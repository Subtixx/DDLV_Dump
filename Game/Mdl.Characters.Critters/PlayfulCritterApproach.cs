using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200092D")]
	internal class PlayfulCritterApproach : Motivation<PlayfulCritterApproachConfig>, ICritterApproachMotivation, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400330E")]
		private Critter critter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400330F")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003310")]
		private Mdl.Environments.Environment environment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003311")]
		private GridScript currentGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003312")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003313")]
		private int numberOfRunAwayLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003314")]
		private bool sitting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4003315")]
		private bool ranAway;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4003316")]
		private bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4003317")]
		private bool gaveUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4003318")]
		private int stuckTries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003319")]
		private Vector3[] possibleDestinations;

		[Cpp2IlInjected.Token(Token = "0x6002A34")]
		[Cpp2IlInjected.Address(RVA = "0xCAFDC0", Offset = "0xCAE7C0", VA = "0x180CAFDC0")]
		public PlayfulCritterApproach(PlayfulCritterApproachConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A35")]
		[Cpp2IlInjected.Address(RVA = "0xCAEB80", Offset = "0xCAD580", VA = "0x180CAEB80", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_00d4
			//IL_007d: Expected F4, but got O
			//IL_008d: Expected I4, but got O
			//IL_00d3: Expected I4, but got I8
			Critter critter = (this.critter = agent.GetComponent<Critter>());
			PlayerAvatar playerAvatar = (avatar = SystemRoot.Instance._avatar);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			List<SceneData> sceneStack2 = sceneStack._sceneStack;
			SceneData main = sceneStack._main;
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
			Critter critter3 = this.critter;
			numberOfRunAwayLeft = (int)gridScript;
			NavMeshAgent agent2 = critter3.Agent;
			float num = (agent2.speed = this.critter.sprintSpeed);
			this.critter.Agent.ResetPath();
			ranAway = true;
			gaveUp = false;
			stuckTries = 3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A36")]
		[Cpp2IlInjected.Address(RVA = "0xCAEEC0", Offset = "0xCAD8C0", VA = "0x180CAEEC0", Slot = "18")]
		protected unsafe override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0012: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_0136: Expected I4, but got I8
			//IL_0166: Invalid comparison between I4 and F4
			//IL_028c: Expected O, but got I4
			//IL_028c: Expected O, but got I4
			//IL_02a1: Expected O, but got I4
			//IL_02d4: Expected F4, but got I4
			Critter critter = this.critter;
			int num = 0;
			int num2 = 0;
			if (critter == (UnityEngine.Object)num2)
			{
				goto IL_02a3;
			}
			PlayerAvatar playerAvatar = avatar;
			Mdl.Environments.Environment environment = this.environment;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num3 = 0;
			GridScript gridScript = default(GridScript);
			if (gridScript != (UnityEngine.Object)num3)
			{
				GridScript gridScript2 = currentGrid;
				if (gridScript != gridScript2)
				{
					goto IL_02a3;
				}
			}
			Critter critter2 = this.critter;
			if (sitting)
			{
				Animator animator = critter2.Animator;
				AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
				float length = animatorStateInfo.m_Length;
				bool flag = default(bool);
				if (!flag)
				{
					this.critter.Animator.SetTrigger("Sit");
				}
				Transform transform = this.critter.transform;
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				transform.LookAt(_003Ctransform_003Ek__BackingField2);
			}
			Critter critter3 = this.critter;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform2 = critter3.transform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			bool flag2 = default(bool);
			if (!flag2)
			{
				Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
				Critter critter4 = this.critter;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				Transform transform3 = critter4.transform;
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				this.critter.Agent.ResetPath();
				ranAway = true;
				stuckTries = 3;
				NavMeshAgent agent2 = this.critter.Agent;
				Vector3 vector6 = default(Vector3);
				float z6 = vector6.z;
				bool flag3 = default(bool);
				if (flag3)
				{
					goto IL_02db;
				}
				isRunning = true;
			}
			float num4 = timer;
			if (!(0f > num4))
			{
				PlayerAvatar playerAvatar2 = avatar;
				timer = num4;
				Transform _003Ctransform_003Ek__BackingField4 = playerAvatar2.transform;
				Critter critter5 = this.critter;
				Vector3 vector7 = default(Vector3);
				float z7 = vector7.z;
				Transform transform4 = critter5.transform;
				Vector3 vector8 = default(Vector3);
				float z8 = vector8.z;
				float num5 = default(float);
				if (!(num4 > num5))
				{
					Transform transform5 = this.critter.transform;
					Transform _003Ctransform_003Ek__BackingField5 = avatar.transform;
					transform5.LookAt(_003Ctransform_003Ek__BackingField5);
					Animator animator2 = this.critter.Animator;
					bool flag4 = default(bool);
					if (flag4)
					{
						goto IL_02db;
					}
					this.critter.Animator.SetTrigger("Happy");
				}
				if (!ranAway && isRunning && !isRunning)
				{
					Vector3[] array = possibleDestinations;
					Func<Vector3, float> func = (Func<Vector3, float>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0015
						Transform transform6 = this.critter.transform;
						Vector3 vector10 = default(Vector3);
						float z10 = vector10.z;
						float result = default(float);
						return result;
					};
					uint num6 = default(uint);
					Vector3[] array2 = Enumerable.Skip<Vector3>((IEnumerable<>)Enumerable.OrderBy<Vector3, float>((IEnumerable<>)(object)array, (Func<, >)(object)func), (int)num6).ToArray<Vector3>();
					int num7 = 0;
					int num8 = 0;
					int walkableMask = this.critter.Agent.walkableMask;
					NavMeshAgent agent3 = this.critter.Agent;
					int num9 = 0;
					int agentTypeID = agent3.agentTypeID;
					if (NavMesh.SamplePosition((Vector3)num8, out *(NavMeshHit*)num9, 100f, (NavMeshQueryFilter)num8))
					{
						bool flag5 = this.critter.Agent.Warp((Vector3)num8);
						goto IL_02a3;
					}
				}
				goto IL_02a6;
			}
			goto IL_02db;
			IL_02a3:
			int num10 = 0;
			goto IL_02a6;
			IL_02a6:
			ranAway = false;
			if (numberOfRunAwayLeft != 0)
			{
				NavMeshAgent agent4 = this.critter.Agent;
				Vector3 vector9 = default(Vector3);
				float z9 = vector9.z;
				bool flag6 = default(bool);
				timer = (flag6 ? 1 : 0);
			}
			sitting = true;
			goto IL_02db;
			IL_02db:
			gaveUp = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A37")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A38")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A39")]
		[Cpp2IlInjected.Address(RVA = "0xCAFC10", Offset = "0xCAE610", VA = "0x180CAFC10", Slot = "19")]
		public bool ShouldTrigger(GameObject agent)
		{
			bool flag = default(bool);
			if (flag)
			{
				if (!gaveUp)
				{
					return true;
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform = agent.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
			}
			gaveUp = false;
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A3A")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
		public bool ShouldFlee(GameObject agent)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A3B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "21")]
		public bool ShouldEnterLocomotionAnimationState(GameObject agent)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A3C")]
		[Cpp2IlInjected.Address(RVA = "0xCAEB50", Offset = "0xCAD550", VA = "0x180CAEB50", Slot = "22")]
		public void CancelFeeding(GameObject agent)
		{
			//Discarded unreachable code: IL_0008
			sitting = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A3D")]
		[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70", Slot = "23")]
		public bool CanInteractWithAvatar()
		{
			return sitting;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A3E")]
		[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70", Slot = "24")]
		public bool CanBeFed()
		{
			return sitting;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A3F")]
		[Cpp2IlInjected.Address(RVA = "0xCAF720", Offset = "0xCAE120", VA = "0x180CAF720")]
		private Vector3 FindDestination()
		{
			//IL_0023: Expected O, but got F4
			//IL_0035: Expected O, but got F4
			//IL_0047: Expected O, but got F4
			//IL_0062: Expected O, but got F4
			int num = 0;
			Vector3[] array = new Vector3[0];
			Vector3 vector = array[21];
			Vector3 vector2 = default(Vector3);
			float z = vector2.z;
			array[1] = (Vector3)z;
			Vector3 vector3 = default(Vector3);
			float z2 = vector3.z;
			array[2] = (Vector3)z2;
			Vector3 vector4 = default(Vector3);
			float z3 = vector4.z;
			array[4] = (Vector3)z3;
			GridData gridData = default(GridData);
			int sizeX_ = gridData.sizeX_;
			Vector3 vector5 = default(Vector3);
			float z4 = vector5.z;
			array[5] = (Vector3)z4;
			IOrderedEnumerable<Vector3> orderedEnumerable = default(IOrderedEnumerable<Vector3>);
			Vector3[] array2 = Enumerable.Skip<Vector3>((IEnumerable<>)orderedEnumerable, 1).ToArray<Vector3>();
			int num2 = 0;
			NavMeshAgent navMeshAgent = default(NavMeshAgent);
			int walkableMask = navMeshAgent.walkableMask;
			NavMeshAgent navMeshAgent2 = default(NavMeshAgent);
			int agentTypeID = navMeshAgent2.agentTypeID;
			bool flag = default(bool);
			if (!flag)
			{
				Transform transform = navMeshAgent2.transform;
			}
			Vector3 vector6 = default(Vector3);
			float z5 = vector6.z;
			throw new NullReferenceException();
		}
	}
}
