using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200044A")]
	public class DreamlightTabButton : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40015C2")]
		public AchievementType AchievementType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40015C3")]
		public RedDot RedDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40015C4")]
		[SerializeField]
		private RectTransform _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40015C5")]
		[SerializeField]
		private RectTransform _highlightedSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40015C6")]
		private int _switchFontMin = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40015C7")]
		private int _switchFontMax;

		[Cpp2IlInjected.Token(Token = "0x6001BD4")]
		[Cpp2IlInjected.Address(RVA = "0xF202B0", Offset = "0xF1ECB0", VA = "0x180F202B0")]
		private void Awake()
		{
			((TemplateButton)this).IgnoreHighlightWhenNotActivated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD5")]
		[Cpp2IlInjected.Address(RVA = "0xF208A0", Offset = "0xF1F2A0", VA = "0x180F208A0")]
		public void SetSwitchFont(int min, int max)
		{
			_switchFontMin = min;
			_switchFontMax = max;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD6")]
		[Cpp2IlInjected.Address(RVA = "0xF207E0", Offset = "0xF1F1E0", VA = "0x180F207E0")]
		public void SetIsSupported(bool isButtonSupported, bool completlyHidden)
		{
			//Discarded unreachable code: IL_0027
			base.IsActivated = isButtonSupported;
			base.IsInteractable = isButtonSupported;
			GetComponent<FocusNavigationElement>().IgnoreThis = isButtonSupported;
			base.gameObject.SetActive(completlyHidden);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD7")]
		[Cpp2IlInjected.Address(RVA = "0xF204A0", Offset = "0xF1EEA0", VA = "0x180F204A0", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_00bf
			base.OnEnable();
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
			UnityEvent onActivated = OnActivated;
			UnityAction call5 = OnUpdatedVisuals;
			onActivated.AddListener(call5);
			UnityEvent onDeactivated = OnDeactivated;
			UnityAction call6 = OnUpdatedVisuals;
			onDeactivated.AddListener(call6);
			OnUpdatedVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD8")]
		[Cpp2IlInjected.Address(RVA = "0xF202C0", Offset = "0xF1ECC0", VA = "0x180F202C0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_00bf
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
			UnityEvent onActivated = OnActivated;
			UnityAction call5 = OnUpdatedVisuals;
			onActivated.RemoveListener(call5);
			UnityEvent onDeactivated = OnDeactivated;
			UnityAction call6 = OnUpdatedVisuals;
			onDeactivated.RemoveListener(call6);
			base.OnDisable();
			OnUpdatedVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD9")]
		[Cpp2IlInjected.Address(RVA = "0xF20680", Offset = "0xF1F080", VA = "0x180F20680")]
		private void OnUpdatedVisuals()
		{
			//Discarded unreachable code: IL_0088
			base.View.Label.SetColorRGBA(994602495);
			base.View.DynamicIcon.SetColorRGBA(994602495);
			GameObject gameObject = base.View.Background.gameObject;
			int num = 0;
			int num2 = 0;
			gameObject.SetActive((byte)num2 != 0);
			GameObject gameObject2 = _highlighted.gameObject;
			bool active = num2 != 0;
			gameObject2.SetActive(active);
			GameObject gameObject3 = _highlightedSelected.gameObject;
			bool active2 = ((TemplateButton)this)._isHighlighted;
			gameObject3.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDA")]
		[Cpp2IlInjected.Address(RVA = "0xF208B0", Offset = "0xF1F2B0", VA = "0x180F208B0")]
		public void UpdateDisplay()
		{
			//Discarded unreachable code: IL_0058
			if (_switchFontMin != -1 && _switchFontMax != -1)
			{
				TextBase label = base.View.Label;
				TextBase.AdjustForHandheldParam adjustForHandheldParam = new TextBase.AdjustForHandheldParam();
				int num = (adjustForHandheldParam.min = _switchFontMin);
				int num2 = (adjustForHandheldParam.max = _switchFontMax);
				label.SetAdjustForHandheld(adjustForHandheldParam);
				base.View.Label.AdjustForHandheld();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDB")]
		[Cpp2IlInjected.Address(RVA = "0xF20990", Offset = "0xF1F390", VA = "0x180F20990")]
		public DreamlightTabButton()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
