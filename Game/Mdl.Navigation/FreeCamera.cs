using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Gestures;
using Mdl.InputSystem;
using Mdl.Motion;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C30")]
	public class FreeCamera
	{
		[Cpp2IlInjected.Token(Token = "0x2000C31")]
		private enum BounceDirection
		{
			[Cpp2IlInjected.Token(Token = "0x4004412")]
			Up,
			[Cpp2IlInjected.Token(Token = "0x4004413")]
			Down
		}

		[Cpp2IlInjected.Token(Token = "0x2000C32")]
		private class RaycastHitDistanceFromReferenceComparer : IComparer<RaycastHit>
		{
			[Cpp2IlInjected.Token(Token = "0x1700076A")]
			public unsafe Vector3 ReferencePoint
			{
				[Cpp2IlInjected.Token(Token = "0x60037B5")]
				[Cpp2IlInjected.Address(RVA = "0xF0A3C0", Offset = "0xF08DC0", VA = "0x180F0A3C0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60037B6")]
				[Cpp2IlInjected.Address(RVA = "0xF0A930", Offset = "0xF09330", VA = "0x180F0A930")]
				[CompilerGenerated]
				set
				{
					//IL_000e: Expected native int or pointer, but got O
					float z = value.z;
					((Vector3*)(IntPtr)_003CReferencePoint_003Ek__BackingField)->z = z;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60037B7")]
			[Cpp2IlInjected.Address(RVA = "0x11DAE50", Offset = "0x11D9850", VA = "0x1811DAE50", Slot = "4")]
			public int Compare(RaycastHit x, RaycastHit y)
			{
				float z = ReferencePoint.z;
				float z2 = ReferencePoint.z;
				int result = default(int);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60037B8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RaycastHitDistanceFromReferenceComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000C33")]
		private class RaycastHitDistanceComparer : IComparer<RaycastHit>
		{
			[Cpp2IlInjected.Token(Token = "0x60037B9")]
			[Cpp2IlInjected.Address(RVA = "0x11DAE10", Offset = "0x11D9810", VA = "0x1811DAE10", Slot = "4")]
			public unsafe int Compare(RaycastHit x, RaycastHit y)
			{
				float distance = ((RaycastHit*)x)->distance;
				float distance2 = ((RaycastHit*)y)->distance;
				int result = default(int);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60037BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RaycastHitDistanceComparer()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40043FA")]
		private Vector3 _groundPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40043FD")]
		private RaycastHitBuffer transientGroundRaycastHits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40043FE")]
		private RaycastHitBuffer transientCollisionRaycastHits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004401")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4004402")]
		private CameraNavigationConfig _config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4004403")]
		private Tween<Vector3> _bounce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4004404")]
		private BounceDirection _bounceDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4004405")]
		private Vector3? _lastZoomDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4004406")]
		private Vector2? _lastScreenPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4004407")]
		private int _lastFingerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4004408")]
		private float _speedMultX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4004409")]
		private float _speedMultY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400440A")]
		private Plane _floorZeroPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400440B")]
		private float collisionRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400440C")]
		private float collisionOverlapRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400440D")]
		private int sphereCastMask;

		[Cpp2IlInjected.Token(Token = "0x400440E")]
		private const float collisionJumpMaxDistance = 15f;

		[Cpp2IlInjected.Token(Token = "0x400440F")]
		private const float collisionJumpStepDistance = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x4004410")]
		private static RaycastHitDistanceFromReferenceComparer groundHitResultComparer = new RaycastHitDistanceFromReferenceComparer();

		[Cpp2IlInjected.Token(Token = "0x17000761")]
		public ICameraBoundary[] Boundaries
		{
			[Cpp2IlInjected.Token(Token = "0x6003780")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CBoundaries_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003781")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CBoundaries_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000762")]
		public unsafe Vector3 Ground
		{
			[Cpp2IlInjected.Token(Token = "0x6003782")]
			[Cpp2IlInjected.Address(RVA = "0x146C860", Offset = "0x146B260", VA = "0x18146C860")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003783")]
			[Cpp2IlInjected.Address(RVA = "0x146C8F0", Offset = "0x146B2F0", VA = "0x18146C8F0")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				//IL_0036: Expected O, but got I4
				float z = value.z;
				((Vector3*)(IntPtr)_groundPosition)->z = z;
				Vector3 up = Vector3.up;
				int num = 0;
				float z2 = up.z;
				float z3 = _groundPosition.z;
				GroundPlane = (Plane)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000763")]
		private Plane GroundPlane
		{
			[Cpp2IlInjected.Token(Token = "0x6003784")]
			[Cpp2IlInjected.Address(RVA = "0x12953B0", Offset = "0x1293DB0", VA = "0x1812953B0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003785")]
			[Cpp2IlInjected.Address(RVA = "0x146C8E0", Offset = "0x146B2E0", VA = "0x18146C8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000764")]
		private unsafe Vector3 RotationTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6003786")]
			[Cpp2IlInjected.Address(RVA = "0x137EEB0", Offset = "0x137D8B0", VA = "0x18137EEB0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003787")]
			[Cpp2IlInjected.Address(RVA = "0x137EED0", Offset = "0x137D8D0", VA = "0x18137EED0")]
			[CompilerGenerated]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CRotationTarget_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000765")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x40043FF")]
		public float DefaultHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6003788")]
			[Cpp2IlInjected.Address(RVA = "0x8239B0", Offset = "0x8223B0", VA = "0x1808239B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003789")]
			[Cpp2IlInjected.Address(RVA = "0x824170", Offset = "0x822B70", VA = "0x180824170")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000766")]
		public float MinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600378A")]
			[Cpp2IlInjected.Address(RVA = "0x146C8B0", Offset = "0x146B2B0", VA = "0x18146C8B0")]
			get
			{
				//Discarded unreachable code: IL_0014
				//IL_0012: Expected O, but got F4
				//IL_0012: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected F4, but got Unknown
				CameraNavigationConfig config = _config;
				float minZoom = ((CameraNavigationConfig)DefaultHeight).minZoom;
				return /*Error near IL_0013: Stack underflow*/* minZoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000767")]
		public float MaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600378B")]
			[Cpp2IlInjected.Address(RVA = "0x146C880", Offset = "0x146B280", VA = "0x18146C880")]
			get
			{
				//Discarded unreachable code: IL_0014
				//IL_0012: Expected O, but got F4
				//IL_0012: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected F4, but got Unknown
				CameraNavigationConfig config = _config;
				float maxZoom = ((CameraNavigationConfig)DefaultHeight).maxZoom;
				return /*Error near IL_0013: Stack underflow*/* maxZoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000768")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x64"), Cpp2IlInjected.Token(Token = "0x4004400")]
		public bool IsMaxUnzoom
		{
			[Cpp2IlInjected.Token(Token = "0x600378C")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600378D")]
			[Cpp2IlInjected.Address(RVA = "0xD2B640", Offset = "0xD2A040", VA = "0x180D2B640")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000769")]
		public float CurrentZoom
		{
			[Cpp2IlInjected.Token(Token = "0x600378E")]
			[Cpp2IlInjected.Address(RVA = "0x146C7C0", Offset = "0x146B1C0", VA = "0x18146C7C0")]
			get
			{
				//Discarded unreachable code: IL_002f
				Transform transform = _camera.transform;
				float minZoom = _config.minZoom;
				CameraNavigationConfig config = _config;
				float num = DefaultHeight;
				float value = default(float);
				return Mathf.Clamp01(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600378F")]
		[Cpp2IlInjected.Address(RVA = "0x1469D30", Offset = "0x1468730", VA = "0x181469D30")]
		public void Init(Camera camera, CameraNavigationConfig config, float initialHeight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003790")]
		[Cpp2IlInjected.Address(RVA = "0x146BE70", Offset = "0x146A870", VA = "0x18146BE70")]
		public unsafe void Reset()
		{
			//IL_0009: Expected O, but got I4
			//IL_0010: Expected native int or pointer, but got O
			int num = 0;
			_lastScreenPos = (Vector2?)(object)num;
			((Nullable<>*)(IntPtr)_lastScreenPos)->has_value = (byte)num != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003791")]
		[Cpp2IlInjected.Address(RVA = "0x146AC80", Offset = "0x1469680", VA = "0x18146AC80")]
		public void Move(float deltaTime, MoveGesture move, InputAction panAction, InputAction rotateAction, InputAction zoomAction)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003792")]
		[Cpp2IlInjected.Address(RVA = "0x146BE80", Offset = "0x146A880", VA = "0x18146BE80")]
		private (Vector3, Quaternion) UpdateForCollisions(Vector3 desiredPosition, Quaternion cameraRotation)
		{
			//IL_0071: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			float z = Vector3.forward.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float z3 = cameraRotation.z;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			float z5 = cameraRotation.z;
			(bool, Vector3) tuple = default((bool, Vector3));
			if ((object)tuple != null)
			{
				float z6 = cameraRotation.z;
				Vector3 vector3 = default(Vector3);
				float z7 = vector3.z;
				Vector3 vector4 = default(Vector3);
				float z8 = vector4.z;
				float z9 = Vector3.forward.z;
				Vector3 vector5 = default(Vector3);
				float z10 = vector5.z;
				(bool, Vector3, float) tuple2 = default((bool, Vector3, float));
				if ((object)tuple2 != null)
				{
				}
			}
			int num = 0;
			int num2 = 0;
			Boundaries = (ICameraBoundary[])num;
			_groundPosition = (Vector3)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003793")]
		[Cpp2IlInjected.Address(RVA = "0x1467C10", Offset = "0x1466610", VA = "0x181467C10")]
		private Vector3 CalculatePan(float deltaTime, MoveGesture move, InputAction panAction)
		{
			int num = 0;
			float z = Vector3.zero.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003794")]
		[Cpp2IlInjected.Address(RVA = "0x14679E0", Offset = "0x14663E0", VA = "0x1814679E0")]
		private Vector3 CalculatePanInputAction(float deltaTime, InputAction panAction)
		{
			int num = 0;
			float z = Vector3.zero.z;
			if ((long)"{il2cpp array field il2cppMethodInfo->}" != 0)
			{
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003795")]
		[Cpp2IlInjected.Address(RVA = "0x1467070", Offset = "0x1465A70", VA = "0x181467070")]
		private Vector3 CalculatePanGesture(MoveGesture move)
		{
			int num = 0;
			int num2 = 0;
			float z = Vector3.zero.z;
			if ((long)"{il2cpp array field il2cppMethodInfo->}" == 0)
			{
				int num3 = 0;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
			}
			int num4 = 0;
			int touchCount = Input.touchCount;
			int num5 = 0;
			Vector2 zero = Vector2.zero;
			float z4 = Vector3.right.z;
			float z5 = Vector3.forward.z;
			float mouseRotationSpeed = move.MouseRotationSpeed;
			float z6 = Vector3.up.z;
			Vector3 vector3 = default(Vector3);
			float z7 = vector3.z;
			RectTransform zone = move._zone;
			Vector3 vector4 = default(Vector3);
			float z8 = vector4.z;
			Transform transform = zone.transform;
			float z9 = zone.position.z;
			RectTransform zone2 = move._zone;
			Transform transform2 = zone2.transform;
			float z10 = zone2.position.z;
			Vector3 vector5 = default(Vector3);
			float z11 = vector5.z;
			Vector2 lastPosition = move._lastPosition;
			bool flag = default(bool);
			if (!flag)
			{
				float z12 = Vector3.forward.z;
				float num6 = z8;
				float z13 = Vector3.right.z;
			}
			if (!flag)
			{
			}
			Vector3 vector6 = default(Vector3);
			float z14 = vector6.z;
			RectTransform zone3 = move._zone;
			Vector3 vector7 = default(Vector3);
			float z15 = vector7.z;
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003796")]
		[Cpp2IlInjected.Address(RVA = "0x1468180", Offset = "0x1466B80", VA = "0x181468180")]
		private Quaternion CalculateRotation(float deltaTime, MoveGesture move, InputAction rotateAction, Quaternion currentRotation)
		{
			int num = 0;
			Quaternion identity = Quaternion.identity;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003797")]
		[Cpp2IlInjected.Address(RVA = "0x1467F70", Offset = "0x1466970", VA = "0x181467F70")]
		private Quaternion CalculateRotationGesture(float deltaTime, MoveGesture move, Quaternion cameraRotation)
		{
			int num = 0;
			Quaternion identity = Quaternion.identity;
			if ((object)cameraRotation != null)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			if ((object)cameraRotation != null)
			{
				float z2 = Vector3.up.z;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003798")]
		[Cpp2IlInjected.Address(RVA = "0x1467D30", Offset = "0x1466730", VA = "0x181467D30")]
		private unsafe Quaternion CalculateRotationAction(float deltaTime, InputAction rotateAction, Quaternion cameraRotation)
		{
			//IL_0028: Expected O, but got I4
			int num = 0;
			Quaternion identity = Quaternion.identity;
			float z = ((Quaternion*)cameraRotation)->eulerAngles.z;
			int num2 = 0;
			int num3 = 0;
			Vector3 up = Vector3.up;
			Quaternion quaternion = cameraRotation * (Quaternion)num3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003799")]
		[Cpp2IlInjected.Address(RVA = "0x1468EC0", Offset = "0x14678C0", VA = "0x181468EC0")]
		private float ClampPitch(float pitchDelta, Quaternion cameraRotation)
		{
			//IL_0004: Invalid comparison between I4 and F4
			//IL_0016: Invalid comparison between F4 and I4
			int num = 0;
			if ((float)num <= pitchDelta || !(_config.minManualPitch > pitchDelta))
			{
				if (pitchDelta <= (float)num)
				{
					goto IL_0026;
				}
				float maxManualPitch = _config.maxManualPitch;
			}
			int num2 = 0;
			goto IL_0026;
			IL_0026:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600379A")]
		[Cpp2IlInjected.Address(RVA = "0x1466D30", Offset = "0x1465730", VA = "0x181466D30")]
		private (Vector3, Quaternion) ApplyRotation(Vector3 cameraPosition, Quaternion currentRotation, Quaternion desiredRotation)
		{
			//IL_0053: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			float z = Vector3.forward.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float z3 = currentRotation.z;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			float z5 = vector2.z;
			float z6 = currentRotation.z;
			float z7 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z8 = vector3.z;
			int num = 0;
			int num2 = 0;
			Boundaries = (ICameraBoundary[])num2;
			_groundPosition = (Vector3)num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600379B")]
		[Cpp2IlInjected.Address(RVA = "0x1468640", Offset = "0x1467040", VA = "0x181468640")]
		private float CalculateZoom(float deltaTime, MoveGesture move, InputAction zoomAction, Vector3 cameraPosition)
		{
			//Discarded unreachable code: IL_0106
			//IL_001d: Invalid comparison between F4 and I4
			//IL_0031: Expected O, but got F4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected F4, but got Unknown
			//IL_003f: Expected F4, but got I4
			//IL_0058: Expected O, but got F4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected F4, but got Unknown
			//IL_0062: Expected O, but got F4
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected F4, but got Unknown
			//IL_009f: Invalid comparison between F4 and I4
			//IL_00d4: Expected O, but got F4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected F4, but got Unknown
			//IL_00de: Expected O, but got F4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected F4, but got Unknown
			CameraNavigationConfig config = _config;
			int num = 0;
			if (config.allowRotation)
			{
			}
			int num2 = 0;
			float _003CDeltaScale_003Ek__BackingField = move.DeltaScale;
			if (!(_003CDeltaScale_003Ek__BackingField > (float)num2))
			{
			}
			IsMaxUnzoom = false;
			float num3 = ((FreeCamera)config.minZoom).DefaultHeight;
			float num4 = /*Error near IL_0032: Stack underflow*/* num3;
			num4 = _003CDeltaScale_003Ek__BackingField;
			float zoom = Mathf.Max(0f, num4);
			CameraNavigationConfig config2 = _config;
			float num5 = DefaultHeight;
			float minZoom = ((CameraNavigationConfig)num5).minZoom;
			float num6 = /*Error near IL_0059: Stack underflow*/* minZoom;
			float maxZoom = ((CameraNavigationConfig)num5).maxZoom;
			float maxZoom2 = /*Error near IL_0063: Stack underflow*/* maxZoom;
			float zoomModifierAtMin = config2.zoomModifierAtMin;
			num4 = num6;
			maxZoom2 = Mathf.Clamp(CameraUtil.ZoomModifier(zoom, num4, maxZoom2, zoomModifierAtMin), -10f, 10f);
			float valueFloat = zoomAction.GetValueFloat();
			zoomModifierAtMin = valueFloat;
			if (!(valueFloat > (float)num))
			{
			}
			CameraNavigationConfig config3 = _config;
			IsMaxUnzoom = false;
			float minZoom2 = config3.minZoom;
			CameraNavigationConfig config4 = _config;
			float num7 = DefaultHeight;
			num6 = num7;
			float minZoom3 = ((CameraNavigationConfig)num6).minZoom;
			float minZoom4 = /*Error near IL_00d5: Stack underflow*/* minZoom3;
			float maxZoom3 = ((CameraNavigationConfig)num7).maxZoom;
			float maxZoom4 = /*Error near IL_00df: Stack underflow*/* maxZoom3;
			float zoom2 = default(float);
			float num8 = Mathf.Clamp(CameraUtil.ZoomModifier(zoom2, minZoom4, maxZoom4, zoomModifierAtMin), -5f, 5f);
			return maxZoom2;
		}

		[Cpp2IlInjected.Token(Token = "0x600379C")]
		[Cpp2IlInjected.Address(RVA = "0x1468480", Offset = "0x1466E80", VA = "0x181468480")]
		private float CalculateZoomGesture(MoveGesture move, Vector3 cameraPosition)
		{
			//IL_001b: Invalid comparison between F4 and I4
			//IL_0035: Expected F4, but got I4
			//IL_0035: Expected F4, but got I4
			//IL_004a: Expected O, but got F4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected F4, but got Unknown
			CameraNavigationConfig config = _config;
			if (config.allowRotation)
			{
			}
			int num = 0;
			float _003CDeltaScale_003Ek__BackingField = move.DeltaScale;
			int num2 = default(int);
			if (!(_003CDeltaScale_003Ek__BackingField > (float)num))
			{
				num2 = 0;
			}
			IsMaxUnzoom = false;
			float minZoom = config.minZoom;
			float zoom = Mathf.Max(0f, num2);
			CameraNavigationConfig config2 = _config;
			float minZoom2 = ((CameraNavigationConfig)DefaultHeight).minZoom;
			float minZoom3 = /*Error near IL_004b: Stack underflow*/* minZoom2;
			float zoomModifierAtMin = config2.zoomModifierAtMin;
			float num3 = Mathf.Clamp(CameraUtil.ZoomModifier(zoom, minZoom3, _003CDeltaScale_003Ek__BackingField, zoomModifierAtMin), -10f, 10f);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600379D")]
		[Cpp2IlInjected.Address(RVA = "0x14682E0", Offset = "0x1466CE0", VA = "0x1814682E0")]
		private float CalculateZoomAction(InputAction zoomAction, Vector3 cameraPosition)
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_003c: Expected O, but got F4
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected F4, but got Unknown
			//IL_0046: Expected O, but got F4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected F4, but got Unknown
			float valueFloat = zoomAction.GetValueFloat();
			int num = 0;
			if (!(valueFloat > (float)num))
			{
				int num2 = 0;
			}
			CameraNavigationConfig config = _config;
			IsMaxUnzoom = false;
			float minZoom = config.minZoom;
			CameraNavigationConfig config2 = _config;
			float num3 = DefaultHeight;
			float minZoom2 = ((CameraNavigationConfig)num3).minZoom;
			float minZoom3 = /*Error near IL_003d: Stack underflow*/* minZoom2;
			float maxZoom = ((CameraNavigationConfig)num3).maxZoom;
			float maxZoom2 = /*Error near IL_0047: Stack underflow*/* maxZoom;
			float zoomModifierAtMin = config2.zoomModifierAtMin;
			float zoom = default(float);
			float num4 = Mathf.Clamp(CameraUtil.ZoomModifier(zoom, minZoom3, maxZoom2, zoomModifierAtMin), -5f, 5f);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600379E")]
		[Cpp2IlInjected.Address(RVA = "0x1466FF0", Offset = "0x14659F0", VA = "0x181466FF0")]
		private Vector3 ApplyZoom(float deltaZoom, Vector3 cameraPosition, Vector3 cameraForward)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600379F")]
		[Cpp2IlInjected.Address(RVA = "0x146A020", Offset = "0x1468A20", VA = "0x18146A020")]
		private (bool, Vector3, float) IsCameraInBoundaries(Vector3 cameraPosition, Vector3 cameraForward)
		{
			//IL_0045: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Vector3 vector = default(Vector3);
			if ((long)num2 < (long)(IntPtr)vector)
			{
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
				if (num2 == 0)
				{
					if (num2 == 0)
					{
						num2++;
						num2 += 312;
					}
					int num4 = 0;
					int num5 = 0;
					Boundaries = (ICameraBoundary[])num4;
					int num6 = 0;
				}
			}
			int num7 = 0;
			int num8 = 0;
			Boundaries = (ICameraBoundary[])num7;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A0")]
		[Cpp2IlInjected.Address(RVA = "0x146A2B0", Offset = "0x1468CB0", VA = "0x18146A2B0")]
		private bool IsPointInBoundaries(Vector3 point)
		{
			ICameraBoundary[] array = Boundaries;
			if (array != null)
			{
				int num = 0;
				int length = array.Length;
				if (num < length)
				{
					ICameraBoundary cameraBoundary = array[num];
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					float z = point.z;
					if (num == 0 && num == 0)
					{
						num++;
						num += 312;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A1")]
		[Cpp2IlInjected.Address(RVA = "0x146A410", Offset = "0x1468E10", VA = "0x18146A410")]
		private unsafe Vector3 KeepInBoundaries(Vector3 position, Vector3 forward)
		{
			//Discarded unreachable code: IL_01b7, IL_01bd
			//IL_0025: Expected F4, but got I4
			//IL_0020: Expected native int or pointer, but got O
			//IL_0042: Expected native int or pointer, but got O
			//IL_00c1: Expected native int or pointer, but got O
			//IL_014f: Expected F4, but got I4
			//IL_014a: Expected native int or pointer, but got O
			//IL_0195: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			float z = forward.z;
			float z2 = forward.z;
			Vector3 groundPosition = default(Vector3);
			((Vector3*)(IntPtr)groundPosition)->z = 0f;
			float z3 = groundPosition.z;
			Vector3 closestPoint = default(Vector3);
			((Vector3*)(IntPtr)closestPoint)->z = z3;
			if (_003C_003Ec._003C_003E9__66_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ICameraBoundary b) => (object)typeof(ICameraBoundary).TypeHandle == null);
			}
			Func<ICameraBoundary, bool> func = (Func<ICameraBoundary, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0023
				int num10 = 0;
				float z9 = groundPosition.z;
				uint num11 = default(uint);
				if (num10 < (int)num11)
				{
					num10 += num10;
					num10++;
				}
				return (object)typeof(ICameraBoundary).TypeHandle == null;
			};
			IEnumerable<ICameraBoundary> enumerable = default(IEnumerable<ICameraBoundary>);
			IEnumerable<ICameraBoundary> enumerable2 = (IEnumerable<ICameraBoundary>)Enumerable.Where<ICameraBoundary>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			if (Enumerable.Any<ICameraBoundary>((IEnumerable<>)enumerable2))
			{
				Func<ICameraBoundary, Vector3> func2 = (Func<ICameraBoundary, Vector3>)(object)(Func<T, TResult>)delegate
				{
					int num8 = 0;
					uint num9 = default(uint);
					if (num8 < (int)num9)
					{
						num8 += num8;
						num8++;
					}
					throw new NullReferenceException();
				};
				IEnumerable<ICameraBoundary> enumerable3 = (IEnumerable<ICameraBoundary>)Enumerable.Select<ICameraBoundary, Vector3>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
				float result = default(float);
				Func<Vector3, float> func3 = (Func<Vector3, float>)(object)(Func<T, TResult>)((Vector3 x) => result);
				IOrderedEnumerable<Vector3> orderedEnumerable = (IOrderedEnumerable<Vector3>)Enumerable.OrderBy<Vector3, float>((IEnumerable<>)enumerable3, (Func<, >)(object)func3);
				((Vector3*)(IntPtr)closestPoint)->z = z;
			}
			if (_003C_003Ec._003C_003E9__66_4 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			Func<ICameraBoundary, bool> func4 = default(Func<ICameraBoundary, bool>);
			Func<ICameraBoundary, bool> func5 = default(Func<ICameraBoundary, bool>);
			if (func4 == null)
			{
				func5 = (func4 = (Func<ICameraBoundary, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0023
					int num6 = 0;
					float z8 = closestPoint.z;
					uint num7 = default(uint);
					if (num6 < (int)num7)
					{
						num6 += num6;
						num6++;
					}
					return (object)typeof(ICameraBoundary).TypeHandle == null;
				});
			}
			IEnumerable<ICameraBoundary> enumerable4 = default(IEnumerable<ICameraBoundary>);
			IEnumerable<ICameraBoundary> enumerable5 = (IEnumerable<ICameraBoundary>)Enumerable.Where<ICameraBoundary>((IEnumerable<>)enumerable4, (Func<, >)(object)func5);
			if (enumerable5 != null)
			{
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_014f;
					}
					num2++;
				}
				float z4 = closestPoint.z;
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					num2++;
				}
				((Vector3*)(IntPtr)closestPoint)->z = num2;
				goto IL_014f;
			}
			goto IL_016d;
			IL_014f:
			enumerable5 = (IEnumerable<ICameraBoundary>)(object)((object)enumerable5 + (object)enumerable5);
			num2 += 312;
			enumerable5 = (IEnumerable<ICameraBoundary>)(object)((object)enumerable5 + (object)enumerable5);
			num2 += 328;
			goto IL_016d;
			IL_016d:
			if (enumerable5 != null)
			{
			}
			float z5 = groundPosition.z;
			uint num5 = default(uint);
			if (num2 < (int)num5)
			{
				num2 += num2;
				num2++;
			}
			((Vector3*)(IntPtr)closestPoint)->z = z3;
			float z6 = closestPoint.z;
			Vector3 vector = default(Vector3);
			float z7 = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A2")]
		[Cpp2IlInjected.Address(RVA = "0x146B5D0", Offset = "0x1469FD0", VA = "0x18146B5D0")]
		private unsafe RaycastHit? RaycastForGroundUsingComparer(IComparer<RaycastHit> comparer)
		{
			//IL_0009: Expected O, but got I4
			//IL_0015: Expected F4, but got I4
			//IL_0010: Expected native int or pointer, but got O
			//IL_0095: Expected O, but got I4
			//IL_00a2: Expected F4, but got I4
			//IL_009d: Expected native int or pointer, but got O
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			string[] array2;
			while (true)
			{
				int num = 0;
				Boundaries = (ICameraBoundary[])num;
				((Vector3*)(IntPtr)_groundPosition)->z = num;
				float z = vector.z;
				float z2 = vector2.z;
				float z3 = vector3.z;
				string[] array = new string[1];
				if ("Ground" == null || array != null)
				{
					array[0] = "Ground";
					int mask = LayerMask.GetMask(array);
					array2 = new string[1];
					if ("Water" == null || array2 != null)
					{
						break;
					}
				}
			}
			array2[0] = "Water";
			int num2 = 0;
			int mask2 = LayerMask.GetMask(array2);
			int num3 = 0;
			int num4 = 0;
			Boundaries = (ICameraBoundary[])num4;
			((Vector3*)(IntPtr)_groundPosition)->z = num4;
			int num5 = default(int);
			if (num5 > 0)
			{
				RaycastHit raycastHit = default(RaycastHit);
				int collider = raycastHit.m_Collider;
				bool flag = default(bool);
				if (!flag)
				{
					num3++;
				}
				if (num5 > 0)
				{
					RaycastHit raycastHit2 = default(RaycastHit);
					float y = raycastHit2.m_Normal.y;
					int collider2 = raycastHit2.m_Collider;
					bool flag2 = default(bool);
					if (flag2)
					{
						float z4 = Vector3.up.z;
						int num6 = 0;
						bool flag3 = default(bool);
						if (flag3)
						{
							goto IL_00f6;
						}
					}
					num3++;
				}
			}
			goto IL_00f6;
			IL_00f6:
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A3")]
		[Cpp2IlInjected.Address(RVA = "0x1469EE0", Offset = "0x14688E0", VA = "0x181469EE0")]
		private Vector3 InitialRaycastGround()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037A4")]
		[Cpp2IlInjected.Address(RVA = "0x146BB90", Offset = "0x146A590", VA = "0x18146BB90")]
		private void RaycastGround()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037A5")]
		[Cpp2IlInjected.Address(RVA = "0x146C2F0", Offset = "0x146ACF0", VA = "0x18146C2F0")]
		private unsafe void UpdateRotationTarget()
		{
			//Discarded unreachable code: IL_004d
			//IL_0047: Expected native int or pointer, but got O
			int num = 0;
			Transform transform = _camera.transform;
			Camera camera = _camera;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform2 = camera.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Plane plane = GroundPlane;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			((Vector3*)(IntPtr)RotationTarget)->z = z3;
		}

		[Cpp2IlInjected.Token(Token = "0x60037A6")]
		[Cpp2IlInjected.Address(RVA = "0x1468C60", Offset = "0x1467660", VA = "0x181468C60")]
		private Vector3 ClampHeight(Vector3 position, Vector3 forward)
		{
			//IL_0016: Expected F4, but got I4
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float num = default(float);
			float num2 = default(float);
			if (!(num > num2))
			{
			}
			float num3 = Mathf.Lerp(0f, num2, num);
			float z2 = forward.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A7")]
		[Cpp2IlInjected.Address(RVA = "0x1469240", Offset = "0x1467C40", VA = "0x181469240")]
		private Vector3 CollisionSnapUpwards(Vector3 initialPosition, Vector3 desiredPosition, Vector3 updatedPosition, float collisionRadius, float collisionOverlapRadius, int collisionMask)
		{
			//IL_0084: Expected F4, but got I4
			//IL_0086: Invalid comparison between F4 and I4
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			float b = default(float);
			(bool, Vector3) tuple = default((bool, Vector3));
			while (true)
			{
				float z = desiredPosition.z;
				float z2 = updatedPosition.z;
				float z3 = desiredPosition.z;
				float z4 = updatedPosition.z;
				float z5 = desiredPosition.z;
				float z6 = desiredPosition.z;
				float z7 = desiredPosition.z;
				float z8 = desiredPosition.z;
				float z9 = desiredPosition.z;
				float z10 = updatedPosition.z;
				float z11 = desiredPosition.z;
				float z12 = updatedPosition.z;
				float z13 = desiredPosition.z;
				int num = 0;
				int num2 = 0;
				float z14 = vector.z;
				float z15 = vector2.z;
				if (!(Mathf.Max(0f, b) <= (float)num2))
				{
					int num3 = 0;
					Vector3 up = Vector3.up;
					if ((object)tuple != null)
					{
						/*Error: Could not find block for branch target IL_009d*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037A8")]
		[Cpp2IlInjected.Address(RVA = "0x1468F60", Offset = "0x1467960", VA = "0x181468F60")]
		private Vector3 CollisionMoveUpwards(Vector3 initialPosition, Vector3 desiredPosition, Vector3 updatedPosition, float collisionRadius, float collisionOverlapRadius, int collisionMask)
		{
			//IL_000b: Expected F4, but got I4
			//IL_0010: Invalid comparison between F4 and I4
			int num = 0;
			int num2 = 0;
			float num3 = default(float);
			float num4 = Mathf.Max(num, num3);
			if (!(num4 > (float)num2))
			{
				float z = updatedPosition.z;
			}
			Vector3 up = Vector3.up;
			num4 = num3;
			float z2 = updatedPosition.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037A9")]
		[Cpp2IlInjected.Address(RVA = "0x1468970", Offset = "0x1467370", VA = "0x181468970")]
		private unsafe static (bool, Vector3) CheckForCollision(Vector3 initialPosition, Vector3 desiredPosition, float collisionRadius, float collisionOverlapRadius, int collisionMask, RaycastHitBuffer raycastHits)
		{
			//IL_0006: Invalid comparison between F4 and I4
			//IL_0028: Expected F4, but got I4
			//IL_0023: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			if (!(collisionOverlapRadius <= (float)num))
			{
				int num3 = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num4 = 0;
				float z2 = desiredPosition.z;
			}
			int num5 = 0;
			((Vector3*)(IntPtr)initialPosition)->x = num5;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037AA")]
		[Cpp2IlInjected.Address(RVA = "0x1469A70", Offset = "0x1468470", VA = "0x181469A70")]
		private unsafe static (bool, Vector3) FindNearestHit(Vector3 initialPoint, Vector3 desiredPoint, RaycastHitBuffer raycastHits)
		{
			//IL_0045: Expected F4, but got I4
			//IL_0040: Expected native int or pointer, but got O
			int hitCount = raycastHits.hitCount;
			int num = 0;
			float z = desiredPoint.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float z3 = desiredPoint.z;
			int num2 = 0;
			if ((long)(IntPtr)"{il2cpp array field il2cppMethodInfo->}" > (long)num2)
			{
				float z4 = desiredPoint.z;
				num2++;
			}
			int num3 = 0;
			((Vector3*)(IntPtr)initialPoint)->x = num3;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037AB")]
		[Cpp2IlInjected.Address(RVA = "0x1469930", Offset = "0x1468330", VA = "0x181469930")]
		public Vector3 FindBestGroundPositionFromCamera(Transform transform)
		{
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			bool flag = default(bool);
			if (!flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private static void OnscreenDebug(string key, Vector3 value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private static void OnscreenDebug(string key, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private static void OnscreenDebug(string key, bool value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private static void OnscreenDebug(string key, string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037B0")]
		[Cpp2IlInjected.Address(RVA = "0x1469730", Offset = "0x1468130", VA = "0x181469730")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private void DebugDrawGroundToCamera(Color color)
		{
			//Discarded unreachable code: IL_0020
			Transform transform = _camera.transform;
			float z = _groundPosition.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037B1")]
		[Cpp2IlInjected.Address(RVA = "0x1469840", Offset = "0x1468240", VA = "0x181469840")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private void DebugDrawPositionToCamera(Vector3 position, Color color)
		{
			//Discarded unreachable code: IL_001b
			Transform transform = _camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037B2")]
		[Cpp2IlInjected.Address(RVA = "0x146B590", Offset = "0x1469F90", VA = "0x18146B590")]
		[Conditional("DEBUG_FREE_CAMERA")]
		private void OnscreenDebugBoundaries()
		{
			//Discarded unreachable code: IL_0019
			ICameraBoundary[] array = Boundaries;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037B3")]
		[Cpp2IlInjected.Address(RVA = "0x146C4A0", Offset = "0x146AEA0", VA = "0x18146C4A0")]
		public unsafe FreeCamera()
		{
			//Discarded unreachable code: IL_00e2
			//IL_0024: Expected O, but got I4
			//IL_003b: Expected native int or pointer, but got O
			//IL_0048: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_00d3: Expected I4, but got O
			//IL_00e1: Expected O, but got I4
			int num2;
			string[] array2;
			while (true)
			{
				float z = Vector3.up.z;
				Vector3 zero = Vector3.zero;
				int num = 0;
				num2 = 0;
				float z2 = zero.z;
				GroundPlane = (Plane)num;
				float z3 = Vector3.zero.z;
				int num3 = 0;
				((Vector3*)(IntPtr)RotationTarget)->z = z3;
				transientGroundRaycastHits = (RaycastHitBuffer)num3;
				int num4 = 0;
				transientCollisionRaycastHits = (RaycastHitBuffer)num4;
				collisionRadius = 1f;
				collisionOverlapRadius = 0.5f;
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
			int mask2 = LayerMask.GetMask(array2);
			int num5 = 0;
			sphereCastMask = (int)typeof(Positions).TypeHandle;
			base.FieldGetter((string)num5, "CameraCollision", ref *(object*)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x60037B4")]
		[Cpp2IlInjected.Address(RVA = "0x146C430", Offset = "0x146AE30", VA = "0x18146C430")]
		static FreeCamera()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
