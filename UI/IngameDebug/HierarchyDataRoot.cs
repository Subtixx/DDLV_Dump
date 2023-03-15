using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public abstract class HierarchyDataRoot : HierarchyData
	{
		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public override Transform BoundTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public override bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "5")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public RuntimeHierarchy Hierarchy
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CHierarchy_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CHierarchy_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xAE4330", Offset = "0xAE2D30", VA = "0x180AE4330")]
		protected HierarchyDataRoot(RuntimeHierarchy hierarchy)
		{
			//IL_0009: Expected I4, but got I8
			m_height = 1;
			((object)this)._002Ector();
			Hierarchy = hierarchy;
			PopChildrenList();
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void RefreshContent();

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xAE4250", Offset = "0xAE2C50", VA = "0x180AE4250", Slot = "8")]
		public override bool Refresh()
		{
			RefreshContent();
			return base.Refresh();
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xAE4280", Offset = "0xAE2C80", VA = "0x180AE4280")]
		public void ResetCachedNames()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xAE4190", Offset = "0xAE2B90", VA = "0x180AE4190")]
		public void RefreshNameOf(Transform target)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
