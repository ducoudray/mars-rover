using MarsRover.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{    
    class Rover
     {

        private readonly Position _position;
        private readonly IDirection _direction;
        public Rover(Position position, IDirection direction)
        {
            _position = position;
            _direction = direction;
        }

        public Rover TurnRigh()
        {
            var turnRighCommand = new TurnRightCommand();
            return Apply(turnRighCommand);
        }
        public Rover TurnLeft()
        {
            var turnLeftCommand = new TurnLeftCommand();
            return Apply(turnLeftCommand);
        }

        public Rover MoveForward()
        {
            var moveForwardCommand = new MoveForwardCommand();
            return Apply(moveForwardCommand);
        }

        public string PrintState()
        {
            return $"{_position.X} {_position.Y} {_direction.AsString()}";
        }

        public Rover Apply(ICommand command)
        {
            return ApplyCommand((dynamic)command);
        }

        private Rover ApplyCommand(TurnLeftCommand command)
        {
            return new Rover(_position, _direction.ToLeft());
        }
        private Rover ApplyCommand(MoveForwardCommand command) 
        {
            return new Rover(_direction.MoveForward(_position), _direction);
        }
        private Rover ApplyCommand(TurnRightCommand command)
        {
            return new Rover(_position, _direction.ToRight());
        }
    }
}
