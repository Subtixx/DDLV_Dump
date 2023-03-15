using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.InputSystem;
using Mdl.Ui;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

namespace mdl.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	public class CutSceneSkipper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public GameObject PcShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public ShortcutIndicator GamepadShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		protected Mdl.InputSystem.InputAction inputActionSkipPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		protected Mdl.InputSystem.InputAction inputActionSkipGamepad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		protected Mdl.InputSystem.InputAction inputActionSkipPCPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		protected Mdl.InputSystem.InputAction inputActionSkipGamepadPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		protected Mdl.InputSystem.InputAction inputActionSkipPCRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		protected Mdl.InputSystem.InputAction inputActionSkipGamepadRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public float skipDelay = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		[SerializeField]
		private RectTransform _mask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		[SerializeField]
		private Image _fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private Action _callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public bool IsFading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public bool IsAnimatingFill;

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x111DFE0", Offset = "0x111C9E0", VA = "0x18111DFE0")]
		public void Start()
		{
			//IL_001b: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			float delay = skipDelay;
			InputTriggerDownWithDelay trigger = new InputTriggerDownWithDelay(delay);
			int num = default(int);
			InputActionBool inputActionBool = new InputActionBool("[Esc]", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			inputActionSkipPC = inputActionBool;
			InputTriggerDownWithDelay trigger2 = new InputTriggerDownWithDelay(delay);
			int num3 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("[ B ]", trigger2, (InputProvider)num3);
			num3 = 0;
			inputActionSkipGamepad = inputActionBool2;
			InputTriggerPressed trigger3 = new InputTriggerPressed();
			int num4 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("[Esc]", trigger3, (InputProvider)num4);
			num4 = 0;
			inputActionSkipPCPress = inputActionBool3;
			InputTriggerPressed trigger4 = new InputTriggerPressed();
			int num5 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("[ B ]", trigger4, (InputProvider)num5);
			num5 = 0;
			inputActionSkipGamepadPress = inputActionBool4;
			InputTriggerReleased trigger5 = new InputTriggerReleased();
			int num6 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("[Esc]", trigger5, (InputProvider)num6);
			num6 = 0;
			inputActionSkipPCRelease = inputActionBool5;
			InputTriggerReleased trigger6 = new InputTriggerReleased();
			int num7 = default(int);
			InputActionBool inputActionBool6 = new InputActionBool("[ B ]", trigger6, (InputProvider)num7);
			num7 = 0;
			inputActionSkipGamepadRelease = inputActionBool6;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x111DA80", Offset = "0x111C480", VA = "0x18111DA80")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_001d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			EventHandler value = OnControllerChanged;
			instance.OnNewInputReceived += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x111D9F0", Offset = "0x111C3F0", VA = "0x18111D9F0")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_001d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			EventHandler value = OnControllerChanged;
			instance.OnNewInputReceived -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x111D960", Offset = "0x111C360", VA = "0x18111D960")]
		private void OnControllerChanged(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0046
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			GameObject pcShortcutIndicator = PcShortcutIndicator;
			bool active = !flag;
			pcShortcutIndicator.SetActive(active);
			GamepadShortcutIndicator.gameObject.SetActive(flag);
			GamepadShortcutIndicator.RefreshVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x111DB10", Offset = "0x111C510", VA = "0x18111DB10")]
		public void Show(Action callback)
		{
			//Discarded unreachable code: IL_0077
			//IL_001a: Expected I4, but got I8
			//IL_0076: Expected F4, but got I4
			_callback = callback;
			IsFading = false;
			ulong num = default(ulong);
			base.gameObject.SetActive((byte)num != 0);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			GameObject pcShortcutIndicator = PcShortcutIndicator;
			bool active = !flag;
			pcShortcutIndicator.SetActive(active);
			GamepadShortcutIndicator.gameObject.SetActive(flag);
			GamepadShortcutIndicator.RefreshVisuals();
			CanvasGroup canvasGroup = _canvasGroup;
			int num3 = 0;
			canvasGroup.alpha = num3;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x111D910", Offset = "0x111C310", VA = "0x18111D910")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0021
			//IL_0020: Expected F4, but got I4
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			CanvasGroup canvasGroup = _canvasGroup;
			int num = 0;
			canvasGroup.alpha = num;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x111E340", Offset = "0x111CD40", VA = "0x18111E340")]
		public void Update()
		{
			//Discarded unreachable code: IL_0276
			//IL_005d: Expected F4, but got I4
			//IL_0228: Expected F4, but got I4
			//IL_0245: Expected O, but got I4
			float deltaTime;
			Mdl.InputSystem.InputAction[] array;
			Mdl.InputSystem.InputAction inputAction6;
			while (true)
			{
				int num = 0;
				ReInput.PlayerHelper players = ReInput.players;
				int playerId = 0;
				bool anyButton = players.GetPlayer(playerId).GetAnyButton();
				if (!anyButton)
				{
					if (IsFading != anyButton)
					{
						goto IL_00b2;
					}
					CanvasGroup canvasGroup = _canvasGroup;
					IsFading = true;
					int complete = 0;
					int num2 = DOTween.Kill(canvasGroup, (byte)complete != 0);
					CanvasGroup canvasGroup2 = _canvasGroup;
					int num3 = 0;
					TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroup2, (float)num3, 0.7f)).SetEase(Ease.OutCirc).SetDelay(0.35f);
				}
				CanvasGroup canvasGroup3 = _canvasGroup;
				IsFading = false;
				int complete2 = 0;
				int num4 = DOTween.Kill(canvasGroup3, (byte)complete2 != 0);
				TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvasGroup, 1f, 0.7f)).SetEase(Ease.OutCirc).Play();
				goto IL_00b2;
				IL_00b2:
				int num5 = 0;
				deltaTime = Time.deltaTime;
				array = new Mdl.InputSystem.InputAction[6];
				Mdl.InputSystem.InputAction inputAction = inputActionSkipPC;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				Mdl.InputSystem.InputAction inputAction2 = inputActionSkipGamepad;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				Mdl.InputSystem.InputAction inputAction3 = inputActionSkipPCPress;
				if (inputAction3 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction3;
				Mdl.InputSystem.InputAction inputAction4 = inputActionSkipGamepadPress;
				if (inputAction4 != null && array == null)
				{
					continue;
				}
				array[3] = inputAction4;
				Mdl.InputSystem.InputAction inputAction5 = inputActionSkipPCRelease;
				if (inputAction5 == null || array != null)
				{
					array[4] = inputAction5;
					inputAction6 = inputActionSkipGamepadRelease;
					if (inputAction6 == null || array != null)
					{
						break;
					}
				}
			}
			array[5] = inputAction6;
			Mdl.InputSystem.InputAction.UpdateAll(deltaTime, array);
			if (!inputActionSkipPCRelease.IsTriggered && !inputActionSkipGamepadRelease.IsTriggered && !inputActionSkipPC.IsTriggered && !inputActionSkipGamepad.IsTriggered)
			{
				if (!inputActionSkipPCPress.IsTriggered && !inputActionSkipGamepadPress.IsTriggered)
				{
					goto IL_0245;
				}
				StartFillAnim();
			}
			RectTransform mask = _mask;
			IsAnimatingFill = false;
			int complete3 = 0;
			int num6 = DOTween.Kill(mask, (byte)complete3 != 0);
			Image fillImage = _fillImage;
			int complete4 = 0;
			int num7 = DOTween.Kill(fillImage, (byte)complete4 != 0);
			Image fillImage2 = _fillImage;
			int num8 = 0;
			fillImage2.fillAmount = num8;
			RectTransform mask2 = _mask;
			int num9 = 0;
			Vector2 sizeDelta = mask2.sizeDelta;
			mask2.sizeDelta = (Vector2)num9;
			goto IL_0245;
			IL_0245:
			if (inputActionSkipPC.IsTriggered || inputActionSkipGamepad.IsTriggered)
			{
				_callback?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x111DBE0", Offset = "0x111C5E0", VA = "0x18111DBE0")]
		private void StartFillAnim()
		{
			//Discarded unreachable code: IL_0107
			//IL_004c: Expected F4, but got I4
			//IL_00fb: Expected O, but got I4
			if (!IsAnimatingFill)
			{
				IsAnimatingFill = true;
				RectTransform mask = _mask;
				int complete = 0;
				int num = DOTween.Kill(mask, (byte)complete != 0);
				Image fillImage = _fillImage;
				int complete2 = 0;
				int num2 = DOTween.Kill(fillImage, (byte)complete2 != 0);
				Image fillImage2 = _fillImage;
				int num3 = 0;
				fillImage2.fillAmount = num3;
				Image fillImage3 = _fillImage;
				float num4 = skipDelay;
				DOTweenModuleUI._003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new DOTweenModuleUI._003C_003Ec__DisplayClass5_0();
				CS_0024_003C_003E8__locals0.target = fillImage3;
				DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => CS_0024_003C_003E8__locals0.target.m_FillAmount);
				DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
				{
					//Discarded unreachable code: IL_000d
					CS_0024_003C_003E8__locals0.target.fillAmount = x;
				};
				TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, 1f, num4);
				TweenerCore<float, float, FloatOptions> tweenerCore = t.SetTarget(dOSetter);
				TweenerCore<float, float, FloatOptions> tweenerCore2 = t.Play();
				RectTransform mask2 = _mask;
				Vector2 sizeDelta = mask2.sizeDelta;
				DOTweenModuleUI._003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals1 = new DOTweenModuleUI._003C_003Ec__DisplayClass25_0();
				CS_0024_003C_003E8__locals1.target = mask2;
				DOGetter<Vector2> dOGetter2 = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => CS_0024_003C_003E8__locals1.target.sizeDelta);
				DOSetter<Vector2> dOSetter2 = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
				{
					//Discarded unreachable code: IL_000d
					CS_0024_003C_003E8__locals1.target.sizeDelta = x;
				};
				int num5 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				Tweener tweener = ((Tweener)t2).SetTarget((object)num5);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = t2.Play();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x111E270", Offset = "0x111CC70", VA = "0x18111E270")]
		private void StopFillAnim()
		{
			//Discarded unreachable code: IL_005e
			//IL_0040: Expected F4, but got I4
			//IL_005d: Expected O, but got I4
			RectTransform mask = _mask;
			IsAnimatingFill = false;
			int complete = 0;
			int num = DOTween.Kill(mask, (byte)complete != 0);
			Image fillImage = _fillImage;
			int complete2 = 0;
			int num2 = DOTween.Kill(fillImage, (byte)complete2 != 0);
			Image fillImage2 = _fillImage;
			int num3 = 0;
			fillImage2.fillAmount = num3;
			RectTransform mask2 = _mask;
			int num4 = 0;
			Vector2 sizeDelta = mask2.sizeDelta;
			mask2.sizeDelta = (Vector2)num4;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x111E900", Offset = "0x111D300", VA = "0x18111E900")]
		public CutSceneSkipper()
		{
		}
	}
}
