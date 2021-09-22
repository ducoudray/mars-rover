using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class DirectionFactory
    {
        public DirectionFactory()
        {
        }
        public static IDirection CreateDirection(string direction)
        {
            return direction switch
            {
                "N" => new North(),
                "W" => new West(),
                "E" => new East(),
                "S" => new South(),
                _ => throw new NotImplementedException($"Direction {direction} is not implemented yet"),
            };
        }
    }
}
