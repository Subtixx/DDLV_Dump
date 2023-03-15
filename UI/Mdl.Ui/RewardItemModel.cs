using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200060B")]
	public class RewardItemModel : CustomButtonModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002195")]
		private RewardItem _rewardItem;

		[Cpp2IlInjected.Token(Token = "0x170005FC")]
		public AnyReward Reward
		{
			[Cpp2IlInjected.Token(Token = "0x6002796")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CReward_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002797")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CReward_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002798")]
		[Cpp2IlInjected.Address(RVA = "0xE329F0", Offset = "0xE313F0", VA = "0x180E329F0", Slot = "4")]
		public override void Init(CustomButton button)
		{
			if ((object)button == null)
			{
			}
			int num = 0;
			_rewardItem = (RewardItem)button;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002799")]
		[Cpp2IlInjected.Address(RVA = "0xE32A70", Offset = "0xE31470", VA = "0x180E32A70", Slot = "6")]
		public override void Release()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600279A")]
		[Cpp2IlInjected.Address(RVA = "0xE32A90", Offset = "0xE31490", VA = "0x180E32A90", Slot = "5")]
		public override void UpdateDisplay()
		{
			//Discarded unreachable code: IL_0098
			//IL_002a: Expected O, but got I4
			AnyReward anyReward = Reward;
			if (anyReward == null || anyReward.Item == null)
			{
				return;
			}
			RewardItem rewardItem = _rewardItem;
			int num = 0;
			if (!(rewardItem == (UnityEngine.Object)num))
			{
				ButtonViewDefault view = _rewardItem.View;
				AnyReward anyReward2 = Reward;
				TextBase label = view.Label;
				ItemReward item = anyReward2.Item;
				string text = default(string);
				string text3 = (label.Text = "x" + text);
				Item item2 = Reward.Item.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					AsyncAtlassedIcon asyncAtlassedIcon = _rewardItem.View.DynamicIcon.AsyncAtlassedIcon;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600279B")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public RewardItemModel()
		{
			((MarshalByRefObject)(object)this)._002Ector();
		}
	}
}
