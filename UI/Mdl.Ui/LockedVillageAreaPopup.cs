using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004E9")]
	public class LockedVillageAreaPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20004EA")]
		public class LockedVillageAreaParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001A31")]
			public int RequiredLevel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4001A32")]
			public int CharacterRequired;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001A33")]
			public Item UnlockedCharacterRequired;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A34")]
			public CurrencyCost UnlockCost;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001A35")]
			public string Title;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001A36")]
			public bool IsRealm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4001A37")]
			public int RequiredMana;

			[Cpp2IlInjected.Token(Token = "0x6002019")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public LockedVillageAreaParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001A15")]
		private LockedVillageAreaParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001A16")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001A17")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001A18")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001A19")]
		[SerializeField]
		private ButtonTmPro _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001A1A")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001A1B")]
		[SerializeField]
		private AsyncAtlassedIcon _mcCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001A1C")]
		[SerializeField]
		private GameObject _mcCurrencyHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001A1D")]
		[SerializeField]
		private BaseButton _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001A1E")]
		[SerializeField]
		private TextBase _tfLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001A1F")]
		[SerializeField]
		private TextBase _tfLevelDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001A20")]
		[SerializeField]
		private TextBase _tfcurrentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001A21")]
		[SerializeField]
		private TextBase _tfCharactedDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001A22")]
		[SerializeField]
		private TextBase _tfCharactedCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001A23")]
		[SerializeField]
		private RectTransform _mcLevelReached;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001A24")]
		[SerializeField]
		private RectTransform _mcCharactersReached;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001A25")]
		[SerializeField]
		private RectTransform _mcCharacterUnlockedReached;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001A26")]
		[SerializeField]
		private TextBase _tfCharacterUnlockLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001A27")]
		[SerializeField]
		private AsyncAtlassedIcon _mcCharacterUnlockUniverseIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001A28")]
		[SerializeField]
		private GameObject _mcCharactersCounterInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001A29")]
		[SerializeField]
		private GameObject _mcCharactersUnlockInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001A2A")]
		[SerializeField]
		private GameObject _mcManaInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001A2B")]
		[SerializeField]
		private RectTransform _mcEnoughMana;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001A2C")]
		[SerializeField]
		private TextBase _tfManaLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001A2D")]
		[SerializeField]
		private GameObject _mcLevelInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001A2E")]
		private bool _hudCurrencyShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001A2F")]
		[SerializeField]
		private AK.Wwise.Event purchaseSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001A30")]
		[SerializeField]
		private Switch _purchaseFailedSwitch;

		[Cpp2IlInjected.Token(Token = "0x600200C")]
		[Cpp2IlInjected.Address(RVA = "0x1331590", Offset = "0x132FF90", VA = "0x181331590", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0051
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnConfirm.ButtonComponent.m_OnClick;
			UnityAction call = OnConfirmClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClose.ButtonComponent.m_OnClick;
			UnityAction call2 = OnCloseClickHandler;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x600200D")]
		[Cpp2IlInjected.Address(RVA = "0x13316B0", Offset = "0x13300B0", VA = "0x1813316B0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0051
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnConfirm.ButtonComponent.m_OnClick;
			UnityAction call = OnConfirmClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClose.ButtonComponent.m_OnClick;
			UnityAction call2 = OnCloseClickHandler;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x600200E")]
		[Cpp2IlInjected.Address(RVA = "0x13301F0", Offset = "0x132EBF0", VA = "0x1813301F0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_007a
			base.OnPush(stack, param);
			Switch purchaseFailedSwitch = _purchaseFailedSwitch;
			GameObject value = base.gameObject;
			purchaseFailedSwitch.SetValue(value);
			AK.Wwise.Event @event = purchaseSfx;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int num3 = 0;
			instance.UpdateCursorBehaviorForUI();
			if (param != null)
			{
				int num4 = 0;
				if (param != null)
				{
					int num5 = 0;
					_param = (LockedVillageAreaParam)param;
				}
			}
			Image mcBlocker = _mcBlocker;
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600200F")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002010")]
		[Cpp2IlInjected.Address(RVA = "0x132FC40", Offset = "0x132E640", VA = "0x18132FC40", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0065, IL_00c8
			//IL_0015: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			base.OnFocusIn();
			if (_param != null)
			{
			}
			if (string.IsNullOrEmpty((string)0))
			{
				int num = 0;
				int num2 = 0;
				string text = Mdl.LocalizationManager.FromStringID("menu.common_unlock", (IResolver)num2, (string)num);
			}
			LockedVillageAreaParam param = _param;
			TextBase tfTitle = _tfTitle;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			string title = _param.Title;
			int num3 = 0;
			int num4 = 0;
			string text2 = Mdl.LocalizationManager.FromStringID(title, (IResolver)num4, (string)num3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002011")]
		[Cpp2IlInjected.Address(RVA = "0x132FF50", Offset = "0x132E950", VA = "0x18132FF50", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_00a1
			//IL_0044: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			base.OnFocusOut(popAfterFocusOut, animate);
			if (!_hudCurrencyShown)
			{
				return;
			}
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
			if (!((UnityEngine.Object)num3 != (UnityEngine.Object)num5))
			{
				return;
			}
			int num6 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject != (UnityEngine.Object)num6)
			{
				GameObject gameObject2 = default(GameObject);
				Canvas component = gameObject2.GetComponent<Canvas>();
				GameObject gameObject3 = default(GameObject);
				GraphicRaycaster component2 = gameObject3.GetComponent<GraphicRaycaster>();
				int num7 = 0;
				if (component2 != (UnityEngine.Object)num7)
				{
					UnityEngine.Object.Destroy(component2);
				}
				int num8 = 0;
				if (component != (UnityEngine.Object)num8)
				{
					UnityEngine.Object.Destroy(component);
				}
				SlidingPanel slidingPanel = default(SlidingPanel);
				slidingPanel?.Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002012")]
		[Cpp2IlInjected.Address(RVA = "0x13303B0", Offset = "0x132EDB0", VA = "0x1813303B0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__35))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__35 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002013")]
		[Cpp2IlInjected.Address(RVA = "0x132FBB0", Offset = "0x132E5B0", VA = "0x18132FBB0")]
		private void OnConfirmClickHandler()
		{
			//Discarded unreachable code: IL_0026
			//IL_0024: Expected O, but got I4
			ButtonTmPro btnConfirm = _btnConfirm;
			PopSelf();
			_param?.AnswerAction((T)1);
		}

		[Cpp2IlInjected.Token(Token = "0x6002014")]
		[Cpp2IlInjected.Address(RVA = "0x132FB40", Offset = "0x132E540", VA = "0x18132FB40")]
		private void OnCloseClickHandler()
		{
			//Discarded unreachable code: IL_0023
			//IL_0021: Expected O, but got I4
			PopSelf();
			LockedVillageAreaParam param = _param;
			if (param != null)
			{
				Action<int> answerAction = param.AnswerAction;
				int num = 0;
				answerAction((T)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002015")]
		[Cpp2IlInjected.Address(RVA = "0x1330430", Offset = "0x132EE30", VA = "0x181330430")]
		private void RefreshRegionInfo()
		{
			//Discarded unreachable code: IL_003e, IL_0070, IL_00ef, IL_0102, IL_0119, IL_013d, IL_017b, IL_01a0, IL_01a5, IL_01ad, IL_01b5, IL_01c8, IL_01d1, IL_01de, IL_01e7, IL_0223, IL_0274, IL_02c0, IL_02d1, IL_02ed, IL_0301, IL_0306, IL_0318, IL_0325, IL_0340, IL_035d, IL_03d0, IL_03e5
			//IL_0079: Expected I4, but got I8
			//IL_00a0: Expected I4, but got I8
			//IL_00da: Expected I4, but got I8
			//IL_0146: Expected I4, but got I8
			//IL_0173: Expected O, but got I4
			//IL_0200: Expected I4, but got I8
			//IL_0243: Expected I4, but got I8
			//IL_0267: Expected I4, but got I8
			//IL_0292: Expected I4, but got I8
			//IL_02ac: Expected I4, but got I8
			//IL_02c9: Expected I4, but got I8
			//IL_0312: Expected O, but got I4
			//IL_033a: Expected O, but got I4
			//IL_035a: Expected O, but got I4
			//IL_0396: Expected I4, but got I8
			//IL_03c6: Expected I4, but got I8
			int num = 0;
			if ((IntPtr)_param != (IntPtr)num)
			{
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				TextBase tfCharactedDesc = _tfCharactedDesc;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				int characterRequired = _param.CharacterRequired;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002016")]
		[Cpp2IlInjected.Address(RVA = "0x132FA50", Offset = "0x132E450", VA = "0x18132FA50", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType != RedirectionType.MenuNavGoBackward)
			{
				if (redirectionType == RedirectionType.MenuNavGoForward)
				{
					goto IL_0058;
				}
				if (redirectionType != RedirectionType.MenuNavGoForward)
				{
					if (redirectionType == RedirectionType.MenuNavGoForward)
					{
						goto IL_0058;
					}
					if (redirectionType != (RedirectionType)1)
					{
						return;
					}
				}
			}
			BaseButton btnClose = _btnClose;
			if (btnClose._isActive)
			{
				Button buttonComponent = btnClose.ButtonComponent;
				_btnClose.ButtonComponent.m_OnClick?.Invoke();
			}
			return;
			IL_0058:
			Button buttonComponent2 = _btnConfirm.ButtonComponent;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002017")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public LockedVillageAreaPopup()
		{
		}
	}
}
