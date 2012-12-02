using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern1
{
    class cRemote
    {

        Commands[] onCommands;
        Commands[] offCommands;

        public cRemote( int numButtons)
        {
            onCommands = new Commands[numButtons];
            offCommands = new Commands[numButtons];

            Commands doNothing = new noCommand();
            for (int i = 0; i < numButtons; i++)
            {
                onCommands[i] = doNothing;
                offCommands[i] = doNothing;
            }

        }

        public void setCommand(Commands myOnCommand, Commands myOffCommand, int slotNum)
        {
            onCommands[slotNum] = myOnCommand;
            offCommands[slotNum] = myOffCommand;
        }

        public void onButtonPressed(int slotNum)
        {
            onCommands[slotNum].execute();
        }

        public void offButtonPressed(int slotNum)
        {
            offCommands[slotNum].execute();
        }
    }
}
