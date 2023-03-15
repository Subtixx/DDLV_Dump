using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public class MaterialReplacerChain : IMaterialReplacer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly List<IMaterialReplacer> _replacers;

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40004ED")]
		public int order
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x118B8F0", Offset = "0x118A2F0", VA = "0x18118B8F0")]
		public MaterialReplacerChain(IEnumerable<IMaterialReplacer> replacers, IMaterialReplacer yetAnother)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x118B7C0", Offset = "0x118A1C0", VA = "0x18118B7C0", Slot = "5")]
		public Material Replace(Material material)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x118B630", Offset = "0x118A030", VA = "0x18118B630")]
		private void Initialize()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
