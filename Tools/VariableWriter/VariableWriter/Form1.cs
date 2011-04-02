using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace VariableWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text += " v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void txtType_Enter(object sender, EventArgs e)
        {
            if (txtType.Text == "type")
                txtType.Text = "";
        }

        private void txtType_Leave(object sender, EventArgs e)
        {
            if (txtType.Text == "")
                txtType.Text = "type";
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "name")
                txtName.Text = "";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                txtName.Text = "name";
        }

        //Generates the varible initialization and copes it to clipboard
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string lower = txtName.Text.Substring(0,1).ToLower() + txtName.Text.Substring(1);
            string upper = txtName.Text.Substring(0,1).ToUpper() + txtName.Text.Substring(1);
            StringBuilder sb = new StringBuilder();
            sb.Append("private " + txtType.Text + " " + lower + ";");
            sb.Append("\r\npublic " + txtType.Text + " " + upper);
            sb.Append("\r\n{");
            sb.Append("\r\n\tget { return " + lower + "; }");
            sb.Append("\r\n\tset { " + lower + " = value; }");
            sb.Append("\r\n}");
            Clipboard.Clear();
            Clipboard.SetText(sb.ToString());
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnGenerate_Click(sender, e);
        }
    }
}
