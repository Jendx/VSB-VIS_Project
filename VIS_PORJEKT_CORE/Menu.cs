using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace WF
{
    public partial class Menu : Form
    {
        Vyzkumnik prihlasenyClovek = new Vyzkumnik();
        public Menu()
        {
            InitializeComponent();
        }
        
        public Menu(Vyzkumnik login)
        {
            InitializeComponent();
            labelWelcome.Text += " " + login.vedec.jmeno;
            prihlasenyClovek = login;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateSCPRecord_Click(object sender, EventArgs e)
        {
            Vytvoření_Záznamu vz = new Vytvoření_Záznamu();
            this.Hide();
            vz.ShowDialog();
            this.Show();
        }

        private void buttonSelectMoT_Click(object sender, EventArgs e)
        {
            STM selectTeamMemeber = new STM(prihlasenyClovek);
            this.Hide();
            selectTeamMemeber.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignMainScientist ass = new AssignMainScientist();
            this.Hide();
            ass.ShowDialog();
            this.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Fuck you");
            Application.Exit();

        }
    }
}
