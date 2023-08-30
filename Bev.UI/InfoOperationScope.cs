using System;

namespace Bev.UI
{
    public class InfoOperationScope : IDisposable
    {
        public InfoOperationScope(string message) => ConsoleUI.StartOperation(message);

        public void Dispose() => ConsoleUI.Done();
    }
}
