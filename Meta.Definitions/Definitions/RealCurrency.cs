using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class RealCurrency : IMessage<RealCurrency>, IMessage, IEquatable<RealCurrency>, IDeepCloneable<RealCurrency>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly MessageParser<RealCurrency> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public const int PriceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float price_;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public const int CurrencyFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private string currency_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public const int SymbolFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private string symbol_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public const int DisplayFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private string display_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public static MessageParser<RealCurrency> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2DA48A0", Offset = "0x2DA32A0", VA = "0x182DA48A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2DA47D0", Offset = "0x2DA31D0", VA = "0x182DA47D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4900", Offset = "0x2DA3300", VA = "0x182DA4900", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public float Price
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get
			{
				return price_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set
			{
				price_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[DebuggerNonUserCode]
		public string Currency
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return currency_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4A10", Offset = "0x2DA3410", VA = "0x182DA4A10")]
			set
			{
				string text = (currency_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public string Symbol
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return symbol_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4AF0", Offset = "0x2DA34F0", VA = "0x182DA4AF0")]
			set
			{
				string text = (symbol_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public string Display
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return display_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4A80", Offset = "0x2DA3480", VA = "0x182DA4A80")]
			set
			{
				string text = (display_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4660", Offset = "0x2DA3060", VA = "0x182DA4660")]
		[DebuggerNonUserCode]
		public RealCurrency()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DA46D0", Offset = "0x2DA30D0", VA = "0x182DA46D0")]
		[DebuggerNonUserCode]
		public RealCurrency(RealCurrency other)
		{
			float num = (price_ = other.price_);
			string text = (currency_ = other.currency_);
			string text2 = (symbol_ = other.symbol_);
			string text3 = (display_ = other.display_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3AE0", Offset = "0x2DA24E0", VA = "0x182DA3AE0", Slot = "10")]
		[DebuggerNonUserCode]
		public RealCurrency Clone()
		{
			//Discarded unreachable code: IL_0078
			RealCurrency realCurrency = new RealCurrency();
			realCurrency.currency_ = "";
			realCurrency.symbol_ = "";
			realCurrency.display_ = "";
			float num = (realCurrency.price_ = price_);
			string text = (realCurrency.currency_ = currency_);
			string text2 = (realCurrency.symbol_ = symbol_);
			string text3 = (realCurrency.display_ = display_);
			UnknownFieldSet unknownFieldSet = (realCurrency._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return realCurrency;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3D20", Offset = "0x2DA2720", VA = "0x182DA3D20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					string text = currency_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = symbol_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = display_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3C10", Offset = "0x2DA2610", VA = "0x182DA3C10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RealCurrency other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					string text = other.currency_;
					if (!(currency_ != text))
					{
						string text2 = other.symbol_;
						if (!(symbol_ != text2))
						{
							string text3 = other.display_;
							if (!(display_ != text3))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3F60", Offset = "0x2DA2960", VA = "0x182DA3F60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006f
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			string text = currency_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = symbol_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = display_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2DA43E0", Offset = "0x2DA2DE0", VA = "0x182DA43E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4440", Offset = "0x2DA2E40", VA = "0x182DA4440", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0078
			float value = price_;
			output.WriteFloat(value);
			if (currency_.m_stringLength != 0)
			{
				string value2 = currency_;
				output.WriteString(value2);
			}
			if (symbol_.m_stringLength != 0)
			{
				string value3 = symbol_;
				output.WriteString(value3);
			}
			if (display_.m_stringLength != 0)
			{
				string value4 = display_;
				output.WriteString(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3900", Offset = "0x2DA2300", VA = "0x182DA3900", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			string text = currency_;
			uint num2 = default(uint);
			if (text.m_stringLength != 0)
			{
				int num = CodedOutputStream.ComputeStringSize(text);
				num++;
				num2 += (uint)num;
			}
			string text2 = symbol_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num2 += (uint)num3;
			}
			string text3 = display_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num2 += (uint)num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += (uint)num5;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DA40D0", Offset = "0x2DA2AD0", VA = "0x182DA40D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RealCurrency other)
		{
			//Discarded unreachable code: IL_007e
			if (other != null)
			{
				float num = other.price_;
				if (other != null)
				{
					price_ = num;
				}
				string text = other.currency_;
				if (text.m_stringLength != 0)
				{
					Currency = text;
				}
				string text2 = other.symbol_;
				if (text2.m_stringLength != 0)
				{
					Symbol = text2;
				}
				string text3 = other.display_;
				if (text3.m_stringLength != 0)
				{
					Display = text3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4180", Offset = "0x2DA2B80", VA = "0x182DA4180", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007b
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (Symbol = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_0064;
				}
				string text4 = (Display = input.ReadString());
			}
			if (num == 13)
			{
				float num2 = (price_ = input.ReadFloat());
			}
			if (num == 18)
			{
				string text6 = (Currency = input.ReadString());
			}
			goto IL_0064;
			IL_0064:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3E70", Offset = "0x2DA2870", VA = "0x182DA3E70", Slot = "11")]
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
						if (num != 1)
						{
							ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
							/*Error: Unexpected end of block*/;
						}
						string text = display_;
					}
					string text2 = symbol_;
				}
				string text3 = currency_;
			}
			float num2 = price_;
			return typeof(float).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4270", Offset = "0x2DA2C70", VA = "0x182DA4270", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0040
			//IL_0025: Expected O, but got I4
			//IL_003f: Expected F4, but got O
			int num = fieldNumber - 1;
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
							Display = (string)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							break;
						}
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj = default(object);
				price_ = (float)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3A30", Offset = "0x2DA2430", VA = "0x182DA3A30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						Display = "";
						break;
					case 0:
						Symbol = "";
						break;
					}
				}
				else
				{
					Currency = "";
				}
			}
			else
			{
				price_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4550", Offset = "0x2DA2F50", VA = "0x182DA4550")]
		static RealCurrency()
		{
			Func<RealCurrency> func = default(Func<RealCurrency>);
			_parser = (MessageParser<RealCurrency>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
