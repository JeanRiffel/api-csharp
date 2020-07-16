using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{

    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command {Id =0, HowTo="Boil and egg", Line="Boil Water", Platform="Kettle"  },
                new Command {Id =1, HowTo="Cut Bread", Line="Boil Water", Platform="Kettle"  },
                new Command {Id =2, HowTo="Make a cup of tea", Line="Boil Water", Platform="Kettle"  }    
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id =0, HowTo="Boil and egg", Line="Boil Water", Platform="Kettle"  };
        }
    }

}