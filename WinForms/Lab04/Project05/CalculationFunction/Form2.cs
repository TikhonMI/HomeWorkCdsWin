using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationFunction
{
    public partial class Form2 : Form
    {
        Logic p;
        //1. свойства с помощью которых будет реализовано обращение к полям  ввода
        public string First
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Last
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public Form2(Logic p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.First = this.First;
            p.Last = this.Last;
        }
    }
}
