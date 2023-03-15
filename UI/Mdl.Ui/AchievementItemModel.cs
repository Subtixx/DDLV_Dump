using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Ui.Cache;
using Meta.Duties;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000436")]
	internal class AchievementItemModel : DreamlightItemModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000462")]
		public AchievementItemData AchievementItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B2E")]
			[Cpp2IlInjected.Address(RVA = "0x8780D0", Offset = "0x876AD0", VA = "0x1808780D0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return AchievementData.ItemData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000463")]
		public AchievementData AchievementData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B2F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CAchievementData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B30")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CAchievementData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000464")]
		private int ClaimedMilestoneIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001B31")]
			[Cpp2IlInjected.Address(RVA = "0x8780F0", Offset = "0x876AF0", VA = "0x1808780F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return AchievementData.ClaimedMilestoneIndex;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000465")]
		public float Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B32")]
			[Cpp2IlInjected.Address(RVA = "0x878350", Offset = "0x876D50", VA = "0x180878350")]
			get
			{
				int curAmountDisplay = AchievementData.CurAmountDisplay;
				int currentMilestoneDisplay = AchievementData.CurrentMilestoneDisplay;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000466")]
		public bool NotCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6001B33")]
			[Cpp2IlInjected.Address(RVA = "0x8782D0", Offset = "0x876CD0", VA = "0x1808782D0")]
			get
			{
				//Discarded unreachable code: IL_002a
				int claimedMilestoneIndex = AchievementData.ClaimedMilestoneIndex;
				int count = ((RepeatedField<T>)(object)AchievementData.ItemData.milestones_).Count;
				return claimedMilestoneIndex != count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000467")]
		public bool IsEnded
		{
			[Cpp2IlInjected.Token(Token = "0x6001B34")]
			[Cpp2IlInjected.Address(RVA = "0x878110", Offset = "0x876B10", VA = "0x180878110")]
			get
			{
				//Discarded unreachable code: IL_002e
				int count = ((RepeatedField<T>)(object)AchievementData.ItemData.milestones_).Count;
				int claimedMilestoneIndex = AchievementData.ClaimedMilestoneIndex;
				claimedMilestoneIndex++;
				return count <= claimedMilestoneIndex;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000468")]
		public bool MilestoneHasCurrencyReward
		{
			[Cpp2IlInjected.Token(Token = "0x6001B35")]
			[Cpp2IlInjected.Address(RVA = "0x878190", Offset = "0x876B90", VA = "0x180878190")]
			get
			{
				if (Enumerable.Any<AchievementMilestone>((IEnumerable<>)(object)AchievementData.ItemData.milestones_) && !IsEnded)
				{
					AchievementItemData itemData = AchievementData.ItemData;
					AchievementData achievementData = AchievementData;
					RepeatedField<AchievementMilestone> milestones_ = itemData.milestones_;
					int index = achievementData.ClaimedMilestoneIndex + 1;
					int rewardItem_ = ((AchievementMilestone)((RepeatedField<T>)(object)milestones_)[index]).rewardItem_;
					ItemType itemType = default(ItemType);
					return itemType == ItemType.Currency;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B36")]
		[Cpp2IlInjected.Address(RVA = "0x8772C0", Offset = "0x875CC0", VA = "0x1808772C0", Slot = "5")]
		public override bool IsClaimable()
		{
			//Discarded unreachable code: IL_002b
			if (IsEnded)
			{
				int num = 0;
			}
			int claimableAmount = AchievementData.ClaimableAmount;
			int currentMilestone = AchievementData.CurrentMilestone;
			return claimableAmount >= currentMilestone;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B37")]
		[Cpp2IlInjected.Address(RVA = "0x877320", Offset = "0x875D20", VA = "0x180877320", Slot = "6")]
		public override bool IsMilestoneEnded()
		{
			return IsEnded;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B38")]
		[Cpp2IlInjected.Address(RVA = "0x877330", Offset = "0x875D30", VA = "0x180877330", Slot = "4")]
		internal override void UpdateDisplay(DreamlightItem dreamlightItem)
		{
			//Discarded unreachable code: IL_03b3
			//IL_00c0: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			//IL_016f: Expected I4, but got I8
			_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
			CS_0024_003C_003E8__locals0.dreamlightItem = dreamlightItem;
			bool milestoneHasCurrencyReward = MilestoneHasCurrencyReward;
			int num = 0;
			bool flag = !MilestoneHasCurrencyReward;
			GameObject gameObject = dreamlightItem.gameObject;
			string text = (gameObject.name = AchievementData.ItemData.title_);
			TextBase textBase = default(TextBase);
			textBase.StringID = "";
			string stringID = textBase._stringID;
			AchievementData achievementData = AchievementData;
			string title_2 = achievementData.ItemData.title_;
			string text2 = achievementData.ResolveString(title_2);
			AchievementData achievementData2 = AchievementData;
			ImageHelper imageHelper = default(ImageHelper);
			AsyncAtlassedIcon asyncAtlassedIcon = imageHelper.AsyncAtlassedIcon;
			string iconAddress_ = achievementData2.ItemData.iconAddress_;
			int num2 = 0;
			asyncAtlassedIcon.Release();
			if (iconAddress_ != null)
			{
				asyncAtlassedIcon.Key = iconAddress_;
				asyncAtlassedIcon.Acquire();
			}
			asyncAtlassedIcon._currentData = (AtlassedIcon)num2;
			asyncAtlassedIcon.Key = (string)num2;
			asyncAtlassedIcon.AssetReference = (AssetReferenceTexture)num2;
			bool isEnded = IsEnded;
			bool flag2 = IsClaimable();
			List<Image> list = (List<Image>)(object)new List<T>();
			RectTransform rectTransform = default(RectTransform);
			int childCount = rectTransform.childCount;
			int count = ((RepeatedField<T>)(object)AchievementData.ItemData.milestones_).Count;
			childCount -= count;
			RectTransform rectTransform2 = default(RectTransform);
			int childCount2 = rectTransform2.childCount;
			if (num2 < childCount2)
			{
				if (num2 > 0)
				{
					RectTransform rectTransform3 = default(RectTransform);
					int childCount3 = rectTransform3.childCount;
					if (num2 < childCount3 && childCount > 0)
					{
						RectTransform rectTransform4 = default(RectTransform);
						GameObject gameObject2 = rectTransform4.GetChild(num2).gameObject;
						int active = 0;
						gameObject2.SetActive((byte)active != 0);
						num2++;
					}
				}
				RectTransform rectTransform5 = default(RectTransform);
				ulong num3 = default(ulong);
				rectTransform5.GetChild(num2).gameObject.SetActive((byte)num3 != 0);
				RectTransform rectTransform6 = default(RectTransform);
				Image component = rectTransform6.GetChild(num2).GetComponent<Image>();
				((List<T>)(object)list).Add((T)component);
				num2++;
			}
			AchievementData achievementData3 = AchievementData;
			int num4 = 0;
			int num5 = 0;
			int count2 = ((RepeatedField<T>)(object)achievementData3.ItemData.milestones_).Count;
			AchievementData achievementData5 = default(AchievementData);
			if (num5 < count2)
			{
				AchievementMilestone achievementMilestone = (AchievementMilestone)((RepeatedField<T>)(object)AchievementData.ItemData.milestones_)[num4];
				int claimedMilestoneIndex = AchievementData.ClaimedMilestoneIndex;
				if (num4 > claimedMilestoneIndex)
				{
					int claimedMilestoneIndex2 = AchievementData.ClaimedMilestoneIndex;
				}
				if (false)
				{
					AchievementData achievementData4 = AchievementData;
					if (flag2)
					{
						int maxAmountDisplay = achievementData4.MaxAmountDisplay;
					}
					int curAmountDisplay = achievementData4.CurAmountDisplay;
					int currentMilestoneDisplay = AchievementData.CurrentMilestoneDisplay;
					TextBase textBase2;
					string text3;
					string text4;
					string text6 = (textBase2.Text = text3 + "/" + text4);
					TextBase textBase3;
					string text7;
					textBase3.Text = text7;
					TextBase textBase4;
					textBase4.transform.RebuildLayout();
					TextBase textBase5;
					textBase5.transform.parent.RebuildLayout();
				}
				achievementData5 = AchievementData;
				num4++;
			}
			ImageHelper staticIcon = default(ImageHelper);
			if (flag2)
			{
				AchievementDataStringResolver stringResolver = achievementData5._stringResolver;
				if (achievementData5.itemsUsed_ != null)
				{
				}
				AchievementState state_ = achievementData5.state_;
				ButtonViewDefault buttonViewDefault = default(ButtonViewDefault);
				buttonViewDefault.Label.StringID = "menu.label_claim";
				staticIcon = buttonViewDefault.StaticIcon;
			}
			float b = staticIcon._startColor.b;
			string subObjectType = ((AssetReference)staticIcon.AssetReference).m_SubObjectType;
			if (subObjectType != null)
			{
			}
			float b2 = staticIcon._startColor.b;
			TextBase textBase7 = default(TextBase);
			if (subObjectType != null)
			{
				int lastMilestoneDisplay = AchievementData.LastMilestoneDisplay;
				TextBase textBase6 = default(TextBase);
				string text8 = default(string);
				string text10 = (textBase6.Text = text8 + "/" + text8);
				string stringID2 = textBase6._stringID;
				if (stringID2 != null)
				{
				}
				if (stringID2 != null)
				{
				}
				ButtonViewDefault buttonViewDefault2 = default(ButtonViewDefault);
				TextBase label = buttonViewDefault2.Label;
				label.StringID = "";
				RectTransform rectTransform7 = label.RectTransform;
				ButtonViewDefault buttonViewDefault3 = default(ButtonViewDefault);
				buttonViewDefault3.Label.Text = "";
				ImageHelper staticIcon2 = buttonViewDefault3.StaticIcon;
				int num6 = 0;
				textBase7.StringID = "menu.common_claimed";
				UnityEvent onRefreshed = textBase7.OnRefreshed;
			}
			UIGameColors.GameColorName colorKey = textBase7._colorKey;
			int num7 = 0;
			UiRoot instance = UiRoot.Instance;
			AchievementData achievementData6 = AchievementData;
			RedDotHelper redDotHelper = instance.RedDotHelper;
			int iD = achievementData6.ItemData.ID;
			GameObject gameObject3 = default(GameObject);
			bool active2 = default(bool);
			gameObject3.SetActive(active2);
			IEnumerator enumerator = RebuildLayout();
			[Cpp2IlInjected.Token(Token = "0x6001B3B")]
			[Cpp2IlInjected.Address(RVA = "0x8E4F70", Offset = "0x8E3970", VA = "0x1808E4F70")]
			[IteratorStateMachine(typeof(_003C_003Ec__DisplayClass18_0._003C_003CUpdateDisplay_003Eg__RebuildLayout_007C0_003Ed))]
			IEnumerator RebuildLayout()
			{
				int _003C_003E1__state = default(int);
				_003C_003Ec__DisplayClass18_0._003C_003CUpdateDisplay_003Eg__RebuildLayout_007C0_003Ed _003C_003CUpdateDisplay_003Eg__RebuildLayout_007C0_003Ed = new _003C_003Ec__DisplayClass18_0._003C_003CUpdateDisplay_003Eg__RebuildLayout_007C0_003Ed(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003C_003CUpdateDisplay_003Eg__RebuildLayout_007C0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B39")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public AchievementItemModel()
		{
			((System.Net.BasicClient)(object)this)._002Ector();
		}
	}
}
