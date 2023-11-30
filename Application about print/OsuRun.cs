using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Application_about_print
{
    public partial class OsuRun : Form
    {
        public OsuRun()
        {
            InitializeComponent();

            this.Load += OsuRun_Load;

        }

        private async void mames_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = new ProcessStartInfo("F:\\フォルダー\\akatsuki.exe");
            Process.Start(psi2);

            await Task.Delay(2000);

            ProcessStartInfo psi = new ProcessStartInfo("C:\\Users\\akeno\\Desktop\\Apps\\!Mames Server.lnk");
            Process.Start(psi);
        }

        private void official_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("G:\\osu!\\osu!.exe");
            Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("G:\\osu!\\Replays");
        }

        private void OsuRun_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ProcessStartInfo psi = new ProcessStartInfo("F:\\フォルダー\\OpenTabletDriver.win-x64\\OpenTabletDriver.Daemon.exe");
            Process.Start(psi);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) // Enable を true にすると ループ してくれるs
        {
            string replayFolder = System.Environment.CurrentDirectory = @"G:\osu!\Replays";

            if (replayMoves.Checked == true)
            {
                string[] files = Directory.GetFiles(replayFolder);
                foreach (string file in files)
                {
                    try
                    {
                        Process.Start(file);

                        Thread.Sleep(2000);

                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ファイルは存在しません。" + ex.Message);
                    }
                }
            } else
            {
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("C:\\Users\\akeno\\Desktop\\Apps\\!Mames Server.lnk");
            Process.Start(psi);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
            
        }
    }
}
