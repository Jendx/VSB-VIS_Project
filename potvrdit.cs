using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF
{
    public partial class potvrdit : Form
    {
        public bool YN { get; set; }
        public potvrdit()
        {
            InitializeComponent();
            
        }
        public potvrdit(string lab)
        {
            InitializeComponent();
            label1.Text = lab;
        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            YN = true;
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void buttonNO_Click(object sender, EventArgs e)
        {
            YN = false;
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void potvrdit_Load(object sender, EventArgs e)
        {

        }
    }
}
