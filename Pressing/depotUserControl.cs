﻿using System;
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
        public depotUserControl()
        {
            InitializeComponent();
        }

        private void btnAjouterDepot_Click(object sender, EventArgs e)
        {
            nouveauDepot nDepot = new nouveauDepot();
            nDepot.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
