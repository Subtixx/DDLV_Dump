using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class NoFatigue : IFatigue, IMessage<NoFatigue>, IMessage, IEquatable<NoFatigue>, IDeepCloneable<NoFatigue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly MessageParser<NoFatigue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[field: Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static NoFatigue Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x29F5930", Offset = "0x29F4330", VA = "0x1829F5930")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public static MessageParser<NoFatigue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x29F5A60", Offset = "0x29F4460", VA = "0x1829F5A60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x29F5990", Offset = "0x29F4390", VA = "0x1829F5990")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x29F5AC0", Offset = "0x29F44C0", VA = "0x1829F5AC0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
		public bool CanRefresh(DateTime lastRefresh, DateTime now)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x91C340", Offset = "0x91AD40", VA = "0x18091C340", Slot = "5")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			return now;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public NoFatigue()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public NoFatigue(NoFatigue other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x29F5610", Offset = "0x29F4010", VA = "0x1829F5610", Slot = "12")]
		[DebuggerNonUserCode]
		public NoFatigue Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			NoFatigue noFatigue = default(NoFatigue);
			noFatigue.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (noFatigue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return noFatigue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x29F5690", Offset = "0x29F4090", VA = "0x1829F5690", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(NoFatigue other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x29F5780", Offset = "0x29F4180", VA = "0x1829F5780", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(NoFatigue other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x29F5710", Offset = "0x29F4110", VA = "0x1829F5710", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x29F57E0", Offset = "0x29F41E0", VA = "0x1829F57E0")]
		static NoFatigue()
		{
			int fieldNumber = 0;
			NoFatigue CS_0024_003C_003E8__locals0 = default(NoFatigue);
			CS_0024_003C_003E8__locals0.ClearFieldValue(fieldNumber);
			Default = CS_0024_003C_003E8__locals0;
			Default = (NoFatigue)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new NoFatigue()));
			/*Error: Unexpected end of block*/;
		}
	}
}
