using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Store;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000492")]
	public sealed class BuyDeliverySystem : IMessage<BuyDeliverySystem>, IMessage, IEquatable<BuyDeliverySystem>, IDeepCloneable<BuyDeliverySystem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000493")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000494")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000E3A")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4000E3B")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency = 1,
				[Cpp2IlInjected.Token(Token = "0x4000E3C")]
				[OriginalName("InvalidItem")]
				InvalidItem = 2,
				[Cpp2IlInjected.Token(Token = "0x4000E3D")]
				[OriginalName("NoPriceForItem")]
				NoPriceForItem = 3,
				[Cpp2IlInjected.Token(Token = "0x4000E3E")]
				[OriginalName("CantBuyItem")]
				CantBuyItem = 5,
				[Cpp2IlInjected.Token(Token = "0x4000E3F")]
				[OriginalName("OverLimit")]
				OverLimit = 6,
				[Cpp2IlInjected.Token(Token = "0x4000E40")]
				[OriginalName("CannotAddItem")]
				CannotAddItem = 7,
				[Cpp2IlInjected.Token(Token = "0x4000E41")]
				[OriginalName("StoreDataBaseError")]
				StoreDataBaseError = 8
			}

			[Cpp2IlInjected.Token(Token = "0x2000495")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E42")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E43")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E44")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E45")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000E46")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000E47")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x1700082B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002C91")]
					[Cpp2IlInjected.Address(RVA = "0x272B4F0", Offset = "0x2729EF0", VA = "0x18272B4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700082C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C92")]
					[Cpp2IlInjected.Address(RVA = "0x272AE90", Offset = "0x2729890", VA = "0x18272AE90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700082D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C93")]
					[Cpp2IlInjected.Address(RVA = "0x272BD90", Offset = "0x272A790", VA = "0x18272BD90", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700082E")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002C97")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C98")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700082F")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6002C99")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C9A")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002C94")]
				[Cpp2IlInjected.Address(RVA = "0x272A550", Offset = "0x2728F50", VA = "0x18272A550")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C95")]
				[Cpp2IlInjected.Address(RVA = "0x272AA40", Offset = "0x2729440", VA = "0x18272AA40")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C96")]
				[Cpp2IlInjected.Address(RVA = "0x2725410", Offset = "0x2723E10", VA = "0x182725410", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C9B")]
				[Cpp2IlInjected.Address(RVA = "0x2725E60", Offset = "0x2724860", VA = "0x182725E60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C9C")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C9D")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C9E")]
				[Cpp2IlInjected.Address(RVA = "0x27282C0", Offset = "0x2726CC0", VA = "0x1827282C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C9F")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA0")]
				[Cpp2IlInjected.Address(RVA = "0x2724A30", Offset = "0x2723430", VA = "0x182724A30", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA1")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA2")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA3")]
				[Cpp2IlInjected.Address(RVA = "0x2726380", Offset = "0x2724D80", VA = "0x182726380", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA4")]
				[Cpp2IlInjected.Address(RVA = "0x2727DD0", Offset = "0x27267D0", VA = "0x182727DD0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA5")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CA6")]
				[Cpp2IlInjected.Address(RVA = "0x2729000", Offset = "0x2727A00", VA = "0x182729000", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000497")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E49")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E4A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E4B")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E4C")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000E4D")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E4E")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000830")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002CAB")]
					[Cpp2IlInjected.Address(RVA = "0x2735E10", Offset = "0x2734810", VA = "0x182735E10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000831")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002CAC")]
					[Cpp2IlInjected.Address(RVA = "0x2735BB0", Offset = "0x27345B0", VA = "0x182735BB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000832")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002CAD")]
					[Cpp2IlInjected.Address(RVA = "0x27360B0", Offset = "0x2734AB0", VA = "0x1827360B0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000833")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002CB1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002CB2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000834")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002CB3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002CB4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000835")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002CC0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002CC1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002CAE")]
				[Cpp2IlInjected.Address(RVA = "0x2734E30", Offset = "0x2733830", VA = "0x182734E30")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CAF")]
				[Cpp2IlInjected.Address(RVA = "0x2734BD0", Offset = "0x27335D0", VA = "0x182734BD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CB0")]
				[Cpp2IlInjected.Address(RVA = "0x272F680", Offset = "0x272E080", VA = "0x18272F680", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CB5")]
				[Cpp2IlInjected.Address(RVA = "0x27301A0", Offset = "0x272EBA0", VA = "0x1827301A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CB6")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CB7")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CB8")]
				[Cpp2IlInjected.Address(RVA = "0x27339C0", Offset = "0x27323C0", VA = "0x1827339C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CB9")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CBA")]
				[Cpp2IlInjected.Address(RVA = "0x272ED60", Offset = "0x272D760", VA = "0x18272ED60", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CBB")]
				[Cpp2IlInjected.Address(RVA = "0x27327B0", Offset = "0x27311B0", VA = "0x1827327B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CBC")]
				[Cpp2IlInjected.Address(RVA = "0x27328E0", Offset = "0x27312E0", VA = "0x1827328E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CBD")]
				[Cpp2IlInjected.Address(RVA = "0x27308C0", Offset = "0x272F2C0", VA = "0x1827308C0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CBE")]
				[Cpp2IlInjected.Address(RVA = "0x2733200", Offset = "0x2731C00", VA = "0x182733200", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CBF")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CC2")]
				[Cpp2IlInjected.Address(RVA = "0x272CF20", Offset = "0x272B920", VA = "0x18272CF20", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000E37")]
		private static readonly MessageParser<BuyDeliverySystem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E38")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000828")]
		[DebuggerNonUserCode]
		public static MessageParser<BuyDeliverySystem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7E")]
			[Cpp2IlInjected.Address(RVA = "0x7145D0", Offset = "0x712FD0", VA = "0x1807145D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000829")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7F")]
			[Cpp2IlInjected.Address(RVA = "0x714500", Offset = "0x712F00", VA = "0x180714500")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C80")]
			[Cpp2IlInjected.Address(RVA = "0x714630", Offset = "0x713030", VA = "0x180714630", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C81")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BuyDeliverySystem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C82")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public BuyDeliverySystem(BuyDeliverySystem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C83")]
		[Cpp2IlInjected.Address(RVA = "0x713FD0", Offset = "0x7129D0", VA = "0x180713FD0", Slot = "10")]
		[DebuggerNonUserCode]
		public BuyDeliverySystem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			BuyDeliverySystem buyDeliverySystem = default(BuyDeliverySystem);
			buyDeliverySystem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (buyDeliverySystem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buyDeliverySystem;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C84")]
		[Cpp2IlInjected.Address(RVA = "0x714050", Offset = "0x712A50", VA = "0x180714050", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C85")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuyDeliverySystem other)
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

		[Cpp2IlInjected.Token(Token = "0x6002C86")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C87")]
		[Cpp2IlInjected.Address(RVA = "0x714390", Offset = "0x712D90", VA = "0x180714390", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C88")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C89")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuyDeliverySystem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8B")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C8C")]
		[Cpp2IlInjected.Address(RVA = "0x7140D0", Offset = "0x712AD0", VA = "0x1807140D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8F")]
		[Cpp2IlInjected.Address(RVA = "0x714140", Offset = "0x712B40", VA = "0x180714140")]
		private static bool IsItemAvailableForDelivery(Item item, Profile profile)
		{
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			ItemType itemType = default(ItemType);
			switch (itemType)
			{
			case ItemType.Furniture:
			{
				List<(Item, int?)> furnitureItemsInDeliverySystem = (List<(Item, int?)>)(object)DeliverySystemExtensions.GetFurnitureItemsInDeliverySystem(ProtoDatabase.Instance.Get<StoreData>("Store_Default"), profile);
				Predicate<(Item, int?)> predicate = (Predicate<(Item, int?)>)(object)(Predicate<T>)(((Item item, int? amount) x) => (byte)(int)typeof(Item).TypeHandle != 0);
				return ((List<T>)(object)furnitureItemsInDeliverySystem).FindIndex((Predicate<>)(object)predicate) != -1;
			}
			default:
			{
				int num = 0;
				break;
			}
			case ItemType.Clothing:
				break;
			}
			StoreData storeData = default(StoreData);
			List<Item> clothingItemsInDeliverySystem = (List<Item>)(object)DeliverySystemExtensions.GetClothingItemsInDeliverySystem(storeData, profile);
			Item item3 = item2;
			bool flag = ((List<T>)(object)clothingItemsInDeliverySystem).Contains((T)item3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C90")]
		[Cpp2IlInjected.Address(RVA = "0x7143F0", Offset = "0x712DF0", VA = "0x1807143F0")]
		static BuyDeliverySystem()
		{
			Func<BuyDeliverySystem> func = default(Func<BuyDeliverySystem>);
			_parser = (MessageParser<BuyDeliverySystem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
