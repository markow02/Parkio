namespace SystemParkingowy
{
    partial class Wyjazdy
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
            dataGridViewExit = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExit).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExit
            // 
            dataGridViewExit.AllowDrop = true;
            dataGridViewExit.AllowUserToAddRows = false;
            dataGridViewExit.AllowUserToDeleteRows = false;
            dataGridViewExit.AllowUserToResizeColumns = false;
            dataGridViewExit.AllowUserToResizeRows = false;
            dataGridViewExit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExit.BackgroundColor = SystemColors.ControlLight;
            dataGridViewExit.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewExit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExit.Dock = DockStyle.Bottom;
            dataGridViewExit.Location = new Point(0, 0);
            dataGridViewExit.MultiSelect = false;
            dataGridViewExit.Name = "dataGridViewExit";
            dataGridViewExit.RowTemplate.Height = 25;
            dataGridViewExit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExit.Size = new Size(1138, 749);
            dataGridViewExit.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(644, 9);
            label2.Name = "label2";
            label2.Size = new Size(464, 59);
            label2.TabIndex = 7;
            label2.Text = "HISTORIA WYJAZDÓW";
            // 
            // Wyjazdy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1138, 749);
            Controls.Add(dataGridViewExit);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wyjazdy";
            Text = "Wyjazdy";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewExit;
        private Label label2;
    }
}