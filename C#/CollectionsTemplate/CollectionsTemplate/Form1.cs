using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ensemble<Etudiant> lili = new Ensemble<Etudiant>();

            Etudiant e2 = new Etudiant("Roger2", "Pierre");

            lili.Add(new Etudiant("Roger1", "Pierre"));
            lili.Add(e2);
            lili.Add(new Etudiant("Roger3", "Pierre"));
            lili.Add(new Etudiant("Roger4", "Pierre3"));
            lili.Add(new Etudiant("Roger4", "Pierre"));
            lili.Add(new Etudiant("Roger4", "Pierre"));
            lili.Add(e2);

            lili.Sort(new ComparateurEtudiant ());

            foreach (Etudiant etud in lili)
                listBox1.Items.Add(etud.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<int, Etudiant> lesEtud = new Dictionary<int,Etudiant>();
            lesEtud.Add(2,new Etudiant("Roger2", "Pierre"));
            lesEtud.Add(5,new Etudiant("Roger5", "Pierre"));
            lesEtud.Add(12,new Etudiant("Roger12", "Pierre"));
            lesEtud.Add(1,new Etudiant("Roger1", "Pierre"));

            foreach (var etudKV in lesEtud)
                listBox1.Items.Add(etudKV.Key + "-->" + etudKV.Value);

            Etudiant e1 = lesEtud[5];
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] t = { 1, 20, 40 };
            Etudiant e1 = new Etudiant("Poulo", "Frank");

            listBox1.Items.Clear();

            System.Collections.ArrayList lili = new ArrayList ();
            lili.Add("zozo");
            lili.Add(12);
            lili.Add(new Etudiant("Poulo", "Frank"));
            lili.Add(new int[] { 1, 20, 40 });
            lili.Add(t);
            lili.Add(t);
            lili.Add(e1);

            foreach (var obj in lili)
                listBox1.Items.Add(obj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] t = { 1, 20, 40, -6, 30, -8 };
            listBox1.Items.Clear();

            IEnumerable<int> lesPositifs = (from  elem in t where elem > 0 select (elem * 3));

            foreach (Object elem in lesPositifs)
                listBox1.Items.Add(elem);
            listBox1.Items.Add("------------------");
            listBox1.Items.Add(lesPositifs.Average());
        }
    }
}
