using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class MonsterInfos : IMessage<MonsterInfos>, IMessage, IEquatable<MonsterInfos>, IDeepCloneable<MonsterInfos>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly MessageParser<MonsterInfos> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const int MinLevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int minLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const int Rank1BaseMaxLevelFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int rank1BaseMaxLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int RankLevelIncrementFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int rankLevelIncrement_;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const int MaxRankFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Ranks maxRank_;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const int RankInfosFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly FieldCodec<RankInfo> _repeated_rankInfos_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly RepeatedField<RankInfo> rankInfos_ = (RepeatedField<RankInfo>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const int FusionRecipesFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly FieldCodec<Recipe> _repeated_fusionRecipes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly RepeatedField<Recipe> fusionRecipes_ = (RepeatedField<Recipe>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const int ComplexFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ComplexType complex_;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[DebuggerNonUserCode]
		public static MessageParser<MonsterInfos> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x29F2210", Offset = "0x29F0C10", VA = "0x1829F2210")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x29F2140", Offset = "0x29F0B40", VA = "0x1829F2140")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x29F2270", Offset = "0x29F0C70", VA = "0x1829F2270", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[DebuggerNonUserCode]
		public int MinLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[DebuggerNonUserCode]
		public int Rank1BaseMaxLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return rank1BaseMaxLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				rank1BaseMaxLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[DebuggerNonUserCode]
		public int RankLevelIncrement
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return rankLevelIncrement_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				rankLevelIncrement_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[DebuggerNonUserCode]
		public Ranks MaxRank
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return maxRank_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				maxRank_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		[DebuggerNonUserCode]
		public RepeatedField<RankInfo> RankInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return rankInfos_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[DebuggerNonUserCode]
		public RepeatedField<Recipe> FusionRecipes
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return fusionRecipes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[DebuggerNonUserCode]
		public ComplexType Complex
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return complex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				complex_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x29F1EC0", Offset = "0x29F08C0", VA = "0x1829F1EC0")]
		[DebuggerNonUserCode]
		public MonsterInfos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x29F1F80", Offset = "0x29F0980", VA = "0x1829F1F80")]
		[DebuggerNonUserCode]
		public MonsterInfos(MonsterInfos other)
		{
			//IL_00a7: Expected O, but got I4
			int num = (minLevel_ = other.minLevel_);
			int num2 = (rank1BaseMaxLevel_ = other.rank1BaseMaxLevel_);
			int num3 = (rankLevelIncrement_ = other.rankLevelIncrement_);
			Ranks ranks = (maxRank_ = other.maxRank_);
			RepeatedField<RankInfo> repeatedField = (rankInfos_ = (RepeatedField<RankInfo>)(object)((RepeatedField<T>)(object)other.rankInfos_).Clone());
			RepeatedField<Recipe> repeatedField2 = (fusionRecipes_ = (RepeatedField<Recipe>)(object)((RepeatedField<T>)(object)other.fusionRecipes_).Clone());
			ComplexType complexType = other.complex_;
			if (complexType != null)
			{
				ComplexType complexType2 = complexType.Clone();
			}
			int num4 = 0;
			complex_ = (ComplexType)num4;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x29F0F10", Offset = "0x29EF910", VA = "0x1829F0F10", Slot = "10")]
		[DebuggerNonUserCode]
		public MonsterInfos Clone()
		{
			return new MonsterInfos(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x29F1070", Offset = "0x29EFA70", VA = "0x1829F1070", Slot = "0")]
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
				if ((IntPtr)minLevel_ == (IntPtr)typeof(MonsterInfos).TypeHandle && (IntPtr)rank1BaseMaxLevel_ == (IntPtr)typeof(MonsterInfos).TypeHandle && (IntPtr)rankLevelIncrement_ == (IntPtr)typeof(MonsterInfos).TypeHandle && (IntPtr)(void*)(int)maxRank_ == (IntPtr)typeof(MonsterInfos).TypeHandle)
				{
					RepeatedField<RankInfo> repeatedField = rankInfos_;
					bool flag = default(bool);
					if (flag)
					{
						RepeatedField<Recipe> repeatedField2 = fusionRecipes_;
						bool flag2 = default(bool);
						if (flag2 && object.Equals(complex_, other))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x29F0F70", Offset = "0x29EF970", VA = "0x1829F0F70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MonsterInfos other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minLevel_;
				if (minLevel_ == num)
				{
					int num2 = other.rank1BaseMaxLevel_;
					if (rank1BaseMaxLevel_ == num2)
					{
						int num3 = other.rankLevelIncrement_;
						if (rankLevelIncrement_ == num3)
						{
							Ranks ranks = other.maxRank_;
							if (maxRank_ == ranks)
							{
								RepeatedField<RankInfo> repeatedField = rankInfos_;
								RepeatedField<RankInfo> repeatedField2 = other.rankInfos_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									RepeatedField<Recipe> repeatedField3 = fusionRecipes_;
									RepeatedField<Recipe> repeatedField4 = other.fusionRecipes_;
									if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
									{
										ComplexType objB = other.complex_;
										if (object.Equals(complex_, objB))
										{
											UnknownFieldSet unknownFields = other._unknownFields;
											return object.Equals(_unknownFields, unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x29F1300", Offset = "0x29EFD00", VA = "0x1829F1300", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006d
			int num = 0;
			if (minLevel_ != 0)
			{
			}
			if (rank1BaseMaxLevel_ != 0)
			{
			}
			if (rankLevelIncrement_ != 0)
			{
			}
			if (maxRank_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)rankInfos_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)fusionRecipes_).GetHashCode();
			ComplexType complexType = complex_;
			if (complexType != null)
			{
				int hashCode3 = complexType.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x29F1A00", Offset = "0x29F0400", VA = "0x1829F1A00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x29F1A60", Offset = "0x29F0460", VA = "0x1829F1A60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00af
			if (minLevel_ != 0)
			{
				int value = minLevel_;
				output.WriteInt32(value);
			}
			if (rank1BaseMaxLevel_ != 0)
			{
				int value2 = rank1BaseMaxLevel_;
				output.WriteInt32(value2);
			}
			if (rankLevelIncrement_ != 0)
			{
				int value3 = rankLevelIncrement_;
				output.WriteInt32(value3);
			}
			if (maxRank_ != 0)
			{
			}
			RepeatedField<RankInfo> repeatedField = rankInfos_;
			FieldCodec<RankInfo> repeated_rankInfos_codec = _repeated_rankInfos_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rankInfos_codec);
			RepeatedField<Recipe> repeatedField2 = fusionRecipes_;
			FieldCodec<Recipe> repeated_fusionRecipes_codec = _repeated_fusionRecipes_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_fusionRecipes_codec);
			if ((long)complex_ != 0)
			{
				ComplexType value4 = complex_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x29F0C10", Offset = "0x29EF610", VA = "0x1829F0C10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e6
			int num = minLevel_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = rank1BaseMaxLevel_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			int num6 = rankLevelIncrement_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			Ranks ranks = maxRank_;
			if (ranks != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)ranks);
				num8++;
				num2 += num8;
			}
			RepeatedField<RankInfo> repeatedField = rankInfos_;
			FieldCodec<RankInfo> repeated_rankInfos_codec = _repeated_rankInfos_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rankInfos_codec);
			RepeatedField<Recipe> repeatedField2 = fusionRecipes_;
			FieldCodec<Recipe> repeated_fusionRecipes_codec = _repeated_fusionRecipes_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_fusionRecipes_codec);
			ComplexType complexType = complex_;
			if (complexType != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(complexType);
				num11++;
				num2 += num11;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				num2 += num12;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x29F1410", Offset = "0x29EFE10", VA = "0x1829F1410", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MonsterInfos other)
		{
			//Discarded unreachable code: IL_00dd
			if (other == null)
			{
				return;
			}
			int num = other.minLevel_;
			if (num != 0)
			{
				minLevel_ = num;
			}
			int num2 = other.rank1BaseMaxLevel_;
			if (num2 != 0)
			{
				rank1BaseMaxLevel_ = num2;
			}
			int num3 = other.rankLevelIncrement_;
			if (num3 != 0)
			{
				rankLevelIncrement_ = num3;
			}
			Ranks ranks = other.maxRank_;
			if (ranks != 0)
			{
				maxRank_ = ranks;
			}
			RepeatedField<RankInfo> repeatedField = rankInfos_;
			RepeatedField<RankInfo> repeatedField2 = other.rankInfos_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<Recipe> repeatedField3 = fusionRecipes_;
			RepeatedField<Recipe> repeatedField4 = other.fusionRecipes_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			if ((long)other.complex_ != 0)
			{
				ComplexType complexType2 = default(ComplexType);
				if (complex_ == null)
				{
					ComplexType complexType = (complex_ = new ComplexType());
					complexType2 = complex_;
				}
				ComplexType other2 = other.complex_;
				complexType2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x29F1560", Offset = "0x29EFF60", VA = "0x1829F1560", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00f5
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if ((int)num > 42)
				{
					if (num == 50)
					{
						RepeatedField<Recipe> repeatedField = fusionRecipes_;
						FieldCodec<Recipe> repeated_fusionRecipes_codec = _repeated_fusionRecipes_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_fusionRecipes_codec);
					}
					if (num != 58)
					{
						goto IL_00de;
					}
					ComplexType builder = default(ComplexType);
					if (complex_ == null)
					{
						ComplexType complexType = (complex_ = new ComplexType());
						builder = complex_;
					}
					input.ReadMessage(builder);
				}
				int num2 = default(int);
				if (num == 32)
				{
					num2 = (int)(maxRank_ = (Ranks)input.ReadInt32());
				}
				if (num2 != 42)
				{
					goto IL_00de;
				}
				RepeatedField<RankInfo> repeatedField2 = rankInfos_;
				FieldCodec<RankInfo> repeated_rankInfos_codec = _repeated_rankInfos_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rankInfos_codec);
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (minLevel_ = input.ReadInt32());
			}
			int num4 = default(int);
			if (num3 == 16)
			{
				num4 = (rank1BaseMaxLevel_ = input.ReadInt32());
			}
			if (num4 == 24)
			{
				int num5 = (rankLevelIncrement_ = input.ReadInt32());
			}
			goto IL_00de;
			IL_00de:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x29F11C0", Offset = "0x29EFBC0", VA = "0x1829F11C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				int num = minLevel_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x29F1790", Offset = "0x29F0190", VA = "0x1829F1790", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011
			//IL_000d: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				object obj = default(object);
				minLevel_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x29F0E10", Offset = "0x29EF810", VA = "0x1829F0E10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0014
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 6)
			{
				minLevel_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x29F1C30", Offset = "0x29F0630", VA = "0x1829F1C30")]
		static MonsterInfos()
		{
			Func<MonsterInfos> func = default(Func<MonsterInfos>);
			_parser = (MessageParser<MonsterInfos>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<RankInfo> parser = RankInfo._parser;
			uint num = default(uint);
			_parser = (MessageParser<MonsterInfos>)(object)FieldCodec.ForMessage<RankInfo>(num, (MessageParser<>)(object)parser);
			MessageParser<Recipe> parser2 = Recipe._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<MonsterInfos>)(object)FieldCodec.ForMessage<Recipe>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
