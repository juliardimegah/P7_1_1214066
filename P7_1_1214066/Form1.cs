using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P7_1_1214066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 232);
        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbLaki.Checked || rbPerempuan.Checked)
                    {
                        if (tbAlamat.Text != "")
                        {
                            if (cbProdi.Text != "")
                            {
                                if (tbTahun.Text != "")
                                {
                                    if (tbSemester.Text != "")
                                    {
                                        MessageBox.Show
                                        ("Lengkap!",
                                         "Informasi data submit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Size = new Size(816, 433);
                                    }
                                    else
                                    {
                                        MessageBox.Show
                                        ("Semester belum diisi!",
                                         "Informasi data submit",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                    ("Tahun Akademik belum diisi!",
                                    "Informasi data submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                                ("Program Studi belum diisi!",
                                "Informasi data submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                            ("Alamat belum diisi!",
                            "Informasi data submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                        ("Jenis Kelamin belum diisi!",
                         "Informasi data submit",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show
                    ("Nama belum diisi!",
                     "Informasi data submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

            else
            {
                MessageBox.Show
                    ("NIM belum diisi!",
                     "Informasi data submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTahun_TextChanged(object sender, EventArgs e)
        {
            if (tbTahun.Text != "" && Regex.IsMatch(tbTahun.Text, @"^\d{4}/\d{4}"))
            {
             epError.Clear();
             
            }
            else
            {
                    epError.SetError(tbTahun, "format Salah");
                    MessageBox.Show
                     ("Format Salah",
                      "Informasi data submit",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text != "" && (tbSemester.Text).All(Char.IsNumber))
            {
                epError.Clear();
                MessageBox.Show
                    ("Benar!",
                     "Informasi data submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             epError.SetError(tbTahun, "Hanya boleh angka!");
             MessageBox.Show
             ("Input hanya boleh angka!",
              "Informasi data submit",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rb2006_CheckedChanged(object sender, EventArgs e)
        {
            cbPem1.Enabled = true;
            cbPem1.Checked = false;
            cbPem2.Enabled = true;
            cbPem2.Checked = false;
            cbPem3.Enabled = true;
            cbPem3.Checked = false;
            cbMatematika.Enabled = true;
            cbMatematika.Checked = false;
            cbPem4.Enabled = true;
            cbPem4.Checked = false;
            cbPem5.Enabled = true;
            cbPem5.Checked = false;
            cbPem6.Enabled = true;
            cbPem6.Checked = false;
            cbPem7.Enabled = true;
            cbPem7.Checked = false;
            cbJarkom.Enabled = true;
            cbJarkom.Checked = false;
            cbOS.Enabled = true;
            cbOS.Checked = false;
            cbMRP.Enabled = false;
            cbMRP.Checked = false;
            cbPLog.Enabled = false;
            cbPLog.Checked = false;
        }

        private void rb2010_CheckedChanged(object sender, EventArgs e)
        {
            cbPem1.Enabled = true;
            cbPem1.Checked = false;
            cbPem2.Enabled = true;
            cbPem2.Checked = false;
            cbPem3.Enabled = true;
            cbPem3.Checked = false;
            cbMatematika.Enabled = false;
            cbMatematika.Checked = false;
            cbPem4.Enabled = true;
            cbPem4.Checked = false;
            cbPem5.Enabled = true;
            cbPem5.Checked = false;
            cbPem6.Enabled = true;
            cbPem6.Checked = false;
            cbPem7.Enabled = true;
            cbPem7.Checked = false;
            cbJarkom.Enabled = true;
            cbJarkom.Checked = false;
            cbOS.Enabled = true;
            cbOS.Checked = false;
            cbMRP.Enabled = true;
            cbMRP.Checked = false;
            cbPLog.Enabled = false;
            cbPLog.Checked = false;
        }

        private void rb2014_CheckedChanged(object sender, EventArgs e)
        {
            cbPem1.Enabled = true;
            cbPem1.Checked = false;
            cbPem2.Enabled = true;
            cbPem2.Checked = false;
            cbPem3.Enabled = true;
            cbPem3.Checked = false;
            cbMatematika.Enabled = false;
            cbMatematika.Checked = false;
            cbPem4.Enabled = true;
            cbPem4.Checked = false;
            cbPem5.Enabled = true;
            cbPem5.Checked = false;
            cbPem6.Enabled = true;
            cbPem6.Checked = false;
            cbPem7.Enabled = true;
            cbPem7.Checked = false;
            cbJarkom.Enabled = true;
            cbJarkom.Checked = false;
            cbOS.Enabled = true;
            cbOS.Checked = false;
            cbMRP.Enabled = false;
            cbMRP.Checked = false;
            cbPLog.Enabled = true;
            cbPLog.Checked = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            String jeniskelamin = null;
            if (rbLaki.Checked)
            {
                jeniskelamin = rbLaki.Text;
            }
            else
            {
                jeniskelamin = rbPerempuan.Text;
            }

            String tahunajar = null;
            if (rb2006.Checked)
            {
                tahunajar = rb2006.Text;
            }
            else if (rb2010.Checked)
            {
                tahunajar = rb2010.Text;
            }
            else
            {
                tahunajar = rb2014.Text;
            }

            String matkul = null;
            if (cbMatematika.Checked)
            {
                matkul += cbMatematika.Text + ", ";
            }

            if (cbJarkom.Checked)
            {
                matkul += cbJarkom.Text + ", ";
            }

            if (cbPem1.Checked)
            {
                matkul += cbPem1.Text + ", " ;
            }

            if (cbPem2.Checked)
            {
                matkul += cbPem2.Text + ", ";
            }

            if (cbPem3.Checked)
            {
                matkul += cbPem3.Text + ", ";
            }

            if (cbPem4.Checked)
            {
                matkul += cbPem4.Text + ", ";
            }

            if (cbPem5.Checked)
            {
                matkul += cbPem5.Text + ", ";
            }

            if (cbPem6.Checked)
            {
                matkul += cbPem6.Text + ", ";
            }

            if (cbPem7.Checked)
            {
                matkul += cbPem7.Text + ", ";
            }

            if (cbOS.Checked)
            {
                matkul += cbOS.Text + ", ";
            }

            if (cbMRP.Checked)
            {
                matkul += cbMRP.Text + ", ";
            }

            if (cbPLog.Checked)
            {
                matkul += cbPLog.Text + ", ";
            }


            MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nNIM: " + tbNIM.Text+
                    "\nJenis Kelamin: " + jeniskelamin +
                    "\nAlamat: " + tbAlamat.Text +
                    "\nProgram Studi: " + cbProdi.Text +
                    "\nTahun Akademik: " + tbTahun.Text +
                    "\nSemester: " + tbSemester.Text+
                    "\n"+"\n"+
                    "\nTahun Akademik: " + tahunajar +
                    "\nMata kuliah: " + matkul,

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            tbNIM.Clear();
            tbNama.Clear();
            tbAlamat.Clear();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            cbProdi.ResetText();
            tbTahun.Clear();
            tbSemester.Clear();
            cbJarkom.Checked = false;
            cbOS.Checked = false;
            cbPem1.Checked = false;
            cbPem2.Checked = false;
            cbPem3.Checked = false;
            cbPem4.Checked = false;
            cbPem5.Checked = false;
            cbPem6.Checked = false;
            cbPem7.Checked = false;
            cbMRP.Checked = false;
            cbPLog.Checked = false;
            rb2006.Checked = false;
            rb2010.Checked = false;
            rb2014.Checked = false;

            this.Size = new Size(816, 232);
            
        }
    }
}
