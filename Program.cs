using System;
using System.Runtime.InteropServices;

class Program
{
    // Import the SetSuspendState function from powrprof.dll
    [DllImport("powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

    static void Main()
    {
        // Put the computer to sleep
        // hibernate = false (sleep mode), forceCritical = false, disableWakeEvent = false
        SetSuspendState(false, false, false);
    }
}