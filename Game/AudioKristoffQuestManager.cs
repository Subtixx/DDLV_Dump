using System;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AudioKristoffQuestManager : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public string gameObjectAssociated = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public string secondGameObjectAssociated = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public string nameComponentToEnable = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public State questState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Switch shortAttenuation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Switch longAttenuation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private uint currentState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool firstTime = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private GameObject objectToFind;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private GameObject secondObjectToFind;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA4F080", Offset = "0xA4DA80", VA = "0x180A4F080")]
	private void OnEnable()
	{
		//IL_0093: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		State state = questState;
		uint num = currentState;
		uint id = state.Id;
		if (num != id)
		{
			Switch @switch = shortAttenuation;
			GameObject value = base.gameObject;
			@switch.SetValue(value);
			return;
		}
		Switch switch2 = longAttenuation;
		GameObject value2 = base.gameObject;
		switch2.SetValue(value2);
		while (!firstTime)
		{
		}
		GameObject gameObject = (objectToFind = GameObject.Find(gameObjectAssociated));
		GameObject gameObject2 = (secondObjectToFind = GameObject.Find(secondGameObjectAssociated));
		GameObject gameObject3 = objectToFind;
		int num2 = 0;
		bool flag = gameObject3 != (UnityEngine.Object)num2;
		int num3 = 0;
		if (flag)
		{
			GameObject gameObject4 = objectToFind;
			string type = nameComponentToEnable;
			Component componentByName = gameObject4.GetComponentByName(type);
			if ((object)componentByName == null)
			{
			}
			int num4 = 0;
			int num5 = 0;
			if (!(componentByName != (UnityEngine.Object)num5))
			{
			}
		}
		GameObject gameObject5 = secondObjectToFind;
		int num6 = 0;
		if (gameObject5 != (UnityEngine.Object)num6)
		{
			GameObject gameObject6 = secondObjectToFind;
			string type2 = nameComponentToEnable;
			Component componentByName2 = gameObject6.GetComponentByName(type2);
			if ((object)componentByName2 != null)
			{
				int num7 = 0;
			}
			int num8 = 0;
			if (!(componentByName2 != (UnityEngine.Object)num8))
			{
			}
		}
		firstTime = false;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA4F370", Offset = "0xA4DD70", VA = "0x180A4F370")]
	public AudioKristoffQuestManager()
	{
	}
}
