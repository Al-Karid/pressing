using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressing.rayon
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            this.rayonTA.Fill(this.pressingDBDataSet.RAYON);
        }
    }
}
