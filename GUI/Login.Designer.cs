namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lbl_facebook = new System.Windows.Forms.Label();
            this.lbl_Google = new System.Windows.Forms.Label();
            this.lbl_signUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.ForeColor = System.Drawing.Color.Gray;
            this.txt_name.Location = new System.Drawing.Point(547, 109);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(263, 30);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Tài khoản";
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.ForeColor = System.Drawing.Color.Gray;
            this.txt_pass.Location = new System.Drawing.Point(547, 161);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(263, 30);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "Mật khẩu";
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_Click);
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxPass.Location = new System.Drawing.Point(538, 234);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPass.TabIndex = 3;
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.lb_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Login.Location = new System.Drawing.Point(610, 278);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(131, 31);
            this.lb_Login.TabIndex = 4;
            this.lb_Login.Text = "Đăng nhập";
            this.lb_Login.Click += new System.EventHandler(this.lb_Login_Click);
            this.lb_Login.MouseEnter += new System.EventHandler(this.lb_Login_MouseEnter);
            this.lb_Login.MouseLeave += new System.EventHandler(this.lb_Login_MouseLeave);
            // 
            // lbl_facebook
            // 
            this.lbl_facebook.AutoSize = true;
            this.lbl_facebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(176)))));
            this.lbl_facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_facebook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_facebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_facebook.Location = new System.Drawing.Point(564, 387);
            this.lbl_facebook.Name = "lbl_facebook";
            this.lbl_facebook.Size = new System.Drawing.Size(85, 23);
            this.lbl_facebook.TabIndex = 5;
            this.lbl_facebook.Text = "Facebook";
            this.lbl_facebook.MouseEnter += new System.EventHandler(this.lbl_facebook_MouseEnter);
            this.lbl_facebook.MouseLeave += new System.EventHandler(this.lbl_facebook_MouseLeave);
            // 
            // lbl_Google
            // 
            this.lbl_Google.AutoSize = true;
            this.lbl_Google.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lbl_Google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Google.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Google.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Google.Location = new System.Drawing.Point(775, 387);
            this.lbl_Google.Name = "lbl_Google";
            this.lbl_Google.Size = new System.Drawing.Size(67, 23);
            this.lbl_Google.TabIndex = 6;
            this.lbl_Google.Text = "Google";
            this.lbl_Google.MouseEnter += new System.EventHandler(this.lbl_Google_MouseEnter);
            this.lbl_Google.MouseLeave += new System.EventHandler(this.lbl_Google_MouseLeave);
            // 
            // lbl_signUp
            // 
            this.lbl_signUp.AutoSize = true;
            this.lbl_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.lbl_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_signUp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_signUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_signUp.Location = new System.Drawing.Point(623, 442);
            this.lbl_signUp.Name = "lbl_signUp";
            this.lbl_signUp.Size = new System.Drawing.Size(102, 31);
            this.lbl_signUp.TabIndex = 7;
            this.lbl_signUp.Text = "Đăng ký";
            this.lbl_signUp.Click += new System.EventHandler(this.lbl_signUp_Click);
            this.lbl_signUp.MouseEnter += new System.EventHandler(this.lbl_signUp_MouseEnter);
            this.lbl_signUp.MouseLeave += new System.EventHandler(this.lbl_signUp_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.lbl_signUp);
            this.Controls.Add(this.lbl_Google);
            this.Controls.Add(this.lbl_facebook);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_name;
        private TextBox txt_pass;
        private CheckBox checkBoxPass;
        private Label lb_Login;
        private Label lbl_facebook;
        private Label lbl_Google;
        private Label lbl_signUp;
    }
}