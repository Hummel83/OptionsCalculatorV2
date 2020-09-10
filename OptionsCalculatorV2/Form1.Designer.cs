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
      ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.Color.DimGray;
      chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
      chartArea1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(12, 256);
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
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(351, 182);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 9);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(81, 13);
      this.label7.TabIndex = 1;
      this.label7.Text = "UnderlyingPrice";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 113);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(78, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "Risk-Free-Rate";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(12, 139);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(75, 13);
      this.label9.TabIndex = 3;
      this.label9.Text = "Dividend-Yield";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(12, 87);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(91, 13);
      this.label10.TabIndex = 4;
      this.label10.Text = "Historical Volatility";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(12, 61);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(29, 13);
      this.label11.TabIndex = 5;
      this.label11.Text = "DTE";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(12, 35);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(61, 13);
      this.label12.TabIndex = 6;
      this.label12.Text = "Strike-Price";
      // 
      // underlyingPriceInput
      // 
      this.underlyingPriceInput.Location = new System.Drawing.Point(114, 6);
      this.underlyingPriceInput.Name = "underlyingPriceInput";
      this.underlyingPriceInput.Size = new System.Drawing.Size(156, 20);
      this.underlyingPriceInput.TabIndex = 7;
      // 
      // strikePriceInput
      // 
      this.strikePriceInput.Location = new System.Drawing.Point(114, 32);
      this.strikePriceInput.Name = "strikePriceInput";
      this.strikePriceInput.Size = new System.Drawing.Size(156, 20);
      this.strikePriceInput.TabIndex = 8;
      // 
      // dteInput
      // 
      this.dteInput.Location = new System.Drawing.Point(114, 58);
      this.dteInput.Name = "dteInput";
      this.dteInput.Size = new System.Drawing.Size(156, 20);
      this.dteInput.TabIndex = 9;
      // 
      // historicalVolatilityInput
      // 
      this.historicalVolatilityInput.Location = new System.Drawing.Point(114, 84);
      this.historicalVolatilityInput.Name = "historicalVolatilityInput";
      this.historicalVolatilityInput.Size = new System.Drawing.Size(156, 20);
      this.historicalVolatilityInput.TabIndex = 10;
      // 
      // riskFreeRateInput
      // 
      this.riskFreeRateInput.Location = new System.Drawing.Point(114, 110);
      this.riskFreeRateInput.Name = "riskFreeRateInput";
      this.riskFreeRateInput.Size = new System.Drawing.Size(156, 20);
      this.riskFreeRateInput.TabIndex = 11;
      this.riskFreeRateInput.Text = "0,5";
      // 
      // dividendYieldInput
      // 
      this.dividendYieldInput.Location = new System.Drawing.Point(114, 136);
      this.dividendYieldInput.Name = "dividendYieldInput";
      this.dividendYieldInput.Size = new System.Drawing.Size(156, 20);
      this.dividendYieldInput.TabIndex = 12;
      this.dividendYieldInput.Text = "0";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 169);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(257, 27);
      this.button1.TabIndex = 13;
      this.button1.Text = "Calculate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 231);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Show from ";
      // 
      // diagramMinPriceInput
      // 
      this.diagramMinPriceInput.Location = new System.Drawing.Point(78, 228);
      this.diagramMinPriceInput.Name = "diagramMinPriceInput";
      this.diagramMinPriceInput.Size = new System.Drawing.Size(56, 20);
      this.diagramMinPriceInput.TabIndex = 15;
      // 
      // diagramMaxPriceInput
      // 
      this.diagramMaxPriceInput.Location = new System.Drawing.Point(156, 228);
      this.diagramMaxPriceInput.Name = "diagramMaxPriceInput";
      this.diagramMaxPriceInput.Size = new System.Drawing.Size(56, 20);
      this.diagramMaxPriceInput.TabIndex = 16;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(140, 231);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 13);
      this.label2.TabIndex = 17;
      this.label2.Text = "-\r\n";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
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
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox riskFreeRateInput;
    private System.Windows.Forms.TextBox strikePriceInput;
    private System.Windows.Forms.TextBox underlyingPriceInput;

    #endregion
  }
}

