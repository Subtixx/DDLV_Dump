using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000725")]
	internal class CharacterTurnAnimationController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002978")]
		private NavMeshAgent navMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002979")]
		private NavMeshAreaHelper navMeshAreaHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400297A")]
		private RelaxingBehaviour relaxingBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400297B")]
		private bool hadPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400297C")]
		private CancellationTokenSource preMoveCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400297D")]
		private Task preMoveTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400297E")]
		private NavMeshAreaHelper.StopNavMeshAgentScope navMeshAgentScope;

		[Cpp2IlInjected.Token(Token = "0x6001FB7")]
		[Cpp2IlInjected.Address(RVA = "0x12E8F20", Offset = "0x12E7920", VA = "0x1812E8F20")]
		private void Start()
		{
			NavMeshAgent navMeshAgent = (this.navMeshAgent = GetComponent<NavMeshAgent>());
			NavMeshAreaHelper navMeshAreaHelper = (this.navMeshAreaHelper = GetComponent<NavMeshAreaHelper>());
			RelaxingBehaviour relaxingBehaviour = (this.relaxingBehaviour = GetComponent<RelaxingBehaviour>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB8")]
		[Cpp2IlInjected.Address(RVA = "0x12E94A0", Offset = "0x12E7EA0", VA = "0x1812E94A0")]
		private void Update()
		{
			UpdatePreMoveAnimation();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB9")]
		[Cpp2IlInjected.Address(RVA = "0x12E9100", Offset = "0x12E7B00", VA = "0x1812E9100")]
		private void UpdatePreMoveAnimation()
		{
			//Discarded unreachable code: IL_010c
			//IL_004a: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00fd: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			bool hasPath = navMeshAgent.hasPath;
			bool flag = hadPath;
			int num = 0;
			if (!hasPath)
			{
				if (!flag || hasPath)
				{
					goto IL_00b0;
				}
				CancellationTokenSource cancellationTokenSource = preMoveCTS;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
					preMoveCTS.Dispose();
					preMoveCTS = (CancellationTokenSource)num;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					int num2 = 0;
					navMeshAgentScope = (NavMeshAreaHelper.StopNavMeshAgentScope)num2;
				}
				preMoveTask = (Task)num;
			}
			NavMeshPath path = navMeshAgent.path;
			CancellationTokenSource cancellationTokenSource2 = (preMoveCTS = new CancellationTokenSource());
			if (path.corners.Length > 1)
			{
				int num3 = 0;
				Vector3[] corners = path.corners;
			}
			CancellationToken token = preMoveCTS.Token;
			int num4 = 0;
			Task task = default(Task);
			preMoveTask = task;
			goto IL_00b0;
			IL_00b0:
			Task task2 = preMoveTask;
			if (task2 != null && task2.IsCompleted)
			{
				CancellationTokenSource cancellationTokenSource3 = preMoveCTS;
				if (cancellationTokenSource3 != null)
				{
					cancellationTokenSource3.Cancel();
					preMoveCTS.Dispose();
					preMoveCTS = (CancellationTokenSource)num;
				}
				bool flag3 = default(bool);
				if (flag3)
				{
					int num5 = 0;
					navMeshAgentScope = (NavMeshAreaHelper.StopNavMeshAgentScope)num5;
				}
				preMoveTask = (Task)num;
			}
			hadPath = hasPath;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FBA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CharacterTurnAnimationController()
		{
		}
	}
}
