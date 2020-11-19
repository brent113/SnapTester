using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000005 RID: 5
	public class clsWifi : BaseProtocal
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000022A8 File Offset: 0x000004A8
		public void WifiParse(byte[] SrcData)
		{
			switch (SrcData[1])
			{
			case 1:
			case 5:
				base.GeneralReackParse(SrcData, true);
				break;
			case 2:
				if (SrcData[2] == 0)
				{
					this.IPParse(SrcData);
					MessageBox.Show(string.Concat(new string[]
					{
						this.SSID,
						" ",
						this.Password,
						" ",
						this.IP
					}));
				}
				else if (SrcData[2] == 1)
				{
					MessageBox.Show("未连接成功！", this.SSID + " " + this.Password);
				}
				else if (SrcData[2] == 2)
				{
					MessageBox.Show("模块异常！");
				}
				break;
			case 6:
				if (SrcData[2] == 0)
				{
					this.NameParse(SrcData);
					MessageBox.Show("Name:" + this.BluetoothName);
				}
				else if (SrcData[2] == 1)
				{
					MessageBox.Show("未设置名字");
				}
				else if (SrcData[2] == 2)
				{
					MessageBox.Show("模块异常！");
				}
				break;
			case 7:
				MessageBox.Show(this.MacParse(SrcData));
				break;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000240C File Offset: 0x0000060C
		private void IPParse(byte[] Data)
		{
			try
			{
				byte[] bValue = new byte[Data.Count<byte>() - 5];
				string[] strValue = new string[3];
				int i = 3;
				for (int j = 0; j < 3; j++)
				{
					int k;
					for (k = 0; k < 32; k++)
					{
						bValue[k] = Data[i++];
						if (bValue[k] == 0)
						{
							break;
						}
					}
					byte[] newBytes = new byte[k];
					Array.Copy(bValue, 0, newBytes, 0, k);
					strValue[j] = Encoding.Default.GetString(newBytes);
				}
				this.SSID = strValue[0];
				this.Password = strValue[1];
				this.IP = strValue[2];
			}
			catch
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000024D4 File Offset: 0x000006D4
		private string MacParse(byte[] Data)
		{
			string string_res = "";
			for (int i = 0; i < 6; i++)
			{
				string_res += Data[i + 3].ToString("X2");
				if (i != 5)
				{
					string_res += "-";
				}
			}
			return string_res;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002530 File Offset: 0x00000730
		private void NameParse(byte[] Data)
		{
			try
			{
				byte[] bValue = new byte[Data.Count<byte>() - 2];
				int i = 3;
				int j;
				for (j = 0; j < 32; j++)
				{
					bValue[j] = Data[i++];
					if (bValue[j] == 0)
					{
						break;
					}
				}
				byte[] newBytes = new byte[j];
				Array.Copy(bValue, 0, newBytes, 0, j);
				this.BluetoothName = Encoding.Default.GetString(newBytes);
			}
			catch
			{
			}
		}

		// Token: 0x04000008 RID: 8
		public string IP;

		// Token: 0x04000009 RID: 9
		public string SSID;

		// Token: 0x0400000A RID: 10
		public string Password;

		// Token: 0x0400000B RID: 11
		public string BluetoothName;
	}
}
