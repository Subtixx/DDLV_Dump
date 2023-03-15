using System;
using System.Runtime.InteropServices;
using System.Xml;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;
using glPlayFab;
using UnityEngine;
using UnityEngine.UI;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	public static class DOTweenModuleUI
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		public static class Utils
		{
			[Cpp2IlInjected.Token(Token = "0x6000838")]
			[Cpp2IlInjected.Address(RVA = "0xA276D0", Offset = "0xA260D0", VA = "0x180A276D0")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				//Discarded unreachable code: IL_002a
				int num = 0;
				Rect rect = to.rect;
				Rect rect2 = to.rect;
				Rect rect3 = to.rect;
				Rect rect4 = to.rect;
				return to.anchoredPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x1124440", Offset = "0x1122E40", VA = "0x181124440")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => target.alpha);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_000d
				target.alpha = x;
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x1123A60", Offset = "0x1122460", VA = "0x181123A60")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Graphic graphic = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x11242A0", Offset = "0x1122CA0", VA = "0x1811242A0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Graphic graphic = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTween.ToAlpha((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x1123700", Offset = "0x1122100", VA = "0x181123700")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Image image = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x1123DC0", Offset = "0x11227C0", VA = "0x181123DC0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Image image = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTween.ToAlpha((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x11245E0", Offset = "0x1122FE0", VA = "0x1811245E0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_004f
			//IL_0017: Invalid comparison between I4 and F4
			if (endValue > 1f || !(0f <= endValue))
			{
			}
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => target.m_FillAmount);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_000d
				target.fillAmount = x;
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, 1f, duration);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x1124960", Offset = "0x1123360", VA = "0x181124960")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
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

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x11247A0", Offset = "0x11231A0", VA = "0x1811247A0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
			{
				float flexibleWidth = target.flexibleWidth;
				float flexibleHeight = target.flexibleHeight;
				throw new NullReferenceException();
			};
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0014
				LayoutElement layoutElement = target;
				bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)target).DtdValidation;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x11251D0", Offset = "0x1123BD0", VA = "0x1811251D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
			{
				float minWidth = target.minWidth;
				float minHeight = target.minHeight;
				throw new NullReferenceException();
			};
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0014
				LayoutElement layoutElement = target;
				bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)target).DtdValidation;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x1125A70", Offset = "0x1124470", VA = "0x181125A70")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
			{
				float preferredWidth = target.preferredWidth;
				float preferredHeight = target.preferredHeight;
				throw new NullReferenceException();
			};
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0014
				LayoutElement layoutElement = target;
				bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)target).DtdValidation;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x11238B0", Offset = "0x11222B0", VA = "0x1811238B0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Outline outline = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x1124100", Offset = "0x1122B00", VA = "0x181124100")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Outline outline = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTween.ToAlpha((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x1125E30", Offset = "0x1124830", VA = "0x181125E30")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
			{
				Outline outline = target;
				throw new NullReferenceException();
			};
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.effectDistance = x;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x1122E50", Offset = "0x1121850", VA = "0x181122E50")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchoredPosition);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchoredPosition = x;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x1122AB0", Offset = "0x11214B0", VA = "0x181122AB0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0037
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchoredPosition);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchoredPosition = x;
			};
			int num = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.X, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x1122C80", Offset = "0x1121680", VA = "0x181122C80")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0042
			//IL_0032: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchoredPosition);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchoredPosition = x;
			};
			int num = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, (Vector2)num, duration);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Y, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x11228F0", Offset = "0x11212F0", VA = "0x1811228F0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0041
			//IL_003c: Expected O, but got I4
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z3 = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_000f
				RectTransform rectTransform = target;
				float z2 = x.z;
			};
			float z = endValue.z;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, snapping).SetTarget(snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x1122370", Offset = "0x1120D70", VA = "0x181122370")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0035
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_000f
				RectTransform rectTransform = target;
				float z = x.z;
			};
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.X, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x1122540", Offset = "0x1120F40", VA = "0x181122540")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0035
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_000f
				RectTransform rectTransform = target;
				float z = x.z;
			};
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Y, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x1122720", Offset = "0x1121120", VA = "0x181122720")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0035
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_000f
				RectTransform rectTransform = target;
				float z = x.z;
			};
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Z, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x1121FF0", Offset = "0x11209F0", VA = "0x181121FF0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchorMax);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchorMax = x;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x11221B0", Offset = "0x1120BB0", VA = "0x1811221B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchorMin);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchorMin = x;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x11258D0", Offset = "0x11242D0", VA = "0x1811258D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.pivot);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.pivot = x;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x1125550", Offset = "0x1123F50", VA = "0x181125550")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003b
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.pivot);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.pivot = x;
			};
			int num = 0;
			int num2 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.X, (byte)num2 != 0);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x1125710", Offset = "0x1124110", VA = "0x181125710")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_0046
			//IL_0032: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.pivot);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.pivot = x;
			};
			int num = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, (Vector2)num, duration);
			int num2 = 0;
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Y, (byte)num2 != 0);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x1126410", Offset = "0x1124E10", VA = "0x181126410")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.sizeDelta);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.sizeDelta = x;
			};
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x1125C30", Offset = "0x1124630", VA = "0x181125C30")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				int num2 = 0;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				RectTransform rectTransform2 = target;
			};
			int num = 0;
			RectTransform rectTransform = target;
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t = default(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions>);
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> tweenerCore = t.SetTarget(rectTransform);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x1125FD0", Offset = "0x11249D0", VA = "0x181125FD0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				int num = 0;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				RectTransform rectTransform2 = target;
			};
			RectTransform rectTransform = target;
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t = default(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions>);
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> tweenerCore = t.SetTarget(rectTransform).SetSpecialStartupMode(SpecialStartupMode.SetShake);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x11261E0", Offset = "0x1124BE0", VA = "0x1811261E0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				int num2 = 0;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				RectTransform rectTransform2 = target;
			};
			int num = 0;
			RectTransform rectTransform = target;
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t = default(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions>);
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> tweenerCore = t.SetTarget(rectTransform).SetSpecialStartupMode(SpecialStartupMode.SetShake);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x1124D70", Offset = "0x1123770", VA = "0x181124D70")]
		public unsafe static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_010d
			//IL_0020: Expected F4, but got I4
			//IL_001b: Expected native int or pointer, but got O
			//IL_0034: Expected F4, but got I4
			((Vector2*)(IntPtr)endValue)->y = 0f;
			float offsetY = -1f;
			int num = 0;
			float startPosY = num;
			bool offsetYSet = (byte)num != 0;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchoredPosition);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchoredPosition = x;
			};
			Tweener relative = default(Tweener);
			Tweener tweener = relative.SetRelative();
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0014
				//IL_0013: Expected F4, but got I4
				Vector2 anchoredPosition2 = target.anchoredPosition;
				startPosY = 0f;
			};
			Tweener t = default(Tweener);
			Tweener t2 = t.OnStart(tweenCallback);
			Sequence s2 = s;
			DOGetter<Vector2> dOGetter2 = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.anchoredPosition);
			DOSetter<Vector2> dOSetter2 = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.anchoredPosition = x;
			};
			Tweener t3 = default(Tweener);
			Sequence t4 = s2.Append(t3).Join(t2);
			RectTransform rectTransform = target;
			Sequence t5 = t4.SetTarget(rectTransform);
			Ease defaultEaseType = DOTween.defaultEaseType;
			Sequence sequence = t5.SetEase(defaultEaseType);
			Sequence t6 = s;
			TweenCallback tweenCallback2 = delegate
			{
				//Discarded unreachable code: IL_0068
				//IL_0059: Expected F4, but got I4
				if (!offsetYSet)
				{
					Sequence sequence3 = s;
					offsetYSet = true;
					offsetY = endValue.y;
				}
				Vector2 anchoredPosition = target.anchoredPosition;
				Sequence t7 = s;
				float to = offsetY;
				float lifetimePercentage = t7.ElapsedDirectionalPercentage();
				float num3 = DOVirtual.EasedValue(0f, to, lifetimePercentage, Ease.OutQuad);
				target.anchoredPosition = anchoredPosition;
			};
			Sequence sequence2 = t6.OnUpdate(tweenCallback2);
			return s;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x1125390", Offset = "0x1123D90", VA = "0x181125390")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0039
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)delegate
			{
				float horizontalNormalizedPosition = target.horizontalNormalizedPosition;
				float verticalNormalizedPosition = target.verticalNormalizedPosition;
				throw new NullReferenceException();
			};
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_000f
				ScrollRect scrollRect2 = target;
				ScrollRect scrollRect3 = target;
			};
			ScrollRect scrollRect = target;
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			return ((Tweener)t).SetTarget((object)scrollRect);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1124BB0", Offset = "0x11235B0", VA = "0x181124BB0")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_004a
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => target.horizontalNormalizedPosition);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_000d
				target.horizontalNormalizedPosition = x;
			};
			Tweener t = TweenSettingsExtensions.SetOptions(DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration), snapping);
			ScrollRect scrollRect = target;
			return t.SetTarget(scrollRect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x11269C0", Offset = "0x11253C0", VA = "0x1811269C0")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_004a
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => target.verticalNormalizedPosition);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
			{
				//Discarded unreachable code: IL_000d
				target.verticalNormalizedPosition = x;
			};
			Tweener t = TweenSettingsExtensions.SetOptions(DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration), snapping);
			ScrollRect scrollRect = target;
			return t.SetTarget(scrollRect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x1126800", Offset = "0x1125200", VA = "0x181126800")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0045
			//IL_0040: Expected O, but got I4
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)delegate
			{
				string contentType2 = ((IOpenIdAPI)target).ContentType;
				throw new NullReferenceException();
			};
			DOSetter<float> dOSetter = (DOSetter<float>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_000d
				string contentType = ((IOpenIdAPI)target).ContentType;
			};
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, snapping).SetTarget(snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x1123C10", Offset = "0x1122610", VA = "0x181123C10")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			//Discarded unreachable code: IL_0034
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Text text = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x1123F60", Offset = "0x1122960", VA = "0x181123F60")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Text text = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTween.ToAlpha((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x11265D0", Offset = "0x1124FD0", VA = "0x1811265D0")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			//Discarded unreachable code: IL_0050
			//IL_001e: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			if (endValue == null)
			{
				int num = 0;
				Debugger.LogWarning("You can't pass a NULL string to DOText: an empty string will be used instead to avoid errors", (Tween)num);
			}
			DOGetter<string> dOGetter = (DOGetter<string>)(object)(DOGetter<T>)delegate
			{
				bool dtdValidation2 = ((System.Xml.IDtdParserAdapterWithValidation)target).DtdValidation;
				throw new NullReferenceException();
			};
			DOSetter<string> dOSetter = (DOSetter<string>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_000d
				bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)target).DtdValidation;
			};
			TweenerCore<string, string, StringOptions> result = (TweenerCore<string, string, StringOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, endValue, duration);
			Tweener t = default(Tweener);
			Tweener tweener = t.SetTarget(richTextEnabled);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x1123010", Offset = "0x1121A10", VA = "0x181123010")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			//IL_001d: Expected O, but got I4
			Graphic graphic = target;
			int num = 0;
			Color to = (Color)num;
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Graphic graphic3 = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<, , > t = ((TweenerCore<, , >)(object)tweenerCore).Blendable<Color, Color, ColorOptions>();
			Graphic graphic2 = target;
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ((TweenerCore<Color, Color, ColorOptions>)(object)t).SetTarget(graphic2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x1123260", Offset = "0x1121C60", VA = "0x181123260")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			//IL_001d: Expected O, but got I4
			Image image = target;
			int num = 0;
			Color to = (Color)num;
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Image image3 = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<, , > t = ((TweenerCore<, , >)(object)tweenerCore).Blendable<Color, Color, ColorOptions>();
			Image image2 = target;
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ((TweenerCore<Color, Color, ColorOptions>)(object)t).SetTarget(image2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x11234B0", Offset = "0x1121EB0", VA = "0x1811234B0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			//IL_001d: Expected O, but got I4
			Text text = target;
			int num = 0;
			Color to = (Color)num;
			DOGetter<Color> dOGetter = (DOGetter<Color>)(object)(DOGetter<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			DOSetter<Color> dOSetter = (DOSetter<Color>)(object)(DOSetter<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Text text3 = target;
			};
			TweenerCore<Color, Color, ColorOptions> tweenerCore = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<, , > t = ((TweenerCore<, , >)(object)tweenerCore).Blendable<Color, Color, ColorOptions>();
			Text text2 = target;
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ((TweenerCore<Color, Color, ColorOptions>)(object)t).SetTarget(text2);
			throw new NullReferenceException();
		}
	}
}
