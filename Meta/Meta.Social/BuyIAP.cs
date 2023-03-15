using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Definitions.Shops;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BFA")]
	public sealed class BuyIAP : IMessage<BuyIAP>, IMessage, IEquatable<BuyIAP>, IDeepCloneable<BuyIAP>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BFB")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000BFC")]
			public sealed class Request : TransactionValidator<CRMBuyResult>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002E83")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002E84")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002E85")]
				public const int ProductIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002E86")]
				private string productID_;

				[Cpp2IlInjected.Token(Token = "0x4002E87")]
				public const int PriceFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002E88")]
				private string price_;

				[Cpp2IlInjected.Token(Token = "0x4002E89")]
				public const int CurrencyFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002E8A")]
				private string currency_;

				[Cpp2IlInjected.Token(Token = "0x4002E8B")]
				public const int ReceiptFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002E8C")]
				private string receipt_;

				[Cpp2IlInjected.Token(Token = "0x4002E8D")]
				public const int SignatureFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002E8E")]
				private string signature_;

				[Cpp2IlInjected.Token(Token = "0x4002E8F")]
				public const int RewardsFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002E90")]
				private MultiReward rewards_;

				[Cpp2IlInjected.Token(Token = "0x4002E91")]
				public const int GachaIdFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4002E92")]
				private string gachaId_;

				[Cpp2IlInjected.Token(Token = "0x4002E93")]
				public const int ValidatedFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4002E94")]
				private bool validated_;

				[Cpp2IlInjected.Token(Token = "0x170011A7")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60065F0")]
					[Cpp2IlInjected.Address(RVA = "0x272B490", Offset = "0x2729E90", VA = "0x18272B490")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011A8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60065F1")]
					[Cpp2IlInjected.Address(RVA = "0x272B190", Offset = "0x2729B90", VA = "0x18272B190")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011A9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60065F2")]
					[Cpp2IlInjected.Address(RVA = "0x272B910", Offset = "0x272A310", VA = "0x18272B910", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011AA")]
				[DebuggerNonUserCode]
				public string ProductID
				{
					[Cpp2IlInjected.Token(Token = "0x60065F6")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065F7")]
					[Cpp2IlInjected.Address(RVA = "0x272C080", Offset = "0x272AA80", VA = "0x18272C080")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011AB")]
				[DebuggerNonUserCode]
				public string Price
				{
					[Cpp2IlInjected.Token(Token = "0x60065F8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065F9")]
					[Cpp2IlInjected.Address(RVA = "0x272C010", Offset = "0x272AA10", VA = "0x18272C010")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011AC")]
				[DebuggerNonUserCode]
				public string Currency
				{
					[Cpp2IlInjected.Token(Token = "0x60065FA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065FB")]
					[Cpp2IlInjected.Address(RVA = "0x272BEC0", Offset = "0x272A8C0", VA = "0x18272BEC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011AD")]
				[DebuggerNonUserCode]
				public string Receipt
				{
					[Cpp2IlInjected.Token(Token = "0x60065FC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065FD")]
					[Cpp2IlInjected.Address(RVA = "0x272C160", Offset = "0x272AB60", VA = "0x18272C160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011AE")]
				[DebuggerNonUserCode]
				public string Signature
				{
					[Cpp2IlInjected.Token(Token = "0x60065FE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065FF")]
					[Cpp2IlInjected.Address(RVA = "0x272C1D0", Offset = "0x272ABD0", VA = "0x18272C1D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011AF")]
				[DebuggerNonUserCode]
				public MultiReward Rewards
				{
					[Cpp2IlInjected.Token(Token = "0x6006600")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006601")]
					[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B0")]
				[DebuggerNonUserCode]
				public string GachaId
				{
					[Cpp2IlInjected.Token(Token = "0x6006602")]
					[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006603")]
					[Cpp2IlInjected.Address(RVA = "0x272BF30", Offset = "0x272A930", VA = "0x18272BF30")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B1")]
				[DebuggerNonUserCode]
				public bool Validated
				{
					[Cpp2IlInjected.Token(Token = "0x6006604")]
					[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006605")]
					[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60065F3")]
				[Cpp2IlInjected.Address(RVA = "0x272AD50", Offset = "0x2729750", VA = "0x18272AD50")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065F4")]
				[Cpp2IlInjected.Address(RVA = "0x272A590", Offset = "0x2728F90", VA = "0x18272A590")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065F5")]
				[Cpp2IlInjected.Address(RVA = "0x27254C0", Offset = "0x2723EC0", VA = "0x1827254C0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006606")]
				[Cpp2IlInjected.Address(RVA = "0x2725A90", Offset = "0x2724490", VA = "0x182725A90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006607")]
				[Cpp2IlInjected.Address(RVA = "0x27260D0", Offset = "0x2724AD0", VA = "0x1827260D0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006608")]
				[Cpp2IlInjected.Address(RVA = "0x2726CA0", Offset = "0x27256A0", VA = "0x182726CA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006609")]
				[Cpp2IlInjected.Address(RVA = "0x2728260", Offset = "0x2726C60", VA = "0x182728260", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600660A")]
				[Cpp2IlInjected.Address(RVA = "0x2729610", Offset = "0x2728010", VA = "0x182729610", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600660B")]
				[Cpp2IlInjected.Address(RVA = "0x2724720", Offset = "0x2723120", VA = "0x182724720", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600660C")]
				[Cpp2IlInjected.Address(RVA = "0x2726F30", Offset = "0x2725930", VA = "0x182726F30", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600660D")]
				[Cpp2IlInjected.Address(RVA = "0x2727420", Offset = "0x2725E20", VA = "0x182727420", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600660E")]
				[Cpp2IlInjected.Address(RVA = "0x2726440", Offset = "0x2724E40", VA = "0x182726440", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600660F")]
				[Cpp2IlInjected.Address(RVA = "0x27277B0", Offset = "0x27261B0", VA = "0x1827277B0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006610")]
				[Cpp2IlInjected.Address(RVA = "0x2724DC0", Offset = "0x27237C0", VA = "0x182724DC0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006611")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
				protected override CRMBuyResult ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(CRMBuyResult);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000BFE")]
			public sealed class Response : TransactionAction<CRMBuyResult>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002E96")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002E97")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002E98")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002E99")]
				private CRMBuyResult result_;

				[Cpp2IlInjected.Token(Token = "0x4002E9A")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002E9B")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170011B2")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006616")]
					[Cpp2IlInjected.Address(RVA = "0x2735E70", Offset = "0x2734870", VA = "0x182735E70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B3")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006617")]
					[Cpp2IlInjected.Address(RVA = "0x2735B30", Offset = "0x2734530", VA = "0x182735B30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B4")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006618")]
					[Cpp2IlInjected.Address(RVA = "0x2736530", Offset = "0x2734F30", VA = "0x182736530", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B5")]
				[DebuggerNonUserCode]
				public CRMBuyResult Result
				{
					[Cpp2IlInjected.Token(Token = "0x600661C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(CRMBuyResult);
					}
					[Cpp2IlInjected.Token(Token = "0x600661D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B6")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600661E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600661F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011B7")]
				protected override CRMBuyResult MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600662B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(CRMBuyResult);
					}
					[Cpp2IlInjected.Token(Token = "0x600662C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006619")]
				[Cpp2IlInjected.Address(RVA = "0x27356F0", Offset = "0x27340F0", VA = "0x1827356F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600661A")]
				[Cpp2IlInjected.Address(RVA = "0x2735430", Offset = "0x2733E30", VA = "0x182735430")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600661B")]
				[Cpp2IlInjected.Address(RVA = "0x272FEB0", Offset = "0x272E8B0", VA = "0x18272FEB0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006620")]
				[Cpp2IlInjected.Address(RVA = "0x27303B0", Offset = "0x272EDB0", VA = "0x1827303B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006621")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006622")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006623")]
				[Cpp2IlInjected.Address(RVA = "0x2733840", Offset = "0x2732240", VA = "0x182733840", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006624")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006625")]
				[Cpp2IlInjected.Address(RVA = "0x272EFD0", Offset = "0x272D9D0", VA = "0x18272EFD0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006626")]
				[Cpp2IlInjected.Address(RVA = "0x27329D0", Offset = "0x27313D0", VA = "0x1827329D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006627")]
				[Cpp2IlInjected.Address(RVA = "0x2731A00", Offset = "0x2730400", VA = "0x182731A00", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006628")]
				[Cpp2IlInjected.Address(RVA = "0x2730C00", Offset = "0x272F600", VA = "0x182730C00", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006629")]
				[Cpp2IlInjected.Address(RVA = "0x2732EC0", Offset = "0x27318C0", VA = "0x182732EC0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600662A")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600662D")]
				[Cpp2IlInjected.Address(RVA = "0x272C240", Offset = "0x272AC40", VA = "0x18272C240", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002E81")]
		private static readonly MessageParser<BuyIAP> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E82")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170011A4")]
		[DebuggerNonUserCode]
		public static MessageParser<BuyIAP> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60065DE")]
			[Cpp2IlInjected.Address(RVA = "0x714AF0", Offset = "0x7134F0", VA = "0x180714AF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60065DF")]
			[Cpp2IlInjected.Address(RVA = "0x714A20", Offset = "0x713420", VA = "0x180714A20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60065E0")]
			[Cpp2IlInjected.Address(RVA = "0x714B50", Offset = "0x713550", VA = "0x180714B50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60065E1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BuyIAP()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60065E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public BuyIAP(BuyIAP other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60065E3")]
		[Cpp2IlInjected.Address(RVA = "0x714740", Offset = "0x713140", VA = "0x180714740", Slot = "10")]
		[DebuggerNonUserCode]
		public BuyIAP Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			BuyIAP buyIAP = default(BuyIAP);
			buyIAP.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (buyIAP._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buyIAP;
		}

		[Cpp2IlInjected.Token(Token = "0x60065E4")]
		[Cpp2IlInjected.Address(RVA = "0x7147C0", Offset = "0x7131C0", VA = "0x1807147C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60065E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuyIAP other)
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

		[Cpp2IlInjected.Token(Token = "0x60065E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60065E7")]
		[Cpp2IlInjected.Address(RVA = "0x7148B0", Offset = "0x7132B0", VA = "0x1807148B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60065E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60065E9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60065EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuyIAP other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60065EB")]
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

		[Cpp2IlInjected.Token(Token = "0x60065EC")]
		[Cpp2IlInjected.Address(RVA = "0x714840", Offset = "0x713240", VA = "0x180714840", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60065ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60065EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60065EF")]
		[Cpp2IlInjected.Address(RVA = "0x714910", Offset = "0x713310", VA = "0x180714910")]
		static BuyIAP()
		{
			Func<BuyIAP> func = default(Func<BuyIAP>);
			_parser = (MessageParser<BuyIAP>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
