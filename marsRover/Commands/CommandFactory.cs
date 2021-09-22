using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Commands
{
    class CommandFactory
    {
        public CommandFactory()
        {

        }

        public static ICommand CreateCommand(char command)
        {
            return command switch
            {
                'M' => new MoveForwardCommand(),
                'R' => new TurnRightCommand(),
                'L' => new TurnLeftCommand(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
