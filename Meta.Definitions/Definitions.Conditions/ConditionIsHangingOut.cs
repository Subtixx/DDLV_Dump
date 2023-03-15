using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000802")]
	public sealed class ConditionIsHangingOut : ICondition, IDataValidation, IMessage<ConditionIsHangingOut>, IMessage, IEquatable<ConditionIsHangingOut>, IDeepCloneable<ConditionIsHangingOut>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027ED")]
		private static readonly MessageParser<ConditionIsHangingOut> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027EF")]
		public const int InversedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027F0")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x40027F1")]
		public const int CharacterFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027F2")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x1700167D")]
		private Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60058E7")]
			[Cpp2IlInjected.Address(RVA = "0x2076E10", Offset = "0x2075810", VA = "0x182076E10")]
			get
			{
				long num = Convert.ToInt64((uint)character_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167E")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60058E8")]
			[Cpp2IlInjected.Address(RVA = "0x2076F40", Offset = "0x2075940", VA = "0x182076F40", Slot = "5")]
			get
			{
				if (!inversed_)
				{
				}
				return "HangingOut " + "NOT " + " in progress";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167F")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60058E9")]
			[Cpp2IlInjected.Address(RVA = "0x2076FC0", Offset = "0x20759C0", VA = "0x182076FC0", Slot = "6")]
			get
			{
				return ConditionListener.Hangout;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001680")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionIsHangingOut> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60058EE")]
			[Cpp2IlInjected.Address(RVA = "0x2076FD0", Offset = "0x20759D0", VA = "0x182076FD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001681")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60058EF")]
			[Cpp2IlInjected.Address(RVA = "0x2076E70", Offset = "0x2075870", VA = "0x182076E70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001682")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60058F0")]
			[Cpp2IlInjected.Address(RVA = "0x2077030", Offset = "0x2075A30", VA = "0x182077030", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001683")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x60058F4")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x60058F5")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001684")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x60058F6")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x60058F7")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058EA")]
		[Cpp2IlInjected.Address(RVA = "0x2076B20", Offset = "0x2075520", VA = "0x182076B20")]
		private bool IsHangingOutWithCharacter(in PlayerProfile playerProfile)
		{
			int num = character_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058EB")]
		[Cpp2IlInjected.Address(RVA = "0x20768E0", Offset = "0x20752E0", VA = "0x1820768E0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			int num = character_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60058EC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058ED")]
		[Cpp2IlInjected.Address(RVA = "0x2076870", Offset = "0x2075270", VA = "0x182076870", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (character_ == 0)
			{
				context.AddInvalidMemberError("Please select a character", "Character");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058F1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionIsHangingOut()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60058F2")]
		[Cpp2IlInjected.Address(RVA = "0x7187C0", Offset = "0x7171C0", VA = "0x1807187C0")]
		[DebuggerNonUserCode]
		public ConditionIsHangingOut(ConditionIsHangingOut other)
		{
			bool flag = (inversed_ = other.inversed_);
			int num = (character_ = other.character_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058F3")]
		[Cpp2IlInjected.Address(RVA = "0x20767E0", Offset = "0x20751E0", VA = "0x1820767E0", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionIsHangingOut Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionIsHangingOut conditionIsHangingOut = new ConditionIsHangingOut();
			bool flag = (conditionIsHangingOut.inversed_ = inversed_);
			int num = (conditionIsHangingOut.character_ = character_);
			UnknownFieldSet unknownFieldSet = (conditionIsHangingOut._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionIsHangingOut;
		}

		[Cpp2IlInjected.Token(Token = "0x60058F8")]
		[Cpp2IlInjected.Address(RVA = "0x20769A0", Offset = "0x20753A0", VA = "0x1820769A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionIsHangingOut).TypeHandle && (IntPtr)character_ == (IntPtr)typeof(ConditionIsHangingOut).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058F9")]
		[Cpp2IlInjected.Address(RVA = "0x718240", Offset = "0x716C40", VA = "0x180718240", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionIsHangingOut other)
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
					int num = other.character_;
					if (character_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058FA")]
		[Cpp2IlInjected.Address(RVA = "0x718370", Offset = "0x716D70", VA = "0x180718370", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (inversed_)
				{
				}
				if (character_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60058FB")]
		[Cpp2IlInjected.Address(RVA = "0x2076CA0", Offset = "0x20756A0", VA = "0x182076CA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60058FC")]
		[Cpp2IlInjected.Address(RVA = "0x718620", Offset = "0x717020", VA = "0x180718620", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (inversed_)
			{
				bool value = inversed_;
				output.WriteBool(value);
			}
			if (character_ != 0)
			{
				int value2 = character_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60058FD")]
		[Cpp2IlInjected.Address(RVA = "0x2076740", Offset = "0x2075140", VA = "0x182076740", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = character_;
				if (num != 0)
				{
					int num2 = CodedOutputStream.ComputeInt32Size(num);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x60058FE")]
		[Cpp2IlInjected.Address(RVA = "0x718490", Offset = "0x716E90", VA = "0x180718490", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionIsHangingOut other)
		{
			if (other != null)
			{
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				int num = other.character_;
				if (num != 0)
				{
					character_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058FF")]
		[Cpp2IlInjected.Address(RVA = "0x718400", Offset = "0x716E00", VA = "0x180718400", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				if (num == 16)
				{
					int num2 = (character_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005900")]
		[Cpp2IlInjected.Address(RVA = "0x2076A30", Offset = "0x2075430", VA = "0x182076A30", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = inversed_;
			}
			if (fieldNumber == 2)
			{
				int num = character_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005901")]
		[Cpp2IlInjected.Address(RVA = "0x2076BD0", Offset = "0x20755D0", VA = "0x182076BD0", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				inversed_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			character_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005902")]
		[Cpp2IlInjected.Address(RVA = "0x718100", Offset = "0x716B00", VA = "0x180718100", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				inversed_ = false;
				break;
			case 2:
				character_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005903")]
		[Cpp2IlInjected.Address(RVA = "0x2076D00", Offset = "0x2075700", VA = "0x182076D00")]
		static ConditionIsHangingOut()
		{
			Func<ConditionIsHangingOut> func = default(Func<ConditionIsHangingOut>);
			_parser = (MessageParser<ConditionIsHangingOut>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005904")]
		[Cpp2IlInjected.Address(RVA = "0x20768E0", Offset = "0x20752E0", VA = "0x1820768E0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			int num = character_;
			bool result = default(bool);
			return result;
		}
	}
}
