using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AudioColliderSpecific : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int fadeoutTimeS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public AK.Wwise.Event[] eventsToPlay = new AK.Wwise.Event[1];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject[] gameObjectSpecific;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private GameObject cameraPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Vector3 cameraPlayerPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int index;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool insideCollider;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA4CEF0", Offset = "0xA4B8F0", VA = "0x180A4CEF0")]
	private void Start()
	{
		//Discarded unreachable code: IL_0015
		//IL_0007: Expected I4, but got I8
		long num = default(long);
		fadeoutTimeS = (int)num;
		base.gameObject.layer = 27;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA4CAF0", Offset = "0xA4B4F0", VA = "0x180A4CAF0")]
	private void OnTriggerEnter(Collider mainCollider)
	{
		//Discarded unreachable code: IL_011c
		//IL_0114: Expected I4, but got I8
		if (mainCollider.CompareTag("MainCamera") && !insideCollider)
		{
			GameObject gameObject = base.gameObject;
			string text = base.gameObject.name;
			AKRESULT aKRESULT = AkSoundEngine.RegisterGameObj(gameObject, text);
			GameObject gameObject2 = base.gameObject;
			Transform transform = base.gameObject.transform;
			AKRESULT aKRESULT2 = AkSoundEngine.SetObjectPosition(gameObject2, transform);
			AK.Wwise.Event[] array = eventsToPlay;
			int num = 0;
			int num2 = 0;
			int length = array.Length;
			if (num < length)
			{
				GameObject[] array2 = gameObjectSpecific;
				AK.Wwise.Event @event = array[num2];
				int num3 = index;
				GameObject gameObject3 = array2[num3];
				string text2 = gameObject3.name;
				AKRESULT aKRESULT3 = AkSoundEngine.RegisterGameObj(gameObject3, text2);
				GameObject[] array3 = gameObjectSpecific;
				int num4 = index;
				GameObject gameObject4 = array3[num4];
				Transform transform2 = gameObject4.transform;
				AKRESULT aKRESULT4 = AkSoundEngine.SetObjectPosition(gameObject4, transform2);
				GameObject[] array4 = gameObjectSpecific;
				int num5 = index;
				GameObject gameObject5 = array4[num5];
				uint num6 = @event.Post(gameObject5);
				num2++;
			}
			index = 0;
			insideCollider = true;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA4CD70", Offset = "0xA4B770", VA = "0x180A4CD70")]
	private void OnTriggerExit(Collider mainCollider)
	{
		//Discarded unreachable code: IL_008f
		if (mainCollider.CompareTag("MainCamera"))
		{
			AK.Wwise.Event[] array = eventsToPlay;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				GameObject[] array2 = gameObjectSpecific;
				int num2 = index;
				AK.Wwise.Event @event = array[num];
				int transitionDuration = fadeoutTimeS;
				GameObject gameObject = array2[num2];
				@event.Stop(gameObject, transitionDuration);
				GameObject[] array3 = gameObjectSpecific;
				int num3 = index;
				AKRESULT aKRESULT = AkSoundEngine.UnregisterGameObj(array3[num3]);
				num++;
			}
			index = num;
			insideCollider = (byte)num != 0;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xA4C9A0", Offset = "0xA4B3A0", VA = "0x180A4C9A0")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_007e
		AK.Wwise.Event[] array = eventsToPlay;
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			GameObject[] array2 = gameObjectSpecific;
			int num2 = index;
			AK.Wwise.Event @event = array[num];
			int transitionDuration = fadeoutTimeS;
			GameObject gameObject = array2[num2];
			@event.Stop(gameObject, transitionDuration);
			GameObject[] array3 = gameObjectSpecific;
			int num3 = index;
			AKRESULT aKRESULT = AkSoundEngine.UnregisterGameObj(array3[num3]);
			num++;
		}
		index = num;
		insideCollider = (byte)num != 0;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA4CF30", Offset = "0xA4B930", VA = "0x180A4CF30")]
	public AudioColliderSpecific()
	{
	}
}
