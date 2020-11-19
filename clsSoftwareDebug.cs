using System;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000027 RID: 39
	public class clsSoftwareDebug
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00013FA4 File Offset: 0x000121A4
		public bool Parse(byte[] ScrData)
		{
			switch (ScrData[1])
			{
			case 0:
				MessageBox.Show("Power loss triggle!");
				break;
			}
			return true;
		}
	}
}
