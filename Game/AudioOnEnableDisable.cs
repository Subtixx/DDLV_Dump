using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AudioOnEnableDisable : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public AK.Wwise.Event soundToPlayOnEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public AK.Wwise.Event soundToStopOnDisable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public GameObject audioEmitter;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1505720", Offset = "0x1504120", VA = "0x181505720")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_0017
		AK.Wwise.Event @event = soundToPlayOnEnable;
		GameObject gameObject = audioEmitter;
		uint num = @event.Post(gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x15056F0", Offset = "0x15040F0", VA = "0x1815056F0")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_0017
		AK.Wwise.Event @event = soundToStopOnDisable;
		GameObject gameObject = audioEmitter;
		uint num = @event.Post(gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioOnEnableDisable()
	{
	}
}
