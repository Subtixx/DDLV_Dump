using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20002FD")]
	public sealed class CreateGardeningTile : IMessage<CreateGardeningTile>, IMessage, IEquatable<CreateGardeningTile>, IDeepCloneable<CreateGardeningTile>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20002FE")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002FF")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400093A")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400093B")]
				[OriginalName("NoGardeningTool")]
				NoGardeningTool,
				[Cpp2IlInjected.Token(Token = "0x400093C")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x400093D")]
				[OriginalName("Occupied")]
				Occupied,
				[Cpp2IlInjected.Token(Token = "0x400093E")]
				[OriginalName("InventoryFull")]
				InventoryFull,
				[Cpp2IlInjected.Token(Token = "0x400093F")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana
			}

			[Cpp2IlInjected.Token(Token = "0x2000300")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000940")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000941")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000942")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000943")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000944")]
				public const int PositionXFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000945")]
				private int positionX_;

				[Cpp2IlInjected.Token(Token = "0x4000946")]
				public const int PositionYFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000947")]
				private int positionY_;

				[Cpp2IlInjected.Token(Token = "0x1700055D")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001DE4")]
					[Cpp2IlInjected.Address(RVA = "0x1F07AB0", Offset = "0x1F064B0", VA = "0x181F07AB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700055E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001DE5")]
					[Cpp2IlInjected.Address(RVA = "0x1F07650", Offset = "0x1F06050", VA = "0x181F07650")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700055F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001DE6")]
					[Cpp2IlInjected.Address(RVA = "0x1F082F0", Offset = "0x1F06CF0", VA = "0x181F082F0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000560")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6001DEA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001DEB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000561")]
				[DebuggerNonUserCode]
				public int PositionX
				{
					[Cpp2IlInjected.Token(Token = "0x6001DEC")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001DED")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000562")]
				[DebuggerNonUserCode]
				public int PositionY
				{
					[Cpp2IlInjected.Token(Token = "0x6001DEE")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001DEF")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001DE7")]
				[Cpp2IlInjected.Address(RVA = "0x1F07450", Offset = "0x1F05E50", VA = "0x181F07450")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DE8")]
				[Cpp2IlInjected.Address(RVA = "0x1F07510", Offset = "0x1F05F10", VA = "0x181F07510")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DE9")]
				[Cpp2IlInjected.Address(RVA = "0x1F02C20", Offset = "0x1F01620", VA = "0x181F02C20", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF0")]
				[Cpp2IlInjected.Address(RVA = "0x1F03000", Offset = "0x1F01A00", VA = "0x181F03000", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF1")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF2")]
				[Cpp2IlInjected.Address(RVA = "0x180B0C0", Offset = "0x1809AC0", VA = "0x18180B0C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF3")]
				[Cpp2IlInjected.Address(RVA = "0x1F04A70", Offset = "0x1F03470", VA = "0x181F04A70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF4")]
				[Cpp2IlInjected.Address(RVA = "0x180B400", Offset = "0x1809E00", VA = "0x18180B400", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF5")]
				[Cpp2IlInjected.Address(RVA = "0x1F01C50", Offset = "0x1F00650", VA = "0x181F01C50", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF6")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF7")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF8")]
				[Cpp2IlInjected.Address(RVA = "0x1F03840", Offset = "0x1F02240", VA = "0x181F03840", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001DF9")]
				[Cpp2IlInjected.Address(RVA = "0x1F04480", Offset = "0x1F02E80", VA = "0x181F04480", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DFA")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001DFB")]
				[Cpp2IlInjected.Address(RVA = "0x1F05640", Offset = "0x1F04040", VA = "0x181F05640", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x6001DFC")]
				[Cpp2IlInjected.Address(RVA = "0x1F01E20", Offset = "0x1F00820", VA = "0x181F01E20")]
				internal static Result CheckPosition(in Player player, IGridInternal grid, GridPosition gridPosition, GardenItemData gardenItemData, out List<GridObject> conflictedObjects)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000302")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000949")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400094A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400094B")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400094C")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400094D")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400094E")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x400094F")]
				public const int CollectedItemsFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000950")]
				private static readonly FieldCodec<CollectedItem> _repeated_collectedItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000951")]
				private readonly RepeatedField<CollectedItem> collectedItems_;

				[Cpp2IlInjected.Token(Token = "0x17000563")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001E01")]
					[Cpp2IlInjected.Address(RVA = "0x1F15B20", Offset = "0x1F14520", VA = "0x181F15B20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000564")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001E02")]
					[Cpp2IlInjected.Address(RVA = "0x1F159E0", Offset = "0x1F143E0", VA = "0x181F159E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000565")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001E03")]
					[Cpp2IlInjected.Address(RVA = "0x1F15E80", Offset = "0x1F14880", VA = "0x181F15E80", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000566")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001E07")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001E08")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000567")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001E09")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001E0A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000568")]
				[DebuggerNonUserCode]
				public RepeatedField<CollectedItem> CollectedItems
				{
					[Cpp2IlInjected.Token(Token = "0x6001E0B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000569")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001E17")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001E18")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001E04")]
				[Cpp2IlInjected.Address(RVA = "0x1F14F10", Offset = "0x1F13910", VA = "0x181F14F10")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E05")]
				[Cpp2IlInjected.Address(RVA = "0x1F14740", Offset = "0x1F13140", VA = "0x181F14740")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E06")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F3E0", Offset = "0x1F0DDE0", VA = "0x181F0F3E0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E0C")]
				[Cpp2IlInjected.Address(RVA = "0x1F105D0", Offset = "0x1F0EFD0", VA = "0x181F105D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E0D")]
				[Cpp2IlInjected.Address(RVA = "0x1F10480", Offset = "0x1F0EE80", VA = "0x181F10480", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E0E")]
				[Cpp2IlInjected.Address(RVA = "0x7F55D0", Offset = "0x7F3FD0", VA = "0x1807F55D0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E0F")]
				[Cpp2IlInjected.Address(RVA = "0x1F13430", Offset = "0x1F11E30", VA = "0x181F13430", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E10")]
				[Cpp2IlInjected.Address(RVA = "0x1F138B0", Offset = "0x1F122B0", VA = "0x181F138B0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E11")]
				[Cpp2IlInjected.Address(RVA = "0x1F0E8D0", Offset = "0x1F0D2D0", VA = "0x181F0E8D0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E12")]
				[Cpp2IlInjected.Address(RVA = "0x1F11DE0", Offset = "0x1F107E0", VA = "0x181F11DE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E13")]
				[Cpp2IlInjected.Address(RVA = "0x1F119E0", Offset = "0x1F103E0", VA = "0x181F119E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E14")]
				[Cpp2IlInjected.Address(RVA = "0x1F10BA0", Offset = "0x1F0F5A0", VA = "0x181F10BA0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E15")]
				[Cpp2IlInjected.Address(RVA = "0x1F13300", Offset = "0x1F11D00", VA = "0x181F13300", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E16")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F1B0", Offset = "0x1F0DBB0", VA = "0x181F0F1B0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E19")]
				[Cpp2IlInjected.Address(RVA = "0x1F0DBB0", Offset = "0x1F0C5B0", VA = "0x181F0DBB0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E1A")]
				[Cpp2IlInjected.Address(RVA = "0x1F125F0", Offset = "0x1F10FF0", VA = "0x181F125F0")]
				private void RemoveConflictedObjects(in Player player, in World world, ITransactionContext transactionContext, IGridInternal grid, List<GridObject> conflictedObjects)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000304")]
			public sealed class ListOfLandscapingExceptions : IMessage<ListOfLandscapingExceptions>, IMessage, IEquatable<ListOfLandscapingExceptions>, IDeepCloneable<ListOfLandscapingExceptions>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000953")]
				private static readonly MessageParser<ListOfLandscapingExceptions> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000954")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000955")]
				public const int ExceptionsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000956")]
				private static readonly FieldCodec<int> _repeated_exceptions_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000957")]
				private readonly RepeatedField<int> exceptions_;

				[Cpp2IlInjected.Token(Token = "0x1700056A")]
				[DebuggerNonUserCode]
				public static MessageParser<ListOfLandscapingExceptions> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001E1F")]
					[Cpp2IlInjected.Address(RVA = "0x1F014E0", Offset = "0x1EFFEE0", VA = "0x181F014E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700056B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001E20")]
					[Cpp2IlInjected.Address(RVA = "0x1F01460", Offset = "0x1EFFE60", VA = "0x181F01460")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700056C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001E21")]
					[Cpp2IlInjected.Address(RVA = "0x1F01540", Offset = "0x1EFFF40", VA = "0x181F01540", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700056D")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Exceptions
				{
					[Cpp2IlInjected.Token(Token = "0x6001E25")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001E22")]
				[Cpp2IlInjected.Address(RVA = "0x1F013E0", Offset = "0x1EFFDE0", VA = "0x181F013E0")]
				[DebuggerNonUserCode]
				public ListOfLandscapingExceptions()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E23")]
				[Cpp2IlInjected.Address(RVA = "0x1F012E0", Offset = "0x1EFFCE0", VA = "0x181F012E0")]
				[DebuggerNonUserCode]
				public ListOfLandscapingExceptions(ListOfLandscapingExceptions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E24")]
				[Cpp2IlInjected.Address(RVA = "0x1F00B90", Offset = "0x1EFF590", VA = "0x181F00B90", Slot = "10")]
				[DebuggerNonUserCode]
				public ListOfLandscapingExceptions Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E26")]
				[Cpp2IlInjected.Address(RVA = "0x1F00CC0", Offset = "0x1EFF6C0", VA = "0x181F00CC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E27")]
				[Cpp2IlInjected.Address(RVA = "0x1F00DA0", Offset = "0x1EFF7A0", VA = "0x181F00DA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ListOfLandscapingExceptions other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E28")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E29")]
				[Cpp2IlInjected.Address(RVA = "0x1F01080", Offset = "0x1EFFA80", VA = "0x181F01080", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E2A")]
				[Cpp2IlInjected.Address(RVA = "0x1F010E0", Offset = "0x1EFFAE0", VA = "0x181F010E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E2B")]
				[Cpp2IlInjected.Address(RVA = "0x1F00A80", Offset = "0x1EFF480", VA = "0x181F00A80", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E2C")]
				[Cpp2IlInjected.Address(RVA = "0x1F00EB0", Offset = "0x1EFF8B0", VA = "0x181F00EB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ListOfLandscapingExceptions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E2D")]
				[Cpp2IlInjected.Address(RVA = "0x1F00F30", Offset = "0x1EFF930", VA = "0x181F00F30", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E2E")]
				[Cpp2IlInjected.Address(RVA = "0x1F00E30", Offset = "0x1EFF830", VA = "0x181F00E30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E2F")]
				[Cpp2IlInjected.Address(RVA = "0x1F01020", Offset = "0x1EFFA20", VA = "0x181F01020", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E30")]
				[Cpp2IlInjected.Address(RVA = "0x1F00B30", Offset = "0x1EFF530", VA = "0x181F00B30", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000306")]
			public sealed class CollectedItem : IMessage<CollectedItem>, IMessage, IEquatable<CollectedItem>, IDeepCloneable<CollectedItem>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000959")]
				private static readonly MessageParser<CollectedItem> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400095A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400095B")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400095C")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x400095D")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400095E")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x1700056E")]
				[DebuggerNonUserCode]
				public static MessageParser<CollectedItem> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001E35")]
					[Cpp2IlInjected.Address(RVA = "0x1F00960", Offset = "0x1EFF360", VA = "0x181F00960")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700056F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001E36")]
					[Cpp2IlInjected.Address(RVA = "0x1F008E0", Offset = "0x1EFF2E0", VA = "0x181F008E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000570")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001E37")]
					[Cpp2IlInjected.Address(RVA = "0x1F009C0", Offset = "0x1EFF3C0", VA = "0x181F009C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000571")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001E3B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001E3C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000572")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6001E3D")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001E3E")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001E38")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public CollectedItem()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E39")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public CollectedItem(CollectedItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E3A")]
				[Cpp2IlInjected.Address(RVA = "0x1F004D0", Offset = "0x1EFEED0", VA = "0x181F004D0", Slot = "10")]
				[DebuggerNonUserCode]
				public CollectedItem Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E3F")]
				[Cpp2IlInjected.Address(RVA = "0x1F00560", Offset = "0x1EFEF60", VA = "0x181F00560", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E40")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CollectedItem other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E41")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E42")]
				[Cpp2IlInjected.Address(RVA = "0x1F00770", Offset = "0x1EFF170", VA = "0x181F00770", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E43")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E44")]
				[Cpp2IlInjected.Address(RVA = "0x1F00400", Offset = "0x1EFEE00", VA = "0x181F00400", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001E45")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CollectedItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E46")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E47")]
				[Cpp2IlInjected.Address(RVA = "0x1F005F0", Offset = "0x1EFEFF0", VA = "0x181F005F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001E48")]
				[Cpp2IlInjected.Address(RVA = "0x1F006B0", Offset = "0x1EFF0B0", VA = "0x181F006B0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001E49")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000936")]
		private static readonly MessageParser<CreateGardeningTile> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000937")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000938")]
		public static readonly Item GardeningTileItem;

		[Cpp2IlInjected.Token(Token = "0x1700055A")]
		[DebuggerNonUserCode]
		public static MessageParser<CreateGardeningTile> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001DD0")]
			[Cpp2IlInjected.Address(RVA = "0x18BD7F0", Offset = "0x18BC1F0", VA = "0x1818BD7F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DD1")]
			[Cpp2IlInjected.Address(RVA = "0x18BD720", Offset = "0x18BC120", VA = "0x1818BD720")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DD2")]
			[Cpp2IlInjected.Address(RVA = "0x18BD850", Offset = "0x18BC250", VA = "0x1818BD850", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CreateGardeningTile()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public CreateGardeningTile(CreateGardeningTile other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD5")]
		[Cpp2IlInjected.Address(RVA = "0x18BCE50", Offset = "0x18BB850", VA = "0x1818BCE50", Slot = "10")]
		[DebuggerNonUserCode]
		public CreateGardeningTile Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			CreateGardeningTile createGardeningTile = default(CreateGardeningTile);
			createGardeningTile.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (createGardeningTile._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return createGardeningTile;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD6")]
		[Cpp2IlInjected.Address(RVA = "0x18BCED0", Offset = "0x18BB8D0", VA = "0x1818BCED0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001DD7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CreateGardeningTile other)
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

		[Cpp2IlInjected.Token(Token = "0x6001DD8")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD9")]
		[Cpp2IlInjected.Address(RVA = "0x18BD560", Offset = "0x18BBF60", VA = "0x1818BD560", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CreateGardeningTile other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDD")]
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

		[Cpp2IlInjected.Token(Token = "0x6001DDE")]
		[Cpp2IlInjected.Address(RVA = "0x18BCF50", Offset = "0x18BB950", VA = "0x1818BCF50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE1")]
		[Cpp2IlInjected.Address(RVA = "0x18BCDF0", Offset = "0x18BB7F0", VA = "0x1818BCDF0")]
		public static GridPosition AdjustPosition(GridPosition position)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected I4, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			int x = position.X;
			x++;
			x = (int)(x + position);
			int x2 = position.X;
			x2++;
			x2 = (int)(x2 + position);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE2")]
		[Cpp2IlInjected.Address(RVA = "0x18BCFC0", Offset = "0x18BB9C0", VA = "0x1818BCFC0")]
		internal unsafe static void SetupGardenProduction(Item seedItem, uint gridID, uint gridObjectID, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00f1
			//IL_00de: Expected O, but got I4
			int itemID = seedItem.ItemID;
			int num = 0;
			bool flag = world.Section.gridCollection_.TryGetGrid(gridID, out *(IGridInternal*)num);
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			GardenData gardenData = default(GardenData);
			RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
			int index = 0;
			((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_)[index]).PlantedSeedItemID = itemID;
			GardenData gardenData2 = default(GardenData);
			RepeatedField<GardenData.Types.GardeningSlot> slots_2 = gardenData2.slots_;
			int index2 = 0;
			GardenData.Types.GardeningSlot gardeningSlot = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_2)[index2];
			TreeAndBushData treeAndBushData = new TreeAndBushData();
			Timestamp endOfGrowth_ = default(Timestamp);
			treeAndBushData.endOfGrowth_ = endOfGrowth_;
			SeedItemData seedItemData = default(SeedItemData);
			int num3 = (treeAndBushData.numberOfProductionLeft_ = seedItemData.numberOfGrowthPeriods_);
			gardeningSlot.Harvest = treeAndBushData;
			if (world.dispatcher != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				int num5 = 0;
			}
			IWorldEventDispatcher dispatcher = world.dispatcher;
			if (dispatcher != null)
			{
				Village village_ = world.Section.village_;
				uint num6 = default(uint);
				if (num < (int)num6)
				{
					num += num;
					num++;
				}
				int num7 = default(int);
				GardeningDetail gardeningDetail = new GardeningDetail(village_.IsVillageGridID((uint)num), (byte)num7 != 0, (Nullable<>)num, (byte)num != 0, (byte)num != 0);
				num7 = 0;
				uint num8 = default(uint);
				if (num < (int)num8)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE3")]
		[Cpp2IlInjected.Address(RVA = "0x18BD5C0", Offset = "0x18BBFC0", VA = "0x1818BD5C0")]
		static CreateGardeningTile()
		{
			Func<CreateGardeningTile> func = default(Func<CreateGardeningTile>);
			GardeningTileItem = (Item)(_parser = (MessageParser<CreateGardeningTile>)(object)new MessageParser<T>((Func<>)(object)func));
		}
	}
}
