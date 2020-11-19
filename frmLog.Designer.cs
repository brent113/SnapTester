namespace SnapTester
{
	// Token: 0x02000011 RID: 17
	public partial class frmLog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003B6C File Offset: 0x00001D6C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003BA4 File Offset: 0x00001DA4
		private void InitializeComponent()
		{
			this.rtbLog = new global::System.Windows.Forms.RichTextBox();
			this.btnClear = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.rtbLog.Location = new global::System.Drawing.Point(12, 12);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.Size = new global::System.Drawing.Size(595, 469);
			this.rtbLog.TabIndex = 0;
			this.rtbLog.Text = "";
			this.btnClear.Location = new global::System.Drawing.Point(522, 500);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(85, 31);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(619, 543);
			base.Controls.Add(this.btnClear);
			base.Controls.Add(this.rtbLog);
			base.Name = "frmLog";
			this.Text = "frmLog";
			base.Load += new global::System.EventHandler(this.frmLog_Load);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmLog_FormClosing);
			base.ResumeLayout(false);
		}

		// Token: 0x04000033 RID: 51
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.RichTextBox rtbLog;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button btnClear;
	}
}
