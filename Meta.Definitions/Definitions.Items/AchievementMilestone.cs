using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200059C")]
	public sealed class AchievementMilestone : IMessage<AchievementMilestone>, IMessage, IEquatable<AchievementMilestone>, IDeepCloneable<AchievementMilestone>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001E81")]
		private static readonly MessageParser<AchievementMilestone> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E82")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001E83")]
		public const int MilestoneFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E84")]
		private int milestone_;

		[Cpp2IlInjected.Token(Token = "0x4001E85")]
		public const int RewardItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001E86")]
		private int rewardItem_;

		[Cpp2IlInjected.Token(Token = "0x4001E87")]
		public const int RewardAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E88")]
		private int rewardAmount_;

		[Cpp2IlInjected.Token(Token = "0x1700120D")]
		[DebuggerNonUserCode]
		public static MessageParser<AchievementMilestone> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60045E7")]
			[Cpp2IlInjected.Address(RVA = "0x314C950", Offset = "0x314B350", VA = "0x18314C950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045E8")]
			[Cpp2IlInjected.Address(RVA = "0x314C880", Offset = "0x314B280", VA = "0x18314C880")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045E9")]
			[Cpp2IlInjected.Address(RVA = "0x314C9B0", Offset = "0x314B3B0", VA = "0x18314C9B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001210")]
		[DebuggerNonUserCode]
		public int Milestone
		{
			[Cpp2IlInjected.Token(Token = "0x60045ED")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return milestone_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045EE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				milestone_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001211")]
		[DebuggerNonUserCode]
		public int RewardItem
		{
			[Cpp2IlInjected.Token(Token = "0x60045EF")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return rewardItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045F0")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				rewardItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001212")]
		[DebuggerNonUserCode]
		public int RewardAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60045F1")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return rewardAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045F2")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				rewardAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045EA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AchievementMilestone()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60045EB")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public AchievementMilestone(AchievementMilestone other)
		{
			int num = (milestone_ = other.milestone_);
			int num2 = (rewardItem_ = other.rewardItem_);
			int num3 = (rewardAmount_ = other.rewardAmount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045EC")]
		[Cpp2IlInjected.Address(RVA = "0x314C400", Offset = "0x314AE00", VA = "0x18314C400", Slot = "10")]
		[DebuggerNonUserCode]
		public AchievementMilestone Clone()
		{
			//Discarded unreachable code: IL_0047
			AchievementMilestone achievementMilestone = new AchievementMilestone();
			int num = (achievementMilestone.milestone_ = milestone_);
			int num2 = (achievementMilestone.rewardItem_ = rewardItem_);
			int num3 = (achievementMilestone.rewardAmount_ = rewardAmount_);
			UnknownFieldSet unknownFieldSet = (achievementMilestone._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return achievementMilestone;
		}

		[Cpp2IlInjected.Token(Token = "0x60045F3")]
		[Cpp2IlInjected.Address(RVA = "0x314C490", Offset = "0x314AE90", VA = "0x18314C490", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)milestone_ == (IntPtr)typeof(AchievementMilestone).TypeHandle && (IntPtr)rewardItem_ == (IntPtr)typeof(AchievementMilestone).TypeHandle && (IntPtr)rewardAmount_ == (IntPtr)typeof(AchievementMilestone).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045F4")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AchievementMilestone other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.milestone_;
				if (milestone_ == num)
				{
					int num2 = other.rewardItem_;
					if (rewardItem_ == num2)
					{
						int num3 = other.rewardAmount_;
						if (rewardAmount_ == num3)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045F5")]
		[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (milestone_ != 0)
				{
				}
				if (rewardItem_ != 0)
				{
				}
				if (rewardAmount_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60045F6")]
		[Cpp2IlInjected.Address(RVA = "0x314C710", Offset = "0x314B110", VA = "0x18314C710", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60045F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (milestone_ != 0)
			{
				int value = milestone_;
				output.WriteInt32(value);
			}
			if (rewardItem_ != 0)
			{
				int value2 = rewardItem_;
				output.WriteInt32(value2);
			}
			if (rewardAmount_ != 0)
			{
				int value3 = rewardAmount_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60045F8")]
		[Cpp2IlInjected.Address(RVA = "0x314C300", Offset = "0x314AD00", VA = "0x18314C300", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = milestone_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = rewardItem_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = rewardAmount_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60045F9")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementMilestone other)
		{
			if (other != null)
			{
				int num = other.milestone_;
				if (num != 0)
				{
					milestone_ = num;
				}
				int num2 = other.rewardItem_;
				if (num2 != 0)
				{
					rewardItem_ = num2;
				}
				int num3 = other.rewardAmount_;
				if (num3 != 0)
				{
					rewardAmount_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045FA")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (milestone_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (rewardItem_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (rewardAmount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045FB")]
		[Cpp2IlInjected.Address(RVA = "0x314C530", Offset = "0x314AF30", VA = "0x18314C530", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = milestone_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045FC")]
		[Cpp2IlInjected.Address(RVA = "0x314C600", Offset = "0x314B000", VA = "0x18314C600", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					rewardAmount_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					rewardItem_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				milestone_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045FD")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				rewardAmount_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045FE")]
		[Cpp2IlInjected.Address(RVA = "0x314C770", Offset = "0x314B170", VA = "0x18314C770")]
		static AchievementMilestone()
		{
			Func<AchievementMilestone> func = default(Func<AchievementMilestone>);
			_parser = (MessageParser<AchievementMilestone>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
