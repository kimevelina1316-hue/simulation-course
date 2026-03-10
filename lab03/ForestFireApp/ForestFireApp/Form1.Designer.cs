using System.Threading;

namespace ForestFireApp
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
            this.components = new System.ComponentModel.Container();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerSim = new System.Windows.Forms.Timer(this.components);
            this.btnIgnite = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxRules = new System.Windows.Forms.GroupBox();
            this.rbAllRules = new System.Windows.Forms.RadioButton();
            this.rbNoRules = new System.Windows.Forms.RadioButton();
            this.rbBarrier = new System.Windows.Forms.RadioButton();
            this.rbLightning = new System.Windows.Forms.RadioButton();
            this.rbWind = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.groupBoxRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGrid
            // 
            this.pbGrid.Location = new System.Drawing.Point(186, 41);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(500, 500);
            this.pbGrid.TabIndex = 0;
            this.pbGrid.TabStop = false;
            this.pbGrid.Click += new System.EventHandler(this.pbGrid_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(774, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(969, 265);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 48);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(969, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 48);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timerSim
            // 
            this.timerSim.Interval = 200;
            // 
            // btnIgnite
            // 
            this.btnIgnite.Location = new System.Drawing.Point(775, 356);
            this.btnIgnite.Name = "btnIgnite";
            this.btnIgnite.Size = new System.Drawing.Size(114, 47);
            this.btnIgnite.TabIndex = 4;
            this.btnIgnite.Text = "Поджечь";
            this.btnIgnite.UseVisualStyleBackColor = true;
            this.btnIgnite.Click += new System.EventHandler(this.btnIgnite_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(26, 41);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(129, 20);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Лесные пожары";
            // 
            // groupBoxRules
            // 
            this.groupBoxRules.Controls.Add(this.rbAllRules);
            this.groupBoxRules.Controls.Add(this.rbNoRules);
            this.groupBoxRules.Controls.Add(this.rbBarrier);
            this.groupBoxRules.Controls.Add(this.rbLightning);
            this.groupBoxRules.Controls.Add(this.rbWind);
            this.groupBoxRules.Location = new System.Drawing.Point(743, 41);
            this.groupBoxRules.Name = "groupBoxRules";
            this.groupBoxRules.Size = new System.Drawing.Size(367, 198);
            this.groupBoxRules.TabIndex = 6;
            this.groupBoxRules.TabStop = false;
            this.groupBoxRules.Text = "Доп.правила";
            // 
            // rbAllRules
            // 
            this.rbAllRules.AutoSize = true;
            this.rbAllRules.Location = new System.Drawing.Point(164, 128);
            this.rbAllRules.Name = "rbAllRules";
            this.rbAllRules.Size = new System.Drawing.Size(130, 24);
            this.rbAllRules.TabIndex = 4;
            this.rbAllRules.TabStop = true;
            this.rbAllRules.Text = "Все правила";
            this.rbAllRules.UseVisualStyleBackColor = true;
            this.rbAllRules.CheckedChanged += new System.EventHandler(this.rbAllRules_CheckedChanged);
            // 
            // rbNoRules
            // 
            this.rbNoRules.AutoSize = true;
            this.rbNoRules.Location = new System.Drawing.Point(164, 75);
            this.rbNoRules.Name = "rbNoRules";
            this.rbNoRules.Size = new System.Drawing.Size(121, 24);
            this.rbNoRules.TabIndex = 3;
            this.rbNoRules.TabStop = true;
            this.rbNoRules.Text = "Без правил";
            this.rbNoRules.UseVisualStyleBackColor = true;
            this.rbNoRules.CheckedChanged += new System.EventHandler(this.rbNoRules_CheckedChanged);
            // 
            // rbBarrier
            // 
            this.rbBarrier.AutoSize = true;
            this.rbBarrier.Location = new System.Drawing.Point(38, 149);
            this.rbBarrier.Name = "rbBarrier";
            this.rbBarrier.Size = new System.Drawing.Size(70, 24);
            this.rbBarrier.TabIndex = 2;
            this.rbBarrier.TabStop = true;
            this.rbBarrier.Text = "Река";
            this.rbBarrier.UseVisualStyleBackColor = true;
            this.rbBarrier.CheckedChanged += new System.EventHandler(this.rbBarrier_CheckedChanged);
            // 
            // rbLightning
            // 
            this.rbLightning.AutoSize = true;
            this.rbLightning.Location = new System.Drawing.Point(32, 98);
            this.rbLightning.Name = "rbLightning";
            this.rbLightning.Size = new System.Drawing.Size(93, 24);
            this.rbLightning.TabIndex = 1;
            this.rbLightning.TabStop = true;
            this.rbLightning.Text = "Молнии";
            this.rbLightning.UseVisualStyleBackColor = true;
            this.rbLightning.CheckedChanged += new System.EventHandler(this.rbLightning_CheckedChanged);
            // 
            // rbWind
            // 
            this.rbWind.AutoSize = true;
            this.rbWind.Location = new System.Drawing.Point(31, 50);
            this.rbWind.Name = "rbWind";
            this.rbWind.Size = new System.Drawing.Size(81, 24);
            this.rbWind.TabIndex = 0;
            this.rbWind.TabStop = true;
            this.rbWind.Text = "Ветер";
            this.rbWind.UseVisualStyleBackColor = true;
            this.rbWind.CheckedChanged += new System.EventHandler(this.rbWind_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1143, 593);
            this.Controls.Add(this.groupBoxRules);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnIgnite);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.groupBoxRules.ResumeLayout(false);
            this.groupBoxRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timerSim;
        private System.Windows.Forms.Button btnIgnite;
        private System.Windows.Forms.Label lblInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxRules;
        private System.Windows.Forms.RadioButton rbLightning;
        private System.Windows.Forms.RadioButton rbWind;
        private System.Windows.Forms.RadioButton rbAllRules;
        private System.Windows.Forms.RadioButton rbNoRules;
        private System.Windows.Forms.RadioButton rbBarrier;

    }
}

