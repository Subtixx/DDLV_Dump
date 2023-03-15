using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200080C")]
	public sealed class ConditionMissionCompleted : ICondition, IDataValidation, IMessage<ConditionMissionCompleted>, IMessage, IEquatable<ConditionMissionCompleted>, IDeepCloneable<ConditionMissionCompleted>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002812")]
		private static readonly MessageParser<ConditionMissionCompleted> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002813")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002814")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002815")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x4002816")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002817")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170016A5")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600598B")]
			[Cpp2IlInjected.Address(RVA = "0x207CF90", Offset = "0x207B990", VA = "0x18207CF90")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A6")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600598D")]
			[Cpp2IlInjected.Address(RVA = "0x207CE70", Offset = "0x207B870", VA = "0x18207CE70", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003c
				long num = Convert.ToInt64((uint)mission_);
				string text = default(string);
				string text2 = text.Replace("Mission/MissionData/", "");
				if (!inversed_)
				{
				}
				return "Mission '" + text2 + "' " + "not completed";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A7")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600598E")]
			[Cpp2IlInjected.Address(RVA = "0x20765C0", Offset = "0x2074FC0", VA = "0x1820765C0", Slot = "6")]
			get
			{
				return ConditionListener.MissionCompleted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A8")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionCompleted> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005991")]
			[Cpp2IlInjected.Address(RVA = "0x207CFF0", Offset = "0x207B9F0", VA = "0x18207CFF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005992")]
			[Cpp2IlInjected.Address(RVA = "0x207CDA0", Offset = "0x207B7A0", VA = "0x18207CDA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005993")]
			[Cpp2IlInjected.Address(RVA = "0x207D050", Offset = "0x207BA50", VA = "0x18207D050", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AB")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005997")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005998")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AC")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005999")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600599A")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600598C")]
		[Cpp2IlInjected.Address(RVA = "0x207C910", Offset = "0x207B310", VA = "0x18207C910")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600598F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005990")]
		[Cpp2IlInjected.Address(RVA = "0x207C7B0", Offset = "0x207B1B0", VA = "0x18207C7B0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004b
			if (mission_ == 0)
			{
				context.AddInvalidMemberError("Please select a mission", "Mission");
			}
			MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
			if (parentOfType != null)
			{
				int iD = parentOfType.ID;
				int num = mission_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					context.AddInvalidMemberError("Please don't use current mission inside MissionCompleted condition", "Mission");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005994")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005995")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionMissionCompleted(ConditionMissionCompleted other)
		{
			int num = (mission_ = other.mission_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005996")]
		[Cpp2IlInjected.Address(RVA = "0x207C720", Offset = "0x207B120", VA = "0x18207C720", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionMissionCompleted Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionMissionCompleted conditionMissionCompleted = new ConditionMissionCompleted();
			int num = (conditionMissionCompleted.mission_ = mission_);
			bool flag = (conditionMissionCompleted.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionMissionCompleted._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x600599B")]
		[Cpp2IlInjected.Address(RVA = "0x207C9E0", Offset = "0x207B3E0", VA = "0x18207C9E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionCompleted).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionMissionCompleted).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600599C")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionCompleted other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.mission_;
				if (mission_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x600599D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (mission_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x600599E")]
		[Cpp2IlInjected.Address(RVA = "0x207CC30", Offset = "0x207B630", VA = "0x18207CC30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600599F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (mission_ != 0)
			{
				int value = mission_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A0")]
		[Cpp2IlInjected.Address(RVA = "0x207C690", Offset = "0x207B090", VA = "0x18207C690", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = mission_;
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

		[Cpp2IlInjected.Token(Token = "0x60059A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionCompleted other)
		{
			if (other != null)
			{
				int num = other.mission_;
				if (num != 0)
				{
					mission_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x60059A2")]
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
					int num2 = (mission_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059A3")]
		[Cpp2IlInjected.Address(RVA = "0x207CA70", Offset = "0x207B470", VA = "0x18207CA70", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = mission_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059A4")]
		[Cpp2IlInjected.Address(RVA = "0x207CB60", Offset = "0x207B560", VA = "0x18207CB60", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				mission_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60059A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				mission_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059A6")]
		[Cpp2IlInjected.Address(RVA = "0x207CC90", Offset = "0x207B690", VA = "0x18207CC90")]
		static ConditionMissionCompleted()
		{
			Func<ConditionMissionCompleted> func = default(Func<ConditionMissionCompleted>);
			_parser = (MessageParser<ConditionMissionCompleted>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059A7")]
		[Cpp2IlInjected.Address(RVA = "0x207C910", Offset = "0x207B310", VA = "0x18207C910", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			bool result = default(bool);
			return result;
		}
	}
}
