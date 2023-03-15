using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007EC")]
	public sealed class ConditionFTUEEventCompleted : ICondition, IDataValidation, IMessage<ConditionFTUEEventCompleted>, IMessage, IEquatable<ConditionFTUEEventCompleted>, IDeepCloneable<ConditionFTUEEventCompleted>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027A3")]
		private static readonly MessageParser<ConditionFTUEEventCompleted> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027A4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027A5")]
		public const int FTUEEventFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027A6")]
		private int fTUEEvent_;

		[Cpp2IlInjected.Token(Token = "0x40027A7")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027A8")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001630")]
		private Item FTUEEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005799")]
			[Cpp2IlInjected.Address(RVA = "0x20726A0", Offset = "0x20710A0", VA = "0x1820726A0")]
			get
			{
				long num = Convert.ToInt64((uint)fTUEEvent_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001631")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600579B")]
			[Cpp2IlInjected.Address(RVA = "0x2072700", Offset = "0x2071100", VA = "0x182072700", Slot = "5")]
			get
			{
				//IL_0020: Expected O, but got I8
				//IL_0038: Expected O, but got I8
				if (inversed_)
				{
					long num = Convert.ToInt64((uint)fTUEEvent_);
					return $"FTUE Event {num} not completed.";
				}
				long num2 = Convert.ToInt64((uint)fTUEEvent_);
				return $"FTUE Event {num2} completed.";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001632")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600579C")]
			[Cpp2IlInjected.Address(RVA = "0x2072830", Offset = "0x2071230", VA = "0x182072830", Slot = "6")]
			get
			{
				return ConditionListener.FTUEEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001633")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionFTUEEventCompleted> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600579F")]
			[Cpp2IlInjected.Address(RVA = "0x2072840", Offset = "0x2071240", VA = "0x182072840")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001634")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60057A0")]
			[Cpp2IlInjected.Address(RVA = "0x20725D0", Offset = "0x2070FD0", VA = "0x1820725D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001635")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60057A1")]
			[Cpp2IlInjected.Address(RVA = "0x20728A0", Offset = "0x20712A0", VA = "0x1820728A0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001636")]
		[DebuggerNonUserCode]
		public int FTUEEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60057A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return fTUEEvent_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057A6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				fTUEEvent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001637")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x60057A7")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057A8")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600579A")]
		[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2070B40", VA = "0x182072140")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = fTUEEvent_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600579D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600579E")]
		[Cpp2IlInjected.Address(RVA = "0x20720D0", Offset = "0x2070AD0", VA = "0x1820720D0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (fTUEEvent_ == 0)
			{
				context.AddInvalidMemberError("Please select an FTUE Event", "FTUEEvent");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057A2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionFTUEEventCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60057A3")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionFTUEEventCompleted(ConditionFTUEEventCompleted other)
		{
			int num = (fTUEEvent_ = other.fTUEEvent_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60057A4")]
		[Cpp2IlInjected.Address(RVA = "0x2072040", Offset = "0x2070A40", VA = "0x182072040", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionFTUEEventCompleted Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionFTUEEventCompleted conditionFTUEEventCompleted = new ConditionFTUEEventCompleted();
			int num = (conditionFTUEEventCompleted.fTUEEvent_ = fTUEEvent_);
			bool flag = (conditionFTUEEventCompleted.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionFTUEEventCompleted._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionFTUEEventCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x60057A9")]
		[Cpp2IlInjected.Address(RVA = "0x2072210", Offset = "0x2070C10", VA = "0x182072210", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)fTUEEvent_ == (IntPtr)typeof(ConditionFTUEEventCompleted).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionFTUEEventCompleted).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionFTUEEventCompleted other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.fTUEEvent_;
				if (fTUEEvent_ == num)
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (fTUEEvent_ != 0)
				{
				}
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60057AC")]
		[Cpp2IlInjected.Address(RVA = "0x2072460", Offset = "0x2070E60", VA = "0x182072460", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60057AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (fTUEEvent_ != 0)
			{
				int value = fTUEEvent_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60057AE")]
		[Cpp2IlInjected.Address(RVA = "0x2071FB0", Offset = "0x20709B0", VA = "0x182071FB0", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = fTUEEvent_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60057AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionFTUEEventCompleted other)
		{
			if (other != null)
			{
				int num = other.fTUEEvent_;
				if (num != 0)
				{
					fTUEEvent_ = num;
				}
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (fTUEEvent_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057B1")]
		[Cpp2IlInjected.Address(RVA = "0x20722A0", Offset = "0x2070CA0", VA = "0x1820722A0", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = fTUEEvent_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057B2")]
		[Cpp2IlInjected.Address(RVA = "0x2072390", Offset = "0x2070D90", VA = "0x182072390", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				fTUEEvent_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60057B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				fTUEEvent_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057B4")]
		[Cpp2IlInjected.Address(RVA = "0x20724C0", Offset = "0x2070EC0", VA = "0x1820724C0")]
		static ConditionFTUEEventCompleted()
		{
			Func<ConditionFTUEEventCompleted> func = default(Func<ConditionFTUEEventCompleted>);
			_parser = (MessageParser<ConditionFTUEEventCompleted>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057B5")]
		[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2070B40", VA = "0x182072140", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = fTUEEvent_;
			bool result = default(bool);
			return result;
		}
	}
}
