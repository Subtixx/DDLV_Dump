using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000557")]
	public sealed class FtueItemData : IMessage<FtueItemData>, IMessage, IEquatable<FtueItemData>, IDeepCloneable<FtueItemData>, IMessageFieldAccessor, IItemData, IHasGlotID
	{
		[Cpp2IlInjected.Token(Token = "0x4001D00")]
		private static readonly MessageParser<FtueItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D01")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001D02")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D03")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001D04")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D05")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D06")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D07")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D08")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D09")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D0A")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D0B")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D0C")]
		public const int RewardsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001D0D")]
		private static readonly FieldCodec<FtueReward> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D0E")]
		private readonly RepeatedField<FtueReward> rewards_ = (RepeatedField<FtueReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001D0F")]
		public const int MaxChoicesFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D10")]
		private int maxChoices_;

		[Cpp2IlInjected.Token(Token = "0x4001D11")]
		public const int RewardChoicesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001D12")]
		private static readonly MapField<int, FtueRewards>.Codec _map_rewardChoices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D13")]
		private readonly MapField<int, FtueRewards> rewardChoices_ = (MapField<int, FtueRewards>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4001D14")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D15")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17001137")]
		[DebuggerNonUserCode]
		public static MessageParser<FtueItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60042AE")]
			[Cpp2IlInjected.Address(RVA = "0x343FA30", Offset = "0x343E430", VA = "0x18343FA30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001138")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60042AF")]
			[Cpp2IlInjected.Address(RVA = "0x343F960", Offset = "0x343E360", VA = "0x18343F960")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001139")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60042B0")]
			[Cpp2IlInjected.Address(RVA = "0x343FA90", Offset = "0x343E490", VA = "0x18343FA90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700113A")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60042B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042B5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700113B")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60042B6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042B7")]
			[Cpp2IlInjected.Address(RVA = "0x343FC80", Offset = "0x343E680", VA = "0x18343FC80")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700113C")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60042B8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042B9")]
			[Cpp2IlInjected.Address(RVA = "0x343FBA0", Offset = "0x343E5A0", VA = "0x18343FBA0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700113D")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60042BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042BB")]
			[Cpp2IlInjected.Address(RVA = "0x343FC10", Offset = "0x343E610", VA = "0x18343FC10")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700113E")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60042BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042BD")]
			[Cpp2IlInjected.Address(RVA = "0x343FCF0", Offset = "0x343E6F0", VA = "0x18343FCF0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700113F")]
		[DebuggerNonUserCode]
		public RepeatedField<FtueReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60042BE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001140")]
		[DebuggerNonUserCode]
		public int MaxChoices
		{
			[Cpp2IlInjected.Token(Token = "0x60042BF")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return maxChoices_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042C0")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				maxChoices_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001141")]
		[DebuggerNonUserCode]
		public MapField<int, FtueRewards> RewardChoices
		{
			[Cpp2IlInjected.Token(Token = "0x60042C1")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return rewardChoices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001142")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60042C2")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042C3")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001143")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60042CF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042B1")]
		[Cpp2IlInjected.Address(RVA = "0x343F600", Offset = "0x343E000", VA = "0x18343F600")]
		[DebuggerNonUserCode]
		public FtueItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60042B2")]
		[Cpp2IlInjected.Address(RVA = "0x343F720", Offset = "0x343E120", VA = "0x18343F720")]
		[DebuggerNonUserCode]
		public FtueItemData(FtueItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			RepeatedField<FtueReward> repeatedField = (rewards_ = (RepeatedField<FtueReward>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			int num2 = (maxChoices_ = other.maxChoices_);
			MapField<int, FtueRewards> mapField = (rewardChoices_ = (MapField<int, FtueRewards>)(object)((MapField<TKey, TValue>)(object)other.rewardChoices_).Clone());
			uint num3 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042B3")]
		[Cpp2IlInjected.Address(RVA = "0x343E390", Offset = "0x343CD90", VA = "0x18343E390", Slot = "10")]
		[DebuggerNonUserCode]
		public FtueItemData Clone()
		{
			return new FtueItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60042C4")]
		[Cpp2IlInjected.Address(RVA = "0x343E530", Offset = "0x343CF30", VA = "0x18343E530", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(FtueItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									RepeatedField<FtueReward> repeatedField = rewards_;
									bool flag5 = default(bool);
									if (flag5 && maxChoices_ == (flag5 ? 1 : 0))
									{
										MapField<int, FtueRewards> mapField = rewardChoices_;
										bool flag6 = default(bool);
										if (flag6 && glotID_ == (flag6 ? 1u : 0u))
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042C5")]
		[Cpp2IlInjected.Address(RVA = "0x343E3F0", Offset = "0x343CDF0", VA = "0x18343E3F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FtueItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									RepeatedField<FtueReward> repeatedField = rewards_;
									RepeatedField<FtueReward> repeatedField2 = other.rewards_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										int num2 = other.maxChoices_;
										if (maxChoices_ == num2)
										{
											MapField<int, FtueRewards> mapField = rewardChoices_;
											MapField<int, FtueRewards> mapField2 = other.rewardChoices_;
											if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
											{
												uint num3 = other.glotID_;
												if (glotID_ == num3)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042C6")]
		[Cpp2IlInjected.Address(RVA = "0x343E820", Offset = "0x343D220", VA = "0x18343E820", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b5
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)rewards_).GetHashCode();
			if (maxChoices_ != 0)
			{
			}
			int hashCode6 = ((MapField<TKey, TValue>)(object)rewardChoices_).GetHashCode();
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60042C7")]
		[Cpp2IlInjected.Address(RVA = "0x343F030", Offset = "0x343DA30", VA = "0x18343F030", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60042C8")]
		[Cpp2IlInjected.Address(RVA = "0x343F090", Offset = "0x343DA90", VA = "0x18343F090", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0104
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			RepeatedField<FtueReward> repeatedField = rewards_;
			FieldCodec<FtueReward> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			if (maxChoices_ != 0)
			{
				int value6 = maxChoices_;
				output.WriteInt32(value6);
			}
			MapField<int, FtueRewards> mapField = rewardChoices_;
			MapField<int, FtueRewards>.Codec map_rewardChoices_codec = _map_rewardChoices_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_rewardChoices_codec);
			if (glotID_ != 0)
			{
				uint value7 = glotID_;
				output.WriteUInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60042C9")]
		[Cpp2IlInjected.Address(RVA = "0x343DF50", Offset = "0x343C950", VA = "0x18343DF50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0147
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			RepeatedField<FtueReward> repeatedField = rewards_;
			FieldCodec<FtueReward> repeated_rewards_codec = _repeated_rewards_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			int num9 = maxChoices_;
			num2 += num8;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			MapField<int, FtueRewards> mapField = rewardChoices_;
			MapField<int, FtueRewards>.Codec map_rewardChoices_codec = _map_rewardChoices_codec;
			int num11 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_rewardChoices_codec);
			uint num12 = glotID_;
			num2 += num11;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeUInt32Size(num12);
				num13 += 2;
				num2 += num13;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num2 += num14;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60042CA")]
		[Cpp2IlInjected.Address(RVA = "0x343EBE0", Offset = "0x343D5E0", VA = "0x18343EBE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FtueItemData other)
		{
			//Discarded unreachable code: IL_00f5
			if (other != null)
			{
				int num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.displayName_;
				if (text2.m_stringLength != 0)
				{
					DisplayName = text2;
				}
				string text3 = other.iconAddress_;
				if (text3.m_stringLength != 0)
				{
					IconAddress = text3;
				}
				string text4 = other.prefabAddress_;
				if (text4.m_stringLength != 0)
				{
					PrefabAddress = text4;
				}
				RepeatedField<FtueReward> repeatedField = rewards_;
				RepeatedField<FtueReward> repeatedField2 = other.rewards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num2 = other.maxChoices_;
				if (num2 != 0)
				{
					maxChoices_ = num2;
				}
				MapField<int, FtueRewards> mapField = rewardChoices_;
				MapField<int, FtueRewards> mapField2 = other.rewardChoices_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				uint num3 = other.glotID_;
				if (num3 != 0)
				{
					glotID_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042CB")]
		[Cpp2IlInjected.Address(RVA = "0x343E990", Offset = "0x343D390", VA = "0x18343E990", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_011b
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 58)
				{
					if (num == 64)
					{
						int num2 = (maxChoices_ = input.ReadInt32());
					}
					if (num == 74)
					{
						MapField<int, FtueRewards> mapField = rewardChoices_;
						MapField<int, FtueRewards>.Codec map_rewardChoices_codec = _map_rewardChoices_codec;
						((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_rewardChoices_codec);
					}
					if (num != 7992)
					{
						goto IL_0104;
					}
					int num3 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 58)
				{
					goto IL_0104;
				}
				RepeatedField<FtueReward> repeatedField = rewards_;
				FieldCodec<FtueReward> repeated_rewards_codec = _repeated_rewards_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_0104;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text6 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0104;
			IL_0104:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60042CC")]
		[Cpp2IlInjected.Address(RVA = "0x343E6B0", Offset = "0x343D0B0", VA = "0x18343E6B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60042CD")]
		[Cpp2IlInjected.Address(RVA = "0x343ED20", Offset = "0x343D720", VA = "0x18343ED20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_001b, IL_0028, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			//IL_003f: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x60042CE")]
		[Cpp2IlInjected.Address(RVA = "0x343E200", Offset = "0x343CC00", VA = "0x18343E200", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0016, IL_0029
			//IL_000f: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042D0")]
		[Cpp2IlInjected.Address(RVA = "0x343E390", Offset = "0x343CD90", VA = "0x18343E390", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FtueItemData ftueItemData = new FtueItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60042D1")]
		[Cpp2IlInjected.Address(RVA = "0x343F310", Offset = "0x343DD10", VA = "0x18343F310")]
		static FtueItemData()
		{
			Func<FtueItemData> func = default(Func<FtueItemData>);
			_parser = (MessageParser<FtueItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<FtueReward> parser = FtueReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<FtueItemData>)(object)FieldCodec.ForMessage<FtueReward>(num, (MessageParser<>)(object)parser);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<FtueRewards> parser2 = FtueRewards._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<FtueRewards>(num2, (MessageParser<>)(object)parser2);
			uint num3 = default(uint);
			_parser = (MessageParser<FtueItemData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num3);
			/*Error: Unexpected end of block*/;
		}
	}
}
