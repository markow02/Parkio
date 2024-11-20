using Newtonsoft.Json;

namespace SystemParkingowy
{
    public partial class Wjazdy : Form
    {
        public Wjazdy()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDataFromJsonFile();
        }

        private void InitializeDataGridView()
        {
            dataGridViewEntry.Columns.Add("Marka", "Marka");
            dataGridViewEntry.Columns.Add("Rodzaj", "Rodzaj");
            dataGridViewEntry.Columns.Add("Miejsce", "Miejsce");
            dataGridViewEntry.Columns.Add("NrRej", "Rejestracja");
            dataGridViewEntry.Columns.Add("Data", "Data");
            dataGridViewEntry.Columns.Add("Godzina", "Godzina wjazdu");
            foreach (DataGridViewColumn column in dataGridViewEntry.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridViewEntry.Font, FontStyle.Bold);
            }
            dataGridViewEntry.ReadOnly = true;
            dataGridViewEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEntry.AllowUserToAddRows = false;
            dataGridViewEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEntry.AllowUserToResizeColumns = false;

            int height = (int)(Height * 0.9);
            dataGridViewEntry.Size = new Size(Width, height);
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

                    //dziedziczenie klasy wpisy
                    var loadedData = JsonConvert.DeserializeObject<Wpisy>(jsonData);

                    dataGridViewEntry.Rows.Clear();
                    foreach (var wpis in loadedData.Wpis)
                    {
                        if(wpis.Zdarzenie == "Wjazd")
                        {
                            dataGridViewEntry.Rows.Add(
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
