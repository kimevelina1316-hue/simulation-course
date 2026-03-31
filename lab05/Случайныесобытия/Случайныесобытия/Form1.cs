using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Случайныесобытия
{
    public partial class Form1 : Form
    {
        
        private const double ProbabilityYes = 0.5;

        
        private static readonly BigInteger M = BigInteger.Pow(2, 63);
        private static readonly BigInteger Beta = BigInteger.Pow(2, 32) + 3;
        private static BigInteger xStar;

      
        private const int WarmupIterations = 100; // Количество итераций прогрева

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Инициализация генератора
            InitializeGenerator(42);

            // 2.  ПРОГРЕВ ГЕНЕРАТОРА
            WarmupGenerator();

            // 3. Настройки интерфейса
            textBoxAnswer.BackColor = Color.White;
            textBoxAnswer.Text = "";
            textBoxQuestion.Focus();

            // 4. Информацию о прогреве в консоль
            Console.WriteLine($"[INFO] Генератор прогрет: {WarmupIterations} итераций");
        }

        /// <summary>
        /// базовый датчик: генерирует число α ∈ [0, 1)
        /// </summary>
        private double GenerateAlpha()
        {
            xStar = (Beta * xStar) % M;
            double alpha = (double)xStar / (double)M;
            return alpha;
        }

        /// <summary>
        /// Инициализация генератора (зерно)
        /// </summary>
        private void InitializeGenerator(int seed)
        {
            xStar = Beta + seed;
            Console.WriteLine($"[INIT] Генератор инициализирован: seed = {seed}");
        }

        /// <summary>
        /// ПРОГРЕВ ГЕНЕРАТОРА
        /// Генерируем и отбрасываем N чисел для "перемешивания" состояния
        /// </summary>
        private void WarmupGenerator()
        {
            Console.WriteLine($"[WARMUP] Начинаю прогрев: {WarmupIterations} итераций...");

            for (int i = 0; i < WarmupIterations; i++)
            {
                // Генерируем число, но НЕ используем его
                xStar = (Beta * xStar) % M;
            }

            Console.WriteLine($"[WARMUP] Прогрев завершён!");
        }

        
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQuestion.Text))
            {
                MessageBox.Show("Пожалуйста, введите вопрос!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuestion.Focus();
                return;
            }

            // === АЛГОРИТМ ИЗ ПРЕЗЕНТАЦИИ + ВАШ ГЕНЕРАТОР ===
            double alpha = GenerateAlpha();
            string result = (alpha < ProbabilityYes) ? "ДА" : "НЕТ";

            // Показываем ответ
            textBoxAnswer.Text = result;

            // Визуальная подсветка
            if (result == "ДА")
            {
                textBoxAnswer.BackColor = Color.LightGreen;
                textBoxAnswer.ForeColor = Color.DarkGreen;
            }
            else
            {
                textBoxAnswer.BackColor = Color.LightCoral;
                textBoxAnswer.ForeColor = Color.DarkRed;
            }

            // Отладка в Output (View → Output)
            Console.WriteLine($"[DEBUG] α = {alpha:F10}, результат = {result}");
        }

       
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxQuestion.Clear();
            textBoxAnswer.Clear();
            textBoxAnswer.BackColor = Color.White;
            textBoxAnswer.ForeColor = Color.Black;
            textBoxQuestion.Focus();
        }
    }
}