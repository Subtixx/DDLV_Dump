using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200096D")]
	[CreateAssetMenu]
	public class ColorPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037F9")]
		public Texture2D inputTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037FA")]
		public int columns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40037FB")]
		public int rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037FC")]
		public List<Color> colors = (List<Color>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003B51")]
		[Cpp2IlInjected.Address(RVA = "0x1150980", Offset = "0x114F380", VA = "0x181150980")]
		public ColorPalette()
		{
		}
	}
}
