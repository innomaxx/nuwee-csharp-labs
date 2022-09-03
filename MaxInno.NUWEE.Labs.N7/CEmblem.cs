
namespace MaxInno.NUWEE.Labs.N7
{
    internal class CEmblem
    {
        const int DefaultRadius = 25;

        private Graphics graphics;
        private int _radius;

        public int X { get; set; }

        public int Y { get; set; }

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

        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        private void Draw(Pen pen)
        {
            int circle_x = X + Radius;
            int circle_y = Y + Radius;
            Rectangle rectangle;

            rectangle = new((int)(circle_x - (Radius / Math.Sqrt(2))),
                (int)(circle_y - (Radius / Math.Sqrt(2))),
                (int)(2.0 * Radius / Math.Sqrt(2)),
                (int)(2.0 * Radius / Math.Sqrt(2))
                );
            graphics.DrawRectangle(pen, rectangle);

            rectangle = new(X, Y,
                (2 * Radius), (2 * Radius));
            graphics.DrawEllipse(pen, rectangle);

            var vertices = new PointF[] {
                new PointF(circle_x + Radius, circle_y),
                new PointF(circle_x, circle_y - Radius),
                new PointF(circle_x - Radius, circle_y),
                new PointF(circle_x, circle_y + Radius),
            };
            graphics.DrawPolygon(pen, vertices);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }
        public void Hide()
        {
            Draw(Pens.White);
            //graphics.Clear(Color.White);
        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Radius += dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }
        public void Collapse(int dR)
        {
            Hide();
            Radius -= dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X += dX;
            Y += dY;
            Show();
        }
    }
}
