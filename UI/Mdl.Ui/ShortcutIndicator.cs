using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Mdl.RewiredConsts;
using NaughtyAttributes;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001E0")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ShortcutIndicator : MonoBehaviour, IHasDynamicView
	{
		[Cpp2IlInjected.Token(Token = "0x20001E1")]
		public enum ColorScheme
		{
			[Cpp2IlInjected.Token(Token = "0x4000833")]
			NavyBgPaleIco,
			[Cpp2IlInjected.Token(Token = "0x4000834")]
			PaleBgNavyIco
		}

		[Cpp2IlInjected.Token(Token = "0x20001E2")]
		public enum VisualType
		{
			[Cpp2IlInjected.Token(Token = "0x4000836")]
			Itself = 0,
			[Cpp2IlInjected.Token(Token = "0x4000837")]
			TextInCircle = 1,
			[Cpp2IlInjected.Token(Token = "0x4000838")]
			TextInCircleAndLabel = 2,
			[Cpp2IlInjected.Token(Token = "0x4000839")]
			IconInCircle = 3,
			[Cpp2IlInjected.Token(Token = "0x400083A")]
			IconInCircleAndLabel = 4,
			[Cpp2IlInjected.Token(Token = "0x400083B")]
			TextInCylinder = 5,
			[Cpp2IlInjected.Token(Token = "0x400083C")]
			TextInLeftBumper = 6,
			[Cpp2IlInjected.Token(Token = "0x400083D")]
			TextInRightBumper = 7,
			[Cpp2IlInjected.Token(Token = "0x400083E")]
			TextInLeftTrigger = 8,
			[Cpp2IlInjected.Token(Token = "0x400083F")]
			TextInRightTrigger = 9,
			[Cpp2IlInjected.Token(Token = "0x4000840")]
			IconOnly = 10,
			[Cpp2IlInjected.Token(Token = "0x4000841")]
			IconAndLabel = 11,
			[Cpp2IlInjected.Token(Token = "0x4000842")]
			TextInOutlineCircle = 12,
			[Cpp2IlInjected.Token(Token = "0x4000843")]
			TextInOutlineBar = 13,
			[Cpp2IlInjected.Token(Token = "0x4000844")]
			IconInOutlineCircle = 14,
			[Cpp2IlInjected.Token(Token = "0x4000845")]
			IconInOutlineBar = 15,
			[Cpp2IlInjected.Token(Token = "0x4000846")]
			TextInOutlineCircleAndLabel = 16,
			[Cpp2IlInjected.Token(Token = "0x4000847")]
			IconInOutlineCircleAndLabel = 17,
			[Cpp2IlInjected.Token(Token = "0x4000848")]
			TextInCircleLightBlue = 4112,
			[Cpp2IlInjected.Token(Token = "0x4000849")]
			TextInCircleNavy = 4128,
			[Cpp2IlInjected.Token(Token = "0x400084A")]
			TextInCircleAndLabelLightBlue = 4144,
			[Cpp2IlInjected.Token(Token = "0x400084B")]
			TextInCircleAndLabelNavy = 4160,
			[Cpp2IlInjected.Token(Token = "0x400084C")]
			IconInCircleLightBlue = 8208,
			[Cpp2IlInjected.Token(Token = "0x400084D")]
			IconInCircleNavy = 8224,
			[Cpp2IlInjected.Token(Token = "0x400084E")]
			IconInCircleAndLabelLightBlue = 8240,
			[Cpp2IlInjected.Token(Token = "0x400084F")]
			IconInCircleAndLabelNavy = 8256,
			[Cpp2IlInjected.Token(Token = "0x4000850")]
			TextInLeftBumperLightBlue = 12304,
			[Cpp2IlInjected.Token(Token = "0x4000851")]
			TextInLeftBumperNavy = 12320,
			[Cpp2IlInjected.Token(Token = "0x4000852")]
			TextInRightBumperLightBlue = 12336,
			[Cpp2IlInjected.Token(Token = "0x4000853")]
			TextInRightBumperNavy = 12352,
			[Cpp2IlInjected.Token(Token = "0x4000854")]
			TextInLeftTriggerLightBlue = 12368,
			[Cpp2IlInjected.Token(Token = "0x4000855")]
			TextInLeftTriggerNavy = 12384,
			[Cpp2IlInjected.Token(Token = "0x4000856")]
			TextInRightTriggerLightBlue = 12400,
			[Cpp2IlInjected.Token(Token = "0x4000857")]
			TextInRightTriggerNavy = 12416,
			[Cpp2IlInjected.Token(Token = "0x4000858")]
			IconOnlyLightBlue = 16400,
			[Cpp2IlInjected.Token(Token = "0x4000859")]
			IconAndLabelLightBlue = 16432,
			[Cpp2IlInjected.Token(Token = "0x400085A")]
			TextInCylinderLightBlue = 20496,
			[Cpp2IlInjected.Token(Token = "0x400085B")]
			TextInCylinderNavy = 20512,
			[Cpp2IlInjected.Token(Token = "0x400085C")]
			TextInBarLightBlue = 24592,
			[Cpp2IlInjected.Token(Token = "0x400085D")]
			TextInBarNavy = 24608,
			[Cpp2IlInjected.Token(Token = "0x400085E")]
			TextInBarAndLabelLightBlue = 24624
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		[SerializeField]
		[Space]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		[Space(15f)]
		[Header("Shortcut")]
		public int RewiredActionIdGP = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		[SerializeField]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredActionIdPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		[SerializeField]
		[Space]
		[Space(15f)]
		[Header("Visuals")]
		private ColorScheme _colorScheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		[SerializeField]
		private Image BG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		[SerializeField]
		private Image Ico;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		[SerializeField]
		private bool SetNativeSizeOnLoad = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		[SerializeField]
		private TextBase _textBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		[Space]
		[Header("Action")]
		[Space(15f)]
		public InputActionEventType[] RewiredActionEventTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		[Space]
		public UnityEvent OnTriggered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		[Space]
		[Header("Legacy")]
		[Space(15f)]
		public bool ForceNewStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		public ShortcutDefinition ShortcutDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		[FormerlySerializedAs("Button")]
		public BaseButton BaseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		[Label("Ignore ActiveSelf Of Button")]
		public bool IgnoreActiveSelfOfBaseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		[FormerlySerializedAs("TargetButton")]
		public TemplateButton TemplateButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		[Label("Ignore ActiveSelf Of Template Button")]
		[FormerlySerializedAs("IgnoreActiveSelfOfButton")]
		public bool IgnoreActiveSelfOfTemplateButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		[SerializeField]
		private bool AutoAdjustWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		[Space]
		[SerializeField]
		private ShortcutIndicatorView _view;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		[SerializeField]
		[Header("Template")]
		public List<VisualType> TemplateOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		private bool _hasBackup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		private Menu _topMenu;

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public TextBase TextBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000C43")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _textBase;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		public bool CanTriggerBaseButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x15EFD90", Offset = "0x15EE790", VA = "0x1815EFD90")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_004e: Expected O, but got I4
				BaseButton baseButton = BaseButton;
				int num = 0;
				if (baseButton != (UnityEngine.Object)num)
				{
					if (IgnoreActiveSelfOfBaseButton)
					{
						return true;
					}
					if (base.gameObject.activeInHierarchy)
					{
						BaseButton baseButton2 = BaseButton;
						if (baseButton2._isActive)
						{
							Button buttonComponent = baseButton2.ButtonComponent;
							int num2 = 0;
							if (buttonComponent != (UnityEngine.Object)num2)
							{
								return ((Selectable)BaseButton.ButtonComponent).m_Interactable;
							}
						}
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		public bool CanTriggerTemplateButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0x15EFEF0", Offset = "0x15EE8F0", VA = "0x1815EFEF0")]
			get
			{
				//IL_0010: Expected O, but got I4
				TemplateButton templateButton = TemplateButton;
				int num = 0;
				if (templateButton != (UnityEngine.Object)num)
				{
					if (IgnoreActiveSelfOfTemplateButton)
					{
						return true;
					}
					if (base.gameObject.activeInHierarchy)
					{
						TemplateButton templateButton2 = TemplateButton;
						if (templateButton2._isActivated)
						{
							return templateButton2._interactable;
						}
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		public ShortcutIndicatorTemplate Template
		{
			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CTemplate_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			[CompilerGenerated]
			set
			{
				_003CTemplate_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		public ShortcutIndicatorView View
		{
			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x15F0060", Offset = "0x15EEA60", VA = "0x1815F0060")]
			get
			{
				//IL_0014: Expected O, but got I4
				bool flag = default(bool);
				if (flag)
				{
					GameObject view = GetView();
					int num = 0;
					if (view != (UnityEngine.Object)num)
					{
						ShortcutIndicatorView shortcutIndicatorView = (_view = view.GetComponent<ShortcutIndicatorView>());
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		public bool IsNewStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x15EFFB0", Offset = "0x15EE9B0", VA = "0x1815EFFB0")]
			get
			{
				//IL_0019: Expected O, but got I4
				//IL_002c: Expected O, but got I4
				if (!ForceNewStyle)
				{
					Image bG = BG;
					int num = 0;
					if (!(bG != (UnityEngine.Object)num))
					{
						Image ico = Ico;
						int num2 = 0;
						return ico != (UnityEngine.Object)num2;
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		public bool CanTriggerRedirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x15EFEB0", Offset = "0x15EE8B0", VA = "0x1815EFEB0")]
			get
			{
				//Discarded unreachable code: IL_0020
				if (!IgnoreActiveSelfOfBaseButton && !IgnoreActiveSelfOfTemplateButton)
				{
					return base.gameObject.activeInHierarchy;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x15ECCF0", Offset = "0x15EB6F0", VA = "0x1815ECCF0")]
		private void Awake()
		{
			RectTransform rectTransform = (_rectTransform = GetComponent<RectTransform>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x15EE330", Offset = "0x15ECD30", VA = "0x1815EE330")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0034
			//IL_0010: Expected O, but got I4
			Menu topMenu = _topMenu;
			int num = 0;
			if (topMenu != (UnityEngine.Object)num)
			{
				Menu.ControllerChange onControllerChange = _topMenu.OnControllerChange;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(ControllerChange);
				((UnityEvent<T0>)(object)onControllerChange).RemoveListener((UnityAction<>)(object)unityAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x15EE610", Offset = "0x15ED010", VA = "0x1815EE610")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0180
			//IL_002c: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			do
			{
				if (_hasBackup)
				{
					Template.Load(this);
				}
				ShortcutIndicatorView view = _view;
				_hasBackup = false;
				int num = 0;
				if (view == (UnityEngine.Object)num)
				{
					ShortcutIndicatorView shortcutIndicatorView = (_view = View);
				}
				if (base.gameObject.activeSelf)
				{
					TransformToPreset();
				}
				ShortcutIndicatorView view2 = _view;
				int num2 = 0;
				if (view2 != (UnityEngine.Object)num2)
				{
					UnityEvent onRefreshed = _view.AdditionalLabel.GetComponent<TextBase>().OnRefreshed;
					UnityAction call = RefreshVisuals;
					onRefreshed.AddListener(call);
				}
				int num3 = 0;
				if (!Application.isPlaying)
				{
					return;
				}
				int num4 = 0;
				UiRoot instance = UiRoot.Instance;
				if ((object)instance != null)
				{
					int num5 = 0;
					if (instance.MenuOnTop != null)
					{
						int num6 = 0;
					}
				}
				int num7 = 0;
				_topMenu = (Menu)num7;
				Menu topMenu = _topMenu;
				int num8 = 0;
				if (topMenu != (UnityEngine.Object)num8)
				{
					Menu.ControllerChange onControllerChange = _topMenu.OnControllerChange;
					UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(ControllerChange);
					((UnityEvent<T0>)(object)onControllerChange).AddListener((UnityAction<>)(object)unityAction);
				}
				int num9 = 0;
				UiRoot instance2 = UiRoot.Instance;
				if ((object)instance2 != null)
				{
					int useKeyboardAsController = 0;
					if (instance2.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						if (RewiredActionIdGP > 0 && !base.gameObject.activeSelf)
						{
							base.gameObject.SetActive(value: true);
							return;
						}
						continue;
					}
				}
				if (base.gameObject.activeSelf && RewiredActionIdGP > 0)
				{
					GameObject gameObject = base.gameObject;
				}
			}
			while (!base.gameObject.activeSelf);
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x15EE430", Offset = "0x15ECE30", VA = "0x1815EE430")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_005b
			bool flag = default(bool);
			if (flag)
			{
				TextBase textBase = default(TextBase);
				UnityEvent onRefreshed = textBase.OnRefreshed;
				UnityAction call = RefreshVisuals;
				onRefreshed.RemoveListener(call);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				ShortcutIndicatorTemplate shortcutIndicatorTemplate = Template;
				_hasBackup = true;
				shortcutIndicatorTemplate.Backup(this);
				int num = 0;
				if (Application.isPlaying)
				{
					int num2 = 0;
					GameObject trash = default(GameObject);
					UiRoot.Instance._miscRecycleBin.SendToBin(trash);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x15ECD40", Offset = "0x15EB740", VA = "0x1815ECD40")]
		private void ControllerChange(bool value)
		{
			//Discarded unreachable code: IL_0028, IL_0066
			do
			{
				if (value)
				{
					if (RewiredActionIdGP > 0 && !base.gameObject.activeSelf)
					{
						base.gameObject.SetActive(value: true);
						return;
					}
				}
				else if (base.gameObject.activeSelf && RewiredActionIdGP > 0)
				{
					GameObject gameObject = base.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					return;
				}
			}
			while (!base.gameObject.activeSelf);
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x15EEA00", Offset = "0x15ED400", VA = "0x1815EEA00")]
		public unsafe void RefreshVisuals()
		{
			//IL_001c: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_00d7: Expected F4, but got I4
			//IL_015a: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			//IL_01bb: Expected O, but got I4
			//IL_023c: Expected O, but got I4
			//IL_02bd: Expected O, but got I4
			//IL_02db: Expected O, but got I4
			//IL_02ef: Expected O, but got I4
			//IL_0310: Expected O, but got I4
			//IL_032d: Expected O, but got I4
			//IL_0356: Expected O, but got I4
			//IL_036a: Expected O, but got I4
			//IL_039a: Expected O, but got I4
			//IL_03bc: Expected O, but got I4
			//IL_03d0: Expected O, but got I4
			//IL_03f9: Expected O, but got I4
			//IL_040d: Expected O, but got I4
			//IL_0444: Expected I4, but got I8
			if (AutoAdjustWidth)
			{
				ShortcutIndicatorView view = _view;
				int num = 0;
				if (view != (UnityEngine.Object)num)
				{
					RectTransform rectTransform = _rectTransform;
					int num2 = 0;
					if (rectTransform != (UnityEngine.Object)num2)
					{
						ShortcutIndicatorView view2 = _view;
						RectTransform rectTransform2 = _rectTransform;
						RectTransform component = view2.BackgroundHolderObject.GetComponent<RectTransform>();
						if (view2.AdditionalLabel.gameObject.activeSelf)
						{
							TMP_Text additionalLabel = view2.AdditionalLabel;
							int forceTextReparsing = 0;
							int ignoreActiveState = 0;
							additionalLabel.ForceMeshUpdate((byte)ignoreActiveState != 0, (byte)forceTextReparsing != 0);
							float preferredWidth = view2.AdditionalLabel.preferredWidth;
						}
						int axis = 0;
						float size = default(float);
						rectTransform2.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, size);
						LayoutRebuilder.MarkLayoutForRebuild(_rectTransform);
					}
				}
			}
			if ((object)BaseUiRoot.Instance != null)
			{
				uint num3 = num3 + 20;
				num3 += num3;
				int num4 = 0;
				string message = default(string);
				Debug.Log(message);
			}
			int num5 = 0;
			int num6 = 0;
			RotateIcon(num6);
			string iconSpriteName = GetIconSpriteName();
			if (string.IsNullOrWhiteSpace(iconSpriteName))
			{
			}
			string bgSpriteName = GetBgSpriteName(iconSpriteName, out *(bool*)num5);
			if ((object)BaseUiRoot.Instance != null)
			{
				uint num7 = num7 + 20;
				num7 += num7;
				Debug.Log("[UI] ShortcutIndicator#RefreshVisuals icoSpriteName: " + iconSpriteName);
				Debug.Log("[UI] ShortcutIndicator#RefreshVisuals bgSpriteName: " + bgSpriteName);
			}
			if (!ForceNewStyle && string.Equals(iconSpriteName, ""))
			{
				Image bG = BG;
				int num8 = 0;
				if (bG != (UnityEngine.Object)num8)
				{
					GameObject gameObject = BG.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				Image ico = Ico;
				int num9 = 0;
				if (ico != (UnityEngine.Object)num9)
				{
					GameObject gameObject2 = Ico.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
				}
				return;
			}
			Image ico2 = Ico;
			int num10 = 0;
			if (ico2 != (UnityEngine.Object)num10)
			{
				GameObject gameObject3 = Ico.gameObject;
				if (ForceNewStyle)
				{
				}
				bool active3 = default(bool);
				gameObject3.SetActive(active3);
				Image ico3 = Ico;
				if (!ForceNewStyle)
				{
				}
				bool flag = default(bool);
				ico3.enabled = flag;
				SpriteAtlasImage component2 = Ico.GetComponent<SpriteAtlasImage>();
				if (SetNativeSizeOnLoad)
				{
					Ico.SetNativeSize();
				}
				LayoutRebuilder.MarkLayoutForRebuild(Ico.rectTransform);
			}
			Image bG2 = BG;
			int num11 = 0;
			if (bG2 != (UnityEngine.Object)num11)
			{
				GameObject gameObject4 = BG.gameObject;
				if (ForceNewStyle)
				{
				}
				bool active4 = default(bool);
				gameObject4.SetActive(active4);
				Image bG3 = BG;
				if (!ForceNewStyle)
				{
				}
				bool flag2 = default(bool);
				bG3.enabled = flag2;
				SpriteAtlasImage component3 = BG.GetComponent<SpriteAtlasImage>();
				if (SetNativeSizeOnLoad)
				{
					BG.SetNativeSize();
				}
				LayoutRebuilder.MarkLayoutForRebuild(BG.rectTransform);
			}
			Image bG4 = BG;
			int num12 = 0;
			if (bG4 != (UnityEngine.Object)num12)
			{
				Image bG5 = BG;
				int num13 = 0;
				Color white = Color.white;
				bG5.color = (Color)num13;
			}
			Image ico4 = Ico;
			int num14 = 0;
			if (ico4 != (UnityEngine.Object)num14)
			{
				Image ico5 = Ico;
				int num15 = 0;
				Color white2 = Color.white;
				ico5.color = (Color)num15;
				UiRoot instance = default(UiRoot);
				if (_colorScheme == ColorScheme.NavyBgPaleIco)
				{
					Image bG6 = BG;
					int num16 = 0;
					if (bG6 != (UnityEngine.Object)num16)
					{
						Image bG7 = BG;
						int num17 = 0;
						if ((object)UiRoot.Instance != null)
						{
						}
						int num18 = 0;
						Color blue = Color.blue;
						bG7.color = (Color)num18;
					}
					Image ico6 = Ico;
					int num19 = 0;
					if (!(ico6 != (UnityEngine.Object)num19))
					{
						goto IL_03f9;
					}
					int num20 = 0;
					instance = UiRoot.Instance;
					if ((object)instance == null)
					{
					}
				}
				if ((long)instance == 1)
				{
					Image bG8 = BG;
					int num21 = 0;
					if (bG8 != (UnityEngine.Object)num21)
					{
						Image bG9 = BG;
						int num22 = 0;
						if ((object)UiRoot.Instance != null)
						{
						}
						int num23 = 0;
						bG9.color = (Color)num23;
					}
					Image ico7 = Ico;
					int num24 = 0;
					if (ico7 != (UnityEngine.Object)num24)
					{
						Image ico8 = Ico;
						int num25 = 0;
						if ((object)UiRoot.Instance != null)
						{
						}
						int num26 = 0;
						Color blue2 = Color.blue;
						ico8.color = (Color)num26;
					}
				}
			}
			goto IL_03f9;
			IL_03f9:
			ShortcutIndicatorView view3 = _view;
			int num27 = 0;
			if (view3 != (UnityEngine.Object)num27)
			{
				GameObject gameObject5 = _view.gameObject;
				int active5 = 0;
				gameObject5.SetActive((byte)active5 != 0);
			}
			if (!base.gameObject.activeSelf)
			{
				ulong num28 = default(ulong);
				base.gameObject.SetActive((byte)num28 != 0);
			}
			LayoutRebuilder.MarkLayoutForRebuild(_rectTransform);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x15ECF80", Offset = "0x15EB980", VA = "0x1815ECF80")]
		private string GetBgSpriteName(string spriteName, out bool shouldColorize)
		{
			char[] array = new char[1];
			array[0] = '_';
			string[] array2 = spriteName.Split(array);
			int length = array2.Length;
			string text = array2[0];
			string text2 = array2[1];
			string text3 = array2[2];
			if (array2 == null)
			{
				if (array2 == null)
				{
					if (text3 == null)
					{
						goto IL_007c;
					}
					if ((long)array2 > 839689206)
					{
						if ((long)array2 > 906799682)
						{
							if ((long)array2 > 1007465396)
							{
								if ((long)array2 == 1731450012)
								{
									if (array2 == null)
									{
									}
									goto IL_007c;
								}
								while ((long)"" != 1748227631)
								{
								}
								while ("" == null)
								{
								}
							}
							if ((long)"" == 923577301)
							{
							}
							while ((long)"" != 1007465396)
							{
							}
						}
						if ((long)"" > 873244444)
						{
							if ((long)"" == 890022063 && "" != null)
							{
								goto IL_020e;
							}
							while ((long)"" != 906799682)
							{
							}
						}
						if ((long)"" == 856466825)
						{
							while ("" == null)
							{
							}
							if ("" == null && "" == null)
							{
								goto IL_020e;
							}
						}
						while ((long)"" != 873244444)
						{
						}
						while ("" == null)
						{
						}
					}
					if ((long)"" > 501951850)
					{
						if ((long)"" > 806133968)
						{
							if ((long)"" == 822911587)
							{
								while ("" == null)
								{
								}
							}
							while ((long)"" != 839689206)
							{
							}
							while ("" == null)
							{
							}
							if ("" == null)
							{
								string text4 = "label_gamepad_options_ps5";
								if ("" == null)
								{
									text4 = "label_gamepad_round";
								}
							}
						}
						if ((long)"" == 518729469)
						{
						}
						while ((long)"" != 806133968)
						{
						}
						while ("" == null)
						{
						}
					}
					if ((long)"" > 468396612)
					{
						if ((long)"" == 485174231)
						{
						}
						while ((long)"" != 501951850)
						{
						}
					}
					if ((long)"" == 401286136)
					{
					}
					while ((long)"" != 468396612)
					{
					}
				}
				while (text3 == null)
				{
				}
				while (array2 != null)
				{
				}
			}
			if (text3 != null)
			{
				while (array2 != null)
				{
				}
			}
			goto IL_020e;
			IL_020e:
			throw new NullReferenceException();
			IL_007c:
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x15ED580", Offset = "0x15EBF80", VA = "0x1815ED580")]
		private string GetIconSpriteName()
		{
			//Discarded unreachable code: IL_0242, IL_0248, IL_024e, IL_0254, IL_025a, IL_0260, IL_0266, IL_0278, IL_0284, IL_028a, IL_0290, IL_029c, IL_02a2, IL_02a8
			//IL_002a: Expected O, but got I4
			//IL_0037: Expected I4, but got I8
			//IL_00ba: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			//IL_0126: Expected F4, but got I4
			//IL_014f: Expected F4, but got I4
			//IL_0198: Expected O, but got I4
			//IL_022a: Expected O, but got I4
			ulong num4 = default(ulong);
			IList<Joystick> list = default(IList<Joystick>);
			uint num7 = default(uint);
			IList<ControllerMap> list2 = default(IList<ControllerMap>);
			int num8 = default(int);
			IEnumerable<ActionElementMap> enumerable = default(IEnumerable<ActionElementMap>);
			InputAction inputAction = default(InputAction);
			KeyCode keyCode = default(KeyCode);
			KeyCode keyCode2 = default(KeyCode);
			IList<ActionElementMap> list3 = default(IList<ActionElementMap>);
			string text3 = default(string);
			InputDetectionHelper.InputController inputController2 = default(InputDetectionHelper.InputController);
			int num16 = default(int);
			string text4 = default(string);
			InputDetectionHelper.InputController inputController4 = default(InputDetectionHelper.InputController);
			string text6 = default(string);
			string text8 = default(string);
			while (true)
			{
				int num = 0;
				InputDetectionHelper.InputController controller;
				int num6;
				if (RewiredActionIdPC != -1 || RewiredActionIdGP != -1)
				{
					int num2 = 0;
					UiRoot instance = UiRoot.Instance;
					int num3 = 0;
					if (!(instance == (UnityEngine.Object)num3))
					{
						controller = InputDetectionHelper.GetController((byte)num4 != 0);
						int num5 = 0;
						ReInput.PlayerHelper players = ReInput.players;
						if (players != null)
						{
							int playerId = 0;
							Rewired.Player player = players.GetPlayer(playerId);
						}
						if (RewiredActionIdGP != -1)
						{
							num6 = 0;
							if (list != null)
							{
								if (num < (int)num7)
								{
									num += num;
									if (num == (int)num7)
									{
										goto IL_0087;
									}
									num++;
								}
								if (list2 != null)
								{
									goto IL_0087;
								}
								goto IL_01c2;
							}
							goto IL_01df;
						}
					}
				}
				goto IL_023c;
				IL_023c:
				return "";
				IL_01df:
				num8++;
				int num9 = 0;
				if (list != null)
				{
				}
				if (num != 0)
				{
					break;
				}
				if (num8 != 0)
				{
					int num10 = num8 - 1;
				}
				if ((long)list != -1)
				{
					if (enumerable != null)
					{
						int num11 = 0;
						ReInput.MappingHelper mapping = ReInput.mapping;
						while (inputAction == null)
						{
						}
						while (keyCode == KeyCode.None)
						{
						}
						int num12 = (int)keyCode2;
						string text = ((Enum)keyCode2).ToString();
						KeyCode keyCode3 = keyCode2;
					}
					if (enumerable != null)
					{
					}
					if (num != 0)
					{
						continue;
					}
				}
				goto IL_023c;
				IL_0087:
				int num13;
				if (list2 != null)
				{
					if (list3 != null)
					{
						num13 = 0;
						while (num13 != RewiredActionIdGP)
						{
						}
						if (list3 != null)
						{
							while ((long)list3 != 1)
							{
							}
							string text2 = ((Enum)controller).ToString();
							InputDetectionHelper.InputController inputController = controller;
							int num14 = 0;
							int num15 = (int)inputController;
							if ((inputController == InputDetectionHelper.InputController.XboxOne || inputController == InputDetectionHelper.InputController.XboxSeries) && num13 != 7)
							{
								if (num13 == 6)
								{
									goto IL_00ed;
								}
								text3 = ((Enum)inputController2).ToString();
								InputDetectionHelper.InputController inputController3 = inputController2;
							}
							if (num13 == 6)
							{
								goto IL_00ed;
							}
							goto IL_0106;
						}
						goto IL_0167;
					}
					goto IL_01ae;
				}
				throw new InvalidCastException();
				IL_01ae:
				num++;
				if (list3 != null)
				{
				}
				if (num == 0)
				{
					while (num == 0)
					{
					}
					goto IL_01c2;
				}
				throw new NullReferenceException();
				IL_01c2:
				num16++;
				if (list2 != null)
				{
				}
				if (num == 0)
				{
					while (num16 == 0)
					{
					}
					num8 = num16 - 1;
					goto IL_01df;
				}
				throw new NullReferenceException();
				IL_0167:
				if (((long)text4 != 3 && (long)text4 != 4 && ((long)text4 != 7 || (long)text4 > 1)) || (long)text4 <= 2 || (long)text4 <= 1)
				{
				}
				string text5 = ((Enum)inputController4).ToString();
				InputDetectionHelper.InputController inputController5 = inputController4;
				string text7 = text5 + "_Axis_" + text6;
				goto IL_01ae;
				IL_00ed:
				int num17 = 0;
				if (!UiRoot.Instance.IsPs5Controller())
				{
				}
				if (_colorScheme != 0)
				{
				}
				goto IL_0106;
				IL_0106:
				if (num13 != 11)
				{
					if (num13 != 12)
					{
						if (num13 != 13)
						{
							if (num13 != 14)
							{
								RotateIcon(num6);
							}
							RotateIcon(-90f);
						}
						RotateIcon(180f);
					}
					RotateIcon(90f);
				}
				RotateIcon(num6);
				int num18 = 0;
				text4 = text3 + "_Button_" + text8 + "_light";
				goto IL_0167;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x15ECC70", Offset = "0x15EB670", VA = "0x1815ECC70")]
		private bool ApplyDpadModifier(ref int btnIndex, ref string prefixStr)
		{
			//Discarded unreachable code: IL_000b, IL_0018, IL_0025
			//IL_0009: Expected F4, but got I4
			int num = 0;
			RotateIcon(num);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x15EF790", Offset = "0x15EE190", VA = "0x1815EF790")]
		private void RotateIcon(float angle)
		{
			//Discarded unreachable code: IL_0021
			//IL_0010: Expected O, but got I4
			Image ico = Ico;
			int num = 0;
			if (ico != (UnityEngine.Object)num)
			{
				RectTransform component = Ico.GetComponent<RectTransform>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x15ECE20", Offset = "0x15EB820", VA = "0x1815ECE20")]
		public void CopyFrom(ShortcutIndicator shortcutIndicator)
		{
			//Discarded unreachable code: IL_009e
			shortcutIndicator.Template.Target = shortcutIndicator;
			shortcutIndicator.Template.GameObjectTemplate.IgnoreParent = true;
			shortcutIndicator.Template.BackgroundHolderTemplate.IgnoreParent = true;
			shortcutIndicator.Template.BackgroundTemplate.IgnoreParent = true;
			shortcutIndicator.Template.IconTemplate.IgnoreParent = true;
			shortcutIndicator.Template.LabelTemplate.IgnoreParent = true;
			shortcutIndicator.Template.AdditionalLabelTemplate.IgnoreParent = true;
			ShortcutIndicatorTemplate shortcutIndicatorTemplate = (Template = shortcutIndicator.Template.Clone());
			Template.Target = this;
			Template.Load(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x15EF880", Offset = "0x15EE280", VA = "0x1815EF880")]
		internal unsafe void TransformToPreset()
		{
			//Discarded unreachable code: IL_0135
			//IL_0094: Expected O, but got I4
			if (!ForceNewStyle)
			{
				int num = 0;
				int num2 = 0;
				if (Application.isPlaying)
				{
					int num3 = 0;
					List<ShortcutIndicatorTemplate> defaultShortcutIndicatorTemplates = (List<ShortcutIndicatorTemplate>)(object)UiRoot.Instance.get_DefaultShortcutIndicatorTemplates();
				}
				int num4 = 0;
				UiRoot instance = UiRoot.Instance;
				int currentController = default(int);
				if ((object)instance != null)
				{
					int useKeyboardAsController = 0;
					currentController = (int)instance.GetCurrentController((byte)useKeyboardAsController != 0);
				}
				int index = currentController;
				List<VisualType> templateOverride = TemplateOverride;
				int num5 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				if ((long)"{il2cpp array field local18->}" != 0)
				{
					Predicate<ShortcutIndicatorTemplate> predicate = (Predicate<ShortcutIndicatorTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorTemplate x)
					{
						//Discarded unreachable code: IL_002a
						VisualType visualType2 = x.VisualType;
						List<VisualType> templateOverride2 = TemplateOverride;
						int num7 = index;
						int num8 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						return (IntPtr)(void*)(int)visualType2 == (IntPtr)"{il2cpp array field local7->}";
					};
				}
				ShortcutDefinition shortcutDefinition = ShortcutDefinition;
				int num6 = 0;
				if (shortcutDefinition != (UnityEngine.Object)num6 && ShortcutDefinition.Self.IndicatorVisualType != 0 && num != 0)
				{
					Predicate<ShortcutIndicatorTemplate> predicate2 = (Predicate<ShortcutIndicatorTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorTemplate x)
					{
						//Discarded unreachable code: IL_0024
						ShortcutIndicator shortcutIndicator = this;
						VisualType visualType = x.VisualType;
						ShortcutDefinition self = shortcutIndicator.ShortcutDefinition.Self;
						return visualType == self.IndicatorVisualType;
					};
					ShortcutIndicatorTemplate shortcutIndicatorTemplate = default(ShortcutIndicatorTemplate);
					if (shortcutIndicatorTemplate != null)
					{
						ShortcutDefinition shortcutDefinition2 = (shortcutIndicatorTemplate.ShortcutDefinition = ShortcutDefinition);
						shortcutIndicatorTemplate.GameObjectTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate.BackgroundHolderTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate.BackgroundTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate.IconTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate.LabelTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate.AdditionalLabelTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate.Load(this);
					}
				}
			}
			RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x15EE0B0", Offset = "0x15ECAB0", VA = "0x1815EE0B0", Slot = "4")]
		[Obsolete]
		public GameObject GetView()
		{
			//IL_001c: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			if (!ForceNewStyle)
			{
				Image bG = BG;
				int num = 0;
				if (!(bG != (UnityEngine.Object)num))
				{
					Image ico = Ico;
					int num2 = 0;
					if (!(ico != (UnityEngine.Object)num2))
					{
						int num3 = 0;
						int num4 = 0;
						if (Application.isPlaying)
						{
							int num5 = 0;
							RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
							Type typeFromHandle = typeof(ShortcutIndicatorView);
							RectTransform content = _content;
							GameObject gameObject = miscRecycleBin.FindReusableOrNew(typeFromHandle, content);
						}
						int num6 = 0;
						if ((UnityEngine.Object)num4 != (UnityEngine.Object)num6)
						{
							Transform transform = default(Transform);
							if ((object)transform != null)
							{
							}
							int num7 = 0;
							float z = Vector3.one.z;
						}
					}
				}
			}
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x15EF6A0", Offset = "0x15EE0A0", VA = "0x1815EF6A0", Slot = "5")]
		[Obsolete]
		public void ReleaseView()
		{
			//Discarded unreachable code: IL_0037
			bool flag = default(bool);
			if (flag)
			{
				ShortcutIndicatorTemplate shortcutIndicatorTemplate = Template;
				_hasBackup = true;
				shortcutIndicatorTemplate.Backup(this);
				int num = 0;
				if (Application.isPlaying)
				{
					int num2 = 0;
					GameObject trash = default(GameObject);
					UiRoot.Instance._miscRecycleBin.SendToBin(trash);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x15EFB60", Offset = "0x15EE560", VA = "0x1815EFB60")]
		public ShortcutIndicator()
		{
			//Discarded unreachable code: IL_00a1
			//IL_0009: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			InputActionEventType[] array = new InputActionEventType[1];
			array[0] = InputActionEventType.ButtonJustPressed;
			RewiredActionEventTypes = array;
			TemplateOverride = (List<VisualType>)(object)new List<T>();
			Template = new ShortcutIndicatorTemplate
			{
				GameObjectTemplate = new GameObjectTemplate(),
				BackgroundHolderTemplate = new GameObjectTemplate(),
				BackgroundTemplate = new GameObjectTemplate(),
				LabelTemplate = new GameObjectTemplate(),
				AdditionalLabelTemplate = new GameObjectTemplate(),
				IconTemplate = new GameObjectTemplate()
			};
			base._002Ector();
		}
	}
}
