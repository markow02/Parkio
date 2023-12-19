namespace SystemParkingowy
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            btnZaloguj = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernameBox.Location = new Point(231, 227);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Nazwa użytkownika";
            usernameBox.Size = new Size(175, 23);
            usernameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(231, 276);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Hasło";
            passwordBox.Size = new Size(175, 23);
            passwordBox.TabIndex = 2;
            // 
            // btnZaloguj
            // 
            btnZaloguj.Location = new Point(281, 336);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(75, 23);
            btnZaloguj.TabIndex = 3;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(247, 147);
            label1.Name = "label1";
            label1.Size = new Size(136, 50);
            label1.TabIndex = 4;
            label1.Text = "Parkio";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(630, 382);
            Controls.Add(label1);
            Controls.Add(btnZaloguj);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button btnZaloguj;
        private Label label1;
    }
}