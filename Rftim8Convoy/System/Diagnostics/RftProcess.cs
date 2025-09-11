using System.Diagnostics;

namespace Rftim8Convoy.System.Diagnostics
{
    class RftProcess
    {
        public RftProcess()
        {
            using Process? process = new();
            process.StartInfo.FileName = @"<Path.exe>";

            process.Start();
        }
    }
}
