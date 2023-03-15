using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	public sealed class GiveItemsToCharacter : IMessage<GiveItemsToCharacter>, IMessage, IEquatable<GiveItemsToCharacter>, IDeepCloneable<GiveItemsToCharacter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200020E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200020F")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40006CE")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40006CF")]
				[OriginalName("InvalidCharacter")]
				InvalidCharacter,
				[Cpp2IlInjected.Token(Token = "0x40006D0")]
				[OriginalName("LimitationReachForToday")]
				LimitationReachForToday,
				[Cpp2IlInjected.Token(Token = "0x40006D1")]
				[OriginalName("TooManyItems")]
				TooManyItems,
				[Cpp2IlInjected.Token(Token = "0x40006D2")]
				[OriginalName("NotGiveMission")]
				NotGiveMission,
				[Cpp2IlInjected.Token(Token = "0x40006D3")]
				[OriginalName("WrongItems")]
				WrongItems,
				[Cpp2IlInjected.Token(Token = "0x40006D4")]
				[OriginalName("NotEnoughItemsInInventory")]
				NotEnoughItemsInInventory,
				[Cpp2IlInjected.Token(Token = "0x40006D5")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x2000210")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IInventoryFullRequest
			{
				[Cpp2IlInjected.Token(Token = "0x40006D6")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40006D7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40006D8")]
				public const int CharacterIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40006D9")]
				private int characterID_;

				[Cpp2IlInjected.Token(Token = "0x40006DA")]
				public const int GiveForMissionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40006DB")]
				private bool giveForMission_;

				[Cpp2IlInjected.Token(Token = "0x40006DC")]
				public const int MissionSlotClassFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40006DD")]
				private MissionSlotClass missionSlotClass_;

				[Cpp2IlInjected.Token(Token = "0x40006DE")]
				public const int MissionSlotIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40006DF")]
				private int missionSlotId_;

				[Cpp2IlInjected.Token(Token = "0x40006E0")]
				public const int ItemsGivenFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x40006E1")]
				private static readonly FieldCodec<ItemGiven> _repeated_itemsGiven_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40006E2")]
				private readonly RepeatedField<ItemGiven> itemsGiven_;

				[Cpp2IlInjected.Token(Token = "0x40006E3")]
				public const int InventoryFullResolutionFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40006E4")]
				private InventoryFullResolution inventoryFullResolution_;

				[Cpp2IlInjected.Token(Token = "0x170003D0")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001576")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE650", Offset = "0x1BFD050", VA = "0x181BFE650")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001577")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE450", Offset = "0x1BFCE50", VA = "0x181BFE450")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001578")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE890", Offset = "0x1BFD290", VA = "0x181BFE890", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D3")]
				[DebuggerNonUserCode]
				public int CharacterID
				{
					[Cpp2IlInjected.Token(Token = "0x600157C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600157D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D4")]
				[DebuggerNonUserCode]
				public bool GiveForMission
				{
					[Cpp2IlInjected.Token(Token = "0x600157E")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600157F")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D5")]
				[DebuggerNonUserCode]
				public MissionSlotClass MissionSlotClass
				{
					[Cpp2IlInjected.Token(Token = "0x6001580")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(MissionSlotClass);
					}
					[Cpp2IlInjected.Token(Token = "0x6001581")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D6")]
				[DebuggerNonUserCode]
				public int MissionSlotId
				{
					[Cpp2IlInjected.Token(Token = "0x6001582")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001583")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D7")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemGiven> ItemsGiven
				{
					[Cpp2IlInjected.Token(Token = "0x6001584")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003D8")]
				[DebuggerNonUserCode]
				public InventoryFullResolution InventoryFullResolution
				{
					[Cpp2IlInjected.Token(Token = "0x6001585")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "16")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001586")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "17")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001579")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDCB0", Offset = "0x1BFC6B0", VA = "0x181BFDCB0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600157A")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDE20", Offset = "0x1BFC820", VA = "0x181BFDE20")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600157B")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9620", Offset = "0x1BF8020", VA = "0x181BF9620", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001587")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9BD0", Offset = "0x1BF85D0", VA = "0x181BF9BD0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001588")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9CE0", Offset = "0x1BF86E0", VA = "0x181BF9CE0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001589")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA640", Offset = "0x1BF9040", VA = "0x181BFA640", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600158A")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB790", Offset = "0x1BFA190", VA = "0x181BFB790", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600158B")]
				[Cpp2IlInjected.Address(RVA = "0x1BFD1F0", Offset = "0x1BFBBF0", VA = "0x181BFD1F0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600158C")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8DA0", Offset = "0x1BF77A0", VA = "0x181BF8DA0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600158D")]
				[Cpp2IlInjected.Address(RVA = "0x1BFAC40", Offset = "0x1BF9640", VA = "0x181BFAC40", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600158E")]
				[Cpp2IlInjected.Address(RVA = "0x1BFAE60", Offset = "0x1BF9860", VA = "0x181BFAE60", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600158F")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA080", Offset = "0x1BF8A80", VA = "0x181BFA080", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001590")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB020", Offset = "0x1BF9A20", VA = "0x181BFB020", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001591")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9410", Offset = "0x1BF7E10", VA = "0x181BF9410", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001592")]
				[Cpp2IlInjected.Address(RVA = "0x1BFC180", Offset = "0x1BFAB80", VA = "0x181BFC180", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000212")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IInventoryFullResponse
			{
				[Cpp2IlInjected.Token(Token = "0x40006E8")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40006E9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40006EA")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40006EB")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40006EC")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40006ED")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40006EE")]
				public const int AllItemsGivensFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x40006EF")]
				private static readonly MapField<int, int>.Codec _map_allItemsGivens_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40006F0")]
				private readonly MapField<int, int> allItemsGivens_;

				[Cpp2IlInjected.Token(Token = "0x40006F1")]
				public const int KeepItemsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40006F2")]
				private bool keepItems_;

				[Cpp2IlInjected.Token(Token = "0x40006F3")]
				public const int FirstDailyPreferredItemFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x40006F4")]
				private bool firstDailyPreferredItem_;

				[Cpp2IlInjected.Token(Token = "0x40006F5")]
				public const int FriendshipGainedFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40006F6")]
				private int friendshipGained_;

				[Cpp2IlInjected.Token(Token = "0x40006F7")]
				public const int InventoryFullDetailsFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40006F8")]
				private InventoryFullDetails inventoryFullDetails_;

				[Cpp2IlInjected.Token(Token = "0x170003D9")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001599")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A880", Offset = "0x1C09280", VA = "0x181C0A880")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003DA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600159A")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A640", Offset = "0x1C09040", VA = "0x181C0A640")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003DB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600159B")]
					[Cpp2IlInjected.Address(RVA = "0x1C0AAC0", Offset = "0x1C094C0", VA = "0x181C0AAC0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003DC")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600159F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60015A0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003DD")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60015A1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60015A2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003DE")]
				[DebuggerNonUserCode]
				public MapField<int, int> AllItemsGivens
				{
					[Cpp2IlInjected.Token(Token = "0x60015A3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003DF")]
				[DebuggerNonUserCode]
				public bool KeepItems
				{
					[Cpp2IlInjected.Token(Token = "0x60015A4")]
					[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60015A5")]
					[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E0")]
				[DebuggerNonUserCode]
				public bool FirstDailyPreferredItem
				{
					[Cpp2IlInjected.Token(Token = "0x60015A6")]
					[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60015A7")]
					[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E1")]
				[DebuggerNonUserCode]
				public int FriendshipGained
				{
					[Cpp2IlInjected.Token(Token = "0x60015A8")]
					[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60015A9")]
					[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E2")]
				[DebuggerNonUserCode]
				public InventoryFullDetails InventoryFullDetails
				{
					[Cpp2IlInjected.Token(Token = "0x60015AA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "23")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60015AB")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0", Slot = "24")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E3")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60015B7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60015B8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600159C")]
				[Cpp2IlInjected.Address(RVA = "0x1C0A1E0", Offset = "0x1C08BE0", VA = "0x181C0A1E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600159D")]
				[Cpp2IlInjected.Address(RVA = "0x1C0A270", Offset = "0x1C08C70", VA = "0x181C0A270")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600159E")]
				[Cpp2IlInjected.Address(RVA = "0x1C04E30", Offset = "0x1C03830", VA = "0x181C04E30", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015AC")]
				[Cpp2IlInjected.Address(RVA = "0x1C04FB0", Offset = "0x1C039B0", VA = "0x181C04FB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015AD")]
				[Cpp2IlInjected.Address(RVA = "0x1C05510", Offset = "0x1C03F10", VA = "0x181C05510", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015AE")]
				[Cpp2IlInjected.Address(RVA = "0x1C06070", Offset = "0x1C04A70", VA = "0x181C06070", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015AF")]
				[Cpp2IlInjected.Address(RVA = "0x1C07E30", Offset = "0x1C06830", VA = "0x181C07E30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015B0")]
				[Cpp2IlInjected.Address(RVA = "0x1C08C00", Offset = "0x1C07600", VA = "0x181C08C00", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015B1")]
				[Cpp2IlInjected.Address(RVA = "0x1C03DA0", Offset = "0x1C027A0", VA = "0x181C03DA0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015B2")]
				[Cpp2IlInjected.Address(RVA = "0x1C06A60", Offset = "0x1C05460", VA = "0x181C06A60", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015B3")]
				[Cpp2IlInjected.Address(RVA = "0x1C06510", Offset = "0x1C04F10", VA = "0x181C06510", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015B4")]
				[Cpp2IlInjected.Address(RVA = "0x1C05B50", Offset = "0x1C04550", VA = "0x181C05B50", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015B5")]
				[Cpp2IlInjected.Address(RVA = "0x1C074D0", Offset = "0x1C05ED0", VA = "0x181C074D0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015B6")]
				[Cpp2IlInjected.Address(RVA = "0x1C04830", Offset = "0x1C03230", VA = "0x181C04830", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015B9")]
				[Cpp2IlInjected.Address(RVA = "0x1C01D80", Offset = "0x1C00780", VA = "0x181C01D80", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000215")]
			public sealed class ItemGiven : IMessage<ItemGiven>, IMessage, IEquatable<ItemGiven>, IDeepCloneable<ItemGiven>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000216")]
				public enum ItemGivenOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4000705")]
					None,
					[Cpp2IlInjected.Token(Token = "0x4000706")]
					ContainerInventoryItemGiven,
					[Cpp2IlInjected.Token(Token = "0x4000707")]
					ListInventoryItemGiven,
					[Cpp2IlInjected.Token(Token = "0x4000708")]
					CurrencyItemGiven
				}

				[Cpp2IlInjected.Token(Token = "0x40006FD")]
				private static readonly MessageParser<ItemGiven> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40006FE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40006FF")]
				public const int ContainerInventoryItemGivenFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000700")]
				public const int ListInventoryItemGivenFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4000701")]
				public const int CurrencyItemGivenFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000702")]
				private object itemGiven_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000703")]
				private ItemGivenOneofCase itemGivenCase_;

				[Cpp2IlInjected.Token(Token = "0x170003E4")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemGiven> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60015C2")]
					[Cpp2IlInjected.Address(RVA = "0x1BF81D0", Offset = "0x1BF6BD0", VA = "0x181BF81D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60015C3")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8010", Offset = "0x1BF6A10", VA = "0x181BF8010")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60015C4")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8230", Offset = "0x1BF6C30", VA = "0x181BF8230", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E7")]
				[DebuggerNonUserCode]
				public ContainerInventoryItemGiven ContainerInventoryItemGiven
				{
					[Cpp2IlInjected.Token(Token = "0x60015C8")]
					[Cpp2IlInjected.Address(RVA = "0x1BF7F50", Offset = "0x1BF6950", VA = "0x181BF7F50")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60015C9")]
					[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E8")]
				[DebuggerNonUserCode]
				public ListInventoryItemGiven ListInventoryItemGiven
				{
					[Cpp2IlInjected.Token(Token = "0x60015CA")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8170", Offset = "0x1BF6B70", VA = "0x181BF8170")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60015CB")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003E9")]
				[DebuggerNonUserCode]
				public CurrencyItemGiven CurrencyItemGiven
				{
					[Cpp2IlInjected.Token(Token = "0x60015CC")]
					[Cpp2IlInjected.Address(RVA = "0x1BF7FB0", Offset = "0x1BF69B0", VA = "0x181BF7FB0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60015CD")]
					[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003EA")]
				[DebuggerNonUserCode]
				public ItemGivenOneofCase ItemGivenCase
				{
					[Cpp2IlInjected.Token(Token = "0x60015CE")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(ItemGivenOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003EB")]
				public IItemGiven ItemGivenData
				{
					[Cpp2IlInjected.Token(Token = "0x60015DD")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8100", Offset = "0x1BF6B00", VA = "0x181BF8100")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003EC")]
				internal IItemGivenInternal ItemGivenDataInternal
				{
					[Cpp2IlInjected.Token(Token = "0x60015DE")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8090", Offset = "0x1BF6A90", VA = "0x181BF8090")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60015C5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ItemGiven()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015C6")]
				[Cpp2IlInjected.Address(RVA = "0x1BF7C50", Offset = "0x1BF6650", VA = "0x181BF7C50")]
				[DebuggerNonUserCode]
				public ItemGiven(ItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015C7")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6C30", Offset = "0x1BF5630", VA = "0x181BF6C30", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemGiven Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015CF")]
				[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
				[DebuggerNonUserCode]
				public void ClearItemGiven()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015D0")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6C90", Offset = "0x1BF5690", VA = "0x181BF6C90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015D1")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6CF0", Offset = "0x1BF56F0", VA = "0x181BF6CF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemGiven other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015D2")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6FD0", Offset = "0x1BF59D0", VA = "0x181BF6FD0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015D3")]
				[Cpp2IlInjected.Address(RVA = "0x1BF7940", Offset = "0x1BF6340", VA = "0x181BF7940", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015D4")]
				[Cpp2IlInjected.Address(RVA = "0x1BF79A0", Offset = "0x1BF63A0", VA = "0x181BF79A0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015D5")]
				[Cpp2IlInjected.Address(RVA = "0x1BF69B0", Offset = "0x1BF53B0", VA = "0x181BF69B0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015D6")]
				[Cpp2IlInjected.Address(RVA = "0x1BF7220", Offset = "0x1BF5C20", VA = "0x181BF7220", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015D7")]
				[Cpp2IlInjected.Address(RVA = "0x1BF7450", Offset = "0x1BF5E50", VA = "0x181BF7450", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015D8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6E50", Offset = "0x1BF5850", VA = "0x181BF6E50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015D9")]
				[Cpp2IlInjected.Address(RVA = "0x1BF77E0", Offset = "0x1BF61E0", VA = "0x181BF77E0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015DA")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6B80", Offset = "0x1BF5580", VA = "0x181BF6B80", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015DB")]
				[Cpp2IlInjected.Address(RVA = "0x1BF7170", Offset = "0x1BF5B70", VA = "0x181BF7170", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015DC")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6BC0", Offset = "0x1BF55C0", VA = "0x181BF6BC0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000218")]
			public sealed class ContainerInventoryItemGiven : IMessage<ContainerInventoryItemGiven>, IMessage, IEquatable<ContainerInventoryItemGiven>, IDeepCloneable<ContainerInventoryItemGiven>, IMessageFieldAccessor, IItemGivenInternal, IItemGiven
			{
				[Cpp2IlInjected.Token(Token = "0x400070A")]
				private static readonly MessageParser<ContainerInventoryItemGiven> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400070B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400070C")]
				public const int InventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400070D")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x400070E")]
				public const int InventoryPositionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400070F")]
				private int inventoryPosition_;

				[Cpp2IlInjected.Token(Token = "0x4000710")]
				public const int AmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000711")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x170003ED")]
				[DebuggerNonUserCode]
				public static MessageParser<ContainerInventoryItemGiven> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60015E3")]
					[Cpp2IlInjected.Address(RVA = "0x1BF5F20", Offset = "0x1BF4920", VA = "0x181BF5F20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003EE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60015E4")]
					[Cpp2IlInjected.Address(RVA = "0x1BF5EA0", Offset = "0x1BF48A0", VA = "0x181BF5EA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003EF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60015E5")]
					[Cpp2IlInjected.Address(RVA = "0x1BF5F80", Offset = "0x1BF4980", VA = "0x181BF5F80", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F0")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x60015E9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60015EA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F1")]
				[DebuggerNonUserCode]
				public int InventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x60015EB")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60015EC")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F2")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x60015ED")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "16")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60015EE")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60015E6")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ContainerInventoryItemGiven()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015E7")]
				[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
				[DebuggerNonUserCode]
				public ContainerInventoryItemGiven(ContainerInventoryItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015E8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5500", Offset = "0x1BF3F00", VA = "0x181BF5500", Slot = "10")]
				[DebuggerNonUserCode]
				public ContainerInventoryItemGiven Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015EF")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5590", Offset = "0x1BF3F90", VA = "0x181BF5590", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015F0")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ContainerInventoryItemGiven other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015F1")]
				[Cpp2IlInjected.Address(RVA = "0x180B0C0", Offset = "0x1809AC0", VA = "0x18180B0C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015F2")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5D30", Offset = "0x1BF4730", VA = "0x181BF5D30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015F3")]
				[Cpp2IlInjected.Address(RVA = "0x180B400", Offset = "0x1809E00", VA = "0x18180B400", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015F4")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5400", Offset = "0x1BF3E00", VA = "0x181BF5400", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60015F5")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ContainerInventoryItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015F6")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015F7")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5630", Offset = "0x1BF4030", VA = "0x181BF5630", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60015F8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5C10", Offset = "0x1BF4610", VA = "0x181BF5C10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015F9")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60015FA")]
				[Cpp2IlInjected.Address(RVA = "0x1BF5710", Offset = "0x1BF4110", VA = "0x181BF5710", Slot = "15")]
				public (Item, ItemState) GetItem(ProfilePlayer profilePlayer)
				{
					return default((Item, ItemState));
				}

				[Cpp2IlInjected.Token(Token = "0x60015FB")]
				[Cpp2IlInjected.Address(RVA = "0x1BF58C0", Offset = "0x1BF42C0", VA = "0x181BF58C0", Slot = "17")]
				public bool HasEnoughItems(ProfilePlayer profilePlayer)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60015FC")]
				[Cpp2IlInjected.Address(RVA = "0x1BF59E0", Offset = "0x1BF43E0", VA = "0x181BF59E0", Slot = "14")]
				void IItemGivenInternal.GiveItems(ProfilePlayer profilePlayer, IPlayerEventDispatcher dispatcher, ref Dictionary<(Item item, ItemState state), int> itemsGiven, bool keepItems = false)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200021A")]
			public sealed class ListInventoryItemGiven : IMessage<ListInventoryItemGiven>, IMessage, IEquatable<ListInventoryItemGiven>, IDeepCloneable<ListInventoryItemGiven>, IMessageFieldAccessor, IItemGivenInternal, IItemGiven
			{
				[Cpp2IlInjected.Token(Token = "0x4000713")]
				private static readonly MessageParser<ListInventoryItemGiven> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000714")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000715")]
				public const int InventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000716")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000717")]
				public const int ItemIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000718")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000719")]
				public const int AmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400071A")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x170003F3")]
				[DebuggerNonUserCode]
				public static MessageParser<ListInventoryItemGiven> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001601")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8C80", Offset = "0x1BF7680", VA = "0x181BF8C80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001602")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8C00", Offset = "0x1BF7600", VA = "0x181BF8C00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001603")]
					[Cpp2IlInjected.Address(RVA = "0x1BF8CE0", Offset = "0x1BF76E0", VA = "0x181BF8CE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F6")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6001607")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001608")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F7")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001609")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600160A")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003F8")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600160B")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "16")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600160C")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001604")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ListInventoryItemGiven()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001605")]
				[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
				[DebuggerNonUserCode]
				public ListInventoryItemGiven(ListInventoryItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001606")]
				[Cpp2IlInjected.Address(RVA = "0x1BF83F0", Offset = "0x1BF6DF0", VA = "0x181BF83F0", Slot = "10")]
				[DebuggerNonUserCode]
				public ListInventoryItemGiven Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600160D")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8480", Offset = "0x1BF6E80", VA = "0x181BF8480", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600160E")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ListInventoryItemGiven other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600160F")]
				[Cpp2IlInjected.Address(RVA = "0x180B0C0", Offset = "0x1809AC0", VA = "0x18180B0C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001610")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8A90", Offset = "0x1BF7490", VA = "0x181BF8A90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001611")]
				[Cpp2IlInjected.Address(RVA = "0x180B400", Offset = "0x1809E00", VA = "0x18180B400", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001612")]
				[Cpp2IlInjected.Address(RVA = "0x1BF82F0", Offset = "0x1BF6CF0", VA = "0x181BF82F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001613")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ListInventoryItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001614")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001615")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8520", Offset = "0x1BF6F20", VA = "0x181BF8520", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001616")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8970", Offset = "0x1BF7370", VA = "0x181BF8970", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001617")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001618")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8600", Offset = "0x1BF7000", VA = "0x181BF8600", Slot = "15")]
				public (Item, ItemState) GetItem(ProfilePlayer profilePlayer)
				{
					return default((Item, ItemState));
				}

				[Cpp2IlInjected.Token(Token = "0x6001619")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8690", Offset = "0x1BF7090", VA = "0x181BF8690", Slot = "17")]
				public bool HasEnoughItems(ProfilePlayer profilePlayer)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600161A")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8770", Offset = "0x1BF7170", VA = "0x181BF8770", Slot = "14")]
				void IItemGivenInternal.GiveItems(ProfilePlayer profilePlayer, IPlayerEventDispatcher dispatcher, ref Dictionary<(Item item, ItemState state), int> itemsGiven, bool keepItems = false)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200021C")]
			public sealed class CurrencyItemGiven : IMessage<CurrencyItemGiven>, IMessage, IEquatable<CurrencyItemGiven>, IDeepCloneable<CurrencyItemGiven>, IMessageFieldAccessor, IItemGivenInternal, IItemGiven
			{
				[Cpp2IlInjected.Token(Token = "0x400071C")]
				private static readonly MessageParser<CurrencyItemGiven> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400071D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400071E")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400071F")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000720")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000721")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x170003F9")]
				[DebuggerNonUserCode]
				public static MessageParser<CurrencyItemGiven> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600161F")]
					[Cpp2IlInjected.Address(RVA = "0x1BF6890", Offset = "0x1BF5290", VA = "0x181BF6890")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003FA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001620")]
					[Cpp2IlInjected.Address(RVA = "0x1BF6810", Offset = "0x1BF5210", VA = "0x181BF6810")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003FB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001621")]
					[Cpp2IlInjected.Address(RVA = "0x1BF68F0", Offset = "0x1BF52F0", VA = "0x181BF68F0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003FC")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001625")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001626")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003FD")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6001627")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "16")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001628")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001622")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public CurrencyItemGiven()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001623")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public CurrencyItemGiven(CurrencyItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001624")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6110", Offset = "0x1BF4B10", VA = "0x181BF6110", Slot = "10")]
				[DebuggerNonUserCode]
				public CurrencyItemGiven Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001629")]
				[Cpp2IlInjected.Address(RVA = "0x1BF61A0", Offset = "0x1BF4BA0", VA = "0x181BF61A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600162A")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CurrencyItemGiven other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600162B")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600162C")]
				[Cpp2IlInjected.Address(RVA = "0x1BF66A0", Offset = "0x1BF50A0", VA = "0x181BF66A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600162D")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600162E")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6040", Offset = "0x1BF4A40", VA = "0x181BF6040", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600162F")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CurrencyItemGiven other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001630")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001631")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6230", Offset = "0x1BF4C30", VA = "0x181BF6230", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001632")]
				[Cpp2IlInjected.Address(RVA = "0x1BF65E0", Offset = "0x1BF4FE0", VA = "0x181BF65E0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001633")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001634")]
				[Cpp2IlInjected.Address(RVA = "0x1BF62F0", Offset = "0x1BF4CF0", VA = "0x181BF62F0", Slot = "15")]
				public (Item, ItemState) GetItem(ProfilePlayer profilePlayer)
				{
					return default((Item, ItemState));
				}

				[Cpp2IlInjected.Token(Token = "0x6001635")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6380", Offset = "0x1BF4D80", VA = "0x181BF6380", Slot = "17")]
				public bool HasEnoughItems(ProfilePlayer profilePlayer)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001636")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6410", Offset = "0x1BF4E10", VA = "0x181BF6410", Slot = "14")]
				void IItemGivenInternal.GiveItems(ProfilePlayer profilePlayer, IPlayerEventDispatcher dispatcher, ref Dictionary<(Item item, ItemState state), int> itemsGiven, bool keepItems = false)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200021E")]
			internal interface IItemGivenInternal : IItemGiven
			{
				[Cpp2IlInjected.Token(Token = "0x600163B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				void GiveItems(ProfilePlayer profilePlayer, IPlayerEventDispatcher dispatcher, ref Dictionary<(Item item, ItemState state), int> itemsGiven, bool keepItems = false);
			}

			[Cpp2IlInjected.Token(Token = "0x200021F")]
			public interface IItemGiven
			{
				[Cpp2IlInjected.Token(Token = "0x170003FE")]
				int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600163D")]
					[Cpp2IlInjected.Address(Slot = "1")]
					get;
				}

				[Cpp2IlInjected.Token(Token = "0x600163C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				(Item, ItemState) GetItem(ProfilePlayer profilePlayer);

				[Cpp2IlInjected.Token(Token = "0x600163E")]
				[Cpp2IlInjected.Address(Slot = "2")]
				bool HasEnoughItems(ProfilePlayer profilePlayer);
			}

			[Cpp2IlInjected.Token(Token = "0x6001575")]
			[Cpp2IlInjected.Address(RVA = "0x99C7A0", Offset = "0x99B1A0", VA = "0x18099C7A0")]
			private static bool ValidateItemsGiven(ProfilePlayer profilePlayer, MissionSubStep subStep, RepeatedField<ItemGiven> itemsGiven)
			{
				//Discarded unreachable code: IL_00bd, IL_00c3, IL_00c9, IL_00cf, IL_00d5, IL_00db, IL_00e1
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Expected I4, but got Unknown
				bool flag3 = default(bool);
				uint num2 = default(uint);
				bool flag4 = default(bool);
				IItemGiven itemGiven = default(IItemGiven);
				int num3 = default(int);
				bool flag5 = default(bool);
				MissionObjective missionObjective = default(MissionObjective);
				while (true)
				{
					int num = 0;
					_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
					if (subStep == null)
					{
						break;
					}
					RepeatedField<MissionObjective> objectives_ = subStep.objectives_;
					if (objectives_ != null)
					{
						bool flag = Enumerable.Any<MissionObjective>((IEnumerable<>)(object)objectives_);
					}
					bool flag2 = num == 1;
					if (num == (flag2 ? 1 : 0))
					{
						break;
					}
					Dictionary<(Item, ItemState), int> dictionary = (CS_0024_003C_003E8__locals0.mergedItemsGiven = (Dictionary<(Item item, ItemState state), int>)(object)new Dictionary<TKey, TValue>());
					if (flag3)
					{
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						if (!flag4)
						{
						}
						num += itemGiven;
					}
					if (CS_0024_003C_003E8__locals0 != null)
					{
						continue;
					}
					if (num3 != 1)
					{
						if (_003C_003Ec._003C_003E9__7_0 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => default(float));
						}
						Predicate<MissionObjective> predicate = (Predicate<MissionObjective>)(object)(Predicate<T>)((MissionObjective x) => default(bool));
						if (flag5)
						{
							break;
						}
					}
					ItemFilter itemFilter_ = missionObjective.itemFilter_;
					int num4 = 0;
					Dictionary<(Item, ItemState), int> mergedItemsGiven = CS_0024_003C_003E8__locals0.mergedItemsGiven;
					int itemsQuantity = itemFilter_.GetItemsQuantity((Dictionary<, >)(object)mergedItemsGiven, (byte)num4 != 0);
					break;
				}
				int num5 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private static readonly MessageParser<GiveItemsToCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		[DebuggerNonUserCode]
		public static MessageParser<GiveItemsToCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001563")]
			[Cpp2IlInjected.Address(RVA = "0x1D05900", Offset = "0x1D04300", VA = "0x181D05900")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001564")]
			[Cpp2IlInjected.Address(RVA = "0x1D05830", Offset = "0x1D04230", VA = "0x181D05830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001565")]
			[Cpp2IlInjected.Address(RVA = "0x1D05960", Offset = "0x1D04360", VA = "0x181D05960", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001566")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GiveItemsToCharacter()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001567")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GiveItemsToCharacter(GiveItemsToCharacter other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001568")]
		[Cpp2IlInjected.Address(RVA = "0x1D05550", Offset = "0x1D03F50", VA = "0x181D05550", Slot = "10")]
		[DebuggerNonUserCode]
		public GiveItemsToCharacter Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GiveItemsToCharacter giveItemsToCharacter = default(GiveItemsToCharacter);
			giveItemsToCharacter.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (giveItemsToCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return giveItemsToCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001569")]
		[Cpp2IlInjected.Address(RVA = "0x1D055D0", Offset = "0x1D03FD0", VA = "0x181D055D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600156A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GiveItemsToCharacter other)
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

		[Cpp2IlInjected.Token(Token = "0x600156B")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600156C")]
		[Cpp2IlInjected.Address(RVA = "0x1D056C0", Offset = "0x1D040C0", VA = "0x181D056C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600156D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600156E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600156F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GiveItemsToCharacter other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001570")]
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

		[Cpp2IlInjected.Token(Token = "0x6001571")]
		[Cpp2IlInjected.Address(RVA = "0x1D05650", Offset = "0x1D04050", VA = "0x181D05650", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001572")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001573")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001574")]
		[Cpp2IlInjected.Address(RVA = "0x1D05720", Offset = "0x1D04120", VA = "0x181D05720")]
		static GiveItemsToCharacter()
		{
			Func<GiveItemsToCharacter> func = default(Func<GiveItemsToCharacter>);
			_parser = (MessageParser<GiveItemsToCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
