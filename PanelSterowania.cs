using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemParkingowy
{
    public partial class PanelSterowania : Form
    {
        public PanelSterowania()
        {
            InitializeComponent();
        }

        private void PanelSterowania_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajSamochod newCar = new DodajSamochod();
            newCar.Show();
        }
    }
}
