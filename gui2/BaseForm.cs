using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui2
{
    public abstract class BaseForm : Form
    {
        protected float pitchDeg = 0f;
        protected float rollDeg = 0f;
        protected bool readyActive = false;

        protected virtual bool IsDataInDegrees => false;



        protected abstract Label PitchLabel { get; }
        protected abstract Label RollLabel { get; }


        protected abstract string UdpIp { get; }
        protected abstract int UdpPort { get; }
        protected abstract string SourceIp { get; }
        protected abstract int SourcePort { get; }

        protected abstract (float pitchRaw, float rollRaw) GetSensorData();

        protected void UpdateData()
        {
            try
            {
                var (pitchRaw, rollRaw) = GetSensorData();
                Debug.WriteLine($"update pitch:{pitchRaw}");
                float pitchRad = 0f,rollRad = 0f;

                if (IsDataInDegrees)
                {
                    
                    pitchRad = pitchRaw * ((float)Math.PI / 180f); // deg → rad
                    rollRad = rollRaw * ((float)Math.PI / 180f);
                    Debug.WriteLine($"update rad pitch:{pitchRad}");
                }
                pitchDeg = Math.Max(Math.Min(pitchRad, 15f), -15f);
                rollDeg = Math.Max(Math.Min(rollRad, 15f), -15f);

                PitchLabel.Text = $"Pitch: {pitchRaw:F2}°";
                RollLabel.Text = $"Roll: {rollRaw:F2}°";

                if (readyActive)
                {
                    Debug.WriteLine("ready");
                    float[] dofs = new float[6] { pitchDeg, rollDeg, 0f, 0f, 0f, 0f };
                    byte[] packet = CreatePacket(9, dofs);
                    SendPacketOnce(packet);
                }
            }
            catch (Exception ex)
            {
                PitchLabel.Text = "Pitch: ERROR";
                RollLabel.Text = "Roll: ERROR";
                Console.WriteLine("UpdateData() Error: " + ex.Message);
            }
        }

        protected byte[] CreatePacket(byte cmd, float[] dof = null)
        {
            byte ID = 55;
            byte SubCmd = 0;
            byte FileNum = 0;
            byte CyChoose = 0;
            byte DO = 0;
            byte JogSpeed = 0;
            ushort padding = 0;

            float[] DOFS = dof ?? new float[6];
            float[] Amp = new float[6];
            float[] Fre = new float[6];
            float[] Pha = new float[6];
            float[] Pos = new float[6];
            float[] Spd = new float[6];
            float[] Vxyz = new float[3];
            float[] Axyz = new float[3];

            uint Time = (uint)(DateTimeOffset.Now.ToUnixTimeSeconds() & 0xFFFFFFFF);

            List<byte> bytes = new List<byte>
        {
            ID, cmd, SubCmd, FileNum, CyChoose, DO, JogSpeed
        };
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

        protected void SendPacketOnce(byte[] packet)
        {

            try
            {
                using (UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse(SourceIp), SourcePort)))
                {
                    udpClient.Send(packet, packet.Length, new IPEndPoint(IPAddress.Parse(UdpIp), UdpPort));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SendPacketOnce error: " + ex.Message);
            }
        }
        protected void SendPacket(byte cmd, float[] dof = null)
        {
            try
            {
                using (UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse(SourceIp), SourcePort)))
                {
                    IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(UdpIp), UdpPort);

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

        // NOTE: pitchLabel และ rollLabel ควรมีในฟอร์มลูก และตั้งชื่อเหมือนกัน
    }
}


