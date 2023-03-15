using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20005A2")]
	public sealed class StartHangoutWithCharacter : IMessage<StartHangoutWithCharacter>, IMessage, IEquatable<StartHangoutWithCharacter>, IDeepCloneable<StartHangoutWithCharacter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005A3")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20005A4")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400111A")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400111B")]
				[OriginalName("InvalidCharacter")]
				InvalidCharacter,
				[Cpp2IlInjected.Token(Token = "0x400111C")]
				[OriginalName("InvalidProfession")]
				InvalidProfession
			}

			[Cpp2IlInjected.Token(Token = "0x20005A5")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400111D")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400111E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400111F")]
				public const int CharacterIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001120")]
				private int characterID_;

				[Cpp2IlInjected.Token(Token = "0x170009FF")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003662")]
					[Cpp2IlInjected.Address(RVA = "0x15BE0E0", Offset = "0x15BCAE0", VA = "0x1815BE0E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A00")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003663")]
					[Cpp2IlInjected.Address(RVA = "0x15BDE60", Offset = "0x15BC860", VA = "0x1815BDE60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A01")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003664")]
					[Cpp2IlInjected.Address(RVA = "0x15BE4A0", Offset = "0x15BCEA0", VA = "0x1815BE4A0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A02")]
				[DebuggerNonUserCode]
				public int CharacterID
				{
					[Cpp2IlInjected.Token(Token = "0x6003668")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6003669")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003665")]
				[Cpp2IlInjected.Address(RVA = "0x15BD900", Offset = "0x15BC300", VA = "0x1815BD900")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003666")]
				[Cpp2IlInjected.Address(RVA = "0x15BD680", Offset = "0x15BC080", VA = "0x1815BD680")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003667")]
				[Cpp2IlInjected.Address(RVA = "0x15B99F0", Offset = "0x15B83F0", VA = "0x1815B99F0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600366A")]
				[Cpp2IlInjected.Address(RVA = "0x15BA350", Offset = "0x15B8D50", VA = "0x1815BA350", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600366B")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600366C")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600366D")]
				[Cpp2IlInjected.Address(RVA = "0x15BBE70", Offset = "0x15BA870", VA = "0x1815BBE70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600366E")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600366F")]
				[Cpp2IlInjected.Address(RVA = "0x15B9630", Offset = "0x15B8030", VA = "0x1815B9630", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003670")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003671")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003672")]
				[Cpp2IlInjected.Address(RVA = "0x15BACF0", Offset = "0x15B96F0", VA = "0x1815BACF0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003673")]
				[Cpp2IlInjected.Address(RVA = "0x15BBC50", Offset = "0x15BA650", VA = "0x1815BBC50", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003674")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003675")]
				[Cpp2IlInjected.Address(RVA = "0x15BC110", Offset = "0x15BAB10", VA = "0x1815BC110", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20005A7")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001122")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001123")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001124")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001125")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4001126")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001127")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000A03")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600367A")]
					[Cpp2IlInjected.Address(RVA = "0x15C93B0", Offset = "0x15C7DB0", VA = "0x1815C93B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A04")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600367B")]
					[Cpp2IlInjected.Address(RVA = "0x15C90F0", Offset = "0x15C7AF0", VA = "0x1815C90F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A05")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600367C")]
					[Cpp2IlInjected.Address(RVA = "0x15C9BF0", Offset = "0x15C85F0", VA = "0x1815C9BF0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A06")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6003680")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003681")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A07")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6003682")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003683")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A08")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600368F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003690")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600367D")]
				[Cpp2IlInjected.Address(RVA = "0x15C8210", Offset = "0x15C6C10", VA = "0x1815C8210")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600367E")]
				[Cpp2IlInjected.Address(RVA = "0x15C8B50", Offset = "0x15C7550", VA = "0x1815C8B50")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600367F")]
				[Cpp2IlInjected.Address(RVA = "0x15C3790", Offset = "0x15C2190", VA = "0x1815C3790", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003684")]
				[Cpp2IlInjected.Address(RVA = "0x15C3A90", Offset = "0x15C2490", VA = "0x1815C3A90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003685")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003686")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003687")]
				[Cpp2IlInjected.Address(RVA = "0x15C6D30", Offset = "0x15C5730", VA = "0x1815C6D30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003688")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003689")]
				[Cpp2IlInjected.Address(RVA = "0x15C2890", Offset = "0x15C1290", VA = "0x1815C2890", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600368A")]
				[Cpp2IlInjected.Address(RVA = "0x15C6180", Offset = "0x15C4B80", VA = "0x1815C6180", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600368B")]
				[Cpp2IlInjected.Address(RVA = "0x15C5150", Offset = "0x15C3B50", VA = "0x1815C5150", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600368C")]
				[Cpp2IlInjected.Address(RVA = "0x15C4940", Offset = "0x15C3340", VA = "0x1815C4940", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600368D")]
				[Cpp2IlInjected.Address(RVA = "0x15C6880", Offset = "0x15C5280", VA = "0x1815C6880", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600368E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003691")]
				[Cpp2IlInjected.Address(RVA = "0x15BF130", Offset = "0x15BDB30", VA = "0x1815BF130", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003692")]
				[Cpp2IlInjected.Address(RVA = "0x15BEDC0", Offset = "0x15BD7C0", VA = "0x1815BEDC0")]
				public static void ApplyProfessionBuff(Player player, World world, Character character, ProfessionItemData profession)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003693")]
				[Cpp2IlInjected.Address(RVA = "0x15C4250", Offset = "0x15C2C50", VA = "0x1815C4250")]
				private static List<(BuffType, int)> GetBuffData(ProfessionItemData profession, int professionLevel, int totalProfessionLevel)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001117")]
		private static readonly MessageParser<StartHangoutWithCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001118")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170009FC")]
		[DebuggerNonUserCode]
		public static MessageParser<StartHangoutWithCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003650")]
			[Cpp2IlInjected.Address(RVA = "0xC03D10", Offset = "0xC02710", VA = "0x180C03D10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009FD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003651")]
			[Cpp2IlInjected.Address(RVA = "0xC03C40", Offset = "0xC02640", VA = "0x180C03C40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009FE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003652")]
			[Cpp2IlInjected.Address(RVA = "0xC03D70", Offset = "0xC02770", VA = "0x180C03D70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003653")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StartHangoutWithCharacter()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6003654")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StartHangoutWithCharacter(StartHangoutWithCharacter other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003655")]
		[Cpp2IlInjected.Address(RVA = "0xC03960", Offset = "0xC02360", VA = "0x180C03960", Slot = "10")]
		[DebuggerNonUserCode]
		public StartHangoutWithCharacter Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StartHangoutWithCharacter startHangoutWithCharacter = default(StartHangoutWithCharacter);
			startHangoutWithCharacter.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (startHangoutWithCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return startHangoutWithCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x6003656")]
		[Cpp2IlInjected.Address(RVA = "0xC039E0", Offset = "0xC023E0", VA = "0x180C039E0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003657")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StartHangoutWithCharacter other)
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

		[Cpp2IlInjected.Token(Token = "0x6003658")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003659")]
		[Cpp2IlInjected.Address(RVA = "0xC03AD0", Offset = "0xC024D0", VA = "0x180C03AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600365A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600365B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600365C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StartHangoutWithCharacter other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600365D")]
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

		[Cpp2IlInjected.Token(Token = "0x600365E")]
		[Cpp2IlInjected.Address(RVA = "0xC03A60", Offset = "0xC02460", VA = "0x180C03A60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600365F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003660")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003661")]
		[Cpp2IlInjected.Address(RVA = "0xC03B30", Offset = "0xC02530", VA = "0x180C03B30")]
		static StartHangoutWithCharacter()
		{
			Func<StartHangoutWithCharacter> func = default(Func<StartHangoutWithCharacter>);
			_parser = (MessageParser<StartHangoutWithCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
