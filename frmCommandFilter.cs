using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x0200000E RID: 14
	public partial class frmCommandFilter : Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00003320 File Offset: 0x00001520
		public frmCommandFilter()
		{
			this.InitializeComponent();
			this.dlgAddResult = new frmCommandFilter.SetObjectText(this.AddResult);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003358 File Offset: 0x00001558
		private void AddResult(object obj, string Text)
		{
			RichTextBox rtb = obj as RichTextBox;
			if (rtb.Lines.Count<string>() > 20000)
			{
				string[] Last3Line = new string[]
				{
					rtb.Lines[rtb.Lines.Count<string>() - 3],
					rtb.Lines[rtb.Lines.Count<string>() - 2],
					rtb.Lines[rtb.Lines.Count<string>() - 1]
				};
				rtb.Text = "";
				rtb.AppendText(Last3Line[0]);
				rtb.AppendText(Last3Line[1]);
				rtb.AppendText(Last3Line[2]);
			}
			rtb.Select(rtb.TextLength, 0);
			rtb.ScrollToCaret();
			rtb.AppendText(Text);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000341C File Offset: 0x0000161C
		private void lstFilter_DoubleClick(object sender, EventArgs e)
		{
			if (this.lstFilter.SelectedIndex >= 0)
			{
				this.filters.RemoveAt(this.lstFilter.SelectedIndex);
				this.lstFilter.Items.RemoveAt(this.lstFilter.SelectedIndex);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003474 File Offset: 0x00001674
		private void btnAddFilter_Click(object sender, EventArgs e)
		{
			Filter newfilter = new Filter();
			byte EvnetID;
			if (byte.TryParse(this.txtEventID.Text, out EvnetID))
			{
				if (this.txtOpCode.Text == "*")
				{
					newfilter.Opcode = ushort.MaxValue;
				}
				else
				{
					byte Opcode;
					if (!byte.TryParse(this.txtOpCode.Text, NumberStyles.AllowHexSpecifier, null, out Opcode))
					{
						return;
					}
					newfilter.Opcode = (ushort)Opcode;
				}
				newfilter.EventID = EvnetID;
				this.filters.Add(newfilter);
				if (newfilter.Opcode != 65535)
				{
					this.lstFilter.Items.Add(newfilter.EventID.ToString("X2") + "  " + newfilter.Opcode.ToString("X2"));
				}
				else
				{
					this.lstFilter.Items.Add(newfilter.EventID.ToString("X2") + "  *");
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003585 File Offset: 0x00001785
		private void frmCommandFilter_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003588 File Offset: 0x00001788
		public void AddData(byte EventID, byte Opcode, byte[] SrcData)
		{
			if (this.filters.Count != 0)
			{
				bool filterexist = false;
				for (int i = 0; i < this.filters.Count; i++)
				{
					if (this.filters[i].Opcode == 65535)
					{
						if (this.filters[i].EventID == EventID)
						{
							filterexist = true;
							break;
						}
					}
					else if (this.filters[i].EventID == EventID && this.filters[i].Opcode == (ushort)Opcode)
					{
						filterexist = true;
						break;
					}
				}
				if (filterexist)
				{
					string NewString = DateTime.Now.ToString("hh:mm:ss:") + "\r\n";
					NewString = NewString + this.ToString(SrcData) + "\r\n";
					base.Invoke(this.dlgAddResult, new object[]
					{
						this.rtbResult,
						NewString
					});
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000036B0 File Offset: 0x000018B0
		private string ToString(byte[] Data)
		{
			string Res = "";
			for (int i = 0; i < Data.Count<byte>(); i++)
			{
				Res = Res + Data[i].ToString("X2") + " ";
			}
			return Res;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000036FB File Offset: 0x000018FB
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.rtbResult.Text = "";
		}

		// Token: 0x0400002D RID: 45
		private List<Filter> filters = new List<Filter>();

		// Token: 0x0400002E RID: 46
		private frmCommandFilter.SetObjectText dlgAddResult;

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate void SetObjectText(object obj, string Text);
	}
}
