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
using System.Runtime.InteropServices;

namespace OptionsCalculatorV2
{
    public partial class Form1 : Form
    {
        private OptionsCalculator optionsCalculator;
        
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
            AllocConsole();
            this.optionsCalculator = OptionsCalculator.getInstance();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.optionsCalculator.onNewCalculation(underlyingPriceInput.Text, strikePriceInput.Text, dteInput.Text, historicalVolatilityInput.Text, riskFreeRateInput.Text, dividendYieldInput.Text, ratioInput.Text);

            clearCharts();

            drawGreeksChart();

            drawThetaDecayChart();
        }

        private void drawThetaDecayChart()
        {
            double optionPrice = optionsCalculator.getCallPrice();
            
            for (int daysLeft = (int)optionsCalculator.DTE; daysLeft > 0; daysLeft--)
            {
                double theta = optionsCalculator.getTheta(0, (double)daysLeft);

                optionPrice += theta;

                thetaDecay.Series[0].Points.AddXY(-daysLeft, optionPrice);
            }
        }

        private void drawGreeksChart()
        {
            double showFromMinPriceInput = double.Parse(diagramMinPriceInput.Text) * optionsCalculator.ratio;
            double showFromMaxPriceInput = double.Parse(diagramMaxPriceInput.Text) * optionsCalculator.ratio;

            for (int price = (int) showFromMinPriceInput; price < showFromMaxPriceInput; price++)
            {
                double delta = optionsCalculator.getDelta(price);
                double gamma = optionsCalculator.getGamma(price);
                double theta = optionsCalculator.getTheta(price);

                chart1.Series[0].Points.AddXY(price / optionsCalculator.ratio, gamma);
                chart1.Series[1].Points.AddXY(price / optionsCalculator.ratio, delta);
                chart1.Series[2].Points.AddXY(price / optionsCalculator.ratio, theta);

                Console.WriteLine($"Price: {price} / Delta: {delta} / Gamma: {gamma} / Theta: {theta}");
            }
        }

        private void clearCharts()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            
            thetaDecay.Series[0].Points.Clear();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void thetaDecay_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}