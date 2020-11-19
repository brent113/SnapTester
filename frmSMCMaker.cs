using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000025 RID: 37
	public partial class frmSMCMaker : Form
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00013B2B File Offset: 0x00011D2B
		public frmSMCMaker()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00013B44 File Offset: 0x00011D44
		private void btnSelectGCode_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "GCODE;NC;CNC|*.GCODE;*.NC;*.CNC";
			ofd.ShowDialog();
			if (!(ofd.FileName == ""))
			{
				this.labGCodeFile.Text = ofd.FileName;
				ofd.FileName = "";
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00013BA4 File Offset: 0x00011DA4
		private void btnSelectSpecial_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			if (!(ofd.FileName == ""))
			{
				this.lstSFile.Items.Add(ofd.FileName);
				ofd.FileName = "";
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00013C0C File Offset: 0x00011E0C
		private void btnCombineFile_Click(object sender, EventArgs e)
		{
			FileInfo fi;
			for (int i = 0; i < this.lstSFile.Items.Count; i++)
			{
				fi = new FileInfo(this.lstSFile.Items[i].ToString());
				if (!fi.Exists)
				{
					MessageBox.Show("File Unexisting!");
					break;
				}
			}
			fi = new FileInfo(this.labGCodeFile.Text);
			if (!fi.Exists)
			{
				MessageBox.Show("Gcode File Unexisting!");
			}
			else
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "SMC|*.SMC";
				sfd.ShowDialog();
				if (!(sfd.FileName == ""))
				{
					fi = new FileInfo(sfd.FileName);
					if (fi.Exists)
					{
						fi.Delete();
					}
					BinaryWriter BW = new BinaryWriter(new FileStream(sfd.FileName, FileMode.CreateNew));
					BW.Write(BitConverter.ToUInt32(new byte[]
					{
						32,
						24,
						16,
						1
					}, 0));
					BW.Write(0u);
					BW.Write(uint.MaxValue);
					if (this.cmbHeaderType.SelectedIndex == 0)
					{
						BW.Write(BitConverter.ToUInt32(new byte[]
						{
							0,
							0,
							0,
							30
						}, 0));
					}
					else if (this.cmbHeaderType.SelectedIndex == 1)
					{
						BW.Write(BitConverter.ToUInt32(new byte[]
						{
							0,
							0,
							0,
							45
						}, 0));
					}
					else
					{
						BW.Write(BitConverter.ToUInt32(new byte[]
						{
							0,
							0,
							0,
							60
						}, 0));
					}
					BW.Write(0u);
					BinaryReader BR;
					byte[] tmpBytes;
					for (int i = 0; i < this.lstSFile.Items.Count; i++)
					{
						BW.Write(BitConverter.ToUInt32(new byte[]
						{
							32,
							24,
							16,
							1
						}, 0));
						string tmpFileName = this.lstSFile.Items[i].ToString();
						string ExtName = tmpFileName.Substring(tmpFileName.Length - 3, 3);
						if (ExtName == "txt")
						{
							BW.Write(0u);
						}
						else if (ExtName == "jpg")
						{
							BW.Write(1u);
						}
						else
						{
							BW.Write(uint.MaxValue);
						}
						fi = new FileInfo(this.lstSFile.Items[i].ToString());
						BW.Write((uint)fi.Length);
						BR = new BinaryReader(new FileStream(tmpFileName, FileMode.Open));
						tmpBytes = new byte[fi.Length];
						BR.Read(tmpBytes, 0, tmpBytes.Count<byte>());
						BW.Write(tmpBytes);
						BR.Close();
					}
					long curPos = BW.BaseStream.Position;
					BW.Seek(16, SeekOrigin.Begin);
					BW.Write((uint)curPos);
					BW.Seek(0, SeekOrigin.End);
					fi = new FileInfo(this.labGCodeFile.Text);
					tmpBytes = new byte[fi.Length];
					BR = new BinaryReader(new FileStream(this.labGCodeFile.Text, FileMode.Open));
					BR.Read(tmpBytes, 0, tmpBytes.Count<byte>());
					BW.Write(tmpBytes);
					BR.Close();
					BW.Close();
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00013F7C File Offset: 0x0001217C
		private void frmSMCMaker_Load(object sender, EventArgs e)
		{
			this.cmbHeaderType.SelectedIndex = 0;
		}
	}
}
