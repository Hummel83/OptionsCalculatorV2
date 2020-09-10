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
        
