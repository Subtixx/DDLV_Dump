using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000210")]
	[CreateAssetMenu]
	public class ShortcutSetDefinition : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400091D")]
		public RuntimePlatform Platform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400091E")]
		[HideInInspector]
		public int RewiredMapCategoryId = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400091F")]
		public List<ShortcutDefinition> Shortcuts;

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0x15F0150", Offset = "0x15EEB50", VA = "0x1815F0150")]
		public ShortcutSetDefinition()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
