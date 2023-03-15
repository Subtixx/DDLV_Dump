using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AI;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200090B")]
	public class Critter : MonoBehaviour, INpc, IPlayerTaskProvider, IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x200090C")]
		internal struct CritterInteractionScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003266")]
			private readonly Critter critter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003267")]
			private readonly ObstacleAvoidanceType obstacleAvoidanceType;

			[Cpp2IlInjected.Token(Token = "0x60029A5")]
			[Cpp2IlInjected.Address(RVA = "0x1195E70", Offset = "0x1194870", VA = "0x181195E70")]
			public CritterInteractionScope(Critter critter)
			{
				//Discarded unreachable code: IL_0043
				this.critter = critter;
				critter.interactingWithAvatar = true;
				critter.Agent.ResetPath();
				ObstacleAvoidanceType obstacleAvoidanceType = (this.obstacleAvoidanceType = critter.Agent.obstacleAvoidanceType);
				NavMeshAgent agent = critter.Agent;
				int num = (int)(agent.obstacleAvoidanceType = ObstacleAvoidanceType.NoObstacleAvoidance);
				critter.UpdateAnimation();
			}

			[Cpp2IlInjected.Token(Token = "0x60029A6")]
			[Cpp2IlInjected.Address(RVA = "0x1195E20", Offset = "0x1194820", VA = "0x181195E20", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_000f
				NavMeshAgent navMeshAgent = default(NavMeshAgent);
				ObstacleAvoidanceType obstacleAvoidanceType2 = (navMeshAgent.obstacleAvoidanceType = this.obstacleAvoidanceType);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003249")]
		[SerializeField]
		private MotivationConfig _critterInterruptibleMotivationConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400324A")]
		private IMotivation freeTimeMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400324B")]
		[SerializeField]
		private CritterApproachConfig _critterApproach;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400324C")]
		private ICritterApproachMotivation approachMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400324D")]
		[SerializeField]
		private CritterFleeConfig _critterFlee;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400324E")]
		private ICritterMotivation fleeingMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400324F")]
		private IMotivation currentMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003250")]
		public float walkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4003251")]
		public float runSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4003253")]
		public float sprintSpeed = 8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003254")]
		public string animatorSpeedFloat = "Speed";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003255")]
		private int animatorSpeedFloatHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003256")]
		public string animatorMoveBool = "Move";

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003257")]
		private int animatorMoveBoolHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003258")]
		[SerializeField]
		private PlayerTaskDefinition _interactWithCritterTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003259")]
		[SerializeField]
		private Transform _interactionCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400325A")]
		private GameObject _interactionOppositeCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400325B")]
		[SerializeField]
		private Transform _interactionItemPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400325C")]
		[SerializeField]
		private Transform _feederItemPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400325D")]
		public AssetReferenceGameObject feederVisualReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400325E")]
		public bool debugShouldResetMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400325F")]
		private NavMeshAgent _navMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003260")]
		private Animator _animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003263")]
		private ItemScript itemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003264")]
		private bool interactingWithAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x4003265")]
		private bool hadPath;

		[Cpp2IlInjected.Token(Token = "0x170005F7")]
		public NpcBodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6002982")]
			[Cpp2IlInjected.Address(RVA = "0x11045E0", Offset = "0x1102FE0", VA = "0x1811045E0", Slot = "4")]
			get
			{
				return NpcBodyType.SmallQuadruped;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F8")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002983")]
			[Cpp2IlInjected.Address(RVA = "0x1104870", Offset = "0x1103270", VA = "0x181104870")]
			get
			{
				//Discarded unreachable code: IL_000c
				return itemScript.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F9")]
		public MotivationConfig FreeTimeMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x6002984")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "5")]
			get
			{
				return _critterInterruptibleMotivationConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FA")]
		public float WalkSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x6002985")]
			[Cpp2IlInjected.Address(RVA = "0xCBE930", Offset = "0xCBD330", VA = "0x180CBE930", Slot = "6")]
			get
			{
				return walkSpeed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FB")]
		public float RunSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x6002986")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5D0", Offset = "0xE38FD0", VA = "0x180E3A5D0", Slot = "7")]
			get
			{
				return runSpeed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4003252")]
		public bool TraversingLink
		{
			[Cpp2IlInjected.Token(Token = "0x6002987")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002988")]
			[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005FD")]
		private Transform InteractionCameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002989")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _interactionCameraPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FE")]
		private Transform InteractionOppositeCameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600298A")]
			[Cpp2IlInjected.Address(RVA = "0x1104840", Offset = "0x1103240", VA = "0x181104840")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _interactionOppositeCameraPosition.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FF")]
		public Transform InteractionItemPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600298B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return _interactionItemPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000600")]
		public Transform FeederItemPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600298C")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return _feederItemPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000601")]
		public NavMeshAgent Agent
		{
			[Cpp2IlInjected.Token(Token = "0x600298D")]
			[Cpp2IlInjected.Address(RVA = "0x1104480", Offset = "0x1102E80", VA = "0x181104480")]
			get
			{
				//IL_0010: Expected O, but got I4
				NavMeshAgent navMeshAgent = _navMeshAgent;
				int num = 0;
				if (navMeshAgent == (UnityEngine.Object)num)
				{
					NavMeshAgent navMeshAgent2 = (_navMeshAgent = GetComponent<NavMeshAgent>());
				}
				return _navMeshAgent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000602")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x600298E")]
			[Cpp2IlInjected.Address(RVA = "0x1104530", Offset = "0x1102F30", VA = "0x181104530")]
			get
			{
				//IL_0010: Expected O, but got I4
				Animator animator = _animator;
				int num = 0;
				if (animator == (UnityEngine.Object)num)
				{
					Animator animator2 = (_animator = GetComponentInChildren<Animator>());
				}
				return _animator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000603")]
		public GridScript AssociatedGrid
		{
			[Cpp2IlInjected.Token(Token = "0x600298F")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			[CompilerGenerated]
			get
			{
				return _003CAssociatedGrid_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002990")]
			[Cpp2IlInjected.Address(RVA = "0x11049F0", Offset = "0x11033F0", VA = "0x1811049F0")]
			[CompilerGenerated]
			set
			{
				_003CAssociatedGrid_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000604")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xD0"), Cpp2IlInjected.Token(Token = "0x4003262")]
		public bool CompletedMinigame
		{
			[Cpp2IlInjected.Token(Token = "0x6002991")]
			[Cpp2IlInjected.Address(RVA = "0xAFC360", Offset = "0xAFAD60", VA = "0x180AFC360")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002992")]
			[Cpp2IlInjected.Address(RVA = "0xAFC480", Offset = "0xAFAE80", VA = "0x180AFC480")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000605")]
		public unsafe Meta.Critter MetaData
		{
			[Cpp2IlInjected.Token(Token = "0x6002993")]
			[Cpp2IlInjected.Address(RVA = "0x11048A0", Offset = "0x11032A0", VA = "0x1811048A0")]
			get
			{
				//Discarded unreachable code: IL_002f
				RepeatedField<Meta.Critter> critters_ = SystemRoot.Instance.MetaClient.profile.world_.critters_;
				Func<Meta.Critter, bool> func = (Func<Meta.Critter, bool>)(object)(Func<T, TResult>)delegate(Meta.Critter x)
				{
					//Discarded unreachable code: IL_001b
					Item critterItem = x.CritterItem;
					Item item = itemScript.Item;
					return *(Item*)critterItem == *(Item*)item;
				};
				return Enumerable.FirstOrDefault<Meta.Critter>((IEnumerable<>)(object)critters_, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000606")]
		public unsafe bool Fed
		{
			[Cpp2IlInjected.Token(Token = "0x6002994")]
			[Cpp2IlInjected.Address(RVA = "0x11045F0", Offset = "0x1102FF0", VA = "0x1811045F0")]
			get
			{
				RepeatedField<Meta.Critter> critters_ = SystemRoot.Instance.MetaClient.profile.world_.critters_;
				Func<Meta.Critter, bool> func = (Func<Meta.Critter, bool>)(object)(Func<T, TResult>)delegate(Meta.Critter x)
				{
					//Discarded unreachable code: IL_001b
					Item critterItem = x.CritterItem;
					Item item = itemScript.Item;
					return *(Item*)critterItem == *(Item*)item;
				};
				Meta.Critter critter = Enumerable.FirstOrDefault<Meta.Critter>((IEnumerable<>)(object)critters_, (Func<, >)(object)func);
				if (critter != null)
				{
					DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
					return critter.Fed(localTime);
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000607")]
		public bool Fleeing
		{
			[Cpp2IlInjected.Token(Token = "0x6002995")]
			[Cpp2IlInjected.Address(RVA = "0x1104830", Offset = "0x1103230", VA = "0x181104830")]
			get
			{
				ICritterMotivation critterMotivation = fleeingMotivation;
				return currentMotivation == critterMotivation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002996")]
		[Cpp2IlInjected.Address(RVA = "0x11038E0", Offset = "0x11022E0", VA = "0x1811038E0")]
		public bool IsInFrustum(Plane[] frustumPlanes)
		{
			//Discarded unreachable code: IL_0009
			Collider component = GetComponent<Collider>();
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002997")]
		[Cpp2IlInjected.Address(RVA = "0x1103470", Offset = "0x1101E70", VA = "0x181103470")]
		public void InitInteractionOppositeCameraPosition()
		{
			//Discarded unreachable code: IL_00e1
			//IL_0010: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			GameObject interactionOppositeCameraPosition = _interactionOppositeCameraPosition;
			int num = 0;
			if (interactionOppositeCameraPosition == (UnityEngine.Object)num)
			{
				Transform interactionCameraPosition = _interactionCameraPosition;
				GameObject original = interactionCameraPosition.gameObject;
				Transform interactionCameraPosition2 = _interactionCameraPosition;
				Vector3 position = interactionCameraPosition.position;
				Transform interactionCameraPosition3 = _interactionCameraPosition;
				int num2 = 0;
				Quaternion rotation = interactionCameraPosition.rotation;
				Transform interactionCameraPosition4 = _interactionCameraPosition;
				int num3 = 0;
				Transform parent = interactionCameraPosition4.parent;
				GameObject gameObject = (_interactionOppositeCameraPosition = UnityEngine.Object.Instantiate(original, (Vector3)num3, (Quaternion)num2, parent));
				_interactionOppositeCameraPosition.name = "InteractionOppositeCameraPosition";
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				Transform interactionItemPosition = _interactionItemPosition;
				Transform interactionCameraPosition5 = _interactionCameraPosition;
				int num4 = 0;
				Vector3 vector = default(Vector3);
				Angle angle = Angle.FromRadians(vector.z);
				Transform transform3 = _interactionOppositeCameraPosition.transform;
				Vector3 up = Vector3.up;
				int num5 = 0;
				float num6 = default(float);
				float angle2 = num6 * 2f;
				transform3.RotateAround((Vector3)num5, (Vector3)num4, angle2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002998")]
		[Cpp2IlInjected.Address(RVA = "0x11031D0", Offset = "0x1101BD0", VA = "0x1811031D0")]
		public Transform ClosestInteractionCameraPosition(Vector3 position)
		{
			//Discarded unreachable code: IL_001a
			Transform interactionCameraPosition = _interactionCameraPosition;
			Transform transform = _interactionOppositeCameraPosition.transform;
			return _interactionCameraPosition;
		}

		[Cpp2IlInjected.Token(Token = "0x6002999")]
		[Cpp2IlInjected.Address(RVA = "0x1102F80", Offset = "0x1101980", VA = "0x181102F80")]
		private void Awake()
		{
			//Discarded unreachable code: IL_008c
			IMotivation motivation = (freeTimeMotivation = _critterInterruptibleMotivationConfig.Instantiate());
			IMotivation motivation2 = _critterApproach.Instantiate();
			if (motivation2 == null)
			{
			}
			if (motivation2 != null)
			{
				approachMotivation = (ICritterApproachMotivation)motivation2;
				IMotivation motivation3 = _critterFlee.Instantiate();
				if (motivation3 == null || motivation3 != null)
				{
					fleeingMotivation = (ICritterMotivation)motivation3;
					ItemScript itemScript = (this.itemScript = GetComponent<ItemScript>());
					InitInteractionOppositeCameraPosition();
					int num = Animator.StringToHash(animatorMoveBool);
					string text = animatorSpeedFloat;
					animatorMoveBoolHash = num;
					int num2 = (animatorSpeedFloatHash = Animator.StringToHash(text));
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600299A")]
		[Cpp2IlInjected.Address(RVA = "0x1103C80", Offset = "0x1102680", VA = "0x181103C80")]
		private void Start()
		{
			IMotivation motivation = (currentMotivation = freeTimeMotivation);
			IMotivation motivation2 = freeTimeMotivation;
			GameObject gameObject = base.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600299B")]
		[Cpp2IlInjected.Address(RVA = "0x1103FF0", Offset = "0x11029F0", VA = "0x181103FF0")]
		private void Update()
		{
			//Discarded unreachable code: IL_016a
			if (debugShouldResetMotivation)
			{
				IMotivation motivation = freeTimeMotivation;
				GameObject gameObject = Agent.gameObject;
				IMotivation motivation2 = (freeTimeMotivation = _critterInterruptibleMotivationConfig.Instantiate());
				debugShouldResetMotivation = false;
			}
			int num;
			if ((long)currentMotivation != 0 && !interactingWithAvatar)
			{
				bool isOnNavMesh = Agent.isOnNavMesh;
				if (isOnNavMesh)
				{
					IMotivation motivation3 = currentMotivation;
					num = 0;
					if (isOnNavMesh)
					{
						int num2 = 0;
						if (isOnNavMesh)
						{
							goto IL_00ef;
						}
					}
					ICritterApproachMotivation critterApproachMotivation = approachMotivation;
					if (!isOnNavMesh)
					{
						if (critterApproachMotivation == null || (object)Agent.gameObject == null)
						{
							goto IL_00ef;
						}
						if (currentMotivation != null)
						{
							GameObject gameObject2 = Agent.gameObject;
						}
						ICritterApproachMotivation critterApproachMotivation2 = (ICritterApproachMotivation)(currentMotivation = approachMotivation);
						IMotivation motivation4 = currentMotivation;
						GameObject gameObject3 = Agent.gameObject;
					}
					if ((object)Agent.gameObject != null)
					{
						int reason = 0;
						Flee((FlightReason)reason);
					}
					goto IL_00ef;
				}
			}
			goto IL_0163;
			IL_0163:
			UpdateAnimation();
			return;
			IL_00ef:
			if ((interactingWithAvatar ? 1 : 0) == num && Agent.isOnNavMesh)
			{
				IMotivation motivation5 = currentMotivation;
				int num3 = 0;
				float deltaTime = Time.deltaTime;
				GameObject gameObject4 = Agent.gameObject;
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				if (num == 0)
				{
					IMotivation motivation6 = (currentMotivation = freeTimeMotivation);
					IMotivation motivation7 = currentMotivation;
					GameObject gameObject5 = Agent.gameObject;
				}
			}
			goto IL_0163;
		}

		[Cpp2IlInjected.Token(Token = "0x600299C")]
		[Cpp2IlInjected.Address(RVA = "0x11039E0", Offset = "0x11023E0", VA = "0x1811039E0")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600299D")]
		[Cpp2IlInjected.Address(RVA = "0x1103DA0", Offset = "0x11027A0", VA = "0x181103DA0")]
		private void UpdateAnimation()
		{
			//Discarded unreachable code: IL_00cd
			int num = 0;
			float speed = Agent.speed;
			if (!(runSpeed >= speed))
			{
				float num2 = Mathf.Clamp01(Agent.speed);
			}
			float speed2 = Agent.speed;
			float value = runSpeed;
			float num3 = Mathf.Clamp01(speed2);
			Animator animator = Animator;
			int id = animatorSpeedFloatHash;
			animator.SetFloat(id, value);
			IMotivation motivation = currentMotivation;
			if ((object)animator == null || (object)base.gameObject == null)
			{
			}
			if (!Agent.hasPath || !hadPath)
			{
			}
			NavMeshAgent agent = Agent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Animator animator2 = Animator;
			int id2 = animatorMoveBoolHash;
			animator2.SetBool(id2, value: true);
			bool flag = (hadPath = Agent.hasPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600299E")]
		[Cpp2IlInjected.Address(RVA = "0x1103810", Offset = "0x1102210", VA = "0x181103810")]
		internal CritterInteractionScope InteractWithAvatar(out bool canBeFed)
		{
			if ((object)typeof(IMotivation).TypeHandle != null && (object)typeof(IMotivation).TypeHandle == null)
			{
				int num = 0;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600299F")]
		[Cpp2IlInjected.Address(RVA = "0x1103330", Offset = "0x1101D30", VA = "0x181103330")]
		internal void Flee(FlightReason reason)
		{
			//Discarded unreachable code: IL_0056
			IMotivation motivation = currentMotivation;
			int num = 0;
			if ((object)typeof(IMotivation).TypeHandle != null)
			{
				int num2 = 0;
				if ((object)typeof(IMotivation).TypeHandle != null)
				{
					return;
				}
			}
			if (currentMotivation != null)
			{
				GameObject gameObject = Agent.gameObject;
			}
			ICritterMotivation critterMotivation = (ICritterMotivation)(currentMotivation = fleeingMotivation);
			IMotivation motivation2 = currentMotivation;
			GameObject gameObject2 = Agent.gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x60029A0")]
		[Cpp2IlInjected.Address(RVA = "0x1103120", Offset = "0x1101B20", VA = "0x181103120")]
		internal void CancelFeeding()
		{
			//Discarded unreachable code: IL_001c
			IMotivation motivation = currentMotivation;
			if ((object)typeof(IMotivation).TypeHandle != null)
			{
				GameObject gameObject = Agent.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029A1")]
		[Cpp2IlInjected.Address(RVA = "0x1103A00", Offset = "0x1102400", VA = "0x181103A00")]
		internal void Respawn(bool teleport)
		{
			//Discarded unreachable code: IL_00bd
			//IL_00bc: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (teleport)
			{
				int sizeX_ = AssociatedGrid.GridData.sizeX_;
				int num4 = UnityEngine.Random.Range(0, sizeX_);
				int sizeY_ = AssociatedGrid.GridData.sizeY_;
				int num5 = UnityEngine.Random.Range(0, sizeY_);
				sizeY_ = num4;
				GridScript gridScript = AssociatedGrid;
				GridScript gridScript2 = AssociatedGrid;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				VillageArea component = gridScript2.GetComponent<VillageArea>();
				bool flag = default(bool);
				if (flag)
				{
					NavMeshAgent agent = Agent;
				}
			}
			if (currentMotivation != null)
			{
				GameObject gameObject = Agent.gameObject;
			}
			IMotivation motivation = (currentMotivation = freeTimeMotivation);
			if (currentMotivation != null)
			{
				GameObject gameObject2 = Agent.gameObject;
			}
			ulong num6 = default(ulong);
			base.gameObject.SetActive((byte)num6 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60029A2")]
		[Cpp2IlInjected.Address(RVA = "0x1103970", Offset = "0x1102370", VA = "0x181103970", Slot = "10")]
		[IteratorStateMachine(typeof(_003CMdl_002DNavigation_002DIPlayerTaskProvider_002DGetTasks_003Ed__79))]
		IEnumerable<PlayerTaskDefinition> IPlayerTaskProvider.GetTasks()
		{
			new _003CMdl_002DNavigation_002DIPlayerTaskProvider_002DGetTasks_003Ed__79(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029A3")]
		[Cpp2IlInjected.Address(RVA = "0x1104410", Offset = "0x1102E10", VA = "0x181104410")]
		public Critter()
		{
		}
	}
}
