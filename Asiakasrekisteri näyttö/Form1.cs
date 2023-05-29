using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asiakasrekisteri_näyttö
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    // Asiakas Yritys luokka, joka pitää sisällään asiakasyroityksen tiedot
    public class AsiakasYritys : AsiakasYhteyshenkilot
    {
        public String nimi_ = "", yTunnus_ = "", osoite_ = "", kaupunki_ = "", toimiala_ = "";
        public int    postNumero_ = 0, puh_ = 0;

    }

    // Asiakkaan yhteyshenkilön tiedot luokka
    public class AsiakasYhteyshenkilot
    {
        public String aRooli_ = "", aNimi_ = "", aSPost_ = "", aPuh_ = "";
    }
}
