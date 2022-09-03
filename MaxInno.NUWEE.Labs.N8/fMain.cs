
namespace MaxInno.NUWEE.Labs.N8
{
    public partial class fMain : Form
    {
        int EmblemsCount = 0;
        int CurrentEmblemIndex;
        CEmblem[] _emblems;

        public fMain()
        {
            InitializeComponent();
            _emblems = new CEmblem[100];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (EmblemsCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentEmblemIndex = EmblemsCount;

            _emblems[CurrentEmblemIndex] =
                new CEmblem(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            _emblems[CurrentEmblemIndex].Show();
            EmblemsCount++;

            cbCircles.Items.Add("Емблема №" + (EmblemsCount - 1).ToString());
            cbCircles.SelectedIndex = EmblemsCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            _emblems[CurrentEmblemIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            for (int i = 0; i < 100; i++)
            {
                _emblems[CurrentEmblemIndex].Move(1, 0);
                Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;

            for (int i = 0; i < 100; i++)
            {
                _emblems[CurrentEmblemIndex].Move(-1, 0);
                Thread.Sleep(5);
            }
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;

            for (int i = 0; i < 100; i++)
            {
                _emblems[CurrentEmblemIndex].Move(0, -1);
                Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0)) return;

            for (int i = 0; i < 100; i++)
            {
                _emblems[CurrentEmblemIndex].Move(0, 1);
                Thread.Sleep(5);
            }
        }
    }
}