using System;

namespace practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;

            double b = Math.PI/2;

            double x0 = (a + b) / 2;

            double eps = InputDouble("Введите значение eps: ", "Необходимо ввести десятичную дробь больше нуля", 0);

            double f;

            while (Math.Abs(Formula(x0)) > eps)

            {

                f = Formula(x0) * Formula(a);

                if (f <= 0)

                {

                    b = x0;

                }

                else

                {

                    a = x0;

                }

                x0 = (a + b) / 2;

            }

            Console.WriteLine("Ответ: " + Formula(x0));

            Console.WriteLine("\nPress something to exit");

            Console.ReadKey();

        }
        static double InputDouble(string msg, string errorMsg = "Необходимо ввести число или десятичную дробь через запятую", double minValue = double.MinValue)

        {

            double result = 0;

            Console.Write(msg);

            while (!double.TryParse(Console.ReadLine(), out result) || result < minValue)

            {

                Console.WriteLine(errorMsg);

            }

            return result;

        }

        static double Formula(double x)

        {

            return Math.Pow(2*Math.Sin(x), 2)/3 - 0.75 * Math.Pow(Math.Cos(x), 2);

        }
    }
}
