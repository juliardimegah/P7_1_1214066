namespace P7_1_1214066
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTahun = new System.Windows.Forms.TextBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.buttonPilih = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2014 = new System.Windows.Forms.RadioButton();
            this.rb2010 = new System.Windows.Forms.RadioButton();
            this.rb2006 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMRP = new System.Windows.Forms.CheckBox();
            this.cbOS = new System.Windows.Forms.CheckBox();
            this.cbJarkom = new System.Windows.Forms.CheckBox();
            this.cbPLog = new System.Windows.Forms.CheckBox();
            this.cbPem7 = new System.Windows.Forms.CheckBox();
            this.cbPem6 = new System.Windows.Forms.CheckBox();
            this.cbPem5 = new System.Windows.Forms.CheckBox();
            this.cbPem4 = new System.Windows.Forms.CheckBox();
            this.cbPem3 = new System.Windows.Forms.CheckBox();
            this.cbPem2 = new System.Windows.Forms.CheckBox();
            this.cbPem1 = new System.Windows.Forms.CheckBox();
            this.cbMatematika = new System.Windows.Forms.CheckBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(201, 45);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(190, 20);
            this.tbNIM.TabIndex = 0;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(201, 70);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(189, 20);
            this.tbNama.TabIndex = 1;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(201, 122);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(189, 59);
            this.tbAlamat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tahun Akademik";
            // 
            // tbTahun
            // 
            this.tbTahun.Location = new System.Drawing.Point(576, 66);
            this.tbTahun.Name = "tbTahun";
            this.tbTahun.Size = new System.Drawing.Size(190, 20);
            this.tbTahun.TabIndex = 6;
            this.tbTahun.TextChanged += new System.EventHandler(this.tbTahun_TextChanged);
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(200, 99);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(68, 17);
            this.rbLaki.TabIndex = 10;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(306, 99);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rbPerempuan.TabIndex = 11;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pilihan Mata Kuliah Mahasiswa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Program Studi";
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "D3 Informatika",
            "D4 Informatika"});
            this.cbProdi.Location = new System.Drawing.Point(576, 39);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(190, 21);
            this.cbProdi.TabIndex = 15;
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(576, 99);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(190, 20);
            this.tbSemester.TabIndex = 16;
            this.tbSemester.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // buttonPilih
            // 
            this.buttonPilih.Location = new System.Drawing.Point(595, 137);
            this.buttonPilih.Name = "buttonPilih";
            this.buttonPilih.Size = new System.Drawing.Size(193, 23);
            this.buttonPilih.TabIndex = 17;
            this.buttonPilih.Text = "Pilih Mata Kuliah";
            this.buttonPilih.UseVisualStyleBackColor = true;
            this.buttonPilih.Click += new System.EventHandler(this.buttonPilih_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2014);
            this.groupBox1.Controls.Add(this.rb2010);
            this.groupBox1.Controls.Add(this.rb2006);
            this.groupBox1.Location = new System.Drawing.Point(24, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Kurikulum";
            // 
            // rb2014
            // 
            this.rb2014.AutoSize = true;
            this.rb2014.Location = new System.Drawing.Point(10, 88);
            this.rb2014.Name = "rb2014";
            this.rb2014.Size = new System.Drawing.Size(98, 17);
            this.rb2014.TabIndex = 24;
            this.rb2014.TabStop = true;
            this.rb2014.Text = "Kurikulum 2014";
            this.rb2014.UseVisualStyleBackColor = true;
            this.rb2014.CheckedChanged += new System.EventHandler(this.rb2014_CheckedChanged);
            // 
            // rb2010
            // 
            this.rb2010.AutoSize = true;
            this.rb2010.Location = new System.Drawing.Point(9, 52);
            this.rb2010.Name = "rb2010";
            this.rb2010.Size = new System.Drawing.Size(98, 17);
            this.rb2010.TabIndex = 23;
            this.rb2010.TabStop = true;
            this.rb2010.Text = "Kurikulum 2010";
            this.rb2010.UseVisualStyleBackColor = true;
            this.rb2010.CheckedChanged += new System.EventHandler(this.rb2010_CheckedChanged);
            // 
            // rb2006
            // 
            this.rb2006.AutoSize = true;
            this.rb2006.Location = new System.Drawing.Point(9, 19);
            this.rb2006.Name = "rb2006";
            this.rb2006.Size = new System.Drawing.Size(98, 17);
            this.rb2006.TabIndex = 22;
            this.rb2006.TabStop = true;
            this.rb2006.Text = "Kurikulum 2006";
            this.rb2006.UseVisualStyleBackColor = true;
            this.rb2006.CheckedChanged += new System.EventHandler(this.rb2006_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMRP);
            this.groupBox2.Controls.Add(this.cbOS);
            this.groupBox2.Controls.Add(this.cbJarkom);
            this.groupBox2.Controls.Add(this.cbPLog);
            this.groupBox2.Controls.Add(this.cbPem7);
            this.groupBox2.Controls.Add(this.cbPem6);
            this.groupBox2.Controls.Add(this.cbPem5);
            this.groupBox2.Controls.Add(this.cbPem4);
            this.groupBox2.Controls.Add(this.cbPem3);
            this.groupBox2.Controls.Add(this.cbPem2);
            this.groupBox2.Controls.Add(this.cbPem1);
            this.groupBox2.Controls.Add(this.cbMatematika);
            this.groupBox2.Location = new System.Drawing.Point(386, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 128);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Mata Kuliah";
            // 
            // cbMRP
            // 
            this.cbMRP.AutoSize = true;
            this.cbMRP.Enabled = false;
            this.cbMRP.Location = new System.Drawing.Point(242, 91);
            this.cbMRP.Name = "cbMRP";
            this.cbMRP.Size = new System.Drawing.Size(148, 17);
            this.cbMRP.TabIndex = 11;
            this.cbMRP.Text = "Manajemen Rantai Pasok";
            this.cbMRP.UseVisualStyleBackColor = true;
            // 
            // cbOS
            // 
            this.cbOS.AutoSize = true;
            this.cbOS.Enabled = false;
            this.cbOS.Location = new System.Drawing.Point(242, 67);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(96, 17);
            this.cbOS.TabIndex = 10;
            this.cbOS.Text = "Sistem Operasi";
            this.cbOS.UseVisualStyleBackColor = true;
            // 
            // cbJarkom
            // 
            this.cbJarkom.AutoSize = true;
            this.cbJarkom.Enabled = false;
            this.cbJarkom.Location = new System.Drawing.Point(242, 44);
            this.cbJarkom.Name = "cbJarkom";
            this.cbJarkom.Size = new System.Drawing.Size(114, 17);
            this.cbJarkom.TabIndex = 9;
            this.cbJarkom.Text = "Jaringan Komputer";
            this.cbJarkom.UseVisualStyleBackColor = true;
            // 
            // cbPLog
            // 
            this.cbPLog.AutoSize = true;
            this.cbPLog.Enabled = false;
            this.cbPLog.Location = new System.Drawing.Point(243, 21);
            this.cbPLog.Name = "cbPLog";
            this.cbPLog.Size = new System.Drawing.Size(114, 17);
            this.cbPLog.TabIndex = 8;
            this.cbPLog.Text = "Pengantar Logistik";
            this.cbPLog.UseVisualStyleBackColor = true;
            // 
            // cbPem7
            // 
            this.cbPem7.AutoSize = true;
            this.cbPem7.Enabled = false;
            this.cbPem7.Location = new System.Drawing.Point(133, 91);
            this.cbPem7.Name = "cbPem7";
            this.cbPem7.Size = new System.Drawing.Size(100, 17);
            this.cbPem7.TabIndex = 7;
            this.cbPem7.Text = "Pemrograman 7";
            this.cbPem7.UseVisualStyleBackColor = true;
            // 
            // cbPem6
            // 
            this.cbPem6.AutoSize = true;
            this.cbPem6.Enabled = false;
            this.cbPem6.Location = new System.Drawing.Point(133, 67);
            this.cbPem6.Name = "cbPem6";
            this.cbPem6.Size = new System.Drawing.Size(100, 17);
            this.cbPem6.TabIndex = 6;
            this.cbPem6.Text = "Pemrograman 6";
            this.cbPem6.UseVisualStyleBackColor = true;
            // 
            // cbPem5
            // 
            this.cbPem5.AutoSize = true;
            this.cbPem5.Enabled = false;
            this.cbPem5.Location = new System.Drawing.Point(133, 44);
            this.cbPem5.Name = "cbPem5";
            this.cbPem5.Size = new System.Drawing.Size(100, 17);
            this.cbPem5.TabIndex = 5;
            this.cbPem5.Text = "Pemrograman 5";
            this.cbPem5.UseVisualStyleBackColor = true;
            // 
            // cbPem4
            // 
            this.cbPem4.AutoSize = true;
            this.cbPem4.Enabled = false;
            this.cbPem4.Location = new System.Drawing.Point(134, 21);
            this.cbPem4.Name = "cbPem4";
            this.cbPem4.Size = new System.Drawing.Size(100, 17);
            this.cbPem4.TabIndex = 4;
            this.cbPem4.Text = "Pemrograman 4";
            this.cbPem4.UseVisualStyleBackColor = true;
            // 
            // cbPem3
            // 
            this.cbPem3.AutoSize = true;
            this.cbPem3.Enabled = false;
            this.cbPem3.Location = new System.Drawing.Point(6, 89);
            this.cbPem3.Name = "cbPem3";
            this.cbPem3.Size = new System.Drawing.Size(100, 17);
            this.cbPem3.TabIndex = 3;
            this.cbPem3.Text = "Pemrograman 3";
            this.cbPem3.UseVisualStyleBackColor = true;
            // 
            // cbPem2
            // 
            this.cbPem2.AutoSize = true;
            this.cbPem2.Enabled = false;
            this.cbPem2.Location = new System.Drawing.Point(6, 65);
            this.cbPem2.Name = "cbPem2";
            this.cbPem2.Size = new System.Drawing.Size(100, 17);
            this.cbPem2.TabIndex = 2;
            this.cbPem2.Text = "Pemrograman 2";
            this.cbPem2.UseVisualStyleBackColor = true;
            // 
            // cbPem1
            // 
            this.cbPem1.AutoSize = true;
            this.cbPem1.Enabled = false;
            this.cbPem1.Location = new System.Drawing.Point(6, 42);
            this.cbPem1.Name = "cbPem1";
            this.cbPem1.Size = new System.Drawing.Size(100, 17);
            this.cbPem1.TabIndex = 1;
            this.cbPem1.Text = "Pemrograman 1";
            this.cbPem1.UseVisualStyleBackColor = true;
            // 
            // cbMatematika
            // 
            this.cbMatematika.AutoSize = true;
            this.cbMatematika.Enabled = false;
            this.cbMatematika.Location = new System.Drawing.Point(7, 19);
            this.cbMatematika.Name = "cbMatematika";
            this.cbMatematika.Size = new System.Drawing.Size(81, 17);
            this.cbMatematika.TabIndex = 0;
            this.cbMatematika.Text = "Matematika";
            this.cbMatematika.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(201, 360);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(193, 23);
            this.buttonSimpan.TabIndex = 20;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(400, 360);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(193, 23);
            this.buttonBatal.TabIndex = 21;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPilih);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTahun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTahun;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.Button buttonPilih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2014;
        private System.Windows.Forms.RadioButton rb2010;
        private System.Windows.Forms.RadioButton rb2006;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbMRP;
        private System.Windows.Forms.CheckBox cbOS;
        private System.Windows.Forms.CheckBox cbJarkom;
        private System.Windows.Forms.CheckBox cbPLog;
        private System.Windows.Forms.CheckBox cbPem7;
        private System.Windows.Forms.CheckBox cbPem6;
        private System.Windows.Forms.CheckBox cbPem5;
        private System.Windows.Forms.CheckBox cbPem4;
        private System.Windows.Forms.CheckBox cbPem3;
        private System.Windows.Forms.CheckBox cbPem2;
        private System.Windows.Forms.CheckBox cbPem1;
        private System.Windows.Forms.CheckBox cbMatematika;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

