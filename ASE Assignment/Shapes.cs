using System.Drawing;

namespace ASE_Assignment
{ /// <summary>
/// The Shapes class is responsible for drawing various shapes on a given Graphics object.
/// </summary>
    public class Shapes
    {
        // Graphics object to draw shapes on
        Graphics graphics;
        // Default pen with red color and thickness 5
        Pen pen = new Pen(Color.Red, 5);
        // Default solid brush with red color
        SolidBrush solidBrush = new SolidBrush(Color.Red);
        // Current position of the pen
        int penPositionX, penPositionY;

        // Constructor initializes the Shapes object with a Graphics object
        public Shapes(Graphics graphics)
        {
            this.graphics = graphics;
            penPositionX = 0;
            penPositionY = 0;
        }
        // Draws a straight line from the current pen position to the specified coordinates
        public void drawstraightLineTo(int goToXCoord, int goToYCoord)
        {
            graphics.DrawLine(pen, penPositionX, penPositionY, goToXCoord, goToYCoord);
            penPositionX = goToXCoord;
            penPositionY = goToYCoord;
        }
        // Moves the pen to the specified coordinates without drawing
        public void movePenToCoords(int goToXCoord, int goToYCoord)
        {
            penPositionX = goToXCoord;
            penPositionY = goToYCoord;
        }
        // Clears the canvas and resets the pen position
        public void clearCanvas()
        {
            graphics.Clear(Color.Transparent);
            penPositionX = penPositionY = 0;
        }
        // Resets the pen position without clearing the canvas
        public void resetCanvas()
        {
            penPositionX = penPositionY = 0;
        }
        // Draws a non filled rectangle centered at the current pen position
        public void DrawNotFilledRectangle(int width, int height)
        {
            graphics.DrawRectangle(pen, penPositionX - width / 2, penPositionY - height / 2, width, height);
        }
        // Draws a non filled circle centered at the current pen position
        public void DrawNotFilledCircle(int radius)
        {
            graphics.DrawEllipse(pen, penPositionX - radius, penPositionY - radius, radius * 2, radius * 2);
        }
        // Draws a filled circle centered at the current pen position
        public void DrawFilledCircle(int radius)
        {
            graphics.FillEllipse(solidBrush, penPositionX - radius, penPositionY - radius, radius * 2, radius * 2);
        }
        // Draws a filled rectangle centered at the current pen position
        public void DrawFilledRectangle(int width, int height)
        {
            graphics.FillRectangle(solidBrush, penPositionX - width / 2, penPositionY - height / 2, width, height);
        }
        // set pen to red
        public void redPen()
        {
            pen = new Pen(Color.Red, 5);
            solidBrush = new SolidBrush(Color.Red);
        }
        // set pen to blue
        public void bluePen()
        {
            pen = new Pen(Color.Blue, 5);
            solidBrush = new SolidBrush(Color.Blue);
        }
        // set pen to yellow
        public void yellowPen()
        {
            pen = new Pen(Color.Yellow, 5);
            solidBrush = new SolidBrush(Color.Yellow);
        }
        // set pen to black
        public void blackPen()
        {
            pen = new Pen(Color.Black, 5);
            solidBrush = new SolidBrush(Color.Black);
        }
        // set pen to green
        public void greenPen()
        {
            pen = new Pen(Color.Green, 5);
            solidBrush = new SolidBrush(Color.Green);
        }


    }
}

