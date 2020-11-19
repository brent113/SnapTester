using System;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000004 RID: 4
	public class BaseProtocal
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000222C File Offset: 0x0000042C
		public byte GeneralReackParse(byte[] SrcData, bool ShowMessage)
		{
			if (ShowMessage)
			{
				if (SrcData[2] == 0)
				{
					MessageBox.Show(this.MsgList.GetMessage(SrcData[0], SrcData[1]) + " Success");
				}
				else
				{
					MessageBox.Show(this.MsgList.GetMessage(SrcData[0], SrcData[1]) + " Fail");
				}
			}
			return SrcData[2];
		}

		// Token: 0x04000005 RID: 5
		private MessageList MsgList = new MessageList();

		// Token: 0x04000006 RID: 6
		public byte OpCode;

		// Token: 0x04000007 RID: 7
		public byte Result;
	}
}
