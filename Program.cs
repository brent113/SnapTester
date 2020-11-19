using System;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000020 RID: 32
	internal static class Program
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00012F4E File Offset: 0x0001114E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
