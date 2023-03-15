using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000859")]
	public sealed class XpWeight : IMessage<XpWeight>, IMessage, IEquatable<XpWeight>, IDeepCloneable<XpWeight>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400294F")]
		private static readonly MessageParser<XpWeight> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002950")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002951")]
		public const int WeightFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002952")]
		private int weight_;

		[Cpp2IlInjected.Token(Token = "0x17001786")]
		[DebuggerNonUserCode]
		public static MessageParser<XpWeight> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005D4E")]
			[Cpp2IlInjected.Address(RVA = "0x17D3260", Offset = "0x17D1C60", VA = "0x1817D3260")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001787")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D4F")]
			[Cpp2IlInjected.Address(RVA = "0x17D3190", Offset = "0x17D1B90", VA = "0x1817D3190")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001788")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D50")]
			[Cpp2IlInjected.Address(RVA = "0x17D32C0", Offset = "0x17D1CC0", VA = "0x1817D32C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001789")]
		[DebuggerNonUserCode]
		public int Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6005D55")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return weight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D56")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				weight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D4D")]
		[Cpp2IlInjected.Address(RVA = "0x17D2CD0", Offset = "0x17D16D0", VA = "0x1817D2CD0")]
		public int GetAmount(XpRewardTable xpRewardTable, int maxLevelXP)
		{
			int num = weight_;
			ulong num2 = num2 + num2;
			RepeatedField<XpWeight> weights_ = xpRewardTable.weights_;
			Func<XpWeight, int> _003C_003E9__2_ = XpRewardTable._003C_003Ec._003C_003E9__2_0;
			if (_003C_003E9__2_ == null)
			{
				XpRewardTable._003C_003Ec._003C_003E9 = (XpRewardTable._003C_003Ec)(object)(Func<T, TResult>)((XpWeight x) => x.weight_);
			}
			int num3 = Enumerable.Sum<XpWeight>((IEnumerable<>)(object)weights_, (Func<, >)(object)_003C_003E9__2_);
			ulong num4 = num4 + num4;
			num4 += num4;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D51")]
		[Cpp2IlInjected.Address(RVA = "0x17D3170", Offset = "0x17D1B70", VA = "0x1817D3170")]
		[DebuggerNonUserCode]
		public XpWeight()
		{
			//IL_000f: Expected I4, but got I8
			weight_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D52")]
		[Cpp2IlInjected.Address(RVA = "0x17D2F10", Offset = "0x17D1910", VA = "0x1817D2F10")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			weight_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D53")]
		[Cpp2IlInjected.Address(RVA = "0x17D3110", Offset = "0x17D1B10", VA = "0x1817D3110")]
		[DebuggerNonUserCode]
		public XpWeight(XpWeight other)
		{
			//IL_000f: Expected I4, but got I8
			weight_ = 1;
			int num = (weight_ = other.weight_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D54")]
		[Cpp2IlInjected.Address(RVA = "0x17D2BB0", Offset = "0x17D15B0", VA = "0x1817D2BB0", Slot = "10")]
		[DebuggerNonUserCode]
		public XpWeight Clone()
		{
			//Discarded unreachable code: IL_0032
			//IL_000f: Expected I4, but got I8
			XpWeight xpWeight = new XpWeight();
			xpWeight.weight_ = 1;
			int num = (xpWeight.weight_ = weight_);
			UnknownFieldSet unknownFieldSet = (xpWeight._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return xpWeight;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D57")]
		[Cpp2IlInjected.Address(RVA = "0x17D2C40", Offset = "0x17D1640", VA = "0x1817D2C40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)weight_ == (IntPtr)typeof(XpWeight).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D58")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(XpWeight other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.weight_;
				if (weight_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D59")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (weight_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D5A")]
		[Cpp2IlInjected.Address(RVA = "0x17D2FA0", Offset = "0x17D19A0", VA = "0x1817D2FA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D5B")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (weight_ != 0)
			{
				int value = weight_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D5C")]
		[Cpp2IlInjected.Address(RVA = "0x17D2B10", Offset = "0x17D1510", VA = "0x1817D2B10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = weight_;
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

		[Cpp2IlInjected.Token(Token = "0x6005D5D")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(XpWeight other)
		{
			if (other != null)
			{
				int num = other.weight_;
				if (num != 0)
				{
					weight_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D5E")]
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
					int num2 = (weight_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D5F")]
		[Cpp2IlInjected.Address(RVA = "0x17D2E60", Offset = "0x17D1860", VA = "0x1817D2E60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = weight_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D60")]
		[Cpp2IlInjected.Address(RVA = "0x17D2F20", Offset = "0x17D1920", VA = "0x1817D2F20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				weight_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D61")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				weight_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D62")]
		[Cpp2IlInjected.Address(RVA = "0x17D3000", Offset = "0x17D1A00", VA = "0x1817D3000")]
		static XpWeight()
		{
			Func<XpWeight> func = default(Func<XpWeight>);
			_parser = (MessageParser<XpWeight>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
