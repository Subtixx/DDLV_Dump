using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000058")]
public class ParticleSystemManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Start()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Update()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xF0BDA0", Offset = "0xF0A7A0", VA = "0x180F0BDA0")]
	public static void Play(ParticleSystem system)
	{
		//Discarded unreachable code: IL_0007, IL_0008
		system.Play();
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xF0BE60", Offset = "0xF0A860", VA = "0x180F0BE60")]
	public static void Stop(ParticleSystem system)
	{
		//Discarded unreachable code: IL_0007
		system.Stop();
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ParticleSystemManager()
	{
	}
}
