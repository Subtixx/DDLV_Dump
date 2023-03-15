using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AudioRTPCBiome : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public GameObject gameobject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public RTPC RTPCBiome;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float RTPCValue = 100f;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1506020", Offset = "0x1504A20", VA = "0x181506020")]
	private void OnTriggerEnter(Collider mainCollider)
	{
		//Discarded unreachable code: IL_002c
		if (mainCollider.CompareTag("MainCamera"))
		{
			RTPC rTPCBiome = RTPCBiome;
			float rTPCValue = RTPCValue;
			GameObject gameObject = gameobject;
			rTPCBiome.SetValue(gameObject, rTPCValue);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x15060A0", Offset = "0x1504AA0", VA = "0x1815060A0")]
	private void OnTriggerExit(Collider mainCollider)
	{
		//Discarded unreachable code: IL_0029
		if (mainCollider.CompareTag("MainCamera"))
		{
			RTPC rTPCBiome = RTPCBiome;
			GameObject gameObject = gameobject;
			rTPCBiome.SetValue(gameObject, 100f);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1506120", Offset = "0x1504B20", VA = "0x181506120")]
	public AudioRTPCBiome()
	{
	}
}
