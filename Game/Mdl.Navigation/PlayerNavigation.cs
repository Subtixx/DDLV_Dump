using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Cameras;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Gestures;
using Mdl.Grid;
using Mdl.InputSystem;
using Mdl.Items;
using Mdl.Missions;
using Mdl.Motion;
using Mdl.Navigation.ControlSchemes;
using Mdl.Systems;
using Mdl.Ui;
using Mdl.Utils;
using Meta;
using Meta.Util;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C56")]
	public class PlayerNavigation : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x2000C57")]
		public delegate void ControlSchemeChanged(ControlSchemeType controlScheme);

		[Cpp2IlInjected.Token(Token = "0x2000C58")]
		public delegate void TaskQueued(PlayerTask task, int index);

		[Cpp2IlInjected.Token(Token = "0x2000C59")]
		public delegate void TaskStarted(PlayerTask task, int index);

		[Cpp2IlInjected.Token(Token = "0x2000C5A")]
		public delegate void TaskCancelled(PlayerTask task, int index);

		[Cpp2IlInjected.Token(Token = "0x2000C5B")]
		public delegate void TaskCompleted(PlayerTask task, int index);

		[Cpp2IlInjected.Token(Token = "0x2000C5C")]
		internal delegate void PlayerInteractionCompleted(IPlayerInteraction playerInteraction);

		[Cpp2IlInjected.Token(Token = "0x2000C5D")]
		public delegate void ControlChanged(bool overriden);

		[Cpp2IlInjected.Token(Token = "0x2000C5E")]
		public delegate void CameraOverrideChanged(bool overridden);

		[Cpp2IlInjected.Token(Token = "0x2000C5F")]
		private class OrderingValueComparer : IComparer<Collider>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400452F")]
			private readonly PlayerNavigation playerNavigation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4004530")]
			private readonly Transform avatarTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4004531")]
			private Vector3 originPosition;

			[Cpp2IlInjected.Token(Token = "0x600396B")]
			[Cpp2IlInjected.Address(RVA = "0x1692220", Offset = "0x1690C20", VA = "0x181692220")]
			public OrderingValueComparer(PlayerNavigation playerNavigation)
			{
				this.playerNavigation = playerNavigation;
				Transform transform = (avatarTransform = SystemRoot.Instance._avatar.transform);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600396C")]
			[Cpp2IlInjected.Address(RVA = "0x1691FA0", Offset = "0x16909A0", VA = "0x181691FA0", Slot = "4")]
			public unsafe int Compare(Collider x, Collider y)
			{
				//Discarded unreachable code: IL_0045
				//IL_0044: Expected F4, but got I4
				//IL_0044: Expected Ref, but got F4
				Transform transform = x.transform;
				float z = originPosition.z;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				Transform transform2 = y.transform;
				float z3 = originPosition.z;
				Vector3 vector2 = default(Vector3);
				float z4 = vector2.z;
				int num = 0;
				return ((float*)z4)->CompareTo(num);
			}

			[Cpp2IlInjected.Token(Token = "0x600396D")]
			[Cpp2IlInjected.Address(RVA = "0x1692150", Offset = "0x1690B50", VA = "0x181692150")]
			public unsafe void UpdateOriginPosition()
			{
				//Discarded unreachable code: IL_0039
				//IL_0033: Expected native int or pointer, but got O
				Transform transform = avatarTransform;
				Transform transform2 = avatarTransform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				PlayerNavigationConfig playerConfig = playerNavigation._playerConfig;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				((Vector3*)(IntPtr)originPosition)->z = z2;
			}

			[Cpp2IlInjected.Token(Token = "0x600396E")]
			[Cpp2IlInjected.Address(RVA = "0x16920C0", Offset = "0x1690AC0", VA = "0x1816920C0")]
			private float GetOrderingValue(Collider potentialClosest)
			{
				//Discarded unreachable code: IL_001a
				Transform transform = potentialClosest.transform;
				float z = originPosition.z;
				Vector3 vector = default(Vector3);
				return vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000C60")]
		public struct TemporaryOverrideScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4004532")]
			private readonly Action end;

			[Cpp2IlInjected.Token(Token = "0x4004533")]
			public static readonly TemporaryOverrideScope Invalid;

			[Cpp2IlInjected.Token(Token = "0x170007B4")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x600396F")]
				[Cpp2IlInjected.Address(RVA = "0x16928F0", Offset = "0x16912F0", VA = "0x1816928F0")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6003970")]
			[Cpp2IlInjected.Address(RVA = "0x10D4470", Offset = "0x10D2E70", VA = "0x1810D4470")]
			internal TemporaryOverrideScope(Action begin, Action end)
			{
				begin?.Invoke();
				this.end = end;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003971")]
			[Cpp2IlInjected.Address(RVA = "0x10D4460", Offset = "0x10D2E60", VA = "0x1810D4460", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001


			[Cpp2IlInjected.Token(Token = "0x6003972")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
			static TemporaryOverrideScope()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40044C0")]
		public int[] InputMapCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40044C1")]
		[SerializeField]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40044C2")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40044C3")]
		[SerializeField]
		private string _moveAnimBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40044C4")]
		private int moveAnimBoolHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40044C5")]
		[SerializeField]
		private string _runAnimFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40044C6")]
		private int runAnimFloatHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40044C7")]
		[SerializeField]
		private string _runSpeedAnimFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40044C8")]
		private int runSpeedAnimFloatHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40044C9")]
		[SerializeField]
		private float _speedThresholdToSendDesiredVelocityToAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40044CA")]
		[SerializeField]
		private string _runTurnAnimFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40044CB")]
		[SerializeField]
		private AK.Wwise.Event _sfxWalk;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40044CC")]
		[SerializeField]
		private AK.Wwise.Event _sfxFastTravelIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40044CD")]
		[SerializeField]
		private AK.Wwise.Event _sfxFastTravelOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40044CE")]
		[SerializeField]
		private PlayerTaskDefinition _walkTaskDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40044CF")]
		[SerializeField]
		private GameObject _defaultTaskAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40044D0")]
		[SerializeField]
		private bool _playTaskVfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40044D1")]
		[SerializeField]
		private GameObject _playerTaskVfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40044D2")]
		[SerializeField]
		private string _vfxOutBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40044D3")]
		[SerializeField]
		private GameObject _taskInfoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40044D4")]
		[SerializeField]
		private GameObject _editModeTimerVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40044D5")]
		private CancellationTokenSource _editModeTimerVFXCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40044D6")]
		[SerializeField]
		private float _holdTimeBeforeTimerVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40044D7")]
		[SerializeField]
		private bool OneTaskAtATime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40044D8")]
		[SerializeField]
		private GameObject _fastTravelInVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40044D9")]
		[SerializeField]
		private GameObject _fastTravelOutVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40044DA")]
		[SerializeField]
		private float _fastTravelCameraMovementDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x40044DB")]
		[SerializeField]
		private float _fastTravelAvatarEndAnimationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40044DC")]
		[SerializeField]
		private float _fastTravelInBetweenDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40044DD")]
		[SerializeField]
		private int _mouseOverOutlineGroupID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40044DE")]
		[SerializeField]
		private float _lineOfSightSphereCastStartAvatarHeightMinPercentage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40044DF")]
		[SerializeField]
		private float _lineOfSightSphereCastStartAvatarHeightMaxPercentage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40044E0")]
		[SerializeField]
		private float _lineOfSightSphereCastRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40044E1")]
		public ControlSchemeType pcDefaultControls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40044E2")]
		public ControlSchemeType pcDefaultHookedControls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40044E3")]
		public ControlSchemeType mobileDefaultControls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40044E4")]
		public ControlSchemeType mobileDefaultHookedControls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40044E7")]
		private ControlSchemeType _defaultScheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40044E8")]
		private OrbitCamera _orbitCameraOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40044E9")]
		private OrbitCamera _avatarOrbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40044EB")]
		private HoldInPlaceGesture _holdInPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40044EC")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40044ED")]
		private SwipeGesture _swipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40044EE")]
		private InputAction inputMoveAxes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40044EF")]
		private InputAction inputCameraPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40044F0")]
		private InputAction inputCameraRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40044F1")]
		private InputAction inputCameraRotateAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40044F2")]
		private InputAction inputCameraZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40044F3")]
		private InputAction inputMoveForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40044F4")]
		private InputAction inputInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40044F5")]
		private InputAction inputUseTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40044F6")]
		private InputAction inputResetPlayerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40044F7")]
		private InputAction inputSwitchToGridEditMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40044F8")]
		private InputAction[] cameraInputActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40044F9")]
		private InputAction[] movementInputActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40044FA")]
		private InputAction[] interactInputActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40044FB")]
		private Tween<Vector3> _cameraPositionTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40044FC")]
		private Tween<Quaternion> _cameraRotationTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40044FD")]
		private int _overrideAllRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40044FE")]
		private int _overrideAnimatorRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40044FF")]
		private int _cameraOverrideRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x4004500")]
		private int _controlsOverrideRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4004501")]
		private int _directionOverrideRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4004505")]
		private PlayerTask _walkTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4004506")]
		private List<PlayerTask> _taskQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4004507")]
		private CancellationTokenSource _taskQueueChoiceCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400450F")]
		private int taskCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x4004510")]
		private float _idleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4004511")]
		private float _touchTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x4004512")]
		private Vector3 _cameraPositionBeforeZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4004513")]
		private Vector3 _cameraRotationBeforeZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
		[Cpp2IlInjected.Token(Token = "0x4004514")]
		private bool _wasUnzooming;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4004515")]
		private Vector3 _previousCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
		[Cpp2IlInjected.Token(Token = "0x4004516")]
		private int _shortcutsBlockedPendingRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4004518")]
		private GameObject _currentInteractible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4004519")]
		private CallOnce resetInitialConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400451A")]
		private BaseHoldBehaviour _currentHoldBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400451B")]
		private BaseUiRoot.Scope _holdBehaviourBlockShortcutsScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400451C")]
		private readonly List<(GameObject go, float distanceSq)> interactibleObjectsPriorityOverrides;

		[Cpp2IlInjected.Token(Token = "0x400451D")]
		private static readonly ProfilerMarker s_moveCamera;

		[Cpp2IlInjected.Token(Token = "0x400451E")]
		private static readonly ProfilerMarker s_moveAvatar;

		[Cpp2IlInjected.Token(Token = "0x400451F")]
		private static readonly ProfilerMarker s_updateAnimator;

		[Cpp2IlInjected.Token(Token = "0x4004520")]
		private static readonly ProfilerMarker s_actuallyMoveAvatar;

		[Cpp2IlInjected.Token(Token = "0x4004521")]
		private static readonly ProfilerMarker s_getInteractable;

		[Cpp2IlInjected.Token(Token = "0x4004522")]
		private static readonly ProfilerMarker s_int_hasLineOfSight;

		[Cpp2IlInjected.Token(Token = "0x4004523")]
		private static readonly ProfilerMarker s_int_isInteractable;

		[Cpp2IlInjected.Token(Token = "0x4004524")]
		private static readonly ProfilerMarker s_int_isInteractable_redirection;

		[Cpp2IlInjected.Token(Token = "0x4004525")]
		private static readonly ProfilerMarker s_int_isInteractable_gridObjectScript;

		[Cpp2IlInjected.Token(Token = "0x4004526")]
		private static readonly ProfilerMarker s_int_isInteractable_playerInteraction;

		[Cpp2IlInjected.Token(Token = "0x4004527")]
		private static readonly ProfilerMarker s_int_isInteractable_taskCollider;

		[Cpp2IlInjected.Token(Token = "0x4004528")]
		private static readonly ProfilerMarker s_int_priorityOverrides;

		[Cpp2IlInjected.Token(Token = "0x4004529")]
		private static readonly ProfilerMarker s_int_overlapItems;

		[Cpp2IlInjected.Token(Token = "0x400452A")]
		private static readonly ProfilerMarker s_int_overlapItems_sort;

		[Cpp2IlInjected.Token(Token = "0x400452B")]
		private static readonly ProfilerMarker s_int_overlapCharacters;

		[Cpp2IlInjected.Token(Token = "0x400452C")]
		private static readonly ProfilerMarker s_int_overlapCharacters_sort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400452D")]
		private Collider[] interactibleCollisionArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400452E")]
		private OrderingValueComparer _orderingValueComparer;

		[Cpp2IlInjected.Token(Token = "0x170007A2")]
		public RectTransform InputZone
		{
			[Cpp2IlInjected.Token(Token = "0x60038B8")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return _inputZone;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14C"), Cpp2IlInjected.Token(Token = "0x40044E5")]
		protected ControlSchemeType ActiveControlSchemeType
		{
			[Cpp2IlInjected.Token(Token = "0x60038B9")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE30", Offset = "0x14CE830", VA = "0x1814CFE30")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038BA")]
			[Cpp2IlInjected.Address(RVA = "0x14D0500", Offset = "0x14CEF00", VA = "0x1814D0500")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007A4")]
		public IControlScheme ControlScheme
		{
			[Cpp2IlInjected.Token(Token = "0x60038BB")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			[CompilerGenerated]
			get
			{
				return _003CControlScheme_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60038BC")]
			[Cpp2IlInjected.Address(RVA = "0x976520", Offset = "0x974F20", VA = "0x180976520")]
			[CompilerGenerated]
			private set
			{
				_003CControlScheme_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A5")]
		public PlayerNavigationConfig PlayerConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60038BD")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _playerConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A6")]
		public bool PlayerWantsToMove
		{
			[Cpp2IlInjected.Token(Token = "0x60038C0")]
			[Cpp2IlInjected.Address(RVA = "0x14CFF20", Offset = "0x14CE920", VA = "0x1814CFF20")]
			get
			{
				InputAction inputAction = inputMoveAxes;
				if (inputAction != null)
				{
					return !inputAction.GetValueVector2().isNearZero();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A7")]
		public bool AllOverridden
		{
			[Cpp2IlInjected.Token(Token = "0x60038C1")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE40", Offset = "0x14CE840", VA = "0x1814CFE40")]
			get
			{
				return _overrideAllRequest > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A8")]
		public bool AnimatorOverridden
		{
			[Cpp2IlInjected.Token(Token = "0x60038C2")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE50", Offset = "0x14CE850", VA = "0x1814CFE50")]
			get
			{
				return _overrideAnimatorRequest > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A9")]
		public bool CameraOverridden
		{
			[Cpp2IlInjected.Token(Token = "0x60038C3")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE60", Offset = "0x14CE860", VA = "0x1814CFE60")]
			get
			{
				return _cameraOverrideRequest > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AA")]
		public bool ControlsOverridden
		{
			[Cpp2IlInjected.Token(Token = "0x60038C4")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE70", Offset = "0x14CE870", VA = "0x1814CFE70")]
			get
			{
				return _controlsOverrideRequest > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AB")]
		public bool DirectionOverridden
		{
			[Cpp2IlInjected.Token(Token = "0x60038C5")]
			[Cpp2IlInjected.Address(RVA = "0x14CFF00", Offset = "0x14CE900", VA = "0x1814CFF00")]
			get
			{
				return _directionOverrideRequest > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x21C"), Cpp2IlInjected.Token(Token = "0x4004502")]
		public bool ActionsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60038C6")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE20", Offset = "0x14CE820", VA = "0x1814CFE20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038C7")]
			[Cpp2IlInjected.Address(RVA = "0x14D04F0", Offset = "0x14CEEF0", VA = "0x1814D04F0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x21D"), Cpp2IlInjected.Token(Token = "0x4004503")]
		public bool WalkingLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60038C8")]
			[Cpp2IlInjected.Address(RVA = "0x14CFF60", Offset = "0x14CE960", VA = "0x1814CFF60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038C9")]
			[Cpp2IlInjected.Address(RVA = "0x14D0990", Offset = "0x14CF390", VA = "0x1814D0990")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x21E"), Cpp2IlInjected.Token(Token = "0x4004504")]
		public bool InputLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60038CA")]
			[Cpp2IlInjected.Address(RVA = "0x14CFF10", Offset = "0x14CE910", VA = "0x1814CFF10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038CB")]
			[Cpp2IlInjected.Address(RVA = "0x14D0980", Offset = "0x14CF380", VA = "0x1814D0980")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AF")]
		public PlayerTask CurrentTask
		{
			[Cpp2IlInjected.Token(Token = "0x60038CC")]
			[Cpp2IlInjected.Address(RVA = "0x14CFEB0", Offset = "0x14CE8B0", VA = "0x1814CFEB0")]
			get
			{
				PlayerTask playerTask = Enumerable.FirstOrDefault<PlayerTask>((IEnumerable<>)_taskQueue);
				if ((object)playerTask == null)
				{
				}
				return playerTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B0")]
		public InteractPreview CurrentInteractPreview
		{
			[Cpp2IlInjected.Token(Token = "0x60038DB")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE90", Offset = "0x14CE890", VA = "0x1814CFE90")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentInteractPreview_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60038DC")]
			[Cpp2IlInjected.Address(RVA = "0x14D06D0", Offset = "0x14CF0D0", VA = "0x1814D06D0")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentInteractPreview_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B1")]
		private GameObject CurrentInteractible
		{
			[Cpp2IlInjected.Token(Token = "0x60038DD")]
			[Cpp2IlInjected.Address(RVA = "0x14CFEA0", Offset = "0x14CE8A0", VA = "0x1814CFEA0")]
			get
			{
				return _currentInteractible;
			}
			[Cpp2IlInjected.Token(Token = "0x60038DE")]
			[Cpp2IlInjected.Address(RVA = "0x14D06E0", Offset = "0x14CF0E0", VA = "0x1814D06E0")]
			set
			{
				//Discarded unreachable code: IL_006e
				//IL_003e: Expected O, but got I4
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					EventHandler value2 = CurrentInteractibleDestroyed;
					DestroyEventProvider destroyEventProvider = default(DestroyEventProvider);
					destroyEventProvider.DestroyEvent -= value2;
					IInteractible interactible = default(IInteractible);
					if (interactible != null)
					{
					}
					CurrentInteractPreview.ClearCurrentInteractible();
				}
				_currentInteractible = value;
				int num = 0;
				if (value != (UnityEngine.Object)num)
				{
					DestroyEventProvider orAddComponent = value.GetOrAddComponent<DestroyEventProvider>();
					EventHandler value3 = CurrentInteractibleDestroyed;
					orAddComponent.DestroyEvent += value3;
					IInteractible interactible2 = default(IInteractible);
					if (interactible2 != null)
					{
					}
					InteractPreview interactPreview = CurrentInteractPreview;
				}
				[Cpp2IlInjected.Token(Token = "0x600393B")]
				[Cpp2IlInjected.Address(RVA = "0x14C5CD0", Offset = "0x14C46D0", VA = "0x1814C5CD0")]
				void CurrentInteractibleDestroyed(object sender, EventArgs e)
				{
					//IL_0009: Expected O, but got I4
					int num2 = 0;
					CurrentInteractible = (GameObject)num2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B2")]
		internal BaseHoldBehaviour CurrentHoldBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x60038DF")]
			[Cpp2IlInjected.Address(RVA = "0x14CFE80", Offset = "0x14CE880", VA = "0x1814CFE80")]
			get
			{
				return _currentHoldBehaviour;
			}
			[Cpp2IlInjected.Token(Token = "0x60038E0")]
			[Cpp2IlInjected.Address(RVA = "0x14D0510", Offset = "0x14CEF10", VA = "0x1814D0510")]
			set
			{
				//Discarded unreachable code: IL_0040
				//IL_000d: Expected O, but got I4
				//IL_001d: Expected O, but got I4
				//IL_0037: Expected O, but got I4
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				int num = 0;
				_holdBehaviourBlockShortcutsScope = (BaseUiRoot.Scope)num;
				_currentHoldBehaviour = value;
				int num2 = 0;
				if (value != (UnityEngine.Object)num2)
				{
					if ((object)Enumerable.FirstOrDefault<PlayerTask>((IEnumerable<>)_taskQueue) == null)
					{
					}
					int num3 = 0;
					CurrentInteractible = (GameObject)num3;
					BaseUiRoot.Scope holdBehaviourBlockShortcutsScope = default(BaseUiRoot.Scope);
					_holdBehaviourBlockShortcutsScope = holdBehaviourBlockShortcutsScope;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B3")]
		private OrderingValueComparer orderingValueComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6003919")]
			[Cpp2IlInjected.Address(RVA = "0x14CFF70", Offset = "0x14CE970", VA = "0x1814CFF70")]
			get
			{
				OrderingValueComparer orderingValueComparer = _orderingValueComparer;
				if (orderingValueComparer == null)
				{
					OrderingValueComparer orderingValueComparer2 = (_orderingValueComparer = new OrderingValueComparer(this));
				}
				return orderingValueComparer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000098")]
		public event ControlSchemeChanged OnControlSchemeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60038BE")]
			[Cpp2IlInjected.Address(RVA = "0x14CFA60", Offset = "0x14CE460", VA = "0x1814CFA60")]
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
			[Cpp2IlInjected.Token(Token = "0x60038BF")]
			[Cpp2IlInjected.Address(RVA = "0x14D0130", Offset = "0x14CEB30", VA = "0x1814D0130")]
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

		[Cpp2IlInjected.Token(Token = "0x14000099")]
		public event TaskQueued OnTaskQueued
		{
			[Cpp2IlInjected.Token(Token = "0x60038CD")]
			[Cpp2IlInjected.Address(RVA = "0x14CFCE0", Offset = "0x14CE6E0", VA = "0x1814CFCE0")]
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
			[Cpp2IlInjected.Token(Token = "0x60038CE")]
			[Cpp2IlInjected.Address(RVA = "0x14D03B0", Offset = "0x14CEDB0", VA = "0x1814D03B0")]
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

		[Cpp2IlInjected.Token(Token = "0x1400009A")]
		public event TaskStarted OnTaskStarted
		{
			[Cpp2IlInjected.Token(Token = "0x60038CF")]
			[Cpp2IlInjected.Address(RVA = "0x14CFD80", Offset = "0x14CE780", VA = "0x1814CFD80")]
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
			[Cpp2IlInjected.Token(Token = "0x60038D0")]
			[Cpp2IlInjected.Address(RVA = "0x14D0450", Offset = "0x14CEE50", VA = "0x1814D0450")]
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

		[Cpp2IlInjected.Token(Token = "0x1400009B")]
		public event TaskCancelled OnTaskCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60038D1")]
			[Cpp2IlInjected.Address(RVA = "0x14CFBA0", Offset = "0x14CE5A0", VA = "0x1814CFBA0")]
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
			[Cpp2IlInjected.Token(Token = "0x60038D2")]
			[Cpp2IlInjected.Address(RVA = "0x14D0270", Offset = "0x14CEC70", VA = "0x1814D0270")]
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

		[Cpp2IlInjected.Token(Token = "0x1400009C")]
		public event TaskCompleted OnTaskCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60038D3")]
			[Cpp2IlInjected.Address(RVA = "0x14CFC40", Offset = "0x14CE640", VA = "0x1814CFC40")]
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
			[Cpp2IlInjected.Token(Token = "0x60038D4")]
			[Cpp2IlInjected.Address(RVA = "0x14D0310", Offset = "0x14CED10", VA = "0x1814D0310")]
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

		[Cpp2IlInjected.Token(Token = "0x1400009D")]
		internal event PlayerInteractionCompleted OnPlayerInteractionCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60038D5")]
			[Cpp2IlInjected.Address(RVA = "0x14CFB00", Offset = "0x14CE500", VA = "0x1814CFB00")]
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
			[Cpp2IlInjected.Token(Token = "0x60038D6")]
			[Cpp2IlInjected.Address(RVA = "0x14D01D0", Offset = "0x14CEBD0", VA = "0x1814D01D0")]
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

		[Cpp2IlInjected.Token(Token = "0x1400009E")]
		public event ControlChanged OnControlChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60038D7")]
			[Cpp2IlInjected.Address(RVA = "0x14CF9C0", Offset = "0x14CE3C0", VA = "0x1814CF9C0")]
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
			[Cpp2IlInjected.Token(Token = "0x60038D8")]
			[Cpp2IlInjected.Address(RVA = "0x14D0090", Offset = "0x14CEA90", VA = "0x1814D0090")]
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

		[Cpp2IlInjected.Token(Token = "0x1400009F")]
		public event CameraOverrideChanged OnCameraOverrideChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60038D9")]
			[Cpp2IlInjected.Address(RVA = "0x14CF920", Offset = "0x14CE320", VA = "0x1814CF920")]
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
			[Cpp2IlInjected.Token(Token = "0x60038DA")]
			[Cpp2IlInjected.Address(RVA = "0x14CFFF0", Offset = "0x14CE9F0", VA = "0x1814CFFF0")]
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

		[Cpp2IlInjected.Token(Token = "0x60038B6")]
		[Cpp2IlInjected.Address(RVA = "0x14C34B0", Offset = "0x14C1EB0", VA = "0x1814C34B0")]
		private unsafe GameObject GetInteractibleObject_OLD(Vector2 position)
		{
			int num = 0;
			return GetInteractibleObject_OLD(position, out *(Vector3*)num, out *(RaycastHit[]*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60038B7")]
		[Cpp2IlInjected.Address(RVA = "0x14C2E40", Offset = "0x14C1840", VA = "0x1814C2E40")]
		private GameObject GetInteractibleObject_OLD(Vector2 position, out Vector3 hitPoint, out RaycastHit[] hits)
		{
			//IL_0023: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			//IL_015e: Expected O, but got I4
			//IL_016d: Expected I4, but got O
			//IL_017b: Expected F4, but got I4
			bool flag = default(bool);
			RaycastHit[] point = default(RaycastHit[]);
			Collider collider = default(Collider);
			GameObject redirection2 = default(GameObject);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				Vector3 zero = Vector3.zero;
				int num3 = 0;
				float num4 = (hitPoint.z = zero.z);
				System.Runtime.CompilerServices.Unsafe.As<RaycastHit[], RaycastHit>(ref hits).m_Point = (Vector3)num3;
				if (!flag)
				{
					break;
				}
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				string[] array = new string[1];
				if ("Player" != null && array == null)
				{
					continue;
				}
				array[0] = "Player";
				int mask = LayerMask.GetMask(array);
				string[] array2 = new string[1];
				if ("Audio" != null && array2 == null)
				{
					continue;
				}
				array2[0] = "Audio";
				int mask2 = LayerMask.GetMask(array2);
				System.Runtime.CompilerServices.Unsafe.As<RaycastHit[], RaycastHit>(ref hits).m_Point = (Vector3)point;
				int num5 = LayerMask.NameToLayer("Ground");
				if ((long)num3 >= (long)(IntPtr)"Ground")
				{
					break;
				}
				GameObject gameObject = collider.gameObject;
				if (gameObject.layer == num5)
				{
					break;
				}
				ColliderRedirection component = gameObject.GetComponent<ColliderRedirection>();
				int num6 = 0;
				if (component != (UnityEngine.Object)num6)
				{
					GameObject redirection = component.Redirection;
					int num7 = 0;
					if (redirection != (UnityEngine.Object)num7)
					{
						redirection2 = component.Redirection;
					}
				}
				GridObjectScript componentInParent = redirection2.GetComponentInParent<GridObjectScript>();
				int num8 = 0;
				if (componentInParent != (UnityEngine.Object)num8)
				{
					GridScript _003CGridScript_003Ek__BackingField = componentInParent.GridScript;
					int num9 = 0;
					if (_003CGridScript_003Ek__BackingField != (UnityEngine.Object)num9 && componentInParent.GridScript.Locked)
					{
						break;
					}
				}
				IPlayerInteraction component2 = redirection2.GetComponent<IPlayerInteraction>();
				if (component2 == null || component2 == null)
				{
					PlayerTaskCollider component3 = redirection2.GetComponent<PlayerTaskCollider>();
					int num10 = 0;
					if (!(component3 != (UnityEngine.Object)num10) || new List<T>((int)component3.GetAllTasks()) != null)
					{
					}
					num3++;
				}
				hitPoint.z = 0f;
				break;
			}
			int num11 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E1")]
		[Cpp2IlInjected.Address(RVA = "0x14C0E10", Offset = "0x14BF810", VA = "0x1814C0E10")]
		public void AddInteractiblePriorityOverride(GameObject go, float distance)
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			List<(GameObject, float)> list = interactibleObjectsPriorityOverrides;
			int num = 0;
			((List<T>)(object)list).Add((T)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E2")]
		[Cpp2IlInjected.Address(RVA = "0x14CAFA0", Offset = "0x14C99A0", VA = "0x1814CAFA0")]
		public void RemoveInteractiblePriorityOverride(GameObject go)
		{
			//Discarded unreachable code: IL_002a
			List<(GameObject, float)> list = interactibleObjectsPriorityOverrides;
			bool result = default(bool);
			Predicate<(GameObject, float)> predicate = (Predicate<(GameObject, float)>)(object)(Predicate<T>)(((GameObject go, float distanceSq) x) => result);
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E3")]
		[Cpp2IlInjected.Address(RVA = "0x14C4B90", Offset = "0x14C3590", VA = "0x1814C4B90")]
		private void InitDefaultControls()
		{
			//Discarded unreachable code: IL_00ae
			//IL_003b: Expected O, but got I4
			int num = 0;
			if (DebugSettings.Settings.overridePcControls_)
			{
				int num2 = 0;
				ControlSchemeType overrideControlScheme_ = DebugSettings.Settings.overrideControlScheme_;
				int num3 = 0;
				DebugSettings settings = DebugSettings.Settings;
				ControlSchemeType oVerrideHookedControlScheme_ = settings.oVerrideHookedControlScheme_;
				string msg = $"Debug forcing override of pc controls to {overrideControlScheme_}, hooked: {settings}";
				object[] args = Array.Empty<object>();
				GameLog.Info(msg, args);
				int num4 = 0;
				ControlSchemeType overrideControlScheme_2 = DebugSettings.Settings.overrideControlScheme_;
				int num5 = 0;
				pcDefaultControls = overrideControlScheme_2;
				ControlSchemeType controlSchemeType = (pcDefaultHookedControls = DebugSettings.Settings.oVerrideHookedControlScheme_);
			}
			PlayerNavigationConfig playerConfig = _playerConfig;
			ControlSchemeType controlSchemeType2 = (playerConfig.defaultControls = pcDefaultControls);
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			ControlSchemeType controlSchemeType3 = (playerConfig2.defaultHookedControls = pcDefaultHookedControls);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E4")]
		[Cpp2IlInjected.Address(RVA = "0x14C6FD0", Offset = "0x14C59D0", VA = "0x1814C6FD0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_062c
			//IL_0029: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_01cf: Expected O, but got I4
			//IL_01cf: Expected O, but got I4
			//IL_023c: Expected O, but got I4
			//IL_047d: Expected O, but got I4
			//IL_04a6: Expected I4, but got I8
			//IL_04a6: Expected O, but got I4
			//IL_04c0: Expected O, but got I4
			//IL_0575: Expected F4, but got I4
			int num2 = default(int);
			int num3;
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			InputAction[] array3;
			InputAction inputAction19;
			while (true)
			{
				int num = 0;
				InputProvider inputProvider = DefaultInputProvider.Get();
				int[] inputMapCategories = InputMapCategories;
				inputProvider.EnableMaps(inputMapCategories);
				InputTriggerPressed trigger = new InputTriggerPressed();
				InputActionBool inputActionBool = new InputActionBool("Interact", trigger, (InputProvider)num2);
				num3 = 0;
				num2 = 0;
				inputInteract = inputActionBool;
				InputAction inputAction = inputInteract;
				EventHandler value = OnInteractTriggered;
				inputAction.OnTriggered += value;
				InputTriggerPressed trigger2 = new InputTriggerPressed();
				InputActionBool inputActionBool2 = new InputActionBool("UseTool", trigger2, (InputProvider)num4);
				num4 = 0;
				inputUseTool = inputActionBool2;
				InputAction inputAction2 = inputUseTool;
				EventHandler value2 = OnUseToolTriggered;
				inputAction2.OnTriggered += value2;
				InputTriggerPressed trigger3 = new InputTriggerPressed();
				InputActionBool inputActionBool3 = new InputActionBool("DebugSwitchToGridEditMode", trigger3, (InputProvider)num5);
				num5 = 0;
				inputSwitchToGridEditMode = inputActionBool3;
				InputAction inputAction3 = inputSwitchToGridEditMode;
				EventHandler value3 = OnSwitchToGridEditMode;
				inputAction3.OnTriggered += value3;
				InputTriggerDown trigger4 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D = (InputActionVector2D)(inputMoveAxes = new InputActionVector2D("MoveHorizontal", "MoveVertical", trigger4, (InputProvider)num3));
				InputActionNone inputActionNone = (InputActionNone)(inputCameraPan = new InputActionNone());
				InputTriggerDown trigger5 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D2 = (InputActionVector2D)(inputCameraRotateAxis = new InputActionVector2D("CameraRotateYaw_Axis", "CameraRotatePitch_Axis", trigger5, (InputProvider)num3));
				InputAction inputAction4 = inputCameraRotateAxis;
				InputActionModifier_ScaleDeltaTime modifier = new InputActionModifier_ScaleDeltaTime();
				inputAction4.AddModifier(modifier);
				InputTriggerDown trigger6 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D3 = (InputActionVector2D)(inputCameraRotate = new InputActionVector2D("CameraRotateYaw", "CameraRotatePitch", trigger6, (InputProvider)num3));
				InputAction inputAction5 = inputCameraRotate;
				InputActionModifier_Merge modifier2 = new InputActionModifier_Merge(inputCameraRotateAxis);
				inputAction5.AddModifier(modifier2);
				InputAction inputAction6 = inputCameraRotate;
				InputActionModifier_Smooth modifier3 = new InputActionModifier_Smooth(5);
				inputAction6.AddModifier(modifier3);
				InputActionNone inputActionNone2 = (InputActionNone)(inputCameraZoom = new InputActionNone());
				InputTriggerDownWithDelay trigger7 = new InputTriggerDownWithDelay();
				InputActionFloat inputActionFloat = new InputActionFloat("MoveForward", trigger7, (string)num6, (InputProvider)num3);
				num6 = 0;
				inputMoveForward = inputActionFloat;
				InputAction inputAction7 = inputMoveForward;
				InputActionModifier_Swizzle modifier4 = new InputActionModifier_Swizzle();
				inputAction7.AddModifier(modifier4);
				InputAction inputAction8 = inputMoveAxes;
				InputActionModifier_Merge modifier5 = new InputActionModifier_Merge(inputMoveForward);
				inputAction8.AddModifier(modifier5);
				Func<bool> func = (Func<bool>)(object)(Func<TResult>)(() => inputMoveForward.IsTriggered);
				InputTriggerPressedWithDelay trigger8 = new InputTriggerPressedWithDelay(0.22f, (Func<>)(object)func);
				InputActionBool inputActionBool4 = new InputActionBool("ResetPlayerCamera", trigger8, (InputProvider)num7);
				num7 = 0;
				inputResetPlayerCamera = inputActionBool4;
				InputAction inputAction9 = inputResetPlayerCamera;
				EventHandler value4 = OnResetPlayerCamera;
				inputAction9.OnTriggered += value4;
				InputAction[] array = new InputAction[0];
				InputAction inputAction10 = inputCameraPan;
				if (inputAction10 != null && array == null)
				{
					continue;
				}
				array[0] = inputAction10;
				InputAction inputAction11 = inputCameraRotateAxis;
				if (inputAction11 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction11;
				InputAction inputAction12 = inputCameraRotate;
				if (inputAction12 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction12;
				InputAction inputAction13 = inputCameraZoom;
				if (inputAction13 != null && array == null)
				{
					continue;
				}
				array[3] = inputAction13;
				InputAction inputAction14 = inputResetPlayerCamera;
				if (inputAction14 != null && array == null)
				{
					continue;
				}
				array[4] = inputAction14;
				cameraInputActions = array;
				InputAction[] array2 = new InputAction[2];
				InputAction inputAction15 = inputMoveForward;
				if (inputAction15 != null && array2 == null)
				{
					continue;
				}
				array2[0] = inputAction15;
				InputAction inputAction16 = inputMoveAxes;
				if (inputAction16 != null && array2 == null)
				{
					continue;
				}
				array2[1] = inputAction16;
				movementInputActions = array2;
				array3 = new InputAction[3];
				InputAction inputAction17 = inputInteract;
				if (inputAction17 != null && array3 == null)
				{
					continue;
				}
				array3[0] = inputAction17;
				InputAction inputAction18 = inputUseTool;
				if (inputAction18 == null || array3 != null)
				{
					array3[1] = inputAction18;
					inputAction19 = inputSwitchToGridEditMode;
					if (inputAction19 == null || array3 != null)
					{
						break;
					}
				}
			}
			array3[2] = inputAction19;
			interactInputActions = array3;
			int num8 = Animator.StringToHash(_moveAnimBool);
			string runAnimFloat = _runAnimFloat;
			moveAnimBoolHash = num8;
			int num9 = Animator.StringToHash(runAnimFloat);
			string runSpeedAnimFloat = _runSpeedAnimFloat;
			runAnimFloatHash = num9;
			int num10 = (runSpeedAnimFloatHash = Animator.StringToHash(runSpeedAnimFloat));
			if ((IntPtr)ControlScheme == (IntPtr)num3)
			{
				ThirdPersonControl thirdPersonControl = (ThirdPersonControl)(ControlScheme = new ThirdPersonControl());
			}
			AvatarAppearance appearance = avatar.appearance;
			int animController = 0;
			appearance.SetAnimController((AvatarAppearance.AnimControllerType)animController).FireAndForgetTask();
			RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = avatar.RelaxingBehaviour;
			EventHandler value5 = RelaxingBehaviour_RelaxingStateChangedEvent;
			_003CRelaxingBehaviour_003Ek__BackingField.RelaxingStateChangedEvent += value5;
			int num11 = default(int);
			HoldInPlaceGesture holdInPlace = new HoldInPlaceGesture(_inputZone, (Camera)num11);
			num11 = 0;
			_holdInPlace = holdInPlace;
			_holdInPlace.MustStayWithinZone = true;
			ulong num13 = default(ulong);
			int num12 = default(int);
			MoveGesture move = new MoveGesture(_inputZone, (Camera)num12, automaticRotation: true, (byte)num13 != 0);
			num12 = 0;
			_move = move;
			int num14 = default(int);
			SwipeGesture swipe = new SwipeGesture(_inputZone, (Camera)num14);
			num14 = 0;
			_swipe = swipe;
			SwipeGesture swipe2 = _swipe;
			int num15 = 0;
			swipe2.MustStayWithinZone = true;
			if ((long)swipe2 != 32)
			{
				int num16 = 0;
				if ((long)swipe2 != 25)
				{
					int num17 = 0;
					if ((long)swipe2 != 38)
					{
						goto IL_051d;
					}
				}
				UnityEngine.Input.simulateMouseWithTouches = false;
			}
			_playerConfig.allowMoveAxesInHookedMode = true;
			_playerConfig.allowSwitchingControls = (byte)num3 != 0;
			goto IL_051d;
			IL_051d:
			PlayerAvatar playerAvatar = avatar;
			IControlScheme controlScheme = ControlScheme;
			PlayerNavigationConfig playerConfig = _playerConfig;
			Transform navigationStartCamera = playerAvatar.navigationStartCamera;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			ControlSchemeType defaultHookedControls = _playerConfig.defaultHookedControls;
			SetControlSchemeInternal(defaultHookedControls);
			_idleTime = num3;
			PlayerAvatar playerAvatar2 = avatar;
			IControlScheme controlScheme2 = ControlScheme;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar2.transform;
			int num18 = 0;
			float num19 = ControlSchemeConstants.DefaultResetAngle(_003Ctransform_003Ek__BackingField);
			Input.RegisterAxisMobile(_playerConfig.verticalAxis);
			Input.RegisterAxisMobile(_playerConfig.horizontalAxis);
			InitConfig();
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			SceneStack.CurrentSceneChanged value6 = OnCurrentSceneChanged;
			sceneStack2.OnCurrentSceneChanged += value6;
			TemporaryCameraTransition component = playerCamera.GetComponent<TemporaryCameraTransition>();
			Action value7 = OnStartCameraTransition;
			component.OnStartCameraTransition += value7;
			TemporaryCameraTransition component2 = playerCamera.GetComponent<TemporaryCameraTransition>();
			Action value8 = OnEndCameraTransition;
			component2.OnEndCameraTransition += value8;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E5")]
		[Cpp2IlInjected.Address(RVA = "0x14CAF50", Offset = "0x14C9950", VA = "0x1814CAF50")]
		private void RelaxingBehaviour_RelaxingStateChangedEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_002a
			RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = avatar.RelaxingBehaviour;
			InteractPreview interactPreview = CurrentInteractPreview;
			if (!_003CRelaxingBehaviour_003Ek__BackingField.Relaxing)
			{
				interactPreview.Enable();
			}
			else
			{
				interactPreview.Disable();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038E6")]
		[Cpp2IlInjected.Address(RVA = "0x14C8290", Offset = "0x14C6C90", VA = "0x1814C8290", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_00e2
			//IL_0054: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			TemporaryCameraTransition component = playerCamera.GetComponent<TemporaryCameraTransition>();
			Action value = OnStartCameraTransition;
			component.OnStartCameraTransition -= value;
			TemporaryCameraTransition component2 = playerCamera.GetComponent<TemporaryCameraTransition>();
			Action value2 = OnEndCameraTransition;
			component2.OnEndCameraTransition -= value2;
			PlayerAvatar playerAvatar = avatar;
			int num = 0;
			if (playerAvatar != (UnityEngine.Object)num)
			{
				RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = avatar.RelaxingBehaviour;
				int num2 = 0;
				if (_003CRelaxingBehaviour_003Ek__BackingField != (UnityEngine.Object)num2)
				{
					RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField2 = avatar.RelaxingBehaviour;
					EventHandler value3 = RelaxingBehaviour_RelaxingStateChangedEvent;
					_003CRelaxingBehaviour_003Ek__BackingField2.RelaxingStateChangedEvent -= value3;
				}
			}
			CancelAllTasks();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num3 = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num3)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.CurrentSceneChanged value4 = OnCurrentSceneChanged;
				sceneStack.OnCurrentSceneChanged -= value4;
			}
			int num4 = 0;
			CurrentInteractible = (GameObject)num4;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E7")]
		[Cpp2IlInjected.Address(RVA = "0x14C6640", Offset = "0x14C5040", VA = "0x1814C6640", Slot = "6")]
		public override void OnSystemPause()
		{
			//Discarded unreachable code: IL_00de
			//IL_006f: Expected F4, but got I4
			//IL_0097: Expected F4, but got I4
			//IL_00ca: Expected O, but got I4
			TemporaryCameraTransition component = playerCamera.GetComponent<TemporaryCameraTransition>();
			int force = 0;
			component.StartTransition((byte)force != 0);
			if ((long)_avatarOrbitCamera == 0)
			{
				ExecuteQueuedTasks();
				int cancelTasks = 0;
				PauseTasks((byte)cancelTasks != 0);
			}
			NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
			float z = Vector3.zero.z;
			Animator _003CAnimator_003Ek__BackingField = avatar.appearance.Animator;
			string runAnimFloat = _runAnimFloat;
			int num = 0;
			_003CAnimator_003Ek__BackingField.SetFloat(runAnimFloat, num);
			Animator _003CAnimator_003Ek__BackingField2 = avatar.appearance.Animator;
			string runTurnAnimFloat = _runTurnAnimFloat;
			int num2 = 0;
			_003CAnimator_003Ek__BackingField2.SetFloat(runTurnAnimFloat, num2);
			Animator _003CAnimator_003Ek__BackingField3 = avatar.appearance.Animator;
			string moveAnimBool = _moveAnimBool;
			int value = 0;
			_003CAnimator_003Ek__BackingField3.SetBool(moveAnimBool, (byte)value != 0);
			int num3 = 0;
			CurrentInteractible = (GameObject)num3;
			if (_shortcutsBlockedPendingRequests > 0)
			{
			}
			SystemRoot.Instance.PauseSystem<ToolPreviewSystem>();
		}

		[Cpp2IlInjected.Token(Token = "0x60038E8")]
		[Cpp2IlInjected.Address(RVA = "0x14C68D0", Offset = "0x14C52D0", VA = "0x1814C68D0", Slot = "7")]
		public unsafe override void OnSystemResume()
		{
			//Discarded unreachable code: IL_0181
			//IL_0070: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AvatarAppearance appearance = avatar.appearance;
			int animController = 0;
			appearance.SetAnimController((AvatarAppearance.AnimControllerType)animController).FireAndForgetTask();
			if (_shortcutsBlockedPendingRequests > num3)
			{
			}
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			TemporaryCameraTransition component = playerCamera.GetComponent<TemporaryCameraTransition>();
			RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = avatar.RelaxingBehaviour;
			if ((_003CRelaxingBehaviour_003Ek__BackingField.Relaxing ? 1 : 0) != num3)
			{
				RelaxingPosition _003CCurrentRelaxingPosition_003Ek__BackingField = _003CRelaxingBehaviour_003Ek__BackingField.CurrentRelaxingPosition;
				int num4 = 0;
				if (!(_003CCurrentRelaxingPosition_003Ek__BackingField == (UnityEngine.Object)num4))
				{
					goto IL_0167;
				}
			}
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment component2 = gameObject.GetComponent<Mdl.Environments.Environment>();
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num5 = 0;
			GridScript gridScript = default(GridScript);
			if (gridScript != (UnityEngine.Object)num5 && (IntPtr)gridScript.Grid != (IntPtr)num3)
			{
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				int allowInvalid = 0;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				uint stride = default(uint);
				GridPosition gridPosition = gridScript.GetGridPosition(in *(Vector3*)num, (int)stride, (byte)allowInvalid != 0);
				if (gridScript.GetLayersForPosition(in *(GridPosition*)num) != GridLayers.Blocking)
				{
					int agentTypeID = avatar.Agent.agentTypeID;
					NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
					int num6 = 0;
					int walkableMask = _003CAgent_003Ek__BackingField.walkableMask;
					if (gridScript.TryGetComponent<VillageArea>(out *(VillageArea*)num6))
					{
					}
					int num7 = 0;
					if (0 == 0)
					{
						Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
						Vector3 vector3 = default(Vector3);
						float z3 = vector3.z;
						bool flag = default(bool);
						if (!flag)
						{
							goto IL_0167;
						}
					}
					NavMeshAgent _003CAgent_003Ek__BackingField2 = avatar.Agent;
				}
			}
			goto IL_0167;
			IL_0167:
			if ((IntPtr)_avatarOrbitCamera == (IntPtr)num3)
			{
				ResumeTasks();
			}
			SystemRoot.Instance.ResumeSystem<ToolPreviewSystem>();
		}

		[Cpp2IlInjected.Token(Token = "0x60038E9")]
		[Cpp2IlInjected.Address(RVA = "0x14C5CD0", Offset = "0x14C46D0", VA = "0x1814C5CD0")]
		private void OnDestroy()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			CurrentInteractible = (GameObject)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60038EA")]
		[Cpp2IlInjected.Address(RVA = "0x14C5DB0", Offset = "0x14C47B0", VA = "0x1814C5DB0")]
		private unsafe void OnInteractTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0065
			bool _003CRelaxing_003Ek__BackingField = avatar.RelaxingBehaviour.Relaxing;
			if (ActiveControlSchemeType == ControlSchemeType.ThirdPerson)
			{
			}
			int num = 0;
			bool flag = Input.HasGameController();
			List<PlayerTask> taskQueue = _taskQueue;
			int maxTasksInQueue = _playerConfig.maxTasksInQueue;
			if (!_003CRelaxing_003Ek__BackingField && flag)
			{
				int num2 = 0;
				if (TryDoInteract() && _currentInteractible.TryGetItem(out *(Item*)num2) && !SystemRoot.TryGetSystem<MissionManager>(out *(MissionManager*)num2))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038EB")]
		[Cpp2IlInjected.Address(RVA = "0x14C8630", Offset = "0x14C7030", VA = "0x1814C8630")]
		private void OnUseToolTriggered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_006f
			//IL_003c: Expected O, but got I4
			PlayerAvatar playerAvatar = avatar;
			if (playerAvatar.Toolbox._currentToolType == Toolbox.ToolType.None || playerAvatar.RelaxingBehaviour.Relaxing)
			{
				return;
			}
			PlayerTask playerTask = Enumerable.FirstOrDefault<PlayerTask>((IEnumerable<>)_taskQueue);
			if ((object)playerTask == null)
			{
			}
			int num = 0;
			if (!(playerTask == (UnityEngine.Object)num))
			{
				if ((object)Enumerable.FirstOrDefault<PlayerTask>((IEnumerable<>)_taskQueue) != null)
				{
				}
				PlayerTask walkTask = _walkTask;
				if (!(walkTask == walkTask))
				{
					return;
				}
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60038EC")]
		[Cpp2IlInjected.Address(RVA = "0x14C60E0", Offset = "0x14C4AE0", VA = "0x1814C60E0")]
		private void OnSwitchToGridEditMode(object sender, EventArgs e)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038ED")]
		[Cpp2IlInjected.Address(RVA = "0x14C5F30", Offset = "0x14C4930", VA = "0x1814C5F30")]
		private void OnResetPlayerCamera(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			if (ControlScheme != null)
			{
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				int num = 0;
				float num2 = ControlSchemeConstants.DefaultResetAngle(_003Ctransform_003Ek__BackingField);
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038EE")]
		[Cpp2IlInjected.Address(RVA = "0x14C11E0", Offset = "0x14BFBE0", VA = "0x1814C11E0")]
		public void CancelAllTasks()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038EF")]
		[Cpp2IlInjected.Address(RVA = "0x14C8E00", Offset = "0x14C7800", VA = "0x1814C8E00")]
		public void PauseTasks(bool cancelTasks = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038F0")]
		[Cpp2IlInjected.Address(RVA = "0x14CB4C0", Offset = "0x14C9EC0", VA = "0x1814CB4C0")]
		public void ResumeTasks()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038F1")]
		[Cpp2IlInjected.Address(RVA = "0x14CE270", Offset = "0x14CCC70", VA = "0x1814CE270")]
		private void Update()
		{
			//IL_0025: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			//IL_01b1: Invalid comparison between F4 and I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			float deltaTime = Time.deltaTime;
			BaseHoldBehaviour currentHoldBehaviour = _currentHoldBehaviour;
			int num5 = 0;
			if (currentHoldBehaviour != (UnityEngine.Object)num5 && !_currentHoldBehaviour.DoUpdate(deltaTime))
			{
				int num6 = 0;
				CurrentHoldBehaviour = (BaseHoldBehaviour)num6;
			}
			if (_overrideAllRequest > num3)
			{
				InputAction.CancelAll(movementInputActions);
				InputAction.CancelAll(interactInputActions);
				InputAction.CancelAll(cameraInputActions);
				_move.Reset();
				_holdInPlace.Release();
			}
			bool flag = HasCameraTransition();
			ProfilerMarker profilerMarker2 = default(ProfilerMarker);
			int num9 = default(int);
			if (!flag)
			{
				IControlScheme controlScheme = ControlScheme;
				if (!flag)
				{
					HoldInPlaceGesture holdInPlace = _holdInPlace;
					if ((InputLocked ? 1 : 0) != num3)
					{
						holdInPlace.Release();
					}
					holdInPlace.Update(deltaTime);
					_swipe.Update(deltaTime);
					InputAction[] inputActions = cameraInputActions;
					InputAction.UpdateAll(deltaTime, inputActions);
					MoveGesture move = _move;
					if ((InputLocked ? 1 : 0) != num3)
					{
						move.Reset();
					}
					move.Update(deltaTime);
					ProfilerMarker profilerMarker = s_moveCamera;
					MoveCamera(deltaTime);
					uint num7 = default(uint);
					if (num7 != 0)
					{
						uint num8 = num7 - 1;
					}
					profilerMarker2 = s_moveAvatar;
					num9 = 0;
					bool flag2 = default(bool);
					if (!flag2)
					{
					}
				}
				uint num10 = default(uint);
				if (num9 < (int)num10)
				{
					num9 += num9;
					num9++;
				}
				num9 += 536;
			}
			if ((object)profilerMarker2 != null)
			{
				int num11 = 0;
				bool flag3 = default(bool);
				if (flag3)
				{
				}
			}
			if ((object)profilerMarker2 != null)
			{
				int num12 = 0;
				bool flag4 = default(bool);
				if (flag4)
				{
				}
			}
			ProfilerMarker profilerMarker3 = s_updateAnimator;
			if ((object)profilerMarker2 != null)
			{
			}
			int num13 = 0;
			int num14 = 0;
			float num18 = default(float);
			float num17 = default(float);
			if (num13 != 0)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float num15 = default(float);
				if (!(num15 <= deltaTime))
				{
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					int num16 = 0;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					num18 = num17;
				}
			}
			deltaTime = num18;
			num17 = deltaTime;
			if (!(num18 <= (float)num))
			{
			}
			ulong num19 = default(ulong);
			bool flag5 = default(bool);
			if (num19 == 0 || flag5 || !flag5)
			{
			}
			uint num20 = default(uint);
			if (num9 < (int)num20)
			{
				num9 += num9;
				num9++;
			}
			num9 += 552;
			int num21 = 0;
			int num22 = 0;
			bool flag6 = default(bool);
			if (!flag6)
			{
				int num23 = 0;
				if (!flag6)
				{
					return;
				}
				int num24 = 0;
				int num25 = 0;
			}
			int num26 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60038F2")]
		[Cpp2IlInjected.Address(RVA = "0x14C4F40", Offset = "0x14C3940", VA = "0x1814C4F40")]
		public void LateUpdate()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("VisualDebugAvatar")]
		private void DebugDrawUpdatedAvatarDirection(bool updated)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038F4")]
		[Cpp2IlInjected.Address(RVA = "0x14CB9A0", Offset = "0x14CA3A0", VA = "0x1814CB9A0")]
		public void TeleportAvatar(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason = PlayerAvatar.AvatarTeleportedReason.Movement, [System.Runtime.InteropServices.Optional] Quaternion? rotation)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038F5")]
		[Cpp2IlInjected.Address(RVA = "0x14CBC20", Offset = "0x14CA620", VA = "0x1814CBC20")]
		private float TeleportCameraBehaviorToAngle(TeleportCameraBehavior cameraBehavior, Transform avatarTransform)
		{
			return cameraBehavior switch
			{
				TeleportCameraBehavior.InFrontOfPlayer => ControlSchemeConstants.InFrontOfAvatarAngle(avatarTransform), 
				TeleportCameraBehavior.BehindPlayer => ControlSchemeConstants.BehindAvatarAngle(avatarTransform), 
				_ => ControlSchemeConstants.DefaultResetAngle(avatarTransform), 
			};
		}

		[Cpp2IlInjected.Token(Token = "0x60038F6")]
		[Cpp2IlInjected.Address(RVA = "0x14CBAC0", Offset = "0x14CA4C0", VA = "0x1814CBAC0")]
		public void TeleportAvatar(Vector3 position, bool cameraToFront, PlayerAvatar.AvatarTeleportedReason reason = PlayerAvatar.AvatarTeleportedReason.Movement)
		{
			//Discarded unreachable code: IL_0030
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			float z = position.z;
			int num3 = 0;
			if ((IntPtr)s_actuallyMoveAvatar != (IntPtr)num3 && !base.IsPaused)
			{
				PlayerAvatar playerAvatar = avatar;
				this.ResetCameraOnPlayer((Nullable<>)num3, (Nullable<>)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038F7")]
		[Cpp2IlInjected.Address(RVA = "0x14CB840", Offset = "0x14CA240", VA = "0x1814CB840")]
		public void TeleportAvatar(Vector3 position, TeleportCameraBehavior cameraBehavior, PlayerAvatar.AvatarTeleportedReason reason = PlayerAvatar.AvatarTeleportedReason.Movement)
		{
			//Discarded unreachable code: IL_0036
			//IL_0035: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			float z = position.z;
			int num3 = 0;
			if ((IntPtr)s_actuallyMoveAvatar != (IntPtr)num3 && !base.IsPaused)
			{
				PlayerAvatar playerAvatar = avatar;
				this.ResetCameraOnPlayer((Nullable<>)num3, (Nullable<>)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038F8")]
		[Cpp2IlInjected.Address(RVA = "0x14CB7A0", Offset = "0x14CA1A0", VA = "0x1814CB7A0")]
		public void SetControlScheme(ControlSchemeType controlScheme, bool firstTimeInit = false)
		{
			//Discarded unreachable code: IL_0029
			if ((ActiveControlSchemeType != controlScheme || firstTimeInit) && (object)_playerConfig != null)
			{
				SetControlSchemeInternal(controlScheme);
				_idleTime = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038F9")]
		[Cpp2IlInjected.Address(RVA = "0x14CB6D0", Offset = "0x14CA0D0", VA = "0x1814CB6D0")]
		private void SetControlSchemeInternal(ControlSchemeType newControlScheme)
		{
			//Discarded unreachable code: IL_004d
			//IL_002e: Expected I4, but got O
			IControlScheme controlScheme = ControlScheme;
			ActiveControlSchemeType = newControlScheme;
			IControlScheme controlScheme2 = ControlScheme;
			IControlScheme controlScheme3 = ControlScheme;
			_move._automaticRotation = (byte)(int)typeof(IControlScheme).TypeHandle != 0;
			ControlSchemeChanged onControlSchemeChanged = this.OnControlSchemeChanged;
			if (onControlSchemeChanged != null)
			{
				ControlSchemeType controlScheme4 = ActiveControlSchemeType;
				onControlSchemeChanged(controlScheme4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FA")]
		[Cpp2IlInjected.Address(RVA = "0x14CB7F0", Offset = "0x14CA1F0", VA = "0x1814CB7F0")]
		public void SetDefaultHookedControls(bool firstTimeInit = false)
		{
			//Discarded unreachable code: IL_0029
			ControlSchemeType defaultHookedControls = _playerConfig.defaultHookedControls;
			if ((ActiveControlSchemeType != defaultHookedControls || firstTimeInit) && firstTimeInit)
			{
				_idleTime = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FB")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA20", Offset = "0x14C9420", VA = "0x1814CAA20")]
		public void RecenterCameraOnPlayer(bool resetToDefault = false)
		{
			//IL_0069: Expected F4, but got I4
			//IL_00a5: Expected F4, but got I4
			if ((long)_orbitCameraOverride != 0 || (long)_avatarOrbitCamera != 0)
			{
				return;
			}
			if (!resetToDefault)
			{
				if (ActiveControlSchemeType != ControlSchemeType.FreeCameraControl)
				{
					return;
				}
				if (_playerConfig.allowSwitchingControls == resetToDefault)
				{
					Plane floorPlane = CameraUtil.FloorPlane;
					int num = 0;
					Transform _003Ctransform_003Ek__BackingField = avatar.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform transform = playerCameraTransform;
					int num2 = 0;
					return;
				}
				while (resetToDefault)
				{
				}
				int num3 = 0;
				_idleTime = num3;
			}
			int num4 = 0;
			PlayerNavigationConfig playerConfig = _playerConfig;
			ControlSchemeType defaultHookedControls = playerConfig.defaultHookedControls;
			while (ActiveControlSchemeType == defaultHookedControls)
			{
			}
			int num5 = 0;
			if ((playerConfig.allowSwitchingControls ? 1 : 0) != num5)
			{
				SetControlSchemeInternal(defaultHookedControls);
				_idleTime = num5;
			}
			Transform transform2 = playerCameraTransform;
			PlayerAvatar playerAvatar = avatar;
			Transform transform3 = playerCameraTransform;
			Transform navigationStartCamera = playerAvatar.navigationStartCamera;
			IControlScheme controlScheme = ControlScheme;
			uint num6 = default(uint);
			if (num5 < (int)num6)
			{
				num5 += num5;
				num5++;
			}
			Transform navigationStartCamera2 = avatar.navigationStartCamera;
			Transform transform4 = playerCameraTransform;
			Tween<Quaternion> cameraRotationTransition = _cameraRotationTransition;
			Tween<Quaternion>.UpdateEventHandler updateEventHandler = (Tween<Quaternion>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate
			{
				int num7 = 0;
				float deltaTime = Time.deltaTime;
				MoveCamera(deltaTime);
			};
			((Tween<T>)(object)cameraRotationTransition).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			cameraRotationTransition = (Tween<Quaternion>)(object)((object)cameraRotationTransition + (object)cameraRotationTransition);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038FC")]
		[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
		private IControlScheme GetActiveControlScheme()
		{
			return ControlScheme;
		}

		[Cpp2IlInjected.Token(Token = "0x60038FD")]
		[Cpp2IlInjected.Address(RVA = "0x14C4D30", Offset = "0x14C3730", VA = "0x1814C4D30")]
		public void InstantDefaultResetCameraOnPlayer()
		{
			//Discarded unreachable code: IL_0030
			//IL_001f: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			int num = 0;
			float num2 = ControlSchemeConstants.DefaultResetAngle(_003Ctransform_003Ek__BackingField);
			int num3 = 0;
			this.ResetCameraOnPlayer((Nullable<>)num3, (Nullable<>)num3);
			playerCamera.GetComponent<TemporaryCameraTransition>().ResetStartTransform();
		}

		[Cpp2IlInjected.Token(Token = "0x60038FE")]
		[Cpp2IlInjected.Address(RVA = "0x14CB090", Offset = "0x14C9A90", VA = "0x1814CB090")]
		public void ResetCameraOnPlayer([System.Runtime.InteropServices.Optional] float? offsetAngle, [System.Runtime.InteropServices.Optional] float? transitionDuration)
		{
			//Discarded unreachable code: IL_00c9
			//IL_00a7: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			if ((long)_orbitCameraOverride == 0)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				PlayerAvatar playerAvatar = avatar;
				Transform transform = playerCameraTransform;
				Transform navigationStartCamera = playerAvatar.navigationStartCamera;
				Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				PlayerAvatar playerAvatar2 = avatar;
				Transform transform2 = playerCameraTransform;
				Transform navigationStartCamera2 = playerAvatar2.navigationStartCamera;
				Quaternion rotation = _003Ctransform_003Ek__BackingField2.rotation;
				Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
				IControlScheme controlScheme = ControlScheme;
				int num = 0;
				IControlScheme controlScheme2 = ControlScheme;
				Tween<Vector3> cameraPositionTransition = _cameraPositionTransition;
				if (cameraPositionTransition != null)
				{
					int reverse = 0;
					((Tween<T>)(object)cameraPositionTransition).Cancel((byte)reverse != 0);
				}
				_cameraPositionTransition = (Tween<Vector3>)num;
				Tween<Quaternion> cameraRotationTransition = _cameraRotationTransition;
				if (cameraRotationTransition != null)
				{
					int reverse2 = 0;
					((Tween<T>)(object)cameraRotationTransition).Cancel((byte)reverse2 != 0);
				}
				_cameraRotationTransition = (Tween<Quaternion>)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FF")]
		[Cpp2IlInjected.Address(RVA = "0x14CB420", Offset = "0x14C9E20", VA = "0x1814CB420")]
		public void ResetCameraPosition([System.Runtime.InteropServices.Optional] float? offsetYaw, [System.Runtime.InteropServices.Optional] float? offsetPitch, [System.Runtime.InteropServices.Optional] float? transitionDuration)
		{
			IControlScheme controlScheme = ControlScheme;
			IControlScheme controlScheme2 = ControlScheme;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003900")]
		[Cpp2IlInjected.Address(RVA = "0x14C4710", Offset = "0x14C3110", VA = "0x1814C4710")]
		private bool HasCameraTransition()
		{
			//Discarded unreachable code: IL_0020
			bool isTransitionAnimating = playerCamera.GetComponent<TemporaryCameraTransition>().IsTransitionAnimating;
			if ((long)_cameraPositionTransition != 0)
			{
				return isTransitionAnimating;
			}
			return isTransitionAnimating;
		}

		[Cpp2IlInjected.Token(Token = "0x6003901")]
		[Cpp2IlInjected.Address(RVA = "0x14C4790", Offset = "0x14C3190", VA = "0x1814C4790")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_01da
			//IL_00c8: Expected O, but got I4
			//IL_0173: Expected F4, but got O
			ControlSchemeType defaultControls = _playerConfig.defaultControls;
			if (_defaultScheme != defaultControls)
			{
				_defaultScheme = defaultControls;
				ActiveControlSchemeType = defaultControls;
				SetControlSchemeInternal(defaultControls);
			}
			NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
			PlayerNavigationConfig playerConfig = _playerConfig;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			float speed = default(float);
			_003CAgent_003Ek__BackingField.speed = speed;
			PlayerAvatar playerAvatar = avatar;
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			NavMeshAgent _003CAgent_003Ek__BackingField2 = playerAvatar.Agent;
			float num = (_003CAgent_003Ek__BackingField2.acceleration = playerConfig2.acceleration);
			PlayerAvatar playerAvatar2 = avatar;
			PlayerNavigationConfig playerConfig3 = _playerConfig;
			NavMeshAgent _003CAgent_003Ek__BackingField3 = playerAvatar2.Agent;
			float num2 = (_003CAgent_003Ek__BackingField3.angularSpeed = playerConfig3.angularSpeed);
			PlayerTask walkTask = default(PlayerTask);
			if ((object)Enumerable.FirstOrDefault<PlayerTask>((IEnumerable<>)_taskQueue) == null)
			{
				walkTask = _walkTask;
			}
			int num3 = 0;
			if (walkTask == (UnityEngine.Object)num3)
			{
				PlayerAvatar playerAvatar3 = avatar;
				PlayerNavigationConfig playerConfig4 = _playerConfig;
				NavMeshAgent _003CAgent_003Ek__BackingField4 = playerAvatar3.Agent;
				bool flag2 = (_003CAgent_003Ek__BackingField4.updateRotation = !playerConfig4.manualAvatarRotation);
			}
			PlayerNavigationConfig playerConfig5 = _playerConfig;
			HoldInPlaceGesture holdInPlace = _holdInPlace;
			float num4 = (holdInPlace.MinDuration = playerConfig5.holdInPlaceDuration);
			PlayerNavigationConfig playerConfig6 = _playerConfig;
			HoldInPlaceGesture holdInPlace2 = _holdInPlace;
			float num5 = (holdInPlace2.DragTolerance = playerConfig6.holdInPlaceDragTolerance);
			_move.MaxForce = 1f;
			MoveGesture move = _move;
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			CameraNavigationConfig cameraConfig = sceneData.CameraConfig;
			move.Friction = (float)cameraConfig;
			PlayerNavigationConfig playerConfig7 = _playerConfig;
			MoveGesture move2 = _move;
			bool flag3 = (move2.AllowMoveWithTwoFingers = playerConfig7.allowMoveWithTwoFingers);
			PlayerNavigationConfig playerConfig8 = _playerConfig;
			SwipeGesture swipe = _swipe;
			float num6 = (swipe.MinDistance = playerConfig8.swipeMinDistance);
			PlayerNavigationConfig playerConfig9 = _playerConfig;
			SwipeGesture swipe2 = _swipe;
			float num7 = (swipe2.MinSpeed = playerConfig9.swipeMinSpeed);
		}

		[Cpp2IlInjected.Token(Token = "0x6003902")]
		[Cpp2IlInjected.Address(RVA = "0x14C14B0", Offset = "0x14BFEB0", VA = "0x1814C14B0")]
		public void CancelQueuedTask(PlayerTask task)
		{
			int pause = 0;
			CancelQueuedTask(task, (byte)pause != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003903")]
		[Cpp2IlInjected.Address(RVA = "0x14C14C0", Offset = "0x14BFEC0", VA = "0x1814C14C0")]
		private void CancelQueuedTask(PlayerTask task, bool pause)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003904")]
		[Cpp2IlInjected.Address(RVA = "0x14C9CC0", Offset = "0x14C86C0", VA = "0x1814C9CC0")]
		public Task<int> QueueTask(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, CancellationToken ct)
		{
			//IL_000a: Expected I4, but got I8
			ulong num = default(ulong);
			return (Task<int>)(object)this.QueueTask(definition, taskCollider, ct, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003905")]
		[Cpp2IlInjected.Address(RVA = "0x14C9CE0", Offset = "0x14C86E0", VA = "0x1814C9CE0")]
		[AsyncStateMachine(typeof(_003CQueueTask_003Ed__200))]
		private Task<int> QueueTask(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, CancellationToken ct, bool fromMultipleChoice)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003906")]
		[Cpp2IlInjected.Address(RVA = "0x14C9E60", Offset = "0x14C8860", VA = "0x1814C9E60")]
		public int QueueTask(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, params IPlayerTaskData[] taskData)
		{
			float z = Vector3.zero.z;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003907")]
		[Cpp2IlInjected.Address(RVA = "0x14C9F90", Offset = "0x14C8990", VA = "0x1814C9F90")]
		public int QueueTask(PlayerTaskDefinition definition, Vector3 destination, params IPlayerTaskData[] taskData)
		{
			float z = destination.z;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003908")]
		[Cpp2IlInjected.Address(RVA = "0x14C9EE0", Offset = "0x14C88E0", VA = "0x1814C9EE0")]
		public int QueueTask(PlayerTaskCollider taskCollider, Vector3 destination, params IPlayerTaskData[] taskData)
		{
			//Discarded unreachable code: IL_0016
			PlayerTaskDefinition playerTaskDefinition = Enumerable.First<PlayerTaskDefinition>(taskCollider.GetAllTasks());
			float z = destination.z;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003909")]
		[Cpp2IlInjected.Address(RVA = "0x14C93F0", Offset = "0x14C7DF0", VA = "0x1814C93F0")]
		public int QueueAutomaticTask(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, params IPlayerTaskData[] taskData)
		{
			float z = Vector3.zero.z;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600390A")]
		[Cpp2IlInjected.Address(RVA = "0x14C9470", Offset = "0x14C7E70", VA = "0x1814C9470")]
		private int QueueTask(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, Vector3 destination, bool automatic, params IPlayerTaskData[] taskData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600390B")]
		[Cpp2IlInjected.Address(RVA = "0x14CE080", Offset = "0x14CCA80", VA = "0x1814CE080")]
		private void UpdateCurrentHoldBehaviour()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600390C")]
		[Cpp2IlInjected.Address(RVA = "0x14C1780", Offset = "0x14C0180", VA = "0x1814C1780")]
		private PlayerTask CreateTask(PlayerTaskDefinition definition, PlayerTaskCollider taskCollider, Vector3 destination, int taskId, CancellationToken ct, params IPlayerTaskData[] taskData)
		{
			//Discarded unreachable code: IL_003a
			//IL_0010: Expected O, but got I4
			GameObject action = definition.Action;
			int num = 0;
			if (action != (UnityEngine.Object)num)
			{
			}
			GameObject defaultTaskAction = _defaultTaskAction;
			Transform parent = base.transform;
			PlayerTask component = UnityEngine.Object.Instantiate(defaultTaskAction, parent).GetComponent<PlayerTask>();
			float z = destination.z;
			return component;
		}

		[Cpp2IlInjected.Token(Token = "0x600390D")]
		[Cpp2IlInjected.Address(RVA = "0x14C0EC0", Offset = "0x14BF8C0", VA = "0x1814C0EC0")]
		[AsyncStateMachine(typeof(_003CAskPlayerToChooseTask_003Ed__208))]
		private Task AskPlayerToChooseTask(List<PlayerTaskDefinition> playerTasks, PlayerTaskCollider playerTaskCollider, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600390E")]
		[Cpp2IlInjected.Address(RVA = "0x14C1CE0", Offset = "0x14C06E0", VA = "0x1814C1CE0")]
		[AsyncStateMachine(typeof(_003CDisplayTaskInfo_003Ed__209))]
		private Task DisplayTaskInfo(GameObject target, CancellationToken ct, int taskID = -1)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600390F")]
		[Cpp2IlInjected.Address(RVA = "0x14C2B90", Offset = "0x14C1590", VA = "0x1814C2B90")]
		private void ExecuteWalkTask()
		{
			//Discarded unreachable code: IL_0033
			//IL_0010: Expected O, but got I4
			//IL_0032: Expected O, but got I8
			PlayerTask walkTask = _walkTask;
			int num = 0;
			if (walkTask != (UnityEngine.Object)num)
			{
				PlayerTask walkTask2 = _walkTask;
				if (walkTask2.Result == PlayerTaskResult.Completed)
				{
					walkTask2.DestroyTask();
					_walkTask = (PlayerTask)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003910")]
		[Cpp2IlInjected.Address(RVA = "0x14C2A10", Offset = "0x14C1410", VA = "0x1814C2A10")]
		private void ExecuteQueuedTasks()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003911")]
		[Cpp2IlInjected.Address(RVA = "0x14CDD40", Offset = "0x14CC740", VA = "0x1814CDD40")]
		private void UpdateControlBranching(float deltaTime)
		{
			float num3 = default(float);
			while (true)
			{
				int num = 0;
				if (ActiveControlSchemeType != ControlSchemeType.FreeCameraControl)
				{
					if (_playerConfig.allowMoveAxesInHookedMode)
					{
						if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
						{
							int num2 = 0;
							int touchCount = Input.touchCount;
						}
						if (!_move.TwoFingers)
						{
						}
						float switchModeMaxTouchTime = _playerConfig.switchModeMaxTouchTime;
						if (!_move.TwoFingers)
						{
							PlayerNavigationConfig playerConfig = _playerConfig;
							if (!(num3 <= playerConfig.switchModeDragSpeed) && ActiveControlSchemeType != ControlSchemeType.FreeCameraControl && playerConfig.allowSwitchingControls)
							{
								SetControlSchemeInternal(ControlSchemeType.FreeCameraControl);
								_idleTime = 0f;
							}
						}
						return;
					}
					if (!_swipe.IsTrue || _move.TwoFingers)
					{
						continue;
					}
				}
				if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
				{
					int num4 = 0;
					if (Input.touchCount == 0)
					{
						break;
					}
				}
			}
			List<PlayerTask> taskQueue = _taskQueue;
			NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			while ((object)_003CAgent_003Ek__BackingField != null)
			{
			}
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			_idleTime = deltaTime;
			if (!(deltaTime >= playerConfig2.idleTimeToSwitch))
			{
				List<PlayerTask> taskQueue2 = _taskQueue;
			}
			ControlSchemeType defaultHookedControls = playerConfig2.defaultHookedControls;
			while (ActiveControlSchemeType == defaultHookedControls)
			{
			}
			while (!playerConfig2.allowSwitchingControls)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003912")]
		[Cpp2IlInjected.Address(RVA = "0x14C5460", Offset = "0x14C3E60", VA = "0x1814C5460")]
		private void MoveCharacter(float deltaTime)
		{
			//Discarded unreachable code: IL_00a2
			//IL_0050: Expected O, but got I4
			int num = 0;
			CallOnce callOnce = resetInitialConfig;
			Action action = delegate
			{
				//Discarded unreachable code: IL_0029
				IControlScheme controlScheme = ControlScheme;
				IControlScheme controlScheme2 = ControlScheme;
				ControlSchemeChanged onControlSchemeChanged = this.OnControlSchemeChanged;
				if (onControlSchemeChanged != null)
				{
					ControlSchemeType controlScheme3 = ActiveControlSchemeType;
					onControlSchemeChanged(controlScheme3);
				}
			};
			callOnce.InvokeOnce(action);
			if ((IntPtr)_avatarOrbitCamera != (IntPtr)num)
			{
				return;
			}
			if (ActiveControlSchemeType != ControlSchemeType.ThirdPerson)
			{
				int num2 = 0;
				if (!Input.HasGameController())
				{
					goto IL_0070;
				}
			}
			BaseHoldBehaviour currentHoldBehaviour = _currentHoldBehaviour;
			int num3 = 0;
			int num4 = default(int);
			if (currentHoldBehaviour == (UnityEngine.Object)num3)
			{
				ProfilerMarker profilerMarker = s_getInteractable;
				GameObject gameObject = (CurrentInteractible = GetInteractibleObject());
				num4 = 0;
				int num5 = 0;
			}
			goto IL_0070;
			IL_0070:
			Vector3 vector = default(Vector3);
			float z = vector.z;
			ProfilerMarker profilerMarker2 = s_actuallyMoveAvatar;
			uint num6 = default(uint);
			if (num4 < (int)num6)
			{
				num4 += num4;
				num4++;
			}
			action += action;
			num4 += 456;
		}

		[Cpp2IlInjected.Token(Token = "0x6003913")]
		[Cpp2IlInjected.Address(RVA = "0x14C1010", Offset = "0x14BFA10", VA = "0x1814C1010")]
		private bool AvatarHasCurrentTool()
		{
			Toolbox _003CToolbox_003Ek__BackingField = avatar.Toolbox;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003914")]
		[Cpp2IlInjected.Address(RVA = "0x14C16D0", Offset = "0x14C00D0", VA = "0x1814C16D0")]
		private void CheckForEditMode()
		{
			do
			{
				if (ActiveControlSchemeType > ControlSchemeType.FreeCameraControl || !_playerConfig.allowMoveAxesInHookedMode)
				{
					if (!_move.TwoFingers && _holdInPlace.IsValid)
					{
						RaycastForEditMode();
						return;
					}
					continue;
				}
				return;
			}
			while (_holdInPlace.IsValid);
			while ((object)this == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003915")]
		[Cpp2IlInjected.Address(RVA = "0x14CA2B0", Offset = "0x14C8CB0", VA = "0x1814CA2B0")]
		private void RaycastForEditMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003916")]
		[Cpp2IlInjected.Address(RVA = "0x14C4E80", Offset = "0x14C3880", VA = "0x1814C4E80")]
		private unsafe void Interact()
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			if (TryDoInteract() && _currentInteractible.TryGetItem(out *(Item*)num) && !SystemRoot.TryGetSystem<MissionManager>(out *(MissionManager*)num))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003917")]
		[Cpp2IlInjected.Address(RVA = "0x14CBCE0", Offset = "0x14CA6E0", VA = "0x1814CBCE0")]
		private bool TryDoInteract()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003918")]
		[Cpp2IlInjected.Address(RVA = "0x14C34E0", Offset = "0x14C1EE0", VA = "0x1814C34E0")]
		private unsafe GameObject GetInteractibleObject()
		{
			//Discarded unreachable code: IL_0260, IL_0266, IL_026c, IL_0272, IL_0278, IL_0290, IL_0296, IL_029c, IL_02a2, IL_02a8, IL_02ae, IL_02b4, IL_02ba, IL_02c0, IL_02cc, IL_02d2, IL_02d8, IL_02de, IL_02e4, IL_02ea, IL_02f0, IL_02f6, IL_02fc, IL_0302, IL_0308, IL_030e, IL_031a
			//IL_01b3: Expected O, but got I4
			//IL_01fa: Invalid comparison between I4 and F4
			//IL_0223: Invalid comparison between I4 and F4
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			bool flag = default(bool);
			Vector3 vector3 = default(Vector3);
			Vector3 vector4 = default(Vector3);
			bool flag2 = default(bool);
			OrderingValueComparer orderingValueComparer = default(OrderingValueComparer);
			int num7 = default(int);
			GameObject gameObject = default(GameObject);
			bool flag3 = default(bool);
			int num8 = default(int);
			int num10 = default(int);
			NonAllocSelectEnumerator<CharacterManager.CharacterInstance, Mdl.Characters.Character, NonAllocWhereEnumerator<CharacterManager.CharacterInstance, List<CharacterManager.CharacterInstance>.Enumerator>> nonAllocSelectEnumerator = default(NonAllocSelectEnumerator<CharacterManager.CharacterInstance, Mdl.Characters.Character, NonAllocWhereEnumerator<CharacterManager.CharacterInstance, List<CharacterManager.CharacterInstance>.Enumerator>>);
			bool flag4 = default(bool);
			GameObject _003CgameObject_003Ek__BackingField = default(GameObject);
			Mdl.Characters.Character character = default(Mdl.Characters.Character);
			Vector3 vector5 = default(Vector3);
			Vector3 vector6 = default(Vector3);
			Vector3 vector7 = default(Vector3);
			Vector3 vector8 = default(Vector3);
			float num12 = default(float);
			float num13 = default(float);
			Vector3 vector9 = default(Vector3);
			Vector3 vector10 = default(Vector3);
			float num14 = default(float);
			Vector3 vector11 = default(Vector3);
			Vector3 vector12 = default(Vector3);
			bool flag5 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				float z = vector.z;
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				PlayerNavigationConfig playerConfig = _playerConfig;
				float z2 = vector2.z;
				float z3 = Vector3.up.z;
				ProfilerMarker profilerMarker = s_int_priorityOverrides;
				List<(GameObject, float)> list = interactibleObjectsPriorityOverrides;
				if (flag)
				{
					Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
					float z4 = vector3.z;
					float z5 = vector4.z;
					float num5 = MathExtensions.HorizontalDistanceSq(in *(Vector3*)num3, in *(Vector3*)num3);
					while (!flag2)
					{
					}
					num2++;
				}
				num2++;
				if (num2 == 0)
				{
					if (num2 != 0)
					{
					}
					int num6 = 0;
					if (num2 == 0)
					{
						if (num2 == 0 || (long)profilerMarker != 966)
						{
							orderingValueComparer.UpdateOriginPosition();
							ProfilerMarker profilerMarker2 = s_int_overlapItems;
							string[] array = new string[1];
							if ("Player" != null && "Player" == null)
							{
								goto IL_0284;
							}
							array[0] = "Player";
							int mask = LayerMask.GetMask(array);
							string[] array2 = new string[1];
							if ("Ground" != null && array2 == null)
							{
								throw new IndexOutOfRangeException();
							}
							array2[0] = "Ground";
							int mask2 = LayerMask.GetMask(array2);
							if (num6 < num7)
							{
								if (!gameObject.GetOrAddComponent<InteractionComponentCache>().isCharacter && flag3)
								{
									num8++;
								}
								num6++;
							}
							num8++;
							int num9 = 0;
							if (num2 != 0)
							{
								throw new NullReferenceException();
							}
							if (num8 != 0)
							{
								num10 = num8 - 1;
								if ((long)profilerMarker2 == 966)
								{
									goto IL_0257;
								}
							}
							ProfilerMarker profilerMarker3 = s_int_overlapCharacters;
							Func<, > func = (Func<, >)(object)((NonAllocSelectEnumerator<, , >*)(&nonAllocSelectEnumerator))->func;
							if (flag4)
							{
								_003CgameObject_003Ek__BackingField = character.gameObject;
								InteractionComponentCache orAddComponent = _003CgameObject_003Ek__BackingField.GetOrAddComponent<InteractionComponentCache>();
								Collider _003Ccollider_003Ek__BackingField = orAddComponent.collider;
								int num11 = 0;
								if (_003Ccollider_003Ek__BackingField == (UnityEngine.Object)num11)
								{
									continue;
								}
								float z6 = vector5.z;
								float z7 = vector6.z;
								float z8 = vector7.z;
								float z9 = vector8.z;
								z2 = num12;
								z2 = num13;
								float z10 = vector9.z;
								float z11 = vector10.z;
								while ((float)num4 <= num14)
								{
								}
								Transform transform = _003CgameObject_003Ek__BackingField.transform;
								float z12 = vector11.z;
								float z13 = vector12.z;
								float num15 = MathExtensions.HorizontalDistanceSq(in *(Vector3*)num3, in *(Vector3*)num3);
								while ((float)num4 <= num15)
								{
								}
								Collider _003Ccollider_003Ek__BackingField2 = orAddComponent.collider;
								while (!flag5)
								{
								}
								num10++;
							}
							num10++;
							if (num2 != 0)
							{
								break;
							}
							if (num10 != 0)
							{
							}
							if (num2 != 0)
							{
								continue;
							}
							if (num10 == 0)
							{
								throw new NullReferenceException();
							}
						}
						goto IL_0257;
					}
					goto IL_0284;
				}
				throw new NullReferenceException();
				IL_0257:
				return _003CgameObject_003Ek__BackingField;
				IL_0284:
				throw new IndexOutOfRangeException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600391A")]
		[Cpp2IlInjected.Address(RVA = "0x14C9FD0", Offset = "0x14C89D0", VA = "0x1814C9FD0")]
		public void QueueWalkTask(Vector3 position, bool automatic)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600391B")]
		[Cpp2IlInjected.Address(RVA = "0x14C5170", Offset = "0x14C3B70", VA = "0x1814C5170")]
		private void MoveCamera(float deltaTime)
		{
			//Discarded unreachable code: IL_00c2
			//IL_0068: Invalid comparison between I4 and F4
			//IL_00c1: Expected I4, but got O
			int num = 0;
			if ((long)_avatarOrbitCamera == 0)
			{
				OrbitCamera orbitCamera = _orbitCameraOverride;
				if (orbitCamera == null)
				{
					if (ControlScheme == null)
					{
						goto IL_00b1;
					}
					bool flag = (long)_overrideAllRequest > (long)(IntPtr)orbitCamera;
					InputAction inputAction = inputCameraZoom;
					uint num2 = default(uint);
					if ((long)(IntPtr)orbitCamera < (long)(int)num2)
					{
						orbitCamera = (OrbitCamera)(object)((object)orbitCamera + (object)orbitCamera);
					}
				}
				MoveGesture move = _move;
				orbitCamera.Move(deltaTime, move);
			}
			if (!HasCameraTransition())
			{
				MoveGesture move2 = _move;
				if (!((float)num > move2.DeltaScale))
				{
					_avatarOrbitCamera.Move(deltaTime, move2);
				}
				float z = _cameraPositionBeforeZoom.z;
				float z2 = _cameraRotationBeforeZoom.z;
				Tween<Quaternion> cameraRotationTransition = _cameraRotationTransition;
				Tween<Quaternion>.FinishEventHandler finishEventHandler = (Tween<Quaternion>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(ExitAvatarViewMode);
				((Tween<T>)(object)cameraRotationTransition).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			}
			goto IL_00b1;
			IL_00b1:
			MoveGesture move3 = _move;
			_wasUnzooming = (byte)(int)move3 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600391C")]
		[Cpp2IlInjected.Address(RVA = "0x14C2C40", Offset = "0x14C1640", VA = "0x1814C2C40")]
		private void ExitAvatarViewMode()
		{
			//Discarded unreachable code: IL_0024
			IControlScheme controlScheme = ControlScheme;
			_move.Reset();
			ResumeTasks();
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x600391D")]
		[Cpp2IlInjected.Address(RVA = "0x14C24A0", Offset = "0x14C0EA0", VA = "0x1814C24A0")]
		private void DoCameraRotationTransition(Vector3 desiredAngle, float duration)
		{
			float z = desiredAngle.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600391E")]
		[Cpp2IlInjected.Address(RVA = "0x14C2180", Offset = "0x14C0B80", VA = "0x1814C2180")]
		private unsafe void DoCameraRotationTransition(Quaternion desiredAngle, float duration)
		{
			//Discarded unreachable code: IL_006d
			//IL_001e: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			if ((object)typeof(Tween<Quaternion>.UpdateEventHandler).TypeHandle != null)
			{
				int num = 0;
			}
			Transform transform = playerCameraTransform;
			int num2 = default(int);
			Tween<Quaternion>.InterpolationFunction interpolationFunction = (Tween<Quaternion>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Quaternion, Quaternion, float, Quaternion>*/)(&Quaternion.Slerp));
			num2 = 0;
			int num3 = default(int);
			EasingFunction easingFunction = new EasingFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num3 = 0;
			Tween<Quaternion> cameraRotationTransition = default(Tween<Quaternion>);
			_cameraRotationTransition = cameraRotationTransition;
			OnStartCameraTransition();
			Tween<Quaternion>.UpdateEventHandler updateEventHandler = (Tween<Quaternion>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateCameraRotation);
			Tween<Quaternion>.FinishEventHandler finishEventHandler = (Tween<Quaternion>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnEndCameraTransition);
			Tween<Quaternion>.CancelEventHandler cancelEventHandler = (Tween<Quaternion>.CancelEventHandler)(object)(Tween<T>.CancelEventHandler)delegate
			{
				OnEndCameraTransition();
			};
		}

		[Cpp2IlInjected.Token(Token = "0x600391F")]
		[Cpp2IlInjected.Address(RVA = "0x14C1E30", Offset = "0x14C0830", VA = "0x1814C1E30")]
		private unsafe void DoCameraPositionTransition(Vector3 desiredPosition, float duration)
		{
			//Discarded unreachable code: IL_0075
			//IL_001d: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			int num = 0;
			Transform transform = playerCameraTransform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num2 = default(int);
			Tween<Vector3>.InterpolationFunction interpolationFunction = (Tween<Vector3>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, Vector3, float, Vector3>*/)(&Vector3.Lerp));
			num2 = 0;
			int num3 = default(int);
			EasingFunction easingFunction = new EasingFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num3 = 0;
			float z2 = desiredPosition.z;
			Tween<Vector3> cameraPositionTransition = default(Tween<Vector3>);
			_cameraPositionTransition = cameraPositionTransition;
			OnStartCameraTransition();
			Tween<Vector3>.UpdateEventHandler updateEventHandler = (Tween<Vector3>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateCameraPosition);
			Tween<Vector3>.FinishEventHandler finishEventHandler = (Tween<Vector3>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnEndCameraTransition);
			Tween<Vector3>.CancelEventHandler cancelEventHandler = (Tween<Vector3>.CancelEventHandler)(object)(Tween<T>.CancelEventHandler)delegate
			{
				OnEndCameraTransition();
			};
		}

		[Cpp2IlInjected.Token(Token = "0x6003920")]
		[Cpp2IlInjected.Address(RVA = "0x14C6040", Offset = "0x14C4A40", VA = "0x1814C6040")]
		private void OnStartCameraTransition()
		{
			//Discarded unreachable code: IL_0027
			//IL_0024: Expected O, but got I4
			int shortcutsBlockedPendingRequests = _shortcutsBlockedPendingRequests;
			shortcutsBlockedPendingRequests++;
			int num = (_shortcutsBlockedPendingRequests = Mathf.Max(0, shortcutsBlockedPendingRequests));
			if (num == 1)
			{
				bool autoSkip = ((IFluxStatement)num).AutoSkip;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003921")]
		[Cpp2IlInjected.Address(RVA = "0x14C5CE0", Offset = "0x14C46E0", VA = "0x1814C5CE0")]
		private void OnEndCameraTransition()
		{
			//Discarded unreachable code: IL_0021
			int shortcutsBlockedPendingRequests = _shortcutsBlockedPendingRequests;
			if ((_shortcutsBlockedPendingRequests = Mathf.Max(0, shortcutsBlockedPendingRequests)) == 0)
			{
			}
			GraphicSettings.ToggleGroundCullingDistance(turnOff: false);
		}

		[Cpp2IlInjected.Token(Token = "0x6003922")]
		[Cpp2IlInjected.Address(RVA = "0x14C1400", Offset = "0x14BFE00", VA = "0x1814C1400")]
		public void CancelCameraTransition()
		{
			//IL_001d: Expected O, but got I8
			//IL_003a: Expected O, but got I8
			Tween<Vector3> cameraPositionTransition = _cameraPositionTransition;
			if (cameraPositionTransition != null)
			{
				int reverse = 0;
				((Tween<T>)(object)cameraPositionTransition).Cancel((byte)reverse != 0);
			}
			_cameraPositionTransition = (Tween<Vector3>)0;
			Tween<Quaternion> cameraRotationTransition = _cameraRotationTransition;
			if (cameraRotationTransition != null)
			{
				int reverse2 = 0;
				((Tween<T>)(object)cameraRotationTransition).Cancel((byte)reverse2 != 0);
			}
			_cameraRotationTransition = (Tween<Quaternion>)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003923")]
		[Cpp2IlInjected.Address(RVA = "0x14CDD10", Offset = "0x14CC710", VA = "0x1814CDD10")]
		private void UpdateCameraRotation(Quaternion rotation, float progress)
		{
			//Discarded unreachable code: IL_0008
			Transform transform = playerCameraTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003924")]
		[Cpp2IlInjected.Address(RVA = "0x14CDCD0", Offset = "0x14CC6D0", VA = "0x1814CDCD0")]
		private void UpdateCameraPosition(Vector3 position, float progress)
		{
			//Discarded unreachable code: IL_000f
			Transform transform = playerCameraTransform;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003925")]
		[Cpp2IlInjected.Address(RVA = "0x14C57F0", Offset = "0x14C41F0", VA = "0x1814C57F0")]
		private unsafe void OnCurrentSceneChanged(SceneData scene)
		{
			//IL_001c: Expected O, but got I4
			//IL_0063: Expected I4, but got I8
			//IL_0063: Expected O, but got I4
			//IL_008a: Expected native int or pointer, but got O
			//IL_00c4: Expected O, but got I4
			//IL_011b: Expected F4, but got I4
			int handle = ((SceneData*)scene)->scene.m_Handle;
			GameObject gameObject = default(GameObject);
			OrbitCameraTarget componentInChildren = gameObject.GetComponentInChildren<OrbitCameraTarget>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				Transform transform = playerCameraTransform;
				Transform startCamera = componentInChildren.startCamera;
				Transform lookAt = componentInChildren.lookAt;
				Camera camera = playerCamera;
				int num2 = 0;
				Vector3 position = transform.position;
				OrbitCameraConfig cameraConfig = componentInChildren.cameraConfig;
				ulong num3 = default(ulong);
				OrbitCamera orbitCameraOverride = new OrbitCamera(camera, (Vector3)num2, cameraConfig, (byte)num3 != 0);
				int num4 = 0;
				_orbitCameraOverride = orbitCameraOverride;
				OrbitCamera orbitCameraOverride2 = _orbitCameraOverride;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)orbitCameraOverride2.YawForward)->z = z;
				Transform startCamera2 = componentInChildren.startCamera;
				OrbitCamera orbitCameraOverride3 = _orbitCameraOverride;
				Transform startCamera3 = componentInChildren.startCamera;
				Transform lookAt2 = componentInChildren.lookAt;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				return;
			}
			int num5 = 0;
			_orbitCameraOverride = (OrbitCamera)num5;
			PlayerAvatar playerAvatar = avatar;
			IControlScheme controlScheme = ControlScheme;
			Transform navigationStartCamera = playerAvatar.navigationStartCamera;
			PlayerNavigationConfig playerConfig = _playerConfig;
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			ControlSchemeType defaultHookedControls = playerConfig2.defaultHookedControls;
			if (ActiveControlSchemeType != defaultHookedControls && (playerConfig2.allowSwitchingControls ? 1 : 0) != num5)
			{
				SetControlSchemeInternal(defaultHookedControls);
				_idleTime = num5;
			}
			PlayerAvatar playerAvatar2 = avatar;
			IControlScheme controlScheme2 = ControlScheme;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar2.transform;
			int num6 = 0;
			float num7 = ControlSchemeConstants.DefaultResetAngle(_003Ctransform_003Ek__BackingField);
			float instantTransitionTime = ControlSchemeConstants.InstantTransitionTime;
			NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
			PlayerNavigationConfig playerConfig3 = _playerConfig;
			float num8 = default(float);
			instantTransitionTime = (_003CAgent_003Ek__BackingField.speed = num8);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003926")]
		[Cpp2IlInjected.Address(RVA = "0x14C2680", Offset = "0x14C1080", VA = "0x1814C2680")]
		public void EnterRealmShortcut(WorldData.Types.World realm)
		{
			//Discarded unreachable code: IL_005f
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if (realm.CanEnter(profile))
			{
				int sceneId_ = realm.sceneId_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)sceneId_);
				SceneItemData sceneItemData2 = default(SceneItemData);
				SceneItemData sceneItemData = sceneItemData2;
				if ((long)sceneItemData != 0)
				{
					EnterSceneItem().FireAndForgetTask();
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6003980")]
			[Cpp2IlInjected.Address(RVA = "0x16A44E0", Offset = "0x16A2EE0", VA = "0x1816A44E0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass251_0._003C_003CEnterSceneItem_003Eg__EnterSceneItem_007C0_003Ed))]
			Task EnterSceneItem()
			{
				int num2 = 0;
				int num3 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003927")]
		[Cpp2IlInjected.Address(RVA = "0x14C2920", Offset = "0x14C1320", VA = "0x1814C2920")]
		public void EnterSceneItem(SceneItemData sceneItemData, [System.Runtime.InteropServices.Optional] ItemScript itemScript)
		{
			//Discarded unreachable code: IL_0032
			if ((long)sceneItemData != 0)
			{
				EnterSceneItem().FireAndForgetTask();
			}
			[Cpp2IlInjected.Token(Token = "0x6003980")]
			[Cpp2IlInjected.Address(RVA = "0x16A44E0", Offset = "0x16A2EE0", VA = "0x1816A44E0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass251_0._003C_003CEnterSceneItem_003Eg__EnterSceneItem_007C0_003Ed))]
			Task EnterSceneItem()
			{
				int num = 0;
				int num2 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003928")]
		[Cpp2IlInjected.Address(RVA = "0x14CF030", Offset = "0x14CDA30", VA = "0x1814CF030")]
		public void UseFastTravel(FastTravelDestination destination)
		{
			//Discarded unreachable code: IL_002d
			FastTravelDestination fastTravelDestination = destination;
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				UseFastTravelAsync().FireAndForgetTask();
			}
			[Cpp2IlInjected.Token(Token = "0x6003984")]
			[Cpp2IlInjected.Address(RVA = "0x16A45F0", Offset = "0x16A2FF0", VA = "0x1816A45F0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass252_0._003C_003CUseFastTravel_003Eg__UseFastTravelAsync_007C0_003Ed))]
			Task UseFastTravelAsync()
			{
				int num2 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003929")]
		[Cpp2IlInjected.Address(RVA = "0x14C8B60", Offset = "0x14C7560", VA = "0x1814C8B60")]
		public TemporaryOverrideScope OverrideControlMaps(bool forceImmediateStop, params int[] newActiveMaps)
		{
			Action action = delegate
			{
				//Discarded unreachable code: IL_0036
				int num3 = 0;
				InputProvider inputProvider3 = DefaultInputProvider.Get();
				int[] inputMapCategories2 = InputMapCategories;
				inputProvider3.DisableMaps(inputMapCategories2);
				int num4 = 0;
				InputProvider inputProvider4 = DefaultInputProvider.Get();
				int[] maps2 = newActiveMaps;
				inputProvider4.EnableMaps(maps2);
			};
			Action action2 = delegate
			{
				//Discarded unreachable code: IL_0036
				int num = 0;
				InputProvider inputProvider = DefaultInputProvider.Get();
				int[] maps = newActiveMaps;
				inputProvider.DisableMaps(maps);
				int num2 = 0;
				InputProvider inputProvider2 = DefaultInputProvider.Get();
				int[] inputMapCategories = InputMapCategories;
				inputProvider2.EnableMaps(inputMapCategories);
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600392A")]
		[Cpp2IlInjected.Address(RVA = "0x14C88D0", Offset = "0x14C72D0", VA = "0x1814C88D0")]
		public TemporaryOverrideScope OverrideAllScope(bool forceImmediateStop = true)
		{
			Action action = delegate
			{
				//Discarded unreachable code: IL_0016
				PlayerNavigation playerNavigation = this;
				bool forceImmediateStop2 = forceImmediateStop;
				playerNavigation.BeginTemporaryOverrideAll(forceImmediateStop2);
			};
			Action action2 = EndTemporaryOverrideAll;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600392B")]
		[Cpp2IlInjected.Address(RVA = "0x14C10D0", Offset = "0x14BFAD0", VA = "0x1814C10D0")]
		public void BeginTemporaryOverrideAll(bool forceImmediateStop = true)
		{
			//Discarded unreachable code: IL_0061
			int overrideAllRequest = _overrideAllRequest;
			overrideAllRequest++;
			int num = Mathf.Max(0, overrideAllRequest);
			ControlChanged onControlChanged = this.OnControlChanged;
			_overrideAllRequest = num;
			if (onControlChanged != null)
			{
				bool overriden = num > 0;
				onControlChanged(overriden);
			}
			if (forceImmediateStop)
			{
				NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
				float z = Vector3.zero.z;
			}
			if (_overrideAllRequest == 1 && _shortcutsBlockedPendingRequests <= 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600392C")]
		[Cpp2IlInjected.Address(RVA = "0x14C25C0", Offset = "0x14C0FC0", VA = "0x1814C25C0")]
		public void EndTemporaryOverrideAll()
		{
			//Discarded unreachable code: IL_0049
			//IL_0045: Expected O, but got I4
			int overrideAllRequest = _overrideAllRequest;
			int num = Mathf.Max(0, overrideAllRequest);
			ControlChanged onControlChanged = this.OnControlChanged;
			_overrideAllRequest = num;
			if (onControlChanged != null)
			{
				bool overriden = num > 0;
				onControlChanged(overriden);
			}
			if (_overrideAllRequest == 0 && _shortcutsBlockedPendingRequests > 0)
			{
				bool autoSkip = ((IFluxStatement)num).AutoSkip;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600392D")]
		[Cpp2IlInjected.Address(RVA = "0x14C89E0", Offset = "0x14C73E0", VA = "0x1814C89E0")]
		public TemporaryOverrideScope OverrideAnimator(bool forceImmediateStop = true)
		{
			Action action = BeginAnimatorOverride;
			Action action2 = EndAnimatorOverride;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600392E")]
		[Cpp2IlInjected.Address(RVA = "0x14C1040", Offset = "0x14BFA40", VA = "0x1814C1040")]
		public void BeginAnimatorOverride()
		{
			int overrideAnimatorRequest = _overrideAnimatorRequest;
			overrideAnimatorRequest++;
			int num = (_overrideAnimatorRequest = Mathf.Max(0, overrideAnimatorRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x600392F")]
		[Cpp2IlInjected.Address(RVA = "0x14C2500", Offset = "0x14C0F00", VA = "0x1814C2500")]
		public void EndAnimatorOverride()
		{
			int overrideAnimatorRequest = _overrideAnimatorRequest;
			int num = (_overrideAnimatorRequest = Mathf.Max(0, overrideAnimatorRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x6003930")]
		[Cpp2IlInjected.Address(RVA = "0x14C8AA0", Offset = "0x14C74A0", VA = "0x1814C8AA0")]
		public TemporaryOverrideScope OverrideCameraScope()
		{
			Action action = BeginTemporaryCameraOverride;
			Action action2 = EndTemporaryCameraOverride;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003931")]
		[Cpp2IlInjected.Address(RVA = "0x14C1070", Offset = "0x14BFA70", VA = "0x1814C1070")]
		public void BeginTemporaryCameraOverride()
		{
			int cameraOverrideRequest = _cameraOverrideRequest;
			cameraOverrideRequest++;
			int num = (_cameraOverrideRequest = Mathf.Max(0, cameraOverrideRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x6003932")]
		[Cpp2IlInjected.Address(RVA = "0x14C2530", Offset = "0x14C0F30", VA = "0x1814C2530")]
		public void EndTemporaryCameraOverride()
		{
			int cameraOverrideRequest = _cameraOverrideRequest;
			int a = 0;
			int b = cameraOverrideRequest - 1;
			bool flag = (_cameraOverrideRequest = Mathf.Max(a, b)) > 0;
			if (cameraOverrideRequest > 0 != flag)
			{
				this.OnCameraOverrideChanged?.Invoke(flag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003933")]
		[Cpp2IlInjected.Address(RVA = "0x14C8C80", Offset = "0x14C7680", VA = "0x1814C8C80")]
		public TemporaryOverrideScope OverrideControlsScope()
		{
			Action action = BeginTemporaryControlsOverride;
			Action action2 = EndTemporaryControlsOverride;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003934")]
		[Cpp2IlInjected.Address(RVA = "0x14C10A0", Offset = "0x14BFAA0", VA = "0x1814C10A0")]
		public void BeginTemporaryControlsOverride()
		{
			int controlsOverrideRequest = _controlsOverrideRequest;
			controlsOverrideRequest++;
			int num = (_controlsOverrideRequest = Mathf.Max(0, controlsOverrideRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x6003935")]
		[Cpp2IlInjected.Address(RVA = "0x14C2590", Offset = "0x14C0F90", VA = "0x1814C2590")]
		public void EndTemporaryControlsOverride()
		{
			int controlsOverrideRequest = _controlsOverrideRequest;
			int num = (_controlsOverrideRequest = Mathf.Max(0, controlsOverrideRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x6003936")]
		[Cpp2IlInjected.Address(RVA = "0x14C8D40", Offset = "0x14C7740", VA = "0x1814C8D40")]
		public TemporaryOverrideScope OverrideDirectionUpdate()
		{
			Action action = delegate
			{
				int directionOverrideRequest2 = _directionOverrideRequest;
				directionOverrideRequest2++;
				int num2 = (_directionOverrideRequest = Mathf.Max(0, directionOverrideRequest2));
			};
			Action action2 = delegate
			{
				int directionOverrideRequest = _directionOverrideRequest;
				int num = (_directionOverrideRequest = Mathf.Max(0, directionOverrideRequest));
			};
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003937")]
		[Cpp2IlInjected.Address(RVA = "0x14C2D60", Offset = "0x14C1760", VA = "0x1814C2D60")]
		public (Vector3, Quaternion) GetDesiredCameraPosition()
		{
			//IL_0019: Expected I4, but got O
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			base.IsStarted = (byte)(int)typeof(IControlScheme).TypeHandle != 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003938")]
		[Cpp2IlInjected.Address(RVA = "0x14C1910", Offset = "0x14C0310", VA = "0x1814C1910")]
		public void DebugTraceInfo()
		{
			//IL_0023: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			object[] args = Array.Empty<object>();
			GameLog.Info("*** PlayerNavigation DebugTraceInfo ***", args);
			int cameraOverrideRequest = _cameraOverrideRequest;
			string msg = $"_cameraOverrideRequest={cameraOverrideRequest}";
			object[] args2 = Array.Empty<object>();
			GameLog.Info(msg, args2);
			int overrideAllRequest = _overrideAllRequest;
			string msg2 = $"_overrideAllRequest={overrideAllRequest}";
			object[] args3 = Array.Empty<object>();
			GameLog.Info(msg2, args3);
			bool flag = ActionsLocked;
			string msg3 = $"ActionsLocked={flag}";
			object[] args4 = Array.Empty<object>();
			GameLog.Info(msg3, args4);
			bool flag2 = WalkingLocked;
			string msg4 = $"WalkingLocked={flag2}";
			object[] args5 = Array.Empty<object>();
			GameLog.Info(msg4, args5);
			bool flag3 = InputLocked;
			string msg5 = $"InputLocked={flag3}";
			object[] args6 = Array.Empty<object>();
			GameLog.Info(msg5, args6);
			GameObject currentInteractible = _currentInteractible;
			if ((object)currentInteractible == null || currentInteractible.name == null)
			{
			}
			string msg6 = "CurrentInteractible=" + "null";
			object[] args7 = Array.Empty<object>();
			GameLog.Info(msg6, args7);
			ControlSchemeType controlSchemeType = ActiveControlSchemeType;
			string msg7 = $"ActiveControlSchemeType={controlSchemeType}";
			object[] args8 = Array.Empty<object>();
			GameLog.Info(msg7, args8);
			OrbitCamera avatarOrbitCamera = _avatarOrbitCamera;
			string msg8 = $"_avatarOrbitCamera={avatarOrbitCamera}";
			object[] args9 = Array.Empty<object>();
			GameLog.Info(msg8, args9);
			OrbitCamera orbitCameraOverride = _orbitCameraOverride;
			string msg9 = $"_orbitCameraOverride={orbitCameraOverride}";
			object[] args10 = Array.Empty<object>();
			GameLog.Info(msg9, args10);
			if (ControlScheme != null)
			{
			}
			object[] args11 = Array.Empty<object>();
			GameLog.Info("*** PlayerNavigation DebugTraceInfo END ***", args11);
		}

		[Cpp2IlInjected.Token(Token = "0x6003939")]
		[Cpp2IlInjected.Address(RVA = "0x14CF640", Offset = "0x14CE040", VA = "0x1814CF640")]
		public PlayerNavigation()
		{
			//Discarded unreachable code: IL_0110
			//IL_0011: Expected I4, but got I8
			//IL_008f: Expected I4, but got I8
			//IL_00b9: Expected I4, but got I8
			//IL_00c2: Expected I4, but got I8
			int[] array = new int[2];
			array[0] = 1;
			InputMapCategories = array;
			_moveAnimBool = "Move";
			_runAnimFloat = "Run";
			_runSpeedAnimFloat = "RunSpeed";
			_speedThresholdToSendDesiredVelocityToAnimator = 0.05f;
			_runTurnAnimFloat = "RunTurn";
			_vfxOutBool = "out";
			_holdTimeBeforeTimerVFX = 0.5f;
			_fastTravelCameraMovementDelay = 0.5f;
			_fastTravelAvatarEndAnimationDelay = 0.5f;
			_fastTravelInBetweenDelay = 0.15f;
			_mouseOverOutlineGroupID = 4;
			_lineOfSightSphereCastStartAvatarHeightMinPercentage = 0.25f;
			_lineOfSightSphereCastStartAvatarHeightMaxPercentage = 0.75f;
			_lineOfSightSphereCastRadius = 0.5f;
			pcDefaultControls = ControlSchemeType.ThirdPerson;
			pcDefaultHookedControls = ControlSchemeType.ThirdPerson;
			_taskQueue = (List<PlayerTask>)(object)new List<T>();
			CurrentInteractPreview = new InteractPreview();
			resetInitialConfig = new CallOnce();
			interactibleObjectsPriorityOverrides = (List<(GameObject go, float distanceSq)>)(object)new List<T>();
			interactibleCollisionArray = new Collider[32];
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600393A")]
		[Cpp2IlInjected.Address(RVA = "0x14CF140", Offset = "0x14CDB40", VA = "0x1814CF140")]
		static PlayerNavigation()
		{
			//IL_0025: Expected O, but got I
			//IL_0047: Expected O, but got I
			//IL_0069: Expected O, but got I
			//IL_008b: Expected O, but got I
			//IL_00ad: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00f1: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0135: Expected O, but got I
			//IL_0157: Expected O, but got I
			//IL_0179: Expected O, but got I
			//IL_019b: Expected O, but got I
			//IL_01bd: Expected O, but got I
			//IL_01df: Expected O, but got I
			//IL_0201: Expected O, but got I
			//IL_021c: Expected O, but got I
			int num = 0;
			int num2 = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("MoveCamera", categoryId, (MarkerFlags)flags, metadataCount);
			int num3 = 0;
			s_moveCamera = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker("MoveAvatar", categoryId2, (MarkerFlags)flags2, metadataCount2);
			int num4 = 0;
			s_moveAvatar = (ProfilerMarker)(long)intPtr2;
			int flags3 = 0;
			int metadataCount3 = 0;
			ushort categoryId3 = default(ushort);
			IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker("UpdateAnimator", categoryId3, (MarkerFlags)flags3, metadataCount3);
			int num5 = 0;
			s_updateAnimator = (ProfilerMarker)(long)intPtr3;
			int flags4 = 0;
			int metadataCount4 = 0;
			ushort categoryId4 = default(ushort);
			IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker("ActuallyMoveAvatar", categoryId4, (MarkerFlags)flags4, metadataCount4);
			int num6 = 0;
			s_actuallyMoveAvatar = (ProfilerMarker)(long)intPtr4;
			int flags5 = 0;
			int metadataCount5 = 0;
			ushort categoryId5 = default(ushort);
			IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker("GetInteractable", categoryId5, (MarkerFlags)flags5, metadataCount5);
			int num7 = 0;
			s_getInteractable = (ProfilerMarker)(long)intPtr5;
			int flags6 = 0;
			int metadataCount6 = 0;
			ushort categoryId6 = default(ushort);
			IntPtr intPtr6 = ProfilerUnsafeUtility.CreateMarker("HasLineOfSight", categoryId6, (MarkerFlags)flags6, metadataCount6);
			int num8 = 0;
			s_int_hasLineOfSight = (ProfilerMarker)(long)intPtr6;
			int flags7 = 0;
			int metadataCount7 = 0;
			ushort categoryId7 = default(ushort);
			IntPtr intPtr7 = ProfilerUnsafeUtility.CreateMarker("IsInteractableObject", categoryId7, (MarkerFlags)flags7, metadataCount7);
			int num9 = 0;
			s_int_isInteractable = (ProfilerMarker)(long)intPtr7;
			int flags8 = 0;
			int metadataCount8 = 0;
			ushort categoryId8 = default(ushort);
			IntPtr intPtr8 = ProfilerUnsafeUtility.CreateMarker("Redirection", categoryId8, (MarkerFlags)flags8, metadataCount8);
			int num10 = 0;
			s_int_isInteractable_redirection = (ProfilerMarker)(long)intPtr8;
			int flags9 = 0;
			int metadataCount9 = 0;
			ushort categoryId9 = default(ushort);
			IntPtr intPtr9 = ProfilerUnsafeUtility.CreateMarker("GetGridObjectScript", categoryId9, (MarkerFlags)flags9, metadataCount9);
			int num11 = 0;
			s_int_isInteractable_gridObjectScript = (ProfilerMarker)(long)intPtr9;
			int flags10 = 0;
			int metadataCount10 = 0;
			ushort categoryId10 = default(ushort);
			IntPtr intPtr10 = ProfilerUnsafeUtility.CreateMarker("PlayerInteraction", categoryId10, (MarkerFlags)flags10, metadataCount10);
			int num12 = 0;
			s_int_isInteractable_playerInteraction = (ProfilerMarker)(long)intPtr10;
			int flags11 = 0;
			int metadataCount11 = 0;
			ushort categoryId11 = default(ushort);
			IntPtr intPtr11 = ProfilerUnsafeUtility.CreateMarker("TaskCollider", categoryId11, (MarkerFlags)flags11, metadataCount11);
			int num13 = 0;
			s_int_isInteractable_taskCollider = (ProfilerMarker)(long)intPtr11;
			int flags12 = 0;
			int metadataCount12 = 0;
			ushort categoryId12 = default(ushort);
			IntPtr intPtr12 = ProfilerUnsafeUtility.CreateMarker("PriorityOverrides", categoryId12, (MarkerFlags)flags12, metadataCount12);
			int num14 = 0;
			s_int_priorityOverrides = (ProfilerMarker)(long)intPtr12;
			int flags13 = 0;
			int metadataCount13 = 0;
			ushort categoryId13 = default(ushort);
			IntPtr intPtr13 = ProfilerUnsafeUtility.CreateMarker("OverlapItems", categoryId13, (MarkerFlags)flags13, metadataCount13);
			int num15 = 0;
			s_int_overlapItems = (ProfilerMarker)(long)intPtr13;
			int flags14 = 0;
			int metadataCount14 = 0;
			ushort categoryId14 = default(ushort);
			IntPtr intPtr14 = ProfilerUnsafeUtility.CreateMarker("OverlapItemsSort", categoryId14, (MarkerFlags)flags14, metadataCount14);
			int num16 = 0;
			s_int_overlapItems_sort = (ProfilerMarker)(long)intPtr14;
			int flags15 = 0;
			int metadataCount15 = 0;
			ushort categoryId15 = default(ushort);
			IntPtr intPtr15 = ProfilerUnsafeUtility.CreateMarker("OverlapCharacters", categoryId15, (MarkerFlags)flags15, metadataCount15);
			int num17 = 0;
			s_int_overlapCharacters = (ProfilerMarker)(long)intPtr15;
			int flags16 = 0;
			int metadataCount16 = 0;
			ushort categoryId16 = default(ushort);
			s_int_overlapCharacters_sort = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("OverlapCharactersSort", categoryId16, (MarkerFlags)flags16, metadataCount16);
		}
	}
}
