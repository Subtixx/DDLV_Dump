using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class FireLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private float m_Rnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private bool m_Burning = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private Light m_Light;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2F113D0", Offset = "0x2F0FDD0", VA = "0x182F113D0")]
		private void Start()
		{
			int num = 0;
			float num2 = (m_Rnd = Random.value * 100f);
			Light light = (m_Light = GetComponent<Light>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2F11430", Offset = "0x2F0FE30", VA = "0x182F11430")]
		private void Update()
		{
			//Discarded unreachable code: IL_00cf
			if (m_Burning)
			{
				Light light = m_Light;
				int num = 0;
				float time = Time.time;
				float rnd = m_Rnd;
				int num2 = 0;
				float time2 = Time.time;
				time2 = time;
				rnd = (light.intensity = Mathf.PerlinNoise(time2, rnd));
				int num4 = 0;
				float time3 = Time.time;
				int num5 = 0;
				time = time3;
				float time4 = Time.time;
				time4 = time;
				float num6 = Mathf.PerlinNoise(time4, time4);
				int num7 = 0;
				float time5 = Time.time;
				int num8 = 0;
				time = time5;
				float time6 = Time.time;
				time4 = time6;
				time6 = time;
				float num9 = Mathf.PerlinNoise(time6, time4);
				int num10 = 0;
				float time7 = Time.time;
				int num11 = 0;
				time = time7;
				float time8 = Time.time;
				time4 = time8;
				time8 = time;
				float num12 = Mathf.PerlinNoise(time8, time4);
				Transform transform = base.transform;
				float z = Vector3.up.z;
				num12 = time4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2F113A0", Offset = "0x2F0FDA0", VA = "0x182F113A0")]
		public void Extinguish()
		{
			//Discarded unreachable code: IL_0018
			m_Burning = false;
			Light light = m_Light;
			int num = ((light.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x13CD770", Offset = "0x13CC170", VA = "0x1813CD770")]
		public FireLight()
		{
		}
	}
}
