using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Rewards;
using Definitions.Shops;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000569")]
	public sealed class BuyOffline : IMessage<BuyOffline>, IMessage, IEquatable<BuyOffline>, IDeepCloneable<BuyOffline>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200056A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200056B")]
			public sealed class Request : TransactionValidator<CRMBuyResult>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001092")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001093")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001094")]
				public const int ProductIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001095")]
				private string productID_;

				[Cpp2IlInjected.Token(Token = "0x4001096")]
				public const int PriceFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4001097")]
				private static readonly FieldCodec<CurrencyCost> _repeated_price_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001098")]
				private readonly RepeatedField<CurrencyCost> price_;

				[Cpp2IlInjected.Token(Token = "0x4001099")]
				public const int RewardsFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400109A")]
				private MultiReward rewards_;

				[Cpp2IlInjected.Token(Token = "0x400109B")]
				public const int GachaIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400109C")]
				private string gachaId_;

				[Cpp2IlInjected.Token(Token = "0x170009A1")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003458")]
					[Cpp2IlInjected.Address(RVA = "0x272B370", Offset = "0x2729D70", VA = "0x18272B370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003459")]
					[Cpp2IlInjected.Address(RVA = "0x272AF90", Offset = "0x2729990", VA = "0x18272AF90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600345A")]
					[Cpp2IlInjected.Address(RVA = "0x272B6D0", Offset = "0x272A0D0", VA = "0x18272B6D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A4")]
				[DebuggerNonUserCode]
				public string ProductID
				{
					[Cpp2IlInjected.Token(Token = "0x600345E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600345F")]
					[Cpp2IlInjected.Address(RVA = "0x272C0F0", Offset = "0x272AAF0", VA = "0x18272C0F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A5")]
				[DebuggerNonUserCode]
				public RepeatedField<CurrencyCost> Price
				{
					[Cpp2IlInjected.Token(Token = "0x6003460")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A6")]
				[DebuggerNonUserCode]
				public MultiReward Rewards
				{
					[Cpp2IlInjected.Token(Token = "0x6003461")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003462")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A7")]
				[DebuggerNonUserCode]
				public string GachaId
				{
					[Cpp2IlInjected.Token(Token = "0x6003463")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003464")]
					[Cpp2IlInjected.Address(RVA = "0x272BFA0", Offset = "0x272A9A0", VA = "0x18272BFA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600345B")]
				[Cpp2IlInjected.Address(RVA = "0x272AC50", Offset = "0x2729650", VA = "0x18272AC50")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600345C")]
				[Cpp2IlInjected.Address(RVA = "0x272AAC0", Offset = "0x27294C0", VA = "0x18272AAC0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600345D")]
				[Cpp2IlInjected.Address(RVA = "0x2725130", Offset = "0x2723B30", VA = "0x182725130", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003465")]
				[Cpp2IlInjected.Address(RVA = "0x2725CA0", Offset = "0x27246A0", VA = "0x182725CA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003466")]
				[Cpp2IlInjected.Address(RVA = "0x2725EF0", Offset = "0x27248F0", VA = "0x182725EF0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003467")]
				[Cpp2IlInjected.Address(RVA = "0x2726BE0", Offset = "0x27255E0", VA = "0x182726BE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003468")]
				[Cpp2IlInjected.Address(RVA = "0x2728440", Offset = "0x2726E40", VA = "0x182728440", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003469")]
				[Cpp2IlInjected.Address(RVA = "0x27297E0", Offset = "0x27281E0", VA = "0x1827297E0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600346A")]
				[Cpp2IlInjected.Address(RVA = "0x2724510", Offset = "0x2722F10", VA = "0x182724510", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600346B")]
				[Cpp2IlInjected.Address(RVA = "0x2726E00", Offset = "0x2725800", VA = "0x182726E00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600346C")]
				[Cpp2IlInjected.Address(RVA = "0x27270C0", Offset = "0x2725AC0", VA = "0x1827270C0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600346D")]
				[Cpp2IlInjected.Address(RVA = "0x2726850", Offset = "0x2725250", VA = "0x182726850", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600346E")]
				[Cpp2IlInjected.Address(RVA = "0x2727C60", Offset = "0x2726660", VA = "0x182727C60", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600346F")]
				[Cpp2IlInjected.Address(RVA = "0x2724FB0", Offset = "0x27239B0", VA = "0x182724FB0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003470")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
				protected override CRMBuyResult ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(CRMBuyResult);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200056D")]
			public sealed class Response : TransactionAction<CRMBuyResult>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400109E")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400109F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40010A0")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40010A1")]
				private CRMBuyResult result_;

				[Cpp2IlInjected.Token(Token = "0x40010A2")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40010A3")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170009A8")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003475")]
					[Cpp2IlInjected.Address(RVA = "0x2735C90", Offset = "0x2734690", VA = "0x182735C90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009A9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003476")]
					[Cpp2IlInjected.Address(RVA = "0x27359B0", Offset = "0x27343B0", VA = "0x1827359B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009AA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003477")]
					[Cpp2IlInjected.Address(RVA = "0x2735FF0", Offset = "0x27349F0", VA = "0x182735FF0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009AB")]
				[DebuggerNonUserCode]
				public CRMBuyResult Result
				{
					[Cpp2IlInjected.Token(Token = "0x600347B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(CRMBuyResult);
					}
					[Cpp2IlInjected.Token(Token = "0x600347C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009AC")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600347D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600347E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009AD")]
				protected override CRMBuyResult MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600348A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(CRMBuyResult);
					}
					[Cpp2IlInjected.Token(Token = "0x600348B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003478")]
				[Cpp2IlInjected.Address(RVA = "0x2734DF0", Offset = "0x27337F0", VA = "0x182734DF0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003479")]
				[Cpp2IlInjected.Address(RVA = "0x2734F90", Offset = "0x2733990", VA = "0x182734F90")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600347A")]
				[Cpp2IlInjected.Address(RVA = "0x272F4C0", Offset = "0x272DEC0", VA = "0x18272F4C0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600347F")]
				[Cpp2IlInjected.Address(RVA = "0x27305E0", Offset = "0x272EFE0", VA = "0x1827305E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003480")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003481")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003482")]
				[Cpp2IlInjected.Address(RVA = "0x27337E0", Offset = "0x27321E0", VA = "0x1827337E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003483")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003484")]
				[Cpp2IlInjected.Address(RVA = "0x272EBC0", Offset = "0x272D5C0", VA = "0x18272EBC0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003485")]
				[Cpp2IlInjected.Address(RVA = "0x2731F40", Offset = "0x2730940", VA = "0x182731F40", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003486")]
				[Cpp2IlInjected.Address(RVA = "0x2732120", Offset = "0x2730B20", VA = "0x182732120", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003487")]
				[Cpp2IlInjected.Address(RVA = "0x2730A60", Offset = "0x272F460", VA = "0x182730A60", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003488")]
				[Cpp2IlInjected.Address(RVA = "0x2733130", Offset = "0x2731B30", VA = "0x182733130", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003489")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600348C")]
				[Cpp2IlInjected.Address(RVA = "0x272C7E0", Offset = "0x272B1E0", VA = "0x18272C7E0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001090")]
		private static readonly MessageParser<BuyOffline> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001091")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700099E")]
		[DebuggerNonUserCode]
		public static MessageParser<BuyOffline> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003446")]
			[Cpp2IlInjected.Address(RVA = "0x715530", Offset = "0x713F30", VA = "0x180715530")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700099F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003447")]
			[Cpp2IlInjected.Address(RVA = "0x715460", Offset = "0x713E60", VA = "0x180715460")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009A0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003448")]
			[Cpp2IlInjected.Address(RVA = "0x715590", Offset = "0x713F90", VA = "0x180715590", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003449")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BuyOffline()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600344A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public BuyOffline(BuyOffline other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600344B")]
		[Cpp2IlInjected.Address(RVA = "0x715180", Offset = "0x713B80", VA = "0x180715180", Slot = "10")]
		[DebuggerNonUserCode]
		public BuyOffline Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			BuyOffline buyOffline = default(BuyOffline);
			buyOffline.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (buyOffline._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buyOffline;
		}

		[Cpp2IlInjected.Token(Token = "0x600344C")]
		[Cpp2IlInjected.Address(RVA = "0x715200", Offset = "0x713C00", VA = "0x180715200", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600344D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuyOffline other)
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

		[Cpp2IlInjected.Token(Token = "0x600344E")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600344F")]
		[Cpp2IlInjected.Address(RVA = "0x7152F0", Offset = "0x713CF0", VA = "0x1807152F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003450")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003451")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003452")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuyOffline other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003453")]
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

		[Cpp2IlInjected.Token(Token = "0x6003454")]
		[Cpp2IlInjected.Address(RVA = "0x715280", Offset = "0x713C80", VA = "0x180715280", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003455")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003456")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003457")]
		[Cpp2IlInjected.Address(RVA = "0x715350", Offset = "0x713D50", VA = "0x180715350")]
		static BuyOffline()
		{
			Func<BuyOffline> func = default(Func<BuyOffline>);
			_parser = (MessageParser<BuyOffline>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
