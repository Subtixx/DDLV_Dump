using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004F0")]
	public class NewItemPopUp : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20004F1")]
		public class NewItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001A5C")]
			public Item Item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4001A5D")]
			public int Amount;

			[Cpp2IlInjected.Token(Token = "0x6002041")]
			[Cpp2IlInjected.Address(RVA = "0xCCE870", Offset = "0xCCD270", VA = "0x180CCE870")]
			public NewItem(Item item, int amount)
			{
				//IL_0014: Expected O, but got I4
				int itemID = item.ItemID;
				base._002Ector();
				Item = (Item)itemID;
				Amount = amount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004F2")]
		public class NewItemPopupParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001A5E")]
			public List<NewItem> Items = (List<NewItem>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001A5F")]
			public bool UsePopupStack;

			[Cpp2IlInjected.Token(Token = "0x6002042")]
			[Cpp2IlInjected.Address(RVA = "0xCCE7F0", Offset = "0xCCD1F0", VA = "0x180CCE7F0")]
			public NewItemPopupParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001A53")]
		[SerializeField]
		private BaseButton _btnContinue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001A54")]
		[SerializeField]
		private CanvasGroup _btnCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001A55")]
		private NewItemPopupParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001A56")]
		[SerializeField]
		private GameObject _openingVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001A57")]
		[SerializeField]
		private CanvasGroup _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001A58")]
		[SerializeField]
		private ScrollRect _mcScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001A59")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001A5A")]
		[SerializeField]
		[Header("Prefabs")]
		private ShoppingCartItem _newItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001A5B")]
		[SerializeField]
		private DecalLibraryItem _newDecalItemPrefab;

		[Cpp2IlInjected.Token(Token = "0x6002034")]
		[Cpp2IlInjected.Address(RVA = "0x1299B30", Offset = "0x1298530", VA = "0x181299B30", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0036
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					_param = (NewItemPopupParam)param;
				}
			}
			GameObject openingVFX = _openingVFX;
			int active = 0;
			openingVFX.SetActive((byte)active != 0);
			base.MenuNavigation.RefreshAll(forcelyUpdate: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002035")]
		[Cpp2IlInjected.Address(RVA = "0x1299A00", Offset = "0x1298400", VA = "0x181299A00", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0060
			base.OnFocusIn();
			int num = 0;
			VibrationsManager.TriggerSuccess();
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_mcBackground, 1f, 0.35f);
			TweenCallback tweenCallback = delegate
			{
				ShowItems();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002036")]
		[Cpp2IlInjected.Address(RVA = "0x1299D40", Offset = "0x1298740", VA = "0x181299D40")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_001e
			FocusNavigationElement component = _btnContinue.GetComponent<FocusNavigationElement>();
			base.MenuNavigation.FocusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002037")]
		[Cpp2IlInjected.Address(RVA = "0x12999B0", Offset = "0x12983B0", VA = "0x1812999B0", Slot = "35")]
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

		[Cpp2IlInjected.Token(Token = "0x6002038")]
		[Cpp2IlInjected.Address(RVA = "0x1299C90", Offset = "0x1298690", VA = "0x181299C90", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_002c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnContinue.ButtonComponent.m_OnClick;
			UnityAction call = OnContinueClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002039")]
		[Cpp2IlInjected.Address(RVA = "0x129A3D0", Offset = "0x1298DD0", VA = "0x18129A3D0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_002c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnContinue.ButtonComponent.m_OnClick;
			UnityAction call = OnContinueClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600203A")]
		[Cpp2IlInjected.Address(RVA = "0x1299C10", Offset = "0x1298610", VA = "0x181299C10", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__17))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__17 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__17(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600203B")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnContinueClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x600203C")]
		[Cpp2IlInjected.Address(RVA = "0x1299DC0", Offset = "0x12987C0", VA = "0x181299DC0")]
		private void ShowItems()
		{
			//Discarded unreachable code: IL_0193, IL_0199, IL_019f, IL_01ab, IL_01b1, IL_01b7, IL_01bd, IL_01c3, IL_01c9, IL_01cf
			//IL_012a: Expected I4, but got O
			int num = 0;
			_openingVFX.SetActive(value: true);
			NewItemPopupParam param = _param;
			if (param == null)
			{
				return;
			}
			List<NewItem> items = param.Items;
			bool flag = default(bool);
			if (flag)
			{
				ScrollRect mcScrollRect = _mcScrollRect;
				RectTransform content = mcScrollRect.m_Content;
				bool flag2 = !mcScrollRect.m_Viewport.Contains(content);
				RectTransform content2 = _mcScrollRect.m_Content;
				Vector2 pivot = content2.pivot;
				if (flag2)
				{
				}
				Vector2 vector2 = (content2.pivot = pivot.WithX(0.5f));
				IItemData itemData = default(IItemData);
				DecalLibraryItem decalLibraryItem = default(DecalLibraryItem);
				if (itemData != null && itemData != null)
				{
					if (itemData == null)
					{
						throw new InvalidCastException();
					}
					DecalLibraryItem newDecalItemPrefab = _newDecalItemPrefab;
					RectTransform mcContent = _mcContent;
					decalLibraryItem = UnityEngine.Object.Instantiate(newDecalItemPrefab, mcContent);
					Color white = Color.white;
					Transform transform = decalLibraryItem.transform;
					float z = Vector3.zero.z;
					Transform transform2 = decalLibraryItem.transform;
					float z2 = Vector3.one.z;
					TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetDelay(0.5f).SetEase(Ease.OutBack);
					decalLibraryItem.DisableSelection();
				}
				ShoppingCartItem newItemPrefab = _newItemPrefab;
				RectTransform mcContent2 = _mcContent;
				ShoppingCartItem shoppingCartItem = UnityEngine.Object.Instantiate(newItemPrefab, mcContent2);
				shoppingCartItem.ItemData = (IItemData)decalLibraryItem;
				shoppingCartItem.Amount = (int)shoppingCartItem;
				shoppingCartItem.GiveItem = true;
				shoppingCartItem.Refresh();
				Transform transform3 = shoppingCartItem.transform;
				float z3 = Vector3.zero.z;
				Transform transform4 = shoppingCartItem.transform;
				float z4 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t2.SetDelay(0.5f).SetEase(Ease.OutBack);
				shoppingCartItem.DisableSelection();
				_mcContent.RebuildLayout();
				num++;
			}
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600203D")]
		[Cpp2IlInjected.Address(RVA = "0x1299920", Offset = "0x1298320", VA = "0x181299920", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0034
			BaseButton btnContinue = _btnContinue;
			if (btnContinue._isActive)
			{
				Button buttonComponent = btnContinue.ButtonComponent;
				_btnContinue.ButtonComponent.m_OnClick?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600203E")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public NewItemPopUp()
		{
		}
	}
}
