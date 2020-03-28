using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CommandManager
    {
        private static CommandManager commandManager;
        private CommandManager()
        {

        }

        public static CommandManager GetInistance()
        {
            if (commandManager == null)
            {
                commandManager = new CommandManager();
            }
            return commandManager;
        }

        public void InvokeCommand(ICommand comand)
        {
            comand.Execute();
        }

    }
}
