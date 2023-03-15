using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C39")]
	[CreateAssetMenu]
	public class OrbitCameraConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004434")]
		[Tooltip("Expresses how much the resulting delta lags behind the actual touch. A MaxForce of 1 means no lag, 0 means no movement.")]
		[Range(0f, 1f)]
		public float moveMaxForce = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004435")]
		[Range(0f, 1f)]
		[Tooltip("Expresses the speed at which the resulting delta will stop moving after touch release. A Friction of 1 means immediate stopping, 0 means no stopping at all.")]
		public float moveFriction = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004436")]
		[Tooltip("Camera yaw rotation speed, in degrees per second, at minimum distance")]
		public float closeHorizontalSpeed = 180f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4004437")]
		[Tooltip("Camera yaw rotation speed, in degrees per second, at maximum distance")]
		public float farHorizontalSpeed = 180f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004438")]
		[Tooltip("Camera pitch rotation speed, in degrees per second, at minimum distance")]
		public float closeVerticalSpeed = 90f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4004439")]
		[Tooltip("Camera pitch rotation speed, in degrees per second, at maximum distance")]
		public float farVerticalSpeed = 90f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400443A")]
		public float minPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400443B")]
		public float maxPitch = 90f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400443C")]
		public float maxYaw = 180f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400443D")]
		public float innerXRadius = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400443E")]
		public float innerZRadius = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400443F")]
		public float outerXRadius = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004440")]
		public float outerZRadius = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4004441")]
		public float zoomSpeed = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004442")]
		public float transitionDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4004443")]
		public float sphereCastCollisionRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004444")]
		public float sphereCastCollisionOverlapRadius = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4004445")]
		public float rotationLagYaw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004446")]
		public float rotationLagPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004447")]
		[Tooltip("Follow camera specific config")]
		public FollowCameraConfig FollowConfig;

		[Cpp2IlInjected.Token(Token = "0x60037FF")]
		[Cpp2IlInjected.Address(RVA = "0xF07560", Offset = "0xF05F60", VA = "0x180F07560")]
		public float MinDistance(float yaw)
		{
			//IL_000e: Expected O, but got F4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected F4, but got Unknown
			//IL_0018: Expected O, but got F4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected F4, but got Unknown
			float num = default(float);
			float num2 = num * (float)Math.PI;
			float num3 = ((OrbitCameraConfig)num2).innerXRadius;
			float num4 = /*Error near IL_000f: Stack underflow*/* num3;
			int num5 = 0;
			float num6 = ((OrbitCameraConfig)num2).innerZRadius;
			float num7 = /*Error near IL_0019: Stack underflow*/* num6;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003800")]
		[Cpp2IlInjected.Address(RVA = "0xF074F0", Offset = "0xF05EF0", VA = "0x180F074F0")]
		public float MaxDistance(float yaw)
		{
			//IL_000e: Expected O, but got F4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected F4, but got Unknown
			//IL_0018: Expected O, but got F4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected F4, but got Unknown
			float num = default(float);
			float num2 = num * (float)Math.PI;
			float num3 = ((OrbitCameraConfig)num2).outerXRadius;
			float num4 = /*Error near IL_000f: Stack underflow*/* num3;
			int num5 = 0;
			float num6 = ((OrbitCameraConfig)num2).outerZRadius;
			float num7 = /*Error near IL_0019: Stack underflow*/* num6;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003801")]
		[Cpp2IlInjected.Address(RVA = "0xF075D0", Offset = "0xF05FD0", VA = "0x180F075D0")]
		public OrbitCameraConfig()
		{
		}
	}
}
