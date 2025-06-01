using gui2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gui2
{
    public partial class TestForm : DesignableForm
    {
        public TestForm()
        {
            InitializeComponent();
            
            pitchTrackBar.Minimum = -15;
            pitchTrackBar.Maximum = 15;
           

            rollTrackBar.Minimum = -15;
            rollTrackBar.Maximum = 15;
            


        }
        protected override Label PitchLabel => this.pitchLabel;
        protected override Label RollLabel => this.rollLabel;

        protected override bool IsDataInDegrees => true;


        protected override string UdpIp => "127.0.0.1";
        protected override int UdpPort => 6000;
        protected override string SourceIp => "127.0.0.1";
        protected override int SourcePort => 11000;

        protected override (float, float) GetSensorData()
        {
            float pitchDeg = pitchTrackBar.Value;
            float rollDeg = rollTrackBar.Value;

            Debug.WriteLine($"pitchDeg: {pitchDeg}");
            Debug.WriteLine($"maxPitch: {pitchTrackBar.Maximum}");


            return (pitchDeg, rollDeg);
        }

        private void pitchTrackBar_Scroll(object sender, EventArgs e)
        {
            
            UpdateData();
        }

        private void rollTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            SendPacket(6);
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            

            readyActive = !readyActive;

            if (readyActive)
            {
                readyBtn.Text = "Ready(ON)";
                Debug.WriteLine("Continuous motion update: ON");
            }
            else
            {
                readyBtn.Text = "Ready";
                Debug.WriteLine("Continuous motion update: OFF");
            }
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            pitchTrackBar.Value = 0;
            rollTrackBar.Value = 0;
            UpdateData();
            SendPacket(7);
        }
    }
}
