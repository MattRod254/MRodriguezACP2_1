using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRodriguezACP2_1
{
    public partial class frmMouser : Form
    {
        public frmMouser()
        {
            InitializeComponent();
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            lblCoordinates.Text = ("Clicked at position " + e.X + ", " + e.Y);
            if((e.X == 225) && (e.Y == 225))
            {
                MessageBox.Show("Awesome Job!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
