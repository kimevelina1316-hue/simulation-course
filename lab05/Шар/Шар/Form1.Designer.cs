namespace Шар
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(559, 74);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(150, 20);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "ЗаДаЙтЕ ВоПрОс:";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(737, 71);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(282, 26);
            this.txtBox1.TabIndex = 2;
            // 
            // buttonAsk
            // 
            this.buttonAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAsk.Location = new System.Drawing.Point(672, 176);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(257, 45);
            this.buttonAsk.TabIndex = 3;
            this.buttonAsk.Text = "Спросить шар!";
            this.buttonAsk.UseVisualStyleBackColor = false;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.Location = new System.Drawing.Point(672, 422);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(257, 46);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить!";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(603, 314);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(63, 20);
            this.labelAnswer.TabIndex = 5;
            this.labelAnswer.Text = "ОтВеТ:";
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(737, 308);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(282, 26);
            this.txtBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 554);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox txtBox2;
    }
}

