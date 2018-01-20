using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressing.depot
{
    public partial class AjouterVet : Form
    {
        private int IDD;

        public AjouterVet(int id)
        {
            InitializeComponent();
            this.IDD = id;
            //txtID.Text = id.ToString();
            serviceTableAdapter1.Fill(pressingDBDataSet.SERVICE);
            rayonTableAdapter1.Fill(pressingDBDataSet.RAYON);
            tarifTableAdapter1.Fill(pressingDBDataSet.TARIF);
            typevetementTableAdapter1.Fill(pressingDBDataSet.TYPEVETEMENT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Veuillez saisir le code du vêtement s'il vous plaît");
            }

            try
            {
                vetementTableAdapter1.Insert(txtCode.Text.ToString(), null, false, this.IDD, Convert.ToInt32(txtService.SelectedValue), Convert.ToInt32(txtRayon.SelectedValue), Convert.ToInt32(txtTarif.SelectedValue), Convert.ToInt32(txtTypeVet.SelectedValue));
                MessageBox.Show("Enregistrement réussi");
                //MessageBox.Show(Convert.ToString(txtService.SelectedValue));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AjouterVet_Load(object sender, EventArgs e)
        {

        }
    }
}
