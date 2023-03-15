using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200033D")]
	public sealed class StartFishing : IMessage<StartFishing>, IMessage, IEquatable<StartFishing>, IDeepCloneable<StartFishing>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200033E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200033F")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000A17")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000A18")]
				[OriginalName("NoFishingTool")]
				NoFishingTool,
				[Cpp2IlInjected.Token(Token = "0x4000A19")]
				[OriginalName("InvalidPendingFishID")]
				InvalidPendingFishId,
				[Cpp2IlInjected.Token(Token = "0x4000A1A")]
				[OriginalName("InvalidBodyOfWater")]
				InvalidBodyOfWater,
				[Cpp2IlInjected.Token(Token = "0x4000A1B")]
				[OriginalName("NoValidFish")]
				NoValidFish,
				[Cpp2IlInjected.Token(Token = "0x4000A1C")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana
			}

			[Cpp2IlInjected.Token(Token = "0x2000340")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000A1D")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000A1E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000A1F")]
				public const int SelectorFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000A20")]
				private PendingFishSelector selector_;

				[Cpp2IlInjected.Token(Token = "0x170005D8")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600205C")]
					[Cpp2IlInjected.Address(RVA = "0x15BE200", Offset = "0x15BCC00", VA = "0x1815BE200")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005D9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600205D")]
					[Cpp2IlInjected.Address(RVA = "0x15BDAE0", Offset = "0x15BC4E0", VA = "0x1815BDAE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005DA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600205E")]
					[Cpp2IlInjected.Address(RVA = "0x15BE320", Offset = "0x15BCD20", VA = "0x1815BE320", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005DB")]
				[DebuggerNonUserCode]
				public PendingFishSelector Selector
				{
					[Cpp2IlInjected.Token(Token = "0x6002062")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002063")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600205F")]
				[Cpp2IlInjected.Address(RVA = "0x15BD560", Offset = "0x15BBF60", VA = "0x1815BD560")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002060")]
				[Cpp2IlInjected.Address(RVA = "0x15BD940", Offset = "0x15BC340", VA = "0x1815BD940")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002061")]
				[Cpp2IlInjected.Address(RVA = "0x15B9E60", Offset = "0x15B8860", VA = "0x1815B9E60", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002064")]
				[Cpp2IlInjected.Address(RVA = "0x15BA210", Offset = "0x15B8C10", VA = "0x1815BA210", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002065")]
				[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002066")]
				[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002067")]
				[Cpp2IlInjected.Address(RVA = "0x15BBF90", Offset = "0x15BA990", VA = "0x1815BBF90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002068")]
				[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002069")]
				[Cpp2IlInjected.Address(RVA = "0x15B93B0", Offset = "0x15B7DB0", VA = "0x1815B93B0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600206A")]
				[Cpp2IlInjected.Address(RVA = "0x15BB4E0", Offset = "0x15B9EE0", VA = "0x1815BB4E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600206B")]
				[Cpp2IlInjected.Address(RVA = "0x15BB400", Offset = "0x15B9E00", VA = "0x1815BB400", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600206C")]
				[Cpp2IlInjected.Address(RVA = "0x15BAE20", Offset = "0x15B9820", VA = "0x1815BAE20", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600206D")]
				[Cpp2IlInjected.Address(RVA = "0x15BBB10", Offset = "0x15BA510", VA = "0x1815BBB10", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600206E")]
				[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600206F")]
				[Cpp2IlInjected.Address(RVA = "0x15BC490", Offset = "0x15BAE90", VA = "0x1815BC490", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000342")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000A22")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000A23")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000A24")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000A25")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000A26")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000A27")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170005DC")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002074")]
					[Cpp2IlInjected.Address(RVA = "0x15C9230", Offset = "0x15C7C30", VA = "0x1815C9230")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005DD")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002075")]
					[Cpp2IlInjected.Address(RVA = "0x15C8E70", Offset = "0x15C7870", VA = "0x1815C8E70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005DE")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002076")]
					[Cpp2IlInjected.Address(RVA = "0x15C96B0", Offset = "0x15C80B0", VA = "0x1815C96B0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005DF")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600207A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600207B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005E0")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600207C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600207D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005E1")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002089")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600208A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002077")]
				[Cpp2IlInjected.Address(RVA = "0x15C8250", Offset = "0x15C6C50", VA = "0x1815C8250")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002078")]
				[Cpp2IlInjected.Address(RVA = "0x15C7E10", Offset = "0x15C6810", VA = "0x1815C7E10")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002079")]
				[Cpp2IlInjected.Address(RVA = "0x15C3150", Offset = "0x15C1B50", VA = "0x1815C3150", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600207E")]
				[Cpp2IlInjected.Address(RVA = "0x15C4040", Offset = "0x15C2A40", VA = "0x1815C4040", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600207F")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002080")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002081")]
				[Cpp2IlInjected.Address(RVA = "0x15C6BB0", Offset = "0x15C55B0", VA = "0x1815C6BB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002082")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002083")]
				[Cpp2IlInjected.Address(RVA = "0x15C2CA0", Offset = "0x15C16A0", VA = "0x1815C2CA0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002084")]
				[Cpp2IlInjected.Address(RVA = "0x15C5F60", Offset = "0x15C4960", VA = "0x1815C5F60", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002085")]
				[Cpp2IlInjected.Address(RVA = "0x15C5C90", Offset = "0x15C4690", VA = "0x1815C5C90", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002086")]
				[Cpp2IlInjected.Address(RVA = "0x15C4C30", Offset = "0x15C3630", VA = "0x1815C4C30", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002087")]
				[Cpp2IlInjected.Address(RVA = "0x15C6950", Offset = "0x15C5350", VA = "0x1815C6950", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002088")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600208B")]
				[Cpp2IlInjected.Address(RVA = "0x15BF880", Offset = "0x15BE280", VA = "0x1815BF880", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600208C")]
				[Cpp2IlInjected.Address(RVA = "0x15C62A0", Offset = "0x15C4CA0", VA = "0x1815C62A0")]
				private static float SelectRandomFishMass(Random random, FishItemData chosenFish)
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600208D")]
				[Cpp2IlInjected.Address(RVA = "0x15C6EB0", Offset = "0x15C58B0", VA = "0x1815C6EB0")]
				private static bool TryGetFishItemData(Item fishItem, out FishItemData fishData)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000A14")]
		private static readonly MessageParser<StartFishing> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A15")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170005D5")]
		[DebuggerNonUserCode]
		public static MessageParser<StartFishing> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600204A")]
			[Cpp2IlInjected.Address(RVA = "0xC032D0", Offset = "0xC01CD0", VA = "0x180C032D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600204B")]
			[Cpp2IlInjected.Address(RVA = "0xC03200", Offset = "0xC01C00", VA = "0x180C03200")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600204C")]
			[Cpp2IlInjected.Address(RVA = "0xC03330", Offset = "0xC01D30", VA = "0x180C03330", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600204D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StartFishing()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600204E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StartFishing(StartFishing other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600204F")]
		[Cpp2IlInjected.Address(RVA = "0xC02F20", Offset = "0xC01920", VA = "0x180C02F20", Slot = "10")]
		[DebuggerNonUserCode]
		public StartFishing Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StartFishing startFishing = default(StartFishing);
			startFishing.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (startFishing._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return startFishing;
		}

		[Cpp2IlInjected.Token(Token = "0x6002050")]
		[Cpp2IlInjected.Address(RVA = "0xC02FA0", Offset = "0xC019A0", VA = "0x180C02FA0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002051")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StartFishing other)
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

		[Cpp2IlInjected.Token(Token = "0x6002052")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002053")]
		[Cpp2IlInjected.Address(RVA = "0xC03090", Offset = "0xC01A90", VA = "0x180C03090", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002054")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002055")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002056")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StartFishing other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002057")]
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

		[Cpp2IlInjected.Token(Token = "0x6002058")]
		[Cpp2IlInjected.Address(RVA = "0xC03020", Offset = "0xC01A20", VA = "0x180C03020", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002059")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600205A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600205B")]
		[Cpp2IlInjected.Address(RVA = "0xC030F0", Offset = "0xC01AF0", VA = "0x180C030F0")]
		static StartFishing()
		{
			Func<StartFishing> func = default(Func<StartFishing>);
			_parser = (MessageParser<StartFishing>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
