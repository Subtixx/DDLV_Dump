using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Graphic;

namespace Mdl.Systems
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000964")]
	public class SceneComplexityNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003412")]
		public LevelComplexityEnum complexityLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003413")]
		public List<string> scenes;

		[Cpp2IlInjected.Token(Token = "0x6002BA3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SceneComplexityNode()
		{
		}
	}
}
