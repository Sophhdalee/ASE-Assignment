using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public partial class Form1 : Form
    {
        Bitmap imageoutput = new Bitmap(500, 300);
        Shapes shapes;
        bool shapeFill;



        public Form1()
        {
            InitializeComponent();
            shapes = new Shapes(Graphics.FromImage(imageoutput));
            textboxToShowFill.Text = "Shape fill off";

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
                    case "green pen":
                        shapes.greenPen();
                        break;

                    case "black pen":
                        shapes.blackPen();
                        break;

                    case "yellow pen":
                        shapes.yellowPen();
                        break;
                    case "blue pen":
                        shapes.bluePen();
                        break;

                    case "clear":
                        shapes.clearCanvas();
                        break;


                    case "fill on":
                        shapeFill = true;
                        textboxToShowFill.Text = "Fill shape on";
                        break;

                    case "fill off":
                        shapeFill = false;
                        textboxToShowFill.Text = "Fill shape off";
                        break;

                    default:
                        Parser.Method(command, shapes, shapeFill);
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