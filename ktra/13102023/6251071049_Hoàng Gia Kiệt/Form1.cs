namespace _6251071049_Hoàng_Gia_Kiệt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            txtTotal.Text = String.Format("{0:0,0 vnđ}", 0);
        }

        private void reset()
        {
            txtId.Clear();
            txtId.Focus();

            txtName.Clear();
            cmbCategory.Refresh();
            nbrNumber.Value = 0;
            txtPrice.Clear();
            radTPHCM.Checked = true;
            dtpDate.Value = DateTime.Now;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (txtId.Text == "")
                MessageBox.Show("Mã sp không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtName.Text == "")
                MessageBox.Show("Tên sp không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nbrNumber.Text == "")
                MessageBox.Show("Số lượng không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPrice.Text == "")
                MessageBox.Show("Giá sp không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (double.TryParse(txtPrice.Text, out price) == false)
                MessageBox.Show("Giá sp phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtpDate.Value > DateTime.Now)
                MessageBox.Show("Thời gian không được lớn hơn hôm nay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string repo;

                if (radTPHCM.Checked)
                    repo = radTPHCM.Text;
                else if (radDN.Checked)
                    repo = radDN.Text;
                else
                    repo = radHN.Text;

                double amount = (int)nbrNumber.Value * price;


                string[] dataRow = { txtId.Text, txtName.Text, cmbCategory.SelectedItem.ToString(), nbrNumber.Value.ToString(), txtPrice.Text, repo, dtpDate.Value.ToString().Split(" ")[0], amount.ToString() };

                ListViewItem item = new ListViewItem(dataRow);

                lvProduct.Items.Add(item);

                double total = Convert.ToDouble(txtTotal.Text.Split(" ")[0]) + amount;

                txtTotal.Text = String.Format("{0:0,0 vnđ}", total);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                e.Cancel = true;
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
    }
}