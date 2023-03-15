using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x200088B")]
	public sealed class TreeAndBushData : IGridStateData, IGrowable, IMessage<TreeAndBushData>, IMessage, IEquatable<TreeAndBushData>, IDeepCloneable<TreeAndBushData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A18")]
		private static readonly MessageParser<TreeAndBushData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A19")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A1A")]
		public const int EndOfLifeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A1B")]
		private Timestamp endOfLife_;

		[Cpp2IlInjected.Token(Token = "0x4002A1C")]
		public const int EndOfGrowthFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A1D")]
		private Timestamp endOfGrowth_;

		[Cpp2IlInjected.Token(Token = "0x4002A1E")]
		public const int NumberOfProductionLeftFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A1F")]
		private int numberOfProductionLeft_;

		[Cpp2IlInjected.Token(Token = "0x4002A20")]
		public const int SaplingGridObjectIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002A21")]
		private uint saplingGridObjectID_;

		[Cpp2IlInjected.Token(Token = "0x170017FE")]
		public bool CanDie
		{
			[Cpp2IlInjected.Token(Token = "0x6005F75")]
			[Cpp2IlInjected.Address(RVA = "0x11960C0", Offset = "0x1194AC0", VA = "0x1811960C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017FF")]
		[DebuggerNonUserCode]
		public static MessageParser<TreeAndBushData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F78")]
			[Cpp2IlInjected.Address(RVA = "0x354EC70", Offset = "0x354D670", VA = "0x18354EC70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001800")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F79")]
			[Cpp2IlInjected.Address(RVA = "0x354EBA0", Offset = "0x354D5A0", VA = "0x18354EBA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001801")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F7A")]
			[Cpp2IlInjected.Address(RVA = "0x354ECD0", Offset = "0x354D6D0", VA = "0x18354ECD0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001802")]
		[DebuggerNonUserCode]
		public Timestamp EndOfLife
		{
			[Cpp2IlInjected.Token(Token = "0x6005F7F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return endOfLife_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F80")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				endOfLife_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001803")]
		[DebuggerNonUserCode]
		public Timestamp EndOfGrowth
		{
			[Cpp2IlInjected.Token(Token = "0x6005F81")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "4")]
			get
			{
				return endOfGrowth_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F82")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "5")]
			set
			{
				endOfGrowth_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001804")]
		[DebuggerNonUserCode]
		public int NumberOfProductionLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6005F83")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return numberOfProductionLeft_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F84")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				numberOfProductionLeft_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001805")]
		[DebuggerNonUserCode]
		public uint SaplingGridObjectID
		{
			[Cpp2IlInjected.Token(Token = "0x6005F85")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return saplingGridObjectID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F86")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				saplingGridObjectID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F73")]
		[Cpp2IlInjected.Address(RVA = "0x354E220", Offset = "0x354CC20", VA = "0x18354E220")]
		public void Initialize(SeedItemData plantedSeedItemData, ITransactionContext context)
		{
			Timestamp timestamp = default(Timestamp);
			endOfGrowth_ = timestamp;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F74")]
		[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
		public void SetSaplingInstance(uint instanceId)
		{
			saplingGridObjectID_ = instanceId;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F76")]
		[Cpp2IlInjected.Address(RVA = "0x354E2C0", Offset = "0x354CCC0", VA = "0x18354E2C0")]
		public bool IsDead(ITransactionContext context)
		{
			//Discarded unreachable code: IL_001b
			if ((long)endOfLife_ == 0)
			{
				int num = 0;
			}
			DateTime dateTime = endOfLife_.ToDateTime();
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F77")]
		[Cpp2IlInjected.Address(RVA = "0x354E1A0", Offset = "0x354CBA0", VA = "0x18354E1A0")]
		public DateTime GetTimeOfDeath(ITransactionContext context)
		{
			return endOfLife_?.ToDateTime() ?? DateTime.MaxValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7B")]
		[Cpp2IlInjected.Address(RVA = "0x354EB30", Offset = "0x354D530", VA = "0x18354EB30")]
		[DebuggerNonUserCode]
		public TreeAndBushData()
		{
			Timestamp timestamp = (endOfGrowth_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7C")]
		[Cpp2IlInjected.Address(RVA = "0x354E610", Offset = "0x354D010", VA = "0x18354E610")]
		private void OnConstruction()
		{
			Timestamp timestamp = (endOfGrowth_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7D")]
		[Cpp2IlInjected.Address(RVA = "0x354EA30", Offset = "0x354D430", VA = "0x18354EA30")]
		[DebuggerNonUserCode]
		public TreeAndBushData(TreeAndBushData other)
		{
			//IL_002e: Expected O, but got I4
			Timestamp timestamp = (endOfGrowth_ = new Timestamp());
			Timestamp timestamp2 = other.endOfLife_;
			int num = 0;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			endOfLife_ = (Timestamp)num;
			Timestamp timestamp4 = other.endOfGrowth_;
			Timestamp timestamp5 = default(Timestamp);
			if (timestamp4 != null)
			{
				timestamp5 = timestamp4.Clone();
			}
			endOfGrowth_ = timestamp5;
			int num2 = (numberOfProductionLeft_ = other.numberOfProductionLeft_);
			uint num3 = (saplingGridObjectID_ = other.saplingGridObjectID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7E")]
		[Cpp2IlInjected.Address(RVA = "0x354DD40", Offset = "0x354C740", VA = "0x18354DD40", Slot = "12")]
		[DebuggerNonUserCode]
		public TreeAndBushData Clone()
		{
			//Discarded unreachable code: IL_0084
			//IL_002f: Expected O, but got I4
			TreeAndBushData treeAndBushData = new TreeAndBushData();
			Timestamp timestamp = (treeAndBushData.endOfGrowth_ = new Timestamp());
			Timestamp timestamp2 = endOfLife_;
			int num = 0;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			treeAndBushData.endOfLife_ = (Timestamp)num;
			Timestamp timestamp4 = endOfGrowth_;
			Timestamp timestamp5 = default(Timestamp);
			if (timestamp4 != null)
			{
				timestamp5 = timestamp4.Clone();
			}
			treeAndBushData.endOfGrowth_ = timestamp5;
			int num2 = (treeAndBushData.numberOfProductionLeft_ = numberOfProductionLeft_);
			uint num3 = (treeAndBushData.saplingGridObjectID_ = saplingGridObjectID_);
			UnknownFieldSet unknownFieldSet = (treeAndBushData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return treeAndBushData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F87")]
		[Cpp2IlInjected.Address(RVA = "0x354DE70", Offset = "0x354C870", VA = "0x18354DE70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(endOfLife_, other))
				{
					bool flag = object.Equals(endOfGrowth_, other);
					if (flag && numberOfProductionLeft_ == (flag ? 1 : 0) && saplingGridObjectID_ == (flag ? 1u : 0u))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F88")]
		[Cpp2IlInjected.Address(RVA = "0x354DF40", Offset = "0x354C940", VA = "0x18354DF40", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(TreeAndBushData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.endOfLife_;
				if (object.Equals(endOfLife_, objB))
				{
					Timestamp objB2 = other.endOfGrowth_;
					if (object.Equals(endOfGrowth_, objB2))
					{
						int num = other.numberOfProductionLeft_;
						if (numberOfProductionLeft_ == num)
						{
							uint num2 = other.saplingGridObjectID_;
							if (saplingGridObjectID_ == num2)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F89")]
		[Cpp2IlInjected.Address(RVA = "0x354E0E0", Offset = "0x354CAE0", VA = "0x18354E0E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				Timestamp timestamp = endOfLife_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				Timestamp timestamp2 = endOfGrowth_;
				if (timestamp2 != null)
				{
					int hashCode2 = timestamp2.GetHashCode();
				}
				if (numberOfProductionLeft_ != 0)
				{
				}
				if (saplingGridObjectID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8A")]
		[Cpp2IlInjected.Address(RVA = "0x354E7E0", Offset = "0x354D1E0", VA = "0x18354E7E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8B")]
		[Cpp2IlInjected.Address(RVA = "0x354E840", Offset = "0x354D240", VA = "0x18354E840", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0077
			if ((long)endOfLife_ != 0)
			{
				Timestamp value = endOfLife_;
				output.WriteMessage(value);
			}
			if ((long)endOfGrowth_ != 0)
			{
				Timestamp value2 = endOfGrowth_;
				output.WriteMessage(value2);
			}
			if (numberOfProductionLeft_ != 0)
			{
				int value3 = numberOfProductionLeft_;
				output.WriteInt32(value3);
			}
			if (saplingGridObjectID_ != 0)
			{
				uint value4 = saplingGridObjectID_;
				output.WriteUInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8C")]
		[Cpp2IlInjected.Address(RVA = "0x354DBC0", Offset = "0x354C5C0", VA = "0x18354DBC0", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = endOfLife_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				Timestamp timestamp2 = endOfGrowth_;
				if (timestamp2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(timestamp2);
					num3++;
					num += num3;
				}
				int num4 = numberOfProductionLeft_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num += num5;
				}
				uint num6 = saplingGridObjectID_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeUInt32Size(num6);
					num7++;
					num += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8D")]
		[Cpp2IlInjected.Address(RVA = "0x354E4E0", Offset = "0x354CEE0", VA = "0x18354E4E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(TreeAndBushData other)
		{
			//Discarded unreachable code: IL_00c6
			if (other == null)
			{
				return;
			}
			if ((long)other.endOfLife_ != 0)
			{
				Timestamp timestamp = endOfLife_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (endOfLife_ = new Timestamp());
					Timestamp timestamp3 = endOfLife_;
				}
				Timestamp other2 = other.endOfLife_;
				timestamp.MergeFrom(other2);
			}
			if ((long)other.endOfGrowth_ != 0)
			{
				Timestamp timestamp5 = default(Timestamp);
				if (endOfGrowth_ == null)
				{
					Timestamp timestamp4 = (endOfGrowth_ = new Timestamp());
					timestamp5 = endOfGrowth_;
				}
				Timestamp other3 = other.endOfGrowth_;
				timestamp5.MergeFrom(other3);
			}
			int num = other.numberOfProductionLeft_;
			if (num != 0)
			{
				numberOfProductionLeft_ = num;
			}
			uint num2 = other.saplingGridObjectID_;
			if (num2 != 0)
			{
				saplingGridObjectID_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8E")]
		[Cpp2IlInjected.Address(RVA = "0x354E380", Offset = "0x354CD80", VA = "0x18354E380", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00af
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (numberOfProductionLeft_ = input.ReadInt32());
				}
				if (num != 32)
				{
					goto IL_0098;
				}
				int num3 = (int)(saplingGridObjectID_ = (uint)input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 10)
			{
				Timestamp builder = default(Timestamp);
				if (endOfLife_ == null)
				{
					timestamp = (endOfLife_ = new Timestamp());
					builder = endOfLife_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 18)
			{
				Timestamp builder2 = default(Timestamp);
				if (endOfGrowth_ == null)
				{
					Timestamp timestamp2 = (endOfGrowth_ = new Timestamp());
					builder2 = endOfGrowth_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_0098;
			IL_0098:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8F")]
		[Cpp2IlInjected.Address(RVA = "0x354DFD0", Offset = "0x354C9D0", VA = "0x18354DFD0", Slot = "13")]
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
						uint num2 = saplingGridObjectID_;
					}
					int num3 = numberOfProductionLeft_;
				}
				Timestamp timestamp = endOfGrowth_;
			}
			Timestamp timestamp2 = endOfLife_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F90")]
		[Cpp2IlInjected.Address(RVA = "0x354E670", Offset = "0x354D070", VA = "0x18354E670", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			//IL_0035: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj2 = default(object);
						saplingGridObjectID_ = (uint)(int)obj2;
						break;
					}
					case 0:
					{
						object obj = default(object);
						numberOfProductionLeft_ = (int)obj;
						break;
					}
					}
				}
				else
				{
					int num2 = 0;
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					endOfGrowth_ = (Timestamp)num2;
				}
				return;
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F91")]
		[Cpp2IlInjected.Address(RVA = "0x354DCF0", Offset = "0x354C6F0", VA = "0x18354DCF0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				saplingGridObjectID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F92")]
		[Cpp2IlInjected.Address(RVA = "0x354E920", Offset = "0x354D320", VA = "0x18354E920")]
		static TreeAndBushData()
		{
			Func<TreeAndBushData> func = default(Func<TreeAndBushData>);
			_parser = (MessageParser<TreeAndBushData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
