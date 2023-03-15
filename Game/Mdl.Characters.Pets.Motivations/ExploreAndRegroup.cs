using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Pets.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008C6")]
	public class ExploreAndRegroup : Motivation<ExploreAndRegroupConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x20008C7")]
		public enum MotivationType
		{
			[Cpp2IlInjected.Token(Token = "0x4003124")]
			Explore,
			[Cpp2IlInjected.Token(Token = "0x4003125")]
			Regroup
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400311D")]
		private IMotivation[] petMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400311E")]
		private float exploringLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400311F")]
		private bool hadPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003120")]
		private Pet pet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003121")]
		private int moveBoolHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003122")]
		private int speedFloatHash;

		[Cpp2IlInjected.Token(Token = "0x170005EF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400311C")]
		public MotivationType? CurrentMotivationType
		{
			[Cpp2IlInjected.Token(Token = "0x6002891")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002892")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005F0")]
		public IMotivation CurrentMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x6002893")]
			[Cpp2IlInjected.Address(RVA = "0x1369F00", Offset = "0x1368900", VA = "0x181369F00")]
			get
			{
				MotivationType motivationType = default(MotivationType);
				if ((object)CurrentMotivationType != null)
				{
					return petMotivation[(int)motivationType];
				}
				int num = 0;
				throw new IndexOutOfRangeException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002894")]
		[Cpp2IlInjected.Address(RVA = "0x1369EB0", Offset = "0x13688B0", VA = "0x181369EB0")]
		public ExploreAndRegroup(ExploreAndRegroupConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002895")]
		[Cpp2IlInjected.Address(RVA = "0x1368F90", Offset = "0x1367990", VA = "0x181368F90", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_0103
			//IL_001e: Expected O, but got I4
			//IL_00f2: Expected O, but got I4
			//IL_0102: Expected F4, but got I4
			Explore explore = default(Explore);
			Regroup regroup = default(Regroup);
			while (true)
			{
				Pet pet = (this.pet = agent.GetComponent<Pet>());
				Pet pet2 = this.pet;
				int num = 0;
				if (!(pet2 != (UnityEngine.Object)num))
				{
					break;
				}
				int num2 = Animator.StringToHash(this.pet.moveBool);
				Pet pet3 = this.pet;
				moveBoolHash = num2;
				int num3 = (speedFloatHash = Animator.StringToHash(pet3.speedFloat));
				IMotivation[] array = (petMotivation = new IMotivation[Enum.GetValues(typeof(MotivationType)).System_002ECollections_002EICollection_002ECount]);
				IMotivation[] array2 = petMotivation;
				if (explore != null && explore == null)
				{
					continue;
				}
				array2[0] = explore;
				IMotivation[] array3 = petMotivation;
				if (regroup == null || regroup != null)
				{
					array3[1] = regroup;
					NavMeshAgent _003CAgent_003Ek__BackingField = this.pet.Agent;
					int num4 = ((_003CAgent_003Ek__BackingField.updateRotation = false) ? 1 : 0);
					int num5 = 0;
					if (regroup == null)
					{
						Animator animator = this.pet.animator;
						int layerIndex = animator.GetLayerIndex((string)num5);
						int num6 = 0;
						animator.SetLayerWeight(layerIndex, num6);
					}
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002896")]
		[Cpp2IlInjected.Address(RVA = "0x13699F0", Offset = "0x13683F0", VA = "0x1813699F0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_00ce
			//IL_0010: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_0054: Expected F4, but got I4
			//IL_007c: Expected F4, but got I4
			//IL_00cd: Expected O, but got I8
			Pet pet = this.pet;
			int num = 0;
			if (pet != (UnityEngine.Object)num)
			{
				Pet pet2 = this.pet;
				pet2.Agent.updateRotation = true;
				int num2 = 0;
				if ((object)pet2 == null)
				{
					Animator animator = this.pet.animator;
					int layerIndex = animator.GetLayerIndex((string)num2);
					int num3 = 0;
					animator.SetLayerWeight(layerIndex, num3);
				}
				Pet pet3 = this.pet;
				Animator animator2 = pet3.animator;
				string speedFloat = pet3.speedFloat;
				int num4 = 0;
				animator2.SetFloat(speedFloat, num4);
				Pet pet4 = this.pet;
				Animator animator3 = pet4.animator;
				string moveBool = pet4.moveBool;
				int value = 0;
				animator3.SetBool(moveBool, (byte)value != 0);
			}
			if ((object)CurrentMotivationType != null)
			{
				MotivationType? motivationType = CurrentMotivationType;
				MotivationType motivationType2 = default(MotivationType);
				IMotivation motivation = petMotivation[(int)motivationType2];
				CurrentMotivationType = (MotivationType?)(object)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002897")]
		[Cpp2IlInjected.Address(RVA = "0x1369C10", Offset = "0x1368610", VA = "0x181369C10", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			//Discarded unreachable code: IL_001e
			if ((object)CurrentMotivationType != null)
			{
				MotivationType? motivationType = CurrentMotivationType;
				MotivationType motivationType2 = default(MotivationType);
				IMotivation motivation = petMotivation[(int)motivationType2];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002898")]
		[Cpp2IlInjected.Address(RVA = "0x1369320", Offset = "0x1367D20", VA = "0x181369320", Slot = "18")]
		protected unsafe override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0016: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_00e7: Invalid comparison between F4 and I4
			//IL_0116: Expected O, but got I4
			//IL_014e: Expected O, but got I4
			float num3 = default(float);
			uint num4 = default(uint);
			Vector3 vector = default(Vector3);
			IMotivation currentMotivation = default(IMotivation);
			uint num9 = default(uint);
			while (true)
			{
				Pet pet = this.pet;
				int num = 0;
				if ((object)pet != null)
				{
				}
				int num2 = 0;
				if ((UnityEngine.Object)num == (UnityEngine.Object)num2)
				{
					break;
				}
				NavMeshAgent _003CAgent_003Ek__BackingField = this.pet.Agent;
				if (!(num3 <= 0.1f))
				{
					NavMeshAgent _003CAgent_003Ek__BackingField2 = this.pet.Agent;
					Quaternion quaternion = Quaternion.LookRotation((Vector3)num);
					Transform transform = this.pet.transform;
					Transform transform2 = this.pet.transform;
				}
				MotivationType? motivationType = CurrentMotivationType;
				if ((object)motivationType != null)
				{
					bool flag = (IntPtr)(void*)motivationType == (IntPtr)(int)num4;
					if ((IntPtr)(void*)motivationType != (IntPtr)(flag ? 1 : 0))
					{
						continue;
					}
					Transform transform3 = this.pet.transform;
					Transform transform4 = this.pet.Master.transform;
					float z = vector.z;
					CurrentMotivationType = (MotivationType?)vector;
					currentMotivation = CurrentMotivation;
				}
				int num5 = 0;
				CurrentMotivationType = (MotivationType?)currentMotivation;
				float weight;
				if (CurrentMotivation == null)
				{
					MotivationType? motivationType2 = CurrentMotivationType;
					float num6 = exploringLayerWeight;
					if ((IntPtr)(((object)motivationType2 == null) ? 1 : 0) == (IntPtr)(void*)motivationType2)
					{
						int num7 = 0;
						if (num6 <= (float)num7)
						{
							goto IL_012b;
						}
					}
					int num8 = 0;
					exploringLayerWeight = num6;
					Pet pet2 = this.pet;
					exploringLayerWeight = num6;
					Animator animator = pet2.animator;
					int layerIndex = animator.GetLayerIndex((string)num8);
					weight = exploringLayerWeight;
					animator.SetLayerWeight(layerIndex, weight);
				}
				goto IL_012b;
				IL_012b:
				IMotivation currentMotivation2 = CurrentMotivation;
				if (num < (int)num9)
				{
					num += num;
					num++;
				}
				if (num == 0)
				{
					int num10 = 0;
					CurrentMotivationType = (MotivationType?)(object)num;
					IMotivation currentMotivation3 = CurrentMotivation;
				}
				Pet pet3 = this.pet;
				float speed = pet3.Agent.speed;
				string moveBool = pet3.moveBool;
				string speedFloat = pet3.speedFloat;
				speed = elapsed;
				Animator animator2 = this.pet.animator;
				int id = speedFloatHash;
				weight = speed;
				animator2.SetFloat(id, weight);
				Pet pet4 = this.pet;
				NavMeshAgent _003CAgent_003Ek__BackingField3 = pet4.Agent;
				Animator animator3 = pet4.animator;
				int id2 = moveBoolHash;
				if (!_003CAgent_003Ek__BackingField3.hasPath || (hadPath ? 1 : 0) != num)
				{
					NavMeshAgent _003CAgent_003Ek__BackingField4 = this.pet.Agent;
					Vector3 velocity = _003CAgent_003Ek__BackingField3.velocity;
				}
				animator3.SetBool(id2, (byte)num4 != 0);
				NavMeshAgent _003CAgent_003Ek__BackingField5 = this.pet.Agent;
				int num11 = 0;
				bool flag2 = (hadPath = _003CAgent_003Ek__BackingField5.hasPath);
				num11 += num11;
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002899")]
		[Cpp2IlInjected.Address(RVA = "0x1369D00", Offset = "0x1368700", VA = "0x181369D00")]
		private unsafe void LerpExploringLayerWeight(float elapsed)
		{
			//IL_0019: Invalid comparison between F4 and I4
			//IL_0044: Expected O, but got I4
			MotivationType? motivationType = CurrentMotivationType;
			float num = exploringLayerWeight;
			if ((IntPtr)(((object)motivationType == null) ? 1 : 0) == (IntPtr)(void*)motivationType)
			{
				int num2 = 0;
				if (!(num <= (float)num2))
				{
					int num3 = 0;
					exploringLayerWeight = num;
					Pet pet = this.pet;
					exploringLayerWeight = num;
					Animator animator = pet.animator;
					int layerIndex = animator.GetLayerIndex((string)num3);
					float weight = exploringLayerWeight;
					animator.SetLayerWeight(layerIndex, weight);
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600289A")]
		[Cpp2IlInjected.Address(RVA = "0x1369DE0", Offset = "0x13687E0", VA = "0x181369DE0")]
		private void SteerRotation(Quaternion desiredRotation, float elapsed)
		{
			//Discarded unreachable code: IL_0019
			Transform transform = pet.transform;
			Transform transform2 = pet.transform;
		}
	}
}
