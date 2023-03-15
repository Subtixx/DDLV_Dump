using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000360")]
	public class NavigationBarButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400104D")]
		[SerializeField]
		public RectTransform RectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400104E")]
		[SerializeField]
		private BaseButton _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400104F")]
		[SerializeField]
		private TextBase _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001050")]
		[SerializeField]
		private Color _regularColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001051")]
		[SerializeField]
		private Color _selectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001052")]
		[SerializeField]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001053")]
		[SerializeField]
		private GameObject _selectedBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001054")]
		[SerializeField]
		private GameObject _selectedBGHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001055")]
		public UnityEvent OnSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001056")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4001057")]
		private bool _isHighlighted;

		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600158E")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x600158F")]
			[Cpp2IlInjected.Address(RVA = "0x12990B0", Offset = "0x1297AB0", VA = "0x1812990B0")]
			set
			{
				_isSelected = value;
				RefreshVisuals();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		public bool IsHighlighted
		{
			[Cpp2IlInjected.Token(Token = "0x6001590")]
			[Cpp2IlInjected.Address(RVA = "0x976360", Offset = "0x974D60", VA = "0x180976360")]
			get
			{
				return _isHighlighted;
			}
			[Cpp2IlInjected.Token(Token = "0x6001591")]
			[Cpp2IlInjected.Address(RVA = "0x12990A0", Offset = "0x1297AA0", VA = "0x1812990A0")]
			set
			{
				_isHighlighted = value;
				RefreshVisuals();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001592")]
		[Cpp2IlInjected.Address(RVA = "0x1298E00", Offset = "0x1297800", VA = "0x181298E00")]
		public void Init(string label)
		{
			//Discarded unreachable code: IL_000d
			_text.StringID = label;
		}

		[Cpp2IlInjected.Token(Token = "0x6001593")]
		[Cpp2IlInjected.Address(RVA = "0x1298EF0", Offset = "0x12978F0", VA = "0x181298EF0")]
		protected void OnEnable()
		{
			//Discarded unreachable code: IL_002c
			Button.ButtonClickedEvent onClick = _button.ButtonComponent.m_OnClick;
			UnityAction call = OnButtonSelect;
			onClick.AddListener(call);
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6001594")]
		[Cpp2IlInjected.Address(RVA = "0x1298E40", Offset = "0x1297840", VA = "0x181298E40")]
		protected void OnDisable()
		{
			//Discarded unreachable code: IL_002c
			Button.ButtonClickedEvent onClick = _button.ButtonComponent.m_OnClick;
			UnityAction call = OnButtonSelect;
			onClick.RemoveListener(call);
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6001595")]
		[Cpp2IlInjected.Address(RVA = "0x1298E20", Offset = "0x1297820", VA = "0x181298E20")]
		private void OnButtonSelect()
		{
			if (!_isSelected)
			{
				OnSelected?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001596")]
		[Cpp2IlInjected.Address(RVA = "0x1298DD0", Offset = "0x12977D0", VA = "0x181298DD0")]
		public void AddHighlight()
		{
			_isHighlighted = true;
			RefreshVisuals();
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6001597")]
		[Cpp2IlInjected.Address(RVA = "0x1299070", Offset = "0x1297A70", VA = "0x181299070")]
		public void RemoveHighlight()
		{
			_isHighlighted = false;
			RefreshVisuals();
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6001598")]
		[Cpp2IlInjected.Address(RVA = "0x1298FA0", Offset = "0x12979A0", VA = "0x181298FA0")]
		private void RefreshVisuals()
		{
			//Discarded unreachable code: IL_0099
			GameObject selectedBGHighlight;
			while (true)
			{
				GameObject highlight = _highlight;
				int num = 0;
				if ((_isHighlighted ? 1 : 0) == num)
				{
				}
				bool active = (_isSelected ? 1 : 0) == num;
				highlight.SetActive(active);
				GameObject selectedBG = _selectedBG;
				if (!_isHighlighted)
				{
					bool active2 = _isSelected;
					selectedBG.SetActive(active2);
					selectedBGHighlight = _selectedBGHighlight;
					if (_isHighlighted)
					{
						break;
					}
				}
			}
			bool active3 = _isSelected;
			selectedBGHighlight.SetActive(active3);
			TextMeshProUGUI textComponent = _text.TextComponent;
			if (_isSelected)
			{
			}
			Color color = (textComponent.color = _regularColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6001599")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public NavigationBarButton()
		{
		}
	}
}
