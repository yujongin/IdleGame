using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{   
    private Vector2 _moveDir;
    private Define.EJoystickState _joystickState;
    public Vector2 MoveDir
    {
        get { return _moveDir; }
        set
        {
            _moveDir = value;
            OnMoveDirChanged?.Invoke(value);
        }
    }
    public Define.EJoystickState JoystickState{
        get{return _joystickState;}
        set{
            _joystickState = value;
            OnJoystickStateChanged?.Invoke(value);
        }
    }

    public event Action<Vector2>OnMoveDirChanged;
    public event Action<Define.EJoystickState> OnJoystickStateChanged;
}
