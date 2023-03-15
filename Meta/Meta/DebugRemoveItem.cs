using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200027B")]
	public sealed class DebugRemoveItem : IMessage<DebugRemoveItem>, IMessage, IEquatable<DebugRemoveItem>, IDeepCloneable<DebugRemoveItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200027C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200027D")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400080C")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400080D")]
				[OriginalName("NotDeveloper")]
				NotDeveloper,
				[Cpp2IlInjected.Token(Token = "0x400080E")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x400080F")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x200027E")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x4000811")]
				[OriginalName("Default")]
				Default,
				[Cpp2IlInjected.Token(Token = "0x4000812")]
				[OriginalName("BuyableOnly")]
				BuyableOnly,
				[Cpp2IlInjected.Token(Token = "0x4000813")]
				[OriginalName("All")]
				All
			}

			[Cpp2IlInjected.Token(Token = "0x200027F")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000814")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000815")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000816")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000817")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000818")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000819")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x400081A")]
				public const int TryConsummableFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400081B")]
				private bool tryConsummable_;

				[Cpp2IlInjected.Token(Token = "0x400081C")]
				public const int TypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400081D")]
				private Type type_;

				[Cpp2IlInjected.Token(Token = "0x17000490")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600195C")]
					[Cpp2IlInjected.Address(RVA = "0x211B900", Offset = "0x211A300", VA = "0x18211B900")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000491")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600195D")]
					[Cpp2IlInjected.Address(RVA = "0x211B680", Offset = "0x211A080", VA = "0x18211B680")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000492")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600195E")]
					[Cpp2IlInjected.Address(RVA = "0x211C5C0", Offset = "0x211AFC0", VA = "0x18211C5C0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000493")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001962")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001963")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000494")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6001964")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001965")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000495")]
				[DebuggerNonUserCode]
				public bool TryConsummable
				{
					[Cpp2IlInjected.Token(Token = "0x6001966")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6001967")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000496")]
				[DebuggerNonUserCode]
				public Type Type
				{
					[Cpp2IlInjected.Token(Token = "0x6001968")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(Type);
					}
					[Cpp2IlInjected.Token(Token = "0x6001969")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600195F")]
				[Cpp2IlInjected.Address(RVA = "0x211A9E0", Offset = "0x21193E0", VA = "0x18211A9E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001960")]
				[Cpp2IlInjected.Address(RVA = "0x211AD80", Offset = "0x2119780", VA = "0x18211AD80")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001961")]
				[Cpp2IlInjected.Address(RVA = "0x2115E00", Offset = "0x2114800", VA = "0x182115E00", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600196A")]
				[Cpp2IlInjected.Address(RVA = "0x2116DF0", Offset = "0x21157F0", VA = "0x182116DF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600196B")]
				[Cpp2IlInjected.Address(RVA = "0xAC9070", Offset = "0xAC7A70", VA = "0x180AC9070", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600196C")]
				[Cpp2IlInjected.Address(RVA = "0xAC9450", Offset = "0xAC7E50", VA = "0x180AC9450", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600196D")]
				[Cpp2IlInjected.Address(RVA = "0x2119140", Offset = "0x2117B40", VA = "0x182119140", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600196E")]
				[Cpp2IlInjected.Address(RVA = "0x21196B0", Offset = "0x21180B0", VA = "0x1821196B0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600196F")]
				[Cpp2IlInjected.Address(RVA = "0x21150D0", Offset = "0x2113AD0", VA = "0x1821150D0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001970")]
				[Cpp2IlInjected.Address(RVA = "0xAC9510", Offset = "0xAC7F10", VA = "0x180AC9510", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001971")]
				[Cpp2IlInjected.Address(RVA = "0xAC9700", Offset = "0xAC8100", VA = "0x180AC9700", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001972")]
				[Cpp2IlInjected.Address(RVA = "0x2117340", Offset = "0x2115D40", VA = "0x182117340", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001973")]
				[Cpp2IlInjected.Address(RVA = "0x2118970", Offset = "0x2117370", VA = "0x182118970", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001974")]
				[Cpp2IlInjected.Address(RVA = "0xAC8AC0", Offset = "0xAC74C0", VA = "0x180AC8AC0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001975")]
				[Cpp2IlInjected.Address(RVA = "0x2119200", Offset = "0x2117C00", VA = "0x182119200", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000281")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400081F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000820")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000821")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000822")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000823")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000824")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000497")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600197A")]
					[Cpp2IlInjected.Address(RVA = "0x2129940", Offset = "0x2128340", VA = "0x182129940")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000498")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600197B")]
					[Cpp2IlInjected.Address(RVA = "0x21291A0", Offset = "0x2127BA0", VA = "0x1821291A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000499")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600197C")]
					[Cpp2IlInjected.Address(RVA = "0x212A0C0", Offset = "0x2128AC0", VA = "0x18212A0C0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700049A")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001980")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001981")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700049B")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001982")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001983")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700049C")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600198F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001990")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600197D")]
				[Cpp2IlInjected.Address(RVA = "0x2128CA0", Offset = "0x21276A0", VA = "0x182128CA0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600197E")]
				[Cpp2IlInjected.Address(RVA = "0x2128900", Offset = "0x2127300", VA = "0x182128900")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600197F")]
				[Cpp2IlInjected.Address(RVA = "0x21219D0", Offset = "0x21203D0", VA = "0x1821219D0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001984")]
				[Cpp2IlInjected.Address(RVA = "0x2122520", Offset = "0x2120F20", VA = "0x182122520", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001985")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001986")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001987")]
				[Cpp2IlInjected.Address(RVA = "0x2126520", Offset = "0x2124F20", VA = "0x182126520", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001988")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001989")]
				[Cpp2IlInjected.Address(RVA = "0x2120280", Offset = "0x211EC80", VA = "0x182120280", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600198A")]
				[Cpp2IlInjected.Address(RVA = "0x2124790", Offset = "0x2123190", VA = "0x182124790", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600198B")]
				[Cpp2IlInjected.Address(RVA = "0x2123A10", Offset = "0x2122410", VA = "0x182123A10", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600198C")]
				[Cpp2IlInjected.Address(RVA = "0x21229F0", Offset = "0x21213F0", VA = "0x1821229F0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600198D")]
				[Cpp2IlInjected.Address(RVA = "0x2125B10", Offset = "0x2124510", VA = "0x182125B10", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600198E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001991")]
				[Cpp2IlInjected.Address(RVA = "0x211E310", Offset = "0x211CD10", VA = "0x18211E310", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private static readonly MessageParser<DebugRemoveItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugRemoveItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600194A")]
			[Cpp2IlInjected.Address(RVA = "0x18CC7A0", Offset = "0x18CB1A0", VA = "0x1818CC7A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600194B")]
			[Cpp2IlInjected.Address(RVA = "0x18CC6D0", Offset = "0x18CB0D0", VA = "0x1818CC6D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600194C")]
			[Cpp2IlInjected.Address(RVA = "0x18CC800", Offset = "0x18CB200", VA = "0x1818CC800", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600194D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugRemoveItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600194E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugRemoveItem(DebugRemoveItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600194F")]
		[Cpp2IlInjected.Address(RVA = "0x18CC3F0", Offset = "0x18CADF0", VA = "0x1818CC3F0", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugRemoveItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugRemoveItem debugRemoveItem = default(DebugRemoveItem);
			debugRemoveItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugRemoveItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugRemoveItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6001950")]
		[Cpp2IlInjected.Address(RVA = "0x18CC470", Offset = "0x18CAE70", VA = "0x1818CC470", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001951")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugRemoveItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6001952")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001953")]
		[Cpp2IlInjected.Address(RVA = "0x18CC560", Offset = "0x18CAF60", VA = "0x1818CC560", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001954")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001955")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001956")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugRemoveItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001957")]
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

		[Cpp2IlInjected.Token(Token = "0x6001958")]
		[Cpp2IlInjected.Address(RVA = "0x18CC4F0", Offset = "0x18CAEF0", VA = "0x1818CC4F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001959")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600195A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600195B")]
		[Cpp2IlInjected.Address(RVA = "0x18CC5C0", Offset = "0x18CAFC0", VA = "0x1818CC5C0")]
		static DebugRemoveItem()
		{
			Func<DebugRemoveItem> func = default(Func<DebugRemoveItem>);
			_parser = (MessageParser<DebugRemoveItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
