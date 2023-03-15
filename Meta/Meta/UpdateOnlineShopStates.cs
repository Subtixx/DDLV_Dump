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
	[Cpp2IlInjected.Token(Token = "0x20005D2")]
	public sealed class UpdateOnlineShopStates : IMessage<UpdateOnlineShopStates>, IMessage, IEquatable<UpdateOnlineShopStates>, IDeepCloneable<UpdateOnlineShopStates>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005D3")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20005D4")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4001198")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4001199")]
				[OriginalName("NoStoreFound")]
				NoStoreFound
			}

			[Cpp2IlInjected.Token(Token = "0x20005D5")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400119A")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400119B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400119C")]
				public const int StoresFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400119D")]
				private static readonly MapField<string, OnlineStoreData>.Codec _map_stores_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400119E")]
				private readonly MapField<string, OnlineStoreData> stores_;

				[Cpp2IlInjected.Token(Token = "0x400119F")]
				public const int RemoveIsNewFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40011A0")]
				private bool removeIsNew_;

				[Cpp2IlInjected.Token(Token = "0x17000A50")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600381D")]
					[Cpp2IlInjected.Address(RVA = "0x1D70F40", Offset = "0x1D6F940", VA = "0x181D70F40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A51")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600381E")]
					[Cpp2IlInjected.Address(RVA = "0x1D704E0", Offset = "0x1D6EEE0", VA = "0x181D704E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A52")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600381F")]
					[Cpp2IlInjected.Address(RVA = "0x1D71660", Offset = "0x1D70060", VA = "0x181D71660", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A53")]
				[DebuggerNonUserCode]
				public MapField<string, OnlineStoreData> Stores
				{
					[Cpp2IlInjected.Token(Token = "0x6003823")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A54")]
				[DebuggerNonUserCode]
				public bool RemoveIsNew
				{
					[Cpp2IlInjected.Token(Token = "0x6003824")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6003825")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003820")]
				[Cpp2IlInjected.Address(RVA = "0x1D70350", Offset = "0x1D6ED50", VA = "0x181D70350")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003821")]
				[Cpp2IlInjected.Address(RVA = "0x1D6FED0", Offset = "0x1D6E8D0", VA = "0x181D6FED0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003822")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A090", Offset = "0x1D68A90", VA = "0x181D6A090", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003826")]
				[Cpp2IlInjected.Address(RVA = "0x1D6AC50", Offset = "0x1D69650", VA = "0x181D6AC50", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003827")]
				[Cpp2IlInjected.Address(RVA = "0x1D6AED0", Offset = "0x1D698D0", VA = "0x181D6AED0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003828")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003829")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D7D0", Offset = "0x1D6C1D0", VA = "0x181D6D7D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600382A")]
				[Cpp2IlInjected.Address(RVA = "0x1D6E620", Offset = "0x1D6D020", VA = "0x181D6E620", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600382B")]
				[Cpp2IlInjected.Address(RVA = "0x1D69AE0", Offset = "0x1D684E0", VA = "0x181D69AE0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600382C")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C6F0", Offset = "0x1D6B0F0", VA = "0x181D6C6F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600382D")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C080", Offset = "0x1D6AA80", VA = "0x181D6C080", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600382E")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B4C0", Offset = "0x1D69EC0", VA = "0x181D6B4C0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600382F")]
				[Cpp2IlInjected.Address(RVA = "0x1D6CFB0", Offset = "0x1D6B9B0", VA = "0x181D6CFB0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003830")]
				[Cpp2IlInjected.Address(RVA = "0x1D69C90", Offset = "0x1D68690", VA = "0x181D69C90", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20005D7")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40011A2")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40011A3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40011A4")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40011A5")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40011A6")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40011A7")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000A55")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003835")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F250", Offset = "0x1D7DC50", VA = "0x181D7F250")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A56")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003836")]
					[Cpp2IlInjected.Address(RVA = "0x1D7EC50", Offset = "0x1D7D650", VA = "0x181D7EC50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A57")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003837")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F9F0", Offset = "0x1D7E3F0", VA = "0x181D7F9F0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A58")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600383B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600383C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A59")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600383D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600383E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A5A")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600384A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600384B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003838")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E6B0", Offset = "0x1D7D0B0", VA = "0x181D7E6B0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003839")]
				[Cpp2IlInjected.Address(RVA = "0x1D7DD10", Offset = "0x1D7C710", VA = "0x181D7DD10")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600383A")]
				[Cpp2IlInjected.Address(RVA = "0x1D76A60", Offset = "0x1D75460", VA = "0x181D76A60", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600383F")]
				[Cpp2IlInjected.Address(RVA = "0x1D77980", Offset = "0x1D76380", VA = "0x181D77980", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003840")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003841")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003842")]
				[Cpp2IlInjected.Address(RVA = "0x1D7BE00", Offset = "0x1D7A800", VA = "0x181D7BE00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003843")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003844")]
				[Cpp2IlInjected.Address(RVA = "0x1D75C40", Offset = "0x1D74640", VA = "0x181D75C40", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003845")]
				[Cpp2IlInjected.Address(RVA = "0x1D7AB10", Offset = "0x1D79510", VA = "0x181D7AB10", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003846")]
				[Cpp2IlInjected.Address(RVA = "0x1D7A100", Offset = "0x1D78B00", VA = "0x181D7A100", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003847")]
				[Cpp2IlInjected.Address(RVA = "0x1D78840", Offset = "0x1D77240", VA = "0x181D78840", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003848")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B450", Offset = "0x1D79E50", VA = "0x181D7B450", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003849")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600384C")]
				[Cpp2IlInjected.Address(RVA = "0x1D72550", Offset = "0x1D70F50", VA = "0x181D72550", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001195")]
		private static readonly MessageParser<UpdateOnlineShopStates> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001196")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000A4D")]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateOnlineShopStates> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600380B")]
			[Cpp2IlInjected.Address(RVA = "0x15DAF00", Offset = "0x15D9900", VA = "0x1815DAF00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A4E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600380C")]
			[Cpp2IlInjected.Address(RVA = "0x15DAE30", Offset = "0x15D9830", VA = "0x1815DAE30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A4F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600380D")]
			[Cpp2IlInjected.Address(RVA = "0x15DAF60", Offset = "0x15D9960", VA = "0x1815DAF60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600380E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpdateOnlineShopStates()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600380F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UpdateOnlineShopStates(UpdateOnlineShopStates other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003810")]
		[Cpp2IlInjected.Address(RVA = "0x15DAB50", Offset = "0x15D9550", VA = "0x1815DAB50", Slot = "10")]
		[DebuggerNonUserCode]
		public UpdateOnlineShopStates Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UpdateOnlineShopStates updateOnlineShopStates = default(UpdateOnlineShopStates);
			updateOnlineShopStates.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (updateOnlineShopStates._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return updateOnlineShopStates;
		}

		[Cpp2IlInjected.Token(Token = "0x6003811")]
		[Cpp2IlInjected.Address(RVA = "0x15DABD0", Offset = "0x15D95D0", VA = "0x1815DABD0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003812")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpdateOnlineShopStates other)
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

		[Cpp2IlInjected.Token(Token = "0x6003813")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003814")]
		[Cpp2IlInjected.Address(RVA = "0x15DACC0", Offset = "0x15D96C0", VA = "0x1815DACC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003815")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003816")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003817")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateOnlineShopStates other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003818")]
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

		[Cpp2IlInjected.Token(Token = "0x6003819")]
		[Cpp2IlInjected.Address(RVA = "0x15DAC50", Offset = "0x15D9650", VA = "0x1815DAC50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600381A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600381B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600381C")]
		[Cpp2IlInjected.Address(RVA = "0x15DAD20", Offset = "0x15D9720", VA = "0x1815DAD20")]
		static UpdateOnlineShopStates()
		{
			Func<UpdateOnlineShopStates> func = default(Func<UpdateOnlineShopStates>);
			_parser = (MessageParser<UpdateOnlineShopStates>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
