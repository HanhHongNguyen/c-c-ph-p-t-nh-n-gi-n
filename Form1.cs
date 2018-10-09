using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace các_phép_tính_đơn_giản
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string pass = txtpass.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Can nhap Name va pass", " Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (name == "hanh" && pass == "123")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result= MessageBox.Show("Name va pass khong dung ! ", "Login", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    if (result != DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        txtname.Focus();
                    }
                }
                }
            }
        }
    }

