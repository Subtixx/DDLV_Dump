using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	public sealed class ItemCurrencyFilter : BaseItemFilter, IMessage<ItemCurrencyFilter>, IMessage, IEquatable<ItemCurrencyFilter>, IDeepCloneable<ItemCurrencyFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		private static readonly MessageParser<ItemCurrencyFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private static readonly FieldCodec<int> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private readonly RepeatedField<int> values_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public const int MinAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private int minAmount_;

		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public const int MaxAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private int maxAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000402")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemCurrencyFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60011E8")]
			[Cpp2IlInjected.Address(RVA = "0x22CE340", Offset = "0x22CCD40", VA = "0x1822CE340")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000403")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60011E9")]
			[Cpp2IlInjected.Address(RVA = "0x22CE270", Offset = "0x22CCC70", VA = "0x1822CE270")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000404")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60011EA")]
			[Cpp2IlInjected.Address(RVA = "0x22CE3A0", Offset = "0x22CCDA0", VA = "0x1822CE3A0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000405")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60011EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000406")]
		[DebuggerNonUserCode]
		public int MinAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60011EF")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return minAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011F0")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				minAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000407")]
		[DebuggerNonUserCode]
		public int MaxAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60011F1")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return maxAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011F2")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				maxAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011EB")]
		[Cpp2IlInjected.Address(RVA = "0x22CE0E0", Offset = "0x22CCAE0", VA = "0x1822CE0E0")]
		[DebuggerNonUserCode]
		public ItemCurrencyFilter()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60011EC")]
		[Cpp2IlInjected.Address(RVA = "0x22CE160", Offset = "0x22CCB60", VA = "0x1822CE160")]
		[DebuggerNonUserCode]
		public ItemCurrencyFilter(ItemCurrencyFilter other)
		{
			((ServiceContainer)(object)this)._002Ector();
			RepeatedField<int> repeatedField = (values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			int num = (minAmount_ = other.minAmount_);
			int num2 = (maxAmount_ = other.maxAmount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011ED")]
		[Cpp2IlInjected.Address(RVA = "0x22CD1F0", Offset = "0x22CBBF0", VA = "0x1822CD1F0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemCurrencyFilter Clone()
		{
			//Discarded unreachable code: IL_005b
			ItemCurrencyFilter itemCurrencyFilter = new ItemCurrencyFilter();
			RepeatedField<int> repeatedField = (itemCurrencyFilter.values_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (itemCurrencyFilter.values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)values_).Clone());
			int num = (itemCurrencyFilter.minAmount_ = minAmount_);
			int num2 = (itemCurrencyFilter.maxAmount_ = maxAmount_);
			UnknownFieldSet unknownFieldSet = (itemCurrencyFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemCurrencyFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60011F3")]
		[Cpp2IlInjected.Address(RVA = "0x22CD520", Offset = "0x22CBF20", VA = "0x1822CD520", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = values_;
				bool flag = default(bool);
				if (flag && minAmount_ == (flag ? 1 : 0) && maxAmount_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011F4")]
		[Cpp2IlInjected.Address(RVA = "0x22CD480", Offset = "0x22CBE80", VA = "0x1822CD480", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemCurrencyFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = values_;
				RepeatedField<int> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.minAmount_;
					if (minAmount_ == num)
					{
						int num2 = other.maxAmount_;
						if (maxAmount_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x60011F5")]
		[Cpp2IlInjected.Address(RVA = "0x2004090", Offset = "0x2002A90", VA = "0x182004090", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0034
			int hashCode = ((RepeatedField<T>)(object)values_).GetHashCode();
			if (minAmount_ != 0)
			{
			}
			if (maxAmount_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60011F6")]
		[Cpp2IlInjected.Address(RVA = "0x22CD9B0", Offset = "0x22CC3B0", VA = "0x1822CD9B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60011F7")]
		[Cpp2IlInjected.Address(RVA = "0x22CDE90", Offset = "0x22CC890", VA = "0x1822CDE90", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			if (minAmount_ != 0)
			{
				int value = minAmount_;
				output.WriteInt32(value);
			}
			if (maxAmount_ != 0)
			{
				int value2 = maxAmount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60011F8")]
		[Cpp2IlInjected.Address(RVA = "0x22CD030", Offset = "0x22CBA30", VA = "0x1822CD030", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0075
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			int num2 = minAmount_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			int num4 = maxAmount_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60011F9")]
		[Cpp2IlInjected.Address(RVA = "0x22CD800", Offset = "0x22CC200", VA = "0x1822CD800", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemCurrencyFilter other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				RepeatedField<int> repeatedField = values_;
				RepeatedField<int> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.minAmount_;
				if (num != 0)
				{
					minAmount_ = num;
				}
				int num2 = other.maxAmount_;
				if (num2 != 0)
				{
					maxAmount_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011FA")]
		[Cpp2IlInjected.Address(RVA = "0x22CD6E0", Offset = "0x22CC0E0", VA = "0x1822CD6E0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 10)
			{
				if (num == 16)
				{
					int num2 = (minAmount_ = input.ReadInt32());
				}
				if (num != 24)
				{
					goto IL_0046;
				}
				int num3 = (maxAmount_ = input.ReadInt32());
			}
			num += 4294967288u;
			if (num != 4294967293u)
			{
				goto IL_0046;
			}
			goto IL_005a;
			IL_0046:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			goto IL_005a;
			IL_005a:
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x60011FB")]
		[Cpp2IlInjected.Address(RVA = "0x22CD610", Offset = "0x22CC010", VA = "0x1822CD610", Slot = "15")]
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
				int num2 = minAmount_;
			}
			RepeatedField<int> repeatedField = values_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011FC")]
		[Cpp2IlInjected.Address(RVA = "0x22CD890", Offset = "0x22CC290", VA = "0x1822CD890", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					maxAmount_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					minAmount_ = (int)obj;
					break;
				}
				}
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011FD")]
		[Cpp2IlInjected.Address(RVA = "0x22CD160", Offset = "0x22CBB60", VA = "0x1822CD160", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					maxAmount_ = 0;
					break;
				case 0:
					minAmount_ = 0;
					break;
				}
				return;
			}
			RepeatedField<int> repeatedField = values_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011FE")]
		[Cpp2IlInjected.Address(RVA = "0x22CD3D0", Offset = "0x22CBDD0", VA = "0x1822CD3D0", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0016
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				int itemID = x.Item.ItemID;
				bool flag = default(bool);
				if (flag)
				{
					List<CurrencyCost> itemPrices = default(List<CurrencyCost>);
					if (((RepeatedField<T>)(object)values_).Count > 0)
					{
						RepeatedField<int> repeatedField = values_;
						Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)delegate(int curId)
						{
							//Discarded unreachable code: IL_0030
							List<CurrencyCost> cpp2il__autoParamName__idx_3 = itemPrices;
							Func<CurrencyCost, bool> cpp2il__autoParamName__idx_4 = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost y)
							{
								//Discarded unreachable code: IL_002c
								int num5 = curId;
								if (y.id_ == num5)
								{
									ItemCurrencyFilter itemCurrencyFilter = this;
									int amount_2 = y.amount_;
									int num6 = itemCurrencyFilter.maxAmount_;
									return true;
								}
								int num7 = 0;
								throw new NullReferenceException();
							};
							return ((IEnumerable<>)cpp2il__autoParamName__idx_3).Any<CurrencyCost>((Func<, >)(object)cpp2il__autoParamName__idx_4);
						};
						bool flag2 = ((RepeatedField<>)(object)repeatedField).Any<int>((Predicate<>)(object)predicate2);
					}
					List<CurrencyCost> cpp2il__autoParamName__idx_ = itemPrices;
					Func<CurrencyCost, bool> cpp2il__autoParamName__idx_2 = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost y)
					{
						//Discarded unreachable code: IL_001f, IL_002b
						int amount_ = y.amount_;
						if (amount_ < minAmount_)
						{
							int num3 = 0;
						}
						int num4 = maxAmount_;
						return false;
					};
					if (((IEnumerable<>)cpp2il__autoParamName__idx_).Any<CurrencyCost>((Func<, >)(object)cpp2il__autoParamName__idx_2))
					{
						int num2 = 0;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60011FF")]
		[Cpp2IlInjected.Address(RVA = "0x22CD320", Offset = "0x22CBD20", VA = "0x1822CD320", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0016
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				int itemID = x.Item.ItemID;
				bool flag = default(bool);
				if (flag)
				{
					List<CurrencyCost> itemPrices = default(List<CurrencyCost>);
					if (((RepeatedField<T>)(object)values_).Count > 0)
					{
						RepeatedField<int> repeatedField = values_;
						Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)delegate(int curId)
						{
							//Discarded unreachable code: IL_0030
							List<CurrencyCost> cpp2il__autoParamName__idx_3 = itemPrices;
							Func<CurrencyCost, bool> cpp2il__autoParamName__idx_4 = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost y)
							{
								//Discarded unreachable code: IL_002c
								int num4 = curId;
								if (y.id_ == num4)
								{
									ItemCurrencyFilter itemCurrencyFilter = this;
									int amount_2 = y.amount_;
									int num5 = itemCurrencyFilter.maxAmount_;
									return true;
								}
								int num6 = 0;
								throw new NullReferenceException();
							};
							return ((IEnumerable<>)cpp2il__autoParamName__idx_3).Any<CurrencyCost>((Func<, >)(object)cpp2il__autoParamName__idx_4);
						};
						bool flag2 = ((RepeatedField<>)(object)repeatedField).Any<int>((Predicate<>)(object)predicate2);
					}
					List<CurrencyCost> cpp2il__autoParamName__idx_ = itemPrices;
					Func<CurrencyCost, bool> cpp2il__autoParamName__idx_2 = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost y)
					{
						//Discarded unreachable code: IL_001f, IL_002b
						int amount_ = y.amount_;
						if (amount_ < minAmount_)
						{
							int num2 = 0;
						}
						int num3 = maxAmount_;
						return false;
					};
					if (((IEnumerable<>)cpp2il__autoParamName__idx_).Any<CurrencyCost>((Func<, >)(object)cpp2il__autoParamName__idx_2))
					{
						return true;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001200")]
		[Cpp2IlInjected.Address(RVA = "0x22CDFA0", Offset = "0x22CC9A0", VA = "0x1822CDFA0")]
		static ItemCurrencyFilter()
		{
			Func<ItemCurrencyFilter> func = default(Func<ItemCurrencyFilter>);
			_parser = (MessageParser<ItemCurrencyFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemCurrencyFilter>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
