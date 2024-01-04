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
            btnNewClient = new Button();
            button1 = new Button();
            dataGridViewCustomers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnNewClient
            // 
            btnNewClient.Location = new Point(35, 21);
            btnNewClient.Name = "btnNewClient";
            btnNewClient.Size = new Size(112, 45);
            btnNewClient.TabIndex = 0;
            btnNewClient.Text = "Dodaj klienta";
            btnNewClient.UseVisualStyleBackColor = true;
            btnNewClient.Click += btnNewClient_Click;
            // 
            // button1
            // 
            button1.Location = new Point(170, 19);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 1;
            button1.Text = "Usuń klienta";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AccessibleRole = AccessibleRole.Grip;
            dataGridViewCustomers.AllowUserToResizeColumns = false;
            dataGridViewCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCustomers.BackgroundColor = SystemColors.Info;
            dataGridViewCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomers.ColumnHeadersHeight = 35;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCustomers.EnableHeadersVisualStyles = false;
            dataGridViewCustomers.GridColor = SystemColors.InactiveBorder;
            dataGridViewCustomers.ImeMode = ImeMode.Off;
            dataGridViewCustomers.Location = new Point(35, 112);
            dataGridViewCustomers.Margin = new Padding(12);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCustomers.RowTemplate.Height = 25;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(953, 395);
            dataGridViewCustomers.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "imie";
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Imię";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "nazwisko";
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Nazwisko";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "telefon";
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Telefon";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "nazwa_miejscowosci";
            Column4.FillWeight = 150F;
            Column4.HeaderText = "Miasto";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.DataPropertyName = "ulica";
            Column5.FillWeight = 150F;
            Column5.HeaderText = "Ulica";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.DataPropertyName = "pesel";
            Column6.FillWeight = 150F;
            Column6.HeaderText = "Pesel";
            Column6.Name = "Column6";
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1122, 729);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(button1);
            Controls.Add(btnNewClient);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Klienci";
            Text = "Klienci";
            Load += Klienci_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewClient;
        private Button button1;
        private DataGridView dataGridViewCustomers;
        private DataGridViewTextBoxColumn imie;
        private DataGridViewTextBoxColumn nazwisko;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn ulica;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
    }
}