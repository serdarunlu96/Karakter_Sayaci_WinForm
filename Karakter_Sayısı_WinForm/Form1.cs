namespace Karakter_Sayısı_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtxtMetin.MaxLength = 255;
            label1.Text = "255";
        }

        private void rtxtMetin_TextChanged(object sender, EventArgs e)
        {
            label1.Text = (rtxtMetin.MaxLength - rtxtMetin.Text.Length).ToString();
            label1.ForeColor = Color.FromArgb(rtxtMetin.Text.Length,0,0);
        }
    }
}