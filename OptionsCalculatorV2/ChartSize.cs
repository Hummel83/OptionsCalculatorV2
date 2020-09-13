namespace OptionsCalculatorV2
{
    public class ChartSize
    {
        public double chartStart { get; }
        public double chartEnd { get; }

        public ChartSize(double chartStart, double chartEnd)
        {
            this.chartStart = chartStart;
            this.chartEnd = chartEnd;
        }
    }
}