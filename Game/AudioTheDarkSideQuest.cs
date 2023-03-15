using System;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AudioTheDarkSideQuest : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 boxCenter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3 boxSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public string targetGameObjectName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Switch switchOnEnter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Switch switchOnExit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public State questActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public State questInactive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public State kristoffLuth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public RTPC kristoffVolume;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool isInsideZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public AudioTheDarkSideQuest otherZonePart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private BoxCollider zone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private GameObject targetGameObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private uint currentState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private uint wolState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool firstTime;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x150B080", Offset = "0x1509A80", VA = "0x18150B080")]
	private void Start()
	{
		//Discarded unreachable code: IL_0019
		//IL_0018: Expected F4, but got I4
		RTPC rTPC = kristoffVolume;
		GameObject gameObject = targetGameObject;
		int num = 0;
		rTPC.SetValue(gameObject, num);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x150AAA0", Offset = "0x15094A0", VA = "0x18150AAA0")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_006c
		if (firstTime)
		{
			BoxCollider boxCollider = (zone = base.gameObject.AddComponent<BoxCollider>());
			BoxCollider boxCollider2 = zone;
			float z = boxCenter.z;
			BoxCollider boxCollider3 = zone;
			float z2 = boxSize.z;
			zone.isTrigger = true;
		}
		GameObject gameObject = (targetGameObject = GameObject.Find(targetGameObjectName));
		firstTime = false;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x150AA30", Offset = "0x1509430", VA = "0x18150AA30")]
	private void OnDisable()
	{
		AKRESULT aKRESULT = AkSoundEngine.SetState("MusicState", "ON");
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x150ABB0", Offset = "0x15095B0", VA = "0x18150ABB0")]
	private void OnTriggerEnter(Collider other)
	{
		bool flag = other.CompareTag("Player");
		if (!flag)
		{
			return;
		}
		State state = questActive;
		uint num = currentState;
		isInsideZone = true;
		uint id = state.Id;
		if (num != id)
		{
			State state2 = questInactive;
			uint num2 = currentState;
			uint id2 = state2.Id;
			if (num2 == id2)
			{
				Switch @switch = switchOnExit;
				GameObject value = targetGameObject;
				@switch.SetValue(value);
				AKRESULT aKRESULT = AkSoundEngine.SetState("MusicState", "ON");
				RTPC rTPC = kristoffVolume;
				GameObject gameObject = targetGameObject;
				rTPC.SetValue(gameObject, 100f);
				UnityEngine.Object.Destroy(zone);
				int num3 = ((base.enabled = false) ? 1 : 0);
			}
			return;
		}
		if ((IntPtr)other == (IntPtr)(flag ? 1 : 0))
		{
			AKRESULT aKRESULT2 = AkSoundEngine.SetState("MusicState", "OFF");
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x150AE30", Offset = "0x1509830", VA = "0x18150AE30")]
	private void OnTriggerExit(Collider other)
	{
		//Discarded unreachable code: IL_00fd
		//IL_00fc: Expected F4, but got I4
		if (!other.CompareTag("Player"))
		{
			return;
		}
		State state = questActive;
		uint num = currentState;
		isInsideZone = false;
		uint id = state.Id;
		if (num != id)
		{
			State state2 = questInactive;
			uint num2 = currentState;
			uint id2 = state2.Id;
			if (num2 == id2)
			{
				Switch @switch = switchOnExit;
				GameObject value = targetGameObject;
				@switch.SetValue(value);
				AKRESULT aKRESULT = AkSoundEngine.SetState("MusicState", "ON");
				RTPC rTPC = kristoffVolume;
				GameObject gameObject = targetGameObject;
				rTPC.SetValue(gameObject, 100f);
				UnityEngine.Object.Destroy(zone);
				int num3 = ((base.enabled = false) ? 1 : 0);
			}
		}
		else
		{
			bool flag2 = otherZonePart.isInsideZone;
			bool flag3 = base.enabled;
			while (flag2 == flag3)
			{
			}
			AKRESULT aKRESULT2 = AkSoundEngine.SetState("MusicState", "ON");
			RTPC rTPC2 = kristoffVolume;
			GameObject gameObject2 = targetGameObject;
			int num4 = 0;
			rTPC2.SetValue(gameObject2, num4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x150B0B0", Offset = "0x1509AB0", VA = "0x18150B0B0")]
	public unsafe AudioTheDarkSideQuest()
	{
		//IL_000c: Expected F4, but got I8
		//IL_0007: Expected native int or pointer, but got O
		//IL_0018: Expected F4, but got I8
		//IL_0013: Expected native int or pointer, but got O
		ulong num = default(ulong);
		((Vector3*)(IntPtr)boxCenter)->z = (long)num;
		ulong num2 = default(ulong);
		((Vector3*)(IntPtr)boxSize)->z = (long)num2;
		targetGameObjectName = "";
		firstTime = true;
		base._002Ector();
	}
}
