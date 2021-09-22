using MarsRover.Commands;
using System;
using System.Linq;

namespace MarsRover

{
    public class MarsRover
    {
        private readonly string _initialState;
        private Rover _rover;
        private ICommand _command;

        public MarsRover(string initialState)
        {            
            this._initialState = initialState;                        
        }


        public string Execute(string inputCommands)
        {
            _rover = RoverFactory.CreateRover(_initialState);

            var charCommans = inputCommands.ToCharArray().ToList();            

            charCommans.ForEach(character => {

            _command = CommandFactory.CreateCommand(character);
            _rover = _rover.Apply(_command);

            });
            
            return _rover.PrintState();
        }

        
    }
}
