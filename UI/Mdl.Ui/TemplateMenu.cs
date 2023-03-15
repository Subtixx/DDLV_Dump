using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000243")]
	public class TemplateMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000A09")]
		[Range(0f, 5f)]
		public float PreFocusOutDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000A0A")]
		public bool IsFullScreenMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x4000A0B")]
		public bool UseDefaultBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x4000A0C")]
		public bool HasMainMenuBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD7")]
		[Cpp2IlInjected.Token(Token = "0x4000A0D")]
		public bool HasMainMenuFooter = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000A0E")]
		public bool HideWorldCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x4000A0F")]
		protected bool PreventPausingCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDA")]
		[Cpp2IlInjected.Token(Token = "0x4000A10")]
		protected bool PreventPausingPlayerNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000A11")]
		public Camera CameraAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000A13")]
		public UnityEvent OnPushed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000A14")]
		public UnityEvent OnPopped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000A15")]
		public UnityEvent OnMainMenuPopped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000A16")]
		public UnityEvent OnMainMenuPushed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000A17")]
		public UnityEvent OnFocusedIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000A18")]
		public UnityEvent OnFocusedOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000A19")]
		public UnityEvent OnLayoutChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000A1A")]
		public UnityEvent OnRefreshDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000A1B")]
		private bool _restored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000A1C")]
		private int _cullingMaskBackup;

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		public RectTransform Background
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4B")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0")]
			[CompilerGenerated]
			get
			{
				return _003CBackground_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E4C")]
			[Cpp2IlInjected.Address(RVA = "0x976540", Offset = "0x974F40", VA = "0x180976540")]
			[CompilerGenerated]
			private set
			{
				_003CBackground_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4D")]
		[Cpp2IlInjected.Address(RVA = "0x17E8E60", Offset = "0x17E7860", VA = "0x1817E8E60", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00cd
			base.OnPush(stack, param);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			if (UseDefaultBackground)
			{
				RectTransform rectTransform = (Background = instance.DefaultBackground);
				RectTransform rectTransform2 = Background;
				Transform transform2 = (((Transform)rectTransform2).parentInternal = base.transform);
				Background.SetAsFirstSibling();
				Background.gameObject.SetActive(value: true);
			}
			if (IsFullScreenMenu)
			{
				if (!PreventPausingCamera)
				{
					PauseRendering();
				}
				if (PreventPausingPlayerNavigation)
				{
				}
			}
			if (HideWorldCanvas)
			{
				instance._worldCanvas.Hide();
			}
			IMenu menu = base.PrevMenu;
			if (menu != null)
			{
				int num2 = 0;
				if (menu != null)
				{
					OnMainMenuPushed?.Invoke();
				}
			}
			OnPushed?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4E")]
		[Cpp2IlInjected.Address(RVA = "0x17E8C30", Offset = "0x17E7630", VA = "0x1817E8C30", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_00a7
			//IL_006d: Expected O, but got I8
			if (!IsFullScreenMenu || !PreventPausingPlayerNavigation)
			{
			}
			if (base.NextMenu == null)
			{
			}
			int num = 0;
			if (UseDefaultBackground)
			{
				bool flag = default(bool);
				if (!flag)
				{
				}
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				RectTransform rectTransform = Background;
				RectTransform rectTransform2 = (RectTransform)(((Transform)rectTransform).parentInternal = instance.DefaultBackgroundHolder);
				GameObject gameObject = Background.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Background = (RectTransform)0;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				OnMainMenuPopped?.Invoke();
			}
			Restore();
			OnPopped?.Invoke();
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4F")]
		[Cpp2IlInjected.Address(RVA = "0x17E89B0", Offset = "0x17E73B0", VA = "0x1817E89B0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0137
			//IL_0028: Expected O, but got I4
			//IL_0062: Expected F4, but got I4
			//IL_00e4: Expected F4, but got I4
			base.OnFocusIn();
			if (base.IsInMenuStack)
			{
				int num = 0;
				MainMenuBar _003CMainMenuBar_003Ek__BackingField = UiRoot.Instance.MainMenuBar;
				int num2 = 0;
				if (_003CMainMenuBar_003Ek__BackingField != (UnityEngine.Object)num2)
				{
					GameObject gameObject = _003CMainMenuBar_003Ek__BackingField.gameObject;
					bool hasMainMenuBar = HasMainMenuBar;
					gameObject.SetActive(hasMainMenuBar);
					CanvasGroup canvasGroup = _003CMainMenuBar_003Ek__BackingField.CanvasGroup;
					if (HasMainMenuBar)
					{
					}
					int num3 = 0;
					canvasGroup.alpha = num3;
					CanvasGroup canvasGroup2 = _003CMainMenuBar_003Ek__BackingField.CanvasGroup;
					bool flag2 = (canvasGroup2.interactable = HasMainMenuBar);
					CanvasGroup canvasGroup3 = _003CMainMenuBar_003Ek__BackingField.CanvasGroup;
					bool flag4 = (canvasGroup3.blocksRaycasts = HasMainMenuBar);
					if (HasMainMenuBar)
					{
						GameObject gameObject2 = _003CMainMenuBar_003Ek__BackingField.Footer.gameObject;
						bool hasMainMenuFooter = HasMainMenuFooter;
						gameObject2.SetActive(hasMainMenuFooter);
						CanvasGroup footerCanvasGroup = _003CMainMenuBar_003Ek__BackingField.FooterCanvasGroup;
						int num4 = default(int);
						if (!HasMainMenuFooter)
						{
							num4 = 0;
						}
						footerCanvasGroup.alpha = num4;
						CanvasGroup footerCanvasGroup2 = _003CMainMenuBar_003Ek__BackingField.FooterCanvasGroup;
						bool flag6 = (footerCanvasGroup2.interactable = HasMainMenuFooter);
						CanvasGroup footerCanvasGroup3 = _003CMainMenuBar_003Ek__BackingField.FooterCanvasGroup;
						bool flag8 = (footerCanvasGroup3.blocksRaycasts = HasMainMenuFooter);
					}
				}
			}
			OnFocusedIn?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E50")]
		[Cpp2IlInjected.Address(RVA = "0x17E8BA0", Offset = "0x17E75A0", VA = "0x1817E8BA0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterFocusOut, animate);
			OnFocusedOut?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x17E9410", Offset = "0x17E7E10", VA = "0x1817E9410", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__25))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__25 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__25(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x17E8BD0", Offset = "0x17E75D0", VA = "0x1817E8BD0", Slot = "34")]
		internal override void OnLayoutChange()
		{
			//Discarded unreachable code: IL_0033
			base.OnLayoutChange();
			if (HasMainMenuBar)
			{
				int num = 0;
				UiRoot.Instance.MainMenuBar.OnLayoutChange();
			}
			OnLayoutChanged?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x17E9490", Offset = "0x17E7E90", VA = "0x1817E9490")]
		protected void Restore()
		{
			//Discarded unreachable code: IL_00f0
			//IL_0035: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			if (_restored || base.IsInPopUpStack)
			{
				return;
			}
			int num = 0;
			if (base.NextMenu == null)
			{
			}
			int num2 = 0;
			Camera cameraAlt = CameraAlt;
			int num3 = 0;
			if (cameraAlt != (UnityEngine.Object)num3)
			{
				GameObject gameObject = CameraAlt.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				UnityEngine.Object.Destroy(CameraAlt.gameObject);
				Transform transform = default(Transform);
				Transform transform3 = (transform.parentInternal = base.transform);
			}
			bool flag = default(bool);
			if (!flag)
			{
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
			if (HideWorldCanvas)
			{
				int num4 = 0;
				UiRoot.Instance._worldCanvas.Show();
			}
			int num5 = 0;
			MainMenuBar _003CMainMenuBar_003Ek__BackingField = UiRoot.Instance.MainMenuBar;
			int num6 = 0;
			if (_003CMainMenuBar_003Ek__BackingField != (UnityEngine.Object)num6)
			{
				bool flag3 = default(bool);
				if (!flag3)
				{
				}
				int num7 = 0;
				GameObject gameObject2 = UiRoot.Instance.MainMenuBar.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
			}
			int num8 = default(int);
			if (num8 != 0 || _cullingMaskBackup != 0)
			{
			}
			_restored = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0x17E9080", Offset = "0x17E7A80", VA = "0x1817E9080")]
		protected void PauseRendering()
		{
			//Discarded unreachable code: IL_00b0
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			_restored = false;
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if (!((UnityEngine.Object)num != (UnityEngine.Object)num2))
			{
				return;
			}
			Camera cameraAlt = CameraAlt;
			int num3 = 0;
			if (!(cameraAlt != (UnityEngine.Object)num3))
			{
				int num4 = 0;
				bool flag = default(bool);
				if (flag)
				{
					int num5 = 0;
					int num6 = default(int);
					if (num6 != 0)
					{
						int num7 = 0;
						int num8 = 0;
						int cullingMaskBackup = default(int);
						_cullingMaskBackup = cullingMaskBackup;
						int num9 = 0;
					}
				}
				return;
			}
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			Camera main = Camera.main;
			int num13 = 0;
			if (main != (UnityEngine.Object)num13)
			{
				int num14 = 0;
				if (Camera.main != main)
				{
					int num15 = 0;
					GameObject gameObject = Camera.main.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
			}
			CameraAlt.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0x17E97F0", Offset = "0x17E81F0", VA = "0x1817E97F0")]
		public TemplateMenu()
		{
		}
	}
}
