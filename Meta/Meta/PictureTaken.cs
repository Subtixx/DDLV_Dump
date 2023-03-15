using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000437")]
	public sealed class PictureTaken : IMessage<PictureTaken>, IMessage, IEquatable<PictureTaken>, IDeepCloneable<PictureTaken>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000438")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000439")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000D20")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000D21")]
				[OriginalName("Failure")]
				Failure
			}

			[Cpp2IlInjected.Token(Token = "0x200043A")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000D22")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000D23")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000D24")]
				public const int PhotoModeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000D25")]
				private PhotoModeType photoMode_;

				[Cpp2IlInjected.Token(Token = "0x4000D26")]
				public const int ItemIdsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4000D27")]
				private static readonly FieldCodec<int> _repeated_itemIds_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000D28")]
				private readonly RepeatedField<int> itemIds_;

				[Cpp2IlInjected.Token(Token = "0x4000D29")]
				public const int GardenItemIdsFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000D2A")]
				private static readonly FieldCodec<int> _repeated_gardenItemIds_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000D2B")]
				private readonly RepeatedField<int> gardenItemIds_;

				[Cpp2IlInjected.Token(Token = "0x4000D2C")]
				public const int SceneTypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000D2D")]
				private SceneType sceneType_;

				[Cpp2IlInjected.Token(Token = "0x17000788")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002940")]
					[Cpp2IlInjected.Address(RVA = "0x25CC450", Offset = "0x25CAE50", VA = "0x1825CC450")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000789")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002941")]
					[Cpp2IlInjected.Address(RVA = "0x25CBF50", Offset = "0x25CA950", VA = "0x1825CBF50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700078A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002942")]
					[Cpp2IlInjected.Address(RVA = "0x25CC6F0", Offset = "0x25CB0F0", VA = "0x1825CC6F0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700078B")]
				[DebuggerNonUserCode]
				public PhotoModeType PhotoMode
				{
					[Cpp2IlInjected.Token(Token = "0x6002946")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(PhotoModeType);
					}
					[Cpp2IlInjected.Token(Token = "0x6002947")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700078C")]
				[DebuggerNonUserCode]
				public RepeatedField<int> ItemIds
				{
					[Cpp2IlInjected.Token(Token = "0x6002948")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700078D")]
				[DebuggerNonUserCode]
				public RepeatedField<int> GardenItemIds
				{
					[Cpp2IlInjected.Token(Token = "0x6002949")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700078E")]
				[DebuggerNonUserCode]
				public SceneType SceneType
				{
					[Cpp2IlInjected.Token(Token = "0x600294A")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(SceneType);
					}
					[Cpp2IlInjected.Token(Token = "0x600294B")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002943")]
				[Cpp2IlInjected.Address(RVA = "0x25CB7C0", Offset = "0x25CA1C0", VA = "0x1825CB7C0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002944")]
				[Cpp2IlInjected.Address(RVA = "0x25CB300", Offset = "0x25C9D00", VA = "0x1825CB300")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002945")]
				[Cpp2IlInjected.Address(RVA = "0x25C5250", Offset = "0x25C3C50", VA = "0x1825C5250", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600294C")]
				[Cpp2IlInjected.Address(RVA = "0x25C5CC0", Offset = "0x25C46C0", VA = "0x1825C5CC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600294D")]
				[Cpp2IlInjected.Address(RVA = "0x25C6230", Offset = "0x25C4C30", VA = "0x1825C6230", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600294E")]
				[Cpp2IlInjected.Address(RVA = "0x25C7030", Offset = "0x25C5A30", VA = "0x1825C7030", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600294F")]
				[Cpp2IlInjected.Address(RVA = "0x25C8960", Offset = "0x25C7360", VA = "0x1825C8960", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002950")]
				[Cpp2IlInjected.Address(RVA = "0x25CA070", Offset = "0x25C8A70", VA = "0x1825CA070", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002951")]
				[Cpp2IlInjected.Address(RVA = "0x25C4920", Offset = "0x25C3320", VA = "0x1825C4920", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002952")]
				[Cpp2IlInjected.Address(RVA = "0x25C7360", Offset = "0x25C5D60", VA = "0x1825C7360", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002953")]
				[Cpp2IlInjected.Address(RVA = "0x25C76A0", Offset = "0x25C60A0", VA = "0x1825C76A0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002954")]
				[Cpp2IlInjected.Address(RVA = "0x25C64C0", Offset = "0x25C4EC0", VA = "0x1825C64C0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002955")]
				[Cpp2IlInjected.Address(RVA = "0x25C7D30", Offset = "0x25C6730", VA = "0x1825C7D30", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002956")]
				[Cpp2IlInjected.Address(RVA = "0x25C4F10", Offset = "0x25C3910", VA = "0x1825C4F10", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002957")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200043C")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000D2F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000D30")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000D31")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000D32")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000D33")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000D34")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700078F")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600295C")]
					[Cpp2IlInjected.Address(RVA = "0x25D67C0", Offset = "0x25D51C0", VA = "0x1825D67C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000790")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600295D")]
					[Cpp2IlInjected.Address(RVA = "0x25D6420", Offset = "0x25D4E20", VA = "0x1825D6420")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000791")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600295E")]
					[Cpp2IlInjected.Address(RVA = "0x25D6E20", Offset = "0x25D5820", VA = "0x1825D6E20", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000792")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002962")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002963")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000793")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002964")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002965")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000794")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002971")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002972")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600295F")]
				[Cpp2IlInjected.Address(RVA = "0x25D5550", Offset = "0x25D3F50", VA = "0x1825D5550")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002960")]
				[Cpp2IlInjected.Address(RVA = "0x25D58F0", Offset = "0x25D42F0", VA = "0x1825D58F0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002961")]
				[Cpp2IlInjected.Address(RVA = "0x25CFFB0", Offset = "0x25CE9B0", VA = "0x1825CFFB0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002966")]
				[Cpp2IlInjected.Address(RVA = "0x25D06B0", Offset = "0x25CF0B0", VA = "0x1825D06B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002967")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002968")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002969")]
				[Cpp2IlInjected.Address(RVA = "0x25D41D0", Offset = "0x25D2BD0", VA = "0x1825D41D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600296A")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600296B")]
				[Cpp2IlInjected.Address(RVA = "0x25CF0B0", Offset = "0x25CDAB0", VA = "0x1825CF0B0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600296C")]
				[Cpp2IlInjected.Address(RVA = "0x25D2900", Offset = "0x25D1300", VA = "0x1825D2900", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600296D")]
				[Cpp2IlInjected.Address(RVA = "0x25D3410", Offset = "0x25D1E10", VA = "0x1825D3410", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600296E")]
				[Cpp2IlInjected.Address(RVA = "0x25D1590", Offset = "0x25CFF90", VA = "0x1825D1590", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600296F")]
				[Cpp2IlInjected.Address(RVA = "0x25D3B20", Offset = "0x25D2520", VA = "0x1825D3B20", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002970")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002973")]
				[Cpp2IlInjected.Address(RVA = "0x25CE730", Offset = "0x25CD130", VA = "0x1825CE730", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000D1D")]
		private static readonly MessageParser<PictureTaken> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D1E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000785")]
		[DebuggerNonUserCode]
		public static MessageParser<PictureTaken> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600292E")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5450", VA = "0x1807B6A50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000786")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600292F")]
			[Cpp2IlInjected.Address(RVA = "0x7B6980", Offset = "0x7B5380", VA = "0x1807B6980")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000787")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002930")]
			[Cpp2IlInjected.Address(RVA = "0x7B6AB0", Offset = "0x7B54B0", VA = "0x1807B6AB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002931")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PictureTaken()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002932")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PictureTaken(PictureTaken other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002933")]
		[Cpp2IlInjected.Address(RVA = "0x7B66A0", Offset = "0x7B50A0", VA = "0x1807B66A0", Slot = "10")]
		[DebuggerNonUserCode]
		public PictureTaken Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PictureTaken pictureTaken = default(PictureTaken);
			pictureTaken.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (pictureTaken._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pictureTaken;
		}

		[Cpp2IlInjected.Token(Token = "0x6002934")]
		[Cpp2IlInjected.Address(RVA = "0x7B6720", Offset = "0x7B5120", VA = "0x1807B6720", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002935")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PictureTaken other)
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

		[Cpp2IlInjected.Token(Token = "0x6002936")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002937")]
		[Cpp2IlInjected.Address(RVA = "0x7B6810", Offset = "0x7B5210", VA = "0x1807B6810", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002938")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002939")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600293A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PictureTaken other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600293B")]
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

		[Cpp2IlInjected.Token(Token = "0x600293C")]
		[Cpp2IlInjected.Address(RVA = "0x7B67A0", Offset = "0x7B51A0", VA = "0x1807B67A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600293D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600293E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600293F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6870", Offset = "0x7B5270", VA = "0x1807B6870")]
		static PictureTaken()
		{
			Func<PictureTaken> func = default(Func<PictureTaken>);
			_parser = (MessageParser<PictureTaken>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
