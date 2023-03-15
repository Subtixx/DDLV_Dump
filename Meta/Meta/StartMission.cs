using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20003FC")]
	public sealed class StartMission : IMessage<StartMission>, IMessage, IEquatable<StartMission>, IDeepCloneable<StartMission>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003FD")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003FE")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000C5D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000C5E")]
				[OriginalName("Expired")]
				Expired,
				[Cpp2IlInjected.Token(Token = "0x4000C5F")]
				[OriginalName("Locked")]
				Locked,
				[Cpp2IlInjected.Token(Token = "0x4000C60")]
				[OriginalName("OneOnGoingByCharacter")]
				OneOnGoingByCharacter,
				[Cpp2IlInjected.Token(Token = "0x4000C61")]
				[OriginalName("InventoryFull")]
				InventoryFull,
				[Cpp2IlInjected.Token(Token = "0x4000C62")]
				[OriginalName("WrongState")]
				WrongState
			}

			[Cpp2IlInjected.Token(Token = "0x20003FF")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IInventoryFullRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4000C63")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C64")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C65")]
				public const int SlotIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C66")]
				private int slotId_;

				[Cpp2IlInjected.Token(Token = "0x4000C67")]
				public const int SlotClassFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000C68")]
				private MissionSlotClass slotClass_;

				[Cpp2IlInjected.Token(Token = "0x4000C69")]
				public const int MissionChoiceFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C6A")]
				private MissionChoice missionChoice_;

				[Cpp2IlInjected.Token(Token = "0x4000C6B")]
				public const int FriendshipChoicesFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4000C6C")]
				private static readonly FieldCodec<FriendshipChoice> _repeated_friendshipChoices_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000C6D")]
				private readonly RepeatedField<FriendshipChoice> friendshipChoices_;

				[Cpp2IlInjected.Token(Token = "0x4000C6E")]
				public const int InventoryFullResolutionFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000C6F")]
				private InventoryFullResolution inventoryFullResolution_;

				[Cpp2IlInjected.Token(Token = "0x4000C70")]
				public const int StepIndexFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000C71")]
				private int stepIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000C72")]
				public const int AutoAcceptFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
				[Cpp2IlInjected.Token(Token = "0x4000C73")]
				private bool autoAccept_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
				[Cpp2IlInjected.Token(Token = "0x4000C74")]
				internal bool CheatForced;

				[Cpp2IlInjected.Token(Token = "0x17000717")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002719")]
					[Cpp2IlInjected.Address(RVA = "0x15BE140", Offset = "0x15BCB40", VA = "0x1815BE140")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000718")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600271A")]
					[Cpp2IlInjected.Address(RVA = "0x15BDB60", Offset = "0x15BC560", VA = "0x1815BDB60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000719")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600271B")]
					[Cpp2IlInjected.Address(RVA = "0x15BE860", Offset = "0x15BD260", VA = "0x1815BE860", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700071A")]
				[DebuggerNonUserCode]
				public int SlotId
				{
					[Cpp2IlInjected.Token(Token = "0x600271F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002720")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700071B")]
				[DebuggerNonUserCode]
				public MissionSlotClass SlotClass
				{
					[Cpp2IlInjected.Token(Token = "0x6002721")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(MissionSlotClass);
					}
					[Cpp2IlInjected.Token(Token = "0x6002722")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700071C")]
				[DebuggerNonUserCode]
				public MissionChoice MissionChoice
				{
					[Cpp2IlInjected.Token(Token = "0x6002723")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(MissionChoice);
					}
					[Cpp2IlInjected.Token(Token = "0x6002724")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700071D")]
				[DebuggerNonUserCode]
				public RepeatedField<FriendshipChoice> FriendshipChoices
				{
					[Cpp2IlInjected.Token(Token = "0x6002725")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700071E")]
				[DebuggerNonUserCode]
				public InventoryFullResolution InventoryFullResolution
				{
					[Cpp2IlInjected.Token(Token = "0x6002726")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "14")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002727")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "15")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700071F")]
				[DebuggerNonUserCode]
				public int StepIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6002728")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002729")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000720")]
				[DebuggerNonUserCode]
				public bool AutoAccept
				{
					[Cpp2IlInjected.Token(Token = "0x600272A")]
					[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600272B")]
					[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600271C")]
				[Cpp2IlInjected.Address(RVA = "0x15BD9E0", Offset = "0x15BC3E0", VA = "0x1815BD9E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600271D")]
				[Cpp2IlInjected.Address(RVA = "0x15BD830", Offset = "0x15BC230", VA = "0x1815BD830")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600271E")]
				[Cpp2IlInjected.Address(RVA = "0x15B9B20", Offset = "0x15B8520", VA = "0x1815B9B20", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600272C")]
				[Cpp2IlInjected.Address(RVA = "0x15BA490", Offset = "0x15B8E90", VA = "0x1815BA490", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600272D")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F90", Offset = "0x15B8990", VA = "0x1815B9F90", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600272E")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF80", Offset = "0x15B9980", VA = "0x1815BAF80", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600272F")]
				[Cpp2IlInjected.Address(RVA = "0x15BC0B0", Offset = "0x15BAAB0", VA = "0x1815BC0B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002730")]
				[Cpp2IlInjected.Address(RVA = "0x15BC600", Offset = "0x15BB000", VA = "0x1815BC600", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002731")]
				[Cpp2IlInjected.Address(RVA = "0x15B91E0", Offset = "0x15B7BE0", VA = "0x1815B91E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002732")]
				[Cpp2IlInjected.Address(RVA = "0x15BB2D0", Offset = "0x15B9CD0", VA = "0x1815BB2D0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002733")]
				[Cpp2IlInjected.Address(RVA = "0x15BB090", Offset = "0x15B9A90", VA = "0x1815BB090", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002734")]
				[Cpp2IlInjected.Address(RVA = "0x15BAB50", Offset = "0x15B9550", VA = "0x1815BAB50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002735")]
				[Cpp2IlInjected.Address(RVA = "0x15BB740", Offset = "0x15BA140", VA = "0x1815BB740", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002736")]
				[Cpp2IlInjected.Address(RVA = "0x15B96D0", Offset = "0x15B80D0", VA = "0x1815B96D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000401")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IInventoryFullResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4000C76")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C77")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C78")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C79")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000C7A")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C7B")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000C7C")]
				public const int InventoryFullDetailsFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000C7D")]
				private InventoryFullDetails inventoryFullDetails_;

				[Cpp2IlInjected.Token(Token = "0x17000721")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600273B")]
					[Cpp2IlInjected.Address(RVA = "0x15C9290", Offset = "0x15C7C90", VA = "0x1815C9290")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000722")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600273C")]
					[Cpp2IlInjected.Address(RVA = "0x15C8D70", Offset = "0x15C7770", VA = "0x1815C8D70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000723")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600273D")]
					[Cpp2IlInjected.Address(RVA = "0x15C9770", Offset = "0x15C8170", VA = "0x1815C9770", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000724")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002741")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002742")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000725")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002743")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002744")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000726")]
				[DebuggerNonUserCode]
				public InventoryFullDetails InventoryFullDetails
				{
					[Cpp2IlInjected.Token(Token = "0x6002745")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "23")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002746")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "24")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000727")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002752")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002753")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600273E")]
				[Cpp2IlInjected.Address(RVA = "0x15C7CD0", Offset = "0x15C66D0", VA = "0x1815C7CD0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600273F")]
				[Cpp2IlInjected.Address(RVA = "0x15C8290", Offset = "0x15C6C90", VA = "0x1815C8290")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002740")]
				[Cpp2IlInjected.Address(RVA = "0x15C38E0", Offset = "0x15C22E0", VA = "0x1815C38E0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002747")]
				[Cpp2IlInjected.Address(RVA = "0x15C3EC0", Offset = "0x15C28C0", VA = "0x1815C3EC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002748")]
				[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002749")]
				[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600274A")]
				[Cpp2IlInjected.Address(RVA = "0x15C6DF0", Offset = "0x15C57F0", VA = "0x1815C6DF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600274B")]
				[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600274C")]
				[Cpp2IlInjected.Address(RVA = "0x15C2E40", Offset = "0x15C1840", VA = "0x1815C2E40", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600274D")]
				[Cpp2IlInjected.Address(RVA = "0x15C5960", Offset = "0x15C4360", VA = "0x1815C5960", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600274E")]
				[Cpp2IlInjected.Address(RVA = "0x15C4EE0", Offset = "0x15C38E0", VA = "0x1815C4EE0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600274F")]
				[Cpp2IlInjected.Address(RVA = "0x15C4520", Offset = "0x15C2F20", VA = "0x1815C4520", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002750")]
				[Cpp2IlInjected.Address(RVA = "0x15C66A0", Offset = "0x15C50A0", VA = "0x1815C66A0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002751")]
				[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002754")]
				[Cpp2IlInjected.Address(RVA = "0x15C15B0", Offset = "0x15BFFB0", VA = "0x1815C15B0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C5A")]
		private static readonly MessageParser<StartMission> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C5B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000714")]
		[DebuggerNonUserCode]
		public static MessageParser<StartMission> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002707")]
			[Cpp2IlInjected.Address(RVA = "0xC04750", Offset = "0xC03150", VA = "0x180C04750")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000715")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002708")]
			[Cpp2IlInjected.Address(RVA = "0xC04680", Offset = "0xC03080", VA = "0x180C04680")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000716")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002709")]
			[Cpp2IlInjected.Address(RVA = "0xC047B0", Offset = "0xC031B0", VA = "0x180C047B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600270A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StartMission()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600270B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StartMission(StartMission other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600270C")]
		[Cpp2IlInjected.Address(RVA = "0xC043A0", Offset = "0xC02DA0", VA = "0x180C043A0", Slot = "10")]
		[DebuggerNonUserCode]
		public StartMission Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StartMission startMission = default(StartMission);
			startMission.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (startMission._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return startMission;
		}

		[Cpp2IlInjected.Token(Token = "0x600270D")]
		[Cpp2IlInjected.Address(RVA = "0xC04420", Offset = "0xC02E20", VA = "0x180C04420", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600270E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StartMission other)
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

		[Cpp2IlInjected.Token(Token = "0x600270F")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002710")]
		[Cpp2IlInjected.Address(RVA = "0xC04510", Offset = "0xC02F10", VA = "0x180C04510", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002711")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002712")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002713")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StartMission other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002714")]
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

		[Cpp2IlInjected.Token(Token = "0x6002715")]
		[Cpp2IlInjected.Address(RVA = "0xC044A0", Offset = "0xC02EA0", VA = "0x180C044A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002716")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002717")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002718")]
		[Cpp2IlInjected.Address(RVA = "0xC04570", Offset = "0xC02F70", VA = "0x180C04570")]
		static StartMission()
		{
			Func<StartMission> func = default(Func<StartMission>);
			_parser = (MessageParser<StartMission>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
