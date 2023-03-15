using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AudioSnbkLoadOnCollider : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Bank[] banksToLoad = new Bank[0];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public string triggerObjectTag = "MainCamera";

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1509460", Offset = "0x1507E60", VA = "0x181509460")]
	private void OnTriggerEnter(Collider other)
	{
		//Discarded unreachable code: IL_0044
		string text = triggerObjectTag;
		if (other.CompareTag(text))
		{
			Bank[] array = banksToLoad;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				Bank bank = array[num];
				int saveDecodedBank = 0;
				int decodeBank = 0;
				bank.Load((byte)decodeBank != 0, (byte)saveDecodedBank != 0);
				num++;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x15094F0", Offset = "0x1507EF0", VA = "0x1815094F0")]
	private void OnTriggerExit(Collider other)
	{
		//Discarded unreachable code: IL_0036
		string text = triggerObjectTag;
		if (other.CompareTag(text))
		{
			Bank[] array = banksToLoad;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Unload();
				num++;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1509400", Offset = "0x1507E00", VA = "0x181509400")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_0025
		Bank[] array = banksToLoad;
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			array[num].Unload();
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1509570", Offset = "0x1507F70", VA = "0x181509570")]
	public AudioSnbkLoadOnCollider()
	{
	}
}
