using Cpp2IlInjected;
using Rewired;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class Hose : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public float maxPower = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public float minPower = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public float changeSpeed = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public ParticleSystem[] hoseWaterSystems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public Renderer systemRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private float m_Power;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F11E30", Offset = "0x2F10830", VA = "0x182F11E30")]
		private void Update()
		{
			//Discarded unreachable code: IL_00d3
			int num = 0;
			int num2 = 0;
			Mouse mouse = ReInput.controllers.Mouse;
			int index = 0;
			if (mouse.GetButton(index))
			{
			}
			float b = minPower;
			int num3 = 0;
			float deltaTime = Time.deltaTime;
			float t = changeSpeed;
			float num4 = (m_Power = Mathf.Lerp(deltaTime, b, t));
			int num5 = 0;
			if (ReInput.controllers.Keyboard.GetKeyDown(KeyCode.Alpha1))
			{
				Renderer renderer = systemRenderer;
				bool flag2 = (renderer.enabled = !renderer.enabled);
			}
			ParticleSystem[] array = hoseWaterSystems;
			int length = array.Length;
			if (num < length)
			{
				ParticleSystem particleSystem = array[num];
				ParticleSystem.MainModule main = particleSystem.main;
				AnimationCurve curveMax = ((ParticleSystem.MinMaxCurve)num4).m_CurveMax;
				ParticleSystem.MainModule main2 = particleSystem.main;
				float num6 = minPower;
				float power = m_Power;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2F12220", Offset = "0x2F10C20", VA = "0x182F12220")]
		public Hose()
		{
		}
	}
}
