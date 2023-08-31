
using System.Threading;
using Bev.UI;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.Welcome();
            AudioUI.Beep();
            Thread.Sleep(1000);
            AudioUI.BeepHigh();
            Thread.Sleep(1000);
            AudioUI.BeepHighHigh();
            Thread.Sleep(1000); 
            AudioUI.Beep(400, 200);
            Thread.Sleep(1000);

            AudioUI.SystemBeep();
            Thread.Sleep(1000);


            ConsoleUI.WriteLine();

            using (new InfoFileRead("XYZZY.txt"))
            {
                Thread.Sleep(5000);
            }

            ConsoleUI.WriteLine();
            ConsoleUI.WriteLine("some more operations");
            Thread.Sleep(1000);
            ConsoleUI.WriteLine();

            using (new InfoOperation("A operation to be aborted"))
            {
                Thread.Sleep(5000);
                ConsoleUI.Abort();
            }
            ConsoleUI.WriteLine();
            ConsoleUI.WriteLine("the end");

        }
    }
}
