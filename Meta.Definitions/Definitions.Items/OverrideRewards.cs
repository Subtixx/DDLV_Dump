using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000548")]
	public sealed class OverrideRewards : IMessage<OverrideRewards>, IMessage, IEquatable<OverrideRewards>, IDeepCloneable<OverrideRewards>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001CB1")]
		private static readonly MessageParser<OverrideRewards> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CB2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CB3")]
		public const int RewardsFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4001CB4")]
		private static readonly FieldCodec<int> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CB5")]
		private readonly RepeatedField<int> rewards_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001103")]
		[DebuggerNonUserCode]
		public static MessageParser<OverrideRewards> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60041DC")]
			[Cpp2IlInjected.Address(RVA = "0x36A6D90", Offset = "0x36A5790", VA = "0x1836A6D90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001104")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041DD")]
			[Cpp2IlInjected.Address(RVA = "0x36A6CC0", Offset = "0x36A56C0", VA = "0x1836A6CC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001105")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041DE")]
			[Cpp2IlInjected.Address(RVA = "0x36A6DF0", Offset = "0x36A57F0", VA = "0x1836A6DF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001106")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60041E2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041DF")]
		[Cpp2IlInjected.Address(RVA = "0x36A6B40", Offset = "0x36A5540", VA = "0x1836A6B40")]
		[DebuggerNonUserCode]
		public OverrideRewards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60041E0")]
		[Cpp2IlInjected.Address(RVA = "0x36A6BC0", Offset = "0x36A55C0", VA = "0x1836A6BC0")]
		[DebuggerNonUserCode]
		public OverrideRewards(OverrideRewards other)
		{
			RepeatedField<int> repeatedField = (rewards_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041E1")]
		[Cpp2IlInjected.Address(RVA = "0x36A63F0", Offset = "0x36A4DF0", VA = "0x1836A63F0", Slot = "10")]
		[DebuggerNonUserCode]
		public OverrideRewards Clone()
		{
			//Discarded unreachable code: IL_003b
			OverrideRewards overrideRewards = new OverrideRewards();
			RepeatedField<int> repeatedField = (overrideRewards.rewards_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (overrideRewards.rewards_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (overrideRewards._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return overrideRewards;
		}

		[Cpp2IlInjected.Token(Token = "0x60041E3")]
		[Cpp2IlInjected.Address(RVA = "0x36A65B0", Offset = "0x36A4FB0", VA = "0x1836A65B0", Slot = "0")]
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
				RepeatedField<int> repeatedField = rewards_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041E4")]
		[Cpp2IlInjected.Address(RVA = "0x36A6520", Offset = "0x36A4F20", VA = "0x1836A6520", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OverrideRewards other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = rewards_;
				RepeatedField<int> repeatedField2 = other.rewards_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041E5")]
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

		[Cpp2IlInjected.Token(Token = "0x60041E6")]
		[Cpp2IlInjected.Address(RVA = "0x36A68E0", Offset = "0x36A52E0", VA = "0x1836A68E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60041E7")]
		[Cpp2IlInjected.Address(RVA = "0x36A6940", Offset = "0x36A5340", VA = "0x1836A6940", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = rewards_;
			FieldCodec<int> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60041E8")]
		[Cpp2IlInjected.Address(RVA = "0x36A62E0", Offset = "0x36A4CE0", VA = "0x1836A62E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = rewards_;
			FieldCodec<int> repeated_rewards_codec = _repeated_rewards_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60041E9")]
		[Cpp2IlInjected.Address(RVA = "0x36A6800", Offset = "0x36A5200", VA = "0x1836A6800", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OverrideRewards other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = rewards_;
				RepeatedField<int> repeatedField2 = other.rewards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041EA")]
		[Cpp2IlInjected.Address(RVA = "0x36A6710", Offset = "0x36A5110", VA = "0x1836A6710", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0045
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967048u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = rewards_;
				FieldCodec<int> repeated_rewards_codec = _repeated_rewards_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041EB")]
		[Cpp2IlInjected.Address(RVA = "0x36A6690", Offset = "0x36A5090", VA = "0x1836A6690", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 31)
			{
				RepeatedField<int> repeatedField = rewards_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041EC")]
		[Cpp2IlInjected.Address(RVA = "0x36A6880", Offset = "0x36A5280", VA = "0x1836A6880", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 31)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041ED")]
		[Cpp2IlInjected.Address(RVA = "0x36A6390", Offset = "0x36A4D90", VA = "0x1836A6390", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000d
			if (fieldNumber == 31)
			{
				RepeatedField<int> repeatedField = rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041EE")]
		[Cpp2IlInjected.Address(RVA = "0x36A6A00", Offset = "0x36A5400", VA = "0x1836A6A00")]
		static OverrideRewards()
		{
			Func<OverrideRewards> func = default(Func<OverrideRewards>);
			_parser = (MessageParser<OverrideRewards>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<OverrideRewards>)(object)FieldCodec.ForInt32(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
