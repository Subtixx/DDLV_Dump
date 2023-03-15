using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001044")]
	public sealed class MissionQueue : IMessage<MissionQueue>, IMessage, IEquatable<MissionQueue>, IDeepCloneable<MissionQueue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400430E")]
		private static readonly MessageParser<MissionQueue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400430F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004310")]
		public const int SlotsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4004311")]
		private static readonly FieldCodec<MissionSlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004312")]
		private readonly RepeatedField<MissionSlot> slots_ = (RepeatedField<MissionSlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170016F3")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionQueue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008416")]
			[Cpp2IlInjected.Address(RVA = "0x1A55580", Offset = "0x1A53F80", VA = "0x181A55580")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008417")]
			[Cpp2IlInjected.Address(RVA = "0x1A554B0", Offset = "0x1A53EB0", VA = "0x181A554B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008418")]
			[Cpp2IlInjected.Address(RVA = "0x1A555E0", Offset = "0x1A53FE0", VA = "0x181A555E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F6")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionSlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x600841C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008419")]
		[Cpp2IlInjected.Address(RVA = "0x1A55430", Offset = "0x1A53E30", VA = "0x181A55430")]
		[DebuggerNonUserCode]
		public MissionQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600841A")]
		[Cpp2IlInjected.Address(RVA = "0x1A55330", Offset = "0x1A53D30", VA = "0x181A55330")]
		[DebuggerNonUserCode]
		public MissionQueue(MissionQueue other)
		{
			RepeatedField<MissionSlot> repeatedField = (slots_ = (RepeatedField<MissionSlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600841B")]
		[Cpp2IlInjected.Address(RVA = "0x1A54B50", Offset = "0x1A53550", VA = "0x181A54B50", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionQueue Clone()
		{
			//Discarded unreachable code: IL_003b
			MissionQueue missionQueue = new MissionQueue();
			RepeatedField<MissionSlot> repeatedField = (missionQueue.slots_ = (RepeatedField<MissionSlot>)(object)new RepeatedField<T>());
			RepeatedField<MissionSlot> repeatedField2 = (missionQueue.slots_ = (RepeatedField<MissionSlot>)(object)((RepeatedField<T>)(object)slots_).Clone());
			UnknownFieldSet unknownFieldSet = (missionQueue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionQueue;
		}

		[Cpp2IlInjected.Token(Token = "0x600841D")]
		[Cpp2IlInjected.Address(RVA = "0x1A54C80", Offset = "0x1A53680", VA = "0x181A54C80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<MissionSlot> repeatedField = slots_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600841E")]
		[Cpp2IlInjected.Address(RVA = "0x1A54D60", Offset = "0x1A53760", VA = "0x181A54D60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionQueue other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<MissionSlot> repeatedField = slots_;
				RepeatedField<MissionSlot> repeatedField2 = other.slots_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600841F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)slots_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6008420")]
		[Cpp2IlInjected.Address(RVA = "0x1A55040", Offset = "0x1A53A40", VA = "0x181A55040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008421")]
		[Cpp2IlInjected.Address(RVA = "0x1A550A0", Offset = "0x1A53AA0", VA = "0x181A550A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<MissionSlot> repeatedField = slots_;
			FieldCodec<MissionSlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008422")]
		[Cpp2IlInjected.Address(RVA = "0x1A54A40", Offset = "0x1A53440", VA = "0x181A54A40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<MissionSlot> repeatedField = slots_;
			FieldCodec<MissionSlot> repeated_slots_codec = _repeated_slots_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008423")]
		[Cpp2IlInjected.Address(RVA = "0x1A54E70", Offset = "0x1A53870", VA = "0x181A54E70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionQueue other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<MissionSlot> repeatedField = slots_;
				RepeatedField<MissionSlot> repeatedField2 = other.slots_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008424")]
		[Cpp2IlInjected.Address(RVA = "0x1A54EF0", Offset = "0x1A538F0", VA = "0x181A54EF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<MissionSlot> repeatedField = slots_;
					FieldCodec<MissionSlot> repeated_slots_codec = _repeated_slots_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008425")]
		[Cpp2IlInjected.Address(RVA = "0x1A54DF0", Offset = "0x1A537F0", VA = "0x181A54DF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MissionSlot> repeatedField = slots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008426")]
		[Cpp2IlInjected.Address(RVA = "0x1A54FE0", Offset = "0x1A539E0", VA = "0x181A54FE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008427")]
		[Cpp2IlInjected.Address(RVA = "0x1A54AF0", Offset = "0x1A534F0", VA = "0x181A54AF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<MissionSlot> repeatedField = slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008428")]
		[Cpp2IlInjected.Address(RVA = "0x1A55160", Offset = "0x1A53B60", VA = "0x181A55160")]
		static MissionQueue()
		{
			Func<MissionQueue> func = default(Func<MissionQueue>);
			_parser = (MessageParser<MissionQueue>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MissionSlot> parser = MissionSlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionQueue>)(object)FieldCodec.ForMessage<MissionSlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
