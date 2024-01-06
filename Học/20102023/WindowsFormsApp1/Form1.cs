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
            Excel.Workbook excelWb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet excelWs = excelApp.Worksheets[1];

            Excel.Range excelRange = excelWs.Cells[1, 1];
            excelRange.Font.Size = 16;
            excelRange.Font.Bold = true;
            excelRange.Font.Color = Color.Red;
            excelRange.Value = "DANH MỤC SẢN PHẨM";

            // Lấy danh mục
            var catalogs = db.Catalog.Select(c => new { code = c.CatalogCode, name = c.CatalogName }).ToList();
            int row = 2;

            foreach (var c in catalogs)
            {
                excelWs.Range["A" + row].Font.Bold = true;
                excelWs.Range["A" + row].Value = c.name;
                row++;

                // Lấy sp theo danh mục
                var products = from p in db.Product where p.CatalogCode == c.code select p;
                foreach (var p in products)
                {
                    excelWs.Range["A" + row].Value = p.ProductCode;
                    excelWs.Range["B" + row].ColumnWidth = 50;
                    excelWs.Range["B" + row].Value = p.ProductName;
                    excelWs.Range["C" + row].Value = p.ProductPrice;
                    row++;
                }
            }
            excelWs.Name = "DanhMucSanPham";
            excelWb.Activate();

            // Lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                excelWb.SaveAs(saveFileDialog.FileName);
            excelApp.Quit();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            // Chuẩn bị nguồn dữ liệu
            var data = db.Product.Select(p => new { ProductCode = p.ProductCode, ProductName = p.ProductName, ProductPrice = p.ProductPrice, CatalogName = p.Catalog.CatalogName }).ToList();

            // Gán nguồn dữ liệu cho CrystalReport
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(data);

            // Hiển thị báo cáo
            Form2 fRpt = new Form2();
            fRpt.crystalReportViewer1.ReportSource = rpt;
            fRpt.ShowDialog();
        }
    }
}
