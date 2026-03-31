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

namespace Шар
{
    public partial class Form1 : Form
    {
        // ============================================
        // ВАРИАНТЫ ОТВЕТОВ И ИХ ВЕРОЯТНОСТИ
        // ============================================
        private readonly string[] answers = {
            "Да",              // 0
            "Нет",             // 1
            "Возможно",        // 2
            "Маловероятно",    // 3
            "Не думаю",        // 4
            "Безусловно"       // 5
        };

        // Вероятности (сумма = 1.0)
        private readonly double[] probabilities = {
            0.20,  // Да - 20%
            0.20,  // Нет - 20%
            0.25,  // Возможно - 25%
            0.15,  // Маловероятно - 15%
            0.10,  // Не думаю - 10%
            0.10   // Безусловно - 10%
        };

        // ============================================
        // САМОПИСНЫЙ ГЕНЕРАТОР
        // ============================================
        private static readonly BigInteger M = BigInteger.Pow(2, 63);
        private static readonly BigInteger Beta = BigInteger.Pow(2, 32) + 3;
        private static BigInteger xStar;

        // Прогрев
        private const int WarmupIterations = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация генератора
            InitializeGenerator(42);
            WarmupGenerator();

            // Настройки интерфейса
            txtBox1.Focus();

            Console.WriteLine($"[INFO] Magic 8-Ball готов! {answers.Length} ответов.");
        }

        /// <summary>
        /// базовый датчик: генерирует число α ∈ [0, 1)
        /// </summary>
        private double GenerateAlpha()
        {
            xStar = (Beta * xStar) % M;
            return (double)xStar / (double)M;
        }

        /// <summary>
        /// Инициализация генератора
        /// </summary>
        private void InitializeGenerator(int seed)
        {
            xStar = Beta + seed;
            Console.WriteLine($"[INIT] Генератор инициализирован: seed = {seed}");
        }

        /// <summary>
        ///  Прогрев генератора
        /// </summary>
        private void WarmupGenerator()
        {
            Console.WriteLine($"[WARMUP] Начинаю прогрев: {WarmupIterations} итераций...");

            for (int i = 0; i < WarmupIterations; i++)
            {
                xStar = (Beta * xStar) % M;
            }

            Console.WriteLine($"[WARMUP] Прогрев завершён!");
        }

        /// <summary>
        /// ГЕНЕРАЦИЯ СОБЫТИЯ ИЗ ГРУППЫ (алгоритм из слайда!)
        /// </summary>
        private int GenerateEventFromGroup()
        {
            // Шаг 1: генерируем α
            double alpha = GenerateAlpha();

            // Шаг 2: находим интервал, куда попало α
            double cumulativeProbability = 0.0;

            for (int k = 0; k < probabilities.Length; k++)
            {
                cumulativeProbability += probabilities[k];

                // Если α попало в этот интервал → возвращаем номер события
                if (alpha < cumulativeProbability)
                {
                    Console.WriteLine($"[DEBUG] α = {alpha:F4}, интервал [{k}] = {answers[k]} (p={probabilities[k]})");
                    return k;
                }
            }

            return probabilities.Length - 1;
        }

        
        private void buttonAsk_Click(object sender, EventArgs e)
        {
            // Проверяем, что вопрос введён
            if (string.IsNullOrWhiteSpace(txtBox1.Text))
            {
                MessageBox.Show("Пожалуйста, введите вопрос!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox1.Focus();
                return;
            }

            // Генерируем событие из группы (номер ответа)
            int answerIndex = GenerateEventFromGroup();

            // Получаем текст ответа
            string answer = answers[answerIndex];

            // Показываем ответ
            txtBox2.Text = answer;

            // Красим в зависимости от ответа
            ColorAnswer(answer);

            Console.WriteLine($"[STAT] Ответ: {answer}");
        }

        /// <summary>
        /// Раскраска ответа
        /// </summary>
        private void ColorAnswer(string answer)
        {
            switch (answer)
            {
                case "Да":
                case "Безусловно":
                    txtBox2.BackColor = Color.LightGreen;
                    txtBox2.ForeColor = Color.DarkGreen;
                    break;
                case "Нет":
                case "Не думаю":
                    txtBox2.BackColor = Color.LightCoral;
                    txtBox2.ForeColor = Color.DarkRed;
                    break;
                case "Возможно":
                    txtBox2.BackColor = Color.LightYellow;
                    txtBox2.ForeColor = Color.DarkOrange;
                    break;
                case "Маловероятно":
                    txtBox2.BackColor = Color.LightGray;
                    txtBox2.ForeColor = Color.DimGray;
                    break;
                default:
                    txtBox2.BackColor = Color.White;
                    txtBox2.ForeColor = Color.Black;
                    break;
            }
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox2.BackColor = Color.White;
            txtBox1.Focus();
        }
    }
}