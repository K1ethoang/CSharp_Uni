namespace WinFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            btnOrder = new Button();
            rtbInfor = new RichTextBox();
            lstProduct = new ListBox();
            lblListProduct = new Label();
            lblInfor = new Label();
            chkOptionService = new CheckBox();
            radHere = new RadioButton();
            radShip = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cbPayment = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(987, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin đặt hàng";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(93, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(145, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Khách hàng:";
            // 
            // txtName
            // 
            txtName.Location = new Point(244, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(272, 39);
            txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(244, 113);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(272, 39);
            txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(93, 120);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(130, 32);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Điện thoại:";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(449, 672);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(146, 40);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Đặt hàng";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // rtbInfor
            // 
            rtbInfor.Location = new Point(559, 84);
            rtbInfor.Name = "rtbInfor";
            rtbInfor.Size = new Size(423, 432);
            rtbInfor.TabIndex = 6;
            rtbInfor.Text = "";
            // 
            // lstProduct
            // 
            lstProduct.FormattingEnabled = true;
            lstProduct.ImeMode = ImeMode.NoControl;
            lstProduct.ItemHeight = 31;
            lstProduct.Location = new Point(93, 206);
            lstProduct.Name = "lstProduct";
            lstProduct.SelectionMode = SelectionMode.MultiExtended;
            lstProduct.Size = new Size(423, 159);
            lstProduct.TabIndex = 7;
            // 
            // lblListProduct
            // 
            lblListProduct.AutoSize = true;
            lblListProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblListProduct.Location = new Point(93, 175);
            lblListProduct.Name = "lblListProduct";
            lblListProduct.Size = new Size(207, 28);
            lblListProduct.TabIndex = 8;
            lblListProduct.Text = "Danh sách sản phẩm";
            lblListProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfor
            // 
            lblInfor.AutoSize = true;
            lblInfor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfor.Location = new Point(559, 53);
            lblInfor.Name = "lblInfor";
            lblInfor.RightToLeft = RightToLeft.No;
            lblInfor.Size = new Size(201, 28);
            lblInfor.TabIndex = 11;
            lblInfor.Text = "Thông tin đơn hàng";
            lblInfor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkOptionService
            // 
            chkOptionService.AutoSize = true;
            chkOptionService.Location = new Point(93, 371);
            chkOptionService.Name = "chkOptionService";
            chkOptionService.Size = new Size(299, 36);
            chkOptionService.TabIndex = 13;
            chkOptionService.Text = "Sử dụng dịch vụ gói quà";
            chkOptionService.UseVisualStyleBackColor = true;
            // 
            // radHere
            // 
            radHere.AutoSize = true;
            radHere.Checked = true;
            radHere.Location = new Point(18, 49);
            radHere.Name = "radHere";
            radHere.Size = new Size(221, 36);
            radHere.TabIndex = 15;
            radHere.TabStop = true;
            radHere.Text = "Mua tại cửa hàng";
            radHere.UseVisualStyleBackColor = true;
            // 
            // radShip
            // 
            radShip.AutoSize = true;
            radShip.Location = new Point(18, 91);
            radShip.Name = "radShip";
            radShip.Size = new Size(226, 36);
            radShip.TabIndex = 16;
            radShip.Text = "Giao hàng tận nơi";
            radShip.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radHere);
            groupBox1.Controls.Add(radShip);
            groupBox1.Location = new Point(93, 413);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 141);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cách giao hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 566);
            label1.Name = "label1";
            label1.Size = new Size(245, 28);
            label1.TabIndex = 18;
            label1.Text = "Phương thức thanh toán";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbPayment
            // 
            cbPayment.FormattingEnabled = true;
            cbPayment.Items.AddRange(new object[] { "Tiền mặt", "Momo", "Ngân hàng" });
            cbPayment.Location = new Point(93, 606);
            cbPayment.Name = "cbPayment";
            cbPayment.Size = new Size(423, 39);
            cbPayment.TabIndex = 19;
            // 
            // Form4
            // 
            AcceptButton = btnOrder;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 724);
            Controls.Add(cbPayment);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(chkOptionService);
            Controls.Add(lblInfor);
            Controls.Add(lblListProduct);
            Controls.Add(lstProduct);
            Controls.Add(rtbInfor);
            Controls.Add(btnOrder);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label lblPhone;
        private Button btnOrder;
        private RichTextBox rtbInfor;
        private ListBox lstProduct;
        private Label lblListProduct;
        private Label lblInfor;
        private CheckBox chkOptionService;
        private RadioButton radHere;
        private RadioButton radShip;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbPayment;
    }
}