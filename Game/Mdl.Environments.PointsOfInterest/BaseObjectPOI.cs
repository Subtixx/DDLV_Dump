using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E0")]
	public abstract class BaseObjectPOI : MonoBehaviour, IPointOfInterest
	{
		[Cpp2IlInjected.Token(Token = "0x20006E1")]
		private class Occupant
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002875")]
			public bool hasArrived;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002876")]
			public GameObject agent;

			[Cpp2IlInjected.Token(Token = "0x6001EA5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Occupant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400286D")]
		[SerializeField]
		private string defaultAnimationEndState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400286E")]
		[SerializeField]
		private bool looping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400286F")]
		[NotNull]
		public ObjectPOIConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002872")]
		private float startedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002873")]
		public Transform LookAtTransformOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002874")]
		private Occupant currentOccupant;

		[Cpp2IlInjected.Token(Token = "0x17000458")]
		public abstract Enum DefaultEntryAnimationTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6001E8F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000459")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4002870")]
		public bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E90")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E91")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700045A")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001E92")]
			[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045B")]
		public int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E93")]
			[Cpp2IlInjected.Address(RVA = "0x163C3A0", Offset = "0x163ADA0", VA = "0x18163C3A0", Slot = "6")]
			get
			{
				int num = 0;
				bool flag = (IntPtr)currentOccupant != (IntPtr)num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045C")]
		public int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E94")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "7")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045D")]
		public float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001E95")]
			[Cpp2IlInjected.Address(RVA = "0x163C3B0", Offset = "0x163ADB0", VA = "0x18163C3B0", Slot = "9")]
			get
			{
				int num = 0;
				return Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4002871")]
		private float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001E96")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E97")]
			[Cpp2IlInjected.Address(RVA = "0xBC5B40", Offset = "0xBC4540", VA = "0x180BC5B40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700045F")]
		private float elapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E98")]
			[Cpp2IlInjected.Address(RVA = "0x163C3F0", Offset = "0x163ADF0", VA = "0x18163C3F0")]
			get
			{
				int num = 0;
				return Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000460")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001E99")]
			[Cpp2IlInjected.Address(RVA = "0x163C350", Offset = "0x163AD50", VA = "0x18163C350", Slot = "8")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.GetComponentInParent<ItemScript>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9A")]
		[Cpp2IlInjected.Address(RVA = "0x163C020", Offset = "0x163AA20", VA = "0x18163C020")]
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

		[Cpp2IlInjected.Token(Token = "0x6001E9B")]
		[Cpp2IlInjected.Address(RVA = "0x163C130", Offset = "0x163AB30", VA = "0x18163C130")]
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

		[Cpp2IlInjected.Token(Token = "0x6001E9C")]
		[Cpp2IlInjected.Address(RVA = "0xA63A00", Offset = "0xA62400", VA = "0x180A63A00")]
		private void OnDestroy()
		{
			Destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9D")]
		[Cpp2IlInjected.Address(RVA = "0x163BF80", Offset = "0x163A980", VA = "0x18163BF80", Slot = "10")]
		public float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig actionConfig)
		{
			//Discarded unreachable code: IL_0016
			int weightBonus = config.weightBonus;
			return PointOfInterestUtil.DefaultInterestWeight(this, avatar, actionConfig, weightBonus);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9E")]
		[Cpp2IlInjected.Address(RVA = "0x163BBD0", Offset = "0x163A5D0", VA = "0x18163BBD0", Slot = "11")]
		public bool CanInterruptAction(GameObject interruptee, GameObject interruptor)
		{
			Occupant occupant = currentOccupant;
			if (occupant == null)
			{
				return true;
			}
			return !occupant.hasArrived;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9F")]
		[Cpp2IlInjected.Address(RVA = "0x163BBF0", Offset = "0x163A5F0", VA = "0x18163BBF0", Slot = "16")]
		public virtual bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//IL_0014: Expected O, but got I4
			if ((long)currentOccupant == 0)
			{
				int num = 0;
				if (actionConfig != (UnityEngine.Object)num && (object)actionConfig != null)
				{
					int num2 = 0;
					if ((object)actionConfig != null && DefaultEntryAnimationTrigger == null)
					{
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA0")]
		[Cpp2IlInjected.Address(RVA = "0x163BBC0", Offset = "0x163A5C0", VA = "0x18163BBC0", Slot = "13")]
		public bool ArrivedAtPoint(GameObject agent)
		{
			Occupant occupant = currentOccupant;
			if (occupant == null)
			{
			}
			return occupant.hasArrived;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA1")]
		[Cpp2IlInjected.Address(RVA = "0x163BFC0", Offset = "0x163A9C0", VA = "0x18163BFC0")]
		public bool IsReachable(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA2")]
		[Cpp2IlInjected.Address(RVA = "0x163BD40", Offset = "0x163A740", VA = "0x18163BD40")]
		private Vector3? Destination(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA3")]
		[Cpp2IlInjected.Address(RVA = "0x163C1D0", Offset = "0x163ABD0", VA = "0x18163C1D0", Slot = "14")]
		[AsyncStateMachine(typeof(_003CVisit_003Ed__38))]
		public Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected BaseObjectPOI()
		{
		}
	}
}
