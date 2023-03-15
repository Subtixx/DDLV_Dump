using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004BE")]
	public sealed class ShopSellItems : IMessage<ShopSellItems>, IMessage, IEquatable<ShopSellItems>, IDeepCloneable<ShopSellItems>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004BF")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004C0")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000EC8")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000EC9")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000ECA")]
				[OriginalName("CannotBeSold")]
				CannotBeSold,
				[Cpp2IlInjected.Token(Token = "0x4000ECB")]
				[OriginalName("InvalidShop")]
				InvalidShop,
				[Cpp2IlInjected.Token(Token = "0x4000ECC")]
				[OriginalName("InvalidInventory")]
				InvalidInventory,
				[Cpp2IlInjected.Token(Token = "0x4000ECD")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems
			}

			[Cpp2IlInjected.Token(Token = "0x20004C1")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000ECE")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000ECF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000ED0")]
				public const int StallItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000ED1")]
				private int stallItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000ED2")]
				public const int ContainerIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000ED3")]
				private int containerId_;

				[Cpp2IlInjected.Token(Token = "0x4000ED4")]
				public const int ItemsFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000ED5")]
				private static readonly FieldCodec<BackpackItem> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000ED6")]
				private readonly RepeatedField<BackpackItem> items_;

				[Cpp2IlInjected.Token(Token = "0x4000ED7")]
				public const int SellBonusMultiplierFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000ED8")]
				private float sellBonusMultiplier_;

				[Cpp2IlInjected.Token(Token = "0x4000ED9")]
				public const int SellCapMultiplierFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000EDA")]
				private float sellCapMultiplier_;

				[Cpp2IlInjected.Token(Token = "0x1700087D")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002E35")]
					[Cpp2IlInjected.Address(RVA = "0x108EE80", Offset = "0x108D880", VA = "0x18108EE80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700087E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E36")]
					[Cpp2IlInjected.Address(RVA = "0x108EDA0", Offset = "0x108D7A0", VA = "0x18108EDA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700087F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E37")]
					[Cpp2IlInjected.Address(RVA = "0x108EEE0", Offset = "0x108D8E0", VA = "0x18108EEE0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000880")]
				[DebuggerNonUserCode]
				public int StallItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002E3B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E3C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000881")]
				[DebuggerNonUserCode]
				public int ContainerId
				{
					[Cpp2IlInjected.Token(Token = "0x6002E3D")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E3E")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000882")]
				[DebuggerNonUserCode]
				public RepeatedField<BackpackItem> Items
				{
					[Cpp2IlInjected.Token(Token = "0x6002E3F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000883")]
				[DebuggerNonUserCode]
				public float SellBonusMultiplier
				{
					[Cpp2IlInjected.Token(Token = "0x6002E40")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E41")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000884")]
				[DebuggerNonUserCode]
				public float SellCapMultiplier
				{
					[Cpp2IlInjected.Token(Token = "0x6002E42")]
					[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E43")]
					[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002E38")]
				[Cpp2IlInjected.Address(RVA = "0x108EC90", Offset = "0x108D690", VA = "0x18108EC90")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E39")]
				[Cpp2IlInjected.Address(RVA = "0x108EBE0", Offset = "0x108D5E0", VA = "0x18108EBE0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3A")]
				[Cpp2IlInjected.Address(RVA = "0x108D580", Offset = "0x108BF80", VA = "0x18108D580", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E44")]
				[Cpp2IlInjected.Address(RVA = "0x108D650", Offset = "0x108C050", VA = "0x18108D650", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E45")]
				[Cpp2IlInjected.Address(RVA = "0x108D880", Offset = "0x108C280", VA = "0x18108D880", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E46")]
				[Cpp2IlInjected.Address(RVA = "0x108DBC0", Offset = "0x108C5C0", VA = "0x18108DBC0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E47")]
				[Cpp2IlInjected.Address(RVA = "0x108E2D0", Offset = "0x108CCD0", VA = "0x18108E2D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E48")]
				[Cpp2IlInjected.Address(RVA = "0x108E6F0", Offset = "0x108D0F0", VA = "0x18108E6F0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E49")]
				[Cpp2IlInjected.Address(RVA = "0x108D280", Offset = "0x108BC80", VA = "0x18108D280", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E4A")]
				[Cpp2IlInjected.Address(RVA = "0x108DDD0", Offset = "0x108C7D0", VA = "0x18108DDD0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E4B")]
				[Cpp2IlInjected.Address(RVA = "0x108DE90", Offset = "0x108C890", VA = "0x18108DE90", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E4C")]
				[Cpp2IlInjected.Address(RVA = "0x108D9E0", Offset = "0x108C3E0", VA = "0x18108D9E0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E4D")]
				[Cpp2IlInjected.Address(RVA = "0x108E0B0", Offset = "0x108CAB0", VA = "0x18108E0B0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E4E")]
				[Cpp2IlInjected.Address(RVA = "0x108D3D0", Offset = "0x108BDD0", VA = "0x18108D3D0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E4F")]
				[Cpp2IlInjected.Address(RVA = "0x108E330", Offset = "0x108CD30", VA = "0x18108E330", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004C3")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000EDC")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000EDD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000EDE")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000EDF")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000EE0")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000EE1")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000885")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002E54")]
					[Cpp2IlInjected.Address(RVA = "0x1091710", Offset = "0x1090110", VA = "0x181091710")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000886")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E55")]
					[Cpp2IlInjected.Address(RVA = "0x1091630", Offset = "0x1090030", VA = "0x181091630")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000887")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E56")]
					[Cpp2IlInjected.Address(RVA = "0x1091770", Offset = "0x1090170", VA = "0x181091770", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000888")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002E5A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E5B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000889")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002E5C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002E5D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700088A")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002E69")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E6A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002E57")]
				[Cpp2IlInjected.Address(RVA = "0x10912D0", Offset = "0x108FCD0", VA = "0x1810912D0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E58")]
				[Cpp2IlInjected.Address(RVA = "0x1091310", Offset = "0x108FD10", VA = "0x181091310")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E59")]
				[Cpp2IlInjected.Address(RVA = "0x1090430", Offset = "0x108EE30", VA = "0x181090430", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E5E")]
				[Cpp2IlInjected.Address(RVA = "0x1090790", Offset = "0x108F190", VA = "0x181090790", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E5F")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E60")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E61")]
				[Cpp2IlInjected.Address(RVA = "0x1091050", Offset = "0x108FA50", VA = "0x181091050", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E62")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E63")]
				[Cpp2IlInjected.Address(RVA = "0x1090360", Offset = "0x108ED60", VA = "0x181090360", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E64")]
				[Cpp2IlInjected.Address(RVA = "0x1090AF0", Offset = "0x108F4F0", VA = "0x181090AF0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E65")]
				[Cpp2IlInjected.Address(RVA = "0x1090D60", Offset = "0x108F760", VA = "0x181090D60", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E66")]
				[Cpp2IlInjected.Address(RVA = "0x1090910", Offset = "0x108F310", VA = "0x181090910", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E67")]
				[Cpp2IlInjected.Address(RVA = "0x1090F20", Offset = "0x108F920", VA = "0x181090F20", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E68")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E6B")]
				[Cpp2IlInjected.Address(RVA = "0x108F060", Offset = "0x108DA60", VA = "0x18108F060", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000EC5")]
		private static readonly MessageParser<ShopSellItems> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EC6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700087A")]
		[DebuggerNonUserCode]
		public static MessageParser<ShopSellItems> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002E22")]
			[Cpp2IlInjected.Address(RVA = "0x1778FF0", Offset = "0x17779F0", VA = "0x181778FF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E23")]
			[Cpp2IlInjected.Address(RVA = "0x1778F20", Offset = "0x1777920", VA = "0x181778F20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E24")]
			[Cpp2IlInjected.Address(RVA = "0x1779050", Offset = "0x1777A50", VA = "0x181779050", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E25")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ShopSellItems()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E26")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ShopSellItems(ShopSellItems other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E27")]
		[Cpp2IlInjected.Address(RVA = "0x1778C40", Offset = "0x1777640", VA = "0x181778C40", Slot = "10")]
		[DebuggerNonUserCode]
		public ShopSellItems Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ShopSellItems shopSellItems = default(ShopSellItems);
			shopSellItems.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (shopSellItems._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return shopSellItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E28")]
		[Cpp2IlInjected.Address(RVA = "0x1778CC0", Offset = "0x17776C0", VA = "0x181778CC0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E29")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ShopSellItems other)
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

		[Cpp2IlInjected.Token(Token = "0x6002E2A")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2B")]
		[Cpp2IlInjected.Address(RVA = "0x1778DB0", Offset = "0x17777B0", VA = "0x181778DB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ShopSellItems other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2F")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E30")]
		[Cpp2IlInjected.Address(RVA = "0x1778D40", Offset = "0x1777740", VA = "0x181778D40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E31")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E32")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E33")]
		[Cpp2IlInjected.Address(RVA = "0x1778A30", Offset = "0x1777430", VA = "0x181778A30")]
		public static bool CannotSell(Item item, ItemState state)
		{
			//Discarded unreachable code: IL_0048
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (!itemData.IsMissionItem())
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				bool flag = default(bool);
				if (!flag || flag)
				{
					if (state != null && state.ConsummableData != null)
					{
						Item item2 = state.ConsummableData.Item;
						ItemType itemType = default(ItemType);
						return itemType != ItemType.MemoryShard;
					}
					int num = 0;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E34")]
		[Cpp2IlInjected.Address(RVA = "0x1778E10", Offset = "0x1777810", VA = "0x181778E10")]
		static ShopSellItems()
		{
			Func<ShopSellItems> func = default(Func<ShopSellItems>);
			_parser = (MessageParser<ShopSellItems>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
