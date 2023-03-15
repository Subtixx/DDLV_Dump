using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Buildings;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002BC")]
	[RequiredAllNotNull]
	public class MoanaBoatPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000C91")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000C92")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000C93")]
		[SerializeField]
		private TextBase _tfLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000C94")]
		[SerializeField]
		private AsyncMenu _upgradePopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000C95")]
		[SerializeField]
		private MoanaBoatFishCaughtPanel _mcFishCaughtPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000C96")]
		[SerializeField]
		private ButtonTmPro _btnCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000C97")]
		[SerializeField]
		private UITimer _mcNextFishTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000C98")]
		[SerializeField]
		private TextBase _tfFishCap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000C99")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000C9A")]
		private FishingStall _currentStall;

		[Cpp2IlInjected.Token(Token = "0x600113A")]
		[Cpp2IlInjected.Address(RVA = "0x1294D60", Offset = "0x1293760", VA = "0x181294D60", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0081
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnCollect.ButtonComponent.m_OnClick;
			UnityAction call = OnCollectClickHandler;
			onClick.AddListener(call);
			UITimer mcNextFishTimer = _mcNextFishTimer;
			UITimer.TimerEventDelegate value = OnTimerCompeletedHandler;
			mcNextFishTimer.TimerComplete += value;
			MoanaBoatFishCaughtPanel mcFishCaughtPanel = _mcFishCaughtPanel;
			MoanaBoatFishCaughtPanel.HideEventDelegate b = OnHideFishCaughtPanelHandler;
			MoanaBoatFishCaughtPanel.HideEventDelegate onHide = mcFishCaughtPanel.OnHide;
			Delegate @delegate = Delegate.Combine(onHide, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onHide)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600113B")]
		[Cpp2IlInjected.Address(RVA = "0x12950D0", Offset = "0x1293AD0", VA = "0x1812950D0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0081
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnCollect.ButtonComponent.m_OnClick;
			UnityAction call = OnCollectClickHandler;
			onClick.RemoveListener(call);
			UITimer mcNextFishTimer = _mcNextFishTimer;
			UITimer.TimerEventDelegate value = OnTimerCompeletedHandler;
			mcNextFishTimer.TimerComplete -= value;
			MoanaBoatFishCaughtPanel mcFishCaughtPanel = _mcFishCaughtPanel;
			MoanaBoatFishCaughtPanel.HideEventDelegate value2 = OnHideFishCaughtPanelHandler;
			MoanaBoatFishCaughtPanel.HideEventDelegate onHide = mcFishCaughtPanel.OnHide;
			Delegate @delegate = Delegate.Remove(onHide, value2);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onHide)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600113C")]
		[Cpp2IlInjected.Address(RVA = "0x1294620", Offset = "0x1293020", VA = "0x181294620", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00c0
			//IL_0056: Expected O, but got I4
			base.OnPush(stack, param);
			Stall _003CCurrentStall_003Ek__BackingField = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			if ((object)_003CCurrentStall_003Ek__BackingField == null)
			{
			}
			int num = 0;
			_currentStall = (FishingStall)_003CCurrentStall_003Ek__BackingField;
			Image mcBlocker = _mcBlocker;
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
			UITimer mcNextFishTimer = _mcNextFishTimer;
			int num2 = 0;
			string text = (mcNextFishTimer.Prefix = LocalizationManager.FromStringID("menu.fishing_boat_next_fish_in", (IResolver)num2) + " ");
			MoanaBoatFishCaughtPanel mcFishCaughtPanel = _mcFishCaughtPanel;
			ListBase.ListEvents onItemData = mcFishCaughtPanel._fishList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(mcFishCaughtPanel.onFishItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = mcFishCaughtPanel._btnOkay.m_OnClick;
			UnityAction call = mcFishCaughtPanel.OnOkayClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600113D")]
		[Cpp2IlInjected.Address(RVA = "0x1294470", Offset = "0x1292E70", VA = "0x181294470", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0064
			//IL_002b: Expected O, but got I4
			base.OnFocusIn();
			_canvasGroup.alpha = 1f;
			Image mcBlocker = _mcBlocker;
			int num = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcBlocker, (Color)num, 0.3f);
			RectTransform mcContent = _mcContent;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetDelay(0.1f).SetEase(Ease.OutBack);
			base.IsDataUpToDate = true;
			RefreshStall();
		}

		[Cpp2IlInjected.Token(Token = "0x600113E")]
		[Cpp2IlInjected.Address(RVA = "0x1294A20", Offset = "0x1293420", VA = "0x181294A20", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__14))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__14 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__14(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600113F")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnCloseClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001140")]
		[Cpp2IlInjected.Address(RVA = "0x1294960", Offset = "0x1293360", VA = "0x181294960")]
		private void OnUpgradeClickHandler()
		{
			//Discarded unreachable code: IL_0038
			BuildingUpgradePopup.BuildingUpgradePopupParam buildingUpgradePopupParam = new BuildingUpgradePopup.BuildingUpgradePopupParam();
			UpgradableBuilding upgradableBuilding = (buildingUpgradePopupParam.UpgradableBuilding = _currentStall.GetComponent<UpgradableBuilding>());
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			AsyncMenu upgradePopup = _upgradePopup;
			menuStack.Push(upgradePopup, buildingUpgradePopupParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6001141")]
		[Cpp2IlInjected.Address(RVA = "0x1294950", Offset = "0x1293350", VA = "0x181294950")]
		private void OnTimerCompeletedHandler(object sender, object param)
		{
			RefreshStall();
		}

		[Cpp2IlInjected.Token(Token = "0x6001142")]
		[Cpp2IlInjected.Address(RVA = "0x1294280", Offset = "0x1292C80", VA = "0x181294280")]
		private void OnCollectClickHandler()
		{
			//Discarded unreachable code: IL_001d
			ButtonTmPro btnCollect = _btnCollect;
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001143")]
		[Cpp2IlInjected.Address(RVA = "0x1294160", Offset = "0x1292B60", VA = "0x181294160")]
		[AsyncStateMachine(typeof(_003CCollectTask_003Ed__19))]
		private Task CollectTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001144")]
		[Cpp2IlInjected.Address(RVA = "0x12945C0", Offset = "0x1292FC0", VA = "0x1812945C0")]
		private void OnHideFishCaughtPanelHandler()
		{
			//Discarded unreachable code: IL_002c
			_canvasGroup.alpha = 1f;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001145")]
		[Cpp2IlInjected.Address(RVA = "0x1294AA0", Offset = "0x12934A0", VA = "0x181294AA0")]
		public void RefreshStall()
		{
			//Discarded unreachable code: IL_003e, IL_0044, IL_0086, IL_009c
			//IL_00a8: Expected F4, but got I4
			FishingStall currentStall = _currentStall;
			TextBase tfLevel = _tfLevel;
			int upgradeLevel = currentStall.GetComponent<UpgradableBuilding>().UpgradeLevel;
			string text = default(string);
			tfLevel.Text = text;
			FishingStall currentStall2 = _currentStall;
			TextBase tfFishCap = _tfFishCap;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001146")]
		[Cpp2IlInjected.Address(RVA = "0x118CD20", Offset = "0x118B720", VA = "0x18118CD20", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			if ((redirectionType > RedirectionType.GamePromptClose && redirectionType == RedirectionType.GamePromptGoBackward) || redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePromptClose)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001147")]
		[Cpp2IlInjected.Address(RVA = "0x1294F40", Offset = "0x1293940", VA = "0x181294F40")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0070
			//IL_0015: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				MoanaBoatFishCaughtPanel mcFishCaughtPanel = _mcFishCaughtPanel;
				int num2 = 0;
				if (!mcFishCaughtPanel.gameObject.activeInHierarchy)
				{
					FocusNavigationElement componentInChildren = _btnCollect.GetComponentInChildren<FocusNavigationElement>();
				}
				FocusNavigationElement component = _mcFishCaughtPanel._btnOkay.GetComponent<FocusNavigationElement>();
				int num3 = 0;
				if (component != (UnityEngine.Object)num3)
				{
					base.MenuNavigation.FocusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001148")]
		[Cpp2IlInjected.Address(RVA = "0x1294420", Offset = "0x1292E20", VA = "0x181294420", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0022
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001149")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public MoanaBoatPopup()
		{
		}
	}
}
