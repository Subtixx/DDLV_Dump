using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000002")]
public class SimpleRotateWorld : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int speed = 10;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1EA12F0", Offset = "0x1E9FCF0", VA = "0x181EA12F0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0018
		Transform transform = base.transform;
		int num = 0;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E97E30", Offset = "0x1E96830", VA = "0x181E97E30")]
	public SimpleRotateWorld()
	{
	}//IL_000a: Expected I4, but got I8

}
