namespace SystemParkingowy
   
{
    partial class Klienci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnConfirm = new Button();
            textBoxModelPojazdu = new TextBox();
            textBoxNumerRej = new TextBox();
            textBoxMarkaPojazdu = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxImie = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nowy_klient = new Button();
            dataGridViewCustomers = new DataGridView();
            usunKlienta = new Button();
            aktualizujKlienta = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            textBoxNumerTelefonu = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(21, 49);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 31);
            btnConfirm.TabIndex = 32;
            btnConfirm.Text = "Dodaj klienta";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += BtnConfirm_Click;
            // 
            // textBoxModelPojazdu
            // 
            textBoxModelPojazdu.Location = new Point(396, 83);
            textBoxModelPojazdu.Name = "textBoxModelPojazdu";
            textBoxModelPojazdu.Size = new Size(152, 23);
            textBoxModelPojazdu.TabIndex = 31;
            // 
            // textBoxNumerRej
            // 
            textBoxNumerRej.Location = new Point(397, 131);
            textBoxNumerRej.Name = "textBoxNumerRej";
            textBoxNumerRej.Size = new Size(152, 23);
            textBoxNumerRej.TabIndex = 30;
            // 
            // textBoxMarkaPojazdu
            // 
            textBoxMarkaPojazdu.Location = new Point(397, 34);
            textBoxMarkaPojazdu.Name = "textBoxMarkaPojazdu";
            textBoxMarkaPojazdu.Size = new Size(151, 23);
            textBoxMarkaPojazdu.TabIndex = 29;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(186, 83);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(152, 23);
            textBoxNazwisko.TabIndex = 27;
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(186, 34);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(151, 23);
            textBoxImie.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(397, 61);
            label9.Name = "label9";
            label9.Size = new Size(53, 19);
            label9.TabIndex = 25;
            label9.Text = "Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(730, 155);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(396, 111);
            label5.Name = "label5";
            label5.Size = new Size(148, 19);
            label5.TabIndex = 23;
            label5.Text = "Numer rejestracyjny";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(397, 12);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 22;
            label4.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(186, 111);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 21;
            label3.Text = "Numer telefonu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(186, 61);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 20;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(186, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 19;
            label1.Text = "Imię";
            // 
            // nowy_klient
            // 
            nowy_klient.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nowy_klient.ForeColor = SystemColors.ControlText;
            nowy_klient.Location = new Point(21, 12);
            nowy_klient.Name = "nowy_klient";
            nowy_klient.Size = new Size(100, 31);
            nowy_klient.TabIndex = 34;
            nowy_klient.Text = "Nowy klient";
            nowy_klient.UseVisualStyleBackColor = true;
            nowy_klient.Click += Nowy_klient_Click;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCustomers.Location = new Point(12, 188);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCustomers.RowTemplate.Height = 25;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCustomers.Size = new Size(1098, 370);
            dataGridViewCustomers.TabIndex = 35;
            dataGridViewCustomers.CellClick += DataGridViewCustomers_CellClick_1;
            // 
            // usunKlienta
            // 
            usunKlienta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usunKlienta.Location = new Point(21, 123);
            usunKlienta.Name = "usunKlienta";
            usunKlienta.Size = new Size(100, 31);
            usunKlienta.TabIndex = 36;
            usunKlienta.Text = "Usun klienta";
            usunKlienta.UseVisualStyleBackColor = true;
            usunKlienta.Click += UsunKlienta_Click;
            // 
            // aktualizujKlienta
            // 
            aktualizujKlienta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            aktualizujKlienta.Location = new Point(21, 86);
            aktualizujKlienta.Name = "aktualizujKlienta";
            aktualizujKlienta.Size = new Size(100, 31);
            aktualizujKlienta.TabIndex = 37;
            aktualizujKlienta.Text = "Aktualizuj";
            aktualizujKlienta.UseVisualStyleBackColor = true;
            aktualizujKlienta.Click += AktualizujKlienta_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(607, 37);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 23);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(607, 12);
            label8.Name = "label8";
            label8.Size = new Size(29, 19);
            label8.TabIndex = 39;
            label8.Text = "Od";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Checked = false;
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(605, 83);
            dateTimePicker2.MinDate = new DateTime(2024, 1, 18, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(155, 23);
            dateTimePicker2.TabIndex = 40;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(607, 61);
            label10.Name = "label10";
            label10.Size = new Size(28, 19);
            label10.TabIndex = 41;
            label10.Text = "Do";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(603, 111);
            label11.Name = "label11";
            label11.Size = new Size(110, 19);
            label11.TabIndex = 42;
            label11.Text = "Numer miejsca";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Os01", "Os02", "Os03", "Os04", "Os05", "Os06", "Os07", "Os08", "Os09", "Os10" });
            comboBox1.Location = new Point(603, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 43;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(798, 37);
            maskedTextBox1.Mask = "000 zł";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(157, 23);
            maskedTextBox1.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(798, 12);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 45;
            label7.Text = "Należność";
            // 
            // textBoxNumerTelefonu
            // 
            textBoxNumerTelefonu.Location = new Point(186, 133);
            textBoxNumerTelefonu.Mask = "000-000-000";
            textBoxNumerTelefonu.Name = "textBoxNumerTelefonu";
            textBoxNumerTelefonu.Size = new Size(152, 23);
            textBoxNumerTelefonu.TabIndex = 46;
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1676, 1041);
            Controls.Add(textBoxNumerTelefonu);
            Controls.Add(label7);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(aktualizujKlienta);
            Controls.Add(usunKlienta);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(nowy_klient);
            Controls.Add(btnConfirm);
            Controls.Add(textBoxModelPojazdu);
            Controls.Add(textBoxNumerRej);
            Controls.Add(textBoxMarkaPojazdu);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Klienci";
            Text = "Klienci";
            Load += Klienci_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deleteClients;
        private DataGridViewTextBoxColumn imie;
        private DataGridViewTextBoxColumn nazwisko;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn ulica;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
        private DataGridViewTextBoxColumn ID_klient;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn nr_domu;
        private DataGridViewTextBoxColumn nr_mieszkania;
        private DataGridViewTextBoxColumn nr_rejestracyjny;
        private DataGridViewTextBoxColumn nr_ubezpieczenia;
        private DataGridViewTextBoxColumn Od;
        private DataGridViewTextBoxColumn Do;
        private DataGridViewTextBoxColumn typ_abonamentu;
        private Button btnConfirm;
        private TextBox textBoxModelPojazdu;
        private TextBox textBoxNumerRej;
        private TextBox textBoxMarkaPojazdu;
        private TextBox textBoxNazwisko;
        private TextBox textBoxImie;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button nowy_klient;
        private DataGridView dataGridViewCustomers;
        private Button usunKlienta;
        private Button aktualizujKlienta;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private Label label11;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox textBoxNumerTelefonu;
    }
}