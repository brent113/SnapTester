using System;
using System.Collections.Generic;
using System.Linq;

namespace SnapTester
{
	// Token: 0x0200000D RID: 13
	public class ProtocalV1
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public byte[] SetupPack(byte[] SrcData)
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
			if (SrcData != null)
			{
				SendBuff.AddRange(SrcData);
			}
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
			return SendBuff.ToArray();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C3C File Offset: 0x00000E3C
		public int Parse(List<byte> SrcData, out byte[] DstData)
		{
			int ret_len = -1;
			DstData = null;
			while (SrcData.Count > 7)
			{
				if (SrcData[0] != 170)
				{
					SrcData.RemoveAt(0);
				}
				else if (SrcData[1] != 85)
				{
					SrcData.RemoveRange(0, 2);
				}
				else
				{
					byte cmd_len0 = SrcData[2];
					byte cmd_len = SrcData[3];
					byte cmd_len_check = SrcData[5];
					if ((cmd_len0 ^ cmd_len) != cmd_len_check)
					{
						SrcData.RemoveRange(0, 2);
					}
					else
					{
						int data_len = (int)cmd_len0 << 8 | (int)cmd_len;
						if (data_len > 2048)
						{
							SrcData.RemoveRange(0, 2);
						}
						else
						{
							if (data_len + 8 > SrcData.Count)
							{
								break;
							}
							byte[] parse_data = new byte[data_len + 8];
							Array.Copy(SrcData.ToArray(), 0, parse_data, 0, parse_data.Count<byte>());
							SrcData.RemoveRange(0, data_len + 8);
							uint Checksum = 0u;
							for (int i = 0; i < data_len - 1; i += 2)
							{
								Checksum += (uint)((int)parse_data[8 + i] << 8 | (int)parse_data[9 + i]);
							}
							if (data_len % 2 != 0)
							{
								Checksum += (uint)parse_data[parse_data.Count<byte>() - 1];
							}
							while (Checksum > 65535u)
							{
								Checksum = (Checksum >> 16 & 65535u) + (Checksum & 65535u);
							}
							Checksum = ~Checksum;
							if ((ulong)(Checksum & 65535u) != (ulong)((long)((int)parse_data[6] << 8 | (int)parse_data[7])))
							{
							}
							byte[] ret_bytes = new byte[data_len];
							Array.Copy(parse_data, 8, ret_bytes, 0, ret_bytes.Count<byte>());
							DstData = ret_bytes;
							ret_len = data_len;
							break;
						}
					}
				}
			}
			return ret_len;
		}
	}
}
