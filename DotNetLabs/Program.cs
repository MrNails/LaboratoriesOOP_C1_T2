
using OOP_Labs_C1_T2.Core;

public static class Program
{
    [STAThread]
    public static void Main(params string[] args)
    {
        var lab = string.Empty;

        var exit = false;

        while (!exit)
        {
            Console.WriteLine("Select an option:");
            var assembly = typeof(Program).Assembly;
            var labs = assembly.DefinedTypes
                .Where(t => t.Name.Contains("Lab") && t.ImplementedInterfaces.Contains(typeof(IExecutable)))
                .OrderBy(t => t.Name)
                .ToList();

            for (int i = 0; i < labs.Count; i++)
            {
                Console.WriteLine("\t{0} - {0} laboratory", i + 1);
            }

            Console.WriteLine("\te - exit\n\tc - clear console");

            lab = Console.ReadLine().ToLower();

            if (!int.TryParse(lab, out var labNumber) || labNumber < 1 || labNumber > labs.Count)
            {
                switch (lab)
                {
                    case "e":
                        exit = true;
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Try again!");
                        break;
                }

                continue;
            }

            var selectedLab = (IExecutable)assembly.CreateInstance(labs[labNumber - 1].FullName);

            selectedLab.Execute();
        }
    }
}