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
using Newtonsoft.Json.Linq;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class OnlineBundleData : IMessage<OnlineBundleData>, IMessage, IEquatable<OnlineBundleData>, IDeepCloneable<OnlineBundleData>, IMessageFieldAccessor, IDataValidation, ISegment, IClientLiveopsConfig<BundleConfig>, IFetchable, ITimeLimited, IHasOnlineItemDependencies, IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			public sealed class BundleContent : IMessage<BundleContent>, IMessage, IEquatable<BundleContent>, IDeepCloneable<BundleContent>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40002A0")]
				private static readonly MessageParser<BundleContent> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002A1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40002A2")]
				public const int ItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002A3")]
				private int itemId_;

				[Cpp2IlInjected.Token(Token = "0x40002A4")]
				public const int QuantityFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40002A5")]
				private int quantity_;

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				[DebuggerNonUserCode]
				public static MessageParser<BundleContent> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000613")]
					[Cpp2IlInjected.Address(RVA = "0x2FE7B50", Offset = "0x2FE6550", VA = "0x182FE7B50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000614")]
					[Cpp2IlInjected.Address(RVA = "0x2FE7AD0", Offset = "0x2FE64D0", VA = "0x182FE7AD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000615")]
					[Cpp2IlInjected.Address(RVA = "0x2FE7BB0", Offset = "0x2FE65B0", VA = "0x182FE7BB0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				[DebuggerNonUserCode]
				public int ItemId
				{
					[Cpp2IlInjected.Token(Token = "0x6000619")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600061A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				[DebuggerNonUserCode]
				public int Quantity
				{
					[Cpp2IlInjected.Token(Token = "0x600061B")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600061C")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000616")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public BundleContent()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public BundleContent(BundleContent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0x2FE76C0", Offset = "0x2FE60C0", VA = "0x182FE76C0", Slot = "10")]
				[DebuggerNonUserCode]
				public BundleContent Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600061D")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7750", Offset = "0x2FE6150", VA = "0x182FE7750", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600061E")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BundleContent other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7960", Offset = "0x2FE6360", VA = "0x182FE7960", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000622")]
				[Cpp2IlInjected.Address(RVA = "0x2FE75F0", Offset = "0x2FE5FF0", VA = "0x182FE75F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000623")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BundleContent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000624")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0x2FE77E0", Offset = "0x2FE61E0", VA = "0x182FE77E0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000626")]
				[Cpp2IlInjected.Address(RVA = "0x2FE78A0", Offset = "0x2FE62A0", VA = "0x182FE78A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private static readonly MessageParser<OnlineBundleData> _parser = (MessageParser<OnlineBundleData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new OnlineBundleData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public const int MinGameVersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private string minGameVersion_;

		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public const int ActiveFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private bool active_;

		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public const int TitleFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private string title_;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public const int DescriptionFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const int IconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const int StartDateFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private ConditionDate startDate_;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public const int EndDateFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private ConditionDate endDate_;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public const int ContentsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private static readonly FieldCodec<Types.BundleContent> _repeated_contents_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private readonly RepeatedField<Types.BundleContent> contents_;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const int AvailablePricesFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly FieldCodec<ContentPrice> _repeated_availablePrices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private readonly RepeatedField<ContentPrice> availablePrices_;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const int IAPDataFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private string iAPData_;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const int FilterTypeFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private FilterType filterType_;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const int OnlineIdFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private string onlineId_;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const int LanguageFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private string language_;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const int LastUpdateTimestampFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private ConditionDate lastUpdateTimestamp_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineBundleData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x298B5F0", Offset = "0x2989FF0", VA = "0x18298B5F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x298B2F0", Offset = "0x2989CF0", VA = "0x18298B2F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x298B650", Offset = "0x298A050", VA = "0x18298B650", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "18")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[DebuggerNonUserCode]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return minGameVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x298B920", Offset = "0x298A320", VA = "0x18298B920", Slot = "20")]
			set
			{
				string text = (minGameVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		[DebuggerNonUserCode]
		public bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "21")]
			get
			{
				return active_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0", Slot = "22")]
			set
			{
				active_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "23")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x298BA00", Offset = "0x298A400", VA = "0x18298BA00", Slot = "24")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x298B760", Offset = "0x298A160", VA = "0x18298B760", Slot = "26")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x298B840", Offset = "0x298A240", VA = "0x18298B840", Slot = "28")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[DebuggerNonUserCode]
		public ConditionDate StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "33")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		[DebuggerNonUserCode]
		public ConditionDate EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "34")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.BundleContent> Contents
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return contents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[DebuggerNonUserCode]
		public RepeatedField<ContentPrice> AvailablePrices
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return availablePrices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[DebuggerNonUserCode]
		public string IAPData
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return iAPData_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x298B7D0", Offset = "0x298A1D0", VA = "0x18298B7D0")]
			set
			{
				string text = (iAPData_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DebuggerNonUserCode]
		public FilterType FilterType
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "15")]
			get
			{
				return filterType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				filterType_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[DebuggerNonUserCode]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return onlineId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x298B990", Offset = "0x298A390", VA = "0x18298B990")]
			set
			{
				string text = (onlineId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80", Slot = "29")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x298B8B0", Offset = "0x298A2B0", VA = "0x18298B8B0", Slot = "30")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		[DebuggerNonUserCode]
		public ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "31")]
			get
			{
				return lastUpdateTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490", Slot = "32")]
			set
			{
				lastUpdateTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public IAPData MyIAPData
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x298B590", Offset = "0x2989F90", VA = "0x18298B590")]
			get
			{
				return Definitions.IAPData.GetByUniqueName(iAPData_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x298B3C0", Offset = "0x2989DC0", VA = "0x18298B3C0", Slot = "35")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "36")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x298B420", Offset = "0x2989E20", VA = "0x18298B420", Slot = "37")]
			get
			{
				if ((object)typeof(_003C_003Ec).TypeHandle == null)
				{
					RepeatedField<Types.BundleContent> repeatedField = contents_;
					Func<Types.BundleContent, Item> _003C_003E9__107_ = _003C_003Ec._003C_003E9__107_0;
					if (_003C_003E9__107_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Types.BundleContent x)
						{
							//Discarded unreachable code: IL_000d
							int itemId_ = x.itemId_;
							return (Item)typeof(Item).TypeHandle;
						};
					}
					List<Item> list = (itemDependencies = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<Types.BundleContent, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__107_)));
				}
				return (List<Item>)typeof(_003C_003Ec).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x298AED0", Offset = "0x29898D0", VA = "0x18298AED0")]
		[DebuggerNonUserCode]
		public unsafe OnlineBundleData()
		{
			//Discarded unreachable code: IL_00a8
			//IL_0099: Expected I4, but got I8
			minGameVersion_ = "";
			title_ = "";
			description_ = "";
			iconAddress_ = "";
			RepeatedField<Types.BundleContent> repeatedField = (contents_ = (RepeatedField<Types.BundleContent>)(object)new RepeatedField<T>());
			RepeatedField<ContentPrice> repeatedField2 = (availablePrices_ = (RepeatedField<ContentPrice>)(object)new RepeatedField<T>());
			iAPData_ = "";
			onlineId_ = "";
			language_ = "";
			((Array.InternalEnumerator<T>*)this)->Dispose();
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			active_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2989DC0", Offset = "0x29887C0", VA = "0x182989DC0")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_0039
			//IL_002a: Expected I4, but got I8
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			active_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x298B100", Offset = "0x2989B00", VA = "0x18298B100")]
		[DebuggerNonUserCode]
		public OnlineBundleData(OnlineBundleData other)
		{
			//IL_0079: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			int num = (version_ = other.version_);
			string text = (minGameVersion_ = other.minGameVersion_);
			bool flag = (active_ = other.active_);
			string text2 = (title_ = other.title_);
			string text3 = (description_ = other.description_);
			string text4 = (iconAddress_ = other.iconAddress_);
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
			RepeatedField<Types.BundleContent> repeatedField = (contents_ = (RepeatedField<Types.BundleContent>)(object)((RepeatedField<T>)(object)other.contents_).Clone());
			RepeatedField<ContentPrice> repeatedField2 = (availablePrices_ = (RepeatedField<ContentPrice>)(object)((RepeatedField<T>)(object)other.availablePrices_).Clone());
			string text5 = (iAPData_ = other.iAPData_);
			FilterType filterType = other.filterType_;
			if (filterType != null)
			{
				FilterType filterType2 = filterType.Clone();
			}
			filterType_ = (FilterType)num2;
			string text6 = (onlineId_ = other.onlineId_);
			string text7 = (language_ = other.language_);
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

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2987AD0", Offset = "0x29864D0", VA = "0x182987AD0", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineBundleData Clone()
		{
			return new OnlineBundleData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2988AA0", Offset = "0x29874A0", VA = "0x182988AA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((OnlineBundleData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x29888B0", Offset = "0x29872B0", VA = "0x1829888B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineBundleData other)
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
							string text2 = other.title_;
							if (!(title_ != text2))
							{
								string text3 = other.description_;
								if (!(description_ != text3))
								{
									string text4 = other.iconAddress_;
									if (!(iconAddress_ != text4))
									{
										ConditionDate objB = other.startDate_;
										if (object.Equals(startDate_, objB))
										{
											ConditionDate objB2 = other.endDate_;
											if (object.Equals(endDate_, objB2))
											{
												RepeatedField<Types.BundleContent> repeatedField = contents_;
												RepeatedField<Types.BundleContent> repeatedField2 = other.contents_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													RepeatedField<ContentPrice> repeatedField3 = availablePrices_;
													RepeatedField<ContentPrice> repeatedField4 = other.availablePrices_;
													if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
													{
														string text5 = other.iAPData_;
														if (!(iAPData_ != text5))
														{
															FilterType objB3 = other.filterType_;
															if (object.Equals(filterType_, objB3))
															{
																string text6 = other.onlineId_;
																if (!(onlineId_ != text6))
																{
																	string text7 = other.language_;
																	if (!(language_ != text7))
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2989440", Offset = "0x2987E40", VA = "0x182989440", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_015a
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
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int hashCode5 = conditionDate.GetHashCode();
			}
			ConditionDate conditionDate2 = endDate_;
			if (conditionDate2 != null)
			{
				int hashCode6 = conditionDate2.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)contents_).GetHashCode();
			int hashCode8 = ((RepeatedField<T>)(object)availablePrices_).GetHashCode();
			string text5 = iAPData_;
			if (text5.m_stringLength != 0)
			{
				int hashCode9 = text5.GetHashCode();
			}
			FilterType filterType = filterType_;
			if (filterType != null)
			{
				int hashCode10 = filterType.GetHashCode();
			}
			string text6 = onlineId_;
			if (text6.m_stringLength != 0)
			{
				int hashCode11 = text6.GetHashCode();
			}
			string text7 = language_;
			if (text7.m_stringLength != 0)
			{
				int hashCode12 = text7.GetHashCode();
			}
			ConditionDate conditionDate3 = lastUpdateTimestamp_;
			if (conditionDate3 != null)
			{
				int hashCode13 = conditionDate3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode14 = unknownFields.GetHashCode();
			}
			return hashCode8;
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x298A850", Offset = "0x2989250", VA = "0x18298A850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x298A8B0", Offset = "0x29892B0", VA = "0x18298A8B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01b0
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
			if (title_.m_stringLength != 0)
			{
				string value4 = title_;
				output.WriteString(value4);
			}
			if (description_.m_stringLength != 0)
			{
				string value5 = description_;
				output.WriteString(value5);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value6 = iconAddress_;
				output.WriteString(value6);
			}
			if ((long)startDate_ != 0)
			{
				ConditionDate value7 = startDate_;
				output.WriteMessage(value7);
			}
			if ((long)endDate_ != 0)
			{
				ConditionDate value8 = endDate_;
				output.WriteMessage(value8);
			}
			RepeatedField<Types.BundleContent> repeatedField = contents_;
			FieldCodec<Types.BundleContent> repeated_contents_codec = _repeated_contents_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_contents_codec);
			RepeatedField<ContentPrice> repeatedField2 = availablePrices_;
			FieldCodec<ContentPrice> repeated_availablePrices_codec = _repeated_availablePrices_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_availablePrices_codec);
			if ((long)filterType_ != 0)
			{
				FilterType value9 = filterType_;
				output.WriteMessage(value9);
			}
			if (onlineId_.m_stringLength != 0)
			{
				string value10 = onlineId_;
				output.WriteString(value10);
			}
			if (language_.m_stringLength != 0)
			{
				string value11 = language_;
				output.WriteString(value11);
			}
			if (iAPData_.m_stringLength != 0)
			{
				string value12 = iAPData_;
				output.WriteString(value12);
			}
			if ((long)lastUpdateTimestamp_ != 0)
			{
				ConditionDate value13 = lastUpdateTimestamp_;
				output.WriteMessage(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2987510", Offset = "0x2985F10", VA = "0x182987510", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01f0
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
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(conditionDate);
				num8++;
				num2 += num8;
			}
			ConditionDate conditionDate2 = endDate_;
			if (conditionDate2 != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(conditionDate2);
				num9++;
				num2 += num9;
			}
			RepeatedField<Types.BundleContent> repeatedField = contents_;
			FieldCodec<Types.BundleContent> repeated_contents_codec = _repeated_contents_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_contents_codec);
			RepeatedField<ContentPrice> repeatedField2 = availablePrices_;
			FieldCodec<ContentPrice> repeated_availablePrices_codec = _repeated_availablePrices_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_availablePrices_codec);
			string text5 = iAPData_;
			if (text5.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text5);
				num12++;
				num2 += num12;
			}
			FilterType filterType = filterType_;
			if (filterType != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(filterType);
				num13++;
				num2 += num13;
			}
			string text6 = onlineId_;
			if (text6.m_stringLength != 0)
			{
				int num14 = CodedOutputStream.ComputeStringSize(text6);
				num14++;
				num2 += num14;
			}
			string text7 = language_;
			if (text7.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text7);
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

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2989AA0", Offset = "0x29884A0", VA = "0x182989AA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineBundleData other)
		{
			//Discarded unreachable code: IL_021d
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
			RepeatedField<Types.BundleContent> repeatedField = contents_;
			RepeatedField<Types.BundleContent> repeatedField2 = other.contents_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<ContentPrice> repeatedField3 = availablePrices_;
			RepeatedField<ContentPrice> repeatedField4 = other.availablePrices_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			string text5 = other.iAPData_;
			if (text5.m_stringLength != 0)
			{
				IAPData = text5;
			}
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
			string text6 = other.onlineId_;
			if (text6.m_stringLength != 0)
			{
				OnlineId = text6;
			}
			string text7 = other.language_;
			if (text7.m_stringLength != 0)
			{
				Language = text7;
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

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2989690", Offset = "0x2988090", VA = "0x182989690", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0227
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 90)
				{
					if ((int)num > 106)
					{
						if (num == 114)
						{
							string text2 = (IAPData = input.ReadString());
						}
						if (num != 122)
						{
							goto IL_0210;
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
					if (num == 98)
					{
						text4 = (OnlineId = input.ReadString());
					}
					if ((long)text4 != 106)
					{
						goto IL_0210;
					}
					string text6 = (Language = input.ReadString());
				}
				FilterType filterType = default(FilterType);
				if ((int)num > 74)
				{
					if (num == 82)
					{
						RepeatedField<ContentPrice> repeatedField = availablePrices_;
						FieldCodec<ContentPrice> repeated_availablePrices_codec = _repeated_availablePrices_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_availablePrices_codec);
					}
					if (num != 90)
					{
						goto IL_0210;
					}
					FilterType builder2 = default(FilterType);
					if (filterType_ == null)
					{
						filterType = (filterType_ = new FilterType());
						builder2 = filterType_;
					}
					input.ReadMessage(builder2);
				}
				ConditionDate conditionDate2 = default(ConditionDate);
				if ((long)filterType == 66)
				{
					ConditionDate builder3 = default(ConditionDate);
					if (endDate_ == null)
					{
						conditionDate2 = (endDate_ = new ConditionDate());
						builder3 = endDate_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)conditionDate2 != 74)
				{
					goto IL_0210;
				}
				RepeatedField<Types.BundleContent> repeatedField2 = contents_;
				FieldCodec<Types.BundleContent> repeated_contents_codec = _repeated_contents_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_contents_codec);
			}
			string text12 = default(string);
			if ((int)num > 24)
			{
				ConditionDate conditionDate3 = default(ConditionDate);
				if ((int)num > 42)
				{
					string text8 = default(string);
					if (num == 50)
					{
						text8 = (IconAddress = input.ReadString());
					}
					if ((long)text8 != 58)
					{
						goto IL_0210;
					}
					ConditionDate builder4 = default(ConditionDate);
					if (startDate_ == null)
					{
						conditionDate3 = (startDate_ = new ConditionDate());
						builder4 = startDate_;
					}
					input.ReadMessage(builder4);
				}
				string text10 = default(string);
				if ((long)conditionDate3 == 34)
				{
					text10 = (Title = input.ReadString());
				}
				if ((long)text10 != 42)
				{
					goto IL_0210;
				}
				text12 = (Description = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text12 == 8)
			{
				num2 = (version_ = input.ReadInt32());
			}
			string text14 = default(string);
			if (num2 == 18)
			{
				text14 = (MinGameVersion = input.ReadString());
			}
			if ((long)text14 == 24)
			{
				bool flag = (active_ = input.ReadBool());
			}
			goto IL_0210;
			IL_0210:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2989240", Offset = "0x2987C40", VA = "0x182989240", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2989EC0", Offset = "0x29888C0", VA = "0x182989EC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_0026, IL_002e, IL_002f, IL_0030, IL_0031, IL_0039, IL_003a, IL_003b, IL_003c, IL_0042, IL_0048, IL_004e, IL_0054, IL_005a, IL_0060, IL_0066
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			if (fieldNumber - 1 <= 14)
			{
				object obj = default(object);
				version_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x29878E0", Offset = "0x29862E0", VA = "0x1829878E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001a, IL_001c
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 14)
			{
				version_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2987B30", Offset = "0x2986530", VA = "0x182987B30", Slot = "14")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0203, IL_0209, IL_020f, IL_0215, IL_021b, IL_0221, IL_0227, IL_022d, IL_0233, IL_0239, IL_023f, IL_0245, IL_024b, IL_0251
			//IL_00ec: Expected O, but got I4
			//IL_011f: Expected O, but got I4
			//IL_0166: Expected O, but got I4
			//IL_0166: Expected O, but got I4
			//IL_0185: Expected O, but got I4
			//IL_01ae: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
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
			ConditionDate conditionDate = endDate_;
			if (conditionDate != null && (IntPtr)conditionDate.date_ != (IntPtr)num3)
			{
				long seconds = startDate_.date_.Seconds;
				long seconds2 = endDate_.date_.Seconds;
				if (seconds > seconds2)
				{
					context.AddError("Start Date must be set to a date before the End Date.");
				}
			}
			string text3 = default(string);
			if (((RepeatedField<T>)(object)contents_).Count > 0)
			{
				RepeatedField<Types.BundleContent> repeatedField = contents_;
				bool flag = default(bool);
				if (flag)
				{
					if (!flag)
					{
						bool flag2 = default(bool);
						if (flag2)
						{
							context.AddError("Content item must have a valid quantity that is greater than 0.");
						}
						ItemType itemType = default(ItemType);
						string arg = default(string);
						text3 = $"Content item of type '{itemType}' is not supported. Please pick among any of the following supported types: {arg}.";
						context.AddError(text3);
					}
					context.AddError("Content item must be valid.");
				}
			}
			if (text3 == null)
			{
				int num4 = 0;
				IAPData iAPData = default(IAPData);
				if (iAPData == null)
				{
					string text4 = "IAPData named=" + (string)num4 + " not found";
				}
			}
			IAPData iAPData2 = default(IAPData);
			if (iAPData2 != null)
			{
				IAPData iAPData3 = default(IAPData);
				RepeatedField<ItemAmount> rewards_ = iAPData3.rewards_;
				int count = ((RepeatedField<T>)(object)rewards_).Count;
				int count2 = ((RepeatedField<T>)(object)rewards_).Count;
				if (count != count2)
				{
					IAPData iAPData4 = default(IAPData);
					count = ((RepeatedField<T>)(object)iAPData4.rewards_).Count;
					int num5 = default(int);
					string text5 = $"IAPData MyIAPData.Rewards.Count={count} and {num5} dont match";
				}
				IAPData iAPData5 = default(IAPData);
				RepeatedField<ItemAmount> rewards_2 = iAPData5.rewards_;
				bool flag3 = default(bool);
				if (flag3)
				{
					ItemAmount reward = (ItemAmount)num;
					Func<Types.BundleContent, bool> func = (Func<Types.BundleContent, bool>)(object)(Func<T, TResult>)delegate(Types.BundleContent x)
					{
						//Discarded unreachable code: IL_0016
						int id_ = reward.id_;
						return x.itemId_ == id_;
					};
					Types.BundleContent bundleContent = default(Types.BundleContent);
					string text6 = default(string);
					if (bundleContent == null)
					{
						int itemId_ = bundleContent.itemId_;
						text6 = $"Contents does not have IAPData.Rewards with Item ID={itemId_}";
					}
					int quantity_ = bundleContent.quantity_;
					string text7 = $"Contents Item ID={text6} quantity is {text6} but in IAPData rewards it's  {text6}.  It must be the same";
				}
			}
			IAPData iAPData6 = default(IAPData);
			int num6 = default(int);
			if (iAPData6 == null || num6 > 0)
			{
			}
			IAPData iAPData7 = default(IAPData);
			if (iAPData7 == null)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__108_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ContentPrice x) => x.amount_ <= 0);
			}
			bool flag4 = default(bool);
			while (!flag4)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x298A360", Offset = "0x2988D60", VA = "0x18298A360", Slot = "16")]
		public BundleConfig ToServerConfig(string onlineId)
		{
			//Discarded unreachable code: IL_019d
			//IL_0059: Expected O, but got I4
			//IL_0162: Expected I4, but got I8
			//IL_0174: Expected O, but got I4
			BundleConfig bundleConfig = new BundleConfig();
			bundleConfig.OnlineId = onlineId;
			int num = (bundleConfig.Version = version_);
			DateTime dateTime = (bundleConfig.StartDate = startDate_.date_.ToDateTime());
			ConditionDate conditionDate = endDate_;
			if (conditionDate != null)
			{
				DateTime dateTime2 = conditionDate.date_.ToDateTime();
				int num2 = 0;
			}
			int num3 = 0;
			bundleConfig.EndDate = (DateTime?)(object)num3;
			bool flag = (bundleConfig.IsHidden = !active_);
			string text = (bundleConfig.MinGameVersion = minGameVersion_);
			ServerLoc serverLoc = new ServerLoc();
			Dictionary<string, string> dictionary = (serverLoc.LocByLanguage = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			bundleConfig.TitleLoc = serverLoc;
			RepeatedField<Types.BundleContent> repeatedField = contents_;
			Func<Types.BundleContent, Content> func = default(Func<Types.BundleContent, Content>);
			if (_003C_003Ec._003C_003E9__109_0 == null)
			{
				func = (Func<Types.BundleContent, Content>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Types.BundleContent x)
				{
					//Discarded unreachable code: IL_0024
					Content content = new Content();
					int num9 = (content.GameItemId = x.itemId_);
					int num10 = (content.Amount = x.quantity_);
					return content;
				});
			}
			List<Content> list = (bundleConfig.Contents = (List<Content>)(object)Enumerable.ToList<Content>(Enumerable.Select<Types.BundleContent, Content>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func)));
			RepeatedField<ContentPrice> repeatedField2 = availablePrices_;
			Func<ContentPrice, glPlayFab.Disney.Price> func2 = default(Func<ContentPrice, glPlayFab.Disney.Price>);
			if (_003C_003Ec._003C_003E9__109_1 == null)
			{
				func2 = (Func<ContentPrice, glPlayFab.Disney.Price>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ContentPrice x)
				{
					//Discarded unreachable code: IL_0024
					glPlayFab.Disney.Price price = new glPlayFab.Disney.Price();
					int num7 = (price.CurrencyItemId = x.currencyId_);
					int num8 = (price.Amount = x.amount_);
					return price;
				});
			}
			List<glPlayFab.Disney.Price> list2 = (bundleConfig.Prices = (List<glPlayFab.Disney.Price>)(object)Enumerable.ToList<glPlayFab.Disney.Price>(Enumerable.Select<ContentPrice, glPlayFab.Disney.Price>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func2)));
			string text2 = iAPData_;
			if (list2 != null)
			{
			}
			string text3 = (bundleConfig.IAPData = iAPData_);
			FilterType filterType = filterType_;
			if (filterType != null)
			{
				int num4 = 0;
				int formatEnumAsIntegers = 0;
				int indented = 0;
				int formatDefaultValues = 0;
				ulong num5 = default(ulong);
				JObject jObject = JObject.Parse(filterType.ToJSONString((byte)formatDefaultValues != 0, (byte)indented != 0, (byte)formatEnumAsIntegers != 0, (int)num5));
			}
			int num6 = 0;
			bundleConfig.Filter = (JObject)num6;
			ServerLoc _003CTitleLoc_003Ek__BackingField = bundleConfig.TitleLoc;
			string text4 = title_;
			Dictionary<string, string> _003CLocByLanguage_003Ek__BackingField = _003CTitleLoc_003Ek__BackingField.LocByLanguage;
			LocalizationUtil.GetLocalizationFromTitleId(text4, (Dictionary<, >)(object)_003CLocByLanguage_003Ek__BackingField, "neutral");
			return bundleConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2988B00", Offset = "0x2987500", VA = "0x182988B00")]
		public static OnlineBundleData FromServerConfig(BundleConfig serverBundleConfig, DateTime lastUpdateTimestamp)
		{
			//Discarded unreachable code: IL_0217
			//IL_0057: Expected I4, but got I8
			//IL_00a2: Expected I4, but got I8
			//IL_00aa: Expected O, but got I4
			//IL_011f: Expected I4, but got I8
			OnlineBundleData onlineBundleData = new OnlineBundleData();
			string text = (onlineBundleData.onlineId_ = ProtoPreconditions.CheckNotNull(serverBundleConfig.OnlineId, "value"));
			int num = (onlineBundleData.version_ = serverBundleConfig.Version);
			ConditionDate conditionDate = new ConditionDate();
			Timestamp timestamp = (conditionDate.date_ = serverBundleConfig.StartDate.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			onlineBundleData.startDate_ = conditionDate;
			DateTime? _003CEndDate_003Ek__BackingField = serverBundleConfig.EndDate;
			int num2 = 0;
			if (timestamp != null)
			{
				ConditionDate conditionDate2 = new ConditionDate();
				DateTime? _003CEndDate_003Ek__BackingField2 = serverBundleConfig.EndDate;
				DateTime dateTime = default(DateTime);
				Timestamp timestamp2 = (conditionDate2.date_ = dateTime.ToProto());
				conditionDate2.localTime_ = (byte)num2 != 0;
				conditionDate2.operator_ = IntOperator.LessThan;
			}
			onlineBundleData.endDate_ = (ConditionDate)num2;
			bool flag = (onlineBundleData.active_ = (serverBundleConfig.IsHidden ? 1 : 0) == num2);
			string text2 = (onlineBundleData.minGameVersion_ = ProtoPreconditions.CheckNotNull(serverBundleConfig.MinGameVersion, "value"));
			int num3 = 0;
			string text3 = (onlineBundleData.language_ = ProtoPreconditions.CheckNotNull(LocalizationUtil.CurrentLanguage, "value"));
			ConditionDate conditionDate3 = new ConditionDate();
			Timestamp timestamp3 = (conditionDate3.date_ = lastUpdateTimestamp.ToProto());
			conditionDate3.localTime_ = (byte)num2 != 0;
			conditionDate3.operator_ = IntOperator.GreaterThanOrEqual;
			onlineBundleData.lastUpdateTimestamp_ = conditionDate3;
			string text4 = (onlineBundleData.title_ = ProtoPreconditions.CheckNotNull(serverBundleConfig.TitleLoc.GetLocalizedText(), "value"));
			string _003CIAPData_003Ek__BackingField = serverBundleConfig.IAPData;
			if (text4 != null)
			{
			}
			string text5 = (onlineBundleData.iAPData_ = ProtoPreconditions.CheckNotNull(serverBundleConfig.IAPData, "value"));
			if (serverBundleConfig.Filter != null)
			{
				string text6 = serverBundleConfig.Filter.ToString();
			}
			FilterType filterType = default(FilterType);
			onlineBundleData.filterType_ = filterType;
			RepeatedField<Types.BundleContent> repeatedField = onlineBundleData.contents_;
			List<Content> _003CContents_003Ek__BackingField = serverBundleConfig.Contents;
			Func<Content, Types.BundleContent> func = default(Func<Content, Types.BundleContent>);
			if (_003C_003Ec._003C_003E9__110_0 == null)
			{
				func = (Func<Content, Types.BundleContent>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Content x)
				{
					//Discarded unreachable code: IL_0024
					Types.BundleContent bundleContent = new Types.BundleContent();
					int num6 = (bundleContent.itemId_ = x.GameItemId);
					int num7 = (bundleContent.quantity_ = x.Amount);
					return bundleContent;
				});
			}
			IEnumerable<Content> enumerable = (IEnumerable<Content>)Enumerable.Select<Content, Types.BundleContent>((IEnumerable<>)_003CContents_003Ek__BackingField, (Func<, >)(object)func);
			((RepeatedField<T>)(object)repeatedField).AddRange((IEnumerable<>)enumerable);
			RepeatedField<ContentPrice> repeatedField2 = onlineBundleData.availablePrices_;
			List<glPlayFab.Disney.Price> _003CPrices_003Ek__BackingField = serverBundleConfig.Prices;
			Func<glPlayFab.Disney.Price, ContentPrice> func2 = default(Func<glPlayFab.Disney.Price, ContentPrice>);
			if (_003C_003Ec._003C_003E9__110_1 == null)
			{
				func2 = (Func<glPlayFab.Disney.Price, ContentPrice>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(glPlayFab.Disney.Price x)
				{
					//Discarded unreachable code: IL_0024
					ContentPrice contentPrice = new ContentPrice();
					int num4 = (contentPrice.currencyId_ = x.CurrencyItemId);
					int num5 = (contentPrice.amount_ = x.Amount);
					return contentPrice;
				});
			}
			IEnumerable<glPlayFab.Disney.Price> enumerable2 = (IEnumerable<glPlayFab.Disney.Price>)Enumerable.Select<glPlayFab.Disney.Price, ContentPrice>((IEnumerable<>)_003CPrices_003Ek__BackingField, (Func<, >)(object)func2);
			((RepeatedField<T>)(object)repeatedField2).AddRange((IEnumerable<>)enumerable2);
			return onlineBundleData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x298AC40", Offset = "0x2989640", VA = "0x18298AC40")]
		static OnlineBundleData()
		{
			MessageParser<Types.BundleContent> parser = Types.BundleContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<OnlineBundleData>)(object)FieldCodec.ForMessage<Types.BundleContent>(num, (MessageParser<>)(object)parser);
			MessageParser<ContentPrice> parser2 = ContentPrice._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<OnlineBundleData>)(object)FieldCodec.ForMessage<ContentPrice>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
