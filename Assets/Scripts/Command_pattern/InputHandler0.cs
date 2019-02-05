using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler0 {
    private GameObject _actor;
    public InputHandler0(GameObject actor)
    {
        _actor = actor;
    }
    public void HandleInput()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _actor.GetComponent<Transform>().Translate(new Vector3(-DataBase.MoveSpeed* Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            _actor.GetComponent<Transform>().Translate(new Vector3(DataBase.MoveSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _actor.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, DataBase.JumpForce));
        }
    }
}
