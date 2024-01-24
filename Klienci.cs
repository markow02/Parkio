using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemParkingowy
{
    public partial class Klienci : Form
    {
        DataTable dataTable = new DataTable();
        int index;
        int lastUsedID = 0;

        public Klienci()
        {
            InitializeComponent();

        }
        private void Klienci_Load(object sender, EventArgs e)
        {


            //  ścieżka do folderu, w którym znajduje się plik wykonywalny aplikacji
            string appFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "klienciTXT");

            // ścieżka do pliku tekstowego w folderze aplikacji
            string filePath = Path.Combine(appFolderPath, "plik.txt");

            try
            {
                if (File.Exists(filePath))
                {
                    // wczytywanie linijek z pliku
                    string[] lines = File.ReadAllLines(filePath);

                    // Dodaj kolumny do DataTable
                    dataTable.Columns.Add("ID Klienta", Type.GetType("System.String"));
                    dataTable.Columns.Add("Imie", Type.GetType("System.String"));
                    dataTable.Columns.Add("Nazwisko", Type.GetType("System.String"));
                    dataTable.Columns.Add("Telefon", Type.GetType("System.String"));
                    dataTable.Columns.Add("Marka", Type.GetType("System.String"));
                    dataTable.Columns.Add("Model", Type.GetType("System.String"));
                    dataTable.Columns.Add("Nr rej", Type.GetType("System.String"));
                    dataTable.Columns.Add("Od", typeof(DateTime));
                    dataTable.Columns.Add("Do", typeof(DateTime));
                    dataTable.Columns.Add("Nr miejsca", Type.GetType("System.String"));
                    dataTable.Columns.Add("Należność", Type.GetType("System.String"));

                    // Dodaj dane z pliku do DataTable
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(';');
                        dataTable.Rows.Add(values);
                    }

                    // Ustaw źródło danych dla DataGridView
                    dataGridViewCustomers.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataTable.Rows.Count > 0)
            {
                // Znajdź maksymalne ID w istniejących danych
                lastUsedID = dataTable.AsEnumerable()
                                      .Select(row => Convert.ToInt32(row["ID Klienta"]))
                                      .Max();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (CzyPolaWypelnione())
            {
                lastUsedID++;
                dataTable.Rows.Add(lastUsedID, textBoxImie.Text, textBoxNazwisko.Text, textBoxNumerTelefonu.Text,
                textBoxMarkaPojazdu.Text, textBoxModelPojazdu.Text, textBoxNumerRej.Text, dateTimePicker1.Value, dateTimePicker2.Value,
                comboBox1.Text, maskedTextBox1.Text);

                SaveDataToFile();
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola przed dodaniem klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // czyszczenie uzupełnionych textBoxow
        private void Nowy_klient_Click(object sender, EventArgs e)
        {
            textBoxImie.Text = string.Empty;
            textBoxNazwisko.Text = string.Empty;
            textBoxNumerTelefonu.Text = string.Empty;
            textBoxMarkaPojazdu.Text = string.Empty;
            textBoxModelPojazdu.Text = string.Empty;
            textBoxNumerRej.Text = string.Empty;
            comboBox1.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
        }

        // usuwanie klienta z tabeli
        private void UsunKlienta_Click(object sender, EventArgs e)
        {
            index = dataGridViewCustomers.CurrentCell.RowIndex;
            dataGridViewCustomers.Rows.RemoveAt(index);
            SaveDataToFile();
        }

        // klikanie w komórkę i przekazywanie danych do textboxa w celu edycji
        private void DataGridViewCustomers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            index = e.RowIndex;
               if (dataGridViewCustomers.Rows.Count > 0 && index >= 0 && index < dataGridViewCustomers.Rows.Count)
               {
                DataGridViewRow row = dataGridViewCustomers.Rows[index];
                textBoxImie.Text = row.Cells[1].Value.ToString();
                textBoxNazwisko.Text = row.Cells[2].Value.ToString();
                textBoxNumerTelefonu.Text = row.Cells[3].Value.ToString();
                textBoxMarkaPojazdu.Text = row.Cells[4].Value.ToString();
                textBoxModelPojazdu.Text = row.Cells[5].Value.ToString();
                textBoxNumerRej.Text = row.Cells[6].Value.ToString();
                dateTimePicker1.Text = row.Cells[7].Value.ToString();
                dateTimePicker2.Text = row.Cells[8].Value.ToString();

                comboBox1.Text = row.Cells[9].Value.ToString();
                maskedTextBox1.Text = row.Cells[10].Value.ToString();
                }
               else
               {
                    MessageBox.Show("Nie wybrałeś klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
        }

        // aktualizacja danych klienta
        private void AktualizujKlienta_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewCustomers.Rows[index];
            newdata.Cells[1].Value = textBoxImie.Text;
            newdata.Cells[2].Value = textBoxNazwisko.Text;
            newdata.Cells[3].Value = textBoxNumerTelefonu.Text;
            newdata.Cells[4].Value = textBoxMarkaPojazdu.Text;
            newdata.Cells[5].Value = textBoxModelPojazdu.Text;
            newdata.Cells[6].Value = textBoxNumerRej.Text;
            newdata.Cells[7].Value = dateTimePicker1.Text;
            newdata.Cells[8].Value = dateTimePicker2.Text;
            newdata.Cells[9].Value = comboBox1.Text;
            newdata.Cells[10].Value = maskedTextBox1.Text;

            SaveDataToFile();
        }
        // sprawdza czy pola są wypełnione - przed dodaniem do tabeli
        private bool CzyPolaWypelnione()
        {
            // Sprawdź, czy wszystkie pola tekstowe są wypełnione
            return !string.IsNullOrWhiteSpace(textBoxImie.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxNazwisko.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxNumerTelefonu.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxMarkaPojazdu.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxModelPojazdu.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxNumerRej.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                   !string.IsNullOrWhiteSpace(maskedTextBox1.Text);
        }


        private void SaveDataToFile()
        {
            // Pobierz ścieżkę do folderu, w którym znajduje się plik wykonywalny aplikacji
            string appFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "klienciTXT");

            // Utwórz ścieżkę do pliku tekstowego w folderze aplikacji
            string filePath = Path.Combine(appFolderPath, "plik.txt");

            try
            {
                // Sprawdź, czy folder klienciTXT istnieje, jeśli nie, utwórz go
                if (!Directory.Exists(appFolderPath))
                {
                    Directory.CreateDirectory(appFolderPath);
                }

                // Nadpisz istniejący plik lub utwórz nowy
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Format zapisu do pliku
                        string line = string.Join(";", row.ItemArray);
                        sw.WriteLine(line);
                    }
                }

                MessageBox.Show("Dane zostały zapisane do pliku.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }
      
    }
}
