namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.TimeEnabled)
            {
                button1.Text = "Play";
                userControlTimer1.TimeEnabled = false;
            }
            else
            {
                button1.Text = "Stop";
                userControlTimer1.TimeEnabled = true;
            }
        }
    }
}