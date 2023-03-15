using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000AD9")]
	public class ActionItemSwitchEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C23")]
		[ItemID]
		[SerializeField]
		public int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C24")]
		public Switch switch_obj;

		[Cpp2IlInjected.Token(Token = "0x60031FC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ActionItemSwitchEntry()
		{
		}
	}
}
