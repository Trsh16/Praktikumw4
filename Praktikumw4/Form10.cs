﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikumw4
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button_Kembali_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button_Prevdata_Click(object sender, EventArgs e)
        {
            Form9 myForm = new Form9();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void button_Nextdata_Click(object sender, EventArgs e)
        {
            Form11 myForm = new Form11();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox_Nama.Text = Form1.SetValueForText1;
            textBox_Alamat.Text = Form1.SetValueForText2;
            textBox_Telp.Text = Form1.SetValueForText3;
        }
    }
}
