namespace SystemParkingowy
{
    partial class PanelSterowania
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
            dataGridView1 = new DataGridView();
            txtNrRej = new TextBox();
            btnZatwierdzWjazd = new Button();
            btnZatwierdzWyjazd = new Button();
            comboBoxRodzaj = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtGodzina = new TextBox();
            label4 = new Label();
            comboBoxMarka = new ComboBox();
            btnUsun = new Button();
            cbabonament = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 263);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1676, 778);
            dataGridView1.TabIndex = 1;
            // 
            // txtNrRej
            // 
            txtNrRej.BorderStyle = BorderStyle.FixedSingle;
            txtNrRej.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNrRej.Location = new Point(352, 44);
            txtNrRej.Name = "txtNrRej";
            txtNrRej.Size = new Size(152, 27);
            txtNrRej.TabIndex = 4;
            // 
            // btnZatwierdzWjazd
            // 
            btnZatwierdzWjazd.BackColor = Color.FromArgb(0, 192, 0);
            btnZatwierdzWjazd.FlatAppearance.BorderSize = 0;
            btnZatwierdzWjazd.FlatStyle = FlatStyle.Flat;
            btnZatwierdzWjazd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZatwierdzWjazd.ForeColor = SystemColors.ControlLightLight;
            btnZatwierdzWjazd.Location = new Point(91, 123);
            btnZatwierdzWjazd.Name = "btnZatwierdzWjazd";
            btnZatwierdzWjazd.Size = new Size(149, 26);
            btnZatwierdzWjazd.TabIndex = 5;
            btnZatwierdzWjazd.Text = "WJAZD";
            btnZatwierdzWjazd.UseVisualStyleBackColor = false;
            btnZatwierdzWjazd.Click += btnZatwierdzWjazd_Click;
            // 
            // btnZatwierdzWyjazd
            // 
            btnZatwierdzWyjazd.BackColor = Color.Red;
            btnZatwierdzWyjazd.FlatAppearance.BorderSize = 0;
            btnZatwierdzWyjazd.FlatStyle = FlatStyle.Flat;
            btnZatwierdzWyjazd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZatwierdzWyjazd.ForeColor = SystemColors.ControlLightLight;
            btnZatwierdzWyjazd.Location = new Point(270, 123);
            btnZatwierdzWyjazd.Name = "btnZatwierdzWyjazd";
            btnZatwierdzWyjazd.Size = new Size(149, 26);
            btnZatwierdzWyjazd.TabIndex = 6;
            btnZatwierdzWyjazd.Text = "WYJAZD";
            btnZatwierdzWyjazd.UseVisualStyleBackColor = false;
            btnZatwierdzWyjazd.Click += btnZatwierdzWyjazd_Click;
            // 
            // comboBoxRodzaj
            // 
            comboBoxRodzaj.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRodzaj.FormattingEnabled = true;
            comboBoxRodzaj.Items.AddRange(new object[] { "osobowy", "ciężarowy" });
            comboBoxRodzaj.Location = new Point(188, 44);
            comboBoxRodzaj.Name = "comboBoxRodzaj";
            comboBoxRodzaj.Size = new Size(152, 27);
            comboBoxRodzaj.TabIndex = 7;
            comboBoxRodzaj.Text = "Wybierz...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 8;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(185, 22);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 9;
            label2.Text = "Rodzaj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(352, 22);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 10;
            label3.Text = "Nr rejestracyjny";
            // 
            // txtGodzina
            // 
            txtGodzina.BorderStyle = BorderStyle.FixedSingle;
            txtGodzina.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGodzina.Location = new Point(1012, 46);
            txtGodzina.Name = "txtGodzina";
            txtGodzina.Size = new Size(152, 27);
            txtGodzina.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1012, 22);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 12;
            label4.Text = "Godzina wyjazdu";
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.AutoCompleteMode = AutoCompleteMode.Append;
            comboBoxMarka.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMarka.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Items.AddRange(new object[] { "Abarth", "AC", "Acura", "AIXAM", "Alfa Romeo", "Alpine", "Arash", "Ariel", "Artega", "Ascari", "Aston Martin", "Audi", "AvtoVAZ", "BAIC", "Bentley", "BMW", "Borgward", "Brilliance", "Bristol", "Bufori", "Bugatti", "Buick", "Byton", "Cadillac", "Caterham", "Changan", "Changhe", "Chery", "Chevrolet", "Chrysler", "Citroen", "Coda", "CT&T", "Dacia", "Daewoo", "DAF", "Daihatsu", "Datsun", "Dodge", "Donkervoort", "DS", "Ferrari", "Fiat", "Fisker", "Force Motors", "Ford", "Foton", "GAZ", "Geely", "Genesis", "Ginetta", "GMC", "Great Wall", "Haima", "Hino", "Holden", "Honda", "Hyundai", "Iconic", "Infiniti", "Isuzu", "IVECO", "JAC", "Jaguar", "Jeep", "JMC", "Kia", "Koenigsegg", "Lamborghini", "Lancia", "Land Rover", "Landwind", "Lexus", "Lifan", "Lincoln", "Lotus", "Luxgen", "Magna Steyr", "Mahindra", "Maserati", "Maxus", "Maybach", "Mazda", "Mazzanti", "McLaren", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Mitsuoka", "Morgan", "Morris", "NIO", "Nissan", "Noble", "Opel", "Pagani", "Perodua", "Peugeot", "Polestar", "Pontiac", "Porsche", "Proton", "Ram", "Reliant", "Renault", "Rimac", "Rivian", "Rolls-Royce", "RUF", "Saab", "Saleen", "Saturn", "Scania", "Scion", "SEAT", "Senova", "SIN Cars", "Skoda", "Smart", "Spyker", "Ssangyong", "Subaru", "Suzuki", "Tata", "Tatra", "Tesla", "Toyota", "Trumpchi", "TVR", "Vauxhall", "Volkswagen", "Volvo", "W Motors", "Wiesmann", "Zenos", "Zenvo" });
            comboBoxMarka.Location = new Point(23, 44);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(152, 27);
            comboBoxMarka.TabIndex = 13;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = Color.Gray;
            btnUsun.FlatAppearance.BorderSize = 0;
            btnUsun.FlatStyle = FlatStyle.Flat;
            btnUsun.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsun.ForeColor = SystemColors.ControlLightLight;
            btnUsun.Location = new Point(443, 123);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(149, 26);
            btnUsun.TabIndex = 14;
            btnUsun.Text = "USUŃ POZYCJĘ";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click;
            // 
            // cbabonament
            // 
            cbabonament.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbabonament.FormattingEnabled = true;
            cbabonament.Location = new Point(694, 44);
            cbabonament.Name = "cbabonament";
            cbabonament.Size = new Size(152, 27);
            cbabonament.TabIndex = 15;
            cbabonament.Text = "Wybierz...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(694, 22);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 16;
            label5.Text = "Abonament";
            // 
            // PanelSterowania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1676, 1041);
            Controls.Add(label5);
            Controls.Add(cbabonament);
            Controls.Add(btnUsun);
            Controls.Add(comboBoxMarka);
            Controls.Add(label4);
            Controls.Add(txtGodzina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRodzaj);
            Controls.Add(btnZatwierdzWyjazd);
            Controls.Add(btnZatwierdzWjazd);
            Controls.Add(txtNrRej);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanelSterowania";
            Text = "PanelSterowania";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtNrRej;
        private Button btnZatwierdzWjazd;
        private Button btnZatwierdzWyjazd;
        private ComboBox comboBoxRodzaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGodzina;
        private Label label4;
        private ComboBox comboBoxMarka;
        private Button btnUsun;
        private ComboBox cbabonament;
        private Label label5;
    }
}