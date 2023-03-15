using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B0A")]
	public class FootStepEnumEntryObj
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D6D")]
		[SerializeField]
		[ItemID]
		public int itemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D6E")]
		public Switch eventType;

		[Cpp2IlInjected.Token(Token = "0x60032F0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FootStepEnumEntryObj()
		{
		}
	}
}
