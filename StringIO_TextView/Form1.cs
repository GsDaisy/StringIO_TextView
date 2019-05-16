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

        private string OrgStr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                this.lblResult.Text = this.OrgStr + this.textBox1.Text;

            }
        }

        private bool TextCheck()
        {
            if(this.textBox1.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.textBox1.Focus();
                return false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)  //엔터 키를 누를 때
            {
                e.Handled = true;
                if (TextCheck() == true)
                {
                    this.lblResult.Text = this.OrgStr + this.textBox1.Text;
                }
            }

        }
    }
}
