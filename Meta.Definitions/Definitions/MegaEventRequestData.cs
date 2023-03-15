using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class MegaEventRequestData : IMessage<MegaEventRequestData>, IMessage, IEquatable<MegaEventRequestData>, IDeepCloneable<MegaEventRequestData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly MessageParser<MegaEventRequestData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public const int NodePosFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private MegaEventNodePos nodePos_;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public const int MissionIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int missionId_;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public const int RewardFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MissionReward reward_;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public const int RewardPresentsFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private MultiGenerator rewardPresents_;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		public static MessageParser<MegaEventRequestData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x30758D0", Offset = "0x30742D0", VA = "0x1830758D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x3075680", Offset = "0x3074080", VA = "0x183075680")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x3075930", Offset = "0x3074330", VA = "0x183075930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		[DebuggerNonUserCode]
		public MegaEventNodePos NodePos
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return nodePos_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				nodePos_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		[DebuggerNonUserCode]
		public int MissionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return missionId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				missionId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		[DebuggerNonUserCode]
		public MissionReward Reward
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return reward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				reward_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[DebuggerNonUserCode]
		public MultiGenerator RewardPresents
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return rewardPresents_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				rewardPresents_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x3075870", Offset = "0x3074270", VA = "0x183075870")]
			get
			{
				long num = Convert.ToInt64((uint)missionId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public MissionItemData MissionData
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x3075750", Offset = "0x3074150", VA = "0x183075750")]
			get
			{
				//Discarded unreachable code: IL_0014
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)missionId_);
				MissionItemData result = default(MissionItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MegaEventRequestData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x30755D0", Offset = "0x3073FD0", VA = "0x1830755D0")]
		[DebuggerNonUserCode]
		public MegaEventRequestData(MegaEventRequestData other)
		{
			//IL_003e: Expected O, but got I4
			MegaEventNodePos megaEventNodePos = (nodePos_ = other.nodePos_);
			int num = (missionId_ = other.missionId_);
			MissionReward missionReward = other.reward_;
			int num2 = 0;
			if (missionReward != null)
			{
				MissionReward missionReward2 = missionReward.Clone();
			}
			reward_ = (MissionReward)num2;
			MultiGenerator multiGenerator = other.rewardPresents_;
			MultiGenerator multiGenerator2 = default(MultiGenerator);
			if (multiGenerator != null)
			{
				multiGenerator2 = multiGenerator.Clone();
			}
			rewardPresents_ = multiGenerator2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3074B60", Offset = "0x3073560", VA = "0x183074B60", Slot = "10")]
		[DebuggerNonUserCode]
		public MegaEventRequestData Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_0040: Expected O, but got I4
			MegaEventRequestData megaEventRequestData = new MegaEventRequestData();
			MegaEventNodePos megaEventNodePos = (megaEventRequestData.nodePos_ = nodePos_);
			int num = (megaEventRequestData.missionId_ = missionId_);
			MissionReward missionReward = reward_;
			int num2 = 0;
			if (missionReward != null)
			{
				MissionReward missionReward2 = missionReward.Clone();
			}
			megaEventRequestData.reward_ = (MissionReward)num2;
			MultiGenerator multiGenerator = rewardPresents_;
			MultiGenerator multiGenerator2 = default(MultiGenerator);
			if (multiGenerator != null)
			{
				multiGenerator2 = multiGenerator.Clone();
			}
			megaEventRequestData.rewardPresents_ = multiGenerator2;
			UnknownFieldSet unknownFieldSet = (megaEventRequestData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return megaEventRequestData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3074C40", Offset = "0x3073640", VA = "0x183074C40", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)nodePos_ == (IntPtr)typeof(MegaEventRequestData).TypeHandle && (IntPtr)missionId_ == (IntPtr)typeof(MegaEventRequestData).TypeHandle && object.Equals(reward_, other) && object.Equals(rewardPresents_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3074D10", Offset = "0x3073710", VA = "0x183074D10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MegaEventRequestData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MegaEventNodePos megaEventNodePos = other.nodePos_;
				if (nodePos_ == megaEventNodePos)
				{
					int num = other.missionId_;
					if (missionId_ == num)
					{
						MissionReward objB = other.reward_;
						if (object.Equals(reward_, objB))
						{
							MultiGenerator objB2 = other.rewardPresents_;
							if (object.Equals(rewardPresents_, objB2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3074EA0", Offset = "0x30738A0", VA = "0x183074EA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (nodePos_ != 0)
				{
				}
				if (missionId_ != 0)
				{
				}
				MissionReward missionReward = reward_;
				if (missionReward != null)
				{
					int hashCode = missionReward.GetHashCode();
				}
				MultiGenerator multiGenerator = rewardPresents_;
				if (multiGenerator != null)
				{
					int hashCode2 = multiGenerator.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x3075380", Offset = "0x3073D80", VA = "0x183075380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x30753E0", Offset = "0x3073DE0", VA = "0x1830753E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0065
			if (nodePos_ != 0)
			{
			}
			if (missionId_ != 0)
			{
				int value = missionId_;
				output.WriteInt32(value);
			}
			if ((long)reward_ != 0)
			{
				MissionReward value2 = reward_;
				output.WriteMessage(value2);
			}
			if ((long)rewardPresents_ != 0)
			{
				MultiGenerator value3 = rewardPresents_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x30749E0", Offset = "0x30733E0", VA = "0x1830749E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				MegaEventNodePos megaEventNodePos = nodePos_;
				num = 0;
				if (megaEventNodePos != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)megaEventNodePos);
				}
				int num3 = missionId_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				MissionReward missionReward = reward_;
				if (missionReward != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(missionReward);
					num5++;
					num += num5;
				}
				MultiGenerator multiGenerator = rewardPresents_;
				if (multiGenerator != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(multiGenerator);
					num6++;
					num += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3074F60", Offset = "0x3073960", VA = "0x183074F60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MegaEventRequestData other)
		{
			//Discarded unreachable code: IL_00bf
			if (other == null)
			{
				return;
			}
			MegaEventNodePos megaEventNodePos = other.nodePos_;
			if (megaEventNodePos != 0)
			{
				nodePos_ = megaEventNodePos;
			}
			int num = other.missionId_;
			if (num != 0)
			{
				missionId_ = num;
			}
			if ((long)other.reward_ != 0)
			{
				MissionReward missionReward2 = default(MissionReward);
				if (reward_ == null)
				{
					MissionReward missionReward = (reward_ = new MissionReward());
					missionReward2 = reward_;
				}
				MissionReward other2 = other.reward_;
				missionReward2.MergeFrom(other2);
			}
			if ((long)other.rewardPresents_ != 0)
			{
				MultiGenerator multiGenerator2 = default(MultiGenerator);
				if (rewardPresents_ == null)
				{
					MultiGenerator multiGenerator = (rewardPresents_ = new MultiGenerator());
					multiGenerator2 = rewardPresents_;
				}
				MultiGenerator other3 = other.rewardPresents_;
				multiGenerator2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x30750A0", Offset = "0x3073AA0", VA = "0x1830750A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					MissionReward missionReward = reward_;
					if (missionReward == null)
					{
						MissionReward missionReward2 = (reward_ = new MissionReward());
					}
					input.ReadMessage(missionReward);
				}
				if (num != 34)
				{
					goto IL_0091;
				}
				MultiGenerator builder = default(MultiGenerator);
				if (rewardPresents_ == null)
				{
					MultiGenerator multiGenerator = (rewardPresents_ = new MultiGenerator());
					builder = rewardPresents_;
				}
				input.ReadMessage(builder);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(nodePos_ = (MegaEventNodePos)input.ReadInt32());
			}
			if (num2 == 16)
			{
				int num3 = (missionId_ = input.ReadInt32());
			}
			goto IL_0091;
			IL_0091:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3074DA0", Offset = "0x30737A0", VA = "0x183074DA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num == 1)
			{
				MultiGenerator multiGenerator = rewardPresents_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3075210", Offset = "0x3073C10", VA = "0x183075210", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003e
			//IL_0025: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			//IL_003d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							rewardPresents_ = (MultiGenerator)num2;
							return;
						}
						throw new InvalidCastException();
					}
					default:
						return;
					case 0:
						break;
					}
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj = default(object);
				missionId_ = (int)obj;
			}
			else
			{
				object obj2 = default(object);
				nodePos_ = (MegaEventNodePos)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3074B10", Offset = "0x3073510", VA = "0x183074B10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x30754C0", Offset = "0x3073EC0", VA = "0x1830754C0")]
		static MegaEventRequestData()
		{
			Func<MegaEventRequestData> func = default(Func<MegaEventRequestData>);
			_parser = (MessageParser<MegaEventRequestData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
