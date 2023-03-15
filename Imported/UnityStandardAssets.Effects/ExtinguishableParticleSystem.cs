using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public float multiplier = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private ParticleSystem[] m_Systems;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2F10AB0", Offset = "0x2F0F4B0", VA = "0x182F10AB0")]
		private void Start()
		{
			ParticleSystem[] array = (m_Systems = GetComponentsInChildren<ParticleSystem>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2F10A30", Offset = "0x2F0F430", VA = "0x182F10A30")]
		public void Extinguish()
		{
			//Discarded unreachable code: IL_0026
			ParticleSystem[] systems = m_Systems;
			int num = 0;
			int length = systems.Length;
			if (num < length)
			{
				ParticleSystem.MainModule main = systems[num].main;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x83A300", Offset = "0x838D00", VA = "0x18083A300")]
		public ExtinguishableParticleSystem()
		{
		}
	}
}
