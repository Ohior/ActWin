using System.Diagnostics;

namespace ActivateWindow
{
    public partial class ActivateWindow : Form
    {
        // System.Diagnostics.Process.Start("ShutDown", "/s");

        // List of all arguments are as following:

        // -r Shutdown and restart the computer
        // -s Shutdown the computer
        // -t xx    Set timeout for shutdown to xx seconds
        // -a Abort a system shutdown
        // -f Forces all windows to close
        // -i Display GUI interface
        // -l Log off
        // -h Hibernate
        private string activateWindowCode = @"@echo off
            taskkill /F /IM explorer.exe
            explorer.exe
            exit";
        private string fileName = "\\Activation.bat";
        public ActivateWindow()
        {
            InitializeComponent();
        }

        private Process RunScrip(string file_path)
        {
            return Process.Start(file_path);
        }

        private void activateWindowButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir_info = new DirectoryInfo(".");
            File.WriteAllText(dir_info.FullName + fileName, activateWindowCode);
            Debug.WriteLine(dir_info.FullName + fileName);
            Process process = RunScrip(dir_info.FullName + fileName);
            process.EnableRaisingEvents = true;
            process.Exited += (sender, e) =>
            {
                File.Delete(dir_info.FullName + fileName);
                MessageBox.Show("RESTART YOUR SYSTEM NOW");
            };

        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/l");
        }

        private void hibernateButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/h");
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir_info = new DirectoryInfo(".");
            File.WriteAllText(dir_info.FullName + fileName, activateWindowCode);
            Process process = RunScrip(dir_info.FullName + fileName);
            Process.Start("shutdown", "/r /t 0");// the argument /r is to restart the computer
            process.Exited += (sender, e) =>
            {
                File.Delete(dir_info.FullName + fileName);
            };

        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            // starts the shutdown application 
            // the argument /s is to shut down the computer
            // the argument /t 0 is to tell the process that 
            // the specified operation needs to be completed 
            // after 0 seconds
            DirectoryInfo dir_info = new DirectoryInfo(".");
            File.WriteAllText(dir_info.FullName + fileName, activateWindowCode);
            RunScrip(dir_info.FullName + fileName);
            File.Delete(dir_info.FullName + fileName);
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");// the argument /r is to restart the computer
        }
    }
}