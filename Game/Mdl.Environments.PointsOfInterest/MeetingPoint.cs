using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006CF")]
	public class MeetingPoint : MonoBehaviour, IPointOfInterest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400280F")]
		public MeetingPointConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002810")]
		public Transform soloWatchPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002811")]
		public List<MeetingPointSlot> slots = (List<MeetingPointSlot>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002814")]
		private MeetingPointSlot closestSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002815")]
		private CancellationTokenSource discussTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002816")]
		private Task discuss;

		[Cpp2IlInjected.Token(Token = "0x1700044D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4002812")]
		public bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E3B")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E3C")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700044E")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001E3D")]
			[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044F")]
		public int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E3E")]
			[Cpp2IlInjected.Address(RVA = "0xBC5A60", Offset = "0xBC4460", VA = "0x180BC5A60", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return this.OccupiedSlots()._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000450")]
		public int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E3F")]
			[Cpp2IlInjected.Address(RVA = "0xBC5A20", Offset = "0xBC4420", VA = "0x180BC5A20", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)slots)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000451")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001E40")]
			[Cpp2IlInjected.Address(RVA = "0xBC59D0", Offset = "0xBC43D0", VA = "0x180BC59D0", Slot = "8")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.GetComponentInParent<ItemScript>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000452")]
		public float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001E41")]
			[Cpp2IlInjected.Address(RVA = "0xBC5AB0", Offset = "0xBC44B0", VA = "0x180BC5AB0", Slot = "9")]
			get
			{
				//IL_0010: Expected O, but got I4
				MeetingPointSlot meetingPointSlot = closestSlot;
				int num = 0;
				if (meetingPointSlot != (UnityEngine.Object)num)
				{
					MeetingPointSlot meetingPointSlot2 = closestSlot;
					return Duration;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000453")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4002813")]
		private float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001E42")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E43")]
			[Cpp2IlInjected.Address(RVA = "0xBC5B40", Offset = "0xBC4540", VA = "0x180BC5B40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E44")]
		[Cpp2IlInjected.Address(RVA = "0xBC5410", Offset = "0xBC3E10", VA = "0x180BC5410")]
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

		[Cpp2IlInjected.Token(Token = "0x6001E45")]
		[Cpp2IlInjected.Address(RVA = "0xBC5520", Offset = "0xBC3F20", VA = "0x180BC5520")]
		private float StimulusProbability(GameObject agent)
		{
			//IL_0034: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> func = (Func<MeetingPointSlot, bool>)(object)(Func<T, TResult>)delegate(MeetingPointSlot s)
			{
				//Discarded unreachable code: IL_0016
				GameObject _003COccupant_003Ek__BackingField = s.Occupant;
				GameObject gameObject = agent;
				return _003COccupant_003Ek__BackingField == gameObject;
			};
			MeetingPointSlot meetingPointSlot = Enumerable.FirstOrDefault<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			if (!(meetingPointSlot != (UnityEngine.Object)num))
			{
				List<MeetingPointSlot> list2 = (List<MeetingPointSlot>)(object)this.OccupiedSlots();
				List<MeetingPointSlot> list3 = slots;
				Func<MeetingPointSlot, bool> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_1;
				if (_003C_003E9__25_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MeetingPointSlot s) => s.InMeeting);
				}
				MeetingPointSlot meetingPointSlot2 = Enumerable.FirstOrDefault<MeetingPointSlot>((IEnumerable<>)list3, (Func<, >)(object)_003C_003E9__25_);
				int num2 = 0;
				if (meetingPointSlot2 != (UnityEngine.Object)num2)
				{
					return config.stimulusSocialProbability;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E46")]
		[Cpp2IlInjected.Address(RVA = "0xA63A00", Offset = "0xA62400", VA = "0x180A63A00")]
		private void OnDestroy()
		{
			Destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E47")]
		[Cpp2IlInjected.Address(RVA = "0xBC50B0", Offset = "0xBC3AB0", VA = "0x180BC50B0", Slot = "10")]
		public float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig actionConfig)
		{
			//IL_000f: Expected O, but got I4
			if ((object)actionConfig == null)
			{
			}
			int num = 0;
			int num2 = 0;
			MeetingPointConfig meetingPointConfig = default(MeetingPointConfig);
			if (actionConfig != (UnityEngine.Object)num2)
			{
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				GameObject gameObject = default(GameObject);
				IPointOfInterest[] _003CPointsOfInterest_003Ek__BackingField = gameObject.GetComponentInChildren<Environment>().PointsOfInterest;
				if (CharacterUtil.GetHouseMeetingPoint(agent, (IEnumerable<>)(object)_003CPointsOfInterest_003Ek__BackingField) != null)
				{
					if ((object)meetingPointConfig != this)
					{
					}
					throw new NullReferenceException();
				}
			}
			meetingPointConfig = config;
			int weightBonus = meetingPointConfig.weightBonus;
			return PointOfInterestUtil.DefaultInterestWeight(this, avatar, actionConfig, weightBonus);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E48")]
		[Cpp2IlInjected.Address(RVA = "0xBC41D0", Offset = "0xBC2BD0", VA = "0x180BC41D0", Slot = "11")]
		public bool CanInterruptAction(GameObject interruptee, GameObject interruptor)
		{
			//IL_0034: Expected O, but got I4
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> func = (Func<MeetingPointSlot, bool>)(object)(Func<T, TResult>)delegate(MeetingPointSlot s)
			{
				//Discarded unreachable code: IL_0016
				GameObject _003COccupant_003Ek__BackingField = s.Occupant;
				GameObject gameObject = interruptee;
				return _003COccupant_003Ek__BackingField == gameObject;
			};
			MeetingPointSlot meetingPointSlot = Enumerable.FirstOrDefault<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			bool flag = meetingPointSlot == (UnityEngine.Object)num;
			if (!flag && meetingPointSlot.InMeeting != flag)
			{
				List<MeetingPointSlot> list2 = slots;
				Predicate<MeetingPointSlot> _003C_003E9__28_ = _003C_003Ec._003C_003E9__28_1;
				if (_003C_003E9__28_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((MeetingPointSlot s) => s.InMeeting);
				}
				return Enumerable.Count<MeetingPointSlot>((IEnumerable<>)((List<T>)(object)list2).FindAll((Predicate<>)(object)_003C_003E9__28_)) == 1;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E49")]
		[Cpp2IlInjected.Address(RVA = "0xBC4440", Offset = "0xBC2E40", VA = "0x180BC4440", Slot = "12")]
		public bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//IL_0042: Expected O, but got I4
			bool canWalkOnLand = agent.GetComponent<NavMeshAreaHelper>()._canWalkOnLand;
			bool isLandCharacter = canWalkOnLand;
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> func = (Func<MeetingPointSlot, bool>)(object)(Func<T, TResult>)delegate(MeetingPointSlot s)
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
			MeetingPointSlot meetingPointSlot = Enumerable.FirstOrDefault<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			if (!(meetingPointSlot == (UnityEngine.Object)num))
			{
				NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
				Transform transform = meetingPointSlot.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4A")]
		[Cpp2IlInjected.Address(RVA = "0xBC4080", Offset = "0xBC2A80", VA = "0x180BC4080", Slot = "13")]
		public bool ArrivedAtPoint(GameObject agent)
		{
			//Discarded unreachable code: IL_0045
			//IL_0034: Expected O, but got I4
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> func = (Func<MeetingPointSlot, bool>)(object)(Func<T, TResult>)delegate(MeetingPointSlot x)
			{
				//Discarded unreachable code: IL_0016
				GameObject _003COccupant_003Ek__BackingField = x.Occupant;
				GameObject gameObject = agent;
				return _003COccupant_003Ek__BackingField == gameObject;
			};
			MeetingPointSlot meetingPointSlot = Enumerable.FirstOrDefault<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			bool flag = meetingPointSlot != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			return meetingPointSlot.HasArrived();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4B")]
		[Cpp2IlInjected.Address(RVA = "0xBC52D0", Offset = "0xBC3CD0", VA = "0x180BC52D0")]
		public List<MeetingPointSlot> OccupiedSlots()
		{
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> _003C_003E9__31_ = _003C_003Ec._003C_003E9__31_0;
			if (_003C_003E9__31_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MeetingPointSlot s) => !s.IsAvailable);
			}
			return (List<MeetingPointSlot>)(object)Enumerable.ToList<MeetingPointSlot>(Enumerable.Where<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__31_));
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4C")]
		[Cpp2IlInjected.Address(RVA = "0xBC46B0", Offset = "0xBC30B0", VA = "0x180BC46B0")]
		public MeetingPointSlot ClosestAvailableSlot(GameObject agent)
		{
			//Discarded unreachable code: IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			int num = 0;
			int num2 = 0;
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> _003C_003E9__32_ = _003C_003Ec._003C_003E9__32_0;
			if (_003C_003E9__32_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MeetingPointSlot s) => s.IsAvailable);
			}
			IEnumerable<MeetingPointSlot> enumerable = (IEnumerable<MeetingPointSlot>)Enumerable.Where<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__32_);
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

		[Cpp2IlInjected.Token(Token = "0x6001E4D")]
		[Cpp2IlInjected.Address(RVA = "0xBC4B80", Offset = "0xBC3580", VA = "0x180BC4B80")]
		public MeetingPointSlot FirstAvailableSlot(bool isLandCharacter)
		{
			//Discarded unreachable code: IL_0029
			List<MeetingPointSlot> list = slots;
			Func<MeetingPointSlot, bool> func = (Func<MeetingPointSlot, bool>)(object)(Func<T, TResult>)delegate(MeetingPointSlot s)
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
			return Enumerable.FirstOrDefault<MeetingPointSlot>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4E")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C60", Offset = "0xBC3660", VA = "0x180BC4C60")]
		public Vector3 GetLookAt(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4F")]
		[Cpp2IlInjected.Address(RVA = "0xBC57A0", Offset = "0xBC41A0", VA = "0x180BC57A0", Slot = "14")]
		[AsyncStateMachine(typeof(_003CVisit_003Ed__35))]
		public Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E50")]
		[Cpp2IlInjected.Address(RVA = "0xBC4A50", Offset = "0xBC3450", VA = "0x180BC4A50")]
		[AsyncStateMachine(typeof(_003CDiscuss_003Ed__36))]
		private Task Discuss(JoinMeetingConfig config, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E51")]
		[Cpp2IlInjected.Address(RVA = "0xBC5910", Offset = "0xBC4310", VA = "0x180BC5910")]
		public MeetingPoint()
		{
		}
	}
}
