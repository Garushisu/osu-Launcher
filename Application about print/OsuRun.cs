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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ReplayPath))
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.ReplayPath);
            } else
            {
                MessageBox.Show("Please define ReplayPath.");
                if (!settings.IsFormOpen())
                {
                    settings myForm = new settings();
                    myForm.Show();
                }
                else
                {
                }
            }

        }

        private void OsuRun_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            first.Text = Properties.Settings.Default.Name1;
            second.Text = Properties.Settings.Default.Name2;
            third.Text = Properties.Settings.Default.Name3;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name1))
            {
                first.Visible = true;
            }
            else
            {
                first.Visible = false;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name2))
            {
                second.Visible = true;
            }
            else
            {
                second.Visible = false;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name3))
            {
                third.Visible = true;
            }
            else
            {
                third.Visible = false;
            }

            if (!string.IsNullOrEmpty(Properties.Settings.Default.OTD))
            {
                ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.OTD);
                Process.Start(psi);
            } else
            {

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) // Enable を true にすると ループ してくれる
        {

            string replayFolder = Properties.Settings.Default.ReplayPath;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.ReplayPath))
            {
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
                }
                else
                {
                }
            }
            else
            {

            }






        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!settings.IsFormOpen())
            {
                settings settings = new settings();
                settings.Show();
            }
            else
            {

            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            first.Text = Properties.Settings.Default.Name1;
            second.Text = Properties.Settings.Default.Name2;
            third.Text = Properties.Settings.Default.Name3;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name1))
            {
                first.Visible = true;
            }
            else
            {
                first.Visible = false;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name2))
            {
                second.Visible = true;
            }
            else
            {
                second.Visible = false;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name3))
            {
                third.Visible = true;
            }
            else
            {
                third.Visible = false;
            }
        }

        private async void first_Click(object sender, EventArgs e)
        {
            bool checkPatch1Checked = Properties.Settings.Default.checkPath1;
            

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Path1))
            {
                if (checkPatch1Checked)
                {
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.patchPath))
                    {
                        ProcessStartInfo psi2 = new ProcessStartInfo(Properties.Settings.Default.patchPath);
                        Process.Start(psi2);

                        await Task.Delay(2000);

                        ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path1);
                        Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show("You didn't setting Patcher's path, it'll run osu! without Patcher.");

                        ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path1);
                        Process.Start(psi);
                    }

                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path1);
                    Process.Start(psi);
                }
            } 
            else
            {
                MessageBox.Show("You must select osu!.exe(or server link).");
                if (!settings.IsFormOpen())
                {
                    settings settings = new settings();
                    settings.Show();
                }
                else
                {

                }
            }
            

        }

        private async void second_Click(object sender, EventArgs e)
        {
            bool checkPatch2Checked = Properties.Settings.Default.checkPath2;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Path2))
            {
                if (checkPatch2Checked)
                {
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.patchPath))
                    {
                        ProcessStartInfo psi2 = new ProcessStartInfo(Properties.Settings.Default.patchPath);
                        Process.Start(psi2);

                        await Task.Delay(2000);

                        ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path2);
                        Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show("You didn't set Patcher's path, it'll run osu! without Patcher.");

                        ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path2);
                        Process.Start(psi);
                    }
                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path2);
                    Process.Start(psi);
                }
            } 
            else
            {
                MessageBox.Show("You must select osu!.exe(or server link).");
                if (!settings.IsFormOpen())
                {
                    settings settings = new settings();
                    settings.Show();
                }
                else
                {

                }
            }
            
        }

        private async void third_Click(object sender, EventArgs e)
        {
            bool checkPath3Checked = Properties.Settings.Default.checkPath3;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Path3))
            {
                if (checkPath3Checked)
                {
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.patchPath))
                    {
                        ProcessStartInfo psi2 = new ProcessStartInfo(Properties.Settings.Default.patchPath);
                        Process.Start(psi2);

                        await Task.Delay(2000);

                        ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path3);
                        Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show("You didn't set Patcher's path, it'll run osu! without Patcher.");

                        ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path3);
                        Process.Start(psi);
                    }
                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.Path1);
                    Process.Start(psi);
                }
            } 
            else
            {
                MessageBox.Show("You must select osu!.exe(or server link).");
                if (!settings.IsFormOpen())
                {
                    settings settings = new settings();
                    settings.Show();
                }
                else
                {

                }
            }
            
        }
    } 
}
