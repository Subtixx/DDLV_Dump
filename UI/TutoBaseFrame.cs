using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000061")]
public class TutoBaseFrame : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	[SerializeField]
	public GameObject BG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public GameObject Deco;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public GameObject ShadeBar;

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x17F3620", Offset = "0x17F2020", VA = "0x1817F3620")]
	public void SetGameGuideMode()
	{
		//Discarded unreachable code: IL_002d
		GameObject bG = BG;
		int active = 0;
		bG.SetActive((byte)active != 0);
		GameObject deco = Deco;
		int active2 = 0;
		deco.SetActive((byte)active2 != 0);
		ShadeBar.SetActive(value: true);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public TutoBaseFrame()
	{
	}
}
