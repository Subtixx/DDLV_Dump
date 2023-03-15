using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters.Motivations;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006F3")]
	[RequireComponent(typeof(IVantagePointSlotPosition))]
	public class VantagePointSlot : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028BB")]
		[SerializeField]
		public bool WaterCharacterOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40028BF")]
		public float elapsed;

		[Cpp2IlInjected.Token(Token = "0x1700046D")]
		public IVantagePointSlotPosition Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001EDE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CPosition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EDF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CPosition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046E")]
		public bool IsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE2")]
			[Cpp2IlInjected.Address(RVA = "0xD448C0", Offset = "0xD432C0", VA = "0x180D448C0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject gameObject = Occupant;
				int num = 0;
				return gameObject == (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40028BD")]
		public bool IsAdmiringView
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE3")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001EE4")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000470")]
		public GameObject Occupant
		{
			[Cpp2IlInjected.Token(Token = "0x6001EE5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003COccupant_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EE6")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003COccupant_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE0")]
		[Cpp2IlInjected.Address(RVA = "0xD44270", Offset = "0xD42C70", VA = "0x180D44270")]
		public Vector3? Destination(GameObject agent)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			NavMeshAgent navMeshAgent = (NavMeshAgent)(object)((object)navMeshAgent + (object)navMeshAgent);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE1")]
		[Cpp2IlInjected.Address(RVA = "0xD44410", Offset = "0xD42E10", VA = "0x180D44410")]
		public bool IsReachable(GameObject agent)
		{
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE7")]
		[Cpp2IlInjected.Address(RVA = "0xD44130", Offset = "0xD42B30", VA = "0x180D44130")]
		private void Awake()
		{
			IVantagePointSlotPosition vantagePointSlotPosition = (Position = GetComponent<IVantagePointSlotPosition>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE8")]
		[Cpp2IlInjected.Address(RVA = "0xD44180", Offset = "0xD42B80", VA = "0x180D44180")]
		private void OnDestroy()
		{
			IsAdmiringView = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE9")]
		[Cpp2IlInjected.Address(RVA = "0xD44180", Offset = "0xD42B80", VA = "0x180D44180")]
		private void Cleanup()
		{
			IsAdmiringView = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEA")]
		[Cpp2IlInjected.Address(RVA = "0xD44190", Offset = "0xD42B90", VA = "0x180D44190")]
		private Vector3? Destination(GameObject agent, Vector3 position)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEB")]
		[Cpp2IlInjected.Address(RVA = "0xD44820", Offset = "0xD43220", VA = "0x180D44820")]
		public bool Take(GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject = Occupant;
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				Occupant = agent;
				return true;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEC")]
		[Cpp2IlInjected.Address(RVA = "0xD44620", Offset = "0xD43020", VA = "0x180D44620")]
		public bool Release(GameObject agent)
		{
			//IL_0018: Expected O, but got I8
			if (!(Occupant != agent))
			{
				Occupant = (GameObject)0;
				IsAdmiringView = false;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EED")]
		[Cpp2IlInjected.Address(RVA = "0xD44000", Offset = "0xD42A00", VA = "0x180D44000")]
		[AsyncStateMachine(typeof(_003CAdmireView_003Ed__24))]
		public Task AdmireView(GameObject agent, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEE")]
		[Cpp2IlInjected.Address(RVA = "0xD43EB0", Offset = "0xD428B0", VA = "0x180D43EB0")]
		[AsyncStateMachine(typeof(_003CAdmireView_003Ed__25))]
		public Task AdmireView(GameObject agent, float duration, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEF")]
		[Cpp2IlInjected.Address(RVA = "0xD446C0", Offset = "0xD430C0", VA = "0x180D446C0")]
		[AsyncStateMachine(typeof(_003CStartFishing_003Ed__26))]
		public Task StartFishing(GameObject agent, float duration, TriggerAnimOnTheSpotConfig fishingMotivationConfig, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF0")]
		[Cpp2IlInjected.Address(RVA = "0xD44530", Offset = "0xD42F30", VA = "0x180D44530")]
		public void Leave(GameObject agent, CancellationToken ct)
		{
			//IL_0027: Expected O, but got I8
			if (!(Occupant != agent))
			{
				if (!(Occupant != agent))
				{
					Occupant = (GameObject)0;
				}
				IsAdmiringView = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF1")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public VantagePointSlot()
		{
		}
	}
}
