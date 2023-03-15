using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000979")]
	public struct DynamicSubTabData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400381D")]
		public string tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400381E")]
		public Sprite selectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400381F")]
		public Sprite unselectedIcon;
	}
}
