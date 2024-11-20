namespace SystemParkingowy
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            logiSub = new Panel();
            btnWyjazdy = new Button();
            btnWjazdy = new Button();
            btnLogi = new Button();
            btnKlienci = new Button();
            btnPanelSterowania = new Button();
            btnWyloguj = new Button();
            btnStatus = new Button();
            godzina = new Label();
            label1 = new Label();
            logo1 = new PictureBox();
            panel2 = new Panel();
            czas = new System.Windows.Forms.Timer(components);
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            logiSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(logiSub);
            panel1.Controls.Add(btnLogi);
            panel1.Controls.Add(btnKlienci);
            panel1.Controls.Add(btnPanelSterowania);
            panel1.Controls.Add(btnWyloguj);
            panel1.Controls.Add(btnStatus);
            panel1.Controls.Add(godzina);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logo1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 749);
            panel1.TabIndex = 0;
            // 
            // logiSub
            // 
            logiSub.BackColor = Color.FromArgb(0, 72, 174);
            logiSub.Controls.Add(btnWyjazdy);
            logiSub.Controls.Add(btnWjazdy);
            logiSub.Location = new Point(0, 380);
            logiSub.Name = "logiSub";
            logiSub.Size = new Size(231, 63);
            logiSub.TabIndex = 23;
            // 
            // btnWyjazdy
            // 
            btnWyjazdy.BackColor = Color.FromArgb(0, 72, 174);
            btnWyjazdy.Cursor = Cursors.Hand;
            btnWyjazdy.FlatAppearance.BorderSize = 0;
            btnWyjazdy.FlatStyle = FlatStyle.Flat;
            btnWyjazdy.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnWyjazdy.ForeColor = SystemColors.ControlLightLight;
            btnWyjazdy.Location = new Point(0, 35);
            btnWyjazdy.Name = "btnWyjazdy";
            btnWyjazdy.Padding = new Padding(20, 0, 0, 0);
            btnWyjazdy.Size = new Size(229, 31);
            btnWyjazdy.TabIndex = 1;
            btnWyjazdy.Text = "wyjazdy";
            btnWyjazdy.TextAlign = ContentAlignment.MiddleLeft;
            btnWyjazdy.UseVisualStyleBackColor = false;
            btnWyjazdy.Click += btnWyjazdy_Click;
            // 
            // btnWjazdy
            // 
            btnWjazdy.BackColor = Color.FromArgb(0, 72, 174);
            btnWjazdy.Cursor = Cursors.Hand;
            btnWjazdy.FlatAppearance.BorderSize = 0;
            btnWjazdy.FlatStyle = FlatStyle.Flat;
            btnWjazdy.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnWjazdy.ForeColor = SystemColors.ControlLightLight;
            btnWjazdy.Location = new Point(0, 3);
            btnWjazdy.Name = "btnWjazdy";
            btnWjazdy.Padding = new Padding(20, 0, 0, 0);
            btnWjazdy.Size = new Size(229, 31);
            btnWjazdy.TabIndex = 0;
            btnWjazdy.Text = "wjazdy";
            btnWjazdy.TextAlign = ContentAlignment.MiddleLeft;
            btnWjazdy.UseVisualStyleBackColor = false;
            btnWjazdy.Click += btnWjazdy_Click;
            // 
            // btnLogi
            // 
            btnLogi.BackColor = SystemColors.HotTrack;
            btnLogi.Cursor = Cursors.Hand;
            btnLogi.FlatAppearance.BorderColor = Color.White;
            btnLogi.FlatAppearance.BorderSize = 0;
            btnLogi.FlatStyle = FlatStyle.Flat;
            btnLogi.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogi.ForeColor = SystemColors.ControlLightLight;
            btnLogi.Location = new Point(0, 347);
            btnLogi.Name = "btnLogi";
            btnLogi.Padding = new Padding(10, 0, 0, 0);
            btnLogi.Size = new Size(228, 38);
            btnLogi.TabIndex = 22;
            btnLogi.Text = "Logi";
            btnLogi.TextAlign = ContentAlignment.MiddleLeft;
            btnLogi.UseVisualStyleBackColor = false;
            btnLogi.Click += btnLogi_Click;
            // 
            // btnKlienci
            // 
            btnKlienci.BackColor = SystemColors.HotTrack;
            btnKlienci.Cursor = Cursors.Hand;
            btnKlienci.FlatAppearance.BorderColor = Color.White;
            btnKlienci.FlatAppearance.BorderSize = 0;
            btnKlienci.FlatStyle = FlatStyle.Flat;
            btnKlienci.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKlienci.ForeColor = SystemColors.ControlLightLight;
            btnKlienci.Location = new Point(0, 303);
            btnKlienci.Name = "btnKlienci";
            btnKlienci.Padding = new Padding(10, 0, 0, 0);
            btnKlienci.Size = new Size(228, 38);
            btnKlienci.TabIndex = 21;
            btnKlienci.Text = "Klienci stali";
            btnKlienci.TextAlign = ContentAlignment.MiddleLeft;
            btnKlienci.UseVisualStyleBackColor = false;
            btnKlienci.Click += btnKlienci_Click;
            // 
            // btnPanelSterowania
            // 
            btnPanelSterowania.BackColor = SystemColors.HotTrack;
            btnPanelSterowania.Cursor = Cursors.Hand;
            btnPanelSterowania.FlatAppearance.BorderColor = Color.White;
            btnPanelSterowania.FlatAppearance.BorderSize = 0;
            btnPanelSterowania.FlatStyle = FlatStyle.Flat;
            btnPanelSterowania.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPanelSterowania.ForeColor = SystemColors.ControlLightLight;
            btnPanelSterowania.Location = new Point(0, 259);
            btnPanelSterowania.Name = "btnPanelSterowania";
            btnPanelSterowania.Padding = new Padding(10, 0, 0, 0);
            btnPanelSterowania.Size = new Size(228, 38);
            btnPanelSterowania.TabIndex = 19;
            btnPanelSterowania.Text = "Panel sterowania";
            btnPanelSterowania.TextAlign = ContentAlignment.MiddleLeft;
            btnPanelSterowania.UseVisualStyleBackColor = false;
            btnPanelSterowania.Click += btnPanelSterowania_Click;
            // 
            // btnWyloguj
            // 
            btnWyloguj.BackColor = SystemColors.ControlDarkDark;
            btnWyloguj.Cursor = Cursors.Hand;
            btnWyloguj.Dock = DockStyle.Bottom;
            btnWyloguj.FlatAppearance.BorderSize = 0;
            btnWyloguj.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnWyloguj.FlatStyle = FlatStyle.Flat;
            btnWyloguj.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWyloguj.ForeColor = SystemColors.ControlLightLight;
            btnWyloguj.Location = new Point(0, 711);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new Size(228, 38);
            btnWyloguj.TabIndex = 18;
            btnWyloguj.Text = "Zamknij";
            btnWyloguj.UseVisualStyleBackColor = false;
            btnWyloguj.Click += btnWyloguj_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = SystemColors.HotTrack;
            btnStatus.Cursor = Cursors.Hand;
            btnStatus.FlatAppearance.BorderColor = Color.White;
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStatus.ForeColor = SystemColors.ControlLightLight;
            btnStatus.Location = new Point(0, 215);
            btnStatus.Name = "btnStatus";
            btnStatus.Padding = new Padding(10, 0, 0, 0);
            btnStatus.Size = new Size(228, 38);
            btnStatus.TabIndex = 13;
            btnStatus.Text = "Status";
            btnStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // godzina
            // 
            godzina.AutoSize = true;
            godzina.Dock = DockStyle.Top;
            godzina.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            godzina.ForeColor = SystemColors.ControlLightLight;
            godzina.Location = new Point(0, 134);
            godzina.Name = "godzina";
            godzina.Size = new Size(138, 55);
            godzina.TabIndex = 12;
            godzina.Text = "Czas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(113, 39);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 2;
            label1.Text = "Parkio";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logo1
            // 
            logo1.BackgroundImage = (Image)resources.GetObject("logo1.BackgroundImage");
            logo1.BackgroundImageLayout = ImageLayout.None;
            logo1.Image = (Image)resources.GetObject("logo1.Image");
            logo1.Location = new Point(12, 12);
            logo1.Name = "logo1";
            logo1.Size = new Size(97, 100);
            logo1.TabIndex = 1;
            logo1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 134);
            panel2.TabIndex = 24;
            // 
            // czas
            // 
            czas.Enabled = true;
            czas.Tick += timer1_Tick_1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = SystemColors.Control;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(228, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1138, 749);
            panelChildForm.TabIndex = 1;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 749);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parkio";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            logiSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox logo1;
        private Label label1;
        private Label godzina;
        private System.Windows.Forms.Timer czas;
        private Button btnStatus;
        private Button btnWyloguj;
        private Button btnLogi;
        private Button btnKlienci;
        private Button btnPanelSterowania;
        private Panel panelChildForm;
        private Panel logiSub;
        private Button btnWjazdy;
        private Button btnWyjazdy;
        private Panel panel2;
    }
}
