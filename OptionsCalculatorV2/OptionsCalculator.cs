using System.Runtime.CompilerServices;

namespace OptionsCalculatorV2
{
    public class OptionsCalculator
    {
        #region singleton

        private static OptionsCalculator instance;

        public static OptionsCalculator getInstance()
        {
            if (instance == null)
                instance = new OptionsCalculator();

            return instance;
        }

        #endregion singleton

        public double underlyingPrice { get; private set; }
        public double strikePrice { get; private set; }
        public double DTE { get; private set; }
        public double YTE => this.DTE / 365;
        public double historicalVolatility { get; private set; }
        public double riskFreeRate { get; private set; }
        public double dividendYield { get; private set; }
        public double ratio { get; private set; }
        
        public double bidPrice { get; private set; }

        public void onNewCalculation(string underlyingPrice, string strikePrice, string DTE, string historicalVolatility, string riskFreeRate, string dividendYield, string ratio, string bidPrice)
        {
            convertAndSetValues();

            void convertAndSetValues()
            {
                this.ratio = double.Parse(ratio);
                this.underlyingPrice = double.Parse(underlyingPrice);
                this.strikePrice = double.Parse(strikePrice);
                this.DTE = double.Parse(DTE);
                this.historicalVolatility = double.Parse(historicalVolatility) / 100;
                this.riskFreeRate = double.Parse(riskFreeRate) / 100;
                this.dividendYield = double.Parse(dividendYield) / 100;
                this.bidPrice = double.Parse(bidPrice);
            }
        }

        public double getDelta(double underlyingPrice = 0)
        {
            if (underlyingPrice == 0) underlyingPrice = this.underlyingPrice;

            double delta = BlackScholes.BlackScholes.getDelta(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);

            return delta;
        }

        public double getGamma(double underlyingPrice = 0)
        {
            if (underlyingPrice == 0) underlyingPrice = this.underlyingPrice;

            double gamma = BlackScholes.BlackScholes.getGamma(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);

            return gamma;
        }

        public double getTheta(double underlyingPrice = 0, double daysLeft = 0)
        {
            if (underlyingPrice == 0) underlyingPrice = this.underlyingPrice;
            if (daysLeft == 0) daysLeft = this.DTE;

            double theta = BlackScholes.BlackScholes.getTheta(underlyingPrice, strikePrice, daysLeft / 365, riskFreeRate, historicalVolatility, dividendYield);

            return theta * ratio;
        }
        
        public double getOmega(double underlyingPrice = 0)
        {
            if (underlyingPrice == 0) underlyingPrice = this.underlyingPrice;

            double omega = BlackScholes.BlackScholes.getOmega(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);

            return omega; //omegalul
        }

        public double getIV(double bidPrice = 0)
        {
            if (bidPrice == 0) bidPrice = this.bidPrice;

            double impliedVolatility = BlackScholes.BlackScholes.getIV(underlyingPrice, strikePrice, YTE, riskFreeRate, bidPrice, dividendYield);

            return impliedVolatility;
        }
        
        public double getCallPrice()
        {
            double callPrice = BlackScholes.BlackScholes.getCallPrice(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);

            return callPrice * ratio;
        }
    }
}