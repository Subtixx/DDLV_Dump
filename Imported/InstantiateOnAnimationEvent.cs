using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000031")]
public class InstantiateOnAnimationEvent : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform target;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public GameObject[] prefab;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F15BF0", Offset = "0x2F145F0", VA = "0x182F15BF0")]
	public void Instantiate(int index)
	{
		//Discarded unreachable code: IL_004f
		GameObject[] array = prefab;
		if (array != null)
		{
			Transform transform = target;
			GameObject gameObject = array[index];
			Transform transform2 = target;
			GameObject gameObject2 = default(GameObject);
			Transform transform3 = gameObject2.transform;
			Transform transform4 = base.transform;
			Transform transform5 = gameObject2.transform;
			Transform transform6 = gameObject2.transform;
			Transform transform7 = gameObject2.transform;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public InstantiateOnAnimationEvent()
	{
	}
}
