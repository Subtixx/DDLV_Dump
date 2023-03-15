using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000539")]
	public sealed class CollectBurningState : IMessage<CollectBurningState>, IMessage, IEquatable<CollectBurningState>, IDeepCloneable<CollectBurningState>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200053A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200053B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400101D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400101E")]
				[OriginalName("NoBurningState")]
				NoBurningState,
				[Cpp2IlInjected.Token(Token = "0x400101F")]
				[OriginalName("BurningStateCooldown")]
				BurningStateCooldown,
				[Cpp2IlInjected.Token(Token = "0x4001020")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x200053C")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001021")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001022")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001023")]
				public const int AreaTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001024")]
				private VillageAreaType areaType_;

				[Cpp2IlInjected.Token(Token = "0x17000951")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60032A4")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC270", Offset = "0x1DFAC70", VA = "0x181DFC270")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000952")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60032A5")]
					[Cpp2IlInjected.Address(RVA = "0x1DFBD80", Offset = "0x1DFA780", VA = "0x181DFBD80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000953")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60032A6")]
					[Cpp2IlInjected.Address(RVA = "0x1DFCE20", Offset = "0x1DFB820", VA = "0x181DFCE20", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000954")]
				[DebuggerNonUserCode]
				public VillageAreaType AreaType
				{
					[Cpp2IlInjected.Token(Token = "0x60032AA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(VillageAreaType);
					}
					[Cpp2IlInjected.Token(Token = "0x60032AB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60032A7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032A8")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032A9")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6CB0", Offset = "0x1DF56B0", VA = "0x181DF6CB0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60032AC")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7740", Offset = "0x1DF6140", VA = "0x181DF7740", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60032AD")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60032AE")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60032AF")]
				[Cpp2IlInjected.Address(RVA = "0x1DF95C0", Offset = "0x1DF7FC0", VA = "0x181DF95C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60032B0")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032B1")]
				[Cpp2IlInjected.Address(RVA = "0x1DF5DC0", Offset = "0x1DF47C0", VA = "0x181DF5DC0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60032B2")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032B3")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032B4")]
				[Cpp2IlInjected.Address(RVA = "0x1DF79D0", Offset = "0x1DF63D0", VA = "0x181DF79D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60032B5")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8CE0", Offset = "0x1DF76E0", VA = "0x181DF8CE0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032B6")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200053E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001026")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001027")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001028")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001029")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400102A")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400102B")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000955")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60032BB")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A030", Offset = "0x1E08A30", VA = "0x181E0A030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000956")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60032BC")]
					[Cpp2IlInjected.Address(RVA = "0x1E09D30", Offset = "0x1E08730", VA = "0x181E09D30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000957")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60032BD")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A390", Offset = "0x1E08D90", VA = "0x181E0A390", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000958")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60032C1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60032C2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000959")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60032C3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60032C4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700095A")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60032D0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60032D1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60032BE")]
				[Cpp2IlInjected.Address(RVA = "0x1E090E0", Offset = "0x1E07AE0", VA = "0x181E090E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032BF")]
				[Cpp2IlInjected.Address(RVA = "0x1E096B0", Offset = "0x1E080B0", VA = "0x181E096B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032C0")]
				[Cpp2IlInjected.Address(RVA = "0x1E01720", Offset = "0x1E00120", VA = "0x181E01720", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60032C5")]
				[Cpp2IlInjected.Address(RVA = "0x1E02F60", Offset = "0x1E01960", VA = "0x181E02F60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60032C6")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60032C7")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60032C8")]
				[Cpp2IlInjected.Address(RVA = "0x1E06C80", Offset = "0x1E05680", VA = "0x181E06C80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60032C9")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032CA")]
				[Cpp2IlInjected.Address(RVA = "0x1E007F0", Offset = "0x1DFF1F0", VA = "0x181E007F0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60032CB")]
				[Cpp2IlInjected.Address(RVA = "0x1E04620", Offset = "0x1E03020", VA = "0x181E04620", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032CC")]
				[Cpp2IlInjected.Address(RVA = "0x1E04A70", Offset = "0x1E03470", VA = "0x181E04A70", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032CD")]
				[Cpp2IlInjected.Address(RVA = "0x1E03B50", Offset = "0x1E02550", VA = "0x181E03B50", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60032CE")]
				[Cpp2IlInjected.Address(RVA = "0x1E06B50", Offset = "0x1E05550", VA = "0x181E06B50", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032CF")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60032D2")]
				[Cpp2IlInjected.Address(RVA = "0x1DFEAD0", Offset = "0x1DFD4D0", VA = "0x181DFEAD0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400101A")]
		private static readonly MessageParser<CollectBurningState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400101B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700094E")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectBurningState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003292")]
			[Cpp2IlInjected.Address(RVA = "0x1675820", Offset = "0x1674220", VA = "0x181675820")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003293")]
			[Cpp2IlInjected.Address(RVA = "0x1675750", Offset = "0x1674150", VA = "0x181675750")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000950")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003294")]
			[Cpp2IlInjected.Address(RVA = "0x1675880", Offset = "0x1674280", VA = "0x181675880", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003295")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectBurningState()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6003296")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public CollectBurningState(CollectBurningState other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003297")]
		[Cpp2IlInjected.Address(RVA = "0x1675470", Offset = "0x1673E70", VA = "0x181675470", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectBurningState Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			CollectBurningState collectBurningState = default(CollectBurningState);
			collectBurningState.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (collectBurningState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectBurningState;
		}

		[Cpp2IlInjected.Token(Token = "0x6003298")]
		[Cpp2IlInjected.Address(RVA = "0x16754F0", Offset = "0x1673EF0", VA = "0x1816754F0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003299")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectBurningState other)
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

		[Cpp2IlInjected.Token(Token = "0x600329A")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600329B")]
		[Cpp2IlInjected.Address(RVA = "0x16755E0", Offset = "0x1673FE0", VA = "0x1816755E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600329C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600329D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600329E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectBurningState other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329F")]
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

		[Cpp2IlInjected.Token(Token = "0x60032A0")]
		[Cpp2IlInjected.Address(RVA = "0x1675570", Offset = "0x1673F70", VA = "0x181675570", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60032A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60032A3")]
		[Cpp2IlInjected.Address(RVA = "0x1675640", Offset = "0x1674040", VA = "0x181675640")]
		static CollectBurningState()
		{
			Func<CollectBurningState> func = default(Func<CollectBurningState>);
			_parser = (MessageParser<CollectBurningState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
