using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public float multiplier = 1f;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C5F0", Offset = "0x2F1AFF0", VA = "0x182F1C5F0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0088
			//IL_0030: Expected O, but got F4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected F4, but got Unknown
			int num = 0;
			ParticleSystem[] componentsInChildren = GetComponentsInChildren<ParticleSystem>();
			int length = componentsInChildren.Length;
			if (num < length)
			{
				ParticleSystem particleSystem = componentsInChildren[num];
				ParticleSystem.MainModule main = particleSystem.main;
				float num2 = ((ParticleSystemMultiplier)ParticleSystem.MainModule.get_startSizeMultiplier_Injected(ref *(ParticleSystem.MainModule*)main)).multiplier;
				float value = /*Error near IL_0031: Stack underflow*/* num2;
				ParticleSystem.MainModule.set_startSizeMultiplier_Injected(ref *(ParticleSystem.MainModule*)main, value);
				float num3 = ParticleSystem.MainModule.get_startSpeedMultiplier_Injected(ref *(ParticleSystem.MainModule*)main);
				ParticleSystem.MainModule.set_startSpeedMultiplier_Injected(ref *(ParticleSystem.MainModule*)main, value);
				float num4 = ParticleSystem.MainModule.get_startLifetimeMultiplier_Injected(ref *(ParticleSystem.MainModule*)main);
				float value2 = Mathf.Lerp(multiplier, 1f, 0.5f);
				ParticleSystem.MainModule.set_startLifetimeMultiplier_Injected(ref *(ParticleSystem.MainModule*)main, value2);
				particleSystem.Clear();
				particleSystem.Play();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x83A300", Offset = "0x838D00", VA = "0x18083A300")]
		public ParticleSystemMultiplier()
		{
		}
	}
}
