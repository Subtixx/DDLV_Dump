using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007D1")]
	public sealed class ConditionCommon : ICondition, IReplaceCondition, IDataValidation, IMessage<ConditionCommon>, IMessage, IEquatable<ConditionCommon>, IDeepCloneable<ConditionCommon>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002750")]
		private static readonly MessageParser<ConditionCommon> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002751")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002752")]
		public const int ConditionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002753")]
		private int condition_;

		[Cpp2IlInjected.Token(Token = "0x4002754")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002755")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170015CF")]
		ICondition IReplaceCondition.ReplaceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x600560A")]
			[Cpp2IlInjected.Address(RVA = "0x3215B80", Offset = "0x3214580", VA = "0x183215B80", Slot = "8")]
			get
			{
				return CommonCondition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D0")]
		private Item ConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600560B")]
			[Cpp2IlInjected.Address(RVA = "0x3216150", Offset = "0x3214B50", VA = "0x183216150")]
			get
			{
				long num = Convert.ToInt64((uint)condition_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D1")]
		private ICondition CommonCondition
		{
			[Cpp2IlInjected.Token(Token = "0x600560C")]
			[Cpp2IlInjected.Address(RVA = "0x3216020", Offset = "0x3214A20", VA = "0x183216020")]
			get
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)condition_);
				ConditionItemData conditionItemData = default(ConditionItemData);
				if (conditionItemData != null)
				{
					ConditionsList conditions_ = conditionItemData.conditions_;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D2")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600560E")]
			[Cpp2IlInjected.Address(RVA = "0x3216280", Offset = "0x3214C80", VA = "0x183216280", Slot = "5")]
			get
			{
				ICondition commonCondition = CommonCondition;
				if (commonCondition == null || commonCondition == null)
				{
				}
				return "(none)";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D3")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600560F")]
			[Cpp2IlInjected.Address(RVA = "0x32162F0", Offset = "0x3214CF0", VA = "0x1832162F0", Slot = "6")]
			get
			{
				ICondition commonCondition;
				do
				{
					commonCondition = CommonCondition;
				}
				while (commonCondition == null);
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				string info = commonCondition.Info;
				string info2 = commonCondition.Info;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D4")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCommon> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005612")]
			[Cpp2IlInjected.Address(RVA = "0x32163C0", Offset = "0x3214DC0", VA = "0x1832163C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005613")]
			[Cpp2IlInjected.Address(RVA = "0x32161B0", Offset = "0x3214BB0", VA = "0x1832161B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005614")]
			[Cpp2IlInjected.Address(RVA = "0x3216420", Offset = "0x3214E20", VA = "0x183216420", Slot = "14")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D7")]
		[DebuggerNonUserCode]
		public int Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6005618")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return condition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005619")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				condition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D8")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x600561A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600561B")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600560D")]
		[Cpp2IlInjected.Address(RVA = "0x3215A80", Offset = "0x3214480", VA = "0x183215A80")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0026
			if (CommonCondition == null)
			{
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool inversed = inversed_;
			return Operations.EvaluateInverse((byte)num != 0, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005610")]
		[Cpp2IlInjected.Address(RVA = "0x3215D10", Offset = "0x3214710", VA = "0x183215D10", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			ICondition commonCondition;
			do
			{
				commonCondition = CommonCondition;
			}
			while (commonCondition == null);
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string info = commonCondition.Info;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005611")]
		[Cpp2IlInjected.Address(RVA = "0x32159B0", Offset = "0x32143B0", VA = "0x1832159B0", Slot = "9")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0039
			//IL_0024: Expected O, but got I4
			if (condition_ != 0)
			{
				if (CommonCondition == null)
				{
					int num = condition_;
					string error = $"Invalid common conditions (id={num})";
					context.AddError(error);
				}
			}
			else
			{
				context.AddError("Please select a commun condition");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005615")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCommon()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005616")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionCommon(ConditionCommon other)
		{
			int num = (condition_ = other.condition_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005617")]
		[Cpp2IlInjected.Address(RVA = "0x3215920", Offset = "0x3214320", VA = "0x183215920", Slot = "16")]
		[DebuggerNonUserCode]
		public ConditionCommon Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionCommon conditionCommon = new ConditionCommon();
			int num = (conditionCommon.condition_ = condition_);
			bool flag = (conditionCommon.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionCommon._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCommon;
		}

		[Cpp2IlInjected.Token(Token = "0x600561C")]
		[Cpp2IlInjected.Address(RVA = "0x3215B90", Offset = "0x3214590", VA = "0x183215B90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)condition_ == (IntPtr)typeof(ConditionCommon).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionCommon).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600561D")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "15")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCommon other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.condition_;
				if (condition_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x600561E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (condition_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x600561F")]
		[Cpp2IlInjected.Address(RVA = "0x3215EB0", Offset = "0x32148B0", VA = "0x183215EB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005620")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "12")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (condition_ != 0)
			{
				int value = condition_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005621")]
		[Cpp2IlInjected.Address(RVA = "0x3215890", Offset = "0x3214290", VA = "0x183215890", Slot = "13")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = condition_;
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

		[Cpp2IlInjected.Token(Token = "0x6005622")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCommon other)
		{
			if (other != null)
			{
				int num = other.condition_;
				if (num != 0)
				{
					condition_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005623")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (condition_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005624")]
		[Cpp2IlInjected.Address(RVA = "0x3215C20", Offset = "0x3214620", VA = "0x183215C20", Slot = "17")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = condition_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005625")]
		[Cpp2IlInjected.Address(RVA = "0x3215DE0", Offset = "0x32147E0", VA = "0x183215DE0", Slot = "18")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				condition_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005626")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "19")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				condition_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005627")]
		[Cpp2IlInjected.Address(RVA = "0x3215F10", Offset = "0x3214910", VA = "0x183215F10")]
		static ConditionCommon()
		{
			Func<ConditionCommon> func = default(Func<ConditionCommon>);
			_parser = (MessageParser<ConditionCommon>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005628")]
		[Cpp2IlInjected.Address(RVA = "0x3215A80", Offset = "0x3214480", VA = "0x183215A80", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0026
			if (CommonCondition == null)
			{
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool inversed = inversed_;
			return Operations.EvaluateInverse((byte)num != 0, inversed);
		}
	}
}
