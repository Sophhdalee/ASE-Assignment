using System;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public class LongInput : Form1
    {
        public static void LongInputCommand(string LongUserInput, Shapes shapes, bool shapeFill, RichTextBox textboxForSyntaxErrors)
        {
            string longUserInputTrim = LongUserInput.ToLower().Trim();
            string[] InputSplitLine = longUserInputTrim.Split('\n');

            foreach (string oneLine in InputSplitLine)
            {
                string[] splitInput = oneLine.Split(' ');

                if (splitInput.Length == 2)
                {
                    string[] parameters = splitInput[1].Split(',');
                    int[] numParameters = new int[parameters.Length];

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        try
                        {
                            numParameters[i] = Convert.ToInt32(parameters[i]);
                        }
                        catch
                        {
                            textboxForSyntaxErrors.Text = "Invalid parameter; it must be a number";
                            return;
                        }
                    }

                    switch (splitInput[0])
                    {
                        case "drawto":
                            try
                            {
                                shapes.drawstraightLineTo(numParameters[0], numParameters[1]);
                            }
                            catch
                            {
                                textboxForSyntaxErrors.Text = "Incorrect number of parameters; please input 2 numbers";
                                return;
                            }
                            break;

                        case "moveto":
                            try
                            {
                                shapes.movePenToCoords(numParameters[0], numParameters[1]);
                            }
                            catch
                            {
                                textboxForSyntaxErrors.Text = "Incorrect number of parameters; please input 2 numbers";
                                return;
                            }
                            break;

                        case "rectangle":
                            try
                            {
                                if (shapeFill)
                                    shapes.DrawFilledRectangle(numParameters[0], numParameters[1]);
                                else
                                    shapes.DrawNotFilledRectangle(numParameters[0], numParameters[1]);
                            }
                            catch
                            {
                                textboxForSyntaxErrors.Text = "Incorrect number of parameters; please input 2 numbers";
                                return;
                            }
                            break;

                        case "circle":
                            try
                            {
                                if (shapeFill)
                                {
                                    shapes.DrawFilledCircle(numParameters[0]);
                                }
                                else
                                {
                                    shapes.DrawNotFilledCircle(numParameters[0]);
                                }
                                   
                            }
                            catch
                            {
                                textboxForSyntaxErrors.Text = "Incorrect number of parameters; please input 1 number";
                                return;
                            }
                            break;

                        default:
                            textboxForSyntaxErrors.Text = "Invalid command";
                            break;
                    }
                }
                else
                {
                    textboxForSyntaxErrors.Text = "Invalid command";
                }
            }
        }
    }
}
