namespace MarsRover
{
    internal class South : IDirection
    {
        public string AsString()
        {
            return "S";
        }

        public Position MoveForward(Position position)
        {            
            return new Position(position.X, position.Y - 1);
        }

        public IDirection ToLeft()
        {
            return new East();
        }

        public IDirection ToRight()
        {
            return new West();
        }
    }
}