using System;
using System.Windows.Forms.VisualStyles;

namespace OptionsCalculatorV2.BlackScholes
{
    public class BlackScholes
    {
        /// <param name="YTE">MUST BE IN YEARS!!!</param>
        private static double calculateDOne(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double dOne = (Math.Log(underlyingPrice / strikePrice) + (riskFreeRate - dividendYield + 0.5 * Math.Pow(historicalVolatility, 2)) * YTE) / (historicalVolatility * Math.Sqrt(YTE));

            return dOne;
        }

        private static double calculateNdOne(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double dOne = calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);
            
            double NdOne = Math.Exp(-(Math.Pow(dOne, 2) / 2)) / (Math.Sqrt(2 * Math.PI));

            return NdOne;
        }

        private static double calculateDTwo(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double DOne = calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield) - historicalVolatility * Math.Sqrt(YTE);

            return DOne;
        }

        private static double calculateNdTwo(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double NdTwo = NormSDist.N(calculateDTwo(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield));

            return NdTwo;
        }
        
        public static double getDelta(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double delta = NormSDist.N(calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield));

            return delta;
        }

        public static double getGamma(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double gamma = calculateNdOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);

            return gamma;
        }

        public static double getTheta(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double ndOne = calculateNdOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);
            double ndTwo = calculateNdTwo(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield);
            
            double theta = -(underlyingPrice * historicalVolatility * ndOne) / (2 * Math.Sqrt(YTE)) - riskFreeRate * strikePrice * Math.Pow(-riskFreeRate * (YTE), 2) * ndTwo;

            return theta / 365;
        }

        public static double getCallPrice(double underlyingPrice, double strikePrice, double YTE, double riskFreeRate, double historicalVolatility, double dividendYield)
        {
            double callOption = Math.Exp(-dividendYield * YTE) * underlyingPrice * NormSDist.N(calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield)) - strikePrice * Math.Exp(-riskFreeRate * YTE) *
                NormSDist.N(calculateDOne(underlyingPrice, strikePrice, YTE, riskFreeRate, historicalVolatility, dividendYield) - historicalVolatility * Math.Sqrt(YTE));

            return callOption;
        }
    }
}