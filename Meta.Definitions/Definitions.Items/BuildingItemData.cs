using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002ED")]
	public sealed class BuildingItemData : IMessage<BuildingItemData>, IMessage, IEquatable<BuildingItemData>, IDeepCloneable<BuildingItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridEditRestriction, IGridPlaceableItemData, IGridStateDataProvider, IBuildingUnlockable, IBuildingConstructable, IHasTags, IBuildingUpgradable, IDataValidation, IDefaultGridLayoutPathProvider, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x4000D64")]
		private static readonly MessageParser<BuildingItemData> _parser = (MessageParser<BuildingItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new BuildingItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D65")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D66")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D67")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000D68")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D69")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4000D6A")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000D6B")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4000D6C")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000D6D")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000D6E")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000D6F")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000D70")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000D71")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000D72")]
		public const int SceneFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000D73")]
		private int scene_;

		[Cpp2IlInjected.Token(Token = "0x4000D74")]
		public const int UnlockWithFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000D75")]
		private int unlockWith_;

		[Cpp2IlInjected.Token(Token = "0x4000D76")]
		public const int UnlockAtLevelFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000D77")]
		private int unlockAtLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000D78")]
		public const int LockedPrefabAddressFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000D79")]
		private string lockedPrefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000D7A")]
		public const int UnlockCostFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4000D7B")]
		private static readonly FieldCodec<CurrencyCost> _repeated_unlockCost_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000D7C")]
		private readonly RepeatedField<CurrencyCost> unlockCost_;

		[Cpp2IlInjected.Token(Token = "0x4000D7D")]
		public const int ManaCostFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000D7E")]
		private int manaCost_;

		[Cpp2IlInjected.Token(Token = "0x4000D7F")]
		public const int UnlockDialogueAddressFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000D80")]
		private string unlockDialogueAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000D81")]
		public const int TagsFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x4000D82")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000D83")]
		private readonly RepeatedField<int> tags_;

		[Cpp2IlInjected.Token(Token = "0x4000D84")]
		public const int RequiredFurnituresFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4000D85")]
		private static readonly FieldCodec<int> _repeated_requiredFurnitures_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000D86")]
		private readonly RepeatedField<int> requiredFurnitures_;

		[Cpp2IlInjected.Token(Token = "0x4000D87")]
		public const int UpgradeInfoFieldNumber = 40;

		[Cpp2IlInjected.Token(Token = "0x4000D88")]
		private static readonly FieldCodec<UpgradeData> _repeated_upgradeInfo_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000D89")]
		private readonly RepeatedField<UpgradeData> upgradeInfo_;

		[Cpp2IlInjected.Token(Token = "0x4000D8A")]
		public const int DefaultGridLayoutPathFieldNumber = 41;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000D8B")]
		private string defaultGridLayoutPath_;

		[Cpp2IlInjected.Token(Token = "0x4000D8C")]
		public const int GridEditRestrictionFieldNumber = 42;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000D8D")]
		private GridEditRestriction gridEditRestriction_;

		[Cpp2IlInjected.Token(Token = "0x4000D8E")]
		public const int IsUnavailableForGeneratorFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000D8F")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000D90")]
		public const int IsSyncOnlineItemFieldNumber = 51;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000D91")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000D92")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000D93")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000D94")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000765")]
		[DebuggerNonUserCode]
		public static MessageParser<BuildingItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF5")]
			[Cpp2IlInjected.Address(RVA = "0x32EE9E0", Offset = "0x32ED3E0", VA = "0x1832EE9E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000766")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF6")]
			[Cpp2IlInjected.Address(RVA = "0x32EE8C0", Offset = "0x32ED2C0", VA = "0x1832EE8C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000767")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF7")]
			[Cpp2IlInjected.Address(RVA = "0x32EECB0", Offset = "0x32ED6B0", VA = "0x1832EECB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000768")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001FFC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FFD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000769")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001FFE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FFF")]
			[Cpp2IlInjected.Address(RVA = "0x32EEF80", Offset = "0x32ED980", VA = "0x1832EEF80")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076A")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002000")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002001")]
			[Cpp2IlInjected.Address(RVA = "0x32EEE30", Offset = "0x32ED830", VA = "0x1832EEE30")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076B")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002002")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002003")]
			[Cpp2IlInjected.Address(RVA = "0x32EEEA0", Offset = "0x32ED8A0", VA = "0x1832EEEA0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076C")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002004")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002005")]
			[Cpp2IlInjected.Address(RVA = "0x32EEFF0", Offset = "0x32ED9F0", VA = "0x1832EEFF0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076D")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6002006")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "24")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002007")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076E")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x6002008")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return scene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002009")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				scene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076F")]
		[DebuggerNonUserCode]
		public int UnlockWith
		{
			[Cpp2IlInjected.Token(Token = "0x600200A")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return unlockWith_;
			}
			[Cpp2IlInjected.Token(Token = "0x600200B")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				unlockWith_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000770")]
		[DebuggerNonUserCode]
		public int UnlockAtLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600200C")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return unlockAtLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x600200D")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				unlockAtLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000771")]
		[DebuggerNonUserCode]
		public string LockedPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600200E")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "29")]
			get
			{
				return lockedPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600200F")]
			[Cpp2IlInjected.Address(RVA = "0x32EEF10", Offset = "0x32ED910", VA = "0x1832EEF10")]
			set
			{
				string text = (lockedPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000772")]
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyCost> UnlockCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002010")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return unlockCost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000773")]
		[DebuggerNonUserCode]
		public int ManaCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002011")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "31")]
			get
			{
				return manaCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002012")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				manaCost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000774")]
		[DebuggerNonUserCode]
		public string UnlockDialogueAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002013")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "32")]
			get
			{
				return unlockDialogueAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002014")]
			[Cpp2IlInjected.Address(RVA = "0x32EF060", Offset = "0x32EDA60", VA = "0x1832EF060")]
			set
			{
				string text = (unlockDialogueAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000775")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002015")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "35")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000776")]
		[DebuggerNonUserCode]
		public RepeatedField<int> RequiredFurnitures
		{
			[Cpp2IlInjected.Token(Token = "0x6002016")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return requiredFurnitures_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000777")]
		[DebuggerNonUserCode]
		public RepeatedField<UpgradeData> UpgradeInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6002017")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "36")]
			get
			{
				return upgradeInfo_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000778")]
		[DebuggerNonUserCode]
		public string DefaultGridLayoutPath
		{
			[Cpp2IlInjected.Token(Token = "0x6002018")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "39")]
			get
			{
				return defaultGridLayoutPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002019")]
			[Cpp2IlInjected.Address(RVA = "0x32EEDC0", Offset = "0x32ED7C0", VA = "0x1832EEDC0")]
			set
			{
				string text = (defaultGridLayoutPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000779")]
		[DebuggerNonUserCode]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x600201A")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0", Slot = "23")]
			get
			{
				return gridEditRestriction_;
			}
			[Cpp2IlInjected.Token(Token = "0x600201B")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			set
			{
				gridEditRestriction_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077A")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x600201C")]
			[Cpp2IlInjected.Address(RVA = "0x1603120", Offset = "0x1601B20", VA = "0x181603120", Slot = "42")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x600201D")]
			[Cpp2IlInjected.Address(RVA = "0x1552740", Offset = "0x1551140", VA = "0x181552740", Slot = "43")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077B")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x600201E")]
			[Cpp2IlInjected.Address(RVA = "0x2287B30", Offset = "0x2286530", VA = "0x182287B30", Slot = "40")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x600201F")]
			[Cpp2IlInjected.Address(RVA = "0x2287B80", Offset = "0x2286580", VA = "0x182287B80", Slot = "41")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077C")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002020")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7C0", Offset = "0xF391C0", VA = "0x180F3A7C0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002021")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7D0", Offset = "0xF391D0", VA = "0x180F3A7D0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077D")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600202D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "26")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077E")]
		public Item SceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x600202E")]
			[Cpp2IlInjected.Address(RVA = "0x32EEB90", Offset = "0x32ED590", VA = "0x1832EEB90")]
			get
			{
				long num = Convert.ToInt64((uint)scene_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077F")]
		public Item UnlockWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600202F")]
			[Cpp2IlInjected.Address(RVA = "0x32EEBF0", Offset = "0x32ED5F0", VA = "0x1832EEBF0", Slot = "27")]
			get
			{
				long num = Convert.ToInt64((uint)unlockWith_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000780")]
		public int UnlockAtPlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6002030")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "28")]
			get
			{
				return unlockAtLevel_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000781")]
		public RepeatedField<CurrencyCost> UnlockCurrencyCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002031")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060", Slot = "30")]
			get
			{
				return unlockCost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000782")]
		public RepeatedField<UpgradeData> UpgradeBuildingInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6002032")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return upgradeInfo_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000783")]
		public Item[] RequiredItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002033")]
			[Cpp2IlInjected.Address(RVA = "0x32EEA40", Offset = "0x32ED440", VA = "0x1832EEA40")]
			get
			{
				RepeatedField<int> repeatedField = requiredFurnitures_;
				Func<int, Item> _003C_003E9__141_ = _003C_003Ec._003C_003E9__141_0;
				if (_003C_003E9__141_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__141_).ToArray<Item>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000784")]
		public bool MustConstruct
		{
			[Cpp2IlInjected.Token(Token = "0x6002034")]
			[Cpp2IlInjected.Address(RVA = "0x32EE990", Offset = "0x32ED390", VA = "0x1832EE990", Slot = "33")]
			get
			{
				//Discarded unreachable code: IL_000f
				return ((RepeatedField<T>)(object)requiredFurnitures_).Count > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000785")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002035")]
			[Cpp2IlInjected.Address(RVA = "0x32EEC50", Offset = "0x32ED650", VA = "0x1832EEC50", Slot = "34")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000786")]
		public string DefaultGridLayoutTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6002036")]
			[Cpp2IlInjected.Address(RVA = "0x32EE800", Offset = "0x32ED200", VA = "0x1832EE800", Slot = "38")]
			get
			{
				int num = iD_;
				BuildingItem buildingItem = default(BuildingItem);
				int buildingItemID = buildingItem.BuildingItemID;
				string result = "Meta.GridCollection, Meta";
				if (buildingItemID == 0)
				{
					result = "Meta.DefaultCharacterHouseData, Meta";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FF8")]
		[Cpp2IlInjected.Address(RVA = "0x32EE3B0", Offset = "0x32ECDB0", VA = "0x1832EE3B0")]
		[DebuggerNonUserCode]
		public BuildingItemData()
		{
			name_ = "";
			displayName_ = "";
			iconAddress_ = "";
			prefabAddress_ = "";
			lockedPrefabAddress_ = "";
			unlockCost_ = (RepeatedField<CurrencyCost>)(object)new RepeatedField<T>();
			unlockDialogueAddress_ = "";
			tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			requiredFurnitures_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			upgradeInfo_ = (RepeatedField<UpgradeData>)(object)new RepeatedField<T>();
			defaultGridLayoutPath_ = "";
			base._002Ector();
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FF9")]
		[Cpp2IlInjected.Address(RVA = "0x32ED200", Offset = "0x32EBC00", VA = "0x1832ED200")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFA")]
		[Cpp2IlInjected.Address(RVA = "0x32EE5C0", Offset = "0x32ECFC0", VA = "0x1832EE5C0")]
		[DebuggerNonUserCode]
		public BuildingItemData(BuildingItemData other)
		{
			//IL_0069: Expected O, but got I4
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData = other.gridAreaData_;
			int num2 = 0;
			if (gridAreaData != null)
			{
				GridAreaData gridAreaData2 = gridAreaData.Clone();
			}
			gridAreaData_ = (GridAreaData)num2;
			int num3 = (scene_ = other.scene_);
			int num4 = (unlockWith_ = other.unlockWith_);
			int num5 = (unlockAtLevel_ = other.unlockAtLevel_);
			string text5 = (lockedPrefabAddress_ = other.lockedPrefabAddress_);
			RepeatedField<CurrencyCost> repeatedField = (unlockCost_ = (RepeatedField<CurrencyCost>)(object)((RepeatedField<T>)(object)other.unlockCost_).Clone());
			int num6 = (manaCost_ = other.manaCost_);
			string text6 = (unlockDialogueAddress_ = other.unlockDialogueAddress_);
			RepeatedField<int> repeatedField2 = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			RepeatedField<int> repeatedField3 = (requiredFurnitures_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.requiredFurnitures_).Clone());
			RepeatedField<UpgradeData> repeatedField4 = (upgradeInfo_ = (RepeatedField<UpgradeData>)(object)((RepeatedField<T>)(object)other.upgradeInfo_).Clone());
			string text7 = (defaultGridLayoutPath_ = other.defaultGridLayoutPath_);
			GridEditRestriction gridEditRestriction = other.gridEditRestriction_;
			GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
			if (gridEditRestriction != null)
			{
				gridEditRestriction2 = gridEditRestriction.Clone();
			}
			gridEditRestriction_ = gridEditRestriction2;
			bool flag = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag2 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num7 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFB")]
		[Cpp2IlInjected.Address(RVA = "0x32EB130", Offset = "0x32E9B30", VA = "0x1832EB130", Slot = "10")]
		[DebuggerNonUserCode]
		public BuildingItemData Clone()
		{
			return new BuildingItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002022")]
		[Cpp2IlInjected.Address(RVA = "0x32EBF30", Offset = "0x32EA930", VA = "0x1832EBF30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((BuildingItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002023")]
		[Cpp2IlInjected.Address(RVA = "0x32EBF90", Offset = "0x32EA990", VA = "0x1832EBF90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuildingItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if ((IntPtr)_repeated_requiredFurnitures_codec == (IntPtr)num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
									{
										int num2 = other.scene_;
										if (scene_ == num2)
										{
											int num3 = other.unlockWith_;
											if (unlockWith_ == num3)
											{
												int num4 = other.unlockAtLevel_;
												if (unlockAtLevel_ == num4)
												{
													string text5 = other.lockedPrefabAddress_;
													if (!(lockedPrefabAddress_ != text5))
													{
														RepeatedField<CurrencyCost> repeatedField = unlockCost_;
														RepeatedField<CurrencyCost> repeatedField2 = other.unlockCost_;
														if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
														{
															int num5 = other.manaCost_;
															if (manaCost_ == num5)
															{
																string text6 = other.unlockDialogueAddress_;
																if (!(unlockDialogueAddress_ != text6))
																{
																	RepeatedField<int> repeatedField3 = tags_;
																	RepeatedField<int> repeatedField4 = other.tags_;
																	if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																	{
																		RepeatedField<int> repeatedField5 = requiredFurnitures_;
																		RepeatedField<int> repeatedField6 = other.requiredFurnitures_;
																		if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
																		{
																			RepeatedField<UpgradeData> repeatedField7 = upgradeInfo_;
																			RepeatedField<UpgradeData> repeatedField8 = other.upgradeInfo_;
																			if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
																			{
																				string text7 = other.defaultGridLayoutPath_;
																				if (!(defaultGridLayoutPath_ != text7))
																				{
																					GridEditRestriction objB2 = other.gridEditRestriction_;
																					if (object.Equals(gridEditRestriction_, objB2))
																					{
																						bool flag = other.isUnavailableForGenerator_;
																						if (isUnavailableForGenerator_ == flag)
																						{
																							bool flag2 = other.isSyncOnlineItem_;
																							if (isSyncOnlineItem_ == flag2)
																							{
																								uint num6 = other.glotID_;
																								if (glotID_ == num6)
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
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002024")]
		[Cpp2IlInjected.Address(RVA = "0x32EC6D0", Offset = "0x32EB0D0", VA = "0x1832EC6D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_017e
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int hashCode5 = gridAreaData.GetHashCode();
			}
			if (scene_ != 0)
			{
			}
			if (unlockWith_ != 0)
			{
			}
			if (unlockAtLevel_ != 0)
			{
			}
			string text5 = lockedPrefabAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)unlockCost_).GetHashCode();
			if (manaCost_ != 0)
			{
			}
			string text6 = unlockDialogueAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode8 = text6.GetHashCode();
			}
			int hashCode9 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			int hashCode10 = ((RepeatedField<T>)(object)requiredFurnitures_).GetHashCode();
			int hashCode11 = ((RepeatedField<T>)(object)upgradeInfo_).GetHashCode();
			string text7 = defaultGridLayoutPath_;
			if (text7.m_stringLength != 0)
			{
				int hashCode12 = text7.GetHashCode();
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int hashCode13 = gridEditRestriction.GetHashCode();
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode14 = unknownFields.GetHashCode();
			}
			return hashCode11;
		}

		[Cpp2IlInjected.Token(Token = "0x6002025")]
		[Cpp2IlInjected.Address(RVA = "0x32ED950", Offset = "0x32EC350", VA = "0x1832ED950", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002026")]
		[Cpp2IlInjected.Address(RVA = "0x32EDAF0", Offset = "0x32EC4F0", VA = "0x1832EDAF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0245
			if ((long)_repeated_requiredFurnitures_codec != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if ((long)gridAreaData_ != 0)
			{
				GridAreaData value6 = gridAreaData_;
				output.WriteMessage(value6);
			}
			if (scene_ != 0)
			{
				int value7 = scene_;
				output.WriteInt32(value7);
			}
			if (unlockWith_ != 0)
			{
				int value8 = unlockWith_;
				output.WriteInt32(value8);
			}
			if (unlockAtLevel_ != 0)
			{
				int value9 = unlockAtLevel_;
				output.WriteInt32(value9);
			}
			if (lockedPrefabAddress_.m_stringLength != 0)
			{
				string value10 = lockedPrefabAddress_;
				output.WriteString(value10);
			}
			RepeatedField<CurrencyCost> repeatedField = unlockCost_;
			FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_unlockCost_codec);
			if (manaCost_ != 0)
			{
				int value11 = manaCost_;
				output.WriteInt32(value11);
			}
			if (unlockDialogueAddress_.m_stringLength != 0)
			{
				string value12 = unlockDialogueAddress_;
				output.WriteString(value12);
			}
			RepeatedField<int> repeatedField2 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			RepeatedField<int> repeatedField3 = requiredFurnitures_;
			FieldCodec<int> repeated_requiredFurnitures_codec = _repeated_requiredFurnitures_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_requiredFurnitures_codec);
			RepeatedField<UpgradeData> repeatedField4 = upgradeInfo_;
			FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_upgradeInfo_codec);
			if (defaultGridLayoutPath_.m_stringLength != 0)
			{
				string value13 = defaultGridLayoutPath_;
				output.WriteString(value13);
			}
			if ((long)gridEditRestriction_ != 0)
			{
				GridEditRestriction value14 = gridEditRestriction_;
				output.WriteMessage(value14);
			}
			if (isUnavailableForGenerator_)
			{
				bool value15 = isUnavailableForGenerator_;
				output.WriteBool(value15);
			}
			if (isSyncOnlineItem_)
			{
				bool value16 = isSyncOnlineItem_;
				output.WriteBool(value16);
			}
			if (glotID_ != 0)
			{
				uint value17 = glotID_;
				output.WriteUInt32(value17);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002027")]
		[Cpp2IlInjected.Address(RVA = "0x32EA970", Offset = "0x32E9370", VA = "0x1832EA970", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_028d
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num2 += num8;
			}
			int num9 = scene_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = unlockWith_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = unlockAtLevel_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			string text5 = lockedPrefabAddress_;
			if (text5.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text5);
				num15++;
				num2 += num15;
			}
			RepeatedField<CurrencyCost> repeatedField = unlockCost_;
			FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_unlockCost_codec);
			int num17 = manaCost_;
			num2 += num16;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18 += 2;
				num2 += num18;
			}
			string text6 = unlockDialogueAddress_;
			if (text6.m_stringLength != 0)
			{
				int num19 = CodedOutputStream.ComputeStringSize(text6);
				num19 += 2;
				num2 += num19;
			}
			RepeatedField<int> repeatedField2 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			RepeatedField<int> repeatedField3 = requiredFurnitures_;
			FieldCodec<int> repeated_requiredFurnitures_codec = _repeated_requiredFurnitures_codec;
			int num21 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_requiredFurnitures_codec);
			RepeatedField<UpgradeData> repeatedField4 = upgradeInfo_;
			FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
			int num22 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_upgradeInfo_codec);
			string text7 = defaultGridLayoutPath_;
			if (text7.m_stringLength != 0)
			{
				int num23 = CodedOutputStream.ComputeStringSize(text7);
				num23 += 2;
				num2 += num23;
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int num24 = CodedOutputStream.ComputeMessageSize(gridEditRestriction);
				num24 += 2;
				num2 += num24;
			}
			uint num25 = glotID_;
			if (num25 != 0)
			{
				int num26 = CodedOutputStream.ComputeUInt32Size(num25);
				num26 += 2;
				num2 += num26;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num27 = unknownFields.CalculateSize();
				num2 += num27;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002028")]
		[Cpp2IlInjected.Address(RVA = "0x32ECEE0", Offset = "0x32EB8E0", VA = "0x1832ECEE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuildingItemData other)
		{
			//Discarded unreachable code: IL_0256
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if ((long)other.gridAreaData_ != 0)
			{
				GridAreaData gridAreaData2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					gridAreaData2 = gridAreaData_;
				}
				GridAreaData other2 = other.gridAreaData_;
				gridAreaData2.MergeFrom(other2);
			}
			int num2 = other.scene_;
			if (num2 != 0)
			{
				scene_ = num2;
			}
			int num3 = other.unlockWith_;
			if (num3 != 0)
			{
				unlockWith_ = num3;
			}
			int num4 = other.unlockAtLevel_;
			if (num4 != 0)
			{
				unlockAtLevel_ = num4;
			}
			string text5 = other.lockedPrefabAddress_;
			if (text5.m_stringLength != 0)
			{
				LockedPrefabAddress = text5;
			}
			RepeatedField<CurrencyCost> repeatedField = unlockCost_;
			RepeatedField<CurrencyCost> repeatedField2 = other.unlockCost_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num5 = other.manaCost_;
			if (num5 != 0)
			{
				manaCost_ = num5;
			}
			string text6 = other.unlockDialogueAddress_;
			if (text6.m_stringLength != 0)
			{
				UnlockDialogueAddress = text6;
			}
			RepeatedField<int> repeatedField3 = tags_;
			RepeatedField<int> repeatedField4 = other.tags_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<int> repeatedField5 = requiredFurnitures_;
			RepeatedField<int> repeatedField6 = other.requiredFurnitures_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			RepeatedField<UpgradeData> repeatedField7 = upgradeInfo_;
			RepeatedField<UpgradeData> repeatedField8 = other.upgradeInfo_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			string text7 = other.defaultGridLayoutPath_;
			if (text7.m_stringLength != 0)
			{
				DefaultGridLayoutPath = text7;
			}
			if ((long)other.gridEditRestriction_ != 0)
			{
				GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
				if (gridEditRestriction_ == null)
				{
					GridEditRestriction gridEditRestriction = (gridEditRestriction_ = new GridEditRestriction());
					gridEditRestriction2 = gridEditRestriction_;
				}
				GridEditRestriction other3 = other.gridEditRestriction_;
				gridEditRestriction2.MergeFrom(other3);
			}
			bool flag = other.isUnavailableForGenerator_;
			if (flag)
			{
				isUnavailableForGenerator_ = flag;
			}
			bool flag2 = other.isSyncOnlineItem_;
			if (flag2)
			{
				isSyncOnlineItem_ = flag2;
			}
			uint num6 = other.glotID_;
			if (num6 != 0)
			{
				glotID_ = num6;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002029")]
		[Cpp2IlInjected.Address(RVA = "0x32EC9D0", Offset = "0x32EB3D0", VA = "0x1832EC9D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_02c7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 114)
			{
				goto IL_0177;
			}
			if ((int)num > 250)
			{
				if ((int)num > 338)
				{
					if (num == 400)
					{
						bool flag = (isUnavailableForGenerator_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 408)
					{
						flag2 = (isSyncOnlineItem_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_02b0;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				if (num == 322)
				{
					RepeatedField<UpgradeData> repeatedField = upgradeInfo_;
					FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_upgradeInfo_codec);
				}
				string text2 = default(string);
				if (num == 330)
				{
					text2 = (DefaultGridLayoutPath = input.ReadString());
				}
				if ((long)text2 != 338)
				{
					goto IL_02b0;
				}
				GridEditRestriction builder = default(GridEditRestriction);
				if (gridEditRestriction_ == null)
				{
					GridEditRestriction gridEditRestriction = (gridEditRestriction_ = new GridEditRestriction());
					builder = gridEditRestriction_;
				}
				input.ReadMessage(builder);
			}
			if ((int)num > 240)
			{
				if (num == 242)
				{
					goto IL_015e;
				}
				num += 4294967048u;
				if (num != 4294967293u)
				{
					goto IL_02b0;
				}
				RepeatedField<int> repeatedField2 = requiredFurnitures_;
				FieldCodec<int> repeated_requiredFurnitures_codec = _repeated_requiredFurnitures_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_requiredFurnitures_codec);
			}
			int num3 = default(int);
			if (num == 160)
			{
				num3 = (manaCost_ = input.ReadInt32());
			}
			string text4 = default(string);
			if (num3 == 170)
			{
				text4 = (UnlockDialogueAddress = input.ReadString());
			}
			if ((long)text4 == 240)
			{
				goto IL_015e;
			}
			goto IL_02b0;
			IL_0177:
			int num6 = default(int);
			if ((int)num > 42)
			{
				string text6 = default(string);
				if ((int)num > 88)
				{
					int num4 = default(int);
					if (num == 96)
					{
						num4 = (unlockAtLevel_ = input.ReadInt32());
					}
					if (num4 == 106)
					{
						text6 = (LockedPrefabAddress = input.ReadString());
					}
					if ((long)text6 != 114)
					{
						goto IL_02b0;
					}
					RepeatedField<CurrencyCost> repeatedField3 = unlockCost_;
					FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
					((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unlockCost_codec);
				}
				GridAreaData gridAreaData = default(GridAreaData);
				if ((long)text6 == 50)
				{
					GridAreaData builder2 = default(GridAreaData);
					if (gridAreaData_ == null)
					{
						gridAreaData = (gridAreaData_ = new GridAreaData());
						builder2 = gridAreaData_;
					}
					input.ReadMessage(builder2);
				}
				int num5 = default(int);
				if ((long)gridAreaData == 80)
				{
					num5 = (scene_ = input.ReadInt32());
				}
				if (num5 != 88)
				{
					goto IL_02b0;
				}
				num6 = (unlockWith_ = input.ReadInt32());
			}
			string text12 = default(string);
			if (num6 > 18)
			{
				string text8 = default(string);
				if (num6 == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				string text10 = default(string);
				if ((long)text8 == 34)
				{
					text10 = (IconAddress = input.ReadString());
				}
				if ((long)text10 != 42)
				{
					goto IL_02b0;
				}
				text12 = (PrefabAddress = input.ReadString());
			}
			int num7 = default(int);
			if ((long)text12 == 8)
			{
				num7 = (iD_ = input.ReadInt32());
			}
			if (num7 == 18)
			{
				string text14 = (Name = input.ReadString());
			}
			goto IL_02b0;
			IL_02b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_015e:
			RepeatedField<int> repeatedField4 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_0177;
		}

		[Cpp2IlInjected.Token(Token = "0x600202A")]
		[Cpp2IlInjected.Address(RVA = "0x32EC210", Offset = "0x32EAC10", VA = "0x1832EC210", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 31)
			{
				if (fieldNumber > 50)
				{
					if (fieldNumber == 51)
					{
						bool flag = isSyncOnlineItem_;
					}
					if (fieldNumber != 999)
					{
						goto IL_0063;
					}
					uint num = glotID_;
				}
				if ((object)typeof(uint).TypeHandle != null && (object)typeof(uint).TypeHandle != null && (long)typeof(uint).TypeHandle != 1)
				{
					if (fieldNumber != 50)
					{
						goto IL_0063;
					}
					bool flag2 = isUnavailableForGenerator_;
				}
			}
			if (fieldNumber - 1 <= 20)
			{
				int num2 = iD_;
			}
			if (fieldNumber == 30)
			{
			}
			if (fieldNumber != 31)
			{
			}
			goto IL_0063;
			IL_0063:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600202B")]
		[Cpp2IlInjected.Address(RVA = "0x32ED260", Offset = "0x32EBC60", VA = "0x1832ED260", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0069, IL_006a, IL_006b, IL_006c, IL_006d, IL_0075, IL_007d, IL_0085, IL_0086, IL_0096, IL_009e, IL_00bd, IL_00c3, IL_00c9, IL_00cf, IL_00d5
			//IL_0016: Expected I4, but got O
			//IL_0026: Expected I4, but got O
			//IL_0050: Expected I4, but got O
			//IL_0058: Expected O, but got I4
			//IL_0068: Expected I4, but got O
			if (fieldNumber > 31)
			{
				if (fieldNumber > 50)
				{
					switch (fieldNumber)
					{
					case 51:
					{
						object obj2 = default(object);
						isSyncOnlineItem_ = (byte)(int)obj2 != 0;
						break;
					}
					case 999:
					{
						object obj = default(object);
						glotID_ = (uint)(int)obj;
						break;
					}
					}
					return;
				}
				if ((object)typeof(uint).TypeHandle != null)
				{
					if ((object)typeof(uint).TypeHandle == null)
					{
						return;
					}
					if ((long)typeof(uint).TypeHandle != 1)
					{
						if (fieldNumber == 50)
						{
							object obj3 = default(object);
							isUnavailableForGenerator_ = (byte)(int)obj3 != 0;
						}
					}
					else
					{
						gridEditRestriction_ = (GridEditRestriction)0;
					}
					return;
				}
			}
			else
			{
				if (fieldNumber - 1 <= 20)
				{
					object obj4 = default(object);
					iD_ = (int)obj4;
					return;
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600202C")]
		[Cpp2IlInjected.Address(RVA = "0x32EAE80", Offset = "0x32E9880", VA = "0x1832EAE80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0063, IL_0064, IL_0065, IL_0066, IL_0067, IL_0068, IL_0069, IL_006a, IL_006d, IL_006e
			//IL_0028: Expected I4, but got I8
			//IL_0062: Expected I4, but got I8
			if (fieldNumber > 31)
			{
				if (fieldNumber > 50)
				{
					switch (fieldNumber)
					{
					case 51:
						isSyncOnlineItem_ = false;
						break;
					case 999:
						glotID_ = 0u;
						break;
					}
					return;
				}
				if ("" != null)
				{
					if ("" != null && (long)"" != 1 && fieldNumber == 50)
					{
						isUnavailableForGenerator_ = false;
					}
					return;
				}
			}
			if (fieldNumber - 1 <= 20)
			{
				iD_ = 0;
				return;
			}
			if (fieldNumber == 30)
			{
			}
			while (fieldNumber != 31)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002037")]
		[Cpp2IlInjected.Address(RVA = "0x32EB130", Offset = "0x32E9B30", VA = "0x1832EB130", Slot = "20")]
		IItemData IItemData.Clone()
		{
			BuildingItemData buildingItemData = new BuildingItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002038")]
		[Cpp2IlInjected.Address(RVA = "0x32EC4F0", Offset = "0x32EAEF0", VA = "0x1832EC4F0")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			HouseData houseData = new HouseData();
			bool flag = (houseData.built_ = ((RepeatedField<T>)(object)requiredFurnitures_).Count <= 0);
			if (((RepeatedField<T>)(object)upgradeInfo_).Count > 0)
			{
				IProfileWorld section = worldProfile.Section;
				int num = 0;
				if (section != null)
				{
					int num2 = iD_;
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					num2 += num2;
				}
				UpgradeState upgradeState = new UpgradeState();
				bool flag2 = (byte)(upgradeState.level_ = ((num != 0) ? 1 : 0)) != 0;
				houseData.upgradeState_ = upgradeState;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002039")]
		[Cpp2IlInjected.Address(RVA = "0x32EB190", Offset = "0x32E9B90", VA = "0x1832EB190", Slot = "37")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_0105: Expected O, but got I4
			//IL_0291: Expected O, but got I4
			bool flag = default(bool);
			BuildingItem buildingItem = default(BuildingItem);
			BuildingItem buildingItem2 = default(BuildingItem);
			BuildingItemData buildingItemData = default(BuildingItemData);
			Func<UpgradeData, bool> func = default(Func<UpgradeData, bool>);
			Func<UpgradeData, int> func2 = default(Func<UpgradeData, int>);
			Func<UpgradeData, bool> func4 = default(Func<UpgradeData, bool>);
			IEnumerable<UpgradeData> enumerable2;
			Func<UpgradeData, bool> func6 = default(Func<UpgradeData, bool>);
			do
			{
				IL_0000:
				int num = 0;
				int refValue = 0;
				int value = unlockAtLevel_;
				context.RequireGreaterOrEqual(value, refValue, "UnlockAtLevel");
				string text = lockedPrefabAddress_;
				if (((RepeatedField<T>)(object)upgradeInfo_).Count == 0 || Enumerable.First<UpgradeData>((IEnumerable<>)(object)upgradeInfo_).level_ != 1)
				{
					context.AddError("When using LockedPrefabAddress, you need at least one UpgradeInfo (with Level=1).");
				}
				RepeatedField<UpgradeData> repeatedField = upgradeInfo_;
				Predicate<UpgradeData> predicate = (Predicate<UpgradeData>)(object)(Predicate<T>)delegate(UpgradeData x)
				{
					//Discarded unreachable code: IL_001c
					string b = lockedPrefabAddress_;
					bool flag2 = string.Equals(x.prefabAddress_, b);
					return (!flag2) ? flag2 : flag2;
				};
				if (((RepeatedField<>)(object)repeatedField).Any<UpgradeData>((Predicate<>)(object)predicate))
				{
					context.AddError("LockedPrefabAddress prefab should not be re-used by UpgradeInfo (building will appear locked even if unlocked)");
				}
				this.BuildingUpgradableValidation(context);
				if (((RepeatedField<T>)(object)upgradeInfo_).Count > 0)
				{
					string cpp2il__autoParamName__idx_ = unlockDialogueAddress_;
					context.RequireNotEmpty<char>((IEnumerable<>)(object)cpp2il__autoParamName__idx_, "UnlockDialogueAddress");
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num2 = unlockWith_;
				if (flag && iD_ != 0)
				{
					string[] array = new string[5];
					if ("Since " != null && "Since " == null)
					{
						goto IL_0000;
					}
					array[0] = "Since ";
					if (num != 0 && "Since " == null)
					{
						goto IL_0000;
					}
					array[1] = (string)num;
					if (" live inside " != null && " live inside " == null)
					{
						goto IL_0000;
					}
					array[2] = " live inside ";
					string text2 = name_;
					if (text2 != null && " live inside " == null)
					{
						goto IL_0000;
					}
					array[3] = text2;
					if (", that npc cannot be selected again for UnlockWithCharacter." != null && ", that npc cannot be selected again for UnlockWithCharacter." == null)
					{
						goto IL_0000;
					}
					array[4] = ", that npc cannot be selected again for UnlockWithCharacter.";
					string error = string.Concat(array);
					context.AddError(error);
				}
				int num3 = iD_;
				if (buildingItem.BuildingItemID != 0)
				{
					GridEditRestriction gridEditRestriction = gridEditRestriction_;
					if (gridEditRestriction != null)
					{
						GridEditRestriction.Types.Restriction canBeRemoved_ = gridEditRestriction.canBeRemoved_;
						if (canBeRemoved_.restrictionCase_ == GridEditRestriction.Types.Restriction.RestrictionOneofCase.Value && canBeRemoved_.Value)
						{
							goto IL_01d0;
						}
					}
					GridEditRestriction gridEditRestriction2 = gridEditRestriction_;
					if (gridEditRestriction2 != null && gridEditRestriction2.canBeRemoved_.restrictionCase_ == GridEditRestriction.Types.Restriction.RestrictionOneofCase.Conditions)
					{
						goto IL_01d0;
					}
				}
				goto IL_01e0;
				IL_01e0:
				int num4 = iD_;
				int buildingItemID = buildingItem2.BuildingItemID;
				if (buildingItemID != 5)
				{
					return;
				}
				if (iD_ == 0)
				{
					RepeatedField<UpgradeData> repeatedField2 = buildingItemData.upgradeInfo_;
					if (_003C_003Ec._003C_003E9__151_4 == null)
					{
						func = (Func<UpgradeData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.House.canReplaceWithSkins_));
					}
					IEnumerable<UpgradeData> enumerable = (IEnumerable<UpgradeData>)Enumerable.Where<UpgradeData>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func);
					if (_003C_003Ec._003C_003E9__151_5 == null)
					{
						func2 = (Func<UpgradeData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.level_));
					}
					int[] array2 = Enumerable.Select<UpgradeData, int>((IEnumerable<>)enumerable, (Func<, >)(object)func2).ToArray<int>();
					Func<int, bool> func3 = (Func<int, bool>)(object)new Func<T, TResult>(CheckLevelInfoForSkin);
					if (!((IEnumerable<>)(object)array2).All<int>((Func<, >)(object)func3))
					{
						string message = $"All levels on the default house ({buildingItemID}) which use CanReplaceWithSkins should have a corresponding entry in this item";
						context.AddInvalidMemberError(message, "UpgradeInfo");
					}
					return;
				}
				RepeatedField<UpgradeData> repeatedField3 = upgradeInfo_;
				if (_003C_003Ec._003C_003E9__151_1 == null)
				{
					func4 = (Func<UpgradeData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.House.canReplaceWithSkins_));
				}
				int num5 = ((RepeatedField<>)(object)repeatedField3).FindIndex<UpgradeData>((Func<, >)(object)func4);
				while (num5 == -1)
				{
				}
				int firstLevelWithSkins = ((UpgradeData)((RepeatedField<T>)(object)upgradeInfo_)[num5]).level_;
				RepeatedField<UpgradeData> repeatedField4 = upgradeInfo_;
				Func<UpgradeData, bool> func5 = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData x)
				{
					//Discarded unreachable code: IL_0014
					int num7 = firstLevelWithSkins;
					return x.level_ >= num7;
				};
				enumerable2 = (IEnumerable<UpgradeData>)Enumerable.Where<UpgradeData>((IEnumerable<>)(object)repeatedField4, (Func<, >)(object)func5);
				if (_003C_003Ec._003C_003E9__151_3 == null)
				{
					func6 = (Func<UpgradeData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.House.canReplaceWithSkins_));
				}
				continue;
				IL_01d0:
				context.AddInvalidMemberError("CanBeRemoved must be false, only House can be removed from village", "GridEditRestriction");
				goto IL_01e0;
			}
			while (((IEnumerable<>)enumerable2).All<UpgradeData>((Func<, >)(object)func6));
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x600203D")]
			[Cpp2IlInjected.Address(RVA = "0x32ED9F0", Offset = "0x32EC3F0", VA = "0x1832ED9F0")]
			bool CheckLevelInfoForSkin(int level)
			{
				//Discarded unreachable code: IL_0039
				RepeatedField<UpgradeData> repeatedField5 = upgradeInfo_;
				Func<UpgradeData, bool> func7 = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData y)
				{
					//Discarded unreachable code: IL_0011
					int num6 = level;
					return y.level_ == num6;
				};
				UpgradeData upgradeData = Enumerable.FirstOrDefault<UpgradeData>((IEnumerable<>)(object)repeatedField5, (Func<, >)(object)func7);
				if (upgradeData == null)
				{
				}
				return upgradeData.House.canReplaceWithSkins_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600203A")]
		[Cpp2IlInjected.Address(RVA = "0x32EDFE0", Offset = "0x32EC9E0", VA = "0x1832EDFE0")]
		static BuildingItemData()
		{
			//Discarded unreachable code: IL_0074
			//IL_006c: Expected O, but got I4
			MessageParser<CurrencyCost> parser = CurrencyCost._parser;
			uint num = default(uint);
			_parser = (MessageParser<BuildingItemData>)(object)FieldCodec.ForMessage<CurrencyCost>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<BuildingItemData>)(object)FieldCodec.ForInt32(num2);
			uint num3 = default(uint);
			_parser = (MessageParser<BuildingItemData>)(object)FieldCodec.ForInt32(num3);
			MessageParser<UpgradeData> parser2 = UpgradeData._parser;
			uint num4 = default(uint);
			_parser = (MessageParser<BuildingItemData>)(object)FieldCodec.ForMessage<UpgradeData>(num4, (MessageParser<>)(object)parser2);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num5 = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num5;
			ReadOnlyCollection<(TagItemType, int?)> parser3 = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<BuildingItemData>)(object)parser3;
		}

		[Cpp2IlInjected.Token(Token = "0x600203B")]
		[Cpp2IlInjected.Address(RVA = "0x32EBF20", Offset = "0x32EA920", VA = "0x1832EBF20", Slot = "25")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			return GetGridStateData(in worldProfile, context);
		}
	}
}
