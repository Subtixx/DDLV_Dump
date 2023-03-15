using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Player
{
	[Cpp2IlInjected.Token(Token = "0x200024A")]
	public sealed class PlayerLevel : IMessage<PlayerLevel>, IMessage, IEquatable<PlayerLevel>, IDeepCloneable<PlayerLevel>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000910")]
		private static readonly MessageParser<PlayerLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000911")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000912")]
		public const int LevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000913")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x4000914")]
		public const int XpFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000915")]
		private int xp_;

		[Cpp2IlInjected.Token(Token = "0x4000916")]
		public const int BaseXpGivenFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000917")]
		private int baseXpGiven_;

		[Cpp2IlInjected.Token(Token = "0x4000918")]
		public const int RequestValueFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000919")]
		private int requestValue_;

		[Cpp2IlInjected.Token(Token = "0x400091A")]
		public const int RequestValueMaxFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400091B")]
		private int requestValueMax_;

		[Cpp2IlInjected.Token(Token = "0x400091C")]
		public const int VillageSlotCountFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400091D")]
		private int villageSlotCount_;

		[Cpp2IlInjected.Token(Token = "0x400091E")]
		public const int RewardsFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400091F")]
		private MultiReward rewards_;

		[Cpp2IlInjected.Token(Token = "0x4000920")]
		public const int UnlocksFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4000921")]
		private static readonly FieldCodec<Unlock> _repeated_unlocks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000922")]
		private readonly RepeatedField<Unlock> unlocks_ = (RepeatedField<Unlock>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000923")]
		public const int ItemRewardsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000924")]
		private static readonly FieldCodec<ItemReward> _repeated_itemRewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000925")]
		private readonly RepeatedField<ItemReward> itemRewards_ = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000926")]
		public const int MaximumManaAmountFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000927")]
		private int maximumManaAmount_;

		[Cpp2IlInjected.Token(Token = "0x170004C9")]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60015AB")]
			[Cpp2IlInjected.Address(RVA = "0x2878B70", Offset = "0x2877570", VA = "0x182878B70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60015AC")]
			[Cpp2IlInjected.Address(RVA = "0x2878AA0", Offset = "0x28774A0", VA = "0x182878AA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60015AD")]
			[Cpp2IlInjected.Address(RVA = "0x2878BD0", Offset = "0x28775D0", VA = "0x182878BD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CC")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60015B1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015B2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CD")]
		[DebuggerNonUserCode]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x60015B3")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return xp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015B4")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				xp_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CE")]
		[DebuggerNonUserCode]
		public int BaseXpGiven
		{
			[Cpp2IlInjected.Token(Token = "0x60015B5")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return baseXpGiven_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015B6")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				baseXpGiven_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CF")]
		[DebuggerNonUserCode]
		public int RequestValue
		{
			[Cpp2IlInjected.Token(Token = "0x60015B7")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return requestValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015B8")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				requestValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D0")]
		[DebuggerNonUserCode]
		public int RequestValueMax
		{
			[Cpp2IlInjected.Token(Token = "0x60015B9")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return requestValueMax_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015BA")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				requestValueMax_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D1")]
		[DebuggerNonUserCode]
		public int VillageSlotCount
		{
			[Cpp2IlInjected.Token(Token = "0x60015BB")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return villageSlotCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015BC")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				villageSlotCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D2")]
		[DebuggerNonUserCode]
		public MultiReward Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60015BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return rewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015BE")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				rewards_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D3")]
		[DebuggerNonUserCode]
		public RepeatedField<Unlock> Unlocks
		{
			[Cpp2IlInjected.Token(Token = "0x60015BF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return unlocks_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D4")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemReward> ItemRewards
		{
			[Cpp2IlInjected.Token(Token = "0x60015C0")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return itemRewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D5")]
		[DebuggerNonUserCode]
		public int MaximumManaAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60015C1")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return maximumManaAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015C2")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				maximumManaAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015AE")]
		[Cpp2IlInjected.Address(RVA = "0x2878810", Offset = "0x2877210", VA = "0x182878810")]
		[DebuggerNonUserCode]
		public PlayerLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60015AF")]
		[Cpp2IlInjected.Address(RVA = "0x28788D0", Offset = "0x28772D0", VA = "0x1828788D0")]
		[DebuggerNonUserCode]
		public PlayerLevel(PlayerLevel other)
		{
			//IL_009d: Expected O, but got I4
			int num = (level_ = other.level_);
			int num2 = (xp_ = other.xp_);
			int num3 = (baseXpGiven_ = other.baseXpGiven_);
			int num4 = (requestValue_ = other.requestValue_);
			int num5 = (requestValueMax_ = other.requestValueMax_);
			int num6 = (villageSlotCount_ = other.villageSlotCount_);
			MultiReward multiReward = other.rewards_;
			if (multiReward != null)
			{
				MultiReward multiReward2 = multiReward.Clone();
			}
			int num7 = 0;
			rewards_ = (MultiReward)num7;
			RepeatedField<Unlock> repeatedField = (unlocks_ = (RepeatedField<Unlock>)(object)((RepeatedField<T>)(object)other.unlocks_).Clone());
			RepeatedField<ItemReward> repeatedField2 = (itemRewards_ = (RepeatedField<ItemReward>)(object)((RepeatedField<T>)(object)other.itemRewards_).Clone());
			int num8 = (maximumManaAmount_ = other.maximumManaAmount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015B0")]
		[Cpp2IlInjected.Address(RVA = "0x2877630", Offset = "0x2876030", VA = "0x182877630", Slot = "10")]
		[DebuggerNonUserCode]
		public PlayerLevel Clone()
		{
			return new PlayerLevel(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60015C3")]
		[Cpp2IlInjected.Address(RVA = "0x28777B0", Offset = "0x28761B0", VA = "0x1828777B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)level_ == (IntPtr)typeof(PlayerLevel).TypeHandle && (IntPtr)xp_ == (IntPtr)typeof(PlayerLevel).TypeHandle && (IntPtr)baseXpGiven_ == (IntPtr)typeof(PlayerLevel).TypeHandle && (IntPtr)requestValue_ == (IntPtr)typeof(PlayerLevel).TypeHandle && (IntPtr)requestValueMax_ == (IntPtr)typeof(PlayerLevel).TypeHandle && (IntPtr)villageSlotCount_ == (IntPtr)typeof(PlayerLevel).TypeHandle && object.Equals(rewards_, other))
				{
					RepeatedField<Unlock> repeatedField = unlocks_;
					bool flag = default(bool);
					if (flag)
					{
						RepeatedField<ItemReward> repeatedField2 = itemRewards_;
						bool flag2 = default(bool);
						if (flag2 && maximumManaAmount_ == (flag2 ? 1 : 0))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015C4")]
		[Cpp2IlInjected.Address(RVA = "0x2877690", Offset = "0x2876090", VA = "0x182877690", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PlayerLevel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.level_;
				if (level_ == num)
				{
					int num2 = other.xp_;
					if (xp_ == num2)
					{
						int num3 = other.baseXpGiven_;
						if (baseXpGiven_ == num3)
						{
							int num4 = other.requestValue_;
							if (requestValue_ == num4)
							{
								int num5 = other.requestValueMax_;
								if (requestValueMax_ == num5)
								{
									int num6 = other.villageSlotCount_;
									if (villageSlotCount_ == num6)
									{
										MultiReward objB = other.rewards_;
										if (object.Equals(rewards_, objB))
										{
											RepeatedField<Unlock> repeatedField = unlocks_;
											RepeatedField<Unlock> repeatedField2 = other.unlocks_;
											if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
											{
												RepeatedField<ItemReward> repeatedField3 = itemRewards_;
												RepeatedField<ItemReward> repeatedField4 = other.itemRewards_;
												if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
												{
													int num7 = other.maximumManaAmount_;
													if (maximumManaAmount_ == num7)
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
				}
			}
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015C5")]
		[Cpp2IlInjected.Address(RVA = "0x2877A60", Offset = "0x2876460", VA = "0x182877A60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0087
			if (level_ != 0)
			{
			}
			if (xp_ != 0)
			{
			}
			if (baseXpGiven_ != 0)
			{
			}
			if (requestValue_ != 0)
			{
			}
			if (requestValueMax_ != 0)
			{
			}
			if (villageSlotCount_ != 0)
			{
			}
			MultiReward multiReward = rewards_;
			if (multiReward != null)
			{
				int hashCode = multiReward.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)unlocks_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)itemRewards_).GetHashCode();
			if (maximumManaAmount_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x60015C6")]
		[Cpp2IlInjected.Address(RVA = "0x28782E0", Offset = "0x2876CE0", VA = "0x1828782E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60015C7")]
		[Cpp2IlInjected.Address(RVA = "0x2878340", Offset = "0x2876D40", VA = "0x182878340", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_010a
			if (level_ != 0)
			{
				int value = level_;
				output.WriteInt32(value);
			}
			if (xp_ != 0)
			{
				int value2 = xp_;
				output.WriteInt32(value2);
			}
			if (baseXpGiven_ != 0)
			{
				int value3 = baseXpGiven_;
				output.WriteInt32(value3);
			}
			if (requestValue_ != 0)
			{
				int value4 = requestValue_;
				output.WriteInt32(value4);
			}
			if (requestValueMax_ != 0)
			{
				int value5 = requestValueMax_;
				output.WriteInt32(value5);
			}
			if (villageSlotCount_ != 0)
			{
				int value6 = villageSlotCount_;
				output.WriteInt32(value6);
			}
			if ((long)rewards_ != 0)
			{
				MultiReward value7 = rewards_;
				output.WriteMessage(value7);
			}
			RepeatedField<Unlock> repeatedField = unlocks_;
			FieldCodec<Unlock> repeated_unlocks_codec = _repeated_unlocks_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_unlocks_codec);
			RepeatedField<ItemReward> repeatedField2 = itemRewards_;
			FieldCodec<ItemReward> repeated_itemRewards_codec = _repeated_itemRewards_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemRewards_codec);
			if (maximumManaAmount_ != 0)
			{
				int value8 = maximumManaAmount_;
				output.WriteInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60015C8")]
		[Cpp2IlInjected.Address(RVA = "0x2877260", Offset = "0x2875C60", VA = "0x182877260", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0149
			int num = level_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = xp_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			int num6 = baseXpGiven_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			int num8 = requestValue_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = requestValueMax_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = villageSlotCount_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			MultiReward multiReward = rewards_;
			if (multiReward != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(multiReward);
				num14++;
				num2 += num14;
			}
			RepeatedField<Unlock> repeatedField = unlocks_;
			FieldCodec<Unlock> repeated_unlocks_codec = _repeated_unlocks_codec;
			int num15 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_unlocks_codec);
			RepeatedField<ItemReward> repeatedField2 = itemRewards_;
			FieldCodec<ItemReward> repeated_itemRewards_codec = _repeated_itemRewards_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemRewards_codec);
			int num17 = maximumManaAmount_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num19 = unknownFields.CalculateSize();
				num2 += num19;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60015C9")]
		[Cpp2IlInjected.Address(RVA = "0x2877BC0", Offset = "0x28765C0", VA = "0x182877BC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerLevel other)
		{
			//Discarded unreachable code: IL_011c
			if (other == null)
			{
				return;
			}
			int num = other.level_;
			if (num != 0)
			{
				level_ = num;
			}
			int num2 = other.xp_;
			if (num2 != 0)
			{
				xp_ = num2;
			}
			int num3 = other.baseXpGiven_;
			if (num3 != 0)
			{
				baseXpGiven_ = num3;
			}
			int num4 = other.requestValue_;
			if (num4 != 0)
			{
				requestValue_ = num4;
			}
			int num5 = other.requestValueMax_;
			if (num5 != 0)
			{
				requestValueMax_ = num5;
			}
			int num6 = other.villageSlotCount_;
			if (num6 != 0)
			{
				villageSlotCount_ = num6;
			}
			if ((long)other.rewards_ != 0)
			{
				MultiReward multiReward2 = default(MultiReward);
				if (rewards_ == null)
				{
					MultiReward multiReward = (rewards_ = new MultiReward());
					multiReward2 = rewards_;
				}
				MultiReward other2 = other.rewards_;
				multiReward2.MergeFrom(other2);
			}
			RepeatedField<Unlock> repeatedField = unlocks_;
			RepeatedField<Unlock> repeatedField2 = other.unlocks_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<ItemReward> repeatedField3 = itemRewards_;
			RepeatedField<ItemReward> repeatedField4 = other.itemRewards_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			int num7 = other.maximumManaAmount_;
			if (num7 != 0)
			{
				maximumManaAmount_ = num7;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60015CA")]
		[Cpp2IlInjected.Address(RVA = "0x2877D20", Offset = "0x2876720", VA = "0x182877D20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0140
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 40)
			{
				if ((int)num > 58)
				{
					if (num == 66)
					{
						RepeatedField<Unlock> repeatedField = unlocks_;
						FieldCodec<Unlock> repeated_unlocks_codec = _repeated_unlocks_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unlocks_codec);
					}
					if (num == 74)
					{
						RepeatedField<ItemReward> repeatedField2 = itemRewards_;
						FieldCodec<ItemReward> repeated_itemRewards_codec = _repeated_itemRewards_codec;
						((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemRewards_codec);
					}
					if (num != 80)
					{
						goto IL_0129;
					}
					int num2 = (maximumManaAmount_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 48)
				{
					num3 = (villageSlotCount_ = input.ReadInt32());
				}
				if (num3 != 58)
				{
					goto IL_0129;
				}
				MultiReward builder = default(MultiReward);
				if (rewards_ == null)
				{
					MultiReward multiReward = (rewards_ = new MultiReward());
					builder = rewards_;
				}
				input.ReadMessage(builder);
			}
			int num6 = default(int);
			if ((int)num > 16)
			{
				int num4 = default(int);
				if (num == 24)
				{
					num4 = (baseXpGiven_ = input.ReadInt32());
				}
				int num5 = default(int);
				if (num4 == 32)
				{
					num5 = (requestValue_ = input.ReadInt32());
				}
				if (num5 != 40)
				{
					goto IL_0129;
				}
				num6 = (requestValueMax_ = input.ReadInt32());
			}
			int num7 = default(int);
			if (num6 == 8)
			{
				num7 = (level_ = input.ReadInt32());
			}
			if (num7 == 16)
			{
				int num8 = (xp_ = input.ReadInt32());
			}
			goto IL_0129;
			IL_0129:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60015CB")]
		[Cpp2IlInjected.Address(RVA = "0x2877920", Offset = "0x2876320", VA = "0x182877920", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = level_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015CC")]
		[Cpp2IlInjected.Address(RVA = "0x2877FA0", Offset = "0x28769A0", VA = "0x182877FA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0023, IL_0029
			//IL_000e: Expected I4, but got O
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				level_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015CD")]
		[Cpp2IlInjected.Address(RVA = "0x28774F0", Offset = "0x2875EF0", VA = "0x1828774F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0017
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 9)
			{
				level_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015CE")]
		[Cpp2IlInjected.Address(RVA = "0x2878580", Offset = "0x2876F80", VA = "0x182878580")]
		static PlayerLevel()
		{
			Func<PlayerLevel> func = default(Func<PlayerLevel>);
			_parser = (MessageParser<PlayerLevel>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Unlock> parser = Unlock._parser;
			uint num = default(uint);
			_parser = (MessageParser<PlayerLevel>)(object)FieldCodec.ForMessage<Unlock>(num, (MessageParser<>)(object)parser);
			MessageParser<ItemReward> parser2 = ItemReward._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<PlayerLevel>)(object)FieldCodec.ForMessage<ItemReward>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
