using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Gestures;
using Mdl.InputSystem;
using Mdl.Motion;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C38")]
	public class OrbitCamera
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4004427")]
		private bool _allowZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004428")]
		protected Transform _targetTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004429")]
		private Vector3 _targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400442A")]
		protected Tween<float> _transition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400442B")]
		private float _normalizedDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400442C")]
		private Vector3 _currentPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400442D")]
		private Vector3 _nextPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400442E")]
		private Quaternion _currentRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400442F")]
		private Quaternion _nextRotation;

		[Cpp2IlInjected.Token(Token = "0x4004430")]
		protected static int sphereCastMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4004431")]
		protected float InitialYaw;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4004432")]
		protected float InitialPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4004433")]
		private float lastZoomValue;

		[Cpp2IlInjected.Token(Token = "0x1700076E")]
		public unsafe Vector3 DesiredCameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60037CE")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3C0", Offset = "0xF08DC0", VA = "0x180F0A3C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60037CF")]
			[Cpp2IlInjected.Address(RVA = "0xF0A930", Offset = "0xF09330", VA = "0x180F0A930")]
			[CompilerGenerated]
			private set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CDesiredCameraPosition_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076F")]
		public Quaternion DesiredCameraRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60037D0")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3E0", Offset = "0xF08DE0", VA = "0x180F0A3E0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60037D1")]
			[Cpp2IlInjected.Address(RVA = "0xF0A940", Offset = "0xF09340", VA = "0x180F0A940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000770")]
		public unsafe Vector3 YawForward
		{
			[Cpp2IlInjected.Token(Token = "0x60037D2")]
			[Cpp2IlInjected.Address(RVA = "0xA64BD0", Offset = "0xA635D0", VA = "0x180A64BD0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60037D3")]
			[Cpp2IlInjected.Address(RVA = "0xA64BF0", Offset = "0xA635F0", VA = "0x180A64BF0")]
			[CompilerGenerated]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CYawForward_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000771")]
		public OrbitCameraConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x60037D4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60037D5")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CConfig_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000772")]
		public bool IsInTransition
		{
			[Cpp2IlInjected.Token(Token = "0x60037D6")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3F0", Offset = "0xF08DF0", VA = "0x180F0A3F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000773")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4004423")]
		protected LaggedAngle Yaw
		{
			[Cpp2IlInjected.Token(Token = "0x60037D7")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000774")]
		protected LaggedAngle Pitch
		{
			[Cpp2IlInjected.Token(Token = "0x60037D8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CPitch_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60037D9")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CPitch_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000775")]
		public float CurrentPitch
		{
			[Cpp2IlInjected.Token(Token = "0x60037DA")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3A0", Offset = "0xF08DA0", VA = "0x180F0A3A0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Pitch.Current;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000776")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x60037DB")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CCamera_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60037DC")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CCamera_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000777")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4004426")]
		public float ScreenOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60037DD")]
			[Cpp2IlInjected.Address(RVA = "0xF0A6E0", Offset = "0xF090E0", VA = "0x180F0A6E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60037DE")]
			[Cpp2IlInjected.Address(RVA = "0xF0A950", Offset = "0xF09350", VA = "0x180F0A950")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000778")]
		private Vector3 NormalizedOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60037DF")]
			[Cpp2IlInjected.Address(RVA = "0xF0A400", Offset = "0xF08E00", VA = "0x180F0A400")]
			get
			{
				//IL_0040: Expected F4, but got I4
				bool flag = default(bool);
				if (!flag)
				{
					float z = Vector3.zero.z;
				}
				int num = 0;
				int num2 = 0;
				float num3 = default(float);
				float num4 = num3;
				float num5 = Camera.VerticalToHorizontalFieldOfView(num4, num4) * 0.5f;
				num5 = num4;
				Angle angle = Angle.FromDegrees(num5);
				float num6 = Mathf.Lerp(num5, num4, num2);
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				num4 = num3;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000779")]
		public Vector3 RawTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60037E0")]
			[Cpp2IlInjected.Address(RVA = "0xF0A630", Offset = "0xF09030", VA = "0x180F0A630")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077A")]
		public Vector3 Target
		{
			[Cpp2IlInjected.Token(Token = "0x60037E1")]
			[Cpp2IlInjected.Address(RVA = "0xF0A810", Offset = "0xF09210", VA = "0x180F0A810")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077B")]
		public float TargetDistance
		{
			[Cpp2IlInjected.Token(Token = "0x60037E2")]
			[Cpp2IlInjected.Address(RVA = "0xF0A6F0", Offset = "0xF090F0", VA = "0x180F0A6F0")]
			get
			{
				//Discarded unreachable code: IL_0040
				//IL_0025: Expected O, but got I4
				Transform transform = Camera.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform targetTransform = _targetTransform;
				int num = 0;
				if (targetTransform != (UnityEngine.Object)num)
				{
					Transform targetTransform2 = _targetTransform;
				}
				float z2 = _targetPosition.z;
				float result = default(float);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037E3")]
		[Cpp2IlInjected.Address(RVA = "0xF08630", Offset = "0xF07030", VA = "0x180F08630")]
		private unsafe void SetTarget(Transform targetTransform)
		{
			//IL_0019: Expected native int or pointer, but got O
			_targetTransform = targetTransform;
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E4")]
		[Cpp2IlInjected.Address(RVA = "0xF085B0", Offset = "0xF06FB0", VA = "0x180F085B0")]
		private unsafe void SetTarget(Vector3 targetPosition)
		{
			//IL_0009: Expected O, but got I8
			//IL_0017: Expected native int or pointer, but got O
			_targetTransform = (Transform)0;
			float z = targetPosition.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E5")]
		[Cpp2IlInjected.Address(RVA = "0xF085F0", Offset = "0xF06FF0", VA = "0x180F085F0")]
		private unsafe void SetTarget(Transform targetTransform, Vector3 targetPosition)
		{
			//IL_0015: Expected native int or pointer, but got O
			_targetTransform = targetTransform;
			float z = targetPosition.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E6")]
		[Cpp2IlInjected.Address(RVA = "0xF0A1F0", Offset = "0xF08BF0", VA = "0x180F0A1F0")]
		public unsafe OrbitCamera(Camera camera, [System.Runtime.InteropServices.Optional] OrbitCameraConfig config, bool allowZoom = false)
		{
			//Discarded unreachable code: IL_008a
			//IL_0012: Expected native int or pointer, but got O
			float z = Vector3.forward.z;
			((Vector3*)(IntPtr)YawForward)->z = z;
			Yaw = new LaggedAngle();
			Pitch = new LaggedAngle();
			_normalizedDistance = 1f;
			base._002Ector();
			Camera = camera;
			Config = config;
			Transform transform = Camera.transform;
			LaggedAngle laggedAngle = Yaw;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Transform transform2 = Camera.transform;
			LaggedAngle laggedAngle2 = Pitch;
			_allowZoom = allowZoom;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E7")]
		[Cpp2IlInjected.Address(RVA = "0xF0A110", Offset = "0xF08B10", VA = "0x180F0A110")]
		public OrbitCamera(Camera camera, Transform targetTransform, OrbitCameraConfig config, bool allowZoom = true)
		{
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E8")]
		[Cpp2IlInjected.Address(RVA = "0xF0A1A0", Offset = "0xF08BA0", VA = "0x180F0A1A0")]
		public OrbitCamera(Camera camera, Vector3 targetPosition, OrbitCameraConfig config, bool allowZoom = true)
		{
			float z = targetPosition.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037E9")]
		[Cpp2IlInjected.Address(RVA = "0xF09EB0", Offset = "0xF088B0", VA = "0x180F09EB0")]
		protected unsafe OrbitCamera(Camera camera, Transform targetTransform, Vector3 targetPosition, OrbitCameraConfig config, bool allowZoom)
		{
			//Discarded unreachable code: IL_00b7
			//IL_0012: Expected native int or pointer, but got O
			//IL_005e: Expected native int or pointer, but got O
			//IL_006a: Expected O, but got I4
			float z = Vector3.forward.z;
			((Vector3*)(IntPtr)YawForward)->z = z;
			Yaw = new LaggedAngle();
			Pitch = new LaggedAngle();
			_normalizedDistance = 1f;
			base._002Ector();
			Camera = camera;
			_targetTransform = targetTransform;
			float z2 = targetPosition.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z2;
			Config = (OrbitCameraConfig)0;
			Transform transform = Camera.transform;
			LaggedAngle laggedAngle = Yaw;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			Transform transform2 = Camera.transform;
			LaggedAngle laggedAngle2 = Pitch;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z5 = vector3.z;
			_allowZoom = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60037EA")]
		[Cpp2IlInjected.Address(RVA = "0xF09620", Offset = "0xF08020", VA = "0x180F09620")]
		protected unsafe void UpdateCameraPosition(Vector3 desiredPosition, Vector3 desiredTarget)
		{
			//Discarded unreachable code: IL_0057
			//IL_0019: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_004a: Expected native int or pointer, but got O
			Camera camera = Camera;
			int num = 0;
			Transform transform = camera.transform;
			int num2 = 0;
			transform.position = (Vector3)num;
			Transform transform2 = Camera.transform;
			int num3 = 0;
			Vector3 up = Vector3.up;
			transform2.LookAt((Vector3)num3, (Vector3)num2);
			float z = desiredPosition.z;
			((Vector3*)(IntPtr)DesiredCameraPosition)->z = z;
			Vector3 up2 = Vector3.up;
		}

		[Cpp2IlInjected.Token(Token = "0x60037EB")]
		[Cpp2IlInjected.Address(RVA = "0xF08200", Offset = "0xF06C00", VA = "0x180F08200", Slot = "4")]
		public virtual void Move(float deltaTime, MoveGesture move)
		{
			//Discarded unreachable code: IL_0029
			//IL_0028: Expected O, but got I8
			Tween<float> transition = _transition;
			if (transition == null)
			{
				InternalZoom(deltaTime);
			}
			int reverse = 0;
			if (!((Tween<T>)(object)transition).Play(deltaTime, (byte)reverse != 0))
			{
				_transition = (Tween<float>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037EC")]
		[Cpp2IlInjected.Address(RVA = "0xF08110", Offset = "0xF06B10", VA = "0x180F08110", Slot = "5")]
		public virtual void Move(float deltaTime, InputAction inputPan, InputAction inputRotation, InputAction inputZoom)
		{
			//IL_0030: Expected O, but got I8
			Tween<float> transition;
			int reverse;
			do
			{
				transition = _transition;
				if (transition == null)
				{
					Vector2 valueVector = inputRotation.GetValueVector2();
					InternalZoom(deltaTime);
					return;
				}
				reverse = 0;
			}
			while (((Tween<T>)(object)transition).Play(deltaTime, (byte)reverse != 0));
			_transition = (Tween<float>)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037ED")]
		[Cpp2IlInjected.Address(RVA = "0xF07E40", Offset = "0xF06840", VA = "0x180F07E40")]
		public unsafe void MoveWithSmoothZoom(float deltaTime, InputAction inputRotation, InputAction inputZoom)
		{
			//IL_0027: Invalid comparison between F4 and I4
			//IL_0030: Expected F4, but got O
			//IL_0044: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			Tween<float> transition;
			int num2 = default(int);
			int num3 = default(int);
			Tween<float> transition2 = default(Tween<float>);
			int reverse;
			do
			{
				transition = _transition;
				if (transition == null)
				{
					if ((IntPtr)(inputZoom.IsTriggered ? 1 : 0) != (IntPtr)transition)
					{
						float transitionDuration = Config.transitionDuration;
						int num = 0;
						if (!(transitionDuration <= (float)num))
						{
							lastZoomValue = (float)transition;
							float valueFloat = inputZoom.GetValueFloat();
							Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
							num2 = 0;
							EasingFunction easingFunction = new EasingFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
							num3 = 0;
							_transition = transition2;
							Tween<float> transition3 = _transition;
							Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateZoom);
							((Tween<T>)(object)transition3).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
							return;
						}
					}
					Vector2 valueVector = inputRotation.GetValueVector2();
					float valueFloat2 = inputZoom.GetValueFloat();
					InternalZoom(deltaTime);
				}
				reverse = 0;
			}
			while (((Tween<T>)(object)transition).Play(deltaTime, (byte)reverse != 0));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037EE")]
		[Cpp2IlInjected.Address(RVA = "0xF09970", Offset = "0xF08370", VA = "0x180F09970")]
		private void UpdateZoom(float value, float progress)
		{
			lastZoomValue = value;
			InternalZoom(value);
		}

		[Cpp2IlInjected.Token(Token = "0x60037EF")]
		[Cpp2IlInjected.Address(RVA = "0xF07BB0", Offset = "0xF065B0", VA = "0x180F07BB0")]
		private void InternalMove(float deltaTime, Vector2 inputRotation, float zoomDelta)
		{
			ApplyCameraRotation(deltaTime, inputRotation);
			InternalZoom(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60037F0")]
		[Cpp2IlInjected.Address(RVA = "0xF07BF0", Offset = "0xF065F0", VA = "0x180F07BF0")]
		private void InternalZoom(float zoomDelta)
		{
			//Discarded unreachable code: IL_0037
			Transform transform = Camera.transform;
			OrbitCameraConfig orbitCameraConfig = Config;
			float sphereCastCollisionRadius = orbitCameraConfig.sphereCastCollisionRadius;
			float sphereCastCollisionOverlapRadius = orbitCameraConfig.sphereCastCollisionOverlapRadius;
			int num = sphereCastMask;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F1")]
		[Cpp2IlInjected.Address(RVA = "0xF08460", Offset = "0xF06E60", VA = "0x180F08460", Slot = "6")]
		public virtual void Reset([System.Runtime.InteropServices.Optional] float? offsetYaw, [System.Runtime.InteropServices.Optional] float? offsetPitch, [System.Runtime.InteropServices.Optional] float? transitionDuration)
		{
			//Discarded unreachable code: IL_00aa
			//IL_001d: Expected I4, but got O
			//IL_003e: Expected F4, but got I4
			//IL_005f: Expected I4, but got O
			OrbitCameraConfig orbitCameraConfig = Config;
			int num = 0;
			LaggedAngle laggedAngle = Yaw;
			if ((object)orbitCameraConfig != null)
			{
			}
			int num2 = 0;
			laggedAngle.UseInterpolation = (byte)(int)orbitCameraConfig != 0;
			OrbitCameraConfig orbitCameraConfig2 = Config;
			LaggedAngle laggedAngle2 = Yaw;
			if ((object)orbitCameraConfig2 != null)
			{
			}
			int num3 = 0;
			laggedAngle2.InterpolationSpeed = num3;
			OrbitCameraConfig orbitCameraConfig3 = Config;
			LaggedAngle laggedAngle3 = Pitch;
			if ((object)orbitCameraConfig3 != null)
			{
			}
			int num4 = 0;
			laggedAngle3.UseInterpolation = (byte)(int)orbitCameraConfig3 != 0;
			OrbitCameraConfig orbitCameraConfig4 = Config;
			LaggedAngle laggedAngle4 = Pitch;
			float rotationLagPitch = default(float);
			if ((object)orbitCameraConfig4 != null)
			{
				rotationLagPitch = orbitCameraConfig4.rotationLagPitch;
			}
			laggedAngle4.InterpolationSpeed = rotationLagPitch;
			if ((object)offsetYaw != null)
			{
			}
			float initialYaw = InitialYaw;
			if ((object)offsetPitch != null)
			{
			}
			float initialPitch = InitialPitch;
			this.Transition(initialYaw, initialPitch, (Nullable<>)transitionDuration);
		}

		[Cpp2IlInjected.Token(Token = "0x60037F2")]
		[Cpp2IlInjected.Address(RVA = "0xF08EA0", Offset = "0xF078A0", VA = "0x180F08EA0")]
		public unsafe void Transition(float yaw, float pitch, Vector3 target, [System.Runtime.InteropServices.Optional] float? durationOverride, [System.Runtime.InteropServices.Optional] OrbitCameraConfig config)
		{
			//IL_000e: Expected native int or pointer, but got O
			//IL_001a: Expected O, but got I4
			float z = target.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
			Config = (OrbitCameraConfig)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F3")]
		[Cpp2IlInjected.Address(RVA = "0xF094F0", Offset = "0xF07EF0", VA = "0x180F094F0")]
		public unsafe void Transition(float yaw, float pitch, Transform target, [System.Runtime.InteropServices.Optional] float? durationOverride, [System.Runtime.InteropServices.Optional] OrbitCameraConfig config)
		{
			//IL_0019: Expected native int or pointer, but got O
			//IL_0025: Expected O, but got I4
			_targetTransform = target;
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
			Config = (OrbitCameraConfig)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F4")]
		[Cpp2IlInjected.Address(RVA = "0xF08FD0", Offset = "0xF079D0", VA = "0x180F08FD0")]
		protected unsafe void Transition(float yaw, float pitch, [System.Runtime.InteropServices.Optional] float? durationOverride)
		{
			//Discarded unreachable code: IL_01ad
			//IL_0033: Expected native int or pointer, but got O
			//IL_00fd: Expected native int or pointer, but got O
			//IL_0120: Invalid comparison between F4 and I4
			//IL_016a: Expected O, but got I4
			//IL_017c: Expected O, but got I4
			Transform transform = Camera.transform;
			Transform transform2 = Camera.transform;
			LaggedAngle laggedAngle = Yaw;
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_currentPosition)->z = z;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			Vector2 zero = Vector2.zero;
			laggedAngle.Reset(yaw);
			OrbitCameraConfig orbitCameraConfig = Config;
			LaggedAngle laggedAngle2 = Pitch;
			float maxPitch = orbitCameraConfig.maxPitch;
			float minPitch = orbitCameraConfig.minPitch;
			minPitch = Mathf.Clamp(pitch, minPitch, maxPitch);
			laggedAngle2.Reset(minPitch);
			Transform transform3 = Camera.transform;
			LaggedAngle laggedAngle3 = Pitch;
			LaggedAngle laggedAngle4 = Yaw;
			float _003CCurrent_003Ek__BackingField = laggedAngle3.Current;
			float _003CCurrent_003Ek__BackingField2 = laggedAngle4.Current;
			int num3 = 0;
			_normalizedDistance = 1f;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Transform transform4 = Camera.transform;
			Camera camera = Camera;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			((Vector3*)(IntPtr)_nextPosition)->z = z4;
			Transform transform5 = camera.transform;
			if ((object)durationOverride != null)
			{
			}
			float transitionDuration = Config.transitionDuration;
			if (!(transitionDuration <= (float)num3))
			{
				Transform transform6 = Camera.transform;
				float z5 = _currentPosition.z;
				Transform transform7 = Camera.transform;
				Quaternion quaternion = (transform7.rotation = _currentRotation);
				int num4 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num4, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num4 = 0;
				int num5 = default(int);
				EasingFunction easingFunction = new EasingFunction(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
				num5 = 0;
				_003CCurrent_003Ek__BackingField2 = transitionDuration;
				Tween<float> transition = default(Tween<float>);
				_transition = transition;
				Tween<float> transition2 = _transition;
				Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateTransition);
				((Tween<T>)(object)transition2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037F5")]
		[Cpp2IlInjected.Address(RVA = "0xF08F40", Offset = "0xF07940", VA = "0x180F08F40")]
		public unsafe void Transition(Vector3 position, Vector3 target, OrbitCameraConfig config, [System.Runtime.InteropServices.Optional] float? durationOverride)
		{
			//IL_0009: Expected O, but got I8
			//IL_0017: Expected native int or pointer, but got O
			_targetTransform = (Transform)0;
			float z = target.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
			float z2 = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F6")]
		[Cpp2IlInjected.Address(RVA = "0xF09590", Offset = "0xF07F90", VA = "0x180F09590")]
		public unsafe void Transition(Vector3 position, Transform target, OrbitCameraConfig config, [System.Runtime.InteropServices.Optional] float? durationOverride)
		{
			//IL_0019: Expected native int or pointer, but got O
			_targetTransform = target;
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)_targetPosition)->z = z;
			float z2 = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F7")]
		[Cpp2IlInjected.Address(RVA = "0xF08670", Offset = "0xF07070", VA = "0x180F08670")]
		private unsafe void Transition(Vector3 position, OrbitCameraConfig config, [System.Runtime.InteropServices.Optional] float? durationOverride)
		{
			//Discarded unreachable code: IL_026d
			//IL_0037: Expected native int or pointer, but got O
			//IL_004c: Expected native int or pointer, but got O
			//IL_0062: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			//IL_0165: Expected O, but got F4
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected F4, but got Unknown
			//IL_0177: Expected O, but got F4
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected F4, but got Unknown
			//IL_01c3: Expected native int or pointer, but got O
			//IL_01e6: Invalid comparison between F4 and I4
			//IL_0204: Expected O, but got I4
			//IL_021d: Expected O, but got I4
			//IL_022a: Expected O, but got I4
			//IL_023c: Expected O, but got I4
			Config = config;
			Transform transform = Camera.transform;
			Transform transform2 = Camera.transform;
			Camera camera = Camera;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_currentPosition)->z = z;
			float z2 = position.z;
			((Vector3*)(IntPtr)_nextPosition)->z = z2;
			int num = 0;
			camera.transform.position = (Vector3)num;
			Transform transform3 = Camera.transform;
			int num2 = 0;
			int num3 = 0;
			Vector3 up = Vector3.up;
			int num4 = 0;
			transform3.LookAt((Vector3)num3, (Vector3)num2);
			LaggedAngle laggedAngle = Yaw;
			int num5 = 0;
			float deltaTime = Time.deltaTime;
			Transform transform4 = Camera.transform;
			int num6 = 0;
			Vector2 zero = Vector2.zero;
			deltaTime = CalculateYaw(deltaTime, deltaTime, (Vector2)num4);
			laggedAngle.Reset(deltaTime);
			Transform transform5 = Camera.transform;
			Camera camera2 = Camera;
			Transform transform6 = camera2.transform;
			Transform transform7 = camera2.transform;
			float minPitch = Config.minPitch;
			LaggedAngle laggedAngle2 = Pitch;
			float num7 = default(float);
			minPitch = num7;
			laggedAngle2.Reset(minPitch);
			Transform transform8 = Camera.transform;
			LaggedAngle laggedAngle3 = Pitch;
			LaggedAngle laggedAngle4 = Yaw;
			float _003CCurrent_003Ek__BackingField = laggedAngle3.Current;
			float _003CCurrent_003Ek__BackingField2 = laggedAngle4.Current;
			int num8 = 0;
			LaggedAngle laggedAngle5 = Yaw;
			OrbitCameraConfig orbitCameraConfig = Config;
			float _003CCurrent_003Ek__BackingField3 = laggedAngle5.Current;
			float innerXRadius = ((OrbitCameraConfig)_003CCurrent_003Ek__BackingField).innerXRadius;
			float num9 = /*Error near IL_0166: Stack underflow*/* innerXRadius;
			OrbitCameraConfig orbitCameraConfig2 = Config;
			float num10 = default(float);
			float outerXRadius = ((OrbitCameraConfig)num10).outerXRadius;
			float num11 = /*Error near IL_0178: Stack underflow*/* outerXRadius;
			if ((object)orbitCameraConfig2 == null)
			{
			}
			Transform transform9 = Camera.transform;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			float normalizedDistance = default(float);
			_normalizedDistance = normalizedDistance;
			Transform transform10 = Camera.transform;
			Camera camera3 = Camera;
			Vector3 vector3 = default(Vector3);
			float z4 = vector3.z;
			((Vector3*)(IntPtr)_nextPosition)->z = z4;
			Transform transform11 = camera3.transform;
			if ((object)durationOverride != null)
			{
			}
			float transitionDuration = Config.transitionDuration;
			if (!(transitionDuration <= (float)num8))
			{
				Camera camera4 = Camera;
				int num12 = 0;
				camera4.transform.position = (Vector3)num12;
				Camera camera5 = Camera;
				int num13 = 0;
				camera5.transform.rotation = (Quaternion)num13;
				int num14 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num14, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num14 = 0;
				int num15 = default(int);
				EasingFunction easingFunction = new EasingFunction(num15, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
				num15 = 0;
				_003CCurrent_003Ek__BackingField2 = transitionDuration;
				Tween<float> transition = default(Tween<float>);
				_transition = transition;
				Tween<float> transition2 = _transition;
				Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateTransition);
				((Tween<T>)(object)transition2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037F8")]
		[Cpp2IlInjected.Address(RVA = "0xF082D0", Offset = "0xF06CD0", VA = "0x180F082D0")]
		private float NormalizedDistance(Vector3 position, Vector3 target, float yaw)
		{
			OrbitCameraConfig orbitCameraConfig = Config;
			float num = default(float);
			float num2 = num * (float)Math.PI;
			if ((object)Config == null)
			{
			}
			Transform transform = Camera.transform;
			float z = target.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037F9")]
		[Cpp2IlInjected.Address(RVA = "0xF097E0", Offset = "0xF081E0", VA = "0x180F097E0")]
		private void UpdateTransition(float value, float progress)
		{
			//Discarded unreachable code: IL_0041
			Transform transform = Camera.transform;
			float z = _nextPosition.z;
			float z2 = _currentPosition.z;
			Transform transform2 = Camera.transform;
			Quaternion nextRotation = _nextRotation;
			Quaternion currentRotation = _currentRotation;
		}

		[Cpp2IlInjected.Token(Token = "0x60037FA")]
		[Cpp2IlInjected.Address(RVA = "0xF07740", Offset = "0xF06140", VA = "0x180F07740")]
		protected void ApplyCameraRotation(float deltaTime, Vector2 deltaPos)
		{
			//Discarded unreachable code: IL_00e7
			//IL_00e6: Expected O, but got I4
			LaggedAngle laggedAngle = Yaw;
			float _003CDesired_003Ek__BackingField = laggedAngle.Desired;
			float _003CCurrent_003Ek__BackingField = Yaw.Current;
			float num = default(float);
			_003CDesired_003Ek__BackingField = num;
			laggedAngle.Update(deltaTime, _003CDesired_003Ek__BackingField, _003CCurrent_003Ek__BackingField);
			LaggedAngle laggedAngle2 = Pitch;
			float num2 = default(float);
			if (!(num2 <= 180f))
			{
			}
			OrbitCameraConfig orbitCameraConfig = Config;
			float maxPitch = orbitCameraConfig.maxPitch;
			float minPitch = orbitCameraConfig.minPitch;
			float num3 = Mathf.Clamp(num2, minPitch, maxPitch);
			LaggedAngle laggedAngle3 = Pitch;
			float _003CCurrent_003Ek__BackingField2 = laggedAngle3.Current;
			maxPitch = num3;
			minPitch = deltaTime;
			laggedAngle3.Update(minPitch, maxPitch, _003CCurrent_003Ek__BackingField2);
			Transform transform = Camera.transform;
			LaggedAngle laggedAngle4 = Pitch;
			LaggedAngle laggedAngle5 = Yaw;
			OrbitCameraConfig orbitCameraConfig2 = Config;
			if (!(deltaTime <= orbitCameraConfig2.maxYaw))
			{
				LaggedAngle laggedAngle6 = Yaw;
				OrbitCameraConfig orbitCameraConfig3 = Config;
				Camera camera = Camera;
				int num4 = 0;
				Transform transform2 = camera.transform;
				LaggedAngle laggedAngle7 = Pitch;
				transform2.eulerAngles = (Vector3)num4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037FB")]
		[Cpp2IlInjected.Address(RVA = "0xF07B00", Offset = "0xF06500", VA = "0x180F07B00", Slot = "7")]
		protected virtual float CalculateYaw(float deltaTime, float currentYaw, Vector2 deltaPos)
		{
			//Discarded unreachable code: IL_0027
			OrbitCameraConfig orbitCameraConfig = Config;
			float farHorizontalSpeed = orbitCameraConfig.farHorizontalSpeed;
			float num = Mathf.Lerp(orbitCameraConfig.closeHorizontalSpeed, farHorizontalSpeed, currentYaw);
			Angle angle = default(Angle);
			float _003CRadians_003Ek__BackingField = angle.Radians;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037FC")]
		[Cpp2IlInjected.Address(RVA = "0xF07A80", Offset = "0xF06480", VA = "0x180F07A80", Slot = "8")]
		protected virtual float CalculatePitch(float deltaTime, float currentPitch, Vector2 deltaPos)
		{
			//Discarded unreachable code: IL_0020
			OrbitCameraConfig orbitCameraConfig = Config;
			float farVerticalSpeed = orbitCameraConfig.farVerticalSpeed;
			float num = Mathf.Lerp(orbitCameraConfig.closeVerticalSpeed, farVerticalSpeed, currentPitch);
			return currentPitch;
		}

		[Cpp2IlInjected.Token(Token = "0x60037FD")]
		[Cpp2IlInjected.Address(RVA = "0xF09990", Offset = "0xF08390", VA = "0x180F09990", Slot = "9")]
		protected virtual Vector3 Zoom(float deltaScale)
		{
			//IL_0020: Expected F4, but got I4
			//IL_0020: Expected F4, but got I4
			Vector3 right = Vector3.right;
			int num = 0;
			int num2 = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float x = default(float);
			Quaternion quaternion = Quaternion.Euler(x, num2, num);
			Vector3 forward = Vector3.forward;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037FE")]
		[Cpp2IlInjected.Address(RVA = "0xF09CA0", Offset = "0xF086A0", VA = "0x180F09CA0")]
		static OrbitCamera()
		{
			//Discarded unreachable code: IL_0056
			string[] array2;
			while (true)
			{
				string[] array = new string[1];
				if ("Ground" == null || array != null)
				{
					array[0] = "Ground";
					int mask = LayerMask.GetMask(array);
					array2 = new string[1];
					if ("CameraCollision" == null || array2 != null)
					{
						break;
					}
				}
			}
			array2[0] = "CameraCollision";
			int num = 0;
			int mask2 = LayerMask.GetMask(array2);
			sphereCastMask = num;
		}
	}
}
