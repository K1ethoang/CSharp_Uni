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
            label1 = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            txtCountry = new TextBox();
            lblCountry = new Label();
            lblType = new Label();
            groupBox2 = new GroupBox();
            gbFormat = new GroupBox();
            rad2D = new RadioButton();
            rad3D = new RadioButton();
            gbType = new GroupBox();
            radLove = new RadioButton();
            radAction = new RadioButton();
            txtBonus = new TextBox();
            lblBonus = new Label();
            lblFormat = new Label();
            nmrAge = new NumericUpDown();
            lblAge = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            groupBox1 = new GroupBox();
            lvListFilm = new ListView();
            colId = new ColumnHeader();
            colName = new ColumnHeader();
            colType = new ColumnHeader();
            colDate = new ColumnHeader();
            colAge = new ColumnHeader();
            colCountry = new ColumnHeader();
            colFormat = new ColumnHeader();
            colBonus = new ColumnHeader();
            groupBox3 = new GroupBox();
            btnEdit = new Button();
            btnStatist = new Button();
            btnSort = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            groupBox2.SuspendLayout();
            gbFormat.SuspendLayout();
            gbType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAge).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1230, 25);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ DOANH THU PHIM CHIẾU RẠP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(84, 28);
            lblId.TabIndex = 2;
            lblId.Text = "Mã đơn:";
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(365, 34);
            txtId.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 107);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 28);
            lblName.TabIndex = 4;
            lblName.Text = "Tên phim:";
            // 
            // txtName
            // 
            txtName.Location = new Point(128, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 34);
            txtName.TabIndex = 5;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(128, 154);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(365, 34);
            txtCountry.TabIndex = 7;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(23, 160);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(95, 28);
            lblCountry.TabIndex = 6;
            lblCountry.Text = "Quốc gia:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(23, 212);
            lblType.Name = "lblType";
            lblType.Size = new Size(84, 28);
            lblType.TabIndex = 8;
            lblType.Text = "Thể loại:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gbFormat);
            groupBox2.Controls.Add(gbType);
            groupBox2.Controls.Add(txtBonus);
            groupBox2.Controls.Add(lblBonus);
            groupBox2.Controls.Add(lblFormat);
            groupBox2.Controls.Add(nmrAge);
            groupBox2.Controls.Add(lblAge);
            groupBox2.Controls.Add(dtpDate);
            groupBox2.Controls.Add(lblDate);
            groupBox2.Controls.Add(lblId);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(lblType);
            groupBox2.Controls.Add(lblName);
            groupBox2.Controls.Add(txtCountry);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(lblCountry);
            groupBox2.Location = new Point(45, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(20, 3, 20, 3);
            groupBox2.Size = new Size(527, 467);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phim";
            // 
            // gbFormat
            // 
            gbFormat.Controls.Add(rad2D);
            gbFormat.Controls.Add(rad3D);
            gbFormat.Location = new Point(159, 353);
            gbFormat.Name = "gbFormat";
            gbFormat.Size = new Size(268, 52);
            gbFormat.TabIndex = 20;
            gbFormat.TabStop = false;
            // 
            // rad2D
            // 
            rad2D.AutoSize = true;
            rad2D.Checked = true;
            rad2D.Location = new Point(6, 15);
            rad2D.Name = "rad2D";
            rad2D.Size = new Size(58, 32);
            rad2D.TabIndex = 16;
            rad2D.TabStop = true;
            rad2D.Text = "2D";
            rad2D.UseVisualStyleBackColor = true;
            // 
            // rad3D
            // 
            rad3D.AutoSize = true;
            rad3D.Location = new Point(176, 15);
            rad3D.Name = "rad3D";
            rad3D.Size = new Size(58, 32);
            rad3D.TabIndex = 17;
            rad3D.Text = "3D";
            rad3D.UseVisualStyleBackColor = true;
            // 
            // gbType
            // 
            gbType.Controls.Add(radLove);
            gbType.Controls.Add(radAction);
            gbType.FlatStyle = FlatStyle.Popup;
            gbType.Location = new Point(128, 194);
            gbType.Name = "gbType";
            gbType.Size = new Size(365, 60);
            gbType.TabIndex = 1;
            gbType.TabStop = false;
            // 
            // radLove
            // 
            radLove.AutoSize = true;
            radLove.Checked = true;
            radLove.Location = new Point(6, 19);
            radLove.Name = "radLove";
            radLove.Size = new Size(111, 32);
            radLove.TabIndex = 9;
            radLove.TabStop = true;
            radLove.Text = "Tình cảm";
            radLove.UseVisualStyleBackColor = true;
            // 
            // radAction
            // 
            radAction.AutoSize = true;
            radAction.Location = new Point(223, 19);
            radAction.Name = "radAction";
            radAction.Size = new Size(131, 32);
            radAction.TabIndex = 10;
            radAction.Text = "Hành động";
            radAction.UseVisualStyleBackColor = true;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(280, 419);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(219, 34);
            txtBonus.TabIndex = 19;
            // 
            // lblBonus
            // 
            lblBonus.AutoSize = true;
            lblBonus.Location = new Point(23, 426);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(251, 28);
            lblBonus.TabIndex = 18;
            lblBonus.Text = "Phụ thu xuất chiếu đặc biệt:";
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Location = new Point(23, 366);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(107, 28);
            lblFormat.TabIndex = 15;
            lblFormat.Text = "Định dạng:";
            // 
            // nmrAge
            // 
            nmrAge.Location = new Point(204, 313);
            nmrAge.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nmrAge.Name = "nmrAge";
            nmrAge.Size = new Size(289, 34);
            nmrAge.TabIndex = 14;
            nmrAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(23, 315);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(164, 28);
            lblAge.TabIndex = 13;
            lblAge.Text = "Độ tuổi quy định:";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "";
            dtpDate.Location = new Point(204, 260);
            dtpDate.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(289, 34);
            dtpDate.TabIndex = 12;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(23, 265);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(163, 28);
            lblDate.TabIndex = 11;
            lblDate.Text = "Ngày công chiếu:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvListFilm);
            groupBox1.Location = new Point(593, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(619, 467);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phim";
            // 
            // lvListFilm
            // 
            lvListFilm.CheckBoxes = true;
            lvListFilm.Columns.AddRange(new ColumnHeader[] { colId, colName, colType, colDate, colAge, colCountry, colFormat, colBonus });
            lvListFilm.FullRowSelect = true;
            lvListFilm.GridLines = true;
            lvListFilm.HideSelection = true;
            lvListFilm.Location = new Point(13, 40);
            lvListFilm.MultiSelect = false;
            lvListFilm.Name = "lvListFilm";
            lvListFilm.Size = new Size(593, 414);
            lvListFilm.TabIndex = 0;
            lvListFilm.UseCompatibleStateImageBehavior = false;
            lvListFilm.View = View.Details;
            lvListFilm.ItemChecked += lvListFilm_ItemChecked;
            lvListFilm.SelectedIndexChanged += lvListFilm_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "Mã đơn";
            colId.Width = 100;
            // 
            // colName
            // 
            colName.Text = "Tên phim";
            colName.Width = 200;
            // 
            // colType
            // 
            colType.Text = "Thể loại";
            colType.Width = 100;
            // 
            // colDate
            // 
            colDate.Text = "Ngày công chiếu";
            colDate.Width = 200;
            // 
            // colAge
            // 
            colAge.DisplayIndex = 7;
            colAge.Text = "Độ tuổi quy định";
            // 
            // colCountry
            // 
            colCountry.DisplayIndex = 4;
            colCountry.Text = "Quốc gia";
            // 
            // colFormat
            // 
            colFormat.DisplayIndex = 5;
            colFormat.Text = "Định dạng";
            // 
            // colBonus
            // 
            colBonus.DisplayIndex = 6;
            colBonus.Text = "Phụ thu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnStatist);
            groupBox3.Controls.Add(btnSort);
            groupBox3.Controls.Add(btnRemove);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(45, 531);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1167, 102);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tác vụ";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.PaleTurquoise;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(614, 45);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(143, 37);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnStatist
            // 
            btnStatist.BackColor = Color.PaleTurquoise;
            btnStatist.Cursor = Cursors.Hand;
            btnStatist.FlatStyle = FlatStyle.Flat;
            btnStatist.Location = new Point(1008, 45);
            btnStatist.Name = "btnStatist";
            btnStatist.Size = new Size(143, 37);
            btnStatist.TabIndex = 4;
            btnStatist.Text = "Thống kê";
            btnStatist.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.PaleTurquoise;
            btnSort.Cursor = Cursors.Hand;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Location = new Point(811, 45);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(143, 37);
            btnSort.TabIndex = 3;
            btnSort.Text = "Sắp xếp";
            btnSort.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.PaleTurquoise;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Enabled = false;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(417, 45);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(143, 37);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.PaleTurquoise;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(220, 45);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 37);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleTurquoise;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(23, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 649);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6251071049 - Hoàng Gia Kiệt";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbFormat.ResumeLayout(false);
            gbFormat.PerformLayout();
            gbType.ResumeLayout(false);
            gbType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAge).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtCountry;
        private Label lblCountry;
        private Label lblType;
        private GroupBox groupBox2;
        private RadioButton radAction;
        private RadioButton radLove;
        private NumericUpDown nmrAge;
        private Label lblAge;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private Label lblBonus;
        private RadioButton rad3D;
        private RadioButton rad2D;
        private Label lblFormat;
        private TextBox txtBonus;
        private GroupBox groupBox1;
        private ListView lvListFilm;
        private ColumnHeader colId;
        private ColumnHeader colName;
        private ColumnHeader colType;
        private ColumnHeader colDate;
        private GroupBox groupBox3;
        private Button btnAdd;
        private Button btnSort;
        private Button btnRemove;
        private Button btnSave;
        private Button btnEdit;
        private Button btnStatist;
        private ColumnHeader colAge;
        private ColumnHeader colCountry;
        private ColumnHeader colFormat;
        private ColumnHeader colBonus;
        private GroupBox gbType;
        private GroupBox gbFormat;
    }
}