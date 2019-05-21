namespace FinancialSystem
{
    partial class PayeePayerDetailsView
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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.adsress = new System.Windows.Forms.Label();
            this.c_num = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.payment_method = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.payee = new System.Windows.Forms.RadioButton();
            this.payer = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtBox_p_method = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.payeeAndPayerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancialSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.payeeAndPayerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialSystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(142, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Name : -";
            // 
            // adsress
            // 
            this.adsress.AutoSize = true;
            this.adsress.Location = new System.Drawing.Point(142, 130);
            this.adsress.Name = "adsress";
            this.adsress.Size = new System.Drawing.Size(77, 17);
            this.adsress.TabIndex = 1;
            this.adsress.Text = "Address : -";
            // 
            // c_num
            // 
            this.c_num.AutoSize = true;
            this.c_num.Location = new System.Drawing.Point(142, 167);
            this.c_num.Name = "c_num";
            this.c_num.Size = new System.Drawing.Size(127, 17);
            this.c_num.TabIndex = 2;
            this.c_num.Text = "Contact Number : -";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(142, 206);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 17);
            this.email.TabIndex = 3;
            this.email.Text = "Email : -";
            // 
            // payment_method
            // 
            this.payment_method.AutoSize = true;
            this.payment_method.Location = new System.Drawing.Point(142, 242);
            this.payment_method.Name = "payment_method";
            this.payment_method.Size = new System.Drawing.Size(131, 17);
            this.payment_method.TabIndex = 4;
            this.payment_method.Text = "Payment Method : -";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(269, 29);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(196, 25);
            this.lable1.TabIndex = 5;
            this.lable1.Text = "Add Payee or Payer";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payee
            // 
            this.payee.AutoSize = true;
            this.payee.Location = new System.Drawing.Point(145, 286);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(68, 21);
            this.payee.TabIndex = 6;
            this.payee.TabStop = true;
            this.payee.Tag = "0";
            this.payee.Text = "payee";
            this.payee.UseVisualStyleBackColor = true;
            // 
            // payer
            // 
            this.payer.AutoSize = true;
            this.payer.Location = new System.Drawing.Point(239, 286);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(65, 21);
            this.payer.TabIndex = 9;
            this.payer.TabStop = true;
            this.payer.Tag = "1";
            this.payer.Text = "payer";
            this.payer.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtBox_p_method
            // 
            this.txtBox_p_method.FormattingEnabled = true;
            this.txtBox_p_method.Items.AddRange(new object[] {
            "Online Transfer",
            "Cheque",
            "Cash",
            "Card"});
            this.txtBox_p_method.Location = new System.Drawing.Point(290, 239);
            this.txtBox_p_method.Name = "txtBox_p_method";
            this.txtBox_p_method.Size = new System.Drawing.Size(289, 24);
            this.txtBox_p_method.TabIndex = 10;
            this.txtBox_p_method.Text = "Select a Payement Method";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(290, 203);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(289, 22);
            this.txt_email.TabIndex = 11;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(290, 167);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(289, 22);
            this.txt_num.TabIndex = 12;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(290, 130);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(289, 22);
            this.txt_add.TabIndex = 13;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(290, 93);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(289, 22);
            this.txt_name.TabIndex = 14;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.RoyalBlue;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.save.Location = new System.Drawing.Point(290, 344);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(162, 46);
            this.save.TabIndex = 16;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.SavePayeeOrPayer);
            // 
            // payeeAndPayerTableBindingSource
            // 
            this.payeeAndPayerTableBindingSource.DataMember = "PayeeAndPayerTable";
            // 
            // PayeePayerDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 436);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txtBox_p_method);
            this.Controls.Add(this.payer);
            this.Controls.Add(this.payee);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.payment_method);
            this.Controls.Add(this.email);
            this.Controls.Add(this.c_num);
            this.Controls.Add(this.adsress);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayeePayerDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payee/Payer";
            ((System.ComponentModel.ISupportInitialize)(this.payeeAndPayerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialSystemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label adsress;
        private System.Windows.Forms.Label c_num;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label payment_method;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.RadioButton payee;
        private System.Windows.Forms.RadioButton payer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox txtBox_p_method;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.BindingSource dBFinancialSystemBindingSource;
        
        private System.Windows.Forms.BindingSource payeeAndPayerTableBindingSource;
    }
}

