using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class East : IDirection
    {
        public string AsString()
        {
            return "E";
        }

        public Position MoveForward(Position position)
        {            
            return new Position(position.X + 1, position.Y);
        }

        public IDirection ToLeft()
        {
            return new North();
        }

        public IDirection ToRight()
        {
            return new South();
        }
    }
}
