using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF
{
    public partial class Error : Form
    {
        public bool shown;
        public Error()
        {
            InitializeComponent();
        }
        public Error(string error)
        {
            InitializeComponent();

            label1.Text = error;

            CenterToScreen();
            shown = true;
        }
        private void Error_Load(object sender, EventArgs e)
        {

        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
            shown = false;
        }
    }
}
