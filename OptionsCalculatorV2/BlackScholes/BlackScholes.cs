using System;
using System.Windows.Forms.VisualStyles;

namespace OptionsCalculatorV2.BlackScholes
{
    public class BlackScholes
    {
        public double underlyingPrice { get; }
        public double strikePrice { get; }
        public double DTE { get; }
        
        public double YTE => this.DTE / 365;
        public double riskFreeRate { get; }
        public double historicalVolatility { get; }
        public double dividendYield { get; }

        public BlackScholes(double underlyingPrice, double strikePrice, double dte, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            this.underlyingPrice = underlyingPrice;
            this.strikePrice = strikePrice;
            this.DTE = dte;
            this.riskFreeRate = riskFreeRate / 100;
            this.historicalVolatility = historicalVolatility / 100;
            this.dividendYield = dividendYield / 100;
        }
        
        /// <param name="underlyingPrice"></param>
        /// <param name="strikePrice"></param>
        /// <param name="time">MUST BE IN YEARS!!!</param>
        /// <param name="interest"></param>
        /// <param name="volatility"></param>
        /// <param name="dividend"></param>
        /// <returns></returns>
        private double calculateDOne(double underlyingPrice, double strikePrice, double time, double interest, double volatility, double dividend)
        {
            double dOne = (Math.Log(underlyingPrice / strikePrice) + (interest - dividend + 0.5 * Math.Pow(volatility, 2)) * time) / (volatility * Math.Sqrt(time));

            return dOne;
        }

        private double calculateNdOne(double underlyingPrice, double strikePrice, double time, double interest, double volatility, double dividend)
        {
            double dOne = this.calculateDOne(underlyingPrice, strikePrice, time, interest, volatility, dividend);
            
            double NdOne = Math.Exp(-(Math.Pow(dOne, 2) / 2)) / (Math.Sqrt(2 * Math.PI));

            return NdOne;
        }

        private double calculateDTwo(double underlyingPrice, double strikePrice, double time, double interest, double volatility, double dividend)
        {
            double DOne = this.calculateDOne(underlyingPrice, strikePrice, time, interest, volatility, dividend) - volatility * Math.Sqrt(time);

            return DOne;
        }

        private double calculateNdTwo(double underlyingPrice, double strikePrice, double time, double interest, double volatility, double dividend)
        {
            double NdTwo = NormSDist.N(this.calculateDTwo(underlyingPrice, strikePrice, time, interest, volatility, dividend));

            return NdTwo;
        }
        
        /// <param name="underlyingPrice">Default is used if no param is given</param>
        /// <returns></returns>
        public double getDelta(double underlyingPrice = 0)
        {
            double delta = NormSDist.N(calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield));

            return delta;
        }

        public double getGamma(double underlyingPrice = 0)
        {
            if (underlyingPrice == 0) underlyingPrice = this.underlyingPrice;
            
            double gamma = this.calculateNdOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);

            return gamma;
        }

        public double getTheta(double underlyingPrice = 0, double YTE = 0)
        {
            if (underlyingPrice == 0) underlyingPrice = this.underlyingPrice;
            if (YTE == 0) YTE = this.YTE;
            
            double ndOne = this.calculateNdOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);
            double ndTwo = this.calculateNdTwo(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);
            
            double theta = -(underlyingPrice * historicalVolatility * ndOne) / (2 * Math.Sqrt(YTE)) - riskFreeRate * strikePrice * Math.Pow(-riskFreeRate * (YTE), 2) * ndTwo;

            return theta / 365;
        }
    }
}