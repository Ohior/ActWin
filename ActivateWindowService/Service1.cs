using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ActivateWindowService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
            ActivateWindow
            DirectoryInfo dir_info = new DirectoryInfo(".");
            File.WriteAllText(dir_info.FullName + fileName, activateWindowCode);
            RunScrip(dir_info.FullName + fileName);
            File.Delete(dir_info.FullName + fileName);
        }
    }
}
