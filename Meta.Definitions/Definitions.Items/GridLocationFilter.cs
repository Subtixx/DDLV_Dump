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
	[Cpp2IlInjected.Token(Token = "0x200048C")]
	public sealed class GridLocationFilter : IMessage<GridLocationFilter>, IMessage, IEquatable<GridLocationFilter>, IDeepCloneable<GridLocationFilter>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200048D")]
		public enum LocationTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001875")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001876")]
			Anywhere,
			[Cpp2IlInjected.Token(Token = "0x4001877")]
			AnywhereInTheVillage,
			[Cpp2IlInjected.Token(Token = "0x4001878")]
			InHouse,
			[Cpp2IlInjected.Token(Token = "0x4001879")]
			PlayerHouse,
			[Cpp2IlInjected.Token(Token = "0x400187A")]
			VillageArea,
			[Cpp2IlInjected.Token(Token = "0x400187B")]
			SpecificLocation
		}

		[Cpp2IlInjected.Token(Token = "0x400186A")]
		private static readonly MessageParser<GridLocationFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400186B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400186C")]
		public const int AnywhereFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400186D")]
		public const int AnywhereInTheVillageFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400186E")]
		public const int InHouseFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400186F")]
		public const int PlayerHouseFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001870")]
		public const int VillageAreaFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001871")]
		public const int SpecificLocationFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001872")]
		private object locationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001873")]
		private LocationTypeOneofCase locationTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000E39")]
		[DebuggerNonUserCode]
		public static MessageParser<GridLocationFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60037CA")]
			[Cpp2IlInjected.Address(RVA = "0x2F919C0", Offset = "0x2F903C0", VA = "0x182F919C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E3A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037CB")]
			[Cpp2IlInjected.Address(RVA = "0x2F91890", Offset = "0x2F90290", VA = "0x182F91890")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E3B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037CC")]
			[Cpp2IlInjected.Address(RVA = "0x2F91C40", Offset = "0x2F90640", VA = "0x182F91C40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E3C")]
		[DebuggerNonUserCode]
		public Empty Anywhere
		{
			[Cpp2IlInjected.Token(Token = "0x60037D0")]
			[Cpp2IlInjected.Address(RVA = "0x2F91830", Offset = "0x2F90230", VA = "0x182F91830")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037D1")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				locationType_ = value;
				bool flag = (byte)(locationTypeCase_ = ((value != null) ? LocationTypeOneofCase.Anywhere : LocationTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E3D")]
		[DebuggerNonUserCode]
		public Empty AnywhereInTheVillage
		{
			[Cpp2IlInjected.Token(Token = "0x60037D2")]
			[Cpp2IlInjected.Address(RVA = "0x2F917D0", Offset = "0x2F901D0", VA = "0x182F917D0")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037D3")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E3E")]
		[DebuggerNonUserCode]
		public LocationInHouse InHouse
		{
			[Cpp2IlInjected.Token(Token = "0x60037D4")]
			[Cpp2IlInjected.Address(RVA = "0x2F91960", Offset = "0x2F90360", VA = "0x182F91960")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.InHouse)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037D5")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E3F")]
		[DebuggerNonUserCode]
		public Empty PlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x60037D6")]
			[Cpp2IlInjected.Address(RVA = "0x2F91A20", Offset = "0x2F90420", VA = "0x182F91A20")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037D7")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E40")]
		[DebuggerNonUserCode]
		public LocationVillageArea VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x60037D8")]
			[Cpp2IlInjected.Address(RVA = "0x2F91BE0", Offset = "0x2F905E0", VA = "0x182F91BE0")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037D9")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E41")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius SpecificLocation
		{
			[Cpp2IlInjected.Token(Token = "0x60037DA")]
			[Cpp2IlInjected.Address(RVA = "0x2F91A80", Offset = "0x2F90480", VA = "0x182F91A80")]
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
			[Cpp2IlInjected.Token(Token = "0x60037DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E42")]
		[DebuggerNonUserCode]
		public LocationTypeOneofCase LocationTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60037DC")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return locationTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E43")]
		public List<VillageAreaType> VillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x60037EB")]
			[Cpp2IlInjected.Address(RVA = "0x2F91AE0", Offset = "0x2F904E0", VA = "0x182F91AE0")]
			get
			{
				switch (locationTypeCase_)
				{
				case LocationTypeOneofCase.VillageArea:
				{
					LocationTypeOneofCase locationTypeOneofCase2 = locationTypeCase_;
					List<VillageAreaType> result2 = default(List<VillageAreaType>);
					if (locationType_ != null)
					{
						return result2;
					}
					goto IL_0037;
				}
				case LocationTypeOneofCase.SpecificLocation:
				{
					LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
					List<VillageAreaType> result = default(List<VillageAreaType>);
					if (locationType_ != null)
					{
						return result;
					}
					throw new InvalidCastException();
				}
				default:
					{
						int num = 0;
						goto IL_0037;
					}
					IL_0037:
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037CD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GridLocationFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60037CE")]
		[Cpp2IlInjected.Address(RVA = "0x2F915E0", Offset = "0x2F8FFE0", VA = "0x182F915E0")]
		[DebuggerNonUserCode]
		public GridLocationFilter(GridLocationFilter other)
		{
			//IL_00a1: Expected I4, but got O
			if (other.locationTypeCase_ <= LocationTypeOneofCase.VillageArea)
			{
				bool flag = (byte)(locationTypeCase_ = (((locationType_ = other.Anywhere.Clone()) != null) ? LocationTypeOneofCase.Anywhere : LocationTypeOneofCase.None)) != 0;
				Empty empty = (Empty)(locationType_ = other.AnywhereInTheVillage.Clone());
				LocationInHouse locationInHouse = (LocationInHouse)(locationType_ = other.InHouse.Clone());
				Empty empty2 = (Empty)(locationType_ = other.PlayerHouse.Clone());
				LocationVillageArea locationVillageArea = (LocationVillageArea)(locationType_ = other.VillageArea.Clone());
				locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = other.SpecificLocation.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037CF")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FA60", Offset = "0x2F8E460", VA = "0x182F8FA60", Slot = "10")]
		[DebuggerNonUserCode]
		public GridLocationFilter Clone()
		{
			return new GridLocationFilter(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60037DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearLocationType()
		{
			//IL_0010: Expected O, but got I4
			locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037DE")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FFE0", Offset = "0x2F8E9E0", VA = "0x182F8FFE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((GridLocationFilter)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60037DF")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FE00", Offset = "0x2F8E800", VA = "0x182F8FE00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridLocationFilter other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
						goto IL_0115;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.locationTypeCase_ == LocationTypeOneofCase.Anywhere)
				{
					obj2 = other.locationType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Empty anywhereInTheVillage = AnywhereInTheVillage;
					Empty anywhereInTheVillage2 = other.AnywhereInTheVillage;
					if (object.Equals(anywhereInTheVillage, anywhereInTheVillage2))
					{
						LocationInHouse inHouse = InHouse;
						LocationInHouse inHouse2 = other.InHouse;
						if (object.Equals(inHouse, inHouse2))
						{
							Empty playerHouse = PlayerHouse;
							Empty playerHouse2 = other.PlayerHouse;
							if (object.Equals(playerHouse, playerHouse2))
							{
								LocationVillageArea villageArea = VillageArea;
								LocationVillageArea villageArea2 = other.VillageArea;
								if (object.Equals(villageArea, villageArea2))
								{
									LocationSourceWithRadius specificLocation = SpecificLocation;
									LocationSourceWithRadius specificLocation2 = other.SpecificLocation;
									if (object.Equals(specificLocation, specificLocation2))
									{
										LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
										if (locationTypeCase_ == locationTypeOneofCase)
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
			int num2 = 0;
			goto IL_0115;
			IL_0115:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037E0")]
		[Cpp2IlInjected.Address(RVA = "0x2F902D0", Offset = "0x2F8ECD0", VA = "0x182F902D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00dc
			while (true)
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				int num = 0;
				if (locationTypeOneofCase == LocationTypeOneofCase.Anywhere)
				{
					object obj = locationType_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (locationTypeOneofCase != LocationTypeOneofCase.AnywhereInTheVillage)
				{
					continue;
				}
				object obj2 = locationType_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (locationTypeCase_ != LocationTypeOneofCase.InHouse)
					{
						continue;
					}
					object obj3 = locationType_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
						{
							continue;
						}
						object obj4 = locationType_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
							{
								continue;
							}
							object obj5 = locationType_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
								{
									object obj6 = locationType_;
									if (obj6 == null)
									{
										break;
									}
									int hashCode6 = obj6.GetHashCode();
								}
								UnknownFieldSet unknownFields = _unknownFields;
								if (unknownFields != null)
								{
									int hashCode7 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x60037E1")]
		[Cpp2IlInjected.Address(RVA = "0x2F91170", Offset = "0x2F8FB70", VA = "0x182F91170", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60037E2")]
		[Cpp2IlInjected.Address(RVA = "0x2F911D0", Offset = "0x2F8FBD0", VA = "0x182F911D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0100
			//IL_002f: Expected O, but got I4
			while (true)
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				int num = 0;
				if (locationTypeOneofCase == LocationTypeOneofCase.Anywhere)
				{
					if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
					{
						object obj = locationType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (locationTypeOneofCase != LocationTypeOneofCase.AnywhereInTheVillage)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
				{
					object obj2 = locationType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.InHouse)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.InHouse)
				{
					object obj3 = locationType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
				{
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						break;
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj5 = locationType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation && locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					object obj6 = locationType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037E3")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F6A0", Offset = "0x2F8E0A0", VA = "0x182F8F6A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.AnywhereInTheVillage)
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
			if (locationTypeCase_ == LocationTypeOneofCase.InHouse)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.InHouse)
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
			if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
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
			if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
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
			if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
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

		[Cpp2IlInjected.Token(Token = "0x60037E4")]
		[Cpp2IlInjected.Address(RVA = "0x2F90B90", Offset = "0x2F8F590", VA = "0x182F90B90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridLocationFilter other)
		{
			//Discarded unreachable code: IL_0067, IL_0070, IL_0087, IL_0098, IL_00af, IL_00c5, IL_00dc, IL_00ed, IL_0104, IL_011a, IL_0131
			//IL_0087: Expected I4, but got O
			//IL_00af: Expected I4, but got O
			//IL_00dc: Expected I4, but got O
			//IL_0104: Expected I4, but got O
			//IL_0131: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.locationTypeCase_ <= LocationTypeOneofCase.VillageArea)
			{
				if (Anywhere == null)
				{
					bool flag = (byte)(locationTypeCase_ = (((locationType_ = new Empty()) != null) ? LocationTypeOneofCase.Anywhere : LocationTypeOneofCase.None)) != 0;
				}
				Empty anywhere = Anywhere;
				Empty anywhere2 = other.Anywhere;
				anywhere.MergeFrom(anywhere2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60037E5")]
		[Cpp2IlInjected.Address(RVA = "0x2F90670", Offset = "0x2F8F070", VA = "0x182F90670", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00a9: Expected I4, but got O
			//IL_0100: Expected I4, but got O
			//IL_01a4: Expected I4, but got O
			//IL_01f5: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					Empty empty = new Empty();
					if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
					{
						if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
						{
						}
						object obj = locationType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(empty);
					locationType_ = empty;
					locationTypeCase_ = (LocationTypeOneofCase)empty;
				}
				if (num == 42)
				{
					LocationVillageArea builder = new LocationVillageArea();
					if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
					{
						if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
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
					locationTypeCase_ = (LocationTypeOneofCase)typeof(LocationVillageArea).TypeHandle;
				}
				if ((long)typeof(LocationVillageArea).TypeHandle != 50)
				{
					goto IL_01f5;
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
			bool flag = default(bool);
			if (num == 10)
			{
				Empty empty2 = new Empty();
				if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.Anywhere)
					{
					}
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(empty2);
				locationType_ = empty2;
				flag = (byte)(locationTypeCase_ = ((empty2 != null) ? LocationTypeOneofCase.Anywhere : LocationTypeOneofCase.None)) != 0;
			}
			if (flag)
			{
				Empty builder3 = new Empty();
				if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.AnywhereInTheVillage)
					{
					}
					object obj5 = locationType_;
					if (obj5 != null && obj5 == null)
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
				LocationInHouse builder4 = new LocationInHouse();
				if (locationTypeCase_ == LocationTypeOneofCase.InHouse)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.InHouse)
					{
					}
					object obj6 = locationType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				locationType_ = builder4;
				locationTypeCase_ = (LocationTypeOneofCase)typeof(LocationInHouse).TypeHandle;
			}
			goto IL_01f5;
			IL_01f5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60037E6")]
		[Cpp2IlInjected.Address(RVA = "0x2F901E0", Offset = "0x2F8EBE0", VA = "0x182F901E0", Slot = "11")]
		[DebuggerNonUserCode]
		public unsafe object GetFieldValue(int fieldNumber)
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			if (fieldNumber <= 5)
			{
				Empty anywhere = Anywhere;
				Empty anywhereInTheVillage = AnywhereInTheVillage;
				LocationInHouse inHouse = InHouse;
				Empty playerHouse = PlayerHouse;
				LocationVillageArea villageArea = VillageArea;
				LocationSourceWithRadius specificLocation = SpecificLocation;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			ex = (ArgumentException)(ex + __ldftn(GridLocationFilter.GetFieldValue));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F90EF0", Offset = "0x2F8F8F0", VA = "0x182F90EF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0030, IL_0034, IL_0038, IL_0039, IL_003d, IL_0041, IL_0042, IL_0046, IL_004a, IL_004b, IL_004f, IL_0053, IL_0054, IL_0060, IL_0066, IL_006c, IL_0072
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				locationType_ = num;
				bool flag = (byte)(locationTypeCase_ = ((num != 0) ? LocationTypeOneofCase.Anywhere : LocationTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037E8")]
		[Cpp2IlInjected.Address(RVA = "0x26EBD60", Offset = "0x26EA760", VA = "0x1826EBD60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 5)
			{
				int num = 0;
				locationType_ = num;
				locationTypeCase_ = (LocationTypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037E9")]
		[Cpp2IlInjected.Address(RVA = "0x2F905C0", Offset = "0x2F8EFC0", VA = "0x182F905C0", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60037EA")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F9F0", Offset = "0x2F8E3F0", VA = "0x182F8F9F0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037EC")]
		[Cpp2IlInjected.Address(RVA = "0x2F90040", Offset = "0x2F8EA40", VA = "0x182F90040")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_001f
			if (locationTypeCase_ == LocationTypeOneofCase.Anywhere)
			{
				return (List<Item>)(object)SpecificLocation.GetBuildingMapMarker(data, ref world);
			}
			int num = 0;
			return (List<Item>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x60037ED")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FAC0", Offset = "0x2F8E4C0", VA = "0x182F8FAC0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			switch (locationTypeCase_)
			{
			case LocationTypeOneofCase.SpecificLocation:
				if (locationType_ != null)
				{
					if ((long)typeof(LocationSourceWithRadius).TypeHandle == 9 || (long)typeof(LocationSourceWithRadius).TypeHandle <= 3)
					{
						string missionStepName3 = context.MissionStepName;
						LocationSourceWithRadius specificLocation = SpecificLocation;
						LocationSource.LocationOneofCase locationCase_ = specificLocation.location_.locationCase_;
						string error2 = $"{missionStepName3} contain unsupported location: {specificLocation}";
						context.AddError(error2);
					}
					break;
				}
				throw new InvalidCastException();
			case LocationTypeOneofCase.VillageArea:
			{
				object obj = locationType_;
				int num = 0;
				if (obj != null)
				{
					bool flag = default(bool);
					if (!flag)
					{
						string missionStepName = context.MissionStepName;
						string error = "TargetAreas should not be empty in " + missionStepName;
						context.AddError(error);
					}
					if (locationType_ != null)
					{
						IEnumerable<VillageAreaType> enumerable = default(IEnumerable<VillageAreaType>);
						int num2 = Enumerable.Count<VillageAreaType>((IEnumerable<>)enumerable);
						if (locationType_ != null)
						{
							int num3 = default(int);
							while (num2 == num3)
							{
							}
							string missionStepName2 = context.MissionStepName;
							string text = "TargetAreas contain duplicates in " + missionStepName2;
							throw new NullReferenceException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037EE")]
		[Cpp2IlInjected.Address(RVA = "0x2F914D0", Offset = "0x2F8FED0", VA = "0x182F914D0")]
		static GridLocationFilter()
		{
			Func<GridLocationFilter> func = default(Func<GridLocationFilter>);
			_parser = (MessageParser<GridLocationFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
