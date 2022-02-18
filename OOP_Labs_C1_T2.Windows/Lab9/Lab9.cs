using OOP_Labs_C1_T2.Core;

namespace OOP_Labs_C1_T2.Windows.Lab9;

public class Lab9 : IExecutable
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    public void Execute()
    {
        Application.Run(new MainForm());
    }
}