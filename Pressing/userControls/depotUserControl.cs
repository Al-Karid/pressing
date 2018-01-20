using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressing
{
    public partial class depotUserControl : UserControl
    {
        private int ID;
        public depotUserControl()
        {
            InitializeComponent();
            this.depotTA.Fill(this.pressingDBDataSet.DEPOT);
            this.vetementTableAdapter1.Fill(this.pressingDBDataSet.VETEMENT);
            
        }

        private void btnAjouterDepot_Click(object sender, EventArgs e)
        {
            Pressing.depot.Ajouter Adepot = new Pressing.depot.Ajouter();
            Adepot.ShowDialog();
            this.depotTA.Fill(this.pressingDBDataSet.DEPOT);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.depotTA.Fill(this.pressingDBDataSet.DEPOT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void depotUserControl_Enter(object sender, EventArgs e)
        {
            this.depotTA.Fill(this.pressingDBDataSet.DEPOT);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        private void btnAjouterVetAuDep_Click(object sender, EventArgs e)
        {
            Pressing.depot.AjouterVet AVet = new Pressing.depot.AjouterVet(this.ID);
            AVet.ShowDialog();
            this.vetementTableAdapter1.Fill(this.pressingDBDataSet.VETEMENT);

            /*try { this.dataGridView2.Refresh(); }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de mettre rafreshir  la table");
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedRowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            //MessageBox.Show(Convert.ToString(selectedRow.Cells["DATE"].Value));
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            //dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();

            this.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());

            //MessageBox.Show(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
        }
    }
}
