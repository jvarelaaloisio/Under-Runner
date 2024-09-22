using System.Collections;
using System.Diagnostics;
using FSM;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Minion.States
{
    public class MinionMoveController : MinionController
    {
        [SerializeField] private float timeMoving;
        [SerializeField] private float speed;
        [SerializeField] private float minDistance;

        [SerializeField] private MinionAgent minionAgent;

        private Vector3 _dir;
        
        public override void Enter()
        {
            StartCoroutine(HandleChangeState());
        }

        private IEnumerator HandleChangeState()
        {
            yield return new WaitForSeconds(timeMoving);
            minionAgent.ChangeStateToAttack();
        }

        public override void OnUpdate()
        {
            if (Vector3.Distance(transform.position, target.transform.position) < minDistance)
                _dir = transform.position - target.transform.position;
            else
                _dir = target.transform.position - transform.position;
            
            _dir.y = 0;
            transform.Translate(_dir * (speed * Time.deltaTime));
        }

        public override void Exit()
        {
        }
    }
}