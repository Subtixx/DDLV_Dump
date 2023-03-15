using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class SmokeParticles : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AudioClip[] extinguishSounds;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2270", Offset = "0x3DC0C70", VA = "0x183DC2270")]
		private void Start()
		{
			//Discarded unreachable code: IL_0038
			AudioSource component = GetComponent<AudioSource>();
			AudioClip[] array = extinguishSounds;
			int length = array.Length;
			length = Random.Range(0, length);
			AudioClip audioClip2 = (component.clip = array[length]);
			GetComponent<AudioSource>().Play();
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SmokeParticles()
		{
		}
	}
}
