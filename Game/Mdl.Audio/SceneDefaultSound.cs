using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B09")]
	public class SceneDefaultSound
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D6B")]
		[SerializeField]
		[ItemID]
		public int sceneID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D6C")]
		public Switch eventType;

		[Cpp2IlInjected.Token(Token = "0x60032EF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SceneDefaultSound()
		{
		}
	}
}
