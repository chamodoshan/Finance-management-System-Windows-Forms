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
    public partial class PredictionView : Form
    {
        public PredictionView()
        {
            InitializeComponent();
        }

        private void Calculation(object sender, EventArgs e)
        {
            string date = dateTimePicker_predict.Text;

            DisplayPredictionViewController DP = new DisplayPredictionViewController();
            DP.CalculatePrediction(date);
        }
    }
}
