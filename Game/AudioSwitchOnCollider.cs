using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AudioSwitchOnCollider : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Switch[] switchOnEnter = new Switch[0];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Switch[] switchOnExit = new Switch[0];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public GameObject gameObjectSpecific;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x150A280", Offset = "0x1508C80", VA = "0x18150A280")]
	private void Start()
	{
		//Discarded unreachable code: IL_0031
		Switch[] array = switchOnExit;
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			Switch @switch = array[num];
			GameObject value = gameObjectSpecific;
			@switch.SetValue(value);
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x150A120", Offset = "0x1508B20", VA = "0x18150A120")]
	private void OnTriggerEnter(Collider other)
	{
		//Discarded unreachable code: IL_003f
		if (other.CompareTag("MainCamera"))
		{
			Switch[] array = switchOnEnter;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				Switch @switch = array[num];
				GameObject value = gameObjectSpecific;
				@switch.SetValue(value);
				num++;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x150A1D0", Offset = "0x1508BD0", VA = "0x18150A1D0")]
	private void OnTriggerExit(Collider other)
	{
		//Discarded unreachable code: IL_003f
		if (other.CompareTag("MainCamera"))
		{
			Switch[] array = switchOnExit;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				Switch @switch = array[num];
				GameObject value = gameObjectSpecific;
				@switch.SetValue(value);
				num++;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x150A2F0", Offset = "0x1508CF0", VA = "0x18150A2F0")]
	public AudioSwitchOnCollider()
	{
	}
}
