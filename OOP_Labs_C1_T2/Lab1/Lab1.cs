using System;
using System.Globalization;

namespace OOP_Labs_C1_T2.Lab1
{
    public class Lab1 : IExecutable
    {
        private Func<string, float?> m_convertToFloat;
        private Func<float?, bool> m_checkFloat;

        public Lab1()
        {
            m_convertToFloat = input =>
            {
                var result = 0.0f;
                var convRes = float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result);

                return convRes ? result : null;
            };

            m_checkFloat = number => number.HasValue;
        }
        
        public void Execute()
        {
            Console.WriteLine("Laboratory work 1\n\nTask 1:");
            Task1();
            Console.WriteLine("\nTask 2:");
            Task2();
        }

        private void Task1()
        {
            float a = 0, x = 0, y = 0, z = 0;

            Console.WriteLine("Start Task 1\nVariant 16 (20)\n" +
                              "Evaluating equation (sin(7/28) + y^2 / (3 + sqrt(z^3 + 16))) * |x| " +
                              "where x not equal 0; either exit from task.");

            x = Helpers.Input("Enter x: ", "Wrong input. Try again", m_convertToFloat)!.Value;

            while (x != 0)
            {
                  y = Helpers.Input("Enter y: ", "Wrong input. Try again", m_convertToFloat)!.Value;
                  z = Helpers.Input("Enter z: ", "Wrong input. Try again", m_convertToFloat)!.Value;

                  a = (float)(Math.Sin(ConvertToRadians(7 / 28)) +
                       Math.Pow(y, 2) / (3 + Math.Sqrt(Math.Pow(z, 3) + 16))) * Math.Abs(x);

                  Console.WriteLine($"X range: {GetXRangeName(x)}\nResult (a) = {a.ToString()} ({GetARangeName(a)})");

                  x = Helpers.Input("Enter x: ", "Wrong input. Try again", m_convertToFloat)!.Value;
            }

            Console.WriteLine("End of Task 1");
        }

        private void Task2()
        {
            float radius;
            
            Console.WriteLine("Start Task 2\nVariant 1\n" +
                              "Evaluating flowerbed square base on it radius.");
            
            radius = Helpers.Input("Enter radius: ", "Wrong input. Try again", m_convertToFloat)!.Value;

            Console.WriteLine($"Square of flowerbed is {Math.PI * Math.Pow(radius, 2)}");
            
            Console.WriteLine("End of Task 2");
        }
        
        private double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        private string GetXRangeName(float x)
        {
            if (x < -10)
                return "less than -10";
            else if (x < -1)
                return "less than -1";
            else if (x > 10)
                return "greater than 10";
            else
                return "greater than 1";
        }

        private string GetARangeName(float a)
        {
            if (a < 0)
                return "negative";
            else
                return "positive";
        }
    }
}