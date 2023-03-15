using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007D8")]
	public sealed class ConditionAreaUnlocked : ICondition, IMessage<ConditionAreaUnlocked>, IMessage, IEquatable<ConditionAreaUnlocked>, IDeepCloneable<ConditionAreaUnlocked>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400275D")]
		private static readonly MessageParser<ConditionAreaUnlocked> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400275E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400275F")]
		public const int VillageAreaFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002760")]
		private VillageAreaType villageArea_;

		[Cpp2IlInjected.Token(Token = "0x4002761")]
		public const int InversedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002762")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170015E3")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005662")]
			[Cpp2IlInjected.Address(RVA = "0x3212C60", Offset = "0x3211660", VA = "0x183212C60", Slot = "5")]
			get
			{
				//IL_0020: Expected O, but got I4
				VillageAreaType villageAreaType = villageArea_;
				if (!inversed_)
				{
				}
				return string.Format("VillageArea {0} {1}unlocked", villageAreaType, "NOT ");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E4")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005663")]
			[Cpp2IlInjected.Address(RVA = "0x2239EE0", Offset = "0x22388E0", VA = "0x182239EE0", Slot = "6")]
			get
			{
				return ConditionListener.Area;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E5")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionAreaUnlocked> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005665")]
			[Cpp2IlInjected.Address(RVA = "0x3212CF0", Offset = "0x32116F0", VA = "0x183212CF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005666")]
			[Cpp2IlInjected.Address(RVA = "0x3212B90", Offset = "0x3211590", VA = "0x183212B90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005667")]
			[Cpp2IlInjected.Address(RVA = "0x3212D50", Offset = "0x3211750", VA = "0x183212D50", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E8")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x600566B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return villageArea_;
			}
			[Cpp2IlInjected.Token(Token = "0x600566C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				villageArea_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E9")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x600566D")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600566E")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005661")]
		[Cpp2IlInjected.Address(RVA = "0x3212630", Offset = "0x3211030", VA = "0x183212630")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			IProfileWorld section = worldProfile.Section;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005664")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005668")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionAreaUnlocked()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005669")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionAreaUnlocked(ConditionAreaUnlocked other)
		{
			VillageAreaType villageAreaType = (villageArea_ = other.villageArea_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600566A")]
		[Cpp2IlInjected.Address(RVA = "0x32125A0", Offset = "0x3210FA0", VA = "0x1832125A0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionAreaUnlocked Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionAreaUnlocked conditionAreaUnlocked = new ConditionAreaUnlocked();
			VillageAreaType villageAreaType = (conditionAreaUnlocked.villageArea_ = villageArea_);
			bool flag = (conditionAreaUnlocked.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionAreaUnlocked._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionAreaUnlocked;
		}

		[Cpp2IlInjected.Token(Token = "0x600566F")]
		[Cpp2IlInjected.Address(RVA = "0x32126B0", Offset = "0x32110B0", VA = "0x1832126B0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)villageArea_ == (IntPtr)typeof(ConditionAreaUnlocked).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionAreaUnlocked).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005670")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionAreaUnlocked other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				VillageAreaType villageAreaType = other.villageArea_;
				if (villageArea_ == villageAreaType)
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005671")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (villageArea_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005672")]
		[Cpp2IlInjected.Address(RVA = "0x3212990", Offset = "0x3211390", VA = "0x183212990", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005673")]
		[Cpp2IlInjected.Address(RVA = "0x32129F0", Offset = "0x32113F0", VA = "0x1832129F0", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (villageArea_ != 0)
			{
			}
			if (inversed_)
			{
				bool value = inversed_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005674")]
		[Cpp2IlInjected.Address(RVA = "0x32124F0", Offset = "0x3210EF0", VA = "0x1832124F0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				VillageAreaType villageAreaType = villageArea_;
				num = 0;
				if (villageAreaType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005675")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionAreaUnlocked other)
		{
			if (other != null)
			{
				VillageAreaType villageAreaType = other.villageArea_;
				if (villageAreaType != 0)
				{
					villageArea_ = villageAreaType;
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

		[Cpp2IlInjected.Token(Token = "0x6005676")]
		[Cpp2IlInjected.Address(RVA = "0x3212830", Offset = "0x3211230", VA = "0x183212830", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 16)
				{
					int num2 = (int)(villageArea_ = (VillageAreaType)input.ReadInt32());
				}
				if (num == 24)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005677")]
		[Cpp2IlInjected.Address(RVA = "0x3212740", Offset = "0x3211140", VA = "0x183212740", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 2)
			{
				VillageAreaType villageAreaType = villageArea_;
			}
			if (fieldNumber == 3)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005678")]
		[Cpp2IlInjected.Address(RVA = "0x32128C0", Offset = "0x32112C0", VA = "0x1832128C0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 2)
			{
				object obj = default(object);
				villageArea_ = (VillageAreaType)obj;
				return;
			}
			while (fieldNumber != 3)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005679")]
		[Cpp2IlInjected.Address(RVA = "0x3212580", Offset = "0x3210F80", VA = "0x183212580", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 2:
				villageArea_ = VillageAreaType.Beach;
				break;
			case 3:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600567A")]
		[Cpp2IlInjected.Address(RVA = "0x3212A80", Offset = "0x3211480", VA = "0x183212A80")]
		static ConditionAreaUnlocked()
		{
			Func<ConditionAreaUnlocked> func = default(Func<ConditionAreaUnlocked>);
			_parser = (MessageParser<ConditionAreaUnlocked>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600567B")]
		[Cpp2IlInjected.Address(RVA = "0x3212630", Offset = "0x3211030", VA = "0x183212630", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			IProfileWorld section = worldProfile.Section;
			bool result = default(bool);
			return result;
		}
	}
}
