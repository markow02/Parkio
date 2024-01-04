using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;    

namespace SystemParkingowy
{
    public partial class Menu : Form
    {
        Bitmap bitmap;

/*        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();

        String server = "mysql-parking-systemparkingowy.a.aivencloud.com";
        String username = "avnadmin";
        String password = "AVNS_zolYLfA9eq4RPl2PH7Y";
        String database = "parking";*/



        private Button? currentButton; // Zmienna do œledzenia bie¿¹cego przycisku


        public Menu()
        {
            InitializeComponent();
            openChildForm(new Status(), btnStatus);
            customDesign();
            FormClosed += Menu_FormClosed;

        }

        private void customDesign()
        {
            logiSub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (logiSub.Visible)
                logiSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu, Button senderButton)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

            ChangeButtonColor(senderButton);
        }

        private void ChangeButtonColor(Button senderButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(0, 102, 204);
            }
            senderButton.BackColor = Color.FromArgb(0, 72, 174);
            currentButton = senderButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            czas.Start();
            godzina.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            godzina.Text = DateTime.Now.ToLongTimeString();
            czas.Start();
        }

        public Form? activeForm = null; //nullable gdy jest '?'
        public void openChildForm(Form childForm, Button senderButton)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            ChangeButtonColor(senderButton);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new Status(), btnStatus);
            hideSubMenu();
        }

        private void btnPanelSterowania_Click(object sender, EventArgs e)
        {
            openChildForm(new PanelSterowania(), btnPanelSterowania);
            hideSubMenu();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            openChildForm(new Monitoring(), btnMonitoring);
            hideSubMenu();
        }

        private void btnKlienci_Click(object sender, EventArgs e)
        {
            openChildForm(new Klienci(), btnKlienci);
            hideSubMenu();
        }

        private void btnLogi_Click(object sender, EventArgs e)
        {
            showSubMenu(logiSub, btnLogi);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login newLoginForm = new Login();
            newLoginForm.Show();
        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnWjazdy_Click(object sender, EventArgs e)
        {
            openChildForm(new Wjazdy(), btnLogi);
            hideSubMenu();
        }

        private void btnWyjazdy_Click(object sender, EventArgs e)
        {
            openChildForm(new Wyjazdy(), btnLogi);
            hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
