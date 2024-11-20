using Newtonsoft.Json;

namespace SystemParkingowy
{
    public partial class Wyjazdy : Form
    {
        public Wyjazdy()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDataFromJsonFile();
        }
        private void InitializeDataGridView()
        {
            dataGridViewExit.Columns.Add("Marka", "Marka");
            dataGridViewExit.Columns.Add("Rodzaj", "Rodzaj");
            dataGridViewExit.Columns.Add("Miejsce", "Miejsce");
            dataGridViewExit.Columns.Add("NrRej", "Rejestracja");
            dataGridViewExit.Columns.Add("Data", "Data");
            dataGridViewExit.Columns.Add("Godzina", "Godzina wyjazdu");
            foreach (DataGridViewColumn column in dataGridViewExit.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridViewExit.Font, FontStyle.Bold);
            }
            dataGridViewExit.ReadOnly = true;
            dataGridViewExit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExit.AllowUserToAddRows = false;
            dataGridViewExit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExit.AllowUserToResizeColumns = false;

            int height = (int)(this.Height * 1.25);
            dataGridViewExit.Size = new Size(this.Width, height);
        }

        private void LoadDataFromJsonFile()
        {
            string appFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parkingTXT");
            string jsonFilePath = Path.Combine(appFolderPath, "log.json");

            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    // dziedziczenie klasy wpisy
                    var loadedData = JsonConvert.DeserializeObject<Wpisy>(jsonData);

                    dataGridViewExit.Rows.Clear();
                    foreach (var wpis in loadedData.Wpis)
                    {
                        if (wpis.Zdarzenie == "Wyjazd")
                        {
                            dataGridViewExit.Rows.Add(
                            wpis.Marka,
                            wpis.Rodzaj,
                            wpis.Miejsce,
                            wpis.NrRej,
                            wpis.Data,
                            wpis.Godzina
                        );
                        }

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z pliku JSON", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
