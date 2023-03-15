using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20003BA")]
	public sealed class FulfillRestaurantOrders : IMessage<FulfillRestaurantOrders>, IMessage, IEquatable<FulfillRestaurantOrders>, IDeepCloneable<FulfillRestaurantOrders>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003BB")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003BC")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000B98")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000B99")]
				[OriginalName("InvalidContainerInventory")]
				InvalidContainerInventory,
				[Cpp2IlInjected.Token(Token = "0x4000B9A")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000B9B")]
				[OriginalName("NoOrderForCharacter")]
				NoOrderForCharacter,
				[Cpp2IlInjected.Token(Token = "0x4000B9C")]
				[OriginalName("OrderAlreadyFulfilled")]
				OrderAlreadyFulfilled,
				[Cpp2IlInjected.Token(Token = "0x4000B9D")]
				[OriginalName("WrongMeal")]
				WrongMeal
			}

			[Cpp2IlInjected.Token(Token = "0x20003BD")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000B9E")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000B9F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000BA0")]
				public const int CharacterItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000BA1")]
				private int characterItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000BA2")]
				public const int ContainerInventoryIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000BA3")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000BA4")]
				public const int ContainerInventoryPositionFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000BA5")]
				private int containerInventoryPosition_;

				[Cpp2IlInjected.Token(Token = "0x170006A9")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60024CE")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FF10", Offset = "0x1E7E910", VA = "0x181E7FF10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006AA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60024CF")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FC90", Offset = "0x1E7E690", VA = "0x181E7FC90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006AB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60024D0")]
					[Cpp2IlInjected.Address(RVA = "0x1E80A50", Offset = "0x1E7F450", VA = "0x181E80A50", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006AC")]
				[DebuggerNonUserCode]
				public int CharacterItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60024D4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60024D5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006AD")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x60024D6")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60024D7")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006AE")]
				[DebuggerNonUserCode]
				public int ContainerInventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x60024D8")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60024D9")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60024D1")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F580", Offset = "0x1E7DF80", VA = "0x181E7F580")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024D2")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F310", Offset = "0x1E7DD10", VA = "0x181E7F310")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024D3")]
				[Cpp2IlInjected.Address(RVA = "0x1E79730", Offset = "0x1E78130", VA = "0x181E79730", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024DA")]
				[Cpp2IlInjected.Address(RVA = "0x1E79C50", Offset = "0x1E78650", VA = "0x181E79C50", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60024DB")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60024DC")]
				[Cpp2IlInjected.Address(RVA = "0x1DF83C0", Offset = "0x1DF6DC0", VA = "0x181DF83C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60024DD")]
				[Cpp2IlInjected.Address(RVA = "0x1E7CB70", Offset = "0x1E7B570", VA = "0x181E7CB70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024DE")]
				[Cpp2IlInjected.Address(RVA = "0x1E7DB60", Offset = "0x1E7C560", VA = "0x181E7DB60", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024DF")]
				[Cpp2IlInjected.Address(RVA = "0x1E78CD0", Offset = "0x1E776D0", VA = "0x181E78CD0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60024E0")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024E1")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024E2")]
				[Cpp2IlInjected.Address(RVA = "0x1E7AB40", Offset = "0x1E79540", VA = "0x181E7AB40", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024E3")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7AC30", VA = "0x181E7C230", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024E4")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024E5")]
				[Cpp2IlInjected.Address(RVA = "0x1E7CCB0", Offset = "0x1E7B6B0", VA = "0x181E7CCB0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003C0")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000BA8")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000BA9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000BAA")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000BAB")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000BAC")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000BAD")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170006AF")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60024EC")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F160", Offset = "0x1E8DB60", VA = "0x181E8F160")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006B0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60024ED")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EFE0", Offset = "0x1E8D9E0", VA = "0x181E8EFE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006B1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60024EE")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F7C0", Offset = "0x1E8E1C0", VA = "0x181E8F7C0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006B2")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60024F2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60024F3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006B3")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60024F4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60024F5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006B4")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002501")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002502")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60024EF")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E0C0", Offset = "0x1E8CAC0", VA = "0x181E8E0C0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024F0")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E930", Offset = "0x1E8D330", VA = "0x181E8E930")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024F1")]
				[Cpp2IlInjected.Address(RVA = "0x1E85910", Offset = "0x1E84310", VA = "0x181E85910", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024F6")]
				[Cpp2IlInjected.Address(RVA = "0x1E86920", Offset = "0x1E85320", VA = "0x181E86920", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60024F7")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60024F8")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60024F9")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B490", Offset = "0x1E89E90", VA = "0x181E8B490", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024FA")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024FB")]
				[Cpp2IlInjected.Address(RVA = "0x1E848C0", Offset = "0x1E832C0", VA = "0x181E848C0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60024FC")]
				[Cpp2IlInjected.Address(RVA = "0x1E89E20", Offset = "0x1E88820", VA = "0x181E89E20", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024FD")]
				[Cpp2IlInjected.Address(RVA = "0x1E88C10", Offset = "0x1E87610", VA = "0x181E88C10", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024FE")]
				[Cpp2IlInjected.Address(RVA = "0x1E87300", Offset = "0x1E85D00", VA = "0x181E87300", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024FF")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A570", Offset = "0x1E88F70", VA = "0x181E8A570", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002500")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002503")]
				[Cpp2IlInjected.Address(RVA = "0x1E824A0", Offset = "0x1E80EA0", VA = "0x181E824A0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000B95")]
		private static readonly MessageParser<FulfillRestaurantOrders> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B96")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170006A6")]
		[DebuggerNonUserCode]
		public static MessageParser<FulfillRestaurantOrders> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60024BC")]
			[Cpp2IlInjected.Address(RVA = "0x1809F50", Offset = "0x1808950", VA = "0x181809F50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60024BD")]
			[Cpp2IlInjected.Address(RVA = "0x1809E80", Offset = "0x1808880", VA = "0x181809E80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60024BE")]
			[Cpp2IlInjected.Address(RVA = "0x1809FB0", Offset = "0x18089B0", VA = "0x181809FB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024BF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FulfillRestaurantOrders()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60024C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public FulfillRestaurantOrders(FulfillRestaurantOrders other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024C1")]
		[Cpp2IlInjected.Address(RVA = "0x1809BA0", Offset = "0x18085A0", VA = "0x181809BA0", Slot = "10")]
		[DebuggerNonUserCode]
		public FulfillRestaurantOrders Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			FulfillRestaurantOrders fulfillRestaurantOrders = default(FulfillRestaurantOrders);
			fulfillRestaurantOrders.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (fulfillRestaurantOrders._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fulfillRestaurantOrders;
		}

		[Cpp2IlInjected.Token(Token = "0x60024C2")]
		[Cpp2IlInjected.Address(RVA = "0x1809C20", Offset = "0x1808620", VA = "0x181809C20", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60024C3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FulfillRestaurantOrders other)
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

		[Cpp2IlInjected.Token(Token = "0x60024C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60024C5")]
		[Cpp2IlInjected.Address(RVA = "0x1809D10", Offset = "0x1808710", VA = "0x181809D10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60024C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60024C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60024C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FulfillRestaurantOrders other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024C9")]
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

		[Cpp2IlInjected.Token(Token = "0x60024CA")]
		[Cpp2IlInjected.Address(RVA = "0x1809CA0", Offset = "0x18086A0", VA = "0x181809CA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60024CB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60024CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60024CD")]
		[Cpp2IlInjected.Address(RVA = "0x1809D70", Offset = "0x1808770", VA = "0x181809D70")]
		static FulfillRestaurantOrders()
		{
			Func<FulfillRestaurantOrders> func = default(Func<FulfillRestaurantOrders>);
			_parser = (MessageParser<FulfillRestaurantOrders>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
