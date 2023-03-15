using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Localization.Formatter;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200043A")]
	internal class BattlePassTaskItemModel : DreamlightItemModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700046E")]
		public BattlePassTaskProgress TaskProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B4A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CTaskProgress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B4B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CTaskProgress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046F")]
		public BattlePassSeasonData SeasonData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B4C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CSeasonData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B4D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CSeasonData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000470")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4001542")]
		public bool IsPremiumUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001B4E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B4F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000471")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B50")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CIconAddress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B51")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CIconAddress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000472")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6001B52")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B53")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CTitle_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000473")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4001545")]
		public bool IsClaimed
		{
			[Cpp2IlInjected.Token(Token = "0x6001B54")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B55")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000474")]
		public bool IsStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6001B56")]
			[Cpp2IlInjected.Address(RVA = "0xA625B0", Offset = "0xA60FB0", VA = "0x180A625B0")]
			get
			{
				DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
				DateTime dateTime = StartDate;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000475")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4001546")]
		public DateTime StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6001B57")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B58")]
			[Cpp2IlInjected.Address(RVA = "0xA62710", Offset = "0xA61110", VA = "0x180A62710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000476")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4001547")]
		public int ClaimedMilestoneIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001B59")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B5A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000477")]
		public float Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B5B")]
			[Cpp2IlInjected.Address(RVA = "0xA626C0", Offset = "0xA610C0", VA = "0x180A626C0")]
			get
			{
				ObjectiveProgress objective_ = TaskProgress.objective_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000478")]
		public bool NotCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6001B5C")]
			[Cpp2IlInjected.Address(RVA = "0xA62690", Offset = "0xA61090", VA = "0x180A62690")]
			get
			{
				//Discarded unreachable code: IL_000f
				return !TaskProgress.IsCompleted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000479")]
		public bool IsEnded
		{
			[Cpp2IlInjected.Token(Token = "0x6001B5D")]
			[Cpp2IlInjected.Address(RVA = "0xA61AA0", Offset = "0xA604A0", VA = "0x180A61AA0")]
			get
			{
				if (IsStarted)
				{
					ObjectiveProgress objective_ = TaskProgress.objective_;
					int num = ClaimedMilestoneIndex;
					num++;
					return IsClaimed;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5E")]
		[Cpp2IlInjected.Address(RVA = "0xA61A80", Offset = "0xA60480", VA = "0x180A61A80", Slot = "5")]
		public override bool IsClaimable()
		{
			//Discarded unreachable code: IL_000c
			return TaskProgress.IsCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5F")]
		[Cpp2IlInjected.Address(RVA = "0xA61AA0", Offset = "0xA604A0", VA = "0x180A61AA0", Slot = "6")]
		public override bool IsMilestoneEnded()
		{
			if (IsStarted)
			{
				ObjectiveProgress objective_ = TaskProgress.objective_;
				int num = ClaimedMilestoneIndex;
				num++;
				return IsClaimed;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B60")]
		[Cpp2IlInjected.Address(RVA = "0xA61AF0", Offset = "0xA604F0", VA = "0x180A61AF0", Slot = "4")]
		internal override void UpdateDisplay(DreamlightItem dreamlightItem)
		{
			//Discarded unreachable code: IL_04c4
			//IL_00f6: Expected F4, but got I4
			//IL_0149: Expected I4, but got I8
			//IL_016a: Expected O, but got I4
			bool flag2;
			string text5 = default(string);
			string text6 = default(string);
			string text9 = default(string);
			string text10 = default(string);
			while (true)
			{
				int ignoreThis = 0;
				dreamlightItem.CanvasGroupAlpha.alpha = 1f;
				dreamlightItem.RewardAmount.TextComponent.fontSize = 36f;
				dreamlightItem.View.RewardIcon.SetActive(value: true);
				GameObject lockedIcon = dreamlightItem.View.LockedIcon;
				int active = 0;
				lockedIcon.SetActive((byte)active != 0);
				GameObject giftIcon = dreamlightItem.View.GiftIcon;
				int active2 = 0;
				giftIcon.SetActive((byte)active2 != 0);
				dreamlightItem.RewardAmount.StringID = "";
				GameObject gameObject = dreamlightItem.gameObject;
				string text2 = (gameObject.name = Title);
				bool isStarted = IsStarted;
				DreamlightItemView _003CView_003Ek__BackingField = dreamlightItem.View;
				if (!isStarted)
				{
					_003CView_003Ek__BackingField.Icon.Unload();
				}
				AsyncAtlassedIcon asyncAtlassedIcon = _003CView_003Ek__BackingField.Icon.AsyncAtlassedIcon;
				string icon = IconAddress;
				bool flag = asyncAtlassedIcon.SetIcon(icon);
				ImageHelper background = dreamlightItem.View.View.Background;
				if (IsStarted)
				{
				}
				int num = 0;
				background.SetAlpha(num);
				ImageHelper staticIcon = dreamlightItem.View.View.StaticIcon;
				if (IsStarted)
				{
				}
				staticIcon.SetAlpha(0.5f);
				GameObject rewardBg = dreamlightItem.View.RewardBg;
				bool isStarted2 = IsStarted;
				rewardBg.SetActive(isStarted2);
				dreamlightItem.View.Phase = DreamlightMenu.Phase.StarPath;
				TextBase desc = dreamlightItem.View.Desc;
				string stringID = Title;
				int num2 = 0;
				string text4 = (desc.Text = LocalizationManager.FromStringID(stringID, (IResolver)num2));
				dreamlightItem.View.IsInteractable = true;
				dreamlightItem.ClaimButton.IsInteractable = true;
				dreamlightItem.FocusNavigationElement.IgnoreThis = (byte)ignoreThis != 0;
				ObjectiveProgress objective_ = TaskProgress.objective_;
				if (IsStarted)
				{
					ObjectiveProgress objective_2 = TaskProgress.objective_;
					int num3 = ClaimedMilestoneIndex;
					num3++;
				}
				int num4 = 0;
				flag2 = IsClaimable();
				if (IsStarted && num4 == 0)
				{
					if (!flag2)
					{
					}
					TextBase progress = dreamlightItem.Progress;
					string text8 = (progress.Text = text5 + "/" + text6);
					TextBase rewardAmount = dreamlightItem.RewardAmount;
					int currencyReward_ = TaskProgress.Data.currencyReward_;
					int num5 = 0;
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					rewardAmount.Text = text9;
					dreamlightItem.RewardAmount.transform.RebuildLayout();
					dreamlightItem.RewardAmount.transform.parent.RebuildLayout();
				}
				if (!IsStarted)
				{
					DreamlightItemView _003CView_003Ek__BackingField2 = dreamlightItem.View;
					int num6 = ((_003CView_003Ek__BackingField2.IsInteractable = false) ? 1 : 0);
					TextButton claimButton = dreamlightItem.ClaimButton;
					int num7 = ((claimButton.IsInteractable = false) ? 1 : 0);
					dreamlightItem.FocusNavigationElement.IgnoreThis = true;
					dreamlightItem.CanvasGroupAlpha.alpha = 0.2f;
					dreamlightItem.View.RewardAmount.Text = "";
					dreamlightItem.View.Progress.Text = "";
					dreamlightItem.View.Desc.Text = "";
					GameObject rewardIcon = dreamlightItem.View.RewardIcon;
					int active3 = 0;
					rewardIcon.SetActive((byte)active3 != 0);
				}
				if (num4 == 0)
				{
					if (flag2)
					{
						DreamlightItemView _003CView_003Ek__BackingField3 = dreamlightItem.View;
						dreamlightItem.Phases[1]?.Invoke();
						dreamlightItem.ClaimButton.View.Label.StringID = "menu.label_claim";
						UnityEvent[] uiEvents = dreamlightItem.View.UiEvents;
					}
					DreamlightItemView _003CView_003Ek__BackingField4 = dreamlightItem.View;
					UnityEvent unityEvent = dreamlightItem.Phases[0];
					if (unityEvent == null)
					{
						continue;
					}
					unityEvent.Invoke();
					UnityEvent unityEvent2 = dreamlightItem.View.UiEvents[0];
					if (unityEvent2 == null)
					{
						break;
					}
					unityEvent2.Invoke();
				}
				TextBase progress2 = dreamlightItem.Progress;
				string text12 = (progress2.Text = text10 + "/" + text10);
				dreamlightItem.View.UiEvents[0]?.Invoke();
				dreamlightItem.Phases[2]?.Invoke();
				dreamlightItem.ClaimButton.View.Label.StringID = "";
				dreamlightItem.ClaimButton.View.Label.Text = "";
				dreamlightItem.RewardAmount.TextComponent.fontSize = 30f;
				dreamlightItem.RewardAmount.StringID = "menu.common_claimed";
				GameObject lockedIcon2 = dreamlightItem.View.LockedIcon;
				int active4 = 0;
				lockedIcon2.SetActive((byte)active4 != 0);
				GameObject rewardIcon2 = dreamlightItem.View.RewardIcon;
				int active5 = 0;
				rewardIcon2.SetActive((byte)active5 != 0);
				GameObject giftIcon2 = dreamlightItem.View.GiftIcon;
				int active6 = 0;
				giftIcon2.SetActive((byte)active6 != 0);
				dreamlightItem.CanvasGroupAlpha.alpha = 0.5f;
				break;
			}
			dreamlightItem.RedDot.gameObject.SetActive(flag2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B61")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public BattlePassTaskItemModel()
		{
			((RandomNumberGenerator)(object)this)._002Ector();
		}
	}
}
