using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace SystemParkingowy
{
    public partial class PanelSterowania : Form
    {
        private System.Windows.Forms.Timer timer;


        private int kolejneOsID = 1; // Unikalne ID dla samochodów osobowych
        private int kolejneCiID = 1; // Unikalne ID dla samochodów ciężarowych

        private HashSet<string> zajeteMiejscaOs = new HashSet<string>();
        private HashSet<string> zajeteMiejscaCi = new HashSet<string>();

        private int ostatnieIDOs = 0;
        private int ostatnieIDCi = 0;

        // Deklaracje zmiennych poziomu klasy
        private string dataWjazdu;
        private string czasPostoju;
        private string zaplata;

        public PanelSterowania()
        {
            InitializeComponent();

            //comboBoxMarka.TextChanged += ComboBoxMarka_TextChanged;
            InitializeDataGridView();
            LoadDataFromJsonFile();

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }
        private void InitializeDataGridView()
        {
            // Konfiguracja DataGridView

            dataGridView1.Columns.Add("Marka", "Marka pojazdu");
            dataGridView1.Columns.Add("Rodzaj", "Rodzaj pojazdu");
            dataGridView1.Columns.Add("NrRej", "Nr rejestracyjny");
            dataGridView1.Columns.Add("DataWjazdu", "Data wjazdu");
            dataGridView1.Columns.Add("Miejsce", "Miejsce");
            dataGridView1.Columns.Add("GodzinaWjazdu", "Godzina wjazdu");
            dataGridView1.Columns.Add("CzasPostoju", "Czas postoju");
            dataGridView1.Columns.Add("GodzinaWyjazdu", "Godzina wyjazdu");
            dataGridView1.Columns.Add("Zapłata", "Zapłata");
            dataGridView1.Columns.Add("Status", "Status");

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }

            // Ustawienia dodatkowe
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            // Ustaw szerokość kolumn na proporcjonalną do szerokości okna
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Zablokuj możliwość ręcznej zmiany szerokości kolumn
            dataGridView1.AllowUserToResizeColumns = false;

            // Dodaj obsługę zdarzenia Resize
            this.Resize += PanelSterowania_Resize;

            // Ustaw pozycję i rozmiar dataGridView1
            int topMargin = 21;
            int height = (int)(this.Height * 0.8);   // 60% dostępnej wysokości
            dataGridView1.Location = new Point(0, topMargin);
            dataGridView1.Size = new Size(this.Width, height);

            // Dodaj obsługę zdarzenia CellClick
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void SaveDataToJsonFile()
        {
            string appFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parkingTXT");
            string jsonFilePath = Path.Combine(appFolderPath, "data.json");

            try
            {
                if (!Directory.Exists(appFolderPath))
                {
                    Directory.CreateDirectory(appFolderPath);
                }

                // Tworzymy obiekt, który będziemy zapisywać
                var dataToSave = new
                {
                    Osobowe = zajeteMiejscaOs.ToList(),
                    Ciezarowe = zajeteMiejscaCi.ToList(),
                    Pojazdy = dataGridView1.Rows.Cast<DataGridViewRow>().Select(row =>
                    {
                        return new
                        {

                            Marka = row.Cells["Marka"].Value,
                            Rodzaj = row.Cells["Rodzaj"].Value,
                            NrRej = row.Cells["NrRej"].Value,
                            DataWjazdu = row.Cells["DataWjazdu"].Value,
                            Miejsce = row.Cells["Miejsce"].Value,
                            GodzinaWjazdu = row.Cells["GodzinaWjazdu"].Value,
                            CzasPostoju = row.Cells["CzasPostoju"].Value,
                            GodzinaWyjazdu = row.Cells["GodzinaWyjazdu"].Value,
                            Zaplata = row.Cells["Zapłata"].Value,
                            Status = row.Cells["Status"].Value
                        };
                    })
                };

                // Serializacja do formatu JSON
                string jsonData = JsonConvert.SerializeObject(dataToSave, Formatting.Indented);

                // Zapis do pliku
                File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku JSON: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromJsonFile()
        {
            string appFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parkingTXT");
            string jsonFilePath = Path.Combine(appFolderPath, "data.json");

            try
            {
                if (File.Exists(jsonFilePath))
                {
                    // Odczyt danych z pliku
                    string jsonData = File.ReadAllText(jsonFilePath);

                    // Deserializacja JSON do obiektu
                    var loadedData = JsonConvert.DeserializeObject<DanePojazdow>(jsonData);

                    // Przypisanie wczytanych danych do struktur w programie
                    zajeteMiejscaOs = new HashSet<string>(loadedData.Osobowe);
                    zajeteMiejscaCi = new HashSet<string>(loadedData.Ciezarowe);

                    // Wczytywanie danych do DataGridView
                    dataGridView1.Rows.Clear();
                    foreach (var pojazd in loadedData.Pojazdy)
                    {
                        dataGridView1.Rows.Add(
                            pojazd.Marka,
                            pojazd.Rodzaj,
                            pojazd.NrRej,
                            pojazd.DataWjazdu,
                            pojazd.Miejsce,
                            pojazd.GodzinaWjazdu,
                            pojazd.CzasPostoju,
                            pojazd.GodzinaWyjazdu,
                            pojazd.Zaplata,
                            pojazd.Status
                        );
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z pliku JSON", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PanelSterowania_Resize(object sender, EventArgs e)
        {
            // Aktualizuj szerokość kolumn na proporcjonalną do szerokości okna po zmianie rozmiaru okna
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {


            comboBoxMarka.SelectedIndex = -1;
            comboBoxRodzaj.SelectedIndex = -1; // Deselect any selected item
            comboBoxRodzaj.Text = "Wybierz..."; // Set the default text
            txtNrRej.Clear();
            txtGodzina.Clear();
        }

        private void btnZatwierdzWjazd_Click(object sender, EventArgs e)
        {
            // Pobranie danych z formularza
            string marka = comboBoxMarka.Text.Trim();
            string rodzaj = comboBoxRodzaj.Text.Trim();
            string nrRej = txtNrRej.Text;


            // Sprawdzenie czy pojazd o danym numerze rejestracyjnym już istnieje
            if (CzyNumerRejestracyjnyIstnieje(nrRej))
            {
                MessageBox.Show("Pojazd o podanym numerze rejestracyjnym już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(marka) || string.Equals(rodzaj, "Wybierz...", StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(nrRej))
            {
                MessageBox.Show("Uzupełnij brakujące dane.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataWjazdu = DateTime.Now.ToString("yyyy-MM-dd");
            string godzinaWjazdu = DateTime.Now.ToString("HH:mm");
            czasPostoju = "Brak danych";
            string godzinaWyjazdu = "Brak danych";
            zaplata = "Brak danych";

            // Sprawdzenie dostępności miejsca
            string miejsce = string.Empty;
            if (rodzaj == "osobowy")
            {
                miejsce = ZnajdzDostepneMiejsce("Os", zajeteMiejscaOs);
                if (miejsce == null)
                {
                    MessageBox.Show("Brak dostępnych miejsc dla samochodów osobowych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.Rows.Add(marka, rodzaj, nrRej, dataWjazdu, miejsce, godzinaWjazdu, czasPostoju, godzinaWyjazdu, zaplata);
                ostatnieIDOs++;
            }
            else if (rodzaj == "ciężarowy")
            {
                miejsce = ZnajdzDostepneMiejsce("Ci", zajeteMiejscaCi);
                if (miejsce == null)
                {
                    MessageBox.Show("Brak dostępnych miejsc dla samochodów ciężarowych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.Rows.Add(marka, rodzaj, nrRej, dataWjazdu, miejsce, godzinaWjazdu, czasPostoju, godzinaWyjazdu, zaplata);
                ostatnieIDCi++;
            }

            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Status"].Value = "Zaparkowany";


            // Dodanie miejsca do listy zajętych miejsc
            if (rodzaj == "osobowy")
            {
                zajeteMiejscaOs.Add(miejsce);
            }
            else if (rodzaj == "ciężarowy")
            {
                zajeteMiejscaCi.Add(miejsce);
            }

            

            SaveDataToJsonFile();
            // Czyszczenie formularza
            ClearForm();

            // Wywołaj okno Bilet
            Bilet biletForm = new Bilet(miejsce, nrRej);
            biletForm.ShowDialog();
        }

        private bool CzyNumerRejestracyjnyIstnieje(string numerRejestracyjny)
        {
            // Sprawdzenie, czy numer rejestracyjny już istnieje w bazie danych
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NrRej"].Value?.ToString() == numerRejestracyjny)
                {
                    // Check if the vehicle has already left
                    string status = row.Cells["Status"].Value?.ToString();
                    if (status != null && status.Equals("Wyjechał", StringComparison.OrdinalIgnoreCase))
                    {
                        return false; // Pojazd o tej samej rejestracji wyjechał
                    }

                    return true; // Pojazd o tej samej rejestracji dalej jest na parkingu
                }
            }
            return false; // Nie znaleziono pojazdu o tym samym numerze rejestracyjnym
        }


        private string ZnajdzDostepneMiejsce(string prefix, HashSet<string> zajeteMiejsca)
        {
            for (int i = 1; i <= 100; i++)
            {
                string miejsce = $"{prefix}{i:D2}";
                if (!zajeteMiejsca.Contains(miejsce))
                {
                    return miejsce;
                }
            }
            return null; // Brak dostępnych miejsc
        }

        private void btnZatwierdzWyjazd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pobierz godzinę wyjazdu
                string godzinaWyjazdu = txtGodzina.Text;
                // Pobierz zmienną "Status" z wiersza przed edycją
                string statusPrzedEdycja = selectedRow.Cells["Status"].Value?.ToString() ?? string.Empty;

                if (statusPrzedEdycja == "Wyjechał")
                {
                    MessageBox.Show("Wyjazd dla tego pojazdu został już zatwierdzony.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Przekonwertuj godziny na obiekty DateTime
                DateTime godzinaWjazdu, godzinaWyjazduDateTime;
                if (DateTime.TryParse(selectedRow.Cells["GodzinaWjazdu"].Value?.ToString(), out godzinaWjazdu) &&
                    DateTime.TryParse(godzinaWyjazdu, out godzinaWyjazduDateTime))
                {
                    // Sprawdź, czy godzina wyjazdu jest poprawna
                    if (godzinaWyjazduDateTime <= godzinaWjazdu)
                    {
                        MessageBox.Show("Wprowadź późniejszą godzinę wyjazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Przywróć poprzednią godzinę wyjazdu
                        selectedRow.Cells["GodzinaWyjazdu"].Value = "Brak danych";
                        // Zmiana statusu tylko jeśli wcześniej był "Zaparkowany"
                        if (statusPrzedEdycja == "Zaparkowany")
                        {
                            selectedRow.Cells["Status"].Value = "Zaparkowany";
                        }
                        return;
                    }



                    // Ustaw nową godzinę wyjazdu
                    selectedRow.Cells["GodzinaWyjazdu"].Value = godzinaWyjazdu;



                    // Oblicz czas postoju
                    TimeSpan czasPostoju = godzinaWyjazduDateTime - godzinaWjazdu;
                    selectedRow.Cells["CzasPostoju"].Value = $"{(int)czasPostoju.TotalHours}h {czasPostoju.Minutes}min";

                    // Ustal opłatę - załóżmy, że za każdą rozpoczętą godzinę kosztuje 5 zł
                    decimal zaplata = (decimal)Math.Ceiling(czasPostoju.TotalHours) * 5;
                    selectedRow.Cells["Zapłata"].Value = zaplata.ToString("C");

                    // Dodaj dane do zmiennych
                    dataWjazdu = selectedRow.Cells["DataWjazdu"].Value?.ToString();
                    this.czasPostoju = selectedRow.Cells["CzasPostoju"].Value?.ToString();
                    this.zaplata = selectedRow.Cells["Zapłata"].Value?.ToString();

                    // Zwolnij miejsce
                    string zajeteMiejsce = selectedRow.Cells["Miejsce"].Value.ToString();
                    string rodzajPojazdu = selectedRow.Cells["Rodzaj"].Value.ToString();

                    if (rodzajPojazdu == "osobowy")
                    {
                        zajeteMiejscaOs.Remove(zajeteMiejsce);
                    }
                    else if (rodzajPojazdu == "ciężarowy")
                    {
                        zajeteMiejscaCi.Remove(zajeteMiejsce);
                    }



                    // Zmiana statusu tylko jeśli wcześniej był "Zaparkowany"
                    if (statusPrzedEdycja == "Zaparkowany")
                    {
                        selectedRow.Cells["Status"].Value = "Wyjechał";
                    }

                    // Wywołaj okno Paragon
                    Paragon paragonForm = new Paragon(dataWjazdu, godzinaWjazdu.ToString("HH:mm"), godzinaWyjazdu, czasPostoju.ToString(), zaplata.ToString());
                    paragonForm.ShowDialog();
                }
                else
                {
                    // Jeśli konwersja godzin się nie powiedzie, wyświetl komunikat
                    MessageBox.Show("Błąd podczas konwersji godzin.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Jeśli nie wybrano wiersza, wyświetl komunikat
                MessageBox.Show("Nie wybrano wiersza do zatwierdzenia wyjazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaveDataToJsonFile();
            ClearForm();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Przeniesienie danych do TextBox-ów
                comboBoxMarka.Text = row.Cells["Marka"].Value.ToString();
                comboBoxRodzaj.Text = row.Cells["Rodzaj"].Value.ToString();
                txtNrRej.Text = row.Cells["NrRej"].Value.ToString();


                // Ustaw aktualną godzinę
                txtGodzina.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0)
            {
                // Sprawdź wartość w kolumnie "Status"
                string statusValue = e.Value?.ToString() ?? string.Empty;

                // Ustaw kolor w zależności od wartości
                if (statusValue == "Zaparkowany")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (statusValue == "Wyjechał")
                {
                    e.CellStyle.ForeColor = Color.Gray;
                    // Wyszarz tekst w pozostałych kolumnach
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.Name != "Status") // Pomijamy kolumnę "Status"
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[column.Index].Style.ForeColor = Color.Gray;
                        }
                    }
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pobierz miejsce i rodzaj pojazdu
                string miejsce = selectedRow.Cells["Miejsce"].Value.ToString();
                string rodzajPojazdu = selectedRow.Cells["Rodzaj"].Value.ToString();

                // Usuń wiersz z dataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Zwolnij miejsce
                if (rodzajPojazdu == "osobowy")
                {
                    zajeteMiejscaOs.Remove(miejsce);
                }
                else if (rodzajPojazdu == "ciężarowy")
                {
                    zajeteMiejscaCi.Remove(miejsce);
                }

                // Zapisz zmiany do pliku JSON
                SaveDataToJsonFile();
            }
            else
            {
                MessageBox.Show("Nie wybrano wiersza do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
