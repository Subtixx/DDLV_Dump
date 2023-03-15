using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002F5")]
	public sealed class OffGridBuildingItemData : IMessage<OffGridBuildingItemData>, IMessage, IEquatable<OffGridBuildingItemData>, IDeepCloneable<OffGridBuildingItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBuildingUnlockable, IBuildingUpgradable, IDefaultGridLayoutPathProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000DEB")]
		private static readonly MessageParser<OffGridBuildingItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000DEC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000DED")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000DEE")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000DEF")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000DF0")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4000DF1")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000DF2")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4000DF3")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000DF4")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000DF5")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000DF6")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000DF7")]
		public const int SceneFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000DF8")]
		private int scene_;

		[Cpp2IlInjected.Token(Token = "0x4000DF9")]
		public const int UnlockWithFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000DFA")]
		private int unlockWith_;

		[Cpp2IlInjected.Token(Token = "0x4000DFB")]
		public const int UnlockAtLevelFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000DFC")]
		private int unlockAtLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000DFD")]
		public const int UnlockCostFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000DFE")]
		private static readonly FieldCodec<CurrencyCost> _repeated_unlockCost_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000DFF")]
		private readonly RepeatedField<CurrencyCost> unlockCost_;

		[Cpp2IlInjected.Token(Token = "0x4000E00")]
		public const int ManaCostFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000E01")]
		private int manaCost_;

		[Cpp2IlInjected.Token(Token = "0x4000E02")]
		public const int UnlockDialogueAddressFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000E03")]
		private string unlockDialogueAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000E04")]
		public const int UpgradeInfoFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000E05")]
		private static readonly FieldCodec<UpgradeData> _repeated_upgradeInfo_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000E06")]
		private readonly RepeatedField<UpgradeData> upgradeInfo_;

		[Cpp2IlInjected.Token(Token = "0x4000E07")]
		public const int DefaultGridLayoutTypeNameFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000E08")]
		private string defaultGridLayoutTypeName_;

		[Cpp2IlInjected.Token(Token = "0x4000E09")]
		public const int DefaultGridLayoutPathFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000E0A")]
		private string defaultGridLayoutPath_;

		[Cpp2IlInjected.Token(Token = "0x4000E0B")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000E0C")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x170007B6")]
		[DebuggerNonUserCode]
		public static MessageParser<OffGridBuildingItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60020C4")]
			[Cpp2IlInjected.Address(RVA = "0x29859C0", Offset = "0x29843C0", VA = "0x1829859C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60020C5")]
			[Cpp2IlInjected.Address(RVA = "0x29858B0", Offset = "0x29842B0", VA = "0x1829858B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60020C6")]
			[Cpp2IlInjected.Address(RVA = "0x2985AE0", Offset = "0x29844E0", VA = "0x182985AE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B9")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60020CB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020CC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60020CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020CE")]
			[Cpp2IlInjected.Address(RVA = "0x2985DB0", Offset = "0x29847B0", VA = "0x182985DB0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BB")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60020CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020D0")]
			[Cpp2IlInjected.Address(RVA = "0x2985CD0", Offset = "0x29846D0", VA = "0x182985CD0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BC")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60020D1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020D2")]
			[Cpp2IlInjected.Address(RVA = "0x2985D40", Offset = "0x2984740", VA = "0x182985D40")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BD")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60020D3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020D4")]
			[Cpp2IlInjected.Address(RVA = "0x2985E20", Offset = "0x2984820", VA = "0x182985E20")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BE")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x60020D5")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return scene_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020D6")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				scene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BF")]
		[DebuggerNonUserCode]
		public int UnlockWith
		{
			[Cpp2IlInjected.Token(Token = "0x60020D7")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return unlockWith_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020D8")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				unlockWith_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C0")]
		[DebuggerNonUserCode]
		public int UnlockAtLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60020D9")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return unlockAtLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020DA")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				unlockAtLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C1")]
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyCost> UnlockCost
		{
			[Cpp2IlInjected.Token(Token = "0x60020DB")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return unlockCost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C2")]
		[DebuggerNonUserCode]
		public int ManaCost
		{
			[Cpp2IlInjected.Token(Token = "0x60020DC")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "28")]
			get
			{
				return manaCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020DD")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				manaCost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C3")]
		[DebuggerNonUserCode]
		public string UnlockDialogueAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60020DE")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060", Slot = "29")]
			get
			{
				return unlockDialogueAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020DF")]
			[Cpp2IlInjected.Address(RVA = "0x2985E90", Offset = "0x2984890", VA = "0x182985E90")]
			set
			{
				string text = (unlockDialogueAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C4")]
		[DebuggerNonUserCode]
		public RepeatedField<UpgradeData> UpgradeInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60020E0")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "30")]
			get
			{
				return upgradeInfo_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C5")]
		[DebuggerNonUserCode]
		public string DefaultGridLayoutTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x60020E1")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "31")]
			get
			{
				return defaultGridLayoutTypeName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020E2")]
			[Cpp2IlInjected.Address(RVA = "0x2985C60", Offset = "0x2984660", VA = "0x182985C60")]
			set
			{
				string text = (defaultGridLayoutTypeName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C6")]
		[DebuggerNonUserCode]
		public string DefaultGridLayoutPath
		{
			[Cpp2IlInjected.Token(Token = "0x60020E3")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "32")]
			get
			{
				return defaultGridLayoutPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020E4")]
			[Cpp2IlInjected.Address(RVA = "0x2985BF0", Offset = "0x29845F0", VA = "0x182985BF0")]
			set
			{
				string text = (defaultGridLayoutPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C7")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60020E5")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020E6")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C8")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60020F2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "23")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C9")]
		public Item SceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x60020F3")]
			[Cpp2IlInjected.Address(RVA = "0x2985A20", Offset = "0x2984420", VA = "0x182985A20")]
			get
			{
				long num = Convert.ToInt64((uint)scene_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CA")]
		public Item UnlockWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60020F4")]
			[Cpp2IlInjected.Address(RVA = "0x2985A80", Offset = "0x2984480", VA = "0x182985A80", Slot = "24")]
			get
			{
				long num = Convert.ToInt64((uint)unlockWith_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CB")]
		public int UnlockAtPlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60020F5")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "25")]
			get
			{
				return unlockAtLevel_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CC")]
		public RepeatedField<CurrencyCost> UnlockCurrencyCost
		{
			[Cpp2IlInjected.Token(Token = "0x60020F6")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "27")]
			get
			{
				return unlockCost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CD")]
		public string LockedPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60020F7")]
			[Cpp2IlInjected.Address(RVA = "0x2985980", Offset = "0x2984380", VA = "0x182985980", Slot = "26")]
			get
			{
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CE")]
		public RepeatedField<UpgradeData> UpgradeBuildingInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60020F8")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return upgradeInfo_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020C7")]
		[Cpp2IlInjected.Address(RVA = "0x29856F0", Offset = "0x29840F0", VA = "0x1829856F0")]
		[DebuggerNonUserCode]
		public OffGridBuildingItemData()
		{
			name_ = "";
			displayName_ = "";
			iconAddress_ = "";
			prefabAddress_ = "";
			unlockCost_ = (RepeatedField<CurrencyCost>)(object)new RepeatedField<T>();
			unlockDialogueAddress_ = "";
			upgradeInfo_ = (RepeatedField<UpgradeData>)(object)new RepeatedField<T>();
			defaultGridLayoutTypeName_ = "";
			defaultGridLayoutPath_ = "";
			base._002Ector();
			string text = (defaultGridLayoutTypeName_ = ProtoPreconditions.CheckNotNull("Meta.DefaultOffGridBuildingData, Meta", "value"));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020C8")]
		[Cpp2IlInjected.Address(RVA = "0x29849B0", Offset = "0x29833B0", VA = "0x1829849B0")]
		private void OnConstruction()
		{
			string text = (defaultGridLayoutTypeName_ = ProtoPreconditions.CheckNotNull("Meta.DefaultOffGridBuildingData, Meta", "value"));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020C9")]
		[Cpp2IlInjected.Address(RVA = "0x2985590", Offset = "0x2983F90", VA = "0x182985590")]
		[DebuggerNonUserCode]
		public OffGridBuildingItemData(OffGridBuildingItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (scene_ = other.scene_);
			int num3 = (unlockWith_ = other.unlockWith_);
			int num4 = (unlockAtLevel_ = other.unlockAtLevel_);
			RepeatedField<CurrencyCost> repeatedField = (unlockCost_ = (RepeatedField<CurrencyCost>)(object)((RepeatedField<T>)(object)other.unlockCost_).Clone());
			int num5 = (manaCost_ = other.manaCost_);
			string text5 = (unlockDialogueAddress_ = other.unlockDialogueAddress_);
			RepeatedField<UpgradeData> repeatedField2 = (upgradeInfo_ = (RepeatedField<UpgradeData>)(object)((RepeatedField<T>)(object)other.upgradeInfo_).Clone());
			string text6 = (defaultGridLayoutTypeName_ = other.defaultGridLayoutTypeName_);
			string text7 = (defaultGridLayoutPath_ = other.defaultGridLayoutPath_);
			uint num6 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020CA")]
		[Cpp2IlInjected.Address(RVA = "0x2983D40", Offset = "0x2982740", VA = "0x182983D40", Slot = "10")]
		[DebuggerNonUserCode]
		public OffGridBuildingItemData Clone()
		{
			//Discarded unreachable code: IL_0111
			OffGridBuildingItemData offGridBuildingItemData = new OffGridBuildingItemData();
			int num = (offGridBuildingItemData.iD_ = iD_);
			string text = (offGridBuildingItemData.name_ = name_);
			string text2 = (offGridBuildingItemData.displayName_ = displayName_);
			string text3 = (offGridBuildingItemData.iconAddress_ = iconAddress_);
			string text4 = (offGridBuildingItemData.prefabAddress_ = prefabAddress_);
			int num2 = (offGridBuildingItemData.scene_ = scene_);
			int num3 = (offGridBuildingItemData.unlockWith_ = unlockWith_);
			int num4 = (offGridBuildingItemData.unlockAtLevel_ = unlockAtLevel_);
			RepeatedField<CurrencyCost> repeatedField = (offGridBuildingItemData.unlockCost_ = (RepeatedField<CurrencyCost>)(object)((RepeatedField<T>)(object)unlockCost_).Clone());
			int num5 = (offGridBuildingItemData.manaCost_ = manaCost_);
			string text5 = (offGridBuildingItemData.unlockDialogueAddress_ = unlockDialogueAddress_);
			RepeatedField<UpgradeData> repeatedField2 = (offGridBuildingItemData.upgradeInfo_ = (RepeatedField<UpgradeData>)(object)((RepeatedField<T>)(object)upgradeInfo_).Clone());
			string text6 = (offGridBuildingItemData.defaultGridLayoutTypeName_ = defaultGridLayoutTypeName_);
			string text7 = (offGridBuildingItemData.defaultGridLayoutPath_ = defaultGridLayoutPath_);
			uint num6 = (offGridBuildingItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (offGridBuildingItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return offGridBuildingItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60020E7")]
		[Cpp2IlInjected.Address(RVA = "0x2983EE0", Offset = "0x29828E0", VA = "0x182983EE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((OffGridBuildingItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60020E8")]
		[Cpp2IlInjected.Address(RVA = "0x2983F40", Offset = "0x2982940", VA = "0x182983F40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OffGridBuildingItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
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
									int num2 = other.scene_;
									if (scene_ == num2)
									{
										int num3 = other.unlockWith_;
										if (unlockWith_ == num3)
										{
											int num4 = other.unlockAtLevel_;
											if (unlockAtLevel_ == num4)
											{
												RepeatedField<CurrencyCost> repeatedField = unlockCost_;
												RepeatedField<CurrencyCost> repeatedField2 = other.unlockCost_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													int num5 = other.manaCost_;
													if (manaCost_ == num5)
													{
														string text5 = other.unlockDialogueAddress_;
														if (!(unlockDialogueAddress_ != text5))
														{
															RepeatedField<UpgradeData> repeatedField3 = upgradeInfo_;
															RepeatedField<UpgradeData> repeatedField4 = other.upgradeInfo_;
															if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
															{
																string text6 = other.defaultGridLayoutTypeName_;
																if (!(defaultGridLayoutTypeName_ != text6))
																{
																	string text7 = other.defaultGridLayoutPath_;
																	if (!(defaultGridLayoutPath_ != text7))
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
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020E9")]
		[Cpp2IlInjected.Address(RVA = "0x29842C0", Offset = "0x2982CC0", VA = "0x1829842C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0121
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
			if (scene_ != 0)
			{
			}
			if (unlockWith_ != 0)
			{
			}
			if (unlockAtLevel_ != 0)
			{
			}
			int hashCode5 = ((RepeatedField<T>)(object)unlockCost_).GetHashCode();
			if (manaCost_ != 0)
			{
			}
			string text5 = unlockDialogueAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)upgradeInfo_).GetHashCode();
			string text6 = defaultGridLayoutTypeName_;
			if (text6.m_stringLength != 0)
			{
				int hashCode8 = text6.GetHashCode();
			}
			string text7 = defaultGridLayoutPath_;
			if (text7.m_stringLength != 0)
			{
				int hashCode9 = text7.GetHashCode();
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode10 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60020EA")]
		[Cpp2IlInjected.Address(RVA = "0x2984F00", Offset = "0x2983900", VA = "0x182984F00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60020EB")]
		[Cpp2IlInjected.Address(RVA = "0x2984F60", Offset = "0x2983960", VA = "0x182984F60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01a9
			if (iD_ != 0)
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
			if (scene_ != 0)
			{
				int value6 = scene_;
				output.WriteInt32(value6);
			}
			if (unlockWith_ != 0)
			{
				int value7 = unlockWith_;
				output.WriteInt32(value7);
			}
			if (unlockAtLevel_ != 0)
			{
				int value8 = unlockAtLevel_;
				output.WriteInt32(value8);
			}
			RepeatedField<CurrencyCost> repeatedField = unlockCost_;
			FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_unlockCost_codec);
			if (manaCost_ != 0)
			{
				int value9 = manaCost_;
				output.WriteInt32(value9);
			}
			if (unlockDialogueAddress_.m_stringLength != 0)
			{
				string value10 = unlockDialogueAddress_;
				output.WriteString(value10);
			}
			RepeatedField<UpgradeData> repeatedField2 = upgradeInfo_;
			FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_upgradeInfo_codec);
			if (defaultGridLayoutTypeName_.m_stringLength != 0)
			{
				string value11 = defaultGridLayoutTypeName_;
				output.WriteString(value11);
			}
			if (defaultGridLayoutPath_.m_stringLength != 0)
			{
				string value12 = defaultGridLayoutPath_;
				output.WriteString(value12);
			}
			if (glotID_ != 0)
			{
				uint value13 = glotID_;
				output.WriteUInt32(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60020EC")]
		[Cpp2IlInjected.Address(RVA = "0x2983730", Offset = "0x2982130", VA = "0x182983730", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_021c
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
			int num8 = scene_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = unlockWith_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = unlockAtLevel_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			RepeatedField<CurrencyCost> repeatedField = unlockCost_;
			FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_unlockCost_codec);
			int num15 = manaCost_;
			num2 += num14;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			string text5 = unlockDialogueAddress_;
			if (text5.m_stringLength != 0)
			{
				int num17 = CodedOutputStream.ComputeStringSize(text5);
				num17++;
				num2 += num17;
			}
			RepeatedField<UpgradeData> repeatedField2 = upgradeInfo_;
			FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
			int num18 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_upgradeInfo_codec);
			string text6 = defaultGridLayoutTypeName_;
			num2 += num18;
			if (text6.m_stringLength != 0)
			{
				int num19 = CodedOutputStream.ComputeStringSize(text6);
				num19++;
				num2 += num19;
			}
			string text7 = defaultGridLayoutPath_;
			if (text7.m_stringLength != 0)
			{
				int num20 = CodedOutputStream.ComputeStringSize(text7);
				num20++;
				num2 += num20;
			}
			uint num21 = glotID_;
			if (num21 != 0)
			{
				int num22 = CodedOutputStream.ComputeUInt32Size(num21);
				num22 += 2;
				num2 += num22;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num23 = unknownFields.CalculateSize();
				num2 += num23;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60020ED")]
		[Cpp2IlInjected.Address(RVA = "0x29844E0", Offset = "0x2982EE0", VA = "0x1829844E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OffGridBuildingItemData other)
		{
			//Discarded unreachable code: IL_0182
			if (other != null)
			{
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
				RepeatedField<CurrencyCost> repeatedField = unlockCost_;
				RepeatedField<CurrencyCost> repeatedField2 = other.unlockCost_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num5 = other.manaCost_;
				if (num5 != 0)
				{
					manaCost_ = num5;
				}
				string text5 = other.unlockDialogueAddress_;
				if (text5.m_stringLength != 0)
				{
					UnlockDialogueAddress = text5;
				}
				RepeatedField<UpgradeData> repeatedField3 = upgradeInfo_;
				RepeatedField<UpgradeData> repeatedField4 = other.upgradeInfo_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				string text6 = other.defaultGridLayoutTypeName_;
				if (text6.m_stringLength != 0)
				{
					DefaultGridLayoutTypeName = text6;
				}
				string text7 = other.defaultGridLayoutPath_;
				if (text7.m_stringLength != 0)
				{
					DefaultGridLayoutPath = text7;
				}
				uint num6 = other.glotID_;
				if (num6 != 0)
				{
					glotID_ = num6;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020EE")]
		[Cpp2IlInjected.Address(RVA = "0x29846A0", Offset = "0x29830A0", VA = "0x1829846A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01bc
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 56)
			{
				if ((int)num > 90)
				{
					if ((int)num > 106)
					{
						if (num == 114)
						{
							string text2 = (DefaultGridLayoutPath = input.ReadString());
						}
						if (num != 7992)
						{
							goto IL_01a5;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					if (num == 98)
					{
						RepeatedField<UpgradeData> repeatedField = upgradeInfo_;
						FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_upgradeInfo_codec);
					}
					if (num != 106)
					{
						goto IL_01a5;
					}
					string text4 = (DefaultGridLayoutTypeName = input.ReadString());
				}
				string text6 = default(string);
				if ((int)num > 74)
				{
					int num3 = default(int);
					if (num == 80)
					{
						num3 = (manaCost_ = input.ReadInt32());
					}
					if (num3 != 90)
					{
						goto IL_01a5;
					}
					text6 = (UnlockDialogueAddress = input.ReadString());
				}
				int num4 = default(int);
				if ((long)text6 == 64)
				{
					num4 = (unlockAtLevel_ = input.ReadInt32());
				}
				if (num4 != 74)
				{
					goto IL_01a5;
				}
				RepeatedField<CurrencyCost> repeatedField2 = unlockCost_;
				FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unlockCost_codec);
			}
			string text10 = default(string);
			if ((int)num > 26)
			{
				int num6 = default(int);
				if ((int)num > 42)
				{
					int num5 = default(int);
					if (num == 48)
					{
						num5 = (scene_ = input.ReadInt32());
					}
					if (num5 != 56)
					{
						goto IL_01a5;
					}
					num6 = (unlockWith_ = input.ReadInt32());
				}
				string text8 = default(string);
				if (num6 == 34)
				{
					text8 = (IconAddress = input.ReadString());
				}
				if ((long)text8 != 42)
				{
					goto IL_01a5;
				}
				text10 = (PrefabAddress = input.ReadString());
			}
			int num7 = default(int);
			if ((long)text10 == 8)
			{
				num7 = (iD_ = input.ReadInt32());
			}
			string text12 = default(string);
			if (num7 == 18)
			{
				text12 = (Name = input.ReadString());
			}
			if ((long)text12 == 26)
			{
				string text14 = (DisplayName = input.ReadString());
			}
			goto IL_01a5;
			IL_01a5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60020EF")]
		[Cpp2IlInjected.Address(RVA = "0x29840F0", Offset = "0x2982AF0", VA = "0x1829840F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 13)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020F0")]
		[Cpp2IlInjected.Address(RVA = "0x2984A40", Offset = "0x2983440", VA = "0x182984A40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_0041, IL_0049, IL_004a, IL_004b, IL_005c, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_005b: Expected I4, but got O
			if (fieldNumber - 1 <= 13)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x60020F1")]
		[Cpp2IlInjected.Address(RVA = "0x2983B40", Offset = "0x2982540", VA = "0x182983B40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_0030
			//IL_0010: Expected I4, but got I8
			//IL_002f: Expected I4, but got I8
			if (fieldNumber - 1 <= 13)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020F9")]
		[Cpp2IlInjected.Address(RVA = "0x2983ED0", Offset = "0x29828D0", VA = "0x182983ED0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			OffGridBuildingItemData offGridBuildingItemData = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020FA")]
		[Cpp2IlInjected.Address(RVA = "0x2985300", Offset = "0x2983D00", VA = "0x182985300")]
		static OffGridBuildingItemData()
		{
			Func<OffGridBuildingItemData> func = default(Func<OffGridBuildingItemData>);
			_parser = (MessageParser<OffGridBuildingItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<CurrencyCost> parser = CurrencyCost._parser;
			uint num = default(uint);
			_parser = (MessageParser<OffGridBuildingItemData>)(object)FieldCodec.ForMessage<CurrencyCost>(num, (MessageParser<>)(object)parser);
			MessageParser<UpgradeData> parser2 = UpgradeData._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<OffGridBuildingItemData>)(object)FieldCodec.ForMessage<UpgradeData>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
