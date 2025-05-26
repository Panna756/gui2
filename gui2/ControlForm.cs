using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;




namespace gui2
{
    public partial class ControlForm : Form
    {
        private bool readyActive = false;
        private string udpIp = "192.168.0.125";
        private int udpPort = 5000;
        private string sourceIp = "192.168.0.131";
        private int sourcePort = 10000;
        public ControlForm()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            //timer.Interval = 10; // 10ms
            //timer.Tick += (s, e) => UpdateData();
            //timer.Start();

        }
        private void UpdateData()
        {
            try
            {
                // สมมติคุณมีตัวแปร pitchRad / rollRad มาจากเซนเซอร์หรือ SimConnect
                float pitchRad = 0.0f;
                float rollRad = 0.0f;

                float pitchDeg = -pitchRad * (180f / (float)Math.PI);
                float rollDeg = -rollRad * (180f / (float)Math.PI);

                // Limit ±15°
                pitchDeg = Math.Max(Math.Min(pitchDeg, 15f), -15f);
                rollDeg = Math.Max(Math.Min(rollDeg, 15f), -15f);

                // อัปเดต UI
                pitchLabel.Text = $"Pitch: {pitchDeg:F2}°";
                rollLabel.Text = $"Roll: {rollDeg:F2}°";

                // ถ้าเปิด Ready Mode → ส่งแพ็กเกจแบบ real-time
                if (readyActive)
                {
                    float[] dofs = new float[6] { pitchDeg, rollDeg, 0f, 0f, 0f, 0f };
                    byte[] packet = CreatePacket(9, dofs);
                    SendPacketOnce(packet);
                }
            }
            catch (Exception ex)
            {
                pitchLabel.Text = "Pitch: ERROR";
                rollLabel.Text = "Roll: ERROR";
                Console.WriteLine("UpdateData() Error: " + ex.Message);
            }
        }
        private byte[] CreatePacket(byte cmd, float[] dof = null)
        {
            byte ID = 55;
            byte SubCmd = 0;
            byte FileNum = 0;
            byte CyChoose = 0;
            byte DO = 0;
            byte JogSpeed = 0;
            ushort padding = 0; // สำหรับ alignment

            float[] DOFS = dof ?? new float[6];  // [0,0,0,0,0,0]
            float[] Amp = new float[6];
            float[] Fre = new float[6];
            float[] Pha = new float[6];
            float[] Pos = new float[6];
            float[] Spd = new float[6];
            float[] Vxyz = new float[3];
            float[] Axyz = new float[3];

            uint Time = (uint)(DateTimeOffset.Now.ToUnixTimeSeconds() & 0xFFFFFFFF);

            List<byte> bytes = new List<byte>();

            // เพิ่มค่าตามฟอร์แมต Python: '<B B B B B B H 6f 6f 6f 6f 6f 6f 3f 3f I'
            bytes.Add(ID);
            bytes.Add(cmd);
            bytes.Add(SubCmd);
            bytes.Add(FileNum);
            bytes.Add(CyChoose);
            bytes.Add(DO);
            bytes.Add(JogSpeed);
            bytes.AddRange(BitConverter.GetBytes(padding));

            void AddFloatArray(float[] arr)
            {
                foreach (var f in arr)
                    bytes.AddRange(BitConverter.GetBytes(f));
            }

            AddFloatArray(DOFS);
            AddFloatArray(Amp);
            AddFloatArray(Fre);
            AddFloatArray(Pha);
            AddFloatArray(Pos);
            AddFloatArray(Spd);
            AddFloatArray(Vxyz);
            AddFloatArray(Axyz);

            bytes.AddRange(BitConverter.GetBytes(Time));

            return bytes.ToArray();
        }
        private void SendPacket(byte cmd, float[] dof = null)
        {
            try
            {
                using (UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse(sourceIp), sourcePort)))
                {
                    IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(udpIp), udpPort);

                    for (int i = 0; i < 5; i++)
                    {
                        byte[] packet = CreatePacket(cmd, dof);
                        udpClient.Send(packet, packet.Length, remoteEP);
                        System.Threading.Thread.Sleep(50); // delay 50ms
                    }

                    Debug.WriteLine("All packets sent.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SendPackets error: " + ex.Message);
            }


        }
        private void SendPacketOnce(byte[] packet)
        {

            try
            {
                using (UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse(sourceIp), sourcePort)))
                {
                    udpClient.Send(packet, packet.Length, new IPEndPoint(IPAddress.Parse(udpIp), udpPort));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SendPacketOnce error: " + ex.Message);
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
                readyBtn.Text = "Ready (ON)";
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
    }
}
