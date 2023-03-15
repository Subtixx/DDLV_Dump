using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class InitWithServerProfile : IMessage<InitWithServerProfile>, IMessage, IEquatable<InitWithServerProfile>, IDeepCloneable<InitWithServerProfile>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000208")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000209")]
				[OriginalName("Error")]
				Error
			}

			[Cpp2IlInjected.Token(Token = "0x200009F")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400020A")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public const int ProfileFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				private Profile profile_;

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000762")]
					[Cpp2IlInjected.Address(RVA = "0x1E43210", Offset = "0x1E41C10", VA = "0x181E43210")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000763")]
					[Cpp2IlInjected.Address(RVA = "0x1E42D90", Offset = "0x1E41790", VA = "0x181E42D90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000764")]
					[Cpp2IlInjected.Address(RVA = "0x1E43330", Offset = "0x1E41D30", VA = "0x181E43330", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				[DebuggerNonUserCode]
				public Profile Profile
				{
					[Cpp2IlInjected.Token(Token = "0x6000768")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000769")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000765")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000766")]
				[Cpp2IlInjected.Address(RVA = "0x1E42870", Offset = "0x1E41270", VA = "0x181E42870")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000767")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D7C0", Offset = "0x1E3C1C0", VA = "0x181E3D7C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600076A")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E070", Offset = "0x1E3CA70", VA = "0x181E3E070", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600076B")]
				[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600076C")]
				[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600076D")]
				[Cpp2IlInjected.Address(RVA = "0x1E40C30", Offset = "0x1E3F630", VA = "0x181E40C30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600076E")]
				[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600076F")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D040", Offset = "0x1E3BA40", VA = "0x181E3D040", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000770")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F9F0", Offset = "0x1E3E3F0", VA = "0x181E3F9F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000771")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F720", Offset = "0x1E3E120", VA = "0x181E3F720", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000772")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E970", Offset = "0x1E3D370", VA = "0x181E3E970", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000773")]
				[Cpp2IlInjected.Address(RVA = "0x1E409D0", Offset = "0x1E3F3D0", VA = "0x181E409D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000774")]
				[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000210")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000211")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000779")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C370", Offset = "0x1E4AD70", VA = "0x181E4C370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600077A")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C070", Offset = "0x1E4AA70", VA = "0x181E4C070")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600077B")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C5D0", Offset = "0x1E4AFD0", VA = "0x181E4C5D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600077F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000780")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600077C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x1E46B10", Offset = "0x1E45510", VA = "0x181E46B10", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000781")]
				[Cpp2IlInjected.Address(RVA = "0x1E47770", Offset = "0x1E46170", VA = "0x181E47770", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000782")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000783")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x1E49C70", Offset = "0x1E48670", VA = "0x181E49C70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000786")]
				[Cpp2IlInjected.Address(RVA = "0x1E46120", Offset = "0x1E44B20", VA = "0x181E46120", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000787")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000788")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000789")]
				[Cpp2IlInjected.Address(RVA = "0x1E47BC0", Offset = "0x1E465C0", VA = "0x181E47BC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600078A")]
				[Cpp2IlInjected.Address(RVA = "0x1E49570", Offset = "0x1E47F70", VA = "0x181E49570", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static readonly MessageParser<InitWithServerProfile> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		[DebuggerNonUserCode]
		public static MessageParser<InitWithServerProfile> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x1709BD0", Offset = "0x17085D0", VA = "0x181709BD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x1709B00", Offset = "0x1708500", VA = "0x181709B00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x1709C30", Offset = "0x1708630", VA = "0x181709C30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public InitWithServerProfile()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public InitWithServerProfile(InitWithServerProfile other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x1709820", Offset = "0x1708220", VA = "0x181709820", Slot = "10")]
		[DebuggerNonUserCode]
		public InitWithServerProfile Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			InitWithServerProfile initWithServerProfile = default(InitWithServerProfile);
			initWithServerProfile.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (initWithServerProfile._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return initWithServerProfile;
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x17098A0", Offset = "0x17082A0", VA = "0x1817098A0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InitWithServerProfile other)
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

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x1709990", Offset = "0x1708390", VA = "0x181709990", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InitWithServerProfile other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
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

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x1709920", Offset = "0x1708320", VA = "0x181709920", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x17099F0", Offset = "0x17083F0", VA = "0x1817099F0")]
		static InitWithServerProfile()
		{
			Func<InitWithServerProfile> func = default(Func<InitWithServerProfile>);
			_parser = (MessageParser<InitWithServerProfile>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
