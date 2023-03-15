using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008EC")]
	public class SayHiToVillager : Motivation<SayHiToVillagerConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400319F")]
		private float speed = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40031A0")]
		private float walkDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031A1")]
		private Task walkTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031A2")]
		private Task sayHiTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031A3")]
		private GameObject currentTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40031A4")]
		private bool setAnimOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40031A5")]
		private CancellationTokenSource ctSource;

		[Cpp2IlInjected.Token(Token = "0x600290B")]
		[Cpp2IlInjected.Address(RVA = "0xCC9420", Offset = "0xCC7E20", VA = "0x180CC9420")]
		public SayHiToVillager(SayHiToVillagerConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x600290C")]
		[Cpp2IlInjected.Address(RVA = "0xCC8B40", Offset = "0xCC7540", VA = "0x180CC8B40", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_0103
			//IL_00f7: Expected O, but got I4
			object[] array;
			string text = default(string);
			bool isCompleted = default(bool);
			while (true)
			{
				array = new object[8];
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
				GameObject gameObject = currentTarget;
				if ((object)gameObject != null && newLine == null)
				{
					continue;
				}
				array[3] = gameObject;
				int num2 = 0;
				string newLine2 = Environment.NewLine;
				if (newLine2 != null && newLine2 == null)
				{
					continue;
				}
				array[4] = newLine2;
				float num3 = walkDuration;
				if (newLine2 != null && newLine2 == null)
				{
					continue;
				}
				array[5] = newLine2;
				int num4 = 0;
				string newLine3 = Environment.NewLine;
				if (newLine3 == null || newLine3 != null)
				{
					array[6] = newLine3;
					Task task = walkTask;
					if (task != null)
					{
						isCompleted = task.IsCompleted;
						int num5 = 0;
						bool flag = !isCompleted;
					}
					if (!isCompleted || isCompleted)
					{
						break;
					}
				}
			}
			array[7] = isCompleted;
			return string.Format("{0} - {1}{2}Target : {3}{4}Walk Duration : {5}{6}Walking : {7}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x600290D")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
		public void ForceTarget(GameObject target)
		{
			currentTarget = target;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600290E")]
		[Cpp2IlInjected.Address(RVA = "0xCC8290", Offset = "0xCC6C90", VA = "0x180CC8290", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600290F")]
		[Cpp2IlInjected.Address(RVA = "0xCC9010", Offset = "0xCC7A10", VA = "0x180CC9010")]
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

		[Cpp2IlInjected.Token(Token = "0x6002910")]
		[Cpp2IlInjected.Address(RVA = "0xCC8F60", Offset = "0xCC7960", VA = "0x180CC8F60")]
		private void ResetSpeed(GameObject agent)
		{
			//Discarded unreachable code: IL_0011
			if (agent.GetComponent<INpc>() != null)
			{
			}
			NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
		}

		[Cpp2IlInjected.Token(Token = "0x6002911")]
		[Cpp2IlInjected.Address(RVA = "0xCC8970", Offset = "0xCC7370", VA = "0x180CC8970", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_0043
			//IL_002d: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0042: Expected F4, but got I4
			ctSource.Cancel();
			if (agent.GetComponent<INpc>() != null)
			{
			}
			if ((object)agent.GetComponent<NavMeshAgent>() == null)
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
		}

		[Cpp2IlInjected.Token(Token = "0x6002912")]
		[Cpp2IlInjected.Address(RVA = "0xCC8B20", Offset = "0xCC7520", VA = "0x180CC8B20", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			IMotivation subMotivation = ((IMotivation)this).SubMotivation;
		}

		[Cpp2IlInjected.Token(Token = "0x6002913")]
		[Cpp2IlInjected.Address(RVA = "0xCC85D0", Offset = "0xCC6FD0", VA = "0x180CC85D0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_0069: Invalid comparison between I4 and F4
			//IL_00dc: Expected O, but got I4
			GameObject gameObject = currentTarget;
			int num = 0;
			if (!(gameObject == (UnityEngine.Object)num))
			{
				if ((long)sayHiTask == 0)
				{
					Transform transform = agent.transform;
					GameObject gameObject2 = currentTarget;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform transform2 = gameObject2.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					float num2 = default(float);
					if (!(elapsed > num2))
					{
						float num3 = walkDuration;
						int num4 = 0;
						walkDuration = num3;
						if (!((float)num4 >= num3))
						{
							Task task = walkTask;
							if ((task == null || !task.IsCompleted) && (long)walkTask == 0)
							{
								goto IL_0102;
							}
						}
						bool flag = UpdateDestination(agent);
						float num5 = (walkDuration = walkDuration);
					}
					ctSource.Cancel();
					CancellationTokenSource cancellationTokenSource = (ctSource = new CancellationTokenSource());
					Task task2 = default(Task);
					sayHiTask = task2;
				}
				GameObject gameObject3 = currentTarget;
				int num6 = 0;
				if (gameObject3 != (UnityEngine.Object)num6)
				{
					Transform transform3 = agent.transform;
					Transform transform4 = currentTarget.transform;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
				}
			}
			goto IL_0102;
			IL_0102:
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002914")]
		[Cpp2IlInjected.Address(RVA = "0xCC90E0", Offset = "0xCC7AE0", VA = "0x180CC90E0")]
		private bool UpdateDestination(GameObject agent)
		{
			//IL_006f: Expected I4, but got I8
			//IL_006f: Expected F4, but got I4
			//IL_006f: Expected O, but got I4
			Transform transform = agent.transform;
			Transform transform2 = currentTarget.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform3 = currentTarget.transform;
			NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
			Vector3? vector2 = default(Vector3?);
			if ((object)vector2 == null)
			{
			}
			NavMeshAgent component2 = agent.GetComponent<NavMeshAgent>();
			CancellationTokenSource cancellationTokenSource = ctSource;
			float num = speed;
			int num2 = 0;
			CancellationToken token = cancellationTokenSource.Token;
			int num3 = 0;
			ulong num4 = default(ulong);
			Task<bool> task = (Task<bool>)(walkTask = CharacterUtil.WalkTo(component2, (Vector3)num2, num, num, (float)num3, token, (byte)num4 != 0));
			throw new NullReferenceException();
		}
	}
}
