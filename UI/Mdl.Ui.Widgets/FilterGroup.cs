using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000986")]
	public class FilterGroup : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003852")]
		public readonly FilterUtil.FilterCombineMode CombineMode;

		[Cpp2IlInjected.Token(Token = "0x17000826")]
		public HashSet<Filter> Filters
		{
			[Cpp2IlInjected.Token(Token = "0x6003BDD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BDE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000827")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003BDF")]
			[Cpp2IlInjected.Address(RVA = "0x1068830", Offset = "0x1067230", VA = "0x181068830", Slot = "5")]
			get
			{
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000828")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE0")]
			[Cpp2IlInjected.Address(RVA = "0x1533200", Offset = "0x1531C00", VA = "0x181533200", Slot = "6")]
			get
			{
				return "FilterGroup";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000829")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE1")]
			[Cpp2IlInjected.Address(RVA = "0x15331D0", Offset = "0x1531BD0", VA = "0x1815331D0", Slot = "7")]
			get
			{
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082A")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE2")]
			[Cpp2IlInjected.Address(RVA = "0x12EC580", Offset = "0x12EAF80", VA = "0x1812EC580", Slot = "8")]
			get
			{
				Color white = Color.white;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BE3")]
		[Cpp2IlInjected.Address(RVA = "0x1533180", Offset = "0x1531B80", VA = "0x181533180")]
		public FilterGroup(HashSet<Filter> filters, FilterUtil.FilterCombineMode combineMode)
		{
			Filters = filters;
			CombineMode = combineMode;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BE4")]
		[Cpp2IlInjected.Address(RVA = "0x1532F20", Offset = "0x1531920", VA = "0x181532F20", Slot = "10")]
		public override bool Equals(Filter other)
		{
			if ((object)other != null)
			{
				int num = 0;
				if ((object)other != null)
				{
					HashSet<Filter> hashSet = Filters;
					bool result = default(bool);
					return result;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BE5")]
		[Cpp2IlInjected.Address(RVA = "0x1532FD0", Offset = "0x15319D0", VA = "0x181532FD0", Slot = "9")]
		public override bool Retains(object item)
		{
			//Discarded unreachable code: IL_0026, IL_002c
			int num = 0;
			int num2 = 0;
			HashSet<Filter> hashSet = Filters;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			int num3 = 0;
			return true;
		}
	}
}
