using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200000A")]
public class SubEmitter_Controller : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ParticleSystem ps;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA1E00", Offset = "0x1EA0800", VA = "0x181EA1E00")]
	public void PlaySubEmitters()
	{
		//Discarded unreachable code: IL_0011
		ParticleSystem particleSystem = ps;
		int subEmitterIndex = 0;
		particleSystem.TriggerSubEmitter(subEmitterIndex);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public SubEmitter_Controller()
	{
	}
}
