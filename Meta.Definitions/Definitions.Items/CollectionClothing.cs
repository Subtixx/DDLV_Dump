using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005AD")]
	public sealed class CollectionClothing : IMessage<CollectionClothing>, IMessage, IEquatable<CollectionClothing>, IDeepCloneable<CollectionClothing>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005AE")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F12")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001F13")]
			Sets,
			[Cpp2IlInjected.Token(Token = "0x4001F14")]
			Universe
		}

		[Cpp2IlInjected.Token(Token = "0x4001F0B")]
		private static readonly MessageParser<CollectionClothing> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F0C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F0D")]
		public const int SetsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F0E")]
		public const int UniverseFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F0F")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F10")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.Token(Token = "0x1700125D")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionClothing> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60046F1")]
			[Cpp2IlInjected.Address(RVA = "0x2EC79B0", Offset = "0x2EC63B0", VA = "0x182EC79B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700125E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046F2")]
			[Cpp2IlInjected.Address(RVA = "0x2EC78E0", Offset = "0x2EC62E0", VA = "0x182EC78E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700125F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046F3")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7AE0", Offset = "0x2EC64E0", VA = "0x182EC7AE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001260")]
		[DebuggerNonUserCode]
		public CollectionClothingSet Sets
		{
			[Cpp2IlInjected.Token(Token = "0x60046F7")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7A10", Offset = "0x2EC6410", VA = "0x182EC7A10")]
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
			[Cpp2IlInjected.Token(Token = "0x60046F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				type_ = value;
				bool flag = (byte)(typeCase_ = ((value != null) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001261")]
		[DebuggerNonUserCode]
		public int Universe
		{
			[Cpp2IlInjected.Token(Token = "0x60046F9")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7A70", Offset = "0x2EC6470", VA = "0x182EC7A70")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (typeCase_ == TypeOneofCase.Universe)
				{
					object obj = type_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60046FA")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7BF0", Offset = "0x2EC65F0", VA = "0x182EC7BF0")]
			set
			{
				//IL_0009: Expected I4, but got I8
				typeCase_ = TypeOneofCase.Universe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001262")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60046FB")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046F4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionClothing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60046F5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7750", Offset = "0x2EC6150", VA = "0x182EC7750")]
		[DebuggerNonUserCode]
		public CollectionClothing(CollectionClothing other)
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
				type_ = new CollectionClothingSet
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

		[Cpp2IlInjected.Token(Token = "0x60046F6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6A90", Offset = "0x2EC5490", VA = "0x182EC6A90", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionClothing Clone()
		{
			return new CollectionClothing(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60046FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60046FD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6C10", Offset = "0x2EC5610", VA = "0x182EC6C10", Slot = "0")]
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
					if ((object)typeof(CollectionClothingSet).TypeHandle != null && (object)typeof(CollectionClothingSet).TypeHandle == null)
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

		[Cpp2IlInjected.Token(Token = "0x60046FE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6AF0", Offset = "0x2EC54F0", VA = "0x182EC6AF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionClothing other)
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

		[Cpp2IlInjected.Token(Token = "0x60046FF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6E80", Offset = "0x2EC5880", VA = "0x182EC6E80", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x6004700")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7500", Offset = "0x2EC5F00", VA = "0x182EC7500", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004701")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7560", Offset = "0x2EC5F60", VA = "0x182EC7560", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x6004702")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6830", Offset = "0x2EC5230", VA = "0x182EC6830", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6004703")]
		[Cpp2IlInjected.Address(RVA = "0x2EC71D0", Offset = "0x2EC5BD0", VA = "0x182EC71D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionClothing other)
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
					bool flag = (byte)(typeCase_ = (((type_ = new CollectionClothingSet()) != null) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
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

		[Cpp2IlInjected.Token(Token = "0x6004704")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7060", Offset = "0x2EC5A60", VA = "0x182EC7060", Slot = "5")]
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
				CollectionClothingSet collectionClothingSet = new CollectionClothingSet();
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
				input.ReadMessage(collectionClothingSet);
				type_ = collectionClothingSet;
				bool flag = (byte)(typeCase_ = ((collectionClothingSet != null) ? TypeOneofCase.Sets : TypeOneofCase.None)) != 0;
			}
			if (num == 16)
			{
				int num3 = (Universe = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004705")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6D70", Offset = "0x2EC5770", VA = "0x182EC6D70", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6004706")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7410", Offset = "0x2EC5E10", VA = "0x182EC7410", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004707")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6990", Offset = "0x2EC5390", VA = "0x182EC6990", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6004708")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6FB0", Offset = "0x2EC59B0", VA = "0x182EC6FB0", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x6004709")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6A20", Offset = "0x2EC5420", VA = "0x182EC6A20", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600470A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7640", Offset = "0x2EC6040", VA = "0x182EC7640")]
		static CollectionClothing()
		{
			Func<CollectionClothing> func = default(Func<CollectionClothing>);
			_parser = (MessageParser<CollectionClothing>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
