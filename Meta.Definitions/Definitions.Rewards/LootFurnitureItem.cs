using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000203")]
	public sealed class LootFurnitureItem : IMessage<LootFurnitureItem>, IMessage, IEquatable<LootFurnitureItem>, IDeepCloneable<LootFurnitureItem>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000204")]
		public enum FurnitureItemOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400083B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400083C")]
			FurnitureItemType
		}

		[Cpp2IlInjected.Token(Token = "0x4000835")]
		private static readonly MessageParser<LootFurnitureItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000837")]
		public const int FurnitureItemTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		private object furnitureItem_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		private FurnitureItemOneofCase furnitureItemCase_;

		[Cpp2IlInjected.Token(Token = "0x1700045A")]
		[DebuggerNonUserCode]
		public static MessageParser<LootFurnitureItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001368")]
			[Cpp2IlInjected.Address(RVA = "0x38F72A0", Offset = "0x38F5CA0", VA = "0x1838F72A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001369")]
			[Cpp2IlInjected.Address(RVA = "0x38F7160", Offset = "0x38F5B60", VA = "0x1838F7160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600136A")]
			[Cpp2IlInjected.Address(RVA = "0x38F7300", Offset = "0x38F5D00", VA = "0x1838F7300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045D")]
		[DebuggerNonUserCode]
		public FurnitureItemType FurnitureItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600136E")]
			[Cpp2IlInjected.Address(RVA = "0x38F7230", Offset = "0x38F5C30", VA = "0x1838F7230")]
			get
			{
				if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
				{
					object obj = furnitureItem_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600136F")]
			[Cpp2IlInjected.Address(RVA = "0x38F7410", Offset = "0x38F5E10", VA = "0x1838F7410")]
			set
			{
				//IL_0016: Expected I4, but got I8
				furnitureItem_ = typeof(FurnitureItemType).TypeHandle;
				furnitureItemCase_ = FurnitureItemOneofCase.FurnitureItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045E")]
		[DebuggerNonUserCode]
		public FurnitureItemOneofCase FurnitureItemCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001370")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return furnitureItemCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600136B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LootFurnitureItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600136C")]
		[Cpp2IlInjected.Address(RVA = "0x38F70B0", Offset = "0x38F5AB0", VA = "0x1838F70B0")]
		[DebuggerNonUserCode]
		public LootFurnitureItem(LootFurnitureItem other)
		{
			//IL_002a: Expected I4, but got I8
			if (other.furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
			{
				int furnitureItemType = (int)other.FurnitureItemType;
				furnitureItem_ = typeof(FurnitureItemType).TypeHandle;
				furnitureItemCase_ = FurnitureItemOneofCase.FurnitureItemType;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600136D")]
		[Cpp2IlInjected.Address(RVA = "0x38F6880", Offset = "0x38F5280", VA = "0x1838F6880", Slot = "10")]
		[DebuggerNonUserCode]
		public LootFurnitureItem Clone()
		{
			//Discarded unreachable code: IL_003f
			//IL_002a: Expected I4, but got I8
			LootFurnitureItem lootFurnitureItem = new LootFurnitureItem();
			if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
			{
				int furnitureItemType = (int)FurnitureItemType;
				lootFurnitureItem.furnitureItem_ = typeof(FurnitureItemType).TypeHandle;
				lootFurnitureItem.furnitureItemCase_ = FurnitureItemOneofCase.FurnitureItemType;
			}
			UnknownFieldSet unknownFieldSet = (lootFurnitureItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return lootFurnitureItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6001371")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearFurnitureItem()
		{
			//IL_0010: Expected O, but got I4
			furnitureItem_ = (furnitureItemCase_ = FurnitureItemOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001372")]
		[Cpp2IlInjected.Address(RVA = "0x38F69E0", Offset = "0x38F53E0", VA = "0x1838F69E0", Slot = "0")]
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
				FurnitureItemType furnitureItemType = FurnitureItemType;
				int num = 0;
				FurnitureItemType furnitureItemType2 = default(FurnitureItemType);
				if (furnitureItemType == furnitureItemType2 && furnitureItemCase_ == (FurnitureItemOneofCase)furnitureItemType2)
				{
					return object.Equals(_unknownFields, num);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001373")]
		[Cpp2IlInjected.Address(RVA = "0x38F6960", Offset = "0x38F5360", VA = "0x1838F6960", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootFurnitureItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int furnitureItemType = (int)FurnitureItemType;
				FurnitureItemType furnitureItemType2 = other.FurnitureItemType;
				if (furnitureItemType == (int)furnitureItemType2)
				{
					FurnitureItemOneofCase furnitureItemOneofCase = other.furnitureItemCase_;
					if (furnitureItemCase_ == furnitureItemOneofCase)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001374")]
		[Cpp2IlInjected.Address(RVA = "0x38F6B60", Offset = "0x38F5560", VA = "0x1838F6B60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0037
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
			{
				if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
				{
					object obj = furnitureItem_;
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

		[Cpp2IlInjected.Token(Token = "0x6001375")]
		[Cpp2IlInjected.Address(RVA = "0x38F6ED0", Offset = "0x38F58D0", VA = "0x1838F6ED0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001376")]
		[Cpp2IlInjected.Address(RVA = "0x38F6F30", Offset = "0x38F5930", VA = "0x1838F6F30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
			{
				int furnitureItemType = (int)FurnitureItemType;
				output.WriteInt32(furnitureItemType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001377")]
		[Cpp2IlInjected.Address(RVA = "0x38F66E0", Offset = "0x38F50E0", VA = "0x1838F66E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
			{
				if (furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
				{
					object obj = furnitureItem_;
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

		[Cpp2IlInjected.Token(Token = "0x6001378")]
		[Cpp2IlInjected.Address(RVA = "0x38F6DA0", Offset = "0x38F57A0", VA = "0x1838F6DA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootFurnitureItem other)
		{
			if (other != null)
			{
				if (other.furnitureItemCase_ == FurnitureItemOneofCase.FurnitureItemType)
				{
					FurnitureItemType furnitureItemType = other.FurnitureItemType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001379")]
		[Cpp2IlInjected.Address(RVA = "0x38F6CD0", Offset = "0x38F56D0", VA = "0x1838F6CD0", Slot = "5")]
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
					furnitureItem_ = num2;
					furnitureItemCase_ = FurnitureItemOneofCase.FurnitureItemType;
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600137A")]
		[Cpp2IlInjected.Address(RVA = "0x38F6AA0", Offset = "0x38F54A0", VA = "0x1838F6AA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				FurnitureItemType furnitureItemType = FurnitureItemType;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600137B")]
		[Cpp2IlInjected.Address(RVA = "0x38F6E00", Offset = "0x38F5800", VA = "0x1838F6E00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				furnitureItem_ = typeof(FurnitureItemType).TypeHandle;
				furnitureItemCase_ = FurnitureItemOneofCase.FurnitureItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600137C")]
		[Cpp2IlInjected.Address(RVA = "0x38F67B0", Offset = "0x38F51B0", VA = "0x1838F67B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				FurnitureItemType furnitureItemType = default(FurnitureItemType);
				furnitureItem_ = furnitureItemType;
				furnitureItemCase_ = FurnitureItemOneofCase.FurnitureItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600137D")]
		[Cpp2IlInjected.Address(RVA = "0x38F6C20", Offset = "0x38F5620", VA = "0x1838F6C20", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "FurnitureItem"))
			{
				FurnitureItemOneofCase furnitureItemOneofCase = furnitureItemCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600137E")]
		[Cpp2IlInjected.Address(RVA = "0x38F6810", Offset = "0x38F5210", VA = "0x1838F6810", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "FurnitureItem"))
			{
				furnitureItem_ = (furnitureItemCase_ = FurnitureItemOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600137F")]
		[Cpp2IlInjected.Address(RVA = "0x38F6FA0", Offset = "0x38F59A0", VA = "0x1838F6FA0")]
		static LootFurnitureItem()
		{
			Func<LootFurnitureItem> func = default(Func<LootFurnitureItem>);
			_parser = (MessageParser<LootFurnitureItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
