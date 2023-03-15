using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000869")]
	public sealed class FriendshipBonus : IMessage<FriendshipBonus>, IMessage, IEquatable<FriendshipBonus>, IDeepCloneable<FriendshipBonus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002987")]
		private static readonly MessageParser<FriendshipBonus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002988")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002989")]
		public const int DialogueXPFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400298A")]
		private static readonly FieldCodec<int> _repeated_dialogueXP_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400298B")]
		private readonly RepeatedField<int> dialogueXP_;

		[Cpp2IlInjected.Token(Token = "0x170017A7")]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipBonus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005DFA")]
			[Cpp2IlInjected.Address(RVA = "0x34366F0", Offset = "0x34350F0", VA = "0x1834366F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DFB")]
			[Cpp2IlInjected.Address(RVA = "0x3436620", Offset = "0x3435020", VA = "0x183436620")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DFC")]
			[Cpp2IlInjected.Address(RVA = "0x3436750", Offset = "0x3435150", VA = "0x183436750", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017AA")]
		[DebuggerNonUserCode]
		public RepeatedField<int> DialogueXP
		{
			[Cpp2IlInjected.Token(Token = "0x6005E00")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return dialogueXP_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DFD")]
		[Cpp2IlInjected.Address(RVA = "0x34365A0", Offset = "0x3434FA0", VA = "0x1834365A0")]
		[DebuggerNonUserCode]
		public FriendshipBonus()
		{
			dialogueXP_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DFE")]
		[Cpp2IlInjected.Address(RVA = "0x3436510", Offset = "0x3434F10", VA = "0x183436510")]
		[DebuggerNonUserCode]
		public FriendshipBonus(FriendshipBonus other)
		{
			RepeatedField<int> repeatedField = (dialogueXP_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.dialogueXP_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DFF")]
		[Cpp2IlInjected.Address(RVA = "0x3435E30", Offset = "0x3434830", VA = "0x183435E30", Slot = "10")]
		[DebuggerNonUserCode]
		public FriendshipBonus Clone()
		{
			//Discarded unreachable code: IL_002e
			FriendshipBonus friendshipBonus = new FriendshipBonus();
			RepeatedField<int> repeatedField = (friendshipBonus.dialogueXP_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)dialogueXP_).Clone());
			UnknownFieldSet unknownFieldSet = (friendshipBonus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return friendshipBonus;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E01")]
		[Cpp2IlInjected.Address(RVA = "0x3435EF0", Offset = "0x34348F0", VA = "0x183435EF0", Slot = "0")]
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
				RepeatedField<int> repeatedField = dialogueXP_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E02")]
		[Cpp2IlInjected.Address(RVA = "0x3435FD0", Offset = "0x34349D0", VA = "0x183435FD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipBonus other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = dialogueXP_;
				RepeatedField<int> repeatedField2 = other.dialogueXP_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E03")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)dialogueXP_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E04")]
		[Cpp2IlInjected.Address(RVA = "0x34362B0", Offset = "0x3434CB0", VA = "0x1834362B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E05")]
		[Cpp2IlInjected.Address(RVA = "0x3436310", Offset = "0x3434D10", VA = "0x183436310", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = dialogueXP_;
			FieldCodec<int> repeated_dialogueXP_codec = _repeated_dialogueXP_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_dialogueXP_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E06")]
		[Cpp2IlInjected.Address(RVA = "0x3435D20", Offset = "0x3434720", VA = "0x183435D20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = dialogueXP_;
			FieldCodec<int> repeated_dialogueXP_codec = _repeated_dialogueXP_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_dialogueXP_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E07")]
		[Cpp2IlInjected.Address(RVA = "0x34360E0", Offset = "0x3434AE0", VA = "0x1834360E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipBonus other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = dialogueXP_;
				RepeatedField<int> repeatedField2 = other.dialogueXP_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E08")]
		[Cpp2IlInjected.Address(RVA = "0x3436160", Offset = "0x3434B60", VA = "0x183436160", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = dialogueXP_;
				FieldCodec<int> repeated_dialogueXP_codec = _repeated_dialogueXP_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_dialogueXP_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E09")]
		[Cpp2IlInjected.Address(RVA = "0x3436060", Offset = "0x3434A60", VA = "0x183436060", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = dialogueXP_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E0A")]
		[Cpp2IlInjected.Address(RVA = "0x3436250", Offset = "0x3434C50", VA = "0x183436250", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005E0B")]
		[Cpp2IlInjected.Address(RVA = "0x3435DD0", Offset = "0x34347D0", VA = "0x183435DD0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = dialogueXP_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E0C")]
		[Cpp2IlInjected.Address(RVA = "0x34363D0", Offset = "0x3434DD0", VA = "0x1834363D0")]
		static FriendshipBonus()
		{
			Func<FriendshipBonus> func = default(Func<FriendshipBonus>);
			_parser = (MessageParser<FriendshipBonus>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<FriendshipBonus>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
