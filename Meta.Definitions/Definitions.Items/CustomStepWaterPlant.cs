using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200050C")]
	public sealed class CustomStepWaterPlant : IMessage<CustomStepWaterPlant>, IMessage, IEquatable<CustomStepWaterPlant>, IDeepCloneable<CustomStepWaterPlant>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, IStepAmount, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200050D")]
		public enum PlantTypesOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001B07")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001B08")]
			FlowerItem,
			[Cpp2IlInjected.Token(Token = "0x4001B09")]
			CropItem
		}

		[Cpp2IlInjected.Token(Token = "0x4001AF6")]
		private static readonly MessageParser<CustomStepWaterPlant> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001AF7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001AF8")]
		public const int FlowerItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001AF9")]
		public const int CropItemFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001AFA")]
		public const int AmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AFB")]
		private StepAmount amount_;

		[Cpp2IlInjected.Token(Token = "0x4001AFC")]
		public const int FilterFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AFD")]
		private GridLocationFilter filter_;

		[Cpp2IlInjected.Token(Token = "0x4001AFE")]
		public const int UseDifferentItemFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AFF")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x4001B00")]
		public const int GenerateMissingFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4001B01")]
		private bool generateMissing_;

		[Cpp2IlInjected.Token(Token = "0x4001B02")]
		public const int GenerateRadiusFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001B03")]
		private int generateRadius_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001B04")]
		private object plantTypes_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001B05")]
		private PlantTypesOneofCase plantTypesCase_;

		[Cpp2IlInjected.Token(Token = "0x1700100B")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepWaterPlant> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003E84")]
			[Cpp2IlInjected.Address(RVA = "0x3567B50", Offset = "0x3566550", VA = "0x183567B50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E85")]
			[Cpp2IlInjected.Address(RVA = "0x3567970", Offset = "0x3566370", VA = "0x183567970")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E86")]
			[Cpp2IlInjected.Address(RVA = "0x3567DC0", Offset = "0x35667C0", VA = "0x183567DC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100E")]
		[DebuggerNonUserCode]
		public ItemSelector FlowerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E8B")]
			[Cpp2IlInjected.Address(RVA = "0x3567A40", Offset = "0x3566440", VA = "0x183567A40")]
			get
			{
				int num = 0;
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					object obj = plantTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003E8C")]
			[Cpp2IlInjected.Address(RVA = "0x3567ED0", Offset = "0x35668D0", VA = "0x183567ED0")]
			set
			{
				plantTypes_ = value;
				bool flag = (byte)(plantTypesCase_ = ((value != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100F")]
		[DebuggerNonUserCode]
		public ItemSelector CropItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E8D")]
			[Cpp2IlInjected.Address(RVA = "0x3567910", Offset = "0x3566310", VA = "0x183567910")]
			get
			{
				int num = 0;
				if (plantTypesCase_ == PlantTypesOneofCase.CropItem)
				{
					object obj = plantTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003E8E")]
			[Cpp2IlInjected.Address(RVA = "0x2C137C0", Offset = "0x2C121C0", VA = "0x182C137C0")]
			set
			{
				plantTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001010")]
		[DebuggerNonUserCode]
		public StepAmount Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E90")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				amount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001011")]
		[DebuggerNonUserCode]
		public GridLocationFilter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003E91")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return filter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E92")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				filter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001012")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E93")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E94")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001013")]
		[DebuggerNonUserCode]
		public bool GenerateMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6003E95")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return generateMissing_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E96")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				generateMissing_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001014")]
		[DebuggerNonUserCode]
		public int GenerateRadius
		{
			[Cpp2IlInjected.Token(Token = "0x6003E97")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return generateRadius_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E98")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				generateRadius_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001015")]
		[DebuggerNonUserCode]
		public PlantTypesOneofCase PlantTypesCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003E99")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return plantTypesCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001016")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003EA8")]
			[Cpp2IlInjected.Address(RVA = "0x3567AA0", Offset = "0x35664A0", VA = "0x183567AA0", Slot = "16")]
			get
			{
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					if (plantTypesCase_ != PlantTypesOneofCase.FlowerItem)
					{
						goto IL_0039;
					}
					object obj = plantTypes_;
					if (obj == null || obj == null)
					{
						goto IL_003b;
					}
				}
				if (plantTypesCase_ == PlantTypesOneofCase.CropItem)
				{
					object obj2 = plantTypes_;
					if (obj2 == null)
					{
						goto IL_003b;
					}
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				goto IL_0039;
				IL_0039:
				int num = 0;
				goto IL_003b;
				IL_003b:
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001017")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003EA9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "17")]
			get
			{
				return amount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001018")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003EAA")]
			[Cpp2IlInjected.Address(RVA = "0x3567BB0", Offset = "0x35665B0", VA = "0x183567BB0", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[1] = "TargetAmount";
					if ("CurrentAmount" == null || "CurrentAmount" != null)
					{
						array[2] = "CurrentAmount";
						if ("FlowerRarity" == null || "FlowerRarity" != null)
						{
							break;
						}
					}
				}
				array[3] = "FlowerRarity";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E87")]
		[Cpp2IlInjected.Address(RVA = "0x35677F0", Offset = "0x35661F0", VA = "0x1835677F0")]
		[DebuggerNonUserCode]
		public CustomStepWaterPlant()
		{
			StepAmount stepAmount = (amount_ = new StepAmount());
			bool flag = (byte)(plantTypesCase_ = (((plantTypes_ = new ItemSelector()) != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E88")]
		[Cpp2IlInjected.Address(RVA = "0x3566DE0", Offset = "0x35657E0", VA = "0x183566DE0")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (amount_ = new StepAmount());
			bool flag = (byte)(plantTypesCase_ = (((plantTypes_ = new ItemSelector()) != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E89")]
		[Cpp2IlInjected.Address(RVA = "0x3567520", Offset = "0x3565F20", VA = "0x183567520")]
		[DebuggerNonUserCode]
		public CustomStepWaterPlant(CustomStepWaterPlant other)
		{
			//IL_006d: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_0116: Expected I4, but got O
			StepAmount stepAmount = (amount_ = new StepAmount());
			ItemSelector itemSelector = (ItemSelector)(plantTypes_ = new ItemSelector());
			int num = 0;
			bool flag = (byte)(plantTypesCase_ = ((itemSelector != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			StepAmount stepAmount2 = other.amount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			amount_ = (StepAmount)num;
			GridLocationFilter gridLocationFilter2 = other.filter_;
			if (gridLocationFilter2 != null)
			{
				GridLocationFilter gridLocationFilter3 = gridLocationFilter2.Clone();
			}
			filter_ = (GridLocationFilter)num;
			bool flag2 = (useDifferentItem_ = other.useDifferentItem_);
			bool flag3 = (generateMissing_ = other.generateMissing_);
			int num2 = (generateRadius_ = other.generateRadius_);
			ItemSelector itemSelector2 = default(ItemSelector);
			if (other.plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
			{
				PlantTypesOneofCase plantTypesOneofCase = other.plantTypesCase_;
				if (other.plantTypes_ == null)
				{
					throw new InvalidCastException();
				}
				plantTypes_ = itemSelector2;
				bool flag4 = (byte)(plantTypesCase_ = ((itemSelector2 != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			}
			if ((long)itemSelector2 == 2)
			{
				PlantTypesOneofCase plantTypesOneofCase2 = other.plantTypesCase_;
				if (other.plantTypes_ == null)
				{
					throw new InvalidCastException();
				}
				ItemSelector itemSelector3 = default(ItemSelector);
				plantTypes_ = itemSelector3;
				plantTypesCase_ = (PlantTypesOneofCase)itemSelector3;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E8A")]
		[Cpp2IlInjected.Address(RVA = "0x3565FC0", Offset = "0x35649C0", VA = "0x183565FC0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepWaterPlant Clone()
		{
			return new CustomStepWaterPlant(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E9A")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearPlantTypes()
		{
			//IL_0010: Expected O, but got I4
			plantTypes_ = (plantTypesCase_ = PlantTypesOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E9B")]
		[Cpp2IlInjected.Address(RVA = "0x3566360", Offset = "0x3564D60", VA = "0x183566360", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CustomStepWaterPlant)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E9C")]
		[Cpp2IlInjected.Address(RVA = "0x35661E0", Offset = "0x3564BE0", VA = "0x1835661E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepWaterPlant other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					object obj = plantTypes_;
					if (obj != null && obj == null)
					{
						goto IL_010b;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					obj2 = other.plantTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemSelector cropItem = CropItem;
					ItemSelector cropItem2 = other.CropItem;
					if (object.Equals(cropItem, cropItem2))
					{
						StepAmount objB = other.amount_;
						if (object.Equals(amount_, objB))
						{
							GridLocationFilter objB2 = other.filter_;
							if (object.Equals(filter_, objB2))
							{
								bool flag = other.useDifferentItem_;
								if (useDifferentItem_ == flag)
								{
									bool flag2 = other.generateMissing_;
									if (generateMissing_ == flag2)
									{
										int num2 = other.generateRadius_;
										if (generateRadius_ == num2)
										{
											PlantTypesOneofCase plantTypesOneofCase = other.plantTypesCase_;
											if (plantTypesCase_ == plantTypesOneofCase)
											{
												UnknownFieldSet unknownFields = other._unknownFields;
												bool flag3 = object.Equals(_unknownFields, unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			goto IL_010b;
			IL_010b:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E9D")]
		[Cpp2IlInjected.Address(RVA = "0x3566540", Offset = "0x3564F40", VA = "0x183566540", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009f
			PlantTypesOneofCase plantTypesOneofCase = plantTypesCase_;
			int num = 0;
			if (plantTypesOneofCase == PlantTypesOneofCase.FlowerItem)
			{
				object obj = plantTypes_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (plantTypesOneofCase == PlantTypesOneofCase.CropItem)
			{
				object obj2 = plantTypes_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			StepAmount stepAmount = amount_;
			if (stepAmount != null)
			{
				int hashCode3 = stepAmount.GetHashCode();
			}
			GridLocationFilter gridLocationFilter = filter_;
			if (gridLocationFilter != null)
			{
				int hashCode4 = gridLocationFilter.GetHashCode();
			}
			if (useDifferentItem_)
			{
			}
			if (generateMissing_)
			{
			}
			if (generateRadius_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E9E")]
		[Cpp2IlInjected.Address(RVA = "0x35671B0", Offset = "0x3565BB0", VA = "0x1835671B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E9F")]
		[Cpp2IlInjected.Address(RVA = "0x3567210", Offset = "0x3565C10", VA = "0x183567210", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00e5
			//IL_002f: Expected O, but got I4
			PlantTypesOneofCase plantTypesOneofCase = plantTypesCase_;
			int num = 0;
			if (plantTypesOneofCase == PlantTypesOneofCase.FlowerItem)
			{
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					object obj = plantTypes_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (plantTypesOneofCase == PlantTypesOneofCase.CropItem && plantTypesCase_ == PlantTypesOneofCase.CropItem)
			{
				object obj2 = plantTypes_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if ((long)amount_ != 0)
			{
				StepAmount value = amount_;
				output.WriteMessage(value);
			}
			if ((long)filter_ != 0)
			{
				GridLocationFilter value2 = filter_;
				output.WriteMessage(value2);
			}
			if (useDifferentItem_)
			{
				bool value3 = useDifferentItem_;
				output.WriteBool(value3);
			}
			if (generateMissing_)
			{
				bool value4 = generateMissing_;
				output.WriteBool(value4);
			}
			if (generateRadius_ != 0)
			{
				int value5 = generateRadius_;
				output.WriteInt32(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA0")]
		[Cpp2IlInjected.Address(RVA = "0x3565C90", Offset = "0x3564690", VA = "0x183565C90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
			{
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					object obj = plantTypes_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (plantTypesCase_ == PlantTypesOneofCase.CropItem)
			{
				if (plantTypesCase_ == PlantTypesOneofCase.CropItem)
				{
					object obj2 = plantTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			StepAmount stepAmount = amount_;
			if (stepAmount != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num4++;
				num += num4;
			}
			GridLocationFilter gridLocationFilter = filter_;
			if (gridLocationFilter != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(gridLocationFilter);
				num5++;
				num += num5;
			}
			int num6 = generateRadius_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
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

		[Cpp2IlInjected.Token(Token = "0x6003EA1")]
		[Cpp2IlInjected.Address(RVA = "0x35667B0", Offset = "0x35651B0", VA = "0x1835667B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepWaterPlant other)
		{
			//IL_0193: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.amount_ != 0)
			{
				StepAmount stepAmount = amount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amount_ = new StepAmount());
					StepAmount stepAmount3 = amount_;
				}
				StepAmount other2 = other.amount_;
				stepAmount.MergeFrom(other2);
			}
			if ((long)other.filter_ != 0)
			{
				GridLocationFilter gridLocationFilter2 = default(GridLocationFilter);
				if (filter_ == null)
				{
					GridLocationFilter gridLocationFilter = (filter_ = new GridLocationFilter());
					gridLocationFilter2 = filter_;
				}
				GridLocationFilter other3 = other.filter_;
				gridLocationFilter2.MergeFrom(other3);
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			bool flag2 = other.generateMissing_;
			if (flag2)
			{
				generateMissing_ = flag2;
			}
			int num = other.generateRadius_;
			if (num != 0)
			{
				generateRadius_ = num;
			}
			if (other.plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
			{
				object obj = default(object);
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					obj = plantTypes_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					bool flag3 = (byte)(plantTypesCase_ = (((plantTypes_ = new ItemSelector()) != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
				}
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					object obj2 = plantTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					object obj3 = other.plantTypes_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(StepAmount).TypeHandle != 2)
			{
			}
			if (CropItem == null)
			{
				plantTypesCase_ = (PlantTypesOneofCase)(plantTypes_ = new ItemSelector());
			}
			ItemSelector cropItem = CropItem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA2")]
		[Cpp2IlInjected.Address(RVA = "0x3566AD0", Offset = "0x35654D0", VA = "0x183566AD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0130: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 40)
				{
					if (num == 80)
					{
						bool flag = (generateMissing_ = input.ReadBool());
					}
					if (num != 88)
					{
						goto IL_0163;
					}
					int num2 = (generateRadius_ = input.ReadInt32());
				}
				GridLocationFilter gridLocationFilter = default(GridLocationFilter);
				if (num == 34)
				{
					GridLocationFilter builder = default(GridLocationFilter);
					if (filter_ == null)
					{
						gridLocationFilter = (filter_ = new GridLocationFilter());
						builder = filter_;
					}
					input.ReadMessage(builder);
				}
				if ((long)gridLocationFilter != 40)
				{
					goto IL_0163;
				}
				bool flag2 = (useDifferentItem_ = input.ReadBool());
			}
			bool flag3 = default(bool);
			if (num == 10)
			{
				ItemSelector itemSelector = new ItemSelector();
				if (plantTypesCase_ == PlantTypesOneofCase.FlowerItem)
				{
					if (plantTypesCase_ != PlantTypesOneofCase.FlowerItem)
					{
					}
					object obj = plantTypes_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemSelector);
				plantTypes_ = itemSelector;
				flag3 = (byte)(plantTypesCase_ = ((itemSelector != null) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			}
			if (flag3)
			{
				ItemSelector builder2 = new ItemSelector();
				if (plantTypesCase_ == PlantTypesOneofCase.CropItem)
				{
					if (plantTypesCase_ != PlantTypesOneofCase.CropItem)
					{
					}
					object obj2 = plantTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				plantTypes_ = builder2;
				plantTypesCase_ = (PlantTypesOneofCase)typeof(ItemSelector).TypeHandle;
			}
			if ((long)typeof(ItemSelector).TypeHandle == 26)
			{
				StepAmount builder3 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					builder3 = amount_;
				}
				input.ReadMessage(builder3);
			}
			goto IL_0163;
			IL_0163:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA3")]
		[Cpp2IlInjected.Address(RVA = "0x35663C0", Offset = "0x3564DC0", VA = "0x1835663C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				ItemSelector flowerItem = FlowerItem;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA4")]
		[Cpp2IlInjected.Address(RVA = "0x3566F00", Offset = "0x3565900", VA = "0x183566F00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028, IL_002c, IL_0030, IL_0031, IL_0035, IL_0039, IL_003d, IL_0041, IL_0042, IL_0043, IL_0044, IL_0050, IL_0056, IL_005c
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				plantTypes_ = num;
				bool flag = (byte)(plantTypesCase_ = ((num != 0) ? PlantTypesOneofCase.FlowerItem : PlantTypesOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA5")]
		[Cpp2IlInjected.Address(RVA = "0x3565E90", Offset = "0x3564890", VA = "0x183565E90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000f, IL_0017, IL_001f
			//IL_000e: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			if (fieldNumber <= 10)
			{
				plantTypesCase_ = PlantTypesOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA6")]
		[Cpp2IlInjected.Address(RVA = "0x3566700", Offset = "0x3565100", VA = "0x183566700", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "PlantTypes"))
			{
				PlantTypesOneofCase plantTypesOneofCase = plantTypesCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EA7")]
		[Cpp2IlInjected.Address(RVA = "0x3565F50", Offset = "0x3564950", VA = "0x183565F50", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "PlantTypes"))
			{
				plantTypes_ = (plantTypesCase_ = PlantTypesOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EAB")]
		[Cpp2IlInjected.Address(RVA = "0x3566020", Offset = "0x3564A20", VA = "0x183566020", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0098
			do
			{
				if (plantTypesCase_ == PlantTypesOneofCase.None)
				{
					string missionStepName = context.MissionStepName;
					string error = "Please select a Plant type for " + missionStepName + " step";
					context.AddError(error);
				}
				if (!useDifferentItem_)
				{
					if (context.IsMissionStep && amount_.IsValueSmallerThen(1))
					{
						string missionStepName2 = context.MissionStepName;
						string message = "Should be 1+ in " + missionStepName2;
						context.AddInvalidMemberError(message, "Amount");
					}
					break;
				}
				if (ItemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item || ItemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.ItemGenerator)
				{
				}
			}
			while (!amount_.IsValueSmallerThen(2));
		}

		[Cpp2IlInjected.Token(Token = "0x6003EAC")]
		[Cpp2IlInjected.Address(RVA = "0x3567410", Offset = "0x3565E10", VA = "0x183567410")]
		static CustomStepWaterPlant()
		{
			Func<CustomStepWaterPlant> func = default(Func<CustomStepWaterPlant>);
			_parser = (MessageParser<CustomStepWaterPlant>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
