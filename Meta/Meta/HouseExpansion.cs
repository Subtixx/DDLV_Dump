using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000814")]
	public sealed class HouseExpansion : IMessage<HouseExpansion>, IMessage, IEquatable<HouseExpansion>, IDeepCloneable<HouseExpansion>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000815")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000816")]
			public sealed class InteriorExpansion : IMessage<InteriorExpansion>, IMessage, IEquatable<InteriorExpansion>, IDeepCloneable<InteriorExpansion>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000817")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000818")]
					public sealed class ExpansionData : IMessage<ExpansionData>, IMessage, IEquatable<ExpansionData>, IDeepCloneable<ExpansionData>, IMessageFieldAccessor, IDataValidation
					{
						[Cpp2IlInjected.Token(Token = "0x4002050")]
						private static readonly MessageParser<ExpansionData> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4002051")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4002052")]
						public const int NameFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4002053")]
						private string name_;

						[Cpp2IlInjected.Token(Token = "0x4002054")]
						public const int RoomPrefabAddressFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4002055")]
						private string roomPrefabAddress_;

						[Cpp2IlInjected.Token(Token = "0x4002056")]
						public const int FloorGridDataPathFieldNumber = 3;

						[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
						[Cpp2IlInjected.Token(Token = "0x4002057")]
						private string floorGridDataPath_;

						[Cpp2IlInjected.Token(Token = "0x4002058")]
						public const int WallGridDataPathsFieldNumber = 4;

						[Cpp2IlInjected.Token(Token = "0x4002059")]
						private static readonly MapField<int, string>.Codec _map_wallGridDataPaths_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
						[Cpp2IlInjected.Token(Token = "0x400205A")]
						private readonly MapField<int, string> wallGridDataPaths_;

						[Cpp2IlInjected.Token(Token = "0x400205B")]
						public const int PriceFieldNumber = 5;

						[Cpp2IlInjected.Token(Token = "0x400205C")]
						private static readonly FieldCodec<CurrencyCost> _repeated_price_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
						[Cpp2IlInjected.Token(Token = "0x400205D")]
						private readonly RepeatedField<CurrencyCost> price_;

						[Cpp2IlInjected.Token(Token = "0x17000B14")]
						[DebuggerNonUserCode]
						public static MessageParser<ExpansionData> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60043A2")]
							[Cpp2IlInjected.Address(RVA = "0x3FA1030", Offset = "0x3F9FA30", VA = "0x183FA1030")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B15")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60043A3")]
							[Cpp2IlInjected.Address(RVA = "0x3FA0FB0", Offset = "0x3F9F9B0", VA = "0x183FA0FB0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B16")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60043A4")]
							[Cpp2IlInjected.Address(RVA = "0x3FA1090", Offset = "0x3F9FA90", VA = "0x183FA1090", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B17")]
						[DebuggerNonUserCode]
						public string Name
						{
							[Cpp2IlInjected.Token(Token = "0x60043A8")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60043A9")]
							[Cpp2IlInjected.Address(RVA = "0x3FA11C0", Offset = "0x3F9FBC0", VA = "0x183FA11C0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B18")]
						[DebuggerNonUserCode]
						public string RoomPrefabAddress
						{
							[Cpp2IlInjected.Token(Token = "0x60043AA")]
							[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60043AB")]
							[Cpp2IlInjected.Address(RVA = "0x3FA1230", Offset = "0x3F9FC30", VA = "0x183FA1230")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B19")]
						[DebuggerNonUserCode]
						public string FloorGridDataPath
						{
							[Cpp2IlInjected.Token(Token = "0x60043AC")]
							[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60043AD")]
							[Cpp2IlInjected.Address(RVA = "0x3FA1150", Offset = "0x3F9FB50", VA = "0x183FA1150")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B1A")]
						[DebuggerNonUserCode]
						public MapField<int, string> WallGridDataPaths
						{
							[Cpp2IlInjected.Token(Token = "0x60043AE")]
							[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000B1B")]
						[DebuggerNonUserCode]
						public RepeatedField<CurrencyCost> Price
						{
							[Cpp2IlInjected.Token(Token = "0x60043AF")]
							[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60043A5")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0DC0", Offset = "0x3F9F7C0", VA = "0x183FA0DC0")]
						[DebuggerNonUserCode]
						public ExpansionData()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043A6")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0EC0", Offset = "0x3F9F8C0", VA = "0x183FA0EC0")]
						[DebuggerNonUserCode]
						public ExpansionData(ExpansionData other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043A7")]
						[Cpp2IlInjected.Address(RVA = "0x3F9FA20", Offset = "0x3F9E420", VA = "0x183F9FA20", Slot = "10")]
						[DebuggerNonUserCode]
						public ExpansionData Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60043B0")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0000", Offset = "0x3F9EA00", VA = "0x183FA0000", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60043B1")]
						[Cpp2IlInjected.Address(RVA = "0x3F9FF00", Offset = "0x3F9E900", VA = "0x183F9FF00", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(ExpansionData other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60043B2")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0210", Offset = "0x3F9EC10", VA = "0x183FA0210", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60043B3")]
						[Cpp2IlInjected.Address(RVA = "0x3FA07A0", Offset = "0x3F9F1A0", VA = "0x183FA07A0", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60043B4")]
						[Cpp2IlInjected.Address(RVA = "0x3FA09C0", Offset = "0x3F9F3C0", VA = "0x183FA09C0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043B5")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F760", Offset = "0x3F9E160", VA = "0x183F9F760", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60043B6")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0310", Offset = "0x3F9ED10", VA = "0x183FA0310", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(ExpansionData other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043B7")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0410", Offset = "0x3F9EE10", VA = "0x183FA0410", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043B8")]
						[Cpp2IlInjected.Address(RVA = "0x3FA0150", Offset = "0x3F9EB50", VA = "0x183FA0150", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60043B9")]
						[Cpp2IlInjected.Address(RVA = "0x3FA05E0", Offset = "0x3F9EFE0", VA = "0x183FA05E0", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043BA")]
						[Cpp2IlInjected.Address(RVA = "0x3F9F910", Offset = "0x3F9E310", VA = "0x183F9F910", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043BB")]
						[Cpp2IlInjected.Address(RVA = "0x3F9FB40", Offset = "0x3F9E540", VA = "0x183F9FB40", Slot = "14")]
						public void DataValidation(DataValidation.Context context)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4002041")]
				private static readonly MessageParser<InteriorExpansion> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002042")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002043")]
				public const int IncreaseMainRoomSizeFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002044")]
				private static readonly FieldCodec<Types.ExpansionData> _repeated_increaseMainRoomSize_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002045")]
				private readonly RepeatedField<Types.ExpansionData> increaseMainRoomSize_;

				[Cpp2IlInjected.Token(Token = "0x4002046")]
				public const int AdditionalRoomsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4002047")]
				private static readonly FieldCodec<Types.ExpansionData> _repeated_additionalRooms_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002048")]
				private readonly RepeatedField<Types.ExpansionData> additionalRooms_;

				[Cpp2IlInjected.Token(Token = "0x4002049")]
				public const int DefaultDoorItemIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400204A")]
				private int defaultDoorItemID_;

				[Cpp2IlInjected.Token(Token = "0x400204B")]
				public const int MaximumNumberOfFloorsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x400204C")]
				private int maximumNumberOfFloors_;

				[Cpp2IlInjected.Token(Token = "0x400204D")]
				public const int AdditionalFloorPriceFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x400204E")]
				private static readonly FieldCodec<CurrencyCost> _repeated_additionalFloorPrice_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400204F")]
				private readonly RepeatedField<CurrencyCost> additionalFloorPrice_;

				[Cpp2IlInjected.Token(Token = "0x17000B0B")]
				[DebuggerNonUserCode]
				public static MessageParser<InteriorExpansion> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004388")]
					[Cpp2IlInjected.Address(RVA = "0x1E3CA80", Offset = "0x1E3B480", VA = "0x181E3CA80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B0C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004389")]
					[Cpp2IlInjected.Address(RVA = "0x1E3CA00", Offset = "0x1E3B400", VA = "0x181E3CA00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B0D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600438A")]
					[Cpp2IlInjected.Address(RVA = "0x1E3CAE0", Offset = "0x1E3B4E0", VA = "0x181E3CAE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B0E")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.ExpansionData> IncreaseMainRoomSize
				{
					[Cpp2IlInjected.Token(Token = "0x600438E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B0F")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.ExpansionData> AdditionalRooms
				{
					[Cpp2IlInjected.Token(Token = "0x600438F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B10")]
				[DebuggerNonUserCode]
				public int DefaultDoorItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6004390")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004391")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B11")]
				[DebuggerNonUserCode]
				public int MaximumNumberOfFloors
				{
					[Cpp2IlInjected.Token(Token = "0x6004392")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004393")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B12")]
				[DebuggerNonUserCode]
				public RepeatedField<CurrencyCost> AdditionalFloorPrice
				{
					[Cpp2IlInjected.Token(Token = "0x6004394")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B13")]
				public Item DefaultDoorItem
				{
					[Cpp2IlInjected.Token(Token = "0x60043A0")]
					[Cpp2IlInjected.Address(RVA = "0x1E3C9A0", Offset = "0x1E3B3A0", VA = "0x181E3C9A0")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600438B")]
				[Cpp2IlInjected.Address(RVA = "0x1E3C6D0", Offset = "0x1E3B0D0", VA = "0x181E3C6D0")]
				[DebuggerNonUserCode]
				public InteriorExpansion()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600438C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3C7C0", Offset = "0x1E3B1C0", VA = "0x181E3C7C0")]
				[DebuggerNonUserCode]
				public InteriorExpansion(InteriorExpansion other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600438D")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B8B0", Offset = "0x1E3A2B0", VA = "0x181E3B8B0", Slot = "10")]
				[DebuggerNonUserCode]
				public InteriorExpansion Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004395")]
				[Cpp2IlInjected.Address(RVA = "0x1E3BA00", Offset = "0x1E3A400", VA = "0x181E3BA00", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004396")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B910", Offset = "0x1E3A310", VA = "0x181E3B910", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(InteriorExpansion other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004397")]
				[Cpp2IlInjected.Address(RVA = "0x1E3BC40", Offset = "0x1E3A640", VA = "0x181E3BC40", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004398")]
				[Cpp2IlInjected.Address(RVA = "0x1E3C1C0", Offset = "0x1E3ABC0", VA = "0x181E3C1C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004399")]
				[Cpp2IlInjected.Address(RVA = "0x1E3C220", Offset = "0x1E3AC20", VA = "0x181E3C220", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600439A")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B660", Offset = "0x1E3A060", VA = "0x181E3B660", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600439B")]
				[Cpp2IlInjected.Address(RVA = "0x1E3BD20", Offset = "0x1E3A720", VA = "0x181E3BD20", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(InteriorExpansion other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600439C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3BE00", Offset = "0x1E3A800", VA = "0x181E3BE00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600439D")]
				[Cpp2IlInjected.Address(RVA = "0x1E3BB40", Offset = "0x1E3A540", VA = "0x181E3BB40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600439E")]
				[Cpp2IlInjected.Address(RVA = "0x1E3BFF0", Offset = "0x1E3A9F0", VA = "0x181E3BFF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600439F")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B810", Offset = "0x1E3A210", VA = "0x181E3B810", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400203B")]
		private static readonly MessageParser<HouseExpansion> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400203C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400203D")]
		public const int InteriorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400203E")]
		private Types.InteriorExpansion interior_;

		[Cpp2IlInjected.Token(Token = "0x400203F")]
		public const int AdditionalRoomsPerFloor = 3;

		[Cpp2IlInjected.Token(Token = "0x4002040")]
		public const int RoomsPerFloor = 4;

		[Cpp2IlInjected.Token(Token = "0x17000B03")]
		[DebuggerNonUserCode]
		public static MessageParser<HouseExpansion> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600436E")]
			[Cpp2IlInjected.Address(RVA = "0x1705860", Offset = "0x1704260", VA = "0x181705860")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B04")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600436F")]
			[Cpp2IlInjected.Address(RVA = "0x1705710", Offset = "0x1704110", VA = "0x181705710")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B05")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004370")]
			[Cpp2IlInjected.Address(RVA = "0x1705950", Offset = "0x1704350", VA = "0x181705950", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B06")]
		[DebuggerNonUserCode]
		public Types.InteriorExpansion Interior
		{
			[Cpp2IlInjected.Token(Token = "0x6004374")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return interior_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004375")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				interior_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B07")]
		public int FloorMax
		{
			[Cpp2IlInjected.Token(Token = "0x6004381")]
			[Cpp2IlInjected.Address(RVA = "0x1705840", Offset = "0x1704240", VA = "0x181705840")]
			get
			{
				//Discarded unreachable code: IL_000c
				return interior_.maximumNumberOfFloors_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B08")]
		public int RoomMax
		{
			[Cpp2IlInjected.Token(Token = "0x6004382")]
			[Cpp2IlInjected.Address(RVA = "0x1705930", Offset = "0x1704330", VA = "0x181705930")]
			get
			{
				//Discarded unreachable code: IL_000c
				return interior_.maximumNumberOfFloors_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B09")]
		public int ExpansionsPerRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6004383")]
			[Cpp2IlInjected.Address(RVA = "0x17057E0", Offset = "0x17041E0", VA = "0x1817057E0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return ((RepeatedField<T>)(object)interior_.increaseMainRoomSize_).Count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0A")]
		public int RoomExpansionMax
		{
			[Cpp2IlInjected.Token(Token = "0x6004384")]
			[Cpp2IlInjected.Address(RVA = "0x17058C0", Offset = "0x17042C0", VA = "0x1817058C0")]
			get
			{
				//Discarded unreachable code: IL_001f
				int maximumNumberOfFloors_ = interior_.maximumNumberOfFloors_;
				return ((RepeatedField<T>)(object)interior_.increaseMainRoomSize_).Count * maximumNumberOfFloors_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004371")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public HouseExpansion()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004372")]
		[Cpp2IlInjected.Address(RVA = "0x17056A0", Offset = "0x17040A0", VA = "0x1817056A0")]
		[DebuggerNonUserCode]
		public HouseExpansion(HouseExpansion other)
		{
			//IL_0021: Expected O, but got I4
			Types.InteriorExpansion interiorExpansion = other.interior_;
			if (interiorExpansion != null)
			{
				Types.InteriorExpansion interiorExpansion2 = interiorExpansion.Clone();
			}
			int num = 0;
			interior_ = (Types.InteriorExpansion)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004373")]
		[Cpp2IlInjected.Address(RVA = "0x1704E90", Offset = "0x1703890", VA = "0x181704E90", Slot = "10")]
		[DebuggerNonUserCode]
		public HouseExpansion Clone()
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected O, but got I4
			HouseExpansion houseExpansion = new HouseExpansion();
			Types.InteriorExpansion interiorExpansion = interior_;
			if (interiorExpansion != null)
			{
				Types.InteriorExpansion interiorExpansion2 = interiorExpansion.Clone();
			}
			int num = 0;
			houseExpansion.interior_ = (Types.InteriorExpansion)num;
			UnknownFieldSet unknownFieldSet = (houseExpansion._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return houseExpansion;
		}

		[Cpp2IlInjected.Token(Token = "0x6004376")]
		[Cpp2IlInjected.Address(RVA = "0x17050C0", Offset = "0x1703AC0", VA = "0x1817050C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(interior_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004377")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HouseExpansion other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.InteriorExpansion objB = other.interior_;
				if (object.Equals(interior_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004378")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Types.InteriorExpansion interiorExpansion = interior_;
				if (interiorExpansion != null)
				{
					int hashCode = interiorExpansion.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004379")]
		[Cpp2IlInjected.Address(RVA = "0x1705530", Offset = "0x1703F30", VA = "0x181705530", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600437A")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)interior_ != 0)
			{
				Types.InteriorExpansion value = interior_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600437B")]
		[Cpp2IlInjected.Address(RVA = "0x1704DF0", Offset = "0x17037F0", VA = "0x181704DF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.InteriorExpansion interiorExpansion = interior_;
				num = 0;
				if (interiorExpansion != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(interiorExpansion);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600437C")]
		[Cpp2IlInjected.Address(RVA = "0x1705300", Offset = "0x1703D00", VA = "0x181705300", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HouseExpansion other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.interior_ != 0)
			{
				Types.InteriorExpansion interiorExpansion = interior_;
				if (interiorExpansion == null)
				{
					Types.InteriorExpansion interiorExpansion2 = (interior_ = new Types.InteriorExpansion());
				}
				Types.InteriorExpansion other2 = other.interior_;
				interiorExpansion.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600437D")]
		[Cpp2IlInjected.Address(RVA = "0x17053D0", Offset = "0x1703DD0", VA = "0x1817053D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.InteriorExpansion interiorExpansion = interior_;
				if (interiorExpansion == null)
				{
					Types.InteriorExpansion interiorExpansion2 = (interior_ = new Types.InteriorExpansion());
				}
				input.ReadMessage(interiorExpansion);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600437E")]
		[Cpp2IlInjected.Address(RVA = "0x1705280", Offset = "0x1703C80", VA = "0x181705280", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.InteriorExpansion interiorExpansion = interior_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600437F")]
		[Cpp2IlInjected.Address(RVA = "0x17054B0", Offset = "0x1703EB0", VA = "0x1817054B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				interior_ = (Types.InteriorExpansion)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004380")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004385")]
		[Cpp2IlInjected.Address(RVA = "0x1705170", Offset = "0x1703B70", VA = "0x181705170")]
		public int GetExpansionIndex(string gridDataPath)
		{
			//Discarded unreachable code: IL_0036
			RepeatedField<Types.InteriorExpansion.Types.ExpansionData> increaseMainRoomSize_ = interior_.increaseMainRoomSize_;
			Func<Types.InteriorExpansion.Types.ExpansionData, bool> func = (Func<Types.InteriorExpansion.Types.ExpansionData, bool>)(object)(Func<T, TResult>)delegate(Types.InteriorExpansion.Types.ExpansionData x)
			{
				//Discarded unreachable code: IL_0014
				string b = gridDataPath;
				return string.Equals(x.floorGridDataPath_, b);
			};
			Types.InteriorExpansion.Types.ExpansionData item = Enumerable.FirstOrDefault<Types.InteriorExpansion.Types.ExpansionData>((IEnumerable<>)(object)increaseMainRoomSize_, (Func<, >)(object)func);
			return ((RepeatedField<T>)(object)increaseMainRoomSize_).IndexOf((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6004386")]
		[Cpp2IlInjected.Address(RVA = "0x1704F30", Offset = "0x1703930", VA = "0x181704F30", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0072
			//IL_0067: Expected O, but got I4
			int count = ((RepeatedField<T>)(object)interior_.increaseMainRoomSize_).Count;
			int count2 = ((RepeatedField<T>)(object)interior_.additionalRooms_).Count;
			if (count != count2)
			{
				context.AddError("IncreaseMainRoomSize and AdditionalRooms must have the same number of elements");
			}
			int count3 = ((RepeatedField<T>)(object)interior_.additionalFloorPrice_).Count;
			int maximumNumberOfFloors_ = interior_.maximumNumberOfFloors_;
			if (count3 != maximumNumberOfFloors_)
			{
				string error = string.Format("{0} must have a number of elements equal to {1} ({2} - 1)", "AdditionalFloorPrice", count3, "MaximumNumberOfFloors");
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004387")]
		[Cpp2IlInjected.Address(RVA = "0x1705590", Offset = "0x1703F90", VA = "0x181705590")]
		static HouseExpansion()
		{
			Func<HouseExpansion> func = default(Func<HouseExpansion>);
			_parser = (MessageParser<HouseExpansion>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
