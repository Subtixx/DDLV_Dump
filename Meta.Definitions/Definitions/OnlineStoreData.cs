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
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class OnlineStoreData : IMessage<OnlineStoreData>, IMessage, IEquatable<OnlineStoreData>, IDeepCloneable<OnlineStoreData>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation, IClientLiveopsConfig<StoreConfig>, IFetchable, ITimeLimited, IHasOnlineItemDependencies, IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			Offer = 9,
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			Rotation = 10,
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			InAppPurchase = 14,
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			GameUpgrade = 16
		}

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly MessageParser<OnlineStoreData> _parser = (MessageParser<OnlineStoreData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new OnlineStoreData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public const int MinGameVersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private string minGameVersion_;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public const int ActiveFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private bool active_;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public const int TitleFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private string title_;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public const int DescriptionFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public const int IconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public const int StartDateFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private ConditionDate startDate_;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public const int EndDateFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private ConditionDate endDate_;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public const int OfferFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public const int RotationFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public const int InAppPurchaseFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public const int GameUpgradeFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public const int ContentsFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private static readonly FieldCodec<StoreContent> _repeated_contents_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly RepeatedField<StoreContent> contents_;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public const int OnlineIdFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private string onlineId_;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public const int LanguageFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private string language_;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public const int LastUpdateTimestampFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private ConditionDate lastUpdateTimestamp_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineStoreData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x36A1150", Offset = "0x369FB50", VA = "0x1836A1150")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x36A0CA0", Offset = "0x369F6A0", VA = "0x1836A0CA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x36A1210", Offset = "0x369FC10", VA = "0x1836A1210", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		[DebuggerNonUserCode]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "20")]
			get
			{
				return minGameVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0x36A14F0", Offset = "0x369FEF0", VA = "0x1836A14F0", Slot = "21")]
			set
			{
				string text = (minGameVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[DebuggerNonUserCode]
		public bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "22")]
			get
			{
				return active_;
			}
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0", Slot = "23")]
			set
			{
				active_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "24")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x36A1610", Offset = "0x36A0010", VA = "0x1836A1610", Slot = "25")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "26")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x36A1320", Offset = "0x369FD20", VA = "0x1836A1320", Slot = "27")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "28")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x36A13D0", Offset = "0x369FDD0", VA = "0x1836A13D0", Slot = "29")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		[DebuggerNonUserCode]
		public ConditionDate StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "34")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		[DebuggerNonUserCode]
		public ConditionDate EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "35")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		[DebuggerNonUserCode]
		public StoreTypeOffer Offer
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x36A10F0", Offset = "0x369FAF0", VA = "0x1836A10F0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Offer)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x36A1560", Offset = "0x369FF60", VA = "0x1836A1560")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		[DebuggerNonUserCode]
		public StoreTypeRotation Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x36A11B0", Offset = "0x369FBB0", VA = "0x1836A11B0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Rotation)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D170", Offset = "0x1E2BB70", VA = "0x181E2D170")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		[DebuggerNonUserCode]
		public StoreTypeInAppPurchase InAppPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x36A0E30", Offset = "0x369F830", VA = "0x1836A0E30")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.InAppPurchase)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x36A1440", Offset = "0x369FE40", VA = "0x1836A1440")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		[DebuggerNonUserCode]
		public StoreTypeGameUpgrade GameUpgrade
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x36A0DD0", Offset = "0x369F7D0", VA = "0x1836A0DD0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.GameUpgrade)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x36A1390", Offset = "0x369FD90", VA = "0x1836A1390")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[DebuggerNonUserCode]
		public RepeatedField<StoreContent> Contents
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return contents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		[DebuggerNonUserCode]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return onlineId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x36A15A0", Offset = "0x369FFA0", VA = "0x1836A15A0")]
			set
			{
				string text = (onlineId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "30")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x36A1480", Offset = "0x369FE80", VA = "0x1836A1480", Slot = "31")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		[DebuggerNonUserCode]
		public ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "32")]
			get
			{
				return lastUpdateTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10", Slot = "33")]
			set
			{
				lastUpdateTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x36A0D70", Offset = "0x369F770", VA = "0x1836A0D70", Slot = "36")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "37")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0x36A0E90", Offset = "0x369F890", VA = "0x1836A0E90", Slot = "38")]
			get
			{
				if ((object)typeof(_003C_003Ec).TypeHandle == null)
				{
					RepeatedField<StoreContent> repeatedField = contents_;
					Func<StoreContent, bool> _003C_003E9__113_ = _003C_003Ec._003C_003E9__113_0;
					if (_003C_003E9__113_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((StoreContent x) => x.Item != null);
					}
					IEnumerable<StoreContent> enumerable = (IEnumerable<StoreContent>)Enumerable.Where<StoreContent>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__113_);
					Func<StoreContent, Item> func = default(Func<StoreContent, Item>);
					if (_003C_003Ec._003C_003E9__113_1 == null)
					{
						func = (Func<StoreContent, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(StoreContent x)
						{
							int item_ = x.Item.item_;
							throw new NullReferenceException();
						});
					}
					List<Item> list = (itemDependencies = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<StoreContent, Item>((IEnumerable<>)enumerable, (Func<, >)(object)func)));
				}
				return (List<Item>)typeof(_003C_003Ec).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x36A07C0", Offset = "0x369F1C0", VA = "0x1836A07C0")]
		[DebuggerNonUserCode]
		public OnlineStoreData()
		{
			//IL_007f: Expected I4, but got I8
			minGameVersion_ = "";
			title_ = "";
			description_ = "";
			iconAddress_ = "";
			contents_ = (RepeatedField<StoreContent>)(object)new RepeatedField<T>();
			onlineId_ = "";
			language_ = "";
			base._002Ector();
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x369EFD0", Offset = "0x369D9D0", VA = "0x18369EFD0")]
		private void OnConstruction()
		{
			//IL_002a: Expected I4, but got I8
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x36A0990", Offset = "0x369F390", VA = "0x1836A0990")]
		[DebuggerNonUserCode]
		public OnlineStoreData(OnlineStoreData other)
		{
			//IL_0079: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_017d: Expected I4, but got O
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
			RepeatedField<StoreContent> repeatedField = (contents_ = (RepeatedField<StoreContent>)(object)((RepeatedField<T>)(object)other.contents_).Clone());
			string text5 = (onlineId_ = other.onlineId_);
			string text6 = (language_ = other.language_);
			ConditionDate conditionDate5 = other.lastUpdateTimestamp_;
			if (conditionDate5 != null)
			{
				ConditionDate conditionDate6 = conditionDate5.Clone();
			}
			lastUpdateTimestamp_ = (ConditionDate)num2;
			TypeOneofCase typeOneofCase = other.typeCase_;
			StoreTypeGameUpgrade storeTypeGameUpgrade = default(StoreTypeGameUpgrade);
			if (typeOneofCase > TypeOneofCase.Rotation)
			{
				StoreTypeInAppPurchase storeTypeInAppPurchase = default(StoreTypeInAppPurchase);
				if (typeOneofCase == TypeOneofCase.InAppPurchase)
				{
					TypeOneofCase typeOneofCase2 = other.typeCase_;
					if (other.type_ == null)
					{
						throw new InvalidCastException();
					}
					type_ = storeTypeInAppPurchase;
				}
				if ((long)storeTypeInAppPurchase != 16)
				{
					goto IL_017d;
				}
				storeTypeGameUpgrade = (StoreTypeGameUpgrade)(type_ = other.GameUpgrade.Clone());
			}
			StoreTypeOffer storeTypeOffer = default(StoreTypeOffer);
			if ((long)storeTypeGameUpgrade == 9)
			{
				TypeOneofCase typeOneofCase3 = other.typeCase_;
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				type_ = storeTypeOffer;
			}
			if ((long)storeTypeOffer == 10)
			{
				typeCase_ = (TypeOneofCase)(type_ = other.Rotation.Clone());
			}
			goto IL_017d;
			IL_017d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x369C020", Offset = "0x369AA20", VA = "0x18369C020", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineStoreData Clone()
		{
			return new OnlineStoreData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E24D20", Offset = "0x1E23720", VA = "0x181E24D20")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x369CD40", Offset = "0x369B740", VA = "0x18369CD40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((OnlineStoreData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x369CDA0", Offset = "0x369B7A0", VA = "0x18369CDA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineStoreData other)
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
												StoreTypeOffer offer = Offer;
												StoreTypeOffer offer2 = other.Offer;
												if (object.Equals(offer, offer2))
												{
													StoreTypeRotation rotation = Rotation;
													StoreTypeRotation rotation2 = other.Rotation;
													if (object.Equals(rotation, rotation2))
													{
														StoreTypeInAppPurchase inAppPurchase = InAppPurchase;
														StoreTypeInAppPurchase inAppPurchase2 = other.InAppPurchase;
														if (object.Equals(inAppPurchase, inAppPurchase2))
														{
															StoreTypeGameUpgrade gameUpgrade = GameUpgrade;
															StoreTypeGameUpgrade gameUpgrade2 = other.GameUpgrade;
															if (object.Equals(gameUpgrade, gameUpgrade2))
															{
																RepeatedField<StoreContent> repeatedField = contents_;
																RepeatedField<StoreContent> repeatedField2 = other.contents_;
																if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																{
																	string text5 = other.onlineId_;
																	if (!(onlineId_ != text5))
																	{
																		string text6 = other.language_;
																		if (!(language_ != text6))
																		{
																			ConditionDate objB3 = other.lastUpdateTimestamp_;
																			if (object.Equals(lastUpdateTimestamp_, objB3))
																			{
																				TypeOneofCase typeOneofCase = other.typeCase_;
																				if (typeCase_ == typeOneofCase)
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x369E060", Offset = "0x369CA60", VA = "0x18369E060", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_01b0
			while (true)
			{
				int num = version_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = minGameVersion_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				if (active_)
				{
				}
				string text2 = title_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = description_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = iconAddress_;
				if (text4.m_stringLength != num2)
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
				if (typeCase_ != TypeOneofCase.Offer)
				{
					continue;
				}
				object obj = type_;
				if (obj != null)
				{
					int hashCode7 = obj.GetHashCode();
					if (typeCase_ != TypeOneofCase.Rotation)
					{
						continue;
					}
					object obj2 = type_;
					if (obj2 != null)
					{
						int hashCode8 = obj2.GetHashCode();
						if (typeCase_ != TypeOneofCase.InAppPurchase)
						{
							continue;
						}
						object obj3 = type_;
						if (obj3 != null)
						{
							int hashCode9 = obj3.GetHashCode();
							if (typeCase_ == TypeOneofCase.GameUpgrade)
							{
								object obj4 = type_;
								if (obj4 == null)
								{
									break;
								}
								int hashCode10 = obj4.GetHashCode();
							}
							int hashCode11 = ((RepeatedField<T>)(object)contents_).GetHashCode();
							string text5 = onlineId_;
							if (text5.m_stringLength != 0)
							{
								int hashCode12 = text5.GetHashCode();
							}
							string text6 = language_;
							if (text6.m_stringLength != 0)
							{
								int hashCode13 = text6.GetHashCode();
							}
							ConditionDate conditionDate3 = lastUpdateTimestamp_;
							if (conditionDate3 != null)
							{
								int hashCode14 = conditionDate3.GetHashCode();
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode15 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x36A00B0", Offset = "0x369EAB0", VA = "0x1836A00B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x36A0110", Offset = "0x369EB10", VA = "0x1836A0110", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0207
			TypeOneofCase typeOneofCase;
			int num;
			do
			{
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
				typeOneofCase = typeCase_;
				num = 0;
			}
			while (typeOneofCase != TypeOneofCase.Offer);
			if (typeCase_ == TypeOneofCase.Offer)
			{
				object obj = type_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (typeCase_ == TypeOneofCase.Rotation && typeCase_ == TypeOneofCase.Rotation)
			{
				object obj2 = type_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			RepeatedField<StoreContent> repeatedField = contents_;
			FieldCodec<StoreContent> repeated_contents_codec = _repeated_contents_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_contents_codec);
			if (onlineId_.m_stringLength != num)
			{
				string value9 = onlineId_;
				output.WriteString(value9);
			}
			if (language_.m_stringLength != num)
			{
				string value10 = language_;
				output.WriteString(value10);
			}
			if (typeCase_ == TypeOneofCase.InAppPurchase && typeCase_ == TypeOneofCase.InAppPurchase)
			{
				object obj3 = type_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
			}
			if ((IntPtr)lastUpdateTimestamp_ != (IntPtr)num)
			{
				ConditionDate value11 = lastUpdateTimestamp_;
				output.WriteMessage(value11);
			}
			if (typeCase_ == TypeOneofCase.GameUpgrade && typeCase_ == TypeOneofCase.GameUpgrade)
			{
				object obj4 = type_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x369B880", Offset = "0x369A280", VA = "0x18369B880", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_025c
			int num = version_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = minGameVersion_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = title_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = description_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != num2)
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
			if (typeCase_ == TypeOneofCase.Offer)
			{
				if (typeCase_ != TypeOneofCase.Offer)
				{
				}
				object obj = type_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num10 = default(int);
				num2 += num10;
			}
			if (typeCase_ == TypeOneofCase.Rotation)
			{
				if (typeCase_ != TypeOneofCase.Rotation)
				{
				}
				object obj2 = type_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num11 = default(int);
				num2 += num11;
			}
			if (typeCase_ == TypeOneofCase.InAppPurchase)
			{
				if (typeCase_ != TypeOneofCase.InAppPurchase)
				{
				}
				object obj3 = type_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num12 = default(int);
				num2 += num12;
			}
			if (typeCase_ == TypeOneofCase.GameUpgrade)
			{
				if (typeCase_ == TypeOneofCase.GameUpgrade)
				{
					object obj4 = type_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num13 = default(int);
				num2 += num13;
			}
			RepeatedField<StoreContent> repeatedField = contents_;
			FieldCodec<StoreContent> repeated_contents_codec = _repeated_contents_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_contents_codec);
			string text5 = onlineId_;
			num2 += num14;
			if (text5.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text5);
				num15++;
				num2 += num15;
			}
			string text6 = language_;
			if (text6.m_stringLength != 0)
			{
				int num16 = CodedOutputStream.ComputeStringSize(text6);
				num16++;
				num2 += num16;
			}
			ConditionDate conditionDate3 = lastUpdateTimestamp_;
			if (conditionDate3 != null)
			{
				int num17 = CodedOutputStream.ComputeMessageSize(conditionDate3);
				num17++;
				num2 += num17;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num18 = unknownFields.CalculateSize();
				num2 += num18;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x369E4D0", Offset = "0x369CED0", VA = "0x18369E4D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineStoreData other)
		{
			//Discarded unreachable code: IL_02c4
			//IL_01c5: Expected I4, but got O
			//IL_0209: Expected I4, but got O
			//IL_024a: Expected I4, but got O
			//IL_028b: Expected I4, but got O
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
			RepeatedField<StoreContent> repeatedField = contents_;
			RepeatedField<StoreContent> repeatedField2 = other.contents_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			string text5 = other.onlineId_;
			if (text5.m_stringLength != 0)
			{
				OnlineId = text5;
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
				ConditionDate other4 = other.lastUpdateTimestamp_;
				conditionDate6.MergeFrom(other4);
			}
			TypeOneofCase typeOneofCase = other.typeCase_;
			StoreTypeGameUpgrade gameUpgrade2 = default(StoreTypeGameUpgrade);
			if (typeOneofCase > TypeOneofCase.Rotation)
			{
				StoreTypeInAppPurchase inAppPurchase2 = default(StoreTypeInAppPurchase);
				if (typeOneofCase == TypeOneofCase.InAppPurchase)
				{
					if (InAppPurchase == null)
					{
						typeCase_ = (TypeOneofCase)(type_ = new StoreTypeInAppPurchase());
					}
					StoreTypeInAppPurchase inAppPurchase = InAppPurchase;
					inAppPurchase2 = other.InAppPurchase;
					inAppPurchase.MergeFrom(inAppPurchase2);
				}
				if ((long)inAppPurchase2 != 16)
				{
					goto IL_02a4;
				}
				if (GameUpgrade == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new StoreTypeGameUpgrade());
				}
				StoreTypeGameUpgrade gameUpgrade = GameUpgrade;
				gameUpgrade2 = other.GameUpgrade;
				gameUpgrade.MergeFrom(gameUpgrade2);
			}
			StoreTypeOffer offer2 = default(StoreTypeOffer);
			if ((long)gameUpgrade2 == 9)
			{
				if (Offer == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new StoreTypeOffer());
				}
				StoreTypeOffer offer = Offer;
				offer2 = other.Offer;
				offer.MergeFrom(offer2);
			}
			if ((long)offer2 == 10)
			{
				if (Rotation == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new StoreTypeRotation());
				}
				StoreTypeRotation rotation = Rotation;
				StoreTypeRotation rotation2 = other.Rotation;
				rotation.MergeFrom(rotation2);
			}
			goto IL_02a4;
			IL_02a4:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x369E960", Offset = "0x369D360", VA = "0x18369E960", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a3: Expected I4, but got O
			//IL_010f: Expected I4, but got O
			//IL_01a0: Expected I4, but got O
			//IL_01f9: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 66)
			{
				if ((int)num > 98)
				{
					if ((int)num > 114)
					{
						if (num == 122)
						{
							ConditionDate conditionDate = lastUpdateTimestamp_;
							if (conditionDate == null)
							{
								ConditionDate conditionDate2 = (lastUpdateTimestamp_ = new ConditionDate());
							}
							input.ReadMessage(conditionDate);
						}
						if (num != 130)
						{
							goto IL_02fe;
						}
						StoreTypeGameUpgrade builder = new StoreTypeGameUpgrade();
						if (typeCase_ == TypeOneofCase.GameUpgrade)
						{
							if (typeCase_ != TypeOneofCase.GameUpgrade)
							{
							}
							object obj = type_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						type_ = builder;
						typeCase_ = (TypeOneofCase)typeof(StoreTypeGameUpgrade).TypeHandle;
					}
					string text2 = default(string);
					if (num == 106)
					{
						text2 = (Language = input.ReadString());
					}
					if ((long)text2 != 114)
					{
						goto IL_02fe;
					}
					StoreTypeInAppPurchase builder2 = new StoreTypeInAppPurchase();
					if (typeCase_ == TypeOneofCase.InAppPurchase)
					{
						if (typeCase_ != TypeOneofCase.InAppPurchase)
						{
						}
						object obj2 = type_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					type_ = builder2;
					typeCase_ = (TypeOneofCase)typeof(StoreTypeInAppPurchase).TypeHandle;
				}
				string text4 = default(string);
				if ((int)num > 82)
				{
					if (num == 90)
					{
						RepeatedField<StoreContent> repeatedField = contents_;
						FieldCodec<StoreContent> repeated_contents_codec = _repeated_contents_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_contents_codec);
					}
					if (num != 98)
					{
						goto IL_02fe;
					}
					text4 = (OnlineId = input.ReadString());
				}
				if ((long)text4 == 74)
				{
					StoreTypeOffer builder3 = new StoreTypeOffer();
					if (typeCase_ == TypeOneofCase.Offer)
					{
						if (typeCase_ != TypeOneofCase.Offer)
						{
						}
						object obj3 = type_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					type_ = builder3;
					typeCase_ = (TypeOneofCase)typeof(StoreTypeOffer).TypeHandle;
				}
				if ((long)typeof(StoreTypeOffer).TypeHandle != 82)
				{
					goto IL_02fe;
				}
				StoreTypeRotation builder4 = new StoreTypeRotation();
				if (typeCase_ == TypeOneofCase.Rotation)
				{
					if (typeCase_ != TypeOneofCase.Rotation)
					{
					}
					object obj4 = type_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				type_ = builder4;
				typeCase_ = (TypeOneofCase)typeof(StoreTypeRotation).TypeHandle;
			}
			string text8 = default(string);
			if ((int)num > 34)
			{
				ConditionDate conditionDate4 = default(ConditionDate);
				if ((int)num > 50)
				{
					ConditionDate conditionDate3 = default(ConditionDate);
					if (num == 58)
					{
						ConditionDate builder5 = default(ConditionDate);
						if (startDate_ == null)
						{
							conditionDate3 = (startDate_ = new ConditionDate());
							builder5 = startDate_;
						}
						input.ReadMessage(builder5);
					}
					if ((long)conditionDate3 != 66)
					{
						goto IL_02fe;
					}
					ConditionDate builder6 = default(ConditionDate);
					if (endDate_ == null)
					{
						conditionDate4 = (endDate_ = new ConditionDate());
						builder6 = endDate_;
					}
					input.ReadMessage(builder6);
				}
				string text6 = default(string);
				if ((long)conditionDate4 == 42)
				{
					text6 = (Description = input.ReadString());
				}
				if ((long)text6 != 50)
				{
					goto IL_02fe;
				}
				text8 = (IconAddress = input.ReadString());
			}
			string text10 = default(string);
			if ((long)text8 > 18)
			{
				bool flag = default(bool);
				if ((long)text8 == 24)
				{
					flag = (active_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_02fe;
				}
				text10 = (Title = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text10 == 8)
			{
				num2 = (version_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text12 = (MinGameVersion = input.ReadString());
			}
			goto IL_02fe;
			IL_02fe:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x369DE40", Offset = "0x369C840", VA = "0x18369DE40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 15)
			{
				int num = version_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x369F0D0", Offset = "0x369DAD0", VA = "0x18369F0D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0015, IL_001c, IL_001d, IL_001e, IL_0022, IL_0029, IL_002a, IL_002e, IL_0035, IL_0036, IL_003a, IL_0041, IL_0042, IL_0046, IL_004d, IL_0051, IL_0058, IL_005c, IL_0064, IL_0068, IL_006c, IL_0070, IL_0074, IL_0075, IL_0079, IL_007d, IL_007e, IL_0082, IL_0089, IL_008d, IL_0094, IL_0098, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00cc
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 15)
			{
				object obj = default(object);
				version_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x369BDB0", Offset = "0x369A7B0", VA = "0x18369BDB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001b
			if (fieldNumber - 1 <= 15)
			{
				int num = (version_ = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x369E410", Offset = "0x369CE10", VA = "0x18369E410", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				TypeOneofCase typeOneofCase = typeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x369BFB0", Offset = "0x369A9B0", VA = "0x18369BFB0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x369C080", Offset = "0x369AA80", VA = "0x18369C080", Slot = "16")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0340, IL_0370, IL_0376, IL_037c, IL_0382, IL_0388, IL_038e, IL_0394, IL_039a, IL_03a0, IL_03a6, IL_03ac, IL_03b2, IL_03b8, IL_03be, IL_03c4, IL_03ca, IL_03d0, IL_03d6, IL_03dc, IL_03e2, IL_03e8, IL_03ee, IL_03f4, IL_03fa, IL_0400, IL_0406, IL_040c, IL_0412, IL_0418, IL_041e, IL_0424, IL_042a
			bool flag = default(bool);
			StoreContentBundle storeContentBundle = default(StoreContentBundle);
			StoreContentBundle storeContentBundle2 = default(StoreContentBundle);
			StoreContentBundle storeContentBundle3 = default(StoreContentBundle);
			StoreContentBundle storeContentBundle4 = default(StoreContentBundle);
			bool flag2 = default(bool);
			string text5 = default(string);
			string text6 = default(string);
			StoreContentItem storeContentItem = default(StoreContentItem);
			StoreContentItem storeContentItem2 = default(StoreContentItem);
			Predicate<ContentPrice> predicate = default(Predicate<ContentPrice>);
			while (true)
			{
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
				if ((IntPtr)endDate_ != (IntPtr)num3)
				{
					long seconds = startDate_.date_.Seconds;
					long seconds2 = endDate_.date_.Seconds;
					if (seconds > seconds2)
					{
						context.AddError("Start Date must be set to a date before the End Date.");
					}
				}
				if (((RepeatedField<T>)(object)contents_).Count <= 0)
				{
					break;
				}
				RepeatedField<StoreContent> repeatedField = contents_;
				switch (flag)
				{
				case true:
				{
					if (storeContentBundle.Data != null)
					{
						OnlineBundleData data = storeContentBundle2.Data;
						string v = minGameVersion_;
						if (data.minGameVersion_.TryIsGameVersionHigher(v, out *(bool*)num))
						{
							string[] array = new string[7];
							if ("Bundle '" != null && "Bundle '" == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[0] = "Bundle '";
							string id_ = storeContentBundle3.id_;
							if (id_ != null && storeContentBundle3 == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[1] = id_;
							if ("' has a min game version (" != null && "' has a min game version (" == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[2] = "' has a min game version (";
							OnlineBundleData data2 = storeContentBundle4.Data;
							string text3 = data2.minGameVersion_;
							if (text3 != null && data2 == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[3] = text3;
							if (") higher than the store (" != null && ") higher than the store (" == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[4] = ") higher than the store (";
							string text4 = minGameVersion_;
							if (text4 != null && ") higher than the store (" == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[5] = text4;
							if (")." != null && ")." == null)
							{
								throw new IndexOutOfRangeException();
							}
							array[6] = ").";
							string error = string.Concat(array);
							context.AddError(error);
						}
					}
					if (!flag2)
					{
						return;
					}
					if (flag2 && (long)startDate_ != 0)
					{
						Timestamp date_ = startDate_.date_;
						long seconds3 = date_.Seconds;
						if ((flag2 ? 1 : 0) < seconds3)
						{
							DateTime arg = date_.ToDateTime();
							DateTime arg2 = startDate_.date_.ToDateTime();
							text5 = $"Sale starting date {arg} cannot be set before the store starting date {arg2}.";
							context.AddInvalidMemberError(text5, "StartDate");
						}
					}
					while (text5 == null)
					{
					}
					while ((long)endDate_ == 0)
					{
					}
					Timestamp date_2 = endDate_.date_;
					long seconds4 = date_2.Seconds;
					while ((long)text5 <= seconds4)
					{
					}
					DateTime arg3 = date_2.ToDateTime();
					DateTime arg4 = endDate_.date_.ToDateTime();
					text6 = $"Sale ending date {arg3} cannot be set after the store ending date {arg4}.";
					context.AddInvalidMemberError(text6, "EndDate");
					goto default;
				}
				default:
					while ((long)text6 != 2)
					{
					}
					if (((RepeatedField<T>)(object)storeContentItem.availablePrices_).Count > 0)
					{
						RepeatedField<ContentPrice> availablePrices_ = storeContentItem2.availablePrices_;
						if (_003C_003Ec._003C_003E9__114_0 == null)
						{
							predicate = (Predicate<ContentPrice>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ContentPrice x) => x.amount_ <= 0));
						}
						if (!((RepeatedField<>)(object)availablePrices_).Any<ContentPrice>((Predicate<>)(object)predicate))
						{
							break;
						}
						context.AddInvalidMemberError("One or more bundle price(s) have an amount of 0 and it must be greater or equal than 1.", "AvailablePrices");
					}
					context.AddInvalidMemberError("Item must have at least 1 valid price.", "AvailablePrices");
					return;
				case false:
					return;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x369F610", Offset = "0x369E010", VA = "0x18369F610", Slot = "17")]
		public unsafe StoreConfig ToServerConfig(string onlineId)
		{
			//Discarded unreachable code: IL_02bb, IL_02c7, IL_02cd, IL_02d3, IL_02d9, IL_02df, IL_02e5, IL_02eb, IL_02f1, IL_02f7, IL_02fd, IL_0303, IL_0309, IL_030f, IL_0315, IL_031b, IL_0327, IL_032d, IL_0333, IL_0339, IL_033f, IL_0345, IL_034b, IL_0351, IL_0357, IL_035d
			//IL_0069: Expected O, but got I4
			//IL_0146: Expected I4, but got I8
			//IL_0186: Expected I4, but got O
			//IL_01f6: Expected O, but got I4
			//IL_022f: Expected O, but got I4
			//IL_025a: Expected I4, but got I8
			StoreOffer _003CDefinition_003Ek__BackingField = default(StoreOffer);
			bool flag2 = default(bool);
			int num7 = default(int);
			int _003CData_003Ek__BackingField = default(int);
			DateTime _003CStartDate_003Ek__BackingField = default(DateTime);
			DateTime _003CEndDate_003Ek__BackingField = default(DateTime);
			bool flag3 = default(bool);
			IStoreContentType _003CId_003Ek__BackingField = default(IStoreContentType);
			IEnumerable<ContentPrice> enumerable = default(IEnumerable<ContentPrice>);
			StoreContentItem storeContentItem = default(StoreContentItem);
			StoreContentBundle storeContentBundle = default(StoreContentBundle);
			StoreContentBundle storeContentBundle2 = default(StoreContentBundle);
			StoreContentBundle storeContentBundle3 = default(StoreContentBundle);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				StoreConfig storeConfig = new StoreConfig();
				storeConfig.OnlineId = onlineId;
				int num5 = (storeConfig.Version = version_);
				DateTime dateTime = (storeConfig.StartDate = startDate_.date_.ToDateTime());
				ConditionDate conditionDate = endDate_;
				if (conditionDate != null)
				{
					DateTime dateTime2 = conditionDate.date_.ToDateTime();
					int num6 = 0;
				}
				storeConfig.EndDate = (DateTime?)(object)num;
				bool flag = (storeConfig.IsHidden = (active_ ? 1 : 0) == num2);
				string text = (storeConfig.MinGameVersion = minGameVersion_);
				List<glPlayFab.Disney.StoreContent> list = (storeConfig.Contents = (List<glPlayFab.Disney.StoreContent>)(object)new List<T>());
				TypeOneofCase typeOneofCase = typeCase_;
				if (typeOneofCase != TypeOneofCase.Offer)
				{
					if (typeOneofCase != TypeOneofCase.Rotation)
					{
						if (typeOneofCase != TypeOneofCase.InAppPurchase)
						{
							if (typeOneofCase != TypeOneofCase.GameUpgrade)
							{
								goto IL_00f9;
							}
							StoreGameUpgrade storeGameUpgrade = GameUpgrade.ToServerConfig();
						}
						StoreInAppPurchase storeInAppPurchase = InAppPurchase.ToServerConfig();
					}
					if (type_ == null)
					{
						throw new InvalidCastException();
					}
				}
				if (type_ == null)
				{
					break;
				}
				storeConfig.Definition = _003CDefinition_003Ek__BackingField;
				goto IL_00f9;
				IL_022f:
				glPlayFab.Disney.StoreContent storeContent;
				if (flag2)
				{
					if (flag2)
					{
						new glPlayFab.Disney.StoreContent.SaleData().Type = (glPlayFab.Disney.StoreContent.SaleType)num2;
					}
					while (num7 != 2)
					{
					}
					glPlayFab.Disney.StoreContent.SaleData saleData = new glPlayFab.Disney.StoreContent.SaleData();
					saleData.Type = glPlayFab.Disney.StoreContent.SaleType.PriceDiscountPct;
					saleData.Data = _003CData_003Ek__BackingField;
					saleData.StartDate = _003CStartDate_003Ek__BackingField;
					saleData.EndDate = _003CEndDate_003Ek__BackingField;
					if ((long)storeContent.Sales == 0)
					{
						List<glPlayFab.Disney.StoreContent.SaleData> list2 = (storeContent.Sales = (List<glPlayFab.Disney.StoreContent.SaleData>)(object)new List<T>());
					}
					((List<T>)(object)storeContent.Sales).Add((T)saleData);
				}
				if (num2 == 0)
				{
					((List<T>)(object)storeConfig.Contents).Add((T)storeContent);
					goto IL_02b1;
				}
				throw new NullReferenceException();
				IL_02b1:
				if (num2 != 0)
				{
					break;
				}
				return storeConfig;
				IL_00f9:
				RepeatedField<StoreContent> repeatedField = contents_;
				if (flag3)
				{
					string value = (flag3 ? ((bool*)1) : ((bool*)null))->ToString();
					bool flag4 = flag3;
					if (!System.Enum.TryParse<glPlayFab.Disney.StoreContent.ContentType>(value, out *(glPlayFab.Disney.StoreContent.ContentType*)num2))
					{
						continue;
					}
					storeContent = new glPlayFab.Disney.StoreContent();
					storeContent.Id = (string)(object)_003CId_003Ek__BackingField;
					storeContent.Type = (glPlayFab.Disney.StoreContent.ContentType)num2;
					storeContent.Quantity = 1;
					if (_003C_003Ec._003C_003E9__115_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ContentPrice x)
						{
							//Discarded unreachable code: IL_0024
							glPlayFab.Disney.Price price = new glPlayFab.Disney.Price();
							int num13 = (price.CurrencyItemId = x.currencyId_);
							int num14 = (price.Amount = x.amount_);
							return price;
						};
					}
					List<glPlayFab.Disney.Price> list3 = (storeContent.AvailablePrices = (List<glPlayFab.Disney.Price>)(object)Enumerable.ToList<glPlayFab.Disney.Price>((IEnumerable<>)enumerable));
					storeContent.ArePricesOverriden = false;
					storeContent.IsFeatured = (byte)(int)list3 != 0;
					if (num2 != 0)
					{
						if (num2 != 1)
						{
							goto IL_022f;
						}
						int num8 = (storeContent.Quantity = storeContentItem.quantity_);
					}
					bool flag5 = (storeContent.ArePricesOverriden = ((RepeatedField<T>)(object)storeContentBundle.overrideAvailablePrices_).Count > 0);
					OnlineBundleData data = storeContentBundle2.Data;
					if (data != null)
					{
						ConditionDate conditionDate2 = data.startDate_;
						if (conditionDate2 != null)
						{
							DateTime dateTime3 = conditionDate2.date_.ToDateTime();
							int num9 = 0;
						}
					}
					int num10 = 0;
					storeContent.StartDateServerOnly = (DateTime?)(object)num10;
					OnlineBundleData data2 = storeContentBundle3.Data;
					if (data2 != null)
					{
						ConditionDate conditionDate3 = data2.endDate_;
						if (conditionDate3 != null)
						{
							DateTime dateTime4 = conditionDate3.date_.ToDateTime();
							int num11 = 0;
						}
					}
					int num12 = 0;
					storeContent.EndDateServerOnly = (DateTime?)(object)num12;
					goto IL_022f;
				}
				goto IL_02b1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x369D000", Offset = "0x369BA00", VA = "0x18369D000")]
		public static OnlineStoreData FromServerConfig(StoreConfig serverStoreConfig, DateTime lastUpdateTimestamp)
		{
			//Discarded unreachable code: IL_037e, IL_0384, IL_038a, IL_0390, IL_0396, IL_039c, IL_03a2, IL_03a8, IL_03ae, IL_03b4, IL_03ba, IL_03c0, IL_03c6, IL_03cc, IL_03d8, IL_03de, IL_03e4, IL_03ea, IL_03f0, IL_03f6
			//IL_0065: Expected I4, but got I8
			//IL_00ad: Expected I4, but got I8
			//IL_00b4: Expected O, but got I4
			//IL_0127: Expected I4, but got I8
			//IL_0193: Expected I4, but got O
			//IL_01c2: Expected O, but got I4
			//IL_0202: Expected O, but got I4
			//IL_023c: Expected I4, but got O
			//IL_0245: Expected I4, but got O
			//IL_0285: Expected O, but got I4
			//IL_029e: Expected I4, but got O
			//IL_0322: Expected I4, but got I8
			//IL_034d: Expected I4, but got I8
			DateTime dateTime = default(DateTime);
			StoreTypeOffer storeTypeOffer = default(StoreTypeOffer);
			StoreTypeRotation storeTypeRotation = default(StoreTypeRotation);
			StoreTypeInAppPurchase storeTypeInAppPurchase = default(StoreTypeInAppPurchase);
			StoreTypeGameUpgrade storeTypeGameUpgrade = default(StoreTypeGameUpgrade);
			bool flag2 = default(bool);
			Func<glPlayFab.Disney.Price, ContentPrice> func = default(Func<glPlayFab.Disney.Price, ContentPrice>);
			List<ContentPrice> list = default(List<ContentPrice>);
			bool flag3 = default(bool);
			Func<glPlayFab.Disney.Price, ContentPrice> func2 = default(Func<glPlayFab.Disney.Price, ContentPrice>);
			bool flag4 = default(bool);
			StoreSaleType storeSaleType = default(StoreSaleType);
			Timestamp date_ = default(Timestamp);
			Timestamp date_2 = default(Timestamp);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				OnlineStoreData onlineStoreData = new OnlineStoreData();
				string text = (onlineStoreData.onlineId_ = ProtoPreconditions.CheckNotNull(serverStoreConfig.OnlineId, "value"));
				int num4 = (onlineStoreData.version_ = serverStoreConfig.Version);
				ConditionDate conditionDate = new ConditionDate();
				Timestamp timestamp = (conditionDate.date_ = serverStoreConfig.StartDate.ToProto());
				conditionDate.localTime_ = (byte)num != 0;
				conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
				onlineStoreData.startDate_ = conditionDate;
				DateTime? _003CEndDate_003Ek__BackingField = serverStoreConfig.EndDate;
				if (timestamp != null)
				{
					ConditionDate conditionDate2 = new ConditionDate();
					DateTime? _003CEndDate_003Ek__BackingField2 = serverStoreConfig.EndDate;
					Timestamp timestamp2 = (conditionDate2.date_ = dateTime.ToProto());
					conditionDate2.localTime_ = (byte)num != 0;
					conditionDate2.operator_ = IntOperator.LessThan;
				}
				onlineStoreData.endDate_ = (ConditionDate)num;
				bool flag = (onlineStoreData.active_ = (serverStoreConfig.IsHidden ? 1 : 0) == num);
				string text2 = (onlineStoreData.minGameVersion_ = ProtoPreconditions.CheckNotNull(serverStoreConfig.MinGameVersion, "value"));
				int num5 = 0;
				string text3 = (onlineStoreData.language_ = ProtoPreconditions.CheckNotNull(LocalizationUtil.CurrentLanguage, "value"));
				ConditionDate conditionDate3 = new ConditionDate();
				Timestamp timestamp3 = (conditionDate3.date_ = lastUpdateTimestamp.ToProto());
				conditionDate3.localTime_ = (byte)num != 0;
				conditionDate3.operator_ = IntOperator.GreaterThanOrEqual;
				onlineStoreData.lastUpdateTimestamp_ = conditionDate3;
				StoreDefinition _003CDefinition_003Ek__BackingField = serverStoreConfig.Definition;
				if (_003CDefinition_003Ek__BackingField != null)
				{
					int num6 = 0;
					if (_003CDefinition_003Ek__BackingField != null)
					{
						onlineStoreData.type_ = storeTypeOffer;
					}
					if (storeTypeOffer != null)
					{
						int num7 = 0;
						if (storeTypeOffer != null)
						{
							onlineStoreData.type_ = storeTypeRotation;
						}
						if (storeTypeRotation != null)
						{
							int num8 = 0;
							if (storeTypeRotation != null)
							{
								onlineStoreData.type_ = storeTypeInAppPurchase;
							}
							if (storeTypeInAppPurchase != null)
							{
								int num9 = 0;
								if (storeTypeInAppPurchase != null)
								{
									onlineStoreData.type_ = storeTypeGameUpgrade;
									onlineStoreData.typeCase_ = (TypeOneofCase)storeTypeGameUpgrade;
								}
							}
						}
					}
				}
				List<glPlayFab.Disney.StoreContent> _003CContents_003Ek__BackingField = serverStoreConfig.Contents;
				if (flag2)
				{
					if (!flag2)
					{
						StoreContent storeContent = new StoreContent();
						StoreContentBundle storeContentBundle = new StoreContentBundle();
						int num10 = 0;
						storeContentBundle.Id = (string)num10;
						storeContent.Bundle = storeContentBundle;
						RepeatedField<ContentPrice> overrideAvailablePrices_ = storeContent.Bundle.overrideAvailablePrices_;
						if (_003C_003Ec._003C_003E9__116_0 == null)
						{
							func = (Func<glPlayFab.Disney.Price, ContentPrice>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(glPlayFab.Disney.Price x)
							{
								//Discarded unreachable code: IL_0024
								ContentPrice contentPrice2 = new ContentPrice();
								int num17 = (contentPrice2.currencyId_ = x.CurrencyItemId);
								int num18 = (contentPrice2.amount_ = x.Amount);
								return contentPrice2;
							});
						}
						list = (List<ContentPrice>)(object)Enumerable.ToList<ContentPrice>(Enumerable.Select<glPlayFab.Disney.Price, ContentPrice>((IEnumerable<>)num, (Func<, >)(object)func));
						((RepeatedField<T>)(object)overrideAvailablePrices_).AddRange((IEnumerable<>)list);
					}
					while ((long)list != 1)
					{
					}
					StoreContent storeContent2 = new StoreContent();
					StoreContentItem storeContentItem = new StoreContentItem();
					if (flag3)
					{
					}
					Item invalid = Item.Invalid;
					storeContentItem.item_ = (int)invalid;
					storeContentItem.quantity_ = (int)invalid;
					storeContent2.Item = storeContentItem;
					RepeatedField<ContentPrice> availablePrices_ = storeContent2.Item.availablePrices_;
					if (_003C_003Ec._003C_003E9__116_1 == null)
					{
						func2 = (Func<glPlayFab.Disney.Price, ContentPrice>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(glPlayFab.Disney.Price x)
						{
							//Discarded unreachable code: IL_0024
							ContentPrice contentPrice = new ContentPrice();
							int num15 = (contentPrice.currencyId_ = x.CurrencyItemId);
							int num16 = (contentPrice.amount_ = x.Amount);
							return contentPrice;
						});
					}
					List<ContentPrice> list2 = (List<ContentPrice>)(object)Enumerable.ToList<ContentPrice>(Enumerable.Select<glPlayFab.Disney.Price, ContentPrice>((IEnumerable<>)num, (Func<, >)(object)func2));
					((RepeatedField<T>)(object)availablePrices_).AddRange((IEnumerable<>)list2);
					storeContent2.isFeatured_ = (byte)(int)list2 != 0;
					if (list2 != null)
					{
						if (flag4)
						{
							if (!flag4)
							{
								StoreContent.Types.StoreSale storeSale = new StoreContent.Types.StoreSale();
								storeSaleType = new StoreSaleType();
								int num12 = (storeSaleType.PriceDiscountValue = 0);
								storeSale.type_ = storeSaleType;
							}
							while ((long)storeSaleType != 1)
							{
							}
							StoreContent.Types.StoreSale storeSale2 = new StoreContent.Types.StoreSale();
							StoreSaleType storeSaleType2 = new StoreSaleType();
							int num14 = (storeSaleType2.PriceDiscountPct = 0);
							storeSale2.type_ = storeSaleType2;
							ConditionDate conditionDate4 = new ConditionDate();
							conditionDate4.date_ = date_;
							conditionDate4.localTime_ = false;
							conditionDate4.operator_ = IntOperator.GreaterThanOrEqual;
							storeSale2.startDate_ = conditionDate4;
							ConditionDate conditionDate5 = new ConditionDate();
							conditionDate5.date_ = date_2;
							conditionDate5.localTime_ = false;
							conditionDate5.operator_ = IntOperator.LessThan;
							storeSale2.endDate_ = conditionDate5;
							((RepeatedField<T>)(object)storeContent2.sales_).Add((T)storeSale2);
						}
						if (num != 0)
						{
							break;
						}
					}
					((RepeatedField<T>)(object)onlineStoreData.contents_).Add((T)storeContent2);
				}
				if (num == 0)
				{
					return onlineStoreData;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x36A05F0", Offset = "0x369EFF0", VA = "0x1836A05F0")]
		static OnlineStoreData()
		{
			MessageParser<StoreContent> parser = StoreContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<OnlineStoreData>)(object)FieldCodec.ForMessage<StoreContent>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
