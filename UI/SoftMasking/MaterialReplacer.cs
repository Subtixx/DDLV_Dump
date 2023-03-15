using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using SoftMasking.TextMeshPro;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public static class MaterialReplacer
	{
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private static readonly List<IMaterialReplacer> _globalReplacers;

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public static IEnumerable<IMaterialReplacer> globalReplacers
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x118BDA0", Offset = "0x118A7A0", VA = "0x18118BDA0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x118BCD0", Offset = "0x118A6D0", VA = "0x18118BCD0")]
		static MaterialReplacer()
		{
			List<IMaterialReplacer> list = (List<IMaterialReplacer>)(object)new List<T>();
			SoftMasking.TextMeshPro.MaterialReplacer item = new SoftMasking.TextMeshPro.MaterialReplacer();
			((List<T>)(object)list).Add((T)item);
			throw new NullReferenceException();
		}
	}
}
