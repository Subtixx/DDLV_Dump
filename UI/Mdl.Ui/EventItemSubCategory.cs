using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000489")]
	public class EventItemSubCategory : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200048A")]
		public enum SubCategoryType
		{
			[Cpp2IlInjected.Token(Token = "0x4001744")]
			Description,
			[Cpp2IlInjected.Token(Token = "0x4001745")]
			Duties,
			[Cpp2IlInjected.Token(Token = "0x4001746")]
			Reward
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001736")]
		[SerializeField]
		private SubCategoryType _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001737")]
		[SerializeField]
		private BaseButton _btnToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001738")]
		[SerializeField]
		internal TextBase title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001739")]
		[SerializeField]
		private AsyncImage _backgroundSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400173A")]
		[SerializeField]
		private Image _backgroundSelectedHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400173B")]
		[SerializeField]
		private Image _backgroundHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400173C")]
		private int _highlightedTextColor = 3885165;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400173D")]
		private int _unhighlightedTextColor = 15264506;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400173E")]
		public Action OnClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400173F")]
		public UnityEvent OnGamepadClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001740")]
		public UnityEvent OnSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001741")]
		private bool _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4001742")]
		private bool _selected;

		[Cpp2IlInjected.Token(Token = "0x170004D7")]
		public SubCategoryType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6001D6E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _type;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D8")]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x6001D6F")]
			[Cpp2IlInjected.Address(RVA = "0x13FB680", Offset = "0x13FA080", VA = "0x1813FB680")]
			get
			{
				return _selected;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D70")]
			[Cpp2IlInjected.Address(RVA = "0x13FB690", Offset = "0x13FA090", VA = "0x1813FB690")]
			set
			{
				_selected = value;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D71")]
		[Cpp2IlInjected.Address(RVA = "0x13FB5B0", Offset = "0x13F9FB0", VA = "0x1813FB5B0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnClick;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D72")]
		[Cpp2IlInjected.Address(RVA = "0x13FB350", Offset = "0x13F9D50", VA = "0x1813FB350")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnClick;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D73")]
		[Cpp2IlInjected.Address(RVA = "0x13FB560", Offset = "0x13F9F60", VA = "0x1813FB560")]
		public void SetBGSelected(AssetReferenceTexture assetRef)
		{
			//Discarded unreachable code: IL_0016
			AsyncImage backgroundSelected = _backgroundSelected;
			string assetGUID = assetRef.AssetGUID;
			backgroundSelected.SetSpriteKey(assetGUID);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D74")]
		[Cpp2IlInjected.Address(RVA = "0x13FB2D0", Offset = "0x13F9CD0", VA = "0x1813FB2D0")]
		private void OnClick()
		{
			//Discarded unreachable code: IL_0050, IL_0066
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				OnClicked?.Invoke();
				if (!_selected)
				{
					UnityEvent onSelect = OnSelect;
					_selected = true;
					onSelect?.Invoke();
				}
				RefreshDisplay();
			}
			else
			{
				UnityEvent onGamepadClicked = OnGamepadClicked;
				while (onGamepadClicked == null)
				{
				}
				onGamepadClicked.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D75")]
		[Cpp2IlInjected.Address(RVA = "0x13FB280", Offset = "0x13F9C80", VA = "0x1813FB280")]
		private void ClickAction()
		{
			OnClicked?.Invoke();
			if (!_selected)
			{
				UnityEvent onSelect = OnSelect;
				_selected = true;
				onSelect?.Invoke();
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D76")]
		[Cpp2IlInjected.Address(RVA = "0x13FB400", Offset = "0x13F9E00", VA = "0x1813FB400")]
		public void OnHighlightAdded()
		{
			//Discarded unreachable code: IL_005d
			_highlighted = true;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				OnClicked?.Invoke();
				if (!_selected)
				{
					UnityEvent onSelect = OnSelect;
					_selected = true;
					onSelect?.Invoke();
				}
				RefreshDisplay();
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D77")]
		[Cpp2IlInjected.Address(RVA = "0x13FB480", Offset = "0x13F9E80", VA = "0x1813FB480")]
		public void OnHighlightRemoved()
		{
			_highlighted = false;
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D78")]
		[Cpp2IlInjected.Address(RVA = "0x13FB490", Offset = "0x13F9E90", VA = "0x1813FB490")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0094
			GameObject gameObject2;
			do
			{
				GameObject gameObject = _backgroundHighlight.gameObject;
				int num = 0;
				if ((_highlighted ? 1 : 0) == num)
				{
				}
				bool active = (_selected ? 1 : 0) == num;
				gameObject.SetActive(active);
				gameObject2 = _backgroundSelectedHighlight.gameObject;
			}
			while (!_highlighted);
			bool active2 = _selected;
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _backgroundSelected.gameObject;
			bool selected = _selected;
			gameObject3.SetActive(selected);
			TextBase textBase = title;
			if (_highlighted)
			{
			}
			int unhighlightedTextColor = _unhighlightedTextColor;
			textBase.SetColorRGB(unhighlightedTextColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D79")]
		[Cpp2IlInjected.Address(RVA = "0x13FB660", Offset = "0x13FA060", VA = "0x1813FB660")]
		public EventItemSubCategory()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8

	}
}
