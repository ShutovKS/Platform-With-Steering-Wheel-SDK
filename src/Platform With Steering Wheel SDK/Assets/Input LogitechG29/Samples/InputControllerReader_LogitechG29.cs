using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputTest", menuName = "Input/InputControllerLogitechG29Reader")]
public class InputControllerReader_LogitechG29 : ScriptableObject,
    InputController_LogitechG29.IButtonsActions,
    InputController_LogitechG29.IHandbrakeActions,
    InputController_LogitechG29.IPedalsActions,
    InputController_LogitechG29.ISteeringwheelActions,
    InputController_LogitechG29.ITransmissionActions
{
    [SerializeField] private bool _isDebugMode;
    private InputController_LogitechG29 _input;

    private void OnEnable()
    {
        _input = new InputController_LogitechG29();
        _input.Buttons.SetCallbacks(this);
        _input.Handbrake.SetCallbacks(this);
        _input.Pedals.SetCallbacks(this);
        _input.Steeringwheel.SetCallbacks(this);
        _input.Transmission.SetCallbacks(this);

        _input.Buttons.Enable();
        _input.Handbrake.Enable();
        _input.Pedals.Enable();
        _input.Steeringwheel.Enable();
        _input.Transmission.Enable();

        RegisterDebugOnActions();
    }

    private void OnDisable()
    {
        _input.Buttons.SetCallbacks(null);
        _input.Handbrake.SetCallbacks(null);
        _input.Pedals.SetCallbacks(null);
        _input.Steeringwheel.SetCallbacks(null);
        _input.Transmission.SetCallbacks(null);

        UnRegisterDebugOnActions();
    }

    private void RegisterDebugOnActions()
    {
        OnNorthButtonCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnNorthButtonCallback: " + value);
            }
        };
        OnSouthButtonCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnSouthButtonCallback: " + value);
            }
        };
        OnEastButtonCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnEastButtonCallback: " + value);
            }
        };
        OnWestButtonCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnWestButtonCallback: " + value);
            }
        };
        OnRightBumperCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnRightBumperCallback: " + value);
            }
        };
        OnLeftBumperCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnLeftBumperCallback: " + value);
            }
        };
        OnRightShiftCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnRightShiftCallback: " + value);
            }
        };
        OnLeftShiftCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnLeftShiftCallback: " + value);
            }
        };
        OnShareCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnShareCallback: " + value);
            }
        };
        OnOptionsCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnOptionsCallback: " + value);
            }
        };
        OnHomeCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnHomeCallback: " + value);
            }
        };
        OnRightStickButtonCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnRightStickButtonCallback: " + value);
            }
        };
        OnLeftStickButtonCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnLeftStickButtonCallback: " + value);
            }
        };
        OnPlusCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnPlusCallback: " + value);
            }
        };
        OnMinusCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnMinusCallback: " + value);
            }
        };
        OnRightTurnCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnRightTurnCallback: " + value);
            }
        };
        OnLeftTurnCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnLeftTurnCallback: " + value);
            }
        };
        OnReturnCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("OnReturnCallback: " + value);
            }
        };

        HatSwitchCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("HatSwitchCallback: " + value);
            }
        };

        Shifter1Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter1Callback: " + value);
            }
        };
        Shifter2Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter2Callback: " + value);
            }
        };
        Shifter3Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter3Callback: " + value);
            }
        };
        Shifter4Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter4Callback: " + value);
            }
        };
        Shifter5Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter5Callback: " + value);
            }
        };
        Shifter6Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter6Callback: " + value);
            }
        };
        Shifter7Callback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("Shifter7Callback: " + value);
            }
        };

        SteeringCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("SteeringCallback: " + value);
            }
        };
        ThrottleCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("ThrottleCallback: " + value);
            }
        };
        BrakeCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("BrakeCallback: " + value);
            }
        };
        ClutchCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("ClutchCallback: " + value);
            }
        };

        HandbrakeCallback = (value) =>
        {
            if (_isDebugMode)
            {
                Debug.Log("HandbrakeCallback: " + value);
            }
        };
    }

    private void UnRegisterDebugOnActions()
    {
        OnNorthButtonCallback = default;
        OnSouthButtonCallback = default;
        OnEastButtonCallback = default;
        OnWestButtonCallback = default;
        OnRightBumperCallback = default;
        OnLeftBumperCallback = default;
        OnRightShiftCallback = default;
        OnLeftShiftCallback = default;
        OnShareCallback = default;
        OnOptionsCallback = default;
        OnHomeCallback = default;
        OnRightStickButtonCallback = default;
        OnLeftStickButtonCallback = default;
        OnPlusCallback = default;
        OnMinusCallback = default;
        OnRightTurnCallback = default;
        OnLeftTurnCallback = default;
        OnReturnCallback = default;

        HatSwitchCallback = default;

        Shifter1Callback = default;
        Shifter2Callback = default;
        Shifter3Callback = default;
        Shifter4Callback = default;
        Shifter5Callback = default;
        Shifter6Callback = default;
        Shifter7Callback = default;

        SteeringCallback = default;
        ThrottleCallback = default;
        BrakeCallback = default;
        ClutchCallback = default;

        HandbrakeCallback = default;
    }

#region Values

    public bool NorthButton { get; private set; }
    public bool SouthButton { get; private set; }
    public bool EastButton { get; private set; }
    public bool WestButton { get; private set; }
    public bool RightBumper { get; private set; }
    public bool LeftBumper { get; private set; }
    public bool RightShift { get; private set; }
    public bool LeftShift { get; private set; }
    public bool Share { get; private set; }
    public bool Options { get; private set; }
    public bool Home { get; private set; }
    public bool RightStickButton { get; private set; }
    public bool LeftStickButton { get; private set; }
    public bool Plus { get; private set; }
    public bool Minus { get; private set; }
    public bool RightTurn { get; private set; }
    public bool LeftTurn { get; private set; }
    public bool Return { get; private set; }

    public Vector2 HatSwitch { get; private set; }

    public bool Shifter1 { get; private set; }
    public bool Shifter2 { get; private set; }
    public bool Shifter3 { get; private set; }
    public bool Shifter4 { get; private set; }
    public bool Shifter5 { get; private set; }
    public bool Shifter6 { get; private set; }
    public bool Shifter7 { get; private set; }

    public float Steering { get; private set; }
    public float Throttle { get; private set; }
    public float Brake { get; private set; }
    public float Clutch { get; private set; }

    public float Handbrake { get; private set; }

#endregion

#region Actions

    public Action<bool> OnNorthButtonCallback;
    public Action<bool> OnSouthButtonCallback;
    public Action<bool> OnEastButtonCallback;
    public Action<bool> OnWestButtonCallback;
    public Action<bool> OnRightBumperCallback;
    public Action<bool> OnLeftBumperCallback;
    public Action<bool> OnRightShiftCallback;
    public Action<bool> OnLeftShiftCallback;
    public Action<bool> OnShareCallback;
    public Action<bool> OnOptionsCallback;
    public Action<bool> OnHomeCallback;
    public Action<bool> OnRightStickButtonCallback;
    public Action<bool> OnLeftStickButtonCallback;
    public Action<bool> OnPlusCallback;
    public Action<bool> OnMinusCallback;
    public Action<bool> OnRightTurnCallback;
    public Action<bool> OnLeftTurnCallback;
    public Action<bool> OnReturnCallback;

    public Action<Vector2> HatSwitchCallback;

    public Action<bool> Shifter1Callback;
    public Action<bool> Shifter2Callback;
    public Action<bool> Shifter3Callback;
    public Action<bool> Shifter4Callback;
    public Action<bool> Shifter5Callback;
    public Action<bool> Shifter6Callback;
    public Action<bool> Shifter7Callback;

    public Action<float> SteeringCallback;
    public Action<float> ThrottleCallback;
    public Action<float> BrakeCallback;
    public Action<float> ClutchCallback;

    public Action<float> HandbrakeCallback;

#endregion

#region Handlers

    public void OnDpad(InputAction.CallbackContext context)
    {
        HatSwitch = context.ReadValue<Vector2>();
        HatSwitchCallback?.Invoke(HatSwitch);
    }

    public void OnHome(InputAction.CallbackContext context)
    {
        Home = context.ReadValueAsButton();
        OnHomeCallback?.Invoke(Home);
    }

    public void OnEast(InputAction.CallbackContext context)
    {
        EastButton = context.ReadValueAsButton();
        OnEastButtonCallback?.Invoke(EastButton);
    }

    public void OnLeftBumper(InputAction.CallbackContext context)
    {
        LeftBumper = context.ReadValueAsButton();
        OnLeftBumperCallback?.Invoke(LeftBumper);
    }

    public void OnRightBumper(InputAction.CallbackContext context)
    {
        RightBumper = context.ReadValueAsButton();
        OnRightBumperCallback?.Invoke(RightBumper);
    }

    public void OnLeftShift(InputAction.CallbackContext context)
    {
        LeftShift = context.ReadValueAsButton();
        OnLeftShiftCallback?.Invoke(LeftShift);
    }

    public void OnRightStick(InputAction.CallbackContext context)
    {
        RightStickButton = context.ReadValueAsButton();
        OnRightStickButtonCallback?.Invoke(RightStickButton);
    }

    public void OnLeftStick(InputAction.CallbackContext context)
    {
        LeftStickButton = context.ReadValueAsButton();
        OnLeftStickButtonCallback?.Invoke(LeftStickButton);
    }

    public void OnLeftTurn(InputAction.CallbackContext context)
    {
        LeftTurn = context.ReadValueAsButton();
        OnLeftTurnCallback?.Invoke(LeftTurn);
    }

    public void OnRightTurn(InputAction.CallbackContext context)
    {
        RightTurn = context.ReadValueAsButton();
        OnRightTurnCallback?.Invoke(RightTurn);
    }

    public void OnRightShift(InputAction.CallbackContext context)
    {
        RightShift = context.ReadValueAsButton();
        OnRightShiftCallback?.Invoke(RightShift);
    }

    public void OnMinus(InputAction.CallbackContext context)
    {
        Minus = context.ReadValueAsButton();
        OnMinusCallback?.Invoke(Minus);
    }

    public void OnNorth(InputAction.CallbackContext context)
    {
        NorthButton = context.ReadValueAsButton();
        OnNorthButtonCallback?.Invoke(NorthButton);
    }

    public void OnOptions(InputAction.CallbackContext context)
    {
        Options = context.ReadValueAsButton();
        OnOptionsCallback?.Invoke(Options);
    }

    public void OnPlus(InputAction.CallbackContext context)
    {
        Plus = context.ReadValueAsButton();
        OnPlusCallback?.Invoke(Plus);
    }

    public void OnReturn(InputAction.CallbackContext context)
    {
        Return = context.ReadValueAsButton();
        OnReturnCallback?.Invoke(Return);
    }

    public void OnShare(InputAction.CallbackContext context)
    {
        Share = context.ReadValueAsButton();
        OnShareCallback?.Invoke(Share);
    }

    public void OnShifter1(InputAction.CallbackContext context)
    {
        Shifter1 = context.ReadValueAsButton();
        Shifter1Callback?.Invoke(Shifter1);
    }

    public void OnShifter2(InputAction.CallbackContext context)
    {
        Shifter2 = context.ReadValueAsButton();
        Shifter2Callback?.Invoke(Shifter2);
    }

    public void OnShifter3(InputAction.CallbackContext context)
    {
        Shifter3 = context.ReadValueAsButton();
        Shifter3Callback?.Invoke(Shifter3);
    }

    public void OnShifter4(InputAction.CallbackContext context)
    {
        Shifter4 = context.ReadValueAsButton();
        Shifter4Callback?.Invoke(Shifter4);
    }

    public void OnShifter5(InputAction.CallbackContext context)
    {
        Shifter5 = context.ReadValueAsButton();
        Shifter5Callback?.Invoke(Shifter5);
    }

    public void OnShifter6(InputAction.CallbackContext context)
    {
        Shifter6 = context.ReadValueAsButton();
        Shifter6Callback?.Invoke(Shifter6);
    }

    public void OnShifter7(InputAction.CallbackContext context)
    {
        Shifter7 = context.ReadValueAsButton();
        Shifter7Callback?.Invoke(Shifter7);
    }

    public void OnSouth(InputAction.CallbackContext context)
    {
        SouthButton = context.ReadValueAsButton();
        OnSouthButtonCallback?.Invoke(SouthButton);
    }

    public void OnWest(InputAction.CallbackContext context)
    {
        WestButton = context.ReadValueAsButton();
        OnWestButtonCallback?.Invoke(WestButton);
    }

    public void OnThrottle(InputAction.CallbackContext context)
    {
        Throttle = context.ReadValue<float>();
        ThrottleCallback?.Invoke(Throttle);
    }

    public void OnClutch(InputAction.CallbackContext context)
    {
        Clutch = context.ReadValue<float>();
        ClutchCallback?.Invoke(Clutch);
    }

    public void OnBrake(InputAction.CallbackContext context)
    {
        Brake = context.ReadValue<float>();
        BrakeCallback?.Invoke(Brake);
    }

    public void OnSteering_Steering(InputAction.CallbackContext context)
    {
        Steering = context.ReadValue<float>();
        SteeringCallback?.Invoke(Steering);
    }

    public void OnSteering_Stick(InputAction.CallbackContext context)
    {
        Steering = context.ReadValue<float>();
        SteeringCallback?.Invoke(Steering);
    }


    public void OnHandbrake(InputAction.CallbackContext context)
    {
        Handbrake = context.ReadValue<float>();
        HandbrakeCallback?.Invoke(Handbrake);
    }

#endregion
}