using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B81")]
	public sealed class GetFiles : IMessage<GetFiles>, IMessage, IEquatable<GetFiles>, IDeepCloneable<GetFiles>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B82")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B83")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002CA1")]
				[OriginalName("Success")]
				Success
			}

			[Cpp2IlInjected.Token(Token = "0x2000B84")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002CA2")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002CA3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002CA4")]
				public const int PathsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002CA5")]
				private static readonly FieldCodec<string> _repeated_paths_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002CA6")]
				private readonly RepeatedField<string> paths_;

				[Cpp2IlInjected.Token(Token = "0x170010C5")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006198")]
					[Cpp2IlInjected.Address(RVA = "0x1E80150", Offset = "0x1E7EB50", VA = "0x181E80150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010C6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006199")]
					[Cpp2IlInjected.Address(RVA = "0x1E7F990", Offset = "0x1E7E390", VA = "0x181E7F990")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010C7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600619A")]
					[Cpp2IlInjected.Address(RVA = "0x1E80450", Offset = "0x1E7EE50", VA = "0x181E80450", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010C8")]
				[DebuggerNonUserCode]
				public RepeatedField<string> Paths
				{
					[Cpp2IlInjected.Token(Token = "0x600619E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600619B")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F5C0", Offset = "0x1E7DFC0", VA = "0x181E7F5C0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600619C")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F210", Offset = "0x1E7DC10", VA = "0x181E7F210")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600619D")]
				[Cpp2IlInjected.Address(RVA = "0x1E79A90", Offset = "0x1E78490", VA = "0x181E79A90", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600619F")]
				[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E78860", VA = "0x181E79E60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061A0")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A0C0", Offset = "0x1E78AC0", VA = "0x181E7A0C0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061A1")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061A2")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C810", Offset = "0x1E7B210", VA = "0x181E7C810", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061A3")]
				[Cpp2IlInjected.Address(RVA = "0x1E7DDA0", Offset = "0x1E7C7A0", VA = "0x181E7DDA0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061A4")]
				[Cpp2IlInjected.Address(RVA = "0x1E78870", Offset = "0x1E77270", VA = "0x181E78870", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061A5")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BA80", Offset = "0x1E7A480", VA = "0x181E7BA80", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061A6")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BC60", Offset = "0x1E7A660", VA = "0x181E7BC60", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061A7")]
				[Cpp2IlInjected.Address(RVA = "0x1E7AF00", Offset = "0x1E79900", VA = "0x181E7AF00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061A8")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C6F0", Offset = "0x1E7B0F0", VA = "0x181E7C6F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061A9")]
				[Cpp2IlInjected.Address(RVA = "0x1E790F0", Offset = "0x1E77AF0", VA = "0x181E790F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B86")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002CA8")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002CA9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002CAA")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002CAB")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002CAC")]
				public const int FileContentsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4002CAD")]
				private static readonly FieldCodec<ByteString> _repeated_fileContents_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002CAE")]
				private readonly RepeatedField<ByteString> fileContents_;

				[Cpp2IlInjected.Token(Token = "0x170010C9")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60061AE")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F4C0", Offset = "0x1E8DEC0", VA = "0x181E8F4C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010CA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60061AF")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EBE0", Offset = "0x1E8D5E0", VA = "0x181E8EBE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010CB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60061B0")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FB80", Offset = "0x1E8E580", VA = "0x181E8FB80", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010CC")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60061B4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60061B5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010CD")]
				[DebuggerNonUserCode]
				public RepeatedField<ByteString> FileContents
				{
					[Cpp2IlInjected.Token(Token = "0x60061B6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60061B1")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D660", Offset = "0x1E8C060", VA = "0x181E8D660")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061B2")]
				[Cpp2IlInjected.Address(RVA = "0x1E8DFC0", Offset = "0x1E8C9C0", VA = "0x181E8DFC0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061B3")]
				[Cpp2IlInjected.Address(RVA = "0x1E85160", Offset = "0x1E83B60", VA = "0x181E85160", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061B7")]
				[Cpp2IlInjected.Address(RVA = "0x1E869D0", Offset = "0x1E853D0", VA = "0x181E869D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061B8")]
				[Cpp2IlInjected.Address(RVA = "0x1E85CB0", Offset = "0x1E846B0", VA = "0x181E85CB0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60061B9")]
				[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061BA")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B430", Offset = "0x1E89E30", VA = "0x181E8B430", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061BB")]
				[Cpp2IlInjected.Address(RVA = "0x1E8BD80", Offset = "0x1E8A780", VA = "0x181E8BD80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061BC")]
				[Cpp2IlInjected.Address(RVA = "0x1E83E70", Offset = "0x1E82870", VA = "0x181E83E70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60061BD")]
				[Cpp2IlInjected.Address(RVA = "0x1E88570", Offset = "0x1E86F70", VA = "0x181E88570", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061BE")]
				[Cpp2IlInjected.Address(RVA = "0x1E88B10", Offset = "0x1E87510", VA = "0x181E88B10", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061BF")]
				[Cpp2IlInjected.Address(RVA = "0x1E873D0", Offset = "0x1E85DD0", VA = "0x181E873D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60061C0")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A880", Offset = "0x1E89280", VA = "0x181E8A880", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60061C1")]
				[Cpp2IlInjected.Address(RVA = "0x1E84D70", Offset = "0x1E83770", VA = "0x181E84D70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002C9E")]
		private static readonly MessageParser<GetFiles> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002C9F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170010C2")]
		[DebuggerNonUserCode]
		public static MessageParser<GetFiles> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006186")]
			[Cpp2IlInjected.Address(RVA = "0x1D03F60", Offset = "0x1D02960", VA = "0x181D03F60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006187")]
			[Cpp2IlInjected.Address(RVA = "0x1D03E90", Offset = "0x1D02890", VA = "0x181D03E90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006188")]
			[Cpp2IlInjected.Address(RVA = "0x1D03FC0", Offset = "0x1D029C0", VA = "0x181D03FC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006189")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GetFiles()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600618A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GetFiles(GetFiles other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600618B")]
		[Cpp2IlInjected.Address(RVA = "0x1D03BB0", Offset = "0x1D025B0", VA = "0x181D03BB0", Slot = "10")]
		[DebuggerNonUserCode]
		public GetFiles Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GetFiles getFiles = default(GetFiles);
			getFiles.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (getFiles._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return getFiles;
		}

		[Cpp2IlInjected.Token(Token = "0x600618C")]
		[Cpp2IlInjected.Address(RVA = "0x1D03C30", Offset = "0x1D02630", VA = "0x181D03C30", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600618D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GetFiles other)
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

		[Cpp2IlInjected.Token(Token = "0x600618E")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600618F")]
		[Cpp2IlInjected.Address(RVA = "0x1D03D20", Offset = "0x1D02720", VA = "0x181D03D20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006190")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006191")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006192")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GetFiles other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006193")]
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

		[Cpp2IlInjected.Token(Token = "0x6006194")]
		[Cpp2IlInjected.Address(RVA = "0x1D03CB0", Offset = "0x1D026B0", VA = "0x181D03CB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006195")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006196")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006197")]
		[Cpp2IlInjected.Address(RVA = "0x1D03D80", Offset = "0x1D02780", VA = "0x181D03D80")]
		static GetFiles()
		{
			Func<GetFiles> func = default(Func<GetFiles>);
			_parser = (MessageParser<GetFiles>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
