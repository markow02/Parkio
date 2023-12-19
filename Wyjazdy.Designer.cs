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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(442, 332);
            label2.Name = "label2";
            label2.Size = new Size(269, 65);
            label2.TabIndex = 4;
            label2.Text = "WYJAZDY";
            // 
            // Wyjazdy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1122, 729);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wyjazdy";
            Text = "Wyjazdy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
    }
}