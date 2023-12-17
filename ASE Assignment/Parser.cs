using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public class Parser : Form1
    {

        public static void Method(string userInput, Shapes shapes, bool fill, RichTextBox textboxForSyntaxErrors)
        {
            userInput = userInput.ToLower().Trim();
            string[] splitInput = userInput.Split(' ');

            if (splitInput.Length == 2)
            {
                string[] parameter = splitInput[1].Split(',');
                int[] numParameter = new int[parameter.Length];
                try
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        numParameter[i] = Convert.ToInt32(parameter[i]);
                        Console.WriteLine(numParameter[i]);
                    }
                }
                catch
                {
                    textboxForSyntaxErrors.Text = "invalid parameters, they must be numbers";
                    return;
                }
                switch (splitInput[0])
                {
                    case "drawto":
                        try
                        {
                            shapes.drawTo(numParameter[0], numParameter[1]);
                            Console.WriteLine("Pen drawn");
                        }
                        catch
                        {
                            
                            Console.WriteLine("Incorrect number of params please input 2 numbers");
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input 2 numbers";
                            return;
                        }
                        break;

                    case "moveto":
                        try
                        {
                            shapes.moveTo(numParameter[0], numParameter[1]);
                            Console.WriteLine("Pen drawn");
                        }
                        catch
                        {
                            Console.WriteLine("Incorrect number of params please input 2 numbers");
                            textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                            return;
                        }
                        break;
                    case "rectangle":
                        if (fill = false)
                        {
                            try
                            {
                                shapes.NotFilledRectangle(numParameter[0], numParameter[1]);
                            }
                            catch
                            {
                                Console.WriteLine("Incorrect number of params for a circle please input one number");
                                textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                                return;
                            }
                        }
                        else if (fill = true)
                        {
                            try
                            {
                                shapes.FilledRectangle(numParameter[0], numParameter[1]);
                            }
                            catch
                            {
                                Console.WriteLine("Incorrect number of params for a circle please input one number");
                                textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                                return;
                            }
                        }
                        break;


                    case "circle":
                        if (fill = false)
                        {
                            try
                            {
                                shapes.NotFilledCircle(numParameter[0]);
                            }
                            catch
                            {
                                Console.WriteLine("Incorrect number of params for a circle please input one number");
                                textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                                return;
                            }
                        }
                        else if(fill = true)
                        {
                            try
                            {
                                shapes.FilledCircle(numParameter[0]);
                            }
                            catch
                            {
                                Console.WriteLine("Incorrect number of params for a circle please input one number");
                                textboxForSyntaxErrors.Text = "Incorrect number of params please input numbers";
                                return;
                            }
                        }
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


  