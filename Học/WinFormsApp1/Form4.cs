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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            rtbInfor.Clear();
            rtbInfor.AppendText("----- Thông tin đơn hàng ----\n");
            rtbInfor.AppendText("Khách hàng: " + txtName.Text + "\n");
            rtbInfor.AppendText("Điện thoại: " + txtPhone.Text + "\n");

            // Hiển thị ds sản phẩm
            if (lstProduct.SelectedItems.Count != 0)
            {
                rtbInfor.AppendText("Sản phẩm: \n");
                // Cách 1:
                //foreach (var product in lstProduct.SelectedItems)
                //{
                //    rtbInfor.AppendText(" - " + product + "\n");
                //}


                // Cách 2: Truy xuất thông qua tập hợp các chỉ mục index của các phần tử được chọn
                //for (int i = 0; i < lstProduct.SelectedIndices.Count; i++)
                //{
                //    rtbInfor.AppendText((i + 1) + " - " + lstProduct.Items[lstProduct.SelectedIndices[i]] + "\n");
                //}

                // Cách 3:
                foreach (int i in lstProduct.SelectedIndices)
                {
                    rtbInfor.AppendText((i + 1) + " - " + lstProduct.Items[i] + "\n");
                }
            }
            if (chkOptionService.Checked)
            {
                rtbInfor.AppendText("Dịch vụ: Bao sách\n");
            }
            if (radHere.Checked)
            {
                rtbInfor.AppendText("Mua tại cửa hàng\n");
            }
            if (radShip.Checked)
            {
                rtbInfor.AppendText("Giao hàng tận nơi\n");
            }

            rtbInfor.AppendText(cbPayment.SelectedItem.ToString() + '\n');
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lstProduct.Items.Add("Iphone 1");
            lstProduct.Items.Add("Iphone 2");
            lstProduct.Items.Add("Iphone 3");
            lstProduct.Items.Add("Iphone 4");
            lstProduct.Items.Add("Iphone 5");

            cbPayment.SelectedIndex = 0;

        }

    }
}
