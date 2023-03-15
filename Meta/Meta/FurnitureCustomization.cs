using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Customization;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	public sealed class FurnitureCustomization : IMessage<FurnitureCustomization>, IMessage, IEquatable<FurnitureCustomization>, IDeepCloneable<FurnitureCustomization>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001B6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20001B7")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40005E3")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40005E4")]
				[OriginalName("DesignDoesNotExist")]
				DesignDoesNotExist
			}

			[Cpp2IlInjected.Token(Token = "0x20001B8")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005E5")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005E6")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40005E7")]
				public const int FurnitureFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005E8")]
				private Furniture furniture_;

				[Cpp2IlInjected.Token(Token = "0x17000336")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001240")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FD90", Offset = "0x1E7E790", VA = "0x181E7FD90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000337")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001241")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FB10", Offset = "0x1E7E510", VA = "0x181E7FB10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000338")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001242")]
					[Cpp2IlInjected.Address(RVA = "0x1E80990", Offset = "0x1E7F390", VA = "0x181E80990", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000339")]
				[DebuggerNonUserCode]
				public Furniture Furniture
				{
					[Cpp2IlInjected.Token(Token = "0x6001246")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001247")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001243")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F420", Offset = "0x1E7DE20", VA = "0x181E7F420")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001244")]
				[Cpp2IlInjected.Address(RVA = "0x1E7EF30", Offset = "0x1E7D930", VA = "0x181E7EF30")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001245")]
				[Cpp2IlInjected.Address(RVA = "0x1E799D0", Offset = "0x1E783D0", VA = "0x181E799D0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001248")]
				[Cpp2IlInjected.Address(RVA = "0x1E79F40", Offset = "0x1E78940", VA = "0x181E79F40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001249")]
				[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600124A")]
				[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600124B")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C750", Offset = "0x1E7B150", VA = "0x181E7C750", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600124C")]
				[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600124D")]
				[Cpp2IlInjected.Address(RVA = "0x1E78920", Offset = "0x1E77320", VA = "0x181E78920", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600124E")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BB00", Offset = "0x1E7A500", VA = "0x181E7BB00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600124F")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B600", Offset = "0x1E7A000", VA = "0x181E7B600", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001250")]
				[Cpp2IlInjected.Address(RVA = "0x1E7AF80", Offset = "0x1E79980", VA = "0x181E7AF80", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001251")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BE70", Offset = "0x1E7A870", VA = "0x181E7BE70", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001252")]
				[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001253")]
				[Cpp2IlInjected.Address(RVA = "0x1E7CBD0", Offset = "0x1E7B5D0", VA = "0x181E7CBD0")]
				public static Result ValidateFurniture(Furniture furniture, ProfilePlayer profilePlayer)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x6001254")]
				[Cpp2IlInjected.Address(RVA = "0x1E7D640", Offset = "0x1E7C040", VA = "0x181E7D640", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20001BA")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005EA")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005EB")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40005EC")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005ED")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40005EE")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005EF")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700033A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001259")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F2E0", Offset = "0x1E8DCE0", VA = "0x181E8F2E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700033B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600125A")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EDE0", Offset = "0x1E8D7E0", VA = "0x181E8EDE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700033C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600125B")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FF40", Offset = "0x1E8E940", VA = "0x181E8FF40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700033D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600125F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001260")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700033E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001261")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001262")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700033F")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600126E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600126F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600125C")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D810", Offset = "0x1E8C210", VA = "0x181E8D810")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600125D")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D850", Offset = "0x1E8C250", VA = "0x181E8D850")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600125E")]
				[Cpp2IlInjected.Address(RVA = "0x1E853F0", Offset = "0x1E83DF0", VA = "0x181E853F0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001263")]
				[Cpp2IlInjected.Address(RVA = "0x1E86570", Offset = "0x1E84F70", VA = "0x181E86570", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001264")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001265")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001266")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B670", Offset = "0x1E8A070", VA = "0x181E8B670", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001267")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001268")]
				[Cpp2IlInjected.Address(RVA = "0x1E843B0", Offset = "0x1E82DB0", VA = "0x181E843B0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001269")]
				[Cpp2IlInjected.Address(RVA = "0x1E88DF0", Offset = "0x1E877F0", VA = "0x181E88DF0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600126A")]
				[Cpp2IlInjected.Address(RVA = "0x1E88A20", Offset = "0x1E87420", VA = "0x181E88A20", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600126B")]
				[Cpp2IlInjected.Address(RVA = "0x1E876F0", Offset = "0x1E860F0", VA = "0x181E876F0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600126C")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A950", Offset = "0x1E89350", VA = "0x181E8A950", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600126D")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001270")]
				[Cpp2IlInjected.Address(RVA = "0x1E813C0", Offset = "0x1E7FDC0", VA = "0x181E813C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private static readonly MessageParser<FurnitureCustomization> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000333")]
		[DebuggerNonUserCode]
		public static MessageParser<FurnitureCustomization> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600122E")]
			[Cpp2IlInjected.Address(RVA = "0x180A470", Offset = "0x1808E70", VA = "0x18180A470")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000334")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600122F")]
			[Cpp2IlInjected.Address(RVA = "0x180A3A0", Offset = "0x1808DA0", VA = "0x18180A3A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001230")]
			[Cpp2IlInjected.Address(RVA = "0x180A4D0", Offset = "0x1808ED0", VA = "0x18180A4D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001231")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FurnitureCustomization()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001232")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public FurnitureCustomization(FurnitureCustomization other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001233")]
		[Cpp2IlInjected.Address(RVA = "0x180A0C0", Offset = "0x1808AC0", VA = "0x18180A0C0", Slot = "10")]
		[DebuggerNonUserCode]
		public FurnitureCustomization Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			FurnitureCustomization furnitureCustomization = default(FurnitureCustomization);
			furnitureCustomization.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (furnitureCustomization._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return furnitureCustomization;
		}

		[Cpp2IlInjected.Token(Token = "0x6001234")]
		[Cpp2IlInjected.Address(RVA = "0x180A140", Offset = "0x1808B40", VA = "0x18180A140", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001235")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FurnitureCustomization other)
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

		[Cpp2IlInjected.Token(Token = "0x6001236")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001237")]
		[Cpp2IlInjected.Address(RVA = "0x180A230", Offset = "0x1808C30", VA = "0x18180A230", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001238")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001239")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600123A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FurnitureCustomization other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600123B")]
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

		[Cpp2IlInjected.Token(Token = "0x600123C")]
		[Cpp2IlInjected.Address(RVA = "0x180A1C0", Offset = "0x1808BC0", VA = "0x18180A1C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600123D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600123E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600123F")]
		[Cpp2IlInjected.Address(RVA = "0x180A290", Offset = "0x1808C90", VA = "0x18180A290")]
		static FurnitureCustomization()
		{
			Func<FurnitureCustomization> func = default(Func<FurnitureCustomization>);
			_parser = (MessageParser<FurnitureCustomization>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
