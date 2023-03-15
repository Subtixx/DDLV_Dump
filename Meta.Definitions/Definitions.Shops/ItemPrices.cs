using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	public sealed class ItemPrices : IMessage<ItemPrices>, IMessage, IEquatable<ItemPrices>, IDeepCloneable<ItemPrices>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private static readonly MessageParser<ItemPrices> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public const int PricesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private static readonly FieldCodec<CurrencyCost> _repeated_prices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private readonly RepeatedField<CurrencyCost> prices_ = (RepeatedField<CurrencyCost>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public const int SoftCurrencySellPriceFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private int softCurrencySellPrice_;

		[Cpp2IlInjected.Token(Token = "0x17000376")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemPrices> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000E57")]
			[Cpp2IlInjected.Address(RVA = "0x25EB030", Offset = "0x25E9A30", VA = "0x1825EB030")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000377")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E58")]
			[Cpp2IlInjected.Address(RVA = "0x25EAF60", Offset = "0x25E9960", VA = "0x1825EAF60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000378")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E59")]
			[Cpp2IlInjected.Address(RVA = "0x25EB090", Offset = "0x25E9A90", VA = "0x1825EB090", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000E5E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E5F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyCost> Prices
		{
			[Cpp2IlInjected.Token(Token = "0x6000E60")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return prices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		[DebuggerNonUserCode]
		public int SoftCurrencySellPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000E61")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return softCurrencySellPrice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E62")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				softCurrencySellPrice_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0x25EADD0", Offset = "0x25E97D0", VA = "0x1825EADD0")]
		[DebuggerNonUserCode]
		public ItemPrices()
		{
			//IL_001c: Expected I4, but got I8
			softCurrencySellPrice_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0x25EA970", Offset = "0x25E9370", VA = "0x1825EA970")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			softCurrencySellPrice_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0x25EAE50", Offset = "0x25E9850", VA = "0x1825EAE50")]
		[DebuggerNonUserCode]
		public ItemPrices(ItemPrices other)
		{
			//IL_001c: Expected I4, but got I8
			softCurrencySellPrice_ = 1;
			int num = (id_ = other.id_);
			RepeatedField<CurrencyCost> repeatedField = (prices_ = (RepeatedField<CurrencyCost>)(object)((RepeatedField<T>)(object)other.prices_).Clone());
			int num2 = (softCurrencySellPrice_ = other.softCurrencySellPrice_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0x25EA380", Offset = "0x25E8D80", VA = "0x1825EA380", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemPrices Clone()
		{
			//Discarded unreachable code: IL_0064
			//IL_001c: Expected I4, but got I8
			ItemPrices itemPrices = new ItemPrices();
			RepeatedField<CurrencyCost> repeatedField = (itemPrices.prices_ = (RepeatedField<CurrencyCost>)(object)new RepeatedField<T>());
			itemPrices.softCurrencySellPrice_ = 1;
			int num = (itemPrices.id_ = id_);
			RepeatedField<CurrencyCost> repeatedField2 = (itemPrices.prices_ = (RepeatedField<CurrencyCost>)(object)((RepeatedField<T>)(object)prices_).Clone());
			int num2 = (itemPrices.softCurrencySellPrice_ = softCurrencySellPrice_);
			UnknownFieldSet unknownFieldSet = (itemPrices._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemPrices;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0x25EA4C0", Offset = "0x25E8EC0", VA = "0x1825EA4C0", Slot = "0")]
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
				if ((IntPtr)id_ == (IntPtr)typeof(ItemPrices).TypeHandle)
				{
					RepeatedField<CurrencyCost> repeatedField = prices_;
					bool flag = default(bool);
					if (flag && softCurrencySellPrice_ == (flag ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E64")]
		[Cpp2IlInjected.Address(RVA = "0x25EA5B0", Offset = "0x25E8FB0", VA = "0x1825EA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemPrices other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.id_;
				if (id_ == num)
				{
					RepeatedField<CurrencyCost> repeatedField = prices_;
					RepeatedField<CurrencyCost> repeatedField2 = other.prices_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						int num2 = other.softCurrencySellPrice_;
						if (softCurrencySellPrice_ == num2)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E65")]
		[Cpp2IlInjected.Address(RVA = "0x25EA720", Offset = "0x25E9120", VA = "0x1825EA720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0032
			if (id_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)prices_).GetHashCode();
			if (softCurrencySellPrice_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E66")]
		[Cpp2IlInjected.Address(RVA = "0x25EAA90", Offset = "0x25E9490", VA = "0x1825EAA90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E67")]
		[Cpp2IlInjected.Address(RVA = "0x25EAAF0", Offset = "0x25E94F0", VA = "0x1825EAAF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			RepeatedField<CurrencyCost> repeatedField = prices_;
			FieldCodec<CurrencyCost> repeated_prices_codec = _repeated_prices_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_prices_codec);
			if (softCurrencySellPrice_ != 0)
			{
				int value2 = softCurrencySellPrice_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E68")]
		[Cpp2IlInjected.Address(RVA = "0x25EA1C0", Offset = "0x25E8BC0", VA = "0x1825EA1C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_006f
			int num = id_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<CurrencyCost> repeatedField = prices_;
			FieldCodec<CurrencyCost> repeated_prices_codec = _repeated_prices_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_prices_codec);
			int num5 = softCurrencySellPrice_;
			num2 += num4;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num2 += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E69")]
		[Cpp2IlInjected.Address(RVA = "0x25EA7C0", Offset = "0x25E91C0", VA = "0x1825EA7C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemPrices other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				int num = other.id_;
				if (num != 0)
				{
					id_ = num;
				}
				RepeatedField<CurrencyCost> repeatedField = prices_;
				RepeatedField<CurrencyCost> repeatedField2 = other.prices_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num2 = other.softCurrencySellPrice_;
				if (num2 != 0)
				{
					softCurrencySellPrice_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6A")]
		[Cpp2IlInjected.Address(RVA = "0x25EA850", Offset = "0x25E9250", VA = "0x1825EA850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0067
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (id_ = input.ReadInt32());
				}
				if (num == 18)
				{
					RepeatedField<CurrencyCost> repeatedField = prices_;
					FieldCodec<CurrencyCost> repeated_prices_codec = _repeated_prices_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_prices_codec);
				}
				if (num == 24)
				{
					int num3 = (softCurrencySellPrice_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6B")]
		[Cpp2IlInjected.Address(RVA = "0x25EA650", Offset = "0x25E9050", VA = "0x1825EA650", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 1)
				{
					goto IL_001e;
				}
				RepeatedField<CurrencyCost> repeatedField = prices_;
			}
			int num2 = id_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0x25EA980", Offset = "0x25E9380", VA = "0x1825EA980", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0020
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					softCurrencySellPrice_ = (int)obj;
					break;
				}
				case 0:
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					/*Error: Unexpected end of block*/;
				}
				}
			}
			else
			{
				object obj2 = default(object);
				id_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6D")]
		[Cpp2IlInjected.Address(RVA = "0x25EA2F0", Offset = "0x25E8CF0", VA = "0x1825EA2F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_002b
			//IL_0019: Expected I4, but got I8
			//IL_002a: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					softCurrencySellPrice_ = 0;
					return;
				case 0:
					break;
				default:
					return;
				}
				RepeatedField<CurrencyCost> repeatedField = prices_;
			}
			id_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6E")]
		[Cpp2IlInjected.Address(RVA = "0x25EAC00", Offset = "0x25E9600", VA = "0x1825EAC00")]
		static ItemPrices()
		{
			Func<ItemPrices> func = default(Func<ItemPrices>);
			_parser = (MessageParser<ItemPrices>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<CurrencyCost> parser = CurrencyCost._parser;
			uint num = default(uint);
			_parser = (MessageParser<ItemPrices>)(object)FieldCodec.ForMessage<CurrencyCost>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
