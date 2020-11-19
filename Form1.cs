using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SnapTester
{
	// Token: 0x02000012 RID: 18
	public partial class Form1 : Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003D50 File Offset: 0x00001F50
		public Form1()
		{
			this.InitializeComponent();
			this.MyHMILables.Add(new Form1.strHMILable(this.labPrintFileName, 66816u));
			this.MyHMILables.Add(new Form1.strHMILable(this.labTampHeater0, 66567u));
			this.MyHMILables.Add(new Form1.strHMILable(this.labTampBed, 66568u));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003F10 File Offset: 0x00002110
		private void SetObjectText(object obj, string Text)
		{
			Label lab = obj as Label;
			lab.Text = Text;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003F30 File Offset: 0x00002130
		private void UpdatePictureImage(byte[] ImageBytes)
		{
			MemoryStream ms = new MemoryStream(ImageBytes);
			this.picboxBTImage.Image = Image.FromStream(ms);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003F57 File Offset: 0x00002157
		private void AddTextToLogForm(string Text)
		{
			this.Log.AddLog(Text);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003F68 File Offset: 0x00002168
		private void AddModuleVersiontoList(object obj, string Text)
		{
			ListBox lstbox = obj as ListBox;
			lstbox.Items.Add(Text);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003F8C File Offset: 0x0000218C
		private void UpdateLightbarStatus(LightbarData Data)
		{
			if (Data.IsValid)
			{
				this.tbLightBrightness.Value = (int)Data.Brightness;
				string strLigthStatus;
				if (Data.Onoff)
				{
					strLigthStatus = "开";
				}
				else
				{
					strLigthStatus = "关";
				}
				if (Data.Mode == 0)
				{
					strLigthStatus += "，状态灯";
				}
				else
				{
					strLigthStatus += "，照明灯";
				}
				MessageBox.Show(strLigthStatus);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004014 File Offset: 0x00002214
		private void SetListBoxValue(object obj, object Value, Form1.SetListBoxOption Option)
		{
			ListBox lstBox = obj as ListBox;
			if (Option == Form1.SetListBoxOption.SLBO_ADD)
			{
				lstBox.Items.Add(Value);
			}
			else if (Option == Form1.SetListBoxOption.SLBO_CLEAR)
			{
				lstBox.Items.Clear();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004060 File Offset: 0x00002260
		private void UpdateSizeText(object[] obj, string[] Text)
		{
			for (int i = 0; i < obj.Count<object>(); i++)
			{
				TextBox tb = obj[i] as TextBox;
				tb.Text = Text[i];
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004098 File Offset: 0x00002298
		private void UpdateSizeDir(object[] obj, bool[] CheckedStatus)
		{
			for (int i = 0; i < obj.Count<object>(); i++)
			{
				CheckBox cb = obj[i] as CheckBox;
				cb.Checked = CheckedStatus[i];
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000040D0 File Offset: 0x000022D0
		private void UpdateCalibrateButtonStat(bool Enable)
		{
			if (Enable)
			{
				this.btnZAutoCalibrate.Enabled = false;
				this.btnCaliHome.Enabled = false;
				this.btnCaliBack.Enabled = true;
				this.btnCaliSave.Enabled = true;
				this.btnCaliZDown.Enabled = true;
				this.btnCaliZUp.Enabled = true;
				for (int i = 0; i < 9; i++)
				{
					this.btnCaliPoint[i].Enabled = true;
				}
			}
			else
			{
				this.btnZAutoCalibrate.Enabled = true;
				this.btnCaliHome.Enabled = true;
				this.btnCaliBack.Enabled = false;
				this.btnCaliSave.Enabled = false;
				this.btnCaliZDown.Enabled = false;
				this.btnCaliZUp.Enabled = false;
				for (int i = 0; i < 9; i++)
				{
					this.btnCaliPoint[i].Enabled = false;
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000041C8 File Offset: 0x000023C8
		private void SetUpdateLabelString(object obj, string Text)
		{
			Label lab = obj as Label;
			lab.Text = Text;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000041E8 File Offset: 0x000023E8
		private void UpdateMachineStatus(clsMachineStatus Status)
		{
			this.labXPos.Text = Status.Pos[0].ToString("f2");
			this.labYPos.Text = Status.Pos[1].ToString("f2");
			this.labZPos.Text = Status.Pos[2].ToString("f2");
			this.labEPos.Text = Status.Pos[3].ToString("f2");
			this.labTampHeater0.Text = Status.Heater0Tamp.ToString() + "/" + Status.Heater0Target.ToString();
			this.labTampBed.Text = Status.HeatedBedTamp.ToString() + "/" + Status.HeaterBedTarget.ToString();
			this.labCurrentLaserPercent.Text = Status.Percent.ToString();
			this.labRPM.Text = Status.CNCRpm.ToString();
			if (Status.PrintingStatus == 0)
			{
				this.picStatus.BackColor = Color.Red;
				this.labStatus.Text = "Idle";
				this.btnStartPrint.Enabled = true;
				this.btnPause.Enabled = false;
				this.btnContinue.Enabled = false;
				this.btnUDiskPrint.Enabled = true;
				this.btnStartPrint.Text = "Start";
				this.btnStop.Enabled = false;
				this.Printing = false;
			}
			else if (Status.PrintingStatus == 3)
			{
				this.picStatus.BackColor = Color.Green;
				this.labStatus.Text = "Printing Online";
				this.btnStartPrint.Enabled = false;
				this.btnPause.Enabled = true;
				this.btnContinue.Enabled = false;
				this.btnStartPrint.Text = "Start";
				this.btnStop.Enabled = true;
			}
			else if (Status.PrintingStatus == 4)
			{
				this.picStatus.BackColor = Color.Yellow;
				this.labStatus.Text = "Pause Online";
				this.btnStartPrint.Enabled = false;
				this.btnPause.Enabled = false;
				this.btnContinue.Enabled = true;
				this.btnStartPrint.Text = "Start";
				this.btnStop.Enabled = true;
			}
			if (Status.Executer == 1)
			{
				this.labExecuter.Text = "Snapmaker-3DPrint";
			}
			else if (Status.Executer == 2)
			{
				this.labExecuter.Text = "Snapmaker-CNC";
			}
			else if (Status.Executer == 3)
			{
				this.labExecuter.Text = "Snapmaker-Laser";
			}
			else if (Status.Executer == 4)
			{
				this.labExecuter.Text = "Snapmaker-Laser";
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004518 File Offset: 0x00002718
		private void OnSpecialContentRead(object sender, EventArgs e)
		{
			int tmpCount = this.SpecialContents.Count;
			int i = 0;
			uint ItemCount = 0u;
			this.ItemStartPos = new List<uint>();
			base.Invoke(this.dlgSetSpecialList, new object[]
			{
				this.lstSpecialContents,
				"",
				Form1.SetListBoxOption.SLBO_CLEAR
			});
			while (tmpCount > 12)
			{
				this.ItemStartPos.Add((uint)i);
				uint Sigh = (uint)((int)this.SpecialContents[i] << 24 | (int)this.SpecialContents[i + 1] << 16 | (int)this.SpecialContents[i + 2] << 8 | (int)this.SpecialContents[i + 3]);
				uint Type = (uint)((int)this.SpecialContents[i + 7] << 24 | (int)this.SpecialContents[i + 6] << 16 | (int)this.SpecialContents[i + 5] << 8 | (int)this.SpecialContents[i + 4]);
				uint Len = (uint)((int)this.SpecialContents[i + 11] << 24 | (int)this.SpecialContents[i + 10] << 16 | (int)this.SpecialContents[i + 9] << 8 | (int)this.SpecialContents[i + 8]);
				i += (int)(12u + Len);
				ItemCount += 1u;
				if (Type == 0u)
				{
					base.Invoke(this.dlgSetSpecialList, new object[]
					{
						this.lstSpecialContents,
						"TXT",
						Form1.SetListBoxOption.SLBO_ADD
					});
				}
				else if (Type == 1u)
				{
					base.Invoke(this.dlgSetSpecialList, new object[]
					{
						this.lstSpecialContents,
						"JPG",
						Form1.SetListBoxOption.SLBO_ADD
					});
				}
				else
				{
					base.Invoke(this.dlgSetSpecialList, new object[]
					{
						this.lstSpecialContents,
						"OTHER",
						Form1.SetListBoxOption.SLBO_ADD
					});
				}
				tmpCount -= (int)(12u + Len);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004738 File Offset: 0x00002938
		private void btnSearchPort_Click(object sender, EventArgs e)
		{
			string[] Ports = SerialPort.GetPortNames();
			this.cmbPorts.Items.Clear();
			foreach (string tmp in Ports)
			{
				this.cmbPorts.Items.Add(tmp);
			}
			if (this.cmbPorts.Items.Count > 0)
			{
				this.cmbPorts.SelectedIndex = 0;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000047B3 File Offset: 0x000029B3
		private void SetProgressBarValue(int Value)
		{
			this.progressBar1.Value = Value;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000047C3 File Offset: 0x000029C3
		private void SetCurrentPath(object obj, string Text)
		{
			this.labCurrentPath.Text = Text;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000047D4 File Offset: 0x000029D4
		private void SetHMILabelText(object ThisLabel, string Text)
		{
			Label thisLable = ThisLabel as Label;
			thisLable.Text = Text;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000047F4 File Offset: 0x000029F4
		private void AddListItem(object obj, string Text)
		{
			ListBox thisList = obj as ListBox;
			thisList.Items.Add(Text);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004818 File Offset: 0x00002A18
		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (this.spPort.IsOpen)
			{
				this.Text = "Close";
				this.spPort.Close();
			}
			else
			{
				try
				{
					this.spPort.PortName = this.cmbPorts.Text;
					this.spPort.Open();
					this.Text = this.cmbPorts.Text + "-Open";
					this.OKReceived = true;
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000048B8 File Offset: 0x00002AB8
		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Gcode;NC;CNC|*.GCODE;*.NC;*.CNC";
			ofd.FileName = "";
			ofd.ShowDialog();
			if (!(ofd.FileName == ""))
			{
				string FileName = ofd.FileName;
				FileInfo fi = new FileInfo(Application.StartupPath + "\\Temp.gcode");
				if (fi.Exists)
				{
					fi.Delete();
				}
				fi = new FileInfo(FileName);
				fi.CopyTo(Application.StartupPath + "\\Temp.gcode");
				this.labFileName.Text = FileName;
				StreamReader SR = new StreamReader(new FileStream(FileName, FileMode.Open));
				this.FileLines = new List<string>();
				for (;;)
				{
					string tmpCode = SR.ReadLine();
					if (tmpCode == null)
					{
						break;
					}
					if (tmpCode.Length <= 2 || tmpCode[0] != ';')
					{
						this.FileLines.Add(tmpCode);
					}
				}
				SR.Close();
				SR.Dispose();
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000049E0 File Offset: 0x00002BE0
		private void Form1_Load(object sender, EventArgs e)
		{
			this.btnCaliPoint[0] = this.btnPoint1;
			this.btnCaliPoint[1] = this.btnPoint2;
			this.btnCaliPoint[2] = this.btnPoint3;
			this.btnCaliPoint[3] = this.btnPoint4;
			this.btnCaliPoint[4] = this.btnPoint5;
			this.btnCaliPoint[5] = this.btnPoint6;
			this.btnCaliPoint[6] = this.btnPoint7;
			this.btnCaliPoint[7] = this.btnPoint8;
			this.btnCaliPoint[8] = this.btnPoint9;
			this.rbSize[0] = this.rbSizeS;
			this.rbSize[1] = this.rbSizeM;
			this.rbSize[2] = this.rbSizeL;
			this.rbSizeS.Click += this.OnMachineSizeClick;
			this.rbSizeM.Click += this.OnMachineSizeClick;
			this.rbSizeL.Click += this.OnMachineSizeClick;
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Click += this.btnCaliPoint_Click;
			}
			ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.GocdeSendThread), null);
			ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.SerialDataProcess), null);
			this.cmdMoveAxisDis.SelectedIndex = 2;
			this.cmbCaliZDis.SelectedIndex = 2;
			this.dlgSetProgressBarValue = new Form1.SetValue(this.SetProgressBarValue);
			this.dlgSetHMILabelText = new Form1.SetText(this.SetHMILabelText);
			this.dlgAddItemToList = new Form1.SetText(this.AddListItem);
			this.dlgSetCurrentPath = new Form1.SetText(this.SetCurrentPath);
			this.SpecialContentReadHandle = (EventHandler)Delegate.Combine(this.SpecialContentReadHandle, new EventHandler(this.OnSpecialContentRead));
			this.dlgSetSpecialList = new Form1.SetObjectValue(this.SetListBoxValue);
			this.dlgUpdateMachineStatus = new Form1.UpdateClassValue(this.UpdateMachineStatus);
			this.dlgUpdateCalibrateButtonEnable = new Form1.UpdateCalibrateEnable(this.UpdateCalibrateButtonStat);
			this.dlgSetSize = new Form1.SetObjectsText(this.UpdateSizeText);
			this.dlgSetDirStatus = new Form1.SetObjectsCheckStatus(this.UpdateSizeDir);
			this.dlgSetUpdateProgressLabel = new Form1.SetText(this.SetUpdateLabelString);
			this.dlgSetBTUpdateProgressLable = new Form1.SetText(this.SetUpdateLabelString);
			this.dlgUpdateLightbarStatus = new Form1.SetLigthbarData(this.UpdateLightbarStatus);
			this.dlgAddLog = new Form1.AddText(this.AddTextToLogForm);
			this.dlgAddModuleVersion = new Form1.SetText(this.AddModuleVersiontoList);
			this.dlgSetLableText = new Form1.SetText(this.SetObjectText);
			this.dlgUpdatePictureBoxImage = new Form1.PostBytes2Object(this.UpdatePictureImage);
			this.tmrGetStatus = new System.Threading.Timer(new TimerCallback(this.OnTimer), this.tmrGetStatus, 0, 100);
			this.tmrEnterUpdate = new System.Threading.Timer(new TimerCallback(this.OnTimerEnterUpdate), this.tmrEnterUpdate, 0, 100);
			this.Log.Show();
			this.Log.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004CE4 File Offset: 0x00002EE4
		private void OnMachineSizeClick(object sender, EventArgs e)
		{
			if (this.rbSize[0].Checked)
			{
				this.txtXSize.Text = "167";
				this.txtYSize.Text = "169";
				this.txtZSize.Text = "150";
				this.txtXOffset.Text = "0";
				this.txtYOffset.Text = "0";
				this.txtZOffset.Text = "0";
				this.cbXDir.Checked = false;
				this.cbYDir.Checked = false;
				this.cbZDir.Checked = false;
				this.cbXHomeDir.Checked = true;
				this.cbYHomeDir.Checked = true;
				this.cbZHomeDir.Checked = true;
			}
			else if (this.rbSize[1].Checked)
			{
				this.txtXSize.Text = "244";
				this.txtYSize.Text = "260";
				this.txtZSize.Text = "235";
				this.txtXOffset.Text = "-7";
				this.txtYOffset.Text = "0";
				this.txtZOffset.Text = "0";
				this.cbXDir.Checked = true;
				this.cbYDir.Checked = false;
				this.cbZDir.Checked = false;
				this.cbXHomeDir.Checked = false;
				this.cbYHomeDir.Checked = true;
				this.cbZHomeDir.Checked = true;
			}
			else if (this.rbSize[2].Checked)
			{
				this.txtXSize.Text = "336";
				this.txtYSize.Text = "360";
				this.txtZSize.Text = "334";
				this.txtXOffset.Text = "-9";
				this.txtYOffset.Text = "0";
				this.txtZOffset.Text = "0";
				this.cbXDir.Checked = true;
				this.cbYDir.Checked = false;
				this.cbZDir.Checked = false;
				this.cbXHomeDir.Checked = false;
				this.cbYHomeDir.Checked = true;
				this.cbZHomeDir.Checked = true;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004F64 File Offset: 0x00003164
		private void OnTimer(object sender)
		{
			if (this.CheckTick++ > 1)
			{
				this.CheckTick = 0;
				if (this.AutoCheckStatus)
				{
					this.SendRequestStatus();
				}
			}
			if (this.GetProgress++ > 7)
			{
				this.GetProgress = 0;
				if (this.CurStatus != null && (this.CurStatus.PrintingStatus == 1 || this.CurStatus.PrintingStatus == 2))
				{
					this.SendRequestProgressPercent();
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005008 File Offset: 0x00003208
		private void OnTimerEnterUpdate(object sender)
		{
			if (this.EnteringUpdate)
			{
				this.SendRequestStatus();
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000502C File Offset: 0x0000322C
		private void SendRequestProgressPercent()
		{
			if (this.spPort.IsOpen)
			{
				this.SendCustomProtocol(7, new byte[]
				{
					9
				});
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005060 File Offset: 0x00003260
		private void SendRequestStatus()
		{
			if (this.spPort.IsOpen)
			{
				this.SendCustomProtocol(7, new byte[]
				{
					1
				});
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005094 File Offset: 0x00003294
		private void btnStartPrint_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(7, new byte[]
			{
				3
			});
			this.Printing = true;
			this.FileLineIndex = 0u;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000050C4 File Offset: 0x000032C4
		private void spPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			int Len = this.spPort.BytesToRead;
			byte[] tmpBytes = new byte[Len];
			this.spPort.Read(tmpBytes, 0, Len);
			this.mtxSerialBuff.WaitOne();
			this.ProcessBuff.AddRange(tmpBytes);
			this.mtxSerialBuff.ReleaseMutex();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000511C File Offset: 0x0000331C
		private void SerialDataProcess(object obj)
		{
			for (;;)
			{
				if (this.ProcessBuff.Count > 9)
				{
					this.mtxSerialBuff.WaitOne();
					if (this.ProcessBuff[0] != 170)
					{
						this.ProcessBuff.RemoveAt(0);
						this.mtxSerialBuff.ReleaseMutex();
					}
					else if (this.ProcessBuff[1] != 85)
					{
						this.ProcessBuff.RemoveRange(0, 2);
						this.mtxSerialBuff.ReleaseMutex();
					}
					else
					{
						string[] ItemName = new string[10];
						byte[] Type = new byte[10];
						string[] txt = new string[6];
						float[] tmpfloat = new float[6];
						byte ProtocalVersion = this.ProcessBuff[4];
						if (ProtocalVersion != 0)
						{
							this.ProcessBuff.RemoveRange(0, 2);
							this.mtxSerialBuff.ReleaseMutex();
						}
						else
						{
							ushort CmdLen = (ushort)((int)this.ProcessBuff[2] << 8 | (int)this.ProcessBuff[3]);
							if ((this.ProcessBuff[2] ^ this.ProcessBuff[3]) != this.ProcessBuff[5])
							{
								this.ProcessBuff.RemoveRange(0, 2);
								this.mtxSerialBuff.ReleaseMutex();
							}
							else if ((int)CmdLen > this.ProcessBuff.Count - 8)
							{
								this.mtxSerialBuff.ReleaseMutex();
								Thread.Sleep(10);
							}
							else
							{
								byte[] DataBuff = new byte[(int)(CmdLen + 8)];
								byte[] SrcData = new byte[(int)CmdLen];
								Array.Copy(this.ProcessBuff.ToArray(), 0, DataBuff, 0, DataBuff.Count<byte>());
								Array.Copy(this.ProcessBuff.ToArray(), 8, SrcData, 0, SrcData.Count<byte>());
								this.ProcessBuff.RemoveRange(0, DataBuff.Count<byte>());
								uint Checksum = 0u;
								for (int i = 0; i < (int)(CmdLen - 1); i += 2)
								{
									Checksum += (uint)((int)DataBuff[8 + i] << 8 | (int)DataBuff[9 + i]);
								}
								if (CmdLen % 2 != 0)
								{
									Checksum += (uint)DataBuff[DataBuff.Count<byte>() - 1];
								}
								while (Checksum > 65535u)
								{
									Checksum = (Checksum >> 16 & 65535u) + (Checksum & 65535u);
								}
								Checksum = ~Checksum;
								if ((ulong)(Checksum & 65535u) != (ulong)((long)((int)DataBuff[6] << 8 | (int)DataBuff[7])))
								{
									this.mtxSerialBuff.ReleaseMutex();
								}
								else
								{
									byte Command = DataBuff[8];
									this.FilterForm.AddData(Command, DataBuff[9], SrcData);
									byte b = Command;
									if (b <= 18)
									{
										switch (b)
										{
										case 2:
										case 4:
										{
											string ReturnCode = this.GcodePhaser.GetString(DataBuff, 9, (int)(CmdLen - 1));
											if (ReturnCode.IndexOf("ok") == 0)
											{
												this.OKReceived = true;
												this.RecvIndex++;
											}
											break;
										}
										case 3:
										case 5:
										case 7:
										case 9:
										case 11:
										case 13:
											break;
										case 6:
											switch (DataBuff[9])
											{
											case 0:
											{
												byte Resulut = DataBuff[10];
												if (Resulut == 0)
												{
													MessageBox.Show("UDist Init Success!");
												}
												else
												{
													MessageBox.Show("UDist Init Fail!");
												}
												break;
											}
											case 1:
											{
												int j = 10;
												byte[] tmpb = new byte[256];
												int k = 0;
												while (DataBuff[j] != 0)
												{
													tmpb[k++] = DataBuff[j];
													j++;
												}
												j++;
												base.Invoke(this.dlgSetCurrentPath, new object[]
												{
													null,
													Encoding.Default.GetString(tmpb, 0, j)
												});
												break;
											}
											case 4:
											{
												byte ItemCount = DataBuff[13];
												int j = 14;
												for (int i = 0; i < (int)ItemCount; i++)
												{
													Type[i] = DataBuff[j++];
													byte[] tmpb = new byte[256];
													int k = 0;
													while (DataBuff[j] != 0)
													{
														tmpb[k++] = DataBuff[j];
														j++;
													}
													j++;
													ItemName[i] = Encoding.Default.GetString(tmpb, 0, k);
													if (Type[i] == 0)
													{
														base.Invoke(this.dlgAddItemToList, new object[]
														{
															this.lstFiles,
															ItemName[i]
														});
													}
													else
													{
														base.Invoke(this.dlgAddItemToList, new object[]
														{
															this.lstFiles,
															"_Dir-" + ItemName[i]
														});
													}
												}
												if (ItemCount != 0)
												{
													this.btnGetFileList_Click(null, null);
												}
												break;
											}
											case 5:
											{
												byte Resulut = DataBuff[10];
												if (Resulut == 0)
												{
													MessageBox.Show("No Contents!");
												}
												byte[] tmpb = new byte[(int)(CmdLen - 3)];
												Array.Copy(DataBuff, 11, tmpb, 0, tmpb.Count<byte>());
												this.SpecialContents.AddRange(tmpb);
												if (Resulut == 2)
												{
													this.OnSpecialContentRead(null, null);
												}
												break;
											}
											case 6:
											{
												byte Resulut = DataBuff[10];
												if (Resulut == 0)
												{
													MessageBox.Show("Start UDisk Print Success!");
												}
												else
												{
													MessageBox.Show("Start UDisk Print Fail!");
												}
												break;
											}
											}
											break;
										case 8:
										{
											clsMachineStatus tmpMachine = new clsMachineStatus();
											if (DataBuff.Count<byte>() >= 10)
											{
												if (DataBuff[9] == 1)
												{
													int j = 10;
													int lValue;
													for (int k = 0; k < 4; k++)
													{
														lValue = 0;
														for (int i = 0; i < 4; i++)
														{
															lValue = (lValue << 8 | (int)DataBuff[j++]);
														}
														tmpMachine.Pos[k] = (double)((float)lValue / 1000f);
													}
													lValue = 0;
													for (int i = 0; i < 2; i++)
													{
														lValue = (int)((short)(lValue << 8 | (int)DataBuff[j++]));
													}
													tmpMachine.HeatedBedTamp = lValue;
													lValue = 0;
													for (int i = 0; i < 2; i++)
													{
														lValue = (int)((short)(lValue << 8 | (int)DataBuff[j++]));
													}
													tmpMachine.HeaterBedTarget = lValue;
													lValue = 0;
													for (int i = 0; i < 2; i++)
													{
														lValue = (int)((short)(lValue << 8 | (int)DataBuff[j++]));
													}
													tmpMachine.Heater0Tamp = lValue;
													lValue = 0;
													for (int i = 0; i < 2; i++)
													{
														lValue = (int)((short)(lValue << 8 | (int)DataBuff[j++]));
													}
													tmpMachine.Heater0Target = lValue;
													j += 2;
													lValue = 0;
													for (int i = 0; i < 4; i++)
													{
														lValue = (lValue << 8 | (int)DataBuff[j++]);
													}
													tmpMachine.Percent = (byte)lValue;
													lValue = 0;
													for (int i = 0; i < 4; i++)
													{
														lValue = (lValue << 8 | (int)DataBuff[j++]);
													}
													tmpMachine.CNCRpm = lValue;
													tmpMachine.PrintingStatus = DataBuff[j++];
													tmpMachine.PeriphStatus = (uint)DataBuff[j++];
													tmpMachine.Executer = DataBuff[j++];
													try
													{
														base.Invoke(this.dlgUpdateMachineStatus, new object[]
														{
															tmpMachine
														});
														this.CurStatus = tmpMachine;
													}
													catch
													{
													}
												}
												else if (DataBuff[9] == 2)
												{
													this.SysFaultFlag = (uint)((int)DataBuff[10] << 24 | (int)DataBuff[11] << 16 | (int)DataBuff[12] << 8 | (int)DataBuff[13]);
													string strFault = "";
													if ((this.SysFaultFlag & 4u) != 0u)
													{
														strFault += "Heated Bed Fault";
													}
													if ((this.SysFaultFlag & 32u) != 0u)
													{
														strFault += "Filament Fault!";
													}
													if ((this.SysFaultFlag & 64u) != 0u)
													{
														strFault += "Powerpanic Valid!";
													}
													if ((this.SysFaultFlag & 128u) != 0u)
													{
														strFault += "Invalid Powerpanic data!";
													}
													if ((this.SysFaultFlag & 256u) != 0u)
													{
														strFault += "EEPROM setting fault!";
													}
													MessageBox.Show(strFault);
													this.sigPowerResume.Post();
												}
												else if (DataBuff[9] == 3)
												{
													MessageBox.Show("Printing Online Started");
												}
												else if (DataBuff[9] == 4)
												{
													this.Printing = false;
													this.OKReceived = true;
													if (this.CurStatus.PrintingStatus == 3)
													{
														this.CurStatus.PrintingStatus = 4;
													}
													else if (this.CurStatus.PrintingStatus == 1)
													{
														this.CurStatus.PrintingStatus = 2;
													}
													base.Invoke(this.dlgUpdateMachineStatus, new object[]
													{
														this.CurStatus
													});
													MessageBox.Show("Pause Success");
												}
												else if (DataBuff[9] == 5)
												{
													MessageBox.Show("Resume Success");
													this.Printing = true;
												}
												else if (DataBuff[9] == 6)
												{
													MessageBox.Show("Stop Success");
													this.OKReceived = true;
													this.Printing = false;
													this.CurStatus.PrintingStatus = 0;
													base.Invoke(this.dlgUpdateMachineStatus, new object[]
													{
														this.CurStatus
													});
												}
												else if (DataBuff[9] == 7)
												{
													MessageBox.Show("Print Complete");
													base.Invoke(this.dlgSetProgressBarValue, new object[]
													{
														100
													});
												}
												else if (DataBuff[9] == 8)
												{
													string strmsg = "";
													if (DataBuff[10] == 1)
													{
														this.PowerPanicSource = DataBuff[11];
														if (this.PowerPanicSource == 0)
														{
															strmsg += "Powerpanic UDisk:";
														}
														else
														{
															strmsg += "Powerpanic Online:";
														}
													}
													this.FileLineIndex = (uint)((int)DataBuff[12] << 24 | (int)DataBuff[13] << 16 | (int)DataBuff[14] << 8 | (int)DataBuff[15]);
													if (this.semCommand != null)
													{
														this.semCommand.Release();
													}
													this.sigPowerResume.Post();
												}
												else if (DataBuff[9] == 9)
												{
													try
													{
														base.Invoke(this.dlgSetProgressBarValue, new object[]
														{
															DataBuff[13]
														});
													}
													catch
													{
													}
												}
												else if (DataBuff[9] == 10)
												{
													if (DataBuff[10] == 0)
													{
														MessageBox.Show("Fault Clear Success!");
													}
													else
													{
														MessageBox.Show("Fault Clear Fail!");
													}
												}
												else if (DataBuff[9] == 11)
												{
													if (this.CurStatus.PrintingStatus == 4)
													{
														this.CurStatus.PrintingStatus = 3;
													}
													else if (this.CurStatus.PrintingStatus == 2)
													{
														this.CurStatus.PrintingStatus = 1;
													}
													base.Invoke(this.dlgUpdateMachineStatus, new object[]
													{
														this.CurStatus
													});
													this.Printing = true;
													this.OKReceived = true;
													this.sigPowerResume.Post();
												}
												else if (DataBuff[9] == 12)
												{
												}
											}
											break;
										}
										case 10:
											b = DataBuff[9];
											switch (b)
											{
											case 1:
												if (DataBuff[10] == 0)
												{
													MessageBox.Show("Machine Resize Success!");
												}
												else
												{
													MessageBox.Show("Machine Resize Fail!");
												}
												break;
											case 2:
											case 4:
												base.Invoke(this.dlgUpdateCalibrateButtonEnable, new object[]
												{
													true
												});
												break;
											case 3:
											case 5:
											case 6:
											case 9:
												break;
											case 7:
											case 8:
												base.Invoke(this.dlgUpdateCalibrateButtonEnable, new object[]
												{
													false
												});
												break;
											case 10:
											{
												TextBox[] tmpBox = new TextBox[1];
												txt = new string[1];
												tmpBox[0] = this.txtLaserFocusHeight;
												int j = 11;
												int lValue = 0;
												for (int i = 0; i < 4; i++)
												{
													lValue = (lValue << 8 | (int)DataBuff[j++]);
												}
												tmpfloat[0] = (float)lValue / 1000f;
												txt[0] = tmpfloat[0].ToString("F2");
												base.Invoke(this.dlgSetSize, new object[]
												{
													tmpBox,
													txt
												});
												break;
											}
											case 11:
												if (DataBuff[10] == 0)
												{
													MessageBox.Show("Save Focus Success!");
												}
												else
												{
													MessageBox.Show("Save Focus Fail!");
												}
												break;
											case 12:
												if (DataBuff[10] == 0)
												{
													MessageBox.Show("Enter Set Focus Success!");
												}
												else
												{
													MessageBox.Show("Enter Set Focus Fail!");
												}
												break;
											case 13:
												MessageBox.Show("Process Success!");
												break;
											default:
												if (b == 20)
												{
													TextBox[] tmpBox = new TextBox[6];
													CheckBox[] tmpcbBox = new CheckBox[6];
													tmpBox[0] = this.txtXSize;
													tmpBox[1] = this.txtYSize;
													tmpBox[2] = this.txtZSize;
													tmpBox[3] = this.txtXOffset;
													tmpBox[4] = this.txtYOffset;
													tmpBox[5] = this.txtZOffset;
													tmpcbBox[0] = this.cbXDir;
													tmpcbBox[1] = this.cbYDir;
													tmpcbBox[2] = this.cbZDir;
													tmpcbBox[3] = this.cbXHomeDir;
													tmpcbBox[4] = this.cbYHomeDir;
													tmpcbBox[5] = this.cbZHomeDir;
													int j = 12;
													for (int k = 0; k < 3; k++)
													{
														int lValue = 0;
														for (int i = 0; i < 4; i++)
														{
															lValue = (lValue << 8 | (int)DataBuff[j++]);
														}
														tmpfloat[k] = (float)lValue / 1000f;
														txt[k] = tmpfloat[k].ToString("F2");
													}
													bool[] tmpbool = new bool[6];
													for (int k = 0; k < 6; k++)
													{
														int lValue = 0;
														for (int i = 0; i < 4; i++)
														{
															lValue = (lValue << 8 | (int)DataBuff[j++]);
														}
														if (lValue > 0)
														{
															tmpbool[k] = true;
														}
														else
														{
															tmpbool[k] = false;
														}
													}
													for (int k = 3; k < 6; k++)
													{
														int lValue = 0;
														for (int i = 0; i < 4; i++)
														{
															lValue = (lValue << 8 | (int)DataBuff[j++]);
														}
														tmpfloat[k] = (float)lValue / 1000f;
														txt[k] = tmpfloat[k].ToString("F2");
													}
													base.Invoke(this.dlgSetSize, new object[]
													{
														tmpBox,
														txt
													});
													base.Invoke(this.dlgSetDirStatus, new object[]
													{
														tmpcbBox,
														tmpbool
													});
												}
												break;
											}
											break;
										case 12:
											b = DataBuff[9];
											if (b == 1)
											{
												if (DataBuff[10] == 0)
												{
													MessageBox.Show("Movement Response Success!");
												}
												else
												{
													MessageBox.Show("Movement Response Fail!");
												}
											}
											break;
										case 14:
										{
											clsWifi Wifi = new clsWifi();
											Wifi.WifiParse(SrcData);
											break;
										}
										default:
											if (b == 18)
											{
												this.LightBar.Parse(SrcData);
												if (DataBuff[9] == 1)
												{
													base.Invoke(this.dlgUpdateLightbarStatus, new object[]
													{
														this.LightBar.LightData
													});
												}
											}
											break;
										}
									}
									else if (b != 119)
									{
										if (b != 154)
										{
											if (b == 170)
											{
												if (DataBuff[9] != 0)
												{
													if (DataBuff[9] == 1)
													{
														ushort PackIndex = (ushort)((int)DataBuff[10] << 8 | (int)DataBuff[11]);
														List<byte> Data = new List<byte>();
														if (this.MyUpdate.Packs != 0)
														{
															if (PackIndex <= this.MyUpdate.Packs)
															{
																byte[] FileData = this.MyUpdate.GetUpdatePack(PackIndex);
																if (FileData == null)
																{
																	Data.Add(2);
																	this.SendCustomProtocol(169, Data.ToArray());
																}
																else
																{
																	Data.Add(1);
																	Data.Add((byte)(PackIndex >> 8));
																	Data.Add((byte)PackIndex);
																	Data.AddRange(FileData);
																	this.SendCustomProtocol(169, Data.ToArray());
																	base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
																	{
																		this.labUpdateProgress,
																		((int)(PackIndex + 1)).ToString() + "/" + this.MyUpdate.Packs.ToString()
																	});
																}
															}
														}
													}
													else if (DataBuff[9] == 2)
													{
														MessageBox.Show("升级完成，请重新启动");
														base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
														{
															this.labUpdateProgress,
															"Complete"
														});
													}
													else if (DataBuff[9] == 3)
													{
														List<byte> lBuff = new List<byte>();
														for (int i = 0; i < 32; i++)
														{
															lBuff.Add(DataBuff[10 + i]);
															if (DataBuff[10 + i] == 0)
															{
																break;
															}
														}
														MessageBox.Show("版本号：" + Encoding.Default.GetString(lBuff.ToArray()));
													}
													else if (DataBuff[9] == 4)
													{
														if (DataBuff[10] == 1)
														{
															base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
															{
																this.labUpdateProgress,
																"0/" + this.MyUpdate.Packs.ToString()
															});
															byte eventID = 169;
															byte[] datas = new byte[1];
															this.SendCustomProtocol(eventID, datas);
														}
													}
													else if (DataBuff[9] == 7)
													{
														clsUpdate UpdateParse = new clsUpdate();
														UpdateParse.ParseModuleVersion(SrcData);
														string[] Res = UpdateParse.ToStringArray();
														foreach (string tmpstr in Res)
														{
															base.Invoke(this.dlgAddItemToList, new object[]
															{
																this.lstModuleVersions,
																tmpstr
															});
														}
													}
												}
											}
										}
										else
										{
											this.debug_test.ClearLinearModuleInfo();
											this.debug_test.Parse(SrcData);
											if (this.debug_test.GetLastOpcode() == 2)
											{
												if (this.debug_test.GetModuleCount() > 0)
												{
													for (int i = 0; i < this.debug_test.GetModuleCount(); i++)
													{
														base.Invoke(this.dlgAddItemToList, new object[]
														{
															this.lstModuleInfo,
															this.debug_test.GetModuleMacID(i).ToString("X08")
														});
													}
												}
											}
											else if (this.debug_test.GetLastOpcode() == 4)
											{
												if (this.debug_test.GetModuleCount() > 0)
												{
													for (int i = 0; i < this.debug_test.GetModuleCount(); i++)
													{
														base.Invoke(this.dlgAddItemToList, new object[]
														{
															this.lstModuleInfo,
															this.debug_test.GetModuleMacID(i).ToString("X08") + "- Len" + this.debug_test.GetModuleLength(i).ToString()
														});
													}
												}
											}
											else if (this.debug_test.GetLastOpcode() == 6)
											{
												if (this.debug_test.GetModuleCount() > 0)
												{
													for (int i = 0; i < this.debug_test.GetModuleCount(); i++)
													{
														base.Invoke(this.dlgAddItemToList, new object[]
														{
															this.lstModuleInfo,
															this.debug_test.GetModuleMacID(i).ToString("X08") + "- Lead" + this.debug_test.GetModuleLead(i).ToString()
														});
													}
												}
											}
										}
									}
									else
									{
										string strToShow;
										if (DataBuff[9] == 1)
										{
											strToShow = "Power Paninc Valid";
											if (DataBuff[10] == 0)
											{
												strToShow += " UDisk";
											}
											else if (DataBuff[10] == 1)
											{
												strToShow += " Screen";
											}
											else if (DataBuff[10] == 2)
											{
												strToShow += " PC";
											}
											strToShow = strToShow + " Pos:" + ((uint)((int)DataBuff[11] << 24 | (int)DataBuff[12] << 16 | (int)DataBuff[13] << 8 | (int)DataBuff[14])).ToString();
										}
										else
										{
											strToShow = "Power Paninc Inalid";
										}
										MessageBox.Show(strToShow);
									}
									this.mtxSerialBuff.ReleaseMutex();
								}
							}
						}
					}
				}
				else
				{
					Thread.Sleep(5);
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000068A0 File Offset: 0x00004AA0
		private void GocdeSendThread(object obj)
		{
			for (;;)
			{
				if (this.HmiCommandBuff.Count > 0)
				{
					try
					{
						int sendlen;
						if (this.HmiCommandBuff.Count > 128)
						{
							sendlen = 128;
						}
						else
						{
							sendlen = this.HmiCommandBuff.Count;
						}
						this.spPort.Write(this.HmiCommandBuff.ToArray(), 0, sendlen);
						this.HmiCommandBuff.RemoveRange(0, sendlen);
					}
					catch
					{
					}
				}
				else if (this.OKReceived)
				{
					if (this.SendBuff.Count > 0)
					{
						this.SendGcode(this.SendBuff[0], this.BuffIndex[0]);
						this.OKReceived = false;
						this.SendIndex++;
						this.SendBuff.RemoveAt(0);
						this.BuffIndex.RemoveAt(0);
					}
					else if ((ulong)this.FileLineIndex < (ulong)((long)this.FileLines.Count) && this.Printing)
					{
						this.SendPrintingGcode(this.FileLines[(int)this.FileLineIndex], this.FileLineIndex);
						this.OKReceived = false;
						int pro = (int)((double)((ulong)(this.FileLineIndex * 100u) / (ulong)((long)this.FileLines.Count)) + 0.5);
						base.Invoke(this.dlgSetProgressBarValue, new object[]
						{
							pro
						});
						this.SendIndex++;
						this.FileLineIndex += 1u;
					}
					else if ((ulong)this.FileLineIndex == (ulong)((long)this.FileLines.Count) && this.FileLineIndex != 0u)
					{
						this.FileLineIndex += 1u;
						this.Printing = false;
						this.SendCustomProtocol(7, new byte[]
						{
							7
						});
					}
					else
					{
						Thread.Sleep(5);
					}
					base.Invoke(this.dlgSetLableText, new object[]
					{
						this.labBuffLines,
						this.SendBuff.Count<string>().ToString()
					});
				}
				else
				{
					Thread.Sleep(5);
					base.Invoke(this.dlgSetLableText, new object[]
					{
						this.labBuffLines,
						this.SendBuff.Count<string>().ToString()
					});
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006B4C File Offset: 0x00004D4C
		private void SendGcode(string Text, uint Index)
		{
			List<byte> SendBuff = new List<byte>();
			SendBuff.Add(170);
			SendBuff.Add(85);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(1);
			SendBuff.Add((byte)(Index >> 24));
			SendBuff.Add((byte)(Index >> 16));
			SendBuff.Add((byte)(Index >> 8));
			SendBuff.Add((byte)Index);
			SendBuff.AddRange(Encoding.Default.GetBytes(Text + "\r\n"));
			SendBuff[2] = (byte)(SendBuff.Count - 8 >> 8);
			SendBuff[3] = (byte)(SendBuff.Count - 8);
			SendBuff[5] = (byte)(SendBuff[2] ^ SendBuff[3]);
			uint Checksum = 0u;
			for (int i = 8; i < SendBuff.Count - 1; i += 2)
			{
				Checksum += (uint)((int)SendBuff[i] << 8 | (int)SendBuff[i + 1]);
			}
			if ((SendBuff.Count - 8) % 2 != 0)
			{
				Checksum += (uint)SendBuff[SendBuff.Count - 1];
			}
			while (Checksum > 65535u)
			{
				Checksum = (Checksum >> 16 & 65535u) + (Checksum & 65535u);
			}
			Checksum = ~Checksum;
			SendBuff[6] = (byte)(Checksum >> 8);
			SendBuff[7] = (byte)Checksum;
			try
			{
				this.spPort.Write(SendBuff.ToArray(), 0, SendBuff.Count);
			}
			catch
			{
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006CF0 File Offset: 0x00004EF0
		private void SendPrintingGcode(string Text, uint Index)
		{
			List<byte> SendBuff = new List<byte>();
			SendBuff.Add(170);
			SendBuff.Add(85);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(3);
			SendBuff.Add((byte)(Index >> 24));
			SendBuff.Add((byte)(Index >> 16));
			SendBuff.Add((byte)(Index >> 8));
			SendBuff.Add((byte)Index);
			SendBuff.AddRange(Encoding.Default.GetBytes(Text + "\r\n"));
			SendBuff[2] = (byte)(SendBuff.Count - 8 >> 8);
			SendBuff[3] = (byte)(SendBuff.Count - 8);
			SendBuff[5] = (byte)(SendBuff[2] ^ SendBuff[3]);
			uint Checksum = 0u;
			for (int i = 8; i < SendBuff.Count - 1; i += 2)
			{
				Checksum += (uint)((int)SendBuff[i] << 8 | (int)SendBuff[i + 1]);
			}
			if ((SendBuff.Count - 8) % 2 != 0)
			{
				Checksum += (uint)SendBuff[SendBuff.Count - 1];
			}
			while (Checksum > 65535u)
			{
				Checksum = (Checksum >> 16 & 65535u) + (Checksum & 65535u);
			}
			Checksum = ~Checksum;
			SendBuff[6] = (byte)(Checksum >> 8);
			SendBuff[7] = (byte)Checksum;
			try
			{
				this.spPort.Write(SendBuff.ToArray(), 0, SendBuff.Count);
			}
			catch
			{
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006E94 File Offset: 0x00005094
		private void button1_Click(object sender, EventArgs e)
		{
			this.picStatus.BackColor = Color.Gray;
			this.labExecuter.Text = "";
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006EBC File Offset: 0x000050BC
		private void btnPause_Click(object sender, EventArgs e)
		{
			this.Printing = false;
			this.SendCustomProtocol(7, new byte[]
			{
				4
			});
			this.btnPause.Enabled = false;
			this.btnStop.Enabled = false;
			this.btnStartPrint.Enabled = false;
			this.btnContinue.Enabled = false;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006F1C File Offset: 0x0000511C
		private void btnContinue_Click(object sender, EventArgs e)
		{
			if (this.CurStatus.PrintingStatus == 4)
			{
				this.GetNextCommandLine();
				this.semCommand = new Semaphore(0, 1);
				if (this.semCommand.WaitOne(20000))
				{
					this.SendCustomProtocol(7, new byte[]
					{
						5
					});
				}
				else
				{
					MessageBox.Show("恢复失败，下位机没应答");
				}
				this.semCommand = null;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006F98 File Offset: 0x00005198
		private void GetNextCommandLine()
		{
			this.SendCustomProtocol(7, new byte[]
			{
				8
			});
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006FBC File Offset: 0x000051BC
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(7, new byte[]
			{
				6
			});
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006FE0 File Offset: 0x000051E0
		private void btnUp_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.cmdMoveAxisDis.Text);
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 Y" + Dis.ToString("F2") + " F" + this.txtMoveSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007098 File Offset: 0x00005298
		private void btnDown_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.cmdMoveAxisDis.Text);
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 Y-" + Dis.ToString("F2") + " F" + this.txtMoveSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007150 File Offset: 0x00005350
		private void btnLeft_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.cmdMoveAxisDis.Text);
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 X-" + Dis.ToString("F2") + " F" + this.txtMoveSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007208 File Offset: 0x00005408
		private void btnRight_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.cmdMoveAxisDis.Text);
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 X" + Dis.ToString("F2") + " F" + this.txtMoveSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000072C0 File Offset: 0x000054C0
		private void btnZUp_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.cmdMoveAxisDis.Text);
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 Z" + Dis.ToString("F2") + " F" + this.txtMoveSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007378 File Offset: 0x00005578
		private void btnZDown_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.cmdMoveAxisDis.Text);
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 Z-" + Dis.ToString("F2") + " F" + this.txtMoveSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007430 File Offset: 0x00005630
		private void SendButtonCommand(uint ButtonID)
		{
			this.SendCustomProtocol(17, new byte[]
			{
				(byte)(ButtonID >> 24),
				(byte)(ButtonID >> 16),
				(byte)(ButtonID >> 8),
				(byte)ButtonID
			});
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000746C File Offset: 0x0000566C
		private void btnCaliHome_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new byte[]
			{
				4
			});
			this.btnZAutoCalibrate.Enabled = false;
			this.btnCaliHome.Enabled = false;
			this.btnCaliBack.Enabled = false;
			this.btnCaliSave.Enabled = false;
			this.btnCaliZDown.Enabled = false;
			this.btnCaliZUp.Enabled = false;
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Enabled = false;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007500 File Offset: 0x00005700
		private void btnCaliPoint_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			for (int i = 0; i < 9; i++)
			{
				if (btn == this.btnCaliPoint[i])
				{
					this.SendCustomProtocol(9, new byte[]
					{
						5,
						(byte)(i + 1)
					});
					break;
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000755C File Offset: 0x0000575C
		private void btnCaliZUp_Click(object sender, EventArgs e)
		{
			int dis = (int)(float.Parse(this.cmbCaliZDis.Text) * 1000f);
			this.SendCustomProtocol(9, new byte[]
			{
				6,
				(byte)(dis >> 24),
				(byte)(dis >> 16),
				(byte)(dis >> 8),
				(byte)dis
			});
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000075B4 File Offset: 0x000057B4
		private void btnCaliZDown_Click(object sender, EventArgs e)
		{
			int dis = (int)(float.Parse(this.cmbCaliZDis.Text) * 1000f);
			dis = -dis;
			this.SendCustomProtocol(9, new byte[]
			{
				6,
				(byte)(dis >> 24),
				(byte)(dis >> 16),
				(byte)(dis >> 8),
				(byte)dis
			});
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00007610 File Offset: 0x00005810
		private void btnZAutoCalibrate_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new byte[]
			{
				2
			});
			this.btnZAutoCalibrate.Enabled = false;
			this.btnCaliHome.Enabled = false;
			this.btnCaliBack.Enabled = false;
			this.btnCaliSave.Enabled = false;
			this.btnCaliZDown.Enabled = false;
			this.btnCaliZUp.Enabled = false;
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Enabled = false;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000076A4 File Offset: 0x000058A4
		private void btnCaliSave_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new byte[]
			{
				7
			});
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Enabled = false;
			}
			this.btnCaliZDown.Enabled = false;
			this.btnCaliZUp.Enabled = false;
			this.btnCaliBack.Enabled = false;
			this.btnCaliSave.Enabled = false;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000771C File Offset: 0x0000591C
		private void btnCaliBack_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new byte[]
			{
				8
			});
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Enabled = false;
			}
			this.btnCaliZDown.Enabled = false;
			this.btnCaliZUp.Enabled = false;
			this.btnCaliBack.Enabled = false;
			this.btnCaliSave.Enabled = false;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007794 File Offset: 0x00005994
		private void btnCaliReset_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new byte[]
			{
				9
			});
			this.btnZAutoCalibrate.Enabled = false;
			this.btnCaliHome.Enabled = false;
			this.btnCaliBack.Enabled = false;
			this.btnCaliSave.Enabled = false;
			this.btnCaliZDown.Enabled = false;
			this.btnCaliZUp.Enabled = false;
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Enabled = false;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007828 File Offset: 0x00005A28
		private void btnOpenUDisk_Click(object sender, EventArgs e)
		{
			byte eventID = 5;
			byte[] datas = new byte[1];
			this.SendCustomProtocol(eventID, datas);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007848 File Offset: 0x00005A48
		private void btnGetFileList_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(5, new byte[]
			{
				4
			});
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000786C File Offset: 0x00005A6C
		private void btnOpenDirectory_Click(object sender, EventArgs e)
		{
			if (this.lstFiles.SelectedIndex >= 0)
			{
				string strItem = this.lstFiles.Items[this.lstFiles.SelectedIndex].ToString();
				if (strItem.Substring(0, 4) == "_Dir")
				{
					string relPath = strItem.Substring(5, strItem.Length - 5);
					List<byte> SendBuff = new List<byte>();
					SendBuff.Add(2);
					SendBuff.AddRange(Encoding.Default.GetBytes(relPath));
					SendBuff.Add(0);
					this.SendCustomProtocol(5, SendBuff.ToArray());
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007914 File Offset: 0x00005B14
		private void btnGetSpecialContent_Click(object sender, EventArgs e)
		{
			this.SpecialContents = new List<byte>();
			if (this.lstFiles.SelectedIndex >= 0)
			{
				string strItem = this.lstFiles.Items[this.lstFiles.SelectedIndex].ToString();
				string FileName = strItem;
				List<byte> SendBuff = new List<byte>();
				SendBuff.Add(5);
				SendBuff.AddRange(Encoding.Default.GetBytes(FileName));
				SendBuff.Add(0);
				this.SendCustomProtocol(5, SendBuff.ToArray());
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000799A File Offset: 0x00005B9A
		private void lstFiles_DoubleClick(object sender, EventArgs e)
		{
			this.lstFiles.Items.Clear();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000079B0 File Offset: 0x00005BB0
		private void btnGetCurPath_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(5, new byte[]
			{
				1
			});
			this.labCurrentPath.Text = "";
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000079E3 File Offset: 0x00005BE3
		private void btnAllHome_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G28");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007A10 File Offset: 0x00005C10
		private void btnSMCMaker_Click(object sender, EventArgs e)
		{
			frmSMCMaker newForm = new frmSMCMaker();
			newForm.ShowDialog(this);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007A2C File Offset: 0x00005C2C
		private void lstSpecialContents_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lstSpecialContents.SelectedIndex >= 0)
			{
				int Index = this.lstSpecialContents.SelectedIndex;
				int ItemPos = (int)this.ItemStartPos[Index];
				uint Len = (uint)((int)this.SpecialContents[ItemPos + 11] << 24 | (int)this.SpecialContents[ItemPos + 10] << 16 | (int)this.SpecialContents[ItemPos + 9] << 8 | (int)this.SpecialContents[ItemPos + 8]);
				byte[] tmpByte = new byte[Len];
				Array.Copy(this.SpecialContents.ToArray(), (long)(ItemPos + 12), tmpByte, 0L, (long)((ulong)Len));
				if (this.lstSpecialContents.Items[Index].ToString() == "TXT")
				{
					this.richTextBox1.Text = "";
					this.richTextBox1.Text = Encoding.Default.GetString(tmpByte);
				}
				else if (this.lstSpecialContents.Items[Index].ToString() == "JPG")
				{
					Image newimage = Image.FromStream(new MemoryStream(tmpByte));
					this.picSpeical.Image = newimage;
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007B74 File Offset: 0x00005D74
		private void btnUDiskPrint_Click(object sender, EventArgs e)
		{
			if (this.lstFiles.SelectedIndex >= 0)
			{
				string strItem = this.lstFiles.Items[this.lstFiles.SelectedIndex].ToString();
				string FileName = strItem;
				List<byte> SendBuff = new List<byte>();
				SendBuff.Add(6);
				SendBuff.AddRange(Encoding.Default.GetBytes(FileName));
				this.SendCustomProtocol(5, SendBuff.ToArray());
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007BE8 File Offset: 0x00005DE8
		private void tbHeadTamp_MouseUp(object sender, MouseEventArgs e)
		{
			int Value = this.tbHeadTamp.Value;
			this.labHeadSetTamp.Text = Value.ToString();
			this.SendBuff.Add("M104 S" + this.labHeadSetTamp.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007C50 File Offset: 0x00005E50
		private void tbHeadTamp_Scroll(object sender, EventArgs e)
		{
			int Value = this.tbHeadTamp.Value;
			this.labHeadSetTamp.Text = Value.ToString();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007C80 File Offset: 0x00005E80
		private void tbBedTamp_MouseUp(object sender, MouseEventArgs e)
		{
			int Value = this.tbBedTamp.Value;
			this.labBedSetTamp.Text = Value.ToString();
			this.SendBuff.Add("M140 S" + this.labBedSetTamp.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007CE8 File Offset: 0x00005EE8
		private void tbBedTamp_Scroll(object sender, EventArgs e)
		{
			int Value = this.tbBedTamp.Value;
			this.labBedSetTamp.Text = Value.ToString();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007D15 File Offset: 0x00005F15
		private void btnFlush_Click(object sender, EventArgs e)
		{
			this.SendBuff.Clear();
			this.BuffIndex.Clear();
			this.HmiCommandBuff.Clear();
			this.OKReceived = true;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007D44 File Offset: 0x00005F44
		private void btnExtrude_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 E" + this.txtExtrudeLength.Text + " F" + this.txtExtrudeSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007DEC File Offset: 0x00005FEC
		private void btnReExtrude_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G91");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 E-" + this.txtExtrudeLength.Text + " F" + this.txtExtrudeSpeed.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007E92 File Offset: 0x00006092
		private void btnFan1On_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M106 P0 S255");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007EBD File Offset: 0x000060BD
		private void btnFan1Off_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M107 P0");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007EE8 File Offset: 0x000060E8
		private void btnFan2On_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M106 P1 S255");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007F13 File Offset: 0x00006113
		private void btnFan2Off_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M107 P1");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007F40 File Offset: 0x00006140
		private void btnGetPowerPanicData_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(7, new byte[]
			{
				8
			});
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007F64 File Offset: 0x00006164
		private void btnCheckFault_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(7, new byte[]
			{
				2
			});
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007F88 File Offset: 0x00006188
		private void btnClearFault_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(7, new byte[]
			{
				10
			});
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007FAC File Offset: 0x000061AC
		private void btnPowerPanicContinue_Click(object sender, EventArgs e)
		{
			if (this.PowerPanicSource == 0)
			{
				this.SendCustomProtocol(7, new byte[]
				{
					12
				});
			}
			else if (this.PowerPanicSource == 1)
			{
				this.SendCustomProtocol(7, new byte[]
				{
					11
				});
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000800C File Offset: 0x0000620C
		private void btnTrigglePowerPanic_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(153, new byte[]
			{
				0
			});
			this.Printing = false;
			this.FileLineIndex = 0u;
			this.OKReceived = true;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008048 File Offset: 0x00006248
		private void SendCustomProtocol(byte EventID, byte[] Datas)
		{
			List<byte> SendBuff = new List<byte>();
			SendBuff.Add(170);
			SendBuff.Add(85);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(0);
			SendBuff.Add(EventID);
			if (Datas != null)
			{
				SendBuff.AddRange(Datas);
			}
			SendBuff[2] = (byte)(SendBuff.Count - 8 >> 8);
			SendBuff[3] = (byte)(SendBuff.Count - 8);
			SendBuff[5] = (byte)(SendBuff[2] ^ SendBuff[3]);
			uint Checksum = 0u;
			for (int i = 8; i < SendBuff.Count - 1; i += 2)
			{
				Checksum += (uint)((int)SendBuff[i] << 8 | (int)SendBuff[i + 1]);
			}
			if ((SendBuff.Count - 8) % 2 != 0)
			{
				Checksum += (uint)SendBuff[SendBuff.Count - 1];
			}
			while (Checksum > 65535u)
			{
				Checksum = (Checksum >> 16 & 65535u) + (Checksum & 65535u);
			}
			Checksum = ~Checksum;
			SendBuff[6] = (byte)(Checksum >> 8);
			SendBuff[7] = (byte)Checksum;
			this.mtxHmiBuff.WaitOne();
			this.HmiCommandBuff.AddRange(SendBuff.ToArray());
			this.mtxHmiBuff.ReleaseMutex();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000081AA File Offset: 0x000063AA
		private void cbAutoCheckStatus_CheckedChanged(object sender, EventArgs e)
		{
			this.AutoCheckStatus = this.cbAutoCheckStatus.Checked;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000081C0 File Offset: 0x000063C0
		private void tbLaserPower_Scroll(object sender, EventArgs e)
		{
			this.labLaserPower.Text = this.tbLaserPower.Value.ToString();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000081F0 File Offset: 0x000063F0
		private void tbLaserPower_MouseUp(object sender, MouseEventArgs e)
		{
			int Value = this.tbLaserPower.Value;
			this.labLaserPower.Text = Value.ToString();
			this.SendBuff.Add("M3 P" + this.labLaserPower.Text);
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008255 File Offset: 0x00006455
		private void btnSetOriginal_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G92 X0 Y0");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008280 File Offset: 0x00006480
		private void tbRPM_Scroll(object sender, EventArgs e)
		{
			int RPM = this.tbRPM.Value;
			this.labTargetRPM.Text = RPM.ToString();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000082B0 File Offset: 0x000064B0
		private void tbRPM_MouseUp(object sender, MouseEventArgs e)
		{
			int RPM = this.tbRPM.Value;
			this.SendBuff.Add("M3 P" + RPM.ToString());
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008300 File Offset: 0x00006500
		private void btnSetSize_Click(object sender, EventArgs e)
		{
			int[] Dir = new int[3];
			int[] HomeDir = new int[3];
			int[] Offset = new int[3];
			int X = (int)(float.Parse(this.txtXSize.Text) * 1000f);
			int Y = (int)(float.Parse(this.txtYSize.Text) * 1000f);
			int Z = (int)(float.Parse(this.txtZSize.Text) * 1000f);
			if (this.cbXDir.Checked)
			{
				Dir[0] = 1;
			}
			else
			{
				Dir[0] = -1;
			}
			if (this.cbYDir.Checked)
			{
				Dir[1] = 1;
			}
			else
			{
				Dir[1] = -1;
			}
			if (this.cbZDir.Checked)
			{
				Dir[2] = 1;
			}
			else
			{
				Dir[2] = -1;
			}
			if (this.cbXHomeDir.Checked)
			{
				HomeDir[0] = 1;
			}
			else
			{
				HomeDir[0] = -1;
			}
			if (this.cbYHomeDir.Checked)
			{
				HomeDir[1] = 1;
			}
			else
			{
				HomeDir[1] = -1;
			}
			if (this.cbZHomeDir.Checked)
			{
				HomeDir[2] = 1;
			}
			else
			{
				HomeDir[2] = -1;
			}
			List<byte> tmpbyte = new List<byte>();
			tmpbyte.Add(1);
			tmpbyte.Add((byte)(X >> 24));
			tmpbyte.Add((byte)(X >> 16));
			tmpbyte.Add((byte)(X >> 8));
			tmpbyte.Add((byte)X);
			tmpbyte.Add((byte)(Y >> 24));
			tmpbyte.Add((byte)(Y >> 16));
			tmpbyte.Add((byte)(Y >> 8));
			tmpbyte.Add((byte)Y);
			tmpbyte.Add((byte)(Z >> 24));
			tmpbyte.Add((byte)(Z >> 16));
			tmpbyte.Add((byte)(Z >> 8));
			tmpbyte.Add((byte)Z);
			for (int i = 0; i < 3; i++)
			{
				tmpbyte.Add((byte)(HomeDir[i] >> 24));
				tmpbyte.Add((byte)(HomeDir[i] >> 16));
				tmpbyte.Add((byte)(HomeDir[i] >> 8));
				tmpbyte.Add((byte)HomeDir[i]);
			}
			for (int i = 0; i < 3; i++)
			{
				tmpbyte.Add((byte)(Dir[i] >> 24));
				tmpbyte.Add((byte)(Dir[i] >> 16));
				tmpbyte.Add((byte)(Dir[i] >> 8));
				tmpbyte.Add((byte)Dir[i]);
			}
			Offset[0] = (int)(float.Parse(this.txtXOffset.Text) * 1000f);
			Offset[1] = (int)(float.Parse(this.txtYOffset.Text) * 1000f);
			Offset[2] = (int)(float.Parse(this.txtZOffset.Text) * 1000f);
			for (int i = 0; i < 3; i++)
			{
				tmpbyte.Add((byte)(Offset[i] >> 24));
				tmpbyte.Add((byte)(Offset[i] >> 16));
				tmpbyte.Add((byte)(Offset[i] >> 8));
				tmpbyte.Add((byte)Offset[i]);
			}
			this.SendCustomProtocol(9, tmpbyte.ToArray());
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008624 File Offset: 0x00006824
		private void btnGetSize_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new List<byte>
			{
				20
			}.ToArray());
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008650 File Offset: 0x00006850
		private void btnReleaeButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 9; i++)
			{
				this.btnCaliPoint[i].Enabled = true;
			}
			this.btnCaliZUp.Enabled = true;
			this.btnCaliZDown.Enabled = true;
			this.btnCaliSave.Enabled = true;
			this.btnCaliBack.Enabled = true;
			this.btnCaliHome.Enabled = true;
			this.btnZAutoCalibrate.Enabled = true;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000086CC File Offset: 0x000068CC
		private void btnLaserEnterSetFocus_Click(object sender, EventArgs e)
		{
			List<byte> lData = new List<byte>();
			lData.Add(12);
			int fX = Convert.ToInt32(float.Parse(this.txtFocusX.Text) * 1000f);
			int fY = Convert.ToInt32(float.Parse(this.txtFocusY.Text) * 1000f);
			int fZ = Convert.ToInt32(float.Parse(this.txtFocusZ.Text) * 1000f);
			byte[] tmpData = BitConverter.GetBytes(fX);
			lData.AddRange(tmpData.Reverse<byte>());
			tmpData = BitConverter.GetBytes(fY);
			lData.AddRange(tmpData.Reverse<byte>());
			tmpData = BitConverter.GetBytes(fZ);
			lData.AddRange(tmpData.Reverse<byte>());
			this.SendCustomProtocol(9, lData.ToArray());
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008790 File Offset: 0x00006990
		private void btnDrawLaserCalibration_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new List<byte>
			{
				13
			}.ToArray());
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000087BC File Offset: 0x000069BC
		private void btnDrawRuler_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new List<byte>
			{
				14
			}.ToArray());
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000087E8 File Offset: 0x000069E8
		private void btnMovementRequire_Click(object sender, EventArgs e)
		{
			List<byte> lData = new List<byte>();
			int fX = Convert.ToInt32(float.Parse(this.txtMovementX.Text) * 1000f);
			int fY = Convert.ToInt32(float.Parse(this.txtMovementY.Text) * 1000f);
			int fZ = Convert.ToInt32(float.Parse(this.txtMovementZ.Text) * 1000f);
			if (this.cbMovementRelative.Checked)
			{
				lData.Add(3);
				byte[] tmpData = BitConverter.GetBytes(fX);
				lData.AddRange(tmpData.Reverse<byte>());
				tmpData = BitConverter.GetBytes(fY);
				lData.AddRange(tmpData.Reverse<byte>());
				tmpData = BitConverter.GetBytes(fZ);
				lData.AddRange(tmpData.Reverse<byte>());
			}
			else
			{
				lData.Add(2);
				byte[] tmpData = BitConverter.GetBytes(fX);
				lData.AddRange(tmpData.Reverse<byte>());
				tmpData = BitConverter.GetBytes(fY);
				lData.AddRange(tmpData.Reverse<byte>());
				tmpData = BitConverter.GetBytes(fZ);
				lData.AddRange(tmpData.Reverse<byte>());
			}
			this.SendCustomProtocol(11, lData.ToArray());
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008910 File Offset: 0x00006B10
		private void btnSetFocusHigh_Click(object sender, EventArgs e)
		{
			List<byte> tmpbyte = new List<byte>();
			float height = float.Parse(this.txtLaserFocusHeight.Text);
			uint Value = (uint)(height * 1000f);
			tmpbyte.Add(11);
			tmpbyte.Add((byte)(Value >> 24));
			tmpbyte.Add((byte)(Value >> 16));
			tmpbyte.Add((byte)(Value >> 8));
			tmpbyte.Add((byte)Value);
			this.SendCustomProtocol(9, tmpbyte.ToArray());
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008984 File Offset: 0x00006B84
		private void btnGetFocus_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(9, new List<byte>
			{
				10
			}.ToArray());
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000089B0 File Offset: 0x00006BB0
		private void btnEnableFilamentSensor_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M1011 S1");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000089DB File Offset: 0x00006BDB
		private void btnDisableFilamentSensor_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M1011 S0");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008A08 File Offset: 0x00006C08
		private void btnAuto_Click(object sender, EventArgs e)
		{
			this.sigPowerResume.Reset();
			this.SendCustomProtocol(7, new byte[]
			{
				2
			});
			if (!this.sigPowerResume.Wait(20000))
			{
				MessageBox.Show("Check fault fail!");
			}
			else if ((this.SysFaultFlag & 64u) != 0u)
			{
				this.SendCustomProtocol(7, new byte[]
				{
					8
				});
				if (this.sigPowerResume.Wait(20000))
				{
					if (this.PowerPanicSource == 1)
					{
						this.SendCustomProtocol(7, new byte[]
						{
							11
						});
						if (this.sigPowerResume.Wait(40000))
						{
							MessageBox.Show("Power power panic Resume success!");
						}
					}
					else
					{
						MessageBox.Show("Not online printing!");
					}
				}
				else
				{
					MessageBox.Show("Can not get the line number!");
				}
			}
			else
			{
				MessageBox.Show("No power panic");
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008B18 File Offset: 0x00006D18
		private void btnSetFeedRateMultiplier_Click(object sender, EventArgs e)
		{
			int Value;
			if (int.TryParse(this.txtM220.Text, out Value))
			{
				this.SendBuff.Add("M220 S" + this.txtM220.Text);
				this.BuffIndex.Add((uint)this.SendBuff.Count);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008B7C File Offset: 0x00006D7C
		private void button2_Click(object sender, EventArgs e)
		{
			float Dis = float.Parse(this.txtLaserFocusHeight.Text);
			this.SendBuff.Add("G90");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
			this.SendBuff.Add("G0 Z" + Dis.ToString("F2") + " F2400");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008C01 File Offset: 0x00006E01
		private void btnFanOn_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M106 S255");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00008C2C File Offset: 0x00006E2C
		private void btnFanOff_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M106 S0");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008C57 File Offset: 0x00006E57
		private void btnLaserFocusOn_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M3 P2");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00008C82 File Offset: 0x00006E82
		private void btnLaserFocusOff_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("M5");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008CAD File Offset: 0x00006EAD
		private void btnLaserZHome_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G28 Z");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008CD8 File Offset: 0x00006ED8
		private void btnZOriginal_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G92 X0 Y0 Z0");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008D04 File Offset: 0x00006F04
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (this.MyUpdate.OpenFile())
			{
				if (this.MyUpdate.FirmwareType == "MainBoard")
				{
					List<byte> SendBuff = new List<byte>();
					SendBuff.Add(4);
					SendBuff.AddRange(Encoding.Default.GetBytes(this.MyUpdate.GetVersion()));
					this.SendCustomProtocol(169, SendBuff.ToArray());
				}
				else
				{
					base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
					{
						this.labUpdateProgress,
						"0/" + this.MyUpdate.Packs.ToString()
					});
					byte eventID = 169;
					byte[] datas = new byte[1];
					this.SendCustomProtocol(eventID, datas);
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008DD8 File Offset: 0x00006FD8
		private void btnSetWifiParameter_Click(object sender, EventArgs e)
		{
			if (this.spPort.IsOpen)
			{
				byte[] bSSID = Encoding.Default.GetBytes(this.txtSSID.Text);
				byte[] bPWD = Encoding.Default.GetBytes(this.txtPassword.Text);
				List<byte> lData = new List<byte>();
				lData.Add(1);
				lData.AddRange(bSSID);
				lData.Add(0);
				lData.AddRange(bPWD);
				lData.Add(0);
				this.SendCustomProtocol(13, lData.ToArray());
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008E60 File Offset: 0x00007060
		private void btnGetCameraIP_Click(object sender, EventArgs e)
		{
			if (this.spPort.IsOpen)
			{
				this.SendCustomProtocol(13, new List<byte>
				{
					2
				}.ToArray());
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00008E9C File Offset: 0x0000709C
		private void button3_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(7, new List<byte>
			{
				1
			}.ToArray());
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00008EC8 File Offset: 0x000070C8
		private void btnRequestFirmwareVersion_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(169, new List<byte>
			{
				3
			}.ToArray());
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008EF8 File Offset: 0x000070F8
		private void btnRequestModuleFirmwareVersion_Click(object sender, EventArgs e)
		{
			this.lstModuleVersions.Items.Clear();
			this.SendCustomProtocol(169, new List<byte>
			{
				7
			}.ToArray());
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008F38 File Offset: 0x00007138
		private void btnGetUpdateStatus_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(169, new List<byte>
			{
				5
			}.ToArray());
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008F68 File Offset: 0x00007168
		private void button6_Click(object sender, EventArgs e)
		{
			if (this.MyUpdate.OpenFile())
			{
				if (this.MyUpdate.FirmwareType == "MainBoard")
				{
					List<byte> SendBuff = new List<byte>();
					SendBuff.Add(4);
					SendBuff.AddRange(Encoding.Default.GetBytes(this.MyUpdate.GetVersion()));
					this.SendCustomProtocol(169, SendBuff.ToArray());
				}
				else
				{
					base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
					{
						this.labUpdateProgress,
						"0/" + this.MyUpdate.Packs.ToString()
					});
					byte eventID = 169;
					byte[] datas = new byte[1];
					this.SendCustomProtocol(eventID, datas);
				}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000903A File Offset: 0x0000723A
		private void EnterUpdate_CheckedChanged(object sender, EventArgs e)
		{
			this.EnteringUpdate = this.EnterUpdate.Checked;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00009050 File Offset: 0x00007250
		private void btnGetLightStatus_Click(object sender, EventArgs e)
		{
			this.SendCustomProtocol(17, new List<byte>
			{
				1
			}.ToArray());
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000907C File Offset: 0x0000727C
		private void rbLigthStatus_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbLigthStatus.Checked)
			{
				byte Brightness = (byte)this.tbLightBrightness.Value;
				this.SendCustomProtocol(17, new List<byte>
				{
					3,
					0,
					Brightness
				}.ToArray());
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000090D8 File Offset: 0x000072D8
		private void rbLightNormal_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbLightNormal.Checked)
			{
				this.SendCustomProtocol(17, new List<byte>
				{
					3,
					1
				}.ToArray());
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00009120 File Offset: 0x00007320
		private void cbLightOnoff_CheckedChanged(object sender, EventArgs e)
		{
			List<byte> lData = new List<byte>();
			lData.Add(2);
			if (this.cbLightOnoff.Checked)
			{
				lData.Add(1);
			}
			else
			{
				lData.Add(0);
			}
			this.SendCustomProtocol(17, lData.ToArray());
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009170 File Offset: 0x00007370
		private void btnOpenOriginFile_Click(object sender, EventArgs e)
		{
			bool ForceBit = this.cbForceUpdate.Checked;
			byte filetype;
			if (this.rbControler.Checked)
			{
				filetype = 0;
			}
			else
			{
				filetype = 1;
			}
			if (this.FirmwareCreater.OpenOriginFile(filetype, ForceBit))
			{
				this.MyUpdate.ParseByteBuff(this.FirmwareCreater.FileBuff);
				if (filetype == 0)
				{
					List<byte> SendBuff = new List<byte>();
					SendBuff.Add(4);
					SendBuff.AddRange(Encoding.Default.GetBytes(this.MyUpdate.GetVersion()));
					this.SendCustomProtocol(169, SendBuff.ToArray());
				}
				else
				{
					base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
					{
						this.labUpdateProgress,
						"0/" + this.MyUpdate.Packs.ToString()
					});
					byte eventID = 169;
					byte[] datas = new byte[1];
					this.SendCustomProtocol(eventID, datas);
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00009280 File Offset: 0x00007480
		private void btnCNCSetOrigin_Click(object sender, EventArgs e)
		{
			this.SendBuff.Add("G92 X0 Y0 Z0");
			this.BuffIndex.Add((uint)this.SendBuff.Count);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000092AB File Offset: 0x000074AB
		private void btnClearGcodeIndex_Click(object sender, EventArgs e)
		{
			this.RecvIndex = 0;
			this.SendIndex = 0;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000092BC File Offset: 0x000074BC
		private void btnOpenLog_Click(object sender, EventArgs e)
		{
			this.Log.Show();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000092CB File Offset: 0x000074CB
		private void btnOpenFilter_Click(object sender, EventArgs e)
		{
			this.FilterForm.Show();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000092DA File Offset: 0x000074DA
		private void lstModuleVersions_DoubleClick(object sender, EventArgs e)
		{
			this.lstModuleVersions.Items.Clear();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000092F0 File Offset: 0x000074F0
		private void btnLoadCustomGcodeFile_Click(object sender, EventArgs e)
		{
			GCodeFile custom_file = new GCodeFile();
			if (custom_file.Load())
			{
				this.rtbCustomFile.Clear();
				string[] FileLines = custom_file.GetFileLines();
				foreach (string tmp in FileLines)
				{
					this.rtbCustomFile.AppendText(tmp);
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00009358 File Offset: 0x00007558
		private void btnRunCustomGcode_Click(object sender, EventArgs e)
		{
			int repeattime = 1;
			if (!int.TryParse(this.txtCustomeRepeat.Text, out repeattime))
			{
				MessageBox.Show("重复次数有错");
			}
			else
			{
				do
				{
					for (int i = 0; i < this.rtbCustomFile.Lines.Count<string>(); i++)
					{
						this.SendBuff.Add(this.rtbCustomFile.Lines[i]);
						this.BuffIndex.Add((uint)this.SendBuff.Count);
					}
					repeattime--;
				}
				while (repeattime > 0);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000093EB File Offset: 0x000075EB
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000093F8 File Offset: 0x000075F8
		private void btnGetLinearModuleLength_Click(object sender, EventArgs e)
		{
			this.lstModuleInfo.Items.Clear();
			this.SendCustomProtocol(153, new List<byte>
			{
				4
			}.ToArray());
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00009438 File Offset: 0x00007638
		private void btnGetLinearModuleLead_Click(object sender, EventArgs e)
		{
			this.lstModuleInfo.Items.Clear();
			this.SendCustomProtocol(153, new List<byte>
			{
				6
			}.ToArray());
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009478 File Offset: 0x00007678
		private void btnSetMacID_Click(object sender, EventArgs e)
		{
			if (this.debug_test.GetModuleCount() > 0)
			{
				int select_index = this.lstModuleInfo.SelectedIndex;
				if (select_index >= 0)
				{
					uint new_id = Convert.ToUInt32(this.txtNewMacID.Text, 16);
					new_id = new_id;
					List<byte> tmpbyte = new List<byte>();
					tmpbyte.Add(1);
					byte[] bits_value = BitConverter.GetBytes(this.debug_test.GetModuleMacID(select_index));
					tmpbyte.AddRange(bits_value.Reverse<byte>());
					bits_value = BitConverter.GetBytes(new_id);
					tmpbyte.AddRange(bits_value.Reverse<byte>());
					this.SendCustomProtocol(153, tmpbyte.ToArray());
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00009528 File Offset: 0x00007728
		private void btnSetLinearModuleLength_Click(object sender, EventArgs e)
		{
			if (this.debug_test.GetModuleCount() > 0)
			{
				int select_index = this.lstModuleInfo.SelectedIndex;
				if (select_index >= 0)
				{
					float tmp_length = uint.Parse(this.txtNewLength.Text);
					uint int_length = (uint)((double)tmp_length * 1000.0);
					List<byte> tmpbyte = new List<byte>();
					tmpbyte.Add(3);
					byte[] bits_value = BitConverter.GetBytes(this.debug_test.GetModuleMacID(select_index));
					tmpbyte.AddRange(bits_value.Reverse<byte>());
					bits_value = BitConverter.GetBytes(int_length);
					tmpbyte.AddRange(bits_value.Reverse<byte>());
					this.SendCustomProtocol(153, tmpbyte.ToArray());
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000095E8 File Offset: 0x000077E8
		private void btnSetLinearModuleLead_Click(object sender, EventArgs e)
		{
			if (this.debug_test.GetModuleCount() > 0)
			{
				int select_index = this.lstModuleInfo.SelectedIndex;
				if (select_index >= 0)
				{
					float tmp_lead = float.Parse(this.txtNewLead.Text);
					uint int_lead = (uint)((double)tmp_lead * 1000.0);
					List<byte> tmpbyte = new List<byte>();
					tmpbyte.Add(5);
					byte[] bits_value = BitConverter.GetBytes(this.debug_test.GetModuleMacID(select_index));
					tmpbyte.AddRange(bits_value.Reverse<byte>());
					bits_value = BitConverter.GetBytes(int_lead);
					tmpbyte.AddRange(bits_value.Reverse<byte>());
					this.SendCustomProtocol(153, tmpbyte.ToArray());
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000096A4 File Offset: 0x000078A4
		private void lstModuleInfo_Click(object sender, EventArgs e)
		{
			if (this.debug_test.GetModuleCount() > 0)
			{
				int select_index = this.lstModuleInfo.SelectedIndex;
				if (select_index >= 0)
				{
					this.txtNewMacID.Text = this.debug_test.GetModuleMacID(select_index).ToString("X08");
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009708 File Offset: 0x00007908
		private void button11_Click(object sender, EventArgs e)
		{
			if (this.CurStatus.PrintingStatus == 4)
			{
				this.GetNextCommandLine();
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009734 File Offset: 0x00007934
		private void btnSerialBTPort_Click(object sender, EventArgs e)
		{
			string[] Ports = this.BTPort.GetPorts();
			string[] trim_ports = new string[Ports.Count<string>()];
			this.cmbBTPort.Items.Clear();
			for (int i = 0; i < Ports.Count<string>(); i++)
			{
				if (Ports[i].Length > 5)
				{
					trim_ports[i] = Ports[i].Substring(0, 5);
				}
				else
				{
					trim_ports[i] = Ports[i];
				}
			}
			this.cmbBTPort.Items.AddRange(trim_ports);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000097BC File Offset: 0x000079BC
		private void btnOpenBTPort_Click(object sender, EventArgs e)
		{
			this.labBTPortStatus.Text = "打开中";
			if (this.cmbBTPort.SelectedIndex >= 0)
			{
				if (this.BTPort.OpenPort(this.cmbBTPort.Text))
				{
					this.labBTPortStatus.Text = "已打开";
					clsComm btport = this.BTPort;
					btport.evOnDataReceive = (EventHandler)Delegate.Combine(btport.evOnDataReceive, new EventHandler(this.BTProcessThread));
				}
				else
				{
					this.labBTPortStatus.Text = "未打开";
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000985C File Offset: 0x00007A5C
		private void btnBTImage_Click(object sender, EventArgs e)
		{
			byte[] protocal_data = new byte[]
			{
				13,
				1
			};
			this.BTPort.SendProtocalData(protocal_data);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00009887 File Offset: 0x00007A87
		private void btnBTUpdate_Click(object sender, EventArgs e)
		{
			this.bt_processor.SendStartUpdate(this.BTPort);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000989C File Offset: 0x00007A9C
		private void BTProcessThread(object sender, EventArgs e)
		{
			byte[] Data = this.BTPort.GetParsedData();
			if (Data != null)
			{
				switch (Data[0])
				{
				case 14:
					if (Data[1] == 0)
					{
						this.bt_jpg_buff = new List<byte>();
						this.Datasize = 0;
					}
					else if (Data[1] == 1)
					{
						byte[] jpg_data = new byte[Data.Count<byte>() - 2];
						Array.Copy(Data, 2, jpg_data, 0, jpg_data.Count<byte>());
						this.Datasize += jpg_data.Count<byte>();
						this.bt_jpg_buff.AddRange(jpg_data);
					}
					else if (Data[1] == 2)
					{
						BinaryFile ImageFile = new BinaryFile();
						ImageFile.WriteToFile(Application.StartupPath + "\\Image\\" + DateTime.Now.ToString("yyMMdd_hhmmss") + ".jpg", this.bt_jpg_buff.ToArray());
						base.Invoke(this.dlgUpdatePictureBoxImage, new object[]
						{
							this.bt_jpg_buff.ToArray()
						});
					}
					else if (Data[1] == 255)
					{
						MessageBox.Show("BT Image Error!");
					}
					break;
				case 16:
					if (Data[1] == 0)
					{
						base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
						{
							this.labBTUpdateProgress,
							"0/0"
						});
					}
					else if (Data[1] == 1)
					{
						ushort req_pack_index = (ushort)((int)Data[2] << 8 | (int)Data[3]);
						base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
						{
							this.labBTUpdateProgress,
							req_pack_index.ToString() + "/" + this.bt_processor.GetTotalPacks().ToString()
						});
						this.bt_processor.SendUpdatePack(this.BTPort, req_pack_index);
					}
					else if (Data[1] == 2)
					{
						base.Invoke(this.dlgSetUpdateProgressLabel, new object[]
						{
							this.labBTUpdateProgress,
							"Complete!"
						});
					}
					else if (Data[1] == 255)
					{
						MessageBox.Show("Error code:" + ((ushort)((int)Data[2] << 8 | (int)Data[3])).ToString("X4"));
					}
					break;
				case 18:
					if (Data[1] == 0)
					{
						MessageBox.Show("设置成功");
					}
					else
					{
						MessageBox.Show("设置失败");
					}
					break;
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00009B6A File Offset: 0x00007D6A
		private void btnBTSetName_Click(object sender, EventArgs e)
		{
			this.bt_processor.SendSetName(this.BTPort, this.txtBTName.Text);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009B8C File Offset: 0x00007D8C
		private void btnSetBTName_Click(object sender, EventArgs e)
		{
			if (this.spPort.IsOpen)
			{
				byte[] byte_name = Encoding.Default.GetBytes(this.txtBTName.Text);
				List<byte> lData = new List<byte>();
				lData.Add(5);
				lData.AddRange(byte_name);
				lData.Add(0);
				this.SendCustomProtocol(13, lData.ToArray());
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009BF0 File Offset: 0x00007DF0
		private void btnBTGetName_Click(object sender, EventArgs e)
		{
			if (this.spPort.IsOpen)
			{
				this.SendCustomProtocol(13, new List<byte>
				{
					6
				}.ToArray());
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00009C2C File Offset: 0x00007E2C
		private void btnSendTestData_Click(object sender, EventArgs e)
		{
			try
			{
				string[] string_senddata = this.textBox2.Text.Split(new char[]
				{
					' '
				});
				List<byte> lData = new List<byte>();
				foreach (string tmp in string_senddata)
				{
					lData.Add(Convert.ToByte(tmp, 16));
				}
				this.bt_processor.SendTestData(this.BTPort, lData.ToArray());
			}
			catch
			{
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00009CC4 File Offset: 0x00007EC4
		private void btnGetBTMac_Click(object sender, EventArgs e)
		{
			if (this.spPort.IsOpen)
			{
				this.SendCustomProtocol(13, new List<byte>
				{
					7
				}.ToArray());
			}
		}

		// Token: 0x04000036 RID: 54
		private frmLog Log = new frmLog();

		// Token: 0x04000037 RID: 55
		private frmCommandFilter FilterForm = new frmCommandFilter();

		// Token: 0x04000038 RID: 56
		private clsGcodePhaser GcodePhaser = new clsGcodePhaser();

		// Token: 0x04000039 RID: 57
		private clsLightBar LightBar = new clsLightBar();

		// Token: 0x0400003A RID: 58
		private System.Threading.Timer tmrGetStatus;

		// Token: 0x0400003B RID: 59
		private System.Threading.Timer tmrEnterUpdate;

		// Token: 0x0400003C RID: 60
		private Update MyUpdate = new Update();

		// Token: 0x0400003D RID: 61
		private UpdateCreater FirmwareCreater = new UpdateCreater();

		// Token: 0x0400003E RID: 62
		private clsMachineStatus CurStatus;

		// Token: 0x0400003F RID: 63
		private int SendIndex;

		// Token: 0x04000040 RID: 64
		private int RecvIndex;

		// Token: 0x04000041 RID: 65
		private Semaphore semCommand = null;

		// Token: 0x04000042 RID: 66
		private Semaphore semPowerResume = null;

		// Token: 0x04000043 RID: 67
		private Signal sigPowerResume = new Signal(0, 1);

		// Token: 0x04000044 RID: 68
		private clsDebugtest debug_test = new clsDebugtest();

		// Token: 0x04000045 RID: 69
		private BinaryFile BTUpdateFile = new BinaryFile();

		// Token: 0x04000046 RID: 70
		private clsComm BTPort = new clsComm();

		// Token: 0x04000047 RID: 71
		private List<Form1.strHMILable> MyHMILables = new List<Form1.strHMILable>();

		// Token: 0x04000048 RID: 72
		private Button[] btnCaliPoint = new Button[9];

		// Token: 0x04000049 RID: 73
		private RadioButton[] rbSize = new RadioButton[3];

		// Token: 0x0400004A RID: 74
		private EventHandler SpecialContentReadHandle;

		// Token: 0x0400004B RID: 75
		private Form1.SetValue dlgSetProgressBarValue;

		// Token: 0x0400004C RID: 76
		private Form1.SetText dlgSetUpdateProgressLabel;

		// Token: 0x0400004D RID: 77
		private Form1.SetText dlgSetHMILabelText;

		// Token: 0x0400004E RID: 78
		private Form1.SetText dlgAddItemToList;

		// Token: 0x0400004F RID: 79
		private Form1.SetText dlgSetCurrentPath;

		// Token: 0x04000050 RID: 80
		private Form1.SetText dlgAddModuleVersion;

		// Token: 0x04000051 RID: 81
		private Form1.SetText dlgSetBTUpdateProgressLable;

		// Token: 0x04000052 RID: 82
		private Form1.SetObjectsText dlgSetSize;

		// Token: 0x04000053 RID: 83
		private Form1.SetObjectsCheckStatus dlgSetDirStatus;

		// Token: 0x04000054 RID: 84
		private Form1.SetObjectValue dlgSetSpecialList;

		// Token: 0x04000055 RID: 85
		private Form1.UpdateClassValue dlgUpdateMachineStatus;

		// Token: 0x04000056 RID: 86
		private Form1.UpdateCalibrateEnable dlgUpdateCalibrateButtonEnable;

		// Token: 0x04000057 RID: 87
		private Form1.SetLigthbarData dlgUpdateLightbarStatus;

		// Token: 0x04000058 RID: 88
		private Form1.PostBytes2Object dlgUpdatePictureBoxImage;

		// Token: 0x04000059 RID: 89
		private Form1.AddText dlgAddLog;

		// Token: 0x0400005A RID: 90
		private Form1.SetText dlgSetLableText;

		// Token: 0x0400005B RID: 91
		private bool AutoCheckStatus = true;

		// Token: 0x0400005C RID: 92
		private byte PowerPanicSource = byte.MaxValue;

		// Token: 0x0400005D RID: 93
		private uint SysFaultFlag;

		// Token: 0x0400005E RID: 94
		private List<string> FileLines = new List<string>();

		// Token: 0x0400005F RID: 95
		private int CheckTick = 0;

		// Token: 0x04000060 RID: 96
		private int GetProgress = 0;

		// Token: 0x04000061 RID: 97
		private bool EnteringUpdate = false;

		// Token: 0x04000062 RID: 98
		private List<byte> HmiCommandBuff = new List<byte>();

		// Token: 0x04000063 RID: 99
		private List<string> SendBuff = new List<string>();

		// Token: 0x04000064 RID: 100
		private List<uint> BuffIndex = new List<uint>();

		// Token: 0x04000065 RID: 101
		private uint FileLineIndex;

		// Token: 0x04000066 RID: 102
		private List<byte> ProcessBuff = new List<byte>();

		// Token: 0x04000067 RID: 103
		private Mutex mtxSerialBuff = new Mutex();

		// Token: 0x04000068 RID: 104
		private bool OKReceived = false;

		// Token: 0x04000069 RID: 105
		private bool Printing = false;

		// Token: 0x0400006A RID: 106
		private List<byte> SpecialContents;

		// Token: 0x0400006B RID: 107
		private List<uint> ItemStartPos;

		// Token: 0x0400006C RID: 108
		private Mutex mtxHmiBuff = new Mutex();

		// Token: 0x0400006D RID: 109
		private ManualResetEvent signal_powerpanic_reack = new ManualResetEvent(false);

		// Token: 0x0400006E RID: 110
		private BTProessor bt_processor = new BTProessor();

		// Token: 0x0400006F RID: 111
		private List<byte> bt_jpg_buff = new List<byte>();

		// Token: 0x04000070 RID: 112
		private int Datasize;

		// Token: 0x02000013 RID: 19
		private enum SetListBoxOption
		{
			// Token: 0x04000165 RID: 357
			SLBO_ADD,
			// Token: 0x04000166 RID: 358
			SLBO_CLEAR
		}

		// Token: 0x02000014 RID: 20
		private struct strHMILable
		{
			// Token: 0x060000D2 RID: 210 RVA: 0x00012E4B File Offset: 0x0001104B
			public strHMILable(Label lab, uint id)
			{
				this.LabelItem = lab;
				this.ID = id;
			}

			// Token: 0x04000167 RID: 359
			public Label LabelItem;

			// Token: 0x04000168 RID: 360
			public uint ID;
		}

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000D4 RID: 212
		private delegate void SetLigthbarData(LightbarData Data);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000D8 RID: 216
		private delegate void SetValue(int Value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000DC RID: 220
		private delegate void SetText(object obj, string Text);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000E0 RID: 224
		private delegate void AddText(string Text);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000E4 RID: 228
		private delegate void SetObjectsText(object[] objs, string[] Text);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000E8 RID: 232
		private delegate void SetObjectsCheckStatus(object[] objs, bool[] CheckStatus);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000EC RID: 236
		private delegate void SetObjectValue(object obj, object Value, Form1.SetListBoxOption option);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000F0 RID: 240
		private delegate void UpdateClassValue(clsMachineStatus Status);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000F4 RID: 244
		private delegate void UpdateCalibrateEnable(bool Enable);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000F8 RID: 248
		private delegate void PostBytes2Object(byte[] BytesToPost);
	}
}
