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
        public Boolean bIsYritysTiedot_ = true, bYhteyshenkilonTiedot_ = true, bPoistaTiedot_ = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.BackColor = Color.Empty;
            label2.BackColor = Color.Empty;
            label4.BackColor = Color.Empty;
            label4.BackColor = Color.Empty;
        }

        private void LisaaTiedotBT_Click(object sender, EventArgs e)
        {
            if (LisaaTiedotBT.Visible)
            {
                muutaTextBoxNimetValilehdenMukaan(false);
                textBox6.Visible = false;

                if (bIsYritysTiedot_)
                {
                    bIsYritysTiedot_ = false;

                    btnYritysYhteyshenkilot.Visible = true;
                    LisaaTiedotBT.Text = "Palaa lisätietoihin";
                    label5.Text = "Lisää lisätiedot";
                    PoistaTiedotBT.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                }
                else if (!bIsYritysTiedot_)
                {
                    bIsYritysTiedot_ = true;

                    btnYritysYhteyshenkilot.Visible = false;
                    LisaaTiedotBT.Text = "Lisää lisätietoa";
                    label5.Text = "Yrityksen lisätiedot";
                    PoistaTiedotBT.Visible = true;

                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
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
                btnYritysYhteyshenkilot.Text = "Palaa yrityksen lisätietoihin";


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

                label5.Text = "Lisää lisätiedot";
                btnYritysYhteyshenkilot.Text = "Lisää yhteyshenkilöiden yhteystiedot";
            }
        }

        private void btnYritysYhteyshenkilot_Click(object sender, EventArgs e)
        {
            muutaTextBoxNimetValilehdenMukaan(bYhteyshenkilonTiedot_);
        }

        private void PoistaTiedotBT_Click(object sender, EventArgs e)
        {

            if (bPoistaTiedot_)
            {
                bPoistaTiedot_ = false;

                btnYritysYhteyshenkilot.Visible = false;
                PoistaTiedotBT.Text = "Poista lisätietoa";
                label5.Text = "Yrityksen lisätiedot";
                LisaaTiedotBT.Visible = true;
            }
            else if (!bPoistaTiedot_)
            {
                bPoistaTiedot_ = true;

                btnYritysYhteyshenkilot.Visible = false;
                PoistaTiedotBT.Text = "Palaa lisätietoihin";
                label5.Text = "Poista lisätietoja";
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
