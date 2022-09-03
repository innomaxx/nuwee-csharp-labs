
namespace MaxInno.NUWEE.Labs.N6
{
    public partial class Form2 : Form
    {
        public Town _town;

        public Form2(Town town)
        {
            _town = town;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _town.Name = textBox1.Text.Trim();
            _town.Country = textBox2.Text.Trim();
            _town.Region = textBox3.Text.Trim();
            _town.Population = int.Parse(textBox4.Text.Trim());
            _town.YearIncome = int.Parse(textBox5.Text.Trim());
            _town.Square = double.Parse(textBox6.Text.Trim());

            _town.HasPort = checkBox1.Checked;
            _town.HasAirport = checkBox2.Checked;
            _town.HasBikeRoads = checkBox3.Checked;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_town != null)
            {
                textBox1.Text = _town.Name;
                textBox2.Text = _town.Country;
                textBox3.Text = _town.Region;
                textBox4.Text = _town.Population.ToString();
                textBox5.Text = _town.YearIncome.ToString();
                textBox6.Text = _town.Square.ToString();

                checkBox1.Checked = _town.HasPort;
                checkBox2.Checked = _town.HasAirport;
                checkBox3.Checked = _town.HasBikeRoads;
            }
        }
    }
}
