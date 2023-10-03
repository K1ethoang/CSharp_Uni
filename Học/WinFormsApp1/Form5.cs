using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset()
        {
            txtName.Clear();
            txtName.Focus();

            rtbDesc.Clear();
            txtPrice.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListViewItem li = lvListProduct.SelectedItems[0];
            li.SubItems[0].Text = txtName.Text;
            li.SubItems[1].Text = rtbDesc.Text;
            li.SubItems[2].Text = txtPrice.Text;

            //MessageBox.Show(lvListProduct.SelectedIndices[0].ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Thêm item vào listView
            // Cách 1: 
            //ListViewItem li = new ListViewItem(txtName.Text);
            //li.SubItems.Add(rtbDesc.Text);
            //li.SubItems.Add(txtPrice.Text);

            //lvListProduct.Items.Add(li);

            // Cách 2:
            String[] dataRow = { txtName.Text, rtbDesc.Text, txtPrice.Text };
            ListViewItem li = new ListViewItem(dataRow);

            lvListProduct.Items.Add(li);

            // reset control
            this.reset();
        }

        private void lvListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListProduct.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;

                txtName.Text = lvListProduct.SelectedItems[0].SubItems[0].Text;
                rtbDesc.Text = lvListProduct.SelectedItems[0].SubItems[1].Text;
                txtPrice.Text = lvListProduct.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                btnEdit.Enabled = false;
                this.reset();
            }
        }
    }
}
