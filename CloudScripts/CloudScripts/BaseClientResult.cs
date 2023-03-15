using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab;
using PlayFab.EconomyModels;
using PlayFab.LeaderboardsModels;
using PlayFab.ProfilesModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	public class BaseClientResult
	{
		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticValue> Statistics
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CStatistics_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CStatistics_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticValue>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public Dictionary<int, Amount> Items
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<int, Amount>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public Dictionary<int, Amount> Currencies
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrencies_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CCurrencies_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<int, Amount>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1165580", Offset = "0x1163F80", VA = "0x181165580")]
		internal static BaseClientResult Create(EntityProfileBody profile, GetVirtualCurrenciesResult result2, GetInventoryItemsResponse result3, GetItemsResponse result4)
		{
			//Discarded unreachable code: IL_0170, IL_0176, IL_017c, IL_0182, IL_0188, IL_018e, IL_019a, IL_01a0, IL_01a6, IL_01ac, IL_01b2
			//IL_0155: Expected I4, but got O
			Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>, PlayFab.LeaderboardsModels.EntityStatisticValue> func = default(Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>, PlayFab.LeaderboardsModels.EntityStatisticValue>);
			Func<CurrencyResponseDto, CatalogItemMetadata, Tuple<CurrencyResponseDto, CatalogItemMetadata>> func2 = default(Func<CurrencyResponseDto, CatalogItemMetadata, Tuple<CurrencyResponseDto, CatalogItemMetadata>>);
			uint num2 = default(uint);
			IEnumerable<InventoryItem> enumerable2 = default(IEnumerable<InventoryItem>);
			uint num6 = default(uint);
			int num5 = default(int);
			int num3 = default(int);
			int num7 = default(int);
			while (true)
			{
				int num = 0;
				BaseClientResult baseClientResult = new BaseClientResult();
				Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticValue> dictionary = (baseClientResult.Statistics = (Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticValue>)(object)new Dictionary<TKey, TValue>());
				Dictionary<int, Amount> dictionary2 = (baseClientResult.Items = (Dictionary<int, Amount>)(object)new Dictionary<TKey, TValue>());
				Dictionary<int, Amount> dictionary3 = (baseClientResult.Currencies = (Dictionary<int, Amount>)(object)new Dictionary<TKey, TValue>());
				if (profile != null)
				{
					Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue> statistics = profile.Statistics;
					if (statistics != null)
					{
						Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>, string> _003C_003E9__12_ = _003C_003Ec._003C_003E9__12_0;
						if (_003C_003E9__12_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
							};
						}
						if (_003C_003Ec._003C_003E9__12_1 == null)
						{
							func = (Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>, PlayFab.LeaderboardsModels.EntityStatisticValue>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
							});
						}
						Dictionary<string, KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>> dictionary4 = (Dictionary<string, KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>>)(object)(baseClientResult.Statistics = (Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticValue>)(object)Enumerable.ToDictionary<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticValue>, string, PlayFab.LeaderboardsModels.EntityStatisticValue>((IEnumerable<>)statistics, (Func<, >)(object)_003C_003E9__12_, (Func<, >)(object)func));
					}
				}
				IEnumerable<CurrencyResponseDto> enumerable;
				if (result2 != null)
				{
					List<CurrencyResponseDto> currencies = result2.Currencies;
					List<CatalogItemMetadata> items = result2.Items;
					enumerable = (IEnumerable<CurrencyResponseDto>)Enumerable.Zip<CurrencyResponseDto, CatalogItemMetadata, Tuple<CurrencyResponseDto, CatalogItemMetadata>>((IEnumerable<>)currencies, (IEnumerable<>)items, (Func<, , >)(object)func2);
					if (enumerable != null)
					{
						if (num < (int)num2)
						{
							num += num;
							if (num == (int)num2)
							{
								num3 += num3;
								goto IL_0107;
							}
							num++;
						}
						while (num3 <= 0)
						{
						}
						Dictionary<int, Amount> dictionary5 = baseClientResult.Currencies;
						Amount amount = new Amount();
						int num4 = (amount.Quantity = amount.Quantity);
						throw new NullReferenceException();
					}
					goto IL_0107;
				}
				goto IL_0116;
				IL_0116:
				if (enumerable2 != null)
				{
					if (num5 < (int)num6)
					{
						num5 += num5;
						if (num5 == (int)num6)
						{
							num3 += num3;
							goto IL_0162;
						}
						num5++;
					}
					num3 = num7;
					while (num7 <= 0)
					{
					}
					Dictionary<int, Amount> dictionary6 = baseClientResult.Items;
					Amount amount2 = new Amount();
					amount2.Quantity = (int)amount2;
					throw new NullReferenceException();
				}
				goto IL_0162;
				IL_0162:
				if (enumerable2 != null)
				{
				}
				if (num == 0)
				{
					return baseClientResult;
				}
				continue;
				IL_0107:
				num5 = 0;
				if (enumerable != null)
				{
				}
				if (num != 0)
				{
					break;
				}
				goto IL_0116;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1165DB0", Offset = "0x11647B0", VA = "0x181165DB0")]
		public BaseClientResult()
		{
		}
	}
}
