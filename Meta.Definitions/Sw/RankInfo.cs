using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class RankInfo : IMessage<RankInfo>, IMessage, IEquatable<RankInfo>, IDeepCloneable<RankInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly MessageParser<RankInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Ranks id_;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const int SumFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MinMax sum_;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const int SumAwkFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private MinMax sumAwk_;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const int XpTableFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly FieldCodec<int> _repeated_xpTable_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly RepeatedField<int> xpTable_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[DebuggerNonUserCode]
		public static MessageParser<RankInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2DA2160", Offset = "0x2DA0B60", VA = "0x182DA2160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2DA2090", Offset = "0x2DA0A90", VA = "0x182DA2090")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2DA21C0", Offset = "0x2DA0BC0", VA = "0x182DA21C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[DebuggerNonUserCode]
		public Ranks Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[DebuggerNonUserCode]
		public MinMax Sum
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return sum_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				sum_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		[DebuggerNonUserCode]
		public MinMax SumAwk
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return sumAwk_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				sumAwk_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		[DebuggerNonUserCode]
		public RepeatedField<int> XpTable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return xpTable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1EC0", Offset = "0x2DA08C0", VA = "0x182DA1EC0")]
		[DebuggerNonUserCode]
		public RankInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1F40", Offset = "0x2DA0940", VA = "0x182DA1F40")]
		[DebuggerNonUserCode]
		public RankInfo(RankInfo other)
		{
			//IL_003d: Expected O, but got I4
			Ranks ranks = other.id_;
			int num = 0;
			id_ = ranks;
			MinMax minMax = other.sum_;
			if (minMax != null)
			{
				MinMax minMax2 = minMax.Clone();
			}
			sum_ = (MinMax)num;
			MinMax minMax3 = other.sumAwk_;
			MinMax minMax4 = default(MinMax);
			if (minMax3 != null)
			{
				minMax4 = minMax3.Clone();
			}
			sumAwk_ = minMax4;
			RepeatedField<int> repeatedField = (xpTable_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.xpTable_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1260", Offset = "0x2D9FC60", VA = "0x182DA1260", Slot = "10")]
		[DebuggerNonUserCode]
		public RankInfo Clone()
		{
			//Discarded unreachable code: IL_008a
			//IL_0040: Expected O, but got I4
			RankInfo rankInfo = new RankInfo();
			RepeatedField<int> repeatedField = (rankInfo.xpTable_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			Ranks ranks = id_;
			int num = 0;
			rankInfo.id_ = ranks;
			MinMax minMax = sum_;
			if (minMax != null)
			{
				MinMax minMax2 = minMax.Clone();
			}
			rankInfo.sum_ = (MinMax)num;
			MinMax minMax3 = sumAwk_;
			MinMax minMax4 = default(MinMax);
			if (minMax3 != null)
			{
				minMax4 = minMax3.Clone();
			}
			rankInfo.sumAwk_ = minMax4;
			RepeatedField<int> repeatedField2 = (rankInfo.xpTable_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)xpTable_).Clone());
			UnknownFieldSet unknownFieldSet = (rankInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return rankInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2DA13E0", Offset = "0x2D9FDE0", VA = "0x182DA13E0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
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
				if ((IntPtr)(void*)(int)id_ == (IntPtr)typeof(RankInfo).TypeHandle && object.Equals(sum_, other) && object.Equals(sumAwk_, other))
				{
					RepeatedField<int> repeatedField = xpTable_;
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

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2DA14F0", Offset = "0x2D9FEF0", VA = "0x182DA14F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RankInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Ranks ranks = other.id_;
				if (id_ == ranks)
				{
					MinMax objB = other.sum_;
					if (object.Equals(sum_, objB))
					{
						MinMax objB2 = other.sumAwk_;
						if (object.Equals(sumAwk_, objB2))
						{
							RepeatedField<int> repeatedField = xpTable_;
							RepeatedField<int> repeatedField2 = other.xpTable_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
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

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2DA16A0", Offset = "0x2DA00A0", VA = "0x182DA16A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0053
			if (id_ != 0)
			{
			}
			MinMax minMax = sum_;
			if (minMax != null)
			{
				int hashCode = minMax.GetHashCode();
			}
			MinMax minMax2 = sumAwk_;
			if (minMax2 != null)
			{
				int hashCode2 = minMax2.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)xpTable_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1BE0", Offset = "0x2DA05E0", VA = "0x182DA1BE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1C40", Offset = "0x2DA0640", VA = "0x182DA1C40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0066
			if (id_ != 0)
			{
			}
			if ((long)sum_ != 0)
			{
				MinMax value = sum_;
				output.WriteMessage(value);
			}
			if ((long)sumAwk_ != 0)
			{
				MinMax value2 = sumAwk_;
				output.WriteMessage(value2);
			}
			RepeatedField<int> repeatedField = xpTable_;
			FieldCodec<int> repeated_xpTable_codec = _repeated_xpTable_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_xpTable_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1040", Offset = "0x2D9FA40", VA = "0x182DA1040", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_008f
			Ranks ranks = id_;
			int num = 0;
			if (ranks != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)ranks);
			}
			MinMax minMax = sum_;
			if (minMax != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(minMax);
				num3++;
				num += num3;
			}
			MinMax minMax2 = sumAwk_;
			if (minMax2 != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(minMax2);
				num4++;
				num += num4;
			}
			RepeatedField<int> repeatedField = xpTable_;
			FieldCodec<int> repeated_xpTable_codec = _repeated_xpTable_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_xpTable_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num5;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1760", Offset = "0x2DA0160", VA = "0x182DA1760", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RankInfo other)
		{
			//Discarded unreachable code: IL_00c4
			if (other == null)
			{
				return;
			}
			Ranks ranks = other.id_;
			if (ranks != 0)
			{
				id_ = ranks;
			}
			if ((long)other.sum_ != 0)
			{
				MinMax minMax2 = default(MinMax);
				if (sum_ == null)
				{
					MinMax minMax = (sum_ = new MinMax());
					minMax2 = sum_;
				}
				MinMax other2 = other.sum_;
				minMax2.MergeFrom(other2);
			}
			if ((long)other.sumAwk_ != 0)
			{
				MinMax minMax4 = default(MinMax);
				if (sumAwk_ == null)
				{
					MinMax minMax3 = (sumAwk_ = new MinMax());
					minMax4 = sumAwk_;
				}
				MinMax other3 = other.sumAwk_;
				minMax4.MergeFrom(other3);
			}
			RepeatedField<int> repeatedField = xpTable_;
			RepeatedField<int> repeatedField2 = other.xpTable_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2DA18B0", Offset = "0x2DA02B0", VA = "0x182DA18B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					MinMax minMax = sumAwk_;
					if (minMax == null)
					{
						MinMax minMax2 = (sumAwk_ = new MinMax());
					}
					input.ReadMessage(minMax);
				}
				num += 4294967264u;
				if (num != 4294967293u)
				{
					goto IL_00a0;
				}
				RepeatedField<int> repeatedField = xpTable_;
				FieldCodec<int> repeated_xpTable_codec = _repeated_xpTable_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_xpTable_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(id_ = (Ranks)input.ReadInt32());
			}
			if (num2 == 18)
			{
				MinMax builder = default(MinMax);
				if (sum_ == null)
				{
					MinMax minMax3 = (sum_ = new MinMax());
					builder = sum_;
				}
				input.ReadMessage(builder);
			}
			goto IL_00a0;
			IL_00a0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2DA15B0", Offset = "0x2D9FFB0", VA = "0x182DA15B0", Slot = "11")]
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
						RepeatedField<int> repeatedField = xpTable_;
					}
					MinMax minMax = sumAwk_;
				}
				MinMax minMax2 = sum_;
			}
			Ranks ranks = id_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1A80", Offset = "0x2DA0480", VA = "0x182DA1A80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0036
			//IL_0025: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num != 1)
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							sumAwk_ = (MinMax)num2;
							return;
						}
					}
					else
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					}
					throw new InvalidCastException();
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj = default(object);
			id_ = (Ranks)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DA11A0", Offset = "0x2D9FBA0", VA = "0x182DA11A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0025
			//IL_0024: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<int> repeatedField = xpTable_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
			}
			id_ = Ranks.NoRank;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1D80", Offset = "0x2DA0780", VA = "0x182DA1D80")]
		static RankInfo()
		{
			Func<RankInfo> func = default(Func<RankInfo>);
			_parser = (MessageParser<RankInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<RankInfo>)(object)FieldCodec.ForInt32(34u);
			/*Error: Unexpected end of block*/;
		}
	}
}
