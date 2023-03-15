using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class UnlockRequirementReward : IMessage<UnlockRequirementReward>, IMessage, IEquatable<UnlockRequirementReward>, IDeepCloneable<UnlockRequirementReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private static readonly MessageParser<UnlockRequirementReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public const int MinPurchasedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int minPurchased_;

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[DebuggerNonUserCode]
		public static MessageParser<UnlockRequirementReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x3556E20", Offset = "0x3555820", VA = "0x183556E20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x3556D50", Offset = "0x3555750", VA = "0x183556D50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x3556E80", Offset = "0x3555880", VA = "0x183556E80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[DebuggerNonUserCode]
		public int MinPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minPurchased_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minPurchased_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UnlockRequirementReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public UnlockRequirementReward(UnlockRequirementReward other)
		{
			int num = (minPurchased_ = other.minPurchased_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x35569A0", Offset = "0x35553A0", VA = "0x1835569A0", Slot = "10")]
		[DebuggerNonUserCode]
		public UnlockRequirementReward Clone()
		{
			//Discarded unreachable code: IL_0029
			UnlockRequirementReward unlockRequirementReward = new UnlockRequirementReward();
			int num = (unlockRequirementReward.minPurchased_ = minPurchased_);
			UnknownFieldSet unknownFieldSet = (unlockRequirementReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return unlockRequirementReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3556A20", Offset = "0x3555420", VA = "0x183556A20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minPurchased_ == (IntPtr)typeof(UnlockRequirementReward).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnlockRequirementReward other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minPurchased_;
				if (minPurchased_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (minPurchased_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3556BE0", Offset = "0x35555E0", VA = "0x183556BE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (minPurchased_ != 0)
			{
				int value = minPurchased_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x3556900", Offset = "0x3555300", VA = "0x183556900", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = minPurchased_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnlockRequirementReward other)
		{
			if (other != null)
			{
				int num = other.minPurchased_;
				if (num != 0)
				{
					minPurchased_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (minPurchased_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3556AB0", Offset = "0x35554B0", VA = "0x183556AB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = minPurchased_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x3556B60", Offset = "0x3555560", VA = "0x183556B60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				minPurchased_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minPurchased_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x3556C40", Offset = "0x3555640", VA = "0x183556C40")]
		static UnlockRequirementReward()
		{
			Func<UnlockRequirementReward> func = default(Func<UnlockRequirementReward>);
			_parser = (MessageParser<UnlockRequirementReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
