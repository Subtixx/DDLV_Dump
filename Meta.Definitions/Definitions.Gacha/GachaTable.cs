using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x200071F")]
	public sealed class GachaTable : IMessage<GachaTable>, IMessage, IEquatable<GachaTable>, IDeepCloneable<GachaTable>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023C3")]
		private static readonly MessageParser<GachaTable> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023C4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023C5")]
		public const int FiltersFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023C6")]
		private static readonly FieldCodec<AnyItemFilter> _repeated_filters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C7")]
		private readonly RepeatedField<AnyItemFilter> filters_ = (RepeatedField<AnyItemFilter>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40023C8")]
		public const int WeigthFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023C9")]
		private int weigth_;

		[Cpp2IlInjected.Token(Token = "0x40023CA")]
		public const int SubTableFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40023CB")]
		private static readonly FieldCodec<GachaTable> _repeated_subTable_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023CC")]
		private readonly RepeatedField<GachaTable> subTable_ = (RepeatedField<GachaTable>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40023CD")]
		public const int ExclusionsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40023CE")]
		private static readonly FieldCodec<AnyItemFilter> _repeated_exclusions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023CF")]
		private readonly RepeatedField<AnyItemFilter> exclusions_ = (RepeatedField<AnyItemFilter>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001426")]
		[DebuggerNonUserCode]
		public static MessageParser<GachaTable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004EF8")]
			[Cpp2IlInjected.Address(RVA = "0x218C710", Offset = "0x218B110", VA = "0x18218C710")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001427")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004EF9")]
			[Cpp2IlInjected.Address(RVA = "0x218C640", Offset = "0x218B040", VA = "0x18218C640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001428")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004EFA")]
			[Cpp2IlInjected.Address(RVA = "0x218C770", Offset = "0x218B170", VA = "0x18218C770", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001429")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyItemFilter> Filters
		{
			[Cpp2IlInjected.Token(Token = "0x6004EFE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return filters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142A")]
		[DebuggerNonUserCode]
		public int Weigth
		{
			[Cpp2IlInjected.Token(Token = "0x6004EFF")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return weigth_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F00")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				weigth_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142B")]
		[DebuggerNonUserCode]
		public RepeatedField<GachaTable> SubTable
		{
			[Cpp2IlInjected.Token(Token = "0x6004F01")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return subTable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142C")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyItemFilter> Exclusions
		{
			[Cpp2IlInjected.Token(Token = "0x6004F02")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return exclusions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFB")]
		[Cpp2IlInjected.Address(RVA = "0x218C550", Offset = "0x218AF50", VA = "0x18218C550")]
		[DebuggerNonUserCode]
		public GachaTable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFC")]
		[Cpp2IlInjected.Address(RVA = "0x218C370", Offset = "0x218AD70", VA = "0x18218C370")]
		[DebuggerNonUserCode]
		public GachaTable(GachaTable other)
		{
			RepeatedField<AnyItemFilter> repeatedField = (filters_ = (RepeatedField<AnyItemFilter>)(object)((RepeatedField<T>)(object)other.filters_).Clone());
			int num = (weigth_ = other.weigth_);
			RepeatedField<GachaTable> repeatedField2 = (subTable_ = (RepeatedField<GachaTable>)(object)((RepeatedField<T>)(object)other.subTable_).Clone());
			RepeatedField<AnyItemFilter> repeatedField3 = (exclusions_ = (RepeatedField<AnyItemFilter>)(object)((RepeatedField<T>)(object)other.exclusions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFD")]
		[Cpp2IlInjected.Address(RVA = "0x218B660", Offset = "0x218A060", VA = "0x18218B660", Slot = "10")]
		[DebuggerNonUserCode]
		public GachaTable Clone()
		{
			return new GachaTable(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F03")]
		[Cpp2IlInjected.Address(RVA = "0x218B7B0", Offset = "0x218A1B0", VA = "0x18218B7B0", Slot = "0")]
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
				RepeatedField<AnyItemFilter> repeatedField = filters_;
				bool flag = default(bool);
				if (flag && weigth_ == (flag ? 1 : 0))
				{
					RepeatedField<GachaTable> repeatedField2 = subTable_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<AnyItemFilter> repeatedField3 = exclusions_;
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

		[Cpp2IlInjected.Token(Token = "0x6004F04")]
		[Cpp2IlInjected.Address(RVA = "0x218B6C0", Offset = "0x218A0C0", VA = "0x18218B6C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GachaTable other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<AnyItemFilter> repeatedField = filters_;
				RepeatedField<AnyItemFilter> repeatedField2 = other.filters_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.weigth_;
					if (weigth_ == num)
					{
						RepeatedField<GachaTable> repeatedField3 = subTable_;
						RepeatedField<GachaTable> repeatedField4 = other.subTable_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							RepeatedField<AnyItemFilter> repeatedField5 = exclusions_;
							RepeatedField<AnyItemFilter> repeatedField6 = other.exclusions_;
							if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F05")]
		[Cpp2IlInjected.Address(RVA = "0x218B9D0", Offset = "0x218A3D0", VA = "0x18218B9D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004b
			int hashCode = ((RepeatedField<T>)(object)filters_).GetHashCode();
			if (weigth_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)subTable_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)exclusions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode = hashCode3;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F06")]
		[Cpp2IlInjected.Address(RVA = "0x218BED0", Offset = "0x218A8D0", VA = "0x18218BED0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F07")]
		[Cpp2IlInjected.Address(RVA = "0x218BF30", Offset = "0x218A930", VA = "0x18218BF30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0072
			RepeatedField<AnyItemFilter> repeatedField = filters_;
			FieldCodec<AnyItemFilter> repeated_filters_codec = _repeated_filters_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_filters_codec);
			if (weigth_ != 0)
			{
				int value = weigth_;
				output.WriteInt32(value);
			}
			RepeatedField<GachaTable> repeatedField2 = subTable_;
			FieldCodec<GachaTable> repeated_subTable_codec = _repeated_subTable_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_subTable_codec);
			RepeatedField<AnyItemFilter> repeatedField3 = exclusions_;
			FieldCodec<AnyItemFilter> repeated_exclusions_codec = _repeated_exclusions_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_exclusions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F08")]
		[Cpp2IlInjected.Address(RVA = "0x218B450", Offset = "0x2189E50", VA = "0x18218B450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0088
			RepeatedField<AnyItemFilter> repeatedField = filters_;
			FieldCodec<AnyItemFilter> repeated_filters_codec = _repeated_filters_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_filters_codec);
			int num2 = weigth_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			RepeatedField<GachaTable> repeatedField2 = subTable_;
			FieldCodec<GachaTable> repeated_subTable_codec = _repeated_subTable_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_subTable_codec);
			RepeatedField<AnyItemFilter> repeatedField3 = exclusions_;
			FieldCodec<AnyItemFilter> repeated_exclusions_codec = _repeated_exclusions_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_exclusions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F09")]
		[Cpp2IlInjected.Address(RVA = "0x218BC80", Offset = "0x218A680", VA = "0x18218BC80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GachaTable other)
		{
			//Discarded unreachable code: IL_007b
			if (other != null)
			{
				RepeatedField<AnyItemFilter> repeatedField = filters_;
				RepeatedField<AnyItemFilter> repeatedField2 = other.filters_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.weigth_;
				if (num != 0)
				{
					weigth_ = num;
				}
				RepeatedField<GachaTable> repeatedField3 = subTable_;
				RepeatedField<GachaTable> repeatedField4 = other.subTable_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<AnyItemFilter> repeatedField5 = exclusions_;
				RepeatedField<AnyItemFilter> repeatedField6 = other.exclusions_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0A")]
		[Cpp2IlInjected.Address(RVA = "0x218BAA0", Offset = "0x218A4A0", VA = "0x18218BAA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0099
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					RepeatedField<GachaTable> repeatedField = subTable_;
					FieldCodec<GachaTable> repeated_subTable_codec = _repeated_subTable_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_subTable_codec);
				}
				if (num != 34)
				{
					goto IL_0082;
				}
				RepeatedField<AnyItemFilter> repeatedField2 = exclusions_;
				FieldCodec<AnyItemFilter> repeated_exclusions_codec = _repeated_exclusions_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_exclusions_codec);
			}
			if (num == 10)
			{
				RepeatedField<AnyItemFilter> repeatedField3 = filters_;
				FieldCodec<AnyItemFilter> repeated_filters_codec = _repeated_filters_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_filters_codec);
			}
			if (num == 16)
			{
				int num2 = (weigth_ = input.ReadInt32());
			}
			goto IL_0082;
			IL_0082:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0B")]
		[Cpp2IlInjected.Address(RVA = "0x218B8E0", Offset = "0x218A2E0", VA = "0x18218B8E0", Slot = "11")]
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
							goto IL_0031;
						}
						RepeatedField<AnyItemFilter> repeatedField = exclusions_;
					}
					RepeatedField<GachaTable> repeatedField2 = subTable_;
				}
				int num2 = weigth_;
			}
			RepeatedField<AnyItemFilter> repeatedField3 = filters_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0C")]
		[Cpp2IlInjected.Address(RVA = "0x218BD50", Offset = "0x218A750", VA = "0x18218BD50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			object obj = default(object);
			while (true)
			{
				int num = fieldNumber - 1;
				if (num != 0)
				{
					if (num != 0)
					{
						if (num == 0)
						{
							continue;
						}
						if (num == 1)
						{
							break;
						}
					}
					weigth_ = (int)obj;
					return;
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0D")]
		[Cpp2IlInjected.Address(RVA = "0x218B5D0", Offset = "0x2189FD0", VA = "0x18218B5D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001d: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 0 || num == 1)
				{
					weigth_ = 0;
				}
				return;
			}
			RepeatedField<AnyItemFilter> repeatedField = filters_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0E")]
		[Cpp2IlInjected.Address(RVA = "0x218C0A0", Offset = "0x218AAA0", VA = "0x18218C0A0")]
		static GachaTable()
		{
			Func<GachaTable> func = default(Func<GachaTable>);
			_parser = (MessageParser<GachaTable>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<AnyItemFilter> parser = AnyItemFilter._parser;
			uint num = default(uint);
			_parser = (MessageParser<GachaTable>)(object)FieldCodec.ForMessage<AnyItemFilter>(num, (MessageParser<>)(object)parser);
			MessageParser<GachaTable> parser2 = _parser;
			uint num2 = default(uint);
			_parser = (MessageParser<GachaTable>)(object)FieldCodec.ForMessage<GachaTable>(num2, (MessageParser<>)(object)parser2);
			MessageParser<AnyItemFilter> parser3 = AnyItemFilter._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<GachaTable>)(object)FieldCodec.ForMessage<AnyItemFilter>(num3, (MessageParser<>)(object)parser3);
			/*Error: Unexpected end of block*/;
		}
	}
}
