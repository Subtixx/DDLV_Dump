using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class FluxReviewedTableProvider : ITableProvider
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class StringTable : IStringTable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private FluxTableProvider.StringTable reviewedTable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private FluxTableProvider.StringTable referenceTable;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003CName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public TableOptions Options
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003COptions_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				private set
				{
					_003COptions_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IEnumerable<KeyValuePair<string, string>> Strings
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x4090CF0", Offset = "0x408F6F0", VA = "0x184090CF0", Slot = "5")]
				[IteratorStateMachine(typeof(_003Cget_Strings_003Ed__11))]
				get
				{
					//IL_0012: Expected I4, but got I8
					int num = 0;
					_003Cget_Strings_003Ed__11 _003Cget_Strings_003Ed__ = default(_003Cget_Strings_003Ed__11);
					_003Cget_Strings_003Ed__._003C_003E1__state = -2;
					int currentManagedThreadId = Environment.CurrentManagedThreadId;
					_003Cget_Strings_003Ed__._003C_003E4__this = this;
					_003Cget_Strings_003Ed__._003C_003El__initialThreadId = currentManagedThreadId;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x40909F0", Offset = "0x408F3F0", VA = "0x1840909F0", Slot = "6")]
			public unsafe bool TryGetValue(string key, out string value)
			{
				//IL_005c: Expected O, but got I4
				//IL_005c: Expected O, but got I4
				//IL_006c: Expected O, but got I4
				//IL_006c: Expected O, but got Ref
				FluxTableProvider.StringTable stringTable = reviewedTable;
				int num = 0;
				if (!((Dictionary<TKey, TValue>)(object)stringTable.Strings).TryGetValue((TKey)key, out *(TValue*)num))
				{
				}
				TableOptions tableOptions = Options;
				if ((tableOptions.IgnoreEmptyRev ? 1 : 0) == num)
				{
				}
				bool flag = tableOptions == null;
				bool flag2 = ((Dictionary<TKey, TValue>)(object)referenceTable.Strings).TryGetValue((TKey)key, out *(TValue*)num);
				if (flag != flag2 && ((Options.BypassTimestampCheck ? 1 : 0) != num || (DateTime)num >= (DateTime)num))
				{
					return true;
				}
				if (num != 0)
				{
				}
				string text = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value) + (string)num;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4090BD0", Offset = "0x408F5D0", VA = "0x184090BD0")]
			public StringTable(string name, FluxTableProvider.StringTable reviewedTable, FluxTableProvider.StringTable referenceTable, TableOptions options)
			{
				//IL_0022: Expected O, but got I4
				Name = name;
				this.reviewedTable = reviewedTable;
				this.referenceTable = referenceTable;
				Options = (TableOptions)0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FluxTableProvider provider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TableOptions options;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000009")]
		public Func<string, string> ReferenceTableNameResolver
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400000A")]
		public Func<string, string> ReviewedTableNameResolver
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CultureInfo ReferenceCulture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CReferenceCulture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CReferenceCulture_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x408BD50", Offset = "0x408A750", VA = "0x18408BD50")]
		public FluxReviewedTableProvider(FluxTableProvider provider, [Optional] TableOptions options)
		{
			Func<string, string> _003C_003E9__15_ = _003C_003Ec._003C_003E9__15_0;
			if (_003C_003E9__15_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string name) => name);
			}
			ReferenceTableNameResolver = _003C_003E9__15_;
			Func<string, string> func = default(Func<string, string>);
			if (_003C_003Ec._003C_003E9__15_1 == null)
			{
				func = (Func<string, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string name) => name + "_rev"));
			}
			ReviewedTableNameResolver = func;
			ReferenceCulture = CultureInfo.GetCultureInfo("en");
			base._002Ector();
			this.provider = provider;
			TableOptions tableOptions = default(TableOptions);
			if (options == null)
			{
				tableOptions.RefPrefix = "";
				tableOptions.BypassTimestampCheck = false;
			}
			this.options = tableOptions;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x408BA10", Offset = "0x408A410", VA = "0x18408BA10", Slot = "4")]
		IStringTable ITableProvider.GetTable(string tableName, CultureInfo culture)
		{
			string tableName2 = (string)ReferenceTableNameResolver((T)tableName);
			string tableName3 = (string)ReviewedTableNameResolver((T)tableName);
			FluxTableProvider fluxTableProvider = provider;
			CultureInfo culture2 = ReferenceCulture;
			FluxTableProvider.StringTable table = fluxTableProvider.GetTable(tableName2, culture2);
			FluxTableProvider.StringTable table2 = provider.GetTable(tableName3, culture);
			TableOptions _003COptions_003Ek__BackingField = options;
			StringTable stringTable = default(StringTable);
			stringTable.Name = tableName;
			stringTable.reviewedTable = table2;
			stringTable.referenceTable = table;
			stringTable.Options = _003COptions_003Ek__BackingField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x408BC20", Offset = "0x408A620", VA = "0x18408BC20", Slot = "5")]
		void ITableProvider.SetJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category, bool forceChangeDate)
		{
			//Discarded unreachable code: IL_0016
			FluxTableProvider fluxTableProvider = provider;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x408B5C0", Offset = "0x4089FC0", VA = "0x18408B5C0", Slot = "6")]
		void ITableProvider.AddJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category)
		{
			//Discarded unreachable code: IL_0016
			FluxTableProvider fluxTableProvider = provider;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x408BB50", Offset = "0x408A550", VA = "0x18408BB50", Slot = "7")]
		void ITableProvider.RemoveJsonValue(LocId locId, CultureInfo culture)
		{
			//Discarded unreachable code: IL_0016
			FluxTableProvider fluxTableProvider = provider;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x408B6E0", Offset = "0x408A0E0", VA = "0x18408B6E0", Slot = "8")]
		List<string> ITableProvider.GetJsonFileNames()
		{
			//Discarded unreachable code: IL_0057
			FluxTableProvider fluxTableProvider = provider;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			Func<string, string> func = (Func<string, string>)(object)(Func<T, TResult>)((string x) => (string)ReviewedTableNameResolver((T)x));
			IEnumerable<string> enumerable = default(IEnumerable<string>);
			HashSet<string> reviewedTablesAndMore = (HashSet<string>)(object)new HashSet<T>((IEqualityComparer<>)enumerable);
			Func<string, bool> func2 = (Func<string, bool>)(object)(Func<T, TResult>)((string x) => !((HashSet<T>)(object)reviewedTablesAndMore).Contains((T)x));
			IEnumerable<string> enumerable2 = default(IEnumerable<string>);
			return (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)enumerable2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x408B940", Offset = "0x408A340", VA = "0x18408B940", Slot = "9")]
		List<string> ITableProvider.GetJsonLocIds(string tableName, CultureInfo culture)
		{
			FluxTableProvider fluxTableProvider = provider;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			throw new NullReferenceException();
		}
	}
}
