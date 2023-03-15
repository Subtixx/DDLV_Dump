using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BubbleAnimation : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	[SerializeField]
	protected CanvasGroup _canvasGroupContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[SerializeField]
	[Header("Animation Settings")]
	private Vector3 _offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[SerializeField]
	private Vector3 _offsetBeforeShow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	[SerializeField]
	private float _showAnimationDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[SerializeField]
	private bool _hasShowAnimation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	[SerializeField]
	private bool _useOriginalScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[SerializeField]
	private bool _useTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	[SerializeField]
	private float _delayBeforeHide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	[SerializeField]
	private float _hideDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	[SerializeField]
	private float _delayBeforeShow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private Sequence _showSequence;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private Sequence _hideSequence;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[HideInInspector]
	public unsafe Vector3 CurrentOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xA64BD0", Offset = "0xA635D0", VA = "0x180A64BD0")]
		[CompilerGenerated]
		get
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA64BF0", Offset = "0xA635F0", VA = "0x180A64BF0")]
		[CompilerGenerated]
		private set
		{
			//IL_000e: Expected native int or pointer, but got O
			float z = value.z;
			((Vector3*)(IntPtr)_003CCurrentOffset_003Ek__BackingField)->z = z;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xA64580", Offset = "0xA62F80", VA = "0x180A64580")]
	public unsafe void Show([Optional] Action onComplete, [Optional] Action onKill)
	{
		//IL_0057: Expected O, but got I4
		//IL_006b: Expected F4, but got I4
		//IL_0088: Expected native int or pointer, but got O
		//IL_01ad: Expected O, but got I4
		//IL_01d8: Expected O, but got I4
		if (!_hasShowAnimation)
		{
			return;
		}
		Transform transform = base.gameObject.transform;
		GameObject gameObject = base.gameObject;
		int num = 0;
		Transform transform2 = gameObject.transform;
		if (_useOriginalScale)
		{
		}
		transform2.localScale = (Vector3)num;
		CanvasGroup canvasGroupContent = _canvasGroupContent;
		int num2 = 0;
		canvasGroupContent.alpha = num2;
		Sequence hideSequence = _hideSequence;
		float z = _offsetBeforeShow.z;
		((Vector3*)(IntPtr)CurrentOffset)->z = z;
		if (hideSequence != null)
		{
			int complete = 0;
			hideSequence.Kill((byte)complete != 0);
		}
		Sequence showSequence = _showSequence;
		if (showSequence != null)
		{
			int complete2 = 0;
			showSequence.Kill((byte)complete2 != 0);
		}
		int num3 = 0;
		Sequence sequence = (_showSequence = DOTween.Sequence());
		float showAnimationDuration = _showAnimationDuration;
		CanvasGroup canvasGroupContent2 = _canvasGroupContent;
		Sequence showSequence2 = _showSequence;
		TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroupContent2, 1f, showAnimationDuration);
		float delayBeforeShow = _delayBeforeShow;
		TweenerCore<float, float, FloatOptions> t2 = t.SetDelay(delayBeforeShow);
		delayBeforeShow = showAnimationDuration;
		Sequence sequence2 = showSequence2.Insert(delayBeforeShow, t2);
		if (!_useTransform)
		{
			Sequence showSequence3 = _showSequence;
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_001b
				//IL_0015: Expected native int or pointer, but got O
				BubbleAnimation bubbleAnimation = this;
				float z2 = x.z;
				((Vector3*)(IntPtr)bubbleAnimation.CurrentOffset)->z = z2;
			};
			float delayBeforeShow2 = _delayBeforeShow;
			TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetDelay(delayBeforeShow2);
			TweenCallback action = delegate
			{
				onKill?.Invoke();
			};
			TweenerCore<Vector3, Vector3, VectorOptions> t5 = t4.OnKill(action);
			TweenCallback action2 = delegate
			{
				onComplete?.Invoke();
			};
			TweenerCore<Vector3, Vector3, VectorOptions> t6 = t5.OnComplete(action2);
			Sequence sequence3 = showSequence3.Insert(delayBeforeShow2, t6);
			return;
		}
		Transform transform3 = base.transform;
		int num4 = 0;
		base.transform.localPosition = (Vector3)num4;
		Sequence showSequence4 = _showSequence;
		int num5 = 0;
		Transform transform4 = base.transform;
		float showAnimationDuration2 = _showAnimationDuration;
		int num6 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> t7 = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMove(transform4, (Vector3)num5, showAnimationDuration2, (byte)num6 != 0);
		float delayBeforeShow3 = _delayBeforeShow;
		TweenerCore<Vector3, Vector3, VectorOptions> t8 = t7.SetDelay(delayBeforeShow3);
		TweenCallback action3 = delegate
		{
			onKill?.Invoke();
		};
		TweenerCore<Vector3, Vector3, VectorOptions> t9 = t8.OnKill(action3);
		TweenCallback action4 = delegate
		{
			onComplete?.Invoke();
		};
		TweenerCore<Vector3, Vector3, VectorOptions> t10 = t9.OnComplete(action4);
		Sequence sequence4 = showSequence4.Insert(delayBeforeShow3, t10);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xA640D0", Offset = "0xA62AD0", VA = "0x180A640D0")]
	public unsafe void Hide([Optional] Action onComplete)
	{
		//IL_0094: Expected F4, but got I4
		if (!_hasShowAnimation)
		{
			onComplete?.Invoke();
			return;
		}
		Sequence showSequence = _showSequence;
		if (showSequence != null)
		{
			int complete = 0;
			showSequence.Kill((byte)complete != 0);
		}
		Sequence hideSequence = _hideSequence;
		if (hideSequence != null)
		{
			int complete2 = 0;
			hideSequence.Kill((byte)complete2 != 0);
		}
		int num = 0;
		Sequence sequence = (_hideSequence = DOTween.Sequence());
		float hideDuration = _hideDuration;
		CanvasGroup canvasGroupContent = _canvasGroupContent;
		Sequence hideSequence2 = _hideSequence;
		int num2 = 0;
		TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroupContent, (float)num2, hideDuration);
		float delayBeforeHide = _delayBeforeHide;
		TweenerCore<float, float, FloatOptions> t2 = t.SetDelay(delayBeforeHide);
		delayBeforeHide = hideDuration;
		Sequence sequence2 = hideSequence2.Insert(delayBeforeHide, t2);
		float delayBeforeHide2 = default(float);
		if (!_useTransform)
		{
			Sequence hideSequence3 = _hideSequence;
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_001b
				//IL_0015: Expected native int or pointer, but got O
				BubbleAnimation bubbleAnimation = this;
				float z3 = x.z;
				((Vector3*)(IntPtr)bubbleAnimation.CurrentOffset)->z = z3;
			};
			float z = _offsetBeforeShow.z;
			delayBeforeHide2 = _delayBeforeHide;
			TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetDelay(delayBeforeHide2);
			TweenCallback action = delegate
			{
				onComplete?.Invoke();
			};
			TweenerCore<Vector3, Vector3, VectorOptions> t5 = t4.OnComplete(action);
			Sequence sequence3 = hideSequence3.Insert(delayBeforeHide2, t5);
		}
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		TweenerCore<Vector3, Vector3, VectorOptions> t6 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
		TweenerCore<Vector3, Vector3, VectorOptions> t7 = t6.SetDelay(delayBeforeHide2);
		TweenCallback action2 = delegate
		{
			onComplete?.Invoke();
		};
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t7.OnComplete(action2);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0xA64540", Offset = "0xA62F40", VA = "0x180A64540")]
	private void OnDestroy()
	{
		Sequence showSequence = _showSequence;
		if (showSequence != null)
		{
			int complete = 0;
			showSequence.Kill((byte)complete != 0);
		}
		Sequence hideSequence = _hideSequence;
		if (hideSequence != null)
		{
			int complete2 = 0;
			hideSequence.Kill((byte)complete2 != 0);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xA64B80", Offset = "0xA63580", VA = "0x180A64B80")]
	public unsafe BubbleAnimation()
	{
		//IL_000c: Expected F4, but got I8
		//IL_0007: Expected native int or pointer, but got O
		ulong num = default(ulong);
		((Vector3*)(IntPtr)_offsetBeforeShow)->z = (long)num;
		_showAnimationDuration = 0.25f;
		_hasShowAnimation = true;
		_hideDuration = 0.15f;
		base._002Ector();
	}
}
