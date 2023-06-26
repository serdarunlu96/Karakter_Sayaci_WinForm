namespace Karakter_Sayısı_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtxtMetin = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtxtMetin
            // 
            rtxtMetin.Location = new Point(52, 33);
            rtxtMetin.MaxLength = 1;
            rtxtMetin.Name = "rtxtMetin";
            rtxtMetin.Size = new Size(438, 191);
            rtxtMetin.TabIndex = 0;
            rtxtMetin.Text = "";
            rtxtMetin.TextChanged += rtxtMetin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 242);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 306);
            Controls.Add(label1);
            Controls.Add(rtxtMetin);
            Name = "Form1";
            Text = "Karakter Sayacı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtMetin;
        private Label label1;
    }
}