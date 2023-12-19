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
            btnNewClient = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnNewClient
            // 
            btnNewClient.Location = new Point(112, 66);
            btnNewClient.Name = "btnNewClient";
            btnNewClient.Size = new Size(112, 45);
            btnNewClient.TabIndex = 0;
            btnNewClient.Text = "Dodaj klienta";
            btnNewClient.UseVisualStyleBackColor = true;
            btnNewClient.Click += btnNewClient_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 136);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 1;
            button1.Text = "Usuń klienta";
            button1.UseVisualStyleBackColor = true;
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1122, 729);
            Controls.Add(button1);
            Controls.Add(btnNewClient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Klienci";
            Text = "Klienci";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewClient;
        private Button button1;
    }
}