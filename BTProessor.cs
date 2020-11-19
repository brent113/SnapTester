using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000022 RID: 34
	public class BTProessor
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0001320C File Offset: 0x0001140C
		public void SendStartUpdate(clsComm CommPort)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "BIN|*.bin";
			ofd.ShowDialog();
			string file_name = ofd.FileName;
			if (!(file_name == ""))
			{
				BinaryFile update_file = new BinaryFile();
				this.UpdateBuff = update_file.ReadToBuffer(file_name);
				this.total_packs = (ushort)(this.UpdateBuff.Count<byte>() / 512);
				if (this.UpdateBuff.Count<byte>() % 512 != 0)
				{
					this.total_packs += 1;
				}
				if (this.UpdateBuff != null)
				{
					ProtocalV1 protocalV = this.protocal_v1;
					byte[] array = new byte[2];
					array[0] = 15;
					byte[] Data = protocalV.SetupPack(array);
					CommPort.SendData(Data);
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000132DC File Offset: 0x000114DC
		public void SendUpdatePack(clsComm CommPort, ushort PackIndex)
		{
			if (this.UpdateBuff != null)
			{
				if (PackIndex > this.total_packs - 1)
				{
					this.SendEndUpdate(CommPort);
				}
				else
				{
					List<byte> update_data = new List<byte>();
					int take_len = 512;
					if (PackIndex == this.total_packs - 1)
					{
						if (this.UpdateBuff.Count<byte>() % 512 != 0)
						{
							take_len = this.UpdateBuff.Count<byte>() % 512;
						}
					}
					update_data.Add(15);
					update_data.Add(1);
					update_data.AddRange(this.UpdateBuff.Skip((int)(PackIndex * 512)).Take(take_len));
					byte[] Data = this.protocal_v1.SetupPack(update_data.ToArray());
					CommPort.SendData(Data);
				}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000133B4 File Offset: 0x000115B4
		private void SendEndUpdate(clsComm CommPort)
		{
			if (this.UpdateBuff != null)
			{
				byte[] Data = this.protocal_v1.SetupPack(new byte[]
				{
					15,
					2
				});
				CommPort.SendData(Data);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000133F8 File Offset: 0x000115F8
		public void SendSetName(clsComm CommPort, string Name)
		{
			if (!(Name == ""))
			{
				List<byte> list_buff = new List<byte>();
				byte[] byte_name = Encoding.Default.GetBytes(Name);
				list_buff.Add(17);
				list_buff.Add(0);
				list_buff.AddRange(byte_name);
				byte[] Data = this.protocal_v1.SetupPack(list_buff.ToArray());
				CommPort.SendData(Data);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00013460 File Offset: 0x00011660
		public void SendTestData(clsComm CommPort, byte[] DataToSend)
		{
			List<byte> list_buff = new List<byte>();
			list_buff.AddRange(DataToSend);
			byte[] Data = this.protocal_v1.SetupPack(list_buff.ToArray());
			CommPort.SendData(Data);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00013498 File Offset: 0x00011698
		public ushort GetTotalPacks()
		{
			return this.total_packs;
		}

		// Token: 0x04000170 RID: 368
		private ProtocalV1 protocal_v1 = new ProtocalV1();

		// Token: 0x04000171 RID: 369
		private byte[] UpdateBuff;

		// Token: 0x04000172 RID: 370
		private ushort total_packs;
	}
}
