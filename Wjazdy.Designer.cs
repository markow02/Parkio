namespace SystemParkingowy
{
    partial class Wjazdy
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(480, 352);
            label1.Name = "label1";
            label1.Size = new Size(238, 65);
            label1.TabIndex = 3;
            label1.Text = "WJAZDY";
            // 
            // Wjazdy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1138, 768);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wjazdy";
            Text = "Logi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}