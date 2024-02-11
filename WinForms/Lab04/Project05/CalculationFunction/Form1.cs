using System.Text;

namespace CalculationFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4. создаем объект Logic
            Logic p = new Logic();
            //2. создаем и открываем Form2
            Form2 editForm = new Form2(p);
            if (editForm.ShowDialog() != DialogResult.OK) return;

            
            label2.Text = p.Massage();
                        
            richTextBox1.Lines = p.PrintArr();


        }
    }
}