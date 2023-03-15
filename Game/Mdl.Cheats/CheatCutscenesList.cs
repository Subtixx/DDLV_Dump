using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200083E")]
	public class CheatCutscenesList : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E07")]
		[SerializeField]
		public List<CheatCutsceneItem> cutscenePaths = (List<CheatCutsceneItem>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6002529")]
		[Cpp2IlInjected.Address(RVA = "0xA7C430", Offset = "0xA7AE30", VA = "0x180A7C430")]
		public CheatCutscenesList()
		{
		}
	}
}
