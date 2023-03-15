using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000471")]
	public sealed class TargetBuildingType : IMessage<TargetBuildingType>, IMessage, IEquatable<TargetBuildingType>, IDeepCloneable<TargetBuildingType>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount
	{
		[Cpp2IlInjected.Token(Token = "0x2000472")]
		public enum BuildingTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40017F6")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40017F7")]
			Any = 1,
			[Cpp2IlInjected.Token(Token = "0x40017F8")]
			House = 2,
			[Cpp2IlInjected.Token(Token = "0x40017F9")]
			Stall = 3,
			[Cpp2IlInjected.Token(Token = "0x40017FA")]
			Garden = 4,
			[Cpp2IlInjected.Token(Token = "0x40017FB")]
			OffGridBuilding = 6,
			[Cpp2IlInjected.Token(Token = "0x40017FC")]
			Other = 5,
			[Cpp2IlInjected.Token(Token = "0x40017FD")]
			PlayerHouse = 7
		}

		[Cpp2IlInjected.Token(Token = "0x40017EA")]
		private static readonly MessageParser<TargetBuildingType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017EB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017EC")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40017ED")]
		public const int HouseFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40017EE")]
		public const int StallFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40017EF")]
		public const int GardenFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40017F0")]
		public const int OffGridBuildingFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40017F1")]
		public const int OtherFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40017F2")]
		public const int PlayerHouseFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017F3")]
		private object buildingType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40017F4")]
		private BuildingTypeOneofCase buildingTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000DDB")]
		[DebuggerNonUserCode]
		public static MessageParser<TargetBuildingType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003671")]
			[Cpp2IlInjected.Address(RVA = "0x2569E20", Offset = "0x2568820", VA = "0x182569E20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003672")]
			[Cpp2IlInjected.Address(RVA = "0x2569BD0", Offset = "0x25685D0", VA = "0x182569BD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003673")]
			[Cpp2IlInjected.Address(RVA = "0x256A1A0", Offset = "0x2568BA0", VA = "0x18256A1A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDE")]
		[DebuggerNonUserCode]
		public TargetAnyWithAmount Any
		{
			[Cpp2IlInjected.Token(Token = "0x6003678")]
			[Cpp2IlInjected.Address(RVA = "0x2569B70", Offset = "0x2568570", VA = "0x182569B70")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.Any)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003679")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				buildingType_ = value;
				bool flag = (byte)(buildingTypeCase_ = ((value != null) ? BuildingTypeOneofCase.Any : BuildingTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDF")]
		[DebuggerNonUserCode]
		public TargetBuilding House
		{
			[Cpp2IlInjected.Token(Token = "0x600367A")]
			[Cpp2IlInjected.Address(RVA = "0x2569D00", Offset = "0x2568700", VA = "0x182569D00")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.House)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600367B")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				buildingType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE0")]
		[DebuggerNonUserCode]
		public TargetBuilding Stall
		{
			[Cpp2IlInjected.Token(Token = "0x600367C")]
			[Cpp2IlInjected.Address(RVA = "0x2569EE0", Offset = "0x25688E0", VA = "0x182569EE0")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.Stall)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600367D")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				buildingType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE1")]
		[DebuggerNonUserCode]
		public TargetBuilding Garden
		{
			[Cpp2IlInjected.Token(Token = "0x600367E")]
			[Cpp2IlInjected.Address(RVA = "0x2569CA0", Offset = "0x25686A0", VA = "0x182569CA0")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.Garden)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600367F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				buildingType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE2")]
		[DebuggerNonUserCode]
		public TargetBuilding OffGridBuilding
		{
			[Cpp2IlInjected.Token(Token = "0x6003680")]
			[Cpp2IlInjected.Address(RVA = "0x2569D60", Offset = "0x2568760", VA = "0x182569D60")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.OffGridBuilding)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003681")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				buildingType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE3")]
		[DebuggerNonUserCode]
		public TargetBuilding Other
		{
			[Cpp2IlInjected.Token(Token = "0x6003682")]
			[Cpp2IlInjected.Address(RVA = "0x2569DC0", Offset = "0x25687C0", VA = "0x182569DC0")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.Other)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003683")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				buildingType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE4")]
		[DebuggerNonUserCode]
		public TargetBuilding PlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6003684")]
			[Cpp2IlInjected.Address(RVA = "0x2569E80", Offset = "0x2568880", VA = "0x182569E80")]
			get
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003685")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
			set
			{
				buildingType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE5")]
		[DebuggerNonUserCode]
		public BuildingTypeOneofCase BuildingTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003686")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return buildingTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE6")]
		public TargetBuilding TargetBuilding
		{
			[Cpp2IlInjected.Token(Token = "0x6003695")]
			[Cpp2IlInjected.Address(RVA = "0x256A150", Offset = "0x2568B50", VA = "0x18256A150")]
			get
			{
				while (true)
				{
					object obj = buildingType_;
					int num = 0;
					if (obj != null)
					{
						/*Error: Could not find block for branch target IL_000d*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE7")]
		public BuildingItemType TargetBuildingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6003697")]
			[Cpp2IlInjected.Address(RVA = "0x256A0F0", Offset = "0x2568AF0", VA = "0x18256A0F0")]
			get
			{
				while (buildingTypeCase_ > BuildingTypeOneofCase.Other)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE8")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003698")]
			[Cpp2IlInjected.Address(RVA = "0x2569F40", Offset = "0x2568940", VA = "0x182569F40", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0027, IL_003f, IL_0045
				if (buildingTypeCase_ != BuildingTypeOneofCase.Any)
				{
					object obj = buildingType_;
					if (obj != null)
					{
						int num = 0;
						if (obj != null && 1L != 0L)
						{
						}
					}
					return new StepAmount(1);
				}
				if (buildingType_ != null)
				{
					return (StepAmount)typeof(TargetAnyWithAmount).TypeHandle;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003674")]
		[Cpp2IlInjected.Address(RVA = "0x25697D0", Offset = "0x25681D0", VA = "0x1825697D0")]
		[DebuggerNonUserCode]
		public TargetBuildingType()
		{
			//IL_0029: Expected I4, but got I8
			TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
			StepAmount stepAmount = (targetAnyWithAmount.targetAmount_ = new StepAmount());
			buildingType_ = targetAnyWithAmount;
			buildingTypeCase_ = BuildingTypeOneofCase.Any;
		}

		[Cpp2IlInjected.Token(Token = "0x6003675")]
		[Cpp2IlInjected.Address(RVA = "0x2568F70", Offset = "0x2567970", VA = "0x182568F70")]
		private void OnConstruction()
		{
			//IL_0023: Expected I4, but got I8
			TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
			StepAmount stepAmount = (targetAnyWithAmount.targetAmount_ = new StepAmount());
			buildingType_ = targetAnyWithAmount;
			buildingTypeCase_ = BuildingTypeOneofCase.Any;
		}

		[Cpp2IlInjected.Token(Token = "0x6003676")]
		[Cpp2IlInjected.Address(RVA = "0x2569890", Offset = "0x2568290", VA = "0x182569890")]
		[DebuggerNonUserCode]
		public TargetBuildingType(TargetBuildingType other)
		{
			//IL_00d4: Expected I4, but got O
			TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
			StepAmount stepAmount = (targetAnyWithAmount.targetAmount_ = new StepAmount());
			buildingType_ = targetAnyWithAmount;
			if (other.buildingTypeCase_ <= BuildingTypeOneofCase.OffGridBuilding)
			{
				bool flag = (byte)(buildingTypeCase_ = (((buildingType_ = other.Any.Clone()) != null) ? BuildingTypeOneofCase.Any : BuildingTypeOneofCase.None)) != 0;
				TargetBuilding targetBuilding = (TargetBuilding)(buildingType_ = other.House.Clone());
				TargetBuilding targetBuilding2 = (TargetBuilding)(buildingType_ = other.Stall.Clone());
				TargetBuilding targetBuilding3 = (TargetBuilding)(buildingType_ = other.Garden.Clone());
				TargetBuilding targetBuilding4 = (TargetBuilding)(buildingType_ = other.Other.Clone());
				TargetBuilding targetBuilding5 = (TargetBuilding)(buildingType_ = other.OffGridBuilding.Clone());
				buildingTypeCase_ = (BuildingTypeOneofCase)(buildingType_ = other.PlayerHouse.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003677")]
		[Cpp2IlInjected.Address(RVA = "0x2567BA0", Offset = "0x25665A0", VA = "0x182567BA0", Slot = "10")]
		[DebuggerNonUserCode]
		public TargetBuildingType Clone()
		{
			return new TargetBuildingType(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003687")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearBuildingType()
		{
			//IL_0010: Expected O, but got I4
			buildingType_ = (buildingTypeCase_ = BuildingTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003688")]
		[Cpp2IlInjected.Address(RVA = "0x2567E10", Offset = "0x2566810", VA = "0x182567E10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((TargetBuildingType)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003689")]
		[Cpp2IlInjected.Address(RVA = "0x2567C00", Offset = "0x2566600", VA = "0x182567C00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TargetBuildingType other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (buildingTypeCase_ == BuildingTypeOneofCase.Any)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
						goto IL_0134;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.buildingTypeCase_ == BuildingTypeOneofCase.Any)
				{
					obj2 = other.buildingType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					TargetBuilding house = House;
					TargetBuilding house2 = other.House;
					if (object.Equals(house, house2))
					{
						TargetBuilding stall = Stall;
						TargetBuilding stall2 = other.Stall;
						if (object.Equals(stall, stall2))
						{
							TargetBuilding garden = Garden;
							TargetBuilding garden2 = other.Garden;
							if (object.Equals(garden, garden2))
							{
								TargetBuilding offGridBuilding = OffGridBuilding;
								TargetBuilding offGridBuilding2 = other.OffGridBuilding;
								if (object.Equals(offGridBuilding, offGridBuilding2))
								{
									TargetBuilding other2 = Other;
									TargetBuilding other3 = other.Other;
									if (object.Equals(other2, other3))
									{
										TargetBuilding playerHouse = PlayerHouse;
										TargetBuilding playerHouse2 = other.PlayerHouse;
										if (object.Equals(playerHouse, playerHouse2))
										{
											BuildingTypeOneofCase buildingTypeOneofCase = other.buildingTypeCase_;
											if (buildingTypeCase_ == buildingTypeOneofCase)
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
			int num2 = 0;
			goto IL_0134;
			IL_0134:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600368A")]
		[Cpp2IlInjected.Address(RVA = "0x2567F70", Offset = "0x2566970", VA = "0x182567F70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0101
			while (true)
			{
				BuildingTypeOneofCase buildingTypeOneofCase = buildingTypeCase_;
				int num = 0;
				if (buildingTypeOneofCase == BuildingTypeOneofCase.Any)
				{
					object obj = buildingType_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (buildingTypeOneofCase != BuildingTypeOneofCase.House)
				{
					continue;
				}
				object obj2 = buildingType_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (buildingTypeCase_ != BuildingTypeOneofCase.Stall)
					{
						continue;
					}
					object obj3 = buildingType_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (buildingTypeCase_ != BuildingTypeOneofCase.Garden)
						{
							continue;
						}
						object obj4 = buildingType_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (buildingTypeCase_ != BuildingTypeOneofCase.OffGridBuilding)
							{
								continue;
							}
							object obj5 = buildingType_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (buildingTypeCase_ != BuildingTypeOneofCase.Other)
								{
									continue;
								}
								object obj6 = buildingType_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse)
									{
										object obj7 = buildingType_;
										if (obj7 == null)
										{
											break;
										}
										int hashCode7 = obj7.GetHashCode();
									}
									UnknownFieldSet unknownFields = _unknownFields;
									if (unknownFields != null)
									{
										int hashCode8 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x600368B")]
		[Cpp2IlInjected.Address(RVA = "0x25692F0", Offset = "0x2567CF0", VA = "0x1825692F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600368C")]
		[Cpp2IlInjected.Address(RVA = "0x2569350", Offset = "0x2567D50", VA = "0x182569350", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_012a
			//IL_002f: Expected O, but got I4
			while (true)
			{
				BuildingTypeOneofCase buildingTypeOneofCase = buildingTypeCase_;
				int num = 0;
				if (buildingTypeOneofCase == BuildingTypeOneofCase.Any)
				{
					if (buildingTypeCase_ == BuildingTypeOneofCase.Any)
					{
						object obj = buildingType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (buildingTypeOneofCase != BuildingTypeOneofCase.House)
				{
					continue;
				}
				if (buildingTypeCase_ == BuildingTypeOneofCase.House)
				{
					object obj2 = buildingType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (buildingTypeCase_ != BuildingTypeOneofCase.Stall)
				{
					continue;
				}
				if (buildingTypeCase_ == BuildingTypeOneofCase.Stall)
				{
					object obj3 = buildingType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (buildingTypeCase_ != BuildingTypeOneofCase.Garden)
				{
					continue;
				}
				if (buildingTypeCase_ == BuildingTypeOneofCase.Garden)
				{
					object obj4 = buildingType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (buildingTypeCase_ != BuildingTypeOneofCase.Other)
				{
					continue;
				}
				if (buildingTypeCase_ == BuildingTypeOneofCase.Other)
				{
					object obj5 = buildingType_;
					if (obj5 != null && obj5 == null)
					{
						break;
					}
				}
				if (buildingTypeCase_ != BuildingTypeOneofCase.OffGridBuilding)
				{
					continue;
				}
				if (buildingTypeCase_ == BuildingTypeOneofCase.OffGridBuilding)
				{
					object obj6 = buildingType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse && buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse)
				{
					object obj7 = buildingType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600368D")]
		[Cpp2IlInjected.Address(RVA = "0x2567760", Offset = "0x2566160", VA = "0x182567760", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (buildingTypeCase_ == BuildingTypeOneofCase.Any)
			{
				if (buildingTypeCase_ == BuildingTypeOneofCase.Any)
				{
					object obj = buildingType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (buildingTypeCase_ == BuildingTypeOneofCase.House)
			{
				if (buildingTypeCase_ != BuildingTypeOneofCase.House)
				{
				}
				object obj2 = buildingType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (buildingTypeCase_ == BuildingTypeOneofCase.Stall)
			{
				if (buildingTypeCase_ != BuildingTypeOneofCase.Stall)
				{
				}
				object obj3 = buildingType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (buildingTypeCase_ == BuildingTypeOneofCase.Garden)
			{
				if (buildingTypeCase_ != BuildingTypeOneofCase.Garden)
				{
				}
				object obj4 = buildingType_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (buildingTypeCase_ == BuildingTypeOneofCase.OffGridBuilding)
			{
				if (buildingTypeCase_ != BuildingTypeOneofCase.OffGridBuilding)
				{
				}
				object obj5 = buildingType_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (buildingTypeCase_ == BuildingTypeOneofCase.Other)
			{
				if (buildingTypeCase_ != BuildingTypeOneofCase.Other)
				{
				}
				object obj6 = buildingType_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse)
			{
				if (buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse)
				{
					object obj7 = buildingType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600368E")]
		[Cpp2IlInjected.Address(RVA = "0x2568C00", Offset = "0x2567600", VA = "0x182568C00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TargetBuildingType other)
		{
			//Discarded unreachable code: IL_0067, IL_0070, IL_0087, IL_0098, IL_00af, IL_00c0, IL_00d7, IL_00e8, IL_00ff, IL_0110, IL_0127, IL_0138, IL_014f
			//IL_0087: Expected I4, but got O
			//IL_00af: Expected I4, but got O
			//IL_00d7: Expected I4, but got O
			//IL_00ff: Expected I4, but got O
			//IL_0127: Expected I4, but got O
			//IL_014f: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.buildingTypeCase_ <= BuildingTypeOneofCase.OffGridBuilding)
			{
				if (Any == null)
				{
					bool flag = (byte)(buildingTypeCase_ = (((buildingType_ = new TargetAnyWithAmount()) != null) ? BuildingTypeOneofCase.Any : BuildingTypeOneofCase.None)) != 0;
				}
				TargetAnyWithAmount any = Any;
				TargetAnyWithAmount any2 = other.Any;
				any.MergeFrom(any2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600368F")]
		[Cpp2IlInjected.Address(RVA = "0x2568640", Offset = "0x2567040", VA = "0x182568640", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0066: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			//IL_0104: Expected I4, but got O
			//IL_015b: Expected I4, but got O
			//IL_01ff: Expected I4, but got O
			//IL_0250: Expected I4, but got O
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
						TargetBuilding targetBuilding = new TargetBuilding();
						if (buildingTypeCase_ == BuildingTypeOneofCase.OffGridBuilding)
						{
							if (buildingTypeCase_ != BuildingTypeOneofCase.OffGridBuilding)
							{
							}
							object obj = buildingType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(targetBuilding);
						buildingType_ = targetBuilding;
						buildingTypeCase_ = (BuildingTypeOneofCase)targetBuilding;
					}
					if (num != 58)
					{
						goto IL_0250;
					}
					TargetBuilding builder = new TargetBuilding();
					if (buildingTypeCase_ == BuildingTypeOneofCase.PlayerHouse)
					{
						if (buildingTypeCase_ != BuildingTypeOneofCase.PlayerHouse)
						{
						}
						object obj2 = buildingType_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					buildingType_ = builder;
					buildingTypeCase_ = (BuildingTypeOneofCase)typeof(TargetBuilding).TypeHandle;
				}
				if (num == 34)
				{
					TargetBuilding builder2 = new TargetBuilding();
					if (buildingTypeCase_ == BuildingTypeOneofCase.Garden)
					{
						if (buildingTypeCase_ != BuildingTypeOneofCase.Garden)
						{
						}
						object obj3 = buildingType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					buildingType_ = builder2;
					buildingTypeCase_ = (BuildingTypeOneofCase)typeof(TargetBuilding).TypeHandle;
				}
				if ((long)typeof(TargetBuilding).TypeHandle != 42)
				{
					goto IL_0250;
				}
				TargetBuilding builder3 = new TargetBuilding();
				if (buildingTypeCase_ == BuildingTypeOneofCase.Other)
				{
					if (buildingTypeCase_ != BuildingTypeOneofCase.Other)
					{
					}
					object obj4 = buildingType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				buildingType_ = builder3;
				buildingTypeCase_ = (BuildingTypeOneofCase)typeof(TargetBuilding).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
				if (buildingTypeCase_ == BuildingTypeOneofCase.Any)
				{
					if (buildingTypeCase_ != BuildingTypeOneofCase.Any)
					{
					}
					object obj5 = buildingType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(targetAnyWithAmount);
				buildingType_ = targetAnyWithAmount;
				flag = (byte)(buildingTypeCase_ = ((targetAnyWithAmount != null) ? BuildingTypeOneofCase.Any : BuildingTypeOneofCase.None)) != 0;
			}
			if (flag)
			{
				TargetBuilding builder4 = new TargetBuilding();
				if (buildingTypeCase_ == BuildingTypeOneofCase.House)
				{
					if (buildingTypeCase_ != BuildingTypeOneofCase.House)
					{
					}
					object obj6 = buildingType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				buildingType_ = builder4;
				buildingTypeCase_ = (BuildingTypeOneofCase)typeof(TargetBuilding).TypeHandle;
			}
			if ((long)typeof(TargetBuilding).TypeHandle == 26)
			{
				TargetBuilding builder5 = new TargetBuilding();
				if (buildingTypeCase_ == BuildingTypeOneofCase.Stall)
				{
					if (buildingTypeCase_ != BuildingTypeOneofCase.Stall)
					{
					}
					object obj7 = buildingType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder5);
				buildingType_ = builder5;
				buildingTypeCase_ = (BuildingTypeOneofCase)typeof(TargetBuilding).TypeHandle;
			}
			goto IL_0250;
			IL_0250:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003690")]
		[Cpp2IlInjected.Address(RVA = "0x2567E70", Offset = "0x2566870", VA = "0x182567E70", Slot = "11")]
		[DebuggerNonUserCode]
		public unsafe object GetFieldValue(int fieldNumber)
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			ArgumentException ex;
			while (true)
			{
				if (fieldNumber <= 6)
				{
					TargetAnyWithAmount any = Any;
					TargetBuilding house = House;
					TargetBuilding stall = Stall;
					TargetBuilding garden = Garden;
					TargetBuilding other = Other;
					TargetBuilding offGridBuilding = OffGridBuilding;
					TargetBuilding playerHouse = PlayerHouse;
				}
				ex = new ArgumentException("Invalid field number", "fieldNumber");
				if (fieldNumber > 6 && fieldNumber > 6 && fieldNumber > 6)
				{
					ex = (ArgumentException)(object)((object)ex + (object)ex);
					if (fieldNumber > 6 && fieldNumber > 6)
					{
						break;
					}
				}
			}
			ex = (ArgumentException)(ex + __ldftn(TargetBuildingType.GetFieldValue));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003691")]
		[Cpp2IlInjected.Address(RVA = "0x2569030", Offset = "0x2567A30", VA = "0x182569030", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0030, IL_0034, IL_0038, IL_0039, IL_003d, IL_0041, IL_0042, IL_0046, IL_004a, IL_004b, IL_004f, IL_0053, IL_0054, IL_0058, IL_005c, IL_005d, IL_0069, IL_006f, IL_0075, IL_007b, IL_0081
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				buildingType_ = num;
				bool flag = (byte)(buildingTypeCase_ = ((num != 0) ? BuildingTypeOneofCase.Any : BuildingTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003692")]
		[Cpp2IlInjected.Address(RVA = "0x255D280", Offset = "0x255BC80", VA = "0x18255D280", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 6)
			{
				int num = 0;
				buildingType_ = num;
				buildingTypeCase_ = (BuildingTypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003693")]
		[Cpp2IlInjected.Address(RVA = "0x25682D0", Offset = "0x2566CD0", VA = "0x1825682D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "BuildingType"))
			{
				BuildingTypeOneofCase buildingTypeOneofCase = buildingTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003694")]
		[Cpp2IlInjected.Address(RVA = "0x2567B30", Offset = "0x2566530", VA = "0x182567B30", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "BuildingType"))
			{
				buildingType_ = (buildingTypeCase_ = BuildingTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003696")]
		[Cpp2IlInjected.Address(RVA = "0x2568380", Offset = "0x2566D80", VA = "0x182568380")]
		public Item GetTargetBuildingItem(MissionItemData data)
		{
			int num = 0;
			if (buildingTypeCase_ == BuildingTypeOneofCase.House)
			{
				if (buildingType_ == null)
				{
					throw new InvalidCastException();
				}
				if (1L == 0L)
				{
				}
				if (buildingType_ == null)
				{
					throw new InvalidCastException();
				}
				Item item = default(Item);
				if ((object)item != null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int ownerCharacter = data.OwnerCharacter;
					CharacterItemData characterItemData = default(CharacterItemData);
					if (characterItemData == null)
					{
						goto IL_0057;
					}
					int house = characterItemData.House;
				}
			}
			object obj = buildingType_;
			Item result = default(Item);
			if (obj != null && obj != null)
			{
				return result;
			}
			goto IL_0057;
			IL_0057:
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6003699")]
		[Cpp2IlInjected.Address(RVA = "0x25696C0", Offset = "0x25680C0", VA = "0x1825696C0")]
		static TargetBuildingType()
		{
			Func<TargetBuildingType> func = default(Func<TargetBuildingType>);
			_parser = (MessageParser<TargetBuildingType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
