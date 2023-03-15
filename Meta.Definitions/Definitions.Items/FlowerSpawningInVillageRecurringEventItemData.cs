using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003B2")]
	public sealed class FlowerSpawningInVillageRecurringEventItemData : IMessage<FlowerSpawningInVillageRecurringEventItemData>, IMessage, IEquatable<FlowerSpawningInVillageRecurringEventItemData>, IDeepCloneable<FlowerSpawningInVillageRecurringEventItemData>, IMessageFieldAccessor, IRecurringEventData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x400130E")]
		private static readonly MessageParser<FlowerSpawningInVillageRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400130F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001310")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001311")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001312")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001313")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001314")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001315")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001316")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001317")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001318")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001319")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400131A")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400131B")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x400131C")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400131D")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x400131E")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400131F")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x4001320")]
		public const int NumberOfFlowersToSpawnFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001321")]
		private int numberOfFlowersToSpawn_;

		[Cpp2IlInjected.Token(Token = "0x4001322")]
		public const int PossibleFlowersFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001323")]
		private static readonly FieldCodec<int> _repeated_possibleFlowers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001324")]
		private readonly RepeatedField<int> possibleFlowers_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001325")]
		public const int MaximumAmountFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001326")]
		private int maximumAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001327")]
		public const int SpawnInSpecificAreasFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001328")]
		private bool spawnInSpecificAreas_;

		[Cpp2IlInjected.Token(Token = "0x4001329")]
		public const int AreasFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x400132A")]
		private static readonly FieldCodec<VillageAreaType> _repeated_areas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400132B")]
		private readonly RepeatedField<VillageAreaType> areas_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400132C")]
		private static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000AD5")]
		[DebuggerNonUserCode]
		public static MessageParser<FlowerSpawningInVillageRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002B90")]
			[Cpp2IlInjected.Address(RVA = "0x3586DE0", Offset = "0x35857E0", VA = "0x183586DE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B91")]
			[Cpp2IlInjected.Address(RVA = "0x3586D10", Offset = "0x3585710", VA = "0x183586D10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B92")]
			[Cpp2IlInjected.Address(RVA = "0x3586EA0", Offset = "0x35858A0", VA = "0x183586EA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD8")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002B97")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B98")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD9")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002B99")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B9A")]
			[Cpp2IlInjected.Address(RVA = "0x3587090", Offset = "0x3585A90", VA = "0x183587090")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ADA")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002B9B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "20")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B9C")]
			[Cpp2IlInjected.Address(RVA = "0x3586FB0", Offset = "0x35859B0", VA = "0x183586FB0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ADB")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002B9D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B9E")]
			[Cpp2IlInjected.Address(RVA = "0x3587020", Offset = "0x3585A20", VA = "0x183587020")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ADC")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002B9F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "22")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA0")]
			[Cpp2IlInjected.Address(RVA = "0x3587100", Offset = "0x3585B00", VA = "0x183587100")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ADD")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA1")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "14")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA2")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ADE")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ADF")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA5")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "16")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA6")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE0")]
		[DebuggerNonUserCode]
		public int NumberOfFlowersToSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA7")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return numberOfFlowersToSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA8")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				numberOfFlowersToSpawn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE1")]
		[DebuggerNonUserCode]
		public RepeatedField<int> PossibleFlowers
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA9")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return possibleFlowers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE2")]
		[DebuggerNonUserCode]
		public int MaximumAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return maximumAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				maximumAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE3")]
		[DebuggerNonUserCode]
		public bool SpawnInSpecificAreas
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAC")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get
			{
				return spawnInSpecificAreas_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BAD")]
			[Cpp2IlInjected.Address(RVA = "0xD2B640", Offset = "0xD2A040", VA = "0x180D2B640")]
			set
			{
				spawnInSpecificAreas_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE4")]
		[DebuggerNonUserCode]
		public RepeatedField<VillageAreaType> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAE")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return areas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE5")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002BBA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE6")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002BBB")]
			[Cpp2IlInjected.Address(RVA = "0x3586E40", Offset = "0x3585840", VA = "0x183586E40")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B93")]
		[Cpp2IlInjected.Address(RVA = "0x3586BB0", Offset = "0x35855B0", VA = "0x183586BB0")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillageRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B94")]
		[Cpp2IlInjected.Address(RVA = "0x3585DF0", Offset = "0x35847F0", VA = "0x183585DF0")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B95")]
		[Cpp2IlInjected.Address(RVA = "0x35868F0", Offset = "0x35852F0", VA = "0x1835868F0")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillageRecurringEventItemData(FlowerSpawningInVillageRecurringEventItemData other)
		{
			//IL_00d8: Expected O, but got I4
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = (activeByDefault_ = other.activeByDefault_);
			RecurringEventIntervalData recurringEventIntervalData2 = other.intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			int num2 = 0;
			intervalData_ = (RecurringEventIntervalData)num2;
			bool flag2 = (executeOnAdd_ = other.executeOnAdd_);
			int num3 = (numberOfFlowersToSpawn_ = other.numberOfFlowersToSpawn_);
			RepeatedField<int> repeatedField = (possibleFlowers_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.possibleFlowers_).Clone());
			int num4 = (maximumAmount_ = other.maximumAmount_);
			bool flag3 = (spawnInSpecificAreas_ = other.spawnInSpecificAreas_);
			RepeatedField<VillageAreaType> repeatedField2 = (areas_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)other.areas_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B96")]
		[Cpp2IlInjected.Address(RVA = "0x35851B0", Offset = "0x3583BB0", VA = "0x1835851B0", Slot = "10")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillageRecurringEventItemData Clone()
		{
			return new FlowerSpawningInVillageRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BAF")]
		[Cpp2IlInjected.Address(RVA = "0x3585210", Offset = "0x3583C10", VA = "0x183585210", Slot = "0")]
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
				if ((object)usedTagTypes == (object)typeof(FlowerSpawningInVillageRecurringEventItemData).TypeHandle)
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
								if (!flag4 && activeByDefault_ == flag4)
								{
									bool flag5 = object.Equals(intervalData_, other);
									if (flag5 && executeOnAdd_ == flag5 && numberOfFlowersToSpawn_ == (flag5 ? 1 : 0))
									{
										RepeatedField<int> repeatedField = possibleFlowers_;
										bool flag6 = default(bool);
										if (flag6 && maximumAmount_ == (flag6 ? 1 : 0) && spawnInSpecificAreas_ == flag6)
										{
											RepeatedField<VillageAreaType> repeatedField2 = areas_;
											bool flag7 = default(bool);
											if (flag7)
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB0")]
		[Cpp2IlInjected.Address(RVA = "0x35853E0", Offset = "0x3583DE0", VA = "0x1835853E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FlowerSpawningInVillageRecurringEventItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if ((IntPtr)usedTagTypes == (IntPtr)num)
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
									bool flag = other.activeByDefault_;
									if (activeByDefault_ == flag)
									{
										RecurringEventIntervalData objB = other.intervalData_;
										if (object.Equals(intervalData_, objB))
										{
											bool flag2 = other.executeOnAdd_;
											if (executeOnAdd_ == flag2)
											{
												int num2 = other.numberOfFlowersToSpawn_;
												if (numberOfFlowersToSpawn_ == num2)
												{
													RepeatedField<int> repeatedField = possibleFlowers_;
													RepeatedField<int> repeatedField2 = other.possibleFlowers_;
													if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
													{
														int num3 = other.maximumAmount_;
														if (maximumAmount_ == num3)
														{
															bool flag3 = other.spawnInSpecificAreas_;
															if (spawnInSpecificAreas_ == flag3)
															{
																RepeatedField<VillageAreaType> repeatedField3 = areas_;
																RepeatedField<VillageAreaType> repeatedField4 = other.areas_;
																if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
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
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB1")]
		[Cpp2IlInjected.Address(RVA = "0x3585720", Offset = "0x3584120", VA = "0x183585720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e6
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
			if (activeByDefault_)
			{
			}
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int hashCode5 = recurringEventIntervalData.GetHashCode();
			}
			if (executeOnAdd_)
			{
			}
			if (numberOfFlowersToSpawn_ != 0)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)possibleFlowers_).GetHashCode();
			if (maximumAmount_ != 0)
			{
			}
			if (spawnInSpecificAreas_)
			{
			}
			int hashCode7 = ((RepeatedField<T>)(object)areas_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB2")]
		[Cpp2IlInjected.Address(RVA = "0x3586280", Offset = "0x3584C80", VA = "0x183586280", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB3")]
		[Cpp2IlInjected.Address(RVA = "0x35862E0", Offset = "0x3584CE0", VA = "0x1835862E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_016b
			if ((long)usedTagTypes != 0)
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
			if (activeByDefault_)
			{
				bool value6 = activeByDefault_;
				output.WriteBool(value6);
			}
			if ((long)intervalData_ != 0)
			{
				RecurringEventIntervalData value7 = intervalData_;
				output.WriteMessage(value7);
			}
			if (executeOnAdd_)
			{
				bool value8 = executeOnAdd_;
				output.WriteBool(value8);
			}
			if (numberOfFlowersToSpawn_ != 0)
			{
				int value9 = numberOfFlowersToSpawn_;
				output.WriteInt32(value9);
			}
			RepeatedField<int> repeatedField = possibleFlowers_;
			FieldCodec<int> repeated_possibleFlowers_codec = _repeated_possibleFlowers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_possibleFlowers_codec);
			if (maximumAmount_ != 0)
			{
				int value10 = maximumAmount_;
				output.WriteInt32(value10);
			}
			if (spawnInSpecificAreas_)
			{
				bool value11 = spawnInSpecificAreas_;
				output.WriteBool(value11);
			}
			RepeatedField<VillageAreaType> repeatedField2 = areas_;
			FieldCodec<VillageAreaType> repeated_areas_codec = _repeated_areas_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_areas_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB4")]
		[Cpp2IlInjected.Address(RVA = "0x3584D00", Offset = "0x3583700", VA = "0x183584D00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_015d
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
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(recurringEventIntervalData);
				num8++;
				num2 += num8;
			}
			int num9 = numberOfFlowersToSpawn_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			RepeatedField<int> repeatedField = possibleFlowers_;
			FieldCodec<int> repeated_possibleFlowers_codec = _repeated_possibleFlowers_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_possibleFlowers_codec);
			int num12 = maximumAmount_;
			num2 += num11;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			RepeatedField<VillageAreaType> repeatedField2 = areas_;
			FieldCodec<VillageAreaType> repeated_areas_codec = _repeated_areas_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_areas_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB5")]
		[Cpp2IlInjected.Address(RVA = "0x3585C20", Offset = "0x3584620", VA = "0x183585C20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FlowerSpawningInVillageRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_016f
			if (other == null)
			{
				return;
			}
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
			bool flag = other.activeByDefault_;
			if (flag)
			{
				activeByDefault_ = flag;
			}
			if ((long)other.intervalData_ != 0)
			{
				RecurringEventIntervalData recurringEventIntervalData2 = default(RecurringEventIntervalData);
				if (intervalData_ == null)
				{
					RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
					recurringEventIntervalData2 = intervalData_;
				}
				RecurringEventIntervalData other2 = other.intervalData_;
				recurringEventIntervalData2.MergeFrom(other2);
			}
			bool flag2 = other.executeOnAdd_;
			if (flag2)
			{
				executeOnAdd_ = flag2;
			}
			int num2 = other.numberOfFlowersToSpawn_;
			if (num2 != 0)
			{
				numberOfFlowersToSpawn_ = num2;
			}
			RepeatedField<int> repeatedField = possibleFlowers_;
			RepeatedField<int> repeatedField2 = other.possibleFlowers_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num3 = other.maximumAmount_;
			if (num3 != 0)
			{
				maximumAmount_ = num3;
			}
			bool flag3 = other.spawnInSpecificAreas_;
			if (flag3)
			{
				spawnInSpecificAreas_ = flag3;
			}
			RepeatedField<VillageAreaType> repeatedField3 = areas_;
			RepeatedField<VillageAreaType> repeatedField4 = other.areas_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB6")]
		[Cpp2IlInjected.Address(RVA = "0x3585900", Offset = "0x3584300", VA = "0x183585900", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01b1
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 82)
				{
					if ((int)num > 96)
					{
						num += 4294967192u;
						if (num != 4294967293u)
						{
							goto IL_019a;
						}
						RepeatedField<VillageAreaType> repeatedField = areas_;
						FieldCodec<VillageAreaType> repeated_areas_codec = _repeated_areas_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_areas_codec);
					}
					int num2 = default(int);
					if (num == 88)
					{
						num2 = (maximumAmount_ = input.ReadInt32());
					}
					if (num2 != 96)
					{
						goto IL_019a;
					}
					bool flag = (spawnInSpecificAreas_ = input.ReadBool());
				}
				if ((int)num > 72)
				{
					num += 4294967216u;
					if (num != 4294967293u)
					{
						goto IL_019a;
					}
					RepeatedField<int> repeatedField2 = possibleFlowers_;
					FieldCodec<int> repeated_possibleFlowers_codec = _repeated_possibleFlowers_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_possibleFlowers_codec);
				}
				bool flag2 = default(bool);
				if (num == 64)
				{
					flag2 = (executeOnAdd_ = input.ReadBool());
				}
				if (!flag2)
				{
					goto IL_019a;
				}
				int num3 = (numberOfFlowersToSpawn_ = input.ReadInt32());
			}
			string text4 = default(string);
			if ((int)num > 26)
			{
				RecurringEventIntervalData recurringEventIntervalData = default(RecurringEventIntervalData);
				if ((int)num > 42)
				{
					bool flag3 = default(bool);
					if (num == 48)
					{
						flag3 = (activeByDefault_ = input.ReadBool());
					}
					if (!flag3)
					{
						goto IL_019a;
					}
					RecurringEventIntervalData builder = default(RecurringEventIntervalData);
					if (intervalData_ == null)
					{
						recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
						builder = intervalData_;
					}
					input.ReadMessage(builder);
				}
				string text2 = default(string);
				if ((long)recurringEventIntervalData == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_019a;
				}
				text4 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text4 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num4 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_019a;
			IL_019a:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB7")]
		[Cpp2IlInjected.Address(RVA = "0x3585560", Offset = "0x3583F60", VA = "0x183585560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB8")]
		[Cpp2IlInjected.Address(RVA = "0x3585E50", Offset = "0x3584850", VA = "0x183585E50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0020, IL_0028, IL_0037, IL_003f, IL_0047, IL_004f, IL_0060, IL_0066, IL_006c, IL_0072, IL_0078
			//IL_000e: Expected I4, but got O
			//IL_002f: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB9")]
		[Cpp2IlInjected.Address(RVA = "0x3585000", Offset = "0x3583A00", VA = "0x183585000", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BBC")]
		[Cpp2IlInjected.Address(RVA = "0x35851B0", Offset = "0x3583BB0", VA = "0x1835851B0", Slot = "23")]
		IItemData IItemData.Clone()
		{
			FlowerSpawningInVillageRecurringEventItemData flowerSpawningInVillageRecurringEventItemData = new FlowerSpawningInVillageRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BBD")]
		[Cpp2IlInjected.Address(RVA = "0x3586610", Offset = "0x3585010", VA = "0x183586610")]
		static FlowerSpawningInVillageRecurringEventItemData()
		{
			//Discarded unreachable code: IL_005f
			//IL_0057: Expected O, but got I4
			Func<FlowerSpawningInVillageRecurringEventItemData> func = default(Func<FlowerSpawningInVillageRecurringEventItemData>);
			MessageParser<FlowerSpawningInVillageRecurringEventItemData> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<FlowerSpawningInVillageRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func));
			_parser = (MessageParser<FlowerSpawningInVillageRecurringEventItemData>)(object)FieldCodec.ForInt32(82u);
			Func<VillageAreaType, int> func2 = (Func<VillageAreaType, int>)(object)(Func<T, TResult>)((VillageAreaType x) => (int)x);
			Func<int, VillageAreaType> func3 = (Func<int, VillageAreaType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<FlowerSpawningInVillageRecurringEventItemData>)(object)FieldCodec.ForEnum<VillageAreaType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num2 = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num2;
			_parser = (MessageParser<FlowerSpawningInVillageRecurringEventItemData>)(object)array;
		}
	}
}
