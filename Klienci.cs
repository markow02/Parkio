using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemParkingowy
{
    public partial class Klienci : Form
    {

        public Klienci()
        {
            InitializeComponent();
        }


        private void btnNewClient_Click(object sender, EventArgs e)
        {
            DodajKlienta newClient = new DodajKlienta();
            newClient.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void Klienci_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            var database = new Database();
                if (database.connect_db())
                {
                string query = "SELECT imie, nazwisko, telefon, pesel, ulica, nazwa_miejscowosci FROM klient " +
                               "LEFT JOIN adres ON klient.id_adres = adres.id_adres " +
                               "RIGHT JOIN miejscowosc ON adres.id_miejscowosc = miejscowosc.id_miejscowosc";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                dataGridViewCustomers.AutoGenerateColumns = false;
                bindingSource.DataSource = dt;
                
                dataGridViewCustomers.DataSource = bindingSource;
                
                database.close_db();


                }
                else{
                    MessageBox.Show("Database error");
                }
        }

    }
}
