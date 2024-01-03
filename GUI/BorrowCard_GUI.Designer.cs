namespace GUI
{
    partial class BorrowCard_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_idcart3 = new System.Windows.Forms.Label();
            this.lbl_idcart2 = new System.Windows.Forms.Label();
            this.lbl_IDCard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccb_IDStaff = new System.Windows.Forms.ComboBox();
            this.ccb_IDReader = new System.Windows.Forms.ComboBox();
            this.cb_Return = new System.Windows.Forms.CheckBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_BookStatus = new System.Windows.Forms.TextBox();
            this.txt_DateReturn = new System.Windows.Forms.TextBox();
            this.txt_DateBorrow = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lv_BorrowCard = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_idcart3);
            this.panel1.Controls.Add(this.lbl_idcart2);
            this.panel1.Controls.Add(this.lbl_IDCard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 62);
            this.panel1.TabIndex = 0;
            // 
            // lbl_idcart3
            // 
            this.lbl_idcart3.AutoSize = true;
            this.lbl_idcart3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_idcart3.Location = new System.Drawing.Point(795, 25);
            this.lbl_idcart3.Name = "lbl_idcart3";
            this.lbl_idcart3.Size = new System.Drawing.Size(85, 23);
            this.lbl_idcart3.TabIndex = 4;
            this.lbl_idcart3.Text = "Mã phiếu";
            // 
            // lbl_idcart2
            // 
            this.lbl_idcart2.AutoSize = true;
            this.lbl_idcart2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_idcart2.Location = new System.Drawing.Point(704, 25);
            this.lbl_idcart2.Name = "lbl_idcart2";
            this.lbl_idcart2.Size = new System.Drawing.Size(85, 23);
            this.lbl_idcart2.TabIndex = 3;
            this.lbl_idcart2.Text = "Mã phiếu";
            this.lbl_idcart2.Click += new System.EventHandler(this.lbl_idcart2_Click);
            // 
            // lbl_IDCard
            // 
            this.lbl_IDCard.AutoSize = true;
            this.lbl_IDCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IDCard.Location = new System.Drawing.Point(704, 25);
            this.lbl_IDCard.Name = "lbl_IDCard";
            this.lbl_IDCard.Size = new System.Drawing.Size(85, 23);
            this.lbl_IDCard.TabIndex = 1;
            this.lbl_IDCard.Text = "Mã phiếu";
            this.lbl_IDCard.Click += new System.EventHandler(this.lbl_IDCard_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_detail);
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ccb_IDStaff);
            this.groupBox1.Controls.Add(this.ccb_IDReader);
            this.groupBox1.Controls.Add(this.cb_Return);
            this.groupBox1.Controls.Add(this.bntExit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txt_BookStatus);
            this.groupBox1.Controls.Add(this.txt_DateReturn);
            this.groupBox1.Controls.Add(this.txt_DateBorrow);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(547, 220);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(131, 48);
            this.btn_detail.TabIndex = 22;
            this.btn_detail.Text = "Chi tiết";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(39, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(142, 48);
            this.btnAddBook.TabIndex = 21;
            this.btnAddBook.Text = "Thêm đầu sách";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã khách hàng";
            // 
            // ccb_IDStaff
            // 
            this.ccb_IDStaff.FormattingEnabled = true;
            this.ccb_IDStaff.Location = new System.Drawing.Point(187, 72);
            this.ccb_IDStaff.Name = "ccb_IDStaff";
            this.ccb_IDStaff.Size = new System.Drawing.Size(234, 31);
            this.ccb_IDStaff.TabIndex = 16;
            // 
            // ccb_IDReader
            // 
            this.ccb_IDReader.FormattingEnabled = true;
            this.ccb_IDReader.Location = new System.Drawing.Point(187, 35);
            this.ccb_IDReader.Name = "ccb_IDReader";
            this.ccb_IDReader.Size = new System.Drawing.Size(235, 31);
            this.ccb_IDReader.TabIndex = 15;
            // 
            // cb_Return
            // 
            this.cb_Return.AutoSize = true;
            this.cb_Return.Location = new System.Drawing.Point(500, 152);
            this.cb_Return.Name = "cb_Return";
            this.cb_Return.Size = new System.Drawing.Size(79, 27);
            this.cb_Return.TabIndex = 14;
            this.cb_Return.Text = "Đã trả";
            this.cb_Return.UseVisualStyleBackColor = true;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(713, 220);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(123, 48);
            this.bntExit.TabIndex = 13;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 48);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 48);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Tạo phiếu mượn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_BookStatus
            // 
            this.txt_BookStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookStatus.Location = new System.Drawing.Point(500, 109);
            this.txt_BookStatus.Name = "txt_BookStatus";
            this.txt_BookStatus.PlaceholderText = "Tình trạng sách";
            this.txt_BookStatus.Size = new System.Drawing.Size(336, 30);
            this.txt_BookStatus.TabIndex = 9;
            // 
            // txt_DateReturn
            // 
            this.txt_DateReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DateReturn.Location = new System.Drawing.Point(500, 72);
            this.txt_DateReturn.Name = "txt_DateReturn";
            this.txt_DateReturn.PlaceholderText = "Ngày trả";
            this.txt_DateReturn.Size = new System.Drawing.Size(336, 30);
            this.txt_DateReturn.TabIndex = 8;
            // 
            // txt_DateBorrow
            // 
            this.txt_DateBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DateBorrow.Location = new System.Drawing.Point(500, 35);
            this.txt_DateBorrow.Name = "txt_DateBorrow";
            this.txt_DateBorrow.PlaceholderText = "Ngày mượn";
            this.txt_DateBorrow.Size = new System.Drawing.Size(336, 30);
            this.txt_DateBorrow.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 336);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(900, 4);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // lv_BorrowCard
            // 
            this.lv_BorrowCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader8});
            this.lv_BorrowCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_BorrowCard.FullRowSelect = true;
            this.lv_BorrowCard.GridLines = true;
            this.lv_BorrowCard.Location = new System.Drawing.Point(0, 340);
            this.lv_BorrowCard.Name = "lv_BorrowCard";
            this.lv_BorrowCard.Size = new System.Drawing.Size(900, 328);
            this.lv_BorrowCard.TabIndex = 3;
            this.lv_BorrowCard.UseCompatibleStateImageBehavior = false;
            this.lv_BorrowCard.View = System.Windows.Forms.View.Details;
            this.lv_BorrowCard.SelectedIndexChanged += new System.EventHandler(this.lv_BorrowCard_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên người mượn";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lớp";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số điện thoại";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên người lập";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng sách mượn";
            this.columnHeader8.Width = 180;
            // 
            // BorrowCard_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.lv_BorrowCard);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BorrowCard_GUI";
            this.Text = "Phieu_Muon_Tra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowCard_GUI_FormClosing);
            this.Load += new System.EventHandler(this.BorrowCard_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_IDCard;
        private Label label1;
        private GroupBox groupBox1;
        private Splitter splitter1;
        private ListView lv_BorrowCard;
        private TextBox txt_BookStatus;
        private TextBox txt_DateReturn;
        private TextBox txt_DateBorrow;
        private Button bntExit;
        private Button btnDelete;
        private Button btnAdd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private CheckBox cb_Return;
        private ComboBox ccb_IDStaff;
        private ComboBox ccb_IDReader;
        private Label label3;
        private Label label2;
        private Label lbl_idcart3;
        private Label lbl_idcart2;
        private Button btnAddBook;
        private ColumnHeader columnHeader8;
        private Button btn_detail;
    }
}