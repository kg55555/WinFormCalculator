namespace Calculator

/// <summary>
/// Lab 2: Calculator
/// Author: Kevin Guo A01243552 Trevor Hong A01232148
/// Date: January 18, 2023 Revision: -
/// Source: N/A
/// </summary>
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }
    }
}