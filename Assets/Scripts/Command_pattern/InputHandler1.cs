using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Command_pattern;
using UnityEngine;

public class InputHandler1 {
    private GameObject _actor;
    private Command _buttonA;
    private Command _buttonD;
    private Command _buttonW;

    public InputHandler1(GameObject actor)
    {
        _actor = actor;
    }
    public void bindCommand()
    {
        _buttonA = new MoveLeft(_actor);
        _buttonD = new MoveRight(_actor);
        _buttonW = new Jump(_actor);
    }
    public void HandleInput()
    {
        if (Input.GetKey(KeyCode.A))
            _buttonA.execute();
        if (Input.GetKey(KeyCode.D))
            _buttonD.execute();
        if (Input.GetKeyDown(KeyCode.W))
            _buttonW.execute();
    }
	
}
