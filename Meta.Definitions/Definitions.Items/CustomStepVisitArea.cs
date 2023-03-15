using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000513")]
	public sealed class CustomStepVisitArea : IMessage<CustomStepVisitArea>, IMessage, IEquatable<CustomStepVisitArea>, IDeepCloneable<CustomStepVisitArea>, IMessageFieldAccessor, IMessageOneofAccessor, IVillageAreaMapMarker, IBuildingMapMarker, IStringTag, IDataValidation, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x2000514")]
		public enum LocationTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001B28")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001B29")]
			VillageArea,
			[Cpp2IlInjected.Token(Token = "0x4001B2A")]
			InPlayerHouse,
			[Cpp2IlInjected.Token(Token = "0x4001B2B")]
			InOwnerHouse,
			[Cpp2IlInjected.Token(Token = "0x4001B2C")]
			InScene,
			[Cpp2IlInjected.Token(Token = "0x4001B2D")]
			SpecificLocation,
			[Cpp2IlInjected.Token(Token = "0x4001B2E")]
			Character
		}

		[Cpp2IlInjected.Token(Token = "0x4001B1B")]
		private static readonly MessageParser<CustomStepVisitArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B1C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B1D")]
		public const int VillageAreaFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001B1E")]
		public const int InPlayerHouseFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001B1F")]
		public const int InOwnerHouseFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4001B20")]
		public const int InSceneFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001B21")]
		public const int SpecificLocationFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001B22")]
		public const int CharacterFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001B23")]
		public const int AutoConfirmFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B24")]
		private bool autoConfirm_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001B25")]
		private object locationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001B26")]
		private LocationTypeOneofCase locationTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17001028")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepVisitArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003EEA")]
			[Cpp2IlInjected.Address(RVA = "0x3565870", Offset = "0x3564270", VA = "0x183565870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001029")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003EEB")]
			[Cpp2IlInjected.Address(RVA = "0x3565570", Offset = "0x3563F70", VA = "0x183565570")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003EEC")]
			[Cpp2IlInjected.Address(RVA = "0x3565B10", Offset = "0x3564510", VA = "0x183565B10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102B")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6003EF0")]
			[Cpp2IlInjected.Address(RVA = "0x3565AA0", Offset = "0x35644A0", VA = "0x183565AA0")]
			get
			{
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003EF1")]
			[Cpp2IlInjected.Address(RVA = "0x3565C20", Offset = "0x3564620", VA = "0x183565C20")]
			set
			{
				//IL_0016: Expected I4, but got I8
				locationType_ = typeof(VillageAreaType).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102C")]
		[DebuggerNonUserCode]
		public Empty InPlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6003EF2")]
			[Cpp2IlInjected.Address(RVA = "0x35656A0", Offset = "0x35640A0", VA = "0x1835656A0")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.InPlayerHouse)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003EF3")]
			[Cpp2IlInjected.Address(RVA = "0x7FE160", Offset = "0x7FCB60", VA = "0x1807FE160")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102D")]
		[DebuggerNonUserCode]
		public Empty InOwnerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6003EF4")]
			[Cpp2IlInjected.Address(RVA = "0x3565640", Offset = "0x3564040", VA = "0x183565640")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.InOwnerHouse)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003EF5")]
			[Cpp2IlInjected.Address(RVA = "0x24D4340", Offset = "0x24D2D40", VA = "0x1824D4340")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102E")]
		[DebuggerNonUserCode]
		public SceneToVisit InScene
		{
			[Cpp2IlInjected.Token(Token = "0x6003EF6")]
			[Cpp2IlInjected.Address(RVA = "0x35657F0", Offset = "0x35641F0", VA = "0x1835657F0")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.InScene)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003EF7")]
			[Cpp2IlInjected.Address(RVA = "0x24D4380", Offset = "0x24D2D80", VA = "0x1824D4380")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102F")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius SpecificLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6003EF8")]
			[Cpp2IlInjected.Address(RVA = "0x35658D0", Offset = "0x35642D0", VA = "0x1835658D0")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003EF9")]
			[Cpp2IlInjected.Address(RVA = "0x3209A60", Offset = "0x3208460", VA = "0x183209A60")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001030")]
		[DebuggerNonUserCode]
		public CharacterWithRadius Character
		{
			[Cpp2IlInjected.Token(Token = "0x6003EFA")]
			[Cpp2IlInjected.Address(RVA = "0x3565510", Offset = "0x3563F10", VA = "0x183565510")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.Character)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003EFB")]
			[Cpp2IlInjected.Address(RVA = "0x3209970", Offset = "0x3208370", VA = "0x183209970")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001031")]
		[DebuggerNonUserCode]
		public bool AutoConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x6003EFC")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return autoConfirm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003EFD")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				autoConfirm_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001032")]
		[DebuggerNonUserCode]
		public LocationTypeOneofCase LocationTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003EFE")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return locationTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001033")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003F0D")]
			[Cpp2IlInjected.Address(RVA = "0x3565930", Offset = "0x3564330", VA = "0x183565930", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_0021
				string[] array;
				do
				{
					array = new string[1];
				}
				while ("TargetName" != null && array == null);
				array[0] = "TargetName";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001034")]
		public List<VillageAreaType> VillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x6003F0E")]
			[Cpp2IlInjected.Address(RVA = "0x35659F0", Offset = "0x35643F0", VA = "0x1835659F0", Slot = "16")]
			get
			{
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					List<VillageAreaType> result = (List<VillageAreaType>)(object)new List<T>();
					VillageAreaType villageArea = VillageArea;
					return result;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001035")]
		public bool IsPerformedServerSide
		{
			[Cpp2IlInjected.Token(Token = "0x6003F10")]
			[Cpp2IlInjected.Address(RVA = "0x3565850", Offset = "0x3564250", VA = "0x183565850")]
			get
			{
				//Discarded unreachable code: IL_0009
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001036")]
		public Item InSceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003F11")]
			[Cpp2IlInjected.Address(RVA = "0x3565700", Offset = "0x3564100", VA = "0x183565700")]
			get
			{
				if (locationTypeCase_ != LocationTypeOneofCase.InScene || locationType_ != null)
				{
					return Item.Invalid;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EED")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepVisitArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003EEE")]
		[Cpp2IlInjected.Address(RVA = "0x3565330", Offset = "0x3563D30", VA = "0x183565330")]
		[DebuggerNonUserCode]
		public CustomStepVisitArea(CustomStepVisitArea other)
		{
			//IL_0091: Expected I4, but got O
			bool flag = (autoConfirm_ = other.autoConfirm_);
			if (other.locationTypeCase_ <= LocationTypeOneofCase.SpecificLocation)
			{
				VillageAreaType villageArea = other.VillageArea;
				Empty empty = (Empty)(locationType_ = other.InPlayerHouse.Clone());
				Empty empty2 = (Empty)(locationType_ = other.InOwnerHouse.Clone());
				SceneToVisit sceneToVisit = (SceneToVisit)(locationType_ = other.InScene.Clone());
				LocationSourceWithRadius locationSourceWithRadius = (LocationSourceWithRadius)(locationType_ = other.SpecificLocation.Clone());
				locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = other.Character.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003EEF")]
		[Cpp2IlInjected.Address(RVA = "0x3562F70", Offset = "0x3561970", VA = "0x183562F70", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepVisitArea Clone()
		{
			return new CustomStepVisitArea(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003EFF")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearLocationType()
		{
			//IL_0010: Expected O, but got I4
			locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F00")]
		[Cpp2IlInjected.Address(RVA = "0x35638D0", Offset = "0x35622D0", VA = "0x1835638D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				VillageAreaType villageAreaType = default(VillageAreaType);
				Empty objB = default(Empty);
				Empty objB2 = default(Empty);
				SceneToVisit objB3 = default(SceneToVisit);
				LocationSourceWithRadius objB4 = default(LocationSourceWithRadius);
				if (VillageArea == villageAreaType && object.Equals(InPlayerHouse, objB) && object.Equals(InOwnerHouse, objB2) && object.Equals(InScene, objB3) && object.Equals(SpecificLocation, objB4))
				{
					CharacterWithRadius objB5 = default(CharacterWithRadius);
					bool flag = object.Equals(Character, objB5);
					if (flag && autoConfirm_ == flag && locationTypeCase_ == (flag ? LocationTypeOneofCase.VillageArea : LocationTypeOneofCase.None))
					{
						return object.Equals(_unknownFields, objB5);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F01")]
		[Cpp2IlInjected.Address(RVA = "0x3563760", Offset = "0x3562160", VA = "0x183563760", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepVisitArea other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int villageArea = (int)VillageArea;
				VillageAreaType villageArea2 = other.VillageArea;
				if (villageArea == (int)villageArea2)
				{
					Empty inPlayerHouse = InPlayerHouse;
					Empty inPlayerHouse2 = other.InPlayerHouse;
					if (object.Equals(inPlayerHouse, inPlayerHouse2))
					{
						Empty inOwnerHouse = InOwnerHouse;
						Empty inOwnerHouse2 = other.InOwnerHouse;
						if (object.Equals(inOwnerHouse, inOwnerHouse2))
						{
							SceneToVisit inScene = InScene;
							SceneToVisit inScene2 = other.InScene;
							if (object.Equals(inScene, inScene2))
							{
								LocationSourceWithRadius specificLocation = SpecificLocation;
								LocationSourceWithRadius specificLocation2 = other.SpecificLocation;
								if (object.Equals(specificLocation, specificLocation2))
								{
									CharacterWithRadius character = Character;
									CharacterWithRadius character2 = other.Character;
									if (object.Equals(character, character2))
									{
										bool flag = other.autoConfirm_;
										if (autoConfirm_ == flag)
										{
											LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
											if (locationTypeCase_ == locationTypeOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F02")]
		[Cpp2IlInjected.Address(RVA = "0x3563D40", Offset = "0x3562740", VA = "0x183563D40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00df
			while (true)
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
					{
					}
					object obj = locationType_;
				}
				if (locationTypeCase_ != LocationTypeOneofCase.InPlayerHouse)
				{
					continue;
				}
				object obj2 = locationType_;
				if (obj2 != null)
				{
					int hashCode = obj2.GetHashCode();
					if (locationTypeCase_ != LocationTypeOneofCase.InOwnerHouse)
					{
						continue;
					}
					object obj3 = locationType_;
					if (obj3 != null)
					{
						int hashCode2 = obj3.GetHashCode();
						if (locationTypeCase_ != LocationTypeOneofCase.InScene)
						{
							continue;
						}
						object obj4 = locationType_;
						if (obj4 != null)
						{
							int hashCode3 = obj4.GetHashCode();
							if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
							{
								continue;
							}
							object obj5 = locationType_;
							if (obj5 != null)
							{
								int hashCode4 = obj5.GetHashCode();
								if (locationTypeCase_ == LocationTypeOneofCase.Character)
								{
									object obj6 = locationType_;
									if (obj6 == null)
									{
										break;
									}
									int hashCode5 = obj6.GetHashCode();
								}
								if (autoConfirm_)
								{
								}
								UnknownFieldSet unknownFields = _unknownFields;
								if (unknownFields != null)
								{
									int hashCode6 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6003F03")]
		[Cpp2IlInjected.Address(RVA = "0x3564BD0", Offset = "0x35635D0", VA = "0x183564BD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F04")]
		[Cpp2IlInjected.Address(RVA = "0x3564F30", Offset = "0x3563930", VA = "0x183564F30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0102
			while (true)
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				if (locationTypeOneofCase == LocationTypeOneofCase.VillageArea)
				{
					int villageArea = (int)VillageArea;
					output.WriteInt32(villageArea);
				}
				int num = 0;
				if (locationTypeOneofCase != LocationTypeOneofCase.InPlayerHouse)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.InPlayerHouse)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.InOwnerHouse)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.InOwnerHouse)
				{
					object obj2 = locationType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.InScene)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.InScene)
				{
					object obj3 = locationType_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ == LocationTypeOneofCase.Character && locationTypeCase_ == LocationTypeOneofCase.Character)
				{
					object obj5 = locationType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (autoConfirm_)
				{
					bool value = autoConfirm_;
					output.WriteBool(value);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F05")]
		[Cpp2IlInjected.Address(RVA = "0x3562B00", Offset = "0x3561500", VA = "0x183562B00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			if (locationTypeCase_ == LocationTypeOneofCase.InPlayerHouse)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.InPlayerHouse)
				{
				}
				object obj2 = locationType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.InOwnerHouse)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.InOwnerHouse)
				{
				}
				object obj3 = locationType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.InScene)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.InScene)
				{
				}
				object obj4 = locationType_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
				{
				}
				object obj5 = locationType_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.Character)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.Character)
				{
					object obj6 = locationType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F06")]
		[Cpp2IlInjected.Address(RVA = "0x35645D0", Offset = "0x3562FD0", VA = "0x1835645D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepVisitArea other)
		{
			//Discarded unreachable code: IL_0042, IL_004b, IL_0062, IL_0078, IL_008f, IL_00a0, IL_00b7, IL_00cd, IL_00e4, IL_00fa, IL_0111
			//IL_0062: Expected I4, but got O
			//IL_008f: Expected I4, but got O
			//IL_00b7: Expected I4, but got O
			//IL_00e4: Expected I4, but got O
			//IL_0111: Expected I4, but got O
			if (other != null)
			{
				bool flag = other.autoConfirm_;
				if (flag)
				{
					autoConfirm_ = flag;
				}
				if (other.locationTypeCase_ <= LocationTypeOneofCase.SpecificLocation)
				{
					VillageAreaType villageArea = other.VillageArea;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F07")]
		[Cpp2IlInjected.Address(RVA = "0x3564100", Offset = "0x3562B00", VA = "0x183564100", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0063: Expected I4, but got O
			//IL_00cc: Expected I4, but got O
			//IL_0123: Expected I4, but got O
			//IL_0138: Expected O, but got I4
			//IL_0141: Expected I4, but got I8
			//IL_0190: Expected I4, but got O
			//IL_01e1: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 50)
					{
						CharacterWithRadius characterWithRadius = new CharacterWithRadius();
						if (locationTypeCase_ == LocationTypeOneofCase.Character)
						{
							if (locationTypeCase_ != LocationTypeOneofCase.Character)
							{
							}
							object obj = locationType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(characterWithRadius);
						locationType_ = characterWithRadius;
						locationTypeCase_ = (LocationTypeOneofCase)characterWithRadius;
					}
					if (num != 160)
					{
						goto IL_01e1;
					}
					bool flag = (autoConfirm_ = input.ReadBool());
				}
				if (num == 34)
				{
					SceneToVisit builder = new SceneToVisit();
					if (locationTypeCase_ == LocationTypeOneofCase.InScene)
					{
						if (locationTypeCase_ != LocationTypeOneofCase.InScene)
						{
						}
						object obj2 = locationType_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					locationType_ = builder;
					locationTypeCase_ = (LocationTypeOneofCase)typeof(SceneToVisit).TypeHandle;
				}
				if ((long)typeof(SceneToVisit).TypeHandle != 42)
				{
					goto IL_01e1;
				}
				LocationSourceWithRadius builder2 = new LocationSourceWithRadius();
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
					{
					}
					object obj3 = locationType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				locationType_ = builder2;
				locationTypeCase_ = (LocationTypeOneofCase)typeof(LocationSourceWithRadius).TypeHandle;
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = input.ReadInt32();
				locationType_ = num2;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
			if (num2 == 18)
			{
				Empty builder3 = new Empty();
				if (locationTypeCase_ == LocationTypeOneofCase.InPlayerHouse)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.InPlayerHouse)
					{
					}
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				locationType_ = builder3;
				locationTypeCase_ = (LocationTypeOneofCase)typeof(Empty).TypeHandle;
			}
			if ((long)typeof(Empty).TypeHandle == 26)
			{
				Empty builder4 = new Empty();
				if (locationTypeCase_ == LocationTypeOneofCase.InOwnerHouse)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.InOwnerHouse)
					{
					}
					object obj5 = locationType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				locationType_ = builder4;
				locationTypeCase_ = (LocationTypeOneofCase)typeof(Empty).TypeHandle;
			}
			goto IL_01e1;
			IL_01e1:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003F08")]
		[Cpp2IlInjected.Address(RVA = "0x3563BB0", Offset = "0x35625B0", VA = "0x183563BB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				VillageAreaType villageArea = VillageArea;
			}
			if (fieldNumber == 20)
			{
				bool flag = autoConfirm_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F09")]
		[Cpp2IlInjected.Address(RVA = "0x35648F0", Offset = "0x35632F0", VA = "0x1835648F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0007, IL_000d, IL_0011, IL_0012, IL_0016, IL_001a, IL_001b, IL_001f, IL_0023, IL_0024, IL_0028, IL_002c, IL_002d, IL_0031, IL_0035, IL_0043, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061
			//IL_0042: Expected I4, but got O
			if (fieldNumber - 1 > 5)
			{
				while (fieldNumber != 20)
				{
				}
				object obj = default(object);
				autoConfirm_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F0A")]
		[Cpp2IlInjected.Address(RVA = "0x3562E70", Offset = "0x3561870", VA = "0x183562E70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = (int)(VillageArea = VillageAreaType.Beach);
			}
			else if (fieldNumber == 20)
			{
				autoConfirm_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F0B")]
		[Cpp2IlInjected.Address(RVA = "0x3564050", Offset = "0x3562A50", VA = "0x183564050", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F0C")]
		[Cpp2IlInjected.Address(RVA = "0x3562F00", Offset = "0x3561900", VA = "0x183562F00", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F0F")]
		[Cpp2IlInjected.Address(RVA = "0x3563A80", Offset = "0x3562480", VA = "0x183563A80")]
		public unsafe List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//IL_002d: Expected O, but got I4
			int num = 0;
			if (!TryGetSceneItemBuilding(data, in world, out *(Item*)num))
			{
				if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
				{
					int num2 = 0;
				}
				if (locationType_ == null)
				{
					throw new InvalidCastException();
				}
			}
			new List<T>().Add((T)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F12")]
		[Cpp2IlInjected.Address(RVA = "0x3564C30", Offset = "0x3563630", VA = "0x183564C30")]
		public bool TryGetSceneItemBuilding(MissionItemData data, in WorldProfile world, out Item buildingItem)
		{
			//IL_0022: Expected I4, but got O
			//IL_006e: Expected I4, but got O
			//IL_00a5: Expected I4, but got I8
			LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			if (locationTypeOneofCase != LocationTypeOneofCase.InPlayerHouse)
			{
				if (locationTypeOneofCase != LocationTypeOneofCase.InOwnerHouse)
				{
					if (locationTypeOneofCase != LocationTypeOneofCase.InScene)
					{
						Item invalid = Item.Invalid;
						int num = 0;
						buildingItem.ItemID = (int)invalid;
					}
					Item targetSceneItem = InSceneItem;
					Func<BuildingItemData, bool> func = (Func<BuildingItemData, bool>)(object)(Func<T, TResult>)delegate(BuildingItemData x)
					{
						Item sceneItem = x.SceneItem;
						throw new NullReferenceException();
					};
					IEnumerable<BuildingItemData> enumerable = default(IEnumerable<BuildingItemData>);
					BuildingItemData buildingItemData = Enumerable.FirstOrDefault<BuildingItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
					if (buildingItemData != null)
					{
						int iD = buildingItemData.ID;
					}
					Item invalid2 = Item.Invalid;
					buildingItem.ItemID = (int)invalid2;
				}
				bool flag = data.TryGetOwnerCharacterHouseItem(out buildingItem);
			}
			IProfileWorld section = world.Section;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			buildingItem.ItemID = num2;
			ulong num4 = default(ulong);
			buildingItem.ItemID = (int)num4;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F13")]
		[Cpp2IlInjected.Address(RVA = "0x3562FD0", Offset = "0x35619D0", VA = "0x183562FD0", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_005f: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0114: Expected O, but got I4
			LocationTypeOneofCase locationTypeOneofCase2 = default(LocationTypeOneofCase);
			LocationTypeOneofCase locationTypeOneofCase3 = default(LocationTypeOneofCase);
			LocationSource.LocationOneofCase locationOneofCase = default(LocationSource.LocationOneofCase);
			LocationSource.LocationOneofCase locationOneofCase2 = default(LocationSource.LocationOneofCase);
			while (true)
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				int num = 0;
				if (locationTypeOneofCase == LocationTypeOneofCase.InOwnerHouse)
				{
					break;
				}
				switch (locationTypeOneofCase)
				{
				case LocationTypeOneofCase.Character:
				{
					int character_ = Character.character_;
					context.AddError("Character is not valid");
					return;
				}
				default:
					return;
				case LocationTypeOneofCase.SpecificLocation:
				{
					if (SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.AnywhereVillageArea)
					{
						string missionStepName = context.MissionStepName;
						string error = $"Please use {locationTypeOneofCase2} instead of SpecificLocation/AnywhereVillageArea in {missionStepName}";
						context.AddError(error);
					}
					if (SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.AnywhereInScene || SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.Realm)
					{
						LocationSource location_ = SpecificLocation.location_;
						string missionStepName2 = context.MissionStepName;
						string error2 = $"Please use {locationTypeOneofCase3} instead of SpecificLocation/{locationOneofCase} in {missionStepName2}";
						context.AddError(error2);
					}
					if (SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.AvatarFront || SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.NearAvatar || SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.NearUniqueItem)
					{
						LocationSource location_2 = SpecificLocation.location_;
						string error3 = $"{locationOneofCase2} is not supported by VisitArea";
						context.AddError(error3);
					}
					if (SpecificLocation.location_.locationCase_ != LocationSource.LocationOneofCase.Custom)
					{
						continue;
					}
					LocationCustom custom = SpecificLocation.location_.Custom;
					string gUID_ = custom.gUID_;
					while (custom == null)
					{
					}
					break;
				}
				case LocationTypeOneofCase.InScene:
					break;
				}
				if ((object)InSceneItem != null)
				{
					context.AddInvalidMemberError("Select a scene", "InScene");
					break;
				}
			}
			object _003COwner_003Ek__BackingField = context.Owner;
			while (_003COwner_003Ek__BackingField == null)
			{
			}
			while (_003COwner_003Ek__BackingField == null)
			{
			}
			bool flag = default(bool);
			if (flag && !flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					Item item = default(Item);
					while ((object)item == null)
					{
					}
				}
				string missionStepName3 = context.MissionStepName;
			}
			string missionStepName4 = context.MissionStepName;
			string text = $"Visit InOwnerHouse is invalid for {missionStepName4}, owner have no house ({missionStepName4})";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F14")]
		[Cpp2IlInjected.Address(RVA = "0x16260C0", Offset = "0x1624AC0", VA = "0x1816260C0", Slot = "20")]
		void IProtobufDefaultData.SetDefaultData()
		{
			autoConfirm_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F15")]
		[Cpp2IlInjected.Address(RVA = "0x3565220", Offset = "0x3563C20", VA = "0x183565220")]
		static CustomStepVisitArea()
		{
			Func<CustomStepVisitArea> func = default(Func<CustomStepVisitArea>);
			_parser = (MessageParser<CustomStepVisitArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F16")]
		[Cpp2IlInjected.Address(RVA = "0x3563630", Offset = "0x3562030", VA = "0x183563630", Slot = "17")]
		unsafe List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_002f
			//IL_002d: Expected O, but got I4
			int num = 0;
			if (!TryGetSceneItemBuilding(data, in world, out *(Item*)num))
			{
				if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
				{
					goto IL_002d;
				}
				if (locationType_ == null)
				{
					throw new InvalidCastException();
				}
			}
			List<Item> list = (List<Item>)(object)new List<T>();
			((List<T>)(object)list).Add((T)num);
			goto IL_002d;
			IL_002d:
			return list;
		}
	}
}
