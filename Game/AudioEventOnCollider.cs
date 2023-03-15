using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AudioEventOnCollider : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public AK.Wwise.Event wwiseEventOnEnter;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA4F000", Offset = "0xA4DA00", VA = "0x180A4F000")]
	private void OnTriggerEnter(Collider other)
	{
		//Discarded unreachable code: IL_0025
		if (other.CompareTag("MainCamera"))
		{
			AK.Wwise.Event @event = wwiseEventOnEnter;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioEventOnCollider()
	{
	}
}
