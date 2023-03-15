using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000823")]
	public sealed class ConditionRealmUnlocked : ICondition, IMessage<ConditionRealmUnlocked>, IMessage, IEquatable<ConditionRealmUnlocked>, IDeepCloneable<ConditionRealmUnlocked>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002877")]
		private static readonly MessageParser<ConditionRealmUnlocked> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002878")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002879")]
		public const int UniverseFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400287A")]
		private int universe_;

		[Cpp2IlInjected.Token(Token = "0x400287B")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400287C")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001709")]
		private Item UniverseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005B10")]
			[Cpp2IlInjected.Address(RVA = "0x24C9070", Offset = "0x24C7A70", VA = "0x1824C9070")]
			get
			{
				long num = Convert.ToInt64((uint)universe_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170A")]
		private string RealmName
		{
			[Cpp2IlInjected.Token(Token = "0x6005B12")]
			[Cpp2IlInjected.Address(RVA = "0x24C8F10", Offset = "0x24C7910", VA = "0x1824C8F10")]
			get
			{
				//Discarded unreachable code: IL_0012
				//IL_0029: Expected O, but got I8
				long num = Convert.ToInt64((uint)universe_);
				return "Any Realm are";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170B")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005B13")]
			[Cpp2IlInjected.Address(RVA = "0x24C8CE0", Offset = "0x24C76E0", VA = "0x1824C8CE0", Slot = "5")]
			get
			{
				//IL_0023: Expected O, but got I8
				long num = Convert.ToInt64((uint)universe_);
				long num2 = Convert.ToInt64((uint)universe_);
				string text = $"Realm {num2}";
				if (!inversed_)
				{
				}
				return text + " " + "" + "unlocked";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170C")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005B14")]
			[Cpp2IlInjected.Address(RVA = "0x24C8EA0", Offset = "0x24C78A0", VA = "0x1824C8EA0", Slot = "6")]
			get
			{
				return ConditionListener.Realm;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170D")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionRealmUnlocked> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005B16")]
			[Cpp2IlInjected.Address(RVA = "0x24C8EB0", Offset = "0x24C78B0", VA = "0x1824C8EB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B17")]
			[Cpp2IlInjected.Address(RVA = "0x24C8C10", Offset = "0x24C7610", VA = "0x1824C8C10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B18")]
			[Cpp2IlInjected.Address(RVA = "0x24C90D0", Offset = "0x24C7AD0", VA = "0x1824C90D0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001710")]
		[DebuggerNonUserCode]
		public int Universe
		{
			[Cpp2IlInjected.Token(Token = "0x6005B1C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return universe_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B1D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				universe_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001711")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005B1E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B1F")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B11")]
		[Cpp2IlInjected.Address(RVA = "0x24C8760", Offset = "0x24C7160", VA = "0x1824C8760")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			int num = universe_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				IProfileWorld section = worldProfile.Section;
			}
			IProfileWorld section2 = worldProfile.Section;
			int num2 = universe_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B15")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B19")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionRealmUnlocked()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1A")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionRealmUnlocked(ConditionRealmUnlocked other)
		{
			int num = (universe_ = other.universe_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1B")]
		[Cpp2IlInjected.Address(RVA = "0x24C84B0", Offset = "0x24C6EB0", VA = "0x1824C84B0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionRealmUnlocked Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionRealmUnlocked conditionRealmUnlocked = new ConditionRealmUnlocked();
			int num = (conditionRealmUnlocked.universe_ = universe_);
			bool flag = (conditionRealmUnlocked.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionRealmUnlocked._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionRealmUnlocked;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B20")]
		[Cpp2IlInjected.Address(RVA = "0x24C86D0", Offset = "0x24C70D0", VA = "0x1824C86D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)universe_ == (IntPtr)typeof(ConditionRealmUnlocked).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionRealmUnlocked).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B21")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionRealmUnlocked other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.universe_;
				if (universe_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005B22")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (universe_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005B23")]
		[Cpp2IlInjected.Address(RVA = "0x24C8AA0", Offset = "0x24C74A0", VA = "0x1824C8AA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B24")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (universe_ != 0)
			{
				int value = universe_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B25")]
		[Cpp2IlInjected.Address(RVA = "0x24C8420", Offset = "0x24C6E20", VA = "0x1824C8420", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = universe_;
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

		[Cpp2IlInjected.Token(Token = "0x6005B26")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionRealmUnlocked other)
		{
			if (other != null)
			{
				int num = other.universe_;
				if (num != 0)
				{
					universe_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005B27")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (universe_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B28")]
		[Cpp2IlInjected.Address(RVA = "0x24C88E0", Offset = "0x24C72E0", VA = "0x1824C88E0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = universe_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B29")]
		[Cpp2IlInjected.Address(RVA = "0x24C89D0", Offset = "0x24C73D0", VA = "0x1824C89D0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				universe_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2A")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				universe_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2B")]
		[Cpp2IlInjected.Address(RVA = "0x24C8B00", Offset = "0x24C7500", VA = "0x1824C8B00")]
		static ConditionRealmUnlocked()
		{
			Func<ConditionRealmUnlocked> func = default(Func<ConditionRealmUnlocked>);
			_parser = (MessageParser<ConditionRealmUnlocked>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2C")]
		[Cpp2IlInjected.Address(RVA = "0x24C8540", Offset = "0x24C6F40", VA = "0x1824C8540", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			int num = universe_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				IProfileWorld section = worldProfile.Section;
			}
			IProfileWorld section2 = worldProfile.Section;
			int num2 = universe_;
			bool result = default(bool);
			return result;
		}
	}
}
