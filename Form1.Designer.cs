namespace SnapTester
{
	// Token: 0x02000012 RID: 18
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00009D00 File Offset: 0x00007F00
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00009D38 File Offset: 0x00007F38
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.cmbPorts = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnSearchPort = new global::System.Windows.Forms.Button();
			this.btnOpen = new global::System.Windows.Forms.Button();
			this.btnUp = new global::System.Windows.Forms.Button();
			this.btnDown = new global::System.Windows.Forms.Button();
			this.btnLeft = new global::System.Windows.Forms.Button();
			this.btnRight = new global::System.Windows.Forms.Button();
			this.btnOpenFile = new global::System.Windows.Forms.Button();
			this.cmdMoveAxisDis = new global::System.Windows.Forms.ComboBox();
			this.labFileName = new global::System.Windows.Forms.Label();
			this.btnPause = new global::System.Windows.Forms.Button();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.btnStartPrint = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.label21 = new global::System.Windows.Forms.Label();
			this.txtExtrudeLength = new global::System.Windows.Forms.TextBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.txtExtrudeSpeed = new global::System.Windows.Forms.TextBox();
			this.btnFan2Off = new global::System.Windows.Forms.Button();
			this.btnFan1Off = new global::System.Windows.Forms.Button();
			this.btnFan2On = new global::System.Windows.Forms.Button();
			this.btnFan1On = new global::System.Windows.Forms.Button();
			this.btnSetFeedRateMultiplier = new global::System.Windows.Forms.Button();
			this.label14 = new global::System.Windows.Forms.Label();
			this.txtM220 = new global::System.Windows.Forms.TextBox();
			this.btnReExtrude = new global::System.Windows.Forms.Button();
			this.btnExtrude = new global::System.Windows.Forms.Button();
			this.labBedSetTamp = new global::System.Windows.Forms.Label();
			this.tbBedTamp = new global::System.Windows.Forms.TrackBar();
			this.labHeadSetTamp = new global::System.Windows.Forms.Label();
			this.tbHeadTamp = new global::System.Windows.Forms.TrackBar();
			this.labTampBed = new global::System.Windows.Forms.Label();
			this.labPrintFileName = new global::System.Windows.Forms.Label();
			this.labTampHeater0 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.btnUDiskPrint = new global::System.Windows.Forms.Button();
			this.lstSpecialContents = new global::System.Windows.Forms.ListBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.btnGetSpecialContent = new global::System.Windows.Forms.Button();
			this.labCurrentPath = new global::System.Windows.Forms.Label();
			this.btnGetCurPath = new global::System.Windows.Forms.Button();
			this.btnOpenUDisk = new global::System.Windows.Forms.Button();
			this.btnOpenDirectory = new global::System.Windows.Forms.Button();
			this.picSpeical = new global::System.Windows.Forms.PictureBox();
			this.lstDirList = new global::System.Windows.Forms.ListBox();
			this.btnGetFileList = new global::System.Windows.Forms.Button();
			this.lstFiles = new global::System.Windows.Forms.ListBox();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.btnReleaeButton = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btnPoint9 = new global::System.Windows.Forms.Button();
			this.btnPoint8 = new global::System.Windows.Forms.Button();
			this.btnPoint7 = new global::System.Windows.Forms.Button();
			this.btnPoint6 = new global::System.Windows.Forms.Button();
			this.btnPoint5 = new global::System.Windows.Forms.Button();
			this.btnCaliReset = new global::System.Windows.Forms.Button();
			this.btnPoint2 = new global::System.Windows.Forms.Button();
			this.btnCaliHome = new global::System.Windows.Forms.Button();
			this.btnZAutoCalibrate = new global::System.Windows.Forms.Button();
			this.btnPoint1 = new global::System.Windows.Forms.Button();
			this.btnPoint4 = new global::System.Windows.Forms.Button();
			this.btnPoint3 = new global::System.Windows.Forms.Button();
			this.btnCaliBack = new global::System.Windows.Forms.Button();
			this.btnCaliSave = new global::System.Windows.Forms.Button();
			this.btnCaliZDown = new global::System.Windows.Forms.Button();
			this.cmbCaliZDis = new global::System.Windows.Forms.ComboBox();
			this.btnCaliZUp = new global::System.Windows.Forms.Button();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.btnTrigglePowerPanic = new global::System.Windows.Forms.Button();
			this.btnAuto = new global::System.Windows.Forms.Button();
			this.btnClearFault = new global::System.Windows.Forms.Button();
			this.btnCheckFault = new global::System.Windows.Forms.Button();
			this.btnGetPowerPanicData = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.btnPowerPanicContinue = new global::System.Windows.Forms.Button();
			this.tabPage6 = new global::System.Windows.Forms.TabPage();
			this.labCurrentLaserPercent = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.btnDrawRuler = new global::System.Windows.Forms.Button();
			this.btnDrawLaserCalibration = new global::System.Windows.Forms.Button();
			this.txtFocusZ = new global::System.Windows.Forms.TextBox();
			this.txtFocusY = new global::System.Windows.Forms.TextBox();
			this.txtFocusX = new global::System.Windows.Forms.TextBox();
			this.cbMovementRelative = new global::System.Windows.Forms.CheckBox();
			this.txtMovementZ = new global::System.Windows.Forms.TextBox();
			this.txtMovementY = new global::System.Windows.Forms.TextBox();
			this.txtMovementX = new global::System.Windows.Forms.TextBox();
			this.btnMovementRequire = new global::System.Windows.Forms.Button();
			this.btnZOriginal = new global::System.Windows.Forms.Button();
			this.btnLaserZHome = new global::System.Windows.Forms.Button();
			this.btnLaserFocusOff = new global::System.Windows.Forms.Button();
			this.btnLaserFocusOn = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.btnGetFocus = new global::System.Windows.Forms.Button();
			this.label15 = new global::System.Windows.Forms.Label();
			this.txtLaserFocusHeight = new global::System.Windows.Forms.TextBox();
			this.btnLaserEnterSetFocus = new global::System.Windows.Forms.Button();
			this.btnSetOriginal = new global::System.Windows.Forms.Button();
			this.btnSetFocusHigh = new global::System.Windows.Forms.Button();
			this.labLaserPower = new global::System.Windows.Forms.Label();
			this.tbLaserPower = new global::System.Windows.Forms.TrackBar();
			this.tabPage7 = new global::System.Windows.Forms.TabPage();
			this.btnCNCSetOrigin = new global::System.Windows.Forms.Button();
			this.labTargetRPM = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.tbRPM = new global::System.Windows.Forms.TrackBar();
			this.labRPM = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.button12 = new global::System.Windows.Forms.Button();
			this.button11 = new global::System.Windows.Forms.Button();
			this.btnFanOff = new global::System.Windows.Forms.Button();
			this.btnFanOn = new global::System.Windows.Forms.Button();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.tabPage8 = new global::System.Windows.Forms.TabPage();
			this.btnEnableFilamentSensor = new global::System.Windows.Forms.Button();
			this.btnDisableFilamentSensor = new global::System.Windows.Forms.Button();
			this.rbSizeL = new global::System.Windows.Forms.RadioButton();
			this.rbSizeM = new global::System.Windows.Forms.RadioButton();
			this.rbSizeS = new global::System.Windows.Forms.RadioButton();
			this.btnGetSize = new global::System.Windows.Forms.Button();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtZOffset = new global::System.Windows.Forms.TextBox();
			this.txtYOffset = new global::System.Windows.Forms.TextBox();
			this.txtXOffset = new global::System.Windows.Forms.TextBox();
			this.cbZHomeDir = new global::System.Windows.Forms.CheckBox();
			this.cbYHomeDir = new global::System.Windows.Forms.CheckBox();
			this.cbXHomeDir = new global::System.Windows.Forms.CheckBox();
			this.cbZDir = new global::System.Windows.Forms.CheckBox();
			this.cbYDir = new global::System.Windows.Forms.CheckBox();
			this.cbXDir = new global::System.Windows.Forms.CheckBox();
			this.btnSetSize = new global::System.Windows.Forms.Button();
			this.txtZSize = new global::System.Windows.Forms.TextBox();
			this.txtYSize = new global::System.Windows.Forms.TextBox();
			this.txtXSize = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.tabPage9 = new global::System.Windows.Forms.TabPage();
			this.lstModuleVersions = new global::System.Windows.Forms.ListBox();
			this.btnRequestModuleFirmwareVersion = new global::System.Windows.Forms.Button();
			this.cbForceUpdate = new global::System.Windows.Forms.CheckBox();
			this.rbModuleType = new global::System.Windows.Forms.RadioButton();
			this.rbControler = new global::System.Windows.Forms.RadioButton();
			this.btnOpenOriginFile = new global::System.Windows.Forms.Button();
			this.EnterUpdate = new global::System.Windows.Forms.CheckBox();
			this.button6 = new global::System.Windows.Forms.Button();
			this.btnGetUpdateStatus = new global::System.Windows.Forms.Button();
			this.btnRequestFirmwareVersion = new global::System.Windows.Forms.Button();
			this.labUpdateProgress = new global::System.Windows.Forms.Label();
			this.btnUpdate = new global::System.Windows.Forms.Button();
			this.tabPage10 = new global::System.Windows.Forms.TabPage();
			this.btnGetBTMac = new global::System.Windows.Forms.Button();
			this.btnSendTestData = new global::System.Windows.Forms.Button();
			this.btnBTGetName = new global::System.Windows.Forms.Button();
			this.labBTUpdateProgress = new global::System.Windows.Forms.Label();
			this.label27 = new global::System.Windows.Forms.Label();
			this.txtBTName = new global::System.Windows.Forms.TextBox();
			this.btnSetBTName = new global::System.Windows.Forms.Button();
			this.btnBTSetName = new global::System.Windows.Forms.Button();
			this.btnBTUpdate = new global::System.Windows.Forms.Button();
			this.labBTPortStatus = new global::System.Windows.Forms.Label();
			this.picboxBTImage = new global::System.Windows.Forms.PictureBox();
			this.btnBTImage = new global::System.Windows.Forms.Button();
			this.btnOpenBTPort = new global::System.Windows.Forms.Button();
			this.btnSerialBTPort = new global::System.Windows.Forms.Button();
			this.label26 = new global::System.Windows.Forms.Label();
			this.cmbBTPort = new global::System.Windows.Forms.ComboBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.labCameraIP = new global::System.Windows.Forms.Label();
			this.btnGetCameraIP = new global::System.Windows.Forms.Button();
			this.btnSetWifiParameter = new global::System.Windows.Forms.Button();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.txtSSID = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.tabPage11 = new global::System.Windows.Forms.TabPage();
			this.rbLightNormal = new global::System.Windows.Forms.RadioButton();
			this.rbLigthStatus = new global::System.Windows.Forms.RadioButton();
			this.tbLightBrightness = new global::System.Windows.Forms.TrackBar();
			this.cbLightOnoff = new global::System.Windows.Forms.CheckBox();
			this.btnGetLightStatus = new global::System.Windows.Forms.Button();
			this.tabPage12 = new global::System.Windows.Forms.TabPage();
			this.label23 = new global::System.Windows.Forms.Label();
			this.txtCustomeRepeat = new global::System.Windows.Forms.TextBox();
			this.btnRunCustomGcode = new global::System.Windows.Forms.Button();
			this.btnLoadCustomGcodeFile = new global::System.Windows.Forms.Button();
			this.rtbCustomFile = new global::System.Windows.Forms.RichTextBox();
			this.tabPage13 = new global::System.Windows.Forms.TabPage();
			this.txtNewLead = new global::System.Windows.Forms.TextBox();
			this.txtNewLength = new global::System.Windows.Forms.TextBox();
			this.btnSetLinearModuleLead = new global::System.Windows.Forms.Button();
			this.btnSetLinearModuleLength = new global::System.Windows.Forms.Button();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label24 = new global::System.Windows.Forms.Label();
			this.txtNewMacID = new global::System.Windows.Forms.TextBox();
			this.txtOldMacID = new global::System.Windows.Forms.TextBox();
			this.btnSetMacID = new global::System.Windows.Forms.Button();
			this.lstModuleInfo = new global::System.Windows.Forms.ListBox();
			this.btnGetLinearModuleLead = new global::System.Windows.Forms.Button();
			this.btnGetLinearModuleLength = new global::System.Windows.Forms.Button();
			this.spPort = new global::System.IO.Ports.SerialPort(this.components);
			this.labPercent = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnContinue = new global::System.Windows.Forms.Button();
			this.btnAllHome = new global::System.Windows.Forms.Button();
			this.btnSMCMaker = new global::System.Windows.Forms.Button();
			this.btnFlush = new global::System.Windows.Forms.Button();
			this.labPrinterStatus = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.labXPos = new global::System.Windows.Forms.Label();
			this.labYPos = new global::System.Windows.Forms.Label();
			this.labZPos = new global::System.Windows.Forms.Label();
			this.labEPos = new global::System.Windows.Forms.Label();
			this.labStatus = new global::System.Windows.Forms.Label();
			this.labExecuter = new global::System.Windows.Forms.Label();
			this.cbAutoCheckStatus = new global::System.Windows.Forms.CheckBox();
			this.btnZUp = new global::System.Windows.Forms.Button();
			this.btnZDown = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.label18 = new global::System.Windows.Forms.Label();
			this.button8 = new global::System.Windows.Forms.Button();
			this.txtMoveSpeed = new global::System.Windows.Forms.TextBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.btnClearGcodeIndex = new global::System.Windows.Forms.Button();
			this.btnOpenLog = new global::System.Windows.Forms.Button();
			this.picStatus = new global::System.Windows.Forms.PictureBox();
			this.btnOpenFilter = new global::System.Windows.Forms.Button();
			this.labBuffLines = new global::System.Windows.Forms.Label();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbBedTamp).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tbHeadTamp).BeginInit();
			this.tabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picSpeical).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbLaserPower).BeginInit();
			this.tabPage7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbRPM).BeginInit();
			this.tabPage5.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picboxBTImage).BeginInit();
			this.tabPage11.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbLightBrightness).BeginInit();
			this.tabPage12.SuspendLayout();
			this.tabPage13.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picStatus).BeginInit();
			base.SuspendLayout();
			this.cmbPorts.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPorts.FormattingEnabled = true;
			this.cmbPorts.Location = new global::System.Drawing.Point(90, 12);
			this.cmbPorts.Name = "cmbPorts";
			this.cmbPorts.Size = new global::System.Drawing.Size(123, 20);
			this.cmbPorts.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(41, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Port";
			this.btnSearchPort.Location = new global::System.Drawing.Point(231, 9);
			this.btnSearchPort.Name = "btnSearchPort";
			this.btnSearchPort.Size = new global::System.Drawing.Size(97, 23);
			this.btnSearchPort.TabIndex = 2;
			this.btnSearchPort.Text = "Seach Port";
			this.btnSearchPort.UseVisualStyleBackColor = true;
			this.btnSearchPort.Click += new global::System.EventHandler(this.btnSearchPort_Click);
			this.btnOpen.Location = new global::System.Drawing.Point(355, 9);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new global::System.Drawing.Size(77, 23);
			this.btnOpen.TabIndex = 3;
			this.btnOpen.Text = "OpenPort";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new global::System.EventHandler(this.btnOpen_Click);
			this.btnUp.Location = new global::System.Drawing.Point(751, 22);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new global::System.Drawing.Size(49, 49);
			this.btnUp.TabIndex = 4;
			this.btnUp.Text = "Y+";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.btnDown.Location = new global::System.Drawing.Point(751, 156);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new global::System.Drawing.Size(49, 49);
			this.btnDown.TabIndex = 5;
			this.btnDown.Text = "Y-";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.btnLeft.Location = new global::System.Drawing.Point(686, 86);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new global::System.Drawing.Size(49, 49);
			this.btnLeft.TabIndex = 6;
			this.btnLeft.Text = "X-";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new global::System.EventHandler(this.btnLeft_Click);
			this.btnRight.Location = new global::System.Drawing.Point(815, 86);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new global::System.Drawing.Size(49, 49);
			this.btnRight.TabIndex = 7;
			this.btnRight.Text = "X+";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new global::System.EventHandler(this.btnRight_Click);
			this.btnOpenFile.Location = new global::System.Drawing.Point(233, 47);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new global::System.Drawing.Size(95, 23);
			this.btnOpenFile.TabIndex = 8;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new global::System.EventHandler(this.btnOpenFile_Click);
			this.cmdMoveAxisDis.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.Simple;
			this.cmdMoveAxisDis.FormattingEnabled = true;
			this.cmdMoveAxisDis.Items.AddRange(new object[]
			{
				"0.1",
				"0.5",
				"1"
			});
			this.cmdMoveAxisDis.Location = new global::System.Drawing.Point(751, 100);
			this.cmdMoveAxisDis.Name = "cmdMoveAxisDis";
			this.cmdMoveAxisDis.Size = new global::System.Drawing.Size(49, 20);
			this.cmdMoveAxisDis.TabIndex = 9;
			this.labFileName.AutoSize = true;
			this.labFileName.Location = new global::System.Drawing.Point(41, 75);
			this.labFileName.Name = "labFileName";
			this.labFileName.Size = new global::System.Drawing.Size(53, 12);
			this.labFileName.TabIndex = 10;
			this.labFileName.Text = "FileName";
			this.btnPause.Enabled = false;
			this.btnPause.Location = new global::System.Drawing.Point(323, 89);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new global::System.Drawing.Size(77, 23);
			this.btnPause.TabIndex = 11;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new global::System.EventHandler(this.btnPause_Click);
			this.progressBar1.Location = new global::System.Drawing.Point(45, 146);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(368, 23);
			this.progressBar1.TabIndex = 12;
			this.btnStartPrint.Enabled = false;
			this.btnStartPrint.Location = new global::System.Drawing.Point(231, 89);
			this.btnStartPrint.Name = "btnStartPrint";
			this.btnStartPrint.Size = new global::System.Drawing.Size(77, 23);
			this.btnStartPrint.TabIndex = 13;
			this.btnStartPrint.Text = "Start Print";
			this.btnStartPrint.UseVisualStyleBackColor = true;
			this.btnStartPrint.Click += new global::System.EventHandler(this.btnStartPrint_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Controls.Add(this.tabPage10);
			this.tabControl1.Controls.Add(this.tabPage11);
			this.tabControl1.Controls.Add(this.tabPage12);
			this.tabControl1.Controls.Add(this.tabPage13);
			this.tabControl1.Location = new global::System.Drawing.Point(26, 225);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(1141, 357);
			this.tabControl1.TabIndex = 16;
			this.tabPage1.Controls.Add(this.label21);
			this.tabPage1.Controls.Add(this.txtExtrudeLength);
			this.tabPage1.Controls.Add(this.label20);
			this.tabPage1.Controls.Add(this.txtExtrudeSpeed);
			this.tabPage1.Controls.Add(this.btnFan2Off);
			this.tabPage1.Controls.Add(this.btnFan1Off);
			this.tabPage1.Controls.Add(this.btnFan2On);
			this.tabPage1.Controls.Add(this.btnFan1On);
			this.tabPage1.Controls.Add(this.btnSetFeedRateMultiplier);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.txtM220);
			this.tabPage1.Controls.Add(this.btnReExtrude);
			this.tabPage1.Controls.Add(this.btnExtrude);
			this.tabPage1.Controls.Add(this.labBedSetTamp);
			this.tabPage1.Controls.Add(this.tbBedTamp);
			this.tabPage1.Controls.Add(this.labHeadSetTamp);
			this.tabPage1.Controls.Add(this.tbHeadTamp);
			this.tabPage1.Controls.Add(this.labTampBed);
			this.tabPage1.Controls.Add(this.labPrintFileName);
			this.tabPage1.Controls.Add(this.labTampHeater0);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(74, 288);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(77, 12);
			this.label21.TabIndex = 46;
			this.label21.Text = "挤出机长度：";
			this.txtExtrudeLength.Location = new global::System.Drawing.Point(160, 285);
			this.txtExtrudeLength.Name = "txtExtrudeLength";
			this.txtExtrudeLength.Size = new global::System.Drawing.Size(100, 21);
			this.txtExtrudeLength.TabIndex = 45;
			this.txtExtrudeLength.Text = "100";
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(280, 288);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(77, 12);
			this.label20.TabIndex = 44;
			this.label20.Text = "挤出机速度：";
			this.txtExtrudeSpeed.Location = new global::System.Drawing.Point(366, 285);
			this.txtExtrudeSpeed.Name = "txtExtrudeSpeed";
			this.txtExtrudeSpeed.Size = new global::System.Drawing.Size(100, 21);
			this.txtExtrudeSpeed.TabIndex = 43;
			this.txtExtrudeSpeed.Text = "100";
			this.btnFan2Off.Location = new global::System.Drawing.Point(853, 283);
			this.btnFan2Off.Name = "btnFan2Off";
			this.btnFan2Off.Size = new global::System.Drawing.Size(160, 23);
			this.btnFan2Off.TabIndex = 42;
			this.btnFan2Off.Text = "Extruder Fan2 Off";
			this.btnFan2Off.UseVisualStyleBackColor = true;
			this.btnFan2Off.Click += new global::System.EventHandler(this.btnFan2Off_Click);
			this.btnFan1Off.Location = new global::System.Drawing.Point(853, 239);
			this.btnFan1Off.Name = "btnFan1Off";
			this.btnFan1Off.Size = new global::System.Drawing.Size(160, 23);
			this.btnFan1Off.TabIndex = 41;
			this.btnFan1Off.Text = "Extruder Fan1 Off";
			this.btnFan1Off.UseVisualStyleBackColor = true;
			this.btnFan1Off.Click += new global::System.EventHandler(this.btnFan1Off_Click);
			this.btnFan2On.Location = new global::System.Drawing.Point(656, 283);
			this.btnFan2On.Name = "btnFan2On";
			this.btnFan2On.Size = new global::System.Drawing.Size(160, 23);
			this.btnFan2On.TabIndex = 40;
			this.btnFan2On.Text = "Extruder Fan2 On";
			this.btnFan2On.UseVisualStyleBackColor = true;
			this.btnFan2On.Click += new global::System.EventHandler(this.btnFan2On_Click);
			this.btnFan1On.Location = new global::System.Drawing.Point(656, 239);
			this.btnFan1On.Name = "btnFan1On";
			this.btnFan1On.Size = new global::System.Drawing.Size(160, 23);
			this.btnFan1On.TabIndex = 39;
			this.btnFan1On.Text = "Extruder Fan1 On";
			this.btnFan1On.UseVisualStyleBackColor = true;
			this.btnFan1On.Click += new global::System.EventHandler(this.btnFan1On_Click);
			this.btnSetFeedRateMultiplier.Location = new global::System.Drawing.Point(780, 59);
			this.btnSetFeedRateMultiplier.Name = "btnSetFeedRateMultiplier";
			this.btnSetFeedRateMultiplier.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetFeedRateMultiplier.TabIndex = 38;
			this.btnSetFeedRateMultiplier.Text = "M220 Setting";
			this.btnSetFeedRateMultiplier.UseVisualStyleBackColor = true;
			this.btnSetFeedRateMultiplier.Click += new global::System.EventHandler(this.btnSetFeedRateMultiplier_Click);
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(507, 64);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(119, 12);
			this.label14.TabIndex = 16;
			this.label14.Text = "FeedRate Multipier:";
			this.txtM220.Location = new global::System.Drawing.Point(632, 61);
			this.txtM220.Name = "txtM220";
			this.txtM220.Size = new global::System.Drawing.Size(114, 21);
			this.txtM220.TabIndex = 15;
			this.txtM220.Text = "100";
			this.btnReExtrude.Location = new global::System.Drawing.Point(527, 283);
			this.btnReExtrude.Name = "btnReExtrude";
			this.btnReExtrude.Size = new global::System.Drawing.Size(75, 23);
			this.btnReExtrude.TabIndex = 14;
			this.btnReExtrude.Text = "ReExtrude";
			this.btnReExtrude.UseVisualStyleBackColor = true;
			this.btnReExtrude.Click += new global::System.EventHandler(this.btnReExtrude_Click);
			this.btnExtrude.Location = new global::System.Drawing.Point(527, 239);
			this.btnExtrude.Name = "btnExtrude";
			this.btnExtrude.Size = new global::System.Drawing.Size(75, 23);
			this.btnExtrude.TabIndex = 9;
			this.btnExtrude.Text = "Extrude";
			this.btnExtrude.UseVisualStyleBackColor = true;
			this.btnExtrude.Click += new global::System.EventHandler(this.btnExtrude_Click);
			this.labBedSetTamp.AutoSize = true;
			this.labBedSetTamp.Location = new global::System.Drawing.Point(399, 193);
			this.labBedSetTamp.Name = "labBedSetTamp";
			this.labBedSetTamp.Size = new global::System.Drawing.Size(41, 12);
			this.labBedSetTamp.TabIndex = 8;
			this.labBedSetTamp.Text = "label3";
			this.tbBedTamp.Location = new global::System.Drawing.Point(25, 217);
			this.tbBedTamp.Maximum = 280;
			this.tbBedTamp.Name = "tbBedTamp";
			this.tbBedTamp.Size = new global::System.Drawing.Size(441, 45);
			this.tbBedTamp.TabIndex = 7;
			this.tbBedTamp.Scroll += new global::System.EventHandler(this.tbBedTamp_Scroll);
			this.tbBedTamp.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.tbBedTamp_MouseUp);
			this.labHeadSetTamp.AutoSize = true;
			this.labHeadSetTamp.Location = new global::System.Drawing.Point(399, 92);
			this.labHeadSetTamp.Name = "labHeadSetTamp";
			this.labHeadSetTamp.Size = new global::System.Drawing.Size(41, 12);
			this.labHeadSetTamp.TabIndex = 6;
			this.labHeadSetTamp.Text = "label3";
			this.tbHeadTamp.Location = new global::System.Drawing.Point(25, 117);
			this.tbHeadTamp.Maximum = 280;
			this.tbHeadTamp.Name = "tbHeadTamp";
			this.tbHeadTamp.Size = new global::System.Drawing.Size(441, 45);
			this.tbHeadTamp.TabIndex = 5;
			this.tbHeadTamp.Scroll += new global::System.EventHandler(this.tbHeadTamp_Scroll);
			this.tbHeadTamp.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.tbHeadTamp_MouseUp);
			this.labTampBed.AutoSize = true;
			this.labTampBed.Location = new global::System.Drawing.Point(237, 28);
			this.labTampBed.Name = "labTampBed";
			this.labTampBed.Size = new global::System.Drawing.Size(23, 12);
			this.labTampBed.TabIndex = 4;
			this.labTampBed.Text = "0/0";
			this.labPrintFileName.AutoSize = true;
			this.labPrintFileName.Location = new global::System.Drawing.Point(126, 64);
			this.labPrintFileName.Name = "labPrintFileName";
			this.labPrintFileName.Size = new global::System.Drawing.Size(47, 12);
			this.labPrintFileName.TabIndex = 3;
			this.labPrintFileName.Text = "No File";
			this.labTampHeater0.AutoSize = true;
			this.labTampHeater0.Location = new global::System.Drawing.Point(126, 28);
			this.labTampHeater0.Name = "labTampHeater0";
			this.labTampHeater0.Size = new global::System.Drawing.Size(23, 12);
			this.labTampHeater0.TabIndex = 2;
			this.labTampHeater0.Text = "0/0";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(23, 28);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(77, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Temperature:";
			this.textBox1.Location = new global::System.Drawing.Point(509, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(346, 21);
			this.textBox1.TabIndex = 0;
			this.tabPage2.Controls.Add(this.btnUDiskPrint);
			this.tabPage2.Controls.Add(this.lstSpecialContents);
			this.tabPage2.Controls.Add(this.richTextBox1);
			this.tabPage2.Controls.Add(this.btnGetSpecialContent);
			this.tabPage2.Controls.Add(this.labCurrentPath);
			this.tabPage2.Controls.Add(this.btnGetCurPath);
			this.tabPage2.Controls.Add(this.btnOpenUDisk);
			this.tabPage2.Controls.Add(this.btnOpenDirectory);
			this.tabPage2.Controls.Add(this.picSpeical);
			this.tabPage2.Controls.Add(this.lstDirList);
			this.tabPage2.Controls.Add(this.btnGetFileList);
			this.tabPage2.Controls.Add(this.lstFiles);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.btnUDiskPrint.Enabled = false;
			this.btnUDiskPrint.Location = new global::System.Drawing.Point(410, 19);
			this.btnUDiskPrint.Name = "btnUDiskPrint";
			this.btnUDiskPrint.Size = new global::System.Drawing.Size(79, 38);
			this.btnUDiskPrint.TabIndex = 16;
			this.btnUDiskPrint.Text = "Print";
			this.btnUDiskPrint.UseVisualStyleBackColor = true;
			this.btnUDiskPrint.Click += new global::System.EventHandler(this.btnUDiskPrint_Click);
			this.lstSpecialContents.FormattingEnabled = true;
			this.lstSpecialContents.ItemHeight = 12;
			this.lstSpecialContents.Location = new global::System.Drawing.Point(495, 184);
			this.lstSpecialContents.Name = "lstSpecialContents";
			this.lstSpecialContents.Size = new global::System.Drawing.Size(102, 124);
			this.lstSpecialContents.TabIndex = 15;
			this.lstSpecialContents.SelectedIndexChanged += new global::System.EventHandler(this.lstSpecialContents_SelectedIndexChanged);
			this.richTextBox1.Location = new global::System.Drawing.Point(612, 191);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(161, 117);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			this.btnGetSpecialContent.Location = new global::System.Drawing.Point(612, 99);
			this.btnGetSpecialContent.Name = "btnGetSpecialContent";
			this.btnGetSpecialContent.Size = new global::System.Drawing.Size(161, 61);
			this.btnGetSpecialContent.TabIndex = 12;
			this.btnGetSpecialContent.Text = "Get Special Content";
			this.btnGetSpecialContent.UseVisualStyleBackColor = true;
			this.btnGetSpecialContent.Click += new global::System.EventHandler(this.btnGetSpecialContent_Click);
			this.labCurrentPath.AutoSize = true;
			this.labCurrentPath.Location = new global::System.Drawing.Point(801, 14);
			this.labCurrentPath.Name = "labCurrentPath";
			this.labCurrentPath.Size = new global::System.Drawing.Size(41, 12);
			this.labCurrentPath.TabIndex = 11;
			this.labCurrentPath.Text = "label3";
			this.btnGetCurPath.Location = new global::System.Drawing.Point(612, 14);
			this.btnGetCurPath.Name = "btnGetCurPath";
			this.btnGetCurPath.Size = new global::System.Drawing.Size(161, 61);
			this.btnGetCurPath.TabIndex = 10;
			this.btnGetCurPath.Text = "Get Current Path";
			this.btnGetCurPath.UseVisualStyleBackColor = true;
			this.btnGetCurPath.Click += new global::System.EventHandler(this.btnGetCurPath_Click);
			this.btnOpenUDisk.Location = new global::System.Drawing.Point(495, 19);
			this.btnOpenUDisk.Name = "btnOpenUDisk";
			this.btnOpenUDisk.Size = new global::System.Drawing.Size(102, 38);
			this.btnOpenUDisk.TabIndex = 9;
			this.btnOpenUDisk.Text = "Open UDisk";
			this.btnOpenUDisk.UseVisualStyleBackColor = true;
			this.btnOpenUDisk.Click += new global::System.EventHandler(this.btnOpenUDisk_Click);
			this.btnOpenDirectory.Location = new global::System.Drawing.Point(495, 132);
			this.btnOpenDirectory.Name = "btnOpenDirectory";
			this.btnOpenDirectory.Size = new global::System.Drawing.Size(102, 33);
			this.btnOpenDirectory.TabIndex = 8;
			this.btnOpenDirectory.Text = "Open Directory";
			this.btnOpenDirectory.UseVisualStyleBackColor = true;
			this.btnOpenDirectory.Click += new global::System.EventHandler(this.btnOpenDirectory_Click);
			this.picSpeical.Location = new global::System.Drawing.Point(803, 47);
			this.picSpeical.Name = "picSpeical";
			this.picSpeical.Size = new global::System.Drawing.Size(305, 261);
			this.picSpeical.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picSpeical.TabIndex = 14;
			this.picSpeical.TabStop = false;
			this.lstDirList.FormattingEnabled = true;
			this.lstDirList.ItemHeight = 12;
			this.lstDirList.Location = new global::System.Drawing.Point(36, 16);
			this.lstDirList.Name = "lstDirList";
			this.lstDirList.Size = new global::System.Drawing.Size(120, 316);
			this.lstDirList.TabIndex = 7;
			this.btnGetFileList.Location = new global::System.Drawing.Point(495, 73);
			this.btnGetFileList.Name = "btnGetFileList";
			this.btnGetFileList.Size = new global::System.Drawing.Size(102, 39);
			this.btnGetFileList.TabIndex = 6;
			this.btnGetFileList.Text = "Get File List";
			this.btnGetFileList.UseVisualStyleBackColor = true;
			this.btnGetFileList.Click += new global::System.EventHandler(this.btnGetFileList_Click);
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.ItemHeight = 12;
			this.lstFiles.Location = new global::System.Drawing.Point(178, 15);
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.Size = new global::System.Drawing.Size(226, 316);
			this.lstFiles.TabIndex = 5;
			this.lstFiles.DoubleClick += new global::System.EventHandler(this.lstFiles_DoubleClick);
			this.tabPage3.Controls.Add(this.btnReleaeButton);
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Controls.Add(this.btnCaliBack);
			this.tabPage3.Controls.Add(this.btnCaliSave);
			this.tabPage3.Controls.Add(this.btnCaliZDown);
			this.tabPage3.Controls.Add(this.cmbCaliZDis);
			this.tabPage3.Controls.Add(this.btnCaliZUp);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Calibration";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.btnReleaeButton.Location = new global::System.Drawing.Point(893, 221);
			this.btnReleaeButton.Name = "btnReleaeButton";
			this.btnReleaeButton.Size = new global::System.Drawing.Size(100, 39);
			this.btnReleaeButton.TabIndex = 14;
			this.btnReleaeButton.Text = "Releae Button";
			this.btnReleaeButton.UseVisualStyleBackColor = true;
			this.btnReleaeButton.Click += new global::System.EventHandler(this.btnReleaeButton_Click);
			this.groupBox2.Controls.Add(this.btnPoint9);
			this.groupBox2.Controls.Add(this.btnPoint8);
			this.groupBox2.Controls.Add(this.btnPoint7);
			this.groupBox2.Controls.Add(this.btnPoint6);
			this.groupBox2.Controls.Add(this.btnPoint5);
			this.groupBox2.Controls.Add(this.btnCaliReset);
			this.groupBox2.Controls.Add(this.btnPoint2);
			this.groupBox2.Controls.Add(this.btnCaliHome);
			this.groupBox2.Controls.Add(this.btnZAutoCalibrate);
			this.groupBox2.Controls.Add(this.btnPoint1);
			this.groupBox2.Controls.Add(this.btnPoint4);
			this.groupBox2.Controls.Add(this.btnPoint3);
			this.groupBox2.Location = new global::System.Drawing.Point(15, 15);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(472, 327);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			this.btnPoint9.Enabled = false;
			this.btnPoint9.Location = new global::System.Drawing.Point(287, 29);
			this.btnPoint9.Name = "btnPoint9";
			this.btnPoint9.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint9.TabIndex = 18;
			this.btnPoint9.Text = "P9";
			this.btnPoint9.UseVisualStyleBackColor = true;
			this.btnPoint8.Enabled = false;
			this.btnPoint8.Location = new global::System.Drawing.Point(143, 29);
			this.btnPoint8.Name = "btnPoint8";
			this.btnPoint8.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint8.TabIndex = 17;
			this.btnPoint8.Text = "P8";
			this.btnPoint8.UseVisualStyleBackColor = true;
			this.btnPoint7.Enabled = false;
			this.btnPoint7.Location = new global::System.Drawing.Point(6, 29);
			this.btnPoint7.Name = "btnPoint7";
			this.btnPoint7.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint7.TabIndex = 16;
			this.btnPoint7.Text = "P7";
			this.btnPoint7.UseVisualStyleBackColor = true;
			this.btnPoint6.Enabled = false;
			this.btnPoint6.Location = new global::System.Drawing.Point(287, 96);
			this.btnPoint6.Name = "btnPoint6";
			this.btnPoint6.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint6.TabIndex = 15;
			this.btnPoint6.Text = "P6";
			this.btnPoint6.UseVisualStyleBackColor = true;
			this.btnPoint5.Enabled = false;
			this.btnPoint5.Location = new global::System.Drawing.Point(143, 96);
			this.btnPoint5.Name = "btnPoint5";
			this.btnPoint5.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint5.TabIndex = 14;
			this.btnPoint5.Text = "P5";
			this.btnPoint5.UseVisualStyleBackColor = true;
			this.btnCaliReset.Enabled = false;
			this.btnCaliReset.Location = new global::System.Drawing.Point(349, 239);
			this.btnCaliReset.Name = "btnCaliReset";
			this.btnCaliReset.Size = new global::System.Drawing.Size(100, 49);
			this.btnCaliReset.TabIndex = 13;
			this.btnCaliReset.Text = "Reset";
			this.btnCaliReset.UseVisualStyleBackColor = true;
			this.btnCaliReset.Click += new global::System.EventHandler(this.btnCaliReset_Click);
			this.btnPoint2.Enabled = false;
			this.btnPoint2.Location = new global::System.Drawing.Point(143, 171);
			this.btnPoint2.Name = "btnPoint2";
			this.btnPoint2.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint2.TabIndex = 4;
			this.btnPoint2.Text = "P2";
			this.btnPoint2.UseVisualStyleBackColor = true;
			this.btnCaliHome.Location = new global::System.Drawing.Point(200, 243);
			this.btnCaliHome.Name = "btnCaliHome";
			this.btnCaliHome.Size = new global::System.Drawing.Size(100, 41);
			this.btnCaliHome.TabIndex = 0;
			this.btnCaliHome.Text = "Home";
			this.btnCaliHome.UseVisualStyleBackColor = true;
			this.btnCaliHome.Click += new global::System.EventHandler(this.btnCaliHome_Click);
			this.btnZAutoCalibrate.Location = new global::System.Drawing.Point(45, 243);
			this.btnZAutoCalibrate.Name = "btnZAutoCalibrate";
			this.btnZAutoCalibrate.Size = new global::System.Drawing.Size(123, 41);
			this.btnZAutoCalibrate.TabIndex = 11;
			this.btnZAutoCalibrate.Text = "ZAutoCalibrate";
			this.btnZAutoCalibrate.UseVisualStyleBackColor = true;
			this.btnZAutoCalibrate.Click += new global::System.EventHandler(this.btnZAutoCalibrate_Click);
			this.btnPoint1.Enabled = false;
			this.btnPoint1.Location = new global::System.Drawing.Point(6, 171);
			this.btnPoint1.Name = "btnPoint1";
			this.btnPoint1.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint1.TabIndex = 1;
			this.btnPoint1.Text = "P1";
			this.btnPoint1.UseVisualStyleBackColor = true;
			this.btnPoint4.Enabled = false;
			this.btnPoint4.Location = new global::System.Drawing.Point(6, 96);
			this.btnPoint4.Name = "btnPoint4";
			this.btnPoint4.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint4.TabIndex = 2;
			this.btnPoint4.Text = "P4";
			this.btnPoint4.UseVisualStyleBackColor = true;
			this.btnPoint3.Enabled = false;
			this.btnPoint3.Location = new global::System.Drawing.Point(287, 171);
			this.btnPoint3.Name = "btnPoint3";
			this.btnPoint3.Size = new global::System.Drawing.Size(100, 33);
			this.btnPoint3.TabIndex = 3;
			this.btnPoint3.Text = "P3";
			this.btnPoint3.UseVisualStyleBackColor = true;
			this.btnCaliBack.Enabled = false;
			this.btnCaliBack.Location = new global::System.Drawing.Point(893, 111);
			this.btnCaliBack.Name = "btnCaliBack";
			this.btnCaliBack.Size = new global::System.Drawing.Size(100, 49);
			this.btnCaliBack.TabIndex = 12;
			this.btnCaliBack.Text = "Back";
			this.btnCaliBack.UseVisualStyleBackColor = true;
			this.btnCaliBack.Click += new global::System.EventHandler(this.btnCaliBack_Click);
			this.btnCaliSave.Enabled = false;
			this.btnCaliSave.Location = new global::System.Drawing.Point(893, 28);
			this.btnCaliSave.Name = "btnCaliSave";
			this.btnCaliSave.Size = new global::System.Drawing.Size(100, 49);
			this.btnCaliSave.TabIndex = 11;
			this.btnCaliSave.Text = "Save";
			this.btnCaliSave.UseVisualStyleBackColor = true;
			this.btnCaliSave.Click += new global::System.EventHandler(this.btnCaliSave_Click);
			this.btnCaliZDown.Location = new global::System.Drawing.Point(656, 178);
			this.btnCaliZDown.Name = "btnCaliZDown";
			this.btnCaliZDown.Size = new global::System.Drawing.Size(49, 49);
			this.btnCaliZDown.TabIndex = 7;
			this.btnCaliZDown.Text = "Z-";
			this.btnCaliZDown.UseVisualStyleBackColor = true;
			this.btnCaliZDown.Click += new global::System.EventHandler(this.btnCaliZDown_Click);
			this.cmbCaliZDis.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.Simple;
			this.cmbCaliZDis.FormattingEnabled = true;
			this.cmbCaliZDis.Items.AddRange(new object[]
			{
				"0.05",
				"0.2",
				"0.5"
			});
			this.cmbCaliZDis.Location = new global::System.Drawing.Point(656, 121);
			this.cmbCaliZDis.Name = "cmbCaliZDis";
			this.cmbCaliZDis.Size = new global::System.Drawing.Size(49, 20);
			this.cmbCaliZDis.TabIndex = 10;
			this.btnCaliZUp.Location = new global::System.Drawing.Point(656, 44);
			this.btnCaliZUp.Name = "btnCaliZUp";
			this.btnCaliZUp.Size = new global::System.Drawing.Size(49, 49);
			this.btnCaliZUp.TabIndex = 6;
			this.btnCaliZUp.Text = "Z+";
			this.btnCaliZUp.UseVisualStyleBackColor = true;
			this.btnCaliZUp.Click += new global::System.EventHandler(this.btnCaliZUp_Click);
			this.tabPage4.Controls.Add(this.btnTrigglePowerPanic);
			this.tabPage4.Controls.Add(this.btnAuto);
			this.tabPage4.Controls.Add(this.btnClearFault);
			this.tabPage4.Controls.Add(this.btnCheckFault);
			this.tabPage4.Controls.Add(this.btnGetPowerPanicData);
			this.tabPage4.Controls.Add(this.label4);
			this.tabPage4.Controls.Add(this.btnPowerPanicContinue);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "PowerPanic";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.btnTrigglePowerPanic.Location = new global::System.Drawing.Point(673, 134);
			this.btnTrigglePowerPanic.Name = "btnTrigglePowerPanic";
			this.btnTrigglePowerPanic.Size = new global::System.Drawing.Size(198, 28);
			this.btnTrigglePowerPanic.TabIndex = 7;
			this.btnTrigglePowerPanic.Text = "Triggle the Power panic";
			this.btnTrigglePowerPanic.UseVisualStyleBackColor = true;
			this.btnTrigglePowerPanic.Click += new global::System.EventHandler(this.btnTrigglePowerPanic_Click);
			this.btnAuto.Location = new global::System.Drawing.Point(673, 64);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new global::System.Drawing.Size(97, 28);
			this.btnAuto.TabIndex = 6;
			this.btnAuto.Text = "Auto Start";
			this.btnAuto.UseVisualStyleBackColor = true;
			this.btnAuto.Click += new global::System.EventHandler(this.btnAuto_Click);
			this.btnClearFault.Location = new global::System.Drawing.Point(47, 230);
			this.btnClearFault.Name = "btnClearFault";
			this.btnClearFault.Size = new global::System.Drawing.Size(182, 23);
			this.btnClearFault.TabIndex = 5;
			this.btnClearFault.Text = "Clear Fault";
			this.btnClearFault.UseVisualStyleBackColor = true;
			this.btnClearFault.Click += new global::System.EventHandler(this.btnClearFault_Click);
			this.btnCheckFault.Location = new global::System.Drawing.Point(47, 168);
			this.btnCheckFault.Name = "btnCheckFault";
			this.btnCheckFault.Size = new global::System.Drawing.Size(182, 23);
			this.btnCheckFault.TabIndex = 4;
			this.btnCheckFault.Text = "Check Fault";
			this.btnCheckFault.UseVisualStyleBackColor = true;
			this.btnCheckFault.Click += new global::System.EventHandler(this.btnCheckFault_Click);
			this.btnGetPowerPanicData.Location = new global::System.Drawing.Point(47, 111);
			this.btnGetPowerPanicData.Name = "btnGetPowerPanicData";
			this.btnGetPowerPanicData.Size = new global::System.Drawing.Size(182, 23);
			this.btnGetPowerPanicData.TabIndex = 3;
			this.btnGetPowerPanicData.Text = "Get Data";
			this.btnGetPowerPanicData.UseVisualStyleBackColor = true;
			this.btnGetPowerPanicData.Click += new global::System.EventHandler(this.btnGetPowerPanicData_Click);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(469, 69);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(41, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "label4";
			this.btnPowerPanicContinue.Location = new global::System.Drawing.Point(47, 64);
			this.btnPowerPanicContinue.Name = "btnPowerPanicContinue";
			this.btnPowerPanicContinue.Size = new global::System.Drawing.Size(182, 23);
			this.btnPowerPanicContinue.TabIndex = 0;
			this.btnPowerPanicContinue.Text = "Power Panic Continue";
			this.btnPowerPanicContinue.UseVisualStyleBackColor = true;
			this.btnPowerPanicContinue.Click += new global::System.EventHandler(this.btnPowerPanicContinue_Click);
			this.tabPage6.Controls.Add(this.labCurrentLaserPercent);
			this.tabPage6.Controls.Add(this.label22);
			this.tabPage6.Controls.Add(this.btnDrawRuler);
			this.tabPage6.Controls.Add(this.btnDrawLaserCalibration);
			this.tabPage6.Controls.Add(this.txtFocusZ);
			this.tabPage6.Controls.Add(this.txtFocusY);
			this.tabPage6.Controls.Add(this.txtFocusX);
			this.tabPage6.Controls.Add(this.cbMovementRelative);
			this.tabPage6.Controls.Add(this.txtMovementZ);
			this.tabPage6.Controls.Add(this.txtMovementY);
			this.tabPage6.Controls.Add(this.txtMovementX);
			this.tabPage6.Controls.Add(this.btnMovementRequire);
			this.tabPage6.Controls.Add(this.btnZOriginal);
			this.tabPage6.Controls.Add(this.btnLaserZHome);
			this.tabPage6.Controls.Add(this.btnLaserFocusOff);
			this.tabPage6.Controls.Add(this.btnLaserFocusOn);
			this.tabPage6.Controls.Add(this.button2);
			this.tabPage6.Controls.Add(this.btnGetFocus);
			this.tabPage6.Controls.Add(this.label15);
			this.tabPage6.Controls.Add(this.txtLaserFocusHeight);
			this.tabPage6.Controls.Add(this.btnLaserEnterSetFocus);
			this.tabPage6.Controls.Add(this.btnSetOriginal);
			this.tabPage6.Controls.Add(this.btnSetFocusHigh);
			this.tabPage6.Controls.Add(this.labLaserPower);
			this.tabPage6.Controls.Add(this.tbLaserPower);
			this.tabPage6.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Laser";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.labCurrentLaserPercent.AutoSize = true;
			this.labCurrentLaserPercent.Location = new global::System.Drawing.Point(700, 43);
			this.labCurrentLaserPercent.Name = "labCurrentLaserPercent";
			this.labCurrentLaserPercent.Size = new global::System.Drawing.Size(17, 12);
			this.labCurrentLaserPercent.TabIndex = 34;
			this.labCurrentLaserPercent.Text = "NA";
			this.label22.AutoSize = true;
			this.label22.Location = new global::System.Drawing.Point(593, 43);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(101, 12);
			this.label22.TabIndex = 33;
			this.label22.Text = "Current Percent:";
			this.btnDrawRuler.Location = new global::System.Drawing.Point(823, 184);
			this.btnDrawRuler.Name = "btnDrawRuler";
			this.btnDrawRuler.Size = new global::System.Drawing.Size(125, 23);
			this.btnDrawRuler.TabIndex = 32;
			this.btnDrawRuler.Text = "Drwa Ruler";
			this.btnDrawRuler.UseVisualStyleBackColor = true;
			this.btnDrawRuler.Click += new global::System.EventHandler(this.btnDrawRuler_Click);
			this.btnDrawLaserCalibration.Location = new global::System.Drawing.Point(670, 184);
			this.btnDrawLaserCalibration.Name = "btnDrawLaserCalibration";
			this.btnDrawLaserCalibration.Size = new global::System.Drawing.Size(125, 23);
			this.btnDrawLaserCalibration.TabIndex = 31;
			this.btnDrawLaserCalibration.Text = "Drwa Clibration";
			this.btnDrawLaserCalibration.UseVisualStyleBackColor = true;
			this.btnDrawLaserCalibration.Click += new global::System.EventHandler(this.btnDrawLaserCalibration_Click);
			this.txtFocusZ.Location = new global::System.Drawing.Point(531, 186);
			this.txtFocusZ.Name = "txtFocusZ";
			this.txtFocusZ.Size = new global::System.Drawing.Size(100, 21);
			this.txtFocusZ.TabIndex = 30;
			this.txtFocusZ.Text = "100";
			this.txtFocusY.Location = new global::System.Drawing.Point(410, 189);
			this.txtFocusY.Name = "txtFocusY";
			this.txtFocusY.Size = new global::System.Drawing.Size(100, 21);
			this.txtFocusY.TabIndex = 29;
			this.txtFocusY.Text = "10";
			this.txtFocusX.Location = new global::System.Drawing.Point(293, 189);
			this.txtFocusX.Name = "txtFocusX";
			this.txtFocusX.Size = new global::System.Drawing.Size(100, 21);
			this.txtFocusX.TabIndex = 28;
			this.txtFocusX.Text = "10";
			this.cbMovementRelative.AutoSize = true;
			this.cbMovementRelative.Location = new global::System.Drawing.Point(656, 275);
			this.cbMovementRelative.Name = "cbMovementRelative";
			this.cbMovementRelative.Size = new global::System.Drawing.Size(102, 16);
			this.cbMovementRelative.TabIndex = 27;
			this.cbMovementRelative.Text = "Relative Mode";
			this.cbMovementRelative.UseVisualStyleBackColor = true;
			this.txtMovementZ.Location = new global::System.Drawing.Point(531, 270);
			this.txtMovementZ.Name = "txtMovementZ";
			this.txtMovementZ.Size = new global::System.Drawing.Size(100, 21);
			this.txtMovementZ.TabIndex = 26;
			this.txtMovementZ.Text = "30";
			this.txtMovementY.Location = new global::System.Drawing.Point(410, 270);
			this.txtMovementY.Name = "txtMovementY";
			this.txtMovementY.Size = new global::System.Drawing.Size(100, 21);
			this.txtMovementY.TabIndex = 25;
			this.txtMovementY.Text = "10";
			this.txtMovementX.Location = new global::System.Drawing.Point(293, 270);
			this.txtMovementX.Name = "txtMovementX";
			this.txtMovementX.Size = new global::System.Drawing.Size(100, 21);
			this.txtMovementX.TabIndex = 24;
			this.txtMovementX.Text = "10";
			this.btnMovementRequire.Location = new global::System.Drawing.Point(102, 268);
			this.btnMovementRequire.Name = "btnMovementRequire";
			this.btnMovementRequire.Size = new global::System.Drawing.Size(160, 23);
			this.btnMovementRequire.TabIndex = 23;
			this.btnMovementRequire.Text = "Movement Require";
			this.btnMovementRequire.UseVisualStyleBackColor = true;
			this.btnMovementRequire.Click += new global::System.EventHandler(this.btnMovementRequire_Click);
			this.btnZOriginal.Location = new global::System.Drawing.Point(984, 94);
			this.btnZOriginal.Name = "btnZOriginal";
			this.btnZOriginal.Size = new global::System.Drawing.Size(113, 24);
			this.btnZOriginal.TabIndex = 22;
			this.btnZOriginal.Text = "Original";
			this.btnZOriginal.UseVisualStyleBackColor = true;
			this.btnZOriginal.Click += new global::System.EventHandler(this.btnZOriginal_Click);
			this.btnLaserZHome.Location = new global::System.Drawing.Point(984, 37);
			this.btnLaserZHome.Name = "btnLaserZHome";
			this.btnLaserZHome.Size = new global::System.Drawing.Size(113, 24);
			this.btnLaserZHome.TabIndex = 21;
			this.btnLaserZHome.Text = "Z Home";
			this.btnLaserZHome.UseVisualStyleBackColor = true;
			this.btnLaserZHome.Click += new global::System.EventHandler(this.btnLaserZHome_Click);
			this.btnLaserFocusOff.Location = new global::System.Drawing.Point(964, 268);
			this.btnLaserFocusOff.Name = "btnLaserFocusOff";
			this.btnLaserFocusOff.Size = new global::System.Drawing.Size(75, 23);
			this.btnLaserFocusOff.TabIndex = 20;
			this.btnLaserFocusOff.Text = "Laser Off";
			this.btnLaserFocusOff.UseVisualStyleBackColor = true;
			this.btnLaserFocusOff.Click += new global::System.EventHandler(this.btnLaserFocusOff_Click);
			this.btnLaserFocusOn.Location = new global::System.Drawing.Point(833, 268);
			this.btnLaserFocusOn.Name = "btnLaserFocusOn";
			this.btnLaserFocusOn.Size = new global::System.Drawing.Size(75, 23);
			this.btnLaserFocusOn.TabIndex = 19;
			this.btnLaserFocusOn.Text = "Laser On";
			this.btnLaserFocusOn.UseVisualStyleBackColor = true;
			this.btnLaserFocusOn.Click += new global::System.EventHandler(this.btnLaserFocusOn_Click);
			this.button2.Location = new global::System.Drawing.Point(806, 142);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(102, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.btnGetFocus.Location = new global::System.Drawing.Point(806, 95);
			this.btnGetFocus.Name = "btnGetFocus";
			this.btnGetFocus.Size = new global::System.Drawing.Size(102, 23);
			this.btnGetFocus.TabIndex = 16;
			this.btnGetFocus.Text = "Get Focus";
			this.btnGetFocus.UseVisualStyleBackColor = true;
			this.btnGetFocus.Click += new global::System.EventHandler(this.btnGetFocus_Click);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(31, 126);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(47, 12);
			this.label15.TabIndex = 15;
			this.label15.Text = "Height:";
			this.txtLaserFocusHeight.Location = new global::System.Drawing.Point(102, 123);
			this.txtLaserFocusHeight.Name = "txtLaserFocusHeight";
			this.txtLaserFocusHeight.Size = new global::System.Drawing.Size(100, 21);
			this.txtLaserFocusHeight.TabIndex = 14;
			this.txtLaserFocusHeight.Text = "20";
			this.btnLaserEnterSetFocus.Location = new global::System.Drawing.Point(102, 189);
			this.btnLaserEnterSetFocus.Name = "btnLaserEnterSetFocus";
			this.btnLaserEnterSetFocus.Size = new global::System.Drawing.Size(160, 23);
			this.btnLaserEnterSetFocus.TabIndex = 11;
			this.btnLaserEnterSetFocus.Text = "Enter Set Focus";
			this.btnLaserEnterSetFocus.UseVisualStyleBackColor = true;
			this.btnLaserEnterSetFocus.Click += new global::System.EventHandler(this.btnLaserEnterSetFocus_Click);
			this.btnSetOriginal.Location = new global::System.Drawing.Point(984, 188);
			this.btnSetOriginal.Name = "btnSetOriginal";
			this.btnSetOriginal.Size = new global::System.Drawing.Size(113, 24);
			this.btnSetOriginal.TabIndex = 10;
			this.btnSetOriginal.Text = "Set Original";
			this.btnSetOriginal.UseVisualStyleBackColor = true;
			this.btnSetOriginal.Click += new global::System.EventHandler(this.btnSetOriginal_Click);
			this.btnSetFocusHigh.Location = new global::System.Drawing.Point(984, 142);
			this.btnSetFocusHigh.Name = "btnSetFocusHigh";
			this.btnSetFocusHigh.Size = new global::System.Drawing.Size(113, 23);
			this.btnSetFocusHigh.TabIndex = 8;
			this.btnSetFocusHigh.Text = "Set Focus Height";
			this.btnSetFocusHigh.UseVisualStyleBackColor = true;
			this.btnSetFocusHigh.Click += new global::System.EventHandler(this.btnSetFocusHigh_Click);
			this.labLaserPower.AutoSize = true;
			this.labLaserPower.Location = new global::System.Drawing.Point(493, 94);
			this.labLaserPower.Name = "labLaserPower";
			this.labLaserPower.Size = new global::System.Drawing.Size(47, 12);
			this.labLaserPower.TabIndex = 7;
			this.labLaserPower.Text = "label10";
			this.tbLaserPower.Location = new global::System.Drawing.Point(102, 37);
			this.tbLaserPower.Maximum = 100;
			this.tbLaserPower.Name = "tbLaserPower";
			this.tbLaserPower.Size = new global::System.Drawing.Size(441, 45);
			this.tbLaserPower.TabIndex = 6;
			this.tbLaserPower.Scroll += new global::System.EventHandler(this.tbLaserPower_Scroll);
			this.tbLaserPower.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.tbLaserPower_MouseUp);
			this.tabPage7.Controls.Add(this.btnCNCSetOrigin);
			this.tabPage7.Controls.Add(this.labTargetRPM);
			this.tabPage7.Controls.Add(this.label11);
			this.tabPage7.Controls.Add(this.tbRPM);
			this.tabPage7.Controls.Add(this.labRPM);
			this.tabPage7.Controls.Add(this.label10);
			this.tabPage7.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "CNC";
			this.tabPage7.UseVisualStyleBackColor = true;
			this.btnCNCSetOrigin.Location = new global::System.Drawing.Point(475, 182);
			this.btnCNCSetOrigin.Name = "btnCNCSetOrigin";
			this.btnCNCSetOrigin.Size = new global::System.Drawing.Size(113, 24);
			this.btnCNCSetOrigin.TabIndex = 11;
			this.btnCNCSetOrigin.Text = "Set Original";
			this.btnCNCSetOrigin.UseVisualStyleBackColor = true;
			this.btnCNCSetOrigin.Click += new global::System.EventHandler(this.btnCNCSetOrigin_Click);
			this.labTargetRPM.AutoSize = true;
			this.labTargetRPM.Location = new global::System.Drawing.Point(616, 92);
			this.labTargetRPM.Name = "labTargetRPM";
			this.labTargetRPM.Size = new global::System.Drawing.Size(11, 12);
			this.labTargetRPM.TabIndex = 9;
			this.labTargetRPM.Text = "0";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(58, 92);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(53, 12);
			this.label11.TabIndex = 8;
			this.label11.Text = "RPM Set:";
			this.tbRPM.Location = new global::System.Drawing.Point(147, 80);
			this.tbRPM.Maximum = 100;
			this.tbRPM.Name = "tbRPM";
			this.tbRPM.Size = new global::System.Drawing.Size(441, 45);
			this.tbRPM.TabIndex = 7;
			this.tbRPM.Scroll += new global::System.EventHandler(this.tbRPM_Scroll);
			this.tbRPM.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.tbRPM_MouseUp);
			this.labRPM.AutoSize = true;
			this.labRPM.Location = new global::System.Drawing.Point(145, 53);
			this.labRPM.Name = "labRPM";
			this.labRPM.Size = new global::System.Drawing.Size(11, 12);
			this.labRPM.TabIndex = 1;
			this.labRPM.Text = "0";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(58, 53);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(77, 12);
			this.label10.TabIndex = 0;
			this.label10.Text = "Current RPM:";
			this.tabPage5.Controls.Add(this.button12);
			this.tabPage5.Controls.Add(this.button11);
			this.tabPage5.Controls.Add(this.btnFanOff);
			this.tabPage5.Controls.Add(this.btnFanOn);
			this.tabPage5.Controls.Add(this.label9);
			this.tabPage5.Controls.Add(this.label8);
			this.tabPage5.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Status";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.button12.Location = new global::System.Drawing.Point(741, 91);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(75, 23);
			this.button12.TabIndex = 21;
			this.button12.Text = "button12";
			this.button12.UseVisualStyleBackColor = true;
			this.button11.Location = new global::System.Drawing.Point(741, 34);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(75, 23);
			this.button11.TabIndex = 20;
			this.button11.Text = "button11";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new global::System.EventHandler(this.button11_Click);
			this.btnFanOff.Location = new global::System.Drawing.Point(511, 192);
			this.btnFanOff.Name = "btnFanOff";
			this.btnFanOff.Size = new global::System.Drawing.Size(75, 23);
			this.btnFanOff.TabIndex = 19;
			this.btnFanOff.Text = "Fan0 Off";
			this.btnFanOff.UseVisualStyleBackColor = true;
			this.btnFanOff.Click += new global::System.EventHandler(this.btnFanOff_Click);
			this.btnFanOn.Location = new global::System.Drawing.Point(511, 151);
			this.btnFanOn.Name = "btnFanOn";
			this.btnFanOn.Size = new global::System.Drawing.Size(75, 23);
			this.btnFanOn.TabIndex = 18;
			this.btnFanOn.Text = "Fan0 On";
			this.btnFanOn.UseVisualStyleBackColor = true;
			this.btnFanOn.Click += new global::System.EventHandler(this.btnFanOn_Click);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(39, 76);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(41, 12);
			this.label9.TabIndex = 1;
			this.label9.Text = "报警：";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(39, 34);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(41, 12);
			this.label8.TabIndex = 0;
			this.label8.Text = "状态：";
			this.tabPage8.Controls.Add(this.btnEnableFilamentSensor);
			this.tabPage8.Controls.Add(this.btnDisableFilamentSensor);
			this.tabPage8.Controls.Add(this.rbSizeL);
			this.tabPage8.Controls.Add(this.rbSizeM);
			this.tabPage8.Controls.Add(this.rbSizeS);
			this.tabPage8.Controls.Add(this.btnGetSize);
			this.tabPage8.Controls.Add(this.label13);
			this.tabPage8.Controls.Add(this.txtZOffset);
			this.tabPage8.Controls.Add(this.txtYOffset);
			this.tabPage8.Controls.Add(this.txtXOffset);
			this.tabPage8.Controls.Add(this.cbZHomeDir);
			this.tabPage8.Controls.Add(this.cbYHomeDir);
			this.tabPage8.Controls.Add(this.cbXHomeDir);
			this.tabPage8.Controls.Add(this.cbZDir);
			this.tabPage8.Controls.Add(this.cbYDir);
			this.tabPage8.Controls.Add(this.cbXDir);
			this.tabPage8.Controls.Add(this.btnSetSize);
			this.tabPage8.Controls.Add(this.txtZSize);
			this.tabPage8.Controls.Add(this.txtYSize);
			this.tabPage8.Controls.Add(this.txtXSize);
			this.tabPage8.Controls.Add(this.label12);
			this.tabPage8.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Setting";
			this.tabPage8.UseVisualStyleBackColor = true;
			this.btnEnableFilamentSensor.Location = new global::System.Drawing.Point(823, 217);
			this.btnEnableFilamentSensor.Name = "btnEnableFilamentSensor";
			this.btnEnableFilamentSensor.Size = new global::System.Drawing.Size(156, 42);
			this.btnEnableFilamentSensor.TabIndex = 20;
			this.btnEnableFilamentSensor.Text = "Enable Filament Sensor";
			this.btnEnableFilamentSensor.UseVisualStyleBackColor = true;
			this.btnEnableFilamentSensor.Click += new global::System.EventHandler(this.btnEnableFilamentSensor_Click);
			this.btnDisableFilamentSensor.Location = new global::System.Drawing.Point(823, 161);
			this.btnDisableFilamentSensor.Name = "btnDisableFilamentSensor";
			this.btnDisableFilamentSensor.Size = new global::System.Drawing.Size(156, 42);
			this.btnDisableFilamentSensor.TabIndex = 19;
			this.btnDisableFilamentSensor.Text = "Disable Filament Sensor";
			this.btnDisableFilamentSensor.UseVisualStyleBackColor = true;
			this.btnDisableFilamentSensor.Click += new global::System.EventHandler(this.btnDisableFilamentSensor_Click);
			this.rbSizeL.AutoSize = true;
			this.rbSizeL.Location = new global::System.Drawing.Point(638, 243);
			this.rbSizeL.Name = "rbSizeL";
			this.rbSizeL.Size = new global::System.Drawing.Size(59, 16);
			this.rbSizeL.TabIndex = 18;
			this.rbSizeL.Text = "Size L";
			this.rbSizeL.UseVisualStyleBackColor = true;
			this.rbSizeM.AutoSize = true;
			this.rbSizeM.Location = new global::System.Drawing.Point(638, 199);
			this.rbSizeM.Name = "rbSizeM";
			this.rbSizeM.Size = new global::System.Drawing.Size(59, 16);
			this.rbSizeM.TabIndex = 17;
			this.rbSizeM.Text = "Size M";
			this.rbSizeM.UseVisualStyleBackColor = true;
			this.rbSizeS.AutoSize = true;
			this.rbSizeS.Checked = true;
			this.rbSizeS.Location = new global::System.Drawing.Point(638, 161);
			this.rbSizeS.Name = "rbSizeS";
			this.rbSizeS.Size = new global::System.Drawing.Size(59, 16);
			this.rbSizeS.TabIndex = 16;
			this.rbSizeS.TabStop = true;
			this.rbSizeS.Text = "Size S";
			this.rbSizeS.UseVisualStyleBackColor = true;
			this.btnGetSize.Location = new global::System.Drawing.Point(823, 92);
			this.btnGetSize.Name = "btnGetSize";
			this.btnGetSize.Size = new global::System.Drawing.Size(156, 45);
			this.btnGetSize.TabIndex = 15;
			this.btnGetSize.Text = "Get Machine Size";
			this.btnGetSize.UseVisualStyleBackColor = true;
			this.btnGetSize.Click += new global::System.EventHandler(this.btnGetSize_Click);
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(45, 185);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(47, 12);
			this.label13.TabIndex = 14;
			this.label13.Text = "Offset:";
			this.txtZOffset.Location = new global::System.Drawing.Point(97, 297);
			this.txtZOffset.Name = "txtZOffset";
			this.txtZOffset.Size = new global::System.Drawing.Size(100, 21);
			this.txtZOffset.TabIndex = 13;
			this.txtZOffset.Text = "-10";
			this.txtYOffset.Location = new global::System.Drawing.Point(97, 238);
			this.txtYOffset.Name = "txtYOffset";
			this.txtYOffset.Size = new global::System.Drawing.Size(100, 21);
			this.txtYOffset.TabIndex = 12;
			this.txtYOffset.Text = "-5";
			this.txtXOffset.Location = new global::System.Drawing.Point(97, 182);
			this.txtXOffset.Name = "txtXOffset";
			this.txtXOffset.Size = new global::System.Drawing.Size(100, 21);
			this.txtXOffset.TabIndex = 11;
			this.txtXOffset.Text = "-5";
			this.cbZHomeDir.AutoSize = true;
			this.cbZHomeDir.Location = new global::System.Drawing.Point(410, 140);
			this.cbZHomeDir.Name = "cbZHomeDir";
			this.cbZHomeDir.Size = new global::System.Drawing.Size(84, 16);
			this.cbZHomeDir.TabIndex = 10;
			this.cbZHomeDir.Text = "Z Home Dir";
			this.cbZHomeDir.UseVisualStyleBackColor = true;
			this.cbYHomeDir.AutoSize = true;
			this.cbYHomeDir.Location = new global::System.Drawing.Point(410, 81);
			this.cbYHomeDir.Name = "cbYHomeDir";
			this.cbYHomeDir.Size = new global::System.Drawing.Size(84, 16);
			this.cbYHomeDir.TabIndex = 9;
			this.cbYHomeDir.Text = "Y Home Dir";
			this.cbYHomeDir.UseVisualStyleBackColor = true;
			this.cbXHomeDir.AutoSize = true;
			this.cbXHomeDir.Location = new global::System.Drawing.Point(412, 22);
			this.cbXHomeDir.Name = "cbXHomeDir";
			this.cbXHomeDir.Size = new global::System.Drawing.Size(84, 16);
			this.cbXHomeDir.TabIndex = 8;
			this.cbXHomeDir.Text = "X Home Dir";
			this.cbXHomeDir.UseVisualStyleBackColor = true;
			this.cbZDir.AutoSize = true;
			this.cbZDir.Location = new global::System.Drawing.Point(256, 140);
			this.cbZDir.Name = "cbZDir";
			this.cbZDir.Size = new global::System.Drawing.Size(54, 16);
			this.cbZDir.TabIndex = 7;
			this.cbZDir.Text = "Z Dir";
			this.cbZDir.UseVisualStyleBackColor = true;
			this.cbYDir.AutoSize = true;
			this.cbYDir.Location = new global::System.Drawing.Point(256, 81);
			this.cbYDir.Name = "cbYDir";
			this.cbYDir.Size = new global::System.Drawing.Size(54, 16);
			this.cbYDir.TabIndex = 6;
			this.cbYDir.Text = "Y Dir";
			this.cbYDir.UseVisualStyleBackColor = true;
			this.cbXDir.AutoSize = true;
			this.cbXDir.Location = new global::System.Drawing.Point(258, 22);
			this.cbXDir.Name = "cbXDir";
			this.cbXDir.Size = new global::System.Drawing.Size(54, 16);
			this.cbXDir.TabIndex = 5;
			this.cbXDir.Text = "X Dir";
			this.cbXDir.UseVisualStyleBackColor = true;
			this.btnSetSize.Location = new global::System.Drawing.Point(823, 10);
			this.btnSetSize.Name = "btnSetSize";
			this.btnSetSize.Size = new global::System.Drawing.Size(156, 45);
			this.btnSetSize.TabIndex = 4;
			this.btnSetSize.Text = "Set Machine Size";
			this.btnSetSize.UseVisualStyleBackColor = true;
			this.btnSetSize.Click += new global::System.EventHandler(this.btnSetSize_Click);
			this.txtZSize.Location = new global::System.Drawing.Point(97, 138);
			this.txtZSize.Name = "txtZSize";
			this.txtZSize.Size = new global::System.Drawing.Size(100, 21);
			this.txtZSize.TabIndex = 3;
			this.txtZSize.Text = "100";
			this.txtYSize.Location = new global::System.Drawing.Point(97, 79);
			this.txtYSize.Name = "txtYSize";
			this.txtYSize.Size = new global::System.Drawing.Size(100, 21);
			this.txtYSize.TabIndex = 2;
			this.txtYSize.Text = "100";
			this.txtXSize.Location = new global::System.Drawing.Point(97, 23);
			this.txtXSize.Name = "txtXSize";
			this.txtXSize.Size = new global::System.Drawing.Size(100, 21);
			this.txtXSize.TabIndex = 1;
			this.txtXSize.Text = "100";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(45, 26);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(35, 12);
			this.label12.TabIndex = 0;
			this.label12.Text = "Size:";
			this.tabPage9.Controls.Add(this.lstModuleVersions);
			this.tabPage9.Controls.Add(this.btnRequestModuleFirmwareVersion);
			this.tabPage9.Controls.Add(this.cbForceUpdate);
			this.tabPage9.Controls.Add(this.rbModuleType);
			this.tabPage9.Controls.Add(this.rbControler);
			this.tabPage9.Controls.Add(this.btnOpenOriginFile);
			this.tabPage9.Controls.Add(this.EnterUpdate);
			this.tabPage9.Controls.Add(this.button6);
			this.tabPage9.Controls.Add(this.btnGetUpdateStatus);
			this.tabPage9.Controls.Add(this.btnRequestFirmwareVersion);
			this.tabPage9.Controls.Add(this.labUpdateProgress);
			this.tabPage9.Controls.Add(this.btnUpdate);
			this.tabPage9.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "Update";
			this.tabPage9.UseVisualStyleBackColor = true;
			this.lstModuleVersions.FormattingEnabled = true;
			this.lstModuleVersions.ItemHeight = 12;
			this.lstModuleVersions.Location = new global::System.Drawing.Point(470, 149);
			this.lstModuleVersions.Name = "lstModuleVersions";
			this.lstModuleVersions.Size = new global::System.Drawing.Size(213, 160);
			this.lstModuleVersions.TabIndex = 41;
			this.lstModuleVersions.DoubleClick += new global::System.EventHandler(this.lstModuleVersions_DoubleClick);
			this.btnRequestModuleFirmwareVersion.Location = new global::System.Drawing.Point(261, 205);
			this.btnRequestModuleFirmwareVersion.Name = "btnRequestModuleFirmwareVersion";
			this.btnRequestModuleFirmwareVersion.Size = new global::System.Drawing.Size(122, 51);
			this.btnRequestModuleFirmwareVersion.TabIndex = 40;
			this.btnRequestModuleFirmwareVersion.Text = "Request Module Firmware Version";
			this.btnRequestModuleFirmwareVersion.UseVisualStyleBackColor = true;
			this.btnRequestModuleFirmwareVersion.Click += new global::System.EventHandler(this.btnRequestModuleFirmwareVersion_Click);
			this.cbForceUpdate.AutoSize = true;
			this.cbForceUpdate.Location = new global::System.Drawing.Point(898, 116);
			this.cbForceUpdate.Name = "cbForceUpdate";
			this.cbForceUpdate.Size = new global::System.Drawing.Size(96, 16);
			this.cbForceUpdate.TabIndex = 39;
			this.cbForceUpdate.Text = "Force Update";
			this.cbForceUpdate.UseVisualStyleBackColor = true;
			this.rbModuleType.AutoSize = true;
			this.rbModuleType.Location = new global::System.Drawing.Point(898, 73);
			this.rbModuleType.Name = "rbModuleType";
			this.rbModuleType.Size = new global::System.Drawing.Size(47, 16);
			this.rbModuleType.TabIndex = 38;
			this.rbModuleType.Text = "模块";
			this.rbModuleType.UseVisualStyleBackColor = true;
			this.rbControler.AutoSize = true;
			this.rbControler.Checked = true;
			this.rbControler.Location = new global::System.Drawing.Point(898, 38);
			this.rbControler.Name = "rbControler";
			this.rbControler.Size = new global::System.Drawing.Size(47, 16);
			this.rbControler.TabIndex = 37;
			this.rbControler.TabStop = true;
			this.rbControler.Text = "主控";
			this.rbControler.UseVisualStyleBackColor = true;
			this.btnOpenOriginFile.Location = new global::System.Drawing.Point(704, 38);
			this.btnOpenOriginFile.Name = "btnOpenOriginFile";
			this.btnOpenOriginFile.Size = new global::System.Drawing.Size(117, 51);
			this.btnOpenOriginFile.TabIndex = 36;
			this.btnOpenOriginFile.Text = "Open Origin Bin File";
			this.btnOpenOriginFile.UseVisualStyleBackColor = true;
			this.btnOpenOriginFile.Click += new global::System.EventHandler(this.btnOpenOriginFile_Click);
			this.EnterUpdate.AutoSize = true;
			this.EnterUpdate.Location = new global::System.Drawing.Point(476, 116);
			this.EnterUpdate.Name = "EnterUpdate";
			this.EnterUpdate.Size = new global::System.Drawing.Size(96, 16);
			this.EnterUpdate.TabIndex = 35;
			this.EnterUpdate.Text = "Enter Update";
			this.EnterUpdate.UseVisualStyleBackColor = true;
			this.EnterUpdate.CheckedChanged += new global::System.EventHandler(this.EnterUpdate_CheckedChanged);
			this.button6.Location = new global::System.Drawing.Point(470, 52);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(75, 23);
			this.button6.TabIndex = 4;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.btnGetUpdateStatus.Location = new global::System.Drawing.Point(93, 205);
			this.btnGetUpdateStatus.Name = "btnGetUpdateStatus";
			this.btnGetUpdateStatus.Size = new global::System.Drawing.Size(122, 51);
			this.btnGetUpdateStatus.TabIndex = 3;
			this.btnGetUpdateStatus.Text = "Get Update Status";
			this.btnGetUpdateStatus.UseVisualStyleBackColor = true;
			this.btnGetUpdateStatus.Click += new global::System.EventHandler(this.btnGetUpdateStatus_Click);
			this.btnRequestFirmwareVersion.Location = new global::System.Drawing.Point(93, 116);
			this.btnRequestFirmwareVersion.Name = "btnRequestFirmwareVersion";
			this.btnRequestFirmwareVersion.Size = new global::System.Drawing.Size(122, 51);
			this.btnRequestFirmwareVersion.TabIndex = 2;
			this.btnRequestFirmwareVersion.Text = "Request Firmware Version";
			this.btnRequestFirmwareVersion.UseVisualStyleBackColor = true;
			this.btnRequestFirmwareVersion.Click += new global::System.EventHandler(this.btnRequestFirmwareVersion_Click);
			this.labUpdateProgress.AutoSize = true;
			this.labUpdateProgress.Location = new global::System.Drawing.Point(291, 57);
			this.labUpdateProgress.Name = "labUpdateProgress";
			this.labUpdateProgress.Size = new global::System.Drawing.Size(47, 12);
			this.labUpdateProgress.TabIndex = 1;
			this.labUpdateProgress.Text = "label16";
			this.btnUpdate.Location = new global::System.Drawing.Point(93, 38);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new global::System.Drawing.Size(122, 51);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new global::System.EventHandler(this.btnUpdate_Click);
			this.tabPage10.Controls.Add(this.btnGetBTMac);
			this.tabPage10.Controls.Add(this.btnSendTestData);
			this.tabPage10.Controls.Add(this.btnBTGetName);
			this.tabPage10.Controls.Add(this.labBTUpdateProgress);
			this.tabPage10.Controls.Add(this.label27);
			this.tabPage10.Controls.Add(this.txtBTName);
			this.tabPage10.Controls.Add(this.btnSetBTName);
			this.tabPage10.Controls.Add(this.btnBTSetName);
			this.tabPage10.Controls.Add(this.btnBTUpdate);
			this.tabPage10.Controls.Add(this.labBTPortStatus);
			this.tabPage10.Controls.Add(this.picboxBTImage);
			this.tabPage10.Controls.Add(this.btnBTImage);
			this.tabPage10.Controls.Add(this.btnOpenBTPort);
			this.tabPage10.Controls.Add(this.btnSerialBTPort);
			this.tabPage10.Controls.Add(this.label26);
			this.tabPage10.Controls.Add(this.cmbBTPort);
			this.tabPage10.Controls.Add(this.textBox2);
			this.tabPage10.Controls.Add(this.button3);
			this.tabPage10.Controls.Add(this.labCameraIP);
			this.tabPage10.Controls.Add(this.btnGetCameraIP);
			this.tabPage10.Controls.Add(this.btnSetWifiParameter);
			this.tabPage10.Controls.Add(this.txtPassword);
			this.tabPage10.Controls.Add(this.txtSSID);
			this.tabPage10.Controls.Add(this.label17);
			this.tabPage10.Controls.Add(this.label16);
			this.tabPage10.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage10.TabIndex = 9;
			this.tabPage10.Text = "LaserCamera";
			this.tabPage10.UseVisualStyleBackColor = true;
			this.btnGetBTMac.Location = new global::System.Drawing.Point(956, 251);
			this.btnGetBTMac.Name = "btnGetBTMac";
			this.btnGetBTMac.Size = new global::System.Drawing.Size(121, 23);
			this.btnGetBTMac.TabIndex = 29;
			this.btnGetBTMac.Text = "Get BT Mac";
			this.btnGetBTMac.UseVisualStyleBackColor = true;
			this.btnGetBTMac.Click += new global::System.EventHandler(this.btnGetBTMac_Click);
			this.btnSendTestData.Location = new global::System.Drawing.Point(381, 143);
			this.btnSendTestData.Name = "btnSendTestData";
			this.btnSendTestData.Size = new global::System.Drawing.Size(121, 23);
			this.btnSendTestData.TabIndex = 28;
			this.btnSendTestData.Text = "Send Test Data";
			this.btnSendTestData.UseVisualStyleBackColor = true;
			this.btnSendTestData.Click += new global::System.EventHandler(this.btnSendTestData_Click);
			this.btnBTGetName.Location = new global::System.Drawing.Point(451, 267);
			this.btnBTGetName.Name = "btnBTGetName";
			this.btnBTGetName.Size = new global::System.Drawing.Size(137, 49);
			this.btnBTGetName.TabIndex = 27;
			this.btnBTGetName.Text = "Get Name";
			this.btnBTGetName.UseVisualStyleBackColor = true;
			this.btnBTGetName.Click += new global::System.EventHandler(this.btnBTGetName_Click);
			this.labBTUpdateProgress.AutoSize = true;
			this.labBTUpdateProgress.Location = new global::System.Drawing.Point(523, 246);
			this.labBTUpdateProgress.Name = "labBTUpdateProgress";
			this.labBTUpdateProgress.Size = new global::System.Drawing.Size(23, 12);
			this.labBTUpdateProgress.TabIndex = 25;
			this.labBTUpdateProgress.Text = "0/0";
			this.label27.AutoSize = true;
			this.label27.Location = new global::System.Drawing.Point(6, 285);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(47, 12);
			this.label27.TabIndex = 24;
			this.label27.Text = "BT Name";
			this.txtBTName.Location = new global::System.Drawing.Point(97, 282);
			this.txtBTName.Name = "txtBTName";
			this.txtBTName.Size = new global::System.Drawing.Size(100, 21);
			this.txtBTName.TabIndex = 23;
			this.btnSetBTName.Location = new global::System.Drawing.Point(213, 267);
			this.btnSetBTName.Name = "btnSetBTName";
			this.btnSetBTName.Size = new global::System.Drawing.Size(142, 49);
			this.btnSetBTName.TabIndex = 22;
			this.btnSetBTName.Text = "Set BT Name";
			this.btnSetBTName.UseVisualStyleBackColor = true;
			this.btnSetBTName.Click += new global::System.EventHandler(this.btnSetBTName_Click);
			this.btnBTSetName.Location = new global::System.Drawing.Point(956, 222);
			this.btnBTSetName.Name = "btnBTSetName";
			this.btnBTSetName.Size = new global::System.Drawing.Size(121, 23);
			this.btnBTSetName.TabIndex = 21;
			this.btnBTSetName.Text = "Set Name";
			this.btnBTSetName.UseVisualStyleBackColor = true;
			this.btnBTSetName.Click += new global::System.EventHandler(this.btnBTSetName_Click);
			this.btnBTUpdate.Location = new global::System.Drawing.Point(956, 192);
			this.btnBTUpdate.Name = "btnBTUpdate";
			this.btnBTUpdate.Size = new global::System.Drawing.Size(121, 23);
			this.btnBTUpdate.TabIndex = 20;
			this.btnBTUpdate.Text = "Update";
			this.btnBTUpdate.UseVisualStyleBackColor = true;
			this.btnBTUpdate.Click += new global::System.EventHandler(this.btnBTUpdate_Click);
			this.labBTPortStatus.AutoSize = true;
			this.labBTPortStatus.Location = new global::System.Drawing.Point(954, 167);
			this.labBTPortStatus.Name = "labBTPortStatus";
			this.labBTPortStatus.Size = new global::System.Drawing.Size(41, 12);
			this.labBTPortStatus.TabIndex = 19;
			this.labBTPortStatus.Text = "未打开";
			this.picboxBTImage.Location = new global::System.Drawing.Point(686, 83);
			this.picboxBTImage.Name = "picboxBTImage";
			this.picboxBTImage.Size = new global::System.Drawing.Size(238, 226);
			this.picboxBTImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxBTImage.TabIndex = 18;
			this.picboxBTImage.TabStop = false;
			this.btnBTImage.Location = new global::System.Drawing.Point(956, 130);
			this.btnBTImage.Name = "btnBTImage";
			this.btnBTImage.Size = new global::System.Drawing.Size(121, 23);
			this.btnBTImage.TabIndex = 17;
			this.btnBTImage.Text = "Image";
			this.btnBTImage.UseVisualStyleBackColor = true;
			this.btnBTImage.Click += new global::System.EventHandler(this.btnBTImage_Click);
			this.btnOpenBTPort.Location = new global::System.Drawing.Point(956, 83);
			this.btnOpenBTPort.Name = "btnOpenBTPort";
			this.btnOpenBTPort.Size = new global::System.Drawing.Size(121, 23);
			this.btnOpenBTPort.TabIndex = 16;
			this.btnOpenBTPort.Text = "Open Port";
			this.btnOpenBTPort.UseVisualStyleBackColor = true;
			this.btnOpenBTPort.Click += new global::System.EventHandler(this.btnOpenBTPort_Click);
			this.btnSerialBTPort.Location = new global::System.Drawing.Point(956, 46);
			this.btnSerialBTPort.Name = "btnSerialBTPort";
			this.btnSerialBTPort.Size = new global::System.Drawing.Size(121, 23);
			this.btnSerialBTPort.TabIndex = 15;
			this.btnSerialBTPort.Text = "Search Port";
			this.btnSerialBTPort.UseVisualStyleBackColor = true;
			this.btnSerialBTPort.Click += new global::System.EventHandler(this.btnSerialBTPort_Click);
			this.label26.AutoSize = true;
			this.label26.Location = new global::System.Drawing.Point(684, 51);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(71, 12);
			this.label26.TabIndex = 14;
			this.label26.Text = "Blue Tooth:";
			this.cmbBTPort.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBTPort.FormattingEnabled = true;
			this.cmbBTPort.Location = new global::System.Drawing.Point(775, 48);
			this.cmbBTPort.Name = "cmbBTPort";
			this.cmbBTPort.Size = new global::System.Drawing.Size(121, 20);
			this.cmbBTPort.TabIndex = 13;
			this.textBox2.Location = new global::System.Drawing.Point(517, 143);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(154, 21);
			this.textBox2.TabIndex = 12;
			this.button3.Location = new global::System.Drawing.Point(213, 209);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(142, 49);
			this.button3.TabIndex = 8;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.labCameraIP.AutoSize = true;
			this.labCameraIP.Location = new global::System.Drawing.Point(95, 148);
			this.labCameraIP.Name = "labCameraIP";
			this.labCameraIP.Size = new global::System.Drawing.Size(47, 12);
			this.labCameraIP.TabIndex = 6;
			this.labCameraIP.Text = "label18";
			this.btnGetCameraIP.Location = new global::System.Drawing.Point(213, 130);
			this.btnGetCameraIP.Name = "btnGetCameraIP";
			this.btnGetCameraIP.Size = new global::System.Drawing.Size(142, 49);
			this.btnGetCameraIP.TabIndex = 5;
			this.btnGetCameraIP.Text = "Get Camera IP";
			this.btnGetCameraIP.UseVisualStyleBackColor = true;
			this.btnGetCameraIP.Click += new global::System.EventHandler(this.btnGetCameraIP_Click);
			this.btnSetWifiParameter.Location = new global::System.Drawing.Point(213, 46);
			this.btnSetWifiParameter.Name = "btnSetWifiParameter";
			this.btnSetWifiParameter.Size = new global::System.Drawing.Size(142, 49);
			this.btnSetWifiParameter.TabIndex = 4;
			this.btnSetWifiParameter.Text = "Set Wifi Parameter";
			this.btnSetWifiParameter.UseVisualStyleBackColor = true;
			this.btnSetWifiParameter.Click += new global::System.EventHandler(this.btnSetWifiParameter_Click);
			this.txtPassword.Location = new global::System.Drawing.Point(97, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(100, 21);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "qhfabz27";
			this.txtSSID.Location = new global::System.Drawing.Point(97, 48);
			this.txtSSID.Name = "txtSSID";
			this.txtSSID.Size = new global::System.Drawing.Size(100, 21);
			this.txtSSID.TabIndex = 2;
			this.txtSSID.Text = "C1";
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(18, 83);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(59, 12);
			this.label17.TabIndex = 1;
			this.label17.Text = "Password:";
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(18, 51);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(35, 12);
			this.label16.TabIndex = 0;
			this.label16.Text = "SSID:";
			this.tabPage11.Controls.Add(this.rbLightNormal);
			this.tabPage11.Controls.Add(this.rbLigthStatus);
			this.tabPage11.Controls.Add(this.tbLightBrightness);
			this.tabPage11.Controls.Add(this.cbLightOnoff);
			this.tabPage11.Controls.Add(this.btnGetLightStatus);
			this.tabPage11.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage11.TabIndex = 10;
			this.tabPage11.Text = "Status Light";
			this.tabPage11.UseVisualStyleBackColor = true;
			this.rbLightNormal.AutoSize = true;
			this.rbLightNormal.Location = new global::System.Drawing.Point(288, 149);
			this.rbLightNormal.Name = "rbLightNormal";
			this.rbLightNormal.Size = new global::System.Drawing.Size(53, 16);
			this.rbLightNormal.TabIndex = 8;
			this.rbLightNormal.Text = "Light";
			this.rbLightNormal.UseVisualStyleBackColor = true;
			this.rbLightNormal.CheckedChanged += new global::System.EventHandler(this.rbLightNormal_CheckedChanged);
			this.rbLigthStatus.AutoSize = true;
			this.rbLigthStatus.Checked = true;
			this.rbLigthStatus.Location = new global::System.Drawing.Point(60, 149);
			this.rbLigthStatus.Name = "rbLigthStatus";
			this.rbLigthStatus.Size = new global::System.Drawing.Size(59, 16);
			this.rbLigthStatus.TabIndex = 7;
			this.rbLigthStatus.TabStop = true;
			this.rbLigthStatus.Text = "Status";
			this.rbLigthStatus.UseVisualStyleBackColor = true;
			this.rbLigthStatus.CheckedChanged += new global::System.EventHandler(this.rbLigthStatus_CheckedChanged);
			this.tbLightBrightness.Location = new global::System.Drawing.Point(60, 193);
			this.tbLightBrightness.Maximum = 100;
			this.tbLightBrightness.Name = "tbLightBrightness";
			this.tbLightBrightness.Size = new global::System.Drawing.Size(441, 45);
			this.tbLightBrightness.TabIndex = 6;
			this.tbLightBrightness.Value = 50;
			this.cbLightOnoff.AutoSize = true;
			this.cbLightOnoff.Location = new global::System.Drawing.Point(60, 95);
			this.cbLightOnoff.Name = "cbLightOnoff";
			this.cbLightOnoff.Size = new global::System.Drawing.Size(72, 16);
			this.cbLightOnoff.TabIndex = 3;
			this.cbLightOnoff.Text = "Light On";
			this.cbLightOnoff.UseVisualStyleBackColor = true;
			this.cbLightOnoff.CheckedChanged += new global::System.EventHandler(this.cbLightOnoff_CheckedChanged);
			this.btnGetLightStatus.Location = new global::System.Drawing.Point(60, 31);
			this.btnGetLightStatus.Name = "btnGetLightStatus";
			this.btnGetLightStatus.Size = new global::System.Drawing.Size(112, 34);
			this.btnGetLightStatus.TabIndex = 2;
			this.btnGetLightStatus.Text = "Get Light Status";
			this.btnGetLightStatus.UseVisualStyleBackColor = true;
			this.btnGetLightStatus.Click += new global::System.EventHandler(this.btnGetLightStatus_Click);
			this.tabPage12.Controls.Add(this.label23);
			this.tabPage12.Controls.Add(this.txtCustomeRepeat);
			this.tabPage12.Controls.Add(this.btnRunCustomGcode);
			this.tabPage12.Controls.Add(this.btnLoadCustomGcodeFile);
			this.tabPage12.Controls.Add(this.rtbCustomFile);
			this.tabPage12.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage12.TabIndex = 11;
			this.tabPage12.Text = "CustomGcode";
			this.tabPage12.UseVisualStyleBackColor = true;
			this.label23.AutoSize = true;
			this.label23.Location = new global::System.Drawing.Point(576, 33);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(77, 12);
			this.label23.TabIndex = 4;
			this.label23.Text = "Repeat Time:";
			this.txtCustomeRepeat.Location = new global::System.Drawing.Point(684, 30);
			this.txtCustomeRepeat.Name = "txtCustomeRepeat";
			this.txtCustomeRepeat.Size = new global::System.Drawing.Size(100, 21);
			this.txtCustomeRepeat.TabIndex = 3;
			this.txtCustomeRepeat.Text = "1";
			this.btnRunCustomGcode.Location = new global::System.Drawing.Point(419, 77);
			this.btnRunCustomGcode.Name = "btnRunCustomGcode";
			this.btnRunCustomGcode.Size = new global::System.Drawing.Size(118, 37);
			this.btnRunCustomGcode.TabIndex = 2;
			this.btnRunCustomGcode.Text = "Run";
			this.btnRunCustomGcode.UseVisualStyleBackColor = true;
			this.btnRunCustomGcode.Click += new global::System.EventHandler(this.btnRunCustomGcode_Click);
			this.btnLoadCustomGcodeFile.Location = new global::System.Drawing.Point(419, 22);
			this.btnLoadCustomGcodeFile.Name = "btnLoadCustomGcodeFile";
			this.btnLoadCustomGcodeFile.Size = new global::System.Drawing.Size(118, 35);
			this.btnLoadCustomGcodeFile.TabIndex = 1;
			this.btnLoadCustomGcodeFile.Text = "Load File";
			this.btnLoadCustomGcodeFile.UseVisualStyleBackColor = true;
			this.btnLoadCustomGcodeFile.Click += new global::System.EventHandler(this.btnLoadCustomGcodeFile_Click);
			this.rtbCustomFile.Location = new global::System.Drawing.Point(15, 22);
			this.rtbCustomFile.Name = "rtbCustomFile";
			this.rtbCustomFile.Size = new global::System.Drawing.Size(368, 294);
			this.rtbCustomFile.TabIndex = 0;
			this.rtbCustomFile.Text = "";
			this.tabPage13.Controls.Add(this.txtNewLead);
			this.tabPage13.Controls.Add(this.txtNewLength);
			this.tabPage13.Controls.Add(this.btnSetLinearModuleLead);
			this.tabPage13.Controls.Add(this.btnSetLinearModuleLength);
			this.tabPage13.Controls.Add(this.label25);
			this.tabPage13.Controls.Add(this.label24);
			this.tabPage13.Controls.Add(this.txtNewMacID);
			this.tabPage13.Controls.Add(this.txtOldMacID);
			this.tabPage13.Controls.Add(this.btnSetMacID);
			this.tabPage13.Controls.Add(this.lstModuleInfo);
			this.tabPage13.Controls.Add(this.btnGetLinearModuleLead);
			this.tabPage13.Controls.Add(this.btnGetLinearModuleLength);
			this.tabPage13.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Size = new global::System.Drawing.Size(1133, 331);
			this.tabPage13.TabIndex = 12;
			this.tabPage13.Text = "Debug";
			this.tabPage13.UseVisualStyleBackColor = true;
			this.txtNewLead.Location = new global::System.Drawing.Point(746, 266);
			this.txtNewLead.Name = "txtNewLead";
			this.txtNewLead.Size = new global::System.Drawing.Size(100, 21);
			this.txtNewLead.TabIndex = 15;
			this.txtNewLength.Location = new global::System.Drawing.Point(746, 185);
			this.txtNewLength.Name = "txtNewLength";
			this.txtNewLength.Size = new global::System.Drawing.Size(100, 21);
			this.txtNewLength.TabIndex = 14;
			this.btnSetLinearModuleLead.Location = new global::System.Drawing.Point(562, 250);
			this.btnSetLinearModuleLead.Name = "btnSetLinearModuleLead";
			this.btnSetLinearModuleLead.Size = new global::System.Drawing.Size(122, 51);
			this.btnSetLinearModuleLead.TabIndex = 13;
			this.btnSetLinearModuleLead.Text = "Set Linear Module Lead";
			this.btnSetLinearModuleLead.UseVisualStyleBackColor = true;
			this.btnSetLinearModuleLead.Click += new global::System.EventHandler(this.btnSetLinearModuleLead_Click);
			this.btnSetLinearModuleLength.Location = new global::System.Drawing.Point(562, 169);
			this.btnSetLinearModuleLength.Name = "btnSetLinearModuleLength";
			this.btnSetLinearModuleLength.Size = new global::System.Drawing.Size(122, 51);
			this.btnSetLinearModuleLength.TabIndex = 12;
			this.btnSetLinearModuleLength.Text = "Set Linear Module Length";
			this.btnSetLinearModuleLength.UseVisualStyleBackColor = true;
			this.btnSetLinearModuleLength.Click += new global::System.EventHandler(this.btnSetLinearModuleLength_Click);
			this.label25.AutoSize = true;
			this.label25.Location = new global::System.Drawing.Point(744, 127);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(53, 12);
			this.label25.TabIndex = 11;
			this.label25.Text = "New Mac:";
			this.label24.AutoSize = true;
			this.label24.Location = new global::System.Drawing.Point(744, 76);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(53, 12);
			this.label24.TabIndex = 10;
			this.label24.Text = "Old Mac:";
			this.txtNewMacID.Location = new global::System.Drawing.Point(810, 124);
			this.txtNewMacID.Name = "txtNewMacID";
			this.txtNewMacID.Size = new global::System.Drawing.Size(100, 21);
			this.txtNewMacID.TabIndex = 9;
			this.txtOldMacID.Location = new global::System.Drawing.Point(810, 73);
			this.txtOldMacID.Name = "txtOldMacID";
			this.txtOldMacID.Size = new global::System.Drawing.Size(100, 21);
			this.txtOldMacID.TabIndex = 8;
			this.btnSetMacID.Location = new global::System.Drawing.Point(562, 73);
			this.btnSetMacID.Name = "btnSetMacID";
			this.btnSetMacID.Size = new global::System.Drawing.Size(122, 51);
			this.btnSetMacID.TabIndex = 7;
			this.btnSetMacID.Text = "Set MacID";
			this.btnSetMacID.UseVisualStyleBackColor = true;
			this.btnSetMacID.Click += new global::System.EventHandler(this.btnSetMacID_Click);
			this.lstModuleInfo.FormattingEnabled = true;
			this.lstModuleInfo.ItemHeight = 12;
			this.lstModuleInfo.Location = new global::System.Drawing.Point(293, 73);
			this.lstModuleInfo.Name = "lstModuleInfo";
			this.lstModuleInfo.Size = new global::System.Drawing.Size(200, 148);
			this.lstModuleInfo.TabIndex = 6;
			this.lstModuleInfo.Click += new global::System.EventHandler(this.lstModuleInfo_Click);
			this.btnGetLinearModuleLead.Location = new global::System.Drawing.Point(100, 169);
			this.btnGetLinearModuleLead.Name = "btnGetLinearModuleLead";
			this.btnGetLinearModuleLead.Size = new global::System.Drawing.Size(122, 51);
			this.btnGetLinearModuleLead.TabIndex = 5;
			this.btnGetLinearModuleLead.Text = "Get Linear Module Lead";
			this.btnGetLinearModuleLead.UseVisualStyleBackColor = true;
			this.btnGetLinearModuleLead.Click += new global::System.EventHandler(this.btnGetLinearModuleLead_Click);
			this.btnGetLinearModuleLength.Location = new global::System.Drawing.Point(100, 73);
			this.btnGetLinearModuleLength.Name = "btnGetLinearModuleLength";
			this.btnGetLinearModuleLength.Size = new global::System.Drawing.Size(122, 51);
			this.btnGetLinearModuleLength.TabIndex = 4;
			this.btnGetLinearModuleLength.Text = "Get Linear Module Length";
			this.btnGetLinearModuleLength.UseVisualStyleBackColor = true;
			this.btnGetLinearModuleLength.Click += new global::System.EventHandler(this.btnGetLinearModuleLength_Click);
			this.spPort.BaudRate = 115200;
			this.spPort.DataReceived += new global::System.IO.Ports.SerialDataReceivedEventHandler(this.spPort_DataReceived);
			this.labPercent.AutoSize = true;
			this.labPercent.Location = new global::System.Drawing.Point(43, 122);
			this.labPercent.Name = "labPercent";
			this.labPercent.Size = new global::System.Drawing.Size(17, 12);
			this.labPercent.TabIndex = 0;
			this.labPercent.Text = "0%";
			this.button1.Location = new global::System.Drawing.Point(527, 161);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.btnContinue.Enabled = false;
			this.btnContinue.Location = new global::System.Drawing.Point(419, 89);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new global::System.Drawing.Size(77, 23);
			this.btnContinue.TabIndex = 18;
			this.btnContinue.Text = "Continue";
			this.btnContinue.UseVisualStyleBackColor = true;
			this.btnContinue.Click += new global::System.EventHandler(this.btnContinue_Click);
			this.btnAllHome.Location = new global::System.Drawing.Point(592, 17);
			this.btnAllHome.Name = "btnAllHome";
			this.btnAllHome.Size = new global::System.Drawing.Size(100, 44);
			this.btnAllHome.TabIndex = 14;
			this.btnAllHome.Text = "All Home";
			this.btnAllHome.UseVisualStyleBackColor = true;
			this.btnAllHome.Click += new global::System.EventHandler(this.btnAllHome_Click);
			this.btnSMCMaker.Location = new global::System.Drawing.Point(1115, 122);
			this.btnSMCMaker.Name = "btnSMCMaker";
			this.btnSMCMaker.Size = new global::System.Drawing.Size(85, 23);
			this.btnSMCMaker.TabIndex = 20;
			this.btnSMCMaker.Text = "SMC Maker";
			this.btnSMCMaker.UseVisualStyleBackColor = true;
			this.btnSMCMaker.Click += new global::System.EventHandler(this.btnSMCMaker_Click);
			this.btnFlush.Location = new global::System.Drawing.Point(355, 47);
			this.btnFlush.Name = "btnFlush";
			this.btnFlush.Size = new global::System.Drawing.Size(77, 23);
			this.btnFlush.TabIndex = 21;
			this.btnFlush.Text = "FlushBuffer";
			this.btnFlush.UseVisualStyleBackColor = true;
			this.btnFlush.Click += new global::System.EventHandler(this.btnFlush_Click);
			this.labPrinterStatus.AutoSize = true;
			this.labPrinterStatus.Location = new global::System.Drawing.Point(823, 177);
			this.labPrinterStatus.Name = "labPrinterStatus";
			this.labPrinterStatus.Size = new global::System.Drawing.Size(41, 12);
			this.labPrinterStatus.TabIndex = 22;
			this.labPrinterStatus.Text = "label3";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(992, 33);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(17, 12);
			this.label3.TabIndex = 23;
			this.label3.Text = "X:";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(992, 59);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(17, 12);
			this.label5.TabIndex = 24;
			this.label5.Text = "Y:";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(992, 89);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(17, 12);
			this.label6.TabIndex = 25;
			this.label6.Text = "Z:";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(992, 122);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(17, 12);
			this.label7.TabIndex = 26;
			this.label7.Text = "E:";
			this.labXPos.AutoSize = true;
			this.labXPos.Location = new global::System.Drawing.Point(1032, 33);
			this.labXPos.Name = "labXPos";
			this.labXPos.Size = new global::System.Drawing.Size(11, 12);
			this.labXPos.TabIndex = 27;
			this.labXPos.Text = "0";
			this.labYPos.AutoSize = true;
			this.labYPos.Location = new global::System.Drawing.Point(1032, 59);
			this.labYPos.Name = "labYPos";
			this.labYPos.Size = new global::System.Drawing.Size(11, 12);
			this.labYPos.TabIndex = 28;
			this.labYPos.Text = "0";
			this.labZPos.AutoSize = true;
			this.labZPos.Location = new global::System.Drawing.Point(1032, 89);
			this.labZPos.Name = "labZPos";
			this.labZPos.Size = new global::System.Drawing.Size(11, 12);
			this.labZPos.TabIndex = 29;
			this.labZPos.Text = "0";
			this.labEPos.AutoSize = true;
			this.labEPos.Location = new global::System.Drawing.Point(1032, 122);
			this.labEPos.Name = "labEPos";
			this.labEPos.Size = new global::System.Drawing.Size(11, 12);
			this.labEPos.TabIndex = 30;
			this.labEPos.Text = "0";
			this.labStatus.AutoSize = true;
			this.labStatus.Location = new global::System.Drawing.Point(1153, 89);
			this.labStatus.Name = "labStatus";
			this.labStatus.Size = new global::System.Drawing.Size(47, 12);
			this.labStatus.TabIndex = 32;
			this.labStatus.Text = "label10";
			this.labExecuter.AutoSize = true;
			this.labExecuter.Location = new global::System.Drawing.Point(992, 157);
			this.labExecuter.Name = "labExecuter";
			this.labExecuter.Size = new global::System.Drawing.Size(47, 12);
			this.labExecuter.TabIndex = 33;
			this.labExecuter.Text = "label10";
			this.cbAutoCheckStatus.AutoSize = true;
			this.cbAutoCheckStatus.Checked = true;
			this.cbAutoCheckStatus.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cbAutoCheckStatus.Location = new global::System.Drawing.Point(965, 203);
			this.cbAutoCheckStatus.Name = "cbAutoCheckStatus";
			this.cbAutoCheckStatus.Size = new global::System.Drawing.Size(96, 16);
			this.cbAutoCheckStatus.TabIndex = 34;
			this.cbAutoCheckStatus.Text = "Status Check";
			this.cbAutoCheckStatus.UseVisualStyleBackColor = true;
			this.cbAutoCheckStatus.CheckedChanged += new global::System.EventHandler(this.cbAutoCheckStatus_CheckedChanged);
			this.btnZUp.Location = new global::System.Drawing.Point(905, 23);
			this.btnZUp.Name = "btnZUp";
			this.btnZUp.Size = new global::System.Drawing.Size(49, 49);
			this.btnZUp.TabIndex = 35;
			this.btnZUp.Text = "Z+";
			this.btnZUp.UseVisualStyleBackColor = true;
			this.btnZUp.Click += new global::System.EventHandler(this.btnZUp_Click);
			this.btnZDown.Location = new global::System.Drawing.Point(905, 140);
			this.btnZDown.Name = "btnZDown";
			this.btnZDown.Size = new global::System.Drawing.Size(49, 49);
			this.btnZDown.TabIndex = 36;
			this.btnZDown.Text = "Z-";
			this.btnZDown.UseVisualStyleBackColor = true;
			this.btnZDown.Click += new global::System.EventHandler(this.btnZDown_Click);
			this.btnStop.Enabled = false;
			this.btnStop.Location = new global::System.Drawing.Point(525, 89);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(77, 23);
			this.btnStop.TabIndex = 37;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.button4.Location = new global::System.Drawing.Point(470, 52);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "button6";
			this.button4.UseVisualStyleBackColor = true;
			this.button5.Location = new global::System.Drawing.Point(93, 205);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(122, 51);
			this.button5.TabIndex = 3;
			this.button5.Text = "Get Update Status";
			this.button5.UseVisualStyleBackColor = true;
			this.button7.Location = new global::System.Drawing.Point(93, 116);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(122, 51);
			this.button7.TabIndex = 2;
			this.button7.Text = "Request Firmware Version";
			this.button7.UseVisualStyleBackColor = true;
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(291, 57);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(47, 12);
			this.label18.TabIndex = 1;
			this.label18.Text = "label16";
			this.button8.Location = new global::System.Drawing.Point(93, 38);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(122, 51);
			this.button8.TabIndex = 0;
			this.button8.Text = "Update";
			this.button8.UseVisualStyleBackColor = true;
			this.txtMoveSpeed.Location = new global::System.Drawing.Point(686, 161);
			this.txtMoveSpeed.Name = "txtMoveSpeed";
			this.txtMoveSpeed.Size = new global::System.Drawing.Size(49, 21);
			this.txtMoveSpeed.TabIndex = 38;
			this.txtMoveSpeed.Text = "3000";
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(623, 166);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(41, 12);
			this.label19.TabIndex = 39;
			this.label19.Text = "Speed:";
			this.btnClearGcodeIndex.Location = new global::System.Drawing.Point(449, 122);
			this.btnClearGcodeIndex.Name = "btnClearGcodeIndex";
			this.btnClearGcodeIndex.Size = new global::System.Drawing.Size(151, 23);
			this.btnClearGcodeIndex.TabIndex = 40;
			this.btnClearGcodeIndex.Text = "Clear GCode Index";
			this.btnClearGcodeIndex.UseVisualStyleBackColor = true;
			this.btnClearGcodeIndex.Click += new global::System.EventHandler(this.btnClearGcodeIndex_Click);
			this.btnOpenLog.Location = new global::System.Drawing.Point(461, 9);
			this.btnOpenLog.Name = "btnOpenLog";
			this.btnOpenLog.Size = new global::System.Drawing.Size(106, 23);
			this.btnOpenLog.TabIndex = 41;
			this.btnOpenLog.Text = "Open Log";
			this.btnOpenLog.UseVisualStyleBackColor = true;
			this.btnOpenLog.Click += new global::System.EventHandler(this.btnOpenLog_Click);
			this.picStatus.BackColor = global::System.Drawing.Color.Gray;
			this.picStatus.Location = new global::System.Drawing.Point(1153, 22);
			this.picStatus.Name = "picStatus";
			this.picStatus.Size = new global::System.Drawing.Size(47, 50);
			this.picStatus.TabIndex = 31;
			this.picStatus.TabStop = false;
			this.btnOpenFilter.Location = new global::System.Drawing.Point(461, 47);
			this.btnOpenFilter.Name = "btnOpenFilter";
			this.btnOpenFilter.Size = new global::System.Drawing.Size(106, 23);
			this.btnOpenFilter.TabIndex = 42;
			this.btnOpenFilter.Text = "Open Filter";
			this.btnOpenFilter.UseVisualStyleBackColor = true;
			this.btnOpenFilter.Click += new global::System.EventHandler(this.btnOpenFilter_Click);
			this.labBuffLines.AutoSize = true;
			this.labBuffLines.Location = new global::System.Drawing.Point(47, 193);
			this.labBuffLines.Name = "labBuffLines";
			this.labBuffLines.Size = new global::System.Drawing.Size(47, 12);
			this.labBuffLines.TabIndex = 43;
			this.labBuffLines.Text = "label24";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new global::System.Drawing.Point(293, 73);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(200, 148);
			this.listBox1.TabIndex = 6;
			this.button9.Location = new global::System.Drawing.Point(100, 169);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(122, 51);
			this.button9.TabIndex = 5;
			this.button9.Text = "Get Linear Module Lead";
			this.button9.UseVisualStyleBackColor = true;
			this.button10.Location = new global::System.Drawing.Point(100, 73);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(122, 51);
			this.button10.TabIndex = 4;
			this.button10.Text = "Get Linear Module Length";
			this.button10.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1231, 594);
			base.Controls.Add(this.labBuffLines);
			base.Controls.Add(this.btnOpenFilter);
			base.Controls.Add(this.btnOpenLog);
			base.Controls.Add(this.btnClearGcodeIndex);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.txtMoveSpeed);
			base.Controls.Add(this.btnStop);
			base.Controls.Add(this.btnZDown);
			base.Controls.Add(this.btnZUp);
			base.Controls.Add(this.cbAutoCheckStatus);
			base.Controls.Add(this.labExecuter);
			base.Controls.Add(this.labStatus);
			base.Controls.Add(this.picStatus);
			base.Controls.Add(this.labEPos);
			base.Controls.Add(this.labZPos);
			base.Controls.Add(this.labYPos);
			base.Controls.Add(this.labXPos);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.labPrinterStatus);
			base.Controls.Add(this.btnFlush);
			base.Controls.Add(this.btnSMCMaker);
			base.Controls.Add(this.btnAllHome);
			base.Controls.Add(this.btnContinue);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.labPercent);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.btnStartPrint);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.btnPause);
			base.Controls.Add(this.labFileName);
			base.Controls.Add(this.cmdMoveAxisDis);
			base.Controls.Add(this.btnOpenFile);
			base.Controls.Add(this.btnRight);
			base.Controls.Add(this.btnLeft);
			base.Controls.Add(this.btnDown);
			base.Controls.Add(this.btnUp);
			base.Controls.Add(this.btnOpen);
			base.Controls.Add(this.btnSearchPort);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cmbPorts);
			base.Name = "Form1";
			this.Text = "Com";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbBedTamp).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tbHeadTamp).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picSpeical).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbLaserPower).EndInit();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbRPM).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage9.PerformLayout();
			this.tabPage10.ResumeLayout(false);
			this.tabPage10.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picboxBTImage).EndInit();
			this.tabPage11.ResumeLayout(false);
			this.tabPage11.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbLightBrightness).EndInit();
			this.tabPage12.ResumeLayout(false);
			this.tabPage12.PerformLayout();
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picStatus).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000071 RID: 113
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ComboBox cmbPorts;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Button btnSearchPort;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Button btnOpen;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Button btnUp;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Button btnDown;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Button btnLeft;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Button btnRight;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Button btnOpenFile;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.ComboBox cmdMoveAxisDis;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label labFileName;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button btnPause;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Button btnStartPrint;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000083 RID: 131
		private global::System.IO.Ports.SerialPort spPort;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label labPercent;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Button btnContinue;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label labTampHeater0;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label labPrintFileName;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.ListBox lstDirList;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Button btnGetFileList;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.ListBox lstFiles;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Button btnOpenDirectory;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label labTampBed;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Button btnCaliHome;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ComboBox cmbCaliZDis;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Button btnCaliZDown;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Button btnCaliZUp;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Button btnPoint2;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Button btnPoint3;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Button btnPoint4;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Button btnPoint1;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Button btnZAutoCalibrate;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Button btnCaliReset;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Button btnCaliBack;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Button btnCaliSave;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Button btnOpenUDisk;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Button btnGetCurPath;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label labCurrentPath;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Button btnAllHome;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Button btnSMCMaker;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.PictureBox picSpeical;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Button btnGetSpecialContent;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.ListBox lstSpecialContents;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Button btnUDiskPrint;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.TrackBar tbHeadTamp;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Label labHeadSetTamp;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Label labBedSetTamp;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.TrackBar tbBedTamp;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Button btnFlush;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Button btnPowerPanicContinue;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Label labPrinterStatus;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Button btnExtrude;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label labXPos;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Label labYPos;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label labZPos;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label labEPos;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.PictureBox picStatus;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label labStatus;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Label labExecuter;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Button btnGetPowerPanicData;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.CheckBox cbAutoCheckStatus;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label labLaserPower;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.TrackBar tbLaserPower;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Button btnSetFocusHigh;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Button btnSetOriginal;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Button btnLaserEnterSetFocus;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Button btnZUp;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Button btnZDown;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.TabPage tabPage7;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label labRPM;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Label labTargetRPM;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.TrackBar tbRPM;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.Button btnReExtrude;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Button btnPoint9;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Button btnPoint8;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Button btnPoint7;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Button btnPoint6;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Button btnPoint5;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.TabPage tabPage8;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Button btnSetSize;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.TextBox txtZSize;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.TextBox txtYSize;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.TextBox txtXSize;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button btnReleaeButton;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.CheckBox cbZDir;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.CheckBox cbYDir;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.CheckBox cbXDir;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.CheckBox cbZHomeDir;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.CheckBox cbYHomeDir;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.CheckBox cbXHomeDir;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.TextBox txtZOffset;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.TextBox txtYOffset;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.TextBox txtXOffset;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Button btnGetSize;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.RadioButton rbSizeL;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.RadioButton rbSizeM;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.RadioButton rbSizeS;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.TextBox txtLaserFocusHeight;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Button btnGetFocus;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Button btnEnableFilamentSensor;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.Button btnDisableFilamentSensor;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.Button btnCheckFault;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.Button btnClearFault;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.Button btnAuto;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.TextBox txtM220;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Button btnSetFeedRateMultiplier;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.Button btnFanOff;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Button btnFanOn;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.Button btnLaserFocusOn;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.Button btnLaserFocusOff;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.Button btnZOriginal;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.Button btnLaserZHome;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.TabPage tabPage9;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Button btnUpdate;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.Label labUpdateProgress;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.TabPage tabPage10;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Button btnGetCameraIP;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Button btnSetWifiParameter;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.TextBox txtSSID;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.Label labCameraIP;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Button btnRequestFirmwareVersion;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.Button btnGetUpdateStatus;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.CheckBox EnterUpdate;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Button btnFan2Off;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.Button btnFan1Off;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.Button btnFan2On;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.Button btnFan1On;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.TabPage tabPage11;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.TrackBar tbLightBrightness;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.CheckBox cbLightOnoff;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.Button btnGetLightStatus;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.RadioButton rbLightNormal;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.RadioButton rbLigthStatus;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.TextBox txtMovementZ;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.TextBox txtMovementY;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.TextBox txtMovementX;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.Button btnMovementRequire;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.CheckBox cbMovementRelative;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.TextBox txtFocusZ;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.TextBox txtFocusY;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.TextBox txtFocusX;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.Button btnDrawLaserCalibration;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.Button btnOpenOriginFile;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.RadioButton rbModuleType;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.RadioButton rbControler;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.CheckBox cbForceUpdate;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.TextBox txtMoveSpeed;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.TextBox txtExtrudeSpeed;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.TextBox txtExtrudeLength;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.Button btnCNCSetOrigin;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.Button btnClearGcodeIndex;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.Button btnOpenLog;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.Button btnDrawRuler;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Button btnOpenFilter;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.Button btnRequestModuleFirmwareVersion;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.ListBox lstModuleVersions;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.Label labCurrentLaserPercent;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.Button btnTrigglePowerPanic;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.TabPage tabPage12;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.Button btnRunCustomGcode;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.Button btnLoadCustomGcodeFile;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.RichTextBox rtbCustomFile;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.TextBox txtCustomeRepeat;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.Label labBuffLines;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.TabPage tabPage13;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.ListBox lstModuleInfo;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.Button btnGetLinearModuleLead;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.Button btnGetLinearModuleLength;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.Button btnSetMacID;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.Button button10;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.TextBox txtNewMacID;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.TextBox txtOldMacID;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.Button btnSetLinearModuleLead;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.Button btnSetLinearModuleLength;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.TextBox txtNewLead;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.TextBox txtNewLength;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.Button button12;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Button button11;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.Button btnOpenBTPort;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.Button btnSerialBTPort;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.ComboBox cmbBTPort;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.PictureBox picboxBTImage;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.Button btnBTImage;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.Label labBTPortStatus;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.Button btnBTUpdate;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.TextBox txtBTName;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.Button btnSetBTName;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.Button btnBTSetName;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.Label labBTUpdateProgress;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.Button btnBTGetName;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.Button btnSendTestData;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.Button btnGetBTMac;
	}
}
