using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GymAnimationAudio : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public State roomType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Switch surfaceTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Switch surfaceWetness;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public GameObject characterAudioEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Bank[] wwiseSoundbanks = new Bank[0];

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public State villageState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public State streamingModeLicense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public RTPC avatarDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public RTPC avatarDistance100m;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public float avatarDistanceValue = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private GameObject characterSpawnPosition;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x154A590", Offset = "0x1548F90", VA = "0x18154A590")]
	private void Start()
	{
		//Discarded unreachable code: IL_00ac
		GameObject gameObject = (characterSpawnPosition = GameObject.Find("CharacterSpawnPosition"));
		roomType.SetValue();
		villageState.SetValue();
		streamingModeLicense.SetValue();
		Bank[] array = wwiseSoundbanks;
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
		RTPC rTPC = avatarDistance;
		float value = avatarDistanceValue;
		GameObject gameObject2 = characterAudioEmitter;
		rTPC.SetValue(gameObject2, value);
		RTPC rTPC2 = avatarDistance100m;
		float value2 = avatarDistanceValue;
		GameObject gameObject3 = characterAudioEmitter;
		rTPC2.SetValue(gameObject3, value2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x154A030", Offset = "0x1548A30", VA = "0x18154A030")]
	public void CharacterChanged()
	{
		//Discarded unreachable code: IL_012a
		//IL_00af: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		GameObject gameObject = (characterAudioEmitter = characterSpawnPosition.GetComponentInChildren<AkGameObj>().gameObject);
		Switch @switch = surfaceTexture;
		GameObject value = characterAudioEmitter;
		@switch.SetValue(value);
		Switch switch2 = surfaceWetness;
		GameObject value2 = characterAudioEmitter;
		switch2.SetValue(value2);
		RTPC rTPC = avatarDistance;
		float value3 = avatarDistanceValue;
		GameObject gameObject2 = characterAudioEmitter;
		rTPC.SetValue(gameObject2, value3);
		RTPC rTPC2 = avatarDistance100m;
		float value4 = avatarDistanceValue;
		GameObject gameObject3 = characterAudioEmitter;
		rTPC2.SetValue(gameObject3, value4);
		GameObject gameObject4 = characterAudioEmitter;
		int num = 0;
		if ((object)gameObject4 != null)
		{
			string text = gameObject4.ToString();
		}
		Debug.Log("AudioEmitter = " + (string)num);
		State state = roomType;
		if (state != null)
		{
			string text2 = state.ToString();
		}
		Debug.Log("RoomType = " + (string)num);
		Switch switch3 = surfaceTexture;
		if (switch3 != null)
		{
			string text3 = switch3.ToString();
		}
		Debug.Log("SurfaceType = " + (string)num);
		Switch switch4 = surfaceWetness;
		string text4 = default(string);
		if (switch4 != null)
		{
			text4 = switch4.ToString();
		}
		Debug.Log("SurfaceWetness = " + text4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x154A2D0", Offset = "0x1548CD0", VA = "0x18154A2D0")]
	private void OnValidate()
	{
		//Discarded unreachable code: IL_0135
		//IL_00ba: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		GameObject gameObject = (characterAudioEmitter = characterSpawnPosition.GetComponentInChildren<AkGameObj>().gameObject);
		Switch @switch = surfaceTexture;
		GameObject value = characterAudioEmitter;
		@switch.SetValue(value);
		Switch switch2 = surfaceWetness;
		GameObject value2 = characterAudioEmitter;
		switch2.SetValue(value2);
		roomType.SetValue();
		RTPC rTPC = avatarDistance;
		float value3 = avatarDistanceValue;
		GameObject gameObject2 = characterAudioEmitter;
		rTPC.SetValue(gameObject2, value3);
		RTPC rTPC2 = avatarDistance100m;
		float value4 = avatarDistanceValue;
		GameObject gameObject3 = characterAudioEmitter;
		rTPC2.SetValue(gameObject3, value4);
		GameObject gameObject4 = characterAudioEmitter;
		int num = 0;
		if ((object)gameObject4 != null)
		{
			string text = gameObject4.ToString();
		}
		Debug.Log("AudioEmitter = " + (string)num);
		State state = roomType;
		if (state != null)
		{
			string text2 = state.ToString();
		}
		Debug.Log("RoomType = " + (string)num);
		Switch switch3 = surfaceTexture;
		if (switch3 != null)
		{
			string text3 = switch3.ToString();
		}
		Debug.Log("SurfaceType = " + (string)num);
		Switch switch4 = surfaceWetness;
		string text4 = default(string);
		if (switch4 != null)
		{
			text4 = switch4.ToString();
		}
		Debug.Log("SurfaceWetness = " + text4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x154A6B0", Offset = "0x15490B0", VA = "0x18154A6B0")]
	public GymAnimationAudio()
	{
	}
}
