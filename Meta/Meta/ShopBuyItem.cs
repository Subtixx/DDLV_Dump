using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000469")]
	public sealed class ShopBuyItem : IMessage<ShopBuyItem>, IMessage, IEquatable<ShopBuyItem>, IDeepCloneable<ShopBuyItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200046A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200046B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000DA8")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000DA9")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000DAA")]
				[OriginalName("SlotIsEmpty")]
				SlotIsEmpty,
				[Cpp2IlInjected.Token(Token = "0x4000DAB")]
				[OriginalName("InvalidShop")]
				InvalidShop,
				[Cpp2IlInjected.Token(Token = "0x4000DAC")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000DAD")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x4000DAE")]
				[OriginalName("InvalidSlot")]
				InvalidSlot,
				[Cpp2IlInjected.Token(Token = "0x4000DAF")]
				[OriginalName("InventoryFull")]
				InventoryFull,
				[Cpp2IlInjected.Token(Token = "0x4000DB0")]
				[OriginalName("NotEnoughItem")]
				NotEnoughItem,
				[Cpp2IlInjected.Token(Token = "0x4000DB1")]
				[OriginalName("NoPriceForItem")]
				NoPriceForItem,
				[Cpp2IlInjected.Token(Token = "0x4000DB2")]
				[OriginalName("CannotAddItem")]
				CannotAddItem,
				[Cpp2IlInjected.Token(Token = "0x4000DB3")]
				[OriginalName("MaximumOwnedReached")]
				MaximumOwnedReached
			}

			[Cpp2IlInjected.Token(Token = "0x200046C")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000DB4")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000DB5")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000DB6")]
				public const int StallItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000DB7")]
				private int stallItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000DB8")]
				public const int GridIDFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4000DB9")]
				private static readonly FieldCodec<uint?> _single_gridID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000DBA")]
				private uint? gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000DBB")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000DBC")]
				private static readonly FieldCodec<uint?> _single_gridObjectID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000DBD")]
				private uint? gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x4000DBE")]
				public const int SlotIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000DBF")]
				private int slotId_;

				[Cpp2IlInjected.Token(Token = "0x4000DC0")]
				public const int AmountFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000DC1")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x4000DC2")]
				public const int BuyMissingSoftCurrencyWithHardCurrencyFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x4000DC3")]
				private bool buyMissingSoftCurrencyWithHardCurrency_;

				[Cpp2IlInjected.Token(Token = "0x170007DE")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002B08")]
					[Cpp2IlInjected.Address(RVA = "0x2B512A0", Offset = "0x2B4FCA0", VA = "0x182B512A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007DF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002B09")]
					[Cpp2IlInjected.Address(RVA = "0x2B50AC0", Offset = "0x2B4F4C0", VA = "0x182B50AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002B0A")]
					[Cpp2IlInjected.Address(RVA = "0x2B51E50", Offset = "0x2B50850", VA = "0x182B51E50", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E1")]
				[DebuggerNonUserCode]
				public int StallItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002B0E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B0F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E2")]
				[DebuggerNonUserCode]
				public uint? GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6002B10")]
					[Cpp2IlInjected.Address(RVA = "0xAC86D0", Offset = "0xAC70D0", VA = "0x180AC86D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002B11")]
					[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E3")]
				[DebuggerNonUserCode]
				public uint? GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6002B12")]
					[Cpp2IlInjected.Address(RVA = "0xF4C770", Offset = "0xF4B170", VA = "0x180F4C770")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002B13")]
					[Cpp2IlInjected.Address(RVA = "0xF4C7F0", Offset = "0xF4B1F0", VA = "0x180F4C7F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E4")]
				[DebuggerNonUserCode]
				public int SlotId
				{
					[Cpp2IlInjected.Token(Token = "0x6002B14")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B15")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E5")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6002B16")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B17")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E6")]
				[DebuggerNonUserCode]
				public bool BuyMissingSoftCurrencyWithHardCurrency
				{
					[Cpp2IlInjected.Token(Token = "0x6002B18")]
					[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B19")]
					[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002B0B")]
				[Cpp2IlInjected.Address(RVA = "0x2B50810", Offset = "0x2B4F210", VA = "0x182B50810")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B0C")]
				[Cpp2IlInjected.Address(RVA = "0x2B505E0", Offset = "0x2B4EFE0", VA = "0x182B505E0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B0D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A4A0", Offset = "0x2B48EA0", VA = "0x182B4A4A0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B1A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B190", Offset = "0x2B49B90", VA = "0x182B4B190", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B1B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A7C0", Offset = "0x2B491C0", VA = "0x182B4A7C0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B1C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C230", Offset = "0x2B4AC30", VA = "0x182B4C230", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B1D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E030", Offset = "0x2B4CA30", VA = "0x182B4E030", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B1E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F150", Offset = "0x2B4DB50", VA = "0x182B4F150", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B1F")]
				[Cpp2IlInjected.Address(RVA = "0x2B49230", Offset = "0x2B47C30", VA = "0x182B49230", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B20")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C970", Offset = "0x2B4B370", VA = "0x182B4C970", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B21")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CC40", Offset = "0x2B4B640", VA = "0x182B4CC40", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B22")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B950", Offset = "0x2B4A350", VA = "0x182B4B950", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B23")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D830", Offset = "0x2B4C230", VA = "0x182B4D830", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B24")]
				[Cpp2IlInjected.Address(RVA = "0x2B49E60", Offset = "0x2B48860", VA = "0x182B49E60", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B25")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E750", Offset = "0x2B4D150", VA = "0x182B4E750", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200046E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000DC5")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000DC6")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000DC7")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000DC8")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000DC9")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000DCA")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000DCB")]
				public const int ItemFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000DCC")]
				private ItemAmount item_;

				[Cpp2IlInjected.Token(Token = "0x4000DCD")]
				public const int PriceFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000DCE")]
				private CurrencyCost price_;

				[Cpp2IlInjected.Token(Token = "0x170007E7")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002B2A")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CF80", Offset = "0x2B5B980", VA = "0x182B5CF80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002B2B")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C8E0", Offset = "0x2B5B2E0", VA = "0x182B5C8E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007E9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002B2C")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D160", Offset = "0x2B5BB60", VA = "0x182B5D160", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007EA")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002B30")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B31")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007EB")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002B32")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002B33")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007EC")]
				[DebuggerNonUserCode]
				public ItemAmount Item
				{
					[Cpp2IlInjected.Token(Token = "0x6002B34")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002B35")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007ED")]
				[DebuggerNonUserCode]
				public CurrencyCost Price
				{
					[Cpp2IlInjected.Token(Token = "0x6002B36")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002B37")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007EE")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002B43")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B44")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002B2D")]
				[Cpp2IlInjected.Address(RVA = "0x2B5B950", Offset = "0x2B5A350", VA = "0x182B5B950")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B2E")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C200", Offset = "0x2B5AC00", VA = "0x182B5C200")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B2F")]
				[Cpp2IlInjected.Address(RVA = "0x2B54B70", Offset = "0x2B53570", VA = "0x182B54B70", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B38")]
				[Cpp2IlInjected.Address(RVA = "0x2B560F0", Offset = "0x2B54AF0", VA = "0x182B560F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B39")]
				[Cpp2IlInjected.Address(RVA = "0x1716D50", Offset = "0x1715750", VA = "0x181716D50", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B3A")]
				[Cpp2IlInjected.Address(RVA = "0x1718D20", Offset = "0x1717720", VA = "0x181718D20", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B3B")]
				[Cpp2IlInjected.Address(RVA = "0x2B59F70", Offset = "0x2B58970", VA = "0x182B59F70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B3C")]
				[Cpp2IlInjected.Address(RVA = "0x1719650", Offset = "0x1718050", VA = "0x181719650", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B3D")]
				[Cpp2IlInjected.Address(RVA = "0x2B54080", Offset = "0x2B52A80", VA = "0x182B54080", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B3E")]
				[Cpp2IlInjected.Address(RVA = "0x2B574D0", Offset = "0x2B55ED0", VA = "0x182B574D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B3F")]
				[Cpp2IlInjected.Address(RVA = "0x2B58810", Offset = "0x2B57210", VA = "0x182B58810", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B40")]
				[Cpp2IlInjected.Address(RVA = "0x2B56990", Offset = "0x2B55390", VA = "0x182B56990", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B41")]
				[Cpp2IlInjected.Address(RVA = "0x2B59200", Offset = "0x2B57C00", VA = "0x182B59200", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B42")]
				[Cpp2IlInjected.Address(RVA = "0x1716B10", Offset = "0x1715510", VA = "0x181716B10", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B45")]
				[Cpp2IlInjected.Address(RVA = "0x2B52ED0", Offset = "0x2B518D0", VA = "0x182B52ED0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000DA5")]
		private static readonly MessageParser<ShopBuyItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000DA6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170007DB")]
		[DebuggerNonUserCode]
		public static MessageParser<ShopBuyItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002AF6")]
			[Cpp2IlInjected.Address(RVA = "0x17783A0", Offset = "0x1776DA0", VA = "0x1817783A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002AF7")]
			[Cpp2IlInjected.Address(RVA = "0x17782D0", Offset = "0x1776CD0", VA = "0x1817782D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002AF8")]
			[Cpp2IlInjected.Address(RVA = "0x1778400", Offset = "0x1776E00", VA = "0x181778400", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ShopBuyItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ShopBuyItem(ShopBuyItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFB")]
		[Cpp2IlInjected.Address(RVA = "0x1777FF0", Offset = "0x17769F0", VA = "0x181777FF0", Slot = "10")]
		[DebuggerNonUserCode]
		public ShopBuyItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ShopBuyItem shopBuyItem = default(ShopBuyItem);
			shopBuyItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (shopBuyItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return shopBuyItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFC")]
		[Cpp2IlInjected.Address(RVA = "0x1778070", Offset = "0x1776A70", VA = "0x181778070", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002AFD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ShopBuyItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6002AFE")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFF")]
		[Cpp2IlInjected.Address(RVA = "0x1778160", Offset = "0x1776B60", VA = "0x181778160", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B00")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B01")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B02")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ShopBuyItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B03")]
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

		[Cpp2IlInjected.Token(Token = "0x6002B04")]
		[Cpp2IlInjected.Address(RVA = "0x17780F0", Offset = "0x1776AF0", VA = "0x1817780F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B05")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B06")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B07")]
		[Cpp2IlInjected.Address(RVA = "0x17781C0", Offset = "0x1776BC0", VA = "0x1817781C0")]
		static ShopBuyItem()
		{
			Func<ShopBuyItem> func = default(Func<ShopBuyItem>);
			_parser = (MessageParser<ShopBuyItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
