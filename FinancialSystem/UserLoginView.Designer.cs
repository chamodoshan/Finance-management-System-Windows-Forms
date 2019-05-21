namespace FinancialSystem
{
    partial class UserLoginView
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
            this.btn_re = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.c_num = new System.Windows.Forms.Label();
            this.adsress = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(342, 263);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(179, 42);
            this.btn_re.TabIndex = 31;
            this.btn_re.Text = "Register";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.RegisterView);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(87, 263);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(179, 42);
            this.btn_login.TabIndex = 30;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Login);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(232, 103);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(289, 22);
            this.txt_mail.TabIndex = 29;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(232, 140);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(289, 22);
            this.txt_pass.TabIndex = 28;
            // 
            // c_num
            // 
            this.c_num.AutoSize = true;
            this.c_num.Location = new System.Drawing.Point(84, 140);
            this.c_num.Name = "c_num";
            this.c_num.Size = new System.Drawing.Size(86, 17);
            this.c_num.TabIndex = 27;
            this.c_num.Text = "Password : -";
            // 
            // adsress
            // 
            this.adsress.AutoSize = true;
            this.adsress.Location = new System.Drawing.Point(84, 103);
            this.adsress.Name = "adsress";
            this.adsress.Size = new System.Drawing.Size(59, 17);
            this.adsress.TabIndex = 26;
            this.adsress.Text = "Email : -";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(269, 21);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(67, 25);
            this.lable1.TabIndex = 25;
            this.lable1.Text = "Login";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // loading
            // 
            this.loading.Image = global::FinancialSystem.Properties.Resources.Loading_icon;
            this.loading.Location = new System.Drawing.Point(96, 189);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(100, 50);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 32;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // UserLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 326);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.btn_re);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.c_num);
            this.Controls.Add(this.adsress);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label c_num;
        private System.Windows.Forms.Label adsress;
        private System.Windows.Forms.Label lable1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox loading;
    }
}