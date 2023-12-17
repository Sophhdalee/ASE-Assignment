using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public partial class Form1 : Form
    {

        Shapes shapes;
        Bitmap imageoutput = new Bitmap(500, 300);

        public Form1()
        {
            InitializeComponent();
            shapes = new Shapes(Graphics.FromImage(imageoutput));
        }

        private void programInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String command;
                command = inputTextbox.Text.ToLower().Trim();


                switch (command)
                {
                    case "reset":
                        shapes.resetCanvas();
                        break;

                    case "red pen":
                        shapes.redPen();
                        break;

                    case "clear":
 
                        shapes.clearCanvas();
                        break;

                    default:
 
                    Parser.Method(command, shapes);
                     break;
                }

                inputTextbox.Text = "";
                Refresh();
            }
        }

        private void outputCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(imageoutput, 0, 0);
        }

        private void commandLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void commandLine_MouseClick(object sender, MouseEventArgs e)
        {
            inputTextbox.Text = "";
        }

        private void textboxToShowFill_Click(object sender, EventArgs e)
        {

        }

        private void buttonToLoad_Click(object sender, EventArgs e)
        {

        }
    }
}