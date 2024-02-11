using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenpeace
{
    public partial class Form2 : Form
    {
        Form1 myF1;

        public Form2()
        {
            InitializeComponent();
            myF1 = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myF1.Show();
                myF1.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myF1 = new Form1();                
                myF1.Show();
                myF1.Activate();
            }
        }
    }
}
