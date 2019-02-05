using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

 public class Command
{
    protected GameObject _actor;
    public Command(GameObject actor)
    {
        _actor = actor;
    }
    virtual public void execute() { }
    virtual public void undo() { }
}
