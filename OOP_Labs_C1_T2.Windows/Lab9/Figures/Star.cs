using System;

namespace OOP_Labs_C1_T2.Windows.Lab9.Figures
{
    public class Star
    {
        public static readonly Star EmptyStar = new Star();

        public Star() : this(0, 0, 0, 0) { }

        public Star(int a, int b) : this(a, b, 0, 0) { }

        public Star(int a, int b, int centerX, int centerY)
        {
            A = a;
            B = b;
            CenterX = centerX;
            CenterY = centerY;
        }

        public int A { get; set; }
        public int B { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }

        public void Draw(Graphics graphics, Pen pen)
        {
            int halfA = A / 2;
            int halfB = B / 2;

            //LeftSide
            graphics.DrawLine(pen, new Point(CenterX - halfA, CenterY), new Point(CenterX - halfB, CenterY + halfB));
            graphics.DrawLine(pen, new Point(CenterX - halfA, CenterY), new Point(CenterX - halfB, CenterY - halfB));

            //Topside
            graphics.DrawLine(pen, new Point(CenterX, CenterY - halfA), new Point(CenterX + halfB, CenterY - halfB));
            graphics.DrawLine(pen, new Point(CenterX, CenterY - halfA), new Point(CenterX - halfB, CenterY - halfB));

            //RightSide
            graphics.DrawLine(pen, new Point(CenterX + halfA, CenterY), new Point(CenterX + halfB, CenterY + halfB));
            graphics.DrawLine(pen, new Point(CenterX + halfA, CenterY), new Point(CenterX + halfB, CenterY - halfB));

            //Bottomside
            graphics.DrawLine(pen, new Point(CenterX, CenterY + halfA), new Point(CenterX + halfB, CenterY + halfB));
            graphics.DrawLine(pen, new Point(CenterX, CenterY + halfA), new Point(CenterX - halfB, CenterY + halfB));
        }
    }
}
