using System;
using Cpp2IlInjected;
using Mdl.Gestures;
using Mdl.Motion;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C40")]
	public class TurntableCamera
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400446D")]
		private CameraNavigationConfig _config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400446E")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400446F")]
		private bool _allowZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4004470")]
		private float _initialDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004471")]
		private float _initialHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004472")]
		private Transform _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004473")]
		private SteerCoroutine _steer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004474")]
		private Tween<Vector3> _bounce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004475")]
		private bool _wasZooming;

		[Cpp2IlInjected.Token(Token = "0x17000780")]
		public unsafe Vector2 HorizontalOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6003822")]
			[Cpp2IlInjected.Address(RVA = "0x13E2060", Offset = "0x13E0A60", VA = "0x1813E2060")]
			get
			{
				SteerCoroutine steer = _steer;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003823")]
			[Cpp2IlInjected.Address(RVA = "0x13E2150", Offset = "0x13E0B50", VA = "0x1813E2150")]
			set
			{
				//Discarded unreachable code: IL_001b
				//IL_001a: Expected F4, but got I4
				//IL_0015: Expected native int or pointer, but got O
				SteerCoroutine steer = _steer;
				steer.horizontalOffset = value;
				((Vector2*)(IntPtr)steer.horizontalOffset)->y = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000781")]
		public float MaxVelocity
		{
			[Cpp2IlInjected.Token(Token = "0x6003824")]
			[Cpp2IlInjected.Address(RVA = "0x13E20E0", Offset = "0x13E0AE0", VA = "0x1813E20E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _steer.maxVelocity;
			}
			[Cpp2IlInjected.Token(Token = "0x6003825")]
			[Cpp2IlInjected.Address(RVA = "0x13E21B0", Offset = "0x13E0BB0", VA = "0x1813E21B0")]
			set
			{
				//Discarded unreachable code: IL_000d
				_steer.maxVelocity = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000782")]
		public float MaxForce
		{
			[Cpp2IlInjected.Token(Token = "0x6003826")]
			[Cpp2IlInjected.Address(RVA = "0x13E20C0", Offset = "0x13E0AC0", VA = "0x1813E20C0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _steer.maxForce;
			}
			[Cpp2IlInjected.Token(Token = "0x6003827")]
			[Cpp2IlInjected.Address(RVA = "0x13E2190", Offset = "0x13E0B90", VA = "0x1813E2190")]
			set
			{
				//Discarded unreachable code: IL_000d
				_steer.maxForce = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000783")]
		public float SlowDownRadius
		{
			[Cpp2IlInjected.Token(Token = "0x6003828")]
			[Cpp2IlInjected.Address(RVA = "0x13E2130", Offset = "0x13E0B30", VA = "0x1813E2130")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _steer.slowDownRadius;
			}
			[Cpp2IlInjected.Token(Token = "0x6003829")]
			[Cpp2IlInjected.Address(RVA = "0x13E21D0", Offset = "0x13E0BD0", VA = "0x1813E21D0")]
			set
			{
				//Discarded unreachable code: IL_000d
				_steer.slowDownRadius = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000784")]
		public float MinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600382A")]
			[Cpp2IlInjected.Address(RVA = "0x13E2100", Offset = "0x13E0B00", VA = "0x1813E2100")]
			get
			{
				//Discarded unreachable code: IL_0012
				//IL_0010: Expected O, but got F4
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0012: Expected F4, but got Unknown
				float initialHeight = ((TurntableCamera)_config.minZoom)._initialHeight;
				return /*Error near IL_0011: Stack underflow*/* initialHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000785")]
		public float MaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600382B")]
			[Cpp2IlInjected.Address(RVA = "0x13E2090", Offset = "0x13E0A90", VA = "0x1813E2090")]
			get
			{
				//Discarded unreachable code: IL_0012
				//IL_0010: Expected O, but got F4
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0012: Expected F4, but got Unknown
				float initialHeight = ((TurntableCamera)_config.maxZoom)._initialHeight;
				return /*Error near IL_0011: Stack underflow*/* initialHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000786")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400446C")]
		public bool IsMaxUnzoom
		{
			[Cpp2IlInjected.Token(Token = "0x600382C")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600382D")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600382E")]
		[Cpp2IlInjected.Address(RVA = "0x13E0FB0", Offset = "0x13DF9B0", VA = "0x1813E0FB0")]
		public void Init(Camera camera, Transform target, CameraNavigationConfig config, float initialHeight, float initialHDistance, bool allowZoom)
		{
			//Discarded unreachable code: IL_0076
			//IL_001c: Expected F4, but got I4
			//IL_0023: Expected F4, but got I4
			_target = target;
			_config = config;
			_camera = camera;
			_initialHeight = 0f;
			_initialDistance = 0f;
			_allowZoom = false;
			SteerCoroutine steerCoroutine = (_steer = new SteerCoroutine());
			SteerCoroutine steer = _steer;
			Transform transform = (steer.target = _target);
			SetDefaultZoom();
			Camera camera2 = _camera;
			SteerCoroutine steer2 = _steer;
			Transform transform2 = camera2.transform;
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600382F")]
		[Cpp2IlInjected.Address(RVA = "0x13E13E0", Offset = "0x13DFDE0", VA = "0x1813E13E0")]
		public void Reset()
		{
			//Discarded unreachable code: IL_0019
			_steer.Reset();
			SetDefaultZoom();
			_wasZooming = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003830")]
		[Cpp2IlInjected.Address(RVA = "0x13E0F70", Offset = "0x13DF970", VA = "0x1813E0F70")]
		public Vector3 GetTargetPosition()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003831")]
		[Cpp2IlInjected.Address(RVA = "0x13E15E0", Offset = "0x13DFFE0", VA = "0x1813E15E0")]
		private void SetDefaultZoom()
		{
			//Discarded unreachable code: IL_005f
			//IL_0022: Expected O, but got F4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected F4, but got Unknown
			//IL_002b: Expected O, but got F4
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected F4, but got Unknown
			//IL_0052: Expected O, but got F4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected F4, but got Unknown
			CameraNavigationConfig config = _config;
			SteerCoroutine steer = _steer;
			float initialHeight = _initialHeight;
			float defaultZoom = config.defaultZoom;
			float maxZoom = ((CameraNavigationConfig)initialHeight).maxZoom;
			float b = /*Error near IL_0023: Stack underflow*/* maxZoom;
			float minZoom = ((CameraNavigationConfig)initialHeight).minZoom;
			float num = (steer.verticalDistance = Mathf.Lerp(/*Error near IL_002c: Stack underflow*/ * minZoom, b, defaultZoom));
			SteerCoroutine steer2 = _steer;
			float initialDistance = ((TurntableCamera)steer2.verticalDistance)._initialDistance;
			float num2 = (steer2.horizontalDistance = /*Error near IL_0053: Stack underflow*/* initialDistance);
		}

		[Cpp2IlInjected.Token(Token = "0x6003832")]
		[Cpp2IlInjected.Address(RVA = "0x13E1340", Offset = "0x13DFD40", VA = "0x1813E1340")]
		public float NormalizedZoom()
		{
			Transform transform = _camera.transform;
			Transform target = _target;
			CameraNavigationConfig config = _config;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003833")]
		[Cpp2IlInjected.Address(RVA = "0x13E1100", Offset = "0x13DFB00", VA = "0x1813E1100")]
		public void Move(float deltaTime, MoveGesture move)
		{
			//Discarded unreachable code: IL_00b4
			//IL_00b3: Expected O, but got I8
			Tween<Vector3> bounce = _bounce;
			if (bounce == null)
			{
				_steer.Move(deltaTime);
				Zoom(move);
				if (!_config.allowRotation)
				{
					Transform transform = _camera.transform;
					Transform transform2 = _camera.transform;
				}
				Vector2 _003CDeltaAngle_003Ek__BackingField = move.DeltaAngle;
				if (move == null)
				{
					return;
				}
				Transform target = _target;
				Camera camera = _camera;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform3 = camera.transform;
				Camera camera2 = _camera;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Transform transform4 = camera2.transform;
				float z3 = Vector3.up.z;
			}
			int reverse = 0;
			if (!((Tween<T>)(object)bounce).Play(deltaTime, (byte)reverse != 0))
			{
				_bounce = (Tween<Vector3>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003834")]
		[Cpp2IlInjected.Address(RVA = "0x13E1660", Offset = "0x13E0060", VA = "0x1813E1660")]
		private void Steer(float deltaTime)
		{
			//Discarded unreachable code: IL_000d
			_steer.Move(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6003835")]
		[Cpp2IlInjected.Address(RVA = "0x13E1680", Offset = "0x13E0080", VA = "0x1813E1680")]
		private void Zoom(MoveGesture move)
		{
			//IL_00d7: Expected O, but got F4
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected F4, but got Unknown
			//IL_00e1: Expected O, but got F4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected F4, but got Unknown
			//IL_0101: Expected O, but got F4
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected F4, but got Unknown
			//IL_0167: Expected F4, but got O
			//IL_019f: Expected O, but got F4
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected F4, but got Unknown
			//IL_01a9: Expected O, but got F4
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected F4, but got Unknown
			//IL_0276: Expected I4, but got O
			//IL_0287: Expected F4, but got I4
			//IL_029b: Expected O, but got F4
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected F4, but got Unknown
			if (_allowZoom)
			{
				Transform target = _target;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				IsMaxUnzoom = false;
				float _003CDeltaScale_003Ek__BackingField = move.DeltaScale;
				if (move != null)
				{
					CameraNavigationConfig config = _config;
					_wasZooming = true;
					float initialHeight = _initialHeight;
					float ceilingBounceAmount = config.ceilingBounceAmount;
					Camera camera = _camera;
					float maxZoom = ((CameraNavigationConfig)initialHeight).maxZoom;
					float num = /*Error near IL_01a0: Stack underflow*/* maxZoom;
					float minZoom = ((CameraNavigationConfig)initialHeight).minZoom;
					float num2 = /*Error near IL_01aa: Stack underflow*/* minZoom;
					float floorBounceAmount = config.floorBounceAmount;
					Transform transform = camera.transform;
					Transform target2 = _target;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					CameraNavigationConfig config2 = _config;
					float initialHeight2 = _initialHeight;
					Transform transform2 = _camera.transform;
					Vector3 vector4 = default(Vector3);
					float z4 = vector4.z;
					Camera camera2 = _camera;
					Vector3 vector5 = default(Vector3);
					float z5 = vector5.z;
					Transform transform3 = camera2.transform;
					Camera camera3 = _camera;
					Vector3 vector6 = default(Vector3);
					float z6 = vector6.z;
					Transform transform4 = camera3.transform;
					Vector3 vector7 = default(Vector3);
					float z7 = vector7.z;
					Transform transform5 = _camera.transform;
					Vector3 vector8 = default(Vector3);
					float z8 = vector8.z;
					Transform transform6 = _camera.transform;
					Camera camera4 = _camera;
					SteerCoroutine steer = _steer;
					IsMaxUnzoom = (byte)(int)transform6 != 0;
					Transform transform7 = camera4.transform;
					steer.verticalDistance = 0f;
					SteerCoroutine steer2 = _steer;
					float initialDistance = ((TurntableCamera)steer2.verticalDistance)._initialDistance;
					float num3 = (steer2.horizontalDistance = /*Error near IL_029c: Stack underflow*/* initialDistance);
					throw new NullReferenceException();
				}
				int num4 = 0;
				if (Input.touchCount < 2 && _wasZooming)
				{
					Camera camera5 = _camera;
					_wasZooming = false;
					Transform transform8 = camera5.transform;
					Vector3 vector9 = default(Vector3);
					float z9 = vector9.z;
					_003CDeltaScale_003Ek__BackingField = z;
					Camera camera6 = _camera;
					Vector3 vector10 = default(Vector3);
					float z10 = vector10.z;
					Transform transform9 = camera6.transform;
					Vector3 vector11 = default(Vector3);
					float z11 = vector11.z;
					Vector2 horizontalOffset = _steer.horizontalOffset;
					Vector3 vector12 = default(Vector3);
					float z12 = vector12.z;
					float y = _steer.horizontalOffset.y;
					Vector3 vector13 = default(Vector3);
					float z13 = vector13.z;
					CameraNavigationConfig config3 = _config;
					float initialHeight3 = _initialHeight;
					float maxZoom2 = ((CameraNavigationConfig)initialHeight3).maxZoom;
					float num5 = /*Error near IL_00d8: Stack underflow*/* maxZoom2;
					float minZoom2 = ((CameraNavigationConfig)initialHeight3).minZoom;
					float num6 = /*Error near IL_00e2: Stack underflow*/* minZoom2;
					Transform transform10 = _camera.transform;
					float initialHeight4 = ((TurntableCamera)_config.minZoom)._initialHeight;
					float num7 = /*Error near IL_0102: Stack underflow*/* initialHeight4;
					num5 = num7;
					Vector3 vector14 = default(Vector3);
					float z14 = vector14.z;
					num5 = num7;
					float horizontalDistance = default(float);
					_steer.horizontalDistance = horizontalDistance;
					SteerCoroutine steer3 = _steer;
					Transform transform11 = _camera.transform;
					float maxZoom3 = _config.maxZoom;
					Vector3 vector15 = default(Vector3);
					float z15 = vector15.z;
					float horizontalDistance2 = default(float);
					_steer.horizontalDistance = horizontalDistance2;
					_steer.verticalDistance = (float)horizontalOffset;
					CameraNavigationConfig config4 = _config;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003836")]
		[Cpp2IlInjected.Address(RVA = "0x13E1420", Offset = "0x13DFE20", VA = "0x1813E1420")]
		private void Rotate(MoveGesture move)
		{
			//Discarded unreachable code: IL_007c
			if (!_config.allowRotation)
			{
				Transform transform = _camera.transform;
				Transform transform2 = _camera.transform;
				return;
			}
			Vector2 _003CDeltaAngle_003Ek__BackingField = move.DeltaAngle;
			while (move == null)
			{
			}
			Transform target = _target;
			Camera camera = _camera;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform3 = camera.transform;
			Camera camera2 = _camera;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform4 = camera2.transform;
			float z3 = Vector3.up.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003837")]
		[Cpp2IlInjected.Address(RVA = "0x13E0D30", Offset = "0x13DF730", VA = "0x1813E0D30")]
		private unsafe void Bounce(Vector3 toPosition, float duration)
		{
			//Discarded unreachable code: IL_0066
			//IL_0020: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			Transform transform = _camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = default(int);
			Tween<Vector3>.InterpolationFunction interpolationFunction = (Tween<Vector3>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, Vector3, float, Vector3>*/)(&Vector3.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num2 = 0;
			float z2 = toPosition.z;
			Tween<Vector3> bounce = default(Tween<Vector3>);
			_bounce = bounce;
			Tween<Vector3> bounce2 = _bounce;
			Tween<Vector3>.UpdateEventHandler updateEventHandler = (Tween<Vector3>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(BounceUpdate);
			((Tween<T>)(object)bounce2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003838")]
		[Cpp2IlInjected.Address(RVA = "0x13E0CE0", Offset = "0x13DF6E0", VA = "0x1813E0CE0")]
		private void BounceUpdate(Vector3 position, float progress)
		{
			//Discarded unreachable code: IL_0014
			Transform transform = _camera.transform;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003839")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TurntableCamera()
		{
		}
	}
}
