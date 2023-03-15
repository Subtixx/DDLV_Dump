using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class OnlinePromoCodeData : IMessage<OnlinePromoCodeData>, IMessage, IEquatable<OnlinePromoCodeData>, IDeepCloneable<OnlinePromoCodeData>, IMessageFieldAccessor, IDataValidation, ISegment, IFetchable, ITimeLimited
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			public sealed class RewardContent : IMessage<RewardContent>, IMessage, IEquatable<RewardContent>, IDeepCloneable<RewardContent>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				private static readonly MessageParser<RewardContent> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40002D2")]
				public const int ItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002D3")]
				private int itemId_;

				[Cpp2IlInjected.Token(Token = "0x40002D4")]
				public const int QuantityFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40002D5")]
				private int quantity_;

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				[DebuggerNonUserCode]
				public static MessageParser<RewardContent> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000668")]
					[Cpp2IlInjected.Address(RVA = "0x2FF2450", Offset = "0x2FF0E50", VA = "0x182FF2450")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000669")]
					[Cpp2IlInjected.Address(RVA = "0x2FF22F0", Offset = "0x2FF0CF0", VA = "0x182FF22F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600066A")]
					[Cpp2IlInjected.Address(RVA = "0x2FF2570", Offset = "0x2FF0F70", VA = "0x182FF2570", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				[DebuggerNonUserCode]
				public int ItemId
				{
					[Cpp2IlInjected.Token(Token = "0x600066E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600066F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				[DebuggerNonUserCode]
				public int Quantity
				{
					[Cpp2IlInjected.Token(Token = "0x6000670")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000671")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600066B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public RewardContent()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600066C")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public RewardContent(RewardContent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600066D")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1AD0", Offset = "0x2FF04D0", VA = "0x182FF1AD0", Slot = "10")]
				[DebuggerNonUserCode]
				public RewardContent Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000672")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1C80", Offset = "0x2FF0680", VA = "0x182FF1C80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000673")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(RewardContent other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000674")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000675")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2010", Offset = "0x2FF0A10", VA = "0x182FF2010", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000676")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000677")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1930", Offset = "0x2FF0330", VA = "0x182FF1930", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000678")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(RewardContent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000679")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600067A")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1D10", Offset = "0x2FF0710", VA = "0x182FF1D10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600067B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1E90", Offset = "0x2FF0890", VA = "0x182FF1E90", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600067C")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static readonly MessageParser<OnlinePromoCodeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public const int MinGameVersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private string minGameVersion_;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public const int TargetLiveUsersFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private bool targetLiveUsers_;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public const int ActiveFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private bool active_;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public const int TitleFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private string title_;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public const int DescriptionFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public const int IconAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public const int PromoCodeIdFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private string promoCodeId_;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public const int StartDateFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private ConditionDate startDate_;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public const int EndDateFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private ConditionDate endDate_;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public const int ContentsFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly FieldCodec<Types.RewardContent> _repeated_contents_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private readonly RepeatedField<Types.RewardContent> contents_;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public const int FilterTypeFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private FilterType filterType_;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public const int ClaimLimitFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private int claimLimit_;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public const int LanguageFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private string language_;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public const int LastUpdateTimestampFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private ConditionDate lastUpdateTimestamp_;

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlinePromoCodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x29914A0", Offset = "0x298FEA0", VA = "0x1829914A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x29913D0", Offset = "0x298FDD0", VA = "0x1829913D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2991500", Offset = "0x298FF00", VA = "0x182991500", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "17")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		[DebuggerNonUserCode]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return minGameVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2991760", Offset = "0x2990160", VA = "0x182991760", Slot = "19")]
			set
			{
				string text = (minGameVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[DebuggerNonUserCode]
		public bool TargetLiveUsers
		{
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return targetLiveUsers_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				targetLiveUsers_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		[DebuggerNonUserCode]
		public bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560", Slot = "20")]
			get
			{
				return active_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0", Slot = "21")]
			set
			{
				active_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "22")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2991840", Offset = "0x2990240", VA = "0x182991840", Slot = "23")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "24")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2991610", Offset = "0x2990010", VA = "0x182991610", Slot = "25")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "26")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2991680", Offset = "0x2990080", VA = "0x182991680", Slot = "27")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		[DebuggerNonUserCode]
		public string PromoCodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return promoCodeId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x29917D0", Offset = "0x29901D0", VA = "0x1829917D0")]
			set
			{
				string text = (promoCodeId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		[DebuggerNonUserCode]
		public ConditionDate StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "32")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		[DebuggerNonUserCode]
		public ConditionDate EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "33")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.RewardContent> Contents
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return contents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[DebuggerNonUserCode]
		public FilterType FilterType
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "15")]
			get
			{
				return filterType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				filterType_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[DebuggerNonUserCode]
		public int ClaimLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get
			{
				return claimLimit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				claimLimit_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "28")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x29916F0", Offset = "0x29900F0", VA = "0x1829916F0", Slot = "29")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		[DebuggerNonUserCode]
		public ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80", Slot = "30")]
			get
			{
				return lastUpdateTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0", Slot = "31")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x2990F70", Offset = "0x298F970", VA = "0x182990F70")]
		[DebuggerNonUserCode]
		public OnlinePromoCodeData()
		{
			//IL_007f: Expected I4, but got I8
			minGameVersion_ = "";
			title_ = "";
			description_ = "";
			iconAddress_ = "";
			promoCodeId_ = "";
			contents_ = (RepeatedField<Types.RewardContent>)(object)new RepeatedField<T>();
			language_ = "";
			base._002Ector();
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			string text = (title_ = ProtoPreconditions.CheckNotNull("Code Claimed", "value"));
			string text2 = (description_ = ProtoPreconditions.CheckNotNull("This is your reward for claiming code", "value"));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2990380", Offset = "0x298ED80", VA = "0x182990380")]
		private void OnConstruction()
		{
			//IL_002a: Expected I4, but got I8
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			string text = (title_ = ProtoPreconditions.CheckNotNull("Code Claimed", "value"));
			string text2 = (description_ = ProtoPreconditions.CheckNotNull("This is your reward for claiming code", "value"));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2991220", Offset = "0x298FC20", VA = "0x182991220")]
		[DebuggerNonUserCode]
		public OnlinePromoCodeData(OnlinePromoCodeData other)
		{
			//IL_0099: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			int num = (version_ = other.version_);
			string text = (minGameVersion_ = other.minGameVersion_);
			bool flag = (targetLiveUsers_ = other.targetLiveUsers_);
			bool flag2 = (active_ = other.active_);
			string text2 = (title_ = other.title_);
			string text3 = (description_ = other.description_);
			string text4 = (iconAddress_ = other.iconAddress_);
			string text5 = (promoCodeId_ = other.promoCodeId_);
			ConditionDate conditionDate = other.startDate_;
			int num2 = 0;
			if (conditionDate != null)
			{
				ConditionDate conditionDate2 = conditionDate.Clone();
			}
			startDate_ = (ConditionDate)num2;
			ConditionDate conditionDate3 = other.endDate_;
			if (conditionDate3 != null)
			{
				ConditionDate conditionDate4 = conditionDate3.Clone();
			}
			endDate_ = (ConditionDate)num2;
			RepeatedField<Types.RewardContent> repeatedField = (contents_ = (RepeatedField<Types.RewardContent>)(object)((RepeatedField<T>)(object)other.contents_).Clone());
			FilterType filterType = other.filterType_;
			if (filterType != null)
			{
				FilterType filterType2 = filterType.Clone();
			}
			filterType_ = (FilterType)num2;
			int num3 = (claimLimit_ = other.claimLimit_);
			string text6 = (language_ = other.language_);
			ConditionDate conditionDate5 = other.lastUpdateTimestamp_;
			ConditionDate conditionDate6 = default(ConditionDate);
			if (conditionDate5 != null)
			{
				conditionDate6 = conditionDate5.Clone();
			}
			lastUpdateTimestamp_ = conditionDate6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x298F4F0", Offset = "0x298DEF0", VA = "0x18298F4F0", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlinePromoCodeData Clone()
		{
			return new OnlinePromoCodeData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x298F6A0", Offset = "0x298E0A0", VA = "0x18298F6A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((OnlinePromoCodeData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x298F700", Offset = "0x298E100", VA = "0x18298F700", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlinePromoCodeData other)
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
						bool flag = other.targetLiveUsers_;
						if (targetLiveUsers_ == flag)
						{
							bool flag2 = other.active_;
							if (active_ == flag2)
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
											string text5 = other.promoCodeId_;
											if (!(promoCodeId_ != text5))
											{
												ConditionDate objB = other.startDate_;
												if (object.Equals(startDate_, objB))
												{
													ConditionDate objB2 = other.endDate_;
													if (object.Equals(endDate_, objB2))
													{
														RepeatedField<Types.RewardContent> repeatedField = contents_;
														RepeatedField<Types.RewardContent> repeatedField2 = other.contents_;
														if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
														{
															FilterType objB3 = other.filterType_;
															if (object.Equals(filterType_, objB3))
															{
																int num2 = other.claimLimit_;
																if (claimLimit_ == num2)
																{
																	string text6 = other.language_;
																	if (!(language_ != text6))
																	{
																		ConditionDate objB4 = other.lastUpdateTimestamp_;
																		if (object.Equals(lastUpdateTimestamp_, objB4))
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x298FAB0", Offset = "0x298E4B0", VA = "0x18298FAB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_013f
			if (version_ != 0)
			{
			}
			string text = minGameVersion_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (targetLiveUsers_)
			{
			}
			if (active_)
			{
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = promoCodeId_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int hashCode6 = conditionDate.GetHashCode();
			}
			ConditionDate conditionDate2 = endDate_;
			if (conditionDate2 != null)
			{
				int hashCode7 = conditionDate2.GetHashCode();
			}
			int hashCode8 = ((RepeatedField<T>)(object)contents_).GetHashCode();
			FilterType filterType = filterType_;
			if (filterType != null)
			{
				int hashCode9 = filterType.GetHashCode();
			}
			if (claimLimit_ != 0)
			{
			}
			string text6 = language_;
			if (text6.m_stringLength != 0)
			{
				int hashCode10 = text6.GetHashCode();
			}
			ConditionDate conditionDate3 = lastUpdateTimestamp_;
			if (conditionDate3 != null)
			{
				int hashCode11 = conditionDate3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode12 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x29909E0", Offset = "0x298F3E0", VA = "0x1829909E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x2990A40", Offset = "0x298F440", VA = "0x182990A40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01ab
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
			if (targetLiveUsers_)
			{
				bool value3 = targetLiveUsers_;
				output.WriteBool(value3);
			}
			if (active_)
			{
				bool value4 = active_;
				output.WriteBool(value4);
			}
			if (title_.m_stringLength != 0)
			{
				string value5 = title_;
				output.WriteString(value5);
			}
			if (description_.m_stringLength != 0)
			{
				string value6 = description_;
				output.WriteString(value6);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value7 = iconAddress_;
				output.WriteString(value7);
			}
			if (promoCodeId_.m_stringLength != 0)
			{
				string value8 = promoCodeId_;
				output.WriteString(value8);
			}
			if ((long)startDate_ != 0)
			{
				ConditionDate value9 = startDate_;
				output.WriteMessage(value9);
			}
			if ((long)endDate_ != 0)
			{
				ConditionDate value10 = endDate_;
				output.WriteMessage(value10);
			}
			RepeatedField<Types.RewardContent> repeatedField = contents_;
			FieldCodec<Types.RewardContent> repeated_contents_codec = _repeated_contents_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_contents_codec);
			if ((long)filterType_ != 0)
			{
				FilterType value11 = filterType_;
				output.WriteMessage(value11);
			}
			if (claimLimit_ != 0)
			{
				int value12 = claimLimit_;
				output.WriteInt32(value12);
			}
			if (language_.m_stringLength != 0)
			{
				string value13 = language_;
				output.WriteString(value13);
			}
			if ((long)lastUpdateTimestamp_ != 0)
			{
				ConditionDate value14 = lastUpdateTimestamp_;
				output.WriteMessage(value14);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x298EF80", Offset = "0x298D980", VA = "0x18298EF80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01d6
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
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			string text5 = promoCodeId_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(conditionDate);
				num9++;
				num2 += num9;
			}
			ConditionDate conditionDate2 = endDate_;
			if (conditionDate2 != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(conditionDate2);
				num10++;
				num2 += num10;
			}
			RepeatedField<Types.RewardContent> repeatedField = contents_;
			FieldCodec<Types.RewardContent> repeated_contents_codec = _repeated_contents_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_contents_codec);
			FilterType filterType = filterType_;
			num2 += num11;
			if (filterType != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(filterType);
				num12++;
				num2 += num12;
			}
			int num13 = claimLimit_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			string text6 = language_;
			if (text6.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text6);
				num15++;
				num2 += num15;
			}
			ConditionDate conditionDate3 = lastUpdateTimestamp_;
			if (conditionDate3 != null)
			{
				int num16 = CodedOutputStream.ComputeMessageSize(conditionDate3);
				num16++;
				num2 += num16;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				num2 += num17;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x298FCD0", Offset = "0x298E6D0", VA = "0x18298FCD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlinePromoCodeData other)
		{
			//Discarded unreachable code: IL_0214
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
			bool flag = other.targetLiveUsers_;
			if (flag)
			{
				targetLiveUsers_ = flag;
			}
			bool flag2 = other.active_;
			if (flag2)
			{
				active_ = flag2;
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
			string text5 = other.promoCodeId_;
			if (text5.m_stringLength != 0)
			{
				PromoCodeId = text5;
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
			if ((long)other.endDate_ != 0)
			{
				ConditionDate conditionDate4 = default(ConditionDate);
				if (endDate_ == null)
				{
					ConditionDate conditionDate3 = (endDate_ = new ConditionDate());
					conditionDate4 = endDate_;
				}
				ConditionDate other3 = other.endDate_;
				conditionDate4.MergeFrom(other3);
			}
			RepeatedField<Types.RewardContent> repeatedField = contents_;
			RepeatedField<Types.RewardContent> repeatedField2 = other.contents_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.filterType_ != 0)
			{
				FilterType filterType2 = default(FilterType);
				if (filterType_ == null)
				{
					FilterType filterType = (filterType_ = new FilterType());
					filterType2 = filterType_;
				}
				FilterType other4 = other.filterType_;
				filterType2.MergeFrom(other4);
			}
			int num2 = other.claimLimit_;
			if (num2 != 0)
			{
				claimLimit_ = num2;
			}
			string text6 = other.language_;
			if (text6.m_stringLength != 0)
			{
				Language = text6;
			}
			if ((long)other.lastUpdateTimestamp_ != 0)
			{
				ConditionDate conditionDate6 = default(ConditionDate);
				if (lastUpdateTimestamp_ == null)
				{
					ConditionDate conditionDate5 = (lastUpdateTimestamp_ = new ConditionDate());
					conditionDate6 = lastUpdateTimestamp_;
				}
				ConditionDate other5 = other.lastUpdateTimestamp_;
				conditionDate6.MergeFrom(other5);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x298FFC0", Offset = "0x298E9C0", VA = "0x18298FFC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_021a
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 90)
				{
					if ((int)num > 104)
					{
						if (num == 114)
						{
							string text2 = (Language = input.ReadString());
						}
						if (num != 122)
						{
							goto IL_0203;
						}
						ConditionDate builder = default(ConditionDate);
						if (lastUpdateTimestamp_ == null)
						{
							ConditionDate conditionDate = (lastUpdateTimestamp_ = new ConditionDate());
							builder = lastUpdateTimestamp_;
						}
						input.ReadMessage(builder);
					}
					FilterType filterType = default(FilterType);
					if (num == 98)
					{
						FilterType builder2 = default(FilterType);
						if (filterType_ == null)
						{
							filterType = (filterType_ = new FilterType());
							builder2 = filterType_;
						}
						input.ReadMessage(builder2);
					}
					if ((long)filterType != 104)
					{
						goto IL_0203;
					}
					int num2 = (claimLimit_ = input.ReadInt32());
				}
				ConditionDate conditionDate2 = default(ConditionDate);
				if ((int)num > 74)
				{
					if (num == 82)
					{
						ConditionDate builder3 = default(ConditionDate);
						if (endDate_ == null)
						{
							conditionDate2 = (endDate_ = new ConditionDate());
							builder3 = endDate_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)conditionDate2 != 90)
					{
						goto IL_0203;
					}
					RepeatedField<Types.RewardContent> repeatedField = contents_;
					FieldCodec<Types.RewardContent> repeated_contents_codec = _repeated_contents_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_contents_codec);
				}
				string text4 = default(string);
				if ((long)conditionDate2 == 66)
				{
					text4 = (PromoCodeId = input.ReadString());
				}
				if ((long)text4 != 74)
				{
					goto IL_0203;
				}
				ConditionDate builder4 = default(ConditionDate);
				if (startDate_ == null)
				{
					ConditionDate conditionDate3 = (startDate_ = new ConditionDate());
					builder4 = startDate_;
				}
				input.ReadMessage(builder4);
			}
			string text10 = default(string);
			if ((int)num > 24)
			{
				string text8 = default(string);
				if ((int)num > 42)
				{
					string text6 = default(string);
					if (num == 50)
					{
						text6 = (Description = input.ReadString());
					}
					if ((long)text6 != 58)
					{
						goto IL_0203;
					}
					text8 = (IconAddress = input.ReadString());
				}
				bool flag = default(bool);
				if ((long)text8 == 32)
				{
					flag = (active_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0203;
				}
				text10 = (Title = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text10 == 8)
			{
				num3 = (version_ = input.ReadInt32());
			}
			string text12 = default(string);
			if (num3 == 18)
			{
				text12 = (MinGameVersion = input.ReadString());
			}
			if ((long)text12 == 24)
			{
				bool flag2 = (targetLiveUsers_ = input.ReadBool());
			}
			goto IL_0203;
			IL_0203:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x298F8C0", Offset = "0x298E2C0", VA = "0x18298F8C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 14)
			{
				int num = version_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2990540", Offset = "0x298EF40", VA = "0x182990540", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_0026, IL_002e, IL_0036, IL_0037, IL_0038, IL_0039, IL_003a, IL_0042, IL_004a, IL_004b, IL_0051, IL_0057, IL_005d, IL_0063, IL_0069, IL_006f, IL_0075, IL_007b
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			if (fieldNumber - 1 <= 14)
			{
				object obj = default(object);
				version_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x298F310", Offset = "0x298DD10", VA = "0x18298F310", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_001a, IL_001b, IL_001d
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 14)
			{
				version_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x298F550", Offset = "0x298DF50", VA = "0x18298F550", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_007c
			if (targetLiveUsers_)
			{
				if ((long)endDate_ != 0)
				{
					long seconds = startDate_.date_.Seconds;
					long seconds2 = endDate_.date_.Seconds;
					if (seconds <= seconds2)
					{
						goto IL_0045;
					}
				}
				context.AddError("Start Date and End Date must be set, and Start Date must be a date before the End Date.");
			}
			goto IL_0045;
			IL_0045:
			string text = promoCodeId_;
			if ("Contents" != null)
			{
				context.AddError("The Promo Code Id have to be filled");
			}
			int count = ((RepeatedField<T>)(object)contents_).Count;
			context.AddInvalidMemberError("Store must contain at least 1 valid content.", "Contents");
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2990DA0", Offset = "0x298F7A0", VA = "0x182990DA0")]
		static OnlinePromoCodeData()
		{
			Func<OnlinePromoCodeData> func = default(Func<OnlinePromoCodeData>);
			_parser = (MessageParser<OnlinePromoCodeData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.RewardContent> parser = Types.RewardContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<OnlinePromoCodeData>)(object)FieldCodec.ForMessage<Types.RewardContent>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
