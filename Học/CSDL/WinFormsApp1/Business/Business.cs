using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DTOs;

namespace WinFormsApp1.Business
{
    internal class Business
    {
        private static Business instance;

        public static Business Instance
        {
            get
            {
                if (instance == null)
                    instance = new Business();
                return instance;
            }
        }

        public Business()
        {
        }

        public void See(DataGridView dgv)
        {
            dgv.DataSource = DAO.DAO.Instance.See();
            dgv.Columns[0].ReadOnly = true;
        }

        public void Search(DataGridView dgv, string productName)
        {
            dgv.DataSource = DAO.DAO.Instance.Search(productName);
        }

        public bool Add(DataGridView dgv)
        {
            DataGridViewRow row = dgv.Rows[dgv.CurrentRow.Index];

            Console.WriteLine(row);

            ProductModel p = new ProductModel();
            p.ProductName = row.Cells["ProductName"].Value.ToString();
            p.ProductPrice = Convert.ToSingle(row.Cells["ProductPrice"].Value.ToString());
            return DAO.DAO.Instance.Add(p);
        }

        public bool Delete(DataGridView dgv)
        {
            DataGridViewRow row = dgv.Rows[dgv.CurrentRow.Index];

            Console.WriteLine(row);

            int pCode = Convert.ToInt32(row.Cells["ProductCode"].Value);

            return DAO.DAO.Instance.Delete(pCode);
        }

        public bool Edit(DataGridView dgv)
        {
            DataGridViewRow row = dgv.Rows[dgv.CurrentRow.Index];

            Console.WriteLine(row);

            ProductModel p = new ProductModel();
            p.ProductId = Convert.ToInt32(row.Cells["ProductCode"].Value);
            p.ProductName = row.Cells["ProductName"].Value.ToString();
            p.ProductPrice = Convert.ToSingle(row.Cells["ProductPrice"].Value.ToString());
            return DAO.DAO.Instance.Edit(p);
        }
    }
}
