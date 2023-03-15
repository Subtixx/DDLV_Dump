using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200048B")]
	public class EventReward : MonoBehaviour, IFocusNavigationOverrideFindNext
	{
		[Cpp2IlInjected.Token(Token = "0x200048C")]
		public delegate void RewardCollected(IItemData itemData, int amount);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001747")]
		[SerializeField]
		private RectTransform _progressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001748")]
		[SerializeField]
		private RectTransform _progressOngoing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001749")]
		[SerializeField]
		private RectTransform _progressCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400174A")]
		[SerializeField]
		private RectTransform _progressLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400174B")]
		[SerializeField]
		private TextBase _progressLockedMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400174C")]
		[SerializeField]
		private RectTransform _progressFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400174D")]
		[SerializeField]
		private BaseButton _btnNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400174E")]
		[SerializeField]
		private BaseButton _btnPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400174F")]
		[SerializeField]
		private HorizontalLayoutGroup _pageIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001750")]
		[SerializeField]
		private RectTransform _previewContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001751")]
		[SerializeField]
		private AsyncAtlassedIcon _previewIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001752")]
		[SerializeField]
		private TextBase _previewName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001753")]
		[SerializeField]
		private RectTransform _previewLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001754")]
		[SerializeField]
		private Image _previewLockedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001755")]
		[SerializeField]
		private Image _previewLockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001756")]
		[SerializeField]
		private TextBase _previewLockedLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001757")]
		[SerializeField]
		private RectTransform _previewCollected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001758")]
		[SerializeField]
		private Image _previewCompletedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001759")]
		[SerializeField]
		private Image _previewCompletedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400175A")]
		[SerializeField]
		private TextBase _previewCompletedLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400175B")]
		[SerializeField]
		private RectTransform _rewardContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400175C")]
		[SerializeField]
		private List<EventRewardItem> _listReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400175D")]
		[SerializeField]
		private EventRewardItem _concurrentRewardItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400175E")]
		[SerializeField]
		private TextBase _concurrentRewardMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400175F")]
		[SerializeField]
		private CustomButton _btnCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001760")]
		[SerializeField]
		private TextBase _tfCollectPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001761")]
		[SerializeField]
		private TextBase _tfCollected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001762")]
		[SerializeField]
		private TextBase _tfTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001763")]
		[SerializeField]
		private RewardPageIndicator _pagePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001764")]
		[SerializeField]
		private EventDisplayManager _eventDisplayManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001765")]
		[SerializeField]
		private AssetReferenceTexture _hardCurrencyPreviewIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001766")]
		[SerializeField]
		private AK.Wwise.Event _collectRewardSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001768")]
		private RewardPageIndicator _currentPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001769")]
		private int _currentPageIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400176A")]
		private BattlePassSeasonData _battlePassData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400176B")]
		private EventRewardItem _currentRewardItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400176C")]
		private bool _pageChanged;

		[Cpp2IlInjected.Token(Token = "0x14000037")]
		public event RewardCollected OnRewardCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001D7A")]
			[Cpp2IlInjected.Address(RVA = "0x140AB00", Offset = "0x1409500", VA = "0x18140AB00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001D7B")]
			[Cpp2IlInjected.Address(RVA = "0x140ABA0", Offset = "0x14095A0", VA = "0x18140ABA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7C")]
		[Cpp2IlInjected.Address(RVA = "0x140A2C0", Offset = "0x1408CC0", VA = "0x18140A2C0")]
		private void Start()
		{
			//Discarded unreachable code: IL_00e5, IL_00eb
			UnityEvent onClicked = _btnCollect.OnClicked;
			UnityAction call = OnCollectClick;
			onClicked.AddListener(call);
			UnityEvent onDehighlighted = _btnCollect.OnDehighlighted;
			UnityAction call2 = OnCollectDehighlighted;
			onDehighlighted.AddListener(call2);
			UnityEvent onHighlighted = _btnCollect.OnHighlighted;
			UnityAction call3 = OnCollectHighlighted;
			onHighlighted.AddListener(call3);
			Button.ButtonClickedEvent onClick = _btnNext.ButtonComponent.m_OnClick;
			UnityAction call4 = OnNextPage;
			onClick.AddListener(call4);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.ButtonComponent.m_OnClick;
			UnityAction call5 = OnPreviousPage;
			onClick2.AddListener(call5);
			List<EventRewardItem> listReward = _listReward;
			bool flag = default(bool);
			if (flag)
			{
				EventRewardItem.Selected selected = OnRewardSelected;
				EventRewardItem.GamepadClicked gamepadClicked = OnRewardGamepadClicked;
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7D")]
		[Cpp2IlInjected.Address(RVA = "0x14071F0", Offset = "0x1405BF0", VA = "0x1814071F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00e0, IL_00e6
			UnityEvent onClicked = _btnCollect.OnClicked;
			UnityAction call = OnCollectClick;
			onClicked.RemoveListener(call);
			UnityEvent onDehighlighted = _btnCollect.OnDehighlighted;
			UnityAction call2 = OnCollectDehighlighted;
			onDehighlighted.RemoveListener(call2);
			UnityEvent onHighlighted = _btnCollect.OnHighlighted;
			UnityAction call3 = OnCollectHighlighted;
			onHighlighted.RemoveListener(call3);
			Button.ButtonClickedEvent onClick = _btnNext.ButtonComponent.m_OnClick;
			UnityAction call4 = OnNextPage;
			onClick.RemoveListener(call4);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.ButtonComponent.m_OnClick;
			UnityAction call5 = OnPreviousPage;
			onClick2.RemoveListener(call5);
			List<EventRewardItem> listReward = _listReward;
			bool flag = default(bool);
			if (flag)
			{
				EventRewardItem.Selected selected = OnRewardSelected;
				EventRewardItem.GamepadClicked gamepadClicked = OnRewardGamepadClicked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7E")]
		[Cpp2IlInjected.Address(RVA = "0x1407610", Offset = "0x1406010", VA = "0x181407610")]
		private void OnNextPage()
		{
			//Discarded unreachable code: IL_00a0
			//IL_0010: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			RewardPageIndicator currentPage = _currentPage;
			int num = 0;
			if (currentPage == (UnityEngine.Object)num)
			{
				return;
			}
			HorizontalLayoutGroup pageIndicator = _pageIndicator;
			int currentPageIndex = _currentPageIndex;
			int childCount = pageIndicator.transform.childCount;
			if (currentPageIndex >= childCount)
			{
				return;
			}
			Transform transform = _pageIndicator.transform;
			int currentPageIndex2 = _currentPageIndex;
			currentPageIndex2++;
			Transform child = transform.GetChild(currentPageIndex2);
			int num2 = 0;
			if (child != (UnityEngine.Object)num2)
			{
				Transform transform2 = _pageIndicator.transform;
				int currentPageIndex3 = _currentPageIndex;
				currentPageIndex3++;
				Transform child2 = transform2.GetChild(currentPageIndex3);
				bool flag = default(bool);
				if (flag)
				{
					UpdateFocusRewardItem(FocusDirection.Right);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7F")]
		[Cpp2IlInjected.Address(RVA = "0x1407830", Offset = "0x1406230", VA = "0x181407830")]
		private void OnPreviousPage()
		{
			//Discarded unreachable code: IL_007a
			//IL_0010: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			RewardPageIndicator currentPage = _currentPage;
			int num = 0;
			if (currentPage == (UnityEngine.Object)num || _currentPageIndex == 0)
			{
				return;
			}
			Transform transform = _pageIndicator.transform;
			int currentPageIndex = _currentPageIndex;
			Transform child = transform.GetChild(currentPageIndex);
			int num2 = 0;
			if (child != (UnityEngine.Object)num2)
			{
				Transform transform2 = _pageIndicator.transform;
				int currentPageIndex2 = _currentPageIndex;
				Transform child2 = transform2.GetChild(currentPageIndex2);
				bool flag = default(bool);
				if (flag)
				{
					int focusDirection = 0;
					UpdateFocusRewardItem((FocusDirection)focusDirection);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D80")]
		[Cpp2IlInjected.Address(RVA = "0x140A9E0", Offset = "0x14093E0", VA = "0x18140A9E0")]
		private void UpdateFocusRewardItem(FocusDirection focusDirection)
		{
			//Discarded unreachable code: IL_0031
			IEnumerator routine = UIUtil.DelayedActionNextFrame(delegate
			{
				//Discarded unreachable code: IL_00c4
				FocusDirection focusDirection2 = focusDirection;
				if (focusDirection2 == FocusDirection.Left)
				{
					EventReward eventReward = this;
					if (eventReward._currentPage._isCurrencyConversionPage)
					{
					}
					EventRewardItem eventRewardItem = Enumerable.LastOrDefault<EventRewardItem>((IEnumerable<>)eventReward._listReward);
				}
				if (focusDirection2 == FocusDirection.Right)
				{
					EventReward eventReward2 = this;
					if (eventReward2._currentPage._isCurrencyConversionPage)
					{
					}
					EventRewardItem item = Enumerable.FirstOrDefault<EventRewardItem>((IEnumerable<>)eventReward2._listReward);
					eventReward2.OnRewardSelected(item);
				}
				int num = 0;
				EventsMenu menu = UiRoot.Instance._menuStack.GetMenu<EventsMenu>();
				if ((object)menu != null)
				{
					MenuNavigation menuNavigation = menu.MenuNavigation;
					if ((object)menuNavigation != null)
					{
						FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
						if ((object)focusNavigation != null)
						{
							FocusNavigationElement component = _currentRewardItem.GetComponent<FocusNavigationElement>();
							focusNavigation.SetFocus(component);
						}
					}
				}
				_currentRewardItem?.Click();
			});
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D81")]
		[Cpp2IlInjected.Address(RVA = "0x14085F0", Offset = "0x1406FF0", VA = "0x1814085F0")]
		private void RefreshRewardDisplay()
		{
			//Discarded unreachable code: IL_00be, IL_00c4, IL_00ca
			//IL_007e: Expected I4, but got I8
			int num = 0;
			RewardPageIndicator currentPage = _currentPage;
			if ((object)currentPage != null)
			{
				BattlePassRewardsPage pageData = currentPage._pageData;
				if (pageData != null)
				{
					RepeatedField<BattlePassReward> rewards_ = pageData.rewards_;
					if (rewards_ != null)
					{
						List<BattlePassReward> list = (List<BattlePassReward>)(object)Enumerable.ToList<BattlePassReward>((IEnumerable<>)(object)rewards_);
					}
				}
			}
			List<EventRewardItem> listReward = _listReward;
			bool flag = default(bool);
			if (flag)
			{
				int active = 0;
				GameObject gameObject = default(GameObject);
				gameObject.SetActive((byte)active != 0);
			}
			int num2 = 0;
			int active2 = 0;
			GameObject gameObject2 = default(GameObject);
			gameObject2.SetActive((byte)active2 != 0);
			int active3 = 0;
			GameObject gameObject3 = default(GameObject);
			gameObject3.SetActive((byte)active3 != 0);
			if ((long)num2 < (long)(IntPtr)gameObject3)
			{
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				if ((object)gameObject3 == null)
				{
				}
				int num4 = 0;
				GameObject gameObject4 = default(GameObject);
				ulong num5 = default(ulong);
				gameObject4.SetActive((byte)num5 != 0);
				num2++;
				uint num6 = num6 + 8;
			}
			GameObject gameObject5 = default(GameObject);
			bool activeSelf = gameObject5.activeSelf;
			GameObject gameObject6 = default(GameObject);
			gameObject6.SetActive(activeSelf);
			int active4 = 0;
			GameObject gameObject7 = default(GameObject);
			gameObject7.SetActive((byte)active4 != 0);
			int num7 = default(int);
			bool active5 = num2 != num7;
			GameObject gameObject8 = default(GameObject);
			gameObject8.SetActive(active5);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D82")]
		[Cpp2IlInjected.Address(RVA = "0x1406710", Offset = "0x1405110", VA = "0x181406710")]
		private int GetPreviousRewardPageRequirement(BattlePassRewardsPage page)
		{
			int num = ((RepeatedField<T>)(object)_battlePassData.rewardsPages_).IndexOf((T)page);
			if (page.unlockRequirementCase_ == BattlePassRewardsPage.UnlockRequirementOneofCase.UnlockRequirementReward && !page.isCurrencyConversionPage_)
			{
				int minPurchased_ = page.UnlockRequirementReward.minPurchased_;
				int num2 = 0;
				RepeatedField<BattlePassReward> rewards_ = ((BattlePassRewardsPage)((RepeatedField<T>)(object)_battlePassData.rewardsPages_)[num2]).rewards_;
				Func<BattlePassReward, bool> _003C_003E9__47_ = _003C_003Ec._003C_003E9__47_1;
				if (_003C_003E9__47_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassReward x) => !x.isPremium_);
				}
				int num3 = Enumerable.Count<BattlePassReward>(Enumerable.Where<BattlePassReward>((IEnumerable<>)(object)rewards_, (Func<, >)(object)_003C_003E9__47_));
				num2 += num3;
				num2++;
				RepeatedField<BattlePassRewardsPage> rewardsPages_ = _battlePassData.rewardsPages_;
				int index = num - 1;
				RepeatedField<BattlePassReward> rewards_2 = ((BattlePassRewardsPage)((RepeatedField<T>)(object)rewardsPages_)[index]).rewards_;
				Func<BattlePassReward, bool> func = default(Func<BattlePassReward, bool>);
				if (_003C_003Ec._003C_003E9__47_0 == null)
				{
					func = (Func<BattlePassReward, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassReward x) => !x.isPremium_));
				}
				int num4 = Enumerable.Count<BattlePassReward>(Enumerable.Where<BattlePassReward>((IEnumerable<>)(object)rewards_2, (Func<, >)(object)func));
				if (minPurchased_ < num2)
				{
					num4 -= num2;
					int num5 = 0;
				}
				int result = default(int);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D83")]
		[Cpp2IlInjected.Address(RVA = "0x1406A80", Offset = "0x1405480", VA = "0x181406A80")]
		private bool IsPageLocked(BattlePassRewardsPage page)
		{
			//Discarded unreachable code: IL_0109, IL_010f, IL_0115, IL_011b
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((page.isCurrencyConversionPage_ ? 1 : 0) == num2)
			{
				goto IL_0065;
			}
			if ((_eventDisplayManager.isPremiumUnlocked ? 1 : 0) != num3)
			{
				RepeatedField<BattlePassRewardsPage> rewardsPages_ = _battlePassData.rewardsPages_;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					if (flag2)
					{
						if (!_eventDisplayManager.GetRewardCollectedStatus(num3, num3))
						{
							num3++;
						}
						num3++;
					}
					num3++;
					if (num3 != 0)
					{
					}
					num3++;
				}
				num3++;
				if (num3 != 0)
				{
					goto IL_0065;
				}
			}
			goto IL_0103;
			IL_0065:
			BattlePassRewardsPage.UnlockRequirementOneofCase unlockRequirementCase_ = page.unlockRequirementCase_;
			int num4 = ((RepeatedField<T>)(object)_battlePassData.rewardsPages_).IndexOf((T)page);
			switch (unlockRequirementCase_)
			{
			case BattlePassRewardsPage.UnlockRequirementOneofCase.UnlockRequirementTask:
			{
				int num5 = page.UnlockRequirementTask.minCollected_;
				RepeatedField<BattlePassTask> tasks_ = _battlePassData.taskConfig_.tasks_;
				Func<BattlePassTask, bool> func = (Func<BattlePassTask, bool>)(object)(Func<T, TResult>)((BattlePassTask x) => _eventDisplayManager.GetTaskCollectedStatus(x));
				return Enumerable.Count<BattlePassTask>(Enumerable.Where<BattlePassTask>((IEnumerable<>)(object)tasks_, (Func<, >)(object)func)) < num5;
			}
			case BattlePassRewardsPage.UnlockRequirementOneofCase.UnlockRequirementReward:
			{
				UnlockRequirementReward unlockRequirementReward = default(UnlockRequirementReward);
				int minPurchased_ = unlockRequirementReward.minPurchased_;
				int num5 = default(int);
				int pageIndex2 = num5 - 1;
				int num6 = CollectedRewardCount(pageIndex2);
				int num7 = CollectedRewardCount(num3);
				num3 += num7;
				num3++;
				int num8 = default(int);
				if (num6 >= num8)
				{
				}
				break;
			}
			}
			goto IL_0103;
			IL_0103:
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6001D93")]
			[Cpp2IlInjected.Address(RVA = "0x140A810", Offset = "0x1409210", VA = "0x18140A810")]
			int CollectedRewardCount(int pageIndex)
			{
				//Discarded unreachable code: IL_0053
				int num9 = 0;
				int count = ((RepeatedField<T>)(object)_battlePassData.rewardsPages_).Count;
				if (pageIndex < count)
				{
					BattlePassRewardsPage battlePassRewardsPage = (BattlePassRewardsPage)((RepeatedField<T>)(object)_battlePassData.rewardsPages_)[pageIndex];
					if (battlePassRewardsPage != null)
					{
						RepeatedField<BattlePassReward> rewards_ = battlePassRewardsPage.rewards_;
						bool flag3 = default(bool);
						if (flag3)
						{
							if (_eventDisplayManager.GetRewardCollectedStatus(pageIndex, num9))
							{
								num9++;
							}
							num9++;
						}
					}
				}
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D84")]
		[Cpp2IlInjected.Address(RVA = "0x1408000", Offset = "0x1406A00", VA = "0x181408000")]
		private void RefreshProgress()
		{
			//Discarded unreachable code: IL_01ce
			//IL_016a: Expected O, but got I4
			//IL_01c2: Expected O, but got I4
			//IL_01c2: Expected O, but got I4
			//IL_01c2: Expected O, but got I4
			List<EventRewardItem> listReward = _listReward;
			Func<EventRewardItem, bool> _003C_003E9__49_ = _003C_003Ec._003C_003E9__49_0;
			if (_003C_003E9__49_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventRewardItem x) => x.gameObject.activeInHierarchy);
			}
			int num = Enumerable.Count<EventRewardItem>(Enumerable.Where<EventRewardItem>((IEnumerable<>)listReward, (Func<, >)(object)_003C_003E9__49_));
			List<EventRewardItem> listReward2 = _listReward;
			Func<EventRewardItem, bool> func = default(Func<EventRewardItem, bool>);
			if (_003C_003Ec._003C_003E9__49_1 == null)
			{
				func = (Func<EventRewardItem, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(EventRewardItem x)
				{
					//Discarded unreachable code: IL_0019
					bool activeInHierarchy = x.gameObject.activeInHierarchy;
					return (!activeInHierarchy) ? activeInHierarchy : x._isCollected;
				});
			}
			int num2 = Enumerable.Count<EventRewardItem>(Enumerable.Where<EventRewardItem>((IEnumerable<>)listReward2, (Func<, >)(object)func));
			TextBase tfCollected = _tfCollected;
			int num3 = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			tfCollected.Text = text;
			TextBase tfTotal = _tfTotal;
			int num4 = 0;
			CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
			string text2 = default(string);
			tfTotal.Text = text2;
			GameObject gameObject = _progressCompleted.gameObject;
			RewardPageIndicator currentPage = _currentPage;
			int num5 = 0;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _progressLocked.gameObject;
			RewardPageIndicator currentPage2 = _currentPage;
			int num6 = 0;
			bool active2 = (currentPage2._isCurrencyConversionPage ? 1 : 0) == num6;
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _progressOngoing.gameObject;
			RewardPageIndicator currentPage3 = _currentPage;
			int num7 = 0;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			RectTransform progressFull = _progressFull;
			RectTransform progressBar = _progressBar;
			Vector2 sizeDelta = progressFull.sizeDelta;
			Vector2 sizeDelta2 = _progressBar.sizeDelta;
			progressBar.sizeDelta = sizeDelta;
			if (!_currentPage._isCurrencyConversionPage)
			{
				TextBase progressLockedMessage = _progressLockedMessage;
				int num8 = 0;
				string format = LocalizationManager.FromStringID("menu.starpath_reward_locked", (IResolver)num8);
				BattlePassRewardsPage pageData = _currentPage._pageData;
				int previousRewardPageRequirement = GetPreviousRewardPageRequirement(pageData);
				RepeatedField<BattlePassRewardsPage> rewardsPages_ = _battlePassData.rewardsPages_;
				int currentPageIndex = _currentPageIndex;
				int count = ((RepeatedField<T>)(object)((BattlePassRewardsPage)((RepeatedField<T>)(object)rewardsPages_)[currentPageIndex]).rewards_).Count;
				int currentPageIndex2 = _currentPageIndex;
				string text4 = (progressLockedMessage.Text = string.Format(format, previousRewardPageRequirement, count, count));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D85")]
		[Cpp2IlInjected.Address(RVA = "0x140A000", Offset = "0x1408A00", VA = "0x18140A000")]
		private void SetPage(RewardPageIndicator pageItemCurrent, bool autoSelectReward = true)
		{
			//Discarded unreachable code: IL_008e
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			_currentPage = pageItemCurrent;
			_currentPageIndex = (flag2 ? 1 : 0);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				bool flag3 = (_pageChanged = autoSelectReward);
			}
			RefreshRewardDisplay();
			if (!autoSelectReward)
			{
				return;
			}
			EventRewardItem eventRewardItem = Enumerable.FirstOrDefault<EventRewardItem>((IEnumerable<>)_listReward);
			if (_pageChanged)
			{
				eventRewardItem._isSelected = false;
				eventRewardItem.RefreshDisplay();
			}
			bool flag4 = default(bool);
			if (!flag4)
			{
				bool flag5 = default(bool);
				if (flag5)
				{
				}
				_currentRewardItem = eventRewardItem;
				RefreshRewardPreview();
				_pageChanged = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D86")]
		[Cpp2IlInjected.Address(RVA = "0x1406F40", Offset = "0x1405940", VA = "0x181406F40")]
		private void OnCollectClick()
		{
			//Discarded unreachable code: IL_0049
			//IL_0010: Expected O, but got I4
			EventRewardItem currentRewardItem = _currentRewardItem;
			int num = 0;
			if (!(currentRewardItem == (UnityEngine.Object)num))
			{
				AK.Wwise.Event collectRewardSfx = _collectRewardSfx;
				if (collectRewardSfx != null)
				{
					GameObject gameObject = _btnCollect.gameObject;
					uint num2 = collectRewardSfx.Post(gameObject);
				}
				EventRewardItem currentRewardItem2 = _currentRewardItem;
				int num3 = 0;
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D87")]
		[Cpp2IlInjected.Address(RVA = "0x1407ED0", Offset = "0x14068D0", VA = "0x181407ED0")]
		[AsyncStateMachine(typeof(_003CPurchaseReward_003Ed__52))]
		private Task PurchaseReward(EventRewardItem item)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D88")]
		[Cpp2IlInjected.Address(RVA = "0x1409EA0", Offset = "0x14088A0", VA = "0x181409EA0")]
		public void SetFocus(FocusNavigation focusNav)
		{
			//IL_0010: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			RewardPageIndicator currentPage = _currentPage;
			int num = 0;
			if (currentPage == (UnityEngine.Object)num)
			{
				return;
			}
			if (!_currentPage._isCurrencyConversionPage)
			{
				EventRewardItem currentRewardItem = _currentRewardItem;
				int num2 = 0;
				if (!(currentRewardItem != (UnityEngine.Object)num2))
				{
				}
			}
			if (_currentPage._isCurrencyConversionPage)
			{
				FocusNavigationElement componentInChildren = _concurrentRewardItem.GetComponentInChildren<FocusNavigationElement>();
				focusNav.SetFocus(componentInChildren);
				return;
			}
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D89")]
		[Cpp2IlInjected.Address(RVA = "0x1409E70", Offset = "0x1408870", VA = "0x181409E70")]
		public void Refresh(BattlePassSeasonData battlePassData)
		{
			_battlePassData = battlePassData;
			RefreshRewardPage();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8A")]
		[Cpp2IlInjected.Address(RVA = "0x1408AC0", Offset = "0x14074C0", VA = "0x181408AC0")]
		private void RefreshRewardPage()
		{
			//Discarded unreachable code: IL_00ff, IL_0105, IL_0117
			//IL_001a: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			int num = 0;
			int count = ((RepeatedField<T>)(object)_battlePassData.rewardsPages_).Count;
			_currentPage = (RewardPageIndicator)num;
			int num2 = 0;
			EventsMenu menu = UiRoot.Instance._menuStack.GetMenu<EventsMenu>();
			if ((object)menu == null || (object)menu.MenuNavigation != null)
			{
			}
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			int index = default(int);
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num4 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num4 && num4 != 0)
				{
					int num5 = 0;
					if (num4 != 0)
					{
						int num6 = 0;
						RewardPageIndicator rewardPageIndicator = default(RewardPageIndicator);
						if (rewardPageIndicator != (UnityEngine.Object)num6)
						{
							RewardPageIndicator rewardPageIndicator2 = default(RewardPageIndicator);
							index = ((PageIndicator)rewardPageIndicator2)._index;
						}
					}
				}
			}
			IEnumerator enumerator = _pageIndicator.transform.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num7 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num8 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			int num9 = 0;
			if ((object)gameObject != null)
			{
				int num10 = 0;
			}
			RewardPageIndicator rewardPageIndicator3 = default(RewardPageIndicator);
			PageIndicator.Selected value = default(PageIndicator.Selected);
			rewardPageIndicator3.OnSelected += value;
			if (num9 == 0)
			{
			}
			int num11 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0) && index > -1 && num9 == index)
			{
				FocusNavigationElement component = rewardPageIndicator3.GetComponent<FocusNavigationElement>();
			}
			num9++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8B")]
		[Cpp2IlInjected.Address(RVA = "0x1407130", Offset = "0x1405B30", VA = "0x181407130")]
		private void OnCollectDehighlighted()
		{
			//Discarded unreachable code: IL_002e, IL_003b
			ButtonViewDefault view = _btnCollect.View;
			if ((object)view != null)
			{
				ImageHelper background = view.Background;
				if ((object)background != null)
				{
					CustomButton btnCollect = _btnCollect;
					background.SetAlpha(1f);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8C")]
		[Cpp2IlInjected.Address(RVA = "0x14071B0", Offset = "0x1405BB0", VA = "0x1814071B0")]
		private void OnCollectHighlighted()
		{
			//Discarded unreachable code: IL_0026
			//IL_0024: Expected F4, but got I4
			ButtonViewDefault view = _btnCollect.View;
			if ((object)view != null)
			{
				ImageHelper background = view.Background;
				if ((object)background != null)
				{
					int num = 0;
					background.SetAlpha(num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8D")]
		[Cpp2IlInjected.Address(RVA = "0x14077A0", Offset = "0x14061A0", VA = "0x1814077A0")]
		private void OnPageSelected(PageIndicator item)
		{
			if ((object)item != null)
			{
				int num = 0;
				if ((object)item == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8E")]
		[Cpp2IlInjected.Address(RVA = "0x1407DA0", Offset = "0x14067A0", VA = "0x181407DA0")]
		private void OnRewardSelected(EventRewardItem item)
		{
			//Discarded unreachable code: IL_0033
			if (_pageChanged)
			{
				item._isSelected = false;
				item.RefreshDisplay();
			}
			bool flag = default(bool);
			if (!flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				_currentRewardItem = item;
				RefreshRewardPreview();
				_pageChanged = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8F")]
		[Cpp2IlInjected.Address(RVA = "0x1407990", Offset = "0x1406390", VA = "0x181407990")]
		private void OnRewardGamepadClicked(EventRewardItem item)
		{
			//Discarded unreachable code: IL_013f
			//IL_0010: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			EventRewardItem currentRewardItem = _currentRewardItem;
			int num = 0;
			if (!(currentRewardItem == (UnityEngine.Object)num))
			{
				EventRewardItem currentRewardItem2 = _currentRewardItem;
			}
			if (!item._isSelected)
			{
				item._btn?.PostWwiseEvent();
				item._isSelected = true;
				item.RefreshDisplay();
				item.OnSelected?.Invoke(item);
			}
			EventDisplayManager eventDisplayManager = _eventDisplayManager;
			int _003CIndex_003Ek__BackingField = item.Index;
			int currentPageIndex = _currentPageIndex;
			if (!eventDisplayManager.GetRewardCollectedStatus(currentPageIndex, _003CIndex_003Ek__BackingField))
			{
			}
			BattlePassReward rewardData = item.RewardData;
			int num2 = 0;
			bool flag = (rewardData.isRecurrent_ ? 1 : 0) == num2;
			if (item.IsLockedByPremium || item.IsLockedByPage || flag || item.IsCollectable == flag)
			{
				return;
			}
			DateTime dateTime = _battlePassData.endDate_.date_.ToDateTime();
			Client client = default(Client);
			DateTime serverTime = client.ServerTime;
			if (!(dateTime > serverTime))
			{
				return;
			}
			EventRewardItem currentRewardItem3 = _currentRewardItem;
			int num3 = 0;
			if (!(currentRewardItem3 == (UnityEngine.Object)num3))
			{
				AK.Wwise.Event collectRewardSfx = _collectRewardSfx;
				if (collectRewardSfx != null)
				{
					GameObject gameObject = _btnCollect.gameObject;
					uint num4 = collectRewardSfx.Post(gameObject);
				}
				EventRewardItem currentRewardItem4 = _currentRewardItem;
				int num5 = 0;
				int num6 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D90")]
		[Cpp2IlInjected.Address(RVA = "0x1409090", Offset = "0x1407A90", VA = "0x181409090")]
		internal void RefreshRewardPreview()
		{
			//Discarded unreachable code: IL_020a, IL_0240, IL_0249, IL_02bb, IL_031a, IL_033e, IL_034c, IL_0376, IL_0420
			//IL_0010: Expected O, but got I4
			//IL_01e2: Expected O, but got I4
			//IL_01fb: Expected O, but got I4
			EventRewardItem currentRewardItem = _currentRewardItem;
			int num = 0;
			if (currentRewardItem != (UnityEngine.Object)num && (long)_currentRewardItem.RewardData != 0)
			{
				long num2 = Convert.ToInt64((uint)_currentRewardItem.RewardData.itemId_);
			}
			int num3 = 0;
			_previewContainer.gameObject.SetActive((byte)num3 != 0);
			if (num3 != 0)
			{
				EventRewardItem currentRewardItem2 = _currentRewardItem;
				EventDisplayManager eventDisplayManager = _eventDisplayManager;
				int _003CIndex_003Ek__BackingField = currentRewardItem2.Index;
				int currentPageIndex = _currentPageIndex;
				if (!eventDisplayManager.GetRewardCollectedStatus(currentPageIndex, _003CIndex_003Ek__BackingField))
				{
				}
				BattlePassReward rewardData = _currentRewardItem.RewardData;
				int num4 = 0;
				bool flag = (rewardData.isRecurrent_ ? 1 : 0) == num4;
				TextMeshProUGUI textComponent = _previewName.TextComponent;
				BattlePassUIGameColors gameColors = _eventDisplayManager._gameColors;
				EventDisplayManager eventDisplayManager2 = _eventDisplayManager;
				Image previewLockedBg = _previewLockedBg;
				BattlePassUIGameColors gameColors2 = eventDisplayManager2._gameColors;
				TextBase previewLockedLabel = _previewLockedLabel;
				Image previewLockedIcon = _previewLockedIcon;
				TextMeshProUGUI textComponent2 = previewLockedLabel.TextComponent;
				BattlePassUIGameColors gameColors3 = _eventDisplayManager._gameColors;
				EventDisplayManager eventDisplayManager3 = _eventDisplayManager;
				Image previewCompletedBg = _previewCompletedBg;
				BattlePassUIGameColors gameColors4 = eventDisplayManager3._gameColors;
				TextBase previewCompletedLabel = _previewCompletedLabel;
				Image previewCompletedIcon = _previewCompletedIcon;
				TextMeshProUGUI textComponent3 = previewCompletedLabel.TextComponent;
				BattlePassUIGameColors gameColors5 = _eventDisplayManager._gameColors;
				AsyncAtlassedIcon previewIcon = _previewIcon;
				Color white = Color.white;
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Currency)
				{
					int num5 = 0;
					Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
					int num6 = 0;
					bool flag2 = default(bool);
					if (flag2)
					{
						string assetGUID = _hardCurrencyPreviewIcon.AssetGUID;
					}
				}
				ItemType itemType2 = default(ItemType);
				DecalItemData decalItemData = default(DecalItemData);
				if (itemType2 == ItemType.Decal && decalItemData.allowColoring_)
				{
					EventDisplayManager eventDisplayManager4 = _eventDisplayManager;
					AsyncAtlassedIcon previewIcon2 = _previewIcon;
					BattlePassUIGameColors gameColors6 = eventDisplayManager4._gameColors;
				}
				AsyncAtlassedIcon previewIcon3 = _previewIcon;
				ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
				int num7 = 0;
				string icon = default(string);
				bool flag3 = previewIcon3.SetIcon(icon);
				TextBase previewName = _previewName;
				ItemType itemType3 = default(ItemType);
				string text = default(string);
				if (itemType3 == ItemType.Decal)
				{
					int num8 = 0;
					int num9 = 0;
					text = LocalizationManager.FromStringID("menu.common_decal_name", (IResolver)num9);
				}
				if ((long)text != 12)
				{
					int num10 = 0;
					int num11 = 0;
					string text2 = LocalizationManager.FromStringID(text, (IResolver)num11);
				}
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			FocusNavigationElement component = _btnCollect.GetComponent<FocusNavigationElement>();
			bool flag4 = (component.IgnoreThis = !_btnCollect.gameObject.activeInHierarchy);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D91")]
		[Cpp2IlInjected.Address(RVA = "0x140A750", Offset = "0x1409150", VA = "0x18140A750", Slot = "4")]
		public bool TryFindNextFocusElement(FocusDirection direction, int input, FocusNavigationElement currentElement, out ISupportsFocusNavigation nextElement)
		{
			ISupportsFocusNavigation[] componentsInChildren = GetComponentsInChildren<ISupportsFocusNavigation>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D92")]
		[Cpp2IlInjected.Address(RVA = "0x140AAE0", Offset = "0x14094E0", VA = "0x18140AAE0")]
		public EventReward()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
