using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000010 RID: 16
	public class Update
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00003738 File Offset: 0x00001938
		public bool OpenFile()
		{
			this.FileBuff = null;
			this.Packs = 0;
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "BIN|*.bin";
			ofd.ShowDialog();
			bool result;
			if (ofd.FileName == "")
			{
				result = false;
			}
			else
			{
				this.UpdateFileName = ofd.FileName;
				FileInfo fi = new FileInfo(this.UpdateFileName);
				this.FileBuff = new byte[fi.Length];
				BinaryReader BR = new BinaryReader(new FileStream(this.UpdateFileName, FileMode.Open));
				BR.Read(this.FileBuff, 0, this.FileBuff.Count<byte>());
				BR.Close();
				this.Packs = (ushort)(this.FileBuff.Count<byte>() / 512);
				if (this.FileBuff.Count<byte>() % 512 != 0)
				{
					this.Packs += 1;
				}
				if (this.FileBuff[0] == 0)
				{
					this.FirmwareType = "MainBoard";
				}
				else if (this.FileBuff[0] == 1)
				{
					this.FirmwareType = "Module";
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003870 File Offset: 0x00001A70
		public void ParseByteBuff(byte[] Buff)
		{
			this.FileBuff = new byte[Buff.Count<byte>()];
			Array.Copy(Buff, 0, this.FileBuff, 0, Buff.Count<byte>());
			this.Packs = (ushort)(this.FileBuff.Count<byte>() / 512);
			if (this.FileBuff.Count<byte>() % 512 != 0)
			{
				this.Packs += 1;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000038E4 File Offset: 0x00001AE4
		public byte[] GetUpdatePack(ushort PackIndex)
		{
			byte[] result;
			if (this.FileBuff == null)
			{
				result = null;
			}
			else if (PackIndex >= this.Packs)
			{
				result = null;
			}
			else
			{
				byte[] Result;
				if (PackIndex == this.Packs - 1)
				{
					if (this.FileBuff.Count<byte>() % 512 == 0)
					{
						Result = new byte[512];
					}
					else
					{
						Result = new byte[this.FileBuff.Count<byte>() % 512];
					}
				}
				else
				{
					Result = new byte[512];
				}
				Array.Copy(this.FileBuff, (int)(PackIndex * 512), Result, 0, Result.Count<byte>());
				result = Result;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000039A0 File Offset: 0x00001BA0
		public string GetVersion()
		{
			List<byte> lVersion = new List<byte>();
			for (int i = 0; i < 32; i++)
			{
				lVersion.Add(this.FileBuff[i + 5]);
				if (this.FileBuff[i + 5] == 0)
				{
					break;
				}
			}
			return Encoding.Default.GetString(lVersion.ToArray());
		}

		// Token: 0x0400002F RID: 47
		private string UpdateFileName = "";

		// Token: 0x04000030 RID: 48
		public ushort Packs = 0;

		// Token: 0x04000031 RID: 49
		private byte[] FileBuff;

		// Token: 0x04000032 RID: 50
		public string FirmwareType = "";
	}
}
