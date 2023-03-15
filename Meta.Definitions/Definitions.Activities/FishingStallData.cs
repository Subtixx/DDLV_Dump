using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008B0")]
	public sealed class FishingStallData : IGridStateData, IGridUpgradeStateData, IMessage<FishingStallData>, IMessage, IEquatable<FishingStallData>, IDeepCloneable<FishingStallData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002AAF")]
		private static readonly MessageParser<FishingStallData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002AB0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002AB1")]
		public const int UpgradeStateFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AB2")]
		private UpgradeState upgradeState_;

		[Cpp2IlInjected.Token(Token = "0x4002AB3")]
		public const int LastCollectFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AB4")]
		private Timestamp lastCollect_;

		[Cpp2IlInjected.Token(Token = "0x4002AB5")]
		public const int PendingFishesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002AB6")]
		private static readonly FieldCodec<MultiReward> _repeated_pendingFishes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AB7")]
		private readonly RepeatedField<MultiReward> pendingFishes_ = (RepeatedField<MultiReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001862")]
		public DateTime LastCollectDateTime
		{
			[Cpp2IlInjected.Token(Token = "0x6006129")]
			[Cpp2IlInjected.Address(RVA = "0x3580110", Offset = "0x357EB10", VA = "0x183580110")]
			get
			{
				return lastCollect_?.ToDateTime() ?? DateTime.MinValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001863")]
		[DebuggerNonUserCode]
		public static MessageParser<FishingStallData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600612A")]
			[Cpp2IlInjected.Address(RVA = "0x3580190", Offset = "0x357EB90", VA = "0x183580190")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001864")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600612B")]
			[Cpp2IlInjected.Address(RVA = "0x3580040", Offset = "0x357EA40", VA = "0x183580040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001865")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600612C")]
			[Cpp2IlInjected.Address(RVA = "0x35801F0", Offset = "0x357EBF0", VA = "0x1835801F0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001866")]
		[DebuggerNonUserCode]
		public UpgradeState UpgradeState
		{
			[Cpp2IlInjected.Token(Token = "0x6006130")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get
			{
				return upgradeState_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006131")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "5")]
			set
			{
				upgradeState_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001867")]
		[DebuggerNonUserCode]
		public Timestamp LastCollect
		{
			[Cpp2IlInjected.Token(Token = "0x6006132")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastCollect_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006133")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastCollect_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001868")]
		[DebuggerNonUserCode]
		public RepeatedField<MultiReward> PendingFishes
		{
			[Cpp2IlInjected.Token(Token = "0x6006134")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return pendingFishes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600612D")]
		[Cpp2IlInjected.Address(RVA = "0x357FFC0", Offset = "0x357E9C0", VA = "0x18357FFC0")]
		[DebuggerNonUserCode]
		public FishingStallData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600612E")]
		[Cpp2IlInjected.Address(RVA = "0x357FE70", Offset = "0x357E870", VA = "0x18357FE70")]
		[DebuggerNonUserCode]
		public FishingStallData(FishingStallData other)
		{
			//IL_002e: Expected O, but got I4
			UpgradeState upgradeState = other.upgradeState_;
			int num = 0;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			upgradeState_ = (UpgradeState)num;
			Timestamp timestamp = other.lastCollect_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			lastCollect_ = timestamp2;
			RepeatedField<MultiReward> repeatedField = (pendingFishes_ = (RepeatedField<MultiReward>)(object)((RepeatedField<T>)(object)other.pendingFishes_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600612F")]
		[Cpp2IlInjected.Address(RVA = "0x357F2B0", Offset = "0x357DCB0", VA = "0x18357F2B0", Slot = "12")]
		[DebuggerNonUserCode]
		public FishingStallData Clone()
		{
			//Discarded unreachable code: IL_0079
			//IL_002f: Expected O, but got I4
			FishingStallData fishingStallData = new FishingStallData();
			RepeatedField<MultiReward> repeatedField = (fishingStallData.pendingFishes_ = (RepeatedField<MultiReward>)(object)new RepeatedField<T>());
			UpgradeState upgradeState = upgradeState_;
			int num = 0;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			fishingStallData.upgradeState_ = (UpgradeState)num;
			Timestamp timestamp = lastCollect_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			fishingStallData.lastCollect_ = timestamp2;
			RepeatedField<MultiReward> repeatedField2 = (fishingStallData.pendingFishes_ = (RepeatedField<MultiReward>)(object)((RepeatedField<T>)(object)pendingFishes_).Clone());
			UnknownFieldSet unknownFieldSet = (fishingStallData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fishingStallData;
		}

		[Cpp2IlInjected.Token(Token = "0x6006135")]
		[Cpp2IlInjected.Address(RVA = "0x357F4E0", Offset = "0x357DEE0", VA = "0x18357F4E0", Slot = "0")]
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
				if (object.Equals(upgradeState_, other) && object.Equals(lastCollect_, other))
				{
					RepeatedField<MultiReward> repeatedField = pendingFishes_;
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

		[Cpp2IlInjected.Token(Token = "0x6006136")]
		[Cpp2IlInjected.Address(RVA = "0x357F420", Offset = "0x357DE20", VA = "0x18357F420", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(FishingStallData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				UpgradeState objB = other.upgradeState_;
				if (object.Equals(upgradeState_, objB))
				{
					Timestamp objB2 = other.lastCollect_;
					if (object.Equals(lastCollect_, objB2))
					{
						RepeatedField<MultiReward> repeatedField = pendingFishes_;
						RepeatedField<MultiReward> repeatedField2 = other.pendingFishes_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006137")]
		[Cpp2IlInjected.Address(RVA = "0x357F680", Offset = "0x357E080", VA = "0x18357F680", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0049
			UpgradeState upgradeState = upgradeState_;
			if (upgradeState != null)
			{
				int hashCode = upgradeState.GetHashCode();
			}
			Timestamp timestamp = lastCollect_;
			if (timestamp != null)
			{
				int hashCode2 = timestamp.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)pendingFishes_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006138")]
		[Cpp2IlInjected.Address(RVA = "0x357FB30", Offset = "0x357E530", VA = "0x18357FB30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006139")]
		[Cpp2IlInjected.Address(RVA = "0x357FB90", Offset = "0x357E590", VA = "0x18357FB90", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005d
			if ((long)upgradeState_ != 0)
			{
				UpgradeState value = upgradeState_;
				output.WriteMessage(value);
			}
			if ((long)lastCollect_ != 0)
			{
				Timestamp value2 = lastCollect_;
				output.WriteMessage(value2);
			}
			RepeatedField<MultiReward> repeatedField = pendingFishes_;
			FieldCodec<MultiReward> repeated_pendingFishes_codec = _repeated_pendingFishes_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_pendingFishes_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600613A")]
		[Cpp2IlInjected.Address(RVA = "0x357F0F0", Offset = "0x357DAF0", VA = "0x18357F0F0", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_006e
			UpgradeState upgradeState = upgradeState_;
			int num = 0;
			if (upgradeState != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(upgradeState);
			}
			Timestamp timestamp = lastCollect_;
			if (timestamp != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(timestamp);
				num3++;
				num += num3;
			}
			RepeatedField<MultiReward> repeatedField = pendingFishes_;
			FieldCodec<MultiReward> repeated_pendingFishes_codec = _repeated_pendingFishes_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_pendingFishes_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600613B")]
		[Cpp2IlInjected.Address(RVA = "0x357F720", Offset = "0x357E120", VA = "0x18357F720", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingStallData other)
		{
			//Discarded unreachable code: IL_00b4
			if (other == null)
			{
				return;
			}
			if ((long)other.upgradeState_ != 0)
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState == null)
				{
					UpgradeState upgradeState2 = (upgradeState_ = new UpgradeState());
					UpgradeState upgradeState3 = upgradeState_;
				}
				UpgradeState other2 = other.upgradeState_;
				upgradeState.MergeFrom(other2);
			}
			if ((long)other.lastCollect_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastCollect_ == null)
				{
					Timestamp timestamp = (lastCollect_ = new Timestamp());
					timestamp2 = lastCollect_;
				}
				Timestamp other3 = other.lastCollect_;
				timestamp2.MergeFrom(other3);
			}
			RepeatedField<MultiReward> repeatedField = pendingFishes_;
			RepeatedField<MultiReward> repeatedField2 = other.pendingFishes_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600613C")]
		[Cpp2IlInjected.Address(RVA = "0x357F870", Offset = "0x357E270", VA = "0x18357F870", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0097
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState == null)
				{
					UpgradeState upgradeState2 = (upgradeState_ = new UpgradeState());
				}
				input.ReadMessage(upgradeState);
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (lastCollect_ == null)
				{
					timestamp = (lastCollect_ = new Timestamp());
					builder = lastCollect_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 26)
			{
				RepeatedField<MultiReward> repeatedField = pendingFishes_;
				FieldCodec<MultiReward> repeated_pendingFishes_codec = _repeated_pendingFishes_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_pendingFishes_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600613D")]
		[Cpp2IlInjected.Address(RVA = "0x357F5E0", Offset = "0x357DFE0", VA = "0x18357F5E0", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MultiReward> repeatedField = pendingFishes_;
				Timestamp timestamp = lastCollect_;
				UpgradeState upgradeState = upgradeState_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600613E")]
		[Cpp2IlInjected.Address(RVA = "0x357FA20", Offset = "0x357E420", VA = "0x18357FA20", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						lastCollect_ = (Timestamp)num2;
						return;
					}
				}
				else
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				}
				throw new InvalidCastException();
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600613F")]
		[Cpp2IlInjected.Address(RVA = "0x357F220", Offset = "0x357DC20", VA = "0x18357F220", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0018
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num == 1)
			{
				RepeatedField<MultiReward> repeatedField = pendingFishes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006140")]
		[Cpp2IlInjected.Address(RVA = "0x357FCA0", Offset = "0x357E6A0", VA = "0x18357FCA0")]
		static FishingStallData()
		{
			Func<FishingStallData> func = default(Func<FishingStallData>);
			_parser = (MessageParser<FishingStallData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MultiReward> parser = MultiReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<FishingStallData>)(object)FieldCodec.ForMessage<MultiReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
