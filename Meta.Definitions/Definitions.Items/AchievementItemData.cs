using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200059E")]
	public sealed class AchievementItemData : IMessage<AchievementItemData>, IMessage, IEquatable<AchievementItemData>, IDeepCloneable<AchievementItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IStringTag, ICustomStepOwner, IItemSelector, IItemGeneratorOwner, IDataValidation, IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x200059F")]
		public enum StepOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001EC5")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001EC6")]
			CatchFish = 21,
			[Cpp2IlInjected.Token(Token = "0x4001EC7")]
			CollectCurrency = 22,
			[Cpp2IlInjected.Token(Token = "0x4001EC8")]
			CookMeal = 23,
			[Cpp2IlInjected.Token(Token = "0x4001EC9")]
			DesignChallenge = 25,
			[Cpp2IlInjected.Token(Token = "0x4001ECA")]
			GardeningHarvest = 28,
			[Cpp2IlInjected.Token(Token = "0x4001ECB")]
			GardeningPlant = 29,
			[Cpp2IlInjected.Token(Token = "0x4001ECC")]
			Possess = 30,
			[Cpp2IlInjected.Token(Token = "0x4001ECD")]
			PickUp = 31,
			[Cpp2IlInjected.Token(Token = "0x4001ECE")]
			PurchaseItem = 32,
			[Cpp2IlInjected.Token(Token = "0x4001ECF")]
			SellItem = 33,
			[Cpp2IlInjected.Token(Token = "0x4001ED0")]
			TakePicture = 35,
			[Cpp2IlInjected.Token(Token = "0x4001ED1")]
			DressUp = 37,
			[Cpp2IlInjected.Token(Token = "0x4001ED2")]
			BuildFriendHouses = 40,
			[Cpp2IlInjected.Token(Token = "0x4001ED3")]
			GiftToCharacter = 41,
			[Cpp2IlInjected.Token(Token = "0x4001ED4")]
			StartDiscussion = 42,
			[Cpp2IlInjected.Token(Token = "0x4001ED5")]
			MineMineral = 43,
			[Cpp2IlInjected.Token(Token = "0x4001ED6")]
			WaterPlant = 44,
			[Cpp2IlInjected.Token(Token = "0x4001ED7")]
			FeedCritter = 45,
			[Cpp2IlInjected.Token(Token = "0x4001ED8")]
			MakeFriend = 46,
			[Cpp2IlInjected.Token(Token = "0x4001ED9")]
			Upgrade = 47,
			[Cpp2IlInjected.Token(Token = "0x4001EDA")]
			Unlock = 48,
			[Cpp2IlInjected.Token(Token = "0x4001EDB")]
			ExpandHouse = 49,
			[Cpp2IlInjected.Token(Token = "0x4001EDC")]
			RoyalDuty = 50,
			[Cpp2IlInjected.Token(Token = "0x4001EDD")]
			EatMeal = 51,
			[Cpp2IlInjected.Token(Token = "0x4001EDE")]
			Decorate = 52
		}

		[Cpp2IlInjected.Token(Token = "0x4001E8A")]
		private static readonly MessageParser<AchievementItemData> _parser = (MessageParser<AchievementItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new AchievementItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E8B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001E8C")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E8D")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001E8E")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E8F")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E90")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E91")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E92")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E93")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E94")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E95")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E96")]
		public const int StatusFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E97")]
		private DutyStatus status_;

		[Cpp2IlInjected.Token(Token = "0x4001E98")]
		public const int TitleFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E99")]
		private string title_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E9A")]
		public const int DescriptionFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E9B")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E9C")]
		public const int TypeFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E9D")]
		private AchievementType type_;

		[Cpp2IlInjected.Token(Token = "0x4001E9E")]
		public const int DifferentTypesOnlyFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001E9F")]
		private bool differentTypesOnly_;

		[Cpp2IlInjected.Token(Token = "0x4001EA0")]
		public const int WithoutFailingFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4001EA1")]
		private bool withoutFailing_;

		[Cpp2IlInjected.Token(Token = "0x4001EA2")]
		public const int UseMilestoneAsFriendshipLevelFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4001EA3")]
		private bool useMilestoneAsFriendshipLevel_;

		[Cpp2IlInjected.Token(Token = "0x4001EA4")]
		public const int CatchFishFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x4001EA5")]
		public const int CollectCurrencyFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x4001EA6")]
		public const int CookMealFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x4001EA7")]
		public const int DesignChallengeFieldNumber = 25;

		[Cpp2IlInjected.Token(Token = "0x4001EA8")]
		public const int GardeningHarvestFieldNumber = 28;

		[Cpp2IlInjected.Token(Token = "0x4001EA9")]
		public const int GardeningPlantFieldNumber = 29;

		[Cpp2IlInjected.Token(Token = "0x4001EAA")]
		public const int PossessFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x4001EAB")]
		public const int PickUpFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4001EAC")]
		public const int PurchaseItemFieldNumber = 32;

		[Cpp2IlInjected.Token(Token = "0x4001EAD")]
		public const int SellItemFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x4001EAE")]
		public const int TakePictureFieldNumber = 35;

		[Cpp2IlInjected.Token(Token = "0x4001EAF")]
		public const int DressUpFieldNumber = 37;

		[Cpp2IlInjected.Token(Token = "0x4001EB0")]
		public const int BuildFriendHousesFieldNumber = 40;

		[Cpp2IlInjected.Token(Token = "0x4001EB1")]
		public const int GiftToCharacterFieldNumber = 41;

		[Cpp2IlInjected.Token(Token = "0x4001EB2")]
		public const int StartDiscussionFieldNumber = 42;

		[Cpp2IlInjected.Token(Token = "0x4001EB3")]
		public const int MineMineralFieldNumber = 43;

		[Cpp2IlInjected.Token(Token = "0x4001EB4")]
		public const int WaterPlantFieldNumber = 44;

		[Cpp2IlInjected.Token(Token = "0x4001EB5")]
		public const int FeedCritterFieldNumber = 45;

		[Cpp2IlInjected.Token(Token = "0x4001EB6")]
		public const int MakeFriendFieldNumber = 46;

		[Cpp2IlInjected.Token(Token = "0x4001EB7")]
		public const int UpgradeFieldNumber = 47;

		[Cpp2IlInjected.Token(Token = "0x4001EB8")]
		public const int UnlockFieldNumber = 48;

		[Cpp2IlInjected.Token(Token = "0x4001EB9")]
		public const int ExpandHouseFieldNumber = 49;

		[Cpp2IlInjected.Token(Token = "0x4001EBA")]
		public const int RoyalDutyFieldNumber = 50;

		[Cpp2IlInjected.Token(Token = "0x4001EBB")]
		public const int EatMealFieldNumber = 51;

		[Cpp2IlInjected.Token(Token = "0x4001EBC")]
		public const int DecorateFieldNumber = 52;

		[Cpp2IlInjected.Token(Token = "0x4001EBD")]
		public const int MilestonesFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4001EBE")]
		private static readonly FieldCodec<AchievementMilestone> _repeated_milestones_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001EBF")]
		private readonly RepeatedField<AchievementMilestone> milestones_ = (RepeatedField<AchievementMilestone>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001EC0")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001EC1")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001EC2")]
		private object step_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001EC3")]
		private StepOneofCase stepCase_;

		[Cpp2IlInjected.Token(Token = "0x17001213")]
		[DebuggerNonUserCode]
		public static MessageParser<AchievementItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004602")]
			[Cpp2IlInjected.Address(RVA = "0x314B4F0", Offset = "0x3149EF0", VA = "0x18314B4F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001214")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004603")]
			[Cpp2IlInjected.Address(RVA = "0x314ACD0", Offset = "0x31496D0", VA = "0x18314ACD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001215")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004604")]
			[Cpp2IlInjected.Address(RVA = "0x314B910", Offset = "0x314A310", VA = "0x18314B910", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001216")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004608")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004609")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001217")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600460A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600460B")]
			[Cpp2IlInjected.Address(RVA = "0x314BF30", Offset = "0x314A930", VA = "0x18314BF30")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001218")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600460C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600460D")]
			[Cpp2IlInjected.Address(RVA = "0x314BC10", Offset = "0x314A610", VA = "0x18314BC10")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001219")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600460E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600460F")]
			[Cpp2IlInjected.Address(RVA = "0x314BE40", Offset = "0x314A840", VA = "0x18314BE40")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121A")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004610")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004611")]
			[Cpp2IlInjected.Address(RVA = "0x314C020", Offset = "0x314AA20", VA = "0x18314C020")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121B")]
		[DebuggerNonUserCode]
		public DutyStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6004612")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004613")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121C")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6004614")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004615")]
			[Cpp2IlInjected.Address(RVA = "0x314C1D0", Offset = "0x314ABD0", VA = "0x18314C1D0")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121D")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6004616")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004617")]
			[Cpp2IlInjected.Address(RVA = "0x314BB60", Offset = "0x314A560", VA = "0x18314BB60")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121E")]
		[DebuggerNonUserCode]
		public AchievementType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004618")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004619")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121F")]
		[DebuggerNonUserCode]
		public bool DifferentTypesOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600461A")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0")]
			get
			{
				return differentTypesOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x600461B")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			set
			{
				differentTypesOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001220")]
		[DebuggerNonUserCode]
		public bool WithoutFailing
		{
			[Cpp2IlInjected.Token(Token = "0x600461C")]
			[Cpp2IlInjected.Address(RVA = "0xDD7060", Offset = "0xDD5A60", VA = "0x180DD7060")]
			get
			{
				return withoutFailing_;
			}
			[Cpp2IlInjected.Token(Token = "0x600461D")]
			[Cpp2IlInjected.Address(RVA = "0xDD7120", Offset = "0xDD5B20", VA = "0x180DD7120")]
			set
			{
				withoutFailing_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001221")]
		[DebuggerNonUserCode]
		public bool UseMilestoneAsFriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600461E")]
			[Cpp2IlInjected.Address(RVA = "0xDD7070", Offset = "0xDD5A70", VA = "0x180DD7070")]
			get
			{
				return useMilestoneAsFriendshipLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x600461F")]
			[Cpp2IlInjected.Address(RVA = "0xDD7130", Offset = "0xDD5B30", VA = "0x180DD7130")]
			set
			{
				useMilestoneAsFriendshipLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001222")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish CatchFish
		{
			[Cpp2IlInjected.Token(Token = "0x6004620")]
			[Cpp2IlInjected.Address(RVA = "0x314AB50", Offset = "0x3149550", VA = "0x18314AB50")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.CatchFish)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004621")]
			[Cpp2IlInjected.Address(RVA = "0x314BA60", Offset = "0x314A460", VA = "0x18314BA60")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001223")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency CollectCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x6004622")]
			[Cpp2IlInjected.Address(RVA = "0x314ABB0", Offset = "0x31495B0", VA = "0x18314ABB0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.CollectCurrency)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004623")]
			[Cpp2IlInjected.Address(RVA = "0x314BAA0", Offset = "0x314A4A0", VA = "0x18314BAA0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001224")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal CookMeal
		{
			[Cpp2IlInjected.Token(Token = "0x6004624")]
			[Cpp2IlInjected.Address(RVA = "0x314AC10", Offset = "0x3149610", VA = "0x18314AC10")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.CookMeal)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004625")]
			[Cpp2IlInjected.Address(RVA = "0x314BAE0", Offset = "0x314A4E0", VA = "0x18314BAE0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001225")]
		[DebuggerNonUserCode]
		public CustomStepDesignChallenge DesignChallenge
		{
			[Cpp2IlInjected.Token(Token = "0x6004626")]
			[Cpp2IlInjected.Address(RVA = "0x314ADA0", Offset = "0x31497A0", VA = "0x18314ADA0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.DesignChallenge)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004627")]
			[Cpp2IlInjected.Address(RVA = "0x314BBD0", Offset = "0x314A5D0", VA = "0x18314BBD0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001226")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest GardeningHarvest
		{
			[Cpp2IlInjected.Token(Token = "0x6004628")]
			[Cpp2IlInjected.Address(RVA = "0x314AFE0", Offset = "0x31499E0", VA = "0x18314AFE0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.GardeningHarvest)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004629")]
			[Cpp2IlInjected.Address(RVA = "0x314BD80", Offset = "0x314A780", VA = "0x18314BD80")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001227")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant GardeningPlant
		{
			[Cpp2IlInjected.Token(Token = "0x600462A")]
			[Cpp2IlInjected.Address(RVA = "0x314B040", Offset = "0x3149A40", VA = "0x18314B040")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.GardeningPlant)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600462B")]
			[Cpp2IlInjected.Address(RVA = "0x314BDC0", Offset = "0x314A7C0", VA = "0x18314BDC0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001228")]
		[DebuggerNonUserCode]
		public CustomStepPossess Possess
		{
			[Cpp2IlInjected.Token(Token = "0x600462C")]
			[Cpp2IlInjected.Address(RVA = "0x314B5B0", Offset = "0x3149FB0", VA = "0x18314B5B0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.Possess)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600462D")]
			[Cpp2IlInjected.Address(RVA = "0x314BFE0", Offset = "0x314A9E0", VA = "0x18314BFE0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001229")]
		[DebuggerNonUserCode]
		public CustomStepPickUp PickUp
		{
			[Cpp2IlInjected.Token(Token = "0x600462E")]
			[Cpp2IlInjected.Address(RVA = "0x314B550", Offset = "0x3149F50", VA = "0x18314B550")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.PickUp)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600462F")]
			[Cpp2IlInjected.Address(RVA = "0x314BFA0", Offset = "0x314A9A0", VA = "0x18314BFA0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122A")]
		[DebuggerNonUserCode]
		public CustomStepPurchaseItem PurchaseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004630")]
			[Cpp2IlInjected.Address(RVA = "0x314B610", Offset = "0x314A010", VA = "0x18314B610")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.PurchaseItem)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004631")]
			[Cpp2IlInjected.Address(RVA = "0x314C090", Offset = "0x314AA90", VA = "0x18314C090")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122B")]
		[DebuggerNonUserCode]
		public CustomStepSellItem SellItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004632")]
			[Cpp2IlInjected.Address(RVA = "0x314B6D0", Offset = "0x314A0D0", VA = "0x18314B6D0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.SellItem)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004633")]
			[Cpp2IlInjected.Address(RVA = "0x314C110", Offset = "0x314AB10", VA = "0x18314C110")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122C")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture TakePicture
		{
			[Cpp2IlInjected.Token(Token = "0x6004634")]
			[Cpp2IlInjected.Address(RVA = "0x314B790", Offset = "0x314A190", VA = "0x18314B790")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.TakePicture)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004635")]
			[Cpp2IlInjected.Address(RVA = "0x314C190", Offset = "0x314AB90", VA = "0x18314C190")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122D")]
		[DebuggerNonUserCode]
		public CustomStepDressUp DressUp
		{
			[Cpp2IlInjected.Token(Token = "0x6004636")]
			[Cpp2IlInjected.Address(RVA = "0x314AE00", Offset = "0x3149800", VA = "0x18314AE00")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.DressUp)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004637")]
			[Cpp2IlInjected.Address(RVA = "0x314BC80", Offset = "0x314A680", VA = "0x18314BC80")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122E")]
		[DebuggerNonUserCode]
		public CustomStepFinishHouse BuildFriendHouses
		{
			[Cpp2IlInjected.Token(Token = "0x6004638")]
			[Cpp2IlInjected.Address(RVA = "0x314AAF0", Offset = "0x31494F0", VA = "0x18314AAF0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.BuildFriendHouses)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004639")]
			[Cpp2IlInjected.Address(RVA = "0x314BA20", Offset = "0x314A420", VA = "0x18314BA20")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122F")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem GiftToCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600463A")]
			[Cpp2IlInjected.Address(RVA = "0x314B0E0", Offset = "0x3149AE0", VA = "0x18314B0E0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.GiftToCharacter)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600463B")]
			[Cpp2IlInjected.Address(RVA = "0x314BE00", Offset = "0x314A800", VA = "0x18314BE00")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001230")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion StartDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x600463C")]
			[Cpp2IlInjected.Address(RVA = "0x314B730", Offset = "0x314A130", VA = "0x18314B730")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.StartDiscussion)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600463D")]
			[Cpp2IlInjected.Address(RVA = "0x314C150", Offset = "0x314AB50", VA = "0x18314C150")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001231")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral MineMineral
		{
			[Cpp2IlInjected.Token(Token = "0x600463E")]
			[Cpp2IlInjected.Address(RVA = "0x314B490", Offset = "0x3149E90", VA = "0x18314B490")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.MineMineral)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600463F")]
			[Cpp2IlInjected.Address(RVA = "0x314BEF0", Offset = "0x314A8F0", VA = "0x18314BEF0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001232")]
		[DebuggerNonUserCode]
		public CustomStepWaterPlant WaterPlant
		{
			[Cpp2IlInjected.Token(Token = "0x6004640")]
			[Cpp2IlInjected.Address(RVA = "0x314B8B0", Offset = "0x314A2B0", VA = "0x18314B8B0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.WaterPlant)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004641")]
			[Cpp2IlInjected.Address(RVA = "0x314C2C0", Offset = "0x314ACC0", VA = "0x18314C2C0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001233")]
		[DebuggerNonUserCode]
		public CustomStepFeedCritter FeedCritter
		{
			[Cpp2IlInjected.Token(Token = "0x6004642")]
			[Cpp2IlInjected.Address(RVA = "0x314AF80", Offset = "0x3149980", VA = "0x18314AF80")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.FeedCritter)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004643")]
			[Cpp2IlInjected.Address(RVA = "0x314BD40", Offset = "0x314A740", VA = "0x18314BD40")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001234")]
		[DebuggerNonUserCode]
		public CustomStepFriend MakeFriend
		{
			[Cpp2IlInjected.Token(Token = "0x6004644")]
			[Cpp2IlInjected.Address(RVA = "0x314B430", Offset = "0x3149E30", VA = "0x18314B430")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.MakeFriend)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004645")]
			[Cpp2IlInjected.Address(RVA = "0x314BEB0", Offset = "0x314A8B0", VA = "0x18314BEB0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001235")]
		[DebuggerNonUserCode]
		public CustomStepUpgrade Upgrade
		{
			[Cpp2IlInjected.Token(Token = "0x6004646")]
			[Cpp2IlInjected.Address(RVA = "0x314B850", Offset = "0x314A250", VA = "0x18314B850")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.Upgrade)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004647")]
			[Cpp2IlInjected.Address(RVA = "0x314C280", Offset = "0x314AC80", VA = "0x18314C280")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001236")]
		[DebuggerNonUserCode]
		public CustomStepUnlock Unlock
		{
			[Cpp2IlInjected.Token(Token = "0x6004648")]
			[Cpp2IlInjected.Address(RVA = "0x314B7F0", Offset = "0x314A1F0", VA = "0x18314B7F0")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.Unlock)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004649")]
			[Cpp2IlInjected.Address(RVA = "0x314C240", Offset = "0x314AC40", VA = "0x18314C240")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001237")]
		[DebuggerNonUserCode]
		public CustomStepExpandHouse ExpandHouse
		{
			[Cpp2IlInjected.Token(Token = "0x600464A")]
			[Cpp2IlInjected.Address(RVA = "0x314AF20", Offset = "0x3149920", VA = "0x18314AF20")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.ExpandHouse)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600464B")]
			[Cpp2IlInjected.Address(RVA = "0x314BD00", Offset = "0x314A700", VA = "0x18314BD00")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001238")]
		[DebuggerNonUserCode]
		public CustomStepRoyalDuties RoyalDuty
		{
			[Cpp2IlInjected.Token(Token = "0x600464C")]
			[Cpp2IlInjected.Address(RVA = "0x314B670", Offset = "0x314A070", VA = "0x18314B670")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.RoyalDuty)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600464D")]
			[Cpp2IlInjected.Address(RVA = "0x314C0D0", Offset = "0x314AAD0", VA = "0x18314C0D0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001239")]
		[DebuggerNonUserCode]
		public CustomStepEatMeal EatMeal
		{
			[Cpp2IlInjected.Token(Token = "0x600464E")]
			[Cpp2IlInjected.Address(RVA = "0x314AE60", Offset = "0x3149860", VA = "0x18314AE60")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.EatMeal)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600464F")]
			[Cpp2IlInjected.Address(RVA = "0x314BCC0", Offset = "0x314A6C0", VA = "0x18314BCC0")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700123A")]
		[DebuggerNonUserCode]
		public CustomStepDecorate Decorate
		{
			[Cpp2IlInjected.Token(Token = "0x6004650")]
			[Cpp2IlInjected.Address(RVA = "0x314AC70", Offset = "0x3149670", VA = "0x18314AC70")]
			get
			{
				int num = 0;
				if (stepCase_ == StepOneofCase.Decorate)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004651")]
			[Cpp2IlInjected.Address(RVA = "0x314BB20", Offset = "0x314A520", VA = "0x18314BB20")]
			set
			{
				step_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700123B")]
		[DebuggerNonUserCode]
		public RepeatedField<AchievementMilestone> Milestones
		{
			[Cpp2IlInjected.Token(Token = "0x6004652")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return milestones_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700123C")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6004653")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004654")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700123D")]
		[DebuggerNonUserCode]
		public StepOneofCase StepCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004655")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return stepCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700123E")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004664")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700123F")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6004665")]
			[Cpp2IlInjected.Address(RVA = "0x314B370", Offset = "0x3149D70", VA = "0x18314B370", Slot = "26")]
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

		[Cpp2IlInjected.Token(Token = "0x17001240")]
		public IUniqueItem GetIUniqueItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004667")]
			[Cpp2IlInjected.Address(RVA = "0x314B0A0", Offset = "0x3149AA0", VA = "0x18314B0A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001241")]
		string[] IStringTag.StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6004668")]
			[Cpp2IlInjected.Address(RVA = "0x3144130", Offset = "0x3142B30", VA = "0x183144130", Slot = "25")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("itemname" != null && "itemname" == null)
					{
						continue;
					}
					array[0] = "itemname";
					if ("milestone" != null && "milestone" == null)
					{
						continue;
					}
					array[1] = "milestone";
					if ("last_milestone" == null || "last_milestone" != null)
					{
						array[2] = "last_milestone";
						if ("level" == null || "level" != null)
						{
							break;
						}
					}
				}
				array[3] = "level";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001242")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004669")]
			[Cpp2IlInjected.Address(RVA = "0x314AEC0", Offset = "0x31498C0", VA = "0x18314AEC0", Slot = "29")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001243")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600466A")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "30")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001244")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x600466B")]
			[Cpp2IlInjected.Address(RVA = "0x314B140", Offset = "0x3149B40", VA = "0x18314B140", Slot = "31")]
			get
			{
				RepeatedField<AchievementMilestone> repeatedField = milestones_;
				Func<AchievementMilestone, bool> _003C_003E9__215_ = _003C_003Ec._003C_003E9__215_0;
				if (_003C_003E9__215_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(AchievementMilestone x)
					{
						//Discarded unreachable code: IL_000f
						int rewardItem_2 = x.rewardItem_;
						ItemType itemType = default(ItemType);
						return itemType != ItemType.Currency;
					};
				}
				IEnumerable<AchievementMilestone> enumerable = (IEnumerable<AchievementMilestone>)Enumerable.Where<AchievementMilestone>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__215_);
				Func<AchievementMilestone, Item> func = default(Func<AchievementMilestone, Item>);
				if (_003C_003Ec._003C_003E9__215_1 == null)
				{
					func = (Func<AchievementMilestone, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(AchievementMilestone x)
					{
						//Discarded unreachable code: IL_000d
						int rewardItem_ = x.rewardItem_;
						return (Item)typeof(Item).TypeHandle;
					});
				}
				return (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<AchievementMilestone, Item>((IEnumerable<>)enumerable, (Func<, >)(object)func));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004605")]
		[Cpp2IlInjected.Address(RVA = "0x314A150", Offset = "0x3148B50", VA = "0x18314A150")]
		[DebuggerNonUserCode]
		public AchievementItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004606")]
		[Cpp2IlInjected.Address(RVA = "0x314A250", Offset = "0x3148C50", VA = "0x18314A250")]
		[DebuggerNonUserCode]
		public AchievementItemData(AchievementItemData other)
		{
			//IL_0356: Expected I4, but got O
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			DutyStatus dutyStatus = (status_ = other.status_);
			string text5 = (title_ = other.title_);
			string text6 = (description_ = other.description_);
			AchievementType achievementType = (type_ = other.type_);
			bool flag = (differentTypesOnly_ = other.differentTypesOnly_);
			bool flag2 = (withoutFailing_ = other.withoutFailing_);
			bool flag3 = (useMilestoneAsFriendshipLevel_ = other.useMilestoneAsFriendshipLevel_);
			RepeatedField<AchievementMilestone> repeatedField = (milestones_ = (RepeatedField<AchievementMilestone>)(object)((RepeatedField<T>)(object)other.milestones_).Clone());
			uint num2 = (glotID_ = other.glotID_);
			if (other.stepCase_ <= StepOneofCase.PickUp)
			{
				CustomStepCatchFish customStepCatchFish = (CustomStepCatchFish)(step_ = other.CatchFish.Clone());
				CustomStepCollectCurrency customStepCollectCurrency = (CustomStepCollectCurrency)(step_ = other.CollectCurrency.Clone());
				CustomStepCookMeal customStepCookMeal = (CustomStepCookMeal)(step_ = other.CookMeal.Clone());
				CustomStepDesignChallenge customStepDesignChallenge = (CustomStepDesignChallenge)(step_ = other.DesignChallenge.Clone());
				CustomStepGardeningHarvest customStepGardeningHarvest = (CustomStepGardeningHarvest)(step_ = other.GardeningHarvest.Clone());
				CustomStepGardeningPlant customStepGardeningPlant = (CustomStepGardeningPlant)(step_ = other.GardeningPlant.Clone());
				CustomStepPossess customStepPossess = (CustomStepPossess)(step_ = other.Possess.Clone());
				CustomStepPickUp customStepPickUp = (CustomStepPickUp)(step_ = other.PickUp.Clone());
				CustomStepPurchaseItem customStepPurchaseItem = (CustomStepPurchaseItem)(step_ = other.PurchaseItem.Clone());
				CustomStepSellItem customStepSellItem = (CustomStepSellItem)(step_ = other.SellItem.Clone());
				CustomStepTakePicture customStepTakePicture = (CustomStepTakePicture)(step_ = other.TakePicture.Clone());
				CustomStepDressUp customStepDressUp = (CustomStepDressUp)(step_ = other.DressUp.Clone());
				CustomStepFinishHouse customStepFinishHouse = (CustomStepFinishHouse)(step_ = other.BuildFriendHouses.Clone());
				CustomStepGiftToCharacterItem customStepGiftToCharacterItem = (CustomStepGiftToCharacterItem)(step_ = other.GiftToCharacter.Clone());
				CustomStepStartDiscussion customStepStartDiscussion = (CustomStepStartDiscussion)(step_ = other.StartDiscussion.Clone());
				CustomStepMineMineral customStepMineMineral = (CustomStepMineMineral)(step_ = other.MineMineral.Clone());
				CustomStepWaterPlant customStepWaterPlant = (CustomStepWaterPlant)(step_ = other.WaterPlant.Clone());
				CustomStepFeedCritter customStepFeedCritter = (CustomStepFeedCritter)(step_ = other.FeedCritter.Clone());
				CustomStepFriend customStepFriend = (CustomStepFriend)(step_ = other.MakeFriend.Clone());
				CustomStepUpgrade customStepUpgrade = (CustomStepUpgrade)(step_ = other.Upgrade.Clone());
				CustomStepUnlock customStepUnlock = (CustomStepUnlock)(step_ = other.Unlock.Clone());
				CustomStepExpandHouse customStepExpandHouse = (CustomStepExpandHouse)(step_ = other.ExpandHouse.Clone());
				CustomStepRoyalDuties customStepRoyalDuties = (CustomStepRoyalDuties)(step_ = other.RoyalDuty.Clone());
				CustomStepEatMeal customStepEatMeal = (CustomStepEatMeal)(step_ = other.EatMeal.Clone());
				stepCase_ = (StepOneofCase)(step_ = other.Decorate.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004607")]
		[Cpp2IlInjected.Address(RVA = "0x3143DA0", Offset = "0x31427A0", VA = "0x183143DA0", Slot = "10")]
		[DebuggerNonUserCode]
		public AchievementItemData Clone()
		{
			return new AchievementItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004656")]
		[Cpp2IlInjected.Address(RVA = "0x3143D80", Offset = "0x3142780", VA = "0x183143D80")]
		[DebuggerNonUserCode]
		public void ClearStep()
		{
			//IL_0010: Expected O, but got I4
			step_ = (stepCase_ = StepOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004657")]
		[Cpp2IlInjected.Address(RVA = "0x3144340", Offset = "0x3142D40", VA = "0x183144340", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((AchievementItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004658")]
		[Cpp2IlInjected.Address(RVA = "0x31443A0", Offset = "0x3142DA0", VA = "0x1831443A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AchievementItemData other)
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
									DutyStatus dutyStatus = other.status_;
									if (status_ == dutyStatus)
									{
										string text5 = other.title_;
										if (!(title_ != text5))
										{
											string text6 = other.description_;
											if (!(description_ != text6))
											{
												AchievementType achievementType = other.type_;
												if (type_ == achievementType)
												{
													bool flag = other.differentTypesOnly_;
													if (differentTypesOnly_ == flag)
													{
														bool flag2 = other.withoutFailing_;
														if (withoutFailing_ == flag2)
														{
															bool flag3 = other.useMilestoneAsFriendshipLevel_;
															if (useMilestoneAsFriendshipLevel_ == flag3)
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
																						CustomStepPossess possess = Possess;
																						CustomStepPossess possess2 = other.Possess;
																						if (object.Equals(possess, possess2))
																						{
																							CustomStepPickUp pickUp = PickUp;
																							CustomStepPickUp pickUp2 = other.PickUp;
																							if (object.Equals(pickUp, pickUp2))
																							{
																								CustomStepPurchaseItem purchaseItem = PurchaseItem;
																								CustomStepPurchaseItem purchaseItem2 = other.PurchaseItem;
																								if (object.Equals(purchaseItem, purchaseItem2))
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
																												CustomStepFinishHouse buildFriendHouses = BuildFriendHouses;
																												CustomStepFinishHouse buildFriendHouses2 = other.BuildFriendHouses;
																												if (object.Equals(buildFriendHouses, buildFriendHouses2))
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
																																						CustomStepRoyalDuties royalDuty = RoyalDuty;
																																						CustomStepRoyalDuties royalDuty2 = other.RoyalDuty;
																																						if (object.Equals(royalDuty, royalDuty2))
																																						{
																																							CustomStepEatMeal eatMeal = EatMeal;
																																							CustomStepEatMeal eatMeal2 = other.EatMeal;
																																							if (object.Equals(eatMeal, eatMeal2))
																																							{
																																								CustomStepDecorate decorate = Decorate;
																																								CustomStepDecorate decorate2 = other.Decorate;
																																								if (object.Equals(decorate, decorate2))
																																								{
																																									RepeatedField<AchievementMilestone> repeatedField = milestones_;
																																									RepeatedField<AchievementMilestone> repeatedField2 = other.milestones_;
																																									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																																									{
																																										uint num2 = other.glotID_;
																																										if (glotID_ == num2)
																																										{
																																											StepOneofCase stepOneofCase = other.stepCase_;
																																											if (stepCase_ == stepOneofCase)
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
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004659")]
		[Cpp2IlInjected.Address(RVA = "0x3144E70", Offset = "0x3143870", VA = "0x183144E70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_04ba
			while (true)
			{
				int num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = name_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = iconAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = prefabAddress_;
				if (text4.m_stringLength != num2)
				{
					int hashCode4 = text4.GetHashCode();
				}
				if (status_ != 0)
				{
				}
				string text5 = title_;
				if (text5.m_stringLength != num2)
				{
					int hashCode5 = text5.GetHashCode();
				}
				string text6 = description_;
				if (text6.m_stringLength != num2)
				{
					int hashCode6 = text6.GetHashCode();
				}
				if (type_ != 0)
				{
				}
				if (differentTypesOnly_)
				{
				}
				if (withoutFailing_)
				{
				}
				if (useMilestoneAsFriendshipLevel_)
				{
				}
				if (stepCase_ != StepOneofCase.CatchFish)
				{
					continue;
				}
				object obj = step_;
				if (obj != null)
				{
					int hashCode7 = obj.GetHashCode();
					if (stepCase_ != StepOneofCase.CollectCurrency)
					{
						continue;
					}
					object obj2 = step_;
					if (obj2 != null)
					{
						int hashCode8 = obj2.GetHashCode();
						if (stepCase_ != StepOneofCase.CookMeal)
						{
							continue;
						}
						object obj3 = step_;
						if (obj3 != null)
						{
							int hashCode9 = obj3.GetHashCode();
							if (stepCase_ != StepOneofCase.DesignChallenge)
							{
								continue;
							}
							object obj4 = step_;
							if (obj4 != null)
							{
								int hashCode10 = obj4.GetHashCode();
								if (stepCase_ != StepOneofCase.GardeningHarvest)
								{
									continue;
								}
								object obj5 = step_;
								if (obj5 != null)
								{
									int hashCode11 = obj5.GetHashCode();
									if (stepCase_ != StepOneofCase.GardeningPlant)
									{
										continue;
									}
									object obj6 = step_;
									if (obj6 != null)
									{
										int hashCode12 = obj6.GetHashCode();
										if (stepCase_ != StepOneofCase.Possess)
										{
											continue;
										}
										object obj7 = step_;
										if (obj7 != null)
										{
											int hashCode13 = obj7.GetHashCode();
											if (stepCase_ != StepOneofCase.PickUp)
											{
												continue;
											}
											object obj8 = step_;
											if (obj8 != null)
											{
												int hashCode14 = obj8.GetHashCode();
												if (stepCase_ != StepOneofCase.PurchaseItem)
												{
													continue;
												}
												object obj9 = step_;
												if (obj9 != null)
												{
													int hashCode15 = obj9.GetHashCode();
													if (stepCase_ != StepOneofCase.SellItem)
													{
														continue;
													}
													object obj10 = step_;
													if (obj10 != null)
													{
														int hashCode16 = obj10.GetHashCode();
														if (stepCase_ != StepOneofCase.TakePicture)
														{
															continue;
														}
														object obj11 = step_;
														if (obj11 != null)
														{
															int hashCode17 = obj11.GetHashCode();
															if (stepCase_ != StepOneofCase.DressUp)
															{
																continue;
															}
															object obj12 = step_;
															if (obj12 != null)
															{
																int hashCode18 = obj12.GetHashCode();
																if (stepCase_ != StepOneofCase.BuildFriendHouses)
																{
																	continue;
																}
																object obj13 = step_;
																if (obj13 != null)
																{
																	int hashCode19 = obj13.GetHashCode();
																	if (stepCase_ != StepOneofCase.GiftToCharacter)
																	{
																		continue;
																	}
																	object obj14 = step_;
																	if (obj14 != null)
																	{
																		int hashCode20 = obj14.GetHashCode();
																		if (stepCase_ != StepOneofCase.StartDiscussion)
																		{
																			continue;
																		}
																		object obj15 = step_;
																		if (obj15 != null)
																		{
																			int hashCode21 = obj15.GetHashCode();
																			if (stepCase_ != StepOneofCase.MineMineral)
																			{
																				continue;
																			}
																			object obj16 = step_;
																			if (obj16 != null)
																			{
																				int hashCode22 = obj16.GetHashCode();
																				if (stepCase_ != StepOneofCase.WaterPlant)
																				{
																					continue;
																				}
																				object obj17 = step_;
																				if (obj17 != null)
																				{
																					int hashCode23 = obj17.GetHashCode();
																					if (stepCase_ != StepOneofCase.FeedCritter)
																					{
																						continue;
																					}
																					object obj18 = step_;
																					if (obj18 != null)
																					{
																						int hashCode24 = obj18.GetHashCode();
																						if (stepCase_ != StepOneofCase.MakeFriend)
																						{
																							continue;
																						}
																						object obj19 = step_;
																						if (obj19 != null)
																						{
																							int hashCode25 = obj19.GetHashCode();
																							if (stepCase_ != StepOneofCase.Upgrade)
																							{
																								continue;
																							}
																							object obj20 = step_;
																							if (obj20 != null)
																							{
																								int hashCode26 = obj20.GetHashCode();
																								if (stepCase_ != StepOneofCase.Unlock)
																								{
																									continue;
																								}
																								object obj21 = step_;
																								if (obj21 != null)
																								{
																									int hashCode27 = obj21.GetHashCode();
																									if (stepCase_ != StepOneofCase.ExpandHouse)
																									{
																										continue;
																									}
																									object obj22 = step_;
																									if (obj22 != null)
																									{
																										int hashCode28 = obj22.GetHashCode();
																										if (stepCase_ != StepOneofCase.RoyalDuty)
																										{
																											continue;
																										}
																										object obj23 = step_;
																										if (obj23 != null)
																										{
																											int hashCode29 = obj23.GetHashCode();
																											if (stepCase_ != StepOneofCase.EatMeal)
																											{
																												continue;
																											}
																											object obj24 = step_;
																											if (obj24 != null)
																											{
																												int hashCode30 = obj24.GetHashCode();
																												if (stepCase_ == StepOneofCase.Decorate)
																												{
																													object obj25 = step_;
																													if (obj25 == null)
																													{
																														break;
																													}
																													int hashCode31 = obj25.GetHashCode();
																												}
																												int hashCode32 = ((RepeatedField<T>)(object)milestones_).GetHashCode();
																												if (glotID_ != 0)
																												{
																												}
																												UnknownFieldSet unknownFields = _unknownFields;
																												if (unknownFields != null)
																												{
																													int hashCode33 = unknownFields.GetHashCode();
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
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600465A")]
		[Cpp2IlInjected.Address(RVA = "0x3149000", Offset = "0x3147A00", VA = "0x183149000", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600465B")]
		[Cpp2IlInjected.Address(RVA = "0x3149060", Offset = "0x3147A60", VA = "0x183149060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_05bb
			while (true)
			{
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
				if (status_ != 0)
				{
				}
				if (title_.m_stringLength != 0)
				{
					string value6 = title_;
					output.WriteString(value6);
				}
				if (description_.m_stringLength != 0)
				{
					string value7 = description_;
					output.WriteString(value7);
				}
				if (type_ != 0)
				{
				}
				if (differentTypesOnly_)
				{
					bool value8 = differentTypesOnly_;
					output.WriteBool(value8);
				}
				if (withoutFailing_)
				{
					bool value9 = withoutFailing_;
					output.WriteBool(value9);
				}
				if (useMilestoneAsFriendshipLevel_)
				{
					bool value10 = useMilestoneAsFriendshipLevel_;
					output.WriteBool(value10);
				}
				RepeatedField<AchievementMilestone> repeatedField = milestones_;
				FieldCodec<AchievementMilestone> repeated_milestones_codec = _repeated_milestones_codec;
				((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_milestones_codec);
				StepOneofCase stepOneofCase = stepCase_;
				int num = 0;
				if (stepOneofCase != StepOneofCase.CatchFish)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.CatchFish)
				{
					object obj = step_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.CollectCurrency)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.CollectCurrency)
				{
					object obj2 = step_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.CookMeal)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.CookMeal)
				{
					object obj3 = step_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.DesignChallenge)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.DesignChallenge)
				{
					object obj4 = step_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.GardeningHarvest)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.GardeningHarvest)
				{
					object obj5 = step_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.GardeningPlant)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.GardeningPlant)
				{
					object obj6 = step_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.Possess)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.Possess)
				{
					object obj7 = step_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.PickUp)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.PickUp)
				{
					object obj8 = step_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.PurchaseItem)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.PurchaseItem)
				{
					object obj9 = step_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.SellItem)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.SellItem)
				{
					object obj10 = step_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.TakePicture)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.TakePicture)
				{
					object obj11 = step_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.DressUp)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.DressUp)
				{
					object obj12 = step_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.BuildFriendHouses)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.BuildFriendHouses)
				{
					object obj13 = step_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.GiftToCharacter)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.GiftToCharacter)
				{
					object obj14 = step_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.StartDiscussion)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.StartDiscussion)
				{
					object obj15 = step_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.MineMineral)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.MineMineral)
				{
					object obj16 = step_;
					if (obj16 != null && obj16 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.WaterPlant)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.WaterPlant)
				{
					object obj17 = step_;
					if (obj17 != null && obj17 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.FeedCritter)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.FeedCritter)
				{
					object obj18 = step_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.MakeFriend)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.MakeFriend)
				{
					object obj19 = step_;
					if (obj19 != null && obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.Upgrade)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.Upgrade)
				{
					object obj20 = step_;
					if (obj20 != null && obj20 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.Unlock)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.Unlock)
				{
					object obj21 = step_;
					if (obj21 != null && obj21 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.ExpandHouse)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.ExpandHouse)
				{
					object obj22 = step_;
					if (obj22 != null && obj22 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ != StepOneofCase.RoyalDuty)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.RoyalDuty)
				{
					object obj23 = step_;
					if (obj23 != null && obj23 == null)
					{
						break;
					}
				}
				if (stepCase_ != StepOneofCase.EatMeal)
				{
					continue;
				}
				if (stepCase_ == StepOneofCase.EatMeal)
				{
					object obj24 = step_;
					if (obj24 != null && obj24 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepCase_ == StepOneofCase.Decorate && stepCase_ == StepOneofCase.Decorate)
				{
					object obj25 = step_;
					if (obj25 != null && obj25 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (glotID_ != 0)
				{
					uint value11 = glotID_;
					output.WriteUInt32(value11);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600465C")]
		[Cpp2IlInjected.Address(RVA = "0x3142AB0", Offset = "0x31414B0", VA = "0x183142AB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0677
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			DutyStatus dutyStatus = status_;
			if (dutyStatus != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)dutyStatus);
				num8++;
				num2 += num8;
			}
			string text5 = title_;
			if (text5.m_stringLength != num2)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			string text6 = description_;
			if (text6.m_stringLength != num2)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text6);
				num10++;
				num2 += num10;
			}
			AchievementType achievementType = type_;
			if (achievementType != 0)
			{
				int num11 = CodedOutputStream.ComputeEnumSize((int)achievementType);
				num11++;
				num2 += num11;
			}
			if (stepCase_ == StepOneofCase.CatchFish)
			{
				if (stepCase_ != StepOneofCase.CatchFish)
				{
				}
				object obj = step_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num12 = default(int);
				num2 += num12;
			}
			if (stepCase_ == StepOneofCase.CollectCurrency)
			{
				if (stepCase_ != StepOneofCase.CollectCurrency)
				{
				}
				object obj2 = step_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num13 = default(int);
				num2 += num13;
			}
			if (stepCase_ == StepOneofCase.CookMeal)
			{
				if (stepCase_ != StepOneofCase.CookMeal)
				{
				}
				object obj3 = step_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num14 = default(int);
				num2 += num14;
			}
			if (stepCase_ == StepOneofCase.DesignChallenge)
			{
				if (stepCase_ != StepOneofCase.DesignChallenge)
				{
				}
				object obj4 = step_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num15 = default(int);
				num2 += num15;
			}
			if (stepCase_ == StepOneofCase.GardeningHarvest)
			{
				if (stepCase_ != StepOneofCase.GardeningHarvest)
				{
				}
				object obj5 = step_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num16 = default(int);
				num2 += num16;
			}
			if (stepCase_ == StepOneofCase.GardeningPlant)
			{
				if (stepCase_ != StepOneofCase.GardeningPlant)
				{
				}
				object obj6 = step_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num17 = default(int);
				num2 += num17;
			}
			if (stepCase_ == StepOneofCase.Possess)
			{
				if (stepCase_ != StepOneofCase.Possess)
				{
				}
				object obj7 = step_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num18 = default(int);
				num2 += num18;
			}
			if (stepCase_ == StepOneofCase.PickUp)
			{
				if (stepCase_ != StepOneofCase.PickUp)
				{
				}
				object obj8 = step_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num19 = default(int);
				num2 += num19;
			}
			if (stepCase_ == StepOneofCase.PurchaseItem)
			{
				if (stepCase_ != StepOneofCase.PurchaseItem)
				{
				}
				object obj9 = step_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num20 = default(int);
				num2 += num20;
			}
			if (stepCase_ == StepOneofCase.SellItem)
			{
				if (stepCase_ != StepOneofCase.SellItem)
				{
				}
				object obj10 = step_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num21 = default(int);
				num2 += num21;
			}
			if (stepCase_ == StepOneofCase.TakePicture)
			{
				if (stepCase_ != StepOneofCase.TakePicture)
				{
				}
				object obj11 = step_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num22 = default(int);
				num2 += num22;
			}
			if (stepCase_ == StepOneofCase.DressUp)
			{
				if (stepCase_ != StepOneofCase.DressUp)
				{
				}
				object obj12 = step_;
				if (obj12 != null && obj12 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num23 = default(int);
				num2 += num23;
			}
			if (stepCase_ == StepOneofCase.BuildFriendHouses)
			{
				if (stepCase_ != StepOneofCase.BuildFriendHouses)
				{
				}
				object obj13 = step_;
				if (obj13 != null && obj13 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num24 = default(int);
				num2 += num24;
			}
			if (stepCase_ == StepOneofCase.GiftToCharacter)
			{
				if (stepCase_ != StepOneofCase.GiftToCharacter)
				{
				}
				object obj14 = step_;
				if (obj14 != null && obj14 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num25 = default(int);
				num2 += num25;
			}
			if (stepCase_ == StepOneofCase.StartDiscussion)
			{
				if (stepCase_ != StepOneofCase.StartDiscussion)
				{
				}
				object obj15 = step_;
				if (obj15 != null && obj15 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num26 = default(int);
				num2 += num26;
			}
			if (stepCase_ == StepOneofCase.MineMineral)
			{
				if (stepCase_ != StepOneofCase.MineMineral)
				{
				}
				object obj16 = step_;
				if (obj16 != null && obj16 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num27 = default(int);
				num2 += num27;
			}
			if (stepCase_ == StepOneofCase.WaterPlant)
			{
				if (stepCase_ != StepOneofCase.WaterPlant)
				{
				}
				object obj17 = step_;
				if (obj17 != null && obj17 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num28 = default(int);
				num2 += num28;
			}
			if (stepCase_ == StepOneofCase.FeedCritter)
			{
				if (stepCase_ != StepOneofCase.FeedCritter)
				{
				}
				object obj18 = step_;
				if (obj18 != null && obj18 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num29 = default(int);
				num2 += num29;
			}
			if (stepCase_ == StepOneofCase.MakeFriend)
			{
				if (stepCase_ != StepOneofCase.MakeFriend)
				{
				}
				object obj19 = step_;
				if (obj19 != null && obj19 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num30 = default(int);
				num2 += num30;
			}
			if (stepCase_ == StepOneofCase.Upgrade)
			{
				if (stepCase_ != StepOneofCase.Upgrade)
				{
				}
				object obj20 = step_;
				if (obj20 != null && obj20 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num31 = default(int);
				num2 += num31;
			}
			if (stepCase_ == StepOneofCase.Unlock)
			{
				if (stepCase_ != StepOneofCase.Unlock)
				{
				}
				object obj21 = step_;
				if (obj21 != null && obj21 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num32 = default(int);
				num2 += num32;
			}
			if (stepCase_ == StepOneofCase.ExpandHouse)
			{
				if (stepCase_ != StepOneofCase.ExpandHouse)
				{
				}
				object obj22 = step_;
				if (obj22 != null && obj22 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num33 = default(int);
				num2 += num33;
			}
			if (stepCase_ == StepOneofCase.RoyalDuty)
			{
				if (stepCase_ != StepOneofCase.RoyalDuty)
				{
				}
				object obj23 = step_;
				if (obj23 != null && obj23 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num34 = default(int);
				num2 += num34;
			}
			if (stepCase_ == StepOneofCase.EatMeal)
			{
				if (stepCase_ != StepOneofCase.EatMeal)
				{
				}
				object obj24 = step_;
				if (obj24 != null && obj24 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num35 = default(int);
				num2 += num35;
			}
			if (stepCase_ == StepOneofCase.Decorate)
			{
				if (stepCase_ == StepOneofCase.Decorate)
				{
					object obj25 = step_;
					if (obj25 != null && obj25 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num36 = default(int);
				num2 += num36;
			}
			RepeatedField<AchievementMilestone> repeatedField = milestones_;
			FieldCodec<AchievementMilestone> repeated_milestones_codec = _repeated_milestones_codec;
			int num37 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_milestones_codec);
			uint num38 = glotID_;
			num2 += num37;
			if (num38 != 0)
			{
				int num39 = CodedOutputStream.ComputeUInt32Size(num38);
				num39 += 2;
				num2 += num39;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num40 = unknownFields.CalculateSize();
				num2 += num40;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600465D")]
		[Cpp2IlInjected.Address(RVA = "0x3145C60", Offset = "0x3144660", VA = "0x183145C60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementItemData other)
		{
			//Discarded unreachable code: IL_0702
			//IL_0171: Expected I4, but got O
			//IL_01aa: Expected I4, but got O
			//IL_01e3: Expected I4, but got O
			//IL_021c: Expected I4, but got O
			//IL_0255: Expected I4, but got O
			//IL_028e: Expected I4, but got O
			//IL_02c7: Expected I4, but got O
			//IL_0300: Expected I4, but got O
			//IL_0339: Expected I4, but got O
			//IL_0372: Expected I4, but got O
			//IL_03ab: Expected I4, but got O
			//IL_03e4: Expected I4, but got O
			//IL_041d: Expected I4, but got O
			//IL_0456: Expected I4, but got O
			//IL_048f: Expected I4, but got O
			//IL_04c8: Expected I4, but got O
			//IL_0501: Expected I4, but got O
			//IL_053a: Expected I4, but got O
			//IL_0573: Expected I4, but got O
			//IL_05ac: Expected I4, but got O
			//IL_05e5: Expected I4, but got O
			//IL_061e: Expected I4, but got O
			//IL_0657: Expected I4, but got O
			//IL_0690: Expected I4, but got O
			//IL_06c9: Expected I4, but got O
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
			DutyStatus dutyStatus = other.status_;
			if (dutyStatus != 0)
			{
				status_ = dutyStatus;
			}
			string text5 = other.title_;
			if (text5.m_stringLength != 0)
			{
				Title = text5;
			}
			string text6 = other.description_;
			if (text6.m_stringLength != 0)
			{
				Description = text6;
			}
			AchievementType achievementType = other.type_;
			if (achievementType != 0)
			{
				type_ = achievementType;
			}
			bool flag = other.differentTypesOnly_;
			if (flag)
			{
				differentTypesOnly_ = flag;
			}
			bool flag2 = other.withoutFailing_;
			if (flag2)
			{
				withoutFailing_ = flag2;
			}
			bool flag3 = other.useMilestoneAsFriendshipLevel_;
			if (flag3)
			{
				useMilestoneAsFriendshipLevel_ = flag3;
			}
			RepeatedField<AchievementMilestone> repeatedField = milestones_;
			RepeatedField<AchievementMilestone> repeatedField2 = other.milestones_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			uint num2 = other.glotID_;
			if (num2 != 0)
			{
				glotID_ = num2;
			}
			if (other.stepCase_ <= StepOneofCase.PickUp)
			{
				if (CatchFish == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepCatchFish());
				}
				CustomStepCatchFish catchFish = CatchFish;
				CustomStepCatchFish catchFish2 = other.CatchFish;
				catchFish.MergeFrom(catchFish2);
				if (CollectCurrency == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepCollectCurrency());
				}
				CustomStepCollectCurrency collectCurrency = CollectCurrency;
				CustomStepCollectCurrency collectCurrency2 = other.CollectCurrency;
				collectCurrency.MergeFrom(collectCurrency2);
				if (CookMeal == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepCookMeal());
				}
				CustomStepCookMeal cookMeal = CookMeal;
				CustomStepCookMeal cookMeal2 = other.CookMeal;
				cookMeal.MergeFrom(cookMeal2);
				if (DesignChallenge == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepDesignChallenge());
				}
				CustomStepDesignChallenge designChallenge = DesignChallenge;
				CustomStepDesignChallenge designChallenge2 = other.DesignChallenge;
				designChallenge.MergeFrom(designChallenge2);
				if (GardeningHarvest == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepGardeningHarvest());
				}
				CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
				CustomStepGardeningHarvest gardeningHarvest2 = other.GardeningHarvest;
				gardeningHarvest.MergeFrom(gardeningHarvest2);
				if (GardeningPlant == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepGardeningPlant());
				}
				CustomStepGardeningPlant gardeningPlant = GardeningPlant;
				CustomStepGardeningPlant gardeningPlant2 = other.GardeningPlant;
				gardeningPlant.MergeFrom(gardeningPlant2);
				if (Possess == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepPossess());
				}
				CustomStepPossess possess = Possess;
				CustomStepPossess possess2 = other.Possess;
				possess.MergeFrom(possess2);
				if (PickUp == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepPickUp());
				}
				CustomStepPickUp pickUp = PickUp;
				CustomStepPickUp pickUp2 = other.PickUp;
				pickUp.MergeFrom(pickUp2);
				if (PurchaseItem == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepPurchaseItem());
				}
				CustomStepPurchaseItem purchaseItem = PurchaseItem;
				CustomStepPurchaseItem purchaseItem2 = other.PurchaseItem;
				purchaseItem.MergeFrom(purchaseItem2);
				if (SellItem == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepSellItem());
				}
				CustomStepSellItem sellItem = SellItem;
				CustomStepSellItem sellItem2 = other.SellItem;
				sellItem.MergeFrom(sellItem2);
				if (TakePicture == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepTakePicture());
				}
				CustomStepTakePicture takePicture = TakePicture;
				CustomStepTakePicture takePicture2 = other.TakePicture;
				takePicture.MergeFrom(takePicture2);
				if (DressUp == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepDressUp());
				}
				CustomStepDressUp dressUp = DressUp;
				CustomStepDressUp dressUp2 = other.DressUp;
				dressUp.MergeFrom(dressUp2);
				if (BuildFriendHouses == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepFinishHouse());
				}
				CustomStepFinishHouse buildFriendHouses = BuildFriendHouses;
				CustomStepFinishHouse buildFriendHouses2 = other.BuildFriendHouses;
				buildFriendHouses.MergeFrom(buildFriendHouses2);
				if (GiftToCharacter == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepGiftToCharacterItem());
				}
				CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
				CustomStepGiftToCharacterItem giftToCharacter2 = other.GiftToCharacter;
				giftToCharacter.MergeFrom(giftToCharacter2);
				if (StartDiscussion == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepStartDiscussion());
				}
				CustomStepStartDiscussion startDiscussion = StartDiscussion;
				CustomStepStartDiscussion startDiscussion2 = other.StartDiscussion;
				startDiscussion.MergeFrom(startDiscussion2);
				if (MineMineral == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepMineMineral());
				}
				CustomStepMineMineral mineMineral = MineMineral;
				CustomStepMineMineral mineMineral2 = other.MineMineral;
				mineMineral.MergeFrom(mineMineral2);
				if (WaterPlant == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepWaterPlant());
				}
				CustomStepWaterPlant waterPlant = WaterPlant;
				CustomStepWaterPlant waterPlant2 = other.WaterPlant;
				waterPlant.MergeFrom(waterPlant2);
				if (FeedCritter == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepFeedCritter());
				}
				CustomStepFeedCritter feedCritter = FeedCritter;
				CustomStepFeedCritter feedCritter2 = other.FeedCritter;
				feedCritter.MergeFrom(feedCritter2);
				if (MakeFriend == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepFriend());
				}
				CustomStepFriend makeFriend = MakeFriend;
				CustomStepFriend makeFriend2 = other.MakeFriend;
				makeFriend.MergeFrom(makeFriend2);
				if (Upgrade == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepUpgrade());
				}
				CustomStepUpgrade upgrade = Upgrade;
				CustomStepUpgrade upgrade2 = other.Upgrade;
				upgrade.MergeFrom(upgrade2);
				if (Unlock == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepUnlock());
				}
				CustomStepUnlock unlock = Unlock;
				CustomStepUnlock unlock2 = other.Unlock;
				unlock.MergeFrom(unlock2);
				if (ExpandHouse == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepExpandHouse());
				}
				CustomStepExpandHouse expandHouse = ExpandHouse;
				CustomStepExpandHouse expandHouse2 = other.ExpandHouse;
				expandHouse.MergeFrom(expandHouse2);
				if (RoyalDuty == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepRoyalDuties());
				}
				CustomStepRoyalDuties royalDuty = RoyalDuty;
				CustomStepRoyalDuties royalDuty2 = other.RoyalDuty;
				royalDuty.MergeFrom(royalDuty2);
				if (EatMeal == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepEatMeal());
				}
				CustomStepEatMeal eatMeal = EatMeal;
				CustomStepEatMeal eatMeal2 = other.EatMeal;
				eatMeal.MergeFrom(eatMeal2);
				if (Decorate == null)
				{
					stepCase_ = (StepOneofCase)(step_ = new CustomStepDecorate());
				}
				CustomStepDecorate decorate = Decorate;
				CustomStepDecorate decorate2 = other.Decorate;
				decorate.MergeFrom(decorate2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600465E")]
		[Cpp2IlInjected.Address(RVA = "0x3146B20", Offset = "0x3145520", VA = "0x183146B20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0083: Expected I4, but got O
			//IL_00d4: Expected I4, but got O
			//IL_0149: Expected I4, but got O
			//IL_01a5: Expected I4, but got O
			//IL_0205: Expected I4, but got O
			//IL_025e: Expected I4, but got O
			//IL_02ba: Expected I4, but got O
			//IL_0313: Expected I4, but got O
			//IL_036f: Expected I4, but got O
			//IL_03db: Expected I4, but got O
			//IL_0434: Expected I4, but got O
			//IL_0490: Expected I4, but got O
			//IL_04e9: Expected I4, but got O
			//IL_0545: Expected I4, but got O
			//IL_05af: Expected I4, but got O
			//IL_0608: Expected I4, but got O
			//IL_0664: Expected I4, but got O
			//IL_06bd: Expected I4, but got O
			//IL_0719: Expected I4, but got O
			//IL_078e: Expected I4, but got O
			//IL_07e7: Expected I4, but got O
			//IL_0843: Expected I4, but got O
			//IL_089c: Expected I4, but got O
			//IL_08f8: Expected I4, but got O
			bool flag = default(bool);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					continue;
				}
				if ((int)num > 234)
				{
					if ((int)num > 346)
					{
						if ((int)num > 386)
						{
							if ((int)num > 402)
							{
								if (num == 410)
								{
									CustomStepEatMeal customStepEatMeal = new CustomStepEatMeal();
									if (stepCase_ == StepOneofCase.EatMeal)
									{
										if (stepCase_ != StepOneofCase.EatMeal)
										{
										}
										object obj = step_;
										if (obj != null && obj == null)
										{
											continue;
										}
									}
									input.ReadMessage(customStepEatMeal);
									step_ = customStepEatMeal;
									stepCase_ = (StepOneofCase)customStepEatMeal;
								}
								if (num == 418)
								{
									CustomStepDecorate builder = new CustomStepDecorate();
									if (stepCase_ == StepOneofCase.Decorate)
									{
										if (stepCase_ != StepOneofCase.Decorate)
										{
										}
										object obj2 = step_;
										if (obj2 != null && obj2 == null)
										{
											continue;
										}
									}
									input.ReadMessage(builder);
									step_ = builder;
									stepCase_ = (StepOneofCase)typeof(CustomStepDecorate).TypeHandle;
								}
								if ((long)typeof(CustomStepDecorate).TypeHandle != 7992)
								{
									continue;
								}
								int num2 = (int)(glotID_ = (uint)input.ReadInt32());
							}
							if (num == 394)
							{
								CustomStepExpandHouse builder2 = new CustomStepExpandHouse();
								if (stepCase_ == StepOneofCase.ExpandHouse)
								{
									if (stepCase_ != StepOneofCase.ExpandHouse)
									{
									}
									object obj3 = step_;
									if (obj3 != null && obj3 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder2);
								step_ = builder2;
								stepCase_ = (StepOneofCase)typeof(CustomStepExpandHouse).TypeHandle;
							}
							if ((long)typeof(CustomStepExpandHouse).TypeHandle != 402)
							{
								continue;
							}
							CustomStepRoyalDuties builder3 = new CustomStepRoyalDuties();
							if (stepCase_ == StepOneofCase.RoyalDuty)
							{
								if (stepCase_ != StepOneofCase.RoyalDuty)
								{
								}
								object obj4 = step_;
								if (obj4 != null && obj4 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder3);
							step_ = builder3;
							stepCase_ = (StepOneofCase)typeof(CustomStepRoyalDuties).TypeHandle;
						}
						if ((int)num > 362)
						{
							if (num == 370)
							{
								CustomStepFriend builder4 = new CustomStepFriend();
								if (stepCase_ == StepOneofCase.MakeFriend)
								{
									if (stepCase_ != StepOneofCase.MakeFriend)
									{
									}
									object obj5 = step_;
									if (obj5 != null && obj5 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder4);
								step_ = builder4;
								stepCase_ = (StepOneofCase)typeof(CustomStepFriend).TypeHandle;
							}
							if ((long)typeof(CustomStepFriend).TypeHandle == 378)
							{
								CustomStepUpgrade builder5 = new CustomStepUpgrade();
								if (stepCase_ == StepOneofCase.Upgrade)
								{
									if (stepCase_ != StepOneofCase.Upgrade)
									{
									}
									object obj6 = step_;
									if (obj6 != null && obj6 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder5);
								step_ = builder5;
								stepCase_ = (StepOneofCase)typeof(CustomStepUpgrade).TypeHandle;
							}
							if ((long)typeof(CustomStepUpgrade).TypeHandle != 386)
							{
								continue;
							}
							CustomStepUnlock builder6 = new CustomStepUnlock();
							if (stepCase_ == StepOneofCase.Unlock)
							{
								if (stepCase_ != StepOneofCase.Unlock)
								{
								}
								object obj7 = step_;
								if (obj7 != null && obj7 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder6);
							step_ = builder6;
							stepCase_ = (StepOneofCase)typeof(CustomStepUnlock).TypeHandle;
						}
						if ((long)typeof(CustomStepUnlock).TypeHandle == 354)
						{
							CustomStepWaterPlant builder7 = new CustomStepWaterPlant();
							if (stepCase_ == StepOneofCase.WaterPlant)
							{
								if (stepCase_ != StepOneofCase.WaterPlant)
								{
								}
								object obj8 = step_;
								if (obj8 != null && obj8 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder7);
							step_ = builder7;
							stepCase_ = (StepOneofCase)typeof(CustomStepWaterPlant).TypeHandle;
						}
						if ((long)typeof(CustomStepWaterPlant).TypeHandle != 362)
						{
							continue;
						}
						CustomStepFeedCritter builder8 = new CustomStepFeedCritter();
						if (stepCase_ == StepOneofCase.FeedCritter)
						{
							if (stepCase_ != StepOneofCase.FeedCritter)
							{
							}
							object obj9 = step_;
							if (obj9 != null && obj9 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder8);
						step_ = builder8;
						stepCase_ = (StepOneofCase)typeof(CustomStepFeedCritter).TypeHandle;
					}
					if ((int)num > 282)
					{
						if ((int)num > 322)
						{
							if (num == 330)
							{
								CustomStepGiftToCharacterItem builder9 = new CustomStepGiftToCharacterItem();
								if (stepCase_ == StepOneofCase.GiftToCharacter)
								{
									if (stepCase_ != StepOneofCase.GiftToCharacter)
									{
									}
									object obj10 = step_;
									if (obj10 != null && obj10 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder9);
								step_ = builder9;
								stepCase_ = (StepOneofCase)typeof(CustomStepGiftToCharacterItem).TypeHandle;
							}
							if ((long)typeof(CustomStepGiftToCharacterItem).TypeHandle == 338)
							{
								CustomStepStartDiscussion builder10 = new CustomStepStartDiscussion();
								if (stepCase_ == StepOneofCase.StartDiscussion)
								{
									if (stepCase_ != StepOneofCase.StartDiscussion)
									{
									}
									object obj11 = step_;
									if (obj11 != null && obj11 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder10);
								step_ = builder10;
								stepCase_ = (StepOneofCase)typeof(CustomStepStartDiscussion).TypeHandle;
							}
							if ((long)typeof(CustomStepStartDiscussion).TypeHandle != 346)
							{
								continue;
							}
							CustomStepMineMineral builder11 = new CustomStepMineMineral();
							if (stepCase_ == StepOneofCase.MineMineral)
							{
								if (stepCase_ != StepOneofCase.MineMineral)
								{
								}
								object obj12 = step_;
								if (obj12 != null && obj12 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder11);
							step_ = builder11;
							stepCase_ = (StepOneofCase)typeof(CustomStepMineMineral).TypeHandle;
						}
						if ((long)typeof(CustomStepMineMineral).TypeHandle == 298)
						{
							CustomStepDressUp builder12 = new CustomStepDressUp();
							if (stepCase_ == StepOneofCase.DressUp)
							{
								if (stepCase_ != StepOneofCase.DressUp)
								{
								}
								object obj13 = step_;
								if (obj13 != null && obj13 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder12);
							step_ = builder12;
							stepCase_ = (StepOneofCase)typeof(CustomStepDressUp).TypeHandle;
						}
						if ((long)typeof(CustomStepDressUp).TypeHandle != 322)
						{
							continue;
						}
						CustomStepFinishHouse builder13 = new CustomStepFinishHouse();
						if (stepCase_ == StepOneofCase.BuildFriendHouses)
						{
							if (stepCase_ != StepOneofCase.BuildFriendHouses)
							{
							}
							object obj14 = step_;
							if (obj14 != null && obj14 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder13);
						step_ = builder13;
						stepCase_ = (StepOneofCase)typeof(CustomStepFinishHouse).TypeHandle;
					}
					if ((long)typeof(CustomStepFinishHouse).TypeHandle > 250)
					{
						if ((long)typeof(CustomStepFinishHouse).TypeHandle == 258)
						{
							CustomStepPurchaseItem builder14 = new CustomStepPurchaseItem();
							if (stepCase_ == StepOneofCase.PurchaseItem)
							{
								if (stepCase_ != StepOneofCase.PurchaseItem)
								{
								}
								object obj15 = step_;
								if (obj15 != null && obj15 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder14);
							step_ = builder14;
							stepCase_ = (StepOneofCase)typeof(CustomStepPurchaseItem).TypeHandle;
						}
						if ((long)typeof(CustomStepPurchaseItem).TypeHandle == 266)
						{
							CustomStepSellItem builder15 = new CustomStepSellItem();
							if (stepCase_ == StepOneofCase.SellItem)
							{
								if (stepCase_ != StepOneofCase.SellItem)
								{
								}
								object obj16 = step_;
								if (obj16 != null && obj16 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder15);
							step_ = builder15;
							stepCase_ = (StepOneofCase)typeof(CustomStepSellItem).TypeHandle;
						}
						if ((long)typeof(CustomStepSellItem).TypeHandle != 282)
						{
							continue;
						}
						CustomStepTakePicture builder16 = new CustomStepTakePicture();
						if (stepCase_ == StepOneofCase.TakePicture)
						{
							if (stepCase_ != StepOneofCase.TakePicture)
							{
							}
							object obj17 = step_;
							if (obj17 != null && obj17 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder16);
						step_ = builder16;
						stepCase_ = (StepOneofCase)typeof(CustomStepTakePicture).TypeHandle;
					}
					if ((long)typeof(CustomStepTakePicture).TypeHandle == 242)
					{
						CustomStepPossess builder17 = new CustomStepPossess();
						if (stepCase_ == StepOneofCase.Possess)
						{
							if (stepCase_ != StepOneofCase.Possess)
							{
							}
							object obj18 = step_;
							if (obj18 != null && obj18 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder17);
						step_ = builder17;
						stepCase_ = (StepOneofCase)typeof(CustomStepPossess).TypeHandle;
					}
					if ((long)typeof(CustomStepPossess).TypeHandle != 250)
					{
						continue;
					}
					CustomStepPickUp builder18 = new CustomStepPickUp();
					if (stepCase_ == StepOneofCase.PickUp)
					{
						if (stepCase_ != StepOneofCase.PickUp)
						{
						}
						object obj19 = step_;
						if (obj19 != null && obj19 == null)
						{
							continue;
						}
					}
					input.ReadMessage(builder18);
					step_ = builder18;
					stepCase_ = (StepOneofCase)typeof(CustomStepPickUp).TypeHandle;
				}
				if ((int)num <= 72)
				{
					continue;
				}
				if ((int)num > 170)
				{
					if ((int)num > 186)
					{
						if (num == 202)
						{
							CustomStepDesignChallenge builder19 = new CustomStepDesignChallenge();
							if (stepCase_ == StepOneofCase.DesignChallenge)
							{
								if (stepCase_ != StepOneofCase.DesignChallenge)
								{
								}
								object obj20 = step_;
								if (obj20 != null && obj20 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder19);
							step_ = builder19;
							stepCase_ = (StepOneofCase)typeof(CustomStepDesignChallenge).TypeHandle;
						}
						if ((long)typeof(CustomStepDesignChallenge).TypeHandle == 226)
						{
							CustomStepGardeningHarvest builder20 = new CustomStepGardeningHarvest();
							if (stepCase_ == StepOneofCase.GardeningHarvest)
							{
								if (stepCase_ != StepOneofCase.GardeningHarvest)
								{
								}
								object obj21 = step_;
								if (obj21 != null && obj21 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder20);
							step_ = builder20;
							stepCase_ = (StepOneofCase)typeof(CustomStepGardeningHarvest).TypeHandle;
						}
						if ((long)typeof(CustomStepGardeningHarvest).TypeHandle != 234)
						{
							continue;
						}
						CustomStepGardeningPlant builder21 = new CustomStepGardeningPlant();
						if (stepCase_ == StepOneofCase.GardeningPlant)
						{
							if (stepCase_ != StepOneofCase.GardeningPlant)
							{
							}
							object obj22 = step_;
							if (obj22 != null && obj22 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder21);
						step_ = builder21;
						stepCase_ = (StepOneofCase)typeof(CustomStepGardeningPlant).TypeHandle;
					}
					if ((long)typeof(CustomStepGardeningPlant).TypeHandle == 178)
					{
						CustomStepCollectCurrency builder22 = new CustomStepCollectCurrency();
						if (stepCase_ == StepOneofCase.CollectCurrency)
						{
							if (stepCase_ != StepOneofCase.CollectCurrency)
							{
							}
							object obj23 = step_;
							if (obj23 != null && obj23 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder22);
						step_ = builder22;
						stepCase_ = (StepOneofCase)typeof(CustomStepCollectCurrency).TypeHandle;
					}
					if ((long)typeof(CustomStepCollectCurrency).TypeHandle != 186)
					{
						continue;
					}
					CustomStepCookMeal builder23 = new CustomStepCookMeal();
					if (stepCase_ == StepOneofCase.CookMeal)
					{
						if (stepCase_ != StepOneofCase.CookMeal)
						{
						}
						object obj24 = step_;
						if (obj24 != null && obj24 == null)
						{
							continue;
						}
					}
					input.ReadMessage(builder23);
					step_ = builder23;
					stepCase_ = (StepOneofCase)typeof(CustomStepCookMeal).TypeHandle;
				}
				if ((long)typeof(CustomStepCookMeal).TypeHandle > 88)
				{
					if ((long)typeof(CustomStepCookMeal).TypeHandle == 96)
					{
						flag = (useMilestoneAsFriendshipLevel_ = input.ReadBool());
					}
					if (flag)
					{
						RepeatedField<AchievementMilestone> repeatedField = milestones_;
						FieldCodec<AchievementMilestone> repeated_milestones_codec = _repeated_milestones_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_milestones_codec);
					}
					if (flag)
					{
						break;
					}
				}
			}
			CustomStepCatchFish customStepCatchFish = new CustomStepCatchFish();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600465F")]
		[Cpp2IlInjected.Address(RVA = "0x31449A0", Offset = "0x31433A0", VA = "0x1831449A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 51)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004660")]
		[Cpp2IlInjected.Address(RVA = "0x31481B0", Offset = "0x3146BB0", VA = "0x1831481B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001f, IL_0020, IL_0024, IL_002b, IL_002c, IL_0030, IL_0037, IL_0038, IL_003c, IL_0043, IL_0044, IL_0045, IL_0049, IL_0050, IL_0051, IL_0055, IL_005c, IL_005d, IL_005e, IL_005f, IL_0060, IL_0061, IL_0065, IL_0069, IL_006a, IL_006e, IL_0072, IL_0073, IL_0077, IL_007b, IL_007c, IL_0080, IL_0087, IL_0088, IL_008c, IL_0093, IL_0094, IL_0098, IL_009f, IL_00a0, IL_00a4, IL_00ab, IL_00ac, IL_00b0, IL_00b7, IL_00b8, IL_00bc, IL_00c3, IL_00c4, IL_00c8, IL_00cf, IL_00d0, IL_00d4, IL_00db, IL_00dc, IL_00e0, IL_00e7, IL_00e8, IL_00ec, IL_00f3, IL_00f4, IL_00f8, IL_00ff, IL_0100, IL_0104, IL_010b, IL_010c, IL_0110, IL_0117, IL_0118, IL_011c, IL_0123, IL_0124, IL_0128, IL_012f, IL_0130, IL_0134, IL_013b, IL_013c, IL_0140, IL_0147, IL_0148, IL_014c, IL_0153, IL_0154, IL_0158, IL_015f, IL_0160, IL_0164, IL_016b, IL_016c, IL_0170, IL_0177, IL_0178, IL_017c, IL_0183, IL_0194, IL_019a, IL_01a0, IL_01a6, IL_01ac, IL_01b2, IL_01b8
			//IL_0011: Expected I4, but got O
			//IL_0193: Expected I4, but got O
			if (fieldNumber - 1 <= 51)
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

		[Cpp2IlInjected.Token(Token = "0x6004661")]
		[Cpp2IlInjected.Address(RVA = "0x3143A80", Offset = "0x3142480", VA = "0x183143A80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0014, IL_0020, IL_002c, IL_0038, IL_0044, IL_004e, IL_005a, IL_0066, IL_0070, IL_0078, IL_0080, IL_0088, IL_00b7
			//IL_009a: Expected O, but got I4
			if (fieldNumber - 1 <= 51)
			{
				int num = (iD_ = 0);
			}
			else if (fieldNumber == 999)
			{
				int num2 = (int)(glotID_ = 0u);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004662")]
		[Cpp2IlInjected.Address(RVA = "0x3145BB0", Offset = "0x31445B0", VA = "0x183145BB0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Step"))
			{
				StepOneofCase stepOneofCase = stepCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004663")]
		[Cpp2IlInjected.Address(RVA = "0x3143D10", Offset = "0x3142710", VA = "0x183143D10", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Step"))
			{
				step_ = (stepCase_ = StepOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004666")]
		[Cpp2IlInjected.Address(RVA = "0x3143DA0", Offset = "0x31427A0", VA = "0x183143DA0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			AchievementItemData achievementItemData = new AchievementItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600466C")]
		[Cpp2IlInjected.Address(RVA = "0x3145B60", Offset = "0x3144560", VA = "0x183145B60", Slot = "27")]
		public (ItemType, ActivityItemType?) GetItemGeneratorParameters()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600466D")]
		[Cpp2IlInjected.Address(RVA = "0x3143E00", Offset = "0x3142800", VA = "0x183143E00", Slot = "28")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0092
			//IL_008f: Expected O, but got I4
			StepOneofCase stepOneofCase = stepCase_;
			if (stepOneofCase == StepOneofCase.Upgrade)
			{
				if (step_ == null)
				{
					throw new InvalidCastException();
				}
				RepeatedField<AchievementMilestone> repeatedField = milestones_;
				Action<AchievementMilestone> action = (Action<AchievementMilestone>)(object)(Action<T>)delegate(AchievementMilestone m)
				{
					//Discarded unreachable code: IL_0023
					CustomStepUpgrade upgrade = Upgrade;
					int milestone_ = m.milestone_;
					DataValidation.Context context2 = context;
					upgrade.BuildingLevelValidation(context2, milestone_);
				};
				((RepeatedField<>)(object)repeatedField).ForEach<AchievementMilestone>((Action<>)(object)action);
			}
			if (stepOneofCase != StepOneofCase.Decorate)
			{
				return;
			}
			RepeatedField<AchievementMilestone> repeatedField2 = milestones_;
			Predicate<AchievementMilestone> predicate = default(Predicate<AchievementMilestone>);
			if (_003C_003Ec._003C_003E9__217_1 == null)
			{
				predicate = (Predicate<AchievementMilestone>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((AchievementMilestone m) => m.milestone_ > 50));
			}
			if (((RepeatedField<>)(object)repeatedField2).Any<AchievementMilestone>((Predicate<>)(object)predicate))
			{
				StepOneofCase stepOneofCase2 = default(StepOneofCase);
				string text = string.Format("{0} achievement {1} must be <= 50", stepOneofCase2, "Milestone");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600466E")]
		[Cpp2IlInjected.Address(RVA = "0x3149F80", Offset = "0x3148980", VA = "0x183149F80")]
		static AchievementItemData()
		{
			MessageParser<AchievementMilestone> parser = AchievementMilestone._parser;
			uint num = default(uint);
			_parser = (MessageParser<AchievementItemData>)(object)FieldCodec.ForMessage<AchievementMilestone>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
