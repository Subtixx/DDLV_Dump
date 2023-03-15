using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002F3")]
	public sealed class GardenItemData : IMessage<GardenItemData>, IMessage, IEquatable<GardenItemData>, IDeepCloneable<GardenItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IGridStateDataProvider, ITutorializable, IGridEditRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x4000DC7")]
		private static readonly MessageParser<GardenItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000DC8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000DC9")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000DCA")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000DCB")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000DCC")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000DCD")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000DCE")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000DCF")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000DD0")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000DD1")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000DD2")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000DD3")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000DD4")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000DD5")]
		public const int NumberOfSlotsFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000DD6")]
		private int numberOfSlots_;

		[Cpp2IlInjected.Token(Token = "0x4000DD7")]
		public const int CropTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000DD8")]
		private CropType cropType_;

		[Cpp2IlInjected.Token(Token = "0x4000DD9")]
		public const int SelfDestructAfterHarvestFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000DDA")]
		private bool selfDestructAfterHarvest_;

		[Cpp2IlInjected.Token(Token = "0x4000DDB")]
		public const int IsTutorialFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000DDC")]
		private bool isTutorial_;

		[Cpp2IlInjected.Token(Token = "0x4000DDD")]
		public const int TutorialDuringFtueFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000DDE")]
		private static readonly FieldCodec<int> _repeated_tutorialDuringFtue_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000DDF")]
		private readonly RepeatedField<int> tutorialDuringFtue_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000DE0")]
		public const int CanTriggerBurningStateFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000DE1")]
		private bool canTriggerBurningState_;

		[Cpp2IlInjected.Token(Token = "0x4000DE2")]
		public const int GridEditRestrictionFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000DE3")]
		private GridEditRestriction gridEditRestriction_;

		[Cpp2IlInjected.Token(Token = "0x4000DE4")]
		public const int ExpiresFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000DE5")]
		private bool expires_;

		[Cpp2IlInjected.Token(Token = "0x4000DE6")]
		public const int ExpirationDurationFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000DE7")]
		private Duration expirationDuration_;

		[Cpp2IlInjected.Token(Token = "0x4000DE8")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000DE9")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x170007A1")]
		[DebuggerNonUserCode]
		public static MessageParser<GardenItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600208A")]
			[Cpp2IlInjected.Address(RVA = "0x2191A10", Offset = "0x2190410", VA = "0x182191A10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600208B")]
			[Cpp2IlInjected.Address(RVA = "0x2191940", Offset = "0x2190340", VA = "0x182191940")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600208C")]
			[Cpp2IlInjected.Address(RVA = "0x2191A70", Offset = "0x2190470", VA = "0x182191A70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A4")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002091")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002092")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A5")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002093")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002094")]
			[Cpp2IlInjected.Address(RVA = "0x2191C70", Offset = "0x2190670", VA = "0x182191C70")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A6")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002095")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002096")]
			[Cpp2IlInjected.Address(RVA = "0x2191B80", Offset = "0x2190580", VA = "0x182191B80")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A7")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002097")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002098")]
			[Cpp2IlInjected.Address(RVA = "0x2191BF0", Offset = "0x21905F0", VA = "0x182191BF0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A8")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002099")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600209A")]
			[Cpp2IlInjected.Address(RVA = "0x2191CE0", Offset = "0x21906E0", VA = "0x182191CE0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A9")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x600209B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x600209C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AA")]
		[DebuggerNonUserCode]
		public int NumberOfSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600209D")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return numberOfSlots_;
			}
			[Cpp2IlInjected.Token(Token = "0x600209E")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				numberOfSlots_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AB")]
		[DebuggerNonUserCode]
		public CropType CropType
		{
			[Cpp2IlInjected.Token(Token = "0x600209F")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return cropType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020A0")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				cropType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AC")]
		[DebuggerNonUserCode]
		public bool SelfDestructAfterHarvest
		{
			[Cpp2IlInjected.Token(Token = "0x60020A1")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return selfDestructAfterHarvest_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020A2")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				selfDestructAfterHarvest_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AD")]
		[DebuggerNonUserCode]
		public bool IsTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x60020A3")]
			[Cpp2IlInjected.Address(RVA = "0xFAD850", Offset = "0xFAC250", VA = "0x180FAD850", Slot = "25")]
			get
			{
				return isTutorial_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020A4")]
			[Cpp2IlInjected.Address(RVA = "0x2191C60", Offset = "0x2190660", VA = "0x182191C60")]
			set
			{
				isTutorial_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AE")]
		[DebuggerNonUserCode]
		public RepeatedField<int> TutorialDuringFtue
		{
			[Cpp2IlInjected.Token(Token = "0x60020A5")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return tutorialDuringFtue_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AF")]
		[DebuggerNonUserCode]
		public bool CanTriggerBurningState
		{
			[Cpp2IlInjected.Token(Token = "0x60020A6")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return canTriggerBurningState_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020A7")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				canTriggerBurningState_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B0")]
		[DebuggerNonUserCode]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60020A8")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "27")]
			get
			{
				return gridEditRestriction_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020A9")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				gridEditRestriction_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B1")]
		[DebuggerNonUserCode]
		public bool Expires
		{
			[Cpp2IlInjected.Token(Token = "0x60020AA")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return expires_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020AB")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set
			{
				expires_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B2")]
		[DebuggerNonUserCode]
		public Duration ExpirationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x60020AC")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return expirationDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020AD")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				expirationDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B3")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60020AE")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60020AF")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B4")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60020BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B5")]
		public IEnumerable<int> IsTutorialDuringFtueEvents
		{
			[Cpp2IlInjected.Token(Token = "0x60020BC")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "26")]
			get
			{
				RepeatedField<int> repeatedField = tutorialDuringFtue_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600208D")]
		[Cpp2IlInjected.Address(RVA = "0x2191580", Offset = "0x218FF80", VA = "0x182191580")]
		[DebuggerNonUserCode]
		public GardenItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600208E")]
		[Cpp2IlInjected.Address(RVA = "0x2190AE0", Offset = "0x218F4E0", VA = "0x182190AE0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600208F")]
		[Cpp2IlInjected.Address(RVA = "0x21916A0", Offset = "0x21900A0", VA = "0x1821916A0")]
		[DebuggerNonUserCode]
		public GardenItemData(GardenItemData other)
		{
			//IL_00b9: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			int num2 = 0;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			gridAreaData_ = (GridAreaData)num2;
			int num3 = (numberOfSlots_ = other.numberOfSlots_);
			CropType cropType = (cropType_ = other.cropType_);
			bool flag = (selfDestructAfterHarvest_ = other.selfDestructAfterHarvest_);
			bool flag2 = (isTutorial_ = other.isTutorial_);
			RepeatedField<int> repeatedField = (tutorialDuringFtue_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tutorialDuringFtue_).Clone());
			bool flag3 = (canTriggerBurningState_ = other.canTriggerBurningState_);
			GridEditRestriction gridEditRestriction = other.gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				GridEditRestriction gridEditRestriction2 = gridEditRestriction.Clone();
			}
			gridEditRestriction_ = (GridEditRestriction)num2;
			bool flag4 = (expires_ = other.expires_);
			Duration duration = other.expirationDuration_;
			Duration duration2 = default(Duration);
			if (duration != null)
			{
				duration2 = duration.Clone();
			}
			expirationDuration_ = duration2;
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002090")]
		[Cpp2IlInjected.Address(RVA = "0x218FC80", Offset = "0x218E680", VA = "0x18218FC80", Slot = "10")]
		[DebuggerNonUserCode]
		public GardenItemData Clone()
		{
			return new GardenItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60020B0")]
		[Cpp2IlInjected.Address(RVA = "0x218FE40", Offset = "0x218E840", VA = "0x18218FE40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((GardenItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60020B1")]
		[Cpp2IlInjected.Address(RVA = "0x218FEA0", Offset = "0x218E8A0", VA = "0x18218FEA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GardenItemData other)
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
										int num2 = other.numberOfSlots_;
										if (numberOfSlots_ == num2)
										{
											CropType cropType = other.cropType_;
											if (cropType_ == cropType)
											{
												bool flag = other.selfDestructAfterHarvest_;
												if (selfDestructAfterHarvest_ == flag)
												{
													bool flag2 = other.isTutorial_;
													if (isTutorial_ == flag2)
													{
														RepeatedField<int> repeatedField = tutorialDuringFtue_;
														RepeatedField<int> repeatedField2 = other.tutorialDuringFtue_;
														if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
														{
															bool flag3 = other.canTriggerBurningState_;
															if (canTriggerBurningState_ == flag3)
															{
																GridEditRestriction objB2 = other.gridEditRestriction_;
																if (object.Equals(gridEditRestriction_, objB2))
																{
																	bool flag4 = other.expires_;
																	if (expires_ == flag4)
																	{
																		Duration objB3 = other.expirationDuration_;
																		if (object.Equals(expirationDuration_, objB3))
																		{
																			uint num3 = other.glotID_;
																			if (glotID_ == num3)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B2")]
		[Cpp2IlInjected.Address(RVA = "0x21902A0", Offset = "0x218ECA0", VA = "0x1821902A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0117
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
			if (numberOfSlots_ != 0)
			{
			}
			if (cropType_ != 0)
			{
			}
			if (selfDestructAfterHarvest_)
			{
			}
			if (isTutorial_)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)tutorialDuringFtue_).GetHashCode();
			if (canTriggerBurningState_)
			{
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int hashCode7 = gridEditRestriction.GetHashCode();
			}
			if (expires_)
			{
			}
			Duration duration = expirationDuration_;
			if (duration != null)
			{
				int hashCode8 = duration.GetHashCode();
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60020B3")]
		[Cpp2IlInjected.Address(RVA = "0x2191060", Offset = "0x218FA60", VA = "0x182191060", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60020B4")]
		[Cpp2IlInjected.Address(RVA = "0x21910C0", Offset = "0x218FAC0", VA = "0x1821910C0", Slot = "6")]
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
			if ((long)gridAreaData_ != 0)
			{
				GridAreaData value6 = gridAreaData_;
				output.WriteMessage(value6);
			}
			if (numberOfSlots_ != 0)
			{
				int value7 = numberOfSlots_;
				output.WriteInt32(value7);
			}
			if (cropType_ != 0)
			{
			}
			if (selfDestructAfterHarvest_)
			{
				bool value8 = selfDestructAfterHarvest_;
				output.WriteBool(value8);
			}
			if (isTutorial_)
			{
				bool value9 = isTutorial_;
				output.WriteBool(value9);
			}
			RepeatedField<int> repeatedField = tutorialDuringFtue_;
			FieldCodec<int> repeated_tutorialDuringFtue_codec = _repeated_tutorialDuringFtue_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tutorialDuringFtue_codec);
			if (canTriggerBurningState_)
			{
				bool value10 = canTriggerBurningState_;
				output.WriteBool(value10);
			}
			if ((long)gridEditRestriction_ != 0)
			{
				GridEditRestriction value11 = gridEditRestriction_;
				output.WriteMessage(value11);
			}
			if (expires_)
			{
				bool value12 = expires_;
				output.WriteBool(value12);
			}
			if ((long)expirationDuration_ != 0)
			{
				Duration value13 = expirationDuration_;
				output.WriteMessage(value13);
			}
			if (glotID_ != 0)
			{
				uint value14 = glotID_;
				output.WriteUInt32(value14);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60020B5")]
		[Cpp2IlInjected.Address(RVA = "0x218F700", Offset = "0x218E100", VA = "0x18218F700", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
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
			int num9 = numberOfSlots_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			CropType cropType = cropType_;
			if (cropType != 0)
			{
				int num11 = CodedOutputStream.ComputeEnumSize((int)cropType);
				num11++;
				num2 += num11;
			}
			RepeatedField<int> repeatedField = tutorialDuringFtue_;
			FieldCodec<int> repeated_tutorialDuringFtue_codec = _repeated_tutorialDuringFtue_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tutorialDuringFtue_codec);
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(gridEditRestriction);
				num13++;
				repeatedField = (RepeatedField<int>)(repeatedField + num13);
			}
			Duration duration = expirationDuration_;
			if (duration != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(duration);
				num14++;
				repeatedField = (RepeatedField<int>)(repeatedField + num14);
			}
			uint num15 = glotID_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeUInt32Size(num15);
				num16 += 2;
				repeatedField = (RepeatedField<int>)(repeatedField + num16);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<int>)(repeatedField + num17);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B6")]
		[Cpp2IlInjected.Address(RVA = "0x21904D0", Offset = "0x218EED0", VA = "0x1821904D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GardenItemData other)
		{
			//Discarded unreachable code: IL_01f9
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
			int num2 = other.numberOfSlots_;
			if (num2 != 0)
			{
				numberOfSlots_ = num2;
			}
			CropType cropType = other.cropType_;
			if (cropType != 0)
			{
				cropType_ = cropType;
			}
			bool flag = other.selfDestructAfterHarvest_;
			if (flag)
			{
				selfDestructAfterHarvest_ = flag;
			}
			bool flag2 = other.isTutorial_;
			if (flag2)
			{
				isTutorial_ = flag2;
			}
			RepeatedField<int> repeatedField = tutorialDuringFtue_;
			RepeatedField<int> repeatedField2 = other.tutorialDuringFtue_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			bool flag3 = other.canTriggerBurningState_;
			if (flag3)
			{
				canTriggerBurningState_ = flag3;
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
			bool flag4 = other.expires_;
			if (flag4)
			{
				expires_ = flag4;
			}
			if ((long)other.expirationDuration_ != 0)
			{
				Duration duration2 = default(Duration);
				if (expirationDuration_ == null)
				{
					Duration duration = (expirationDuration_ = new Duration());
					duration2 = expirationDuration_;
				}
				Duration other4 = other.expirationDuration_;
				duration2.MergeFrom(other4);
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60020B7")]
		[Cpp2IlInjected.Address(RVA = "0x2190750", Offset = "0x218F150", VA = "0x182190750", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0227
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 64)
			{
				if ((int)num > 90)
				{
					if ((int)num > 106)
					{
						if (num == 112)
						{
							bool flag = (expires_ = input.ReadBool());
						}
						Duration duration = default(Duration);
						if (num == 122)
						{
							Duration builder = default(Duration);
							if (expirationDuration_ == null)
							{
								duration = (expirationDuration_ = new Duration());
								builder = expirationDuration_;
							}
							input.ReadMessage(builder);
						}
						if ((long)duration != 7992)
						{
							goto IL_0210;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					bool flag2 = default(bool);
					if (num == 96)
					{
						flag2 = (canTriggerBurningState_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0210;
					}
					GridEditRestriction builder2 = default(GridEditRestriction);
					if (gridEditRestriction_ == null)
					{
						GridEditRestriction gridEditRestriction = (gridEditRestriction_ = new GridEditRestriction());
						builder2 = gridEditRestriction_;
					}
					input.ReadMessage(builder2);
				}
				if ((int)num > 80)
				{
					num += 4294967208u;
					if (num != 4294967293u)
					{
						goto IL_0210;
					}
					RepeatedField<int> repeatedField = tutorialDuringFtue_;
					FieldCodec<int> repeated_tutorialDuringFtue_codec = _repeated_tutorialDuringFtue_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tutorialDuringFtue_codec);
				}
				bool flag3 = default(bool);
				if (num == 72)
				{
					flag3 = (selfDestructAfterHarvest_ = input.ReadBool());
				}
				if (!flag3)
				{
					goto IL_0210;
				}
				bool flag4 = (isTutorial_ = input.ReadBool());
			}
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 34)
			{
				int num4 = default(int);
				if ((int)num > 50)
				{
					int num3 = default(int);
					if (num == 56)
					{
						num3 = (numberOfSlots_ = input.ReadInt32());
					}
					if (num3 != 64)
					{
						goto IL_0210;
					}
					num4 = (int)(cropType_ = (CropType)input.ReadInt32());
				}
				string text2 = default(string);
				if (num4 == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 50)
				{
					goto IL_0210;
				}
				GridAreaData builder3 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder3 = gridAreaData_;
				}
				input.ReadMessage(builder3);
			}
			string text6 = default(string);
			if ((long)gridAreaData > 18)
			{
				string text4 = default(string);
				if ((long)gridAreaData == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_0210;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text6 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0210;
			IL_0210:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60020B8")]
		[Cpp2IlInjected.Address(RVA = "0x2190040", Offset = "0x218EA40", VA = "0x182190040", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 14)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020B9")]
		[Cpp2IlInjected.Address(RVA = "0x2190B40", Offset = "0x218F540", VA = "0x182190B40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_002c, IL_0034, IL_003c, IL_0044, IL_004c, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c, IL_0082
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0063: Expected I4, but got O
			if (fieldNumber - 1 <= 14)
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

		[Cpp2IlInjected.Token(Token = "0x60020BA")]
		[Cpp2IlInjected.Address(RVA = "0x218FA60", Offset = "0x218E460", VA = "0x18218FA60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_002f
			//IL_0010: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			if (fieldNumber - 1 <= 14)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020BD")]
		[Cpp2IlInjected.Address(RVA = "0x218FCE0", Offset = "0x218E6E0", VA = "0x18218FCE0")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			GardenData gardenData = new GardenData();
			int num = 0;
			if (numberOfSlots_ > num)
			{
				RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
				GardenData.Types.GardeningSlot gardeningSlot = new GardenData.Types.GardeningSlot();
				Timestamp lastActivity_ = default(Timestamp);
				gardeningSlot.lastActivity_ = lastActivity_;
				((RepeatedField<T>)(object)slots_).Add((T)gardeningSlot);
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020BE")]
		[Cpp2IlInjected.Address(RVA = "0x218FC80", Offset = "0x218E680", VA = "0x18218FC80", Slot = "20")]
		IItemData IItemData.Clone()
		{
			GardenItemData gardenItemData = new GardenItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020BF")]
		[Cpp2IlInjected.Address(RVA = "0x2191440", Offset = "0x218FE40", VA = "0x182191440")]
		static GardenItemData()
		{
			Func<GardenItemData> func = default(Func<GardenItemData>);
			_parser = (MessageParser<GardenItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<GardenItemData>)(object)FieldCodec.ForInt32(90u);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020C0")]
		[Cpp2IlInjected.Address(RVA = "0x218FCE0", Offset = "0x218E6E0", VA = "0x18218FCE0", Slot = "24")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			GardenData gardenData = new GardenData();
			int num = 0;
			if (numberOfSlots_ > num)
			{
				RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
				GardenData.Types.GardeningSlot gardeningSlot = new GardenData.Types.GardeningSlot();
				Timestamp lastActivity_ = default(Timestamp);
				gardeningSlot.lastActivity_ = lastActivity_;
				((RepeatedField<T>)(object)slots_).Add((T)gardeningSlot);
				num++;
			}
			throw new NullReferenceException();
		}
	}
}
