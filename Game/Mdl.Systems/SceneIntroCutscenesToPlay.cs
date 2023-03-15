using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Systems
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000953")]
	public class SceneIntroCutscenesToPlay
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40033C0")]
		[ItemID]
		public int introCutsceneEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40033C1")]
		[SerializeField]
		[ItemID]
		public int sceneID;

		[Cpp2IlInjected.Token(Token = "0x6002B1B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SceneIntroCutscenesToPlay()
		{
		}
	}
}
