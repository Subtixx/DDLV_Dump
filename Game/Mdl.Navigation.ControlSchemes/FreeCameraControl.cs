using System;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.InputSystem;
using Meta.Util;
using UnityEngine;

namespace Mdl.Navigation.ControlSchemes
{
	[Cpp2IlInjected.Token(Token = "0x2000C99")]
	public class FreeCameraControl
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400468F")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004690")]
		private PlayerAvatar _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004691")]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004692")]
		private CameraNavigationConfig _cameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004693")]
		private FreeCamera _freeCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004694")]
		private PlayerNavigation _playerNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004695")]
		private Transform _initialCamera;

		[Cpp2IlInjected.Token(Token = "0x170007D4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400468E")]
		public bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5F")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003A60")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007D5")]
		public ControlSchemeType ControlSchemeType
		{
			[Cpp2IlInjected.Token(Token = "0x6003A61")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100")]
			get
			{
				return ControlSchemeType.FreeCameraControl;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D6")]
		public bool ShouldDisplayCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A62")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D7")]
		public bool RequiresInteractionAngle
		{
			[Cpp2IlInjected.Token(Token = "0x6003A63")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D8")]
		public bool AutomaticRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6003A64")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D9")]
		public bool HasCameraTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6003A65")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DA")]
		public float CurrentZoom
		{
			[Cpp2IlInjected.Token(Token = "0x6003A66")]
			[Cpp2IlInjected.Address(RVA = "0x1466C40", Offset = "0x1465640", VA = "0x181466C40")]
			get
			{
				//Discarded unreachable code: IL_0037
				FreeCamera freeCamera = _freeCamera;
				Transform transform = freeCamera._camera.transform;
				float minZoom = freeCamera._config.minZoom;
				CameraNavigationConfig config = freeCamera._config;
				float _003CDefaultHeight_003Ek__BackingField = freeCamera.DefaultHeight;
				float value = default(float);
				return Mathf.Clamp01(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DB")]
		public bool IsMaxUnzoom
		{
			[Cpp2IlInjected.Token(Token = "0x6003A67")]
			[Cpp2IlInjected.Address(RVA = "0x1466D10", Offset = "0x1465710", VA = "0x181466D10")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _freeCamera.IsMaxUnzoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DC")]
		public unsafe Vector3 Ground
		{
			[Cpp2IlInjected.Token(Token = "0x6003A68")]
			[Cpp2IlInjected.Address(RVA = "0x1466CE0", Offset = "0x14656E0", VA = "0x181466CE0")]
			get
			{
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A69")]
			[Cpp2IlInjected.Address(RVA = "0x1466B40", Offset = "0x1465540", VA = "0x181466B40")]
			set
			{
				//Discarded unreachable code: IL_003f
				//IL_0015: Expected native int or pointer, but got O
				//IL_003e: Expected O, but got I4
				FreeCamera freeCamera = _freeCamera;
				float z = value.z;
				((Vector3*)(IntPtr)freeCamera._groundPosition)->z = z;
				Vector3 up = Vector3.up;
				int num = 0;
				float z2 = up.z;
				float z3 = freeCamera._groundPosition.z;
				freeCamera.GroundPlane = (Plane)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6A")]
		[Cpp2IlInjected.Address(RVA = "0x1466BD0", Offset = "0x14655D0", VA = "0x181466BD0")]
		public FreeCameraControl()
		{
			//IL_0010: Expected F4, but got I4
			int num = 0;
			Enabled = true;
			UpdateCameraTransition(num);
			FreeCamera freeCamera = (_freeCamera = new FreeCamera());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6B")]
		[Cpp2IlInjected.Address(RVA = "0x14654C0", Offset = "0x1463EC0", VA = "0x1814654C0")]
		public void Init(Camera camera, PlayerAvatar avatar, PlayerNavigationConfig playerConfig, Transform initialCamera, CameraNavigationConfig cameraConfig)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6C")]
		[Cpp2IlInjected.Address(RVA = "0x1466B40", Offset = "0x1465540", VA = "0x181466B40")]
		public unsafe void SetGround(Vector3 ground)
		{
			//Discarded unreachable code: IL_003f
			//IL_0015: Expected native int or pointer, but got O
			//IL_003e: Expected O, but got I4
			FreeCamera freeCamera = _freeCamera;
			float z = ground.z;
			((Vector3*)(IntPtr)freeCamera._groundPosition)->z = z;
			Vector3 up = Vector3.up;
			int num = 0;
			float z2 = up.z;
			float z3 = freeCamera._groundPosition.z;
			freeCamera.GroundPlane = (Plane)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6D")]
		[Cpp2IlInjected.Address(RVA = "0x1466A40", Offset = "0x1465440", VA = "0x181466A40")]
		public void SetBoundaries(ICameraBoundary boundaries)
		{
			ICameraBoundary[] array;
			do
			{
				array = new ICameraBoundary[1];
			}
			while (boundaries != null && array == null);
			array[0] = boundaries;
			_freeCamera.Boundaries = array;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6E")]
		[Cpp2IlInjected.Address(RVA = "0x1466B10", Offset = "0x1465510", VA = "0x181466B10")]
		public void SetBoundaries(ICameraBoundary[] boundaries)
		{
			_freeCamera.Boundaries = boundaries;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6F")]
		[Cpp2IlInjected.Address(RVA = "0x14665A0", Offset = "0x1464FA0", VA = "0x1814665A0")]
		public unsafe void ResetCameraPosition(float? offsetYaw, float? offsetPitch, float? transitionDuration)
		{
			//Discarded unreachable code: IL_012a
			//IL_0039: Expected native int or pointer, but got O
			//IL_0066: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			int num = 0;
			if ((Enabled ? 1 : 0) != num)
			{
				Transform _003Ctransform_003Ek__BackingField = _avatar.transform;
				FreeCamera freeCamera = _freeCamera;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float z2 = vector.z;
				((Vector3*)(IntPtr)freeCamera._groundPosition)->z = z2;
				Vector3 up = Vector3.up;
				int num2 = 0;
				float z3 = up.z;
				float z4 = freeCamera._groundPosition.z;
				freeCamera.GroundPlane = (Plane)num2;
				Transform initialCamera = _initialCamera;
				Vector3 vector2 = default(Vector3);
				float z5 = vector2.z;
				FreeCamera freeCamera2 = _freeCamera;
				CameraNavigationConfig cameraConfig = _cameraConfig;
				float num3 = ControlSchemesUtil.DefaultHeight(freeCamera2.DefaultHeight, cameraConfig);
				Transform transform = _camera.transform;
				Camera camera = _camera;
				Vector3 vector3 = default(Vector3);
				float z6 = vector3.z;
				Transform transform2 = camera.transform;
				Vector3 vector4 = default(Vector3);
				float z7 = vector4.z;
				Quaternion quaternion = Quaternion.Euler((Vector3)num2);
				float z8 = Vector3.forward.z;
				Vector3 vector5 = default(Vector3);
				float z9 = vector5.z;
				float z10 = Vector3.up.z;
				float z11 = Vector3.forward.z;
				float num4 = default(float);
				z7 = num4;
				bool flag = default(bool);
				if (flag)
				{
					Transform transform3 = _camera.transform;
					Vector3 vector6 = default(Vector3);
					float z12 = vector6.z;
					Transform transform4 = _camera.transform;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A70")]
		[Cpp2IlInjected.Address(RVA = "0x1466A10", Offset = "0x1465410", VA = "0x181466A10")]
		public unsafe void Reset()
		{
			//Discarded unreachable code: IL_0026
			//IL_0019: Expected O, but got I4
			//IL_0020: Expected native int or pointer, but got O
			if (Enabled)
			{
				FreeCamera freeCamera = _freeCamera;
				int num = 0;
				freeCamera._lastScreenPos = (Vector2?)(object)num;
				((Nullable<>*)(IntPtr)freeCamera._lastScreenPos)->has_value = (byte)num != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A71")]
		[Cpp2IlInjected.Address(RVA = "0x14657F0", Offset = "0x14641F0", VA = "0x1814657F0")]
		public void MoveAvatar(float deltaTime, InputAction inputMoveAxes, bool controlsOverridden)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A72")]
		[Cpp2IlInjected.Address(RVA = "0x1465470", Offset = "0x1463E70", VA = "0x181465470")]
		public Vector3 GetAvatarFacingDirection()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A73")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void UpdateCameraTransition(float deltaTime)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A74")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void UpdateAvatarAnimatorParameters(Vector2 moveInput, ref bool move, ref float run)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A75")]
		[Cpp2IlInjected.Address(RVA = "0x1466410", Offset = "0x1464E10", VA = "0x181466410")]
		public void MoveCamera(float deltaTime, MoveGesture move, InputAction panAction, InputAction rotateAction, InputAction zoomAction, bool controlsOverridden)
		{
			//Discarded unreachable code: IL_006e
			if (!Enabled)
			{
				return;
			}
			FreeCamera freeCamera = _freeCamera;
			if (_cameraConfig.automaticPitchCalculation)
			{
				float num = DesiredPitch();
				if (move != null)
				{
				}
				CameraNavigationConfig cameraConfig = _cameraConfig;
				Camera camera = _camera;
				num = deltaTime;
				float num2 = ControlSchemesUtil.SteerPitch(num, num, camera, cameraConfig);
				num = num2;
				Transform transform = _camera.transform;
				Transform transform2 = _camera.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				num2 = num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A76")]
		[Cpp2IlInjected.Address(RVA = "0x1465270", Offset = "0x1463C70", VA = "0x181465270")]
		public float DesiredPitch(CameraNavigationConfig _)
		{
			return DesiredPitch();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A77")]
		[Cpp2IlInjected.Address(RVA = "0x1465280", Offset = "0x1463C80", VA = "0x181465280")]
		private float DesiredPitch()
		{
			//Discarded unreachable code: IL_0030
			Camera camera = _camera;
			PlayerAvatar avatar = _avatar;
			Transform transform = camera.transform;
			FreeCamera freeCamera = _freeCamera;
			CameraNavigationConfig cameraConfig = _cameraConfig;
			PlayerNavigationConfig playerConfig = _playerConfig;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A78")]
		[Cpp2IlInjected.Address(RVA = "0x1465220", Offset = "0x1463C20", VA = "0x181465220")]
		public void DebugTrace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A79")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void UpdateDesiredFacingFromAvatar()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7A")]
		[Cpp2IlInjected.Address(RVA = "0x1465320", Offset = "0x1463D20", VA = "0x181465320")]
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
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			throw new NullReferenceException();
		}
	}
}
