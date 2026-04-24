namespace _6_лабораторная
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDiscrete = new System.Windows.Forms.TabPage();
            this.chartNormal = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxProb1 = new System.Windows.Forms.TextBox();
            this.labelProb1 = new System.Windows.Forms.Label();
            this.labelProb2 = new System.Windows.Forms.Label();
            this.textBoxProb2 = new System.Windows.Forms.TextBox();
            this.labelProb3 = new System.Windows.Forms.Label();
            this.textBoxProb3 = new System.Windows.Forms.TextBox();
            this.textBoxProb4 = new System.Windows.Forms.TextBox();
            this.textBoxProb5 = new System.Windows.Forms.TextBox();
            this.labelProb4 = new System.Windows.Forms.Label();
            this.labelProb5 = new System.Windows.Forms.Label();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.labelExperiments = new System.Windows.Forms.Label();
            this.textBoxExperiments = new System.Windows.Forms.TextBox();
            this.buttonStartDiscrete = new System.Windows.Forms.Button();
            this.chartDiscrete = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResultsDiscrete = new System.Windows.Forms.TextBox();
            this.labelNormalTitle = new System.Windows.Forms.Label();
            this.labelMean = new System.Windows.Forms.Label();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.textBoxVariance = new System.Windows.Forms.TextBox();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelSampleSize = new System.Windows.Forms.Label();
            this.textBoxSampleSize = new System.Windows.Forms.TextBox();
            this.buttonStartNormal = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResultsNormal = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabDiscrete.SuspendLayout();
            this.chartNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiscrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDiscrete);
            this.tabControl.Controls.Add(this.chartNormal);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1619, 1021);
            this.tabControl.TabIndex = 0;
            // 
            // tabDiscrete
            // 
            this.tabDiscrete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabDiscrete.Controls.Add(this.textBoxResultsDiscrete);
            this.tabDiscrete.Controls.Add(this.chartDiscrete);
            this.tabDiscrete.Controls.Add(this.buttonStartDiscrete);
            this.tabDiscrete.Controls.Add(this.textBoxExperiments);
            this.tabDiscrete.Controls.Add(this.labelExperiments);
            this.tabDiscrete.Controls.Add(this.buttonAuto);
            this.tabDiscrete.Controls.Add(this.labelProb5);
            this.tabDiscrete.Controls.Add(this.labelProb4);
            this.tabDiscrete.Controls.Add(this.textBoxProb5);
            this.tabDiscrete.Controls.Add(this.textBoxProb4);
            this.tabDiscrete.Controls.Add(this.textBoxProb3);
            this.tabDiscrete.Controls.Add(this.labelProb3);
            this.tabDiscrete.Controls.Add(this.textBoxProb2);
            this.tabDiscrete.Controls.Add(this.labelProb2);
            this.tabDiscrete.Controls.Add(this.labelProb1);
            this.tabDiscrete.Controls.Add(this.textBoxProb1);
            this.tabDiscrete.Controls.Add(this.labelTitle);
            this.tabDiscrete.Location = new System.Drawing.Point(4, 29);
            this.tabDiscrete.Name = "tabDiscrete";
            this.tabDiscrete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscrete.Size = new System.Drawing.Size(1611, 988);
            this.tabDiscrete.TabIndex = 0;
            this.tabDiscrete.Text = "Lab 6.1 - Дискретное распределение";
            // 
            // chartNormal
            // 
            this.chartNormal.BackColor = System.Drawing.Color.MediumPurple;
            this.chartNormal.Controls.Add(this.textBoxResultsNormal);
            this.chartNormal.Controls.Add(this.chart1);
            this.chartNormal.Controls.Add(this.buttonStartNormal);
            this.chartNormal.Controls.Add(this.textBoxSampleSize);
            this.chartNormal.Controls.Add(this.labelSampleSize);
            this.chartNormal.Controls.Add(this.labelVariance);
            this.chartNormal.Controls.Add(this.textBoxVariance);
            this.chartNormal.Controls.Add(this.textBoxMean);
            this.chartNormal.Controls.Add(this.labelMean);
            this.chartNormal.Controls.Add(this.labelNormalTitle);
            this.chartNormal.Location = new System.Drawing.Point(4, 29);
            this.chartNormal.Name = "chartNormal";
            this.chartNormal.Padding = new System.Windows.Forms.Padding(3);
            this.chartNormal.Size = new System.Drawing.Size(1611, 988);
            this.chartNormal.TabIndex = 1;
            this.chartNormal.Text = "Lab 6.2 - Нормальное распределение";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(20, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(437, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Введите вероятности (сумма = 1):";
            // 
            // textBoxProb1
            // 
            this.textBoxProb1.Location = new System.Drawing.Point(202, 103);
            this.textBoxProb1.Name = "textBoxProb1";
            this.textBoxProb1.Size = new System.Drawing.Size(80, 26);
            this.textBoxProb1.TabIndex = 1;
            this.textBoxProb1.Text = "0.2";
            // 
            // labelProb1
            // 
            this.labelProb1.AutoSize = true;
            this.labelProb1.Location = new System.Drawing.Point(142, 106);
            this.labelProb1.Name = "labelProb1";
            this.labelProb1.Size = new System.Drawing.Size(62, 20);
            this.labelProb1.TabIndex = 2;
            this.labelProb1.Text = "P(X=1):";
            // 
            // labelProb2
            // 
            this.labelProb2.AutoSize = true;
            this.labelProb2.Location = new System.Drawing.Point(138, 136);
            this.labelProb2.Name = "labelProb2";
            this.labelProb2.Size = new System.Drawing.Size(66, 20);
            this.labelProb2.TabIndex = 3;
            this.labelProb2.Text = " P(X=2):";
            // 
            // textBoxProb2
            // 
            this.textBoxProb2.Location = new System.Drawing.Point(202, 133);
            this.textBoxProb2.Name = "textBoxProb2";
            this.textBoxProb2.Size = new System.Drawing.Size(80, 26);
            this.textBoxProb2.TabIndex = 4;
            this.textBoxProb2.Text = "0.2";
            // 
            // labelProb3
            // 
            this.labelProb3.AutoSize = true;
            this.labelProb3.Location = new System.Drawing.Point(142, 166);
            this.labelProb3.Name = "labelProb3";
            this.labelProb3.Size = new System.Drawing.Size(62, 20);
            this.labelProb3.TabIndex = 5;
            this.labelProb3.Text = "P(X=3):";
            // 
            // textBoxProb3
            // 
            this.textBoxProb3.Location = new System.Drawing.Point(202, 163);
            this.textBoxProb3.Name = "textBoxProb3";
            this.textBoxProb3.Size = new System.Drawing.Size(80, 26);
            this.textBoxProb3.TabIndex = 6;
            this.textBoxProb3.Text = "0.2";
            // 
            // textBoxProb4
            // 
            this.textBoxProb4.Location = new System.Drawing.Point(202, 193);
            this.textBoxProb4.Name = "textBoxProb4";
            this.textBoxProb4.Size = new System.Drawing.Size(80, 26);
            this.textBoxProb4.TabIndex = 7;
            this.textBoxProb4.Text = "0.2";
            // 
            // textBoxProb5
            // 
            this.textBoxProb5.Location = new System.Drawing.Point(202, 223);
            this.textBoxProb5.Name = "textBoxProb5";
            this.textBoxProb5.Size = new System.Drawing.Size(80, 26);
            this.textBoxProb5.TabIndex = 8;
            this.textBoxProb5.Text = "0.2";
            // 
            // labelProb4
            // 
            this.labelProb4.AutoSize = true;
            this.labelProb4.Location = new System.Drawing.Point(142, 196);
            this.labelProb4.Name = "labelProb4";
            this.labelProb4.Size = new System.Drawing.Size(62, 20);
            this.labelProb4.TabIndex = 9;
            this.labelProb4.Text = "P(X=4):";
            // 
            // labelProb5
            // 
            this.labelProb5.AutoSize = true;
            this.labelProb5.Location = new System.Drawing.Point(142, 226);
            this.labelProb5.Name = "labelProb5";
            this.labelProb5.Size = new System.Drawing.Size(62, 20);
            this.labelProb5.TabIndex = 10;
            this.labelProb5.Text = "P(X=5):";
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.Yellow;
            this.buttonAuto.Location = new System.Drawing.Point(142, 269);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(140, 30);
            this.buttonAuto.TabIndex = 11;
            this.buttonAuto.Text = "Авто (последняя P)";
            this.buttonAuto.UseVisualStyleBackColor = false;
            // 
            // labelExperiments
            // 
            this.labelExperiments.AutoSize = true;
            this.labelExperiments.Location = new System.Drawing.Point(88, 359);
            this.labelExperiments.Name = "labelExperiments";
            this.labelExperiments.Size = new System.Drawing.Size(250, 20);
            this.labelExperiments.TabIndex = 12;
            this.labelExperiments.Text = "Количество экспериментов (N):";
            // 
            // textBoxExperiments
            // 
            this.textBoxExperiments.Location = new System.Drawing.Point(143, 397);
            this.textBoxExperiments.Name = "textBoxExperiments";
            this.textBoxExperiments.Size = new System.Drawing.Size(140, 26);
            this.textBoxExperiments.TabIndex = 13;
            this.textBoxExperiments.Text = "1000";
            // 
            // buttonStartDiscrete
            // 
            this.buttonStartDiscrete.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStartDiscrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartDiscrete.Location = new System.Drawing.Point(70, 455);
            this.buttonStartDiscrete.Name = "buttonStartDiscrete";
            this.buttonStartDiscrete.Size = new System.Drawing.Size(290, 65);
            this.buttonStartDiscrete.TabIndex = 14;
            this.buttonStartDiscrete.Text = "Запустить моделирование";
            this.buttonStartDiscrete.UseVisualStyleBackColor = false;
            // 
            // chartDiscrete
            // 
            this.chartDiscrete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartDiscrete.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDiscrete.Legends.Add(legend4);
            this.chartDiscrete.Location = new System.Drawing.Point(483, 20);
            this.chartDiscrete.Name = "chartDiscrete";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiscrete.Series.Add(series4);
            this.chartDiscrete.Size = new System.Drawing.Size(950, 465);
            this.chartDiscrete.TabIndex = 15;
            this.chartDiscrete.Text = "chart1";
            // 
            // textBoxResultsDiscrete
            // 
            this.textBoxResultsDiscrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsDiscrete.Location = new System.Drawing.Point(483, 539);
            this.textBoxResultsDiscrete.Multiline = true;
            this.textBoxResultsDiscrete.Name = "textBoxResultsDiscrete";
            this.textBoxResultsDiscrete.ReadOnly = true;
            this.textBoxResultsDiscrete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultsDiscrete.Size = new System.Drawing.Size(950, 389);
            this.textBoxResultsDiscrete.TabIndex = 16;
            // 
            // labelNormalTitle
            // 
            this.labelNormalTitle.AutoSize = true;
            this.labelNormalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormalTitle.Location = new System.Drawing.Point(37, 110);
            this.labelNormalTitle.Name = "labelNormalTitle";
            this.labelNormalTitle.Size = new System.Drawing.Size(538, 29);
            this.labelNormalTitle.TabIndex = 0;
            this.labelNormalTitle.Text = "Параметры нормального распределения:";
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMean.Location = new System.Drawing.Point(138, 236);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(115, 20);
            this.labelMean.TabIndex = 1;
            this.labelMean.Text = "Среднее (μ):";
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(325, 233);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(100, 26);
            this.textBoxMean.TabIndex = 2;
            this.textBoxMean.Text = "0";
            // 
            // textBoxVariance
            // 
            this.textBoxVariance.Location = new System.Drawing.Point(325, 284);
            this.textBoxVariance.Name = "textBoxVariance";
            this.textBoxVariance.Size = new System.Drawing.Size(100, 26);
            this.textBoxVariance.TabIndex = 3;
            this.textBoxVariance.Text = "1";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariance.Location = new System.Drawing.Point(138, 284);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(138, 20);
            this.labelVariance.TabIndex = 4;
            this.labelVariance.Text = "Дисперсия (σ²):";
            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoSize = true;
            this.labelSampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSampleSize.Location = new System.Drawing.Point(119, 332);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(176, 20);
            this.labelSampleSize.TabIndex = 5;
            this.labelSampleSize.Text = "Объём выборки (N):";
            // 
            // textBoxSampleSize
            // 
            this.textBoxSampleSize.Location = new System.Drawing.Point(325, 326);
            this.textBoxSampleSize.Name = "textBoxSampleSize";
            this.textBoxSampleSize.Size = new System.Drawing.Size(100, 26);
            this.textBoxSampleSize.TabIndex = 6;
            this.textBoxSampleSize.Text = "1000";
            // 
            // buttonStartNormal
            // 
            this.buttonStartNormal.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStartNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartNormal.Location = new System.Drawing.Point(100, 433);
            this.buttonStartNormal.Name = "buttonStartNormal";
            this.buttonStartNormal.Size = new System.Drawing.Size(349, 67);
            this.buttonStartNormal.TabIndex = 7;
            this.buttonStartNormal.Text = "Запустить моделирование";
            this.buttonStartNormal.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(608, 32);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(952, 487);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // textBoxResultsNormal
            // 
            this.textBoxResultsNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsNormal.Location = new System.Drawing.Point(608, 552);
            this.textBoxResultsNormal.Multiline = true;
            this.textBoxResultsNormal.Name = "textBoxResultsNormal";
            this.textBoxResultsNormal.ReadOnly = true;
            this.textBoxResultsNormal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultsNormal.Size = new System.Drawing.Size(952, 401);
            this.textBoxResultsNormal.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 1021);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 6";
            this.tabControl.ResumeLayout(false);
            this.tabDiscrete.ResumeLayout(false);
            this.tabDiscrete.PerformLayout();
            this.chartNormal.ResumeLayout(false);
            this.chartNormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiscrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDiscrete;
        private System.Windows.Forms.TabPage chartNormal;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelProb1;
        private System.Windows.Forms.TextBox textBoxProb1;
        private System.Windows.Forms.TextBox textBoxProb3;
        private System.Windows.Forms.Label labelProb3;
        private System.Windows.Forms.TextBox textBoxProb2;
        private System.Windows.Forms.Label labelProb2;
        private System.Windows.Forms.Label labelProb5;
        private System.Windows.Forms.Label labelProb4;
        private System.Windows.Forms.TextBox textBoxProb5;
        private System.Windows.Forms.TextBox textBoxProb4;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.TextBox textBoxExperiments;
        private System.Windows.Forms.Label labelExperiments;
        private System.Windows.Forms.Button buttonStartDiscrete;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiscrete;
        private System.Windows.Forms.TextBox textBoxResultsDiscrete;
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label labelNormalTitle;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.TextBox textBoxVariance;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.Button buttonStartNormal;
        private System.Windows.Forms.TextBox textBoxSampleSize;
        private System.Windows.Forms.Label labelSampleSize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxResultsNormal;
    }
}

