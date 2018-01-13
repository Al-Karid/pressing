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
    public partial class TypeVetement : Form
    {
        public TypeVetement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                typeVetBS.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                typeVetBS.CancelEdit();
            }

            try
            {
                typevetementTableAdapter1.Fill(pressingDBDS.TYPEVETEMENT);
                MessageBox.Show("Enregistrement terminé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
