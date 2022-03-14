namespace Praktikumw4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.textBox_Alamat = new System.Windows.Forms.TextBox();
            this.textBox_Telp = new System.Windows.Forms.TextBox();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.button_Lihatdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp:";
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(109, 38);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(374, 31);
            this.textBox_Nama.TabIndex = 3;
            // 
            // textBox_Alamat
            // 
            this.textBox_Alamat.Location = new System.Drawing.Point(109, 99);
            this.textBox_Alamat.Name = "textBox_Alamat";
            this.textBox_Alamat.Size = new System.Drawing.Size(561, 31);
            this.textBox_Alamat.TabIndex = 4;
            // 
            // textBox_Telp
            // 
            this.textBox_Telp.Location = new System.Drawing.Point(109, 152);
            this.textBox_Telp.Name = "textBox_Telp";
            this.textBox_Telp.Size = new System.Drawing.Size(190, 31);
            this.textBox_Telp.TabIndex = 5;
            this.textBox_Telp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telp_KeyPress);
            // 
            // button_Simpan
            // 
            this.button_Simpan.Location = new System.Drawing.Point(26, 225);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(112, 34);
            this.button_Simpan.TabIndex = 6;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = true;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // button_Lihatdata
            // 
            this.button_Lihatdata.Location = new System.Drawing.Point(187, 225);
            this.button_Lihatdata.Name = "button_Lihatdata";
            this.button_Lihatdata.Size = new System.Drawing.Size(112, 34);
            this.button_Lihatdata.TabIndex = 7;
            this.button_Lihatdata.Text = "Lihat Data";
            this.button_Lihatdata.UseVisualStyleBackColor = true;
            this.button_Lihatdata.Click += new System.EventHandler(this.button_Lihatdata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 294);
            this.Controls.Add(this.button_Lihatdata);
            this.Controls.Add(this.button_Simpan);
            this.Controls.Add(this.textBox_Telp);
            this.Controls.Add(this.textBox_Alamat);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Nama;
        private TextBox textBox_Alamat;
        private TextBox textBox_Telp;
        private Button button_Simpan;
        private Button button_Lihatdata;
    }
}