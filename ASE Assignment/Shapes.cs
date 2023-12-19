using System.Drawing;

namespace ASE_Assignment
{
    public class Shapes
    {
        Graphics graphics;
        Pen pen;
        SolidBrush solidBrush;
        int positionX, positionY;


        public Shapes(Graphics graphics)
        {
            this.graphics = graphics;
            positionX = positionY = 0;
            pen = new Pen(Color.Red, 5);
            solidBrush = new SolidBrush(Color.Black);
        }

        public void drawTo(int moveToXCoord, int moveToYCoord)
        {
            graphics.DrawLine(pen, positionX, positionY, moveToXCoord, moveToYCoord);
            positionX = moveToXCoord;
            positionY = moveToYCoord;
        }

        public void moveTo(int moveToXCoord, int moveToYCoord)
        {
            positionX = moveToXCoord;
            positionY = moveToYCoord;
        }

        public void clearCanvas()
        {
            graphics.Clear(Color.Transparent);
            positionX = positionY = 0;
        }

        public void resetCanvas()
        {
            positionX = positionY = 0;
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


        public void NotFilledRectangle(int width, int height)
        {
            graphics.DrawRectangle(pen, positionX - width / 2, positionY - height / 2, width, height);
        }
        public void NotFilledCircle(int radius)
        {
            graphics.DrawEllipse(pen, positionX - radius, positionY - radius, radius * 2, radius * 2);
        }


        public void FilledCircle(int radius)
        {
            graphics.FillEllipse(solidBrush, positionX - radius, positionY - radius, radius * 2, radius * 2);
        }
        public void FilledRectangle(int width, int height)
        {
            graphics.FillRectangle(solidBrush, positionX - width / 2, positionY - height / 2, width, height);
        }



    }
}

