using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200028E")]
	public class ThrobberIcon : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200028F")]
		public struct ThrobberIconTransactionScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000B8E")]
			private readonly ThrobberIcon throbber;

			[Cpp2IlInjected.Token(Token = "0x600102E")]
			[Cpp2IlInjected.Address(RVA = "0x13501A0", Offset = "0x134EBA0", VA = "0x1813501A0")]
			public ThrobberIconTransactionScope(ThrobberIcon throbber)
			{
				//Discarded unreachable code: IL_000e
				this.throbber = throbber;
				throbber.Show();
			}

			[Cpp2IlInjected.Token(Token = "0x600102F")]
			[Cpp2IlInjected.Address(RVA = "0x1350180", Offset = "0x134EB80", VA = "0x181350180", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B80")]
		[SerializeField]
		private Animator _animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B81")]
		[SerializeField]
		private Transform _bigStar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B82")]
		[SerializeField]
		private Transform _starParticles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B83")]
		[SerializeField]
		private CanvasGroup _starParticlesCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B84")]
		[SerializeField]
		private CanvasGroup _mc_canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B85")]
		[SerializeField]
		[Header("Anim config")]
		private float _rotationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000B86")]
		[SerializeField]
		private Ease _rotationEase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B87")]
		[Space]
		[SerializeField]
		private Vector3 _endScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000B88")]
		[SerializeField]
		private float _scaleDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B89")]
		[SerializeField]
		private Ease _scaleEase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000B8A")]
		[Space]
		[SerializeField]
		[Space(15f)]
		[Range(0f, 1f)]
		private float _fadeInTimeRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000B8B")]
		[SerializeField]
		private AnimationCurve _fadeEase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000B8C")]
		[Space]
		[SerializeField]
		private float _showHideDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000B8D")]
		private Sequence _sequence;

		[Cpp2IlInjected.Token(Token = "0x6001021")]
		[Cpp2IlInjected.Address(RVA = "0x17EE700", Offset = "0x17ED100", VA = "0x1817EE700")]
		private void Awake()
		{
			InitSequence();
		}

		[Cpp2IlInjected.Token(Token = "0x6001022")]
		[Cpp2IlInjected.Address(RVA = "0x17EEB10", Offset = "0x17ED510", VA = "0x1817EEB10")]
		private void OnDestroy()
		{
			Sequence sequence = _sequence;
			int complete = 0;
			sequence.Kill((byte)complete != 0);
			CanvasGroup mc_canvasGroup = _mc_canvasGroup;
			int complete2 = 0;
			int num = DOTween.Kill(mc_canvasGroup, (byte)complete2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001023")]
		[Cpp2IlInjected.Address(RVA = "0x17EE840", Offset = "0x17ED240", VA = "0x1817EE840")]
		private void InitSequence()
		{
			//Discarded unreachable code: IL_0146
			//IL_0063: Expected F4, but got I4
			//IL_00b6: Expected F4, but got I4
			//IL_00c3: Expected O, but got F4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected F4, but got Unknown
			//IL_0128: Expected F4, but got I4
			Sequence sequence = _sequence;
			if (sequence != null)
			{
				int complete = 0;
				sequence.Kill((byte)complete != 0);
			}
			int num = 0;
			Sequence sequence2 = (_sequence = DOTween.Sequence());
			Transform bigStar = _bigStar;
			Sequence sequence3 = _sequence;
			Ease rotationEase = _rotationEase;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = t.SetEase(rotationEase);
			int num2 = 0;
			Sequence sequence4 = sequence3.Insert(num2, t2);
			float z = _endScale.z;
			Transform starParticles = _starParticles;
			Sequence sequence5 = _sequence;
			Ease scaleEase = _scaleEase;
			TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetEase(scaleEase);
			float rotationDuration = _rotationDuration;
			TweenerCore<Vector3, Vector3, VectorOptions> t5 = t4.SetDelay(rotationDuration);
			int num3 = 0;
			Sequence sequence6 = sequence5.Insert(num3, t5);
			float scaleDuration = ((ThrobberIcon)_fadeInTimeRatio)._scaleDuration;
			float fadeInDuration;
			float num4 = (fadeInDuration = /*Error near IL_00c4: Stack underflow*/* scaleDuration);
			CanvasGroup starParticlesCG = _starParticlesCG;
			Sequence sequence7 = _sequence;
			TweenerCore<float, float, FloatOptions> t6 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(starParticlesCG, 1f, num4);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0022
				//IL_001f: Expected F4, but got I4
				ThrobberIcon throbberIcon = this;
				float scaleDuration2 = throbberIcon._scaleDuration;
				CanvasGroup starParticlesCG2 = throbberIcon._starParticlesCG;
				int num6 = 0;
				TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(starParticlesCG2, (float)num6, scaleDuration2);
			};
			TweenerCore<float, float, FloatOptions> t7 = t6.OnComplete(action);
			float rotationDuration2 = _rotationDuration;
			TweenerCore<float, float, FloatOptions> t8 = t7.SetDelay(rotationDuration2);
			int num5 = 0;
			Sequence sequence8 = sequence7.Insert(num5, t8);
			Sequence sequence9 = _sequence.SetLoops(-1);
			Sequence sequence10 = _sequence.Pause();
		}

		[Cpp2IlInjected.Token(Token = "0x6001024")]
		[Cpp2IlInjected.Address(RVA = "0x17EEC00", Offset = "0x17ED600", VA = "0x1817EEC00")]
		public void Show()
		{
			//Discarded unreachable code: IL_0045
			float showHideDuration = _showHideDuration;
			base.gameObject.SetActive(value: true);
			Sequence sequence = _sequence.Play();
			CanvasGroup mc_canvasGroup = _mc_canvasGroup;
			int complete = 0;
			int num = mc_canvasGroup.DOKill((byte)complete != 0);
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_mc_canvasGroup, 1f, showHideDuration);
		}

		[Cpp2IlInjected.Token(Token = "0x6001025")]
		[Cpp2IlInjected.Address(RVA = "0x17EEC90", Offset = "0x17ED690", VA = "0x1817EEC90")]
		public void Show(float duration)
		{
			//Discarded unreachable code: IL_003d
			base.gameObject.SetActive(value: true);
			Sequence sequence = _sequence.Play();
			CanvasGroup mc_canvasGroup = _mc_canvasGroup;
			int complete = 0;
			int num = mc_canvasGroup.DOKill((byte)complete != 0);
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_mc_canvasGroup, 1f, duration);
		}

		[Cpp2IlInjected.Token(Token = "0x6001026")]
		[Cpp2IlInjected.Address(RVA = "0x17EE710", Offset = "0x17ED110", VA = "0x1817EE710")]
		public void Hide()
		{
			//IL_0011: Expected O, but got I4
			float showHideDuration = _showHideDuration;
			int num = 0;
			Hide(showHideDuration, (Action)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001027")]
		[Cpp2IlInjected.Address(RVA = "0x17EE830", Offset = "0x17ED230", VA = "0x1817EE830")]
		public void Hide(float duration)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			Hide(duration, (Action)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001028")]
		[Cpp2IlInjected.Address(RVA = "0x17EE820", Offset = "0x17ED220", VA = "0x1817EE820")]
		public void Hide(Action onComplete)
		{
			float showHideDuration = _showHideDuration;
			Hide(showHideDuration, onComplete);
		}

		[Cpp2IlInjected.Token(Token = "0x6001029")]
		[Cpp2IlInjected.Address(RVA = "0x17EE720", Offset = "0x17ED120", VA = "0x1817EE720")]
		public void Hide(float duration, Action onComplete)
		{
			//Discarded unreachable code: IL_003f
			//IL_0025: Expected F4, but got I4
			CanvasGroup mc_canvasGroup = _mc_canvasGroup;
			int num = 0;
			TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(mc_canvasGroup, (float)num, duration);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0039
				Sequence sequence = _sequence.Pause();
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				onComplete?.Invoke();
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = t.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x600102A")]
		[Cpp2IlInjected.Address(RVA = "0x17EEBC0", Offset = "0x17ED5C0", VA = "0x1817EEBC0")]
		public void Play()
		{
			Sequence sequence = _sequence.Play();
		}

		[Cpp2IlInjected.Token(Token = "0x600102B")]
		[Cpp2IlInjected.Address(RVA = "0x17EEB80", Offset = "0x17ED580", VA = "0x1817EEB80")]
		public void Pause()
		{
			Sequence sequence = _sequence.Pause();
		}

		[Cpp2IlInjected.Token(Token = "0x600102C")]
		[Cpp2IlInjected.Address(RVA = "0x17EED20", Offset = "0x17ED720", VA = "0x1817EED20")]
		public ThrobberIconTransactionScope TransactionScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600102D")]
		[Cpp2IlInjected.Address(RVA = "0x17EED50", Offset = "0x17ED750", VA = "0x1817EED50")]
		public unsafe ThrobberIcon()
		{
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			//IL_0021: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			ulong num = default(ulong);
			((Vector3*)(IntPtr)_endScale)->z = (long)num;
			_rotationDuration = 1.45f;
			_rotationEase = Ease.InOutExpo;
			_scaleDuration = 0.33f;
			_scaleEase = Ease.OutSine;
			_fadeInTimeRatio = 0.6f;
			_showHideDuration = 0.33f;
			base._002Ector();
		}
	}
}
