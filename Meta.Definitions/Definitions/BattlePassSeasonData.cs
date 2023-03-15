using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class BattlePassSeasonData : IMessage<BattlePassSeasonData>, IMessage, IEquatable<BattlePassSeasonData>, IDeepCloneable<BattlePassSeasonData>, IMessageFieldAccessor, IDataValidation, IHasOnlineItemDependencies, IHasItemDependencies, IClientLiveopsConfig<BattlePassConfigV2>, IFetchable, ITimeLimited
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			public sealed class Price : IMessage<Price>, IMessage, IEquatable<Price>, IDeepCloneable<Price>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				private static readonly MessageParser<Price> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000205")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000206")]
				public const int IdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000207")]
				private int id_;

				[Cpp2IlInjected.Token(Token = "0x4000208")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000209")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				[DebuggerNonUserCode]
				public static MessageParser<Price> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000490")]
					[Cpp2IlInjected.Address(RVA = "0x9D37F0", Offset = "0x9D21F0", VA = "0x1809D37F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000491")]
					[Cpp2IlInjected.Address(RVA = "0x9D3770", Offset = "0x9D2170", VA = "0x1809D3770")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000492")]
					[Cpp2IlInjected.Address(RVA = "0x9D3850", Offset = "0x9D2250", VA = "0x1809D3850", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				[DebuggerNonUserCode]
				public int Id
				{
					[Cpp2IlInjected.Token(Token = "0x6000496")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000497")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6000498")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000499")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Price()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public Price(Price other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x9D3360", Offset = "0x9D1D60", VA = "0x1809D3360", Slot = "10")]
				[DebuggerNonUserCode]
				public Price Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0x9D33F0", Offset = "0x9D1DF0", VA = "0x1809D33F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600049B")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Price other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600049C")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600049D")]
				[Cpp2IlInjected.Address(RVA = "0x9D3600", Offset = "0x9D2000", VA = "0x1809D3600", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0x9D3290", Offset = "0x9D1C90", VA = "0x1809D3290", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Price other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004A2")]
				[Cpp2IlInjected.Address(RVA = "0x9D3480", Offset = "0x9D1E80", VA = "0x1809D3480", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004A3")]
				[Cpp2IlInjected.Address(RVA = "0x9D3540", Offset = "0x9D1F40", VA = "0x1809D3540", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004A4")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly MessageParser<BattlePassSeasonData> _parser = (MessageParser<BattlePassSeasonData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new BattlePassSeasonData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public const int MinGameVersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private string minGameVersion_;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public const int ActiveFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private bool active_;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public const int StartDateFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private ConditionDate startDate_;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public const int FinishDateFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private ConditionDate finishDate_;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public const int EndDateFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private ConditionDate endDate_;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public const int TitleFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private string title_;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public const int DescriptionFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public const int IconAddressFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public const int PremiumPassImageFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private string premiumPassImage_;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public const int CurrencyNameFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private string currencyName_;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public const int PremiumPassPriceFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Types.Price premiumPassPrice_;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public const int EventCurrencyIncrementFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private int eventCurrencyIncrement_;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public const int EventCurrencyIncrementPriceFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private Types.Price eventCurrencyIncrementPrice_;

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public const int CurrencyBundleAmountFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int currencyBundleAmount_;

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public const int CurrencyBundlePriceFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Types.Price currencyBundlePrice_;

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public const int FreeActiveTaskCountFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int freeActiveTaskCount_;

		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public const int PremiumActiveTaskCountFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int premiumActiveTaskCount_;

		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public const int RewardsSetupFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private BattlePassRewardsSetup rewardsSetup_;

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public const int RewardsPagesFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static readonly FieldCodec<BattlePassRewardsPage> _repeated_rewardsPages_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private readonly RepeatedField<BattlePassRewardsPage> rewardsPages_;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public const int TaskConfigFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private BattlePassTaskConfig taskConfig_;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public const int OnlineIdFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private string onlineId_;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public const int CurrencyOnlineIdFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private string currencyOnlineId_;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public const int CurrencyOnlineTypeFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private string currencyOnlineType_;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public const int LanguageFieldNumber = 33;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private string language_;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public const int LastUpdateTimestampFieldNumber = 34;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private ConditionDate lastUpdateTimestamp_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassSeasonData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x26FFDA0", Offset = "0x26FE7A0", VA = "0x1826FFDA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x26FF850", Offset = "0x26FE250", VA = "0x1826FF850")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x26FFE50", Offset = "0x26FE850", VA = "0x1826FFE50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "19")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "20")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		[DebuggerNonUserCode]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "21")]
			get
			{
				return minGameVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x2700200", Offset = "0x26FEC00", VA = "0x182700200", Slot = "22")]
			set
			{
				string text = (minGameVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[DebuggerNonUserCode]
		public bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "23")]
			get
			{
				return active_;
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0", Slot = "24")]
			set
			{
				active_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[DebuggerNonUserCode]
		public ConditionDate StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "35")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		[DebuggerNonUserCode]
		public ConditionDate FinishDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return finishDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				finishDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		[DebuggerNonUserCode]
		public ConditionDate EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "36")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x2700350", Offset = "0x26FED50", VA = "0x182700350", Slot = "26")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "27")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x27000B0", Offset = "0x26FEAB0", VA = "0x1827000B0", Slot = "28")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "29")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x2700120", Offset = "0x26FEB20", VA = "0x182700120", Slot = "30")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		[DebuggerNonUserCode]
		public string PremiumPassImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return premiumPassImage_;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x27002E0", Offset = "0x26FECE0", VA = "0x1827002E0")]
			set
			{
				string text = (premiumPassImage_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		[DebuggerNonUserCode]
		public string CurrencyName
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return currencyName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x26FFF60", Offset = "0x26FE960", VA = "0x1826FFF60")]
			set
			{
				string text = (currencyName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		[DebuggerNonUserCode]
		public Types.Price PremiumPassPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return premiumPassPrice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				premiumPassPrice_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		[DebuggerNonUserCode]
		public int EventCurrencyIncrement
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return eventCurrencyIncrement_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				eventCurrencyIncrement_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		[DebuggerNonUserCode]
		public Types.Price EventCurrencyIncrementPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return eventCurrencyIncrementPrice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		[DebuggerNonUserCode]
		public int CurrencyBundleAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return currencyBundleAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			set
			{
				currencyBundleAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		[DebuggerNonUserCode]
		public Types.Price CurrencyBundlePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return currencyBundlePrice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			set
			{
				currencyBundlePrice_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		[DebuggerNonUserCode]
		public int FreeActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return freeActiveTaskCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			set
			{
				freeActiveTaskCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		[DebuggerNonUserCode]
		public int PremiumActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0390", Offset = "0x1E9ED90", VA = "0x181EA0390")]
			get
			{
				return premiumActiveTaskCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x22DD580", Offset = "0x22DBF80", VA = "0x1822DD580")]
			set
			{
				premiumActiveTaskCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		[DebuggerNonUserCode]
		public BattlePassRewardsSetup RewardsSetup
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return rewardsSetup_;
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			set
			{
				rewardsSetup_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		[DebuggerNonUserCode]
		public RepeatedField<BattlePassRewardsPage> RewardsPages
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return rewardsPages_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public BattlePassTaskConfig TaskConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return taskConfig_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			set
			{
				taskConfig_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		[DebuggerNonUserCode]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return onlineId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x2700270", Offset = "0x26FEC70", VA = "0x182700270")]
			set
			{
				string text = (onlineId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		[DebuggerNonUserCode]
		public string CurrencyOnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return currencyOnlineId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x26FFFD0", Offset = "0x26FE9D0", VA = "0x1826FFFD0")]
			set
			{
				string text = (currencyOnlineId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		[DebuggerNonUserCode]
		public string CurrencyOnlineType
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return currencyOnlineType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x2700040", Offset = "0x26FEA40", VA = "0x182700040")]
			set
			{
				string text = (currencyOnlineType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0", Slot = "31")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x2700190", Offset = "0x26FEB90", VA = "0x182700190", Slot = "32")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		[DebuggerNonUserCode]
		public ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80", Slot = "33")]
			get
			{
				return lastUpdateTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "34")]
			set
			{
				lastUpdateTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public bool EnableScheduledEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private int SCItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x26FFE00", Offset = "0x26FE800", VA = "0x1826FFE00")]
			get
			{
				int num = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		private int HCItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x26FF980", Offset = "0x26FE380", VA = "0x1826FF980")]
			get
			{
				int num = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x26FF920", Offset = "0x26FE320", VA = "0x1826FF920", Slot = "15")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "16")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x26FF9D0", Offset = "0x26FE3D0", VA = "0x1826FF9D0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0059, IL_005f
				int num = 0;
				if ((IntPtr)itemDependencies == (IntPtr)num)
				{
					List<Item> list = (itemDependencies = (List<Item>)(object)new List<T>());
					RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
					bool flag = default(bool);
					if (flag)
					{
						List<Item> list2 = itemDependencies;
						if (_003C_003Ec._003C_003E9__166_0 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(BattlePassReward x)
							{
								//Discarded unreachable code: IL_000d
								int itemId_ = x.itemId_;
								return (Item)typeof(Item).TypeHandle;
							};
						}
						IEnumerable<BattlePassReward> enumerable = default(IEnumerable<BattlePassReward>);
						((List<T>)(object)list2).AddRange((IEnumerable<>)enumerable);
					}
				}
				return itemDependencies;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		private BattlePassReward MainReward
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x26FFC80", Offset = "0x26FE680", VA = "0x1826FFC80")]
			get
			{
				int mainRewardPage = rewardsSetup_.MainRewardPage;
				int count = ((RepeatedField<T>)(object)rewardsPages_).Count;
				if (mainRewardPage < count)
				{
					BattlePassRewardsPage battlePassRewardsPage = (BattlePassRewardsPage)((RepeatedField<T>)(object)rewardsPages_)[mainRewardPage];
					BattlePassRewardsSetup battlePassRewardsSetup = rewardsSetup_;
					RepeatedField<BattlePassReward> rewards_ = battlePassRewardsPage.rewards_;
					int mainRewardIndex = battlePassRewardsSetup.MainRewardIndex;
					int count2 = ((RepeatedField<T>)(object)rewards_).Count;
					if (mainRewardIndex < count2)
					{
						return (BattlePassReward)((RepeatedField<T>)(object)rewards_)[mainRewardIndex];
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x26FF310", Offset = "0x26FDD10", VA = "0x1826FF310")]
		[DebuggerNonUserCode]
		public BattlePassSeasonData()
		{
			minGameVersion_ = "";
			title_ = "";
			description_ = "";
			iconAddress_ = "";
			premiumPassImage_ = "";
			currencyName_ = "";
			rewardsPages_ = (RepeatedField<BattlePassRewardsPage>)(object)new RepeatedField<T>();
			onlineId_ = "";
			currencyOnlineId_ = "";
			currencyOnlineType_ = "";
			language_ = "";
			base._002Ector();
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x26FCE70", Offset = "0x26FB870", VA = "0x1826FCE70")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_0158
			//IL_002e: Expected I4, but got I8
			//IL_0063: Expected I4, but got I8
			//IL_0099: Expected I4, but got I8
			//IL_00bb: Expected I4, but got O
			//IL_00dd: Expected I4, but got O
			//IL_00ff: Expected I4, but got O
			//IL_0110: Expected I4, but got I8
			//IL_0119: Expected I4, but got I8
			//IL_0136: Expected I4, but got I8
			//IL_0140: Expected I4, but got I8
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			ConditionDate conditionDate = new ConditionDate();
			DateTime dateTime = default(DateTime);
			Timestamp timestamp = (conditionDate.date_ = dateTime.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			ConditionDate conditionDate2 = new ConditionDate();
			int num2 = 0;
			DateTime dateTime2 = default(DateTime);
			Timestamp timestamp2 = (conditionDate2.date_ = dateTime2.ToProto());
			conditionDate2.localTime_ = false;
			conditionDate2.operator_ = IntOperator.LessThan;
			finishDate_ = conditionDate2;
			ConditionDate conditionDate3 = new ConditionDate();
			int num3 = 0;
			DateTime dateTime3 = default(DateTime);
			Timestamp timestamp3 = (conditionDate3.date_ = dateTime3.ToProto());
			conditionDate3.localTime_ = false;
			conditionDate3.operator_ = IntOperator.LessThan;
			endDate_ = conditionDate3;
			Types.Price price = new Types.Price();
			int num4 = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			price.id_ = (int)hardCurrencyItem;
			premiumPassPrice_ = price;
			Types.Price price2 = new Types.Price();
			int num5 = 0;
			Item hardCurrencyItem2 = CurrencyItem.HardCurrencyItem;
			price2.id_ = (int)hardCurrencyItem2;
			eventCurrencyIncrementPrice_ = price2;
			Types.Price price3 = new Types.Price();
			int num6 = 0;
			Item hardCurrencyItem3 = CurrencyItem.HardCurrencyItem;
			price3.id_ = (int)hardCurrencyItem3;
			currencyBundlePrice_ = price3;
			freeActiveTaskCount_ = 3;
			premiumActiveTaskCount_ = 6;
			BattlePassRewardsSetup battlePassRewardsSetup = new BattlePassRewardsSetup();
			battlePassRewardsSetup.mainReward_ = "";
			battlePassRewardsSetup.pagesNum_ = 1;
			battlePassRewardsSetup.rewardsNumPerPage_ = 1;
			rewardsSetup_ = battlePassRewardsSetup;
			BattlePassTaskConfig battlePassTaskConfig = (taskConfig_ = new BattlePassTaskConfig());
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x26FF470", Offset = "0x26FDE70", VA = "0x1826FF470")]
		[DebuggerNonUserCode]
		public BattlePassSeasonData(BattlePassSeasonData other)
		{
			//IL_0049: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			//IL_011d: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			//IL_0197: Expected I4, but got I8
			//IL_01a1: Expected I4, but got I8
			//IL_023d: Expected O, but got I4
			//IL_026f: Expected O, but got I4
			int num = (version_ = other.version_);
			string text = (minGameVersion_ = other.minGameVersion_);
			bool flag = other.active_;
			int num2 = 0;
			active_ = flag;
			ConditionDate conditionDate = other.startDate_;
			if (conditionDate != null)
			{
				ConditionDate conditionDate2 = conditionDate.Clone();
			}
			startDate_ = (ConditionDate)num2;
			ConditionDate conditionDate3 = other.finishDate_;
			if (conditionDate3 != null)
			{
				ConditionDate conditionDate4 = conditionDate3.Clone();
			}
			finishDate_ = (ConditionDate)num2;
			ConditionDate conditionDate5 = other.endDate_;
			if (conditionDate5 != null)
			{
				ConditionDate conditionDate6 = conditionDate5.Clone();
			}
			endDate_ = (ConditionDate)num2;
			string text2 = (title_ = other.title_);
			string text3 = (description_ = other.description_);
			string text4 = (iconAddress_ = other.iconAddress_);
			string text5 = (premiumPassImage_ = other.premiumPassImage_);
			string text6 = (currencyName_ = other.currencyName_);
			Types.Price price = other.premiumPassPrice_;
			if (price != null)
			{
				Types.Price price2 = price.Clone();
			}
			premiumPassPrice_ = (Types.Price)num2;
			int num3 = (eventCurrencyIncrement_ = other.eventCurrencyIncrement_);
			Types.Price price3 = other.eventCurrencyIncrementPrice_;
			if (price3 != null)
			{
				Types.Price price4 = price3.Clone();
			}
			eventCurrencyIncrementPrice_ = (Types.Price)num2;
			int num4 = (currencyBundleAmount_ = other.currencyBundleAmount_);
			Types.Price price5 = other.currencyBundlePrice_;
			if (price5 != null)
			{
				Types.Price price6 = price5.Clone();
			}
			currencyBundlePrice_ = (Types.Price)num2;
			int num5 = (freeActiveTaskCount_ = other.freeActiveTaskCount_);
			int num6 = (premiumActiveTaskCount_ = other.premiumActiveTaskCount_);
			BattlePassRewardsSetup battlePassRewardsSetup = other.rewardsSetup_;
			if (battlePassRewardsSetup != null)
			{
				BattlePassRewardsSetup battlePassRewardsSetup2 = new BattlePassRewardsSetup
				{
					mainReward_ = "",
					pagesNum_ = 1,
					rewardsNumPerPage_ = 1
				};
				int num7 = (battlePassRewardsSetup2.pagesNum_ = battlePassRewardsSetup.pagesNum_);
				int num8 = (battlePassRewardsSetup2.rewardsNumPerPage_ = battlePassRewardsSetup.rewardsNumPerPage_);
				string text7 = (battlePassRewardsSetup2.mainReward_ = battlePassRewardsSetup.mainReward_);
				int num9 = (battlePassRewardsSetup2.totalFreeSCNum_ = battlePassRewardsSetup.totalFreeSCNum_);
				int num10 = (battlePassRewardsSetup2.totalPremiumSCNum_ = battlePassRewardsSetup.totalPremiumSCNum_);
				int num11 = (battlePassRewardsSetup2.totalFreeHCNum_ = battlePassRewardsSetup.totalFreeHCNum_);
				int num12 = (battlePassRewardsSetup2.totalPremiumHCNum_ = battlePassRewardsSetup.totalPremiumHCNum_);
				UnknownFieldSet unknownFieldSet = (battlePassRewardsSetup2._unknownFields = UnknownFieldSet.Clone(battlePassRewardsSetup._unknownFields));
			}
			rewardsSetup_ = (BattlePassRewardsSetup)num2;
			RepeatedField<BattlePassRewardsPage> repeatedField = (rewardsPages_ = (RepeatedField<BattlePassRewardsPage>)(object)((RepeatedField<T>)(object)other.rewardsPages_).Clone());
			BattlePassTaskConfig battlePassTaskConfig = other.taskConfig_;
			if (battlePassTaskConfig != null)
			{
				BattlePassTaskConfig battlePassTaskConfig2 = battlePassTaskConfig.Clone();
			}
			taskConfig_ = (BattlePassTaskConfig)num2;
			string text8 = (onlineId_ = other.onlineId_);
			string text9 = (currencyOnlineId_ = other.currencyOnlineId_);
			string text10 = (currencyOnlineType_ = other.currencyOnlineType_);
			string text11 = (language_ = other.language_);
			ConditionDate conditionDate7 = other.lastUpdateTimestamp_;
			ConditionDate conditionDate8 = default(ConditionDate);
			if (conditionDate7 != null)
			{
				conditionDate8 = conditionDate7.Clone();
			}
			lastUpdateTimestamp_ = conditionDate8;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x26F8A50", Offset = "0x26F7450", VA = "0x1826F8A50", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassSeasonData Clone()
		{
			return new BattlePassSeasonData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x26FA7C0", Offset = "0x26F91C0", VA = "0x1826FA7C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((BattlePassSeasonData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x26FA820", Offset = "0x26F9220", VA = "0x1826FA820", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassSeasonData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.version_;
				if (version_ == num)
				{
					string text = other.minGameVersion_;
					if (!(minGameVersion_ != text))
					{
						bool flag = other.active_;
						if (active_ == flag)
						{
							ConditionDate objB = other.startDate_;
							if (object.Equals(startDate_, objB))
							{
								ConditionDate objB2 = other.finishDate_;
								if (object.Equals(finishDate_, objB2))
								{
									ConditionDate objB3 = other.endDate_;
									if (object.Equals(endDate_, objB3))
									{
										string text2 = other.title_;
										if (!(title_ != text2))
										{
											string text3 = other.description_;
											if (!(description_ != text3))
											{
												string text4 = other.iconAddress_;
												if (!(iconAddress_ != text4))
												{
													string text5 = other.premiumPassImage_;
													if (!(premiumPassImage_ != text5))
													{
														string text6 = other.currencyName_;
														if (!(currencyName_ != text6))
														{
															Types.Price objB4 = other.premiumPassPrice_;
															if (object.Equals(premiumPassPrice_, objB4))
															{
																int num2 = other.eventCurrencyIncrement_;
																if (eventCurrencyIncrement_ == num2)
																{
																	Types.Price objB5 = other.eventCurrencyIncrementPrice_;
																	if (object.Equals(eventCurrencyIncrementPrice_, objB5))
																	{
																		int num3 = other.currencyBundleAmount_;
																		if (currencyBundleAmount_ == num3)
																		{
																			Types.Price objB6 = other.currencyBundlePrice_;
																			if (object.Equals(currencyBundlePrice_, objB6))
																			{
																				int num4 = other.freeActiveTaskCount_;
																				if (freeActiveTaskCount_ == num4)
																				{
																					int num5 = other.premiumActiveTaskCount_;
																					if (premiumActiveTaskCount_ == num5)
																					{
																						BattlePassRewardsSetup objB7 = other.rewardsSetup_;
																						if (object.Equals(rewardsSetup_, objB7))
																						{
																							RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
																							RepeatedField<BattlePassRewardsPage> repeatedField2 = other.rewardsPages_;
																							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																							{
																								BattlePassTaskConfig objB8 = other.taskConfig_;
																								if (object.Equals(taskConfig_, objB8))
																								{
																									string text7 = other.onlineId_;
																									if (!(onlineId_ != text7))
																									{
																										string text8 = other.currencyOnlineId_;
																										if (!(currencyOnlineId_ != text8))
																										{
																											string text9 = other.currencyOnlineType_;
																											if (!(currencyOnlineType_ != text9))
																											{
																												string text10 = other.language_;
																												if (!(language_ != text10))
																												{
																													ConditionDate objB9 = other.lastUpdateTimestamp_;
																													if (object.Equals(lastUpdateTimestamp_, objB9))
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
								}
							}
						}
					}
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x26FB900", Offset = "0x26FA300", VA = "0x1826FB900", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_022b
			if (version_ != 0)
			{
			}
			string text = minGameVersion_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (active_)
			{
			}
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int hashCode2 = conditionDate.GetHashCode();
			}
			ConditionDate conditionDate2 = finishDate_;
			if (conditionDate2 != null)
			{
				int hashCode3 = conditionDate2.GetHashCode();
			}
			ConditionDate conditionDate3 = endDate_;
			if (conditionDate3 != null)
			{
				int hashCode4 = conditionDate3.GetHashCode();
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int hashCode5 = text2.GetHashCode();
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int hashCode6 = text3.GetHashCode();
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode7 = text4.GetHashCode();
			}
			string text5 = premiumPassImage_;
			if (text5.m_stringLength != 0)
			{
				int hashCode8 = text5.GetHashCode();
			}
			string text6 = currencyName_;
			if (text6.m_stringLength != 0)
			{
				int hashCode9 = text6.GetHashCode();
			}
			Types.Price price = premiumPassPrice_;
			if (price != null)
			{
				int hashCode10 = price.GetHashCode();
			}
			if (eventCurrencyIncrement_ != 0)
			{
			}
			Types.Price price2 = eventCurrencyIncrementPrice_;
			if (price2 != null)
			{
				int hashCode11 = price2.GetHashCode();
			}
			if (currencyBundleAmount_ != 0)
			{
			}
			Types.Price price3 = currencyBundlePrice_;
			if (price3 != null)
			{
				int hashCode12 = price3.GetHashCode();
			}
			if (freeActiveTaskCount_ != 0)
			{
			}
			if (premiumActiveTaskCount_ != 0)
			{
			}
			BattlePassRewardsSetup battlePassRewardsSetup = rewardsSetup_;
			if (battlePassRewardsSetup != null)
			{
				int hashCode13 = battlePassRewardsSetup.GetHashCode();
			}
			int hashCode14 = ((RepeatedField<T>)(object)rewardsPages_).GetHashCode();
			BattlePassTaskConfig battlePassTaskConfig = taskConfig_;
			if (battlePassTaskConfig != null)
			{
				int hashCode15 = battlePassTaskConfig.GetHashCode();
			}
			string text7 = onlineId_;
			if (text7.m_stringLength != 0)
			{
				int hashCode16 = text7.GetHashCode();
			}
			string text8 = currencyOnlineId_;
			if (text8.m_stringLength != 0)
			{
				int hashCode17 = text8.GetHashCode();
			}
			string text9 = currencyOnlineType_;
			if (text9.m_stringLength != 0)
			{
				int hashCode18 = text9.GetHashCode();
			}
			string text10 = language_;
			if (text10.m_stringLength != 0)
			{
				int hashCode19 = text10.GetHashCode();
			}
			ConditionDate conditionDate4 = lastUpdateTimestamp_;
			if (conditionDate4 != null)
			{
				int hashCode20 = conditionDate4.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode21 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x26FE1A0", Offset = "0x26FCBA0", VA = "0x1826FE1A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x26FEB60", Offset = "0x26FD560", VA = "0x1826FEB60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_02dc
			if (version_ != 0)
			{
				int value = version_;
				output.WriteInt32(value);
			}
			if (minGameVersion_.m_stringLength != 0)
			{
				string value2 = minGameVersion_;
				output.WriteString(value2);
			}
			if (active_)
			{
				bool value3 = active_;
				output.WriteBool(value3);
			}
			if ((long)startDate_ != 0)
			{
				ConditionDate value4 = startDate_;
				output.WriteMessage(value4);
			}
			if ((long)finishDate_ != 0)
			{
				ConditionDate value5 = finishDate_;
				output.WriteMessage(value5);
			}
			if ((long)endDate_ != 0)
			{
				ConditionDate value6 = endDate_;
				output.WriteMessage(value6);
			}
			if (title_.m_stringLength != 0)
			{
				string value7 = title_;
				output.WriteString(value7);
			}
			if (description_.m_stringLength != 0)
			{
				string value8 = description_;
				output.WriteString(value8);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value9 = iconAddress_;
				output.WriteString(value9);
			}
			if (premiumPassImage_.m_stringLength != 0)
			{
				string value10 = premiumPassImage_;
				output.WriteString(value10);
			}
			if (currencyName_.m_stringLength != 0)
			{
				string value11 = currencyName_;
				output.WriteString(value11);
			}
			if ((long)premiumPassPrice_ != 0)
			{
				Types.Price value12 = premiumPassPrice_;
				output.WriteMessage(value12);
			}
			if (eventCurrencyIncrement_ != 0)
			{
				int value13 = eventCurrencyIncrement_;
				output.WriteInt32(value13);
			}
			if ((long)eventCurrencyIncrementPrice_ != 0)
			{
				Types.Price value14 = eventCurrencyIncrementPrice_;
				output.WriteMessage(value14);
			}
			if (currencyBundleAmount_ != 0)
			{
				int value15 = currencyBundleAmount_;
				output.WriteInt32(value15);
			}
			if ((long)currencyBundlePrice_ != 0)
			{
				Types.Price value16 = currencyBundlePrice_;
				output.WriteMessage(value16);
			}
			if (freeActiveTaskCount_ != 0)
			{
				int value17 = freeActiveTaskCount_;
				output.WriteInt32(value17);
			}
			if (premiumActiveTaskCount_ != 0)
			{
				int value18 = premiumActiveTaskCount_;
				output.WriteInt32(value18);
			}
			if ((long)rewardsSetup_ != 0)
			{
				BattlePassRewardsSetup value19 = rewardsSetup_;
				output.WriteMessage(value19);
			}
			RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
			FieldCodec<BattlePassRewardsPage> repeated_rewardsPages_codec = _repeated_rewardsPages_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewardsPages_codec);
			if ((long)taskConfig_ != 0)
			{
				BattlePassTaskConfig value20 = taskConfig_;
				output.WriteMessage(value20);
			}
			if (onlineId_.m_stringLength != 0)
			{
				string value21 = onlineId_;
				output.WriteString(value21);
			}
			if (currencyOnlineId_.m_stringLength != 0)
			{
				string value22 = currencyOnlineId_;
				output.WriteString(value22);
			}
			if (currencyOnlineType_.m_stringLength != 0)
			{
				string value23 = currencyOnlineType_;
				output.WriteString(value23);
			}
			if (language_.m_stringLength != 0)
			{
				string value24 = language_;
				output.WriteString(value24);
			}
			if ((long)lastUpdateTimestamp_ != 0)
			{
				ConditionDate value25 = lastUpdateTimestamp_;
				output.WriteMessage(value25);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x26F80F0", Offset = "0x26F6AF0", VA = "0x1826F80F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0376
			int num = version_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = minGameVersion_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(conditionDate);
				num5++;
				num2 += num5;
			}
			ConditionDate conditionDate2 = finishDate_;
			if (conditionDate2 != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(conditionDate2);
				num6++;
				num2 += num6;
			}
			ConditionDate conditionDate3 = endDate_;
			if (conditionDate3 != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(conditionDate3);
				num7++;
				num2 += num7;
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text2);
				num8++;
				num2 += num8;
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text3);
				num9++;
				num2 += num9;
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text4);
				num10++;
				num2 += num10;
			}
			string text5 = premiumPassImage_;
			if (text5.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text5);
				num11++;
				num2 += num11;
			}
			string text6 = currencyName_;
			if (text6.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text6);
				num12++;
				num2 += num12;
			}
			Types.Price price = premiumPassPrice_;
			if (price != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(price);
				num13++;
				num2 += num13;
			}
			int num14 = eventCurrencyIncrement_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			Types.Price price2 = eventCurrencyIncrementPrice_;
			if (price2 != null)
			{
				int num16 = CodedOutputStream.ComputeMessageSize(price2);
				num16++;
				num2 += num16;
			}
			int num17 = currencyBundleAmount_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			Types.Price price3 = currencyBundlePrice_;
			if (price3 != null)
			{
				int num19 = CodedOutputStream.ComputeMessageSize(price3);
				num19 += 2;
				num2 += num19;
			}
			int num20 = freeActiveTaskCount_;
			if (num20 != 0)
			{
				int num21 = CodedOutputStream.ComputeInt32Size(num20);
				num21 += 2;
				num2 += num21;
			}
			int num22 = premiumActiveTaskCount_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeInt32Size(num22);
				num23 += 2;
				num2 += num23;
			}
			BattlePassRewardsSetup battlePassRewardsSetup = rewardsSetup_;
			if (battlePassRewardsSetup != null)
			{
				int num24 = CodedOutputStream.ComputeMessageSize(battlePassRewardsSetup);
				num24 += 2;
				num2 += num24;
			}
			RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
			FieldCodec<BattlePassRewardsPage> repeated_rewardsPages_codec = _repeated_rewardsPages_codec;
			int num25 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewardsPages_codec);
			BattlePassTaskConfig battlePassTaskConfig = taskConfig_;
			num2 += num25;
			if (battlePassTaskConfig != null)
			{
				int num26 = CodedOutputStream.ComputeMessageSize(battlePassTaskConfig);
				num26 += 2;
				num2 += num26;
			}
			string text7 = onlineId_;
			if (text7.m_stringLength != 0)
			{
				int num27 = CodedOutputStream.ComputeStringSize(text7);
				num27 += 2;
				num2 += num27;
			}
			string text8 = currencyOnlineId_;
			if (text8.m_stringLength != 0)
			{
				int num28 = CodedOutputStream.ComputeStringSize(text8);
				num28 += 2;
				num2 += num28;
			}
			string text9 = currencyOnlineType_;
			if (text9.m_stringLength != 0)
			{
				int num29 = CodedOutputStream.ComputeStringSize(text9);
				num29 += 2;
				num2 += num29;
			}
			string text10 = language_;
			if (text10.m_stringLength != 0)
			{
				int num30 = CodedOutputStream.ComputeStringSize(text10);
				num30 += 2;
				num2 += num30;
			}
			ConditionDate conditionDate4 = lastUpdateTimestamp_;
			if (conditionDate4 != null)
			{
				int num31 = CodedOutputStream.ComputeMessageSize(conditionDate4);
				num31 += 2;
				num2 += num31;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num32 = unknownFields.CalculateSize();
				num2 += num32;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x26FC1D0", Offset = "0x26FABD0", VA = "0x1826FC1D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassSeasonData other)
		{
			//Discarded unreachable code: IL_049b
			if (other == null)
			{
				return;
			}
			int num = other.version_;
			if (num != 0)
			{
				version_ = num;
			}
			string text = other.minGameVersion_;
			if (text.m_stringLength != 0)
			{
				MinGameVersion = text;
			}
			bool flag = other.active_;
			if (flag)
			{
				active_ = flag;
			}
			if ((long)other.startDate_ != 0)
			{
				ConditionDate conditionDate2 = default(ConditionDate);
				if (startDate_ == null)
				{
					ConditionDate conditionDate = (startDate_ = new ConditionDate());
					conditionDate2 = startDate_;
				}
				ConditionDate other2 = other.startDate_;
				conditionDate2.MergeFrom(other2);
			}
			if ((long)other.finishDate_ != 0)
			{
				ConditionDate conditionDate4 = default(ConditionDate);
				if (finishDate_ == null)
				{
					ConditionDate conditionDate3 = (finishDate_ = new ConditionDate());
					conditionDate4 = finishDate_;
				}
				ConditionDate other3 = other.finishDate_;
				conditionDate4.MergeFrom(other3);
			}
			if ((long)other.endDate_ != 0)
			{
				ConditionDate conditionDate6 = default(ConditionDate);
				if (endDate_ == null)
				{
					ConditionDate conditionDate5 = (endDate_ = new ConditionDate());
					conditionDate6 = endDate_;
				}
				ConditionDate other4 = other.endDate_;
				conditionDate6.MergeFrom(other4);
			}
			string text2 = other.title_;
			if (text2.m_stringLength != 0)
			{
				Title = text2;
			}
			string text3 = other.description_;
			if (text3.m_stringLength != 0)
			{
				Description = text3;
			}
			string text4 = other.iconAddress_;
			if (text4.m_stringLength != 0)
			{
				IconAddress = text4;
			}
			string text5 = other.premiumPassImage_;
			if (text5.m_stringLength != 0)
			{
				PremiumPassImage = text5;
			}
			string text6 = other.currencyName_;
			if (text6.m_stringLength != 0)
			{
				CurrencyName = text6;
			}
			if ((long)other.premiumPassPrice_ != 0)
			{
				Types.Price price2 = default(Types.Price);
				if (premiumPassPrice_ == null)
				{
					Types.Price price = (premiumPassPrice_ = new Types.Price());
					price2 = premiumPassPrice_;
				}
				Types.Price other5 = other.premiumPassPrice_;
				price2.MergeFrom(other5);
			}
			int num2 = other.eventCurrencyIncrement_;
			if (num2 != 0)
			{
				eventCurrencyIncrement_ = num2;
			}
			if ((long)other.eventCurrencyIncrementPrice_ != 0)
			{
				Types.Price price4 = default(Types.Price);
				if (eventCurrencyIncrementPrice_ == null)
				{
					Types.Price price3 = (eventCurrencyIncrementPrice_ = new Types.Price());
					price4 = eventCurrencyIncrementPrice_;
				}
				Types.Price other6 = other.eventCurrencyIncrementPrice_;
				price4.MergeFrom(other6);
			}
			int num3 = other.currencyBundleAmount_;
			if (num3 != 0)
			{
				currencyBundleAmount_ = num3;
			}
			if ((long)other.currencyBundlePrice_ != 0)
			{
				Types.Price price6 = default(Types.Price);
				if (currencyBundlePrice_ == null)
				{
					Types.Price price5 = (currencyBundlePrice_ = new Types.Price());
					price6 = currencyBundlePrice_;
				}
				Types.Price other7 = other.currencyBundlePrice_;
				price6.MergeFrom(other7);
			}
			int num4 = other.freeActiveTaskCount_;
			if (num4 != 0)
			{
				freeActiveTaskCount_ = num4;
			}
			int num5 = other.premiumActiveTaskCount_;
			if (num5 != 0)
			{
				premiumActiveTaskCount_ = num5;
			}
			if (other.rewardsSetup_ != null)
			{
				BattlePassRewardsSetup battlePassRewardsSetup2 = default(BattlePassRewardsSetup);
				BattlePassRewardsSetup battlePassRewardsSetup3 = default(BattlePassRewardsSetup);
				if (rewardsSetup_ == null)
				{
					BattlePassRewardsSetup battlePassRewardsSetup = (rewardsSetup_ = new BattlePassRewardsSetup());
					battlePassRewardsSetup2 = rewardsSetup_;
					battlePassRewardsSetup3 = other.rewardsSetup_;
				}
				if (battlePassRewardsSetup3 != null)
				{
					int pagesNum_ = battlePassRewardsSetup3.pagesNum_;
					if (pagesNum_ != 0)
					{
						battlePassRewardsSetup2.pagesNum_ = pagesNum_;
					}
					int rewardsNumPerPage_ = battlePassRewardsSetup3.rewardsNumPerPage_;
					if (rewardsNumPerPage_ != 0)
					{
						battlePassRewardsSetup2.rewardsNumPerPage_ = rewardsNumPerPage_;
					}
					string mainReward_ = battlePassRewardsSetup3.mainReward_;
					if (mainReward_.m_stringLength != 0)
					{
						battlePassRewardsSetup2.MainReward = mainReward_;
					}
					int totalFreeSCNum_ = battlePassRewardsSetup3.totalFreeSCNum_;
					if (totalFreeSCNum_ != 0)
					{
						battlePassRewardsSetup2.totalFreeSCNum_ = totalFreeSCNum_;
					}
					int totalPremiumSCNum_ = battlePassRewardsSetup3.totalPremiumSCNum_;
					if (totalPremiumSCNum_ != 0)
					{
						battlePassRewardsSetup2.totalPremiumSCNum_ = totalPremiumSCNum_;
					}
					int totalFreeHCNum_ = battlePassRewardsSetup3.totalFreeHCNum_;
					if (totalFreeHCNum_ != 0)
					{
						battlePassRewardsSetup2.totalFreeHCNum_ = totalFreeHCNum_;
					}
					int totalPremiumHCNum_ = battlePassRewardsSetup3.totalPremiumHCNum_;
					if (totalPremiumHCNum_ != 0)
					{
						battlePassRewardsSetup2.totalPremiumHCNum_ = totalPremiumHCNum_;
					}
					UnknownFieldSet unknownFields = battlePassRewardsSetup3._unknownFields;
					UnknownFieldSet unknownFieldSet = (battlePassRewardsSetup2._unknownFields = UnknownFieldSet.MergeFrom(battlePassRewardsSetup2._unknownFields, unknownFields));
				}
			}
			RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
			RepeatedField<BattlePassRewardsPage> repeatedField2 = other.rewardsPages_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.taskConfig_ != 0)
			{
				BattlePassTaskConfig battlePassTaskConfig2 = default(BattlePassTaskConfig);
				if (taskConfig_ == null)
				{
					BattlePassTaskConfig battlePassTaskConfig = (taskConfig_ = new BattlePassTaskConfig());
					battlePassTaskConfig2 = taskConfig_;
				}
				BattlePassTaskConfig other8 = other.taskConfig_;
				battlePassTaskConfig2.MergeFrom(other8);
			}
			string text7 = other.onlineId_;
			if (text7.m_stringLength != 0)
			{
				OnlineId = text7;
			}
			string text8 = other.currencyOnlineId_;
			if (text8.m_stringLength != 0)
			{
				CurrencyOnlineId = text8;
			}
			string text9 = other.currencyOnlineType_;
			if (text9.m_stringLength != 0)
			{
				CurrencyOnlineType = text9;
			}
			string text10 = other.language_;
			if (text10.m_stringLength != 0)
			{
				Language = text10;
			}
			if ((long)other.lastUpdateTimestamp_ != 0)
			{
				ConditionDate conditionDate8 = default(ConditionDate);
				if (lastUpdateTimestamp_ == null)
				{
					ConditionDate conditionDate7 = (lastUpdateTimestamp_ = new ConditionDate());
					conditionDate8 = lastUpdateTimestamp_;
				}
				ConditionDate other9 = other.lastUpdateTimestamp_;
				conditionDate8.MergeFrom(other9);
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x26FC7F0", Offset = "0x26FB1F0", VA = "0x1826FC7F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_03e7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 104)
			{
				if ((int)num > 162)
				{
					if ((int)num > 242)
					{
						if ((int)num > 258)
						{
							if (num == 266)
							{
								string text2 = (Language = input.ReadString());
							}
							if (num != 274)
							{
								goto IL_03d0;
							}
							ConditionDate builder = default(ConditionDate);
							if (lastUpdateTimestamp_ == null)
							{
								ConditionDate conditionDate = (lastUpdateTimestamp_ = new ConditionDate());
								builder = lastUpdateTimestamp_;
							}
							input.ReadMessage(builder);
						}
						string text4 = default(string);
						if (num == 250)
						{
							text4 = (CurrencyOnlineId = input.ReadString());
						}
						if ((long)text4 != 258)
						{
							goto IL_03d0;
						}
						string text6 = (CurrencyOnlineType = input.ReadString());
					}
					if (num == 170)
					{
						RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
						FieldCodec<BattlePassRewardsPage> repeated_rewardsPages_codec = _repeated_rewardsPages_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewardsPages_codec);
					}
					BattlePassTaskConfig battlePassTaskConfig = default(BattlePassTaskConfig);
					if (num == 178)
					{
						BattlePassTaskConfig builder2 = default(BattlePassTaskConfig);
						if (taskConfig_ == null)
						{
							battlePassTaskConfig = (taskConfig_ = new BattlePassTaskConfig());
							builder2 = taskConfig_;
						}
						input.ReadMessage(builder2);
					}
					if ((long)battlePassTaskConfig != 242)
					{
						goto IL_03d0;
					}
					string text8 = (OnlineId = input.ReadString());
				}
				BattlePassRewardsSetup battlePassRewardsSetup = default(BattlePassRewardsSetup);
				if ((int)num > 130)
				{
					int num2 = default(int);
					if (num == 136)
					{
						num2 = (freeActiveTaskCount_ = input.ReadInt32());
					}
					int num3 = default(int);
					if (num2 == 144)
					{
						num3 = (premiumActiveTaskCount_ = input.ReadInt32());
					}
					if (num3 != 162)
					{
						goto IL_03d0;
					}
					BattlePassRewardsSetup builder3 = default(BattlePassRewardsSetup);
					if (rewardsSetup_ == null)
					{
						battlePassRewardsSetup = (rewardsSetup_ = new BattlePassRewardsSetup());
						builder3 = rewardsSetup_;
					}
					input.ReadMessage(builder3);
				}
				Types.Price price = default(Types.Price);
				if ((long)battlePassRewardsSetup == 114)
				{
					Types.Price builder4 = default(Types.Price);
					if (eventCurrencyIncrementPrice_ == null)
					{
						price = (eventCurrencyIncrementPrice_ = new Types.Price());
						builder4 = eventCurrencyIncrementPrice_;
					}
					input.ReadMessage(builder4);
				}
				int num4 = default(int);
				if ((long)price == 120)
				{
					num4 = (currencyBundleAmount_ = input.ReadInt32());
				}
				if (num4 != 130)
				{
					goto IL_03d0;
				}
				Types.Price builder5 = default(Types.Price);
				if (currencyBundlePrice_ == null)
				{
					Types.Price price2 = (currencyBundlePrice_ = new Types.Price());
					builder5 = currencyBundlePrice_;
				}
				input.ReadMessage(builder5);
			}
			string text18 = default(string);
			if ((int)num > 50)
			{
				string text12 = default(string);
				if ((int)num > 74)
				{
					int num5 = default(int);
					if ((int)num > 90)
					{
						Types.Price price3 = default(Types.Price);
						if (num == 98)
						{
							Types.Price builder6 = default(Types.Price);
							if (premiumPassPrice_ == null)
							{
								price3 = (premiumPassPrice_ = new Types.Price());
								builder6 = premiumPassPrice_;
							}
							input.ReadMessage(builder6);
						}
						if ((long)price3 != 104)
						{
							goto IL_03d0;
						}
						num5 = (eventCurrencyIncrement_ = input.ReadInt32());
					}
					string text10 = default(string);
					if (num5 == 82)
					{
						text10 = (PremiumPassImage = input.ReadString());
					}
					if ((long)text10 != 90)
					{
						goto IL_03d0;
					}
					text12 = (CurrencyName = input.ReadString());
				}
				string text14 = default(string);
				if ((long)text12 == 58)
				{
					text14 = (Title = input.ReadString());
				}
				string text16 = default(string);
				if ((long)text14 == 66)
				{
					text16 = (Description = input.ReadString());
				}
				if ((long)text16 != 74)
				{
					goto IL_03d0;
				}
				text18 = (IconAddress = input.ReadString());
			}
			ConditionDate conditionDate4 = default(ConditionDate);
			if ((long)text18 > 24)
			{
				ConditionDate conditionDate2 = default(ConditionDate);
				if ((long)text18 == 34)
				{
					ConditionDate builder7 = default(ConditionDate);
					if (startDate_ == null)
					{
						conditionDate2 = (startDate_ = new ConditionDate());
						builder7 = startDate_;
					}
					input.ReadMessage(builder7);
				}
				ConditionDate conditionDate3 = default(ConditionDate);
				if ((long)conditionDate2 == 42)
				{
					ConditionDate builder8 = default(ConditionDate);
					if (finishDate_ == null)
					{
						conditionDate3 = (finishDate_ = new ConditionDate());
						builder8 = finishDate_;
					}
					input.ReadMessage(builder8);
				}
				if ((long)conditionDate3 != 50)
				{
					goto IL_03d0;
				}
				ConditionDate builder9 = default(ConditionDate);
				if (endDate_ == null)
				{
					conditionDate4 = (endDate_ = new ConditionDate());
					builder9 = endDate_;
				}
				input.ReadMessage(builder9);
			}
			int num6 = default(int);
			if ((long)conditionDate4 == 8)
			{
				num6 = (version_ = input.ReadInt32());
			}
			string text20 = default(string);
			if (num6 == 18)
			{
				text20 = (MinGameVersion = input.ReadString());
			}
			if ((long)text20 == 24)
			{
				bool flag = (active_ = input.ReadBool());
			}
			goto IL_03d0;
			IL_03d0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x26FB600", Offset = "0x26FA000", VA = "0x1826FB600", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 33)
			{
				int num = version_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x26FD290", Offset = "0x26FBC90", VA = "0x1826FD290", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_0026, IL_002e, IL_0036, IL_0037, IL_0038, IL_0039, IL_003a, IL_003b, IL_0043, IL_004b, IL_0053, IL_005b, IL_005c, IL_005d, IL_005e, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d, IL_0083, IL_0089, IL_008f, IL_0095, IL_009b, IL_00a1, IL_00a7, IL_00ad, IL_00b3
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			if (fieldNumber - 1 <= 33)
			{
				object obj = default(object);
				version_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x26F8740", Offset = "0x26F7140", VA = "0x1826F8740", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0023
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 33)
			{
				version_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x26FBED0", Offset = "0x26FA8D0", VA = "0x1826FBED0")]
		public bool GetNextUnavailableTaskDate(ITransactionContext context, out DateTime nextTaskDate)
		{
			//IL_0069: Expected I8, but got O
			//IL_00a2: Expected I8, but got O
			RepeatedField<BattlePassTask> tasks_ = taskConfig_.tasks_;
			Func<BattlePassTask, DateTime> func = (Func<BattlePassTask, DateTime>)(object)(Func<T, TResult>)((BattlePassTask x) => TaskStartTime(x));
			IEnumerable<BattlePassTask> enumerable = (IEnumerable<BattlePassTask>)Enumerable.Select<BattlePassTask, DateTime>((IEnumerable<>)(object)tasks_, (Func<, >)(object)func);
			Func<DateTime, bool> func2 = (Func<DateTime, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				ITransactionContext transactionContext = context;
				bool result = default(bool);
				return result;
			};
			IEnumerable<DateTime> enumerable2 = (IEnumerable<DateTime>)Enumerable.Where<DateTime>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
			if (!Enumerable.Any<DateTime>((IEnumerable<>)enumerable2))
			{
				DateTime minValue = DateTime.MinValue;
				int num = 0;
				nextTaskDate.dateData = (ulong)(long)minValue;
			}
			Func<DateTime, DateTime> func3 = default(Func<DateTime, DateTime>);
			if (_003C_003Ec._003C_003E9__167_2 == null)
			{
				func3 = (Func<DateTime, DateTime>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DateTime x) => x));
			}
			DateTime dateTime = Enumerable.First<DateTime>((IEnumerable<>)Enumerable.OrderBy<DateTime, DateTime>((IEnumerable<>)enumerable2, (Func<, >)(object)func3));
			nextTaskDate.dateData = (ulong)(long)dateTime;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x26FDB50", Offset = "0x26FC550", VA = "0x1826FDB50")]
		public DateTime TaskStartTime(BattlePassTask task)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x26FDA30", Offset = "0x26FC430", VA = "0x1826FDA30")]
		public bool TaskIsAvailable(BattlePassTask task, ITransactionContext context)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			num += num;
			int num3 = num3 + 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x26FBC90", Offset = "0x26FA690", VA = "0x1826FBC90")]
		public BattlePassReward GetMainReward()
		{
			//Discarded unreachable code: IL_0023, IL_0029, IL_002f, IL_0035
			int num = 0;
			int num2 = 0;
			BattlePassReward mainReward = MainReward;
			if (mainReward == null)
			{
				RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag && !flag2)
				{
				}
			}
			return mainReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x26F8AB0", Offset = "0x26F74B0", VA = "0x1826F8AB0", Slot = "14")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//IL_015c: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			//IL_01aa: Expected O, but got I4
			//IL_0237: Expected O, but got I4
			//IL_0297: Expected O, but got I4
			//IL_0297: Expected O, but got I4
			//IL_02b6: Expected O, but got I4
			//IL_02b6: Expected O, but got I4
			//IL_0312: Expected O, but got I4
			//IL_0329: Expected O, but got I4
			//IL_03ac: Expected O, but got I4
			//IL_03cc: Expected O, but got I4
			//IL_03cc: Expected O, but got I4
			//IL_03f8: Expected O, but got I4
			//IL_0418: Expected O, but got I4
			//IL_0418: Expected O, but got I4
			bool flag = default(bool);
			string message2 = default(string);
			DateTime dateTime3 = default(DateTime);
			Func<BattlePassRewardsPage, int> func = default(Func<BattlePassRewardsPage, int>);
			IEnumerable<BattlePassRewardsPage> enumerable = default(IEnumerable<BattlePassRewardsPage>);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			BattlePassRewardsPage battlePassRewardsPage = default(BattlePassRewardsPage);
			BattlePassRewardsPage battlePassRewardsPage2 = default(BattlePassRewardsPage);
			int count3 = default(int);
			BattlePassRewardsPage battlePassRewardsPage3 = default(BattlePassRewardsPage);
			int num13 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				string text = minGameVersion_;
				if (num != 0)
				{
					context.AddInvalidMemberError("Version cannot be empty and must contain only first two digits of the full game version (ex: 1.2).", "MinGameVersion");
				}
				if (!SemVer.TryParse(minGameVersion_ + ".0", out *(SemVer*)num))
				{
					string text2 = minGameVersion_;
					string message = "Version '" + text2 + "' must contain only first two digits of the full game version (ex: 1.2).";
					context.AddInvalidMemberError(message, "MinGameVersion");
				}
				long seconds = startDate_.date_.Seconds;
				long seconds2 = finishDate_.date_.Seconds;
				seconds = finishDate_.date_.Seconds;
				long seconds3 = endDate_.date_.Seconds;
				if (seconds > seconds3)
				{
					context.AddInvalidMemberError("Must be between StartDate and EndDate", "FinishDate");
				}
				Types.Price price = premiumPassPrice_;
				Types.Price price2 = currencyBundlePrice_;
				int id_ = price.id_;
				int id_2 = price2.id_;
				int id_3;
				if ((object)typeof(Item).TypeHandle != null)
				{
					Types.Price price3 = premiumPassPrice_;
					Types.Price price4 = eventCurrencyIncrementPrice_;
					id_3 = price3.id_;
					long num3 = Convert.ToInt64((uint)id_3);
					long num4 = Convert.ToInt64((uint)price4.id_);
				}
				context.AddError("Backend code limitation, doesn't support mixed currencies, fields PremiumPassPrice must be the same as CurrencyBundlePrice & EventCurrencyIncrementPrice");
				int amount_ = currencyBundlePrice_.amount_;
				Types.Price price5 = eventCurrencyIncrementPrice_;
				id_3 = currencyBundleAmount_;
				Types.Price price6 = eventCurrencyIncrementPrice_;
				amount_ = currencyBundleAmount_;
				string error = $"Bundle price {id_3} must be cheaper than the regular price {amount_}.";
				context.AddError(error);
				int num5 = premiumActiveTaskCount_;
				context.AddInvalidMemberError("Must be greater than FreeActiveTaskCount", "PremiumActiveTaskCount");
				int count = ((RepeatedField<T>)(object)taskConfig_.tasks_).Count;
				int num6 = premiumActiveTaskCount_;
				if (count < num6)
				{
					string error2 = $"Not enough tasks defined, must be greater or equal to {count}";
					context.AddError(error2);
				}
				DateTime dateTime = finishDate_.date_.ToDateTime();
				DateTime dateTime2 = startDate_.date_.ToDateTime();
				TimeSpan timeSpan = dateTime - dateTime2;
				RepeatedField<BattlePassTask> tasks_ = taskConfig_.tasks_;
				if (flag)
				{
					context.AddInvalidMemberError(message2, "AvailableOnDay");
					num2++;
				}
				int num7 = 0;
				if ((object)dateTime != null)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__173_1 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassTask x) => x.currencyReward_);
				}
				if (dateTime3 < (DateTime)num7 && _003C_003Ec._003C_003E9__173_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassRewardsPage x) => !x.isCurrencyConversionPage_);
				}
				if (_003C_003Ec._003C_003E9__173_3 == null)
				{
					func = (Func<BattlePassRewardsPage, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(BattlePassRewardsPage x)
					{
						//Discarded unreachable code: IL_002e
						RepeatedField<BattlePassReward> rewards_ = x.rewards_;
						Func<BattlePassReward, int> _003C_003E9__173_ = _003C_003Ec._003C_003E9__173_12;
						if (_003C_003E9__173_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassReward y) => y.price_);
						}
						return Enumerable.Sum<BattlePassReward>((IEnumerable<>)(object)rewards_, (Func<, >)(object)_003C_003E9__173_);
					});
				}
				int num8 = Enumerable.Sum<BattlePassRewardsPage>((IEnumerable<>)enumerable, (Func<, >)(object)func);
				if (num8 != num9)
				{
					string text3 = $"Sum of rewards from duties ({num8}) does not match the sum of all battle pass rewards prices ({num8}).";
				}
				if (num8 != num10)
				{
					num8 = num11;
					string text4 = string.Format("Number of reward pages ({0}) does not match the one defined in {1} ({2}).", num8, "RewardsSetup", num11);
				}
				if (num7 >= num12)
				{
					break;
				}
				if (!battlePassRewardsPage.isCurrencyConversionPage_)
				{
					int count2 = ((RepeatedField<T>)(object)battlePassRewardsPage2.rewards_).Count;
					if (num7 != count2)
					{
						object[] array = new object[4];
						count3 = ((RepeatedField<T>)(object)battlePassRewardsPage3.rewards_).Count;
						if (count3 != 0 && count3 == 0)
						{
							continue;
						}
						array[0] = count3;
						if (num13 != 0 && num13 == 0)
						{
							continue;
						}
						array[1] = num13;
						if ("RewardsSetup" != null && "RewardsSetup" == null)
						{
							continue;
						}
						array[2] = "RewardsSetup";
						if ("RewardsSetup" != null && "RewardsSetup" == null)
						{
							continue;
						}
						array[3] = "RewardsSetup";
						string text5 = string.Format("Number of rewards ({0}) in page {1} does not match the one defined in {2} ({3}).", array);
					}
				}
				num7++;
				break;
			}
			BattlePassReward battlePassReward = default(BattlePassReward);
			if (battlePassReward == null)
			{
			}
			if (_003C_003Ec._003C_003E9__173_4 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassRewardsPage x) => !x.isCurrencyConversionPage_);
			}
			Func<BattlePassRewardsPage, int> func2 = (Func<BattlePassRewardsPage, int>)(object)new Func<T, TResult>(((BattlePassSeasonData)count3)._003CDataValidation_003Eb__173_5);
			IEnumerable<BattlePassRewardsPage> enumerable2 = default(IEnumerable<BattlePassRewardsPage>);
			int num14 = Enumerable.Sum<BattlePassRewardsPage>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
			string text6 = string.Format("Amount of HC rewarded on the free track ({0}) does not match the one defined in {1} ({2}).", num14, "RewardsSetup", num14);
			if (_003C_003Ec._003C_003E9__173_6 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassRewardsPage x) => !x.isCurrencyConversionPage_);
			}
			Func<BattlePassRewardsPage, int> func3 = (Func<BattlePassRewardsPage, int>)(object)new Func<T, TResult>(((BattlePassSeasonData)num14)._003CDataValidation_003Eb__173_7);
			IEnumerable<BattlePassRewardsPage> enumerable3 = default(IEnumerable<BattlePassRewardsPage>);
			int num15 = Enumerable.Sum<BattlePassRewardsPage>((IEnumerable<>)enumerable3, (Func<, >)(object)func3);
			string text7 = string.Format("Amount of HC rewarded on the premium track ({0}) does not match the one defined in {1} ({2}).", num15, "RewardsSetup", num15);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x26FDBA0", Offset = "0x26FC5A0", VA = "0x1826FDBA0", Slot = "18")]
		public BattlePassConfigV2 ToServerConfig(string onlineId)
		{
			//Discarded unreachable code: IL_025e
			//IL_0070: Expected O, but got I4
			BattlePassConfigV2 battlePassConfigV = new BattlePassConfigV2();
			battlePassConfigV.OnlineId = onlineId;
			int num = (battlePassConfigV.Version = version_);
			DateTime dateTime = (battlePassConfigV.StartDate = startDate_.date_.ToDateTime());
			DateTime dateTime2 = (battlePassConfigV.FinishDate = finishDate_.date_.ToDateTime());
			DateTime dateTime3 = endDate_.date_.ToDateTime();
			int num2 = 0;
			battlePassConfigV.EndDate = (DateTime?)(object)num2;
			bool flag = (battlePassConfigV.IsHidden = !active_);
			string text = (battlePassConfigV.MinGameVersion = minGameVersion_);
			ServerLoc serverLoc = new ServerLoc();
			Dictionary<string, string> dictionary = (serverLoc.LocByLanguage = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			battlePassConfigV.TitleLoc = serverLoc;
			ServerLoc serverLoc2 = new ServerLoc();
			Dictionary<string, string> dictionary2 = (serverLoc2.LocByLanguage = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			battlePassConfigV.DescLoc = serverLoc2;
			ServerLoc serverLoc3 = new ServerLoc();
			Dictionary<string, string> dictionary3 = (serverLoc3.LocByLanguage = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			battlePassConfigV.CurrencyLoc = serverLoc3;
			glPlayFab.Disney.Price price = new glPlayFab.Disney.Price();
			int num3 = (price.CurrencyItemId = premiumPassPrice_.id_);
			int num4 = (price.Amount = premiumPassPrice_.amount_);
			battlePassConfigV.PremiumPassPrice = price;
			int num5 = (battlePassConfigV.EventCurrencyIncrement = eventCurrencyIncrement_);
			glPlayFab.Disney.Price price2 = new glPlayFab.Disney.Price();
			int num6 = (price2.CurrencyItemId = eventCurrencyIncrementPrice_.id_);
			int num7 = (price2.Amount = eventCurrencyIncrementPrice_.amount_);
			battlePassConfigV.EventCurrencyIncrementPrice = price2;
			int num8 = (battlePassConfigV.CurrencyBundleAmount = currencyBundleAmount_);
			glPlayFab.Disney.Price price3 = new glPlayFab.Disney.Price();
			int num9 = (price3.CurrencyItemId = currencyBundlePrice_.id_);
			int num10 = (price3.Amount = currencyBundlePrice_.amount_);
			battlePassConfigV.CurrencyBundlePrice = price3;
			BattlePassTaskConfigV2 battlePassTaskConfigV = (battlePassConfigV.TaskConfig = taskConfig_.ToServerConfig());
			int num11 = (battlePassConfigV.FreeActiveTaskCount = freeActiveTaskCount_);
			int num12 = (battlePassConfigV.PremiumActiveTaskCount = premiumActiveTaskCount_);
			List<glPlayFab.Disney.BattlePassRewardsPage> list = (battlePassConfigV.RewardsPages = (List<glPlayFab.Disney.BattlePassRewardsPage>)(object)new List<T>());
			string text2 = (battlePassConfigV.MainReward = rewardsSetup_.mainReward_);
			BattlePassConfigV2 serverBPConfig = battlePassConfigV;
			RepeatedField<BattlePassRewardsPage> repeatedField = rewardsPages_;
			Action<BattlePassRewardsPage> action = (Action<BattlePassRewardsPage>)(object)(Action<T>)delegate(BattlePassRewardsPage x)
			{
				//Discarded unreachable code: IL_009d
				List<glPlayFab.Disney.BattlePassRewardsPage> _003CRewardsPages_003Ek__BackingField = serverBPConfig.RewardsPages;
				glPlayFab.Disney.BattlePassRewardsPage battlePassRewardsPage = new glPlayFab.Disney.BattlePassRewardsPage();
				UnlockRequirementTask unlockRequirementTask = x.UnlockRequirementTask;
				int _003CUnlockRequirementMinTaskCollected_003Ek__BackingField = 0;
				if (unlockRequirementTask != null)
				{
				}
				battlePassRewardsPage.UnlockRequirementMinTaskCollected = _003CUnlockRequirementMinTaskCollected_003Ek__BackingField;
				UnlockRequirementReward unlockRequirementReward = x.UnlockRequirementReward;
				int minPurchased_ = default(int);
				if (unlockRequirementReward != null)
				{
					minPurchased_ = unlockRequirementReward.minPurchased_;
				}
				battlePassRewardsPage.UnlockRequirementMinRewardPurchased = minPurchased_;
				RepeatedField<BattlePassReward> rewards_ = x.rewards_;
				Func<BattlePassReward, glPlayFab.Disney.BattlePassReward> func = default(Func<BattlePassReward, glPlayFab.Disney.BattlePassReward>);
				if (_003C_003Ec._003C_003E9__174_1 == null)
				{
					func = (Func<BattlePassReward, glPlayFab.Disney.BattlePassReward>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassReward y) => y.ToServerReward()));
				}
				List<glPlayFab.Disney.BattlePassReward> list2 = (battlePassRewardsPage.Rewards = (List<glPlayFab.Disney.BattlePassReward>)(object)Enumerable.ToList<glPlayFab.Disney.BattlePassReward>(Enumerable.Select<BattlePassReward, glPlayFab.Disney.BattlePassReward>((IEnumerable<>)(object)rewards_, (Func<, >)(object)func)));
				bool flag2 = (battlePassRewardsPage.IsCurrencyConversionPage = x.isCurrencyConversionPage_);
				((List<T>)(object)_003CRewardsPages_003Ek__BackingField).Add((T)battlePassRewardsPage);
			};
			((RepeatedField<>)(object)repeatedField).ForEach<BattlePassRewardsPage>((Action<>)(object)action);
			string text3 = title_;
			string text4 = description_;
			string text5 = currencyName_;
			return (BattlePassConfigV2)(object)"neutral";
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x26FAB10", Offset = "0x26F9510", VA = "0x1826FAB10")]
		public static BattlePassSeasonData FromServerConfig(BattlePassConfigV2 serverBPConfig, DateTime lastUpdateTimestamp)
		{
			//Discarded unreachable code: IL_03c6, IL_03cc, IL_03d2, IL_03d8, IL_03de, IL_03e4, IL_03ea
			//IL_005d: Expected I4, but got I8
			//IL_0094: Expected I4, but got I8
			//IL_00dc: Expected I4, but got I8
			//IL_00e3: Expected O, but got I4
			//IL_0156: Expected I4, but got I8
			//IL_02d7: Expected I4, but got I8
			//IL_02e1: Expected I4, but got I8
			//IL_034d: Expected I4, but got O
			//IL_0355: Expected O, but got I4
			//IL_035e: Expected I4, but got O
			//IL_036e: Expected I4, but got O
			//IL_0376: Expected O, but got I4
			//IL_037f: Expected I4, but got O
			//IL_03b7: Expected I4, but got O
			int num = 0;
			BattlePassSeasonData battlePassSeasonData = new BattlePassSeasonData();
			string text = (battlePassSeasonData.onlineId_ = ProtoPreconditions.CheckNotNull(serverBPConfig.OnlineId, "value"));
			int num2 = (battlePassSeasonData.version_ = serverBPConfig.Version);
			ConditionDate conditionDate = new ConditionDate();
			Timestamp timestamp = (conditionDate.date_ = serverBPConfig.StartDate.ToProto());
			conditionDate.localTime_ = (byte)num != 0;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			battlePassSeasonData.startDate_ = conditionDate;
			ConditionDate conditionDate2 = new ConditionDate();
			Timestamp timestamp2 = (conditionDate2.date_ = serverBPConfig.FinishDate.ToProto());
			conditionDate2.localTime_ = (byte)num != 0;
			conditionDate2.operator_ = IntOperator.LessThan;
			battlePassSeasonData.finishDate_ = conditionDate2;
			DateTime? _003CEndDate_003Ek__BackingField = serverBPConfig.EndDate;
			if (timestamp2 != null)
			{
				ConditionDate conditionDate3 = new ConditionDate();
				DateTime? _003CEndDate_003Ek__BackingField2 = serverBPConfig.EndDate;
				DateTime dateTime = default(DateTime);
				Timestamp timestamp3 = (conditionDate3.date_ = dateTime.ToProto());
				conditionDate3.localTime_ = (byte)num != 0;
				conditionDate3.operator_ = IntOperator.LessThan;
			}
			battlePassSeasonData.endDate_ = (ConditionDate)num;
			bool flag = (battlePassSeasonData.active_ = (serverBPConfig.IsHidden ? 1 : 0) == num);
			string text2 = (battlePassSeasonData.minGameVersion_ = ProtoPreconditions.CheckNotNull(serverBPConfig.MinGameVersion, "value"));
			int num3 = 0;
			string text3 = (battlePassSeasonData.language_ = ProtoPreconditions.CheckNotNull(LocalizationUtil.CurrentLanguage, "value"));
			ConditionDate conditionDate4 = new ConditionDate();
			Timestamp timestamp4 = (conditionDate4.date_ = lastUpdateTimestamp.ToProto());
			conditionDate4.localTime_ = (byte)num != 0;
			conditionDate4.operator_ = IntOperator.GreaterThanOrEqual;
			battlePassSeasonData.lastUpdateTimestamp_ = conditionDate4;
			string text4 = (battlePassSeasonData.title_ = ProtoPreconditions.CheckNotNull(serverBPConfig.TitleLoc.GetLocalizedText(), "value"));
			string text5 = (battlePassSeasonData.description_ = ProtoPreconditions.CheckNotNull(serverBPConfig.DescLoc.GetLocalizedText(), "value"));
			string text6 = (battlePassSeasonData.currencyName_ = ProtoPreconditions.CheckNotNull(serverBPConfig.CurrencyLoc.GetLocalizedText(), "value"));
			Types.Price price = new Types.Price();
			int num4 = (price.id_ = serverBPConfig.PremiumPassPrice.CurrencyItemId);
			int num5 = (price.amount_ = serverBPConfig.PremiumPassPrice.Amount);
			battlePassSeasonData.premiumPassPrice_ = price;
			int num6 = (battlePassSeasonData.eventCurrencyIncrement_ = serverBPConfig.EventCurrencyIncrement);
			Types.Price price2 = new Types.Price();
			int num7 = (price2.id_ = serverBPConfig.EventCurrencyIncrementPrice.CurrencyItemId);
			int num8 = (price2.amount_ = serverBPConfig.EventCurrencyIncrementPrice.Amount);
			battlePassSeasonData.eventCurrencyIncrementPrice_ = price2;
			int num9 = (battlePassSeasonData.currencyBundleAmount_ = serverBPConfig.CurrencyBundleAmount);
			Types.Price price3 = new Types.Price();
			int num10 = (price3.id_ = serverBPConfig.CurrencyBundlePrice.CurrencyItemId);
			int num11 = (price3.amount_ = serverBPConfig.CurrencyBundlePrice.Amount);
			battlePassSeasonData.currencyBundlePrice_ = price3;
			int num12 = (battlePassSeasonData.freeActiveTaskCount_ = serverBPConfig.FreeActiveTaskCount);
			BattlePassTaskConfig battlePassTaskConfig = (battlePassSeasonData.taskConfig_ = BattlePassTaskConfig.FromServerConfig(serverBPConfig.TaskConfig));
			int num13 = (battlePassSeasonData.premiumActiveTaskCount_ = serverBPConfig.PremiumActiveTaskCount);
			BattlePassRewardsSetup battlePassRewardsSetup = default(BattlePassRewardsSetup);
			battlePassRewardsSetup.mainReward_ = "";
			battlePassRewardsSetup.pagesNum_ = 1;
			battlePassRewardsSetup.rewardsNumPerPage_ = 1;
			int num14 = (battlePassRewardsSetup.pagesNum_ = serverBPConfig.NumPages);
			int num15 = (battlePassRewardsSetup.rewardsNumPerPage_ = serverBPConfig.NumRewardsPerPage);
			string text7 = (battlePassRewardsSetup.mainReward_ = ProtoPreconditions.CheckNotNull(serverBPConfig.MainReward, "value"));
			battlePassSeasonData.rewardsSetup_ = battlePassRewardsSetup;
			List<glPlayFab.Disney.BattlePassRewardsPage> _003CRewardsPages_003Ek__BackingField = serverBPConfig.RewardsPages;
			bool flag2 = default(bool);
			if (flag2)
			{
				BattlePassRewardsPage battlePassRewardsPage = new BattlePassRewardsPage();
				UnlockRequirementTask unlockRequirementTask = new UnlockRequirementTask();
				unlockRequirementTask.minCollected_ = (int)unlockRequirementTask;
				battlePassRewardsPage.unlockRequirement_ = num;
				battlePassRewardsPage.unlockRequirementCase_ = (BattlePassRewardsPage.UnlockRequirementOneofCase)unlockRequirementTask;
				UnlockRequirementReward unlockRequirementReward = new UnlockRequirementReward();
				unlockRequirementReward.minPurchased_ = (int)unlockRequirementReward;
				battlePassRewardsPage.unlockRequirement_ = num;
				battlePassRewardsPage.unlockRequirementCase_ = (BattlePassRewardsPage.UnlockRequirementOneofCase)unlockRequirementReward;
				RepeatedField<BattlePassReward> rewards_ = battlePassRewardsPage.rewards_;
				if (_003C_003Ec._003C_003E9__175_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((glPlayFab.Disney.BattlePassReward x) => BattlePassReward.FromServerReward(x));
				}
				IEnumerable<glPlayFab.Disney.BattlePassReward> enumerable = default(IEnumerable<glPlayFab.Disney.BattlePassReward>);
				((RepeatedField<T>)(object)rewards_).AddRange((IEnumerable<>)enumerable);
				battlePassRewardsPage.isCurrencyConversionPage_ = (byte)(int)enumerable != 0;
				((RepeatedField<T>)(object)battlePassSeasonData.rewardsPages_).Add((T)battlePassRewardsPage);
			}
			return battlePassSeasonData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x26FF140", Offset = "0x26FDB40", VA = "0x1826FF140")]
		static BattlePassSeasonData()
		{
			MessageParser<BattlePassRewardsPage> parser = BattlePassRewardsPage._parser;
			uint num = default(uint);
			_parser = (MessageParser<BattlePassSeasonData>)(object)FieldCodec.ForMessage<BattlePassRewardsPage>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
