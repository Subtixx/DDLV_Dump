using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000308")]
	public class CollectionTabButton : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000EC1")]
		public CollectionSubMenu CollectionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000EC2")]
		public TextBase Amount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000EC3")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000EC4")]
		public RedDot RedDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000EC5")]
		[SerializeField]
		private RectTransform _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000EC6")]
		[SerializeField]
		private RectTransform _highlightedSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000EC7")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000EC8")]
		private int _switchFontMin = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000EC9")]
		private int _switchFontMax;

		[Cpp2IlInjected.Token(Token = "0x60013B0")]
		[Cpp2IlInjected.Address(RVA = "0x1147450", Offset = "0x1145E50", VA = "0x181147450")]
		private void Start()
		{
			FocusNavigationElement focusNavigationElement = (((TemplateButton)this).FocusNavigationElement = GetComponent<FocusNavigationElement>());
			FocusNavigation focusNavigation = (((TemplateButton)this).FocusNavigation = _focusNavigation);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013B1")]
		[Cpp2IlInjected.Address(RVA = "0x11471A0", Offset = "0x1145BA0", VA = "0x1811471A0", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_007b
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnUpdatedVisuals;
			onSelected.AddListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = OnUpdatedVisuals;
			onDeselected.AddListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = OnUpdatedVisuals;
			onHighlighted.AddListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = OnUpdatedVisuals;
			onDehighlighted.AddListener(call4);
			base.OnEnable();
		}

		[Cpp2IlInjected.Token(Token = "0x60013B2")]
		[Cpp2IlInjected.Address(RVA = "0x1147050", Offset = "0x1145A50", VA = "0x181147050", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_007b
			base.OnDisable();
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnUpdatedVisuals;
			onSelected.RemoveListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = OnUpdatedVisuals;
			onDeselected.RemoveListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = OnUpdatedVisuals;
			onHighlighted.RemoveListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = OnUpdatedVisuals;
			onDehighlighted.RemoveListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x60013B3")]
		[Cpp2IlInjected.Address(RVA = "0x1147440", Offset = "0x1145E40", VA = "0x181147440")]
		public void SetSwitchFont(int min, int max)
		{
			_switchFontMin = min;
			_switchFontMax = max;
		}

		[Cpp2IlInjected.Token(Token = "0x60013B4")]
		[Cpp2IlInjected.Address(RVA = "0x11472F0", Offset = "0x1145CF0", VA = "0x1811472F0")]
		private void OnUpdatedVisuals()
		{
			//Discarded unreachable code: IL_009b
			base.View.Label.SetColorRGB(15264506);
			base.View.DynamicIcon.SetColorRGB(15264506);
			Amount.SetColorRGB(15264506);
			GameObject gameObject = base.View.Background.gameObject;
			int num = 0;
			bool active = default(bool);
			gameObject.SetActive(active);
			GameObject gameObject2 = _highlighted.gameObject;
			bool active2 = ((TemplateButton)this)._isHighlighted;
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _highlightedSelected.gameObject;
			bool active3 = ((TemplateButton)this)._isHighlighted;
			gameObject3.SetActive(active3);
		}

		[Cpp2IlInjected.Token(Token = "0x60013B5")]
		[Cpp2IlInjected.Address(RVA = "0x11474B0", Offset = "0x1145EB0", VA = "0x1811474B0")]
		internal void UpdateDisplay(CollectionModel collectionModel)
		{
			//Discarded unreachable code: IL_0153
			//IL_0076: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField = collectionModel.CollectionGroupModels;
			Func<CollectionItemGroupModel, int> _003C_003E9__14_ = _003C_003Ec._003C_003E9__14_0;
			if (_003C_003E9__14_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionItemGroupModel x) => x.TotalItems);
			}
			int num = Enumerable.Sum<CollectionItemGroupModel>((IEnumerable<>)_003CCollectionGroupModels_003Ek__BackingField, (Func<, >)(object)_003C_003E9__14_);
			List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField2 = collectionModel.CollectionGroupModels;
			Func<CollectionItemGroupModel, int> func = default(Func<CollectionItemGroupModel, int>);
			if (_003C_003Ec._003C_003E9__14_1 == null)
			{
				func = (Func<CollectionItemGroupModel, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CollectionItemGroupModel x)
				{
					//Discarded unreachable code: IL_002e
					List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField = x.CollectionItemModels;
					Func<CollectionItemModel, bool> _003C_003E9__14_2 = _003C_003Ec._003C_003E9__14_2;
					if (_003C_003E9__14_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionItemModel y) => y.IsCollected);
					}
					return Enumerable.Count<CollectionItemModel>((IEnumerable<>)_003CCollectionItemModels_003Ek__BackingField, (Func<, >)(object)_003C_003E9__14_2);
				});
			}
			int num2 = Enumerable.Sum<CollectionItemGroupModel>((IEnumerable<>)_003CCollectionGroupModels_003Ek__BackingField2, (Func<, >)(object)func);
			TextBase amount = Amount;
			string text2 = (amount.Text = $"{num2}/{num2}");
			if (CollectionType <= CollectionSubMenu.Fish)
			{
				bool isInteractable = (base.IsActivated = num2 != 0);
				base.IsInteractable = isInteractable;
				FocusNavigationElement focusNavigationElement = ((TemplateButton)this).FocusNavigationElement;
				int num3 = 0;
				if (!(focusNavigationElement != (UnityEngine.Object)num3))
				{
					FocusNavigationElement focusNavigationElement2 = (((TemplateButton)this).FocusNavigationElement = GetComponent<FocusNavigationElement>());
				}
				bool ignoreThis = default(bool);
				((TemplateButton)this).FocusNavigationElement.IgnoreThis = ignoreThis;
				CanvasGroup canvasGroup = CanvasGroup;
				if (num2 != 0)
				{
				}
				canvasGroup.alpha = 0.3f;
			}
			if (_switchFontMin != -1 && _switchFontMax != -1)
			{
				TextBase label = base.View.Label;
				TextBase.AdjustForHandheldParam adjustForHandheldParam = new TextBase.AdjustForHandheldParam();
				int num4 = (adjustForHandheldParam.min = _switchFontMin);
				int num5 = (adjustForHandheldParam.max = _switchFontMax);
				label.SetAdjustForHandheld(adjustForHandheldParam);
				base.View.Label.AdjustForHandheld();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B6")]
		[Cpp2IlInjected.Address(RVA = "0x11478C0", Offset = "0x11462C0", VA = "0x1811478C0")]
		public CollectionTabButton()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
