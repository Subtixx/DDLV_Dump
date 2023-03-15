using System;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Core;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Duties;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000439")]
	internal class RoyalDutyItemModel : DreamlightItemModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700046B")]
		public DutySlot DutySlot
		{
			[Cpp2IlInjected.Token(Token = "0x6001B42")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDutySlot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B43")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDutySlot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046C")]
		public bool NotCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6001B44")]
			[Cpp2IlInjected.Address(RVA = "0xE35D80", Offset = "0xE34780", VA = "0x180E35D80")]
			get
			{
				//Discarded unreachable code: IL_000f
				return DutySlot.state_ < DutySlotState.RewardsClaimed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046D")]
		public float Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B45")]
			[Cpp2IlInjected.Address(RVA = "0xE35DA0", Offset = "0xE347A0", VA = "0x180E35DA0")]
			get
			{
				DutyStepData stepData_ = DutySlot.stepData_;
				if (stepData_ != null)
				{
					int targetAmount_ = stepData_.targetAmount_;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B46")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
		public override bool IsMilestoneEnded()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B47")]
		[Cpp2IlInjected.Address(RVA = "0xE35420", Offset = "0xE33E20", VA = "0x180E35420", Slot = "5")]
		public override bool IsClaimable()
		{
			//Discarded unreachable code: IL_000f
			return DutySlot.state_ == DutySlotState.Completed;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B48")]
		[Cpp2IlInjected.Address(RVA = "0xE35440", Offset = "0xE33E40", VA = "0x180E35440", Slot = "4")]
		internal unsafe override void UpdateDisplay(DreamlightItem dreamlightItem)
		{
			//Discarded unreachable code: IL_033a
			//IL_0021: Expected I4, but got I8
			//IL_00b7: Expected I4, but got I8
			//IL_012e: Expected I4, but got I8
			dreamlightItem.CanvasGroupAlpha.alpha = 1f;
			ulong num = default(ulong);
			dreamlightItem.View.RewardIcon.SetActive((byte)num != 0);
			GameObject lockedIcon = dreamlightItem.View.LockedIcon;
			int active = 0;
			lockedIcon.SetActive((byte)active != 0);
			GameObject giftIcon = dreamlightItem.View.GiftIcon;
			int active2 = 0;
			giftIcon.SetActive((byte)active2 != 0);
			dreamlightItem.RewardAmount.StringID = "";
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num2 = Convert.ToInt64((uint)DutySlot.dutyId_);
			GameObject gameObject = dreamlightItem.gameObject;
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			string text = (gameObject.name = royalDutyItemData.displayName_);
			DreamlightItemView _003CView_003Ek__BackingField = dreamlightItem.View;
			int extraBuff = (int)(_003CView_003Ek__BackingField.Phase = DreamlightMenu.Phase.RoyalDuty);
			dreamlightItem.View.Desc._parseCustomXml = TextBase.CustomXmlOption.ParseOff;
			TextBase desc = dreamlightItem.View.Desc;
			DutySlot dutySlot = DutySlot;
			string description_ = royalDutyItemData.description_;
			if (!string.IsNullOrEmpty(description_))
			{
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				RoyalDutySlotStringResolver resolver = dutySlot.StringResolver(_003CLocalizator_003Ek__BackingField);
				string text2 = LocalizationManager.FromStringID(description_, resolver);
			}
			string text3 = (desc.StringID = string.Empty);
			dreamlightItem.View.Icon.AsyncAtlassedIcon.ColorToApply = UIGameColors.GameColorName.OffWhite;
			AsyncAtlassedIcon asyncAtlassedIcon = dreamlightItem.View.Icon.AsyncAtlassedIcon;
			string iconAddress_ = royalDutyItemData.iconAddress_;
			bool flag = asyncAtlassedIcon.SetIcon(iconAddress_);
			DutySlot dutySlot2 = DutySlot;
			RepeatedField<DutyStepDifficulty> stepDifficultyLayers_ = royalDutyItemData.stepDifficultyLayers_;
			int difficultyLayer_ = dutySlot2.difficultyLayer_;
			int dustReward_ = ((DutyStepDifficulty)((RepeatedField<T>)(object)stepDifficultyLayers_)[difficultyLayer_]).dustReward_;
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			int isReduction = 0;
			player_.ApplyBuff(BuffType.RoyalDutyRewardMultiplier, ref *(int*)dustReward_, (byte)isReduction != 0, extraBuff);
			TextBase rewardAmount = dreamlightItem.RewardAmount;
			string text4 = default(string);
			dreamlightItem.RewardAmount.Text = text4;
			rewardAmount.Text = text4;
			TextBase progress = dreamlightItem.Progress;
			if (DutySlot.stepData_ != null)
			{
			}
			if (DutySlot.stepData_ != null)
			{
			}
			string text5 = default(string);
			string text6 = default(string);
			string text8 = (progress.Text = text5 + "/" + text6);
			dreamlightItem.RewardAmount.transform.RebuildLayout();
			dreamlightItem.RewardAmount.transform.parent.RebuildLayout();
			DutySlot dutySlot3 = DutySlot;
			DutySlotState state_ = dutySlot3.state_;
			if (dutySlot3 != null)
			{
				if (dutySlot3 != null)
				{
					if (state_ != DutySlotState.NotStarted)
					{
						goto IL_02fa;
					}
					dreamlightItem.Phases[2]?.Invoke();
					dreamlightItem.ClaimButton.View.Label.StringID = "menu.common_claimed";
				}
				dreamlightItem.Phases[1]?.Invoke();
				dreamlightItem.ClaimButton.View.Label.StringID = "menu.label_claim";
				UnityEvent[] uiEvents = dreamlightItem.View.UiEvents;
			}
			dreamlightItem.Phases[0]?.Invoke();
			dreamlightItem.View.UiEvents[0]?.Invoke();
			goto IL_02fa;
			IL_02fa:
			GameObject gameObject2 = dreamlightItem.RedDot.gameObject;
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			DutySlot dutySlot4 = DutySlot;
			RedDotHelper redDotHelper = instance.RedDotHelper;
			long num4 = Convert.ToInt64((uint)dutySlot4.dutyId_);
			bool active3 = default(bool);
			gameObject2.SetActive(active3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B49")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public RoyalDutyItemModel()
		{
			((System.Net.BasicClient)(object)this)._002Ector();
		}
	}
}
