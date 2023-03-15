using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003FE")]
	public sealed class MiningDataItemData : IMessage<MiningDataItemData>, IMessage, IEquatable<MiningDataItemData>, IDeepCloneable<MiningDataItemData>, IMessageFieldAccessor, IItemData, IProtobufDefaultData, IActivityDataItemData
	{
		[Cpp2IlInjected.Token(Token = "0x40015CC")]
		private static readonly MessageParser<MiningDataItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015CD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40015CE")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015CF")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40015D0")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015D1")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015D2")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015D3")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015D4")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015D5")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015D6")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40015D7")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015D8")]
		public const int ResultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40015D9")]
		private ItemWithState result_;

		[Cpp2IlInjected.Token(Token = "0x40015DA")]
		public const int LocationFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40015DB")]
		private ActivityDataLocationFilter location_;

		[Cpp2IlInjected.Token(Token = "0x40015DC")]
		public const int IsValuableFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40015DD")]
		private bool isValuable_;

		[Cpp2IlInjected.Token(Token = "0x40015DE")]
		public const int RarityFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40015DF")]
		private MiningRarity rarity_;

		[Cpp2IlInjected.Token(Token = "0x40015E0")]
		public const int WeightPercentageFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40015E1")]
		private int weightPercentage_;

		[Cpp2IlInjected.Token(Token = "0x40015E2")]
		public const int FailureProbabilityPerHitFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40015E3")]
		private int failureProbabilityPerHit_;

		[Cpp2IlInjected.Token(Token = "0x40015E4")]
		public const int MininumNumberOfHitsFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40015E5")]
		private int mininumNumberOfHits_;

		[Cpp2IlInjected.Token(Token = "0x40015E6")]
		public const int MaximumNumberOfHitsFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40015E7")]
		private int maximumNumberOfHits_;

		[Cpp2IlInjected.Token(Token = "0x40015E8")]
		public const int IsHiddenFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40015E9")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x17000C76")]
		[DebuggerNonUserCode]
		public static MessageParser<MiningDataItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60030AC")]
			[Cpp2IlInjected.Address(RVA = "0x1D33F00", Offset = "0x1D32900", VA = "0x181D33F00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C77")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60030AD")]
			[Cpp2IlInjected.Address(RVA = "0x1D33E30", Offset = "0x1D32830", VA = "0x181D33E30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C78")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60030AE")]
			[Cpp2IlInjected.Address(RVA = "0x1D33F60", Offset = "0x1D32960", VA = "0x181D33F60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C79")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60030B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60030B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030B6")]
			[Cpp2IlInjected.Address(RVA = "0x1D34150", Offset = "0x1D32B50", VA = "0x181D34150")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7B")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60030B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030B8")]
			[Cpp2IlInjected.Address(RVA = "0x1D34070", Offset = "0x1D32A70", VA = "0x181D34070")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7C")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60030B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030BA")]
			[Cpp2IlInjected.Address(RVA = "0x1D340E0", Offset = "0x1D32AE0", VA = "0x181D340E0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7D")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60030BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030BC")]
			[Cpp2IlInjected.Address(RVA = "0x1D341C0", Offset = "0x1D32BC0", VA = "0x181D341C0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7E")]
		[DebuggerNonUserCode]
		public ItemWithState Result
		{
			[Cpp2IlInjected.Token(Token = "0x60030BD")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return result_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030BE")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				result_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7F")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter Location
		{
			[Cpp2IlInjected.Token(Token = "0x60030BF")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C0")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C80")]
		[DebuggerNonUserCode]
		public bool IsValuable
		{
			[Cpp2IlInjected.Token(Token = "0x60030C1")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return isValuable_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C2")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				isValuable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C81")]
		[DebuggerNonUserCode]
		public MiningRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60030C3")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C4")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C82")]
		[DebuggerNonUserCode]
		public int WeightPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x60030C5")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return weightPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C6")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				weightPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C83")]
		[DebuggerNonUserCode]
		public int FailureProbabilityPerHit
		{
			[Cpp2IlInjected.Token(Token = "0x60030C7")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return failureProbabilityPerHit_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C8")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				failureProbabilityPerHit_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C84")]
		[DebuggerNonUserCode]
		public int MininumNumberOfHits
		{
			[Cpp2IlInjected.Token(Token = "0x60030C9")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return mininumNumberOfHits_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				mininumNumberOfHits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C85")]
		[DebuggerNonUserCode]
		public int MaximumNumberOfHits
		{
			[Cpp2IlInjected.Token(Token = "0x60030CB")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30")]
			get
			{
				return maximumNumberOfHits_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030CC")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				maximumNumberOfHits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C86")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x60030CD")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x60030CE")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C87")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60030DA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C88")]
		Item IActivityDataItemData.ResultItem
		{
			[Cpp2IlInjected.Token(Token = "0x60030DB")]
			[Cpp2IlInjected.Address(RVA = "0x1D32670", Offset = "0x1D31070", VA = "0x181D32670", Slot = "22")]
			get
			{
				//Discarded unreachable code: IL_000c
				return result_.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D33D20", Offset = "0x1D32720", VA = "0x181D33D20")]
		[DebuggerNonUserCode]
		public MiningDataItemData()
		{
			//IL_004c: Expected I4, but got I8
			ItemWithState itemWithState = (result_ = new ItemWithState());
			weightPercentage_ = 1000;
			ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D331C0", Offset = "0x1D31BC0", VA = "0x181D331C0")]
		private void OnConstruction()
		{
			//IL_001a: Expected I4, but got I8
			ItemWithState itemWithState = (result_ = new ItemWithState());
			weightPercentage_ = 1000;
			ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D33B00", Offset = "0x1D32500", VA = "0x181D33B00")]
		[DebuggerNonUserCode]
		public MiningDataItemData(MiningDataItemData other)
		{
			//IL_004c: Expected I4, but got I8
			//IL_00c6: Expected O, but got I4
			ItemWithState itemWithState = (result_ = new ItemWithState());
			weightPercentage_ = 1000;
			ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			ItemWithState itemWithState2 = other.result_;
			int num2 = 0;
			if (itemWithState2 != null)
			{
				ItemWithState itemWithState3 = itemWithState2.Clone();
			}
			result_ = (ItemWithState)num2;
			ActivityDataLocationFilter activityDataLocationFilter2 = other.location_;
			ActivityDataLocationFilter activityDataLocationFilter3 = default(ActivityDataLocationFilter);
			if (activityDataLocationFilter2 != null)
			{
				activityDataLocationFilter3 = activityDataLocationFilter2.Clone();
			}
			location_ = activityDataLocationFilter3;
			bool flag = (isValuable_ = other.isValuable_);
			MiningRarity miningRarity = (rarity_ = other.rarity_);
			int num3 = (weightPercentage_ = other.weightPercentage_);
			int num4 = (failureProbabilityPerHit_ = other.failureProbabilityPerHit_);
			int num5 = (mininumNumberOfHits_ = other.mininumNumberOfHits_);
			int num6 = (maximumNumberOfHits_ = other.maximumNumberOfHits_);
			bool flag2 = (isHidden_ = other.isHidden_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D32610", Offset = "0x1D31010", VA = "0x181D32610", Slot = "10")]
		[DebuggerNonUserCode]
		public MiningDataItemData Clone()
		{
			return new MiningDataItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60030CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D326A0", Offset = "0x1D310A0", VA = "0x181D326A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MiningDataItemData).TypeHandle)
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
								if (!flag4 && object.Equals(result_, other))
								{
									bool flag5 = object.Equals(location_, other);
									if (flag5 && isValuable_ == flag5 && rarity_ == (flag5 ? MiningRarity.Uncommon : MiningRarity.Common) && weightPercentage_ == (flag5 ? 1 : 0) && failureProbabilityPerHit_ == (flag5 ? 1 : 0) && mininumNumberOfHits_ == (flag5 ? 1 : 0) && maximumNumberOfHits_ == (flag5 ? 1 : 0) && isHidden_ == flag5)
									{
										return object.Equals(_unknownFields, other);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D32810", Offset = "0x1D31210", VA = "0x181D32810", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiningDataItemData other)
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
									ItemWithState objB = other.result_;
									if (object.Equals(result_, objB))
									{
										ActivityDataLocationFilter objB2 = other.location_;
										if (object.Equals(location_, objB2))
										{
											bool flag = other.isValuable_;
											if (isValuable_ == flag)
											{
												MiningRarity miningRarity = other.rarity_;
												if (rarity_ == miningRarity)
												{
													int num2 = other.weightPercentage_;
													if (weightPercentage_ == num2)
													{
														int num3 = other.failureProbabilityPerHit_;
														if (failureProbabilityPerHit_ == num3)
														{
															int num4 = other.mininumNumberOfHits_;
															if (mininumNumberOfHits_ == num4)
															{
																int num5 = other.maximumNumberOfHits_;
																if (maximumNumberOfHits_ == num5)
																{
																	bool flag2 = other.isHidden_;
																	if (isHidden_ == flag2)
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
			}
			int num6 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D32B30", Offset = "0x1D31530", VA = "0x181D32B30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f3
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
			ItemWithState itemWithState = result_;
			if (itemWithState != null)
			{
				int hashCode5 = itemWithState.GetHashCode();
			}
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			if (activityDataLocationFilter != null)
			{
				int hashCode6 = activityDataLocationFilter.GetHashCode();
			}
			if (isValuable_)
			{
			}
			if (rarity_ != 0)
			{
			}
			if (weightPercentage_ != 0)
			{
			}
			if (failureProbabilityPerHit_ != 0)
			{
			}
			if (mininumNumberOfHits_ != 0)
			{
			}
			if (maximumNumberOfHits_ != 0)
			{
			}
			if (isHidden_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D336D0", Offset = "0x1D320D0", VA = "0x181D336D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60030D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D33730", Offset = "0x1D32130", VA = "0x181D33730", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0174
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
			if ((long)result_ != 0)
			{
				ItemWithState value6 = result_;
				output.WriteMessage(value6);
			}
			if ((long)location_ != 0)
			{
				ActivityDataLocationFilter value7 = location_;
				output.WriteMessage(value7);
			}
			if (isValuable_)
			{
				bool value8 = isValuable_;
				output.WriteBool(value8);
			}
			if (rarity_ != 0)
			{
			}
			if (weightPercentage_ != 0)
			{
				int value9 = weightPercentage_;
				output.WriteInt32(value9);
			}
			if (failureProbabilityPerHit_ != 0)
			{
				int value10 = failureProbabilityPerHit_;
				output.WriteInt32(value10);
			}
			if (mininumNumberOfHits_ != 0)
			{
				int value11 = mininumNumberOfHits_;
				output.WriteInt32(value11);
			}
			if (maximumNumberOfHits_ != 0)
			{
				int value12 = maximumNumberOfHits_;
				output.WriteInt32(value12);
			}
			if (isHidden_)
			{
				bool value13 = isHidden_;
				output.WriteBool(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60030D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D32150", Offset = "0x1D30B50", VA = "0x181D32150", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01ad
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
			ItemWithState itemWithState = result_;
			if (itemWithState != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(itemWithState);
				num8++;
				num2 += num8;
			}
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			if (activityDataLocationFilter != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(activityDataLocationFilter);
				num9++;
				num2 += num9;
			}
			MiningRarity miningRarity = rarity_;
			if (miningRarity != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)miningRarity);
				num10++;
				num2 += num10;
			}
			int num11 = weightPercentage_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = failureProbabilityPerHit_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			int num15 = mininumNumberOfHits_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			int num17 = maximumNumberOfHits_;
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

		[Cpp2IlInjected.Token(Token = "0x60030D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D32FC0", Offset = "0x1D319C0", VA = "0x181D32FC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiningDataItemData other)
		{
			//Discarded unreachable code: IL_01a3
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
			if ((long)other.result_ != 0)
			{
				ItemWithState itemWithState2 = default(ItemWithState);
				if (result_ == null)
				{
					ItemWithState itemWithState = (result_ = new ItemWithState());
					itemWithState2 = result_;
				}
				ItemWithState other2 = other.result_;
				itemWithState2.MergeFrom(other2);
			}
			if ((long)other.location_ != 0)
			{
				ActivityDataLocationFilter activityDataLocationFilter2 = default(ActivityDataLocationFilter);
				if (location_ == null)
				{
					ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
					activityDataLocationFilter2 = location_;
				}
				ActivityDataLocationFilter other3 = other.location_;
				activityDataLocationFilter2.MergeFrom(other3);
			}
			bool flag = other.isValuable_;
			if (flag)
			{
				isValuable_ = flag;
			}
			MiningRarity miningRarity = other.rarity_;
			if (miningRarity != 0)
			{
				rarity_ = miningRarity;
			}
			int num2 = other.weightPercentage_;
			if (num2 != 0)
			{
				weightPercentage_ = num2;
			}
			int num3 = other.failureProbabilityPerHit_;
			if (num3 != 0)
			{
				failureProbabilityPerHit_ = num3;
			}
			int num4 = other.mininumNumberOfHits_;
			if (num4 != 0)
			{
				mininumNumberOfHits_ = num4;
			}
			int num5 = other.maximumNumberOfHits_;
			if (num5 != 0)
			{
				maximumNumberOfHits_ = num5;
			}
			bool flag2 = other.isHidden_;
			if (flag2)
			{
				isHidden_ = flag2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60030D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D32D20", Offset = "0x1D31720", VA = "0x181D32D20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01bb
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 80)
				{
					if ((int)num > 96)
					{
						if (num == 104)
						{
							int num2 = (maximumNumberOfHits_ = input.ReadInt32());
						}
						if (num != 112)
						{
							goto IL_01a4;
						}
						bool flag = (isHidden_ = input.ReadBool());
					}
					int num3 = default(int);
					if (num == 88)
					{
						num3 = (failureProbabilityPerHit_ = input.ReadInt32());
					}
					if (num3 != 96)
					{
						goto IL_01a4;
					}
					int num4 = (mininumNumberOfHits_ = input.ReadInt32());
				}
				bool flag2 = default(bool);
				if (num == 64)
				{
					flag2 = (isValuable_ = input.ReadBool());
				}
				int num5 = default(int);
				if (flag2)
				{
					num5 = (int)(rarity_ = (MiningRarity)input.ReadInt32());
				}
				if (num5 != 80)
				{
					goto IL_01a4;
				}
				int num6 = (weightPercentage_ = input.ReadInt32());
			}
			string text4 = default(string);
			if ((int)num > 26)
			{
				ActivityDataLocationFilter activityDataLocationFilter = default(ActivityDataLocationFilter);
				if ((int)num > 42)
				{
					ItemWithState itemWithState = default(ItemWithState);
					if (num == 50)
					{
						ItemWithState builder = default(ItemWithState);
						if (result_ == null)
						{
							itemWithState = (result_ = new ItemWithState());
							builder = result_;
						}
						input.ReadMessage(builder);
					}
					if ((long)itemWithState != 58)
					{
						goto IL_01a4;
					}
					ActivityDataLocationFilter builder2 = default(ActivityDataLocationFilter);
					if (location_ == null)
					{
						activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
						builder2 = location_;
					}
					input.ReadMessage(builder2);
				}
				string text2 = default(string);
				if ((long)activityDataLocationFilter == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_01a4;
				}
				text4 = (PrefabAddress = input.ReadString());
			}
			int num7 = default(int);
			if ((long)text4 == 8)
			{
				num7 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num7 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_01a4;
			IL_01a4:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60030D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D32940", Offset = "0x1D31340", VA = "0x181D32940", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 13)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D33260", Offset = "0x1D31C60", VA = "0x181D33260", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_002c, IL_0034, IL_003c, IL_0044, IL_004c, IL_0054, IL_005c, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			if (fieldNumber - 1 <= 13)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D32450", Offset = "0x1D30E50", VA = "0x181D32450", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 13)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D32610", Offset = "0x1D31010", VA = "0x181D32610", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MiningDataItemData miningDataItemData = new MiningDataItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D32690", Offset = "0x1D31090", VA = "0x181D32690", Slot = "21")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			mininumNumberOfHits_ = 2;
			maximumNumberOfHits_ = 2;
		}

		[Cpp2IlInjected.Token(Token = "0x60030DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D339F0", Offset = "0x1D323F0", VA = "0x181D339F0")]
		static MiningDataItemData()
		{
			Func<MiningDataItemData> func = default(Func<MiningDataItemData>);
			_parser = (MessageParser<MiningDataItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
