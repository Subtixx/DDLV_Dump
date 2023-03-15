using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class Localizator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private List<IResolver> generalResolvers;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000033")]
		private CultureInfo Culture
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000034")]
		private ITableProvider TableProvider
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000035")]
		private Func<LocId, LocId> RedirectionCallback
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000036")]
		private Func<LocId, string, string> FormatCallback
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000037")]
		private Dictionary<string, IStringTable> StringTables
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MultiResolver GeneralResolver
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CGeneralResolver_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CGeneralResolver_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x408FCA0", Offset = "0x408E6A0", VA = "0x18408FCA0")]
		public Localizator(string culture, ITableProvider tableProvider, [Optional] Func<LocId, LocId> redirectionCallback, [Optional] Func<LocId, string, string> formatCallback)
		{
			//IL_0036: Expected O, but got I4
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(culture);
			StringTables = (Dictionary<string, IStringTable>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			Culture = cultureInfo;
			TableProvider = tableProvider;
			RedirectionCallback = redirectionCallback;
			FormatCallback = (Func<LocId, string, string>)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x408FDD0", Offset = "0x408E7D0", VA = "0x18408FDD0")]
		public Localizator(CultureInfo culture, ITableProvider tableProvider, [Optional] Func<LocId, LocId> redirectionCallback, [Optional] Func<LocId, string, string> formatCallback)
		{
			//IL_002f: Expected O, but got I4
			StringTables = (Dictionary<string, IStringTable>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			Culture = culture;
			TableProvider = tableProvider;
			RedirectionCallback = redirectionCallback;
			FormatCallback = (Func<LocId, string, string>)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x408F730", Offset = "0x408E130", VA = "0x18408F730")]
		private unsafe IStringTable GetTable(string name)
		{
			Dictionary<string, IStringTable> dictionary = StringTables;
			int num = 0;
			if (!((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)name, out *(TValue*)num))
			{
				ITableProvider tableProvider = TableProvider;
				Dictionary<string, IStringTable> dictionary2 = StringTables;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				throw new NullReferenceException();
			}
			dictionary = (Dictionary<string, IStringTable>)(object)((object)dictionary + (object)dictionary);
			num += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x408F620", Offset = "0x408E020", VA = "0x18408F620")]
		public void AddGeneralResolver(IResolver resolver)
		{
			//Discarded unreachable code: IL_0042
			if (resolver != null)
			{
				List<IResolver> list = generalResolvers;
				if (list == null)
				{
					List<IResolver> list2 = (generalResolvers = (List<IResolver>)(object)new List<T>());
					List<IResolver> list3 = generalResolvers;
				}
				((List<T>)(object)list).Add((T)resolver);
				MultiResolver multiResolver = default(MultiResolver);
				List<IResolver> list4 = (List<IResolver>)(multiResolver.Resolvers = generalResolvers);
				GeneralResolver = multiResolver;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x408F870", Offset = "0x408E270", VA = "0x18408F870", Slot = "4")]
		public unsafe string Get(LocId locId, [Optional] IResolver resolver)
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			return ((LocId*)locId)->FullName;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x408F8C0", Offset = "0x408E2C0", VA = "0x18408F8C0", Slot = "5")]
		public bool TryGet(LocId locId, out string text, [Optional] IResolver resolver)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
