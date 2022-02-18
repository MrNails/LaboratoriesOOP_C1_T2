using OOP_Labs_C1_T2.Core;

namespace OOP_Labs_C1_T2.Windows.Lab7;

public class Lab7 : IExecutable
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public void Execute()
    {
        Application.Run(new MainForm());
    }
}