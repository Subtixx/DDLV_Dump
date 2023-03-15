using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x200085B")]
	public sealed class XpRewardTable : IDataValidation, IMessage<XpRewardTable>, IMessage, IEquatable<XpRewardTable>, IDeepCloneable<XpRewardTable>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002954")]
		private static readonly MessageParser<XpRewardTable> _parser = (MessageParser<XpRewardTable>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new XpRewardTable()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002955")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002956")]
		public const int CharacterXpPercentageFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002957")]
		private int characterXpPercentage_;

		[Cpp2IlInjected.Token(Token = "0x4002958")]
		public const int WeightsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002959")]
		private static readonly FieldCodec<XpWeight> _repeated_weights_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400295A")]
		private readonly RepeatedField<XpWeight> weights_ = (RepeatedField<XpWeight>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700178A")]
		public int TotalWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6005D67")]
			[Cpp2IlInjected.Address(RVA = "0x17D28D0", Offset = "0x17D12D0", VA = "0x1817D28D0")]
			get
			{
				RepeatedField<XpWeight> repeatedField = weights_;
				Func<XpWeight, int> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((XpWeight x) => x.weight_);
				}
				return Enumerable.Sum<XpWeight>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__2_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178B")]
		[DebuggerNonUserCode]
		public static MessageParser<XpRewardTable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005D69")]
			[Cpp2IlInjected.Address(RVA = "0x17D2870", Offset = "0x17D1270", VA = "0x1817D2870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D6A")]
			[Cpp2IlInjected.Address(RVA = "0x17D27A0", Offset = "0x17D11A0", VA = "0x1817D27A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D6B")]
			[Cpp2IlInjected.Address(RVA = "0x17D2A00", Offset = "0x17D1400", VA = "0x1817D2A00", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178E")]
		[DebuggerNonUserCode]
		public int CharacterXpPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6005D6F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return characterXpPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D70")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				characterXpPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178F")]
		[DebuggerNonUserCode]
		public RepeatedField<XpWeight> Weights
		{
			[Cpp2IlInjected.Token(Token = "0x6005D71")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return weights_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D66")]
		[Cpp2IlInjected.Address(RVA = "0x17D2340", Offset = "0x17D0D40", VA = "0x1817D2340")]
		public int TotalXP(int maxLevelXP)
		{
			ulong num = num + num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D68")]
		[Cpp2IlInjected.Address(RVA = "0x17D1C90", Offset = "0x17D0690", VA = "0x1817D1C90", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003c, IL_0042
			int num = 0;
			if (((RepeatedField<T>)(object)weights_).Count == 0)
			{
				context.AddInvalidMemberError("Cannot be empty", "Weights");
			}
			RepeatedField<XpWeight> repeatedField = weights_;
			bool flag = default(bool);
			if (flag)
			{
				context.AddInvalidMemberError("Elements must be in ascending order", "Weights");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D6C")]
		[Cpp2IlInjected.Address(RVA = "0x17D2720", Offset = "0x17D1120", VA = "0x1817D2720")]
		[DebuggerNonUserCode]
		public XpRewardTable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005D6D")]
		[Cpp2IlInjected.Address(RVA = "0x17D2620", Offset = "0x17D1020", VA = "0x1817D2620")]
		[DebuggerNonUserCode]
		public XpRewardTable(XpRewardTable other)
		{
			int num = (characterXpPercentage_ = other.characterXpPercentage_);
			RepeatedField<XpWeight> repeatedField = (weights_ = (RepeatedField<XpWeight>)(object)((RepeatedField<T>)(object)other.weights_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D6E")]
		[Cpp2IlInjected.Address(RVA = "0x17D1B60", Offset = "0x17D0560", VA = "0x1817D1B60", Slot = "11")]
		[DebuggerNonUserCode]
		public XpRewardTable Clone()
		{
			//Discarded unreachable code: IL_004b
			XpRewardTable xpRewardTable = new XpRewardTable();
			RepeatedField<XpWeight> repeatedField = (xpRewardTable.weights_ = (RepeatedField<XpWeight>)(object)new RepeatedField<T>());
			int num = (xpRewardTable.characterXpPercentage_ = characterXpPercentage_);
			RepeatedField<XpWeight> repeatedField2 = (xpRewardTable.weights_ = (RepeatedField<XpWeight>)(object)((RepeatedField<T>)(object)weights_).Clone());
			UnknownFieldSet unknownFieldSet = (xpRewardTable._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return xpRewardTable;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D72")]
		[Cpp2IlInjected.Address(RVA = "0x17D1E30", Offset = "0x17D0830", VA = "0x1817D1E30", Slot = "0")]
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
				if ((IntPtr)characterXpPercentage_ == (IntPtr)typeof(XpRewardTable).TypeHandle)
				{
					RepeatedField<XpWeight> repeatedField = weights_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D73")]
		[Cpp2IlInjected.Address(RVA = "0x17D1F10", Offset = "0x17D0910", VA = "0x1817D1F10", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(XpRewardTable other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.characterXpPercentage_;
				if (characterXpPercentage_ == num)
				{
					RepeatedField<XpWeight> repeatedField = weights_;
					RepeatedField<XpWeight> repeatedField2 = other.weights_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D74")]
		[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (characterXpPercentage_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)weights_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D75")]
		[Cpp2IlInjected.Address(RVA = "0x17D22E0", Offset = "0x17D0CE0", VA = "0x1817D22E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D76")]
		[Cpp2IlInjected.Address(RVA = "0x17D2360", Offset = "0x17D0D60", VA = "0x1817D2360", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (characterXpPercentage_ != 0)
			{
				int value = characterXpPercentage_;
				output.WriteInt32(value);
			}
			RepeatedField<XpWeight> repeatedField = weights_;
			FieldCodec<XpWeight> repeated_weights_codec = _repeated_weights_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_weights_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D77")]
		[Cpp2IlInjected.Address(RVA = "0x17D1A00", Offset = "0x17D0400", VA = "0x1817D1A00", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			int num = characterXpPercentage_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<XpWeight> repeatedField = weights_;
			FieldCodec<XpWeight> repeated_weights_codec = _repeated_weights_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_weights_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += num5;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D78")]
		[Cpp2IlInjected.Address(RVA = "0x17D2180", Offset = "0x17D0B80", VA = "0x1817D2180", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(XpRewardTable other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				int num = other.characterXpPercentage_;
				if (num != 0)
				{
					characterXpPercentage_ = num;
				}
				RepeatedField<XpWeight> repeatedField = weights_;
				RepeatedField<XpWeight> repeatedField2 = other.weights_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D79")]
		[Cpp2IlInjected.Address(RVA = "0x17D2080", Offset = "0x17D0A80", VA = "0x1817D2080", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (characterXpPercentage_ = input.ReadInt32());
				}
				if (num == 18)
				{
					RepeatedField<XpWeight> repeatedField = weights_;
					FieldCodec<XpWeight> repeated_weights_codec = _repeated_weights_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_weights_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D7A")]
		[Cpp2IlInjected.Address(RVA = "0x17D1FB0", Offset = "0x17D09B0", VA = "0x1817D1FB0", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = characterXpPercentage_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<XpWeight> repeatedField = weights_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D7B")]
		[Cpp2IlInjected.Address(RVA = "0x17D2210", Offset = "0x17D0C10", VA = "0x1817D2210", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				characterXpPercentage_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D7C")]
		[Cpp2IlInjected.Address(RVA = "0x17D1AF0", Offset = "0x17D04F0", VA = "0x1817D1AF0", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				characterXpPercentage_ = 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<XpWeight> repeatedField = weights_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D7D")]
		[Cpp2IlInjected.Address(RVA = "0x17D2450", Offset = "0x17D0E50", VA = "0x1817D2450")]
		static XpRewardTable()
		{
			MessageParser<XpWeight> parser = XpWeight._parser;
			uint num = default(uint);
			_parser = (MessageParser<XpRewardTable>)(object)FieldCodec.ForMessage<XpWeight>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
