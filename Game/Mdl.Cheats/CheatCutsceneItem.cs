using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Cheats
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200083D")]
	public class CheatCutsceneItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E04")]
		[ItemID]
		[SerializeField]
		public int sceneId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E05")]
		public string cutsceneId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E06")]
		public AssetReference cutsceneRef;

		[Cpp2IlInjected.Token(Token = "0x6002528")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CheatCutsceneItem()
		{
		}
	}
}
