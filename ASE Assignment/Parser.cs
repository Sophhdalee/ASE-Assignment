using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public class Parser : Form1
    {

        public static void Method(string userInput, Shapes shapes)
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
                            return;
                        }
                        break;
                    case "rectangle":
                        try
                        {
                            shapes.NotFilledRectangle(numParameter[0], numParameter[1]);
                        }
                        catch
                        {
                            Console.WriteLine("Incorrect number of params for rectangle, please input 2 numbers");
                            return;
                        }
                        break;
                    case "circle":
                        try
                        {
                            shapes.NotFilledCircle(numParameter[0]);
                        }
                        catch
                        {
                            Console.WriteLine("Incorrect number of params for a circle please input one number");
                            return;
                        }
                        break;

                }
            }
            else
            {
                //invalid command
            }
        }
    }
}


