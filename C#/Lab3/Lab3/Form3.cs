using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxShop.SelectedItem == null) {
                MessageBox.Show("Please select an item from Shop!");
            }
            else {
                lbxCart.Items.Add(lbxShop.SelectedItem.ToString());
                lbxShop.Items.Remove(lbxShop.SelectedItem.ToString());
            }            
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem == null) {
                MessageBox.Show("Please select an item from Cart!");
            }
            else {
                lbxShop.Items.Add(lbxCart.SelectedItem.ToString());
                lbxCart.Items.Remove(lbxCart.SelectedItem.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxShop.Items.Add(txtAdd.Text);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total item in Shop + Cart = " + (lbxShop.Items.Count + lbxCart.Items.Count));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (lbxCart.Items.Count != 0) {
                lbxShop.Items.Add(lbxCart.Items[0]);
                lbxCart.Items.Remove(lbxCart.Items[0]);
            }
        }
    }
}
