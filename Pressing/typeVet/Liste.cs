﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressing.typeVet
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            this.TypeVetListTA.Fill(this.pressingDBDataSet.TYPEVETEMENT);
        }
    }
}
