using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000926")]
	internal class CritterWandering : Motivation<CritterWanderingConfig>, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.Token(Token = "0x2000927")]
		private enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40032ED")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40032EE")]
			Idle,
			[Cpp2IlInjected.Token(Token = "0x40032EF")]
			Walk,
			[Cpp2IlInjected.Token(Token = "0x40032F0")]
			Run
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032E7")]
		private Critter critter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032E8")]
		private float idleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40032E9")]
		private int rotateDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032EA")]
		private int destinations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40032EB")]
		private State _currentState;

		[Cpp2IlInjected.Token(Token = "0x1700060C")]
		private State currentState
		{
			[Cpp2IlInjected.Token(Token = "0x60029F5")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return _currentState;
			}
			[Cpp2IlInjected.Token(Token = "0x60029F6")]
			[Cpp2IlInjected.Address(RVA = "0x1102EC0", Offset = "0x11018C0", VA = "0x181102EC0")]
			set
			{
				//Discarded unreachable code: IL_0062
				if (_currentState == value)
				{
					return;
				}
				_currentState = value;
				if (value != 0 && value != 0)
				{
					switch (value)
					{
					case State.Idle:
					{
						NavMeshAgent agent2 = critter.Agent;
						float num2 = (agent2.speed = critter.runSpeed);
						break;
					}
					case State.None:
					{
						NavMeshAgent agent = critter.Agent;
						float num = (agent.speed = critter.walkSpeed);
						break;
					}
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029F7")]
		[Cpp2IlInjected.Address(RVA = "0x1102E70", Offset = "0x1101870", VA = "0x181102E70")]
		public CritterWandering(CritterWanderingConfig critterWanderingConfig)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)critterWanderingConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x60029F8")]
		[Cpp2IlInjected.Address(RVA = "0x1102810", Offset = "0x1101210", VA = "0x181102810", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_004c
			//IL_001e: Expected O, but got I4
			Critter critter = (this.critter = agent.GetComponent<Critter>());
			Critter critter2 = this.critter;
			int num = 0;
			if (critter2 != (UnityEngine.Object)num)
			{
				int minInclusive = 0;
				int num2 = (rotateDir = UnityEngine.Random.Range(minInclusive, 2));
				int num3 = (destinations = UnityEngine.Random.Range(minInclusive, 2));
				SetDestination();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029F9")]
		[Cpp2IlInjected.Address(RVA = "0x1102AA0", Offset = "0x11014A0", VA = "0x181102AA0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_0012: Expected I4, but got I8
			if (_currentState != 0)
			{
				_currentState = State.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029FA")]
		[Cpp2IlInjected.Address(RVA = "0x1102AA0", Offset = "0x11014A0", VA = "0x181102AA0", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			//IL_0012: Expected I4, but got I8
			if (_currentState != 0)
			{
				_currentState = State.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029FB")]
		[Cpp2IlInjected.Address(RVA = "0x1102910", Offset = "0x1101310", VA = "0x181102910", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_0032: Invalid comparison between I4 and F4
			while (true)
			{
				Critter critter = this.critter;
				int num = 0;
				if (critter == (UnityEngine.Object)num)
				{
					break;
				}
				State state = _currentState;
				if (state == State.Idle)
				{
					float num2 = idleTime;
					int num3 = 0;
					idleTime = num2;
					if (!((float)num3 <= num2))
					{
						destinations = (int)state;
						SetDestination();
					}
				}
				while (state > State.Idle)
				{
				}
				if (!this.critter.Agent.pathPending)
				{
					float remainingDistance = this.critter.Agent.remainingDistance;
					float stoppingDistance = this.critter.Agent.stoppingDistance;
					currentState = State.Idle;
					break;
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029FC")]
		[Cpp2IlInjected.Address(RVA = "0x1102AB0", Offset = "0x11014B0", VA = "0x181102AB0")]
		private Vector3 FindDestination()
		{
			int num = 0;
			Vector2 insideUnitCircle = UnityEngine.Random.insideUnitCircle;
			NavMeshAgent navMeshAgent = default(NavMeshAgent);
			int walkableMask = navMeshAgent.walkableMask;
			NavMeshAgent navMeshAgent2 = default(NavMeshAgent);
			int agentTypeID = navMeshAgent2.agentTypeID;
			bool flag = default(bool);
			if (!flag)
			{
				Transform transform = navMeshAgent2.transform;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029FD")]
		[Cpp2IlInjected.Address(RVA = "0x1102CC0", Offset = "0x11016C0", VA = "0x181102CC0")]
		private void SetDestination()
		{
			//Discarded unreachable code: IL_005a
			Critter critter = this.critter;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform = critter.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			currentState = State.Walk;
			if (this.critter.Agent.isActiveAndEnabled && this.critter.Agent.isOnNavMesh)
			{
				NavMeshAgent agent = this.critter.Agent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029FE")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "19")]
		public bool CanInteractWithAvatar()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60029FF")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
		public bool CanBeFed()
		{
			return true;
		}
	}
}
