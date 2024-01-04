namespace SystemParkingowy
{
    partial class Wjazdy
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
            label1 = new Label();
            dataGridViewEntry = new DataGridView();
            marka = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntry).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(393, 45);
            label1.Name = "label1";
            label1.Size = new Size(238, 65);
            label1.TabIndex = 3;
            label1.Text = "WJAZDY";
            // 
            // dataGridViewEntry
            // 
            dataGridViewEntry.AllowDrop = true;
            dataGridViewEntry.AllowUserToAddRows = false;
            dataGridViewEntry.BackgroundColor = SystemColors.Menu;
            dataGridViewEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntry.Columns.AddRange(new DataGridViewColumn[] { marka, model, Column3, Column4 });
            dataGridViewEntry.GridColor = SystemColors.InactiveBorder;
            dataGridViewEntry.Location = new Point(35, 147);
            dataGridViewEntry.Name = "dataGridViewEntry";
            dataGridViewEntry.RowTemplate.Height = 25;
            dataGridViewEntry.Size = new Size(443, 85);
            dataGridViewEntry.TabIndex = 4;
            // 
            // marka
            // 
            marka.DataPropertyName = "marka";
            marka.HeaderText = "Marka";
            marka.Name = "marka";
            // 
            // model
            // 
            model.DataPropertyName = "model";
            model.HeaderText = "Model";
            model.Name = "model";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "nr_rejestracyjny";
            Column3.HeaderText = "Num rej";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "dt_wjazd";
            Column4.HeaderText = "Data wjazdu";
            Column4.Name = "Column4";
            // 
            // Wjazdy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1138, 768);
            Controls.Add(dataGridViewEntry);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wjazdy";
            Text = "Logi";
            Load += Wjazdy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewEntry;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn marka;
        private DataGridViewTextBoxColumn model;
    }
}