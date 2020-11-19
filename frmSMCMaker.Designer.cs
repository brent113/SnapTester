namespace SnapTester
{
	// Token: 0x02000025 RID: 37
	public partial class frmSMCMaker : global::System.Windows.Forms.Form
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00013644 File Offset: 0x00011844
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001367C File Offset: 0x0001187C
		private void InitializeComponent()
		{
			this.btnSelectGCode = new global::System.Windows.Forms.Button();
			this.btnSelectSpecial = new global::System.Windows.Forms.Button();
			this.btnCombineFile = new global::System.Windows.Forms.Button();
			this.labGCodeFile = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lstSFile = new global::System.Windows.Forms.ListBox();
			this.cmbHeaderType = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.btnSelectGCode.Location = new global::System.Drawing.Point(362, 32);
			this.btnSelectGCode.Name = "btnSelectGCode";
			this.btnSelectGCode.Size = new global::System.Drawing.Size(127, 23);
			this.btnSelectGCode.TabIndex = 0;
			this.btnSelectGCode.Text = "Select GCode";
			this.btnSelectGCode.UseVisualStyleBackColor = true;
			this.btnSelectGCode.Click += new global::System.EventHandler(this.btnSelectGCode_Click);
			this.btnSelectSpecial.Location = new global::System.Drawing.Point(362, 87);
			this.btnSelectSpecial.Name = "btnSelectSpecial";
			this.btnSelectSpecial.Size = new global::System.Drawing.Size(127, 23);
			this.btnSelectSpecial.TabIndex = 1;
			this.btnSelectSpecial.Text = "Select Special";
			this.btnSelectSpecial.UseVisualStyleBackColor = true;
			this.btnSelectSpecial.Click += new global::System.EventHandler(this.btnSelectSpecial_Click);
			this.btnCombineFile.Location = new global::System.Drawing.Point(12, 414);
			this.btnCombineFile.Name = "btnCombineFile";
			this.btnCombineFile.Size = new global::System.Drawing.Size(127, 23);
			this.btnCombineFile.TabIndex = 2;
			this.btnCombineFile.Text = "Combine";
			this.btnCombineFile.UseVisualStyleBackColor = true;
			this.btnCombineFile.Click += new global::System.EventHandler(this.btnCombineFile_Click);
			this.labGCodeFile.AutoSize = true;
			this.labGCodeFile.Location = new global::System.Drawing.Point(24, 37);
			this.labGCodeFile.Name = "labGCodeFile";
			this.labGCodeFile.Size = new global::System.Drawing.Size(41, 12);
			this.labGCodeFile.TabIndex = 3;
			this.labGCodeFile.Text = "label1";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(24, 92);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(113, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "Special File List:";
			this.lstSFile.FormattingEnabled = true;
			this.lstSFile.ItemHeight = 12;
			this.lstSFile.Location = new global::System.Drawing.Point(26, 124);
			this.lstSFile.Name = "lstSFile";
			this.lstSFile.Size = new global::System.Drawing.Size(285, 256);
			this.lstSFile.TabIndex = 5;
			this.cmbHeaderType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHeaderType.FormattingEnabled = true;
			this.cmbHeaderType.Items.AddRange(new object[]
			{
				"Printer",
				"Laser",
				"CNC"
			});
			this.cmbHeaderType.Location = new global::System.Drawing.Point(368, 155);
			this.cmbHeaderType.Name = "cmbHeaderType";
			this.cmbHeaderType.Size = new global::System.Drawing.Size(121, 20);
			this.cmbHeaderType.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(538, 449);
			base.Controls.Add(this.cmbHeaderType);
			base.Controls.Add(this.lstSFile);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.labGCodeFile);
			base.Controls.Add(this.btnCombineFile);
			base.Controls.Add(this.btnSelectSpecial);
			base.Controls.Add(this.btnSelectGCode);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmSMCMaker";
			this.Text = "frmSMCMaker";
			base.Load += new global::System.EventHandler(this.frmSMCMaker_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000178 RID: 376
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Button btnSelectGCode;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.Button btnSelectSpecial;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.Button btnCombineFile;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.Label labGCodeFile;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.ListBox lstSFile;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.ComboBox cmbHeaderType;
	}
}
