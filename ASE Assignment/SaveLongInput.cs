using System.Windows.Forms;

namespace ASE_Assignment
{
    /// <summary>
    /// This class is responsible for saving the content of a RichTextBox to a text file
    /// </summary>
    internal class SaveLongInput
    {
        // Method to save the content of a RichTextBox to a text file
        public static void SaveLongCommands(RichTextBox longInputTextbox)
        {
         // Create a SaveFileDialog to allow the user to choose the file location and name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
         // Set the default file extension to .txt
            saveFileDialog.DefaultExt = "*.txt";
         // Set the filter to show only .txt files in the file dialog
            saveFileDialog.Filter = "TXT Files|*.txt";
         // check if user selected a file and clicked ok
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFileDialog.FileName.Length > 0)
            {
                // save the file content of the textbox
                longInputTextbox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

    }
}
