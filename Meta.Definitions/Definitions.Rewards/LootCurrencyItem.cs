using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000209")]
	public sealed class LootCurrencyItem : IMessage<LootCurrencyItem>, IMessage, IEquatable<LootCurrencyItem>, IDeepCloneable<LootCurrencyItem>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200020A")]
		public enum CurrencyItemOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400084D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400084E")]
			CurrencyType
		}

		[Cpp2IlInjected.Token(Token = "0x4000847")]
		private static readonly MessageParser<LootCurrencyItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000849")]
		public const int CurrencyTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private object currencyItem_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		private CurrencyItemOneofCase currencyItemCase_;

		[Cpp2IlInjected.Token(Token = "0x17000464")]
		[DebuggerNonUserCode]
		public static MessageParser<LootCurrencyItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600139E")]
			[Cpp2IlInjected.Address(RVA = "0x38F6500", Offset = "0x38F4F00", VA = "0x1838F6500")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000465")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600139F")]
			[Cpp2IlInjected.Address(RVA = "0x38F6430", Offset = "0x38F4E30", VA = "0x1838F6430")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000466")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013A0")]
			[Cpp2IlInjected.Address(RVA = "0x38F6560", Offset = "0x38F4F60", VA = "0x1838F6560", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000467")]
		[DebuggerNonUserCode]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60013A4")]
			[Cpp2IlInjected.Address(RVA = "0x38F63C0", Offset = "0x38F4DC0", VA = "0x1838F63C0")]
			get
			{
				if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
				{
					object obj = currencyItem_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013A5")]
			[Cpp2IlInjected.Address(RVA = "0x38F6670", Offset = "0x38F5070", VA = "0x1838F6670")]
			set
			{
				//IL_0016: Expected I4, but got I8
				currencyItem_ = typeof(CurrencyType).TypeHandle;
				currencyItemCase_ = CurrencyItemOneofCase.CurrencyType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000468")]
		[DebuggerNonUserCode]
		public CurrencyItemOneofCase CurrencyItemCase
		{
			[Cpp2IlInjected.Token(Token = "0x60013A6")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return currencyItemCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013A1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LootCurrencyItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60013A2")]
		[Cpp2IlInjected.Address(RVA = "0x38F6310", Offset = "0x38F4D10", VA = "0x1838F6310")]
		[DebuggerNonUserCode]
		public LootCurrencyItem(LootCurrencyItem other)
		{
			//IL_002a: Expected I4, but got I8
			if (other.currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
			{
				int currencyType = (int)other.CurrencyType;
				currencyItem_ = typeof(CurrencyType).TypeHandle;
				currencyItemCase_ = CurrencyItemOneofCase.CurrencyType;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013A3")]
		[Cpp2IlInjected.Address(RVA = "0x38F5AE0", Offset = "0x38F44E0", VA = "0x1838F5AE0", Slot = "10")]
		[DebuggerNonUserCode]
		public LootCurrencyItem Clone()
		{
			//Discarded unreachable code: IL_003f
			//IL_002a: Expected I4, but got I8
			LootCurrencyItem lootCurrencyItem = new LootCurrencyItem();
			if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
			{
				int currencyType = (int)CurrencyType;
				lootCurrencyItem.currencyItem_ = typeof(CurrencyType).TypeHandle;
				lootCurrencyItem.currencyItemCase_ = CurrencyItemOneofCase.CurrencyType;
			}
			UnknownFieldSet unknownFieldSet = (lootCurrencyItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return lootCurrencyItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60013A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearCurrencyItem()
		{
			//IL_0010: Expected O, but got I4
			currencyItem_ = (currencyItemCase_ = CurrencyItemOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013A8")]
		[Cpp2IlInjected.Address(RVA = "0x38F5BC0", Offset = "0x38F45C0", VA = "0x1838F5BC0", Slot = "0")]
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
				CurrencyType currencyType = CurrencyType;
				int num = 0;
				CurrencyType currencyType2 = default(CurrencyType);
				if (currencyType == currencyType2 && currencyItemCase_ == (CurrencyItemOneofCase)currencyType2)
				{
					return object.Equals(_unknownFields, num);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013A9")]
		[Cpp2IlInjected.Address(RVA = "0x38F5C80", Offset = "0x38F4680", VA = "0x1838F5C80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootCurrencyItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int currencyType = (int)CurrencyType;
				CurrencyType currencyType2 = other.CurrencyType;
				if (currencyType == (int)currencyType2)
				{
					CurrencyItemOneofCase currencyItemOneofCase = other.currencyItemCase_;
					if (currencyItemCase_ == currencyItemOneofCase)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013AA")]
		[Cpp2IlInjected.Address(RVA = "0x38F5DC0", Offset = "0x38F47C0", VA = "0x1838F5DC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0037
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
			{
				if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
				{
					object obj = currencyItem_;
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

		[Cpp2IlInjected.Token(Token = "0x60013AB")]
		[Cpp2IlInjected.Address(RVA = "0x38F6130", Offset = "0x38F4B30", VA = "0x1838F6130", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60013AC")]
		[Cpp2IlInjected.Address(RVA = "0x38F6190", Offset = "0x38F4B90", VA = "0x1838F6190", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
			{
				int currencyType = (int)CurrencyType;
				output.WriteInt32(currencyType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60013AD")]
		[Cpp2IlInjected.Address(RVA = "0x38F5940", Offset = "0x38F4340", VA = "0x1838F5940", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
			{
				if (currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
				{
					object obj = currencyItem_;
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

		[Cpp2IlInjected.Token(Token = "0x60013AE")]
		[Cpp2IlInjected.Address(RVA = "0x38F5F30", Offset = "0x38F4930", VA = "0x1838F5F30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootCurrencyItem other)
		{
			if (other != null)
			{
				if (other.currencyItemCase_ == CurrencyItemOneofCase.CurrencyType)
				{
					CurrencyType currencyType = other.CurrencyType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013AF")]
		[Cpp2IlInjected.Address(RVA = "0x38F5F90", Offset = "0x38F4990", VA = "0x1838F5F90", Slot = "5")]
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
					currencyItem_ = num2;
					currencyItemCase_ = CurrencyItemOneofCase.CurrencyType;
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B0")]
		[Cpp2IlInjected.Address(RVA = "0x38F5D00", Offset = "0x38F4700", VA = "0x1838F5D00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				CurrencyType currencyType = CurrencyType;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013B1")]
		[Cpp2IlInjected.Address(RVA = "0x38F6060", Offset = "0x38F4A60", VA = "0x1838F6060", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				currencyItem_ = typeof(CurrencyType).TypeHandle;
				currencyItemCase_ = CurrencyItemOneofCase.CurrencyType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B2")]
		[Cpp2IlInjected.Address(RVA = "0x38F5A10", Offset = "0x38F4410", VA = "0x1838F5A10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				CurrencyType currencyType = default(CurrencyType);
				currencyItem_ = currencyType;
				currencyItemCase_ = CurrencyItemOneofCase.CurrencyType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B3")]
		[Cpp2IlInjected.Address(RVA = "0x38F5E80", Offset = "0x38F4880", VA = "0x1838F5E80", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "CurrencyItem"))
			{
				CurrencyItemOneofCase currencyItemOneofCase = currencyItemCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013B4")]
		[Cpp2IlInjected.Address(RVA = "0x38F5A70", Offset = "0x38F4470", VA = "0x1838F5A70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "CurrencyItem"))
			{
				currencyItem_ = (currencyItemCase_ = CurrencyItemOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B5")]
		[Cpp2IlInjected.Address(RVA = "0x38F6200", Offset = "0x38F4C00", VA = "0x1838F6200")]
		static LootCurrencyItem()
		{
			Func<LootCurrencyItem> func = default(Func<LootCurrencyItem>);
			_parser = (MessageParser<LootCurrencyItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
