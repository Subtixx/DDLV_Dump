using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public class PageIndicator : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		public class PageIndicatorColorScheme
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public Color SelectedBgColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public Color LockedBgColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public Color UnlockedBgColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public Color LockedLabelColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public Color UnlockedLabelColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public Color SelectedLockedLabelColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			public Color SelectedUnlockedLabelColor;

			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PageIndicatorColorScheme()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000197")]
		public delegate void Selected(PageIndicator tab);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		[SerializeField]
		protected SpriteAtlasImage _lockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		[SerializeField]
		protected BaseButton _btn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		[SerializeField]
		protected SpriteAtlasImage _bgEndNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		[SerializeField]
		protected SpriteAtlasImage _bgMidNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		[SerializeField]
		protected SpriteAtlasImage _bgEndHighlightSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		[SerializeField]
		protected SpriteAtlasImage _bgMidHighlightSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		[SerializeField]
		protected SpriteAtlasImage _bgEndHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		[SerializeField]
		protected SpriteAtlasImage _bgMidHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		[SerializeField]
		protected RectTransform _bgEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		[SerializeField]
		protected RectTransform _bgMid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		[SerializeField]
		protected TextBase _pageNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		[SerializeField]
		protected RectTransform _labelContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		[SerializeField]
		protected HorizontalLayoutGroup _container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		protected PageIndicatorColorScheme _colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		protected PageIndicatorColorScheme _defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		protected int _index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		protected int _totalCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		protected string _pageLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		protected bool _isLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		protected bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		protected bool _isHighlighted;

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return _index;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60009F0")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
			get
			{
				return _isLocked;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0x12A6AD0", Offset = "0x12A54D0", VA = "0x1812A6AD0")]
			set
			{
				_isLocked = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0x7DAE20", Offset = "0x7D9820", VA = "0x1807DAE20")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0x12A6AF0", Offset = "0x12A54F0", VA = "0x1812A6AF0")]
			set
			{
				_isSelected = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public bool IsHighlighted
		{
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0x12A6A00", Offset = "0x12A5400", VA = "0x1812A6A00")]
			get
			{
				return _isHighlighted;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F5")]
			[Cpp2IlInjected.Address(RVA = "0x12A6AB0", Offset = "0x12A54B0", VA = "0x1812A6AB0")]
			set
			{
				_isHighlighted = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x12A6960", Offset = "0x12A5360", VA = "0x1812A6960")]
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
			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x12A6A10", Offset = "0x12A5410", VA = "0x1812A6A10")]
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

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x12A68B0", Offset = "0x12A52B0", VA = "0x1812A68B0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0038
			InitDefaultColor();
			BaseButton btn = _btn;
			if ((object)btn != null)
			{
				Button buttonComponent = btn.ButtonComponent;
				if ((object)buttonComponent != null)
				{
					Button.ButtonClickedEvent onClick = buttonComponent.m_OnClick;
					UnityAction call = OnClicked;
					onClick.AddListener(call);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x12A5F50", Offset = "0x12A4950", VA = "0x1812A5F50")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0032
			BaseButton btn = _btn;
			if ((object)btn != null)
			{
				Button buttonComponent = btn.ButtonComponent;
				if ((object)buttonComponent != null)
				{
					Button.ButtonClickedEvent onClick = buttonComponent.m_OnClick;
					UnityAction call = OnClicked;
					onClick.RemoveListener(call);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x12A5C60", Offset = "0x12A4660", VA = "0x1812A5C60")]
		private void InitDefaultColor()
		{
			//Discarded unreachable code: IL_0075
			PageIndicatorColorScheme defaultColor = new PageIndicatorColorScheme();
			int num = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			int num2 = 0;
			UIGameColors gameColors2 = UiRoot.Instance._gameColors;
			int num3 = 0;
			UIGameColors gameColors3 = UiRoot.Instance._gameColors;
			int num4 = 0;
			UIGameColors gameColors4 = UiRoot.Instance._gameColors;
			int num5 = 0;
			UIGameColors gameColors5 = UiRoot.Instance._gameColors;
			int num6 = 0;
			UIGameColors gameColors6 = UiRoot.Instance._gameColors;
			int num7 = 0;
			UIGameColors gameColors7 = UiRoot.Instance._gameColors;
			_defaultColor = defaultColor;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x12A5EF0", Offset = "0x12A48F0", VA = "0x1812A5EF0")]
		private void OnClicked()
		{
			if (!_isSelected)
			{
				_btn?.PostWwiseEvent();
				_isSelected = true;
				RefreshDisplay();
				this.OnSelected?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x12A6000", Offset = "0x12A4A00", VA = "0x1812A6000")]
		public void OnHighlightAdded()
		{
			_isHighlighted = true;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x12A6020", Offset = "0x12A4A20", VA = "0x1812A6020")]
		public void OnHighlightRemoved()
		{
			_isHighlighted = false;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x12A6040", Offset = "0x12A4A40", VA = "0x1812A6040", Slot = "4")]
		public virtual void RefreshDisplay()
		{
			//Discarded unreachable code: IL_031d
			//IL_005c: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			if (_colors == null)
			{
			}
			GameObject gameObject = _lockedIcon.gameObject;
			bool isLocked = _isLocked;
			gameObject.SetActive(isLocked);
			Image image = _bgEndNormal.Image;
			SpriteAtlasImage bgMidNormal = _bgMidNormal;
			int num = 0;
			Image image2 = bgMidNormal.Image;
			if (_isSelected)
			{
			}
			if (_isLocked)
			{
			}
			image2.color = (Color)num;
			image.color = (Color)num;
			int index = _index;
			int totalCount = _totalCount;
			bool active = index < totalCount;
			_bgEnd.gameObject.SetActive(active);
			_bgMid.gameObject.SetActive(active);
			int totalCount2 = _totalCount;
			if (_index == totalCount2)
			{
				RectTransform bgEnd = _bgEnd;
				RectTransform bgMid = _bgMid;
				Quaternion localRotation = bgEnd.localRotation;
			}
			CanvasGroup component = _labelContainer.GetComponent<CanvasGroup>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				CanvasGroup component2 = _labelContainer.GetComponent<CanvasGroup>();
				if (!_isLocked || _isSelected || !_isHighlighted)
				{
				}
				component2.alpha = 1f;
			}
			string pageLabel = _pageLabel;
			TextBase pageNumber = _pageNumber;
			if (string.IsNullOrEmpty(pageLabel))
			{
				int index2 = _index;
				index2++;
			}
			string text = (pageNumber.StringID = _pageLabel);
			SpriteAtlasImage lockedIcon = _lockedIcon;
			if (!_isHighlighted)
			{
				if (!_isSelected)
				{
					Image image3 = lockedIcon.Image;
					TextBase pageNumber2 = _pageNumber;
					int num3 = 0;
					TextMeshProUGUI textComponent = pageNumber2.TextComponent;
					if (_isLocked)
					{
					}
					textComponent.color = (Color)num3;
				}
				TextMeshProUGUI textComponent2 = _pageNumber.TextComponent;
				if (!_isLocked)
				{
				}
			}
			TextMeshProUGUI textComponent3 = _pageNumber.TextComponent;
			int num4 = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			GameObject gameObject2 = _bgEndHighlight.gameObject;
			int num5 = 0;
			bool active2 = default(bool);
			if ((_isHighlighted ? 1 : 0) != num5)
			{
				active2 = (_isSelected ? 1 : 0) == num5;
			}
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _bgMidHighlight.gameObject;
			int num6 = 0;
			bool active3 = default(bool);
			if ((_isHighlighted ? 1 : 0) != num6)
			{
				active3 = (_isSelected ? 1 : 0) == num6;
			}
			gameObject3.SetActive(active3);
			GameObject gameObject4 = _bgEndHighlightSelected.gameObject;
			if (!_isHighlighted)
			{
			}
			bool active4 = _isSelected;
			gameObject4.SetActive(active4);
			GameObject gameObject5 = _bgMidHighlightSelected.gameObject;
			if (!_isHighlighted)
			{
			}
			bool active5 = _isSelected;
			gameObject5.SetActive(active5);
			GameObject gameObject6 = _bgEndNormal.gameObject;
			bool active6 = !_isHighlighted;
			gameObject6.SetActive(active6);
			GameObject gameObject7 = _bgMidNormal.gameObject;
			bool active7 = !_isHighlighted;
			gameObject7.SetActive(active7);
			Image image4 = _bgEndNormal.Image;
			Image image5 = _bgMidNormal.Image;
			Image image6 = _bgEndNormal.Image;
			Image image7 = _bgEndNormal.Image;
			Image image8 = _bgEndNormal.Image;
			if (!_isSelected && !_isLocked)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x12A5E60", Offset = "0x12A4860", VA = "0x1812A5E60")]
		public void Init(bool isLocked, int index, int total, [Optional] PageIndicatorColorScheme colors, [Optional] string pageLabel)
		{
			//IL_000d: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			InitDefaultColor();
			_colors = (PageIndicatorColorScheme)0;
			_isLocked = isLocked;
			_index = index;
			_totalCount = total;
			_pageLabel = (string)0;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PageIndicator()
		{
		}
	}
}
