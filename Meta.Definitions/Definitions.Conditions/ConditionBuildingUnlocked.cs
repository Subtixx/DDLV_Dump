using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007DA")]
	public sealed class ConditionBuildingUnlocked : ICondition, IMessage<ConditionBuildingUnlocked>, IMessage, IEquatable<ConditionBuildingUnlocked>, IDeepCloneable<ConditionBuildingUnlocked>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002764")]
		private static readonly MessageParser<ConditionBuildingUnlocked> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002765")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002766")]
		public const int BuildingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002767")]
		private int building_;

		[Cpp2IlInjected.Token(Token = "0x4002768")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002769")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170015EA")]
		private Item BuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x600567F")]
			[Cpp2IlInjected.Address(RVA = "0x3213410", Offset = "0x3211E10", VA = "0x183213410")]
			get
			{
				long num = Convert.ToInt64((uint)building_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015EB")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005681")]
			[Cpp2IlInjected.Address(RVA = "0x3213540", Offset = "0x3211F40", VA = "0x183213540", Slot = "5")]
			get
			{
				//IL_0025: Expected O, but got I8
				long num = Convert.ToInt64((uint)building_);
				if (!inversed_)
				{
				}
				return string.Format("Building '{0}' is {1}unlocked", num, "NOT ");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015EC")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005682")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015ED")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionBuildingUnlocked> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005684")]
			[Cpp2IlInjected.Address(RVA = "0x3213620", Offset = "0x3212020", VA = "0x183213620")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015EE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005685")]
			[Cpp2IlInjected.Address(RVA = "0x3213470", Offset = "0x3211E70", VA = "0x183213470")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015EF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005686")]
			[Cpp2IlInjected.Address(RVA = "0x3213680", Offset = "0x3212080", VA = "0x183213680", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F0")]
		[DebuggerNonUserCode]
		public int Building
		{
			[Cpp2IlInjected.Token(Token = "0x600568A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return building_;
			}
			[Cpp2IlInjected.Token(Token = "0x600568B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				building_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F1")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x600568C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600568D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005680")]
		[Cpp2IlInjected.Address(RVA = "0x3212F80", Offset = "0x3211980", VA = "0x183212F80")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = building_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005683")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005687")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionBuildingUnlocked()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005688")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionBuildingUnlocked(ConditionBuildingUnlocked other)
		{
			int num = (building_ = other.building_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005689")]
		[Cpp2IlInjected.Address(RVA = "0x3212EF0", Offset = "0x32118F0", VA = "0x183212EF0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionBuildingUnlocked Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionBuildingUnlocked conditionBuildingUnlocked = new ConditionBuildingUnlocked();
			int num = (conditionBuildingUnlocked.building_ = building_);
			bool flag = (conditionBuildingUnlocked.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionBuildingUnlocked._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionBuildingUnlocked;
		}

		[Cpp2IlInjected.Token(Token = "0x600568E")]
		[Cpp2IlInjected.Address(RVA = "0x3213050", Offset = "0x3211A50", VA = "0x183213050", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)building_ == (IntPtr)typeof(ConditionBuildingUnlocked).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionBuildingUnlocked).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600568F")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionBuildingUnlocked other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.building_;
				if (building_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005690")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (building_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005691")]
		[Cpp2IlInjected.Address(RVA = "0x32132A0", Offset = "0x3211CA0", VA = "0x1832132A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005692")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (building_ != 0)
			{
				int value = building_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005693")]
		[Cpp2IlInjected.Address(RVA = "0x3212E60", Offset = "0x3211860", VA = "0x183212E60", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = building_;
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

		[Cpp2IlInjected.Token(Token = "0x6005694")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionBuildingUnlocked other)
		{
			if (other != null)
			{
				int num = other.building_;
				if (num != 0)
				{
					building_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005695")]
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
					int num2 = (building_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005696")]
		[Cpp2IlInjected.Address(RVA = "0x32130E0", Offset = "0x3211AE0", VA = "0x1832130E0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = building_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005697")]
		[Cpp2IlInjected.Address(RVA = "0x32131D0", Offset = "0x3211BD0", VA = "0x1832131D0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				building_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005698")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				building_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005699")]
		[Cpp2IlInjected.Address(RVA = "0x3213300", Offset = "0x3211D00", VA = "0x183213300")]
		static ConditionBuildingUnlocked()
		{
			Func<ConditionBuildingUnlocked> func = default(Func<ConditionBuildingUnlocked>);
			_parser = (MessageParser<ConditionBuildingUnlocked>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600569A")]
		[Cpp2IlInjected.Address(RVA = "0x3212F80", Offset = "0x3211980", VA = "0x183212F80", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = building_;
			bool result = default(bool);
			return result;
		}
	}
}
