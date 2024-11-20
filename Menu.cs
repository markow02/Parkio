namespace SystemParkingowy
{
    public partial class Menu : Form
    {
        private Button? currentButton; // Zmienna do œledzenia bie¿¹cego przycisku


        public Menu()
        {
            InitializeComponent();
            openChildForm(new Status(), btnStatus);
            customDesign();
            FormClosed += Menu_FormClosed;

            this.Resize += Menu_Resize;
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            this.Close();
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
