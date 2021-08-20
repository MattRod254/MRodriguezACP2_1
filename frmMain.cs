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

    public partial class frmMain : Form
    {

        LinkedList<string> items = new LinkedList<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbxResults.Items.Count > 0)
            {
                items.Clear();
            }
            else
            {
                MessageBox.Show("There are no items in the list box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuMainMouserItm_Click(object sender, EventArgs e)
        {
            new frmMouser().ShowDialog();
        }

        private void mnuMainAboutItm_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private void mnuMainInOutItm_Click(object sender, EventArgs e)
        {
            new frmInputOutput().ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {        

            if (!string.IsNullOrEmpty(tbxInput.Text))
            {
                items.AddLast(tbxInput.Text);
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("There are no items in the text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbxResults.Items.Count > 0)
            {
                if (!string.IsNullOrEmpty(tbxInput.Text) && items.Contains(tbxInput.Text))
                {
                    items.Remove(tbxInput.Text);
                    MessageBox.Show("Item was removed.");
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("There are no items in the text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxInput.Text) && items.Contains(tbxInput.Text))
            {
                MessageBox.Show("The item you searched was found.", "Item found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The item you searched was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxResults.DataSource = items.ToList();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
