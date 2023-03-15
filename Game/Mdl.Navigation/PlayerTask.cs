using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C7B")]
	public sealed class PlayerTask : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000C7C")]
		public class PlayerTaskDynamicData : IPlayerTaskData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40045E3")]
			public Vector3 AvatarDestinatinationPosition;

			[Cpp2IlInjected.Token(Token = "0x60039D5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlayerTaskDynamicData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045BA")]
		[Header("Avatar Movement")]
		public PlayerTaskArrivedAtDestinationCondition ArrivedAtDestinationCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40045BB")]
		public bool NavigationAllowPartialPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40045BC")]
		public float CloseToDestinationMinDistance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40045BD")]
		public float CloseToDestinationMaxDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40045BE")]
		public NavigationOverrideType NavigationOverrideType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40045BF")]
		public bool DisableAllMovement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40045C0")]
		public bool DisableNavMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40045C1")]
		public float PositionQueryDistanceWeight = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40045C2")]
		public float PositionQueryDirectionWeight = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40045C3")]
		[Header("Avatar Rotation")]
		public bool FaceTowardDestination = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40045C4")]
		public CharacterFacingBehavior FaceTowardBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40045C5")]
		public float OverrideFaceTowardDuration = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40045C6")]
		[Header("Task Step Parallelization")]
		public PlayerTaskParallelization ParallelBehavior = PlayerTaskParallelization.MovementAndFacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40045C7")]
		[Header("Misc")]
		public bool DisableShortcuts = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40045C8")]
		public bool ForceAvatarVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40045C9")]
		[SerializeField]
		[Header("Audio")]
		private AK.Wwise.Event ActionStartedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40045CA")]
		[SerializeField]
		private AK.Wwise.Event ActionFailedToStartSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40045CB")]
		[Header("Debug")]
		public bool EnableDebugLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40045D5")]
		private PlayerAction _action;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40045D6")]
		private Task _taskExecution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40045D7")]
		private bool _initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40045D8")]
		private CancellationTokenSource _preExecuteCancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40045D9")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40045DA")]
		private GameObject _vfxInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40045DB")]
		private string _vfxOutBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40045DC")]
		private bool wasAvatarNavMeshAgentEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
		[Cpp2IlInjected.Token(Token = "0x40045E1")]
		private bool? executingAction;

		[Cpp2IlInjected.Token(Token = "0x40045E2")]
		private static readonly float DebugDuration;

		[Cpp2IlInjected.Token(Token = "0x170007B6")]
		public PlayerTaskDefinition Definition
		{
			[Cpp2IlInjected.Token(Token = "0x6003999")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CDefinition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600399A")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			private set
			{
				_003CDefinition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B7")]
		public PlayerTaskCollider TaskCollider
		{
			[Cpp2IlInjected.Token(Token = "0x600399B")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CTaskCollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600399C")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			private set
			{
				_003CTaskCollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B8")]
		public PlayerAvatar Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x600399D")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600399E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			private set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B9")]
		public unsafe Vector3 Destination
		{
			[Cpp2IlInjected.Token(Token = "0x600399F")]
			[Cpp2IlInjected.Address(RVA = "0x14D4950", Offset = "0x14D3350", VA = "0x1814D4950")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60039A0")]
			[Cpp2IlInjected.Address(RVA = "0x14D4B40", Offset = "0x14D3540", VA = "0x1814D4B40")]
			[CompilerGenerated]
			private set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CDestination_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BA")]
		public IPlayerTaskData[] TaskData
		{
			[Cpp2IlInjected.Token(Token = "0x60039A1")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			[CompilerGenerated]
			get
			{
				return _003CTaskData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60039A2")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			[CompilerGenerated]
			private set
			{
				_003CTaskData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x98"), Cpp2IlInjected.Token(Token = "0x40045D1")]
		public int TaskId
		{
			[Cpp2IlInjected.Token(Token = "0x60039A3")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60039A4")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007BC")]
		public CancellationToken PreExecuteCancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60039A5")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CPreExecuteCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60039A6")]
			[Cpp2IlInjected.Address(RVA = "0x14D4B70", Offset = "0x14D3570", VA = "0x1814D4B70")]
			[CompilerGenerated]
			private set
			{
				_003CPreExecuteCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BD")]
		public bool CanBeResumed
		{
			[Cpp2IlInjected.Token(Token = "0x60039A7")]
			[Cpp2IlInjected.Address(RVA = "0x14D48B0", Offset = "0x14D32B0", VA = "0x1814D48B0")]
			get
			{
				//Discarded unreachable code: IL_002c
				//IL_001b: Expected O, but got I4
				if (Result == PlayerTaskResult.Completed)
				{
					int num = 0;
				}
				PlayerAction action = _action;
				int num2 = 0;
				if (action == (UnityEngine.Object)num2)
				{
					return true;
				}
				return _action.CanBeResumed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA8"), Cpp2IlInjected.Token(Token = "0x40045D3")]
		public bool InProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60039A8")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60039A9")]
			[Cpp2IlInjected.Address(RVA = "0x7DB480", Offset = "0x7D9E80", VA = "0x1807DB480")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007BF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xAC"), Cpp2IlInjected.Token(Token = "0x40045D4")]
		public PlayerTaskResult Result
		{
			[Cpp2IlInjected.Token(Token = "0x60039AA")]
			[Cpp2IlInjected.Address(RVA = "0x1024770", Offset = "0x1023170", VA = "0x181024770")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60039AB")]
			[Cpp2IlInjected.Address(RVA = "0x1024810", Offset = "0x1023210", VA = "0x181024810")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007C0")]
		private float? FacingDuration
		{
			[Cpp2IlInjected.Token(Token = "0x60039AC")]
			[Cpp2IlInjected.Address(RVA = "0x14D4970", Offset = "0x14D3370", VA = "0x1814D4970")]
			get
			{
				//IL_000b: Invalid comparison between F4 and I4
				float overrideFaceTowardDuration = OverrideFaceTowardDuration;
				int num = 0;
				if (!(overrideFaceTowardDuration <= (float)num))
				{
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007C1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xF8"), Cpp2IlInjected.Token(Token = "0x40045DE")]
		public bool IsMovementComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60039AF")]
			[Cpp2IlInjected.Address(RVA = "0xF32FF0", Offset = "0xF319F0", VA = "0x180F32FF0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60039B0")]
			[Cpp2IlInjected.Address(RVA = "0xF33000", Offset = "0xF31A00", VA = "0x180F33000")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007C2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x108"), Cpp2IlInjected.Token(Token = "0x40045E0")]
		public bool IsFacingComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60039B3")]
			[Cpp2IlInjected.Address(RVA = "0x14D49D0", Offset = "0x14D33D0", VA = "0x1814D49D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60039B4")]
			[Cpp2IlInjected.Address(RVA = "0x14D4B60", Offset = "0x14D3560", VA = "0x1814D4B60")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007C3")]
		private bool IsRunningMovementAndFacingInParallel
		{
			[Cpp2IlInjected.Token(Token = "0x60039C5")]
			[Cpp2IlInjected.Address(RVA = "0x14D49E0", Offset = "0x14D33E0", VA = "0x1814D49E0")]
			get
			{
				return ParallelBehavior == PlayerTaskParallelization.Everything;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A0")]
		public event EventHandler OnMovementComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60039AD")]
			[Cpp2IlInjected.Address(RVA = "0x14D4810", Offset = "0x14D3210", VA = "0x1814D4810")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039AE")]
			[Cpp2IlInjected.Address(RVA = "0x14D4AA0", Offset = "0x14D34A0", VA = "0x1814D4AA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A1")]
		public event EventHandler OnFacingComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60039B1")]
			[Cpp2IlInjected.Address(RVA = "0x14D4770", Offset = "0x14D3170", VA = "0x1814D4770")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039B2")]
			[Cpp2IlInjected.Address(RVA = "0x14D4A00", Offset = "0x14D3400", VA = "0x1814D4A00")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039B5")]
		[Cpp2IlInjected.Address(RVA = "0x14D3940", Offset = "0x14D2340", VA = "0x1814D3940")]
		public void Init(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, PlayerAvatar avatar, Vector3 destination, IPlayerTaskData[] taskData, int taskId, CancellationToken ct)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039B6")]
		[Cpp2IlInjected.Address(RVA = "0x14D40B0", Offset = "0x14D2AB0", VA = "0x1814D40B0")]
		public void PlayVfx(GameObject vfxPrefab, string vfxOutBool)
		{
			//Discarded unreachable code: IL_00c4
			//IL_0010: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			GameObject vfxInstance = _vfxInstance;
			int num = 0;
			if (vfxInstance != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(_vfxInstance);
			}
			Transform parent = SystemRoot.Instance.transform;
			GameObject gameObject = (_vfxInstance = UnityEngine.Object.Instantiate(vfxPrefab, parent));
			GameObject vfxInstance2 = _vfxInstance;
			if (ArrivedAtDestinationCondition != PlayerTaskArrivedAtDestinationCondition.DontMoveToDestination)
			{
				Transform transform = vfxInstance2.transform;
				PlayerTaskCollider playerTaskCollider = TaskCollider;
				int num2 = 0;
				if (playerTaskCollider != (UnityEngine.Object)num2)
				{
					Transform destination = TaskCollider.Destination;
				}
				float z = Destination.z;
			}
			Transform _003Ctransform_003Ek__BackingField = Avatar.transform;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			_vfxOutBool = vfxOutBool;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack.CurrentSceneChanged value = DestroyVfxImmediate;
			sceneStack.OnCurrentSceneChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60039B7")]
		[Cpp2IlInjected.Address(RVA = "0x14D4450", Offset = "0x14D2E50", VA = "0x1814D4450")]
		public void StopVfx(bool immediately = false)
		{
			//Discarded unreachable code: IL_0069
			//IL_0010: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			GameObject vfxInstance = _vfxInstance;
			int num = 0;
			if (!(vfxInstance != (UnityEngine.Object)num))
			{
				return;
			}
			if (!immediately && !string.IsNullOrEmpty(_vfxOutBool))
			{
				Animator component = _vfxInstance.GetComponent<Animator>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					Animator component2 = _vfxInstance.GetComponent<Animator>();
					string vfxOutBool = _vfxOutBool;
					component2.SetBool(vfxOutBool, value: true);
					return;
				}
			}
			UnityEngine.Object.Destroy(_vfxInstance);
		}

		[Cpp2IlInjected.Token(Token = "0x60039B8")]
		[Cpp2IlInjected.Address(RVA = "0x14D1BC0", Offset = "0x14D05C0", VA = "0x1814D1BC0")]
		public void Execute()
		{
			//Discarded unreachable code: IL_0024
			//IL_0023: Expected I4, but got I8
			bool flag = default(bool);
			if (!flag)
			{
				CancellationToken token = _cancellationTokenSource.Token;
				int num = 0;
				Task taskExecution = default(Task);
				_taskExecution = taskExecution;
			}
			else
			{
				Result = PlayerTaskResult.Completed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039B9")]
		[Cpp2IlInjected.Address(RVA = "0x14D1A20", Offset = "0x14D0420", VA = "0x1814D1A20")]
		private void DestroyVfxImmediate(SceneData loadedScene)
		{
			//IL_0010: Expected O, but got I4
			GameObject vfxInstance = _vfxInstance;
			int num = 0;
			if (vfxInstance != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(_vfxInstance);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039BA")]
		[Cpp2IlInjected.Address(RVA = "0x14D3DF0", Offset = "0x14D27F0", VA = "0x1814D3DF0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00a8
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			//IL_007f: Expected O, but got I8
			//IL_00a7: Expected O, but got I8
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.CurrentSceneChanged value = DestroyVfxImmediate;
				sceneStack.OnCurrentSceneChanged -= value;
			}
			int immediately = 0;
			StopVfx((byte)immediately != 0);
			Task taskExecution = _taskExecution;
			if (taskExecution == null || taskExecution.Exception == null)
			{
				CancellationTokenSource preExecuteCancellationTokenSource = _preExecuteCancellationTokenSource;
				if (preExecuteCancellationTokenSource != null)
				{
					preExecuteCancellationTokenSource.Cancel();
					_preExecuteCancellationTokenSource.Dispose();
					_preExecuteCancellationTokenSource = (CancellationTokenSource)0;
				}
				CancellationTokenSource cancellationTokenSource = _cancellationTokenSource;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
					_cancellationTokenSource.Dispose();
					_cancellationTokenSource = (CancellationTokenSource)0;
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039BB")]
		[Cpp2IlInjected.Address(RVA = "0x14D15F0", Offset = "0x14CFFF0", VA = "0x1814D15F0")]
		public void Cancel()
		{
			//Discarded unreachable code: IL_007e
			//IL_0025: Expected O, but got I8
			//IL_0050: Expected O, but got I4
			//IL_0074: Expected O, but got I8
			//IL_007d: Expected I4, but got I8
			CancellationTokenSource cancellationTokenSource = _cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				_cancellationTokenSource.Dispose();
				_cancellationTokenSource = (CancellationTokenSource)0;
			}
			if ((long)_taskExecution != 0)
			{
				Avatar.Agent.ResetPath();
				PlayerAction action = _action;
				int num = 0;
				if (action != (UnityEngine.Object)num)
				{
					PlayerAction action2 = _action;
					PlayerAvatar avatar = Avatar;
					action2.CancelAction(avatar, this);
				}
			}
			_taskExecution = (Task)0;
			Result = PlayerTaskResult.Cancelled;
		}

		[Cpp2IlInjected.Token(Token = "0x60039BC")]
		[Cpp2IlInjected.Address(RVA = "0x26D4AD0", Offset = "0x26D34D0", VA = "0x1826D4AD0")]
		public T GetTaskData<T>() where T : class, IPlayerTaskData
		{
			IPlayerTaskData[] array = TaskData;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				if (num == 0)
				{
					num++;
				}
				if (num == 0)
				{
					throw new InvalidCastException();
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039BD")]
		[Cpp2IlInjected.Address(RVA = "0x26D4980", Offset = "0x26D3380", VA = "0x1826D4980")]
		public List<T> GetAllTasksData<T>() where T : class, IPlayerTaskData
		{
			IPlayerTaskData[] array = TaskData;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				if (num != 0 && num == 0)
				{
					throw new InvalidCastException();
				}
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039BE")]
		[Cpp2IlInjected.Address(RVA = "0x14D14F0", Offset = "0x14CFEF0", VA = "0x1814D14F0")]
		public unsafe void AddTaskData(IPlayerTaskData playerTaskData)
		{
			//IL_004d: Expected I4, but got O
			IPlayerTaskData[] array;
			do
			{
				int length = TaskData.Length;
				length++;
				array = new IPlayerTaskData[length];
				IPlayerTaskData[] array2 = TaskData;
				int length2 = array2.Length;
				Array.Copy(array2, array, length2);
			}
			while (playerTaskData != null && array == null);
			int num = array.Length - 1;
			num += 4;
			((int*)num)->m_value = (int)playerTaskData;
			TaskData = array;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039BF")]
		[Cpp2IlInjected.Address(RVA = "0x14D45C0", Offset = "0x14D2FC0", VA = "0x1814D45C0")]
		[AsyncStateMachine(typeof(_003CTaskExecution_003Ed__91))]
		private Task TaskExecution(CancellationToken externalCancellationToken)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039C0")]
		[Cpp2IlInjected.Address(RVA = "0x14D1FA0", Offset = "0x14D09A0", VA = "0x1814D1FA0")]
		private Task GetActionTask(CancellationTokenSource cancellationTokenSource)
		{
			//IL_0010: Expected O, but got I4
			PlayerAction action = _action;
			int num = 0;
			if (!(action == (UnityEngine.Object)num))
			{
				PlayerAction action2 = _action;
				string msg = $"Action: {action2}";
				object[] args = Array.Empty<object>();
				GameLog.Info(msg, args);
				int num2 = 0;
				executingAction = (bool?)args;
				if (NavigationOverrideType == (NavigationOverrideType)num2)
				{
					int num3 = 0;
				}
				int num4 = 0;
			}
			int num5 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60039C1")]
		[Cpp2IlInjected.Address(RVA = "0x14D1D60", Offset = "0x14D0760", VA = "0x1814D1D60")]
		[AsyncStateMachine(typeof(_003CGetActionTaskDefault_003Ed__93))]
		private Task GetActionTaskDefault(CancellationTokenSource cancellationTokenSource)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039C2")]
		[Cpp2IlInjected.Address(RVA = "0x14D1E80", Offset = "0x14D0880", VA = "0x1814D1E80")]
		[AsyncStateMachine(typeof(_003CGetActionTaskWithOverrideControls_003Ed__94))]
		private Task GetActionTaskWithOverrideControls(CancellationTokenSource cancellationTokenSource)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039C3")]
		[Cpp2IlInjected.Address(RVA = "0x14D2E80", Offset = "0x14D1880", VA = "0x1814D2E80")]
		private Task GetMovementTask(CancellationTokenSource cts)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039C4")]
		[Cpp2IlInjected.Address(RVA = "0x14D3C90", Offset = "0x14D2690", VA = "0x1814D3C90")]
		[AsyncStateMachine(typeof(_003CMoveAvatar_003Ed__96))]
		private Task MoveAvatar(Vector3 destination, float stoppingDistance, CancellationTokenSource selfCancellationSource, bool playerTask = false, bool usePositionForDistanceCheck = false, bool allowPartialPath = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039C6")]
		[Cpp2IlInjected.Address(RVA = "0x14D2D10", Offset = "0x14D1710", VA = "0x1814D2D10")]
		private Vector3 GetIntendedDestination()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039C7")]
		[Cpp2IlInjected.Address(RVA = "0x14D23E0", Offset = "0x14D0DE0", VA = "0x1814D23E0")]
		private Task GetFacingTask(Vector3 intendedDestination, CancellationToken ct)
		{
			//IL_0043: Expected O, but got I4
			int num = 0;
			Task completedTask = Task.CompletedTask;
			if (FaceTowardDestination)
			{
				if (ArrivedAtDestinationCondition != PlayerTaskArrivedAtDestinationCondition.CloseToDestination)
				{
					PlayerTaskCollider playerTaskCollider = TaskCollider;
					if ((object)playerTaskCollider != null)
					{
						Transform destination = playerTaskCollider.Destination;
						Vector3 vector = default(Vector3);
						float z = vector.z;
					}
					if ((object)playerTaskCollider == null || !((Vector3)num == intendedDestination))
					{
						goto IL_00a0;
					}
					GameObject _003CgameObject_003Ek__BackingField = Avatar.gameObject;
					Transform destination2 = TaskCollider.Destination;
					Transform destination3 = TaskCollider.Destination;
					CharacterFacingBehavior faceTowardBehavior = FaceTowardBehavior;
					float? facingDuration = (float?)this.get_FacingDuration();
					int num2 = 0;
				}
				GameObject _003CgameObject_003Ek__BackingField2 = Avatar.gameObject;
				CharacterFacingBehavior faceTowardBehavior2 = FaceTowardBehavior;
				float? facingDuration2 = (float?)this.get_FacingDuration();
				int num3 = 0;
			}
			goto IL_00a0;
			IL_00a0:
			Func<Task, Task> func = (Func<Task, Task>)(object)new Func<T, TResult>(GetFireFacingCompleteTask);
			Task<Task> task = (Task<Task>)(object)completedTask.ContinueWith<Task>((Func<, >)(object)func, TaskContinuationOptions.ExecuteSynchronously);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039C8")]
		[Cpp2IlInjected.Address(RVA = "0x14D2950", Offset = "0x14D1350", VA = "0x1814D2950")]
		private Task GetFutureFacingTask(Vector3 intendedDestination, CancellationToken ct)
		{
			//IL_0043: Expected O, but got I4
			int num = 0;
			Task completedTask = Task.CompletedTask;
			if (FaceTowardDestination)
			{
				if (ArrivedAtDestinationCondition != PlayerTaskArrivedAtDestinationCondition.CloseToDestination)
				{
					PlayerTaskCollider playerTaskCollider = TaskCollider;
					if ((object)playerTaskCollider != null)
					{
						Transform destination = playerTaskCollider.Destination;
						Vector3 vector = default(Vector3);
						float z = vector.z;
					}
					if ((object)playerTaskCollider == null || !((Vector3)num == intendedDestination))
					{
						goto IL_00a0;
					}
					GameObject _003CgameObject_003Ek__BackingField = Avatar.gameObject;
					Transform destination2 = TaskCollider.Destination;
					Transform destination3 = TaskCollider.Destination;
					CharacterFacingBehavior faceTowardBehavior = FaceTowardBehavior;
					float? facingDuration = (float?)this.get_FacingDuration();
					int num2 = 0;
				}
				GameObject _003CgameObject_003Ek__BackingField2 = Avatar.gameObject;
				CharacterFacingBehavior faceTowardBehavior2 = FaceTowardBehavior;
				float? facingDuration2 = (float?)this.get_FacingDuration();
				int num3 = 0;
			}
			goto IL_00a0;
			IL_00a0:
			Func<Task, Task> func = (Func<Task, Task>)(object)new Func<T, TResult>(GetFireFacingCompleteTask);
			Task<Task> task = (Task<Task>)(object)completedTask.ContinueWith<Task>((Func<, >)(object)func, TaskContinuationOptions.ExecuteSynchronously);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039C9")]
		[Cpp2IlInjected.Address(RVA = "0x14D22B0", Offset = "0x14D0CB0", VA = "0x1814D22B0")]
		[AsyncStateMachine(typeof(_003CMoveThenFace_003Ed__102))]
		private Task MoveThenFace(CancellationTokenSource cts)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CA")]
		[Cpp2IlInjected.Address(RVA = "0x14D2870", Offset = "0x14D1270", VA = "0x1814D2870")]
		private Task GetFireMovementCompleteTask(Task continuationFromTask)
		{
			//Discarded unreachable code: IL_0023
			if (!continuationFromTask.IsCanceled)
			{
				EventHandler onMovementComplete = this.OnMovementComplete;
				IsMovementComplete = true;
				if (onMovementComplete == null)
				{
				}
			}
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CB")]
		[Cpp2IlInjected.Address(RVA = "0x14D2790", Offset = "0x14D1190", VA = "0x1814D2790")]
		private Task GetFireFacingCompleteTask(Task continuationFromTask)
		{
			//Discarded unreachable code: IL_0023
			if (!continuationFromTask.IsCanceled)
			{
				EventHandler onFacingComplete = this.OnFacingComplete;
				IsFacingComplete = true;
				if (onFacingComplete == null)
				{
				}
			}
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CC")]
		[Cpp2IlInjected.Address(RVA = "0x14D22B0", Offset = "0x14D0CB0", VA = "0x1814D22B0")]
		private Task GetCombinedMovementAndFacingTask(CancellationTokenSource cts)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CD")]
		[Cpp2IlInjected.Address(RVA = "0x14D1890", Offset = "0x14D0290", VA = "0x1814D1890")]
		public void DestroyTask()
		{
			if (!InProgress)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60039CE")]
		[Cpp2IlInjected.Address(RVA = "0x14D1AC0", Offset = "0x14D04C0", VA = "0x1814D1AC0")]
		[AsyncStateMachine(typeof(_003CDestroyWhenNotInProgress_003Ed__107))]
		private Task DestroyWhenNotInProgress()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CF")]
		[Cpp2IlInjected.Address(RVA = "0x14D3780", Offset = "0x14D2180", VA = "0x1814D3780")]
		public IPlayerTaskData GetPlayerTaskData(PlayerTaskDefinition playerTaskDefinition, CancellationToken ct)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039D0")]
		[Cpp2IlInjected.Address(RVA = "0x14D1730", Offset = "0x14D0130", VA = "0x1814D1730")]
		[AsyncStateMachine(typeof(_003CCreateTaskDataArray_003Ed__109))]
		internal static Task<IPlayerTaskData[]> CreateTaskDataArray(PlayerTaskDefinition definition, GameObject target, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<IPlayerTaskData[]>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		private void DebugPosition(Vector3 position, Color color)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		private void DebugPositionRadius(Vector3 position, float radius, Color color)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039D3")]
		[Cpp2IlInjected.Address(RVA = "0x14D4730", Offset = "0x14D3130", VA = "0x1814D4730")]
		public PlayerTask()
		{
		}//IL_0047: Expected I4, but got I8

	}
}
