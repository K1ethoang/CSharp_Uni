using System.Collections;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp1.DAO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận thoát!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Business.Business.Instance.See(dgvProduct);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            Business.Business.Instance.Search(dgvProduct, txtFind.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Business.Business.Instance.Add(dgvProduct))
            {
                MessageBox.Show("Thêm thành công", "Thông báo!");
                Business.Business.Instance.See(dgvProduct);
            }
            else
                MessageBox.Show("Thêm không thành công", "Thông báo!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xoá", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Business.Business.Instance.Delete(dgvProduct))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo!");
                    Business.Business.Instance.See(dgvProduct);
                }
                else
                    MessageBox.Show("Có lỗi khi xoá", "Thông báo!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Business.Business.Instance.Edit(dgvProduct))
            {
                MessageBox.Show("Sửa thành công", "Thông báo!");
                Business.Business.Instance.See(dgvProduct);
            }
            else
                MessageBox.Show("Có lỗi khi sửa", "Thông báo!");
        }
    }
}