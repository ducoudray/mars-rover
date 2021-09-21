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
        public static IDirection CreateDirection( string direction)
        {
            switch (direction)
            {
                case "N":
                    return new North();                                            
                case "W":
                    return new West();                    
                case "E":
                    return new East();
                case "S":
                    return new South();
                default:
                    throw new NotImplementedException($"Direction {direction} is not implemented yet");                    
            }
        }
    }
}
