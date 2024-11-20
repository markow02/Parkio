using System.Drawing.Printing;

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
            float y = 10;

            e.Graphics.DrawString("Data wjazdu: " + lblDataWjazdu.Text, Font, Brushes.Black, 10, y);
            y += 20; //

            e.Graphics.DrawString("Godzina wjazdu: " + lblGodzinaWjazdu.Text, Font, Brushes.Black, 10, y);
            y += 20;

            e.Graphics.DrawString("Godzina wyjazdu: " + lblGodzinaWyjazdu.Text, Font, Brushes.Black, 10, y);
            y += 20;

            e.Graphics.DrawString("Czas postoju: " + lblCzasPostoju.Text, Font, Brushes.Black, 10, y);
            y += 20;

            e.Graphics.DrawString("Należność: " + lblZaplata.Text, Font, Brushes.Black, 10, y);
            y += 20;
        }

    }
}
