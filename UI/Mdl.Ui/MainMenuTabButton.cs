using Cpp2IlInjected;
using Newtonsoft.Json.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000266")]
	public class MainMenuTabButton : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000AC7")]
		public ShortcutDefinition ShortcutDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000AC8")]
		public ImageHelper DynamicIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000AC9")]
		public GameObject QuestIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000ACA")]
		[SerializeField]
		private GameObject Decoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000ACB")]
		[SerializeField]
		protected GameObject SelectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000ACC")]
		[SerializeField]
		protected GameObject HighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000ACD")]
		[SerializeField]
		protected GameObject SelectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000ACE")]
		[SerializeField]
		private ImageHelper _iconImageHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000ACF")]
		[SerializeField]
		private TextBase _labelTextBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000AD0")]
		[SerializeField]
		private string _defaultColor = "#fff4d8";

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000AD1")]
		[SerializeField]
		private string _selectedColor = "#3b486d";

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000AD2")]
		[SerializeField]
		private bool IsAltHighlight;

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xFA6080", Offset = "0xFA4A80", VA = "0x180FA6080", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_0044
			((TemplateButton)this).UseHighlightWhenSelected = true;
			base.OnEnable();
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnSelectedHandler;
			onSelected.AddListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = OnSelectedHandler;
			onDeselected.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xFA5FB0", Offset = "0xFA49B0", VA = "0x180FA5FB0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_003d
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnSelectedHandler;
			onSelected.RemoveListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = OnSelectedHandler;
			onDeselected.RemoveListener(call2);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xFA63F0", Offset = "0xFA4DF0", VA = "0x180FA63F0", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_004a
			//IL_0016: Expected O, but got I4
			base.RefreshDisplay();
			ButtonViewDefault view = base.View;
			int num = 0;
			if (view != (Object)num)
			{
				base.View.DynamicIcon.SetColorRGB(16577222);
				base.View.Label.SetColorRGB(16577222);
			}
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xFA6160", Offset = "0xFA4B60", VA = "0x180FA6160")]
		private void OnSelectedHandler()
		{
			//Discarded unreachable code: IL_0044
			//IL_0010: Expected O, but got I4
			ButtonViewDefault view = base.View;
			int num = 0;
			if (view != (Object)num)
			{
				base.View.DynamicIcon.SetColorRGB(16577222);
				base.View.Label.SetColorRGB(16577222);
			}
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xFA5F90", Offset = "0xFA4990", VA = "0x180FA5F90")]
		public void OnClickedHandler()
		{
			//Discarded unreachable code: IL_0008
			object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xFA66D0", Offset = "0xFA50D0", VA = "0x180FA66D0")]
		public void SetIcon(string path)
		{
			//Discarded unreachable code: IL_0026
			//IL_0010: Expected O, but got I4
			ImageHelper dynamicIcon = DynamicIcon;
			int num = 0;
			if (dynamicIcon != (Object)num)
			{
				ImageHelper dynamicIcon2 = DynamicIcon;
				DynamicIcon.Load();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xFA5E30", Offset = "0xFA4830", VA = "0x180FA5E30")]
		public void MainMenuHighlight()
		{
			//Discarded unreachable code: IL_0053
			//IL_0010: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			GameObject highlightBg = HighlightBg;
			int num = 0;
			if (highlightBg != (Object)num)
			{
				HighlightBg.SetActive(value: true);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num2 = 0;
			if (selectedHighlightBg != (Object)num2)
			{
				GameObject selectedBg = SelectedBg;
				int active = 0;
				selectedBg.SetActive((byte)active != 0);
				SelectedHighlightBg.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4C")]
		[Cpp2IlInjected.Address(RVA = "0xFA5F30", Offset = "0xFA4930", VA = "0x180FA5F30")]
		public void MainMenuRemoveHighlight()
		{
			//Discarded unreachable code: IL_003a
			GameObject highlightBg = HighlightBg;
			int active = 0;
			highlightBg.SetActive((byte)active != 0);
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int active2 = 0;
			selectedHighlightBg.SetActive((byte)active2 != 0);
			GameObject selectedBg = SelectedBg;
			bool isSelected = ((TemplateButton)this)._isSelected;
			selectedBg.SetActive(isSelected);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4D")]
		[Cpp2IlInjected.Address(RVA = "0xFA5B50", Offset = "0xFA4550", VA = "0x180FA5B50", Slot = "20")]
		public virtual void AddHighlight()
		{
			//Discarded unreachable code: IL_0026
			//IL_0010: Expected O, but got I4
			GameObject decoration = Decoration;
			int num = 0;
			if (decoration != (Object)num)
			{
				Decoration.SetActive(value: true);
			}
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4E")]
		[Cpp2IlInjected.Address(RVA = "0xFA64E0", Offset = "0xFA4EE0", VA = "0x180FA64E0", Slot = "21")]
		public virtual void RemoveHighlight()
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			GameObject decoration = Decoration;
			int num = 0;
			if (decoration != (Object)num)
			{
				GameObject decoration2 = Decoration;
				int active = 0;
				decoration2.SetActive((byte)active != 0);
			}
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4F")]
		[Cpp2IlInjected.Address(RVA = "0xFA6570", Offset = "0xFA4F70", VA = "0x180FA6570")]
		private void SetColor()
		{
			//Discarded unreachable code: IL_00ae
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			ImageHelper iconImageHelper = _iconImageHelper;
			int num = 0;
			if (!(iconImageHelper != (Object)num))
			{
				return;
			}
			TextBase labelTextBase = _labelTextBase;
			int num2 = 0;
			if (labelTextBase != (Object)num2)
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || IsAltHighlight)
				{
					ImageHelper iconImageHelper2 = _iconImageHelper;
					string defaultColor = _defaultColor;
					iconImageHelper2.SetColorHTML(defaultColor);
					TextBase labelTextBase2 = _labelTextBase;
					string defaultColor2 = _defaultColor;
					labelTextBase2.SetColorHTML(defaultColor2);
				}
				else
				{
					ImageHelper iconImageHelper3 = _iconImageHelper;
					string selectedColor = _selectedColor;
					iconImageHelper3.SetColorHTML(selectedColor);
					TextBase labelTextBase3 = _labelTextBase;
					string selectedColor2 = _selectedColor;
					labelTextBase3.SetColorHTML(selectedColor2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F50")]
		[Cpp2IlInjected.Address(RVA = "0xFA5D40", Offset = "0xFA4740", VA = "0x180FA5D40")]
		public void InventoryTabHighlight()
		{
			//Discarded unreachable code: IL_0049
			MainMenuHighlight();
			SetColor();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !IsAltHighlight)
			{
				GameObject highlightBg = HighlightBg;
				int active = 0;
				highlightBg.SetActive((byte)active != 0);
				SelectedBg.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F51")]
		[Cpp2IlInjected.Address(RVA = "0xFA5BE0", Offset = "0xFA45E0", VA = "0x180FA5BE0")]
		public void InventoryTabDehighlight()
		{
			//Discarded unreachable code: IL_0036, IL_0079
			SetColor();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !IsAltHighlight)
			{
				GameObject selectedBg = SelectedBg;
				int active = 0;
				selectedBg.SetActive((byte)active != 0);
				return;
			}
			GameObject highlightBg = HighlightBg;
			int active2 = 0;
			highlightBg.SetActive((byte)active2 != 0);
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int active3 = 0;
			selectedHighlightBg.SetActive((byte)active3 != 0);
			GameObject selectedBg2 = SelectedBg;
			bool isSelected = ((TemplateButton)this)._isSelected;
			selectedBg2.SetActive(isSelected);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F52")]
		[Cpp2IlInjected.Address(RVA = "0xFA5DC0", Offset = "0xFA47C0", VA = "0x180FA5DC0")]
		public void InventoryTabSelected()
		{
			//Discarded unreachable code: IL_0037
			MainMenuHighlight();
			SetColor();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !IsAltHighlight)
			{
				SelectedHighlightBg.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F53")]
		[Cpp2IlInjected.Address(RVA = "0xFA5C90", Offset = "0xFA4690", VA = "0x180FA5C90")]
		public void InventoryTabDeselected()
		{
			//Discarded unreachable code: IL_0077
			GameObject highlightBg = HighlightBg;
			int active = 0;
			highlightBg.SetActive((byte)active != 0);
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int active2 = 0;
			selectedHighlightBg.SetActive((byte)active2 != 0);
			GameObject selectedBg = SelectedBg;
			bool isSelected = ((TemplateButton)this)._isSelected;
			selectedBg.SetActive(isSelected);
			SetColor();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !IsAltHighlight)
			{
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				int active3 = 0;
				selectedHighlightBg2.SetActive((byte)active3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F54")]
		[Cpp2IlInjected.Address(RVA = "0xFA6250", Offset = "0xFA4C50", VA = "0x180FA6250")]
		private void RefreshBackground()
		{
			//Discarded unreachable code: IL_00a0
			//IL_0010: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			GameObject selectedBg = SelectedBg;
			int num = 0;
			bool flag = selectedBg != (Object)num;
			int num2 = 0;
			if (flag)
			{
				bool active = default(bool);
				SelectedBg.gameObject.SetActive(active);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num3 = 0;
			if (selectedHighlightBg != (Object)num3)
			{
				GameObject gameObject = SelectedHighlightBg.gameObject;
				bool active2 = ((TemplateButton)this)._isHighlighted;
				gameObject.SetActive(active2);
			}
			GameObject highlightBg = HighlightBg;
			int num4 = 0;
			if (highlightBg != (Object)num4)
			{
				GameObject gameObject2 = HighlightBg.gameObject;
				bool active3 = ((TemplateButton)this)._isHighlighted;
				gameObject2.SetActive(active3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F55")]
		[Cpp2IlInjected.Address(RVA = "0xFA6780", Offset = "0xFA5180", VA = "0x180FA6780")]
		public MainMenuTabButton()
		{
		}
	}
}
