using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialSystem
{
    public partial class ExpensesAndIncomeDeatilsView : Form
    {
        ExpenseAndIncomeViewController CEI = new ExpenseAndIncomeViewController();
        private int count = 0;
        Boolean error = false;
        List<string> amount = new List<string>();
        List<string> reason = new List<string>();
        List<string> date = new List<string>();
        List<string> payeepayer = new List<string>();
        List<string> expenseIncome = new List<string>();
        List<string> rows = new List<string>();
        List<List<string>> data = new List<List<string>>();
       
        public ExpensesAndIncomeDeatilsView()
        {
            
            InitializeComponent();
            this.rows =CEI.GetPayeePayer();
        }

        private void GenerateEntries(object sender, EventArgs e)
        {
            lbl.Visible = false;
            numericUpDown.Visible = false;
            btn_generate.Visible = false;
            count = Convert.ToInt32(numericUpDown.Value);
            Panel[] panel = new Panel[(int)this.numericUpDown.Value];
            Label[] label0 = new Label[(int)this.numericUpDown.Value];
            Label[] label1 = new Label[(int)this.numericUpDown.Value];
            Label[] label2 = new Label[(int)this.numericUpDown.Value];
            Label[] label3 = new Label[(int)this.numericUpDown.Value];
            Label[] label4 = new Label[(int)this.numericUpDown.Value];
            Label[] label5 = new Label[(int)this.numericUpDown.Value];
            TextBox[] txt1 = new TextBox[(int)this.numericUpDown.Value];
            TextBox[] txt2 = new TextBox[(int)this.numericUpDown.Value];
            RadioButton[] radioButton1 = new RadioButton[(int)this.numericUpDown.Value];
            RadioButton[] radioButton2 = new RadioButton[(int)this.numericUpDown.Value];
            DateTimePicker[] datePicker = new DateTimePicker[(int)this.numericUpDown.Value];
            ComboBox[] comboBox = new ComboBox[(int)this.numericUpDown.Value];
            ComboBox[] comboBox2 = new ComboBox[(int)this.numericUpDown.Value];
            
            for (int i = 0; i < txt1.Length; i++)
            {
                //instantiate and configure the text boxes
                /*txt[i] = new TextBox();
                System.Drawing.Point p = new System.Drawing.Point(176, 114 + i * 25);
                txt[i].Location = p;
                txt[i].Size = new System.Drawing.Size(183, 20);
                this.Controls.Add(txt[i]);*/
                //instantiate and configure the labels

                /*panel[i] = new Panel();
                panel[i].Location = new System.Drawing.Point(10, 105 + i * 200);
                panel[i].Name = "panel" + (i + 1).ToString();
                panel[i].Size = new System.Drawing.Size(450, 280);
                panel[i].TabIndex = 26;
                this.Controls.Add(panel[i]);*/

                label0[i] = new Label();
                System.Drawing.Point pLabel0 = new System.Drawing.Point(110, 105 + i * 200);
                label0[i].Location = pLabel0;
                label0[i].Size = new System.Drawing.Size(500, 17);
                label0[i].Text = @"Entry - " + (i + 1).ToString() + " ---------------------------------------------------------------------------------------------------------";
                this.Controls.Add(label0[i]);

                label1[i] = new Label();
                System.Drawing.Point pLabel1 = new System.Drawing.Point(110, 135 + i * 200);
                label1[i].Location = pLabel1;
                label1[i].Size = new System.Drawing.Size(69, 17);
                label1[i].Text = @"Amount : - ";
                this.Controls.Add(label1[i]);

                label2[i] = new Label();
                System.Drawing.Point pLabe2 = new System.Drawing.Point(110, 165 + i * 200);
                label2[i].Location = pLabe2;
                label2[i].Size = new System.Drawing.Size(69, 17);
                label2[i].Text = @"Reason : - ";
                this.Controls.Add(label2[i]);

                label3[i] = new Label();
                System.Drawing.Point pLabe3 = new System.Drawing.Point(110, 195 + i * 200);
                label3[i].Location = pLabe3;
                label3[i].Size = new System.Drawing.Size(69, 17);
                label3[i].Text = @"Date : - ";
                this.Controls.Add(label3[i]);

                label4[i] = new Label();
                System.Drawing.Point pLabe4 = new System.Drawing.Point(110, 225 + i * 200);
                label4[i].Location = pLabe4;
                label4[i].Size = new System.Drawing.Size(90, 17);
                label4[i].Text = @"Payee or Payer : - ";
                this.Controls.Add(label4[i]);

                label5[i] = new Label();
                System.Drawing.Point pLabe5 = new System.Drawing.Point(110, 255 + i * 200);
                label5[i].Location = pLabe5;
                label5[i].Size = new System.Drawing.Size(105, 17);
                label5[i].Text = @"Expense or Income : - ";
                this.Controls.Add(label5[i]);

                txt1[i] = new TextBox();
                System.Drawing.Point text1 = new System.Drawing.Point(220, 132 + i * 200);
                txt1[i].Location = text1;
                txt1[i].Size = new System.Drawing.Size(240, 18);
                txt1[i].Name = "txt_amount" + (i + 1).ToString(); 
                this.Controls.Add(txt1[i]);

                txt2[i] = new TextBox();
                System.Drawing.Point text2 = new System.Drawing.Point(220, 162 + i * 200);
                txt2[i].Location = text2;
                txt2[i].Size = new System.Drawing.Size(240, 18);
                txt2[i].Name = "txt_reason" + (i + 1).ToString();
                this.Controls.Add(txt2[i]);

                datePicker[i] = new DateTimePicker();
                datePicker[i].CustomFormat = "yyyy-MM-dd";
                datePicker[i].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                System.Drawing.Point dp = new System.Drawing.Point(220, 192 + i * 200);
                datePicker[i].Location = dp;
                datePicker[i].Size = new System.Drawing.Size(240, 18);
                datePicker[i].Name = "dateTimePicker" + (i + 1).ToString();
                this.Controls.Add(datePicker[i]);

                comboBox[i] = new ComboBox();
                System.Drawing.Point cb = new System.Drawing.Point(220, 222 + i * 200);
                comboBox[i].Location = cb;
                comboBox[i].Size = new System.Drawing.Size(240, 18);
                comboBox[i].Name = "comboBox_p_p" + (i + 1).ToString();
                for (int j = 0; j < rows.Count; j++)
                {
                    comboBox[i].Items.Add(rows[j]);
                }  
                this.Controls.Add(comboBox[i]);

                comboBox2[i] = new ComboBox();
                System.Drawing.Point cb2 = new System.Drawing.Point(220, 252 + i * 200);
                comboBox2[i].Location = cb2;
                comboBox2[i].Size = new System.Drawing.Size(240, 18);
                comboBox2[i].Name = "comboBox_e_i" + (i + 1).ToString();
                comboBox2[i].Items.Add("Expense");
                comboBox2[i].Items.Add("Income");
                this.Controls.Add(comboBox2[i]);


                /*radioButton1[i] = new RadioButton();
                radioButton1[i].Location = new System.Drawing.Point(110, 255 + i * 200);
                radioButton1[i].Name = "expense";
                radioButton1[i].Text = "Expense";
                radioButton1[i].Size = new System.Drawing.Size(74, 21);
                this.Controls.Add(radioButton1[i]);

                radioButton2[i] = new RadioButton();
                radioButton2[i].Location = new System.Drawing.Point(210, 255 + i * 200);
                radioButton2[i].Name = "income";
                radioButton2[i].Text = "Income";
                radioButton2[i].Size = new System.Drawing.Size(74, 21);
                this.Controls.Add(radioButton2[i]);*/

                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.RoyalBlue;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.MidnightBlue;
                btn.Location = new System.Drawing.Point(205, 285 + (txt1.Length-1) * 200);
                btn.Name = "save";
                btn.Size = new System.Drawing.Size(150, 40);
                btn.TabIndex = 30;
                btn.Text = "Save";
                btn.UseVisualStyleBackColor = false;
                btn.Click += new System.EventHandler(this.SaveEntries);
                this.Controls.Add(btn);
            }

            
        }

        private void SaveEntries(object sender, EventArgs e)
        {

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    
                    if (CEI.IsEmpty(txt.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {

                            if (txt.Name == "txt_amount" + (i + 1))
                            {
                                amount.Add(txt.Text);
                            }
                            else if (txt.Name == "txt_reason" + (i + 1))
                            {
                                reason.Add(txt.Text);

                            }

                        }
                    }
                    txt.Clear();
                
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dp = (DateTimePicker)c;

                    if (CEI.IsEmpty(dp.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {

                            if (dp.Name == "dateTimePicker" + (i + 1))
                            {
                                date.Add(dp.Text);
                            }

                        }
                    }
                    dp.ResetText();
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    if (CEI.IsEmpty(cb.Text)){

                        error = true;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {

                            if (cb.Name == "comboBox_p_p" + (i + 1))
                            {
                                var text = (int)Char.GetNumericValue(cb.Text[0]);
                                payeepayer.Add(text.ToString());
                            }
                            else if (cb.Name == "comboBox_e_i" + (i + 1))
                            {
                                expenseIncome.Add(cb.Text);
                            }

                        }
                    }

                    cb.SelectedIndex=-1;
                }

            }
            if (error)
            {
                MessageBox.Show("Some Fields are Empty !!!");
            }
            else
            {
                for (int i = 0; i < amount.Count; i++)
                {
                    List<string> temp = new List<string>();
                    temp.Add(amount[i]);
                    temp.Add(reason[i]);
                    temp.Add(date[i]);
                    temp.Add(payeepayer[i]);
                    temp.Add(expenseIncome[i]);

                    data.Add(temp);

                }

                CEI.CreateExpenseOrIncome(data);
            }


            //(int)Char.GetNumericValue()

            //Console.WriteLine(Int32.Parse(Convert.ToString (data[0][3][0])));
            // Console.WriteLine((int)Char.GetNumericValue(data[0][3][0]));
            /*for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine("test[" + i + "] = {0}", string.Join(", ", data[i][3]));
            }*/
        }
    }
}
