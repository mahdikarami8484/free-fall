// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GameController/GameInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""TouchInput"",
            ""id"": ""82b7c03a-44fb-4a62-b094-02516bba4e41"",
            ""actions"": [
                {
                    ""name"": ""TouchInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2804eb21-906d-4d9c-bc91-43f4970f8ae0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPress"",
                    ""type"": ""Button"",
                    ""id"": ""6ff02b71-a0d2-4fe7-8181-7bf3daf843b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2176b83b-f742-4b19-a892-68028c5dcda9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a55df6c5-5a41-4e0e-b461-eaad12bfeaf7"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f61f9f22-f51d-4ca9-9f04-1271b5eb5f6c"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""beeb0e1b-b600-4953-8d28-1d3cabf5babf"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerInput"",
            ""id"": ""0014476c-c209-44fb-a5c2-9c23894350ac"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""ec96d8af-be39-463e-a8d7-bbccf0ef8820"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Axis"",
                    ""id"": ""1e4624a8-3b4a-4375-b1c6-6eb35b82b923"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""167f8c23-6764-449e-9d97-e44cdc91b62c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""46623a8b-ed73-44b2-b37b-4390ac21450a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD Axis"",
                    ""id"": ""9a8e87ba-65c2-407c-91a8-12f91c4fecf6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e79fd942-76f7-4a12-bdc7-030712e6cd11"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bb09dab5-f25e-4075-99bb-f56c34f60767"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TouchInput
        m_TouchInput = asset.FindActionMap("TouchInput", throwIfNotFound: true);
        m_TouchInput_TouchInput = m_TouchInput.FindAction("TouchInput", throwIfNotFound: true);
        m_TouchInput_TouchPress = m_TouchInput.FindAction("TouchPress", throwIfNotFound: true);
        m_TouchInput_TouchPosition = m_TouchInput.FindAction("TouchPosition", throwIfNotFound: true);
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_Horizontal = m_PlayerInput.FindAction("Horizontal", throwIfNotFound: true);
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

    // TouchInput
    private readonly InputActionMap m_TouchInput;
    private ITouchInputActions m_TouchInputActionsCallbackInterface;
    private readonly InputAction m_TouchInput_TouchInput;
    private readonly InputAction m_TouchInput_TouchPress;
    private readonly InputAction m_TouchInput_TouchPosition;
    public struct TouchInputActions
    {
        private @GameInputs m_Wrapper;
        public TouchInputActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInput => m_Wrapper.m_TouchInput_TouchInput;
        public InputAction @TouchPress => m_Wrapper.m_TouchInput_TouchPress;
        public InputAction @TouchPosition => m_Wrapper.m_TouchInput_TouchPosition;
        public InputActionMap Get() { return m_Wrapper.m_TouchInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchInputActions set) { return set.Get(); }
        public void SetCallbacks(ITouchInputActions instance)
        {
            if (m_Wrapper.m_TouchInputActionsCallbackInterface != null)
            {
                @TouchInput.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchInput;
                @TouchInput.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchInput;
                @TouchInput.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchInput;
                @TouchPress.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchPress;
                @TouchPress.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchPress;
                @TouchPress.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchPress;
                @TouchPosition.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchPosition;
            }
            m_Wrapper.m_TouchInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchInput.started += instance.OnTouchInput;
                @TouchInput.performed += instance.OnTouchInput;
                @TouchInput.canceled += instance.OnTouchInput;
                @TouchPress.started += instance.OnTouchPress;
                @TouchPress.performed += instance.OnTouchPress;
                @TouchPress.canceled += instance.OnTouchPress;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
            }
        }
    }
    public TouchInputActions @TouchInput => new TouchInputActions(this);

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private IPlayerInputActions m_PlayerInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInput_Horizontal;
    public struct PlayerInputActions
    {
        private @GameInputs m_Wrapper;
        public PlayerInputActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_PlayerInput_Horizontal;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnHorizontal;
            }
            m_Wrapper.m_PlayerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
            }
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    public interface ITouchInputActions
    {
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouchPress(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
    }
    public interface IPlayerInputActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
    }
}
