namespace MarsRover
{
    public class MarsRover
    {
        private readonly string _initialState;
        private Position _position;
        private IDirection _direction;

        public MarsRover(string initialState)
        {            
            this._initialState = initialState;            
        }


        public string Execute(string command)
        {
            var states = _initialState.Split(" ");
            var x = int.Parse(states[0]);
            var y = int.Parse(states[1]);
            _position = new Position(x, y);

            var directionInput = states[2];
            _direction = DirectionFactory.CreateDirection(directionInput);
            if (command == "M")
            {                
                _position = _direction.MoveForward(_position);
            }            
            if (command == "R")
            {
                _direction = _direction.ToRight();
            }
            if (command == "L")
            {
                _direction = _direction.ToLeft();
            }
            return $"{_position.X} {_position.Y} {_direction.AsString()}";
        }
    }
}
