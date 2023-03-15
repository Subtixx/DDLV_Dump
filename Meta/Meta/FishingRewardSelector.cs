using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A44")]
	internal abstract class FishingRewardSelector
	{
		[Cpp2IlInjected.Token(Token = "0x17000EAC")]
		protected Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x60058B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60058B8")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAD")]
		protected ITransactionContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x60058B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60058BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAE")]
		protected PendingFish Fish
		{
			[Cpp2IlInjected.Token(Token = "0x60058BB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFish_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60058BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CFish_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058B6")]
		[Cpp2IlInjected.Address(RVA = "0x1800D30", Offset = "0x17FF730", VA = "0x181800D30")]
		public static FishingRewardSelector Create(Profile profile, ITransactionContext context, PendingFish pendingFish)
		{
			if (!SpecificFishRewardSelector.ShouldCreate(pendingFish))
			{
				if (!FirstTimeFishingRewardSelector.ShouldCreate(profile, pendingFish))
				{
					DefaultFishingRewardSelector defaultFishingRewardSelector = new DefaultFishingRewardSelector(profile, context, pendingFish);
				}
				FirstTimeFishingRewardSelector firstTimeFishingRewardSelector = new FirstTimeFishingRewardSelector(profile, context, pendingFish);
			}
			SpecificFishRewardSelector specificFishRewardSelector = new SpecificFishRewardSelector(profile, context, pendingFish);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058BD")]
		[Cpp2IlInjected.Address(RVA = "0x79F770", Offset = "0x79E170", VA = "0x18079F770")]
		protected FishingRewardSelector(Profile profile, ITransactionContext context, PendingFish pendingFish)
		{
			RecordSelectionSuccess();
			Profile = profile;
			Context = context;
			Fish = pendingFish;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool TrySelectReward(Random random, out FishingDataItemData chosenFishingData);

		[Cpp2IlInjected.Token(Token = "0x60058BF")]
		[Cpp2IlInjected.Address(RVA = "0x1800E60", Offset = "0x17FF860", VA = "0x181800E60")]
		[IteratorStateMachine(typeof(_003CEnumerateSelectReward_003Ed__15))]
		public IEnumerable<FishingDataItemData> EnumerateSelectReward(Random random)
		{
			_003CEnumerateSelectReward_003Ed__15 _003CEnumerateSelectReward_003Ed__ = new _003CEnumerateSelectReward_003Ed__15(-2);
			_003CEnumerateSelectReward_003Ed__._003C_003E4__this = this;
			_003CEnumerateSelectReward_003Ed__._003C_003E3__random = random;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058C0")]
		[Cpp2IlInjected.Address(RVA = "0x1800EF0", Offset = "0x17FF8F0", VA = "0x181800EF0")]
		protected FishingDataItemData GetFishingDataItemData(Item fishItem)
		{
			//Discarded unreachable code: IL_0008
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			FishingDataItemData result = default(FishingDataItemData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60058C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public virtual void RecordSelectionSuccess()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
