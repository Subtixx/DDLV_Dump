using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class Price : IMessage<Price>, IMessage, IEquatable<Price>, IDeepCloneable<Price>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public enum PriceOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			Offline,
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			Iap
		}

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly MessageParser<Price> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public const int OfflineFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public const int IapFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private object price_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private PriceOneofCase priceCase_;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public static MessageParser<Price> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x28851D0", Offset = "0x2883BD0", VA = "0x1828851D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2885040", Offset = "0x2883A40", VA = "0x182885040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x2885230", Offset = "0x2883C30", VA = "0x182885230", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public CurrencyCost Offline
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2885170", Offset = "0x2883B70", VA = "0x182885170")]
			get
			{
				int num = 0;
				if (priceCase_ == PriceOneofCase.Offline)
				{
					object obj = price_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				price_ = value;
				bool flag = (byte)(priceCase_ = ((value != null) ? PriceOneofCase.Offline : PriceOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public RealCurrency Iap
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2885110", Offset = "0x2883B10", VA = "0x182885110")]
			get
			{
				int num = 0;
				if (priceCase_ == PriceOneofCase.Iap)
				{
					object obj = price_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				price_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public PriceOneofCase PriceCase
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return priceCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Price()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2884EE0", Offset = "0x28838E0", VA = "0x182884EE0")]
		[DebuggerNonUserCode]
		public Price(Price other)
		{
			//IL_005c: Expected I4, but got O
			PriceOneofCase priceOneofCase = other.priceCase_;
			if (priceOneofCase == PriceOneofCase.Offline)
			{
				PriceOneofCase priceOneofCase2 = other.priceCase_;
				if (other.price_ == null)
				{
					throw new InvalidCastException();
				}
				CurrencyCost currencyCost = default(CurrencyCost);
				price_ = currencyCost;
				bool flag = (byte)(priceCase_ = ((currencyCost != null) ? PriceOneofCase.Offline : PriceOneofCase.None)) != 0;
			}
			if (priceOneofCase == PriceOneofCase.Iap)
			{
				PriceOneofCase priceOneofCase3 = other.priceCase_;
				if (other.price_ == null)
				{
					throw new InvalidCastException();
				}
				RealCurrency realCurrency = default(RealCurrency);
				price_ = realCurrency;
				priceCase_ = (PriceOneofCase)realCurrency;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2883FE0", Offset = "0x28829E0", VA = "0x182883FE0", Slot = "10")]
		[DebuggerNonUserCode]
		public Price Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_005e: Expected I4, but got O
			Price price = new Price();
			PriceOneofCase priceOneofCase = priceCase_;
			if (priceOneofCase == PriceOneofCase.Offline)
			{
				PriceOneofCase priceOneofCase2 = priceCase_;
				if (price_ == null)
				{
					throw new InvalidCastException();
				}
				CurrencyCost currencyCost = default(CurrencyCost);
				price.price_ = currencyCost;
				bool flag = (byte)(price.priceCase_ = ((currencyCost != null) ? PriceOneofCase.Offline : PriceOneofCase.None)) != 0;
			}
			if (priceOneofCase == PriceOneofCase.Iap)
			{
				PriceOneofCase priceOneofCase3 = priceCase_;
				if (price_ == null)
				{
					throw new InvalidCastException();
				}
				RealCurrency realCurrency = default(RealCurrency);
				price.price_ = realCurrency;
				price.priceCase_ = (PriceOneofCase)realCurrency;
			}
			UnknownFieldSet unknownFieldSet = (price._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return price;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearPrice()
		{
			//IL_0010: Expected O, but got I4
			price_ = (priceCase_ = PriceOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2884170", Offset = "0x2882B70", VA = "0x182884170", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (priceCase_ == PriceOneofCase.Offline)
					{
						object obj = price_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(CurrencyCost).TypeHandle != null && (object)typeof(CurrencyCost).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						RealCurrency objB = default(RealCurrency);
						bool flag2 = object.Equals(Iap, objB);
						if (flag2 && priceCase_ == (flag2 ? PriceOneofCase.Offline : PriceOneofCase.None))
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

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x28842E0", Offset = "0x2882CE0", VA = "0x1828842E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Price other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (priceCase_ == PriceOneofCase.Offline)
				{
					object obj = price_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.priceCase_ == PriceOneofCase.Offline)
				{
					obj2 = other.price_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					RealCurrency iap = Iap;
					RealCurrency iap2 = other.Iap;
					if (object.Equals(iap, iap2))
					{
						PriceOneofCase priceOneofCase = other.priceCase_;
						if (priceCase_ == priceOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2884520", Offset = "0x2882F20", VA = "0x182884520", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			PriceOneofCase priceOneofCase = priceCase_;
			int num = 0;
			if (priceOneofCase == PriceOneofCase.Offline)
			{
				object obj = price_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (priceOneofCase == PriceOneofCase.Iap)
			{
				object obj2 = price_;
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

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2884C40", Offset = "0x2883640", VA = "0x182884C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2884CA0", Offset = "0x28836A0", VA = "0x182884CA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			PriceOneofCase priceOneofCase = priceCase_;
			int num = 0;
			if (priceOneofCase == PriceOneofCase.Offline)
			{
				if (priceCase_ == PriceOneofCase.Offline)
				{
					object obj = price_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (priceOneofCase == PriceOneofCase.Iap && priceCase_ == PriceOneofCase.Iap)
			{
				object obj2 = price_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2883E20", Offset = "0x2882820", VA = "0x182883E20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (priceCase_ == PriceOneofCase.Offline)
			{
				if (priceCase_ == PriceOneofCase.Offline)
				{
					object obj = price_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (priceCase_ == PriceOneofCase.Iap)
			{
				if (priceCase_ == PriceOneofCase.Iap)
				{
					object obj2 = price_;
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

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2884700", Offset = "0x2883100", VA = "0x182884700", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Price other)
		{
			//IL_00dd: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.priceCase_ == PriceOneofCase.Offline)
			{
				PriceOneofCase priceOneofCase = priceCase_;
				int num = 0;
				if (priceOneofCase == PriceOneofCase.Offline)
				{
					object obj = price_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(priceCase_ = (((price_ = new CurrencyCost()) != null) ? PriceOneofCase.Offline : PriceOneofCase.None)) != 0;
				}
				if (priceCase_ == PriceOneofCase.Offline)
				{
					object obj2 = price_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.priceCase_ == PriceOneofCase.Offline)
				{
					object obj3 = other.price_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(RealCurrency).TypeHandle != 2)
			{
			}
			if (Iap == null)
			{
				priceCase_ = (PriceOneofCase)(price_ = new RealCurrency());
			}
			RealCurrency other2 = default(RealCurrency);
			Iap.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2884950", Offset = "0x2883350", VA = "0x182884950", Slot = "5")]
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
				CurrencyCost currencyCost = new CurrencyCost();
				if (priceCase_ == PriceOneofCase.Offline)
				{
					if (priceCase_ != PriceOneofCase.Offline)
					{
					}
					object obj = price_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(currencyCost);
				price_ = currencyCost;
				bool flag = (byte)(priceCase_ = ((currencyCost != null) ? PriceOneofCase.Offline : PriceOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				RealCurrency builder = new RealCurrency();
				if (priceCase_ == PriceOneofCase.Iap)
				{
					if (priceCase_ != PriceOneofCase.Iap)
					{
					}
					object obj2 = price_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				price_ = builder;
				priceCase_ = (PriceOneofCase)typeof(RealCurrency).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2884410", Offset = "0x2882E10", VA = "0x182884410", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (priceCase_ == PriceOneofCase.Offline)
			{
				object obj = price_;
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
				if (priceCase_ == PriceOneofCase.Iap)
				{
					obj2 = price_;
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

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2884B50", Offset = "0x2883550", VA = "0x182884B50", Slot = "12")]
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
				price_ = num;
				bool flag = (byte)(priceCase_ = ((num != 0) ? PriceOneofCase.Offline : PriceOneofCase.None)) != 0;
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
				price_ = value;
				priceCase_ = (PriceOneofCase)typeof(RealCurrency).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				priceCase_ = PriceOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2884650", Offset = "0x2883050", VA = "0x182884650", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "price"))
			{
				PriceOneofCase priceOneofCase = priceCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2883F70", Offset = "0x2882970", VA = "0x182883F70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "price"))
			{
				price_ = (priceCase_ = PriceOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2884DD0", Offset = "0x28837D0", VA = "0x182884DD0")]
		static Price()
		{
			Func<Price> func = default(Func<Price>);
			_parser = (MessageParser<Price>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
