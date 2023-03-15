using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000503")]
	public sealed class CustomStepGardeningHarvest : IMessage<CustomStepGardeningHarvest>, IMessage, IEquatable<CustomStepGardeningHarvest>, IDeepCloneable<CustomStepGardeningHarvest>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001AC2")]
		private static readonly MessageParser<CustomStepGardeningHarvest> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001AC3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001AC4")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AC5")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001AC6")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AC7")]
		private StepAmount amount_;

		[Cpp2IlInjected.Token(Token = "0x4001AC8")]
		public const int UseDifferentItemFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AC9")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x4001ACA")]
		public const int FilterFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001ACB")]
		private GridLocationFilter filter_;

		[Cpp2IlInjected.Token(Token = "0x4001ACC")]
		public const int WithFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001ACD")]
		private HangoutWithCharacter with_;

		[Cpp2IlInjected.Token(Token = "0x17000FDC")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepGardeningHarvest> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003DEB")]
			[Cpp2IlInjected.Address(RVA = "0x34EAC90", Offset = "0x34E9690", VA = "0x1834EAC90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003DEC")]
			[Cpp2IlInjected.Address(RVA = "0x34EABC0", Offset = "0x34E95C0", VA = "0x1834EABC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003DED")]
			[Cpp2IlInjected.Address(RVA = "0x34EAFE0", Offset = "0x34E99E0", VA = "0x1834EAFE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDF")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003DF2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003DF3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE0")]
		[DebuggerNonUserCode]
		public StepAmount Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003DF4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003DF5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE1")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003DF6")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003DF7")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE2")]
		[DebuggerNonUserCode]
		public GridLocationFilter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003DF8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return filter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003DF9")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				filter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE3")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter With
		{
			[Cpp2IlInjected.Token(Token = "0x6003DFA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return with_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003DFB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				with_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE4")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003E07")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE5")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E08")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return amount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE6")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003E09")]
			[Cpp2IlInjected.Address(RVA = "0x34EACF0", Offset = "0x34E96F0", VA = "0x1834EACF0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_00b7
				string[] array;
				while (true)
				{
					array = new string[6];
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
					if ("CurrentAmount" != null && "CurrentAmount" == null)
					{
						continue;
					}
					array[2] = "CurrentAmount";
					if ("CropType" != null && "CropType" == null)
					{
						continue;
					}
					array[3] = "CropType";
					if ("MinUnlockLevel" == null || "MinUnlockLevel" != null)
					{
						array[4] = "MinUnlockLevel";
						if ("MaxUnlockLevel" == null || "MaxUnlockLevel" != null)
						{
							break;
						}
					}
				}
				array[5] = "MaxUnlockLevel";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DEE")]
		[Cpp2IlInjected.Address(RVA = "0x34EA840", Offset = "0x34E9240", VA = "0x1834EA840")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DEF")]
		[Cpp2IlInjected.Address(RVA = "0x34EA2D0", Offset = "0x34E8CD0", VA = "0x1834EA2D0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DF0")]
		[Cpp2IlInjected.Address(RVA = "0x34EA990", Offset = "0x34E9390", VA = "0x1834EA990")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest(CustomStepGardeningHarvest other)
		{
			//IL_006a: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_00b6: Expected O, but got I4
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.amount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			amount_ = (StepAmount)num;
			bool flag = (useDifferentItem_ = other.useDifferentItem_);
			GridLocationFilter gridLocationFilter2 = other.filter_;
			if (gridLocationFilter2 != null)
			{
				GridLocationFilter gridLocationFilter3 = gridLocationFilter2.Clone();
			}
			filter_ = (GridLocationFilter)num;
			HangoutWithCharacter hangoutWithCharacter2 = other.with_;
			HangoutWithCharacter hangoutWithCharacter3 = default(HangoutWithCharacter);
			if (hangoutWithCharacter2 != null)
			{
				hangoutWithCharacter3 = hangoutWithCharacter2.Clone();
			}
			with_ = hangoutWithCharacter3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DF1")]
		[Cpp2IlInjected.Address(RVA = "0x34E9990", Offset = "0x34E8390", VA = "0x1834E9990", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest Clone()
		{
			return new CustomStepGardeningHarvest(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003DFC")]
		[Cpp2IlInjected.Address(RVA = "0x34E9B40", Offset = "0x34E8540", VA = "0x1834E9B40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetItem_, other))
				{
					bool flag = object.Equals(amount_, other);
					if (flag && useDifferentItem_ == flag && object.Equals(filter_, other) && object.Equals(with_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DFD")]
		[Cpp2IlInjected.Address(RVA = "0x34E9C40", Offset = "0x34E8640", VA = "0x1834E9C40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepGardeningHarvest other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.targetItem_;
				if (object.Equals(targetItem_, objB))
				{
					StepAmount objB2 = other.amount_;
					if (object.Equals(amount_, objB2))
					{
						bool flag = other.useDifferentItem_;
						if (useDifferentItem_ == flag)
						{
							GridLocationFilter objB3 = other.filter_;
							if (object.Equals(filter_, objB3))
							{
								HangoutWithCharacter objB4 = other.with_;
								if (object.Equals(with_, objB4))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DFE")]
		[Cpp2IlInjected.Address(RVA = "0x34E9E00", Offset = "0x34E8800", VA = "0x1834E9E00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				if (useDifferentItem_)
				{
				}
				GridLocationFilter gridLocationFilter = filter_;
				if (gridLocationFilter != null)
				{
					int hashCode3 = gridLocationFilter.GetHashCode();
				}
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int hashCode4 = hangoutWithCharacter.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DFF")]
		[Cpp2IlInjected.Address(RVA = "0x34EA5C0", Offset = "0x34E8FC0", VA = "0x1834EA5C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E00")]
		[Cpp2IlInjected.Address(RVA = "0x34EA620", Offset = "0x34E9020", VA = "0x1834EA620", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0093
			if ((long)targetItem_ != 0)
			{
				ItemSelector value = targetItem_;
				output.WriteMessage(value);
			}
			if ((long)amount_ != 0)
			{
				StepAmount value2 = amount_;
				output.WriteMessage(value2);
			}
			if (useDifferentItem_)
			{
				bool value3 = useDifferentItem_;
				output.WriteBool(value3);
			}
			if ((long)filter_ != 0)
			{
				GridLocationFilter value4 = filter_;
				output.WriteMessage(value4);
			}
			if ((long)with_ != 0)
			{
				HangoutWithCharacter value5 = with_;
				output.WriteMessage(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E01")]
		[Cpp2IlInjected.Address(RVA = "0x34E97E0", Offset = "0x34E81E0", VA = "0x1834E97E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetItem_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num3++;
					num += num3;
				}
				GridLocationFilter gridLocationFilter = filter_;
				if (gridLocationFilter != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(gridLocationFilter);
					num4++;
					num += num4;
				}
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(hangoutWithCharacter);
					num5++;
					num += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E02")]
		[Cpp2IlInjected.Address(RVA = "0x34E9EE0", Offset = "0x34E88E0", VA = "0x1834E9EE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepGardeningHarvest other)
		{
			//Discarded unreachable code: IL_0128
			if (other == null)
			{
				return;
			}
			if ((long)other.targetItem_ != 0)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetItem_ = new ItemSelector());
					ItemSelector itemSelector3 = targetItem_;
				}
				ItemSelector other2 = other.targetItem_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.amount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					stepAmount2 = amount_;
				}
				StepAmount other3 = other.amount_;
				stepAmount2.MergeFrom(other3);
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			if ((long)other.filter_ != 0)
			{
				GridLocationFilter gridLocationFilter2 = default(GridLocationFilter);
				if (filter_ == null)
				{
					GridLocationFilter gridLocationFilter = (filter_ = new GridLocationFilter());
					gridLocationFilter2 = filter_;
				}
				GridLocationFilter other4 = other.filter_;
				gridLocationFilter2.MergeFrom(other4);
			}
			if ((long)other.with_ != 0)
			{
				HangoutWithCharacter hangoutWithCharacter2 = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					hangoutWithCharacter2 = with_;
				}
				HangoutWithCharacter other5 = other.with_;
				hangoutWithCharacter2.MergeFrom(other5);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E03")]
		[Cpp2IlInjected.Address(RVA = "0x34EA0D0", Offset = "0x34E8AD0", VA = "0x1834EA0D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00fa
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (useDifferentItem_ = input.ReadBool());
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
				if ((long)gridLocationFilter != 42)
				{
					goto IL_00e3;
				}
				HangoutWithCharacter builder2 = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					builder2 = with_;
				}
				input.ReadMessage(builder2);
			}
			ItemSelector itemSelector = default(ItemSelector);
			if (num == 10)
			{
				ItemSelector builder3 = default(ItemSelector);
				if (targetItem_ == null)
				{
					itemSelector = (targetItem_ = new ItemSelector());
					builder3 = targetItem_;
				}
				input.ReadMessage(builder3);
			}
			if ((long)itemSelector == 18)
			{
				StepAmount builder4 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					builder4 = amount_;
				}
				input.ReadMessage(builder4);
			}
			goto IL_00e3;
			IL_00e3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E04")]
		[Cpp2IlInjected.Address(RVA = "0x34E9CF0", Offset = "0x34E86F0", VA = "0x1834E9CF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							HangoutWithCharacter hangoutWithCharacter = with_;
						}
						GridLocationFilter gridLocationFilter = filter_;
					}
					bool flag = useDifferentItem_;
				}
				StepAmount stepAmount = amount_;
			}
			ItemSelector itemSelector = targetItem_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E05")]
		[Cpp2IlInjected.Address(RVA = "0x34EA410", Offset = "0x34E8E10", VA = "0x1834EA410", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			//IL_0039: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								with_ = (HangoutWithCharacter)num2;
								return;
							}
							throw new InvalidCastException();
						}
						default:
							return;
						case 0:
							break;
						}
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
					}
					object obj = default(object);
					useDifferentItem_ = (byte)(int)obj != 0;
					return;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E06")]
		[Cpp2IlInjected.Address(RVA = "0x34E9920", Offset = "0x34E8320", VA = "0x1834E9920", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E0A")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "17")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			amount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E0B")]
		[Cpp2IlInjected.Address(RVA = "0x34E99F0", Offset = "0x34E83F0", VA = "0x1834E99F0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0080
			do
			{
				if (!useDifferentItem_)
				{
					if (amount_.IsValueSmallerThen(1) && context.IsMissionStep)
					{
						string missionStepName = context.MissionStepName;
						string message = "Should be 1+ in " + missionStepName;
						context.AddInvalidMemberError(message, "Amount");
					}
					return;
				}
				if (targetItem_.itemSelectorCase_ == (ItemSelector.ItemSelectorOneofCase)(-3))
				{
					context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
				}
			}
			while (!amount_.IsValueSmallerThen(2));
			context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "Amount");
		}

		[Cpp2IlInjected.Token(Token = "0x6003E0C")]
		[Cpp2IlInjected.Address(RVA = "0x34EA730", Offset = "0x34E9130", VA = "0x1834EA730")]
		static CustomStepGardeningHarvest()
		{
			Func<CustomStepGardeningHarvest> func = default(Func<CustomStepGardeningHarvest>);
			_parser = (MessageParser<CustomStepGardeningHarvest>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
