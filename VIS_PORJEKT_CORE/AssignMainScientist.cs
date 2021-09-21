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
    public partial class AssignMainScientist : Form
    {
        public int count;
        int proverka;

        List<Vrchni_výzkumnik> vv = new List<Vrchni_výzkumnik>();
        List<SCP_Objekt> SCPO = new List<SCP_Objekt>();

        RadicVrchni_vyzkumnik RVV = new RadicVrchni_vyzkumnik();
        RadicSCP_Objekt RSCPO = new RadicSCP_Objekt();

        public AssignMainScientist()
        {
            InitializeComponent();
            count = 0;
            //Error e = new Error("Zadejte úroveň prověření");
            //e.ShowDialog();  
        }

        #region AddingItemsToBoxes
        public void AddItem(string name, int proverka)
        {
            Vrchní_výzkumník.Items.Add(name + " " + proverka);
        }

        public void AddItem(int cislo, string prezdivka, int proverka)
        {
            SCP.Items.Add("SCP-"+ cislo + " " + prezdivka + " " + proverka);
        }
        #endregion

        public int getProverka()
        {
            int proverka;

            if (!int.TryParse(textBoxProverka.Text, out proverka))
            {
                Error err = new Error("Ja ty tvoje znaky fakt jako nežeru. CHCI POUZE ČÍSLO!");
                if (count < 2)
                    err.Show();

                textBoxProverka.Clear();
                count--;
                return -1;
            }
            else
            {
                count--;
                return proverka;
            }

            return 0;

        }


        private void Vrchní_výzkumník_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProverka_TextChanged(object sender, EventArgs e) // 1. - 4. bod HL. scénaře
        {
            vv.Clear();
            SCPO.Clear();
            Vrchní_výzkumník.Items.Clear();
            SCP.Items.Clear();

            if (textBoxProverka.Text != "")
            {
                count++;
                proverka = getProverka();
            }
            
            if(proverka != -1 && textBoxProverka.Text != "")
            {
                #region Nacteni Dat

                vv = RVV.LoadAll();

                foreach (var v in vv)
                {
                    if (v.vedec.proverka >= this.proverka)
                    {

                        AddItem(v.vedec.jmeno, v.vedec.proverka);
                    }
                }


                SCPO = RSCPO.LoadAll();
                
               
                foreach (var scp in SCPO)
                {
                    if (scp.proverka <= this.proverka)
                    {
    
                        AddItem(scp.cislo, scp.prezdivka, scp.proverka);
                    }
                }
                #endregion

                if(Vrchní_výzkumník.Items.Count == 0)
                {
                    potvrdit potvrditZvyseni = new potvrdit("Zvýšit prověřku nějakému Vrchnímu výzkumníkovy?");
                    var zvysit = potvrditZvyseni.ShowDialog();

                    if(zvysit == DialogResult.Yes)
                    {
                        ZvyseniProverky zvyseniP = new ZvyseniProverky(vv, proverka);
                        zvyseniP.ShowDialog();


                        foreach (var v in vv)
                        {
                            if (v.vedec.proverka >= this.proverka)
                            {

                                AddItem(v.vedec.jmeno, v.vedec.proverka);
                            }
                        }
                    }

                    if(zvysit == DialogResult.No)
                    {
                        // \_(u_u)_/
                    }
                }

            }

        }

        #region Closing
        private void button2_Click(object sender, EventArgs e)
        {

            // f.Show();
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }
        #endregion

        private void Assign_Click(object sender, EventArgs e)
        {
            if(Vrchní_výzkumník.SelectedItem == null || SCP.SelectedItem == null )
            {
                Error err = new Error("Vyberte položku z obou sloupců!");
                err.ShowDialog();
                return;
            }
            string SelectedVV = Vrchní_výzkumník.SelectedItem.ToString();
            string SelectedSCP = SCP.SelectedItem.ToString();

            string[] splitted = new string[4];
            SelectedVV = SelectedVV.Remove(SelectedVV.LastIndexOf(" "));
            splitted = SelectedSCP.Split("-");
            string trimedSCP = splitted[1].Remove(splitted[1].IndexOf(" "));

            AssignVVAndSCPO(SelectedVV, trimedSCP);
        }

        public void AssignVVAndSCPO(string SelectedVrchniVyzkumnik, string SCPObjekt)
        {
            

            int scpId = -10;
            foreach(var scp in SCPO)
            {
                if(scp.cislo == int.Parse(SCPObjekt))
                {
                    scpId = scp.cislo;
                }
            }

            foreach (var v in vv)
            {
                if(v.vedec.jmeno == SelectedVrchniVyzkumnik)
                {
                    v.vedec.prirazeneSCP = scpId;
                    v.vedec.tym = "SCP-" + v.vedec.prirazeneSCP + "-1";
                }
            }
            RVV.UpdateDB(vv);

            Error err = new Error("Zpráva byla odeslána V. Výzkumník "+ SelectedVrchniVyzkumnik + " o přiřazení k SCP-" + SCPObjekt);
            err.ShowDialog();

        }
    }
}
//}
