using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class ComplexType : IMessage<ComplexType>, IMessage, IEquatable<ComplexType>, IDeepCloneable<ComplexType>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly MessageParser<ComplexType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public const int AFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int a_;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const int SFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private string s_ = "";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int MmFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private MinMax mm_;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public const int RiFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly FieldCodec<RankInfo> _repeated_ri_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly RepeatedField<RankInfo> ri_ = (RepeatedField<RankInfo>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		[DebuggerNonUserCode]
		public static MessageParser<ComplexType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3211870", Offset = "0x3210270", VA = "0x183211870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x32117A0", Offset = "0x32101A0", VA = "0x1832117A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x32118D0", Offset = "0x32102D0", VA = "0x1832118D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[DebuggerNonUserCode]
		public int A
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return a_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				a_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[DebuggerNonUserCode]
		public string S
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return s_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x32119E0", Offset = "0x32103E0", VA = "0x1832119E0")]
			set
			{
				string text = (s_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[DebuggerNonUserCode]
		public MinMax Mm
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return mm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				mm_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[DebuggerNonUserCode]
		public RepeatedField<RankInfo> Ri
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return ri_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3211700", Offset = "0x3210100", VA = "0x183211700")]
		[DebuggerNonUserCode]
		public ComplexType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x32115A0", Offset = "0x320FFA0", VA = "0x1832115A0")]
		[DebuggerNonUserCode]
		public ComplexType(ComplexType other)
		{
			//IL_0058: Expected O, but got I4
			int num = (a_ = other.a_);
			string text = (s_ = other.s_);
			MinMax minMax = other.mm_;
			if (minMax != null)
			{
				MinMax minMax2 = minMax.Clone();
			}
			int num2 = 0;
			mm_ = (MinMax)num2;
			RepeatedField<RankInfo> repeatedField = (ri_ = (RepeatedField<RankInfo>)(object)((RepeatedField<T>)(object)other.ri_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x32108C0", Offset = "0x320F2C0", VA = "0x1832108C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ComplexType Clone()
		{
			//Discarded unreachable code: IL_0087
			//IL_005b: Expected O, but got I4
			ComplexType complexType = new ComplexType();
			complexType.s_ = "";
			RepeatedField<RankInfo> repeatedField = (complexType.ri_ = (RepeatedField<RankInfo>)(object)new RepeatedField<T>());
			int num = (complexType.a_ = a_);
			string text = (complexType.s_ = s_);
			MinMax minMax = mm_;
			if (minMax != null)
			{
				MinMax minMax2 = minMax.Clone();
			}
			int num2 = 0;
			complexType.mm_ = (MinMax)num2;
			RepeatedField<RankInfo> repeatedField2 = (complexType.ri_ = (RepeatedField<RankInfo>)(object)((RepeatedField<T>)(object)ri_).Clone());
			UnknownFieldSet unknownFieldSet = (complexType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return complexType;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3210A50", Offset = "0x320F450", VA = "0x183210A50", Slot = "0")]
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
				if ((IntPtr)a_ == (IntPtr)typeof(ComplexType).TypeHandle)
				{
					string text = s_;
					bool flag = default(bool);
					if (!flag && object.Equals(mm_, other))
					{
						RepeatedField<RankInfo> repeatedField = ri_;
						bool flag2 = default(bool);
						if (flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3210B60", Offset = "0x320F560", VA = "0x183210B60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ComplexType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.a_;
				if (a_ == num)
				{
					string text = other.s_;
					if (!(s_ != text))
					{
						MinMax objB = other.mm_;
						if (object.Equals(mm_, objB))
						{
							RepeatedField<RankInfo> repeatedField = ri_;
							RepeatedField<RankInfo> repeatedField2 = other.ri_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
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

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3210D10", Offset = "0x320F710", VA = "0x183210D10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0058
			if (a_ != 0)
			{
			}
			string text = s_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			MinMax minMax = mm_;
			if (minMax != null)
			{
				int hashCode2 = minMax.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)ri_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3211220", Offset = "0x320FC20", VA = "0x183211220", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3211280", Offset = "0x320FC80", VA = "0x183211280", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0079
			if (a_ != 0)
			{
				int value = a_;
				output.WriteInt32(value);
			}
			if (s_.m_stringLength != 0)
			{
				string value2 = s_;
				output.WriteString(value2);
			}
			if ((long)mm_ != 0)
			{
				MinMax value3 = mm_;
				output.WriteMessage(value3);
			}
			RepeatedField<RankInfo> repeatedField = ri_;
			FieldCodec<RankInfo> repeated_ri_codec = _repeated_ri_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ri_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3210690", Offset = "0x320F090", VA = "0x183210690", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0094
			int num = a_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = s_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			MinMax minMax = mm_;
			if (minMax != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(minMax);
				num5++;
				num2 += num5;
			}
			RepeatedField<RankInfo> repeatedField = ri_;
			FieldCodec<RankInfo> repeated_ri_codec = _repeated_ri_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ri_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num6;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3210DD0", Offset = "0x320F7D0", VA = "0x183210DD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ComplexType other)
		{
			//Discarded unreachable code: IL_00a1
			if (other == null)
			{
				return;
			}
			int num = other.a_;
			if (num != 0)
			{
				a_ = num;
			}
			string text = other.s_;
			if (text.m_stringLength != 0)
			{
				S = text;
			}
			if ((long)other.mm_ != 0)
			{
				MinMax minMax2 = default(MinMax);
				if (mm_ == null)
				{
					MinMax minMax = (mm_ = new MinMax());
					minMax2 = mm_;
				}
				MinMax other2 = other.mm_;
				minMax2.MergeFrom(other2);
			}
			RepeatedField<RankInfo> repeatedField = ri_;
			RepeatedField<RankInfo> repeatedField2 = other.ri_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3210EF0", Offset = "0x320F8F0", VA = "0x183210EF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0099
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					MinMax minMax = mm_;
					if (minMax == null)
					{
						MinMax minMax2 = (mm_ = new MinMax());
					}
					input.ReadMessage(minMax);
				}
				if (num != 34)
				{
					goto IL_0082;
				}
				RepeatedField<RankInfo> repeatedField = ri_;
				FieldCodec<RankInfo> repeated_ri_codec = _repeated_ri_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ri_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (a_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text2 = (S = input.ReadString());
			}
			goto IL_0082;
			IL_0082:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3210C20", Offset = "0x320F620", VA = "0x183210C20", Slot = "11")]
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
						RepeatedField<RankInfo> repeatedField = ri_;
					}
					MinMax minMax = mm_;
				}
				string text = s_;
			}
			int num2 = a_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3211090", Offset = "0x320FA90", VA = "0x183211090", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0037
			//IL_0025: Expected O, but got I4
			//IL_0036: Expected I4, but got O
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
							mm_ = (MinMax)num2;
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
			else
			{
				object obj = default(object);
				a_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3210800", Offset = "0x320F200", VA = "0x183210800", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0031
			//IL_0030: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						RepeatedField<RankInfo> repeatedField = ri_;
						break;
					}
					case 0:
						break;
					default:
						return;
					}
				}
				S = "";
			}
			else
			{
				a_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x32113D0", Offset = "0x320FDD0", VA = "0x1832113D0")]
		static ComplexType()
		{
			Func<ComplexType> func = default(Func<ComplexType>);
			_parser = (MessageParser<ComplexType>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<RankInfo> parser = RankInfo._parser;
			uint num = default(uint);
			_parser = (MessageParser<ComplexType>)(object)FieldCodec.ForMessage<RankInfo>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
