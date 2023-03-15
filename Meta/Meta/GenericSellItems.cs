using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200048A")]
	public sealed class GenericSellItems : IMessage<GenericSellItems>, IMessage, IEquatable<GenericSellItems>, IDeepCloneable<GenericSellItems>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200048B")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200048C")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000E27")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4000E28")]
				[OriginalName("InvalidItem")]
				InvalidItem = 2
			}

			[Cpp2IlInjected.Token(Token = "0x200048D")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E29")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E2A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E2B")]
				public const int ItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000E2C")]
				private static readonly FieldCodec<ItemAmount> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E2D")]
				private readonly RepeatedField<ItemAmount> items_;

				[Cpp2IlInjected.Token(Token = "0x1700081E")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002C48")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FDF0", Offset = "0x1E7E7F0", VA = "0x181E7FDF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700081F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C49")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FB90", Offset = "0x1E7E590", VA = "0x181E7FB90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000820")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C4A")]
					[Cpp2IlInjected.Address(RVA = "0x1E808D0", Offset = "0x1E7F2D0", VA = "0x181E808D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000821")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemAmount> Items
				{
					[Cpp2IlInjected.Token(Token = "0x6002C4E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002C4B")]
				[Cpp2IlInjected.Address(RVA = "0x1E7EFD0", Offset = "0x1E7D9D0", VA = "0x181E7EFD0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C4C")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F390", Offset = "0x1E7DD90", VA = "0x181E7F390")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C4D")]
				[Cpp2IlInjected.Address(RVA = "0x1E797E0", Offset = "0x1E781E0", VA = "0x181E797E0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C4F")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A410", Offset = "0x1E78E10", VA = "0x181E7A410", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C50")]
				[Cpp2IlInjected.Address(RVA = "0x1E79CF0", Offset = "0x1E786F0", VA = "0x181E79CF0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C51")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C52")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C7B0", Offset = "0x1E7B1B0", VA = "0x181E7C7B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C53")]
				[Cpp2IlInjected.Address(RVA = "0x1E7D9C0", Offset = "0x1E7C3C0", VA = "0x181E7D9C0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C54")]
				[Cpp2IlInjected.Address(RVA = "0x1E78FB0", Offset = "0x1E779B0", VA = "0x181E78FB0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C55")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B480", Offset = "0x1E79E80", VA = "0x181E7B480", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C56")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B6E0", Offset = "0x1E7A0E0", VA = "0x181E7B6E0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C57")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A840", Offset = "0x1E79240", VA = "0x181E7A840", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C58")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C4F0", Offset = "0x1E7AEF0", VA = "0x181E7C4F0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C59")]
				[Cpp2IlInjected.Address(RVA = "0x1E79290", Offset = "0x1E77C90", VA = "0x181E79290", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5A")]
				[Cpp2IlInjected.Address(RVA = "0x1E7D6C0", Offset = "0x1E7C0C0", VA = "0x181E7D6C0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200048F")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E2F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E30")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E31")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E32")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000E33")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E34")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000822")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002C5F")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F400", Offset = "0x1E8DE00", VA = "0x181E8F400")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000823")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C60")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EF60", Offset = "0x1E8D960", VA = "0x181E8EF60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000824")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C61")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F940", Offset = "0x1E8E340", VA = "0x181E8F940", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000825")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002C65")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C66")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000826")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002C67")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002C68")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000827")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002C74")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C75")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002C62")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D9A0", Offset = "0x1E8C3A0", VA = "0x181E8D9A0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C63")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E100", Offset = "0x1E8CB00", VA = "0x181E8E100")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C64")]
				[Cpp2IlInjected.Address(RVA = "0x1E85A70", Offset = "0x1E84470", VA = "0x181E85A70", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C69")]
				[Cpp2IlInjected.Address(RVA = "0x1E86B40", Offset = "0x1E85540", VA = "0x181E86B40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C6A")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C6B")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C6C")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B7F0", Offset = "0x1E8A1F0", VA = "0x181E8B7F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C6D")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C6E")]
				[Cpp2IlInjected.Address(RVA = "0x1E84990", Offset = "0x1E83390", VA = "0x181E84990", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C6F")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A2A0", Offset = "0x1E88CA0", VA = "0x181E8A2A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C70")]
				[Cpp2IlInjected.Address(RVA = "0x1E88D00", Offset = "0x1E87700", VA = "0x181E88D00", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C71")]
				[Cpp2IlInjected.Address(RVA = "0x1E877C0", Offset = "0x1E861C0", VA = "0x181E877C0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C72")]
				[Cpp2IlInjected.Address(RVA = "0x1E8AC20", Offset = "0x1E89620", VA = "0x181E8AC20", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C73")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C76")]
				[Cpp2IlInjected.Address(RVA = "0x1E82DB0", Offset = "0x1E817B0", VA = "0x181E82DB0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000E24")]
		private static readonly MessageParser<GenericSellItems> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E25")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700081B")]
		[DebuggerNonUserCode]
		public static MessageParser<GenericSellItems> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002C36")]
			[Cpp2IlInjected.Address(RVA = "0x1D02AE0", Offset = "0x1D014E0", VA = "0x181D02AE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C37")]
			[Cpp2IlInjected.Address(RVA = "0x1D02A10", Offset = "0x1D01410", VA = "0x181D02A10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C38")]
			[Cpp2IlInjected.Address(RVA = "0x1D02B40", Offset = "0x1D01540", VA = "0x181D02B40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C39")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GenericSellItems()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GenericSellItems(GenericSellItems other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3B")]
		[Cpp2IlInjected.Address(RVA = "0x1D02730", Offset = "0x1D01130", VA = "0x181D02730", Slot = "10")]
		[DebuggerNonUserCode]
		public GenericSellItems Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GenericSellItems genericSellItems = default(GenericSellItems);
			genericSellItems.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (genericSellItems._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return genericSellItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3C")]
		[Cpp2IlInjected.Address(RVA = "0x1D027B0", Offset = "0x1D011B0", VA = "0x181D027B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C3D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GenericSellItems other)
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

		[Cpp2IlInjected.Token(Token = "0x6002C3E")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3F")]
		[Cpp2IlInjected.Address(RVA = "0x1D028A0", Offset = "0x1D012A0", VA = "0x181D028A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C40")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C41")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C42")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GenericSellItems other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C43")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C44")]
		[Cpp2IlInjected.Address(RVA = "0x1D02830", Offset = "0x1D01230", VA = "0x181D02830", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C45")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C46")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C47")]
		[Cpp2IlInjected.Address(RVA = "0x1D02900", Offset = "0x1D01300", VA = "0x181D02900")]
		static GenericSellItems()
		{
			Func<GenericSellItems> func = default(Func<GenericSellItems>);
			_parser = (MessageParser<GenericSellItems>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
