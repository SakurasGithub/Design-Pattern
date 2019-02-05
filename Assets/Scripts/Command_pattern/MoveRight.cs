using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Command_pattern
{
    public class MoveRight:Command
    {
        public MoveRight(GameObject actor) : base(actor) { }
        public override void execute()
        {
            base.execute();
            _actor.GetComponent<Transform>().Translate(new Vector3(DataBase.MoveSpeed * Time.deltaTime, 0, 0));
        }

        public override void undo()
        {
            base.undo();
            Debug.Log("向左移");
        }
    }
}
