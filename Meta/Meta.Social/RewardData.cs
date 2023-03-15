using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000C23")]
	public sealed class RewardData : IMessage<RewardData>, IMessage, IEquatable<RewardData>, IDeepCloneable<RewardData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002F01")]
		private static readonly MessageParser<RewardData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002F02")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002F03")]
		public const int RewardsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002F04")]
		private static readonly FieldCodec<InboxItemReward> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002F05")]
		private readonly RepeatedField<InboxItemReward> rewards_ = (RepeatedField<InboxItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170011EE")]
		[DebuggerNonUserCode]
		public static MessageParser<RewardData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600675E")]
			[Cpp2IlInjected.Address(RVA = "0x1765580", Offset = "0x1763F80", VA = "0x181765580")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011EF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600675F")]
			[Cpp2IlInjected.Address(RVA = "0x17654B0", Offset = "0x1763EB0", VA = "0x1817654B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006760")]
			[Cpp2IlInjected.Address(RVA = "0x17655E0", Offset = "0x1763FE0", VA = "0x1817655E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F1")]
		[DebuggerNonUserCode]
		public RepeatedField<InboxItemReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x6006764")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006761")]
		[Cpp2IlInjected.Address(RVA = "0x1765430", Offset = "0x1763E30", VA = "0x181765430")]
		[DebuggerNonUserCode]
		public RewardData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006762")]
		[Cpp2IlInjected.Address(RVA = "0x1765330", Offset = "0x1763D30", VA = "0x181765330")]
		[DebuggerNonUserCode]
		public RewardData(RewardData other)
		{
			RepeatedField<InboxItemReward> repeatedField = (rewards_ = (RepeatedField<InboxItemReward>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006763")]
		[Cpp2IlInjected.Address(RVA = "0x1764B50", Offset = "0x1763550", VA = "0x181764B50", Slot = "10")]
		[DebuggerNonUserCode]
		public RewardData Clone()
		{
			//Discarded unreachable code: IL_003b
			RewardData rewardData = new RewardData();
			RepeatedField<InboxItemReward> repeatedField = (rewardData.rewards_ = (RepeatedField<InboxItemReward>)(object)new RepeatedField<T>());
			RepeatedField<InboxItemReward> repeatedField2 = (rewardData.rewards_ = (RepeatedField<InboxItemReward>)(object)((RepeatedField<T>)(object)rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (rewardData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return rewardData;
		}

		[Cpp2IlInjected.Token(Token = "0x6006765")]
		[Cpp2IlInjected.Address(RVA = "0x1764D10", Offset = "0x1763710", VA = "0x181764D10", Slot = "0")]
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
				RepeatedField<InboxItemReward> repeatedField = rewards_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006766")]
		[Cpp2IlInjected.Address(RVA = "0x1764C80", Offset = "0x1763680", VA = "0x181764C80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RewardData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<InboxItemReward> repeatedField = rewards_;
				RepeatedField<InboxItemReward> repeatedField2 = other.rewards_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006767")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)rewards_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6006768")]
		[Cpp2IlInjected.Address(RVA = "0x1765040", Offset = "0x1763A40", VA = "0x181765040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006769")]
		[Cpp2IlInjected.Address(RVA = "0x17650A0", Offset = "0x1763AA0", VA = "0x1817650A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<InboxItemReward> repeatedField = rewards_;
			FieldCodec<InboxItemReward> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600676A")]
		[Cpp2IlInjected.Address(RVA = "0x1764A40", Offset = "0x1763440", VA = "0x181764A40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<InboxItemReward> repeatedField = rewards_;
			FieldCodec<InboxItemReward> repeated_rewards_codec = _repeated_rewards_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600676B")]
		[Cpp2IlInjected.Address(RVA = "0x1764F60", Offset = "0x1763960", VA = "0x181764F60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RewardData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<InboxItemReward> repeatedField = rewards_;
				RepeatedField<InboxItemReward> repeatedField2 = other.rewards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600676C")]
		[Cpp2IlInjected.Address(RVA = "0x1764E70", Offset = "0x1763870", VA = "0x181764E70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<InboxItemReward> repeatedField = rewards_;
					FieldCodec<InboxItemReward> repeated_rewards_codec = _repeated_rewards_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600676D")]
		[Cpp2IlInjected.Address(RVA = "0x1764DF0", Offset = "0x17637F0", VA = "0x181764DF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<InboxItemReward> repeatedField = rewards_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600676E")]
		[Cpp2IlInjected.Address(RVA = "0x1764FE0", Offset = "0x17639E0", VA = "0x181764FE0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600676F")]
		[Cpp2IlInjected.Address(RVA = "0x1764AF0", Offset = "0x17634F0", VA = "0x181764AF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<InboxItemReward> repeatedField = rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006770")]
		[Cpp2IlInjected.Address(RVA = "0x1765160", Offset = "0x1763B60", VA = "0x181765160")]
		static RewardData()
		{
			Func<RewardData> func = default(Func<RewardData>);
			_parser = (MessageParser<RewardData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<InboxItemReward> parser = InboxItemReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<RewardData>)(object)FieldCodec.ForMessage<InboxItemReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
