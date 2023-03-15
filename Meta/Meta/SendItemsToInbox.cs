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
	[Cpp2IlInjected.Token(Token = "0x20005C2")]
	public sealed class SendItemsToInbox : IMessage<SendItemsToInbox>, IMessage, IEquatable<SendItemsToInbox>, IDeepCloneable<SendItemsToInbox>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005C3")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20005C4")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400116D")]
				[OriginalName("Success")]
				Success
			}

			[Cpp2IlInjected.Token(Token = "0x20005C5")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400116E")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400116F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001170")]
				public const int ItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001171")]
				private static readonly FieldCodec<InboxItemReward> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001172")]
				private readonly RepeatedField<InboxItemReward> items_;

				[Cpp2IlInjected.Token(Token = "0x4001173")]
				public const int ReasonFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001174")]
				private ItemsSentToInboxReason reason_;

				[Cpp2IlInjected.Token(Token = "0x17000A34")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003789")]
					[Cpp2IlInjected.Address(RVA = "0x2B513C0", Offset = "0x2B4FDC0", VA = "0x182B513C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A35")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600378A")]
					[Cpp2IlInjected.Address(RVA = "0x2B50B40", Offset = "0x2B4F540", VA = "0x182B50B40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A36")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600378B")]
					[Cpp2IlInjected.Address(RVA = "0x2B51CD0", Offset = "0x2B506D0", VA = "0x182B51CD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A37")]
				[DebuggerNonUserCode]
				public RepeatedField<InboxItemReward> Items
				{
					[Cpp2IlInjected.Token(Token = "0x600378F")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A38")]
				[DebuggerNonUserCode]
				public ItemsSentToInboxReason Reason
				{
					[Cpp2IlInjected.Token(Token = "0x6003790")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(ItemsSentToInboxReason);
					}
					[Cpp2IlInjected.Token(Token = "0x6003791")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600378C")]
				[Cpp2IlInjected.Address(RVA = "0x2B50850", Offset = "0x2B4F250", VA = "0x182B50850")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600378D")]
				[Cpp2IlInjected.Address(RVA = "0x2B50400", Offset = "0x2B4EE00", VA = "0x182B50400")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600378E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A3E0", Offset = "0x2B48DE0", VA = "0x182B4A3E0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003792")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AEC0", Offset = "0x2B498C0", VA = "0x182B4AEC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003793")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B0F0", Offset = "0x2B49AF0", VA = "0x182B4B0F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003794")]
				[Cpp2IlInjected.Address(RVA = "0x18BBB60", Offset = "0x18BA560", VA = "0x1818BBB60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003795")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E090", Offset = "0x2B4CA90", VA = "0x182B4E090", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003796")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EDA0", Offset = "0x2B4D7A0", VA = "0x182B4EDA0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003797")]
				[Cpp2IlInjected.Address(RVA = "0x2B49790", Offset = "0x2B48190", VA = "0x182B49790", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003798")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CA60", Offset = "0x2B4B460", VA = "0x182B4CA60", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003799")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CF60", Offset = "0x2B4B960", VA = "0x182B4CF60", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600379A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BB30", Offset = "0x2B4A530", VA = "0x182B4BB30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600379B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D5A0", Offset = "0x2B4BFA0", VA = "0x182B4D5A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600379C")]
				[Cpp2IlInjected.Address(RVA = "0x2B49D30", Offset = "0x2B48730", VA = "0x182B49D30", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20005C7")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001176")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001177")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001178")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001179")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400117A")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400117B")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000A39")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60037A1")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CBC0", Offset = "0x2B5B5C0", VA = "0x182B5CBC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A3A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60037A2")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C860", Offset = "0x2B5B260", VA = "0x182B5C860")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A3B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60037A3")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D760", Offset = "0x2B5C160", VA = "0x182B5D760", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A3C")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60037A7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60037A8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A3D")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60037A9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60037AA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A3E")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60037B6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60037B7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60037A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B5B990", Offset = "0x2B5A390", VA = "0x182B5B990")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BCD0", Offset = "0x2B5A6D0", VA = "0x182B5BCD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B55020", Offset = "0x2B53A20", VA = "0x182B55020", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B55F90", Offset = "0x2B54990", VA = "0x182B55F90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60037AC")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60037AD")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60037AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B5A2D0", Offset = "0x2B58CD0", VA = "0x182B5A2D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037AF")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B541C0", Offset = "0x2B52BC0", VA = "0x182B541C0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60037B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B58330", Offset = "0x2B56D30", VA = "0x182B58330", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B589D0", Offset = "0x2B573D0", VA = "0x182B589D0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B56B80", Offset = "0x2B55580", VA = "0x182B56B80", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B59A40", Offset = "0x2B58440", VA = "0x182B59A40", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037B5")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B52320", Offset = "0x2B50D20", VA = "0x182B52320", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400116A")]
		private static readonly MessageParser<SendItemsToInbox> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400116B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000A31")]
		[DebuggerNonUserCode]
		public static MessageParser<SendItemsToInbox> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003777")]
			[Cpp2IlInjected.Address(RVA = "0x1773410", Offset = "0x1771E10", VA = "0x181773410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A32")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003778")]
			[Cpp2IlInjected.Address(RVA = "0x1773340", Offset = "0x1771D40", VA = "0x181773340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A33")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003779")]
			[Cpp2IlInjected.Address(RVA = "0x1773470", Offset = "0x1771E70", VA = "0x181773470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600377A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SendItemsToInbox()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600377B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SendItemsToInbox(SendItemsToInbox other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600377C")]
		[Cpp2IlInjected.Address(RVA = "0x1773060", Offset = "0x1771A60", VA = "0x181773060", Slot = "10")]
		[DebuggerNonUserCode]
		public SendItemsToInbox Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SendItemsToInbox sendItemsToInbox = default(SendItemsToInbox);
			sendItemsToInbox.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (sendItemsToInbox._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return sendItemsToInbox;
		}

		[Cpp2IlInjected.Token(Token = "0x600377D")]
		[Cpp2IlInjected.Address(RVA = "0x17730E0", Offset = "0x1771AE0", VA = "0x1817730E0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600377E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SendItemsToInbox other)
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

		[Cpp2IlInjected.Token(Token = "0x600377F")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003780")]
		[Cpp2IlInjected.Address(RVA = "0x17731D0", Offset = "0x1771BD0", VA = "0x1817731D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003781")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003782")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003783")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SendItemsToInbox other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003784")]
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

		[Cpp2IlInjected.Token(Token = "0x6003785")]
		[Cpp2IlInjected.Address(RVA = "0x1773160", Offset = "0x1771B60", VA = "0x181773160", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003786")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003787")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003788")]
		[Cpp2IlInjected.Address(RVA = "0x1773230", Offset = "0x1771C30", VA = "0x181773230")]
		static SendItemsToInbox()
		{
			Func<SendItemsToInbox> func = default(Func<SendItemsToInbox>);
			_parser = (MessageParser<SendItemsToInbox>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
