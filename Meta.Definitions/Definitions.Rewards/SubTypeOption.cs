using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	public sealed class SubTypeOption : IMessage<SubTypeOption>, IMessage, IEquatable<SubTypeOption>, IDeepCloneable<SubTypeOption>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		public enum SubTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40006DE")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40006DF")]
			Activity,
			[Cpp2IlInjected.Token(Token = "0x40006E0")]
			Building,
			[Cpp2IlInjected.Token(Token = "0x40006E1")]
			Furniture,
			[Cpp2IlInjected.Token(Token = "0x40006E2")]
			Tag,
			[Cpp2IlInjected.Token(Token = "0x40006E3")]
			Crop,
			[Cpp2IlInjected.Token(Token = "0x40006E4")]
			Clothing,
			[Cpp2IlInjected.Token(Token = "0x40006E5")]
			Trimming
		}

		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private static readonly MessageParser<SubTypeOption> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public const int ActivityFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public const int BuildingFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public const int FurnitureFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public const int TagFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public const int CropFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public const int ClothingFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public const int TrimmingFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private object subType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private SubTypeOneofCase subTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		[DebuggerNonUserCode]
		public static MessageParser<SubTypeOption> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000FF3")]
			[Cpp2IlInjected.Address(RVA = "0x255F6A0", Offset = "0x255E0A0", VA = "0x18255F6A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FF4")]
			[Cpp2IlInjected.Address(RVA = "0x255F570", Offset = "0x255DF70", VA = "0x18255F570")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FF5")]
			[Cpp2IlInjected.Address(RVA = "0x255F7C0", Offset = "0x255E1C0", VA = "0x18255F7C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		[DebuggerNonUserCode]
		public ActivitySubTypeFilter Activity
		{
			[Cpp2IlInjected.Token(Token = "0x6000FF9")]
			[Cpp2IlInjected.Address(RVA = "0x255F390", Offset = "0x255DD90", VA = "0x18255F390")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Activity)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FFA")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				subType_ = value;
				bool flag = (byte)(subTypeCase_ = ((value != null) ? SubTypeOneofCase.Activity : SubTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		[DebuggerNonUserCode]
		public BuildingSubTypeFilter Building
		{
			[Cpp2IlInjected.Token(Token = "0x6000FFB")]
			[Cpp2IlInjected.Address(RVA = "0x255F3F0", Offset = "0x255DDF0", VA = "0x18255F3F0")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Building)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FFC")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				subType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		[DebuggerNonUserCode]
		public FurnitureSubTypeFilter Furniture
		{
			[Cpp2IlInjected.Token(Token = "0x6000FFD")]
			[Cpp2IlInjected.Address(RVA = "0x255F640", Offset = "0x255E040", VA = "0x18255F640")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Furniture)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FFE")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				subType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		[DebuggerNonUserCode]
		public TagSubTypeFilter Tag
		{
			[Cpp2IlInjected.Token(Token = "0x6000FFF")]
			[Cpp2IlInjected.Address(RVA = "0x255F700", Offset = "0x255E100", VA = "0x18255F700")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Tag)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001000")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				subType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		[DebuggerNonUserCode]
		public CropSubTypeFilter Crop
		{
			[Cpp2IlInjected.Token(Token = "0x6001001")]
			[Cpp2IlInjected.Address(RVA = "0x255F4B0", Offset = "0x255DEB0", VA = "0x18255F4B0")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Crop)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001002")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				subType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		[DebuggerNonUserCode]
		public ClothingSubTypeFilter Clothing
		{
			[Cpp2IlInjected.Token(Token = "0x6001003")]
			[Cpp2IlInjected.Address(RVA = "0x255F450", Offset = "0x255DE50", VA = "0x18255F450")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Clothing)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001004")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				subType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		[DebuggerNonUserCode]
		public TrimmingSubTypeFilter Trimming
		{
			[Cpp2IlInjected.Token(Token = "0x6001005")]
			[Cpp2IlInjected.Address(RVA = "0x255F760", Offset = "0x255E160", VA = "0x18255F760")]
			get
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Trimming)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001006")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
			set
			{
				subType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		[DebuggerNonUserCode]
		public SubTypeOneofCase SubTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001007")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return subTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		[DebuggerNonUserCode]
		public ISubTypeFilter SubTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6001009")]
			[Cpp2IlInjected.Address(RVA = "0x255DB40", Offset = "0x255C540", VA = "0x18255DB40")]
			get
			{
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Expected I8, but got Unknown
				if (subTypeCase_ <= SubTypeOneofCase.Clothing)
				{
					ActivitySubTypeFilter activity = Activity;
					BuildingSubTypeFilter building = Building;
					FurnitureSubTypeFilter furniture = Furniture;
					TagSubTypeFilter tag = Tag;
					CropSubTypeFilter crop = Crop;
					ClothingSubTypeFilter clothing = Clothing;
					TrimmingSubTypeFilter trimming = Trimming;
				}
				SubTypeNullFilter subTypeNullFilter = DefaultSubType;
				subTypeNullFilter = (SubTypeNullFilter)(object)((object)subTypeNullFilter + (object)subTypeNullFilter);
				ulong num = (ulong)(long)(num + subTypeNullFilter);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600100A")]
			[Cpp2IlInjected.Address(RVA = "0x255F8D0", Offset = "0x255E2D0", VA = "0x18255F8D0")]
			set
			{
				SetSubType(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		[field: Cpp2IlInjected.Token(Token = "0x40006DC")]
		public static SubTypeNullFilter DefaultSubType
		{
			[Cpp2IlInjected.Token(Token = "0x600101A")]
			[Cpp2IlInjected.Address(RVA = "0x255F510", Offset = "0x255DF10", VA = "0x18255F510")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FF6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SubTypeOption()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FF7")]
		[Cpp2IlInjected.Address(RVA = "0x255F0D0", Offset = "0x255DAD0", VA = "0x18255F0D0")]
		[DebuggerNonUserCode]
		public SubTypeOption(SubTypeOption other)
		{
			//IL_00a8: Expected I4, but got I8
			//IL_00ef: Expected I4, but got O
			if (other.subTypeCase_ <= SubTypeOneofCase.Clothing)
			{
				bool flag = (byte)(subTypeCase_ = (((subType_ = other.Activity.Clone()) != null) ? SubTypeOneofCase.Activity : SubTypeOneofCase.None)) != 0;
				BuildingSubTypeFilter buildingSubTypeFilter = (BuildingSubTypeFilter)(subType_ = other.Building.Clone());
				FurnitureSubTypeFilter furnitureSubTypeFilter = (FurnitureSubTypeFilter)(subType_ = other.Furniture.Clone());
				TagSubTypeFilter tag = other.Tag;
				TagSubTypeFilter tagSubTypeFilter = new TagSubTypeFilter();
				RepeatedField<TagItemType> repeatedField = (tagSubTypeFilter.values_ = (RepeatedField<TagItemType>)(object)((RepeatedField<T>)(object)tag.values_).Clone());
				UnknownFieldSet unknownFieldSet = (tagSubTypeFilter._unknownFields = UnknownFieldSet.Clone(tag._unknownFields));
				subType_ = tagSubTypeFilter;
				subTypeCase_ = SubTypeOneofCase.Tag;
				CropSubTypeFilter cropSubTypeFilter = (CropSubTypeFilter)(subType_ = other.Crop.Clone());
				ClothingSubTypeFilter clothingSubTypeFilter = (ClothingSubTypeFilter)(subType_ = other.Clothing.Clone());
				subTypeCase_ = (SubTypeOneofCase)(subType_ = other.Trimming.Clone());
			}
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FF8")]
		[Cpp2IlInjected.Address(RVA = "0x255D360", Offset = "0x255BD60", VA = "0x18255D360", Slot = "10")]
		[DebuggerNonUserCode]
		public SubTypeOption Clone()
		{
			return new SubTypeOption(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001008")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearSubType()
		{
			//IL_0010: Expected O, but got I4
			subType_ = (subTypeCase_ = SubTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600100B")]
		[Cpp2IlInjected.Address(RVA = "0x255DB40", Offset = "0x255C540", VA = "0x18255DB40")]
		[DebuggerNonUserCode]
		public ISubTypeFilter GetSubType()
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected I8, but got Unknown
			if (subTypeCase_ <= SubTypeOneofCase.Clothing)
			{
				ActivitySubTypeFilter activity = Activity;
				BuildingSubTypeFilter building = Building;
				FurnitureSubTypeFilter furniture = Furniture;
				TagSubTypeFilter tag = Tag;
				CropSubTypeFilter crop = Crop;
				ClothingSubTypeFilter clothing = Clothing;
				TrimmingSubTypeFilter trimming = Trimming;
			}
			SubTypeNullFilter subTypeNullFilter = DefaultSubType;
			subTypeNullFilter = (SubTypeNullFilter)(object)((object)subTypeNullFilter + (object)subTypeNullFilter);
			ulong num = (ulong)(long)(num + subTypeNullFilter);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600100C")]
		[Cpp2IlInjected.Address(RVA = "0x255E9C0", Offset = "0x255D3C0", VA = "0x18255E9C0")]
		[DebuggerNonUserCode]
		public void SetSubType(ISubTypeFilter value)
		{
			//IL_0038: Expected I4, but got I8
			//IL_0049: Expected I4, but got I8
			//IL_005a: Expected I4, but got I8
			//IL_006b: Expected I4, but got I8
			//IL_007c: Expected I4, but got I8
			//IL_008d: Expected I4, but got I8
			//IL_009e: Expected I4, but got I8
			//IL_00ad: Expected O, but got I4
			int num = 0;
			if (value != null)
			{
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Activity;
					return;
				}
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Building;
					return;
				}
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Furniture;
					return;
				}
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Tag;
					return;
				}
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Crop;
					return;
				}
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Clothing;
					return;
				}
				if (value != null)
				{
					subType_ = value;
					subTypeCase_ = SubTypeOneofCase.Trimming;
					return;
				}
			}
			subTypeCase_ = (SubTypeOneofCase)num;
			subType_ = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600100D")]
		[Cpp2IlInjected.Address(RVA = "0x255D3C0", Offset = "0x255BDC0", VA = "0x18255D3C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((SubTypeOption)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600100E")]
		[Cpp2IlInjected.Address(RVA = "0x255D420", Offset = "0x255BE20", VA = "0x18255D420", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SubTypeOption other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (subTypeCase_ == SubTypeOneofCase.Activity)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
						goto IL_0134;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.subTypeCase_ == SubTypeOneofCase.Activity)
				{
					obj2 = other.subType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					BuildingSubTypeFilter building = Building;
					BuildingSubTypeFilter building2 = other.Building;
					if (object.Equals(building, building2))
					{
						FurnitureSubTypeFilter furniture = Furniture;
						FurnitureSubTypeFilter furniture2 = other.Furniture;
						if (object.Equals(furniture, furniture2))
						{
							TagSubTypeFilter tag = Tag;
							TagSubTypeFilter tag2 = other.Tag;
							if (object.Equals(tag, tag2))
							{
								CropSubTypeFilter crop = Crop;
								CropSubTypeFilter crop2 = other.Crop;
								if (object.Equals(crop, crop2))
								{
									ClothingSubTypeFilter clothing = Clothing;
									ClothingSubTypeFilter clothing2 = other.Clothing;
									if (object.Equals(clothing, clothing2))
									{
										TrimmingSubTypeFilter trimming = Trimming;
										TrimmingSubTypeFilter trimming2 = other.Trimming;
										if (object.Equals(trimming, trimming2))
										{
											SubTypeOneofCase subTypeOneofCase = other.subTypeCase_;
											if (subTypeCase_ == subTypeOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x600100F")]
		[Cpp2IlInjected.Address(RVA = "0x255D730", Offset = "0x255C130", VA = "0x18255D730", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0101
			while (true)
			{
				SubTypeOneofCase subTypeOneofCase = subTypeCase_;
				int num = 0;
				if (subTypeOneofCase == SubTypeOneofCase.Activity)
				{
					object obj = subType_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (subTypeOneofCase != SubTypeOneofCase.Building)
				{
					continue;
				}
				object obj2 = subType_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (subTypeCase_ != SubTypeOneofCase.Furniture)
					{
						continue;
					}
					object obj3 = subType_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (subTypeCase_ != SubTypeOneofCase.Tag)
						{
							continue;
						}
						object obj4 = subType_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (subTypeCase_ != SubTypeOneofCase.Crop)
							{
								continue;
							}
							object obj5 = subType_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (subTypeCase_ != SubTypeOneofCase.Clothing)
								{
									continue;
								}
								object obj6 = subType_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (subTypeCase_ == SubTypeOneofCase.Trimming)
									{
										object obj7 = subType_;
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

		[Cpp2IlInjected.Token(Token = "0x6001010")]
		[Cpp2IlInjected.Address(RVA = "0x255EBB0", Offset = "0x255D5B0", VA = "0x18255EBB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001011")]
		[Cpp2IlInjected.Address(RVA = "0x255EC10", Offset = "0x255D610", VA = "0x18255EC10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_012a
			//IL_002f: Expected O, but got I4
			while (true)
			{
				SubTypeOneofCase subTypeOneofCase = subTypeCase_;
				int num = 0;
				if (subTypeOneofCase == SubTypeOneofCase.Activity)
				{
					if (subTypeCase_ == SubTypeOneofCase.Activity)
					{
						object obj = subType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (subTypeOneofCase != SubTypeOneofCase.Building)
				{
					continue;
				}
				if (subTypeCase_ == SubTypeOneofCase.Building)
				{
					object obj2 = subType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (subTypeCase_ != SubTypeOneofCase.Furniture)
				{
					continue;
				}
				if (subTypeCase_ == SubTypeOneofCase.Furniture)
				{
					object obj3 = subType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (subTypeCase_ != SubTypeOneofCase.Tag)
				{
					continue;
				}
				if (subTypeCase_ == SubTypeOneofCase.Tag)
				{
					object obj4 = subType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (subTypeCase_ != SubTypeOneofCase.Crop)
				{
					continue;
				}
				if (subTypeCase_ == SubTypeOneofCase.Crop)
				{
					object obj5 = subType_;
					if (obj5 != null && obj5 == null)
					{
						break;
					}
				}
				if (subTypeCase_ != SubTypeOneofCase.Clothing)
				{
					continue;
				}
				if (subTypeCase_ == SubTypeOneofCase.Clothing)
				{
					object obj6 = subType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (subTypeCase_ == SubTypeOneofCase.Trimming && subTypeCase_ == SubTypeOneofCase.Trimming)
				{
					object obj7 = subType_;
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

		[Cpp2IlInjected.Token(Token = "0x6001012")]
		[Cpp2IlInjected.Address(RVA = "0x255CEB0", Offset = "0x255B8B0", VA = "0x18255CEB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (subTypeCase_ == SubTypeOneofCase.Activity)
			{
				if (subTypeCase_ == SubTypeOneofCase.Activity)
				{
					object obj = subType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (subTypeCase_ == SubTypeOneofCase.Building)
			{
				if (subTypeCase_ != SubTypeOneofCase.Building)
				{
				}
				object obj2 = subType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (subTypeCase_ == SubTypeOneofCase.Furniture)
			{
				if (subTypeCase_ != SubTypeOneofCase.Furniture)
				{
				}
				object obj3 = subType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (subTypeCase_ == SubTypeOneofCase.Tag)
			{
				if (subTypeCase_ != SubTypeOneofCase.Tag)
				{
				}
				object obj4 = subType_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (subTypeCase_ == SubTypeOneofCase.Crop)
			{
				if (subTypeCase_ != SubTypeOneofCase.Crop)
				{
				}
				object obj5 = subType_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (subTypeCase_ == SubTypeOneofCase.Clothing)
			{
				if (subTypeCase_ != SubTypeOneofCase.Clothing)
				{
				}
				object obj6 = subType_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (subTypeCase_ == SubTypeOneofCase.Trimming)
			{
				if (subTypeCase_ == SubTypeOneofCase.Trimming)
				{
					object obj7 = subType_;
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

		[Cpp2IlInjected.Token(Token = "0x6001013")]
		[Cpp2IlInjected.Address(RVA = "0x255E290", Offset = "0x255CC90", VA = "0x18255E290", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SubTypeOption other)
		{
			//Discarded unreachable code: IL_0067, IL_0070, IL_0087, IL_009d, IL_00b4, IL_00ca, IL_00e1, IL_00f7, IL_010e, IL_0124, IL_013b, IL_0151, IL_0168
			//IL_0087: Expected I4, but got O
			//IL_00b4: Expected I4, but got O
			//IL_00e1: Expected I4, but got O
			//IL_010e: Expected I4, but got O
			//IL_013b: Expected I4, but got O
			//IL_0168: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.subTypeCase_ <= SubTypeOneofCase.Clothing)
			{
				if (Activity == null)
				{
					bool flag = (byte)(subTypeCase_ = (((subType_ = new ActivitySubTypeFilter()) != null) ? SubTypeOneofCase.Activity : SubTypeOneofCase.None)) != 0;
				}
				ActivitySubTypeFilter activity = Activity;
				ActivitySubTypeFilter activity2 = other.Activity;
				activity.MergeFrom(activity2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001014")]
		[Cpp2IlInjected.Address(RVA = "0x255DC90", Offset = "0x255C690", VA = "0x18255DC90", Slot = "5")]
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
						ClothingSubTypeFilter clothingSubTypeFilter = new ClothingSubTypeFilter();
						if (subTypeCase_ == SubTypeOneofCase.Clothing)
						{
							if (subTypeCase_ != SubTypeOneofCase.Clothing)
							{
							}
							object obj = subType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(clothingSubTypeFilter);
						subType_ = clothingSubTypeFilter;
						subTypeCase_ = (SubTypeOneofCase)clothingSubTypeFilter;
					}
					if (num != 58)
					{
						goto IL_0250;
					}
					TrimmingSubTypeFilter builder = new TrimmingSubTypeFilter();
					if (subTypeCase_ == SubTypeOneofCase.Trimming)
					{
						if (subTypeCase_ != SubTypeOneofCase.Trimming)
						{
						}
						object obj2 = subType_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					subType_ = builder;
					subTypeCase_ = (SubTypeOneofCase)typeof(TrimmingSubTypeFilter).TypeHandle;
				}
				if (num == 34)
				{
					TagSubTypeFilter builder2 = new TagSubTypeFilter();
					if (subTypeCase_ == SubTypeOneofCase.Tag)
					{
						if (subTypeCase_ != SubTypeOneofCase.Tag)
						{
						}
						object obj3 = subType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					subType_ = builder2;
					subTypeCase_ = (SubTypeOneofCase)typeof(TagSubTypeFilter).TypeHandle;
				}
				if ((long)typeof(TagSubTypeFilter).TypeHandle != 42)
				{
					goto IL_0250;
				}
				CropSubTypeFilter builder3 = new CropSubTypeFilter();
				if (subTypeCase_ == SubTypeOneofCase.Crop)
				{
					if (subTypeCase_ != SubTypeOneofCase.Crop)
					{
					}
					object obj4 = subType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				subType_ = builder3;
				subTypeCase_ = (SubTypeOneofCase)typeof(CropSubTypeFilter).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				ActivitySubTypeFilter activitySubTypeFilter = new ActivitySubTypeFilter();
				if (subTypeCase_ == SubTypeOneofCase.Activity)
				{
					if (subTypeCase_ != SubTypeOneofCase.Activity)
					{
					}
					object obj5 = subType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(activitySubTypeFilter);
				subType_ = activitySubTypeFilter;
				flag = (byte)(subTypeCase_ = ((activitySubTypeFilter != null) ? SubTypeOneofCase.Activity : SubTypeOneofCase.None)) != 0;
			}
			if (flag)
			{
				BuildingSubTypeFilter builder4 = new BuildingSubTypeFilter();
				if (subTypeCase_ == SubTypeOneofCase.Building)
				{
					if (subTypeCase_ != SubTypeOneofCase.Building)
					{
					}
					object obj6 = subType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				subType_ = builder4;
				subTypeCase_ = (SubTypeOneofCase)typeof(BuildingSubTypeFilter).TypeHandle;
			}
			if ((long)typeof(BuildingSubTypeFilter).TypeHandle == 26)
			{
				FurnitureSubTypeFilter builder5 = new FurnitureSubTypeFilter();
				if (subTypeCase_ == SubTypeOneofCase.Furniture)
				{
					if (subTypeCase_ != SubTypeOneofCase.Furniture)
					{
					}
					object obj7 = subType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder5);
				subType_ = builder5;
				subTypeCase_ = (SubTypeOneofCase)typeof(FurnitureSubTypeFilter).TypeHandle;
			}
			goto IL_0250;
			IL_0250:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001015")]
		[Cpp2IlInjected.Address(RVA = "0x255D630", Offset = "0x255C030", VA = "0x18255D630", Slot = "11")]
		[DebuggerNonUserCode]
		public unsafe object GetFieldValue(int fieldNumber)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			if (fieldNumber <= 6)
			{
				ActivitySubTypeFilter activity = Activity;
				BuildingSubTypeFilter building = Building;
				FurnitureSubTypeFilter furniture = Furniture;
				TagSubTypeFilter tag = Tag;
				CropSubTypeFilter crop = Crop;
				ClothingSubTypeFilter clothing = Clothing;
				TrimmingSubTypeFilter trimming = Trimming;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			ex = (ArgumentException)(ex + __ldftn(SubTypeOption.GetFieldValue));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001016")]
		[Cpp2IlInjected.Address(RVA = "0x255E6C0", Offset = "0x255D0C0", VA = "0x18255E6C0", Slot = "12")]
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
				subType_ = num;
				bool flag = (byte)(subTypeCase_ = ((num != 0) ? SubTypeOneofCase.Activity : SubTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001017")]
		[Cpp2IlInjected.Address(RVA = "0x255D280", Offset = "0x255BC80", VA = "0x18255D280", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 6)
			{
				int num = 0;
				subType_ = num;
				subTypeCase_ = (SubTypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001018")]
		[Cpp2IlInjected.Address(RVA = "0x255DA90", Offset = "0x255C490", VA = "0x18255DA90", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "subType"))
			{
				SubTypeOneofCase subTypeOneofCase = subTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001019")]
		[Cpp2IlInjected.Address(RVA = "0x255D2F0", Offset = "0x255BCF0", VA = "0x18255D2F0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "subType"))
			{
				subType_ = (subTypeCase_ = SubTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600101B")]
		[Cpp2IlInjected.Address(RVA = "0x255EF80", Offset = "0x255D980", VA = "0x18255EF80")]
		static SubTypeOption()
		{
			Func<SubTypeOption> func = default(Func<SubTypeOption>);
			_parser = (MessageParser<SubTypeOption>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<SubTypeOption>)(object)new SubTypeNullFilter();
			/*Error: Unexpected end of block*/;
		}
	}
}
