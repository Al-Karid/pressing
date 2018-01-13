using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            homeUserControl1.BringToFront();
        }

        private Boolean flag = false;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            depotUserControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeUserControl1.BringToFront();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            ajouterDepotUserControl1.BringToFront();
        }

        private void btnEtat_Click(object sender, EventArgs e)
        {

        }
    }
}
