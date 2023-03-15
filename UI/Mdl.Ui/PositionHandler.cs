using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Grid;
using Mdl.Platform;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007DE")]
	public class PositionHandler : MonoBehaviour, IHasLayout
	{
		[Cpp2IlInjected.Token(Token = "0x20007DF")]
		public delegate void ButtonAction();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E2E")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E2F")]
		[SerializeField]
		private BaseButton _btnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E30")]
		[SerializeField]
		private BaseButton _btnRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E31")]
		[SerializeField]
		private BaseButton _btnRemoveAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E32")]
		[SerializeField]
		private BaseButton _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E33")]
		[SerializeField]
		private BaseButton _btnRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002E34")]
		[SerializeField]
		private TextBase _fence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002E35")]
		[SerializeField]
		private RectTransform _fenceIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002E36")]
		[SerializeField]
		private RectTransform _fenceIndicatorHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002E37")]
		[SerializeField]
		private GameObject _fenceShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002E38")]
		[SerializeField]
		private BaseButton _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002E39")]
		[SerializeField]
		private bool _isInEditmode = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002E3A")]
		[SerializeField]
		private Sprite _confirmEnableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002E3B")]
		[SerializeField]
		private Sprite _confirmDisableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E3C")]
		[SerializeField]
		private Sprite _removeEnableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002E3D")]
		[SerializeField]
		private Sprite _removeDisableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002E3E")]
		[SerializeField]
		private Sprite _trashEnableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002E3F")]
		[SerializeField]
		private Sprite _trashDisableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002E40")]
		[SerializeField]
		private Sprite _rotateEnableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002E41")]
		[SerializeField]
		private Sprite _rotateDisableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002E42")]
		[SerializeField]
		private Sprite _addEnableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002E43")]
		[SerializeField]
		private Sprite _addDisableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002E44")]
		private GridEditMode _gridEditMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002E45")]
		public ButtonAction AddButtonHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002E46")]
		public ButtonAction RemoveButtonHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002E47")]
		public ButtonAction RemoveAllButtonHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002E48")]
		public ButtonAction CancelButtonHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002E49")]
		public ButtonAction ConfirmButtonHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002E4A")]
		public ButtonAction RotateButtonHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002E4B")]
		public Func<bool> IsAddActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002E4C")]
		public Func<bool> IsRemoveActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002E4D")]
		public Func<bool> IsCancelActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002E4E")]
		public Func<bool> IsConfirmActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002E4F")]
		public Func<bool> IsRotateActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002E50")]
		[SerializeField]
		private GameObject _targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002E51")]
		private bool _moveToInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002E52")]
		[SerializeField]
		private RectTransform _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002E53")]
		[SerializeField]
		private RectTransform _mcAnimated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002E54")]
		private Vector3 _targetObjectPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002E55")]
		public AK.Wwise.Event sfxMoveEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002E56")]
		public AK.Wwise.Event sfxSelectEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002E57")]
		protected MenuLayoutTemplate _oldLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002E58")]
		[SerializeField]
		private List<MenuLayoutTemplate> LayoutTemplates = (List<MenuLayoutTemplate>)(object)new List<T>
		{
			(T)new MenuLayoutTemplate
			{
				Platform = RuntimePlatform.WindowsPlayer,
				IsLandscape = true,
				CanvasScaleFactor = 0.25f
			},
			(T)new MenuLayoutTemplate
			{
				Platform = RuntimePlatform.WindowsEditor,
				IsLandscape = true,
				CanvasScaleFactor = 0.25f
			}
		};

		[Cpp2IlInjected.Token(Token = "0x1700070B")]
		public bool IsInEditMode
		{
			[Cpp2IlInjected.Token(Token = "0x6003217")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return _isInEditmode;
			}
			[Cpp2IlInjected.Token(Token = "0x6003218")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set
			{
				_isInEditmode = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070C")]
		public bool IsInFenceMode
		{
			[Cpp2IlInjected.Token(Token = "0x6003219")]
			[Cpp2IlInjected.Address(RVA = "0xE168C0", Offset = "0xE152C0", VA = "0x180E168C0")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_0010: Expected O, but got I4
				GridEditMode gridEditMode = _gridEditMode;
				int num = 0;
				bool flag = gridEditMode != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				return _gridEditMode.IsInFenceMode();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070D")]
		public BaseButton RemoveButton
		{
			[Cpp2IlInjected.Token(Token = "0x600321A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _btnRemove;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070E")]
		public BaseButton RemoveAllButton
		{
			[Cpp2IlInjected.Token(Token = "0x600321B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _btnRemoveAll;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070F")]
		public BaseButton CancelButton
		{
			[Cpp2IlInjected.Token(Token = "0x600321C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _btnCancel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000710")]
		public BaseButton ConfirmButton
		{
			[Cpp2IlInjected.Token(Token = "0x600321D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _btnConfirm;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000711")]
		public BaseButton RotateButton
		{
			[Cpp2IlInjected.Token(Token = "0x600321E")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _btnRotate;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000712")]
		public BaseButton AddButton
		{
			[Cpp2IlInjected.Token(Token = "0x600321F")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _btnAdd;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000713")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003220")]
			[Cpp2IlInjected.Address(RVA = "0xD227E0", Offset = "0xD211E0", VA = "0x180D227E0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000714")]
		public List<MenuLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x6003221")]
			[Cpp2IlInjected.Address(RVA = "0x739220", Offset = "0x737C20", VA = "0x180739220", Slot = "5")]
			get
			{
				return LayoutTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000715")]
		public object ClickHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6003222")]
			[Cpp2IlInjected.Address(RVA = "0x739280", Offset = "0x737C80", VA = "0x180739280")]
			[CompilerGenerated]
			get
			{
				return _003CClickHandler_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003223")]
			[Cpp2IlInjected.Address(RVA = "0x73A360", Offset = "0x738D60", VA = "0x18073A360")]
			[CompilerGenerated]
			private set
			{
				_003CClickHandler_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003224")]
		[Cpp2IlInjected.Address(RVA = "0xE15BA0", Offset = "0xE145A0", VA = "0x180E15BA0")]
		public void Show()
		{
			//Discarded unreachable code: IL_0043
			base.gameObject.SetActive(value: true);
			_btnConfirm.OnHighlightExit();
			Update();
			RectTransform mcAnimated = _mcAnimated;
			float z = Vector3.zero.z;
			RectTransform mcAnimated2 = _mcAnimated;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x6003225")]
		[Cpp2IlInjected.Address(RVA = "0xE15360", Offset = "0xE13D60", VA = "0x180E15360")]
		public unsafe void Init(GameObject target)
		{
			//Discarded unreachable code: IL_0040
			//IL_0028: Expected native int or pointer, but got O
			_targetObject = target;
			Transform transform = _targetObject.transform;
			AK.Wwise.Event @event = sfxSelectEvent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_targetObjectPos)->z = z;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003226")]
		[Cpp2IlInjected.Address(RVA = "0xE15CB0", Offset = "0xE146B0", VA = "0x180E15CB0")]
		private void Start()
		{
			//Discarded unreachable code: IL_012a
			MenuLayoutTemplate oldLayout = _oldLayout;
			MenuLayoutTemplate currentLayout = GetCurrentLayout();
			if (oldLayout != currentLayout)
			{
				OnLayoutChange();
			}
			Button.ButtonClickedEvent onClick = _btnAdd.ButtonComponent.m_OnClick;
			UnityAction call = OnAddTargetClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnConfirm.ButtonComponent.m_OnClick;
			UnityAction call2 = OnConfirmTargetClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnRemove.ButtonComponent.m_OnClick;
			UnityAction call3 = OnRemoveTargetClickHandler;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnRemoveAll.ButtonComponent.m_OnClick;
			UnityAction call4 = OnRemoveAllClickHandler;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnCancel.ButtonComponent.m_OnClick;
			UnityAction call5 = OnCancelTargetClickHandler;
			onClick5.AddListener(call5);
			Button.ButtonClickedEvent onClick6 = _btnRotate.ButtonComponent.m_OnClick;
			UnityAction call6 = OnRotateTargetClickHandler;
			onClick6.AddListener(call6);
			_background.SetAsFirstSibling();
			int num = 0;
			IMenu top = UiRoot.Instance._menuStack.Top;
		}

		[Cpp2IlInjected.Token(Token = "0x6003227")]
		[Cpp2IlInjected.Address(RVA = "0xE15670", Offset = "0xE14070", VA = "0x180E15670")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_012e
			//IL_00f9: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0111: Expected O, but got I4
			//IL_0119: Expected O, but got I4
			Button.ButtonClickedEvent onClick = _btnAdd.ButtonComponent.m_OnClick;
			UnityAction call = OnAddTargetClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnConfirm.ButtonComponent.m_OnClick;
			UnityAction call2 = OnConfirmTargetClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnRemove.ButtonComponent.m_OnClick;
			UnityAction call3 = OnRemoveTargetClickHandler;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnRemoveAll.ButtonComponent.m_OnClick;
			UnityAction call4 = OnRemoveAllClickHandler;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnCancel.ButtonComponent.m_OnClick;
			UnityAction call5 = OnCancelTargetClickHandler;
			onClick5.RemoveListener(call5);
			Button.ButtonClickedEvent onClick6 = _btnRotate.ButtonComponent.m_OnClick;
			UnityAction call6 = OnRotateTargetClickHandler;
			onClick6.RemoveListener(call6);
			int num = 0;
			AddButtonHandler = (ButtonAction)num;
			RemoveButtonHandler = (ButtonAction)num;
			CancelButtonHandler = (ButtonAction)num;
			ConfirmButtonHandler = (ButtonAction)num;
			RotateButtonHandler = (ButtonAction)num;
			int num2 = 0;
			IMenu top = UiRoot.Instance._menuStack.Top;
		}

		[Cpp2IlInjected.Token(Token = "0x6003228")]
		[Cpp2IlInjected.Address(RVA = "0xE15B70", Offset = "0xE14570", VA = "0x180E15B70")]
		private void OnRotateTargetClickHandler()
		{
			RotateButtonHandler?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003229")]
		[Cpp2IlInjected.Address(RVA = "0xE15B50", Offset = "0xE14550", VA = "0x180E15B50")]
		private void OnRemoveTargetClickHandler()
		{
			RemoveButtonHandler?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600322A")]
		[Cpp2IlInjected.Address(RVA = "0xE15B30", Offset = "0xE14530", VA = "0x180E15B30")]
		private void OnRemoveAllClickHandler()
		{
			RemoveAllButtonHandler?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600322B")]
		[Cpp2IlInjected.Address(RVA = "0xE15630", Offset = "0xE14030", VA = "0x180E15630")]
		private void OnCancelTargetClickHandler()
		{
			CancelButtonHandler?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600322C")]
		[Cpp2IlInjected.Address(RVA = "0xE15650", Offset = "0xE14050", VA = "0x180E15650")]
		private void OnConfirmTargetClickHandler()
		{
			ConfirmButtonHandler?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600322D")]
		[Cpp2IlInjected.Address(RVA = "0x952590", Offset = "0x950F90", VA = "0x180952590")]
		private void OnAddTargetClickHandler()
		{
			AddButtonHandler?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600322E")]
		[Cpp2IlInjected.Address(RVA = "0xE15FC0", Offset = "0xE149C0", VA = "0x180E15FC0")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_02ca
			//IL_001c: Expected O, but got I4
			//IL_0059: Expected native int or pointer, but got O
			//IL_008b: Expected I4, but got O
			//IL_00ae: Expected I4, but got O
			//IL_00d1: Expected I4, but got O
			//IL_010a: Expected I4, but got O
			//IL_0138: Expected I4, but got O
			//IL_0157: Expected O, but got I4
			//IL_01a8: Expected O, but got I4
			//IL_0232: Expected I4, but got I8
			//IL_026b: Expected O, but got I4
			if (!base.isActiveAndEnabled)
			{
				return;
			}
			GameObject targetObject = _targetObject;
			int num = 0;
			if (targetObject == (UnityEngine.Object)num)
			{
				return;
			}
			Transform transform = _targetObject.transform;
			bool flag = default(bool);
			if (flag)
			{
				Transform transform2 = _targetObject.transform;
				AK.Wwise.Event @event = sfxMoveEvent;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)_targetObjectPos)->z = z;
				GameObject gameObject = base.gameObject;
				uint num2 = @event.Post(gameObject);
			}
			Button buttonComponent = _btnConfirm.ButtonComponent;
			bool interactable = (byte)(int)IsConfirmActive() != 0;
			buttonComponent.interactable = interactable;
			Button buttonComponent2 = _btnRotate.ButtonComponent;
			bool interactable2 = (byte)(int)IsRotateActive() != 0;
			buttonComponent2.interactable = interactable2;
			Button buttonComponent3 = _btnRemove.ButtonComponent;
			bool interactable3 = (byte)(int)IsRemoveActive() != 0;
			buttonComponent3.interactable = interactable3;
			Button buttonComponent4 = _btnRemove.ButtonComponent;
			Button buttonComponent5 = _btnCancel.ButtonComponent;
			Func<bool> isCancelActive = IsCancelActive;
			if (isCancelActive == null)
			{
			}
			bool interactable4 = (byte)(int)isCancelActive() != 0;
			buttonComponent5.interactable = interactable4;
			if ((long)IsAddActive != 0)
			{
				Button buttonComponent6 = _btnAdd.ButtonComponent;
				bool interactable5 = (byte)(int)IsAddActive() != 0;
				buttonComponent6.interactable = interactable5;
			}
			int num3 = 0;
			Camera main = Camera.main;
			int num4 = 0;
			int childMaxDecimals = default(int);
			float num11 = default(float);
			if (main != (UnityEngine.Object)num4)
			{
				Collider component = _targetObject.GetComponent<Collider>();
				int num5 = 0;
				Camera main2 = Camera.main;
				int num6 = 0;
				Camera main3 = Camera.main;
				int num7 = 0;
				Camera main4 = Camera.main;
				Transform transform3 = _targetObject.transform;
				childMaxDecimals = 0;
				int num8 = 0;
				base.transform.position = (Vector3)num8;
				float a = default(float);
				float num9 = Mathf.Min(a, 450f);
				RectTransform component2 = GetComponent<RectTransform>();
				float num10 = Mathf.Max(num9, 350f);
				num10 = num9;
				num11 = Mathf.Max(num10, 350f);
			}
			GameObject gameObject2 = _fenceIndicatorHolder.gameObject;
			bool isInFenceMode = IsInFenceMode;
			int maxDecimals = 0;
			gameObject2.SetActive(isInFenceMode);
			if (IsInFenceMode)
			{
				GridEditMode gridEditMode = _gridEditMode;
				TextBase fence = _fence;
				int remainingAmountOfSelectedFences = gridEditMode.GetRemainingAmountOfSelectedFences();
				ulong num12 = default(ulong);
				string text2 = (fence.Text = TextUtilities.FormatNumber(num11, 4, maxDecimals, childMaxDecimals, (byte)num12 != 0));
				int num13 = 0;
				UiRoot instance = UiRoot.Instance;
				int num14 = 0;
				bool flag2 = instance.IsControllerConnected((byte)num14 != 0);
				RectTransform fenceIndicator = _fenceIndicator;
				if (!flag2)
				{
					fenceIndicator.anchoredPosition = (Vector2)num14;
					GameObject gameObject3 = _fenceShortcutIndicator.gameObject;
					int active = 0;
					gameObject3.SetActive((byte)active != 0);
				}
				_fenceShortcutIndicator.gameObject.SetActive(value: true);
				RectTransform fenceIndicatorHolder = _fenceIndicatorHolder;
			}
			GameObject gameObject4 = _btnRemoveAll.gameObject;
			if (!IsInFenceMode)
			{
			}
			bool canRemoveWholeFence = _gridEditMode.CanRemoveWholeFence;
			gameObject4.SetActive(canRemoveWholeFence);
		}

		[Cpp2IlInjected.Token(Token = "0x600322F")]
		[Cpp2IlInjected.Address(RVA = "0xE14C50", Offset = "0xE13650", VA = "0x180E14C50")]
		internal void InitWithSystem(GridObjectGizmoSystem gridObjectGizmoSystem)
		{
			//Discarded unreachable code: IL_0280
			//IL_0033: Expected O, but got I4
			//IL_0205: Expected I4, but got O
			//IL_0241: Expected I4, but got O
			//IL_025c: Expected I4, but got I8
			//IL_0276: Expected I4, but got O
			GridObjectGizmoSystem gridObjectGizmoSystem2 = gridObjectGizmoSystem;
			if ((object)gridObjectGizmoSystem2 == null)
			{
			}
			int num = 0;
			_gridEditMode = (GridEditMode)gridObjectGizmoSystem2;
			GridEditMode gridEditMode = _gridEditMode;
			int num2 = 0;
			bool isInEditmode = gridEditMode != (UnityEngine.Object)num2;
			ButtonAction removeButtonHandler = RemoveButtonHandler;
			_isInEditmode = isInEditmode;
			ButtonAction b = gridObjectGizmoSystem.RemoveSelectedObject;
			Delegate @delegate = Delegate.Combine(removeButtonHandler, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				RemoveButtonHandler = (ButtonAction)@delegate;
				if (_isInEditmode)
				{
					ButtonAction removeAllButtonHandler = RemoveAllButtonHandler;
					ButtonAction b2 = _gridEditMode.RemoveWholeFence;
					Delegate delegate2 = Delegate.Combine(removeAllButtonHandler, b2);
					if ((object)delegate2 != null && (object)delegate2 == null)
					{
						goto IL_0286;
					}
					RemoveAllButtonHandler = (ButtonAction)delegate2;
				}
				ButtonAction addButtonHandler = AddButtonHandler;
				ButtonAction b3 = gridObjectGizmoSystem.DuplicateSelectedObject;
				Delegate delegate3 = Delegate.Combine(addButtonHandler, b3);
				if ((object)delegate3 == null || (object)delegate3 != null)
				{
					AddButtonHandler = (ButtonAction)delegate3;
					ButtonAction rotateButtonHandler = RotateButtonHandler;
					ButtonAction b4 = delegate
					{
						//Discarded unreachable code: IL_000d
						gridObjectGizmoSystem.RotateSelectedObject(clockwise: true);
					};
					Delegate delegate4 = Delegate.Combine(rotateButtonHandler, b4);
					if ((object)delegate4 == null || (object)delegate4 != null)
					{
						RotateButtonHandler = (ButtonAction)delegate4;
						ButtonAction confirmButtonHandler = ConfirmButtonHandler;
						ButtonAction b5 = gridObjectGizmoSystem.DeselectSelectedObject;
						Delegate delegate5 = Delegate.Combine(confirmButtonHandler, b5);
						if ((object)delegate5 == null || (object)delegate5 != null)
						{
							ConfirmButtonHandler = (ButtonAction)delegate5;
							Func<bool> func = (IsConfirmActive = (Func<bool>)(object)(Func<TResult>)(() => gridObjectGizmoSystem.UseEditGrid));
							Func<bool> isAddActive = default(Func<bool>);
							if (_003C_003Ec._003C_003E9__80_2 == null)
							{
								isAddActive = (Func<bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<TResult>)delegate
								{
									int num4 = 0;
									/*Error: Unexpected end of block*/;
								});
							}
							IsAddActive = isAddActive;
							Func<bool> func2 = (IsRotateActive = (Func<bool>)(object)(Func<TResult>)(() => gridObjectGizmoSystem.UseEditGrid));
							Func<bool> func3 = (IsRemoveActive = (Func<bool>)(object)(Func<TResult>)(() => gridObjectGizmoSystem.UseEditGrid));
							BaseButton btnAdd = _btnAdd;
							if ((long)IsAddActive == 0)
							{
								GameObject gameObject = btnAdd.gameObject;
							}
							GameObject gameObject2 = btnAdd.gameObject;
							bool active = (byte)(int)IsAddActive() != 0;
							gameObject2.SetActive(active);
							GameObject gameObject3 = _btnRemoveAll.gameObject;
							int active2 = 0;
							gameObject3.SetActive((byte)active2 != 0);
							GameObject gameObject4 = _btnRemove.gameObject;
							bool active3 = (byte)(int)IsRemoveActive() != 0;
							gameObject4.SetActive(active3);
							ulong num3 = default(ulong);
							_btnCancel.gameObject.SetActive((byte)num3 != 0);
							GameObject gameObject5 = _btnRotate.gameObject;
							bool active4 = (byte)(int)IsRotateActive() != 0;
							gameObject5.SetActive(active4);
							return;
						}
					}
				}
			}
			goto IL_0286;
			IL_0286:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003230")]
		[Cpp2IlInjected.Address(RVA = "0xE15B90", Offset = "0xE14590", VA = "0x180E15B90")]
		public void RefreshRemoveButton(bool moveToInventory)
		{
			_moveToInventory = moveToInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x6003231")]
		[Cpp2IlInjected.Address(RVA = "0xE159B0", Offset = "0xE143B0", VA = "0x180E159B0")]
		internal void OnLayoutChange()
		{
			//Discarded unreachable code: IL_002f
			//IL_0028: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				MenuLayoutTemplate currentLayout = GetCurrentLayout();
				if (currentLayout != null)
				{
					_oldLayout = currentLayout;
					List<GameObjectTemplate> templates = (List<GameObjectTemplate>)(object)currentLayout.GetTemplates();
					if (flag)
					{
						int num = 0;
						if (this != (UnityEngine.Object)num)
						{
							int num2 = 0;
							break;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003232")]
		[Cpp2IlInjected.Address(RVA = "0xE14B60", Offset = "0xE13560", VA = "0x180E14B60")]
		internal MenuLayoutTemplate GetCurrentLayout()
		{
			//Discarded unreachable code: IL_0033
			int num = 0;
			RuntimePlatform runtimePlatform = PlatformUtils.GetRuntimePlatform();
			List<MenuLayoutTemplate> layoutTemplates = LayoutTemplates;
			Predicate<MenuLayoutTemplate> predicate = (Predicate<MenuLayoutTemplate>)(object)(Predicate<T>)delegate(MenuLayoutTemplate x)
			{
				//Discarded unreachable code: IL_0029
				int num2 = 0;
				if (!CanvasHelper.InstanceMain.IsLandscape)
				{
				}
				RuntimePlatform runtimePlatform2 = runtimePlatform;
				return x.IsLandscape = x.Platform == runtimePlatform2;
			};
			return (MenuLayoutTemplate)((List<T>)(object)layoutTemplates).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6003233")]
		[Cpp2IlInjected.Address(RVA = "0xE154E0", Offset = "0xE13EE0", VA = "0x180E154E0")]
		private void InputActionPosition_Confirm_OnTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			if (IsConfirmActive() != null)
			{
				ConfirmButtonHandler?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003234")]
		[Cpp2IlInjected.Address(RVA = "0xE15470", Offset = "0xE13E70", VA = "0x180E15470")]
		private void InputActionPosition_Cancel_OnTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			if (IsCancelActive() != null)
			{
				CancelButtonHandler?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003235")]
		[Cpp2IlInjected.Address(RVA = "0xE155C0", Offset = "0xE13FC0", VA = "0x180E155C0")]
		private void InputActionPosition_Rotate_OnTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			if (IsRotateActive() != null)
			{
				RotateButtonHandler?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003236")]
		[Cpp2IlInjected.Address(RVA = "0xE15400", Offset = "0xE13E00", VA = "0x180E15400")]
		private void InputActionPosition_Add_OnTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			if (IsAddActive() != null)
			{
				AddButtonHandler?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003237")]
		[Cpp2IlInjected.Address(RVA = "0xE15550", Offset = "0xE13F50", VA = "0x180E15550")]
		private void InputActionPosition_Remove_OnTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			if (IsRemoveActive() != null)
			{
				RemoveButtonHandler?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003238")]
		[Cpp2IlInjected.Address(RVA = "0xE16780", Offset = "0xE15180", VA = "0x180E16780")]
		public PositionHandler()
		{
		}//Discarded unreachable code: IL_006b
		//IL_001c: Expected I4, but got I8
		//IL_0044: Expected I4, but got I8

	}
}
