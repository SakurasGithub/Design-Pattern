using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class Move:Command
{
    public Move(GameObject actor) : base(actor) { }
    public override void execute()
    {
        base.execute();
        if (Input.GetKey(KeyCode.A))
        {
            _actor.GetComponent<Transform>().Translate(new Vector3(-DataBase.MoveSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            _actor.GetComponent<Transform>().Translate(new Vector3(DataBase.MoveSpeed * Time.deltaTime, 0, 0));
        }
    }
}
