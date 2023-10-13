namespace _6251071049_Hoàng_Gia_Kiệt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblId = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblNumber = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblDate = new Label();
            cmbCategory = new ComboBox();
            nbrNumber = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            gbRepo = new GroupBox();
            radHN = new RadioButton();
            radDN = new RadioButton();
            radTPHCM = new RadioButton();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            lvProduct = new ListView();
            colId = new ColumnHeader();
            colName = new ColumnHeader();
            colCategory = new ColumnHeader();
            colNumber = new ColumnHeader();
            colPrice = new ColumnHeader();
            colRepo = new ColumnHeader();
            colDate = new ColumnHeader();
            colAmount = new ColumnHeader();
            label2 = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nbrNumber).BeginInit();
            groupBox1.SuspendLayout();
            gbRepo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1050, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM NHẬP KHO";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(153, 75);
            lblId.Name = "lblId";
            lblId.Size = new Size(71, 28);
            lblId.TabIndex = 1;
            lblId.Text = "Mã SP:";
            // 
            // txtId
            // 
            txtId.Location = new Point(230, 69);
            txtId.Name = "txtId";
            txtId.Size = new Size(438, 34);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(230, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(438, 34);
            txtName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(153, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(72, 28);
            lblName.TabIndex = 3;
            lblName.Text = "Tên SP:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(121, 157);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(104, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Danh mục:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(128, 199);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(96, 28);
            lblNumber.TabIndex = 7;
            lblNumber.Text = "Số lượng:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(230, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(438, 34);
            txtPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(139, 239);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(85, 28);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Đơn giá:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(112, 328);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(112, 28);
            lblDate.TabIndex = 13;
            lblDate.Text = "Ngày nhập:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Loa bluetooth" });
            cmbCategory.Location = new Point(230, 151);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(438, 36);
            cmbCategory.TabIndex = 15;
            // 
            // nbrNumber
            // 
            nbrNumber.Location = new Point(230, 193);
            nbrNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nbrNumber.Name = "nbrNumber";
            nbrNumber.Size = new Size(438, 34);
            nbrNumber.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(729, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 293);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(15, 233);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(229, 43);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(15, 183);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(229, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(229, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(15, 83);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(229, 43);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(229, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbRepo
            // 
            gbRepo.Controls.Add(radHN);
            gbRepo.Controls.Add(radDN);
            gbRepo.Controls.Add(radTPHCM);
            gbRepo.Location = new Point(230, 265);
            gbRepo.Name = "gbRepo";
            gbRepo.Size = new Size(438, 51);
            gbRepo.TabIndex = 18;
            gbRepo.TabStop = false;
            // 
            // radHN
            // 
            radHN.AutoSize = true;
            radHN.Location = new Point(337, 16);
            radHN.Name = "radHN";
            radHN.Size = new Size(94, 32);
            radHN.TabIndex = 22;
            radHN.TabStop = true;
            radHN.Text = "Hà Nội";
            radHN.UseVisualStyleBackColor = true;
            // 
            // radDN
            // 
            radDN.AutoSize = true;
            radDN.Location = new Point(170, 16);
            radDN.Name = "radDN";
            radDN.Size = new Size(110, 32);
            radDN.TabIndex = 21;
            radDN.TabStop = true;
            radDN.Text = "Đà Nẵng";
            radDN.UseVisualStyleBackColor = true;
            // 
            // radTPHCM
            // 
            radTPHCM.AutoSize = true;
            radTPHCM.Checked = true;
            radTPHCM.Location = new Point(6, 16);
            radTPHCM.Name = "radTPHCM";
            radTPHCM.Size = new Size(107, 32);
            radTPHCM.TabIndex = 20;
            radTPHCM.TabStop = true;
            radTPHCM.Text = "TP. HCM";
            radTPHCM.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(230, 328);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(435, 34);
            dtpDate.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 283);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 20;
            label1.Text = "Kho:";
            // 
            // lvProduct
            // 
            lvProduct.CheckBoxes = true;
            lvProduct.Columns.AddRange(new ColumnHeader[] { colId, colName, colCategory, colNumber, colPrice, colRepo, colDate, colAmount });
            lvProduct.FullRowSelect = true;
            lvProduct.GridLines = true;
            lvProduct.Location = new Point(12, 407);
            lvProduct.MultiSelect = false;
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(1050, 250);
            lvProduct.Sorting = SortOrder.Ascending;
            lvProduct.TabIndex = 21;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.View = View.Details;
            lvProduct.SelectedIndexChanged += lvProduct_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "Mã SP";
            colId.Width = 80;
            // 
            // colName
            // 
            colName.Text = "Tên SP";
            colName.Width = 200;
            // 
            // colCategory
            // 
            colCategory.Text = "Danh mục";
            colCategory.Width = 140;
            // 
            // colNumber
            // 
            colNumber.Text = "Số lượng";
            colNumber.Width = 100;
            // 
            // colPrice
            // 
            colPrice.Text = "Đơn giá";
            colPrice.Width = 120;
            // 
            // colRepo
            // 
            colRepo.Text = "Kho";
            colRepo.Width = 100;
            // 
            // colDate
            // 
            colDate.Text = "Ngày nhập";
            colDate.Width = 120;
            // 
            // colAmount
            // 
            colAmount.Text = "Thành tiền";
            colAmount.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(690, 683);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 22;
            label2.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(795, 683);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(267, 34);
            txtTotal.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 720);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(lvProduct);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(gbRepo);
            Controls.Add(groupBox1);
            Controls.Add(nbrNumber);
            Controls.Add(cmbCategory);
            Controls.Add(lblDate);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblNumber);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6251071049 - Hoàng Gia Kiệt";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nbrNumber).EndInit();
            groupBox1.ResumeLayout(false);
            gbRepo.ResumeLayout(false);
            gbRepo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtName;
        private Label lblName;
        private Label lblCategory;
        private Label lblNumber;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox textBox5;
        private Label lblRepo;
        private TextBox textBox6;
        private Label lblDate;
        private ComboBox cmbCategory;
        private NumericUpDown nbrNumber;
        private GroupBox groupBox1;
        private GroupBox gbRepo;
        private RadioButton radHN;
        private RadioButton radDN;
        private RadioButton radTPHCM;
        private DateTimePicker dtpDate;
        private Label label1;
        private Button btnExit;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private ListView lvProduct;
        private Label label2;
        private ColumnHeader colId;
        private ColumnHeader colName;
        private ColumnHeader colCategory;
        private ColumnHeader colNumber;
        private ColumnHeader colPrice;
        private ColumnHeader colRepo;
        private ColumnHeader colDate;
        private ColumnHeader colAmount;
        private TextBox txtTotal;
    }
}