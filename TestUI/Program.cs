
using System.Threading;
using Bev.UI;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.Welcome();
            ConsoleUI.WriteLine();

            using (new InfoOperationScope("Some operation"))
            {
                Thread.Sleep(5000);
            }

            ConsoleUI.WriteLine();
            ConsoleUI.WriteLine("some more operations");
            Thread.Sleep(1000);
            ConsoleUI.WriteLine();

            using (new InfoOperationScope("A operation to be aborted"))
            {
                Thread.Sleep(5000);
                ConsoleUI.Abort();
            }
            ConsoleUI.WriteLine();
            ConsoleUI.WriteLine("the end");

        }
    }
}
