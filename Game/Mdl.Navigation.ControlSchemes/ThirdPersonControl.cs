using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.InputSystem;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Util;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Navigation.ControlSchemes
{
	[Cpp2IlInjected.Token(Token = "0x2000C9C")]
	internal class ThirdPersonControl : IControlScheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400469C")]
		public bool EnableTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400469D")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400469E")]
		private PlayerAvatar _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400469F")]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40046A0")]
		private CameraNavigationConfig _cameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40046A1")]
		private TurntableCamera _turntableCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40046A2")]
		private PresetCamera _presetCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40046A3")]
		private FollowCamera _followCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40046A4")]
		private float timer;

		[Cpp2IlInjected.Token(Token = "0x40046A5")]
		private const int numberOfPreviousDirections = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40046A6")]
		private Vector3[] previousDirections = new Vector3[5];

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40046A7")]
		private int nextIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40046A8")]
		private Vector3 desiredVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40046A9")]
		private SmoothedDirection desiredFacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40046AA")]
		private Vector3? hardTurnNewDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40046AB")]
		private float hardTurnFailsafe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40046AC")]
		private float previousRunTurnValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40046AD")]
		private int runFloatHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40046AE")]
		private int runTurnFloatHash;

		[Cpp2IlInjected.Token(Token = "0x170007E4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400469B")]
		public bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6003A95")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003A96")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710", Slot = "5")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170007E5")]
		public ControlSchemeType ControlSchemeType
		{
			[Cpp2IlInjected.Token(Token = "0x6003A97")]
			[Cpp2IlInjected.Address(RVA = "0x8C8560", Offset = "0x8C6F60", VA = "0x1808C8560", Slot = "6")]
			get
			{
				return ControlSchemeType.ThirdPerson;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E6")]
		public bool IsMaxUnzoom
		{
			[Cpp2IlInjected.Token(Token = "0x6003A98")]
			[Cpp2IlInjected.Address(RVA = "0x10758E0", Offset = "0x10742E0", VA = "0x1810758E0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _turntableCamera.IsMaxUnzoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E7")]
		public bool ShouldDisplayCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A99")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "8")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E8")]
		public bool RequiresInteractionAngle
		{
			[Cpp2IlInjected.Token(Token = "0x6003A9A")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "9")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E9")]
		public bool AutomaticRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6003A9B")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "10")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EA")]
		public bool HasCameraTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6003A9C")]
			[Cpp2IlInjected.Address(RVA = "0x10758C0", Offset = "0x10742C0", VA = "0x1810758C0", Slot = "11")]
			get
			{
				FollowCamera followCamera = _followCamera;
				if (followCamera == null)
				{
					int num = 0;
				}
				return followCamera.IsInTransition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9D")]
		[Cpp2IlInjected.Address(RVA = "0x1075810", Offset = "0x1074210", VA = "0x181075810")]
		public unsafe ThirdPersonControl()
		{
			//IL_0027: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)desiredVelocity)->z = z;
			desiredFacing = new SmoothedDirection();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9E")]
		[Cpp2IlInjected.Address(RVA = "0x10741F0", Offset = "0x1072BF0", VA = "0x1810741F0", Slot = "12")]
		public void Init(Camera camera, PlayerAvatar avatar, PlayerNavigationConfig playerConfig, Transform initialCamera, CameraNavigationConfig cameraConfig)
		{
			//Discarded unreachable code: IL_0273
			//IL_0017: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_01b0: Expected O, but got I4
			_camera = camera;
			PlayerAvatar avatar2 = _avatar;
			int num = 0;
			if (avatar2 != (UnityEngine.Object)num)
			{
				AnimationEventDispatcher component = _avatar.GetComponent<AnimationEventDispatcher>();
				AnimationEventDispatcher.AnimationEventHandler value = AvatarAnimationEvent;
				component.AnimationEvent -= value;
			}
			_avatar = avatar;
			PlayerAvatar avatar3 = _avatar;
			int num2 = 0;
			AnimationEventDispatcher.AnimationEventHandler animationEventHandler = default(AnimationEventDispatcher.AnimationEventHandler);
			if (avatar3 != (UnityEngine.Object)num2)
			{
				AnimationEventDispatcher component2 = _avatar.GetComponent<AnimationEventDispatcher>();
				animationEventHandler = AvatarAnimationEvent;
				component2.AnimationEvent += animationEventHandler;
			}
			_playerConfig = playerConfig;
			_cameraConfig = (CameraNavigationConfig)(object)animationEventHandler;
			int num3 = 0;
			_turntableCamera = (TurntableCamera)num3;
			_presetCamera = (PresetCamera)num3;
			_followCamera = (FollowCamera)num3;
			int num4 = 0;
			if (!((UnityEngine.Object)num3 != (UnityEngine.Object)num4))
			{
				PresetCamera presetCamera = (_presetCamera = new PresetCamera());
				PresetCamera presetCamera2 = _presetCamera;
				Transform transform = avatar.Agent.transform;
				TurntableCamera turntableCamera = (_turntableCamera = new TurntableCamera());
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
				NavMeshAgent _003CAgent_003Ek__BackingField = avatar.Agent;
				TurntableCamera turntableCamera2 = _turntableCamera;
				Transform transform2 = _003CAgent_003Ek__BackingField.transform;
				bool allowWheelZoomInHookedMode = playerConfig.allowWheelZoomInHookedMode;
			}
			bool allowWheelZoomInHookedMode2 = playerConfig.allowWheelZoomInHookedMode;
			FollowCamera followCamera = default(FollowCamera);
			_followCamera = followCamera;
			TurntableCamera turntableCamera3 = _turntableCamera;
			if (turntableCamera3 != null)
			{
				float num5 = (turntableCamera3.MaxVelocity = _cameraConfig.followMaxVelocity);
				CameraNavigationConfig cameraConfig2 = _cameraConfig;
				TurntableCamera turntableCamera4 = _turntableCamera;
				float num6 = (turntableCamera4.MaxForce = cameraConfig2.followMaxForce);
				CameraNavigationConfig cameraConfig3 = _cameraConfig;
				TurntableCamera turntableCamera5 = _turntableCamera;
				float num7 = (turntableCamera5.SlowDownRadius = cameraConfig3.followSlowDownRadius);
			}
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			int num8 = 0;
			if (system != (UnityEngine.Object)num8)
			{
				PlayerNavigation.ControlChanged value2 = OnControlChanged;
				system.OnControlChanged -= value2;
				PlayerNavigation.ControlChanged value3 = OnControlChanged;
				system.OnControlChanged += value3;
				PlayerNavigation.TaskCompleted value4 = OnTaskCompletedOrCancelled;
				system.OnTaskCompleted -= value4;
				PlayerNavigation.TaskCompleted value5 = OnTaskCompletedOrCancelled;
				system.OnTaskCompleted += value5;
				PlayerNavigation.TaskCancelled value6 = OnTaskCompletedOrCancelled;
				system.OnTaskCancelled -= value6;
				PlayerNavigation.TaskCancelled value7 = OnTaskCompletedOrCancelled;
				system.OnTaskCancelled += value7;
			}
			int num9 = Animator.StringToHash("Run");
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			runFloatHash = num9;
			int num10 = (runTurnFloatHash = Animator.StringToHash(playerConfig2.runTurnAnimatorParameter));
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9F")]
		[Cpp2IlInjected.Address(RVA = "0x1075150", Offset = "0x1073B50", VA = "0x181075150")]
		private void OnControlChanged(bool overridden)
		{
			if (!overridden)
			{
				UpdateDesiredFacingFromAvatar();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA0")]
		[Cpp2IlInjected.Address(RVA = "0x1075160", Offset = "0x1073B60", VA = "0x181075160")]
		private void OnTaskCompletedOrCancelled(PlayerTask task, int index)
		{
			UpdateDesiredFacingFromAvatar();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA1")]
		[Cpp2IlInjected.Address(RVA = "0x1075710", Offset = "0x1074110", VA = "0x181075710", Slot = "23")]
		public void UpdateDesiredFacingFromAvatar()
		{
			//Discarded unreachable code: IL_0062
			//IL_0059: Expected O, but got F4
			PlayerAvatar avatar = _avatar;
			SmoothedDirection smoothedDirection = desiredFacing;
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3[] array = previousDirections;
			int num = 0;
			if (num < array.Length)
			{
				Transform _003Ctransform_003Ek__BackingField2 = _avatar.transform;
				num++;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				array[1] = (Vector3)z2;
				Vector3[] array2 = previousDirections;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA2")]
		[Cpp2IlInjected.Address(RVA = "0x1075170", Offset = "0x1073B70", VA = "0x181075170", Slot = "17")]
		public void ResetCameraPosition([System.Runtime.InteropServices.Optional] float? offsetYaw, [System.Runtime.InteropServices.Optional] float? offsetPitch, [System.Runtime.InteropServices.Optional] float? transitionDuration)
		{
			//Discarded unreachable code: IL_00e0
			if (Enabled)
			{
				TurntableCamera turntableCamera = _turntableCamera;
				if (turntableCamera != null)
				{
					CameraNavigationConfig cameraConfig = _cameraConfig;
					Camera camera = _camera;
					PlayerAvatar avatar = _avatar;
					float defaultZoom = cameraConfig.defaultZoom;
					Vector2 vector2 = (turntableCamera.HorizontalOffset = ControlSchemesUtil.CameraHorizontalOffset(avatar, camera, cameraConfig, defaultZoom));
					Transform transform = _camera.transform;
					TurntableCamera turntableCamera2 = _turntableCamera;
					Vector3 vector3 = default(Vector3);
					float z = vector3.z;
					Transform transform2 = _camera.transform;
					float num = _turntableCamera.NormalizedZoom();
					float num2 = DesiredPitch(num);
					Transform transform3 = _camera.transform;
					Vector3 vector4 = default(Vector3);
					float z2 = vector4.z;
					num2 = num;
					int num3 = 0;
					Transform transform4 = _camera.transform;
					TurntableCamera turntableCamera3 = _turntableCamera;
					Vector3 vector5 = default(Vector3);
					float z3 = vector5.z;
				}
				_followCamera?.Reset((Nullable<>)offsetYaw, (Nullable<>)offsetPitch, (Nullable<>)transitionDuration);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA3")]
		[Cpp2IlInjected.Address(RVA = "0x10753B0", Offset = "0x1073DB0", VA = "0x1810753B0", Slot = "16")]
		public void Reset()
		{
			//IL_0023: Expected O, but got I4
			if (Enabled)
			{
				_turntableCamera?.Reset();
				int num = 0;
				hardTurnNewDirection = (Vector3?)(object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA4")]
		[Cpp2IlInjected.Address(RVA = "0x1074A30", Offset = "0x1073430", VA = "0x181074A30", Slot = "13")]
		public void MoveAvatar(float deltaTime, InputAction inputMoveAxes, bool controlsOverridden)
		{
			//Discarded unreachable code: IL_002b, IL_0051, IL_0071, IL_00f0, IL_011e, IL_012f
			//IL_002a: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			//IL_00eb: Expected native int or pointer, but got O
			//IL_0114: Expected native int or pointer, but got O
			//IL_012f: Expected O, but got I4
			//IL_015f: Expected O, but got F4
			//IL_017d: Expected I4, but got O
			if (1 == 0 && _playerConfig.allowMoveAxesInHookedMode)
			{
				float num = hardTurnFailsafe;
				int num2 = 0;
				hardTurnFailsafe = num;
				hardTurnNewDirection = (Vector3?)(object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA5")]
		[Cpp2IlInjected.Address(RVA = "0x1074060", Offset = "0x1072A60", VA = "0x181074060", Slot = "22")]
		public Vector3 GetAvatarFacingDirection()
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA6")]
		[Cpp2IlInjected.Address(RVA = "0x1074F30", Offset = "0x1073930", VA = "0x181074F30", Slot = "14")]
		public void MoveCamera(float deltaTime, MoveGesture move, bool controlsOverridden)
		{
			//Discarded unreachable code: IL_00a0
			if (1u != 0)
			{
				return;
			}
			Transform transform = default(Transform);
			if (_followCamera == null)
			{
				if (_turntableCamera == null)
				{
					_presetCamera.Move(deltaTime, move);
					return;
				}
				CameraNavigationConfig cameraConfig = _cameraConfig;
				PlayerAvatar avatar = _avatar;
				Camera camera = _camera;
				float zoomAmount = default(float);
				Vector2 vector = ControlSchemesUtil.CameraHorizontalOffset(avatar, camera, cameraConfig, zoomAmount);
				TurntableCamera turntableCamera = _turntableCamera;
				float normalizedZoom = _turntableCamera.NormalizedZoom();
				float num = DesiredPitch(normalizedZoom);
				float num2 = default(float);
				if (move == null)
				{
					num = num2;
				}
				transform = _camera.transform;
				Transform transform2 = _camera.transform;
				Vector3 vector2 = default(Vector3);
				float z = vector2.z;
				num2 = num;
			}
			IEnumerator enumerator = ((IEnumerable)transform).GetEnumerator();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA7")]
		[Cpp2IlInjected.Address(RVA = "0x1074EF0", Offset = "0x10738F0", VA = "0x181074EF0", Slot = "15")]
		public void MoveCamera(float deltaTime, InputAction panAction, InputAction rotateAction, InputAction zoomAction, bool controlsOverridden)
		{
			if (1 == 0 && _followCamera == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA8")]
		[Cpp2IlInjected.Address(RVA = "0x10756B0", Offset = "0x10740B0", VA = "0x1810756B0", Slot = "18")]
		public void UpdateCameraTransition(float deltaTime)
		{
			//Discarded unreachable code: IL_0026
			//IL_0025: Expected O, but got I4
			FollowCamera followCamera = _followCamera;
			if (followCamera != null && followCamera.IsInTransition)
			{
				FollowCamera followCamera2 = _followCamera;
				int num = 0;
				followCamera2.Move(deltaTime, (MoveGesture)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA9")]
		[Cpp2IlInjected.Address(RVA = "0x10753E0", Offset = "0x1073DE0", VA = "0x1810753E0", Slot = "19")]
		public void UpdateAvatarAnimatorParameters(Vector2 moveInput, ref bool move, ref float run)
		{
			//Discarded unreachable code: IL_010a
			//IL_0025: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			Vector3[] array = previousDirections;
			int num = nextIndex;
			int length = array.Length;
			int num2 = num - 1;
			ulong num3 = num3 + num3;
			num2 = (int)((long)num2 - (long)num3);
			num2 += 5;
			ulong num4 = num4 + num4;
			num2 = (int)((long)num2 - (long)num4);
			float z = Vector3.up.z;
			PlayerNavigationConfig playerConfig = _playerConfig;
			float value = default(float);
			float b = Mathf.Clamp(value, -0.99f, 0.99f);
			float runTurnSmoothing = _playerConfig.runTurnSmoothing;
			float num5 = Mathf.Lerp(previousRunTurnValue, b, runTurnSmoothing);
			PlayerAvatar avatar = _avatar;
			previousRunTurnValue = num5;
			Animator animator = avatar.Animator;
			float value2 = previousRunTurnValue;
			int id = runTurnFloatHash;
			animator.SetFloat(id, value2);
			bool flag = default(bool);
			if (flag && !_avatar.AvatarGoingSomewhere)
			{
				Animator animator2 = _avatar.Animator;
				int id2 = runFloatHash;
				float @float = animator2.GetFloat(id2);
				PlayerNavigationConfig playerConfig2 = _playerConfig;
				if (!(@float <= playerConfig2.hardStopThreshold))
				{
					_avatar.Animator.SetTrigger("HardStop");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAA")]
		[Cpp2IlInjected.Address(RVA = "0x1073F10", Offset = "0x1072910", VA = "0x181073F10", Slot = "21")]
		public float DesiredPitch(CameraNavigationConfig currentCameraConfig)
		{
			//Discarded unreachable code: IL_000f
			float defaultZoom = currentCameraConfig.defaultZoom;
			return DesiredPitch(defaultZoom);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAB")]
		[Cpp2IlInjected.Address(RVA = "0x1073F30", Offset = "0x1072930", VA = "0x181073F30")]
		private float DesiredPitch(float normalizedZoom)
		{
			//Discarded unreachable code: IL_00c4
			//IL_0025: Expected I4, but got I8
			//IL_0057: Expected O, but got I4
			PlayerNavigationConfig playerConfig = _playerConfig;
			CameraNavigationConfig cameraConfig = _cameraConfig;
			Camera camera = _camera;
			ulong num = default(ulong);
			float num2 = ControlSchemesUtil.FollowCameraDesiredPitch(_avatar, camera, cameraConfig, playerConfig, (byte)num != 0);
			CameraNavigationConfig cameraConfig2 = _cameraConfig;
			num2 = normalizedZoom;
			float num3 = ControlSchemesUtil.TurntableCameraDesiredPitch(num2, normalizedZoom, cameraConfig2);
			CameraOverrideZone cameraOverrideZone = _avatar.cameraOverrideZone;
			int num4 = 0;
			if (cameraOverrideZone != (UnityEngine.Object)num4)
			{
				PlayerAvatar avatar = _avatar;
				CameraOverrideZone cameraOverrideZone2 = avatar.cameraOverrideZone;
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				float pitch = cameraOverrideZone2.GetPitch(_003Ctransform_003Ek__BackingField, ControlSchemeType.HookedCamera);
				PlayerAvatar avatar2 = _avatar;
				CameraOverrideZone cameraOverrideZone3 = avatar2.cameraOverrideZone;
				Camera camera2 = _camera;
				Transform _003Ctransform_003Ek__BackingField2 = avatar2.transform;
				float strength = cameraOverrideZone3.GetStrength(_003Ctransform_003Ek__BackingField2, camera2);
				strength = normalizedZoom;
				float num5 = Mathf.Lerp(strength, normalizedZoom, strength);
			}
			return normalizedZoom;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAC")]
		[Cpp2IlInjected.Address(RVA = "0x1074170", Offset = "0x1072B70", VA = "0x181074170")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_0060
			TurntableCamera turntableCamera = _turntableCamera;
			if (turntableCamera != null)
			{
				float num = (turntableCamera.MaxVelocity = _cameraConfig.followMaxVelocity);
				CameraNavigationConfig cameraConfig = _cameraConfig;
				TurntableCamera turntableCamera2 = _turntableCamera;
				float num2 = (turntableCamera2.MaxForce = cameraConfig.followMaxForce);
				CameraNavigationConfig cameraConfig2 = _cameraConfig;
				TurntableCamera turntableCamera3 = _turntableCamera;
				float num3 = (turntableCamera3.SlowDownRadius = cameraConfig2.followSlowDownRadius);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAD")]
		[Cpp2IlInjected.Address(RVA = "0x1073D00", Offset = "0x1072700", VA = "0x181073D00", Slot = "24")]
		public void DebugTrace()
		{
			//Discarded unreachable code: IL_0097
			TurntableCamera turntableCamera = _turntableCamera;
			string text = $"ThirdPersonCamera._turntableCamera={turntableCamera}";
			FollowCamera followCamera = _followCamera;
			string text2 = $"ThirdPersonCamera._orbitCamera={followCamera}";
			PresetCamera presetCamera = _presetCamera;
			string arg = $"ThirdPersonCamera._presetCamera={presetCamera}";
			TurntableCamera turntableCamera2 = _turntableCamera;
			if (turntableCamera2 != null)
			{
				float maxVelocity = turntableCamera2.MaxVelocity;
				string arg2 = $"ThirdPersonCamera._turntableCamera.MaxVelocity={arg}";
				float maxForce = _turntableCamera.MaxForce;
				string arg3 = $"ThirdPersonCamera._turntableCamera.MaxVelocity={arg2}";
				float slowDownRadius = _turntableCamera.SlowDownRadius;
				string text3 = $"ThirdPersonCamera._turntableCamera.MaxVelocity={arg3}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAE")]
		[Cpp2IlInjected.Address(RVA = "0x1073BB0", Offset = "0x10725B0", VA = "0x181073BB0")]
		private void AvatarAnimationEvent(string eventName, AnimationEventDispatcher.AnimationEventArgs args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAF")]
		[Cpp2IlInjected.Address(RVA = "0x10740E0", Offset = "0x1072AE0", VA = "0x1810740E0", Slot = "20")]
		public (Vector3, Quaternion) GetCameraDesiredPositionAndRotation()
		{
			//IL_0012: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Enabled = (byte)num != 0;
			_camera = (Camera)num;
			throw new NullReferenceException();
		}
	}
}
