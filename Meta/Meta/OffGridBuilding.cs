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
	[Cpp2IlInjected.Token(Token = "0x200091B")]
	public sealed class OffGridBuilding : IMessage<OffGridBuilding>, IMessage, IEquatable<OffGridBuilding>, IDeepCloneable<OffGridBuilding>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024E5")]
		private static readonly MessageParser<OffGridBuilding> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024E6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024E7")]
		public const int GridIDsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40024E8")]
		private static readonly FieldCodec<uint> _repeated_gridIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024E9")]
		private readonly RepeatedField<uint> gridIDs_ = (RepeatedField<uint>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40024EA")]
		public const int CustomLocationPositionsPathFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024EB")]
		private string customLocationPositionsPath_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024EC")]
		public const int BodiesOfWaterFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40024ED")]
		private static readonly FieldCodec<BodyOfWater> _repeated_bodiesOfWater_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024EE")]
		private readonly RepeatedField<BodyOfWater> bodiesOfWater_ = (RepeatedField<BodyOfWater>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40024EF")]
		public const int MiningRocksFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40024F0")]
		private static readonly FieldCodec<MiningRock> _repeated_miningRocks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024F1")]
		private readonly RepeatedField<MiningRock> miningRocks_ = (RepeatedField<MiningRock>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000D7A")]
		[DebuggerNonUserCode]
		public static MessageParser<OffGridBuilding> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F20")]
			[Cpp2IlInjected.Address(RVA = "0x13A1870", Offset = "0x13A0270", VA = "0x1813A1870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F21")]
			[Cpp2IlInjected.Address(RVA = "0x13A17A0", Offset = "0x13A01A0", VA = "0x1813A17A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F22")]
			[Cpp2IlInjected.Address(RVA = "0x13A18D0", Offset = "0x13A02D0", VA = "0x1813A18D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7D")]
		[DebuggerNonUserCode]
		public RepeatedField<uint> GridIDs
		{
			[Cpp2IlInjected.Token(Token = "0x6004F26")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gridIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7E")]
		[DebuggerNonUserCode]
		public string CustomLocationPositionsPath
		{
			[Cpp2IlInjected.Token(Token = "0x6004F27")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return customLocationPositionsPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F28")]
			[Cpp2IlInjected.Address(RVA = "0x13A19E0", Offset = "0x13A03E0", VA = "0x1813A19E0")]
			set
			{
				string text = (customLocationPositionsPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7F")]
		[DebuggerNonUserCode]
		public RepeatedField<BodyOfWater> BodiesOfWater
		{
			[Cpp2IlInjected.Token(Token = "0x6004F29")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return bodiesOfWater_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D80")]
		[DebuggerNonUserCode]
		public RepeatedField<MiningRock> MiningRocks
		{
			[Cpp2IlInjected.Token(Token = "0x6004F2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return miningRocks_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F23")]
		[Cpp2IlInjected.Address(RVA = "0x13A1680", Offset = "0x13A0080", VA = "0x1813A1680")]
		[DebuggerNonUserCode]
		public OffGridBuilding()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F24")]
		[Cpp2IlInjected.Address(RVA = "0x13A1450", Offset = "0x139FE50", VA = "0x1813A1450")]
		[DebuggerNonUserCode]
		public OffGridBuilding(OffGridBuilding other)
		{
			RepeatedField<uint> repeatedField = (gridIDs_ = (RepeatedField<uint>)(object)((RepeatedField<T>)(object)other.gridIDs_).Clone());
			string text = (customLocationPositionsPath_ = other.customLocationPositionsPath_);
			RepeatedField<BodyOfWater> repeatedField2 = (bodiesOfWater_ = (RepeatedField<BodyOfWater>)(object)((RepeatedField<T>)(object)other.bodiesOfWater_).Clone());
			RepeatedField<MiningRock> repeatedField3 = (miningRocks_ = (RepeatedField<MiningRock>)(object)((RepeatedField<T>)(object)other.miningRocks_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F25")]
		[Cpp2IlInjected.Address(RVA = "0x13A0450", Offset = "0x139EE50", VA = "0x1813A0450", Slot = "10")]
		[DebuggerNonUserCode]
		public OffGridBuilding Clone()
		{
			return new OffGridBuilding(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2B")]
		[Cpp2IlInjected.Address(RVA = "0x13A04B0", Offset = "0x139EEB0", VA = "0x1813A04B0", Slot = "0")]
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
				if (flag)
				{
					string text = customLocationPositionsPath_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
						bool flag3 = default(bool);
						if (flag3)
						{
							RepeatedField<MiningRock> repeatedField3 = miningRocks_;
							bool flag4 = default(bool);
							if (flag4)
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

		[Cpp2IlInjected.Token(Token = "0x6004F2C")]
		[Cpp2IlInjected.Address(RVA = "0x13A0600", Offset = "0x139F000", VA = "0x1813A0600", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OffGridBuilding other)
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
					string text = other.customLocationPositionsPath_;
					if (!(customLocationPositionsPath_ != text))
					{
						RepeatedField<BodyOfWater> repeatedField3 = bodiesOfWater_;
						RepeatedField<BodyOfWater> repeatedField4 = other.bodiesOfWater_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							RepeatedField<MiningRock> repeatedField5 = miningRocks_;
							RepeatedField<MiningRock> repeatedField6 = other.miningRocks_;
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

		[Cpp2IlInjected.Token(Token = "0x6004F2D")]
		[Cpp2IlInjected.Address(RVA = "0x13A07B0", Offset = "0x139F1B0", VA = "0x1813A07B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005b
			int hashCode = ((RepeatedField<T>)(object)gridIDs_).GetHashCode();
			string text = customLocationPositionsPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)bodiesOfWater_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)miningRocks_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode = hashCode4;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2E")]
		[Cpp2IlInjected.Address(RVA = "0x13A0FB0", Offset = "0x139F9B0", VA = "0x1813A0FB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2F")]
		[Cpp2IlInjected.Address(RVA = "0x13A1010", Offset = "0x139FA10", VA = "0x1813A1010", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0077
			RepeatedField<uint> repeatedField = gridIDs_;
			FieldCodec<uint> repeated_gridIDs_codec = _repeated_gridIDs_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gridIDs_codec);
			if (customLocationPositionsPath_.m_stringLength != 0)
			{
				string value = customLocationPositionsPath_;
				output.WriteString(value);
			}
			RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
			FieldCodec<BodyOfWater> repeated_bodiesOfWater_codec = _repeated_bodiesOfWater_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_bodiesOfWater_codec);
			RepeatedField<MiningRock> repeatedField3 = miningRocks_;
			FieldCodec<MiningRock> repeated_miningRocks_codec = _repeated_miningRocks_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_miningRocks_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F30")]
		[Cpp2IlInjected.Address(RVA = "0x13A0210", Offset = "0x139EC10", VA = "0x1813A0210", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			RepeatedField<uint> repeatedField = gridIDs_;
			FieldCodec<uint> repeated_gridIDs_codec = _repeated_gridIDs_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gridIDs_codec);
			string text = customLocationPositionsPath_;
			if (text.m_stringLength != 0)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
				num += num2;
			}
			RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
			FieldCodec<BodyOfWater> repeated_bodiesOfWater_codec = _repeated_bodiesOfWater_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_bodiesOfWater_codec);
			RepeatedField<MiningRock> repeatedField3 = miningRocks_;
			FieldCodec<MiningRock> repeated_miningRocks_codec = _repeated_miningRocks_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_miningRocks_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<BodyOfWater>)(repeatedField2 + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F31")]
		[Cpp2IlInjected.Address(RVA = "0x13A0D40", Offset = "0x139F740", VA = "0x1813A0D40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OffGridBuilding other)
		{
			//Discarded unreachable code: IL_0080
			if (other != null)
			{
				RepeatedField<uint> repeatedField = gridIDs_;
				RepeatedField<uint> repeatedField2 = other.gridIDs_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text = other.customLocationPositionsPath_;
				if (text.m_stringLength != 0)
				{
					CustomLocationPositionsPath = text;
				}
				RepeatedField<BodyOfWater> repeatedField3 = bodiesOfWater_;
				RepeatedField<BodyOfWater> repeatedField4 = other.bodiesOfWater_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<MiningRock> repeatedField5 = miningRocks_;
				RepeatedField<MiningRock> repeatedField6 = other.miningRocks_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F32")]
		[Cpp2IlInjected.Address(RVA = "0x13A0B50", Offset = "0x139F550", VA = "0x1813A0B50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_009f
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 10)
			{
				if (num == 18)
				{
					string text2 = (CustomLocationPositionsPath = input.ReadString());
				}
				if (num == 26)
				{
					RepeatedField<BodyOfWater> repeatedField = bodiesOfWater_;
					FieldCodec<BodyOfWater> repeated_bodiesOfWater_codec = _repeated_bodiesOfWater_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_bodiesOfWater_codec);
				}
				if (num != 34)
				{
					goto IL_006f;
				}
				RepeatedField<MiningRock> repeatedField2 = miningRocks_;
				FieldCodec<MiningRock> repeated_miningRocks_codec = _repeated_miningRocks_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_miningRocks_codec);
			}
			num += 4294967288u;
			if (num != 4294967293u)
			{
				goto IL_006f;
			}
			goto IL_0085;
			IL_0085:
			RepeatedField<uint> repeatedField3 = gridIDs_;
			FieldCodec<uint> repeated_gridIDs_codec = _repeated_gridIDs_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gridIDs_codec);
			return;
			IL_006f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			goto IL_0085;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F33")]
		[Cpp2IlInjected.Address(RVA = "0x13A0700", Offset = "0x139F100", VA = "0x1813A0700", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MiningRock> repeatedField = miningRocks_;
				RepeatedField<BodyOfWater> repeatedField2 = bodiesOfWater_;
				string text = customLocationPositionsPath_;
				RepeatedField<uint> repeatedField3 = gridIDs_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F34")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E30", Offset = "0x139F830", VA = "0x1813A0E30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
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
					int num2 = 0;
					if (value == null || value != null)
					{
						CustomLocationPositionsPath = (string)num2;
						return;
					}
					continue;
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F35")]
		[Cpp2IlInjected.Address(RVA = "0x13A03B0", Offset = "0x139EDB0", VA = "0x1813A03B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 0 || num == 1)
				{
					CustomLocationPositionsPath = "";
				}
				return;
			}
			RepeatedField<uint> repeatedField = gridIDs_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F36")]
		[Cpp2IlInjected.Address(RVA = "0x13A08E0", Offset = "0x139F2E0", VA = "0x1813A08E0")]
		public void Initialize(in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000c
			RepeatedField<BodyOfWater> repeatedField = bodiesOfWater_;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F37")]
		[Cpp2IlInjected.Address(RVA = "0x13A0880", Offset = "0x139F280", VA = "0x1813A0880")]
		public bool HasGrid(uint gridID)
		{
			//Discarded unreachable code: IL_000d
			//IL_000c: Expected O, but got I4
			return ((RepeatedField<T>)(object)gridIDs_).Contains((T)gridID);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F38")]
		[Cpp2IlInjected.Address(RVA = "0x13A09F0", Offset = "0x139F3F0", VA = "0x1813A09F0")]
		public bool IsBuildingRelatedGrid(uint gridID, GridCollection gridCollection)
		{
			//IL_0020: Expected O, but got I4
			uint gridID2 = gridID;
			if (((RepeatedField<T>)(object)gridIDs_).Contains((T)gridID))
			{
				return true;
			}
			RepeatedField<uint> repeatedField = gridIDs_;
			Predicate<uint> predicate = (Predicate<uint>)(object)(Predicate<T>)delegate(uint x)
			{
				//Discarded unreachable code: IL_0017
				GridCollection gridCollection2 = gridCollection;
				uint potentialSubGridID = gridID2;
				return gridCollection2.IsSubGridOf(potentialSubGridID, x);
			};
			bool flag = ((RepeatedField<>)(object)repeatedField).Any<uint>((Predicate<>)(object)predicate);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F39")]
		[Cpp2IlInjected.Address(RVA = "0x13A11A0", Offset = "0x139FBA0", VA = "0x1813A11A0")]
		static OffGridBuilding()
		{
			Func<OffGridBuilding> func = default(Func<OffGridBuilding>);
			_parser = (MessageParser<OffGridBuilding>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<OffGridBuilding>)(object)FieldCodec.ForUInt32(10u);
			MessageParser<BodyOfWater> parser = BodyOfWater._parser;
			uint num = default(uint);
			_parser = (MessageParser<OffGridBuilding>)(object)FieldCodec.ForMessage<BodyOfWater>(num, (MessageParser<>)(object)parser);
			MessageParser<MiningRock> parser2 = MiningRock._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<OffGridBuilding>)(object)FieldCodec.ForMessage<MiningRock>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
