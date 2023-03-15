using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008BE")]
	public sealed class ItemCollectMinigameData : IMessage<ItemCollectMinigameData>, IMessage, IEquatable<ItemCollectMinigameData>, IDeepCloneable<ItemCollectMinigameData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400232F")]
		private static readonly MessageParser<ItemCollectMinigameData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002330")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002331")]
		public const int DurationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002332")]
		private Duration duration_;

		[Cpp2IlInjected.Token(Token = "0x4002333")]
		public const int NumberOfItemsToCollectFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002334")]
		private int numberOfItemsToCollect_;

		[Cpp2IlInjected.Token(Token = "0x4002335")]
		public const int FixedRewardPerItemFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002336")]
		private bool fixedRewardPerItem_;

		[Cpp2IlInjected.Token(Token = "0x4002337")]
		public const int RewardsPerItemFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002338")]
		private MultiItemInstance rewardsPerItem_;

		[Cpp2IlInjected.Token(Token = "0x4002339")]
		public const int VictoryRewardLootPresentFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400233A")]
		private int victoryRewardLootPresent_;

		[Cpp2IlInjected.Token(Token = "0x400233B")]
		public const int GracePeriodFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400233C")]
		private Duration gracePeriod_;

		[Cpp2IlInjected.Token(Token = "0x400233D")]
		public const int AnticipationVFXPrefabAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400233E")]
		private string anticipationVFXPrefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400233F")]
		public const int AnticipationDurationFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002340")]
		private Duration anticipationDuration_;

		[Cpp2IlInjected.Token(Token = "0x17000C87")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemCollectMinigameData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004A9C")]
			[Cpp2IlInjected.Address(RVA = "0x1711760", Offset = "0x1710160", VA = "0x181711760")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C88")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A9D")]
			[Cpp2IlInjected.Address(RVA = "0x1711690", Offset = "0x1710090", VA = "0x181711690")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C89")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A9E")]
			[Cpp2IlInjected.Address(RVA = "0x17117C0", Offset = "0x17101C0", VA = "0x1817117C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8A")]
		[DebuggerNonUserCode]
		public Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6004AA2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return duration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AA3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				duration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8B")]
		[DebuggerNonUserCode]
		public int NumberOfItemsToCollect
		{
			[Cpp2IlInjected.Token(Token = "0x6004AA4")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return numberOfItemsToCollect_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AA5")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				numberOfItemsToCollect_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8C")]
		[DebuggerNonUserCode]
		public bool FixedRewardPerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004AA6")]
			[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
			get
			{
				return fixedRewardPerItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AA7")]
			[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
			set
			{
				fixedRewardPerItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8D")]
		[DebuggerNonUserCode]
		public MultiItemInstance RewardsPerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004AA8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return rewardsPerItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AA9")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				rewardsPerItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8E")]
		[DebuggerNonUserCode]
		public int VictoryRewardLootPresent
		{
			[Cpp2IlInjected.Token(Token = "0x6004AAA")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return victoryRewardLootPresent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AAB")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				victoryRewardLootPresent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8F")]
		[DebuggerNonUserCode]
		public Duration GracePeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6004AAC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return gracePeriod_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AAD")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				gracePeriod_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C90")]
		[DebuggerNonUserCode]
		public string AnticipationVFXPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004AAE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return anticipationVFXPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AAF")]
			[Cpp2IlInjected.Address(RVA = "0x17118D0", Offset = "0x17102D0", VA = "0x1817118D0")]
			set
			{
				string text = (anticipationVFXPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C91")]
		[DebuggerNonUserCode]
		public Duration AnticipationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return anticipationDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AB1")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				anticipationDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A9F")]
		[Cpp2IlInjected.Address(RVA = "0x17114F0", Offset = "0x170FEF0", VA = "0x1817114F0")]
		[DebuggerNonUserCode]
		public ItemCollectMinigameData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AA0")]
		[Cpp2IlInjected.Address(RVA = "0x1711540", Offset = "0x170FF40", VA = "0x181711540")]
		[DebuggerNonUserCode]
		public ItemCollectMinigameData(ItemCollectMinigameData other)
		{
			//IL_002c: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			Duration duration = other.duration_;
			int num = 0;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			duration_ = (Duration)num;
			int num2 = (numberOfItemsToCollect_ = other.numberOfItemsToCollect_);
			bool flag = (fixedRewardPerItem_ = other.fixedRewardPerItem_);
			MultiItemInstance multiItemInstance = other.rewardsPerItem_;
			if (multiItemInstance != null)
			{
				MultiItemInstance multiItemInstance2 = multiItemInstance.Clone();
			}
			rewardsPerItem_ = (MultiItemInstance)num;
			int num3 = (victoryRewardLootPresent_ = other.victoryRewardLootPresent_);
			Duration duration3 = other.gracePeriod_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			gracePeriod_ = (Duration)num;
			string text = (anticipationVFXPrefabAddress_ = other.anticipationVFXPrefabAddress_);
			Duration duration5 = other.anticipationDuration_;
			Duration duration6 = default(Duration);
			if (duration5 != null)
			{
				duration6 = duration5.Clone();
			}
			anticipationDuration_ = duration6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004AA1")]
		[Cpp2IlInjected.Address(RVA = "0x17104C0", Offset = "0x170EEC0", VA = "0x1817104C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemCollectMinigameData Clone()
		{
			//Discarded unreachable code: IL_00db
			//IL_002c: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			ItemCollectMinigameData itemCollectMinigameData = new ItemCollectMinigameData();
			itemCollectMinigameData.anticipationVFXPrefabAddress_ = "";
			Duration duration = duration_;
			int num = 0;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			itemCollectMinigameData.duration_ = (Duration)num;
			int num2 = (itemCollectMinigameData.numberOfItemsToCollect_ = numberOfItemsToCollect_);
			bool flag = (itemCollectMinigameData.fixedRewardPerItem_ = fixedRewardPerItem_);
			MultiItemInstance multiItemInstance = rewardsPerItem_;
			if (multiItemInstance != null)
			{
				MultiItemInstance multiItemInstance2 = multiItemInstance.Clone();
			}
			itemCollectMinigameData.rewardsPerItem_ = (MultiItemInstance)num;
			int num3 = (itemCollectMinigameData.victoryRewardLootPresent_ = victoryRewardLootPresent_);
			Duration duration3 = gracePeriod_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			itemCollectMinigameData.gracePeriod_ = (Duration)num;
			string text = (itemCollectMinigameData.anticipationVFXPrefabAddress_ = anticipationVFXPrefabAddress_);
			Duration duration5 = anticipationDuration_;
			Duration duration6 = default(Duration);
			if (duration5 != null)
			{
				duration6 = duration5.Clone();
			}
			itemCollectMinigameData.anticipationDuration_ = duration6;
			UnknownFieldSet unknownFieldSet = (itemCollectMinigameData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemCollectMinigameData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB2")]
		[Cpp2IlInjected.Address(RVA = "0x1710640", Offset = "0x170F040", VA = "0x181710640", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(duration_, other);
				if (flag && numberOfItemsToCollect_ == (flag ? 1 : 0) && fixedRewardPerItem_ == flag)
				{
					bool flag2 = object.Equals(rewardsPerItem_, other);
					if (flag2 && victoryRewardLootPresent_ == (flag2 ? 1 : 0) && object.Equals(gracePeriod_, other))
					{
						string text = anticipationVFXPrefabAddress_;
						bool flag3 = default(bool);
						if (!flag3 && object.Equals(anticipationDuration_, other))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB3")]
		[Cpp2IlInjected.Address(RVA = "0x1710770", Offset = "0x170F170", VA = "0x181710770", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemCollectMinigameData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Duration objB = other.duration_;
				if (object.Equals(duration_, objB))
				{
					int num = other.numberOfItemsToCollect_;
					if (numberOfItemsToCollect_ == num)
					{
						bool flag = other.fixedRewardPerItem_;
						if (fixedRewardPerItem_ == flag)
						{
							MultiItemInstance objB2 = other.rewardsPerItem_;
							if (object.Equals(rewardsPerItem_, objB2))
							{
								int num2 = other.victoryRewardLootPresent_;
								if (victoryRewardLootPresent_ == num2)
								{
									Duration objB3 = other.gracePeriod_;
									if (object.Equals(gracePeriod_, objB3))
									{
										string text = other.anticipationVFXPrefabAddress_;
										if (!(anticipationVFXPrefabAddress_ != text))
										{
											Duration objB4 = other.anticipationDuration_;
											if (object.Equals(anticipationDuration_, objB4))
											{
												UnknownFieldSet unknownFields = other._unknownFields;
												return object.Equals(_unknownFields, unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB4")]
		[Cpp2IlInjected.Address(RVA = "0x17109C0", Offset = "0x170F3C0", VA = "0x1817109C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a2
			Duration duration = duration_;
			if (duration != null)
			{
				int hashCode = duration.GetHashCode();
			}
			if (numberOfItemsToCollect_ != 0)
			{
			}
			if (fixedRewardPerItem_)
			{
			}
			MultiItemInstance multiItemInstance = rewardsPerItem_;
			if (multiItemInstance != null)
			{
				int hashCode2 = multiItemInstance.GetHashCode();
			}
			if (victoryRewardLootPresent_ != 0)
			{
			}
			Duration duration2 = gracePeriod_;
			if (duration2 != null)
			{
				int hashCode3 = duration2.GetHashCode();
			}
			string text = anticipationVFXPrefabAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode4 = text.GetHashCode();
			}
			Duration duration3 = anticipationDuration_;
			if (duration3 != null)
			{
				int hashCode5 = duration3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB5")]
		[Cpp2IlInjected.Address(RVA = "0x17111F0", Offset = "0x170FBF0", VA = "0x1817111F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB6")]
		[Cpp2IlInjected.Address(RVA = "0x1711250", Offset = "0x170FC50", VA = "0x181711250", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00e3
			if ((long)duration_ != 0)
			{
				Duration value = duration_;
				output.WriteMessage(value);
			}
			if (numberOfItemsToCollect_ != 0)
			{
				int value2 = numberOfItemsToCollect_;
				output.WriteInt32(value2);
			}
			if (fixedRewardPerItem_)
			{
				bool value3 = fixedRewardPerItem_;
				output.WriteBool(value3);
			}
			if ((long)rewardsPerItem_ != 0)
			{
				MultiItemInstance value4 = rewardsPerItem_;
				output.WriteMessage(value4);
			}
			if (victoryRewardLootPresent_ != 0)
			{
				int value5 = victoryRewardLootPresent_;
				output.WriteInt32(value5);
			}
			if ((long)gracePeriod_ != 0)
			{
				Duration value6 = gracePeriod_;
				output.WriteMessage(value6);
			}
			if (anticipationVFXPrefabAddress_.m_stringLength != 0)
			{
				string value7 = anticipationVFXPrefabAddress_;
				output.WriteString(value7);
			}
			if ((long)anticipationDuration_ != 0)
			{
				Duration value8 = anticipationDuration_;
				output.WriteMessage(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB7")]
		[Cpp2IlInjected.Address(RVA = "0x17101F0", Offset = "0x170EBF0", VA = "0x1817101F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00f9
			Duration duration = duration_;
			int num = 0;
			if (duration != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(duration);
			}
			int num3 = numberOfItemsToCollect_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			MultiItemInstance multiItemInstance = rewardsPerItem_;
			if (multiItemInstance != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(multiItemInstance);
				num5++;
				num += num5;
			}
			int num6 = victoryRewardLootPresent_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			Duration duration2 = gracePeriod_;
			if (duration2 != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(duration2);
				num8++;
				num += num8;
			}
			string text = anticipationVFXPrefabAddress_;
			if (text.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text);
				num9++;
				num += num9;
			}
			Duration duration3 = anticipationDuration_;
			if (duration3 != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(duration3);
				num10++;
				num += num10;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				num += num11;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB8")]
		[Cpp2IlInjected.Address(RVA = "0x1710D40", Offset = "0x170F740", VA = "0x181710D40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemCollectMinigameData other)
		{
			//Discarded unreachable code: IL_016c
			if (other == null)
			{
				return;
			}
			if ((long)other.duration_ != 0)
			{
				Duration duration = duration_;
				if (duration == null)
				{
					Duration duration2 = (duration_ = new Duration());
					Duration duration3 = duration_;
				}
				Duration other2 = other.duration_;
				duration.MergeFrom(other2);
			}
			int num = other.numberOfItemsToCollect_;
			if (num != 0)
			{
				numberOfItemsToCollect_ = num;
			}
			bool flag = other.fixedRewardPerItem_;
			if (flag)
			{
				fixedRewardPerItem_ = flag;
			}
			if ((long)other.rewardsPerItem_ != 0)
			{
				MultiItemInstance multiItemInstance2 = default(MultiItemInstance);
				if (rewardsPerItem_ == null)
				{
					MultiItemInstance multiItemInstance = (rewardsPerItem_ = new MultiItemInstance());
					multiItemInstance2 = rewardsPerItem_;
				}
				MultiItemInstance other3 = other.rewardsPerItem_;
				multiItemInstance2.MergeFrom(other3);
			}
			int num2 = other.victoryRewardLootPresent_;
			if (num2 != 0)
			{
				victoryRewardLootPresent_ = num2;
			}
			if ((long)other.gracePeriod_ != 0)
			{
				Duration duration5 = default(Duration);
				if (gracePeriod_ == null)
				{
					Duration duration4 = (gracePeriod_ = new Duration());
					duration5 = gracePeriod_;
				}
				Duration other4 = other.gracePeriod_;
				duration5.MergeFrom(other4);
			}
			string text = other.anticipationVFXPrefabAddress_;
			if (text.m_stringLength != 0)
			{
				AnticipationVFXPrefabAddress = text;
			}
			if ((long)other.anticipationDuration_ != 0)
			{
				Duration duration7 = default(Duration);
				if (anticipationDuration_ == null)
				{
					Duration duration6 = (anticipationDuration_ = new Duration());
					duration7 = anticipationDuration_;
				}
				Duration other5 = other.anticipationDuration_;
				duration7.MergeFrom(other5);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004AB9")]
		[Cpp2IlInjected.Address(RVA = "0x1710AF0", Offset = "0x170F4F0", VA = "0x181710AF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_014e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						string text2 = (AnticipationVFXPrefabAddress = input.ReadString());
					}
					if (num != 66)
					{
						goto IL_0137;
					}
					Duration builder = default(Duration);
					if (anticipationDuration_ == null)
					{
						Duration duration = (anticipationDuration_ = new Duration());
						builder = anticipationDuration_;
					}
					input.ReadMessage(builder);
				}
				int num2 = default(int);
				if (num == 40)
				{
					num2 = (victoryRewardLootPresent_ = input.ReadInt32());
				}
				if (num2 != 50)
				{
					goto IL_0137;
				}
				Duration builder2 = default(Duration);
				if (gracePeriod_ == null)
				{
					Duration duration2 = (gracePeriod_ = new Duration());
					builder2 = gracePeriod_;
				}
				input.ReadMessage(builder2);
			}
			MultiItemInstance multiItemInstance = default(MultiItemInstance);
			if ((int)num > 16)
			{
				bool flag = default(bool);
				if (num == 24)
				{
					flag = (fixedRewardPerItem_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0137;
				}
				MultiItemInstance builder3 = default(MultiItemInstance);
				if (rewardsPerItem_ == null)
				{
					multiItemInstance = (rewardsPerItem_ = new MultiItemInstance());
					builder3 = rewardsPerItem_;
				}
				input.ReadMessage(builder3);
			}
			Duration duration3 = default(Duration);
			if ((long)multiItemInstance == 10)
			{
				Duration builder4 = default(Duration);
				if (duration_ == null)
				{
					duration3 = (duration_ = new Duration());
					builder4 = duration_;
				}
				input.ReadMessage(builder4);
			}
			if ((long)duration3 == 16)
			{
				int num3 = (numberOfItemsToCollect_ = input.ReadInt32());
			}
			goto IL_0137;
			IL_0137:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004ABA")]
		[Cpp2IlInjected.Address(RVA = "0x1710850", Offset = "0x170F250", VA = "0x181710850", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				Duration duration = duration_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ABB")]
		[Cpp2IlInjected.Address(RVA = "0x1710F50", Offset = "0x170F950", VA = "0x181710F50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_0022, IL_0023, IL_002f, IL_0035, IL_003b
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				duration_ = (Duration)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004ABC")]
		[Cpp2IlInjected.Address(RVA = "0x17103D0", Offset = "0x170EDD0", VA = "0x1817103D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014, IL_0016
			//IL_0011: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num <= 7)
			{
				numberOfItemsToCollect_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004ABD")]
		[Cpp2IlInjected.Address(RVA = "0x17113E0", Offset = "0x170FDE0", VA = "0x1817113E0")]
		static ItemCollectMinigameData()
		{
			Func<ItemCollectMinigameData> func = default(Func<ItemCollectMinigameData>);
			_parser = (MessageParser<ItemCollectMinigameData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
