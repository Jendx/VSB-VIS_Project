using BusinessLayer;
using BusinessLayer.Řadiče;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF
{
    public partial class ZvyseniProverky : Form
    {
        RadicVrchni_vyzkumnik RVV = new RadicVrchni_vyzkumnik();
        List<Vrchni_výzkumnik> vv = new List<Vrchni_výzkumnik>();
        List<Ucty> ucty = new List<Ucty>();
        int proverka;
        public ZvyseniProverky()
        {
            InitializeComponent();
        }

        public ZvyseniProverky(List<Vrchni_výzkumnik> vv, int proverka)
        {
           
            InitializeComponent();
            this.proverka = proverka;
            this.vv = vv;
            listBoxVrchniVyzkumnik.Items.Clear();
            foreach (var vrchni in this.vv)
            {
                listBoxVrchniVyzkumnik.Items.Add(vrchni.vedec.jmeno);
            }
            
        }

        public ZvyseniProverky(List<Ucty> u, int proverka)
        {

            InitializeComponent();
            this.proverka = proverka;
            this.ucty = u;
            listBoxVrchniVyzkumnik.Items.Clear();
            foreach (var ucet in this.ucty)
            {
                vv.Add(new Vrchni_výzkumnik(ucet));
                listBoxVrchniVyzkumnik.Items.Add(ucet.jmeno);
            }

        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            potvrdit p = new potvrdit("zvyšit prověrku " + listBoxVrchniVyzkumnik.SelectedItem + " na uroveň " + this.proverka +" ?");
            var YN = p.ShowDialog();
            List<Vrchni_výzkumnik> VybranyVV = new List<Vrchni_výzkumnik>();
            

            if (YN == DialogResult.Yes)
            {
                foreach(var vrchni in vv)
                {
                    if(vrchni.vedec.jmeno == listBoxVrchniVyzkumnik.SelectedItem.ToString())
                    {
                       
                        VybranyVV.Add(vrchni);
                        break;
                    }
                }

                MessageBox.Show(VybranyVV[0].vedec.jmeno + " Dostavte se na přeškolení");

                potvrdit nedostavimSa = new potvrdit("se dostavit na přeškolení?");
                var SkoleniYN = nedostavimSa.ShowDialog();

                if (SkoleniYN == DialogResult.No)
                {
                    this.Close();

                }

                if( SkoleniYN == DialogResult.Yes)
                {
                    VybranyVV[0].vedec.proverka = this.proverka;

                    RVV.UpdateDB(VybranyVV);
                    Error err = new Error("Prověrka byla zvýšena " + listBoxVrchniVyzkumnik.SelectedItem.ToString());
                    this.Close();
                }
                

               
            }
            
            if(YN == DialogResult.No)
            {
                this.Close();
            }
        }
        private void buttonNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
