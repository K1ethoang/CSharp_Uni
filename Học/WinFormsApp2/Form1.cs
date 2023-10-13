namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtName.Clear();
            txtName.Focus();

            rtbDesc.Clear();
            txtPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] dataRow = { txtName.Text, rtbDesc.Text, txtPrice.Text };
            ListViewItem item = new ListViewItem(dataRow);

            item.ImageIndex = 0;
            lvProduct.Items.Add(item);

            reset();
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvProduct.View = View.SmallIcon;
            lvProduct.Items[0].ImageIndex = 0;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvProduct.View = View.LargeIcon;
            lvProduct.Items[0].ImageIndex = 1;
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            lvProduct.ForeColor = cd.Color;
        }
    }
}