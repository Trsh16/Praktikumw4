using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_Prevdata_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data sudah data pertama");
        }

        private void button_Kembali_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox_Nama.Text = Form1.SetValueForText1;
            textBox_Alamat.Text = Form1.SetValueForText2;
            textBox_Telp.Text = Form1.SetValueForText3;         
        }

        private void button_Nextdata_Click(object sender, EventArgs e)
        {
            if (textBox_Nama.Text == null)
            {
                textBox_Nama.Text = "<data kosong>";
                textBox_Alamat.Text = "data kosong";
                textBox_Telp.Text = "<data kosong>";
            }
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
