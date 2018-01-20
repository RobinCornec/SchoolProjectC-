using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccesBases
{
    public partial class Form1 : Form
    {
        bdd laBase;

        public Form1()
        {
            InitializeComponent();

            laBase = new bdd(bdd.typeBdd.MySql);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void testCnx_Click(object sender, EventArgs e)
        {
            laBase.ouvrir();
            laBase.fermer();
        }

        private void changerBase(object sender, EventArgs e)
        {
            if(MySql.Checked)
                laBase = new bdd(bdd.typeBdd.MySql);
            else
                laBase = new bdd(bdd.typeBdd.SqlServer);
 
 
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            Client client = new Client(31, "Lulu", "rue Joliette");
            client.creerNouveau(laBase);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Client client = new Client((int)numericUpDown1.Value);
            client.supprimer(laBase);

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
    }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            List<int> lNumClient;

            lNumClient = Client.listeDesNumeros(laBase);
            comboBox1.Items.Clear();
            foreach (int nc in lNumClient)
                comboBox1.Items.Add(nc);
     
        }
    }
}
