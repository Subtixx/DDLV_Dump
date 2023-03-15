using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Rewards;
using Google.Protobuf.Collections;

namespace Meta.Online.CRM
{
	[Cpp2IlInjected.Token(Token = "0x2000FDC")]
	public class GameConfig
	{
		[Cpp2IlInjected.Token(Token = "0x2000FDD")]
		public class BundleItem
		{
			[Cpp2IlInjected.Token(Token = "0x17001652")]
			public ItemReward Item
			{
				[Cpp2IlInjected.Token(Token = "0x6007FC2")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CItem_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FC3")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CItem_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001653")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4004139")]
			public int? ReplacedQuantity
			{
				[Cpp2IlInjected.Token(Token = "0x6007FC4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007FC5")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x6007FC6")]
			[Cpp2IlInjected.Address(RVA = "0x997370", Offset = "0x995D70", VA = "0x180997370")]
			public BundleItem(int id, int amount, int? replacedAmount)
			{
				//Discarded unreachable code: IL_0029
				Item = new ItemReward
				{
					id_ = id,
					amount_ = amount
				};
				ReplacedQuantity = replacedAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000FDE")]
		public enum BundleType
		{
			[Cpp2IlInjected.Token(Token = "0x400413B")]
			Offline = 1,
			[Cpp2IlInjected.Token(Token = "0x400413C")]
			IAP = 2,
			[Cpp2IlInjected.Token(Token = "0x400413D")]
			Invalid = 99
		}

		[Cpp2IlInjected.Token(Token = "0x2000FDF")]
		public enum BundleSubType
		{
			[Cpp2IlInjected.Token(Token = "0x400413F")]
			Item = 1,
			[Cpp2IlInjected.Token(Token = "0x4004140")]
			Bundle = 2,
			[Cpp2IlInjected.Token(Token = "0x4004141")]
			Gacha = 3,
			[Cpp2IlInjected.Token(Token = "0x4004142")]
			Invalid = 99
		}

		[Cpp2IlInjected.Token(Token = "0x2000FE0")]
		public class StoreBundle
		{
			[Cpp2IlInjected.Token(Token = "0x17001654")]
			public string BundleId
			{
				[Cpp2IlInjected.Token(Token = "0x6007FC7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CBundleId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FC8")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CBundleId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001655")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4004144")]
			public BundleType Type
			{
				[Cpp2IlInjected.Token(Token = "0x6007FC9")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007FCA")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x17001656")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4004145")]
			public BundleSubType SubType
			{
				[Cpp2IlInjected.Token(Token = "0x6007FCB")]
				[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007FCC")]
				[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x17001657")]
			public List<BundleItem> Items
			{
				[Cpp2IlInjected.Token(Token = "0x6007FCD")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FCE")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003CItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001658")]
			public List<Price> Prices
			{
				[Cpp2IlInjected.Token(Token = "0x6007FCF")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CPrices_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FD0")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				private set
				{
					_003CPrices_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001659")]
			public List<Price> ReplacedPrices
			{
				[Cpp2IlInjected.Token(Token = "0x6007FD1")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CReplacedPrices_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FD2")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				private set
				{
					_003CReplacedPrices_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700165A")]
			public List<string> Categories
			{
				[Cpp2IlInjected.Token(Token = "0x6007FD3")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CCategories_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FD4")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				private set
				{
					_003CCategories_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700165B")]
			public string GachaId
			{
				[Cpp2IlInjected.Token(Token = "0x6007FD5")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				[CompilerGenerated]
				get
				{
					return _003CGachaId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FD6")]
				[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
				[CompilerGenerated]
				private set
				{
					_003CGachaId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700165C")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x6007FD7")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				[CompilerGenerated]
				get
				{
					return _003CTitle_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FD8")]
				[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
				[CompilerGenerated]
				private set
				{
					_003CTitle_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700165D")]
			public string Image
			{
				[Cpp2IlInjected.Token(Token = "0x6007FD9")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003CImage_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007FDA")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				private set
				{
					_003CImage_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007FDB")]
			[Cpp2IlInjected.Address(RVA = "0x99C000", Offset = "0x99AA00", VA = "0x18099C000")]
			public Dictionary<string, List<string>> GetTags(List<string> tagsData)
			{
				//Discarded unreachable code: IL_00b3, IL_00b9, IL_00bf, IL_00c5, IL_00cb, IL_00d1, IL_00d7, IL_00dd, IL_00e3, IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d, IL_0113
				int num = 0;
				Dictionary<string, List<string>> result = (Dictionary<string, List<string>>)(object)new Dictionary<TKey, TValue>();
				bool flag = default(bool);
				if (flag)
				{
					(new char[1])[0] = '=';
					string[] array = default(string[]);
					int length = array.Length;
					if (length != 1)
					{
						while (length != 2)
						{
						}
						string text = array[1];
						char[] array2 = new char[length - 1];
						array2[0] = ',';
						List<string> list = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)text.Split(array2));
						throw new NullReferenceException();
					}
					string text2 = array[0];
					char[] array3 = new char[1];
					array3[0] = ',';
					string[] array4 = text2.Split(array3);
					while (num >= array4.Length)
					{
					}
					string item = array4[num];
					new List<T>().Add((T)item);
					throw new NullReferenceException();
				}
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007FDC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public StoreBundle()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001651")]
		public List<StoreBundle> StoreBundles
		{
			[Cpp2IlInjected.Token(Token = "0x6007FB5")]
			[Cpp2IlInjected.Address(RVA = "0x180EC80", Offset = "0x180D680", VA = "0x18180EC80")]
			get
			{
				return (List<StoreBundle>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007FB6")]
		[Cpp2IlInjected.Address(RVA = "0x180EC80", Offset = "0x180D680", VA = "0x18180EC80")]
		public List<StoreBundle> GetStoreBundles([Optional] List<string> categories)
		{
			return (List<StoreBundle>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FB7")]
		[Cpp2IlInjected.Address(RVA = "0x180E330", Offset = "0x180CD30", VA = "0x18180E330")]
		public RepeatedField<CurrencyCost> GetBundlePrices(string bundleId)
		{
			//Discarded unreachable code: IL_0062, IL_0068
			int num = 0;
			if (new List<T>() != null)
			{
				List<StoreBundle> list = (List<StoreBundle>)(object)new List<T>();
				Predicate<StoreBundle> predicate = (Predicate<StoreBundle>)(object)(Predicate<T>)delegate(StoreBundle x)
				{
					//Discarded unreachable code: IL_0014
					string b = bundleId;
					return string.Equals(x.BundleId, b);
				};
				StoreBundle storeBundle = (StoreBundle)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				if (storeBundle != null)
				{
					RepeatedField<CurrencyCost> repeatedField = (RepeatedField<CurrencyCost>)(object)new RepeatedField<T>();
					List<Price> _003CPrices_003Ek__BackingField = storeBundle.Prices;
					bool flag = default(bool);
					if (flag)
					{
						CurrencyCost item = default(CurrencyCost);
						((RepeatedField<T>)(object)repeatedField).Add((T)item);
					}
					return repeatedField;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FB8")]
		[Cpp2IlInjected.Address(RVA = "0x180E070", Offset = "0x180CA70", VA = "0x18180E070")]
		public MultiReward GetBundleItems(string bundleId)
		{
			if (new List<T>() != null)
			{
				List<StoreBundle> list = (List<StoreBundle>)(object)new List<T>();
				Predicate<StoreBundle> predicate = (Predicate<StoreBundle>)(object)(Predicate<T>)delegate(StoreBundle x)
				{
					//Discarded unreachable code: IL_0014
					string b = bundleId;
					return string.Equals(x.BundleId, b);
				};
				StoreBundle storeBundle = (StoreBundle)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				if (storeBundle != null)
				{
					List<BundleItem> _003CItems_003Ek__BackingField = storeBundle.Items;
					Func<BundleItem, ItemReward> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_1;
					if (_003C_003E9__8_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BundleItem x) => x.Item);
					}
					return new MultiReward(Enumerable.Select<BundleItem, ItemReward>((IEnumerable<>)_003CItems_003Ek__BackingField, (Func<, >)(object)_003C_003E9__8_));
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FB9")]
		[Cpp2IlInjected.Address(RVA = "0x180E7B0", Offset = "0x180D1B0", VA = "0x18180E7B0")]
		public string GetGachaId(string bundleId)
		{
			//Discarded unreachable code: IL_004a
			if (new List<T>() != null)
			{
				List<StoreBundle> list = (List<StoreBundle>)(object)new List<T>();
				Predicate<StoreBundle> predicate = (Predicate<StoreBundle>)(object)(Predicate<T>)delegate(StoreBundle x)
				{
					//Discarded unreachable code: IL_0014
					string b = bundleId;
					return string.Equals(x.BundleId, b);
				};
				StoreBundle storeBundle = (StoreBundle)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				if (storeBundle != null && storeBundle.SubType == BundleSubType.Gacha)
				{
					return storeBundle.GachaId;
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6007FBA")]
		[Cpp2IlInjected.Address(RVA = "0x180E610", Offset = "0x180D010", VA = "0x18180E610")]
		public BundleType GetBundleType(string bundleId)
		{
			//Discarded unreachable code: IL_003e
			if (new List<T>() != null)
			{
				List<StoreBundle> list = (List<StoreBundle>)(object)new List<T>();
				Predicate<StoreBundle> predicate = (Predicate<StoreBundle>)(object)(Predicate<T>)delegate(StoreBundle x)
				{
					//Discarded unreachable code: IL_0014
					string b = bundleId;
					return string.Equals(x.BundleId, b);
				};
				StoreBundle storeBundle = (StoreBundle)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				if (storeBundle != null)
				{
					return storeBundle.Type;
				}
			}
			return BundleType.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6007FBB")]
		[Cpp2IlInjected.Address(RVA = "0x180EBC0", Offset = "0x180D5C0", VA = "0x18180EBC0")]
		public Dictionary<string, string> GetIAPProductIds()
		{
			return (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FBC")]
		[Cpp2IlInjected.Address(RVA = "0x180EB20", Offset = "0x180D520", VA = "0x18180EB20")]
		public string GetIAPProductId(string bundleId)
		{
			//Discarded unreachable code: IL_000c
			return (string)new Dictionary<TKey, TValue>()[(TKey)bundleId];
		}

		[Cpp2IlInjected.Token(Token = "0x6007FBD")]
		[Cpp2IlInjected.Address(RVA = "0x180E960", Offset = "0x180D360", VA = "0x18180E960")]
		public string GetIAPBundleId(string productId)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007FBE")]
		[Cpp2IlInjected.Address(RVA = "0x180EAC0", Offset = "0x180D4C0", VA = "0x18180EAC0")]
		public List<string> GetIAPIds()
		{
			return (List<string>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FBF")]
		[Cpp2IlInjected.Address(RVA = "0x180EC20", Offset = "0x180D620", VA = "0x18180EC20")]
		public List<string> GetOfflineIds()
		{
			return (List<string>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FC0")]
		[Cpp2IlInjected.Address(RVA = "0x180DDB0", Offset = "0x180C7B0", VA = "0x18180DDB0")]
		public List<string> GetAllCategories()
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_003c, IL_0042
			//IL_0024: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			List<string> list;
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				list = (List<string>)(object)new List<T>();
				List<StoreBundle> list2 = (List<StoreBundle>)(object)new List<T>();
				if (!flag || !flag2)
				{
					break;
				}
				if (!((List<T>)(object)list).Contains((T)num2))
				{
					((List<T>)(object)list).Add((T)num2);
					break;
				}
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6007FC1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GameConfig()
		{
		}
	}
}
