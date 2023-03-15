using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Items;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006C7")]
	public class Flower : MonoBehaviour, IPointOfInterest
	{
		[Cpp2IlInjected.Token(Token = "0x20006C8")]
		private class Occupant
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40027F6")]
			public bool hasArrived;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40027F7")]
			public GameObject agent;

			[Cpp2IlInjected.Token(Token = "0x6001E27")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Occupant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027F1")]
		public FlowerConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40027F4")]
		private float startedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40027F5")]
		private Occupant currentOccupant;

		[Cpp2IlInjected.Token(Token = "0x1700043D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40027F2")]
		public bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E12")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E13")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700043E")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001E14")]
			[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043F")]
		public int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E15")]
			[Cpp2IlInjected.Address(RVA = "0x14579F0", Offset = "0x14563F0", VA = "0x1814579F0", Slot = "6")]
			get
			{
				int num = 0;
				bool flag = (IntPtr)currentOccupant != (IntPtr)num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000440")]
		public int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E16")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "7")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000441")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001E17")]
			[Cpp2IlInjected.Address(RVA = "0x14579A0", Offset = "0x14563A0", VA = "0x1814579A0", Slot = "8")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.GetComponentInParent<ItemScript>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000442")]
		public float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001E18")]
			[Cpp2IlInjected.Address(RVA = "0x1457A00", Offset = "0x1456400", VA = "0x181457A00", Slot = "9")]
			get
			{
				int num = 0;
				return Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000443")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x40027F3")]
		private float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001E19")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E1A")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000444")]
		private float elapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E1B")]
			[Cpp2IlInjected.Address(RVA = "0x1457A40", Offset = "0x1456440", VA = "0x181457A40")]
			get
			{
				int num = 0;
				return Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1C")]
		[Cpp2IlInjected.Address(RVA = "0x1457630", Offset = "0x1456030", VA = "0x181457630")]
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

		[Cpp2IlInjected.Token(Token = "0x6001E1D")]
		[Cpp2IlInjected.Address(RVA = "0x14577A0", Offset = "0x14561A0", VA = "0x1814577A0")]
		private float StimulusProbability(GameObject agent)
		{
			//Discarded unreachable code: IL_0028
			Occupant occupant = currentOccupant;
			if (occupant != null && occupant.agent == agent)
			{
				int num = 0;
			}
			return config.stimulusSoloProbability;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1E")]
		[Cpp2IlInjected.Address(RVA = "0x1457620", Offset = "0x1456020", VA = "0x181457620")]
		private void OnDestroy()
		{
			Destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1F")]
		[Cpp2IlInjected.Address(RVA = "0xA81B90", Offset = "0xA80590", VA = "0x180A81B90", Slot = "10")]
		public float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig actionConfig)
		{
			//Discarded unreachable code: IL_0016
			int weightBonus = config.weightBonus;
			return PointOfInterestUtil.DefaultInterestWeight(this, avatar, actionConfig, weightBonus);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E20")]
		[Cpp2IlInjected.Address(RVA = "0x14571B0", Offset = "0x1455BB0", VA = "0x1814571B0", Slot = "11")]
		public bool CanInterruptAction(GameObject interruptee, GameObject interruptor)
		{
			Occupant occupant = currentOccupant;
			if (occupant == null)
			{
				return true;
			}
			return !occupant.hasArrived;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E21")]
		[Cpp2IlInjected.Address(RVA = "0x14571D0", Offset = "0x1455BD0", VA = "0x1814571D0", Slot = "12")]
		public bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			if ((long)currentOccupant == 0)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E22")]
		[Cpp2IlInjected.Address(RVA = "0x14571A0", Offset = "0x1455BA0", VA = "0x1814571A0", Slot = "13")]
		public bool ArrivedAtPoint(GameObject agent)
		{
			Occupant occupant = currentOccupant;
			if (occupant == null)
			{
			}
			return occupant.hasArrived;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E23")]
		[Cpp2IlInjected.Address(RVA = "0x14575C0", Offset = "0x1455FC0", VA = "0x1814575C0")]
		public bool IsReachable(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E24")]
		[Cpp2IlInjected.Address(RVA = "0x1457240", Offset = "0x1455C40", VA = "0x181457240")]
		private Vector3? Destination(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E25")]
		[Cpp2IlInjected.Address(RVA = "0x1457840", Offset = "0x1456240", VA = "0x181457840", Slot = "14")]
		[AsyncStateMachine(typeof(_003CVisit_003Ed__33))]
		public Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E26")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Flower()
		{
		}
	}
}
