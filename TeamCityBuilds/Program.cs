using System;
using System.Diagnostics;
namespace TeamCityBuilds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Team City Test");
            Console.WriteLine("****************");
            Console.Write("Enter The application you wanted to run:");
            string _app_name = Console.ReadLine();
            System.Diagnostics.Process.Start(_app_name);
            

        

        }
    }
}
