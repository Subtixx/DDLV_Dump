using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class Recipe : IMessage<Recipe>, IMessage, IEquatable<Recipe>, IDeepCloneable<Recipe>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly MessageParser<Recipe> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const int MaterialsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly FieldCodec<int> _repeated_materials_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly RepeatedField<int> materials_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const int MinRankFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Ranks minRank_;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public const int ResultFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int result_;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int CostFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly FieldCodec<CurrencyAmount> _repeated_cost_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly RepeatedField<CurrencyAmount> cost_ = (RepeatedField<CurrencyAmount>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		[DebuggerNonUserCode]
		public static MessageParser<Recipe> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2DA8040", Offset = "0x2DA6A40", VA = "0x182DA8040")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7F70", Offset = "0x2DA6970", VA = "0x182DA7F70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2DA80A0", Offset = "0x2DA6AA0", VA = "0x182DA80A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return materials_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		[DebuggerNonUserCode]
		public Ranks MinRank
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return minRank_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				minRank_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[DebuggerNonUserCode]
		public int Result
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return result_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				result_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyAmount> Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return cost_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7D20", Offset = "0x2DA6720", VA = "0x182DA7D20")]
		[DebuggerNonUserCode]
		public Recipe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7DE0", Offset = "0x2DA67E0", VA = "0x182DA7DE0")]
		[DebuggerNonUserCode]
		public Recipe(Recipe other)
		{
			RepeatedField<int> repeatedField = (materials_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.materials_).Clone());
			Ranks ranks = (minRank_ = other.minRank_);
			int num = (result_ = other.result_);
			RepeatedField<CurrencyAmount> repeatedField2 = (cost_ = (RepeatedField<CurrencyAmount>)(object)((RepeatedField<T>)(object)other.cost_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7010", Offset = "0x2DA5A10", VA = "0x182DA7010", Slot = "10")]
		[DebuggerNonUserCode]
		public Recipe Clone()
		{
			//Discarded unreachable code: IL_007f
			Recipe recipe = new Recipe();
			RepeatedField<int> repeatedField = (recipe.materials_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<CurrencyAmount> repeatedField2 = (recipe.cost_ = (RepeatedField<CurrencyAmount>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField3 = (recipe.materials_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)materials_).Clone());
			Ranks ranks = (recipe.minRank_ = minRank_);
			int num = (recipe.result_ = result_);
			RepeatedField<CurrencyAmount> repeatedField4 = (recipe.cost_ = (RepeatedField<CurrencyAmount>)(object)((RepeatedField<T>)(object)cost_).Clone());
			UnknownFieldSet unknownFieldSet = (recipe._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return recipe;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DA71D0", Offset = "0x2DA5BD0", VA = "0x182DA71D0", Slot = "0")]
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
				RepeatedField<int> repeatedField = materials_;
				bool flag = default(bool);
				if (flag && minRank_ == (flag ? Ranks.Rank1 : Ranks.NoRank) && result_ == (flag ? 1 : 0))
				{
					RepeatedField<CurrencyAmount> repeatedField2 = cost_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA72F0", Offset = "0x2DA5CF0", VA = "0x182DA72F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Recipe other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = materials_;
				RepeatedField<int> repeatedField2 = other.materials_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					Ranks ranks = other.minRank_;
					if (minRank_ == ranks)
					{
						int num = other.result_;
						if (result_ == num)
						{
							RepeatedField<CurrencyAmount> repeatedField3 = cost_;
							RepeatedField<CurrencyAmount> repeatedField4 = other.cost_;
							if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
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

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA74D0", Offset = "0x2DA5ED0", VA = "0x182DA74D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0045
			int num = 0;
			int hashCode = ((RepeatedField<T>)(object)materials_).GetHashCode();
			if (minRank_ != 0)
			{
			}
			if (result_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)cost_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7960", Offset = "0x2DA6360", VA = "0x182DA7960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA79C0", Offset = "0x2DA63C0", VA = "0x182DA79C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0062
			RepeatedField<int> repeatedField = materials_;
			FieldCodec<int> repeated_materials_codec = _repeated_materials_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_materials_codec);
			if (minRank_ != 0)
			{
			}
			if (result_ != 0)
			{
				int value = result_;
				output.WriteInt32(value);
			}
			RepeatedField<CurrencyAmount> repeatedField2 = cost_;
			FieldCodec<CurrencyAmount> repeated_cost_codec = _repeated_cost_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_cost_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6DF0", Offset = "0x2DA57F0", VA = "0x182DA6DF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0094
			RepeatedField<int> repeatedField = materials_;
			FieldCodec<int> repeated_materials_codec = _repeated_materials_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_materials_codec);
			Ranks ranks = minRank_;
			if (ranks != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)ranks);
				num2++;
				num += num2;
			}
			int num3 = result_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			RepeatedField<CurrencyAmount> repeatedField2 = cost_;
			FieldCodec<CurrencyAmount> repeated_cost_codec = _repeated_cost_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_cost_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num5;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7590", Offset = "0x2DA5F90", VA = "0x182DA7590", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Recipe other)
		{
			//Discarded unreachable code: IL_0076
			if (other != null)
			{
				RepeatedField<int> repeatedField = materials_;
				RepeatedField<int> repeatedField2 = other.materials_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				Ranks ranks = other.minRank_;
				if (ranks != 0)
				{
					minRank_ = ranks;
				}
				int num = other.result_;
				if (num != 0)
				{
					result_ = num;
				}
				RepeatedField<CurrencyAmount> repeatedField3 = cost_;
				RepeatedField<CurrencyAmount> repeatedField4 = other.cost_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7650", Offset = "0x2DA6050", VA = "0x182DA7650", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0095
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 10)
			{
				if (num == 16)
				{
					int num2 = (int)(minRank_ = (Ranks)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 24)
				{
					num3 = (result_ = input.ReadInt32());
				}
				if (num3 != 34)
				{
					goto IL_0065;
				}
				RepeatedField<CurrencyAmount> repeatedField = cost_;
				FieldCodec<CurrencyAmount> repeated_cost_codec = _repeated_cost_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_cost_codec);
			}
			num += 4294967288u;
			if (num != 4294967293u)
			{
				goto IL_0065;
			}
			goto IL_007b;
			IL_007b:
			RepeatedField<int> repeatedField2 = materials_;
			FieldCodec<int> repeated_materials_codec = _repeated_materials_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_materials_codec);
			return;
			IL_0065:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			goto IL_007b;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2DA73C0", Offset = "0x2DA5DC0", VA = "0x182DA73C0", Slot = "11")]
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
						RepeatedField<CurrencyAmount> repeatedField = cost_;
					}
					int num2 = result_;
				}
				Ranks ranks = minRank_;
			}
			RepeatedField<int> repeatedField2 = materials_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA77E0", Offset = "0x2DA61E0", VA = "0x182DA77E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0)
				{
					object obj = default(object);
					minRank_ = (Ranks)obj;
					return;
				}
				if (num == 0 || num != 1)
				{
					object obj2 = default(object);
					result_ = (int)obj2;
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6F70", Offset = "0x2DA5970", VA = "0x182DA6F70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001d: Expected I4, but got I8
			//IL_0027: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num == 1)
					{
						result_ = 0;
					}
				}
				else
				{
					minRank_ = Ranks.NoRank;
				}
				return;
			}
			RepeatedField<int> repeatedField = materials_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7B30", Offset = "0x2DA6530", VA = "0x182DA7B30")]
		static Recipe()
		{
			Func<Recipe> func = default(Func<Recipe>);
			_parser = (MessageParser<Recipe>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<Recipe>)(object)FieldCodec.ForInt32(10u);
			MessageParser<CurrencyAmount> parser = CurrencyAmount._parser;
			uint num = default(uint);
			_parser = (MessageParser<Recipe>)(object)FieldCodec.ForMessage<CurrencyAmount>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
