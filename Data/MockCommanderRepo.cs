using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //this mock repo will not be connected to any database, but for hardcoding data; useful for testing
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pot" },
                new Command { Id = 1, HowTo = "Toast Bagel", Line = "Slice Bagel with knife", Platform = "Knife & Toaster" },
                new Command { Id = 2, HowTo = "Make instant coffee", Line = "Put coffee into cup and add hot water", Platform = "Cup & Kettle" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pot" };
        }
    }
}