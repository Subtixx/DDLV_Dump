using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001030")]
	public sealed class MissionSlot : IMessage<MissionSlot>, IMessage, IEquatable<MissionSlot>, IDeepCloneable<MissionSlot>, IMessageFieldAccessor, IMissionIdentifier
	{
		[Cpp2IlInjected.Token(Token = "0x2001031")]
		private struct MissionSlotInitScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40042D3")]
			private MissionSlot Slot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40042D4")]
			private readonly bool ApplyAutoStart;

			[Cpp2IlInjected.Token(Token = "0x60083D6")]
			[Cpp2IlInjected.Address(RVA = "0x12F4740", Offset = "0x12F3140", VA = "0x1812F4740")]
			public MissionSlotInitScope(MissionSlot slot, bool applyAutoStart)
			{
				Slot = slot;
				ApplyAutoStart = applyAutoStart;
				int _003CInitScopeCounter_003Ek__BackingField = InitScopeCounter;
				_003CInitScopeCounter_003Ek__BackingField = (InitScopeCounter = _003CInitScopeCounter_003Ek__BackingField + 1);
			}

			[Cpp2IlInjected.Token(Token = "0x60083D7")]
			[Cpp2IlInjected.Address(RVA = "0x12F4530", Offset = "0x12F2F30", VA = "0x1812F4530", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0025
				//IL_0024: Expected O, but got I4
				int num = 0;
				num += num;
				num++;
				InitScopeCounter = InitScopeCounter;
				if ((ApplyAutoStart ? 1 : 0) != num)
				{
				}
				Slot = (MissionSlot)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40042A1")]
		private static readonly MessageParser<MissionSlot> _parser = (MessageParser<MissionSlot>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionSlot()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40042A2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40042A3")]
		public const int CharacterIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40042A4")]
		private int characterId_;

		[Cpp2IlInjected.Token(Token = "0x40042A5")]
		public const int MissionIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40042A6")]
		private int missionId_;

		[Cpp2IlInjected.Token(Token = "0x40042A7")]
		public const int CurrentStepIndexFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40042A8")]
		private int currentStepIndex_;

		[Cpp2IlInjected.Token(Token = "0x40042A9")]
		public const int MissionStepsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40042AA")]
		private static readonly FieldCodec<MissionStep> _repeated_missionSteps_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40042AB")]
		private readonly RepeatedField<MissionStep> missionSteps_ = (RepeatedField<MissionStep>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40042AC")]
		public const int MissionChoiceFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40042AD")]
		private MissionChoice missionChoice_;

		[Cpp2IlInjected.Token(Token = "0x40042AE")]
		public const int MissionNextChoiceFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40042AF")]
		private MissionChoice missionNextChoice_;

		[Cpp2IlInjected.Token(Token = "0x40042B0")]
		public const int MissionVariablesFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40042B1")]
		private static readonly MapField<int, MissionVariableList>.Codec _map_missionVariables_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40042B2")]
		private readonly MapField<int, MissionVariableList> missionVariables_ = (MapField<int, MissionVariableList>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40042B3")]
		public const int ItemsToGiveFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x40042B4")]
		private static readonly FieldCodec<ItemFilterData> _repeated_itemsToGive_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40042B5")]
		private readonly RepeatedField<ItemFilterData> itemsToGive_ = (RepeatedField<ItemFilterData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40042B6")]
		public const int ItemsToGiveAmountFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x40042B7")]
		private static readonly FieldCodec<int> _repeated_itemsToGiveAmount_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40042B8")]
		private readonly RepeatedField<int> itemsToGiveAmount_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40042B9")]
		public const int SlotIdFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40042BA")]
		private int slotId_;

		[Cpp2IlInjected.Token(Token = "0x40042BB")]
		public const int ClassFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40042BC")]
		private MissionSlotClass class_;

		[Cpp2IlInjected.Token(Token = "0x40042BD")]
		public const int StateFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40042BE")]
		private MissionSlotState state_;

		[Cpp2IlInjected.Token(Token = "0x40042BF")]
		public const int ExpirationTimeFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40042C0")]
		private Timestamp expirationTime_;

		[Cpp2IlInjected.Token(Token = "0x40042C1")]
		public const int StartTimeFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40042C2")]
		private Timestamp startTime_;

		[Cpp2IlInjected.Token(Token = "0x40042C3")]
		public const int EndTimeFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40042C4")]
		private Timestamp endTime_;

		[Cpp2IlInjected.Token(Token = "0x40042C5")]
		public const int RewardsFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40042C6")]
		private MultiReward rewards_;

		[Cpp2IlInjected.Token(Token = "0x40042C7")]
		public const int RewardPresentsFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40042C8")]
		private MultiReward rewardPresents_;

		[Cpp2IlInjected.Token(Token = "0x40042C9")]
		public const int AdditionalRewardsFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40042CA")]
		private MultiReward additionalRewards_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40042CB")]
		private MissionSlotStringResolver _stringResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40042CC")]
		public bool MissionAccepted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x40042CD")]
		private bool Started;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40042CE")]
		private Profile Profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40042CF")]
		private ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40042D0")]
		private ITransactionContext Context;

		[Cpp2IlInjected.Token(Token = "0x40042D2")]
		private static readonly Item RewardPresentItem;

		[Cpp2IlInjected.Token(Token = "0x170016C0")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionSlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008343")]
			[Cpp2IlInjected.Address(RVA = "0x1A633E0", Offset = "0x1A61DE0", VA = "0x181A633E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008344")]
			[Cpp2IlInjected.Address(RVA = "0x1A62C00", Offset = "0x1A61600", VA = "0x181A62C00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008345")]
			[Cpp2IlInjected.Address(RVA = "0x1A63440", Offset = "0x1A61E40", VA = "0x181A63440", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C3")]
		[DebuggerNonUserCode]
		public int CharacterId
		{
			[Cpp2IlInjected.Token(Token = "0x6008349")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return characterId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600834A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				characterId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C4")]
		[DebuggerNonUserCode]
		public int MissionId
		{
			[Cpp2IlInjected.Token(Token = "0x600834B")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return missionId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600834C")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				missionId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C5")]
		[DebuggerNonUserCode]
		public int CurrentStepIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600834D")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return currentStepIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600834E")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				currentStepIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C6")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionStep> MissionSteps
		{
			[Cpp2IlInjected.Token(Token = "0x600834F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return missionSteps_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C7")]
		[DebuggerNonUserCode]
		public MissionChoice MissionChoice
		{
			[Cpp2IlInjected.Token(Token = "0x6008350")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return missionChoice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008351")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				missionChoice_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C8")]
		[DebuggerNonUserCode]
		public MissionChoice MissionNextChoice
		{
			[Cpp2IlInjected.Token(Token = "0x6008352")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return missionNextChoice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008353")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				missionNextChoice_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C9")]
		[DebuggerNonUserCode]
		public MapField<int, MissionVariableList> MissionVariables
		{
			[Cpp2IlInjected.Token(Token = "0x6008354")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return missionVariables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CA")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemFilterData> ItemsToGive
		{
			[Cpp2IlInjected.Token(Token = "0x6008355")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return itemsToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CB")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemsToGiveAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008356")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return itemsToGiveAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CC")]
		[DebuggerNonUserCode]
		public int SlotId
		{
			[Cpp2IlInjected.Token(Token = "0x6008357")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return slotId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008358")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				slotId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CD")]
		[DebuggerNonUserCode]
		public MissionSlotClass Class
		{
			[Cpp2IlInjected.Token(Token = "0x6008359")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return class_;
			}
			[Cpp2IlInjected.Token(Token = "0x600835A")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				class_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CE")]
		[DebuggerNonUserCode]
		public MissionSlotState State
		{
			[Cpp2IlInjected.Token(Token = "0x600835B")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x600835C")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CF")]
		[DebuggerNonUserCode]
		public Timestamp ExpirationTime
		{
			[Cpp2IlInjected.Token(Token = "0x600835D")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return expirationTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x600835E")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				expirationTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D0")]
		[DebuggerNonUserCode]
		public Timestamp StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x600835F")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return startTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008360")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				startTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D1")]
		[DebuggerNonUserCode]
		public Timestamp EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6008361")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return endTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008362")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				endTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D2")]
		[DebuggerNonUserCode]
		public MultiReward Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x6008363")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return rewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008364")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				rewards_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D3")]
		[DebuggerNonUserCode]
		public MultiReward RewardPresents
		{
			[Cpp2IlInjected.Token(Token = "0x6008365")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return rewardPresents_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008366")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D4")]
		[DebuggerNonUserCode]
		public MultiReward AdditionalRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6008367")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return additionalRewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008368")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			set
			{
				additionalRewards_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D5")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6008374")]
			[Cpp2IlInjected.Address(RVA = "0x1A629F0", Offset = "0x1A613F0", VA = "0x181A629F0")]
			get
			{
				long num = Convert.ToInt64((uint)characterId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D6")]
		IMissionIdentifier IMissionIdentifier.IdentifierParent
		{
			[Cpp2IlInjected.Token(Token = "0x6008376")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "15")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D7")]
		int IMissionIdentifier.IdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x6008377")]
			[Cpp2IlInjected.Address(RVA = "0x1A5BDA0", Offset = "0x1A5A7A0", VA = "0x181A5BDA0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.iD_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D8")]
		string IMissionIdentifier.IdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x6008378")]
			[Cpp2IlInjected.Address(RVA = "0x1A5BDC0", Offset = "0x1A5A7C0", VA = "0x181A5BDC0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.name_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D9")]
		public string FullIdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x6008379")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CE0", Offset = "0x1A616E0", VA = "0x181A62CE0", Slot = "19")]
			get
			{
				return MissionIdentifier.GetFullIdentifierName(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DA")]
		public string FullIdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x600837A")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CD0", Offset = "0x1A616D0", VA = "0x181A62CD0", Slot = "18")]
			get
			{
				return MissionIdentifier.GetFullIdentifierID(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DB")]
		public IEnumerable<MissionObjective> AllStepsObjectives
		{
			[Cpp2IlInjected.Token(Token = "0x600837C")]
			[Cpp2IlInjected.Address(RVA = "0x1A62790", Offset = "0x1A61190", VA = "0x181A62790")]
			get
			{
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				Func<MissionStep, IEnumerable<MissionObjective>> _003C_003E9__129_ = _003C_003Ec._003C_003E9__129_0;
				if (_003C_003E9__129_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStep x) => (IEnumerable<MissionObjective>)x.get_AllObjectives());
				}
				return (IEnumerable<MissionObjective>)Enumerable.SelectMany<MissionStep, MissionObjective>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__129_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DC")]
		public IEnumerable<MissionSubStep> AllSubSteps
		{
			[Cpp2IlInjected.Token(Token = "0x600837D")]
			[Cpp2IlInjected.Address(RVA = "0x1A628C0", Offset = "0x1A612C0", VA = "0x181A628C0")]
			get
			{
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				Func<MissionStep, IEnumerable<MissionSubStep>> _003C_003E9__131_ = _003C_003Ec._003C_003E9__131_0;
				if (_003C_003E9__131_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionStep x)
					{
						RepeatedField<MissionSubStep> subSteps_ = x.subSteps_;
						throw new NullReferenceException();
					};
				}
				return (IEnumerable<MissionSubStep>)Enumerable.SelectMany<MissionStep, MissionSubStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__131_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DD")]
		public string OutroDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x600837F")]
			[Cpp2IlInjected.Address(RVA = "0x1A63080", Offset = "0x1A61A80", VA = "0x181A63080")]
			get
			{
				if (Data.completedCase_ != MissionItemData.CompletedOneofCase.Any && Data.completedCase_ != MissionItemData.CompletedOneofCase.NoOutro)
				{
					if (missionChoice_ != 0)
					{
						int num = 0;
						MessageDescriptor descriptor = MissionItemData.Types.CompletedDescriptionDialogueChoices.Descriptor;
						MissionChoice missionChoice = missionChoice_;
						string name = descriptor.ToString();
						MessageDescriptor messageDescriptor = descriptor;
						IFieldAccessor accessor = descriptor.FindFieldByName(name).accessor;
						MissionItemData.Types.CompletedDescriptionDialogue choice2_ = Data.Choices.choice2_;
					}
					MissionItemData.Types.CompletedDescriptionDialogueChoices choices = Data.Choices;
				}
				MissionItemData.Types.CompletedDescriptionDialogue any = Data.Any;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DE")]
		public ItemFilterData ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6008380")]
			[Cpp2IlInjected.Address(RVA = "0x1A62F80", Offset = "0x1A61980", VA = "0x181A62F80")]
			get
			{
				MissionStep currentStep = CurrentStep;
				if (currentStep != null)
				{
					MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(currentStep.get_AllObjectives());
					if (missionObjective != null)
					{
						ItemFilter itemFilter_ = missionObjective.itemFilter_;
						if (itemFilter_ != null)
						{
							return itemFilter_.data_;
						}
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DF")]
		public string OngoingDialog
		{
			[Cpp2IlInjected.Token(Token = "0x6008383")]
			[Cpp2IlInjected.Address(RVA = "0x1A63050", Offset = "0x1A61A50", VA = "0x181A63050")]
			get
			{
				//Discarded unreachable code: IL_0011
				return CurrentStep.Data.ongoingDialogue_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E0")]
		public bool IsMissionEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6008384")]
			[Cpp2IlInjected.Address(RVA = "0xF87740", Offset = "0xF86140", VA = "0x180F87740")]
			get
			{
				return state_ == MissionSlotState.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E1")]
		public bool IsMissionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6008385")]
			[Cpp2IlInjected.Address(RVA = "0x1A62E00", Offset = "0x1A61800", VA = "0x181A62E00")]
			get
			{
				return state_ != MissionSlotState.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E2")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6008386")]
			[Cpp2IlInjected.Address(RVA = "0x1A62E20", Offset = "0x1A61820", VA = "0x181A62E20")]
			get
			{
				if (state_ != 0)
				{
					long num = Convert.ToInt64((uint)missionId_);
					bool flag = default(bool);
					if (flag)
					{
						long num2 = Convert.ToInt64((uint)characterId_);
						bool result = default(bool);
						return result;
					}
				}
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E3")]
		public bool IsMissionActiveButIncompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6008387")]
			[Cpp2IlInjected.Address(RVA = "0x1A62DF0", Offset = "0x1A617F0", VA = "0x181A62DF0")]
			get
			{
				MissionSlotState missionSlotState = state_;
				if (missionSlotState == MissionSlotState.Invalid)
				{
				}
				return missionSlotState != MissionSlotState.Completed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E4")]
		public bool IsMissionStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6008388")]
			[Cpp2IlInjected.Address(RVA = "0x1A62E10", Offset = "0x1A61810", VA = "0x181A62E10")]
			get
			{
				return state_ > MissionSlotState.Available;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E5")]
		public bool OwnerInactive
		{
			[Cpp2IlInjected.Token(Token = "0x600838A")]
			[Cpp2IlInjected.Address(RVA = "0x1A63270", Offset = "0x1A61C70", VA = "0x181A63270")]
			get
			{
				long num = Convert.ToInt64((uint)characterId_);
				bool flag = default(bool);
				if (flag)
				{
					ProfileWorld world_ = Profile.world_;
					long num2 = Convert.ToInt64((uint)characterId_);
					bool flag2 = default(bool);
					bool result = default(bool);
					if (flag2)
					{
						return result;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E6")]
		public MissionItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x600838B")]
			[Cpp2IlInjected.Address(RVA = "0x1A62AE0", Offset = "0x1A614E0", VA = "0x181A62AE0")]
			get
			{
				//Discarded unreachable code: IL_0014
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)missionId_);
				MissionItemData result = default(MissionItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E7")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600838C")]
			[Cpp2IlInjected.Address(RVA = "0x1A62FF0", Offset = "0x1A619F0", VA = "0x181A62FF0")]
			get
			{
				long num = Convert.ToInt64((uint)missionId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E8")]
		public MissionStep CurrentStep
		{
			[Cpp2IlInjected.Token(Token = "0x600838D")]
			[Cpp2IlInjected.Address(RVA = "0x1A62A50", Offset = "0x1A61450", VA = "0x181A62A50")]
			get
			{
				int num = currentStepIndex_;
				int count = ((RepeatedField<T>)(object)missionSteps_).Count;
				if (num < count)
				{
					RepeatedField<MissionStep> repeatedField = missionSteps_;
					int index = currentStepIndex_;
					return (MissionStep)((RepeatedField<T>)(object)repeatedField)[index];
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E9")]
		private IWorldEventDispatcher WorldDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x600838E")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016EA")]
		public static bool InInitScopeCounter
		{
			[Cpp2IlInjected.Token(Token = "0x600838F")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CF0", Offset = "0x1A616F0", VA = "0x181A62CF0")]
			get
			{
				return (long)"{il2cpp field on {'constant19' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x28}" > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016EB")]
		[field: Cpp2IlInjected.Token(Token = "0x40042D1")]
		public static int InitScopeCounter
		{
			[Cpp2IlInjected.Token(Token = "0x6008390")]
			[Cpp2IlInjected.Address(RVA = "0x1A62D90", Offset = "0x1A61790", VA = "0x181A62D90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008391")]
			[Cpp2IlInjected.Address(RVA = "0x1A63550", Offset = "0x1A61F50", VA = "0x181A63550")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170016EC")]
		internal IEnumerable<IMissionIdentifier> AllMissionIdentifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60083BD")]
			[Cpp2IlInjected.Address(RVA = "0x1A625D0", Offset = "0x1A60FD0", VA = "0x181A625D0")]
			get
			{
				IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Empty<IMissionIdentifier>();
				IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)this.get_AllStepsObjectives();
				IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Concat<IMissionIdentifier>((IEnumerable<>)enumerable, (IEnumerable<>)allStepsObjectives);
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				Func<MissionStep, IEnumerable<MissionSubStep>> _003C_003E9__131_ = _003C_003Ec._003C_003E9__131_0;
				if (_003C_003E9__131_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionStep x)
					{
						RepeatedField<MissionSubStep> subSteps_ = x.subSteps_;
						throw new NullReferenceException();
					};
				}
				IEnumerable<MissionStep> enumerable3 = (IEnumerable<MissionStep>)Enumerable.SelectMany<MissionStep, MissionSubStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__131_);
				IEnumerable<IMissionIdentifier> enumerable4 = (IEnumerable<IMissionIdentifier>)Enumerable.Concat<IMissionIdentifier>((IEnumerable<>)enumerable2, (IEnumerable<>)enumerable3);
				RepeatedField<MissionStep> repeatedField2 = missionSteps_;
				return (IEnumerable<IMissionIdentifier>)Enumerable.Concat<IMissionIdentifier>((IEnumerable<>)enumerable4, (IEnumerable<>)(object)repeatedField2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008346")]
		[Cpp2IlInjected.Address(RVA = "0x1A620E0", Offset = "0x1A60AE0", VA = "0x181A620E0")]
		[DebuggerNonUserCode]
		public MissionSlot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008347")]
		[Cpp2IlInjected.Address(RVA = "0x1A62230", Offset = "0x1A60C30", VA = "0x181A62230")]
		[DebuggerNonUserCode]
		public MissionSlot(MissionSlot other)
		{
			//IL_012f: Expected O, but got I4
			//IL_014d: Expected O, but got I4
			//IL_016b: Expected O, but got I4
			//IL_0189: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			int num = (characterId_ = other.characterId_);
			int num2 = (missionId_ = other.missionId_);
			int num3 = (currentStepIndex_ = other.currentStepIndex_);
			RepeatedField<MissionStep> repeatedField = (missionSteps_ = (RepeatedField<MissionStep>)(object)((RepeatedField<T>)(object)other.missionSteps_).Clone());
			MissionChoice missionChoice = (missionChoice_ = other.missionChoice_);
			MissionChoice missionChoice2 = (missionNextChoice_ = other.missionNextChoice_);
			MapField<int, MissionVariableList> mapField = (missionVariables_ = (MapField<int, MissionVariableList>)(object)((MapField<TKey, TValue>)(object)other.missionVariables_).Clone());
			RepeatedField<ItemFilterData> repeatedField2 = (itemsToGive_ = (RepeatedField<ItemFilterData>)(object)((RepeatedField<T>)(object)other.itemsToGive_).Clone());
			RepeatedField<int> repeatedField3 = (itemsToGiveAmount_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemsToGiveAmount_).Clone());
			int num4 = other.slotId_;
			int num5 = 0;
			slotId_ = num4;
			MissionSlotClass missionSlotClass = (class_ = other.class_);
			MissionSlotState missionSlotState = (state_ = other.state_);
			Timestamp timestamp = other.expirationTime_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			expirationTime_ = (Timestamp)num5;
			Timestamp timestamp3 = other.startTime_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			startTime_ = (Timestamp)num5;
			Timestamp timestamp5 = other.endTime_;
			if (timestamp5 != null)
			{
				Timestamp timestamp6 = timestamp5.Clone();
			}
			endTime_ = (Timestamp)num5;
			MultiReward multiReward = other.rewards_;
			if (multiReward != null)
			{
				MultiReward multiReward2 = multiReward.Clone();
			}
			rewards_ = (MultiReward)num5;
			MultiReward multiReward3 = other.rewardPresents_;
			if (multiReward3 != null)
			{
				MultiReward multiReward4 = multiReward3.Clone();
			}
			rewardPresents_ = (MultiReward)num5;
			MultiReward multiReward5 = other.additionalRewards_;
			MultiReward multiReward6 = default(MultiReward);
			if (multiReward5 != null)
			{
				multiReward6 = multiReward5.Clone();
			}
			additionalRewards_ = multiReward6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008348")]
		[Cpp2IlInjected.Address(RVA = "0x1A567B0", Offset = "0x1A551B0", VA = "0x181A567B0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionSlot Clone()
		{
			return new MissionSlot(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008369")]
		[Cpp2IlInjected.Address(RVA = "0x1A57E90", Offset = "0x1A56890", VA = "0x181A57E90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MissionSlot)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600836A")]
		[Cpp2IlInjected.Address(RVA = "0x1A57C70", Offset = "0x1A56670", VA = "0x181A57C70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionSlot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.characterId_;
				if ((IntPtr)_repeated_itemsToGive_codec == (IntPtr)num)
				{
					int num2 = other.missionId_;
					if (missionId_ == num2)
					{
						int num3 = other.currentStepIndex_;
						if (currentStepIndex_ == num3)
						{
							RepeatedField<MissionStep> repeatedField = missionSteps_;
							RepeatedField<MissionStep> repeatedField2 = other.missionSteps_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
							{
								MissionChoice missionChoice = other.missionChoice_;
								if (missionChoice_ == missionChoice)
								{
									MissionChoice missionChoice2 = other.missionNextChoice_;
									if (missionNextChoice_ == missionChoice2)
									{
										MapField<int, MissionVariableList> mapField = missionVariables_;
										MapField<int, MissionVariableList> mapField2 = other.missionVariables_;
										if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
										{
											RepeatedField<ItemFilterData> repeatedField3 = itemsToGive_;
											RepeatedField<ItemFilterData> repeatedField4 = other.itemsToGive_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
											{
												RepeatedField<int> repeatedField5 = itemsToGiveAmount_;
												RepeatedField<int> repeatedField6 = other.itemsToGiveAmount_;
												if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
												{
													int num4 = other.slotId_;
													if (slotId_ == num4)
													{
														MissionSlotClass missionSlotClass = other.class_;
														if (class_ == missionSlotClass)
														{
															MissionSlotState missionSlotState = other.state_;
															if (state_ == missionSlotState)
															{
																Timestamp objB = other.expirationTime_;
																if (object.Equals(expirationTime_, objB))
																{
																	Timestamp objB2 = other.startTime_;
																	if (object.Equals(startTime_, objB2))
																	{
																		Timestamp objB3 = other.endTime_;
																		if (object.Equals(endTime_, objB3))
																		{
																			MultiReward objB4 = other.rewards_;
																			if (object.Equals(rewards_, objB4))
																			{
																				MultiReward objB5 = other.rewardPresents_;
																				if (object.Equals(rewardPresents_, objB5))
																				{
																					MultiReward objB6 = other.additionalRewards_;
																					if (object.Equals(additionalRewards_, objB6))
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600836B")]
		[Cpp2IlInjected.Address(RVA = "0x1A58CD0", Offset = "0x1A576D0", VA = "0x181A58CD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_011c
			int num = 0;
			if (characterId_ != 0)
			{
			}
			if (missionId_ != 0)
			{
			}
			if (currentStepIndex_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)missionSteps_).GetHashCode();
			if (missionChoice_ != 0)
			{
			}
			if (missionNextChoice_ != 0)
			{
			}
			int hashCode2 = ((MapField<TKey, TValue>)(object)missionVariables_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)itemsToGive_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)itemsToGiveAmount_).GetHashCode();
			if (slotId_ != 0)
			{
			}
			if (class_ != 0)
			{
			}
			if (state_ != 0)
			{
			}
			Timestamp timestamp = expirationTime_;
			if (timestamp != null)
			{
				int hashCode5 = timestamp.GetHashCode();
			}
			Timestamp timestamp2 = startTime_;
			if (timestamp2 != null)
			{
				int hashCode6 = timestamp2.GetHashCode();
			}
			Timestamp timestamp3 = endTime_;
			if (timestamp3 != null)
			{
				int hashCode7 = timestamp3.GetHashCode();
			}
			MultiReward multiReward = rewards_;
			if (multiReward != null)
			{
				int hashCode8 = multiReward.GetHashCode();
			}
			MultiReward multiReward2 = rewardPresents_;
			if (multiReward2 != null)
			{
				int hashCode9 = multiReward2.GetHashCode();
			}
			MultiReward multiReward3 = additionalRewards_;
			if (multiReward3 != null)
			{
				int hashCode10 = multiReward3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode11 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x600836C")]
		[Cpp2IlInjected.Address(RVA = "0x1A5FF30", Offset = "0x1A5E930", VA = "0x181A5FF30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600836D")]
		[Cpp2IlInjected.Address(RVA = "0x1A618C0", Offset = "0x1A602C0", VA = "0x181A618C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_019e
			if ((long)_repeated_itemsToGive_codec != 0)
			{
				int value = characterId_;
				output.WriteInt32(value);
			}
			if (missionId_ != 0)
			{
				int value2 = missionId_;
				output.WriteInt32(value2);
			}
			if (currentStepIndex_ != 0)
			{
				int value3 = currentStepIndex_;
				output.WriteInt32(value3);
			}
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			FieldCodec<MissionStep> repeated_missionSteps_codec = _repeated_missionSteps_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_missionSteps_codec);
			if (missionChoice_ != 0)
			{
			}
			if (missionNextChoice_ != 0)
			{
			}
			MapField<int, MissionVariableList> mapField = missionVariables_;
			MapField<int, MissionVariableList>.Codec map_missionVariables_codec = _map_missionVariables_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_missionVariables_codec);
			RepeatedField<ItemFilterData> repeatedField2 = itemsToGive_;
			FieldCodec<ItemFilterData> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			RepeatedField<int> repeatedField3 = itemsToGiveAmount_;
			FieldCodec<int> repeated_itemsToGiveAmount_codec = _repeated_itemsToGiveAmount_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToGiveAmount_codec);
			if (slotId_ != 0)
			{
				int value4 = slotId_;
				output.WriteInt32(value4);
			}
			if (class_ != 0)
			{
			}
			if (state_ != 0)
			{
			}
			if ((long)expirationTime_ != 0)
			{
				Timestamp value5 = expirationTime_;
				output.WriteMessage(value5);
			}
			if ((long)startTime_ != 0)
			{
				Timestamp value6 = startTime_;
				output.WriteMessage(value6);
			}
			if ((long)endTime_ != 0)
			{
				Timestamp value7 = endTime_;
				output.WriteMessage(value7);
			}
			if ((long)rewards_ != 0)
			{
				MultiReward value8 = rewards_;
				output.WriteMessage(value8);
			}
			if ((long)rewardPresents_ != 0)
			{
				MultiReward value9 = rewardPresents_;
				output.WriteMessage(value9);
			}
			if ((long)additionalRewards_ != 0)
			{
				MultiReward value10 = additionalRewards_;
				output.WriteMessage(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600836E")]
		[Cpp2IlInjected.Address(RVA = "0x1A55F40", Offset = "0x1A54940", VA = "0x181A55F40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0248
			int num = characterId_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = missionId_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			int num6 = currentStepIndex_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			FieldCodec<MissionStep> repeated_missionSteps_codec = _repeated_missionSteps_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_missionSteps_codec);
			MissionChoice missionChoice = missionChoice_;
			num2 += num8;
			if (missionChoice != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)missionChoice);
				num9++;
				num2 += num9;
			}
			MissionChoice missionChoice2 = missionNextChoice_;
			if (missionChoice2 != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)missionChoice2);
				num10++;
				num2 += num10;
			}
			MapField<int, MissionVariableList> mapField = missionVariables_;
			MapField<int, MissionVariableList>.Codec map_missionVariables_codec = _map_missionVariables_codec;
			int num11 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_missionVariables_codec);
			RepeatedField<ItemFilterData> repeatedField2 = itemsToGive_;
			FieldCodec<ItemFilterData> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemsToGive_codec);
			RepeatedField<int> repeatedField3 = itemsToGiveAmount_;
			FieldCodec<int> repeated_itemsToGiveAmount_codec = _repeated_itemsToGiveAmount_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_itemsToGiveAmount_codec);
			int num14 = slotId_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			MissionSlotClass missionSlotClass = class_;
			if (missionSlotClass != 0)
			{
				int num16 = CodedOutputStream.ComputeEnumSize((int)missionSlotClass);
				num16++;
				num2 += num16;
			}
			MissionSlotState missionSlotState = state_;
			if (missionSlotState != 0)
			{
				int num17 = CodedOutputStream.ComputeEnumSize((int)missionSlotState);
				num17++;
				num2 += num17;
			}
			Timestamp timestamp = expirationTime_;
			if (timestamp != null)
			{
				int num18 = CodedOutputStream.ComputeMessageSize(timestamp);
				num18++;
				num2 += num18;
			}
			Timestamp timestamp2 = startTime_;
			if (timestamp2 != null)
			{
				int num19 = CodedOutputStream.ComputeMessageSize(timestamp2);
				num19 += 2;
				num2 += num19;
			}
			Timestamp timestamp3 = endTime_;
			if (timestamp3 != null)
			{
				int num20 = CodedOutputStream.ComputeMessageSize(timestamp3);
				num20 += 2;
				num2 += num20;
			}
			MultiReward multiReward = rewards_;
			if (multiReward != null)
			{
				int num21 = CodedOutputStream.ComputeMessageSize(multiReward);
				num21 += 2;
				num2 += num21;
			}
			MultiReward multiReward2 = rewardPresents_;
			if (multiReward2 != null)
			{
				int num22 = CodedOutputStream.ComputeMessageSize(multiReward2);
				num22 += 2;
				num2 += num22;
			}
			MultiReward multiReward3 = additionalRewards_;
			if (multiReward3 != null)
			{
				int num23 = CodedOutputStream.ComputeMessageSize(multiReward3);
				num23 += 2;
				num2 += num23;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num24 = unknownFields.CalculateSize();
				num2 += num24;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600836F")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B4C0", Offset = "0x1A59EC0", VA = "0x181A5B4C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionSlot other)
		{
			//Discarded unreachable code: IL_0290
			if (other == null)
			{
				return;
			}
			int num = other.characterId_;
			if (num != 0)
			{
				characterId_ = num;
			}
			int num2 = other.missionId_;
			if (num2 != 0)
			{
				missionId_ = num2;
			}
			int num3 = other.currentStepIndex_;
			if (num3 != 0)
			{
				currentStepIndex_ = num3;
			}
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			RepeatedField<MissionStep> repeatedField2 = other.missionSteps_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			MissionChoice missionChoice = other.missionChoice_;
			if (missionChoice != 0)
			{
				missionChoice_ = missionChoice;
			}
			MissionChoice missionChoice2 = other.missionNextChoice_;
			if (missionChoice2 != 0)
			{
				missionNextChoice_ = missionChoice2;
			}
			MapField<int, MissionVariableList> mapField = missionVariables_;
			MapField<int, MissionVariableList> mapField2 = other.missionVariables_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			RepeatedField<ItemFilterData> repeatedField3 = itemsToGive_;
			RepeatedField<ItemFilterData> repeatedField4 = other.itemsToGive_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<int> repeatedField5 = itemsToGiveAmount_;
			RepeatedField<int> repeatedField6 = other.itemsToGiveAmount_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			int num4 = other.slotId_;
			if (num4 != 0)
			{
				slotId_ = num4;
			}
			MissionSlotClass missionSlotClass = other.class_;
			if (missionSlotClass != 0)
			{
				class_ = missionSlotClass;
			}
			MissionSlotState missionSlotState = other.state_;
			if (missionSlotState != 0)
			{
				state_ = missionSlotState;
			}
			if ((long)other.expirationTime_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (expirationTime_ == null)
				{
					Timestamp timestamp = (expirationTime_ = new Timestamp());
					timestamp2 = expirationTime_;
				}
				Timestamp other2 = other.expirationTime_;
				timestamp2.MergeFrom(other2);
			}
			if ((long)other.startTime_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (startTime_ == null)
				{
					Timestamp timestamp3 = (startTime_ = new Timestamp());
					timestamp4 = startTime_;
				}
				Timestamp other3 = other.startTime_;
				timestamp4.MergeFrom(other3);
			}
			if ((long)other.endTime_ != 0)
			{
				Timestamp timestamp6 = default(Timestamp);
				if (endTime_ == null)
				{
					Timestamp timestamp5 = (endTime_ = new Timestamp());
					timestamp6 = endTime_;
				}
				Timestamp other4 = other.endTime_;
				timestamp6.MergeFrom(other4);
			}
			if ((long)other.rewards_ != 0)
			{
				MultiReward multiReward2 = default(MultiReward);
				if (rewards_ == null)
				{
					MultiReward multiReward = (rewards_ = new MultiReward());
					multiReward2 = rewards_;
				}
				MultiReward other5 = other.rewards_;
				multiReward2.MergeFrom(other5);
			}
			if ((long)other.rewardPresents_ != 0)
			{
				MultiReward multiReward4 = default(MultiReward);
				if (rewardPresents_ == null)
				{
					MultiReward multiReward3 = (rewardPresents_ = new MultiReward());
					multiReward4 = rewardPresents_;
				}
				MultiReward other6 = other.rewardPresents_;
				multiReward4.MergeFrom(other6);
			}
			if ((long)other.additionalRewards_ != 0)
			{
				MultiReward multiReward6 = default(MultiReward);
				if (additionalRewards_ == null)
				{
					MultiReward multiReward5 = (additionalRewards_ = new MultiReward());
					multiReward6 = additionalRewards_;
				}
				MultiReward other7 = other.additionalRewards_;
				multiReward6.MergeFrom(other7);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6008370")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B850", Offset = "0x1A5A250", VA = "0x181A5B850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_02cd
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			int num4 = default(int);
			if ((int)num > 72)
			{
				Timestamp timestamp2 = default(Timestamp);
				if ((int)num > 106)
				{
					MultiReward multiReward3 = default(MultiReward);
					if ((int)num > 170)
					{
						MultiReward multiReward = default(MultiReward);
						if (num == 186)
						{
							MultiReward builder = default(MultiReward);
							if (rewards_ == null)
							{
								multiReward = (rewards_ = new MultiReward());
								builder = rewards_;
							}
							input.ReadMessage(builder);
						}
						MultiReward multiReward2 = default(MultiReward);
						if ((long)multiReward == 194)
						{
							MultiReward builder2 = default(MultiReward);
							if (rewardPresents_ == null)
							{
								multiReward2 = (rewardPresents_ = new MultiReward());
								builder2 = rewardPresents_;
							}
							input.ReadMessage(builder2);
						}
						if ((long)multiReward2 != 202)
						{
							goto IL_02b6;
						}
						MultiReward builder3 = default(MultiReward);
						if (additionalRewards_ == null)
						{
							multiReward3 = (additionalRewards_ = new MultiReward());
							builder3 = additionalRewards_;
						}
						input.ReadMessage(builder3);
					}
					Timestamp timestamp = default(Timestamp);
					if ((long)multiReward3 == 162)
					{
						Timestamp builder4 = default(Timestamp);
						if (startTime_ == null)
						{
							timestamp = (startTime_ = new Timestamp());
							builder4 = startTime_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)timestamp != 170)
					{
						goto IL_02b6;
					}
					Timestamp builder5 = default(Timestamp);
					if (endTime_ == null)
					{
						timestamp2 = (endTime_ = new Timestamp());
						builder5 = endTime_;
					}
					input.ReadMessage(builder5);
				}
				Timestamp timestamp3 = default(Timestamp);
				if ((long)timestamp2 > 80)
				{
					int num2 = default(int);
					if ((long)timestamp2 == 88)
					{
						num2 = (int)(class_ = (MissionSlotClass)input.ReadInt32());
					}
					int num3 = default(int);
					if (num2 == 96)
					{
						num3 = (int)(state_ = (MissionSlotState)input.ReadInt32());
					}
					if (num3 != 106)
					{
						goto IL_02b6;
					}
					Timestamp builder6 = default(Timestamp);
					if (expirationTime_ == null)
					{
						timestamp3 = (expirationTime_ = new Timestamp());
						builder6 = expirationTime_;
					}
					input.ReadMessage(builder6);
				}
				if ((long)timestamp3 == 74)
				{
					goto IL_0208;
				}
				if ((long)timestamp3 != 80)
				{
					goto IL_02b6;
				}
				num4 = (slotId_ = input.ReadInt32());
			}
			if (num4 <= 34)
			{
				goto IL_0250;
			}
			if (num4 <= 48)
			{
				goto IL_0221;
			}
			if (num4 == 58)
			{
				MapField<int, MissionVariableList> mapField = missionVariables_;
				MapField<int, MissionVariableList>.Codec map_missionVariables_codec = _map_missionVariables_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_missionVariables_codec);
			}
			if (num4 == 66)
			{
				RepeatedField<ItemFilterData> repeatedField = itemsToGive_;
				FieldCodec<ItemFilterData> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			}
			if (num4 == 72)
			{
				goto IL_0208;
			}
			goto IL_02b6;
			IL_0208:
			RepeatedField<int> repeatedField2 = itemsToGiveAmount_;
			FieldCodec<int> repeated_itemsToGiveAmount_codec = _repeated_itemsToGiveAmount_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToGiveAmount_codec);
			goto IL_0221;
			IL_0221:
			int num5 = default(int);
			if (num4 == 40)
			{
				num5 = (int)(missionChoice_ = (MissionChoice)input.ReadInt32());
			}
			int num6 = default(int);
			if (num5 == 48)
			{
				num6 = (int)(missionNextChoice_ = (MissionChoice)input.ReadInt32());
				goto IL_0250;
			}
			goto IL_02b6;
			IL_0250:
			int num7 = default(int);
			if (num6 > 16)
			{
				if (num6 == 24)
				{
					num7 = (currentStepIndex_ = input.ReadInt32());
				}
				if (num7 != 34)
				{
					goto IL_02b6;
				}
				RepeatedField<MissionStep> repeatedField3 = missionSteps_;
				FieldCodec<MissionStep> repeated_missionSteps_codec = _repeated_missionSteps_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_missionSteps_codec);
			}
			int num8 = default(int);
			if (num7 == 8)
			{
				num8 = (characterId_ = input.ReadInt32());
			}
			if (num8 == 16)
			{
				int num9 = (missionId_ = input.ReadInt32());
			}
			goto IL_02b6;
			IL_02b6:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008371")]
		[Cpp2IlInjected.Address(RVA = "0x1A58A20", Offset = "0x1A57420", VA = "0x181A58A20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 24)
			{
				int num = characterId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008372")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EB70", Offset = "0x1A5D570", VA = "0x181A5EB70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0017, IL_001f, IL_0027, IL_0030, IL_0039, IL_0042, IL_004b, IL_0057, IL_005d, IL_0063
			//IL_000e: Expected I4, but got O
			//IL_0016: Expected I4, but got O
			//IL_001e: Expected I4, but got O
			//IL_0026: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			//IL_004a: Expected I4, but got O
			//IL_0056: Expected O, but got I4
			if (fieldNumber - 1 <= 24)
			{
				object obj = default(object);
				characterId_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008373")]
		[Cpp2IlInjected.Address(RVA = "0x1A565C0", Offset = "0x1A54FC0", VA = "0x181A565C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0019
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 24)
			{
				characterId_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008375")]
		[Cpp2IlInjected.Address(RVA = "0x1A5FB80", Offset = "0x1A5E580", VA = "0x181A5FB80")]
		public MissionSlotStringResolver StringResolver(Localizator localizator)
		{
			MissionSlotStringResolver stringResolver = _stringResolver;
			if (stringResolver == null)
			{
				MissionSlotStringResolver missionSlotStringResolver = default(MissionSlotStringResolver);
				missionSlotStringResolver._missionSlot = this;
				missionSlotStringResolver._localizator = localizator;
				_stringResolver = missionSlotStringResolver;
			}
			return stringResolver;
		}

		[Cpp2IlInjected.Token(Token = "0x600837B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "14")]
		object IMissionIdentifier.ResolveKey(Localizator localizator, string key)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600837E")]
		[Cpp2IlInjected.Address(RVA = "0x1A596D0", Offset = "0x1A580D0", VA = "0x181A596D0")]
		public MissionObjective GetObjectiveByIds(int stepID, int subStepID, int objectiveID)
		{
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			Func<MissionStep, bool> func = (Func<MissionStep, bool>)(object)(Func<T, TResult>)delegate(MissionStep x)
			{
				//Discarded unreachable code: IL_0018
				MissionStepData _003CData_003Ek__BackingField3 = x.Data;
				int num3 = stepID;
				return _003CData_003Ek__BackingField3.stepID_ == num3;
			};
			MissionStep missionStep = Enumerable.FirstOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (missionStep != null)
			{
				RepeatedField<MissionSubStep> subSteps_ = missionStep.subSteps_;
				Func<MissionSubStep, bool> func2 = (Func<MissionSubStep, bool>)(object)(Func<T, TResult>)delegate(MissionSubStep x)
				{
					//Discarded unreachable code: IL_0018
					MissionSubStepData _003CData_003Ek__BackingField2 = x.Data;
					int num2 = subStepID;
					return _003CData_003Ek__BackingField2.subStepID_ == num2;
				};
				MissionSubStep missionSubStep = Enumerable.FirstOrDefault<MissionSubStep>((IEnumerable<>)(object)subSteps_, (Func<, >)(object)func2);
				if (missionSubStep != null)
				{
					RepeatedField<MissionObjective> objectives_ = missionSubStep.objectives_;
					Func<MissionObjective, bool> func3 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_0018
						MissionObjectiveData _003CData_003Ek__BackingField = x.Data;
						int num = objectiveID;
						return _003CData_003Ek__BackingField.objectiveID_ == num;
					};
					return Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)objectives_, (Func<, >)(object)func3);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008381")]
		[Cpp2IlInjected.Address(RVA = "0x1A57B50", Offset = "0x1A56550", VA = "0x181A57B50")]
		public IEnumerable<MissionObjective> EndStepAfterDialog(Item characterTalkedTo)
		{
			//Discarded unreachable code: IL_004c
			//IL_001b: Expected O, but got I4
			IEnumerable<MissionObjective> allObjectives;
			Func<MissionObjective, bool> func;
			do
			{
				int itemID = characterTalkedTo.ItemID;
				Item characterTalkedTo2 = (Item)itemID;
				MissionStep currentStep = CurrentStep;
				if (currentStep == null)
				{
					break;
				}
				allObjectives = (IEnumerable<MissionObjective>)currentStep.get_AllObjectives();
				func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => UseAfterDialog(x));
				[Cpp2IlInjected.Token(Token = "0x60083E6")]
				[Cpp2IlInjected.Address(RVA = "0x1301650", Offset = "0x1300050", VA = "0x181301650")]
				bool UseAfterDialog(MissionObjective obj)
				{
					if (obj.IsOverAfterCharacterDialog())
					{
						ITargetCharacterOverride getITargetCharacterOverride = obj.Data.GetITargetCharacterOverride;
						Item item = default(Item);
						if (getITargetCharacterOverride == null || getITargetCharacterOverride == null || (object)item != null)
						{
							goto IL_002c;
						}
						if ((object)characterTalkedTo2 == null)
						{
						}
					}
					int num = 0;
					goto IL_002c;
					IL_002c:
					throw new NullReferenceException();
				}
			}
			while (Enumerable.Where<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)func) != null);
			return (IEnumerable<MissionObjective>)Enumerable.Empty<MissionObjective>();
		}

		[Cpp2IlInjected.Token(Token = "0x6008382")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B190", Offset = "0x1A59B90", VA = "0x181A5B190")]
		public bool IsTargetingCharacter(Item targetCharacterItem)
		{
			//IL_0014: Expected O, but got I4
			int itemID = targetCharacterItem.ItemID;
			Item targetCharacterItem2 = (Item)itemID;
			if (state_ == MissionSlotState.OnGoing && CurrentStep != null)
			{
				IEnumerable<MissionObjective> activeObjectives = (IEnumerable<MissionObjective>)CurrentStep.get_ActiveObjectives();
				Func<MissionObjective, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					Item targetCharacterItem3 = x.TargetCharacterItem;
					throw new NullReferenceException();
				};
				return ((IEnumerable<>)activeObjectives).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_);
			}
			int num = characterId_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008389")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B100", Offset = "0x1A59B00", VA = "0x181A5B100")]
		public bool IsMissionExpired(DateTime serverTime)
		{
			Timestamp timestamp = expirationTime_;
			if (timestamp != null)
			{
				DateTime dateTime = timestamp.ToDateTime();
				return serverTime > dateTime;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008392")]
		[Cpp2IlInjected.Address(RVA = "0x1A5A190", Offset = "0x1A58B90", VA = "0x181A5A190")]
		public IDisposable Init(in World world, ITransactionContext context, int characterId, int missionId, bool applyAutoStart = true)
		{
			//Discarded unreachable code: IL_01ed, IL_01f3, IL_01f9, IL_01ff, IL_0205, IL_020b, IL_0211, IL_0217, IL_021d, IL_0223
			//IL_0019: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0029: Expected I4, but got I8
			//IL_00dd: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Profile = (Profile)(object)this;
			int num5 = 0;
			Dispatcher = (ProfileEventDispatcher)0;
			Context = (ITransactionContext)0;
			state_ = MissionSlotState.Available;
			characterId_ = characterId;
			missionId_ = 0;
			currentStepIndex_ = num4;
			Started = (byte)num4 != 0;
			missionChoice_ = (MissionChoice)num4;
			((MapField<TKey, TValue>)(object)missionVariables_).Clear();
			Random random = new Random(Profile.player_.GetRandomSeed("mission_slot_init"));
			Profile profile = Profile;
			_003CGetMissionItemsToGive_003Ed__179 _003CGetMissionItemsToGive_003Ed__ = new _003CGetMissionItemsToGive_003Ed__179(-2);
			_003CGetMissionItemsToGive_003Ed__._003C_003E4__this = this;
			_003CGetMissionItemsToGive_003Ed__._003C_003E3__random = random;
			_003CGetMissionItemsToGive_003Ed__._003C_003E3__profile = profile;
			if (_003CGetMissionItemsToGive_003Ed__ != null)
			{
				uint num6 = default(uint);
				if (num4 < (int)num6)
				{
					num4 += num4;
					if (num4 == (int)num6)
					{
						goto IL_00bd;
					}
					num4++;
				}
				RepeatedField<ItemFilterData> repeatedField = itemsToGive_;
				goto IL_00bd;
			}
			goto IL_00c4;
			IL_00bd:
			_003CGetMissionItemsToGive_003Ed__ = (_003CGetMissionItemsToGive_003Ed__179)(object)((object)_003CGetMissionItemsToGive_003Ed__ + (object)_003CGetMissionItemsToGive_003Ed__);
			goto IL_00c4;
			IL_0142:
			int num7 = 0;
			_003CGetMissionItemsToGiveAmount_003Ed__178 _003CGetMissionItemsToGiveAmount_003Ed__;
			if (_003CGetMissionItemsToGiveAmount_003Ed__ != null)
			{
			}
			MissionItemData missionItemData = default(MissionItemData);
			int count = ((RepeatedField<T>)(object)missionItemData.steps_).Count;
			MissionObjective missionObjective = default(MissionObjective);
			if (num7 < count)
			{
				MissionItemData missionItemData2 = default(MissionItemData);
				MissionStepData missionStepData = (MissionStepData)((RepeatedField<T>)(object)missionItemData2.steps_)[num7];
				MissionStep missionStep = new MissionStep();
				RepeatedField<MissionSubStep> repeatedField2 = (missionStep.subSteps_ = (RepeatedField<MissionSubStep>)(object)new RepeatedField<T>());
				RepeatedField<MissionSubStepData> subSteps_ = missionStepData.subSteps_;
				bool flag = default(bool);
				if (flag)
				{
					MissionSubStep missionSubStep = new MissionSubStep();
					int num8 = 0;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<MissionObjective> objectives_ = missionSubStep.objectives_;
						missionObjective = new MissionObjective();
						((RepeatedField<T>)(object)objectives_).Add((T)missionObjective);
					}
					((RepeatedField<T>)(object)missionStep.subSteps_).Add((T)missionSubStep);
				}
				int num9 = 0;
				missionStep.Init(random);
				num7++;
			}
			MapField<string, string> progressKeys_ = missionObjective.progressKeys_;
			throw new NullReferenceException();
			IL_0131:
			int num10 = num10 + num10;
			num10 += 312;
			goto IL_0142;
			IL_00c4:
			num10 = 0;
			if (_003CGetMissionItemsToGive_003Ed__ != null)
			{
			}
			_003CGetMissionItemsToGiveAmount_003Ed__ = new _003CGetMissionItemsToGiveAmount_003Ed__178(-2);
			_003CGetMissionItemsToGiveAmount_003Ed__._003C_003E4__this = (MissionSlot)0;
			_003CGetMissionItemsToGiveAmount_003Ed__._003C_003E3__random = random;
			_003CGetMissionItemsToGiveAmount_003Ed__._003C_003E3__profile = profile;
			uint num11 = default(uint);
			if (num10 < (int)num11)
			{
				num10 += num10;
				num10++;
			}
			if (_003CGetMissionItemsToGiveAmount_003Ed__ != null)
			{
				uint num12 = default(uint);
				if (num10 < (int)num12)
				{
					num10 += num10;
					if (num10 == (int)num12)
					{
						goto IL_0131;
					}
					num10++;
				}
				num10 += num10;
				num10 += 312;
				goto IL_0131;
			}
			goto IL_0142;
		}

		[Cpp2IlInjected.Token(Token = "0x6008393")]
		[Cpp2IlInjected.Address(RVA = "0x1A5AC00", Offset = "0x1A59600", VA = "0x181A5AC00")]
		public bool IsCompatibleWith(MissionItemData data)
		{
			if (data != null)
			{
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				RepeatedField<MissionStepData> steps_ = data.steps_;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				int count2 = ((RepeatedField<T>)(object)steps_).Count;
				if (count == count2)
				{
					int num = 0;
					int num2 = 0;
					int count3 = ((RepeatedField<T>)(object)repeatedField).Count;
					if (num2 < count3)
					{
						RepeatedField<MissionSubStep> subSteps_ = ((MissionStep)((RepeatedField<T>)(object)repeatedField)[num]).subSteps_;
						RepeatedField<MissionSubStepData> subSteps_2 = ((MissionStepData)((RepeatedField<T>)(object)steps_)[num]).subSteps_;
						int count4 = ((RepeatedField<T>)(object)subSteps_).Count;
						int count5 = ((RepeatedField<T>)(object)subSteps_2).Count;
						if (count4 == count5)
						{
							int num3 = 0;
							int count6 = ((RepeatedField<T>)(object)subSteps_).Count;
							if (num3 < count6)
							{
								RepeatedField<MissionObjective> objectives_ = ((MissionSubStep)((RepeatedField<T>)(object)subSteps_)[num3]).objectives_;
								RepeatedField<MissionObjectiveData> objectives_2 = ((MissionSubStepData)((RepeatedField<T>)(object)subSteps_2)[num3]).objectives_;
								int count7 = ((RepeatedField<T>)(object)objectives_).Count;
								int count8 = ((RepeatedField<T>)(object)objectives_2).Count;
								if (count7 != count8)
								{
									goto IL_00cd;
								}
								num3++;
							}
							num++;
						}
					}
				}
			}
			goto IL_00cd;
			IL_00cd:
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008394")]
		[Cpp2IlInjected.Address(RVA = "0x1A5D3A0", Offset = "0x1A5BDA0", VA = "0x181A5D3A0")]
		internal void PreInit(in World world, ITransactionContext context, bool allowReset = true)
		{
			//IL_00a3: Expected O, but got I4
			MissionItemData data;
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				data = Data;
				if (!allowReset || IsCompatibleWith(data))
				{
					break;
				}
				if (state_ != 0)
				{
					int num = missionId_;
					if (flag)
					{
						int num2 = characterId_;
						if (flag2)
						{
							object[] array = new object[4];
							int num3 = missionId_;
							if (array != null && array == null)
							{
								continue;
							}
							array[0] = array;
							Item missionItem = MissionItem;
							if ((object)missionItem != null && (object)missionItem == null)
							{
								continue;
							}
							array[1] = missionItem;
							int num4 = characterId_;
							if (num4 != 0 && num4 == 0)
							{
								continue;
							}
							array[2] = num4;
							Item characterItem = CharacterItem;
							if ((object)characterItem != null && (object)characterItem == null)
							{
								continue;
							}
							array[3] = characterItem;
							string text = string.Format("MissionSlot.PreInit: Profile contain deprecated data, mission canceled: Mission={0}={1}, Character={2}={3}", array);
						}
					}
				}
				ResetMission();
				return;
			}
			IWorldEventDispatcher dispatcher = world.dispatcher;
			if (dispatcher == null)
			{
			}
			int num5 = 0;
			Dispatcher = (ProfileEventDispatcher)dispatcher;
			Context = context;
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			int num6 = 0;
			int num7 = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			while (num7 >= count)
			{
			}
			MissionStep missionStep = (MissionStep)((RepeatedField<T>)(object)missionSteps_)[num6];
			MissionStepData data2 = (MissionStepData)((RepeatedField<T>)(object)data.steps_)[num6];
			missionStep.PreInit(in world, context, data2, this, num6);
			RepeatedField<MissionStep> repeatedField2 = missionSteps_;
			num6++;
			while (repeatedField2 != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008395")]
		[Cpp2IlInjected.Address(RVA = "0x1A57EF0", Offset = "0x1A568F0", VA = "0x181A57EF0")]
		public bool EvaluateAutoStart()
		{
			//Discarded unreachable code: IL_008b, IL_0091, IL_0097, IL_009d, IL_00a3
			//IL_0046: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			RepeatedField<MissionItemData.Types.AutoAcceptOption> autoAccept_ = Data.autoAccept_;
			bool flag = default(bool);
			if (flag)
			{
				ITransactionContext context = Context;
				Profile profile = Profile;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				StartMission.Types.Response response = new StartMission.Types.Response();
				StartMission.Types.Request request = new StartMission.Types.Request();
				request.missionChoice_ = (MissionChoice)request;
				MissionSlotClass missionSlotClass = (request.slotClass_ = class_);
				int num5 = (request.slotId_ = slotId_);
				request.autoAccept_ = true;
				response.request_ = request;
				num4++;
			}
			if (num4 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008396")]
		[Cpp2IlInjected.Address(RVA = "0x1A59300", Offset = "0x1A57D00", VA = "0x181A59300")]
		[IteratorStateMachine(typeof(_003CGetMissionItemsToGiveAmount_003Ed__178))]
		private IEnumerable<int> GetMissionItemsToGiveAmount(Random random, Profile profile)
		{
			_003CGetMissionItemsToGiveAmount_003Ed__178 _003CGetMissionItemsToGiveAmount_003Ed__ = new _003CGetMissionItemsToGiveAmount_003Ed__178(-2);
			_003CGetMissionItemsToGiveAmount_003Ed__._003C_003E4__this = this;
			_003CGetMissionItemsToGiveAmount_003Ed__._003C_003E3__random = random;
			_003CGetMissionItemsToGiveAmount_003Ed__._003C_003E3__profile = profile;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008397")]
		[Cpp2IlInjected.Address(RVA = "0x1A593B0", Offset = "0x1A57DB0", VA = "0x181A593B0")]
		[IteratorStateMachine(typeof(_003CGetMissionItemsToGive_003Ed__179))]
		private IEnumerable<ItemFilterData> GetMissionItemsToGive(Random random, Profile profile)
		{
			_003CGetMissionItemsToGive_003Ed__179 _003CGetMissionItemsToGive_003Ed__ = new _003CGetMissionItemsToGive_003Ed__179(-2);
			_003CGetMissionItemsToGive_003Ed__._003C_003E4__this = this;
			_003CGetMissionItemsToGive_003Ed__._003C_003E3__random = random;
			_003CGetMissionItemsToGive_003Ed__._003C_003E3__profile = profile;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008398")]
		[Cpp2IlInjected.Address(RVA = "0x1A58F30", Offset = "0x1A57930", VA = "0x181A58F30")]
		public MultiItemInstance GetItemsToGive()
		{
			//Discarded unreachable code: IL_004c, IL_0052, IL_0058, IL_005e, IL_0064
			int num = 0;
			MultiItemInstance multiItemInstance = new MultiItemInstance();
			RepeatedField<int> repeatedField = itemsToGiveAmount_;
			IEnumerable<> enumerable = MoreLinq.Zip<ItemFilterData, int>((IEnumerable<>)(object)itemsToGive_, (IEnumerable<>)(object)repeatedField);
			ItemInstance itemInstance = default(ItemInstance);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_003f;
					}
					num++;
				}
				((RepeatedField<T>)(object)multiItemInstance.items_).Add((T)itemInstance);
				goto IL_003f;
			}
			goto IL_0046;
			IL_0046:
			if (enumerable != null)
			{
			}
			return multiItemInstance;
			IL_003f:
			itemInstance = (ItemInstance)(object)((object)itemInstance + (object)itemInstance);
			goto IL_0046;
		}

		[Cpp2IlInjected.Token(Token = "0x6008399")]
		[Cpp2IlInjected.Address(RVA = "0x1A5BDE0", Offset = "0x1A5A7E0", VA = "0x181A5BDE0")]
		public static ItemInstance NewItemToGive(int itemID, int amount = 1)
		{
			//Discarded unreachable code: IL_0023
			ItemInstance itemInstance = new ItemInstance();
			itemInstance.amount_ = amount;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.MemoryShard)
			{
				ItemState itemState = new ItemState();
				int num2 = (itemState.MemoryShardIndex = 0);
			}
			return itemInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x600839A")]
		[Cpp2IlInjected.Address(RVA = "0x1A5BF50", Offset = "0x1A5A950", VA = "0x181A5BF50")]
		public static ItemInstance NewItemToGive(Item item, int amount = 1)
		{
			//Discarded unreachable code: IL_002a
			ItemInstance itemInstance = new ItemInstance();
			itemInstance.itemID_ = 0;
			itemInstance.amount_ = amount;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.MemoryShard)
			{
				ItemState itemState = new ItemState();
				int num2 = (itemState.MemoryShardIndex = 0);
			}
			return itemInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x600839B")]
		[Cpp2IlInjected.Address(RVA = "0x1A5F670", Offset = "0x1A5E070", VA = "0x181A5F670")]
		private void Start()
		{
			//Discarded unreachable code: IL_00a0
			int num = 0;
			if ((Started ? 1 : 0) != num)
			{
				return;
			}
			VerifiyState();
			Started = true;
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			bool flag = default(bool);
			if (flag)
			{
				MissionStepStatus missionStepStatus = default(MissionStepStatus);
				while (missionStepStatus == MissionStepStatus.Confirmed)
				{
				}
				MissionStep.StepStatusChangedDelegate stepStatusChangedDelegate = OnStepStatusChanged;
			}
			int num2 = 0;
			int num3 = default(int);
			if (currentStepIndex_ < num3)
			{
				MissionStep missionStep = default(MissionStep);
				MissionStep.StepCompletionChangedDelegate completionChangedDelegate = default(MissionStep.StepCompletionChangedDelegate);
				missionStep?.Start(completionChangedDelegate);
			}
			if ((object)typeof(Item).TypeHandle != null)
			{
				return;
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
			MissionStep missionStep2 = default(MissionStep);
			if (missionStep2.Status != MissionStepStatus.Confirmed)
			{
				int num4 = 0;
				MissionStep missionStep3 = default(MissionStep);
				MissionStep.StepCompletionChangedDelegate completionChangedDelegate2 = default(MissionStep.StepCompletionChangedDelegate);
				missionStep3.Start(completionChangedDelegate2);
			}
			int num5 = default(int);
			if (num2 < num5)
			{
				MissionStep missionStep4 = default(MissionStep);
				MissionStepStatus status = missionStep4.Status;
				if (status == MissionStepStatus.Ongoing || status == MissionStepStatus.Completed)
				{
					MissionStepStatus status2 = missionStep4.Status;
				}
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600839C")]
		[Cpp2IlInjected.Address(RVA = "0x1A60F50", Offset = "0x1A5F950", VA = "0x181A60F50")]
		private void VerifiyState()
		{
			//Discarded unreachable code: IL_0244
			//IL_0096: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			//IL_01b1: Expected O, but got I8
			//IL_01d0: Expected O, but got I4
			//IL_01f8: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			//IL_0243: Expected I4, but got I8
			uint num6 = default(uint);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				if (state_ != MissionSlotState.OnGoing)
				{
					break;
				}
				int num2 = currentStepIndex_;
				int count = ((RepeatedField<T>)(object)missionSteps_).Count;
				if (num2 < count)
				{
					if (CurrentStep != null)
					{
						if (CurrentStep.Status != MissionStepStatus.Completed && CurrentStep.Status != MissionStepStatus.Confirmed)
						{
							goto IL_0111;
						}
						object[] array = new object[4];
						Item missionItem = MissionItem;
						if ((object)missionItem != null && (object)missionItem == null)
						{
							continue;
						}
						array[0] = missionItem;
						MissionSlotState missionSlotState = state_;
						if (missionSlotState != 0 && missionSlotState == MissionSlotState.Invalid)
						{
							continue;
						}
						array[1] = missionSlotState;
						int num3 = currentStepIndex_;
						if (num3 != 0 && num3 == 0)
						{
							continue;
						}
						array[2] = num3;
						MissionStepStatus status = CurrentStep.Status;
						if (status != 0 && status == MissionStepStatus.NotStarted)
						{
							continue;
						}
						array[3] = status;
						string text = string.Format("VerifiyState: {0} is in invalid state (State={1}, CurrentStepIndex={2}, CurrentStep.Status={3}", array);
					}
					Item missionItem2 = MissionItem;
					MissionSlotState missionSlotState2 = state_;
					int num4 = currentStepIndex_;
					string text2 = $"VerifiyState: CurentStep=null for {missionItem2} (State={missionItem2}, CurrentStepIndex={missionItem2}";
					goto IL_0111;
				}
				goto IL_0192;
				IL_0111:
				int num5 = currentStepIndex_;
				MissionStepStatus status2 = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, num5).Status;
				int count2 = ((RepeatedField<T>)(object)missionSteps_).Count;
				if (num >= count2)
				{
					break;
				}
				IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSteps_)[num]).get_AllObjectives();
				if (allObjectives != null)
				{
					while (num == currentStepIndex_)
					{
					}
					while (num <= currentStepIndex_)
					{
					}
					while ((long)(IntPtr)allObjectives <= 0L)
					{
					}
					while ((long)allObjectives >= 4)
					{
					}
					if (num == (int)num6 && (long)allObjectives == 3)
					{
						while (!flag)
						{
						}
					}
				}
				if (allObjectives != null)
				{
				}
				num++;
				goto IL_0192;
				IL_0192:
				object[] array2 = new object[4];
				long num7 = Convert.ToInt64((uint)missionId_);
				array2[0] = num7;
				int num8 = currentStepIndex_;
				if (num8 != 0 && num8 == 0)
				{
					continue;
				}
				array2[1] = num8;
				int count3 = ((RepeatedField<T>)(object)missionSteps_).Count;
				num8 = count3;
				if (count3 == 0 || count3 != 0)
				{
					array2[2] = num8;
					MissionSlotState missionSlotState3 = state_;
					if (missionSlotState3 == MissionSlotState.Invalid || missionSlotState3 != 0)
					{
						array2[3] = missionSlotState3;
						string text3 = string.Format("VerifiyState: Force {0} to be completed (CurrentStepIndex={1}/{2}, State={3})", array2);
						int num9 = (currentStepIndex_ = ((RepeatedField<T>)(object)missionSteps_).Count);
						state_ = MissionSlotState.Completed;
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600839D")]
		[Cpp2IlInjected.Address(RVA = "0x1A5E4F0", Offset = "0x1A5CEF0", VA = "0x181A5E4F0")]
		private void ResolveVariables()
		{
			//Discarded unreachable code: IL_009d
			//IL_007f: Expected I4, but got O
			//IL_0087: Expected F4, but got I4
			RepeatedField<ItemFilterData> repeatedField = itemsToGive_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num < count)
			{
				string introDlgItemFilterVariableName = Data.GetIntroDlgItemFilterVariableName(num);
				MissionVariable missionVariable = new MissionVariable();
				missionVariable.Name = introDlgItemFilterVariableName;
				ItemFilterData itemFilterData2 = (missionVariable.ItemFilter = (ItemFilterData)((RepeatedField<T>)(object)itemsToGive_)[num]);
				SetMissionVariable(MissionVariable.VariableOneofCase.ItemFilter, missionVariable);
				string introDlgAmountVariableName = Data.GetIntroDlgAmountVariableName(num);
				MissionVariable missionVariable2 = new MissionVariable();
				missionVariable2.Name = introDlgAmountVariableName;
				int num2 = (int)((RepeatedField<T>)(object)itemsToGiveAmount_)[num];
				missionVariable2.TargetAmount = num;
				SetMissionVariable(MissionVariable.VariableOneofCase.TargetAmount, missionVariable2);
				RepeatedField<ItemFilterData> repeatedField2 = itemsToGive_;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600839E")]
		[Cpp2IlInjected.Address(RVA = "0x1A59A70", Offset = "0x1A58470", VA = "0x181A59A70")]
		public string GetStoryDescriptionStack(Localizator localizator)
		{
			//Discarded unreachable code: IL_009d, IL_00a3, IL_00a9, IL_00af
			int num = 0;
			List<string> list;
			IEnumerable<MissionStep> enumerable;
			string text = default(string);
			if (state_ > MissionSlotState.Available)
			{
				list = (List<string>)(object)new List<T>();
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				Func<MissionStep, bool> _003C_003E9__186_ = _003C_003Ec._003C_003E9__186_0;
				if (_003C_003E9__186_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStep x) => x.Status != MissionStepStatus.NotStarted);
				}
				enumerable = (IEnumerable<MissionStep>)Enumerable.Where<MissionStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__186_);
				if (enumerable != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_0066;
						}
						num++;
					}
					while (num != 0)
					{
					}
					((List<T>)(object)list).Add((T)text);
					goto IL_0066;
				}
				goto IL_006d;
			}
			return "";
			IL_0066:
			text += text;
			goto IL_006d;
			IL_006d:
			int num3 = 0;
			if (enumerable != null)
			{
			}
			MissionItemData missionItemData = default(MissionItemData);
			string completedStoryDescription_ = missionItemData.completedStoryDescription_;
			if (missionItemData == null)
			{
				string item = default(string);
				((List<T>)(object)list).Add((T)item);
			}
			return string.Join("\n\n", (IEnumerable<>)list);
		}

		[Cpp2IlInjected.Token(Token = "0x600839F")]
		[Cpp2IlInjected.Address(RVA = "0x1A581E0", Offset = "0x1A56BE0", VA = "0x181A581E0")]
		public List<DescriptionInfo> GetAllDescriptions(Localizator localizator, bool reversed = true)
		{
			//Discarded unreachable code: IL_007a, IL_0080, IL_0086, IL_008c
			int num = 0;
			List<DescriptionInfo> list = (List<DescriptionInfo>)(object)new List<T>();
			IEnumerable<MissionStep> enumerable;
			List<DescriptionInfo> list2 = default(List<DescriptionInfo>);
			if (state_ > MissionSlotState.Available)
			{
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				Func<MissionStep, bool> func = (Func<MissionStep, bool>)(object)(Func<T, TResult>)delegate(MissionStep x)
				{
					//Discarded unreachable code: IL_001f
					int num3 = currentStepIndex_;
					if (x.StepIndex > num3)
					{
						int num4 = 0;
					}
					return x.Status != MissionStepStatus.NotStarted;
				};
				enumerable = (IEnumerable<MissionStep>)Enumerable.Where<MissionStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				if (reversed)
				{
					IEnumerable<MissionStep> enumerable2 = (IEnumerable<MissionStep>)Enumerable.Reverse<MissionStep>((IEnumerable<>)enumerable);
				}
				if (enumerable != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_005a;
						}
						num++;
					}
					((List<T>)(object)list).AddRange((IEnumerable<>)list2);
					goto IL_005a;
				}
				goto IL_0061;
			}
			goto IL_0078;
			IL_005a:
			list2 = (List<DescriptionInfo>)(object)((object)list2 + (object)list2);
			goto IL_0061;
			IL_0078:
			return list;
			IL_0061:
			if (enumerable != null)
			{
			}
			int size = ((List<>)(object)list)._size;
			DescriptionInfo item = default(DescriptionInfo);
			((List<T>)(object)list).Insert(size, (T)item);
			goto IL_0078;
		}

		[Cpp2IlInjected.Token(Token = "0x60083A0")]
		[Cpp2IlInjected.Address(RVA = "0x1A58830", Offset = "0x1A57230", VA = "0x181A58830")]
		public List<DescriptionInfo> GetCurrentDescriptions(Localizator localizator, bool includeAvailable = false)
		{
			//Discarded unreachable code: IL_0020, IL_0024
			//IL_005e: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			if (state_ == MissionSlotState.Available)
			{
				List<DescriptionInfo> list = (List<DescriptionInfo>)(object)new List<T>();
				DescriptionInfo completedDescription = GetCompletedDescription(localizator);
				((List<T>)(object)list).Add((T)completedDescription);
				return list;
			}
			List<DescriptionInfo> list2 = (List<DescriptionInfo>)(object)new List<T>();
			while (!includeAvailable)
			{
			}
			List<DescriptionInfo> list3 = (List<DescriptionInfo>)(object)new List<T>();
			MissionStep missionStep = Enumerable.First<MissionStep>((IEnumerable<>)list3);
			MissionItemData missionItemData = default(MissionItemData);
			string availableDescription_ = missionItemData.availableDescription_;
			int num = 0;
			int num2 = 0;
			int num4 = default(int);
			int num3 = default(int);
			DescriptionInfo item = new DescriptionInfo(missionStep.ResolveString(localizator, availableDescription_, (IResolver)num2), (byte)num3 != 0, num4, (MissionObjective)num, (Nullable<>)num, (Nullable<>)num);
			num4 = 0;
			num3 = 0;
			((List<T>)(object)list3).Add((T)item);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083A1")]
		[Cpp2IlInjected.Address(RVA = "0x1A58500", Offset = "0x1A56F00", VA = "0x181A58500")]
		private DescriptionInfo GetCompletedDescription(Localizator localizator)
		{
			//IL_0085: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			int num = 0;
			if (Data.completedCase_ != MissionItemData.CompletedOneofCase.Any)
			{
				if (Data.completedCase_ != MissionItemData.CompletedOneofCase.NoOutro)
				{
					if (missionChoice_ != (MissionChoice)num)
					{
						int num2 = 0;
						MessageDescriptor descriptor = MissionItemData.Types.CompletedDescriptionDialogueChoices.Descriptor;
						MissionChoice missionChoice = missionChoice_;
						string name = descriptor.ToString();
						MessageDescriptor messageDescriptor = descriptor;
						IFieldAccessor accessor = descriptor.FindFieldByName(name).accessor;
						MissionItemData.Types.CompletedDescriptionDialogueChoices choices = Data.Choices;
					}
					MissionItemData.Types.CompletedDescriptionDialogue choice1_ = Data.Choices.choice1_;
				}
				int num4 = default(int);
				int num3 = default(int);
				DescriptionInfo result = new DescriptionInfo("", (byte)num3 != 0, num4, (MissionObjective)num, (Nullable<>)num, (Nullable<>)num);
				num4 = 0;
				num3 = 0;
				return result;
			}
			string completedRequestDescription_ = Data.Any.completedRequestDescription_;
			MissionStep lastStep = GetLastStep();
			int num5 = 0;
			string text = lastStep.ResolveString(localizator, completedRequestDescription_, (IResolver)num5);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083A2")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B330", Offset = "0x1A59D30", VA = "0x181A5B330")]
		public bool IsValidStepIndex(int index)
		{
			//Discarded unreachable code: IL_002d
			MissionStepData missionStepData = Enumerable.ElementAtOrDefault<MissionStepData>((IEnumerable<>)(object)Data.steps_, index);
			if (missionStepData != null)
			{
				if (missionStepData.choiceRequirement_ == MissionChoice.Any)
				{
					return true;
				}
				int num = 0;
			}
			return MissionChoice.Any == missionChoice_;
		}

		[Cpp2IlInjected.Token(Token = "0x60083A3")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B420", Offset = "0x1A59E20", VA = "0x181A5B420")]
		public bool IsValidStepIndex(MissionStepData stepData)
		{
			if (stepData != null)
			{
				if (stepData.choiceRequirement_ == MissionChoice.Any)
				{
					return true;
				}
				int num = 0;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60083A4")]
		[Cpp2IlInjected.Address(RVA = "0x1A563C0", Offset = "0x1A54DC0", VA = "0x181A563C0")]
		public bool CanStartMission()
		{
			//Discarded unreachable code: IL_002e
			if (state_ != MissionSlotState.Available)
			{
				int num = 0;
			}
			ConditionsList unlockConditions_ = Data.unlockConditions_;
			ITransactionContext context = Context;
			Profile profile = Profile;
			return unlockConditions_.Evaluate(profile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60083A5")]
		[Cpp2IlInjected.Address(RVA = "0x1A5F2E0", Offset = "0x1A5DCE0", VA = "0x181A5F2E0")]
		internal void StartMission()
		{
			//Discarded unreachable code: IL_00a0, IL_00a6, IL_00ac
			//IL_0012: Expected I4, but got I8
			//IL_004d: Expected I4, but got I8
			int num = 0;
			currentStepIndex_ = -1;
			int num2 = (currentStepIndex_ = GetNextStepIndex(-1));
			MissionChoice missionChoice = (missionNextChoice_ = missionChoice_);
			int count = ((RepeatedField<T>)(object)Data.steps_).Count;
			if (num2 < count)
			{
				state_ = MissionSlotState.OnGoing;
				Start();
				RepeatedField<ItemInstance> items_ = GetItemsToGive().items_;
				bool flag = default(bool);
				if (flag)
				{
					Profile profile = Profile;
					ProfileEventDispatcher dispatcher = Dispatcher;
					ITransactionContext context = Context;
					MissionItemData data = Data;
					int num3 = characterId_;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				return;
			}
			state_ = (MissionSlotState)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083A6")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EA20", Offset = "0x1A5D420", VA = "0x181A5EA20")]
		internal void ResumeMission()
		{
			if (state_ > MissionSlotState.Available)
			{
				Start();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60083A7")]
		[Cpp2IlInjected.Address(RVA = "0x1A56810", Offset = "0x1A55210", VA = "0x181A56810")]
		internal void ConfirmLastStep()
		{
			//Discarded unreachable code: IL_0053
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			int num = currentStepIndex_;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num == count)
			{
				RepeatedField<MissionStep> repeatedField2 = missionSteps_;
				int num2 = currentStepIndex_;
				MissionStepStatus status = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, num2).Status;
				uint num3 = default(uint);
				Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField2, (int)num3)?.SetConfirmed();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60083A8")]
		[Cpp2IlInjected.Address(RVA = "0x1A5D9B0", Offset = "0x1A5C3B0", VA = "0x181A5D9B0")]
		internal void ResetMission()
		{
			//Discarded unreachable code: IL_001c, IL_0022
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				MissionStep.StepStatusChangedDelegate stepStatusChangedDelegate = OnStepStatusChanged;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60083A9")]
		[Cpp2IlInjected.Address(RVA = "0x1A57710", Offset = "0x1A56110", VA = "0x181A57710")]
		internal void EndMission(bool success = true)
		{
			//Discarded unreachable code: IL_015e
			//IL_00c8: Expected O, but got I4
			int num = 0;
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			int num2 = currentStepIndex_;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num2 == count)
			{
				RepeatedField<MissionStep> repeatedField2 = missionSteps_;
				int num3 = currentStepIndex_;
				MissionStepStatus status = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, num3).Status;
				uint num4 = default(uint);
				Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField2, (int)num4)?.SetConfirmed();
			}
			DeleteItemsAfterMission();
			MultiReward multiReward = default(MultiReward);
			if (success)
			{
				if (class_ <= MissionSlotClass.Village)
				{
					QuestInformation questInfo_ = Profile.world_.questInfo_;
					int num5 = missionId_;
				}
				multiReward = rewards_;
				MultiReward moreRewards = additionalRewards_;
				multiReward.MergedRewards(moreRewards);
				Profile profile = Profile;
				ITransactionContext context = Context;
				ProfileEventDispatcher dispatcher = Dispatcher;
				multiReward.Give((IRewardRecipient)profile, (IProfile)profile, (IProfileEventDispatcher)dispatcher, context, (Nullable<>)num, (byte)num != 0);
				if ((IntPtr)rewardPresents_ != (IntPtr)num)
				{
					ItemState itemState = new ItemState();
					MultiItemInstance multiItemInstance2 = (itemState.LootPresentData = new MultiItemInstance());
					MultiReward multiReward2 = rewardPresents_;
					MultiItemInstance lootPresentData = itemState.LootPresentData;
					int givenItems = multiReward2.GetGivenItems(lootPresentData);
					Profile profile2 = Profile;
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					Item rewardPresentItem = RewardPresentItem;
					ITransactionContext context2 = Context;
				}
			}
			MissionItemData data = Data;
			if (multiReward != null)
			{
				RepeatedField<AnyReward> repeatedField3 = multiReward.rewards_;
				if (repeatedField3 != null)
				{
					List<AnyReward> list = (List<AnyReward>)(object)Enumerable.ToList<AnyReward>((IEnumerable<>)(object)repeatedField3);
				}
			}
			ResetMission();
			ProfileEventDispatcher dispatcher3 = Dispatcher;
			int num6 = slotId_;
		}

		[Cpp2IlInjected.Token(Token = "0x60083AA")]
		[Cpp2IlInjected.Address(RVA = "0x1A56920", Offset = "0x1A55320", VA = "0x181A56920")]
		private void DeleteItemsAfterMission()
		{
			//Discarded unreachable code: IL_02f0, IL_02f6, IL_0302, IL_0308, IL_030e, IL_0314, IL_031a, IL_0320, IL_032c, IL_0332, IL_0338, IL_033e, IL_0344, IL_034a, IL_0350, IL_0356, IL_035c, IL_0362, IL_0368, IL_036e, IL_0374, IL_037a, IL_0380, IL_0386, IL_038c, IL_0392, IL_0398, IL_039e, IL_03a4, IL_03aa, IL_03b0, IL_03b6, IL_03bc, IL_03c2, IL_03c8, IL_03ce, IL_03d4, IL_03da, IL_03e0, IL_03e6, IL_03ec, IL_03f2, IL_03f8, IL_03fe, IL_0404
			//IL_00fb: Expected O, but got I4
			bool flag = default(bool);
			IItemData itemData = default(IItemData);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			IEnumerable<IGrid> cpp2il__autoParamName__idx_ = default(IEnumerable<IGrid>);
			Predicate<ItemInstance> predicate = default(Predicate<ItemInstance>);
			AmountWithState amountWithState = default(AmountWithState);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				RepeatedField<int> itemsToDeleteAfterMission_ = Data.itemsToDeleteAfterMission_;
				int num3;
				if (flag)
				{
					_003C_003Ec__DisplayClass199_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass199_0();
					CS_0024_003C_003E8__locals0.item = (Item)CS_0024_003C_003E8__locals0;
					Item item = CS_0024_003C_003E8__locals0.item;
					if (itemData != null)
					{
						ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)Profile.player_.containerInventories_).get_Values();
						if (values != null)
						{
							Item item2 = CS_0024_003C_003E8__locals0.item;
						}
						num++;
						if (values != null)
						{
						}
						if (num != 0)
						{
							throw new NullReferenceException();
						}
						if (num == 0)
						{
						}
					}
					ICollection<ListInventory> values2 = (ICollection<ListInventory>)((MapField<TKey, TValue>)(object)Profile.player_.listInventories_).get_Values();
					if (values2 != null)
					{
						Item item3 = CS_0024_003C_003E8__locals0.item;
						while (!flag2)
						{
						}
						Item item4 = CS_0024_003C_003E8__locals0.item;
						while (!flag3)
						{
						}
						ProfileEventDispatcher dispatcher = Dispatcher;
						Item item5 = CS_0024_003C_003E8__locals0.item;
					}
					num++;
					num3 = 0;
					if (values2 != null)
					{
						int num4 = 0;
					}
					if (num != 0)
					{
						break;
					}
					if (num != 0)
					{
					}
					IGrid[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<IGrid>();
					if (num3 < array.Length)
					{
						IGrid grid = array[num3];
						GridObject[] array2 = ((IEnumerable<>)num3).ToArray<GridObject>();
						if (num3 < array2.Length)
						{
							GridObject gridObject = array2[num3];
							if (gridObject.ItemID != 0)
							{
								goto IL_02d6;
							}
							GridState gridState = gridObject.state_;
							if (gridState != null)
							{
								WeedData weedData = gridState.WeedData;
								if (weedData != null)
								{
									ItemWithState treasure = weedData.Treasure;
									if (treasure != null)
									{
										int itemID = treasure.Item.ItemID;
									}
								}
								Item item6 = CS_0024_003C_003E8__locals0.item;
								if (num3 != 0 && num3 != 0)
								{
									goto IL_02d6;
								}
							}
							GridState gridState2 = gridObject.state_;
							if (gridState2 != null)
							{
								AmountWithState itemAmountState = gridState2.ItemAmountState;
								if (itemAmountState != null)
								{
									ItemState itemState = itemAmountState.state_;
									if (itemState != null)
									{
										ItemInstance consummableData = itemState.ConsummableData;
										if (consummableData != null)
										{
											int itemID2 = consummableData.Item.ItemID;
										}
									}
								}
								Item item7 = CS_0024_003C_003E8__locals0.item;
								if (num3 != 0 && num3 != 0)
								{
									goto IL_02d6;
								}
							}
							GridState gridState3 = gridObject.state_;
							if (gridState3 != null)
							{
								AmountWithState itemAmountState2 = gridState3.ItemAmountState;
								if (itemAmountState2 != null)
								{
									ItemState itemState2 = itemAmountState2.state_;
									if (itemState2 != null)
									{
										MultiItemInstance lootPresentData = itemState2.LootPresentData;
										if (lootPresentData != null)
										{
											RepeatedField<ItemInstance> items_ = lootPresentData.items_;
											if (CS_0024_003C_003E8__locals0._003C_003E9__0 == null)
											{
												predicate = (CS_0024_003C_003E8__locals0._003C_003E9__0 = (Predicate<ItemInstance>)(object)(Predicate<T>)delegate(ItemInstance x)
												{
													Item item8 = x.Item;
													throw new NullReferenceException();
												});
											}
											bool flag4 = ((RepeatedField<>)(object)items_).Any<ItemInstance>((Predicate<>)(object)predicate);
											int index = ((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_).Count - 1;
											if ((object)((ItemInstance)((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_)[index]).Item != null)
											{
												((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_).RemoveAt(index);
											}
											if (((RepeatedField<T>)(object)amountWithState.state_.LootPresentData.items_).Count == 0)
											{
												num3++;
												goto IL_02d6;
											}
										}
									}
								}
							}
							goto IL_02dc;
						}
						goto IL_02e2;
					}
				}
				goto IL_02e8;
				IL_02e8:
				if (num == 0)
				{
					return;
				}
				continue;
				IL_02dc:
				num3++;
				goto IL_02e2;
				IL_02e2:
				num3++;
				goto IL_02e8;
				IL_02d6:
				num3++;
				goto IL_02dc;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083AB")]
		[Cpp2IlInjected.Address(RVA = "0x1A599F0", Offset = "0x1A583F0", VA = "0x181A599F0")]
		[IteratorStateMachine(typeof(_003CGetPreviousSteps_003Ed__200))]
		public IEnumerable<MissionStep> GetPreviousSteps(int index)
		{
			_003CGetPreviousSteps_003Ed__200 _003CGetPreviousSteps_003Ed__ = new _003CGetPreviousSteps_003Ed__200(-2);
			_003CGetPreviousSteps_003Ed__._003C_003E4__this = this;
			_003CGetPreviousSteps_003Ed__._003C_003E3__index = index;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083AC")]
		[Cpp2IlInjected.Address(RVA = "0x1A59980", Offset = "0x1A58380", VA = "0x181A59980")]
		private MissionStep GetPreviousStep(bool useStatus = false)
		{
			int index = currentStepIndex_;
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			index = GetPreviousStepIndex(index, useStatus);
			return Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, index);
		}

		[Cpp2IlInjected.Token(Token = "0x60083AD")]
		[Cpp2IlInjected.Address(RVA = "0x1A59970", Offset = "0x1A58370", VA = "0x181A59970")]
		private int GetPreviousStepIndex(bool useStatus = false)
		{
			int index = currentStepIndex_;
			return GetPreviousStepIndex(index, useStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60083AE")]
		[Cpp2IlInjected.Address(RVA = "0x1A598C0", Offset = "0x1A582C0", VA = "0x181A598C0")]
		private int GetPreviousStepIndex(int index, bool useStatus = false)
		{
			if (!useStatus)
			{
				if (IsValidStepIndex(index))
				{
					return index;
				}
			}
			else
			{
				MissionStepStatus status = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, index).Status;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A59670", Offset = "0x1A58070", VA = "0x181A59670")]
		private MissionStep GetNextStep()
		{
			int index = currentStepIndex_;
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			index = GetNextStepIndex(index);
			return Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, index);
		}

		[Cpp2IlInjected.Token(Token = "0x60083B0")]
		[Cpp2IlInjected.Address(RVA = "0x1A59660", Offset = "0x1A58060", VA = "0x181A59660")]
		private int GetNextStepIndex()
		{
			int index = currentStepIndex_;
			return GetNextStepIndex(index);
		}

		[Cpp2IlInjected.Token(Token = "0x60083B1")]
		[Cpp2IlInjected.Address(RVA = "0x1A595B0", Offset = "0x1A57FB0", VA = "0x181A595B0")]
		private int GetNextStepIndex(int index)
		{
			//Discarded unreachable code: IL_002f
			int count = ((RepeatedField<T>)(object)missionSteps_).Count;
			if (index < count)
			{
				if (!IsValidStepIndex(index))
				{
					RepeatedField<MissionStep> repeatedField = missionSteps_;
				}
				return index;
			}
			return ((RepeatedField<T>)(object)missionSteps_).Count;
		}

		[Cpp2IlInjected.Token(Token = "0x60083B2")]
		[Cpp2IlInjected.Address(RVA = "0x1A58C70", Offset = "0x1A57670", VA = "0x181A58C70")]
		private MissionStep GetFirstStep()
		{
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			int nextStepIndex = GetNextStepIndex(-1);
			return Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, nextStepIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60083B3")]
		[Cpp2IlInjected.Address(RVA = "0x1A58C60", Offset = "0x1A57660", VA = "0x181A58C60")]
		private int GetFirstStepIndex()
		{
			return GetNextStepIndex(-1);
		}

		[Cpp2IlInjected.Token(Token = "0x60083B4")]
		[Cpp2IlInjected.Address(RVA = "0x1A59220", Offset = "0x1A57C20", VA = "0x181A59220")]
		private MissionStep GetLastStep()
		{
			//Discarded unreachable code: IL_0025
			RepeatedField<MissionStep> repeatedField = missionSteps_;
			int count = ((RepeatedField<T>)(object)missionSteps_).Count;
			if (!IsValidStepIndex(count))
			{
			}
			return Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, count);
		}

		[Cpp2IlInjected.Token(Token = "0x60083B5")]
		[Cpp2IlInjected.Address(RVA = "0x1A59190", Offset = "0x1A57B90", VA = "0x181A59190")]
		private int GetLastStepIndex()
		{
			//Discarded unreachable code: IL_0018
			int count = ((RepeatedField<T>)(object)missionSteps_).Count;
			if (!IsValidStepIndex(count))
			{
			}
			return count;
		}

		[Cpp2IlInjected.Token(Token = "0x60083B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B030", Offset = "0x1A59A30", VA = "0x181A5B030")]
		private bool IsFirstStep()
		{
			int num = currentStepIndex_;
			if (!IsValidStepIndex(num))
			{
			}
			return num == -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60083B7")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B090", Offset = "0x1A59A90", VA = "0x181A5B090")]
		public bool IsLastStep()
		{
			//Discarded unreachable code: IL_0020
			int index = currentStepIndex_;
			int nextStepIndex = GetNextStepIndex(index);
			int count = ((RepeatedField<T>)(object)missionSteps_).Count;
			return nextStepIndex == count;
		}

		[Cpp2IlInjected.Token(Token = "0x60083B8")]
		[Cpp2IlInjected.Address(RVA = "0x1A5C050", Offset = "0x1A5AA50", VA = "0x181A5C050")]
		private void OnStepCompletionChanged(MissionStep missionStep, bool completed)
		{
			//Discarded unreachable code: IL_00d1, IL_00d7, IL_00e5, IL_00eb, IL_00f8, IL_00fe, IL_010c, IL_0112, IL_011b, IL_0121, IL_0127, IL_0134, IL_013a, IL_0143, IL_0149, IL_014f, IL_015c, IL_0162, IL_016b, IL_0171, IL_0177, IL_017c, IL_0182, IL_0190, IL_0196, IL_019f, IL_01a5, IL_01ab, IL_01b0, IL_01b6, IL_01bc, IL_01c2, IL_01c7, IL_01cd, IL_01d3, IL_01d9, IL_01fa, IL_0200, IL_0206, IL_020c, IL_0214, IL_021a, IL_0228, IL_022e, IL_0237, IL_023d, IL_0243, IL_024b, IL_0251, IL_025a, IL_0260, IL_0266, IL_026e, IL_0274, IL_027d, IL_0283, IL_0289, IL_028e, IL_0294, IL_02a2, IL_02a8, IL_02b1, IL_02b7, IL_02bd, IL_02c2, IL_02c8, IL_02ce, IL_02d4, IL_02d9, IL_02df, IL_02e5, IL_02eb
			//IL_0085: Expected I4, but got I8
			//IL_0189: Expected O, but got I4
			//IL_029b: Expected O, but got I4
			int num = 0;
			if (!completed)
			{
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				int num2 = currentStepIndex_;
				if (!IsValidStepIndex(num2))
				{
				}
				MissionStep missionStep2 = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, num2);
				if (CurrentStep != null)
				{
					MissionStep currentStep = CurrentStep;
					MissionStep.StepCompletionChangedDelegate completionChangedDelegate = OnStepCompletionChanged;
					currentStep.Stop(completionChangedDelegate);
				}
				int index = currentStepIndex_;
				if (!IsValidStepIndex(index))
				{
				}
				ProfileEventDispatcher dispatcher = Dispatcher;
				uint num3 = default(uint);
				currentStepIndex_ = (int)num3;
				int num4 = slotId_;
				state_ = MissionSlotState.OnGoing;
			}
			MissionStep currentStep2 = CurrentStep;
			if (missionStep == currentStep2)
			{
				bool flag = AdvanceStep();
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				MissionSlotClass missionSlotClass = class_;
				int num5 = slotId_;
				MissionItemData data = Data;
				return;
			}
			object[] array = new object[8];
			Item missionItem = MissionItem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083B9")]
		[Cpp2IlInjected.Address(RVA = "0x1A558E0", Offset = "0x1A542E0", VA = "0x181A558E0")]
		private bool AdvanceStep()
		{
			//IL_0074: Expected O, but got I4
			//IL_01eb: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			if (state_ != MissionSlotState.Completed)
			{
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				int num3 = currentStepIndex_;
				MissionStepStatus status = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, num3).Status;
				uint num4 = default(uint);
				MissionStep missionStep = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, (int)num4);
				if (missionStep != null && missionStep.Status < MissionStepStatus.Confirmed)
				{
					missionStep.SetConfirmed();
					MissionStep.StepStatusChangedDelegate value = OnStepStatusChanged;
					missionStep.StepStatusChanged -= value;
					int num5 = 0;
					missionStep.Stop((MissionStep.StepCompletionChangedDelegate)num5);
				}
				MissionChoice missionChoice = missionNextChoice_;
				if (missionChoice_ != missionChoice)
				{
					missionChoice_ = missionChoice;
				}
				RepeatedField<MissionSubStep> subSteps_ = CurrentStep.subSteps_;
				Func<MissionSubStep, bool> func = default(Func<MissionSubStep, bool>);
				if (MissionStep._003C_003Ec._003C_003E9__60_0 == null)
				{
					func = (Func<MissionSubStep, bool>)(object)(MissionStep._003C_003Ec._003C_003E9 = (MissionStep._003C_003Ec)(object)(Func<T, TResult>)((MissionSubStep x) => x.AutoConfirmOnCompletion));
				}
				if (((IEnumerable<>)(object)subSteps_).All<MissionSubStep>((Func<, >)(object)func) || CurrentStep.Status == MissionStepStatus.Confirmed)
				{
					CurrentStep.SetConfirmed();
					MissionStep currentStep = CurrentStep;
					MissionStep.StepStatusChangedDelegate value2 = OnStepStatusChanged;
					currentStep.StepStatusChanged -= value2;
					MissionStep currentStep2 = CurrentStep;
					MissionStep.StepCompletionChangedDelegate completionChangedDelegate = OnStepCompletionChanged;
					currentStep2.Stop(completionChangedDelegate);
				}
				int num6 = currentStepIndex_;
				int index = currentStepIndex_;
				int nextStepIndex = GetNextStepIndex(index);
				int count = ((RepeatedField<T>)(object)missionSteps_).Count;
				if (nextStepIndex != count)
				{
					int index2 = currentStepIndex_;
					int num7 = (currentStepIndex_ = GetNextStepIndex(index2));
					int num8 = currentStepIndex_;
					int count2 = ((RepeatedField<T>)(object)missionSteps_).Count;
					if (num8 < count2)
					{
						RepeatedField<MissionStep> repeatedField2 = missionSteps_;
						int index3 = currentStepIndex_;
						MissionStep missionStep2 = (MissionStep)((RepeatedField<T>)(object)repeatedField2)[index3];
					}
					int num9 = 0;
					MissionStep.StepCompletionChangedDelegate stepCompletionChangedDelegate = OnStepCompletionChanged;
					ProfileEventDispatcher dispatcher = Dispatcher;
					int num10 = currentStepIndex_;
					int num11 = slotId_;
				}
				int count3 = ((RepeatedField<T>)(object)missionSteps_).Count;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				currentStepIndex_ = count3;
				state_ = MissionSlotState.Completed;
				int num12 = slotId_;
				if (Data.completedCase_ == MissionItemData.CompletedOneofCase.NoOutro)
				{
					EndMission.Types.Response response = new EndMission.Types.Response();
					EndMission.Types.Request request = new EndMission.Types.Request();
					int num13 = (request.slotId_ = slotId_);
					MissionSlotClass missionSlotClass = (request.slotClass_ = class_);
					response.request_ = request;
				}
			}
			int num14 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EA30", Offset = "0x1A5D430", VA = "0x181A5EA30")]
		private void RewindStep()
		{
			//Discarded unreachable code: IL_0056
			//IL_0055: Expected I4, but got I8
			if (CurrentStep != null)
			{
				MissionStep currentStep = CurrentStep;
				MissionStep.StepCompletionChangedDelegate completionChangedDelegate = OnStepCompletionChanged;
				currentStep.Stop(completionChangedDelegate);
			}
			int index = currentStepIndex_;
			if (!IsValidStepIndex(index))
			{
			}
			ProfileEventDispatcher dispatcher = Dispatcher;
			uint num = default(uint);
			currentStepIndex_ = (int)num;
			int num2 = slotId_;
			state_ = MissionSlotState.OnGoing;
		}

		[Cpp2IlInjected.Token(Token = "0x60083BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CB10", Offset = "0x1A5B510", VA = "0x181A5CB10")]
		private void OnStepStatusChanged(MissionStep step, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			//Discarded unreachable code: IL_001b
			ProfileEventDispatcher dispatcher = Dispatcher;
			int _003CStepIndex_003Ek__BackingField = step.StepIndex;
			int num = slotId_;
		}

		[Cpp2IlInjected.Token(Token = "0x60083BC")]
		[Cpp2IlInjected.Address(RVA = "0x1A56410", Offset = "0x1A54E10", VA = "0x181A56410")]
		internal bool CheckManualCompletion(MissionCompleteStep.Types.Condition condition, string stepName, InventoryFullResolution inventoryFullResolution, out InventoryFullDetails inventoryFullDetails)
		{
			_003C_003Ec__DisplayClass217_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass217_0();
			CS_0024_003C_003E8__locals0.stepName = stepName;
			string stepName2 = CS_0024_003C_003E8__locals0.stepName;
			if (CS_0024_003C_003E8__locals0 == null)
			{
				IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)this.get_AllStepsObjectives();
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_001b
					MissionObjectiveData _003CData_003Ek__BackingField = x.Data;
					string stepName3 = CS_0024_003C_003E8__locals0.stepName;
					return string.Equals(_003CData_003Ek__BackingField.stepName_, stepName3);
				};
				MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
				bool result = default(bool);
				if (missionObjective != null && missionObjective.status_ != (MissionStepStatus)(-5))
				{
					return result;
				}
				throw new NullReferenceException();
			}
			Exception ex = new Exception("CheckManualCompletion called with invalid args: 'stepName' cannot be empty!");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60083BE")]
		[Cpp2IlInjected.Address(RVA = "0x1A5DC10", Offset = "0x1A5C610", VA = "0x181A5DC10")]
		internal object ResolveKey(Localizator localizator, string key, [Optional] string stepName)
		{
			//IL_01e4: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			if ("ownername" == null)
			{
				string text = default(string);
				if (text != null)
				{
					int num3 = missionId_;
				}
				if (text != null || text != null)
				{
					goto IL_0213;
				}
				if (text != null)
				{
					ItemFilterData itemFilterData = Enumerable.FirstOrDefault<ItemFilterData>((IEnumerable<>)(object)itemsToGive_);
					if (itemFilterData == null)
					{
						goto IL_01c2;
					}
					int item_ = itemFilterData.item_;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				}
				if (text != null)
				{
					int num4 = Enumerable.FirstOrDefault<int>((IEnumerable<>)(object)itemsToGiveAmount_);
				}
				if (key.StartsWith("introdlg.itemname["))
				{
					goto IL_01e4;
				}
				int count = 0;
				if (!key.StartsWith("introdlg.targetamount[") && Data != null)
				{
					char[] array = new char[1];
					uint num5 = default(uint);
					array[0] = (char)num5;
					string[] array2 = key.Split(array, count);
					int length = array2.Length;
					string namelower = array2[0];
					IMissionIdentifier missionIdentifier = GetResolverByName(namelower);
					if (missionIdentifier == null && key != null)
					{
						if (missionIdentifier != null)
						{
							int num6 = currentStepIndex_;
							MissionStepStatus status = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, num6).Status;
						}
						bool flag = string.Equals(key, "next");
						int num7 = 0;
						if (flag)
						{
							int index = currentStepIndex_;
							index = GetNextStepIndex(index);
							object obj = ResvoleKeyAt(index);
						}
						bool flag2 = string.Equals(key, "first");
						int num8 = 0;
						if (flag2)
						{
							int nextStepIndex = GetNextStepIndex(-1);
							object obj2 = ResvoleKeyAt(nextStepIndex);
						}
						if (string.Equals(key, "last"))
						{
							int lastStepIndex = GetLastStepIndex();
						}
					}
					if (!string.IsNullOrEmpty(stepName))
					{
						string namelower2 = stepName.ToLower();
						if (GetResolverByName(namelower2) == null)
						{
						}
					}
					int num9 = currentStepIndex_;
					MissionStepStatus status2 = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, num9).Status;
					uint num10 = default(uint);
					object obj3 = default(object);
					if (Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, (int)num10) != null && obj3 != null)
					{
					}
				}
			}
			goto IL_01c2;
			IL_01c2:
			int count2 = ((RepeatedField<T>)(object)itemsToGiveAmount_).Count;
			int num11 = default(int);
			while (num11 >= count2)
			{
			}
			int num12 = (int)((RepeatedField<T>)(object)itemsToGiveAmount_)[num11];
			goto IL_01e4;
			IL_0213:
			throw new NullReferenceException();
			IL_01e4:
			int num13 = default(int);
			num11 = num13;
			int count3 = ((RepeatedField<T>)(object)itemsToGive_).Count;
			while (num11 >= count3)
			{
			}
			int item_2 = ((ItemFilterData)((RepeatedField<T>)(object)itemsToGive_)[num11]).item_;
			item_2 = count3;
			goto IL_0213;
			[Cpp2IlInjected.Token(Token = "0x60083CE")]
			[Cpp2IlInjected.Address(RVA = "0x1A60420", Offset = "0x1A5EE20", VA = "0x181A60420")]
			IMissionIdentifier GetResolverByName(string _namelower)
			{
				//Discarded unreachable code: IL_008b
				//Could not transform parameter 1: unsupported argument pattern
				//Could not transform parameter 1: unsupported argument pattern
				IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Empty<IMissionIdentifier>();
				IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)this.get_AllStepsObjectives();
				IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Concat<IMissionIdentifier>((IEnumerable<>)enumerable, (IEnumerable<>)allStepsObjectives);
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				Func<MissionStep, IEnumerable<MissionSubStep>> func = default(Func<MissionStep, IEnumerable<MissionSubStep>>);
				if (_003C_003Ec._003C_003E9__131_0 == null)
				{
					func = (Func<MissionStep, IEnumerable<MissionSubStep>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionStep x)
					{
						RepeatedField<MissionSubStep> subSteps_ = x.subSteps_;
						throw new NullReferenceException();
					});
				}
				IEnumerable<MissionStep> enumerable3 = (IEnumerable<MissionStep>)Enumerable.SelectMany<MissionStep, MissionSubStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				IEnumerable<IMissionIdentifier> enumerable4 = (IEnumerable<IMissionIdentifier>)Enumerable.Concat<IMissionIdentifier>((IEnumerable<>)enumerable2, (IEnumerable<>)enumerable3);
				RepeatedField<MissionStep> repeatedField2 = missionSteps_;
				IEnumerable<IMissionIdentifier> enumerable5 = (IEnumerable<IMissionIdentifier>)Enumerable.Concat<IMissionIdentifier>((IEnumerable<>)enumerable4, (IEnumerable<>)(object)repeatedField2);
				Func<IMissionIdentifier, bool> func2 = (Func<IMissionIdentifier, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000f
					string b = _namelower;
					string a = default(string);
					return string.Equals(a, b);
				};
				return Enumerable.FirstOrDefault<IMissionIdentifier>((IEnumerable<>)enumerable5, (Func<, >)(object)func2);
			}
			[Cpp2IlInjected.Token(Token = "0x60083D0")]
			[Cpp2IlInjected.Address(RVA = "0x1A606A0", Offset = "0x1A5F0A0", VA = "0x181A606A0")]
			object ResvoleKeyAt(int _index)
			{
				//Could not transform parameter 1: unsupported argument pattern
				//Could not transform parameter 1: unsupported argument pattern
				MissionStep missionStep = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, _index);
				if (missionStep != null)
				{
					string key2 = cpp2il__autoParamName__idx_1.tags[1];
					Localizator localizator2 = cpp2il__autoParamName__idx_1.localizator;
					if (missionStep.ResolveKey(localizator2, key2) != null)
					{
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60083BF")]
		[Cpp2IlInjected.Address(RVA = "0x1A5E6C0", Offset = "0x1A5D0C0", VA = "0x181A5E6C0")]
		public unsafe string ResolveXml(string text)
		{
			//Discarded unreachable code: IL_00d1, IL_00d7, IL_00dd, IL_00e3, IL_00e9
			int num = 0;
			if ("<" == null)
			{
				int stringLength = text.m_stringLength;
				int num2 = text.IndexOf("<");
				int num3 = text.IndexOf("choice", StringComparison.OrdinalIgnoreCase);
				ulong num4 = default(ulong);
				if (num4 == 0)
				{
					num2 -= num;
					string text2 = text.Remove(num, num2);
					num2 = num;
				}
				string text4 = default(string);
				if (IsChoiceXmlTag(text, num2, out *(MissionChoice*)num, out *(bool*)num))
				{
					int num5 = text.IndexOf(">", num2);
					num5 -= num2;
					int count = num5 + 1;
					string text3 = text.Remove(num2, count);
					count = num2;
					int startIndex = 0;
					text4 = text.Substring(startIndex, count);
				}
				int startIndex2 = num2 + 1;
				num2 = text4.IndexOf("<", startIndex2);
				MissionChoice missionChoice = missionChoice_;
				bool flag = default(bool);
				if (!flag)
				{
					int stringLength2 = text4.m_stringLength;
					stringLength2 -= num2;
					string text5 = text4.Remove(num2, stringLength2);
				}
			}
			object obj = text.Clone();
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60083D2")]
			[Cpp2IlInjected.Address(RVA = "0x1A608D0", Offset = "0x1A5F2D0", VA = "0x181A608D0")]
			static bool IsChoiceXmlTag(string str, int pos, out MissionChoice outChoice, out bool outIsEnd)
			{
				if (str.IndexOf(">", pos) > pos)
				{
					char c = str[pos];
					bool value = default(bool);
					outIsEnd.m_value = value;
					int num6 = 0;
					int num7 = 0;
					char c2 = str[0];
					c2 = char.ToLower(c2);
					char c3 = default(char);
					if (c2 == c3)
					{
						num6++;
						num7 = num6;
						int num8 = 0;
						int num9 = 0;
						c2 = str[0];
						c2 = char.ToLower(c2);
						char c4 = default(char);
						if (c2 == c4)
						{
							num8++;
							num9 = num8;
						}
						int num10 = pos + 1;
						char c5 = str[pos];
						char c6 = str[pos];
						char c7 = (char)(outChoice.value__ = str[pos]);
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60083C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A5F0F0", Offset = "0x1A5DAF0", VA = "0x181A5F0F0")]
		internal void SetMissionVariable(MissionVariable.VariableOneofCase type, MissionVariable value)
		{
			//IL_000e: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)missionVariables_).ContainsKey((TKey)type))
			{
				RepeatedField<MissionVariable> variables_ = ((MissionVariableList)((MapField<TKey, TValue>)(object)missionVariables_)[(TKey)type]).variables_;
				int num = 0;
				int count = ((RepeatedField<T>)(object)variables_).Count;
				if (num < count)
				{
					MissionVariable missionVariable = (MissionVariable)((RepeatedField<T>)(object)variables_)[num];
					string name_ = missionVariable.name_;
					if (missionVariable == null)
					{
						num++;
					}
					((RepeatedField<T>)(object)variables_)[num] = (T)value;
				}
				int count2 = ((RepeatedField<T>)(object)variables_).Count;
				if (num == count2)
				{
					((RepeatedField<T>)(object)variables_).Add((T)value);
				}
				return;
			}
			MissionVariableList missionVariableList = new MissionVariableList();
			((RepeatedField<T>)(object)missionVariableList.variables_).Add((T)value);
			((MapField<TKey, TValue>)(object)missionVariables_)[(TKey)type] = (TValue)missionVariableList;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A59460", Offset = "0x1A57E60", VA = "0x181A59460")]
		internal MissionVariable GetMissionVariable(MissionVariable.VariableOneofCase type, string name)
		{
			//IL_001b: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)missionVariables_).ContainsKey((TKey)type))
			{
				RepeatedField<MissionVariable> variables_ = ((MissionVariableList)((MapField<TKey, TValue>)(object)missionVariables_)[(TKey)type]).variables_;
				Func<MissionVariable, bool> func = (Func<MissionVariable, bool>)(object)(Func<T, TResult>)delegate(MissionVariable x)
				{
					//Discarded unreachable code: IL_0014
					string b = name;
					return string.Equals(x.name_, b);
				};
				return Enumerable.First<MissionVariable>((IEnumerable<>)(object)variables_, (Func<, >)(object)func);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083C2")]
		[Cpp2IlInjected.Address(RVA = "0x1A5AE60", Offset = "0x1A59860", VA = "0x181A5AE60")]
		public bool IsCurrentStepReadyToGiveItems(Item targetCharacterItem)
		{
			//IL_001f: Expected O, but got I4
			//IL_0046: Expected I4, but got I8
			int itemID = targetCharacterItem.ItemID;
			MissionStep currentStep = CurrentStep;
			if (currentStep != null)
			{
				MissionStep._003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals0 = new MissionStep._003C_003Ec__DisplayClass52_0();
				CS_0024_003C_003E8__locals0.targetCharacterItem = (Item)itemID;
				Func<MissionObjective, bool> predicate = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					Item targetCharacterItem2 = x.TargetCharacterItem;
					throw new NullReferenceException();
				};
				MissionStep._003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals1 = new MissionStep._003C_003Ec__DisplayClass51_0();
				CS_0024_003C_003E8__locals1.predicate = predicate;
				CS_0024_003C_003E8__locals1.custumStep = MissionObjectiveData.CustomStepOneofCase.BringItem;
				IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)currentStep.get_AllObjectives();
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_002e
					//IL_002c: Expected I4, but got O
					MissionObjectiveData _003CData_003Ek__BackingField = x.Data;
					MissionObjectiveData.CustomStepOneofCase custumStep = CS_0024_003C_003E8__locals1.custumStep;
					if (_003CData_003Ek__BackingField.customStepCase_ != custumStep)
					{
						int num = 0;
					}
					Func<MissionObjective, bool> predicate2 = CS_0024_003C_003E8__locals1.predicate;
					return (predicate2 == null) ? true : ((byte)(int)predicate2((T)x) != 0);
				};
				MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)func);
				if (missionObjective != null)
				{
					MissionSubStep _003CMissionSubStep_003Ek__BackingField = missionObjective.MissionSubStep;
					if (_003CMissionSubStep_003Ek__BackingField != null)
					{
						return _003CMissionSubStep_003Ek__BackingField.Status == MissionStepStatus.ReadyToBeCompleted;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A5FC40", Offset = "0x1A5E640", VA = "0x181A5FC40")]
		public bool TalkToCharacterNeedToSpawnOutside(MissionObjective objective, out Item characterItem)
		{
			//IL_00d9: Expected I4, but got O
			MissionObjective missionObjective = objective;
			int num = 0;
			MissionObjectiveData missionObjectiveData = default(MissionObjectiveData);
			if (missionObjectiveData != null)
			{
				MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
			}
			if (num != 270 && objective.Data.TalkToCharacter.targetIsNotOwner_.useField_)
			{
				int index = currentStepIndex_;
				RepeatedField<MissionStep> repeatedField = missionSteps_;
				index = GetNextStepIndex(index);
				MissionStep missionStep = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, index);
				if (missionStep != null)
				{
					IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
					Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0022
						int targetCharacter = objective.Data.TalkToCharacter.targetIsNotOwner_.Character.TargetCharacter;
						bool result = default(bool);
						return result;
					};
					if (Enumerable.Any<MissionObjective>(Enumerable.Where<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)func)))
					{
						int num2 = (characterItem.ItemID = objective.Data.TalkToCharacter.targetIsNotOwner_.Character.TargetCharacter);
						return true;
					}
				}
			}
			Item invalid = Item.Invalid;
			characterItem.ItemID = (int)invalid;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CD30", Offset = "0x1A5B730", VA = "0x181A5CD30")]
		public unsafe bool OverrideScheduleOutdoor(Item characterItem)
		{
			//Discarded unreachable code: IL_0187, IL_018d
			//IL_0016: Expected O, but got I4
			Func<MissionObjectiveData, bool> func = default(Func<MissionObjectiveData, bool>);
			uint num3 = default(uint);
			bool flag = default(bool);
			uint num4 = default(uint);
			while (true)
			{
				int itemID = characterItem.ItemID;
				int num = 0;
				_003C_003Ec__DisplayClass226_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass226_0();
				CS_0024_003C_003E8__locals1.characterItem = (Item)itemID;
				if (state_ != MissionSlotState.OnGoing)
				{
					break;
				}
				MissionStep currentStep = CurrentStep;
				if (currentStep == null)
				{
					break;
				}
				int num2 = characterId_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					IEnumerable<MissionObjective> activeObjectives = (IEnumerable<MissionObjective>)currentStep.get_ActiveObjectives();
					Func<MissionObjective, bool> _003C_003E9__226_ = _003C_003Ec._003C_003E9__226_0;
					if (_003C_003E9__226_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.MissionSubStep.Data.isOwnerFollowing_);
					}
					if (((IEnumerable<>)activeObjectives).Any<MissionObjective>((Func<, >)(object)_003C_003E9__226_))
					{
						break;
					}
				}
				if ((IntPtr)num2 == (IntPtr)_repeated_itemsToGive_codec && HasActiveFollowObjective(out *(MissionObjective*)num))
				{
					break;
				}
				IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)currentStep.get_AllObjectives();
				Func<MissionObjective, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000f
					Item characterItem3 = CS_0024_003C_003E8__locals1.characterItem;
					return x.IsCharacterToListen(characterItem3);
				};
				if (((IEnumerable<>)allObjectives).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					break;
				}
				IEnumerable<MissionObjectiveData> allObjectives2 = (IEnumerable<MissionObjectiveData>)currentStep.Data.get_AllObjectives();
				if (_003C_003Ec._003C_003E9__226_2 == null)
				{
					func = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
					{
						CustomStepTalkToCharacter talkToCharacter = x.TalkToCharacter;
						if (talkToCharacter != null)
						{
							OptionalField targetIsNotOwner_ = talkToCharacter.targetIsNotOwner_;
							int num5 = 0;
							if (targetIsNotOwner_ != null)
							{
								bool useField_ = targetIsNotOwner_.useField_;
							}
							return num5 == 1;
						}
						throw new NullReferenceException();
					});
				}
				IEnumerable<MissionObjectiveData> enumerable = (IEnumerable<MissionObjectiveData>)Enumerable.Where<MissionObjectiveData>((IEnumerable<>)allObjectives2, (Func<, >)(object)func);
				if (enumerable != null)
				{
					_003C_003Ec__DisplayClass226_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass226_1();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals1;
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_0165;
						}
						num++;
					}
					CS_0024_003C_003E8__locals0.obj = (MissionObjectiveData)(object)CS_0024_003C_003E8__locals0;
					RepeatedField<MissionStep> repeatedField = missionSteps_;
					int index = currentStepIndex_;
					index = GetNextStepIndex(index);
					if (Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)repeatedField, index) == null)
					{
						continue;
					}
					Func<MissionObjective, bool> func2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_0035
						int targetCharacter = CS_0024_003C_003E8__locals0.obj.TalkToCharacter.targetIsNotOwner_.Character.TargetCharacter;
						bool flag2 = default(bool);
						if (!flag2)
						{
							return flag2;
						}
						Item characterItem2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.characterItem;
						return x.IsCharacterToListen(characterItem2);
					};
					while (!flag)
					{
					}
					num++;
					goto IL_0165;
				}
				goto IL_0174;
				IL_0174:
				num++;
				if (enumerable != null)
				{
				}
				if (num == 0)
				{
				}
				break;
				IL_0165:
				num4 += num4;
				num += 312;
				goto IL_0174;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A5A130", Offset = "0x1A58B30", VA = "0x181A5A130")]
		public bool HasActiveFollowObjective(Item characterItem, out MissionObjective obj)
		{
			if ((IntPtr)characterItem.ItemID != (IntPtr)_repeated_itemsToGive_codec)
			{
				int num = 0;
			}
			return HasActiveFollowObjective(out obj);
		}

		[Cpp2IlInjected.Token(Token = "0x60083C6")]
		[Cpp2IlInjected.Address(RVA = "0x1A59E90", Offset = "0x1A58890", VA = "0x181A59E90")]
		public bool HasActiveFollowObjective(out MissionObjective obj)
		{
			//IL_001c: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			if (state_ == MissionSlotState.OnGoing)
			{
				IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)this.get_AllStepsObjectives();
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)new Func<T, TResult>(hasOngoingFollow);
				int num = 0;
				MissionObjective missionObjective = Enumerable.LastOrDefault<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
			}
			int num2 = 0;
			CustomStepFollowCharacter customStepFollowCharacter = default(CustomStepFollowCharacter);
			CustomStepFollowCharacter.UntilOneofCase untilCase_ = customStepFollowCharacter.untilCase_;
			if (untilCase_ != 0 && untilCase_ != 0 && untilCase_ != 0)
			{
				if (untilCase_ != 0)
				{
					if (untilCase_ != 0)
					{
						if (untilCase_ != (CustomStepFollowCharacter.UntilOneofCase)1)
						{
							goto IL_00a5;
						}
						MissionSlot missionSlot = default(MissionSlot);
						RepeatedField<MissionStep> repeatedField = missionSlot.missionSteps_;
						MissionStep missionStep = default(MissionStep);
						int _003CStepIndex_003Ek__BackingField = missionStep.StepIndex;
						IEnumerable<MissionStep> enumerable = (IEnumerable<MissionStep>)Enumerable.Skip<MissionStep>((IEnumerable<>)(object)repeatedField, _003CStepIndex_003Ek__BackingField);
						if (enumerable != null)
						{
							Func<MissionStep, bool> func2 = (Func<MissionStep, bool>)(object)new Func<T, TResult>(hasStartedOwnerFollower);
							int num3 = 0;
							if (Enumerable.FirstOrDefault<MissionStep>((IEnumerable<>)enumerable, (Func<, >)(object)func2) != null)
							{
								goto IL_00a5;
							}
						}
					}
					MissionSlot missionSlot2 = default(MissionSlot);
					return missionSlot2.state_ < MissionSlotState.Completed;
				}
				MissionStepStatus missionStepStatus = default(MissionStepStatus);
				return missionStepStatus < MissionStepStatus.Completed;
			}
			bool result = default(bool);
			return result;
			IL_00a5:
			int num4 = 0;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60083D5")]
			[Cpp2IlInjected.Address(RVA = "0x1A60080", Offset = "0x1A5EA80", VA = "0x181A60080")]
			static bool hasOngoingFollow(MissionObjective _obj)
			{
				//Discarded unreachable code: IL_001e
				if (_obj.status_ < MissionStepStatus.Ongoing)
				{
					int num6 = 0;
				}
				return _obj.Data.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.FollowCharacter;
			}
			[Cpp2IlInjected.Token(Token = "0x60083D4")]
			[Cpp2IlInjected.Address(RVA = "0x1A600C0", Offset = "0x1A5EAC0", VA = "0x181A600C0")]
			static bool hasStartedOwnerFollower(MissionStep _step)
			{
				//Discarded unreachable code: IL_003c
				if (_step.Status == MissionStepStatus.NotStarted)
				{
				}
				RepeatedField<MissionSubStepData> subSteps_ = _step.Data.subSteps_;
				Predicate<MissionSubStepData> predicate = default(Predicate<MissionSubStepData>);
				if (_003C_003Ec._003C_003E9__228_2 == null)
				{
					predicate = (Predicate<MissionSubStepData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(MissionSubStepData x)
					{
						if (!x.isOwnerFollowing_)
						{
							int num5 = 0;
						}
						Item followerItem = x.FollowerItem;
						throw new NullReferenceException();
					});
				}
				return ((RepeatedField<>)(object)subSteps_).Any<MissionSubStepData>((Predicate<>)(object)predicate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60083C7")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CBB0", Offset = "0x1A5B5B0", VA = "0x181A5CBB0")]
		public MultiReward OverrideMissionRewards(MultiReward rewards, Random random)
		{
			//Discarded unreachable code: IL_0053
			MissionItemData data = Data;
			if (data.rewardsCase_ == MissionItemData.RewardsOneofCase.OverrideRewards)
			{
				RepeatedField<int> repeatedField = data.OverrideRewards.rewards_;
				Action<int> action = (Action<int>)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_0030
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					MultiReward multiReward = rewards;
					LootTableItemData lootTableItemData = default(LootTableItemData);
					LootTable lootTable = lootTableItemData.rewards_;
					MissionSlot missionSlot = this;
					MissionSlot missionSlot2 = this;
					int num = 0;
					MultiReward moreRewards = default(MultiReward);
					multiReward.MergedRewards(moreRewards);
				};
				((RepeatedField<>)(object)repeatedField).ForEach<int>((Action<>)(object)action);
			}
			return rewards;
		}

		[Cpp2IlInjected.Token(Token = "0x60083C8")]
		[Cpp2IlInjected.Address(RVA = "0x1A55730", Offset = "0x1A54130", VA = "0x181A55730")]
		public MultiReward AdditionalMissionRewards(Random random)
		{
			MissionItemData data = Data;
			LootTable additionnalRewards_ = data.additionnalRewards_;
			if (additionnalRewards_ != null)
			{
				RepeatedField<SubLootTable> subLootTables_ = additionnalRewards_.subLootTables_;
				if (subLootTables_ != null)
				{
					bool flag = Enumerable.Any<SubLootTable>((IEnumerable<>)(object)subLootTables_);
					int num = 0;
				}
				if (0 != 1)
				{
					LootTable additionnalRewards_2 = data.additionnalRewards_;
					MultiReward result = default(MultiReward);
					return result;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60083C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A61CC0", Offset = "0x1A606C0", VA = "0x181A61CC0")]
		static MissionSlot()
		{
			MessageParser<MissionStep> parser = MissionStep._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionSlot>)(object)FieldCodec.ForMessage<MissionStep>(num, (MessageParser<>)(object)parser);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<MissionVariableList> parser2 = MissionVariableList._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<MissionVariableList>(num2, (MessageParser<>)(object)parser2);
			uint num3 = default(uint);
			_parser = (MessageParser<MissionSlot>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num3);
			MessageParser<ItemFilterData> parser3 = ItemFilterData._parser;
			uint num4 = default(uint);
			_parser = (MessageParser<MissionSlot>)(object)FieldCodec.ForMessage<ItemFilterData>(num4, (MessageParser<>)(object)parser3);
			RewardPresentItem = (Item)(_parser = (MessageParser<MissionSlot>)(object)FieldCodec.ForInt32(74u));
		}
	}
}
