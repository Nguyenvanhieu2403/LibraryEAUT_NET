namespace GUI
{
    partial class DetailBorrmow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_detailBr = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.lbl_cardID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nameUser = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_detailBr);
            this.groupBox1.Location = new System.Drawing.Point(46, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lst_detailBr
            // 
            this.lst_detailBr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lst_detailBr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_detailBr.FullRowSelect = true;
            this.lst_detailBr.GridLines = true;
            this.lst_detailBr.Location = new System.Drawing.Point(3, 26);
            this.lst_detailBr.Name = "lst_detailBr";
            this.lst_detailBr.Size = new System.Drawing.Size(798, 218);
            this.lst_detailBr.TabIndex = 0;
            this.lst_detailBr.UseCompatibleStateImageBehavior = false;
            this.lst_detailBr.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sách";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thể loại";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác giả";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày mượn";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày trả";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết mượn trả";
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_txt.Location = new System.Drawing.Point(643, 50);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(106, 28);
            this.lbl_txt.TabIndex = 2;
            this.lbl_txt.Text = "Mã phiếu:";
            // 
            // lbl_cardID
            // 
            this.lbl_cardID.AutoSize = true;
            this.lbl_cardID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cardID.Location = new System.Drawing.Point(755, 50);
            this.lbl_cardID.Name = "lbl_cardID";
            this.lbl_cardID.Size = new System.Drawing.Size(33, 28);
            this.lbl_cardID.TabIndex = 3;
            this.lbl_cardID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên người mượn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại:";
            // 
            // lbl_nameUser
            // 
            this.lbl_nameUser.AutoSize = true;
            this.lbl_nameUser.Location = new System.Drawing.Point(225, 108);
            this.lbl_nameUser.Name = "lbl_nameUser";
            this.lbl_nameUser.Size = new System.Drawing.Size(87, 23);
            this.lbl_nameUser.TabIndex = 6;
            this.lbl_nameUser.Text = "nameUser";
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(170, 166);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(122, 23);
            this.lbl_phoneNumber.TabIndex = 7;
            this.lbl_phoneNumber.Text = "phoneNumber";
            // 
            // DetailBorrmow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_nameUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cardID);
            this.Controls.Add(this.lbl_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DetailBorrmow";
            this.Text = "DetailBorrmow";
            this.Load += new System.EventHandler(this.DetailBorrmow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lst_detailBr;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label1;
        private Label lbl_txt;
        private Label lbl_cardID;
        private Label label2;
        private Label label3;
        private Label lbl_nameUser;
        private Label lbl_phoneNumber;
    }
}