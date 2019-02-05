using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Command_pattern;
using UnityEngine;

public class PlayerControll:MonoBehaviour{
    ///// <summary>
    ///// 输入和响应硬编码
    ///// </summary>
    //private InputHandler0 _inputHandler0;
    //private void Start()
    //{
    //    _inputHandler0 = new InputHandler0(gameObject);
    //}
    //private void Update()
    //{
    //    _inputHandler0.HandleInput();
    //}

    ///// <summary>
    ///// 输入与响应的关系通过InputHandler里的bindConmmand函数动态绑定
    ///// </summary>
    //private InputHandler1 _inputHandler1;
    //private void Start()
    //{
    //    _inputHandler1 = new InputHandler1(gameObject);
    //    _inputHandler1.bindCommand();
    //}
    //private void Update()
    //{
    //    _inputHandler1.HandleInput();
    //}

    /// <summary>
    /// 将角色与命令解耦
    /// </summary>
    private InputHandler2 _inputHandler2;
    private Command _command;
    private void Start()
    {
        _inputHandler2 = new InputHandler2(gameObject);
        _inputHandler2.bindCommand();
    }
    private void Update()
    {
        _command = _inputHandler2.handleInput();
        if (_command != null)
        {
            _command.execute();
            CommmandRec.AddCom(_command);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            CommmandRec.Back().undo();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            CommmandRec.Forward().execute();
        }
    }

}
