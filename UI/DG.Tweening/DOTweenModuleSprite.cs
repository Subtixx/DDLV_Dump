using System;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	public static class DOTweenModuleSprite
	{
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x1121A60", Offset = "0x1120460", VA = "0x181121A60")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				SpriteRenderer spriteRenderer = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x1121C10", Offset = "0x1120610", VA = "0x181121C10")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				SpriteRenderer spriteRenderer = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTween.ToAlpha((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x1121DB0", Offset = "0x11207B0", VA = "0x181121DB0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			//Discarded unreachable code: IL_0070
			int num = 0;
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int length = colorKeys.Length;
			int num2 = 0;
			if (length > 0)
			{
				int num3 = 0;
				int length2 = colorKeys.Length;
				if (num2 == 0)
				{
				}
				int num4 = length - 1;
				if (num2 == num4)
				{
					int includeLoops = 0;
					float num5 = sequence.Duration((byte)includeLoops != 0);
				}
				if (num2 == 0)
				{
				}
				TweenerCore<Color, Color, ColorOptions> t = default(TweenerCore<Color, Color, ColorOptions>);
				TweenerCore<Color, Color, ColorOptions> t2 = t.SetEase(Ease.Linear);
				Sequence sequence2 = sequence.Append(t2);
				num2++;
			}
			Sequence sequence3 = sequence.SetTarget(target);
			return sequence;
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x1121810", Offset = "0x1120210", VA = "0x181121810")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			//IL_001d: Expected O, but got I4
			SpriteRenderer spriteRenderer = target;
			int num = 0;
			Color to = (Color)num;
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_000f
				Color color = to;
				SpriteRenderer spriteRenderer3 = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<, , > t = ((TweenerCore<, , >)(object)tweenerCore).Blendable<Color, Color, ColorOptions>();
			SpriteRenderer spriteRenderer2 = target;
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ((TweenerCore<Color, Color, ColorOptions>)(object)t).SetTarget(spriteRenderer2);
			throw new NullReferenceException();
		}
	}
}
