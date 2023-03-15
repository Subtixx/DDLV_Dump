using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	public sealed class ItemGenerator : IMessage<ItemGenerator>, IMessage, IEquatable<ItemGenerator>, IDeepCloneable<ItemGenerator>, IMessageFieldAccessor, IGenerator, IGeneratorFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private static readonly MessageParser<ItemGenerator> _parser = (MessageParser<ItemGenerator>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemGenerator()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private ItemIdFilter id_;

		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private ItemTypeFilter type_;

		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public const int SubTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		private ItemSubTypeFilter subType_;

		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public const int QualityFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private ItemQualityFilter quality_;

		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public const int ComplexityFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private ItemComplexityFilter complexity_;

		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public const int MoodFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		private ItemMoodFilter mood_;

		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public const int SturdinessFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private ItemSturdinessFilter sturdiness_;

		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public const int NormalityFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		private ItemNormalityFilter normality_;

		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public const int MinRarityFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private ItemMinRarityFilter minRarity_;

		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public const int MaxRarityFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private ItemMaxRarityFilter maxRarity_;

		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public const int RarityFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private ItemRarityFilter rarity_;

		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public const int AllTagsFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private ItemAllTagsFilter allTags_;

		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public const int AnyTagFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private ItemAnyTagFilter anyTag_;

		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public const int SeedFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		private ItemSeedFilter seed_;

		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public const int MealFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private ItemMealFilter meal_;

		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public const int InStallFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		private ItemAvailableInStall inStall_;

		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public const int GridFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private ItemGridFilter grid_;

		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public const int CurrencyFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private ItemCurrencyFilter currency_;

		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public const int MinFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private int min_;

		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public const int MaxFieldNumber = 101;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private int max_;

		[Cpp2IlInjected.Token(Token = "0x17000421")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemGenerator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001254")]
			[Cpp2IlInjected.Address(RVA = "0x25DBFC0", Offset = "0x25DA9C0", VA = "0x1825DBFC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000422")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001255")]
			[Cpp2IlInjected.Address(RVA = "0x25DBEF0", Offset = "0x25DA8F0", VA = "0x1825DBEF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001256")]
			[Cpp2IlInjected.Address(RVA = "0x25DC020", Offset = "0x25DAA20", VA = "0x1825DC020", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000424")]
		[DebuggerNonUserCode]
		public ItemIdFilter Id
		{
			[Cpp2IlInjected.Token(Token = "0x600125B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x600125C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				id_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000425")]
		[DebuggerNonUserCode]
		public ItemTypeFilter Type
		{
			[Cpp2IlInjected.Token(Token = "0x600125D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x600125E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				type_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		[DebuggerNonUserCode]
		public ItemSubTypeFilter SubType
		{
			[Cpp2IlInjected.Token(Token = "0x600125F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return subType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001260")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				subType_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000427")]
		[DebuggerNonUserCode]
		public ItemQualityFilter Quality
		{
			[Cpp2IlInjected.Token(Token = "0x6001261")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return quality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001262")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				quality_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000428")]
		[DebuggerNonUserCode]
		public ItemComplexityFilter Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6001263")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return complexity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001264")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				complexity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000429")]
		[DebuggerNonUserCode]
		public ItemMoodFilter Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6001265")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return mood_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001266")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				mood_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		[DebuggerNonUserCode]
		public ItemSturdinessFilter Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6001267")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return sturdiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001268")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				sturdiness_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		[DebuggerNonUserCode]
		public ItemNormalityFilter Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6001269")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return normality_;
			}
			[Cpp2IlInjected.Token(Token = "0x600126A")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				normality_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		[DebuggerNonUserCode]
		public ItemMinRarityFilter MinRarity
		{
			[Cpp2IlInjected.Token(Token = "0x600126B")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return minRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x600126C")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				minRarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		[DebuggerNonUserCode]
		public ItemMaxRarityFilter MaxRarity
		{
			[Cpp2IlInjected.Token(Token = "0x600126D")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return maxRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x600126E")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				maxRarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		[DebuggerNonUserCode]
		public ItemRarityFilter Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x600126F")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001270")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				rarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		[DebuggerNonUserCode]
		public ItemAllTagsFilter AllTags
		{
			[Cpp2IlInjected.Token(Token = "0x6001271")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return allTags_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001272")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				allTags_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000430")]
		[DebuggerNonUserCode]
		public ItemAnyTagFilter AnyTag
		{
			[Cpp2IlInjected.Token(Token = "0x6001273")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return anyTag_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001274")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				anyTag_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		[DebuggerNonUserCode]
		public ItemSeedFilter Seed
		{
			[Cpp2IlInjected.Token(Token = "0x6001275")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return seed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001276")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000432")]
		[DebuggerNonUserCode]
		public ItemMealFilter Meal
		{
			[Cpp2IlInjected.Token(Token = "0x6001277")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return meal_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001278")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			set
			{
				meal_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		[DebuggerNonUserCode]
		public ItemAvailableInStall InStall
		{
			[Cpp2IlInjected.Token(Token = "0x6001279")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return inStall_;
			}
			[Cpp2IlInjected.Token(Token = "0x600127A")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			set
			{
				inStall_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000434")]
		[DebuggerNonUserCode]
		public ItemGridFilter Grid
		{
			[Cpp2IlInjected.Token(Token = "0x600127B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return grid_;
			}
			[Cpp2IlInjected.Token(Token = "0x600127C")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			set
			{
				grid_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000435")]
		[DebuggerNonUserCode]
		public ItemCurrencyFilter Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600127D")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return currency_;
			}
			[Cpp2IlInjected.Token(Token = "0x600127E")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			set
			{
				currency_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000436")]
		[DebuggerNonUserCode]
		public int Min
		{
			[Cpp2IlInjected.Token(Token = "0x600127F")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001280")]
			[Cpp2IlInjected.Address(RVA = "0xF64F60", Offset = "0xF63960", VA = "0x180F64F60")]
			set
			{
				min_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000437")]
		[DebuggerNonUserCode]
		public int Max
		{
			[Cpp2IlInjected.Token(Token = "0x6001281")]
			[Cpp2IlInjected.Address(RVA = "0x1024770", Offset = "0x1023170", VA = "0x181024770")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001282")]
			[Cpp2IlInjected.Address(RVA = "0x1024810", Offset = "0x1023210", VA = "0x181024810")]
			set
			{
				max_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001257")]
		[Cpp2IlInjected.Address(RVA = "0x25DBEC0", Offset = "0x25DA8C0", VA = "0x1825DBEC0")]
		[DebuggerNonUserCode]
		public ItemGenerator()
		{
			//IL_000f: Expected I4, but got I8
			//IL_0018: Expected I4, but got I8
			min_ = 1;
			max_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001258")]
		[Cpp2IlInjected.Address(RVA = "0x25DAB80", Offset = "0x25D9580", VA = "0x1825DAB80")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			min_ = 1;
			max_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001259")]
		[Cpp2IlInjected.Address(RVA = "0x25DB6C0", Offset = "0x25DA0C0", VA = "0x1825DB6C0")]
		[DebuggerNonUserCode]
		public ItemGenerator(ItemGenerator other)
		{
			//IL_000f: Expected I4, but got I8
			//IL_0018: Expected I4, but got I8
			//IL_005a: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_00fa: Expected O, but got I4
			//IL_0143: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01a9: Expected O, but got I4
			//IL_01ed: Expected O, but got I4
			//IL_0231: Expected O, but got I4
			//IL_0275: Expected O, but got I4
			//IL_0292: Expected O, but got I4
			//IL_02af: Expected O, but got I4
			//IL_0317: Expected O, but got I4
			//IL_0349: Expected O, but got I4
			//IL_0366: Expected O, but got I4
			//IL_039c: Expected O, but got I4
			//IL_03bb: Expected O, but got I4
			//IL_0414: Expected O, but got I4
			min_ = 1;
			max_ = 1;
			ItemIdFilter itemIdFilter = other.id_;
			int num = 0;
			if (itemIdFilter != null)
			{
				ItemIdFilter itemIdFilter2 = new ItemIdFilter();
				RepeatedField<int> repeatedField = (itemIdFilter2.values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)itemIdFilter.values_).Clone());
				UnknownFieldSet unknownFieldSet = (itemIdFilter2._unknownFields = UnknownFieldSet.Clone(itemIdFilter._unknownFields));
			}
			id_ = (ItemIdFilter)num;
			ItemTypeFilter itemTypeFilter = other.type_;
			if (itemTypeFilter != null)
			{
				ItemTypeFilter itemTypeFilter2 = itemTypeFilter.Clone();
			}
			type_ = (ItemTypeFilter)num;
			ItemSubTypeFilter itemSubTypeFilter = other.subType_;
			if (itemSubTypeFilter != null)
			{
				ItemSubTypeFilter itemSubTypeFilter2 = itemSubTypeFilter.Clone();
			}
			subType_ = (ItemSubTypeFilter)num;
			ItemQualityFilter itemQualityFilter = other.quality_;
			if (itemQualityFilter != null)
			{
				ItemQualityFilter itemQualityFilter2 = new ItemQualityFilter();
				RepeatedField<Quality> repeatedField2 = (itemQualityFilter2.values_ = (RepeatedField<Quality>)(object)((RepeatedField<T>)(object)itemQualityFilter.values_).Clone());
				UnknownFieldSet unknownFieldSet2 = (itemQualityFilter2._unknownFields = UnknownFieldSet.Clone(itemQualityFilter._unknownFields));
			}
			quality_ = (ItemQualityFilter)num;
			ItemComplexityFilter itemComplexityFilter = other.complexity_;
			if (itemComplexityFilter != null)
			{
				ItemComplexityFilter itemComplexityFilter2 = itemComplexityFilter.Clone();
			}
			complexity_ = (ItemComplexityFilter)num;
			ItemMoodFilter itemMoodFilter = other.mood_;
			if (itemMoodFilter != null)
			{
				ItemMoodFilter itemMoodFilter2 = new ItemMoodFilter();
				RepeatedField<Mood> repeatedField3 = (itemMoodFilter2.values_ = (RepeatedField<Mood>)(object)((RepeatedField<T>)(object)itemMoodFilter.values_).Clone());
				UnknownFieldSet unknownFieldSet3 = (itemMoodFilter2._unknownFields = UnknownFieldSet.Clone(itemMoodFilter._unknownFields));
			}
			mood_ = (ItemMoodFilter)num;
			ItemSturdinessFilter itemSturdinessFilter = other.sturdiness_;
			if (itemSturdinessFilter != null)
			{
				ItemSturdinessFilter itemSturdinessFilter2 = itemSturdinessFilter.Clone();
			}
			sturdiness_ = (ItemSturdinessFilter)num;
			ItemNormalityFilter itemNormalityFilter = other.normality_;
			if (itemNormalityFilter != null)
			{
				ItemNormalityFilter itemNormalityFilter2 = new ItemNormalityFilter();
				RepeatedField<Normality> repeatedField4 = (itemNormalityFilter2.values_ = (RepeatedField<Normality>)(object)((RepeatedField<T>)(object)itemNormalityFilter.values_).Clone());
				UnknownFieldSet unknownFieldSet4 = (itemNormalityFilter2._unknownFields = UnknownFieldSet.Clone(itemNormalityFilter._unknownFields));
			}
			normality_ = (ItemNormalityFilter)num;
			ItemMinRarityFilter itemMinRarityFilter = other.minRarity_;
			if (itemMinRarityFilter != null)
			{
				ItemMinRarityFilter itemMinRarityFilter2 = new ItemMinRarityFilter();
				int num2 = (itemMinRarityFilter2.value_ = itemMinRarityFilter.value_);
				UnknownFieldSet unknownFieldSet5 = (itemMinRarityFilter2._unknownFields = UnknownFieldSet.Clone(itemMinRarityFilter._unknownFields));
			}
			minRarity_ = (ItemMinRarityFilter)num;
			ItemMaxRarityFilter itemMaxRarityFilter = other.maxRarity_;
			if (itemMaxRarityFilter != null)
			{
				ItemMaxRarityFilter itemMaxRarityFilter2 = new ItemMaxRarityFilter();
				int num3 = (itemMaxRarityFilter2.value_ = itemMaxRarityFilter.value_);
				UnknownFieldSet unknownFieldSet6 = (itemMaxRarityFilter2._unknownFields = UnknownFieldSet.Clone(itemMaxRarityFilter._unknownFields));
			}
			maxRarity_ = (ItemMaxRarityFilter)num;
			ItemRarityFilter itemRarityFilter = other.rarity_;
			if (itemRarityFilter != null)
			{
				ItemRarityFilter itemRarityFilter2 = new ItemRarityFilter();
				int num4 = (itemRarityFilter2.value_ = itemRarityFilter.value_);
				UnknownFieldSet unknownFieldSet7 = (itemRarityFilter2._unknownFields = UnknownFieldSet.Clone(itemRarityFilter._unknownFields));
			}
			rarity_ = (ItemRarityFilter)num;
			ItemAllTagsFilter itemAllTagsFilter = other.allTags_;
			if (itemAllTagsFilter != null)
			{
				ItemAllTagsFilter itemAllTagsFilter2 = itemAllTagsFilter.Clone();
			}
			allTags_ = (ItemAllTagsFilter)num;
			ItemAnyTagFilter itemAnyTagFilter = other.anyTag_;
			if (itemAnyTagFilter != null)
			{
				ItemAnyTagFilter itemAnyTagFilter2 = itemAnyTagFilter.Clone();
			}
			anyTag_ = (ItemAnyTagFilter)num;
			ItemSeedFilter itemSeedFilter = other.seed_;
			if (itemSeedFilter != null)
			{
				ItemSeedFilter itemSeedFilter2 = new ItemSeedFilter();
				ActivityItemType activityItemType = (itemSeedFilter2.producedType_ = itemSeedFilter.producedType_);
				CropType cropType = (itemSeedFilter2.cropType_ = itemSeedFilter.cropType_);
				bool flag = (itemSeedFilter2.hasProduct_ = itemSeedFilter.hasProduct_);
				UnknownFieldSet unknownFieldSet8 = (itemSeedFilter2._unknownFields = UnknownFieldSet.Clone(itemSeedFilter._unknownFields));
			}
			seed_ = (ItemSeedFilter)num;
			ItemMealFilter itemMealFilter = other.meal_;
			if (itemMealFilter != null)
			{
				ItemMealFilter itemMealFilter2 = new ItemMealFilter();
				UnknownFieldSet unknownFieldSet9 = (itemMealFilter2._unknownFields = UnknownFieldSet.Clone(itemMealFilter._unknownFields));
			}
			meal_ = (ItemMealFilter)num;
			ItemAvailableInStall itemAvailableInStall = other.inStall_;
			if (itemAvailableInStall != null)
			{
				ItemAvailableInStall itemAvailableInStall2 = itemAvailableInStall.Clone();
			}
			inStall_ = (ItemAvailableInStall)num;
			ItemGridFilter itemGridFilter = other.grid_;
			if (itemGridFilter != null)
			{
				ItemGridFilter itemGridFilter2 = new ItemGridFilter();
				AreaSize minAreaSize_ = itemGridFilter.minAreaSize_;
				if (minAreaSize_ != null)
				{
					AreaSize areaSize = minAreaSize_.Clone();
				}
				itemGridFilter2.minAreaSize_ = (AreaSize)num;
				AreaSize maxAreaSize_ = itemGridFilter.maxAreaSize_;
				if (maxAreaSize_ != null)
				{
					AreaSize areaSize2 = maxAreaSize_.Clone();
				}
				itemGridFilter2.maxAreaSize_ = (AreaSize)num;
				bool flag2 = (itemGridFilter2.canRotate_ = itemGridFilter.canRotate_);
				GridSizeQualifier gridSizeQualifier = (itemGridFilter2.sizeQualifier_ = itemGridFilter.sizeQualifier_);
				RepeatedField<int> repeatedField5 = (itemGridFilter2.ignoreSizeForTags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)itemGridFilter.ignoreSizeForTags_).Clone());
				UnknownFieldSet unknownFieldSet10 = (itemGridFilter2._unknownFields = UnknownFieldSet.Clone(itemGridFilter._unknownFields));
			}
			grid_ = (ItemGridFilter)num;
			ItemCurrencyFilter itemCurrencyFilter = other.currency_;
			ItemCurrencyFilter itemCurrencyFilter2 = default(ItemCurrencyFilter);
			if (itemCurrencyFilter != null)
			{
				itemCurrencyFilter2 = itemCurrencyFilter.Clone();
			}
			currency_ = itemCurrencyFilter2;
			int num5 = (min_ = other.min_);
			int num6 = (max_ = other.max_);
			UnknownFieldSet unknownFieldSet11 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600125A")]
		[Cpp2IlInjected.Address(RVA = "0x25D8380", Offset = "0x25D6D80", VA = "0x1825D8380", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemGenerator Clone()
		{
			return new ItemGenerator(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001283")]
		[Cpp2IlInjected.Address(RVA = "0x25D86E0", Offset = "0x25D70E0", VA = "0x1825D86E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ItemGenerator)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001284")]
		[Cpp2IlInjected.Address(RVA = "0x25D84A0", Offset = "0x25D6EA0", VA = "0x1825D84A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemGenerator other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemIdFilter objB = other.id_;
				if (object.Equals(id_, objB))
				{
					ItemTypeFilter objB2 = other.type_;
					if (object.Equals(type_, objB2))
					{
						ItemSubTypeFilter objB3 = other.subType_;
						if (object.Equals(subType_, objB3))
						{
							ItemQualityFilter objB4 = other.quality_;
							if (object.Equals(quality_, objB4))
							{
								ItemComplexityFilter objB5 = other.complexity_;
								if (object.Equals(complexity_, objB5))
								{
									ItemMoodFilter objB6 = other.mood_;
									if (object.Equals(mood_, objB6))
									{
										ItemSturdinessFilter objB7 = other.sturdiness_;
										if (object.Equals(sturdiness_, objB7))
										{
											ItemNormalityFilter objB8 = other.normality_;
											if (object.Equals(normality_, objB8))
											{
												ItemMinRarityFilter objB9 = other.minRarity_;
												if (object.Equals(minRarity_, objB9))
												{
													ItemMaxRarityFilter objB10 = other.maxRarity_;
													if (object.Equals(maxRarity_, objB10))
													{
														ItemRarityFilter objB11 = other.rarity_;
														if (object.Equals(rarity_, objB11))
														{
															ItemAllTagsFilter objB12 = other.allTags_;
															if (object.Equals(allTags_, objB12))
															{
																ItemAnyTagFilter objB13 = other.anyTag_;
																if (object.Equals(anyTag_, objB13))
																{
																	ItemSeedFilter objB14 = other.seed_;
																	if (object.Equals(seed_, objB14))
																	{
																		ItemMealFilter objB15 = other.meal_;
																		if (object.Equals(meal_, objB15))
																		{
																			ItemAvailableInStall objB16 = other.inStall_;
																			if (object.Equals(inStall_, objB16))
																			{
																				ItemGridFilter objB17 = other.grid_;
																				if (object.Equals(grid_, objB17))
																				{
																					ItemCurrencyFilter objB18 = other.currency_;
																					if (object.Equals(currency_, objB18))
																					{
																						int num = other.min_;
																						if (min_ == num)
																						{
																							int num2 = other.max_;
																							if (max_ == num2)
																							{
																								UnknownFieldSet unknownFields = other._unknownFields;
																								return object.Equals(_unknownFields, unknownFields);
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001285")]
		[Cpp2IlInjected.Address(RVA = "0x25D95D0", Offset = "0x25D7FD0", VA = "0x1825D95D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			ItemIdFilter itemIdFilter = id_;
			if (itemIdFilter != null)
			{
				int hashCode = itemIdFilter.GetHashCode();
			}
			ItemTypeFilter itemTypeFilter = type_;
			if (itemTypeFilter != null)
			{
				int hashCode2 = itemTypeFilter.GetHashCode();
			}
			ItemSubTypeFilter itemSubTypeFilter = subType_;
			if (itemSubTypeFilter != null)
			{
				int hashCode3 = itemSubTypeFilter.GetHashCode();
			}
			ItemQualityFilter itemQualityFilter = quality_;
			if (itemQualityFilter != null)
			{
				int hashCode4 = itemQualityFilter.GetHashCode();
			}
			ItemComplexityFilter itemComplexityFilter = complexity_;
			if (itemComplexityFilter != null)
			{
				int hashCode5 = itemComplexityFilter.GetHashCode();
			}
			ItemMoodFilter itemMoodFilter = mood_;
			if (itemMoodFilter != null)
			{
				int hashCode6 = itemMoodFilter.GetHashCode();
			}
			ItemSturdinessFilter itemSturdinessFilter = sturdiness_;
			if (itemSturdinessFilter != null)
			{
				int hashCode7 = itemSturdinessFilter.GetHashCode();
			}
			ItemNormalityFilter itemNormalityFilter = normality_;
			if (itemNormalityFilter != null)
			{
				int hashCode8 = itemNormalityFilter.GetHashCode();
			}
			ItemMinRarityFilter itemMinRarityFilter = minRarity_;
			if (itemMinRarityFilter != null)
			{
				int hashCode9 = itemMinRarityFilter.GetHashCode();
			}
			ItemMaxRarityFilter itemMaxRarityFilter = maxRarity_;
			if (itemMaxRarityFilter != null)
			{
				int hashCode10 = itemMaxRarityFilter.GetHashCode();
			}
			ItemRarityFilter itemRarityFilter = rarity_;
			if (itemRarityFilter != null)
			{
				int hashCode11 = itemRarityFilter.GetHashCode();
			}
			ItemAllTagsFilter itemAllTagsFilter = allTags_;
			if (itemAllTagsFilter != null)
			{
				int hashCode12 = itemAllTagsFilter.GetHashCode();
			}
			ItemAnyTagFilter itemAnyTagFilter = anyTag_;
			if (itemAnyTagFilter != null)
			{
				int hashCode13 = itemAnyTagFilter.GetHashCode();
			}
			ItemSeedFilter itemSeedFilter = seed_;
			if (itemSeedFilter != null)
			{
				int hashCode14 = itemSeedFilter.GetHashCode();
			}
			ItemMealFilter itemMealFilter = meal_;
			if (itemMealFilter != null)
			{
				int hashCode15 = itemMealFilter.GetHashCode();
			}
			ItemAvailableInStall itemAvailableInStall = inStall_;
			if (itemAvailableInStall != null)
			{
				int hashCode16 = itemAvailableInStall.GetHashCode();
			}
			ItemGridFilter itemGridFilter = grid_;
			if (itemGridFilter != null)
			{
				int hashCode17 = itemGridFilter.GetHashCode();
			}
			ItemCurrencyFilter itemCurrencyFilter = currency_;
			if (itemCurrencyFilter != null)
			{
				int hashCode18 = itemCurrencyFilter.GetHashCode();
			}
			if (min_ != 0)
			{
			}
			if (max_ != 0)
			{
			}
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001286")]
		[Cpp2IlInjected.Address(RVA = "0x25DB170", Offset = "0x25D9B70", VA = "0x1825DB170", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001287")]
		[Cpp2IlInjected.Address(RVA = "0x25DB1D0", Offset = "0x25D9BD0", VA = "0x1825DB1D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0226
			if ((long)id_ != 0)
			{
				ItemIdFilter value = id_;
				output.WriteMessage(value);
			}
			if ((long)type_ != 0)
			{
				ItemTypeFilter value2 = type_;
				output.WriteMessage(value2);
			}
			if ((long)subType_ != 0)
			{
				ItemSubTypeFilter value3 = subType_;
				output.WriteMessage(value3);
			}
			if ((long)quality_ != 0)
			{
				ItemQualityFilter value4 = quality_;
				output.WriteMessage(value4);
			}
			if ((long)complexity_ != 0)
			{
				ItemComplexityFilter value5 = complexity_;
				output.WriteMessage(value5);
			}
			if ((long)mood_ != 0)
			{
				ItemMoodFilter value6 = mood_;
				output.WriteMessage(value6);
			}
			if ((long)sturdiness_ != 0)
			{
				ItemSturdinessFilter value7 = sturdiness_;
				output.WriteMessage(value7);
			}
			if ((long)normality_ != 0)
			{
				ItemNormalityFilter value8 = normality_;
				output.WriteMessage(value8);
			}
			if ((long)minRarity_ != 0)
			{
				ItemMinRarityFilter value9 = minRarity_;
				output.WriteMessage(value9);
			}
			if ((long)maxRarity_ != 0)
			{
				ItemMaxRarityFilter value10 = maxRarity_;
				output.WriteMessage(value10);
			}
			if ((long)rarity_ != 0)
			{
				ItemRarityFilter value11 = rarity_;
				output.WriteMessage(value11);
			}
			if ((long)allTags_ != 0)
			{
				ItemAllTagsFilter value12 = allTags_;
				output.WriteMessage(value12);
			}
			if ((long)anyTag_ != 0)
			{
				ItemAnyTagFilter value13 = anyTag_;
				output.WriteMessage(value13);
			}
			if ((long)seed_ != 0)
			{
				ItemSeedFilter value14 = seed_;
				output.WriteMessage(value14);
			}
			if ((long)meal_ != 0)
			{
				ItemMealFilter value15 = meal_;
				output.WriteMessage(value15);
			}
			if ((long)inStall_ != 0)
			{
				ItemAvailableInStall value16 = inStall_;
				output.WriteMessage(value16);
			}
			if ((long)grid_ != 0)
			{
				ItemGridFilter value17 = grid_;
				output.WriteMessage(value17);
			}
			if ((long)currency_ != 0)
			{
				ItemCurrencyFilter value18 = currency_;
				output.WriteMessage(value18);
			}
			if (min_ != 0)
			{
				int value19 = min_;
				output.WriteInt32(value19);
			}
			if (max_ != 0)
			{
				int value20 = max_;
				output.WriteInt32(value20);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001288")]
		[Cpp2IlInjected.Address(RVA = "0x25D7D00", Offset = "0x25D6700", VA = "0x1825D7D00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2 = default(int);
			UnknownFieldSet unknownFields;
			do
			{
				ItemIdFilter itemIdFilter = id_;
				int num = 0;
				if (itemIdFilter != null)
				{
					num2 = CodedOutputStream.ComputeMessageSize(itemIdFilter) + 1;
				}
				ItemTypeFilter itemTypeFilter = type_;
				if (itemTypeFilter != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(itemTypeFilter);
					num3++;
					num2 += num3;
				}
				ItemSubTypeFilter itemSubTypeFilter = subType_;
				if (itemSubTypeFilter != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(itemSubTypeFilter);
					num4++;
					num2 += num4;
				}
				ItemQualityFilter itemQualityFilter = quality_;
				if (itemQualityFilter != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(itemQualityFilter);
					num5++;
					num2 += num5;
				}
				ItemComplexityFilter itemComplexityFilter = complexity_;
				if (itemComplexityFilter != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(itemComplexityFilter);
					num6++;
					num2 += num6;
				}
				ItemMoodFilter itemMoodFilter = mood_;
				if (itemMoodFilter != null)
				{
					int num7 = CodedOutputStream.ComputeMessageSize(itemMoodFilter);
					num7++;
					num2 += num7;
				}
				ItemSturdinessFilter itemSturdinessFilter = sturdiness_;
				if (itemSturdinessFilter != null)
				{
					int num8 = CodedOutputStream.ComputeMessageSize(itemSturdinessFilter);
					num8++;
					num2 += num8;
				}
				ItemNormalityFilter itemNormalityFilter = normality_;
				if (itemNormalityFilter != null)
				{
					int num9 = CodedOutputStream.ComputeMessageSize(itemNormalityFilter);
					num9++;
					num2 += num9;
				}
				ItemMinRarityFilter itemMinRarityFilter = minRarity_;
				if (itemMinRarityFilter != null)
				{
					int num10 = CodedOutputStream.ComputeMessageSize(itemMinRarityFilter);
					num10++;
					num2 += num10;
				}
				ItemMaxRarityFilter itemMaxRarityFilter = maxRarity_;
				if (itemMaxRarityFilter != null)
				{
					int num11 = CodedOutputStream.ComputeMessageSize(itemMaxRarityFilter);
					num11++;
					num2 += num11;
				}
				ItemRarityFilter itemRarityFilter = rarity_;
				if (itemRarityFilter != null)
				{
					int num12 = CodedOutputStream.ComputeMessageSize(itemRarityFilter);
					num12++;
					num2 += num12;
				}
				ItemAllTagsFilter itemAllTagsFilter = allTags_;
				if (itemAllTagsFilter != null)
				{
					int num13 = CodedOutputStream.ComputeMessageSize(itemAllTagsFilter);
					num13++;
					num2 += num13;
				}
				ItemAnyTagFilter itemAnyTagFilter = anyTag_;
				if (itemAnyTagFilter != null)
				{
					int num14 = CodedOutputStream.ComputeMessageSize(itemAnyTagFilter);
					num14++;
					num2 += num14;
				}
				ItemSeedFilter itemSeedFilter = seed_;
				if (itemSeedFilter != null)
				{
					int num15 = CodedOutputStream.ComputeMessageSize(itemSeedFilter);
					num15++;
					num2 += num15;
				}
				ItemMealFilter itemMealFilter = meal_;
				if (itemMealFilter != null)
				{
					int num16 = CodedOutputStream.ComputeMessageSize(itemMealFilter);
					num16++;
					num2 += num16;
				}
				ItemAvailableInStall itemAvailableInStall = inStall_;
				if (itemAvailableInStall != null)
				{
					int num17 = CodedOutputStream.ComputeMessageSize(itemAvailableInStall);
					num17 += 2;
					num2 += num17;
				}
				ItemGridFilter itemGridFilter = grid_;
				if (itemGridFilter != null)
				{
					int num18 = CodedOutputStream.ComputeMessageSize(itemGridFilter);
					num18 += 2;
					num2 += num18;
				}
				ItemCurrencyFilter itemCurrencyFilter = currency_;
				if (itemCurrencyFilter != null)
				{
					int num19 = CodedOutputStream.ComputeMessageSize(itemCurrencyFilter);
					num19 += 2;
					num2 += num19;
				}
				int num20 = min_;
				if (num20 != 0)
				{
					int num21 = CodedOutputStream.ComputeInt32Size(num20);
					num21 += 2;
					num2 += num21;
				}
				int num22 = max_;
				if (num22 != 0)
				{
					int num23 = CodedOutputStream.ComputeInt32Size(num22);
					num23 += 2;
					num2 += num23;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num24 = unknownFields.CalculateSize();
			return num24 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001289")]
		[Cpp2IlInjected.Address(RVA = "0x25D98E0", Offset = "0x25D82E0", VA = "0x1825D98E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemGenerator other)
		{
			//Discarded unreachable code: IL_0772
			//IL_04a1: Expected I4, but got I8
			if (other == null)
			{
				return;
			}
			ItemIdFilter itemIdFilter = other.id_;
			if (itemIdFilter != null)
			{
				ItemIdFilter itemIdFilter2 = id_;
				if (itemIdFilter2 == null)
				{
					ItemIdFilter itemIdFilter3 = (id_ = new ItemIdFilter());
					ItemIdFilter itemIdFilter4 = id_;
				}
				if (itemIdFilter != null)
				{
					RepeatedField<int> values_ = itemIdFilter2.values_;
					RepeatedField<int> values_2 = itemIdFilter.values_;
					((RepeatedField<T>)(object)values_).Add((IEnumerable<>)(object)values_2);
					UnknownFieldSet unknownFields = itemIdFilter._unknownFields;
					UnknownFieldSet unknownFieldSet = (itemIdFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemIdFilter2._unknownFields, unknownFields));
				}
			}
			if ((long)other.type_ != 0)
			{
				ItemTypeFilter itemTypeFilter2 = default(ItemTypeFilter);
				if (type_ == null)
				{
					ItemTypeFilter itemTypeFilter = (type_ = new ItemTypeFilter());
					itemTypeFilter2 = type_;
				}
				ItemTypeFilter other2 = other.type_;
				itemTypeFilter2.MergeFrom(other2);
			}
			if ((long)other.subType_ != 0)
			{
				ItemSubTypeFilter itemSubTypeFilter2 = default(ItemSubTypeFilter);
				if (subType_ == null)
				{
					ItemSubTypeFilter itemSubTypeFilter = (subType_ = new ItemSubTypeFilter());
					itemSubTypeFilter2 = subType_;
				}
				ItemSubTypeFilter other3 = other.subType_;
				itemSubTypeFilter2.MergeFrom(other3);
			}
			if (other.quality_ != null)
			{
				ItemQualityFilter itemQualityFilter2 = default(ItemQualityFilter);
				ItemQualityFilter itemQualityFilter3 = default(ItemQualityFilter);
				if (quality_ == null)
				{
					ItemQualityFilter itemQualityFilter = (quality_ = new ItemQualityFilter());
					itemQualityFilter2 = quality_;
					itemQualityFilter3 = other.quality_;
				}
				if (itemQualityFilter3 != null)
				{
					RepeatedField<Quality> values_3 = itemQualityFilter2.values_;
					RepeatedField<Quality> values_4 = itemQualityFilter3.values_;
					((RepeatedField<T>)(object)values_3).Add((IEnumerable<>)(object)values_4);
					UnknownFieldSet unknownFields2 = itemQualityFilter3._unknownFields;
					UnknownFieldSet unknownFieldSet2 = (itemQualityFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemQualityFilter2._unknownFields, unknownFields2));
				}
			}
			if ((long)other.complexity_ != 0)
			{
				ItemComplexityFilter itemComplexityFilter2 = default(ItemComplexityFilter);
				if (complexity_ == null)
				{
					ItemComplexityFilter itemComplexityFilter = (complexity_ = new ItemComplexityFilter());
					itemComplexityFilter2 = complexity_;
				}
				ItemComplexityFilter other4 = other.complexity_;
				itemComplexityFilter2.MergeFrom(other4);
			}
			if (other.mood_ != null)
			{
				ItemMoodFilter itemMoodFilter2 = default(ItemMoodFilter);
				ItemMoodFilter itemMoodFilter3 = default(ItemMoodFilter);
				if (mood_ == null)
				{
					ItemMoodFilter itemMoodFilter = (mood_ = new ItemMoodFilter());
					itemMoodFilter2 = mood_;
					itemMoodFilter3 = other.mood_;
				}
				if (itemMoodFilter3 != null)
				{
					RepeatedField<Mood> values_5 = itemMoodFilter2.values_;
					RepeatedField<Mood> values_6 = itemMoodFilter3.values_;
					((RepeatedField<T>)(object)values_5).Add((IEnumerable<>)(object)values_6);
					UnknownFieldSet unknownFields3 = itemMoodFilter3._unknownFields;
					UnknownFieldSet unknownFieldSet3 = (itemMoodFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemMoodFilter2._unknownFields, unknownFields3));
				}
			}
			if ((long)other.sturdiness_ != 0)
			{
				ItemSturdinessFilter itemSturdinessFilter2 = default(ItemSturdinessFilter);
				if (sturdiness_ == null)
				{
					ItemSturdinessFilter itemSturdinessFilter = (sturdiness_ = new ItemSturdinessFilter());
					itemSturdinessFilter2 = sturdiness_;
				}
				ItemSturdinessFilter other5 = other.sturdiness_;
				itemSturdinessFilter2.MergeFrom(other5);
			}
			if (other.normality_ != null)
			{
				ItemNormalityFilter itemNormalityFilter2 = default(ItemNormalityFilter);
				ItemNormalityFilter itemNormalityFilter3 = default(ItemNormalityFilter);
				if (normality_ == null)
				{
					ItemNormalityFilter itemNormalityFilter = (normality_ = new ItemNormalityFilter());
					itemNormalityFilter2 = normality_;
					itemNormalityFilter3 = other.normality_;
				}
				if (itemNormalityFilter3 != null)
				{
					RepeatedField<Normality> values_7 = itemNormalityFilter2.values_;
					RepeatedField<Normality> values_8 = itemNormalityFilter3.values_;
					((RepeatedField<T>)(object)values_7).Add((IEnumerable<>)(object)values_8);
					UnknownFieldSet unknownFields4 = itemNormalityFilter3._unknownFields;
					UnknownFieldSet unknownFieldSet4 = (itemNormalityFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemNormalityFilter2._unknownFields, unknownFields4));
				}
			}
			if (other.minRarity_ != null)
			{
				ItemMinRarityFilter itemMinRarityFilter2 = default(ItemMinRarityFilter);
				ItemMinRarityFilter itemMinRarityFilter3 = default(ItemMinRarityFilter);
				if (minRarity_ == null)
				{
					ItemMinRarityFilter itemMinRarityFilter = (minRarity_ = new ItemMinRarityFilter());
					itemMinRarityFilter2 = other.minRarity_;
					itemMinRarityFilter3 = minRarity_;
				}
				if (itemMinRarityFilter2 != null)
				{
					int value_ = itemMinRarityFilter2.value_;
					if (value_ != 0)
					{
						itemMinRarityFilter3.value_ = value_;
					}
					UnknownFieldSet unknownFields5 = itemMinRarityFilter2._unknownFields;
					UnknownFieldSet unknownFieldSet5 = (itemMinRarityFilter3._unknownFields = UnknownFieldSet.MergeFrom(itemMinRarityFilter3._unknownFields, unknownFields5));
				}
			}
			if (other.maxRarity_ != null)
			{
				ItemMaxRarityFilter itemMaxRarityFilter2 = default(ItemMaxRarityFilter);
				ItemMaxRarityFilter itemMaxRarityFilter3 = default(ItemMaxRarityFilter);
				if (maxRarity_ == null)
				{
					ItemMaxRarityFilter itemMaxRarityFilter = (maxRarity_ = new ItemMaxRarityFilter());
					itemMaxRarityFilter2 = other.maxRarity_;
					itemMaxRarityFilter3 = maxRarity_;
				}
				if (itemMaxRarityFilter2 != null)
				{
					int value_2 = itemMaxRarityFilter2.value_;
					if (value_2 != 0)
					{
						itemMaxRarityFilter3.value_ = value_2;
					}
					UnknownFieldSet unknownFields6 = itemMaxRarityFilter2._unknownFields;
					UnknownFieldSet unknownFieldSet6 = (itemMaxRarityFilter3._unknownFields = UnknownFieldSet.MergeFrom(itemMaxRarityFilter3._unknownFields, unknownFields6));
				}
			}
			if (other.rarity_ != null)
			{
				ItemRarityFilter itemRarityFilter2 = default(ItemRarityFilter);
				ItemRarityFilter itemRarityFilter3 = default(ItemRarityFilter);
				if (rarity_ == null)
				{
					ItemRarityFilter itemRarityFilter = (rarity_ = new ItemRarityFilter());
					itemRarityFilter2 = other.rarity_;
					itemRarityFilter3 = rarity_;
				}
				if (itemRarityFilter2 != null)
				{
					int value_3 = itemRarityFilter2.value_;
					if (value_3 != 0)
					{
						itemRarityFilter3.value_ = value_3;
					}
					UnknownFieldSet unknownFields7 = itemRarityFilter2._unknownFields;
					UnknownFieldSet unknownFieldSet7 = (itemRarityFilter3._unknownFields = UnknownFieldSet.MergeFrom(itemRarityFilter3._unknownFields, unknownFields7));
				}
			}
			if ((long)other.allTags_ != 0)
			{
				ItemAllTagsFilter itemAllTagsFilter2 = default(ItemAllTagsFilter);
				if (allTags_ == null)
				{
					ItemAllTagsFilter itemAllTagsFilter = (allTags_ = new ItemAllTagsFilter());
					itemAllTagsFilter2 = allTags_;
				}
				ItemAllTagsFilter other6 = other.allTags_;
				itemAllTagsFilter2.MergeFrom(other6);
			}
			if ((long)other.anyTag_ != 0)
			{
				ItemAnyTagFilter itemAnyTagFilter2 = default(ItemAnyTagFilter);
				if (anyTag_ == null)
				{
					ItemAnyTagFilter itemAnyTagFilter = (anyTag_ = new ItemAnyTagFilter());
					itemAnyTagFilter2 = anyTag_;
				}
				ItemAnyTagFilter other7 = other.anyTag_;
				itemAnyTagFilter2.MergeFrom(other7);
			}
			if (other.seed_ != null)
			{
				ItemSeedFilter itemSeedFilter2 = default(ItemSeedFilter);
				ItemSeedFilter itemSeedFilter3 = default(ItemSeedFilter);
				if (seed_ == null)
				{
					ItemSeedFilter itemSeedFilter = new ItemSeedFilter();
					itemSeedFilter.producedType_ = ActivityItemType.Crop;
					itemSeedFilter.hasProduct_ = true;
					seed_ = itemSeedFilter;
					itemSeedFilter2 = other.seed_;
					itemSeedFilter3 = seed_;
				}
				if (itemSeedFilter2 != null)
				{
					ActivityItemType producedType_ = itemSeedFilter2.producedType_;
					if (producedType_ != 0)
					{
						itemSeedFilter3.producedType_ = producedType_;
					}
					CropType cropType_ = itemSeedFilter2.cropType_;
					if (cropType_ != 0)
					{
						itemSeedFilter3.cropType_ = cropType_;
					}
					bool hasProduct_ = itemSeedFilter2.hasProduct_;
					if (hasProduct_)
					{
						itemSeedFilter3.hasProduct_ = hasProduct_;
					}
					UnknownFieldSet unknownFields8 = itemSeedFilter2._unknownFields;
					UnknownFieldSet unknownFieldSet8 = (itemSeedFilter3._unknownFields = UnknownFieldSet.MergeFrom(itemSeedFilter3._unknownFields, unknownFields8));
				}
			}
			if ((long)other.meal_ != 0)
			{
				ItemMealFilter itemMealFilter2 = default(ItemMealFilter);
				if (meal_ == null)
				{
					ItemMealFilter itemMealFilter = (meal_ = new ItemMealFilter());
					itemMealFilter2 = meal_;
				}
				ItemMealFilter itemMealFilter3 = other.meal_;
				if (itemMealFilter3 != null)
				{
					UnknownFieldSet unknownFields9 = itemMealFilter3._unknownFields;
					UnknownFieldSet unknownFieldSet9 = (itemMealFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemMealFilter2._unknownFields, unknownFields9));
				}
			}
			if ((long)other.inStall_ != 0)
			{
				ItemAvailableInStall itemAvailableInStall2 = default(ItemAvailableInStall);
				if (inStall_ == null)
				{
					ItemAvailableInStall itemAvailableInStall = (inStall_ = new ItemAvailableInStall());
					itemAvailableInStall2 = inStall_;
				}
				ItemAvailableInStall other8 = other.inStall_;
				itemAvailableInStall2.MergeFrom(other8);
			}
			if (other.grid_ != null)
			{
				ItemGridFilter itemGridFilter2 = default(ItemGridFilter);
				ItemGridFilter itemGridFilter3 = default(ItemGridFilter);
				if (grid_ == null)
				{
					ItemGridFilter itemGridFilter = (grid_ = new ItemGridFilter());
					itemGridFilter2 = grid_;
					itemGridFilter3 = other.grid_;
				}
				if (itemGridFilter3 != null)
				{
					if ((long)itemGridFilter3.minAreaSize_ != 0)
					{
						AreaSize minAreaSize_ = default(AreaSize);
						if (itemGridFilter2.minAreaSize_ == null)
						{
							AreaSize areaSize = (itemGridFilter2.minAreaSize_ = new AreaSize());
							minAreaSize_ = itemGridFilter2.minAreaSize_;
						}
						AreaSize minAreaSize_2 = itemGridFilter3.minAreaSize_;
						minAreaSize_.MergeFrom(minAreaSize_2);
					}
					if ((long)itemGridFilter3.maxAreaSize_ != 0)
					{
						AreaSize maxAreaSize_ = default(AreaSize);
						if (itemGridFilter2.maxAreaSize_ == null)
						{
							AreaSize areaSize2 = (itemGridFilter2.maxAreaSize_ = new AreaSize());
							maxAreaSize_ = itemGridFilter2.maxAreaSize_;
						}
						AreaSize maxAreaSize_2 = itemGridFilter3.maxAreaSize_;
						maxAreaSize_.MergeFrom(maxAreaSize_2);
					}
					bool canRotate_ = itemGridFilter3.canRotate_;
					if (canRotate_)
					{
						itemGridFilter2.canRotate_ = canRotate_;
					}
					GridSizeQualifier sizeQualifier_ = itemGridFilter3.sizeQualifier_;
					if (sizeQualifier_ != 0)
					{
						itemGridFilter2.sizeQualifier_ = sizeQualifier_;
					}
					RepeatedField<int> ignoreSizeForTags_ = itemGridFilter2.ignoreSizeForTags_;
					RepeatedField<int> ignoreSizeForTags_2 = itemGridFilter3.ignoreSizeForTags_;
					((RepeatedField<T>)(object)ignoreSizeForTags_).Add((IEnumerable<>)(object)ignoreSizeForTags_2);
					UnknownFieldSet unknownFields10 = itemGridFilter3._unknownFields;
					UnknownFieldSet unknownFieldSet10 = (itemGridFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemGridFilter2._unknownFields, unknownFields10));
				}
			}
			if ((long)other.currency_ != 0)
			{
				ItemCurrencyFilter itemCurrencyFilter2 = default(ItemCurrencyFilter);
				if (currency_ == null)
				{
					ItemCurrencyFilter itemCurrencyFilter = (currency_ = new ItemCurrencyFilter());
					itemCurrencyFilter2 = currency_;
				}
				ItemCurrencyFilter other9 = other.currency_;
				itemCurrencyFilter2.MergeFrom(other9);
			}
			int num = other.min_;
			if (num != 0)
			{
				min_ = num;
			}
			int num2 = other.max_;
			if (num2 != 0)
			{
				max_ = num2;
			}
			UnknownFieldSet unknownFields11 = other._unknownFields;
			UnknownFieldSet unknownFieldSet11 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields11));
		}

		[Cpp2IlInjected.Token(Token = "0x600128A")]
		[Cpp2IlInjected.Address(RVA = "0x25DA3F0", Offset = "0x25D8DF0", VA = "0x1825DA3F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0415
			//IL_0144: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 82)
			{
				if ((int)num > 122)
				{
					if ((int)num > 138)
					{
						if (num == 146)
						{
							ItemCurrencyFilter itemCurrencyFilter = currency_;
							if (itemCurrencyFilter == null)
							{
								ItemCurrencyFilter itemCurrencyFilter2 = (currency_ = new ItemCurrencyFilter());
							}
							input.ReadMessage(itemCurrencyFilter);
						}
						int num2 = default(int);
						if (num == 800)
						{
							num2 = (min_ = input.ReadInt32());
						}
						if (num2 != 808)
						{
							goto IL_03fe;
						}
						int num3 = (max_ = input.ReadInt32());
					}
					ItemAvailableInStall itemAvailableInStall = default(ItemAvailableInStall);
					if (num == 130)
					{
						ItemAvailableInStall builder = default(ItemAvailableInStall);
						if (inStall_ == null)
						{
							itemAvailableInStall = (inStall_ = new ItemAvailableInStall());
							builder = inStall_;
						}
						input.ReadMessage(builder);
					}
					if ((long)itemAvailableInStall != 138)
					{
						goto IL_03fe;
					}
					ItemGridFilter builder2 = default(ItemGridFilter);
					if (grid_ == null)
					{
						ItemGridFilter itemGridFilter = (grid_ = new ItemGridFilter());
						builder2 = grid_;
					}
					input.ReadMessage(builder2);
				}
				ItemMealFilter itemMealFilter = default(ItemMealFilter);
				if ((int)num > 98)
				{
					ItemAnyTagFilter itemAnyTagFilter = default(ItemAnyTagFilter);
					if (num == 106)
					{
						ItemAnyTagFilter builder3 = default(ItemAnyTagFilter);
						if (anyTag_ == null)
						{
							itemAnyTagFilter = (anyTag_ = new ItemAnyTagFilter());
							builder3 = anyTag_;
						}
						input.ReadMessage(builder3);
					}
					ItemSeedFilter itemSeedFilter = default(ItemSeedFilter);
					if ((long)itemAnyTagFilter == 114)
					{
						ItemSeedFilter builder4 = default(ItemSeedFilter);
						if (seed_ == null)
						{
							itemSeedFilter = new ItemSeedFilter();
							itemSeedFilter.producedType_ = ActivityItemType.Crop;
							itemSeedFilter.hasProduct_ = true;
							seed_ = itemSeedFilter;
							builder4 = seed_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)itemSeedFilter != 122)
					{
						goto IL_03fe;
					}
					ItemMealFilter builder5 = default(ItemMealFilter);
					if (meal_ == null)
					{
						itemMealFilter = (meal_ = new ItemMealFilter());
						builder5 = meal_;
					}
					input.ReadMessage(builder5);
				}
				ItemRarityFilter itemRarityFilter = default(ItemRarityFilter);
				if ((long)itemMealFilter == 90)
				{
					ItemRarityFilter builder6 = default(ItemRarityFilter);
					if (rarity_ == null)
					{
						itemRarityFilter = (rarity_ = new ItemRarityFilter());
						builder6 = rarity_;
					}
					input.ReadMessage(builder6);
				}
				if ((long)itemRarityFilter != 98)
				{
					goto IL_03fe;
				}
				ItemAllTagsFilter builder7 = default(ItemAllTagsFilter);
				if (allTags_ == null)
				{
					ItemAllTagsFilter itemAllTagsFilter = (allTags_ = new ItemAllTagsFilter());
					builder7 = allTags_;
				}
				input.ReadMessage(builder7);
			}
			ItemSturdinessFilter itemSturdinessFilter = default(ItemSturdinessFilter);
			if ((int)num > 42)
			{
				ItemMaxRarityFilter itemMaxRarityFilter = default(ItemMaxRarityFilter);
				if ((int)num > 58)
				{
					ItemNormalityFilter itemNormalityFilter = default(ItemNormalityFilter);
					if (num == 66)
					{
						ItemNormalityFilter builder8 = default(ItemNormalityFilter);
						if (normality_ == null)
						{
							itemNormalityFilter = (normality_ = new ItemNormalityFilter());
							builder8 = normality_;
						}
						input.ReadMessage(builder8);
					}
					ItemMinRarityFilter itemMinRarityFilter = default(ItemMinRarityFilter);
					if ((long)itemNormalityFilter == 74)
					{
						ItemMinRarityFilter builder9 = default(ItemMinRarityFilter);
						if (minRarity_ == null)
						{
							itemMinRarityFilter = (minRarity_ = new ItemMinRarityFilter());
							builder9 = minRarity_;
						}
						input.ReadMessage(builder9);
					}
					if ((long)itemMinRarityFilter != 82)
					{
						goto IL_03fe;
					}
					ItemMaxRarityFilter builder10 = default(ItemMaxRarityFilter);
					if (maxRarity_ == null)
					{
						itemMaxRarityFilter = (maxRarity_ = new ItemMaxRarityFilter());
						builder10 = maxRarity_;
					}
					input.ReadMessage(builder10);
				}
				ItemMoodFilter itemMoodFilter = default(ItemMoodFilter);
				if ((long)itemMaxRarityFilter == 50)
				{
					ItemMoodFilter builder11 = default(ItemMoodFilter);
					if (mood_ == null)
					{
						itemMoodFilter = (mood_ = new ItemMoodFilter());
						builder11 = mood_;
					}
					input.ReadMessage(builder11);
				}
				if ((long)itemMoodFilter != 58)
				{
					goto IL_03fe;
				}
				ItemSturdinessFilter builder12 = default(ItemSturdinessFilter);
				if (sturdiness_ == null)
				{
					itemSturdinessFilter = (sturdiness_ = new ItemSturdinessFilter());
					builder12 = sturdiness_;
				}
				input.ReadMessage(builder12);
			}
			ItemComplexityFilter itemComplexityFilter = default(ItemComplexityFilter);
			if ((long)itemSturdinessFilter > 18)
			{
				ItemSubTypeFilter itemSubTypeFilter = default(ItemSubTypeFilter);
				if ((long)itemSturdinessFilter == 26)
				{
					ItemSubTypeFilter builder13 = default(ItemSubTypeFilter);
					if (subType_ == null)
					{
						itemSubTypeFilter = (subType_ = new ItemSubTypeFilter());
						builder13 = subType_;
					}
					input.ReadMessage(builder13);
				}
				ItemQualityFilter itemQualityFilter = default(ItemQualityFilter);
				if ((long)itemSubTypeFilter == 34)
				{
					ItemQualityFilter builder14 = default(ItemQualityFilter);
					if (quality_ == null)
					{
						itemQualityFilter = (quality_ = new ItemQualityFilter());
						builder14 = quality_;
					}
					input.ReadMessage(builder14);
				}
				if ((long)itemQualityFilter != 42)
				{
					goto IL_03fe;
				}
				ItemComplexityFilter builder15 = default(ItemComplexityFilter);
				if (complexity_ == null)
				{
					itemComplexityFilter = (complexity_ = new ItemComplexityFilter());
					builder15 = complexity_;
				}
				input.ReadMessage(builder15);
			}
			ItemIdFilter itemIdFilter = default(ItemIdFilter);
			if ((long)itemComplexityFilter == 10)
			{
				ItemIdFilter builder16 = default(ItemIdFilter);
				if (id_ == null)
				{
					itemIdFilter = (id_ = new ItemIdFilter());
					builder16 = id_;
				}
				input.ReadMessage(builder16);
			}
			if ((long)itemIdFilter == 18)
			{
				ItemTypeFilter builder17 = default(ItemTypeFilter);
				if (type_ == null)
				{
					ItemTypeFilter itemTypeFilter = (type_ = new ItemTypeFilter());
					builder17 = type_;
				}
				input.ReadMessage(builder17);
			}
			goto IL_03fe;
			IL_03fe:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600128B")]
		[Cpp2IlInjected.Address(RVA = "0x25D8BE0", Offset = "0x25D75E0", VA = "0x1825D8BE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 17)
			{
				ItemIdFilter itemIdFilter = id_;
			}
			if (fieldNumber == 100)
			{
				int num = min_;
			}
			if (fieldNumber == 101)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600128C")]
		[Cpp2IlInjected.Address(RVA = "0x25DABA0", Offset = "0x25D95A0", VA = "0x1825DABA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e, IL_003a, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0
			//IL_0018: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_002d: Expected I4, but got O
			if (fieldNumber - 1 <= 17)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				id_ = (ItemIdFilter)num;
			}
			else if (fieldNumber == 100)
			{
				object obj = default(object);
				min_ = (int)obj;
			}
			else
			{
				object obj2 = default(object);
				max_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600128D")]
		[Cpp2IlInjected.Address(RVA = "0x25D81A0", Offset = "0x25D6BA0", VA = "0x1825D81A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0025
			//IL_0015: Expected I4, but got I8
			//IL_0024: Expected I4, but got I8
			if (fieldNumber - 1 <= 17)
			{
			}
			switch (fieldNumber)
			{
			case 100:
				min_ = 0;
				break;
			case 101:
				max_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600128E")]
		[Cpp2IlInjected.Address(RVA = "0x25D8420", Offset = "0x25D6E20", VA = "0x1825D8420")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_000f
			//IL_000c: Expected O, but got I4
			int num = 0;
			List<ItemWithState> filteredItemList = (List<ItemWithState>)(object)this.GetFilteredItemList(ref playerProfile, ref worldProfile, (List<>)(object)items, (ExtraFilterInfo)num);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600128F")]
		[Cpp2IlInjected.Address(RVA = "0x25D9850", Offset = "0x25D8250", VA = "0x1825D9850")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items, ExtraFilterInfo extraFilter)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001290")]
		[Cpp2IlInjected.Address(RVA = "0x25D83F0", Offset = "0x25D6DF0", VA = "0x1825D83F0")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			int num = 0;
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001291")]
		[Cpp2IlInjected.Address(RVA = "0x25D8A80", Offset = "0x25D7480", VA = "0x1825D8A80")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, ExtraFilterInfo extraFilter, [Optional] List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_002c
			List<ItemWithState> list = default(List<ItemWithState>);
			List<ItemWithState> filteredItems = list;
			List<ItemWithState> list2 = filteredItems;
			Func<ItemWithState> func = (Func<ItemWithState>)(object)(Func<TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001292")]
		[Cpp2IlInjected.Address(RVA = "0x25D8740", Offset = "0x25D7140", VA = "0x1825D8740")]
		public IReward GenerateByWeight(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, WeightInfo weightInfo, [Optional] ExtraFilterInfo extraFilter, [Optional] List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0033
			//IL_000d: Expected O, but got I4
			WeightInfo weightInfo2 = (WeightInfo)0;
			List<ItemWithState> list = default(List<ItemWithState>);
			List<ItemWithState> filteredItems = list;
			List<ItemWithState> list2 = filteredItems;
			Func<ItemWithState> func = (Func<ItemWithState>)(object)(Func<TResult>)delegate
			{
				//Discarded unreachable code: IL_00f0, IL_00f6, IL_00fc, IL_0102
				//IL_002c: Expected O, but got I4
				int num = 0;
				List<(ItemWithState, int)> list3 = (List<(ItemWithState, int)>)(object)new List<T>();
				List<ItemWithState> list4 = filteredItems;
				bool flag = default(bool);
				if (flag)
				{
					Dictionary<int, int> _003CWeightedItems_003Ek__BackingField = weightInfo2.WeightedItems;
					int num2 = 0;
					((List<T>)(object)list3).Add((T)num2);
				}
				num++;
				int num3 = 0;
				if (num != 0)
				{
				}
				Func<(ItemWithState, int), int> func2 = default(Func<(ItemWithState, int), int>);
				if (_003C_003Ec._003C_003E9__127_1 == null)
				{
					func2 = (Func<(ItemWithState, int), int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IOrderedEnumerable<(ItemWithState, int)> orderedEnumerable = (IOrderedEnumerable<(ItemWithState, int)>)Enumerable.OrderBy<(ItemWithState, int), int>((IEnumerable<>)list3, (Func<, >)(object)func2);
				Func<(ItemWithState, int), int> func3 = default(Func<(ItemWithState, int), int>);
				if (_003C_003Ec._003C_003E9__127_2 == null)
				{
					func3 = (Func<(ItemWithState, int), int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				int num4 = Enumerable.Sum<(ItemWithState, int)>((IEnumerable<>)orderedEnumerable, (Func<, >)(object)func3);
				uint num5 = default(uint);
				if (num3 < (int)num5)
				{
					num3 += num3;
					num3++;
				}
				int num7 = default(int);
				if (num4 != 0)
				{
					uint num6 = default(uint);
					if (num3 < (int)num6)
					{
						num3 += num3;
						if (num3 == (int)num6)
						{
							goto IL_00d9;
						}
						num3++;
					}
					num4 -= num3;
					num7++;
				}
				num7++;
				num4 += num4;
				goto IL_00d9;
				IL_00d9:
				if (num4 + num4 != 0)
				{
				}
				if (num7 != 0)
				{
				}
				throw new NullReferenceException();
			};
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001293")]
		[Cpp2IlInjected.Address(RVA = "0x25D88B0", Offset = "0x25D72B0", VA = "0x1825D88B0")]
		private IReward GenerateReward(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> filteredItems, Func<ItemWithState> searchReward)
		{
			//IL_0064: Expected O, but got I4
			ItemWithState itemWithState = default(ItemWithState);
			if (itemWithState != null)
			{
				ItemReward itemReward = new ItemReward();
				int num = (itemReward.id_ = itemWithState.itemID_);
				int num2 = max_;
				int minValue = min_;
				num2++;
				int num3 = (itemReward.amount_ = random.Next(minValue, num2));
				ItemState itemState = (itemReward.state_ = itemWithState.state_);
			}
			NullGenerator _003CDefault_003Ek__BackingField = NullGenerator.Default;
			int num4 = 0;
			IReward reward = _003CDefault_003Ek__BackingField.Generate(random, ref playerProfile, ref worldProfile, (List<>)num4);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001294")]
		[Cpp2IlInjected.Address(RVA = "0x25D8E30", Offset = "0x25D7830", VA = "0x1825D8E30")]
		public List<ItemWithState> GetFilteredItemList(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items, ExtraFilterInfo extraFilter)
		{
			//Discarded unreachable code: IL_0387, IL_038d, IL_0393
			int num = 0;
			ItemDatabase itemDb = ItemDatabase.Instance;
			if (items != null)
			{
				Func<ItemWithState, ItemWithState> _003C_003E9__129_ = _003C_003Ec._003C_003E9__129_0;
				if (_003C_003E9__129_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Clone());
				}
				if (Enumerable.ToList<ItemWithState>(Enumerable.Select<ItemWithState, ItemWithState>((IEnumerable<>)items, (Func<, >)(object)_003C_003E9__129_)) != null)
				{
					goto IL_0088;
				}
			}
			IEnumerable<IItemData> allItemsData = (IEnumerable<IItemData>)itemDb.get_AllItemsData();
			Func<IItemData, ItemWithState> func = default(Func<IItemData, ItemWithState>);
			if (_003C_003Ec._003C_003E9__129_1 == null)
			{
				func = (Func<IItemData, ItemWithState>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => new ItemWithState()));
			}
			List<ItemWithState> list = (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<IItemData, ItemWithState>((IEnumerable<>)allItemsData, (Func<, >)(object)func));
			goto IL_0088;
			IL_0088:
			List<ItemWithState> filteredItems = list;
			List<ItemWithState> list2 = filteredItems;
			Predicate<ItemWithState> predicate = default(Predicate<ItemWithState>);
			if (_003C_003Ec._003C_003E9__129_2 == null)
			{
				predicate = (Predicate<ItemWithState>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(ItemWithState x)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item item = x.Item;
					IItemData itemData = default(IItemData);
					if (itemData != null)
					{
						return itemData.IsNotBuyable();
					}
					throw new NullReferenceException();
				});
			}
			int num2 = ((List<T>)(object)list2).RemoveAll((Predicate<>)(object)predicate);
			ItemIdFilter itemIdFilter = id_;
			if (itemIdFilter != null)
			{
				List<ItemWithState> list3 = filteredItems;
				ItemDatabase itemDatabase = itemDb;
				((BaseItemFilter)itemIdFilter).Filter(itemDatabase, (List<>)(object)list3);
			}
			ItemTypeFilter itemTypeFilter = type_;
			if (itemTypeFilter != null)
			{
				List<ItemWithState> list4 = filteredItems;
				ItemDatabase itemDatabase2 = itemDb;
				((BaseItemFilter)itemTypeFilter).Filter(itemDatabase2, (List<>)(object)list4);
			}
			ItemSubTypeFilter itemSubTypeFilter = subType_;
			if (itemSubTypeFilter != null)
			{
				List<ItemWithState> list5 = filteredItems;
				ItemDatabase itemDatabase3 = itemDb;
				((BaseItemFilter)itemSubTypeFilter).Filter(itemDatabase3, (List<>)(object)list5);
			}
			ItemQualityFilter itemQualityFilter = quality_;
			if (itemQualityFilter != null)
			{
				List<ItemWithState> list6 = filteredItems;
				ItemDatabase itemDatabase4 = itemDb;
				((BaseItemFilter)itemQualityFilter).Filter(itemDatabase4, (List<>)(object)list6);
			}
			ItemComplexityFilter itemComplexityFilter = complexity_;
			if (itemComplexityFilter != null)
			{
				List<ItemWithState> list7 = filteredItems;
				ItemDatabase itemDatabase5 = itemDb;
				((BaseItemFilter)itemComplexityFilter).Filter(itemDatabase5, (List<>)(object)list7);
			}
			ItemMoodFilter itemMoodFilter = mood_;
			if (itemMoodFilter != null)
			{
				List<ItemWithState> list8 = filteredItems;
				ItemDatabase itemDatabase6 = itemDb;
				((BaseItemFilter)itemMoodFilter).Filter(itemDatabase6, (List<>)(object)list8);
			}
			ItemSturdinessFilter itemSturdinessFilter = sturdiness_;
			if (itemSturdinessFilter != null)
			{
				List<ItemWithState> list9 = filteredItems;
				ItemDatabase itemDatabase7 = itemDb;
				((BaseItemFilter)itemSturdinessFilter).Filter(itemDatabase7, (List<>)(object)list9);
			}
			ItemNormalityFilter itemNormalityFilter = normality_;
			if (itemNormalityFilter != null)
			{
				List<ItemWithState> list10 = filteredItems;
				ItemDatabase itemDatabase8 = itemDb;
				((BaseItemFilter)itemNormalityFilter).Filter(itemDatabase8, (List<>)(object)list10);
			}
			ItemRarityFilter itemRarityFilter = rarity_;
			if (itemRarityFilter != null)
			{
				List<ItemWithState> list11 = filteredItems;
				ItemDatabase itemDatabase9 = itemDb;
				((BaseItemFilter)itemRarityFilter).Filter(itemDatabase9, (List<>)(object)list11);
			}
			ItemAllTagsFilter itemAllTagsFilter = allTags_;
			if (itemAllTagsFilter != null)
			{
				List<ItemWithState> list12 = filteredItems;
				ItemDatabase itemDatabase10 = itemDb;
				((BaseItemFilter)itemAllTagsFilter).Filter(itemDatabase10, (List<>)(object)list12);
			}
			ItemAnyTagFilter itemAnyTagFilter = anyTag_;
			if (itemAnyTagFilter != null)
			{
				List<ItemWithState> list13 = filteredItems;
				ItemDatabase itemDatabase11 = itemDb;
				((BaseItemFilter)itemAnyTagFilter).Filter(itemDatabase11, (List<>)(object)list13);
			}
			ItemSeedFilter itemSeedFilter = seed_;
			if (itemSeedFilter != null)
			{
				List<ItemWithState> list14 = filteredItems;
				ItemDatabase itemDatabase12 = itemDb;
				((BaseItemFilter)itemSeedFilter).Filter(itemDatabase12, (List<>)(object)list14);
			}
			ItemMealFilter itemMealFilter = meal_;
			if (itemMealFilter != null)
			{
				List<ItemWithState> list15 = filteredItems;
				ItemDatabase itemDatabase13 = itemDb;
				((BaseItemFilter)itemMealFilter).Filter(itemDatabase13, (List<>)(object)list15);
			}
			ItemAvailableInStall itemAvailableInStall = inStall_;
			if (itemAvailableInStall != null)
			{
				List<ItemWithState> list16 = filteredItems;
				ItemDatabase itemDatabase14 = itemDb;
				((BaseItemFilter)itemAvailableInStall).Filter(itemDatabase14, (List<>)(object)list16);
			}
			ItemGridFilter itemGridFilter = grid_;
			if (itemGridFilter != null)
			{
				List<ItemWithState> list17 = filteredItems;
				ItemDatabase itemDatabase15 = itemDb;
				((BaseItemFilter)itemGridFilter).Filter(itemDatabase15, (List<>)(object)list17);
			}
			ItemCurrencyFilter itemCurrencyFilter = currency_;
			if (itemCurrencyFilter != null)
			{
				List<ItemWithState> list18 = filteredItems;
				ItemDatabase itemDatabase16 = itemDb;
				((BaseItemFilter)itemCurrencyFilter).Filter(itemDatabase16, (List<>)(object)list18);
			}
			if (predicate != null)
			{
				Action<IItemFilter> action = (Action<IItemFilter>)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_0008
					List<ItemWithState> list21 = filteredItems;
				};
			}
			Action<IItemFilter> action2 = (Action<IItemFilter>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				List<ItemWithState> list20 = filteredItems;
			};
			List<ItemWithState> list19 = filteredItems;
			ItemDatabase itemDatabase17 = itemDb;
			ItemMinLevelFilter itemMinLevelFilter = default(ItemMinLevelFilter);
			((BaseItemFilter)itemMinLevelFilter).Filter(itemDatabase17, (List<>)(object)list19);
			return filteredItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6001295")]
		[Cpp2IlInjected.Address(RVA = "0x25DB5B0", Offset = "0x25D9FB0", VA = "0x1825DB5B0")]
		static ItemGenerator()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001296")]
		[Cpp2IlInjected.Address(RVA = "0x25D83E0", Offset = "0x25D6DE0", VA = "0x1825D83E0", Slot = "16")]
		IReward IGeneratorFilter.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, ExtraFilterInfo extraFilter, List<ItemWithState> items)
		{
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001297")]
		[Cpp2IlInjected.Address(RVA = "0x25D8420", Offset = "0x25D6E20", VA = "0x1825D8420", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_000f
			//IL_000c: Expected O, but got I4
			int num = 0;
			List<ItemWithState> filteredItemList = (List<ItemWithState>)(object)this.GetFilteredItemList(ref playerProfile, ref worldProfile, (List<>)(object)items, (ExtraFilterInfo)num);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001298")]
		[Cpp2IlInjected.Address(RVA = "0x25D83F0", Offset = "0x25D6DF0", VA = "0x1825D83F0", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			int num = 0;
			IReward result = default(IReward);
			return result;
		}
	}
}
