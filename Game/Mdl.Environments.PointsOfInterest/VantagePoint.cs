using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006EC")]
	public class VantagePoint : MonoBehaviour, IPointOfInterest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028A1")]
		public VantagePointType pointType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40028A2")]
		public VantagePointConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40028A3")]
		public List<VantagePointSlot> slots = (List<VantagePointSlot>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40028A6")]
		private VantagePointSlot closestSlot;

		[Cpp2IlInjected.Token(Token = "0x17000466")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40028A4")]
		public bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBB")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001EBC")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000467")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBD")]
			[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000468")]
		public int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBE")]
			[Cpp2IlInjected.Address(RVA = "0xD45A50", Offset = "0xD44450", VA = "0x180D45A50", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_0038
				List<VantagePointSlot> list = slots;
				Func<VantagePointSlot, bool> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
				if (_003C_003E9__29_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VantagePointSlot s) => !s.IsAvailable);
				}
				return Enumerable.ToList<VantagePointSlot>(Enumerable.Where<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__29_))._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000469")]
		public int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBF")]
			[Cpp2IlInjected.Address(RVA = "0xD45A10", Offset = "0xD44410", VA = "0x180D45A10", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)slots)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046A")]
		public float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC0")]
			[Cpp2IlInjected.Address(RVA = "0xD45BC0", Offset = "0xD445C0", VA = "0x180D45BC0", Slot = "9")]
			get
			{
				//IL_0010: Expected O, but got I4
				VantagePointSlot vantagePointSlot = closestSlot;
				int num = 0;
				if (vantagePointSlot != (UnityEngine.Object)num)
				{
					VantagePointSlot vantagePointSlot2 = closestSlot;
					return Duration;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x40028A5")]
		private float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC1")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001EC2")]
			[Cpp2IlInjected.Address(RVA = "0xBC5B40", Offset = "0xBC4540", VA = "0x180BC5B40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700046C")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC3")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC4")]
		[Cpp2IlInjected.Address(RVA = "0xD45370", Offset = "0xD43D70", VA = "0x180D45370")]
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

		[Cpp2IlInjected.Token(Token = "0x6001EC5")]
		[Cpp2IlInjected.Address(RVA = "0xD45480", Offset = "0xD43E80", VA = "0x180D45480")]
		private float StimulusProbability(GameObject agent)
		{
			//IL_0034: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			List<VantagePointSlot> list = slots;
			Func<VantagePointSlot, bool> func = (Func<VantagePointSlot, bool>)(object)(Func<T, TResult>)delegate(VantagePointSlot s)
			{
				//Discarded unreachable code: IL_0016
				GameObject _003COccupant_003Ek__BackingField = s.Occupant;
				GameObject gameObject = agent;
				return _003COccupant_003Ek__BackingField == gameObject;
			};
			VantagePointSlot vantagePointSlot = Enumerable.FirstOrDefault<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			if (!(vantagePointSlot != (UnityEngine.Object)num))
			{
				List<VantagePointSlot> list2 = slots;
				Func<VantagePointSlot, bool> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
				if (_003C_003E9__29_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VantagePointSlot s) => !s.IsAvailable);
				}
				List<VantagePointSlot> list3 = (List<VantagePointSlot>)(object)Enumerable.ToList<VantagePointSlot>(Enumerable.Where<VantagePointSlot>((IEnumerable<>)list2, (Func<, >)(object)_003C_003E9__29_));
				List<VantagePointSlot> list4 = slots;
				Func<VantagePointSlot, bool> func2 = default(Func<VantagePointSlot, bool>);
				if (_003C_003Ec._003C_003E9__23_1 == null)
				{
					func2 = (Func<VantagePointSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VantagePointSlot s) => s.IsAdmiringView));
				}
				VantagePointSlot vantagePointSlot2 = Enumerable.FirstOrDefault<VantagePointSlot>((IEnumerable<>)list4, (Func<, >)(object)func2);
				int num2 = 0;
				if (vantagePointSlot2 != (UnityEngine.Object)num2)
				{
					return config.stimulusSocialProbability;
				}
				VantagePointConfig vantagePointConfig = config;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC6")]
		[Cpp2IlInjected.Address(RVA = "0xA63A00", Offset = "0xA62400", VA = "0x180A63A00")]
		private void OnDestroy()
		{
			Destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC7")]
		[Cpp2IlInjected.Address(RVA = "0xD451F0", Offset = "0xD43BF0", VA = "0x180D451F0", Slot = "10")]
		public float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig actionConfig)
		{
			//Discarded unreachable code: IL_0016
			int weightBonus = config.weightBonus;
			return PointOfInterestUtil.DefaultInterestWeight(this, avatar, actionConfig, weightBonus);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC8")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "11")]
		public bool CanInterruptAction(GameObject interruptee, GameObject interruptor)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC9")]
		[Cpp2IlInjected.Address(RVA = "0xD44A60", Offset = "0xD43460", VA = "0x180D44A60", Slot = "12")]
		public bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//IL_0009: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			int num = 0;
			if (actionConfig != (UnityEngine.Object)num && (object)actionConfig != null)
			{
				int num2 = 0;
				if ((object)actionConfig != null)
				{
					VantagePointType vantagePointType = pointType;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_0089;
					}
				}
			}
			bool canWalkOnLand = agent.GetComponent<NavMeshAreaHelper>()._canWalkOnLand;
			bool isLandCharacter = canWalkOnLand;
			List<VantagePointSlot> list = slots;
			Func<VantagePointSlot, bool> func = (Func<VantagePointSlot, bool>)(object)(Func<T, TResult>)delegate(VantagePointSlot s)
			{
				//Discarded unreachable code: IL_0021
				bool isAvailable = s.IsAvailable;
				if (!isAvailable)
				{
					return isAvailable;
				}
				bool flag2 = isLandCharacter;
				return s.WaterCharacterOnly != flag2;
			};
			VantagePointSlot vantagePointSlot = Enumerable.FirstOrDefault<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num3 = 0;
			if (!(vantagePointSlot == (UnityEngine.Object)num3))
			{
				Transform transform = vantagePointSlot.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
			}
			goto IL_0089;
			IL_0089:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECA")]
		[Cpp2IlInjected.Address(RVA = "0xD44920", Offset = "0xD43320", VA = "0x180D44920", Slot = "13")]
		public bool ArrivedAtPoint(GameObject agent)
		{
			//Discarded unreachable code: IL_0045
			//IL_0034: Expected O, but got I4
			List<VantagePointSlot> list = slots;
			Func<VantagePointSlot, bool> func = (Func<VantagePointSlot, bool>)(object)(Func<T, TResult>)delegate(VantagePointSlot x)
			{
				//Discarded unreachable code: IL_0016
				GameObject _003COccupant_003Ek__BackingField = x.Occupant;
				GameObject gameObject = agent;
				return _003COccupant_003Ek__BackingField == gameObject;
			};
			VantagePointSlot vantagePointSlot = Enumerable.FirstOrDefault<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			bool flag = vantagePointSlot != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			return vantagePointSlot.IsAdmiringView;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECB")]
		[Cpp2IlInjected.Address(RVA = "0xD45230", Offset = "0xD43C30", VA = "0x180D45230")]
		public List<VantagePointSlot> OccupiedSlots()
		{
			List<VantagePointSlot> list = slots;
			Func<VantagePointSlot, bool> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
			if (_003C_003E9__29_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VantagePointSlot s) => !s.IsAvailable);
			}
			return (List<VantagePointSlot>)(object)Enumerable.ToList<VantagePointSlot>(Enumerable.Where<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__29_));
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECC")]
		[Cpp2IlInjected.Address(RVA = "0xD44D70", Offset = "0xD43770", VA = "0x180D44D70")]
		public VantagePointSlot ClosestAvailableSlot(GameObject agent)
		{
			//Discarded unreachable code: IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			int num = 0;
			int num2 = 0;
			List<VantagePointSlot> list = slots;
			Func<VantagePointSlot, bool> _003C_003E9__30_ = _003C_003Ec._003C_003E9__30_0;
			if (_003C_003E9__30_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VantagePointSlot s) => s.IsAvailable);
			}
			IEnumerable<VantagePointSlot> enumerable = (IEnumerable<VantagePointSlot>)Enumerable.Where<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__30_);
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

		[Cpp2IlInjected.Token(Token = "0x6001ECD")]
		[Cpp2IlInjected.Address(RVA = "0xD45110", Offset = "0xD43B10", VA = "0x180D45110")]
		public VantagePointSlot FirstAvailableSlot(bool isLandCharacter)
		{
			//Discarded unreachable code: IL_0029
			List<VantagePointSlot> list = slots;
			Func<VantagePointSlot, bool> func = (Func<VantagePointSlot, bool>)(object)(Func<T, TResult>)delegate(VantagePointSlot s)
			{
				//Discarded unreachable code: IL_0021
				bool isAvailable = s.IsAvailable;
				if (!isAvailable)
				{
					return isAvailable;
				}
				bool flag = isLandCharacter;
				return s.WaterCharacterOnly != flag;
			};
			return Enumerable.FirstOrDefault<VantagePointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECE")]
		[Cpp2IlInjected.Address(RVA = "0xD45830", Offset = "0xD44230", VA = "0x180D45830", Slot = "14")]
		[AsyncStateMachine(typeof(_003CVisit_003Ed__32))]
		public Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECF")]
		[Cpp2IlInjected.Address(RVA = "0xD45990", Offset = "0xD44390", VA = "0x180D45990")]
		public VantagePoint()
		{
		}
	}
}
