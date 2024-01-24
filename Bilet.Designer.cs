namespace SystemParkingowy
{
    partial class Bilet
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
            lblNumerMiejsca = new Label();
            btnDrukuj = new Button();
            lblNrRej = new Label();
            SuspendLayout();
            // 
            // lblNumerMiejsca
            // 
            lblNumerMiejsca.AutoSize = true;
            lblNumerMiejsca.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumerMiejsca.Location = new Point(166, 197);
            lblNumerMiejsca.Name = "lblNumerMiejsca";
            lblNumerMiejsca.Size = new Size(362, 59);
            lblNumerMiejsca.TabIndex = 0;
            lblNumerMiejsca.Text = "NUMER MIEJSCA";
            // 
            // btnDrukuj
            // 
            btnDrukuj.Location = new Point(180, 366);
            btnDrukuj.Name = "btnDrukuj";
            btnDrukuj.Size = new Size(97, 23);
            btnDrukuj.TabIndex = 1;
            btnDrukuj.Text = "DRUKUJ";
            btnDrukuj.UseVisualStyleBackColor = true;
            btnDrukuj.Click += btnDrukuj_Click;
            // 
            // lblNrRej
            // 
            lblNrRej.AutoSize = true;
            lblNrRej.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrRej.Location = new Point(166, 109);
            lblNrRej.Name = "lblNrRej";
            lblNrRej.Size = new Size(362, 59);
            lblNrRej.TabIndex = 2;
            lblNrRej.Text = "NUMER MIEJSCA";
            // 
            // Bilet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(lblNrRej);
            Controls.Add(btnDrukuj);
            Controls.Add(lblNumerMiejsca);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Bilet";
            Text = "Bilet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumerMiejsca;
        private Button btnDrukuj;
        private Label lblNrRej;
    }
}