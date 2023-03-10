//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Data/Controllers/GameInput.inputactions
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

public partial class @GameInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""aa76d8cc-da68-4a5a-881a-7d89cec6db77"",
            ""actions"": [
                {
                    ""name"": ""AxesMovement"",
                    ""type"": ""Value"",
                    ""id"": ""70f83dd9-c37d-4370-ad73-ce5eecbd2a3c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookAroundDelta"",
                    ""type"": ""Value"",
                    ""id"": ""01a43dc2-226f-4ed2-9c82-bc19aab39c4c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AnyAccelerationUp"",
                    ""type"": ""Button"",
                    ""id"": ""027f2132-5448-4f8e-8067-099cd2cb66eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AnyAccelerationDown"",
                    ""type"": ""Button"",
                    ""id"": ""003113a4-4137-41c4-8229-01eae5e98e2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleCamera"",
                    ""type"": ""Button"",
                    ""id"": ""ee7dba56-1598-4c27-a6fd-530473ad4c9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scrolling/Zooming"",
                    ""type"": ""Value"",
                    ""id"": ""272d3fb6-668f-4e6a-99db-5d9232bd75fa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""EscapeButton"",
                    ""type"": ""Button"",
                    ""id"": ""76443f27-97ab-437a-b79d-e1deed848720"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionButton"",
                    ""type"": ""Button"",
                    ""id"": ""8cbcb847-5c87-4879-a009-9b4e2ea9bca1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleCheatField"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7a5ce41f-21f5-46da-884f-b42d184d2064"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RestartLevelUp"",
                    ""type"": ""Button"",
                    ""id"": ""0ff64064-31ec-41dd-a110-32bd68d97d08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RestartLevelDown"",
                    ""type"": ""Button"",
                    ""id"": ""545d332a-67f9-42c3-81ee-3f75b1df3343"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootTheArrow"",
                    ""type"": ""Button"",
                    ""id"": ""ca644c8f-2d3d-4b5e-b2a6-01227e2e24f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BuyUpgrade"",
                    ""type"": ""Button"",
                    ""id"": ""87e4c0c0-4c2a-4589-934f-33fe14460056"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""782a0593-16e2-48f6-90d5-902abbc73bd6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxesMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a0a3441d-0506-44ce-a85c-ac542bfdbe39"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxesMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""54f1009a-0b61-467b-a310-74aeebb158a7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxesMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""faf2458a-7fbc-48fd-b280-7981bd28d50a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxesMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3c55d87f-a673-45cb-8767-43c249806e12"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxesMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ac17bba5-fea7-4a9f-bdca-03169aafd0d6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAroundDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c558218-155b-4e7b-b3f3-1b4c4d8d89a0"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyAccelerationUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4563716d-9c4a-441b-9974-945b1741f2ab"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EscapeButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""451036f9-8ce5-4eb7-be24-46c737333b4d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b003e23a-849f-4f7f-b840-53c6a82964f9"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleCheatField"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e39015c6-6f03-43be-b0b0-6c8f927f2e8f"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40ab6b40-d0c2-40c9-8250-2cfbd35d644e"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scrolling/Zooming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""324d0648-05f1-4bc6-ac76-718376640d17"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyAccelerationDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""053abb98-1975-4bf3-8634-6a1b33580fdb"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartLevelDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""533cc69c-0558-4d95-baf2-81d2a636df65"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartLevelUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02ec67fe-a4ef-434e-bf26-0ece476f2c2a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootTheArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d75422bf-bd0f-4908-bc19-bbcc1010f0f1"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BuyUpgrade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GUIControls"",
            ""id"": ""7fb08407-be40-460d-814c-4023b47d7643"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""fb38dac1-4889-4455-bf43-307600a56276"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f49bd1d9-2d49-42af-be5e-9d9aad9f5f4d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_AxesMovement = m_PlayerControls.FindAction("AxesMovement", throwIfNotFound: true);
        m_PlayerControls_LookAroundDelta = m_PlayerControls.FindAction("LookAroundDelta", throwIfNotFound: true);
        m_PlayerControls_AnyAccelerationUp = m_PlayerControls.FindAction("AnyAccelerationUp", throwIfNotFound: true);
        m_PlayerControls_AnyAccelerationDown = m_PlayerControls.FindAction("AnyAccelerationDown", throwIfNotFound: true);
        m_PlayerControls_ToggleCamera = m_PlayerControls.FindAction("ToggleCamera", throwIfNotFound: true);
        m_PlayerControls_ScrollingZooming = m_PlayerControls.FindAction("Scrolling/Zooming", throwIfNotFound: true);
        m_PlayerControls_EscapeButton = m_PlayerControls.FindAction("EscapeButton", throwIfNotFound: true);
        m_PlayerControls_ActionButton = m_PlayerControls.FindAction("ActionButton", throwIfNotFound: true);
        m_PlayerControls_ToggleCheatField = m_PlayerControls.FindAction("ToggleCheatField", throwIfNotFound: true);
        m_PlayerControls_RestartLevelUp = m_PlayerControls.FindAction("RestartLevelUp", throwIfNotFound: true);
        m_PlayerControls_RestartLevelDown = m_PlayerControls.FindAction("RestartLevelDown", throwIfNotFound: true);
        m_PlayerControls_ShootTheArrow = m_PlayerControls.FindAction("ShootTheArrow", throwIfNotFound: true);
        m_PlayerControls_BuyUpgrade = m_PlayerControls.FindAction("BuyUpgrade", throwIfNotFound: true);
        // GUIControls
        m_GUIControls = asset.FindActionMap("GUIControls", throwIfNotFound: true);
        m_GUIControls_Newaction = m_GUIControls.FindAction("New action", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_AxesMovement;
    private readonly InputAction m_PlayerControls_LookAroundDelta;
    private readonly InputAction m_PlayerControls_AnyAccelerationUp;
    private readonly InputAction m_PlayerControls_AnyAccelerationDown;
    private readonly InputAction m_PlayerControls_ToggleCamera;
    private readonly InputAction m_PlayerControls_ScrollingZooming;
    private readonly InputAction m_PlayerControls_EscapeButton;
    private readonly InputAction m_PlayerControls_ActionButton;
    private readonly InputAction m_PlayerControls_ToggleCheatField;
    private readonly InputAction m_PlayerControls_RestartLevelUp;
    private readonly InputAction m_PlayerControls_RestartLevelDown;
    private readonly InputAction m_PlayerControls_ShootTheArrow;
    private readonly InputAction m_PlayerControls_BuyUpgrade;
    public struct PlayerControlsActions
    {
        private @GameInput m_Wrapper;
        public PlayerControlsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @AxesMovement => m_Wrapper.m_PlayerControls_AxesMovement;
        public InputAction @LookAroundDelta => m_Wrapper.m_PlayerControls_LookAroundDelta;
        public InputAction @AnyAccelerationUp => m_Wrapper.m_PlayerControls_AnyAccelerationUp;
        public InputAction @AnyAccelerationDown => m_Wrapper.m_PlayerControls_AnyAccelerationDown;
        public InputAction @ToggleCamera => m_Wrapper.m_PlayerControls_ToggleCamera;
        public InputAction @ScrollingZooming => m_Wrapper.m_PlayerControls_ScrollingZooming;
        public InputAction @EscapeButton => m_Wrapper.m_PlayerControls_EscapeButton;
        public InputAction @ActionButton => m_Wrapper.m_PlayerControls_ActionButton;
        public InputAction @ToggleCheatField => m_Wrapper.m_PlayerControls_ToggleCheatField;
        public InputAction @RestartLevelUp => m_Wrapper.m_PlayerControls_RestartLevelUp;
        public InputAction @RestartLevelDown => m_Wrapper.m_PlayerControls_RestartLevelDown;
        public InputAction @ShootTheArrow => m_Wrapper.m_PlayerControls_ShootTheArrow;
        public InputAction @BuyUpgrade => m_Wrapper.m_PlayerControls_BuyUpgrade;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @AxesMovement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAxesMovement;
                @AxesMovement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAxesMovement;
                @AxesMovement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAxesMovement;
                @LookAroundDelta.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLookAroundDelta;
                @LookAroundDelta.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLookAroundDelta;
                @LookAroundDelta.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLookAroundDelta;
                @AnyAccelerationUp.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnyAccelerationUp;
                @AnyAccelerationUp.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnyAccelerationUp;
                @AnyAccelerationUp.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnyAccelerationUp;
                @AnyAccelerationDown.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnyAccelerationDown;
                @AnyAccelerationDown.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnyAccelerationDown;
                @AnyAccelerationDown.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnyAccelerationDown;
                @ToggleCamera.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnToggleCamera;
                @ToggleCamera.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnToggleCamera;
                @ToggleCamera.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnToggleCamera;
                @ScrollingZooming.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScrollingZooming;
                @ScrollingZooming.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScrollingZooming;
                @ScrollingZooming.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScrollingZooming;
                @EscapeButton.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEscapeButton;
                @EscapeButton.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEscapeButton;
                @EscapeButton.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEscapeButton;
                @ActionButton.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActionButton;
                @ActionButton.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActionButton;
                @ActionButton.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActionButton;
                @ToggleCheatField.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnToggleCheatField;
                @ToggleCheatField.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnToggleCheatField;
                @ToggleCheatField.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnToggleCheatField;
                @RestartLevelUp.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRestartLevelUp;
                @RestartLevelUp.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRestartLevelUp;
                @RestartLevelUp.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRestartLevelUp;
                @RestartLevelDown.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRestartLevelDown;
                @RestartLevelDown.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRestartLevelDown;
                @RestartLevelDown.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRestartLevelDown;
                @ShootTheArrow.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShootTheArrow;
                @ShootTheArrow.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShootTheArrow;
                @ShootTheArrow.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShootTheArrow;
                @BuyUpgrade.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBuyUpgrade;
                @BuyUpgrade.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBuyUpgrade;
                @BuyUpgrade.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBuyUpgrade;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AxesMovement.started += instance.OnAxesMovement;
                @AxesMovement.performed += instance.OnAxesMovement;
                @AxesMovement.canceled += instance.OnAxesMovement;
                @LookAroundDelta.started += instance.OnLookAroundDelta;
                @LookAroundDelta.performed += instance.OnLookAroundDelta;
                @LookAroundDelta.canceled += instance.OnLookAroundDelta;
                @AnyAccelerationUp.started += instance.OnAnyAccelerationUp;
                @AnyAccelerationUp.performed += instance.OnAnyAccelerationUp;
                @AnyAccelerationUp.canceled += instance.OnAnyAccelerationUp;
                @AnyAccelerationDown.started += instance.OnAnyAccelerationDown;
                @AnyAccelerationDown.performed += instance.OnAnyAccelerationDown;
                @AnyAccelerationDown.canceled += instance.OnAnyAccelerationDown;
                @ToggleCamera.started += instance.OnToggleCamera;
                @ToggleCamera.performed += instance.OnToggleCamera;
                @ToggleCamera.canceled += instance.OnToggleCamera;
                @ScrollingZooming.started += instance.OnScrollingZooming;
                @ScrollingZooming.performed += instance.OnScrollingZooming;
                @ScrollingZooming.canceled += instance.OnScrollingZooming;
                @EscapeButton.started += instance.OnEscapeButton;
                @EscapeButton.performed += instance.OnEscapeButton;
                @EscapeButton.canceled += instance.OnEscapeButton;
                @ActionButton.started += instance.OnActionButton;
                @ActionButton.performed += instance.OnActionButton;
                @ActionButton.canceled += instance.OnActionButton;
                @ToggleCheatField.started += instance.OnToggleCheatField;
                @ToggleCheatField.performed += instance.OnToggleCheatField;
                @ToggleCheatField.canceled += instance.OnToggleCheatField;
                @RestartLevelUp.started += instance.OnRestartLevelUp;
                @RestartLevelUp.performed += instance.OnRestartLevelUp;
                @RestartLevelUp.canceled += instance.OnRestartLevelUp;
                @RestartLevelDown.started += instance.OnRestartLevelDown;
                @RestartLevelDown.performed += instance.OnRestartLevelDown;
                @RestartLevelDown.canceled += instance.OnRestartLevelDown;
                @ShootTheArrow.started += instance.OnShootTheArrow;
                @ShootTheArrow.performed += instance.OnShootTheArrow;
                @ShootTheArrow.canceled += instance.OnShootTheArrow;
                @BuyUpgrade.started += instance.OnBuyUpgrade;
                @BuyUpgrade.performed += instance.OnBuyUpgrade;
                @BuyUpgrade.canceled += instance.OnBuyUpgrade;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // GUIControls
    private readonly InputActionMap m_GUIControls;
    private IGUIControlsActions m_GUIControlsActionsCallbackInterface;
    private readonly InputAction m_GUIControls_Newaction;
    public struct GUIControlsActions
    {
        private @GameInput m_Wrapper;
        public GUIControlsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_GUIControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_GUIControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GUIControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGUIControlsActions instance)
        {
            if (m_Wrapper.m_GUIControlsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_GUIControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_GUIControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_GUIControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_GUIControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public GUIControlsActions @GUIControls => new GUIControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnAxesMovement(InputAction.CallbackContext context);
        void OnLookAroundDelta(InputAction.CallbackContext context);
        void OnAnyAccelerationUp(InputAction.CallbackContext context);
        void OnAnyAccelerationDown(InputAction.CallbackContext context);
        void OnToggleCamera(InputAction.CallbackContext context);
        void OnScrollingZooming(InputAction.CallbackContext context);
        void OnEscapeButton(InputAction.CallbackContext context);
        void OnActionButton(InputAction.CallbackContext context);
        void OnToggleCheatField(InputAction.CallbackContext context);
        void OnRestartLevelUp(InputAction.CallbackContext context);
        void OnRestartLevelDown(InputAction.CallbackContext context);
        void OnShootTheArrow(InputAction.CallbackContext context);
        void OnBuyUpgrade(InputAction.CallbackContext context);
    }
    public interface IGUIControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
