using System.Drawing.Printing;

namespace SystemParkingowy
{
    public partial class Bilet : Form
    {
        public Bilet(string miejsce, string nrRej)
        {
            InitializeComponent();
            lblNumerMiejsca.Text = miejsce;
            lblNrRej.Text = nrRej;
        }

        private void BtnDrukuj_Click(object sender, EventArgs e)
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
           
            e.Graphics.DrawString("Miejsce: " + lblNumerMiejsca.Text, Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Nr rejestracyjny: " + lblNrRej.Text, Font, Brushes.Black, 10, 30);
        }
    }
}
