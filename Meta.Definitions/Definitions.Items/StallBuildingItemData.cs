using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002F1")]
	public sealed class StallBuildingItemData : IMessage<StallBuildingItemData>, IMessage, IEquatable<StallBuildingItemData>, IDeepCloneable<StallBuildingItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IGridStateDataProvider, IBuildingUnlockable, IBuildingUpgradable, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000D9D")]
		private static readonly MessageParser<StallBuildingItemData> _parser = (MessageParser<StallBuildingItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new StallBuildingItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D9E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D9F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000DA0")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000DA1")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000DA2")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4000DA3")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000DA4")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4000DA5")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000DA6")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000DA7")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000DA8")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000DA9")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000DAA")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000DAB")]
		public const int EmployeeItemIDsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4000DAC")]
		private static readonly FieldCodec<int> _repeated_employeeItemIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000DAD")]
		private readonly RepeatedField<int> employeeItemIDs_;

		[Cpp2IlInjected.Token(Token = "0x4000DAE")]
		public const int ShopDataFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000DAF")]
		private string shopData_;

		[Cpp2IlInjected.Token(Token = "0x4000DB0")]
		public const int SlotLootTableItemIDFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000DB1")]
		private static readonly FieldCodec<int> _repeated_slotLootTableItemID_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000DB2")]
		private readonly RepeatedField<int> slotLootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000DB3")]
		public const int UnlockWithFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000DB4")]
		private int unlockWith_;

		[Cpp2IlInjected.Token(Token = "0x4000DB5")]
		public const int UnlockAtLevelFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000DB6")]
		private int unlockAtLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000DB7")]
		public const int UnlockCostFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4000DB8")]
		private static readonly FieldCodec<CurrencyCost> _repeated_unlockCost_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000DB9")]
		private readonly RepeatedField<CurrencyCost> unlockCost_;

		[Cpp2IlInjected.Token(Token = "0x4000DBA")]
		public const int ManaCostFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000DBB")]
		private int manaCost_;

		[Cpp2IlInjected.Token(Token = "0x4000DBC")]
		public const int UnlockDialogueAddressFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000DBD")]
		private string unlockDialogueAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000DBE")]
		public const int UpgradeInfoFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4000DBF")]
		private static readonly FieldCodec<UpgradeData> _repeated_upgradeInfo_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000DC0")]
		private readonly RepeatedField<UpgradeData> upgradeInfo_;

		[Cpp2IlInjected.Token(Token = "0x4000DC1")]
		public const int SceneIdFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000DC2")]
		private SceneType sceneId_;

		[Cpp2IlInjected.Token(Token = "0x4000DC3")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000DC4")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17000787")]
		[DebuggerNonUserCode]
		public static MessageParser<StallBuildingItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600204A")]
			[Cpp2IlInjected.Address(RVA = "0x2630100", Offset = "0x262EB00", VA = "0x182630100")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000788")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600204B")]
			[Cpp2IlInjected.Address(RVA = "0x262FEB0", Offset = "0x262E8B0", VA = "0x18262FEB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000789")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600204C")]
			[Cpp2IlInjected.Address(RVA = "0x26301C0", Offset = "0x262EBC0", VA = "0x1826301C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078A")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002051")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002052")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078B")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002053")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002054")]
			[Cpp2IlInjected.Address(RVA = "0x26303B0", Offset = "0x262EDB0", VA = "0x1826303B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078C")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002055")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002056")]
			[Cpp2IlInjected.Address(RVA = "0x26302D0", Offset = "0x262ECD0", VA = "0x1826302D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078D")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002057")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002058")]
			[Cpp2IlInjected.Address(RVA = "0x2630340", Offset = "0x262ED40", VA = "0x182630340")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078E")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002059")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600205A")]
			[Cpp2IlInjected.Address(RVA = "0x2630420", Offset = "0x262EE20", VA = "0x182630420")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078F")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x600205B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x600205C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000790")]
		[DebuggerNonUserCode]
		public RepeatedField<int> EmployeeItemIDs
		{
			[Cpp2IlInjected.Token(Token = "0x600205D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return employeeItemIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000791")]
		[DebuggerNonUserCode]
		public string ShopData
		{
			[Cpp2IlInjected.Token(Token = "0x600205E")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return shopData_;
			}
			[Cpp2IlInjected.Token(Token = "0x600205F")]
			[Cpp2IlInjected.Address(RVA = "0x2630490", Offset = "0x262EE90", VA = "0x182630490")]
			set
			{
				string text = (shopData_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000792")]
		[DebuggerNonUserCode]
		public RepeatedField<int> SlotLootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002060")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return slotLootTableItemID_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000793")]
		[DebuggerNonUserCode]
		public int UnlockWith
		{
			[Cpp2IlInjected.Token(Token = "0x6002061")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return unlockWith_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002062")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				unlockWith_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000794")]
		[DebuggerNonUserCode]
		public int UnlockAtLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6002063")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30")]
			get
			{
				return unlockAtLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002064")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				unlockAtLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000795")]
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyCost> UnlockCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002065")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return unlockCost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000796")]
		[DebuggerNonUserCode]
		public int ManaCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002066")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "30")]
			get
			{
				return manaCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002067")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				manaCost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000797")]
		[DebuggerNonUserCode]
		public string UnlockDialogueAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002068")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "31")]
			get
			{
				return unlockDialogueAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002069")]
			[Cpp2IlInjected.Address(RVA = "0x2630500", Offset = "0x262EF00", VA = "0x182630500")]
			set
			{
				string text = (unlockDialogueAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000798")]
		[DebuggerNonUserCode]
		public RepeatedField<UpgradeData> UpgradeInfo
		{
			[Cpp2IlInjected.Token(Token = "0x600206A")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80", Slot = "32")]
			get
			{
				return upgradeInfo_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000799")]
		[DebuggerNonUserCode]
		public SceneType SceneId
		{
			[Cpp2IlInjected.Token(Token = "0x600206B")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return sceneId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600206C")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			set
			{
				sceneId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079A")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x600206D")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600206E")]
			[Cpp2IlInjected.Address(RVA = "0x125C200", Offset = "0x125AC00", VA = "0x18125C200", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600207A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079C")]
		public Item[] EmployeeItems
		{
			[Cpp2IlInjected.Token(Token = "0x600207C")]
			[Cpp2IlInjected.Address(RVA = "0x262FF80", Offset = "0x262E980", VA = "0x18262FF80")]
			get
			{
				RepeatedField<int> repeatedField = employeeItemIDs_;
				Func<int, Item> _003C_003E9__112_ = _003C_003Ec._003C_003E9__112_0;
				if (_003C_003E9__112_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__112_).ToArray<Item>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079D")]
		public Item UnlockWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600207D")]
			[Cpp2IlInjected.Address(RVA = "0x2630160", Offset = "0x262EB60", VA = "0x182630160", Slot = "26")]
			get
			{
				long num = Convert.ToInt64((uint)unlockWith_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079E")]
		public int UnlockAtPlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600207E")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "27")]
			get
			{
				return unlockAtLevel_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079F")]
		public string LockedPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600207F")]
			[Cpp2IlInjected.Address(RVA = "0x26300C0", Offset = "0x262EAC0", VA = "0x1826300C0", Slot = "28")]
			get
			{
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A0")]
		public RepeatedField<CurrencyCost> UnlockCurrencyCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002080")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "29")]
			get
			{
				return unlockCost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600204D")]
		[Cpp2IlInjected.Address(RVA = "0x262FAD0", Offset = "0x262E4D0", VA = "0x18262FAD0")]
		[DebuggerNonUserCode]
		public StallBuildingItemData()
		{
			name_ = "";
			displayName_ = "";
			iconAddress_ = "";
			prefabAddress_ = "";
			employeeItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			shopData_ = "";
			slotLootTableItemID_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			unlockCost_ = (RepeatedField<CurrencyCost>)(object)new RepeatedField<T>();
			unlockDialogueAddress_ = "";
			upgradeInfo_ = (RepeatedField<UpgradeData>)(object)new RepeatedField<T>();
			base._002Ector();
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600204E")]
		[Cpp2IlInjected.Address(RVA = "0x262EC60", Offset = "0x262D660", VA = "0x18262EC60")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600204F")]
		[Cpp2IlInjected.Address(RVA = "0x262FCD0", Offset = "0x262E6D0", VA = "0x18262FCD0")]
		[DebuggerNonUserCode]
		public StallBuildingItemData(StallBuildingItemData other)
		{
			//IL_0069: Expected O, but got I4
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData = other.gridAreaData_;
			if (gridAreaData != null)
			{
				GridAreaData gridAreaData2 = gridAreaData.Clone();
			}
			int num2 = 0;
			gridAreaData_ = (GridAreaData)num2;
			RepeatedField<int> repeatedField = (employeeItemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.employeeItemIDs_).Clone());
			string text5 = (shopData_ = other.shopData_);
			RepeatedField<int> repeatedField2 = (slotLootTableItemID_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.slotLootTableItemID_).Clone());
			int num3 = (unlockWith_ = other.unlockWith_);
			int num4 = (unlockAtLevel_ = other.unlockAtLevel_);
			RepeatedField<CurrencyCost> repeatedField3 = (unlockCost_ = (RepeatedField<CurrencyCost>)(object)((RepeatedField<T>)(object)other.unlockCost_).Clone());
			int num5 = (manaCost_ = other.manaCost_);
			string text6 = (unlockDialogueAddress_ = other.unlockDialogueAddress_);
			RepeatedField<UpgradeData> repeatedField4 = (upgradeInfo_ = (RepeatedField<UpgradeData>)(object)((RepeatedField<T>)(object)other.upgradeInfo_).Clone());
			SceneType sceneType = (sceneId_ = other.sceneId_);
			uint num6 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002050")]
		[Cpp2IlInjected.Address(RVA = "0x262DAA0", Offset = "0x262C4A0", VA = "0x18262DAA0", Slot = "10")]
		[DebuggerNonUserCode]
		public StallBuildingItemData Clone()
		{
			return new StallBuildingItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600206F")]
		[Cpp2IlInjected.Address(RVA = "0x262DBF0", Offset = "0x262C5F0", VA = "0x18262DBF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((StallBuildingItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002070")]
		[Cpp2IlInjected.Address(RVA = "0x262DC50", Offset = "0x262C650", VA = "0x18262DC50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StallBuildingItemData other)
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
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
									{
										RepeatedField<int> repeatedField = employeeItemIDs_;
										RepeatedField<int> repeatedField2 = other.employeeItemIDs_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											string text5 = other.shopData_;
											if (!(shopData_ != text5))
											{
												RepeatedField<int> repeatedField3 = slotLootTableItemID_;
												RepeatedField<int> repeatedField4 = other.slotLootTableItemID_;
												if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
												{
													int num2 = other.unlockWith_;
													if (unlockWith_ == num2)
													{
														int num3 = other.unlockAtLevel_;
														if (unlockAtLevel_ == num3)
														{
															RepeatedField<CurrencyCost> repeatedField5 = unlockCost_;
															RepeatedField<CurrencyCost> repeatedField6 = other.unlockCost_;
															if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
															{
																int num4 = other.manaCost_;
																if (manaCost_ == num4)
																{
																	string text6 = other.unlockDialogueAddress_;
																	if (!(unlockDialogueAddress_ != text6))
																	{
																		RepeatedField<UpgradeData> repeatedField7 = upgradeInfo_;
																		RepeatedField<UpgradeData> repeatedField8 = other.upgradeInfo_;
																		if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
																		{
																			SceneType sceneType = other.sceneId_;
																			if (sceneId_ == sceneType)
																			{
																				uint num5 = other.glotID_;
																				if (glotID_ == num5)
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
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002071")]
		[Cpp2IlInjected.Address(RVA = "0x262E340", Offset = "0x262CD40", VA = "0x18262E340", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0136
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
			int hashCode6 = ((RepeatedField<T>)(object)employeeItemIDs_).GetHashCode();
			string text5 = shopData_;
			if (text5.m_stringLength != 0)
			{
				int hashCode7 = text5.GetHashCode();
			}
			int hashCode8 = ((RepeatedField<T>)(object)slotLootTableItemID_).GetHashCode();
			if (unlockWith_ != 0)
			{
			}
			if (unlockAtLevel_ != 0)
			{
			}
			int hashCode9 = ((RepeatedField<T>)(object)unlockCost_).GetHashCode();
			if (manaCost_ != 0)
			{
			}
			string text6 = unlockDialogueAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode10 = text6.GetHashCode();
			}
			int hashCode11 = ((RepeatedField<T>)(object)upgradeInfo_).GetHashCode();
			if (sceneId_ != 0)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode12 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002072")]
		[Cpp2IlInjected.Address(RVA = "0x262F330", Offset = "0x262DD30", VA = "0x18262F330", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002073")]
		[Cpp2IlInjected.Address(RVA = "0x262F390", Offset = "0x262DD90", VA = "0x18262F390", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01c8
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
			if ((long)gridAreaData_ != 0)
			{
				GridAreaData value6 = gridAreaData_;
				output.WriteMessage(value6);
			}
			RepeatedField<int> repeatedField = employeeItemIDs_;
			FieldCodec<int> repeated_employeeItemIDs_codec = _repeated_employeeItemIDs_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_employeeItemIDs_codec);
			if (shopData_.m_stringLength != 0)
			{
				string value7 = shopData_;
				output.WriteString(value7);
			}
			RepeatedField<int> repeatedField2 = slotLootTableItemID_;
			FieldCodec<int> repeated_slotLootTableItemID_codec = _repeated_slotLootTableItemID_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_slotLootTableItemID_codec);
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
			RepeatedField<CurrencyCost> repeatedField3 = unlockCost_;
			FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_unlockCost_codec);
			if (manaCost_ != 0)
			{
				int value10 = manaCost_;
				output.WriteInt32(value10);
			}
			if (unlockDialogueAddress_.m_stringLength != 0)
			{
				string value11 = unlockDialogueAddress_;
				output.WriteString(value11);
			}
			RepeatedField<UpgradeData> repeatedField4 = upgradeInfo_;
			FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_upgradeInfo_codec);
			if (sceneId_ != 0)
			{
			}
			if (glotID_ != 0)
			{
				uint value12 = glotID_;
				output.WriteUInt32(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002074")]
		[Cpp2IlInjected.Address(RVA = "0x262D3C0", Offset = "0x262BDC0", VA = "0x18262D3C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0255
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
			RepeatedField<int> repeatedField = employeeItemIDs_;
			FieldCodec<int> repeated_employeeItemIDs_codec = _repeated_employeeItemIDs_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_employeeItemIDs_codec);
			string text5 = shopData_;
			num2 += num9;
			if (text5.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text5);
				num10++;
				num2 += num10;
			}
			RepeatedField<int> repeatedField2 = slotLootTableItemID_;
			FieldCodec<int> repeated_slotLootTableItemID_codec = _repeated_slotLootTableItemID_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_slotLootTableItemID_codec);
			int num12 = unlockWith_;
			num2 += num11;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			int num14 = unlockAtLevel_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			RepeatedField<CurrencyCost> repeatedField3 = unlockCost_;
			FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_unlockCost_codec);
			int num17 = manaCost_;
			num2 += num16;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			string text6 = unlockDialogueAddress_;
			if (text6.m_stringLength != 0)
			{
				int num19 = CodedOutputStream.ComputeStringSize(text6);
				num19++;
				num2 += num19;
			}
			RepeatedField<UpgradeData> repeatedField4 = upgradeInfo_;
			FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_upgradeInfo_codec);
			SceneType sceneType = sceneId_;
			num2 += num20;
			if (sceneType != 0)
			{
				int num21 = CodedOutputStream.ComputeEnumSize((int)sceneType);
				num21 += 2;
				num2 += num21;
			}
			uint num22 = glotID_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeUInt32Size(num22);
				num23 += 2;
				num2 += num23;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num24 = unknownFields.CalculateSize();
				num2 += num24;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002075")]
		[Cpp2IlInjected.Address(RVA = "0x262E5A0", Offset = "0x262CFA0", VA = "0x18262E5A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StallBuildingItemData other)
		{
			//Discarded unreachable code: IL_01d6
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
			RepeatedField<int> repeatedField = employeeItemIDs_;
			RepeatedField<int> repeatedField2 = other.employeeItemIDs_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			string text5 = other.shopData_;
			if (text5.m_stringLength != 0)
			{
				ShopData = text5;
			}
			RepeatedField<int> repeatedField3 = slotLootTableItemID_;
			RepeatedField<int> repeatedField4 = other.slotLootTableItemID_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			int num2 = other.unlockWith_;
			if (num2 != 0)
			{
				unlockWith_ = num2;
			}
			int num3 = other.unlockAtLevel_;
			if (num3 != 0)
			{
				unlockAtLevel_ = num3;
			}
			RepeatedField<CurrencyCost> repeatedField5 = unlockCost_;
			RepeatedField<CurrencyCost> repeatedField6 = other.unlockCost_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			int num4 = other.manaCost_;
			if (num4 != 0)
			{
				manaCost_ = num4;
			}
			string text6 = other.unlockDialogueAddress_;
			if (text6.m_stringLength != 0)
			{
				UnlockDialogueAddress = text6;
			}
			RepeatedField<UpgradeData> repeatedField7 = upgradeInfo_;
			RepeatedField<UpgradeData> repeatedField8 = other.upgradeInfo_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			SceneType sceneType = other.sceneId_;
			if (sceneType != 0)
			{
				sceneId_ = sceneType;
			}
			uint num5 = other.glotID_;
			if (num5 != 0)
			{
				glotID_ = num5;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002076")]
		[Cpp2IlInjected.Address(RVA = "0x262E810", Offset = "0x262D210", VA = "0x18262E810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0238
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 74)
			{
				if ((int)num > 106)
				{
					if ((int)num > 122)
					{
						if (num == 130)
						{
							RepeatedField<UpgradeData> repeatedField = upgradeInfo_;
							FieldCodec<UpgradeData> repeated_upgradeInfo_codec = _repeated_upgradeInfo_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_upgradeInfo_codec);
						}
						int num2 = default(int);
						if (num == 136)
						{
							num2 = (int)(sceneId_ = (SceneType)input.ReadInt32());
						}
						if (num2 != 7992)
						{
							goto IL_0221;
						}
						int num3 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num4 = default(int);
					if (num == 112)
					{
						num4 = (manaCost_ = input.ReadInt32());
					}
					if (num4 != 122)
					{
						goto IL_0221;
					}
					string text2 = (UnlockDialogueAddress = input.ReadString());
				}
				int num6 = default(int);
				if ((int)num > 82)
				{
					int num5 = default(int);
					if (num == 88)
					{
						num5 = (unlockWith_ = input.ReadInt32());
					}
					if (num5 == 96)
					{
						num6 = (unlockAtLevel_ = input.ReadInt32());
					}
					if (num6 != 106)
					{
						goto IL_0221;
					}
					RepeatedField<CurrencyCost> repeatedField2 = unlockCost_;
					FieldCodec<CurrencyCost> repeated_unlockCost_codec = _repeated_unlockCost_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unlockCost_codec);
				}
				num6 += -80;
				if (num6 != -3)
				{
					goto IL_0221;
				}
				RepeatedField<int> repeatedField3 = slotLootTableItemID_;
				FieldCodec<int> repeated_slotLootTableItemID_codec = _repeated_slotLootTableItemID_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slotLootTableItemID_codec);
			}
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 34)
			{
				string text4 = default(string);
				if ((int)num > 50)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 74)
						{
							goto IL_0221;
						}
						text4 = (ShopData = input.ReadString());
					}
					RepeatedField<int> repeatedField4 = employeeItemIDs_;
					FieldCodec<int> repeated_employeeItemIDs_codec = _repeated_employeeItemIDs_codec;
					((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_employeeItemIDs_codec);
				}
				string text6 = default(string);
				if ((long)text4 == 42)
				{
					text6 = (PrefabAddress = input.ReadString());
				}
				if ((long)text6 != 50)
				{
					goto IL_0221;
				}
				GridAreaData builder = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder = gridAreaData_;
				}
				input.ReadMessage(builder);
			}
			string text10 = default(string);
			if ((long)gridAreaData > 18)
			{
				string text8 = default(string);
				if ((long)gridAreaData == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				if ((long)text8 != 34)
				{
					goto IL_0221;
				}
				text10 = (IconAddress = input.ReadString());
			}
			int num7 = default(int);
			if ((long)text10 == 8)
			{
				num7 = (iD_ = input.ReadInt32());
			}
			if (num7 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_0221;
			IL_0221:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002077")]
		[Cpp2IlInjected.Address(RVA = "0x262DE60", Offset = "0x262C860", VA = "0x18262DE60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 16)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002078")]
		[Cpp2IlInjected.Address(RVA = "0x262ECC0", Offset = "0x262D6C0", VA = "0x18262ECC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0049, IL_004a, IL_0057, IL_006f, IL_0075, IL_007b, IL_0081, IL_0087, IL_008d
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_006e: Expected I4, but got O
			if (fieldNumber - 1 <= 16)
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

		[Cpp2IlInjected.Token(Token = "0x6002079")]
		[Cpp2IlInjected.Address(RVA = "0x262D880", Offset = "0x262C280", VA = "0x18262D880", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_002f
			//IL_0010: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			if (fieldNumber - 1 <= 16)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600207B")]
		[Cpp2IlInjected.Address(RVA = "0x262F240", Offset = "0x262DC40", VA = "0x18262F240")]
		public Item SlotLootTableItem(int index)
		{
			//Discarded unreachable code: IL_0023
			//IL_001d: Expected I4, but got O
			int count = ((RepeatedField<T>)(object)slotLootTableItemID_).Count;
			if (index < count)
			{
				int num = (int)((RepeatedField<T>)(object)slotLootTableItemID_)[index];
			}
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6002081")]
		[Cpp2IlInjected.Address(RVA = "0x262DAA0", Offset = "0x262C4A0", VA = "0x18262DAA0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			StallBuildingItemData stallBuildingItemData = new StallBuildingItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002082")]
		[Cpp2IlInjected.Address(RVA = "0x262E080", Offset = "0x262CA80", VA = "0x18262E080")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_009c: Expected O, but got I4
			if (((RepeatedField<T>)(object)upgradeInfo_).Count > 0)
			{
				bool flag = this.NeedUnlock();
				int num = 0;
				bool level_ = !flag;
				UpgradeData upgradeData = Enumerable.First<UpgradeData>((IEnumerable<>)(object)upgradeInfo_);
				UpgradeData.BenefitsOneofCase benefitsCase_ = upgradeData.benefitsCase_;
				if (upgradeData != null)
				{
					if (upgradeData != null)
					{
						if (upgradeData == null || benefitsCase_ != (UpgradeData.BenefitsOneofCase)1)
						{
							goto IL_00a7;
						}
						GardenStallData gardenStallData = new GardenStallData();
					}
					StallData stallData = new StallData();
					UpgradeState upgradeState = new UpgradeState();
					upgradeState.level_ = (level_ ? 1 : 0);
					stallData.upgradeState_ = upgradeState;
				}
				FishingStallData fishingStallData = new FishingStallData();
				UpgradeState upgradeState2 = new UpgradeState();
				upgradeState2.level_ = (level_ ? 1 : 0);
				fishingStallData.upgradeState_ = upgradeState2;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				Timestamp timestamp = (fishingStallData.lastCollect_ = ((DateTime)num).ToProto());
			}
			goto IL_00a7;
			IL_00a7:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002083")]
		[Cpp2IlInjected.Address(RVA = "0x262DB00", Offset = "0x262C500", VA = "0x18262DB00", Slot = "33")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003f
			int refValue = 0;
			int value = unlockAtLevel_;
			context.RequireGreaterOrEqual(value, refValue, "UnlockAtLevel");
			this.BuildingUpgradableValidation(context);
			if (((RepeatedField<T>)(object)upgradeInfo_).Count > 0)
			{
				string cpp2il__autoParamName__idx_ = unlockDialogueAddress_;
				context.RequireNotEmpty<char>((IEnumerable<>)(object)cpp2il__autoParamName__idx_, "UnlockDialogueAddress");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002084")]
		[Cpp2IlInjected.Address(RVA = "0x262F7F0", Offset = "0x262E1F0", VA = "0x18262F7F0")]
		static StallBuildingItemData()
		{
			_parser = (MessageParser<StallBuildingItemData>)(object)FieldCodec.ForInt32(58u);
			_parser = (MessageParser<StallBuildingItemData>)(object)FieldCodec.ForInt32(82u);
			MessageParser<CurrencyCost> parser = CurrencyCost._parser;
			uint num = default(uint);
			_parser = (MessageParser<StallBuildingItemData>)(object)FieldCodec.ForMessage<CurrencyCost>(num, (MessageParser<>)(object)parser);
			MessageParser<UpgradeData> parser2 = UpgradeData._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<StallBuildingItemData>)(object)FieldCodec.ForMessage<UpgradeData>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002085")]
		[Cpp2IlInjected.Address(RVA = "0x262DBE0", Offset = "0x262C5E0", VA = "0x18262DBE0", Slot = "24")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			return GetGridStateData(in worldProfile, context);
		}
	}
}
