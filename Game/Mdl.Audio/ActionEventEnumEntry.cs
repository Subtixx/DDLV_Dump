using System;
using AK.Wwise;
using Cpp2IlInjected;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000AD8")]
	public class ActionEventEnumEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C21")]
		public string event_name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C22")]
		public Event event_obj;

		[Cpp2IlInjected.Token(Token = "0x60031FB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ActionEventEnumEntry()
		{
		}
	}
}
