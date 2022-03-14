namespace Praktikumw4
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Nextdata = new System.Windows.Forms.Button();
            this.button_Prevdata = new System.Windows.Forms.Button();
            this.button_Kembali = new System.Windows.Forms.Button();
            this.textBox_Telp = new System.Windows.Forms.TextBox();
            this.textBox_Alamat = new System.Windows.Forms.TextBox();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Nextdata
            // 
            this.button_Nextdata.Location = new System.Drawing.Point(359, 224);
            this.button_Nextdata.Name = "button_Nextdata";
            this.button_Nextdata.Size = new System.Drawing.Size(112, 34);
            this.button_Nextdata.TabIndex = 61;
            this.button_Nextdata.Text = "Next Data";
            this.button_Nextdata.UseVisualStyleBackColor = true;
            this.button_Nextdata.Click += new System.EventHandler(this.button_Nextdata_Click);
            // 
            // button_Prevdata
            // 
            this.button_Prevdata.Location = new System.Drawing.Point(203, 224);
            this.button_Prevdata.Name = "button_Prevdata";
            this.button_Prevdata.Size = new System.Drawing.Size(112, 34);
            this.button_Prevdata.TabIndex = 60;
            this.button_Prevdata.Text = "Prev Data";
            this.button_Prevdata.UseVisualStyleBackColor = true;
            this.button_Prevdata.Click += new System.EventHandler(this.button_Prevdata_Click);
            // 
            // button_Kembali
            // 
            this.button_Kembali.Location = new System.Drawing.Point(42, 224);
            this.button_Kembali.Name = "button_Kembali";
            this.button_Kembali.Size = new System.Drawing.Size(112, 34);
            this.button_Kembali.TabIndex = 59;
            this.button_Kembali.Text = "Kembali";
            this.button_Kembali.UseVisualStyleBackColor = true;
            this.button_Kembali.Click += new System.EventHandler(this.button_Kembali_Click);
            // 
            // textBox_Telp
            // 
            this.textBox_Telp.Location = new System.Drawing.Point(125, 157);
            this.textBox_Telp.Name = "textBox_Telp";
            this.textBox_Telp.Size = new System.Drawing.Size(190, 31);
            this.textBox_Telp.TabIndex = 58;
            // 
            // textBox_Alamat
            // 
            this.textBox_Alamat.Location = new System.Drawing.Point(125, 98);
            this.textBox_Alamat.Name = "textBox_Alamat";
            this.textBox_Alamat.Size = new System.Drawing.Size(561, 31);
            this.textBox_Alamat.TabIndex = 57;
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(125, 43);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(374, 31);
            this.textBox_Nama.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Telp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Alamat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nama:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 294);
            this.Controls.Add(this.button_Nextdata);
            this.Controls.Add(this.button_Prevdata);
            this.Controls.Add(this.button_Kembali);
            this.Controls.Add(this.textBox_Telp);
            this.Controls.Add(this.textBox_Alamat);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Nextdata;
        private Button button_Prevdata;
        private Button button_Kembali;
        private TextBox textBox_Telp;
        private TextBox textBox_Alamat;
        private TextBox textBox_Nama;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}