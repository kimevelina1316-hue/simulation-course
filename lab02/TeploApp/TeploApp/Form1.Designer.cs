namespace TeploApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.txtTa = new System.Windows.Forms.TextBox();
            this.txtTn = new System.Windows.Forms.TextBox();
            this.txtRho = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.lblT0 = new System.Windows.Forms.Label();
            this.lblTa = new System.Windows.Forms.Label();
            this.lblTn = new System.Windows.Forms.Label();
            this.lblRho = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblLambda = new System.Windows.Forms.Label();
            this.cboTimeStep = new System.Windows.Forms.ComboBox();
            this.cboSpaceStep = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCenterTemp = new System.Windows.Forms.Label();
            this.lblCalcTime = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(152, 12);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 26);
            this.txtL.TabIndex = 0;
            this.txtL.Text = "1.0";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(152, 48);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(100, 26);
            this.txtT0.TabIndex = 1;
            this.txtT0.Text = "0.0";
            // 
            // txtTa
            // 
            this.txtTa.Location = new System.Drawing.Point(152, 79);
            this.txtTa.Name = "txtTa";
            this.txtTa.Size = new System.Drawing.Size(100, 26);
            this.txtTa.TabIndex = 2;
            this.txtTa.Text = "100.0";
            // 
            // txtTn
            // 
            this.txtTn.Location = new System.Drawing.Point(152, 111);
            this.txtTn.Name = "txtTn";
            this.txtTn.Size = new System.Drawing.Size(100, 26);
            this.txtTn.TabIndex = 3;
            this.txtTn.Text = "0.0";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(152, 144);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(100, 26);
            this.txtRho.TabIndex = 4;
            this.txtRho.Text = "1.0";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(152, 176);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 26);
            this.txtC.TabIndex = 5;
            this.txtC.Text = "1.0";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(152, 208);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 26);
            this.txtLambda.TabIndex = 6;
            this.txtLambda.Text = "1.0";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblL.Location = new System.Drawing.Point(91, 13);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(55, 22);
            this.lblL.TabIndex = 7;
            this.lblL.Text = "L(м) :";
            // 
            // lblT0
            // 
            this.lblT0.AutoSize = true;
            this.lblT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblT0.Location = new System.Drawing.Point(67, 49);
            this.lblT0.Name = "lblT0";
            this.lblT0.Size = new System.Drawing.Size(80, 22);
            this.lblT0.TabIndex = 8;
            this.lblT0.Text = "T₀  (°C) :";
            // 
            // lblTa
            // 
            this.lblTa.AutoSize = true;
            this.lblTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTa.Location = new System.Drawing.Point(67, 80);
            this.lblTa.Name = "lblTa";
            this.lblTa.Size = new System.Drawing.Size(76, 22);
            this.lblTa.TabIndex = 9;
            this.lblTa.Text = "Tₐ (°C) :";
            // 
            // lblTn
            // 
            this.lblTn.AutoSize = true;
            this.lblTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTn.Location = new System.Drawing.Point(67, 111);
            this.lblTn.Name = "lblTn";
            this.lblTn.Size = new System.Drawing.Size(76, 22);
            this.lblTn.TabIndex = 10;
            this.lblTn.Text = "Tₙ (°C) :";
            // 
            // lblRho
            // 
            this.lblRho.AutoSize = true;
            this.lblRho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRho.Location = new System.Drawing.Point(46, 144);
            this.lblRho.Name = "lblRho";
            this.lblRho.Size = new System.Drawing.Size(100, 22);
            this.lblRho.TabIndex = 11;
            this.lblRho.Text = "ρ (кг/m^3) :";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblC.Location = new System.Drawing.Point(32, 176);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(114, 22);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "c (Дж/кг*K) :";
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLambda.Location = new System.Drawing.Point(43, 208);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(103, 22);
            this.lblLambda.TabIndex = 13;
            this.lblLambda.Text = "λ (Вт/м*К) :";
            // 
            // cboTimeStep
            // 
            this.cboTimeStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeStep.FormattingEnabled = true;
            this.cboTimeStep.Location = new System.Drawing.Point(474, 111);
            this.cboTimeStep.Name = "cboTimeStep";
            this.cboTimeStep.Size = new System.Drawing.Size(121, 28);
            this.cboTimeStep.TabIndex = 14;
            // 
            // cboSpaceStep
            // 
            this.cboSpaceStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpaceStep.FormattingEnabled = true;
            this.cboSpaceStep.Location = new System.Drawing.Point(474, 145);
            this.cboSpaceStep.Name = "cboSpaceStep";
            this.cboSpaceStep.Size = new System.Drawing.Size(121, 28);
            this.cboSpaceStep.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(655, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chartTemperature
            // 
            chartArea1.AxisX.Title = "x (м)";
            chartArea1.AxisY.Title = "T (°C)";
            chartArea1.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend1);
            this.chartTemperature.Location = new System.Drawing.Point(12, 256);
            this.chartTemperature.Name = "chartTemperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Size = new System.Drawing.Size(807, 488);
            this.chartTemperature.TabIndex = 17;
            this.chartTemperature.Text = "chart1";
            // 
            // lblCenterTemp
            // 
            this.lblCenterTemp.AutoSize = true;
            this.lblCenterTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCenterTemp.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCenterTemp.Location = new System.Drawing.Point(310, 13);
            this.lblCenterTemp.Name = "lblCenterTemp";
            this.lblCenterTemp.Size = new System.Drawing.Size(285, 25);
            this.lblCenterTemp.TabIndex = 18;
            this.lblCenterTemp.Text = "Температура в центре: --- °C";
            // 
            // lblCalcTime
            // 
            this.lblCalcTime.AutoSize = true;
            this.lblCalcTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCalcTime.Location = new System.Drawing.Point(338, 49);
            this.lblCalcTime.Name = "lblCalcTime";
            this.lblCalcTime.Size = new System.Drawing.Size(218, 25);
            this.lblCalcTime.TabIndex = 19;
            this.lblCalcTime.Text = "Время расчета: --- мс";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(485, 179);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(100, 26);
            this.txtTotalTime.TabIndex = 20;
            this.txtTotalTime.Text = "2.0";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(275, 182);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(204, 20);
            this.lblTotalTime.TabIndex = 21;
            this.lblTotalTime.Text = "Время моделирования, с:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Шаг по пространству, м";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Шаг по времени, с";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(655, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 35);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 756);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.lblCalcTime);
            this.Controls.Add(this.lblCenterTemp);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cboSpaceStep);
            this.Controls.Add(this.cboTimeStep);
            this.Controls.Add(this.lblLambda);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblRho);
            this.Controls.Add(this.lblTn);
            this.Controls.Add(this.lblTa);
            this.Controls.Add(this.lblT0);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtRho);
            this.Controls.Add(this.txtTn);
            this.Controls.Add(this.txtTa);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.txtL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.TextBox txtTa;
        private System.Windows.Forms.TextBox txtTn;
        private System.Windows.Forms.TextBox txtRho;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblT0;
        private System.Windows.Forms.Label lblTa;
        private System.Windows.Forms.Label lblTn;
        private System.Windows.Forms.Label lblRho;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.ComboBox cboTimeStep;
        private System.Windows.Forms.ComboBox cboSpaceStep;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Label lblCenterTemp;
        private System.Windows.Forms.Label lblCalcTime;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}

