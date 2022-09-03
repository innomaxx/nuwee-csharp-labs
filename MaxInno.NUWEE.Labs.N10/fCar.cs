using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable enable

namespace MaxInno.NUWEE.Labs.N10
{
    public partial class fCar : Form
    {
        private Car? _car;

        public fCar()
        {
            InitializeComponent();
        }

        public fCar(Car car)
        {
            _car = car;
            InitializeComponent();
        }
    }
}
