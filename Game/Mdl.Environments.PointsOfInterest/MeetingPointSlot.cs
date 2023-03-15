using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006DA")]
	public class MeetingPointSlot : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400283C")]
		[SerializeField]
		public bool WaterCharacterOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400283F")]
		private MeetingParameters parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002841")]
		private Task lookAtTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002842")]
		public float elapsed;

		[Cpp2IlInjected.Token(Token = "0x17000454")]
		public bool IsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6001E6C")]
			[Cpp2IlInjected.Address(RVA = "0xBC4020", Offset = "0xBC2A20", VA = "0x180BC4020")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject gameObject = Occupant;
				int num = 0;
				return gameObject == (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000455")]
		public GameObject Occupant
		{
			[Cpp2IlInjected.Token(Token = "0x6001E6D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003COccupant_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003COccupant_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000456")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400283E")]
		public bool InMeeting
		{
			[Cpp2IlInjected.Token(Token = "0x6001E6F")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E70")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000457")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4002840")]
		public bool OccupantArrived
		{
			[Cpp2IlInjected.Token(Token = "0x6001E71")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E72")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E6A")]
		[Cpp2IlInjected.Address(RVA = "0xBC2B70", Offset = "0xBC1570", VA = "0x180BC2B70")]
		public Vector3? Destination(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E6B")]
		[Cpp2IlInjected.Address(RVA = "0xBC2CF0", Offset = "0xBC16F0", VA = "0x180BC2CF0")]
		public bool IsReachable(GameObject agent)
		{
			NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E73")]
		[Cpp2IlInjected.Address(RVA = "0xBC2A90", Offset = "0xBC1490", VA = "0x180BC2A90")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_003b
			//IL_0017: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			GameObject gameObject = Occupant;
			InMeeting = false;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				NavMeshAgent component = Occupant.GetComponent<NavMeshAgent>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					component.avoidancePriority = 50;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E74")]
		[Cpp2IlInjected.Address(RVA = "0xBC2A90", Offset = "0xBC1490", VA = "0x180BC2A90")]
		private void Cleanup()
		{
			//Discarded unreachable code: IL_003b
			//IL_0017: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			GameObject gameObject = Occupant;
			InMeeting = false;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				NavMeshAgent component = Occupant.GetComponent<NavMeshAgent>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					component.avoidancePriority = 50;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E75")]
		[Cpp2IlInjected.Address(RVA = "0xBC3870", Offset = "0xBC2270", VA = "0x180BC3870")]
		public bool Take(GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject = Occupant;
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				InMeeting = false;
				Occupant = agent;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E76")]
		[Cpp2IlInjected.Address(RVA = "0xBC37D0", Offset = "0xBC21D0", VA = "0x180BC37D0")]
		public bool Release(GameObject agent)
		{
			//IL_0021: Expected O, but got I8
			bool flag = Occupant != agent;
			if (!flag)
			{
				InMeeting = flag;
				Occupant = (GameObject)0;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E77")]
		[Cpp2IlInjected.Address(RVA = "0xBC2C70", Offset = "0xBC1670", VA = "0x180BC2C70")]
		public bool HasArrived()
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject = Occupant;
			int num = 0;
			if (!(gameObject == (UnityEngine.Object)num))
			{
				return OccupantArrived;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E78")]
		[Cpp2IlInjected.Address(RVA = "0xBC36A0", Offset = "0xBC20A0", VA = "0x180BC36A0")]
		[AsyncStateMachine(typeof(_003CReact_003Ed__25))]
		public Task React(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E79")]
		[Cpp2IlInjected.Address(RVA = "0xBC2F80", Offset = "0xBC1980", VA = "0x180BC2F80")]
		[AsyncStateMachine(typeof(_003CJoinMeeting_003Ed__26))]
		public Task JoinMeeting(GameObject agent, MeetingPoint meeting, MeetingParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7A")]
		[Cpp2IlInjected.Address(RVA = "0xBC2E10", Offset = "0xBC1810", VA = "0x180BC2E10")]
		[AsyncStateMachine(typeof(_003CJoinMeeting_003Ed__27))]
		public Task JoinMeeting(GameObject agent, MeetingPoint meeting, MeetingParameters parameters, float duration, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7B")]
		[Cpp2IlInjected.Address(RVA = "0xBC30F0", Offset = "0xBC1AF0", VA = "0x180BC30F0")]
		[AsyncStateMachine(typeof(_003CLeaveMeeting_003Ed__28))]
		public Task LeaveMeeting(GameObject agent, MeetingPoint meeting, MeetingParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7C")]
		[Cpp2IlInjected.Address(RVA = "0xBC3BB0", Offset = "0xBC25B0", VA = "0x180BC3BB0")]
		private void UpdateAllFriendLookAts(MeetingPoint meeting, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0010
			List<MeetingPointSlot> list = (List<MeetingPointSlot>)(object)meeting.OccupiedSlots();
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7D")]
		[Cpp2IlInjected.Address(RVA = "0xBC3ED0", Offset = "0xBC28D0", VA = "0x180BC3ED0")]
		public void UpdateLookAt(MeetingPoint meeting, CancellationToken ct)
		{
			int num = 0;
			Task task = default(Task);
			lookAtTask = task;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7E")]
		[Cpp2IlInjected.Address(RVA = "0xBC3920", Offset = "0xBC2320", VA = "0x180BC3920")]
		private void UpdateAllAvoidancePriorities(MeetingPoint meeting, bool resetAvoidance, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0063, IL_0069, IL_006f, IL_0075, IL_007b
			int num = 0;
			List<MeetingPointSlot> list = (List<MeetingPointSlot>)(object)meeting.OccupiedSlots();
			List<MeetingPointSlot> list2 = (List<MeetingPointSlot>)(object)meeting.OccupiedSlots();
			Func<MeetingPointSlot, bool> func = (Func<MeetingPointSlot, bool>)(object)(Func<T, TResult>)((MeetingPointSlot x) => HasArrived());
			IEnumerable<MeetingPointSlot> enumerable = (IEnumerable<MeetingPointSlot>)Enumerable.Where<MeetingPointSlot>((IEnumerable<>)list2, (Func<, >)(object)func);
			NavMeshAgent navMeshAgent = default(NavMeshAgent);
			int num4 = default(int);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_004d;
					}
					num++;
				}
				if (!resetAvoidance)
				{
					num4 = (navMeshAgent.avoidancePriority = 0);
					goto IL_004d;
				}
				goto IL_0054;
			}
			goto IL_005d;
			IL_005d:
			if (enumerable == null)
			{
			}
			return;
			IL_004d:
			num4 += num4;
			goto IL_0054;
			IL_0054:
			navMeshAgent.avoidancePriority = 50;
			goto IL_005d;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7F")]
		[Cpp2IlInjected.Address(RVA = "0xBC3D10", Offset = "0xBC2710", VA = "0x180BC3D10")]
		public void UpdateAvoidancePriority(bool resetAvoidance, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0023
			NavMeshAgent component = Occupant.GetComponent<NavMeshAgent>();
			if (!resetAvoidance)
			{
				int num2 = (component.avoidancePriority = 0);
			}
			else
			{
				component.avoidancePriority = 50;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E80")]
		[Cpp2IlInjected.Address(RVA = "0xBC3D90", Offset = "0xBC2790", VA = "0x180BC3D90")]
		[AsyncStateMachine(typeof(_003CUpdateLookAtAsync_003Ed__33))]
		private Task UpdateLookAtAsync(MeetingPoint meeting, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E81")]
		[Cpp2IlInjected.Address(RVA = "0xBC3260", Offset = "0xBC1C60", VA = "0x180BC3260")]
		private void OnDrawGizmos()
		{
			//Discarded unreachable code: IL_0062
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform5 = base.transform;
			Transform transform6 = base.transform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Transform transform7 = base.transform;
			Transform transform8 = base.transform;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E82")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MeetingPointSlot()
		{
		}
	}
}
