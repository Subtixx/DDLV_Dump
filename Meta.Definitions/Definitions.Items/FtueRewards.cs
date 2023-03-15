using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000555")]
	public sealed class FtueRewards : IMessage<FtueRewards>, IMessage, IEquatable<FtueRewards>, IDeepCloneable<FtueRewards>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001CF8")]
		private static readonly MessageParser<FtueRewards> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CF9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CFA")]
		public const int IsDefaultChoiceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CFB")]
		private bool isDefaultChoice_;

		[Cpp2IlInjected.Token(Token = "0x4001CFC")]
		public const int RewardsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001CFD")]
		private static readonly FieldCodec<FtueReward> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CFE")]
		private readonly RepeatedField<FtueReward> rewards_ = (RepeatedField<FtueReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001132")]
		[DebuggerNonUserCode]
		public static MessageParser<FtueRewards> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004296")]
			[Cpp2IlInjected.Address(RVA = "0x3441100", Offset = "0x343FB00", VA = "0x183441100")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001133")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004297")]
			[Cpp2IlInjected.Address(RVA = "0x3441030", Offset = "0x343FA30", VA = "0x183441030")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001134")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004298")]
			[Cpp2IlInjected.Address(RVA = "0x3441160", Offset = "0x343FB60", VA = "0x183441160", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001135")]
		[DebuggerNonUserCode]
		public bool IsDefaultChoice
		{
			[Cpp2IlInjected.Token(Token = "0x600429C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return isDefaultChoice_;
			}
			[Cpp2IlInjected.Token(Token = "0x600429D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				isDefaultChoice_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001136")]
		[DebuggerNonUserCode]
		public RepeatedField<FtueReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x600429E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004299")]
		[Cpp2IlInjected.Address(RVA = "0x3440FB0", Offset = "0x343F9B0", VA = "0x183440FB0")]
		[DebuggerNonUserCode]
		public FtueRewards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600429A")]
		[Cpp2IlInjected.Address(RVA = "0x3440EB0", Offset = "0x343F8B0", VA = "0x183440EB0")]
		[DebuggerNonUserCode]
		public FtueRewards(FtueRewards other)
		{
			bool flag = (isDefaultChoice_ = other.isDefaultChoice_);
			RepeatedField<FtueReward> repeatedField = (rewards_ = (RepeatedField<FtueReward>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600429B")]
		[Cpp2IlInjected.Address(RVA = "0x34405B0", Offset = "0x343EFB0", VA = "0x1834405B0", Slot = "10")]
		[DebuggerNonUserCode]
		public FtueRewards Clone()
		{
			//Discarded unreachable code: IL_004b
			FtueRewards ftueRewards = new FtueRewards();
			RepeatedField<FtueReward> repeatedField = (ftueRewards.rewards_ = (RepeatedField<FtueReward>)(object)new RepeatedField<T>());
			bool flag = (ftueRewards.isDefaultChoice_ = isDefaultChoice_);
			RepeatedField<FtueReward> repeatedField2 = (ftueRewards.rewards_ = (RepeatedField<FtueReward>)(object)((RepeatedField<T>)(object)rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (ftueRewards._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return ftueRewards;
		}

		[Cpp2IlInjected.Token(Token = "0x600429F")]
		[Cpp2IlInjected.Address(RVA = "0x3440780", Offset = "0x343F180", VA = "0x183440780", Slot = "0")]
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
				if ((IntPtr)(isDefaultChoice_ ? 1 : 0) == (IntPtr)typeof(FtueRewards).TypeHandle)
				{
					RepeatedField<FtueReward> repeatedField = rewards_;
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

		[Cpp2IlInjected.Token(Token = "0x60042A0")]
		[Cpp2IlInjected.Address(RVA = "0x34406E0", Offset = "0x343F0E0", VA = "0x1834406E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FtueRewards other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.isDefaultChoice_;
				if (isDefaultChoice_ == flag)
				{
					RepeatedField<FtueReward> repeatedField = rewards_;
					RepeatedField<FtueReward> repeatedField2 = other.rewards_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042A1")]
		[Cpp2IlInjected.Address(RVA = "0x78BEE0", Offset = "0x78A8E0", VA = "0x18078BEE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002a
			if (isDefaultChoice_)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)rewards_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60042A2")]
		[Cpp2IlInjected.Address(RVA = "0x3440B90", Offset = "0x343F590", VA = "0x183440B90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60042A3")]
		[Cpp2IlInjected.Address(RVA = "0x3440BF0", Offset = "0x343F5F0", VA = "0x183440BF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (isDefaultChoice_)
			{
				bool value = isDefaultChoice_;
				output.WriteBool(value);
			}
			RepeatedField<FtueReward> repeatedField = rewards_;
			FieldCodec<FtueReward> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60042A4")]
		[Cpp2IlInjected.Address(RVA = "0x3440480", Offset = "0x343EE80", VA = "0x183440480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			RepeatedField<FtueReward> repeatedField = rewards_;
			FieldCodec<FtueReward> repeated_rewards_codec = _repeated_rewards_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<FtueReward>)(repeatedField + num2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042A5")]
		[Cpp2IlInjected.Address(RVA = "0x3440A30", Offset = "0x343F430", VA = "0x183440A30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FtueRewards other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				bool flag = other.isDefaultChoice_;
				if (flag)
				{
					isDefaultChoice_ = flag;
				}
				RepeatedField<FtueReward> repeatedField = rewards_;
				RepeatedField<FtueReward> repeatedField2 = other.rewards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042A6")]
		[Cpp2IlInjected.Address(RVA = "0x3440930", Offset = "0x343F330", VA = "0x183440930", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (isDefaultChoice_ = input.ReadBool());
				}
				if (num == 18)
				{
					RepeatedField<FtueReward> repeatedField = rewards_;
					FieldCodec<FtueReward> repeated_rewards_codec = _repeated_rewards_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042A7")]
		[Cpp2IlInjected.Address(RVA = "0x3440860", Offset = "0x343F260", VA = "0x183440860", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = isDefaultChoice_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<FtueReward> repeatedField = rewards_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60042A8")]
		[Cpp2IlInjected.Address(RVA = "0x3440AC0", Offset = "0x343F4C0", VA = "0x183440AC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				isDefaultChoice_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60042A9")]
		[Cpp2IlInjected.Address(RVA = "0x3440540", Offset = "0x343EF40", VA = "0x183440540", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				isDefaultChoice_ = false;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<FtueReward> repeatedField = rewards_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042AA")]
		[Cpp2IlInjected.Address(RVA = "0x3440CE0", Offset = "0x343F6E0", VA = "0x183440CE0")]
		static FtueRewards()
		{
			Func<FtueRewards> func = default(Func<FtueRewards>);
			_parser = (MessageParser<FtueRewards>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<FtueReward> parser = FtueReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<FtueRewards>)(object)FieldCodec.ForMessage<FtueReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
