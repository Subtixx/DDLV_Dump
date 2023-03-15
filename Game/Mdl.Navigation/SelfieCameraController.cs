using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.InputSystem;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C3F")]
	public class SelfieCameraController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400445E")]
		private float inputYaw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400445F")]
		private LaggedAngle avatarAngle = new LaggedAngle();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004460")]
		private SelfieCamera selfieCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004461")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004462")]
		private OrbitCameraConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004463")]
		private float elapsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4004464")]
		private float max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004465")]
		private float initial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4004466")]
		private float target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004467")]
		private Vector3 positionInitial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4004468")]
		private Quaternion rotationInitial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4004469")]
		private Vector3 positionTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400446A")]
		private Quaternion rotationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400446B")]
		private Transform transitionTransformToUpdate;

		[Cpp2IlInjected.Token(Token = "0x1700077F")]
		public bool IsInTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6003817")]
			[Cpp2IlInjected.Address(RVA = "0xCCCD40", Offset = "0xCCB740", VA = "0x180CCCD40")]
			get
			{
				float num = max;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003818")]
		[Cpp2IlInjected.Address(RVA = "0xCCCC70", Offset = "0xCCB670", VA = "0x180CCCC70")]
		public SelfieCameraController(SelfieCamera selfieCamera, PlayerAvatar avatar, OrbitCameraConfig config)
		{
			//IL_0031: Expected F4, but got I4
			this.selfieCamera = selfieCamera;
			this.avatar = avatar;
			this.config = config;
			int num = 0;
			elapsed = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003819")]
		[Cpp2IlInjected.Address(RVA = "0xCCC4E0", Offset = "0xCCAEE0", VA = "0x180CCC4E0")]
		public void Reset(OrbitCameraConfig config, bool immediateUpdate = false)
		{
			//Discarded unreachable code: IL_009d
			//IL_0066: Expected F4, but got I4
			//IL_009c: Expected F4, but got I4
			this.config = config;
			PlayerAvatar playerAvatar = avatar;
			LaggedAngle laggedAngle = avatarAngle;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
			LaggedAngle laggedAngle2 = avatarAngle;
			float num = (laggedAngle2.InterpolationSpeed = config.rotationLagYaw);
			avatarAngle.UseInterpolation = true;
			SelfieCamera selfieCamera = this.selfieCamera;
			selfieCamera.Config = config;
			LaggedAngle _003CPitch_003Ek__BackingField = selfieCamera.Pitch;
			int num2 = 0;
			_003CPitch_003Ek__BackingField.Reset(num2);
			LaggedAngle _003CPitch_003Ek__BackingField2 = selfieCamera.Pitch;
			float num3 = (_003CPitch_003Ek__BackingField2.InterpolationSpeed = config.rotationLagPitch);
			selfieCamera.Pitch.UseInterpolation = true;
			if (immediateUpdate)
			{
				int num4 = 0;
				Update(num4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600381A")]
		[Cpp2IlInjected.Address(RVA = "0xCCC150", Offset = "0xCCAB50", VA = "0x180CCC150")]
		public void AddInput(InputAction rotateAvatar, InputAction rotateCamera)
		{
			//Discarded unreachable code: IL_0024
			//IL_0023: Expected F4, but got I4
			float num = (inputYaw = rotateAvatar.GetValueFloat());
			SelfieCamera selfieCamera = this.selfieCamera;
			Vector2 valueVector = rotateCamera.GetValueVector2();
			selfieCamera.InputPitch = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x600381B")]
		[Cpp2IlInjected.Address(RVA = "0xCCC9F0", Offset = "0xCCB3F0", VA = "0x180CCC9F0")]
		public void Update(float deltaTime)
		{
			//Discarded unreachable code: IL_010e
			//IL_001c: Expected F4, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_00f1: Expected F4, but got I4
			float _003CDesired_003Ek__BackingField = avatarAngle.Desired;
			int num = 0;
			float num2 = inputYaw;
			inputYaw = num;
			float num3 = CalculateYaw(deltaTime, _003CDesired_003Ek__BackingField, num2);
			LaggedAngle laggedAngle = avatarAngle;
			float _003CCurrent_003Ek__BackingField = laggedAngle.Current;
			_003CDesired_003Ek__BackingField = num3;
			laggedAngle.Update(deltaTime, _003CDesired_003Ek__BackingField, _003CCurrent_003Ek__BackingField);
			float num4 = elapsed;
			if (!(max <= num4))
			{
				elapsed = num4;
				float b = target;
				_003CDesired_003Ek__BackingField = num4;
				float num5 = Trigo.ClampAngleDegrees180(Mathf.LerpAngle(initial, b, _003CDesired_003Ek__BackingField));
				LaggedAngle laggedAngle2 = avatarAngle;
				b = num5;
				laggedAngle2.Reset(b);
				int num6 = 0;
				Transform transform = transitionTransformToUpdate;
				num5 = num4;
				float num7 = Mathf.Clamp01(num5);
				transform.position = (Vector3)num6;
				Transform transform2 = transitionTransformToUpdate;
				_003CCurrent_003Ek__BackingField = num4;
				transform2.rotation = (Quaternion)num6;
			}
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			float _003CCurrent_003Ek__BackingField2 = avatarAngle.Current;
			int num8 = 0;
			Quaternion quaternion = Quaternion.Euler(num4, num8, _003CCurrent_003Ek__BackingField2);
			if (!(max > elapsed))
			{
				selfieCamera.Update(deltaTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600381C")]
		[Cpp2IlInjected.Address(RVA = "0xCCC850", Offset = "0xCCB250", VA = "0x180CCC850")]
		private void UpdateTransition()
		{
			//Discarded unreachable code: IL_007b
			float num = Mathf.Clamp01(elapsed);
			float b = target;
			float num2 = Trigo.ClampAngleDegrees180(Mathf.LerpAngle(initial, b, num));
			LaggedAngle laggedAngle = avatarAngle;
			b = num2;
			laggedAngle.Reset(b);
			float z = positionTarget.z;
			Transform transform = transitionTransformToUpdate;
			num2 = num;
			float z2 = positionInitial.z;
			float num3 = Mathf.Clamp01(num2);
			Quaternion quaternion = rotationTarget;
			Transform transform2 = transitionTransformToUpdate;
			Quaternion quaternion2 = rotationInitial;
		}

		[Cpp2IlInjected.Token(Token = "0x600381D")]
		[Cpp2IlInjected.Address(RVA = "0xCCC390", Offset = "0xCCAD90", VA = "0x180CCC390")]
		private float ConsumeInputYaw()
		{
			float result = inputYaw;
			inputYaw = 0f;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600381E")]
		[Cpp2IlInjected.Address(RVA = "0xCCC1C0", Offset = "0xCCABC0", VA = "0x180CCC1C0")]
		private float CalculateYaw(float deltaTime, float currentYaw, float inputYaw)
		{
			//Discarded unreachable code: IL_007e
			//IL_0017: Expected F4, but got I4
			//IL_002d: Expected F4, but got I4
			SelfieCamera selfieCamera = this.selfieCamera;
			OrbitCameraConfig orbitCameraConfig = config;
			int num = 0;
			float num2 = orbitCameraConfig.MinDistance(num);
			OrbitCameraConfig orbitCameraConfig2 = config;
			int num3 = 0;
			float num4 = orbitCameraConfig2.MaxDistance(num3);
			if ((object)orbitCameraConfig2 == null)
			{
			}
			Transform transform = this.selfieCamera.Camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			OrbitCameraConfig orbitCameraConfig3 = config;
			float farHorizontalSpeed = orbitCameraConfig3.farHorizontalSpeed;
			float _003CRadians_003Ek__BackingField = Angle.FromDegrees(Mathf.Lerp(orbitCameraConfig3.closeHorizontalSpeed, farHorizontalSpeed, currentYaw)).Radians;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600381F")]
		[Cpp2IlInjected.Address(RVA = "0xCCC3A0", Offset = "0xCCADA0", VA = "0x180CCC3A0")]
		private float NormalizedDistance(Vector3 target, float yaw)
		{
			float num = config.MinDistance(yaw);
			OrbitCameraConfig orbitCameraConfig = config;
			float num2 = orbitCameraConfig.MaxDistance(yaw);
			if ((object)orbitCameraConfig == null)
			{
			}
			Transform transform = selfieCamera.Camera.transform;
			float z = target.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			num2 = yaw;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003820")]
		[Cpp2IlInjected.Address(RVA = "0xCCC600", Offset = "0xCCB000", VA = "0x180CCC600")]
		public void TransitionFromCurrent(Transform cameraTransform)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003821")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_SELFIE_CAMERA")]
		private static void OnscreenDebug(string name, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
