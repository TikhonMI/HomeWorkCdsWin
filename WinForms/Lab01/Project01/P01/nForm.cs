﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class nForm : Form
    {
        
        private bool nclose = false;
        
        public new void Close()
        {
            nclose = true;
            base.Close();
        }
        
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxClose.Checked) return;

            if (nclose) return;

            e.Cancel = true;
            this.Hide();
        }

        private void checkBoxClose_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
