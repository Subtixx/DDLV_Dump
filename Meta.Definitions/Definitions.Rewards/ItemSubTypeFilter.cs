using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public sealed class ItemSubTypeFilter : BaseItemFilter, IMessage<ItemSubTypeFilter>, IMessage, IEquatable<ItemSubTypeFilter>, IDeepCloneable<ItemSubTypeFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private static readonly MessageParser<ItemSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public const int SubTypesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private static readonly FieldCodec<SubTypeOption> _repeated_subTypes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private readonly RepeatedField<SubTypeOption> subTypes_ = (RepeatedField<SubTypeOption>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000FD7")]
			[Cpp2IlInjected.Address(RVA = "0x645870", Offset = "0x644270", VA = "0x180645870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FD8")]
			[Cpp2IlInjected.Address(RVA = "0x6457A0", Offset = "0x6441A0", VA = "0x1806457A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FD9")]
			[Cpp2IlInjected.Address(RVA = "0x6458D0", Offset = "0x6442D0", VA = "0x1806458D0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		[DebuggerNonUserCode]
		public RepeatedField<SubTypeOption> SubTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000FDD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return subTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDA")]
		[Cpp2IlInjected.Address(RVA = "0x645620", Offset = "0x644020", VA = "0x180645620")]
		[DebuggerNonUserCode]
		public ItemSubTypeFilter()
		{
			((LicenseManager)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDB")]
		[Cpp2IlInjected.Address(RVA = "0x6456A0", Offset = "0x6440A0", VA = "0x1806456A0")]
		[DebuggerNonUserCode]
		public ItemSubTypeFilter(ItemSubTypeFilter other)
		{
			((LicenseManager)(object)this)._002Ector();
			RepeatedField<SubTypeOption> repeatedField = (subTypes_ = (RepeatedField<SubTypeOption>)(object)((RepeatedField<T>)(object)other.subTypes_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDC")]
		[Cpp2IlInjected.Address(RVA = "0x644C40", Offset = "0x643640", VA = "0x180644C40", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemSubTypeFilter itemSubTypeFilter = new ItemSubTypeFilter();
			RepeatedField<SubTypeOption> repeatedField = (itemSubTypeFilter.subTypes_ = (RepeatedField<SubTypeOption>)(object)new RepeatedField<T>());
			RepeatedField<SubTypeOption> repeatedField2 = (itemSubTypeFilter.subTypes_ = (RepeatedField<SubTypeOption>)(object)((RepeatedField<T>)(object)subTypes_).Clone());
			UnknownFieldSet unknownFieldSet = (itemSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDE")]
		[Cpp2IlInjected.Address(RVA = "0x644F70", Offset = "0x643970", VA = "0x180644F70", Slot = "0")]
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
				RepeatedField<SubTypeOption> repeatedField = subTypes_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDF")]
		[Cpp2IlInjected.Address(RVA = "0x645050", Offset = "0x643A50", VA = "0x180645050", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<SubTypeOption> repeatedField = subTypes_;
				RepeatedField<SubTypeOption> repeatedField2 = other.subTypes_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE0")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)subTypes_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE1")]
		[Cpp2IlInjected.Address(RVA = "0x645330", Offset = "0x643D30", VA = "0x180645330", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE2")]
		[Cpp2IlInjected.Address(RVA = "0x645390", Offset = "0x643D90", VA = "0x180645390", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<SubTypeOption> repeatedField = subTypes_;
			FieldCodec<SubTypeOption> repeated_subTypes_codec = _repeated_subTypes_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_subTypes_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE3")]
		[Cpp2IlInjected.Address(RVA = "0x644B30", Offset = "0x643530", VA = "0x180644B30", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<SubTypeOption> repeatedField = subTypes_;
			FieldCodec<SubTypeOption> repeated_subTypes_codec = _repeated_subTypes_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_subTypes_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE4")]
		[Cpp2IlInjected.Address(RVA = "0x645250", Offset = "0x643C50", VA = "0x180645250", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<SubTypeOption> repeatedField = subTypes_;
				RepeatedField<SubTypeOption> repeatedField2 = other.subTypes_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE5")]
		[Cpp2IlInjected.Address(RVA = "0x645160", Offset = "0x643B60", VA = "0x180645160", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<SubTypeOption> repeatedField = subTypes_;
					FieldCodec<SubTypeOption> repeated_subTypes_codec = _repeated_subTypes_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_subTypes_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE6")]
		[Cpp2IlInjected.Address(RVA = "0x6450E0", Offset = "0x643AE0", VA = "0x1806450E0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<SubTypeOption> repeatedField = subTypes_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE7")]
		[Cpp2IlInjected.Address(RVA = "0x6452D0", Offset = "0x643CD0", VA = "0x1806452D0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE8")]
		[Cpp2IlInjected.Address(RVA = "0x644BE0", Offset = "0x6435E0", VA = "0x180644BE0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<SubTypeOption> repeatedField = subTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE9")]
		[Cpp2IlInjected.Address(RVA = "0x644E70", Offset = "0x643870", VA = "0x180644E70", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0033, IL_0039, IL_003f
				int num3;
				bool flag = default(bool);
				while (true)
				{
					int num2 = 0;
					num3 = 0;
					RepeatedField<SubTypeOption> repeatedField = subTypes_;
					if (!flag)
					{
						break;
					}
					if ((object)x.Item != null)
					{
						int num4 = 0;
						num3++;
						break;
					}
				}
				if (num3 + 1 != 0)
				{
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FEA")]
		[Cpp2IlInjected.Address(RVA = "0x644D70", Offset = "0x643770", VA = "0x180644D70", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0030, IL_0036, IL_003c
				int num3;
				bool flag = default(bool);
				while (true)
				{
					int num2 = 0;
					num3 = 0;
					RepeatedField<SubTypeOption> repeatedField = subTypes_;
					if (!flag)
					{
						break;
					}
					if ((object)x.Item != null)
					{
						num3++;
						break;
					}
				}
				if (num3 + 1 != 0)
				{
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FEB")]
		[Cpp2IlInjected.Address(RVA = "0x645450", Offset = "0x643E50", VA = "0x180645450")]
		static ItemSubTypeFilter()
		{
			Func<ItemSubTypeFilter> func = default(Func<ItemSubTypeFilter>);
			_parser = (MessageParser<ItemSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<SubTypeOption> parser = SubTypeOption._parser;
			uint num = default(uint);
			_parser = (MessageParser<ItemSubTypeFilter>)(object)FieldCodec.ForMessage<SubTypeOption>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
