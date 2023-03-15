using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public sealed class UnlockRequirementTask : IMessage<UnlockRequirementTask>, IMessage, IEquatable<UnlockRequirementTask>, IDeepCloneable<UnlockRequirementTask>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private static readonly MessageParser<UnlockRequirementTask> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public const int MinCollectedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int minCollected_;

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		[DebuggerNonUserCode]
		public static MessageParser<UnlockRequirementTask> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0x35574B0", Offset = "0x3555EB0", VA = "0x1835574B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0x35573E0", Offset = "0x3555DE0", VA = "0x1835573E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x3557510", Offset = "0x3555F10", VA = "0x183557510", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[DebuggerNonUserCode]
		public int MinCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minCollected_;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minCollected_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UnlockRequirementTask()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public UnlockRequirementTask(UnlockRequirementTask other)
		{
			int num = (minCollected_ = other.minCollected_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x3557030", Offset = "0x3555A30", VA = "0x183557030", Slot = "10")]
		[DebuggerNonUserCode]
		public UnlockRequirementTask Clone()
		{
			//Discarded unreachable code: IL_0029
			UnlockRequirementTask unlockRequirementTask = new UnlockRequirementTask();
			int num = (unlockRequirementTask.minCollected_ = minCollected_);
			UnknownFieldSet unknownFieldSet = (unlockRequirementTask._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return unlockRequirementTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x35570B0", Offset = "0x3555AB0", VA = "0x1835570B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minCollected_ == (IntPtr)typeof(UnlockRequirementTask).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnlockRequirementTask other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minCollected_;
				if (minCollected_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (minCollected_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x3557270", Offset = "0x3555C70", VA = "0x183557270", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (minCollected_ != 0)
			{
				int value = minCollected_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x3556F90", Offset = "0x3555990", VA = "0x183556F90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = minCollected_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnlockRequirementTask other)
		{
			if (other != null)
			{
				int num = other.minCollected_;
				if (num != 0)
				{
					minCollected_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (minCollected_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x3557140", Offset = "0x3555B40", VA = "0x183557140", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = minCollected_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x35571F0", Offset = "0x3555BF0", VA = "0x1835571F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				minCollected_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minCollected_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x35572D0", Offset = "0x3555CD0", VA = "0x1835572D0")]
		static UnlockRequirementTask()
		{
			Func<UnlockRequirementTask> func = default(Func<UnlockRequirementTask>);
			_parser = (MessageParser<UnlockRequirementTask>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
