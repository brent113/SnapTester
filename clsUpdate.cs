using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnapTester
{
	// Token: 0x02000002 RID: 2
	public class clsUpdate
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002074 File Offset: 0x00000274
		public void ParseModuleVersion(byte[] Data)
		{
			uint ID = (uint)((int)Data[2] << 24 | (int)Data[3] << 16 | (int)Data[4] << 8 | (int)Data[5]);
			byte[] bVersion = new byte[Data.Count<byte>() - 7];
			Array.Copy(Data, 6, bVersion, 0, bVersion.Count<byte>());
			string newVersion = Encoding.Default.GetString(bVersion);
			this.ModuleID.Add(ID);
			this.ModuleVersion.Add(newVersion);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020DE File Offset: 0x000002DE
		public void ClearItems()
		{
			this.ModuleVersion.Clear();
			this.ModuleID.Clear();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020FC File Offset: 0x000002FC
		public string[] ToStringArray()
		{
			string[] strResult = new string[this.ModuleID.Count];
			for (int i = 0; i < this.ModuleID.Count; i++)
			{
				strResult[i] = this.ModuleID[i].ToString("X8") + " - " + this.ModuleVersion[i];
			}
			return strResult;
		}

		// Token: 0x04000001 RID: 1
		private List<string> ModuleVersion = new List<string>();

		// Token: 0x04000002 RID: 2
		private List<uint> ModuleID = new List<uint>();
	}
}
