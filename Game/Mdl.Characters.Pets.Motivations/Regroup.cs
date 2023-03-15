using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Pets.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008CA")]
	public class Regroup : Motivation<RegroupConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003134")]
		private Pet pet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003135")]
		private float retargetTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003136")]
		private float immobileTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003137")]
		private float currentFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003138")]
		private bool targetReached;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003139")]
		private Vector3 targetOffset;

		[Cpp2IlInjected.Token(Token = "0x600289F")]
		[Cpp2IlInjected.Address(RVA = "0xCBE190", Offset = "0xCBCB90", VA = "0x180CBE190")]
		public Regroup(RegroupConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x60028A0")]
		[Cpp2IlInjected.Address(RVA = "0xCBD4D0", Offset = "0xCBBED0", VA = "0x180CBD4D0", Slot = "15")]
		protected unsafe override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_005d
			//IL_0028: Expected F4, but got I4
			//IL_005c: Expected F4, but got O
			//IL_0057: Expected native int or pointer, but got O
			Pet pet = (this.pet = agent.GetComponent<Pet>());
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				retargetTime = 0.5f;
				currentFollowTime = (flag ? 1 : 0);
				targetReached = (byte)num2 != 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				bool flag2 = default(bool);
				if (flag2)
				{
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					((Vector3*)(IntPtr)targetOffset)->z = (float)vector3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028A1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028A3")]
		[Cpp2IlInjected.Address(RVA = "0xCBD8A0", Offset = "0xCBC2A0", VA = "0x180CBD8A0", Slot = "18")]
		protected unsafe override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0012: Expected O, but got I4
			//IL_003d: Invalid comparison between I4 and F4
			//IL_00cd: Expected O, but got I4
			//IL_022d: Expected F4, but got O
			//IL_0228: Expected native int or pointer, but got O
			int num = 0;
			Pet pet = this.pet;
			int num2 = 0;
			bool flag = pet == (UnityEngine.Object)num2;
			NavMeshAgent _003CAgent_003Ek__BackingField2;
			if (!flag)
			{
				if (targetReached != flag)
				{
					float num3 = currentFollowTime;
					int num4 = 0;
					currentFollowTime = num3;
					if ((float)num4 >= num3)
					{
						goto IL_023a;
					}
					Transform transform = this.pet.Master.transform;
					float z = targetOffset.z;
					NavMeshAgent _003CAgent_003Ek__BackingField = this.pet.Agent;
					Transform transform2 = this.pet.transform;
					Transform transform3 = this.pet.transform;
					Transform transform4 = this.pet.Master.transform;
					Transform transform5 = this.pet.transform;
					Transform transform6 = this.pet.transform;
					Pet pet2 = this.pet;
					int num5 = 0;
					pet2.transform.rotation = (Quaternion)num5;
					Pet pet3 = this.pet;
					Transform transform7 = pet3.transform;
					Transform transform8 = pet3.transform;
				}
				_003CAgent_003Ek__BackingField2 = this.pet.Agent;
				bool pathPending = _003CAgent_003Ek__BackingField2.pathPending;
				int num6 = 0;
				if (!pathPending)
				{
					float remainingDistance = this.pet.Agent.remainingDistance;
					NavMeshAgent _003CAgent_003Ek__BackingField3 = this.pet.Agent;
					int num7 = 0;
					if (_003CAgent_003Ek__BackingField3.stoppingDistance >= remainingDistance)
					{
						goto IL_0167;
					}
					NavMeshAgent _003CAgent_003Ek__BackingField4 = this.pet.Agent;
					if (!_003CAgent_003Ek__BackingField4.hasPath)
					{
						NavMeshAgent _003CAgent_003Ek__BackingField5 = this.pet.Agent;
						Vector3 velocity = _003CAgent_003Ek__BackingField4.velocity;
						if ((object)_003CAgent_003Ek__BackingField5 == null)
						{
							goto IL_0167;
						}
					}
				}
				goto IL_017f;
			}
			goto IL_023a;
			IL_0167:
			this.pet.Agent.speed = elapsed;
			targetReached = true;
			goto IL_017f;
			IL_017f:
			NavMeshAgent _003CAgent_003Ek__BackingField6 = this.pet.Agent;
			Vector3 velocity2 = _003CAgent_003Ek__BackingField2.velocity;
			float num8 = (retargetTime = retargetTime);
			immobileTime = elapsed;
			if (!(elapsed >= 1f))
			{
				Pet pet4 = this.pet;
				retargetTime = 0.5f;
				Transform transform9 = pet4.transform;
				Transform transform10 = this.pet.Master.transform;
				Transform transform11 = this.pet.Master.transform;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				bool flag2 = default(bool);
				if (flag2)
				{
					Transform transform12 = this.pet.Master.transform;
					Vector3 vector2 = default(Vector3);
					float z3 = vector2.z;
					((Vector3*)(IntPtr)targetOffset)->z = (float)vector2;
					NavMeshAgent _003CAgent_003Ek__BackingField7 = this.pet.Agent;
				}
			}
			goto IL_023a;
			IL_023a:
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028A4")]
		[Cpp2IlInjected.Address(RVA = "0xCBE0C0", Offset = "0xCBCAC0", VA = "0x180CBE0C0")]
		private void SteerRotation(Pet pet, Quaternion desiredRotation, float elapsed)
		{
			//Discarded unreachable code: IL_000f
			Transform transform = pet.transform;
			Transform transform2 = pet.transform;
		}
	}
}
