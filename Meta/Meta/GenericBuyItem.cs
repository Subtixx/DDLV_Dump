using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000481")]
	public sealed class GenericBuyItem : IMessage<GenericBuyItem>, IMessage, IEquatable<GenericBuyItem>, IDeepCloneable<GenericBuyItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000482")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000483")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000E09")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000E0A")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000E0B")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000E0C")]
				[OriginalName("NoPriceForItem")]
				NoPriceForItem,
				[Cpp2IlInjected.Token(Token = "0x4000E0D")]
				[OriginalName("ItemIsHidden")]
				ItemIsHidden,
				[Cpp2IlInjected.Token(Token = "0x4000E0E")]
				[OriginalName("CantBuyItem")]
				CantBuyItem,
				[Cpp2IlInjected.Token(Token = "0x4000E0F")]
				[OriginalName("OverLimit")]
				OverLimit,
				[Cpp2IlInjected.Token(Token = "0x4000E10")]
				[OriginalName("CannotAddItem")]
				CannotAddItem,
				[Cpp2IlInjected.Token(Token = "0x4000E11")]
				[OriginalName("StoreDataBaseError")]
				StoreDataBaseError
			}

			[Cpp2IlInjected.Token(Token = "0x2000484")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E12")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E13")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E14")]
				public const int ItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E15")]
				private int itemId_;

				[Cpp2IlInjected.Token(Token = "0x4000E16")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000E17")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x4000E18")]
				public const int BuyMissingSoftCurrencyWithHardCurrencyFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E19")]
				private bool buyMissingSoftCurrencyWithHardCurrency_;

				[Cpp2IlInjected.Token(Token = "0x1700080F")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002BF7")]
					[Cpp2IlInjected.Address(RVA = "0x1E80090", Offset = "0x1E7EA90", VA = "0x181E80090")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000810")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002BF8")]
					[Cpp2IlInjected.Address(RVA = "0x1E7F790", Offset = "0x1E7E190", VA = "0x181E7F790")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000811")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002BF9")]
					[Cpp2IlInjected.Address(RVA = "0x1E80690", Offset = "0x1E7F090", VA = "0x181E80690", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000812")]
				[DebuggerNonUserCode]
				public int ItemId
				{
					[Cpp2IlInjected.Token(Token = "0x6002BFD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002BFE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000813")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6002BFF")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C00")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000814")]
				[DebuggerNonUserCode]
				public bool BuyMissingSoftCurrencyWithHardCurrency
				{
					[Cpp2IlInjected.Token(Token = "0x6002C01")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C02")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002BFA")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F640", Offset = "0x1E7E040", VA = "0x181E7F640")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BFB")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F060", Offset = "0x1E7DA60", VA = "0x181E7F060")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BFC")]
				[Cpp2IlInjected.Address(RVA = "0x1E794F0", Offset = "0x1E77EF0", VA = "0x181E794F0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C03")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A290", Offset = "0x1E78C90", VA = "0x181E7A290", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C04")]
				[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C05")]
				[Cpp2IlInjected.Address(RVA = "0x75BE10", Offset = "0x75A810", VA = "0x18075BE10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C06")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C930", Offset = "0x1E7B330", VA = "0x181E7C930", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C07")]
				[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C08")]
				[Cpp2IlInjected.Address(RVA = "0x1E78C00", Offset = "0x1E77600", VA = "0x181E78C00", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C09")]
				[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C0A")]
				[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C0B")]
				[Cpp2IlInjected.Address(RVA = "0x1E7AA50", Offset = "0x1E79450", VA = "0x181E7AA50", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C0C")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BFB0", Offset = "0x1E7A9B0", VA = "0x181E7BFB0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C0D")]
				[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C0E")]
				[Cpp2IlInjected.Address(RVA = "0x1E7CF90", Offset = "0x1E7B990", VA = "0x181E7CF90", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C0F")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B1E0", Offset = "0x1E79BE0", VA = "0x181E7B1E0")]
				private bool IsItemHidden(IGenericBuyable itemData, in World world)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000487")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E1C")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E1D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E1E")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E1F")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000E20")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E21")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000815")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002C17")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F280", Offset = "0x1E8DC80", VA = "0x181E8F280")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000816")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C18")]
					[Cpp2IlInjected.Address(RVA = "0x1E8ED60", Offset = "0x1E8D760", VA = "0x181E8ED60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000817")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C19")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F700", Offset = "0x1E8E100", VA = "0x181E8F700", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000818")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002C1D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C1E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000819")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002C1F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002C20")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700081A")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002C2C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C2D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002C1A")]
				[Cpp2IlInjected.Address(RVA = "0x1E8DF80", Offset = "0x1E8C980", VA = "0x181E8DF80")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C1B")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D6E0", Offset = "0x1E8C0E0", VA = "0x181E8D6E0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C1C")]
				[Cpp2IlInjected.Address(RVA = "0x1E85290", Offset = "0x1E83C90", VA = "0x181E85290", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C21")]
				[Cpp2IlInjected.Address(RVA = "0x1E86100", Offset = "0x1E84B00", VA = "0x181E86100", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C22")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C23")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C24")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B610", Offset = "0x1E8A010", VA = "0x181E8B610", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C25")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C26")]
				[Cpp2IlInjected.Address(RVA = "0x1E83F60", Offset = "0x1E82960", VA = "0x181E83F60", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C27")]
				[Cpp2IlInjected.Address(RVA = "0x1E89330", Offset = "0x1E87D30", VA = "0x181E89330", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C28")]
				[Cpp2IlInjected.Address(RVA = "0x1E88930", Offset = "0x1E87330", VA = "0x181E88930", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C29")]
				[Cpp2IlInjected.Address(RVA = "0x1E87C60", Offset = "0x1E86660", VA = "0x181E87C60", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C2A")]
				[Cpp2IlInjected.Address(RVA = "0x1E8AA20", Offset = "0x1E89420", VA = "0x181E8AA20", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C2B")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C2E")]
				[Cpp2IlInjected.Address(RVA = "0x1E82020", Offset = "0x1E80A20", VA = "0x181E82020", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000E06")]
		private static readonly MessageParser<GenericBuyItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E07")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700080C")]
		[DebuggerNonUserCode]
		public static MessageParser<GenericBuyItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002BE5")]
			[Cpp2IlInjected.Address(RVA = "0x1D025C0", Offset = "0x1D00FC0", VA = "0x181D025C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002BE6")]
			[Cpp2IlInjected.Address(RVA = "0x1D024F0", Offset = "0x1D00EF0", VA = "0x181D024F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002BE7")]
			[Cpp2IlInjected.Address(RVA = "0x1D02620", Offset = "0x1D01020", VA = "0x181D02620", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GenericBuyItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GenericBuyItem(GenericBuyItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEA")]
		[Cpp2IlInjected.Address(RVA = "0x1D02210", Offset = "0x1D00C10", VA = "0x181D02210", Slot = "10")]
		[DebuggerNonUserCode]
		public GenericBuyItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GenericBuyItem genericBuyItem = default(GenericBuyItem);
			genericBuyItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (genericBuyItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return genericBuyItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEB")]
		[Cpp2IlInjected.Address(RVA = "0x1D02290", Offset = "0x1D00C90", VA = "0x181D02290", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002BEC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GenericBuyItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6002BED")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEE")]
		[Cpp2IlInjected.Address(RVA = "0x1D02380", Offset = "0x1D00D80", VA = "0x181D02380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GenericBuyItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF2")]
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

		[Cpp2IlInjected.Token(Token = "0x6002BF3")]
		[Cpp2IlInjected.Address(RVA = "0x1D02310", Offset = "0x1D00D10", VA = "0x181D02310", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF6")]
		[Cpp2IlInjected.Address(RVA = "0x1D023E0", Offset = "0x1D00DE0", VA = "0x181D023E0")]
		static GenericBuyItem()
		{
			Func<GenericBuyItem> func = default(Func<GenericBuyItem>);
			_parser = (MessageParser<GenericBuyItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
