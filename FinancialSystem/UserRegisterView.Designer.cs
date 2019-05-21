namespace FinancialSystem
{
    partial class UserRegisterView
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
            this.lable1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.c_num = new System.Windows.Forms.Label();
            this.adsress = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txt_con_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_re = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(248, 30);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(90, 25);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Register";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(232, 92);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(289, 22);
            this.txt_name.TabIndex = 20;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(232, 129);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(289, 22);
            this.txt_mail.TabIndex = 19;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(232, 166);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(289, 22);
            this.txt_pass.TabIndex = 18;
            // 
            // c_num
            // 
            this.c_num.AutoSize = true;
            this.c_num.Location = new System.Drawing.Point(84, 166);
            this.c_num.Name = "c_num";
            this.c_num.Size = new System.Drawing.Size(86, 17);
            this.c_num.TabIndex = 17;
            this.c_num.Text = "Password : -";
            // 
            // adsress
            // 
            this.adsress.AutoSize = true;
            this.adsress.Location = new System.Drawing.Point(84, 129);
            this.adsress.Name = "adsress";
            this.adsress.Size = new System.Drawing.Size(59, 17);
            this.adsress.TabIndex = 16;
            this.adsress.Text = "Email : -";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(84, 92);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 17);
            this.name.TabIndex = 15;
            this.name.Text = "Name : -";
            // 
            // txt_con_pass
            // 
            this.txt_con_pass.Location = new System.Drawing.Point(232, 206);
            this.txt_con_pass.Name = "txt_con_pass";
            this.txt_con_pass.Size = new System.Drawing.Size(289, 22);
            this.txt_con_pass.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confirm Password : -";
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(87, 272);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(179, 42);
            this.btn_re.TabIndex = 23;
            this.btn_re.Text = "Register";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.Register);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(342, 272);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(179, 42);
            this.btn_login.TabIndex = 24;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.LoginView);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 326);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_re);
            this.Controls.Add(this.txt_con_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.c_num);
            this.Controls.Add(this.adsress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label c_num;
        private System.Windows.Forms.Label adsress;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txt_con_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.Button btn_login;
    }
}