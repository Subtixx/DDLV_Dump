using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20008A0")]
	public class TweenDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003303")]
		[HideInInspector]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003304")]
		public GameObject Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003305")]
		public float Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003306")]
		public eEaseType Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4003307")]
		public bool IsBackward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003308")]
		public TweenParam[] Params;

		[Cpp2IlInjected.Token(Token = "0x6003638")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TweenDefinition()
		{
		}
	}
}
