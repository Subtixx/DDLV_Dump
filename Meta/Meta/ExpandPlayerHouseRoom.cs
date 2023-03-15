using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004FF")]
	public sealed class ExpandPlayerHouseRoom : IMessage<ExpandPlayerHouseRoom>, IMessage, IEquatable<ExpandPlayerHouseRoom>, IDeepCloneable<ExpandPlayerHouseRoom>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000500")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000501")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000F78")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000F79")]
				[OriginalName("InvalidFloor")]
				InvalidFloor,
				[Cpp2IlInjected.Token(Token = "0x4000F7A")]
				[OriginalName("InvalidRoom")]
				InvalidRoom,
				[Cpp2IlInjected.Token(Token = "0x4000F7B")]
				[OriginalName("CannotExpandRoom")]
				CannotExpandRoom,
				[Cpp2IlInjected.Token(Token = "0x4000F7C")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency
			}

			[Cpp2IlInjected.Token(Token = "0x2000502")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F7D")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F7E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F7F")]
				public const int FloorIndexFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F80")]
				private int floorIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000F81")]
				public const int RoomSlotFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000F82")]
				private House.Types.RoomSlot roomSlot_;

				[Cpp2IlInjected.Token(Token = "0x170008ED")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003092")]
					[Cpp2IlInjected.Address(RVA = "0x1E13890", Offset = "0x1E12290", VA = "0x181E13890")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003093")]
					[Cpp2IlInjected.Address(RVA = "0x1E135B0", Offset = "0x1E11FB0", VA = "0x181E135B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003094")]
					[Cpp2IlInjected.Address(RVA = "0x1E14310", Offset = "0x1E12D10", VA = "0x181E14310", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F0")]
				[DebuggerNonUserCode]
				public int FloorIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6003098")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6003099")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F1")]
				[DebuggerNonUserCode]
				public House.Types.RoomSlot RoomSlot
				{
					[Cpp2IlInjected.Token(Token = "0x600309A")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(House.Types.RoomSlot);
					}
					[Cpp2IlInjected.Token(Token = "0x600309B")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003095")]
				[Cpp2IlInjected.Address(RVA = "0x1E12C00", Offset = "0x1E11600", VA = "0x181E12C00")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003096")]
				[Cpp2IlInjected.Address(RVA = "0x1E12F00", Offset = "0x1E11900", VA = "0x181E12F00")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003097")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D200", Offset = "0x1E0BC00", VA = "0x181E0D200", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600309C")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D600", Offset = "0x1E0C000", VA = "0x181E0D600", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600309D")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600309E")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600309F")]
				[Cpp2IlInjected.Address(RVA = "0x1E10510", Offset = "0x1E0EF10", VA = "0x181E10510", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030A0")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030A1")]
				[Cpp2IlInjected.Address(RVA = "0x1E0C1D0", Offset = "0x1E0ABD0", VA = "0x181E0C1D0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60030A2")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030A3")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030A4")]
				[Cpp2IlInjected.Address(RVA = "0x1E0E9C0", Offset = "0x1E0D3C0", VA = "0x181E0E9C0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030A5")]
				[Cpp2IlInjected.Address(RVA = "0x1E0FA50", Offset = "0x1E0E450", VA = "0x181E0FA50", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030A6")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030A7")]
				[Cpp2IlInjected.Address(RVA = "0x1E10E40", Offset = "0x1E0F840", VA = "0x181E10E40", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000504")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F84")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F85")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F86")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F87")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000F88")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F89")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170008F2")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60030AC")]
					[Cpp2IlInjected.Address(RVA = "0x1E20680", Offset = "0x1E1F080", VA = "0x181E20680")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F3")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60030AD")]
					[Cpp2IlInjected.Address(RVA = "0x1E1FEA0", Offset = "0x1E1E8A0", VA = "0x181E1FEA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F4")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60030AE")]
					[Cpp2IlInjected.Address(RVA = "0x1E20C80", Offset = "0x1E1F680", VA = "0x181E20C80", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F5")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60030B2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60030B3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F6")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60030B4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60030B5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F7")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60030C1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60030C2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60030AF")]
				[Cpp2IlInjected.Address(RVA = "0x1E1F4F0", Offset = "0x1E1DEF0", VA = "0x181E1F4F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030B0")]
				[Cpp2IlInjected.Address(RVA = "0x1E1EDD0", Offset = "0x1E1D7D0", VA = "0x181E1EDD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030B1")]
				[Cpp2IlInjected.Address(RVA = "0x1E197C0", Offset = "0x1E181C0", VA = "0x181E197C0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030B6")]
				[Cpp2IlInjected.Address(RVA = "0x1E1A2C0", Offset = "0x1E18CC0", VA = "0x181E1A2C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60030B7")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60030B8")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60030B9")]
				[Cpp2IlInjected.Address(RVA = "0x1E1DC60", Offset = "0x1E1C660", VA = "0x181E1DC60", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030BA")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030BB")]
				[Cpp2IlInjected.Address(RVA = "0x1E18B30", Offset = "0x1E17530", VA = "0x181E18B30", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60030BC")]
				[Cpp2IlInjected.Address(RVA = "0x1E1B3E0", Offset = "0x1E19DE0", VA = "0x181E1B3E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030BD")]
				[Cpp2IlInjected.Address(RVA = "0x1E1BB50", Offset = "0x1E1A550", VA = "0x181E1BB50", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030BE")]
				[Cpp2IlInjected.Address(RVA = "0x1E1AB50", Offset = "0x1E19550", VA = "0x181E1AB50", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030BF")]
				[Cpp2IlInjected.Address(RVA = "0x1E1D5D0", Offset = "0x1E1BFD0", VA = "0x181E1D5D0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030C0")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030C3")]
				[Cpp2IlInjected.Address(RVA = "0x1E16050", Offset = "0x1E14A50", VA = "0x181E16050", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000F75")]
		private static readonly MessageParser<ExpandPlayerHouseRoom> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F76")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170008EA")]
		[DebuggerNonUserCode]
		public static MessageParser<ExpandPlayerHouseRoom> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003080")]
			[Cpp2IlInjected.Address(RVA = "0x17F9470", Offset = "0x17F7E70", VA = "0x1817F9470")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003081")]
			[Cpp2IlInjected.Address(RVA = "0x17F93A0", Offset = "0x17F7DA0", VA = "0x1817F93A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003082")]
			[Cpp2IlInjected.Address(RVA = "0x17F94D0", Offset = "0x17F7ED0", VA = "0x1817F94D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003083")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ExpandPlayerHouseRoom()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6003084")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ExpandPlayerHouseRoom(ExpandPlayerHouseRoom other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003085")]
		[Cpp2IlInjected.Address(RVA = "0x17F90C0", Offset = "0x17F7AC0", VA = "0x1817F90C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ExpandPlayerHouseRoom Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ExpandPlayerHouseRoom expandPlayerHouseRoom = default(ExpandPlayerHouseRoom);
			expandPlayerHouseRoom.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (expandPlayerHouseRoom._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return expandPlayerHouseRoom;
		}

		[Cpp2IlInjected.Token(Token = "0x6003086")]
		[Cpp2IlInjected.Address(RVA = "0x17F9140", Offset = "0x17F7B40", VA = "0x1817F9140", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003087")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ExpandPlayerHouseRoom other)
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

		[Cpp2IlInjected.Token(Token = "0x6003088")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003089")]
		[Cpp2IlInjected.Address(RVA = "0x17F9230", Offset = "0x17F7C30", VA = "0x1817F9230", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600308A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600308B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600308C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ExpandPlayerHouseRoom other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600308D")]
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

		[Cpp2IlInjected.Token(Token = "0x600308E")]
		[Cpp2IlInjected.Address(RVA = "0x17F91C0", Offset = "0x17F7BC0", VA = "0x1817F91C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600308F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003090")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003091")]
		[Cpp2IlInjected.Address(RVA = "0x17F9290", Offset = "0x17F7C90", VA = "0x1817F9290")]
		static ExpandPlayerHouseRoom()
		{
			Func<ExpandPlayerHouseRoom> func = default(Func<ExpandPlayerHouseRoom>);
			_parser = (MessageParser<ExpandPlayerHouseRoom>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
