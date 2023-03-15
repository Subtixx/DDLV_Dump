using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200049E")]
	public sealed class CustomStepDesignChallenge : IMessage<CustomStepDesignChallenge>, IMessage, IEquatable<CustomStepDesignChallenge>, IDeepCloneable<CustomStepDesignChallenge>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40018B9")]
		private static readonly MessageParser<CustomStepDesignChallenge> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40018BA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40018BB")]
		public const int ChallengeTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018BC")]
		private ChallengeType challengeType_;

		[Cpp2IlInjected.Token(Token = "0x40018BD")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018BE")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000E75")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepDesignChallenge> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60038B8")]
			[Cpp2IlInjected.Address(RVA = "0x34DDF50", Offset = "0x34DC950", VA = "0x1834DDF50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E76")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038B9")]
			[Cpp2IlInjected.Address(RVA = "0x34DDE80", Offset = "0x34DC880", VA = "0x1834DDE80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E77")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038BA")]
			[Cpp2IlInjected.Address(RVA = "0x34DDFB0", Offset = "0x34DC9B0", VA = "0x1834DDFB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E78")]
		[DebuggerNonUserCode]
		public ChallengeType ChallengeType
		{
			[Cpp2IlInjected.Token(Token = "0x60038BE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return challengeType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60038BF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				challengeType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E79")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60038C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60038C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038BB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepDesignChallenge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60038BC")]
		[Cpp2IlInjected.Address(RVA = "0x34DDE10", Offset = "0x34DC810", VA = "0x1834DDE10")]
		[DebuggerNonUserCode]
		public CustomStepDesignChallenge(CustomStepDesignChallenge other)
		{
			//IL_002f: Expected O, but got I4
			ChallengeType challengeType = (challengeType_ = other.challengeType_);
			StepAmount stepAmount = other.targetAmount_;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			int num = 0;
			targetAmount_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038BD")]
		[Cpp2IlInjected.Address(RVA = "0x34DD7E0", Offset = "0x34DC1E0", VA = "0x1834DD7E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepDesignChallenge Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			CustomStepDesignChallenge customStepDesignChallenge = new CustomStepDesignChallenge();
			ChallengeType challengeType = (customStepDesignChallenge.challengeType_ = challengeType_);
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			int num = 0;
			customStepDesignChallenge.targetAmount_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (customStepDesignChallenge._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepDesignChallenge;
		}

		[Cpp2IlInjected.Token(Token = "0x60038C2")]
		[Cpp2IlInjected.Address(RVA = "0x34DD880", Offset = "0x34DC280", VA = "0x1834DD880", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)challengeType_ == (IntPtr)typeof(CustomStepDesignChallenge).TypeHandle && object.Equals(targetAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038C3")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepDesignChallenge other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ChallengeType challengeType = other.challengeType_;
				if (challengeType_ == challengeType)
				{
					StepAmount objB = other.targetAmount_;
					if (object.Equals(targetAmount_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038C4")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (challengeType_ != 0)
				{
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int hashCode = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60038C5")]
		[Cpp2IlInjected.Address(RVA = "0x34DDCA0", Offset = "0x34DC6A0", VA = "0x1834DDCA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60038C6")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0035
			if (challengeType_ != 0)
			{
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value = targetAmount_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60038C7")]
		[Cpp2IlInjected.Address(RVA = "0x34DD710", Offset = "0x34DC110", VA = "0x1834DD710", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ChallengeType challengeType = challengeType_;
				num = 0;
				if (challengeType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)challengeType);
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60038C8")]
		[Cpp2IlInjected.Address(RVA = "0x34DDA00", Offset = "0x34DC400", VA = "0x1834DDA00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepDesignChallenge other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			ChallengeType challengeType = other.challengeType_;
			if (challengeType != 0)
			{
				challengeType_ = challengeType;
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other2 = other.targetAmount_;
				stepAmount2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60038C9")]
		[Cpp2IlInjected.Address(RVA = "0x34DDAE0", Offset = "0x34DC4E0", VA = "0x1834DDAE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (int)(challengeType_ = (ChallengeType)input.ReadInt32());
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					builder = targetAmount_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60038CA")]
		[Cpp2IlInjected.Address(RVA = "0x34DD930", Offset = "0x34DC330", VA = "0x1834DD930", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ChallengeType challengeType = challengeType_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = targetAmount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038CB")]
		[Cpp2IlInjected.Address(RVA = "0x34DDBD0", Offset = "0x34DC5D0", VA = "0x1834DDBD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				challengeType_ = (ChallengeType)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				targetAmount_ = (StepAmount)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038CC")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				challengeType_ = ChallengeType.Any;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038CD")]
		[Cpp2IlInjected.Address(RVA = "0x34DDD00", Offset = "0x34DC700", VA = "0x1834DDD00")]
		static CustomStepDesignChallenge()
		{
			Func<CustomStepDesignChallenge> func = default(Func<CustomStepDesignChallenge>);
			_parser = (MessageParser<CustomStepDesignChallenge>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
