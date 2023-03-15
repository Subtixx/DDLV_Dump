using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000520")]
	public sealed class ChangePlayerHouseWallpaper : IMessage<ChangePlayerHouseWallpaper>, IMessage, IEquatable<ChangePlayerHouseWallpaper>, IDeepCloneable<ChangePlayerHouseWallpaper>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000521")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000522")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000FDB")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000FDC")]
				[OriginalName("InvalidFloor")]
				InvalidFloor,
				[Cpp2IlInjected.Token(Token = "0x4000FDD")]
				[OriginalName("InvalidRoom")]
				InvalidRoom,
				[Cpp2IlInjected.Token(Token = "0x4000FDE")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000FDF")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems
			}

			[Cpp2IlInjected.Token(Token = "0x2000523")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000524")]
				public enum WallSelectionOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4000FEC")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x4000FED")]
					WallPosition = 3
				}

				[Cpp2IlInjected.Token(Token = "0x4000FE0")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FE1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FE2")]
				public const int FloorIndexFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FE3")]
				private int floorIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000FE4")]
				public const int RoomSlotFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000FE5")]
				private House.Types.RoomSlot roomSlot_;

				[Cpp2IlInjected.Token(Token = "0x4000FE6")]
				public const int WallPositionFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000FE7")]
				public const int WallpaperItemIDFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000FE8")]
				private int wallpaperItemID_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000FE9")]
				private object wallSelection_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000FEA")]
				private WallSelectionOneofCase wallSelectionCase_;

				[Cpp2IlInjected.Token(Token = "0x17000926")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60031C1")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC510", Offset = "0x1DFAF10", VA = "0x181DFC510")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000927")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60031C2")]
					[Cpp2IlInjected.Address(RVA = "0x1DFBA80", Offset = "0x1DFA480", VA = "0x181DFBA80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000928")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60031C3")]
					[Cpp2IlInjected.Address(RVA = "0x1DFCCA0", Offset = "0x1DFB6A0", VA = "0x181DFCCA0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000929")]
				[DebuggerNonUserCode]
				public int FloorIndex
				{
					[Cpp2IlInjected.Token(Token = "0x60031C7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60031C8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700092A")]
				[DebuggerNonUserCode]
				public House.Types.RoomSlot RoomSlot
				{
					[Cpp2IlInjected.Token(Token = "0x60031C9")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(House.Types.RoomSlot);
					}
					[Cpp2IlInjected.Token(Token = "0x60031CA")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700092B")]
				[DebuggerNonUserCode]
				public House.Types.WallPosition WallPosition
				{
					[Cpp2IlInjected.Token(Token = "0x60031CB")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC570", Offset = "0x1DFAF70", VA = "0x181DFC570")]
					get
					{
						return default(House.Types.WallPosition);
					}
					[Cpp2IlInjected.Token(Token = "0x60031CC")]
					[Cpp2IlInjected.Address(RVA = "0x1DFD160", Offset = "0x1DFBB60", VA = "0x181DFD160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700092C")]
				[DebuggerNonUserCode]
				public int WallpaperItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60031CD")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60031CE")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700092D")]
				[DebuggerNonUserCode]
				public WallSelectionOneofCase WallSelectionCase
				{
					[Cpp2IlInjected.Token(Token = "0x60031CF")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(WallSelectionOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700092E")]
				public House.Types.WallPosition? ModifiedWall
				{
					[Cpp2IlInjected.Token(Token = "0x60031DE")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC080", Offset = "0x1DFAA80", VA = "0x181DFC080")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60031DF")]
					[Cpp2IlInjected.Address(RVA = "0x1DFD030", Offset = "0x1DFBA30", VA = "0x181DFD030")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60031C4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031C5")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB8D0", Offset = "0x1DFA2D0", VA = "0x181DFB8D0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031C6")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6F40", Offset = "0x1DF5940", VA = "0x181DF6F40", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60031D0")]
				[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
				[DebuggerNonUserCode]
				public void ClearWallSelection()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031D1")]
				[Cpp2IlInjected.Address(RVA = "0x1DF72B0", Offset = "0x1DF5CB0", VA = "0x181DF72B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60031D2")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7030", Offset = "0x1DF5A30", VA = "0x181DF7030", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60031D3")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8460", Offset = "0x1DF6E60", VA = "0x181DF8460", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60031D4")]
				[Cpp2IlInjected.Address(RVA = "0x1DF9740", Offset = "0x1DF8140", VA = "0x181DF9740", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60031D5")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA260", Offset = "0x1DF8C60", VA = "0x181DFA260", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031D6")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6220", Offset = "0x1DF4C20", VA = "0x181DF6220", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60031D7")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8740", Offset = "0x1DF7140", VA = "0x181DF8740", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031D8")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8AC0", Offset = "0x1DF74C0", VA = "0x181DF8AC0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031D9")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7C30", Offset = "0x1DF6630", VA = "0x181DF7C30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60031DA")]
				[Cpp2IlInjected.Address(RVA = "0x1DF9200", Offset = "0x1DF7C00", VA = "0x181DF9200", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031DB")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6700", Offset = "0x1DF5100", VA = "0x181DF6700", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031DC")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8560", Offset = "0x1DF6F60", VA = "0x181DF8560", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60031DD")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6740", Offset = "0x1DF5140", VA = "0x181DF6740", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000526")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FEF")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FF0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FF1")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FF2")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000FF3")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000FF4")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700092F")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60031E4")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A1B0", Offset = "0x1E08BB0", VA = "0x181E0A1B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000930")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60031E5")]
					[Cpp2IlInjected.Address(RVA = "0x1E09BB0", Offset = "0x1E085B0", VA = "0x181E09BB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000931")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60031E6")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A2D0", Offset = "0x1E08CD0", VA = "0x181E0A2D0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000932")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60031EA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60031EB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000933")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60031EC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60031ED")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000934")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60031F9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60031FA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60031E7")]
				[Cpp2IlInjected.Address(RVA = "0x1E08DD0", Offset = "0x1E077D0", VA = "0x181E08DD0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031E8")]
				[Cpp2IlInjected.Address(RVA = "0x1E08400", Offset = "0x1E06E00", VA = "0x181E08400")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031E9")]
				[Cpp2IlInjected.Address(RVA = "0x1E01580", Offset = "0x1DFFF80", VA = "0x181E01580", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60031EE")]
				[Cpp2IlInjected.Address(RVA = "0x1E02B40", Offset = "0x1E01540", VA = "0x181E02B40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60031EF")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60031F0")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60031F1")]
				[Cpp2IlInjected.Address(RVA = "0x1E06E60", Offset = "0x1E05860", VA = "0x181E06E60", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60031F2")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031F3")]
				[Cpp2IlInjected.Address(RVA = "0x1E01220", Offset = "0x1DFFC20", VA = "0x181E01220", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60031F4")]
				[Cpp2IlInjected.Address(RVA = "0x1E04720", Offset = "0x1E03120", VA = "0x181E04720", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031F5")]
				[Cpp2IlInjected.Address(RVA = "0x1E05910", Offset = "0x1E04310", VA = "0x181E05910", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031F6")]
				[Cpp2IlInjected.Address(RVA = "0x1E03670", Offset = "0x1E02070", VA = "0x181E03670", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60031F7")]
				[Cpp2IlInjected.Address(RVA = "0x1E06400", Offset = "0x1E04E00", VA = "0x181E06400", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031F8")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60031FB")]
				[Cpp2IlInjected.Address(RVA = "0x1DFF890", Offset = "0x1DFE290", VA = "0x181DFF890", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000FD8")]
		private static readonly MessageParser<ChangePlayerHouseWallpaper> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000FD9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000923")]
		[DebuggerNonUserCode]
		public static MessageParser<ChangePlayerHouseWallpaper> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60031AF")]
			[Cpp2IlInjected.Address(RVA = "0x71A290", Offset = "0x718C90", VA = "0x18071A290")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000924")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031B0")]
			[Cpp2IlInjected.Address(RVA = "0x71A1C0", Offset = "0x718BC0", VA = "0x18071A1C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000925")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031B1")]
			[Cpp2IlInjected.Address(RVA = "0x71A2F0", Offset = "0x718CF0", VA = "0x18071A2F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031B2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ChangePlayerHouseWallpaper()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60031B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ChangePlayerHouseWallpaper(ChangePlayerHouseWallpaper other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031B4")]
		[Cpp2IlInjected.Address(RVA = "0x719EE0", Offset = "0x7188E0", VA = "0x180719EE0", Slot = "10")]
		[DebuggerNonUserCode]
		public ChangePlayerHouseWallpaper Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ChangePlayerHouseWallpaper changePlayerHouseWallpaper = default(ChangePlayerHouseWallpaper);
			changePlayerHouseWallpaper.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (changePlayerHouseWallpaper._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return changePlayerHouseWallpaper;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B5")]
		[Cpp2IlInjected.Address(RVA = "0x719F60", Offset = "0x718960", VA = "0x180719F60", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60031B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChangePlayerHouseWallpaper other)
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

		[Cpp2IlInjected.Token(Token = "0x60031B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B8")]
		[Cpp2IlInjected.Address(RVA = "0x71A050", Offset = "0x718A50", VA = "0x18071A050", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60031B9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60031BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChangePlayerHouseWallpaper other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031BC")]
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

		[Cpp2IlInjected.Token(Token = "0x60031BD")]
		[Cpp2IlInjected.Address(RVA = "0x719FE0", Offset = "0x7189E0", VA = "0x180719FE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031BE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031C0")]
		[Cpp2IlInjected.Address(RVA = "0x71A0B0", Offset = "0x718AB0", VA = "0x18071A0B0")]
		static ChangePlayerHouseWallpaper()
		{
			Func<ChangePlayerHouseWallpaper> func = default(Func<ChangePlayerHouseWallpaper>);
			_parser = (MessageParser<ChangePlayerHouseWallpaper>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
