﻿using System;
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
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            this.clientTA.Fill(this.pressingDBDataSet.CLIENT);
        }
    }
}
