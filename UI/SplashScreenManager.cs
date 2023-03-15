using System;
using System.Collections;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl;
using Mdl.Ui;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x2000072")]
public class SplashScreenManager : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	[SerializeField]
	private Image _splashFirstItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	[SerializeField]
	private Image _splashSecondItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	[SerializeField]
	private ThrobberIcon _loadingThrobber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	[SerializeField]
	private Boot boot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	[SerializeField]
	private float _intervalSeconds = 1.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	[SerializeField]
	private float _fadeSeconds = 1.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	[SerializeField]
	private LoadingProgressBar _progress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Sequence _sequence;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private CpuBoostModeScope? _boostModeScope;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x15FEC90", Offset = "0x15FD690", VA = "0x1815FEC90")]
	private void Start()
	{
		//Discarded unreachable code: IL_0037
		//IL_0020: Expected O, but got I8
		GraphicSettingsData.SetUnityLogEnable(isEnable: false);
		CpuBoostModeScope.CpuBoostMode oldBoostMode = CpuBoostModeScope.Create(CpuBoostModeScope.CpuBoostMode.FastLoad).oldBoostMode;
		Boot boot = this.boot;
		ulong num = default(ulong);
		_boostModeScope = (CpuBoostModeScope?)(object)num;
		IEnumerator routine = boot.LoadMain();
		Coroutine coroutine = StartCoroutine(routine);
		StartAnimation();
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x15FEAC0", Offset = "0x15FD4C0", VA = "0x1815FEAC0")]
	private void StartAnimation()
	{
		//IL_0092: Expected F4, but got I4
		//IL_010a: Expected F4, but got I4
		Sequence sequence = _sequence;
		if (sequence != null)
		{
			int complete = 0;
			sequence.Kill((byte)complete != 0);
		}
		int num = 0;
		Sequence sequence2 = (_sequence = DOTween.Sequence());
		float intervalSeconds = _intervalSeconds;
		Sequence s = _sequence.AppendInterval(intervalSeconds);
		float fadeSeconds = _fadeSeconds;
		TweenerCore<Color, Color, ColorOptions> t = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(_splashFirstItem, 1f, fadeSeconds);
		Sequence s2 = s.Append(t);
		float intervalSeconds2 = _intervalSeconds;
		Sequence s3 = s2.AppendInterval(intervalSeconds2);
		float fadeSeconds2 = _fadeSeconds;
		Image splashFirstItem = _splashFirstItem;
		int num2 = 0;
		TweenerCore<Color, Color, ColorOptions> t2 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(splashFirstItem, (float)num2, fadeSeconds2);
		Sequence s4 = s3.Append(t2);
		float intervalSeconds3 = _intervalSeconds;
		Sequence s5 = s4.AppendInterval(intervalSeconds3);
		float fadeSeconds3 = _fadeSeconds;
		TweenerCore<Color, Color, ColorOptions> t3 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(_splashSecondItem, 1f, fadeSeconds3);
		Sequence s6 = s5.Append(t3);
		float intervalSeconds4 = _intervalSeconds;
		Sequence s7 = s6.AppendInterval(intervalSeconds4);
		float fadeSeconds4 = _fadeSeconds;
		Image splashSecondItem = _splashSecondItem;
		int num3 = 0;
		TweenerCore<Color, Color, ColorOptions> t4 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(splashSecondItem, (float)num3, fadeSeconds4);
		TweenCallback action = delegate
		{
			//Discarded unreachable code: IL_0048
			_loadingThrobber?.Show();
			_progress.gameObject.SetActive(value: true);
			Boot boot = this.boot;
			Func<IEnumerator> func = (Func<IEnumerator>)(object)(Func<TResult>)(() => _progress.AnimateToEndTask().AsIEnumerator());
			IEnumerator routine = boot.StartMain((Func<>)(object)func);
			Coroutine coroutine = StartCoroutine(routine);
		};
		TweenerCore<Color, Color, ColorOptions> t5 = t4.OnComplete(action);
		Sequence sequence3 = s7.Append(t5);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x15FE9D0", Offset = "0x15FD3D0", VA = "0x1815FE9D0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_0053
		//IL_0010: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_0052: Expected O, but got I8
		CpuBoostModeScope? boostModeScope = _boostModeScope;
		int num = 0;
		_boostModeScope = (CpuBoostModeScope?)(object)num;
		ThrobberIcon loadingThrobber = _loadingThrobber;
		int num2 = 0;
		if (loadingThrobber != (UnityEngine.Object)num2)
		{
			_loadingThrobber.Hide();
		}
		Sequence sequence = _sequence;
		if (sequence != null)
		{
			int complete = 0;
			sequence.Kill((byte)complete != 0);
		}
		_sequence = (Sequence)0;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x15FEF20", Offset = "0x15FD920", VA = "0x1815FEF20")]
	public SplashScreenManager()
	{
	}
}
