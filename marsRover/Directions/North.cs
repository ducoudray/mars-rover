using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class North : IDirection
    {
        public string AsString()
        {
            return "N";
        }

        public Position MoveForward(Position position)
        {            
            return new Position(position.X, position.Y + 1);
        }

        public IDirection ToLeft()
        {
            return new West();
        }

        public IDirection ToRight()
        {
            return new East();

        }
    }
}
