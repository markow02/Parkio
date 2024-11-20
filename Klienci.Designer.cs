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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnConfirm = new Button();
            textBoxModelPojazdu = new TextBox();
            textBoxNumerRej = new TextBox();
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
            DateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            DateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            comboBoxRodzaj = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            textBoxNumerTelefonu = new MaskedTextBox();
            textBoxMarkaPojazdu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(91, 123);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 26);
            btnConfirm.TabIndex = 32;
            btnConfirm.Text = "DODAJ";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += BtnConfirm_Click;
            // 
            // textBoxModelPojazdu
            // 
            textBoxModelPojazdu.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxModelPojazdu.Location = new Point(676, 44);
            textBoxModelPojazdu.Name = "textBoxModelPojazdu";
            textBoxModelPojazdu.Size = new Size(152, 27);
            textBoxModelPojazdu.TabIndex = 31;
            // 
            // textBoxNumerRej
            // 
            textBoxNumerRej.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumerRej.Location = new Point(1003, 44);
            textBoxNumerRej.Name = "textBoxNumerRej";
            textBoxNumerRej.Size = new Size(152, 27);
            textBoxNumerRej.TabIndex = 30;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(188, 44);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(152, 27);
            textBoxNazwisko.TabIndex = 27;
            // 
            // textBoxImie
            // 
            textBoxImie.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(23, 44);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(152, 27);
            textBoxImie.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(675, 22);
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
            label5.Location = new Point(1001, 22);
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
            label4.Location = new Point(513, 22);
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
            label3.Location = new Point(352, 22);
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
            label2.Location = new Point(185, 22);
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
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 19;
            label1.Text = "Imię";
            // 
            // nowy_klient
            // 
            nowy_klient.BackColor = SystemColors.ActiveCaption;
            nowy_klient.FlatAppearance.BorderSize = 0;
            nowy_klient.FlatStyle = FlatStyle.Flat;
            nowy_klient.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nowy_klient.ForeColor = SystemColors.ControlLightLight;
            nowy_klient.Location = new Point(1497, 121);
            nowy_klient.Name = "nowy_klient";
            nowy_klient.Size = new Size(157, 30);
            nowy_klient.TabIndex = 34;
            nowy_klient.Text = "WYCZYŚĆ";
            nowy_klient.UseVisualStyleBackColor = false;
            nowy_klient.Click += Nowy_klient_Click;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowDrop = true;
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AllowUserToDeleteRows = false;
            dataGridViewCustomers.AllowUserToResizeColumns = false;
            dataGridViewCustomers.AllowUserToResizeRows = false;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomers.Dock = DockStyle.Bottom;
            dataGridViewCustomers.Location = new Point(0, 263);
            dataGridViewCustomers.MultiSelect = false;
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowTemplate.Height = 25;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(1676, 778);
            dataGridViewCustomers.TabIndex = 35;
            dataGridViewCustomers.CellClick += DataGridViewCustomers_CellClick_1;
            // 
            // usunKlienta
            // 
            usunKlienta.BackColor = Color.Gray;
            usunKlienta.FlatAppearance.BorderSize = 0;
            usunKlienta.FlatStyle = FlatStyle.Flat;
            usunKlienta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usunKlienta.ForeColor = SystemColors.ControlLightLight;
            usunKlienta.Location = new Point(443, 123);
            usunKlienta.Name = "usunKlienta";
            usunKlienta.Size = new Size(149, 26);
            usunKlienta.TabIndex = 36;
            usunKlienta.Text = "USUŃ";
            usunKlienta.UseVisualStyleBackColor = false;
            usunKlienta.Click += UsunKlienta_Click;
            // 
            // aktualizujKlienta
            // 
            aktualizujKlienta.BackColor = Color.FromArgb(255, 128, 0);
            aktualizujKlienta.FlatAppearance.BorderSize = 0;
            aktualizujKlienta.FlatStyle = FlatStyle.Flat;
            aktualizujKlienta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            aktualizujKlienta.ForeColor = SystemColors.ControlLightLight;
            aktualizujKlienta.Location = new Point(270, 123);
            aktualizujKlienta.Name = "aktualizujKlienta";
            aktualizujKlienta.Size = new Size(149, 26);
            aktualizujKlienta.TabIndex = 37;
            aktualizujKlienta.Text = "AKTUALIZUJ";
            aktualizujKlienta.UseVisualStyleBackColor = false;
            aktualizujKlienta.Click += AktualizujKlienta_Click;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Checked = false;
            DateTimePicker1.CustomFormat = "";
            DateTimePicker1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.Location = new Point(1163, 44);
            DateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(157, 27);
            DateTimePicker1.TabIndex = 38;
            DateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(1166, 22);
            label8.Name = "label8";
            label8.Size = new Size(29, 19);
            label8.TabIndex = 39;
            label8.Text = "Od";
            // 
            // DateTimePicker2
            // 
            DateTimePicker2.Checked = false;
            DateTimePicker2.CustomFormat = "";
            DateTimePicker2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker2.Format = DateTimePickerFormat.Custom;
            DateTimePicker2.Location = new Point(1329, 44);
            DateTimePicker2.MinDate = new DateTime(2024, 1, 18, 0, 0, 0, 0);
            DateTimePicker2.Name = "DateTimePicker2";
            DateTimePicker2.Size = new Size(155, 27);
            DateTimePicker2.TabIndex = 40;
            DateTimePicker2.ValueChanged += DateTimePicker2_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(1331, 22);
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
            label11.Location = new Point(836, 22);
            label11.Name = "label11";
            label11.Size = new Size(54, 19);
            label11.TabIndex = 42;
            label11.Text = "Rodzaj";
            // 
            // comboBoxRodzaj
            // 
            comboBoxRodzaj.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRodzaj.FormattingEnabled = true;
            comboBoxRodzaj.Items.AddRange(new object[] { "osobowy", "ciężarowy" });
            comboBoxRodzaj.Location = new Point(837, 44);
            comboBoxRodzaj.Name = "comboBoxRodzaj";
            comboBoxRodzaj.Size = new Size(157, 27);
            comboBoxRodzaj.TabIndex = 43;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(1497, 44);
            maskedTextBox1.Mask = "000 zł";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(157, 27);
            maskedTextBox1.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(1493, 22);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 45;
            label7.Text = "Należność";
            // 
            // textBoxNumerTelefonu
            // 
            textBoxNumerTelefonu.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumerTelefonu.Location = new Point(352, 44);
            textBoxNumerTelefonu.Mask = "000-000-000";
            textBoxNumerTelefonu.Name = "textBoxNumerTelefonu";
            textBoxNumerTelefonu.Size = new Size(152, 27);
            textBoxNumerTelefonu.TabIndex = 46;
            // 
            // textBoxMarkaPojazdu
            // 
            textBoxMarkaPojazdu.AutoCompleteMode = AutoCompleteMode.Append;
            textBoxMarkaPojazdu.AutoCompleteSource = AutoCompleteSource.ListItems;
            textBoxMarkaPojazdu.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMarkaPojazdu.FormattingEnabled = true;
            textBoxMarkaPojazdu.Items.AddRange(new object[] { "Abarth", "AC", "Acura", "AIXAM", "Alfa Romeo", "Alpine", "Arash", "Ariel", "Artega", "Ascari", "Aston Martin", "Audi", "AvtoVAZ", "BAIC", "Bentley", "BMW", "Borgward", "Brilliance", "Bristol", "Bufori", "Bugatti", "Buick", "Byton", "Cadillac", "Caterham", "Changan", "Changhe", "Chery", "Chevrolet", "Chrysler", "Citroen", "Coda", "CT&T", "Dacia", "Daewoo", "DAF", "Daihatsu", "Datsun", "Dodge", "Donkervoort", "DS", "Ferrari", "Fiat", "Fisker", "Force Motors", "Ford", "Foton", "GAZ", "Geely", "Genesis", "Ginetta", "GMC", "Great Wall", "Haima", "Hino", "Holden", "Honda", "Hyundai", "Iconic", "Infiniti", "Isuzu", "IVECO", "JAC", "Jaguar", "Jeep", "JMC", "Kia", "Koenigsegg", "Lamborghini", "Lancia", "Land Rover", "Landwind", "Lexus", "Lifan", "Lincoln", "Lotus", "Luxgen", "Magna Steyr", "Mahindra", "Maserati", "Maxus", "Maybach", "Mazda", "Mazzanti", "McLaren", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Mitsuoka", "Morgan", "Morris", "NIO", "Nissan", "Noble", "Opel", "Pagani", "Perodua", "Peugeot", "Polestar", "Pontiac", "Porsche", "Proton", "Ram", "Reliant", "Renault", "Rimac", "Rivian", "Rolls-Royce", "RUF", "Saab", "Saleen", "Saturn", "Scania", "Scion", "SEAT", "Senova", "SIN Cars", "Skoda", "Smart", "Spyker", "Ssangyong", "Subaru", "Suzuki", "Tata", "Tatra", "Tesla", "Toyota", "Trumpchi", "TVR", "Vauxhall", "Volkswagen", "Volvo", "W Motors", "Wiesmann", "Zenos", "Zenvo" });
            textBoxMarkaPojazdu.Location = new Point(515, 44);
            textBoxMarkaPojazdu.Name = "textBoxMarkaPojazdu";
            textBoxMarkaPojazdu.Size = new Size(152, 27);
            textBoxMarkaPojazdu.TabIndex = 47;
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1676, 1041);
            Controls.Add(textBoxMarkaPojazdu);
            Controls.Add(textBoxNumerTelefonu);
            Controls.Add(label7);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBoxRodzaj);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(DateTimePicker2);
            Controls.Add(label8);
            Controls.Add(DateTimePicker1);
            Controls.Add(aktualizujKlienta);
            Controls.Add(usunKlienta);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(nowy_klient);
            Controls.Add(btnConfirm);
            Controls.Add(textBoxModelPojazdu);
            Controls.Add(textBoxNumerRej);
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

        private Button btnConfirm;
        private TextBox textBoxModelPojazdu;
        private TextBox textBoxNumerRej;
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
        private Label label8;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxRodzaj;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox textBoxNumerTelefonu;
        private ComboBox textBoxMarkaPojazdu;
        private DateTimePicker DateTimePicker1;
        private DateTimePicker DateTimePicker2;
    }
}