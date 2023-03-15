using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AudioEnableRespawn : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public GameObject akRoom;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Start()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Update()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA4EF60", Offset = "0xA4D960", VA = "0x180A4EF60")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_001c
		GameObject original = akRoom;
		Transform parent = base.gameObject.transform;
		GameObject gameObject = Object.Instantiate(original, parent);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4D8D0", VA = "0x180A4EED0")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_0011
		Object.Destroy(GetComponentInChildren<AkRoom>().gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioEnableRespawn()
	{
	}
}
