using System;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005EF")]
	public class TimelinePlayerCameraHolder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002417")]
		private GameObject cameraObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002418")]
		private Camera trackCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002419")]
		private Camera playerCamera;

		[Cpp2IlInjected.Token(Token = "0x6001A59")]
		[Cpp2IlInjected.Address(RVA = "0x13CF560", Offset = "0x13CDF60", VA = "0x1813CF560")]
		private void OnEnable()
		{
			GameObject gameObject = (cameraObj = SystemRoot.Instance._playerCamera.gameObject);
			Camera camera = (trackCamera = base.gameObject.GetComponent<Camera>());
			Camera camera2 = (playerCamera = cameraObj.GetComponent<Camera>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5A")]
		[Cpp2IlInjected.Address(RVA = "0x13CF510", Offset = "0x13CDF10", VA = "0x1813CF510")]
		private void OnDisable()
		{
			//IL_0009: Expected O, but got I8
			cameraObj = (GameObject)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5B")]
		[Cpp2IlInjected.Address(RVA = "0x13CF6A0", Offset = "0x13CE0A0", VA = "0x1813CF6A0")]
		private void Update()
		{
			//Discarded unreachable code: IL_00a2
			//IL_0010: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			GameObject gameObject = cameraObj;
			int num = 0;
			if (!(gameObject != (UnityEngine.Object)num))
			{
				return;
			}
			Transform transform = cameraObj.transform;
			Transform transform2 = base.gameObject.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform3 = cameraObj.transform;
			Transform transform4 = base.gameObject.transform;
			Camera camera = trackCamera;
			int num2 = 0;
			if (camera != (UnityEngine.Object)num2)
			{
				Camera camera2 = playerCamera;
				int num3 = 0;
				if (camera2 != (UnityEngine.Object)num3)
				{
					Camera camera3 = trackCamera;
					Camera camera4 = playerCamera;
					float num4 = (camera4.fieldOfView = camera3.fieldOfView);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelinePlayerCameraHolder()
		{
		}
	}
}
