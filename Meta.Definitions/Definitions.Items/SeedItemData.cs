using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Scene;
using Definitions.Util;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200029D")]
	public sealed class SeedItemData : IMessage<SeedItemData>, IMessage, IEquatable<SeedItemData>, IDeepCloneable<SeedItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, INeedWatering, IIsMissionItem, IHasExtraGiftFriendship, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200029E")]
		public enum MissionRestrictionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000AC1")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000AC2")]
			MissionSeedLocationRestriction = 25
		}

		[Cpp2IlInjected.Token(Token = "0x200029F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002A0")]
			public sealed class RestrictedAreas : IMessage<RestrictedAreas>, IMessage, IEquatable<RestrictedAreas>, IDeepCloneable<RestrictedAreas>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000AC3")]
				private static readonly MessageParser<RestrictedAreas> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000AC4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000AC5")]
				public const int AreasFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000AC6")]
				private static readonly FieldCodec<VillageAreaType> _repeated_areas_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000AC7")]
				private readonly RepeatedField<VillageAreaType> areas_;

				[Cpp2IlInjected.Token(Token = "0x170005B7")]
				[DebuggerNonUserCode]
				public static MessageParser<RestrictedAreas> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001A9A")]
					[Cpp2IlInjected.Address(RVA = "0x2373EA0", Offset = "0x23728A0", VA = "0x182373EA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001A9B")]
					[Cpp2IlInjected.Address(RVA = "0x2373E20", Offset = "0x2372820", VA = "0x182373E20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001A9C")]
					[Cpp2IlInjected.Address(RVA = "0x2373F00", Offset = "0x2372900", VA = "0x182373F00", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005BA")]
				[DebuggerNonUserCode]
				public RepeatedField<VillageAreaType> Areas
				{
					[Cpp2IlInjected.Token(Token = "0x6001AA0")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001A9D")]
				[Cpp2IlInjected.Address(RVA = "0x2373DA0", Offset = "0x23727A0", VA = "0x182373DA0")]
				[DebuggerNonUserCode]
				public RestrictedAreas()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A9E")]
				[Cpp2IlInjected.Address(RVA = "0x2373D10", Offset = "0x2372710", VA = "0x182373D10")]
				[DebuggerNonUserCode]
				public RestrictedAreas(RestrictedAreas other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A9F")]
				[Cpp2IlInjected.Address(RVA = "0x2373550", Offset = "0x2371F50", VA = "0x182373550", Slot = "10")]
				[DebuggerNonUserCode]
				public RestrictedAreas Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA1")]
				[Cpp2IlInjected.Address(RVA = "0x23736A0", Offset = "0x23720A0", VA = "0x1823736A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA2")]
				[Cpp2IlInjected.Address(RVA = "0x2373610", Offset = "0x2372010", VA = "0x182373610", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(RestrictedAreas other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA3")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA4")]
				[Cpp2IlInjected.Address(RVA = "0x23739D0", Offset = "0x23723D0", VA = "0x1823739D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA5")]
				[Cpp2IlInjected.Address(RVA = "0x2373A30", Offset = "0x2372430", VA = "0x182373A30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA6")]
				[Cpp2IlInjected.Address(RVA = "0x2373440", Offset = "0x2371E40", VA = "0x182373440", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA7")]
				[Cpp2IlInjected.Address(RVA = "0x2373800", Offset = "0x2372200", VA = "0x182373800", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(RestrictedAreas other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA8")]
				[Cpp2IlInjected.Address(RVA = "0x2373880", Offset = "0x2372280", VA = "0x182373880", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001AA9")]
				[Cpp2IlInjected.Address(RVA = "0x2373780", Offset = "0x2372180", VA = "0x182373780", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001AAA")]
				[Cpp2IlInjected.Address(RVA = "0x2373970", Offset = "0x2372370", VA = "0x182373970", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001AAB")]
				[Cpp2IlInjected.Address(RVA = "0x23734F0", Offset = "0x2371EF0", VA = "0x1823734F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000A83")]
		private static readonly MessageParser<SeedItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A84")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000A85")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A86")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000A87")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A88")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4000A89")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A8A")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4000A8B")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A8C")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000A8D")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000A8E")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000A8F")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000A90")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000A91")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000A92")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x4000A93")]
		public const int SaplingPrefabAddressFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000A94")]
		private string saplingPrefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000A95")]
		public const int GrowthPeriodFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000A96")]
		private Duration growthPeriod_;

		[Cpp2IlInjected.Token(Token = "0x4000A97")]
		public const int NumberOfWateringRequiredFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000A98")]
		private int numberOfWateringRequired_;

		[Cpp2IlInjected.Token(Token = "0x4000A99")]
		public const int NoGrowthBuffFieldNumber = 33;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000A9A")]
		private bool noGrowthBuff_;

		[Cpp2IlInjected.Token(Token = "0x4000A9B")]
		public const int HarvestPrefabAddressFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000A9C")]
		private string harvestPrefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000A9D")]
		public const int ProducesItemFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000A9E")]
		private bool producesItem_;

		[Cpp2IlInjected.Token(Token = "0x4000A9F")]
		public const int ProducedItemIDFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000AA0")]
		private int producedItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000AA1")]
		public const int ProducedAmountFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000AA2")]
		private int producedAmount_;

		[Cpp2IlInjected.Token(Token = "0x4000AA3")]
		public const int ProductionPeriodFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000AA4")]
		private Duration productionPeriod_;

		[Cpp2IlInjected.Token(Token = "0x4000AA5")]
		public const int NumberOfGrowthPeriodsFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000AA6")]
		private int numberOfGrowthPeriods_;

		[Cpp2IlInjected.Token(Token = "0x4000AA7")]
		public const int SelfDestructAfterAllGrowthPeriodsFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000AA8")]
		private bool selfDestructAfterAllGrowthPeriods_;

		[Cpp2IlInjected.Token(Token = "0x4000AA9")]
		public const int BurningStateVFXPrefabAddressFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000AAA")]
		private string burningStateVFXPrefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000AAB")]
		public const int BurningStateCollectVFXPrefabAddressFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000AAC")]
		private string burningStateCollectVFXPrefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000AAD")]
		public const int HasGrowthBoostFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000AAE")]
		private bool hasGrowthBoost_;

		[Cpp2IlInjected.Token(Token = "0x4000AAF")]
		public const int VillageAreaFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000AB0")]
		private VillageAreaType villageArea_;

		[Cpp2IlInjected.Token(Token = "0x4000AB1")]
		public const int MinimumStallLevelFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000AB2")]
		private int minimumStallLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000AB3")]
		public const int IsMissionItemFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000AB4")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000AB5")]
		public const int UnsellableFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x4000AB6")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4000AB7")]
		public const int MissionSeedLocationRestrictionFieldNumber = 25;

		[Cpp2IlInjected.Token(Token = "0x4000AB8")]
		public const int MissionSeedBlockHarvestFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAE")]
		[Cpp2IlInjected.Token(Token = "0x4000AB9")]
		private bool missionSeedBlockHarvest_;

		[Cpp2IlInjected.Token(Token = "0x4000ABA")]
		public const int ExtraGiftFriendshipFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000ABB")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4000ABC")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000ABD")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000ABE")]
		private object missionRestriction_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000ABF")]
		private MissionRestrictionOneofCase missionRestrictionCase_;

		[Cpp2IlInjected.Token(Token = "0x1700058F")]
		[DebuggerNonUserCode]
		public static MessageParser<SeedItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001A3B")]
			[Cpp2IlInjected.Address(RVA = "0x38477E0", Offset = "0x38461E0", VA = "0x1838477E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000590")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001A3C")]
			[Cpp2IlInjected.Address(RVA = "0x3847640", Offset = "0x3846040", VA = "0x183847640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000591")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001A3D")]
			[Cpp2IlInjected.Address(RVA = "0x38478D0", Offset = "0x38462D0", VA = "0x1838478D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000592")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001A42")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A43")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000593")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001A44")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A45")]
			[Cpp2IlInjected.Address(RVA = "0x3847CD0", Offset = "0x38466D0", VA = "0x183847CD0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000594")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001A46")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "26")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A47")]
			[Cpp2IlInjected.Address(RVA = "0x3847B30", Offset = "0x3846530", VA = "0x183847B30")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000595")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A48")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A49")]
			[Cpp2IlInjected.Address(RVA = "0x3847C10", Offset = "0x3846610", VA = "0x183847C10")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000596")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A4A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A4B")]
			[Cpp2IlInjected.Address(RVA = "0x3847D40", Offset = "0x3846740", VA = "0x183847D40")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000597")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001A4C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "29")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A4D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000598")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001A4E")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "27")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A4F")]
			[Cpp2IlInjected.Address(RVA = "0x3847AC0", Offset = "0x38464C0", VA = "0x183847AC0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000599")]
		[DebuggerNonUserCode]
		public string SaplingPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A50")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return saplingPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A51")]
			[Cpp2IlInjected.Address(RVA = "0x3847DB0", Offset = "0x38467B0", VA = "0x183847DB0")]
			set
			{
				string text = (saplingPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059A")]
		[DebuggerNonUserCode]
		public Duration GrowthPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6001A52")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return growthPeriod_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A53")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				growthPeriod_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059B")]
		[DebuggerNonUserCode]
		public int NumberOfWateringRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6001A54")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return numberOfWateringRequired_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A55")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				numberOfWateringRequired_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059C")]
		[DebuggerNonUserCode]
		public bool NoGrowthBuff
		{
			[Cpp2IlInjected.Token(Token = "0x6001A56")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get
			{
				return noGrowthBuff_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A57")]
			[Cpp2IlInjected.Address(RVA = "0xD2B640", Offset = "0xD2A040", VA = "0x180D2B640")]
			set
			{
				noGrowthBuff_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059D")]
		[DebuggerNonUserCode]
		public string HarvestPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A58")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return harvestPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A59")]
			[Cpp2IlInjected.Address(RVA = "0x3847BA0", Offset = "0x38465A0", VA = "0x183847BA0")]
			set
			{
				string text = (harvestPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059E")]
		[DebuggerNonUserCode]
		public bool ProducesItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001A5A")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return producesItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A5B")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set
			{
				producesItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059F")]
		[DebuggerNonUserCode]
		public int ProducedItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001A5C")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040")]
			get
			{
				return producedItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A5D")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set
			{
				producedItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A0")]
		[DebuggerNonUserCode]
		public int ProducedAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6001A5E")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return producedAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A5F")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				producedAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A1")]
		[DebuggerNonUserCode]
		public Duration ProductionPeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6001A60")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return productionPeriod_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A61")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A2")]
		[DebuggerNonUserCode]
		public int NumberOfGrowthPeriods
		{
			[Cpp2IlInjected.Token(Token = "0x6001A62")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return numberOfGrowthPeriods_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A63")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			set
			{
				numberOfGrowthPeriods_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A3")]
		[DebuggerNonUserCode]
		public bool SelfDestructAfterAllGrowthPeriods
		{
			[Cpp2IlInjected.Token(Token = "0x6001A64")]
			[Cpp2IlInjected.Address(RVA = "0xEFF390", Offset = "0xEFDD90", VA = "0x180EFF390")]
			get
			{
				return selfDestructAfterAllGrowthPeriods_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A65")]
			[Cpp2IlInjected.Address(RVA = "0xEFF460", Offset = "0xEFDE60", VA = "0x180EFF460")]
			set
			{
				selfDestructAfterAllGrowthPeriods_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A4")]
		[DebuggerNonUserCode]
		public string BurningStateVFXPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A66")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return burningStateVFXPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A67")]
			[Cpp2IlInjected.Address(RVA = "0x3847A50", Offset = "0x3846450", VA = "0x183847A50")]
			set
			{
				string text = (burningStateVFXPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A5")]
		[DebuggerNonUserCode]
		public string BurningStateCollectVFXPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A68")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return burningStateCollectVFXPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A69")]
			[Cpp2IlInjected.Address(RVA = "0x38479E0", Offset = "0x38463E0", VA = "0x1838479E0")]
			set
			{
				string text = (burningStateCollectVFXPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A6")]
		[DebuggerNonUserCode]
		public bool HasGrowthBoost
		{
			[Cpp2IlInjected.Token(Token = "0x6001A6A")]
			[Cpp2IlInjected.Address(RVA = "0x1603120", Offset = "0x1601B20", VA = "0x181603120")]
			get
			{
				return hasGrowthBoost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A6B")]
			[Cpp2IlInjected.Address(RVA = "0x1552740", Offset = "0x1551140", VA = "0x181552740")]
			set
			{
				hasGrowthBoost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A7")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6001A6C")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7C0", Offset = "0xF391C0", VA = "0x180F3A7C0")]
			get
			{
				return villageArea_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A6D")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7D0", Offset = "0xF391D0", VA = "0x180F3A7D0")]
			set
			{
				villageArea_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A8")]
		[DebuggerNonUserCode]
		public int MinimumStallLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6001A6E")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840")]
			get
			{
				return minimumStallLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A6F")]
			[Cpp2IlInjected.Address(RVA = "0xF64F60", Offset = "0xF63960", VA = "0x180F64F60")]
			set
			{
				minimumStallLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A9")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001A70")]
			[Cpp2IlInjected.Address(RVA = "0x1062FC0", Offset = "0x10619C0", VA = "0x181062FC0", Slot = "31")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A71")]
			[Cpp2IlInjected.Address(RVA = "0x3418E00", Offset = "0x3417800", VA = "0x183418E00")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AA")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6001A72")]
			[Cpp2IlInjected.Address(RVA = "0x34189A0", Offset = "0x34173A0", VA = "0x1834189A0")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A73")]
			[Cpp2IlInjected.Address(RVA = "0x3418DE0", Offset = "0x34177E0", VA = "0x183418DE0")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AB")]
		[DebuggerNonUserCode]
		public GridLocationFilter MissionSeedLocationRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6001A74")]
			[Cpp2IlInjected.Address(RVA = "0x3847770", Offset = "0x3846170", VA = "0x183847770")]
			get
			{
				int num = 0;
				if (missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
				{
					object obj = missionRestriction_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001A75")]
			[Cpp2IlInjected.Address(RVA = "0x3847C90", Offset = "0x3846690", VA = "0x183847C90")]
			set
			{
				missionRestriction_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AC")]
		[DebuggerNonUserCode]
		public bool MissionSeedBlockHarvest
		{
			[Cpp2IlInjected.Token(Token = "0x6001A76")]
			[Cpp2IlInjected.Address(RVA = "0x34189B0", Offset = "0x34173B0", VA = "0x1834189B0")]
			get
			{
				return missionSeedBlockHarvest_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A77")]
			[Cpp2IlInjected.Address(RVA = "0x3847C80", Offset = "0x3846680", VA = "0x183847C80")]
			set
			{
				missionSeedBlockHarvest_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AD")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6001A78")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACB0", Offset = "0xA596B0", VA = "0x180A5ACB0", Slot = "32")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A79")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACD0", Offset = "0xA596D0", VA = "0x180A5ACD0")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AE")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001A7A")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACC0", Offset = "0xA596C0", VA = "0x180A5ACC0", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A7B")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACF0", Offset = "0xA596F0", VA = "0x180A5ACF0", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AF")]
		[DebuggerNonUserCode]
		public MissionRestrictionOneofCase MissionRestrictionCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001A7C")]
			[Cpp2IlInjected.Address(RVA = "0x148A150", Offset = "0x1488B50", VA = "0x18148A150")]
			get
			{
				return missionRestrictionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B0")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001A8B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B1")]
		public Item ProducedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001A8C")]
			[Cpp2IlInjected.Address(RVA = "0x3847840", Offset = "0x3846240", VA = "0x183847840")]
			get
			{
				if (producesItem_)
				{
					int num = producedItemID_;
				}
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B2")]
		public bool NeedWatering
		{
			[Cpp2IlInjected.Token(Token = "0x6001A8D")]
			[Cpp2IlInjected.Address(RVA = "0x38477D0", Offset = "0x38461D0", VA = "0x1838477D0", Slot = "30")]
			get
			{
				return numberOfWateringRequired_ > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B3")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001A8E")]
			[Cpp2IlInjected.Address(RVA = "0x3847630", Offset = "0x3846030", VA = "0x183847630", Slot = "28")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B4")]
		public SeedType SeedType
		{
			[Cpp2IlInjected.Token(Token = "0x6001A94")]
			[Cpp2IlInjected.Address(RVA = "0x38478B0", Offset = "0x38462B0", VA = "0x1838478B0")]
			get
			{
				int num;
				do
				{
					num = 0;
				}
				while (numberOfWateringRequired_ != num);
				bool flag = (selfDestructAfterAllGrowthPeriods_ ? 1 : 0) != num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B5")]
		public bool IsNotRestricted
		{
			[Cpp2IlInjected.Token(Token = "0x6001A95")]
			[Cpp2IlInjected.Address(RVA = "0x3847750", Offset = "0x3846150", VA = "0x183847750")]
			get
			{
				if (!isMissionItem_)
				{
					return true;
				}
				return missionRestrictionCase_ == MissionRestrictionOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B6")]
		public bool IsLocationRestricted
		{
			[Cpp2IlInjected.Token(Token = "0x6001A96")]
			[Cpp2IlInjected.Address(RVA = "0x3847710", Offset = "0x3846110", VA = "0x183847710")]
			get
			{
				if (isMissionItem_ && missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
				{
					GridLocationFilter missionSeedLocationRestriction = MissionSeedLocationRestriction;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3E")]
		[Cpp2IlInjected.Address(RVA = "0x38471E0", Offset = "0x3845BE0", VA = "0x1838471E0")]
		[DebuggerNonUserCode]
		public SeedItemData()
		{
			//Discarded unreachable code: IL_00a1
			name_ = "";
			displayName_ = "";
			iconAddress_ = "";
			prefabAddress_ = "";
			description_ = "";
			saplingPrefabAddress_ = "";
			harvestPrefabAddress_ = "";
			burningStateVFXPrefabAddress_ = "";
			burningStateCollectVFXPrefabAddress_ = "";
			base._002Ector();
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			Duration duration = (growthPeriod_ = new Duration());
			Duration duration2 = (productionPeriod_ = new Duration());
			gridAreaData_.AcceptedFloorTypesFlag = 5375;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3F")]
		[Cpp2IlInjected.Address(RVA = "0x3846030", Offset = "0x3844A30", VA = "0x183846030")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_0038
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			Duration duration = (growthPeriod_ = new Duration());
			Duration duration2 = (productionPeriod_ = new Duration());
			gridAreaData_.AcceptedFloorTypesFlag = 5375;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A40")]
		[Cpp2IlInjected.Address(RVA = "0x38473A0", Offset = "0x3845DA0", VA = "0x1838473A0")]
		[DebuggerNonUserCode]
		public SeedItemData(SeedItemData other)
		{
			//IL_0069: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			//IL_0208: Expected I4, but got O
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
			string text5 = (description_ = other.description_);
			string text6 = (saplingPrefabAddress_ = other.saplingPrefabAddress_);
			Duration duration = other.growthPeriod_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			growthPeriod_ = (Duration)num2;
			int num3 = (numberOfWateringRequired_ = other.numberOfWateringRequired_);
			bool flag = (noGrowthBuff_ = other.noGrowthBuff_);
			string text7 = (harvestPrefabAddress_ = other.harvestPrefabAddress_);
			bool flag2 = (producesItem_ = other.producesItem_);
			int num4 = (producedItemID_ = other.producedItemID_);
			int num5 = (producedAmount_ = other.producedAmount_);
			Duration duration3 = other.productionPeriod_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			productionPeriod_ = (Duration)num2;
			int num6 = (numberOfGrowthPeriods_ = other.numberOfGrowthPeriods_);
			bool flag3 = (selfDestructAfterAllGrowthPeriods_ = other.selfDestructAfterAllGrowthPeriods_);
			string text8 = (burningStateVFXPrefabAddress_ = other.burningStateVFXPrefabAddress_);
			string text9 = (burningStateCollectVFXPrefabAddress_ = other.burningStateCollectVFXPrefabAddress_);
			bool flag4 = (hasGrowthBoost_ = other.hasGrowthBoost_);
			VillageAreaType villageAreaType = (villageArea_ = other.villageArea_);
			int num7 = (minimumStallLevel_ = other.minimumStallLevel_);
			bool flag5 = (isMissionItem_ = other.isMissionItem_);
			bool flag6 = (unsellable_ = other.unsellable_);
			bool flag7 = (missionSeedBlockHarvest_ = other.missionSeedBlockHarvest_);
			int num8 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			uint num9 = (glotID_ = other.glotID_);
			if (other.missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
			{
				if (other.missionRestriction_ == null)
				{
					throw new InvalidCastException();
				}
				GridLocationFilter gridLocationFilter = default(GridLocationFilter);
				missionRestriction_ = gridLocationFilter;
				missionRestrictionCase_ = (MissionRestrictionOneofCase)gridLocationFilter;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A41")]
		[Cpp2IlInjected.Address(RVA = "0x3844400", Offset = "0x3842E00", VA = "0x183844400", Slot = "10")]
		[DebuggerNonUserCode]
		public SeedItemData Clone()
		{
			return new SeedItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7D")]
		[Cpp2IlInjected.Address(RVA = "0x3844370", Offset = "0x3842D70", VA = "0x183844370")]
		[DebuggerNonUserCode]
		public void ClearMissionRestriction()
		{
			//IL_0010: Expected O, but got I4
			missionRestriction_ = (missionRestrictionCase_ = MissionRestrictionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7E")]
		[Cpp2IlInjected.Address(RVA = "0x3844670", Offset = "0x3843070", VA = "0x183844670", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((SeedItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7F")]
		[Cpp2IlInjected.Address(RVA = "0x38446D0", Offset = "0x38430D0", VA = "0x1838446D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SeedItemData other)
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
										string text5 = other.description_;
										if (!(description_ != text5))
										{
											string text6 = other.saplingPrefabAddress_;
											if (!(saplingPrefabAddress_ != text6))
											{
												Duration objB2 = other.growthPeriod_;
												if (object.Equals(growthPeriod_, objB2))
												{
													int num2 = other.numberOfWateringRequired_;
													if (numberOfWateringRequired_ == num2)
													{
														bool flag = other.noGrowthBuff_;
														if (noGrowthBuff_ == flag)
														{
															string text7 = other.harvestPrefabAddress_;
															if (!(harvestPrefabAddress_ != text7))
															{
																bool flag2 = other.producesItem_;
																if (producesItem_ == flag2)
																{
																	int num3 = other.producedItemID_;
																	if (producedItemID_ == num3)
																	{
																		int num4 = other.producedAmount_;
																		if (producedAmount_ == num4)
																		{
																			Duration objB3 = other.productionPeriod_;
																			if (object.Equals(productionPeriod_, objB3))
																			{
																				int num5 = other.numberOfGrowthPeriods_;
																				if (numberOfGrowthPeriods_ == num5)
																				{
																					bool flag3 = other.selfDestructAfterAllGrowthPeriods_;
																					if (selfDestructAfterAllGrowthPeriods_ == flag3)
																					{
																						string text8 = other.burningStateVFXPrefabAddress_;
																						if (!(burningStateVFXPrefabAddress_ != text8))
																						{
																							string text9 = other.burningStateCollectVFXPrefabAddress_;
																							if (!(burningStateCollectVFXPrefabAddress_ != text9))
																							{
																								bool flag4 = other.hasGrowthBoost_;
																								if (hasGrowthBoost_ == flag4)
																								{
																									VillageAreaType villageAreaType = other.villageArea_;
																									if (villageArea_ == villageAreaType)
																									{
																										int num6 = other.minimumStallLevel_;
																										if (minimumStallLevel_ == num6)
																										{
																											bool flag5 = other.isMissionItem_;
																											if (isMissionItem_ == flag5)
																											{
																												bool flag6 = other.unsellable_;
																												if (unsellable_ == flag6)
																												{
																													GridLocationFilter missionSeedLocationRestriction = MissionSeedLocationRestriction;
																													GridLocationFilter missionSeedLocationRestriction2 = other.MissionSeedLocationRestriction;
																													if (object.Equals(missionSeedLocationRestriction, missionSeedLocationRestriction2))
																													{
																														bool flag7 = other.missionSeedBlockHarvest_;
																														if (missionSeedBlockHarvest_ == flag7)
																														{
																															int num7 = other.extraGiftFriendship_;
																															if (extraGiftFriendship_ == num7)
																															{
																																uint num8 = other.glotID_;
																																if (glotID_ == num8)
																																{
																																	MissionRestrictionOneofCase missionRestrictionOneofCase = other.missionRestrictionCase_;
																																	if (missionRestrictionCase_ == missionRestrictionOneofCase)
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
						}
					}
				}
			}
			int num9 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A80")]
		[Cpp2IlInjected.Address(RVA = "0x3844FF0", Offset = "0x38439F0", VA = "0x183844FF0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_0222
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int hashCode4 = text4.GetHashCode();
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int hashCode5 = gridAreaData.GetHashCode();
			}
			string text5 = description_;
			if (text5.m_stringLength != num2)
			{
				int hashCode6 = text5.GetHashCode();
			}
			string text6 = saplingPrefabAddress_;
			if (text6.m_stringLength != num2)
			{
				int hashCode7 = text6.GetHashCode();
			}
			Duration duration = growthPeriod_;
			if (duration != null)
			{
				int hashCode8 = duration.GetHashCode();
			}
			if (numberOfWateringRequired_ != 0)
			{
			}
			if (noGrowthBuff_)
			{
			}
			string text7 = harvestPrefabAddress_;
			if (text7.m_stringLength != num2)
			{
				int hashCode9 = text7.GetHashCode();
			}
			if (producesItem_)
			{
			}
			if (producedItemID_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text7)->ResultCode;
			}
			if (producedAmount_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text7)->ResultCode;
			}
			Duration duration2 = productionPeriod_;
			if (duration2 != null)
			{
				int hashCode10 = duration2.GetHashCode();
			}
			if (numberOfGrowthPeriods_ != 0)
			{
			}
			if (selfDestructAfterAllGrowthPeriods_)
			{
			}
			string text8 = burningStateVFXPrefabAddress_;
			if (text8.m_stringLength != num2)
			{
				int hashCode11 = text8.GetHashCode();
			}
			string text9 = burningStateCollectVFXPrefabAddress_;
			if (text9.m_stringLength != num2)
			{
				int hashCode12 = text9.GetHashCode();
			}
			if (hasGrowthBoost_)
			{
			}
			if (villageArea_ != 0)
			{
				Result resultCode3 = ((SessionSearchFindCallbackInfo*)text9)->ResultCode;
			}
			if (minimumStallLevel_ != 0)
			{
				Result resultCode4 = ((SessionSearchFindCallbackInfo*)text9)->ResultCode;
			}
			if (isMissionItem_)
			{
			}
			if (unsellable_)
			{
			}
			if (missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
			{
				object obj = missionRestriction_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode13 = obj.GetHashCode();
			}
			if (missionSeedBlockHarvest_)
			{
			}
			if (extraGiftFriendship_ != 0)
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
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A81")]
		[Cpp2IlInjected.Address(RVA = "0x3846A20", Offset = "0x3845420", VA = "0x183846A20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A82")]
		[Cpp2IlInjected.Address(RVA = "0x3846A80", Offset = "0x3845480", VA = "0x183846A80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0317
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
			if (description_.m_stringLength != 0)
			{
				string value7 = description_;
				output.WriteString(value7);
			}
			if (saplingPrefabAddress_.m_stringLength != 0)
			{
				string value8 = saplingPrefabAddress_;
				output.WriteString(value8);
			}
			if ((long)growthPeriod_ != 0)
			{
				Duration value9 = growthPeriod_;
				output.WriteMessage(value9);
			}
			if (numberOfWateringRequired_ != 0)
			{
				int value10 = numberOfWateringRequired_;
				output.WriteInt32(value10);
			}
			if (harvestPrefabAddress_.m_stringLength != 0)
			{
				string value11 = harvestPrefabAddress_;
				output.WriteString(value11);
			}
			if (producesItem_)
			{
				bool value12 = producesItem_;
				output.WriteBool(value12);
			}
			if (producedItemID_ != 0)
			{
				int value13 = producedItemID_;
				output.WriteInt32(value13);
			}
			if (producedAmount_ != 0)
			{
				int value14 = producedAmount_;
				output.WriteInt32(value14);
			}
			if ((long)productionPeriod_ != 0)
			{
				Duration value15 = productionPeriod_;
				output.WriteMessage(value15);
			}
			if (numberOfGrowthPeriods_ != 0)
			{
				int value16 = numberOfGrowthPeriods_;
				output.WriteInt32(value16);
			}
			if (selfDestructAfterAllGrowthPeriods_)
			{
				bool value17 = selfDestructAfterAllGrowthPeriods_;
				output.WriteBool(value17);
			}
			if (burningStateVFXPrefabAddress_.m_stringLength != 0)
			{
				string value18 = burningStateVFXPrefabAddress_;
				output.WriteString(value18);
			}
			if (burningStateCollectVFXPrefabAddress_.m_stringLength != 0)
			{
				string value19 = burningStateCollectVFXPrefabAddress_;
				output.WriteString(value19);
			}
			if (hasGrowthBoost_)
			{
				bool value20 = hasGrowthBoost_;
				output.WriteBool(value20);
			}
			if (villageArea_ != 0)
			{
			}
			if (minimumStallLevel_ != 0)
			{
				int value21 = minimumStallLevel_;
				output.WriteInt32(value21);
			}
			if (isMissionItem_)
			{
				bool value22 = isMissionItem_;
				output.WriteBool(value22);
			}
			if (missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction && missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
			{
				object obj = missionRestriction_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (missionSeedBlockHarvest_)
			{
				bool value23 = missionSeedBlockHarvest_;
				output.WriteBool(value23);
			}
			if (extraGiftFriendship_ != 0)
			{
				int value24 = extraGiftFriendship_;
				output.WriteInt32(value24);
			}
			if (unsellable_)
			{
				bool value25 = unsellable_;
				output.WriteBool(value25);
			}
			if (noGrowthBuff_)
			{
				bool value26 = noGrowthBuff_;
				output.WriteBool(value26);
			}
			if (glotID_ != 0)
			{
				uint value27 = glotID_;
				output.WriteUInt32(value27);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A83")]
		[Cpp2IlInjected.Address(RVA = "0x3843A30", Offset = "0x3842430", VA = "0x183843A30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_031f
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
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
			string text5 = description_;
			if (text5.m_stringLength != num2)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			string text6 = saplingPrefabAddress_;
			if (text6.m_stringLength != num2)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text6);
				num10++;
				num2 += num10;
			}
			Duration duration = growthPeriod_;
			if (duration != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(duration);
				num11++;
				num2 += num11;
			}
			int num12 = numberOfWateringRequired_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			string text7 = harvestPrefabAddress_;
			if (text7.m_stringLength != num2)
			{
				int num14 = CodedOutputStream.ComputeStringSize(text7);
				num14++;
				num2 += num14;
			}
			int num15 = producedItemID_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			int num17 = producedAmount_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			Duration duration2 = productionPeriod_;
			if (duration2 != null)
			{
				int num19 = CodedOutputStream.ComputeMessageSize(duration2);
				num19++;
				num2 += num19;
			}
			int num20 = numberOfGrowthPeriods_;
			if (num20 != 0)
			{
				int num21 = CodedOutputStream.ComputeInt32Size(num20);
				num21 += 2;
				num2 += num21;
			}
			string text8 = burningStateVFXPrefabAddress_;
			if (text8.m_stringLength != num2)
			{
				int num22 = CodedOutputStream.ComputeStringSize(text8);
				num22 += 2;
				num2 += num22;
			}
			string text9 = burningStateCollectVFXPrefabAddress_;
			if (text9.m_stringLength != num2)
			{
				int num23 = CodedOutputStream.ComputeStringSize(text9);
				num23 += 2;
				num2 += num23;
			}
			VillageAreaType villageAreaType = villageArea_;
			if (villageAreaType != 0)
			{
				int num24 = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
				num24 += 2;
				num2 += num24;
			}
			int num25 = minimumStallLevel_;
			if (num25 != 0)
			{
				int num26 = CodedOutputStream.ComputeInt32Size(num25);
				num26 += 2;
				num2 += num26;
			}
			if (missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
			{
				if (missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
				{
					object obj = missionRestriction_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num27 = default(int);
				num2 += num27;
			}
			int num28 = extraGiftFriendship_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
				num2 += num29;
			}
			uint num30 = glotID_;
			if (num30 != 0)
			{
				int num31 = CodedOutputStream.ComputeUInt32Size(num30);
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

		[Cpp2IlInjected.Token(Token = "0x6001A84")]
		[Cpp2IlInjected.Address(RVA = "0x3845650", Offset = "0x3844050", VA = "0x183845650", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SeedItemData other)
		{
			//Discarded unreachable code: IL_034d
			//IL_0314: Expected I4, but got O
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
			string text5 = other.description_;
			if (text5.m_stringLength != 0)
			{
				Description = text5;
			}
			string text6 = other.saplingPrefabAddress_;
			if (text6.m_stringLength != 0)
			{
				SaplingPrefabAddress = text6;
			}
			if ((long)other.growthPeriod_ != 0)
			{
				Duration duration2 = default(Duration);
				if (growthPeriod_ == null)
				{
					Duration duration = (growthPeriod_ = new Duration());
					duration2 = growthPeriod_;
				}
				Duration other3 = other.growthPeriod_;
				duration2.MergeFrom(other3);
			}
			int num2 = other.numberOfWateringRequired_;
			if (num2 != 0)
			{
				numberOfWateringRequired_ = num2;
			}
			bool flag = other.noGrowthBuff_;
			if (flag)
			{
				noGrowthBuff_ = flag;
			}
			string text7 = other.harvestPrefabAddress_;
			if (text7.m_stringLength != 0)
			{
				HarvestPrefabAddress = text7;
			}
			bool flag2 = other.producesItem_;
			if (flag2)
			{
				producesItem_ = flag2;
			}
			int num3 = other.producedItemID_;
			if (num3 != 0)
			{
				producedItemID_ = num3;
			}
			int num4 = other.producedAmount_;
			if (num4 != 0)
			{
				producedAmount_ = num4;
			}
			if ((long)other.productionPeriod_ != 0)
			{
				Duration duration4 = default(Duration);
				if (productionPeriod_ == null)
				{
					Duration duration3 = (productionPeriod_ = new Duration());
					duration4 = productionPeriod_;
				}
				Duration other4 = other.productionPeriod_;
				duration4.MergeFrom(other4);
			}
			int num5 = other.numberOfGrowthPeriods_;
			if (num5 != 0)
			{
				numberOfGrowthPeriods_ = num5;
			}
			bool flag3 = other.selfDestructAfterAllGrowthPeriods_;
			if (flag3)
			{
				selfDestructAfterAllGrowthPeriods_ = flag3;
			}
			string text8 = other.burningStateVFXPrefabAddress_;
			if (text8.m_stringLength != 0)
			{
				BurningStateVFXPrefabAddress = text8;
			}
			string text9 = other.burningStateCollectVFXPrefabAddress_;
			if (text9.m_stringLength != 0)
			{
				BurningStateCollectVFXPrefabAddress = text9;
			}
			bool flag4 = other.hasGrowthBoost_;
			if (flag4)
			{
				hasGrowthBoost_ = flag4;
			}
			VillageAreaType villageAreaType = other.villageArea_;
			if (villageAreaType != 0)
			{
				villageArea_ = villageAreaType;
			}
			int num6 = other.minimumStallLevel_;
			if (num6 != 0)
			{
				minimumStallLevel_ = num6;
			}
			bool flag5 = other.isMissionItem_;
			if (flag5)
			{
				isMissionItem_ = flag5;
			}
			bool flag6 = other.unsellable_;
			if (flag6)
			{
				unsellable_ = flag6;
			}
			bool flag7 = other.missionSeedBlockHarvest_;
			if (flag7)
			{
				missionSeedBlockHarvest_ = flag7;
			}
			int num7 = other.extraGiftFriendship_;
			if (num7 != 0)
			{
				extraGiftFriendship_ = num7;
			}
			uint num8 = other.glotID_;
			if (num8 != 0)
			{
				glotID_ = num8;
			}
			if (other.missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
			{
				if (MissionSeedLocationRestriction == null)
				{
					missionRestrictionCase_ = (MissionRestrictionOneofCase)(missionRestriction_ = new GridLocationFilter());
				}
				GridLocationFilter missionSeedLocationRestriction = MissionSeedLocationRestriction;
				GridLocationFilter missionSeedLocationRestriction2 = other.MissionSeedLocationRestriction;
				missionSeedLocationRestriction.MergeFrom(missionSeedLocationRestriction2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001A85")]
		[Cpp2IlInjected.Address(RVA = "0x3845A60", Offset = "0x3844460", VA = "0x183845A60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00f9: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 112)
			{
				if ((int)num > 168)
				{
					if ((int)num > 240)
					{
						if ((int)num > 256)
						{
							if (num == 264)
							{
								bool flag = (noGrowthBuff_ = input.ReadBool());
							}
							if (num != 7992)
							{
								goto IL_03ce;
							}
							int num2 = (int)(glotID_ = (uint)input.ReadInt32());
						}
						int num3 = default(int);
						if (num == 248)
						{
							num3 = (extraGiftFriendship_ = input.ReadInt32());
						}
						if (num3 != 256)
						{
							goto IL_03ce;
						}
						bool flag2 = (unsellable_ = input.ReadBool());
					}
					bool flag3 = default(bool);
					if ((int)num > 192)
					{
						if (num == 202)
						{
							GridLocationFilter builder = new GridLocationFilter();
							if (missionRestrictionCase_ == MissionRestrictionOneofCase.MissionSeedLocationRestriction)
							{
								if (missionRestrictionCase_ != MissionRestrictionOneofCase.MissionSeedLocationRestriction)
								{
								}
								object obj = missionRestriction_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder);
							missionRestriction_ = builder;
							missionRestrictionCase_ = (MissionRestrictionOneofCase)typeof(GridLocationFilter).TypeHandle;
						}
						if ((long)typeof(GridLocationFilter).TypeHandle != 240)
						{
							goto IL_03ce;
						}
						flag3 = (missionSeedBlockHarvest_ = input.ReadBool());
					}
					int num4 = default(int);
					if (flag3)
					{
						num4 = (minimumStallLevel_ = input.ReadInt32());
					}
					if (num4 != 192)
					{
						goto IL_03ce;
					}
					bool flag4 = (isMissionItem_ = input.ReadBool());
				}
				string text4 = default(string);
				if ((int)num > 136)
				{
					int num5 = default(int);
					if ((int)num > 154)
					{
						bool flag5 = default(bool);
						if (num == 160)
						{
							flag5 = (hasGrowthBoost_ = input.ReadBool());
						}
						if (!flag5)
						{
							goto IL_03ce;
						}
						num5 = (int)(villageArea_ = (VillageAreaType)input.ReadInt32());
					}
					string text2 = default(string);
					if (num5 == 146)
					{
						text2 = (BurningStateVFXPrefabAddress = input.ReadString());
					}
					if ((long)text2 != 154)
					{
						goto IL_03ce;
					}
					text4 = (BurningStateCollectVFXPrefabAddress = input.ReadString());
				}
				Duration duration = default(Duration);
				if ((long)text4 == 122)
				{
					Duration builder2 = default(Duration);
					if (productionPeriod_ == null)
					{
						duration = (productionPeriod_ = new Duration());
						builder2 = productionPeriod_;
					}
					input.ReadMessage(builder2);
				}
				int num6 = default(int);
				if ((long)duration == 128)
				{
					num6 = (numberOfGrowthPeriods_ = input.ReadInt32());
				}
				if (num6 != 136)
				{
					goto IL_03ce;
				}
				bool flag6 = (selfDestructAfterAllGrowthPeriods_ = input.ReadBool());
			}
			int num9 = default(int);
			if ((int)num > 58)
			{
				bool flag7 = default(bool);
				if ((int)num > 80)
				{
					int num8 = default(int);
					if ((int)num > 96)
					{
						int num7 = default(int);
						if (num == 104)
						{
							num7 = (producedItemID_ = input.ReadInt32());
						}
						if (num7 != 112)
						{
							goto IL_03ce;
						}
						num8 = (producedAmount_ = input.ReadInt32());
					}
					string text6 = default(string);
					if (num8 == 90)
					{
						text6 = (HarvestPrefabAddress = input.ReadString());
					}
					if ((long)text6 != 96)
					{
						goto IL_03ce;
					}
					flag7 = (producesItem_ = input.ReadBool());
				}
				string text8 = default(string);
				if (flag7)
				{
					text8 = (SaplingPrefabAddress = input.ReadString());
				}
				Duration duration2 = default(Duration);
				if ((long)text8 == 74)
				{
					Duration builder3 = default(Duration);
					if (growthPeriod_ == null)
					{
						duration2 = (growthPeriod_ = new Duration());
						builder3 = growthPeriod_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)duration2 != 80)
				{
					goto IL_03ce;
				}
				num9 = (numberOfWateringRequired_ = input.ReadInt32());
			}
			string text14 = default(string);
			if (num9 > 26)
			{
				string text10 = default(string);
				if (num9 > 42)
				{
					GridAreaData gridAreaData = default(GridAreaData);
					if (num9 == 50)
					{
						GridAreaData builder4 = default(GridAreaData);
						if (gridAreaData_ == null)
						{
							gridAreaData = (gridAreaData_ = new GridAreaData());
							builder4 = gridAreaData_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)gridAreaData != 58)
					{
						goto IL_03ce;
					}
					text10 = (Description = input.ReadString());
				}
				string text12 = default(string);
				if ((long)text10 == 34)
				{
					text12 = (IconAddress = input.ReadString());
				}
				if ((long)text12 != 42)
				{
					goto IL_03ce;
				}
				text14 = (PrefabAddress = input.ReadString());
			}
			int num10 = default(int);
			if ((long)text14 == 8)
			{
				num10 = (iD_ = input.ReadInt32());
			}
			string text16 = default(string);
			if (num10 == 18)
			{
				text16 = (Name = input.ReadString());
			}
			if ((long)text16 == 26)
			{
				string text18 = (DisplayName = input.ReadString());
			}
			goto IL_03ce;
			IL_03ce:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001A86")]
		[Cpp2IlInjected.Address(RVA = "0x3844C40", Offset = "0x3843640", VA = "0x183844C40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 32)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A87")]
		[Cpp2IlInjected.Address(RVA = "0x3846120", Offset = "0x3844B20", VA = "0x183846120", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0023, IL_0024, IL_0025, IL_0026, IL_0027, IL_0028, IL_0029, IL_003a, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6, IL_00ac, IL_00b2, IL_00b8, IL_00be, IL_00c4, IL_00ca
			//IL_000e: Expected I4, but got O
			//IL_0039: Expected I4, but got O
			if (fieldNumber - 1 <= 32)
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

		[Cpp2IlInjected.Token(Token = "0x6001A88")]
		[Cpp2IlInjected.Address(RVA = "0x3844010", Offset = "0x3842A10", VA = "0x183844010", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0023, IL_0024, IL_0025, IL_0026, IL_0027, IL_0028
			if (fieldNumber - 1 <= 32)
			{
				int num = (iD_ = 0);
			}
			else if (fieldNumber == 999)
			{
				int num2 = (int)(glotID_ = 0u);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A89")]
		[Cpp2IlInjected.Address(RVA = "0x3845400", Offset = "0x3843E00", VA = "0x183845400", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "MissionRestriction"))
			{
				MissionRestrictionOneofCase missionRestrictionOneofCase = missionRestrictionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8A")]
		[Cpp2IlInjected.Address(RVA = "0x3844390", Offset = "0x3842D90", VA = "0x183844390", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "MissionRestriction"))
			{
				missionRestriction_ = (missionRestrictionCase_ = MissionRestrictionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8F")]
		[Cpp2IlInjected.Address(RVA = "0x3844660", Offset = "0x3843060", VA = "0x183844660", Slot = "33")]
		void IProtobufDefaultData.SetDefaultData()
		{
			hasGrowthBoost_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A90")]
		[Cpp2IlInjected.Address(RVA = "0x3844990", Offset = "0x3843390", VA = "0x183844990")]
		public (TimeSpan, TimeSpan) GetDurations()
		{
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			TimeSpan timeSpan = default(TimeSpan);
			TimeSpan timeSpan2 = default(TimeSpan);
			TimeSpan timeSpan3 = default(TimeSpan);
			TimeSpan timeSpan4 = default(TimeSpan);
			if (timeSpan - timeSpan2 < timeSpan3 && timeSpan > timeSpan4)
			{
				TimeSpan timeSpan5 = timeSpan - timeSpan4;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A91")]
		[Cpp2IlInjected.Address(RVA = "0x38454C0", Offset = "0x3843EC0", VA = "0x1838454C0")]
		public bool HasGrowthBoostFor(VillageAreaType? area)
		{
			int num = default(int);
			if (!hasGrowthBoost_)
			{
				num = 0;
			}
			return villageArea_ == (VillageAreaType)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A92")]
		[Cpp2IlInjected.Address(RVA = "0x3845530", Offset = "0x3843F30", VA = "0x183845530")]
		public bool HasGrowthBoostFor(VillageAreaType area)
		{
			if (!hasGrowthBoost_)
			{
				int num = 0;
			}
			return villageArea_ == area;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A93")]
		[Cpp2IlInjected.Address(RVA = "0x3845550", Offset = "0x3843F50", VA = "0x183845550")]
		public bool IsUnlocked(IProfile profile)
		{
			if (!hasGrowthBoost_)
			{
			}
			VillageAreaType villageAreaType = villageArea_;
			int num = 0;
			if ((long)num < (long)(IntPtr)profile)
			{
				num += num;
				num++;
			}
			int num2 = (int)villageAreaType;
			num2 += num2;
			num += 808;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A97")]
		[Cpp2IlInjected.Address(RVA = "0x3844460", Offset = "0x3842E60", VA = "0x183844460", Slot = "34")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0069
			if (producesItem_)
			{
				if (producesItem_)
				{
				}
				if ((object)Item.Invalid != null)
				{
					context.AddInvalidMemberError("Cannot be None", "ProducedItemID");
				}
			}
			if (!hasGrowthBoost_ && !isMissionItem_)
			{
				context.AddInvalidMemberError("Must be true (can be false only for MissionItem)", "HasGrowthBoost");
			}
			int acceptedFloorTypesFlag = gridAreaData_.AcceptedFloorTypesFlag;
			bool flag = default(bool);
			if (!flag)
			{
				context.AddError("Floor Type Preset is not set to Light Item.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A98")]
		[Cpp2IlInjected.Address(RVA = "0x3844400", Offset = "0x3842E00", VA = "0x183844400", Slot = "22")]
		IItemData IItemData.Clone()
		{
			SeedItemData seedItemData = new SeedItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A99")]
		[Cpp2IlInjected.Address(RVA = "0x38470D0", Offset = "0x3845AD0", VA = "0x1838470D0")]
		static SeedItemData()
		{
			Func<SeedItemData> func = default(Func<SeedItemData>);
			_parser = (MessageParser<SeedItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
