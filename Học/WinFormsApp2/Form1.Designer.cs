namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rtbDesc = new RichTextBox();
            lvProduct = new ListView();
            colName = new ColumnHeader();
            colDesc = new ColumnHeader();
            colPrice = new ColumnHeader();
            lvImage = new ImageList(components);
            btnAdd = new Button();
            mnListView = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            smallIconToolStripMenuItem = new ToolStripMenuItem();
            largeIconToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            btnEdit = new Button();
            btnReset = new Button();
            btnExit = new Button();
            mnListView.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(0, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(965, 31);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH CẬP NHẬT THÔNG TIN SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 90);
            label2.Name = "label2";
            label2.Size = new Size(84, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên sp:";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 38);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 323);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(251, 38);
            txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 330);
            label3.Name = "label3";
            label3.Size = new Size(83, 31);
            label3.TabIndex = 5;
            label3.Text = "Giá sp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 157);
            label4.Name = "label4";
            label4.Size = new Size(79, 31);
            label4.TabIndex = 3;
            label4.Text = "Mô tả:";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(138, 157);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(251, 139);
            rtbDesc.TabIndex = 4;
            rtbDesc.Text = "";
            // 
            // lvProduct
            // 
            lvProduct.Columns.AddRange(new ColumnHeader[] { colName, colDesc, colPrice });
            lvProduct.LargeImageList = lvImage;
            lvProduct.Location = new Point(443, 83);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(446, 278);
            lvProduct.SmallImageList = lvImage;
            lvProduct.TabIndex = 7;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Tên sp";
            colName.Width = 150;
            // 
            // colDesc
            // 
            colDesc.Text = "Mô tả";
            colDesc.Width = 150;
            // 
            // colPrice
            // 
            colPrice.Text = "Giá";
            // 
            // lvImage
            // 
            lvImage.ColorDepth = ColorDepth.Depth8Bit;
            lvImage.ImageStream = (ImageListStreamer)resources.GetObject("lvImage.ImageStream");
            lvImage.TransparentColor = Color.Transparent;
            lvImage.Images.SetKeyName(0, "Android-Bold-24px.png");
            lvImage.Images.SetKeyName(1, "Apple-Bold-24px.png");
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // mnListView
            // 
            mnListView.ImageScalingSize = new Size(20, 20);
            mnListView.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, formatToolStripMenuItem });
            mnListView.Location = new Point(0, 0);
            mnListView.Name = "mnListView";
            mnListView.Size = new Size(993, 28);
            mnListView.TabIndex = 9;
            mnListView.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem, smallIconToolStripMenuItem, largeIconToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(161, 26);
            listToolStripMenuItem.Text = "List";
            // 
            // smallIconToolStripMenuItem
            // 
            smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            smallIconToolStripMenuItem.Size = new Size(161, 26);
            smallIconToolStripMenuItem.Text = "Small icon";
            smallIconToolStripMenuItem.Click += smallIconToolStripMenuItem_Click;
            // 
            // largeIconToolStripMenuItem
            // 
            largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            largeIconToolStripMenuItem.Size = new Size(161, 26);
            largeIconToolStripMenuItem.Text = "Large icon";
            largeIconToolStripMenuItem.Click += largeIconToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(357, 406);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 38);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(576, 406);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 38);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(795, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 38);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(993, 483);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lvProduct);
            Controls.Add(rtbDesc);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mnListView);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = mnListView;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6251071049 - Hoàng Gia Kiệt";
            mnListView.ResumeLayout(false);
            mnListView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label label3;
        private Label label4;
        private RichTextBox rtbDesc;
        private ListView lvProduct;
        private Button btnAdd;
        private MenuStrip mnListView;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private Button btnEdit;
        private Button btnReset;
        private Button btnExit;
        private ImageList lvImage;
        private ColumnHeader colName;
        private ColumnHeader colDesc;
        private ColumnHeader colPrice;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem smallIconToolStripMenuItem;
        private ToolStripMenuItem largeIconToolStripMenuItem;
    }
}