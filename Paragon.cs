using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SystemParkingowy
{
    public partial class Paragon : Form
    {
        public Paragon(string dataWjazdu, string godzinaWjazdu, string godzinaWyjazdu, string czasPostoju, string zaplata)
        {
            InitializeComponent();
            lblDataWjazdu.Text = dataWjazdu;
            lblGodzinaWjazdu.Text = godzinaWjazdu;
            lblGodzinaWyjazdu.Text = godzinaWyjazdu;
            lblCzasPostoju.Text = czasPostoju;
            lblZaplata.Text = zaplata + " zł";
        }

        private void btnDrukuj_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Miejsce: " + lblDataWjazdu.Text, Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Nr rejestracyjny: " + lblGodzinaWjazdu.Text, Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString("Nr rejestracyjny: " + lblGodzinaWyjazdu.Text, Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString("Nr rejestracyjny: " + lblCzasPostoju.Text, Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString("Nr rejestracyjny: " + lblZaplata.Text, Font, Brushes.Black, 10, 30);
        }

        
    }
}
