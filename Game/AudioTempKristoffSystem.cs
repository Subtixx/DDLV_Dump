using System;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AudioTempKristoffSystem : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public GameObject Zone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public string characterName = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public State beforeQuest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public State afterQuest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public RTPC wolRTPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private GameObject character;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Vector3 character_position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool firstTime = true;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x150A9C0", Offset = "0x15093C0", VA = "0x18150A9C0")]
	private void Start()
	{
		//Discarded unreachable code: IL_000c
		afterQuest.SetValue();
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x150A3D0", Offset = "0x1508DD0", VA = "0x18150A3D0")]
	private unsafe void OnTriggerEnter(Collider otherObject)
	{
		//Discarded unreachable code: IL_0151
		//IL_002d: Expected O, but got I4
		//IL_0051: Expected native int or pointer, but got O
		string text = characterName;
		int num = 0;
		int num2 = 0;
		GameObject gameObject = (character = GameObject.Find(text));
		GameObject gameObject2 = character;
		int num3 = 0;
		if (!(gameObject2 != (UnityEngine.Object)num3))
		{
			return;
		}
		Transform component = character.GetComponent<Transform>();
		Vector3 vector = default(Vector3);
		float z = vector.z;
		((Vector3*)(IntPtr)character_position)->z = z;
		if (otherObject.CompareTag("MainCamera"))
		{
			Collider component2 = Zone.GetComponent<Collider>();
			float z2 = character_position.z;
			bool flag = default(bool);
			if (flag)
			{
				RTPC rTPC = wolRTPC;
				GameObject gameObject3 = character;
				rTPC.SetValue(gameObject3, 100f);
				if (firstTime)
				{
					beforeQuest.SetValue();
					firstTime = false;
				}
				if (string.Equals(beforeQuest.ToString(), "Before"))
				{
					AKRESULT aKRESULT = AkSoundEngine.SetState("MusicState", "OFF");
				}
			}
		}
		string a = otherObject.name;
		string b = characterName;
		if (!string.Equals(a, b))
		{
			if (!otherObject.CompareTag("MainCamera"))
			{
				return;
			}
			Collider component3 = Zone.GetComponent<Collider>();
			float z3 = character_position.z;
			bool flag2 = default(bool);
			if (flag2)
			{
				return;
			}
		}
		afterQuest.SetValue();
		GameObject zone = Zone;
		int active = 0;
		zone.SetActive((byte)active != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x150A720", Offset = "0x1509120", VA = "0x18150A720")]
	private unsafe void OnTriggerExit(Collider otherObject)
	{
		//Discarded unreachable code: IL_00ff
		//IL_002d: Expected O, but got I4
		//IL_0051: Expected native int or pointer, but got O
		//IL_00a1: Expected F4, but got I4
		string text = characterName;
		int num = 0;
		int num2 = 0;
		GameObject gameObject = (character = GameObject.Find(text));
		GameObject gameObject2 = character;
		int num3 = 0;
		if (!(gameObject2 != (UnityEngine.Object)num3))
		{
			return;
		}
		Transform component = character.GetComponent<Transform>();
		Vector3 vector = default(Vector3);
		float z = vector.z;
		((Vector3*)(IntPtr)character_position)->z = z;
		if (otherObject.CompareTag("MainCamera"))
		{
			Collider component2 = Zone.GetComponent<Collider>();
			float z2 = character_position.z;
			bool flag = default(bool);
			if (flag)
			{
				RTPC rTPC = wolRTPC;
				GameObject gameObject3 = character;
				int num4 = 0;
				rTPC.SetValue(gameObject3, num4);
			}
			AKRESULT aKRESULT = AkSoundEngine.SetState("MusicState", "ON");
		}
		string a = otherObject.name;
		string b = characterName;
		if (string.Equals(a, b))
		{
			afterQuest.SetValue();
			AKRESULT aKRESULT2 = AkSoundEngine.SetState("MusicState", "ON");
			GameObject zone = Zone;
			int active = 0;
			zone.SetActive((byte)active != 0);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x150A360", Offset = "0x1508D60", VA = "0x18150A360")]
	private void OnDisable()
	{
		AKRESULT aKRESULT = AkSoundEngine.SetState("MusicState", "ON");
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x150A9E0", Offset = "0x15093E0", VA = "0x18150A9E0")]
	public AudioTempKristoffSystem()
	{
	}
}
