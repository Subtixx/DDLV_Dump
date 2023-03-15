using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000206")]
	public sealed class LootClothingItem : IMessage<LootClothingItem>, IMessage, IEquatable<LootClothingItem>, IDeepCloneable<LootClothingItem>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000207")]
		public enum ClothingItemOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000844")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000845")]
			ClothingItemType
		}

		[Cpp2IlInjected.Token(Token = "0x400083E")]
		private static readonly MessageParser<LootClothingItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public const int ClothingItemTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		private object clothingItem_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private ClothingItemOneofCase clothingItemCase_;

		[Cpp2IlInjected.Token(Token = "0x1700045F")]
		[DebuggerNonUserCode]
		public static MessageParser<LootClothingItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001383")]
			[Cpp2IlInjected.Address(RVA = "0x38F5760", Offset = "0x38F4160", VA = "0x1838F5760")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000460")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001384")]
			[Cpp2IlInjected.Address(RVA = "0x38F5690", Offset = "0x38F4090", VA = "0x1838F5690")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000461")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001385")]
			[Cpp2IlInjected.Address(RVA = "0x38F57C0", Offset = "0x38F41C0", VA = "0x1838F57C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000462")]
		[DebuggerNonUserCode]
		public ClothingItemType ClothingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6001389")]
			[Cpp2IlInjected.Address(RVA = "0x38F5620", Offset = "0x38F4020", VA = "0x1838F5620")]
			get
			{
				if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
				{
					object obj = clothingItem_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600138A")]
			[Cpp2IlInjected.Address(RVA = "0x38F58D0", Offset = "0x38F42D0", VA = "0x1838F58D0")]
			set
			{
				//IL_0016: Expected I4, but got I8
				clothingItem_ = typeof(ClothingItemType).TypeHandle;
				clothingItemCase_ = ClothingItemOneofCase.ClothingItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000463")]
		[DebuggerNonUserCode]
		public ClothingItemOneofCase ClothingItemCase
		{
			[Cpp2IlInjected.Token(Token = "0x600138B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return clothingItemCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001386")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LootClothingItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001387")]
		[Cpp2IlInjected.Address(RVA = "0x38F5570", Offset = "0x38F3F70", VA = "0x1838F5570")]
		[DebuggerNonUserCode]
		public LootClothingItem(LootClothingItem other)
		{
			//IL_002a: Expected I4, but got I8
			if (other.clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
			{
				int clothingItemType = (int)other.ClothingItemType;
				clothingItem_ = typeof(ClothingItemType).TypeHandle;
				clothingItemCase_ = ClothingItemOneofCase.ClothingItemType;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001388")]
		[Cpp2IlInjected.Address(RVA = "0x38F4D40", Offset = "0x38F3740", VA = "0x1838F4D40", Slot = "10")]
		[DebuggerNonUserCode]
		public LootClothingItem Clone()
		{
			//Discarded unreachable code: IL_003f
			//IL_002a: Expected I4, but got I8
			LootClothingItem lootClothingItem = new LootClothingItem();
			if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
			{
				int clothingItemType = (int)ClothingItemType;
				lootClothingItem.clothingItem_ = typeof(ClothingItemType).TypeHandle;
				lootClothingItem.clothingItemCase_ = ClothingItemOneofCase.ClothingItemType;
			}
			UnknownFieldSet unknownFieldSet = (lootClothingItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return lootClothingItem;
		}

		[Cpp2IlInjected.Token(Token = "0x600138C")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearClothingItem()
		{
			//IL_0010: Expected O, but got I4
			clothingItem_ = (clothingItemCase_ = ClothingItemOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600138D")]
		[Cpp2IlInjected.Address(RVA = "0x38F4E20", Offset = "0x38F3820", VA = "0x1838F4E20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_002e: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				ClothingItemType clothingItemType = ClothingItemType;
				int num = 0;
				ClothingItemType clothingItemType2 = default(ClothingItemType);
				if (clothingItemType == clothingItemType2 && clothingItemCase_ == (ClothingItemOneofCase)clothingItemType2)
				{
					return object.Equals(_unknownFields, num);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600138E")]
		[Cpp2IlInjected.Address(RVA = "0x38F4EE0", Offset = "0x38F38E0", VA = "0x1838F4EE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootClothingItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int clothingItemType = (int)ClothingItemType;
				ClothingItemType clothingItemType2 = other.ClothingItemType;
				if (clothingItemType == (int)clothingItemType2)
				{
					ClothingItemOneofCase clothingItemOneofCase = other.clothingItemCase_;
					if (clothingItemCase_ == clothingItemOneofCase)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600138F")]
		[Cpp2IlInjected.Address(RVA = "0x38F5020", Offset = "0x38F3A20", VA = "0x1838F5020", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0037
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
			{
				if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
				{
					object obj = clothingItem_;
				}
				System.Net.Http.Headers.Token.Type type = (System.Net.Http.Headers.Token)num;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001390")]
		[Cpp2IlInjected.Address(RVA = "0x38F5390", Offset = "0x38F3D90", VA = "0x1838F5390", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001391")]
		[Cpp2IlInjected.Address(RVA = "0x38F53F0", Offset = "0x38F3DF0", VA = "0x1838F53F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
			{
				int clothingItemType = (int)ClothingItemType;
				output.WriteInt32(clothingItemType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001392")]
		[Cpp2IlInjected.Address(RVA = "0x38F4BA0", Offset = "0x38F35A0", VA = "0x1838F4BA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
			{
				if (clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
				{
					object obj = clothingItem_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001393")]
		[Cpp2IlInjected.Address(RVA = "0x38F5190", Offset = "0x38F3B90", VA = "0x1838F5190", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootClothingItem other)
		{
			if (other != null)
			{
				if (other.clothingItemCase_ == ClothingItemOneofCase.ClothingItemType)
				{
					ClothingItemType clothingItemType = other.ClothingItemType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001394")]
		[Cpp2IlInjected.Address(RVA = "0x38F51F0", Offset = "0x38F3BF0", VA = "0x1838F51F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003d
			//IL_001f: Expected O, but got I4
			//IL_0028: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = input.ReadInt32();
					clothingItem_ = num2;
					clothingItemCase_ = ClothingItemOneofCase.ClothingItemType;
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001395")]
		[Cpp2IlInjected.Address(RVA = "0x38F4F60", Offset = "0x38F3960", VA = "0x1838F4F60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ClothingItemType clothingItemType = ClothingItemType;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001396")]
		[Cpp2IlInjected.Address(RVA = "0x38F52C0", Offset = "0x38F3CC0", VA = "0x1838F52C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				clothingItem_ = typeof(ClothingItemType).TypeHandle;
				clothingItemCase_ = ClothingItemOneofCase.ClothingItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001397")]
		[Cpp2IlInjected.Address(RVA = "0x38F4C70", Offset = "0x38F3670", VA = "0x1838F4C70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				ClothingItemType clothingItemType = default(ClothingItemType);
				clothingItem_ = clothingItemType;
				clothingItemCase_ = ClothingItemOneofCase.ClothingItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001398")]
		[Cpp2IlInjected.Address(RVA = "0x38F50E0", Offset = "0x38F3AE0", VA = "0x1838F50E0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ClothingItem"))
			{
				ClothingItemOneofCase clothingItemOneofCase = clothingItemCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001399")]
		[Cpp2IlInjected.Address(RVA = "0x38F4CD0", Offset = "0x38F36D0", VA = "0x1838F4CD0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ClothingItem"))
			{
				clothingItem_ = (clothingItemCase_ = ClothingItemOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600139A")]
		[Cpp2IlInjected.Address(RVA = "0x38F5460", Offset = "0x38F3E60", VA = "0x1838F5460")]
		static LootClothingItem()
		{
			Func<LootClothingItem> func = default(Func<LootClothingItem>);
			_parser = (MessageParser<LootClothingItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
