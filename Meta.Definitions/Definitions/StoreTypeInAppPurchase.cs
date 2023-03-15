using System;
using System.Diagnostics;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class StoreTypeInAppPurchase : IMessage<StoreTypeInAppPurchase>, IMessage, IEquatable<StoreTypeInAppPurchase>, IDeepCloneable<StoreTypeInAppPurchase>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly MessageParser<StoreTypeInAppPurchase> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreTypeInAppPurchase> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2554FA0", Offset = "0x25539A0", VA = "0x182554FA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0x2554ED0", Offset = "0x25538D0", VA = "0x182554ED0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x2555000", Offset = "0x2553A00", VA = "0x182555000", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StoreTypeInAppPurchase()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StoreTypeInAppPurchase(StoreTypeInAppPurchase other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2554B50", Offset = "0x2553550", VA = "0x182554B50", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreTypeInAppPurchase Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StoreTypeInAppPurchase storeTypeInAppPurchase = default(StoreTypeInAppPurchase);
			storeTypeInAppPurchase.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (storeTypeInAppPurchase._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeTypeInAppPurchase;
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2554BD0", Offset = "0x25535D0", VA = "0x182554BD0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreTypeInAppPurchase other)
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

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2554D60", Offset = "0x2553760", VA = "0x182554D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreTypeInAppPurchase other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
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

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2554CA0", Offset = "0x25536A0", VA = "0x182554CA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2554D10", Offset = "0x2553710", VA = "0x182554D10")]
		public StoreInAppPurchase ToServerConfig()
		{
			return new StoreInAppPurchase();
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2554C50", Offset = "0x2553650", VA = "0x182554C50")]
		public static StoreTypeInAppPurchase FromServerConfig(StoreInAppPurchase iapPurchaseConfig)
		{
			int fieldNumber = 0;
			StoreTypeInAppPurchase storeTypeInAppPurchase = default(StoreTypeInAppPurchase);
			storeTypeInAppPurchase.ClearFieldValue(fieldNumber);
			return storeTypeInAppPurchase;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2554DC0", Offset = "0x25537C0", VA = "0x182554DC0")]
		static StoreTypeInAppPurchase()
		{
			Func<StoreTypeInAppPurchase> func = default(Func<StoreTypeInAppPurchase>);
			_parser = (MessageParser<StoreTypeInAppPurchase>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
