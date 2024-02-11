namespace ValidationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы ввели: \n" + userWalid1.Label + ": " + userWalid1.Latt + "\n" + numValid1.Label + ": " + numValid1.Numb);
        }
    }
}