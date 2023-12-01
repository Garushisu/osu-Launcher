using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_about_print
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        OsuRun OsuRunInstance = new OsuRun();

        private void Settings_Load(object sender, EventArgs e)
        {
            firstName.Text = Properties.Settings.Default.Name1;
            firstPath.Text = Properties.Settings.Default.Path1;
            secondName.Text = Properties.Settings.Default.Name2;
            secondPath.Text = Properties.Settings.Default.Path2;
            thirdName.Text = Properties.Settings.Default.Name3;
            thirdPath.Text = Properties.Settings.Default.Path3;
            

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

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name1 = firstName.Text;
            Properties.Settings.Default.Path1 = firstPath.Text;
            Properties.Settings.Default.Name2 = secondName.Text;
            Properties.Settings.Default.Path2 = secondPath.Text;
            Properties.Settings.Default.Name3 = thirdName.Text;
            Properties.Settings.Default.Path3 = thirdPath.Text;
            Properties.Settings.Default.Save();
        }

        
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("保存", "保存しますか？", MessageBoxButtons.YesNoCancel);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.Name1 = firstName.Text;
                Properties.Settings.Default.Path1 = firstPath.Text;
                Properties.Settings.Default.Name2 = secondName.Text;
                Properties.Settings.Default.Path2 = secondPath.Text;
                Properties.Settings.Default.Name3 = thirdName.Text;
                Properties.Settings.Default.Path3 = thirdPath.Text;
                Properties.Settings.Default.Save();
            }else if(result == System.Windows.Forms.DialogResult.No)
            {
                
            } else
            {
                Close();
            }
        }
    }
}
