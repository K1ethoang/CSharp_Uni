using System.Data;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ListViewItem lvItem = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtId.Clear();
            txtId.Focus();

            radLove.Checked = true;
            rad2D.Checked = true;

            txtName.Clear();
            dtpDate.ResetText();
            nmrAge.Value = 18;
            txtCountry.Clear();
            txtBonus.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type, format;

            if (radLove.Checked)
            {
                type = radLove.Text;
            }
            else
            {
                type = radAction.Text;
            }

            if (rad2D.Checked)
            {
                format = rad2D.Text;
            }
            else
            {
                format = rad3D.Text;
            }

            string[] dataRow = { txtId.Text, txtName.Text, type, dtpDate.Text, txtCountry.Text, format, txtBonus.Text, nmrAge.Value.ToString() };

            ListViewItem li = new ListViewItem(dataRow);

            lvListFilm.Items.Add(li);

            reset();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvListFilm.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu?", "Thống báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    foreach (var li in lvListFilm.CheckedItems)
                    {
                        lvListFilm.Items.Remove((ListViewItem)li);
                    }
                }
            }
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void lvListFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListFilm.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;

                btnAdd.Enabled = false;
            }
            else if (lvListFilm.CheckedItems.Count > 0)
                btnRemove.Enabled = true;
            else
            {
                reset();
                btnSave.Enabled = false;
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;

                btnAdd.Enabled = true;
            }
        }

        private void lvListFilm_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvListFilm.CheckedItems.Count > 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                reset();
                btnRemove.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

            txtId.Text = lvListFilm.SelectedItems[0].SubItems[0].Text;
            txtName.Text = lvListFilm.SelectedItems[0].SubItems[1].Text;

            if (lvListFilm.SelectedItems[0].SubItems[2].Text.Equals("Tình cảm"))
                radLove.Checked = true;
            else
                radAction.Checked = true;

            dtpDate.Text = lvListFilm.SelectedItems[0].SubItems[3].Text;

            txtCountry.Text = lvListFilm.SelectedItems[0].SubItems[4].Text;

            if (lvListFilm.SelectedItems[0].SubItems[5].Text.Equals("2D"))
                rad2D.Checked = true;
            else
                rad3D.Checked = true;

            txtBonus.Text = lvListFilm.SelectedItems[0].SubItems[6].Text;

            nmrAge.Value = Convert.ToInt32(lvListFilm.SelectedItems[0].SubItems[7].Text);

            lvItem = lvListFilm.SelectedItems[0];

            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string type, format;

            if (radLove.Checked)
                type = radLove.Text;
            else
                type = radAction.Text;

            if (rad2D.Checked)
                format = rad2D.Text;
            else
                format = rad3D.Text;

            lvItem.SubItems[0].Text = txtId.Text;
            lvItem.SubItems[1].Text = txtName.Text;
            lvItem.SubItems[2].Text = type;
            lvItem.SubItems[3].Text = dtpDate.Text;
            lvItem.SubItems[4].Text = txtCountry.Text;
            lvItem.SubItems[5].Text = format;
            lvItem.SubItems[6].Text = txtBonus.Text;
            lvItem.SubItems[7].Text = nmrAge.Value.ToString();

            reset();
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}