using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000594")]
	public sealed class PriceOverride : IMessage<PriceOverride>, IMessage, IEquatable<PriceOverride>, IDeepCloneable<PriceOverride>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000595")]
		public enum OverrideOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001E2C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001E2D")]
			Currency,
			[Cpp2IlInjected.Token(Token = "0x4001E2E")]
			Price
		}

		[Cpp2IlInjected.Token(Token = "0x4001E25")]
		private static readonly MessageParser<PriceOverride> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E26")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001E27")]
		public const int CurrencyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001E28")]
		public const int PriceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E29")]
		private object override_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E2A")]
		private OverrideOneofCase overrideCase_;

		[Cpp2IlInjected.Token(Token = "0x170011D8")]
		[DebuggerNonUserCode]
		public static MessageParser<PriceOverride> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600454F")]
			[Cpp2IlInjected.Address(RVA = "0x2883BE0", Offset = "0x28825E0", VA = "0x182883BE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011D9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004550")]
			[Cpp2IlInjected.Address(RVA = "0x2883B10", Offset = "0x2882510", VA = "0x182883B10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011DA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004551")]
			[Cpp2IlInjected.Address(RVA = "0x2883CA0", Offset = "0x28826A0", VA = "0x182883CA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011DB")]
		[DebuggerNonUserCode]
		public int Currency
		{
			[Cpp2IlInjected.Token(Token = "0x6004555")]
			[Cpp2IlInjected.Address(RVA = "0x2883AA0", Offset = "0x28824A0", VA = "0x182883AA0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (overrideCase_ == OverrideOneofCase.Currency)
				{
					object obj = override_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6004556")]
			[Cpp2IlInjected.Address(RVA = "0x2883DB0", Offset = "0x28827B0", VA = "0x182883DB0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				override_ = typeof(int).TypeHandle;
				overrideCase_ = OverrideOneofCase.Currency;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011DC")]
		[DebuggerNonUserCode]
		public CurrencyCost Price
		{
			[Cpp2IlInjected.Token(Token = "0x6004557")]
			[Cpp2IlInjected.Address(RVA = "0x2883C40", Offset = "0x2882640", VA = "0x182883C40")]
			get
			{
				int num = 0;
				if (overrideCase_ == OverrideOneofCase.Price)
				{
					object obj = override_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004558")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				override_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011DD")]
		[DebuggerNonUserCode]
		public OverrideOneofCase OverrideCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004559")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return overrideCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004552")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PriceOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004553")]
		[Cpp2IlInjected.Address(RVA = "0x2883970", Offset = "0x2882370", VA = "0x182883970")]
		[DebuggerNonUserCode]
		public PriceOverride(PriceOverride other)
		{
			//IL_002c: Expected I4, but got I8
			//IL_004e: Expected I4, but got O
			OverrideOneofCase overrideOneofCase = other.overrideCase_;
			if (overrideOneofCase == OverrideOneofCase.Currency)
			{
				int currency = other.Currency;
				override_ = typeof(int).TypeHandle;
				overrideCase_ = OverrideOneofCase.Currency;
			}
			if (overrideOneofCase == OverrideOneofCase.Price)
			{
				OverrideOneofCase overrideOneofCase2 = other.overrideCase_;
				if (other.override_ == null)
				{
					throw new InvalidCastException();
				}
				CurrencyCost currencyCost = default(CurrencyCost);
				override_ = currencyCost;
				overrideCase_ = (OverrideOneofCase)currencyCost;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004554")]
		[Cpp2IlInjected.Address(RVA = "0x2882D90", Offset = "0x2881790", VA = "0x182882D90", Slot = "10")]
		[DebuggerNonUserCode]
		public PriceOverride Clone()
		{
			//Discarded unreachable code: IL_0067
			//IL_002c: Expected I4, but got I8
			//IL_0050: Expected I4, but got O
			PriceOverride priceOverride = new PriceOverride();
			OverrideOneofCase overrideOneofCase = overrideCase_;
			if (overrideOneofCase == OverrideOneofCase.Currency)
			{
				int currency = Currency;
				priceOverride.override_ = typeof(int).TypeHandle;
				priceOverride.overrideCase_ = OverrideOneofCase.Currency;
			}
			if (overrideOneofCase == OverrideOneofCase.Price)
			{
				OverrideOneofCase overrideOneofCase2 = overrideCase_;
				if (override_ == null)
				{
					throw new InvalidCastException();
				}
				CurrencyCost currencyCost = default(CurrencyCost);
				priceOverride.override_ = currencyCost;
				priceOverride.overrideCase_ = (OverrideOneofCase)currencyCost;
			}
			UnknownFieldSet unknownFieldSet = (priceOverride._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return priceOverride;
		}

		[Cpp2IlInjected.Token(Token = "0x600455A")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearOverride()
		{
			//IL_0010: Expected O, but got I4
			override_ = (overrideCase_ = OverrideOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600455B")]
		[Cpp2IlInjected.Address(RVA = "0x2882EF0", Offset = "0x28818F0", VA = "0x182882EF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = default(int);
				if (Currency == num)
				{
					CurrencyCost objB = default(CurrencyCost);
					bool flag = object.Equals(Price, objB);
					if (flag && overrideCase_ == (flag ? OverrideOneofCase.Currency : OverrideOneofCase.None))
					{
						return object.Equals(_unknownFields, objB);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600455C")]
		[Cpp2IlInjected.Address(RVA = "0x2882FE0", Offset = "0x28819E0", VA = "0x182882FE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PriceOverride other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int currency = Currency;
				int currency2 = other.Currency;
				if (currency == currency2)
				{
					CurrencyCost price = Price;
					CurrencyCost price2 = other.Price;
					if (object.Equals(price, price2))
					{
						OverrideOneofCase overrideOneofCase = other.overrideCase_;
						if (overrideCase_ == overrideOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600455D")]
		[Cpp2IlInjected.Address(RVA = "0x28831A0", Offset = "0x2881BA0", VA = "0x1828831A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004e
			int num = 0;
			if (overrideCase_ == OverrideOneofCase.Currency)
			{
				if (overrideCase_ != OverrideOneofCase.Currency)
				{
				}
				object obj = override_;
			}
			if (overrideCase_ == OverrideOneofCase.Price)
			{
				object obj2 = override_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600455E")]
		[Cpp2IlInjected.Address(RVA = "0x2883720", Offset = "0x2882120", VA = "0x182883720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600455F")]
		[Cpp2IlInjected.Address(RVA = "0x2883780", Offset = "0x2882180", VA = "0x182883780", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			OverrideOneofCase overrideOneofCase = overrideCase_;
			if (overrideOneofCase == OverrideOneofCase.Currency)
			{
				int currency = Currency;
				output.WriteInt32(currency);
			}
			if (overrideOneofCase == OverrideOneofCase.Price && overrideCase_ == OverrideOneofCase.Price)
			{
				object obj = override_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004560")]
		[Cpp2IlInjected.Address(RVA = "0x2882B30", Offset = "0x2881530", VA = "0x182882B30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (overrideCase_ == OverrideOneofCase.Currency)
			{
				if (overrideCase_ == OverrideOneofCase.Currency)
				{
					object obj = override_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (overrideCase_ == OverrideOneofCase.Price)
			{
				if (overrideCase_ == OverrideOneofCase.Price)
				{
					object obj2 = override_;
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

		[Cpp2IlInjected.Token(Token = "0x6004561")]
		[Cpp2IlInjected.Address(RVA = "0x2883380", Offset = "0x2881D80", VA = "0x182883380", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PriceOverride other)
		{
			if (other == null)
			{
				return;
			}
			if (other.overrideCase_ != OverrideOneofCase.Currency)
			{
				while ((long)typeof(CurrencyCost).TypeHandle != 2)
				{
				}
				CurrencyCost currencyCost = default(CurrencyCost);
				if (currencyCost == null)
				{
					CurrencyCost currencyCost2 = new CurrencyCost();
				}
				CurrencyCost price = other.Price;
				CurrencyCost currencyCost3 = default(CurrencyCost);
				currencyCost3.MergeFrom(price);
				throw new NullReferenceException();
			}
			int num = (Currency = other.Currency);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004562")]
		[Cpp2IlInjected.Address(RVA = "0x2883490", Offset = "0x2881E90", VA = "0x182883490", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0068: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num3 = (Currency = input.ReadInt32());
			}
			if (num == 18)
			{
				CurrencyCost builder = new CurrencyCost();
				if (overrideCase_ == OverrideOneofCase.Price)
				{
					if (overrideCase_ != OverrideOneofCase.Price)
					{
					}
					object obj = override_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				override_ = builder;
				overrideCase_ = (OverrideOneofCase)typeof(CurrencyCost).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004563")]
		[Cpp2IlInjected.Address(RVA = "0x2883090", Offset = "0x2881A90", VA = "0x182883090", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int currency = Currency;
			}
			if (fieldNumber == 2)
			{
				while (overrideCase_ != OverrideOneofCase.Price)
				{
				}
				object obj = override_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_0037;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
			IL_0037:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004564")]
		[Cpp2IlInjected.Address(RVA = "0x28835F0", Offset = "0x2881FF0", VA = "0x1828835F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0018: Expected I4, but got I8
			//IL_0037: Expected I4, but got O
			if (fieldNumber == 1)
			{
				override_ = typeof(int).TypeHandle;
				overrideCase_ = OverrideOneofCase.Currency;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				override_ = value;
				overrideCase_ = (OverrideOneofCase)typeof(int).TypeHandle;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004565")]
		[Cpp2IlInjected.Address(RVA = "0x2882C90", Offset = "0x2881690", VA = "0x182882C90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				int num = default(int);
				override_ = num;
				overrideCase_ = OverrideOneofCase.Currency;
				break;
			}
			case 2:
				overrideCase_ = OverrideOneofCase.None;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004566")]
		[Cpp2IlInjected.Address(RVA = "0x28832D0", Offset = "0x2881CD0", VA = "0x1828832D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Override"))
			{
				OverrideOneofCase overrideOneofCase = overrideCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004567")]
		[Cpp2IlInjected.Address(RVA = "0x2882D20", Offset = "0x2881720", VA = "0x182882D20", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Override"))
			{
				override_ = (overrideCase_ = OverrideOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004568")]
		[Cpp2IlInjected.Address(RVA = "0x2883860", Offset = "0x2882260", VA = "0x182883860")]
		static PriceOverride()
		{
			Func<PriceOverride> func = default(Func<PriceOverride>);
			_parser = (MessageParser<PriceOverride>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
