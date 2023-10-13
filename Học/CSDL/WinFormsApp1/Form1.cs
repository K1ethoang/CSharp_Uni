using System.Collections;
using System.Data;
using System.Data.SqlClient;

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

        private DataTable execSql(string sql, params object[] args)
        {
            DataTable data = new DataTable();

            string connectStr = @"Data Source=K1ETHOANG;Initial Catalog=c_product;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                string query = sql;

                SqlCommand cmd = new SqlCommand(query, connection);

                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(" ");

                    List<string> paramList = new List<string>();

                    foreach (string prm in processSql)
                    {
                        if (prm.StartsWith("@"))
                        {
                            if (prm.EndsWith(","))
                                prm.Remove(prm.Length - 1);
                            paramList.Add(prm);
                        }
                    }

                    for (int i = 0; i < args.Length; i++)
                        cmd.Parameters.AddWithValue(paramList[i], args[i]);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product";
            dtvProduct.DataSource = execSql(query);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "select * from product where productName like @keyword and productCode > @number";

            Object[] prms = new object[] { "%" + txtFind.Text + "%", 1};

            DataTable data = execSql(query, prms);

            dtvProduct.DataSource = data;

            txtFind.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

    }
}