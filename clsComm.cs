using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;

namespace SnapTester
{
	// Token: 0x02000008 RID: 8
	public class clsComm
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000026C4 File Offset: 0x000008C4
		public clsComm()
		{
			this.ProcessBuff = new List<byte>();
			ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.SerialDataProcess), null);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000271C File Offset: 0x0000091C
		public string[] GetPorts()
		{
			return SerialPort.GetPortNames();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002738 File Offset: 0x00000938
		public bool OpenPort(string PortName)
		{
			bool result;
			if (this.spPort.IsOpen)
			{
				this.spPort.Close();
				result = true;
			}
			else
			{
				try
				{
					this.spPort.PortName = PortName;
					this.spPort.ReadBufferSize = 20480;
					this.spPort.Open();
					this.spPort.DataReceived += this.spPort_DataReceived;
					result = true;
				}
				catch
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000027CC File Offset: 0x000009CC
		public void SendData(byte[] Datas)
		{
			try
			{
				this.spPort.Write(Datas, 0, Datas.Count<byte>());
			}
			catch
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002808 File Offset: 0x00000A08
		public void SendProtocalData(byte[] Datas)
		{
			List<byte> SendBuff = new List<byte>();
			SendBuff.Add(170);
			SendBuff.Add(85);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.AddRange(Datas);
			SendBuff[2] = (byte)(SendBuff.Count - 8 >> 8);
			SendBuff[3] = (byte)(SendBuff.Count - 8);
			SendBuff[5] = (byte)(SendBuff[2] ^ SendBuff[3]);
			uint Checksum = 0u;
			for (int i = 8; i < SendBuff.Count - 1; i += 2)
			{
				Checksum += (uint)((int)SendBuff[i] << 8 | (int)SendBuff[i + 1]);
			}
			if ((SendBuff.Count - 8) % 2 != 0)
			{
				Checksum += (uint)SendBuff[SendBuff.Count - 1];
			}
			while (Checksum > 65535u)
			{
				Checksum = (Checksum >> 16 & 65535u) + (Checksum & 65535u);
			}
			Checksum = ~Checksum;
			SendBuff[6] = (byte)(Checksum >> 8);
			SendBuff[7] = (byte)Checksum;
			try
			{
				this.spPort.Write(SendBuff.ToArray(), 0, SendBuff.Count);
			}
			catch
			{
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002964 File Offset: 0x00000B64
		private void spPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			int Len = this.spPort.BytesToRead;
			byte[] tmpBytes = new byte[Len];
			this.spPort.Read(tmpBytes, 0, Len);
			this.mtxSerialBuff.WaitOne();
			this.ProcessBuff.AddRange(tmpBytes);
			this.mtxSerialBuff.ReleaseMutex();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029BC File Offset: 0x00000BBC
		private void SerialDataProcess(object obj)
		{
			ProtocalV1 protocal_v = new ProtocalV1();
			for (;;)
			{
				if (this.ProcessBuff.Count >= 8)
				{
					this.mtxSerialBuff.WaitOne();
					if (protocal_v.Parse(this.ProcessBuff, out this.ParseData) > 0)
					{
						if (this.evOnDataReceive != null)
						{
							this.evOnDataReceive(this, null);
						}
					}
					this.mtxSerialBuff.ReleaseMutex();
				}
				else
				{
					Thread.Sleep(5);
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A48 File Offset: 0x00000C48
		public byte[] GetParsedData()
		{
			byte[] retvale = this.ParseData;
			this.ParseData = null;
			return retvale;
		}

		// Token: 0x04000011 RID: 17
		private Mutex mtxSerialBuff = new Mutex();

		// Token: 0x04000012 RID: 18
		private List<byte> ProcessBuff = new List<byte>();

		// Token: 0x04000013 RID: 19
		private SerialPort spPort = new SerialPort();

		// Token: 0x04000014 RID: 20
		private byte[] ParseData;

		// Token: 0x04000015 RID: 21
		public EventHandler evOnDataReceive;
	}
}
