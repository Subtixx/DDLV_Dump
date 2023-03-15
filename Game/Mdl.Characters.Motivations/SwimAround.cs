using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008EE")]
	public class SwimAround : Motivation<SwimAroundConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031B1")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031B2")]
		private Task overallTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031B3")]
		private bool isTaskActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40031B4")]
		private bool isIdling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40031B5")]
		private bool isMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40031B6")]
		private float runTime;

		[Cpp2IlInjected.Token(Token = "0x6002917")]
		[Cpp2IlInjected.Address(RVA = "0x1067720", Offset = "0x1066120", VA = "0x181067720")]
		public SwimAround(SwimAroundConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002918")]
		[Cpp2IlInjected.Address(RVA = "0x1066EA0", Offset = "0x10658A0", VA = "0x181066EA0", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_0074
			//IL_0035: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			object[] array;
			bool flag2;
			while (true)
			{
				array = new object[4];
				bool flag = isTaskActive;
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				flag2 = isIdling;
				if (flag2 && !flag2)
				{
					continue;
				}
				array[1] = flag2;
				bool flag3 = isMoving;
				flag2 = flag3;
				if (!flag3 || flag3)
				{
					array[2] = flag2;
					float num = runTime;
					flag2 = flag3;
					if (!flag3 || flag3)
					{
						break;
					}
				}
			}
			array[3] = flag2;
			return string.Format("active: {0}, isIdling = {1}, isMoving = {2} (runtime={3})", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6002919")]
		[Cpp2IlInjected.Address(RVA = "0x1066410", Offset = "0x1064E10", VA = "0x181066410", Slot = "14")]
		public override bool CanBeInterrupted(GameObject interruptee, GameObject interruptor)
		{
			//Discarded unreachable code: IL_001f
			Character component = interruptee.GetComponent<Character>();
			if ((object)component != null && component.TraversingLink)
			{
				int num = 0;
			}
			return ((Motivation<C>)(object)this).CanBeInterrupted(interruptee, interruptor);
		}

		[Cpp2IlInjected.Token(Token = "0x600291A")]
		[Cpp2IlInjected.Address(RVA = "0x10665F0", Offset = "0x1064FF0", VA = "0x1810665F0", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_0050
			//IL_003c: Expected F4, but got I4
			this.cancellationTokenSource?.Cancel();
			CancellationTokenSource cancellationTokenSource = (this.cancellationTokenSource = new CancellationTokenSource());
			CancellationTokenSource cancellationTokenSource2 = this.cancellationTokenSource;
			int num = 0;
			isTaskActive = false;
			isMoving = false;
			runTime = num;
			CancellationToken token = cancellationTokenSource2.Token;
			int num2 = 0;
			Task task = default(Task);
			overallTask = task;
		}

		[Cpp2IlInjected.Token(Token = "0x600291B")]
		[Cpp2IlInjected.Address(RVA = "0x10667C0", Offset = "0x10651C0", VA = "0x1810667C0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//Discarded unreachable code: IL_0016
			runTime = elapsed;
			return !overallTask.IsCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x600291C")]
		[Cpp2IlInjected.Address(RVA = "0x10667F0", Offset = "0x10651F0", VA = "0x1810667F0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_0086
			//IL_001a: Expected O, but got I8
			//IL_0032: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_0049: Expected F4, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			cancellationTokenSource?.Cancel();
			cancellationTokenSource = (CancellationTokenSource)0;
			if ((object)typeof(UnityEngine.Object).TypeHandle == null)
			{
				Animator componentInChildren = agent.GetComponentInChildren<Animator>();
				int num = 0;
				if (componentInChildren != (UnityEngine.Object)num)
				{
					int layerIndex = componentInChildren.GetLayerIndex((string)num);
					int num2 = 0;
					componentInChildren.SetLayerWeight(layerIndex, num2);
				}
			}
			Animator componentInChildren2 = agent.GetComponentInChildren<Animator>();
			int num3 = 0;
			bool flag = componentInChildren2 != (UnityEngine.Object)num3;
			if (flag)
			{
				int num4 = 0;
				if (!flag)
				{
					componentInChildren2.ResetTrigger((string)num4);
					componentInChildren2.ResetTrigger((string)num4);
				}
			}
			CharacterUtil.EnableCharacter(agent, enable: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600291D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600291E")]
		[Cpp2IlInjected.Address(RVA = "0x10664B0", Offset = "0x1064EB0", VA = "0x1810664B0")]
		[AsyncStateMachine(typeof(_003CDoAllTasks_003Ed__13))]
		private Task DoAllTasks(CancellationToken ct, GameObject agent)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600291F")]
		[Cpp2IlInjected.Address(RVA = "0x1066A00", Offset = "0x1065400", VA = "0x181066A00")]
		[AsyncStateMachine(typeof(_003CDoIdle_003Ed__14))]
		private Task DoIdle(CancellationToken ct, GameObject agent)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002920")]
		[Cpp2IlInjected.Address(RVA = "0x1066CA0", Offset = "0x10656A0", VA = "0x181066CA0")]
		[AsyncStateMachine(typeof(_003CDoShortIdle_003Ed__15))]
		private Task DoShortIdle(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002921")]
		[Cpp2IlInjected.Address(RVA = "0x1066B40", Offset = "0x1065540", VA = "0x181066B40")]
		[AsyncStateMachine(typeof(_003CDoMove_003Ed__16))]
		private Task<bool> DoMove(CancellationToken ct, GameObject agent)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002922")]
		[Cpp2IlInjected.Address(RVA = "0x1067110", Offset = "0x1065B10", VA = "0x181067110")]
		private Vector3 GetRandomPositionAround(Vector3 initialPosition)
		{
			float num = UnityEngine.Random.Range(-1f, 1f);
			float num2 = UnityEngine.Random.Range(-1f, 1f);
			num2 = num;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float num3 = UnityEngine.Random.Range(num2, 1f);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002923")]
		[Cpp2IlInjected.Address(RVA = "0x1066DC0", Offset = "0x10657C0", VA = "0x181066DC0")]
		private float GetAgentSpeed(GameObject agent)
		{
			if (agent.GetComponent<INpc>() != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002924")]
		[Cpp2IlInjected.Address(RVA = "0x10673C0", Offset = "0x1065DC0", VA = "0x1810673C0")]
		private Task PlayInAnimation(GameObject agent, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			Task completedTask = Task.CompletedTask;
			if (completedTask == null)
			{
				int num2 = 0;
				if (completedTask != null)
				{
					SetAnimOverride(agent, 1f);
				}
			}
			if (completedTask == null)
			{
			}
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002925")]
		[Cpp2IlInjected.Address(RVA = "0x1067510", Offset = "0x1065F10", VA = "0x181067510")]
		private Task PlayOutAnimation(GameObject agent, CancellationToken ct)
		{
			//Discarded unreachable code: IL_000e
			int num = 0;
			Task completedTask = Task.CompletedTask;
			if (completedTask == null)
			{
			}
			return completedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6002926")]
		[Cpp2IlInjected.Address(RVA = "0x1067260", Offset = "0x1065C60", VA = "0x181067260")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__21))]
		private Task PlayAnimation(GameObject agent, string animState, string triggerToSet, string triggerToReset, float maxTime, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002927")]
		[Cpp2IlInjected.Address(RVA = "0x10675F0", Offset = "0x1065FF0", VA = "0x1810675F0")]
		private void SetAnimOverride(GameObject agent, float weight)
		{
			//Discarded unreachable code: IL_0024
			//IL_0010: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			Animator componentInChildren = agent.GetComponentInChildren<Animator>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				int layerIndex = componentInChildren.GetLayerIndex((string)num);
				componentInChildren.SetLayerWeight(layerIndex, weight);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002928")]
		[Cpp2IlInjected.Address(RVA = "0x10676C0", Offset = "0x10660C0", VA = "0x1810676C0")]
		[Conditional("DEBUG")]
		private void Warn(string message)
		{
			UnityEngine.Debug.LogWarning(message);
		}
	}
}
