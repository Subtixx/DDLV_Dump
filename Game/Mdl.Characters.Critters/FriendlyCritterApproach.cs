using System;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200092A")]
	internal class FriendlyCritterApproach : Motivation<FriendlyCritterApproachConfig>, ICritterApproachMotivation, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032F5")]
		private Critter critter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032F6")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032F7")]
		private Mdl.Environments.Environment environment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40032F8")]
		private GridScript currentGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40032F9")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40032FA")]
		private bool sitting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40032FB")]
		private bool? monitorExiting;

		[Cpp2IlInjected.Token(Token = "0x6002A12")]
		[Cpp2IlInjected.Address(RVA = "0x1470EC0", Offset = "0x146F8C0", VA = "0x181470EC0")]
		public FriendlyCritterApproach(FriendlyCritterApproachConfig friendlyCritterApproachConfig)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)friendlyCritterApproachConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A13")]
		[Cpp2IlInjected.Address(RVA = "0x1470430", Offset = "0x146EE30", VA = "0x181470430", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_008f
			//IL_0083: Expected F4, but got O
			//IL_008e: Expected O, but got I4
			Critter critter = (this.critter = agent.GetComponent<Critter>());
			PlayerAvatar playerAvatar = (avatar = SystemRoot.Instance._avatar);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment environment = (this.environment = gameObject.GetComponent<Mdl.Environments.Environment>());
			Critter critter2 = this.critter;
			Mdl.Environments.Environment environment2 = this.environment;
			Transform transform = critter2.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			GridScript gridScript = default(GridScript);
			currentGrid = gridScript;
			timer = (float)gridScript;
			int num = 0;
			monitorExiting = (bool?)(object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A14")]
		[Cpp2IlInjected.Address(RVA = "0x1470690", Offset = "0x146F090", VA = "0x181470690", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			Critter critter = this.critter;
			int num = 0;
			if (!(critter == (UnityEngine.Object)num))
			{
				PlayerAvatar playerAvatar = avatar;
				Mdl.Environments.Environment environment = this.environment;
				Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num2 = 0;
				GridScript gridScript = default(GridScript);
				if (gridScript != (UnityEngine.Object)num2)
				{
					GridScript gridScript2 = currentGrid;
					if (gridScript != gridScript2)
					{
						goto IL_0070;
					}
				}
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag != flag2)
				{
					goto IL_0077;
				}
				bool flag3 = default(bool);
				if (!flag3 && !flag)
				{
					int num3 = 0;
					monitorExiting = (bool?)(object)num3;
				}
			}
			goto IL_0070;
			IL_0077:
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float num4 = default(float);
			float length = default(float);
			if (!(num4 > elapsed))
			{
				if (z2 != 0f)
				{
					AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
					length = animatorStateInfo.m_Length;
					bool flag4 = default(bool);
					Animator animator = default(Animator);
					if (!flag4)
					{
						animator.SetTrigger("Sit");
					}
					int num5 = 0;
					animator.transform.LookAt((Transform)num5);
					int num6 = 0;
				}
				NavMeshAgent navMeshAgent = default(NavMeshAgent);
				navMeshAgent.ResetPath();
			}
			if (1L != 0L)
			{
				Animator animator2 = default(Animator);
				animator2.SetTrigger("Exit");
			}
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			bool flag5 = default(bool);
			if (flag5)
			{
				int num7 = 0;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				float num8 = UnityEngine.Random.Range(length, length);
				NavMeshAgent navMeshAgent2 = default(NavMeshAgent);
				navMeshAgent2.speed = length;
				int num9 = 0;
				NavMeshAgent navMeshAgent3 = default(NavMeshAgent);
				bool flag6 = navMeshAgent3.SetDestination((Vector3)num9);
			}
			throw new NullReferenceException();
			IL_0070:
			int num10 = 0;
			while ((object)critter == null)
			{
			}
			goto IL_0077;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A15")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A16")]
		[Cpp2IlInjected.Address(RVA = "0x1470D80", Offset = "0x146F780", VA = "0x181470D80", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_0026
			if (sitting)
			{
				critter.Animator.SetTrigger("Exit");
				sitting = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A17")]
		[Cpp2IlInjected.Address(RVA = "0x1470DF0", Offset = "0x146F7F0", VA = "0x181470DF0", Slot = "19")]
		public bool ShouldTrigger(GameObject agent)
		{
			//Discarded unreachable code: IL_0019
			//IL_0015: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag == flag2)
			{
				bool flag3 = default(bool);
				if (!flag3 && !flag)
				{
					int num = 0;
					monitorExiting = (bool?)(object)num;
				}
				return flag;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A18")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
		public bool ShouldFlee(GameObject agent)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A19")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "21")]
		public bool ShouldEnterLocomotionAnimationState(GameObject agent)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "22")]
		public void CancelFeeding(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "23")]
		public bool CanInteractWithAvatar()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "24")]
		public bool CanBeFed()
		{
			return true;
		}
	}
}
