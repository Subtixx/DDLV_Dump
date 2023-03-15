using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Options;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200052D")]
	public sealed class MissionObjectiveData : IMessage<MissionObjectiveData>, IMessage, IEquatable<MissionObjectiveData>, IDeepCloneable<MissionObjectiveData>, IMessageFieldAccessor, IMessageOneofAccessor, IMissionStepName, ICustomStepOwner, IItemSelector, IItemGeneratorOwner, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200052E")]
		public enum CustomStepOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001BE0")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001BE1")]
			BringItem = 100,
			[Cpp2IlInjected.Token(Token = "0x4001BE2")]
			Cancel = 103,
			[Cpp2IlInjected.Token(Token = "0x4001BE3")]
			CatchFish = 105,
			[Cpp2IlInjected.Token(Token = "0x4001BE4")]
			Chase = 108,
			[Cpp2IlInjected.Token(Token = "0x4001BE5")]
			CollectCurrency = 110,
			[Cpp2IlInjected.Token(Token = "0x4001BE6")]
			Conditional = 115,
			[Cpp2IlInjected.Token(Token = "0x4001BE7")]
			ConsumeItem = 120,
			[Cpp2IlInjected.Token(Token = "0x4001BE8")]
			CookMeal = 125,
			[Cpp2IlInjected.Token(Token = "0x4001BE9")]
			CraftItem = 130,
			[Cpp2IlInjected.Token(Token = "0x4001BEA")]
			Decorate = 135,
			[Cpp2IlInjected.Token(Token = "0x4001BEB")]
			DesignChallenge = 140,
			[Cpp2IlInjected.Token(Token = "0x4001BEC")]
			DressUp = 145,
			[Cpp2IlInjected.Token(Token = "0x4001BED")]
			EatMeal = 150,
			[Cpp2IlInjected.Token(Token = "0x4001BEE")]
			ExpandHouse = 155,
			[Cpp2IlInjected.Token(Token = "0x4001BEF")]
			FeedCritter = 160,
			[Cpp2IlInjected.Token(Token = "0x4001BF0")]
			FillKeyhole = 165,
			[Cpp2IlInjected.Token(Token = "0x4001BF1")]
			FinishHouse = 170,
			[Cpp2IlInjected.Token(Token = "0x4001BF2")]
			FollowCharacter = 175,
			[Cpp2IlInjected.Token(Token = "0x4001BF3")]
			Friend = 180,
			[Cpp2IlInjected.Token(Token = "0x4001BF4")]
			GardeningHarvest = 185,
			[Cpp2IlInjected.Token(Token = "0x4001BF5")]
			GardeningPlant = 190,
			[Cpp2IlInjected.Token(Token = "0x4001BF6")]
			GiftToCharacter = 195,
			[Cpp2IlInjected.Token(Token = "0x4001BF7")]
			Interaction = 197,
			[Cpp2IlInjected.Token(Token = "0x4001BF8")]
			Listen = 200,
			[Cpp2IlInjected.Token(Token = "0x4001BF9")]
			MakeGarden = 205,
			[Cpp2IlInjected.Token(Token = "0x4001BFA")]
			MineMineral = 210,
			[Cpp2IlInjected.Token(Token = "0x4001BFB")]
			Party = 215,
			[Cpp2IlInjected.Token(Token = "0x4001BFC")]
			PickUp = 220,
			[Cpp2IlInjected.Token(Token = "0x4001BFD")]
			PlaceBuilding = 225,
			[Cpp2IlInjected.Token(Token = "0x4001BFE")]
			Possess = 230,
			[Cpp2IlInjected.Token(Token = "0x4001BFF")]
			PurchaseItem = 235,
			[Cpp2IlInjected.Token(Token = "0x4001C00")]
			RemoveBlocker = 240,
			[Cpp2IlInjected.Token(Token = "0x4001C01")]
			RoyalDuties = 245,
			[Cpp2IlInjected.Token(Token = "0x4001C02")]
			SellItem = 250,
			[Cpp2IlInjected.Token(Token = "0x4001C03")]
			ServeRestaurantOrder = 255,
			[Cpp2IlInjected.Token(Token = "0x4001C04")]
			StartDiscussion = 260,
			[Cpp2IlInjected.Token(Token = "0x4001C05")]
			TakePicture = 265,
			[Cpp2IlInjected.Token(Token = "0x4001C06")]
			TalkToCharacter = 270,
			[Cpp2IlInjected.Token(Token = "0x4001C07")]
			Unlock = 275,
			[Cpp2IlInjected.Token(Token = "0x4001C08")]
			UnlockCharacter = 280,
			[Cpp2IlInjected.Token(Token = "0x4001C09")]
			Upgrade = 285,
			[Cpp2IlInjected.Token(Token = "0x4001C0A")]
			VisitArea = 290,
			[Cpp2IlInjected.Token(Token = "0x4001C0B")]
			WaterPlant = 295
		}

		[Cpp2IlInjected.Token(Token = "0x4001BA4")]
		private static readonly MessageParser<MissionObjectiveData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001BA5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001BA6")]
		public const int StepDescriptionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BA7")]
		private string stepDescription_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001BA8")]
		public const int ObjectiveIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001BA9")]
		private int objectiveID_;

		[Cpp2IlInjected.Token(Token = "0x4001BAA")]
		public const int StepNameFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001BAB")]
		private string stepName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001BAC")]
		public const int HideProgressionCountFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001BAD")]
		private bool hideProgressionCount_;

		[Cpp2IlInjected.Token(Token = "0x4001BAE")]
		public const int HideCharacterFeedbackFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4001BAF")]
		private bool hideCharacterFeedback_;

		[Cpp2IlInjected.Token(Token = "0x4001BB0")]
		public const int SkipSubStepWhenCompletedFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4001BB1")]
		private bool skipSubStepWhenCompleted_;

		[Cpp2IlInjected.Token(Token = "0x4001BB2")]
		public const int BringItemFieldNumber = 100;

		[Cpp2IlInjected.Token(Token = "0x4001BB3")]
		public const int CancelFieldNumber = 103;

		[Cpp2IlInjected.Token(Token = "0x4001BB4")]
		public const int CatchFishFieldNumber = 105;

		[Cpp2IlInjected.Token(Token = "0x4001BB5")]
		public const int ChaseFieldNumber = 108;

		[Cpp2IlInjected.Token(Token = "0x4001BB6")]
		public const int CollectCurrencyFieldNumber = 110;

		[Cpp2IlInjected.Token(Token = "0x4001BB7")]
		public const int ConditionalFieldNumber = 115;

		[Cpp2IlInjected.Token(Token = "0x4001BB8")]
		public const int ConsumeItemFieldNumber = 120;

		[Cpp2IlInjected.Token(Token = "0x4001BB9")]
		public const int CookMealFieldNumber = 125;

		[Cpp2IlInjected.Token(Token = "0x4001BBA")]
		public const int CraftItemFieldNumber = 130;

		[Cpp2IlInjected.Token(Token = "0x4001BBB")]
		public const int DecorateFieldNumber = 135;

		[Cpp2IlInjected.Token(Token = "0x4001BBC")]
		public const int DesignChallengeFieldNumber = 140;

		[Cpp2IlInjected.Token(Token = "0x4001BBD")]
		public const int DressUpFieldNumber = 145;

		[Cpp2IlInjected.Token(Token = "0x4001BBE")]
		public const int EatMealFieldNumber = 150;

		[Cpp2IlInjected.Token(Token = "0x4001BBF")]
		public const int ExpandHouseFieldNumber = 155;

		[Cpp2IlInjected.Token(Token = "0x4001BC0")]
		public const int FeedCritterFieldNumber = 160;

		[Cpp2IlInjected.Token(Token = "0x4001BC1")]
		public const int FillKeyholeFieldNumber = 165;

		[Cpp2IlInjected.Token(Token = "0x4001BC2")]
		public const int FinishHouseFieldNumber = 170;

		[Cpp2IlInjected.Token(Token = "0x4001BC3")]
		public const int FollowCharacterFieldNumber = 175;

		[Cpp2IlInjected.Token(Token = "0x4001BC4")]
		public const int FriendFieldNumber = 180;

		[Cpp2IlInjected.Token(Token = "0x4001BC5")]
		public const int GardeningHarvestFieldNumber = 185;

		[Cpp2IlInjected.Token(Token = "0x4001BC6")]
		public const int GardeningPlantFieldNumber = 190;

		[Cpp2IlInjected.Token(Token = "0x4001BC7")]
		public const int GiftToCharacterFieldNumber = 195;

		[Cpp2IlInjected.Token(Token = "0x4001BC8")]
		public const int InteractionFieldNumber = 197;

		[Cpp2IlInjected.Token(Token = "0x4001BC9")]
		public const int ListenFieldNumber = 200;

		[Cpp2IlInjected.Token(Token = "0x4001BCA")]
		public const int MakeGardenFieldNumber = 205;

		[Cpp2IlInjected.Token(Token = "0x4001BCB")]
		public const int MineMineralFieldNumber = 210;

		[Cpp2IlInjected.Token(Token = "0x4001BCC")]
		public const int PartyFieldNumber = 215;

		[Cpp2IlInjected.Token(Token = "0x4001BCD")]
		public const int PickUpFieldNumber = 220;

		[Cpp2IlInjected.Token(Token = "0x4001BCE")]
		public const int PlaceBuildingFieldNumber = 225;

		[Cpp2IlInjected.Token(Token = "0x4001BCF")]
		public const int PossessFieldNumber = 230;

		[Cpp2IlInjected.Token(Token = "0x4001BD0")]
		public const int PurchaseItemFieldNumber = 235;

		[Cpp2IlInjected.Token(Token = "0x4001BD1")]
		public const int RemoveBlockerFieldNumber = 240;

		[Cpp2IlInjected.Token(Token = "0x4001BD2")]
		public const int RoyalDutiesFieldNumber = 245;

		[Cpp2IlInjected.Token(Token = "0x4001BD3")]
		public const int SellItemFieldNumber = 250;

		[Cpp2IlInjected.Token(Token = "0x4001BD4")]
		public const int ServeRestaurantOrderFieldNumber = 255;

		[Cpp2IlInjected.Token(Token = "0x4001BD5")]
		public const int StartDiscussionFieldNumber = 260;

		[Cpp2IlInjected.Token(Token = "0x4001BD6")]
		public const int TakePictureFieldNumber = 265;

		[Cpp2IlInjected.Token(Token = "0x4001BD7")]
		public const int TalkToCharacterFieldNumber = 270;

		[Cpp2IlInjected.Token(Token = "0x4001BD8")]
		public const int UnlockFieldNumber = 275;

		[Cpp2IlInjected.Token(Token = "0x4001BD9")]
		public const int UnlockCharacterFieldNumber = 280;

		[Cpp2IlInjected.Token(Token = "0x4001BDA")]
		public const int UpgradeFieldNumber = 285;

		[Cpp2IlInjected.Token(Token = "0x4001BDB")]
		public const int VisitAreaFieldNumber = 290;

		[Cpp2IlInjected.Token(Token = "0x4001BDC")]
		public const int WaterPlantFieldNumber = 295;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001BDD")]
		private object customStep_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001BDE")]
		private CustomStepOneofCase customStepCase_;

		[Cpp2IlInjected.Token(Token = "0x1700106D")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionObjectiveData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600400D")]
			[Cpp2IlInjected.Address(RVA = "0x371F6C0", Offset = "0x371E0C0", VA = "0x18371F6C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700106E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600400E")]
			[Cpp2IlInjected.Address(RVA = "0x371EB70", Offset = "0x371D570", VA = "0x18371EB70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700106F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600400F")]
			[Cpp2IlInjected.Address(RVA = "0x371FD80", Offset = "0x371E780", VA = "0x18371FD80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001070")]
		[DebuggerNonUserCode]
		public string StepDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6004013")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return stepDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004014")]
			[Cpp2IlInjected.Address(RVA = "0x3720790", Offset = "0x371F190", VA = "0x183720790")]
			set
			{
				string text = (stepDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001071")]
		[DebuggerNonUserCode]
		public int ObjectiveID
		{
			[Cpp2IlInjected.Token(Token = "0x6004015")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return objectiveID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004016")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				objectiveID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001072")]
		[DebuggerNonUserCode]
		public string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x6004017")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "16")]
			get
			{
				return stepName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004018")]
			[Cpp2IlInjected.Address(RVA = "0x3720800", Offset = "0x371F200", VA = "0x183720800", Slot = "17")]
			set
			{
				string text = (stepName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001073")]
		[DebuggerNonUserCode]
		public bool HideProgressionCount
		{
			[Cpp2IlInjected.Token(Token = "0x6004019")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return hideProgressionCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600401A")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				hideProgressionCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001074")]
		[DebuggerNonUserCode]
		public bool HideCharacterFeedback
		{
			[Cpp2IlInjected.Token(Token = "0x600401B")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
			get
			{
				return hideCharacterFeedback_;
			}
			[Cpp2IlInjected.Token(Token = "0x600401C")]
			[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
			set
			{
				hideCharacterFeedback_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001075")]
		[DebuggerNonUserCode]
		public bool SkipSubStepWhenCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600401D")]
			[Cpp2IlInjected.Address(RVA = "0x997D80", Offset = "0x996780", VA = "0x180997D80")]
			get
			{
				return skipSubStepWhenCompleted_;
			}
			[Cpp2IlInjected.Token(Token = "0x600401E")]
			[Cpp2IlInjected.Address(RVA = "0x997DB0", Offset = "0x9967B0", VA = "0x180997DB0")]
			set
			{
				skipSubStepWhenCompleted_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001076")]
		[DebuggerNonUserCode]
		public CustomStepBringItem BringItem
		{
			[Cpp2IlInjected.Token(Token = "0x600401F")]
			[Cpp2IlInjected.Address(RVA = "0x371E7B0", Offset = "0x371D1B0", VA = "0x18371E7B0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.BringItem)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004020")]
			[Cpp2IlInjected.Address(RVA = "0x371FE90", Offset = "0x371E890", VA = "0x18371FE90")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001077")]
		[DebuggerNonUserCode]
		public CustomStepCancel Cancel
		{
			[Cpp2IlInjected.Token(Token = "0x6004021")]
			[Cpp2IlInjected.Address(RVA = "0x371E810", Offset = "0x371D210", VA = "0x18371E810")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Cancel)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004022")]
			[Cpp2IlInjected.Address(RVA = "0x371FED0", Offset = "0x371E8D0", VA = "0x18371FED0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001078")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish CatchFish
		{
			[Cpp2IlInjected.Token(Token = "0x6004023")]
			[Cpp2IlInjected.Address(RVA = "0x371E870", Offset = "0x371D270", VA = "0x18371E870")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.CatchFish)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004024")]
			[Cpp2IlInjected.Address(RVA = "0x371FF10", Offset = "0x371E910", VA = "0x18371FF10")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001079")]
		[DebuggerNonUserCode]
		public CustomStepChase Chase
		{
			[Cpp2IlInjected.Token(Token = "0x6004025")]
			[Cpp2IlInjected.Address(RVA = "0x371E8D0", Offset = "0x371D2D0", VA = "0x18371E8D0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Chase)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004026")]
			[Cpp2IlInjected.Address(RVA = "0x371FF50", Offset = "0x371E950", VA = "0x18371FF50")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107A")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency CollectCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x6004027")]
			[Cpp2IlInjected.Address(RVA = "0x371E930", Offset = "0x371D330", VA = "0x18371E930")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.CollectCurrency)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004028")]
			[Cpp2IlInjected.Address(RVA = "0x371FF90", Offset = "0x371E990", VA = "0x18371FF90")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107B")]
		[DebuggerNonUserCode]
		public CustomStepConditional Conditional
		{
			[Cpp2IlInjected.Token(Token = "0x6004029")]
			[Cpp2IlInjected.Address(RVA = "0x371E990", Offset = "0x371D390", VA = "0x18371E990")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Conditional)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600402A")]
			[Cpp2IlInjected.Address(RVA = "0x371FFD0", Offset = "0x371E9D0", VA = "0x18371FFD0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107C")]
		[DebuggerNonUserCode]
		public CustomStepConsumeItem ConsumeItem
		{
			[Cpp2IlInjected.Token(Token = "0x600402B")]
			[Cpp2IlInjected.Address(RVA = "0x371E9F0", Offset = "0x371D3F0", VA = "0x18371E9F0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.ConsumeItem)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600402C")]
			[Cpp2IlInjected.Address(RVA = "0x3720010", Offset = "0x371EA10", VA = "0x183720010")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107D")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal CookMeal
		{
			[Cpp2IlInjected.Token(Token = "0x600402D")]
			[Cpp2IlInjected.Address(RVA = "0x371EA50", Offset = "0x371D450", VA = "0x18371EA50")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.CookMeal)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600402E")]
			[Cpp2IlInjected.Address(RVA = "0x3720050", Offset = "0x371EA50", VA = "0x183720050")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107E")]
		[DebuggerNonUserCode]
		public CustomStepCraftItem CraftItem
		{
			[Cpp2IlInjected.Token(Token = "0x600402F")]
			[Cpp2IlInjected.Address(RVA = "0x371EAB0", Offset = "0x371D4B0", VA = "0x18371EAB0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.CraftItem)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004030")]
			[Cpp2IlInjected.Address(RVA = "0x3720090", Offset = "0x371EA90", VA = "0x183720090")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107F")]
		[DebuggerNonUserCode]
		public CustomStepDecorate Decorate
		{
			[Cpp2IlInjected.Token(Token = "0x6004031")]
			[Cpp2IlInjected.Address(RVA = "0x371EB10", Offset = "0x371D510", VA = "0x18371EB10")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Decorate)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004032")]
			[Cpp2IlInjected.Address(RVA = "0x37200D0", Offset = "0x371EAD0", VA = "0x1837200D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001080")]
		[DebuggerNonUserCode]
		public CustomStepDesignChallenge DesignChallenge
		{
			[Cpp2IlInjected.Token(Token = "0x6004033")]
			[Cpp2IlInjected.Address(RVA = "0x371EC40", Offset = "0x371D640", VA = "0x18371EC40")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.DesignChallenge)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004034")]
			[Cpp2IlInjected.Address(RVA = "0x3720110", Offset = "0x371EB10", VA = "0x183720110")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001081")]
		[DebuggerNonUserCode]
		public CustomStepDressUp DressUp
		{
			[Cpp2IlInjected.Token(Token = "0x6004035")]
			[Cpp2IlInjected.Address(RVA = "0x371ECA0", Offset = "0x371D6A0", VA = "0x18371ECA0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.DressUp)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004036")]
			[Cpp2IlInjected.Address(RVA = "0x3720150", Offset = "0x371EB50", VA = "0x183720150")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001082")]
		[DebuggerNonUserCode]
		public CustomStepEatMeal EatMeal
		{
			[Cpp2IlInjected.Token(Token = "0x6004037")]
			[Cpp2IlInjected.Address(RVA = "0x371ED00", Offset = "0x371D700", VA = "0x18371ED00")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.EatMeal)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004038")]
			[Cpp2IlInjected.Address(RVA = "0x3720190", Offset = "0x371EB90", VA = "0x183720190")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001083")]
		[DebuggerNonUserCode]
		public CustomStepExpandHouse ExpandHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6004039")]
			[Cpp2IlInjected.Address(RVA = "0x371ED60", Offset = "0x371D760", VA = "0x18371ED60")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.ExpandHouse)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600403A")]
			[Cpp2IlInjected.Address(RVA = "0x37201D0", Offset = "0x371EBD0", VA = "0x1837201D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001084")]
		[DebuggerNonUserCode]
		public CustomStepFeedCritter FeedCritter
		{
			[Cpp2IlInjected.Token(Token = "0x600403B")]
			[Cpp2IlInjected.Address(RVA = "0x371EDC0", Offset = "0x371D7C0", VA = "0x18371EDC0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.FeedCritter)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600403C")]
			[Cpp2IlInjected.Address(RVA = "0x3720210", Offset = "0x371EC10", VA = "0x183720210")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001085")]
		[DebuggerNonUserCode]
		public CustomStepFillKeyhole FillKeyhole
		{
			[Cpp2IlInjected.Token(Token = "0x600403D")]
			[Cpp2IlInjected.Address(RVA = "0x371EE20", Offset = "0x371D820", VA = "0x18371EE20")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.FillKeyhole)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600403E")]
			[Cpp2IlInjected.Address(RVA = "0x3720250", Offset = "0x371EC50", VA = "0x183720250")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001086")]
		[DebuggerNonUserCode]
		public CustomStepFinishHouse FinishHouse
		{
			[Cpp2IlInjected.Token(Token = "0x600403F")]
			[Cpp2IlInjected.Address(RVA = "0x371EE80", Offset = "0x371D880", VA = "0x18371EE80")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.FinishHouse)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004040")]
			[Cpp2IlInjected.Address(RVA = "0x3720290", Offset = "0x371EC90", VA = "0x183720290")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001087")]
		[DebuggerNonUserCode]
		public CustomStepFollowCharacter FollowCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6004041")]
			[Cpp2IlInjected.Address(RVA = "0x371EEE0", Offset = "0x371D8E0", VA = "0x18371EEE0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.FollowCharacter)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004042")]
			[Cpp2IlInjected.Address(RVA = "0x37202D0", Offset = "0x371ECD0", VA = "0x1837202D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001088")]
		[DebuggerNonUserCode]
		public CustomStepFriend Friend
		{
			[Cpp2IlInjected.Token(Token = "0x6004043")]
			[Cpp2IlInjected.Address(RVA = "0x371EF40", Offset = "0x371D940", VA = "0x18371EF40")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Friend)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004044")]
			[Cpp2IlInjected.Address(RVA = "0x3720310", Offset = "0x371ED10", VA = "0x183720310")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001089")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest GardeningHarvest
		{
			[Cpp2IlInjected.Token(Token = "0x6004045")]
			[Cpp2IlInjected.Address(RVA = "0x371EFA0", Offset = "0x371D9A0", VA = "0x18371EFA0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.GardeningHarvest)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004046")]
			[Cpp2IlInjected.Address(RVA = "0x3720350", Offset = "0x371ED50", VA = "0x183720350")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700108A")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant GardeningPlant
		{
			[Cpp2IlInjected.Token(Token = "0x6004047")]
			[Cpp2IlInjected.Address(RVA = "0x371F000", Offset = "0x371DA00", VA = "0x18371F000")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.GardeningPlant)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004048")]
			[Cpp2IlInjected.Address(RVA = "0x3720390", Offset = "0x371ED90", VA = "0x183720390")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700108B")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem GiftToCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6004049")]
			[Cpp2IlInjected.Address(RVA = "0x371F460", Offset = "0x371DE60", VA = "0x18371F460")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.GiftToCharacter)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600404A")]
			[Cpp2IlInjected.Address(RVA = "0x37203D0", Offset = "0x371EDD0", VA = "0x1837203D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700108C")]
		[DebuggerNonUserCode]
		public CustomStepInteraction Interaction
		{
			[Cpp2IlInjected.Token(Token = "0x600404B")]
			[Cpp2IlInjected.Address(RVA = "0x371F4C0", Offset = "0x371DEC0", VA = "0x18371F4C0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Interaction)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600404C")]
			[Cpp2IlInjected.Address(RVA = "0x3720410", Offset = "0x371EE10", VA = "0x183720410")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700108D")]
		[DebuggerNonUserCode]
		public CustomStepListen Listen
		{
			[Cpp2IlInjected.Token(Token = "0x600404D")]
			[Cpp2IlInjected.Address(RVA = "0x371F5A0", Offset = "0x371DFA0", VA = "0x18371F5A0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Listen)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600404E")]
			[Cpp2IlInjected.Address(RVA = "0x3720450", Offset = "0x371EE50", VA = "0x183720450")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700108E")]
		[DebuggerNonUserCode]
		public CustomStepMakeGarden MakeGarden
		{
			[Cpp2IlInjected.Token(Token = "0x600404F")]
			[Cpp2IlInjected.Address(RVA = "0x371F600", Offset = "0x371E000", VA = "0x18371F600")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.MakeGarden)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004050")]
			[Cpp2IlInjected.Address(RVA = "0x3720490", Offset = "0x371EE90", VA = "0x183720490")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700108F")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral MineMineral
		{
			[Cpp2IlInjected.Token(Token = "0x6004051")]
			[Cpp2IlInjected.Address(RVA = "0x371F660", Offset = "0x371E060", VA = "0x18371F660")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.MineMineral)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004052")]
			[Cpp2IlInjected.Address(RVA = "0x37204D0", Offset = "0x371EED0", VA = "0x1837204D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001090")]
		[DebuggerNonUserCode]
		public CustomStepParty Party
		{
			[Cpp2IlInjected.Token(Token = "0x6004053")]
			[Cpp2IlInjected.Address(RVA = "0x371F720", Offset = "0x371E120", VA = "0x18371F720")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Party)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004054")]
			[Cpp2IlInjected.Address(RVA = "0x3720510", Offset = "0x371EF10", VA = "0x183720510")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001091")]
		[DebuggerNonUserCode]
		public CustomStepPickUp PickUp
		{
			[Cpp2IlInjected.Token(Token = "0x6004055")]
			[Cpp2IlInjected.Address(RVA = "0x371F780", Offset = "0x371E180", VA = "0x18371F780")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.PickUp)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004056")]
			[Cpp2IlInjected.Address(RVA = "0x3720550", Offset = "0x371EF50", VA = "0x183720550")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001092")]
		[DebuggerNonUserCode]
		public CustomStepPlaceBuilding PlaceBuilding
		{
			[Cpp2IlInjected.Token(Token = "0x6004057")]
			[Cpp2IlInjected.Address(RVA = "0x371F7E0", Offset = "0x371E1E0", VA = "0x18371F7E0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.PlaceBuilding)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004058")]
			[Cpp2IlInjected.Address(RVA = "0x3720590", Offset = "0x371EF90", VA = "0x183720590")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001093")]
		[DebuggerNonUserCode]
		public CustomStepPossess Possess
		{
			[Cpp2IlInjected.Token(Token = "0x6004059")]
			[Cpp2IlInjected.Address(RVA = "0x371F840", Offset = "0x371E240", VA = "0x18371F840")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Possess)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600405A")]
			[Cpp2IlInjected.Address(RVA = "0x37205D0", Offset = "0x371EFD0", VA = "0x1837205D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001094")]
		[DebuggerNonUserCode]
		public CustomStepPurchaseItem PurchaseItem
		{
			[Cpp2IlInjected.Token(Token = "0x600405B")]
			[Cpp2IlInjected.Address(RVA = "0x371F8A0", Offset = "0x371E2A0", VA = "0x18371F8A0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.PurchaseItem)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600405C")]
			[Cpp2IlInjected.Address(RVA = "0x3720610", Offset = "0x371F010", VA = "0x183720610")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001095")]
		[DebuggerNonUserCode]
		public CustomStepRemoveBlocker RemoveBlocker
		{
			[Cpp2IlInjected.Token(Token = "0x600405D")]
			[Cpp2IlInjected.Address(RVA = "0x371F900", Offset = "0x371E300", VA = "0x18371F900")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.RemoveBlocker)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600405E")]
			[Cpp2IlInjected.Address(RVA = "0x3720650", Offset = "0x371F050", VA = "0x183720650")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001096")]
		[DebuggerNonUserCode]
		public CustomStepRoyalDuties RoyalDuties
		{
			[Cpp2IlInjected.Token(Token = "0x600405F")]
			[Cpp2IlInjected.Address(RVA = "0x371F960", Offset = "0x371E360", VA = "0x18371F960")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.RoyalDuties)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004060")]
			[Cpp2IlInjected.Address(RVA = "0x3720690", Offset = "0x371F090", VA = "0x183720690")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001097")]
		[DebuggerNonUserCode]
		public CustomStepSellItem SellItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004061")]
			[Cpp2IlInjected.Address(RVA = "0x371F9C0", Offset = "0x371E3C0", VA = "0x18371F9C0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.SellItem)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004062")]
			[Cpp2IlInjected.Address(RVA = "0x37206D0", Offset = "0x371F0D0", VA = "0x1837206D0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001098")]
		[DebuggerNonUserCode]
		public CustomStepServeRestaurantOrder ServeRestaurantOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6004063")]
			[Cpp2IlInjected.Address(RVA = "0x371FA20", Offset = "0x371E420", VA = "0x18371FA20")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.ServeRestaurantOrder)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004064")]
			[Cpp2IlInjected.Address(RVA = "0x3720710", Offset = "0x371F110", VA = "0x183720710")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001099")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion StartDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6004065")]
			[Cpp2IlInjected.Address(RVA = "0x371FA80", Offset = "0x371E480", VA = "0x18371FA80")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.StartDiscussion)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004066")]
			[Cpp2IlInjected.Address(RVA = "0x3720750", Offset = "0x371F150", VA = "0x183720750")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700109A")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture TakePicture
		{
			[Cpp2IlInjected.Token(Token = "0x6004067")]
			[Cpp2IlInjected.Address(RVA = "0x371FAE0", Offset = "0x371E4E0", VA = "0x18371FAE0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.TakePicture)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004068")]
			[Cpp2IlInjected.Address(RVA = "0x3720870", Offset = "0x371F270", VA = "0x183720870")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700109B")]
		[DebuggerNonUserCode]
		public CustomStepTalkToCharacter TalkToCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6004069")]
			[Cpp2IlInjected.Address(RVA = "0x371FB40", Offset = "0x371E540", VA = "0x18371FB40")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.TalkToCharacter)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600406A")]
			[Cpp2IlInjected.Address(RVA = "0x37208B0", Offset = "0x371F2B0", VA = "0x1837208B0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700109C")]
		[DebuggerNonUserCode]
		public CustomStepUnlock Unlock
		{
			[Cpp2IlInjected.Token(Token = "0x600406B")]
			[Cpp2IlInjected.Address(RVA = "0x371FC00", Offset = "0x371E600", VA = "0x18371FC00")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Unlock)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600406C")]
			[Cpp2IlInjected.Address(RVA = "0x3720930", Offset = "0x371F330", VA = "0x183720930")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700109D")]
		[DebuggerNonUserCode]
		public CustomStepUnlockCharacter UnlockCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600406D")]
			[Cpp2IlInjected.Address(RVA = "0x371FBA0", Offset = "0x371E5A0", VA = "0x18371FBA0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.UnlockCharacter)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600406E")]
			[Cpp2IlInjected.Address(RVA = "0x37208F0", Offset = "0x371F2F0", VA = "0x1837208F0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700109E")]
		[DebuggerNonUserCode]
		public CustomStepUpgrade Upgrade
		{
			[Cpp2IlInjected.Token(Token = "0x600406F")]
			[Cpp2IlInjected.Address(RVA = "0x371FC60", Offset = "0x371E660", VA = "0x18371FC60")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.Upgrade)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004070")]
			[Cpp2IlInjected.Address(RVA = "0x3720970", Offset = "0x371F370", VA = "0x183720970")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700109F")]
		[DebuggerNonUserCode]
		public CustomStepVisitArea VisitArea
		{
			[Cpp2IlInjected.Token(Token = "0x6004071")]
			[Cpp2IlInjected.Address(RVA = "0x371FCC0", Offset = "0x371E6C0", VA = "0x18371FCC0")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.VisitArea)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004072")]
			[Cpp2IlInjected.Address(RVA = "0x37209B0", Offset = "0x371F3B0", VA = "0x1837209B0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A0")]
		[DebuggerNonUserCode]
		public CustomStepWaterPlant WaterPlant
		{
			[Cpp2IlInjected.Token(Token = "0x6004073")]
			[Cpp2IlInjected.Address(RVA = "0x371FD20", Offset = "0x371E720", VA = "0x18371FD20")]
			get
			{
				int num = 0;
				if (customStepCase_ == CustomStepOneofCase.WaterPlant)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004074")]
			[Cpp2IlInjected.Address(RVA = "0x37209F0", Offset = "0x371F3F0", VA = "0x1837209F0")]
			set
			{
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A1")]
		[DebuggerNonUserCode]
		public CustomStepOneofCase CustomStepCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004075")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return customStepCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A2")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6004084")]
			[Cpp2IlInjected.Address(RVA = "0x371F520", Offset = "0x371DF20", VA = "0x18371F520", Slot = "18")]
			get
			{
				if ((object)typeof(IItemSelector).TypeHandle != null)
				{
				}
				return (ItemSelector)typeof(IItemSelector).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A3")]
		public IItemSelector GetIItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6004085")]
			[Cpp2IlInjected.Address(RVA = "0x371F160", Offset = "0x371DB60", VA = "0x18371F160")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A4")]
		public IItemSelectorsWithAmount GetIItemSelectorsWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004086")]
			[Cpp2IlInjected.Address(RVA = "0x371F1A0", Offset = "0x371DBA0", VA = "0x18371F1A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A5")]
		public IUniqueItem GetIUniqueItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004087")]
			[Cpp2IlInjected.Address(RVA = "0x371F320", Offset = "0x371DD20", VA = "0x18371F320")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A6")]
		public IStepAmount GetIStepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004088")]
			[Cpp2IlInjected.Address(RVA = "0x371F260", Offset = "0x371DC60", VA = "0x18371F260")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A7")]
		public IMinWeightReq GetMinWeightReqStepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004089")]
			[Cpp2IlInjected.Address(RVA = "0x371F420", Offset = "0x371DE20", VA = "0x18371F420")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A8")]
		public IMaxWeightReq GetMaxWeightReqStepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600408A")]
			[Cpp2IlInjected.Address(RVA = "0x371F3A0", Offset = "0x371DDA0", VA = "0x18371F3A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A9")]
		public IMinStarRatingReq GetMinStarRatingReqStepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600408B")]
			[Cpp2IlInjected.Address(RVA = "0x371F3E0", Offset = "0x371DDE0", VA = "0x18371F3E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010AA")]
		public IStringTag GetIStringTag
		{
			[Cpp2IlInjected.Token(Token = "0x600408C")]
			[Cpp2IlInjected.Address(RVA = "0x371F2A0", Offset = "0x371DCA0", VA = "0x18371F2A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010AB")]
		public ITargetCharacterOverride GetITargetCharacterOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600408D")]
			[Cpp2IlInjected.Address(RVA = "0x371F2E0", Offset = "0x371DCE0", VA = "0x18371F2E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010AC")]
		public ICharactersAvaibility GetIOtherCharactersAvaibility
		{
			[Cpp2IlInjected.Token(Token = "0x600408E")]
			[Cpp2IlInjected.Address(RVA = "0x371F1E0", Offset = "0x371DBE0", VA = "0x18371F1E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010AD")]
		public IChallengeType GetIChallengeType
		{
			[Cpp2IlInjected.Token(Token = "0x6004092")]
			[Cpp2IlInjected.Address(RVA = "0x371F0E0", Offset = "0x371DAE0", VA = "0x18371F0E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010AE")]
		public ISpawnHelper GetISpawnHelper
		{
			[Cpp2IlInjected.Token(Token = "0x6004093")]
			[Cpp2IlInjected.Address(RVA = "0x371F220", Offset = "0x371DC20", VA = "0x18371F220")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010AF")]
		public IAreaFilter GetIAreaFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6004094")]
			[Cpp2IlInjected.Address(RVA = "0x371F060", Offset = "0x371DA60", VA = "0x18371F060")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B0")]
		public IItemAmount GetIItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004095")]
			[Cpp2IlInjected.Address(RVA = "0x371F120", Offset = "0x371DB20", VA = "0x18371F120")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B1")]
		public IVillageAreaMapMarker GetIVillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x6004096")]
			[Cpp2IlInjected.Address(RVA = "0x371F360", Offset = "0x371DD60", VA = "0x18371F360")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B2")]
		public IBuildingMapMarker GetIBuildingMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x6004097")]
			[Cpp2IlInjected.Address(RVA = "0x371F0A0", Offset = "0x371DAA0", VA = "0x18371F0A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004010")]
		[Cpp2IlInjected.Address(RVA = "0x371DA20", Offset = "0x371C420", VA = "0x18371DA20")]
		[DebuggerNonUserCode]
		public MissionObjectiveData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004011")]
		[Cpp2IlInjected.Address(RVA = "0x371DA80", Offset = "0x371C480", VA = "0x18371DA80")]
		[DebuggerNonUserCode]
		public MissionObjectiveData(MissionObjectiveData other)
		{
			//IL_0633: Expected I4, but got O
			string text = (stepDescription_ = other.stepDescription_);
			int num = (objectiveID_ = other.objectiveID_);
			string text2 = (stepName_ = other.stepName_);
			bool flag = (hideProgressionCount_ = other.hideProgressionCount_);
			bool flag2 = (hideCharacterFeedback_ = other.hideCharacterFeedback_);
			bool flag3 = (skipSubStepWhenCompleted_ = other.skipSubStepWhenCompleted_);
			CustomStepOneofCase customStepOneofCase = other.customStepCase_;
			if (customStepOneofCase > CustomStepOneofCase.GardeningPlant)
			{
				if (customStepOneofCase > CustomStepOneofCase.RemoveBlocker)
				{
					if (customStepOneofCase > CustomStepOneofCase.TakePicture)
					{
						if (customStepOneofCase > CustomStepOneofCase.UnlockCharacter)
						{
							if (customStepOneofCase == CustomStepOneofCase.Upgrade)
							{
								CustomStepUpgrade customStepUpgrade = (CustomStepUpgrade)(customStep_ = other.Upgrade.Clone());
							}
							if (customStepOneofCase == CustomStepOneofCase.VisitArea)
							{
								CustomStepVisitArea customStepVisitArea = (CustomStepVisitArea)(customStep_ = other.VisitArea.Clone());
							}
							if (customStepOneofCase != CustomStepOneofCase.WaterPlant)
							{
								goto IL_0633;
							}
							CustomStepWaterPlant customStepWaterPlant = (CustomStepWaterPlant)(customStep_ = other.WaterPlant.Clone());
						}
						if (customStepOneofCase == CustomStepOneofCase.TalkToCharacter)
						{
							CustomStepTalkToCharacter customStepTalkToCharacter = (CustomStepTalkToCharacter)(customStep_ = other.TalkToCharacter.Clone());
						}
						if (customStepOneofCase == CustomStepOneofCase.Unlock)
						{
							CustomStepUnlock customStepUnlock = (CustomStepUnlock)(customStep_ = other.Unlock.Clone());
						}
						if (customStepOneofCase != CustomStepOneofCase.UnlockCharacter)
						{
							goto IL_0633;
						}
						CustomStepUnlockCharacter customStepUnlockCharacter = (CustomStepUnlockCharacter)(customStep_ = other.UnlockCharacter.Clone());
					}
					if (customStepOneofCase > CustomStepOneofCase.SellItem)
					{
						if (customStepOneofCase == CustomStepOneofCase.ServeRestaurantOrder)
						{
							CustomStepServeRestaurantOrder customStepServeRestaurantOrder = (CustomStepServeRestaurantOrder)(customStep_ = other.ServeRestaurantOrder.Clone());
						}
						if (customStepOneofCase == CustomStepOneofCase.StartDiscussion)
						{
							CustomStepStartDiscussion customStepStartDiscussion = (CustomStepStartDiscussion)(customStep_ = other.StartDiscussion.Clone());
						}
						if (customStepOneofCase != CustomStepOneofCase.TakePicture)
						{
							goto IL_0633;
						}
						CustomStepTakePicture customStepTakePicture = (CustomStepTakePicture)(customStep_ = other.TakePicture.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.RoyalDuties)
					{
						CustomStepRoyalDuties customStepRoyalDuties = (CustomStepRoyalDuties)(customStep_ = other.RoyalDuties.Clone());
					}
					if (customStepOneofCase != CustomStepOneofCase.SellItem)
					{
						goto IL_0633;
					}
					CustomStepSellItem customStepSellItem = (CustomStepSellItem)(customStep_ = other.SellItem.Clone());
				}
				if (customStepOneofCase > CustomStepOneofCase.MineMineral)
				{
					if (customStepOneofCase > CustomStepOneofCase.PlaceBuilding)
					{
						if (customStepOneofCase == CustomStepOneofCase.Possess)
						{
							CustomStepPossess customStepPossess = (CustomStepPossess)(customStep_ = other.Possess.Clone());
						}
						if (customStepOneofCase == CustomStepOneofCase.PurchaseItem)
						{
							CustomStepPurchaseItem customStepPurchaseItem = (CustomStepPurchaseItem)(customStep_ = other.PurchaseItem.Clone());
						}
						if (customStepOneofCase != CustomStepOneofCase.RemoveBlocker)
						{
							goto IL_0633;
						}
						CustomStepRemoveBlocker customStepRemoveBlocker = (CustomStepRemoveBlocker)(customStep_ = other.RemoveBlocker.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.Party)
					{
						CustomStepParty customStepParty = (CustomStepParty)(customStep_ = other.Party.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.PickUp)
					{
						CustomStepPickUp customStepPickUp = (CustomStepPickUp)(customStep_ = other.PickUp.Clone());
					}
					if (customStepOneofCase != CustomStepOneofCase.PlaceBuilding)
					{
						goto IL_0633;
					}
					CustomStepPlaceBuilding customStepPlaceBuilding = (CustomStepPlaceBuilding)(customStep_ = other.PlaceBuilding.Clone());
				}
				if (customStepOneofCase > CustomStepOneofCase.Interaction)
				{
					if (customStepOneofCase == CustomStepOneofCase.Listen)
					{
						CustomStepListen customStepListen = (CustomStepListen)(customStep_ = other.Listen.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.MakeGarden)
					{
						CustomStepMakeGarden customStepMakeGarden = (CustomStepMakeGarden)(customStep_ = other.MakeGarden.Clone());
					}
					if (customStepOneofCase != CustomStepOneofCase.MineMineral)
					{
						goto IL_0633;
					}
					CustomStepMineMineral customStepMineMineral = (CustomStepMineMineral)(customStep_ = other.MineMineral.Clone());
				}
				if (customStepOneofCase == CustomStepOneofCase.GiftToCharacter)
				{
					CustomStepGiftToCharacterItem customStepGiftToCharacterItem = (CustomStepGiftToCharacterItem)(customStep_ = other.GiftToCharacter.Clone());
				}
				if (customStepOneofCase != CustomStepOneofCase.Interaction)
				{
					goto IL_0633;
				}
				CustomStepInteraction customStepInteraction = (CustomStepInteraction)(customStep_ = other.Interaction.Clone());
			}
			if (customStepOneofCase > CustomStepOneofCase.Decorate)
			{
				if (customStepOneofCase > CustomStepOneofCase.FeedCritter)
				{
					if (customStepOneofCase > CustomStepOneofCase.FollowCharacter)
					{
						if (customStepOneofCase == CustomStepOneofCase.Friend)
						{
							CustomStepFriend customStepFriend = (CustomStepFriend)(customStep_ = other.Friend.Clone());
						}
						if (customStepOneofCase == CustomStepOneofCase.GardeningHarvest)
						{
							CustomStepGardeningHarvest customStepGardeningHarvest = (CustomStepGardeningHarvest)(customStep_ = other.GardeningHarvest.Clone());
						}
						if (customStepOneofCase != CustomStepOneofCase.GardeningPlant)
						{
							goto IL_0633;
						}
						CustomStepGardeningPlant customStepGardeningPlant = (CustomStepGardeningPlant)(customStep_ = other.GardeningPlant.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.FillKeyhole)
					{
						CustomStepFillKeyhole customStepFillKeyhole = (CustomStepFillKeyhole)(customStep_ = other.FillKeyhole.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.FinishHouse)
					{
						CustomStepFinishHouse customStepFinishHouse = (CustomStepFinishHouse)(customStep_ = other.FinishHouse.Clone());
					}
					if (customStepOneofCase != CustomStepOneofCase.FollowCharacter)
					{
						goto IL_0633;
					}
					CustomStepFollowCharacter customStepFollowCharacter = (CustomStepFollowCharacter)(customStep_ = other.FollowCharacter.Clone());
				}
				if (customStepOneofCase > CustomStepOneofCase.DressUp)
				{
					if (customStepOneofCase == CustomStepOneofCase.EatMeal)
					{
						CustomStepEatMeal customStepEatMeal = (CustomStepEatMeal)(customStep_ = other.EatMeal.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.ExpandHouse)
					{
						CustomStepExpandHouse customStepExpandHouse = (CustomStepExpandHouse)(customStep_ = other.ExpandHouse.Clone());
					}
					if (customStepOneofCase != CustomStepOneofCase.FeedCritter)
					{
						goto IL_0633;
					}
					CustomStepFeedCritter customStepFeedCritter = (CustomStepFeedCritter)(customStep_ = other.FeedCritter.Clone());
				}
				if (customStepOneofCase == CustomStepOneofCase.DesignChallenge)
				{
					CustomStepDesignChallenge customStepDesignChallenge = (CustomStepDesignChallenge)(customStep_ = other.DesignChallenge.Clone());
				}
				if (customStepOneofCase != CustomStepOneofCase.DressUp)
				{
					goto IL_0633;
				}
				CustomStepDressUp customStepDressUp = (CustomStepDressUp)(customStep_ = other.DressUp.Clone());
			}
			if (customStepOneofCase > CustomStepOneofCase.CollectCurrency)
			{
				if (customStepOneofCase > CustomStepOneofCase.ConsumeItem)
				{
					if (customStepOneofCase == CustomStepOneofCase.CookMeal)
					{
						CustomStepCookMeal customStepCookMeal = (CustomStepCookMeal)(customStep_ = other.CookMeal.Clone());
					}
					if (customStepOneofCase == CustomStepOneofCase.CraftItem)
					{
						CustomStepCraftItem customStepCraftItem = (CustomStepCraftItem)(customStep_ = other.CraftItem.Clone());
					}
					if (customStepOneofCase != CustomStepOneofCase.Decorate)
					{
						goto IL_0633;
					}
					CustomStepDecorate customStepDecorate = (CustomStepDecorate)(customStep_ = other.Decorate.Clone());
				}
				if (customStepOneofCase == CustomStepOneofCase.Conditional)
				{
					CustomStepConditional customStepConditional = (CustomStepConditional)(customStep_ = other.Conditional.Clone());
				}
				if (customStepOneofCase != CustomStepOneofCase.ConsumeItem)
				{
					goto IL_0633;
				}
				CustomStepConsumeItem customStepConsumeItem = (CustomStepConsumeItem)(customStep_ = other.ConsumeItem.Clone());
			}
			if (customStepOneofCase > CustomStepOneofCase.Cancel)
			{
				if (customStepOneofCase == CustomStepOneofCase.CatchFish)
				{
					CustomStepCatchFish customStepCatchFish = (CustomStepCatchFish)(customStep_ = other.CatchFish.Clone());
				}
				if (customStepOneofCase == CustomStepOneofCase.Chase)
				{
					CustomStepChase customStepChase = (CustomStepChase)(customStep_ = other.Chase.Clone());
				}
				if (customStepOneofCase != CustomStepOneofCase.CollectCurrency)
				{
					goto IL_0633;
				}
				CustomStepCollectCurrency customStepCollectCurrency = (CustomStepCollectCurrency)(customStep_ = other.CollectCurrency.Clone());
			}
			if (customStepOneofCase == CustomStepOneofCase.BringItem)
			{
				CustomStepBringItem customStepBringItem = (CustomStepBringItem)(customStep_ = other.BringItem.Clone());
			}
			if (customStepOneofCase == CustomStepOneofCase.Cancel)
			{
				customStepCase_ = (CustomStepOneofCase)(customStep_ = other.Cancel.Clone());
			}
			goto IL_0633;
			IL_0633:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004012")]
		[Cpp2IlInjected.Address(RVA = "0x3713E30", Offset = "0x3712830", VA = "0x183713E30", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionObjectiveData Clone()
		{
			return new MissionObjectiveData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004076")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearCustomStep()
		{
			//IL_0010: Expected O, but got I4
			customStep_ = (customStepCase_ = CustomStepOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004077")]
		[Cpp2IlInjected.Address(RVA = "0x3714770", Offset = "0x3713170", VA = "0x183714770", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MissionObjectiveData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004078")]
		[Cpp2IlInjected.Address(RVA = "0x3713F10", Offset = "0x3712910", VA = "0x183713F10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionObjectiveData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.stepDescription_;
				if (!(stepDescription_ != text))
				{
					int num = other.objectiveID_;
					if (objectiveID_ == num)
					{
						string text2 = other.stepName_;
						if (!(stepName_ != text2))
						{
							bool flag = other.hideProgressionCount_;
							if (hideProgressionCount_ == flag)
							{
								bool flag2 = other.hideCharacterFeedback_;
								if (hideCharacterFeedback_ == flag2)
								{
									bool flag3 = other.skipSubStepWhenCompleted_;
									if (skipSubStepWhenCompleted_ == flag3)
									{
										CustomStepBringItem bringItem = BringItem;
										CustomStepBringItem bringItem2 = other.BringItem;
										if (object.Equals(bringItem, bringItem2))
										{
											CustomStepCancel cancel = Cancel;
											CustomStepCancel cancel2 = other.Cancel;
											if (object.Equals(cancel, cancel2))
											{
												CustomStepCatchFish catchFish = CatchFish;
												CustomStepCatchFish catchFish2 = other.CatchFish;
												if (object.Equals(catchFish, catchFish2))
												{
													CustomStepChase chase = Chase;
													CustomStepChase chase2 = other.Chase;
													if (object.Equals(chase, chase2))
													{
														CustomStepCollectCurrency collectCurrency = CollectCurrency;
														CustomStepCollectCurrency collectCurrency2 = other.CollectCurrency;
														if (object.Equals(collectCurrency, collectCurrency2))
														{
															CustomStepConditional conditional = Conditional;
															CustomStepConditional conditional2 = other.Conditional;
															if (object.Equals(conditional, conditional2))
															{
																CustomStepConsumeItem consumeItem = ConsumeItem;
																CustomStepConsumeItem consumeItem2 = other.ConsumeItem;
																if (object.Equals(consumeItem, consumeItem2))
																{
																	CustomStepCookMeal cookMeal = CookMeal;
																	CustomStepCookMeal cookMeal2 = other.CookMeal;
																	if (object.Equals(cookMeal, cookMeal2))
																	{
																		CustomStepCraftItem craftItem = CraftItem;
																		CustomStepCraftItem craftItem2 = other.CraftItem;
																		if (object.Equals(craftItem, craftItem2))
																		{
																			CustomStepDecorate decorate = Decorate;
																			CustomStepDecorate decorate2 = other.Decorate;
																			if (object.Equals(decorate, decorate2))
																			{
																				CustomStepDesignChallenge designChallenge = DesignChallenge;
																				CustomStepDesignChallenge designChallenge2 = other.DesignChallenge;
																				if (object.Equals(designChallenge, designChallenge2))
																				{
																					CustomStepDressUp dressUp = DressUp;
																					CustomStepDressUp dressUp2 = other.DressUp;
																					if (object.Equals(dressUp, dressUp2))
																					{
																						CustomStepEatMeal eatMeal = EatMeal;
																						CustomStepEatMeal eatMeal2 = other.EatMeal;
																						if (object.Equals(eatMeal, eatMeal2))
																						{
																							CustomStepExpandHouse expandHouse = ExpandHouse;
																							CustomStepExpandHouse expandHouse2 = other.ExpandHouse;
																							if (object.Equals(expandHouse, expandHouse2))
																							{
																								CustomStepFeedCritter feedCritter = FeedCritter;
																								CustomStepFeedCritter feedCritter2 = other.FeedCritter;
																								if (object.Equals(feedCritter, feedCritter2))
																								{
																									CustomStepFillKeyhole fillKeyhole = FillKeyhole;
																									CustomStepFillKeyhole fillKeyhole2 = other.FillKeyhole;
																									if (object.Equals(fillKeyhole, fillKeyhole2))
																									{
																										CustomStepFinishHouse finishHouse = FinishHouse;
																										CustomStepFinishHouse finishHouse2 = other.FinishHouse;
																										if (object.Equals(finishHouse, finishHouse2))
																										{
																											CustomStepFollowCharacter followCharacter = FollowCharacter;
																											CustomStepFollowCharacter followCharacter2 = other.FollowCharacter;
																											if (object.Equals(followCharacter, followCharacter2))
																											{
																												CustomStepFriend friend = Friend;
																												CustomStepFriend friend2 = other.Friend;
																												if (object.Equals(friend, friend2))
																												{
																													CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
																													CustomStepGardeningHarvest gardeningHarvest2 = other.GardeningHarvest;
																													if (object.Equals(gardeningHarvest, gardeningHarvest2))
																													{
																														CustomStepGardeningPlant gardeningPlant = GardeningPlant;
																														CustomStepGardeningPlant gardeningPlant2 = other.GardeningPlant;
																														if (object.Equals(gardeningPlant, gardeningPlant2))
																														{
																															CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
																															CustomStepGiftToCharacterItem giftToCharacter2 = other.GiftToCharacter;
																															if (object.Equals(giftToCharacter, giftToCharacter2))
																															{
																																CustomStepInteraction interaction = Interaction;
																																CustomStepInteraction interaction2 = other.Interaction;
																																if (object.Equals(interaction, interaction2))
																																{
																																	CustomStepListen listen = Listen;
																																	CustomStepListen listen2 = other.Listen;
																																	if (object.Equals(listen, listen2))
																																	{
																																		CustomStepMakeGarden makeGarden = MakeGarden;
																																		CustomStepMakeGarden makeGarden2 = other.MakeGarden;
																																		if (object.Equals(makeGarden, makeGarden2))
																																		{
																																			CustomStepMineMineral mineMineral = MineMineral;
																																			CustomStepMineMineral mineMineral2 = other.MineMineral;
																																			if (object.Equals(mineMineral, mineMineral2))
																																			{
																																				CustomStepParty party = Party;
																																				CustomStepParty party2 = other.Party;
																																				if (object.Equals(party, party2))
																																				{
																																					CustomStepPickUp pickUp = PickUp;
																																					CustomStepPickUp pickUp2 = other.PickUp;
																																					if (object.Equals(pickUp, pickUp2))
																																					{
																																						CustomStepPlaceBuilding placeBuilding = PlaceBuilding;
																																						CustomStepPlaceBuilding placeBuilding2 = other.PlaceBuilding;
																																						if (object.Equals(placeBuilding, placeBuilding2))
																																						{
																																							CustomStepPossess possess = Possess;
																																							CustomStepPossess possess2 = other.Possess;
																																							if (object.Equals(possess, possess2))
																																							{
																																								CustomStepPurchaseItem purchaseItem = PurchaseItem;
																																								CustomStepPurchaseItem purchaseItem2 = other.PurchaseItem;
																																								if (object.Equals(purchaseItem, purchaseItem2))
																																								{
																																									CustomStepRemoveBlocker removeBlocker = RemoveBlocker;
																																									CustomStepRemoveBlocker removeBlocker2 = other.RemoveBlocker;
																																									if (object.Equals(removeBlocker, removeBlocker2))
																																									{
																																										CustomStepRoyalDuties royalDuties = RoyalDuties;
																																										CustomStepRoyalDuties royalDuties2 = other.RoyalDuties;
																																										if (object.Equals(royalDuties, royalDuties2))
																																										{
																																											CustomStepSellItem sellItem = SellItem;
																																											CustomStepSellItem sellItem2 = other.SellItem;
																																											if (object.Equals(sellItem, sellItem2))
																																											{
																																												CustomStepServeRestaurantOrder serveRestaurantOrder = ServeRestaurantOrder;
																																												CustomStepServeRestaurantOrder serveRestaurantOrder2 = other.ServeRestaurantOrder;
																																												if (object.Equals(serveRestaurantOrder, serveRestaurantOrder2))
																																												{
																																													CustomStepStartDiscussion startDiscussion = StartDiscussion;
																																													CustomStepStartDiscussion startDiscussion2 = other.StartDiscussion;
																																													if (object.Equals(startDiscussion, startDiscussion2))
																																													{
																																														CustomStepTakePicture takePicture = TakePicture;
																																														CustomStepTakePicture takePicture2 = other.TakePicture;
																																														if (object.Equals(takePicture, takePicture2))
																																														{
																																															CustomStepTalkToCharacter talkToCharacter = TalkToCharacter;
																																															CustomStepTalkToCharacter talkToCharacter2 = other.TalkToCharacter;
																																															if (object.Equals(talkToCharacter, talkToCharacter2))
																																															{
																																																CustomStepUnlock unlock = Unlock;
																																																CustomStepUnlock unlock2 = other.Unlock;
																																																if (object.Equals(unlock, unlock2))
																																																{
																																																	CustomStepUnlockCharacter unlockCharacter = UnlockCharacter;
																																																	CustomStepUnlockCharacter unlockCharacter2 = other.UnlockCharacter;
																																																	if (object.Equals(unlockCharacter, unlockCharacter2))
																																																	{
																																																		CustomStepUpgrade upgrade = Upgrade;
																																																		CustomStepUpgrade upgrade2 = other.Upgrade;
																																																		if (object.Equals(upgrade, upgrade2))
																																																		{
																																																			CustomStepVisitArea visitArea = VisitArea;
																																																			CustomStepVisitArea visitArea2 = other.VisitArea;
																																																			if (object.Equals(visitArea, visitArea2))
																																																			{
																																																				CustomStepWaterPlant waterPlant = WaterPlant;
																																																				CustomStepWaterPlant waterPlant2 = other.WaterPlant;
																																																				if (object.Equals(waterPlant, waterPlant2))
																																																				{
																																																					CustomStepOneofCase customStepOneofCase = other.customStepCase_;
																																																					if (customStepCase_ == customStepOneofCase)
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
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004079")]
		[Cpp2IlInjected.Address(RVA = "0x3714EA0", Offset = "0x37138A0", VA = "0x183714EA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0732
			while (true)
			{
				int num = 0;
				string text = stepDescription_;
				if (text.m_stringLength != num)
				{
					int hashCode = text.GetHashCode();
				}
				if (objectiveID_ != 0)
				{
				}
				string text2 = stepName_;
				if (text2.m_stringLength != num)
				{
					int hashCode2 = text2.GetHashCode();
				}
				if (hideProgressionCount_)
				{
				}
				if (hideCharacterFeedback_)
				{
				}
				if (skipSubStepWhenCompleted_)
				{
				}
				if (customStepCase_ != CustomStepOneofCase.BringItem)
				{
					continue;
				}
				object obj = customStep_;
				if (obj != null)
				{
					int hashCode3 = obj.GetHashCode();
					if (customStepCase_ != CustomStepOneofCase.Cancel)
					{
						continue;
					}
					object obj2 = customStep_;
					if (obj2 != null)
					{
						int hashCode4 = obj2.GetHashCode();
						if (customStepCase_ != CustomStepOneofCase.CatchFish)
						{
							continue;
						}
						object obj3 = customStep_;
						if (obj3 != null)
						{
							int hashCode5 = obj3.GetHashCode();
							if (customStepCase_ != CustomStepOneofCase.Chase)
							{
								continue;
							}
							object obj4 = customStep_;
							if (obj4 != null)
							{
								int hashCode6 = obj4.GetHashCode();
								if (customStepCase_ != CustomStepOneofCase.CollectCurrency)
								{
									continue;
								}
								object obj5 = customStep_;
								if (obj5 != null)
								{
									int hashCode7 = obj5.GetHashCode();
									if (customStepCase_ != CustomStepOneofCase.Conditional)
									{
										continue;
									}
									object obj6 = customStep_;
									if (obj6 != null)
									{
										int hashCode8 = obj6.GetHashCode();
										if (customStepCase_ != CustomStepOneofCase.ConsumeItem)
										{
											continue;
										}
										object obj7 = customStep_;
										if (obj7 != null)
										{
											int hashCode9 = obj7.GetHashCode();
											if (customStepCase_ != CustomStepOneofCase.CookMeal)
											{
												continue;
											}
											object obj8 = customStep_;
											if (obj8 != null)
											{
												int hashCode10 = obj8.GetHashCode();
												if (customStepCase_ != CustomStepOneofCase.CraftItem)
												{
													continue;
												}
												object obj9 = customStep_;
												if (obj9 != null)
												{
													int hashCode11 = obj9.GetHashCode();
													if (customStepCase_ != CustomStepOneofCase.Decorate)
													{
														continue;
													}
													object obj10 = customStep_;
													if (obj10 != null)
													{
														int hashCode12 = obj10.GetHashCode();
														if (customStepCase_ != CustomStepOneofCase.DesignChallenge)
														{
															continue;
														}
														object obj11 = customStep_;
														if (obj11 != null)
														{
															int hashCode13 = obj11.GetHashCode();
															if (customStepCase_ != CustomStepOneofCase.DressUp)
															{
																continue;
															}
															object obj12 = customStep_;
															if (obj12 != null)
															{
																int hashCode14 = obj12.GetHashCode();
																if (customStepCase_ != CustomStepOneofCase.EatMeal)
																{
																	continue;
																}
																object obj13 = customStep_;
																if (obj13 != null)
																{
																	int hashCode15 = obj13.GetHashCode();
																	if (customStepCase_ != CustomStepOneofCase.ExpandHouse)
																	{
																		continue;
																	}
																	object obj14 = customStep_;
																	if (obj14 != null)
																	{
																		int hashCode16 = obj14.GetHashCode();
																		if (customStepCase_ != CustomStepOneofCase.FeedCritter)
																		{
																			continue;
																		}
																		object obj15 = customStep_;
																		if (obj15 != null)
																		{
																			int hashCode17 = obj15.GetHashCode();
																			if (customStepCase_ != CustomStepOneofCase.FillKeyhole)
																			{
																				continue;
																			}
																			object obj16 = customStep_;
																			if (obj16 != null)
																			{
																				int hashCode18 = obj16.GetHashCode();
																				if (customStepCase_ != CustomStepOneofCase.FinishHouse)
																				{
																					continue;
																				}
																				object obj17 = customStep_;
																				if (obj17 != null)
																				{
																					int hashCode19 = obj17.GetHashCode();
																					if (customStepCase_ != CustomStepOneofCase.FollowCharacter)
																					{
																						continue;
																					}
																					object obj18 = customStep_;
																					if (obj18 != null)
																					{
																						int hashCode20 = obj18.GetHashCode();
																						if (customStepCase_ != CustomStepOneofCase.Friend)
																						{
																							continue;
																						}
																						object obj19 = customStep_;
																						if (obj19 != null)
																						{
																							int hashCode21 = obj19.GetHashCode();
																							if (customStepCase_ != CustomStepOneofCase.GardeningHarvest)
																							{
																								continue;
																							}
																							object obj20 = customStep_;
																							if (obj20 != null)
																							{
																								int hashCode22 = obj20.GetHashCode();
																								if (customStepCase_ != CustomStepOneofCase.GardeningPlant)
																								{
																									continue;
																								}
																								object obj21 = customStep_;
																								if (obj21 != null)
																								{
																									int hashCode23 = obj21.GetHashCode();
																									if (customStepCase_ != CustomStepOneofCase.GiftToCharacter)
																									{
																										continue;
																									}
																									object obj22 = customStep_;
																									if (obj22 != null)
																									{
																										int hashCode24 = obj22.GetHashCode();
																										if (customStepCase_ != CustomStepOneofCase.Interaction)
																										{
																											continue;
																										}
																										object obj23 = customStep_;
																										if (obj23 != null)
																										{
																											int hashCode25 = obj23.GetHashCode();
																											if (customStepCase_ != CustomStepOneofCase.Listen)
																											{
																												continue;
																											}
																											object obj24 = customStep_;
																											if (obj24 != null)
																											{
																												int hashCode26 = obj24.GetHashCode();
																												if (customStepCase_ != CustomStepOneofCase.MakeGarden)
																												{
																													continue;
																												}
																												object obj25 = customStep_;
																												if (obj25 != null)
																												{
																													int hashCode27 = obj25.GetHashCode();
																													if (customStepCase_ != CustomStepOneofCase.MineMineral)
																													{
																														continue;
																													}
																													object obj26 = customStep_;
																													if (obj26 != null)
																													{
																														int hashCode28 = obj26.GetHashCode();
																														if (customStepCase_ != CustomStepOneofCase.Party)
																														{
																															continue;
																														}
																														object obj27 = customStep_;
																														if (obj27 != null)
																														{
																															int hashCode29 = obj27.GetHashCode();
																															if (customStepCase_ != CustomStepOneofCase.PickUp)
																															{
																																continue;
																															}
																															object obj28 = customStep_;
																															if (obj28 != null)
																															{
																																int hashCode30 = obj28.GetHashCode();
																																if (customStepCase_ != CustomStepOneofCase.PlaceBuilding)
																																{
																																	continue;
																																}
																																object obj29 = customStep_;
																																if (obj29 != null)
																																{
																																	int hashCode31 = obj29.GetHashCode();
																																	if (customStepCase_ != CustomStepOneofCase.Possess)
																																	{
																																		continue;
																																	}
																																	object obj30 = customStep_;
																																	if (obj30 != null)
																																	{
																																		int hashCode32 = obj30.GetHashCode();
																																		if (customStepCase_ != CustomStepOneofCase.PurchaseItem)
																																		{
																																			continue;
																																		}
																																		object obj31 = customStep_;
																																		if (obj31 != null)
																																		{
																																			int hashCode33 = obj31.GetHashCode();
																																			if (customStepCase_ != CustomStepOneofCase.RemoveBlocker)
																																			{
																																				continue;
																																			}
																																			object obj32 = customStep_;
																																			if (obj32 != null)
																																			{
																																				int hashCode34 = obj32.GetHashCode();
																																				if (customStepCase_ != CustomStepOneofCase.RoyalDuties)
																																				{
																																					continue;
																																				}
																																				object obj33 = customStep_;
																																				if (obj33 != null)
																																				{
																																					int hashCode35 = obj33.GetHashCode();
																																					if (customStepCase_ != CustomStepOneofCase.SellItem)
																																					{
																																						continue;
																																					}
																																					object obj34 = customStep_;
																																					if (obj34 != null)
																																					{
																																						int hashCode36 = obj34.GetHashCode();
																																						if (customStepCase_ != CustomStepOneofCase.ServeRestaurantOrder)
																																						{
																																							continue;
																																						}
																																						object obj35 = customStep_;
																																						if (obj35 != null)
																																						{
																																							int hashCode37 = obj35.GetHashCode();
																																							if (customStepCase_ != CustomStepOneofCase.StartDiscussion)
																																							{
																																								continue;
																																							}
																																							object obj36 = customStep_;
																																							if (obj36 != null)
																																							{
																																								int hashCode38 = obj36.GetHashCode();
																																								if (customStepCase_ != CustomStepOneofCase.TakePicture)
																																								{
																																									continue;
																																								}
																																								object obj37 = customStep_;
																																								if (obj37 != null)
																																								{
																																									int hashCode39 = obj37.GetHashCode();
																																									if (customStepCase_ != CustomStepOneofCase.TalkToCharacter)
																																									{
																																										continue;
																																									}
																																									object obj38 = customStep_;
																																									if (obj38 != null)
																																									{
																																										int hashCode40 = obj38.GetHashCode();
																																										if (customStepCase_ != CustomStepOneofCase.Unlock)
																																										{
																																											continue;
																																										}
																																										object obj39 = customStep_;
																																										if (obj39 != null)
																																										{
																																											int hashCode41 = obj39.GetHashCode();
																																											if (customStepCase_ != CustomStepOneofCase.UnlockCharacter)
																																											{
																																												continue;
																																											}
																																											object obj40 = customStep_;
																																											if (obj40 != null)
																																											{
																																												int hashCode42 = obj40.GetHashCode();
																																												if (customStepCase_ != CustomStepOneofCase.Upgrade)
																																												{
																																													continue;
																																												}
																																												object obj41 = customStep_;
																																												if (obj41 != null)
																																												{
																																													int hashCode43 = obj41.GetHashCode();
																																													if (customStepCase_ != CustomStepOneofCase.VisitArea)
																																													{
																																														continue;
																																													}
																																													object obj42 = customStep_;
																																													if (obj42 != null)
																																													{
																																														int hashCode44 = obj42.GetHashCode();
																																														if (customStepCase_ == CustomStepOneofCase.WaterPlant)
																																														{
																																															object obj43 = customStep_;
																																															if (obj43 == null)
																																															{
																																																break;
																																															}
																																															int hashCode45 = obj43.GetHashCode();
																																														}
																																														UnknownFieldSet unknownFields = _unknownFields;
																																														if (unknownFields != null)
																																														{
																																															int hashCode46 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x600407A")]
		[Cpp2IlInjected.Address(RVA = "0x371BE70", Offset = "0x371A870", VA = "0x18371BE70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600407B")]
		[Cpp2IlInjected.Address(RVA = "0x371C280", Offset = "0x371AC80", VA = "0x18371C280", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			while (true)
			{
				if (stepDescription_.m_stringLength != 0)
				{
					string value = stepDescription_;
					output.WriteString(value);
				}
				if (objectiveID_ != 0)
				{
					int value2 = objectiveID_;
					output.WriteInt32(value2);
				}
				if (stepName_.m_stringLength != 0)
				{
					string value3 = stepName_;
					output.WriteString(value3);
				}
				if (hideProgressionCount_)
				{
					bool value4 = hideProgressionCount_;
					output.WriteBool(value4);
				}
				if (hideCharacterFeedback_)
				{
					bool value5 = hideCharacterFeedback_;
					output.WriteBool(value5);
				}
				if (skipSubStepWhenCompleted_)
				{
					bool value6 = skipSubStepWhenCompleted_;
					output.WriteBool(value6);
				}
				CustomStepOneofCase customStepOneofCase = customStepCase_;
				int num = 0;
				if (customStepOneofCase != CustomStepOneofCase.BringItem)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.BringItem)
				{
					object obj = customStep_;
					if (obj != null && obj == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Cancel)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Cancel)
				{
					object obj2 = customStep_;
					if (obj2 != null && obj2 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.CatchFish)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.CatchFish)
				{
					object obj3 = customStep_;
					if (obj3 != null && obj3 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Chase)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Chase)
				{
					object obj4 = customStep_;
					if (obj4 != null && obj4 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.CollectCurrency)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.CollectCurrency)
				{
					object obj5 = customStep_;
					if (obj5 != null && obj5 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Conditional)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Conditional)
				{
					object obj6 = customStep_;
					if (obj6 != null && obj6 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.ConsumeItem)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.ConsumeItem)
				{
					object obj7 = customStep_;
					if (obj7 != null && obj7 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.CookMeal)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.CookMeal)
				{
					object obj8 = customStep_;
					if (obj8 != null && obj8 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.CraftItem)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.CraftItem)
				{
					object obj9 = customStep_;
					if (obj9 != null && obj9 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Decorate)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Decorate)
				{
					object obj10 = customStep_;
					if (obj10 != null && obj10 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.DesignChallenge)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.DesignChallenge)
				{
					object obj11 = customStep_;
					if (obj11 != null && obj11 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.DressUp)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.DressUp)
				{
					object obj12 = customStep_;
					if (obj12 != null && obj12 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.EatMeal)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.EatMeal)
				{
					object obj13 = customStep_;
					if (obj13 != null && obj13 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.ExpandHouse)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.ExpandHouse)
				{
					object obj14 = customStep_;
					if (obj14 != null && obj14 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.FeedCritter)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.FeedCritter)
				{
					object obj15 = customStep_;
					if (obj15 != null && obj15 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.FillKeyhole)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.FillKeyhole)
				{
					object obj16 = customStep_;
					if (obj16 != null && obj16 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.FinishHouse)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.FinishHouse)
				{
					object obj17 = customStep_;
					if (obj17 != null && obj17 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.FollowCharacter)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.FollowCharacter)
				{
					object obj18 = customStep_;
					if (obj18 != null && obj18 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Friend)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Friend)
				{
					object obj19 = customStep_;
					if (obj19 != null && obj19 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.GardeningHarvest)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.GardeningHarvest)
				{
					object obj20 = customStep_;
					if (obj20 != null && obj20 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.GardeningPlant)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.GardeningPlant)
				{
					object obj21 = customStep_;
					if (obj21 != null && obj21 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.GiftToCharacter)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.GiftToCharacter)
				{
					object obj22 = customStep_;
					if (obj22 != null && obj22 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Interaction)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Interaction)
				{
					object obj23 = customStep_;
					if (obj23 != null && obj23 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Listen)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Listen)
				{
					object obj24 = customStep_;
					if (obj24 != null && obj24 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.MakeGarden)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.MakeGarden)
				{
					object obj25 = customStep_;
					if (obj25 != null && obj25 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.MineMineral)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.MineMineral)
				{
					object obj26 = customStep_;
					if (obj26 != null && obj26 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Party)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Party)
				{
					object obj27 = customStep_;
					if (obj27 != null && obj27 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.PickUp)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.PickUp)
				{
					object obj28 = customStep_;
					if (obj28 != null && obj28 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.PlaceBuilding)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.PlaceBuilding)
				{
					object obj29 = customStep_;
					if (obj29 != null && obj29 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Possess)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Possess)
				{
					object obj30 = customStep_;
					if (obj30 != null && obj30 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.PurchaseItem)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.PurchaseItem)
				{
					object obj31 = customStep_;
					if (obj31 != null && obj31 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.RemoveBlocker)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.RemoveBlocker)
				{
					object obj32 = customStep_;
					if (obj32 != null && obj32 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.RoyalDuties)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.RoyalDuties)
				{
					object obj33 = customStep_;
					if (obj33 != null && obj33 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.SellItem)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.SellItem)
				{
					object obj34 = customStep_;
					if (obj34 != null && obj34 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.ServeRestaurantOrder)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.ServeRestaurantOrder)
				{
					object obj35 = customStep_;
					if (obj35 != null && obj35 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.StartDiscussion)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.StartDiscussion)
				{
					object obj36 = customStep_;
					if (obj36 != null && obj36 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.TakePicture)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.TakePicture)
				{
					object obj37 = customStep_;
					if (obj37 != null && obj37 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.TalkToCharacter)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.TalkToCharacter)
				{
					object obj38 = customStep_;
					if (obj38 != null && obj38 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.Unlock)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.Unlock)
				{
					object obj39 = customStep_;
					if (obj39 != null && obj39 == null)
					{
						continue;
					}
				}
				if (customStepCase_ != CustomStepOneofCase.UnlockCharacter)
				{
					continue;
				}
				if (customStepCase_ == CustomStepOneofCase.UnlockCharacter)
				{
					object obj40 = customStep_;
					if (obj40 != null && obj40 == null)
					{
						continue;
					}
				}
				if (customStepCase_ == CustomStepOneofCase.Upgrade)
				{
					/*Error: Could not find block for branch target IL_084f*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600407C")]
		[Cpp2IlInjected.Address(RVA = "0x37122F0", Offset = "0x3710CF0", VA = "0x1837122F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_09a9
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			int num17 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			int num20 = default(int);
			int num21 = default(int);
			int num22 = default(int);
			int num23 = default(int);
			int num24 = default(int);
			int num25 = default(int);
			int num26 = default(int);
			int num27 = default(int);
			int num28 = default(int);
			int num29 = default(int);
			int num30 = default(int);
			int num31 = default(int);
			int num32 = default(int);
			int num33 = default(int);
			int num34 = default(int);
			int num35 = default(int);
			int num36 = default(int);
			int num37 = default(int);
			int num38 = default(int);
			int num39 = default(int);
			int num40 = default(int);
			int num41 = default(int);
			int num42 = default(int);
			int num43 = default(int);
			int num44 = default(int);
			int num45 = default(int);
			int num46 = default(int);
			int num;
			int num47 = default(int);
			while (true)
			{
				string text = stepDescription_;
				num = 0;
				if (text.m_stringLength != num)
				{
					int num2 = CodedOutputStream.ComputeStringSize(text);
				}
				int num3 = objectiveID_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				string text2 = stepName_;
				if (text2.m_stringLength != num)
				{
					int num5 = CodedOutputStream.ComputeStringSize(text2);
					num5++;
					num += num5;
				}
				if (customStepCase_ == CustomStepOneofCase.BringItem)
				{
					if (customStepCase_ != CustomStepOneofCase.BringItem)
					{
					}
					object obj = customStep_;
					if (obj != null && obj == null)
					{
						continue;
					}
					num += 2;
					num += num6;
				}
				if (customStepCase_ == CustomStepOneofCase.Cancel)
				{
					if (customStepCase_ != CustomStepOneofCase.Cancel)
					{
					}
					object obj2 = customStep_;
					if (obj2 != null && obj2 == null)
					{
						continue;
					}
					num += 2;
					num += num7;
				}
				if (customStepCase_ == CustomStepOneofCase.CatchFish)
				{
					if (customStepCase_ != CustomStepOneofCase.CatchFish)
					{
					}
					object obj3 = customStep_;
					if (obj3 != null && obj3 == null)
					{
						continue;
					}
					num += 2;
					num += num8;
				}
				if (customStepCase_ == CustomStepOneofCase.Chase)
				{
					if (customStepCase_ != CustomStepOneofCase.Chase)
					{
					}
					object obj4 = customStep_;
					if (obj4 != null && obj4 == null)
					{
						continue;
					}
					num += 2;
					num += num9;
				}
				if (customStepCase_ == CustomStepOneofCase.CollectCurrency)
				{
					if (customStepCase_ != CustomStepOneofCase.CollectCurrency)
					{
					}
					object obj5 = customStep_;
					if (obj5 != null && obj5 == null)
					{
						continue;
					}
					num += 2;
					num += num10;
				}
				if (customStepCase_ == CustomStepOneofCase.Conditional)
				{
					if (customStepCase_ != CustomStepOneofCase.Conditional)
					{
					}
					object obj6 = customStep_;
					if (obj6 != null && obj6 == null)
					{
						continue;
					}
					num += 2;
					num += num11;
				}
				if (customStepCase_ == CustomStepOneofCase.ConsumeItem)
				{
					if (customStepCase_ != CustomStepOneofCase.ConsumeItem)
					{
					}
					object obj7 = customStep_;
					if (obj7 != null && obj7 == null)
					{
						continue;
					}
					num += 2;
					num += num12;
				}
				if (customStepCase_ == CustomStepOneofCase.CookMeal)
				{
					if (customStepCase_ != CustomStepOneofCase.CookMeal)
					{
					}
					object obj8 = customStep_;
					if (obj8 != null && obj8 == null)
					{
						continue;
					}
					num += 2;
					num += num13;
				}
				if (customStepCase_ == CustomStepOneofCase.CraftItem)
				{
					if (customStepCase_ != CustomStepOneofCase.CraftItem)
					{
					}
					object obj9 = customStep_;
					if (obj9 != null && obj9 == null)
					{
						continue;
					}
					num += 2;
					num += num14;
				}
				if (customStepCase_ == CustomStepOneofCase.Decorate)
				{
					if (customStepCase_ != CustomStepOneofCase.Decorate)
					{
					}
					object obj10 = customStep_;
					if (obj10 != null && obj10 == null)
					{
						continue;
					}
					num += 2;
					num += num15;
				}
				if (customStepCase_ == CustomStepOneofCase.DesignChallenge)
				{
					if (customStepCase_ != CustomStepOneofCase.DesignChallenge)
					{
					}
					object obj11 = customStep_;
					if (obj11 != null && obj11 == null)
					{
						continue;
					}
					num += 2;
					num += num16;
				}
				if (customStepCase_ == CustomStepOneofCase.DressUp)
				{
					if (customStepCase_ != CustomStepOneofCase.DressUp)
					{
					}
					object obj12 = customStep_;
					if (obj12 != null && obj12 == null)
					{
						continue;
					}
					num += 2;
					num += num17;
				}
				if (customStepCase_ == CustomStepOneofCase.EatMeal)
				{
					if (customStepCase_ != CustomStepOneofCase.EatMeal)
					{
					}
					object obj13 = customStep_;
					if (obj13 != null && obj13 == null)
					{
						continue;
					}
					num += 2;
					num += num18;
				}
				if (customStepCase_ == CustomStepOneofCase.ExpandHouse)
				{
					if (customStepCase_ != CustomStepOneofCase.ExpandHouse)
					{
					}
					object obj14 = customStep_;
					if (obj14 != null && obj14 == null)
					{
						continue;
					}
					num += 2;
					num += num19;
				}
				if (customStepCase_ == CustomStepOneofCase.FeedCritter)
				{
					if (customStepCase_ != CustomStepOneofCase.FeedCritter)
					{
					}
					object obj15 = customStep_;
					if (obj15 != null && obj15 == null)
					{
						continue;
					}
					num += 2;
					num += num20;
				}
				if (customStepCase_ == CustomStepOneofCase.FillKeyhole)
				{
					if (customStepCase_ != CustomStepOneofCase.FillKeyhole)
					{
					}
					object obj16 = customStep_;
					if (obj16 != null && obj16 == null)
					{
						continue;
					}
					num += 2;
					num += num21;
				}
				if (customStepCase_ == CustomStepOneofCase.FinishHouse)
				{
					if (customStepCase_ != CustomStepOneofCase.FinishHouse)
					{
					}
					object obj17 = customStep_;
					if (obj17 != null && obj17 == null)
					{
						continue;
					}
					num += 2;
					num += num22;
				}
				if (customStepCase_ == CustomStepOneofCase.FollowCharacter)
				{
					if (customStepCase_ != CustomStepOneofCase.FollowCharacter)
					{
					}
					object obj18 = customStep_;
					if (obj18 != null && obj18 == null)
					{
						continue;
					}
					num += 2;
					num += num23;
				}
				if (customStepCase_ == CustomStepOneofCase.Friend)
				{
					if (customStepCase_ != CustomStepOneofCase.Friend)
					{
					}
					object obj19 = customStep_;
					if (obj19 != null && obj19 == null)
					{
						continue;
					}
					num += 2;
					num += num24;
				}
				if (customStepCase_ == CustomStepOneofCase.GardeningHarvest)
				{
					if (customStepCase_ != CustomStepOneofCase.GardeningHarvest)
					{
					}
					object obj20 = customStep_;
					if (obj20 != null && obj20 == null)
					{
						continue;
					}
					num += 2;
					num += num25;
				}
				if (customStepCase_ == CustomStepOneofCase.GardeningPlant)
				{
					if (customStepCase_ != CustomStepOneofCase.GardeningPlant)
					{
					}
					object obj21 = customStep_;
					if (obj21 != null && obj21 == null)
					{
						continue;
					}
					num += 2;
					num += num26;
				}
				if (customStepCase_ == CustomStepOneofCase.GiftToCharacter)
				{
					if (customStepCase_ != CustomStepOneofCase.GiftToCharacter)
					{
					}
					object obj22 = customStep_;
					if (obj22 != null && obj22 == null)
					{
						continue;
					}
					num += 2;
					num += num27;
				}
				if (customStepCase_ == CustomStepOneofCase.Interaction)
				{
					if (customStepCase_ != CustomStepOneofCase.Interaction)
					{
					}
					object obj23 = customStep_;
					if (obj23 != null && obj23 == null)
					{
						continue;
					}
					num += 2;
					num += num28;
				}
				if (customStepCase_ == CustomStepOneofCase.Listen)
				{
					if (customStepCase_ != CustomStepOneofCase.Listen)
					{
					}
					object obj24 = customStep_;
					if (obj24 != null && obj24 == null)
					{
						continue;
					}
					num += 2;
					num += num29;
				}
				if (customStepCase_ == CustomStepOneofCase.MakeGarden)
				{
					if (customStepCase_ != CustomStepOneofCase.MakeGarden)
					{
					}
					object obj25 = customStep_;
					if (obj25 != null && obj25 == null)
					{
						continue;
					}
					num += 2;
					num += num30;
				}
				if (customStepCase_ == CustomStepOneofCase.MineMineral)
				{
					if (customStepCase_ != CustomStepOneofCase.MineMineral)
					{
					}
					object obj26 = customStep_;
					if (obj26 != null && obj26 == null)
					{
						continue;
					}
					num += 2;
					num += num31;
				}
				if (customStepCase_ == CustomStepOneofCase.Party)
				{
					if (customStepCase_ != CustomStepOneofCase.Party)
					{
					}
					object obj27 = customStep_;
					if (obj27 != null && obj27 == null)
					{
						continue;
					}
					num += 2;
					num += num32;
				}
				if (customStepCase_ == CustomStepOneofCase.PickUp)
				{
					if (customStepCase_ != CustomStepOneofCase.PickUp)
					{
					}
					object obj28 = customStep_;
					if (obj28 != null && obj28 == null)
					{
						continue;
					}
					num += 2;
					num += num33;
				}
				if (customStepCase_ == CustomStepOneofCase.PlaceBuilding)
				{
					if (customStepCase_ != CustomStepOneofCase.PlaceBuilding)
					{
					}
					object obj29 = customStep_;
					if (obj29 != null && obj29 == null)
					{
						continue;
					}
					num += 2;
					num += num34;
				}
				if (customStepCase_ == CustomStepOneofCase.Possess)
				{
					if (customStepCase_ != CustomStepOneofCase.Possess)
					{
					}
					object obj30 = customStep_;
					if (obj30 != null && obj30 == null)
					{
						continue;
					}
					num += 2;
					num += num35;
				}
				if (customStepCase_ == CustomStepOneofCase.PurchaseItem)
				{
					if (customStepCase_ != CustomStepOneofCase.PurchaseItem)
					{
					}
					object obj31 = customStep_;
					if (obj31 != null && obj31 == null)
					{
						continue;
					}
					num += 2;
					num += num36;
				}
				if (customStepCase_ == CustomStepOneofCase.RemoveBlocker)
				{
					if (customStepCase_ != CustomStepOneofCase.RemoveBlocker)
					{
					}
					object obj32 = customStep_;
					if (obj32 != null && obj32 == null)
					{
						continue;
					}
					num += 2;
					num += num37;
				}
				if (customStepCase_ == CustomStepOneofCase.RoyalDuties)
				{
					if (customStepCase_ != CustomStepOneofCase.RoyalDuties)
					{
					}
					object obj33 = customStep_;
					if (obj33 != null && obj33 == null)
					{
						continue;
					}
					num += 2;
					num += num38;
				}
				if (customStepCase_ == CustomStepOneofCase.SellItem)
				{
					if (customStepCase_ != CustomStepOneofCase.SellItem)
					{
					}
					object obj34 = customStep_;
					if (obj34 != null && obj34 == null)
					{
						continue;
					}
					num += 2;
					num += num39;
				}
				if (customStepCase_ == CustomStepOneofCase.ServeRestaurantOrder)
				{
					if (customStepCase_ != CustomStepOneofCase.ServeRestaurantOrder)
					{
					}
					object obj35 = customStep_;
					if (obj35 != null && obj35 == null)
					{
						continue;
					}
					num += 2;
					num += num40;
				}
				if (customStepCase_ == CustomStepOneofCase.StartDiscussion)
				{
					if (customStepCase_ != CustomStepOneofCase.StartDiscussion)
					{
					}
					object obj36 = customStep_;
					if (obj36 != null && obj36 == null)
					{
						continue;
					}
					num += 2;
					num += num41;
				}
				if (customStepCase_ == CustomStepOneofCase.TakePicture)
				{
					if (customStepCase_ != CustomStepOneofCase.TakePicture)
					{
					}
					object obj37 = customStep_;
					if (obj37 != null && obj37 == null)
					{
						continue;
					}
				}
				if (customStepCase_ == CustomStepOneofCase.TalkToCharacter)
				{
					if (customStepCase_ != CustomStepOneofCase.TalkToCharacter)
					{
					}
					object obj38 = customStep_;
					if (obj38 != null && obj38 == null)
					{
						continue;
					}
					num += 2;
					num += num42;
				}
				if (customStepCase_ == CustomStepOneofCase.Unlock)
				{
					if (customStepCase_ != CustomStepOneofCase.Unlock)
					{
					}
					object obj39 = customStep_;
					if (obj39 != null && obj39 == null)
					{
						continue;
					}
					num += 2;
					num += num43;
				}
				if (customStepCase_ == CustomStepOneofCase.UnlockCharacter)
				{
					if (customStepCase_ != CustomStepOneofCase.UnlockCharacter)
					{
					}
					object obj40 = customStep_;
					if (obj40 != null && obj40 == null)
					{
						continue;
					}
					num += 2;
					num += num44;
				}
				if (customStepCase_ == CustomStepOneofCase.Upgrade)
				{
					if (customStepCase_ != CustomStepOneofCase.Upgrade)
					{
					}
					object obj41 = customStep_;
					if (obj41 != null && obj41 == null)
					{
						continue;
					}
					num += 2;
					num += num45;
				}
				if (customStepCase_ == CustomStepOneofCase.VisitArea)
				{
					if (customStepCase_ != CustomStepOneofCase.VisitArea)
					{
					}
					object obj42 = customStep_;
					if (obj42 != null && obj42 == null)
					{
						continue;
					}
					num += 2;
					num += num46;
				}
				if (customStepCase_ != CustomStepOneofCase.WaterPlant)
				{
					break;
				}
				if (customStepCase_ == CustomStepOneofCase.WaterPlant)
				{
					object obj43 = customStep_;
					if (obj43 != null && obj43 == null)
					{
						continue;
					}
				}
				num += 2;
				num += num47;
				break;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num48 = unknownFields.CalculateSize();
				num += num48;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600407D")]
		[Cpp2IlInjected.Address(RVA = "0x37191A0", Offset = "0x3717BA0", VA = "0x1837191A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionObjectiveData other)
		{
			//Discarded unreachable code: IL_0ce2
			//IL_00e4: Expected I4, but got O
			//IL_0128: Expected I4, but got O
			//IL_016f: Expected I4, but got O
			//IL_01b3: Expected I4, but got O
			//IL_01f7: Expected I4, but got O
			//IL_023e: Expected I4, but got O
			//IL_0290: Expected I4, but got O
			//IL_02d4: Expected I4, but got O
			//IL_031b: Expected I4, but got O
			//IL_035f: Expected I4, but got O
			//IL_03a6: Expected I4, but got O
			//IL_0406: Expected I4, but got O
			//IL_044a: Expected I4, but got O
			//IL_0491: Expected I4, but got O
			//IL_04d5: Expected I4, but got O
			//IL_0519: Expected I4, but got O
			//IL_0560: Expected I4, but got O
			//IL_05b2: Expected I4, but got O
			//IL_05f6: Expected I4, but got O
			//IL_063d: Expected I4, but got O
			//IL_0681: Expected I4, but got O
			//IL_06c8: Expected I4, but got O
			//IL_0736: Expected I4, but got O
			//IL_077a: Expected I4, but got O
			//IL_07c1: Expected I4, but got O
			//IL_0805: Expected I4, but got O
			//IL_0849: Expected I4, but got O
			//IL_0890: Expected I4, but got O
			//IL_08e2: Expected I4, but got O
			//IL_0926: Expected I4, but got O
			//IL_096d: Expected I4, but got O
			//IL_09b1: Expected I4, but got O
			//IL_09f8: Expected I4, but got O
			//IL_0a46: Expected I4, but got O
			//IL_0a8a: Expected I4, but got O
			//IL_0ad1: Expected I4, but got O
			//IL_0b12: Expected I4, but got O
			//IL_0b56: Expected I4, but got O
			//IL_0ba2: Expected I4, but got O
			//IL_0be3: Expected I4, but got O
			//IL_0c27: Expected I4, but got O
			//IL_0c68: Expected I4, but got O
			//IL_0ca9: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.stepDescription_;
			if (text.m_stringLength != 0)
			{
				StepDescription = text;
			}
			int num = other.objectiveID_;
			if (num != 0)
			{
				objectiveID_ = num;
			}
			string text2 = other.stepName_;
			if (text2.m_stringLength != 0)
			{
				StepName = text2;
			}
			bool flag = other.hideProgressionCount_;
			if (flag)
			{
				hideProgressionCount_ = flag;
			}
			bool flag2 = other.hideCharacterFeedback_;
			if (flag2)
			{
				hideCharacterFeedback_ = flag2;
			}
			bool flag3 = other.skipSubStepWhenCompleted_;
			if (flag3)
			{
				skipSubStepWhenCompleted_ = flag3;
			}
			CustomStepOneofCase customStepOneofCase = other.customStepCase_;
			CustomStepInteraction interaction2 = default(CustomStepInteraction);
			if (customStepOneofCase > CustomStepOneofCase.GardeningPlant)
			{
				CustomStepSellItem sellItem2 = default(CustomStepSellItem);
				if (customStepOneofCase > CustomStepOneofCase.RemoveBlocker)
				{
					CustomStepUnlockCharacter unlockCharacter2 = default(CustomStepUnlockCharacter);
					if (customStepOneofCase > CustomStepOneofCase.TakePicture)
					{
						CustomStepWaterPlant waterPlant2 = default(CustomStepWaterPlant);
						if (customStepOneofCase > CustomStepOneofCase.UnlockCharacter)
						{
							CustomStepUpgrade upgrade2 = default(CustomStepUpgrade);
							if (customStepOneofCase == CustomStepOneofCase.Upgrade)
							{
								if (Upgrade == null)
								{
									customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepUpgrade());
								}
								CustomStepUpgrade upgrade = Upgrade;
								upgrade2 = other.Upgrade;
								upgrade.MergeFrom(upgrade2);
							}
							CustomStepVisitArea visitArea2 = default(CustomStepVisitArea);
							if ((long)upgrade2 == 290)
							{
								if (VisitArea == null)
								{
									customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepVisitArea());
								}
								CustomStepVisitArea visitArea = VisitArea;
								visitArea2 = other.VisitArea;
								visitArea.MergeFrom(visitArea2);
							}
							if ((long)visitArea2 != 295)
							{
								goto IL_0cc2;
							}
							if (WaterPlant == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepWaterPlant());
							}
							CustomStepWaterPlant waterPlant = WaterPlant;
							waterPlant2 = other.WaterPlant;
							waterPlant.MergeFrom(waterPlant2);
						}
						CustomStepTalkToCharacter talkToCharacter2 = default(CustomStepTalkToCharacter);
						if ((long)waterPlant2 == 270)
						{
							if (TalkToCharacter == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepTalkToCharacter());
							}
							CustomStepTalkToCharacter talkToCharacter = TalkToCharacter;
							talkToCharacter2 = other.TalkToCharacter;
							talkToCharacter.MergeFrom(talkToCharacter2);
						}
						CustomStepUnlock unlock2 = default(CustomStepUnlock);
						if ((long)talkToCharacter2 == 275)
						{
							if (Unlock == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepUnlock());
							}
							CustomStepUnlock unlock = Unlock;
							unlock2 = other.Unlock;
							unlock.MergeFrom(unlock2);
						}
						if ((long)unlock2 != 280)
						{
							goto IL_0cc2;
						}
						if (UnlockCharacter == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepUnlockCharacter());
						}
						CustomStepUnlockCharacter unlockCharacter = UnlockCharacter;
						unlockCharacter2 = other.UnlockCharacter;
						unlockCharacter.MergeFrom(unlockCharacter2);
					}
					CustomStepTakePicture takePicture2 = default(CustomStepTakePicture);
					if ((long)unlockCharacter2 > 250)
					{
						CustomStepServeRestaurantOrder serveRestaurantOrder2 = default(CustomStepServeRestaurantOrder);
						if ((long)unlockCharacter2 == 255)
						{
							if (ServeRestaurantOrder == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepServeRestaurantOrder());
							}
							CustomStepServeRestaurantOrder serveRestaurantOrder = ServeRestaurantOrder;
							serveRestaurantOrder2 = other.ServeRestaurantOrder;
							serveRestaurantOrder.MergeFrom(serveRestaurantOrder2);
						}
						CustomStepStartDiscussion startDiscussion2 = default(CustomStepStartDiscussion);
						if ((long)serveRestaurantOrder2 == 260)
						{
							if (StartDiscussion == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepStartDiscussion());
							}
							CustomStepStartDiscussion startDiscussion = StartDiscussion;
							startDiscussion2 = other.StartDiscussion;
							startDiscussion.MergeFrom(startDiscussion2);
						}
						if ((long)startDiscussion2 != 265)
						{
							goto IL_0cc2;
						}
						if (TakePicture == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepTakePicture());
						}
						CustomStepTakePicture takePicture = TakePicture;
						takePicture2 = other.TakePicture;
						takePicture.MergeFrom(takePicture2);
					}
					CustomStepRoyalDuties royalDuties2 = default(CustomStepRoyalDuties);
					if ((long)takePicture2 == 245)
					{
						if (RoyalDuties == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepRoyalDuties());
						}
						CustomStepRoyalDuties royalDuties = RoyalDuties;
						royalDuties2 = other.RoyalDuties;
						royalDuties.MergeFrom(royalDuties2);
					}
					if ((long)royalDuties2 != 250)
					{
						goto IL_0cc2;
					}
					if (SellItem == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepSellItem());
					}
					CustomStepSellItem sellItem = SellItem;
					sellItem2 = other.SellItem;
					sellItem.MergeFrom(sellItem2);
				}
				CustomStepPlaceBuilding placeBuilding2 = default(CustomStepPlaceBuilding);
				if ((long)sellItem2 > 210)
				{
					CustomStepRemoveBlocker removeBlocker2 = default(CustomStepRemoveBlocker);
					if ((long)sellItem2 > 225)
					{
						CustomStepPossess possess2 = default(CustomStepPossess);
						if ((long)sellItem2 == 230)
						{
							if (Possess == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepPossess());
							}
							CustomStepPossess possess = Possess;
							possess2 = other.Possess;
							possess.MergeFrom(possess2);
						}
						CustomStepPurchaseItem purchaseItem2 = default(CustomStepPurchaseItem);
						if ((long)possess2 == 235)
						{
							if (PurchaseItem == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepPurchaseItem());
							}
							CustomStepPurchaseItem purchaseItem = PurchaseItem;
							purchaseItem2 = other.PurchaseItem;
							purchaseItem.MergeFrom(purchaseItem2);
						}
						if ((long)purchaseItem2 != 240)
						{
							goto IL_0cc2;
						}
						if (RemoveBlocker == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepRemoveBlocker());
						}
						CustomStepRemoveBlocker removeBlocker = RemoveBlocker;
						removeBlocker2 = other.RemoveBlocker;
						removeBlocker.MergeFrom(removeBlocker2);
					}
					CustomStepParty party2 = default(CustomStepParty);
					if ((long)removeBlocker2 == 215)
					{
						if (Party == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepParty());
						}
						CustomStepParty party = Party;
						party2 = other.Party;
						party.MergeFrom(party2);
					}
					CustomStepPickUp pickUp2 = default(CustomStepPickUp);
					if ((long)party2 == 220)
					{
						if (PickUp == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepPickUp());
						}
						CustomStepPickUp pickUp = PickUp;
						pickUp2 = other.PickUp;
						pickUp.MergeFrom(pickUp2);
					}
					if ((long)pickUp2 != 225)
					{
						goto IL_0cc2;
					}
					if (PlaceBuilding == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepPlaceBuilding());
					}
					CustomStepPlaceBuilding placeBuilding = PlaceBuilding;
					placeBuilding2 = other.PlaceBuilding;
					placeBuilding.MergeFrom(placeBuilding2);
				}
				CustomStepMineMineral mineMineral2 = default(CustomStepMineMineral);
				if ((long)placeBuilding2 > 197)
				{
					CustomStepListen listen2 = default(CustomStepListen);
					if ((long)placeBuilding2 == 200)
					{
						if (Listen == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepListen());
						}
						CustomStepListen listen = Listen;
						listen2 = other.Listen;
						listen.MergeFrom(listen2);
					}
					CustomStepMakeGarden makeGarden2 = default(CustomStepMakeGarden);
					if ((long)listen2 == 205)
					{
						if (MakeGarden == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepMakeGarden());
						}
						CustomStepMakeGarden makeGarden = MakeGarden;
						makeGarden2 = other.MakeGarden;
						makeGarden.MergeFrom(makeGarden2);
					}
					if ((long)makeGarden2 != 210)
					{
						goto IL_0cc2;
					}
					if (MineMineral == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepMineMineral());
					}
					CustomStepMineMineral mineMineral = MineMineral;
					mineMineral2 = other.MineMineral;
					mineMineral.MergeFrom(mineMineral2);
				}
				CustomStepGiftToCharacterItem giftToCharacter2 = default(CustomStepGiftToCharacterItem);
				if ((long)mineMineral2 == 195)
				{
					if (GiftToCharacter == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepGiftToCharacterItem());
					}
					CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
					giftToCharacter2 = other.GiftToCharacter;
					giftToCharacter.MergeFrom(giftToCharacter2);
				}
				if ((long)giftToCharacter2 != 197)
				{
					goto IL_0cc2;
				}
				if (Interaction == null)
				{
					customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepInteraction());
				}
				CustomStepInteraction interaction = Interaction;
				interaction2 = other.Interaction;
				interaction.MergeFrom(interaction2);
			}
			CustomStepDressUp dressUp2 = default(CustomStepDressUp);
			if ((long)interaction2 > 135)
			{
				CustomStepFollowCharacter followCharacter2 = default(CustomStepFollowCharacter);
				if ((long)interaction2 > 160)
				{
					CustomStepGardeningPlant gardeningPlant2 = default(CustomStepGardeningPlant);
					if ((long)interaction2 > 175)
					{
						CustomStepFriend friend2 = default(CustomStepFriend);
						if ((long)interaction2 == 180)
						{
							if (Friend == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepFriend());
							}
							CustomStepFriend friend = Friend;
							friend2 = other.Friend;
							friend.MergeFrom(friend2);
						}
						CustomStepGardeningHarvest gardeningHarvest2 = default(CustomStepGardeningHarvest);
						if ((long)friend2 == 185)
						{
							if (GardeningHarvest == null)
							{
								customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepGardeningHarvest());
							}
							CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
							gardeningHarvest2 = other.GardeningHarvest;
							gardeningHarvest.MergeFrom(gardeningHarvest2);
						}
						if ((long)gardeningHarvest2 != 190)
						{
							goto IL_0cc2;
						}
						if (GardeningPlant == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepGardeningPlant());
						}
						CustomStepGardeningPlant gardeningPlant = GardeningPlant;
						gardeningPlant2 = other.GardeningPlant;
						gardeningPlant.MergeFrom(gardeningPlant2);
					}
					CustomStepFillKeyhole fillKeyhole2 = default(CustomStepFillKeyhole);
					if ((long)gardeningPlant2 == 165)
					{
						if (FillKeyhole == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepFillKeyhole());
						}
						CustomStepFillKeyhole fillKeyhole = FillKeyhole;
						fillKeyhole2 = other.FillKeyhole;
						fillKeyhole.MergeFrom(fillKeyhole2);
					}
					CustomStepFinishHouse finishHouse2 = default(CustomStepFinishHouse);
					if ((long)fillKeyhole2 == 170)
					{
						if (FinishHouse == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepFinishHouse());
						}
						CustomStepFinishHouse finishHouse = FinishHouse;
						finishHouse2 = other.FinishHouse;
						finishHouse.MergeFrom(finishHouse2);
					}
					if ((long)finishHouse2 != 175)
					{
						goto IL_0cc2;
					}
					if (FollowCharacter == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepFollowCharacter());
					}
					CustomStepFollowCharacter followCharacter = FollowCharacter;
					followCharacter2 = other.FollowCharacter;
					followCharacter.MergeFrom(followCharacter2);
				}
				CustomStepFeedCritter feedCritter2 = default(CustomStepFeedCritter);
				if ((long)followCharacter2 > 145)
				{
					CustomStepEatMeal eatMeal2 = default(CustomStepEatMeal);
					if ((long)followCharacter2 == 150)
					{
						if (EatMeal == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepEatMeal());
						}
						CustomStepEatMeal eatMeal = EatMeal;
						eatMeal2 = other.EatMeal;
						eatMeal.MergeFrom(eatMeal2);
					}
					CustomStepExpandHouse expandHouse2 = default(CustomStepExpandHouse);
					if ((long)eatMeal2 == 155)
					{
						if (ExpandHouse == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepExpandHouse());
						}
						CustomStepExpandHouse expandHouse = ExpandHouse;
						expandHouse2 = other.ExpandHouse;
						expandHouse.MergeFrom(expandHouse2);
					}
					if ((long)expandHouse2 != 160)
					{
						goto IL_0cc2;
					}
					if (FeedCritter == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepFeedCritter());
					}
					CustomStepFeedCritter feedCritter = FeedCritter;
					feedCritter2 = other.FeedCritter;
					feedCritter.MergeFrom(feedCritter2);
				}
				CustomStepDesignChallenge designChallenge2 = default(CustomStepDesignChallenge);
				if ((long)feedCritter2 == 140)
				{
					if (DesignChallenge == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepDesignChallenge());
					}
					CustomStepDesignChallenge designChallenge = DesignChallenge;
					designChallenge2 = other.DesignChallenge;
					designChallenge.MergeFrom(designChallenge2);
				}
				if ((long)designChallenge2 != 145)
				{
					goto IL_0cc2;
				}
				if (DressUp == null)
				{
					customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepDressUp());
				}
				CustomStepDressUp dressUp = DressUp;
				dressUp2 = other.DressUp;
			}
			CustomStepConsumeItem consumeItem2 = default(CustomStepConsumeItem);
			if ((long)dressUp2 > 110)
			{
				CustomStepDecorate decorate2 = default(CustomStepDecorate);
				if ((long)dressUp2 > 120)
				{
					CustomStepCookMeal cookMeal2 = default(CustomStepCookMeal);
					if ((long)dressUp2 == 125)
					{
						if (CookMeal == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepCookMeal());
						}
						CustomStepCookMeal cookMeal = CookMeal;
						cookMeal2 = other.CookMeal;
						cookMeal.MergeFrom(cookMeal2);
					}
					CustomStepCraftItem craftItem2 = default(CustomStepCraftItem);
					if ((long)cookMeal2 == 130)
					{
						if (CraftItem == null)
						{
							customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepCraftItem());
						}
						CustomStepCraftItem craftItem = CraftItem;
						craftItem2 = other.CraftItem;
						craftItem.MergeFrom(craftItem2);
					}
					if ((long)craftItem2 != 135)
					{
						goto IL_0cc2;
					}
					if (Decorate == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepDecorate());
					}
					CustomStepDecorate decorate = Decorate;
					decorate2 = other.Decorate;
					decorate.MergeFrom(decorate2);
				}
				CustomStepConditional conditional2 = default(CustomStepConditional);
				if ((long)decorate2 == 115)
				{
					if (Conditional == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepConditional());
					}
					CustomStepConditional conditional = Conditional;
					conditional2 = other.Conditional;
					conditional.MergeFrom(conditional2);
				}
				if ((long)conditional2 != 120)
				{
					goto IL_0cc2;
				}
				if (ConsumeItem == null)
				{
					customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepConsumeItem());
				}
				CustomStepConsumeItem consumeItem = ConsumeItem;
				consumeItem2 = other.ConsumeItem;
				consumeItem.MergeFrom(consumeItem2);
			}
			CustomStepCollectCurrency collectCurrency2 = default(CustomStepCollectCurrency);
			if ((long)consumeItem2 > 103)
			{
				CustomStepCatchFish catchFish2 = default(CustomStepCatchFish);
				if ((long)consumeItem2 == 105)
				{
					if (CatchFish == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepCatchFish());
					}
					CustomStepCatchFish catchFish = CatchFish;
					catchFish2 = other.CatchFish;
					catchFish.MergeFrom(catchFish2);
				}
				CustomStepChase chase2 = default(CustomStepChase);
				if ((long)catchFish2 == 108)
				{
					if (Chase == null)
					{
						customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepChase());
					}
					CustomStepChase chase = Chase;
					chase2 = other.Chase;
					chase.MergeFrom(chase2);
				}
				if ((long)chase2 != 110)
				{
					goto IL_0cc2;
				}
				if (CollectCurrency == null)
				{
					customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepCollectCurrency());
				}
				CustomStepCollectCurrency collectCurrency = CollectCurrency;
				collectCurrency2 = other.CollectCurrency;
				collectCurrency.MergeFrom(collectCurrency2);
			}
			CustomStepBringItem bringItem2 = default(CustomStepBringItem);
			if ((long)collectCurrency2 == 100)
			{
				if (BringItem == null)
				{
					customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepBringItem());
				}
				CustomStepBringItem bringItem = BringItem;
				bringItem2 = other.BringItem;
				bringItem.MergeFrom(bringItem2);
			}
			if ((long)bringItem2 == 103)
			{
				if (Cancel == null)
				{
					customStepCase_ = (CustomStepOneofCase)(customStep_ = new CustomStepCancel());
				}
				CustomStepCancel cancel = Cancel;
				CustomStepCancel cancel2 = other.Cancel;
				cancel.MergeFrom(cancel2);
			}
			goto IL_0cc2;
			IL_0cc2:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600407E")]
		[Cpp2IlInjected.Address(RVA = "0x3716D20", Offset = "0x3715720", VA = "0x183716D20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_009b: Expected I4, but got O
			//IL_00f2: Expected I4, but got O
			//IL_0149: Expected I4, but got O
			//IL_01a5: Expected I4, but got O
			//IL_01fc: Expected I4, but got O
			//IL_0255: Expected I4, but got O
			//IL_02b1: Expected I4, but got O
			//IL_0314: Expected I4, but got O
			//IL_036d: Expected I4, but got O
			//IL_03c9: Expected I4, but got O
			//IL_0422: Expected I4, but got O
			//IL_047b: Expected I4, but got O
			//IL_04d7: Expected I4, but got O
			//IL_0546: Expected I4, but got O
			//IL_059f: Expected I4, but got O
			//IL_05fb: Expected I4, but got O
			//IL_0654: Expected I4, but got O
			//IL_06ad: Expected I4, but got O
			//IL_0709: Expected I4, but got O
			//IL_0770: Expected I4, but got O
			//IL_07c9: Expected I4, but got O
			//IL_0825: Expected I4, but got O
			//IL_087e: Expected I4, but got O
			//IL_08d7: Expected I4, but got O
			//IL_0933: Expected I4, but got O
			//IL_09ae: Expected I4, but got O
			//IL_0a07: Expected I4, but got O
			//IL_0a63: Expected I4, but got O
			//IL_0abc: Expected I4, but got O
			//IL_0b15: Expected I4, but got O
			//IL_0b71: Expected I4, but got O
			//IL_0bd8: Expected I4, but got O
			//IL_0c31: Expected I4, but got O
			//IL_0c8d: Expected I4, but got O
			//IL_0ce0: Expected I4, but got O
			//IL_0d33: Expected I4, but got O
			//IL_0d8f: Expected I4, but got O
			//IL_0dfb: Expected I4, but got O
			//IL_0e4e: Expected I4, but got O
			//IL_0ea4: Expected I4, but got O
			//IL_0ef7: Expected I4, but got O
			//IL_0f4a: Expected I4, but got O
			//IL_0fa0: Expected I4, but got O
			object obj2 = default(object);
			object obj3 = default(object);
			object obj4 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
			object obj7 = default(object);
			object obj8 = default(object);
			object obj9 = default(object);
			object obj10 = default(object);
			object obj11 = default(object);
			object obj12 = default(object);
			object obj13 = default(object);
			object obj14 = default(object);
			object obj15 = default(object);
			object obj16 = default(object);
			object obj17 = default(object);
			object obj18 = default(object);
			object obj19 = default(object);
			object obj20 = default(object);
			object obj21 = default(object);
			object obj22 = default(object);
			object obj23 = default(object);
			object obj24 = default(object);
			object obj25 = default(object);
			object obj26 = default(object);
			object obj27 = default(object);
			object obj28 = default(object);
			object obj29 = default(object);
			object obj30 = default(object);
			object obj31 = default(object);
			object obj32 = default(object);
			object obj33 = default(object);
			object obj34 = default(object);
			object obj35 = default(object);
			object obj36 = default(object);
			object obj37 = default(object);
			object obj38 = default(object);
			object obj39 = default(object);
			object obj40 = default(object);
			object obj41 = default(object);
			object obj42 = default(object);
			object obj43 = default(object);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			string text2 = default(string);
			int num2 = default(int);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					return;
				}
				if ((int)num > 1402)
				{
					if ((int)num > 1842)
					{
						if ((int)num > 2082)
						{
							if ((int)num > 2202)
							{
								if ((int)num > 2282)
								{
									if (num == 2322)
									{
										CustomStepVisitArea customStepVisitArea = new CustomStepVisitArea();
										if (customStepCase_ == CustomStepOneofCase.VisitArea)
										{
											if (customStepCase_ != CustomStepOneofCase.VisitArea)
											{
											}
											object obj = customStep_;
											if (obj != null && obj == null)
											{
												break;
											}
										}
										input.ReadMessage(customStepVisitArea);
										customStep_ = customStepVisitArea;
										customStepCase_ = (CustomStepOneofCase)customStepVisitArea;
									}
									if (num != 2362)
									{
										goto IL_102d;
									}
									CustomStepWaterPlant builder = new CustomStepWaterPlant();
									if (customStepCase_ == CustomStepOneofCase.WaterPlant)
									{
										if (customStepCase_ != CustomStepOneofCase.WaterPlant)
										{
										}
										obj2 = customStep_;
										if (obj2 != null && obj2 == null)
										{
											continue;
										}
									}
									input.ReadMessage(builder);
									customStep_ = builder;
									customStepCase_ = (CustomStepOneofCase)obj2;
								}
								if (num == 2242)
								{
									CustomStepUnlockCharacter builder2 = new CustomStepUnlockCharacter();
									if (customStepCase_ == CustomStepOneofCase.UnlockCharacter)
									{
										if (customStepCase_ != CustomStepOneofCase.UnlockCharacter)
										{
										}
										obj3 = customStep_;
										if (obj3 != null && obj3 == null)
										{
											continue;
										}
									}
									input.ReadMessage(builder2);
									customStep_ = builder2;
									customStepCase_ = (CustomStepOneofCase)obj3;
								}
								if ((long)obj3 != 2282)
								{
									goto IL_102d;
								}
								CustomStepUpgrade builder3 = new CustomStepUpgrade();
								if (customStepCase_ == CustomStepOneofCase.Upgrade)
								{
									if (customStepCase_ != CustomStepOneofCase.Upgrade)
									{
									}
									obj4 = customStep_;
									if (obj4 != null && obj4 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder3);
								customStep_ = builder3;
								customStepCase_ = (CustomStepOneofCase)obj4;
							}
							if (num == 2122)
							{
								CustomStepTakePicture builder4 = new CustomStepTakePicture();
								if (customStepCase_ == CustomStepOneofCase.TakePicture)
								{
									if (customStepCase_ != CustomStepOneofCase.TakePicture)
									{
									}
									obj5 = customStep_;
									if (obj5 != null && obj5 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder4);
								customStep_ = builder4;
								customStepCase_ = (CustomStepOneofCase)obj5;
							}
							if ((long)obj5 == 2162)
							{
								CustomStepTalkToCharacter builder5 = new CustomStepTalkToCharacter();
								if (customStepCase_ == CustomStepOneofCase.TalkToCharacter)
								{
									if (customStepCase_ != CustomStepOneofCase.TalkToCharacter)
									{
									}
									obj6 = customStep_;
									if (obj6 != null && obj6 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder5);
								customStep_ = builder5;
								customStepCase_ = (CustomStepOneofCase)obj6;
							}
							if ((long)obj6 != 2202)
							{
								goto IL_102d;
							}
							CustomStepUnlock builder6 = new CustomStepUnlock();
							if (customStepCase_ == CustomStepOneofCase.Unlock)
							{
								if (customStepCase_ != CustomStepOneofCase.Unlock)
								{
								}
								obj7 = customStep_;
								if (obj7 != null && obj7 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder6);
							customStep_ = builder6;
							customStepCase_ = (CustomStepOneofCase)obj7;
						}
						if ((int)num > 1962)
						{
							if (num == 2002)
							{
								CustomStepSellItem builder7 = new CustomStepSellItem();
								if (customStepCase_ == CustomStepOneofCase.SellItem)
								{
									if (customStepCase_ != CustomStepOneofCase.SellItem)
									{
									}
									obj8 = customStep_;
									if (obj8 != null && obj8 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder7);
								customStep_ = builder7;
								customStepCase_ = (CustomStepOneofCase)obj8;
							}
							if ((long)obj8 == 2042)
							{
								CustomStepServeRestaurantOrder builder8 = new CustomStepServeRestaurantOrder();
								if (customStepCase_ == CustomStepOneofCase.ServeRestaurantOrder)
								{
									if (customStepCase_ != CustomStepOneofCase.ServeRestaurantOrder)
									{
									}
									obj9 = customStep_;
									if (obj9 != null && obj9 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder8);
								customStep_ = builder8;
								customStepCase_ = (CustomStepOneofCase)obj9;
							}
							if ((long)obj9 != 2082)
							{
								goto IL_102d;
							}
							CustomStepStartDiscussion builder9 = new CustomStepStartDiscussion();
							if (customStepCase_ == CustomStepOneofCase.StartDiscussion)
							{
								if (customStepCase_ != CustomStepOneofCase.StartDiscussion)
								{
								}
								obj10 = customStep_;
								if (obj10 != null && obj10 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder9);
							customStep_ = builder9;
							customStepCase_ = (CustomStepOneofCase)obj10;
						}
						if ((long)obj10 == 1882)
						{
							CustomStepPurchaseItem builder10 = new CustomStepPurchaseItem();
							if (customStepCase_ == CustomStepOneofCase.PurchaseItem)
							{
								if (customStepCase_ != CustomStepOneofCase.PurchaseItem)
								{
								}
								obj11 = customStep_;
								if (obj11 != null && obj11 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder10);
							customStep_ = builder10;
							customStepCase_ = (CustomStepOneofCase)obj11;
						}
						if ((long)obj11 == 1922)
						{
							CustomStepRemoveBlocker builder11 = new CustomStepRemoveBlocker();
							if (customStepCase_ == CustomStepOneofCase.RemoveBlocker)
							{
								if (customStepCase_ != CustomStepOneofCase.RemoveBlocker)
								{
								}
								obj12 = customStep_;
								if (obj12 != null && obj12 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder11);
							customStep_ = builder11;
							customStepCase_ = (CustomStepOneofCase)obj12;
						}
						if ((long)obj12 != 1962)
						{
							goto IL_102d;
						}
						CustomStepRoyalDuties builder12 = new CustomStepRoyalDuties();
						if (customStepCase_ == CustomStepOneofCase.RoyalDuties)
						{
							if (customStepCase_ != CustomStepOneofCase.RoyalDuties)
							{
							}
							obj13 = customStep_;
							if (obj13 != null && obj13 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder12);
						customStep_ = builder12;
						customStepCase_ = (CustomStepOneofCase)obj13;
					}
					if ((int)num > 1602)
					{
						if ((int)num > 1722)
						{
							if (num == 1762)
							{
								CustomStepPickUp builder13 = new CustomStepPickUp();
								if (customStepCase_ == CustomStepOneofCase.PickUp)
								{
									if (customStepCase_ != CustomStepOneofCase.PickUp)
									{
									}
									obj14 = customStep_;
									if (obj14 != null && obj14 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder13);
								customStep_ = builder13;
								customStepCase_ = (CustomStepOneofCase)obj14;
							}
							if ((long)obj14 == 1802)
							{
								CustomStepPlaceBuilding builder14 = new CustomStepPlaceBuilding();
								if (customStepCase_ == CustomStepOneofCase.PlaceBuilding)
								{
									if (customStepCase_ != CustomStepOneofCase.PlaceBuilding)
									{
									}
									obj15 = customStep_;
									if (obj15 != null && obj15 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder14);
								customStep_ = builder14;
								customStepCase_ = (CustomStepOneofCase)obj15;
							}
							if ((long)obj15 != 1842)
							{
								goto IL_102d;
							}
							CustomStepPossess builder15 = new CustomStepPossess();
							if (customStepCase_ == CustomStepOneofCase.Possess)
							{
								if (customStepCase_ != CustomStepOneofCase.Possess)
								{
								}
								obj16 = customStep_;
								if (obj16 != null && obj16 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder15);
							customStep_ = builder15;
							customStepCase_ = (CustomStepOneofCase)obj16;
						}
						if ((long)obj16 == 1642)
						{
							CustomStepMakeGarden builder16 = new CustomStepMakeGarden();
							if (customStepCase_ == CustomStepOneofCase.MakeGarden)
							{
								if (customStepCase_ != CustomStepOneofCase.MakeGarden)
								{
								}
								obj17 = customStep_;
								if (obj17 != null && obj17 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder16);
							customStep_ = builder16;
							customStepCase_ = (CustomStepOneofCase)obj17;
						}
						if ((long)obj17 == 1682)
						{
							CustomStepMineMineral builder17 = new CustomStepMineMineral();
							if (customStepCase_ == CustomStepOneofCase.MineMineral)
							{
								if (customStepCase_ != CustomStepOneofCase.MineMineral)
								{
								}
								obj18 = customStep_;
								if (obj18 != null && obj18 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder17);
							customStep_ = builder17;
							customStepCase_ = (CustomStepOneofCase)obj18;
						}
						if ((long)obj18 != 1722)
						{
							goto IL_102d;
						}
						CustomStepParty builder18 = new CustomStepParty();
						if (customStepCase_ == CustomStepOneofCase.Party)
						{
							if (customStepCase_ != CustomStepOneofCase.Party)
							{
							}
							obj19 = customStep_;
							if (obj19 != null && obj19 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder18);
						customStep_ = builder18;
						customStepCase_ = (CustomStepOneofCase)obj19;
					}
					if ((long)obj19 > 1522)
					{
						if ((long)obj19 == 1562)
						{
							CustomStepGiftToCharacterItem builder19 = new CustomStepGiftToCharacterItem();
							if (customStepCase_ == CustomStepOneofCase.GiftToCharacter)
							{
								if (customStepCase_ != CustomStepOneofCase.GiftToCharacter)
								{
								}
								obj20 = customStep_;
								if (obj20 != null && obj20 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder19);
							customStep_ = builder19;
							customStepCase_ = (CustomStepOneofCase)obj20;
						}
						if ((long)obj20 == 1578)
						{
							CustomStepInteraction builder20 = new CustomStepInteraction();
							if (customStepCase_ == CustomStepOneofCase.Interaction)
							{
								if (customStepCase_ != CustomStepOneofCase.Interaction)
								{
								}
								obj21 = customStep_;
								if (obj21 != null && obj21 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder20);
							customStep_ = builder20;
							customStepCase_ = (CustomStepOneofCase)obj21;
						}
						if ((long)obj21 != 1602)
						{
							goto IL_102d;
						}
						CustomStepListen builder21 = new CustomStepListen();
						if (customStepCase_ == CustomStepOneofCase.Listen)
						{
							if (customStepCase_ != CustomStepOneofCase.Listen)
							{
							}
							obj22 = customStep_;
							if (obj22 != null && obj22 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder21);
						customStep_ = builder21;
						customStepCase_ = (CustomStepOneofCase)obj22;
					}
					if ((long)obj22 == 1442)
					{
						CustomStepFriend builder22 = new CustomStepFriend();
						if (customStepCase_ == CustomStepOneofCase.Friend)
						{
							if (customStepCase_ != CustomStepOneofCase.Friend)
							{
							}
							obj23 = customStep_;
							if (obj23 != null && obj23 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder22);
						customStep_ = builder22;
						customStepCase_ = (CustomStepOneofCase)obj23;
					}
					if ((long)obj23 == 1482)
					{
						CustomStepGardeningHarvest builder23 = new CustomStepGardeningHarvest();
						if (customStepCase_ == CustomStepOneofCase.GardeningHarvest)
						{
							if (customStepCase_ != CustomStepOneofCase.GardeningHarvest)
							{
							}
							obj24 = customStep_;
							if (obj24 != null && obj24 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder23);
						customStep_ = builder23;
						customStepCase_ = (CustomStepOneofCase)obj24;
					}
					if ((long)obj24 != 1522)
					{
						goto IL_102d;
					}
					CustomStepGardeningPlant builder24 = new CustomStepGardeningPlant();
					if (customStepCase_ == CustomStepOneofCase.GardeningPlant)
					{
						if (customStepCase_ != CustomStepOneofCase.GardeningPlant)
						{
						}
						obj25 = customStep_;
						if (obj25 != null && obj25 == null)
						{
							continue;
						}
					}
					input.ReadMessage(builder24);
					customStep_ = builder24;
					customStepCase_ = (CustomStepOneofCase)obj25;
				}
				if ((int)num > 922)
				{
					if ((int)num > 1162)
					{
						if ((int)num > 1282)
						{
							if (num == 1322)
							{
								CustomStepFillKeyhole builder25 = new CustomStepFillKeyhole();
								if (customStepCase_ == CustomStepOneofCase.FillKeyhole)
								{
									if (customStepCase_ != CustomStepOneofCase.FillKeyhole)
									{
									}
									obj26 = customStep_;
									if (obj26 != null && obj26 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder25);
								customStep_ = builder25;
								customStepCase_ = (CustomStepOneofCase)obj26;
							}
							if ((long)obj26 == 1362)
							{
								CustomStepFinishHouse builder26 = new CustomStepFinishHouse();
								if (customStepCase_ == CustomStepOneofCase.FinishHouse)
								{
									if (customStepCase_ != CustomStepOneofCase.FinishHouse)
									{
									}
									obj27 = customStep_;
									if (obj27 != null && obj27 == null)
									{
										continue;
									}
								}
								input.ReadMessage(builder26);
								customStep_ = builder26;
								customStepCase_ = (CustomStepOneofCase)obj27;
							}
							if ((long)obj27 != 1402)
							{
								goto IL_102d;
							}
							CustomStepFollowCharacter builder27 = new CustomStepFollowCharacter();
							if (customStepCase_ == CustomStepOneofCase.FollowCharacter)
							{
								if (customStepCase_ != CustomStepOneofCase.FollowCharacter)
								{
								}
								obj28 = customStep_;
								if (obj28 != null && obj28 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder27);
							customStep_ = builder27;
							customStepCase_ = (CustomStepOneofCase)obj28;
						}
						if ((long)obj28 == 1202)
						{
							CustomStepEatMeal builder28 = new CustomStepEatMeal();
							if (customStepCase_ == CustomStepOneofCase.EatMeal)
							{
								if (customStepCase_ != CustomStepOneofCase.EatMeal)
								{
								}
								obj29 = customStep_;
								if (obj29 != null && obj29 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder28);
							customStep_ = builder28;
							customStepCase_ = (CustomStepOneofCase)obj29;
						}
						if ((long)obj29 == 1242)
						{
							CustomStepExpandHouse builder29 = new CustomStepExpandHouse();
							if (customStepCase_ == CustomStepOneofCase.ExpandHouse)
							{
								if (customStepCase_ != CustomStepOneofCase.ExpandHouse)
								{
								}
								obj30 = customStep_;
								if (obj30 != null && obj30 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder29);
							customStep_ = builder29;
							customStepCase_ = (CustomStepOneofCase)obj30;
						}
						if ((long)obj30 != 1282)
						{
							goto IL_102d;
						}
						CustomStepFeedCritter builder30 = new CustomStepFeedCritter();
						if (customStepCase_ == CustomStepOneofCase.FeedCritter)
						{
							if (customStepCase_ != CustomStepOneofCase.FeedCritter)
							{
							}
							obj31 = customStep_;
							if (obj31 != null && obj31 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder30);
						customStep_ = builder30;
						customStepCase_ = (CustomStepOneofCase)obj31;
					}
					if ((long)obj31 > 1042)
					{
						if ((long)obj31 == 1082)
						{
							CustomStepDecorate builder31 = new CustomStepDecorate();
							if (customStepCase_ == CustomStepOneofCase.Decorate)
							{
								if (customStepCase_ != CustomStepOneofCase.Decorate)
								{
								}
								obj32 = customStep_;
								if (obj32 != null && obj32 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder31);
							customStep_ = builder31;
							customStepCase_ = (CustomStepOneofCase)obj32;
						}
						if ((long)obj32 == 1122)
						{
							CustomStepDesignChallenge builder32 = new CustomStepDesignChallenge();
							if (customStepCase_ == CustomStepOneofCase.DesignChallenge)
							{
								if (customStepCase_ != CustomStepOneofCase.DesignChallenge)
								{
								}
								obj33 = customStep_;
								if (obj33 != null && obj33 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder32);
							customStep_ = builder32;
							customStepCase_ = (CustomStepOneofCase)obj33;
						}
						if ((long)obj33 != 1162)
						{
							goto IL_102d;
						}
						CustomStepDressUp builder33 = new CustomStepDressUp();
						if (customStepCase_ == CustomStepOneofCase.DressUp)
						{
							if (customStepCase_ != CustomStepOneofCase.DressUp)
							{
							}
							obj34 = customStep_;
							if (obj34 != null && obj34 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder33);
						customStep_ = builder33;
						customStepCase_ = (CustomStepOneofCase)obj34;
					}
					if ((long)obj34 == 962)
					{
						CustomStepConsumeItem builder34 = new CustomStepConsumeItem();
						if (customStepCase_ == CustomStepOneofCase.ConsumeItem)
						{
							if (customStepCase_ != CustomStepOneofCase.ConsumeItem)
							{
							}
							obj35 = customStep_;
							if (obj35 != null && obj35 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder34);
						customStep_ = builder34;
						customStepCase_ = (CustomStepOneofCase)obj35;
					}
					if ((long)obj35 == 1002)
					{
						CustomStepCookMeal builder35 = new CustomStepCookMeal();
						if (customStepCase_ == CustomStepOneofCase.CookMeal)
						{
							if (customStepCase_ != CustomStepOneofCase.CookMeal)
							{
							}
							obj36 = customStep_;
							if (obj36 != null && obj36 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder35);
						customStep_ = builder35;
						customStepCase_ = (CustomStepOneofCase)obj36;
					}
					if ((long)obj36 != 1042)
					{
						goto IL_102d;
					}
					CustomStepCraftItem builder36 = new CustomStepCraftItem();
					if (customStepCase_ == CustomStepOneofCase.CraftItem)
					{
						if (customStepCase_ != CustomStepOneofCase.CraftItem)
						{
						}
						obj37 = customStep_;
						if (obj37 != null && obj37 == null)
						{
							continue;
						}
					}
					input.ReadMessage(builder36);
					customStep_ = builder36;
					customStepCase_ = (CustomStepOneofCase)obj37;
				}
				if ((long)obj37 > 96)
				{
					if ((long)obj37 > 842)
					{
						if ((long)obj37 == 866)
						{
							CustomStepChase builder37 = new CustomStepChase();
							if (customStepCase_ == CustomStepOneofCase.Chase)
							{
								if (customStepCase_ != CustomStepOneofCase.Chase)
								{
								}
								obj38 = customStep_;
								if (obj38 != null && obj38 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder37);
							customStep_ = builder37;
							customStepCase_ = (CustomStepOneofCase)obj38;
						}
						if ((long)obj38 == 882)
						{
							CustomStepCollectCurrency builder38 = new CustomStepCollectCurrency();
							if (customStepCase_ == CustomStepOneofCase.CollectCurrency)
							{
								if (customStepCase_ != CustomStepOneofCase.CollectCurrency)
								{
								}
								obj39 = customStep_;
								if (obj39 != null && obj39 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder38);
							customStep_ = builder38;
							customStepCase_ = (CustomStepOneofCase)obj39;
						}
						if ((long)obj39 != 922)
						{
							goto IL_102d;
						}
						CustomStepConditional builder39 = new CustomStepConditional();
						if (customStepCase_ == CustomStepOneofCase.Conditional)
						{
							if (customStepCase_ != CustomStepOneofCase.Conditional)
							{
							}
							obj40 = customStep_;
							if (obj40 != null && obj40 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder39);
						customStep_ = builder39;
						customStepCase_ = (CustomStepOneofCase)obj40;
					}
					if ((long)obj40 == 802)
					{
						CustomStepBringItem builder40 = new CustomStepBringItem();
						if (customStepCase_ == CustomStepOneofCase.BringItem)
						{
							if (customStepCase_ != CustomStepOneofCase.BringItem)
							{
							}
							obj41 = customStep_;
							if (obj41 != null && obj41 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder40);
						customStep_ = builder40;
						customStepCase_ = (CustomStepOneofCase)obj41;
					}
					if ((long)obj41 == 826)
					{
						CustomStepCancel builder41 = new CustomStepCancel();
						if (customStepCase_ == CustomStepOneofCase.Cancel)
						{
							if (customStepCase_ != CustomStepOneofCase.Cancel)
							{
							}
							obj42 = customStep_;
							if (obj42 != null && obj42 == null)
							{
								continue;
							}
						}
						input.ReadMessage(builder41);
						customStep_ = builder41;
						customStepCase_ = (CustomStepOneofCase)obj42;
					}
					if ((long)obj42 != 842)
					{
						goto IL_102d;
					}
					CustomStepCatchFish builder42 = new CustomStepCatchFish();
					if (customStepCase_ == CustomStepOneofCase.CatchFish)
					{
						if (customStepCase_ != CustomStepOneofCase.CatchFish)
						{
						}
						obj43 = customStep_;
						if (obj43 != null && obj43 == null)
						{
							continue;
						}
					}
					input.ReadMessage(builder42);
					customStep_ = builder42;
					customStepCase_ = (CustomStepOneofCase)obj43;
				}
				if ((long)obj43 > 74)
				{
					if ((long)obj43 == 80)
					{
						flag = (hideProgressionCount_ = input.ReadBool());
					}
					if (flag)
					{
						flag2 = (hideCharacterFeedback_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_102d;
					}
					flag3 = (skipSubStepWhenCompleted_ = input.ReadBool());
				}
				if (flag3)
				{
					text2 = (StepDescription = input.ReadString());
				}
				if ((long)text2 == 64)
				{
					num2 = (objectiveID_ = input.ReadInt32());
				}
				if (num2 == 74)
				{
					string text4 = (StepName = input.ReadString());
				}
				goto IL_102d;
				IL_102d:
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600407F")]
		[Cpp2IlInjected.Address(RVA = "0x37147D0", Offset = "0x37131D0", VA = "0x1837147D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 185)
			{
				if (fieldNumber > 235)
				{
					if (fieldNumber > 265)
					{
						if (fieldNumber > 280)
						{
							if (fieldNumber == 285)
							{
								CustomStepUpgrade upgrade = Upgrade;
							}
							if (fieldNumber == 290)
							{
								CustomStepVisitArea visitArea = VisitArea;
							}
							CustomStepWaterPlant waterPlant = WaterPlant;
						}
						if (fieldNumber == 270)
						{
							CustomStepTalkToCharacter talkToCharacter = TalkToCharacter;
						}
						CustomStepUnlock unlock = Unlock;
						CustomStepUnlockCharacter unlockCharacter = UnlockCharacter;
					}
					if (fieldNumber > 250)
					{
						if (fieldNumber == 255)
						{
							CustomStepServeRestaurantOrder serveRestaurantOrder = ServeRestaurantOrder;
						}
						CustomStepStartDiscussion startDiscussion = StartDiscussion;
						CustomStepTakePicture takePicture = TakePicture;
					}
					CustomStepRemoveBlocker removeBlocker = RemoveBlocker;
					CustomStepRoyalDuties royalDuties = RoyalDuties;
					CustomStepSellItem sellItem = SellItem;
				}
				if (fieldNumber > 205)
				{
					if (fieldNumber > 220)
					{
						if (fieldNumber == 225)
						{
							CustomStepPlaceBuilding placeBuilding = PlaceBuilding;
						}
						CustomStepPossess possess = Possess;
						CustomStepPurchaseItem purchaseItem = PurchaseItem;
					}
					CustomStepMineMineral mineMineral = MineMineral;
					CustomStepParty party = Party;
					CustomStepPickUp pickUp = PickUp;
				}
				CustomStepInteraction interaction = Interaction;
				CustomStepListen listen = Listen;
				CustomStepMakeGarden makeGarden = MakeGarden;
				CustomStepGardeningPlant gardeningPlant = GardeningPlant;
				CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
			}
			if (fieldNumber > 130)
			{
				if (fieldNumber > 155)
				{
					if (fieldNumber > 170)
					{
						if (fieldNumber == 175)
						{
							CustomStepFollowCharacter followCharacter = FollowCharacter;
						}
						CustomStepFriend friend = Friend;
						CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
					}
					CustomStepFeedCritter feedCritter = FeedCritter;
					CustomStepFillKeyhole fillKeyhole = FillKeyhole;
					CustomStepFinishHouse finishHouse = FinishHouse;
				}
				CustomStepDressUp dressUp = DressUp;
				CustomStepEatMeal eatMeal = EatMeal;
				CustomStepExpandHouse expandHouse = ExpandHouse;
				CustomStepDecorate decorate = Decorate;
				CustomStepDesignChallenge designChallenge = DesignChallenge;
			}
			CustomStepConsumeItem consumeItem = ConsumeItem;
			CustomStepCookMeal cookMeal = CookMeal;
			CustomStepCraftItem craftItem = CraftItem;
			CustomStepChase chase = Chase;
			CustomStepCollectCurrency collectCurrency = CollectCurrency;
			CustomStepConditional conditional = Conditional;
			CustomStepBringItem bringItem = BringItem;
			CustomStepCancel cancel = Cancel;
			CustomStepCatchFish catchFish = CatchFish;
			string text = stepDescription_;
			bool flag = skipSubStepWhenCompleted_;
			bool flag2 = hideCharacterFeedback_;
			bool flag3 = hideProgressionCount_;
			string text2 = stepName_;
			int num = objectiveID_;
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004080")]
		[Cpp2IlInjected.Address(RVA = "0x371AA50", Offset = "0x3719450", VA = "0x18371AA50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_00c3, IL_00c7, IL_00ce, IL_0117, IL_011b, IL_0122, IL_013d, IL_0141, IL_0148, IL_0150, IL_0154, IL_015b, IL_01af, IL_01b3, IL_01ba, IL_01d5, IL_01d9, IL_01e0, IL_01e8, IL_01ec, IL_01f3, IL_020e, IL_0212, IL_0219, IL_0221, IL_0225, IL_022c, IL_0234, IL_0238, IL_023f, IL_0247, IL_024b, IL_0252, IL_02b1, IL_02b5, IL_02bc, IL_02d7, IL_02db, IL_02e2, IL_02ea, IL_02ee, IL_02f5, IL_0310, IL_0314, IL_031b, IL_0323, IL_0327, IL_032e, IL_0336, IL_033a, IL_0341, IL_0349, IL_034d, IL_0354, IL_036f, IL_0373, IL_037a, IL_0382, IL_0386, IL_038d, IL_0395, IL_0399, IL_03a0, IL_03a8, IL_03ac, IL_03b3, IL_03bb, IL_03bf, IL_03c6, IL_03ce, IL_03d2, IL_03d9, IL_03e1, IL_03e5, IL_03ec, IL_03f4, IL_03f8, IL_03ff, IL_0407, IL_040b, IL_0412, IL_0413, IL_0417, IL_041b, IL_041f, IL_0423, IL_0424, IL_0425, IL_0426, IL_042a, IL_0431, IL_0432, IL_0433, IL_0457, IL_0469, IL_0475, IL_047b, IL_048d, IL_0499, IL_049f, IL_04ab, IL_04b1, IL_04b7, IL_04bd, IL_04cf, IL_04db, IL_04e1, IL_04ed, IL_04f3, IL_04f9, IL_04ff, IL_050b, IL_0511, IL_0517, IL_051d, IL_0523, IL_0529, IL_052f, IL_0535, IL_053b, IL_0541
			//IL_0045: Expected O, but got I4
			//IL_0050: Expected I4, but got O
			//IL_0076: Expected I4, but got O
			//IL_00af: Expected I4, but got O
			//IL_0103: Expected I4, but got O
			//IL_019b: Expected I4, but got O
			//IL_029d: Expected I4, but got O
			if (fieldNumber > 185)
			{
				if (fieldNumber > 235)
				{
					if (fieldNumber > 265)
					{
						if (fieldNumber > 280)
						{
							switch (fieldNumber)
							{
							case 285:
							{
								int num = 0;
								if (value == null || value != null)
								{
									customStep_ = num;
									customStepCase_ = (CustomStepOneofCase)typeof(string).TypeHandle;
									break;
								}
								throw new InvalidCastException();
							}
							case 290:
								if (value == null || value != null)
								{
									customStep_ = value;
									customStepCase_ = (CustomStepOneofCase)typeof(string).TypeHandle;
									break;
								}
								throw new InvalidCastException();
							default:
								if (value == null || value != null)
								{
									customStep_ = value;
									break;
								}
								throw new InvalidCastException();
							}
						}
						else if (fieldNumber == 270)
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
							customStepCase_ = (CustomStepOneofCase)typeof(string).TypeHandle;
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
						}
					}
					else if (fieldNumber > 250)
					{
						if (fieldNumber == 255)
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
							customStepCase_ = (CustomStepOneofCase)typeof(string).TypeHandle;
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
						}
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						customStep_ = value;
					}
				}
				else if (fieldNumber > 205)
				{
					if (fieldNumber > 220)
					{
						if (fieldNumber == 225)
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
							customStepCase_ = (CustomStepOneofCase)typeof(string).TypeHandle;
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
						}
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						customStep_ = value;
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					customStep_ = value;
				}
			}
			else if (fieldNumber > 130)
			{
				if (fieldNumber > 155)
				{
					if (fieldNumber > 170)
					{
						if (fieldNumber == 175)
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
							customStepCase_ = (CustomStepOneofCase)typeof(string).TypeHandle;
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							customStep_ = value;
						}
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						customStep_ = value;
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					customStep_ = value;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				customStep_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004081")]
		[Cpp2IlInjected.Address(RVA = "0x3713AC0", Offset = "0x37124C0", VA = "0x183713AC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0184: Expected O, but got I4
			if ((fieldNumber <= 185 || ((fieldNumber <= 235 || ((fieldNumber <= 265 || ((fieldNumber <= 280 || (fieldNumber != 285 && fieldNumber != 290)) && fieldNumber != 270 && fieldNumber != 275)) && (fieldNumber <= 250 || (fieldNumber != 255 && fieldNumber != 260)) && fieldNumber != 240 && fieldNumber != 245)) && (fieldNumber <= 205 || ((fieldNumber <= 220 || (fieldNumber != 225 && fieldNumber != 230)) && fieldNumber != 210 && fieldNumber != 215)) && (fieldNumber <= 195 || (fieldNumber != 197 && fieldNumber != 200)) && fieldNumber != 190)) && (fieldNumber <= 130 || ((fieldNumber <= 155 || ((fieldNumber <= 170 || (fieldNumber != 175 && fieldNumber != 180)) && fieldNumber != 160 && fieldNumber != 165)) && (fieldNumber <= 140 || (fieldNumber != 145 && fieldNumber != 150)) && fieldNumber != 135)) && (fieldNumber <= 105 || ((fieldNumber <= 115 || (fieldNumber != 120 && fieldNumber != 125)) && fieldNumber != 108 && fieldNumber != 110)))
			{
				if (fieldNumber <= 12)
				{
					if (fieldNumber == 1)
					{
						StepDescription = "";
					}
					else if (fieldNumber != 1)
					{
						if (fieldNumber != 1)
						{
							if (fieldNumber != 1)
							{
								if (fieldNumber != 1)
								{
									if (fieldNumber == 1)
									{
										skipSubStepWhenCompleted_ = false;
									}
								}
								else
								{
									hideCharacterFeedback_ = false;
								}
							}
							else
							{
								hideProgressionCount_ = false;
							}
						}
						else
						{
							StepName = "";
						}
					}
					else
					{
						int num = (objectiveID_ = 0);
					}
					return;
				}
				if (fieldNumber != 100 && fieldNumber != 103 && fieldNumber != 105)
				{
					return;
				}
			}
			int num2 = 0;
			customStep_ = num2;
			customStepCase_ = (CustomStepOneofCase)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004082")]
		[Cpp2IlInjected.Address(RVA = "0x3716480", Offset = "0x3714E80", VA = "0x183716480", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "CustomStep"))
			{
				CustomStepOneofCase customStepOneofCase = customStepCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004083")]
		[Cpp2IlInjected.Address(RVA = "0x3713DC0", Offset = "0x37127C0", VA = "0x183713DC0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "CustomStep"))
			{
				customStep_ = (customStepCase_ = CustomStepOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600408F")]
		[Cpp2IlInjected.Address(RVA = "0x371C090", Offset = "0x371AA90", VA = "0x18371C090")]
		public bool TryGetITargetCharacterDialog(out string dialog)
		{
			int num = 0;
			if ((object)typeof(ICharacterDialog).TypeHandle != null)
			{
				num += num;
				num++;
			}
			return (object)typeof(ICharacterDialog).TypeHandle == null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004090")]
		[Cpp2IlInjected.Address(RVA = "0x371BED0", Offset = "0x371A8D0", VA = "0x18371BED0")]
		public unsafe bool TryGetITargetCharacterDialog(MissionStepStatus status, out string dialog)
		{
			int num = 0;
			if ((object)typeof(ICharacterDialog).TypeHandle != null && (long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dialog))
			{
				num += num;
				if ((object)"{il2cpp array field il2cppMethodInfo->}" != (object)typeof(ICharacterDialog).TypeHandle)
				{
					num++;
				}
			}
			if (num == 0 && num != 0)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += num;
				num += 344;
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004091")]
		[Cpp2IlInjected.Address(RVA = "0x3716C90", Offset = "0x3715690", VA = "0x183716C90")]
		public bool IsOverAfterCharacterDialog(MissionStepStatus status)
		{
			bool flag = default(bool);
			if (flag && flag)
			{
				return flag;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004098")]
		[Cpp2IlInjected.Address(RVA = "0x3716640", Offset = "0x3715040", VA = "0x183716640")]
		public List<string> GetVariableList(MissionVariable.VariableOneofCase type)
		{
			//Discarded unreachable code: IL_00e7, IL_00ed, IL_00f3, IL_00f9, IL_00ff, IL_0105, IL_0111, IL_0117, IL_011d
			//IL_004e: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			string item = default(string);
			bool flag = default(bool);
			string text = default(string);
			string text2 = default(string);
			uint num3 = default(uint);
			string text3 = default(string);
			while (true)
			{
				int num = 0;
				List<string> list = (List<string>)(object)new List<T>();
				if (type == MissionVariable.VariableOneofCase.ItemFilter)
				{
					if ((object)typeof(IItemSelector).TypeHandle != null)
					{
						((List<T>)(object)list).Add((T)item);
					}
					if ((object)typeof(IItemSelectorsWithAmount).TypeHandle != null)
					{
						if ((object)typeof(IItemSelector).TypeHandle != null)
						{
							if ((long)num < (long)(IntPtr)typeof(IItemSelector).TypeHandle)
							{
								num += num;
								num++;
							}
							int num2 = 0;
							if (!flag)
							{
								text = GetItemFilterVariableName((ItemSelector)num2, num);
								((List<T>)(object)list).Add((T)text);
							}
							num++;
							text += text;
						}
						num++;
						if (num != 0)
						{
							break;
						}
						if (num == 0)
						{
							goto IL_0078;
						}
					}
					return list;
				}
				while (type != MissionVariable.VariableOneofCase.TargetAmount)
				{
				}
				goto IL_0078;
				IL_0078:
				if ((object)typeof(IStepAmount).TypeHandle != null && (object)typeof(IStepAmount).TypeHandle != null)
				{
					((List<T>)(object)list).Add((T)text2);
				}
				while ((object)typeof(IItemSelectorsWithAmount).TypeHandle == null)
				{
				}
				if (text2 != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_00ce;
						}
						num++;
					}
					int num4 = 0;
					if (text2 == null)
					{
						text3 = GetStepAmountVariableName((StepAmount)num4, num);
						((List<T>)(object)list).Add((T)text3);
					}
					num++;
					goto IL_00ce;
				}
				goto IL_00d5;
				IL_00d5:
				if (text2 != null)
				{
				}
				if (num == 0)
				{
					throw new NullReferenceException();
				}
				continue;
				IL_00ce:
				text3 += text3;
				goto IL_00d5;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004099")]
		[Cpp2IlInjected.Address(RVA = "0x3716320", Offset = "0x3714D20", VA = "0x183716320")]
		public string GetItemFilterVariableName(ItemSelector itemSelector, int idx = -1)
		{
			if (itemSelector == null)
			{
				return string.Empty;
			}
			string variableName_ = default(string);
			if (itemSelector.useCustomVariableName_)
			{
				variableName_ = itemSelector.variableName_;
				if (".ItemFilter" == null)
				{
					string variableName_2 = itemSelector.variableName_;
				}
			}
			string text = variableName_ + ".ItemFilter";
			if (!itemSelector.useCustomVariableName_)
			{
				return $"{text}[{text}]";
			}
			return text;
		}

		[Cpp2IlInjected.Token(Token = "0x600409A")]
		[Cpp2IlInjected.Address(RVA = "0x3716530", Offset = "0x3714F30", VA = "0x183716530")]
		public string GetStepAmountVariableName(StepAmount stepAmount, int idx = -1)
		{
			if (stepAmount == null)
			{
				return string.Empty;
			}
			string variableName_ = default(string);
			if (stepAmount.useCustomVariableName_)
			{
				variableName_ = stepAmount.variableName_;
				if (".Amount" == null)
				{
					string variableName_2 = stepAmount.variableName_;
				}
			}
			string text = variableName_ + ".Amount";
			if (!stepAmount.useCustomVariableName_)
			{
				return $"{text}[{text}]";
			}
			return text;
		}

		[Cpp2IlInjected.Token(Token = "0x600409B")]
		[Cpp2IlInjected.Address(RVA = "0x3716430", Offset = "0x3714E30", VA = "0x183716430", Slot = "19")]
		public (ItemType, ActivityItemType?) GetItemGeneratorParameters()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600409C")]
		[Cpp2IlInjected.Address(RVA = "0x371C170", Offset = "0x371AB70", VA = "0x18371C170")]
		public unsafe bool TryGetToolTips(out string tooltip)
		{
			//Discarded unreachable code: IL_0030
			//IL_0030: Expected I4, but got O
			int num = 0;
			CustomOptions customOptions = default(CustomOptions);
			CustomOptions customOptions2 = default(CustomOptions);
			if ((object)typeof(IMessage).TypeHandle == null || (object)typeof(IMessage).TypeHandle == null || customOptions == null || !customOptions2.TryGetMessage<AllMessageOptions, EditorStyleOverride>(AllMessageOptions.MessageEditorStyleOverride, out *(EditorStyleOverride*)num) || num != 0)
			{
			}
			return (byte)(int)typeof(IMessage).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600409D")]
		[Cpp2IlInjected.Address(RVA = "0x3713E90", Offset = "0x3712890", VA = "0x183713E90", Slot = "20")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0029
			if (customStepCase_ == CustomStepOneofCase.None)
			{
				string text = stepName_;
				string error = "CustomStepCase of " + text + " is <None>. Maybe using deleted CustomStep or it's an Editor error";
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600409E")]
		[Cpp2IlInjected.Address(RVA = "0x371D910", Offset = "0x371C310", VA = "0x18371D910")]
		static MissionObjectiveData()
		{
			Func<MissionObjectiveData> func = default(Func<MissionObjectiveData>);
			_parser = (MessageParser<MissionObjectiveData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
