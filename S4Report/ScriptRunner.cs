using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace S4Report
{
    class ScriptRunner
    {
        private readonly Timer timer;

        public ScriptRunner()
        {
            timer = new Timer(10000) { AutoReset = true };
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"\\output.txt", lines);
        }
    }
}
