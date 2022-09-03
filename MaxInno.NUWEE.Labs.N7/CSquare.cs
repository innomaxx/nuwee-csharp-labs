
namespace MaxInno.NUWEE.Labs.N7
{
    internal class CSquare
    {
        protected Graphics graphics;

        public int X { get; set; }

        public int Y { get; set; }

        public int Side { get; set; }

        public CSquare(Graphics graphics, int X, int Y, int side)
        {
            this.graphics = graphics;
            this.X = X - side/2;
            this.Y = Y - side/2;
            Side = side;
        }

        protected virtual void Draw(Pen pen)
        {
            var figure = new Rectangle(X, Y, Side, Side);
            graphics.DrawRectangle(pen, figure);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }

        public void Expand()
        {
            Hide();
            Side++;
            Show();
        }

        public void Expand(int dR)
        {
            Hide();
            //Side = Side + dR;
            Side = Side + GetSide(dR);
            Show();
        }

        private void Collapse()
        {
            Hide();
            Side--;
            Show();
        }

        public void Collapse(int dR)
        {
            Hide();
            //Side = Side - dR;
            Side = Side - GetSide(dR);
            Show();
        }

        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }

        private static int GetSide(int circleRadius)
        {
            return (int)Math.Sqrt(Math.Pow(circleRadius, 2) / 2);
        }
    }
}
