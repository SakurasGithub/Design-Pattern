using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Command_pattern
{
    static class CommmandRec
    {
        static private List<Command> commandRec=new List<Command>();
        static private int currentCom=-1;
        static public void AddCom(Command com)
        {
            if(currentCom == commandRec.Count-1)
            {
                commandRec.Add(com);
                currentCom++;
            }
            else if(currentCom< commandRec.Count-1)
            {
                if (commandRec[currentCom+1]!=com)
                {
                    commandRec.RemoveRange(currentCom + 1, commandRec.Count - 1 - currentCom);
                    commandRec.Add(com);
                    currentCom++;
                }
            }
        }
        static public Command Back()
        {
            currentCom--;
            return commandRec[currentCom];
        }
        static public Command Forward()
        {
            currentCom++;
            return commandRec[currentCom];
        }
    }
}
