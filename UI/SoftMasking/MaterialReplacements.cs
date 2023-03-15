using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	internal class MaterialReplacements
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private class MaterialOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			private int _useCount;

			[Cpp2IlInjected.Token(Token = "0x1700019B")]
			public Material original
			{
				[Cpp2IlInjected.Token(Token = "0x60006F4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003Coriginal_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60006F5")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				private set
				{
					_003Coriginal_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700019C")]
			public Material replacement
			{
				[Cpp2IlInjected.Token(Token = "0x60006F6")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003Creplacement_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60006F7")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003Creplacement_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xAFD220", Offset = "0xAFBC20", VA = "0x180AFD220")]
			public MaterialOverride(Material original, Material replacement)
			{
				//IL_001d: Expected I4, but got I8
				this.original = original;
				this.replacement = replacement;
				_useCount = 1;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xAFD200", Offset = "0xAFBC00", VA = "0x180AFD200")]
			public Material Get()
			{
				return replacement;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xAFD210", Offset = "0xAFBC10", VA = "0x180AFD210")]
			public bool Release()
			{
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly IMaterialReplacer _replacer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private readonly Action<Material> _applyParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private readonly List<MaterialOverride> _overrides = (List<MaterialOverride>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x118B580", Offset = "0x1189F80", VA = "0x18118B580")]
		public MaterialReplacements(IMaterialReplacer replacer, Action<Material> applyParameters)
		{
			_replacer = replacer;
			_applyParameters = applyParameters;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x118B1E0", Offset = "0x1189BE0", VA = "0x18118B1E0")]
		public Material Get(Material original)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x118B420", Offset = "0x1189E20", VA = "0x18118B420")]
		public void Release(Material replacement)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x118AFB0", Offset = "0x11899B0", VA = "0x18118AFB0")]
		public void ApplyAll()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x118B0D0", Offset = "0x1189AD0", VA = "0x18118B0D0")]
		public void DestroyAllAndClear()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
