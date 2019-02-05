using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Command_pattern
{
    class InputHandler2
    {
        private GameObject _actor;
        private Command _commandA;
        private Command _commandD;
        private Command _commandW;
        public InputHandler2(GameObject actor)
        {
            _actor = actor;
        }
        public void bindCommand()
        {
            _commandA = new MoveLeft(_actor);
            _commandD = new MoveRight(_actor);
            _commandW = new Jump(_actor);

    }
        public Command handleInput()
        {
            if (Input.GetKey(KeyCode.A))
                return _commandA;
            if (Input.GetKey(KeyCode.D))
                return _commandD;
            if (Input.GetKeyDown(KeyCode.W))
                return _commandW;
            return null;
        }
    }

}
