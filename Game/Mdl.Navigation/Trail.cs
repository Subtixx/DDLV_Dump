using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Activities;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C95")]
	public class Trail : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004669")]
		[SerializeField]
		private bool _waitInsteadOfReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400466A")]
		[SerializeField]
		private float _distanceFromAvatarToReset = 12f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400466B")]
		[SerializeField]
		private float _movingTargetDistanceToReset = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400466C")]
		[SerializeField]
		private float _movingTargetMaxDistanceToReset = 14f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400466D")]
		[SerializeField]
		private float _timeToResetAfterDestination = 2.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400466E")]
		[SerializeField]
		private float _minDistanceFromAvatarToAllowUpdate = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400466F")]
		[SerializeField]
		private float _initialDistanceFromAvatar = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4004670")]
		[SerializeField]
		private float _timeBetweenCheck = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004671")]
		[SerializeField]
		private PlayerTaskDefinition _upgradeBuildingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004672")]
		[SerializeField]
		private bool _adaptSpeedToAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4004673")]
		[SerializeField]
		private float _navMeshSampleMaxDistance = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004674")]
		protected NavMeshAgent moverNavMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004675")]
		private ParticleSystem[] particleSystems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4004676")]
		private Coroutine coroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4004677")]
		private PlayerAvatar playerAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4004678")]
		private PlayerNavigation playerNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4004679")]
		public AK.Wwise.Event _sfxnavigationtrailStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400467A")]
		public AK.Wwise.Event _sfxnavigationtrailStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400467B")]
		private bool _targetIsBlinking;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400467C")]
		private Transform _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400467D")]
		private Vector3 _targetPositionAtSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400467E")]
		private Transform fakeTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400467F")]
		private Vector3 lastTargetPositionReached;

		[Cpp2IlInjected.Token(Token = "0x170007CE")]
		public unsafe Transform Target
		{
			[Cpp2IlInjected.Token(Token = "0x6003A32")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return _target;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A33")]
			[Cpp2IlInjected.Address(RVA = "0x13DE620", Offset = "0x13DD020", VA = "0x1813DE620")]
			set
			{
				//Discarded unreachable code: IL_01b7
				//IL_002c: Expected O, but got I4
				//IL_009d: Expected O, but got I4
				//IL_0108: Expected native int or pointer, but got O
				//IL_0148: Expected O, but got I4
				//IL_0148: Expected O, but got I4
				//IL_0158: Expected O, but got I4
				//IL_018c: Expected O, but got I4
				int num = 0;
				int num2 = 0;
				bool flag = default(bool);
				if (flag)
				{
					Coroutine routine = this.coroutine;
					StopCoroutine(routine);
					GameObject gameObject = base.gameObject;
					int num3 = 0;
					bool active = value != (UnityEngine.Object)num3;
					gameObject.SetActive(active);
					Transform transform = fakeTarget;
					if (gameObject == transform)
					{
						GameObject gameObject2 = fakeTarget.gameObject;
						int active2 = 0;
						gameObject2.SetActive((byte)active2 != 0);
					}
					if (_targetIsBlinking)
					{
						_targetIsBlinking = false;
						EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(Target_OnVisibilityChanged);
						BlinkMode blinkMode = default(BlinkMode);
						blinkMode.remove_OnVisibilityChanged((EventHandler<>)(object)eventHandler);
					}
				}
				_target = value;
				int num4 = 0;
				if (value != (UnityEngine.Object)num4)
				{
					base.gameObject.SetActive(value: true);
					ResetMoverPosition();
					PlayerAvatar playerAvatar = this.playerAvatar;
					NavMeshAgent navMeshAgent = moverNavMeshAgent;
					int num5 = (navMeshAgent.walkableMask = playerAvatar.Agent.walkableMask);
					int num6 = 0;
					moverNavMeshAgent.SetAreaCost(num6, 1f);
					num6++;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					((Vector3*)(IntPtr)_targetPositionAtSelection)->z = z;
					NavMeshAgent navMeshAgent2 = moverNavMeshAgent;
					float navMeshSampleMaxDistance = _navMeshSampleMaxDistance;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					int agentTypeID = navMeshAgent2.agentTypeID;
					int walkableMask2 = moverNavMeshAgent.walkableMask;
					if (NavMesh.SamplePosition((Vector3)num6, out *(NavMeshHit*)num, navMeshSampleMaxDistance, (NavMeshQueryFilter)num6))
					{
					}
					bool flag2 = moverNavMeshAgent.SetDestination((Vector3)num6);
					int _003C_003E1__state = default(int);
					_003CDistanceCheckRoutine_003Ed__40 _003CDistanceCheckRoutine_003Ed__ = new _003CDistanceCheckRoutine_003Ed__40(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CDistanceCheckRoutine_003Ed__._003C_003E4__this = this;
					Coroutine coroutine = (this.coroutine = StartCoroutine(_003CDistanceCheckRoutine_003Ed__));
					int num7 = 0;
					BlinkMode blinkMode2 = default(BlinkMode);
					if (blinkMode2 != (UnityEngine.Object)num7)
					{
						_targetIsBlinking = true;
						EventHandler<bool> eventHandler2 = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(Target_OnVisibilityChanged);
						blinkMode2.add_OnVisibilityChanged((EventHandler<>)(object)eventHandler2);
					}
				}
				if (this.TargetChanged == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007CF")]
		public Vector3? TargetPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6003A34")]
			[Cpp2IlInjected.Address(RVA = "0x13DE1A0", Offset = "0x13DCBA0", VA = "0x1813DE1A0")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					int num2 = 0;
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A35")]
			[Cpp2IlInjected.Address(RVA = "0x13DE470", Offset = "0x13DCE70", VA = "0x1813DE470")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A2")]
		public event EventHandler TargetChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003A2A")]
			[Cpp2IlInjected.Address(RVA = "0x13DE100", Offset = "0x13DCB00", VA = "0x1813DE100")]
			[CompilerGenerated]
			add
			{
				EventHandler targetChanged = this.TargetChanged;
				Delegate @delegate = Delegate.Combine(targetChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != targetChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A2B")]
			[Cpp2IlInjected.Address(RVA = "0x13DE3D0", Offset = "0x13DCDD0", VA = "0x1813DE3D0")]
			[CompilerGenerated]
			remove
			{
				EventHandler targetChanged = this.TargetChanged;
				Delegate @delegate = Delegate.Remove(targetChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != targetChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A3")]
		public event EventHandler AutoCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x6003A2C")]
			[Cpp2IlInjected.Address(RVA = "0x13DDFC0", Offset = "0x13DC9C0", VA = "0x1813DDFC0")]
			[CompilerGenerated]
			add
			{
				EventHandler autoCancelled = this.AutoCancelled;
				Delegate @delegate = Delegate.Combine(autoCancelled, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != autoCancelled)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A2D")]
			[Cpp2IlInjected.Address(RVA = "0x13DE290", Offset = "0x13DCC90", VA = "0x1813DE290")]
			[CompilerGenerated]
			remove
			{
				EventHandler autoCancelled = this.AutoCancelled;
				Delegate @delegate = Delegate.Remove(autoCancelled, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != autoCancelled)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A4")]
		public event EventHandler ReachedDestination
		{
			[Cpp2IlInjected.Token(Token = "0x6003A2E")]
			[Cpp2IlInjected.Address(RVA = "0x13DE060", Offset = "0x13DCA60", VA = "0x1813DE060")]
			[CompilerGenerated]
			add
			{
				EventHandler reachedDestination = this.ReachedDestination;
				Delegate @delegate = Delegate.Combine(reachedDestination, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != reachedDestination)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A2F")]
			[Cpp2IlInjected.Address(RVA = "0x13DE330", Offset = "0x13DCD30", VA = "0x1813DE330")]
			[CompilerGenerated]
			remove
			{
				EventHandler reachedDestination = this.ReachedDestination;
				Delegate @delegate = Delegate.Remove(reachedDestination, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != reachedDestination)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A30")]
		[Cpp2IlInjected.Address(RVA = "0x13DD0E0", Offset = "0x13DBAE0", VA = "0x1813DD0E0")]
		public void Init(PlayerAvatar avatar)
		{
			//Discarded unreachable code: IL_0158
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			playerAvatar = avatar;
			Toolbox _003CToolbox_003Ek__BackingField = playerAvatar.Toolbox;
			EventHandler<GameObject> b = (EventHandler<GameObject>)(object)new EventHandler<TEventArgs>(Toolbox_ToolInteractedWithObjectEvent);
			EventHandler<GameObject> toolInteractedWithObjectEvent = _003CToolbox_003Ek__BackingField.ToolInteractedWithObjectEvent;
			Delegate @delegate = Delegate.Combine(toolInteractedWithObjectEvent, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != toolInteractedWithObjectEvent)
				{
				}
				NavMeshAgent navMeshAgent = (moverNavMeshAgent = GetComponent<NavMeshAgent>());
				NavMeshAgent navMeshAgent2 = moverNavMeshAgent;
				float num = (navMeshAgent2.height = avatar.Agent.height);
				NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
				NavMeshAgent navMeshAgent3 = moverNavMeshAgent;
				num = (navMeshAgent3.radius = _003CAgent_003Ek__BackingField.radius);
				NavMeshAgent _003CAgent_003Ek__BackingField2 = avatar.Agent;
				NavMeshAgent navMeshAgent4 = moverNavMeshAgent;
				int num2 = (navMeshAgent4.walkableMask = _003CAgent_003Ek__BackingField2.walkableMask);
				ParticleSystem[] array = (particleSystems = GetComponentsInChildren<ParticleSystem>(includeInactive: true));
				PlayerNavigation playerNavigation = (this.playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
				PlayerNavigation playerNavigation2 = this.playerNavigation;
				PlayerNavigation.TaskQueued value = PlayerNavigation_OnTaskQueued;
				playerNavigation2.OnTaskQueued += value;
				PlayerNavigation playerNavigation3 = this.playerNavigation;
				PlayerNavigation.PlayerInteractionCompleted value2 = PlayerNavigation_OnPlayerInteractionCompleted;
				playerNavigation3.OnPlayerInteractionCompleted += value2;
				Transform transform = (fakeTarget = new GameObject().transform);
				Transform transform2 = fakeTarget;
				Transform transform4 = (transform2.parent = base.transform);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A31")]
		[Cpp2IlInjected.Address(RVA = "0x13DDBF0", Offset = "0x13DC5F0", VA = "0x1813DDBF0")]
		public void Stop()
		{
			//Discarded unreachable code: IL_00cb
			//IL_0009: Expected O, but got I4
			//IL_0019: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			int num = 0;
			Target = (Transform)num;
			PlayerAvatar playerAvatar = this.playerAvatar;
			int num2 = 0;
			if (playerAvatar != (UnityEngine.Object)num2)
			{
				Toolbox _003CToolbox_003Ek__BackingField = this.playerAvatar.Toolbox;
				int num3 = 0;
				if (_003CToolbox_003Ek__BackingField != (UnityEngine.Object)num3)
				{
					Toolbox _003CToolbox_003Ek__BackingField2 = this.playerAvatar.Toolbox;
					EventHandler<GameObject> value = (EventHandler<GameObject>)(object)new EventHandler<TEventArgs>(Toolbox_ToolInteractedWithObjectEvent);
					EventHandler<GameObject> toolInteractedWithObjectEvent = _003CToolbox_003Ek__BackingField2.ToolInteractedWithObjectEvent;
					Delegate @delegate = Delegate.Remove(toolInteractedWithObjectEvent, value);
					if ((object)@delegate != null && (object)@delegate == null)
					{
						throw new InvalidCastException();
					}
					while ((object)@delegate != toolInteractedWithObjectEvent)
					{
					}
				}
			}
			PlayerNavigation playerNavigation = this.playerNavigation;
			int num4 = 0;
			if (playerNavigation != (UnityEngine.Object)num4)
			{
				PlayerNavigation playerNavigation2 = this.playerNavigation;
				PlayerNavigation.TaskQueued value2 = PlayerNavigation_OnTaskQueued;
				playerNavigation2.OnTaskQueued -= value2;
				PlayerNavigation playerNavigation3 = this.playerNavigation;
				PlayerNavigation.PlayerInteractionCompleted value3 = PlayerNavigation_OnPlayerInteractionCompleted;
				playerNavigation3.OnPlayerInteractionCompleted -= value3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A36")]
		[Cpp2IlInjected.Address(RVA = "0x13DCFA0", Offset = "0x13DB9A0", VA = "0x1813DCFA0")]
		private void AutoCancel()
		{
			//IL_0010: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			Transform target = _target;
			int num = 0;
			if (target != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Target = (Transform)num2;
				if (this.AutoCancelled == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A37")]
		[Cpp2IlInjected.Address(RVA = "0x13DD070", Offset = "0x13DBA70", VA = "0x1813DD070")]
		[IteratorStateMachine(typeof(_003CDistanceCheckRoutine_003Ed__40))]
		private IEnumerator DistanceCheckRoutine()
		{
			int _003C_003E1__state = default(int);
			_003CDistanceCheckRoutine_003Ed__40 _003CDistanceCheckRoutine_003Ed__ = new _003CDistanceCheckRoutine_003Ed__40(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDistanceCheckRoutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A38")]
		[Cpp2IlInjected.Address(RVA = "0x13DD8F0", Offset = "0x13DC2F0", VA = "0x1813DD8F0")]
		private unsafe void RaiseDestinationReached()
		{
			//Discarded unreachable code: IL_004b
			//IL_0040: Expected native int or pointer, but got O
			Transform target = _target;
			float z = lastTargetPositionReached.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			bool flag = default(bool);
			if (flag)
			{
				Transform target2 = _target;
				EventHandler reachedDestination = this.ReachedDestination;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				((Vector3*)(IntPtr)lastTargetPositionReached)->z = z3;
				if (reachedDestination == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A39")]
		[Cpp2IlInjected.Address(RVA = "0x13DDA10", Offset = "0x13DC410", VA = "0x1813DDA10")]
		private void ResetMoverPosition()
		{
			//Discarded unreachable code: IL_0082
			ParticleSystem[] array = particleSystems;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Stop();
				num++;
			}
			PlayerAvatar playerAvatar = this.playerAvatar;
			NavMeshAgent navMeshAgent = moverNavMeshAgent;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform _003Ctransform_003Ek__BackingField2 = this.playerAvatar.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			ParticleSystem[] array2 = particleSystems;
			int length2 = array2.Length;
			if (num < length2)
			{
				ParticleSystemManager.Play(array2[num]);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3A")]
		[Cpp2IlInjected.Address(RVA = "0x13DD550", Offset = "0x13DBF50", VA = "0x1813DD550")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0017
			AK.Wwise.Event sfxnavigationtrailStart = _sfxnavigationtrailStart;
			GameObject gameObject = base.gameObject;
			uint num = sfxnavigationtrailStart.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3B")]
		[Cpp2IlInjected.Address(RVA = "0x13DD510", Offset = "0x13DBF10", VA = "0x1813DD510")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0017
			AK.Wwise.Event sfxnavigationtrailStop = _sfxnavigationtrailStop;
			GameObject gameObject = base.gameObject;
			uint num = sfxnavigationtrailStop.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3C")]
		[Cpp2IlInjected.Address(RVA = "0x13DD640", Offset = "0x13DC040", VA = "0x1813DD640")]
		private void PlayerNavigation_OnTaskQueued(PlayerTask task, int index)
		{
			//Discarded unreachable code: IL_00ee
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			Transform target = _target;
			int num = 0;
			if (!(target != (UnityEngine.Object)num))
			{
				return;
			}
			PlayerTaskCollider _003CTaskCollider_003Ek__BackingField = task.TaskCollider;
			int num2 = 0;
			if (_003CTaskCollider_003Ek__BackingField != (UnityEngine.Object)num2)
			{
				Transform destination = task.TaskCollider.Destination;
				Transform target2 = _target;
				if (destination == target2)
				{
					goto IL_00e7;
				}
			}
			PlayerTaskCollider _003CTaskCollider_003Ek__BackingField2 = task.TaskCollider;
			int num3 = 0;
			if (_003CTaskCollider_003Ek__BackingField2 == (UnityEngine.Object)num3)
			{
				GardeningSlot taskData = task.GetTaskData<GardeningSlot>();
				int num4 = 0;
				if (taskData != (UnityEngine.Object)num4)
				{
					GardeningSlot taskData2 = task.GetTaskData<GardeningSlot>();
					GardeningSlot component = _target.GetComponent<GardeningSlot>();
					if (taskData2 == component)
					{
						goto IL_00e7;
					}
				}
			}
			PlayerTaskDefinition _003CDefinition_003Ek__BackingField = task.Definition;
			PlayerTaskDefinition upgradeBuildingTask = _upgradeBuildingTask;
			if (_003CDefinition_003Ek__BackingField == upgradeBuildingTask)
			{
				PlayerTaskCollider _003CTaskCollider_003Ek__BackingField3 = task.TaskCollider;
				Transform target3 = _target;
				Transform parent = _003CTaskCollider_003Ek__BackingField3.Destination.GetComponentInParent<ItemScript>().transform;
				if (!target3.IsChildOf(parent))
				{
					return;
				}
				goto IL_00e7;
			}
			return;
			IL_00e7:
			AutoCancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3D")]
		[Cpp2IlInjected.Address(RVA = "0x13DD590", Offset = "0x13DBF90", VA = "0x1813DD590")]
		private void PlayerNavigation_OnPlayerInteractionCompleted(IPlayerInteraction playerInteraction)
		{
			//Discarded unreachable code: IL_0028
			//IL_0010: Expected O, but got I4
			Transform target = _target;
			int num = 0;
			if (target != (UnityEngine.Object)num && _target.GetComponentInChildren<IPlayerInteraction>() == playerInteraction)
			{
				AutoCancel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3E")]
		[Cpp2IlInjected.Address(RVA = "0x13DDEB0", Offset = "0x13DC8B0", VA = "0x1813DDEB0")]
		private void Toolbox_ToolInteractedWithObjectEvent(object sender, GameObject e)
		{
			//Discarded unreachable code: IL_0032
			//IL_0010: Expected O, but got I4
			Transform target = _target;
			int num = 0;
			if (target != (UnityEngine.Object)num)
			{
				Transform transform = e.transform;
				Transform target2 = _target;
				if (transform == target2)
				{
					AutoCancel();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3F")]
		[Cpp2IlInjected.Address(RVA = "0x13DDEA0", Offset = "0x13DC8A0", VA = "0x1813DDEA0")]
		private void Target_OnVisibilityChanged(object sender, bool shown)
		{
			if (!shown)
			{
				AutoCancel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A40")]
		[Cpp2IlInjected.Address(RVA = "0x13DDF80", Offset = "0x13DC980", VA = "0x1813DDF80")]
		public Trail()
		{
		}
	}
}
