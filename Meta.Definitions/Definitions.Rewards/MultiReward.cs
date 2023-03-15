using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000231")]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public sealed class MultiReward : IReward, IMessage<MultiReward>, IMessage, IEquatable<MultiReward>, IDeepCloneable<MultiReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40008F3")]
		private static readonly MessageParser<MultiReward> _parser = (MessageParser<MultiReward>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MultiReward()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008F4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40008F5")]
		public const int RewardsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40008F6")]
		private static readonly FieldCodec<AnyReward> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008F7")]
		private readonly RepeatedField<AnyReward> rewards_;

		[Cpp2IlInjected.Token(Token = "0x170004B6")]
		[DebuggerNonUserCode]
		public static MessageParser<MultiReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001537")]
			[Cpp2IlInjected.Address(RVA = "0x29F54A0", Offset = "0x29F3EA0", VA = "0x1829F54A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001538")]
			[Cpp2IlInjected.Address(RVA = "0x29F53D0", Offset = "0x29F3DD0", VA = "0x1829F53D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001539")]
			[Cpp2IlInjected.Address(RVA = "0x29F5500", Offset = "0x29F3F00", VA = "0x1829F5500", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x600153D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6001549")]
			[Cpp2IlInjected.Address(RVA = "0x29F5280", Offset = "0x29F3C80", VA = "0x1829F5280", Slot = "4")]
			get
			{
				RepeatedField<AnyReward> repeatedField = rewards_;
				Func<AnyReward, string> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
				if (_003C_003E9__29_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AnyReward x) => x.DebugDisplay);
				}
				IEnumerable<AnyReward> enumerable = (IEnumerable<AnyReward>)Enumerable.Select<AnyReward, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__29_);
				return string.Join("\n", (IEnumerable<>)enumerable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600153A")]
		[Cpp2IlInjected.Address(RVA = "0x29F5040", Offset = "0x29F3A40", VA = "0x1829F5040")]
		[DebuggerNonUserCode]
		public MultiReward()
		{
			rewards_ = (RepeatedField<AnyReward>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600153B")]
		[Cpp2IlInjected.Address(RVA = "0x29F4F40", Offset = "0x29F3940", VA = "0x1829F4F40")]
		[DebuggerNonUserCode]
		public MultiReward(MultiReward other)
		{
			rewards_ = (RepeatedField<AnyReward>)(object)new RepeatedField<T>();
			base._002Ector();
			RepeatedField<AnyReward> repeatedField = (rewards_ = (RepeatedField<AnyReward>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600153C")]
		[Cpp2IlInjected.Address(RVA = "0x29F4310", Offset = "0x29F2D10", VA = "0x1829F4310", Slot = "14")]
		[DebuggerNonUserCode]
		public MultiReward Clone()
		{
			//Discarded unreachable code: IL_003b
			MultiReward multiReward = new MultiReward();
			RepeatedField<AnyReward> repeatedField = (multiReward.rewards_ = (RepeatedField<AnyReward>)(object)new RepeatedField<T>());
			RepeatedField<AnyReward> repeatedField2 = (multiReward.rewards_ = (RepeatedField<AnyReward>)(object)((RepeatedField<T>)(object)rewards_).Clone());
			UnknownFieldSet unknownFieldSet = (multiReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return multiReward;
		}

		[Cpp2IlInjected.Token(Token = "0x600153E")]
		[Cpp2IlInjected.Address(RVA = "0x29F44F0", Offset = "0x29F2EF0", VA = "0x1829F44F0", Slot = "0")]
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
				RepeatedField<AnyReward> repeatedField = rewards_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600153F")]
		[Cpp2IlInjected.Address(RVA = "0x29F4460", Offset = "0x29F2E60", VA = "0x1829F4460", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(MultiReward other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<AnyReward> repeatedField = rewards_;
				RepeatedField<AnyReward> repeatedField2 = other.rewards_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001540")]
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

		[Cpp2IlInjected.Token(Token = "0x6001541")]
		[Cpp2IlInjected.Address(RVA = "0x29F4BF0", Offset = "0x29F35F0", VA = "0x1829F4BF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001542")]
		[Cpp2IlInjected.Address(RVA = "0x29F4CB0", Offset = "0x29F36B0", VA = "0x1829F4CB0", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<AnyReward> repeatedField = rewards_;
			FieldCodec<AnyReward> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001543")]
		[Cpp2IlInjected.Address(RVA = "0x29F4110", Offset = "0x29F2B10", VA = "0x1829F4110", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<AnyReward> repeatedField = rewards_;
			FieldCodec<AnyReward> repeated_rewards_codec = _repeated_rewards_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001544")]
		[Cpp2IlInjected.Address(RVA = "0x29F4A30", Offset = "0x29F3430", VA = "0x1829F4A30", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(MultiReward other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<AnyReward> repeatedField = rewards_;
				RepeatedField<AnyReward> repeatedField2 = other.rewards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001545")]
		[Cpp2IlInjected.Address(RVA = "0x29F4940", Offset = "0x29F3340", VA = "0x1829F4940", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<AnyReward> repeatedField = rewards_;
					FieldCodec<AnyReward> repeated_rewards_codec = _repeated_rewards_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001546")]
		[Cpp2IlInjected.Address(RVA = "0x29F45D0", Offset = "0x29F2FD0", VA = "0x1829F45D0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<AnyReward> repeatedField = rewards_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001547")]
		[Cpp2IlInjected.Address(RVA = "0x29F4B90", Offset = "0x29F3590", VA = "0x1829F4B90", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6001548")]
		[Cpp2IlInjected.Address(RVA = "0x29F42B0", Offset = "0x29F2CB0", VA = "0x1829F42B0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<AnyReward> repeatedField = rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154A")]
		[Cpp2IlInjected.Address(RVA = "0x29F50C0", Offset = "0x29F3AC0", VA = "0x1829F50C0")]
		public MultiReward(IEnumerable<IReward> rewards)
		{
			//Discarded unreachable code: IL_001c, IL_0022
			RepeatedField<AnyReward> repeatedField = (rewards_ = (RepeatedField<AnyReward>)(object)new RepeatedField<T>());
			base._002Ector();
			if (repeatedField != null)
			{
			}
			if (repeatedField == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154B")]
		[Cpp2IlInjected.Address(RVA = "0x29F41C0", Offset = "0x29F2BC0", VA = "0x1829F41C0", Slot = "5")]
		public bool CanGive(IRewardRecipient recipient)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<AnyReward> repeatedField = rewards_;
			Func<AnyReward, bool> func = (Func<AnyReward, bool>)(object)(Func<T, TResult>)delegate(AnyReward x)
			{
				//Discarded unreachable code: IL_000f
				IRewardRecipient recipient2 = recipient;
				return x.CanGive(recipient2);
			};
			return ((IEnumerable<>)(object)repeatedField).All<AnyReward>((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600154C")]
		[Cpp2IlInjected.Address(RVA = "0x29F4890", Offset = "0x29F3290", VA = "0x1829F4890")]
		public void Give(IRewardRecipient recipient, IProfile profile, IProfileEventDispatcher dispatcher, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600154D")]
		[Cpp2IlInjected.Address(RVA = "0x29F4740", Offset = "0x29F3140", VA = "0x1829F4740")]
		public void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
			//Discarded unreachable code: IL_000e
			int num = 0;
			RepeatedField<AnyReward> repeatedField = rewards_;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154E")]
		[Cpp2IlInjected.Address(RVA = "0x29F4650", Offset = "0x29F3050", VA = "0x1829F4650", Slot = "7")]
		public int GetGivenItems(MultiItemInstance rewards)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<AnyReward> repeatedField = rewards_;
			Func<AnyReward, int> func = (Func<AnyReward, int>)(object)(Func<T, TResult>)delegate(AnyReward x)
			{
				//Discarded unreachable code: IL_000f
				MultiItemInstance rewards2 = rewards;
				return x.GetGivenItems(rewards2);
			};
			return Enumerable.Sum<AnyReward>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600154F")]
		[Cpp2IlInjected.Address(RVA = "0x29F4AB0", Offset = "0x29F34B0", VA = "0x1829F4AB0")]
		public void MergedRewards(MultiReward moreRewards)
		{
			if (moreRewards != null)
			{
				RepeatedField<AnyReward> repeatedField = moreRewards.rewards_;
				Action<AnyReward> action = (Action<AnyReward>)(object)(Action<T>)delegate(AnyReward x)
				{
					//Discarded unreachable code: IL_000d
					((RepeatedField<T>)(object)rewards_).Add((T)x);
				};
				((RepeatedField<>)(object)repeatedField).ForEach<AnyReward>((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001550")]
		[Cpp2IlInjected.Address(RVA = "0x29F4D70", Offset = "0x29F3770", VA = "0x1829F4D70")]
		static MultiReward()
		{
			MessageParser<AnyReward> parser = AnyReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<MultiReward>)(object)FieldCodec.ForMessage<AnyReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001551")]
		[Cpp2IlInjected.Address(RVA = "0x29F4440", Offset = "0x29F2E40", VA = "0x1829F4440", Slot = "6")]
		void IReward.Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, Item? characterItem, bool canSendToInbox)
		{
		}
	}
}
