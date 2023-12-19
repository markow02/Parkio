namespace SystemParkingowy
{
    partial class PanelSterowania
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(93, 61);
            button1.Name = "button1";
            button1.Size = new Size(125, 60);
            button1.TabIndex = 0;
            button1.Text = "Dodaj samochód";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(93, 127);
            button2.Name = "button2";
            button2.Size = new Size(125, 55);
            button2.TabIndex = 1;
            button2.Text = "Usuń samochód";
            button2.UseVisualStyleBackColor = true;
            // 
            // PanelSterowania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1138, 768);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanelSterowania";
            Text = "PanelSterowania";
            Load += PanelSterowania_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}