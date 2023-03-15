using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000507")]
	public sealed class ManagePlayerHouseRoom : IMessage<ManagePlayerHouseRoom>, IMessage, IEquatable<ManagePlayerHouseRoom>, IDeepCloneable<ManagePlayerHouseRoom>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000508")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000509")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000F8F")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000F90")]
				[OriginalName("InvalidFloor")]
				InvalidFloor,
				[Cpp2IlInjected.Token(Token = "0x4000F91")]
				[OriginalName("CannotAddRooms")]
				CannotAddRooms,
				[Cpp2IlInjected.Token(Token = "0x4000F92")]
				[OriginalName("NothingToChange")]
				NothingToChange,
				[Cpp2IlInjected.Token(Token = "0x4000F93")]
				[OriginalName("InvalidAdditionalRoomIndex")]
				InvalidAdditionalRoomIndex,
				[Cpp2IlInjected.Token(Token = "0x4000F94")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000F95")]
				[OriginalName("NeedUpgrade")]
				NeedUpgrade
			}

			[Cpp2IlInjected.Token(Token = "0x200050A")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F96")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F97")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F98")]
				public const int FloorIndexFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F99")]
				private int floorIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000F9A")]
				public const int RoomSlotFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000F9B")]
				private House.Types.RoomSlot roomSlot_;

				[Cpp2IlInjected.Token(Token = "0x4000F9C")]
				public const int AdditionalRoomIndexFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000F9D")]
				private static readonly FieldCodec<int?> _single_additionalRoomIndex_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F9E")]
				private int? additionalRoomIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000F9F")]
				public const int RoomNameFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000FA0")]
				private string roomName_;

				[Cpp2IlInjected.Token(Token = "0x170008FB")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60030DD")]
					[Cpp2IlInjected.Address(RVA = "0x1E430F0", Offset = "0x1E41AF0", VA = "0x181E430F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008FC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60030DE")]
					[Cpp2IlInjected.Address(RVA = "0x1E42E10", Offset = "0x1E41810", VA = "0x181E42E10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008FD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60030DF")]
					[Cpp2IlInjected.Address(RVA = "0x1E437B0", Offset = "0x1E421B0", VA = "0x181E437B0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008FE")]
				[DebuggerNonUserCode]
				public int FloorIndex
				{
					[Cpp2IlInjected.Token(Token = "0x60030E3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60030E4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008FF")]
				[DebuggerNonUserCode]
				public House.Types.RoomSlot RoomSlot
				{
					[Cpp2IlInjected.Token(Token = "0x60030E5")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(House.Types.RoomSlot);
					}
					[Cpp2IlInjected.Token(Token = "0x60030E6")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000900")]
				[DebuggerNonUserCode]
				public int? AdditionalRoomIndex
				{
					[Cpp2IlInjected.Token(Token = "0x60030E7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60030E8")]
					[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000901")]
				[DebuggerNonUserCode]
				public string RoomName
				{
					[Cpp2IlInjected.Token(Token = "0x60030E9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60030EA")]
					[Cpp2IlInjected.Address(RVA = "0x1E438E0", Offset = "0x1E422E0", VA = "0x181E438E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60030E0")]
				[Cpp2IlInjected.Address(RVA = "0x1E42680", Offset = "0x1E41080", VA = "0x181E42680")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030E1")]
				[Cpp2IlInjected.Address(RVA = "0x1E42C50", Offset = "0x1E41650", VA = "0x181E42C50")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030E2")]
				[Cpp2IlInjected.Address(RVA = "0x1E3DA30", Offset = "0x1E3C430", VA = "0x181E3DA30", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030EB")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E550", Offset = "0x1E3CF50", VA = "0x181E3E550", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60030EC")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E670", Offset = "0x1E3D070", VA = "0x181E3E670", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60030ED")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F080", Offset = "0x1E3DA80", VA = "0x181E3F080", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60030EE")]
				[Cpp2IlInjected.Address(RVA = "0x1E40B70", Offset = "0x1E3F570", VA = "0x181E40B70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030EF")]
				[Cpp2IlInjected.Address(RVA = "0x1E41770", Offset = "0x1E40170", VA = "0x181E41770", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030F0")]
				[Cpp2IlInjected.Address(RVA = "0x1E3CBA0", Offset = "0x1E3B5A0", VA = "0x181E3CBA0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60030F1")]
				[Cpp2IlInjected.Address(RVA = "0x1E40110", Offset = "0x1E3EB10", VA = "0x181E40110", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030F2")]
				[Cpp2IlInjected.Address(RVA = "0x1E3FC90", Offset = "0x1E3E690", VA = "0x181E3FC90", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030F3")]
				[Cpp2IlInjected.Address(RVA = "0x1E3EBE0", Offset = "0x1E3D5E0", VA = "0x181E3EBE0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60030F4")]
				[Cpp2IlInjected.Address(RVA = "0x1E40840", Offset = "0x1E3F240", VA = "0x181E40840", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030F5")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D4C0", Offset = "0x1E3BEC0", VA = "0x181E3D4C0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030F6")]
				[Cpp2IlInjected.Address(RVA = "0x1E40E10", Offset = "0x1E3F810", VA = "0x181E40E10", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200050C")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FA2")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FA3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FA4")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FA5")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000FA6")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000FA7")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000902")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60030FB")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C190", Offset = "0x1E4AB90", VA = "0x181E4C190")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000903")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60030FC")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C0F0", Offset = "0x1E4AAF0", VA = "0x181E4C0F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000904")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60030FD")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C510", Offset = "0x1E4AF10", VA = "0x181E4C510", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000905")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6003101")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003102")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000906")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6003103")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003104")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000907")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6003110")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003111")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60030FE")]
				[Cpp2IlInjected.Address(RVA = "0x1E4BDB0", Offset = "0x1E4A7B0", VA = "0x181E4BDB0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60030FF")]
				[Cpp2IlInjected.Address(RVA = "0x1E4BC40", Offset = "0x1E4A640", VA = "0x181E4BC40")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003100")]
				[Cpp2IlInjected.Address(RVA = "0x1E46970", Offset = "0x1E45370", VA = "0x181E46970", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003105")]
				[Cpp2IlInjected.Address(RVA = "0x1E47490", Offset = "0x1E45E90", VA = "0x181E47490", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003106")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003107")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003108")]
				[Cpp2IlInjected.Address(RVA = "0x1E49A30", Offset = "0x1E48430", VA = "0x181E49A30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003109")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600310A")]
				[Cpp2IlInjected.Address(RVA = "0x1E464F0", Offset = "0x1E44EF0", VA = "0x181E464F0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600310B")]
				[Cpp2IlInjected.Address(RVA = "0x1E48F60", Offset = "0x1E47960", VA = "0x181E48F60", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600310C")]
				[Cpp2IlInjected.Address(RVA = "0x1E489F0", Offset = "0x1E473F0", VA = "0x181E489F0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600310D")]
				[Cpp2IlInjected.Address(RVA = "0x1E47E20", Offset = "0x1E46820", VA = "0x181E47E20", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600310E")]
				[Cpp2IlInjected.Address(RVA = "0x1E495F0", Offset = "0x1E47FF0", VA = "0x181E495F0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600310F")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003112")]
				[Cpp2IlInjected.Address(RVA = "0x1E441B0", Offset = "0x1E42BB0", VA = "0x181E441B0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000F8C")]
		private static readonly MessageParser<ManagePlayerHouseRoom> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F8D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170008F8")]
		[DebuggerNonUserCode]
		public static MessageParser<ManagePlayerHouseRoom> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60030CB")]
			[Cpp2IlInjected.Address(RVA = "0x18B4A10", Offset = "0x18B3410", VA = "0x1818B4A10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60030CC")]
			[Cpp2IlInjected.Address(RVA = "0x18B4940", Offset = "0x18B3340", VA = "0x1818B4940")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60030CD")]
			[Cpp2IlInjected.Address(RVA = "0x18B4A70", Offset = "0x18B3470", VA = "0x1818B4A70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030CE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ManagePlayerHouseRoom()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60030CF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ManagePlayerHouseRoom(ManagePlayerHouseRoom other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030D0")]
		[Cpp2IlInjected.Address(RVA = "0x18B4660", Offset = "0x18B3060", VA = "0x1818B4660", Slot = "10")]
		[DebuggerNonUserCode]
		public ManagePlayerHouseRoom Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ManagePlayerHouseRoom managePlayerHouseRoom = default(ManagePlayerHouseRoom);
			managePlayerHouseRoom.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (managePlayerHouseRoom._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return managePlayerHouseRoom;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D1")]
		[Cpp2IlInjected.Address(RVA = "0x18B46E0", Offset = "0x18B30E0", VA = "0x1818B46E0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60030D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ManagePlayerHouseRoom other)
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

		[Cpp2IlInjected.Token(Token = "0x60030D3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D4")]
		[Cpp2IlInjected.Address(RVA = "0x18B47D0", Offset = "0x18B31D0", VA = "0x1818B47D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60030D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60030D6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ManagePlayerHouseRoom other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030D8")]
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

		[Cpp2IlInjected.Token(Token = "0x60030D9")]
		[Cpp2IlInjected.Address(RVA = "0x18B4760", Offset = "0x18B3160", VA = "0x1818B4760", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60030DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60030DC")]
		[Cpp2IlInjected.Address(RVA = "0x18B4830", Offset = "0x18B3230", VA = "0x1818B4830")]
		static ManagePlayerHouseRoom()
		{
			Func<ManagePlayerHouseRoom> func = default(Func<ManagePlayerHouseRoom>);
			_parser = (MessageParser<ManagePlayerHouseRoom>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
