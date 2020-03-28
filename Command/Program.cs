using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;
namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommand pasteCommand = new PasteCommand(new object(), "required text", 5);
            CommandManager commandManager = CommandManager.GetInistance();
            commandManager.InvokeCommand(pasteCommand);
            // or pasteCommand.Execute();

            List<PasteCommand> ps = new List<PasteCommand>();
            ps.Where(w => w.Cats.Exists(q => q.Name == "")).First();

        }
    }
}
