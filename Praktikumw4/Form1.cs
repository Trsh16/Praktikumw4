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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        private void Form1_Load(object sender, EventArgs e)
        {
          if (DataBindings.Count > 10)
            {
                MessageBox.Show("Data telah penuh!");
            }
        }
        private void button_Simpan_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox_Nama.Text;
            SetValueForText2 = textBox_Alamat.Text;
            SetValueForText3 = textBox_Telp.Text;
        }

        private void button_Lihatdata_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        private void textBox_Telp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}