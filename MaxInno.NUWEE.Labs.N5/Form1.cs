
namespace MaxInno.NUWEE.Labs.N5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x1) ||
                !double.TryParse(textBox2.Text, out double x2))
            {
                MessageBox.Show("Неправильні дані в полях");
                return;
            }

            textBox3.Text = Formula(x1, x2).ToString("0.######");
        }

        private static double Formula(double x1, double x2)
        {
            return 23 * Math.Pow(Math.Cos(Math.Pow(x1, 3) * Math.Pow(x2, 5)), 2) + 2 * x1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}