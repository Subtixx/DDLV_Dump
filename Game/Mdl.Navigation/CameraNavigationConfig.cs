using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C23")]
	[CreateAssetMenu]
	public class CameraNavigationConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000C24")]
		public class CameraPreset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40043C3")]
			public bool activeByDefault;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40043C4")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40043C5")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40043C6")]
			public float transitionDuration;

			[Cpp2IlInjected.Token(Token = "0x6003747")]
			[Cpp2IlInjected.Address(RVA = "0x13E4460", Offset = "0x13E2E60", VA = "0x1813E4460")]
			public CameraPreset()
			{
				Quaternion identity = Quaternion.identity;
				transitionDuration = 1f;
				base._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400439B")]
		[Tooltip("Expresses the speed at which the resulting delta will stop moving after touch release. A Friction of 1 means immediate stopping, 0 means no stopping at all.")]
		[Range(0f, 1f)]
		public float moveFriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400439C")]
		public float panMaxPosOnGroundAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400439D")]
		public float obstacleClimbSmoothness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400439E")]
		public float zoomSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400439F")]
		public float zoomAnalogSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40043A0")]
		public float minZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40043A1")]
		public float maxZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40043A2")]
		[Range(0f, 1f)]
		public float defaultZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40043A3")]
		public bool automaticPitchCalculation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40043A4")]
		public float zoomInPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40043A5")]
		public float zoomOutPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40043A6")]
		public AnimationCurve zoomPitchInterpolationCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40043A7")]
		public float minManualPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40043A8")]
		public float maxManualPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40043A9")]
		[Range(0f, 1f)]
		public float zoomModifierAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40043AA")]
		public float bounceDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40043AB")]
		public float floorBounceAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40043AC")]
		public float ceilingBounceAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40043AD")]
		public float followOffsetXRadiusAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40043AE")]
		public float followOffsetZRadiusAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40043AF")]
		public float followOffsetForwardOffsetAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40043B0")]
		public float followOffsetXRadiusAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40043B1")]
		public float followOffsetZRadiusAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40043B2")]
		public float followOffsetForwardOffsetAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40043B3")]
		public float followMaxVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40043B4")]
		public float followMaxForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40043B5")]
		public float followSlowDownRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40043B6")]
		public float followMinPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40043B7")]
		public float followMaxPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40043B8")]
		public float followPitchMaxForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40043B9")]
		public float transitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40043BA")]
		public bool allowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40043BB")]
		public float rotationMaxForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40043BC")]
		public float rotationFriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40043BD")]
		public bool useBezierTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40043BE")]
		public float bezierTransitionMinimumDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40043BF")]
		public AnimationCurve bezierTransitionSpeedCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40043C0")]
		public AnimationCurve bezierTransitionMovementHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40043C1")]
		public List<CameraPreset> hookedCameraPresets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40043C2")]
		public OrbitCameraConfig orbitCameraConfig;

		[Cpp2IlInjected.Token(Token = "0x6003745")]
		[Cpp2IlInjected.Address(RVA = "0x164DBB0", Offset = "0x164C5B0", VA = "0x18164DBB0")]
		public CameraNavigationConfig Clone()
		{
			//Discarded unreachable code: IL_01ec
			CameraNavigationConfig cameraNavigationConfig = ScriptableObject.CreateInstance<CameraNavigationConfig>();
			float num = (cameraNavigationConfig.moveFriction = moveFriction);
			float num2 = (cameraNavigationConfig.obstacleClimbSmoothness = obstacleClimbSmoothness);
			float num3 = (cameraNavigationConfig.zoomSpeed = zoomSpeed);
			float num4 = (cameraNavigationConfig.minZoom = minZoom);
			float num5 = (cameraNavigationConfig.maxZoom = maxZoom);
			float num6 = (cameraNavigationConfig.zoomInPitch = zoomInPitch);
			float num7 = (cameraNavigationConfig.zoomOutPitch = zoomOutPitch);
			AnimationCurve animationCurve = (cameraNavigationConfig.zoomPitchInterpolationCurve = new AnimationCurve(zoomPitchInterpolationCurve.keys));
			float num8 = (cameraNavigationConfig.zoomModifierAtMin = zoomModifierAtMin);
			float num9 = (cameraNavigationConfig.bounceDuration = bounceDuration);
			float num10 = (cameraNavigationConfig.floorBounceAmount = floorBounceAmount);
			float num11 = (cameraNavigationConfig.ceilingBounceAmount = ceilingBounceAmount);
			float num12 = (cameraNavigationConfig.followOffsetXRadiusAtMin = followOffsetXRadiusAtMin);
			float num13 = (cameraNavigationConfig.followOffsetZRadiusAtMin = followOffsetZRadiusAtMin);
			float num14 = (cameraNavigationConfig.followOffsetForwardOffsetAtMin = followOffsetForwardOffsetAtMin);
			float num15 = (cameraNavigationConfig.followOffsetXRadiusAtMax = followOffsetXRadiusAtMax);
			float num16 = (cameraNavigationConfig.followOffsetZRadiusAtMax = followOffsetZRadiusAtMax);
			float num17 = (cameraNavigationConfig.followOffsetForwardOffsetAtMax = followOffsetForwardOffsetAtMax);
			float num18 = (cameraNavigationConfig.followMaxVelocity = followMaxVelocity);
			float num19 = (cameraNavigationConfig.followMaxForce = followMaxForce);
			float num20 = (cameraNavigationConfig.followSlowDownRadius = followSlowDownRadius);
			float num21 = (cameraNavigationConfig.followMinPitch = followMinPitch);
			float num22 = (cameraNavigationConfig.followMaxPitch = followMaxPitch);
			float num23 = (cameraNavigationConfig.followPitchMaxForce = followPitchMaxForce);
			float num24 = (cameraNavigationConfig.transitionDuration = transitionDuration);
			bool flag = (cameraNavigationConfig.allowRotation = allowRotation);
			bool flag2 = (cameraNavigationConfig.useBezierTransition = useBezierTransition);
			float num25 = (cameraNavigationConfig.bezierTransitionMinimumDuration = bezierTransitionMinimumDuration);
			AnimationCurve animationCurve2 = (cameraNavigationConfig.bezierTransitionSpeedCurve = bezierTransitionSpeedCurve);
			AnimationCurve animationCurve3 = (cameraNavigationConfig.bezierTransitionMovementHeight = bezierTransitionMovementHeight);
			return cameraNavigationConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x6003746")]
		[Cpp2IlInjected.Address(RVA = "0x164DD80", Offset = "0x164C780", VA = "0x18164DD80")]
		public CameraNavigationConfig()
		{
			//IL_008a: Expected F4, but got I4
			//IL_008a: Expected F4, but got I4
			int num = 0;
			moveFriction = 0.5f;
			int num2 = 0;
			panMaxPosOnGroundAngle = 10f;
			obstacleClimbSmoothness = 0.5f;
			zoomSpeed = 1f;
			zoomAnalogSpeed = 0.66f;
			minZoom = 0.5f;
			maxZoom = 1.5f;
			defaultZoom = 0.5f;
			automaticPitchCalculation = true;
			zoomInPitch = 30f;
			zoomOutPitch = 40f;
			zoomPitchInterpolationCurve = AnimationCurve.Linear(num2, num, 1f, 1f);
			minManualPitch = 10f;
			maxManualPitch = 80f;
			zoomModifierAtMin = 0.5f;
			bounceDuration = 0.2f;
			floorBounceAmount = 1f;
			ceilingBounceAmount = 2f;
			followOffsetXRadiusAtMin = 1f;
			followOffsetZRadiusAtMin = 1f;
			followOffsetForwardOffsetAtMin = 1f;
			followOffsetXRadiusAtMax = 1f;
			followOffsetZRadiusAtMax = 1f;
			followOffsetForwardOffsetAtMax = 1f;
			followMaxVelocity = 100f;
			followMaxForce = 20f;
			followSlowDownRadius = 10f;
			followMinPitch = 20f;
			followMaxPitch = 35f;
			followPitchMaxForce = 20f;
			transitionDuration = 1f;
			allowRotation = true;
			rotationMaxForce = 40f;
			rotationFriction = 0.5f;
			bezierTransitionMinimumDuration = 1f;
			bezierTransitionSpeedCurve = new AnimationCurve();
			bezierTransitionMovementHeight = new AnimationCurve();
			hookedCameraPresets = (List<CameraPreset>)(object)new List<T>();
			base._002Ector();
		}
	}
}
