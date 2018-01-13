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
    public partial class gestionUserControl : UserControl
    {
        public gestionUserControl()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TypeVetement typeVet = new TypeVetement();
            typeVet.ShowDialog();
        }
    }
}
