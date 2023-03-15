using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Cache
{
	[Cpp2IlInjected.Token(Token = "0x2000963")]
	public class AtlassedIcon
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40037D1")]
		public int slot = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037D2")]
		public Texture texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037D3")]
		public Rect uvRect;

		[Cpp2IlInjected.Token(Token = "0x6003B23")]
		[Cpp2IlInjected.Address(RVA = "0x882570", Offset = "0x880F70", VA = "0x180882570")]
		public AtlassedIcon()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
