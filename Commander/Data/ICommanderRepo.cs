using System.Collections;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommmanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommmandById(int i);

    }
}