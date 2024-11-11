using System;
using System.Collections;
using UnityEngine;

namespace ObstacleSystem
{
    public class ObstacleDestroy : MonoBehaviour
    {
        [SerializeField] private ParticleSystem destroyParticles;
        [SerializeField] private float destroyParticlesSeconds;
        [SerializeField] private GameObject model;
        [SerializeField] private ObstacleEventCaller eventCaller;
        
        private ObstaclesCollision obstaclesCollission;
        private Coroutine _destroyCoroutine;
        
        private void OnEnable()
        {
            obstaclesCollission ??= GetComponent<ObstaclesCollision>();
            model.gameObject.SetActive(true);
        }

        public void DestroyObstacle()
        {
            if(_destroyCoroutine != null)
                StopCoroutine(_destroyCoroutine);

            _destroyCoroutine = StartCoroutine(DestroyObstacleCoroutine());
        }

        private IEnumerator DestroyObstacleCoroutine()
        {
            model.gameObject.SetActive(false);
            destroyParticles.Play();
            obstaclesCollission.SetCanTrigger(false);
            yield return new WaitForSeconds(destroyParticlesSeconds);
            eventCaller.HandleEvent();
        }
    }
}
