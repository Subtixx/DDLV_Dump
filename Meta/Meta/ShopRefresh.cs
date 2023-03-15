using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Options;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000461")]
	public sealed class ShopRefresh : IMessage<ShopRefresh>, IMessage, IEquatable<ShopRefresh>, IDeepCloneable<ShopRefresh>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000462")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000463")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000D86")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000D87")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000D88")]
				[OriginalName("NotRefreshable")]
				NotRefreshable,
				[Cpp2IlInjected.Token(Token = "0x4000D89")]
				[OriginalName("InvalidShop")]
				InvalidShop,
				[Cpp2IlInjected.Token(Token = "0x4000D8A")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000D8B")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId
			}

			[Cpp2IlInjected.Token(Token = "0x2000464")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IDynamicTransactionPriority
			{
				[Cpp2IlInjected.Token(Token = "0x4000D8C")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000D8D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000D8E")]
				public const int StallItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000D8F")]
				private int stallItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000D90")]
				public const int GridIDFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4000D91")]
				private static readonly FieldCodec<uint?> _single_gridID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000D92")]
				private uint? gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000D93")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000D94")]
				private static readonly FieldCodec<uint?> _single_gridObjectID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000D95")]
				private uint? gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x4000D96")]
				public const int ForceFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000D97")]
				private bool force_;

				[Cpp2IlInjected.Token(Token = "0x4000D98")]
				public const int BuyMissingSoftCurrencyWithHardCurrencyFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x4000D99")]
				private bool buyMissingSoftCurrencyWithHardCurrency_;

				[Cpp2IlInjected.Token(Token = "0x4000D9A")]
				public const int PlayerRequestedFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x4000D9B")]
				private bool playerRequested_;

				[Cpp2IlInjected.Token(Token = "0x170007CB")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002AB4")]
					[Cpp2IlInjected.Address(RVA = "0x2B510C0", Offset = "0x2B4FAC0", VA = "0x182B510C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AB5")]
					[Cpp2IlInjected.Address(RVA = "0x2B50D40", Offset = "0x2B4F740", VA = "0x182B50D40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AB6")]
					[Cpp2IlInjected.Address(RVA = "0x2B51C10", Offset = "0x2B50610", VA = "0x182B51C10", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CE")]
				[DebuggerNonUserCode]
				public int StallItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002ABA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002ABB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CF")]
				[DebuggerNonUserCode]
				public uint? GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6002ABC")]
					[Cpp2IlInjected.Address(RVA = "0xAC86D0", Offset = "0xAC70D0", VA = "0x180AC86D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002ABD")]
					[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D0")]
				[DebuggerNonUserCode]
				public uint? GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6002ABE")]
					[Cpp2IlInjected.Address(RVA = "0xF4C770", Offset = "0xF4B170", VA = "0x180F4C770")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002ABF")]
					[Cpp2IlInjected.Address(RVA = "0xF4C7F0", Offset = "0xF4B1F0", VA = "0x180F4C7F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D1")]
				[DebuggerNonUserCode]
				public bool Force
				{
					[Cpp2IlInjected.Token(Token = "0x6002AC0")]
					[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AC1")]
					[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D2")]
				[DebuggerNonUserCode]
				public bool BuyMissingSoftCurrencyWithHardCurrency
				{
					[Cpp2IlInjected.Token(Token = "0x6002AC2")]
					[Cpp2IlInjected.Address(RVA = "0xDD84C0", Offset = "0xDD6EC0", VA = "0x180DD84C0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AC3")]
					[Cpp2IlInjected.Address(RVA = "0xDD84D0", Offset = "0xDD6ED0", VA = "0x180DD84D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D3")]
				[DebuggerNonUserCode]
				public bool PlayerRequested
				{
					[Cpp2IlInjected.Token(Token = "0x6002AC4")]
					[Cpp2IlInjected.Address(RVA = "0x2B515A0", Offset = "0x2B4FFA0", VA = "0x182B515A0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AC5")]
					[Cpp2IlInjected.Address(RVA = "0x2B520B0", Offset = "0x2B50AB0", VA = "0x182B520B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D4")]
				public TransactionPriorityOptions.Types.Priority? Priority
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD1")]
					[Cpp2IlInjected.Address(RVA = "0x2B515B0", Offset = "0x2B4FFB0", VA = "0x182B515B0", Slot = "16")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB7")]
				[Cpp2IlInjected.Address(RVA = "0x2B50490", Offset = "0x2B4EE90", VA = "0x182B50490")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB8")]
				[Cpp2IlInjected.Address(RVA = "0x2B50360", Offset = "0x2B4ED60", VA = "0x182B50360")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB9")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A160", Offset = "0x2B48B60", VA = "0x182B4A160", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC6")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AA30", Offset = "0x2B49430", VA = "0x182B4AA30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC7")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B390", Offset = "0x2B49D90", VA = "0x182B4B390", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC8")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C360", Offset = "0x2B4AD60", VA = "0x182B4C360", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC9")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DEB0", Offset = "0x2B4C8B0", VA = "0x182B4DEB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACA")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EF90", Offset = "0x2B4D990", VA = "0x182B4EF90", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACB")]
				[Cpp2IlInjected.Address(RVA = "0x2B49620", Offset = "0x2B48020", VA = "0x182B49620", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACC")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C690", Offset = "0x2B4B090", VA = "0x182B4C690", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACD")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C780", Offset = "0x2B4B180", VA = "0x182B4C780", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACE")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BC80", Offset = "0x2B4A680", VA = "0x182B4BC80", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACF")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D0F0", Offset = "0x2B4BAF0", VA = "0x182B4D0F0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AD0")]
				[Cpp2IlInjected.Address(RVA = "0x2B49CD0", Offset = "0x2B486D0", VA = "0x182B49CD0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AD2")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E390", Offset = "0x2B4CD90", VA = "0x182B4E390", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000466")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000D9D")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000D9E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000D9F")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000DA0")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000DA1")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000DA2")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170007D5")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD7")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CEC0", Offset = "0x2B5B8C0", VA = "0x182B5CEC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD8")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C560", Offset = "0x2B5AF60", VA = "0x182B5C560")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD9")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D0A0", Offset = "0x2B5BAA0", VA = "0x182B5D0A0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D8")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002ADD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002ADE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007D9")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002ADF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002AE0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007DA")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002AEC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AED")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002ADA")]
				[Cpp2IlInjected.Address(RVA = "0x2B5B5B0", Offset = "0x2B59FB0", VA = "0x182B5B5B0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ADB")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BE10", Offset = "0x2B5A810", VA = "0x182B5BE10")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ADC")]
				[Cpp2IlInjected.Address(RVA = "0x2B55190", Offset = "0x2B53B90", VA = "0x182B55190", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE1")]
				[Cpp2IlInjected.Address(RVA = "0x2B56040", Offset = "0x2B54A40", VA = "0x182B56040", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE2")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE3")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE4")]
				[Cpp2IlInjected.Address(RVA = "0x2B59E50", Offset = "0x2B58850", VA = "0x182B59E50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE5")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE6")]
				[Cpp2IlInjected.Address(RVA = "0x2B53F10", Offset = "0x2B52910", VA = "0x182B53F10", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE7")]
				[Cpp2IlInjected.Address(RVA = "0x2B58AC0", Offset = "0x2B574C0", VA = "0x182B58AC0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE8")]
				[Cpp2IlInjected.Address(RVA = "0x2B58D80", Offset = "0x2B57780", VA = "0x182B58D80", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE9")]
				[Cpp2IlInjected.Address(RVA = "0x2B567F0", Offset = "0x2B551F0", VA = "0x182B567F0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AEA")]
				[Cpp2IlInjected.Address(RVA = "0x2B59970", Offset = "0x2B58370", VA = "0x182B59970", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AEB")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AEE")]
				[Cpp2IlInjected.Address(RVA = "0x2B528E0", Offset = "0x2B512E0", VA = "0x182B528E0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000D83")]
		private static readonly MessageParser<ShopRefresh> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D84")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170007C8")]
		[DebuggerNonUserCode]
		public static MessageParser<ShopRefresh> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA2")]
			[Cpp2IlInjected.Address(RVA = "0x17788C0", Offset = "0x17772C0", VA = "0x1817788C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA3")]
			[Cpp2IlInjected.Address(RVA = "0x17787F0", Offset = "0x17771F0", VA = "0x1817787F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA4")]
			[Cpp2IlInjected.Address(RVA = "0x1778920", Offset = "0x1777320", VA = "0x181778920", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ShopRefresh()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ShopRefresh(ShopRefresh other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA7")]
		[Cpp2IlInjected.Address(RVA = "0x1778510", Offset = "0x1776F10", VA = "0x181778510", Slot = "10")]
		[DebuggerNonUserCode]
		public ShopRefresh Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ShopRefresh shopRefresh = default(ShopRefresh);
			shopRefresh.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (shopRefresh._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return shopRefresh;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA8")]
		[Cpp2IlInjected.Address(RVA = "0x1778590", Offset = "0x1776F90", VA = "0x181778590", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002AA9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ShopRefresh other)
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

		[Cpp2IlInjected.Token(Token = "0x6002AAA")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAB")]
		[Cpp2IlInjected.Address(RVA = "0x1778680", Offset = "0x1777080", VA = "0x181778680", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ShopRefresh other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAF")]
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

		[Cpp2IlInjected.Token(Token = "0x6002AB0")]
		[Cpp2IlInjected.Address(RVA = "0x1778610", Offset = "0x1777010", VA = "0x181778610", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB3")]
		[Cpp2IlInjected.Address(RVA = "0x17786E0", Offset = "0x17770E0", VA = "0x1817786E0")]
		static ShopRefresh()
		{
			Func<ShopRefresh> func = default(Func<ShopRefresh>);
			_parser = (MessageParser<ShopRefresh>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
