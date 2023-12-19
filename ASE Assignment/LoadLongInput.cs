using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assignment
{
    internal class LoadLongInput
    {
        public static void LoadLongCommands(RichTextBox longInputTextbox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                longInputTextbox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
