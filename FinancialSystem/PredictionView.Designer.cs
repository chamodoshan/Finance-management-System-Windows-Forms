namespace FinancialSystem
{
    partial class PredictionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_predict = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expenses = new System.Windows.Forms.Label();
            this.incomes = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(305, 29);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(111, 25);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Prediction";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a Date";
            // 
            // dateTimePicker_predict
            // 
            this.dateTimePicker_predict.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_predict.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_predict.Location = new System.Drawing.Point(325, 93);
            this.dateTimePicker_predict.Name = "dateTimePicker_predict";
            this.dateTimePicker_predict.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker_predict.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Expenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Incomes";
            // 
            // expenses
            // 
            this.expenses.AutoSize = true;
            this.expenses.Location = new System.Drawing.Point(322, 209);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(13, 17);
            this.expenses.TabIndex = 11;
            this.expenses.Text = "-";
            // 
            // incomes
            // 
            this.incomes.AutoSize = true;
            this.incomes.Location = new System.Drawing.Point(322, 280);
            this.incomes.Name = "incomes";
            this.incomes.Size = new System.Drawing.Size(13, 17);
            this.incomes.TabIndex = 12;
            this.incomes.Text = "-";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(291, 357);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(146, 43);
            this.btn_cal.TabIndex = 13;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.Calculation);
            // 
            // PredictionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 436);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.incomes);
            this.Controls.Add(this.expenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_predict);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PredictionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predictions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_predict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label expenses;
        private System.Windows.Forms.Label incomes;
        private System.Windows.Forms.Button btn_cal;
    }
}