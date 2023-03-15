using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20003C4")]
	public sealed class FeedCritter : IMessage<FeedCritter>, IMessage, IEquatable<FeedCritter>, IDeepCloneable<FeedCritter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003C5")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003C6")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000BB4")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4000BB5")]
				[OriginalName("InvalidCritter")]
				InvalidCritter = 1,
				[Cpp2IlInjected.Token(Token = "0x4000BB6")]
				[OriginalName("InvalidContainerInventoryID")]
				InvalidContainerInventoryId = 4,
				[Cpp2IlInjected.Token(Token = "0x4000BB7")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems = 5
			}

			[Cpp2IlInjected.Token(Token = "0x20003C7")]
			public enum CritterReaction
			{
				[Cpp2IlInjected.Token(Token = "0x4000BB9")]
				[OriginalName("Like")]
				Like,
				[Cpp2IlInjected.Token(Token = "0x4000BBA")]
				[OriginalName("Favorite")]
				Favorite,
				[Cpp2IlInjected.Token(Token = "0x4000BBB")]
				[OriginalName("Hate")]
				Hate
			}

			[Cpp2IlInjected.Token(Token = "0x20003C8")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000BBC")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000BBD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000BBE")]
				public const int CritterItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000BBF")]
				private int critterItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000BC0")]
				public const int ContainerInventoryIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000BC1")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000BC2")]
				public const int ContainerInventoryPositionFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000BC3")]
				private int containerInventoryPosition_;

				[Cpp2IlInjected.Token(Token = "0x4000BC4")]
				public const int GridIDFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000BC5")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000BC6")]
				public const int RewardPositionXFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000BC7")]
				private int rewardPositionX_;

				[Cpp2IlInjected.Token(Token = "0x4000BC8")]
				public const int RewardPositionYFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000BC9")]
				private int rewardPositionY_;

				[Cpp2IlInjected.Token(Token = "0x170006B8")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600251F")]
					[Cpp2IlInjected.Address(RVA = "0x1E13A70", Offset = "0x1E12470", VA = "0x181E13A70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006B9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002520")]
					[Cpp2IlInjected.Address(RVA = "0x1E134B0", Offset = "0x1E11EB0", VA = "0x181E134B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006BA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002521")]
					[Cpp2IlInjected.Address(RVA = "0x1E143D0", Offset = "0x1E12DD0", VA = "0x181E143D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006BB")]
				[DebuggerNonUserCode]
				public int CritterItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002525")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002526")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006BC")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6002527")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6002528")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006BD")]
				[DebuggerNonUserCode]
				public int ContainerInventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6002529")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600252A")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006BE")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x600252B")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600252C")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006BF")]
				[DebuggerNonUserCode]
				public int RewardPositionX
				{
					[Cpp2IlInjected.Token(Token = "0x600252D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600252E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C0")]
				[DebuggerNonUserCode]
				public int RewardPositionY
				{
					[Cpp2IlInjected.Token(Token = "0x600252F")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002530")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002522")]
				[Cpp2IlInjected.Address(RVA = "0x1E12C40", Offset = "0x1E11640", VA = "0x181E12C40")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002523")]
				[Cpp2IlInjected.Address(RVA = "0x1E12C80", Offset = "0x1E11680", VA = "0x181E12C80")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002524")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D2B0", Offset = "0x1E0BCB0", VA = "0x181E0D2B0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002531")]
				[Cpp2IlInjected.Address(RVA = "0x1E0DA90", Offset = "0x1E0C490", VA = "0x181E0DA90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002532")]
				[Cpp2IlInjected.Address(RVA = "0x1E0DF00", Offset = "0x1E0C900", VA = "0x181E0DF00", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002533")]
				[Cpp2IlInjected.Address(RVA = "0x1E0EEE0", Offset = "0x1E0D8E0", VA = "0x181E0EEE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002534")]
				[Cpp2IlInjected.Address(RVA = "0x1E10450", Offset = "0x1E0EE50", VA = "0x181E10450", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002535")]
				[Cpp2IlInjected.Address(RVA = "0x1E117C0", Offset = "0x1E101C0", VA = "0x181E117C0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002536")]
				[Cpp2IlInjected.Address(RVA = "0x1E0C470", Offset = "0x1E0AE70", VA = "0x181E0C470", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002537")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F320", Offset = "0x1E0DD20", VA = "0x181E0F320", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002538")]
				[Cpp2IlInjected.Address(RVA = "0x1E0EFD0", Offset = "0x1E0D9D0", VA = "0x181E0EFD0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002539")]
				[Cpp2IlInjected.Address(RVA = "0x1E0E1D0", Offset = "0x1E0CBD0", VA = "0x181E0E1D0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600253A")]
				[Cpp2IlInjected.Address(RVA = "0x1E0FB20", Offset = "0x1E0E520", VA = "0x181E0FB20", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600253B")]
				[Cpp2IlInjected.Address(RVA = "0x18B3600", Offset = "0x18B2000", VA = "0x1818B3600", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600253C")]
				[Cpp2IlInjected.Address(RVA = "0x1E11170", Offset = "0x1E0FB70", VA = "0x181E11170", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003CB")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000BCC")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000BCD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000BCE")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000BCF")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000BD0")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000BD1")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000BD2")]
				public const int ReactionFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000BD3")]
				private CritterReaction reaction_;

				[Cpp2IlInjected.Token(Token = "0x4000BD4")]
				public const int UnlockedFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000BD5")]
				private bool unlocked_;

				[Cpp2IlInjected.Token(Token = "0x4000BD6")]
				private const string CritterFeedingRandomSeedName = "CritterFeeding";

				[Cpp2IlInjected.Token(Token = "0x170006C1")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002543")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F460", Offset = "0x1E8DE60", VA = "0x181E8F460")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002544")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EEE0", Offset = "0x1E8D8E0", VA = "0x181E8EEE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002545")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FC40", Offset = "0x1E8E640", VA = "0x181E8FC40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C4")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002549")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600254A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C5")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600254B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600254C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C6")]
				[DebuggerNonUserCode]
				public CritterReaction Reaction
				{
					[Cpp2IlInjected.Token(Token = "0x600254D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(CritterReaction);
					}
					[Cpp2IlInjected.Token(Token = "0x600254E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C7")]
				[DebuggerNonUserCode]
				public bool Unlocked
				{
					[Cpp2IlInjected.Token(Token = "0x600254F")]
					[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002550")]
					[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006C8")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600255C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600255D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002546")]
				[Cpp2IlInjected.Address(RVA = "0x1E8EAA0", Offset = "0x1E8D4A0", VA = "0x181E8EAA0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002547")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E510", Offset = "0x1E8CF10", VA = "0x181E8E510")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002548")]
				[Cpp2IlInjected.Address(RVA = "0x1E85BE0", Offset = "0x1E845E0", VA = "0x181E85BE0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002551")]
				[Cpp2IlInjected.Address(RVA = "0x1E86BF0", Offset = "0x1E855F0", VA = "0x181E86BF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002552")]
				[Cpp2IlInjected.Address(RVA = "0x1E868A0", Offset = "0x1E852A0", VA = "0x181E868A0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002553")]
				[Cpp2IlInjected.Address(RVA = "0x1E87F30", Offset = "0x1E86930", VA = "0x181E87F30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002554")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B550", Offset = "0x1E89F50", VA = "0x181E8B550", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002555")]
				[Cpp2IlInjected.Address(RVA = "0x1E8BE70", Offset = "0x1E8A870", VA = "0x181E8BE70", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002556")]
				[Cpp2IlInjected.Address(RVA = "0x1E84480", Offset = "0x1E82E80", VA = "0x181E84480", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002557")]
				[Cpp2IlInjected.Address(RVA = "0x1E890A0", Offset = "0x1E87AA0", VA = "0x181E890A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002558")]
				[Cpp2IlInjected.Address(RVA = "0x1E89470", Offset = "0x1E87E70", VA = "0x181E89470", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002559")]
				[Cpp2IlInjected.Address(RVA = "0x1E87B40", Offset = "0x1E86540", VA = "0x181E87B40", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600255A")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A3E0", Offset = "0x1E88DE0", VA = "0x181E8A3E0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600255B")]
				[Cpp2IlInjected.Address(RVA = "0x1E84DE0", Offset = "0x1E837E0", VA = "0x181E84DE0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600255E")]
				[Cpp2IlInjected.Address(RVA = "0x1E815C0", Offset = "0x1E7FFC0", VA = "0x181E815C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600255F")]
				[Cpp2IlInjected.Address(RVA = "0x1E880F0", Offset = "0x1E86AF0", VA = "0x181E880F0")]
				private void GiveFeedingReward(Player player, World world, ITransactionContext transactionContext, CritterItemData critterItemData, Random random)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002560")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B850", Offset = "0x1E8A250", VA = "0x181E8B850")]
				internal static void UnlockCritter(Critter critter, CritterItemData critterItemData, ProfilePlayer profilePlayer, IPlayerEventDispatcher dispatcher)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000BB1")]
		private static readonly MessageParser<FeedCritter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000BB2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170006B5")]
		[DebuggerNonUserCode]
		public static MessageParser<FeedCritter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600250D")]
			[Cpp2IlInjected.Address(RVA = "0x17F99E0", Offset = "0x17F83E0", VA = "0x1817F99E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600250E")]
			[Cpp2IlInjected.Address(RVA = "0x17F9910", Offset = "0x17F8310", VA = "0x1817F9910")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600250F")]
			[Cpp2IlInjected.Address(RVA = "0x17F9A40", Offset = "0x17F8440", VA = "0x1817F9A40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002510")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FeedCritter()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002511")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public FeedCritter(FeedCritter other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002512")]
		[Cpp2IlInjected.Address(RVA = "0x17F9630", Offset = "0x17F8030", VA = "0x1817F9630", Slot = "10")]
		[DebuggerNonUserCode]
		public FeedCritter Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			FeedCritter feedCritter = default(FeedCritter);
			feedCritter.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (feedCritter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return feedCritter;
		}

		[Cpp2IlInjected.Token(Token = "0x6002513")]
		[Cpp2IlInjected.Address(RVA = "0x17F96B0", Offset = "0x17F80B0", VA = "0x1817F96B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002514")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FeedCritter other)
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

		[Cpp2IlInjected.Token(Token = "0x6002515")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002516")]
		[Cpp2IlInjected.Address(RVA = "0x17F97A0", Offset = "0x17F81A0", VA = "0x1817F97A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002517")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002518")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002519")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FeedCritter other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600251A")]
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

		[Cpp2IlInjected.Token(Token = "0x600251B")]
		[Cpp2IlInjected.Address(RVA = "0x17F9730", Offset = "0x17F8130", VA = "0x1817F9730", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600251C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600251D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600251E")]
		[Cpp2IlInjected.Address(RVA = "0x17F9800", Offset = "0x17F8200", VA = "0x1817F9800")]
		static FeedCritter()
		{
			Func<FeedCritter> func = default(Func<FeedCritter>);
			_parser = (MessageParser<FeedCritter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
