using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public partial class Form1 : Form
    {

        Shapes shapes;
        Bitmap canvasBitmap = new Bitmap(500, 300);

        public Form1()
        {
            InitializeComponent();
            shapes = new Shapes(Graphics.FromImage(canvasBitmap));
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

                if (command.Equals("reset") == true)
                {
                    shapes.resetCanvas();
                }
                else if (command.Equals("clear") == true)
                {
                    shapes.clearCanvas();

                }
                else if (command.Equals("pen red") == true)
                {
                    shapes.redPen();
                }
                inputTextbox.Text = "";
                Refresh();
            }
        }

        private void outputCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(canvasBitmap, 0, 0);
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