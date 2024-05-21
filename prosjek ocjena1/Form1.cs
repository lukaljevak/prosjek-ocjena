using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjek_ocjena1
{
    public partial class Form1 : Form
    {
        List<Prosjek>
        public Form1()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIspis.Clear
            foreach (Prosjek prosjek in listaOcjena)
            {
                txtIspis.AppendText(prosjek.NazivPredmeta + "\t" + prosjek.Ocjena + "\r\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO:napraviti provijeru podataka
            //try.catch
            //ocjena mora biti od 1 do 5
            //predmet nesmije biti prazan string
            Prosjek prosjek = new Prosjek(cmbOcjena.Text, Convert.ToInt32(txtOcjena.Text);
            listaOcjena.add(prosjek);
            txtOcjena.Clear();
            txtOcjena.Focus();
            
        }
    }
}
