﻿namespace SystemParkingowy
{
    partial class Status
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
            dataGridViewPlace = new DataGridView();
            numer = new DataGridViewTextBoxColumn();
            wolnosc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlace).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 49);
            label1.Name = "label1";
            label1.Size = new Size(388, 65);
            label1.TabIndex = 0;
            label1.Text = "Zajętość miejsc";
            // 
            // dataGridViewPlace
            // 
            dataGridViewPlace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlace.Columns.AddRange(new DataGridViewColumn[] { numer, wolnosc });
            dataGridViewPlace.Location = new Point(12, 272);
            dataGridViewPlace.Name = "dataGridViewPlace";
            dataGridViewPlace.RowTemplate.Height = 25;
            dataGridViewPlace.Size = new Size(1108, 346);
            dataGridViewPlace.TabIndex = 1;
            // 
            // numer
            // 
            numer.DataPropertyName = "numer";
            numer.HeaderText = "Numer miejsca";
            numer.Name = "numer";
            // 
            // wolnosc
            // 
            wolnosc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wolnosc.DataPropertyName = "wolnosc";
            wolnosc.HeaderText = "Dostępność";
            wolnosc.Name = "wolnosc";
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1122, 729);
            Controls.Add(dataGridViewPlace);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Status";
            Text = "Status";
            Load += Status_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPlace;
        private DataGridViewTextBoxColumn numer;
        private DataGridViewTextBoxColumn dostepnosc;
        private DataGridViewTextBoxColumn wolnosc;
    }
}