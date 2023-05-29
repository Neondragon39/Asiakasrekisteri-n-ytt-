using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asiakasrekisteri_näyttö
{
    public partial class Form1 : Form
    {
        public Boolean bIsYritysTiedot_ = true, bYhteyshenkilonTiedot_ = true, bPoistaTiedot_ = false, bIsYhteydenotto_ = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LisaaTiedotBT_Click(object sender, EventArgs e)
        {
            if (LisaaTiedotBT.Visible)
            {
                muutaTextBoxNimetValilehdenMukaan(false);
                textBox6.Visible = false;

                if (bIsYritysTiedot_)
                {
                    btnNaytayhteydenotot.Visible = false;
                    bIsYritysTiedot_ = false;

                    btnYritysYhteyshenkilot.Visible = true;
                    LisaaTiedotBT.Text = "Palaa yhteystietoihin";
                    label5.Text = "Lisää yhteystiedot";
                    PoistaTiedotBT.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                }
                else if (!bIsYritysTiedot_)
                {
                    btnNaytayhteydenotot.Visible = true;
                    bIsYritysTiedot_ = true;

                    btnYritysYhteyshenkilot.Visible = false;
                    LisaaTiedotBT.Text = "Lisää yhteystiedot";
                    label5.Text = "Yrityksen yhteystiedot";
                    PoistaTiedotBT.Visible = true;

                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;

                    btnYritysYhteyshenkilot.Visible = true;
                    btnYritysYhteyshenkilot.Text = "Lisää yhteydenotto";
                }
            }
        }

        private void muutaTextBoxNimetValilehdenMukaan(Boolean bIs)
        {
            if (bIs)
            {
                textBox1.Text = "yritys";
                textBox2.Text = "asiakkaan nimi";
                textBox3.Text = "rooli";
                textBox4.Text = "sähköpostiosoite";
                textBox5.Text = "puhelin numero";
                textBox6.Visible = false;
                bYhteyshenkilonTiedot_ = false;

                label5.Text = "Lisää yhteyshenkilö";
                btnYritysYhteyshenkilot.Text = "Palaa yrityksen yhteystietoihin";


            }
            else if(!bIs)
            {
                textBox1.Text = "Y-Tunnus";
                textBox2.Text = "Katuosoite";
                textBox3.Text = "Postinumero";
                textBox4.Text = "Kaupunki";
                textBox5.Text = "toimiala";
                textBox6.Text = "Puhelinnumero";
                textBox6.Visible = true;
                bYhteyshenkilonTiedot_ = true;

                label5.Text = "Lisää yhteystiedot";
                btnYritysYhteyshenkilot.Text = "Lisää yhteyshenkilöiden yhteystiedot";
            }
        }

        private void btnValitse_Click(object sender, EventArgs e)
        {
            LisaaTiedotBT.Visible = true;
            PoistaTiedotBT.Visible = true;
            btnNaytayhteydenotot.Visible = true;
            btnYritysYhteyshenkilot.Visible = true;
            btnYritysYhteyshenkilot.Text = "Lisää yhteydenotto";

            label5.Text = "Yrityksen yhteystiedot";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LisaaTiedotBT.Visible = false;
            PoistaTiedotBT.Visible = false;
            btnNaytayhteydenotot.Visible = false;
            label5.Text = "Yhteydenotot asiakkaisiin";
        }

        private void btnYritysYhteyshenkilot_Click(object sender, EventArgs e)
        {
            if (!btnNaytayhteydenotot.Visible)
                muutaTextBoxNimetValilehdenMukaan(bYhteyshenkilonTiedot_);
            else if (!bIsYhteydenotto_)
            {
                label5.Text = "Lisää yhteydenotto";
                btnYritysYhteyshenkilot.Text = "Palaa";
                bIsYhteydenotto_ = true;
            }
            else if (bIsYhteydenotto_)
            {
                label5.Text = "Yrityksen yhteystiedot";
                btnYritysYhteyshenkilot.Text = "Lisää yhteydenotto";
                bIsYhteydenotto_ = false;
            }
        }

        private void PoistaTiedotBT_Click(object sender, EventArgs e)
        {
            if (bPoistaTiedot_)
            {
                btnNaytayhteydenotot.Visible = true;
                bPoistaTiedot_ = false;

                btnYritysYhteyshenkilot.Visible = false;
                PoistaTiedotBT.Text = "Poista yhteystietoa";
                label5.Text = "Yrityksen yhteystiedot";
                LisaaTiedotBT.Visible = true;

                btnYritysYhteyshenkilot.Visible = true;
                btnYritysYhteyshenkilot.Text = "Lisää yhteydenotto";
            }
            else if (!bPoistaTiedot_)
            {
                btnNaytayhteydenotot.Visible = false;
                bPoistaTiedot_ = true;

                btnYritysYhteyshenkilot.Visible = false;
                PoistaTiedotBT.Text = "Palaa yhteystietoihin";
                label5.Text = "Poista yhteystietoja";
                LisaaTiedotBT.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
        }
    }
}
