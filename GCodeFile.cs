using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000029 RID: 41
	public class GCodeFile
	{
		// Token: 0x06000121 RID: 289 RVA: 0x000143A8 File Offset: 0x000125A8
		public bool Load()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "GCODE CNC NC|*.Gcode;*.CNC;*.NC";
			ofd.ShowDialog();
			bool result;
			if (ofd.FileName == "")
			{
				result = false;
			}
			else
			{
				this.FileName = ofd.FileName;
				List<string> list_file_line = new List<string>();
				StreamReader SR = new StreamReader(new FileStream(this.FileName, FileMode.Open));
				for (;;)
				{
					string tmp = SR.ReadLine();
					if (tmp == null)
					{
						break;
					}
					list_file_line.Add(tmp + "\r\n");
				}
				SR.Close();
				SR.Dispose();
				this.FileLines = list_file_line.ToArray();
				result = true;
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00014464 File Offset: 0x00012664
		public string[] GetFileLines()
		{
			return this.FileLines;
		}

		// Token: 0x04000183 RID: 387
		private string FileName;

		// Token: 0x04000184 RID: 388
		private string[] FileLines;
	}
}
