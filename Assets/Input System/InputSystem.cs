//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input System/InputSystem.inputactions
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

public partial class @InputSystem: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""a86b56e1-b655-4ac9-b95a-3dd4e7bdee3b"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""916a45a6-c1e0-458d-831e-e240ed0fec0b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Duck"",
                    ""type"": ""Value"",
                    ""id"": ""ab22cec0-641e-4c56-a550-f0a0ff03aef9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1.401298E-45)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Value"",
                    ""id"": ""aa9b5651-2ed3-4f48-9348-e2175c166eb9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Value"",
                    ""id"": ""5f6cf082-2e73-4d9d-bbb9-f2ea7d875eb8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57b784eb-f178-4e0d-b49b-4078a58eaedc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6dc9e230-97ff-4768-a75f-5fc47ead6bed"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25efb8a4-d18b-4667-8e7b-83578093c58d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bc55daf-fd65-4f7c-b9ef-2f4722fef47a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Input
        m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
        m_Input_Jump = m_Input.FindAction("Jump", throwIfNotFound: true);
        m_Input_Duck = m_Input.FindAction("Duck", throwIfNotFound: true);
        m_Input_MoveLeft = m_Input.FindAction("MoveLeft", throwIfNotFound: true);
        m_Input_MoveRight = m_Input.FindAction("MoveRight", throwIfNotFound: true);
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

    // Input
    private readonly InputActionMap m_Input;
    private List<IInputActions> m_InputActionsCallbackInterfaces = new List<IInputActions>();
    private readonly InputAction m_Input_Jump;
    private readonly InputAction m_Input_Duck;
    private readonly InputAction m_Input_MoveLeft;
    private readonly InputAction m_Input_MoveRight;
    public struct InputActions
    {
        private @InputSystem m_Wrapper;
        public InputActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Input_Jump;
        public InputAction @Duck => m_Wrapper.m_Input_Duck;
        public InputAction @MoveLeft => m_Wrapper.m_Input_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Input_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void AddCallbacks(IInputActions instance)
        {
            if (instance == null || m_Wrapper.m_InputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InputActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Duck.started += instance.OnDuck;
            @Duck.performed += instance.OnDuck;
            @Duck.canceled += instance.OnDuck;
            @MoveLeft.started += instance.OnMoveLeft;
            @MoveLeft.performed += instance.OnMoveLeft;
            @MoveLeft.canceled += instance.OnMoveLeft;
            @MoveRight.started += instance.OnMoveRight;
            @MoveRight.performed += instance.OnMoveRight;
            @MoveRight.canceled += instance.OnMoveRight;
        }

        private void UnregisterCallbacks(IInputActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Duck.started -= instance.OnDuck;
            @Duck.performed -= instance.OnDuck;
            @Duck.canceled -= instance.OnDuck;
            @MoveLeft.started -= instance.OnMoveLeft;
            @MoveLeft.performed -= instance.OnMoveLeft;
            @MoveLeft.canceled -= instance.OnMoveLeft;
            @MoveRight.started -= instance.OnMoveRight;
            @MoveRight.performed -= instance.OnMoveRight;
            @MoveRight.canceled -= instance.OnMoveRight;
        }

        public void RemoveCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInputActions instance)
        {
            foreach (var item in m_Wrapper.m_InputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InputActions @Input => new InputActions(this);
    public interface IInputActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnDuck(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
}
