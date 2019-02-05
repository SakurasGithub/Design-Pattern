using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Jump:Command
{
    public Jump(GameObject actor) : base(actor) { }

    public override void execute()
    {
        base.execute();
        _actor.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, DataBase.JumpForce));
    }
}
