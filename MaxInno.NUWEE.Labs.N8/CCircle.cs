
namespace MaxInno.NUWEE.Labs.N8
{
    internal class CCircle : CFigure
    {
        private int _radius;

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }

        public CCircle(Graphics graphics, int X, int Y, int Radius)
        {
            _graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        public override void Draw(Pen pen)
        {
            var rectangle = new Rectangle(X, Y, (2 * Radius), (2 * Radius));
            _graphics.DrawEllipse(pen, rectangle);
        }

        public override void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }

        public override void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
    }
}
