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
            BtnDrukuj = new Button();
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
            // BtnDrukuj
            // 
            BtnDrukuj.Location = new Point(176, 415);
            BtnDrukuj.Name = "BtnDrukuj";
            BtnDrukuj.Size = new Size(75, 23);
            BtnDrukuj.TabIndex = 1;
            BtnDrukuj.Text = "DRUKUJ";
            BtnDrukuj.UseVisualStyleBackColor = true;
            BtnDrukuj.Click += BtnDrukuj_Click;
            // 
            // lblNrRej
            // 
            lblNrRej.AutoSize = true;
            lblNrRej.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrRej.Location = new Point(166, 109);
            lblNrRej.Name = "lblNrRej";
            lblNrRej.Size = new Size(502, 59);
            lblNrRej.TabIndex = 2;
            lblNrRej.Text = "NUMER REJESTRACYJNY";
            // 
            // Bilet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(lblNrRej);
            Controls.Add(BtnDrukuj);
            Controls.Add(lblNumerMiejsca);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Bilet";
            Text = "Bilet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumerMiejsca;
        private Label lblNrRej;
        private Button BtnDrukuj;
    }
}