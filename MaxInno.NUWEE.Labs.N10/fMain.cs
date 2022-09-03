
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
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
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
                    Name = "Виробник"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Model",
                    Name = "Модель"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Type",
                    Name = "Тип кузова"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "FuelType",
                    Name = "Тип палива"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NumberOfSeats",
                    Name = "Кількість сидінь"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Length",
                    Name = "Загальна довжина"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Weight",
                    Name = "Вага"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IsEcoVehicle",
                    Name = "Екологічно чистий?"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IsEcoAffordable",
                    Name = "Економічно вигідний?"
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