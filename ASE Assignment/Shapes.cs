using System.Drawing;

namespace ASE_Assignment
{
    public class Shapes
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Red, 5);
        SolidBrush solidBrush = new SolidBrush(Color.Red);
        int penPositionX, penPositionY;


        public Shapes(Graphics graphics)
        {
            this.graphics = graphics;
            penPositionX = 0;
            penPositionY = 0;
        }

        public void drawstraightLineTo(int goToXCoord, int goToYCoord)
        {
            graphics.DrawLine(pen, penPositionX, penPositionY, goToXCoord, goToYCoord);
            penPositionX = goToXCoord;
            penPositionY = goToYCoord;
        }

        public void movePenToCoords(int goToXCoord, int goToYCoord)
        {
            penPositionX = goToXCoord;
            penPositionY = goToYCoord;
        }

        public void clearCanvas()
        {
            graphics.Clear(Color.Transparent);
            penPositionX = penPositionY = 0;
        }

        public void resetCanvas()
        {
            penPositionX = penPositionY = 0;
        }

        public void DrawNotFilledRectangle(int width, int height)
        {
            graphics.DrawRectangle(pen, penPositionX - width / 2, penPositionY - height / 2, width, height);
        }
        public void DrawNotFilledCircle(int radius)
        {
            graphics.DrawEllipse(pen, penPositionX - radius, penPositionY - radius, radius * 2, radius * 2);
        }
        public void DrawFilledCircle(int radius)
        {
            graphics.FillEllipse(solidBrush, penPositionX - radius, penPositionY - radius, radius * 2, radius * 2);
        }
        public void DrawFilledRectangle(int width, int height)
        {
            graphics.FillRectangle(solidBrush, penPositionX - width / 2, penPositionY - height / 2, width, height);
        }
        public void redPen()
        {
            pen = new Pen(Color.Red, 5);
            solidBrush = new SolidBrush(Color.Red);
        }
        public void bluePen()
        {
            pen = new Pen(Color.Blue, 5);
            solidBrush = new SolidBrush(Color.Blue);
        }
        public void yellowPen()
        {
            pen = new Pen(Color.Yellow, 5);
            solidBrush = new SolidBrush(Color.Yellow);
        }
        public void blackPen()
        {
            pen = new Pen(Color.Black, 5);
            solidBrush = new SolidBrush(Color.Black);
        }
        public void greenPen()
        {
            pen = new Pen(Color.Green, 5);
            solidBrush = new SolidBrush(Color.Green);
        }


    }
}

