using System;
using System.Numerics;
using System.Linq;

namespace RandomGeneratorComparison
{
    class Program
    {
        // Параметры мультипликативного конгруэнтного генератора
        private static readonly BigInteger M = BigInteger.Pow(2, 63); // 2^63
        private static readonly BigInteger Beta = BigInteger.Pow(2, 32) + 3; // 2^32 + 3
        private static BigInteger xStar; // текущее состояние генератора

        static void Main(string[] args)
        {
            Console.WriteLine("=== СРАВНЕНИЕ ГЕНЕРАТОРОВ СЛУЧАЙНЫХ ЧИСЕЛ ===\n");

            int sampleSize = 100000;
            int seed = 42; // начальное значение (зерно)

            // Теоретические значения для равномерного распределения U[0,1]
            double theoreticalMean = 0.5;
            double theoreticalVariance = 1.0 / 12.0; // ≈ 0.083333...

            Console.WriteLine($"Размер выборки: {sampleSize}");
            Console.WriteLine($"Seed: {seed}\n");

            Console.WriteLine("=== ТЕОРЕТИЧЕСКИЕ ЗНАЧЕНИЯ (U[0,1]) ===");
            Console.WriteLine($"Среднее: {theoreticalMean:F10}");
            Console.WriteLine($"Дисперсия: {theoreticalVariance:F10}\n");

            // 1. Самописный генератор
            Console.WriteLine("=== САМОПИСНЫЙ ГЕНЕРАТОР ===");
            double[] customSamples = GenerateCustomSamples(sampleSize, seed);
            double customMean = CalculateMean(customSamples);
            double customVariance = CalculateVariance(customSamples, customMean);

            Console.WriteLine($"Выборочное среднее: {customMean:F10}");
            Console.WriteLine($"Выборочная дисперсия: {customVariance:F10}");
            Console.WriteLine($"Отклонение среднего от теоретического: {Math.Abs(customMean - theoreticalMean):F10}");
            Console.WriteLine($"Отклонение дисперсии от теоретического: {Math.Abs(customVariance - theoreticalVariance):F10}\n");

            // 2. Встроенный генератор C#
            Console.WriteLine("=== ВСТРОЕННЫЙ ГЕНЕРАТОР C# (System.Random) ===");
            double[] builtinSamples = GenerateBuiltInSamples(sampleSize, seed);
            double builtinMean = CalculateMean(builtinSamples);
            double builtinVariance = CalculateVariance(builtinSamples, builtinMean);

            Console.WriteLine($"Выборочное среднее: {builtinMean:F10}");
            Console.WriteLine($"Выборочная дисперсия: {builtinVariance:F10}");
            Console.WriteLine($"Отклонение среднего от теоретического: {Math.Abs(builtinMean - theoreticalMean):F10}");
            Console.WriteLine($"Отклонение дисперсии от теоретического: {Math.Abs(builtinVariance - theoreticalVariance):F10}\n");

            // 3. Сравнение
            Console.WriteLine("=== СРАВНЕНИЕ РЕЗУЛЬТАТОВ ===");
            Console.WriteLine($"Разница в средних (самописный - встроенный): {Math.Abs(customMean - builtinMean):F10}");
            Console.WriteLine($"Разница в дисперсиях (самописный - встроенный): {Math.Abs(customVariance - builtinVariance):F10}\n");

            // 4. Вывод
            Console.WriteLine("=== ВЫВОД ===");
            double customMeanError = Math.Abs(customMean - theoreticalMean);
            double builtinMeanError = Math.Abs(builtinMean - theoreticalMean);
            double customVarError = Math.Abs(customVariance - theoreticalVariance);
            double builtinVarError = Math.Abs(builtinVariance - theoreticalVariance);

            Console.WriteLine($"Самописный генератор:");
            Console.WriteLine($"  - Точность среднего: {customMeanError:E2}");
            Console.WriteLine($"  - Точность дисперсии: {customVarError:E2}");

            Console.WriteLine($"\nВстроенный генератор:");
            Console.WriteLine($"  - Точность среднего: {builtinMeanError:E2}");
            Console.WriteLine($"  - Точность дисперсии: {builtinVarError:E2}");

            if (customMeanError < builtinMeanError && customVarError < builtinVarError)
                Console.WriteLine("\n✓ Самописный генератор показал лучшую точность!");
            else if (builtinMeanError < customMeanError && builtinVarError < customVarError)
                Console.WriteLine("\n✓ Встроенный генератор показал лучшую точность!");
            else
                Console.WriteLine("\n✓ Генераторы показали сопоставимую точность!");

            Console.WriteLine("\nОба генератора дают результаты, близкие к теоретическим значениям");
            Console.WriteLine("для равномерного распределения на интервале [0,1].");
        }

        /// <summary>
        /// Генерация выборки с помощью самописного мультипликативного конгруэнтного генератора
        /// </summary>
        static double[] GenerateCustomSamples(int count, int seed)
        {
            double[] samples = new double[count];

            // Инициализация начального значения
            xStar = Beta; // x₀* = β

            for (int i = 0; i < count; i++)
            {
                // x_i* = (β * x_{i-1}*) mod M
                xStar = (Beta * xStar) % M;

                // x_i = x_i* / M
                samples[i] = (double)xStar / (double)M;
            }

            return samples;
        }

        /// <summary>
        /// Генерация выборки с помощью встроенного генератора C#
        /// </summary>
        static double[] GenerateBuiltInSamples(int count, int seed)
        {
            Random rnd = new Random(seed);
            double[] samples = new double[count];

            for (int i = 0; i < count; i++)
            {
                samples[i] = rnd.NextDouble();
            }

            return samples;
        }

        /// <summary>
        /// Вычисление выборочного среднего
        /// </summary>
        static double CalculateMean(double[] samples)
        {
            double sum = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                sum += samples[i];
            }
            return sum / samples.Length;
        }

        /// <summary>
        /// Вычисление выборочной дисперсии
        /// </summary>
        static double CalculateVariance(double[] samples, double mean)
        {
            double sumSquaredDiff = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                double diff = samples[i] - mean;
                sumSquaredDiff += diff * diff;
            }
            return sumSquaredDiff / samples.Length;
        }
    }
}