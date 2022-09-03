
namespace MaxInno.NUWEE.Labs.N8
{
    internal class CRotatedSquare : CSquare
    {
        public CRotatedSquare(Graphics graphics, int x, int y, int circleRadius)
            : base(graphics, x, y, circleRadius)
        {
            
        }

        public override void Draw(Pen pen)
        {
            int circle_x = X + _circleRadius;
            int circle_y = Y + _circleRadius;

            var vertices = new PointF[] {
                new PointF(circle_x + _circleRadius, circle_y),
                new PointF(circle_x, circle_y - _circleRadius),
                new PointF(circle_x - _circleRadius, circle_y),
                new PointF(circle_x, circle_y + _circleRadius),
            };

            _graphics.DrawPolygon(pen, vertices);
        }
    }
}
