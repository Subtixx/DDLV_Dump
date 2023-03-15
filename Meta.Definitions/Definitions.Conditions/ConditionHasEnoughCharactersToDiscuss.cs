using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007F6")]
	public sealed class ConditionHasEnoughCharactersToDiscuss : ICondition, IMessage<ConditionHasEnoughCharactersToDiscuss>, IMessage, IEquatable<ConditionHasEnoughCharactersToDiscuss>, IDeepCloneable<ConditionHasEnoughCharactersToDiscuss>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027CE")]
		private static readonly MessageParser<ConditionHasEnoughCharactersToDiscuss> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027CF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027D0")]
		public const int MinimumFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027D1")]
		private int minimum_;

		[Cpp2IlInjected.Token(Token = "0x17001659")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005840")]
			[Cpp2IlInjected.Address(RVA = "0x2072F40", Offset = "0x2071940", VA = "0x182072F40", Slot = "5")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = minimum_;
				return $"Has a minimum of '{num}' characters to daily discuss";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700165A")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005841")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700165B")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionHasEnoughCharactersToDiscuss> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005843")]
			[Cpp2IlInjected.Address(RVA = "0x2072FB0", Offset = "0x20719B0", VA = "0x182072FB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700165C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005844")]
			[Cpp2IlInjected.Address(RVA = "0x2072E70", Offset = "0x2071870", VA = "0x182072E70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700165D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005845")]
			[Cpp2IlInjected.Address(RVA = "0x2073010", Offset = "0x2071A10", VA = "0x182073010", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700165E")]
		[DebuggerNonUserCode]
		public int Minimum
		{
			[Cpp2IlInjected.Token(Token = "0x6005849")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minimum_;
			}
			[Cpp2IlInjected.Token(Token = "0x600584A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minimum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600583F")]
		[Cpp2IlInjected.Address(RVA = "0x2072AD0", Offset = "0x20714D0", VA = "0x182072AD0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005842")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005846")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCharactersToDiscuss()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005847")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCharactersToDiscuss(ConditionHasEnoughCharactersToDiscuss other)
		{
			int num = (minimum_ = other.minimum_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005848")]
		[Cpp2IlInjected.Address(RVA = "0x2072A50", Offset = "0x2071450", VA = "0x182072A50", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCharactersToDiscuss Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionHasEnoughCharactersToDiscuss conditionHasEnoughCharactersToDiscuss = new ConditionHasEnoughCharactersToDiscuss();
			int num = (conditionHasEnoughCharactersToDiscuss.minimum_ = minimum_);
			UnknownFieldSet unknownFieldSet = (conditionHasEnoughCharactersToDiscuss._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionHasEnoughCharactersToDiscuss;
		}

		[Cpp2IlInjected.Token(Token = "0x600584B")]
		[Cpp2IlInjected.Address(RVA = "0x2072B40", Offset = "0x2071540", VA = "0x182072B40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minimum_ == (IntPtr)typeof(ConditionHasEnoughCharactersToDiscuss).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600584C")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionHasEnoughCharactersToDiscuss other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minimum_;
				if (minimum_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600584D")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (minimum_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600584E")]
		[Cpp2IlInjected.Address(RVA = "0x2072D00", Offset = "0x2071700", VA = "0x182072D00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600584F")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (minimum_ != 0)
			{
				int value = minimum_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005850")]
		[Cpp2IlInjected.Address(RVA = "0x20729B0", Offset = "0x20713B0", VA = "0x1820729B0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = minimum_;
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

		[Cpp2IlInjected.Token(Token = "0x6005851")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionHasEnoughCharactersToDiscuss other)
		{
			if (other != null)
			{
				int num = other.minimum_;
				if (num != 0)
				{
					minimum_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005852")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (minimum_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005853")]
		[Cpp2IlInjected.Address(RVA = "0x2072BD0", Offset = "0x20715D0", VA = "0x182072BD0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = minimum_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005854")]
		[Cpp2IlInjected.Address(RVA = "0x2072C80", Offset = "0x2071680", VA = "0x182072C80", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				minimum_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005855")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minimum_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005856")]
		[Cpp2IlInjected.Address(RVA = "0x2072D60", Offset = "0x2071760", VA = "0x182072D60")]
		static ConditionHasEnoughCharactersToDiscuss()
		{
			Func<ConditionHasEnoughCharactersToDiscuss> func = default(Func<ConditionHasEnoughCharactersToDiscuss>);
			_parser = (MessageParser<ConditionHasEnoughCharactersToDiscuss>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005857")]
		[Cpp2IlInjected.Address(RVA = "0x2072AD0", Offset = "0x20714D0", VA = "0x182072AD0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}
	}
}
