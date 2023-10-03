namespace WinFormsApp1
{
    partial class Form5
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
            lblName = new Label();
            txtName = new TextBox();
            lblDesc = new Label();
            rtbDesc = new RichTextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            btnClose = new Button();
            lvListProduct = new ListView();
            colName = new ColumnHeader();
            colDesc = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(34, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(134, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Tên sản phẩm:";
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 34);
            txtName.TabIndex = 2;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(34, 123);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(68, 28);
            lblDesc.TabIndex = 3;
            lblDesc.Text = "Mô tả:";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(174, 120);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(285, 82);
            rtbDesc.TabIndex = 4;
            rtbDesc.Text = "";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(174, 217);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(285, 34);
            txtPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(34, 223);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(134, 28);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Giá sản phẩm:";
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(120, 289);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(374, 289);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.Location = new Point(628, 289);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 37);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(882, 289);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 37);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lvListProduct
            // 
            lvListProduct.CheckBoxes = true;
            lvListProduct.Columns.AddRange(new ColumnHeader[] { colName, colDesc, colPrice });
            lvListProduct.FullRowSelect = true;
            lvListProduct.GridLines = true;
            lvListProduct.HideSelection = true;
            lvListProduct.Location = new Point(498, 69);
            lvListProduct.MultiSelect = false;
            lvListProduct.Name = "lvListProduct";
            lvListProduct.Size = new Size(549, 182);
            lvListProduct.TabIndex = 11;
            lvListProduct.UseCompatibleStateImageBehavior = false;
            lvListProduct.View = View.Details;
            lvListProduct.SelectedIndexChanged += lvListProduct_SelectedIndexChanged;
            // 
            // colName
            // 
            colName.Text = "Tên sản phẩm";
            colName.Width = 200;
            // 
            // colDesc
            // 
            colDesc.Text = "Mô tả";
            colDesc.Width = 200;
            // 
            // colPrice
            // 
            colPrice.Text = "Giá";
            colPrice.Width = 120;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1047, 25);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "CHƯƠNG TRÌNH CẬP NHẬT THÔNG TIN SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1071, 349);
            Controls.Add(lblTitle);
            Controls.Add(lvListProduct);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(rtbDesc);
            Controls.Add(lblDesc);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblDesc;
        private RichTextBox rtbDesc;
        private TextBox txtPrice;
        private Label lblPrice;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnReset;
        private Button btnClose;
        private ListView lvListProduct;
        private ColumnHeader colName;
        private ColumnHeader colDesc;
        private ColumnHeader colPrice;
        private Label lblTitle;
    }
}