using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer.Řadiče;
using BusinessLayer;

namespace WF
{
    public partial class Login : Form
    {
        
        public string login { get; set; }
        public string password { get; set; }
        public Login()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadicSpravce_Oblasti radic = new RadicSpravce_Oblasti();
            List<Spravce_Oblasti> so = new List<Spravce_Oblasti>();
            so = radic.LoadAllSpravce_Oblasti();
            bool notFound = false;

            foreach (var spravce in so)
            {
                if (spravce.vedec.login == LoginBox1.Text & spravce.vedec.heslo == PasswordBox.Text)
                {
                    Menu m = new Menu(spravce);
                    this.Hide();
                    m.ShowDialog();
                    notFound = true;
                    break;

                }
            }

            if (notFound == false)
            {
                Error err = new Error("Špatné přihlašovací údaje");
                err.ShowDialog();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }
    }
}
