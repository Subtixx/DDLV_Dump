using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002A3")]
	public class BuildingUpgradePopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20002A4")]
		public class BuildingUpgradePopupParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000BF6")]
			public UpgradableBuilding UpgradableBuilding;

			[Cpp2IlInjected.Token(Token = "0x600109E")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public BuildingUpgradePopupParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000BE1")]
		private UpgradeData _currentUpgradeInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000BE2")]
		private UpgradeData _nextUpgradeInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000BE3")]
		private RepeatedField<UpgradeData> _upgradeInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000BE4")]
		private UpgradableBuilding _upgradableBuilding;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000BE5")]
		[SerializeField]
		private CanvasGroup _mcCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000BE6")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000BE7")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000BE8")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000BE9")]
		[SerializeField]
		private Button _btnInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000BEA")]
		[SerializeField]
		private TextBase _tfStallLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000BEB")]
		[SerializeField]
		private TextBase _tfStallLevelLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000BEC")]
		[SerializeField]
		private BuildingCurrentLevelContent _mcCurrentStatContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000BED")]
		[SerializeField]
		private BuildingLevelStatsContent _mcLevelsStatContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000BEE")]
		[SerializeField]
		private BuildingUpgradeIcon _mcStallIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000BEF")]
		[SerializeField]
		private CurrencyContent _mcCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000BF0")]
		[SerializeField]
		private Button _btnBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000BF1")]
		[SerializeField]
		private ButtonTmProIcon _btnUpgrade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000BF2")]
		[SerializeField]
		private TextBase _tfUpgradeButtonLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000BF3")]
		[SerializeField]
		private SpriteAtlasImage _mcUpgradeButtonIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000BF4")]
		[SerializeField]
		private SpriteAtlasImage _mcUpgradeButtonLockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000BF5")]
		[SerializeField]
		private AK.Wwise.Event _upgradeSuccessSFX;

		[Cpp2IlInjected.Token(Token = "0x600108D")]
		[Cpp2IlInjected.Address(RVA = "0xA6BED0", Offset = "0xA6A8D0", VA = "0x180A6BED0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0094
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnInfo.m_OnClick;
			UnityAction call2 = OnInfoClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnBack.m_OnClick;
			UnityAction call3 = OnBackClickHandler;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnUpgrade.ButtonComponent.m_OnClick;
			UnityAction call4 = OnUpgradeClickHandler;
			onClick4.AddListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x600108E")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0A0", Offset = "0xA6AAA0", VA = "0x180A6C0A0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0094
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnInfo.m_OnClick;
			UnityAction call2 = OnInfoClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnBack.m_OnClick;
			UnityAction call3 = OnBackClickHandler;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnUpgrade.ButtonComponent.m_OnClick;
			UnityAction call4 = OnUpgradeClickHandler;
			onClick4.RemoveListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x600108F")]
		[Cpp2IlInjected.Address(RVA = "0xA6B0B0", Offset = "0xA69AB0", VA = "0x180A6B0B0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0033
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					_upgradableBuilding = (UpgradableBuilding)(object)param;
				}
			}
			Image mcBlocker = _mcBlocker;
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001090")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001091")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD60", Offset = "0xA69760", VA = "0x180A6AD60", Slot = "27")]
		public override void OnFocusIn()
		{
			//IL_0039: Expected O, but got I4
			base.OnFocusIn();
			RefreshBuildingInfo();
			base.IsDataUpToDate = true;
			_mcCurrencyContent?.Show();
			Image mcBlocker = _mcBlocker;
			int num = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcBlocker, (Color)num, 0.3f);
			RectTransform mcContent = _mcContent;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetDelay(0.1f).SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x6001092")]
		[Cpp2IlInjected.Address(RVA = "0xA6B3A0", Offset = "0xA69DA0", VA = "0x180A6B3A0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__27))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__27 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001093")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF10", Offset = "0xA69910", VA = "0x180A6AF10")]
		private void OnPurchaseSuccessfulHandler(bool purchaseSucceed)
		{
			//Discarded unreachable code: IL_0025
			if (purchaseSucceed)
			{
				CanvasGroup mcCanvasGroup = _mcCanvasGroup;
				int num = ((mcCanvasGroup.interactable = false) ? 1 : 0);
				CancellationToken cancellationToken = base.CancellationToken;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001094")]
		[Cpp2IlInjected.Address(RVA = "0xA6B1D0", Offset = "0xA69BD0", VA = "0x180A6B1D0")]
		private void OnUpgradeClickHandler()
		{
			//Discarded unreachable code: IL_0021
			CanvasGroup mcCanvasGroup = _mcCanvasGroup;
			int num = ((mcCanvasGroup.interactable = false) ? 1 : 0);
			CancellationToken cancellationToken = base.CancellationToken;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001095")]
		[Cpp2IlInjected.Address(RVA = "0xA6C270", Offset = "0xA6AC70", VA = "0x180A6C270")]
		[AsyncStateMachine(typeof(_003CUpgradeTask_003Ed__30))]
		private Task UpgradeTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001096")]
		[Cpp2IlInjected.Address(RVA = "0xA6AEA0", Offset = "0xA698A0", VA = "0x180A6AEA0")]
		private void OnInfoClickHandler()
		{
			//Discarded unreachable code: IL_003a
			_mcLevelsStatContent.Show();
			TextBase tfStallLabel = _tfStallLabel;
			BuildingLevelStatsContent mcLevelsStatContent = _mcLevelsStatContent;
			string stringID = tfStallLabel._stringID;
			RepeatedField<UpgradeData> upgradeInfo = _upgradeInfo;
			UpgradeData currentUpgradeInfo = _currentUpgradeInfo;
			mcLevelsStatContent.RefreshDisplay(currentUpgradeInfo, (RepeatedField<>)(object)upgradeInfo, stringID);
		}

		[Cpp2IlInjected.Token(Token = "0x6001097")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD30", Offset = "0xA69730", VA = "0x180A6AD30")]
		private void OnBackClickHandler()
		{
			//Discarded unreachable code: IL_000c
			_mcLevelsStatContent.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x6001098")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnCloseClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001099")]
		[Cpp2IlInjected.Address(RVA = "0xA6B360", Offset = "0xA69D60", VA = "0x180A6B360")]
		private void OnUpgradeFinished()
		{
			//Discarded unreachable code: IL_0013
			RefreshBuildingInfo();
			_mcCanvasGroup.interactable = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600109A")]
		[Cpp2IlInjected.Address(RVA = "0xA6B420", Offset = "0xA69E20", VA = "0x180A6B420")]
		private void RefreshBuildingInfo()
		{
			//Discarded unreachable code: IL_0091, IL_00f4, IL_00f9, IL_00fe, IL_0103, IL_011c, IL_0135, IL_014e, IL_0175, IL_018f, IL_032e
			//IL_00b5: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_0198: Expected I4, but got I8
			//IL_01d4: Expected I4, but got I8
			//IL_01eb: Expected I4, but got I8
			//IL_01fd: Expected I4, but got I8
			//IL_0238: Expected O, but got I4
			//IL_024f: Expected O, but got I4
			//IL_02f7: Expected I4, but got I8
			//IL_0319: Expected O, but got I4
			IItemData itemData = _upgradableBuilding.ItemData;
			if (itemData != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				_upgradeInfo = (RepeatedField<UpgradeData>)(object)itemData;
				UpgradableBuilding upgradableBuilding = _upgradableBuilding;
				TextBase tfStallLabel = _tfStallLabel;
				IItemData itemData2 = upgradableBuilding.ItemData;
				int upgradeLevel = _upgradableBuilding.UpgradeLevel;
				UpgradeData currentUpgradeInfo = default(UpgradeData);
				_currentUpgradeInfo = currentUpgradeInfo;
				int upgradeLevel2 = _upgradableBuilding.UpgradeLevel;
				UpgradeData nextUpgradeInfo = default(UpgradeData);
				_nextUpgradeInfo = nextUpgradeInfo;
				TextBase tfStallLevelLabel = _tfStallLevelLabel;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				int upgradeLevel3 = _upgradableBuilding.UpgradeLevel;
				upgradeLevel3++;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600109B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABC0", Offset = "0xA695C0", VA = "0x180A6ABC0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0091
			while (true)
			{
				if (redirectionType != RedirectionType.MenuNavGoBackward && redirectionType != RedirectionType.MenuNavGoBackward)
				{
					switch (redirectionType)
					{
					default:
						return;
					case RedirectionType.MenuNavGoBackward:
					{
						if (!_btnUpgrade.gameObject.activeSelf)
						{
							continue;
						}
						Button buttonComponent = _btnUpgrade.ButtonComponent;
						Button buttonComponent2 = _btnUpgrade.ButtonComponent;
						break;
					}
					case (RedirectionType)1:
						break;
					}
				}
				if (_mcLevelsStatContent.gameObject.activeSelf)
				{
					break;
				}
				if (_btnClose.gameObject.activeSelf)
				{
					Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
					while (onClick == null)
					{
					}
					onClick.Invoke();
					return;
				}
			}
			_mcLevelsStatContent.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x600109C")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public BuildingUpgradePopup()
		{
		}
	}
}
