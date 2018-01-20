using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressing.client
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string c_n = txtNonCLient.Text;
            string c_p = txtPrenomClient.Text;
            string c_nb = txtNumeroClient.Text;

            try
            {
                this.clientTableAdapter1.Insert(c_n, c_p, c_nb);
                MessageBox.Show("Enregistrement effectué avec succès");
                txtNonCLient.Text = "";
                txtPrenomClient.Text = "";
                txtNumeroClient.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ce client existe probablement déjà dans la base de données");
                //MessageBox.Show(ex.Message);
            }
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }
    }
}
