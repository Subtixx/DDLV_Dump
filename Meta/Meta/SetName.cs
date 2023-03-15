using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004E6")]
	public sealed class SetName : IMessage<SetName>, IMessage, IEquatable<SetName>, IDeepCloneable<SetName>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004E7")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004E8")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000F3C")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000F3D")]
				[OriginalName("AlreadySet")]
				AlreadySet,
				[Cpp2IlInjected.Token(Token = "0x4000F3E")]
				[OriginalName("ProfileIsNull")]
				ProfileIsNull,
				[Cpp2IlInjected.Token(Token = "0x4000F3F")]
				[OriginalName("ProfanityDetected")]
				ProfanityDetected,
				[Cpp2IlInjected.Token(Token = "0x4000F40")]
				[OriginalName("OnCooldown")]
				OnCooldown,
				[Cpp2IlInjected.Token(Token = "0x4000F41")]
				[OriginalName("OnlineNameFailed")]
				OnlineNameFailed
			}

			[Cpp2IlInjected.Token(Token = "0x20004E9")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F42")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F43")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F44")]
				public const int NameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F45")]
				private string name_;

				[Cpp2IlInjected.Token(Token = "0x170008C5")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002FB0")]
					[Cpp2IlInjected.Address(RVA = "0x2B51300", Offset = "0x2B4FD00", VA = "0x182B51300")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008C6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002FB1")]
					[Cpp2IlInjected.Address(RVA = "0x2B50BC0", Offset = "0x2B4F5C0", VA = "0x182B50BC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008C7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002FB2")]
					[Cpp2IlInjected.Address(RVA = "0x2B516D0", Offset = "0x2B500D0", VA = "0x182B516D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008C8")]
				[DebuggerNonUserCode]
				public string Name
				{
					[Cpp2IlInjected.Token(Token = "0x6002FB6")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002FB7")]
					[Cpp2IlInjected.Address(RVA = "0x2B52040", Offset = "0x2B50A40", VA = "0x182B52040")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002FB3")]
				[Cpp2IlInjected.Address(RVA = "0x2B507B0", Offset = "0x2B4F1B0", VA = "0x182B507B0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FB4")]
				[Cpp2IlInjected.Address(RVA = "0x2B50530", Offset = "0x2B4EF30", VA = "0x182B50530")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FB5")]
				[Cpp2IlInjected.Address(RVA = "0x2B49FE0", Offset = "0x2B489E0", VA = "0x182B49FE0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002FB8")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B2E0", Offset = "0x2B49CE0", VA = "0x182B4B2E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FB9")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FBA")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FBB")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DF10", Offset = "0x2B4C910", VA = "0x182B4DF10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002FBC")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FBD")]
				[Cpp2IlInjected.Address(RVA = "0x2B49B50", Offset = "0x2B48550", VA = "0x182B49B50", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FBE")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CBE0", Offset = "0x2B4B5E0", VA = "0x182B4CBE0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FBF")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CAF0", Offset = "0x2B4B4F0", VA = "0x182B4CAF0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FC0")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BAB0", Offset = "0x2B4A4B0", VA = "0x182B4BAB0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002FC1")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D4E0", Offset = "0x2B4BEE0", VA = "0x182B4D4E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FC2")]
				[Cpp2IlInjected.Address(RVA = "0x2B49ED0", Offset = "0x2B488D0", VA = "0x182B49ED0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FC3")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E2D0", Offset = "0x2B4CCD0", VA = "0x182B4E2D0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004EB")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F47")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F48")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F49")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F4A")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000F4B")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F4C")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170008C9")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002FC8")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CF20", Offset = "0x2B5B920", VA = "0x182B5CF20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008CA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002FC9")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C6E0", Offset = "0x2B5B0E0", VA = "0x182B5C6E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008CB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002FCA")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D8E0", Offset = "0x2B5C2E0", VA = "0x182B5D8E0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008CC")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002FCE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002FCF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008CD")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002FD0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002FD1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008CE")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002FDD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002FDE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008CF")]
				public bool IsSuccess
				{
					[Cpp2IlInjected.Token(Token = "0x6002FE0")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CAE0", Offset = "0x2B5B4E0", VA = "0x182B5CAE0")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002FCB")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C3E0", Offset = "0x2B5ADE0", VA = "0x182B5C3E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FCC")]
				[Cpp2IlInjected.Address(RVA = "0x2B5B410", Offset = "0x2B59E10", VA = "0x182B5B410")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FCD")]
				[Cpp2IlInjected.Address(RVA = "0x2B55610", Offset = "0x2B54010", VA = "0x182B55610", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD2")]
				[Cpp2IlInjected.Address(RVA = "0x2B55CD0", Offset = "0x2B546D0", VA = "0x182B55CD0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD3")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD4")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD5")]
				[Cpp2IlInjected.Address(RVA = "0x2B5A270", Offset = "0x2B58C70", VA = "0x182B5A270", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD6")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD7")]
				[Cpp2IlInjected.Address(RVA = "0x2B54290", Offset = "0x2B52C90", VA = "0x182B54290", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD8")]
				[Cpp2IlInjected.Address(RVA = "0x2B57AB0", Offset = "0x2B564B0", VA = "0x182B57AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FD9")]
				[Cpp2IlInjected.Address(RVA = "0x2B58240", Offset = "0x2B56C40", VA = "0x182B58240", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FDA")]
				[Cpp2IlInjected.Address(RVA = "0x2B56E20", Offset = "0x2B55820", VA = "0x182B56E20", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002FDB")]
				[Cpp2IlInjected.Address(RVA = "0x2B59B10", Offset = "0x2B58510", VA = "0x182B59B10", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FDC")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002FDF")]
				[Cpp2IlInjected.Address(RVA = "0x2B521A0", Offset = "0x2B50BA0", VA = "0x182B521A0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000F39")]
		private static readonly MessageParser<SetName> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F3A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170008C2")]
		[DebuggerNonUserCode]
		public static MessageParser<SetName> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002F9E")]
			[Cpp2IlInjected.Address(RVA = "0x1777440", Offset = "0x1775E40", VA = "0x181777440")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F9F")]
			[Cpp2IlInjected.Address(RVA = "0x1777370", Offset = "0x1775D70", VA = "0x181777370")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FA0")]
			[Cpp2IlInjected.Address(RVA = "0x17774A0", Offset = "0x1775EA0", VA = "0x1817774A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SetName()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SetName(SetName other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA3")]
		[Cpp2IlInjected.Address(RVA = "0x1777090", Offset = "0x1775A90", VA = "0x181777090", Slot = "10")]
		[DebuggerNonUserCode]
		public SetName Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SetName setName = default(SetName);
			setName.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (setName._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return setName;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA4")]
		[Cpp2IlInjected.Address(RVA = "0x1777110", Offset = "0x1775B10", VA = "0x181777110", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002FA5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SetName other)
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

		[Cpp2IlInjected.Token(Token = "0x6002FA6")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA7")]
		[Cpp2IlInjected.Address(RVA = "0x1777200", Offset = "0x1775C00", VA = "0x181777200", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SetName other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAB")]
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

		[Cpp2IlInjected.Token(Token = "0x6002FAC")]
		[Cpp2IlInjected.Address(RVA = "0x1777190", Offset = "0x1775B90", VA = "0x181777190", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAF")]
		[Cpp2IlInjected.Address(RVA = "0x1777260", Offset = "0x1775C60", VA = "0x181777260")]
		static SetName()
		{
			Func<SetName> func = default(Func<SetName>);
			_parser = (MessageParser<SetName>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
