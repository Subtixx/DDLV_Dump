using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007E7")]
	public sealed class MiningRock : IMessage<MiningRock>, IMessage, IEquatable<MiningRock>, IDeepCloneable<MiningRock>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007E8")]
		public enum StateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F8F")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001F90")]
			Full,
			[Cpp2IlInjected.Token(Token = "0x4001F91")]
			Special
		}

		[Cpp2IlInjected.Token(Token = "0x20007E9")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20007EA")]
			public sealed class FullState : IMessage<FullState>, IMessage, IEquatable<FullState>, IDeepCloneable<FullState>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001F92")]
				private static readonly MessageParser<FullState> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001F93")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001F94")]
				public const int MiningDataItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001F95")]
				private int miningDataItemID_;

				[Cpp2IlInjected.Token(Token = "0x4001F96")]
				public const int NumberOfHitsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001F97")]
				private int numberOfHits_;

				[Cpp2IlInjected.Token(Token = "0x4001F98")]
				public const int NumberOfHitsNeededFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001F99")]
				private int numberOfHitsNeeded_;

				[Cpp2IlInjected.Token(Token = "0x17000AA7")]
				[DebuggerNonUserCode]
				public static MessageParser<FullState> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60041C8")]
					[Cpp2IlInjected.Address(RVA = "0x25C3AF0", Offset = "0x25C24F0", VA = "0x1825C3AF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60041C9")]
					[Cpp2IlInjected.Address(RVA = "0x25C3A10", Offset = "0x25C2410", VA = "0x1825C3A10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60041CA")]
					[Cpp2IlInjected.Address(RVA = "0x25C3B50", Offset = "0x25C2550", VA = "0x1825C3B50", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAA")]
				[DebuggerNonUserCode]
				public int MiningDataItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60041CE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60041CF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAB")]
				[DebuggerNonUserCode]
				public int NumberOfHits
				{
					[Cpp2IlInjected.Token(Token = "0x60041D0")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60041D1")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAC")]
				[DebuggerNonUserCode]
				public int NumberOfHitsNeeded
				{
					[Cpp2IlInjected.Token(Token = "0x60041D2")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60041D3")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAD")]
				public Item MiningDataItem
				{
					[Cpp2IlInjected.Token(Token = "0x60041DF")]
					[Cpp2IlInjected.Address(RVA = "0x25C3A90", Offset = "0x25C2490", VA = "0x1825C3A90")]
					get
					{
						return default(Item);
					}
					[Cpp2IlInjected.Token(Token = "0x60041E0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60041CB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public FullState()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60041CC")]
				[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
				[DebuggerNonUserCode]
				public FullState(FullState other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60041CD")]
				[Cpp2IlInjected.Address(RVA = "0x25C34F0", Offset = "0x25C1EF0", VA = "0x1825C34F0", Slot = "10")]
				[DebuggerNonUserCode]
				public FullState Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60041D4")]
				[Cpp2IlInjected.Address(RVA = "0x25C3580", Offset = "0x25C1F80", VA = "0x1825C3580", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60041D5")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FullState other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60041D6")]
				[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60041D7")]
				[Cpp2IlInjected.Address(RVA = "0x25C38A0", Offset = "0x25C22A0", VA = "0x1825C38A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60041D8")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60041D9")]
				[Cpp2IlInjected.Address(RVA = "0x25C33F0", Offset = "0x25C1DF0", VA = "0x1825C33F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60041DA")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FullState other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60041DB")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60041DC")]
				[Cpp2IlInjected.Address(RVA = "0x25C3620", Offset = "0x25C2020", VA = "0x1825C3620", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60041DD")]
				[Cpp2IlInjected.Address(RVA = "0x25C3790", Offset = "0x25C2190", VA = "0x1825C3790", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60041DE")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001F86")]
		private static readonly MessageParser<MiningRock> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F87")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F88")]
		public const int FullFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F89")]
		public const int SpecialFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001F8A")]
		public const int LastHitFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F8B")]
		private Timestamp lastHit_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F8C")]
		private object state_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F8D")]
		private StateOneofCase stateCase_;

		[Cpp2IlInjected.Token(Token = "0x17000AA0")]
		[DebuggerNonUserCode]
		public static MessageParser<MiningRock> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60041AA")]
			[Cpp2IlInjected.Address(RVA = "0x7FDF50", Offset = "0x7FC950", VA = "0x1807FDF50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AA1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FC820", VA = "0x1807FDE20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AA2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041AC")]
			[Cpp2IlInjected.Address(RVA = "0x7FE010", Offset = "0x7FCA10", VA = "0x1807FE010", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AA3")]
		[DebuggerNonUserCode]
		public Types.FullState Full
		{
			[Cpp2IlInjected.Token(Token = "0x60041B0")]
			[Cpp2IlInjected.Address(RVA = "0x7FDEF0", Offset = "0x7FC8F0", VA = "0x1807FDEF0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Full)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60041B1")]
			[Cpp2IlInjected.Address(RVA = "0x7FE120", Offset = "0x7FCB20", VA = "0x1807FE120")]
			set
			{
				state_ = value;
				bool flag = (byte)(stateCase_ = ((value != null) ? StateOneofCase.Full : StateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AA4")]
		[DebuggerNonUserCode]
		public Types.FullState Special
		{
			[Cpp2IlInjected.Token(Token = "0x60041B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FDFB0", Offset = "0x7FC9B0", VA = "0x1807FDFB0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Special)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60041B3")]
			[Cpp2IlInjected.Address(RVA = "0x7FE160", Offset = "0x7FCB60", VA = "0x1807FE160")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AA5")]
		[DebuggerNonUserCode]
		public Timestamp LastHit
		{
			[Cpp2IlInjected.Token(Token = "0x60041B4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return lastHit_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				lastHit_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AA6")]
		[DebuggerNonUserCode]
		public StateOneofCase StateCase
		{
			[Cpp2IlInjected.Token(Token = "0x60041B6")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return stateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041AD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MiningRock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60041AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC90", Offset = "0x7FC690", VA = "0x1807FDC90")]
		[DebuggerNonUserCode]
		public MiningRock(MiningRock other)
		{
			//IL_0021: Expected O, but got I4
			//IL_007c: Expected I4, but got O
			Timestamp timestamp = other.lastHit_;
			int num = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			lastHit_ = (Timestamp)num;
			Types.FullState fullState = default(Types.FullState);
			if (other.stateCase_ == StateOneofCase.Full)
			{
				StateOneofCase stateOneofCase = other.stateCase_;
				if (other.state_ == null)
				{
					throw new InvalidCastException();
				}
				state_ = fullState;
				bool flag = (byte)(stateCase_ = ((fullState != null) ? StateOneofCase.Full : StateOneofCase.None)) != 0;
			}
			if ((long)fullState == 2)
			{
				StateOneofCase stateOneofCase2 = other.stateCase_;
				if (other.state_ == null)
				{
					throw new InvalidCastException();
				}
				Types.FullState fullState2 = default(Types.FullState);
				state_ = fullState2;
				stateCase_ = (StateOneofCase)fullState2;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB10", Offset = "0x7FB510", VA = "0x1807FCB10", Slot = "10")]
		[DebuggerNonUserCode]
		public MiningRock Clone()
		{
			return new MiningRock(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60041B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearState()
		{
			//IL_0010: Expected O, but got I4
			state_ = (stateCase_ = StateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB70", Offset = "0x7FB570", VA = "0x1807FCB70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (stateCase_ == StateOneofCase.Full)
					{
						object obj = state_;
						if (obj != null && obj == null)
						{
							goto IL_0086;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Types.FullState).TypeHandle != null && (object)typeof(Types.FullState).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					Types.FullState objB = default(Types.FullState);
					if (flag && object.Equals(Special, objB))
					{
						bool flag2 = object.Equals(lastHit_, objB);
						if (flag2 && stateCase_ == (flag2 ? StateOneofCase.Full : StateOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0086;
			IL_0086:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCF0", Offset = "0x7FB6F0", VA = "0x1807FCCF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiningRock other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Full)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						goto IL_00b1;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.stateCase_ == StateOneofCase.Full)
				{
					obj2 = other.state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Types.FullState special = Special;
					Types.FullState special2 = other.Special;
					if (object.Equals(special, special2))
					{
						Timestamp objB = other.lastHit_;
						if (object.Equals(lastHit_, objB))
						{
							StateOneofCase stateOneofCase = other.stateCase_;
							if (stateCase_ == stateOneofCase)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								bool flag = object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00b1;
			IL_00b1:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF60", Offset = "0x7FB960", VA = "0x1807FCF60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0067
			StateOneofCase stateOneofCase = stateCase_;
			int num = 0;
			if (stateOneofCase == StateOneofCase.Full)
			{
				object obj = state_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (stateOneofCase == StateOneofCase.Special)
			{
				object obj2 = state_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			Timestamp timestamp = lastHit_;
			if (timestamp != null)
			{
				int hashCode3 = timestamp.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60041BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9D0", Offset = "0x7FC3D0", VA = "0x1807FD9D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60041BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA30", Offset = "0x7FC430", VA = "0x1807FDA30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0079
			//IL_002c: Expected O, but got I4
			StateOneofCase stateOneofCase = stateCase_;
			int num = 0;
			if (stateOneofCase == StateOneofCase.Full)
			{
				if (stateCase_ == StateOneofCase.Full)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (stateOneofCase == StateOneofCase.Special && stateCase_ == StateOneofCase.Special)
			{
				object obj2 = state_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if ((long)lastHit_ != 0)
			{
				Timestamp value = lastHit_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60041BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8B0", Offset = "0x7FB2B0", VA = "0x1807FC8B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (stateCase_ == StateOneofCase.Full)
			{
				if (stateCase_ == StateOneofCase.Full)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (stateCase_ == StateOneofCase.Special)
			{
				if (stateCase_ == StateOneofCase.Special)
				{
					object obj2 = state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			Timestamp timestamp = lastHit_;
			if (timestamp != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60041BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD380", Offset = "0x7FBD80", VA = "0x1807FD380", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiningRock other)
		{
			//IL_0118: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.lastHit_ != 0)
			{
				Timestamp timestamp = lastHit_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastHit_ = new Timestamp());
					Timestamp timestamp3 = lastHit_;
				}
				Timestamp other2 = other.lastHit_;
				timestamp.MergeFrom(other2);
			}
			if (other.stateCase_ == StateOneofCase.Full)
			{
				object obj = default(object);
				if (stateCase_ == StateOneofCase.Full)
				{
					obj = state_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					bool flag = (byte)(stateCase_ = (((state_ = new Types.FullState()) != null) ? StateOneofCase.Full : StateOneofCase.None)) != 0;
				}
				if (stateCase_ == StateOneofCase.Full)
				{
					object obj2 = state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.stateCase_ == StateOneofCase.Full)
				{
					object obj3 = other.state_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(Timestamp).TypeHandle != 2)
			{
			}
			if (Special == null)
			{
				stateCase_ = (StateOneofCase)(state_ = new Types.FullState());
			}
			Types.FullState special = Special;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD620", Offset = "0x7FC020", VA = "0x1807FD620", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.FullState fullState = new Types.FullState();
				if (stateCase_ == StateOneofCase.Full)
				{
					if (stateCase_ != StateOneofCase.Full)
					{
					}
					object obj = state_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(fullState);
				state_ = fullState;
				bool flag = (byte)(stateCase_ = ((fullState != null) ? StateOneofCase.Full : StateOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				Types.FullState builder = new Types.FullState();
				if (stateCase_ == StateOneofCase.Special)
				{
					if (stateCase_ != StateOneofCase.Special)
					{
					}
					object obj2 = state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				state_ = builder;
				stateCase_ = (StateOneofCase)typeof(Types.FullState).TypeHandle;
			}
			if ((long)typeof(Types.FullState).TypeHandle == 26)
			{
				Timestamp builder2 = default(Timestamp);
				if (lastHit_ == null)
				{
					Timestamp timestamp = (lastHit_ = new Timestamp());
					builder2 = lastHit_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60041C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE40", Offset = "0x7FB840", VA = "0x1807FCE40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = lastHit_;
				while (stateCase_ != StateOneofCase.Special)
				{
				}
				object obj = state_;
				while (obj == null)
				{
				}
				if (obj != null)
				{
					while (stateCase_ != StateOneofCase.Full)
					{
					}
					object obj2 = state_;
					while (obj2 == null)
					{
					}
					while (obj2 != null)
					{
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD880", Offset = "0x7FC280", VA = "0x1807FD880", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			//IL_003b: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						lastHit_ = (Timestamp)num2;
						goto case 0;
					}
					throw new InvalidCastException();
				}
				case 0:
					if (value == null || value != null)
					{
						state_ = value;
						stateCase_ = (StateOneofCase)typeof(Timestamp).TypeHandle;
						break;
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				state_ = value;
				bool flag = (byte)(stateCase_ = ((value != null) ? StateOneofCase.Full : StateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA30", Offset = "0x7FB430", VA = "0x1807FCA30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				stateCase_ = StateOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0A0", Offset = "0x7FBAA0", VA = "0x1807FD0A0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "State"))
			{
				StateOneofCase stateOneofCase = stateCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA80", Offset = "0x7FB480", VA = "0x1807FCA80", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "State"))
			{
				state_ = (stateCase_ = StateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD150", Offset = "0x7FBB50", VA = "0x1807FD150")]
		public StateOneofCase GetState(ITransactionContext context)
		{
			//Discarded unreachable code: IL_0034
			if (stateCase_ == StateOneofCase.None)
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				if ((long)lastHit_ != 0)
				{
					DateTime dateTime = lastHit_.ToDateTime();
					TimeSpan timeSpan = default(TimeSpan);
					if ((object)timeSpan == null)
					{
						goto IL_002d;
					}
				}
				return StateOneofCase.Full;
			}
			goto IL_002d;
			IL_002d:
			return stateCase_;
		}

		[Cpp2IlInjected.Token(Token = "0x60041C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD360", Offset = "0x7FBD60", VA = "0x1807FD360")]
		public bool IsFull(ITransactionContext context)
		{
			return GetState(context) != StateOneofCase.None;
		}

		[Cpp2IlInjected.Token(Token = "0x60041C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB80", Offset = "0x7FC580", VA = "0x1807FDB80")]
		static MiningRock()
		{
			Func<MiningRock> func = default(Func<MiningRock>);
			_parser = (MessageParser<MiningRock>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
