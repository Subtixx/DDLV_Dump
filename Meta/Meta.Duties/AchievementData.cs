using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Localization.Core;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Customization;
using Meta.Grids;
using Meta.Missions;
using Meta.Util;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010AB")]
	public sealed class AchievementData : IMessage<AchievementData>, IMessage, IEquatable<AchievementData>, IDeepCloneable<AchievementData>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20010AC")]
		public enum OptionalStateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40044C0")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40044C1")]
			GridObjectsCollected = 10
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40044A2")]
		private ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40044A3")]
		private Profile Profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40044A4")]
		private AchievementDataStringResolver _stringResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40044A5")]
		private bool isStarted;

		[Cpp2IlInjected.Token(Token = "0x40044A6")]
		private static readonly MessageParser<AchievementData> _parser = (MessageParser<AchievementData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new AchievementData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40044A7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40044A8")]
		public const int AchievementIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40044A9")]
		private int achievementID_;

		[Cpp2IlInjected.Token(Token = "0x40044AA")]
		public const int CurAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40044AB")]
		private int curAmount_;

		[Cpp2IlInjected.Token(Token = "0x40044AC")]
		public const int ClaimedRewardMilestoneFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40044AD")]
		private int claimedRewardMilestone_;

		[Cpp2IlInjected.Token(Token = "0x40044AE")]
		public const int ItemFilterFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40044AF")]
		private ItemFilter itemFilter_;

		[Cpp2IlInjected.Token(Token = "0x40044B0")]
		public const int StateFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40044B1")]
		private AchievementState state_;

		[Cpp2IlInjected.Token(Token = "0x40044B2")]
		public const int TypesCollectedFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40044B3")]
		private static readonly FieldCodec<int> _repeated_typesCollected_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40044B4")]
		private readonly RepeatedField<int> typesCollected_;

		[Cpp2IlInjected.Token(Token = "0x40044B5")]
		public const int AchNameFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40044B6")]
		private string achName_;

		[Cpp2IlInjected.Token(Token = "0x40044B7")]
		public const int ItemsUsedFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x40044B8")]
		private static readonly FieldCodec<int> _repeated_itemsUsed_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40044B9")]
		private readonly RepeatedField<int> itemsUsed_;

		[Cpp2IlInjected.Token(Token = "0x40044BA")]
		public const int MaxAmountFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40044BB")]
		private int maxAmount_;

		[Cpp2IlInjected.Token(Token = "0x40044BC")]
		public const int GridObjectsCollectedFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40044BD")]
		private object optionalState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40044BE")]
		private OptionalStateOneofCase optionalStateCase_;

		[Cpp2IlInjected.Token(Token = "0x17001770")]
		public AchievementItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6008709")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CB40", Offset = "0x1E2B540", VA = "0x181E2CB40")]
			get
			{
				//Discarded unreachable code: IL_0008
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				AchievementItemData result = default(AchievementItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001771")]
		public int PreviousMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x600873F")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CF60", Offset = "0x1E2B960", VA = "0x181E2CF60")]
			get
			{
				//Discarded unreachable code: IL_0009, IL_001b
				int claimedMilestoneIndex = ClaimedMilestoneIndex;
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001772")]
		public int CurrentMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x6008740")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C8F0", Offset = "0x1E2B2F0", VA = "0x181E2C8F0")]
			get
			{
				//Discarded unreachable code: IL_003d
				RepeatedField<AchievementMilestone> milestones_ = ItemData.milestones_;
				int count = ((RepeatedField<T>)(object)ItemData.milestones_).Count;
				int val = ClaimedMilestoneIndex + 1;
				val = Math.Min(count - 1, val);
				return ((AchievementMilestone)((RepeatedField<T>)(object)milestones_)[val]).milestone_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001773")]
		public int ClaimedMilestoneIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008741")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C760", Offset = "0x1E2B160", VA = "0x181E2C760")]
			get
			{
				//Discarded unreachable code: IL_0021
				RepeatedField<AchievementMilestone> milestones_ = ItemData.milestones_;
				Func<AchievementMilestone, bool> func = (Func<AchievementMilestone, bool>)(object)(Func<T, TResult>)delegate(AchievementMilestone x)
				{
					//Discarded unreachable code: IL_0011
					int num = claimedRewardMilestone_;
					return x.milestone_ == num;
				};
				return ((RepeatedField<>)(object)milestones_).FindIndex<AchievementMilestone>((Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001774")]
		public int LastMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x6008742")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CE10", Offset = "0x1E2B810", VA = "0x181E2CE10")]
			get
			{
				//Discarded unreachable code: IL_002c
				RepeatedField<AchievementMilestone> milestones_ = ItemData.milestones_;
				int index = ((RepeatedField<T>)(object)ItemData.milestones_).Count - 1;
				return ((AchievementMilestone)((RepeatedField<T>)(object)milestones_)[index]).milestone_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001775")]
		public bool IsLastMilestoneClaimed
		{
			[Cpp2IlInjected.Token(Token = "0x6008743")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CB20", Offset = "0x1E2B520", VA = "0x181E2CB20")]
			get
			{
				int num = claimedRewardMilestone_;
				int lastMilestone = LastMilestone;
				return num >= lastMilestone;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001776")]
		public int CurAmountDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6008744")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C840", Offset = "0x1E2B240", VA = "0x181E2C840")]
			get
			{
				//Discarded unreachable code: IL_0024
				AchievementItemData itemData = ItemData;
				int num = curAmount_;
				if (itemData.withoutFailing_)
				{
					int previousMilestone = PreviousMilestone;
					num -= previousMilestone;
				}
				return num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001777")]
		public int MaxAmountDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6008745")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CEB0", Offset = "0x1E2B8B0", VA = "0x181E2CEB0")]
			get
			{
				//Discarded unreachable code: IL_002b
				if (!ItemData.withoutFailing_)
				{
					return curAmount_;
				}
				int num = maxAmount_;
				int previousMilestone = PreviousMilestone;
				return num - previousMilestone;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001778")]
		public int ClaimableAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008746")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C720", Offset = "0x1E2B120", VA = "0x181E2C720")]
			get
			{
				//Discarded unreachable code: IL_001c
				if (ItemData.withoutFailing_)
				{
					return maxAmount_;
				}
				return curAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001779")]
		public int CurrentMilestoneDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6008747")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C890", Offset = "0x1E2B290", VA = "0x181E2C890")]
			get
			{
				//Discarded unreachable code: IL_002f
				AchievementItemData itemData = ItemData;
				int num = 0;
				if ((itemData.withoutFailing_ ? 1 : 0) == num)
				{
					return CurrentMilestone;
				}
				int currentMilestone = CurrentMilestone;
				int previousMilestone = PreviousMilestone;
				return currentMilestone - previousMilestone;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177A")]
		public int LastMilestoneDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6008748")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CC10", Offset = "0x1E2B610", VA = "0x181E2CC10")]
			get
			{
				//Discarded unreachable code: IL_009c
				if (!ItemData.withoutFailing_)
				{
					RepeatedField<AchievementMilestone> milestones_ = ItemData.milestones_;
					int index = ((RepeatedField<T>)(object)ItemData.milestones_).Count - 1;
					return ((AchievementMilestone)((RepeatedField<T>)(object)milestones_)[index]).milestone_;
				}
				int count = ((RepeatedField<T>)(object)ItemData.milestones_).Count;
				int milestone_ = ((AchievementMilestone)((RepeatedField<T>)(object)ItemData.milestones_)[count]).milestone_;
				RepeatedField<AchievementMilestone> milestones_2 = ItemData.milestones_;
				int index2 = ((RepeatedField<T>)(object)ItemData.milestones_).Count - 1;
				int milestone_2 = ((AchievementMilestone)((RepeatedField<T>)(object)milestones_2)[index2]).milestone_;
				return milestone_2 - milestone_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177B")]
		[DebuggerNonUserCode]
		public static MessageParser<AchievementData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008750")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CF00", Offset = "0x1E2B900", VA = "0x181E2CF00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008751")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C9F0", Offset = "0x1E2B3F0", VA = "0x181E2C9F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008752")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CFF0", Offset = "0x1E2B9F0", VA = "0x181E2CFF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177E")]
		[DebuggerNonUserCode]
		public int AchievementID
		{
			[Cpp2IlInjected.Token(Token = "0x6008756")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return achievementID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008757")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				achievementID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177F")]
		[DebuggerNonUserCode]
		public int CurAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008758")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return curAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008759")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				curAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001780")]
		[DebuggerNonUserCode]
		public int ClaimedRewardMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x600875A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return claimedRewardMilestone_;
			}
			[Cpp2IlInjected.Token(Token = "0x600875B")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				claimedRewardMilestone_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001781")]
		[DebuggerNonUserCode]
		public ItemFilter ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600875C")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return itemFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x600875D")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				itemFilter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001782")]
		[DebuggerNonUserCode]
		public AchievementState State
		{
			[Cpp2IlInjected.Token(Token = "0x600875E")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x600875F")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001783")]
		[DebuggerNonUserCode]
		public RepeatedField<int> TypesCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6008760")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return typesCollected_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001784")]
		[DebuggerNonUserCode]
		public string AchName
		{
			[Cpp2IlInjected.Token(Token = "0x6008761")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return achName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008762")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D100", Offset = "0x1E2BB00", VA = "0x181E2D100")]
			set
			{
				string text = (achName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001785")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6008763")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return itemsUsed_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001786")]
		[DebuggerNonUserCode]
		public int MaxAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008764")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get
			{
				return maxAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008765")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				maxAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001787")]
		[DebuggerNonUserCode]
		public GridObjectAddressList GridObjectsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6008766")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CAC0", Offset = "0x1E2B4C0", VA = "0x181E2CAC0")]
			get
			{
				if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
				{
					object obj = optionalState_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008767")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D170", Offset = "0x1E2BB70", VA = "0x181E2D170")]
			set
			{
				optionalState_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001788")]
		[DebuggerNonUserCode]
		public OptionalStateOneofCase OptionalStateCase
		{
			[Cpp2IlInjected.Token(Token = "0x6008768")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return optionalStateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600870A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B820", Offset = "0x1E2A220", VA = "0x181E2B820")]
		public AchievementDataStringResolver StringResolver(Localizator localizator)
		{
			AchievementDataStringResolver stringResolver = _stringResolver;
			if (stringResolver == null)
			{
				AchievementDataStringResolver achievementDataStringResolver = default(AchievementDataStringResolver);
				achievementDataStringResolver._achievementData = this;
				achievementDataStringResolver._localizator = localizator;
				_stringResolver = achievementDataStringResolver;
			}
			return stringResolver;
		}

		[Cpp2IlInjected.Token(Token = "0x600870B")]
		[Cpp2IlInjected.Address(RVA = "0x1E29CE0", Offset = "0x1E286E0", VA = "0x181E29CE0")]
		public void Start(Profile profile, ProfileEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_01e3, IL_01fa, IL_0201
			if (!isStarted)
			{
				isStarted = true;
				Dispatcher = dispatcher;
				Profile = profile;
				if (state_ != AchievementState.Completed && ItemData.stepCase_ <= AchievementItemData.StepOneofCase.PickUp)
				{
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.FishingResultReceived fishingResultReceived = OnFishingResultReceived;
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.FishingResultReceived value = OnFishingResultReceived;
					dispatcher3.OnFishingResultReceived += value;
					ProfileEventDispatcher dispatcher4 = Dispatcher;
					ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
					dispatcher4.OnCurrencyChanged -= value2;
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.CurrencyChanged value3 = OnCurrencyChanged;
					dispatcher5.OnCurrencyChanged += value3;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.MealCooked value4 = OnMealCooked;
					dispatcher6.OnMealCooked -= value4;
					ProfileEventDispatcher dispatcher7 = Dispatcher;
					ProfileEventDispatcher.MealCooked value5 = OnMealCooked;
					dispatcher7.OnMealCooked += value5;
					ProfileEventDispatcher dispatcher8 = Dispatcher;
					ProfileEventDispatcher.GardeningEvent value6 = OnHarvestEvent;
					dispatcher8.OnGardeningEvent -= value6;
					ProfileEventDispatcher dispatcher9 = Dispatcher;
					ProfileEventDispatcher.GardeningEvent value7 = OnHarvestEvent;
					dispatcher9.OnGardeningEvent += value7;
					ProfileEventDispatcher dispatcher10 = Dispatcher;
					ProfileEventDispatcher.GardeningEvent value8 = OnPlantingEvent;
					dispatcher10.OnGardeningEvent -= value8;
					ProfileEventDispatcher dispatcher11 = Dispatcher;
					ProfileEventDispatcher.GardeningEvent value9 = OnPlantingEvent;
					dispatcher11.OnGardeningEvent += value9;
					ProfileEventDispatcher dispatcher12 = Dispatcher;
					ProfileEventDispatcher.ItemAdded value10 = OnPickUpItemAdded;
					dispatcher12.OnItemAdded -= value10;
					ProfileEventDispatcher dispatcher13 = Dispatcher;
					ProfileEventDispatcher.ItemAdded value11 = OnPickUpItemAdded;
					dispatcher13.OnItemAdded += value11;
					ProfileEventDispatcher dispatcher14 = Dispatcher;
					ProfileEventDispatcher.GridChanged value12 = OnPickUpWeed;
					dispatcher14.OnGridChanged -= value12;
					ProfileEventDispatcher dispatcher15 = Dispatcher;
					ProfileEventDispatcher.GridChanged value13 = OnPickUpWeed;
					dispatcher15.OnGridChanged += value13;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600870C")]
		[Cpp2IlInjected.Address(RVA = "0x1E28550", Offset = "0x1E26F50", VA = "0x181E28550")]
		private void OnShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery)
		{
			int itemID = item.ItemID;
			if (state_ == AchievementState.Completed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600870D")]
		[Cpp2IlInjected.Address(RVA = "0x1E26A60", Offset = "0x1E25460", VA = "0x181E26A60")]
		private void OnDutyAchRewardCollected(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item royalDutyItem)
		{
			//Discarded unreachable code: IL_003a
			CustomStepRoyalDuties royalDuty = ItemData.RoyalDuty;
			if (royalDuty == null)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			if (royalDutyItemData != null)
			{
				DutyType type_ = royalDuty.type_;
				if (type_ == DutyType.None || type_ == royalDutyItemData.type_)
				{
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600870E")]
		[Cpp2IlInjected.Address(RVA = "0x1E292A0", Offset = "0x1E27CA0", VA = "0x181E292A0")]
		private void StartExpandHouse()
		{
			//Discarded unreachable code: IL_00f2
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			CustomStepExpandHouse expandHouse = ItemData.ExpandHouse;
			if (expandHouse != null)
			{
				ExpandHouseEventType eventToListen = expandHouse.EventToListen;
				int num = (int)eventToListen;
				ExpandHouseEventType expandHouseEventType = default(ExpandHouseEventType);
				if (((Enum)eventToListen).HasFlag(expandHouseEventType))
				{
					ProfileEventDispatcher dispatcher = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomExpanded value = OnPlayerHouseRoomExpanded;
					dispatcher.OnPlayerHouseRoomExpanded -= value;
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomExpanded value2 = OnPlayerHouseRoomExpanded;
					dispatcher2.OnPlayerHouseRoomExpanded += value2;
				}
				bool flag = default(bool);
				if (flag)
				{
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomAdded value3 = OnPlayerHouseRoomAdded;
					dispatcher3.OnPlayerHouseRoomAdded -= value3;
					ProfileEventDispatcher dispatcher4 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomAdded value4 = OnPlayerHouseRoomAdded;
					dispatcher4.OnPlayerHouseRoomAdded += value4;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseFloorAdded value5 = OnPlayerHouseFloorAdded;
					dispatcher5.OnPlayerHouseFloorAdded -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseFloorAdded value6 = OnPlayerHouseFloorAdded;
					dispatcher6.OnPlayerHouseFloorAdded += value6;
				}
				InitExpandHouse();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600870F")]
		[Cpp2IlInjected.Address(RVA = "0x1E25C90", Offset = "0x1E24690", VA = "0x181E25C90")]
		private void InitExpandHouse()
		{
			//Discarded unreachable code: IL_0185
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected I4, but got Unknown
			if (curAmount_ >= 1)
			{
				return;
			}
			CustomStepExpandHouse expandHouse = ItemData.ExpandHouse;
			if (expandHouse == null)
			{
				return;
			}
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			if (expandHouse.actionType_ > CustomStepExpandHouse.Types.ExpandType.ReachNumberOfFloor)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)Profile.world_.playerHouse_.floors_).Count;
			int num = num - count;
			int roomCount = Profile.world_.playerHouse_.RoomCount;
			int num2 = default(int);
			num += num2;
			num -= roomCount;
			Profile profile = Profile;
			int num3 = default(int);
			num2 = num3;
			House playerHouse_ = profile.world_.playerHouse_;
			int num4 = default(int);
			playerHouse_ = (House)(playerHouse_ - num4);
			int amount_ = expandHouse.amount_;
			if ((long)amount_ <= (long)(IntPtr)playerHouse_)
			{
				return;
			}
			amount_ -= playerHouse_;
			House playerHouse_2 = Profile.world_.playerHouse_;
			int num5 = default(int);
			num = num5;
			int roomCount2 = Profile.world_.playerHouse_.RoomCount;
			num -= roomCount2;
			int amount_2 = expandHouse.amount_;
			if (amount_2 > num)
			{
				amount_2 -= num;
				Profile profile2 = Profile;
				int num6 = default(int);
				num = num6;
				int count2 = ((RepeatedField<T>)(object)profile2.world_.playerHouse_.floors_).Count;
				num -= count2;
				int amount_3 = expandHouse.amount_;
				if (amount_3 > num)
				{
					amount_3 -= num;
					int roomCount3 = Profile.world_.playerHouse_.RoomCount;
					int num7 = (curAmount_ = ((RepeatedField<T>)(object)Profile.world_.playerHouse_.floors_).Count);
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008710")]
		[Cpp2IlInjected.Address(RVA = "0x1E284C0", Offset = "0x1E26EC0", VA = "0x181E284C0")]
		private void OnPlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost)
		{
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008711")]
		[Cpp2IlInjected.Address(RVA = "0x1E284C0", Offset = "0x1E26EC0", VA = "0x181E284C0")]
		private void OnPlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, List<CurrencyCost> cost)
		{
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008712")]
		[Cpp2IlInjected.Address(RVA = "0x1E284C0", Offset = "0x1E26EC0", VA = "0x181E284C0")]
		private void OnPlayerHouseFloorAdded([Optional] CurrencyCost cost)
		{
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008713")]
		[Cpp2IlInjected.Address(RVA = "0x1E295E0", Offset = "0x1E27FE0", VA = "0x181E295E0")]
		private void StartUnlockBuilding()
		{
			//Discarded unreachable code: IL_0163
			CustomStepUnlock unlock = ItemData.Unlock;
			if (unlock == null)
			{
				return;
			}
			CustomStepUnlock.TypeOneofCase typeCase_ = unlock.typeCase_;
			if (unlock != null)
			{
				if (unlock != null)
				{
					if (unlock != null)
					{
						if (typeCase_ == CustomStepUnlock.TypeOneofCase.Building)
						{
							ProfileEventDispatcher dispatcher = Dispatcher;
							ProfileEventDispatcher.ToolAdded value = OnToolAdded;
							dispatcher.OnToolAdded -= value;
							ProfileEventDispatcher dispatcher2 = Dispatcher;
							ProfileEventDispatcher.ToolAdded value2 = OnToolAdded;
							dispatcher2.OnToolAdded += value2;
						}
					}
					else
					{
						ProfileEventDispatcher dispatcher3 = Dispatcher;
						ProfileEventDispatcher.RealmUnlocked value3 = OnRealmUnlocked;
						dispatcher3.OnRealmUnlocked -= value3;
						ProfileEventDispatcher dispatcher4 = Dispatcher;
						ProfileEventDispatcher.RealmUnlocked value4 = OnRealmUnlocked;
						dispatcher4.OnRealmUnlocked += value4;
					}
				}
				else
				{
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value5 = OnVillageAreaUnlocked;
					dispatcher5.OnVillageAreaUnlocked -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value6 = OnVillageAreaUnlocked;
					dispatcher6.OnVillageAreaUnlocked += value6;
				}
			}
			else
			{
				ProfileEventDispatcher dispatcher7 = Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value7 = OnBuildingUnlocked;
				dispatcher7.OnBuildingUnlocked -= value7;
				ProfileEventDispatcher dispatcher8 = Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value8 = OnBuildingUnlocked;
				dispatcher8.OnBuildingUnlocked += value8;
				ProfileEventDispatcher dispatcher9 = Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value9 = OnBuildingBuilt;
				dispatcher9.OnBuildingBuilt -= value9;
				ProfileEventDispatcher dispatcher10 = Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value10 = OnBuildingBuilt;
				dispatcher10.OnBuildingBuilt += value10;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008714")]
		[Cpp2IlInjected.Address(RVA = "0x1E26730", Offset = "0x1E25130", VA = "0x181E26730")]
		private void OnBuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs)
		{
			CheckBuildingUnlockedCompletion(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6008715")]
		[Cpp2IlInjected.Address(RVA = "0x1E26730", Offset = "0x1E25130", VA = "0x181E26730")]
		private void OnBuildingBuilt(Item item)
		{
			CheckBuildingUnlockedCompletion(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6008716")]
		[Cpp2IlInjected.Address(RVA = "0x1E23760", Offset = "0x1E22160", VA = "0x181E23760")]
		private void CheckBuildingUnlockedCompletion(Item item)
		{
			//Discarded unreachable code: IL_00a4
			int itemID = item.ItemID;
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Building)
			{
				return;
			}
			CustomStepUnlock unlock = ItemData.Unlock;
			if (unlock == null)
			{
				return;
			}
			TargetBuildingType building = unlock.Building;
			if (building.buildingTypeCase_ != TargetBuildingType.BuildingTypeOneofCase.Any)
			{
				if (building.TargetBuilding == null)
				{
					return;
				}
				BuildingItemType buildingItemType = default(BuildingItemType);
				int num2 = (int)buildingItemType;
				BuildingItemType targetBuildingItemType = building.TargetBuildingItemType;
				if (num2 != (int)targetBuildingItemType)
				{
					return;
				}
				if (building.TargetBuilding.targetCase_ == TargetBuilding.TargetOneofCase.ItemID)
				{
					Item item2 = building.TargetBuilding.Item;
					bool flag = default(bool);
					if (flag)
					{
						return;
					}
				}
			}
			ProfileWorld world_ = Profile.world_;
			bool flag2 = default(bool);
			if (flag2)
			{
				ProfileWorld world_2 = Profile.world_;
				bool flag3 = default(bool);
				if (flag3)
				{
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008717")]
		[Cpp2IlInjected.Address(RVA = "0x1E28820", Offset = "0x1E27220", VA = "0x181E28820")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0027
			//IL_000e: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			if (!((RepeatedField<T>)(object)typesCollected_).Contains((T)areaType))
			{
				((RepeatedField<T>)(object)typesCollected_).Add((T)areaType);
				int milestonePassed = 0;
				CheckMilestoneProgress((byte)milestonePassed != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008718")]
		[Cpp2IlInjected.Address(RVA = "0x1E284D0", Offset = "0x1E26ED0", VA = "0x181E284D0")]
		private void OnRealmUnlocked(string realmName, bool unlockedByFlag)
		{
			//Discarded unreachable code: IL_0034
			Profile profile = Profile;
			int num = curAmount_;
			if (num != (curAmount_ = ((MapField<TKey, TValue>)(object)profile.world_.realms_).Count))
			{
				int milestonePassed = 0;
				CheckMilestoneProgress((byte)milestonePassed != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008719")]
		[Cpp2IlInjected.Address(RVA = "0x1E287A0", Offset = "0x1E271A0", VA = "0x181E287A0")]
		private void OnToolAdded(Item toolItem)
		{
			//Discarded unreachable code: IL_0034
			Profile profile = Profile;
			int num = curAmount_;
			if (num != (curAmount_ = ((RepeatedField<T>)(object)profile.player_.tools_).Count))
			{
				int milestonePassed = 0;
				CheckMilestoneProgress((byte)milestonePassed != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600871A")]
		[Cpp2IlInjected.Address(RVA = "0x1E29980", Offset = "0x1E28380", VA = "0x181E29980")]
		private void StartUpgrade()
		{
			//Discarded unreachable code: IL_00c1
			AchievementItemData itemData = ItemData;
			CustomStepUpgrade upgrade = itemData.Upgrade;
			if (upgrade == null)
			{
				return;
			}
			CustomStepUpgrade.TargetOneofCase targetCase_ = upgrade.targetCase_;
			if ((long)itemData <= 1)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.BuidingUpgraded value = OnBuidingUpgraded;
				dispatcher.OnBuidingUpgraded -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.BuidingUpgraded value2 = OnBuidingUpgraded;
				dispatcher2.OnBuidingUpgraded += value2;
				if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any)
				{
				}
				Item buildingItem = upgrade.BuildingItem;
			}
			if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any || upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.PlayerLevel)
			{
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value3 = OnPlayerLevelGained;
				dispatcher3.OnPlayerLevelGained -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value4 = OnPlayerLevelGained;
				dispatcher4.OnPlayerLevelGained += value4;
				int gained = 0;
				OnPlayerLevelGained(gained);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600871B")]
		[Cpp2IlInjected.Address(RVA = "0x1E266D0", Offset = "0x1E250D0", VA = "0x181E266D0")]
		private void OnBuidingUpgraded(GridObject gridObj, UpgradeData upData)
		{
			//Discarded unreachable code: IL_0008
			int itemID = gridObj.ItemID;
		}

		[Cpp2IlInjected.Token(Token = "0x600871C")]
		[Cpp2IlInjected.Address(RVA = "0x1E235C0", Offset = "0x1E21FC0", VA = "0x181E235C0")]
		private void CheckBuidingUpgradedCompletion(bool isUpgradeEvent, Item item, int level)
		{
			//Discarded unreachable code: IL_0088
			int num = 0;
			CustomStepUpgrade upgrade = ItemData.Upgrade;
			if (upgrade == null)
			{
				return;
			}
			if (upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.BuildingID)
			{
				Item buildingItem = upgrade.BuildingItem;
				bool flag = default(bool);
				if (flag)
				{
					if ((object)upgrade.BuildingItem == null)
					{
						return;
					}
					ProfileWorld world_ = Profile.world_;
				}
			}
			if (!isUpgradeEvent)
			{
				return;
			}
			int num2 = curAmount_;
			if (upgrade.targetTypeCase_ == CustomStepUpgrade.TargetTypeOneofCase.TargetLevel || isUpgradeEvent)
			{
				int targetLevel = upgrade.TargetLevel;
				int num3 = curAmount_;
				if (num2 != (curAmount_ = num3 + 1))
				{
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600871D")]
		[Cpp2IlInjected.Address(RVA = "0x1E241C0", Offset = "0x1E22BC0", VA = "0x181E241C0")]
		private void OnPlayerLevelGained(int gained)
		{
			//Discarded unreachable code: IL_0047
			CustomStepUpgrade upgrade = ItemData.Upgrade;
			if (upgrade != null)
			{
				int num = curAmount_;
				if (upgrade.targetTypeCase_ != CustomStepUpgrade.TargetTypeOneofCase.TargetLevel)
				{
				}
				if (num != (curAmount_ = Profile.player_.level_))
				{
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600871E")]
		[Cpp2IlInjected.Address(RVA = "0x1E241C0", Offset = "0x1E22BC0", VA = "0x181E241C0")]
		private void CheckPlayerLevelCompletion()
		{
			//Discarded unreachable code: IL_0047
			CustomStepUpgrade upgrade = ItemData.Upgrade;
			if (upgrade != null)
			{
				int num = curAmount_;
				if (upgrade.targetTypeCase_ != CustomStepUpgrade.TargetTypeOneofCase.TargetLevel)
				{
				}
				if (num != (curAmount_ = Profile.player_.level_))
				{
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600871F")]
		[Cpp2IlInjected.Address(RVA = "0x1E266C0", Offset = "0x1E250C0", VA = "0x181E266C0")]
		private void OnAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			CheckDressUpCompletion();
		}

		[Cpp2IlInjected.Token(Token = "0x6008720")]
		[Cpp2IlInjected.Address(RVA = "0x1E23940", Offset = "0x1E22340", VA = "0x181E23940")]
		private void CheckDressUpCompletion()
		{
			//Discarded unreachable code: IL_00dc
			ProfilePlayer player_ = Profile.player_;
			if ((long)ProfilePlayer._map_furnitureData_codec != 0)
			{
			}
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractClothes((IAvatar)player_.femaleAvatar_);
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int itemsQuantity = itemFilter.GetItemsQuantity((Dictionary<, >)(object)dictionary, (byte)num != 0);
			int prevAmount = curAmount_;
			if (ItemData.withoutFailing_)
			{
				int num2 = curAmount_;
				if (maxAmount_ < num2)
				{
					maxAmount_ = num2;
				}
			}
			int num3 = curAmount_;
			if (prevAmount != num3)
			{
				List<AchievementMilestone> list = (List<AchievementMilestone>)(object)Enumerable.ToList<AchievementMilestone>((IEnumerable<>)(object)ItemData.milestones_);
				Predicate<AchievementMilestone> predicate = (Predicate<AchievementMilestone>)(object)(Predicate<T>)delegate(AchievementMilestone x)
				{
					//Discarded unreachable code: IL_0011
					int num5 = prevAmount;
					return x.milestone_ > num5;
				};
				AchievementMilestone achievementMilestone = (AchievementMilestone)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				int num4 = 0;
				if (achievementMilestone != null)
				{
					int milestone_ = achievementMilestone.milestone_;
				}
				bool milestonePassed = num4 <= curAmount_;
				CheckMilestoneProgress(milestonePassed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008721")]
		[Cpp2IlInjected.Address(RVA = "0x1E24DA0", Offset = "0x1E237A0", VA = "0x181E24DA0")]
		private void DecorateOnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions addObjectOptions)
		{
			//Discarded unreachable code: IL_004e
			if (gridObject != null)
			{
				int itemID = gridObject.ItemID;
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Furniture)
				{
					ItemSelector itemSelector = ItemData.ItemSelector;
					if (itemSelector != null && itemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.FilterGenerator)
					{
						int itemID2 = gridObject.ItemID;
						FurnitureItemType furnitureItemType = default(FurnitureItemType);
						if (furnitureItemType == FurnitureItemType.Blocker || furnitureItemType == FurnitureItemType.Door)
						{
							return;
						}
					}
				}
			}
			bool flag = default(bool);
			if (flag)
			{
				int milestonePassed = 0;
				CheckMilestoneProgress((byte)milestonePassed != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008722")]
		[Cpp2IlInjected.Address(RVA = "0x1E25770", Offset = "0x1E24170", VA = "0x181E25770")]
		private bool HasCorrectDecor(IGrid grid, GridChangedOperation operation, GridObject gridObject)
		{
			//Discarded unreachable code: IL_00ec
			bool flag = default(bool);
			bool flag2 = default(bool);
			IEnumerable<GridObject> enumerable = default(IEnumerable<GridObject>);
			uint num3 = default(uint);
			bool flag3 = default(bool);
			uint num4 = default(uint);
			while (true)
			{
				int num = 0;
				int num2 = curAmount_;
				if (operation != GridChangedOperation.UpdateState)
				{
					if (operation == GridChangedOperation.UpdateTransform || flag)
					{
					}
					GridLocationFilter location_ = ItemData.Decorate.location_;
					if (location_ != null)
					{
						LocationSourceWithRadius specificLocation = location_.SpecificLocation;
					}
					int itemID = gridObject.ItemID;
					if (!flag2)
					{
						break;
					}
					if (operation != GridChangedOperation.Remove)
					{
						LocationSourceWithRadius specificLocation2 = ItemData.Decorate.location_.SpecificLocation;
						if (enumerable != null)
						{
							if (num < (int)num3)
							{
								num += num;
								if (num == (int)num3)
								{
									goto IL_007e;
								}
								num++;
							}
							while (!flag3)
							{
							}
							goto IL_007e;
						}
						goto IL_0085;
					}
				}
				goto IL_0099;
				IL_007e:
				num4 += num4;
				goto IL_0085;
				IL_0085:
				num++;
				if (enumerable != null)
				{
				}
				if (this != null)
				{
					continue;
				}
				if (num == 0)
				{
					break;
				}
				goto IL_0099;
				IL_0099:
				return num2 != curAmount_;
			}
			while (operation != GridChangedOperation.UpdateTransform)
			{
			}
			ItemFilter itemFilter = itemFilter_;
			int itemID2 = gridObject.ItemID;
			bool flag4 = default(bool);
			while (!flag4)
			{
			}
			GridLocationFilter location_2 = ItemData.Decorate.location_;
			Profile profile = Profile;
			bool flag5 = MissionObjective.ApplyGridLocationFilter(location_2, grid, gridObject, profile);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008723")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BF80", Offset = "0x1E2A980", VA = "0x181E2BF80")]
		private unsafe bool UpdateGridObjectCollected(IGrid grid, GridObject gridObject, bool mustAdd)
		{
			if (!mustAdd)
			{
				int num = 0;
				if (!TryGetGridObjectCollected(grid, gridObject, out *(GridObjectAddress*)num))
				{
					goto IL_0031;
				}
				if (optionalState_ == null)
				{
					goto IL_0033;
				}
			}
			int num2 = 0;
			if (!TryGetGridObjectCollected(grid, gridObject, out *(GridObjectAddress*)num2))
			{
				AddGridObjectCollected(grid, gridObject);
			}
			goto IL_0031;
			IL_0033:
			throw new InvalidCastException();
			IL_0031:
			int num3 = 0;
			goto IL_0033;
		}

		[Cpp2IlInjected.Token(Token = "0x6008724")]
		[Cpp2IlInjected.Address(RVA = "0x1E26080", Offset = "0x1E24A80", VA = "0x181E26080")]
		private unsafe bool IsGridObjectCollected(IGrid grid, GridObject gridObject)
		{
			int num = 0;
			return TryGetGridObjectCollected(grid, gridObject, out *(GridObjectAddress*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008725")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B920", Offset = "0x1E2A320", VA = "0x181E2B920")]
		private bool TryGetGridObjectCollected(IGrid grid, GridObject gridObject, out GridObjectAddress gridObjectAddress)
		{
			if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
			{
				object obj = optionalState_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				if (obj != null)
				{
					Func<GridObjectAddress, bool> func = (Func<GridObjectAddress, bool>)(object)(Func<T, TResult>)delegate(GridObjectAddress x)
					{
						//Discarded unreachable code: IL_002c
						IGrid grid2 = grid;
						if ((IntPtr)(int)x.gridID_ != (IntPtr)typeof(IGrid).TypeHandle)
						{
							int num = 0;
						}
						uint iD_ = gridObject.iD_;
						return x.gridObjectID_ == iD_;
					};
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008726")]
		[Cpp2IlInjected.Address(RVA = "0x1E230D0", Offset = "0x1E21AD0", VA = "0x181E230D0")]
		private void AddGridObjectCollected(IGrid grid, GridObject gridObject)
		{
			//Discarded unreachable code: IL_0052
			//IL_001e: Expected I4, but got O
			if (optionalStateCase_ != OptionalStateOneofCase.GridObjectsCollected)
			{
				optionalStateCase_ = (OptionalStateOneofCase)(optionalState_ = new GridObjectAddressList());
			}
			OptionalStateOneofCase optionalStateOneofCase = optionalStateCase_;
			object obj = optionalState_;
			int num = 0;
			if (obj != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				uint iD_ = gridObject.iD_;
				GridObjectAddress gridObjectAddress = new GridObjectAddress((uint)num, iD_);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008727")]
		[Cpp2IlInjected.Address(RVA = "0x1E28B70", Offset = "0x1E27570", VA = "0x181E28B70")]
		private unsafe bool RemoveGridObjectCollected(IGrid grid, GridObject gridObject)
		{
			int num = 0;
			if (!TryGetGridObjectCollected(grid, gridObject, out *(GridObjectAddress*)num) || optionalState_ != null)
			{
				int num2 = 0;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008728")]
		[Cpp2IlInjected.Address(RVA = "0x1E26740", Offset = "0x1E25140", VA = "0x181E26740")]
		private void OnCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			CheckFriendCompletion(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6008729")]
		[Cpp2IlInjected.Address(RVA = "0x1E26740", Offset = "0x1E25140", VA = "0x181E26740")]
		private void OnCharacterUnlocked(Item characterItem)
		{
			CheckFriendCompletion(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x600872A")]
		[Cpp2IlInjected.Address(RVA = "0x1E23B40", Offset = "0x1E22540", VA = "0x181E23B40")]
		private unsafe void CheckFriendCompletion(Item characterItem)
		{
			//Discarded unreachable code: IL_014d, IL_0153, IL_0159, IL_015f, IL_0165, IL_016b, IL_0171, IL_0177, IL_017d
			//IL_001c: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			CharacterAny characterAny = default(CharacterAny);
			while (true)
			{
				int itemID = characterItem.ItemID;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Item characterItem2 = (Item)itemID;
				AchievementItemData itemData = ItemData;
				if (itemData != null)
				{
					CustomStepFriend makeFriend = itemData.MakeFriend;
				}
				CustomStepFriend stepMakeFriendData = (CustomStepFriend)num;
				if ((IntPtr)stepMakeFriendData == (IntPtr)num)
				{
					break;
				}
				RepeatedField<int> repeatedField = typesCollected_;
				if (!flag)
				{
					RepeatedField<Character> characters_ = Profile.world_.characters_;
					Predicate<Character> predicate = (Predicate<Character>)(object)(Predicate<T>)delegate(Character x)
					{
						int iD3 = x.Data.ID;
						throw new NullReferenceException();
					};
					if (ProtoExtensions.TryFindValue<Character>((RepeatedField<>)(object)characters_, (Predicate<>)(object)predicate, ref *(Character*)num) && num != 0)
					{
						RepeatedField<int> repeatedField2 = typesCollected_;
					}
				}
				if (stepMakeFriendData.characterCase_ != CustomStepFriend.CharacterOneofCase.Any)
				{
					break;
				}
				int num4 = curAmount_;
				if (itemData.useMilestoneAsFriendshipLevel_)
				{
					RepeatedField<AchievementMilestone> milestones_ = itemData.milestones_;
					if (flag2)
					{
						AchievementMilestone milestone = (AchievementMilestone)num3;
						_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals1;
						if ((long)curAmount_ >= (long)(IntPtr)CS_0024_003C_003E8__locals1)
						{
							continue;
						}
						RepeatedField<Character> characters_2 = Profile.world_.characters_;
						Func<Character, bool> func = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
						{
							//Discarded unreachable code: IL_003c
							//IL_003b: Expected O, but got I4
							int milestone_ = milestone.milestone_;
							if (x.friendshipLevel_ < milestone_)
							{
								int num9 = 0;
							}
							RepeatedField<int> repeatedField4 = typesCollected_;
							int iD2 = x.Data.ID;
							return ((RepeatedField<T>)(object)repeatedField4).Contains((T)iD2);
						};
						int num5 = Enumerable.Count<Character>((IEnumerable<>)(object)characters_2, (Func<, >)(object)func);
						int num6 = (curAmount_ = characterAny.amountOfCharacter_);
					}
					if (num + 1 == 0)
					{
					}
				}
				Func<Character, bool> func2 = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
				{
					//Discarded unreachable code: IL_0037
					//IL_0036: Expected O, but got I4
					int minimumFriendshipLevel_ = stepMakeFriendData.minimumFriendshipLevel_;
					if (x.friendshipLevel_ < minimumFriendshipLevel_)
					{
						int num8 = 0;
					}
					RepeatedField<int> repeatedField3 = typesCollected_;
					int iD = x.Data.ID;
					return ((RepeatedField<T>)(object)repeatedField3).Contains((T)iD);
				};
				int num7 = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600872B")]
		[Cpp2IlInjected.Address(RVA = "0x1E26750", Offset = "0x1E25150", VA = "0x181E26750")]
		private void OnCritterFed(Critter critter, FeedCritterDetails details)
		{
			AchievementItemData itemData = ItemData;
			int num = 0;
			CustomStepFeedCritter feedCritter = itemData.FeedCritter;
			if (feedCritter == null || critter == null)
			{
				return;
			}
			CritterItemData data = critter.Data;
			if (data == null || data != null || (feedCritter.conditionCase_ == CustomStepFeedCritter.ConditionOneofCase.Location && feedCritter.Location != data.location_))
			{
				return;
			}
			CustomStepFeedCritter.Types.FeedAction action_ = feedCritter.action_;
			if (action_ == CustomStepFeedCritter.Types.FeedAction.FavoriteItem)
			{
				if (details.Reaction != (FeedCritter.Types.CritterReaction)action_)
				{
					return;
				}
			}
			else if (feedCritter != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600872C")]
		[Cpp2IlInjected.Address(RVA = "0x1E27A10", Offset = "0x1E26410", VA = "0x181E27A10")]
		private void OnMealEaten(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason)
		{
			//Discarded unreachable code: IL_000c
			ItemFilter itemFilter = itemFilter_;
			int num = default(int);
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600872D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AC70", Offset = "0x1E29670", VA = "0x181E2AC70")]
		private void Stop()
		{
			//Discarded unreachable code: IL_03e4
			//IL_03e3: Expected O, but got I4
			if (!isStarted)
			{
				return;
			}
			isStarted = false;
			if ((long)_repeated_itemsUsed_codec != 0)
			{
				if (ItemData.stepCase_ <= AchievementItemData.StepOneofCase.PickUp)
				{
					ProfileEventDispatcher dispatcher = Dispatcher;
					ProfileEventDispatcher.FishingResultReceived value = OnFishingResultReceived;
					dispatcher.OnFishingResultReceived -= value;
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
					dispatcher2.OnCurrencyChanged -= value2;
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
					dispatcher3.OnMealCooked -= value3;
					ProfileEventDispatcher dispatcher4 = Dispatcher;
					ProfileEventDispatcher.GardeningEvent value4 = OnHarvestEvent;
					dispatcher4.OnGardeningEvent -= value4;
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.GardeningEvent value5 = OnPlantingEvent;
					dispatcher5.OnGardeningEvent -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.ItemAdded value6 = OnPickUpItemAdded;
					dispatcher6.OnItemAdded -= value6;
					ProfileEventDispatcher.GridChanged gridChanged = OnShopItemBought;
					ProfileEventDispatcher dispatcher7 = Dispatcher;
					ProfileEventDispatcher.ShopItemBought value7 = OnShopItemBought;
					dispatcher7.OnShopItemBought -= value7;
					ProfileEventDispatcher dispatcher8 = Dispatcher;
					ProfileEventDispatcher.ShopItemsSold value8 = OnShopItemsSold;
					dispatcher8.OnShopItemsSold -= value8;
					ProfileEventDispatcher dispatcher9 = Dispatcher;
					ProfileEventDispatcher.PictureTaken value9 = OnPictureTaken;
					dispatcher9.OnPictureTaken -= value9;
					ProfileEventDispatcher dispatcher10 = Dispatcher;
					ProfileEventDispatcher.AvatarCustomizationChanged value10 = OnAvatarCustomizationChanged;
					dispatcher10.OnAvatarCustomizationChanged -= value10;
					ProfileEventDispatcher.GridChanged gridChanged2 = OnItemsGivenToCharacter;
					ProfileEventDispatcher dispatcher11 = Dispatcher;
					ProfileEventDispatcher.ItemsGivenToCharacter value11 = OnItemsGivenToCharacter;
					dispatcher11.OnItemsGivenToCharacter -= value11;
					ProfileEventDispatcher dispatcher12 = Dispatcher;
					ProfileEventDispatcher.DiscussionEnded value12 = OnDiscussionEnded;
					dispatcher12.OnDiscussionEnded -= value12;
					ProfileEventDispatcher dispatcher13 = Dispatcher;
					ProfileEventDispatcher.MiningRockEmptied value13 = OnMiningMineral;
					dispatcher13.OnMiningRockEmptied -= value13;
					StopWaterPlant();
					ProfileEventDispatcher dispatcher14 = Dispatcher;
					ProfileEventDispatcher.CritterFed value14 = OnCritterFed;
					dispatcher14.OnCritterFed -= value14;
					ProfileEventDispatcher dispatcher15 = Dispatcher;
					ProfileEventDispatcher.CharacterUnlocked value15 = OnCharacterUnlocked;
					dispatcher15.OnCharacterUnlocked -= value15;
					ProfileEventDispatcher dispatcher16 = Dispatcher;
					ProfileEventDispatcher.CharacterFriendshipLevelChanged value16 = OnCharacterFriendshipLevelChanged;
					dispatcher16.OnCharacterFriendshipLevelChanged -= value16;
					ProfileEventDispatcher dispatcher17 = Dispatcher;
					ProfileEventDispatcher.BuidingUpgraded value17 = OnBuidingUpgraded;
					dispatcher17.OnBuidingUpgraded -= value17;
					ProfileEventDispatcher dispatcher18 = Dispatcher;
					ProfileEventDispatcher.PlayerLevelGained value18 = OnPlayerLevelGained;
					dispatcher18.OnPlayerLevelGained -= value18;
					ProfileEventDispatcher dispatcher19 = Dispatcher;
					ProfileEventDispatcher.BuildingUnlocked value19 = OnBuildingUnlocked;
					dispatcher19.OnBuildingUnlocked -= value19;
					ProfileEventDispatcher dispatcher20 = Dispatcher;
					ProfileEventDispatcher.BuildingBuilt value20 = OnBuildingBuilt;
					dispatcher20.OnBuildingBuilt -= value20;
					ProfileEventDispatcher dispatcher21 = Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value21 = OnVillageAreaUnlocked;
					dispatcher21.OnVillageAreaUnlocked -= value21;
					ProfileEventDispatcher dispatcher22 = Dispatcher;
					ProfileEventDispatcher.RealmUnlocked value22 = OnRealmUnlocked;
					dispatcher22.OnRealmUnlocked -= value22;
					ProfileEventDispatcher dispatcher23 = Dispatcher;
					ProfileEventDispatcher.ToolAdded value23 = OnToolAdded;
					dispatcher23.OnToolAdded -= value23;
					ProfileEventDispatcher dispatcher24 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomExpanded value24 = OnPlayerHouseRoomExpanded;
					dispatcher24.OnPlayerHouseRoomExpanded -= value24;
					ProfileEventDispatcher dispatcher25 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomAdded value25 = OnPlayerHouseRoomAdded;
					dispatcher25.OnPlayerHouseRoomAdded -= value25;
					ProfileEventDispatcher dispatcher26 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseFloorAdded value26 = OnPlayerHouseFloorAdded;
					dispatcher26.OnPlayerHouseFloorAdded -= value26;
					ProfileEventDispatcher dispatcher27 = Dispatcher;
					ProfileEventDispatcher.DutyAchRewardCollected value27 = OnDutyAchRewardCollected;
					dispatcher27.OnDutyAchRewardCollected -= value27;
					ProfileEventDispatcher dispatcher28 = Dispatcher;
					ProfileEventDispatcher.ItemRemoved value28 = OnMealEaten;
					dispatcher28.OnItemRemoved -= value28;
					ProfileEventDispatcher dispatcher29 = Dispatcher;
					ProfileEventDispatcher.GridChanged value29 = DecorateOnGridChanged;
					dispatcher29.OnGridChanged -= value29;
				}
				optionalState_ = (optionalStateCase_ = OptionalStateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600872E")]
		[Cpp2IlInjected.Address(RVA = "0x1E280E0", Offset = "0x1E26AE0", VA = "0x181E280E0")]
		private void OnPictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType)
		{
			//Discarded unreachable code: IL_00b6
			//IL_0081: Expected I4, but got O
			CustomStepTakePicture takePicture = ItemData.TakePicture;
			if (takePicture == null)
			{
				return;
			}
			OptionalField location_ = takePicture.location_;
			if (location_.useField_)
			{
				SceneType scene = location_.Scene;
			}
			CustomStepTakePicture.ItemOneofCase itemCase_ = takePicture.itemCase_;
			int num = curAmount_;
			if (itemCase_ != 0)
			{
				if (itemCase_ == CustomStepTakePicture.ItemOneofCase.TargetGroup)
				{
					int count = ((RepeatedField<T>)(object)takePicture.TargetGroup.items_).Count;
				}
				Func<int, Item> func = default(Func<int, Item>);
				if (_003C_003Ec._003C_003E9__42_0 == null)
				{
					func = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle));
				}
				List<Item> list = (List<Item>)(object)new List<T>((int)Enumerable.Select<int, Item>((IEnumerable<>)itemIds, (Func<, >)(object)func));
				List<Item> list2 = (List<Item>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
			}
			int num2 = (curAmount_ = num + 1);
			if (num != curAmount_)
			{
				int milestonePassed = 0;
				CheckMilestoneProgress((byte)milestonePassed != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600872F")]
		[Cpp2IlInjected.Address(RVA = "0x1E29BB0", Offset = "0x1E285B0", VA = "0x181E29BB0")]
		private void StartWaterPlant()
		{
			//Discarded unreachable code: IL_0059
			StopWaterPlant();
			CustomStepWaterPlant.PlantTypesOneofCase plantTypesCase_ = ItemData.WaterPlant.plantTypesCase_;
			if (plantTypesCase_ == CustomStepWaterPlant.PlantTypesOneofCase.FlowerItem)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.FlowerEvent value = OnWaterFlowerResultReceived;
				dispatcher.OnFlowerEvent += value;
				return;
			}
			while (plantTypesCase_ != CustomStepWaterPlant.PlantTypesOneofCase.CropItem)
			{
			}
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value2 = OnWaterCropResultReceived;
			dispatcher2.OnGardeningEvent += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008730")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AB90", Offset = "0x1E29590", VA = "0x181E2AB90")]
		private void StopWaterPlant()
		{
			//Discarded unreachable code: IL_0037
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value = OnWaterCropResultReceived;
			dispatcher.OnGardeningEvent -= value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.FlowerEvent value2 = OnWaterFlowerResultReceived;
			dispatcher2.OnFlowerEvent -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008731")]
		[Cpp2IlInjected.Address(RVA = "0x1E288B0", Offset = "0x1E272B0", VA = "0x181E288B0")]
		private void OnWaterCropResultReceived(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0063
			GridState gridState = gridObject.state_;
			if (gridState == null)
			{
				return;
			}
			GardenData gardenData = gridState.GardenData;
			if (gardenData != null && Enumerable.ElementAt<GardenData.Types.GardeningSlot>((IEnumerable<>)(object)gardenData.slots_, slotIndex) != null)
			{
				Item plantedSeedItem = Enumerable.ElementAt<GardenData.Types.GardeningSlot>((IEnumerable<>)(object)gridObject.state_.GardenData.slots_, slotIndex).PlantedSeedItem;
				SeedItemData seedItemData = default(SeedItemData);
				if (seedItemData != null)
				{
					Item producedItem = seedItemData.ProducedItem;
				}
				Item invalid = Item.Invalid;
				bool flag = default(bool);
				if (flag)
				{
					CheckProgress(invalid, 1);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008732")]
		[Cpp2IlInjected.Address(RVA = "0x1E28AB0", Offset = "0x1E274B0", VA = "0x181E28AB0")]
		private void OnWaterFlowerResultReceived(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry)
		{
			if (operation == FlowerOperation.Water && gridObject != null)
			{
				int itemID = gridObject.ItemID;
				ItemType itemType = default(ItemType);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (itemType == ItemType.ActivityItem && activityItemType != ActivityItemType.Flower)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008733")]
		[Cpp2IlInjected.Address(RVA = "0x1E27A70", Offset = "0x1E26470", VA = "0x181E27A70")]
		private void OnMiningMineral(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_0150
			//IL_0014: Expected O, but got I4
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			CustomStepMineMineral mineMineral = ItemData.MineMineral;
			if (mineMineral == null)
			{
				return;
			}
			HangoutWithCharacter with_ = mineMineral.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			if (Enumerable.Any<ActivityDataLocationFilter>((IEnumerable<>)(object)mineMineral.locations_) && location.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.Scene)
			{
				RepeatedField<ActivityDataLocationFilter> locations_ = mineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_0018
					int scene = x.Scene;
					int scene2 = location.Scene;
					return scene == scene2;
				};
				if (!((RepeatedField<>)(object)locations_).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate))
				{
					return;
				}
			}
			if (Enumerable.Any<ActivityDataLocationFilter>((IEnumerable<>)(object)mineMineral.locations_) && location.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
			{
				RepeatedField<ActivityDataLocationFilter> locations_2 = mineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate2 = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_001c
					VillageAreaType villageArea = x.VillageArea;
					ActivityDataLocationFilter activityDataLocationFilter = location;
					int num3 = (int)villageArea;
					VillageAreaType villageArea2 = activityDataLocationFilter.VillageArea;
					return num3 == (int)villageArea2;
				};
				if (!((RepeatedField<>)(object)locations_2).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate2))
				{
					return;
				}
			}
			if (!mineMineral.acceptMiningFailure_)
			{
				if (!success)
				{
					goto IL_0111;
				}
				if (_003C_003Ec._003C_003E9__47_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Item);
				}
				IEnumerable<ItemWithState> enumerable = default(IEnumerable<ItemWithState>);
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)enumerable);
				this.CheckProgress((List<>)(object)list);
			}
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
			goto IL_0111;
			IL_0111:
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
			dispatcher.OnItemCollectMinigameEnded += value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
			dispatcher2.OnMinigameItemsCollected += value2;
			[Cpp2IlInjected.Token(Token = "0x6008792")]
			[Cpp2IlInjected.Address(RVA = "0x15D5FC0", Offset = "0x15D49C0", VA = "0x1815D5FC0")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				int num = default(int);
				if (minigame.ID == num)
				{
					if (state_ == AchievementState.Completed)
					{
						ProfileEventDispatcher dispatcher3 = Dispatcher;
						ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
						dispatcher3.OnItemCollectMinigameEnded -= value3;
						ProfileEventDispatcher dispatcher4 = Dispatcher;
						ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
						dispatcher4.OnMinigameItemsCollected -= value4;
						throw new NullReferenceException();
					}
					RepeatedField<ItemInstance> items_ = items.items_;
					Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
					{
						//Discarded unreachable code: IL_000f
						AchievementData achievementData = this;
						Item item = x.Item;
					};
					((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6008791")]
			[Cpp2IlInjected.Address(RVA = "0x15D61F0", Offset = "0x15D4BF0", VA = "0x1815D61F0")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_004c
				int num2 = default(int);
				if (minigame.ID == num2)
				{
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value5 = MinigameStopped;
					dispatcher5.OnItemCollectMinigameEnded -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value6 = MinigameItemsCollected;
					dispatcher6.OnMinigameItemsCollected -= value6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008734")]
		[Cpp2IlInjected.Address(RVA = "0x1E272D0", Offset = "0x1E25CD0", VA = "0x181E272D0")]
		private void OnItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false)
		{
			//Discarded unreachable code: IL_0150
			//IL_0022: Expected O, but got I4
			int itemID = characterItem.ItemID;
			bool alreadyGifted2 = false;
			Item characterItem2 = (Item)itemID;
			bool flag = default(bool);
			if (flag || itemsGiven == null)
			{
				return;
			}
			int count = ((Dictionary<TKey, TValue>)(object)itemsGiven).Count;
			if (count <= 0 || count != 0)
			{
				return;
			}
			AchievementItemData itemData = ItemData;
			if (itemData == null || itemData.stepCase_ != AchievementItemData.StepOneofCase.GiftToCharacter || itemData.GiftToCharacter == null)
			{
				return;
			}
			CustomStepGiftToCharacterItem giftToCharacter = itemData.GiftToCharacter;
			Item characterItem3 = characterItem2;
			if (!giftToCharacter.IsValid(characterItem3))
			{
				return;
			}
			Func<KeyValuePair<(Item, ItemState), int>, Item> _003C_003E9__48_ = _003C_003Ec._003C_003E9__48_0;
			if (_003C_003E9__48_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<KeyValuePair<(Item, ItemState), int>, Item>((IEnumerable<>)itemsGiven, (Func<, >)(object)_003C_003E9__48_));
			if (itemData.GiftToCharacter.mustBeFavoriteThing_)
			{
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0021
					ProfileWorld world_ = Profile.world_;
					bool flag3 = default(bool);
					return (!flag3) ? flag3 : (!alreadyGifted2);
				};
				List<Item> list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list, (Func<, >)(object)func));
			}
			if (itemData.GiftToCharacter.targetItem_.itemSelectorCase_ != 0)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				if (itemFilter.GetItemsQuantity((Dictionary<, >)(object)itemsGiven, (byte)num != 0) == 0)
				{
					return;
				}
			}
			if (itemData.GiftToCharacter.useDifferentCharacter_)
			{
				RepeatedField<int> repeatedField = itemsUsed_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					RepeatedField<int> repeatedField2 = itemsUsed_;
				}
				List<Item> list3 = (List<Item>)(object)new List<T>();
			}
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008735")]
		[Cpp2IlInjected.Address(RVA = "0x1E26950", Offset = "0x1E25350", VA = "0x181E26950")]
		private void OnDiscussionEnded(Item characterItem)
		{
			//Discarded unreachable code: IL_0075
			//IL_004a: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			int itemID = characterItem.ItemID;
			AchievementItemData itemData = ItemData;
			if (itemData == null || itemData.stepCase_ != AchievementItemData.StepOneofCase.StartDiscussion || itemData.StartDiscussion == null)
			{
				return;
			}
			CustomStepStartDiscussion startDiscussion = itemData.StartDiscussion;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (itemData.StartDiscussion.useDifferentCharacter_)
			{
				bool flag2 = ((RepeatedField<T>)(object)itemsUsed_).Contains((T)itemID);
				bool flag3 = !flag2;
				if (!flag2)
				{
					((RepeatedField<T>)(object)itemsUsed_).Add((T)itemID);
				}
				if (!flag3)
				{
					return;
				}
			}
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008736")]
		[Cpp2IlInjected.Address(RVA = "0x1E27760", Offset = "0x1E26160", VA = "0x181E27760")]
		private void OnMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_0081
			//IL_0034: Expected O, but got I4
			int itemID = mealItem.ItemID;
			if (state_ == AchievementState.Completed)
			{
			}
			int num = default(int);
			if (num != 1 || ItemData.CookMeal == null)
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num2 = 0;
			int num3 = 0;
			((List<T>)(object)list).Add((T)num2);
			Func<KeyValuePair<Item, int>, (Item, ItemState)> func = default(Func<KeyValuePair<Item, int>, (Item, ItemState)>);
			if (_003C_003Ec._003C_003E9__50_0 == null)
			{
				func = (Func<KeyValuePair<Item, int>, (Item, ItemState)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num4 = 0;
					/*Error: Unexpected end of block*/;
				});
			}
			IEnumerable<KeyValuePair<Item, int>> enumerable = (IEnumerable<KeyValuePair<Item, int>>)Enumerable.Select<KeyValuePair<Item, int>, (Item, ItemState)>((IEnumerable<>)ingredients, (Func<, >)(object)func);
			((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
			List<(Item, ItemState)> list2 = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
			int milestonePassed = 0;
			CheckMilestoneProgress((byte)milestonePassed != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008737")]
		[Cpp2IlInjected.Address(RVA = "0x1E26E10", Offset = "0x1E25810", VA = "0x181E26E10")]
		private void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_0071
			if (operation != GridChangedOperation.UpdateState)
			{
				return;
			}
			GridObject gridObject2 = gridObject;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Building)
			{
				return;
			}
			GridState gridState = gridObject.state_;
			if (gridState == null)
			{
				return;
			}
			HouseData houseData = gridState.HouseData;
			if (houseData != null)
			{
				int num = 0;
				bool built_ = houseData.built_;
				Func<CharacterItemData, bool> func = (Func<CharacterItemData, bool>)(object)(Func<T, TResult>)delegate(CharacterItemData x)
				{
					//Discarded unreachable code: IL_0018
					int house = x.House;
					GridObject gridObject3 = gridObject;
					return house == gridObject3.itemID_;
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				if (Enumerable.FirstOrDefault<CharacterItemData>(enumerable, (Func<, >)(object)func) != null)
				{
					int milestonePassed = 0;
					CheckMilestoneProgress((byte)milestonePassed != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008738")]
		[Cpp2IlInjected.Address(RVA = "0x1E27F70", Offset = "0x1E26970", VA = "0x181E27F70")]
		private void OnPickUpWeed(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_0044
			if (operation != GridChangedOperation.Remove)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int itemID = gridObject.ItemID;
			bool flag = default(bool);
			if (flag)
			{
				HangoutWithCharacter with_ = ItemData.PickUp.with_;
				Profile profile = Profile;
				if (with_.CurrentHangoutCharacterIsValid(profile))
				{
					int itemID2 = gridObject.ItemID;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008739")]
		[Cpp2IlInjected.Address(RVA = "0x1E26880", Offset = "0x1E25280", VA = "0x181E26880")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			int itemID = currencyItem.ItemID;
			if (state_ == AchievementState.Completed || gained <= 0)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			if (itemFilter != null)
			{
				ItemFilterData data_ = itemFilter.data_;
				if (data_ != null)
				{
					int item_ = data_.item_;
				}
			}
			bool flag = itemID == num;
			if (num != (flag ? 1 : 0))
			{
				int milestonePassed = 0;
				CheckMilestoneProgress((byte)milestonePassed != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600873A")]
		[Cpp2IlInjected.Address(RVA = "0x1E26B90", Offset = "0x1E25590", VA = "0x181E26B90")]
		private void OnFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID)
		{
			//IL_000d: Expected O, but got I4
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			if (state_ == AchievementState.Completed)
			{
				return;
			}
			HangoutWithCharacter with_ = ItemData.CatchFish.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			if (!itemFilter_.data_.fishLocation_.useField_)
			{
			}
			bool flag = default(bool);
			if (!flag != success)
			{
				return;
			}
			if (!success)
			{
				AchievementItemData itemData = ItemData;
				if (itemData.withoutFailing_ != success)
				{
					int num = (curAmount_ = PreviousMilestone);
					if (itemData.differentTypesOnly_ != success)
					{
						((RepeatedField<T>)(object)typesCollected_).Clear();
					}
				}
				return;
			}
			ProfileEventDispatcher.MinigameEventHandler value = default(ProfileEventDispatcher.MinigameEventHandler);
			Dispatcher.OnItemCollectMinigameEnded += value;
			ProfileEventDispatcher.MinigameItemsCollected value2 = default(ProfileEventDispatcher.MinigameItemsCollected);
			Dispatcher.OnMinigameItemsCollected += value2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600873B")]
		[Cpp2IlInjected.Address(RVA = "0x1E27EE0", Offset = "0x1E268E0", VA = "0x181E27EE0")]
		private void OnPickUpItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			//Discarded unreachable code: IL_002c
			if (state_ != AchievementState.Completed)
			{
				HangoutWithCharacter with_ = ItemData.PickUp.with_;
				Profile profile = Profile;
				if (!with_.CurrentHangoutCharacterIsValid(profile))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600873C")]
		[Cpp2IlInjected.Address(RVA = "0x1E28570", Offset = "0x1E26F70", VA = "0x181E28570")]
		private void OnShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> backpackItems, IEnumerable<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_003d, IL_0043, IL_0049, IL_004f
			int num = 0;
			if (state_ == AchievementState.Completed)
			{
				return;
			}
			List<Item> list = (List<Item>)(object)new List<T>();
			int itemID = default(int);
			if (list != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0031;
					}
					num++;
				}
				Item item = default(Item);
				itemID = item.ItemID;
				num++;
				goto IL_0031;
			}
			goto IL_0038;
			IL_0031:
			itemID += itemID;
			goto IL_0038;
			IL_0038:
			if (list == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600873D")]
		[Cpp2IlInjected.Address(RVA = "0x1E28370", Offset = "0x1E26D70", VA = "0x181E28370")]
		private void OnPlantingEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0047
			if (state_ == AchievementState.Completed)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null && (long)itemFilter.data_ != 0)
			{
				Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
				SeedItemData seedItemData = default(SeedItemData);
				if (seedItemData != null)
				{
					Item producedItem = seedItemData.ProducedItem;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600873E")]
		[Cpp2IlInjected.Address(RVA = "0x1E27010", Offset = "0x1E25A10", VA = "0x181E27010")]
		private void OnHarvestEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_00d0
			//IL_000d: Expected O, but got I4
			GardeningDetail detail2 = (GardeningDetail)0;
			if (state_ == AchievementState.Completed)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter == null || (long)itemFilter.data_ == 0)
			{
				return;
			}
			HangoutWithCharacter with_ = ItemData.GardeningHarvest.with_;
			Profile profile = Profile;
			if (with_.CurrentHangoutCharacterIsValid(profile))
			{
				Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
				SeedItemData seedItemData = default(SeedItemData);
				if (seedItemData != null)
				{
					Item producedItem = seedItemData.ProducedItem;
					GardeningDetail gardeningDetail = detail2;
					ProfileEventDispatcher dispatcher = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
					dispatcher.OnItemCollectMinigameEnded += value;
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
					dispatcher2.OnMinigameItemsCollected += value2;
				}
			}
			[Cpp2IlInjected.Token(Token = "0x600879E")]
			[Cpp2IlInjected.Address(RVA = "0x15D6710", Offset = "0x15D5110", VA = "0x1815D6710")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				int num = default(int);
				int num2 = default(int);
				do
				{
					GardeningDetail gardeningDetail2 = detail2;
					if (minigame.ID != num)
					{
						return;
					}
					if (state_ != AchievementState.Completed)
					{
						RepeatedField<ItemInstance> items_ = items.items_;
						Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
						{
							//Discarded unreachable code: IL_000f
							AchievementData achievementData = this;
							Item item = x.Item;
						};
						((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
						return;
					}
				}
				while (minigame.ID != num2);
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600879D")]
			[Cpp2IlInjected.Address(RVA = "0x15D6950", Offset = "0x15D5350", VA = "0x1815D6950")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_0055
				GardeningDetail gardeningDetail3 = detail2;
				int num3 = default(int);
				if (minigame.ID == num3)
				{
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
					dispatcher3.OnItemCollectMinigameEnded -= value3;
					ProfileEventDispatcher dispatcher4 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
					dispatcher4.OnMinigameItemsCollected -= value4;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008749")]
		[Cpp2IlInjected.Address(RVA = "0x1E25670", Offset = "0x1E24070", VA = "0x181E25670")]
		public List<AchievementMilestone> GetRewardsToClaim()
		{
			//Discarded unreachable code: IL_003d
			if (ItemData.withoutFailing_)
			{
			}
			int num = curAmount_;
			int num2 = 0;
			RepeatedField<AchievementMilestone> milestones_ = ItemData.milestones_;
			Func<AchievementMilestone, bool> func = (Func<AchievementMilestone, bool>)(object)(Func<T, TResult>)delegate(AchievementMilestone x)
			{
				//Discarded unreachable code: IL_002b
				if (ItemData.withoutFailing_)
				{
				}
				int num3 = curAmount_;
				int milestone_ = x.milestone_;
				if (num3 < milestone_)
				{
					int num4 = 0;
				}
				return (long)(IntPtr)"{il2cpp field on {'constant4' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x40}" < (long)milestone_;
			};
			return (List<AchievementMilestone>)(object)Enumerable.ToList<AchievementMilestone>(Enumerable.Where<AchievementMilestone>((IEnumerable<>)(object)milestones_, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x600874A")]
		[Cpp2IlInjected.Address(RVA = "0x1E24700", Offset = "0x1E23100", VA = "0x181E24700")]
		internal void ClaimRewards(Profile profile, IPlayerEventDispatcher playerDispatcher, IWorldEventDispatcher worldDispatcher, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600874B")]
		[Cpp2IlInjected.Address(RVA = "0x1E24340", Offset = "0x1E22D40", VA = "0x181E24340")]
		private void CheckProgress(List<Item> itemsToCheck)
		{
			//Discarded unreachable code: IL_00f5, IL_00fb, IL_0101
			//IL_0054: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (itemsToCheck == null)
				{
					break;
				}
				if (itemFilter_.ApplyFilter((IEnumerable<>)itemsToCheck) == null)
				{
					break;
				}
				int prevAmount = curAmount_;
				if ((ItemData.differentTypesOnly_ ? 1 : 0) != num3)
				{
					if (flag)
					{
						if (((RepeatedField<T>)(object)typesCollected_).Contains((T)num2))
						{
							continue;
						}
						((RepeatedField<T>)(object)typesCollected_).Add((T)num2);
					}
					num3++;
					if (num3 == 0)
					{
					}
				}
				if (ItemData.withoutFailing_)
				{
					int num4 = curAmount_;
					if (maxAmount_ < num4)
					{
						maxAmount_ = num4;
					}
				}
				int num5 = curAmount_;
				if (prevAmount != num5)
				{
					List<AchievementMilestone> list = (List<AchievementMilestone>)(object)Enumerable.ToList<AchievementMilestone>((IEnumerable<>)(object)ItemData.milestones_);
					Predicate<AchievementMilestone> predicate = (Predicate<AchievementMilestone>)(object)(Predicate<T>)delegate(AchievementMilestone x)
					{
						//Discarded unreachable code: IL_0011
						int num6 = prevAmount;
						return x.milestone_ > num6;
					};
					AchievementMilestone achievementMilestone = (AchievementMilestone)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
					if (achievementMilestone != null)
					{
						int milestone_ = achievementMilestone.milestone_;
					}
					bool milestonePassed = num3 <= curAmount_;
					CheckMilestoneProgress(milestonePassed);
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600874C")]
		[Cpp2IlInjected.Address(RVA = "0x1E24230", Offset = "0x1E22C30", VA = "0x181E24230")]
		private void CheckProgress(Item item, int amount)
		{
			//Discarded unreachable code: IL_001c
			bool flag = default(bool);
			if (flag && amount > 0)
			{
				List<Item> list = (List<Item>)(object)new List<T>();
				int num = 0;
				num++;
				this.CheckProgress((List<>)(object)list);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600874D")]
		[Cpp2IlInjected.Address(RVA = "0x1E24060", Offset = "0x1E22A60", VA = "0x181E24060")]
		private void CheckMilestoneProgress(bool milestonePassed = false)
		{
			//Discarded unreachable code: IL_005d
			//IL_0030: Expected I4, but got I8
			int num = 0;
			if (ItemData == null)
			{
				return;
			}
			int lastMilestoneDisplay = LastMilestoneDisplay;
			int num2 = curAmount_;
			if (ItemData.withoutFailing_)
			{
			}
			state_ = AchievementState.Completed;
			Stop();
			if (Dispatcher != null)
			{
				int num3 = achievementID_;
				int num4 = 0;
				uint num5 = default(uint);
				if (num4 < (int)num5)
				{
					num4 += num4;
					num4++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600874E")]
		[Cpp2IlInjected.Address(RVA = "0x1E25510", Offset = "0x1E23F10", VA = "0x181E25510")]
		private string GetItemDisplayName(int itemID, Localizator localizator)
		{
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600874F")]
		[Cpp2IlInjected.Address(RVA = "0x1E28C50", Offset = "0x1E27650", VA = "0x181E28C50")]
		internal object ResolveKey(Localizator localizator, string key)
		{
			string text;
			if (localizator != null)
			{
				AchievementItemData itemData = ItemData;
				if (itemData != null && itemData == null)
				{
					text = key.ToLower();
					if (text != null)
					{
						if (text == null)
						{
							goto IL_0060;
						}
						ItemFilter itemFilter = itemFilter_;
						if (itemFilter != null)
						{
							ItemFilterData data_ = itemFilter.data_;
							if (data_ != null)
							{
								int item_ = data_.item_;
								int item_2 = itemFilter_.data_.item_;
								string text2 = default(string);
								if (text2 == null)
								{
									goto IL_0060;
								}
							}
						}
					}
				}
			}
			goto IL_008c;
			IL_008c:
			throw new NullReferenceException();
			IL_0060:
			if (text != null)
			{
				int currentMilestone = CurrentMilestone;
			}
			string text3 = default(string);
			if (text3 != null)
			{
				int lastMilestone = LastMilestone;
			}
			string text4 = default(string);
			if (text4 != null)
			{
				int claimedMilestoneIndex = ClaimedMilestoneIndex;
				claimedMilestoneIndex += 2;
			}
			goto IL_008c;
		}

		[Cpp2IlInjected.Token(Token = "0x6008753")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C650", Offset = "0x1E2B050", VA = "0x181E2C650")]
		[DebuggerNonUserCode]
		public AchievementData()
		{
			typesCollected_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			achName_ = "";
			itemsUsed_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6008754")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C4C0", Offset = "0x1E2AEC0", VA = "0x181E2C4C0")]
		[DebuggerNonUserCode]
		public AchievementData(AchievementData other)
		{
			//IL_0049: Expected O, but got I4
			//IL_00c6: Expected I4, but got O
			int num = other.achievementID_;
			int num2 = 0;
			achievementID_ = num;
			int num3 = (curAmount_ = other.curAmount_);
			int num4 = (claimedRewardMilestone_ = other.claimedRewardMilestone_);
			ItemFilter itemFilter = other.itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = itemFilter.Clone();
			}
			itemFilter_ = (ItemFilter)num2;
			AchievementState achievementState = (state_ = other.state_);
			RepeatedField<int> repeatedField = (typesCollected_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.typesCollected_).Clone());
			string text = (achName_ = other.achName_);
			RepeatedField<int> repeatedField2 = (itemsUsed_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemsUsed_).Clone());
			int num5 = (maxAmount_ = other.maxAmount_);
			if (other.optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
			{
				if (other.optionalState_ == null)
				{
					throw new InvalidCastException();
				}
				GridObjectAddressList gridObjectAddressList = default(GridObjectAddressList);
				optionalState_ = gridObjectAddressList;
				optionalStateCase_ = (OptionalStateOneofCase)gridObjectAddressList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008755")]
		[Cpp2IlInjected.Address(RVA = "0x1E24D40", Offset = "0x1E23740", VA = "0x181E24D40", Slot = "10")]
		[DebuggerNonUserCode]
		public AchievementData Clone()
		{
			return new AchievementData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008769")]
		[Cpp2IlInjected.Address(RVA = "0x1E24D20", Offset = "0x1E23720", VA = "0x181E24D20")]
		[DebuggerNonUserCode]
		public void ClearOptionalState()
		{
			//IL_0010: Expected O, but got I4
			optionalState_ = (optionalStateCase_ = OptionalStateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600876A")]
		[Cpp2IlInjected.Address(RVA = "0x1E25030", Offset = "0x1E23A30", VA = "0x181E25030", Slot = "0")]
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
				if ((IntPtr)achievementID_ == (IntPtr)typeof(AchievementData).TypeHandle && (IntPtr)curAmount_ == (IntPtr)typeof(AchievementData).TypeHandle && (IntPtr)claimedRewardMilestone_ == (IntPtr)typeof(AchievementData).TypeHandle)
				{
					bool flag = object.Equals(itemFilter_, other);
					if (flag && state_ == (flag ? AchievementState.Completed : AchievementState.OnGoing))
					{
						RepeatedField<int> repeatedField = typesCollected_;
						bool flag2 = default(bool);
						if (flag2)
						{
							string text = achName_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								RepeatedField<int> repeatedField2 = itemsUsed_;
								bool flag4 = default(bool);
								if (flag4 && maxAmount_ == (flag4 ? 1 : 0))
								{
									GridObjectAddressList objB = default(GridObjectAddressList);
									bool flag5 = object.Equals(GridObjectsCollected, objB);
									if (flag5 && optionalStateCase_ == (flag5 ? ((OptionalStateOneofCase)1) : OptionalStateOneofCase.None))
									{
										return object.Equals(_unknownFields, objB);
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

		[Cpp2IlInjected.Token(Token = "0x600876B")]
		[Cpp2IlInjected.Address(RVA = "0x1E24EC0", Offset = "0x1E238C0", VA = "0x181E24EC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AchievementData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.achievementID_;
				if (achievementID_ == num)
				{
					int num2 = other.curAmount_;
					if (curAmount_ == num2)
					{
						int num3 = other.claimedRewardMilestone_;
						if (claimedRewardMilestone_ == num3)
						{
							ItemFilter objB = other.itemFilter_;
							if (object.Equals(itemFilter_, objB))
							{
								AchievementState achievementState = other.state_;
								if (state_ == achievementState)
								{
									RepeatedField<int> repeatedField = typesCollected_;
									RepeatedField<int> repeatedField2 = other.typesCollected_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										string text = other.achName_;
										if (!(achName_ != text))
										{
											RepeatedField<int> repeatedField3 = itemsUsed_;
											RepeatedField<int> repeatedField4 = other.itemsUsed_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
											{
												int num4 = other.maxAmount_;
												if (maxAmount_ == num4)
												{
													GridObjectAddressList gridObjectsCollected = GridObjectsCollected;
													GridObjectAddressList gridObjectsCollected2 = other.GridObjectsCollected;
													if (object.Equals(gridObjectsCollected, gridObjectsCollected2))
													{
														OptionalStateOneofCase optionalStateOneofCase = other.optionalStateCase_;
														if (optionalStateCase_ == optionalStateOneofCase)
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600876C")]
		[Cpp2IlInjected.Address(RVA = "0x1E25350", Offset = "0x1E23D50", VA = "0x181E25350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b0
			int num = achievementID_;
			int num2 = 0;
			if (num != 0)
			{
			}
			if (curAmount_ != 0)
			{
			}
			if (claimedRewardMilestone_ != 0)
			{
			}
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				int hashCode = itemFilter.GetHashCode();
			}
			if (state_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)typesCollected_).GetHashCode();
			string text = achName_;
			if (text.m_stringLength != num2)
			{
				int hashCode3 = text.GetHashCode();
			}
			int hashCode4 = ((RepeatedField<T>)(object)itemsUsed_).GetHashCode();
			if (maxAmount_ != 0)
			{
			}
			if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
			{
				object obj = optionalState_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode5 = obj.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600876D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B8C0", Offset = "0x1E2A2C0", VA = "0x181E2B8C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600876E")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C0A0", Offset = "0x1E2AAA0", VA = "0x181E2C0A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_010c
			if (achievementID_ != 0)
			{
				int value = achievementID_;
				output.WriteInt32(value);
			}
			if (curAmount_ != 0)
			{
				int value2 = curAmount_;
				output.WriteInt32(value2);
			}
			if (claimedRewardMilestone_ != 0)
			{
				int value3 = claimedRewardMilestone_;
				output.WriteInt32(value3);
			}
			if ((long)itemFilter_ != 0)
			{
				ItemFilter value4 = itemFilter_;
				output.WriteMessage(value4);
			}
			if (state_ != 0)
			{
			}
			RepeatedField<int> repeatedField = typesCollected_;
			FieldCodec<int> repeated_typesCollected_codec = _repeated_typesCollected_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_typesCollected_codec);
			if (achName_.m_stringLength != 0)
			{
				string value5 = achName_;
				output.WriteString(value5);
			}
			RepeatedField<int> repeatedField2 = itemsUsed_;
			FieldCodec<int> repeated_itemsUsed_codec = _repeated_itemsUsed_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemsUsed_codec);
			if (maxAmount_ != 0)
			{
				int value6 = maxAmount_;
				output.WriteInt32(value6);
			}
			if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected && optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
			{
				object obj = optionalState_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600876F")]
		[Cpp2IlInjected.Address(RVA = "0x1E232C0", Offset = "0x1E21CC0", VA = "0x181E232C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0166
			int num = achievementID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = curAmount_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			int num6 = claimedRewardMilestone_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(itemFilter);
				num8++;
				num2 += num8;
			}
			AchievementState achievementState = state_;
			if (achievementState != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)achievementState);
				num9++;
				num2 += num9;
			}
			RepeatedField<int> repeatedField = typesCollected_;
			FieldCodec<int> repeated_typesCollected_codec = _repeated_typesCollected_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_typesCollected_codec);
			string text = achName_;
			num2 += num10;
			if (text.m_stringLength != num2)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text);
				num11++;
				num2 += num11;
			}
			RepeatedField<int> repeatedField2 = itemsUsed_;
			FieldCodec<int> repeated_itemsUsed_codec = _repeated_itemsUsed_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemsUsed_codec);
			int num13 = maxAmount_;
			num2 += num12;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
			{
				if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
				{
					object obj = optionalState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
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

		[Cpp2IlInjected.Token(Token = "0x6008770")]
		[Cpp2IlInjected.Address(RVA = "0x1E263F0", Offset = "0x1E24DF0", VA = "0x181E263F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementData other)
		{
			//Discarded unreachable code: IL_01a4
			ItemFilter itemFilter2 = default(ItemFilter);
			object obj = default(object);
			GridObjectAddressList gridObjectAddressList = default(GridObjectAddressList);
			while (true)
			{
				if (other == null)
				{
					return;
				}
				int num = other.achievementID_;
				if (num != 0)
				{
					achievementID_ = num;
				}
				int num2 = other.curAmount_;
				if (num2 != 0)
				{
					curAmount_ = num2;
				}
				int num3 = other.claimedRewardMilestone_;
				if (num3 != 0)
				{
					claimedRewardMilestone_ = num3;
				}
				if ((long)other.itemFilter_ != 0)
				{
					if (itemFilter_ == null)
					{
						ItemFilter itemFilter = (itemFilter_ = new ItemFilter());
						itemFilter2 = itemFilter_;
					}
					ItemFilter other2 = other.itemFilter_;
					itemFilter2.MergeFrom(other2);
				}
				AchievementState achievementState = other.state_;
				if (achievementState != 0)
				{
					state_ = achievementState;
				}
				RepeatedField<int> repeatedField = typesCollected_;
				RepeatedField<int> repeatedField2 = other.typesCollected_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text = other.achName_;
				if (text.m_stringLength != 0)
				{
					AchName = text;
				}
				RepeatedField<int> repeatedField3 = itemsUsed_;
				RepeatedField<int> repeatedField4 = other.itemsUsed_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				int num4 = other.maxAmount_;
				if (num4 != 0)
				{
					maxAmount_ = num4;
				}
				if (other.optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
				{
					if (num4 == 0)
					{
					}
					OptionalStateOneofCase optionalStateOneofCase = optionalStateCase_;
					if (optionalStateOneofCase == OptionalStateOneofCase.GridObjectsCollected)
					{
						obj = optionalState_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					if (obj == null)
					{
						gridObjectAddressList = (GridObjectAddressList)(optionalState_ = new GridObjectAddressList());
						optionalStateCase_ = optionalStateOneofCase;
					}
					if (gridObjectAddressList != null)
					{
						continue;
					}
					if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
					{
						object obj2 = optionalState_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					if (1L == 0L)
					{
					}
					if (other.optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
					{
						object obj3 = other.optionalState_;
						if (obj3 != null && obj3 == null)
						{
							break;
						}
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008771")]
		[Cpp2IlInjected.Address(RVA = "0x1E260A0", Offset = "0x1E24AA0", VA = "0x181E260A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0089: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 48)
			{
				goto IL_00cc;
			}
			if ((int)num > 64)
			{
				if (num == 66)
				{
					goto IL_00b3;
				}
				if (num == 72)
				{
					int num2 = (maxAmount_ = input.ReadInt32());
				}
				if (num != 82)
				{
					goto IL_0178;
				}
				GridObjectAddressList builder = new GridObjectAddressList();
				if (optionalStateCase_ == OptionalStateOneofCase.GridObjectsCollected)
				{
					if (optionalStateCase_ != OptionalStateOneofCase.GridObjectsCollected)
					{
					}
					object obj = optionalState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				optionalState_ = builder;
				optionalStateCase_ = (OptionalStateOneofCase)typeof(GridObjectAddressList).TypeHandle;
			}
			if (num == 50)
			{
				goto IL_011e;
			}
			string text2 = default(string);
			if (num == 58)
			{
				text2 = (AchName = input.ReadString());
			}
			if ((long)text2 == 64)
			{
				goto IL_00b3;
			}
			goto IL_0178;
			IL_00cc:
			if ((int)num <= 24)
			{
				goto IL_0137;
			}
			ItemFilter itemFilter = default(ItemFilter);
			if (num == 34)
			{
				ItemFilter builder2 = default(ItemFilter);
				if (itemFilter_ == null)
				{
					itemFilter = (itemFilter_ = new ItemFilter());
					builder2 = itemFilter_;
				}
				input.ReadMessage(builder2);
			}
			int num3 = default(int);
			if ((long)itemFilter == 40)
			{
				num3 = (int)(state_ = (AchievementState)input.ReadInt32());
			}
			if (num3 == 48)
			{
				goto IL_011e;
			}
			goto IL_0178;
			IL_011e:
			RepeatedField<int> repeatedField = typesCollected_;
			FieldCodec<int> repeated_typesCollected_codec = _repeated_typesCollected_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_typesCollected_codec);
			goto IL_0137;
			IL_0178:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_00b3:
			RepeatedField<int> repeatedField2 = itemsUsed_;
			FieldCodec<int> repeated_itemsUsed_codec = _repeated_itemsUsed_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsUsed_codec);
			goto IL_00cc;
			IL_0137:
			int num4 = default(int);
			if (num3 == 8)
			{
				num4 = (achievementID_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num4 == 16)
			{
				num5 = (curAmount_ = input.ReadInt32());
			}
			if (num5 == 24)
			{
				int num6 = (claimedRewardMilestone_ = input.ReadInt32());
			}
			goto IL_0178;
		}

		[Cpp2IlInjected.Token(Token = "0x6008772")]
		[Cpp2IlInjected.Address(RVA = "0x1E251E0", Offset = "0x1E23BE0", VA = "0x181E251E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = achievementID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008773")]
		[Cpp2IlInjected.Address(RVA = "0x1E28F30", Offset = "0x1E27930", VA = "0x181E28F30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_001b
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				achievementID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008774")]
		[Cpp2IlInjected.Address(RVA = "0x1E24B50", Offset = "0x1E23550", VA = "0x181E24B50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_001b, IL_0025, IL_003a, IL_004e, IL_005a, IL_006e
			//IL_002e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			if (fieldNumber - 1 <= 9)
			{
				int num = (achievementID_ = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008775")]
		[Cpp2IlInjected.Address(RVA = "0x1E255B0", Offset = "0x1E23FB0", VA = "0x181E255B0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "OptionalState"))
			{
				OptionalStateOneofCase optionalStateOneofCase = optionalStateCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008776")]
		[Cpp2IlInjected.Address(RVA = "0x1E24CB0", Offset = "0x1E236B0", VA = "0x181E24CB0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "OptionalState"))
			{
				optionalState_ = (optionalStateCase_ = OptionalStateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008777")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C360", Offset = "0x1E2AD60", VA = "0x181E2C360")]
		static AchievementData()
		{
			_parser = (MessageParser<AchievementData>)(object)FieldCodec.ForInt32(50u);
			_parser = (MessageParser<AchievementData>)(object)FieldCodec.ForInt32(66u);
			/*Error: Unexpected end of block*/;
		}
	}
}
