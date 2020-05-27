using System;
using System.Windows.Forms;

namespace PresetVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VolumeController vc = new VolumeController();
            vc.SetVolume(Convert.ToInt32(Properties.Settings.Default["preset1"]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VolumeController vc = new VolumeController();
            vc.SetVolume(Convert.ToInt32(Properties.Settings.Default["preset2"]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VolumeController vc = new VolumeController();
            vc.SetVolume(Convert.ToInt32(Properties.Settings.Default["preset3"]));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VolumeController vc = new VolumeController();
            vc.SetVolume(Convert.ToInt32(Properties.Settings.Default["preset4"]));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VolumeController vc = new VolumeController();
            vc.SetVolume(Convert.ToInt32(Properties.Settings.Default["preset5"]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = (string)Properties.Settings.Default["preset1"];
            button2.Text = (string)Properties.Settings.Default["preset2"];
            button3.Text = (string)Properties.Settings.Default["preset3"];
            button4.Text = (string)Properties.Settings.Default["preset4"];
            button5.Text = (string)Properties.Settings.Default["preset5"];
        }
    }
}
