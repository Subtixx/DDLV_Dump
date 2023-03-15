using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	public static class DOTweenModulePhysics
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x1121020", Offset = "0x111FA20", VA = "0x181121020")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0041
			//IL_003c: Expected O, but got I4
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MovePosition);
			float z = endValue.z;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, snapping).SetTarget(snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x1120A80", Offset = "0x111F480", VA = "0x181120A80")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MovePosition);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.X, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x1120C60", Offset = "0x111F660", VA = "0x181120C60")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MovePosition);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Y, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x1120E40", Offset = "0x111F840", VA = "0x181120E40")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MovePosition);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Tweener tweener = TweenSettingsExtensions.SetOptions((TweenerCore<, , >)(object)tweenerCore, AxisConstraint.Z, snapping);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x1121650", Offset = "0x1120050", VA = "0x181121650")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			//Discarded unreachable code: IL_003e
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.target = target;
			DOGetter<Quaternion> dOGetter = (DOGetter<Quaternion>)(object)(DOGetter<T>)delegate
			{
				throw new NullReferenceException();
			};
			DOSetter<Quaternion> dOSetter = (DOSetter<Quaternion>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MoveRotation);
			float z = endValue.z;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = tweenerCore.SetTarget(dOSetter);
			return tweenerCore;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x1120830", Offset = "0x111F230", VA = "0x181120830")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x111FE50", Offset = "0x111E850", VA = "0x18111FE50")]
		public unsafe static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			//Discarded unreachable code: IL_0189
			//IL_001b: Expected native int or pointer, but got O
			//IL_0034: Expected F4, but got I4
			float z = endValue.z;
			Vector3 endValue2 = default(Vector3);
			((Vector3*)(IntPtr)endValue2)->z = z;
			float offsetY = -1f;
			int num = 0;
			float startPosY = num;
			bool offsetYSet = (byte)num != 0;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector6 = default(Vector3);
				float z6 = vector6.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter = (DOSetter<Vector3>)(object)new DOSetter<T>(target.MovePosition);
			Tweener t = default(Tweener);
			Tweener tweener = t.SetEase(Ease.OutQuad).SetRelative();
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0016
				Rigidbody rigidbody4 = target;
				Vector3 vector5 = default(Vector3);
				startPosY = vector5.y;
			};
			Tweener t2 = default(Tweener);
			Tween yTween = t2.OnStart(tweenCallback);
			Sequence s2 = s;
			DOGetter<Vector3> dOGetter2 = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector4 = default(Vector3);
				float z5 = vector4.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter2 = (DOSetter<Vector3>)(object)new DOSetter<T>(target.MovePosition);
			Vector3 vector = endValue2;
			Tweener t3 = default(Tweener);
			Tweener t4 = t3.SetEase(Ease.Linear);
			Sequence s3 = s2.Append(t4);
			DOGetter<Vector3> dOGetter3 = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector3 = default(Vector3);
				float z4 = vector3.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> dOSetter3 = (DOSetter<Vector3>)(object)new DOSetter<T>(target.MovePosition);
			float z2 = endValue2.z;
			Tweener t5 = default(Tweener);
			Tweener t6 = t5.SetEase(Ease.Linear);
			Sequence s4 = s3.Join(t6);
			Tween t7 = yTween;
			Sequence t8 = s4.Join(t7);
			Rigidbody rigidbody = target;
			Sequence t9 = t8.SetTarget(rigidbody);
			Ease defaultEaseType = DOTween.defaultEaseType;
			Sequence sequence = t9.SetEase(defaultEaseType);
			Tween t10 = yTween;
			TweenCallback tweenCallback2 = delegate
			{
				//Discarded unreachable code: IL_006a
				//IL_005f: Expected F4, but got I4
				if (!offsetYSet)
				{
					Sequence sequence2 = s;
					offsetYSet = true;
					offsetY = endValue2.y;
				}
				Rigidbody rigidbody2 = target;
				Tween t11 = yTween;
				float to = offsetY;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				float lifetimePercentage = t11.ElapsedPercentage();
				float num3 = DOVirtual.EasedValue(0f, to, lifetimePercentage, Ease.OutQuad);
				Rigidbody rigidbody3 = target;
			};
			Tween tween = t10.OnUpdate(tweenCallback2);
			return s;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x11211F0", Offset = "0x111FBF0", VA = "0x1811211F0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			//Discarded unreachable code: IL_004a
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.target = target;
			int num = 0;
			ABSTweenPlugin<Vector3, Path, PathOptions> cpp2il__autoParamName__idx_ = (ABSTweenPlugin<Vector3, Path, PathOptions>)(object)PathPlugin.Get();
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> cpp2il__autoParamName__idx_2 = (DOSetter<Vector3>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MovePosition);
			Path endValue = default(Path);
			return ((TweenerCore<Vector3, Path, PathOptions>)(object)DOTween.To<Vector3, Path, PathOptions>((ABSTweenPlugin<, , >)(object)cpp2il__autoParamName__idx_, (DOGetter<>)(object)dOGetter, (DOSetter<>)(object)cpp2il__autoParamName__idx_2, endValue, duration)).SetTarget(dOGetter).SetUpdate(UpdateType.Fixed);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x1120580", Offset = "0x111EF80", VA = "0x181120580")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			//Discarded unreachable code: IL_0054
			Transform transform = default(Transform);
			Transform trans = transform;
			int num = 0;
			ABSTweenPlugin<Vector3, Path, PathOptions> cpp2il__autoParamName__idx_ = (ABSTweenPlugin<Vector3, Path, PathOptions>)(object)PathPlugin.Get();
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> cpp2il__autoParamName__idx_2 = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_0040
				//IL_001e: Expected O, but got I4
				Transform transform2 = trans;
				Rigidbody rigidbody = target;
				Transform parent = transform2.parent;
				int num2 = 0;
				if (parent == (UnityEngine.Object)num2)
				{
				}
				Transform parent2 = trans.parent;
				float z = x.z;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
			};
			Path endValue = default(Path);
			return ((TweenerCore<Vector3, Path, PathOptions>)(object)DOTween.To<Vector3, Path, PathOptions>((ABSTweenPlugin<, , >)(object)cpp2il__autoParamName__idx_, (DOGetter<>)(object)dOGetter, (DOSetter<>)(object)cpp2il__autoParamName__idx_2, endValue, duration)).SetTarget(dOGetter).SetUpdate(UpdateType.Fixed);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x1121470", Offset = "0x111FE70", VA = "0x181121470")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			//Discarded unreachable code: IL_0047
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.target = target;
			int num = 0;
			ABSTweenPlugin<Vector3, Path, PathOptions> cpp2il__autoParamName__idx_ = (ABSTweenPlugin<Vector3, Path, PathOptions>)(object)PathPlugin.Get();
			DOGetter<Vector3> dOGetter = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> cpp2il__autoParamName__idx_2 = (DOSetter<Vector3>)(object)new DOSetter<T>(((Rigidbody)(object)CS_0024_003C_003E8__locals0).MovePosition);
			return ((TweenerCore<Vector3, Path, PathOptions>)(object)DOTween.To<Vector3, Path, PathOptions>((ABSTweenPlugin<, , >)(object)cpp2il__autoParamName__idx_, (DOGetter<>)(object)dOGetter, (DOSetter<>)(object)cpp2il__autoParamName__idx_2, path, duration)).SetTarget(dOGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x1120380", Offset = "0x111ED80", VA = "0x181120380")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			//Discarded unreachable code: IL_0068
			Transform trans = target.transform;
			int num = 0;
			ABSTweenPlugin<Vector3, Path, PathOptions> cpp2il__autoParamName__idx_ = (ABSTweenPlugin<Vector3, Path, PathOptions>)(object)PathPlugin.Get();
			DOGetter<Vector3> cpp2il__autoParamName__idx_2 = (DOGetter<Vector3>)(object)(DOGetter<T>)delegate
			{
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				throw new NullReferenceException();
			};
			DOSetter<Vector3> cpp2il__autoParamName__idx_3 = (DOSetter<Vector3>)(object)(DOSetter<T>)delegate(Vector3 x)
			{
				//Discarded unreachable code: IL_0040
				//IL_001e: Expected O, but got I4
				Transform transform = trans;
				Rigidbody rigidbody2 = target;
				Transform parent = transform.parent;
				int num2 = 0;
				if (parent == (UnityEngine.Object)num2)
				{
				}
				Transform parent2 = trans.parent;
				float z = x.z;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
			};
			TweenerCore<, , > t = DOTween.To<Vector3, Path, PathOptions>((ABSTweenPlugin<, , >)(object)cpp2il__autoParamName__idx_, (DOGetter<>)(object)cpp2il__autoParamName__idx_2, (DOSetter<>)(object)cpp2il__autoParamName__idx_3, path, duration);
			Rigidbody rigidbody = target;
			return ((TweenerCore<Vector3, Path, PathOptions>)(object)t).SetTarget(rigidbody);
		}
	}
}
