using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public static float lastSoundTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public float force = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private List<ParticleCollisionEvent> m_CollisionEvents = (List<ParticleCollisionEvent>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private ParticleSystem m_ParticleSystem;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8450", Offset = "0x3DC6E50", VA = "0x183DC8450")]
		private void Start()
		{
			ParticleSystem particleSystem = (m_ParticleSystem = GetComponent<ParticleSystem>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8190", Offset = "0x3DC6B90", VA = "0x183DC8190")]
		private void OnParticleCollision(GameObject other)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DC84A0", Offset = "0x3DC6EA0", VA = "0x183DC84A0")]
		public WaterHoseParticles()
		{
		}
	}
}
