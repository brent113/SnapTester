using System;
using System.Linq;

namespace SnapTester
{
	// Token: 0x02000021 RID: 33
	public class clsDebugtest : BaseProtocal
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00012F74 File Offset: 0x00011174
		public void Parse(byte[] SrcData)
		{
			this.LastOpCode = SrcData[1];
			switch (SrcData[1])
			{
			case 1:
			case 3:
			case 5:
				base.GeneralReackParse(SrcData, false);
				break;
			case 2:
			{
				int Count = (SrcData.Count<byte>() - 1) / 4;
				this.LinearModuleLead = new float[Count];
				this.LinearModuleMacID = new uint[Count];
				break;
			}
			case 4:
			{
				int Count = (SrcData.Count<byte>() - 1) / 8;
				this.LinearModuleLength = new uint[Count];
				this.LinearModuleMacID = new uint[Count];
				for (int i = 0; i < Count; i++)
				{
					int j = i * 8;
					this.LinearModuleMacID[i] = (uint)((int)SrcData[j + 2] << 24 | (int)SrcData[j + 3] << 16 | (int)SrcData[j + 4] << 8 | (int)SrcData[j + 5]);
					uint u32_temp = (uint)((int)SrcData[j + 6] << 24 | (int)SrcData[j + 7] << 16 | (int)SrcData[j + 8] << 8 | (int)SrcData[j + 9]);
					this.LinearModuleLength[i] = (uint)(u32_temp / 1000f);
					this.LinearModuleMacID[i] = this.LinearModuleMacID[i] >> 1;
				}
				break;
			}
			case 6:
			{
				int Count = (SrcData.Count<byte>() - 1) / 8;
				this.LinearModuleLead = new float[Count];
				this.LinearModuleMacID = new uint[Count];
				for (int i = 0; i < Count; i++)
				{
					int j = i * 8;
					this.LinearModuleMacID[i] = (uint)((int)SrcData[j + 2] << 24 | (int)SrcData[j + 3] << 16 | (int)SrcData[j + 4] << 8 | (int)SrcData[j + 5]);
					uint u32_temp = (uint)((int)SrcData[j + 6] << 24 | (int)SrcData[j + 7] << 16 | (int)SrcData[j + 8] << 8 | (int)SrcData[j + 9]);
					this.LinearModuleLead[i] = u32_temp / 1000f;
					this.LinearModuleMacID[i] = this.LinearModuleMacID[i] >> 1;
				}
				break;
			}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00013140 File Offset: 0x00011340
		public uint GetModuleLength(int Index)
		{
			return this.LinearModuleLength[Index];
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001315C File Offset: 0x0001135C
		public float GetModuleLead(int Index)
		{
			return this.LinearModuleLead[Index];
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00013178 File Offset: 0x00011378
		public uint GetModuleMacID(int Index)
		{
			return this.LinearModuleMacID[Index];
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00013194 File Offset: 0x00011394
		public int GetModuleCount()
		{
			int result;
			if (this.LinearModuleMacID != null)
			{
				result = this.LinearModuleMacID.Count<uint>();
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000131C4 File Offset: 0x000113C4
		public byte GetLastOpcode()
		{
			return this.LastOpCode;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000131DC File Offset: 0x000113DC
		public void ClearLinearModuleInfo()
		{
			this.LinearModuleLead = null;
			this.LinearModuleLength = null;
			this.LinearModuleMacID = null;
		}

		// Token: 0x0400016C RID: 364
		private uint[] LinearModuleLength;

		// Token: 0x0400016D RID: 365
		private float[] LinearModuleLead;

		// Token: 0x0400016E RID: 366
		private uint[] LinearModuleMacID;

		// Token: 0x0400016F RID: 367
		private byte LastOpCode;
	}
}
