using System;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public class Parser : Form1
    {

        public static void ParseCommand(string userInput, Shapes shapes, bool shapeFill, RichTextBox textboxForSyntaxErrors)
        {
            string[] splitUserInput = userInput.ToLower().Trim().Split(' ');

            if (splitUserInput.Length == 2)
            {
                string[] parameter = splitUserInput[1].Split(',');
                int[] numParameter = new int[parameter.Length];
                try
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        numParameter[i] = Convert.ToInt32(parameter[i]);
                    }
                }
                catch
                {
                    textboxForSyntaxErrors.Text = "invalid parameters, they must be numbers";
                    return;
                }             
                    switch (splitUserInput[0])
                    {
                        case "drawto":
                            try
                            {
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
                        textboxForSyntaxErrors.Text = "invalid command";
                        break;
                }
            }
            else
            {
                textboxForSyntaxErrors.Text = "invalid command";
            }


        }
    }
}


  