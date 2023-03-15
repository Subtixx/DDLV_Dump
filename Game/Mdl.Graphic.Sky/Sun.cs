using System;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004D4")]
	[ExecuteAlways]
	[RequireComponent(typeof(Light))]
	public class Sun : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4001E3D")]
		public static float size;

		[Cpp2IlInjected.Token(Token = "0x4001E3E")]
		public static Color color;

		[Cpp2IlInjected.Token(Token = "0x4001E3F")]
		public static Vector3 direction;

		[Cpp2IlInjected.Token(Token = "0x4001E40")]
		public static Color lightColor;

		[Cpp2IlInjected.Token(Token = "0x4001E41")]
		public static Vector3 lightOffset;

		[Cpp2IlInjected.Token(Token = "0x4001E42")]
		public static float lightIntensity;

		[Cpp2IlInjected.Token(Token = "0x4001E43")]
		public static float shadowStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E44")]
		private bool lightEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E45")]
		private Camera playerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E46")]
		private Light _light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E47")]
		private Vector3[] corners = new Vector3[4];

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		public Light light
		{
			[Cpp2IlInjected.Token(Token = "0x600153E")]
			[Cpp2IlInjected.Address(RVA = "0x1066250", Offset = "0x1064C50", VA = "0x181066250")]
			get
			{
				//IL_0010: Expected O, but got I4
				Light light = _light;
				int num = 0;
				if (light == (UnityEngine.Object)num)
				{
					Light light2 = (_light = GetComponent<Light>());
				}
				return _light;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600153F")]
		[Cpp2IlInjected.Address(RVA = "0x1065C80", Offset = "0x1064680", VA = "0x181065C80")]
		protected void OnEnable()
		{
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
			}
			playerCamera = (Camera)(object)_003CInstance_003Ek__BackingField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001540")]
		[Cpp2IlInjected.Address(RVA = "0x1065D40", Offset = "0x1064740", VA = "0x181065D40")]
		private void Update()
		{
			//Discarded unreachable code: IL_00c7
			//IL_0012: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0074: Expected I4, but got O
			//IL_0089: Expected O, but got I4
			Camera camera = playerCamera;
			int num = 0;
			int num2 = 0;
			if (!(camera != (UnityEngine.Object)num2))
			{
				int num3 = 0;
				int num4 = 0;
				base.transform.SetPositionAndRotation((Vector3)num4, (Quaternion)num3);
				Transform transform = base.transform;
				int num5 = 0;
				Vector3 one = Vector3.one;
				transform.localScale = (Vector3)num5;
			}
			Camera camera2 = playerCamera;
			float num6 = size;
			SetPosFromCamera(camera2, (Vector3)num, num6);
			Light light = this.light;
			float num7 = lightIntensity;
			lightEnable = (byte)(int)camera2 != 0;
			if ((object)camera2 != null)
			{
				int num8 = 0;
				this.light.color = (Color)num8;
				Light light2 = this.light;
				float num10 = (light2.intensity = lightIntensity);
				Light light3 = this.light;
				float num12 = (light3.shadowStrength = shadowStrength);
				Transform transform2 = this.light.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001541")]
		[Cpp2IlInjected.Address(RVA = "0xEFB820", Offset = "0xEFA220", VA = "0x180EFB820")]
		protected unsafe void SetPosFromCamera(Camera camera, Vector3 direction, float size)
		{
			//Discarded unreachable code: IL_00a6
			//IL_0038: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			int num = 0;
			float farClipPlane = camera.farClipPlane;
			int num2 = 0;
			float num3 = farClipPlane * 0.8f;
			Vector2 zero = Vector2.zero;
			int num4 = 0;
			Vector2 one = Vector2.one;
			Vector3[] outCorners = corners;
			camera.CalculateFrustumCorners((Rect)num, num3, Camera.MonoOrStereoscopicEye.Mono, outCorners);
			Transform transform = camera.transform;
			float z = direction.z;
			farClipPlane = num3;
			int num5 = 0;
			Vector3 one2 = Vector3.one;
			Vector3[] array = corners;
			int length = array.Length;
			float num6 = Vector3.Distance((Vector3)array, (Vector3)num5);
			float magnitude = ((Vector3*)direction)->magnitude;
			int num7 = 0;
			Quaternion quaternion = Quaternion.LookRotation(direction);
			int num8 = 0;
			base.transform.SetPositionAndRotation((Vector3)num8, (Quaternion)num7);
			int num9 = 0;
			base.transform.localScale = (Vector3)num9;
		}

		[Cpp2IlInjected.Token(Token = "0x6001542")]
		[Cpp2IlInjected.Address(RVA = "0xEFBB30", Offset = "0xEFA530", VA = "0x180EFBB30")]
		protected void SetPosWithoutCamera(Vector3 direction, float size)
		{
			//Discarded unreachable code: IL_002b
			//IL_0011: Expected O, but got I4
			//IL_0011: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			base.transform.SetPositionAndRotation((Vector3)num2, (Quaternion)num);
			Transform transform = base.transform;
			int num3 = 0;
			Vector3 one = Vector3.one;
			transform.localScale = (Vector3)num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001543")]
		[Cpp2IlInjected.Address(RVA = "0x10661F0", Offset = "0x1064BF0", VA = "0x1810661F0")]
		public Sun()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001544")]
		[Cpp2IlInjected.Address(RVA = "0x1066170", Offset = "0x1064B70", VA = "0x181066170")]
		static Sun()
		{
			float z = Vector3.down.z;
			float z2 = Vector3.down.z;
		}
	}
}
