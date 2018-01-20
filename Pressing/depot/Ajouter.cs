using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Pressing.depot
{
    public partial class Ajouter : Form
    {

        public int ID;
        public bool canValidate;

        public Ajouter()
        {
            InitializeComponent();
            this.canValidate = false;
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            Pressing.client.Ajouter Aclient = new Pressing.client.Ajouter();
            Aclient.ShowDialog();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (numClient.Text == "")
            {
                MessageBox.Show("Veuillez saisir le numéro du client");
                return;
            }

            if (!this.canValidate)
            {
                MessageBox.Show("Idenfiant du client invalide");
                return;
            }

            try
            {
                depotTableAdapter1.Insert(DateTime.Now, dateTimePicker1.Value, checkBox1.Checked, false, this.ID);
                MessageBox.Show("Depot enregistré avec succès");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show(checkBox1.Checked.ToString
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void numClient_Leave(object sender, EventArgs e)
        {
            if (numClient.Text == "")
            {
                MessageBox.Show("Veuillez saisir le numéro du client");
                return;
            }

            try
            {
                string tel = numClient.Text;
                DataTable cfd = cfdTableAdapter1.GetData(tel);
                DataRow r = cfd.Rows[0];
                txtNomClient.Text = r["NOM"] + " " + r["PRENON"];
                this.ID = Convert.ToInt32(r["ID"].ToString());
                this.canValidate = true;
                //MessageBox.Show(r["TELEPHONE"].ToString());
            }
            catch (Exception ex)
            {
                //this.canValidate = false;
                MessageBox.Show("Ce client n'existe probablement pas.\nVous devriez peut-être l'enregistrer avant de continuer");
                //MessageBox.Show(ex.Message + "\n");
            }
        }
    }
}
