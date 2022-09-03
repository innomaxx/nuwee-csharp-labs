
namespace MaxInno.NUWEE.Labs.N8
{
    internal abstract class CFigure
    {
        protected Graphics _graphics;

        public int X { get; set; }

        public int Y { get; set; }

        abstract public void Draw(Pen pen);

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }

        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }

        abstract public void Expand(int dR);

        abstract public void Collapse(int dR);
    }
}
