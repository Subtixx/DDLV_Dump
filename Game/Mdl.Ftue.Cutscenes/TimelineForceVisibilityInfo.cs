using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005D8")]
	public class TimelineForceVisibilityInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023C8")]
		public string forceVisibilityID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C9")]
		[ItemID]
		[SerializeField]
		public int characterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023CA")]
		public bool forceVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x40023CB")]
		public bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x40023CC")]
		public bool triggerRequired = true;

		[Cpp2IlInjected.Token(Token = "0x6001A01")]
		[Cpp2IlInjected.Address(RVA = "0x13CE770", Offset = "0x13CD170", VA = "0x1813CE770")]
		public TimelineForceVisibilityInfo()
		{
		}
	}
}
