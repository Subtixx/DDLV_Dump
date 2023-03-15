using System;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Utils;
using Meta.Util;
using UnityEngine;

namespace Mdl.Navigation.ControlSchemes
{
	[Cpp2IlInjected.Token(Token = "0x2000C98")]
	public static class ControlSchemesUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6003A56")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92570", VA = "0x180A93B70")]
		public unsafe static Vector3 GetDesiredVelocity(Vector2 axes, PlayerAvatar avatar, Camera camera, float deltaTime, PlayerNavigationConfig playerConfig, bool applyAcceleration = true)
		{
			//IL_0009: Expected F4, but got I4
			//IL_0004: Expected native int or pointer, but got O
			//IL_0028: Expected F4, but got I4
			//IL_0028: Expected F4, but got I4
			//IL_0031: Invalid comparison between F4 and I4
			//IL_0037: Invalid comparison between F4 and I4
			//IL_0049: Invalid comparison between F4 and I4
			//IL_004f: Invalid comparison between I4 and F4
			int num = 0;
			((Vector2*)(IntPtr)axes)->x = num;
			int num2 = 0;
			float z = Vector3.zero.z;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			float value = default(float);
			float num6 = Mathf.Clamp(value, num4, num3);
			int num7 = 0;
			if (!(num6 > (float)num5))
			{
				if (num6 <= (float)num5)
				{
					goto IL_0065;
				}
				num6 = deltaTime;
			}
			float value2 = default(float);
			float num8 = Mathf.Clamp01(value2);
			float num9 = default(float);
			if (!(num9 > (float)num5))
			{
				if ((float)num5 <= num9)
				{
					goto IL_0059;
				}
				num9 = num6;
			}
			float num10 = default(float);
			num9 = num10;
			goto IL_0059;
			IL_0059:
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			num8 = deltaTime;
			goto IL_0065;
			IL_0065:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A57")]
		[Cpp2IlInjected.Address(RVA = "0xA93F20", Offset = "0xA92920", VA = "0x180A93F20")]
		public unsafe static Vector3 MoveWithAxes(Vector2 axes, PlayerAvatar avatar, Camera camera, float deltaTime, PlayerNavigationConfig playerConfig)
		{
			//IL_0009: Expected F4, but got I4
			//IL_0004: Expected native int or pointer, but got O
			//IL_0017: Invalid comparison between F4 and I4
			int num = 0;
			((Vector2*)(IntPtr)axes)->x = num;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num2 = 0;
			float num3 = default(float);
			if (!(num3 > (float)num2))
			{
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag || !flag2)
				{
					goto IL_0035;
				}
				int num4 = 0;
			}
			int num5 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			bool flag3 = default(bool);
			if (!flag3)
			{
			}
			goto IL_0035;
			IL_0035:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A58")]
		[Cpp2IlInjected.Address(RVA = "0xA940B0", Offset = "0xA92AB0", VA = "0x180A940B0")]
		public static float SteerPitch(float deltaTime, float desiredPitch, Camera camera, CameraNavigationConfig cameraConfig)
		{
			//Discarded unreachable code: IL_0034
			int num = 0;
			float deltaTime2 = Time.deltaTime;
			float followPitchMaxForce = cameraConfig.followPitchMaxForce;
			Transform transform = camera.transform;
			Angle angle = Angle.FromDegrees(desiredPitch);
			float value = default(float);
			float result = Mathf.Clamp(value, desiredPitch, followPitchMaxForce);
			Transform transform2 = camera.transform;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A59")]
		[Cpp2IlInjected.Address(RVA = "0xA93740", Offset = "0xA92140", VA = "0x180A93740")]
		public static float FollowCameraDesiredPitch(PlayerAvatar avatar, Camera camera, CameraNavigationConfig cameraConfig, PlayerNavigationConfig playerConfig, bool ignoreAxis = true)
		{
			//Discarded unreachable code: IL_0055
			//IL_0023: Invalid comparison between F4 and I4
			Vector3 zero = Vector3.zero;
			int num = 0;
			float axis = Input.GetAxis(playerConfig.horizontalAxis);
			float axis2 = Input.GetAxis(playerConfig.verticalAxis);
			float num2 = default(float);
			if (!(num2 <= (float)num))
			{
				Vector3 forward = Vector3.forward;
			}
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float followMinPitch = cameraConfig.followMinPitch;
			float t = default(float);
			return Mathf.Lerp(cameraConfig.followMaxPitch, followMinPitch, t);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5A")]
		[Cpp2IlInjected.Address(RVA = "0xA941E0", Offset = "0xA92BE0", VA = "0x180A941E0")]
		public static float TurntableCameraDesiredPitch(float zoom, float followPitch, CameraNavigationConfig cameraConfig)
		{
			//Discarded unreachable code: IL_0041
			//IL_001f: Expected F4, but got I4
			double num = Math.Log(zoom, followPitch);
			int num2 = 0;
			AnimationCurve zoomPitchInterpolationCurve = cameraConfig.zoomPitchInterpolationCurve;
			float zoomOutPitch = cameraConfig.zoomOutPitch;
			float num3 = zoomPitchInterpolationCurve.Evaluate(num2);
			float num4 = Mathf.Lerp(num3, zoomOutPitch, num3);
			zoomOutPitch = num4;
			num4 = followPitch;
			num3 = zoom;
			return Mathf.Lerp(num4, zoomOutPitch, num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5B")]
		[Cpp2IlInjected.Address(RVA = "0xA939A0", Offset = "0xA923A0", VA = "0x180A939A0")]
		public static float FreeCameraDesiredPitchWithOverride(PlayerAvatar avatar, Camera camera, float height, float defaultHeight, CameraNavigationConfig cameraConfig, PlayerNavigationConfig playerConfig)
		{
			//Discarded unreachable code: IL_0075
			//IL_0026: Expected O, but got I4
			float num = Mathf.Clamp01(defaultHeight);
			num = defaultHeight;
			float num2 = Mathf.Lerp(height, num, height);
			CameraOverrideZone cameraOverrideZone = avatar.cameraOverrideZone;
			int num3 = 0;
			if (cameraOverrideZone != (UnityEngine.Object)num3)
			{
				CameraOverrideZone cameraOverrideZone2 = avatar.cameraOverrideZone;
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				float pitch = cameraOverrideZone2.GetPitch(_003Ctransform_003Ek__BackingField, ControlSchemeType.FreeCameraControl);
				CameraOverrideZone cameraOverrideZone3 = avatar.cameraOverrideZone;
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				float strength = cameraOverrideZone3.GetStrength(_003Ctransform_003Ek__BackingField2, camera);
				strength = height;
				num = defaultHeight;
				float num4 = Mathf.Lerp(strength, num, height);
			}
			return height;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5C")]
		[Cpp2IlInjected.Address(RVA = "0xA93AF0", Offset = "0xA924F0", VA = "0x180A93AF0")]
		public static float FreeCameraDesiredPitch(float height, float defaultHeight, CameraNavigationConfig cameraConfig, PlayerNavigationConfig playerConfig)
		{
			//Discarded unreachable code: IL_002c
			//IL_0006: Expected O, but got F4
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected F4, but got Unknown
			//IL_000e: Expected O, but got F4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected F4, but got Unknown
			float minZoom = ((CameraNavigationConfig)defaultHeight).minZoom;
			float num = /*Error near IL_0007: Stack underflow*/* minZoom;
			float maxZoom = ((CameraNavigationConfig)defaultHeight).maxZoom;
			float num2 = /*Error near IL_000f: Stack underflow*/* maxZoom;
			AnimationCurve zoomPitchInterpolationCurve = cameraConfig.zoomPitchInterpolationCurve;
			num = height;
			float num3 = zoomPitchInterpolationCurve.Evaluate(num);
			num2 = num3;
			return Mathf.Lerp(num3, num, num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5D")]
		[Cpp2IlInjected.Address(RVA = "0xA93700", Offset = "0xA92100", VA = "0x180A93700")]
		public static float DefaultHeight(float initialHeight, CameraNavigationConfig cameraConfig)
		{
			//Discarded unreachable code: IL_001f
			//IL_000d: Expected O, but got F4
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected F4, but got Unknown
			float minZoom = cameraConfig.minZoom;
			float maxZoom = ((CameraNavigationConfig)initialHeight).maxZoom;
			float b = /*Error near IL_000e: Stack underflow*/* maxZoom;
			float defaultZoom = cameraConfig.defaultZoom;
			return Mathf.Lerp(minZoom, b, defaultZoom);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5E")]
		[Cpp2IlInjected.Address(RVA = "0xA93290", Offset = "0xA91C90", VA = "0x180A93290")]
		public static Vector2 CameraHorizontalOffset(PlayerAvatar avatar, Camera camera, CameraNavigationConfig cameraConfig, float zoomAmount)
		{
			//Discarded unreachable code: IL_01f1
			//IL_0048: Invalid comparison between I4 and F4
			//IL_00a6: Expected O, but got I4
			//IL_01c1: Expected F4, but got I4
			Transform transform = camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Transform transform2 = camera.transform;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			Vector3 vector5 = default(Vector3);
			if (!(0f <= vector5.y))
			{
			}
			float followOffsetXRadiusAtMax = cameraConfig.followOffsetXRadiusAtMax;
			float num = Mathf.Lerp(cameraConfig.followOffsetXRadiusAtMin, followOffsetXRadiusAtMax, zoomAmount);
			float followOffsetZRadiusAtMax = cameraConfig.followOffsetZRadiusAtMax;
			float num2 = Mathf.Lerp(cameraConfig.followOffsetZRadiusAtMin, followOffsetZRadiusAtMax, zoomAmount);
			float followOffsetForwardOffsetAtMax = cameraConfig.followOffsetForwardOffsetAtMax;
			float num3 = Mathf.Lerp(cameraConfig.followOffsetForwardOffsetAtMin, followOffsetForwardOffsetAtMax, zoomAmount);
			CameraOverrideZone cameraOverrideZone = avatar.cameraOverrideZone;
			int num4 = 0;
			float num11;
			float offsetRightOffsetAtMax;
			if (cameraOverrideZone != (UnityEngine.Object)num4)
			{
				CameraOverrideZone cameraOverrideZone2 = avatar.cameraOverrideZone;
				Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
				float strength = cameraOverrideZone2.GetStrength(_003Ctransform_003Ek__BackingField3, camera);
				CameraOverrideZoneConfig config = avatar.cameraOverrideZone.config;
				float offsetXRadiusAtMax = config.offsetXRadiusAtMax;
				float num5 = Mathf.Lerp(config.offsetXRadiusAtMin, offsetXRadiusAtMax, zoomAmount);
				offsetXRadiusAtMax = num5;
				num5 = num;
				float num6 = Mathf.Lerp(num5, offsetXRadiusAtMax, zoomAmount);
				CameraOverrideZone cameraOverrideZone3 = avatar.cameraOverrideZone;
				num = num6;
				CameraOverrideZoneConfig config2 = cameraOverrideZone3.config;
				float offsetZRadiusAtMax = config2.offsetZRadiusAtMax;
				float num7 = Mathf.Lerp(config2.offsetZRadiusAtMin, offsetZRadiusAtMax, zoomAmount);
				offsetZRadiusAtMax = num7;
				num7 = num2;
				float num8 = Mathf.Lerp(num7, offsetZRadiusAtMax, zoomAmount);
				CameraOverrideZone cameraOverrideZone4 = avatar.cameraOverrideZone;
				num2 = num8;
				CameraOverrideZoneConfig config3 = cameraOverrideZone4.config;
				float offsetForwardOffsetAtMax = config3.offsetForwardOffsetAtMax;
				float num9 = Mathf.Lerp(config3.offsetForwardOffsetAtMin, offsetForwardOffsetAtMax, zoomAmount);
				offsetForwardOffsetAtMax = num9;
				num9 = num3;
				float num10 = Mathf.Lerp(num9, offsetForwardOffsetAtMax, zoomAmount);
				CameraOverrideZone cameraOverrideZone5 = avatar.cameraOverrideZone;
				num3 = num10;
				CameraOverrideZoneConfig config4 = cameraOverrideZone5.config;
				offsetRightOffsetAtMax = config4.offsetRightOffsetAtMax;
				offsetRightOffsetAtMax = Mathf.Lerp(config4.offsetRightOffsetAtMin, offsetRightOffsetAtMax, zoomAmount);
				num11 = Mathf.Lerp(0f, offsetRightOffsetAtMax, zoomAmount);
			}
			int num12 = 0;
			Vector2 zero = Vector2.zero;
			float num13 = default(float);
			num11 = num13;
			Angle angle = Angle.FromDegrees(num11);
			offsetRightOffsetAtMax = num;
			int num14 = 0;
			Vector2 up = Vector2.up;
			int num15 = 0;
			return Vector2.right;
		}
	}
}
