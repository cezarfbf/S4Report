using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace S4Report
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteLog(DateTime.Now.ToString() + ": Service Start");
            ScriptRunner runner = new ScriptRunner();
           
        }

        protected override void OnStop()
        {
            WriteLog(DateTime.Now.ToString() + ": Service Stoped");

        }

        private void WriteLog(string log)
        {
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt"))
            {
                sw.WriteLine(log);
            }
        }
     
    }
}
