using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexTraining
{
    public partial class Form1 : Form
    {
        public static String Ime;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                btnIgraPrva.Enabled = true;
                btnIgraVtora.Enabled = true;
                btnIgraTreta.Enabled = true;
                Ime = textBox1.Text;
            }
            else if (textBox1.Text.Trim().Length == 0)
            {
                btnIgraPrva.Enabled = false;
                btnIgraVtora.Enabled = false;
                btnIgraTreta.Enabled = false;
            }
        }

        private void btnIgraVtora_Click(object sender, EventArgs e)
        {
            FormVtoraIgra forma2 = new FormVtoraIgra();
            forma2.Visible = false;
            forma2.ShowDialog();
            forma2.Close();
        }

        private void btnIgraTreta_Click(object sender, EventArgs e)
        {
            FormTretaIgra forma3 = new FormTretaIgra();
            forma3.Visible = false;
            forma3.ShowDialog();
            forma3.Close();
        }

        private void btnIgraPrva_Click(object sender, EventArgs e)
        {
            FormPrvaIgra forma1 = new FormPrvaIgra();
            forma1.Visible = false;
            forma1.ShowDialog();
            forma1.Close();
        }
    }
}
