using System;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000006 RID: 6
	public class clsLightBar : BaseProtocal
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000025BC File Offset: 0x000007BC
		public clsLightBar()
		{
			this.LightData = new LightbarData();
			this.LightData.Brightness = byte.MaxValue;
			this.LightData.IsValid = false;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000025F0 File Offset: 0x000007F0
		public void Parse(byte[] SrcData)
		{
			switch (SrcData[1])
			{
			case 1:
				if (SrcData[2] == 0)
				{
					this.LightData.IsValid = true;
				}
				else
				{
					this.LightData.IsValid = false;
				}
				if (SrcData[3] == 0)
				{
					this.LightData.Onoff = false;
				}
				else
				{
					this.LightData.Onoff = true;
				}
				this.LightData.Mode = SrcData[4];
				this.LightData.Brightness = SrcData[5];
				if (!this.LightData.IsValid)
				{
					MessageBox.Show("Light bar invalid!");
				}
				break;
			case 2:
				base.GeneralReackParse(SrcData, true);
				break;
			case 3:
				base.GeneralReackParse(SrcData, true);
				break;
			}
		}

		// Token: 0x0400000C RID: 12
		public LightbarData LightData;
	}
}
