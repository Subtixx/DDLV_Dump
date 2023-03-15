using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Light sunLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public float minHeight = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float minShadowDistance = 80f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float minShadowBias = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float maxHeight = 1000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float maxShadowDistance = 10000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public float maxShadowBias = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float adaptTime = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private float m_SmoothHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private float m_ChangeSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private float m_OriginalStrength = 1f;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2F10290", Offset = "0x2F0EC90", VA = "0x182F10290")]
		private void Start()
		{
			//Discarded unreachable code: IL_0014
			float num = (m_OriginalStrength = sunLight.shadowStrength);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2F102C0", Offset = "0x2F0ECC0", VA = "0x182F102C0")]
		private void Update()
		{
			//Discarded unreachable code: IL_00ca
			//IL_00be: Expected F4, but got I4
			int num = 0;
			Transform transform = Camera.main.transform;
			int num2 = 0;
			int num3 = 0;
			float z = Vector3.up.z;
			int num4 = 0;
			Transform transform2 = base.transform;
			bool flag = default(bool);
			if (flag)
			{
			}
			float num5 = default(float);
			m_SmoothHeight = num5;
			float b = maxHeight;
			float num6 = Mathf.InverseLerp(minHeight, b, num5);
			float b2 = maxShadowDistance;
			num5 = num6;
			QualitySettings.shadowDistance = Mathf.Lerp(minShadowDistance, b2, num5);
			float b3 = maxShadowBias;
			float a = minShadowBias;
			Light light = sunLight;
			b3 = (light.shadowBias = Mathf.Lerp(a, b3, 1f));
			float originalStrength = m_OriginalStrength;
			Light light2 = sunLight;
			int num8 = 0;
			float num10 = (light2.shadowStrength = Mathf.Lerp(originalStrength, num8, num6));
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2F10520", Offset = "0x2F0EF20", VA = "0x182F10520")]
		public DynamicShadowSettings()
		{
		}
	}
}
