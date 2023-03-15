using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000806")]
	public sealed class ConditionManaHasAlreadyMissed : ICondition, IMessage<ConditionManaHasAlreadyMissed>, IMessage, IEquatable<ConditionManaHasAlreadyMissed>, IDeepCloneable<ConditionManaHasAlreadyMissed>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027FD")]
		private static readonly MessageParser<ConditionManaHasAlreadyMissed> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027FE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027FF")]
		public const int InversedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002800")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x1700168F")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600592E")]
			[Cpp2IlInjected.Address(RVA = "0x207AE80", Offset = "0x2079880", VA = "0x18207AE80", Slot = "5")]
			get
			{
				string result = "Already Missed Mana";
				if (inversed_)
				{
					result = "Never Missed Mana";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001690")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600592F")]
			[Cpp2IlInjected.Address(RVA = "0x207AEF0", Offset = "0x20798F0", VA = "0x18207AEF0", Slot = "6")]
			get
			{
				return ConditionListener.ManaAlreadyMissed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001691")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionManaHasAlreadyMissed> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005931")]
			[Cpp2IlInjected.Address(RVA = "0x207AF00", Offset = "0x2079900", VA = "0x18207AF00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001692")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005932")]
			[Cpp2IlInjected.Address(RVA = "0x207ADB0", Offset = "0x20797B0", VA = "0x18207ADB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001693")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005933")]
			[Cpp2IlInjected.Address(RVA = "0x207AF60", Offset = "0x2079960", VA = "0x18207AF60", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001694")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005937")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005938")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600592D")]
		[Cpp2IlInjected.Address(RVA = "0x207AA10", Offset = "0x2079410", VA = "0x18207AA10")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			IProfilePlayer section = playerProfile.Section;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005930")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005934")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionManaHasAlreadyMissed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005935")]
		[Cpp2IlInjected.Address(RVA = "0x13AA900", Offset = "0x13A9300", VA = "0x1813AA900")]
		[DebuggerNonUserCode]
		public ConditionManaHasAlreadyMissed(ConditionManaHasAlreadyMissed other)
		{
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005936")]
		[Cpp2IlInjected.Address(RVA = "0x207A990", Offset = "0x2079390", VA = "0x18207A990", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionManaHasAlreadyMissed Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionManaHasAlreadyMissed conditionManaHasAlreadyMissed = new ConditionManaHasAlreadyMissed();
			bool flag = (conditionManaHasAlreadyMissed.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionManaHasAlreadyMissed._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionManaHasAlreadyMissed;
		}

		[Cpp2IlInjected.Token(Token = "0x6005939")]
		[Cpp2IlInjected.Address(RVA = "0x207AA80", Offset = "0x2079480", VA = "0x18207AA80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionManaHasAlreadyMissed).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600593A")]
		[Cpp2IlInjected.Address(RVA = "0x13AA400", Offset = "0x13A8E00", VA = "0x1813AA400", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionManaHasAlreadyMissed other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.inversed_;
				if (inversed_ == flag)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600593B")]
		[Cpp2IlInjected.Address(RVA = "0x13AA570", Offset = "0x13A8F70", VA = "0x1813AA570", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600593C")]
		[Cpp2IlInjected.Address(RVA = "0x207AC40", Offset = "0x2079640", VA = "0x18207AC40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600593D")]
		[Cpp2IlInjected.Address(RVA = "0x13AA790", Offset = "0x13A9190", VA = "0x1813AA790", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (inversed_)
			{
				bool value = inversed_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600593E")]
		[Cpp2IlInjected.Address(RVA = "0x13AA330", Offset = "0x13A8D30", VA = "0x1813AA330", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				bool flag = inversed_;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x600593F")]
		[Cpp2IlInjected.Address(RVA = "0x13AA660", Offset = "0x13A9060", VA = "0x1813AA660", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionManaHasAlreadyMissed other)
		{
			if (other != null)
			{
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005940")]
		[Cpp2IlInjected.Address(RVA = "0x13AA5E0", Offset = "0x13A8FE0", VA = "0x1813AA5E0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005941")]
		[Cpp2IlInjected.Address(RVA = "0x207AB10", Offset = "0x2079510", VA = "0x18207AB10", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005942")]
		[Cpp2IlInjected.Address(RVA = "0x207ABC0", Offset = "0x20795C0", VA = "0x18207ABC0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				inversed_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005943")]
		[Cpp2IlInjected.Address(RVA = "0x13AA370", Offset = "0x13A8D70", VA = "0x1813AA370", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005944")]
		[Cpp2IlInjected.Address(RVA = "0x207ACA0", Offset = "0x20796A0", VA = "0x18207ACA0")]
		static ConditionManaHasAlreadyMissed()
		{
			Func<ConditionManaHasAlreadyMissed> func = default(Func<ConditionManaHasAlreadyMissed>);
			_parser = (MessageParser<ConditionManaHasAlreadyMissed>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005945")]
		[Cpp2IlInjected.Address(RVA = "0x207AA10", Offset = "0x2079410", VA = "0x18207AA10", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			IProfilePlayer section = playerProfile.Section;
			bool result = default(bool);
			return result;
		}
	}
}
