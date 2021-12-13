using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBA8
{
    abstract class Computer
    {
        public string BootUp()
        {
            return "BOOTING UP COMPUTER .....";
        }
        public string ShutDown()
        {
            return "SHUTTING DOWN COMPUTER .....";
        }
    }

    class SuperComputer : Computer
    {
        static void Main()
        {
            Console.Write("ENTER 1 TO BOOT AND 2 TO SHUTDOWN. ENTER CHOICE = ");
            int n = Convert.ToInt32(Console.ReadLine());
            SuperComputer ob = new SuperComputer();
            if (n == 1)
                ob.BootUp();
            else if (n == 2)
                ob.ShutDown();
            Console.ReadLine();
        }       
    }

    class MainframeComputer : Computer
    {
        static void Main()
        {
            Console.Write("ENTER 1 TO BOOT AND 2 TO SHUTDOWN. ENTER CHOICE = ");
            int n = Convert.ToInt32(Console.ReadLine());
            MainframeComputer ob = new MainframeComputer();
            if (n == 1)
                ob.BootUp();
            else if (n == 2)
                ob.ShutDown();
            Console.ReadLine();
        }
    }

    class MicroComputer : Computer
    {
        static void Main()
        {
            Console.Write("ENTER 1 TO BOOT AND 2 TO SHUTDOWN. ENTER CHOICE = ");
            int n = Convert.ToInt32(Console.ReadLine());
            MicroComputer ob = new MicroComputer();
            if (n == 1)
                ob.BootUp();
            else if (n == 2)
                ob.ShutDown();
            Console.ReadLine();
        }
    }

}
