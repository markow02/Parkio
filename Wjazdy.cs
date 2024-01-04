using MySql.Data.MySqlClient;
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
    public partial class Wjazdy : Form
    {
        public Wjazdy()
        {
            InitializeComponent();
        }

        private void Wjazdy_Load(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM rezerwacja " +
                               "LEFT JOIN samochod ON rezerwacja.id_samochod = samochod.id_samochod";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                dataGridViewEntry.AutoGenerateColumns = false;
                bindingSource.DataSource = dt;
                dataGridViewEntry.DataSource = bindingSource;

                database.close_db();


            }
            else
            {
                MessageBox.Show("Database error");
            }
        }
    }
}
