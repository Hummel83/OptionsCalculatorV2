namespace OptionsCalculatorV2
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.underlyingPriceInput = new System.Windows.Forms.TextBox();
      this.strikePriceInput = new System.Windows.Forms.TextBox();
      this.dteInput = new System.Windows.Forms.TextBox();
      this.historicalVolatilityInput = new System.Windows.Forms.TextBox();
      this.riskFreeRateInput = new System.Windows.Forms.TextBox();
      this.dividendYieldInput = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.diagramMinPriceInput = new System.Windows.Forms.TextBox();
      this.diagramMaxPriceInput = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.thetaDecay = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label3 = new System.Windows.Forms.Label();
      this.ratioInput = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.thetaDecay)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.Color.DimGray;
      chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
      chartArea1.AxisX.Title = "Underlying-Price";
      chartArea1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(12, 288);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Color = System.Drawing.Color.Gold;
      series1.Legend = "Legend1";
      series1.Name = "gamma";
      series2.BorderWidth = 5;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series2.Color = System.Drawing.Color.Aqua;
      series2.Legend = "Legend1";
      series2.Name = "delta";
      series2.ShadowColor = System.Drawing.Color.Black;
      series2.ShadowOffset = 3;
      series3.BorderWidth = 3;
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series3.Color = System.Drawing.Color.DarkRed;
      series3.Legend = "Legend1";
      series3.Name = "theta";
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Series.Add(series3);
      this.chart1.Size = new System.Drawing.Size(351, 182);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label7.Location = new System.Drawing.Point(12, 13);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(96, 16);
      this.label7.TabIndex = 1;
      this.label7.Text = "UnderlyingPrice";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label8.Location = new System.Drawing.Point(12, 117);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(93, 16);
      this.label8.TabIndex = 2;
      this.label8.Text = "Risk-Free-Rate";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label9.Location = new System.Drawing.Point(12, 143);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(88, 16);
      this.label9.TabIndex = 3;
      this.label9.Text = "Dividend-Yield";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label10.Location = new System.Drawing.Point(12, 91);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(112, 16);
      this.label10.TabIndex = 4;
      this.label10.Text = "Historical Volatility";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label11.Location = new System.Drawing.Point(12, 65);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(31, 16);
      this.label11.TabIndex = 5;
      this.label11.Text = "DTE";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label12.Location = new System.Drawing.Point(12, 39);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(74, 16);
      this.label12.TabIndex = 6;
      this.label12.Text = "Strike-Price";
      // 
      // underlyingPriceInput
      // 
      this.underlyingPriceInput.Location = new System.Drawing.Point(130, 12);
      this.underlyingPriceInput.Name = "underlyingPriceInput";
      this.underlyingPriceInput.Size = new System.Drawing.Size(156, 20);
      this.underlyingPriceInput.TabIndex = 7;
      // 
      // strikePriceInput
      // 
      this.strikePriceInput.Location = new System.Drawing.Point(130, 38);
      this.strikePriceInput.Name = "strikePriceInput";
      this.strikePriceInput.Size = new System.Drawing.Size(156, 20);
      this.strikePriceInput.TabIndex = 8;
      // 
      // dteInput
      // 
      this.dteInput.Location = new System.Drawing.Point(130, 64);
      this.dteInput.Name = "dteInput";
      this.dteInput.Size = new System.Drawing.Size(156, 20);
      this.dteInput.TabIndex = 9;
      // 
      // historicalVolatilityInput
      // 
      this.historicalVolatilityInput.Location = new System.Drawing.Point(130, 90);
      this.historicalVolatilityInput.Name = "historicalVolatilityInput";
      this.historicalVolatilityInput.Size = new System.Drawing.Size(156, 20);
      this.historicalVolatilityInput.TabIndex = 10;
      // 
      // riskFreeRateInput
      // 
      this.riskFreeRateInput.Location = new System.Drawing.Point(130, 116);
      this.riskFreeRateInput.Name = "riskFreeRateInput";
      this.riskFreeRateInput.Size = new System.Drawing.Size(156, 20);
      this.riskFreeRateInput.TabIndex = 11;
      this.riskFreeRateInput.Text = "0,5";
      // 
      // dividendYieldInput
      // 
      this.dividendYieldInput.Location = new System.Drawing.Point(130, 142);
      this.dividendYieldInput.Name = "dividendYieldInput";
      this.dividendYieldInput.Size = new System.Drawing.Size(156, 20);
      this.dividendYieldInput.TabIndex = 12;
      this.dividendYieldInput.Text = "0";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 194);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(274, 27);
      this.button1.TabIndex = 13;
      this.button1.Text = "Calculate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label1.Location = new System.Drawing.Point(12, 262);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 16);
      this.label1.TabIndex = 14;
      this.label1.Text = "Show from ";
      // 
      // diagramMinPriceInput
      // 
      this.diagramMinPriceInput.Location = new System.Drawing.Point(130, 262);
      this.diagramMinPriceInput.Name = "diagramMinPriceInput";
      this.diagramMinPriceInput.Size = new System.Drawing.Size(67, 20);
      this.diagramMinPriceInput.TabIndex = 15;
      // 
      // diagramMaxPriceInput
      // 
      this.diagramMaxPriceInput.Location = new System.Drawing.Point(219, 262);
      this.diagramMaxPriceInput.Name = "diagramMaxPriceInput";
      this.diagramMaxPriceInput.Size = new System.Drawing.Size(67, 20);
      this.diagramMaxPriceInput.TabIndex = 16;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(203, 265);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 13);
      this.label2.TabIndex = 17;
      this.label2.Text = "-\r\n";
      // 
      // thetaDecay
      // 
      this.thetaDecay.BackColor = System.Drawing.Color.DimGray;
      chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
      chartArea2.AxisX.Title = "Days left";
      chartArea2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
      chartArea2.Name = "ChartArea1";
      this.thetaDecay.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.thetaDecay.Legends.Add(legend2);
      this.thetaDecay.Location = new System.Drawing.Point(377, 288);
      this.thetaDecay.Name = "thetaDecay";
      series4.BorderWidth = 3;
      series4.ChartArea = "ChartArea1";
      series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series4.Color = System.Drawing.Color.Red;
      series4.Legend = "Legend1";
      series4.Name = "optionPrice";
      this.thetaDecay.Series.Add(series4);
      this.thetaDecay.Size = new System.Drawing.Size(351, 182);
      this.thetaDecay.TabIndex = 18;
      this.thetaDecay.Text = "chart2";
      this.thetaDecay.Click += new System.EventHandler(this.thetaDecay_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label3.Location = new System.Drawing.Point(12, 169);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 16);
      this.label3.TabIndex = 19;
      this.label3.Text = "Ratio";
      // 
      // ratioInput
      // 
      this.ratioInput.Location = new System.Drawing.Point(130, 168);
      this.ratioInput.Name = "ratioInput";
      this.ratioInput.Size = new System.Drawing.Size(156, 20);
      this.ratioInput.TabIndex = 20;
      this.ratioInput.Text = "0,1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label4.Location = new System.Drawing.Point(446, 269);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(282, 16);
      this.label4.TabIndex = 21;
      this.label4.Text = "Time-Decay (if underlying price stays the same)";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SlateGray;
      this.ClientSize = new System.Drawing.Size(740, 482);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.ratioInput);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.thetaDecay);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.diagramMaxPriceInput);
      this.Controls.Add(this.diagramMinPriceInput);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dividendYieldInput);
      this.Controls.Add(this.riskFreeRateInput);
      this.Controls.Add(this.historicalVolatilityInput);
      this.Controls.Add(this.dteInput);
      this.Controls.Add(this.strikePriceInput);
      this.Controls.Add(this.underlyingPriceInput);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.chart1);
      this.Name = "Form1";
      this.Text = "Gescheiter Options-Rechner";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.thetaDecay)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.TextBox diagramMaxPriceInput;
    private System.Windows.Forms.TextBox diagramMinPriceInput;
    private System.Windows.Forms.TextBox dividendYieldInput;
    private System.Windows.Forms.TextBox dteInput;
    private System.Windows.Forms.TextBox historicalVolatilityInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox ratioInput;
    private System.Windows.Forms.TextBox riskFreeRateInput;
    private System.Windows.Forms.TextBox strikePriceInput;
    private System.Windows.Forms.DataVisualization.Charting.Chart thetaDecay;
    private System.Windows.Forms.TextBox underlyingPriceInput;

    #endregion
  }
}

