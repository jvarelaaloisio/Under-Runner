//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Dev/UnderRunnerTest/Scripts/DEBUG/Input/DebugActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DebugActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DebugActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugActions"",
    ""maps"": [
        {
            ""name"": ""Cheats"",
            ""id"": ""0b59a3ca-7d31-44d5-a7aa-18ef2d306627"",
            ""actions"": [
                {
                    ""name"": ""Invencibility"",
                    ""type"": ""Button"",
                    ""id"": ""2d8f658d-65a0-4f62-bb0f-514705f0606a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""55d062bf-3654-4118-9d94-f0c2bd00927e"",
                    ""path"": ""<Keyboard>/f9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Invencibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cheats
        m_Cheats = asset.FindActionMap("Cheats", throwIfNotFound: true);
        m_Cheats_Invencibility = m_Cheats.FindAction("Invencibility", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Cheats
    private readonly InputActionMap m_Cheats;
    private List<ICheatsActions> m_CheatsActionsCallbackInterfaces = new List<ICheatsActions>();
    private readonly InputAction m_Cheats_Invencibility;
    public struct CheatsActions
    {
        private @DebugActions m_Wrapper;
        public CheatsActions(@DebugActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Invencibility => m_Wrapper.m_Cheats_Invencibility;
        public InputActionMap Get() { return m_Wrapper.m_Cheats; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CheatsActions set) { return set.Get(); }
        public void AddCallbacks(ICheatsActions instance)
        {
            if (instance == null || m_Wrapper.m_CheatsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CheatsActionsCallbackInterfaces.Add(instance);
            @Invencibility.started += instance.OnInvencibility;
            @Invencibility.performed += instance.OnInvencibility;
            @Invencibility.canceled += instance.OnInvencibility;
        }

        private void UnregisterCallbacks(ICheatsActions instance)
        {
            @Invencibility.started -= instance.OnInvencibility;
            @Invencibility.performed -= instance.OnInvencibility;
            @Invencibility.canceled -= instance.OnInvencibility;
        }

        public void RemoveCallbacks(ICheatsActions instance)
        {
            if (m_Wrapper.m_CheatsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICheatsActions instance)
        {
            foreach (var item in m_Wrapper.m_CheatsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CheatsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CheatsActions @Cheats => new CheatsActions(this);
    public interface ICheatsActions
    {
        void OnInvencibility(InputAction.CallbackContext context);
    }
}