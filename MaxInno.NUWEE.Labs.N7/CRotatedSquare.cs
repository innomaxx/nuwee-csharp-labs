
namespace MaxInno.NUWEE.Labs.N7
{
    internal class CRotatedSquare : CSquare
    {
        private readonly float _rotateDegrees;
        private readonly int _circleRadius;

        public CRotatedSquare(Graphics graphics, int X, int Y, int side,
            float rotateDegrees, int circleRadius)
            : base(graphics, X, Y, side)
        {
            _rotateDegrees = rotateDegrees;
            _circleRadius = circleRadius;
        }

        protected override void Draw(Pen pen)
        {
            graphics.TranslateTransform(X, Y);
            graphics.RotateTransform(_rotateDegrees);
            graphics.TranslateTransform(-X, -Y);

            base.Draw(pen);
        }
    }
}
