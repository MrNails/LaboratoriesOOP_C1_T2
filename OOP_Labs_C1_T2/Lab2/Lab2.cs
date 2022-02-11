using System;

namespace OOP_Labs_C1_T2.Lab2;

public class Lab2 : IExecutable
{
    private Func<string, int?> m_convertToInt;
    private Func<int?, bool> m_checkInt;

    public Lab2()
    {
        m_convertToInt = input =>
        {
            var result = 0;
            var convRes = int.TryParse(input, out result);

            return convRes ? result : null;
        };

        m_checkInt = number => number >= 0;
    }
    
    public void Execute()
    {
        Console.WriteLine("Laboratory work 2\n\nTask 1:");
        Task1();
        Console.WriteLine("\nTask 2:");
        Task2();
    }

    private void Task1()
    {
        int[] staticArr = new int [16];

        Console.WriteLine("Start task 1.\nSwap max element with 4-th element.");
        
        Fill1DArr(staticArr);

        PrintArr(staticArr);
        
        var index = MaxElemIndex(staticArr);

        //Swap via deconstruct
        (staticArr[3], staticArr[index]) = (staticArr[index], staticArr[3]);
        
        PrintArr(staticArr);
        
        Console.WriteLine("End task 1.\n");
    }

    private void Task2()
    {
        int size, minElemIndex, maxElemIndex;
        int[] arr;

        Console.WriteLine("Start task 2.\nPrint max and min elements indices.");
        
        size = Helpers.Input("Enter array size: ", "Wrong input or size less than 0. Try again.", m_convertToInt, m_checkInt)!.Value;

        arr = (int[])Array.CreateInstance(typeof(int), size);

        Fill1DArr(arr);
        
        PrintArr(arr);

        minElemIndex = MinElemIndex(arr);
        maxElemIndex = MaxElemIndex(arr);

        Console.WriteLine($"Min element index {minElemIndex + 1}. Max element index {maxElemIndex + 1}");
        
        Console.WriteLine("End task 2.\n");
    }

    private void Fill1DArr(int[] arr)
    {
        var rand = new Random(DateTime.Now.Millisecond);
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rand.Next(-1000, 1000);
    }

    private void PrintArr(int[] arr)
    {
        Console.WriteLine("\n=========================");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i].ToString() + " ");
        Console.WriteLine("\n=========================\n");
    }

    private int MaxElemIndex(int[]? arr)
    {
        int result = -1;
        int max = 0;

        if (arr == null || arr.Length == 0)
            return result;

        max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                result = i;
            }
        }

        return result;
    }
    
    private int MinElemIndex(int[]? arr)
    {
        int result = -1;
        int min = 0;

        if (arr == null || arr.Length == 0)
            return result;

        min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
                result = i;
            }
        }

        return result;
    }
}