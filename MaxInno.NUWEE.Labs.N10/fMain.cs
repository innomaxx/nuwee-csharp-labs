
using System.Text;

#nullable enable

namespace MaxInno.NUWEE.Labs.N10
{
    public partial class fMain : Form
    {
        private Car? _car;

        public fMain()
        {
            InitializeComponent();
        }

        public fMain(Car car)
        {
            _car = car;
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "������� ����� (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "�������� ��� � ���������� ������";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            StreamWriter sw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);

                
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            dataGridView.Columns.AddRange(new[]
            {
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Vendor",
                    Name = "��������"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Model",
                    Name = "������"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Type",
                    Name = "��� ������"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "FuelType",
                    Name = "��� ������"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NumberOfSeats",
                    Name = "ʳ������ �����"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Length",
                    Name = "�������� �������"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Weight",
                    Name = "����"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IsEcoVehicle",
                    Name = "��������� ������?"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IsEcoAffordable",
                    Name = "��������� �������?"
                }
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var car = new Car();
            var carForm = new fCar(car);

            if (carForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}