using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004F5")]
	public class NotEnoughCurrencyPopUp : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001A6B")]
		private int _lackingAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001A6C")]
		private NotEnoughCurrencyArgs _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001A6D")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001A6E")]
		[SerializeField]
		private RectTransform _mcAnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001A6F")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001A70")]
		[SerializeField]
		private TextBase _tfBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001A71")]
		[SerializeField]
		private RectTransform _mcPricesHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001A72")]
		[SerializeField]
		private GameObject _mcPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001A73")]
		[SerializeField]
		private AsyncAtlassedIcon _mcCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001A74")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001A75")]
		[SerializeField]
		private GameObject _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001A76")]
		[SerializeField]
		private GameObject _btnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001A77")]
		[SerializeField]
		private GameObject _btnGo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001A78")]
		[SerializeField]
		private GameObject _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001A79")]
		[SerializeField]
		private TextBase _tfGo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001A7A")]
		[SerializeField]
		private GameObject _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001A7B")]
		public AK.Wwise.Event sfxInitEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001A7C")]
		public Switch sfxInitSwitch;

		[Cpp2IlInjected.Token(Token = "0x600204A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600204B")]
		[Cpp2IlInjected.Address(RVA = "0xE1AEF0", Offset = "0xE198F0", VA = "0x180E1AEF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			base.UnregisterFocusedListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x600204C")]
		[Cpp2IlInjected.Address(RVA = "0x129D5B0", Offset = "0x129BFB0", VA = "0x18129D5B0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_006f
			base.OnPush(stack, param);
			if (param == null)
			{
				return;
			}
			int num = 0;
			if (param != null)
			{
				int num2 = 0;
				_param = (NotEnoughCurrencyArgs)param;
				NotEnoughCurrencyArgs param2 = _param;
				if ((long)param2.ProductItems == 0)
				{
					List<Item> list = (param2.ProductItems = (List<Item>)(object)new List<T>());
				}
				Switch @switch = sfxInitSwitch;
				GameObject value = base.gameObject;
				@switch.SetValue(value);
				AK.Wwise.Event @event = sfxInitEvent;
				GameObject gameObject = base.gameObject;
				uint num3 = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600204D")]
		[Cpp2IlInjected.Address(RVA = "0x129D3E0", Offset = "0x129BDE0", VA = "0x18129D3E0", Slot = "26")]
		public override void OnPop()
		{
			TweenMax.KillAllByCancelationToken(this);
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x600204E")]
		[Cpp2IlInjected.Address(RVA = "0x129CD90", Offset = "0x129B790", VA = "0x18129CD90", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0111
			//IL_0043: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			base.OnFocusIn();
			RefreshData();
			base.IsDataUpToDate = true;
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				if (top == null)
				{
				}
			}
			int num5 = 0;
			if ((Object)num3 != (Object)num5)
			{
				int num6 = 0;
				GameObject gameObject = default(GameObject);
				if (gameObject != (Object)num6)
				{
					GameObject gameObject2 = default(GameObject);
					Canvas component = gameObject2.GetComponent<Canvas>();
					int num7 = 0;
					if (component == (Object)num7)
					{
						GameObject gameObject3 = default(GameObject);
						Canvas canvas = gameObject3.AddComponent<Canvas>();
						GameObject gameObject4 = default(GameObject);
						GraphicRaycaster graphicRaycaster = gameObject4.AddComponent<GraphicRaycaster>();
						int num8 = 0;
						Canvas component2 = UiRoot.Instance._popupStack.GetComponent<Canvas>();
						canvas.overrideSorting = true;
						int num9 = (canvas.sortingLayerID = component2.sortingLayerID);
						int sortingOrder = 0;
						int sortingOrder2 = component2.sortingOrder;
						canvas.sortingOrder = sortingOrder;
						SlidingPanel slidingPanel = default(SlidingPanel);
						slidingPanel?.Show(andOpen: true);
						LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num3);
					}
				}
			}
			RectTransform mcAnimatedContent = _mcAnimatedContent;
			float z = Vector3.zero.z;
			RectTransform mcAnimatedContent2 = _mcAnimatedContent;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x600204F")]
		[Cpp2IlInjected.Address(RVA = "0x129D150", Offset = "0x129BB50", VA = "0x18129D150", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0095
			//IL_0038: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			base.OnFocusOut(popAfterFocusOut, animate);
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				if (top == null)
				{
				}
			}
			int num5 = 0;
			if (!((Object)num3 != (Object)num5))
			{
				return;
			}
			int num6 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject != (Object)num6)
			{
				GameObject gameObject2 = default(GameObject);
				Canvas component = gameObject2.GetComponent<Canvas>();
				GameObject gameObject3 = default(GameObject);
				GraphicRaycaster component2 = gameObject3.GetComponent<GraphicRaycaster>();
				int num7 = 0;
				if (component2 != (Object)num7)
				{
					Object.Destroy(component2);
				}
				int num8 = 0;
				if (component != (Object)num8)
				{
					Object.Destroy(component);
				}
				SlidingPanel slidingPanel = default(SlidingPanel);
				slidingPanel?.Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002050")]
		[Cpp2IlInjected.Address(RVA = "0x129CD20", Offset = "0x129B720", VA = "0x18129CD20")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_001e
			PopSelf();
			_param.CancelCallback?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002051")]
		[Cpp2IlInjected.Address(RVA = "0x129D440", Offset = "0x129BE40", VA = "0x18129D440")]
		public void OnPurchseClicked()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002052")]
		[Cpp2IlInjected.Address(RVA = "0x129D890", Offset = "0x129C290", VA = "0x18129D890")]
		[AsyncStateMachine(typeof(_003CPurchaseWithHardCurrency_003Ed__26))]
		private Task PurchaseWithHardCurrency(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002053")]
		[Cpp2IlInjected.Address(RVA = "0x129D740", Offset = "0x129C140", VA = "0x18129D740")]
		public void OnRedirectionClicked()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002054")]
		[Cpp2IlInjected.Address(RVA = "0x129DAB0", Offset = "0x129C4B0", VA = "0x18129DAB0")]
		private void RefreshData()
		{
			//Discarded unreachable code: IL_0154
			//IL_006b: Expected O, but got I4
			//IL_0102: Expected O, but got I4
			//IL_014d: Expected O, but got I4
			NotEnoughCurrencyArgs param = _param;
			if (param == null)
			{
				return;
			}
			IItemData currencyItemData = param.CurrencyItemData;
			TextBase tfTitle = _tfTitle;
			string text = default(string);
			string text3 = (tfTitle.StringID = "menu.error_not_enough_currency_" + text + "_title");
			IItemData currencyItemData2 = _param.CurrencyItemData;
			string text4 = text3.ToLower();
			string stringID = "menu.error_not_enough_currency_" + text4 + "_message";
			int num = 0;
			string text5 = LocalizationManager.FromStringID(stringID, (IResolver)num);
			IItemData currencyItemData3 = _param.CurrencyItemData;
			if (text5 != null)
			{
				if (string.Equals(text5, "Gem"))
				{
					_btnCancel.SetActive(value: true);
					_tfGo.StringID = "menu.hud_btn_shop";
				}
				if (string.Equals(text5, "Heart"))
				{
					_btnCancel.SetActive(value: true);
					_tfGo.StringID = "menu.btn_go_phone";
				}
				if (string.Equals(text5, "StarCoin"))
				{
					_btnCancel.SetActive(value: true);
					int num2 = 0;
					string text6 = LocalizationManager.FromStringID("menu.error_not_enough_currency_starcoin_noshop_message", (IResolver)num2);
				}
			}
			_btnConfirm.SetActive(value: true);
			_tfBody.Text = text5;
			if ((object)_tfBody.TextComponent.transform != null)
			{
			}
			RectTransform mcContent = _mcContent;
			Vector2 sizeDelta = mcContent.sizeDelta;
			int num3 = 0;
			mcContent.sizeDelta = (Vector2)num3;
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002055")]
		[Cpp2IlInjected.Address(RVA = "0x129D9B0", Offset = "0x129C3B0", VA = "0x18129D9B0")]
		[AsyncStateMachine(typeof(_003CRedirect_003Ed__29))]
		public Task Redirect(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002056")]
		[Cpp2IlInjected.Address(RVA = "0x129CC10", Offset = "0x129B610", VA = "0x18129CC10", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
		}//Discarded unreachable code: IL_0001, IL_000f, IL_001b, IL_001f, IL_0026, IL_002a, IL_0031, IL_003f, IL_004d


		[Cpp2IlInjected.Token(Token = "0x6002057")]
		[Cpp2IlInjected.Address(RVA = "0x129DEA0", Offset = "0x129C8A0", VA = "0x18129DEA0")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_006b
			//IL_0026: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			FocusNavigation componentInChildren = GetComponentInChildren<FocusNavigation>();
			int num2 = 0;
			if (componentInChildren != (Object)num2 && (long)componentInChildren._focusedElement == 0)
			{
				if (_btnConfirm.activeSelf || !_btnPurchase.activeSelf)
				{
				}
				FocusNavigationElement component = _btnConfirm.transform.GetComponent<FocusNavigationElement>();
				componentInChildren.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002058")]
		[Cpp2IlInjected.Address(RVA = "0x129CD70", Offset = "0x129B770", VA = "0x18129CD70", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002059")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public NotEnoughCurrencyPopUp()
		{
		}
	}
}
