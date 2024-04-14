namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tpFood = new TabPage();
            panel6 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel4 = new Panel();
            dtgvFood = new DataGridView();
            panel3 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            tpFoodCategory = new TabPage();
            panel17 = new Panel();
            dtgvCategory = new DataGridView();
            panel16 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            panel11 = new Panel();
            panel14 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            panel15 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            tpTable = new TabPage();
            panel12 = new Panel();
            dtgvTable = new DataGridView();
            panel13 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            panel18 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel19 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel20 = new Panel();
            textBox3 = new TextBox();
            label6 = new Label();
            tbAccount = new TabPage();
            panel22 = new Panel();
            dtgvAccount = new DataGridView();
            panel23 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel24 = new Panel();
            btnResetPassword = new Button();
            panel25 = new Panel();
            cbAccountType = new ComboBox();
            label10 = new Label();
            panel26 = new Panel();
            txtDisplayName = new TextBox();
            label11 = new Label();
            panel27 = new Panel();
            txbUsername = new TextBox();
            label12 = new Label();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel3.SuspendLayout();
            tpFoodCategory.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel16.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            tpTable.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel13.SuspendLayout();
            panel18.SuspendLayout();
            panel21.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            tbAccount.SuspendLayout();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tbAccount);
            tcAdmin.Location = new Point(4, 5);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1001, 525);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(993, 492);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(4, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 408);
            panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(7, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(972, 402);
            dtgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 67);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(404, 8);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(162, 45);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(694, 15);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(250, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(24, 15);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(250, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(993, 492);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(628, 79);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 407);
            panel6.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 204);
            panel10.Name = "panel10";
            panel10.Size = new Size(353, 58);
            panel10.TabIndex = 5;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(136, 18);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(209, 27);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 21);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 0;
            label4.Text = "Giá";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 140);
            panel9.Name = "panel9";
            panel9.Size = new Size(353, 58);
            panel9.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(136, 16);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(209, 28);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 21);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 0;
            label3.Text = "Danh mục";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(3, 76);
            panel8.Name = "panel8";
            panel8.Size = new Size(353, 58);
            panel8.TabIndex = 4;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(136, 3);
            txbFoodName.Multiline = true;
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(209, 41);
            txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên món";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbDisplayName);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(3, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(353, 58);
            panel7.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(136, 3);
            txbDisplayName.Multiline = true;
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.ReadOnly = true;
            txbDisplayName.Size = new Size(209, 41);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 21);
            label2.Name = "label2";
            label2.Size = new Size(30, 23);
            label2.TabIndex = 0;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFoodName);
            panel5.Controls.Add(btnSearchFood);
            panel5.Location = new Point(628, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(359, 66);
            panel5.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(8, 23);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(248, 27);
            txbSearchFoodName.TabIndex = 1;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(262, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(94, 60);
            btnSearchFood.TabIndex = 0;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFood);
            panel4.Location = new Point(6, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(616, 407);
            panel4.TabIndex = 1;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(610, 401);
            dtgvFood.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnShowFood);
            panel3.Controls.Add(btnEditFood);
            panel3.Controls.Add(btnDeleteFood);
            panel3.Controls.Add(btnAddFood);
            panel3.Location = new Point(5, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 66);
            panel3.TabIndex = 0;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(501, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(94, 60);
            btnShowFood.TabIndex = 0;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(339, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(94, 60);
            btnEditFood.TabIndex = 0;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(177, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 60);
            btnDeleteFood.TabIndex = 0;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(15, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 60);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel17);
            tpFoodCategory.Controls.Add(panel16);
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(993, 492);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            panel17.Controls.Add(dtgvCategory);
            panel17.Location = new Point(6, 79);
            panel17.Name = "panel17";
            panel17.Size = new Size(616, 407);
            panel17.TabIndex = 6;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(610, 401);
            dtgvCategory.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnShowCategory);
            panel16.Controls.Add(btnEditCategory);
            panel16.Controls.Add(btnDeleteCategory);
            panel16.Controls.Add(btnAddCategory);
            panel16.Location = new Point(6, 6);
            panel16.Name = "panel16";
            panel16.Size = new Size(616, 66);
            panel16.TabIndex = 5;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(501, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(94, 60);
            btnShowCategory.TabIndex = 0;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(339, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(94, 60);
            btnEditCategory.TabIndex = 0;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(177, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 60);
            btnDeleteCategory.TabIndex = 0;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(15, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 60);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(631, 79);
            panel11.Name = "panel11";
            panel11.Size = new Size(359, 407);
            panel11.TabIndex = 4;
            // 
            // panel14
            // 
            panel14.Controls.Add(textBox1);
            panel14.Controls.Add(label7);
            panel14.Location = new Point(3, 76);
            panel14.Name = "panel14";
            panel14.Size = new Size(353, 58);
            panel14.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 41);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 21);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbCategoryID);
            panel15.Controls.Add(label8);
            panel15.Location = new Point(3, 12);
            panel15.Name = "panel15";
            panel15.Size = new Size(353, 58);
            panel15.TabIndex = 3;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(146, 3);
            txbCategoryID.Multiline = true;
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(199, 41);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 21);
            label8.Name = "label8";
            label8.Size = new Size(30, 23);
            label8.TabIndex = 0;
            label8.Text = "ID";
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel12);
            tpTable.Controls.Add(panel13);
            tpTable.Controls.Add(panel18);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(993, 492);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvTable);
            panel12.Location = new Point(4, 79);
            panel12.Name = "panel12";
            panel12.Size = new Size(616, 407);
            panel12.TabIndex = 9;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(610, 401);
            dtgvTable.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnShowTable);
            panel13.Controls.Add(btnEditTable);
            panel13.Controls.Add(btnDeleteTable);
            panel13.Controls.Add(btnAddTable);
            panel13.Location = new Point(4, 6);
            panel13.Name = "panel13";
            panel13.Size = new Size(616, 66);
            panel13.TabIndex = 8;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(501, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(94, 60);
            btnShowTable.TabIndex = 0;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(339, 3);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(94, 60);
            btnEditTable.TabIndex = 0;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(177, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(94, 60);
            btnDeleteTable.TabIndex = 0;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(15, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(94, 60);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Controls.Add(panel21);
            panel18.Controls.Add(panel19);
            panel18.Controls.Add(panel20);
            panel18.Location = new Point(629, 79);
            panel18.Name = "panel18";
            panel18.Size = new Size(359, 407);
            panel18.TabIndex = 7;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(3, 140);
            panel21.Name = "panel21";
            panel21.Size = new Size(353, 58);
            panel21.TabIndex = 5;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(151, 18);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(194, 28);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 21);
            label9.Name = "label9";
            label9.Size = new Size(101, 23);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái";
            // 
            // panel19
            // 
            panel19.Controls.Add(txbTableName);
            panel19.Controls.Add(label5);
            panel19.Location = new Point(3, 76);
            panel19.Name = "panel19";
            panel19.Size = new Size(353, 58);
            panel19.TabIndex = 4;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(146, 3);
            txbTableName.Multiline = true;
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(199, 41);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 21);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn";
            // 
            // panel20
            // 
            panel20.Controls.Add(textBox3);
            panel20.Controls.Add(label6);
            panel20.Location = new Point(3, 12);
            panel20.Name = "panel20";
            panel20.Size = new Size(353, 58);
            panel20.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(199, 41);
            textBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 21);
            label6.Name = "label6";
            label6.Size = new Size(30, 23);
            label6.TabIndex = 0;
            label6.Text = "ID";
            // 
            // tbAccount
            // 
            tbAccount.Controls.Add(panel22);
            tbAccount.Controls.Add(panel23);
            tbAccount.Controls.Add(panel24);
            tbAccount.Location = new Point(4, 29);
            tbAccount.Name = "tbAccount";
            tbAccount.Padding = new Padding(3);
            tbAccount.Size = new Size(993, 492);
            tbAccount.TabIndex = 4;
            tbAccount.Text = "Tài khoản";
            tbAccount.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            panel22.Controls.Add(dtgvAccount);
            panel22.Location = new Point(4, 79);
            panel22.Name = "panel22";
            panel22.Size = new Size(616, 407);
            panel22.TabIndex = 12;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(610, 401);
            dtgvAccount.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnShowAccount);
            panel23.Controls.Add(btnEditAccount);
            panel23.Controls.Add(btnDeleteAccount);
            panel23.Controls.Add(btnAddAccount);
            panel23.Location = new Point(4, 6);
            panel23.Name = "panel23";
            panel23.Size = new Size(616, 66);
            panel23.TabIndex = 11;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(501, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(94, 60);
            btnShowAccount.TabIndex = 0;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(339, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 60);
            btnEditAccount.TabIndex = 0;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(177, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 60);
            btnDeleteAccount.TabIndex = 0;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(15, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(94, 60);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnResetPassword);
            panel24.Controls.Add(panel25);
            panel24.Controls.Add(panel26);
            panel24.Controls.Add(panel27);
            panel24.Location = new Point(629, 79);
            panel24.Name = "panel24";
            panel24.Size = new Size(359, 407);
            panel24.TabIndex = 10;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(174, 226);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(154, 49);
            btnResetPassword.TabIndex = 7;
            btnResetPassword.Text = "Reset mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            panel25.Controls.Add(cbAccountType);
            panel25.Controls.Add(label10);
            panel25.Location = new Point(3, 140);
            panel25.Name = "panel25";
            panel25.Size = new Size(353, 58);
            panel25.TabIndex = 6;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(146, 18);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(199, 28);
            cbAccountType.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 18);
            label10.Name = "label10";
            label10.Size = new Size(71, 23);
            label10.TabIndex = 0;
            label10.Text = "Loại tk";
            // 
            // panel26
            // 
            panel26.Controls.Add(txtDisplayName);
            panel26.Controls.Add(label11);
            panel26.Location = new Point(3, 76);
            panel26.Name = "panel26";
            panel26.Size = new Size(353, 58);
            panel26.TabIndex = 4;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(146, 3);
            txtDisplayName.Multiline = true;
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(199, 41);
            txtDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 21);
            label11.Name = "label11";
            label11.Size = new Size(117, 23);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị";
            // 
            // panel27
            // 
            panel27.Controls.Add(txbUsername);
            panel27.Controls.Add(label12);
            panel27.Location = new Point(3, 12);
            panel27.Name = "panel27";
            panel27.Size = new Size(353, 58);
            panel27.TabIndex = 3;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(146, 3);
            txbUsername.Multiline = true;
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(199, 41);
            txbUsername.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(5, 21);
            label12.Name = "label12";
            label12.Size = new Size(101, 23);
            label12.TabIndex = 0;
            label12.Text = "Tài khoản";
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 532);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdmin";
            Load += fAdmin_Load;
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel3.ResumeLayout(false);
            tpFoodCategory.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel16.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            tpTable.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel13.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            tbAccount.ResumeLayout(false);
            panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private Panel panel2;
        private Panel panel1;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tbAccount;
        private DataGridView dtgvBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Button btnViewBill;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel4;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel7;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label1;
        private DataGridView dtgvFood;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel17;
        private DataGridView dtgvCategory;
        private Panel panel16;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel11;
        private Panel panel14;
        private TextBox textBox1;
        private Label label7;
        private Panel panel15;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel12;
        private DataGridView dtgvTable;
        private Panel panel13;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel18;
        private Panel panel21;
        private ComboBox cbTableStatus;
        private Label label9;
        private Panel panel19;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel20;
        private TextBox textBox3;
        private Label label6;
        private Panel panel22;
        private DataGridView dtgvAccount;
        private Panel panel23;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Panel panel24;
        private Button btnResetPassword;
        private Panel panel25;
        private ComboBox cbAccountType;
        private Label label10;
        private Panel panel26;
        private TextBox txtDisplayName;
        private Label label11;
        private Panel panel27;
        private TextBox txbUsername;
        private Label label12;
    }
}