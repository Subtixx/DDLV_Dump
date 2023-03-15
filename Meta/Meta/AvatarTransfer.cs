using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public sealed class AvatarTransfer : IMessage<AvatarTransfer>, IMessage, IEquatable<AvatarTransfer>, IDeepCloneable<AvatarTransfer>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000194")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400057E")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400057F")]
				[OriginalName("InvalidAvatarCode")]
				InvalidAvatarCode,
				[Cpp2IlInjected.Token(Token = "0x4000580")]
				[OriginalName("InvalidAvatarData")]
				InvalidAvatarData,
				[Cpp2IlInjected.Token(Token = "0x4000581")]
				[OriginalName("TooManyDesign")]
				TooManyDesign,
				[Cpp2IlInjected.Token(Token = "0x4000582")]
				[OriginalName("AlreadyDone")]
				AlreadyDone
			}

			[Cpp2IlInjected.Token(Token = "0x2000195")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000583")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000584")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000585")]
				public const int AvatarDataFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000586")]
				private ByteString avatarData_;

				[Cpp2IlInjected.Token(Token = "0x170002FC")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001108")]
					[Cpp2IlInjected.Address(RVA = "0x272B3D0", Offset = "0x2729DD0", VA = "0x18272B3D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002FD")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001109")]
					[Cpp2IlInjected.Address(RVA = "0x272B210", Offset = "0x2729C10", VA = "0x18272B210")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002FE")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600110A")]
					[Cpp2IlInjected.Address(RVA = "0x272BA90", Offset = "0x272A490", VA = "0x18272BA90", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002FF")]
				[DebuggerNonUserCode]
				public ByteString AvatarData
				{
					[Cpp2IlInjected.Token(Token = "0x600110E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600110F")]
					[Cpp2IlInjected.Address(RVA = "0x272BE50", Offset = "0x272A850", VA = "0x18272BE50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600110B")]
				[Cpp2IlInjected.Address(RVA = "0x272A670", Offset = "0x2729070", VA = "0x18272A670")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600110C")]
				[Cpp2IlInjected.Address(RVA = "0x272A820", Offset = "0x2729220", VA = "0x18272A820")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600110D")]
				[Cpp2IlInjected.Address(RVA = "0x2725380", Offset = "0x2723D80", VA = "0x182725380", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001110")]
				[Cpp2IlInjected.Address(RVA = "0x27261D0", Offset = "0x2724BD0", VA = "0x1827261D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001111")]
				[Cpp2IlInjected.Address(RVA = "0x27258B0", Offset = "0x27242B0", VA = "0x1827258B0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001112")]
				[Cpp2IlInjected.Address(RVA = "0x2726B60", Offset = "0x2725560", VA = "0x182726B60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001113")]
				[Cpp2IlInjected.Address(RVA = "0x2728500", Offset = "0x2726F00", VA = "0x182728500", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001114")]
				[Cpp2IlInjected.Address(RVA = "0x27295A0", Offset = "0x2727FA0", VA = "0x1827295A0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001115")]
				[Cpp2IlInjected.Address(RVA = "0x2724680", Offset = "0x2723080", VA = "0x182724680", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001116")]
				[Cpp2IlInjected.Address(RVA = "0x2727740", Offset = "0x2726140", VA = "0x182727740", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001117")]
				[Cpp2IlInjected.Address(RVA = "0x2727390", Offset = "0x2725D90", VA = "0x182727390", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001118")]
				[Cpp2IlInjected.Address(RVA = "0x2726720", Offset = "0x2725120", VA = "0x182726720", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001119")]
				[Cpp2IlInjected.Address(RVA = "0x2727B20", Offset = "0x2726520", VA = "0x182727B20", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600111A")]
				[Cpp2IlInjected.Address(RVA = "0x2724F00", Offset = "0x2723900", VA = "0x182724F00", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600111B")]
				[Cpp2IlInjected.Address(RVA = "0x2728950", Offset = "0x2727350", VA = "0x182728950", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000197")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000588")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000589")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400058A")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400058C")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400058D")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000300")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001120")]
					[Cpp2IlInjected.Address(RVA = "0x2735F90", Offset = "0x2734990", VA = "0x182735F90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000301")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001121")]
					[Cpp2IlInjected.Address(RVA = "0x2735AB0", Offset = "0x27344B0", VA = "0x182735AB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000302")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001122")]
					[Cpp2IlInjected.Address(RVA = "0x27363B0", Offset = "0x2734DB0", VA = "0x1827363B0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000303")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001126")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001127")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000304")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001128")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001129")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000305")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001135")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001136")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001123")]
				[Cpp2IlInjected.Address(RVA = "0x2734CF0", Offset = "0x27336F0", VA = "0x182734CF0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001124")]
				[Cpp2IlInjected.Address(RVA = "0x27349A0", Offset = "0x27333A0", VA = "0x1827349A0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001125")]
				[Cpp2IlInjected.Address(RVA = "0x272FBD0", Offset = "0x272E5D0", VA = "0x18272FBD0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600112A")]
				[Cpp2IlInjected.Address(RVA = "0x2730300", Offset = "0x272ED00", VA = "0x182730300", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600112B")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600112C")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600112D")]
				[Cpp2IlInjected.Address(RVA = "0x2733AE0", Offset = "0x27324E0", VA = "0x182733AE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600112E")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600112F")]
				[Cpp2IlInjected.Address(RVA = "0x272EE30", Offset = "0x272D830", VA = "0x18272EE30", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001130")]
				[Cpp2IlInjected.Address(RVA = "0x2732590", Offset = "0x2730F90", VA = "0x182732590", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001131")]
				[Cpp2IlInjected.Address(RVA = "0x2731E50", Offset = "0x2730850", VA = "0x182731E50", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001132")]
				[Cpp2IlInjected.Address(RVA = "0x27307F0", Offset = "0x272F1F0", VA = "0x1827307F0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001133")]
				[Cpp2IlInjected.Address(RVA = "0x2733640", Offset = "0x2732040", VA = "0x182733640", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001134")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001137")]
				[Cpp2IlInjected.Address(RVA = "0x272D400", Offset = "0x272BE00", VA = "0x18272D400", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly MessageParser<AvatarTransfer> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarTransfer> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60010F6")]
			[Cpp2IlInjected.Address(RVA = "0x1AB4BF0", Offset = "0x1AB35F0", VA = "0x181AB4BF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60010F7")]
			[Cpp2IlInjected.Address(RVA = "0x1AB4B20", Offset = "0x1AB3520", VA = "0x181AB4B20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60010F8")]
			[Cpp2IlInjected.Address(RVA = "0x1AB4C50", Offset = "0x1AB3650", VA = "0x181AB4C50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010F9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AvatarTransfer()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60010FA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public AvatarTransfer(AvatarTransfer other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010FB")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4840", Offset = "0x1AB3240", VA = "0x181AB4840", Slot = "10")]
		[DebuggerNonUserCode]
		public AvatarTransfer Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			AvatarTransfer avatarTransfer = default(AvatarTransfer);
			avatarTransfer.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (avatarTransfer._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return avatarTransfer;
		}

		[Cpp2IlInjected.Token(Token = "0x60010FC")]
		[Cpp2IlInjected.Address(RVA = "0x1AB48C0", Offset = "0x1AB32C0", VA = "0x181AB48C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60010FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AvatarTransfer other)
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

		[Cpp2IlInjected.Token(Token = "0x60010FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60010FF")]
		[Cpp2IlInjected.Address(RVA = "0x1AB49B0", Offset = "0x1AB33B0", VA = "0x181AB49B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001100")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001101")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001102")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarTransfer other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001103")]
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

		[Cpp2IlInjected.Token(Token = "0x6001104")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4940", Offset = "0x1AB3340", VA = "0x181AB4940", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001105")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001106")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001107")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4A10", Offset = "0x1AB3410", VA = "0x181AB4A10")]
		static AvatarTransfer()
		{
			Func<AvatarTransfer> func = default(Func<AvatarTransfer>);
			_parser = (MessageParser<AvatarTransfer>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
