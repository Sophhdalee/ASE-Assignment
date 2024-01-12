using System;
using System.Windows.Forms;

namespace ASE_Assignment
  /// <Summary>
  /// Parser contains a method for executing drawing commands based on the users input and providing error feedback when required to
  /// <summary>
{
    public class Parser : Form1
    {

        public static void ParseCommand(string userInput, Shapes shapes, bool shapeFill, RichTextBox textboxForSyntaxErrors)
        {
            // Split user input into lowercase words
            string[] splitUserInput = userInput.ToLower().Trim().Split(' ');
            // Checks if user input has 2 elements 
            if (splitUserInput.Length == 2)
            {
            // Split the string by comma seperator based on the length of the string 
                string[] parameter = splitUserInput[1].Split(',');
                int[] numParameter = new int[parameter.Length];
                try
                {
           // Convert parameter strings to integers
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        numParameter[i] = Convert.ToInt32(parameter[i]);
                    }
                }
                catch
                {
                   // Handle invalid parameters when numbers are not entered
                    textboxForSyntaxErrors.Text = "invalid parameters, they must be numbers";
                    return;
                }
                switch (splitUserInput[0])
                {
                    case "drawto":
                    try
                    {
                     // Draw a straight line to certain coordinates
                        shapes.drawstraightLineTo(numParameter[0], numParameter[1]);
                    }
                    catch
                    {

                        textboxForSyntaxErrors.Text = "Incorrect number of params please input 2 numbers";
                        return;
                    }
                    break;

                    case "moveto":
                    try
                    {
                    // Move the pen to certain coordinates
                        shapes.movePenToCoords(numParameter[0], numParameter[1]);
                    }
                    catch
                    {
                        textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                        return;
                    }
                    break;
                    case "rectangle":
                    if (shapeFill == false)
                    {
                        try
                        {
                         // Draw a non-filled rectangle with certain dimensions
                            shapes.DrawNotFilledRectangle(numParameter[0], numParameter[1]);
                        }
                        catch
                        {
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                            return;
                        }
                    }
                    else if (shapeFill == true)
                    {
                        try
                        {
                        // Draw a filled rectangle with certain dimensions
                            shapes.DrawFilledRectangle(numParameter[0], numParameter[1]);
                        }
                        catch
                        {
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                            return;
                        }
                    }
                    break;
                    case "circle":
                    if (shapeFill == false)
                    {
                        try
                        {
                            // Draw filled Circle with certain Radius
                            shapes.DrawNotFilledCircle(numParameter[0]);
                        }
                        catch
                        {
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                            return;
                        }
                    }
                    else if (shapeFill == true)
                    {
                        try
                        {
                            // Draw a filled circle with certain radius
                            shapes.DrawFilledCircle(numParameter[0]);
                        }
                        catch
                        {
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                            return;
                        }
                    }
                    break;

                    default:
                    // Handle invalid command
                    textboxForSyntaxErrors.Text = "invalid command";
                    break;
                }
            }
            else
            {
                // Handle invalid command format
                textboxForSyntaxErrors.Text = "invalid command";
            }


        }
    }
}



