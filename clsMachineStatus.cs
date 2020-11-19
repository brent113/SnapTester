using System;

namespace SnapTester
{
	// Token: 0x0200000C RID: 12
	public class clsMachineStatus
	{
		// Token: 0x04000019 RID: 25
		public double[] Pos = new double[4];

		// Token: 0x0400001A RID: 26
		public byte PrintingStatus;

		// Token: 0x0400001B RID: 27
		public uint PeriphStatus;

		// Token: 0x0400001C RID: 28
		public uint FaultStatus;

		// Token: 0x0400001D RID: 29
		public byte Executer;

		// Token: 0x0400001E RID: 30
		public int Heater0Tamp;

		// Token: 0x0400001F RID: 31
		public int Heater0Target;

		// Token: 0x04000020 RID: 32
		public int HeatedBedTamp;

		// Token: 0x04000021 RID: 33
		public int HeaterBedTarget;

		// Token: 0x04000022 RID: 34
		public int CNCRpm;

		// Token: 0x04000023 RID: 35
		public byte Percent;
	}
}
