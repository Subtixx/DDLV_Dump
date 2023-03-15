using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005A8")]
	public sealed class CollectionFurniture : IMessage<CollectionFurniture>, IMessage, IEquatable<CollectionFurniture>, IDeepCloneable<CollectionFurniture>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005A9")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F01")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001F02")]
			Sets,
			[Cpp2IlInjected.Token(Token = "0x4001F03")]
			Universe
		}

		[Cpp2IlInjected.Token(Token = "0x4001EFA")]
		private static readonly MessageParser<CollectionFurniture> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001EFB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001EFC")]
		public const int SetsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001EFD")]
		public const int UniverseFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001EFE")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001EFF")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.Token(Token = "0x17001253")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionFurniture> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60046BE")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB3D0", Offset = "0x2EC9DD0", VA = "0x182ECB3D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001254")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046BF")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB300", Offset = "0x2EC9D00", VA = "0x182ECB300")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001255")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046C0")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB500", Offset = "0x2EC9F00", VA = "0x182ECB500", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001256")]
		[DebuggerNonUserCode]
		public CollectionFurnitureSet Sets
		{
			[Cpp2IlInjected.Token(Token = "0x60046C4")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB430", Offset = "0x2EC9E30", VA = "0x182ECB430")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Sets)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60046C5")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				type_ = value;
				bool flag = (byte)(typeCase_ = ((value != null) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001257")]
		[DebuggerNonUserCode]
		public int Universe
		{
			[Cpp2IlInjected.Token(Token = "0x60046C6")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB490", Offset = "0x2EC9E90", VA = "0x182ECB490")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (typeCase_ == TypeOneofCase.Universe)
				{
					object obj = type_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60046C7")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB610", Offset = "0x2ECA010", VA = "0x182ECB610")]
			set
			{
				//IL_0014: Expected I4, but got I8
				type_ = typeof(int).TypeHandle;
				typeCase_ = TypeOneofCase.Universe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001258")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60046C8")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046C1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionFurniture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60046C2")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB170", Offset = "0x2EC9B70", VA = "0x182ECB170")]
		[DebuggerNonUserCode]
		public CollectionFurniture(CollectionFurniture other)
		{
			//IL_0046: Expected I4, but got I8
			TypeOneofCase typeOneofCase = other.typeCase_;
			if (typeOneofCase == TypeOneofCase.Sets)
			{
				TypeOneofCase typeOneofCase2 = other.typeCase_;
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				RepeatedField<> list_ = default(RepeatedField<>);
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				type_ = new CollectionFurnitureSet
				{
					list_ = (RepeatedField<int>)(object)list_,
					_unknownFields = unknownFields
				};
				typeCase_ = TypeOneofCase.Sets;
			}
			if (typeOneofCase == TypeOneofCase.Universe)
			{
				int num = (Universe = other.Universe);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046C3")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA4B0", Offset = "0x2EC8EB0", VA = "0x182ECA4B0", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionFurniture Clone()
		{
			return new CollectionFurniture(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60046C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60046CA")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA510", Offset = "0x2EC8F10", VA = "0x182ECA510", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0069: Expected O, but got I4
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (typeCase_ == TypeOneofCase.Sets)
					{
						object obj = type_;
						if (obj != null && obj == null)
						{
							goto IL_006e;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(CollectionFurnitureSet).TypeHandle != null && (object)typeof(CollectionFurnitureSet).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						int universe = Universe;
						int num2 = 0;
						int num3 = default(int);
						if (universe == num3 && typeCase_ == (TypeOneofCase)num3)
						{
							bool flag2 = object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			goto IL_006e;
			IL_006e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA670", Offset = "0x2EC9070", VA = "0x182ECA670", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionFurniture other)
		{
			//IL_004d: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Sets)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						goto IL_0090;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.typeCase_ == TypeOneofCase.Sets)
				{
					obj2 = other.type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int universe = Universe;
					int universe2 = other.Universe;
					if (universe == universe2)
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
			goto IL_0090;
			IL_0090:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA8A0", Offset = "0x2EC92A0", VA = "0x182ECA8A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004c
			TypeOneofCase typeOneofCase = typeCase_;
			int num = 0;
			if (typeOneofCase == TypeOneofCase.Sets)
			{
				object obj = type_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (typeOneofCase == TypeOneofCase.Universe && typeCase_ == TypeOneofCase.Universe)
			{
				object obj2 = type_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60046CD")]
		[Cpp2IlInjected.Address(RVA = "0x2ECAF20", Offset = "0x2EC9920", VA = "0x182ECAF20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60046CE")]
		[Cpp2IlInjected.Address(RVA = "0x2ECAF80", Offset = "0x2EC9980", VA = "0x182ECAF80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			//IL_002c: Expected O, but got I4
			TypeOneofCase typeOneofCase = typeCase_;
			if (typeOneofCase == TypeOneofCase.Sets)
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Sets)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (typeOneofCase == TypeOneofCase.Universe)
			{
				int universe = Universe;
				output.WriteInt32(universe);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60046CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA250", Offset = "0x2EC8C50", VA = "0x182ECA250", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0069
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (typeCase_ == TypeOneofCase.Sets)
			{
				if (typeCase_ == TypeOneofCase.Sets)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (typeCase_ == TypeOneofCase.Universe)
			{
				if (typeCase_ == TypeOneofCase.Universe)
				{
					object obj2 = type_;
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

		[Cpp2IlInjected.Token(Token = "0x60046D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ECAA80", Offset = "0x2EC9480", VA = "0x182ECAA80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionFurniture other)
		{
			if (other == null)
			{
				return;
			}
			TypeOneofCase typeOneofCase = other.typeCase_;
			if (typeOneofCase == TypeOneofCase.Sets)
			{
				TypeOneofCase typeOneofCase2 = typeCase_;
				int num = 0;
				if (typeOneofCase2 == TypeOneofCase.Sets)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(typeCase_ = (((type_ = new CollectionFurnitureSet()) != null) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
				}
				if (typeCase_ == TypeOneofCase.Sets)
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
				object obj3 = default(object);
				if (other.typeCase_ == TypeOneofCase.Sets)
				{
					obj3 = other.type_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj3 == null)
				{
					goto IL_00ae;
				}
			}
			if (typeOneofCase == TypeOneofCase.Universe)
			{
				int num2 = (Universe = other.Universe);
			}
			goto IL_00ae;
			IL_00ae:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60046D1")]
		[Cpp2IlInjected.Address(RVA = "0x2ECACC0", Offset = "0x2EC96C0", VA = "0x182ECACC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				CollectionFurnitureSet collectionFurnitureSet = new CollectionFurnitureSet();
				if (typeCase_ == TypeOneofCase.Sets)
				{
					if (typeCase_ != TypeOneofCase.Sets)
					{
					}
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(collectionFurnitureSet);
				type_ = collectionFurnitureSet;
				bool flag = (byte)(typeCase_ = ((collectionFurnitureSet != null) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
			}
			if (num == 16)
			{
				int num3 = (Universe = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60046D2")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA790", Offset = "0x2EC9190", VA = "0x182ECA790", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (typeCase_ == TypeOneofCase.Sets)
			{
				object obj = type_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0037;
				}
			}
			goto IL_0027;
			IL_001c:
			if (fieldNumber == 2)
			{
				int universe = Universe;
			}
			goto IL_0027;
			IL_0037:
			throw new InvalidCastException();
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x60046D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ECAE30", Offset = "0x2EC9830", VA = "0x182ECAE30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				type_ = num;
				bool flag = (byte)(typeCase_ = ((num != 0) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA3B0", Offset = "0x2EC8DB0", VA = "0x182ECA3B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_0019: Expected O, but got I4
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				typeCase_ = TypeOneofCase.None;
				break;
			case 2:
			{
				int num = default(int);
				type_ = num;
				typeCase_ = TypeOneofCase.Universe;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA9D0", Offset = "0x2EC93D0", VA = "0x182ECA9D0", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60046D6")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA440", Offset = "0x2EC8E40", VA = "0x182ECA440", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB060", Offset = "0x2EC9A60", VA = "0x182ECB060")]
		static CollectionFurniture()
		{
			Func<CollectionFurniture> func = default(Func<CollectionFurniture>);
			_parser = (MessageParser<CollectionFurniture>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
