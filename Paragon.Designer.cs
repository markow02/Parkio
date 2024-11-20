namespace SystemParkingowy
{
    partial class Paragon
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
            lblDataWjazdu = new Label();
            lblGodzinaWjazdu = new Label();
            lblGodzinaWyjazdu = new Label();
            lblCzasPostoju = new Label();
            lblZaplata = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDrukuj = new Button();
            SuspendLayout();
            // 
            // lblDataWjazdu
            // 
            lblDataWjazdu.AutoSize = true;
            lblDataWjazdu.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataWjazdu.Location = new Point(175, 91);
            lblDataWjazdu.Name = "lblDataWjazdu";
            lblDataWjazdu.Size = new Size(106, 19);
            lblDataWjazdu.TabIndex = 0;
            lblDataWjazdu.Text = "DATA WJAZDU";
            // 
            // lblGodzinaWjazdu
            // 
            lblGodzinaWjazdu.AutoSize = true;
            lblGodzinaWjazdu.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGodzinaWjazdu.Location = new Point(175, 122);
            lblGodzinaWjazdu.Name = "lblGodzinaWjazdu";
            lblGodzinaWjazdu.Size = new Size(134, 19);
            lblGodzinaWjazdu.TabIndex = 1;
            lblGodzinaWjazdu.Text = "GODZINA WJAZDU";
            // 
            // lblGodzinaWyjazdu
            // 
            lblGodzinaWyjazdu.AutoSize = true;
            lblGodzinaWyjazdu.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGodzinaWyjazdu.Location = new Point(175, 155);
            lblGodzinaWyjazdu.Name = "lblGodzinaWyjazdu";
            lblGodzinaWyjazdu.Size = new Size(142, 19);
            lblGodzinaWyjazdu.TabIndex = 2;
            lblGodzinaWyjazdu.Text = "GODZINA WYJAZDU";
            // 
            // lblCzasPostoju
            // 
            lblCzasPostoju.AutoSize = true;
            lblCzasPostoju.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCzasPostoju.Location = new Point(176, 189);
            lblCzasPostoju.Name = "lblCzasPostoju";
            lblCzasPostoju.Size = new Size(109, 19);
            lblCzasPostoju.TabIndex = 3;
            lblCzasPostoju.Text = "CZAS POSTOJU";
            // 
            // lblZaplata
            // 
            lblZaplata.AutoSize = true;
            lblZaplata.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblZaplata.Location = new Point(176, 220);
            lblZaplata.Name = "lblZaplata";
            lblZaplata.Size = new Size(69, 19);
            lblZaplata.TabIndex = 4;
            lblZaplata.Text = "ZAPŁATA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 91);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 5;
            label1.Text = "Data: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 122);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 6;
            label2.Text = "Wjazd: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 155);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 7;
            label3.Text = "Wyjazd: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(71, 189);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 8;
            label4.Text = "Czas postoju: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(91, 220);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 9;
            label5.Text = "Należność:";
            // 
            // btnDrukuj
            // 
            btnDrukuj.Location = new Point(176, 415);
            btnDrukuj.Name = "btnDrukuj";
            btnDrukuj.Size = new Size(75, 23);
            btnDrukuj.TabIndex = 10;
            btnDrukuj.Text = "DRUKUJ";
            btnDrukuj.UseVisualStyleBackColor = true;
            btnDrukuj.Click += btnDrukuj_Click;
            // 
            // Paragon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(btnDrukuj);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblZaplata);
            Controls.Add(lblCzasPostoju);
            Controls.Add(lblGodzinaWyjazdu);
            Controls.Add(lblGodzinaWjazdu);
            Controls.Add(lblDataWjazdu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Paragon";
            Text = "Paragon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataWjazdu;
        private Label lblGodzinaWjazdu;
        private Label lblGodzinaWyjazdu;
        private Label lblCzasPostoju;
        private Label lblZaplata;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDrukuj;
    }
}