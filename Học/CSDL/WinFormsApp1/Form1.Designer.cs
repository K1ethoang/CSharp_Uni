namespace WinFormsApp1
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
            dtvProduct = new DataGridView();
            txtFind = new TextBox();
            btnFind = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnView = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvProduct).BeginInit();
            SuspendLayout();
            // 
            // dtvProduct
            // 
            dtvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvProduct.Location = new Point(12, 12);
            dtvProduct.Name = "dtvProduct";
            dtvProduct.RowHeadersWidth = 51;
            dtvProduct.RowTemplate.Height = 29;
            dtvProduct.Size = new Size(520, 354);
            dtvProduct.TabIndex = 0;
            // 
            // txtFind
            // 
            txtFind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFind.Location = new Point(555, 22);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(220, 34);
            txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFind.Location = new Point(794, 20);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 38);
            btnFind.TabIndex = 2;
            btnFind.Text = "Search";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(555, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(333, 41);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(555, 197);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(333, 41);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(555, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(333, 41);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.Location = new Point(555, 69);
            btnView.Name = "btnView";
            btnView.Size = new Size(333, 41);
            btnView.TabIndex = 7;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(555, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(333, 41);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(900, 382);
            Controls.Add(btnExit);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Controls.Add(dtvProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật thông tin sản phẩm";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dtvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtvProduct;
        private TextBox txtFind;
        private Button btnFind;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnView;
        private Button btnExit;
    }
}