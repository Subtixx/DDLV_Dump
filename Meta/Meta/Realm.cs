using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000879")]
	public sealed class Realm : IMessage<Realm>, IMessage, IEquatable<Realm>, IDeepCloneable<Realm>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002209")]
		private static readonly MessageParser<Realm> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400220A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400220B")]
		public const int GridIDsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400220C")]
		private static readonly FieldCodec<uint> _repeated_gridIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400220D")]
		private readonly RepeatedField<uint> gridIDs_ = (RepeatedField<uint>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400220E")]
		public const int UnlockedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400220F")]
		private bool unlocked_;

		[Cpp2IlInjected.Token(Token = "0x4002210")]
		public const int BodiesOfWaterFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4002211")]
		private static readonly FieldCodec<BodyOfWater> _repeated_bodiesOfWater_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002212")]
		private readonly RepeatedField<BodyOfWater> bodiesOfWater_ = (RepeatedField<BodyOfWater>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002213")]
		public const int MiningRocksFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002214")]
		private static readonly FieldCodec<MiningRock> _repeated_miningRocks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002215")]
		private readonly RepeatedField<MiningRock> miningRocks_ = (RepeatedField<MiningRock>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002216")]
		public const int CustomLocationPositionsPathFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002217")]
		private string customLocationPositionsPath_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000BD3")]
		[DebuggerNonUserCode]
		public static MessageParser<Realm> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600476D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2320", Offset = "0x5C0D20", VA = "0x1805C2320")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600476E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2250", Offset = "0x5C0C50", VA = "0x1805C2250")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600476F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2390", Offset = "0x5C0D90", VA = "0x1805C2390", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD6")]
		[DebuggerNonUserCode]
		public RepeatedField<uint> GridIDs
		{
			[Cpp2IlInjected.Token(Token = "0x6004773")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gridIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD7")]
		[DebuggerNonUserCode]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6004774")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return unlocked_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004775")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				unlocked_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD8")]
		[DebuggerNonUserCode]
		public RepeatedField<BodyOfWater> BodiesOfWater
		{
			[Cpp2IlInjected.Token(Token = "0x6004776")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return bodiesOfWater_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD9")]
		[DebuggerNonUserCode]
		public RepeatedField<MiningRock> MiningRocks
		{
			[Cpp2IlInjected.Token(Token = "0x6004777")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return miningRocks_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDA")]
		[DebuggerNonUserCode]
		public string CustomLocationPositionsPath
		{
			[Cpp2IlInjected.Token(Token = "0x6004778")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return customLocationPositionsPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004779")]
			[Cpp2IlInjected.Address(RVA = "0x5C24A0", Offset = "0x5C0EA0", VA = "0x1805C24A0")]
			set
			{
				string text = (customLocationPositionsPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004770")]
		[Cpp2IlInjected.Address(RVA = "0x5C1EF0", Offset = "0x5C08F0", VA = "0x1805C1EF0")]
		[DebuggerNonUserCode]
		public Realm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004771")]
		[Cpp2IlInjected.Address(RVA = "0x5C2010", Offset = "0x5C0A10", VA = "0x1805C2010")]
		[DebuggerNonUserCode]
		public Realm(Realm other)
		{
			RepeatedField<uint> repeatedField = (gridIDs_ = (RepeatedField<uint>)(object)((RepeatedField<T>)(object)other.gridIDs_).Clone());
			bool flag = (unlocked_ = other.unlocked_);
			RepeatedField<BodyOfWater> repeatedField2 = (bodiesOfWater_ = (RepeatedField<BodyOfWater>)(object)((RepeatedField<T>)(object)other.bodiesOfWater_).Clone());
			RepeatedField<MiningRock> repeatedField3 = (miningRocks_ = (RepeatedField<MiningRock>)(object)((RepeatedField<T>)(object)other.miningRocks_).Clone());
			string text = (customLocationPositionsPath_ = other.customLocationPositionsPath_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004772")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F60", Offset = "0x5BF960", VA = "0x1805C0F60", Slot = "10")]
		[DebuggerNonUserCode]
		public Realm Clone()
		{
			return new Realm(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600477A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0FC0", Offset = "0x5BF9C0", VA = "0x1805C0FC0", Slot = "0")]
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
				RepeatedField<uint> repeatedField = gridIDs_;
				bool flag = default(bool);
				if (flag && unlocked_ == flag)
				{
					RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<MiningRock> repeatedField3 = miningRocks_;
						bool flag3 = default(bool);
						if (flag3)
						{
							string text = customLocationPositionsPath_;
							bool flag4 = default(bool);
							if (!flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600477B")]
		[Cpp2IlInjected.Address(RVA = "0x5C1120", Offset = "0x5BFB20", VA = "0x1805C1120", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Realm other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<uint> repeatedField = gridIDs_;
				RepeatedField<uint> repeatedField2 = other.gridIDs_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					bool flag = other.unlocked_;
					if (unlocked_ == flag)
					{
						RepeatedField<BodyOfWater> repeatedField3 = bodiesOfWater_;
						RepeatedField<BodyOfWater> repeatedField4 = other.bodiesOfWater_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							RepeatedField<MiningRock> repeatedField5 = miningRocks_;
							RepeatedField<MiningRock> repeatedField6 = other.miningRocks_;
							if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
							{
								string text = other.customLocationPositionsPath_;
								if (!(customLocationPositionsPath_ != text))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600477C")]
		[Cpp2IlInjected.Address(RVA = "0x5C1340", Offset = "0x5BFD40", VA = "0x1805C1340", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0068
			int hashCode = ((RepeatedField<T>)(object)gridIDs_).GetHashCode();
			if (unlocked_)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)bodiesOfWater_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)miningRocks_).GetHashCode();
			string text = customLocationPositionsPath_;
			hashCode = hashCode3;
			if (text.m_stringLength != 0)
			{
				int hashCode4 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600477D")]
		[Cpp2IlInjected.Address(RVA = "0x5C1A30", Offset = "0x5C0430", VA = "0x1805C1A30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600477E")]
		[Cpp2IlInjected.Address(RVA = "0x5C1A90", Offset = "0x5C0490", VA = "0x1805C1A90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0090
			RepeatedField<uint> repeatedField = gridIDs_;
			FieldCodec<uint> repeated_gridIDs_codec = _repeated_gridIDs_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gridIDs_codec);
			if (unlocked_)
			{
				bool value = unlocked_;
				output.WriteBool(value);
			}
			if (customLocationPositionsPath_.m_stringLength != 0)
			{
				string value2 = customLocationPositionsPath_;
				output.WriteString(value2);
			}
			RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
			FieldCodec<BodyOfWater> repeated_bodiesOfWater_codec = _repeated_bodiesOfWater_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_bodiesOfWater_codec);
			RepeatedField<MiningRock> repeatedField3 = miningRocks_;
			FieldCodec<MiningRock> repeated_miningRocks_codec = _repeated_miningRocks_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_miningRocks_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600477F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CF0", Offset = "0x5BF6F0", VA = "0x1805C0CF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			RepeatedField<uint> repeatedField = gridIDs_;
			FieldCodec<uint> repeated_gridIDs_codec = _repeated_gridIDs_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gridIDs_codec);
			RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
			FieldCodec<BodyOfWater> repeated_bodiesOfWater_codec = _repeated_bodiesOfWater_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_bodiesOfWater_codec);
			RepeatedField<MiningRock> repeatedField3 = miningRocks_;
			FieldCodec<MiningRock> repeated_miningRocks_codec = _repeated_miningRocks_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_miningRocks_codec);
			string text = customLocationPositionsPath_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				repeatedField2 = (RepeatedField<BodyOfWater>)(repeatedField2 + num4);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<BodyOfWater>)(repeatedField2 + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004780")]
		[Cpp2IlInjected.Address(RVA = "0x5C1750", Offset = "0x5C0150", VA = "0x1805C1750", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Realm other)
		{
			//Discarded unreachable code: IL_0098
			if (other != null)
			{
				RepeatedField<uint> repeatedField = gridIDs_;
				RepeatedField<uint> repeatedField2 = other.gridIDs_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.unlocked_;
				if (flag)
				{
					unlocked_ = flag;
				}
				RepeatedField<BodyOfWater> repeatedField3 = bodiesOfWater_;
				RepeatedField<BodyOfWater> repeatedField4 = other.bodiesOfWater_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<MiningRock> repeatedField5 = miningRocks_;
				RepeatedField<MiningRock> repeatedField6 = other.miningRocks_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				string text = other.customLocationPositionsPath_;
				if (text.m_stringLength != 0)
				{
					CustomLocationPositionsPath = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004781")]
		[Cpp2IlInjected.Address(RVA = "0x5C1540", Offset = "0x5BFF40", VA = "0x1805C1540", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (CustomLocationPositionsPath = input.ReadString());
				}
				RepeatedField<BodyOfWater> repeatedField = default(RepeatedField<BodyOfWater>);
				if (num == 34)
				{
					repeatedField = bodiesOfWater_;
					FieldCodec<BodyOfWater> repeated_bodiesOfWater_codec = _repeated_bodiesOfWater_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_bodiesOfWater_codec);
				}
				if ((long)repeatedField != 42)
				{
					goto IL_0086;
				}
				RepeatedField<MiningRock> repeatedField2 = miningRocks_;
				FieldCodec<MiningRock> repeated_miningRocks_codec = _repeated_miningRocks_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_miningRocks_codec);
			}
			num += 4294967288u;
			if (num != 4294967293u)
			{
				if (num == 16)
				{
					bool flag = (unlocked_ = input.ReadBool());
				}
				goto IL_0086;
			}
			goto IL_009c;
			IL_009c:
			RepeatedField<uint> repeatedField3 = gridIDs_;
			FieldCodec<uint> repeated_gridIDs_codec = _repeated_gridIDs_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gridIDs_codec);
			return;
			IL_0086:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			goto IL_009c;
		}

		[Cpp2IlInjected.Token(Token = "0x6004782")]
		[Cpp2IlInjected.Address(RVA = "0x5C1230", Offset = "0x5BFC30", VA = "0x1805C1230", Slot = "11")]
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
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							RepeatedField<MiningRock> repeatedField = miningRocks_;
						}
						RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
					}
					string text = customLocationPositionsPath_;
				}
				bool flag = unlocked_;
			}
			RepeatedField<uint> repeatedField3 = gridIDs_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004783")]
		[Cpp2IlInjected.Address(RVA = "0x5C1850", Offset = "0x5C0250", VA = "0x1805C1850", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			object obj = default(object);
			while (true)
			{
				int num = fieldNumber - 1;
				if (num != 0)
				{
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
						int num2 = 0;
						if (value == null || value != null)
						{
							CustomLocationPositionsPath = (string)num2;
							return;
						}
						continue;
					}
					unlocked_ = (byte)(int)obj != 0;
					return;
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004784")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EA0", Offset = "0x5BF8A0", VA = "0x1805C0EA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num == 0 || num == 1)
					{
						CustomLocationPositionsPath = "";
					}
				}
				else
				{
					unlocked_ = false;
				}
				return;
			}
			RepeatedField<uint> repeatedField = gridIDs_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004785")]
		[Cpp2IlInjected.Address(RVA = "0x5C1430", Offset = "0x5BFE30", VA = "0x1805C1430")]
		internal void Initialize(in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000c
			RepeatedField<BodyOfWater> repeatedField = bodiesOfWater_;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004786")]
		[Cpp2IlInjected.Address(RVA = "0x5C1C40", Offset = "0x5C0640", VA = "0x1805C1C40")]
		static Realm()
		{
			Func<Realm> func = default(Func<Realm>);
			_parser = (MessageParser<Realm>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<Realm>)(object)FieldCodec.ForUInt32(10u);
			MessageParser<BodyOfWater> parser = BodyOfWater._parser;
			uint num = default(uint);
			_parser = (MessageParser<Realm>)(object)FieldCodec.ForMessage<BodyOfWater>(num, (MessageParser<>)(object)parser);
			MessageParser<MiningRock> parser2 = MiningRock._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<Realm>)(object)FieldCodec.ForMessage<MiningRock>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
