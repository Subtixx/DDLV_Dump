using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class DebugColorPicker : SkinnedWindow
	{
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private static DebugColorPicker m_instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		[SerializeField]
		private Image panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		[SerializeField]
		private ColorWheelControl colorWheel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[SerializeField]
		private DebugColorPickerAlphaSlider alphaSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		[SerializeField]
		private Text rgbaText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		[SerializeField]
		private BoundInputField rInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		[SerializeField]
		private BoundInputField gInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		[SerializeField]
		private BoundInputField bInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		[SerializeField]
		private BoundInputField aInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		[SerializeField]
		private LayoutElement rgbaLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		[SerializeField]
		private LayoutElement buttonsLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		[SerializeField]
		private Button cancelButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		[SerializeField]
		private Button okButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private Canvas referenceCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private Color initialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private ColorWheelControl.OnColorChangedDelegate onColorChanged;

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public static GameObject Prefab
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x112A700", Offset = "0x1129100", VA = "0x18112A700")]
			[CompilerGenerated]
			get
			{
				return _003CPrefab_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x112A740", Offset = "0x1129140", VA = "0x18112A740")]
			[CompilerGenerated]
			set
			{
				_003CPrefab_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public static DebugColorPicker Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x112A560", Offset = "0x1128F60", VA = "0x18112A560")]
			get
			{
				//Discarded unreachable code: IL_004b
				if (!m_instance)
				{
					Prefab = (GameObject)(object)UnityEngine.Object.FindObjectOfType<DebugColorPicker>();
					GameObject gameObject = m_instance.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
					Transform item = m_instance.transform;
					bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Add((T)item);
				}
				return m_instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1129500", Offset = "0x1127F00", VA = "0x181129500", Slot = "4")]
		protected override void Awake()
		{
			//Discarded unreachable code: IL_0073
			base.Awake();
			rInput.Initialize();
			gInput.Initialize();
			bInput.Initialize();
			aInput.Initialize();
			Button.ButtonClickedEvent onClick = cancelButton.m_OnClick;
			UnityAction call = Cancel;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = okButton.m_OnClick;
			UnityAction call2 = Close;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x112A000", Offset = "0x1128A00", VA = "0x18112A000")]
		private void Start()
		{
			//Discarded unreachable code: IL_024f
			//IL_0056: Expected O, but got I4
			DebugColorPickerAlphaSlider debugColorPickerAlphaSlider;
			Delegate @delegate;
			int num;
			do
			{
				ColorWheelControl colorWheelControl = colorWheel;
				ColorWheelControl.OnColorChangedDelegate value = OnSelectedColorChanged;
				colorWheelControl.OnColorChanged += value;
				debugColorPickerAlphaSlider = alphaSlider;
				DebugColorPickerAlphaSlider.OnValueChangedDelegate onValueChanged = debugColorPickerAlphaSlider.OnValueChanged;
				DebugColorPickerAlphaSlider.OnValueChangedDelegate b = OnAlphaChanged;
				@delegate = Delegate.Combine(onValueChanged, b);
				num = 0;
			}
			while ((object)@delegate != null && (object)@delegate == null);
			debugColorPickerAlphaSlider.OnValueChanged = (DebugColorPickerAlphaSlider.OnValueChangedDelegate)num;
			rInput.DefaultEmptyValue = "0";
			gInput.DefaultEmptyValue = "0";
			bInput.DefaultEmptyValue = "0";
			aInput.DefaultEmptyValue = "0";
			BoundInputField boundInputField = rInput;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			BoundInputField boundInputField2 = gInput;
			UISkin uISkin2 = (boundInputField2.Skin = base.m_skin);
			BoundInputField boundInputField3 = bInput;
			UISkin uISkin3 = (boundInputField3.Skin = base.m_skin);
			BoundInputField boundInputField4 = aInput;
			UISkin uISkin4 = (boundInputField4.Skin = base.m_skin);
			BoundInputField boundInputField5 = rInput;
			BoundInputField.OnValueChangedDelegate onValueChanged2 = boundInputField5.OnValueChanged;
			BoundInputField.OnValueChangedDelegate b2 = OnRGBAChanged;
			Delegate delegate2 = Delegate.Combine(onValueChanged2, b2);
			if ((object)delegate2 == null || (object)delegate2 != null)
			{
				boundInputField5.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate2;
				BoundInputField boundInputField6 = gInput;
				BoundInputField.OnValueChangedDelegate b3 = OnRGBAChanged;
				Delegate delegate3 = Delegate.Combine(onValueChanged2, b3);
				if ((object)delegate3 == null || (object)delegate3 != null)
				{
					boundInputField6.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate3;
					BoundInputField boundInputField7 = bInput;
					BoundInputField.OnValueChangedDelegate b4 = OnRGBAChanged;
					Delegate delegate4 = Delegate.Combine(onValueChanged2, b4);
					if ((object)delegate4 == null || (object)delegate4 != null)
					{
						boundInputField7.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate4;
						BoundInputField boundInputField8 = aInput;
						BoundInputField.OnValueChangedDelegate onValueChanged3 = boundInputField8.OnValueChanged;
						BoundInputField.OnValueChangedDelegate b5 = OnRGBAChanged;
						Delegate delegate5 = Delegate.Combine(onValueChanged3, b5);
						if ((object)delegate5 == null || (object)delegate5 != null)
						{
							boundInputField8.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate5;
							Color32 color = colorWheel.m_color;
							string text = default(string);
							rInput.Text = text;
							string text2 = default(string);
							gInput.Text = text2;
							string text3 = default(string);
							bInput.Text = text3;
							string text4 = default(string);
							aInput.Text = text4;
							Image alphaImage = alphaSlider.alphaImage;
							onColorChanged?.Invoke(color);
							return;
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1129E10", Offset = "0x1128810", VA = "0x181129E10")]
		public void Show(ColorWheelControl.OnColorChangedDelegate onColorChanged, Color initialColor, Canvas referenceCanvas)
		{
			//Discarded unreachable code: IL_006b
			//IL_0009: Expected O, but got I4
			int num = 0;
			this.onColorChanged = (ColorWheelControl.OnColorChangedDelegate)num;
			ColorWheelControl colorWheelControl = colorWheel;
			Image alphaImage = alphaSlider.alphaImage;
			DebugColorPickerAlphaSlider debugColorPickerAlphaSlider = alphaSlider;
			RectTransform selector = debugColorPickerAlphaSlider.selector;
			RectTransform selector2 = debugColorPickerAlphaSlider.selector;
			float value = debugColorPickerAlphaSlider.m_value;
			this.onColorChanged = onColorChanged;
			Transform transform = panel.transform;
			int num2 = 0;
			Vector2 zero = Vector2.zero;
			if ((object)transform != null)
			{
				base.gameObject.SetActive(value: true);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1129650", Offset = "0x1128050", VA = "0x181129650")]
		public void Cancel()
		{
			//Discarded unreachable code: IL_0045
			ColorWheelControl colorWheelControl = colorWheel;
			Color color = initialValue;
			if (colorWheelControl.m_color != color && onColorChanged != null)
			{
				Color32 color2 = initialValue;
			}
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x1129710", Offset = "0x1128110", VA = "0x181129710")]
		public void Close()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1129CD0", Offset = "0x11286D0", VA = "0x181129CD0", Slot = "6")]
		protected override void RefreshSkin()
		{
			//Discarded unreachable code: IL_00f6
			UISkin skin = base.m_skin;
			Image image = panel;
			Color color = (image.color = skin.m_windowColor);
			UISkin skin2 = base.m_skin;
			LayoutElement layoutElement = rgbaLayoutElement;
			UISkin skin3 = base.m_skin;
			LayoutElement layoutElement2 = buttonsLayoutElement;
			float b = Mathf.Min(45f, b);
			layoutElement2.SetHeight(b);
			UISkin skin4 = base.m_skin;
			rgbaText.SetSkinText(skin4);
			BoundInputField boundInputField = rInput;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			BoundInputField boundInputField2 = gInput;
			UISkin uISkin2 = (boundInputField2.Skin = base.m_skin);
			BoundInputField boundInputField3 = bInput;
			UISkin uISkin3 = (boundInputField3.Skin = base.m_skin);
			BoundInputField boundInputField4 = aInput;
			UISkin uISkin4 = (boundInputField4.Skin = base.m_skin);
			UISkin skin9 = base.m_skin;
			cancelButton.SetSkinButton(skin9);
			UISkin skin10 = base.m_skin;
			okButton.SetSkinButton(skin10);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1129BA0", Offset = "0x11285A0", VA = "0x181129BA0")]
		private void OnSelectedColorChanged(Color32 color)
		{
			//Discarded unreachable code: IL_0047
			string text = default(string);
			rInput.Text = text;
			string text2 = default(string);
			gInput.Text = text2;
			string text3 = default(string);
			bInput.Text = text3;
			string text4 = default(string);
			aInput.Text = text4;
			Image alphaImage = alphaSlider.alphaImage;
			if (onColorChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x11298C0", Offset = "0x11282C0", VA = "0x1811298C0")]
		private void OnAlphaChanged(float alpha)
		{
			//Discarded unreachable code: IL_0035
			string text = default(string);
			aInput.Text = text;
			colorWheel.Alpha = alpha;
			Color color = colorWheel.m_color;
			if (onColorChanged != null)
			{
				Color32 color2 = color;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1129980", Offset = "0x1128380", VA = "0x181129980")]
		private bool OnRGBAChanged(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0072
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			Color32 color = colorWheel.m_color;
			BoundInputField boundInputField = rInput;
			if (!(source == boundInputField))
			{
				BoundInputField boundInputField2 = gInput;
				if (!(source == boundInputField2))
				{
					BoundInputField boundInputField3 = bInput;
					if (!(source == boundInputField3))
					{
						float value = default(float);
						alphaSlider.Value = value;
					}
				}
			}
			Image alphaImage = alphaSlider.alphaImage;
			ColorWheelControl colorWheelControl = colorWheel;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1129760", Offset = "0x1128160", VA = "0x181129760")]
		public static void DestroyInstance()
		{
			//Discarded unreachable code: IL_0031
			if ((bool)m_instance)
			{
				HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
				Transform item = m_instance.transform;
				bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Remove((T)item);
				UnityEngine.Object.Destroy(m_instance);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public DebugColorPicker()
		{
		}
	}
}
