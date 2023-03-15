using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008E7")]
	public sealed class OnlineShopContentStatus : IMessage<OnlineShopContentStatus>, IMessage, IEquatable<OnlineShopContentStatus>, IDeepCloneable<OnlineShopContentStatus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002411")]
		private static readonly MessageParser<OnlineShopContentStatus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002412")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002413")]
		public const int IsNewFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002414")]
		private bool isNew_;

		[Cpp2IlInjected.Token(Token = "0x17000D16")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineShopContentStatus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004CFF")]
			[Cpp2IlInjected.Address(RVA = "0x13AAA20", Offset = "0x13A9420", VA = "0x1813AAA20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D17")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D00")]
			[Cpp2IlInjected.Address(RVA = "0x13AA950", Offset = "0x13A9350", VA = "0x1813AA950")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D18")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D01")]
			[Cpp2IlInjected.Address(RVA = "0x13AAA80", Offset = "0x13A9480", VA = "0x1813AAA80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D19")]
		[DebuggerNonUserCode]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x6004D05")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return isNew_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D06")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				isNew_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D02")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public OnlineShopContentStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D03")]
		[Cpp2IlInjected.Address(RVA = "0x13AA900", Offset = "0x13A9300", VA = "0x1813AA900")]
		[DebuggerNonUserCode]
		public OnlineShopContentStatus(OnlineShopContentStatus other)
		{
			bool flag = (isNew_ = other.isNew_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D04")]
		[Cpp2IlInjected.Address(RVA = "0x13AA380", Offset = "0x13A8D80", VA = "0x1813AA380", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineShopContentStatus Clone()
		{
			//Discarded unreachable code: IL_0029
			OnlineShopContentStatus onlineShopContentStatus = new OnlineShopContentStatus();
			bool flag = (onlineShopContentStatus.isNew_ = isNew_);
			UnknownFieldSet unknownFieldSet = (onlineShopContentStatus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return onlineShopContentStatus;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D07")]
		[Cpp2IlInjected.Address(RVA = "0x13AA430", Offset = "0x13A8E30", VA = "0x1813AA430", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(isNew_ ? 1 : 0) == (IntPtr)typeof(OnlineShopContentStatus).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D08")]
		[Cpp2IlInjected.Address(RVA = "0x13AA400", Offset = "0x13A8E00", VA = "0x1813AA400", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineShopContentStatus other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.isNew_;
				if (isNew_ == flag)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D09")]
		[Cpp2IlInjected.Address(RVA = "0x13AA570", Offset = "0x13A8F70", VA = "0x1813AA570", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (isNew_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0A")]
		[Cpp2IlInjected.Address(RVA = "0x13AA730", Offset = "0x13A9130", VA = "0x1813AA730", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0B")]
		[Cpp2IlInjected.Address(RVA = "0x13AA790", Offset = "0x13A9190", VA = "0x1813AA790", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (isNew_)
			{
				bool value = isNew_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0C")]
		[Cpp2IlInjected.Address(RVA = "0x13AA330", Offset = "0x13A8D30", VA = "0x1813AA330", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				bool flag = isNew_;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0D")]
		[Cpp2IlInjected.Address(RVA = "0x13AA660", Offset = "0x13A9060", VA = "0x1813AA660", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineShopContentStatus other)
		{
			if (other != null)
			{
				bool flag = other.isNew_;
				if (flag)
				{
					isNew_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0E")]
		[Cpp2IlInjected.Address(RVA = "0x13AA5E0", Offset = "0x13A8FE0", VA = "0x1813AA5E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (isNew_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0F")]
		[Cpp2IlInjected.Address(RVA = "0x13AA4C0", Offset = "0x13A8EC0", VA = "0x1813AA4C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = isNew_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D10")]
		[Cpp2IlInjected.Address(RVA = "0x13AA6B0", Offset = "0x13A90B0", VA = "0x1813AA6B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				isNew_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D11")]
		[Cpp2IlInjected.Address(RVA = "0x13AA370", Offset = "0x13A8D70", VA = "0x1813AA370", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				isNew_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D12")]
		[Cpp2IlInjected.Address(RVA = "0x13AA7F0", Offset = "0x13A91F0", VA = "0x1813AA7F0")]
		static OnlineShopContentStatus()
		{
			Func<OnlineShopContentStatus> func = default(Func<OnlineShopContentStatus>);
			_parser = (MessageParser<OnlineShopContentStatus>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
