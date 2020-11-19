using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SnapTester
{
	// Token: 0x02000023 RID: 35
	public class MessageList
	{
		// Token: 0x06000111 RID: 273 RVA: 0x000134C8 File Offset: 0x000116C8
		public string GetMessage(byte EvID, byte code)
		{
			if (this.Messages.Count > 0)
			{
				int ID = (int)EvID << 8 | (int)code;
				for (int i = 0; i < this.Messages.Count; i++)
				{
					if (this.Messages[i].ID == ID)
					{
						return this.Messages[i].Message;
					}
				}
			}
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00013544 File Offset: 0x00011744
		public int LoadMessageFromFile(string FileName)
		{
			StreamReader SR = new StreamReader(new FileStream(FileName, FileMode.Open));
			for (;;)
			{
				string tmpLine = SR.ReadLine();
				if (tmpLine == null)
				{
					break;
				}
				string[] tmpStr = tmpLine.Split(new char[]
				{
					','
				});
				if (tmpStr.Count<string>() == 3)
				{
					string strEventID = tmpStr[0];
					string strOpcode = tmpStr[1];
					string strMessage = tmpStr[2];
					try
					{
						byte bEvID = byte.Parse(strEventID);
						byte bOpCode = byte.Parse(strOpcode);
						int tmpID = (int)bEvID << 8 | (int)bOpCode;
						MessageInfo tmpmsg = new MessageInfo();
						tmpmsg.ID = tmpID;
						tmpmsg.Message = strMessage;
						this.Messages.Add(tmpmsg);
					}
					catch
					{
					}
				}
			}
			SR.Close();
			return this.Messages.Count;
		}

		// Token: 0x04000173 RID: 371
		private List<MessageInfo> Messages = new List<MessageInfo>();

		// Token: 0x04000174 RID: 372
		public byte EventID;

		// Token: 0x04000175 RID: 373
		public byte Opcode;
	}
}
