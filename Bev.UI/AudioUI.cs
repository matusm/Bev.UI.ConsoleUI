using System;

namespace Bev.UI
{
    public static class AudioUI
    {
        public static void Beep()
        {
            try
            {
                Console.Beep();
            }
            catch (PlatformNotSupportedException)
            {
                SystemBeep();
            }
        }

        public static void BeepLow() => Beep(400, 200);

        public static void BeepHigh() => Beep(1600, 200);

        public static void BeepHighHigh() => Beep(3600, 200);

        public static void SystemBeep() => Console.Write("\a");

        public static void Beep(int frequency, int duration)
        {
            try
            {
                Console.Beep(frequency, duration);
            }
            catch(ArgumentOutOfRangeException)
            {
                Beep();
            }
            catch (PlatformNotSupportedException)
            {
            }
        }
    }
}
