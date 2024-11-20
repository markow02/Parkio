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
    public partial class Login : Form
    {
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "admin";
        public Login()
        {
            InitializeComponent();
           
        }

        private void BtnZaloguj_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameBox.Text;
            string enteredPassword = passwordBox.Text;
            

            if (enteredUsername == CorrectUsername && enteredPassword == CorrectPassword)
            {
                Menu newMenuForm = new Menu();
                newMenuForm.Show();
                this.Hide();        
            }
            else
            {
                MessageBox.Show("Nieprawidłowa nazwa użytkownika lub hasło");
            }
        }

       


    }
}
