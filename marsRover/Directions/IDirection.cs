using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    interface IDirection
    {
        Position MoveForward(Position position);
        string AsString();
        IDirection ToRight();
        IDirection ToLeft();
    }
}
