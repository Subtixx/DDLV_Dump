using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	public sealed class AnyItemFilter : IMessage<AnyItemFilter>, IMessage, IEquatable<AnyItemFilter>, IDeepCloneable<AnyItemFilter>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001EA")]
		public enum FilterOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			Id,
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			Type,
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			SubType,
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			Quality,
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			Complexity,
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			Mood,
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			Sturdiness,
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			Normality,
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			MinRarity,
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			MaxRarity,
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			Rarity,
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			AllTags,
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			AnyTag,
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			Seed,
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			Meal,
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			Null,
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			InStall,
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			Grid,
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			Currency
		}

		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private static readonly MessageParser<AnyItemFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public const int SubTypeFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public const int QualityFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public const int ComplexityFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public const int MoodFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public const int SturdinessFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public const int NormalityFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public const int MinRarityFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public const int MaxRarityFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public const int RarityFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public const int AllTagsFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public const int AnyTagFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public const int SeedFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public const int MealFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public const int NullFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public const int InStallFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public const int GridFieldNumber = 18;

		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public const int CurrencyFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		private object filter_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private FilterOneofCase filterCase_;

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyItemFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001210")]
			[Cpp2IlInjected.Address(RVA = "0x26E9080", Offset = "0x26E7A80", VA = "0x1826E9080")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000409")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001211")]
			[Cpp2IlInjected.Address(RVA = "0x26E8C40", Offset = "0x26E7640", VA = "0x1826E8C40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001212")]
			[Cpp2IlInjected.Address(RVA = "0x26E9320", Offset = "0x26E7D20", VA = "0x1826E9320", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		[DebuggerNonUserCode]
		public ItemIdFilter Id
		{
			[Cpp2IlInjected.Token(Token = "0x6001216")]
			[Cpp2IlInjected.Address(RVA = "0x26E8D70", Offset = "0x26E7770", VA = "0x1826E8D70")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Id)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001217")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				filter_ = value;
				bool flag = (byte)(filterCase_ = ((value != null) ? FilterOneofCase.Id : FilterOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		[DebuggerNonUserCode]
		public ItemTypeFilter Type
		{
			[Cpp2IlInjected.Token(Token = "0x6001218")]
			[Cpp2IlInjected.Address(RVA = "0x26E92C0", Offset = "0x26E7CC0", VA = "0x1826E92C0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Type)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001219")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		[DebuggerNonUserCode]
		public ItemSubTypeFilter SubType
		{
			[Cpp2IlInjected.Token(Token = "0x600121A")]
			[Cpp2IlInjected.Address(RVA = "0x26E9260", Offset = "0x26E7C60", VA = "0x1826E9260")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.SubType)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600121B")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		[DebuggerNonUserCode]
		public ItemQualityFilter Quality
		{
			[Cpp2IlInjected.Token(Token = "0x600121C")]
			[Cpp2IlInjected.Address(RVA = "0x26E90E0", Offset = "0x26E7AE0", VA = "0x1826E90E0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Quality)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600121D")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		[DebuggerNonUserCode]
		public ItemComplexityFilter Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x600121E")]
			[Cpp2IlInjected.Address(RVA = "0x26E8AE0", Offset = "0x26E74E0", VA = "0x1826E8AE0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Complexity)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600121F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		[DebuggerNonUserCode]
		public ItemMoodFilter Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6001220")]
			[Cpp2IlInjected.Address(RVA = "0x26E8F60", Offset = "0x26E7960", VA = "0x1826E8F60")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Mood)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001221")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000411")]
		[DebuggerNonUserCode]
		public ItemSturdinessFilter Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6001222")]
			[Cpp2IlInjected.Address(RVA = "0x26E9200", Offset = "0x26E7C00", VA = "0x1826E9200")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Sturdiness)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001223")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000412")]
		[DebuggerNonUserCode]
		public ItemNormalityFilter Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6001224")]
			[Cpp2IlInjected.Address(RVA = "0x26E8FC0", Offset = "0x26E79C0", VA = "0x1826E8FC0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Normality)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001225")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E50", Offset = "0x5C4850", VA = "0x1805C5E50")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		[DebuggerNonUserCode]
		public ItemMinRarityFilter MinRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6001226")]
			[Cpp2IlInjected.Address(RVA = "0x26E8F00", Offset = "0x26E7900", VA = "0x1826E8F00")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.MinRarity)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001227")]
			[Cpp2IlInjected.Address(RVA = "0x1D17080", Offset = "0x1D15A80", VA = "0x181D17080")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000414")]
		[DebuggerNonUserCode]
		public ItemMaxRarityFilter MaxRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6001228")]
			[Cpp2IlInjected.Address(RVA = "0x26E8E40", Offset = "0x26E7840", VA = "0x1826E8E40")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.MaxRarity)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001229")]
			[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		[DebuggerNonUserCode]
		public ItemRarityFilter Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x600122A")]
			[Cpp2IlInjected.Address(RVA = "0x26E9140", Offset = "0x26E7B40", VA = "0x1826E9140")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Rarity)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600122B")]
			[Cpp2IlInjected.Address(RVA = "0x1D174F0", Offset = "0x1D15EF0", VA = "0x181D174F0")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000416")]
		[DebuggerNonUserCode]
		public ItemAllTagsFilter AllTags
		{
			[Cpp2IlInjected.Token(Token = "0x600122C")]
			[Cpp2IlInjected.Address(RVA = "0x26E8A20", Offset = "0x26E7420", VA = "0x1826E8A20")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.AllTags)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600122D")]
			[Cpp2IlInjected.Address(RVA = "0x1D16F80", Offset = "0x1D15980", VA = "0x181D16F80")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000417")]
		[DebuggerNonUserCode]
		public ItemAnyTagFilter AnyTag
		{
			[Cpp2IlInjected.Token(Token = "0x600122E")]
			[Cpp2IlInjected.Address(RVA = "0x26E8A80", Offset = "0x26E7480", VA = "0x1826E8A80")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.AnyTag)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600122F")]
			[Cpp2IlInjected.Address(RVA = "0x1D17040", Offset = "0x1D15A40", VA = "0x181D17040")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000418")]
		[DebuggerNonUserCode]
		public ItemSeedFilter Seed
		{
			[Cpp2IlInjected.Token(Token = "0x6001230")]
			[Cpp2IlInjected.Address(RVA = "0x26E91A0", Offset = "0x26E7BA0", VA = "0x1826E91A0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Seed)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001231")]
			[Cpp2IlInjected.Address(RVA = "0x1D17530", Offset = "0x1D15F30", VA = "0x181D17530")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000419")]
		[DebuggerNonUserCode]
		public ItemMealFilter Meal
		{
			[Cpp2IlInjected.Token(Token = "0x6001232")]
			[Cpp2IlInjected.Address(RVA = "0x26E8EA0", Offset = "0x26E78A0", VA = "0x1826E8EA0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Meal)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001233")]
			[Cpp2IlInjected.Address(RVA = "0x1D17000", Offset = "0x1D15A00", VA = "0x181D17000")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041A")]
		[DebuggerNonUserCode]
		public ItemNullFilter Null
		{
			[Cpp2IlInjected.Token(Token = "0x6001234")]
			[Cpp2IlInjected.Address(RVA = "0x26E9020", Offset = "0x26E7A20", VA = "0x1826E9020")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Null)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001235")]
			[Cpp2IlInjected.Address(RVA = "0x2028E80", Offset = "0x2027880", VA = "0x182028E80")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041B")]
		[DebuggerNonUserCode]
		public ItemAvailableInStall InStall
		{
			[Cpp2IlInjected.Token(Token = "0x6001236")]
			[Cpp2IlInjected.Address(RVA = "0x26E8DD0", Offset = "0x26E77D0", VA = "0x1826E8DD0")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.InStall)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001237")]
			[Cpp2IlInjected.Address(RVA = "0x2028F00", Offset = "0x2027900", VA = "0x182028F00")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041C")]
		[DebuggerNonUserCode]
		public ItemGridFilter Grid
		{
			[Cpp2IlInjected.Token(Token = "0x6001238")]
			[Cpp2IlInjected.Address(RVA = "0x26E8D10", Offset = "0x26E7710", VA = "0x1826E8D10")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Grid)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001239")]
			[Cpp2IlInjected.Address(RVA = "0x2028EC0", Offset = "0x20278C0", VA = "0x182028EC0")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041D")]
		[DebuggerNonUserCode]
		public ItemCurrencyFilter Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600123A")]
			[Cpp2IlInjected.Address(RVA = "0x26E8B40", Offset = "0x26E7540", VA = "0x1826E8B40")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Currency)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600123B")]
			[Cpp2IlInjected.Address(RVA = "0x2028D50", Offset = "0x2027750", VA = "0x182028D50")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041E")]
		[DebuggerNonUserCode]
		public FilterOneofCase FilterCase
		{
			[Cpp2IlInjected.Token(Token = "0x600123C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return filterCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041F")]
		[DebuggerNonUserCode]
		public IItemFilter ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600123E")]
			[Cpp2IlInjected.Address(RVA = "0x26E8E30", Offset = "0x26E7830", VA = "0x1826E8E30")]
			get
			{
				return GetFilter();
			}
			[Cpp2IlInjected.Token(Token = "0x600123F")]
			[Cpp2IlInjected.Address(RVA = "0x26E9430", Offset = "0x26E7E30", VA = "0x1826E9430")]
			set
			{
				SetFilter(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public IItemFilter DefaultFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600124F")]
			[Cpp2IlInjected.Address(RVA = "0x26E8BA0", Offset = "0x26E75A0", VA = "0x1826E8BA0")]
			get
			{
				ItemNullFilter _003CDefault_003Ek__BackingField = ItemNullFilter.Default;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001213")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AnyItemFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001214")]
		[Cpp2IlInjected.Address(RVA = "0x26E84F0", Offset = "0x26E6EF0", VA = "0x1826E84F0")]
		[DebuggerNonUserCode]
		public AnyItemFilter(AnyItemFilter other)
		{
			//IL_01b3: Expected I4, but got O
			if (other.filterCase_ <= FilterOneofCase.Grid)
			{
				bool flag = (byte)(filterCase_ = (((filter_ = other.Id.Clone()) != null) ? FilterOneofCase.Id : FilterOneofCase.None)) != 0;
				ItemTypeFilter itemTypeFilter = (ItemTypeFilter)(filter_ = other.Type.Clone());
				ItemSubTypeFilter itemSubTypeFilter = (ItemSubTypeFilter)(filter_ = other.SubType.Clone());
				ItemQualityFilter itemQualityFilter = (ItemQualityFilter)(filter_ = other.Quality.Clone());
				ItemComplexityFilter itemComplexityFilter = (ItemComplexityFilter)(filter_ = other.Complexity.Clone());
				ItemMoodFilter itemMoodFilter = (ItemMoodFilter)(filter_ = other.Mood.Clone());
				ItemSturdinessFilter itemSturdinessFilter = (ItemSturdinessFilter)(filter_ = other.Sturdiness.Clone());
				ItemNormalityFilter itemNormalityFilter = (ItemNormalityFilter)(filter_ = other.Normality.Clone());
				ItemMinRarityFilter itemMinRarityFilter = (ItemMinRarityFilter)(filter_ = other.MinRarity.Clone());
				ItemMaxRarityFilter itemMaxRarityFilter = (ItemMaxRarityFilter)(filter_ = other.MaxRarity.Clone());
				ItemRarityFilter itemRarityFilter = (ItemRarityFilter)(filter_ = other.Rarity.Clone());
				ItemAllTagsFilter itemAllTagsFilter = (ItemAllTagsFilter)(filter_ = other.AllTags.Clone());
				ItemAnyTagFilter itemAnyTagFilter = (ItemAnyTagFilter)(filter_ = other.AnyTag.Clone());
				ItemSeedFilter itemSeedFilter = (ItemSeedFilter)(filter_ = other.Seed.Clone());
				ItemMealFilter itemMealFilter = (ItemMealFilter)(filter_ = other.Meal.Clone());
				ItemNullFilter itemNullFilter = (ItemNullFilter)(filter_ = other.Null.Clone());
				ItemAvailableInStall itemAvailableInStall = (ItemAvailableInStall)(filter_ = other.InStall.Clone());
				ItemGridFilter itemGridFilter = (ItemGridFilter)(filter_ = other.Grid.Clone());
				filterCase_ = (FilterOneofCase)(filter_ = other.Currency.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001215")]
		[Cpp2IlInjected.Address(RVA = "0x26E4230", Offset = "0x26E2C30", VA = "0x1826E4230", Slot = "10")]
		[DebuggerNonUserCode]
		public AnyItemFilter Clone()
		{
			return new AnyItemFilter(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600123D")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearFilter()
		{
			//IL_0010: Expected O, but got I4
			filter_ = (filterCase_ = FilterOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001240")]
		[Cpp2IlInjected.Address(RVA = "0x26E48E0", Offset = "0x26E32E0", VA = "0x1826E48E0")]
		[DebuggerNonUserCode]
		public IItemFilter GetFilter()
		{
			if (filterCase_ <= FilterOneofCase.Grid)
			{
				ItemIdFilter id = Id;
				ItemTypeFilter type = Type;
				ItemSubTypeFilter subType = SubType;
				ItemQualityFilter quality = Quality;
				ItemComplexityFilter complexity = Complexity;
				ItemMoodFilter mood = Mood;
				ItemSturdinessFilter sturdiness = Sturdiness;
				ItemNormalityFilter normality = Normality;
				ItemMinRarityFilter minRarity = MinRarity;
				ItemMaxRarityFilter maxRarity = MaxRarity;
				ItemRarityFilter rarity = Rarity;
				ItemAllTagsFilter allTags = AllTags;
				ItemAnyTagFilter anyTag = AnyTag;
				ItemSeedFilter seed = Seed;
				ItemMealFilter meal = Meal;
				ItemNullFilter @null = Null;
				ItemAvailableInStall inStall = InStall;
				ItemGridFilter grid = Grid;
				ItemCurrencyFilter currency = Currency;
			}
			ItemNullFilter _003CDefault_003Ek__BackingField = ItemNullFilter.Default;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001241")]
		[Cpp2IlInjected.Address(RVA = "0x26E7590", Offset = "0x26E5F90", VA = "0x1826E7590")]
		[DebuggerNonUserCode]
		public void SetFilter(IItemFilter value)
		{
			//IL_0090: Expected I4, but got I8
			//IL_00a2: Expected I4, but got I8
			//IL_00b4: Expected I4, but got I8
			//IL_00c6: Expected I4, but got I8
			//IL_00d8: Expected I4, but got I8
			//IL_00ea: Expected I4, but got I8
			//IL_00fc: Expected I4, but got I8
			//IL_010e: Expected I4, but got I8
			//IL_0120: Expected I4, but got I8
			//IL_0132: Expected I4, but got I8
			//IL_0144: Expected I4, but got I8
			//IL_0155: Expected I4, but got I8
			//IL_0166: Expected I4, but got I8
			//IL_0177: Expected I4, but got I8
			//IL_0188: Expected I4, but got I8
			//IL_0199: Expected I4, but got I8
			//IL_01aa: Expected I4, but got I8
			//IL_01bb: Expected I4, but got I8
			//IL_01cc: Expected I4, but got I8
			//IL_01db: Expected O, but got I4
			int num = 0;
			if (value != null)
			{
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Id;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Type;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.SubType;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Quality;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Complexity;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Mood;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Sturdiness;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Normality;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.MinRarity;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.MaxRarity;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Rarity;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.AllTags;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.AnyTag;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Seed;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Meal;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Null;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.InStall;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Grid;
					return;
				}
				if (value != null)
				{
					filter_ = value;
					filterCase_ = FilterOneofCase.Currency;
					return;
				}
			}
			filterCase_ = (FilterOneofCase)num;
			filter_ = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001242")]
		[Cpp2IlInjected.Address(RVA = "0x26E46C0", Offset = "0x26E30C0", VA = "0x1826E46C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((AnyItemFilter)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001243")]
		[Cpp2IlInjected.Address(RVA = "0x26E4290", Offset = "0x26E2C90", VA = "0x1826E4290", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AnyItemFilter other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.Id)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
						goto IL_02a8;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.filterCase_ == FilterOneofCase.Id)
				{
					obj2 = other.filter_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemTypeFilter type = Type;
					ItemTypeFilter type2 = other.Type;
					if (object.Equals(type, type2))
					{
						ItemSubTypeFilter subType = SubType;
						ItemSubTypeFilter subType2 = other.SubType;
						if (object.Equals(subType, subType2))
						{
							ItemQualityFilter quality = Quality;
							ItemQualityFilter quality2 = other.Quality;
							if (object.Equals(quality, quality2))
							{
								ItemComplexityFilter complexity = Complexity;
								ItemComplexityFilter complexity2 = other.Complexity;
								if (object.Equals(complexity, complexity2))
								{
									ItemMoodFilter mood = Mood;
									ItemMoodFilter mood2 = other.Mood;
									if (object.Equals(mood, mood2))
									{
										ItemSturdinessFilter sturdiness = Sturdiness;
										ItemSturdinessFilter sturdiness2 = other.Sturdiness;
										if (object.Equals(sturdiness, sturdiness2))
										{
											ItemNormalityFilter normality = Normality;
											ItemNormalityFilter normality2 = other.Normality;
											if (object.Equals(normality, normality2))
											{
												ItemMinRarityFilter minRarity = MinRarity;
												ItemMinRarityFilter minRarity2 = other.MinRarity;
												if (object.Equals(minRarity, minRarity2))
												{
													ItemMaxRarityFilter maxRarity = MaxRarity;
													ItemMaxRarityFilter maxRarity2 = other.MaxRarity;
													if (object.Equals(maxRarity, maxRarity2))
													{
														ItemRarityFilter rarity = Rarity;
														ItemRarityFilter rarity2 = other.Rarity;
														if (object.Equals(rarity, rarity2))
														{
															ItemAllTagsFilter allTags = AllTags;
															ItemAllTagsFilter allTags2 = other.AllTags;
															if (object.Equals(allTags, allTags2))
															{
																ItemAnyTagFilter anyTag = AnyTag;
																ItemAnyTagFilter anyTag2 = other.AnyTag;
																if (object.Equals(anyTag, anyTag2))
																{
																	ItemSeedFilter seed = Seed;
																	ItemSeedFilter seed2 = other.Seed;
																	if (object.Equals(seed, seed2))
																	{
																		ItemMealFilter meal = Meal;
																		ItemMealFilter meal2 = other.Meal;
																		if (object.Equals(meal, meal2))
																		{
																			ItemNullFilter @null = Null;
																			ItemNullFilter null2 = other.Null;
																			if (object.Equals(@null, null2))
																			{
																				ItemAvailableInStall inStall = InStall;
																				ItemAvailableInStall inStall2 = other.InStall;
																				if (object.Equals(inStall, inStall2))
																				{
																					ItemGridFilter grid = Grid;
																					ItemGridFilter grid2 = other.Grid;
																					if (object.Equals(grid, grid2))
																					{
																						ItemCurrencyFilter currency = Currency;
																						ItemCurrencyFilter currency2 = other.Currency;
																						if (object.Equals(currency, currency2))
																						{
																							FilterOneofCase filterOneofCase = other.filterCase_;
																							if (filterCase_ == filterOneofCase)
																							{
																								UnknownFieldSet unknownFields = other._unknownFields;
																								bool flag = object.Equals(_unknownFields, unknownFields);
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
			int num2 = 0;
			goto IL_02a8;
			IL_02a8:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001244")]
		[Cpp2IlInjected.Address(RVA = "0x26E4AC0", Offset = "0x26E34C0", VA = "0x1826E4AC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_02ce
			while (true)
			{
				FilterOneofCase filterOneofCase = filterCase_;
				int num = 0;
				if (filterOneofCase == FilterOneofCase.Id)
				{
					object obj = filter_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (filterOneofCase != FilterOneofCase.Type)
				{
					continue;
				}
				object obj2 = filter_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (filterCase_ != FilterOneofCase.SubType)
					{
						continue;
					}
					object obj3 = filter_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (filterCase_ != FilterOneofCase.Quality)
						{
							continue;
						}
						object obj4 = filter_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (filterCase_ != FilterOneofCase.Complexity)
							{
								continue;
							}
							object obj5 = filter_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (filterCase_ != FilterOneofCase.Mood)
								{
									continue;
								}
								object obj6 = filter_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (filterCase_ != FilterOneofCase.Sturdiness)
									{
										continue;
									}
									object obj7 = filter_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (filterCase_ != FilterOneofCase.Normality)
										{
											continue;
										}
										object obj8 = filter_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (filterCase_ != FilterOneofCase.MinRarity)
											{
												continue;
											}
											object obj9 = filter_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (filterCase_ != FilterOneofCase.MaxRarity)
												{
													continue;
												}
												object obj10 = filter_;
												if (obj10 != null)
												{
													int hashCode10 = obj10.GetHashCode();
													if (filterCase_ != FilterOneofCase.Rarity)
													{
														continue;
													}
													object obj11 = filter_;
													if (obj11 != null)
													{
														int hashCode11 = obj11.GetHashCode();
														if (filterCase_ != FilterOneofCase.AllTags)
														{
															continue;
														}
														object obj12 = filter_;
														if (obj12 != null)
														{
															int hashCode12 = obj12.GetHashCode();
															if (filterCase_ != FilterOneofCase.AnyTag)
															{
																continue;
															}
															object obj13 = filter_;
															if (obj13 != null)
															{
																int hashCode13 = obj13.GetHashCode();
																if (filterCase_ != FilterOneofCase.Seed)
																{
																	continue;
																}
																object obj14 = filter_;
																if (obj14 != null)
																{
																	int hashCode14 = obj14.GetHashCode();
																	if (filterCase_ != FilterOneofCase.Meal)
																	{
																		continue;
																	}
																	object obj15 = filter_;
																	if (obj15 != null)
																	{
																		int hashCode15 = obj15.GetHashCode();
																		if (filterCase_ != FilterOneofCase.Null)
																		{
																			continue;
																		}
																		object obj16 = filter_;
																		if (obj16 != null)
																		{
																			int hashCode16 = obj16.GetHashCode();
																			if (filterCase_ != FilterOneofCase.InStall)
																			{
																				continue;
																			}
																			object obj17 = filter_;
																			if (obj17 != null)
																			{
																				int hashCode17 = obj17.GetHashCode();
																				if (filterCase_ != FilterOneofCase.Grid)
																				{
																					continue;
																				}
																				object obj18 = filter_;
																				if (obj18 != null)
																				{
																					int hashCode18 = obj18.GetHashCode();
																					if (filterCase_ == FilterOneofCase.Currency)
																					{
																						object obj19 = filter_;
																						if (obj19 == null)
																						{
																							break;
																						}
																						int hashCode19 = obj19.GetHashCode();
																					}
																					UnknownFieldSet unknownFields = _unknownFields;
																					if (unknownFields != null)
																					{
																						int hashCode20 = unknownFields.GetHashCode();
																					}
																					return 1;
																				}
																			}
																			throw new InvalidCastException();
																		}
																		throw new InvalidCastException();
																	}
																	throw new InvalidCastException();
																}
																throw new InvalidCastException();
															}
															throw new InvalidCastException();
														}
														throw new InvalidCastException();
													}
													throw new InvalidCastException();
												}
												throw new InvalidCastException();
											}
											throw new InvalidCastException();
										}
										throw new InvalidCastException();
									}
									throw new InvalidCastException();
								}
								throw new InvalidCastException();
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001245")]
		[Cpp2IlInjected.Address(RVA = "0x26E7A70", Offset = "0x26E6470", VA = "0x1826E7A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001246")]
		[Cpp2IlInjected.Address(RVA = "0x26E7AD0", Offset = "0x26E64D0", VA = "0x1826E7AD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_033e
			//IL_002f: Expected O, but got I4
			while (true)
			{
				FilterOneofCase filterOneofCase = filterCase_;
				int num = 0;
				if (filterOneofCase == FilterOneofCase.Id)
				{
					if (filterCase_ == FilterOneofCase.Id)
					{
						object obj = filter_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (filterOneofCase != FilterOneofCase.Type)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Type)
				{
					object obj2 = filter_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.SubType)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.SubType)
				{
					object obj3 = filter_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Quality)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Quality)
				{
					object obj4 = filter_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Complexity)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Complexity)
				{
					object obj5 = filter_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Mood)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Mood)
				{
					object obj6 = filter_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Sturdiness)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Sturdiness)
				{
					object obj7 = filter_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Normality)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Normality)
				{
					object obj8 = filter_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.MinRarity)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.MinRarity)
				{
					object obj9 = filter_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.MaxRarity)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.MaxRarity)
				{
					object obj10 = filter_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Rarity)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Rarity)
				{
					object obj11 = filter_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.AllTags)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.AllTags)
				{
					object obj12 = filter_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.AnyTag)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.AnyTag)
				{
					object obj13 = filter_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Seed)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Seed)
				{
					object obj14 = filter_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Meal)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Meal)
				{
					object obj15 = filter_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.Null)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Null)
				{
					object obj16 = filter_;
					if (obj16 != null && obj16 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ != FilterOneofCase.InStall)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.InStall)
				{
					object obj17 = filter_;
					if (obj17 != null && obj17 == null)
					{
						break;
					}
				}
				if (filterCase_ != FilterOneofCase.Grid)
				{
					continue;
				}
				if (filterCase_ == FilterOneofCase.Grid)
				{
					object obj18 = filter_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (filterCase_ == FilterOneofCase.Currency && filterCase_ == FilterOneofCase.Currency)
				{
					object obj19 = filter_;
					if (obj19 != null && obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001247")]
		[Cpp2IlInjected.Address(RVA = "0x26E3730", Offset = "0x26E2130", VA = "0x1826E3730", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (filterCase_ == FilterOneofCase.Id)
			{
				if (filterCase_ == FilterOneofCase.Id)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (filterCase_ == FilterOneofCase.Type)
			{
				if (filterCase_ != FilterOneofCase.Type)
				{
				}
				object obj2 = filter_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (filterCase_ == FilterOneofCase.SubType)
			{
				if (filterCase_ != FilterOneofCase.SubType)
				{
				}
				object obj3 = filter_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (filterCase_ == FilterOneofCase.Quality)
			{
				if (filterCase_ != FilterOneofCase.Quality)
				{
				}
				object obj4 = filter_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (filterCase_ == FilterOneofCase.Complexity)
			{
				if (filterCase_ != FilterOneofCase.Complexity)
				{
				}
				object obj5 = filter_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (filterCase_ == FilterOneofCase.Mood)
			{
				if (filterCase_ != FilterOneofCase.Mood)
				{
				}
				object obj6 = filter_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (filterCase_ == FilterOneofCase.Sturdiness)
			{
				if (filterCase_ != FilterOneofCase.Sturdiness)
				{
				}
				object obj7 = filter_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			if (filterCase_ == FilterOneofCase.Normality)
			{
				if (filterCase_ != FilterOneofCase.Normality)
				{
				}
				object obj8 = filter_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num9 = default(int);
				num += num9;
			}
			if (filterCase_ == FilterOneofCase.MinRarity)
			{
				if (filterCase_ != FilterOneofCase.MinRarity)
				{
				}
				object obj9 = filter_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num10 = default(int);
				num += num10;
			}
			if (filterCase_ == FilterOneofCase.MaxRarity)
			{
				if (filterCase_ != FilterOneofCase.MaxRarity)
				{
				}
				object obj10 = filter_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num11 = default(int);
				num += num11;
			}
			if (filterCase_ == FilterOneofCase.Rarity)
			{
				if (filterCase_ != FilterOneofCase.Rarity)
				{
				}
				object obj11 = filter_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num12 = default(int);
				num += num12;
			}
			if (filterCase_ == FilterOneofCase.AllTags)
			{
				if (filterCase_ != FilterOneofCase.AllTags)
				{
				}
				object obj12 = filter_;
				if (obj12 != null && obj12 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num13 = default(int);
				num += num13;
			}
			if (filterCase_ == FilterOneofCase.AnyTag)
			{
				if (filterCase_ != FilterOneofCase.AnyTag)
				{
				}
				object obj13 = filter_;
				if (obj13 != null && obj13 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num14 = default(int);
				num += num14;
			}
			if (filterCase_ == FilterOneofCase.Seed)
			{
				if (filterCase_ != FilterOneofCase.Seed)
				{
				}
				object obj14 = filter_;
				if (obj14 != null && obj14 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num15 = default(int);
				num += num15;
			}
			if (filterCase_ == FilterOneofCase.Meal)
			{
				if (filterCase_ != FilterOneofCase.Meal)
				{
				}
				object obj15 = filter_;
				if (obj15 != null && obj15 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num16 = default(int);
				num += num16;
			}
			if (filterCase_ == FilterOneofCase.Null)
			{
				if (filterCase_ != FilterOneofCase.Null)
				{
				}
				object obj16 = filter_;
				if (obj16 != null && obj16 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num17 = default(int);
				num += num17;
			}
			if (filterCase_ == FilterOneofCase.InStall)
			{
				if (filterCase_ != FilterOneofCase.InStall)
				{
				}
				object obj17 = filter_;
				if (obj17 != null && obj17 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num18 = default(int);
				num += num18;
			}
			if (filterCase_ == FilterOneofCase.Grid)
			{
				if (filterCase_ != FilterOneofCase.Grid)
				{
				}
				object obj18 = filter_;
				if (obj18 != null && obj18 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num19 = default(int);
				num += num19;
			}
			if (filterCase_ == FilterOneofCase.Currency)
			{
				if (filterCase_ == FilterOneofCase.Currency)
				{
					object obj19 = filter_;
					if (obj19 != null && obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num20 = default(int);
				num += num20;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num21 = unknownFields.CalculateSize();
				num += num21;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001248")]
		[Cpp2IlInjected.Address(RVA = "0x26E5410", Offset = "0x26E3E10", VA = "0x1826E5410", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyItemFilter other)
		{
			//Discarded unreachable code: IL_0068, IL_0071, IL_0088, IL_009e, IL_00b5, IL_00cb, IL_00e2, IL_00f8, IL_010f, IL_0125, IL_013c, IL_0152, IL_0169, IL_017f, IL_0196, IL_01ac, IL_01c3, IL_01d9, IL_01f0, IL_0206, IL_021d, IL_0233, IL_024a, IL_0260, IL_0277, IL_028d, IL_02a4, IL_02ba, IL_02d1, IL_02e7, IL_02fe, IL_0314, IL_032b, IL_0341, IL_0358, IL_036e, IL_0385
			//IL_0088: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			//IL_00e2: Expected I4, but got O
			//IL_010f: Expected I4, but got O
			//IL_013c: Expected I4, but got O
			//IL_0169: Expected I4, but got O
			//IL_0196: Expected I4, but got O
			//IL_01c3: Expected I4, but got O
			//IL_01f0: Expected I4, but got O
			//IL_021d: Expected I4, but got O
			//IL_024a: Expected I4, but got O
			//IL_0277: Expected I4, but got O
			//IL_02a4: Expected I4, but got O
			//IL_02d1: Expected I4, but got O
			//IL_02fe: Expected I4, but got O
			//IL_032b: Expected I4, but got O
			//IL_0358: Expected I4, but got O
			//IL_0385: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.filterCase_ <= FilterOneofCase.Grid)
			{
				if (Id == null)
				{
					bool flag = (byte)(filterCase_ = (((filter_ = new ItemIdFilter()) != null) ? FilterOneofCase.Id : FilterOneofCase.None)) != 0;
				}
				ItemIdFilter id = Id;
				ItemIdFilter id2 = other.Id;
				id.MergeFrom(id2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001249")]
		[Cpp2IlInjected.Address(RVA = "0x26E5E80", Offset = "0x26E4880", VA = "0x1826E5E80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0077: Expected I4, but got O
			//IL_00c8: Expected I4, but got O
			//IL_0124: Expected I4, but got O
			//IL_0175: Expected I4, but got O
			//IL_01d1: Expected I4, but got O
			//IL_022b: Expected I4, but got O
			//IL_0281: Expected I4, but got O
			//IL_02da: Expected I4, but got O
			//IL_0330: Expected I4, but got O
			//IL_0389: Expected I4, but got O
			//IL_03ea: Expected I4, but got O
			//IL_043e: Expected I4, but got O
			//IL_0497: Expected I4, but got O
			//IL_04eb: Expected I4, but got O
			//IL_0542: Expected I4, but got O
			//IL_05a4: Expected I4, but got O
			//IL_05fb: Expected I4, but got O
			//IL_06a4: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 74)
			{
				if ((int)num > 114)
				{
					if ((int)num > 130)
					{
						if (num == 138)
						{
							ItemAvailableInStall itemAvailableInStall = new ItemAvailableInStall();
							if (filterCase_ == FilterOneofCase.InStall)
							{
								if (filterCase_ != FilterOneofCase.InStall)
								{
								}
								object obj = filter_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(itemAvailableInStall);
							filter_ = itemAvailableInStall;
							filterCase_ = (FilterOneofCase)itemAvailableInStall;
						}
						if (num == 146)
						{
							ItemGridFilter builder = new ItemGridFilter();
							if (filterCase_ == FilterOneofCase.Grid)
							{
								if (filterCase_ != FilterOneofCase.Grid)
								{
								}
								object obj2 = filter_;
								if (obj2 != null && obj2 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder);
							filter_ = builder;
							filterCase_ = (FilterOneofCase)typeof(ItemGridFilter).TypeHandle;
						}
						if ((long)typeof(ItemGridFilter).TypeHandle != 154)
						{
							goto IL_06a4;
						}
						ItemCurrencyFilter builder2 = new ItemCurrencyFilter();
						if (filterCase_ == FilterOneofCase.Currency)
						{
							if (filterCase_ != FilterOneofCase.Currency)
							{
							}
							object obj3 = filter_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder2);
						filter_ = builder2;
						filterCase_ = (FilterOneofCase)typeof(ItemCurrencyFilter).TypeHandle;
					}
					if (num == 122)
					{
						ItemMealFilter builder3 = new ItemMealFilter();
						if (filterCase_ == FilterOneofCase.Meal)
						{
							if (filterCase_ != FilterOneofCase.Meal)
							{
							}
							object obj4 = filter_;
							if (obj4 != null && obj4 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder3);
						filter_ = builder3;
						filterCase_ = (FilterOneofCase)typeof(ItemMealFilter).TypeHandle;
					}
					if ((long)typeof(ItemMealFilter).TypeHandle != 130)
					{
						goto IL_06a4;
					}
					ItemNullFilter builder4 = new ItemNullFilter();
					if (filterCase_ == FilterOneofCase.Null)
					{
						if (filterCase_ != FilterOneofCase.Null)
						{
						}
						object obj5 = filter_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					filter_ = builder4;
					filterCase_ = (FilterOneofCase)typeof(ItemNullFilter).TypeHandle;
				}
				if ((int)num > 90)
				{
					if (num == 98)
					{
						ItemAllTagsFilter builder5 = new ItemAllTagsFilter();
						if (filterCase_ == FilterOneofCase.AllTags)
						{
							if (filterCase_ != FilterOneofCase.AllTags)
							{
							}
							object obj6 = filter_;
							if (obj6 != null && obj6 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder5);
						filter_ = builder5;
						filterCase_ = (FilterOneofCase)typeof(ItemAllTagsFilter).TypeHandle;
					}
					if ((long)typeof(ItemAllTagsFilter).TypeHandle == 106)
					{
						ItemAnyTagFilter builder6 = new ItemAnyTagFilter();
						if (filterCase_ == FilterOneofCase.AnyTag)
						{
							if (filterCase_ != FilterOneofCase.AnyTag)
							{
							}
							object obj7 = filter_;
							if (obj7 != null && obj7 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder6);
						filter_ = builder6;
						filterCase_ = (FilterOneofCase)typeof(ItemAnyTagFilter).TypeHandle;
					}
					if ((long)typeof(ItemAnyTagFilter).TypeHandle != 114)
					{
						goto IL_06a4;
					}
					ItemSeedFilter builder7 = new ItemSeedFilter();
					if (filterCase_ == FilterOneofCase.Seed)
					{
						if (filterCase_ != FilterOneofCase.Seed)
						{
						}
						object obj8 = filter_;
						if (obj8 != null && obj8 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder7);
					filter_ = builder7;
					filterCase_ = (FilterOneofCase)typeof(ItemSeedFilter).TypeHandle;
				}
				if ((long)typeof(ItemSeedFilter).TypeHandle == 82)
				{
					ItemMaxRarityFilter builder8 = new ItemMaxRarityFilter();
					if (filterCase_ == FilterOneofCase.MaxRarity)
					{
						if (filterCase_ != FilterOneofCase.MaxRarity)
						{
						}
						object obj9 = filter_;
						if (obj9 != null && obj9 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder8);
					filter_ = builder8;
					filterCase_ = (FilterOneofCase)typeof(ItemMaxRarityFilter).TypeHandle;
				}
				if ((long)typeof(ItemMaxRarityFilter).TypeHandle != 90)
				{
					goto IL_06a4;
				}
				ItemRarityFilter builder9 = new ItemRarityFilter();
				if (filterCase_ == FilterOneofCase.Rarity)
				{
					if (filterCase_ != FilterOneofCase.Rarity)
					{
					}
					object obj10 = filter_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder9);
				filter_ = builder9;
				filterCase_ = (FilterOneofCase)typeof(ItemRarityFilter).TypeHandle;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						ItemSturdinessFilter builder10 = new ItemSturdinessFilter();
						if (filterCase_ == FilterOneofCase.Sturdiness)
						{
							if (filterCase_ != FilterOneofCase.Sturdiness)
							{
							}
							object obj11 = filter_;
							if (obj11 != null && obj11 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder10);
						filter_ = builder10;
						filterCase_ = (FilterOneofCase)typeof(ItemSturdinessFilter).TypeHandle;
					}
					if ((long)typeof(ItemSturdinessFilter).TypeHandle == 66)
					{
						ItemNormalityFilter builder11 = new ItemNormalityFilter();
						if (filterCase_ == FilterOneofCase.Normality)
						{
							if (filterCase_ != FilterOneofCase.Normality)
							{
							}
							object obj12 = filter_;
							if (obj12 != null && obj12 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder11);
						filter_ = builder11;
						filterCase_ = (FilterOneofCase)typeof(ItemNormalityFilter).TypeHandle;
					}
					if ((long)typeof(ItemNormalityFilter).TypeHandle != 74)
					{
						goto IL_06a4;
					}
					ItemMinRarityFilter builder12 = new ItemMinRarityFilter();
					if (filterCase_ == FilterOneofCase.MinRarity)
					{
						if (filterCase_ != FilterOneofCase.MinRarity)
						{
						}
						object obj13 = filter_;
						if (obj13 != null && obj13 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder12);
					filter_ = builder12;
					filterCase_ = (FilterOneofCase)typeof(ItemMinRarityFilter).TypeHandle;
				}
				if ((long)typeof(ItemMinRarityFilter).TypeHandle == 42)
				{
					ItemComplexityFilter builder13 = new ItemComplexityFilter();
					if (filterCase_ == FilterOneofCase.Complexity)
					{
						if (filterCase_ != FilterOneofCase.Complexity)
						{
						}
						object obj14 = filter_;
						if (obj14 != null && obj14 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder13);
					filter_ = builder13;
					filterCase_ = (FilterOneofCase)typeof(ItemComplexityFilter).TypeHandle;
				}
				if ((long)typeof(ItemComplexityFilter).TypeHandle != 50)
				{
					goto IL_06a4;
				}
				ItemMoodFilter builder14 = new ItemMoodFilter();
				if (filterCase_ == FilterOneofCase.Mood)
				{
					if (filterCase_ != FilterOneofCase.Mood)
					{
					}
					object obj15 = filter_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder14);
				filter_ = builder14;
				filterCase_ = (FilterOneofCase)typeof(ItemMoodFilter).TypeHandle;
			}
			if ((long)typeof(ItemMoodFilter).TypeHandle > 18)
			{
				if ((long)typeof(ItemMoodFilter).TypeHandle == 26)
				{
					ItemSubTypeFilter builder15 = new ItemSubTypeFilter();
					if (filterCase_ == FilterOneofCase.SubType)
					{
						if (filterCase_ != FilterOneofCase.SubType)
						{
						}
						object obj16 = filter_;
						if (obj16 != null && obj16 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder15);
					filter_ = builder15;
					filterCase_ = (FilterOneofCase)typeof(ItemSubTypeFilter).TypeHandle;
				}
				if ((long)typeof(ItemSubTypeFilter).TypeHandle != 34)
				{
					goto IL_06a4;
				}
				ItemQualityFilter builder16 = new ItemQualityFilter();
				if (filterCase_ == FilterOneofCase.Quality)
				{
					if (filterCase_ != FilterOneofCase.Quality)
					{
					}
					object obj17 = filter_;
					if (obj17 != null && obj17 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder16);
				filter_ = builder16;
				filterCase_ = (FilterOneofCase)typeof(ItemQualityFilter).TypeHandle;
			}
			bool flag = default(bool);
			if ((long)typeof(ItemQualityFilter).TypeHandle == 10)
			{
				ItemIdFilter itemIdFilter = new ItemIdFilter();
				if (filterCase_ == FilterOneofCase.Id)
				{
					if (filterCase_ != FilterOneofCase.Id)
					{
					}
					object obj18 = filter_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemIdFilter);
				filter_ = itemIdFilter;
				flag = (byte)(filterCase_ = ((itemIdFilter != null) ? FilterOneofCase.Id : FilterOneofCase.None)) != 0;
			}
			if (flag)
			{
				ItemTypeFilter builder17 = new ItemTypeFilter();
				if (filterCase_ == FilterOneofCase.Type)
				{
					if (filterCase_ != FilterOneofCase.Type)
					{
					}
					object obj19 = filter_;
					if (obj19 != null && obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder17);
				filter_ = builder17;
				filterCase_ = (FilterOneofCase)typeof(ItemTypeFilter).TypeHandle;
			}
			goto IL_06a4;
			IL_06a4:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600124A")]
		[Cpp2IlInjected.Address(RVA = "0x26E4720", Offset = "0x26E3120", VA = "0x1826E4720", Slot = "11")]
		[DebuggerNonUserCode]
		public unsafe object GetFieldValue(int fieldNumber)
		{
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			if (fieldNumber <= 18)
			{
				ItemIdFilter id = Id;
				ItemTypeFilter type = Type;
				ItemSubTypeFilter subType = SubType;
				ItemQualityFilter quality = Quality;
				ItemComplexityFilter complexity = Complexity;
				ItemMoodFilter mood = Mood;
				ItemSturdinessFilter sturdiness = Sturdiness;
				ItemNormalityFilter normality = Normality;
				ItemMinRarityFilter minRarity = MinRarity;
				ItemMaxRarityFilter maxRarity = MaxRarity;
				ItemRarityFilter rarity = Rarity;
				ItemAllTagsFilter allTags = AllTags;
				ItemAnyTagFilter anyTag = AnyTag;
				ItemSeedFilter seed = Seed;
				ItemMealFilter meal = Meal;
				ItemNullFilter @null = Null;
				ItemAvailableInStall inStall = InStall;
				ItemGridFilter grid = Grid;
				ItemCurrencyFilter currency = Currency;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			ex = (ArgumentException)(ex + __ldftn(AnyItemFilter.GetFieldValue));
			ex = (ArgumentException)(ex + __ldftn(AnyItemFilter.GetFieldValue));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600124B")]
		[Cpp2IlInjected.Address(RVA = "0x26E6E00", Offset = "0x26E5800", VA = "0x1826E6E00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002b, IL_002f, IL_0036, IL_0037, IL_003b, IL_0042, IL_0043, IL_0047, IL_004e, IL_004f, IL_0053, IL_005a, IL_005b, IL_005f, IL_0066, IL_0067, IL_006b, IL_0072, IL_0073, IL_0077, IL_007e, IL_007f, IL_0083, IL_008a, IL_008b, IL_008f, IL_0096, IL_0097, IL_009b, IL_00a2, IL_00a3, IL_00a7, IL_00ae, IL_00af, IL_00b3, IL_00ba, IL_00bb, IL_00bf, IL_00c6, IL_00c7, IL_00cb, IL_00d2, IL_00d3, IL_00d7, IL_00de, IL_00df, IL_00e3, IL_00ea, IL_00eb, IL_00ef, IL_00f3, IL_00f4, IL_00f8, IL_00fc, IL_00fd, IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139, IL_013f, IL_0145, IL_014b, IL_0151, IL_0157, IL_015d, IL_0163, IL_0169
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 18)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				filter_ = num;
				bool flag = (byte)(filterCase_ = ((num != 0) ? FilterOneofCase.Id : FilterOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600124C")]
		[Cpp2IlInjected.Address(RVA = "0x26E4120", Offset = "0x26E2B20", VA = "0x1826E4120", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000e: Expected O, but got I4
			if (fieldNumber <= 18)
			{
				int num = 0;
				filter_ = num;
				filterCase_ = (FilterOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600124D")]
		[Cpp2IlInjected.Address(RVA = "0x26E5360", Offset = "0x26E3D60", VA = "0x1826E5360", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "filter"))
			{
				FilterOneofCase filterOneofCase = filterCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600124E")]
		[Cpp2IlInjected.Address(RVA = "0x26E41C0", Offset = "0x26E2BC0", VA = "0x1826E41C0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "filter"))
			{
				filter_ = (filterCase_ = FilterOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001250")]
		[Cpp2IlInjected.Address(RVA = "0x26E83E0", Offset = "0x26E6DE0", VA = "0x1826E83E0")]
		static AnyItemFilter()
		{
			Func<AnyItemFilter> func = default(Func<AnyItemFilter>);
			_parser = (MessageParser<AnyItemFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
