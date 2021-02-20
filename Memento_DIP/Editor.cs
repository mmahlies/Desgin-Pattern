using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_DIP
{
    public class Editor
    {
        private string Text { get; set; }
        private int SelectionWidth { get; set; }

        public void SetText(string text)
        {
            Text = text;
        }
        public void SetSelectionWidth(int width)
        {
            SelectionWidth= width;
        }

        public SnapShot CreateSnapShot()
        {
            return new SnapShot(this, this.Text, this.SelectionWidth);
        }
        // Memento Class 
        // Memento is an immutable object; that's why the
        // originator passes its state to the memento's
        // constructor parameters.
        public class SnapShot
        {
            private Editor editor;
            private string Text { get; set; }
            private int SelectionWidth { get; set; }
            public SnapShot(Editor editor, string text, int selectionWidth)
            {
                this.editor = editor;
                this.Text = text;
                this.SelectionWidth = selectionWidth;
            }

            void Restore()
            {
                editor.SetText(this.Text);
                editor.SetSelectionWidth(this.SelectionWidth);
            }
        }

        public class ChangesHistory
        {
            public Stack<Editor.SnapShot> _snapShots { get; set; }
        }
    }
}
