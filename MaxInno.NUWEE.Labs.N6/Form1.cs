
namespace MaxInno.NUWEE.Labs.N6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var town = new Town();
            var addTownForm = new Form2(town);

            if (addTownForm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text += string.Format(
                    "{0}, {1}, {2}. Мешканців: {3}. Річний дохід: {4:0.00} грн. Площа: {5:0.000} кв. км. [{6} | {7} | {8}] | Річний дохід на мешканця: {9:0.00} грн\r\n",
                    town.Name,
                    town.Country,
                    town.Region,
                    town.Population,
                    town.YearIncome,
                    town.Square,
                    town.HasPort ? "Є порт" : "Немає порту",
                    town.HasAirport ? "Є аеропорт" : "Немає аеропорту",
                    town.HasBikeRoads ? "Є велодоріжки" : "Немає велодоріжок",
                    town.GetYearIncomePerInhabitant());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
                "Припинити роботу", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}