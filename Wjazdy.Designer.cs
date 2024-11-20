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
            dataGridViewEntry = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntry).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEntry
            // 
            dataGridViewEntry.AllowDrop = true;
            dataGridViewEntry.AllowUserToAddRows = false;
            dataGridViewEntry.AllowUserToDeleteRows = false;
            dataGridViewEntry.AllowUserToResizeColumns = false;
            dataGridViewEntry.AllowUserToResizeRows = false;
            dataGridViewEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEntry.BackgroundColor = SystemColors.ControlLight;
            dataGridViewEntry.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntry.Dock = DockStyle.Bottom;
            dataGridViewEntry.Location = new Point(0, 118);
            dataGridViewEntry.MultiSelect = false;
            dataGridViewEntry.Name = "dataGridViewEntry";
            dataGridViewEntry.RowTemplate.Height = 25;
            dataGridViewEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEntry.Size = new Size(1676, 923);
            dataGridViewEntry.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(646, 9);
            label1.Name = "label1";
            label1.Size = new Size(440, 59);
            label1.TabIndex = 5;
            label1.Text = "HISTORIA WJAZDÓW";
            // 
            // Wjazdy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1676, 1041);
            Controls.Add(label1);
            Controls.Add(dataGridViewEntry);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wjazdy";
            Text = "Logi";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewEntry;
        private Label label1;
    }
}