using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Keyholes
{
	[Cpp2IlInjected.Token(Token = "0x2000272")]
	public sealed class CompletionLevel : IMessage<CompletionLevel>, IMessage, IEquatable<CompletionLevel>, IDeepCloneable<CompletionLevel>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40009A8")]
		private static readonly MessageParser<CompletionLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009A9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009AA")]
		public const int NeededItemsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40009AB")]
		private static readonly FieldCodec<KeyholeContent> _repeated_neededItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009AC")]
		private readonly RepeatedField<KeyholeContent> neededItems_ = (RepeatedField<KeyholeContent>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40009AD")]
		public const int FilterByTypeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009AE")]
		private bool filterByType_;

		[Cpp2IlInjected.Token(Token = "0x40009AF")]
		public const int AcceptedItemsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40009B0")]
		private static readonly FieldCodec<int> _repeated_acceptedItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40009B1")]
		private readonly RepeatedField<int> acceptedItems_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40009B2")]
		public const int AcceptedItemTypeFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40009B3")]
		private static readonly FieldCodec<ActivityItemType> _repeated_acceptedItemType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40009B4")]
		private readonly RepeatedField<ActivityItemType> acceptedItemType_ = (RepeatedField<ActivityItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000524")]
		[DebuggerNonUserCode]
		public static MessageParser<CompletionLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001745")]
			[Cpp2IlInjected.Address(RVA = "0x3210520", Offset = "0x320EF20", VA = "0x183210520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000525")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001746")]
			[Cpp2IlInjected.Address(RVA = "0x3210450", Offset = "0x320EE50", VA = "0x183210450")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000526")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001747")]
			[Cpp2IlInjected.Address(RVA = "0x3210580", Offset = "0x320EF80", VA = "0x183210580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000527")]
		[DebuggerNonUserCode]
		public RepeatedField<KeyholeContent> NeededItems
		{
			[Cpp2IlInjected.Token(Token = "0x600174B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return neededItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000528")]
		[DebuggerNonUserCode]
		public bool FilterByType
		{
			[Cpp2IlInjected.Token(Token = "0x600174C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return filterByType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600174D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				filterByType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000529")]
		[DebuggerNonUserCode]
		public RepeatedField<int> AcceptedItems
		{
			[Cpp2IlInjected.Token(Token = "0x600174E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return acceptedItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052A")]
		[DebuggerNonUserCode]
		public RepeatedField<ActivityItemType> AcceptedItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600174F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return acceptedItemType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001748")]
		[Cpp2IlInjected.Address(RVA = "0x3210150", Offset = "0x320EB50", VA = "0x183210150")]
		[DebuggerNonUserCode]
		public CompletionLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001749")]
		[Cpp2IlInjected.Address(RVA = "0x3210250", Offset = "0x320EC50", VA = "0x183210250")]
		[DebuggerNonUserCode]
		public CompletionLevel(CompletionLevel other)
		{
			RepeatedField<KeyholeContent> repeatedField = (neededItems_ = (RepeatedField<KeyholeContent>)(object)((RepeatedField<T>)(object)other.neededItems_).Clone());
			bool flag = (filterByType_ = other.filterByType_);
			RepeatedField<int> repeatedField2 = (acceptedItems_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.acceptedItems_).Clone());
			RepeatedField<ActivityItemType> repeatedField3 = (acceptedItemType_ = (RepeatedField<ActivityItemType>)(object)((RepeatedField<T>)(object)other.acceptedItemType_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600174A")]
		[Cpp2IlInjected.Address(RVA = "0x320F200", Offset = "0x320DC00", VA = "0x18320F200", Slot = "10")]
		[DebuggerNonUserCode]
		public CompletionLevel Clone()
		{
			return new CompletionLevel(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001750")]
		[Cpp2IlInjected.Address(RVA = "0x320F530", Offset = "0x320DF30", VA = "0x18320F530", Slot = "0")]
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
				RepeatedField<KeyholeContent> repeatedField = neededItems_;
				bool flag = default(bool);
				if (flag && filterByType_ == flag)
				{
					RepeatedField<int> repeatedField2 = acceptedItems_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<ActivityItemType> repeatedField3 = acceptedItemType_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001751")]
		[Cpp2IlInjected.Address(RVA = "0x320F440", Offset = "0x320DE40", VA = "0x18320F440", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CompletionLevel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<KeyholeContent> repeatedField = neededItems_;
				RepeatedField<KeyholeContent> repeatedField2 = other.neededItems_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					bool flag = other.filterByType_;
					if (filterByType_ == flag)
					{
						RepeatedField<int> repeatedField3 = acceptedItems_;
						RepeatedField<int> repeatedField4 = other.acceptedItems_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							RepeatedField<ActivityItemType> repeatedField5 = acceptedItemType_;
							RepeatedField<ActivityItemType> repeatedField6 = other.acceptedItemType_;
							if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
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

		[Cpp2IlInjected.Token(Token = "0x6001752")]
		[Cpp2IlInjected.Address(RVA = "0x320F760", Offset = "0x320E160", VA = "0x18320F760", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004d
			int hashCode = ((RepeatedField<T>)(object)neededItems_).GetHashCode();
			if (filterByType_)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)acceptedItems_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)acceptedItemType_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode = hashCode3;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6001753")]
		[Cpp2IlInjected.Address(RVA = "0x320FC70", Offset = "0x320E670", VA = "0x18320FC70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001754")]
		[Cpp2IlInjected.Address(RVA = "0x320FCD0", Offset = "0x320E6D0", VA = "0x18320FCD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0072
			RepeatedField<KeyholeContent> repeatedField = neededItems_;
			FieldCodec<KeyholeContent> repeated_neededItems_codec = _repeated_neededItems_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_neededItems_codec);
			if (filterByType_)
			{
				bool value = filterByType_;
				output.WriteBool(value);
			}
			RepeatedField<int> repeatedField2 = acceptedItems_;
			FieldCodec<int> repeated_acceptedItems_codec = _repeated_acceptedItems_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_acceptedItems_codec);
			RepeatedField<ActivityItemType> repeatedField3 = acceptedItemType_;
			FieldCodec<ActivityItemType> repeated_acceptedItemType_codec = _repeated_acceptedItemType_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_acceptedItemType_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001755")]
		[Cpp2IlInjected.Address(RVA = "0x320F010", Offset = "0x320DA10", VA = "0x18320F010", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			RepeatedField<KeyholeContent> repeatedField = neededItems_;
			FieldCodec<KeyholeContent> repeated_neededItems_codec = _repeated_neededItems_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_neededItems_codec);
			RepeatedField<int> repeatedField2 = acceptedItems_;
			FieldCodec<int> repeated_acceptedItems_codec = _repeated_acceptedItems_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_acceptedItems_codec);
			RepeatedField<ActivityItemType> repeatedField3 = acceptedItemType_;
			FieldCodec<ActivityItemType> repeated_acceptedItemType_codec = _repeated_acceptedItemType_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_acceptedItemType_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num4);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001756")]
		[Cpp2IlInjected.Address(RVA = "0x320FA20", Offset = "0x320E420", VA = "0x18320FA20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CompletionLevel other)
		{
			//Discarded unreachable code: IL_007b
			if (other != null)
			{
				RepeatedField<KeyholeContent> repeatedField = neededItems_;
				RepeatedField<KeyholeContent> repeatedField2 = other.neededItems_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.filterByType_;
				if (flag)
				{
					filterByType_ = flag;
				}
				RepeatedField<int> repeatedField3 = acceptedItems_;
				RepeatedField<int> repeatedField4 = other.acceptedItems_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<ActivityItemType> repeatedField5 = acceptedItemType_;
				RepeatedField<ActivityItemType> repeatedField6 = other.acceptedItemType_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001757")]
		[Cpp2IlInjected.Address(RVA = "0x320F830", Offset = "0x320E230", VA = "0x18320F830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if (num == 50)
				{
					goto IL_0074;
				}
				num += 4294967240u;
				if (num != 4294967293u)
				{
					goto IL_008d;
				}
				RepeatedField<ActivityItemType> repeatedField = acceptedItemType_;
				FieldCodec<ActivityItemType> repeated_acceptedItemType_codec = _repeated_acceptedItemType_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_acceptedItemType_codec);
			}
			if (num == 34)
			{
				RepeatedField<KeyholeContent> repeatedField2 = neededItems_;
				FieldCodec<KeyholeContent> repeated_neededItems_codec = _repeated_neededItems_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_neededItems_codec);
			}
			bool flag = default(bool);
			if (num == 40)
			{
				flag = (filterByType_ = input.ReadBool());
			}
			if (flag)
			{
				goto IL_0074;
			}
			goto IL_008d;
			IL_0074:
			RepeatedField<int> repeatedField3 = acceptedItems_;
			FieldCodec<int> repeated_acceptedItems_codec = _repeated_acceptedItems_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_acceptedItems_codec);
			goto IL_008d;
			IL_008d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001758")]
		[Cpp2IlInjected.Address(RVA = "0x320F670", Offset = "0x320E070", VA = "0x18320F670", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 0)
			{
				if (fieldNumber != 0)
				{
					if (fieldNumber != 0)
					{
						if (fieldNumber != 1)
						{
							goto IL_002c;
						}
						RepeatedField<ActivityItemType> repeatedField = acceptedItemType_;
					}
					RepeatedField<int> repeatedField2 = acceptedItems_;
				}
				bool flag = filterByType_;
			}
			RepeatedField<KeyholeContent> repeatedField3 = neededItems_;
			goto IL_002c;
			IL_002c:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001759")]
		[Cpp2IlInjected.Address(RVA = "0x320FAF0", Offset = "0x320E4F0", VA = "0x18320FAF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			object obj = default(object);
			while (true)
			{
				if (fieldNumber != 0)
				{
					if (fieldNumber != 0)
					{
						if (fieldNumber == 0)
						{
							continue;
						}
						if (fieldNumber == 1)
						{
							break;
						}
					}
					filterByType_ = (byte)(int)obj != 0;
					return;
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600175A")]
		[Cpp2IlInjected.Address(RVA = "0x320F170", Offset = "0x320DB70", VA = "0x18320F170", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 0)
			{
				if (fieldNumber == 0 || fieldNumber == 0 || fieldNumber == 1)
				{
					filterByType_ = false;
				}
				return;
			}
			RepeatedField<KeyholeContent> repeatedField = neededItems_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600175B")]
		[Cpp2IlInjected.Address(RVA = "0x320F260", Offset = "0x320DC60", VA = "0x18320F260", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004d, IL_0053, IL_0059
			//IL_0039: Expected O, but got I4
			int num = 0;
			RepeatedField<KeyholeContent> repeatedField = neededItems_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (!filterByType_)
			{
				RepeatedField<int> repeatedField2 = acceptedItems_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					int num2 = default(int);
					string message = string.Format("{0}[{1}] must be part of {2}", "NeededItems", num2, "AcceptedItems");
					context.AddInvalidMemberError(message, "AcceptedItems");
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x600175C")]
		[Cpp2IlInjected.Address(RVA = "0x320FE50", Offset = "0x320E850", VA = "0x18320FE50")]
		static CompletionLevel()
		{
			Func<CompletionLevel> func = default(Func<CompletionLevel>);
			MessageParser<CompletionLevel> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<CompletionLevel>)(object)new MessageParser<T>((Func<>)(object)func));
			MessageParser<KeyholeContent> parser = KeyholeContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<CompletionLevel>)(object)FieldCodec.ForMessage<KeyholeContent>(num, (MessageParser<>)(object)parser);
			_parser = (MessageParser<CompletionLevel>)(object)FieldCodec.ForInt32(50u);
			Func<ActivityItemType, int> func2 = (Func<ActivityItemType, int>)(object)(Func<T, TResult>)((ActivityItemType x) => (int)x);
			Func<int, ActivityItemType> func3 = (Func<int, ActivityItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num2 = default(uint);
			_parser = (MessageParser<CompletionLevel>)(object)FieldCodec.ForEnum<ActivityItemType>(num2, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
