using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002D9")]
	public sealed class UpgradeData : IMessage<UpgradeData>, IMessage, IEquatable<UpgradeData>, IDeepCloneable<UpgradeData>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20002DA")]
		public enum BenefitsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000D0B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000D0C")]
			Fishing = 10,
			[Cpp2IlInjected.Token(Token = "0x4000D0D")]
			Gardening = 11,
			[Cpp2IlInjected.Token(Token = "0x4000D0E")]
			Kitchen = 12,
			[Cpp2IlInjected.Token(Token = "0x4000D0F")]
			Garden = 13,
			[Cpp2IlInjected.Token(Token = "0x4000D10")]
			House = 14,
			[Cpp2IlInjected.Token(Token = "0x4000D11")]
			Restaurant = 15,
			[Cpp2IlInjected.Token(Token = "0x4000D12")]
			Store = 16
		}

		[Cpp2IlInjected.Token(Token = "0x4000CF5")]
		private static readonly MessageParser<UpgradeData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000CF6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000CF7")]
		public const int LevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000CF8")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x4000CF9")]
		public const int PlayerLevelFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000CFA")]
		private int playerLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000CFB")]
		public const int CostFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000CFC")]
		private CurrencyCost cost_;

		[Cpp2IlInjected.Token(Token = "0x4000CFD")]
		public const int PrefabAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000CFE")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CFF")]
		public const int UpgradeDialogueAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000D00")]
		private string upgradeDialogueAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000D01")]
		public const int FishingFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000D02")]
		public const int GardeningFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000D03")]
		public const int KitchenFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000D04")]
		public const int GardenFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4000D05")]
		public const int HouseFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4000D06")]
		public const int RestaurantFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4000D07")]
		public const int StoreFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000D08")]
		private object benefits_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000D09")]
		private BenefitsOneofCase benefitsCase_;

		[Cpp2IlInjected.Token(Token = "0x1700071E")]
		[DebuggerNonUserCode]
		public static MessageParser<UpgradeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001EDE")]
			[Cpp2IlInjected.Address(RVA = "0x355BD30", Offset = "0x355A730", VA = "0x18355BD30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001EDF")]
			[Cpp2IlInjected.Address(RVA = "0x355BA80", Offset = "0x355A480", VA = "0x18355BA80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000720")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE0")]
			[Cpp2IlInjected.Address(RVA = "0x355BE50", Offset = "0x355A850", VA = "0x18355BE50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000721")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EE6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000722")]
		[DebuggerNonUserCode]
		public int PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE7")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return playerLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EE8")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				playerLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000723")]
		[DebuggerNonUserCode]
		public CurrencyCost Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return cost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EEA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				cost_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000724")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001EEB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EEC")]
			[Cpp2IlInjected.Address(RVA = "0x355C0A0", Offset = "0x355AAA0", VA = "0x18355C0A0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000725")]
		[DebuggerNonUserCode]
		public string UpgradeDialogueAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001EED")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return upgradeDialogueAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EEE")]
			[Cpp2IlInjected.Address(RVA = "0x355C190", Offset = "0x355AB90", VA = "0x18355C190")]
			set
			{
				string text = (upgradeDialogueAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000726")]
		[DebuggerNonUserCode]
		public BenefitsFishingData Fishing
		{
			[Cpp2IlInjected.Token(Token = "0x6001EEF")]
			[Cpp2IlInjected.Address(RVA = "0x355BB50", Offset = "0x355A550", VA = "0x18355BB50")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.Fishing)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EF0")]
			[Cpp2IlInjected.Address(RVA = "0x355BF60", Offset = "0x355A960", VA = "0x18355BF60")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000727")]
		[DebuggerNonUserCode]
		public BenefitsGardeningData Gardening
		{
			[Cpp2IlInjected.Token(Token = "0x6001EF1")]
			[Cpp2IlInjected.Address(RVA = "0x355BC10", Offset = "0x355A610", VA = "0x18355BC10")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.Gardening)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EF2")]
			[Cpp2IlInjected.Address(RVA = "0x355BFE0", Offset = "0x355A9E0", VA = "0x18355BFE0")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000728")]
		[DebuggerNonUserCode]
		public BenefitsKitchenData Kitchen
		{
			[Cpp2IlInjected.Token(Token = "0x6001EF3")]
			[Cpp2IlInjected.Address(RVA = "0x355BCD0", Offset = "0x355A6D0", VA = "0x18355BCD0")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.Kitchen)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EF4")]
			[Cpp2IlInjected.Address(RVA = "0x355C060", Offset = "0x355AA60", VA = "0x18355C060")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000729")]
		[DebuggerNonUserCode]
		public BenefitsGardenData Garden
		{
			[Cpp2IlInjected.Token(Token = "0x6001EF5")]
			[Cpp2IlInjected.Address(RVA = "0x355BBB0", Offset = "0x355A5B0", VA = "0x18355BBB0")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.Garden)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EF6")]
			[Cpp2IlInjected.Address(RVA = "0x355BFA0", Offset = "0x355A9A0", VA = "0x18355BFA0")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072A")]
		[DebuggerNonUserCode]
		public BenefitsHouseData House
		{
			[Cpp2IlInjected.Token(Token = "0x6001EF7")]
			[Cpp2IlInjected.Address(RVA = "0x355BC70", Offset = "0x355A670", VA = "0x18355BC70")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.House)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EF8")]
			[Cpp2IlInjected.Address(RVA = "0x355C020", Offset = "0x355AA20", VA = "0x18355C020")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072B")]
		[DebuggerNonUserCode]
		public BenefitsRestaurantData Restaurant
		{
			[Cpp2IlInjected.Token(Token = "0x6001EF9")]
			[Cpp2IlInjected.Address(RVA = "0x355BD90", Offset = "0x355A790", VA = "0x18355BD90")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.Restaurant)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EFA")]
			[Cpp2IlInjected.Address(RVA = "0x355C110", Offset = "0x355AB10", VA = "0x18355C110")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072C")]
		[DebuggerNonUserCode]
		public BenefitsStoreData Store
		{
			[Cpp2IlInjected.Token(Token = "0x6001EFB")]
			[Cpp2IlInjected.Address(RVA = "0x355BDF0", Offset = "0x355A7F0", VA = "0x18355BDF0")]
			get
			{
				int num = 0;
				if (benefitsCase_ == BenefitsOneofCase.Store)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001EFC")]
			[Cpp2IlInjected.Address(RVA = "0x355C150", Offset = "0x355AB50", VA = "0x18355C150")]
			set
			{
				benefits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072D")]
		[DebuggerNonUserCode]
		public BenefitsOneofCase BenefitsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001EFD")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return benefitsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072E")]
		public object Benefits
		{
			[Cpp2IlInjected.Token(Token = "0x6001F0C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return benefits_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE1")]
		[Cpp2IlInjected.Address(RVA = "0x355B9D0", Offset = "0x355A3D0", VA = "0x18355B9D0")]
		[DebuggerNonUserCode]
		public UpgradeData()
		{
			CurrencyCost currencyCost = (cost_ = new CurrencyCost());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE2")]
		[Cpp2IlInjected.Address(RVA = "0x355ABE0", Offset = "0x35595E0", VA = "0x18355ABE0")]
		private void OnConstruction()
		{
			CurrencyCost currencyCost = (cost_ = new CurrencyCost());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE3")]
		[Cpp2IlInjected.Address(RVA = "0x355B6B0", Offset = "0x355A0B0", VA = "0x18355B6B0")]
		[DebuggerNonUserCode]
		public UpgradeData(UpgradeData other)
		{
			//IL_0063: Expected O, but got I4
			//IL_012a: Expected I4, but got O
			CurrencyCost currencyCost = (cost_ = new CurrencyCost());
			int num = (level_ = other.level_);
			int num2 = (playerLevel_ = other.playerLevel_);
			CurrencyCost currencyCost2 = other.cost_;
			if (currencyCost2 != null)
			{
				CurrencyCost currencyCost3 = currencyCost2.Clone();
			}
			int num3 = 0;
			cost_ = (CurrencyCost)num3;
			string text = (prefabAddress_ = other.prefabAddress_);
			string text2 = (upgradeDialogueAddress_ = other.upgradeDialogueAddress_);
			if (other.benefitsCase_ <= (BenefitsOneofCase)6)
			{
				BenefitsFishingData benefitsFishingData = (BenefitsFishingData)(benefits_ = other.Fishing.Clone());
				BenefitsGardeningData benefitsGardeningData = (BenefitsGardeningData)(benefits_ = other.Gardening.Clone());
				BenefitsKitchenData benefitsKitchenData = (BenefitsKitchenData)(benefits_ = other.Kitchen.Clone());
				BenefitsGardenData benefitsGardenData = (BenefitsGardenData)(benefits_ = other.Garden.Clone());
				BenefitsHouseData benefitsHouseData = (BenefitsHouseData)(benefits_ = other.House.Clone());
				BenefitsRestaurantData benefitsRestaurantData = (BenefitsRestaurantData)(benefits_ = other.Restaurant.Clone());
				benefitsCase_ = (BenefitsOneofCase)(benefits_ = other.Store.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE4")]
		[Cpp2IlInjected.Address(RVA = "0x35596E0", Offset = "0x35580E0", VA = "0x1835596E0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpgradeData Clone()
		{
			return new UpgradeData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EFE")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearBenefits()
		{
			//IL_0010: Expected O, but got I4
			benefits_ = (benefitsCase_ = BenefitsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EFF")]
		[Cpp2IlInjected.Address(RVA = "0x3559740", Offset = "0x3558140", VA = "0x183559740", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((UpgradeData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F00")]
		[Cpp2IlInjected.Address(RVA = "0x35597A0", Offset = "0x35581A0", VA = "0x1835597A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpgradeData other)
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
					int num2 = other.playerLevel_;
					if (playerLevel_ == num2)
					{
						CurrencyCost objB = other.cost_;
						if (object.Equals(cost_, objB))
						{
							string text = other.prefabAddress_;
							if (!(prefabAddress_ != text))
							{
								string text2 = other.upgradeDialogueAddress_;
								if (!(upgradeDialogueAddress_ != text2))
								{
									BenefitsFishingData fishing = Fishing;
									BenefitsFishingData fishing2 = other.Fishing;
									if (object.Equals(fishing, fishing2))
									{
										BenefitsGardeningData gardening = Gardening;
										BenefitsGardeningData gardening2 = other.Gardening;
										if (object.Equals(gardening, gardening2))
										{
											BenefitsKitchenData kitchen = Kitchen;
											BenefitsKitchenData kitchen2 = other.Kitchen;
											if (object.Equals(kitchen, kitchen2))
											{
												BenefitsGardenData garden = Garden;
												BenefitsGardenData garden2 = other.Garden;
												if (object.Equals(garden, garden2))
												{
													BenefitsHouseData house = House;
													BenefitsHouseData house2 = other.House;
													if (object.Equals(house, house2))
													{
														BenefitsRestaurantData restaurant = Restaurant;
														BenefitsRestaurantData restaurant2 = other.Restaurant;
														if (object.Equals(restaurant, restaurant2))
														{
															BenefitsStoreData store = Store;
															BenefitsStoreData store2 = other.Store;
															if (object.Equals(store, store2))
															{
																BenefitsOneofCase benefitsOneofCase = other.benefitsCase_;
																if (benefitsCase_ == benefitsOneofCase)
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F01")]
		[Cpp2IlInjected.Address(RVA = "0x3559B80", Offset = "0x3558580", VA = "0x183559B80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0174
			while (true)
			{
				int num = level_;
				int num2 = 0;
				if (num != 0)
				{
				}
				if (playerLevel_ != 0)
				{
				}
				CurrencyCost currencyCost = cost_;
				if (currencyCost != null)
				{
					int hashCode = currencyCost.GetHashCode();
				}
				string text = prefabAddress_;
				if (text.m_stringLength != num2)
				{
					int hashCode2 = text.GetHashCode();
				}
				string text2 = upgradeDialogueAddress_;
				if (text2.m_stringLength != num2)
				{
					int hashCode3 = text2.GetHashCode();
				}
				if (benefitsCase_ != BenefitsOneofCase.Fishing)
				{
					continue;
				}
				object obj = benefits_;
				if (obj != null)
				{
					int hashCode4 = obj.GetHashCode();
					if (benefitsCase_ != BenefitsOneofCase.Gardening)
					{
						continue;
					}
					object obj2 = benefits_;
					if (obj2 != null)
					{
						int hashCode5 = obj2.GetHashCode();
						if (benefitsCase_ != BenefitsOneofCase.Kitchen)
						{
							continue;
						}
						object obj3 = benefits_;
						if (obj3 != null)
						{
							int hashCode6 = obj3.GetHashCode();
							if (benefitsCase_ != BenefitsOneofCase.Garden)
							{
								continue;
							}
							object obj4 = benefits_;
							if (obj4 != null)
							{
								int hashCode7 = obj4.GetHashCode();
								if (benefitsCase_ != BenefitsOneofCase.House)
								{
									continue;
								}
								object obj5 = benefits_;
								if (obj5 != null)
								{
									int hashCode8 = obj5.GetHashCode();
									if (benefitsCase_ != BenefitsOneofCase.Restaurant)
									{
										continue;
									}
									object obj6 = benefits_;
									if (obj6 != null)
									{
										int hashCode9 = obj6.GetHashCode();
										if (benefitsCase_ == BenefitsOneofCase.Store)
										{
											object obj7 = benefits_;
											if (obj7 == null)
											{
												break;
											}
											int hashCode10 = obj7.GetHashCode();
										}
										UnknownFieldSet unknownFields = _unknownFields;
										if (unknownFields != null)
										{
											int hashCode11 = unknownFields.GetHashCode();
										}
										return 1;
									}
								}
								throw new InvalidCastException();
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F02")]
		[Cpp2IlInjected.Address(RVA = "0x355B0D0", Offset = "0x3559AD0", VA = "0x18355B0D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F03")]
		[Cpp2IlInjected.Address(RVA = "0x355B130", Offset = "0x3559B30", VA = "0x18355B130", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01c9
			while (true)
			{
				if (level_ != 0)
				{
					int value = level_;
					output.WriteInt32(value);
				}
				if (playerLevel_ != 0)
				{
					int value2 = playerLevel_;
					output.WriteInt32(value2);
				}
				if ((long)cost_ != 0)
				{
					CurrencyCost value3 = cost_;
					output.WriteMessage(value3);
				}
				if (prefabAddress_.m_stringLength != 0)
				{
					string value4 = prefabAddress_;
					output.WriteString(value4);
				}
				if (upgradeDialogueAddress_.m_stringLength != 0)
				{
					string value5 = upgradeDialogueAddress_;
					output.WriteString(value5);
				}
				BenefitsOneofCase benefitsOneofCase = benefitsCase_;
				int num = 0;
				if (benefitsOneofCase != BenefitsOneofCase.Fishing)
				{
					continue;
				}
				if (benefitsCase_ == BenefitsOneofCase.Fishing)
				{
					object obj = benefits_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (benefitsCase_ != BenefitsOneofCase.Gardening)
				{
					continue;
				}
				if (benefitsCase_ == BenefitsOneofCase.Gardening)
				{
					object obj2 = benefits_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (benefitsCase_ != BenefitsOneofCase.Kitchen)
				{
					continue;
				}
				if (benefitsCase_ == BenefitsOneofCase.Kitchen)
				{
					object obj3 = benefits_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (benefitsCase_ != BenefitsOneofCase.Garden)
				{
					continue;
				}
				if (benefitsCase_ == BenefitsOneofCase.Garden)
				{
					object obj4 = benefits_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (benefitsCase_ != BenefitsOneofCase.House)
				{
					continue;
				}
				if (benefitsCase_ == BenefitsOneofCase.House)
				{
					object obj5 = benefits_;
					if (obj5 != null && obj5 == null)
					{
						break;
					}
				}
				if (benefitsCase_ != BenefitsOneofCase.Restaurant)
				{
					continue;
				}
				if (benefitsCase_ == BenefitsOneofCase.Restaurant)
				{
					object obj6 = benefits_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (benefitsCase_ == BenefitsOneofCase.Store && benefitsCase_ == BenefitsOneofCase.Store)
				{
					object obj7 = benefits_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F04")]
		[Cpp2IlInjected.Address(RVA = "0x3559050", Offset = "0x3557A50", VA = "0x183559050", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0217
			int num = level_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = playerLevel_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			CurrencyCost currencyCost = cost_;
			if (currencyCost != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(currencyCost);
				num6++;
				num2 += num6;
			}
			string text = prefabAddress_;
			if (text.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text);
				num7++;
				num2 += num7;
			}
			string text2 = upgradeDialogueAddress_;
			if (text2.m_stringLength != num2)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text2);
				num8++;
				num2 += num8;
			}
			if (benefitsCase_ == BenefitsOneofCase.Fishing)
			{
				if (benefitsCase_ != BenefitsOneofCase.Fishing)
				{
				}
				object obj = benefits_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num9 = default(int);
				num2 += num9;
			}
			if (benefitsCase_ == BenefitsOneofCase.Gardening)
			{
				if (benefitsCase_ != BenefitsOneofCase.Gardening)
				{
				}
				object obj2 = benefits_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num10 = default(int);
				num2 += num10;
			}
			if (benefitsCase_ == BenefitsOneofCase.Kitchen)
			{
				if (benefitsCase_ != BenefitsOneofCase.Kitchen)
				{
				}
				object obj3 = benefits_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num11 = default(int);
				num2 += num11;
			}
			if (benefitsCase_ == BenefitsOneofCase.Garden)
			{
				if (benefitsCase_ != BenefitsOneofCase.Garden)
				{
				}
				object obj4 = benefits_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num12 = default(int);
				num2 += num12;
			}
			if (benefitsCase_ == BenefitsOneofCase.House)
			{
				if (benefitsCase_ != BenefitsOneofCase.House)
				{
				}
				object obj5 = benefits_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num13 = default(int);
				num2 += num13;
			}
			if (benefitsCase_ == BenefitsOneofCase.Restaurant)
			{
				if (benefitsCase_ != BenefitsOneofCase.Restaurant)
				{
				}
				object obj6 = benefits_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num14 = default(int);
				num2 += num14;
			}
			if (benefitsCase_ == BenefitsOneofCase.Store)
			{
				if (benefitsCase_ == BenefitsOneofCase.Store)
				{
					object obj7 = benefits_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num15 = default(int);
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F05")]
		[Cpp2IlInjected.Address(RVA = "0x355A700", Offset = "0x3559100", VA = "0x18355A700", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpgradeData other)
		{
			//Discarded unreachable code: IL_0252
			//IL_00c3: Expected I4, but got O
			//IL_00fc: Expected I4, but got O
			//IL_0135: Expected I4, but got O
			//IL_016e: Expected I4, but got O
			//IL_01a7: Expected I4, but got O
			//IL_01e0: Expected I4, but got O
			//IL_0219: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			int num = other.level_;
			if (num != 0)
			{
				level_ = num;
			}
			int num2 = other.playerLevel_;
			if (num2 != 0)
			{
				playerLevel_ = num2;
			}
			if ((long)other.cost_ != 0)
			{
				CurrencyCost currencyCost2 = default(CurrencyCost);
				if (cost_ == null)
				{
					CurrencyCost currencyCost = (cost_ = new CurrencyCost());
					currencyCost2 = cost_;
				}
				CurrencyCost other2 = other.cost_;
				currencyCost2.MergeFrom(other2);
			}
			string text = other.prefabAddress_;
			if (text.m_stringLength != 0)
			{
				PrefabAddress = text;
			}
			string text2 = other.upgradeDialogueAddress_;
			if (text2.m_stringLength != 0)
			{
				UpgradeDialogueAddress = text2;
			}
			if (other.benefitsCase_ <= (BenefitsOneofCase)6)
			{
				if (Fishing == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsFishingData());
				}
				BenefitsFishingData fishing = Fishing;
				BenefitsFishingData fishing2 = other.Fishing;
				fishing.MergeFrom(fishing2);
				if (Gardening == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsGardeningData());
				}
				BenefitsGardeningData gardening = Gardening;
				BenefitsGardeningData gardening2 = other.Gardening;
				gardening.MergeFrom(gardening2);
				if (Kitchen == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsKitchenData());
				}
				BenefitsKitchenData kitchen = Kitchen;
				BenefitsKitchenData kitchen2 = other.Kitchen;
				kitchen.MergeFrom(kitchen2);
				if (Garden == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsGardenData());
				}
				BenefitsGardenData garden = Garden;
				BenefitsGardenData garden2 = other.Garden;
				garden.MergeFrom(garden2);
				if (House == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsHouseData());
				}
				BenefitsHouseData house = House;
				BenefitsHouseData house2 = other.House;
				house.MergeFrom(house2);
				if (Restaurant == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsRestaurantData());
				}
				BenefitsRestaurantData restaurant = Restaurant;
				BenefitsRestaurantData restaurant2 = other.Restaurant;
				restaurant.MergeFrom(restaurant2);
				if (Store == null)
				{
					benefitsCase_ = (BenefitsOneofCase)(benefits_ = new BenefitsStoreData());
				}
				BenefitsStoreData store = Store;
				BenefitsStoreData store2 = other.Store;
				store.MergeFrom(store2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001F06")]
		[Cpp2IlInjected.Address(RVA = "0x355A020", Offset = "0x3558A20", VA = "0x18355A020", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0068: Expected I4, but got O
			//IL_00b6: Expected I4, but got O
			//IL_0112: Expected I4, but got O
			//IL_0163: Expected I4, but got O
			//IL_01b9: Expected I4, but got O
			//IL_0212: Expected I4, but got O
			//IL_029f: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 82)
			{
				if ((int)num > 106)
				{
					if (num == 114)
					{
						BenefitsHouseData benefitsHouseData = new BenefitsHouseData();
						if (benefitsCase_ == BenefitsOneofCase.House)
						{
							if (benefitsCase_ != BenefitsOneofCase.House)
							{
							}
							object obj = benefits_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(benefitsHouseData);
						benefits_ = benefitsHouseData;
						benefitsCase_ = (BenefitsOneofCase)benefitsHouseData;
					}
					if (num == 122)
					{
						BenefitsRestaurantData builder = new BenefitsRestaurantData();
						if (benefitsCase_ == BenefitsOneofCase.Restaurant)
						{
							if (benefitsCase_ != BenefitsOneofCase.Restaurant)
							{
							}
							object obj2 = benefits_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						benefits_ = builder;
						benefitsCase_ = (BenefitsOneofCase)typeof(BenefitsRestaurantData).TypeHandle;
					}
					if ((long)typeof(BenefitsRestaurantData).TypeHandle != 130)
					{
						goto IL_02fd;
					}
					BenefitsStoreData builder2 = new BenefitsStoreData();
					if (benefitsCase_ == BenefitsOneofCase.Store)
					{
						if (benefitsCase_ != BenefitsOneofCase.Store)
						{
						}
						object obj3 = benefits_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					benefits_ = builder2;
					benefitsCase_ = (BenefitsOneofCase)typeof(BenefitsStoreData).TypeHandle;
				}
				if (num == 90)
				{
					BenefitsGardeningData builder3 = new BenefitsGardeningData();
					if (benefitsCase_ == BenefitsOneofCase.Gardening)
					{
						if (benefitsCase_ != BenefitsOneofCase.Gardening)
						{
						}
						object obj4 = benefits_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					benefits_ = builder3;
					benefitsCase_ = (BenefitsOneofCase)typeof(BenefitsGardeningData).TypeHandle;
				}
				if ((long)typeof(BenefitsGardeningData).TypeHandle == 98)
				{
					BenefitsKitchenData builder4 = new BenefitsKitchenData();
					if (benefitsCase_ == BenefitsOneofCase.Kitchen)
					{
						if (benefitsCase_ != BenefitsOneofCase.Kitchen)
						{
						}
						object obj5 = benefits_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					benefits_ = builder4;
					benefitsCase_ = (BenefitsOneofCase)typeof(BenefitsKitchenData).TypeHandle;
				}
				if ((long)typeof(BenefitsKitchenData).TypeHandle != 106)
				{
					goto IL_02fd;
				}
				BenefitsGardenData builder5 = new BenefitsGardenData();
				if (benefitsCase_ == BenefitsOneofCase.Garden)
				{
					if (benefitsCase_ != BenefitsOneofCase.Garden)
					{
					}
					object obj6 = benefits_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder5);
				benefits_ = builder5;
				benefitsCase_ = (BenefitsOneofCase)typeof(BenefitsGardenData).TypeHandle;
			}
			if ((int)num > 26)
			{
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (UpgradeDialogueAddress = input.ReadString());
				}
				if ((long)text4 != 82)
				{
					goto IL_02fd;
				}
				BenefitsFishingData builder6 = new BenefitsFishingData();
				if (benefitsCase_ == BenefitsOneofCase.Fishing)
				{
					if (benefitsCase_ != BenefitsOneofCase.Fishing)
					{
					}
					object obj7 = benefits_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder6);
				benefits_ = builder6;
				benefitsCase_ = (BenefitsOneofCase)typeof(BenefitsFishingData).TypeHandle;
			}
			int num2 = default(int);
			if ((long)typeof(BenefitsFishingData).TypeHandle == 8)
			{
				num2 = (level_ = input.ReadInt32());
			}
			int num3 = default(int);
			if (num2 == 16)
			{
				num3 = (playerLevel_ = input.ReadInt32());
			}
			if (num3 == 26)
			{
				CurrencyCost builder7 = default(CurrencyCost);
				if (cost_ == null)
				{
					CurrencyCost currencyCost = (cost_ = new CurrencyCost());
					builder7 = cost_;
				}
				input.ReadMessage(builder7);
			}
			goto IL_02fd;
			IL_02fd:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001F07")]
		[Cpp2IlInjected.Address(RVA = "0x35599B0", Offset = "0x35583B0", VA = "0x1835599B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 15)
			{
				int num = level_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F08")]
		[Cpp2IlInjected.Address(RVA = "0x355AC40", Offset = "0x3559640", VA = "0x18355AC40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0016, IL_001d, IL_0021, IL_0028, IL_0029, IL_002d, IL_0031, IL_0032, IL_0036, IL_003b, IL_003f, IL_0043, IL_0044, IL_0048, IL_004c, IL_004d, IL_0051, IL_0055, IL_0056, IL_005a, IL_005e, IL_005f, IL_0063, IL_0067, IL_0068, IL_006c, IL_0070, IL_0071, IL_0077, IL_007d, IL_0083, IL_0089, IL_008f, IL_0095, IL_009b, IL_00a1, IL_00a7
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 15)
			{
				object obj = default(object);
				level_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F09")]
		[Cpp2IlInjected.Address(RVA = "0x3559550", Offset = "0x3557F50", VA = "0x183559550", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_001b, IL_0030, IL_003c
			//IL_0024: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			if (fieldNumber - 1 <= 15)
			{
				int num = (level_ = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F0A")]
		[Cpp2IlInjected.Address(RVA = "0x3559F70", Offset = "0x3558970", VA = "0x183559F70", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Benefits"))
			{
				BenefitsOneofCase benefitsOneofCase = benefitsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F0B")]
		[Cpp2IlInjected.Address(RVA = "0x3559670", Offset = "0x3558070", VA = "0x183559670", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Benefits"))
			{
				benefits_ = (benefitsCase_ = BenefitsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F0D")]
		[Cpp2IlInjected.Address(RVA = "0x355B5A0", Offset = "0x3559FA0", VA = "0x18355B5A0")]
		static UpgradeData()
		{
			Func<UpgradeData> func = default(Func<UpgradeData>);
			_parser = (MessageParser<UpgradeData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
