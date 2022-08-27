using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ActivateWindow
{
    partial class BackgroundService : ServiceBase
    {
        public BackgroundService()
        {
            InitializeComponent();
        }

        public void StartService()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            Application.Run(new ActivateWindow());
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
