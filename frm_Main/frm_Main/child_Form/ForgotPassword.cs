﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btSingInLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng kiểm tra email của bạn và làm theo hướng dẫn ! ", "Thông Báo" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
