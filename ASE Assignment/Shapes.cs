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

        public void drawTo(int moveToX, int moveToY)
        {
            graphics.DrawLine(pen, positionX, positionY, moveToX, moveToY);
            positionX = moveToX;
            positionY = moveToY;
        }

        public void moveTo(int toX, int toY)
        {
            positionX = toX;
            positionY = toY;
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
    }
}

