using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace TacoLuaExec
{
    class FivemFound
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
        public static void ExecuteLua()
        {
            string path = @"C:\\TacoLua";
            if (Directory.Exists(path))
            {
            }
            else
            {
                Directory.CreateDirectory("C:\\TacoLua");
            }

            if (File.Exists("C:\\TacoLua\\Menu.lua"))
            {
            }
            else
            {
                File.Create("C:\\TacoLua\\Menu.lua");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"I created a file for you here C:\TacoLua\Menu.lua | You can put your code inside of Menu.lua ");
            Console.Write(@"If you are writed your code press (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Y");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(")");
            Console.WriteLine("");
        Input:
            var option = Console.ReadLine();
            if (option == "Y")
            {
                Execute();
            }
            if (option == "y")
            {
                Execute();
            }
            goto Input;
            // Console.ReadLine();
        }

        public static void Execute()
        {
            using (System.IO.StreamWriter WriteText = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\FiveM\FiveM.app\citizen\scripting\lua\scheduler.lua", true))
                WriteText.WriteLine("");
            TryFunction();
            Console.ReadLine();
        }
        public static void TryFunction()
        {
            using (System.IO.StreamWriter WriteText = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\FiveM\FiveM.app\citizen\scripting\lua\scheduler.lua", true))
                WriteText.WriteLine("if GetCurrentResourceName() == \"spawnmanager\" then");
            TryFunction2();
            Console.ReadLine();
        }

        public static void TryFunction2()
        {
            string fileName = @"C:\TacoLua\Menu.lua";
            StreamReader reader = new StreamReader(fileName);
            FileInfo fi = new FileInfo(fileName);
            StreamReader sr = fi.OpenText();
            string SSSSS = "";
            while ((SSSSS = sr.ReadLine()) != null)
            {
                using (System.IO.StreamWriter WriteText2 = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\FiveM\FiveM.app\citizen\scripting\lua\scheduler.lua", true))
                    WriteText2.WriteLine(SSSSS);
            }
            TryFunction3();
            Console.ReadLine();
        }
        public static void TryFunction3()
        {
            using (System.IO.StreamWriter WriteText3 = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\FiveM\FiveM.app\citizen\scripting\lua\scheduler.lua", true))
                WriteText3.WriteLine("end");
            TryFunction4();
            Console.ReadLine();
        }
        public static void TryFunction4()
        {
            using (System.IO.StreamWriter WriteText4 = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\FiveM\FiveM.app\citizen\scripting\lua\scheduler.lua", true))
                WriteText4.WriteLine("");
            MessageBox((IntPtr)0, "Injected have fun...", "Taco Free Lua Exec", 0);
            Environment.Exit(0);
        }
    }
}