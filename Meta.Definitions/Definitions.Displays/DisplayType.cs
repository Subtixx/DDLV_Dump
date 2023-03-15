using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x200074C")]
	public sealed class DisplayType : IMessage<DisplayType>, IMessage, IEquatable<DisplayType>, IDeepCloneable<DisplayType>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200074D")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400247E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400247F")]
			StoreStage,
			[Cpp2IlInjected.Token(Token = "0x4002480")]
			StoreShelf
		}

		[Cpp2IlInjected.Token(Token = "0x4002477")]
		private static readonly MessageParser<DisplayType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002478")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002479")]
		public const int StoreStageFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400247A")]
		public const int StoreShelfFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400247B")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400247C")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.Token(Token = "0x1700147F")]
		[DebuggerNonUserCode]
		public static MessageParser<DisplayType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60050A8")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D340", Offset = "0x2C4BD40", VA = "0x182C4D340")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001480")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60050A9")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D270", Offset = "0x2C4BC70", VA = "0x182C4D270")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001481")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60050AA")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D460", Offset = "0x2C4BE60", VA = "0x182C4D460", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001482")]
		[DebuggerNonUserCode]
		public StoreStage StoreStage
		{
			[Cpp2IlInjected.Token(Token = "0x60050AE")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D400", Offset = "0x2C4BE00", VA = "0x182C4D400")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.StoreStage)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60050AF")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				type_ = value;
				bool flag = (byte)(typeCase_ = ((value != null) ? TypeOneofCase.StoreStage : TypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001483")]
		[DebuggerNonUserCode]
		public StoreShelf StoreShelf
		{
			[Cpp2IlInjected.Token(Token = "0x60050B0")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D3A0", Offset = "0x2C4BDA0", VA = "0x182C4D3A0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.StoreShelf)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60050B1")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001484")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60050B2")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050AB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DisplayType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D110", Offset = "0x2C4BB10", VA = "0x182C4D110")]
		[DebuggerNonUserCode]
		public DisplayType(DisplayType other)
		{
			//IL_005c: Expected I4, but got O
			TypeOneofCase typeOneofCase = other.typeCase_;
			if (typeOneofCase == TypeOneofCase.StoreStage)
			{
				TypeOneofCase typeOneofCase2 = other.typeCase_;
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				StoreStage storeStage = default(StoreStage);
				type_ = storeStage;
				bool flag = (byte)(typeCase_ = ((storeStage != null) ? TypeOneofCase.StoreStage : TypeOneofCase.None)) != 0;
			}
			if (typeOneofCase == TypeOneofCase.StoreShelf)
			{
				TypeOneofCase typeOneofCase3 = other.typeCase_;
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				StoreShelf storeShelf = default(StoreShelf);
				type_ = storeShelf;
				typeCase_ = (TypeOneofCase)storeShelf;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C210", Offset = "0x2C4AC10", VA = "0x182C4C210", Slot = "10")]
		[DebuggerNonUserCode]
		public DisplayType Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_005e: Expected I4, but got O
			DisplayType displayType = new DisplayType();
			TypeOneofCase typeOneofCase = typeCase_;
			if (typeOneofCase == TypeOneofCase.StoreStage)
			{
				TypeOneofCase typeOneofCase2 = typeCase_;
				if (type_ == null)
				{
					throw new InvalidCastException();
				}
				StoreStage storeStage = default(StoreStage);
				displayType.type_ = storeStage;
				bool flag = (byte)(displayType.typeCase_ = ((storeStage != null) ? TypeOneofCase.StoreStage : TypeOneofCase.None)) != 0;
			}
			if (typeOneofCase == TypeOneofCase.StoreShelf)
			{
				TypeOneofCase typeOneofCase3 = typeCase_;
				if (type_ == null)
				{
					throw new InvalidCastException();
				}
				StoreShelf storeShelf = default(StoreShelf);
				displayType.type_ = storeShelf;
				displayType.typeCase_ = (TypeOneofCase)storeShelf;
			}
			UnknownFieldSet unknownFieldSet = (displayType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return displayType;
		}

		[Cpp2IlInjected.Token(Token = "0x60050B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60050B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C4D0", Offset = "0x2C4AED0", VA = "0x182C4C4D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (typeCase_ == TypeOneofCase.StoreStage)
					{
						object obj = type_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(StoreStage).TypeHandle != null && (object)typeof(StoreStage).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						StoreShelf objB = default(StoreShelf);
						bool flag2 = object.Equals(StoreShelf, objB);
						if (flag2 && typeCase_ == (flag2 ? TypeOneofCase.StoreStage : TypeOneofCase.None))
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

		[Cpp2IlInjected.Token(Token = "0x60050B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C3A0", Offset = "0x2C4ADA0", VA = "0x182C4C3A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DisplayType other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.StoreStage)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.typeCase_ == TypeOneofCase.StoreStage)
				{
					obj2 = other.type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					StoreShelf storeShelf = StoreShelf;
					StoreShelf storeShelf2 = other.StoreShelf;
					if (object.Equals(storeShelf, storeShelf2))
					{
						TypeOneofCase typeOneofCase = other.typeCase_;
						if (typeCase_ == typeOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x60050B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C750", Offset = "0x2C4B150", VA = "0x182C4C750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			TypeOneofCase typeOneofCase = typeCase_;
			int num = 0;
			if (typeOneofCase == TypeOneofCase.StoreStage)
			{
				object obj = type_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (typeOneofCase == TypeOneofCase.StoreShelf)
			{
				object obj2 = type_;
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

		[Cpp2IlInjected.Token(Token = "0x60050B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CE70", Offset = "0x2C4B870", VA = "0x182C4CE70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60050B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CED0", Offset = "0x2C4B8D0", VA = "0x182C4CED0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			TypeOneofCase typeOneofCase = typeCase_;
			int num = 0;
			if (typeOneofCase == TypeOneofCase.StoreStage)
			{
				if (typeCase_ == TypeOneofCase.StoreStage)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (typeOneofCase == TypeOneofCase.StoreShelf && typeCase_ == TypeOneofCase.StoreShelf)
			{
				object obj2 = type_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60050B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C050", Offset = "0x2C4AA50", VA = "0x182C4C050", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (typeCase_ == TypeOneofCase.StoreStage)
			{
				if (typeCase_ == TypeOneofCase.StoreStage)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (typeCase_ == TypeOneofCase.StoreShelf)
			{
				if (typeCase_ == TypeOneofCase.StoreShelf)
				{
					object obj2 = type_;
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

		[Cpp2IlInjected.Token(Token = "0x60050BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C930", Offset = "0x2C4B330", VA = "0x182C4C930", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DisplayType other)
		{
			//IL_00dd: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.typeCase_ == TypeOneofCase.StoreStage)
			{
				TypeOneofCase typeOneofCase = typeCase_;
				int num = 0;
				if (typeOneofCase == TypeOneofCase.StoreStage)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(typeCase_ = (((type_ = new StoreStage()) != null) ? TypeOneofCase.StoreStage : TypeOneofCase.None)) != 0;
				}
				if (typeCase_ == TypeOneofCase.StoreStage)
				{
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.typeCase_ == TypeOneofCase.StoreStage)
				{
					object obj3 = other.type_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(StoreStage).TypeHandle != 2)
			{
			}
			if (StoreShelf == null)
			{
				typeCase_ = (TypeOneofCase)(type_ = new StoreShelf());
			}
			StoreShelf other2 = default(StoreShelf);
			StoreShelf.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CB80", Offset = "0x2C4B580", VA = "0x182C4CB80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				StoreStage storeStage = new StoreStage();
				if (typeCase_ == TypeOneofCase.StoreStage)
				{
					if (typeCase_ != TypeOneofCase.StoreStage)
					{
					}
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(storeStage);
				type_ = storeStage;
				bool flag = (byte)(typeCase_ = ((storeStage != null) ? TypeOneofCase.StoreStage : TypeOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				StoreShelf builder = new StoreShelf();
				if (typeCase_ == TypeOneofCase.StoreShelf)
				{
					if (typeCase_ != TypeOneofCase.StoreShelf)
					{
					}
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				type_ = builder;
				typeCase_ = (TypeOneofCase)typeof(StoreShelf).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60050BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C640", Offset = "0x2C4B040", VA = "0x182C4C640", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (typeCase_ == TypeOneofCase.StoreStage)
			{
				object obj = type_;
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
			if (fieldNumber == 2)
			{
				if (typeCase_ == TypeOneofCase.StoreShelf)
				{
					obj2 = type_;
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

		[Cpp2IlInjected.Token(Token = "0x60050BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CD80", Offset = "0x2C4B780", VA = "0x182C4CD80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0043: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				type_ = num;
				bool flag = (byte)(typeCase_ = ((num != 0) ? TypeOneofCase.StoreStage : TypeOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				type_ = value;
				typeCase_ = (TypeOneofCase)typeof(StoreStage).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050BE")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				typeCase_ = TypeOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C880", Offset = "0x2C4B280", VA = "0x182C4C880", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				TypeOneofCase typeOneofCase = typeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60050C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C1A0", Offset = "0x2C4ABA0", VA = "0x182C4C1A0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D000", Offset = "0x2C4BA00", VA = "0x182C4D000")]
		static DisplayType()
		{
			Func<DisplayType> func = default(Func<DisplayType>);
			_parser = (MessageParser<DisplayType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
