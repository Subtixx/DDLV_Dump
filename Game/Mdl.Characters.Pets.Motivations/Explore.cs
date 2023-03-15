using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Pets.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008C5")]
	public class Explore : Motivation<ExploreConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003116")]
		private Pet pet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003117")]
		private int destinations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003118")]
		private float runTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003119")]
		private float immobileTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400311A")]
		private float idleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400311B")]
		private int rotateDir;

		[Cpp2IlInjected.Token(Token = "0x600288B")]
		[Cpp2IlInjected.Address(RVA = "0x136ACC0", Offset = "0x13696C0", VA = "0x18136ACC0")]
		public Explore(ExploreConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x600288C")]
		[Cpp2IlInjected.Address(RVA = "0x136A060", Offset = "0x1368A60", VA = "0x18136A060", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_0097
			//IL_001e: Expected O, but got I4
			//IL_003a: Expected F4, but got I4
			Pet pet = (this.pet = agent.GetComponent<Pet>());
			Pet pet2 = this.pet;
			int num = 0;
			bool flag = pet2 != (UnityEngine.Object)num;
			if (flag)
			{
				destinations = (flag ? 1 : 0);
				NpcBodyType bodyType = pet2.bodyType;
				runTime = (float)bodyType;
				immobileTime = 0f;
				int num2 = UnityEngine.Random.Range(0, 2);
				Pet pet3 = this.pet;
				rotateDir = num2;
				NavMeshAgent _003CAgent_003Ek__BackingField = pet3.Agent;
				NavMeshAgent _003CAgent_003Ek__BackingField2 = this.pet.Agent;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				NavMeshAgent _003CAgent_003Ek__BackingField3 = this.pet.Agent;
				int num3 = ((_003CAgent_003Ek__BackingField3.autoBraking = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600288D")]
		[Cpp2IlInjected.Address(RVA = "0x136A520", Offset = "0x1368F20", VA = "0x18136A520", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_0025
			//IL_0010: Expected O, but got I4
			Pet pet = this.pet;
			int num = 0;
			if (pet != (UnityEngine.Object)num)
			{
				this.pet.Agent.autoBraking = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600288E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600288F")]
		[Cpp2IlInjected.Address(RVA = "0x136A230", Offset = "0x1368C30", VA = "0x18136A230", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			Pet pet = this.pet;
			int num = 0;
			if (pet == (UnityEngine.Object)num)
			{
				goto IL_0093;
			}
			if (!this.pet.Agent.pathPending)
			{
				float remainingDistance = this.pet.Agent.remainingDistance;
				float stoppingDistance = this.pet.Agent.stoppingDistance;
				int num2 = 0;
				if (stoppingDistance >= remainingDistance)
				{
					goto IL_0083;
				}
				if (!this.pet.Agent.hasPath)
				{
					NavMeshAgent _003CAgent_003Ek__BackingField = this.pet.Agent;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					if ((object)_003CAgent_003Ek__BackingField == null)
					{
						goto IL_0083;
					}
				}
			}
			goto IL_00cb;
			IL_00cb:
			throw new NullReferenceException();
			IL_0083:
			float num3 = (idleTime = idleTime);
			goto IL_0093;
			IL_0093:
			int num4 = 0;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			int num5 = 0;
			int num6 = 0;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			NavMeshAgent _003CAgent_003Ek__BackingField2 = pet.Agent;
			bool flag2 = (_003CAgent_003Ek__BackingField2.autoBraking = (long)"{il2cpp field on {'constant27' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x28}" == 0);
			goto IL_00cb;
		}

		[Cpp2IlInjected.Token(Token = "0x6002890")]
		[Cpp2IlInjected.Address(RVA = "0x136A5B0", Offset = "0x1368FB0", VA = "0x18136A5B0")]
		private Vector3 FindDestination(Pet pet, PetMaster master)
		{
			//IL_0059: Expected F4, but got I4
			//IL_0059: Expected F4, but got I4
			Transform transform = master.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			string moveBool = pet.moveBool;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			string moveBool2 = pet.moveBool;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			int num = 0;
			Vector3 vector6 = default(Vector3);
			float z6 = vector6.z;
			float num2 = UnityEngine.Random.Range(0f, 1.0869187E+09f);
			string moveBool3 = pet.moveBool;
			Transform transform2 = master.transform;
			Vector3 vector7 = default(Vector3);
			float z7 = vector7.z;
			Transform transform3 = master.transform;
			Vector3 vector8 = default(Vector3);
			float z8 = vector8.z;
			string moveBool4 = pet.moveBool;
			Transform transform4 = master.transform;
			Vector3 vector9 = default(Vector3);
			float z9 = vector9.z;
			Vector3 vector10 = default(Vector3);
			float z10 = vector10.z;
			Transform transform5 = master.transform;
			Vector3 vector11 = default(Vector3);
			float z11 = vector11.z;
			Transform transform6 = master.transform;
			string moveBool5 = pet.moveBool;
			Vector3 vector12 = default(Vector3);
			float z12 = vector12.z;
			Vector3 vector13 = default(Vector3);
			float z13 = vector13.z;
			bool flag = default(bool);
			if (!flag)
			{
				Transform transform7 = master.transform;
			}
			Vector3 vector14 = default(Vector3);
			float z14 = vector14.z;
			throw new NullReferenceException();
		}
	}
}
