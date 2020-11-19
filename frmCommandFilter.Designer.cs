namespace SnapTester
{
	// Token: 0x0200000E RID: 14
	public partial class frmCommandFilter : global::System.Windows.Forms.Form
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002E10 File Offset: 0x00001010
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E48 File Offset: 0x00001048
		private void InitializeComponent()
		{
			this.lstFilter = new global::System.Windows.Forms.ListBox();
			this.rtbResult = new global::System.Windows.Forms.RichTextBox();
			this.btnAddFilter = new global::System.Windows.Forms.Button();
			this.txtEventID = new global::System.Windows.Forms.TextBox();
			this.txtOpCode = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnClear = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.lstFilter.FormattingEnabled = true;
			this.lstFilter.ItemHeight = 12;
			this.lstFilter.Location = new global::System.Drawing.Point(29, 167);
			this.lstFilter.Name = "lstFilter";
			this.lstFilter.Size = new global::System.Drawing.Size(120, 184);
			this.lstFilter.TabIndex = 0;
			this.lstFilter.DoubleClick += new global::System.EventHandler(this.lstFilter_DoubleClick);
			this.rtbResult.Location = new global::System.Drawing.Point(203, 31);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.Size = new global::System.Drawing.Size(556, 421);
			this.rtbResult.TabIndex = 1;
			this.rtbResult.Text = "";
			this.btnAddFilter.Location = new global::System.Drawing.Point(29, 29);
			this.btnAddFilter.Name = "btnAddFilter";
			this.btnAddFilter.Size = new global::System.Drawing.Size(104, 23);
			this.btnAddFilter.TabIndex = 2;
			this.btnAddFilter.Text = "Add Filter";
			this.btnAddFilter.UseVisualStyleBackColor = true;
			this.btnAddFilter.Click += new global::System.EventHandler(this.btnAddFilter_Click);
			this.txtEventID.Location = new global::System.Drawing.Point(86, 74);
			this.txtEventID.Name = "txtEventID";
			this.txtEventID.Size = new global::System.Drawing.Size(63, 21);
			this.txtEventID.TabIndex = 3;
			this.txtEventID.Text = "00";
			this.txtEventID.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.txtOpCode.Location = new global::System.Drawing.Point(86, 114);
			this.txtOpCode.Name = "txtOpCode";
			this.txtOpCode.Size = new global::System.Drawing.Size(63, 21);
			this.txtOpCode.TabIndex = 4;
			this.txtOpCode.Text = "*";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 77);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "Event ID";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 117);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(41, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "OpCode";
			this.btnClear.Location = new global::System.Drawing.Point(86, 382);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(789, 488);
			base.Controls.Add(this.btnClear);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.txtOpCode);
			base.Controls.Add(this.txtEventID);
			base.Controls.Add(this.btnAddFilter);
			base.Controls.Add(this.rtbResult);
			base.Controls.Add(this.lstFilter);
			base.Name = "frmCommandFilter";
			this.Text = "Filter";
			base.Load += new global::System.EventHandler(this.frmCommandFilter_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000024 RID: 36
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ListBox lstFilter;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.RichTextBox rtbResult;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button btnAddFilter;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.TextBox txtEventID;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TextBox txtOpCode;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button btnClear;
	}
}
