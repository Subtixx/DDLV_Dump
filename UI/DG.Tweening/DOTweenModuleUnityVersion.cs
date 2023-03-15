using System;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public static class DOTweenModuleUnityVersion
	{
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x1126DE0", Offset = "0x11257E0", VA = "0x181126DE0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
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

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x1126B80", Offset = "0x1125580", VA = "0x181126B80")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
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

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x1127440", Offset = "0x1125E40", VA = "0x181127440")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			if (t.active)
			{
				DOTweenCYInstruction.WaitForCompletion waitForCompletion = new DOTweenCYInstruction.WaitForCompletion(t);
			}
			Debugger.LogInvalidTween(t);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x1127740", Offset = "0x1126140", VA = "0x181127740")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			if (t.active)
			{
				DOTweenCYInstruction.WaitForRewind waitForRewind = new DOTweenCYInstruction.WaitForRewind(t);
			}
			Debugger.LogInvalidTween(t);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x11275C0", Offset = "0x1125FC0", VA = "0x1811275C0")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			if (t.active)
			{
				DOTweenCYInstruction.WaitForKill waitForKill = new DOTweenCYInstruction.WaitForKill(t);
			}
			Debugger.LogInvalidTween(t);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x11274F0", Offset = "0x1125EF0", VA = "0x1811274F0")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			if (t.active)
			{
				DOTweenCYInstruction.WaitForElapsedLoops waitForElapsedLoops = new DOTweenCYInstruction.WaitForElapsedLoops(t, elapsedLoops);
			}
			Debugger.LogInvalidTween(t);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x1127670", Offset = "0x1126070", VA = "0x181127670")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			if (t.active)
			{
				DOTweenCYInstruction.WaitForPosition waitForPosition = new DOTweenCYInstruction.WaitForPosition(t, position);
			}
			Debugger.LogInvalidTween(t);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x11277F0", Offset = "0x11261F0", VA = "0x1811277F0")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			if (t.active)
			{
				DOTweenCYInstruction.WaitForStart waitForStart = new DOTweenCYInstruction.WaitForStart(t);
			}
			Debugger.LogInvalidTween(t);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x1127020", Offset = "0x1125A20", VA = "0x181127020")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			bool flag = default(bool);
			if (flag)
			{
				DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
				{
					//Discarded unreachable code: IL_0016
					Material material2 = target;
					int nameID = propertyID;
					return material2.GetTextureOffset(nameID);
				};
				DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
				{
					//Discarded unreachable code: IL_0017
					Material material = target;
					int name = propertyID;
					material.SetTextureOffsetImpl(name, x);
				};
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
				return tweenerCore;
			}
			Debugger.LogMissingMaterialProperty(propertyID);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x1127230", Offset = "0x1125C30", VA = "0x181127230")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			bool flag = default(bool);
			if (flag)
			{
				DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
				{
					//Discarded unreachable code: IL_0016
					Material material2 = target;
					int nameID = propertyID;
					return material2.GetTextureScale(nameID);
				};
				DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
				{
					//Discarded unreachable code: IL_0017
					Material material = target;
					int name = propertyID;
					material.SetTextureScaleImpl(name, x);
				};
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
				return tweenerCore;
			}
			Debugger.LogMissingMaterialProperty(propertyID);
			throw new NullReferenceException();
		}
	}
}
