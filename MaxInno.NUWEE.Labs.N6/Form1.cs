
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
                    "{0}, {1}, {2}. ���������: {3}. г���� �����: {4:0.00} ���. �����: {5:0.000} ��. ��. [{6} | {7} | {8}] | г���� ����� �� ��������: {9:0.00} ���\r\n",
                    town.Name,
                    town.Country,
                    town.Region,
                    town.Population,
                    town.YearIncome,
                    town.Square,
                    town.HasPort ? "� ����" : "���� �����",
                    town.HasAirport ? "� ��������" : "���� ���������",
                    town.HasBikeRoads ? "� ����������" : "���� ����������",
                    town.GetYearIncomePerInhabitant());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��������� ������ ����������?",
                "��������� ������", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}