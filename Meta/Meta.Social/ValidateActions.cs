using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B89")]
	public sealed class ValidateActions : IMessage<ValidateActions>, IMessage, IEquatable<ValidateActions>, IDeepCloneable<ValidateActions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B8A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B8B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002CB4")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002CB5")]
				[OriginalName("ReplayError")]
				ReplayError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002CB6")]
				[OriginalName("Error")]
				Error = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000B8C")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002CB7")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002CB8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002CB9")]
				public const int ActionsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002CBA")]
				private static readonly FieldCodec<WrappedRequest> _repeated_actions_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002CBB")]
				private readonly RepeatedField<WrappedRequest> actions_;

				[Cpp2IlInjected.Token(Token = "0x170010D1")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60061DB")]
					[Cpp2IlInjected.Address(RVA = "0xACB690", Offset = "0xACA090", VA = "0x180ACB690")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010D2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60061DC")]
					[Cpp2IlInjected.Address(RVA = "0xACB530", Offset = "0xAC9F30", VA = "0x180ACB530")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010D3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60061DD")]
					[Cpp2IlInjected.Address(RVA = "0xACB8D0", Offset = "0xACA2D0", VA = "0x180ACB8D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010D4")]
				[DebuggerNonUserCode]
				public RepeatedField<WrappedRequest> Actions
				{
					[Cpp2IlInjected.Token(Token = "0x60061E1")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60061DE")]
				[Cpp2IlInjected.Address(RVA = "0xACB3A0", Offset = "0xAC9DA0", VA = "0x180ACB3A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061DF")]
				[Cpp2IlInjected.Address(RVA = "0xACB180", Offset = "0xAC9B80", VA = "0x180ACB180")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061E0")]
				[Cpp2IlInjected.Address(RVA = "0xAC8B70", Offset = "0xAC7570", VA = "0x180AC8B70", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061E2")]
				[Cpp2IlInjected.Address(RVA = "0xAC8EF0", Offset = "0xAC78F0", VA = "0x180AC8EF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061E3")]
				[Cpp2IlInjected.Address(RVA = "0xAC90C0", Offset = "0xAC7AC0", VA = "0x180AC90C0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061E4")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061E5")]
				[Cpp2IlInjected.Address(RVA = "0xAC9CA0", Offset = "0xAC86A0", VA = "0x180AC9CA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061E6")]
				[Cpp2IlInjected.Address(RVA = "0xACAA00", Offset = "0xAC9400", VA = "0x180ACAA00", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061E7")]
				[Cpp2IlInjected.Address(RVA = "0xAC87B0", Offset = "0xAC71B0", VA = "0x180AC87B0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061E8")]
				[Cpp2IlInjected.Address(RVA = "0xAC98C0", Offset = "0xAC82C0", VA = "0x180AC98C0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC9610", Offset = "0xAC8010", VA = "0x180AC9610", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061EA")]
				[Cpp2IlInjected.Address(RVA = "0xAC91F0", Offset = "0xAC7BF0", VA = "0x180AC91F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061EB")]
				[Cpp2IlInjected.Address(RVA = "0xAC9AB0", Offset = "0xAC84B0", VA = "0x180AC9AB0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061EC")]
				[Cpp2IlInjected.Address(RVA = "0xAC8A60", Offset = "0xAC7460", VA = "0x180AC8A60", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B8E")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002CBD")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002CBE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002CBF")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002CC0")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x170010D5")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60061F1")]
					[Cpp2IlInjected.Address(RVA = "0xACF660", Offset = "0xACE060", VA = "0x180ACF660")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010D6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60061F2")]
					[Cpp2IlInjected.Address(RVA = "0xACF5E0", Offset = "0xACDFE0", VA = "0x180ACF5E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010D7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60061F3")]
					[Cpp2IlInjected.Address(RVA = "0xACF780", Offset = "0xACE180", VA = "0x180ACF780", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010D8")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60061F7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60061F8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60061F4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061F5")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061F6")]
				[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061F9")]
				[Cpp2IlInjected.Address(RVA = "0xACCD50", Offset = "0xACB750", VA = "0x180ACCD50", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061FA")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061FB")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061FC")]
				[Cpp2IlInjected.Address(RVA = "0xACDB50", Offset = "0xACC550", VA = "0x180ACDB50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061FD")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061FE")]
				[Cpp2IlInjected.Address(RVA = "0xACC730", Offset = "0xACB130", VA = "0x180ACC730", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061FF")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006200")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006201")]
				[Cpp2IlInjected.Address(RVA = "0xACD280", Offset = "0xACBC80", VA = "0x180ACD280", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006202")]
				[Cpp2IlInjected.Address(RVA = "0xACD940", Offset = "0xACC340", VA = "0x180ACD940", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006203")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002CB1")]
		private static readonly MessageParser<ValidateActions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002CB2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170010CE")]
		[DebuggerNonUserCode]
		public static MessageParser<ValidateActions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60061C9")]
			[Cpp2IlInjected.Address(RVA = "0x15DF630", Offset = "0x15DE030", VA = "0x1815DF630")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60061CA")]
			[Cpp2IlInjected.Address(RVA = "0x15DF560", Offset = "0x15DDF60", VA = "0x1815DF560")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60061CB")]
			[Cpp2IlInjected.Address(RVA = "0x15DF690", Offset = "0x15DE090", VA = "0x1815DF690", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60061CC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ValidateActions()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60061CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ValidateActions(ValidateActions other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60061CE")]
		[Cpp2IlInjected.Address(RVA = "0x15DF280", Offset = "0x15DDC80", VA = "0x1815DF280", Slot = "10")]
		[DebuggerNonUserCode]
		public ValidateActions Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ValidateActions validateActions = default(ValidateActions);
			validateActions.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (validateActions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return validateActions;
		}

		[Cpp2IlInjected.Token(Token = "0x60061CF")]
		[Cpp2IlInjected.Address(RVA = "0x15DF300", Offset = "0x15DDD00", VA = "0x1815DF300", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60061D0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ValidateActions other)
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

		[Cpp2IlInjected.Token(Token = "0x60061D1")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60061D2")]
		[Cpp2IlInjected.Address(RVA = "0x15DF3F0", Offset = "0x15DDDF0", VA = "0x1815DF3F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60061D3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60061D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60061D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ValidateActions other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60061D6")]
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

		[Cpp2IlInjected.Token(Token = "0x60061D7")]
		[Cpp2IlInjected.Address(RVA = "0x15DF380", Offset = "0x15DDD80", VA = "0x1815DF380", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60061D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60061D9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60061DA")]
		[Cpp2IlInjected.Address(RVA = "0x15DF450", Offset = "0x15DDE50", VA = "0x1815DF450")]
		static ValidateActions()
		{
			Func<ValidateActions> func = default(Func<ValidateActions>);
			_parser = (MessageParser<ValidateActions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
