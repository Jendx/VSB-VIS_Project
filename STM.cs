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
    public partial class STM : Form
    {
        Vyzkumnik personal = new Vyzkumnik();
        RadicUctu RU = new RadicUctu();
        RadicSCP_Objekt RSCPO = new RadicSCP_Objekt();
        int PozadovanaProverka = 0;

        List<Ucty> ucty = new List<Ucty>();
        public STM()
        {
            InitializeComponent();
            ucty = RU.LoadAll();

            foreach(var u in ucty)
            {
                VýzkumníkListBox.Items.Add(u.jmeno);
            }
        }

        public STM(Vyzkumnik osoba)
        {
            InitializeComponent();

            ucty = RU.LoadAll();
            personal = osoba;
            List<SCP_Objekt> SCPO = RSCPO.LoadAll();

            foreach(var scpo in SCPO)
            {
                if (scpo.cislo == personal.vedec.prirazeneSCP)
                    PozadovanaProverka = scpo.proverka;
            }

            foreach (var u in ucty)
            {
                if (u.proverka >= PozadovanaProverka)
                    VýzkumníkListBox.Items.Add(u.jmeno);
            }

            if(VýzkumníkListBox.Items.Count == 0)
            {
                Error err = new Error("Neexistuje výkumník s dostatečným prověřením!");
                err.ShowDialog();

                MessageBox.Show("Je potřeba zvýšit prověření u výkumníka!");
                ZvyseniProverky zp = new ZvyseniProverky(ucty, PozadovanaProverka);
                var TF = zp.ShowDialog();
                if(TF == DialogResult.Yes)
                {
                    VýzkumníkListBox.Items.Clear();
                    ucty.Clear();
                    ucty = RU.LoadAll();

                    foreach (var u in ucty)
                    {
                        if (u.proverka >= PozadovanaProverka)
                            VýzkumníkListBox.Items.Add(u.jmeno);
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            ČlenovéListBox.Items.Add(VýzkumníkListBox.SelectedItem);
            VýzkumníkListBox.Items.Remove(VýzkumníkListBox.SelectedItem);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            VýzkumníkListBox.Items.Add(ČlenovéListBox.SelectedItem);
            ČlenovéListBox.Items.Remove(ČlenovéListBox.SelectedItem);
        }

        private void SEND_Click(object sender, EventArgs e) // Funguje to, že zároveň jsem člověkem, co je "VV" a chci přidat lidi do týmu
        {
            MessageBox.Show("Seznam byl odeslán ke schválení");

            potvrdit potvrd = new potvrdit("schválit zenam Vrchního výzkumníka?");
            var YN = potvrd.ShowDialog();

            if(YN == DialogResult.Yes)
            {
                List<Ucty> NovyTym = new List<Ucty>();
                foreach(var i in ČlenovéListBox.Items)
                {
                    foreach(var u in ucty)
                    {
                        if(u.jmeno == i.ToString())
                        {
                            u.tym = personal.vedec.tym;
                            u.prirazeneSCP = personal.vedec.prirazeneSCP;
                            NovyTym.Add(u);
                        }
                    }

                }

                RU.Update(NovyTym);
            }
            if (YN == DialogResult.No)
            {
                MessageBox.Show("Seznam byl neschválen!");
            }

        }
    }
}
