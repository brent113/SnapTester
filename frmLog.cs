using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000011 RID: 17
	public partial class frmLog : Form
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00003A02 File Offset: 0x00001C02
		public frmLog()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003A1B File Offset: 0x00001C1B
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.rtbLog.Clear();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003A2C File Offset: 0x00001C2C
		public void AddLog(string Text)
		{
			if (this.rtbLog.Lines.Count<string>() > 20000)
			{
				string[] Last3Line = new string[]
				{
					this.rtbLog.Lines[this.rtbLog.Lines.Count<string>() - 3],
					this.rtbLog.Lines[this.rtbLog.Lines.Count<string>() - 2],
					this.rtbLog.Lines[this.rtbLog.Lines.Count<string>() - 1]
				};
				this.rtbLog.Text = "";
				this.rtbLog.AppendText(Last3Line[0]);
				this.rtbLog.AppendText(Last3Line[1]);
				this.rtbLog.AppendText(Last3Line[2]);
			}
			string NewString = DateTime.Now.ToString("hh:mm:ss:");
			NewString = NewString + Text + "\r\n";
			this.rtbLog.Select(this.rtbLog.TextLength, 0);
			this.rtbLog.ScrollToCaret();
			this.rtbLog.AppendText(NewString);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003B56 File Offset: 0x00001D56
		private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			e.Cancel = true;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003B68 File Offset: 0x00001D68
		private void frmLog_Load(object sender, EventArgs e)
		{
		}
	}
}
