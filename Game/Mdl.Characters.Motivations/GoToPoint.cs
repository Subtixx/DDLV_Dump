using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008D4")]
	internal class GoToPoint : Motivation<GoToPointConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003155")]
		private AnimationClip originalIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003156")]
		private Task walkToTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003157")]
		private Transform targetTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003158")]
		private CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x60028BD")]
		[Cpp2IlInjected.Address(RVA = "0xCE19B0", Offset = "0xCE03B0", VA = "0x180CE19B0")]
		public GoToPoint(GoToPointConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x60028BE")]
		[Cpp2IlInjected.Address(RVA = "0xCE0F90", Offset = "0xCDF990", VA = "0x180CE0F90", Slot = "15")]
		protected unsafe override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_0073
			//IL_0063: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag && agent.TryGetComponent<Animator>(out *(Animator*)num))
			{
				int num2 = 0;
				RuntimeAnimatorController runtimeAnimatorController = default(RuntimeAnimatorController);
				if ((object)runtimeAnimatorController != null)
				{
					int num3 = 0;
					if ((object)runtimeAnimatorController != null)
					{
						List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
						bool result = default(bool);
						Predicate<KeyValuePair<AnimationClip, AnimationClip>> predicate = (Predicate<KeyValuePair<AnimationClip, AnimationClip>>)(object)(Predicate<T>)((KeyValuePair<AnimationClip, AnimationClip> x) => result);
						int index = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
						int num4 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						originalIdle = (AnimationClip)(object)predicate;
						int num5 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						int num6 = 0;
						((List<T>)(object)list)[index] = (T)num6;
					}
				}
			}
			CancellationTokenSource cancellationTokenSource = (cts = new CancellationTokenSource());
		}

		[Cpp2IlInjected.Token(Token = "0x60028BF")]
		[Cpp2IlInjected.Address(RVA = "0xCE12B0", Offset = "0xCDFCB0", VA = "0x180CE12B0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0058: Expected O, but got I4
			//IL_0061: Expected O, but got I8
			Task task = walkToTask;
			if (task == null)
			{
				goto IL_0045;
			}
			if (task.IsCompleted)
			{
				Transform transform = agent.transform;
				Transform transform2 = targetTransform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float num = default(float);
				if (!(num <= 0.2f))
				{
					goto IL_0045;
				}
			}
			goto IL_00a3;
			IL_0045:
			LocationCustom locationCustom = new LocationCustom();
			int num2 = 0;
			locationCustom.GUID = (string)num2;
			walkToTask = (Task)0;
			Character character = agent.GetComponent<Character>();
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
				CancellationToken token = cts.Token;
				Task task2 = (walkToTask = WalkTo(token));
			}
			if ((long)walkToTask == 0)
			{
				throw new NullReferenceException();
			}
			goto IL_00a3;
			IL_00a3:
			return true;
			[Cpp2IlInjected.Token(Token = "0x60028C5")]
			[Cpp2IlInjected.Address(RVA = "0x1053AE0", Offset = "0x10524E0", VA = "0x181053AE0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass6_0._003C_003CDoExecute_003Eg__WalkTo_007C0_003Ed))]
			Task WalkTo(CancellationToken ct)
			{
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028C1")]
		[Cpp2IlInjected.Address(RVA = "0xCE15A0", Offset = "0xCDFFA0", VA = "0x180CE15A0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_005d
			//IL_005c: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || !flag2)
			{
				return;
			}
			int num = 0;
			RuntimeAnimatorController runtimeAnimatorController = default(RuntimeAnimatorController);
			if ((object)runtimeAnimatorController == null)
			{
				return;
			}
			int num2 = 0;
			if ((object)runtimeAnimatorController != null)
			{
				List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
				bool result = default(bool);
				Predicate<KeyValuePair<AnimationClip, AnimationClip>> predicate = (Predicate<KeyValuePair<AnimationClip, AnimationClip>>)(object)(Predicate<T>)((KeyValuePair<AnimationClip, AnimationClip> x) => result);
				int index = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num3 += num3;
				AnimationClip animationClip = originalIdle;
				int num4 = 0;
				((List<T>)(object)list)[index] = (T)num4;
			}
		}
	}
}
