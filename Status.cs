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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            var database = new Database();

            if (database.connect_db())
            {
                string query = "SELECT * FROM miejsce";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                dataGridViewPlace.AutoGenerateColumns = false;
                bindingSource.DataSource = dt;
                dataGridViewPlace.DataSource = bindingSource;

                database.close_db();


            }
            else
            {
                MessageBox.Show("Database error");
            }
        }
    }
}
