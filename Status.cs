using Newtonsoft.Json;
using System.Globalization;

namespace SystemParkingowy
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            LoadDataFromJsonFile();
        }

        private void LoadDataFromJsonFile()
        {
            string appFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parkingTXT");
            string jsonFilePath = Path.Combine(appFolderPath, "data.json");
            DateTime WybranaData = DataWybor.Value;
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    var loadedData = JsonConvert.DeserializeObject<DanePojazdow>(jsonData);

                    int totalEntered = 0;
                    int totalParked = 0;
                    int totalExited = 0;
                    decimal totalEarnings = 0;

                    foreach (Pojazd pojazd in loadedData.Pojazdy)
                    {
                        string dataZPlikuJSONString = pojazd.DataWjazdu;
                        DateTime dataJSON = DateTime.ParseExact(dataZPlikuJSONString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                        if (dataJSON.Date == WybranaData.Date)
                        {
                            totalEntered++;
                            if (pojazd.Status == "Zaparkowany")
                            {
                                totalParked++;
                            }
                            else if (pojazd.Status == "Wyjechał")
                            {
                                totalExited++;
                                decimal earnings;
                                if (Decimal.TryParse(pojazd.Zaplata.Replace(" zł", ""), out earnings))
                                {
                                    totalEarnings += earnings;
                                }
                            }
                        }
                    }
                    IleWjazdowLabel.Text = totalEntered.ToString();
                    ZaparkowaneLabel.Text = totalParked.ToString();
                    IleWyjazdowLabel.Text = totalExited.ToString();
                    ZarobekLabel.Text = totalEarnings.ToString("C");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z pliku JSON", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WybranoDate_Click(object sender, EventArgs e)
        {
            LoadDataFromJsonFile();
        }


    }
}
