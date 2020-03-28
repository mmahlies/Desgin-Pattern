using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    class PasteCommand : ICommand
    {
        object document;
        string textToPaste;
        int position;
        public List<Cats> Cats { get; set; }
        public PasteCommand(object document, string text, int position)
        {
            this.document = document;
            this.textToPaste = text;
            this.position = position;
        }
        public void Execute()
        {
           // make execute
        }

        public bool IsAllowUndo()
        {
            throw new NotImplementedException();
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
    class Cats
    {
        public string Name { get; set; }
    }
}
