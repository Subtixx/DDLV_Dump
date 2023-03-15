using System;
using System.Reflection;
using Cpp2IlInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Scripting;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public static class DOTweenModuleUtils
	{
		[Cpp2IlInjected.Token(Token = "0x2000161")]
		public static class Physics
		{
			[Cpp2IlInjected.Token(Token = "0x60008D0")]
			[Cpp2IlInjected.Address(RVA = "0xA16610", Offset = "0xA15010", VA = "0x180A16610")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
				if (!options.isRigidbody)
				{
					return;
				}
				object target = t.target;
				int num = 0;
				if (target != null)
				{
					int num2 = 0;
					if (target != null)
					{
						throw new NullReferenceException();
					}
				}
				throw new InvalidCastException();
			}

			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0xA16510", Offset = "0xA14F10", VA = "0x180A16510")]
			public static bool HasRigidbody2D(Component target)
			{
				//Discarded unreachable code: IL_0011
				//IL_0010: Expected O, but got I4
				Rigidbody2D component = target.GetComponent<Rigidbody2D>();
				int num = 0;
				return component != (UnityEngine.Object)num;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0xA16590", Offset = "0xA14F90", VA = "0x180A16590")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				//Discarded unreachable code: IL_0011
				//IL_0010: Expected O, but got I4
				Rigidbody component = target.GetComponent<Rigidbody>();
				int num = 0;
				return component != (UnityEngine.Object)num;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0xA163F0", Offset = "0xA14DF0", VA = "0x180A163F0")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				//IL_0014: Expected O, but got I4
				if (tweenRigidbody)
				{
					Rigidbody component = target.GetComponent<Rigidbody>();
					int num = 0;
					TweenerCore<Vector3, Path, PathOptions> result = default(TweenerCore<Vector3, Path, PathOptions>);
					if (component != (UnityEngine.Object)num && isLocal)
					{
						return result;
					}
				}
				Transform transform = target.transform;
				if (isLocal)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private static bool _initialized;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x11278A0", Offset = "0x11262A0", VA = "0x1811278A0")]
		[Preserve]
		public unsafe static void Init()
		{
			//Discarded unreachable code: IL_0016
			//IL_000c: Expected O, but got I4
			int num = default(int);
			Action<PathOptions, Tween, Quaternion, Transform> action = (Action<PathOptions, Tween, Quaternion, Transform>)(object)new Action<T1, T2, T3, T4>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<PathOptions, Tween, Quaternion, Transform, void>*/)(&Physics.SetOrientationOnPath));
			num = 0;
			DOTweenExternalCommand.add_SetOrientationOnPath((Action<, , , >)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x1127950", Offset = "0x1126350", VA = "0x181127950")]
		[Preserve]
		private static void Preserver()
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			Assembly[] assemblies = AppDomain.getCurDomain().GetAssemblies();
			MethodInfo method = typeof(MonoBehaviour).GetMethod("Stub");
		}
	}
}
