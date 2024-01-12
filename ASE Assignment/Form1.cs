using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASE_Assignment
{
    // Define the Form1 class, inheriting from the Form class
    public partial class Form1 : Form
    {
        // Initialize a Bitmap object for drawing with a size off 500x300
        Bitmap imageoutput = new Bitmap(500, 300);
        // declares shapes objects for handling drawing operations
        Shapes shapes;
        // if shapes should be filled or not 
        bool shapeFill = false;


        // Constructor for Form1
        public Form1()
        {
            InitializeComponent();
            // Initialize the Shapes object with the graphics context from the Bitmap
            shapes = new Shapes(Graphics.FromImage(imageoutput));
            // show in textbox if shape fill is off
            textboxToShowFill.Text = "Shape fill off";

        }

        // Event handler for the KeyDown event of the commandLine textbox
        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {

         // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {

         // Clear any previous syntax error messages
                textboxForSyntaxErrors.Text = "";
                string userInput = inputTextbox.Text.ToLower().Trim();
                string longUserInput = longInputTextbox.Text;

                switch (userInput)
                    {
                        case "reset":
                            shapes.resetCanvas();
                            break;
                    // handles pen commands
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
                    // clear canvas
                        case "clear":
                            shapes.clearCanvas();
                            break;
                    // handles fill on and off commands
                        case "fill on":
                            shapeFill = true;
                            textboxToShowFill.Text = "Fill shape on";
                            break;
                        case "fill off":
                            shapeFill = false;
                            textboxToShowFill.Text = "Fill shape off";
                            break;
                    // error messages for drawing 
                        case "drwato":
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input 2 numbers";
                            break;
                        case "moveto":
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input 2 numbers";
                            break;
                        case "circle":
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input 1 numbers";
                            break;
                        case "rectangle":
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input 2 numbers";
                            break;
                        case "triangle":
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                            break;
                    case "run":
                    // Call a method to process a long input command
                    LongInput.LongInputCommand(longUserInput, shapes, shapeFill, textboxForSyntaxErrors);
                        break;
                    default:
                    // Call a general parser to process commands
                    Parser.ParseCommand(userInput, shapes, shapeFill, textboxForSyntaxErrors);
                            break;
                    }
                
                inputTextbox.Text = "";
                Refresh();
            }
        }
        // Event handler for the Paint event of the outputCanvas
        private void outputCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(imageoutput, 0, 0);
        }

        // Event handler for the MouseClick event of the commandLine textbox
        private void commandLine_MouseClick(object sender, MouseEventArgs e)
        {
            // Clear the input textbox when clicked
            inputTextbox.Text = "";
        }

        // Event handler for the Click event of the buttonToLoad button
        private void buttonToLoad_Click(object sender, EventArgs e)
        {
            LoadLongInput.LoadLongCommands(longInputTextbox);
        }

        // Event handler for the Click event of the buttonToSave button
        private void buttonToSave_Click(object sender, EventArgs e)
        {
            SaveLongInput.SaveLongCommands(longInputTextbox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}