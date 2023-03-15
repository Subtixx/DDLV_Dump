using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005D7")]
	public class TimelineFlag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023C4")]
		public string flagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C5")]
		[SerializeField]
		[ItemID]
		public int flag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023C6")]
		public bool setFlag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x40023C7")]
		public bool triggerRequired = true;

		[Cpp2IlInjected.Token(Token = "0x6001A00")]
		[Cpp2IlInjected.Address(RVA = "0x13CE760", Offset = "0x13CD160", VA = "0x1813CE760")]
		public TimelineFlag()
		{
		}
	}
}
