using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptionsCalculatorV2.BlackScholes;

namespace OptionsCalculatorV2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            
            double underlyingPrice = double.Parse(underlyingPriceInput.Text);
            double strikePrice = double.Parse(strikePriceInput.Text);
            double DTE = double.Parse(dteInput.Text);
            double historicalVolatility = double.Parse(historicalVolatilityInput.Text);
            double riskFreeRate = double.Parse(riskFreeRateInput.Text);
            double dividendYield = double.Parse(dividendYieldInput.Text);
            
            BlackScholes.BlackScholes blackScholes = new BlackScholes.BlackScholes(underlyingPrice, strikePrice, DTE, riskFreeRate, historicalVolatility, dividendYield);

            double showFromMin = double.Parse(diagramMinPriceInput.Text);
            double showFromMax = double.Parse(diagramMaxPriceInput.Text);
            
            for (int price = (int)showFromMin; price < showFromMax; price++)
            {
                chart1.Series[0].Points.AddXY(price, blackScholes.getDelta(price));
            }
            
        }
  }
}
