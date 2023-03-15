using System;
using System.Collections.Generic;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Mdl.Platform;
using Mdl.Utils;
using StoreFrontEnums;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class TextBase : MonoBehaviour, IResolver
	{
		[Cpp2IlInjected.Token(Token = "0x20001FA")]
		public enum CustomXmlOption
		{
			[Cpp2IlInjected.Token(Token = "0x40008BA")]
			NoParse,
			[Cpp2IlInjected.Token(Token = "0x40008BB")]
			ParseOn,
			[Cpp2IlInjected.Token(Token = "0x40008BC")]
			ParseOff
		}

		[Cpp2IlInjected.Token(Token = "0x20001FB")]
		private enum ControlType
		{
			[Cpp2IlInjected.Token(Token = "0x40008BE")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40008BF")]
			Keyboard,
			[Cpp2IlInjected.Token(Token = "0x40008C0")]
			Gamepad
		}

		[Cpp2IlInjected.Token(Token = "0x20001FC")]
		public class AdjustForHandheldParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40008C1")]
			public int min = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40008C2")]
			public int max;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40008C3")]
			public int staticSize = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40008C4")]
			public bool autoExpand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40008C5")]
			public float increaseX = -1f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40008C6")]
			public float increaseY = -1f;

			[Cpp2IlInjected.Token(Token = "0x6000CC5")]
			[Cpp2IlInjected.Address(RVA = "0x134FDE0", Offset = "0x134E7E0", VA = "0x18134FDE0")]
			public AdjustForHandheldParam()
			{
			}//IL_0009: Expected I4, but got I8
			//IL_0019: Expected I4, but got I8

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008A0")]
		[SerializeField]
		private TextMeshProUGUI _tmp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008A1")]
		[SerializeField]
		[StringId(true)]
		private string _stringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40008A2")]
		[SerializeField]
		private string _text = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40008A3")]
		[SerializeField]
		private List<TextBaseAlternative> _alternatives;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40008A4")]
		[SerializeField]
		private UIGameColors.GameColorName _colorKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40008A5")]
		[SerializeField]
		private CustomXmlOption _parseCustomXml;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40008A6")]
		[SerializeField]
		private bool _parseIconTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40008A7")]
		public UIGameColors.GameColorName ColorToApply;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40008A8")]
		[SerializeField]
		private bool _adjustRectWidthToText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40008A9")]
		[SerializeField]
		private bool _adjustRectHeightToText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40008AA")]
		public RectTransform RectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40008AB")]
		public UnityEvent OnRefreshed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40008AC")]
		[SerializeField]
		private Material _materialToApply;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40008AD")]
		[SerializeField]
		private ControlType _controlToKeep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40008AE")]
		[SerializeField]
		[FormerlySerializedAs("_switchTextOverride")]
		[Header("To Enable Override Settings For Handheld")]
		private bool _handheldTextOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40008AF")]
		[SerializeField]
		[Header("Change those only if needed, else leave it at -1 to be ignored")]
		[Header("If Min and Max are setup, it will force to enable the auto-size on TMP_Text")]
		private int _minFontSize = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40008B0")]
		[SerializeField]
		private int _maxFontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40008B1")]
		[SerializeField]
		private int _staticFontSize = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40008B2")]
		[SerializeField]
		private float _increaseXBy = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40008B3")]
		[SerializeField]
		private float _increaseYBy = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40008B4")]
		[SerializeField]
		[Header("To adjust parent with size of this")]
		private bool _autoExpand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40008B5")]
		[SerializeField]
		private float _padding = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40008B6")]
		[SerializeField]
		private SetSizeBasedOnChild.SizeAdjustment _sizeAdjustment = SetSizeBasedOnChild.SizeAdjustment.None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40008B7")]
		[SerializeField]
		[Header("Set one or both of these value if you want to keep a min size with AutoExpand")]
		private float _minX = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40008B8")]
		[SerializeField]
		private float _minY = -1f;

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		public TextMeshProUGUI TextComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAB")]
			[Cpp2IlInjected.Address(RVA = "0x17EB910", Offset = "0x17EA310", VA = "0x1817EB910")]
			get
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				return _tmp = GetComponent<TextMeshProUGUI>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public string StringID
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _stringID;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x17EBA20", Offset = "0x17EA420", VA = "0x1817EBA20")]
			set
			{
				if (!string.Equals(_stringID, value))
				{
					_stringID = value;
					RefreshText();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _text;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x17EBA70", Offset = "0x17EA470", VA = "0x1817EBA70")]
			set
			{
				if (!string.Equals(_text, value))
				{
					_stringID = "";
					_text = value;
					RefreshText();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public UIGameColors.GameColorName ColorKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB0")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return _colorKey;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB1")]
			[Cpp2IlInjected.Address(RVA = "0x17EBA00", Offset = "0x17EA400", VA = "0x1817EBA00")]
			set
			{
				if (_colorKey != value)
				{
					_colorKey = value;
					ColorToApply = value;
					RefreshColor();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public CustomXmlOption ParseCustomXml
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB2")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return _parseCustomXml;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB3")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			internal set
			{
				_parseCustomXml = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		public bool ParseIconTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB4")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return _parseIconTags;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		private bool _canApplyTextSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0x17EB9D0", Offset = "0x17EA3D0", VA = "0x1817EB9D0")]
			get
			{
				//Discarded unreachable code: IL_0004
				int num = 0;
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB6")]
		[Cpp2IlInjected.Address(RVA = "0x17EAD40", Offset = "0x17E9740", VA = "0x1817EAD40")]
		private void OnEnable()
		{
			if (_handheldTextOverride)
			{
				AdjustForHandheld();
			}
			RefreshText();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB7")]
		[Cpp2IlInjected.Address(RVA = "0x17EB870", Offset = "0x17EA270", VA = "0x1817EB870")]
		private void Start()
		{
			RefreshText();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x17EAF80", Offset = "0x17E9980", VA = "0x1817EAF80")]
		public void RefreshText()
		{
			//Discarded unreachable code: IL_01ba, IL_01c0, IL_01c6
			//IL_005a: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			string stringID = _stringID;
			string text = _text;
			List<TextBaseAlternative> alternatives = _alternatives;
			int num3 = 0;
			int num4 = 0;
			PlayfabOriginId runtimePlayfabOriginId = PlatformUtils.GetRuntimePlayfabOriginId();
			List<TextBaseAlternative> alternatives2 = _alternatives;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
			bool flag4 = string.IsNullOrEmpty(stringID);
			Material materialToApply = _materialToApply;
			int num5 = 0;
			if (materialToApply != (UnityEngine.Object)num5)
			{
				TextMeshProUGUI textComponent = TextComponent;
				Material material = (textComponent.fontSharedMaterial = _materialToApply);
			}
			string text2 = default(string);
			if (!flag4)
			{
				int num6 = 0;
				text2 = LocalizationManager.FromStringID(stringID, (IResolver)num6);
			}
			string text3 = default(string);
			if (text2 != null)
			{
				text3 = text2.Replace("&nbsp;", "<NBSP>");
			}
			TextMeshProUGUI textComponent2 = TextComponent;
			string str = default(string);
			if (text3 != null && text3.Contains("ß"))
			{
				str = text3.Replace("ß", "ẞ");
			}
			string text4 = default(string);
			if (_parseCustomXml != 0)
			{
				int num7 = 0;
				CustomXmlSettings instance = CustomXmlSettings.Instance;
				bool useXml = _parseCustomXml == CustomXmlOption.ParseOn;
				text4 = instance.Parse(str, useXml);
			}
			TextMeshProUGUI textComponent3 = TextComponent;
			string text5 = default(string);
			if (_parseIconTags)
			{
				text5 = LocalizationManager.FormatText(text4, this);
			}
			textComponent3.text = text5;
			RefreshColor();
			if (_adjustRectWidthToText)
			{
				RectTransform rectTransform = TextComponent.rectTransform;
				float preferredWidth = TextComponent.preferredWidth;
				int axis = 0;
				rectTransform.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, preferredWidth);
				LayoutRebuilder.MarkLayoutForRebuild(TextComponent.rectTransform);
			}
			if (_adjustRectHeightToText)
			{
				RectTransform rectTransform2 = TextComponent.rectTransform;
				float preferredWidth = TextComponent.preferredHeight;
				rectTransform2.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, preferredWidth);
				LayoutRebuilder.MarkLayoutForRebuild(TextComponent.rectTransform);
			}
			OnRefreshed?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0x17EAE60", Offset = "0x17E9860", VA = "0x1817EAE60")]
		public void RefreshColor()
		{
			//Discarded unreachable code: IL_004a
			//IL_0019: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			if (ColorToApply == UIGameColors.GameColorName.NONE)
			{
				return;
			}
			TextMeshProUGUI textComponent = TextComponent;
			int num = 0;
			if (textComponent != (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int num3 = 0;
				if (instance != (UnityEngine.Object)num3)
				{
					TextMeshProUGUI textComponent2 = TextComponent;
					int num4 = 0;
					UIGameColors gameColors = UiRoot.Instance._gameColors;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0x17EAD70", Offset = "0x17E9770", VA = "0x1817EAD70")]
		public string ParseImageGlyph(string text)
		{
			return LocalizationManager.FormatText(text, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0x17EB650", Offset = "0x17EA050", VA = "0x1817EB650")]
		public void SetColorRGB(int rgb)
		{
			//Discarded unreachable code: IL_000a
			TextMeshProUGUI textComponent = TextComponent;
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBC")]
		[Cpp2IlInjected.Address(RVA = "0x17EB5C0", Offset = "0x17E9FC0", VA = "0x1817EB5C0")]
		public void SetColorRGBA(int rgba)
		{
			//Discarded unreachable code: IL_000a
			TextMeshProUGUI textComponent = TextComponent;
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBD")]
		[Cpp2IlInjected.Address(RVA = "0x17EB540", Offset = "0x17E9F40", VA = "0x1817EB540")]
		public void SetColorHTML(string htmlColor)
		{
			//Discarded unreachable code: IL_0008
			TextMeshProUGUI textComponent = TextComponent;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0x17EB6E0", Offset = "0x17EA0E0", VA = "0x1817EB6E0")]
		public unsafe void SetColor(GameObject colorProvider)
		{
			//Discarded unreachable code: IL_002e
			//IL_000b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (colorProvider == (UnityEngine.Object)num2)
			{
				return;
			}
			bool flag = colorProvider.TryGetComponent<IHasUIntValue>(out *(IHasUIntValue*)num);
			if (flag)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				SetColorRGB(flag ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0x17EB820", Offset = "0x17EA220", VA = "0x1817EB820")]
		public void SetColor(Color color)
		{
			//Discarded unreachable code: IL_0008
			TextMeshProUGUI textComponent = TextComponent;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0x17EAD90", Offset = "0x17E9790", VA = "0x1817EAD90")]
		public static void RefreshAllLocalizedText()
		{
			//Discarded unreachable code: IL_0035
			TextBase[] array = UnityEngine.Object.FindObjectsOfType<TextBase>(includeInactive: true);
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				TextBase textBase = array[num];
				if (!string.IsNullOrEmpty(textBase._stringID))
				{
					textBase.RefreshText();
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0x17E9EF0", Offset = "0x17E88F0", VA = "0x1817E9EF0", Slot = "4")]
		object IResolver.Resolve(string key)
		{
			//IL_004e: Expected I4, but got I8
			//IL_0067: Expected I4, but got I8
			//IL_00d2: Expected I4, but got I8
			//IL_00f6: Expected O, but got I4
			//IL_03b3: Expected O, but got I4
			ulong num = default(ulong);
			InputDetectionHelper.InputController controller = default(InputDetectionHelper.InputController);
			ulong num3 = default(ulong);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			bool flag12 = default(bool);
			bool flag13 = default(bool);
			bool flag14 = default(bool);
			bool flag15 = default(bool);
			bool flag16 = default(bool);
			ulong num11 = default(ulong);
			uint num12 = default(uint);
			InputDetectionHelper.InputController inputController = default(InputDetectionHelper.InputController);
			bool flag17 = default(bool);
			bool flag18 = default(bool);
			bool flag21 = default(bool);
			bool flag22 = default(bool);
			bool flag23 = default(bool);
			bool flag24 = default(bool);
			bool flag25 = default(bool);
			while (key != null)
			{
				int index = 0;
				char c = key[index];
				int index2 = 0;
				char c2 = key[index2];
				string text = key.ToLower();
				if (!text.StartsWith("input_"))
				{
					break;
				}
				ControlType controlToKeep = _controlToKeep;
				if (controlToKeep == ControlType.Keyboard)
				{
				}
				if (controlToKeep == ControlType.Gamepad)
				{
					if (InputDetectionHelper.GetController((byte)num != 0) != InputDetectionHelper.InputController.Keyboard)
					{
						goto IL_0069;
					}
					int num2 = 0;
					bool flag = UiRoot.Instance.IsPs5Controller();
				}
				controller = InputDetectionHelper.GetController((byte)num3 != 0);
				goto IL_0069;
				IL_04c0:
				string[] array;
				if ((flag2 ? 1 : 0) > (true ? 1 : 0))
				{
					if (flag2)
					{
						flag3 = string.Equals((string)(object)array, "input_movement");
						if (!flag3)
						{
							goto IL_0526;
						}
					}
					if (flag3)
					{
						flag4 = string.Equals((string)(object)array, "input_inventory");
						if (!flag4)
						{
							goto IL_0526;
						}
					}
					if (!flag4)
					{
						goto IL_0526;
					}
				}
				if (flag4)
				{
					flag5 = string.Equals((string)(object)array, "input_back");
					if (flag5)
					{
						goto IL_0526;
					}
				}
				if (flag5 && !string.Equals((string)(object)array, "input_mainmenu"))
				{
				}
				goto IL_0526;
				IL_0487:
				if (flag6)
				{
					flag7 = string.Equals((string)(object)array, "input_shortcutcamera");
					if (!flag7)
					{
						goto IL_0526;
					}
				}
				if (flag7)
				{
					flag2 = string.Equals((string)(object)array, "input_shortcutshovel");
					if (flag2)
					{
						goto IL_04c0;
					}
				}
				goto IL_0526;
				IL_0526:
				string text2 = "<sprite name=" + "IconGlyphSheet_Esc" + ">";
				break;
				IL_046c:
				if (flag8)
				{
					flag6 = string.Equals((string)(object)array, "input_fasttravel");
					if (!flag6)
					{
						goto IL_0526;
					}
				}
				goto IL_0487;
				IL_034c:
				if ((flag9 ? 1 : 0) <= (true ? 1 : 0))
				{
					continue;
				}
				if (flag9)
				{
					flag10 = string.Equals((string)(object)array, "input_shortcutpickaxe");
					if (!flag10)
					{
						goto IL_0526;
					}
				}
				if (flag10)
				{
					flag11 = string.Equals((string)(object)array, "input_interact");
					if (!flag11)
					{
						goto IL_0526;
					}
				}
				if (flag11 && string.Equals((string)(object)array, "input_fishingaction"))
				{
					int num4 = 0;
					if ((long)LocalizationManager.FromStringID("menu.press_left_click", (IResolver)num4) == 2289383866L)
					{
						flag12 = string.Equals((string)(object)array, "input_mainmenuquestlog");
						if (!flag12)
						{
							goto IL_0526;
						}
					}
					if (flag12)
					{
						flag13 = string.Equals((string)(object)array, "input_mainmenudreamlight");
						if (!flag13)
						{
							goto IL_0526;
						}
					}
					if (flag13)
					{
						flag14 = string.Equals((string)(object)array, "input_shortcutwateringcan");
						if (flag14)
						{
							goto IL_040e;
						}
					}
				}
				goto IL_0526;
				IL_040e:
				if ((flag14 ? 1 : 0) <= (true ? 1 : 0))
				{
					goto IL_04c0;
				}
				if ((flag14 ? 1 : 0) <= (true ? 1 : 0))
				{
					goto IL_046c;
				}
				if (flag14)
				{
					flag15 = string.Equals((string)(object)array, "input_fasttrackquest");
					if (flag15)
					{
						goto IL_0487;
					}
				}
				if (flag15)
				{
					flag16 = string.Equals((string)(object)array, "input_toolswheel");
					if (!flag16)
					{
						goto IL_0526;
					}
				}
				if (flag16)
				{
					flag8 = string.Equals((string)(object)array, "catalog");
					if (flag8)
					{
						goto IL_046c;
					}
				}
				goto IL_0526;
				IL_0069:
				int num5 = 0;
				if (InputDetectionHelper.IsConsole())
				{
					int num6 = 0;
					UiRoot instance = UiRoot.Instance;
					if (controller != instance.CurrentControlType)
					{
						int num7 = 0;
						if (UiRoot.Instance.CurrentControlType != 0)
						{
							int num8 = 0;
							InputDetectionHelper.InputController currentControlType = UiRoot.Instance.CurrentControlType;
						}
					}
					int num9 = 0;
					RuntimePlatform runtimePlatform = PlatformUtils.GetRuntimePlatform();
					if (runtimePlatform == RuntimePlatform.PS4)
					{
					}
					switch (runtimePlatform)
					{
					}
					int num10 = 0;
					UiRoot.Instance.CurrentControlType = (InputDetectionHelper.InputController)num11;
				}
				char[] array2 = new char[1];
				array2[0] = (char)num12;
				string[] array3 = text.Split(array2);
				string text3 = ((Enum)inputController).ToString();
				InputDetectionHelper.InputController inputController2 = inputController;
				if (!string.Equals(text, "input_trackquest") || string.Equals("XboxOne", "NintendoSwitch"))
				{
				}
				if (string.Equals("input_interact", "input_fishingaction"))
				{
				}
				if (string.Equals("input_interact", "input_catalog") || string.Equals("input_interact", "catalog"))
				{
				}
				if (flag17 || flag18)
				{
				}
				if (string.Equals("inventory", "mainmenudreamlight"))
				{
				}
				bool flag19 = string.Equals("input_inventory", "input_fasttravel");
				if (!flag19 || inputController2 == InputDetectionHelper.InputController.NintendoSwitch || inputController2 == InputDetectionHelper.InputController.PlayStation4 || inputController2 == InputDetectionHelper.InputController.PlayStation5 || (flag19 ? 1 : 0) <= (true ? 1 : 0) || inputController2 == InputDetectionHelper.InputController.XboxSeries)
				{
				}
				if (string.Equals("input_inventory", "input_interact"))
				{
				}
				bool flag20 = string.Equals("input_inventory", "input_fasttrackquest");
				array = new string[5];
				if ("<sprite name=" != null && "<sprite name=" == null)
				{
					continue;
				}
				array[0] = "<sprite name=";
				if ("icon" != null && "<sprite name=" == null)
				{
					continue;
				}
				array[1] = "icon";
				if ("." != null && "." == null)
				{
					continue;
				}
				array[2] = ".";
				if ("interact" != null && "." == null)
				{
					continue;
				}
				array[3] = "interact";
				if (">" != null && ">" == null)
				{
					continue;
				}
				array[4] = ">";
				string text4 = string.Concat(array);
				uint num13 = _003CPrivateImplementationDetails_003E.ComputeStringHash((string)(object)array);
				if ((int)num13 <= 1979092248)
				{
					goto IL_040e;
				}
				if ((int)num13 <= -1307314864)
				{
					goto IL_034c;
				}
				if ((int)num13 > -409220276)
				{
					if (num13 == 3913582865u)
					{
						flag21 = string.Equals((string)(object)array, "input_usetool");
						if (!flag21)
						{
							goto IL_0526;
						}
					}
					if (flag21)
					{
						flag22 = string.Equals((string)(object)array, "input_mainmenumap");
						if (!flag22)
						{
							goto IL_0526;
						}
					}
					if (!flag22)
					{
						goto IL_0526;
					}
					flag23 = string.Equals((string)(object)array, "input_catalog");
					if (flag23)
					{
						goto IL_046c;
					}
				}
				if (flag23)
				{
					flag24 = string.Equals((string)(object)array, "input_mainmenucollection");
					if (!flag24)
					{
						goto IL_0526;
					}
				}
				if (flag24)
				{
					flag25 = string.Equals((string)(object)array, "input_shortcutfishingpole");
					if (!flag25)
					{
						goto IL_0526;
					}
				}
				if (flag25)
				{
					flag9 = string.Equals((string)(object)array, "input_wardrobe");
					if (flag9)
					{
						goto IL_034c;
					}
				}
				goto IL_0526;
			}
			int num14 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0x17EB500", Offset = "0x17E9F00", VA = "0x1817EB500")]
		public void SetAdjustForHandheld(AdjustForHandheldParam param)
		{
			//Discarded unreachable code: IL_0059
			int num = (_minFontSize = param.min);
			int num2 = (_maxFontSize = param.max);
			int num3 = (_staticFontSize = param.staticSize);
			bool flag = (_autoExpand = param.autoExpand);
			float num4 = (_increaseXBy = param.increaseX);
			float num5 = (_increaseYBy = param.increaseY);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC3")]
		[Cpp2IlInjected.Address(RVA = "0x17E9C10", Offset = "0x17E8610", VA = "0x1817E9C10")]
		public void AdjustForHandheld()
		{
			//Discarded unreachable code: IL_012c
			//IL_0044: Expected F4, but got I4
			//IL_005b: Expected F4, but got I4
			//IL_0074: Expected F4, but got I4
			//IL_00b1: Expected O, but got I4
			//IL_00d4: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (!PlatformUtils.IsSteamDeck())
				{
					return;
				}
				if (_minFontSize != -1)
				{
					if (_maxFontSize == -1)
					{
						continue;
					}
					TextComponent.enableAutoSizing = true;
					if (_minFontSize != -1)
					{
						int num3 = 0;
						TextComponent.fontSizeMin = num3;
					}
				}
				if (_maxFontSize != -1)
				{
					int num4 = 0;
					TextComponent.fontSizeMax = num4;
				}
				if (_staticFontSize != -1)
				{
					int num5 = 0;
					TextComponent.fontSize = num5;
				}
				RectTransform component = base.gameObject.GetComponent<RectTransform>();
				if (_autoExpand)
				{
					break;
				}
				if (_autoExpand)
				{
					Vector2 sizeDelta = component.sizeDelta;
					int num6 = 0;
					Vector2 sizeDelta2 = component.sizeDelta;
					component.sizeDelta = (Vector2)num6;
				}
				if ((object)component != null)
				{
					Vector2 sizeDelta3 = component.sizeDelta;
					int num7 = 0;
					Vector2 sizeDelta4 = component.sizeDelta;
					component.sizeDelta = (Vector2)num7;
				}
				return;
			}
			SetSizeBasedOnChild orAddComponent = base.transform.parent.GetOrAddComponent<SetSizeBasedOnChild>();
			SetSizeBasedOnChild.SizeAdjustment sizeAdjustment = (orAddComponent._sizeToAdjust = _sizeAdjustment);
			if (((object)orAddComponent != null || (object)orAddComponent != null) && _sizeAdjustment == SetSizeBasedOnChild.SizeAdjustment.Height)
			{
				float num8 = (orAddComponent.minHeight = _minY);
			}
			orAddComponent._specificChild = (RectTransform)0;
			orAddComponent.DoAdjustment();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC4")]
		[Cpp2IlInjected.Address(RVA = "0x17EB880", Offset = "0x17EA280", VA = "0x1817EB880")]
		public TextBase()
		{
		}//IL_0014: Expected I4, but got I8
		//IL_0024: Expected I4, but got I8
		//IL_004e: Expected I4, but got I8

	}
}
