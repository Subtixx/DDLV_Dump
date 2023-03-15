using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Items;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006BC")]
	public class Circuit : MonoBehaviour, IPointOfInterest
	{
		[Cpp2IlInjected.Token(Token = "0x20006BD")]
		private class Occupant
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40027CB")]
			public int currentPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40027CC")]
			public bool hasArrived;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40027CD")]
			public GameObject agent;

			[Cpp2IlInjected.Token(Token = "0x6001E00")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Occupant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027C2")]
		public CircuitConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027C3")]
		public List<Transform> points = (List<Transform>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40027C4")]
		private List<Occupant> occupants = (List<Occupant>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40027C5")]
		private List<float> cumulatedDistance = (List<float>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40027C7")]
		private float startedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40027C9")]
		private Task updateSpeedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40027CA")]
		private CancellationTokenSource ctSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x17000434")]
		public float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE2")]
			[Cpp2IlInjected.Address(RVA = "0xA82C70", Offset = "0xA81670", VA = "0x180A82C70", Slot = "9")]
			get
			{
				int num = 0;
				return Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000435")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x40027C6")]
		private float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE3")]
			[Cpp2IlInjected.Address(RVA = "0xA82BB0", Offset = "0xA815B0", VA = "0x180A82BB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001DE4")]
			[Cpp2IlInjected.Address(RVA = "0xA82CD0", Offset = "0xA816D0", VA = "0x180A82CD0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000436")]
		private float elapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE5")]
			[Cpp2IlInjected.Address(RVA = "0xA82CB0", Offset = "0xA816B0", VA = "0x180A82CB0")]
			get
			{
				int num = 0;
				return Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000437")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40027C8")]
		public bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE6")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001DE7")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000438")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE8")]
			[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000439")]
		public int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE9")]
			[Cpp2IlInjected.Address(RVA = "0xA82BE0", Offset = "0xA815E0", VA = "0x180A82BE0", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)occupants)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043A")]
		public int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001DEA")]
			[Cpp2IlInjected.Address(RVA = "0xA82BC0", Offset = "0xA815C0", VA = "0x180A82BC0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return config.maxOccupants;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043B")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001DEB")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEC")]
		[Cpp2IlInjected.Address(RVA = "0xA81160", Offset = "0xA7FB60", VA = "0x180A81160")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DED")]
		[Cpp2IlInjected.Address(RVA = "0xA82580", Offset = "0xA80F80", VA = "0x180A82580")]
		private void Start()
		{
			//Discarded unreachable code: IL_0043
			//IL_0010: Expected O, but got I4
			StimulusBroadcaster componentInChildren = GetComponentInChildren<StimulusBroadcaster>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				GameObject sender = base.gameObject;
				StimulusBroadcaster.ProbabilityFunction probability = StimulusProbability;
				componentInChildren.Broadcast(sender, this, probability);
			}
			int num2 = 0;
			float num3 = (startedTime = Time.time);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEE")]
		[Cpp2IlInjected.Address(RVA = "0xA3C690", Offset = "0xA3B090", VA = "0x180A3C690")]
		private void OnDestroy()
		{
			Destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEF")]
		[Cpp2IlInjected.Address(RVA = "0xA81B90", Offset = "0xA80590", VA = "0x180A81B90", Slot = "10")]
		public float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig actionConfig)
		{
			//Discarded unreachable code: IL_0016
			int weightBonus = config.weightBonus;
			return PointOfInterestUtil.DefaultInterestWeight(this, avatar, actionConfig, weightBonus);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF0")]
		[Cpp2IlInjected.Address(RVA = "0xA821A0", Offset = "0xA80BA0", VA = "0x180A821A0")]
		public int NextClosestPointIndex(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF1")]
		[Cpp2IlInjected.Address(RVA = "0xA81BD0", Offset = "0xA805D0", VA = "0x180A81BD0")]
		public bool IsReachable(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF2")]
		[Cpp2IlInjected.Address(RVA = "0xA81840", Offset = "0xA80240", VA = "0x180A81840")]
		private Vector3? Destination(GameObject agent, Vector3 position)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF3")]
		[Cpp2IlInjected.Address(RVA = "0xA81350", Offset = "0xA7FD50", VA = "0x180A81350", Slot = "11")]
		public bool CanInterruptAction(GameObject interruptee, GameObject interruptor)
		{
			GameObject gameObject = interruptor;
			if (!(interruptee == gameObject))
			{
				List<Occupant> list = occupants;
				Func<Occupant, bool> func = (Func<Occupant, bool>)(object)(Func<T, TResult>)delegate(Occupant o)
				{
					//Discarded unreachable code: IL_0016
					GameObject agent = o.agent;
					GameObject gameObject2 = interruptor;
					return agent == gameObject2;
				};
				Occupant occupant = Enumerable.FirstOrDefault<Occupant>((IEnumerable<>)list, (Func<, >)(object)func);
				if (occupant != null)
				{
					return !occupant.hasArrived;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF4")]
		[Cpp2IlInjected.Address(RVA = "0xA814A0", Offset = "0xA7FEA0", VA = "0x180A814A0", Slot = "12")]
		public bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//Discarded unreachable code: IL_0017
			List<Occupant> list = occupants;
			int maxOccupants = config.maxOccupants;
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF5")]
		[Cpp2IlInjected.Address(RVA = "0xA81060", Offset = "0xA7FA60", VA = "0x180A81060", Slot = "13")]
		public bool ArrivedAtPoint(GameObject agent)
		{
			//Discarded unreachable code: IL_0034
			List<Occupant> list = occupants;
			Func<Occupant, bool> func = (Func<Occupant, bool>)(object)(Func<T, TResult>)delegate(Occupant x)
			{
				//Discarded unreachable code: IL_0016
				GameObject agent2 = x.agent;
				GameObject gameObject = agent;
				return agent2 == gameObject;
			};
			Occupant occupant = Enumerable.FirstOrDefault<Occupant>((IEnumerable<>)list, (Func<, >)(object)func);
			if (occupant == null)
			{
			}
			return occupant.hasArrived;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF6")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0", Slot = "14")]
		[AsyncStateMachine(typeof(_003CVisit_003Ed__38))]
		public Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF7")]
		[Cpp2IlInjected.Address(RVA = "0xA827A0", Offset = "0xA811A0", VA = "0x180A827A0")]
		[AsyncStateMachine(typeof(_003CUpdateSpeed_003Ed__39))]
		private Task UpdateSpeed(Occupant agent, float runSpeed, float walkSpeed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF8")]
		[Cpp2IlInjected.Address(RVA = "0xA81EA0", Offset = "0xA808A0", VA = "0x180A81EA0")]
		private bool IsRunning(Occupant agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF9")]
		[Cpp2IlInjected.Address(RVA = "0xA816B0", Offset = "0xA800B0", VA = "0x180A816B0")]
		private (Occupant, float) ClosestInFront(Occupant agent)
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFA")]
		[Cpp2IlInjected.Address(RVA = "0xA81520", Offset = "0xA7FF20", VA = "0x180A81520")]
		private (Occupant, float) ClosestBehind(Occupant agent)
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFB")]
		[Cpp2IlInjected.Address(RVA = "0xA82690", Offset = "0xA81090", VA = "0x180A82690")]
		private float StimulusProbability(GameObject agent)
		{
			List<Occupant> list = occupants;
			if (list != null)
			{
				Func<Occupant, bool> cpp2il__autoParamName__idx_ = (Func<Occupant, bool>)(object)(Func<T, TResult>)delegate(Occupant x)
				{
					//Discarded unreachable code: IL_0016
					GameObject agent2 = x.agent;
					GameObject gameObject = agent;
					return agent2 == gameObject;
				};
				if (((IEnumerable<>)list).Any<Occupant>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					int num = 0;
				}
			}
			CircuitConfig circuitConfig = config;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFC")]
		[Cpp2IlInjected.Address(RVA = "0xA81AF0", Offset = "0xA804F0", VA = "0x180A81AF0")]
		private float DistanceBetween(Occupant infront, Occupant behind)
		{
			float num = DistanceAlongCircuit(infront);
			float num2 = DistanceAlongCircuit(behind);
			if (!(num >= num2))
			{
				float num3 = ((IEnumerable<>)cumulatedDistance).Last<float>();
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFD")]
		[Cpp2IlInjected.Address(RVA = "0xA81920", Offset = "0xA80320", VA = "0x180A81920")]
		private float DistanceAlongCircuit(Occupant a)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFE")]
		[Cpp2IlInjected.Address(RVA = "0xA82360", Offset = "0xA80D60", VA = "0x180A82360")]
		private void OnDrawGizmos()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFF")]
		[Cpp2IlInjected.Address(RVA = "0xA82A70", Offset = "0xA81470", VA = "0x180A82A70")]
		public Circuit()
		{
		}
	}
}
