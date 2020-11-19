using System;
using System.Text;

namespace SnapTester
{
	// Token: 0x0200000B RID: 11
	public class clsGcodePhaser
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public string GetString(byte[] bValue, int Index, int Len)
		{
			return Encoding.Default.GetString(bValue, Index, Len);
		}
	}
}
