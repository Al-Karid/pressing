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

        private void button8_Click(object sender, EventArgs e)
        {
            Pressing.typeVet.Liste typeVetList = new Pressing.typeVet.Liste();
            typeVetList.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pressing.client.Liste liste = new Pressing.client.Liste();
            liste.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pressing.service.Liste liste = new Pressing.service.Liste();
            liste.ShowDialog();
        }
    }
}
