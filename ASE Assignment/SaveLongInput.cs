using System.Windows.Forms;

namespace ASE_Assignment
{
    internal class SaveLongInput
    {
        public static void SaveLongCommands(RichTextBox longInputTextbox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "TXT Files|*.txt";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFileDialog.FileName.Length > 0)
            {
                longInputTextbox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

    }
}
