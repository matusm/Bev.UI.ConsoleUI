using System;

namespace Bev.UI
{
    public class InfoOperation : IDisposable
    {
        public InfoOperation(string message) => ConsoleUI.StartOperation(message);
        public void Dispose() => ConsoleUI.Done();
    }

    public class InfoFileWrite : IDisposable
    {
        public InfoFileWrite(string filename) => ConsoleUI.WritingFile(filename);
        public void Dispose() => ConsoleUI.Done();
    }

    public class InfoFileRead : IDisposable
    {
        public InfoFileRead(string filename) => ConsoleUI.ReadingFile(filename);
        public void Dispose() => ConsoleUI.Done();
    }

}
