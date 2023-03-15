using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000441")]
	public sealed class LocationSource : IMessage<LocationSource>, IMessage, IEquatable<LocationSource>, IDeepCloneable<LocationSource>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000442")]
		public enum LocationOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001757")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001758")]
			Anywhere = 1,
			[Cpp2IlInjected.Token(Token = "0x4001759")]
			AnywhereFloorType = 2,
			[Cpp2IlInjected.Token(Token = "0x400175A")]
			AnywhereVillageArea = 3,
			[Cpp2IlInjected.Token(Token = "0x400175B")]
			AnywhereInScene = 4,
			[Cpp2IlInjected.Token(Token = "0x400175C")]
			FishingSpot = 9,
			[Cpp2IlInjected.Token(Token = "0x400175D")]
			Building = 10,
			[Cpp2IlInjected.Token(Token = "0x400175E")]
			PlayerHouse = 11,
			[Cpp2IlInjected.Token(Token = "0x400175F")]
			Castle = 12,
			[Cpp2IlInjected.Token(Token = "0x4001760")]
			AvatarFront = 13,
			[Cpp2IlInjected.Token(Token = "0x4001761")]
			NearAvatar = 14,
			[Cpp2IlInjected.Token(Token = "0x4001762")]
			Other = 15,
			[Cpp2IlInjected.Token(Token = "0x4001763")]
			Custom = 16,
			[Cpp2IlInjected.Token(Token = "0x4001764")]
			Realm = 17,
			[Cpp2IlInjected.Token(Token = "0x4001765")]
			NearUniqueItem = 18
		}

		[Cpp2IlInjected.Token(Token = "0x4001744")]
		private static readonly MessageParser<LocationSource> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001745")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001746")]
		public const int AnywhereFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001747")]
		public const int AnywhereFloorTypeFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001748")]
		public const int AnywhereVillageAreaFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4001749")]
		public const int AnywhereInSceneFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400174A")]
		public const int FishingSpotFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x400174B")]
		public const int BuildingFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400174C")]
		public const int PlayerHouseFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x400174D")]
		public const int CastleFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x400174E")]
		public const int AvatarFrontFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x400174F")]
		public const int NearAvatarFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4001750")]
		public const int OtherFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4001751")]
		public const int CustomFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4001752")]
		public const int RealmFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x4001753")]
		public const int NearUniqueItemFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001754")]
		private object location_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001755")]
		private LocationOneofCase locationCase_;

		[Cpp2IlInjected.Token(Token = "0x17000D63")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationSource> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003440")]
			[Cpp2IlInjected.Address(RVA = "0x38F1B60", Offset = "0x38F0560", VA = "0x1838F1B60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D64")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003441")]
			[Cpp2IlInjected.Address(RVA = "0x38F1910", Offset = "0x38F0310", VA = "0x1838F1910")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D65")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003442")]
			[Cpp2IlInjected.Address(RVA = "0x38F1C80", Offset = "0x38F0680", VA = "0x1838F1C80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D66")]
		[DebuggerNonUserCode]
		public Empty Anywhere
		{
			[Cpp2IlInjected.Token(Token = "0x6003447")]
			[Cpp2IlInjected.Address(RVA = "0x38F1730", Offset = "0x38F0130", VA = "0x1838F1730")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Anywhere)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003448")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				location_ = value;
				bool flag = (byte)(locationCase_ = ((value != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D67")]
		[DebuggerNonUserCode]
		public LocationAnywhereFloorType AnywhereFloorType
		{
			[Cpp2IlInjected.Token(Token = "0x6003449")]
			[Cpp2IlInjected.Address(RVA = "0x38F1610", Offset = "0x38F0010", VA = "0x1838F1610")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.AnywhereFloorType)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600344A")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D68")]
		[DebuggerNonUserCode]
		public LocationAnywhereVillageArea AnywhereVillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x600344B")]
			[Cpp2IlInjected.Address(RVA = "0x38F16D0", Offset = "0x38F00D0", VA = "0x1838F16D0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.AnywhereVillageArea)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600344C")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D69")]
		[DebuggerNonUserCode]
		public LocationAnywhereScene AnywhereInScene
		{
			[Cpp2IlInjected.Token(Token = "0x600344D")]
			[Cpp2IlInjected.Address(RVA = "0x38F1670", Offset = "0x38F0070", VA = "0x1838F1670")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.AnywhereInScene)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600344E")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6A")]
		[DebuggerNonUserCode]
		public LocationFishingSpot FishingSpot
		{
			[Cpp2IlInjected.Token(Token = "0x600344F")]
			[Cpp2IlInjected.Address(RVA = "0x38F19E0", Offset = "0x38F03E0", VA = "0x1838F19E0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.FishingSpot)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003450")]
			[Cpp2IlInjected.Address(RVA = "0x1D17080", Offset = "0x1D15A80", VA = "0x181D17080")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6B")]
		[DebuggerNonUserCode]
		public LocationBuilding Building
		{
			[Cpp2IlInjected.Token(Token = "0x6003451")]
			[Cpp2IlInjected.Address(RVA = "0x38F17F0", Offset = "0x38F01F0", VA = "0x1838F17F0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Building)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003452")]
			[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6C")]
		[DebuggerNonUserCode]
		public Empty PlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6003453")]
			[Cpp2IlInjected.Address(RVA = "0x38F1BC0", Offset = "0x38F05C0", VA = "0x1838F1BC0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.PlayerHouse)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003454")]
			[Cpp2IlInjected.Address(RVA = "0x1D174F0", Offset = "0x1D15EF0", VA = "0x181D174F0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6D")]
		[DebuggerNonUserCode]
		public Empty Castle
		{
			[Cpp2IlInjected.Token(Token = "0x6003455")]
			[Cpp2IlInjected.Address(RVA = "0x38F1850", Offset = "0x38F0250", VA = "0x1838F1850")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Castle)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003456")]
			[Cpp2IlInjected.Address(RVA = "0x1D16F80", Offset = "0x1D15980", VA = "0x181D16F80")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6E")]
		[DebuggerNonUserCode]
		public LocationAvatarFront AvatarFront
		{
			[Cpp2IlInjected.Token(Token = "0x6003457")]
			[Cpp2IlInjected.Address(RVA = "0x38F1790", Offset = "0x38F0190", VA = "0x1838F1790")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.AvatarFront)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003458")]
			[Cpp2IlInjected.Address(RVA = "0x1D17040", Offset = "0x1D15A40", VA = "0x181D17040")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6F")]
		[DebuggerNonUserCode]
		public Empty NearAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6003459")]
			[Cpp2IlInjected.Address(RVA = "0x38F1A40", Offset = "0x38F0440", VA = "0x1838F1A40")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.NearAvatar)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600345A")]
			[Cpp2IlInjected.Address(RVA = "0x1D17530", Offset = "0x1D15F30", VA = "0x181D17530")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D70")]
		[DebuggerNonUserCode]
		public LocationOther Other
		{
			[Cpp2IlInjected.Token(Token = "0x600345B")]
			[Cpp2IlInjected.Address(RVA = "0x38F1B00", Offset = "0x38F0500", VA = "0x1838F1B00")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Other)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600345C")]
			[Cpp2IlInjected.Address(RVA = "0x1D17000", Offset = "0x1D15A00", VA = "0x181D17000")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D71")]
		[DebuggerNonUserCode]
		public LocationCustom Custom
		{
			[Cpp2IlInjected.Token(Token = "0x600345D")]
			[Cpp2IlInjected.Address(RVA = "0x38F18B0", Offset = "0x38F02B0", VA = "0x1838F18B0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Custom)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600345E")]
			[Cpp2IlInjected.Address(RVA = "0x2028E80", Offset = "0x2027880", VA = "0x182028E80")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D72")]
		[DebuggerNonUserCode]
		public LocationRealm Realm
		{
			[Cpp2IlInjected.Token(Token = "0x600345F")]
			[Cpp2IlInjected.Address(RVA = "0x38F1C20", Offset = "0x38F0620", VA = "0x1838F1C20")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Realm)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003460")]
			[Cpp2IlInjected.Address(RVA = "0x2028F00", Offset = "0x2027900", VA = "0x182028F00")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D73")]
		[DebuggerNonUserCode]
		public LocationNearUniqueItem NearUniqueItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003461")]
			[Cpp2IlInjected.Address(RVA = "0x38F1AA0", Offset = "0x38F04A0", VA = "0x1838F1AA0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.NearUniqueItem)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003462")]
			[Cpp2IlInjected.Address(RVA = "0x2028EC0", Offset = "0x20278C0", VA = "0x182028EC0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D74")]
		[DebuggerNonUserCode]
		public LocationOneofCase LocationCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003463")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return locationCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003443")]
		[Cpp2IlInjected.Address(RVA = "0x38F15A0", Offset = "0x38EFFA0", VA = "0x1838F15A0")]
		[DebuggerNonUserCode]
		public LocationSource()
		{
			bool flag = (byte)(locationCase_ = (((location_ = new Empty()) != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003444")]
		[Cpp2IlInjected.Address(RVA = "0x38F01B0", Offset = "0x38EEBB0", VA = "0x1838F01B0")]
		private void OnConstruction()
		{
			bool flag = (byte)(locationCase_ = (((location_ = new Empty()) != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003445")]
		[Cpp2IlInjected.Address(RVA = "0x38F0FE0", Offset = "0x38EF9E0", VA = "0x1838F0FE0")]
		[DebuggerNonUserCode]
		public LocationSource(LocationSource other)
		{
			//IL_006e: Expected I4, but got O
			//IL_008b: Expected I4, but got O
			//IL_00a8: Expected I4, but got O
			//IL_00c5: Expected I4, but got O
			//IL_00e2: Expected I4, but got O
			//IL_00ff: Expected I4, but got O
			//IL_011c: Expected I4, but got O
			//IL_0139: Expected I4, but got O
			//IL_0156: Expected I4, but got O
			//IL_01b3: Expected I4, but got O
			bool flag = (byte)(locationCase_ = (((location_ = new Empty()) != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
			if (other.locationCase_ <= LocationOneofCase.Realm)
			{
				bool flag2 = (byte)(locationCase_ = (((location_ = other.Anywhere.Clone()) != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
				locationCase_ = (LocationOneofCase)(location_ = other.AnywhereFloorType.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.AnywhereVillageArea.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.AnywhereInScene.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.FishingSpot.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.Building.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.PlayerHouse.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.Castle.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.AvatarFront.Clone());
				locationCase_ = (LocationOneofCase)(location_ = other.NearAvatar.Clone());
				LocationOther other2 = other.Other;
				LocationOther locationOther = new LocationOther();
				string text = (locationOther.location_ = other2.location_);
				UnknownFieldSet unknownFieldSet = (locationOther._unknownFields = UnknownFieldSet.Clone(other2._unknownFields));
				location_ = locationOther;
				locationCase_ = (LocationOneofCase)(location_ = other.Custom.Clone());
				LocationRealm realm = other.Realm;
				LocationRealm locationRealm = new LocationRealm
				{
					realm_ = ""
				};
				string text2 = (locationRealm.realm_ = realm.realm_);
				UnknownFieldSet unknownFieldSet2 = (locationRealm._unknownFields = UnknownFieldSet.Clone(realm._unknownFields));
				location_ = locationRealm;
				LocationNearUniqueItem nearUniqueItem = other.NearUniqueItem;
				LocationNearUniqueItem locationNearUniqueItem = new LocationNearUniqueItem();
				int num = (locationNearUniqueItem.itemID_ = nearUniqueItem.itemID_);
				int num2 = (locationNearUniqueItem.sceneID_ = nearUniqueItem.sceneID_);
				UnknownFieldSet unknownFieldSet3 = (locationNearUniqueItem._unknownFields = UnknownFieldSet.Clone(nearUniqueItem._unknownFields));
				location_ = locationNearUniqueItem;
			}
			UnknownFieldSet unknownFieldSet4 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003446")]
		[Cpp2IlInjected.Address(RVA = "0x38EE0F0", Offset = "0x38ECAF0", VA = "0x1838EE0F0", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationSource Clone()
		{
			return new LocationSource(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003464")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearLocation()
		{
			//IL_0010: Expected O, but got I4
			location_ = (locationCase_ = LocationOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003465")]
		[Cpp2IlInjected.Address(RVA = "0x38EE4A0", Offset = "0x38ECEA0", VA = "0x1838EE4A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003466")]
		[Cpp2IlInjected.Address(RVA = "0x38EE150", Offset = "0x38ECB50", VA = "0x1838EE150", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationSource other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.Anywhere)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
						goto IL_020d;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.locationCase_ == LocationOneofCase.Anywhere)
				{
					obj2 = other.location_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					LocationAnywhereFloorType anywhereFloorType = AnywhereFloorType;
					LocationAnywhereFloorType anywhereFloorType2 = other.AnywhereFloorType;
					if (object.Equals(anywhereFloorType, anywhereFloorType2))
					{
						LocationAnywhereVillageArea anywhereVillageArea = AnywhereVillageArea;
						LocationAnywhereVillageArea anywhereVillageArea2 = other.AnywhereVillageArea;
						if (object.Equals(anywhereVillageArea, anywhereVillageArea2))
						{
							LocationAnywhereScene anywhereInScene = AnywhereInScene;
							LocationAnywhereScene anywhereInScene2 = other.AnywhereInScene;
							if (object.Equals(anywhereInScene, anywhereInScene2))
							{
								LocationFishingSpot fishingSpot = FishingSpot;
								LocationFishingSpot fishingSpot2 = other.FishingSpot;
								if (object.Equals(fishingSpot, fishingSpot2))
								{
									LocationBuilding building = Building;
									LocationBuilding building2 = other.Building;
									if (object.Equals(building, building2))
									{
										Empty playerHouse = PlayerHouse;
										Empty playerHouse2 = other.PlayerHouse;
										if (object.Equals(playerHouse, playerHouse2))
										{
											Empty castle = Castle;
											Empty castle2 = other.Castle;
											if (object.Equals(castle, castle2))
											{
												LocationAvatarFront avatarFront = AvatarFront;
												LocationAvatarFront avatarFront2 = other.AvatarFront;
												if (object.Equals(avatarFront, avatarFront2))
												{
													Empty nearAvatar = NearAvatar;
													Empty nearAvatar2 = other.NearAvatar;
													if (object.Equals(nearAvatar, nearAvatar2))
													{
														LocationOther other2 = Other;
														LocationOther other3 = other.Other;
														if (object.Equals(other2, other3))
														{
															LocationCustom custom = Custom;
															LocationCustom custom2 = other.Custom;
															if (object.Equals(custom, custom2))
															{
																LocationRealm realm = Realm;
																LocationRealm realm2 = other.Realm;
																if (object.Equals(realm, realm2))
																{
																	LocationNearUniqueItem nearUniqueItem = NearUniqueItem;
																	LocationNearUniqueItem nearUniqueItem2 = other.NearUniqueItem;
																	if (object.Equals(nearUniqueItem, nearUniqueItem2))
																	{
																		LocationOneofCase locationOneofCase = other.locationCase_;
																		if (locationCase_ == locationOneofCase)
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
			int num2 = 0;
			goto IL_020d;
			IL_020d:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003467")]
		[Cpp2IlInjected.Address(RVA = "0x38EE680", Offset = "0x38ED080", VA = "0x1838EE680", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0211
			while (true)
			{
				LocationOneofCase locationOneofCase = locationCase_;
				int num = 0;
				if (locationOneofCase == LocationOneofCase.Anywhere)
				{
					object obj = location_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (locationOneofCase != LocationOneofCase.AnywhereFloorType)
				{
					continue;
				}
				object obj2 = location_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (locationCase_ != LocationOneofCase.AnywhereVillageArea)
					{
						continue;
					}
					object obj3 = location_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (locationCase_ != LocationOneofCase.AnywhereInScene)
						{
							continue;
						}
						object obj4 = location_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (locationCase_ != LocationOneofCase.FishingSpot)
							{
								continue;
							}
							object obj5 = location_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (locationCase_ != LocationOneofCase.Building)
								{
									continue;
								}
								object obj6 = location_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (locationCase_ != LocationOneofCase.PlayerHouse)
									{
										continue;
									}
									object obj7 = location_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (locationCase_ != LocationOneofCase.Castle)
										{
											continue;
										}
										object obj8 = location_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (locationCase_ != LocationOneofCase.AvatarFront)
											{
												continue;
											}
											object obj9 = location_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (locationCase_ != LocationOneofCase.NearAvatar)
												{
													continue;
												}
												object obj10 = location_;
												if (obj10 != null)
												{
													int hashCode10 = obj10.GetHashCode();
													if (locationCase_ != LocationOneofCase.Other)
													{
														continue;
													}
													object obj11 = location_;
													if (obj11 != null)
													{
														int hashCode11 = obj11.GetHashCode();
														if (locationCase_ != LocationOneofCase.Custom)
														{
															continue;
														}
														object obj12 = location_;
														if (obj12 != null)
														{
															int hashCode12 = obj12.GetHashCode();
															if (locationCase_ != LocationOneofCase.Realm)
															{
																continue;
															}
															object obj13 = location_;
															if (obj13 != null)
															{
																int hashCode13 = obj13.GetHashCode();
																if (locationCase_ == LocationOneofCase.NearUniqueItem)
																{
																	object obj14 = location_;
																	if (obj14 == null)
																	{
																		break;
																	}
																	int hashCode14 = obj14.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6003468")]
		[Cpp2IlInjected.Address(RVA = "0x38F07B0", Offset = "0x38EF1B0", VA = "0x1838F07B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003469")]
		[Cpp2IlInjected.Address(RVA = "0x38F0810", Offset = "0x38EF210", VA = "0x1838F0810", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0267
			//IL_002f: Expected O, but got I4
			while (true)
			{
				LocationOneofCase locationOneofCase = locationCase_;
				int num = 0;
				if (locationOneofCase == LocationOneofCase.Anywhere)
				{
					if (locationCase_ == LocationOneofCase.Anywhere)
					{
						object obj = location_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (locationOneofCase != LocationOneofCase.AnywhereFloorType)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.AnywhereFloorType)
				{
					object obj2 = location_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.AnywhereVillageArea)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.AnywhereVillageArea)
				{
					object obj3 = location_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.AnywhereInScene)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.AnywhereInScene)
				{
					object obj4 = location_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.FishingSpot)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.FishingSpot)
				{
					object obj5 = location_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.Building)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.Building)
				{
					object obj6 = location_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.PlayerHouse)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.PlayerHouse)
				{
					object obj7 = location_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.Castle)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.Castle)
				{
					object obj8 = location_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.AvatarFront)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.AvatarFront)
				{
					object obj9 = location_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.NearAvatar)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.NearAvatar)
				{
					object obj10 = location_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.Other)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.Other)
				{
					object obj11 = location_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ != LocationOneofCase.Custom)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.Custom)
				{
					object obj12 = location_;
					if (obj12 != null && obj12 == null)
					{
						break;
					}
				}
				if (locationCase_ != LocationOneofCase.Realm)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.Realm)
				{
					object obj13 = location_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationCase_ == LocationOneofCase.NearUniqueItem && locationCase_ == LocationOneofCase.NearUniqueItem)
				{
					object obj14 = location_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600346A")]
		[Cpp2IlInjected.Address(RVA = "0x38ED880", Offset = "0x38EC280", VA = "0x1838ED880", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (locationCase_ == LocationOneofCase.Anywhere)
			{
				if (locationCase_ == LocationOneofCase.Anywhere)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (locationCase_ == LocationOneofCase.AnywhereFloorType)
			{
				if (locationCase_ != LocationOneofCase.AnywhereFloorType)
				{
				}
				object obj2 = location_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (locationCase_ == LocationOneofCase.AnywhereVillageArea)
			{
				if (locationCase_ != LocationOneofCase.AnywhereVillageArea)
				{
				}
				object obj3 = location_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (locationCase_ == LocationOneofCase.AnywhereInScene)
			{
				if (locationCase_ != LocationOneofCase.AnywhereInScene)
				{
				}
				object obj4 = location_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (locationCase_ == LocationOneofCase.FishingSpot)
			{
				if (locationCase_ != LocationOneofCase.FishingSpot)
				{
				}
				object obj5 = location_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (locationCase_ == LocationOneofCase.Building)
			{
				if (locationCase_ != LocationOneofCase.Building)
				{
				}
				object obj6 = location_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (locationCase_ == LocationOneofCase.PlayerHouse)
			{
				if (locationCase_ != LocationOneofCase.PlayerHouse)
				{
				}
				object obj7 = location_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			if (locationCase_ == LocationOneofCase.Castle)
			{
				if (locationCase_ != LocationOneofCase.Castle)
				{
				}
				object obj8 = location_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num9 = default(int);
				num += num9;
			}
			if (locationCase_ == LocationOneofCase.AvatarFront)
			{
				if (locationCase_ != LocationOneofCase.AvatarFront)
				{
				}
				object obj9 = location_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num10 = default(int);
				num += num10;
			}
			if (locationCase_ == LocationOneofCase.NearAvatar)
			{
				if (locationCase_ != LocationOneofCase.NearAvatar)
				{
				}
				object obj10 = location_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num11 = default(int);
				num += num11;
			}
			if (locationCase_ == LocationOneofCase.Other)
			{
				if (locationCase_ != LocationOneofCase.Other)
				{
				}
				object obj11 = location_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num12 = default(int);
				num += num12;
			}
			if (locationCase_ == LocationOneofCase.Custom)
			{
				if (locationCase_ != LocationOneofCase.Custom)
				{
				}
				object obj12 = location_;
				if (obj12 != null && obj12 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num13 = default(int);
				num += num13;
			}
			if (locationCase_ == LocationOneofCase.Realm)
			{
				if (locationCase_ != LocationOneofCase.Realm)
				{
				}
				object obj13 = location_;
				if (obj13 != null && obj13 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num14 = default(int);
				num += num14;
			}
			if (locationCase_ == LocationOneofCase.NearUniqueItem)
			{
				if (locationCase_ == LocationOneofCase.NearUniqueItem)
				{
					object obj14 = location_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num15 = default(int);
				num += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num += num16;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600346B")]
		[Cpp2IlInjected.Address(RVA = "0x38EF9C0", Offset = "0x38EE3C0", VA = "0x1838EF9C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationSource other)
		{
			//Discarded unreachable code: IL_02c7, IL_02d0, IL_02e7, IL_02fd, IL_0314, IL_031c, IL_0321, IL_032a, IL_0334, IL_0346, IL_035d, IL_0365, IL_036a, IL_0378, IL_0381, IL_038f, IL_0398
			//IL_006e: Expected I4, but got O
			//IL_00a7: Expected I4, but got O
			//IL_00e0: Expected I4, but got O
			//IL_0119: Expected I4, but got O
			//IL_0152: Expected I4, but got O
			//IL_018b: Expected I4, but got O
			//IL_01bb: Expected I4, but got O
			//IL_01eb: Expected I4, but got O
			//IL_0224: Expected I4, but got O
			//IL_0254: Expected I4, but got O
			//IL_02e7: Expected I4, but got O
			//IL_0314: Expected I4, but got O
			//IL_035d: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.locationCase_ <= LocationOneofCase.Realm)
			{
				if (Anywhere == null)
				{
					bool flag = (byte)(locationCase_ = (((location_ = new Empty()) != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
				}
				Empty anywhere = Anywhere;
				Empty anywhere2 = other.Anywhere;
				anywhere.MergeFrom(anywhere2);
				if (AnywhereFloorType == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationAnywhereFloorType());
				}
				LocationAnywhereFloorType anywhereFloorType = AnywhereFloorType;
				LocationAnywhereFloorType anywhereFloorType2 = other.AnywhereFloorType;
				anywhereFloorType.MergeFrom(anywhereFloorType2);
				if (AnywhereVillageArea == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationAnywhereVillageArea());
				}
				LocationAnywhereVillageArea anywhereVillageArea = AnywhereVillageArea;
				LocationAnywhereVillageArea anywhereVillageArea2 = other.AnywhereVillageArea;
				anywhereVillageArea.MergeFrom(anywhereVillageArea2);
				if (AnywhereInScene == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationAnywhereScene());
				}
				LocationAnywhereScene anywhereInScene = AnywhereInScene;
				LocationAnywhereScene anywhereInScene2 = other.AnywhereInScene;
				anywhereInScene.MergeFrom(anywhereInScene2);
				if (FishingSpot == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationFishingSpot());
				}
				LocationFishingSpot fishingSpot = FishingSpot;
				LocationFishingSpot fishingSpot2 = other.FishingSpot;
				fishingSpot.MergeFrom(fishingSpot2);
				if (Building == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationBuilding());
				}
				LocationBuilding building = Building;
				LocationBuilding building2 = other.Building;
				building.MergeFrom(building2);
				if (PlayerHouse == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new Empty());
				}
				Empty playerHouse = PlayerHouse;
				Empty playerHouse2 = other.PlayerHouse;
				if (Castle == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new Empty());
				}
				Empty castle = Castle;
				Empty castle2 = other.Castle;
				if (AvatarFront == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationAvatarFront());
				}
				LocationAvatarFront avatarFront = AvatarFront;
				LocationAvatarFront avatarFront2 = other.AvatarFront;
				avatarFront.MergeFrom(avatarFront2);
				if (NearAvatar == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new Empty());
				}
				Empty nearAvatar = NearAvatar;
				Empty nearAvatar2 = other.NearAvatar;
				if (Other == null)
				{
					locationCase_ = (LocationOneofCase)(location_ = new LocationOther());
				}
				LocationOther other2 = Other;
				LocationOther other3 = other.Other;
				if (other3 != null)
				{
					string text = other3.location_;
					if (text.m_stringLength != 0)
					{
						other2.Location = text;
					}
					UnknownFieldSet unknownFields = other3._unknownFields;
					UnknownFieldSet unknownFieldSet = (other2._unknownFields = UnknownFieldSet.MergeFrom(other2._unknownFields, unknownFields));
				}
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x600346C")]
		[Cpp2IlInjected.Address(RVA = "0x38EEDA0", Offset = "0x38ED7A0", VA = "0x1838EEDA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_008a: Expected I4, but got O
			//IL_00df: Expected I4, but got O
			//IL_00f3: Expected I4, but got O
			//IL_011d: Expected I4, but got O
			//IL_0182: Expected I4, but got O
			//IL_01db: Expected I4, but got O
			//IL_022c: Expected I4, but got O
			//IL_0282: Expected I4, but got O
			//IL_02db: Expected I4, but got O
			//IL_033e: Expected I4, but got O
			//IL_0397: Expected I4, but got O
			//IL_03eb: Expected I4, but got O
			//IL_0444: Expected I4, but got O
			//IL_04ed: Expected I4, but got O
			//IL_0541: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 90)
			{
				if ((int)num > 114)
				{
					if ((int)num > 130)
					{
						if (num == 138)
						{
							LocationRealm locationRealm = new LocationRealm();
							if (locationCase_ == LocationOneofCase.Realm)
							{
								if (locationCase_ != LocationOneofCase.Realm)
								{
								}
								object obj = location_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
								if (obj != null)
								{
									UnknownFieldSet unknownFields = locationRealm._unknownFields;
									UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
									locationRealm._unknownFields = unknownFields2;
								}
							}
							input.ReadMessage(locationRealm);
							location_ = locationRealm;
							locationCase_ = (LocationOneofCase)locationRealm;
						}
						if (num != 146)
						{
							goto IL_0541;
						}
						LocationNearUniqueItem locationNearUniqueItem = new LocationNearUniqueItem();
						UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
						if (locationCase_ == LocationOneofCase.NearUniqueItem)
						{
							if (locationCase_ != LocationOneofCase.NearUniqueItem)
							{
							}
							object obj2 = location_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
							if (obj2 != null)
							{
								if ((object)typeof(LocationNearUniqueItem).TypeHandle != null)
								{
									locationNearUniqueItem.itemID_ = (int)typeof(LocationNearUniqueItem).TypeHandle;
								}
								if ((object)typeof(LocationNearUniqueItem).TypeHandle != null)
								{
									locationNearUniqueItem.sceneID_ = (int)typeof(LocationNearUniqueItem).TypeHandle;
								}
								UnknownFieldSet unknownFields3 = locationNearUniqueItem._unknownFields;
								locationNearUniqueItem._unknownFields = unknownFieldSet;
							}
						}
						input.ReadMessage(locationNearUniqueItem);
						location_ = locationNearUniqueItem;
						locationCase_ = (LocationOneofCase)unknownFieldSet;
					}
					UnknownFieldSet unknownFieldSet2 = default(UnknownFieldSet);
					if (num == 122)
					{
						LocationOther locationOther = new LocationOther();
						if (locationCase_ == LocationOneofCase.Other)
						{
							if (locationCase_ != LocationOneofCase.Other)
							{
							}
							object obj3 = location_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
							if (obj3 != null)
							{
								UnknownFieldSet unknownFields4 = locationOther._unknownFields;
								locationOther._unknownFields = unknownFieldSet2;
							}
						}
						input.ReadMessage(locationOther);
						location_ = locationOther;
						locationCase_ = (LocationOneofCase)unknownFieldSet2;
					}
					if ((long)unknownFieldSet2 != 130)
					{
						goto IL_0541;
					}
					LocationCustom builder = new LocationCustom();
					if (locationCase_ == LocationOneofCase.Custom)
					{
						if (locationCase_ != LocationOneofCase.Custom)
						{
						}
						object obj4 = location_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					location_ = builder;
					locationCase_ = (LocationOneofCase)typeof(LocationCustom).TypeHandle;
				}
				if (num == 98)
				{
					Empty builder2 = new Empty();
					if (locationCase_ == LocationOneofCase.Castle)
					{
						if (locationCase_ != LocationOneofCase.Castle)
						{
						}
						object obj5 = location_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					location_ = builder2;
					locationCase_ = (LocationOneofCase)typeof(Empty).TypeHandle;
				}
				if ((long)typeof(Empty).TypeHandle == 106)
				{
					LocationAvatarFront builder3 = new LocationAvatarFront();
					if (locationCase_ == LocationOneofCase.AvatarFront)
					{
						if (locationCase_ != LocationOneofCase.AvatarFront)
						{
						}
						object obj6 = location_;
						if (obj6 != null && obj6 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					location_ = builder3;
					locationCase_ = (LocationOneofCase)typeof(LocationAvatarFront).TypeHandle;
				}
				if ((long)typeof(LocationAvatarFront).TypeHandle != 114)
				{
					goto IL_0541;
				}
				Empty builder4 = new Empty();
				if (locationCase_ == LocationOneofCase.NearAvatar)
				{
					if (locationCase_ != LocationOneofCase.NearAvatar)
					{
					}
					object obj7 = location_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				location_ = builder4;
				locationCase_ = (LocationOneofCase)typeof(Empty).TypeHandle;
			}
			if ((int)num > 26)
			{
				if ((int)num > 74)
				{
					if (num == 82)
					{
						LocationBuilding builder5 = new LocationBuilding();
						if (locationCase_ == LocationOneofCase.Building)
						{
							if (locationCase_ != LocationOneofCase.Building)
							{
							}
							object obj8 = location_;
							if (obj8 != null && obj8 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder5);
						location_ = builder5;
						locationCase_ = (LocationOneofCase)typeof(LocationBuilding).TypeHandle;
					}
					if ((long)typeof(LocationBuilding).TypeHandle != 90)
					{
						goto IL_0541;
					}
					Empty builder6 = new Empty();
					if (locationCase_ == LocationOneofCase.PlayerHouse)
					{
						if (locationCase_ != LocationOneofCase.PlayerHouse)
						{
						}
						object obj9 = location_;
						if (obj9 != null && obj9 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder6);
					location_ = builder6;
					locationCase_ = (LocationOneofCase)typeof(Empty).TypeHandle;
				}
				if ((long)typeof(Empty).TypeHandle == 34)
				{
					LocationAnywhereScene builder7 = new LocationAnywhereScene();
					if (locationCase_ == LocationOneofCase.AnywhereInScene)
					{
						if (locationCase_ != LocationOneofCase.AnywhereInScene)
						{
						}
						object obj10 = location_;
						if (obj10 != null && obj10 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder7);
					location_ = builder7;
					locationCase_ = (LocationOneofCase)typeof(LocationAnywhereScene).TypeHandle;
				}
				if ((long)typeof(LocationAnywhereScene).TypeHandle != 74)
				{
					goto IL_0541;
				}
				LocationFishingSpot builder8 = new LocationFishingSpot();
				if (locationCase_ == LocationOneofCase.FishingSpot)
				{
					if (locationCase_ != LocationOneofCase.FishingSpot)
					{
					}
					object obj11 = location_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder8);
				location_ = builder8;
				locationCase_ = (LocationOneofCase)typeof(LocationFishingSpot).TypeHandle;
			}
			bool flag = default(bool);
			if ((long)typeof(LocationFishingSpot).TypeHandle == 10)
			{
				Empty empty = new Empty();
				if (locationCase_ == LocationOneofCase.Anywhere)
				{
					if (locationCase_ != LocationOneofCase.Anywhere)
					{
					}
					object obj12 = location_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(empty);
				location_ = empty;
				flag = (byte)(locationCase_ = ((empty != null) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
			}
			if (flag)
			{
				LocationAnywhereFloorType builder9 = new LocationAnywhereFloorType();
				if (locationCase_ == LocationOneofCase.AnywhereFloorType)
				{
					if (locationCase_ != LocationOneofCase.AnywhereFloorType)
					{
					}
					object obj13 = location_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder9);
				location_ = builder9;
				locationCase_ = (LocationOneofCase)typeof(LocationAnywhereFloorType).TypeHandle;
			}
			if ((long)typeof(LocationAnywhereFloorType).TypeHandle == 26)
			{
				LocationAnywhereVillageArea builder10 = new LocationAnywhereVillageArea();
				if (locationCase_ == LocationOneofCase.AnywhereVillageArea)
				{
					if (locationCase_ != LocationOneofCase.AnywhereVillageArea)
					{
					}
					object obj14 = location_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder10);
				location_ = builder10;
				locationCase_ = (LocationOneofCase)typeof(LocationAnywhereVillageArea).TypeHandle;
			}
			goto IL_0541;
			IL_0541:
			UnknownFieldSet unknownFieldSet3 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600346D")]
		[Cpp2IlInjected.Address(RVA = "0x38EE500", Offset = "0x38ECF00", VA = "0x1838EE500", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 17)
			{
				Empty anywhere = Anywhere;
				LocationAnywhereFloorType anywhereFloorType = AnywhereFloorType;
				LocationAnywhereVillageArea anywhereVillageArea = AnywhereVillageArea;
				LocationAnywhereScene anywhereInScene = AnywhereInScene;
				LocationFishingSpot fishingSpot = FishingSpot;
				LocationBuilding building = Building;
				Empty playerHouse = PlayerHouse;
				Empty castle = Castle;
				LocationAvatarFront avatarFront = AvatarFront;
				Empty nearAvatar = NearAvatar;
				LocationOther other = Other;
				LocationCustom custom = Custom;
				LocationRealm realm = Realm;
				LocationNearUniqueItem nearUniqueItem = NearUniqueItem;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			while (fieldNumber >= 17)
			{
			}
			while (true)
			{
				if (fieldNumber > 17)
				{
					/*Error: Could not find block for branch target IL_008c*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600346E")]
		[Cpp2IlInjected.Address(RVA = "0x38F0220", Offset = "0x38EEC20", VA = "0x1838F0220", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002b, IL_002f, IL_0036, IL_0037, IL_003b, IL_0042, IL_0043, IL_0047, IL_004e, IL_004f, IL_0053, IL_005a, IL_005b, IL_005f, IL_0066, IL_0067, IL_006b, IL_0072, IL_0073, IL_0077, IL_007e, IL_007f, IL_0083, IL_008a, IL_008b, IL_008f, IL_0093, IL_0094, IL_0098, IL_009c, IL_009d, IL_00a1, IL_00a5, IL_00a6, IL_00aa, IL_00ae, IL_00af, IL_00b3, IL_00b7, IL_00b8, IL_00c4, IL_00ca, IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 17)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				location_ = num;
				bool flag = (byte)(locationCase_ = ((num != 0) ? LocationOneofCase.Anywhere : LocationOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600346F")]
		[Cpp2IlInjected.Address(RVA = "0x38EDFE0", Offset = "0x38EC9E0", VA = "0x1838EDFE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000e: Expected O, but got I4
			if (fieldNumber <= 17)
			{
				int num = 0;
				location_ = num;
				locationCase_ = (LocationOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003470")]
		[Cpp2IlInjected.Address(RVA = "0x38EECF0", Offset = "0x38ED6F0", VA = "0x1838EECF0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Location"))
			{
				LocationOneofCase locationOneofCase = locationCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003471")]
		[Cpp2IlInjected.Address(RVA = "0x38EE080", Offset = "0x38ECA80", VA = "0x1838EE080", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Location"))
			{
				location_ = (locationCase_ = LocationOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003472")]
		[Cpp2IlInjected.Address(RVA = "0x38F0ED0", Offset = "0x38EF8D0", VA = "0x1838F0ED0")]
		static LocationSource()
		{
			Func<LocationSource> func = default(Func<LocationSource>);
			_parser = (MessageParser<LocationSource>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
