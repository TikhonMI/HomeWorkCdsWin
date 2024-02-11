using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FormS : Form
    {
        public string aX
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string bX
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string c
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public FormS()
        {
            InitializeComponent();
        }

        private void KeyEqual_Click(object sender, EventArgs e)
        {
                        
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) //Кодировка ASCII
            {
                e.Handled = true;
                //MessageBox.Show("Поле не может содержать буквы");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
                //MessageBox.Show("Поле не может содержать буквы");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
                //MessageBox.Show("Поле не может содержать буквы");
            }
        }
    }
}
