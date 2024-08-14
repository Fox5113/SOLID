using AaSOLID.Setting;
using AaSOLID.SOLID;
using AaSOLID.SOLID.BaseClasses;
using AaSOLID.SOLID.Main;
using System.IO;


internal class Program
{
    private readonly static IWriter Logger = new LogWriter("logfile.txt");
    private static void Main(string[] args)
    {
#pragma warning disable IDE0059 // Ненужное присваивание значения
        var game = new Game(args, Logger);
#pragma warning restore IDE0059 // Ненужное присваивание значения

    }
}