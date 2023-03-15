using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	public sealed class ChangeCharacterProfession : IMessage<ChangeCharacterProfession>, IMessage, IEquatable<ChangeCharacterProfession>, IDeepCloneable<ChangeCharacterProfession>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001E6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20001E7")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000669")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400066A")]
				[OriginalName("InvalidCharacter")]
				InvalidCharacter,
				[Cpp2IlInjected.Token(Token = "0x400066B")]
				[OriginalName("InvalidProfession")]
				InvalidProfession,
				[Cpp2IlInjected.Token(Token = "0x400066C")]
				[OriginalName("InvalidManual")]
				InvalidManual,
				[Cpp2IlInjected.Token(Token = "0x400066D")]
				[OriginalName("InvalidInventory")]
				InvalidInventory,
				[Cpp2IlInjected.Token(Token = "0x400066E")]
				[OriginalName("InvalidInventoryPostion")]
				InvalidInventoryPostion,
				[Cpp2IlInjected.Token(Token = "0x400066F")]
				[OriginalName("IncorrectLevel")]
				IncorrectLevel,
				[Cpp2IlInjected.Token(Token = "0x4000670")]
				[OriginalName("InvalidProfessionForCharacter")]
				InvalidProfessionForCharacter
			}

			[Cpp2IlInjected.Token(Token = "0x20001E8")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000671")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000672")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000673")]
				public const int CharacterIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000674")]
				private int characterID_;

				[Cpp2IlInjected.Token(Token = "0x4000675")]
				public const int InventoryIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000676")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000677")]
				public const int InventoryPositionFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000678")]
				private int inventoryPosition_;

				[Cpp2IlInjected.Token(Token = "0x1700038D")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001408")]
					[Cpp2IlInjected.Address(RVA = "0x272B550", Offset = "0x2729F50", VA = "0x18272B550")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700038E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001409")]
					[Cpp2IlInjected.Address(RVA = "0x272B110", Offset = "0x2729B10", VA = "0x18272B110")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700038F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600140A")]
					[Cpp2IlInjected.Address(RVA = "0x272BCD0", Offset = "0x272A6D0", VA = "0x18272BCD0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000390")]
				[DebuggerNonUserCode]
				public int CharacterID
				{
					[Cpp2IlInjected.Token(Token = "0x600140E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600140F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000391")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6001410")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001411")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000392")]
				[DebuggerNonUserCode]
				public int InventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6001412")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001413")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600140B")]
				[Cpp2IlInjected.Address(RVA = "0x272AC10", Offset = "0x2729610", VA = "0x18272AC10")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600140C")]
				[Cpp2IlInjected.Address(RVA = "0x272A490", Offset = "0x2728E90", VA = "0x18272A490")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600140D")]
				[Cpp2IlInjected.Address(RVA = "0x2725230", Offset = "0x2723C30", VA = "0x182725230", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001414")]
				[Cpp2IlInjected.Address(RVA = "0x2725DC0", Offset = "0x27247C0", VA = "0x182725DC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001415")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001416")]
				[Cpp2IlInjected.Address(RVA = "0x1DF83C0", Offset = "0x1DF6DC0", VA = "0x181DF83C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001417")]
				[Cpp2IlInjected.Address(RVA = "0x2728380", Offset = "0x2726D80", VA = "0x182728380", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001418")]
				[Cpp2IlInjected.Address(RVA = "0x1E7DB60", Offset = "0x1E7C560", VA = "0x181E7DB60", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001419")]
				[Cpp2IlInjected.Address(RVA = "0x2724930", Offset = "0x2723330", VA = "0x182724930", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600141A")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600141B")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600141C")]
				[Cpp2IlInjected.Address(RVA = "0x27269E0", Offset = "0x27253E0", VA = "0x1827269E0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600141D")]
				[Cpp2IlInjected.Address(RVA = "0x2728020", Offset = "0x2726A20", VA = "0x182728020", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600141E")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600141F")]
				[Cpp2IlInjected.Address(RVA = "0x2728640", Offset = "0x2727040", VA = "0x182728640", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20001EA")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400067A")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400067B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400067C")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400067D")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400067E")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400067F")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000393")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001424")]
					[Cpp2IlInjected.Address(RVA = "0x2735C30", Offset = "0x2734630", VA = "0x182735C30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000394")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001425")]
					[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734430", VA = "0x182735A30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000395")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001426")]
					[Cpp2IlInjected.Address(RVA = "0x27366B0", Offset = "0x27350B0", VA = "0x1827366B0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000396")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600142A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600142B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000397")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600142C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600142D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000398")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001439")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600143A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001427")]
				[Cpp2IlInjected.Address(RVA = "0x2734DB0", Offset = "0x27337B0", VA = "0x182734DB0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001428")]
				[Cpp2IlInjected.Address(RVA = "0x27355C0", Offset = "0x2733FC0", VA = "0x1827355C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001429")]
				[Cpp2IlInjected.Address(RVA = "0x272F7D0", Offset = "0x272E1D0", VA = "0x18272F7D0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600142E")]
				[Cpp2IlInjected.Address(RVA = "0x27300F0", Offset = "0x272EAF0", VA = "0x1827300F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600142F")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001430")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001431")]
				[Cpp2IlInjected.Address(RVA = "0x2733960", Offset = "0x2732360", VA = "0x182733960", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001432")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001433")]
				[Cpp2IlInjected.Address(RVA = "0x272EF00", Offset = "0x272D900", VA = "0x18272EF00", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001434")]
				[Cpp2IlInjected.Address(RVA = "0x2732300", Offset = "0x2730D00", VA = "0x182732300", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001435")]
				[Cpp2IlInjected.Address(RVA = "0x27326C0", Offset = "0x27310C0", VA = "0x1827326C0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001436")]
				[Cpp2IlInjected.Address(RVA = "0x2730CD0", Offset = "0x272F6D0", VA = "0x182730CD0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001437")]
				[Cpp2IlInjected.Address(RVA = "0x2733570", Offset = "0x2731F70", VA = "0x182733570", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001438")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600143B")]
				[Cpp2IlInjected.Address(RVA = "0x272CA50", Offset = "0x272B450", VA = "0x18272CA50", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private static readonly MessageParser<ChangeCharacterProfession> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		[DebuggerNonUserCode]
		public static MessageParser<ChangeCharacterProfession> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60013F6")]
			[Cpp2IlInjected.Address(RVA = "0x718E10", Offset = "0x717810", VA = "0x180718E10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013F7")]
			[Cpp2IlInjected.Address(RVA = "0x718D40", Offset = "0x717740", VA = "0x180718D40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013F8")]
			[Cpp2IlInjected.Address(RVA = "0x718E70", Offset = "0x717870", VA = "0x180718E70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013F9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ChangeCharacterProfession()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60013FA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ChangeCharacterProfession(ChangeCharacterProfession other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013FB")]
		[Cpp2IlInjected.Address(RVA = "0x718A60", Offset = "0x717460", VA = "0x180718A60", Slot = "10")]
		[DebuggerNonUserCode]
		public ChangeCharacterProfession Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ChangeCharacterProfession changeCharacterProfession = default(ChangeCharacterProfession);
			changeCharacterProfession.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (changeCharacterProfession._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return changeCharacterProfession;
		}

		[Cpp2IlInjected.Token(Token = "0x60013FC")]
		[Cpp2IlInjected.Address(RVA = "0x718AE0", Offset = "0x7174E0", VA = "0x180718AE0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60013FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChangeCharacterProfession other)
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

		[Cpp2IlInjected.Token(Token = "0x60013FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60013FF")]
		[Cpp2IlInjected.Address(RVA = "0x718BD0", Offset = "0x7175D0", VA = "0x180718BD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001400")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001401")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001402")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChangeCharacterProfession other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001403")]
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

		[Cpp2IlInjected.Token(Token = "0x6001404")]
		[Cpp2IlInjected.Address(RVA = "0x718B60", Offset = "0x717560", VA = "0x180718B60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001405")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001406")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001407")]
		[Cpp2IlInjected.Address(RVA = "0x718C30", Offset = "0x717630", VA = "0x180718C30")]
		static ChangeCharacterProfession()
		{
			Func<ChangeCharacterProfession> func = default(Func<ChangeCharacterProfession>);
			_parser = (MessageParser<ChangeCharacterProfession>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
