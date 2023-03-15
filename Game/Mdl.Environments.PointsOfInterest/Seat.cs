using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006B5")]
	public class Seat : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002797")]
		private SitDownParameters parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002798")]
		private RelaxingPosition seat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002799")]
		public float elapsed;

		[Cpp2IlInjected.Token(Token = "0x17000430")]
		public bool IsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC7")]
			[Cpp2IlInjected.Address(RVA = "0xCCBDF0", Offset = "0xCCA7F0", VA = "0x180CCBDF0")]
			get
			{
				//Discarded unreachable code: IL_002f
				//IL_0010: Expected O, but got I4
				//IL_002e: Expected O, but got I4
				RelaxingPosition relaxingPosition = seat;
				int num = 0;
				bool flag = relaxingPosition != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				GameObject _003CRelaxingCharacter_003Ek__BackingField = seat.RelaxingCharacter;
				int num2 = 0;
				return _003CRelaxingCharacter_003Ek__BackingField == (UnityEngine.Object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		public GameObject Occupant
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC8")]
			[Cpp2IlInjected.Address(RVA = "0xCCBFD0", Offset = "0xCCA9D0", VA = "0x180CCBFD0")]
			get
			{
				//IL_0010: Expected O, but got I4
				RelaxingPosition relaxingPosition = seat;
				int num = 0;
				if (relaxingPosition != (UnityEngine.Object)num)
				{
					return seat.RelaxingCharacter;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000432")]
		public bool IsSeated
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC9")]
			[Cpp2IlInjected.Address(RVA = "0xCCBEC0", Offset = "0xCCA8C0", VA = "0x180CCBEC0")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0028: Expected O, but got I4
				GameObject occupant = Occupant;
				int num = 0;
				if (occupant != (UnityEngine.Object)num)
				{
					RelaxingBehaviour component = Occupant.GetComponent<RelaxingBehaviour>();
					int num2 = 0;
					if (component != (UnityEngine.Object)num2)
					{
						return Occupant.GetComponent<RelaxingBehaviour>().Relaxing;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC5")]
		[Cpp2IlInjected.Address(RVA = "0xCCB140", Offset = "0xCC9B40", VA = "0x180CCB140")]
		public Vector3? Destination(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC6")]
		[Cpp2IlInjected.Address(RVA = "0xCCB240", Offset = "0xCC9C40", VA = "0x180CCB240")]
		public bool IsReachable(GameObject agent)
		{
			NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCA")]
		[Cpp2IlInjected.Address(RVA = "0xCCAD50", Offset = "0xCC9750", VA = "0x180CCAD50")]
		private void Awake()
		{
			RelaxingPosition[] componentsInParent = GetComponentsInParent<RelaxingPosition>();
			Func<RelaxingPosition, bool> func = (Func<RelaxingPosition, bool>)(object)(Func<T, TResult>)delegate(RelaxingPosition s)
			{
				//Discarded unreachable code: IL_001e
				RelaxingPosition._003Cget_AllDestinations_003Ed__4 _003Cget_AllDestinations_003Ed__ = new RelaxingPosition._003Cget_AllDestinations_003Ed__4(-2)
				{
					_003C_003E4__this = s
				};
				Transform transform = base.transform;
				return Enumerable.Contains<Transform>((IEnumerable<>)(object)_003Cget_AllDestinations_003Ed__, transform);
			};
			RelaxingPosition relaxingPosition = (seat = Enumerable.FirstOrDefault<RelaxingPosition>((IEnumerable<>)(object)componentsInParent, (Func<, >)(object)func));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCB")]
		[Cpp2IlInjected.Address(RVA = "0xCCB360", Offset = "0xCC9D60", VA = "0x180CCB360")]
		private void OnDestroy()
		{
			Cleanup();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCC")]
		[Cpp2IlInjected.Address(RVA = "0xCCAE20", Offset = "0xCC9820", VA = "0x180CCAE20")]
		private void Cleanup()
		{
			//Discarded unreachable code: IL_00ac, IL_00b2
			//IL_0018: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0079: Expected F4, but got I4
			//IL_00a0: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GameObject occupant = Occupant;
			int num4 = 0;
			if (!(occupant != (UnityEngine.Object)num4))
			{
				return;
			}
			Animator componentInChildren = Occupant.GetComponentInChildren<Animator>();
			int num5 = 0;
			if (componentInChildren != (UnityEngine.Object)num5)
			{
				SitDownParameters sitDownParameters = parameters;
				if (sitDownParameters != null)
				{
					List<string> triggersToReset = sitDownParameters.triggersToReset;
					bool flag = default(bool);
					if (flag)
					{
						componentInChildren.ResetTrigger((string)num2);
					}
					int layerIndex = componentInChildren.GetLayerIndex("SittingDown");
					int num6 = 0;
					componentInChildren.SetLayerWeight(layerIndex, num6);
				}
			}
			if (Occupant.GetComponent<IRelaxer>() != null)
			{
			}
			RelaxingBehaviour component = Occupant.GetComponent<RelaxingBehaviour>();
			int num7 = 0;
			if (component != (UnityEngine.Object)num7)
			{
				component.Relaxing = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCD")]
		[Cpp2IlInjected.Address(RVA = "0xCCBBC0", Offset = "0xCCA5C0", VA = "0x180CCBBC0")]
		public bool Take(GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			RelaxingPosition relaxingPosition = seat;
			int num = 0;
			if (relaxingPosition != (UnityEngine.Object)num)
			{
				GameObject _003CRelaxingCharacter_003Ek__BackingField = seat.RelaxingCharacter;
				int num2 = 0;
				if (_003CRelaxingCharacter_003Ek__BackingField == (UnityEngine.Object)num2)
				{
					RelaxingBehaviour component = agent.GetComponent<RelaxingBehaviour>();
					int num3 = 0;
					if (!(component == (UnityEngine.Object)num3))
					{
						seat.Reserve(agent);
						return true;
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCE")]
		[Cpp2IlInjected.Address(RVA = "0xCCB5D0", Offset = "0xCC9FD0", VA = "0x180CCB5D0")]
		public bool Release(GameObject agent)
		{
			//IL_002b: Expected O, but got I4
			//IL_0044: Expected F4, but got I4
			//IL_0061: Expected O, but got I4
			if (!(Occupant != agent))
			{
				seat.Free(agent);
				Animator componentInChildren = agent.GetComponentInChildren<Animator>();
				int num = 0;
				if (componentInChildren != (UnityEngine.Object)num)
				{
					int layerIndex = componentInChildren.GetLayerIndex("SittingDown");
					int num2 = 0;
					componentInChildren.SetLayerWeight(layerIndex, num2);
				}
				if (agent.GetComponent<IRelaxer>() != null)
				{
				}
				RelaxingBehaviour component = agent.GetComponent<RelaxingBehaviour>();
				int num3 = 0;
				if (component != (UnityEngine.Object)num3)
				{
					component.Relaxing = false;
				}
				return true;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCF")]
		[Cpp2IlInjected.Address(RVA = "0xCCB7C0", Offset = "0xCCA1C0", VA = "0x180CCB7C0")]
		[AsyncStateMachine(typeof(_003CSitDown_003Ed__16))]
		public Task SitDown(GameObject agent, SitDownParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD0")]
		[Cpp2IlInjected.Address(RVA = "0xCCB370", Offset = "0xCC9D70", VA = "0x180CCB370")]
		[AsyncStateMachine(typeof(_003CPlaySitDownAnimation_003Ed__17))]
		private Task PlaySitDownAnimation(GameObject agent, SitDownParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD1")]
		[Cpp2IlInjected.Address(RVA = "0xCCB910", Offset = "0xCCA310", VA = "0x180CCB910")]
		[AsyncStateMachine(typeof(_003CSitDown_003Ed__18))]
		public Task SitDown(GameObject agent, float duration, SitDownParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD2")]
		[Cpp2IlInjected.Address(RVA = "0xCCBA70", Offset = "0xCCA470", VA = "0x180CCBA70")]
		[AsyncStateMachine(typeof(_003CStandUp_003Ed__19))]
		public Task StandUp(GameObject agent, SitDownParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD3")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4A0", Offset = "0xCC9EA0", VA = "0x180CCB4A0")]
		[AsyncStateMachine(typeof(_003CPlayStandUpAnimation_003Ed__20))]
		private Task PlayStandUpAnimation(GameObject agent, SitDownParameters parameters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Seat()
		{
		}
	}
}
