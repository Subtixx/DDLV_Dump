using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007D8")]
	public class NotEnoughManaInfo : InfoGizmo
	{
		[Cpp2IlInjected.Token(Token = "0x20007D9")]
		private enum AnimationStep
		{
			[Cpp2IlInjected.Token(Token = "0x4002E20")]
			Mana,
			[Cpp2IlInjected.Token(Token = "0x4002E21")]
			House,
			[Cpp2IlInjected.Token(Token = "0x4002E22")]
			Apple
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E02")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002E03")]
		[SerializeField]
		private CanvasGroup _bubbleGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002E04")]
		[SerializeField]
		private RectTransform _bubbleRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002E05")]
		[SerializeField]
		private CanvasGroup _manaGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002E06")]
		[SerializeField]
		private RectTransform _manaPlusIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002E07")]
		[SerializeField]
		private CanvasGroup _houseGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002E08")]
		[SerializeField]
		private RectTransform _houseArrowIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002E09")]
		[SerializeField]
		private CanvasGroup _appleGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002E0A")]
		[SerializeField]
		private GameObject _appleWholeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002E0B")]
		[SerializeField]
		private GameObject _appleBittonIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002E0C")]
		[SerializeField]
		[Header("Global animation settings")]
		private float _bubbleFadeInDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4002E0D")]
		[SerializeField]
		private float _bubbleFadeOutDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002E0E")]
		[SerializeField]
		private float _stepFadeInOutDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002E0F")]
		[SerializeField]
		private AnimationStep[] _animationSteps;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002E10")]
		[SerializeField]
		[Header("Mana animation settings")]
		private float _manaPlusBounceAnimationDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4002E11")]
		[SerializeField]
		private float _manaPlusPauseAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002E12")]
		[SerializeField]
		private int _manaAnimationRepeat = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4002E13")]
		[SerializeField]
		[Header("House animation settings")]
		private float _houseArrowBounceAnimationDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002E14")]
		[SerializeField]
		private float _houseArrowPauseAnimationDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4002E15")]
		[SerializeField]
		private int _houseArrowAnimationRepeat = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002E16")]
		[SerializeField]
		[Header("Apple animation settings")]
		private float _appleWholeShownDuration = 0.35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4002E17")]
		[SerializeField]
		private float _appleBittenShownDuration = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002E18")]
		[SerializeField]
		private int _appleAnimationRepeat = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4002E19")]
		private bool _animationPlaying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002E1A")]
		private int _animationStepIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4002E1B")]
		[SerializeField]
		[Header("Icon settings")]
		private float _femaleIconDistanceY = -120f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002E1C")]
		[SerializeField]
		private float _maleIconDistanceY = -120f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4002E1D")]
		private float _iconDistanceY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002E1E")]
		private bool notEnough;

		[Cpp2IlInjected.Token(Token = "0x60031FC")]
		[Cpp2IlInjected.Address(RVA = "0x129F2B0", Offset = "0x129DCB0", VA = "0x18129F2B0", Slot = "15")]
		public override void Kill()
		{
			CanvasGroup manaGroup = _manaGroup;
			int complete = 0;
			int num = manaGroup.DOKill((byte)complete != 0);
			CanvasGroup houseGroup = _houseGroup;
			int complete2 = 0;
			int num2 = houseGroup.DOKill((byte)complete2 != 0);
			CanvasGroup appleGroup = _appleGroup;
			int complete3 = 0;
			int num3 = appleGroup.DOKill((byte)complete3 != 0);
			RectTransform bubbleRectTransform = _bubbleRectTransform;
			int complete4 = 0;
			int num4 = bubbleRectTransform.DOKill((byte)complete4 != 0);
			CanvasGroup bubbleGroup = _bubbleGroup;
			int complete5 = 0;
			int num5 = bubbleGroup.DOKill((byte)complete5 != 0);
			RectTransform manaPlusIcon = _manaPlusIcon;
			int complete6 = 0;
			int num6 = manaPlusIcon.DOKill((byte)complete6 != 0);
			RectTransform houseArrowIcon = _houseArrowIcon;
			int complete7 = 0;
			int num7 = houseArrowIcon.DOKill((byte)complete7 != 0);
			base.Kill();
		}

		[Cpp2IlInjected.Token(Token = "0x60031FD")]
		[Cpp2IlInjected.Address(RVA = "0x129F070", Offset = "0x129DA70", VA = "0x18129F070", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_00a3
			//IL_003c: Expected F4, but got I4
			//IL_0050: Expected F4, but got I4
			//IL_0064: Expected F4, but got I4
			//IL_0078: Expected F4, but got I4
			//IL_008f: Expected I4, but got I8
			//IL_009b: Expected I4, but got O
			if ((long)ProfilePlayer._map_furnitureData_codec != 0)
			{
			}
			float num = (_iconDistanceY = _femaleIconDistanceY);
			CanvasGroup bubbleGroup = _bubbleGroup;
			int num2 = 0;
			bubbleGroup.alpha = num2;
			CanvasGroup manaGroup = _manaGroup;
			int num3 = 0;
			manaGroup.alpha = num3;
			CanvasGroup houseGroup = _houseGroup;
			int num4 = 0;
			houseGroup.alpha = num4;
			CanvasGroup appleGroup = _appleGroup;
			int num5 = 0;
			appleGroup.alpha = num5;
			_animationPlaying = false;
			_animationStepIndex = -1;
			CanvasGroup canvasGroup = appleGroup;
			notEnough = (byte)(int)canvasGroup != 0;
			Animate();
		}

		[Cpp2IlInjected.Token(Token = "0x60031FE")]
		[Cpp2IlInjected.Address(RVA = "0x129EC50", Offset = "0x129D650", VA = "0x18129EC50")]
		private void Animate(int stepIndex = -1)
		{
			//IL_00e0: Expected F4, but got I4
			//IL_0142: Expected F4, but got I4
			_animationPlaying = true;
			int num = (_animationStepIndex = stepIndex);
			int num2 = stepIndex;
			if (num2 != -1)
			{
				if (notEnough)
				{
					AnimationStep[] animationSteps = _animationSteps;
				}
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					AnimateStep(num2);
					AnimationStep[] animationSteps2 = _animationSteps;
					int num4 = num2 - 1;
					AnimationStep animationStep = animationSteps2[num4];
					if (animationStep != 0)
					{
						switch (animationStep)
						{
						}
					}
					CanvasGroup manaGroup = _manaGroup;
					if ((object)manaGroup.transform != null)
					{
					}
					AnimationStep[] animationSteps3 = _animationSteps;
					int num5 = stepIndex;
					AnimationStep animationStep2 = animationSteps3[num5];
					if (animationStep2 != 0)
					{
						switch (animationStep2)
						{
						}
					}
					CanvasGroup manaGroup2 = _manaGroup;
					Transform transform = manaGroup2.transform;
					float stepFadeInOutDuration = _stepFadeInOutDuration;
					int num6 = 0;
					TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(manaGroup, (float)num6, stepFadeInOutDuration);
					int num7 = 0;
					float stepFadeInOutDuration2 = _stepFadeInOutDuration;
					TweenerCore<float, float, FloatOptions> tweenerCore2 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(manaGroup2, 1f, stepFadeInOutDuration2);
					TweenCallback action = delegate
					{
						//Discarded unreachable code: IL_0016
						NotEnoughManaInfo notEnoughManaInfo = this;
						int stepIndex2 = stepIndex;
						notEnoughManaInfo.AnimateStep(stepIndex2);
					};
					TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = t.OnComplete(action);
					return;
				}
				Vector2 anchoredPosition = _bubbleRectTransform.anchoredPosition;
				float bubbleFadeInDuration = _bubbleFadeInDuration;
				CanvasGroup bubbleGroup = _bubbleGroup;
				int num8 = 0;
				TweenerCore<float, float, FloatOptions> tweenerCore4 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(bubbleGroup, (float)num8, bubbleFadeInDuration);
				TweenCallback tweenCallback = base.Hide;
			}
			AnimateIn();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031FF")]
		[Cpp2IlInjected.Address(RVA = "0x129E800", Offset = "0x129D200", VA = "0x18129E800")]
		private void AnimateStep(int stepIndex)
		{
			AnimationStep animationStep = _animationSteps[stepIndex];
			if (animationStep != 0)
			{
				switch (animationStep)
				{
				default:
					_animationPlaying = false;
					return;
				case AnimationStep.House:
				{
					int _003C_003E1__state = default(int);
					_003CAnimateAppleCoroutine_003Ed__40 _003CAnimateAppleCoroutine_003Ed__ = new _003CAnimateAppleCoroutine_003Ed__40(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CAnimateAppleCoroutine_003Ed__._003C_003E4__this = this;
					_003CAnimateAppleCoroutine_003Ed__.stepIndex = stepIndex;
					Coroutine coroutine = StartCoroutine(_003CAnimateAppleCoroutine_003Ed__);
					break;
				}
				case AnimationStep.Mana:
					break;
				}
				int stepIndex3 = stepIndex;
				int num = 0;
				Sequence s = DOTween.Sequence();
				int num2 = 0;
				if (_houseArrowAnimationRepeat > num2)
				{
					float houseArrowPauseAnimationDuration = _houseArrowPauseAnimationDuration;
					Sequence sequence = s.AppendInterval(houseArrowPauseAnimationDuration);
					float houseArrowBounceAnimationDuration = _houseArrowBounceAnimationDuration;
					int num3 = 0;
					TweenerCore<Vector2, Vector2, VectorOptions> t = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(_houseArrowIcon, -18f, houseArrowBounceAnimationDuration, (byte)num3 != 0);
					Sequence sequence2 = s.Append(t);
					float houseArrowBounceAnimationDuration2 = _houseArrowBounceAnimationDuration;
					int num4 = 0;
					TweenerCore<Vector2, Vector2, VectorOptions> t2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(_houseArrowIcon, -25f, houseArrowBounceAnimationDuration2, (byte)num4 != 0);
					Sequence sequence3 = s.Append(t2);
					num2++;
				}
			}
			int stepIndex2 = stepIndex;
			int num5 = 0;
			Sequence sequence4 = DOTween.Sequence();
			int num6 = 0;
			if (_manaAnimationRepeat > num6)
			{
				float manaPlusPauseAnimationDuration = _manaPlusPauseAnimationDuration;
				Sequence sequence5 = sequence4.AppendInterval(manaPlusPauseAnimationDuration);
				float manaPlusBounceAnimationDuration = _manaPlusBounceAnimationDuration;
				int num7 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t3 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_manaPlusIcon, -4f, manaPlusBounceAnimationDuration, (byte)num7 != 0);
				Sequence sequence6 = sequence4.Append(t3);
				float manaPlusBounceAnimationDuration2 = _manaPlusBounceAnimationDuration;
				int num8 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t4 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_manaPlusIcon, -10f, manaPlusBounceAnimationDuration2, (byte)num8 != 0);
				Sequence sequence7 = sequence4.Append(t4);
				num6++;
			}
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_001a
				NotEnoughManaInfo notEnoughManaInfo = this;
				int num9 = stepIndex2;
				num9++;
				notEnoughManaInfo.Animate(num9);
			};
			Sequence sequence8 = sequence4.OnComplete(action);
			Sequence sequence9 = sequence4.Play();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003200")]
		[Cpp2IlInjected.Address(RVA = "0x129F040", Offset = "0x129DA40", VA = "0x18129F040")]
		private CanvasGroup GetCanvasGroupForStep(AnimationStep step)
		{
			if (step != 0)
			{
				switch (step)
				{
				case AnimationStep.House:
					return _appleGroup;
				case AnimationStep.Mana:
					return _houseGroup;
				}
			}
			return _manaGroup;
		}

		[Cpp2IlInjected.Token(Token = "0x6003201")]
		[Cpp2IlInjected.Address(RVA = "0x129E310", Offset = "0x129CD10", VA = "0x18129E310")]
		private void AnimateIn()
		{
			//Discarded unreachable code: IL_00a1
			//IL_005e: Expected O, but got I4
			AnimationStep[] animationSteps = _animationSteps;
			if (animationSteps.Length != 0)
			{
				AnimationStep animationStep = animationSteps[0];
				if (animationStep != 0)
				{
					switch (animationStep)
					{
					}
				}
				_manaGroup.alpha = 1f;
			}
			RectTransform bubbleRectTransform = _bubbleRectTransform;
			Vector2 anchoredPosition = bubbleRectTransform.anchoredPosition;
			RectTransform bubbleRectTransform2 = _bubbleRectTransform;
			int num = 0;
			Vector2 anchoredPosition2 = bubbleRectTransform2.anchoredPosition;
			bubbleRectTransform.anchoredPosition = (Vector2)num;
			Vector2 anchoredPosition3 = _bubbleRectTransform.anchoredPosition;
			float bubbleFadeInDuration = _bubbleFadeInDuration;
			TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_bubbleGroup, 1f, bubbleFadeInDuration);
			TweenCallback action = delegate
			{
				int stepIndex = 0;
				Animate(stepIndex);
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = t.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6003202")]
		[Cpp2IlInjected.Address(RVA = "0x129E700", Offset = "0x129D100", VA = "0x18129E700")]
		private void AnimateOut()
		{
			//Discarded unreachable code: IL_0044
			//IL_0028: Expected F4, but got I4
			Vector2 anchoredPosition = _bubbleRectTransform.anchoredPosition;
			float bubbleFadeInDuration = _bubbleFadeInDuration;
			CanvasGroup bubbleGroup = _bubbleGroup;
			int num = 0;
			TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(bubbleGroup, (float)num, bubbleFadeInDuration);
			TweenCallback action = base.Hide;
			TweenerCore<float, float, FloatOptions> tweenerCore = t.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6003203")]
		[Cpp2IlInjected.Address(RVA = "0x129E4F0", Offset = "0x129CEF0", VA = "0x18129E4F0")]
		private void AnimateMana(int stepIndex)
		{
			//Discarded unreachable code: IL_00b4
			int num = 0;
			Sequence sequence = DOTween.Sequence();
			int num2 = 0;
			if (_manaAnimationRepeat > num2)
			{
				float manaPlusPauseAnimationDuration = _manaPlusPauseAnimationDuration;
				Sequence sequence2 = sequence.AppendInterval(manaPlusPauseAnimationDuration);
				float manaPlusBounceAnimationDuration = _manaPlusBounceAnimationDuration;
				int num3 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_manaPlusIcon, -4f, manaPlusBounceAnimationDuration, (byte)num3 != 0);
				Sequence sequence3 = sequence.Append(t);
				float manaPlusBounceAnimationDuration2 = _manaPlusBounceAnimationDuration;
				int num4 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_manaPlusIcon, -10f, manaPlusBounceAnimationDuration2, (byte)num4 != 0);
				Sequence sequence4 = sequence.Append(t2);
				num2++;
			}
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_001a
				NotEnoughManaInfo notEnoughManaInfo = this;
				int num5 = stepIndex;
				num5++;
				notEnoughManaInfo.Animate(num5);
			};
			Sequence sequence5 = sequence.OnComplete(action);
			Sequence sequence6 = sequence.Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6003204")]
		[Cpp2IlInjected.Address(RVA = "0x129E100", Offset = "0x129CB00", VA = "0x18129E100")]
		private void AnimateHouse(int stepIndex)
		{
			//Discarded unreachable code: IL_00b4
			int num = 0;
			Sequence sequence = DOTween.Sequence();
			int num2 = 0;
			if (_houseArrowAnimationRepeat > num2)
			{
				float houseArrowPauseAnimationDuration = _houseArrowPauseAnimationDuration;
				Sequence sequence2 = sequence.AppendInterval(houseArrowPauseAnimationDuration);
				float houseArrowBounceAnimationDuration = _houseArrowBounceAnimationDuration;
				int num3 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(_houseArrowIcon, -18f, houseArrowBounceAnimationDuration, (byte)num3 != 0);
				Sequence sequence3 = sequence.Append(t);
				float houseArrowBounceAnimationDuration2 = _houseArrowBounceAnimationDuration;
				int num4 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(_houseArrowIcon, -25f, houseArrowBounceAnimationDuration2, (byte)num4 != 0);
				Sequence sequence4 = sequence.Append(t2);
				num2++;
			}
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_001a
				NotEnoughManaInfo notEnoughManaInfo = this;
				int num5 = stepIndex;
				num5++;
				notEnoughManaInfo.Animate(num5);
			};
			Sequence sequence5 = sequence.OnComplete(action);
			Sequence sequence6 = sequence.Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6003205")]
		[Cpp2IlInjected.Address(RVA = "0x129E070", Offset = "0x129CA70", VA = "0x18129E070")]
		private void AnimateApple(int stepIndex)
		{
			//Discarded unreachable code: IL_0020
			int _003C_003E1__state = default(int);
			_003CAnimateAppleCoroutine_003Ed__40 _003CAnimateAppleCoroutine_003Ed__ = new _003CAnimateAppleCoroutine_003Ed__40(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAnimateAppleCoroutine_003Ed__._003C_003E4__this = this;
			_003CAnimateAppleCoroutine_003Ed__.stepIndex = stepIndex;
			Coroutine coroutine = StartCoroutine(_003CAnimateAppleCoroutine_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6003206")]
		[Cpp2IlInjected.Address(RVA = "0x129DFF0", Offset = "0x129C9F0", VA = "0x18129DFF0")]
		[IteratorStateMachine(typeof(_003CAnimateAppleCoroutine_003Ed__40))]
		private IEnumerator AnimateAppleCoroutine(int stepIndex)
		{
			int _003C_003E1__state = default(int);
			_003CAnimateAppleCoroutine_003Ed__40 _003CAnimateAppleCoroutine_003Ed__ = new _003CAnimateAppleCoroutine_003Ed__40(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAnimateAppleCoroutine_003Ed__._003C_003E4__this = this;
			_003CAnimateAppleCoroutine_003Ed__.stepIndex = stepIndex;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003207")]
		[Cpp2IlInjected.Address(RVA = "0x129F370", Offset = "0x129DD70", VA = "0x18129F370", Slot = "17")]
		protected override void UpdatePosition()
		{
			//Discarded unreachable code: IL_0089
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (targetObject != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Camera main = Camera.main;
				int num3 = 0;
				if (main != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					Camera main2 = Camera.main;
					Transform transform = _targetObject.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					Transform transform2 = base.transform;
					RectTransform rectTransform = _rectTransform;
					Vector2 anchoredPosition = rectTransform.anchoredPosition;
					RectTransform rectTransform2 = _rectTransform;
					int num5 = 0;
					Vector2 anchoredPosition2 = rectTransform2.anchoredPosition;
					rectTransform.anchoredPosition = (Vector2)num5;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003208")]
		[Cpp2IlInjected.Address(RVA = "0x129F340", Offset = "0x129DD40", VA = "0x18129F340")]
		private void OnEnable()
		{
			if (_animationPlaying)
			{
				int animationStepIndex = _animationStepIndex;
				Animate(animationStepIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003209")]
		[Cpp2IlInjected.Address(RVA = "0x129F530", Offset = "0x129DF30", VA = "0x18129F530")]
		public NotEnoughManaInfo()
		{
		}//IL_0035: Expected I4, but got I8
		//IL_0054: Expected I4, but got I8
		//IL_0073: Expected I4, but got I8
		//IL_0083: Expected I4, but got I8

	}
}
