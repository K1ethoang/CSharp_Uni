using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        product_2Entities1 db = new product_2Entities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = db.Product.ToList();
            dgvProduct.Columns[0].ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = "USB 32GB";
            p.ProductPrice = 1200000;
            p.CatalogCode = 3;
            db.Product.Add(p);
            db.SaveChanges();
            btnView_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvProduct.Rows[dgvProduct.CurrentRow.Index];

            int code = Convert.ToInt32(selectedRow.Cells["ProductCode"].Value);

            //Product selectedProduct = db.Product.Find(code);
            Product selectedProduct = db.Product.Where(p => p.ProductCode == code).SingleOrDefault();

            selectedProduct.ProductName = selectedRow.Cells["ProductName"].Value.ToString();
            selectedProduct.ProductPrice = float.Parse(selectedRow.Cells["ProductPrice"].Value.ToString());

            db.SaveChanges();
            btnView_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int pCode = Convert.ToInt32(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells["ProductCode"].Value);

            Product selectedProduct = db.Product.Where(p => p.ProductCode == pCode).SingleOrDefault();

            db.Product.Remove(selectedProduct);
            db.SaveChanges();
            btnView_Click(sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
        }
    }
}
