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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rtbContent.AppendText("Nghệ thuật kiềm chế cơn nóng giận\n");
            rtbContent.AppendText("Nếu người đó nhỏ hơn bạn, đếm 3 lần trước khi nói\n");
            rtbContent.AppendText("Nếu người đó ngang hơn bạn, đếm 5 lần trước khi nói\n");
            rtbContent.AppendText("Nếu người đó lớn hơn bạn, đếm 7 lần trước khi nói\n");
            rtbContent.AppendText("Nếu người đó là VỢ bạn, cứ ĐẾM khỏi nói\n");
            rtbContent.AppendText("Nếu người đó là CHỒNG bạn, cứ NÓI khỏi đếm\n");
        }
    }
}
