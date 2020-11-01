using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbalimentos.Items.Add("Lechuga");
            cmbalimentos.Items.Add("Leche");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbalimentos.SelectedIndex;
            lblindice.Text = indice.ToString();

            lbltexto.Text = cmbalimentos.Items[indice].ToString();

           /* MessageBox.Show("Este es el indice", indice.ToString()); */
        }

        private void btnadcionar_Click(object sender, EventArgs e)
        {
            cmbalimentos.Items.Add(txtalimento.Text);
           /* txtalimento.Clear(); */
        }
    }
}
