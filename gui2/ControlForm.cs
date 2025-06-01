using gui2;
using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct PlaneAttitude
{
    public double pitch;
    public double bank;
}


namespace gui2
{
    public partial class ControlForm : DesignableForm
    {
        private float pitchRad = 0f;
        private float rollRad = 0f;

        protected override (float, float) GetSensorData() => (pitchRad, rollRad);

        protected override Label PitchLabel => this.pitchLabel;
        protected override Label RollLabel => this.rollLabel;

        protected override string UdpIp => "192.168.0.125";
        protected override int UdpPort => 5000;
        protected override string SourceIp => "192.168.0.131";
        protected override int SourcePort => 10000;

        //simconnect
        private SimConnect? simconnect;
        const int WM_USER_SIMCONNECT = 0x0402;

        //รับค่าจาก sim
        enum DEFINITIONS { PlaneAttitude }
        enum DATA_REQUESTS { RequestAttitude }


        public ControlForm()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    SetupSimConnect();
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 100 };
                    timer.Tick += (s, e) =>
                    {
                        simconnect.RequestDataOnSimObject(
                            DATA_REQUESTS.RequestAttitude,
                            DEFINITIONS.PlaneAttitude,
                            SimConnect.SIMCONNECT_OBJECT_ID_USER,
                            SIMCONNECT_PERIOD.ONCE,
                            SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,
                            0, // origin
                            0, // interval
                            0  // limit
                        );
                    };
                    timer.Start();
                    Debug.WriteLine("SimConnect connected!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SimConnect connection failed:\n" + ex.Message);
                }
            }
        }

        private void SetupSimConnect()
        {
            simconnect = new SimConnect("MyApp", this.Handle, WM_USER_SIMCONNECT, null, 0);
            simconnect.AddToDataDefinition(DEFINITIONS.PlaneAttitude, "PLANE PITCH DEGREES", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.PlaneAttitude, "PLANE BANK DEGREES", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.RegisterDataDefineStruct<PlaneAttitude>(DEFINITIONS.PlaneAttitude);
            simconnect.OnRecvSimobjectData += Simconnect_OnRecvSimobjectData;

        }
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
                simconnect?.ReceiveMessage();
            else
                base.DefWndProc(ref m);
        }

        private void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            if ((DATA_REQUESTS)data.dwRequestID == DATA_REQUESTS.RequestAttitude)
            {
                object[] values = (object[])data.dwData;

                PlaneAttitude att = new PlaneAttitude
                {
                    pitch = (double)values[0],
                    bank = (double)values[1]
                };

                pitchRad = (float)(att.pitch * Math.PI / 180.0);
                rollRad = (float)(att.bank * Math.PI / 180.0);
                UpdateData();
            }
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            SendPacket(6);

        }


        private void stopBtn_Click(object sender, EventArgs e)
        {
            SendPacket(7);
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

        private void middleBtn_Click(object sender, EventArgs e)
        {
            SendPacket(2);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
