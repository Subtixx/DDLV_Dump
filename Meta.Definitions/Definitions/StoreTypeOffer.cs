using System;
using System.Diagnostics;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class StoreTypeOffer : IMessage<StoreTypeOffer>, IMessage, IEquatable<StoreTypeOffer>, IDeepCloneable<StoreTypeOffer>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly MessageParser<StoreTypeOffer> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreTypeOffer> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2555560", Offset = "0x2553F60", VA = "0x182555560")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2555490", Offset = "0x2553E90", VA = "0x182555490")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x25555C0", Offset = "0x2553FC0", VA = "0x1825555C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StoreTypeOffer()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StoreTypeOffer(StoreTypeOffer other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2555110", Offset = "0x2553B10", VA = "0x182555110", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreTypeOffer Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StoreTypeOffer storeTypeOffer = default(StoreTypeOffer);
			storeTypeOffer.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (storeTypeOffer._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeTypeOffer;
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2555190", Offset = "0x2553B90", VA = "0x182555190", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreTypeOffer other)
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

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2555320", Offset = "0x2553D20", VA = "0x182555320", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreTypeOffer other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x2555260", Offset = "0x2553C60", VA = "0x182555260", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x25552D0", Offset = "0x2553CD0", VA = "0x1825552D0")]
		public StoreOffer ToServerConfig()
		{
			return new StoreOffer();
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x2555210", Offset = "0x2553C10", VA = "0x182555210")]
		public static StoreTypeOffer FromServerConfig(StoreOffer offerConfig)
		{
			int fieldNumber = 0;
			StoreTypeOffer storeTypeOffer = default(StoreTypeOffer);
			storeTypeOffer.ClearFieldValue(fieldNumber);
			return storeTypeOffer;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2555380", Offset = "0x2553D80", VA = "0x182555380")]
		static StoreTypeOffer()
		{
			Func<StoreTypeOffer> func = default(Func<StoreTypeOffer>);
			_parser = (MessageParser<StoreTypeOffer>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
