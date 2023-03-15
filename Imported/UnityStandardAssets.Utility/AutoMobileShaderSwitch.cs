using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public class ReplacementDefinition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public Shader original;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Shader replacement;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public class ReplacementList
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public ReplacementDefinition[] items = new ReplacementDefinition[0];

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3DC0C50", Offset = "0x3DBF650", VA = "0x183DC0C50")]
			public ReplacementList()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnEnable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AutoMobileShaderSwitch()
		{
		}
	}
}
