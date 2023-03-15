using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Pets
{
	[Cpp2IlInjected.Token(Token = "0x20008C0")]
	[RequireComponent(typeof(NavMeshAgent))]
	public class Pet : MonoBehaviour, INpc, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030FA")]
		public string moveBool = "IsMoving";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030FB")]
		public string speedFloat = "Speed";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030FC")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030FD")]
		public NpcBodyType bodyType = NpcBodyType.SmallQuadruped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40030FE")]
		public MotivationConfig freeTimeMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003101")]
		public float walkSpeed = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4003102")]
		public float runSpeed = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4003104")]
		private bool interactingWithAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003105")]
		private IMotivation freeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003106")]
		private Animator _animator;

		[Cpp2IlInjected.Token(Token = "0x170005E5")]
		public NpcBodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6002864")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40", Slot = "4")]
			get
			{
				return bodyType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E6")]
		public MotivationConfig FreeTimeMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x6002865")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "5")]
			get
			{
				return freeTimeMotivation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E7")]
		public PetMaster Master
		{
			[Cpp2IlInjected.Token(Token = "0x6002866")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CMaster_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002867")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CMaster_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E8")]
		public NavMeshAgent Agent
		{
			[Cpp2IlInjected.Token(Token = "0x6002868")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CAgent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002869")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CAgent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E9")]
		public float WalkSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600286A")]
			[Cpp2IlInjected.Address(RVA = "0xCBE930", Offset = "0xCBD330", VA = "0x180CBE930", Slot = "6")]
			get
			{
				return walkSpeed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EA")]
		public float RunSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600286B")]
			[Cpp2IlInjected.Address(RVA = "0xF0F9B0", Offset = "0xF0E3B0", VA = "0x180F0F9B0", Slot = "7")]
			get
			{
				return RunSpeed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4003103")]
		public bool TraversingLink
		{
			[Cpp2IlInjected.Token(Token = "0x600286C")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600286D")]
			[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005EC")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x600286E")]
			[Cpp2IlInjected.Address(RVA = "0xF0F910", Offset = "0xF0E310", VA = "0x180F0F910")]
			get
			{
				//IL_0010: Expected O, but got I4
				Animator animator = _animator;
				int num = 0;
				if (animator == (UnityEngine.Object)num)
				{
					Animator animator2 = (_animator = GetComponentInChildren<Animator>());
				}
				return _animator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600286F")]
		[Cpp2IlInjected.Address(RVA = "0xF0F560", Offset = "0xF0DF60", VA = "0x180F0F560")]
		private void Awake()
		{
			NavMeshAgent navMeshAgent = (Agent = GetComponent<NavMeshAgent>());
			IMotivation motivation = (freeTime = freeTimeMotivation.Instantiate());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002870")]
		[Cpp2IlInjected.Address(RVA = "0xF0F660", Offset = "0xF0E060", VA = "0x180F0F660")]
		public void Init(PetMaster master)
		{
			Master = master;
			IMotivation motivation = freeTime;
			GameObject gameObject = base.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002871")]
		[Cpp2IlInjected.Address(RVA = "0xF0F5E0", Offset = "0xF0DFE0", VA = "0x180F0F5E0")]
		public void Execute(float elapsed)
		{
			//Discarded unreachable code: IL_0018
			if (!interactingWithAvatar)
			{
				IMotivation motivation = freeTime;
				GameObject gameObject = base.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002872")]
		[Cpp2IlInjected.Address(RVA = "0xF0F770", Offset = "0xF0E170", VA = "0x180F0F770")]
		public void PauseExecution()
		{
			NavMeshAgent navMeshAgent = Agent;
			int num = ((navMeshAgent.enabled = false) ? 1 : 0);
			Agent.isStopped = true;
			IMotivation motivation = freeTime;
			GameObject gameObject = base.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002873")]
		[Cpp2IlInjected.Address(RVA = "0xF0F800", Offset = "0xF0E200", VA = "0x180F0F800")]
		public void ResumeExecution()
		{
			Agent.enabled = true;
			NavMeshAgent navMeshAgent = Agent;
			int num = ((navMeshAgent.isStopped = false) ? 1 : 0);
			IMotivation motivation = freeTime;
			GameObject gameObject = base.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002874")]
		[Cpp2IlInjected.Address(RVA = "0xF0F6E0", Offset = "0xF0E0E0", VA = "0x180F0F6E0")]
		public bool IsInFrustum(Plane[] frustumPlanes)
		{
			//Discarded unreachable code: IL_0009
			Collider component = GetComponent<Collider>();
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002875")]
		[Cpp2IlInjected.Address(RVA = "0xF0F890", Offset = "0xF0E290", VA = "0x180F0F890")]
		public Pet()
		{
		}//IL_0020: Expected I4, but got I8

	}
}
