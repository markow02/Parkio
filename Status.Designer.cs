namespace SystemParkingowy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            IleWjazdowLabel = new Label();
            ZaparkowaneLabel = new Label();
            IleWyjazdowLabel = new Label();
            ZarobekLabel = new Label();
            DataWybor = new DateTimePicker();
            WybranoDate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IleWjazdowLabel
            // 
            IleWjazdowLabel.AutoSize = true;
            IleWjazdowLabel.Font = new Font("Calibri", 96F, FontStyle.Bold, GraphicsUnit.Point);
            IleWjazdowLabel.ForeColor = Color.FromArgb(0, 192, 0);
            IleWjazdowLabel.Location = new Point(136, 457);
            IleWjazdowLabel.Name = "IleWjazdowLabel";
            IleWjazdowLabel.Size = new Size(130, 156);
            IleWjazdowLabel.TabIndex = 5;
            IleWjazdowLabel.Text = "0";
            // 
            // ZaparkowaneLabel
            // 
            ZaparkowaneLabel.AutoSize = true;
            ZaparkowaneLabel.Font = new Font("Calibri", 96F, FontStyle.Bold, GraphicsUnit.Point);
            ZaparkowaneLabel.ForeColor = Color.Red;
            ZaparkowaneLabel.Location = new Point(149, 457);
            ZaparkowaneLabel.Name = "ZaparkowaneLabel";
            ZaparkowaneLabel.Size = new Size(130, 156);
            ZaparkowaneLabel.TabIndex = 6;
            ZaparkowaneLabel.Text = "0";
            // 
            // IleWyjazdowLabel
            // 
            IleWyjazdowLabel.AutoSize = true;
            IleWyjazdowLabel.Font = new Font("Calibri", 96F, FontStyle.Bold, GraphicsUnit.Point);
            IleWyjazdowLabel.ForeColor = Color.Gray;
            IleWyjazdowLabel.Location = new Point(148, 457);
            IleWyjazdowLabel.Name = "IleWyjazdowLabel";
            IleWyjazdowLabel.Size = new Size(130, 156);
            IleWyjazdowLabel.TabIndex = 7;
            IleWyjazdowLabel.Text = "0";
            // 
            // ZarobekLabel
            // 
            ZarobekLabel.AutoSize = true;
            ZarobekLabel.Font = new Font("Calibri", 84F, FontStyle.Bold, GraphicsUnit.Point);
            ZarobekLabel.ForeColor = Color.Gold;
            ZarobekLabel.Location = new Point(17, 470);
            ZarobekLabel.Name = "ZarobekLabel";
            ZarobekLabel.Size = new Size(115, 137);
            ZarobekLabel.TabIndex = 8;
            ZarobekLabel.Text = "0";
            // 
            // DataWybor
            // 
            DataWybor.CalendarFont = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            DataWybor.Checked = false;
            DataWybor.CustomFormat = "";
            DataWybor.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            DataWybor.Format = DateTimePickerFormat.Custom;
            DataWybor.Location = new Point(730, 34);
            DataWybor.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DataWybor.Name = "DataWybor";
            DataWybor.Size = new Size(221, 50);
            DataWybor.TabIndex = 39;
            // 
            // WybranoDate
            // 
            WybranoDate.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            WybranoDate.ForeColor = SystemColors.ControlText;
            WybranoDate.Location = new Point(730, 93);
            WybranoDate.Name = "WybranoDate";
            WybranoDate.Size = new Size(221, 50);
            WybranoDate.TabIndex = 40;
            WybranoDate.Text = "POKAŻ STAN";
            WybranoDate.UseVisualStyleBackColor = true;
            WybranoDate.Click += WybranoDate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(DataWybor);
            panel1.Controls.Add(WybranoDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1676, 178);
            panel1.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(1676, 900);
            panel2.TabIndex = 42;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(ZarobekLabel);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(1257, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(463, 900);
            panel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(102, 200);
            label3.Name = "label3";
            label3.Size = new Size(283, 78);
            label3.TabIndex = 9;
            label3.Text = "ZAROBEK";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(459, 192);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(IleWyjazdowLabel);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(838, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(419, 900);
            panel6.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(59, 200);
            label6.Name = "label6";
            label6.Size = new Size(281, 78);
            label6.TabIndex = 8;
            label6.Text = "WYJAZDY";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(415, 192);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(ZaparkowaneLabel);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(419, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(419, 900);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(31, 195);
            label1.Name = "label1";
            label1.Size = new Size(349, 156);
            label1.TabIndex = 7;
            label1.Text = "AKTUALNIE \r\nZAJĘTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(415, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(IleWjazdowLabel);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 900);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(84, 200);
            label2.Name = "label2";
            label2.Size = new Size(249, 78);
            label2.TabIndex = 1;
            label2.Text = "WJAZDY";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1676, 1041);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Status";
            Text = "Status";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label IleWjazdowLabel;
        private Label ZaparkowaneLabel;
        private Label IleWyjazdowLabel;
        private Label ZarobekLabel;
        private DateTimePicker DataWybor;
        private Button WybranoDate;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label1;
        private Label label3;
    }
}