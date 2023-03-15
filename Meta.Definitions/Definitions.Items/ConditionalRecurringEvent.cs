using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003C8")]
	public sealed class ConditionalRecurringEvent : IMessage<ConditionalRecurringEvent>, IMessage, IEquatable<ConditionalRecurringEvent>, IDeepCloneable<ConditionalRecurringEvent>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003C9")]
		public enum EndOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40013F6")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40013F7")]
			DateUTC = 2,
			[Cpp2IlInjected.Token(Token = "0x40013F8")]
			DateLocal = 3,
			[Cpp2IlInjected.Token(Token = "0x40013F9")]
			Duration = 4
		}

		[Cpp2IlInjected.Token(Token = "0x40013EC")]
		private static readonly MessageParser<ConditionalRecurringEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40013ED")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40013EE")]
		public const int RecurringEventItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40013EF")]
		private int recurringEventItemID_;

		[Cpp2IlInjected.Token(Token = "0x40013F0")]
		public const int DateUTCFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40013F1")]
		public const int DateLocalFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40013F2")]
		public const int DurationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40013F3")]
		private object end_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40013F4")]
		private EndOneofCase endCase_;

		[Cpp2IlInjected.Token(Token = "0x17000B57")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalRecurringEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002D27")]
			[Cpp2IlInjected.Address(RVA = "0x24D41D0", Offset = "0x24D2BD0", VA = "0x1824D41D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B58")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D28")]
			[Cpp2IlInjected.Address(RVA = "0x24D40A0", Offset = "0x24D2AA0", VA = "0x1824D40A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B59")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D29")]
			[Cpp2IlInjected.Address(RVA = "0x24D4230", Offset = "0x24D2C30", VA = "0x1824D4230", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5A")]
		[DebuggerNonUserCode]
		public int RecurringEventItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002D2D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D2E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5B")]
		[DebuggerNonUserCode]
		public Timestamp DateUTC
		{
			[Cpp2IlInjected.Token(Token = "0x6002D2F")]
			[Cpp2IlInjected.Address(RVA = "0x24D4040", Offset = "0x24D2A40", VA = "0x1824D4040")]
			get
			{
				int num = 0;
				if (endCase_ == EndOneofCase.DateUTC)
				{
					object obj = end_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002D30")]
			[Cpp2IlInjected.Address(RVA = "0x7FE160", Offset = "0x7FCB60", VA = "0x1807FE160")]
			set
			{
				end_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5C")]
		[DebuggerNonUserCode]
		public Timestamp DateLocal
		{
			[Cpp2IlInjected.Token(Token = "0x6002D31")]
			[Cpp2IlInjected.Address(RVA = "0x24D3FE0", Offset = "0x24D29E0", VA = "0x1824D3FE0")]
			get
			{
				int num = 0;
				if (endCase_ == EndOneofCase.DateLocal)
				{
					object obj = end_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002D32")]
			[Cpp2IlInjected.Address(RVA = "0x24D4340", Offset = "0x24D2D40", VA = "0x1824D4340")]
			set
			{
				end_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5D")]
		[DebuggerNonUserCode]
		public Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6002D33")]
			[Cpp2IlInjected.Address(RVA = "0x24D4170", Offset = "0x24D2B70", VA = "0x1824D4170")]
			get
			{
				int num = 0;
				if (endCase_ == EndOneofCase.Duration)
				{
					object obj = end_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002D34")]
			[Cpp2IlInjected.Address(RVA = "0x24D4380", Offset = "0x24D2D80", VA = "0x1824D4380")]
			set
			{
				end_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5E")]
		[DebuggerNonUserCode]
		public EndOneofCase EndCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002D35")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return endCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D2A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionalRecurringEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002D2B")]
		[Cpp2IlInjected.Address(RVA = "0x24D3E00", Offset = "0x24D2800", VA = "0x1824D3E00")]
		[DebuggerNonUserCode]
		public ConditionalRecurringEvent(ConditionalRecurringEvent other)
		{
			//IL_0064: Expected I4, but got O
			int num = (recurringEventItemID_ = other.recurringEventItemID_);
			EndOneofCase endOneofCase = other.endCase_;
			if (other.end_ != null)
			{
				Duration duration = default(Duration);
				end_ = duration;
				EndOneofCase endOneofCase2 = other.endCase_;
				if (other.end_ != null)
				{
					Timestamp timestamp = default(Timestamp);
					end_ = timestamp;
					EndOneofCase endOneofCase3 = other.endCase_;
					if (other.end_ != null)
					{
						Timestamp timestamp2 = default(Timestamp);
						end_ = timestamp2;
						endCase_ = (EndOneofCase)timestamp2;
						UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
						throw new NullReferenceException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D2C")]
		[Cpp2IlInjected.Address(RVA = "0x24D2E50", Offset = "0x24D1850", VA = "0x1824D2E50", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalRecurringEvent Clone()
		{
			return new ConditionalRecurringEvent(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D36")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearEnd()
		{
			//IL_0010: Expected O, but got I4
			end_ = (endCase_ = EndOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D37")]
		[Cpp2IlInjected.Address(RVA = "0x24D2FB0", Offset = "0x24D19B0", VA = "0x1824D2FB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = default(Timestamp);
				Timestamp objB2 = default(Timestamp);
				if ((IntPtr)recurringEventItemID_ == (IntPtr)typeof(ConditionalRecurringEvent).TypeHandle && object.Equals(DateUTC, objB) && object.Equals(DateLocal, objB2))
				{
					Duration objB3 = default(Duration);
					bool flag = object.Equals(Duration, objB3);
					if (flag && endCase_ == (flag ? ((EndOneofCase)1) : EndOneofCase.None))
					{
						return object.Equals(_unknownFields, objB3);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D38")]
		[Cpp2IlInjected.Address(RVA = "0x24D2EB0", Offset = "0x24D18B0", VA = "0x1824D2EB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalRecurringEvent other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.recurringEventItemID_;
				if (recurringEventItemID_ == num)
				{
					Timestamp dateUTC = DateUTC;
					Timestamp dateUTC2 = other.DateUTC;
					if (object.Equals(dateUTC, dateUTC2))
					{
						Timestamp dateLocal = DateLocal;
						Timestamp dateLocal2 = other.DateLocal;
						if (object.Equals(dateLocal, dateLocal2))
						{
							Duration duration = Duration;
							Duration duration2 = other.Duration;
							if (object.Equals(duration, duration2))
							{
								EndOneofCase endOneofCase = other.endCase_;
								if (endCase_ == endOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D39")]
		[Cpp2IlInjected.Address(RVA = "0x24D31F0", Offset = "0x24D1BF0", VA = "0x1824D31F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_007e
			while (true)
			{
				int num = recurringEventItemID_;
				int num2 = 0;
				if (num != 0)
				{
				}
				if (endCase_ != EndOneofCase.DateUTC)
				{
					continue;
				}
				object obj = end_;
				if (obj != null)
				{
					int hashCode = obj.GetHashCode();
					if (endCase_ != EndOneofCase.DateLocal)
					{
						continue;
					}
					object obj2 = end_;
					if (obj2 != null)
					{
						int hashCode2 = obj2.GetHashCode();
						if (endCase_ == EndOneofCase.Duration)
						{
							object obj3 = end_;
							if (obj3 == null)
							{
								break;
							}
							int hashCode3 = obj3.GetHashCode();
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode4 = unknownFields.GetHashCode();
						}
						return 1;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3A")]
		[Cpp2IlInjected.Address(RVA = "0x24D3AC0", Offset = "0x24D24C0", VA = "0x1824D3AC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3B")]
		[Cpp2IlInjected.Address(RVA = "0x24D3B20", Offset = "0x24D2520", VA = "0x1824D3B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_009a
			while (true)
			{
				if (recurringEventItemID_ != 0)
				{
					int value = recurringEventItemID_;
					output.WriteInt32(value);
				}
				EndOneofCase endOneofCase = endCase_;
				int num = 0;
				if (endOneofCase != EndOneofCase.DateUTC)
				{
					continue;
				}
				if (endCase_ == EndOneofCase.DateUTC)
				{
					object obj = end_;
					if (obj != null && obj == null)
					{
						break;
					}
				}
				if (endCase_ != EndOneofCase.DateLocal)
				{
					continue;
				}
				if (endCase_ == EndOneofCase.DateLocal)
				{
					object obj2 = end_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (endCase_ == EndOneofCase.Duration && endCase_ == EndOneofCase.Duration)
				{
					object obj3 = end_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3C")]
		[Cpp2IlInjected.Address(RVA = "0x24D2B80", Offset = "0x24D1580", VA = "0x1824D2B80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = recurringEventItemID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (endCase_ == EndOneofCase.DateUTC)
			{
				if (endCase_ != EndOneofCase.DateUTC)
				{
				}
				object obj = end_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num4 = default(int);
				num2 += num4;
			}
			if (endCase_ == EndOneofCase.DateLocal)
			{
				if (endCase_ != EndOneofCase.DateLocal)
				{
				}
				object obj2 = end_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num5 = default(int);
				num2 += num5;
			}
			if (endCase_ == EndOneofCase.Duration)
			{
				if (endCase_ == EndOneofCase.Duration)
				{
					object obj3 = end_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num6 = default(int);
				num2 += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3D")]
		[Cpp2IlInjected.Address(RVA = "0x24D3460", Offset = "0x24D1E60", VA = "0x1824D3460", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalRecurringEvent other)
		{
			//Discarded unreachable code: IL_00ec
			//IL_004c: Expected I4, but got O
			//IL_0083: Expected I4, but got O
			//IL_00b3: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			int num = other.recurringEventItemID_;
			if (num != 0)
			{
				recurringEventItemID_ = num;
			}
			EndOneofCase endOneofCase = other.endCase_;
			if (num != 0)
			{
				if (num != 0)
				{
					if (endOneofCase != (EndOneofCase)1)
					{
						goto IL_00cc;
					}
					if (Duration == null)
					{
						endCase_ = (EndOneofCase)(end_ = new Duration());
					}
					Duration duration = Duration;
					Duration duration2 = other.Duration;
					duration.MergeFrom(duration2);
				}
				if (DateLocal == null)
				{
					endCase_ = (EndOneofCase)(end_ = new Timestamp());
				}
				Timestamp dateLocal = DateLocal;
				Timestamp dateLocal2 = other.DateLocal;
			}
			if (DateUTC == null)
			{
				endCase_ = (EndOneofCase)(end_ = new Timestamp());
			}
			Timestamp dateUTC = DateUTC;
			Timestamp dateUTC2 = other.DateUTC;
			dateUTC.MergeFrom(dateUTC2);
			goto IL_00cc;
			IL_00cc:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3E")]
		[Cpp2IlInjected.Address(RVA = "0x24D3640", Offset = "0x24D2040", VA = "0x1824D3640", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00ac: Expected I4, but got O
			//IL_010d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					Timestamp timestamp = new Timestamp();
					if (endCase_ == EndOneofCase.DateLocal)
					{
						if (endCase_ != EndOneofCase.DateLocal)
						{
						}
						object obj = end_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(timestamp);
					end_ = timestamp;
					endCase_ = (EndOneofCase)timestamp;
				}
				if (num != 34)
				{
					goto IL_010d;
				}
				Duration builder = new Duration();
				if (endCase_ == EndOneofCase.Duration)
				{
					if (endCase_ != EndOneofCase.Duration)
					{
					}
					object obj2 = end_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				end_ = builder;
				endCase_ = (EndOneofCase)typeof(Duration).TypeHandle;
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (recurringEventItemID_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				Timestamp builder2 = new Timestamp();
				if (endCase_ == EndOneofCase.DateUTC)
				{
					if (endCase_ != EndOneofCase.DateUTC)
					{
					}
					object obj3 = end_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				end_ = builder2;
				endCase_ = (EndOneofCase)typeof(Timestamp).TypeHandle;
			}
			goto IL_010d;
			IL_010d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3F")]
		[Cpp2IlInjected.Address(RVA = "0x24D30F0", Offset = "0x24D1AF0", VA = "0x1824D30F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						Duration duration = Duration;
					}
					Timestamp dateLocal = DateLocal;
				}
				Timestamp dateUTC = DateUTC;
			}
			int num2 = recurringEventItemID_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D40")]
		[Cpp2IlInjected.Address(RVA = "0x24D3920", Offset = "0x24D2320", VA = "0x1824D3920", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_006f
			//IL_0025: Expected O, but got I4
			//IL_0030: Expected I4, but got O
			//IL_004b: Expected I4, but got O
			//IL_0066: Expected I4, but got O
			//IL_006e: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							end_ = num2;
							endCase_ = (EndOneofCase)typeof(Timestamp).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							end_ = value;
							endCase_ = (EndOneofCase)typeof(Timestamp).TypeHandle;
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
					end_ = value;
					endCase_ = (EndOneofCase)typeof(Timestamp).TypeHandle;
				}
			}
			else
			{
				object obj = default(object);
				recurringEventItemID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D41")]
		[Cpp2IlInjected.Address(RVA = "0x24D2D90", Offset = "0x24D1790", VA = "0x1824D2D90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015
			//IL_000d: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				end_ = num;
				endCase_ = (EndOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D42")]
		[Cpp2IlInjected.Address(RVA = "0x24D33B0", Offset = "0x24D1DB0", VA = "0x1824D33B0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "End"))
			{
				EndOneofCase endOneofCase = endCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D43")]
		[Cpp2IlInjected.Address(RVA = "0x24D2DE0", Offset = "0x24D17E0", VA = "0x1824D2DE0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "End"))
			{
				end_ = (endCase_ = EndOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D44")]
		[Cpp2IlInjected.Address(RVA = "0x24D3CF0", Offset = "0x24D26F0", VA = "0x1824D3CF0")]
		static ConditionalRecurringEvent()
		{
			Func<ConditionalRecurringEvent> func = default(Func<ConditionalRecurringEvent>);
			_parser = (MessageParser<ConditionalRecurringEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
