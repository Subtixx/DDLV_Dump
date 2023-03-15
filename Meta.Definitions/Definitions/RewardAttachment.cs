using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class RewardAttachment : IMessage<RewardAttachment>, IMessage, IEquatable<RewardAttachment>, IDeepCloneable<RewardAttachment>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private static readonly MessageParser<RewardAttachment> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public const int RewardsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static readonly FieldCodec<InboxItemReward> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private readonly RepeatedField<InboxItemReward> rewards_ = (RepeatedField<InboxItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		[DebuggerNonUserCode]
		public static MessageParser<RewardAttachment> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0x2DAE100", Offset = "0x2DACB00", VA = "0x182DAE100")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0x2DAE030", Offset = "0x2DACA30", VA = "0x182DAE030")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0x2DAE160", Offset = "0x2DACB60", VA = "0x182DAE160", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		[DebuggerNonUserCode]
		public RepeatedField<InboxItemReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60009A5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2DADEB0", Offset = "0x2DAC8B0", VA = "0x182DADEB0")]
		[DebuggerNonUserCode]
		public RewardAttachment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2DADF30", Offset = "0x2DAC930", VA = "0x182DADF30")]
		[DebuggerNonUserCode]
		public RewardAttachment(RewardAttachment other)
		{
			RepeatedField<InboxItemReward> repeatedField = (rewards_ = (RepeatedField<InboxItemReward>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD6D0", Offset = "0x2DAC0D0", VA = "0x182DAD6D0", Slot = "10")]
		[DebuggerNonUserCode]
		public RewardAttachment Clone()
		{
			//Discarded unreachable code: IL_003b
			RewardAttachment rewardAttachment = new RewardAttachment();
			RepeatedField<InboxItemReward> repeatedField = (rewardAttachment.rewards_ = (RepeatedField<InboxItemReward>)(object)new RepeatedField<T>());
			RepeatedField<InboxItemReward> repeatedField2 = (rewardAttachment.rewards_ = (RepeatedField<InboxItemReward>)(object)((RepeatedField<T>)(object)rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (rewardAttachment._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return rewardAttachment;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD800", Offset = "0x2DAC200", VA = "0x182DAD800", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD8E0", Offset = "0x2DAC2E0", VA = "0x182DAD8E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RewardAttachment other)
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

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
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

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x2DADBC0", Offset = "0x2DAC5C0", VA = "0x182DADBC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2DADC20", Offset = "0x2DAC620", VA = "0x182DADC20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<InboxItemReward> repeatedField = rewards_;
			FieldCodec<InboxItemReward> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD5C0", Offset = "0x2DABFC0", VA = "0x182DAD5C0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2DADAE0", Offset = "0x2DAC4E0", VA = "0x182DADAE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RewardAttachment other)
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

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD9F0", Offset = "0x2DAC3F0", VA = "0x182DAD9F0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD970", Offset = "0x2DAC370", VA = "0x182DAD970", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2DADB60", Offset = "0x2DAC560", VA = "0x182DADB60", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD670", Offset = "0x2DAC070", VA = "0x182DAD670", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<InboxItemReward> repeatedField = rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DADCE0", Offset = "0x2DAC6E0", VA = "0x182DADCE0")]
		static RewardAttachment()
		{
			Func<RewardAttachment> func = default(Func<RewardAttachment>);
			_parser = (MessageParser<RewardAttachment>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<InboxItemReward> parser = InboxItemReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<RewardAttachment>)(object)FieldCodec.ForMessage<InboxItemReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
