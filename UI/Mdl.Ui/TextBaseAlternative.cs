using System;
using Cpp2IlInjected;
using StoreFrontEnums;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	public struct TextBaseAlternative
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400089C")]
		[Header("Filters")]
		public RuntimePlatform[] Platforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400089D")]
		public PlayfabOriginId[] Stores;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400089E")]
		[Header("Text Variant")]
		public string StringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400089F")]
		public string Text;
	}
}
