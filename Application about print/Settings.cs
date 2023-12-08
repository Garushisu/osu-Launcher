using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_about_print
{
    public partial class settings : Form
    {

        private static bool isFormOpen = false;

        public settings()
        {
            InitializeComponent();

            isFormOpen = true;

        }



        osuLancher OsuRunInstance = new osuLancher();

        private void Settings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            firstName.Text = Properties.Settings.Default.Name1;
            firstPath.Text = Properties.Settings.Default.Path1;
            secondName.Text = Properties.Settings.Default.Name2;
            secondPath.Text = Properties.Settings.Default.Path2;
            thirdName.Text = Properties.Settings.Default.Name3;
            thirdPath.Text = Properties.Settings.Default.Path3;
            OTD.Text = Properties.Settings.Default.OTD;
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.Name1 = firstName.Text;
            Properties.Settings.Default.Path1 = firstPath.Text;
            Properties.Settings.Default.Name2 = secondName.Text;
            Properties.Settings.Default.Path2 = secondPath.Text;
            Properties.Settings.Default.Name3 = thirdName.Text;
            Properties.Settings.Default.Path3 = thirdPath.Text;
            Properties.Settings.Default.OTD = OTD.Text;
            Properties.Settings.Default.Save();

        }

        private void path1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Setting the exe file.";
            openFileDialog.Filter = "file (*.exe) | *.exe";
            openFileDialog.DereferenceLinks = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                firstPath.Text = path;
                path = Properties.Settings.Default.Path1;
            }
        }

        private void path2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Setting the exe file.";
            openFileDialog.Filter = "file (*.exe) | *.exe";
            openFileDialog.DereferenceLinks = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                secondPath.Text = path;
                path = Properties.Settings.Default.Path2;
            }
        }

        private void path3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Setting the exe file.";
            openFileDialog.Filter = "file (*.exe) | *.exe";
            openFileDialog.DereferenceLinks = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                thirdPath.Text = path;
                path = Properties.Settings.Default.Path3;
            }
        }

        private void replayPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select Replay folder.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ReplayPath = folderBrowserDialog.SelectedPath;
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.ReplayPath;

                
            }
        }

        private void OTDPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Setting the exe file.";
            openFileDialog.Filter = "file (*.exe) | *.exe";
            openFileDialog.DereferenceLinks = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                OTD.Text = path;
                path = Properties.Settings.Default.OTD;
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            isFormOpen = false;
        }

        public static bool IsFormOpen()
        {
            return isFormOpen;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
