﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter_2_Exercise_p_75
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (label1.BackColor == Color.Red)
                    label1.BackColor = Color.Blue;
                else
                    label1.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("The box is not checked!");
            }
        }
    }
}
