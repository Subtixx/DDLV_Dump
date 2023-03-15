using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A54")]
	public class HiddenAvatarPart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003925")]
		[HideInInspector]
		public int name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003926")]
		[HideInInspector]
		public int bodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003927")]
		[HideInInspector]
		public int section;

		[Cpp2IlInjected.Token(Token = "0x6003024")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public HiddenAvatarPart()
		{
		}
	}
}
