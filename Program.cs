using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace TacoLuaExec
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int length = 16;
            var rString = "";
            for (var i = 0; i < length; i++)
            {
                rString += ((char)(random.Next(1, 26) + 64)).ToString();
            }
            Console.Title = rString;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@" $$$$$$$$\  $$$$$$\   $$$$$$\   $$$$$$\  ");
            Console.WriteLine(@" \__$$  __|$$  __$$\ $$  __$$\ $$  __$$\ ");
            Console.WriteLine(@"    $$ |   $$ /  $$ |$$ /  \__|$$ /  $$ |");
            Console.WriteLine(@"    $$ |   $$$$$$$$ |$$ |      $$ |  $$ |");
            Console.WriteLine(@"    $$ |   $$  __$$ |$$ |      $$ |  $$ |");
            Console.WriteLine(@"    $$ |   $$ |  $$ |$$ |  $$\ $$ |  $$ |");
            Console.WriteLine(@"    $$ |   $$ |  $$ |\$$$$$$  | $$$$$$  |");
            Console.WriteLine(@"    \__|   \__|  \__| \______/  \______/ ");

            Console.WriteLine(@"Developed By taco#1736");

            string process = "FiveM_GTAProcess";
            if (Process.GetProcessesByName(process).Length > 0)
            {
                Console.WriteLine("FiveM Process Found");
                Thread.Sleep(3000);
                Console.Clear();
                FivemFound.ExecuteLua();
                Console.ReadLine();
            }

            else
            {
                Console.Write("FiveM Process Waiting");
                goto auth2;
            }

        auth2:;

            string process2 = "FiveM_GTAProcess";
            if (Process.GetProcessesByName(process2).Length > 0)
            {
                Console.WriteLine("Fivem Process Found");
                Thread.Sleep(3000);
                Console.Clear();
                FivemFound.ExecuteLua();
                Console.ReadLine();
            }

            else
            {
                Console.Write(".");
                Thread.Sleep(1000);
                goto auth2;
            }
            Console.ReadLine();

        }
    }
}