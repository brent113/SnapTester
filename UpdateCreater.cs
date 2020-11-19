using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000028 RID: 40
	public class UpdateCreater
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00013FE8 File Offset: 0x000121E8
		public bool OpenOriginFile(byte Type, bool ForceBit)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.FileName = "";
			ofd.Filter = "BIN|*.bin";
			ofd.ShowDialog();
			bool result;
			if (ofd.FileName == "")
			{
				result = false;
			}
			else
			{
				string FileName = ofd.FileName;
				BinaryReader BR = new BinaryReader(new FileStream(FileName, FileMode.Open));
				FileInfo FI = new FileInfo(FileName);
				byte[] SrcBuff = new byte[FI.Length];
				BR.Read(SrcBuff, 0, SrcBuff.Count<byte>());
				BR.Close();
				this.FileBuff = new byte[SrcBuff.Count<byte>() + 2048];
				int i = 0;
				this.FileBuff[i++] = Type;
				ushort StartID = 0;
				ushort EndID = 20;
				this.FileBuff[i++] = (byte)(StartID >> 8);
				this.FileBuff[i++] = (byte)StartID;
				this.FileBuff[i++] = (byte)(EndID >> 8);
				this.FileBuff[i++] = (byte)EndID;
				byte[] bVersion = Encoding.Default.GetBytes(string.Concat(new string[]
				{
					"Snapmaker_",
					DateTime.Now.Year.ToString("D2"),
					"-",
					DateTime.Now.Month.ToString("D2"),
					"-",
					DateTime.Now.Day.ToString("D2"),
					"-",
					DateTime.Now.Hour.ToString("D2"),
					DateTime.Now.Minute.ToString("D2")
				}));
				byte[] tmpVersion = new byte[33];
				for (int j = 0; j < tmpVersion.Count<byte>(); j++)
				{
					tmpVersion[j] = 0;
				}
				int VersionLen;
				if (bVersion.Count<byte>() >= 31)
				{
					VersionLen = 31;
				}
				else
				{
					VersionLen = bVersion.Count<byte>();
				}
				Array.Copy(bVersion, 0, this.FileBuff, i, VersionLen);
				i += VersionLen;
				i = 40;
				this.FileBuff[i++] = (byte)SrcBuff.Count<byte>();
				this.FileBuff[i++] = (byte)(SrcBuff.Count<byte>() >> 8);
				this.FileBuff[i++] = (byte)(SrcBuff.Count<byte>() >> 16);
				this.FileBuff[i++] = (byte)(SrcBuff.Count<byte>() >> 24);
				i = 44;
				uint Checksum = 0u;
				for (int j = 0; j < SrcBuff.Count<byte>(); j++)
				{
					Checksum += (uint)SrcBuff[j];
				}
				this.FileBuff[i++] = (byte)Checksum;
				this.FileBuff[i++] = (byte)(Checksum >> 8);
				this.FileBuff[i++] = (byte)(Checksum >> 16);
				this.FileBuff[i++] = (byte)(Checksum >> 24);
				uint UpdateFlag = 0u;
				if (ForceBit)
				{
					UpdateFlag |= 1u;
				}
				this.FileBuff[i++] = (byte)(UpdateFlag >> 24);
				this.FileBuff[i++] = (byte)(UpdateFlag >> 16);
				this.FileBuff[i++] = (byte)(UpdateFlag >> 8);
				this.FileBuff[i++] = (byte)UpdateFlag;
				Array.Copy(SrcBuff, 0, this.FileBuff, 2048, SrcBuff.Count<byte>());
				result = true;
			}
			return result;
		}

		// Token: 0x04000182 RID: 386
		public byte[] FileBuff;
	}
}
