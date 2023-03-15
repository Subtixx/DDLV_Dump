using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004EF")]
	public sealed class CatchFishConditionType : IMessage<CatchFishConditionType>, IMessage, IEquatable<CatchFishConditionType>, IDeepCloneable<CatchFishConditionType>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004F0")]
		public enum TypesOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001A6F")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001A70")]
			Amount = 4,
			[Cpp2IlInjected.Token(Token = "0x4001A71")]
			TotalWeight = 6
		}

		[Cpp2IlInjected.Token(Token = "0x4001A68")]
		private static readonly MessageParser<CatchFishConditionType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A69")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A6A")]
		public const int AmountFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001A6B")]
		public const int TotalWeightFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A6C")]
		private object types_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A6D")]
		private TypesOneofCase typesCase_;

		[Cpp2IlInjected.Token(Token = "0x17000F9A")]
		[DebuggerNonUserCode]
		public static MessageParser<CatchFishConditionType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003CE5")]
			[Cpp2IlInjected.Address(RVA = "0x2895BE0", Offset = "0x28945E0", VA = "0x182895BE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003CE6")]
			[Cpp2IlInjected.Address(RVA = "0x2895B10", Offset = "0x2894510", VA = "0x182895B10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003CE7")]
			[Cpp2IlInjected.Address(RVA = "0x2895CA0", Offset = "0x28946A0", VA = "0x182895CA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9D")]
		[DebuggerNonUserCode]
		public CatchFishConditionAmount Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003CEC")]
			[Cpp2IlInjected.Address(RVA = "0x2895AB0", Offset = "0x28944B0", VA = "0x182895AB0")]
			get
			{
				int num = 0;
				if (typesCase_ == TypesOneofCase.Amount)
				{
					object obj = types_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003CED")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				types_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9E")]
		[DebuggerNonUserCode]
		public CatchFishConditionWeight TotalWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6003CEE")]
			[Cpp2IlInjected.Address(RVA = "0x2895C40", Offset = "0x2894640", VA = "0x182895C40")]
			get
			{
				int num = 0;
				if (typesCase_ == TypesOneofCase.TotalWeight)
				{
					object obj = types_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003CEF")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				types_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9F")]
		[DebuggerNonUserCode]
		public TypesOneofCase TypesCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003CF0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return typesCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CE8")]
		[Cpp2IlInjected.Address(RVA = "0x28956D0", Offset = "0x28940D0", VA = "0x1828956D0")]
		[DebuggerNonUserCode]
		public CatchFishConditionType()
		{
			//IL_0020: Expected I4, but got O
			CatchFishConditionAmount catchFishConditionAmount = new CatchFishConditionAmount();
			catchFishConditionAmount.OnConstruction();
			types_ = catchFishConditionAmount;
			typesCase_ = (TypesOneofCase)catchFishConditionAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CE9")]
		[Cpp2IlInjected.Address(RVA = "0x28952C0", Offset = "0x2893CC0", VA = "0x1828952C0")]
		private void OnConstruction()
		{
			//IL_001a: Expected I4, but got O
			CatchFishConditionAmount catchFishConditionAmount = new CatchFishConditionAmount();
			catchFishConditionAmount.OnConstruction();
			types_ = catchFishConditionAmount;
			typesCase_ = (TypesOneofCase)catchFishConditionAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CEA")]
		[Cpp2IlInjected.Address(RVA = "0x2895750", Offset = "0x2894150", VA = "0x182895750")]
		[DebuggerNonUserCode]
		public CatchFishConditionType(CatchFishConditionType other)
		{
			//IL_0020: Expected I4, but got O
			//IL_005f: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_008b: Expected I4, but got I8
			//IL_00c7: Expected O, but got I4
			//IL_00e1: Expected I4, but got I8
			CatchFishConditionAmount catchFishConditionAmount = new CatchFishConditionAmount();
			catchFishConditionAmount.OnConstruction();
			types_ = catchFishConditionAmount;
			typesCase_ = (TypesOneofCase)catchFishConditionAmount;
			TypesOneofCase typesOneofCase = other.typesCase_;
			if (typesOneofCase == TypesOneofCase.Amount)
			{
				TypesOneofCase typesOneofCase2 = other.typesCase_;
				object obj = other.types_;
				int num = 0;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				CatchFishConditionAmount catchFishConditionAmount2 = new CatchFishConditionAmount();
				catchFishConditionAmount2.OnConstruction();
				if (catchFishConditionAmount2 != null)
				{
				}
				catchFishConditionAmount2.amountToCatch_ = (StepAmount)num;
				catchFishConditionAmount2.minWeightRequired_ = (StepAmount)num;
				StepAmount maxWeightRequired_ = default(StepAmount);
				catchFishConditionAmount2.maxWeightRequired_ = maxWeightRequired_;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				catchFishConditionAmount2._unknownFields = unknownFields;
				types_ = catchFishConditionAmount2;
				typesCase_ = TypesOneofCase.Amount;
			}
			if (typesOneofCase == TypesOneofCase.TotalWeight)
			{
				TypesOneofCase typesOneofCase3 = other.typesCase_;
				object obj2 = other.types_;
				int num2 = 0;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				CatchFishConditionWeight catchFishConditionWeight = new CatchFishConditionWeight();
				StepAmount stepAmount = (catchFishConditionWeight.totalWeightToCatch_ = new StepAmount());
				catchFishConditionWeight.totalWeightToCatch_ = (StepAmount)num2;
				UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
				catchFishConditionWeight._unknownFields = unknownFields2;
				types_ = catchFishConditionWeight;
				typesCase_ = TypesOneofCase.TotalWeight;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CEB")]
		[Cpp2IlInjected.Address(RVA = "0x2894860", Offset = "0x2893260", VA = "0x182894860", Slot = "10")]
		[DebuggerNonUserCode]
		public CatchFishConditionType Clone()
		{
			return new CatchFishConditionType(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF1")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearTypes()
		{
			//IL_0010: Expected O, but got I4
			types_ = (typesCase_ = TypesOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF2")]
		[Cpp2IlInjected.Address(RVA = "0x28948C0", Offset = "0x28932C0", VA = "0x1828948C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (typesCase_ == TypesOneofCase.Amount)
					{
						object obj = types_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(CatchFishConditionAmount).TypeHandle != null && (object)typeof(CatchFishConditionAmount).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						CatchFishConditionWeight objB = default(CatchFishConditionWeight);
						bool flag2 = object.Equals(TotalWeight, objB);
						if (flag2 && typesCase_ == (flag2 ? ((TypesOneofCase)1) : TypesOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0071;
			IL_0071:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF3")]
		[Cpp2IlInjected.Address(RVA = "0x2894A30", Offset = "0x2893430", VA = "0x182894A30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CatchFishConditionType other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (typesCase_ == TypesOneofCase.Amount)
				{
					object obj = types_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.typesCase_ == TypesOneofCase.Amount)
				{
					obj2 = other.types_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					CatchFishConditionWeight totalWeight = TotalWeight;
					CatchFishConditionWeight totalWeight2 = other.TotalWeight;
					if (object.Equals(totalWeight, totalWeight2))
					{
						TypesOneofCase typesOneofCase = other.typesCase_;
						if (typesCase_ == typesOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF4")]
		[Cpp2IlInjected.Address(RVA = "0x2894C70", Offset = "0x2893670", VA = "0x182894C70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			TypesOneofCase typesOneofCase = typesCase_;
			int num = 0;
			if (typesOneofCase == TypesOneofCase.Amount)
			{
				object obj = types_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (typesOneofCase == TypesOneofCase.TotalWeight)
			{
				object obj2 = types_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF5")]
		[Cpp2IlInjected.Address(RVA = "0x2895430", Offset = "0x2893E30", VA = "0x182895430", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF6")]
		[Cpp2IlInjected.Address(RVA = "0x2895490", Offset = "0x2893E90", VA = "0x182895490", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			TypesOneofCase typesOneofCase = typesCase_;
			int num = 0;
			if (typesOneofCase == TypesOneofCase.Amount)
			{
				if (typesCase_ == TypesOneofCase.Amount)
				{
					object obj = types_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (typesOneofCase == TypesOneofCase.TotalWeight && typesCase_ == TypesOneofCase.TotalWeight)
			{
				object obj2 = types_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF7")]
		[Cpp2IlInjected.Address(RVA = "0x2894660", Offset = "0x2893060", VA = "0x182894660", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (typesCase_ == TypesOneofCase.Amount)
			{
				if (typesCase_ == TypesOneofCase.Amount)
				{
					object obj = types_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (typesCase_ == TypesOneofCase.TotalWeight)
			{
				if (typesCase_ == TypesOneofCase.TotalWeight)
				{
					object obj2 = types_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF8")]
		[Cpp2IlInjected.Address(RVA = "0x2894E50", Offset = "0x2893850", VA = "0x182894E50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CatchFishConditionType other)
		{
			//IL_00d9: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.typesCase_ == TypesOneofCase.Amount)
			{
				TypesOneofCase typesOneofCase = typesCase_;
				int num = 0;
				if (typesOneofCase == TypesOneofCase.Amount)
				{
					object obj = types_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					CatchFishConditionAmount catchFishConditionAmount = new CatchFishConditionAmount();
					catchFishConditionAmount.OnConstruction();
					types_ = catchFishConditionAmount;
					typesCase_ = typesOneofCase;
				}
				if (typesCase_ == TypesOneofCase.Amount)
				{
					object obj2 = types_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.typesCase_ == TypesOneofCase.Amount)
				{
					object obj3 = other.types_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(CatchFishConditionWeight).TypeHandle != 6)
			{
			}
			if (TotalWeight == null)
			{
				typesCase_ = (TypesOneofCase)(types_ = new CatchFishConditionWeight());
			}
			CatchFishConditionWeight other2 = default(CatchFishConditionWeight);
			TotalWeight.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF9")]
		[Cpp2IlInjected.Address(RVA = "0x28950B0", Offset = "0x2893AB0", VA = "0x1828950B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005a: Expected I4, but got O
			//IL_00a3: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 34)
			{
				CatchFishConditionAmount catchFishConditionAmount = new CatchFishConditionAmount();
				catchFishConditionAmount.OnConstruction();
				if (typesCase_ == TypesOneofCase.Amount)
				{
					if (typesCase_ != TypesOneofCase.Amount)
					{
					}
					object obj = types_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(catchFishConditionAmount);
				types_ = catchFishConditionAmount;
				typesCase_ = (TypesOneofCase)catchFishConditionAmount;
			}
			if (num == 50)
			{
				CatchFishConditionWeight builder = new CatchFishConditionWeight();
				if (typesCase_ == TypesOneofCase.TotalWeight)
				{
					if (typesCase_ != TypesOneofCase.TotalWeight)
					{
					}
					object obj2 = types_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				types_ = builder;
				typesCase_ = (TypesOneofCase)typeof(CatchFishConditionWeight).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFA")]
		[Cpp2IlInjected.Address(RVA = "0x2894B60", Offset = "0x2893560", VA = "0x182894B60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 4)
			{
				goto IL_001c;
			}
			if (typesCase_ == TypesOneofCase.Amount)
			{
				object obj = types_;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					goto IL_001c;
				}
			}
			goto IL_0038;
			IL_0038:
			object obj2 = default(object);
			return obj2;
			IL_001c:
			if (fieldNumber == 6)
			{
				if (typesCase_ == TypesOneofCase.TotalWeight)
				{
					obj2 = types_;
					if (obj2 != null && obj2 == null)
					{
						goto IL_0040;
					}
				}
				goto IL_0038;
			}
			goto IL_0040;
			IL_0040:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFB")]
		[Cpp2IlInjected.Address(RVA = "0x2895340", Offset = "0x2893D40", VA = "0x182895340", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0020: Expected I4, but got O
			//IL_003f: Expected I4, but got O
			if (fieldNumber == 4)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				types_ = num;
				typesCase_ = (TypesOneofCase)typeof(CatchFishConditionWeight).TypeHandle;
			}
			else
			{
				while (fieldNumber != 6)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				types_ = value;
				typesCase_ = (TypesOneofCase)typeof(CatchFishConditionWeight).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFC")]
		[Cpp2IlInjected.Address(RVA = "0x28947B0", Offset = "0x28931B0", VA = "0x1828947B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 4 || fieldNumber == 6)
			{
				typesCase_ = TypesOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFD")]
		[Cpp2IlInjected.Address(RVA = "0x2894DA0", Offset = "0x28937A0", VA = "0x182894DA0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Types"))
			{
				TypesOneofCase typesOneofCase = typesCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFE")]
		[Cpp2IlInjected.Address(RVA = "0x28947F0", Offset = "0x28931F0", VA = "0x1828947F0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Types"))
			{
				types_ = (typesCase_ = TypesOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFF")]
		[Cpp2IlInjected.Address(RVA = "0x28955C0", Offset = "0x2893FC0", VA = "0x1828955C0")]
		static CatchFishConditionType()
		{
			Func<CatchFishConditionType> func = default(Func<CatchFishConditionType>);
			_parser = (MessageParser<CatchFishConditionType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
