
namespace MaxInno.NUWEE.Labs.N8
{
    internal class CSquare : CFigure
    {
        protected int _circleRadius;

        public CSquare(Graphics graphics, int x, int y, int circleRadius)
        {
            _graphics = graphics;
            _circleRadius = circleRadius;

            X = x;
            Y = y;
        }

        public override void Draw(Pen pen)
        {
            int circle_x = X + _circleRadius;
            int circle_y = Y + _circleRadius;
            
            var rectangle = new Rectangle(
                (int)(circle_x - (_circleRadius / Math.Sqrt(2))),
                (int)(circle_y - (_circleRadius / Math.Sqrt(2))),
                (int)(2.0 * _circleRadius / Math.Sqrt(2)),
                (int)(2.0 * _circleRadius / Math.Sqrt(2))
            );

            _graphics.DrawRectangle(pen, rectangle);
        }

        public override void Expand(int dR)
        {
            Hide();
            _circleRadius += dR;
            Show();
        }

        public override void Collapse(int dR)
        {
            Hide();
            _circleRadius -= dR;
            Show();
        }
    }
}
