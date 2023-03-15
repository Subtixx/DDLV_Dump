using System;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	public class ShortcutParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000907")]
		public float[] Floats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000908")]
		public string[] Strings;

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ShortcutParam()
		{
		}
	}
}
