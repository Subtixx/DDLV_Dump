using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000800")]
	public sealed class ConditionIsFTUE : ICondition, IMessage<ConditionIsFTUE>, IMessage, IEquatable<ConditionIsFTUE>, IDeepCloneable<ConditionIsFTUE>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027E7")]
		private readonly Item lastFTUE;

		[Cpp2IlInjected.Token(Token = "0x40027E8")]
		private static readonly MessageParser<ConditionIsFTUE> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027E9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027EA")]
		public const int InversedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027EB")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001677")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60058CC")]
			[Cpp2IlInjected.Address(RVA = "0x2076540", Offset = "0x2074F40", VA = "0x182076540", Slot = "5")]
			get
			{
				if (!inversed_)
				{
				}
				return "FTUE " + "NOT " + "in progress";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001678")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60058CD")]
			[Cpp2IlInjected.Address(RVA = "0x20765C0", Offset = "0x2074FC0", VA = "0x1820765C0", Slot = "6")]
			get
			{
				return ConditionListener.MissionCompleted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001679")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionIsFTUE> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60058CF")]
			[Cpp2IlInjected.Address(RVA = "0x20765D0", Offset = "0x2074FD0", VA = "0x1820765D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60058D0")]
			[Cpp2IlInjected.Address(RVA = "0x2076470", Offset = "0x2074E70", VA = "0x182076470")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60058D1")]
			[Cpp2IlInjected.Address(RVA = "0x2076630", Offset = "0x2075030", VA = "0x182076630", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167C")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x60058D5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x60058D6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058CB")]
		[Cpp2IlInjected.Address(RVA = "0x2075DE0", Offset = "0x20747E0", VA = "0x182075DE0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0019
			IProfileWorld section = worldProfile.Section;
			bool inversed = inversed_;
			return Operations.EvaluateInverse(section == null, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x60058CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058D2")]
		[Cpp2IlInjected.Address(RVA = "0x2076360", Offset = "0x2074D60", VA = "0x182076360")]
		[DebuggerNonUserCode]
		public ConditionIsFTUE()
		{
			//IL_0013: Expected O, but got I8
			lastFTUE = (Item)Convert.ToInt64(2070000103u);
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60058D3")]
		[Cpp2IlInjected.Address(RVA = "0x20763D0", Offset = "0x2074DD0", VA = "0x1820763D0")]
		[DebuggerNonUserCode]
		public ConditionIsFTUE(ConditionIsFTUE other)
		{
			lastFTUE = (Item)typeof(Item).TypeHandle;
			base._002Ector();
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058D4")]
		[Cpp2IlInjected.Address(RVA = "0x2075D10", Offset = "0x2074710", VA = "0x182075D10", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionIsFTUE Clone()
		{
			//Discarded unreachable code: IL_0036
			//IL_0013: Expected O, but got I8
			long num = Convert.ToInt64(2070000103u);
			ConditionIsFTUE conditionIsFTUE = default(ConditionIsFTUE);
			conditionIsFTUE.lastFTUE = (Item)num;
			bool flag = (conditionIsFTUE.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionIsFTUE._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionIsFTUE;
		}

		[Cpp2IlInjected.Token(Token = "0x60058D7")]
		[Cpp2IlInjected.Address(RVA = "0x2075E60", Offset = "0x2074860", VA = "0x182075E60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionIsFTUE).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058D8")]
		[Cpp2IlInjected.Address(RVA = "0x2075EF0", Offset = "0x20748F0", VA = "0x182075EF0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionIsFTUE other)
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

		[Cpp2IlInjected.Token(Token = "0x60058D9")]
		[Cpp2IlInjected.Address(RVA = "0x2075FD0", Offset = "0x20749D0", VA = "0x182075FD0", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x60058DA")]
		[Cpp2IlInjected.Address(RVA = "0x2076190", Offset = "0x2074B90", VA = "0x182076190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60058DB")]
		[Cpp2IlInjected.Address(RVA = "0x20761F0", Offset = "0x2074BF0", VA = "0x1820761F0", Slot = "10")]
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

		[Cpp2IlInjected.Token(Token = "0x60058DC")]
		[Cpp2IlInjected.Address(RVA = "0x2075CC0", Offset = "0x20746C0", VA = "0x182075CC0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60058DD")]
		[Cpp2IlInjected.Address(RVA = "0x2076040", Offset = "0x2074A40", VA = "0x182076040", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionIsFTUE other)
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

		[Cpp2IlInjected.Token(Token = "0x60058DE")]
		[Cpp2IlInjected.Address(RVA = "0x2076090", Offset = "0x2074A90", VA = "0x182076090", Slot = "9")]
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

		[Cpp2IlInjected.Token(Token = "0x60058DF")]
		[Cpp2IlInjected.Address(RVA = "0x2075F20", Offset = "0x2074920", VA = "0x182075F20", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x60058E0")]
		[Cpp2IlInjected.Address(RVA = "0x2076110", Offset = "0x2074B10", VA = "0x182076110", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x60058E1")]
		[Cpp2IlInjected.Address(RVA = "0x2075D00", Offset = "0x2074700", VA = "0x182075D00", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058E2")]
		[Cpp2IlInjected.Address(RVA = "0x2076250", Offset = "0x2074C50", VA = "0x182076250")]
		static ConditionIsFTUE()
		{
			Func<ConditionIsFTUE> func = default(Func<ConditionIsFTUE>);
			_parser = (MessageParser<ConditionIsFTUE>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058E3")]
		[Cpp2IlInjected.Address(RVA = "0x2075DE0", Offset = "0x20747E0", VA = "0x182075DE0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0019
			IProfileWorld section = worldProfile.Section;
			bool inversed = inversed_;
			return Operations.EvaluateInverse(section == null, inversed);
		}
	}
}
