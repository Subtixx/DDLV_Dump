using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000599")]
	public sealed class DutyStepDifficulty : IMessage<DutyStepDifficulty>, IMessage, IEquatable<DutyStepDifficulty>, IDeepCloneable<DutyStepDifficulty>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, ICustomStepOwner, IItemSelector, IItemGeneratorOwner
	{
		[Cpp2IlInjected.Token(Token = "0x200059A")]
		public enum DifficultyStepOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001E69")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001E6A")]
			BringItem = 10,
			[Cpp2IlInjected.Token(Token = "0x4001E6B")]
			CatchFish = 11,
			[Cpp2IlInjected.Token(Token = "0x4001E6C")]
			CollectCurrency = 12,
			[Cpp2IlInjected.Token(Token = "0x4001E6D")]
			CookMeal = 13,
			[Cpp2IlInjected.Token(Token = "0x4001E6E")]
			DesignChallenge = 15,
			[Cpp2IlInjected.Token(Token = "0x4001E6F")]
			GardeningHarvest = 16,
			[Cpp2IlInjected.Token(Token = "0x4001E70")]
			GardeningPlant = 17,
			[Cpp2IlInjected.Token(Token = "0x4001E71")]
			PickUp = 18,
			[Cpp2IlInjected.Token(Token = "0x4001E72")]
			SellItem = 19,
			[Cpp2IlInjected.Token(Token = "0x4001E73")]
			TakePicture = 20,
			[Cpp2IlInjected.Token(Token = "0x4001E74")]
			DressUp = 21,
			[Cpp2IlInjected.Token(Token = "0x4001E75")]
			GiftToCharacter = 22,
			[Cpp2IlInjected.Token(Token = "0x4001E76")]
			StartDiscussion = 23,
			[Cpp2IlInjected.Token(Token = "0x4001E77")]
			MineMineral = 24,
			[Cpp2IlInjected.Token(Token = "0x4001E78")]
			WaterPlant = 25,
			[Cpp2IlInjected.Token(Token = "0x4001E79")]
			FeedCritter = 26,
			[Cpp2IlInjected.Token(Token = "0x4001E7A")]
			MakeFriend = 27,
			[Cpp2IlInjected.Token(Token = "0x4001E7B")]
			Upgrade = 28,
			[Cpp2IlInjected.Token(Token = "0x4001E7C")]
			Unlock = 29,
			[Cpp2IlInjected.Token(Token = "0x4001E7D")]
			ExpandHouse = 30,
			[Cpp2IlInjected.Token(Token = "0x4001E7E")]
			EatMeal = 31,
			[Cpp2IlInjected.Token(Token = "0x4001E7F")]
			ServeRestaurantOrder = 56
		}

		[Cpp2IlInjected.Token(Token = "0x4001E4A")]
		private static readonly MessageParser<DutyStepDifficulty> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E4B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001E4C")]
		public const int BringItemFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001E4D")]
		public const int CatchFishFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4001E4E")]
		public const int CollectCurrencyFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4001E4F")]
		public const int CookMealFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4001E50")]
		public const int DesignChallengeFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4001E51")]
		public const int GardeningHarvestFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4001E52")]
		public const int GardeningPlantFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x4001E53")]
		public const int PickUpFieldNumber = 18;

		[Cpp2IlInjected.Token(Token = "0x4001E54")]
		public const int SellItemFieldNumber = 19;

		[Cpp2IlInjected.Token(Token = "0x4001E55")]
		public const int TakePictureFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x4001E56")]
		public const int DressUpFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x4001E57")]
		public const int GiftToCharacterFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x4001E58")]
		public const int StartDiscussionFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x4001E59")]
		public const int MineMineralFieldNumber = 24;

		[Cpp2IlInjected.Token(Token = "0x4001E5A")]
		public const int WaterPlantFieldNumber = 25;

		[Cpp2IlInjected.Token(Token = "0x4001E5B")]
		public const int FeedCritterFieldNumber = 26;

		[Cpp2IlInjected.Token(Token = "0x4001E5C")]
		public const int MakeFriendFieldNumber = 27;

		[Cpp2IlInjected.Token(Token = "0x4001E5D")]
		public const int UpgradeFieldNumber = 28;

		[Cpp2IlInjected.Token(Token = "0x4001E5E")]
		public const int UnlockFieldNumber = 29;

		[Cpp2IlInjected.Token(Token = "0x4001E5F")]
		public const int ExpandHouseFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x4001E60")]
		public const int EatMealFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4001E61")]
		public const int ServeRestaurantOrderFieldNumber = 56;

		[Cpp2IlInjected.Token(Token = "0x4001E62")]
		public const int AvailableWhenFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E63")]
		private ConditionsList availableWhen_;

		[Cpp2IlInjected.Token(Token = "0x4001E64")]
		public const int DustRewardFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E65")]
		private int dustReward_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E66")]
		private object difficultyStep_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E67")]
		private DifficultyStepOneofCase difficultyStepCase_;

		[Cpp2IlInjected.Token(Token = "0x170011EE")]
		[DebuggerNonUserCode]
		public static MessageParser<DutyStepDifficulty> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600459A")]
			[Cpp2IlInjected.Address(RVA = "0x2C54870", Offset = "0x2C53270", VA = "0x182C54870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011EF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600459B")]
			[Cpp2IlInjected.Address(RVA = "0x2C542E0", Offset = "0x2C52CE0", VA = "0x182C542E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600459C")]
			[Cpp2IlInjected.Address(RVA = "0x2C54C90", Offset = "0x2C53690", VA = "0x182C54C90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F1")]
		[DebuggerNonUserCode]
		public CustomStepBringItem BringItem
		{
			[Cpp2IlInjected.Token(Token = "0x60045A0")]
			[Cpp2IlInjected.Address(RVA = "0x2C54160", Offset = "0x2C52B60", VA = "0x182C54160")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045A1")]
			[Cpp2IlInjected.Address(RVA = "0x2C54DA0", Offset = "0x2C537A0", VA = "0x182C54DA0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F2")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish CatchFish
		{
			[Cpp2IlInjected.Token(Token = "0x60045A2")]
			[Cpp2IlInjected.Address(RVA = "0x2C541C0", Offset = "0x2C52BC0", VA = "0x182C541C0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.CatchFish)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045A3")]
			[Cpp2IlInjected.Address(RVA = "0x2C54DE0", Offset = "0x2C537E0", VA = "0x182C54DE0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F3")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency CollectCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x60045A4")]
			[Cpp2IlInjected.Address(RVA = "0x2C54220", Offset = "0x2C52C20", VA = "0x182C54220")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.CollectCurrency)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C54E20", Offset = "0x2C53820", VA = "0x182C54E20")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F4")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal CookMeal
		{
			[Cpp2IlInjected.Token(Token = "0x60045A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C54280", Offset = "0x2C52C80", VA = "0x182C54280")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.CookMeal)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045A7")]
			[Cpp2IlInjected.Address(RVA = "0x2C54E60", Offset = "0x2C53860", VA = "0x182C54E60")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F5")]
		[DebuggerNonUserCode]
		public CustomStepDesignChallenge DesignChallenge
		{
			[Cpp2IlInjected.Token(Token = "0x60045A8")]
			[Cpp2IlInjected.Address(RVA = "0x2C543B0", Offset = "0x2C52DB0", VA = "0x182C543B0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.DesignChallenge)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045A9")]
			[Cpp2IlInjected.Address(RVA = "0x2C54EA0", Offset = "0x2C538A0", VA = "0x182C54EA0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F6")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest GardeningHarvest
		{
			[Cpp2IlInjected.Token(Token = "0x60045AA")]
			[Cpp2IlInjected.Address(RVA = "0x2C54590", Offset = "0x2C52F90", VA = "0x182C54590")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningHarvest)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C54FE0", Offset = "0x2C539E0", VA = "0x182C54FE0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F7")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant GardeningPlant
		{
			[Cpp2IlInjected.Token(Token = "0x60045AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C545F0", Offset = "0x2C52FF0", VA = "0x182C545F0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningPlant)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C55020", Offset = "0x2C53A20", VA = "0x182C55020")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F8")]
		[DebuggerNonUserCode]
		public CustomStepPickUp PickUp
		{
			[Cpp2IlInjected.Token(Token = "0x60045AE")]
			[Cpp2IlInjected.Address(RVA = "0x2C548D0", Offset = "0x2C532D0", VA = "0x182C548D0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.PickUp)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045AF")]
			[Cpp2IlInjected.Address(RVA = "0x2C55120", Offset = "0x2C53B20", VA = "0x182C55120")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011F9")]
		[DebuggerNonUserCode]
		public CustomStepSellItem SellItem
		{
			[Cpp2IlInjected.Token(Token = "0x60045B0")]
			[Cpp2IlInjected.Address(RVA = "0x2C54930", Offset = "0x2C53330", VA = "0x182C54930")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.SellItem)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045B1")]
			[Cpp2IlInjected.Address(RVA = "0x2C55160", Offset = "0x2C53B60", VA = "0x182C55160")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011FA")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture TakePicture
		{
			[Cpp2IlInjected.Token(Token = "0x60045B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C54B10", Offset = "0x2C53510", VA = "0x182C54B10")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.TakePicture)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045B3")]
			[Cpp2IlInjected.Address(RVA = "0x2C55220", Offset = "0x2C53C20", VA = "0x182C55220")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011FB")]
		[DebuggerNonUserCode]
		public CustomStepDressUp DressUp
		{
			[Cpp2IlInjected.Token(Token = "0x60045B4")]
			[Cpp2IlInjected.Address(RVA = "0x2C54410", Offset = "0x2C52E10", VA = "0x182C54410")]
			get
			{
				if (difficultyStepCase_ == DifficultyStepOneofCase.DressUp)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045B5")]
			[Cpp2IlInjected.Address(RVA = "0x2C54EE0", Offset = "0x2C538E0", VA = "0x182C54EE0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011FC")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem GiftToCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60045B6")]
			[Cpp2IlInjected.Address(RVA = "0x2C54690", Offset = "0x2C53090", VA = "0x182C54690")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.GiftToCharacter)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045B7")]
			[Cpp2IlInjected.Address(RVA = "0x2C55060", Offset = "0x2C53A60", VA = "0x182C55060")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011FD")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion StartDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x60045B8")]
			[Cpp2IlInjected.Address(RVA = "0x2C549F0", Offset = "0x2C533F0", VA = "0x182C549F0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.StartDiscussion)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045B9")]
			[Cpp2IlInjected.Address(RVA = "0x2C551E0", Offset = "0x2C53BE0", VA = "0x182C551E0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011FE")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral MineMineral
		{
			[Cpp2IlInjected.Token(Token = "0x60045BA")]
			[Cpp2IlInjected.Address(RVA = "0x2C54810", Offset = "0x2C53210", VA = "0x182C54810")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.MineMineral)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045BB")]
			[Cpp2IlInjected.Address(RVA = "0x2C550E0", Offset = "0x2C53AE0", VA = "0x182C550E0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011FF")]
		[DebuggerNonUserCode]
		public CustomStepWaterPlant WaterPlant
		{
			[Cpp2IlInjected.Token(Token = "0x60045BC")]
			[Cpp2IlInjected.Address(RVA = "0x2C54C30", Offset = "0x2C53630", VA = "0x182C54C30")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.WaterPlant)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045BD")]
			[Cpp2IlInjected.Address(RVA = "0x2C552E0", Offset = "0x2C53CE0", VA = "0x182C552E0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001200")]
		[DebuggerNonUserCode]
		public CustomStepFeedCritter FeedCritter
		{
			[Cpp2IlInjected.Token(Token = "0x60045BE")]
			[Cpp2IlInjected.Address(RVA = "0x2C54530", Offset = "0x2C52F30", VA = "0x182C54530")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.FeedCritter)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045BF")]
			[Cpp2IlInjected.Address(RVA = "0x2C54FA0", Offset = "0x2C539A0", VA = "0x182C54FA0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001201")]
		[DebuggerNonUserCode]
		public CustomStepFriend MakeFriend
		{
			[Cpp2IlInjected.Token(Token = "0x60045C0")]
			[Cpp2IlInjected.Address(RVA = "0x2C547B0", Offset = "0x2C531B0", VA = "0x182C547B0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.MakeFriend)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045C1")]
			[Cpp2IlInjected.Address(RVA = "0x2C550A0", Offset = "0x2C53AA0", VA = "0x182C550A0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001202")]
		[DebuggerNonUserCode]
		public CustomStepUpgrade Upgrade
		{
			[Cpp2IlInjected.Token(Token = "0x60045C2")]
			[Cpp2IlInjected.Address(RVA = "0x2C54BD0", Offset = "0x2C535D0", VA = "0x182C54BD0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.Upgrade)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045C3")]
			[Cpp2IlInjected.Address(RVA = "0x2C552A0", Offset = "0x2C53CA0", VA = "0x182C552A0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001203")]
		[DebuggerNonUserCode]
		public CustomStepUnlock Unlock
		{
			[Cpp2IlInjected.Token(Token = "0x60045C4")]
			[Cpp2IlInjected.Address(RVA = "0x2C54B70", Offset = "0x2C53570", VA = "0x182C54B70")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.Unlock)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045C5")]
			[Cpp2IlInjected.Address(RVA = "0x2C55260", Offset = "0x2C53C60", VA = "0x182C55260")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001204")]
		[DebuggerNonUserCode]
		public CustomStepExpandHouse ExpandHouse
		{
			[Cpp2IlInjected.Token(Token = "0x60045C6")]
			[Cpp2IlInjected.Address(RVA = "0x2C544D0", Offset = "0x2C52ED0", VA = "0x182C544D0")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.ExpandHouse)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045C7")]
			[Cpp2IlInjected.Address(RVA = "0x2C54F60", Offset = "0x2C53960", VA = "0x182C54F60")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001205")]
		[DebuggerNonUserCode]
		public CustomStepEatMeal EatMeal
		{
			[Cpp2IlInjected.Token(Token = "0x60045C8")]
			[Cpp2IlInjected.Address(RVA = "0x2C54470", Offset = "0x2C52E70", VA = "0x182C54470")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.EatMeal)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045C9")]
			[Cpp2IlInjected.Address(RVA = "0x2C54F20", Offset = "0x2C53920", VA = "0x182C54F20")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001206")]
		[DebuggerNonUserCode]
		public CustomStepServeRestaurantOrder ServeRestaurantOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60045CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C54990", Offset = "0x2C53390", VA = "0x182C54990")]
			get
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60045CB")]
			[Cpp2IlInjected.Address(RVA = "0x2C551A0", Offset = "0x2C53BA0", VA = "0x182C551A0")]
			set
			{
				difficultyStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001207")]
		[DebuggerNonUserCode]
		public ConditionsList AvailableWhen
		{
			[Cpp2IlInjected.Token(Token = "0x60045CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return availableWhen_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				availableWhen_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001208")]
		[DebuggerNonUserCode]
		public int DustReward
		{
			[Cpp2IlInjected.Token(Token = "0x60045CE")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return dustReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045CF")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				dustReward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001209")]
		[DebuggerNonUserCode]
		public DifficultyStepOneofCase DifficultyStepCase
		{
			[Cpp2IlInjected.Token(Token = "0x60045D0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return difficultyStepCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120A")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60045DF")]
			[Cpp2IlInjected.Address(RVA = "0x2C546F0", Offset = "0x2C530F0", VA = "0x182C546F0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0018
				if ((object)typeof(IItemSelector).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					return (ItemSelector)typeof(IItemSelector).TypeHandle;
				}
				return (ItemSelector)typeof(IItemSelector).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120B")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60045E0")]
			[Cpp2IlInjected.Address(RVA = "0x2C54A50", Offset = "0x2C53450", VA = "0x182C54A50", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0018
				if ((object)typeof(IStepAmount).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					return (StepAmount)typeof(IStepAmount).TypeHandle;
				}
				return (StepAmount)typeof(IStepAmount).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120C")]
		public IUniqueItem GetIUniqueItem
		{
			[Cpp2IlInjected.Token(Token = "0x60045E1")]
			[Cpp2IlInjected.Address(RVA = "0x2C54650", Offset = "0x2C53050", VA = "0x182C54650")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600459D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DutyStepDifficulty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600459E")]
		[Cpp2IlInjected.Address(RVA = "0x2C53B00", Offset = "0x2C52500", VA = "0x182C53B00")]
		[DebuggerNonUserCode]
		public DutyStepDifficulty(DutyStepDifficulty other)
		{
			//IL_0021: Expected O, but got I4
			//IL_0219: Expected I4, but got O
			ConditionsList conditionsList = other.availableWhen_;
			int num = 0;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			availableWhen_ = (ConditionsList)num;
			CustomStepEatMeal customStepEatMeal = default(CustomStepEatMeal);
			if ((dustReward_ = other.dustReward_) <= 21)
			{
				CustomStepBringItem customStepBringItem = (CustomStepBringItem)(difficultyStep_ = other.BringItem.Clone());
				CustomStepCatchFish customStepCatchFish = (CustomStepCatchFish)(difficultyStep_ = other.CatchFish.Clone());
				CustomStepCollectCurrency customStepCollectCurrency = (CustomStepCollectCurrency)(difficultyStep_ = other.CollectCurrency.Clone());
				CustomStepCookMeal customStepCookMeal = (CustomStepCookMeal)(difficultyStep_ = other.CookMeal.Clone());
				CustomStepDesignChallenge customStepDesignChallenge = (CustomStepDesignChallenge)(difficultyStep_ = other.DesignChallenge.Clone());
				CustomStepGardeningHarvest customStepGardeningHarvest = (CustomStepGardeningHarvest)(difficultyStep_ = other.GardeningHarvest.Clone());
				CustomStepGardeningPlant customStepGardeningPlant = (CustomStepGardeningPlant)(difficultyStep_ = other.GardeningPlant.Clone());
				CustomStepPickUp customStepPickUp = (CustomStepPickUp)(difficultyStep_ = other.PickUp.Clone());
				CustomStepSellItem customStepSellItem = (CustomStepSellItem)(difficultyStep_ = other.SellItem.Clone());
				CustomStepTakePicture customStepTakePicture = (CustomStepTakePicture)(difficultyStep_ = other.TakePicture.Clone());
				CustomStepDressUp customStepDressUp = (CustomStepDressUp)(difficultyStep_ = other.DressUp.Clone());
				CustomStepGiftToCharacterItem customStepGiftToCharacterItem = (CustomStepGiftToCharacterItem)(difficultyStep_ = other.GiftToCharacter.Clone());
				CustomStepStartDiscussion customStepStartDiscussion = (CustomStepStartDiscussion)(difficultyStep_ = other.StartDiscussion.Clone());
				CustomStepMineMineral customStepMineMineral = (CustomStepMineMineral)(difficultyStep_ = other.MineMineral.Clone());
				CustomStepWaterPlant customStepWaterPlant = (CustomStepWaterPlant)(difficultyStep_ = other.WaterPlant.Clone());
				CustomStepFeedCritter customStepFeedCritter = (CustomStepFeedCritter)(difficultyStep_ = other.FeedCritter.Clone());
				CustomStepFriend customStepFriend = (CustomStepFriend)(difficultyStep_ = other.MakeFriend.Clone());
				CustomStepUpgrade customStepUpgrade = (CustomStepUpgrade)(difficultyStep_ = other.Upgrade.Clone());
				CustomStepUnlock customStepUnlock = (CustomStepUnlock)(difficultyStep_ = other.Unlock.Clone());
				CustomStepExpandHouse customStepExpandHouse = (CustomStepExpandHouse)(difficultyStep_ = other.ExpandHouse.Clone());
				customStepEatMeal = (CustomStepEatMeal)(difficultyStep_ = other.EatMeal.Clone());
			}
			if ((long)customStepEatMeal == 56)
			{
				DifficultyStepOneofCase difficultyStepOneofCase = other.difficultyStepCase_;
				if (other.difficultyStep_ == null)
				{
					throw new InvalidCastException();
				}
				CustomStepServeRestaurantOrder customStepServeRestaurantOrder = default(CustomStepServeRestaurantOrder);
				difficultyStep_ = customStepServeRestaurantOrder;
				difficultyStepCase_ = (DifficultyStepOneofCase)customStepServeRestaurantOrder;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600459F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F200", Offset = "0x2C4DC00", VA = "0x182C4F200", Slot = "10")]
		[DebuggerNonUserCode]
		public DutyStepDifficulty Clone()
		{
			return new DutyStepDifficulty(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60045D1")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearDifficultyStep()
		{
			//IL_0010: Expected O, but got I4
			difficultyStep_ = (difficultyStepCase_ = DifficultyStepOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F730", Offset = "0x2C4E130", VA = "0x182C4F730", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((DutyStepDifficulty)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60045D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F260", Offset = "0x2C4DC60", VA = "0x182C4F260", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DutyStepDifficulty other)
		{
			//IL_0055: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
						goto IL_0334;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
				{
					obj2 = other.difficultyStep_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					CustomStepCatchFish catchFish = CatchFish;
					CustomStepCatchFish catchFish2 = other.CatchFish;
					if (object.Equals(catchFish, catchFish2))
					{
						CustomStepCollectCurrency collectCurrency = CollectCurrency;
						CustomStepCollectCurrency collectCurrency2 = other.CollectCurrency;
						if (object.Equals(collectCurrency, collectCurrency2))
						{
							CustomStepCookMeal cookMeal = CookMeal;
							CustomStepCookMeal cookMeal2 = other.CookMeal;
							if (object.Equals(cookMeal, cookMeal2))
							{
								CustomStepDesignChallenge designChallenge = DesignChallenge;
								CustomStepDesignChallenge designChallenge2 = other.DesignChallenge;
								if (object.Equals(designChallenge, designChallenge2))
								{
									CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
									CustomStepGardeningHarvest gardeningHarvest2 = other.GardeningHarvest;
									if (object.Equals(gardeningHarvest, gardeningHarvest2))
									{
										CustomStepGardeningPlant gardeningPlant = GardeningPlant;
										CustomStepGardeningPlant gardeningPlant2 = other.GardeningPlant;
										if (object.Equals(gardeningPlant, gardeningPlant2))
										{
											CustomStepPickUp pickUp = PickUp;
											CustomStepPickUp pickUp2 = other.PickUp;
											if (object.Equals(pickUp, pickUp2))
											{
												CustomStepSellItem sellItem = SellItem;
												CustomStepSellItem sellItem2 = other.SellItem;
												if (object.Equals(sellItem, sellItem2))
												{
													CustomStepTakePicture takePicture = TakePicture;
													CustomStepTakePicture takePicture2 = other.TakePicture;
													if (object.Equals(takePicture, takePicture2))
													{
														CustomStepDressUp dressUp = DressUp;
														CustomStepDressUp dressUp2 = other.DressUp;
														if (object.Equals(dressUp, dressUp2))
														{
															CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
															CustomStepGiftToCharacterItem giftToCharacter2 = other.GiftToCharacter;
															if (object.Equals(giftToCharacter, giftToCharacter2))
															{
																CustomStepStartDiscussion startDiscussion = StartDiscussion;
																CustomStepStartDiscussion startDiscussion2 = other.StartDiscussion;
																if (object.Equals(startDiscussion, startDiscussion2))
																{
																	CustomStepMineMineral mineMineral = MineMineral;
																	CustomStepMineMineral mineMineral2 = other.MineMineral;
																	if (object.Equals(mineMineral, mineMineral2))
																	{
																		CustomStepWaterPlant waterPlant = WaterPlant;
																		CustomStepWaterPlant waterPlant2 = other.WaterPlant;
																		if (object.Equals(waterPlant, waterPlant2))
																		{
																			CustomStepFeedCritter feedCritter = FeedCritter;
																			CustomStepFeedCritter feedCritter2 = other.FeedCritter;
																			if (object.Equals(feedCritter, feedCritter2))
																			{
																				CustomStepFriend makeFriend = MakeFriend;
																				CustomStepFriend makeFriend2 = other.MakeFriend;
																				if (object.Equals(makeFriend, makeFriend2))
																				{
																					CustomStepUpgrade upgrade = Upgrade;
																					CustomStepUpgrade upgrade2 = other.Upgrade;
																					if (object.Equals(upgrade, upgrade2))
																					{
																						CustomStepUnlock unlock = Unlock;
																						CustomStepUnlock unlock2 = other.Unlock;
																						if (object.Equals(unlock, unlock2))
																						{
																							CustomStepExpandHouse expandHouse = ExpandHouse;
																							CustomStepExpandHouse expandHouse2 = other.ExpandHouse;
																							if (object.Equals(expandHouse, expandHouse2))
																							{
																								CustomStepEatMeal eatMeal = EatMeal;
																								CustomStepEatMeal eatMeal2 = other.EatMeal;
																								if (object.Equals(eatMeal, eatMeal2))
																								{
																									CustomStepServeRestaurantOrder serveRestaurantOrder = ServeRestaurantOrder;
																									CustomStepServeRestaurantOrder serveRestaurantOrder2 = other.ServeRestaurantOrder;
																									if (object.Equals(serveRestaurantOrder, serveRestaurantOrder2))
																									{
																										ConditionsList objB = other.availableWhen_;
																										if (object.Equals(availableWhen_, objB))
																										{
																											int num2 = other.dustReward_;
																											if (dustReward_ == num2)
																											{
																												DifficultyStepOneofCase difficultyStepOneofCase = other.difficultyStepCase_;
																												if (difficultyStepCase_ == difficultyStepOneofCase)
																												{
																													UnknownFieldSet unknownFields = other._unknownFields;
																													bool flag = object.Equals(_unknownFields, unknownFields);
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
			goto IL_0334;
			IL_0334:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FAF0", Offset = "0x2C4E4F0", VA = "0x182C4FAF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0367
			while (true)
			{
				DifficultyStepOneofCase difficultyStepOneofCase = difficultyStepCase_;
				int num = 0;
				if (difficultyStepOneofCase == DifficultyStepOneofCase.BringItem)
				{
					object obj = difficultyStep_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (difficultyStepOneofCase != DifficultyStepOneofCase.CatchFish)
				{
					continue;
				}
				object obj2 = difficultyStep_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (difficultyStepCase_ != DifficultyStepOneofCase.CollectCurrency)
					{
						continue;
					}
					object obj3 = difficultyStep_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (difficultyStepCase_ != DifficultyStepOneofCase.CookMeal)
						{
							continue;
						}
						object obj4 = difficultyStep_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (difficultyStepCase_ != DifficultyStepOneofCase.DesignChallenge)
							{
								continue;
							}
							object obj5 = difficultyStep_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningHarvest)
								{
									continue;
								}
								object obj6 = difficultyStep_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningPlant)
									{
										continue;
									}
									object obj7 = difficultyStep_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (difficultyStepCase_ != DifficultyStepOneofCase.PickUp)
										{
											continue;
										}
										object obj8 = difficultyStep_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (difficultyStepCase_ != DifficultyStepOneofCase.SellItem)
											{
												continue;
											}
											object obj9 = difficultyStep_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (difficultyStepCase_ != DifficultyStepOneofCase.TakePicture)
												{
													continue;
												}
												object obj10 = difficultyStep_;
												if (obj10 != null)
												{
													int hashCode10 = obj10.GetHashCode();
													if (difficultyStepCase_ != DifficultyStepOneofCase.DressUp)
													{
														continue;
													}
													object obj11 = difficultyStep_;
													if (obj11 != null)
													{
														int hashCode11 = obj11.GetHashCode();
														if (difficultyStepCase_ != DifficultyStepOneofCase.GiftToCharacter)
														{
															continue;
														}
														object obj12 = difficultyStep_;
														if (obj12 != null)
														{
															int hashCode12 = obj12.GetHashCode();
															if (difficultyStepCase_ != DifficultyStepOneofCase.StartDiscussion)
															{
																continue;
															}
															object obj13 = difficultyStep_;
															if (obj13 != null)
															{
																int hashCode13 = obj13.GetHashCode();
																if (difficultyStepCase_ != DifficultyStepOneofCase.MineMineral)
																{
																	continue;
																}
																object obj14 = difficultyStep_;
																if (obj14 != null)
																{
																	int hashCode14 = obj14.GetHashCode();
																	if (difficultyStepCase_ != DifficultyStepOneofCase.WaterPlant)
																	{
																		continue;
																	}
																	object obj15 = difficultyStep_;
																	if (obj15 != null)
																	{
																		int hashCode15 = obj15.GetHashCode();
																		if (difficultyStepCase_ != DifficultyStepOneofCase.FeedCritter)
																		{
																			continue;
																		}
																		object obj16 = difficultyStep_;
																		if (obj16 != null)
																		{
																			int hashCode16 = obj16.GetHashCode();
																			if (difficultyStepCase_ != DifficultyStepOneofCase.MakeFriend)
																			{
																				continue;
																			}
																			object obj17 = difficultyStep_;
																			if (obj17 != null)
																			{
																				int hashCode17 = obj17.GetHashCode();
																				if (difficultyStepCase_ != DifficultyStepOneofCase.Upgrade)
																				{
																					continue;
																				}
																				object obj18 = difficultyStep_;
																				if (obj18 != null)
																				{
																					int hashCode18 = obj18.GetHashCode();
																					if (difficultyStepCase_ != DifficultyStepOneofCase.Unlock)
																					{
																						continue;
																					}
																					object obj19 = difficultyStep_;
																					if (obj19 != null)
																					{
																						int hashCode19 = obj19.GetHashCode();
																						if (difficultyStepCase_ != DifficultyStepOneofCase.ExpandHouse)
																						{
																							continue;
																						}
																						object obj20 = difficultyStep_;
																						if (obj20 != null)
																						{
																							int hashCode20 = obj20.GetHashCode();
																							if (difficultyStepCase_ != DifficultyStepOneofCase.EatMeal)
																							{
																								continue;
																							}
																							object obj21 = difficultyStep_;
																							if (obj21 != null)
																							{
																								int hashCode21 = obj21.GetHashCode();
																								if (difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder)
																								{
																									object obj22 = difficultyStep_;
																									if (obj22 == null)
																									{
																										break;
																									}
																									int hashCode22 = obj22.GetHashCode();
																								}
																								ConditionsList conditionsList = availableWhen_;
																								if (conditionsList != null)
																								{
																									int hashCode23 = conditionsList.GetHashCode();
																								}
																								if (dustReward_ != 0)
																								{
																								}
																								UnknownFieldSet unknownFields = _unknownFields;
																								if (unknownFields != null)
																								{
																									int hashCode24 = unknownFields.GetHashCode();
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
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C52E80", Offset = "0x2C51880", VA = "0x182C52E80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60045D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C52EE0", Offset = "0x2C518E0", VA = "0x182C52EE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0409
			while (true)
			{
				if ((long)availableWhen_ != 0)
				{
					ConditionsList value = availableWhen_;
					output.WriteMessage(value);
				}
				if (dustReward_ != 0)
				{
					int value2 = dustReward_;
					output.WriteInt32(value2);
				}
				DifficultyStepOneofCase difficultyStepOneofCase = difficultyStepCase_;
				int num = 0;
				if (difficultyStepOneofCase != DifficultyStepOneofCase.BringItem)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.CatchFish)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.CatchFish)
				{
					object obj2 = difficultyStep_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.CollectCurrency)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.CollectCurrency)
				{
					object obj3 = difficultyStep_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.CookMeal)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.CookMeal)
				{
					object obj4 = difficultyStep_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.DesignChallenge)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.DesignChallenge)
				{
					object obj5 = difficultyStep_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningHarvest)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningHarvest)
				{
					object obj6 = difficultyStep_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningPlant)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningPlant)
				{
					object obj7 = difficultyStep_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.PickUp)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.PickUp)
				{
					object obj8 = difficultyStep_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.SellItem)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.SellItem)
				{
					object obj9 = difficultyStep_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.TakePicture)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.TakePicture)
				{
					object obj10 = difficultyStep_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.DressUp)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.DressUp)
				{
					object obj11 = difficultyStep_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.GiftToCharacter)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.GiftToCharacter)
				{
					object obj12 = difficultyStep_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.StartDiscussion)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.StartDiscussion)
				{
					object obj13 = difficultyStep_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.MineMineral)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.MineMineral)
				{
					object obj14 = difficultyStep_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.WaterPlant)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.WaterPlant)
				{
					object obj15 = difficultyStep_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.FeedCritter)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.FeedCritter)
				{
					object obj16 = difficultyStep_;
					if (obj16 != null && obj16 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.MakeFriend)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.MakeFriend)
				{
					object obj17 = difficultyStep_;
					if (obj17 != null && obj17 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.Upgrade)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.Upgrade)
				{
					object obj18 = difficultyStep_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.Unlock)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.Unlock)
				{
					object obj19 = difficultyStep_;
					if (obj19 != null && obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.ExpandHouse)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.ExpandHouse)
				{
					object obj20 = difficultyStep_;
					if (obj20 != null && obj20 == null)
					{
						break;
					}
				}
				if (difficultyStepCase_ != DifficultyStepOneofCase.EatMeal)
				{
					continue;
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.EatMeal)
				{
					object obj21 = difficultyStep_;
					if (obj21 != null && obj21 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder && difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder)
				{
					object obj22 = difficultyStep_;
					if (obj22 != null && obj22 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E4B0", Offset = "0x2C4CEB0", VA = "0x182C4E4B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002e: Expected O, but got I4
			int num = 0;
			if (difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
			{
				if (difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
				{
					object obj = difficultyStep_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.CatchFish)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.CatchFish)
				{
				}
				object obj2 = difficultyStep_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.CollectCurrency)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.CollectCurrency)
				{
				}
				object obj3 = difficultyStep_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.CookMeal)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.CookMeal)
				{
				}
				object obj4 = difficultyStep_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.DesignChallenge)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.DesignChallenge)
				{
				}
				object obj5 = difficultyStep_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningHarvest)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningHarvest)
				{
				}
				object obj6 = difficultyStep_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num7 = default(int);
				num += num7;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningPlant)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningPlant)
				{
				}
				object obj7 = difficultyStep_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num8 = default(int);
				num += num8;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.PickUp)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.PickUp)
				{
				}
				object obj8 = difficultyStep_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num9 = default(int);
				num += num9;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.SellItem)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.SellItem)
				{
				}
				object obj9 = difficultyStep_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num10 = default(int);
				num += num10;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.TakePicture)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.TakePicture)
				{
				}
				object obj10 = difficultyStep_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num11 = default(int);
				num += num11;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.DressUp)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.DressUp)
				{
				}
				object obj11 = difficultyStep_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num12 = default(int);
				num += num12;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.GiftToCharacter)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.GiftToCharacter)
				{
				}
				object obj12 = difficultyStep_;
				if (obj12 != null && obj12 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num13 = default(int);
				num += num13;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.StartDiscussion)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.StartDiscussion)
				{
				}
				object obj13 = difficultyStep_;
				if (obj13 != null && obj13 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num14 = default(int);
				num += num14;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.MineMineral)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.MineMineral)
				{
				}
				object obj14 = difficultyStep_;
				if (obj14 != null && obj14 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num15 = default(int);
				num += num15;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.WaterPlant)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.WaterPlant)
				{
				}
				object obj15 = difficultyStep_;
				if (obj15 != null && obj15 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num16 = default(int);
				num += num16;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.FeedCritter)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.FeedCritter)
				{
				}
				object obj16 = difficultyStep_;
				if (obj16 != null && obj16 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num17 = default(int);
				num += num17;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.MakeFriend)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.MakeFriend)
				{
				}
				object obj17 = difficultyStep_;
				if (obj17 != null && obj17 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num18 = default(int);
				num += num18;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.Upgrade)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.Upgrade)
				{
				}
				object obj18 = difficultyStep_;
				if (obj18 != null && obj18 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num19 = default(int);
				num += num19;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.Unlock)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.Unlock)
				{
				}
				object obj19 = difficultyStep_;
				if (obj19 != null && obj19 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num20 = default(int);
				num += num20;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.ExpandHouse)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.ExpandHouse)
				{
				}
				object obj20 = difficultyStep_;
				if (obj20 != null && obj20 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num21 = default(int);
				num += num21;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.EatMeal)
			{
				if (difficultyStepCase_ != DifficultyStepOneofCase.EatMeal)
				{
				}
				object obj21 = difficultyStep_;
				if (obj21 != null && obj21 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num22 = default(int);
				num += num22;
			}
			if (difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder)
			{
				if (difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder)
				{
					object obj22 = difficultyStep_;
					if (obj22 != null && obj22 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num23 = default(int);
				num += num23;
			}
			ConditionsList conditionsList = availableWhen_;
			if (conditionsList != null)
			{
				int num24 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num24++;
				num += num24;
			}
			int num25 = dustReward_;
			if (num25 != 0)
			{
				int num26 = CodedOutputStream.ComputeInt32Size(num25);
				num26++;
				num += num26;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num27 = unknownFields.CalculateSize();
				num += num27;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60045D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C51890", Offset = "0x2C50290", VA = "0x182C51890", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DutyStepDifficulty other)
		{
			//Discarded unreachable code: IL_00ab, IL_00b4, IL_00cb, IL_00e1, IL_00f8, IL_010e, IL_0125, IL_013b, IL_0152, IL_0168, IL_017f, IL_0195, IL_01ac, IL_01c2, IL_01d9, IL_01ef, IL_0206, IL_021c, IL_0233, IL_0249, IL_0260, IL_0276, IL_028d, IL_02a3, IL_02ba, IL_02d0, IL_02e7, IL_02fd, IL_0314, IL_032a, IL_0341, IL_0357, IL_036e, IL_0384, IL_039b, IL_03b1, IL_03c8, IL_03de, IL_03f5, IL_040b, IL_0422
			//IL_0072: Expected I4, but got O
			//IL_00cb: Expected I4, but got O
			//IL_00f8: Expected I4, but got O
			//IL_0125: Expected I4, but got O
			//IL_0152: Expected I4, but got O
			//IL_017f: Expected I4, but got O
			//IL_01ac: Expected I4, but got O
			//IL_01d9: Expected I4, but got O
			//IL_0206: Expected I4, but got O
			//IL_0233: Expected I4, but got O
			//IL_0260: Expected I4, but got O
			//IL_028d: Expected I4, but got O
			//IL_02ba: Expected I4, but got O
			//IL_02e7: Expected I4, but got O
			//IL_0314: Expected I4, but got O
			//IL_0341: Expected I4, but got O
			//IL_036e: Expected I4, but got O
			//IL_039b: Expected I4, but got O
			//IL_03c8: Expected I4, but got O
			//IL_03f5: Expected I4, but got O
			//IL_0422: Expected I4, but got O
			//IL_0457: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.availableWhen_ != 0)
			{
				ConditionsList conditionsList = availableWhen_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (availableWhen_ = new ConditionsList());
				}
				ConditionsList other2 = other.availableWhen_;
				conditionsList.MergeFrom(other2);
			}
			int num = other.dustReward_;
			if (num != 0)
			{
				dustReward_ = num;
			}
			if (num <= 21)
			{
				if (BringItem == null)
				{
					difficultyStepCase_ = (DifficultyStepOneofCase)(difficultyStep_ = new CustomStepBringItem());
				}
				CustomStepBringItem bringItem = BringItem;
				CustomStepBringItem bringItem2 = other.BringItem;
				bringItem.MergeFrom(bringItem2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			CustomStepEatMeal customStepEatMeal = default(CustomStepEatMeal);
			while ((long)customStepEatMeal != 56)
			{
			}
			if (ServeRestaurantOrder == null)
			{
				difficultyStepCase_ = (DifficultyStepOneofCase)(difficultyStep_ = new CustomStepServeRestaurantOrder());
			}
			CustomStepServeRestaurantOrder other3 = default(CustomStepServeRestaurantOrder);
			ServeRestaurantOrder.MergeFrom(other3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C50620", Offset = "0x2C4F020", VA = "0x182C50620", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_007d: Expected I4, but got O
			//IL_00ce: Expected I4, but got O
			//IL_012a: Expected I4, but got O
			//IL_017e: Expected I4, but got O
			//IL_01d7: Expected I4, but got O
			//IL_0233: Expected I4, but got O
			//IL_0293: Expected I4, but got O
			//IL_02ec: Expected I4, but got O
			//IL_0348: Expected I4, but got O
			//IL_03a1: Expected I4, but got O
			//IL_03fa: Expected I4, but got O
			//IL_0456: Expected I4, but got O
			//IL_04bf: Expected I4, but got O
			//IL_0518: Expected I4, but got O
			//IL_0574: Expected I4, but got O
			//IL_05ca: Expected I4, but got O
			//IL_0623: Expected I4, but got O
			//IL_067f: Expected I4, but got O
			//IL_06e3: Expected I4, but got O
			//IL_0739: Expected I4, but got O
			//IL_0792: Expected I4, but got O
			//IL_082e: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 162)
			{
				if ((int)num > 210)
				{
					if ((int)num > 234)
					{
						if (num == 242)
						{
							CustomStepExpandHouse customStepExpandHouse = new CustomStepExpandHouse();
							if (difficultyStepCase_ == DifficultyStepOneofCase.ExpandHouse)
							{
								if (difficultyStepCase_ != DifficultyStepOneofCase.ExpandHouse)
								{
								}
								object obj = difficultyStep_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(customStepExpandHouse);
							difficultyStep_ = customStepExpandHouse;
							difficultyStepCase_ = (DifficultyStepOneofCase)customStepExpandHouse;
						}
						if (num == 250)
						{
							CustomStepEatMeal builder = new CustomStepEatMeal();
							if (difficultyStepCase_ == DifficultyStepOneofCase.EatMeal)
							{
								if (difficultyStepCase_ != DifficultyStepOneofCase.EatMeal)
								{
								}
								object obj2 = difficultyStep_;
								if (obj2 != null && obj2 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder);
							difficultyStep_ = builder;
							difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepEatMeal).TypeHandle;
						}
						if ((long)typeof(CustomStepEatMeal).TypeHandle != 450)
						{
							goto IL_082e;
						}
						CustomStepServeRestaurantOrder builder2 = new CustomStepServeRestaurantOrder();
						if (difficultyStepCase_ == DifficultyStepOneofCase.ServeRestaurantOrder)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.ServeRestaurantOrder)
							{
							}
							object obj3 = difficultyStep_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder2);
						difficultyStep_ = builder2;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepServeRestaurantOrder).TypeHandle;
					}
					if (num == 218)
					{
						CustomStepFriend builder3 = new CustomStepFriend();
						if (difficultyStepCase_ == DifficultyStepOneofCase.MakeFriend)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.MakeFriend)
							{
							}
							object obj4 = difficultyStep_;
							if (obj4 != null && obj4 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder3);
						difficultyStep_ = builder3;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepFriend).TypeHandle;
					}
					if ((long)typeof(CustomStepFriend).TypeHandle == 226)
					{
						CustomStepUpgrade builder4 = new CustomStepUpgrade();
						if (difficultyStepCase_ == DifficultyStepOneofCase.Upgrade)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.Upgrade)
							{
							}
							object obj5 = difficultyStep_;
							if (obj5 != null && obj5 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder4);
						difficultyStep_ = builder4;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepUpgrade).TypeHandle;
					}
					if ((long)typeof(CustomStepUpgrade).TypeHandle != 234)
					{
						goto IL_082e;
					}
					CustomStepUnlock builder5 = new CustomStepUnlock();
					if (difficultyStepCase_ == DifficultyStepOneofCase.Unlock)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.Unlock)
						{
						}
						object obj6 = difficultyStep_;
						if (obj6 != null && obj6 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder5);
					difficultyStep_ = builder5;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepUnlock).TypeHandle;
				}
				if ((int)num > 186)
				{
					if (num == 194)
					{
						CustomStepMineMineral builder6 = new CustomStepMineMineral();
						if (difficultyStepCase_ == DifficultyStepOneofCase.MineMineral)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.MineMineral)
							{
							}
							object obj7 = difficultyStep_;
							if (obj7 != null && obj7 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder6);
						difficultyStep_ = builder6;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepMineMineral).TypeHandle;
					}
					if ((long)typeof(CustomStepMineMineral).TypeHandle == 202)
					{
						CustomStepWaterPlant builder7 = new CustomStepWaterPlant();
						if (difficultyStepCase_ == DifficultyStepOneofCase.WaterPlant)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.WaterPlant)
							{
							}
							object obj8 = difficultyStep_;
							if (obj8 != null && obj8 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder7);
						difficultyStep_ = builder7;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepWaterPlant).TypeHandle;
					}
					if ((long)typeof(CustomStepWaterPlant).TypeHandle != 210)
					{
						goto IL_082e;
					}
					CustomStepFeedCritter builder8 = new CustomStepFeedCritter();
					if (difficultyStepCase_ == DifficultyStepOneofCase.FeedCritter)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.FeedCritter)
						{
						}
						object obj9 = difficultyStep_;
						if (obj9 != null && obj9 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder8);
					difficultyStep_ = builder8;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepFeedCritter).TypeHandle;
				}
				if ((long)typeof(CustomStepFeedCritter).TypeHandle == 170)
				{
					CustomStepDressUp builder9 = new CustomStepDressUp();
					if (difficultyStepCase_ == DifficultyStepOneofCase.DressUp)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.DressUp)
						{
						}
						object obj10 = difficultyStep_;
						if (obj10 != null && obj10 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder9);
					difficultyStep_ = builder9;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepDressUp).TypeHandle;
				}
				if ((long)typeof(CustomStepDressUp).TypeHandle == 178)
				{
					CustomStepGiftToCharacterItem builder10 = new CustomStepGiftToCharacterItem();
					if (difficultyStepCase_ == DifficultyStepOneofCase.GiftToCharacter)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.GiftToCharacter)
						{
						}
						object obj11 = difficultyStep_;
						if (obj11 != null && obj11 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder10);
					difficultyStep_ = builder10;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepGiftToCharacterItem).TypeHandle;
				}
				if ((long)typeof(CustomStepGiftToCharacterItem).TypeHandle != 186)
				{
					goto IL_082e;
				}
				CustomStepStartDiscussion builder11 = new CustomStepStartDiscussion();
				if (difficultyStepCase_ == DifficultyStepOneofCase.StartDiscussion)
				{
					if (difficultyStepCase_ != DifficultyStepOneofCase.StartDiscussion)
					{
					}
					object obj12 = difficultyStep_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder11);
				difficultyStep_ = builder11;
				difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepStartDiscussion).TypeHandle;
			}
			if ((int)num > 106)
			{
				if ((int)num > 138)
				{
					if (num == 146)
					{
						CustomStepPickUp builder12 = new CustomStepPickUp();
						if (difficultyStepCase_ == DifficultyStepOneofCase.PickUp)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.PickUp)
							{
							}
							object obj13 = difficultyStep_;
							if (obj13 != null && obj13 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder12);
						difficultyStep_ = builder12;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepPickUp).TypeHandle;
					}
					if ((long)typeof(CustomStepPickUp).TypeHandle == 154)
					{
						CustomStepSellItem builder13 = new CustomStepSellItem();
						if (difficultyStepCase_ == DifficultyStepOneofCase.SellItem)
						{
							if (difficultyStepCase_ != DifficultyStepOneofCase.SellItem)
							{
							}
							object obj14 = difficultyStep_;
							if (obj14 != null && obj14 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder13);
						difficultyStep_ = builder13;
						difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepSellItem).TypeHandle;
					}
					if ((long)typeof(CustomStepSellItem).TypeHandle != 162)
					{
						goto IL_082e;
					}
					CustomStepTakePicture builder14 = new CustomStepTakePicture();
					if (difficultyStepCase_ == DifficultyStepOneofCase.TakePicture)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.TakePicture)
						{
						}
						object obj15 = difficultyStep_;
						if (obj15 != null && obj15 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder14);
					difficultyStep_ = builder14;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepTakePicture).TypeHandle;
				}
				if ((long)typeof(CustomStepTakePicture).TypeHandle == 122)
				{
					CustomStepDesignChallenge builder15 = new CustomStepDesignChallenge();
					if (difficultyStepCase_ == DifficultyStepOneofCase.DesignChallenge)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.DesignChallenge)
						{
						}
						object obj16 = difficultyStep_;
						if (obj16 != null && obj16 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder15);
					difficultyStep_ = builder15;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepDesignChallenge).TypeHandle;
				}
				if ((long)typeof(CustomStepDesignChallenge).TypeHandle == 130)
				{
					CustomStepGardeningHarvest builder16 = new CustomStepGardeningHarvest();
					if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningHarvest)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningHarvest)
						{
						}
						object obj17 = difficultyStep_;
						if (obj17 != null && obj17 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder16);
					difficultyStep_ = builder16;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepGardeningHarvest).TypeHandle;
				}
				if ((long)typeof(CustomStepGardeningHarvest).TypeHandle != 138)
				{
					goto IL_082e;
				}
				CustomStepGardeningPlant builder17 = new CustomStepGardeningPlant();
				if (difficultyStepCase_ == DifficultyStepOneofCase.GardeningPlant)
				{
					if (difficultyStepCase_ != DifficultyStepOneofCase.GardeningPlant)
					{
					}
					object obj18 = difficultyStep_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder17);
				difficultyStep_ = builder17;
				difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepGardeningPlant).TypeHandle;
			}
			if ((long)typeof(CustomStepGardeningPlant).TypeHandle > 82)
			{
				if ((long)typeof(CustomStepGardeningPlant).TypeHandle == 90)
				{
					CustomStepCatchFish builder18 = new CustomStepCatchFish();
					if (difficultyStepCase_ == DifficultyStepOneofCase.CatchFish)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.CatchFish)
						{
						}
						object obj19 = difficultyStep_;
						if (obj19 != null && obj19 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder18);
					difficultyStep_ = builder18;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepCatchFish).TypeHandle;
				}
				if ((long)typeof(CustomStepCatchFish).TypeHandle == 98)
				{
					CustomStepCollectCurrency builder19 = new CustomStepCollectCurrency();
					if (difficultyStepCase_ == DifficultyStepOneofCase.CollectCurrency)
					{
						if (difficultyStepCase_ != DifficultyStepOneofCase.CollectCurrency)
						{
						}
						object obj20 = difficultyStep_;
						if (obj20 != null && obj20 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder19);
					difficultyStep_ = builder19;
					difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepCollectCurrency).TypeHandle;
				}
				if ((long)typeof(CustomStepCollectCurrency).TypeHandle != 106)
				{
					goto IL_082e;
				}
				CustomStepCookMeal builder20 = new CustomStepCookMeal();
				if (difficultyStepCase_ == DifficultyStepOneofCase.CookMeal)
				{
					if (difficultyStepCase_ != DifficultyStepOneofCase.CookMeal)
					{
					}
					object obj21 = difficultyStep_;
					if (obj21 != null && obj21 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder20);
				difficultyStep_ = builder20;
				difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepCookMeal).TypeHandle;
			}
			ConditionsList conditionsList = default(ConditionsList);
			if ((long)typeof(CustomStepCookMeal).TypeHandle == 10)
			{
				ConditionsList builder21 = default(ConditionsList);
				if (availableWhen_ == null)
				{
					conditionsList = (availableWhen_ = new ConditionsList());
					builder21 = availableWhen_;
				}
				input.ReadMessage(builder21);
			}
			int num2 = default(int);
			if ((long)conditionsList == 16)
			{
				num2 = (dustReward_ = input.ReadInt32());
			}
			if (num2 == 82)
			{
				CustomStepBringItem builder22 = new CustomStepBringItem();
				if (difficultyStepCase_ == DifficultyStepOneofCase.BringItem)
				{
					if (difficultyStepCase_ != DifficultyStepOneofCase.BringItem)
					{
					}
					object obj22 = difficultyStep_;
					if (obj22 != null && obj22 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder22);
				difficultyStep_ = builder22;
				difficultyStepCase_ = (DifficultyStepOneofCase)typeof(CustomStepBringItem).TypeHandle;
			}
			goto IL_082e;
			IL_082e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60045DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F790", Offset = "0x2C4E190", VA = "0x182C4F790", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 30)
			{
				ConditionsList conditionsList = availableWhen_;
			}
			if (fieldNumber == 56)
			{
				while (difficultyStepCase_ != DifficultyStepOneofCase.ServeRestaurantOrder)
				{
				}
				object obj = difficultyStep_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_0040;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0040;
			IL_0040:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C52500", Offset = "0x2C50F00", VA = "0x182C52500", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0021, IL_0025, IL_002c, IL_002d, IL_0031, IL_0038, IL_0039, IL_003d, IL_0044, IL_0045, IL_0049, IL_0050, IL_0051, IL_0055, IL_005c, IL_005d, IL_0061, IL_0068, IL_0069, IL_006d, IL_0074, IL_0075, IL_0079, IL_0080, IL_0081, IL_0085, IL_008c, IL_008d, IL_0091, IL_0098, IL_0099, IL_009d, IL_00a4, IL_00a5, IL_00a9, IL_00b0, IL_00b1, IL_00b5, IL_00bc, IL_00bd, IL_00c1, IL_00c8, IL_00c9, IL_00cd, IL_00d4, IL_00d5, IL_00d9, IL_00e0, IL_00e1, IL_00e5, IL_00ec, IL_00ed, IL_00f1, IL_00f8, IL_00f9, IL_00fd, IL_0104, IL_0105, IL_0109, IL_0110, IL_0111, IL_0115, IL_011c, IL_0145, IL_014b, IL_0151, IL_0157, IL_015d, IL_0163, IL_0169, IL_016f, IL_0175, IL_017b, IL_0181, IL_0187, IL_018d, IL_0193, IL_0199, IL_019f, IL_01a5, IL_01ab, IL_01b1, IL_01b7, IL_01bd
			//IL_0020: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num <= 30)
			{
				int num2 = 0;
				if (value == null || value != null)
				{
					availableWhen_ = (ConditionsList)num2;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 56)
			{
			}
			if (value == null || value != null)
			{
				difficultyStep_ = value;
				difficultyStepCase_ = (DifficultyStepOneofCase)num;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F090", Offset = "0x2C4DA90", VA = "0x182C4F090", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			if (fieldNumber - 1 <= 30)
			{
				int num = 0;
				availableWhen_ = (ConditionsList)num;
				int num2 = (dustReward_ = 0);
			}
			else if (fieldNumber == 56)
			{
				int num3 = 0;
				int num4 = 0;
				difficultyStep_ = num3;
				difficultyStepCase_ = (DifficultyStepOneofCase)num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C50570", Offset = "0x2C4EF70", VA = "0x182C50570", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "DifficultyStep"))
			{
				DifficultyStepOneofCase difficultyStepOneofCase = difficultyStepCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F190", Offset = "0x2C4DB90", VA = "0x182C4F190", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "DifficultyStep"))
			{
				difficultyStep_ = (difficultyStepCase_ = DifficultyStepOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C50520", Offset = "0x2C4EF20", VA = "0x182C50520", Slot = "18")]
		public (ItemType, ActivityItemType?) GetItemGeneratorParameters()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C539F0", Offset = "0x2C523F0", VA = "0x182C539F0")]
		static DutyStepDifficulty()
		{
			Func<DutyStepDifficulty> func = default(Func<DutyStepDifficulty>);
			_parser = (MessageParser<DutyStepDifficulty>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
