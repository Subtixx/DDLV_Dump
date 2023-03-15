using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008F7")]
	public class TriggerAnimOnTheSpot : Motivation<TriggerAnimOnTheSpotConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031F4")]
		private float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40031F5")]
		private Vector3 lookDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031F6")]
		private Task playAnimInTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031F7")]
		private Task playAnimOutTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40031F8")]
		private CancellationTokenSource ctSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40031F9")]
		private NavMeshObstacle clearingNavMeshObstacle;

		[Cpp2IlInjected.Token(Token = "0x600293F")]
		[Cpp2IlInjected.Address(RVA = "0x13DFBA0", Offset = "0x13DE5A0", VA = "0x1813DFBA0")]
		public TriggerAnimOnTheSpot(TriggerAnimOnTheSpotConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002940")]
		[Cpp2IlInjected.Address(RVA = "0x13DF710", Offset = "0x13DE110", VA = "0x1813DF710", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_00a5
			object[] array;
			string text = default(string);
			string newLine2;
			while (true)
			{
				array = new object[6];
				string info = ((Motivation<C>)(object)this).GetInfo(agent);
				if (info != null && info == null)
				{
					continue;
				}
				array[0] = info;
				if (text != null && text == null)
				{
					continue;
				}
				array[1] = text;
				int num = 0;
				string newLine = Environment.NewLine;
				if (newLine != null && newLine == null)
				{
					continue;
				}
				array[2] = newLine;
				float num2 = duration;
				if (newLine != null && newLine == null)
				{
					continue;
				}
				array[3] = newLine;
				int num3 = 0;
				newLine2 = Environment.NewLine;
				if (newLine2 == null || newLine2 != null)
				{
					array[4] = newLine2;
					if (newLine2 == null || newLine2 != null)
					{
						break;
					}
				}
			}
			array[5] = newLine2;
			return string.Format("{0} - {1}{2}Duration : {3}{4}Animation : {5}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6002941")]
		[Cpp2IlInjected.Address(RVA = "0x13DED40", Offset = "0x13DD740", VA = "0x1813DED40", Slot = "15")]
		protected unsafe override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_00f3
			//IL_0016: Expected F4, but got I4
			//IL_002d: Expected native int or pointer, but got O
			int num = 0;
			CancellationTokenSource cancellationTokenSource = (ctSource = new CancellationTokenSource());
			duration = num;
			Transform transform = agent.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)lookDir)->z = z;
			bool flag = default(bool);
			if (!flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_0042;
				}
				int num2 = 0;
			}
			int num3 = 0;
			goto IL_0042;
			IL_0042:
			GameObject gameObject = new GameObject();
			Transform transform2 = gameObject.transform;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject2 = default(GameObject);
			Transform transform4 = (transform2.parent = gameObject2.transform);
			Transform transform5 = gameObject.transform;
			Transform transform6 = agent.transform;
			Transform transform7 = agent.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform8 = gameObject.transform;
			Transform transform9 = agent.transform;
			NavMeshObstacle navMeshObstacle = (clearingNavMeshObstacle = gameObject.AddComponent<NavMeshObstacle>());
			clearingNavMeshObstacle.shape = NavMeshObstacleShape.Box;
			clearingNavMeshObstacle.carving = true;
			NavMeshObstacle navMeshObstacle2 = clearingNavMeshObstacle;
			CancellationToken token = ctSource.Token;
			Task task = default(Task);
			playAnimInTask = task;
		}

		[Cpp2IlInjected.Token(Token = "0x6002942")]
		[Cpp2IlInjected.Address(RVA = "0x13DF4A0", Offset = "0x13DDEA0", VA = "0x1813DF4A0", Slot = "16")]
		protected unsafe override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_007b
			//IL_0021: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			ctSource.Cancel();
			int num = 0;
			playAnimInTask = (Task)num;
			playAnimOutTask = (Task)num;
			Animator componentInChildren = agent.GetComponentInChildren<Animator>();
			int num2 = 0;
			if (componentInChildren != (UnityEngine.Object)num2)
			{
				componentInChildren.ResetTrigger((string)num2);
				componentInChildren.ResetTrigger((string)num2);
			}
			if ((bool)clearingNavMeshObstacle)
			{
				UnityEngine.Object.Destroy(clearingNavMeshObstacle.gameObject);
			}
			SendOrPostCallback sendOrPostCallback = default(SendOrPostCallback);
			SendOrPostCallback sendOrPostCallback2 = delegate
			{
				//Discarded unreachable code: IL_001e
				if (sendOrPostCallback == null)
				{
					sendOrPostCallback = delegate
					{
						//Discarded unreachable code: IL_0024
						GameObject gameObject = agent;
						int num3 = 0;
						if (!gameObject.TryGetComponent<Character>(out *(Character*)num3) && !agent.TryGetComponent<NavMeshAgent>(out *(NavMeshAgent*)num3))
						{
						}
					};
				}
			};
		}

		[Cpp2IlInjected.Token(Token = "0x6002943")]
		[Cpp2IlInjected.Address(RVA = "0xCC8B20", Offset = "0xCC7520", VA = "0x180CC8B20", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			IMotivation subMotivation = ((IMotivation)this).SubMotivation;
		}

		[Cpp2IlInjected.Token(Token = "0x6002944")]
		[Cpp2IlInjected.Address(RVA = "0x13DF280", Offset = "0x13DDC80", VA = "0x1813DF280", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0032: Expected O, but got I4
			Task task = playAnimInTask;
			if (task != null && !task.IsCompleted && !playAnimInTask.IsCanceled)
			{
				NavMeshObstacle navMeshObstacle = clearingNavMeshObstacle;
				int num = 0;
				if (!(navMeshObstacle != (UnityEngine.Object)num))
				{
					goto IL_009e;
				}
				Transform transform = clearingNavMeshObstacle.transform;
				Transform transform2 = agent.transform;
			}
			float num2 = duration;
			int num3 = 0;
			duration = num2;
			Task task2 = playAnimOutTask;
			if (task2 == null)
			{
				CancellationToken token = ctSource.Token;
				Task task3 = default(Task);
				playAnimOutTask = task3;
				Task task4 = playAnimOutTask;
			}
			if (task2.IsCompleted || playAnimOutTask.IsCanceled)
			{
				throw new NullReferenceException();
			}
			goto IL_009e;
			IL_009e:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002945")]
		[Cpp2IlInjected.Address(RVA = "0x13DFA20", Offset = "0x13DE420", VA = "0x1813DFA20")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__12))]
		internal Task PlayAnimation(GameObject agent, string animState, string triggerToSet, string triggerToReset, float maxTime, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
