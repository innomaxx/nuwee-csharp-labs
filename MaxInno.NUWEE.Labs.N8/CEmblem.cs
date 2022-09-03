
namespace MaxInno.NUWEE.Labs.N8
{
    internal class CEmblem : CFigure
    {
        private readonly CFigure[] _parts;

        public CEmblem(Graphics graphics, int x, int y, int circleRadius)
        {
            _graphics = graphics;
            X = x;
            Y = y;

            _parts = new CFigure[]
            {
                new CCircle(graphics, x, y, circleRadius),
                new CSquare(graphics, x, y, circleRadius),
                new CRotatedSquare(graphics, x, y, circleRadius)
            };
        }

        public override void Draw(Pen pen)
        {
            foreach (var part in _parts)
            {
                part.Draw(pen);
            }
        }

        public override void Expand(int dR)
        {
            foreach (var part in _parts)
            {
                part.Expand(dR);
            }
        }

        public override void Collapse(int dR)
        {
            foreach (var part in _parts)
            {
                part.Collapse(dR);
            }
        }

        public new void Move(int dX, int dY)
        {
            foreach (var part in _parts)
            {
                part.Move(dX, dY);
            }
        }
    }
}
