using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AudioTriggerZoneWithName : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public string gameObjectAssociated = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public string nameComponentToEnable = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private GameObject objectToFind;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x150B140", Offset = "0x1509B40", VA = "0x18150B140")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_0057
		//IL_0023: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		GameObject gameObject = (objectToFind = GameObject.Find(gameObjectAssociated));
		GameObject gameObject2 = objectToFind;
		int num = 0;
		if (gameObject2 != (Object)num)
		{
			GameObject gameObject3 = objectToFind;
			string type = nameComponentToEnable;
			Component componentByName = gameObject3.GetComponentByName(type);
			if ((object)componentByName == null)
			{
			}
			int num2 = 0;
			int num3 = 0;
			if (!(componentByName != (Object)num3))
			{
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x150B280", Offset = "0x1509C80", VA = "0x18150B280")]
	public AudioTriggerZoneWithName()
	{
	}
}
