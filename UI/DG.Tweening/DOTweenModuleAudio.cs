using System;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Audio;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public static class DOTweenModuleAudio
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x111E980", Offset = "0x111D380", VA = "0x18111E980")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_004d
			//IL_000f: Invalid comparison between I4 and F4
			//IL_003e: Expected F4, but got I4
			int num = default(int);
			if (0f > endValue || !(endValue <= 1f))
			{
				num = 0;
			}
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => target.volume);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_000d
				target.volume = x;
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, (float)num, duration);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x111ECF0", Offset = "0x111D6F0", VA = "0x18111ECF0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => target.pitch);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_000d
				target.pitch = x;
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x111F070", Offset = "0x111DA70", VA = "0x18111F070")]
		public unsafe static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			//Discarded unreachable code: IL_0046
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)delegate
			{
				AudioMixer audioMixer2 = target;
				int num = 0;
				string name2 = floatName;
				bool @float = audioMixer2.GetFloat(name2, out *(float*)num);
				throw new NullReferenceException();
			};
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_0018
				AudioMixer audioMixer = target;
				string name = floatName;
				bool flag = audioMixer.SetFloat(name, x);
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, endValue, duration);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x111E910", Offset = "0x111D310", VA = "0x18111E910")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return DOTween.Complete(target, withCallbacks);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x111EC20", Offset = "0x111D620", VA = "0x18111EC20")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return DOTween.Kill(target, complete);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x111EB40", Offset = "0x111D540", VA = "0x18111EB40")]
		public static int DOFlip(this AudioMixer target)
		{
			return DOTween.Flip(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x111EBA0", Offset = "0x111D5A0", VA = "0x18111EBA0")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return DOTween.Goto(target, to, andPlay);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x111EC90", Offset = "0x111D690", VA = "0x18111EC90")]
		public static int DOPause(this AudioMixer target)
		{
			return DOTween.Pause(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x111EF50", Offset = "0x111D950", VA = "0x18111EF50")]
		public static int DOPlay(this AudioMixer target)
		{
			return DOTween.Play(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x111EE90", Offset = "0x111D890", VA = "0x18111EE90")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return DOTween.PlayBackwards(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x111EEF0", Offset = "0x111D8F0", VA = "0x18111EEF0")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return DOTween.PlayForward(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x111EFB0", Offset = "0x111D9B0", VA = "0x18111EFB0")]
		public static int DORestart(this AudioMixer target)
		{
			return DOTween.Restart(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x111F010", Offset = "0x111DA10", VA = "0x18111F010")]
		public static int DORewind(this AudioMixer target)
		{
			return DOTween.Rewind(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x111F220", Offset = "0x111DC20", VA = "0x18111F220")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return DOTween.SmoothRewind(target);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x111F280", Offset = "0x111DC80", VA = "0x18111F280")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return DOTween.TogglePause(target);
		}
	}
}
