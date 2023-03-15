using System;
using System.Diagnostics;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public sealed class StoreTypeGameUpgrade : IMessage<StoreTypeGameUpgrade>, IMessage, IEquatable<StoreTypeGameUpgrade>, IDeepCloneable<StoreTypeGameUpgrade>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private static readonly MessageParser<StoreTypeGameUpgrade> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreTypeGameUpgrade> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x25549E0", Offset = "0x25533E0", VA = "0x1825549E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x2554910", Offset = "0x2553310", VA = "0x182554910")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2554A40", Offset = "0x2553440", VA = "0x182554A40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StoreTypeGameUpgrade()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StoreTypeGameUpgrade(StoreTypeGameUpgrade other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2554590", Offset = "0x2552F90", VA = "0x182554590", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreTypeGameUpgrade Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StoreTypeGameUpgrade storeTypeGameUpgrade = default(StoreTypeGameUpgrade);
			storeTypeGameUpgrade.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (storeTypeGameUpgrade._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeTypeGameUpgrade;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2554610", Offset = "0x2553010", VA = "0x182554610", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreTypeGameUpgrade other)
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

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x25547A0", Offset = "0x25531A0", VA = "0x1825547A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreTypeGameUpgrade other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
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

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x25546E0", Offset = "0x25530E0", VA = "0x1825546E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2554750", Offset = "0x2553150", VA = "0x182554750")]
		public StoreGameUpgrade ToServerConfig()
		{
			return new StoreGameUpgrade();
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2554690", Offset = "0x2553090", VA = "0x182554690")]
		public static StoreTypeGameUpgrade FromServerConfig(StoreGameUpgrade gameUpgradeConfig)
		{
			int fieldNumber = 0;
			StoreTypeGameUpgrade storeTypeGameUpgrade = default(StoreTypeGameUpgrade);
			storeTypeGameUpgrade.ClearFieldValue(fieldNumber);
			return storeTypeGameUpgrade;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2554800", Offset = "0x2553200", VA = "0x182554800")]
		static StoreTypeGameUpgrade()
		{
			Func<StoreTypeGameUpgrade> func = default(Func<StoreTypeGameUpgrade>);
			_parser = (MessageParser<StoreTypeGameUpgrade>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
