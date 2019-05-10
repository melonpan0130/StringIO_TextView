using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form
    {
        String OrgStr = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text; // "결과 : " 문자열 저장
        }

        private void btnEcit_Click(object sender, EventArgs e)
        {
            if (this.lblResult.Text == "")
                this.lblResult.Text = "please insert comment.";
            this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
        }
    }
}
