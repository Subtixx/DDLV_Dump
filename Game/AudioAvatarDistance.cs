using System;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AudioAvatarDistance : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private Vector3 avatarPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private string rtpcToString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float avatarDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public RTPC rtpcName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GameObject rtpcTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool forceRTPCUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool usingCulling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private SphereCollider collider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private AudioEmitterCullingManager cullingScript;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xA47C90", Offset = "0xA46690", VA = "0x180A47C90")]
	private void Start()
	{
		//Discarded unreachable code: IL_0066
		//IL_004b: Expected O, but got I4
		string text = (rtpcToString = rtpcName.Name);
		SphereCollider sphereCollider = (collider = base.gameObject.GetComponent<SphereCollider>());
		AudioEmitterCullingManager audioEmitterCullingManager = (cullingScript = base.gameObject.GetComponent<AudioEmitterCullingManager>());
		AudioEmitterCullingManager audioEmitterCullingManager2 = cullingScript;
		int num = 0;
		if (audioEmitterCullingManager2 != (UnityEngine.Object)num)
		{
			usingCulling = true;
		}
		if (forceRTPCUpdate)
		{
			usingCulling = false;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA47A70", Offset = "0xA46470", VA = "0x180A47A70")]
	private unsafe void OnTriggerStay(Collider other)
	{
		//Discarded unreachable code: IL_00c4
		//IL_0010: Expected O, but got I4
		//IL_0035: Expected native int or pointer, but got O
		SphereCollider sphereCollider = collider;
		int num = 0;
		if (!(sphereCollider == (UnityEngine.Object)num) && other.CompareTag("Player"))
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)avatarPos)->z = z;
			float z2 = vector.z;
			Transform transform = base.transform;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			SphereCollider sphereCollider2 = collider;
			float num2 = default(float);
			avatarDistance = num2;
			float radius = sphereCollider2.radius;
			if (!(num2 <= radius))
			{
				float num3 = (avatarDistance = collider.radius);
			}
			if (!usingCulling || cullingScript.isInsideCollider)
			{
				string in_pszRtpcName = rtpcToString;
				float in_value = avatarDistance;
				GameObject in_gameObjectID = rtpcTarget;
				AKRESULT aKRESULT = AkSoundEngine.SetRTPCValue(in_pszRtpcName, in_value, in_gameObjectID);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xA47960", Offset = "0xA46360", VA = "0x180A47960")]
	private void OnTriggerExit(Collider other)
	{
		//Discarded unreachable code: IL_004f
		//IL_0010: Expected O, but got I4
		SphereCollider sphereCollider = collider;
		int num = 0;
		if (!(sphereCollider == (UnityEngine.Object)num) && other.CompareTag("Player"))
		{
			float radius = collider.radius;
			string in_pszRtpcName = rtpcToString;
			avatarDistance = radius;
			GameObject in_gameObjectID = rtpcTarget;
			AKRESULT aKRESULT = AkSoundEngine.SetRTPCValue(in_pszRtpcName, radius, in_gameObjectID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioAvatarDistance()
	{
	}
}
