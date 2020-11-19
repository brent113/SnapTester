using System;
using System.Threading;

namespace SnapTester
{
	// Token: 0x0200001F RID: 31
	public class Signal
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00012E5C File Offset: 0x0001105C
		public Signal()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00012E72 File Offset: 0x00011072
		public Signal(byte InitCount, byte Max)
		{
			this.Count = InitCount;
			this.MaxCount = Max;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00012E98 File Offset: 0x00011098
		public void Post()
		{
			this.count_add.WaitOne();
			if (this.Count < this.MaxCount)
			{
				this.Count += 1;
			}
			this.count_add.ReleaseMutex();
			Thread.Sleep(100);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00012EEC File Offset: 0x000110EC
		public bool Wait(int millissecondsTimeout)
		{
			int timecounter = 0;
			while (this.Count == 0)
			{
				if (timecounter++ > millissecondsTimeout)
				{
					return false;
				}
				this.count_add.WaitOne();
				Thread.Sleep(1);
				this.count_add.ReleaseMutex();
			}
			return true;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00012F44 File Offset: 0x00011144
		public void Reset()
		{
			this.Count = 0;
		}

		// Token: 0x04000169 RID: 361
		private byte Count;

		// Token: 0x0400016A RID: 362
		private byte MaxCount;

		// Token: 0x0400016B RID: 363
		private Mutex count_add = new Mutex();
	}
}
