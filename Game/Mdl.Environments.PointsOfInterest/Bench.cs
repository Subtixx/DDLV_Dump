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
	[Cpp2IlInjected.Token(Token = "0x20006AD")]
	public class Bench : MonoBehaviour, IPointOfInterest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002770")]
		public BenchConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002771")]
		public List<Seat> seats = (List<Seat>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002774")]
		private Seat closestSeat;

		[Cpp2IlInjected.Token(Token = "0x17000429")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4002772")]
		public bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001D9F")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001DA0")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA1")]
			[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		public int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA2")]
			[Cpp2IlInjected.Address(RVA = "0x163F2B0", Offset = "0x163DCB0", VA = "0x18163F2B0", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_0038
				List<Seat> list = seats;
				Func<Seat, bool> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
				if (_003C_003E9__29_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => !s.IsAvailable);
				}
				return Enumerable.ToList<Seat>(Enumerable.Where<Seat>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__29_))._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		public int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA3")]
			[Cpp2IlInjected.Address(RVA = "0x163F270", Offset = "0x163DC70", VA = "0x18163F270", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)seats)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		public float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA4")]
			[Cpp2IlInjected.Address(RVA = "0x163F420", Offset = "0x163DE20", VA = "0x18163F420", Slot = "9")]
			get
			{
				//IL_0010: Expected O, but got I4
				Seat seat = closestSeat;
				int num = 0;
				if (seat != (UnityEngine.Object)num)
				{
					Seat seat2 = closestSeat;
					return Duration;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x4002773")]
		private float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA5")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001DA6")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA7")]
			[Cpp2IlInjected.Address(RVA = "0x163F220", Offset = "0x163DC20", VA = "0x18163F220", Slot = "8")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.GetComponentInParent<ItemScript>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA8")]
		[Cpp2IlInjected.Address(RVA = "0x163EB70", Offset = "0x163D570", VA = "0x18163EB70")]
		private void Start()
		{
			//Discarded unreachable code: IL_0031
			//IL_0010: Expected O, but got I4
			StimulusBroadcaster componentInChildren = GetComponentInChildren<StimulusBroadcaster>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				GameObject sender = base.gameObject;
				StimulusBroadcaster.ProbabilityFunction probability = StimulusProbability;
				componentInChildren.Broadcast(sender, this, probability);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA9")]
		[Cpp2IlInjected.Address(RVA = "0x163EC80", Offset = "0x163D680", VA = "0x18163EC80")]
		private float StimulusProbability(GameObject agent)
		{
			//IL_0034: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			List<Seat> list = seats;
			Func<Seat, bool> func = (Func<Seat, bool>)(object)(Func<T, TResult>)delegate(Seat s)
			{
				//Discarded unreachable code: IL_0016
				GameObject occupant = s.Occupant;
				GameObject gameObject = agent;
				return occupant == gameObject;
			};
			Seat seat = Enumerable.FirstOrDefault<Seat>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			if (!(seat != (UnityEngine.Object)num))
			{
				List<Seat> list2 = seats;
				Func<Seat, bool> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
				if (_003C_003E9__29_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => !s.IsAvailable);
				}
				List<Seat> list3 = (List<Seat>)(object)Enumerable.ToList<Seat>(Enumerable.Where<Seat>((IEnumerable<>)list2, (Func<, >)(object)_003C_003E9__29_));
				List<Seat> list4 = seats;
				Func<Seat, bool> func2 = default(Func<Seat, bool>);
				if (_003C_003Ec._003C_003E9__22_1 == null)
				{
					func2 = (Func<Seat, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => s.IsSeated));
				}
				Seat seat2 = Enumerable.FirstOrDefault<Seat>((IEnumerable<>)list4, (Func<, >)(object)func2);
				int num2 = 0;
				if (seat2 != (UnityEngine.Object)num2)
				{
					return config.stimulusSocialProbability;
				}
				BenchConfig benchConfig = config;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAA")]
		[Cpp2IlInjected.Address(RVA = "0x163EB60", Offset = "0x163D560", VA = "0x18163EB60")]
		private void OnDestroy()
		{
			Destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAB")]
		[Cpp2IlInjected.Address(RVA = "0x163E9E0", Offset = "0x163D3E0", VA = "0x18163E9E0", Slot = "10")]
		public float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig actionConfig)
		{
			//Discarded unreachable code: IL_0016
			int weightBonus = config.weightBonus;
			return PointOfInterestUtil.DefaultInterestWeight(this, avatar, actionConfig, weightBonus);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAC")]
		[Cpp2IlInjected.Address(RVA = "0x163DF00", Offset = "0x163C900", VA = "0x18163DF00", Slot = "11")]
		public bool CanInterruptAction(GameObject interruptee, GameObject interruptor)
		{
			//Discarded unreachable code: IL_0043
			//IL_0034: Expected O, but got I4
			List<Seat> list = seats;
			Func<Seat, bool> func = (Func<Seat, bool>)(object)(Func<T, TResult>)delegate(Seat s)
			{
				//Discarded unreachable code: IL_0016
				GameObject occupant = s.Occupant;
				GameObject gameObject = interruptee;
				return occupant == gameObject;
			};
			Seat seat = Enumerable.FirstOrDefault<Seat>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			if (seat == (UnityEngine.Object)num)
			{
				return true;
			}
			return !seat.IsSeated;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAD")]
		[Cpp2IlInjected.Address(RVA = "0x163E050", Offset = "0x163CA50", VA = "0x18163E050", Slot = "12")]
		public bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//IL_003f: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if (agent.GetComponent<INpc>() != null)
			{
				BenchConfig benchConfig = config;
				int num = 0;
				List<NpcBodyType> allowedBodyTypes = benchConfig.allowedBodyTypes;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_008e;
				}
			}
			Seat seat = CurrentSeat(agent);
			int num3 = 0;
			if (!(seat != (UnityEngine.Object)num3))
			{
				List<Seat> list = seats;
				Func<Seat, bool> func = default(Func<Seat, bool>);
				if (_003C_003Ec._003C_003E9__31_0 == null)
				{
					func = (Func<Seat, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => s.IsAvailable));
				}
				Seat seat2 = Enumerable.FirstOrDefault<Seat>((IEnumerable<>)list, (Func<, >)(object)func);
				int num4 = 0;
				if (!(seat2 == (UnityEngine.Object)num4))
				{
					return seat2.IsReachable(agent);
				}
			}
			goto IL_008e;
			IL_008e:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAE")]
		[Cpp2IlInjected.Address(RVA = "0x163DDB0", Offset = "0x163C7B0", VA = "0x18163DDB0", Slot = "13")]
		public bool ArrivedAtPoint(GameObject agent)
		{
			//Discarded unreachable code: IL_0045
			//IL_0034: Expected O, but got I4
			List<Seat> list = seats;
			Func<Seat, bool> func = (Func<Seat, bool>)(object)(Func<T, TResult>)delegate(Seat x)
			{
				//Discarded unreachable code: IL_0016
				GameObject occupant = x.Occupant;
				GameObject gameObject = agent;
				return occupant == gameObject;
			};
			Seat seat = Enumerable.FirstOrDefault<Seat>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			bool flag = seat != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			return seat.IsSeated;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAF")]
		[Cpp2IlInjected.Address(RVA = "0x163E6C0", Offset = "0x163D0C0", VA = "0x18163E6C0")]
		public Seat CurrentSeat(GameObject agent)
		{
			//IL_000b: Expected O, but got I4
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (agent == (UnityEngine.Object)num2)
				{
					break;
				}
				List<Seat> list = seats;
				if (flag)
				{
					if (!(gameObject == agent))
					{
						continue;
					}
					num++;
				}
				if (num + 1 == 0)
				{
				}
				break;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB0")]
		[Cpp2IlInjected.Address(RVA = "0x163EA20", Offset = "0x163D420", VA = "0x18163EA20")]
		public List<Seat> OccupiedSeats()
		{
			List<Seat> list = seats;
			Func<Seat, bool> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
			if (_003C_003E9__29_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => !s.IsAvailable);
			}
			return (List<Seat>)(object)Enumerable.ToList<Seat>(Enumerable.Where<Seat>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__29_));
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB1")]
		[Cpp2IlInjected.Address(RVA = "0x163E320", Offset = "0x163CD20", VA = "0x18163E320")]
		public Seat ClosestAvailableSeat(GameObject agent)
		{
			//Discarded unreachable code: IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			int num = 0;
			int num2 = 0;
			List<Seat> list = seats;
			Func<Seat, bool> _003C_003E9__30_ = _003C_003Ec._003C_003E9__30_0;
			if (_003C_003E9__30_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => s.IsAvailable);
			}
			IEnumerable<Seat> enumerable = (IEnumerable<Seat>)Enumerable.Where<Seat>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__30_);
			int num4 = default(int);
			if (enumerable != null)
			{
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_0067;
					}
					num2++;
				}
				Transform transform = agent.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				num4 = 0;
				goto IL_0067;
			}
			goto IL_006e;
			IL_0067:
			num4 += num4;
			goto IL_006e;
			IL_006e:
			if (enumerable != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB2")]
		[Cpp2IlInjected.Address(RVA = "0x163E8B0", Offset = "0x163D2B0", VA = "0x18163E8B0")]
		public Seat FirstAvailableSeat()
		{
			List<Seat> list = seats;
			Func<Seat, bool> _003C_003E9__31_ = _003C_003Ec._003C_003E9__31_0;
			if (_003C_003E9__31_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Seat s) => s.IsAvailable);
			}
			return Enumerable.FirstOrDefault<Seat>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__31_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB3")]
		[Cpp2IlInjected.Address(RVA = "0x163F030", Offset = "0x163DA30", VA = "0x18163F030", Slot = "14")]
		[AsyncStateMachine(typeof(_003CVisit_003Ed__32))]
		public Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB4")]
		[Cpp2IlInjected.Address(RVA = "0x163F1A0", Offset = "0x163DBA0", VA = "0x18163F1A0")]
		public Bench()
		{
		}
	}
}
