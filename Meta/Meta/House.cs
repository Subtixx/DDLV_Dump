using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000800")]
	public sealed class House : IMessage<House>, IMessage, IEquatable<House>, IDeepCloneable<House>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000801")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000802")]
			public enum RoomSlot
			{
				[Cpp2IlInjected.Token(Token = "0x4001FF9")]
				[OriginalName("RoomSlot_Center")]
				Center,
				[Cpp2IlInjected.Token(Token = "0x4001FFA")]
				[OriginalName("RoomSlot_Left")]
				Left,
				[Cpp2IlInjected.Token(Token = "0x4001FFB")]
				[OriginalName("RoomSlot_Right")]
				Right,
				[Cpp2IlInjected.Token(Token = "0x4001FFC")]
				[OriginalName("RoomSlot_Top")]
				Top
			}

			[Cpp2IlInjected.Token(Token = "0x2000803")]
			public enum WallPosition
			{
				[Cpp2IlInjected.Token(Token = "0x4001FFE")]
				[OriginalName("WallPosition_Top")]
				Top,
				[Cpp2IlInjected.Token(Token = "0x4001FFF")]
				[OriginalName("WallPosition_Right")]
				Right,
				[Cpp2IlInjected.Token(Token = "0x4002000")]
				[OriginalName("WallPosition_Bottom")]
				Bottom,
				[Cpp2IlInjected.Token(Token = "0x4002001")]
				[OriginalName("WallPosition_Left")]
				Left
			}

			[Cpp2IlInjected.Token(Token = "0x2000804")]
			public sealed class Room : IMessage<Room>, IMessage, IEquatable<Room>, IDeepCloneable<Room>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002002")]
				private static readonly MessageParser<Room> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002003")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002004")]
				public const int NameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002005")]
				private string name_;

				[Cpp2IlInjected.Token(Token = "0x4002006")]
				public const int FloorGridIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002007")]
				private uint floorGridID_;

				[Cpp2IlInjected.Token(Token = "0x4002008")]
				public const int WallGridIDsFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4002009")]
				private static readonly MapField<int, uint>.Codec _map_wallGridIDs_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400200A")]
				private readonly MapField<int, uint> wallGridIDs_;

				[Cpp2IlInjected.Token(Token = "0x400200B")]
				public const int RoomPrefabAddressFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400200C")]
				private string roomPrefabAddress_;

				[Cpp2IlInjected.Token(Token = "0x400200D")]
				public const int FlooringFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400200E")]
				private int flooring_;

				[Cpp2IlInjected.Token(Token = "0x400200F")]
				public const int WallpapersFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x4002010")]
				private static readonly MapField<int, int>.Codec _map_wallpapers_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002011")]
				private readonly MapField<int, int> wallpapers_;

				[Cpp2IlInjected.Token(Token = "0x4002012")]
				public static readonly Item DEFAULT_FLOOR;

				[Cpp2IlInjected.Token(Token = "0x4002013")]
				public static readonly Item DEFAULT_WALLPAPER;

				[Cpp2IlInjected.Token(Token = "0x17000AE7")]
				[DebuggerNonUserCode]
				public static MessageParser<Room> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60042DB")]
					[Cpp2IlInjected.Address(RVA = "0x1E4E880", Offset = "0x1E4D280", VA = "0x181E4E880")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AE8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60042DC")]
					[Cpp2IlInjected.Address(RVA = "0x1E4E800", Offset = "0x1E4D200", VA = "0x181E4E800")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AE9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60042DD")]
					[Cpp2IlInjected.Address(RVA = "0x1E4E8E0", Offset = "0x1E4D2E0", VA = "0x181E4E8E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AEA")]
				[DebuggerNonUserCode]
				public string Name
				{
					[Cpp2IlInjected.Token(Token = "0x60042E2")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60042E3")]
					[Cpp2IlInjected.Address(RVA = "0x1E4E9A0", Offset = "0x1E4D3A0", VA = "0x181E4E9A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AEB")]
				[DebuggerNonUserCode]
				public uint FloorGridID
				{
					[Cpp2IlInjected.Token(Token = "0x60042E4")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60042E5")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AEC")]
				[DebuggerNonUserCode]
				public MapField<int, uint> WallGridIDs
				{
					[Cpp2IlInjected.Token(Token = "0x60042E6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AED")]
				[DebuggerNonUserCode]
				public string RoomPrefabAddress
				{
					[Cpp2IlInjected.Token(Token = "0x60042E7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60042E8")]
					[Cpp2IlInjected.Address(RVA = "0x1E4EA10", Offset = "0x1E4D410", VA = "0x181E4EA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AEE")]
				[DebuggerNonUserCode]
				public int Flooring
				{
					[Cpp2IlInjected.Token(Token = "0x60042E9")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60042EA")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AEF")]
				[DebuggerNonUserCode]
				public MapField<int, int> Wallpapers
				{
					[Cpp2IlInjected.Token(Token = "0x60042EB")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60042DE")]
				[Cpp2IlInjected.Address(RVA = "0x1E4E500", Offset = "0x1E4CF00", VA = "0x181E4E500")]
				[DebuggerNonUserCode]
				public Room()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042DF")]
				[Cpp2IlInjected.Address(RVA = "0x1E4DCA0", Offset = "0x1E4C6A0", VA = "0x181E4DCA0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042E0")]
				[Cpp2IlInjected.Address(RVA = "0x1E4E710", Offset = "0x1E4D110", VA = "0x181E4E710")]
				[DebuggerNonUserCode]
				public Room(Room other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042E1")]
				[Cpp2IlInjected.Address(RVA = "0x1E4CDE0", Offset = "0x1E4B7E0", VA = "0x181E4CDE0", Slot = "10")]
				[DebuggerNonUserCode]
				public Room Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042EC")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D280", Offset = "0x1E4BC80", VA = "0x181E4D280", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60042ED")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D170", Offset = "0x1E4BB70", VA = "0x181E4D170", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Room other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60042EE")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D670", Offset = "0x1E4C070", VA = "0x181E4D670", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042EF")]
				[Cpp2IlInjected.Address(RVA = "0x1E4E000", Offset = "0x1E4CA00", VA = "0x181E4E000", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042F0")]
				[Cpp2IlInjected.Address(RVA = "0x1E4E0A0", Offset = "0x1E4CAA0", VA = "0x181E4E0A0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042F1")]
				[Cpp2IlInjected.Address(RVA = "0x1E4CAE0", Offset = "0x1E4B4E0", VA = "0x181E4CAE0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042F2")]
				[Cpp2IlInjected.Address(RVA = "0x1E4DBB0", Offset = "0x1E4C5B0", VA = "0x181E4DBB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Room other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042F3")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D9E0", Offset = "0x1E4C3E0", VA = "0x181E4D9E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042F4")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D520", Offset = "0x1E4BF20", VA = "0x181E4D520", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042F5")]
				[Cpp2IlInjected.Address(RVA = "0x1E4DDD0", Offset = "0x1E4C7D0", VA = "0x181E4DDD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042F6")]
				[Cpp2IlInjected.Address(RVA = "0x1E4CCE0", Offset = "0x1E4B6E0", VA = "0x181E4CCE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042F7")]
				[Cpp2IlInjected.Address(RVA = "0x1E4CF00", Offset = "0x1E4B900", VA = "0x181E4CF00")]
				public static Room CreateRoom(HouseExpansion.Types.InteriorExpansion.Types.ExpansionData roomData, GridCollection gridCollection, out IGrid floorGrid)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042F8")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D4F0", Offset = "0x1E4BEF0", VA = "0x181E4D4F0")]
				public int ExpansionCount(int roomSlot, Profile profile, Floor floor, HouseExpansion houseExpansion)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042F9")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D3D0", Offset = "0x1E4BDD0", VA = "0x181E4D3D0")]
				public int ExpansionCount(RoomSlot roomSlot, ProfileWorld profileWorld, Floor floor, HouseExpansion houseExpansion)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042FA")]
				[Cpp2IlInjected.Address(RVA = "0x1E4D770", Offset = "0x1E4C170", VA = "0x181E4D770")]
				public bool IsRoomRelatedGrid(uint gridID, GridCollection gridCollection)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000807")]
			public sealed class Floor : IMessage<Floor>, IMessage, IEquatable<Floor>, IDeepCloneable<Floor>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000808")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000809")]
					public sealed class AdditionalRoomsList : IMessage<AdditionalRoomsList>, IMessage, IEquatable<AdditionalRoomsList>, IDeepCloneable<AdditionalRoomsList>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x400201F")]
						private static readonly MessageParser<AdditionalRoomsList> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4002020")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4002021")]
						public const int GridDataPathsFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x4002022")]
						private static readonly FieldCodec<string> _repeated_gridDataPaths_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4002023")]
						private readonly RepeatedField<string> gridDataPaths_;

						[Cpp2IlInjected.Token(Token = "0x17000AF5")]
						[DebuggerNonUserCode]
						public static MessageParser<AdditionalRoomsList> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x6004317")]
							[Cpp2IlInjected.Address(RVA = "0x3F9F640", Offset = "0x3F9E040", VA = "0x183F9F640")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000AF6")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6004318")]
							[Cpp2IlInjected.Address(RVA = "0x3F9F5C0", Offset = "0x3F9DFC0", VA = "0x183F9F5C0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000AF7")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6004319")]
							[Cpp2IlInjected.Address(RVA = "0x3F9F6A0", Offset = "0x3F9E0A0", VA = "0x183F9F6A0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000AF8")]
						[DebuggerNonUserCode]
						public RepeatedField<string> GridDataPaths
						{
							[Cpp2IlInjected.Token(Token = "0x600431D")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x600431A")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F4B0", Offset = "0x3F9DEB0", VA = "0x183F9F4B0")]
						[DebuggerNonUserCode]
						public AdditionalRoomsList()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600431B")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F530", Offset = "0x3F9DF30", VA = "0x183F9F530")]
						[DebuggerNonUserCode]
						public AdditionalRoomsList(AdditionalRoomsList other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600431C")]
						[Cpp2IlInjected.Address(RVA = "0x3F9EDD0", Offset = "0x3F9D7D0", VA = "0x183F9EDD0", Slot = "10")]
						[DebuggerNonUserCode]
						public AdditionalRoomsList Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600431E")]
						[Cpp2IlInjected.Address(RVA = "0x3F9EE90", Offset = "0x3F9D890", VA = "0x183F9EE90", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600431F")]
						[Cpp2IlInjected.Address(RVA = "0x3F9EF70", Offset = "0x3F9D970", VA = "0x183F9EF70", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(AdditionalRoomsList other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6004320")]
						[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6004321")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F250", Offset = "0x3F9DC50", VA = "0x183F9F250", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6004322")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F2B0", Offset = "0x3F9DCB0", VA = "0x183F9F2B0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004323")]
						[Cpp2IlInjected.Address(RVA = "0x3F9ECC0", Offset = "0x3F9D6C0", VA = "0x183F9ECC0", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6004324")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F080", Offset = "0x3F9DA80", VA = "0x183F9F080", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(AdditionalRoomsList other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004325")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F100", Offset = "0x3F9DB00", VA = "0x183F9F100", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004326")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F000", Offset = "0x3F9DA00", VA = "0x183F9F000", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6004327")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F1F0", Offset = "0x3F9DBF0", VA = "0x183F9F1F0", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004328")]
						[Cpp2IlInjected.Address(RVA = "0x3F9ED70", Offset = "0x3F9D770", VA = "0x183F9ED70", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4002017")]
				private static readonly MessageParser<Floor> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002018")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002019")]
				public const int RoomsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400201A")]
				private static readonly MapField<int, Room>.Codec _map_rooms_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400201B")]
				private readonly MapField<int, Room> rooms_;

				[Cpp2IlInjected.Token(Token = "0x400201C")]
				public const int BoughtRoomsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x400201D")]
				private static readonly MapField<int, Types.AdditionalRoomsList>.Codec _map_boughtRooms_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400201E")]
				private readonly MapField<int, Types.AdditionalRoomsList> boughtRooms_;

				[Cpp2IlInjected.Token(Token = "0x17000AF0")]
				[DebuggerNonUserCode]
				public static MessageParser<Floor> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004300")]
					[Cpp2IlInjected.Address(RVA = "0x1E3A8E0", Offset = "0x1E392E0", VA = "0x181E3A8E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AF1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004301")]
					[Cpp2IlInjected.Address(RVA = "0x1E3A860", Offset = "0x1E39260", VA = "0x181E3A860")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AF2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004302")]
					[Cpp2IlInjected.Address(RVA = "0x1E3A940", Offset = "0x1E39340", VA = "0x181E3A940", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AF3")]
				[DebuggerNonUserCode]
				public MapField<int, Room> Rooms
				{
					[Cpp2IlInjected.Token(Token = "0x6004306")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AF4")]
				[DebuggerNonUserCode]
				public MapField<int, Types.AdditionalRoomsList> BoughtRooms
				{
					[Cpp2IlInjected.Token(Token = "0x6004307")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004303")]
				[Cpp2IlInjected.Address(RVA = "0x1E3A7A0", Offset = "0x1E391A0", VA = "0x181E3A7A0")]
				[DebuggerNonUserCode]
				public Floor()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004304")]
				[Cpp2IlInjected.Address(RVA = "0x1E3A620", Offset = "0x1E39020", VA = "0x181E3A620")]
				[DebuggerNonUserCode]
				public Floor(Floor other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004305")]
				[Cpp2IlInjected.Address(RVA = "0x1E39990", Offset = "0x1E38390", VA = "0x181E39990", Slot = "10")]
				[DebuggerNonUserCode]
				public Floor Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004308")]
				[Cpp2IlInjected.Address(RVA = "0x1E39B40", Offset = "0x1E38540", VA = "0x181E39B40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004309")]
				[Cpp2IlInjected.Address(RVA = "0x1E39C40", Offset = "0x1E38640", VA = "0x181E39C40", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Floor other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600430A")]
				[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600430B")]
				[Cpp2IlInjected.Address(RVA = "0x1E3A120", Offset = "0x1E38B20", VA = "0x181E3A120", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600430C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3A1F0", Offset = "0x1E38BF0", VA = "0x181E3A1F0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600430D")]
				[Cpp2IlInjected.Address(RVA = "0x1E39610", Offset = "0x1E38010", VA = "0x181E39610", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600430E")]
				[Cpp2IlInjected.Address(RVA = "0x1E39EF0", Offset = "0x1E388F0", VA = "0x181E39EF0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Floor other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600430F")]
				[Cpp2IlInjected.Address(RVA = "0x1E39D90", Offset = "0x1E38790", VA = "0x181E39D90", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004310")]
				[Cpp2IlInjected.Address(RVA = "0x1E39D00", Offset = "0x1E38700", VA = "0x181E39D00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004311")]
				[Cpp2IlInjected.Address(RVA = "0x1E3A070", Offset = "0x1E38A70", VA = "0x181E3A070", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004312")]
				[Cpp2IlInjected.Address(RVA = "0x1E39920", Offset = "0x1E38320", VA = "0x181E39920", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004313")]
				[Cpp2IlInjected.Address(RVA = "0x1E3A180", Offset = "0x1E38B80", VA = "0x181E3A180")]
				public bool TryGetRoom(RoomSlot roomSlot, out Room room)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004314")]
				[Cpp2IlInjected.Address(RVA = "0x1E39F90", Offset = "0x1E38990", VA = "0x181E39F90")]
				public bool PlayerLevelAllowsAddRoom(ProfileWorld profileWorld)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004315")]
				[Cpp2IlInjected.Address(RVA = "0x1E39700", Offset = "0x1E38100", VA = "0x181E39700")]
				public bool CanAddRooms(ProfileWorld profileWorld)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001FEF")]
		private static readonly MessageParser<House> _parser = (MessageParser<House>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new House()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FF0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FF1")]
		public const int FloorsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001FF2")]
		private static readonly FieldCodec<Types.Floor> _repeated_floors_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FF3")]
		private readonly RepeatedField<Types.Floor> floors_ = (RepeatedField<Types.Floor>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001FF4")]
		public const int InitialRoomGridLayoutPathFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FF5")]
		private string initialRoomGridLayoutPath_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FF6")]
		public const int HouseItemIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FF7")]
		private int houseItemID_;

		[Cpp2IlInjected.Token(Token = "0x17000ADF")]
		[DebuggerNonUserCode]
		public static MessageParser<House> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60042BD")]
			[Cpp2IlInjected.Address(RVA = "0x1707830", Offset = "0x1706230", VA = "0x181707830")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60042BE")]
			[Cpp2IlInjected.Address(RVA = "0x1707700", Offset = "0x1706100", VA = "0x181707700")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60042BF")]
			[Cpp2IlInjected.Address(RVA = "0x17079C0", Offset = "0x17063C0", VA = "0x1817079C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE2")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Floor> Floors
		{
			[Cpp2IlInjected.Token(Token = "0x60042C3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return floors_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE3")]
		[DebuggerNonUserCode]
		public string InitialRoomGridLayoutPath
		{
			[Cpp2IlInjected.Token(Token = "0x60042C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return initialRoomGridLayoutPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042C5")]
			[Cpp2IlInjected.Address(RVA = "0x1707AD0", Offset = "0x17064D0", VA = "0x181707AD0")]
			set
			{
				string text = (initialRoomGridLayoutPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE4")]
		[DebuggerNonUserCode]
		public int HouseItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60042C6")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return houseItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042C7")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				houseItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE5")]
		public Item HouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x60042D3")]
			[Cpp2IlInjected.Address(RVA = "0x17077D0", Offset = "0x17061D0", VA = "0x1817077D0")]
			get
			{
				long num = Convert.ToInt64((uint)houseItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60042D4")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				//IL_0007: Expected I4, but got O
				houseItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE6")]
		public int RoomCount
		{
			[Cpp2IlInjected.Token(Token = "0x60042D8")]
			[Cpp2IlInjected.Address(RVA = "0x1707890", Offset = "0x1706290", VA = "0x181707890")]
			get
			{
				RepeatedField<Types.Floor> repeatedField = floors_;
				Func<Types.Floor, int> _003C_003E9__46_ = _003C_003Ec._003C_003E9__46_0;
				if (_003C_003E9__46_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.Floor f) => ((MapField<TKey, TValue>)(object)f.rooms_).Count);
				}
				return Enumerable.Sum<Types.Floor>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__46_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042C0")]
		[Cpp2IlInjected.Address(RVA = "0x1707530", Offset = "0x1705F30", VA = "0x181707530")]
		[DebuggerNonUserCode]
		public House()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60042C1")]
		[Cpp2IlInjected.Address(RVA = "0x17075D0", Offset = "0x1705FD0", VA = "0x1817075D0")]
		[DebuggerNonUserCode]
		public House(House other)
		{
			RepeatedField<Types.Floor> repeatedField = (floors_ = (RepeatedField<Types.Floor>)(object)((RepeatedField<T>)(object)other.floors_).Clone());
			string text = (initialRoomGridLayoutPath_ = other.initialRoomGridLayoutPath_);
			int num = (houseItemID_ = other.houseItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042C2")]
		[Cpp2IlInjected.Address(RVA = "0x17063C0", Offset = "0x1704DC0", VA = "0x1817063C0", Slot = "10")]
		[DebuggerNonUserCode]
		public House Clone()
		{
			//Discarded unreachable code: IL_0066
			House house = new House();
			RepeatedField<Types.Floor> repeatedField = (house.floors_ = (RepeatedField<Types.Floor>)(object)new RepeatedField<T>());
			house.initialRoomGridLayoutPath_ = "";
			RepeatedField<Types.Floor> repeatedField2 = (house.floors_ = (RepeatedField<Types.Floor>)(object)((RepeatedField<T>)(object)floors_).Clone());
			string text = (house.initialRoomGridLayoutPath_ = initialRoomGridLayoutPath_);
			int num = (house.houseItemID_ = houseItemID_);
			UnknownFieldSet unknownFieldSet = (house._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return house;
		}

		[Cpp2IlInjected.Token(Token = "0x60042C8")]
		[Cpp2IlInjected.Address(RVA = "0x1706520", Offset = "0x1704F20", VA = "0x181706520", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<Types.Floor> repeatedField = floors_;
				bool flag = default(bool);
				if (flag)
				{
					string text = initialRoomGridLayoutPath_;
					bool flag2 = default(bool);
					if (!flag2 && houseItemID_ == (flag2 ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042C9")]
		[Cpp2IlInjected.Address(RVA = "0x1706610", Offset = "0x1705010", VA = "0x181706610", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(House other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.Floor> repeatedField = floors_;
				RepeatedField<Types.Floor> repeatedField2 = other.floors_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					string text = other.initialRoomGridLayoutPath_;
					if (!(initialRoomGridLayoutPath_ != text))
					{
						int num = other.houseItemID_;
						if (houseItemID_ == num)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042CA")]
		[Cpp2IlInjected.Address(RVA = "0x17067A0", Offset = "0x17051A0", VA = "0x1817067A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0048
			int hashCode = ((RepeatedField<T>)(object)floors_).GetHashCode();
			string text = initialRoomGridLayoutPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			if (houseItemID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60042CB")]
		[Cpp2IlInjected.Address(RVA = "0x17071E0", Offset = "0x1705BE0", VA = "0x1817071E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60042CC")]
		[Cpp2IlInjected.Address(RVA = "0x1707240", Offset = "0x1705C40", VA = "0x181707240", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			RepeatedField<Types.Floor> repeatedField = floors_;
			FieldCodec<Types.Floor> repeated_floors_codec = _repeated_floors_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_floors_codec);
			if (initialRoomGridLayoutPath_.m_stringLength != 0)
			{
				string value = initialRoomGridLayoutPath_;
				output.WriteString(value);
			}
			if (houseItemID_ != 0)
			{
				int value2 = houseItemID_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60042CD")]
		[Cpp2IlInjected.Address(RVA = "0x1706100", Offset = "0x1704B00", VA = "0x181706100", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007a
			RepeatedField<Types.Floor> repeatedField = floors_;
			FieldCodec<Types.Floor> repeated_floors_codec = _repeated_floors_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_floors_codec);
			string text = initialRoomGridLayoutPath_;
			if (text.m_stringLength != 0)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
				num += num2;
			}
			int num3 = houseItemID_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60042CE")]
		[Cpp2IlInjected.Address(RVA = "0x1706F10", Offset = "0x1705910", VA = "0x181706F10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(House other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				RepeatedField<Types.Floor> repeatedField = floors_;
				RepeatedField<Types.Floor> repeatedField2 = other.floors_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text = other.initialRoomGridLayoutPath_;
				if (text.m_stringLength != 0)
				{
					InitialRoomGridLayoutPath = text;
				}
				int num = other.houseItemID_;
				if (num != 0)
				{
					houseItemID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042CF")]
		[Cpp2IlInjected.Address(RVA = "0x1706DE0", Offset = "0x17057E0", VA = "0x181706DE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0069
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.Floor> repeatedField = floors_;
					FieldCodec<Types.Floor> repeated_floors_codec = _repeated_floors_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_floors_codec);
				}
				string text2 = default(string);
				if (num == 18)
				{
					text2 = (InitialRoomGridLayoutPath = input.ReadString());
				}
				if ((long)text2 == 24)
				{
					int num2 = (houseItemID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042D0")]
		[Cpp2IlInjected.Address(RVA = "0x17066C0", Offset = "0x17050C0", VA = "0x1817066C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					int num2 = houseItemID_;
				}
				string text = initialRoomGridLayoutPath_;
			}
			RepeatedField<Types.Floor> repeatedField = floors_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60042D1")]
		[Cpp2IlInjected.Address(RVA = "0x17070B0", Offset = "0x1705AB0", VA = "0x1817070B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					houseItemID_ = (int)obj;
					return;
				}
				default:
					return;
				case 0:
					break;
				}
				if (value == null || value != null)
				{
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042D2")]
		[Cpp2IlInjected.Address(RVA = "0x1706320", Offset = "0x1704D20", VA = "0x181706320", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					houseItemID_ = 0;
					break;
				case 0:
					InitialRoomGridLayoutPath = "";
					break;
				}
				return;
			}
			RepeatedField<Types.Floor> repeatedField = floors_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042D5")]
		[Cpp2IlInjected.Address(RVA = "0x1706B00", Offset = "0x1705500", VA = "0x181706B00")]
		public bool IsHouseRelatedGrid(uint gridID, GridCollection gridCollection)
		{
			//Discarded unreachable code: IL_0050, IL_0056, IL_005c, IL_0062, IL_0068
			int num = 0;
			RepeatedField<Types.Floor> repeatedField = floors_;
			bool flag = default(bool);
			if (flag)
			{
				ICollection<> collection = default(ICollection<>);
				if (collection != null)
				{
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					num++;
				}
				num++;
				if (collection != null)
				{
				}
				while (num == 0)
				{
				}
				if ((long)typeof(IDisposable).TypeHandle == 105)
				{
				}
				while ((long)typeof(IDisposable).TypeHandle != 78)
				{
				}
			}
			if (num + 1 != 0)
			{
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042D6")]
		[Cpp2IlInjected.Address(RVA = "0x1706840", Offset = "0x1705240", VA = "0x181706840")]
		public static BenefitsHouseData GetPlayerHouseLevelBenefits(ProfileWorld profileWorld)
		{
			//IL_0027: Expected O, but got I4
			House playerHouse_ = profileWorld.playerHouse_;
			GridCollection gridCollection_ = profileWorld.gridCollection_;
			long num = Convert.ToInt64((uint)playerHouse_.houseItemID_);
			GridObject playerHouseGridObject = (GridObject)0;
			GridState state_ = playerHouseGridObject.state_;
			if (state_ != null)
			{
				HouseData houseData = state_.HouseData;
				if (houseData != null && (long)houseData.upgradeState_ != 0)
				{
					House playerHouse_2 = profileWorld.playerHouse_;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int num2 = playerHouse_2.houseItemID_;
					BuildingItemData buildingItemData = default(BuildingItemData);
					RepeatedField<UpgradeData> upgradeInfo_ = buildingItemData.upgradeInfo_;
					Func<UpgradeData, bool> func = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData x)
					{
						//Discarded unreachable code: IL_0029
						GridObject gridObject = playerHouseGridObject;
						int level_ = x.level_;
						UpgradeState upgradeState_ = gridObject.state_.HouseData.upgradeState_;
						return level_ == upgradeState_.level_;
					};
					UpgradeData upgradeData = Enumerable.FirstOrDefault<UpgradeData>((IEnumerable<>)(object)upgradeInfo_, (Func<, >)(object)func);
					if (upgradeData != null)
					{
						return upgradeData.House;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042D7")]
		[Cpp2IlInjected.Address(RVA = "0x1706240", Offset = "0x1704C40", VA = "0x181706240")]
		public bool CanAddFloor(ProfileWorld profileWorld)
		{
			//Discarded unreachable code: IL_0025
			int count = ((RepeatedField<T>)(object)floors_).Count;
			BenefitsHouseData playerHouseLevelBenefits = GetPlayerHouseLevelBenefits(profileWorld);
			int num = 0;
			if (playerHouseLevelBenefits != null)
			{
				int expansionLimitsFloors_ = playerHouseLevelBenefits.expansionLimitsFloors_;
			}
			return count < num;
		}

		[Cpp2IlInjected.Token(Token = "0x60042D9")]
		[Cpp2IlInjected.Address(RVA = "0x1706FB0", Offset = "0x17059B0", VA = "0x181706FB0")]
		public int RoomExpansionCount(Profile profile, HouseExpansion houseExpansion)
		{
			//Discarded unreachable code: IL_0030
			RepeatedField<Types.Floor> repeatedField = floors_;
			Func<Types.Floor, int> func = (Func<Types.Floor, int>)(object)(Func<T, TResult>)delegate(Types.Floor f)
			{
				//Discarded unreachable code: IL_0035
				MapField<int, Types.Room> rooms_ = f.rooms_;
				Func<KeyValuePair<int, Types.Room>, int> func2 = (Func<KeyValuePair<int, Types.Room>, int>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000e
					HouseExpansion houseExpansion2 = houseExpansion;
					int result = default(int);
					return result;
				};
				return Enumerable.Sum<KeyValuePair<int, Types.Room>>((IEnumerable<>)(object)rooms_, (Func<, >)(object)func2);
			};
			return Enumerable.Sum<Types.Floor>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60042DA")]
		[Cpp2IlInjected.Address(RVA = "0x1707360", Offset = "0x1705D60", VA = "0x181707360")]
		static House()
		{
			MessageParser<Types.Floor> parser = Types.Floor._parser;
			uint num = default(uint);
			_parser = (MessageParser<House>)(object)FieldCodec.ForMessage<Types.Floor>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
