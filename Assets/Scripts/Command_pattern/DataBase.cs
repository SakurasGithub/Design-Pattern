using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class DataBase{
    static private float _moveSpeed=5;
    static private float _jumpForce=500;
    static public float MoveSpeed { get { return _moveSpeed; } }
    static public float JumpForce { get { return _jumpForce; } }
}
