using System;

namespace OOP_Labs_C1_T2
{
    public static class Helpers
    {
        public static T Input<T>(string inputText, string errorText, 
                                 Func<string, T> converter, 
                                 Func<T, bool> predicate = null)
        {
            var input = string.Empty;
            T result;

            while (true)
            {
                Console.WriteLine(inputText);
                input = Console.ReadLine();
            
                result = converter.Invoke(input);

                if (predicate == null || predicate(result))
                    return result;

                Console.WriteLine(errorText);
            }

        }
    }
}