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
            label1.BackColor = Color.Empty;
            label2.BackColor = Color.Empty;
            label4.BackColor = Color.Empty;
            label4.BackColor = Color.Empty;
        }
    }
}
