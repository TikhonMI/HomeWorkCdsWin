using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationForm
{
    public partial class NumValid : UserControl
    {
        public string Numb 
        {
            get { return textBox1.Text; } 
            set {  textBox1.Text = value; } 
        }

        public string Label
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public NumValid()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))               
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы");
            }
        }
    }
}
