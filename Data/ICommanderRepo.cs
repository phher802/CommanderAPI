using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //method signature to provide to consumer on this interface
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);

    }
}