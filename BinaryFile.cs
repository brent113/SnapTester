using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x0200002A RID: 42
	public class BinaryFile
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00014488 File Offset: 0x00012688
		public byte[] ReadToBuffer(string FileName)
		{
			FileInfo file_info = new FileInfo(FileName);
			byte[] result;
			if (file_info.Exists)
			{
				BinaryReader BR = new BinaryReader(new FileStream(FileName, FileMode.Open));
				byte[] res_buff = new byte[file_info.Length];
				BR.Read(res_buff, 0, res_buff.Count<byte>());
				BR.Close();
				result = res_buff;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000144E8 File Offset: 0x000126E8
		public void WriteToFile(string FileName, byte[] Data)
		{
			FileInfo file_info = new FileInfo(FileName);
			if (file_info.Exists)
			{
				DialogResult dia_res = MessageBox.Show("File Exist! Replace?", "Write binary file", MessageBoxButtons.YesNo);
				if (dia_res == DialogResult.No)
				{
					return;
				}
				file_info.Delete();
			}
			BinaryWriter BW = new BinaryWriter(new FileStream(FileName, FileMode.CreateNew));
			BW.Write(Data);
			BW.Close();
		}
	}
}
