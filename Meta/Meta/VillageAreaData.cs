using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007F5")]
	public sealed class VillageAreaData : IMessage<VillageAreaData>, IMessage, IEquatable<VillageAreaData>, IDeepCloneable<VillageAreaData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007F6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20007F7")]
			public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001FC7")]
				private static readonly MessageParser<Data> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001FC8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001FC9")]
				public const int AreaTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001FCA")]
				private VillageAreaType areaType_;

				[Cpp2IlInjected.Token(Token = "0x4001FCB")]
				public const int UnlockPlayerLevelFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001FCC")]
				private int unlockPlayerLevel_;

				[Cpp2IlInjected.Token(Token = "0x4001FCD")]
				public const int UnlockCostFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4001FCE")]
				private static readonly FieldCodec<CurrencyCost> _repeated_unlockCost_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001FCF")]
				private readonly RepeatedField<CurrencyCost> unlockCost_;

				[Cpp2IlInjected.Token(Token = "0x4001FD0")]
				public const int ManaCostFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001FD1")]
				private int manaCost_;

				[Cpp2IlInjected.Token(Token = "0x4001FD2")]
				public const int UnlockCharacterCountFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4001FD3")]
				private int unlockCharacterCount_;

				[Cpp2IlInjected.Token(Token = "0x17000AC8")]
				[DebuggerNonUserCode]
				public static MessageParser<Data> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600425D")]
					[Cpp2IlInjected.Address(RVA = "0xAC7A00", Offset = "0xAC6400", VA = "0x180AC7A00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AC9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600425E")]
					[Cpp2IlInjected.Address(RVA = "0xAC7980", Offset = "0xAC6380", VA = "0x180AC7980")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ACA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600425F")]
					[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6460", VA = "0x180AC7A60", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ACB")]
				[DebuggerNonUserCode]
				public VillageAreaType AreaType
				{
					[Cpp2IlInjected.Token(Token = "0x6004263")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(VillageAreaType);
					}
					[Cpp2IlInjected.Token(Token = "0x6004264")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ACC")]
				[DebuggerNonUserCode]
				public int UnlockPlayerLevel
				{
					[Cpp2IlInjected.Token(Token = "0x6004265")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004266")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ACD")]
				[DebuggerNonUserCode]
				public RepeatedField<CurrencyCost> UnlockCost
				{
					[Cpp2IlInjected.Token(Token = "0x6004267")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ACE")]
				[DebuggerNonUserCode]
				public int ManaCost
				{
					[Cpp2IlInjected.Token(Token = "0x6004268")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004269")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ACF")]
				[DebuggerNonUserCode]
				public int UnlockCharacterCount
				{
					[Cpp2IlInjected.Token(Token = "0x600426A")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600426B")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004260")]
				[Cpp2IlInjected.Address(RVA = "0xAC7900", Offset = "0xAC6300", VA = "0x180AC7900")]
				[DebuggerNonUserCode]
				public Data()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004261")]
				[Cpp2IlInjected.Address(RVA = "0xAC77F0", Offset = "0xAC61F0", VA = "0x180AC77F0")]
				[DebuggerNonUserCode]
				public Data(Data other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004262")]
				[Cpp2IlInjected.Address(RVA = "0xAC6BC0", Offset = "0xAC55C0", VA = "0x180AC6BC0", Slot = "10")]
				[DebuggerNonUserCode]
				public Data Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600426C")]
				[Cpp2IlInjected.Address(RVA = "0xAC6D00", Offset = "0xAC5700", VA = "0x180AC6D00", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600426D")]
				[Cpp2IlInjected.Address(RVA = "0xAC6E00", Offset = "0xAC5800", VA = "0x180AC6E00", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Data other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600426E")]
				[Cpp2IlInjected.Address(RVA = "0xAC6FC0", Offset = "0xAC59C0", VA = "0x180AC6FC0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600426F")]
				[Cpp2IlInjected.Address(RVA = "0xAC7460", Offset = "0xAC5E60", VA = "0x180AC7460", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004270")]
				[Cpp2IlInjected.Address(RVA = "0xAC74C0", Offset = "0xAC5EC0", VA = "0x180AC74C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004271")]
				[Cpp2IlInjected.Address(RVA = "0xAC68F0", Offset = "0xAC52F0", VA = "0x180AC68F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004272")]
				[Cpp2IlInjected.Address(RVA = "0xAC71F0", Offset = "0xAC5BF0", VA = "0x180AC71F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Data other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004273")]
				[Cpp2IlInjected.Address(RVA = "0xAC7090", Offset = "0xAC5A90", VA = "0x180AC7090", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004274")]
				[Cpp2IlInjected.Address(RVA = "0xAC6EB0", Offset = "0xAC58B0", VA = "0x180AC6EB0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004275")]
				[Cpp2IlInjected.Address(RVA = "0xAC72A0", Offset = "0xAC5CA0", VA = "0x180AC72A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004276")]
				[Cpp2IlInjected.Address(RVA = "0xAC6B00", Offset = "0xAC5500", VA = "0x180AC6B00", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004277")]
				[Cpp2IlInjected.Address(RVA = "0xAC6A80", Offset = "0xAC5480", VA = "0x180AC6A80")]
				public bool CanBeUnlocked(Profile profile)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001FC2")]
		private static readonly MessageParser<VillageAreaData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FC3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FC4")]
		public const int AreasFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001FC5")]
		private static readonly FieldCodec<Types.Data> _repeated_areas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FC6")]
		private readonly RepeatedField<Types.Data> areas_ = (RepeatedField<Types.Data>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000AC4")]
		[DebuggerNonUserCode]
		public static MessageParser<VillageAreaData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600424A")]
			[Cpp2IlInjected.Address(RVA = "0x15E14C0", Offset = "0x15DFEC0", VA = "0x1815E14C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600424B")]
			[Cpp2IlInjected.Address(RVA = "0x15E13F0", Offset = "0x15DFDF0", VA = "0x1815E13F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600424C")]
			[Cpp2IlInjected.Address(RVA = "0x15E1520", Offset = "0x15DFF20", VA = "0x1815E1520", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC7")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Data> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x6004250")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return areas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600424D")]
		[Cpp2IlInjected.Address(RVA = "0x15E1370", Offset = "0x15DFD70", VA = "0x1815E1370")]
		[DebuggerNonUserCode]
		public VillageAreaData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600424E")]
		[Cpp2IlInjected.Address(RVA = "0x15E1270", Offset = "0x15DFC70", VA = "0x1815E1270")]
		[DebuggerNonUserCode]
		public VillageAreaData(VillageAreaData other)
		{
			RepeatedField<Types.Data> repeatedField = (areas_ = (RepeatedField<Types.Data>)(object)((RepeatedField<T>)(object)other.areas_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600424F")]
		[Cpp2IlInjected.Address(RVA = "0x15E0A90", Offset = "0x15DF490", VA = "0x1815E0A90", Slot = "10")]
		[DebuggerNonUserCode]
		public VillageAreaData Clone()
		{
			//Discarded unreachable code: IL_003b
			VillageAreaData villageAreaData = new VillageAreaData();
			RepeatedField<Types.Data> repeatedField = (villageAreaData.areas_ = (RepeatedField<Types.Data>)(object)new RepeatedField<T>());
			RepeatedField<Types.Data> repeatedField2 = (villageAreaData.areas_ = (RepeatedField<Types.Data>)(object)((RepeatedField<T>)(object)areas_).Clone());
			UnknownFieldSet unknownFieldSet = (villageAreaData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return villageAreaData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004251")]
		[Cpp2IlInjected.Address(RVA = "0x15E0C50", Offset = "0x15DF650", VA = "0x1815E0C50", Slot = "0")]
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
				RepeatedField<Types.Data> repeatedField = areas_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004252")]
		[Cpp2IlInjected.Address(RVA = "0x15E0BC0", Offset = "0x15DF5C0", VA = "0x1815E0BC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(VillageAreaData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.Data> repeatedField = areas_;
				RepeatedField<Types.Data> repeatedField2 = other.areas_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004253")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)areas_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004254")]
		[Cpp2IlInjected.Address(RVA = "0x15E0F80", Offset = "0x15DF980", VA = "0x1815E0F80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004255")]
		[Cpp2IlInjected.Address(RVA = "0x15E0FE0", Offset = "0x15DF9E0", VA = "0x1815E0FE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.Data> repeatedField = areas_;
			FieldCodec<Types.Data> repeated_areas_codec = _repeated_areas_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_areas_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004256")]
		[Cpp2IlInjected.Address(RVA = "0x15E0980", Offset = "0x15DF380", VA = "0x1815E0980", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.Data> repeatedField = areas_;
			FieldCodec<Types.Data> repeated_areas_codec = _repeated_areas_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_areas_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004257")]
		[Cpp2IlInjected.Address(RVA = "0x15E0EA0", Offset = "0x15DF8A0", VA = "0x1815E0EA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(VillageAreaData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.Data> repeatedField = areas_;
				RepeatedField<Types.Data> repeatedField2 = other.areas_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004258")]
		[Cpp2IlInjected.Address(RVA = "0x15E0DB0", Offset = "0x15DF7B0", VA = "0x1815E0DB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.Data> repeatedField = areas_;
					FieldCodec<Types.Data> repeated_areas_codec = _repeated_areas_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_areas_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004259")]
		[Cpp2IlInjected.Address(RVA = "0x15E0D30", Offset = "0x15DF730", VA = "0x1815E0D30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.Data> repeatedField = areas_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600425A")]
		[Cpp2IlInjected.Address(RVA = "0x15E0F20", Offset = "0x15DF920", VA = "0x1815E0F20", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600425B")]
		[Cpp2IlInjected.Address(RVA = "0x15E0A30", Offset = "0x15DF430", VA = "0x1815E0A30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.Data> repeatedField = areas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600425C")]
		[Cpp2IlInjected.Address(RVA = "0x15E10A0", Offset = "0x15DFAA0", VA = "0x1815E10A0")]
		static VillageAreaData()
		{
			Func<VillageAreaData> func = default(Func<VillageAreaData>);
			_parser = (MessageParser<VillageAreaData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.Data> parser = Types.Data._parser;
			uint num = default(uint);
			_parser = (MessageParser<VillageAreaData>)(object)FieldCodec.ForMessage<Types.Data>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
