using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AudioPlayOnStart : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public AK.Wwise.Event soundToPlayOnStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public AK.Wwise.Event playOnDestroy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public GameObject audioEmitter;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1505720", Offset = "0x1504120", VA = "0x181505720")]
	private void Start()
	{
		//Discarded unreachable code: IL_0017
		AK.Wwise.Event @event = soundToPlayOnStart;
		GameObject gameObject = audioEmitter;
		uint num = @event.Post(gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x15056F0", Offset = "0x15040F0", VA = "0x1815056F0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_0017
		AK.Wwise.Event @event = playOnDestroy;
		GameObject gameObject = audioEmitter;
		uint num = @event.Post(gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioPlayOnStart()
	{
	}
}
