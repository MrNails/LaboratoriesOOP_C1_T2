using System;
using OOP_Labs_C1_T2.Core;

namespace OOP_Labs_C1_T2
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Windows.WindowConfiguration.Configure();

            IExecutable executable = null!;
            int action = -1;
            
            while (true)
            {
                Console.WriteLine("Choose an action:" +
                                  "\n\t0 - exit" +
                                  "\n\t1 - Laboratory work 1" +
                                  "\n\t2 - Laboratory work 2" +
                                  "\n\t3 - Laboratory work 3" +
                                  "\n\t4 - Laboratory work 4" +
                                  "\n\t5 - Laboratory work 5" +
                                  "\n\t7 - Laboratory work 7" +
                                  "\n\t9 - Laboratory work 9"
                                  );

                var input = Console.ReadLine();

                if (!int.TryParse(input, out action))
                    action = -1;
                
                Console.Clear();
                switch (action)
                {
                    case 0:
                        return;
                    case 1:
                        executable = new Lab1.Lab1();
                        break;
                    case 2:
                        executable = new Lab2.Lab2();
                        break;
                    case 3:
                        executable = new Lab3.Lab3();
                        break;
                    case 4:
                        executable = new Lab4.Lab4();
                        break;
                    case 5:
                        executable = new Lab5.Lab5();
                        break;
                    case 7:
                        executable = new Windows.Lab7.Lab7();
                        break;
                    case 9:
                        executable = new Windows.Lab9.Lab9();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Try again.");
                        break;
                }
                
                executable?.Execute();
            }
        }
    }
}
