using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200098B")]
	public class ExtraFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400385F")]
		public Sprite filterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003860")]
		public Sprite filterBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003861")]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003862")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003863")]
		private int _index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003864")]
		private Color _color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003865")]
		private List<DynamicFilterItemData> _subFilters;

		[Cpp2IlInjected.Token(Token = "0x1700083F")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003C06")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "5")]
			get
			{
				return _index;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000840")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003C07")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "6")]
			get
			{
				return _name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000841")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C08")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "7")]
			get
			{
				return _displayName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000842")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003C09")]
			[Cpp2IlInjected.Address(RVA = "0x15216D0", Offset = "0x15200D0", VA = "0x1815216D0", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000843")]
		public List<DynamicFilterItemData> SubFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6003C0A")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _subFilters;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C0B")]
		[Cpp2IlInjected.Address(RVA = "0x1521630", Offset = "0x1520030", VA = "0x181521630")]
		public unsafe ExtraFilter(string name, string displayName, Color color, [Optional] Sprite icon, [Optional] Sprite background, int index = 0, [Optional] List<DynamicFilterItemData> subFilters)
		{
			//IL_000b: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			//IL_0019: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int num = 0;
			((object)this).FieldGetter((string)num, displayName, ref *(object*)color);
			filterIcon = (Sprite)0;
			filterBackground = (Sprite)0;
			_name = name;
			_displayName = displayName;
			_index = 0;
			_subFilters = (List<DynamicFilterItemData>)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C0C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "9")]
		public override bool Retains(object item)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C0D")]
		[Cpp2IlInjected.Address(RVA = "0x1521570", Offset = "0x151FF70", VA = "0x181521570", Slot = "10")]
		public override bool Equals(Filter other)
		{
			if ((object)other != null)
			{
				int num = 0;
				if ((object)other != null)
				{
					string name = other.Name;
					string name2 = Name;
					return string.Equals(name, name2);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
