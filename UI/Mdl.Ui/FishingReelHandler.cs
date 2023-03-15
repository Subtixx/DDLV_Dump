using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Activities;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Util;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007A6")]
	[RequiredAllNotNull]
	public class FishingReelHandler : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CE6")]
		[SerializeField]
		private RectTransform _mcFishingProgressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CE7")]
		[SerializeField]
		private RectTransform _mcFishingProgressBarContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002CE8")]
		[SerializeField]
		private RectTransform _mcRedGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002CE9")]
		[SerializeField]
		private SpriteAtlasImage _mcFishIconBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002CEA")]
		[SerializeField]
		private SpriteAtlasImage _mcFishIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002CEB")]
		[SerializeField]
		private SpriteAtlasImage _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002CEC")]
		[SerializeField]
		private RectTransform _lineFeedback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002CED")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002CEE")]
		[SerializeField]
		private GameObject _gamepadKeyIndicatorHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002CEF")]
		[SerializeField]
		private Sprite _releaseSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002CF0")]
		[SerializeField]
		private Sprite _holdSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002CF1")]
		[SerializeField]
		private Sprite _waitSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002CF2")]
		[SerializeField]
		private Sprite _mcFishNormalSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002CF3")]
		[SerializeField]
		private Sprite _mcFishRedSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002CF4")]
		[SerializeField]
		private float _holdGizmoTension = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4002CF5")]
		[SerializeField]
		private float _releaseGizmoTension = 0.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002CF6")]
		private FishingMiniGame _fishingMiniGame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002CF7")]
		private bool _isWaiting = true;

		[Cpp2IlInjected.Token(Token = "0x170006DD")]
		public Sprite ReleaseSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60030E7")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return _releaseSprite;
			}
			[Cpp2IlInjected.Token(Token = "0x60030E8")]
			[Cpp2IlInjected.Address(RVA = "0x976600", Offset = "0x975000", VA = "0x180976600")]
			set
			{
				_releaseSprite = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DE")]
		public Sprite HoldSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60030E9")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return _holdSprite;
			}
			[Cpp2IlInjected.Token(Token = "0x60030EA")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			set
			{
				_holdSprite = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DF")]
		public Sprite WaitSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60030EB")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return _waitSprite;
			}
			[Cpp2IlInjected.Token(Token = "0x60030EC")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			set
			{
				_waitSprite = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030ED")]
		[Cpp2IlInjected.Address(RVA = "0x165F480", Offset = "0x165DE80", VA = "0x18165F480", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [System.Runtime.InteropServices.Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_003b
			FishingMiniGame fishingMiniGame = (_fishingMiniGame = SystemRoot.Instance.GetSystem<FishingSystem>().MiniGame);
			FishingMiniGame fishingMiniGame2 = _fishingMiniGame;
			Action value = ShowLineFeedback;
			fishingMiniGame2.FishHookedEvent += value;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x60030EE")]
		[Cpp2IlInjected.Address(RVA = "0x165F8B0", Offset = "0x165E2B0", VA = "0x18165F8B0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0022
			KillAnim();
			FishingMiniGame fishingMiniGame = _fishingMiniGame;
			Action value = ShowLineFeedback;
			fishingMiniGame.FishHookedEvent -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x60030EF")]
		[Cpp2IlInjected.Address(RVA = "0x165FAE0", Offset = "0x165E4E0", VA = "0x18165FAE0", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_00fc
			base.Update();
			GameObject gameObject = _mcIcon.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			FishingMiniGame.FishingState _003CCurrentFishingState_003Ek__BackingField = _fishingMiniGame.CurrentFishingState;
			if (_003CCurrentFishingState_003Ek__BackingField == FishingMiniGame.FishingState.WaitingForBite)
			{
				TextBase tfLabel = _tfLabel;
				_isWaiting = true;
				tfLabel.StringID = "menu.fishing_wait";
				GameObject gamepadKeyIndicatorHolder = _gamepadKeyIndicatorHolder;
				int active2 = 0;
				gamepadKeyIndicatorHolder.SetActive((byte)active2 != 0);
				GameObject gameObject2 = _mcFishingProgressBarContent.gameObject;
				bool active3 = !_isWaiting;
				gameObject2.SetActive(active3);
				Sprite waitSprite = _waitSprite;
				SpriteAtlasImage mcIcon = _mcIcon;
				string text2 = (mcIcon.ImageAddress = waitSprite.name);
			}
			else
			{
				while (_003CCurrentFishingState_003Ek__BackingField != FishingMiniGame.FishingState.FishBit)
				{
				}
				Sprite holdSprite = _holdSprite;
				SpriteAtlasImage mcIcon2 = _mcIcon;
				string text4 = (mcIcon2.ImageAddress = holdSprite.name);
				_mcIcon.gameObject.SetActive(value: true);
				ControlType controlType = _controlType;
				GameObject gamepadKeyIndicatorHolder2 = _gamepadKeyIndicatorHolder;
				if (controlType == ControlType.None)
				{
				}
				bool active4 = controlType != ControlType.Keyboard;
				gamepadKeyIndicatorHolder2.SetActive(active4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030F0")]
		[Cpp2IlInjected.Address(RVA = "0x165F6D0", Offset = "0x165E0D0", VA = "0x18165F6D0")]
		private void KillAnim()
		{
			//Discarded unreachable code: IL_004c
			//IL_004b: Expected F4, but got I4
			RectTransform lineFeedback = _lineFeedback;
			int complete = 0;
			int num = DOTween.Kill(lineFeedback, (byte)complete != 0);
			CanvasGroup component = _lineFeedback.GetComponent<CanvasGroup>();
			int complete2 = 0;
			int num2 = DOTween.Kill(component, (byte)complete2 != 0);
			RectTransform lineFeedback2 = _lineFeedback;
			CanvasGroup component2 = _lineFeedback.GetComponent<CanvasGroup>();
			int num3 = 0;
			component2.alpha = num3;
		}

		[Cpp2IlInjected.Token(Token = "0x60030F1")]
		[Cpp2IlInjected.Address(RVA = "0x165F950", Offset = "0x165E350", VA = "0x18165F950")]
		private void ShowLineFeedback()
		{
			//Discarded unreachable code: IL_007e
			//IL_0064: Expected F4, but got I4
			KillAnim();
			RectTransform lineFeedback = _lineFeedback;
			_lineFeedback.GetComponent<CanvasGroup>().alpha = 1f;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)_lineFeedback, 1f, 0.7f)).SetEase(Ease.OutExpo).Play();
			CanvasGroup component = _lineFeedback.GetComponent<CanvasGroup>();
			int num = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component, (float)num, 0.9f)).SetEase(Ease.OutExpo).SetDelay(0.4f).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x60030F2")]
		[Cpp2IlInjected.Address(RVA = "0x165F830", Offset = "0x165E230", VA = "0x18165F830", Slot = "19")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_002d
			base.OnControllerChanged();
			CanvasGroup component = _mcIcon.GetComponent<CanvasGroup>();
			switch (_controlType)
			{
			}
			component.alpha = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x60030F3")]
		[Cpp2IlInjected.Address(RVA = "0x165F7D0", Offset = "0x165E1D0", VA = "0x18165F7D0", Slot = "15")]
		public override void Kill()
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60030F4")]
		[Cpp2IlInjected.Address(RVA = "0x165FCB0", Offset = "0x165E6B0", VA = "0x18165FCB0")]
		public FishingReelHandler()
		{
		}
	}
}
