using System;

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
        
        /// <param name="underlyingPrice">Default is used if no param is given</param>
        /// <returns></returns>
        public double getDelta(double underlyingPrice = 0)
        {
            double delta = NormSDist.N(calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield));

            return delta;
        }
    }
}