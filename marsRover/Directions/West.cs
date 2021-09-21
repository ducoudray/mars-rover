using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class West : IDirection
    {
        public string AsString()
        {
            return "W";
        }

        public Position MoveForward(Position position)
        {            
            return new Position(position.X - 1, position.Y);
        }

        public IDirection ToLeft()
        {
            return new South();
        }

        public IDirection ToRight()
        {
            return new North();
        }
    }
}
