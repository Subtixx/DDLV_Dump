using System;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public static class DOTweenModulePhysics2D
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x111FAF0", Offset = "0x111E4F0", VA = "0x18111FAF0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0034
			//IL_002f: Expected O, but got I4
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => CS_0024_003C_003E8__locals0.target.position);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)new DOSetter<T>(((Rigidbody2D)(object)CS_0024_003C_003E8__locals0).MovePosition);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = ((Tweener)tweenerCore).SetTarget((object)snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x111F750", Offset = "0x111E150", VA = "0x18111F750")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0037
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => CS_0024_003C_003E8__locals0.target.position);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)new DOSetter<T>(((Rigidbody2D)(object)CS_0024_003C_003E8__locals0).MovePosition);
			int num = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.X, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x111F920", Offset = "0x111E320", VA = "0x18111F920")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0042
			//IL_0032: Expected O, but got I4
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => CS_0024_003C_003E8__locals0.target.position);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)new DOSetter<T>(((Rigidbody2D)(object)CS_0024_003C_003E8__locals0).MovePosition);
			int num = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, (Vector2)num, duration);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Y, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x111FCB0", Offset = "0x111E6B0", VA = "0x18111FCB0")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			//Discarded unreachable code: IL_003f
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => CS_0024_003C_003E8__locals0.target.rotation);
			DOSetter<float> dOSetter = (DOSetter<float>)(object)new DOSetter<T>(((Rigidbody2D)(object)CS_0024_003C_003E8__locals0).MoveRotation);
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTween.To((DOGetter<>)(object)dOGetter, (DOSetter<>)(object)dOSetter, duration, duration);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x111F2E0", Offset = "0x111DCE0", VA = "0x18111F2E0")]
		public unsafe static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0121
			//IL_0020: Expected F4, but got I4
			//IL_001b: Expected native int or pointer, but got O
			((Vector2*)(IntPtr)endValue)->y = 0f;
			float startPosY = 0f;
			float offsetY = -1f;
			bool offsetYSet = false;
			int num = 0;
			Sequence s = DOTween.Sequence();
			DOGetter<Vector2> dOGetter = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.position);
			DOSetter<Vector2> dOSetter = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.position = x;
			};
			Tweener relative = default(Tweener);
			Tweener tweener = relative.SetRelative();
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0014
				//IL_0013: Expected F4, but got I4
				Vector2 position2 = target.position;
				startPosY = 0f;
			};
			Tweener t = default(Tweener);
			Tween yTween = t.OnStart(tweenCallback);
			Sequence s2 = s;
			DOGetter<Vector2> dOGetter2 = (DOGetter<Vector2>)(object)(DOGetter<T>)(() => target.position);
			DOSetter<Vector2> dOSetter2 = (DOSetter<Vector2>)(object)(DOSetter<T>)delegate(Vector2 x)
			{
				//Discarded unreachable code: IL_000d
				target.position = x;
			};
			Tweener t2 = default(Tweener);
			Sequence s3 = s2.Append(t2);
			Tween t3 = yTween;
			Sequence t4 = s3.Join(t3);
			Rigidbody2D rigidbody2D = target;
			Sequence t5 = t4.SetTarget(rigidbody2D);
			Ease defaultEaseType = DOTween.defaultEaseType;
			Sequence sequence = t5.SetEase(defaultEaseType);
			Tween t6 = yTween;
			TweenCallback tweenCallback2 = delegate
			{
				//Discarded unreachable code: IL_0067
				//IL_005c: Expected F4, but got I4
				if (!offsetYSet)
				{
					Sequence sequence2 = s;
					offsetYSet = true;
					offsetY = endValue.y;
				}
				Vector2 position = target.position;
				Tween t7 = yTween;
				float to = offsetY;
				float lifetimePercentage = t7.ElapsedPercentage();
				float num2 = DOVirtual.EasedValue(0f, to, lifetimePercentage, Ease.OutQuad);
				Rigidbody2D rigidbody2D2 = target;
			};
			Tween tween = t6.OnUpdate(tweenCallback2);
			return s;
		}
	}
}
