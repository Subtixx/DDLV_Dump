using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C3E")]
	public class SelfieCamera
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004459")]
		private float InputPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400445B")]
		private OrbitCameraTarget Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400445C")]
		public Camera Camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400445D")]
		private OrbitCameraConfig Config;

		[Cpp2IlInjected.Token(Token = "0x1700077D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400445A")]
		private LaggedAngle Pitch
		{
			[Cpp2IlInjected.Token(Token = "0x600380C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		} = new LaggedAngle();


		[Cpp2IlInjected.Token(Token = "0x1700077E")]
		public float CurrentPitch
		{
			[Cpp2IlInjected.Token(Token = "0x600380D")]
			[Cpp2IlInjected.Address(RVA = "0xCCD950", Offset = "0xCCC350", VA = "0x180CCD950")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Pitch.Current;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600380E")]
		[Cpp2IlInjected.Address(RVA = "0xCCD890", Offset = "0xCCC290", VA = "0x180CCD890")]
		public SelfieCamera(Camera camera, OrbitCameraTarget target, OrbitCameraConfig config)
		{
			Camera = camera;
			Target = target;
			Config = config;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600380F")]
		[Cpp2IlInjected.Address(RVA = "0xCCD3D0", Offset = "0xCCBDD0", VA = "0x180CCD3D0")]
		public void Reset(OrbitCameraConfig config)
		{
			//Discarded unreachable code: IL_0039
			//IL_0017: Expected F4, but got I4
			Config = config;
			LaggedAngle laggedAngle = Pitch;
			int num = 0;
			laggedAngle.Reset(num);
			LaggedAngle laggedAngle2 = Pitch;
			float num2 = (laggedAngle2.InterpolationSpeed = config.rotationLagPitch);
			Pitch.UseInterpolation = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003810")]
		[Cpp2IlInjected.Address(RVA = "0xCCCD50", Offset = "0xCCB750", VA = "0x180CCCD50")]
		public void AddPitchInput(float pitchDelta)
		{
			InputPitch = pitchDelta;
		}

		[Cpp2IlInjected.Token(Token = "0x6003811")]
		[Cpp2IlInjected.Address(RVA = "0xCCD440", Offset = "0xCCBE40", VA = "0x180CCD440")]
		public void Update(float deltaTime)
		{
			//Discarded unreachable code: IL_0181
			//IL_0022: Expected F4, but got I4
			//IL_0038: Expected F4, but got I4
			//IL_0108: Expected F4, but got I4
			LaggedAngle laggedAngle = Pitch;
			InputPitch = 0f;
			OrbitCameraConfig config = Config;
			int num = 0;
			float num2 = config.MinDistance(num);
			OrbitCameraConfig config2 = Config;
			int num3 = 0;
			float num4 = config2.MaxDistance(num3);
			if ((object)config2 == null)
			{
			}
			Transform transform = Camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			OrbitCameraConfig config3 = Config;
			float farVerticalSpeed = config3.farVerticalSpeed;
			float t = default(float);
			float value = Trigo.ClampAngleDegrees180(Mathf.Lerp(config3.closeVerticalSpeed, farVerticalSpeed, t));
			OrbitCameraConfig config4 = Config;
			float maxPitch = config4.maxPitch;
			float minPitch = config4.minPitch;
			float num5 = Mathf.Clamp(value, minPitch, maxPitch);
			LaggedAngle laggedAngle2 = Pitch;
			float _003CCurrent_003Ek__BackingField = laggedAngle2.Current;
			maxPitch = num5;
			minPitch = deltaTime;
			laggedAngle2.Update(minPitch, maxPitch, _003CCurrent_003Ek__BackingField);
			Transform anchor = Target.anchor;
			Transform transform2 = anchor.transform;
			float m = anchor.localToWorldMatrix.m02;
			float _003CCurrent_003Ek__BackingField2 = Pitch.Current;
			int num6 = 0;
			Quaternion quaternion = Quaternion.Euler(m, _003CCurrent_003Ek__BackingField2, num6);
			Transform startCamera = Target.startCamera;
			OrbitCameraTarget target = Target;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform anchor2 = target.anchor;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			Camera camera = Camera;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			Transform transform3 = camera.transform;
			Transform transform4 = Camera.transform;
			Transform lookAt = Target.lookAt;
			transform4.LookAt(lookAt);
		}

		[Cpp2IlInjected.Token(Token = "0x6003812")]
		[Cpp2IlInjected.Address(RVA = "0xCCCD60", Offset = "0xCCB760", VA = "0x180CCCD60")]
		private float CalculatePitch(float deltaTime, float currentPitch, float inputPitch)
		{
			//Discarded unreachable code: IL_006a
			//IL_0017: Expected F4, but got I4
			//IL_002c: Expected F4, but got I4
			(Vector3, Quaternion) targetPositionAndRotation = ((Vector3, Quaternion))this.GetTargetPositionAndRotation();
			OrbitCameraConfig config = Config;
			int num = 0;
			float num2 = config.MinDistance(num);
			OrbitCameraConfig config2 = Config;
			int num3 = 0;
			float num4 = config2.MaxDistance(num3);
			if ((object)config2 == null)
			{
			}
			Transform transform = Camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			OrbitCameraConfig config3 = Config;
			float farVerticalSpeed = config3.farVerticalSpeed;
			return Mathf.Lerp(config3.closeVerticalSpeed, farVerticalSpeed, currentPitch);
		}

		[Cpp2IlInjected.Token(Token = "0x6003813")]
		[Cpp2IlInjected.Address(RVA = "0xCCD2A0", Offset = "0xCCBCA0", VA = "0x180CCD2A0")]
		private float NormalizedDistance(Vector3 target, float yaw)
		{
			float num = Config.MinDistance(yaw);
			OrbitCameraConfig config = Config;
			float num2 = config.MaxDistance(yaw);
			if ((object)config == null)
			{
			}
			Transform transform = Camera.transform;
			float z = target.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			num2 = yaw;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003814")]
		[Cpp2IlInjected.Address(RVA = "0xCCC390", Offset = "0xCCAD90", VA = "0x180CCC390")]
		private float ConsumePitchInput()
		{
			float inputPitch = InputPitch;
			InputPitch = 0f;
			return inputPitch;
		}

		[Cpp2IlInjected.Token(Token = "0x6003815")]
		[Cpp2IlInjected.Address(RVA = "0xCCCEF0", Offset = "0xCCB8F0", VA = "0x180CCCEF0")]
		public (Vector3, Quaternion) GetTargetPositionAndRotation()
		{
			//IL_0015: Expected F4, but got I4
			//IL_0015: Expected F4, but got I4
			//IL_0049: Expected F4, but got I4
			//IL_0092: Expected F4, but got I4
			//IL_009a: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			float num3 = Mathf.Clamp(Trigo.ClampAngleDegrees180(360f), num2, num);
			Transform transform = default(Transform);
			Transform transform2 = transform.transform;
			Matrix4x4 localToWorldMatrix = transform.localToWorldMatrix;
			float m = localToWorldMatrix.m02;
			float m2 = localToWorldMatrix.m03;
			int num4 = 0;
			Quaternion quaternion = Quaternion.Euler(m, m2, num4);
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			float z6 = Vector3.up.z;
			int num5 = 0;
			int num6 = 0;
			InputPitch = num6;
			Pitch = (LaggedAngle)num6;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003816")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_SELFIE_CAMERA")]
		private static void OnscreenDebug(string name, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
