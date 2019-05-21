namespace FinancialSystem
{
    partial class ExpensesAndIncomeDeatilsView
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
            this.lable2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(240, 41);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(237, 25);
            this.lable2.TabIndex = 22;
            this.lable2.Text = "Add Expense or Income";
            this.lable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(148, 92);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(133, 17);
            this.lbl.TabIndex = 35;
            this.lbl.Text = "How Many Entries ?";
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(448, 85);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(137, 26);
            this.btn_generate.TabIndex = 37;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.GenerateEntries);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(296, 87);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(146, 22);
            this.numericUpDown.TabIndex = 38;
            // 
            // ExpensesAndIncomeDeatilsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(733, 436);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lable2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExpensesAndIncomeDeatilsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses/Incomes";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}