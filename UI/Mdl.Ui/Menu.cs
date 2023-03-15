using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Tracking;
using Meta.Util;
using NaughtyAttributes;
using Rewired;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200022D")]
	public class Menu : MonoBehaviour, IMenu, IHasAsssetGUID, IHasLayout, IHasShortcutIndicators, IHasSFX
	{
		[Cpp2IlInjected.Token(Token = "0x200022E")]
		public class ControllerChange : UnityEvent<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000DFA")]
			[Cpp2IlInjected.Address(RVA = "0xAFC8C0", Offset = "0xAFB2C0", VA = "0x180AFC8C0")]
			public ControllerChange()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40009B9")]
		protected MenuLayoutTemplate _oldLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40009BB")]
		[SerializeField]
		[FormerlySerializedAs("_canvasScalerMatchScreenWidth")]
		[Header("Canvas Scaler")]
		private bool _useCanvasScalerMatchWidthOrHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40009BC")]
		private DropdownList<float> _matchWidthOrHeightValues = (DropdownList<float>)(object)new DropdownList<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40009BD")]
		[SerializeField]
		[Dropdown("_matchWidthOrHeightValues")]
		[ShowIf("_useCanvasScalerMatchWidthOrHeight")]
		private float _matchWidthOrHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40009BF")]
		[SerializeField]
		[NonReorderable]
		[Header("Shortcuts and layouts")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40009C0")]
		[NonReorderable]
		[SerializeField]
		private List<ShortcutIndicatorSetTemplate> GamepadKeySetTemplates = (List<ShortcutIndicatorSetTemplate>)(object)new List<T>
		{
			(T)new ShortcutIndicatorSetTemplate
			{
				GamepadType = ControlType.None,
				Platform = RuntimePlatform.WindowsEditor
			},
			(T)new ShortcutIndicatorSetTemplate
			{
				GamepadType = ControlType.Xbox360,
				Platform = RuntimePlatform.WindowsPlayer
			}
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40009C1")]
		[Space]
		[Header("Audio")]
		[Space(15f)]
		public AK.Wwise.Event[] SFXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40009C3")]
		[Space]
		public AK.Wwise.Event _sfxEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40009C4")]
		public AK.Wwise.Event closeSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40009C5")]
		protected PlayerNavigation.TemporaryOverrideScope _overrideAllScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40009C6")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40009C8")]
		private MenuNavigation _menuNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40009C9")]
		[Header("Other")]
		public bool LockAvatarControl = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40009CA")]
		public bool UseSafeAre;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x40009CB")]
		public bool UseKeyboardShortcutIndicators;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x40009CC")]
		public bool ForceLoadKeyboardShortcutIndicators = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40009CD")]
		public bool KeepVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x40009CE")]
		public bool _isGamepadHoldAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x40009CF")]
		public bool ShouldHideWorldUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40009D0")]
		protected MenuParam _menuParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40009D1")]
		protected bool _isFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40009D2")]
		protected bool _isInFocusOutAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40009D3")]
		protected MenuStack _stack;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40009D4")]
		private bool _isWorldUIVisibleBeforeFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40009D5")]
		public ControllerChange OnControllerChange = new ControllerChange();

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		internal IMenu NextMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CNextMenu_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DC5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CNextMenu_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		internal IMenu PrevMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CPrevMenu_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DC7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CPrevMenu_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC8")]
			[Cpp2IlInjected.Address(RVA = "0xD227E0", Offset = "0xD211E0", VA = "0x180D227E0", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		public List<MenuLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC9")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "17")]
			get
			{
				return LayoutTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40009BA")]
		public bool IsStaticMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000DCA")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000DCB")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		public bool UseCanvasScalerMatchWidthOrHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DCC")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90", Slot = "6")]
			get
			{
				return _useCanvasScalerMatchWidthOrHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		public float CanvasScalerMatchWidthOrHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DCD")]
			[Cpp2IlInjected.Address(RVA = "0x823CC0", Offset = "0x8226C0", VA = "0x180823CC0", Slot = "7")]
			get
			{
				return _matchWidthOrHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		public string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000DCE")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return _003CAssetGUID_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DCF")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60", Slot = "15")]
			[CompilerGenerated]
			set
			{
				_003CAssetGUID_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		public List<ShortcutIndicatorSetTemplate> ShortcutIndicatorSets
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD0")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "19")]
			get
			{
				return GamepadKeySetTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x40009C2")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD1")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0", Slot = "21")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000DD2")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200", Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD3")]
			[Cpp2IlInjected.Address(RVA = "0x1195AD0", Offset = "0x11944D0", VA = "0x181195AD0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x40009C7")]
		public bool IsDataUpToDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD4")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEA0", Offset = "0x7D98A0", VA = "0x1807DAEA0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000DD5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB470", Offset = "0x7D9E70", VA = "0x1807DB470")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		public bool IsFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD6")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30")]
			get
			{
				return _isFocused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		public bool IsInFocusOutAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD7")]
			[Cpp2IlInjected.Address(RVA = "0x1195B50", Offset = "0x1194550", VA = "0x181195B50")]
			get
			{
				return _isInFocusOutAnimation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		public bool IsInMenuStack
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD8")]
			[Cpp2IlInjected.Address(RVA = "0x1195B60", Offset = "0x1194560", VA = "0x181195B60")]
			get
			{
				//Discarded unreachable code: IL_001c
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				MenuStack stack = _stack;
				return instance._menuStack == stack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		public bool IsInPopUpStack
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD9")]
			[Cpp2IlInjected.Address(RVA = "0x1195BE0", Offset = "0x11945E0", VA = "0x181195BE0")]
			get
			{
				//Discarded unreachable code: IL_001c
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				MenuStack stack = _stack;
				return instance._popupStack == stack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		public bool IsInSystemPromptStack
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDA")]
			[Cpp2IlInjected.Address(RVA = "0x1195C60", Offset = "0x1194660", VA = "0x181195C60")]
			get
			{
				//Discarded unreachable code: IL_001c
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				MenuStack stack = _stack;
				return instance._systemPromptStack == stack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		public MenuNavigation MenuNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDB")]
			[Cpp2IlInjected.Address(RVA = "0x1195CE0", Offset = "0x11946E0", VA = "0x181195CE0")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				return _menuNavigation = GetComponent<MenuNavigation>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		public FocusNavigation FocusNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDC")]
			[Cpp2IlInjected.Address(RVA = "0x1195B00", Offset = "0x1194500", VA = "0x181195B00")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MenuNavigation.FocusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		public bool IsGamepadHoldAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDD")]
			[Cpp2IlInjected.Address(RVA = "0x1195B40", Offset = "0x1194540", VA = "0x181195B40")]
			get
			{
				return _isGamepadHoldAllowed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		private bool ShouldNotDisable
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDE")]
			[Cpp2IlInjected.Address(RVA = "0x1195DA0", Offset = "0x11947A0", VA = "0x181195DA0")]
			get
			{
				if ((object)this == null)
				{
					return 0 != 0;
				}
				int num = 0;
				return (object)this != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDF")]
		[Cpp2IlInjected.Address(RVA = "0x11942A0", Offset = "0x1192CA0", VA = "0x1811942A0", Slot = "24")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_001e
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				this.cancellationTokenSource.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE0")]
		[Cpp2IlInjected.Address(RVA = "0x1193740", Offset = "0x1192140", VA = "0x181193740", Slot = "8")]
		public Task<Menu> Instantiate(Transform parent)
		{
			//Discarded unreachable code: IL_006a
			Menu menu = UnityEngine.Object.Instantiate(this, parent);
			Transform transform = menu.transform;
			float z = Vector3.zero.z;
			Transform transform2 = menu.transform;
			float z2 = Vector3.one.z;
			RectTransform component = menu.GetComponent<RectTransform>();
			int num = 0;
			Vector2 vector = (component.anchoredPosition = Vector2.zero);
			RectTransform component2 = menu.GetComponent<RectTransform>();
			int num2 = 0;
			Vector2 vector2 = (component2.sizeDelta = Vector2.zero);
			return (Task<Menu>)(object)Task.FromResult(menu);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE1")]
		[Cpp2IlInjected.Address(RVA = "0x1194D50", Offset = "0x1193750", VA = "0x181194D50", Slot = "25")]
		public virtual void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0092
			//IL_0064: Expected O, but got I4
			if (SystemRoot.ErrorReporter != null)
			{
				string text = base.gameObject.name + " Push";
			}
			_stack = stack;
			AK.Wwise.Event sfxEvent = _sfxEvent;
			GameObject gameObject = base.gameObject;
			uint num = sfxEvent.Post(gameObject);
			RegisterBaseListeners();
			_menuParam = param;
			bool flag = CheckAndStartControlOverride();
			MenuNavigation menuNavigation = MenuNavigation;
			int num2 = 0;
			if (menuNavigation != (UnityEngine.Object)num2)
			{
				MenuNavigation.RegisterEventListeners();
			}
			if (base.gameObject.name == null)
			{
			}
			RaiseUIEvent("Open", "", param);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE2")]
		[Cpp2IlInjected.Address(RVA = "0x1194B20", Offset = "0x1193520", VA = "0x181194B20", Slot = "26")]
		public virtual void OnPop()
		{
			//Discarded unreachable code: IL_00b8
			//IL_0021: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			string text = base.gameObject.name;
			if (text == null)
			{
			}
			int num = 0;
			int num2 = 0;
			RaiseUIEvent("Close", text, (MenuParam)num2);
			UnregisterBaseListeners();
			int num3 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num4 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num5 = 0;
				bool flag = default(bool);
				if (top != null && !flag)
				{
					int num6 = 0;
					UiRoot.Instance.UpdateCursorBehaviorForGameplay();
				}
			}
			int num7 = 0;
			_overrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num7;
			IsDataUpToDate = (byte)num7 != 0;
			if ((IsStaticMenu ? 1 : 0) == num7)
			{
				if (!Addressables.ReleaseInstance(base.gameObject))
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			else
			{
				int num8 = 0;
				RecycleBin menuRecycleBin = UiRoot.Instance._menuRecycleBin;
				GameObject trash = base.gameObject;
				menuRecycleBin.SendToBin(trash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE3")]
		[Cpp2IlInjected.Address(RVA = "0x11951B0", Offset = "0x1193BB0", VA = "0x1811951B0")]
		public void RaiseUIEvent(string uiAction, string uiName, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0016
			if (TrackingManager.Instance != null)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE4")]
		[Cpp2IlInjected.Address(RVA = "0x11942E0", Offset = "0x1192CE0", VA = "0x1811942E0", Slot = "27")]
		public virtual void OnFocusIn()
		{
			//Discarded unreachable code: IL_0178
			//IL_00ab: Expected O, but got I4
			if (!_isFocused)
			{
				if (SystemRoot.ErrorReporter != null)
				{
					string text = base.gameObject.name + " FocusIn";
				}
				MenuLayoutTemplate oldLayout = _oldLayout;
				MenuLayoutTemplate currentLayout = GetCurrentLayout();
				if (oldLayout == currentLayout)
				{
					MenuLayoutTemplate oldLayout2 = _oldLayout;
					LoadRewiredMapCategory(oldLayout2);
				}
				OnLayoutChange();
				MenuStack stack = _stack;
				int num = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				if (stack == menuStack)
				{
					int num2 = 0;
					UiRoot instance = UiRoot.Instance;
					bool useSafeAre = UseSafeAre;
					instance.ApplySafeAreaToMenuStack(useSafeAre);
				}
				if (_isInFocusOutAnimation)
				{
					CancellationTokenProvider component = GetComponent<CancellationTokenProvider>();
					int num3 = 0;
					if (component != (UnityEngine.Object)num3)
					{
						component.ForceCancelAndRenew();
						_isInFocusOutAnimation = false;
					}
				}
				int num4 = 0;
				bool flag = (_isWorldUIVisibleBeforeFocus = UiRoot.Instance._worldCanvas.gameObject.activeSelf);
				if (ShouldHideWorldUI && flag)
				{
					int num5 = 0;
					GameObject gameObject = UiRoot.Instance._worldCanvas.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				base.gameObject.SetActive(value: true);
				_isFocused = true;
				RegisterFocusedListeners();
				GetComponent<MenuNavigation>()?.RefreshAll(forcelyUpdate: true);
				_menuParam?.OnFocusInAction?.Invoke();
			}
			else
			{
				string text2 = base.gameObject.name;
				string text3 = "Menustack stack :: try to focus a menu already focused :: " + text2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE5")]
		[Cpp2IlInjected.Address(RVA = "0x1194740", Offset = "0x1193140", VA = "0x181194740", Slot = "28")]
		public virtual void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			UnregisterFocusedListeners();
			if (ShouldHideWorldUI && _isWorldUIVisibleBeforeFocus)
			{
				int num = 0;
				UiRoot.Instance._worldCanvas.gameObject.SetActive(value: true);
			}
			if (!animate)
			{
				_isFocused = animate;
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				if (popAfterFocusOut != animate)
				{
					_menuParam?.OnPopAction?.Invoke();
					OnPop();
				}
				return;
			}
			OnFocusOutAsync().FireAndForgetTask();
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6000DFC")]
			[Cpp2IlInjected.Address(RVA = "0xB0C8E0", Offset = "0xB0B2E0", VA = "0x180B0C8E0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass86_0._003C_003COnFocusOut_003Eg__OnFocusOutAsync_007C0_003Ed))]
			Task OnFocusOutAsync()
			{
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE6")]
		[Cpp2IlInjected.Address(RVA = "0x1195160", Offset = "0x1193B60", VA = "0x181195160", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__87))]
		public virtual IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__87 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__87(_003C_003E1__state);
			_003C_003E1__state = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "30")]
		protected virtual void RegisterBaseListeners()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "31")]
		protected virtual void UnregisterBaseListeners()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "32")]
		protected virtual void RegisterFocusedListeners()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEA")]
		[Cpp2IlInjected.Address(RVA = "0x1195770", Offset = "0x1194170", VA = "0x181195770", Slot = "33")]
		protected virtual void UnregisterFocusedListeners()
		{
			MenuLayoutTemplate oldLayout = _oldLayout;
			RemoveRewiredMapCategory(oldLayout);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEB")]
		[Cpp2IlInjected.Address(RVA = "0x11948E0", Offset = "0x11932E0", VA = "0x1811948E0", Slot = "34")]
		internal virtual void OnLayoutChange()
		{
			//Discarded unreachable code: IL_005e, IL_0064
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			MenuLayoutTemplate currentLayout = GetCurrentLayout();
			if (currentLayout != null)
			{
				MenuLayoutTemplate oldLayout = _oldLayout;
				RemoveRewiredMapCategory(oldLayout);
				_oldLayout = currentLayout;
				List<GameObjectTemplate> list = (List<GameObjectTemplate>)(object)new List<T>();
				List<GameObjectTemplate> gameObjectTemplates = currentLayout.GameObjectTemplates;
				((List<T>)(object)list).AddRange((IEnumerable<>)gameObjectTemplates);
				bool flag = default(bool);
				if (flag)
				{
					int num4 = 0;
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					int num5 = 0;
				}
			}
			int num6 = 0;
			UiRoot.Instance.SetCursor();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEC")]
		[Cpp2IlInjected.Address(RVA = "0x1195370", Offset = "0x1193D70", VA = "0x181195370")]
		private void RemoveRewiredMapCategory(MenuLayoutTemplate menuLayoutTemplate)
		{
			//Discarded unreachable code: IL_0068
			//IL_0014: Expected O, but got I4
			if (menuLayoutTemplate != null)
			{
				ShortcutSetDefinition shortcutSet = menuLayoutTemplate.ShortcutSet;
				int num = 0;
				if (shortcutSet != (UnityEngine.Object)num)
				{
					ShortcutSetDefinition shortcutSet2 = menuLayoutTemplate.ShortcutSet;
					int num2 = 0;
					ReInput.PlayerHelper players = ReInput.players;
					int playerId = 0;
					Player player = players.GetPlayer(playerId);
					int num3 = 0;
					InputProvider inputProvider = DefaultInputProvider.Get();
					int[] array = new int[1];
					int num4 = (array[0] = menuLayoutTemplate.ShortcutSet.RewiredMapCategoryId);
					inputProvider.DisableMaps(array);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DED")]
		[Cpp2IlInjected.Address(RVA = "0x1193900", Offset = "0x1192300", VA = "0x181193900")]
		private void LoadRewiredMapCategory(MenuLayoutTemplate menuLayoutTemplate)
		{
			//Discarded unreachable code: IL_0068
			//IL_0014: Expected O, but got I4
			if (menuLayoutTemplate != null)
			{
				ShortcutSetDefinition shortcutSet = menuLayoutTemplate.ShortcutSet;
				int num = 0;
				if (shortcutSet != (UnityEngine.Object)num)
				{
					ShortcutSetDefinition shortcutSet2 = menuLayoutTemplate.ShortcutSet;
					int num2 = 0;
					ReInput.PlayerHelper players = ReInput.players;
					int playerId = 0;
					Player player = players.GetPlayer(playerId);
					int num3 = 0;
					InputProvider inputProvider = DefaultInputProvider.Get();
					int[] array = new int[1];
					int num4 = (array[0] = menuLayoutTemplate.ShortcutSet.RewiredMapCategoryId);
					inputProvider.EnableMaps(array);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEE")]
		[Cpp2IlInjected.Address(RVA = "0x1193A50", Offset = "0x1192450", VA = "0x181193A50", Slot = "35")]
		internal unsafe virtual void OnControllerChanged()
		{
			//Discarded unreachable code: IL_02c0, IL_02c6, IL_02cc, IL_02d2, IL_02d8, IL_02de, IL_02e4, IL_02ea, IL_02f0, IL_02f6, IL_02fc, IL_0302, IL_0308, IL_030e, IL_0314, IL_031a, IL_0320, IL_0326, IL_032c, IL_0332, IL_0338, IL_033e, IL_0344, IL_034a, IL_0350, IL_0356, IL_035c, IL_0362, IL_0368, IL_036e, IL_0374, IL_037a, IL_0380, IL_0386
			//IL_001b: Expected I4, but got I8
			//IL_0055: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_027e: Expected O, but got I4
			//IL_0296: Expected O, but got I4
			ulong num5 = default(ulong);
			bool flag = default(bool);
			List<ShortcutIndicatorTemplate> defaultShortcutIndicatorTemplates = default(List<ShortcutIndicatorTemplate>);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			MenuNavigation menuNavigation = default(MenuNavigation);
			MenuNavigation menuNavigation2 = default(MenuNavigation);
			MenuNavigation menuNavigation3 = default(MenuNavigation);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int index;
				ControlType controlType = (ControlType)(index = (int)UiRoot.Instance.GetCurrentController((byte)num5 != 0));
				ShortcutIndicatorSetTemplate currentShortcutIndicatorSet = GetCurrentShortcutIndicatorSet();
				List<ShortcutIndicatorTemplate> indicatorTemplates = (List<ShortcutIndicatorTemplate>)(object)currentShortcutIndicatorSet.GetIndicatorTemplates();
				if (flag)
				{
					ShortcutIndicatorTemplate childTemplate = (ShortcutIndicatorTemplate)0;
					ShortcutIndicator target = childTemplate.Target;
					int num6 = 0;
					if (!(target != (UnityEngine.Object)num6))
					{
						continue;
					}
					ShortcutIndicatorTemplate shortcutIndicatorTemplate = childTemplate;
					ShortcutIndicator target2 = shortcutIndicatorTemplate.Target;
					if (target2.RewiredActionIdPC != -1 || target2.RewiredActionIdGP != -1)
					{
						continue;
					}
					ShortcutDefinition shortcutDefinition = shortcutIndicatorTemplate.ShortcutDefinition;
					int num7 = 0;
					if (shortcutDefinition != (UnityEngine.Object)num7 && childTemplate.ShortcutDefinition.Self.IndicatorVisualType != 0 && currentShortcutIndicatorSet.GamepadType != 0)
					{
						ShortcutIndicatorTemplate shortcutIndicatorTemplate2 = childTemplate;
						if (shortcutIndicatorTemplate2.ShortcutDefinition.ControlType == ControlType.Keyboard)
						{
							GameObject gameObject = shortcutIndicatorTemplate2.Target.gameObject;
							int active = 0;
							gameObject.SetActive((byte)active != 0);
						}
						ShortcutIndicatorTemplate shortcutIndicatorTemplate3 = childTemplate;
						GameObjectTemplate gameObjectTemplate = shortcutIndicatorTemplate3.GameObjectTemplate;
						GameObject gameObject2 = shortcutIndicatorTemplate3.Target.gameObject;
						int ignoreParent = 0;
						gameObjectTemplate.Load(gameObject2, (byte)ignoreParent != 0);
						childTemplate.Target.TransformToPreset();
					}
					List<ShortcutIndicator.VisualType> templateOverride = childTemplate.Target.TemplateOverride;
					int num8 = index;
					_003C_003Ec__DisplayClass95_0 _003C_003Ec__DisplayClass95_;
					if (_003C_003Ec__DisplayClass95_ != null)
					{
						int num9 = 0;
						if (Application.isPlaying)
						{
							int num10 = 0;
							defaultShortcutIndicatorTemplates = (List<ShortcutIndicatorTemplate>)(object)UiRoot.Instance.get_DefaultShortcutIndicatorTemplates();
						}
						Predicate<ShortcutIndicatorTemplate> predicate = (Predicate<ShortcutIndicatorTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorTemplate x)
						{
							//Discarded unreachable code: IL_003d
							ShortcutIndicatorTemplate shortcutIndicatorTemplate6 = childTemplate;
							ShortcutIndicator.VisualType visualType = x.VisualType;
							ShortcutIndicator target5 = shortcutIndicatorTemplate6.Target;
							List<ShortcutIndicator.VisualType> templateOverride2 = target5.TemplateOverride;
							int num16 = index;
							int num17 = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							return (IntPtr)(void*)(int)visualType == (IntPtr)"{il2cpp array field local9->}";
						};
						ShortcutIndicatorTemplate shortcutIndicatorTemplate4 = (ShortcutIndicatorTemplate)((List<T>)(object)defaultShortcutIndicatorTemplates).Find((Predicate<>)(object)predicate);
						ShortcutDefinition shortcutDefinition2 = (shortcutIndicatorTemplate4.ShortcutDefinition = childTemplate.Target.ShortcutDefinition);
						shortcutIndicatorTemplate4.GameObjectTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate4.BackgroundTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate4.IconTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate4.LabelTemplate.IgnoreParent = true;
						shortcutIndicatorTemplate4.AdditionalLabelTemplate.IgnoreParent = true;
						ShortcutIndicator target3 = childTemplate.Target;
						shortcutIndicatorTemplate4.Load(target3);
					}
					while (!ForceLoadKeyboardShortcutIndicators)
					{
					}
					ShortcutIndicatorTemplate shortcutIndicatorTemplate5 = childTemplate;
					ShortcutIndicator target4 = shortcutIndicatorTemplate5.Target;
					shortcutIndicatorTemplate5.Load(target4);
				}
				if (controlType != 0)
				{
					break;
				}
				List<GameObjectTemplate> gameObjectTemplates = (List<GameObjectTemplate>)(object)currentShortcutIndicatorSet.GetGameObjectTemplates();
				if (flag2)
				{
					int num11 = 0;
					while (!flag3)
					{
					}
					int num12 = 0;
				}
				if (controlType != 0)
				{
					continue;
				}
				int num13 = 0;
				if (menuNavigation != (UnityEngine.Object)num13)
				{
					FocusNavigation focusNavigation = menuNavigation2.FocusNavigation;
					int num14 = 0;
					if (focusNavigation != (UnityEngine.Object)num14)
					{
						bool flag4 = menuNavigation3.FocusNavigation.RestoreFocus();
					}
				}
				int num15 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag5 = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEF")]
		[Cpp2IlInjected.Address(RVA = "0x1193080", Offset = "0x1191A80", VA = "0x181193080")]
		internal MenuLayoutTemplate GetCurrentLayout()
		{
			//Discarded unreachable code: IL_0058
			//IL_003a: Expected I4, but got I8
			int num = 0;
			RuntimePlatform runtimePlatform;
			RuntimePlatform runtimePlatform2 = (runtimePlatform = PlatformUtils.GetRuntimePlatform());
			if (runtimePlatform2 > RuntimePlatform.PS4)
			{
				if (runtimePlatform2 == RuntimePlatform.XboxOne || runtimePlatform2 == RuntimePlatform.Switch)
				{
					goto IL_0031;
				}
				if (runtimePlatform2 > RuntimePlatform.WindowsPlayer)
				{
					goto IL_003a;
				}
			}
			if (runtimePlatform2 == RuntimePlatform.OSXPlayer || runtimePlatform2 == RuntimePlatform.PS4)
			{
				goto IL_0031;
			}
			goto IL_003a;
			IL_0031:
			runtimePlatform = RuntimePlatform.WindowsPlayer;
			goto IL_003a;
			IL_003a:
			List<MenuLayoutTemplate> layoutTemplates = LayoutTemplates;
			Predicate<MenuLayoutTemplate> predicate = (Predicate<MenuLayoutTemplate>)(object)(Predicate<T>)delegate(MenuLayoutTemplate x)
			{
				//Discarded unreachable code: IL_002f
				int num2 = 0;
				CanvasHelper instanceMain = CanvasHelper.InstanceMain;
				if ((object)instanceMain == null || !instanceMain.IsLandscape)
				{
				}
				RuntimePlatform runtimePlatform3 = runtimePlatform;
				return x.IsLandscape = x.Platform == runtimePlatform3;
			};
			return (MenuLayoutTemplate)((List<T>)(object)layoutTemplates).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF0")]
		[Cpp2IlInjected.Address(RVA = "0x1193190", Offset = "0x1191B90", VA = "0x181193190", Slot = "20")]
		public ShortcutIndicatorSetTemplate GetCurrentShortcutIndicatorSet()
		{
			//Discarded unreachable code: IL_0171
			//IL_00dc: Expected I4, but got I8
			//IL_00e6: Expected I4, but got I8
			int num = 0;
			RuntimePlatform runtimePlatform2 = PlatformUtils.GetRuntimePlatform();
			int num2 = 0;
			RuntimePlatform runtimePlatform = runtimePlatform2;
			UiRoot instance = UiRoot.Instance;
			bool useKeyboardShortcutIndicators = UseKeyboardShortcutIndicators;
			bool flag = instance.IsControllerConnected(useKeyboardShortcutIndicators);
			int num3 = 0;
			UiRoot instance2 = UiRoot.Instance;
			bool useKeyboardShortcutIndicators2 = UseKeyboardShortcutIndicators;
			ControlType gamepadType = instance2.GetCurrentController(useKeyboardShortcutIndicators2);
			List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates = GamepadKeySetTemplates;
			if (!flag)
			{
				Predicate<ShortcutIndicatorSetTemplate> predicate = (Predicate<ShortcutIndicatorSetTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorSetTemplate x)
				{
					//Discarded unreachable code: IL_0011
					ControlType controlType = gamepadType;
					return x.GamepadType == controlType;
				};
			}
			Predicate<ShortcutIndicatorSetTemplate> predicate2 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorSetTemplate x)
			{
				//Discarded unreachable code: IL_0011
				RuntimePlatform runtimePlatform3 = runtimePlatform;
				return x.Platform == runtimePlatform3;
			};
			ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate3 = default(ShortcutIndicatorSetTemplate);
			if (((List<T>)(object)gamepadKeySetTemplates).Find((Predicate<>)(object)predicate2) == null)
			{
				List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates2 = GamepadKeySetTemplates;
				Predicate<ShortcutIndicatorSetTemplate> predicate3 = default(Predicate<ShortcutIndicatorSetTemplate>);
				if (_003C_003Ec._003C_003E9__97_1 == null)
				{
					predicate3 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.Xbox360));
				}
				if (((List<T>)(object)gamepadKeySetTemplates2).Find((Predicate<>)(object)predicate3) == null)
				{
					if (!flag)
					{
						ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate = new ShortcutIndicatorSetTemplate();
						shortcutIndicatorSetTemplate.GamepadType = ControlType.None;
						shortcutIndicatorSetTemplate.Platform = RuntimePlatform.WindowsEditor;
					}
					List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates3 = GamepadKeySetTemplates;
					Predicate<ShortcutIndicatorSetTemplate> predicate4 = default(Predicate<ShortcutIndicatorSetTemplate>);
					if (_003C_003Ec._003C_003E9__97_3 == null)
					{
						predicate4 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.Xbox360));
					}
					ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate2 = (ShortcutIndicatorSetTemplate)((List<T>)(object)gamepadKeySetTemplates3).Find((Predicate<>)(object)predicate4);
					if (gamepadType == ControlType.Keyboard)
					{
						shortcutIndicatorSetTemplate3 = shortcutIndicatorSetTemplate2.Clone();
						List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates4 = GamepadKeySetTemplates;
						Predicate<ShortcutIndicatorSetTemplate> predicate5 = default(Predicate<ShortcutIndicatorSetTemplate>);
						if (_003C_003Ec._003C_003E9__97_4 == null)
						{
							predicate5 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.None));
						}
						List<GameObjectTemplate> list = (shortcutIndicatorSetTemplate3.GameObjectTemplates = ((ShortcutIndicatorSetTemplate)((List<T>)(object)gamepadKeySetTemplates4).Find((Predicate<>)(object)predicate5)).GameObjectTemplates);
					}
				}
			}
			return shortcutIndicatorSetTemplate3;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF1")]
		[Cpp2IlInjected.Address(RVA = "0x1195540", Offset = "0x1193F40", VA = "0x181195540", Slot = "36")]
		internal virtual void SetRecordingMode(bool isInRecording)
		{
			//Discarded unreachable code: IL_0029
			RecordingModeComponent[] componentsInChildren = GetComponentsInChildren<RecordingModeComponent>();
			Action<RecordingModeComponent> action = (Action<RecordingModeComponent>)(object)(Action<T>)delegate(RecordingModeComponent x)
			{
				//Discarded unreachable code: IL_0012
				bool flag2 = (x.IsShown = !isInRecording);
			};
			MoreLinq.ForEach<RecordingModeComponent>((IEnumerable<>)(object)componentsInChildren, (Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF2")]
		[Cpp2IlInjected.Address(RVA = "0x1194FC0", Offset = "0x11939C0", VA = "0x181194FC0", Slot = "37")]
		public virtual void PopSelf()
		{
			//Discarded unreachable code: IL_0021
			if (_stack.Top == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				_stack.Pop();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF3")]
		[Cpp2IlInjected.Address(RVA = "0x1192FB0", Offset = "0x11919B0", VA = "0x181192FB0")]
		protected bool CheckAndStartControlOverride()
		{
			if (LockAvatarControl)
			{
				bool flag = default(bool);
				if (!flag)
				{
					PlayerNavigation playerNavigation = default(PlayerNavigation);
					PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (_overrideAllScope = playerNavigation.OverrideAllScope());
				}
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF4")]
		[Cpp2IlInjected.Address(RVA = "0x1195630", Offset = "0x1194030", VA = "0x181195630")]
		protected void StopControlOverride()
		{
			//Discarded unreachable code: IL_003f
			//IL_003e: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				bool flag = default(bool);
				if (top != null && !flag)
				{
					int num4 = 0;
					UiRoot.Instance.UpdateCursorBehaviorForGameplay();
				}
			}
			int num5 = 0;
			_overrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num5;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF5")]
		[Cpp2IlInjected.Address(RVA = "0x11950B0", Offset = "0x1193AB0", VA = "0x1811950B0", Slot = "23")]
		public void PostSfx(int index)
		{
			//Discarded unreachable code: IL_003c
			AK.Wwise.Event[] sFXS = SFXS;
			if (sFXS.Length > index && sFXS[index].IsValid())
			{
				AK.Wwise.Event @event = SFXS[index];
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF6")]
		[Cpp2IlInjected.Address(RVA = "0x1193630", Offset = "0x1192030", VA = "0x181193630")]
		public void HandleMainMenuRedirection(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_0018, IL_0022, IL_0023, IL_0024, IL_0025, IL_0026
			int num = 0;
			MainMenuBar _003CMainMenuBar_003Ek__BackingField = UiRoot.Instance.MainMenuBar;
			if (redirectionType != RedirectionType.MainMenuGoToEvents)
			{
				while (redirectionType != RedirectionType.MainMenuGoToInGameShop)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF7")]
		[Cpp2IlInjected.Address(RVA = "0x11954C0", Offset = "0x1193EC0", VA = "0x1811954C0")]
		public void RestoreNavigation()
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CToggleMenuNav_003Ed__105 _003CToggleMenuNav_003Ed__ = new _003CToggleMenuNav_003Ed__105(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CToggleMenuNav_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CToggleMenuNav_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF8")]
		[Cpp2IlInjected.Address(RVA = "0x1195700", Offset = "0x1194100", VA = "0x181195700")]
		[IteratorStateMachine(typeof(_003CToggleMenuNav_003Ed__105))]
		private IEnumerator ToggleMenuNav()
		{
			int _003C_003E1__state = default(int);
			_003CToggleMenuNav_003Ed__105 _003CToggleMenuNav_003Ed__ = new _003CToggleMenuNav_003Ed__105(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CToggleMenuNav_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0x1195780", Offset = "0x1194180", VA = "0x181195780")]
		public Menu()
		{
		}//Discarded unreachable code: IL_00f4
		//IL_0022: Expected I4, but got I8
		//IL_004a: Expected I4, but got I8
		//IL_0082: Expected I4, but got I8
		//IL_008c: Expected I4, but got I8
		//IL_00a6: Expected I4, but got I8
		//IL_00b0: Expected I4, but got I8

	}
}
