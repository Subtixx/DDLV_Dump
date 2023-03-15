using System;
using Cpp2IlInjected;
using Meta.Util;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C41")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(BoxCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class CameraOverrideZone : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004476")]
		public CameraOverrideZoneConfig config;

		[Cpp2IlInjected.Token(Token = "0x17000787")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x600383A")]
			[Cpp2IlInjected.Address(RVA = "0x164F370", Offset = "0x164DD70", VA = "0x18164F370")]
			get
			{
				//IL_0015: Expected O, but got I4
				BoxCollider component = base.gameObject.GetComponent<BoxCollider>();
				int num = 0;
				if (component != (UnityEngine.Object)num)
				{
					BoxCollider component2 = base.gameObject.GetComponent<BoxCollider>();
					float result = default(float);
					return result;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000788")]
		public BoxCollider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x600383B")]
			[Cpp2IlInjected.Address(RVA = "0x164F320", Offset = "0x164DD20", VA = "0x18164F320")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.GetComponent<BoxCollider>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600383C")]
		[Cpp2IlInjected.Address(RVA = "0x164EE10", Offset = "0x164D810", VA = "0x18164EE10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0040
			BoxCollider component = base.gameObject.GetComponent<BoxCollider>();
			float num = Radius * 2f;
			float radius = Radius;
			float radius2 = Radius;
			component.isTrigger = true;
			base.gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600383D")]
		[Cpp2IlInjected.Address(RVA = "0x164EE10", Offset = "0x164D810", VA = "0x18164EE10")]
		private void InitCollider()
		{
			//Discarded unreachable code: IL_0040
			BoxCollider component = base.gameObject.GetComponent<BoxCollider>();
			float num = Radius * 2f;
			float radius = Radius;
			float radius2 = Radius;
			component.isTrigger = true;
			base.gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600383E")]
		[Cpp2IlInjected.Address(RVA = "0x164EF30", Offset = "0x164D930", VA = "0x18164EF30")]
		public float GetPitch(Transform avatar, ControlSchemeType controlSchemeType)
		{
			//Discarded unreachable code: IL_0059
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform = base.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			CameraOverrideZoneConfig cameraOverrideZoneConfig = config;
			float t = default(float);
			if (controlSchemeType != ControlSchemeType.FreeCameraControl)
			{
				float hookedPitchForward = cameraOverrideZoneConfig.hookedPitchForward;
				return Mathf.Lerp(cameraOverrideZoneConfig.hookedPitchBackward, hookedPitchForward, t);
			}
			float freePitchForward = cameraOverrideZoneConfig.freePitchForward;
			return Mathf.Lerp(cameraOverrideZoneConfig.freePitchBackward, freePitchForward, t);
		}

		[Cpp2IlInjected.Token(Token = "0x600383F")]
		[Cpp2IlInjected.Address(RVA = "0x164F030", Offset = "0x164DA30", VA = "0x18164F030")]
		public float GetStrength(Transform avatar, Camera camera)
		{
			//IL_004e: Expected F4, but got I4
			if (base.gameObject.activeInHierarchy)
			{
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				int num = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				CameraOverrideZoneConfig cameraOverrideZoneConfig = config;
				float strengthBackward = cameraOverrideZoneConfig.strengthBackward;
				float strengthForward = cameraOverrideZoneConfig.strengthForward;
				float num2 = Mathf.Lerp(strengthBackward, strengthForward, num);
				Transform transform3 = base.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				float radius = Radius;
				return config.strengthCurve.Evaluate(1f);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003840")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraOverrideZone()
		{
		}
	}
}
