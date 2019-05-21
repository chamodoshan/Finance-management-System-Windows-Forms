namespace FinancialSystem
{
    partial class MenuView
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
            this.p_p_btn = new System.Windows.Forms.Button();
            this.lable_menu = new System.Windows.Forms.Label();
            this.p_p_btn_u = new System.Windows.Forms.Button();
            this.e_btn = new System.Windows.Forms.Button();
            this.e_btn_u = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.predic_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p_p_btn
            // 
            this.p_p_btn.AutoSize = true;
            this.p_p_btn.Location = new System.Drawing.Point(233, 85);
            this.p_p_btn.Name = "p_p_btn";
            this.p_p_btn.Size = new System.Drawing.Size(248, 32);
            this.p_p_btn.TabIndex = 0;
            this.p_p_btn.Text = "Add Payee or Payer";
            this.p_p_btn.UseVisualStyleBackColor = true;
            this.p_p_btn.Click += new System.EventHandler(this.PayeePayerForm);
            // 
            // lable_menu
            // 
            this.lable_menu.AutoSize = true;
            this.lable_menu.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_menu.Location = new System.Drawing.Point(323, 36);
            this.lable_menu.Name = "lable_menu";
            this.lable_menu.Size = new System.Drawing.Size(66, 25);
            this.lable_menu.TabIndex = 23;
            this.lable_menu.Text = "Menu";
            this.lable_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_p_btn_u
            // 
            this.p_p_btn_u.AutoSize = true;
            this.p_p_btn_u.Location = new System.Drawing.Point(233, 141);
            this.p_p_btn_u.Name = "p_p_btn_u";
            this.p_p_btn_u.Size = new System.Drawing.Size(248, 32);
            this.p_p_btn_u.TabIndex = 24;
            this.p_p_btn_u.Text = "View / Update Payee or Payer";
            this.p_p_btn_u.UseVisualStyleBackColor = true;
            this.p_p_btn_u.Click += new System.EventHandler(this.UpdatePayeeOrPayer);
            // 
            // e_btn
            // 
            this.e_btn.AutoSize = true;
            this.e_btn.Location = new System.Drawing.Point(233, 198);
            this.e_btn.Name = "e_btn";
            this.e_btn.Size = new System.Drawing.Size(248, 32);
            this.e_btn.TabIndex = 25;
            this.e_btn.Text = "Add Expense";
            this.e_btn.UseVisualStyleBackColor = true;
            this.e_btn.Click += new System.EventHandler(this.ExpenseForm);
            // 
            // e_btn_u
            // 
            this.e_btn_u.AutoSize = true;
            this.e_btn_u.Location = new System.Drawing.Point(233, 255);
            this.e_btn_u.Name = "e_btn_u";
            this.e_btn_u.Size = new System.Drawing.Size(248, 32);
            this.e_btn_u.TabIndex = 26;
            this.e_btn_u.Text = "View / Update Expense or Income";
            this.e_btn_u.UseVisualStyleBackColor = true;
            this.e_btn_u.Click += new System.EventHandler(this.UpdateExpenseOrIncome);
            // 
            // report_btn
            // 
            this.report_btn.AutoSize = true;
            this.report_btn.Location = new System.Drawing.Point(233, 314);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(248, 32);
            this.report_btn.TabIndex = 27;
            this.report_btn.Text = "Display Report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.ReportForm);
            // 
            // predic_btn
            // 
            this.predic_btn.AutoSize = true;
            this.predic_btn.Location = new System.Drawing.Point(233, 373);
            this.predic_btn.Name = "predic_btn";
            this.predic_btn.Size = new System.Drawing.Size(248, 32);
            this.predic_btn.TabIndex = 28;
            this.predic_btn.Text = "Display Predictions";
            this.predic_btn.UseVisualStyleBackColor = true;
            this.predic_btn.Click += new System.EventHandler(this.PredictionForm);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(733, 436);
            this.Controls.Add(this.predic_btn);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.e_btn_u);
            this.Controls.Add(this.e_btn);
            this.Controls.Add(this.p_p_btn_u);
            this.Controls.Add(this.lable_menu);
            this.Controls.Add(this.p_p_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p_p_btn;
        private System.Windows.Forms.Label lable_menu;
        private System.Windows.Forms.Button p_p_btn_u;
        private System.Windows.Forms.Button e_btn;
        private System.Windows.Forms.Button e_btn_u;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Button predic_btn;
    }
}